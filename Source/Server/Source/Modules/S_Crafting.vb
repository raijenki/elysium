Imports System.IO
Imports ASFW
Imports ASFW.IO.FileIO

Friend Module modCrafting

#Region "Globals"

    Friend Recipe(MAX_RECIPE) As RecipeRec

    Friend Const RecipeType_Herb As Byte = 0
    Friend Const RecipeType_Wood As Byte = 1
    Friend Const RecipeType_Metal As Byte = 2

    Friend Structure RecipeRec
        Dim Name As String
        Dim RecipeType As Byte
        Dim MakeItemNum As Integer
        Dim MakeItemAmount As Integer
        Dim Ingredients() As IngredientsRec
        Dim CreateTime As Byte
    End Structure

    Friend Structure IngredientsRec
        Dim ItemNum As Integer
        Dim Value As Integer
    End Structure

#End Region

#Region "Database"

    Sub CheckRecipes()
        Dim i As Integer

        For i = 1 To MAX_RECIPE
            If Not File.Exists(Path.Recipe(i)) Then
                SaveRecipe(i)
                Application.DoEvents()
            End If
        Next

    End Sub

    Sub SaveRecipes()
        Dim i As Integer

        For i = 1 To MAX_RECIPE
            SaveRecipe(i)
            Application.DoEvents()
        Next

    End Sub

    Sub SaveRecipe(RecipeNum As Integer)
        Dim filename As String
        Dim i As Integer

        filename = Path.Recipe(RecipeNum)

        Dim writer As New ByteStream(100)

        writer.WriteString(Recipe(RecipeNum).Name)
        writer.WriteByte(Recipe(RecipeNum).RecipeType)
        writer.WriteInt32(Recipe(RecipeNum).MakeItemNum)
        writer.WriteInt32(Recipe(RecipeNum).MakeItemAmount)

        For i = 1 To MAX_INGREDIENT
            writer.WriteInt32(Recipe(RecipeNum).Ingredients(i).ItemNum)
            writer.WriteInt32(Recipe(RecipeNum).Ingredients(i).Value)
        Next

        writer.WriteByte(Recipe(RecipeNum).CreateTime)

        BinaryFile.Save(filename, writer)
    End Sub

    Sub LoadRecipes()
        Dim i As Integer

        For i = 1 To MAX_RECIPE
            LoadRecipe(i)
            Application.DoEvents()
        Next

    End Sub

    Sub LoadRecipe(RecipeNum As Integer)
        Dim filename As String
        Dim i As Integer

        CheckRecipes()

        filename = Path.Recipe(RecipeNum)
        Dim reader As New ByteStream()
        BinaryFile.Load(filename, reader)

        Recipe(RecipeNum).Name = reader.ReadString()
        Recipe(RecipeNum).RecipeType = reader.ReadByte()
        Recipe(RecipeNum).MakeItemNum = reader.ReadInt32()
        Recipe(RecipeNum).MakeItemAmount = reader.ReadInt32()

        ReDim Recipe(RecipeNum).Ingredients(MAX_INGREDIENT)
        For i = 1 To MAX_INGREDIENT
            Recipe(RecipeNum).Ingredients(i).ItemNum = reader.ReadInt32()
            Recipe(RecipeNum).Ingredients(i).Value = reader.ReadInt32()
        Next

        Recipe(RecipeNum).CreateTime = reader.ReadByte()

    End Sub

    Sub ClearRecipes()
        Dim i As Integer

        For i = 1 To MAX_RECIPE
            ClearRecipe(i)
            Application.DoEvents()
        Next

    End Sub

    Sub ClearRecipe(Num As Integer)
        Recipe(Num).Name = ""
        Recipe(Num).RecipeType = 0
        Recipe(Num).MakeItemNum = 0
        Recipe(Num).MakeItemAmount = 0
        Recipe(Num).CreateTime = 0
        ReDim Recipe(Num).Ingredients(MAX_INGREDIENT)
    End Sub

#End Region

