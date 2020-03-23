Imports System.IO
Imports ASFW.IO.Serialization

#If CLIENT Then
Public Class LanguageDef

    Public Load As New LoadDef
    Public Class LoadDef

        Public Loading As String = "Carregando..."
        Public Graphics As String = "Iniciando Graficos..."
        Public Network As String = "Conectando na rede..."
        Public Starting As String = "Jogo inciando..."

    End Class

    Public MainMenu As New MainMenuDef
    Public Class MainMenuDef

        ' TEXTO PRINCIPAL
        Public ServerStatus As String = "Status do servidor:"
        Public ServerOnline As String = "Online"
        Public ServerReconnect As String = "Reconectando..."
        Public ServerOffline As String = "Offline"
        Public ButtonPlay As String = "Jogar"
        Public ButtonRegister As String = "Registrar"
        Public ButtonCredits As String = "Creditos"
        Public ButtonExit As String = "Sair"
        Public NewsHeader As String = "Ultimas noticias"
        Public News As String = "Bemvindos ao cliente da Elysium.NET
                                 Esse é uma game engine, gratuita e open source, baseado em VB.NET
                                 Precisa de ajuda OU suporte? visite nosso forum
                                 http://www.mmodev.com.br/"

        ' TEXTO DE LOGIN
        Public Login As String = "Login"
        Public LoginName As String = "Login : "
        Public LoginPass As String = "Senha : "
        Public LoginCheckBox As String = "Salvar senha?"
        Public LoginButton As String = "Enviar"

        ' TEXTO DE NOVO PERSONAGEM
        Public NewCharacter As String = "Criar personagem"
        Public NewCharacterName As String = "Nome : "
        Public NewCharacterClass As String = "Classe : "
        Public NewCharacterGender As String = "Genero : "
        Public NewCharacterMale As String = "Masculino"
        Public NewCharacterFemale As String = "Feminino"
        Public NewCharacterSprite As String = "Sprite"
        Public NewCharacterButton As String = "Enviar"

        ' TEXTO DE SELEÇÃO DE PERSONAGENS
        Public UseCharacter As String = "Seleção de personagem"
        Public UseCharacterNew As String = "Novo personagem"
        Public UseCharacterUse As String = "Escolher personagem"
        Public UseCharacterDel As String = "Deletar personagem"

        ' TEXTO DE REGISTRO DA CONTA
        Public Register As String = "Registro de conta"
        Public RegisterName As String = "Login : "
        Public RegisterPass1 As String = "Senha : "
        ' RJK OU LUCAS, SE VIREM ISSO ESSA VARIAVEL TERIA Q TER UM NOME MAIS AMIGAVEL N?
        Public RegisterPass2 As String = "Re-digite a senha : "

        ' TEXTO DE CREDITOS
        Public Credits As String = "Creditos"

        ' TEXTOS DIVERSOS
        Public StringLegal As String = "Você não pode usar caracteres ASCII em seu nome, digite novamente por favor."
        Public SendLogin As String = "Conectado, logando na seleção de personagem..."
        Public SendNewCharacter As String = "Conectado, selecionando personagem..."
        Public SendRegister As String = "Conectado, concluindo registro..."
        Public ConnectToServer As String = "Conectando no servidor ( {0} ) ..."

    End Class

    Public Game As New GameDef
    Public Class GameDef

        Public MapName As String = "Mapa : "
        Public Time As String = "Tempo : "
        Public Fps As String = "Fps : "
        Public Lps As String = "Lps : "

        Public Ping As String = "Ping : "
        Public PingSync As String = "Sync"
        Public PingLocal As String = "Local"

        Public MapReceive As String = "Carregando mapa..."
        Public DataReceive As String = "Carregando dados..."

        Public MapCurMap As String = "Mapa # {0}"
        Public MapCurLoc As String = "Localização() x: {0} y: {1}"
        Public MapLoc As String = "Localizacao atual x: {0} y: {1}"

    End Class

    Public Chat As New ChatDef
    Public Class ChatDef

        ' Universal
        Public Emote As String = "Digite : /emote [1-11]"
        Public Info As String = "Digite : /info [player]"
        Public Party As String = "Digite : /party [player]"
        Public PlayerMsg As String = "Digite : ![player] [message]"
        Public HouseInvite As String = "Digite : /houseinvite [player]"
        Public InvalidCmd As String = "Comando invalido talquei?"
        Public Help1 As String = "Comandos sociais : "
        Public Help2 As String = "'[message] = Chat global"
        Public Help3 As String = "-[message] = Chat da party"
        Public Help4 As String = "![player] [message] = Mensagem direta"
        Public Help5 As String = "Comandos uteis: /help, /info, 
                                  /who, /fps, /lps, /stats, /trade, 
                                  /party, /join, /leave, /sellhouse, 
                                  /houseinvite"

        ' Admin-Only
        Public AccessAlert As String = "Você não tem permissão necessaria..."
        Public AdminGblMsg As String = "''msghere = Chat global como admin"
        Public AdminPvtMsg As String = "= msghere = Chat privado como admin"
        Public Admin1 As String = "omandos sociais:"
        Public Admin2 As String = "Comandos uteis /admin, /loc, 
                                   /warpmeto, /warptome, /warpto, 
                                   /sprite, /mapreport, /kick, 
                                   /ban, /respawn, /welcome, /questreset"

        Public Welcome As String = "Digite : /welcome [message]"
        Public Access As String = "Digite : /access [player] [access]"
        Public Sprite As String = "Digite : /sprite [index]"
        Public Kick As String = "Digite : /kick [player]"
        Public Ban As String = "Digite : /ban [player]"

        Public WarpMeTo As String = "Digite : /warpmeto [player]"
        Public WarpToMe As String = "Digite : /warptome [player]"
        Public WarpTo As String = "Digite : /warpto [map index]"

        Public ResetQuest As String = "Digite : /questreset [index]"

        Public InvalidMap As String = "Mapa invalido..."
        Public InvalidQuest As String = "Quest invalida..."

    End Class

    Public ItemDescription As New ItemDescriptionDef
    Public Class ItemDescriptionDef

        Public NotAvailable As String = "Não é possivel"
        Public None As String = "Zero"
        Public Seconds As String = "Segundos"

        Public Currency As String = "Moeda"
        Public Key As String = "Chave"
        Public Furniture As String = "Moveis"
        Public Potion As String = "Poção"
        Public Skill As String = "Habilidades"

        Public Weapon As String = "Equipamento"
        Public Armor As String = "Armadura"
        Public Helmet As String = "Capacete"
        Public Shield As String = "Escudo"
        Public Shoes As String = "Pés"
        Public Gloves As String = "Mãos"

        Public Amount As String = "Quantidade : "
        Public Restore As String = "Restaurar quantidade : "
        Public Damage As String = "Dano : "
        Public Defense As String = "Defesa : "

    End Class

    Public SkillDescription As New SkillDescriptionDef
    Public Class SkillDescriptionDef

        Public No As String = "No"
        Public None As String = "None"
        Public Warp As String = "Warp"
        Public Tiles As String = "Tiles"
        Public SelfCast As String = "Self-Cast"

        Public Gain As String = "Regen : "
        Public GainHp As String = "Regen Hp"
        Public GainMp As String = "Regen Mp"
        Public Lose As String = "Syphon : "
        Public LoseHp As String = "Syphon Hp"
        Public LoseMp As String = "Syphon Mp"

    End Class

    Public Crafting As New CraftingDef
    Public Class CraftingDef

        Public NotEnough As String = "Not enough materials!"
        Public NotSelected As String = "Nothing selected"

    End Class

    Public Trade As New TradeDef
    Public Class TradeDef

        Public Request As String = "{0} is requesting to trade."
        Public Timeout As String = "You took too long to decide. Please try again."

        Public Value As String = "Total Value : {0}g"

        Public StatusOther As String = "Other player confirmed offer."
        Public StatusSelf As String = "You confirmed the offer."

    End Class

    Public Events As New EventDef
    Public Class EventDef

        Public OptContinue = "- Continue -"

    End Class

    Public Quest As New QuestDef
    Public Class QuestDef

        Public Cancel As String = "Cancel Started"
        Public Started As String = "Quest Started"
        Public Completed As String = "Quest Completed"

        ' Quest Types
        Public Slay As String = "Defeat {0}/{1} {2}."
        Public Collect As String = "Collect {0}/{1} {2}."
        Public Talk As String = "Go talk To {0}."
        Public Reach As String = "Go To {0}."
        Public TurnIn As String = "Give {0} the {1} {2}/{3} they requested."
        Public Kill As String = "Defeat {0}/{1} Players In Battle."
        Public Gather As String = "Gather {0}/{1} {2}."
        Public Fetch As String = "Fetch {0} X {1} from {2}."

    End Class

    Public Character As New CharacterDef
    Public Class CharacterDef

        Public Name As String = "Name : "
        Public ClassType As String = "Class : "
        Public Level As String = "Lv : "
        Public Exp As String = "Exp : "

        Public StatsLabel As String = "== Stats =="
        Public Strength As String = "Strength : "
        Public Endurance As String = "Endurance : "
        Public Vitality As String = "Vitality : "
        Public Intelligence As String = "Intelligence : "
        Public Luck As String = "Luck : "
        Public Spirit As String = "Spirit : "
        Public Points As String = "Points Available : "

        Public SkillLabel As String = "== Skill Levels =="
        Public Herbalist As String = "Herbalist : "
        Public Woodcutter As String = "Woodcutter : "
        Public Miner As String = "Miner : "
        Public Fisherman As String = "Fisherman : "

    End Class
End Class

Friend Module modLanguage
    Public Language As New LanguageDef

    Friend Sub LoadLanguage()
        Dim cf As String = Path.Config() & "\Languages\"
        If Not Directory.Exists(cf) Then
            Directory.CreateDirectory(cf)
        End If : cf = cf & Settings.Language & ".xml"

        If Not File.Exists(cf) Then
            File.Create(cf).Dispose()
            SaveXml(Of LanguageDef)(cf, New LanguageDef)
        End If : Language = LoadXml(Of LanguageDef)(cf)
    End Sub
End Module
#End If