#Region "Incoming Packets"

    Sub Packet_RequestRecipes(index As Integer, ByRef data() As Byte)
        AddDebug("Recebida CMSG: CRequestRecipes")

        SendRecipes(index)
    End Sub

    Sub Packet_RequestEditRecipes(index As Integer, ByRef data() As Byte)
        ' Prevenir hacking
        If GetPlayerAccess(index) < AdminType.Developer Then Exit Sub

        Dim Buffer = New ByteStream(4)
        Buffer.WriteInt32(ServerPackets.SRecipeEditor)
        Socket.SendDataTo(index, Buffer.Data, Buffer.Head)

        AddDebug("Enviada SMSG: SRecipeEditor")

        Buffer.Dispose()

    End Sub

    Sub Packet_SaveRecipe(index As Integer, ByRef data() As Byte)
        Dim n As Integer

        ' Prevenir hacking
        If GetPlayerAccess(index) < AdminType.Developer Then Exit Sub
        Dim buffer As New ByteStream(data)
        AddDebug("Recebida EMSG: SaveRecipe")

        'Índice da receita
        n = buffer.ReadInt32

        ' Atualizar a receita
        Recipe(n).Name = buffer.ReadString
        Recipe(n).RecipeType = buffer.ReadInt32
        Recipe(n).MakeItemNum = buffer.ReadInt32
        Recipe(n).MakeItemAmount = buffer.ReadInt32

        For i = 1 To MAX_INGREDIENT
            Recipe(n).Ingredients(i).ItemNum = buffer.ReadInt32()
            Recipe(n).Ingredients(i).Value = buffer.ReadInt32()
        Next

        Recipe(n).CreateTime = buffer.ReadInt32

        'Salvar
        SaveRecipe(n)

        'Enviar a todos
        SendUpdateRecipeToAll(n)

        buffer.Dispose()

    End Sub

    Sub Packet_CloseCraft(index As Integer, ByRef data() As Byte)
        AddDebug("Recebida CMSG: CCloseCraft")

        TempPlayer(index).IsCrafting = False
    End Sub

    Sub Packet_StartCraft(index As Integer, ByRef data() As Byte)
        Dim recipeindex As Integer, amount As Integer
        Dim buffer As New ByteStream(data)

        AddDebug("Recebida CMSG: CStartCraft")

        recipeindex = buffer.ReadInt32
        amount = buffer.ReadInt32

        If TempPlayer(index).IsCrafting = False Then Exit Sub

        If recipeindex = 0 OrElse amount = 0 Then Exit Sub

        If Not CheckLearnedRecipe(index, recipeindex) Then Exit Sub

        StartCraft(index, recipeindex, amount)

        buffer.Dispose()

    End Sub

#End Region

#Region "Outgoing Packets"

    Sub SendRecipes(index As Integer)
        Dim i As Integer

        For i = 1 To MAX_RECIPE

            If Len(Trim$(Recipe(i).Name)) > 0 Then
                SendUpdateRecipeTo(index, i)
            End If

        Next

    End Sub

    Sub SendUpdateRecipeTo(index As Integer, RecipeNum As Integer)
        Dim buffer As ByteStream, i As Integer
        buffer = New ByteStream(4)
        buffer.WriteInt32(ServerPackets.SUpdateRecipe)
        buffer.WriteInt32(RecipeNum)

        AddDebug("Enviada SMSG: SUpdateRecipe")

        buffer.WriteString((Trim$(Recipe(RecipeNum).Name)))
        buffer.WriteInt32(Recipe(RecipeNum).RecipeType)
        buffer.WriteInt32(Recipe(RecipeNum).MakeItemNum)
        buffer.WriteInt32(Recipe(RecipeNum).MakeItemAmount)

        For i = 1 To MAX_INGREDIENT
            buffer.WriteInt32(Recipe(RecipeNum).Ingredients(i).ItemNum)
            buffer.WriteInt32(Recipe(RecipeNum).Ingredients(i).Value)
        Next

        buffer.WriteInt32(Recipe(RecipeNum).CreateTime)

        Socket.SendDataTo(index, buffer.Data, buffer.Head)

        buffer.Dispose()
    End Sub

    Sub SendUpdateRecipeToAll(RecipeNum As Integer)
        Dim buffer As ByteStream
        buffer = New ByteStream(4)
        buffer.WriteInt32(ServerPackets.SUpdateRecipe)
        buffer.WriteInt32(RecipeNum)

        AddDebug("Enviada SMSG: SUpdateRecipe To All")

        buffer.WriteString((Trim$(Recipe(RecipeNum).Name)))
        buffer.WriteInt32(Recipe(RecipeNum).RecipeType)
        buffer.WriteInt32(Recipe(RecipeNum).MakeItemNum)
        buffer.WriteInt32(Recipe(RecipeNum).MakeItemAmount)

        For i = 1 To MAX_INGREDIENT
            buffer.WriteInt32(Recipe(RecipeNum).Ingredients(i).ItemNum)
            buffer.WriteInt32(Recipe(RecipeNum).Ingredients(i).Value)
        Next

        buffer.WriteInt32(Recipe(RecipeNum).CreateTime)

        SendDataToAll(buffer.Data, buffer.Head)

        buffer.Dispose()
    End Sub

    Sub SendPlayerRecipes(index As Integer)
        Dim i As Integer
        Dim buffer As ByteStream
        buffer = New ByteStream(4)
        buffer.WriteInt32(ServerPackets.SSendPlayerRecipe)

        AddDebug("Enviada SMSG: SSendPlayerRecipe")

        For i = 1 To MAX_RECIPE
            buffer.WriteInt32(Player(index).Character(TempPlayer(index).CurChar).RecipeLearned(i))
        Next

        Socket.SendDataTo(index, buffer.Data, buffer.Head)

        buffer.Dispose()
    End Sub

    Sub SendOpenCraft(index As Integer)
        Dim buffer As ByteStream
        buffer = New ByteStream(4)
        buffer.WriteInt32(ServerPackets.SOpenCraft)

        AddDebug("Enviada SMSG: SOpenCraft")

        Socket.SendDataTo(index, buffer.Data, buffer.Head)

        buffer.Dispose()
    End Sub

    Sub SendCraftUpdate(index As Integer, done As Byte)
        Dim buffer As ByteStream
        buffer = New ByteStream(4)
        buffer.WriteInt32(ServerPackets.SUpdateCraft)

        AddDebug("Enviada SMSG: SUpdateCraft")

        buffer.WriteInt32(done)

        Socket.SendDataTo(index, buffer.Data, buffer.Head)

        buffer.Dispose()
    End Sub

#End Region

#Region "Functions"

    Friend Function CheckLearnedRecipe(index As Integer, RecipeNum As Integer) As Boolean
        CheckLearnedRecipe = False

        If Player(index).Character(TempPlayer(index).CurChar).RecipeLearned(RecipeNum) = 1 Then
            CheckLearnedRecipe = True
        End If
    End Function

    Friend Sub LearnRecipe(index As Integer, RecipeNum As Integer, InvNum As Integer)
        If CheckLearnedRecipe(index, RecipeNum) Then ' já conhecemos esta
            PlayerMsg(index, "Você já conhece esta receita!", ColorType.BrightRed)
        Else ' caso contrário, vamos aprender
            Player(index).Character(TempPlayer(index).CurChar).RecipeLearned(RecipeNum) = 1

            PlayerMsg(index, "Você aprendeu a receita " & Recipe(RecipeNum).Name & "!", ColorType.BrightGreen)

            TakeInvItem(index, GetPlayerInvItemNum(index, InvNum), 0)

            SavePlayer(index)
            SendPlayerData(index)
        End If
    End Sub

    Friend Sub StartCraft(index As Integer, RecipeNum As Integer, Amount As Integer)

        If TempPlayer?(index).IsCrafting Then
            TempPlayer(index).CraftRecipe = RecipeNum
            TempPlayer(index).CraftAmount = Amount

            TempPlayer(index).CraftTimer = GetTimeMs()
            TempPlayer(index).CraftTimeNeeded = Recipe(RecipeNum).CreateTime

            TempPlayer(index).CraftIt = 1
        End If

    End Sub

    Friend Sub UpdateCraft(index As Integer)
        Dim i As Integer

        'certo, fizemos o item, dar o item e tomar os ingredientes
        If GiveInvItem(index, Recipe(TempPlayer(index).CraftRecipe).MakeItemNum, Recipe(TempPlayer(index).CraftRecipe).MakeItemAmount, True) Then
            For i = 1 To MAX_INGREDIENT
                TakeInvItem(index, Recipe(TempPlayer(index).CraftRecipe).Ingredients(i).ItemNum, Recipe(TempPlayer(index).CraftRecipe).Ingredients(i).Value)
            Next
            PlayerMsg(index, "Você criou " & Trim(Item(Recipe(TempPlayer(index).CraftRecipe).MakeItemNum).Name) & " X " & Recipe(TempPlayer(index).CraftRecipe).MakeItemAmount, ColorType.BrightGreen)
        End If

        If TempPlayer?(index).IsCrafting Then
            TempPlayer(index).CraftAmount = TempPlayer(index).CraftAmount - 1

            If TempPlayer(index).CraftAmount > 0 Then
                TempPlayer(index).CraftTimer = GetTimeMs()
                TempPlayer(index).CraftTimeNeeded = Recipe(TempPlayer(index).CraftRecipe).CreateTime

                TempPlayer(index).CraftIt = 1

                SendCraftUpdate(index, 0)
            End If

            SendCraftUpdate(index, 1)
        End If

    End Sub

#End Region

End Module