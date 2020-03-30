Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditor_Events
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Show Text")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Show Choices")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Chatbox Text")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Show ChatBubble")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mensagens", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Player Variable")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Player Switch")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Self Switch")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Processamento de Evento", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Conditional Branch")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stop Event Processing")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Label")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GoTo Label")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Controle de Fluxo", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Items")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Restore HP")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Restore MP")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Level Up")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Level")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Skills")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Class")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Sprite")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Gender")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change PK")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Give Experience")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opções do Jogador", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Warp Player")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Move Route")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Wait for Route Completion")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Force Spawn Npc")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hold Player")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Release Player")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Movimento", New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode31, TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Animation")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Animação", New System.Windows.Forms.TreeNode() {TreeNode34})
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Begin Quest")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Complete Task")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("End Quest")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Questing", New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode37, TreeNode38})
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Fog")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Weather")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Map Tinting")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Funções de Mapa", New System.Windows.Forms.TreeNode() {TreeNode40, TreeNode41, TreeNode42})
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Play BGM")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stop BGM")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Play Sound")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stop Sounds")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Músicas e Sons", New System.Windows.Forms.TreeNode() {TreeNode44, TreeNode45, TreeNode46, TreeNode47})
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Wait...")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Access")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Custom Script")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Etc...", New System.Windows.Forms.TreeNode() {TreeNode49, TreeNode50, TreeNode51})
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Open Bank")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Open Shop")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Loja e Banco", New System.Windows.Forms.TreeNode() {TreeNode53, TreeNode54})
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fade In")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fade Out")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opções de Cutscenes", New System.Windows.Forms.TreeNode() {TreeNode56, TreeNode57})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditor_Events))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Movement", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Wait", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Turning", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Speed", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Walk Animation", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Fixed Direction", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup7 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("WalkThrough", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup8 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Set Position", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup9 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Set Graphic", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Move Up")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Move Down")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Move left")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Move Right")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Move Randomly")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Move To Player***")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Move from Player***")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Step Forwards")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Step Backwards")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Wait 100Ms")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Wait 500Ms")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Wait 1000Ms")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn Up")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn Down")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn Left")
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn Right")
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn 90DG Right")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn 90DG Left")
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn 180DG")
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn Randomly")
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn To Player***")
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Turn From Player***")
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Speed 8x Slower")
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Speed 4x Slower")
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Speed 2x Slower")
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Speed To Normal")
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Speed 2x Faster")
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Speed 4x Faster")
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Freq. To Lowest")
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Freq. To Lower")
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Freq. To Normal")
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Freq. To Higher")
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Freq. To Highest")
        Dim ListViewItem34 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Walking Animation ON")
        Dim ListViewItem35 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Walking Animation OFF")
        Dim ListViewItem36 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Fixed Direction ON")
        Dim ListViewItem37 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Fixed Direction OFF")
        Dim ListViewItem38 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Walkthrough ON")
        Dim ListViewItem39 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Walkthrough ON")
        Dim ListViewItem40 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Position Below Player")
        Dim ListViewItem41 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set PositionWith Player")
        Dim ListViewItem42 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Position Above Player")
        Dim ListViewItem43 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Set Graphic...")
        Me.tvCommands = New System.Windows.Forms.TreeView()
        Me.fraPageSetUp = New DarkUI.Controls.DarkGroupBox()
        Me.chkGlobal = New DarkUI.Controls.DarkCheckBox()
        Me.btnClearPage = New DarkUI.Controls.DarkButton()
        Me.btnDeletePage = New DarkUI.Controls.DarkButton()
        Me.btnPastePage = New DarkUI.Controls.DarkButton()
        Me.btnCopyPage = New DarkUI.Controls.DarkButton()
        Me.btnNewPage = New DarkUI.Controls.DarkButton()
        Me.txtName = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel1 = New DarkUI.Controls.DarkLabel()
        Me.tabPages = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlTabPage = New System.Windows.Forms.Panel()
        Me.fraCommands = New System.Windows.Forms.Panel()
        Me.btnCancelCommand = New DarkUI.Controls.DarkButton()
        Me.DarkGroupBox8 = New DarkUI.Controls.DarkGroupBox()
        Me.btnClearCommand = New DarkUI.Controls.DarkButton()
        Me.btnDeleteCommand = New DarkUI.Controls.DarkButton()
        Me.btnEditCommand = New DarkUI.Controls.DarkButton()
        Me.btnAddCommand = New DarkUI.Controls.DarkButton()
        Me.lstCommands = New System.Windows.Forms.ListBox()
        Me.DarkLabel10 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel9 = New DarkUI.Controls.DarkLabel()
        Me.DarkGroupBox7 = New DarkUI.Controls.DarkGroupBox()
        Me.cmbEventQuest = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel8 = New DarkUI.Controls.DarkLabel()
        Me.DarkGroupBox5 = New DarkUI.Controls.DarkGroupBox()
        Me.cmbTrigger = New DarkUI.Controls.DarkComboBox()
        Me.DarkGroupBox4 = New DarkUI.Controls.DarkGroupBox()
        Me.cmbPositioning = New DarkUI.Controls.DarkComboBox()
        Me.DarkGroupBox3 = New DarkUI.Controls.DarkGroupBox()
        Me.DarkLabel7 = New DarkUI.Controls.DarkLabel()
        Me.cmbMoveFreq = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel6 = New DarkUI.Controls.DarkLabel()
        Me.cmbMoveSpeed = New DarkUI.Controls.DarkComboBox()
        Me.btnMoveRoute = New DarkUI.Controls.DarkButton()
        Me.cmbMoveType = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel5 = New DarkUI.Controls.DarkLabel()
        Me.DarkGroupBox2 = New DarkUI.Controls.DarkGroupBox()
        Me.picGraphic = New System.Windows.Forms.PictureBox()
        Me.DarkGroupBox1 = New DarkUI.Controls.DarkGroupBox()
        Me.cmbSelfSwitchCompare = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel4 = New DarkUI.Controls.DarkLabel()
        Me.cmbSelfSwitch = New DarkUI.Controls.DarkComboBox()
        Me.chkSelfSwitch = New DarkUI.Controls.DarkCheckBox()
        Me.cmbHasItem = New DarkUI.Controls.DarkComboBox()
        Me.chkHasItem = New DarkUI.Controls.DarkCheckBox()
        Me.cmbPlayerSwitchCompare = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel3 = New DarkUI.Controls.DarkLabel()
        Me.cmbPlayerSwitch = New DarkUI.Controls.DarkComboBox()
        Me.chkPlayerSwitch = New DarkUI.Controls.DarkCheckBox()
        Me.nudPlayerVariable = New DarkUI.Controls.DarkNumericUpDown()
        Me.cmbPlayervarCompare = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel2 = New DarkUI.Controls.DarkLabel()
        Me.cmbPlayerVar = New DarkUI.Controls.DarkComboBox()
        Me.chkPlayerVar = New DarkUI.Controls.DarkCheckBox()
        Me.DarkGroupBox6 = New DarkUI.Controls.DarkGroupBox()
        Me.chkShowName = New DarkUI.Controls.DarkCheckBox()
        Me.chkWalkThrough = New DarkUI.Controls.DarkCheckBox()
        Me.chkDirFix = New DarkUI.Controls.DarkCheckBox()
        Me.chkWalkAnim = New DarkUI.Controls.DarkCheckBox()
        Me.btnLabeling = New DarkUI.Controls.DarkButton()
        Me.btnCancel = New DarkUI.Controls.DarkButton()
        Me.btnOk = New DarkUI.Controls.DarkButton()
        Me.fraMoveRoute = New DarkUI.Controls.DarkGroupBox()
        Me.btnMoveRouteOk = New DarkUI.Controls.DarkButton()
        Me.btnMoveRouteCancel = New DarkUI.Controls.DarkButton()
        Me.chkRepeatRoute = New DarkUI.Controls.DarkCheckBox()
        Me.chkIgnoreMove = New DarkUI.Controls.DarkCheckBox()
        Me.DarkGroupBox10 = New DarkUI.Controls.DarkGroupBox()
        Me.lstvwMoveRoute = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstMoveRoute = New System.Windows.Forms.ListBox()
        Me.cmbEvent = New DarkUI.Controls.DarkComboBox()
        Me.fraGraphic = New DarkUI.Controls.DarkGroupBox()
        Me.pnlGraphicSel = New System.Windows.Forms.Panel()
        Me.picGraphicSel = New System.Windows.Forms.PictureBox()
        Me.btnGraphicOk = New DarkUI.Controls.DarkButton()
        Me.btnGraphicCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel13 = New DarkUI.Controls.DarkLabel()
        Me.nudGraphic = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel12 = New DarkUI.Controls.DarkLabel()
        Me.cmbGraphic = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel11 = New DarkUI.Controls.DarkLabel()
        Me.fraDialogue = New DarkUI.Controls.DarkGroupBox()
        Me.fraConditionalBranch = New DarkUI.Controls.DarkGroupBox()
        Me.cmbCondition_Time = New DarkUI.Controls.DarkComboBox()
        Me.optCondition9 = New DarkUI.Controls.DarkRadioButton()
        Me.btnConditionalBranchOk = New DarkUI.Controls.DarkButton()
        Me.btnConditionalBranchCancel = New DarkUI.Controls.DarkButton()
        Me.cmbCondition_Gender = New DarkUI.Controls.DarkComboBox()
        Me.optCondition8 = New DarkUI.Controls.DarkRadioButton()
        Me.fraConditions_Quest = New DarkUI.Controls.DarkGroupBox()
        Me.DarkLabel20 = New DarkUI.Controls.DarkLabel()
        Me.nudCondition_QuestTask = New DarkUI.Controls.DarkNumericUpDown()
        Me.cmbCondition_General = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel19 = New DarkUI.Controls.DarkLabel()
        Me.optCondition_Quest1 = New DarkUI.Controls.DarkRadioButton()
        Me.optCondition_Quest0 = New DarkUI.Controls.DarkRadioButton()
        Me.nudCondition_Quest = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel18 = New DarkUI.Controls.DarkLabel()
        Me.optCondition7 = New DarkUI.Controls.DarkRadioButton()
        Me.cmbCondition_SelfSwitchCondition = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel17 = New DarkUI.Controls.DarkLabel()
        Me.cmbCondition_SelfSwitch = New DarkUI.Controls.DarkComboBox()
        Me.optCondition6 = New DarkUI.Controls.DarkRadioButton()
        Me.nudCondition_LevelAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.optCondition5 = New DarkUI.Controls.DarkRadioButton()
        Me.cmbCondition_LevelCompare = New DarkUI.Controls.DarkComboBox()
        Me.cmbCondition_LearntSkill = New DarkUI.Controls.DarkComboBox()
        Me.optCondition4 = New DarkUI.Controls.DarkRadioButton()
        Me.cmbCondition_ClassIs = New DarkUI.Controls.DarkComboBox()
        Me.optCondition3 = New DarkUI.Controls.DarkRadioButton()
        Me.nudCondition_HasItem = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel16 = New DarkUI.Controls.DarkLabel()
        Me.cmbCondition_HasItem = New DarkUI.Controls.DarkComboBox()
        Me.optCondition2 = New DarkUI.Controls.DarkRadioButton()
        Me.optCondition1 = New DarkUI.Controls.DarkRadioButton()
        Me.DarkLabel15 = New DarkUI.Controls.DarkLabel()
        Me.cmbCondtion_PlayerSwitchCondition = New DarkUI.Controls.DarkComboBox()
        Me.cmbCondition_PlayerSwitch = New DarkUI.Controls.DarkComboBox()
        Me.nudCondition_PlayerVarCondition = New DarkUI.Controls.DarkNumericUpDown()
        Me.cmbCondition_PlayerVarCompare = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel14 = New DarkUI.Controls.DarkLabel()
        Me.cmbCondition_PlayerVarIndex = New DarkUI.Controls.DarkComboBox()
        Me.optCondition0 = New DarkUI.Controls.DarkRadioButton()
        Me.fraPlayAnimation = New DarkUI.Controls.DarkGroupBox()
        Me.btnPlayAnimationOk = New DarkUI.Controls.DarkButton()
        Me.btnPlayAnimationCancel = New DarkUI.Controls.DarkButton()
        Me.lblPlayAnimY = New DarkUI.Controls.DarkLabel()
        Me.lblPlayAnimX = New DarkUI.Controls.DarkLabel()
        Me.cmbPlayAnimEvent = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel62 = New DarkUI.Controls.DarkLabel()
        Me.cmbAnimTargetType = New DarkUI.Controls.DarkComboBox()
        Me.nudPlayAnimTileY = New DarkUI.Controls.DarkNumericUpDown()
        Me.nudPlayAnimTileX = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel61 = New DarkUI.Controls.DarkLabel()
        Me.cmbPlayAnim = New DarkUI.Controls.DarkComboBox()
        Me.fraMoveRouteWait = New DarkUI.Controls.DarkGroupBox()
        Me.btnMoveWaitCancel = New DarkUI.Controls.DarkButton()
        Me.btnMoveWaitOk = New DarkUI.Controls.DarkButton()
        Me.DarkLabel79 = New DarkUI.Controls.DarkLabel()
        Me.cmbMoveWait = New DarkUI.Controls.DarkComboBox()
        Me.fraCustomScript = New DarkUI.Controls.DarkGroupBox()
        Me.nudCustomScript = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel78 = New DarkUI.Controls.DarkLabel()
        Me.btnCustomScriptCancel = New DarkUI.Controls.DarkButton()
        Me.btnCustomScriptOk = New DarkUI.Controls.DarkButton()
        Me.fraSetWeather = New DarkUI.Controls.DarkGroupBox()
        Me.btnSetWeatherOk = New DarkUI.Controls.DarkButton()
        Me.btnSetWeatherCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel76 = New DarkUI.Controls.DarkLabel()
        Me.nudWeatherIntensity = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel75 = New DarkUI.Controls.DarkLabel()
        Me.CmbWeather = New DarkUI.Controls.DarkComboBox()
        Me.fraSpawnNpc = New DarkUI.Controls.DarkGroupBox()
        Me.btnSpawnNpcOk = New DarkUI.Controls.DarkButton()
        Me.btnSpawnNpcCancel = New DarkUI.Controls.DarkButton()
        Me.cmbSpawnNpc = New DarkUI.Controls.DarkComboBox()
        Me.fraGiveExp = New DarkUI.Controls.DarkGroupBox()
        Me.btnGiveExpOk = New DarkUI.Controls.DarkButton()
        Me.btnGiveExpCancel = New DarkUI.Controls.DarkButton()
        Me.nudGiveExp = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel77 = New DarkUI.Controls.DarkLabel()
        Me.fraEndQuest = New DarkUI.Controls.DarkGroupBox()
        Me.btnEndQuestOk = New DarkUI.Controls.DarkButton()
        Me.btnEndQuestCancel = New DarkUI.Controls.DarkButton()
        Me.cmbEndQuest = New DarkUI.Controls.DarkComboBox()
        Me.fraSetAccess = New DarkUI.Controls.DarkGroupBox()
        Me.btnSetAccessOk = New DarkUI.Controls.DarkButton()
        Me.btnSetAccessCancel = New DarkUI.Controls.DarkButton()
        Me.cmbSetAccess = New DarkUI.Controls.DarkComboBox()
        Me.fraSetWait = New DarkUI.Controls.DarkGroupBox()
        Me.btnSetWaitOk = New DarkUI.Controls.DarkButton()
        Me.btnSetWaitCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel74 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel72 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel73 = New DarkUI.Controls.DarkLabel()
        Me.nudWaitAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.fraShowPic = New DarkUI.Controls.DarkGroupBox()
        Me.btnShowPicOk = New DarkUI.Controls.DarkButton()
        Me.btnShowPicCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel71 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel70 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel67 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel68 = New DarkUI.Controls.DarkLabel()
        Me.nudPicOffsetY = New DarkUI.Controls.DarkNumericUpDown()
        Me.nudPicOffsetX = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel69 = New DarkUI.Controls.DarkLabel()
        Me.cmbPicLoc = New DarkUI.Controls.DarkComboBox()
        Me.nudShowPicture = New DarkUI.Controls.DarkNumericUpDown()
        Me.picShowPic = New System.Windows.Forms.PictureBox()
        Me.cmbPicIndex = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel66 = New DarkUI.Controls.DarkLabel()
        Me.fraOpenShop = New DarkUI.Controls.DarkGroupBox()
        Me.btnOpenShopOk = New DarkUI.Controls.DarkButton()
        Me.btnOpenShopCancel = New DarkUI.Controls.DarkButton()
        Me.cmbOpenShop = New DarkUI.Controls.DarkComboBox()
        Me.fraChangeLevel = New DarkUI.Controls.DarkGroupBox()
        Me.btnChangeLevelOk = New DarkUI.Controls.DarkButton()
        Me.btnChangeLevelCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel65 = New DarkUI.Controls.DarkLabel()
        Me.nudChangeLevel = New DarkUI.Controls.DarkNumericUpDown()
        Me.fraChangeGender = New DarkUI.Controls.DarkGroupBox()
        Me.btnChangeGenderOk = New DarkUI.Controls.DarkButton()
        Me.btnChangeGenderCancel = New DarkUI.Controls.DarkButton()
        Me.optChangeSexFemale = New DarkUI.Controls.DarkRadioButton()
        Me.optChangeSexMale = New DarkUI.Controls.DarkRadioButton()
        Me.fraGoToLabel = New DarkUI.Controls.DarkGroupBox()
        Me.btnGoToLabelOk = New DarkUI.Controls.DarkButton()
        Me.btnGoToLabelCancel = New DarkUI.Controls.DarkButton()
        Me.txtGotoLabel = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel60 = New DarkUI.Controls.DarkLabel()
        Me.fraHidePic = New DarkUI.Controls.DarkGroupBox()
        Me.btnHidePicOk = New DarkUI.Controls.DarkButton()
        Me.btnHidePicCancel = New DarkUI.Controls.DarkButton()
        Me.nudHidePic = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel59 = New DarkUI.Controls.DarkLabel()
        Me.fraBeginQuest = New DarkUI.Controls.DarkGroupBox()
        Me.btnBeginQuestOk = New DarkUI.Controls.DarkButton()
        Me.btnBeginQuestCancel = New DarkUI.Controls.DarkButton()
        Me.cmbBeginQuest = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel58 = New DarkUI.Controls.DarkLabel()
        Me.fraShowChoices = New DarkUI.Controls.DarkGroupBox()
        Me.txtChoices4 = New DarkUI.Controls.DarkTextBox()
        Me.txtChoices3 = New DarkUI.Controls.DarkTextBox()
        Me.txtChoices2 = New DarkUI.Controls.DarkTextBox()
        Me.txtChoices1 = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel56 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel57 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel55 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel54 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel52 = New DarkUI.Controls.DarkLabel()
        Me.txtChoicePrompt = New DarkUI.Controls.DarkTextBox()
        Me.btnShowChoicesOk = New DarkUI.Controls.DarkButton()
        Me.picShowChoicesFace = New System.Windows.Forms.PictureBox()
        Me.btnShowChoicesCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel53 = New DarkUI.Controls.DarkLabel()
        Me.nudShowChoicesFace = New DarkUI.Controls.DarkNumericUpDown()
        Me.fraPlayerVariable = New DarkUI.Controls.DarkGroupBox()
        Me.nudVariableData2 = New DarkUI.Controls.DarkNumericUpDown()
        Me.optVariableAction2 = New DarkUI.Controls.DarkRadioButton()
        Me.btnPlayerVarOk = New DarkUI.Controls.DarkButton()
        Me.btnPlayerVarCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel51 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel50 = New DarkUI.Controls.DarkLabel()
        Me.nudVariableData4 = New DarkUI.Controls.DarkNumericUpDown()
        Me.nudVariableData3 = New DarkUI.Controls.DarkNumericUpDown()
        Me.optVariableAction3 = New DarkUI.Controls.DarkRadioButton()
        Me.optVariableAction1 = New DarkUI.Controls.DarkRadioButton()
        Me.nudVariableData1 = New DarkUI.Controls.DarkNumericUpDown()
        Me.nudVariableData0 = New DarkUI.Controls.DarkNumericUpDown()
        Me.optVariableAction0 = New DarkUI.Controls.DarkRadioButton()
        Me.cmbVariable = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel49 = New DarkUI.Controls.DarkLabel()
        Me.fraChangeSprite = New DarkUI.Controls.DarkGroupBox()
        Me.btnChangeSpriteOk = New DarkUI.Controls.DarkButton()
        Me.btnChangeSpriteCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel48 = New DarkUI.Controls.DarkLabel()
        Me.nudChangeSprite = New DarkUI.Controls.DarkNumericUpDown()
        Me.picChangeSprite = New System.Windows.Forms.PictureBox()
        Me.fraSetSelfSwitch = New DarkUI.Controls.DarkGroupBox()
        Me.btnSelfswitchOk = New DarkUI.Controls.DarkButton()
        Me.btnSelfswitchCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel47 = New DarkUI.Controls.DarkLabel()
        Me.cmbSetSelfSwitchTo = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel46 = New DarkUI.Controls.DarkLabel()
        Me.cmbSetSelfSwitch = New DarkUI.Controls.DarkComboBox()
        Me.fraMapTint = New DarkUI.Controls.DarkGroupBox()
        Me.btnMapTintOk = New DarkUI.Controls.DarkButton()
        Me.btnMapTintCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel42 = New DarkUI.Controls.DarkLabel()
        Me.nudMapTintData3 = New DarkUI.Controls.DarkNumericUpDown()
        Me.nudMapTintData2 = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel43 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel44 = New DarkUI.Controls.DarkLabel()
        Me.nudMapTintData1 = New DarkUI.Controls.DarkNumericUpDown()
        Me.nudMapTintData0 = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel45 = New DarkUI.Controls.DarkLabel()
        Me.fraShowChatBubble = New DarkUI.Controls.DarkGroupBox()
        Me.btnShowChatBubbleOk = New DarkUI.Controls.DarkButton()
        Me.btnShowChatBubbleCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel41 = New DarkUI.Controls.DarkLabel()
        Me.cmbChatBubbleTarget = New DarkUI.Controls.DarkComboBox()
        Me.cmbChatBubbleTargetType = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel40 = New DarkUI.Controls.DarkLabel()
        Me.txtChatbubbleText = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel39 = New DarkUI.Controls.DarkLabel()
        Me.fraPlaySound = New DarkUI.Controls.DarkGroupBox()
        Me.btnPlaySoundOk = New DarkUI.Controls.DarkButton()
        Me.btnPlaySoundCancel = New DarkUI.Controls.DarkButton()
        Me.cmbPlaySound = New DarkUI.Controls.DarkComboBox()
        Me.fraChangePK = New DarkUI.Controls.DarkGroupBox()
        Me.btnChangePkOk = New DarkUI.Controls.DarkButton()
        Me.btnChangePkCancel = New DarkUI.Controls.DarkButton()
        Me.cmbSetPK = New DarkUI.Controls.DarkComboBox()
        Me.fraCreateLabel = New DarkUI.Controls.DarkGroupBox()
        Me.btnCreatelabelOk = New DarkUI.Controls.DarkButton()
        Me.btnCreatelabelCancel = New DarkUI.Controls.DarkButton()
        Me.txtLabelName = New DarkUI.Controls.DarkTextBox()
        Me.lblLabelName = New DarkUI.Controls.DarkLabel()
        Me.fraChangeClass = New DarkUI.Controls.DarkGroupBox()
        Me.btnChangeClassOk = New DarkUI.Controls.DarkButton()
        Me.btnChangeClassCancel = New DarkUI.Controls.DarkButton()
        Me.cmbChangeClass = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel38 = New DarkUI.Controls.DarkLabel()
        Me.fraChangeSkills = New DarkUI.Controls.DarkGroupBox()
        Me.btnChangeSkillsOk = New DarkUI.Controls.DarkButton()
        Me.btnChangeSkillsCancel = New DarkUI.Controls.DarkButton()
        Me.optChangeSkillsRemove = New DarkUI.Controls.DarkRadioButton()
        Me.optChangeSkillsAdd = New DarkUI.Controls.DarkRadioButton()
        Me.cmbChangeSkills = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel37 = New DarkUI.Controls.DarkLabel()
        Me.fraCompleteTask = New DarkUI.Controls.DarkGroupBox()
        Me.btnCompleteQuestTaskOk = New DarkUI.Controls.DarkButton()
        Me.btnCompleteQuestTaskCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel35 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel36 = New DarkUI.Controls.DarkLabel()
        Me.nudCompleteQuestTask = New DarkUI.Controls.DarkNumericUpDown()
        Me.cmbCompleteQuest = New DarkUI.Controls.DarkComboBox()
        Me.fraPlayerWarp = New DarkUI.Controls.DarkGroupBox()
        Me.btnPlayerWarpOk = New DarkUI.Controls.DarkButton()
        Me.btnPlayerWarpCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel31 = New DarkUI.Controls.DarkLabel()
        Me.cmbWarpPlayerDir = New DarkUI.Controls.DarkComboBox()
        Me.nudWPY = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel32 = New DarkUI.Controls.DarkLabel()
        Me.nudWPX = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel33 = New DarkUI.Controls.DarkLabel()
        Me.nudWPMap = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel34 = New DarkUI.Controls.DarkLabel()
        Me.fraSetFog = New DarkUI.Controls.DarkGroupBox()
        Me.btnSetFogOk = New DarkUI.Controls.DarkButton()
        Me.btnSetFogCancel = New DarkUI.Controls.DarkButton()
        Me.DarkLabel30 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel29 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel28 = New DarkUI.Controls.DarkLabel()
        Me.nudFogData2 = New DarkUI.Controls.DarkNumericUpDown()
        Me.nudFogData1 = New DarkUI.Controls.DarkNumericUpDown()
        Me.nudFogData0 = New DarkUI.Controls.DarkNumericUpDown()
        Me.fraShowText = New DarkUI.Controls.DarkGroupBox()
        Me.DarkLabel27 = New DarkUI.Controls.DarkLabel()
        Me.txtShowText = New DarkUI.Controls.DarkTextBox()
        Me.btnShowTextCancel = New DarkUI.Controls.DarkButton()
        Me.btnShowTextOk = New DarkUI.Controls.DarkButton()
        Me.picShowTextFace = New System.Windows.Forms.PictureBox()
        Me.DarkLabel26 = New DarkUI.Controls.DarkLabel()
        Me.nudShowTextFace = New DarkUI.Controls.DarkNumericUpDown()
        Me.fraAddText = New DarkUI.Controls.DarkGroupBox()
        Me.btnAddTextOk = New DarkUI.Controls.DarkButton()
        Me.btnAddTextCancel = New DarkUI.Controls.DarkButton()
        Me.optAddText_Global = New DarkUI.Controls.DarkRadioButton()
        Me.optAddText_Map = New DarkUI.Controls.DarkRadioButton()
        Me.optAddText_Player = New DarkUI.Controls.DarkRadioButton()
        Me.DarkLabel25 = New DarkUI.Controls.DarkLabel()
        Me.txtAddText_Text = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel24 = New DarkUI.Controls.DarkLabel()
        Me.fraPlayerSwitch = New DarkUI.Controls.DarkGroupBox()
        Me.btnSetPlayerSwitchOk = New DarkUI.Controls.DarkButton()
        Me.btnSetPlayerswitchCancel = New DarkUI.Controls.DarkButton()
        Me.cmbPlayerSwitchSet = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel23 = New DarkUI.Controls.DarkLabel()
        Me.cmbSwitch = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel22 = New DarkUI.Controls.DarkLabel()
        Me.fraChangeItems = New DarkUI.Controls.DarkGroupBox()
        Me.btnChangeItemsOk = New DarkUI.Controls.DarkButton()
        Me.btnChangeItemsCancel = New DarkUI.Controls.DarkButton()
        Me.nudChangeItemsAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.optChangeItemRemove = New DarkUI.Controls.DarkRadioButton()
        Me.optChangeItemAdd = New DarkUI.Controls.DarkRadioButton()
        Me.optChangeItemSet = New DarkUI.Controls.DarkRadioButton()
        Me.cmbChangeItemIndex = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel21 = New DarkUI.Controls.DarkLabel()
        Me.fraPlayBGM = New DarkUI.Controls.DarkGroupBox()
        Me.btnPlayBgmOk = New DarkUI.Controls.DarkButton()
        Me.btnPlayBgmCancel = New DarkUI.Controls.DarkButton()
        Me.cmbPlayBGM = New DarkUI.Controls.DarkComboBox()
        Me.pnlVariableSwitches = New System.Windows.Forms.Panel()
        Me.FraRenaming = New System.Windows.Forms.GroupBox()
        Me.btnRename_Cancel = New System.Windows.Forms.Button()
        Me.btnRename_Ok = New System.Windows.Forms.Button()
        Me.fraRandom10 = New System.Windows.Forms.GroupBox()
        Me.txtRename = New System.Windows.Forms.TextBox()
        Me.lblEditing = New System.Windows.Forms.Label()
        Me.fraLabeling = New DarkUI.Controls.DarkGroupBox()
        Me.lstSwitches = New System.Windows.Forms.ListBox()
        Me.lstVariables = New System.Windows.Forms.ListBox()
        Me.btnLabel_Cancel = New System.Windows.Forms.Button()
        Me.lblRandomLabel36 = New System.Windows.Forms.Label()
        Me.btnRenameVariable = New System.Windows.Forms.Button()
        Me.lblRandomLabel25 = New System.Windows.Forms.Label()
        Me.btnRenameSwitch = New System.Windows.Forms.Button()
        Me.btnLabel_Ok = New System.Windows.Forms.Button()
        Me.fraPageSetUp.SuspendLayout()
        Me.tabPages.SuspendLayout()
        Me.pnlTabPage.SuspendLayout()
        Me.fraCommands.SuspendLayout()
        Me.DarkGroupBox8.SuspendLayout()
        Me.DarkGroupBox7.SuspendLayout()
        Me.DarkGroupBox5.SuspendLayout()
        Me.DarkGroupBox4.SuspendLayout()
        Me.DarkGroupBox3.SuspendLayout()
        Me.DarkGroupBox2.SuspendLayout()
        CType(Me.picGraphic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DarkGroupBox1.SuspendLayout()
        CType(Me.nudPlayerVariable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DarkGroupBox6.SuspendLayout()
        Me.fraMoveRoute.SuspendLayout()
        Me.DarkGroupBox10.SuspendLayout()
        Me.fraGraphic.SuspendLayout()
        Me.pnlGraphicSel.SuspendLayout()
        CType(Me.picGraphicSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGraphic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDialogue.SuspendLayout()
        Me.fraConditionalBranch.SuspendLayout()
        Me.fraConditions_Quest.SuspendLayout()
        CType(Me.nudCondition_QuestTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCondition_Quest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCondition_LevelAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCondition_HasItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCondition_PlayerVarCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraPlayAnimation.SuspendLayout()
        CType(Me.nudPlayAnimTileY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlayAnimTileX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraMoveRouteWait.SuspendLayout()
        Me.fraCustomScript.SuspendLayout()
        CType(Me.nudCustomScript, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraSetWeather.SuspendLayout()
        CType(Me.nudWeatherIntensity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraSpawnNpc.SuspendLayout()
        Me.fraGiveExp.SuspendLayout()
        CType(Me.nudGiveExp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraEndQuest.SuspendLayout()
        Me.fraSetAccess.SuspendLayout()
        Me.fraSetWait.SuspendLayout()
        CType(Me.nudWaitAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraShowPic.SuspendLayout()
        CType(Me.nudPicOffsetY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPicOffsetX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShowPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShowPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraOpenShop.SuspendLayout()
        Me.fraChangeLevel.SuspendLayout()
        CType(Me.nudChangeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraChangeGender.SuspendLayout()
        Me.fraGoToLabel.SuspendLayout()
        Me.fraHidePic.SuspendLayout()
        CType(Me.nudHidePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraBeginQuest.SuspendLayout()
        Me.fraShowChoices.SuspendLayout()
        CType(Me.picShowChoicesFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShowChoicesFace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraPlayerVariable.SuspendLayout()
        CType(Me.nudVariableData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVariableData4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVariableData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVariableData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVariableData0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraChangeSprite.SuspendLayout()
        CType(Me.nudChangeSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChangeSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraSetSelfSwitch.SuspendLayout()
        Me.fraMapTint.SuspendLayout()
        CType(Me.nudMapTintData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMapTintData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMapTintData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMapTintData0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraShowChatBubble.SuspendLayout()
        Me.fraPlaySound.SuspendLayout()
        Me.fraChangePK.SuspendLayout()
        Me.fraCreateLabel.SuspendLayout()
        Me.fraChangeClass.SuspendLayout()
        Me.fraChangeSkills.SuspendLayout()
        Me.fraCompleteTask.SuspendLayout()
        CType(Me.nudCompleteQuestTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraPlayerWarp.SuspendLayout()
        CType(Me.nudWPY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWPX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWPMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraSetFog.SuspendLayout()
        CType(Me.nudFogData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFogData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFogData0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraShowText.SuspendLayout()
        CType(Me.picShowTextFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShowTextFace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraAddText.SuspendLayout()
        Me.fraPlayerSwitch.SuspendLayout()
        Me.fraChangeItems.SuspendLayout()
        CType(Me.nudChangeItemsAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraPlayBGM.SuspendLayout()
        Me.pnlVariableSwitches.SuspendLayout()
        Me.FraRenaming.SuspendLayout()
        Me.fraRandom10.SuspendLayout()
        Me.fraLabeling.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvCommands
        '
        Me.tvCommands.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tvCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvCommands.ForeColor = System.Drawing.Color.Gainsboro
        Me.tvCommands.Location = New System.Drawing.Point(9, 5)
        Me.tvCommands.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tvCommands.Name = "tvCommands"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Show Text"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "Show Choices"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "Add Chatbox Text"
        TreeNode4.Name = "Node5"
        TreeNode4.Text = "Show ChatBubble"
        TreeNode5.Name = "NodeMessages"
        TreeNode5.Text = "Mensagens"
        TreeNode6.Name = "Node1"
        TreeNode6.Text = "Set Player Variable"
        TreeNode7.Name = "Node2"
        TreeNode7.Text = "Set Player Switch"
        TreeNode8.Name = "Node3"
        TreeNode8.Text = "Set Self Switch"
        TreeNode9.Name = "NodeProcessing"
        TreeNode9.Text = "Processamento de Evento"
        TreeNode10.Name = "Node1"
        TreeNode10.Text = "Conditional Branch"
        TreeNode11.Name = "Node2"
        TreeNode11.Text = "Stop Event Processing"
        TreeNode12.Name = "Node3"
        TreeNode12.Text = "Label"
        TreeNode13.Name = "Node4"
        TreeNode13.Text = "GoTo Label"
        TreeNode14.Name = "NodeFlowControl"
        TreeNode14.Text = "Controle de Fluxo"
        TreeNode15.Name = "Node1"
        TreeNode15.Text = "Change Items"
        TreeNode16.Name = "Node2"
        TreeNode16.Text = "Restore HP"
        TreeNode17.Name = "Node3"
        TreeNode17.Text = "Restore MP"
        TreeNode18.Name = "Node4"
        TreeNode18.Text = "Level Up"
        TreeNode19.Name = "Node5"
        TreeNode19.Text = "Change Level"
        TreeNode20.Name = "Node6"
        TreeNode20.Text = "Change Skills"
        TreeNode21.Name = "Node7"
        TreeNode21.Text = "Change Class"
        TreeNode22.Name = "Node8"
        TreeNode22.Text = "Change Sprite"
        TreeNode23.Name = "Node9"
        TreeNode23.Text = "Change Gender"
        TreeNode24.Name = "Node10"
        TreeNode24.Text = "Change PK"
        TreeNode25.Name = "Node11"
        TreeNode25.Text = "Give Experience"
        TreeNode26.Name = "NodePlayerOptions"
        TreeNode26.Text = "Opções do Jogador"
        TreeNode27.Name = "Node1"
        TreeNode27.Text = "Warp Player"
        TreeNode28.Name = "Node2"
        TreeNode28.Text = "Set Move Route"
        TreeNode29.Name = "Node3"
        TreeNode29.Text = "Wait for Route Completion"
        TreeNode30.Name = "Node4"
        TreeNode30.Text = "Force Spawn Npc"
        TreeNode31.Name = "Node5"
        TreeNode31.Text = "Hold Player"
        TreeNode32.Name = "Node6"
        TreeNode32.Text = "Release Player"
        TreeNode33.Name = "NodeMovement"
        TreeNode33.Text = "Movimento"
        TreeNode34.Name = "Node1"
        TreeNode34.Text = "Animation"
        TreeNode35.Name = "NodeAnimation"
        TreeNode35.Text = "Animação"
        TreeNode36.Name = "Node1"
        TreeNode36.Text = "Begin Quest"
        TreeNode37.Name = "Node2"
        TreeNode37.Text = "Complete Task"
        TreeNode38.Name = "Node3"
        TreeNode38.Text = "End Quest"
        TreeNode39.Name = "NodeQuesting"
        TreeNode39.Text = "Questing"
        TreeNode40.Name = "Node1"
        TreeNode40.Text = "Set Fog"
        TreeNode41.Name = "Node2"
        TreeNode41.Text = "Set Weather"
        TreeNode42.Name = "Node3"
        TreeNode42.Text = "Set Map Tinting"
        TreeNode43.Name = "NodeMapFunctions"
        TreeNode43.Text = "Funções de Mapa"
        TreeNode44.Name = "Node1"
        TreeNode44.Text = "Play BGM"
        TreeNode45.Name = "Node2"
        TreeNode45.Text = "Stop BGM"
        TreeNode46.Name = "Node3"
        TreeNode46.Text = "Play Sound"
        TreeNode47.Name = "Node4"
        TreeNode47.Text = "Stop Sounds"
        TreeNode48.Name = "NodeSound"
        TreeNode48.Text = "Músicas e Sons"
        TreeNode49.Name = "Node1"
        TreeNode49.Text = "Wait..."
        TreeNode50.Name = "Node2"
        TreeNode50.Text = "Set Access"
        TreeNode51.Name = "Node3"
        TreeNode51.Text = "Custom Script"
        TreeNode52.Name = "NodeEtc"
        TreeNode52.Text = "Etc..."
        TreeNode53.Name = "Node1"
        TreeNode53.Text = "Open Bank"
        TreeNode54.Name = "Node2"
        TreeNode54.Text = "Open Shop"
        TreeNode55.Name = "NodeShopBank"
        TreeNode55.Text = "Loja e Banco"
        TreeNode56.Name = "Node1"
        TreeNode56.Text = "Fade In"
        TreeNode57.Name = "Node2"
        TreeNode57.Text = "Fade Out"
        TreeNode58.Name = "Node0"
        TreeNode58.Text = "Opções de Cutscenes"
        Me.tvCommands.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode9, TreeNode14, TreeNode26, TreeNode33, TreeNode35, TreeNode39, TreeNode43, TreeNode48, TreeNode52, TreeNode55, TreeNode58})
        Me.tvCommands.Size = New System.Drawing.Size(570, 680)
        Me.tvCommands.TabIndex = 1
        '
        'fraPageSetUp
        '
        Me.fraPageSetUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraPageSetUp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraPageSetUp.Controls.Add(Me.chkGlobal)
        Me.fraPageSetUp.Controls.Add(Me.btnClearPage)
        Me.fraPageSetUp.Controls.Add(Me.btnDeletePage)
        Me.fraPageSetUp.Controls.Add(Me.btnPastePage)
        Me.fraPageSetUp.Controls.Add(Me.btnCopyPage)
        Me.fraPageSetUp.Controls.Add(Me.btnNewPage)
        Me.fraPageSetUp.Controls.Add(Me.txtName)
        Me.fraPageSetUp.Controls.Add(Me.DarkLabel1)
        Me.fraPageSetUp.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraPageSetUp.Location = New System.Drawing.Point(4, 5)
        Me.fraPageSetUp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPageSetUp.Name = "fraPageSetUp"
        Me.fraPageSetUp.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPageSetUp.Size = New System.Drawing.Size(1186, 77)
        Me.fraPageSetUp.TabIndex = 2
        Me.fraPageSetUp.TabStop = False
        Me.fraPageSetUp.Text = "Geral"
        '
        'chkGlobal
        '
        Me.chkGlobal.AutoSize = True
        Me.chkGlobal.Location = New System.Drawing.Point(420, 31)
        Me.chkGlobal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkGlobal.Name = "chkGlobal"
        Me.chkGlobal.Size = New System.Drawing.Size(81, 24)
        Me.chkGlobal.TabIndex = 7
        Me.chkGlobal.Text = "Global"
        '
        'btnClearPage
        '
        Me.btnClearPage.Location = New System.Drawing.Point(1060, 25)
        Me.btnClearPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClearPage.Name = "btnClearPage"
        Me.btnClearPage.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnClearPage.Size = New System.Drawing.Size(112, 35)
        Me.btnClearPage.TabIndex = 6
        Me.btnClearPage.Text = "Limpar "
        '
        'btnDeletePage
        '
        Me.btnDeletePage.Location = New System.Drawing.Point(933, 25)
        Me.btnDeletePage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeletePage.Name = "btnDeletePage"
        Me.btnDeletePage.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnDeletePage.Size = New System.Drawing.Size(118, 35)
        Me.btnDeletePage.TabIndex = 5
        Me.btnDeletePage.Text = "Deletar "
        '
        'btnPastePage
        '
        Me.btnPastePage.Location = New System.Drawing.Point(812, 25)
        Me.btnPastePage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPastePage.Name = "btnPastePage"
        Me.btnPastePage.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPastePage.Size = New System.Drawing.Size(112, 35)
        Me.btnPastePage.TabIndex = 4
        Me.btnPastePage.Text = "Colar"
        '
        'btnCopyPage
        '
        Me.btnCopyPage.Location = New System.Drawing.Point(690, 25)
        Me.btnCopyPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCopyPage.Name = "btnCopyPage"
        Me.btnCopyPage.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCopyPage.Size = New System.Drawing.Size(112, 35)
        Me.btnCopyPage.TabIndex = 3
        Me.btnCopyPage.Text = "Copiar"
        '
        'btnNewPage
        '
        Me.btnNewPage.Location = New System.Drawing.Point(568, 25)
        Me.btnNewPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNewPage.Name = "btnNewPage"
        Me.btnNewPage.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnNewPage.Size = New System.Drawing.Size(112, 35)
        Me.btnNewPage.TabIndex = 2
        Me.btnNewPage.Text = "Nova"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(153, 29)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 26)
        Me.txtName.TabIndex = 1
        '
        'DarkLabel1
        '
        Me.DarkLabel1.AutoSize = True
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(14, 32)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(131, 20)
        Me.DarkLabel1.TabIndex = 0
        Me.DarkLabel1.Text = "Nome do Evento:"
        '
        'tabPages
        '
        Me.tabPages.Controls.Add(Me.TabPage1)
        Me.tabPages.Location = New System.Drawing.Point(18, 91)
        Me.tabPages.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabPages.Name = "tabPages"
        Me.tabPages.SelectedIndex = 0
        Me.tabPages.Size = New System.Drawing.Size(1064, 29)
        Me.tabPages.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DimGray
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1056, 0)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlTabPage
        '
        Me.pnlTabPage.Controls.Add(Me.fraCommands)
        Me.pnlTabPage.Controls.Add(Me.DarkGroupBox8)
        Me.pnlTabPage.Controls.Add(Me.lstCommands)
        Me.pnlTabPage.Controls.Add(Me.DarkLabel10)
        Me.pnlTabPage.Controls.Add(Me.DarkLabel9)
        Me.pnlTabPage.Controls.Add(Me.DarkGroupBox7)
        Me.pnlTabPage.Controls.Add(Me.DarkGroupBox5)
        Me.pnlTabPage.Controls.Add(Me.DarkGroupBox4)
        Me.pnlTabPage.Controls.Add(Me.DarkGroupBox3)
        Me.pnlTabPage.Controls.Add(Me.DarkGroupBox2)
        Me.pnlTabPage.Controls.Add(Me.DarkGroupBox1)
        Me.pnlTabPage.Location = New System.Drawing.Point(4, 125)
        Me.pnlTabPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlTabPage.Name = "pnlTabPage"
        Me.pnlTabPage.Size = New System.Drawing.Size(1186, 765)
        Me.pnlTabPage.TabIndex = 4
        '
        'fraCommands
        '
        Me.fraCommands.Controls.Add(Me.btnCancelCommand)
        Me.fraCommands.Controls.Add(Me.tvCommands)
        Me.fraCommands.Location = New System.Drawing.Point(584, 9)
        Me.fraCommands.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraCommands.Name = "fraCommands"
        Me.fraCommands.Size = New System.Drawing.Size(590, 742)
        Me.fraCommands.TabIndex = 6
        Me.fraCommands.Visible = False
        '
        'btnCancelCommand
        '
        Me.btnCancelCommand.Location = New System.Drawing.Point(468, 695)
        Me.btnCancelCommand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelCommand.Name = "btnCancelCommand"
        Me.btnCancelCommand.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCancelCommand.Size = New System.Drawing.Size(112, 35)
        Me.btnCancelCommand.TabIndex = 2
        Me.btnCancelCommand.Text = "Cancelar"
        '
        'DarkGroupBox8
        '
        Me.DarkGroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox8.Controls.Add(Me.btnClearCommand)
        Me.DarkGroupBox8.Controls.Add(Me.btnDeleteCommand)
        Me.DarkGroupBox8.Controls.Add(Me.btnEditCommand)
        Me.DarkGroupBox8.Controls.Add(Me.btnAddCommand)
        Me.DarkGroupBox8.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox8.Location = New System.Drawing.Point(584, 675)
        Me.DarkGroupBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox8.Name = "DarkGroupBox8"
        Me.DarkGroupBox8.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox8.Size = New System.Drawing.Size(590, 75)
        Me.DarkGroupBox8.TabIndex = 9
        Me.DarkGroupBox8.TabStop = False
        Me.DarkGroupBox8.Text = "Commands"
        '
        'btnClearCommand
        '
        Me.btnClearCommand.Location = New System.Drawing.Point(468, 29)
        Me.btnClearCommand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClearCommand.Name = "btnClearCommand"
        Me.btnClearCommand.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnClearCommand.Size = New System.Drawing.Size(112, 35)
        Me.btnClearCommand.TabIndex = 3
        Me.btnClearCommand.Text = "Clear"
        '
        'btnDeleteCommand
        '
        Me.btnDeleteCommand.Location = New System.Drawing.Point(318, 29)
        Me.btnDeleteCommand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeleteCommand.Name = "btnDeleteCommand"
        Me.btnDeleteCommand.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnDeleteCommand.Size = New System.Drawing.Size(112, 35)
        Me.btnDeleteCommand.TabIndex = 2
        Me.btnDeleteCommand.Text = "Delete"
        '
        'btnEditCommand
        '
        Me.btnEditCommand.Location = New System.Drawing.Point(162, 29)
        Me.btnEditCommand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditCommand.Name = "btnEditCommand"
        Me.btnEditCommand.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnEditCommand.Size = New System.Drawing.Size(112, 35)
        Me.btnEditCommand.TabIndex = 1
        Me.btnEditCommand.Text = "Edit"
        '
        'btnAddCommand
        '
        Me.btnAddCommand.Location = New System.Drawing.Point(9, 29)
        Me.btnAddCommand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddCommand.Name = "btnAddCommand"
        Me.btnAddCommand.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnAddCommand.Size = New System.Drawing.Size(112, 35)
        Me.btnAddCommand.TabIndex = 0
        Me.btnAddCommand.Text = "Add"
        '
        'lstCommands
        '
        Me.lstCommands.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lstCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCommands.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstCommands.FormattingEnabled = True
        Me.lstCommands.ItemHeight = 20
        Me.lstCommands.Location = New System.Drawing.Point(584, 9)
        Me.lstCommands.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstCommands.Name = "lstCommands"
        Me.lstCommands.Size = New System.Drawing.Size(588, 662)
        Me.lstCommands.TabIndex = 8
        '
        'DarkLabel10
        '
        Me.DarkLabel10.ForeColor = System.Drawing.Color.Red
        Me.DarkLabel10.Location = New System.Drawing.Point(273, 705)
        Me.DarkLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel10.Name = "DarkLabel10"
        Me.DarkLabel10.Size = New System.Drawing.Size(300, 46)
        Me.DarkLabel10.TabIndex = 7
        Me.DarkLabel10.Text = "** If global, only the first page will be processed. For shop keepers etc."
        '
        'DarkLabel9
        '
        Me.DarkLabel9.ForeColor = System.Drawing.Color.Red
        Me.DarkLabel9.Location = New System.Drawing.Point(273, 652)
        Me.DarkLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel9.Name = "DarkLabel9"
        Me.DarkLabel9.Size = New System.Drawing.Size(302, 52)
        Me.DarkLabel9.TabIndex = 6
        Me.DarkLabel9.Text = "* Self Switches are always global and will reset on server restart."
        '
        'DarkGroupBox7
        '
        Me.DarkGroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox7.Controls.Add(Me.cmbEventQuest)
        Me.DarkGroupBox7.Controls.Add(Me.DarkLabel8)
        Me.DarkGroupBox7.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox7.Location = New System.Drawing.Point(273, 578)
        Me.DarkGroupBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox7.Name = "DarkGroupBox7"
        Me.DarkGroupBox7.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox7.Size = New System.Drawing.Size(300, 69)
        Me.DarkGroupBox7.TabIndex = 5
        Me.DarkGroupBox7.TabStop = False
        Me.DarkGroupBox7.Text = "Ícone da Quest"
        '
        'cmbEventQuest
        '
        Me.cmbEventQuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbEventQuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbEventQuest.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbEventQuest.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbEventQuest.ButtonIcon = CType(resources.GetObject("cmbEventQuest.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbEventQuest.DrawDropdownHoverOutline = False
        Me.cmbEventQuest.DrawFocusRectangle = False
        Me.cmbEventQuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEventQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEventQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEventQuest.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbEventQuest.FormattingEnabled = True
        Me.cmbEventQuest.Location = New System.Drawing.Point(76, 26)
        Me.cmbEventQuest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbEventQuest.Name = "cmbEventQuest"
        Me.cmbEventQuest.Size = New System.Drawing.Size(212, 27)
        Me.cmbEventQuest.TabIndex = 1
        Me.cmbEventQuest.Text = Nothing
        Me.cmbEventQuest.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel8
        '
        Me.DarkLabel8.AutoSize = True
        Me.DarkLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel8.Location = New System.Drawing.Point(10, 31)
        Me.DarkLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel8.Name = "DarkLabel8"
        Me.DarkLabel8.Size = New System.Drawing.Size(56, 20)
        Me.DarkLabel8.TabIndex = 0
        Me.DarkLabel8.Text = "Quest:"
        '
        'DarkGroupBox5
        '
        Me.DarkGroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox5.Controls.Add(Me.cmbTrigger)
        Me.DarkGroupBox5.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox5.Location = New System.Drawing.Point(273, 494)
        Me.DarkGroupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox5.Name = "DarkGroupBox5"
        Me.DarkGroupBox5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox5.Size = New System.Drawing.Size(300, 75)
        Me.DarkGroupBox5.TabIndex = 4
        Me.DarkGroupBox5.TabStop = False
        Me.DarkGroupBox5.Text = "Gatilho de Início"
        '
        'cmbTrigger
        '
        Me.cmbTrigger.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbTrigger.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbTrigger.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbTrigger.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbTrigger.ButtonIcon = CType(resources.GetObject("cmbTrigger.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbTrigger.DrawDropdownHoverOutline = False
        Me.cmbTrigger.DrawFocusRectangle = False
        Me.cmbTrigger.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTrigger.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbTrigger.FormattingEnabled = True
        Me.cmbTrigger.Items.AddRange(New Object() {"Action Button", "Player Touch", "Parallel Process"})
        Me.cmbTrigger.Location = New System.Drawing.Point(9, 29)
        Me.cmbTrigger.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbTrigger.Name = "cmbTrigger"
        Me.cmbTrigger.Size = New System.Drawing.Size(282, 27)
        Me.cmbTrigger.TabIndex = 0
        Me.cmbTrigger.Text = "Action Button"
        Me.cmbTrigger.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkGroupBox4
        '
        Me.DarkGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox4.Controls.Add(Me.cmbPositioning)
        Me.DarkGroupBox4.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox4.Location = New System.Drawing.Point(273, 411)
        Me.DarkGroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox4.Name = "DarkGroupBox4"
        Me.DarkGroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox4.Size = New System.Drawing.Size(300, 74)
        Me.DarkGroupBox4.TabIndex = 3
        Me.DarkGroupBox4.TabStop = False
        Me.DarkGroupBox4.Text = "Posicionamento"
        '
        'cmbPositioning
        '
        Me.cmbPositioning.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPositioning.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPositioning.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPositioning.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPositioning.ButtonIcon = CType(resources.GetObject("cmbPositioning.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPositioning.DrawDropdownHoverOutline = False
        Me.cmbPositioning.DrawFocusRectangle = False
        Me.cmbPositioning.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPositioning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPositioning.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPositioning.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPositioning.FormattingEnabled = True
        Me.cmbPositioning.Items.AddRange(New Object() {"Below Characters", "Same as Characters", "Above Characters"})
        Me.cmbPositioning.Location = New System.Drawing.Point(9, 29)
        Me.cmbPositioning.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPositioning.Name = "cmbPositioning"
        Me.cmbPositioning.Size = New System.Drawing.Size(282, 27)
        Me.cmbPositioning.TabIndex = 0
        Me.cmbPositioning.Text = "Below Characters"
        Me.cmbPositioning.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkGroupBox3
        '
        Me.DarkGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel7)
        Me.DarkGroupBox3.Controls.Add(Me.cmbMoveFreq)
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel6)
        Me.DarkGroupBox3.Controls.Add(Me.cmbMoveSpeed)
        Me.DarkGroupBox3.Controls.Add(Me.btnMoveRoute)
        Me.DarkGroupBox3.Controls.Add(Me.cmbMoveType)
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel5)
        Me.DarkGroupBox3.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox3.Location = New System.Drawing.Point(274, 212)
        Me.DarkGroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox3.Name = "DarkGroupBox3"
        Me.DarkGroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox3.Size = New System.Drawing.Size(300, 189)
        Me.DarkGroupBox3.TabIndex = 2
        Me.DarkGroupBox3.TabStop = False
        Me.DarkGroupBox3.Text = "Movimentação"
        '
        'DarkLabel7
        '
        Me.DarkLabel7.AutoSize = True
        Me.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel7.Location = New System.Drawing.Point(9, 154)
        Me.DarkLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel7.Name = "DarkLabel7"
        Me.DarkLabel7.Size = New System.Drawing.Size(93, 20)
        Me.DarkLabel7.TabIndex = 6
        Me.DarkLabel7.Text = "Frequência:"
        '
        'cmbMoveFreq
        '
        Me.cmbMoveFreq.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbMoveFreq.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbMoveFreq.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbMoveFreq.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbMoveFreq.ButtonIcon = CType(resources.GetObject("cmbMoveFreq.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbMoveFreq.DrawDropdownHoverOutline = False
        Me.cmbMoveFreq.DrawFocusRectangle = False
        Me.cmbMoveFreq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMoveFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoveFreq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMoveFreq.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbMoveFreq.FormattingEnabled = True
        Me.cmbMoveFreq.Items.AddRange(New Object() {"Lowest", "Lower", "Normal", "Higher", "Highest"})
        Me.cmbMoveFreq.Location = New System.Drawing.Point(104, 149)
        Me.cmbMoveFreq.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbMoveFreq.Name = "cmbMoveFreq"
        Me.cmbMoveFreq.Size = New System.Drawing.Size(186, 27)
        Me.cmbMoveFreq.TabIndex = 5
        Me.cmbMoveFreq.Text = "Lowest"
        Me.cmbMoveFreq.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel6
        '
        Me.DarkLabel6.AutoSize = True
        Me.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel6.Location = New System.Drawing.Point(9, 112)
        Me.DarkLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel6.Name = "DarkLabel6"
        Me.DarkLabel6.Size = New System.Drawing.Size(92, 20)
        Me.DarkLabel6.TabIndex = 4
        Me.DarkLabel6.Text = "Velocidade:"
        '
        'cmbMoveSpeed
        '
        Me.cmbMoveSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbMoveSpeed.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbMoveSpeed.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbMoveSpeed.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbMoveSpeed.ButtonIcon = CType(resources.GetObject("cmbMoveSpeed.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbMoveSpeed.DrawDropdownHoverOutline = False
        Me.cmbMoveSpeed.DrawFocusRectangle = False
        Me.cmbMoveSpeed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMoveSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoveSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMoveSpeed.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbMoveSpeed.FormattingEnabled = True
        Me.cmbMoveSpeed.Items.AddRange(New Object() {"8x Slower", "4x Slower", "2x Slower", "Normal", "2x Faster", "4x Faster"})
        Me.cmbMoveSpeed.Location = New System.Drawing.Point(104, 108)
        Me.cmbMoveSpeed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbMoveSpeed.Name = "cmbMoveSpeed"
        Me.cmbMoveSpeed.Size = New System.Drawing.Size(186, 27)
        Me.cmbMoveSpeed.TabIndex = 3
        Me.cmbMoveSpeed.Text = "8x Slower"
        Me.cmbMoveSpeed.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'btnMoveRoute
        '
        Me.btnMoveRoute.Location = New System.Drawing.Point(178, 63)
        Me.btnMoveRoute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMoveRoute.Name = "btnMoveRoute"
        Me.btnMoveRoute.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnMoveRoute.Size = New System.Drawing.Size(112, 35)
        Me.btnMoveRoute.TabIndex = 2
        Me.btnMoveRoute.Text = "Move Route"
        '
        'cmbMoveType
        '
        Me.cmbMoveType.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbMoveType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbMoveType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbMoveType.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbMoveType.ButtonIcon = CType(resources.GetObject("cmbMoveType.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbMoveType.DrawDropdownHoverOutline = False
        Me.cmbMoveType.DrawFocusRectangle = False
        Me.cmbMoveType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMoveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMoveType.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbMoveType.FormattingEnabled = True
        Me.cmbMoveType.Items.AddRange(New Object() {"Fixed Position", "Random", "Move Route"})
        Me.cmbMoveType.Location = New System.Drawing.Point(104, 22)
        Me.cmbMoveType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbMoveType.Name = "cmbMoveType"
        Me.cmbMoveType.Size = New System.Drawing.Size(186, 27)
        Me.cmbMoveType.TabIndex = 1
        Me.cmbMoveType.Text = "Fixed Position"
        Me.cmbMoveType.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel5
        '
        Me.DarkLabel5.AutoSize = True
        Me.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel5.Location = New System.Drawing.Point(9, 26)
        Me.DarkLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel5.Name = "DarkLabel5"
        Me.DarkLabel5.Size = New System.Drawing.Size(43, 20)
        Me.DarkLabel5.TabIndex = 0
        Me.DarkLabel5.Text = "Tipo:"
        '
        'DarkGroupBox2
        '
        Me.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox2.Controls.Add(Me.picGraphic)
        Me.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox2.Location = New System.Drawing.Point(4, 212)
        Me.DarkGroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox2.Name = "DarkGroupBox2"
        Me.DarkGroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox2.Size = New System.Drawing.Size(260, 357)
        Me.DarkGroupBox2.TabIndex = 1
        Me.DarkGroupBox2.TabStop = False
        Me.DarkGroupBox2.Text = "Gráfico"
        '
        'picGraphic
        '
        Me.picGraphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picGraphic.Location = New System.Drawing.Point(9, 29)
        Me.picGraphic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picGraphic.Name = "picGraphic"
        Me.picGraphic.Size = New System.Drawing.Size(242, 318)
        Me.picGraphic.TabIndex = 1
        Me.picGraphic.TabStop = False
        '
        'DarkGroupBox1
        '
        Me.DarkGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox1.Controls.Add(Me.cmbSelfSwitchCompare)
        Me.DarkGroupBox1.Controls.Add(Me.DarkLabel4)
        Me.DarkGroupBox1.Controls.Add(Me.cmbSelfSwitch)
        Me.DarkGroupBox1.Controls.Add(Me.chkSelfSwitch)
        Me.DarkGroupBox1.Controls.Add(Me.cmbHasItem)
        Me.DarkGroupBox1.Controls.Add(Me.chkHasItem)
        Me.DarkGroupBox1.Controls.Add(Me.cmbPlayerSwitchCompare)
        Me.DarkGroupBox1.Controls.Add(Me.DarkLabel3)
        Me.DarkGroupBox1.Controls.Add(Me.cmbPlayerSwitch)
        Me.DarkGroupBox1.Controls.Add(Me.chkPlayerSwitch)
        Me.DarkGroupBox1.Controls.Add(Me.nudPlayerVariable)
        Me.DarkGroupBox1.Controls.Add(Me.cmbPlayervarCompare)
        Me.DarkGroupBox1.Controls.Add(Me.DarkLabel2)
        Me.DarkGroupBox1.Controls.Add(Me.cmbPlayerVar)
        Me.DarkGroupBox1.Controls.Add(Me.chkPlayerVar)
        Me.DarkGroupBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox1.Location = New System.Drawing.Point(4, 9)
        Me.DarkGroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox1.Name = "DarkGroupBox1"
        Me.DarkGroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox1.Size = New System.Drawing.Size(570, 194)
        Me.DarkGroupBox1.TabIndex = 0
        Me.DarkGroupBox1.TabStop = False
        Me.DarkGroupBox1.Text = "Condições"
        '
        'cmbSelfSwitchCompare
        '
        Me.cmbSelfSwitchCompare.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbSelfSwitchCompare.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbSelfSwitchCompare.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbSelfSwitchCompare.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbSelfSwitchCompare.ButtonIcon = CType(resources.GetObject("cmbSelfSwitchCompare.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbSelfSwitchCompare.DrawDropdownHoverOutline = False
        Me.cmbSelfSwitchCompare.DrawFocusRectangle = False
        Me.cmbSelfSwitchCompare.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSelfSwitchCompare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelfSwitchCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelfSwitchCompare.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbSelfSwitchCompare.FormattingEnabled = True
        Me.cmbSelfSwitchCompare.Items.AddRange(New Object() {"False = 0", "True = 1"})
        Me.cmbSelfSwitchCompare.Location = New System.Drawing.Point(334, 151)
        Me.cmbSelfSwitchCompare.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSelfSwitchCompare.Name = "cmbSelfSwitchCompare"
        Me.cmbSelfSwitchCompare.Size = New System.Drawing.Size(132, 27)
        Me.cmbSelfSwitchCompare.TabIndex = 14
        Me.cmbSelfSwitchCompare.Text = "False = 0"
        Me.cmbSelfSwitchCompare.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel4
        '
        Me.DarkLabel4.AutoSize = True
        Me.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel4.Location = New System.Drawing.Point(304, 155)
        Me.DarkLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel4.Name = "DarkLabel4"
        Me.DarkLabel4.Size = New System.Drawing.Size(20, 20)
        Me.DarkLabel4.TabIndex = 13
        Me.DarkLabel4.Text = "is"
        '
        'cmbSelfSwitch
        '
        Me.cmbSelfSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbSelfSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbSelfSwitch.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbSelfSwitch.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbSelfSwitch.ButtonIcon = CType(resources.GetObject("cmbSelfSwitch.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbSelfSwitch.DrawDropdownHoverOutline = False
        Me.cmbSelfSwitch.DrawFocusRectangle = False
        Me.cmbSelfSwitch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSelfSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelfSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelfSwitch.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbSelfSwitch.FormattingEnabled = True
        Me.cmbSelfSwitch.Items.AddRange(New Object() {"None", "1 - A", "2 - B", "3 - C", "4 - D"})
        Me.cmbSelfSwitch.Location = New System.Drawing.Point(162, 151)
        Me.cmbSelfSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSelfSwitch.Name = "cmbSelfSwitch"
        Me.cmbSelfSwitch.Size = New System.Drawing.Size(132, 27)
        Me.cmbSelfSwitch.TabIndex = 12
        Me.cmbSelfSwitch.Text = "None"
        Me.cmbSelfSwitch.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'chkSelfSwitch
        '
        Me.chkSelfSwitch.AutoSize = True
        Me.chkSelfSwitch.Location = New System.Drawing.Point(9, 154)
        Me.chkSelfSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSelfSwitch.Name = "chkSelfSwitch"
        Me.chkSelfSwitch.Size = New System.Drawing.Size(120, 24)
        Me.chkSelfSwitch.TabIndex = 11
        Me.chkSelfSwitch.Text = "Self Switch*"
        '
        'cmbHasItem
        '
        Me.cmbHasItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbHasItem.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbHasItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbHasItem.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbHasItem.ButtonIcon = CType(resources.GetObject("cmbHasItem.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbHasItem.DrawDropdownHoverOutline = False
        Me.cmbHasItem.DrawFocusRectangle = False
        Me.cmbHasItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbHasItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHasItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbHasItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbHasItem.FormattingEnabled = True
        Me.cmbHasItem.Location = New System.Drawing.Point(162, 109)
        Me.cmbHasItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbHasItem.Name = "cmbHasItem"
        Me.cmbHasItem.Size = New System.Drawing.Size(304, 27)
        Me.cmbHasItem.TabIndex = 10
        Me.cmbHasItem.Text = Nothing
        Me.cmbHasItem.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'chkHasItem
        '
        Me.chkHasItem.AutoSize = True
        Me.chkHasItem.Location = New System.Drawing.Point(9, 112)
        Me.chkHasItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkHasItem.Name = "chkHasItem"
        Me.chkHasItem.Size = New System.Drawing.Size(164, 24)
        Me.chkHasItem.TabIndex = 9
        Me.chkHasItem.Text = "Jogador Tem Item"
        '
        'cmbPlayerSwitchCompare
        '
        Me.cmbPlayerSwitchCompare.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPlayerSwitchCompare.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPlayerSwitchCompare.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPlayerSwitchCompare.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPlayerSwitchCompare.ButtonIcon = CType(resources.GetObject("cmbPlayerSwitchCompare.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPlayerSwitchCompare.DrawDropdownHoverOutline = False
        Me.cmbPlayerSwitchCompare.DrawFocusRectangle = False
        Me.cmbPlayerSwitchCompare.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPlayerSwitchCompare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayerSwitchCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayerSwitchCompare.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPlayerSwitchCompare.FormattingEnabled = True
        Me.cmbPlayerSwitchCompare.Items.AddRange(New Object() {"Falso = 0", "Verdadeiro = 1"})
        Me.cmbPlayerSwitchCompare.Location = New System.Drawing.Point(334, 68)
        Me.cmbPlayerSwitchCompare.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPlayerSwitchCompare.Name = "cmbPlayerSwitchCompare"
        Me.cmbPlayerSwitchCompare.Size = New System.Drawing.Size(132, 27)
        Me.cmbPlayerSwitchCompare.TabIndex = 8
        Me.cmbPlayerSwitchCompare.Text = "Falso = 0"
        Me.cmbPlayerSwitchCompare.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = True
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(304, 72)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(18, 20)
        Me.DarkLabel3.TabIndex = 7
        Me.DarkLabel3.Text = "é"
        '
        'cmbPlayerSwitch
        '
        Me.cmbPlayerSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPlayerSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPlayerSwitch.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPlayerSwitch.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPlayerSwitch.ButtonIcon = CType(resources.GetObject("cmbPlayerSwitch.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPlayerSwitch.DrawDropdownHoverOutline = False
        Me.cmbPlayerSwitch.DrawFocusRectangle = False
        Me.cmbPlayerSwitch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPlayerSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayerSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayerSwitch.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPlayerSwitch.FormattingEnabled = True
        Me.cmbPlayerSwitch.Location = New System.Drawing.Point(162, 68)
        Me.cmbPlayerSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPlayerSwitch.Name = "cmbPlayerSwitch"
        Me.cmbPlayerSwitch.Size = New System.Drawing.Size(132, 27)
        Me.cmbPlayerSwitch.TabIndex = 6
        Me.cmbPlayerSwitch.Text = Nothing
        Me.cmbPlayerSwitch.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'chkPlayerSwitch
        '
        Me.chkPlayerSwitch.AutoSize = True
        Me.chkPlayerSwitch.Location = New System.Drawing.Point(9, 71)
        Me.chkPlayerSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPlayerSwitch.Name = "chkPlayerSwitch"
        Me.chkPlayerSwitch.Size = New System.Drawing.Size(129, 24)
        Me.chkPlayerSwitch.TabIndex = 5
        Me.chkPlayerSwitch.Text = "Player Switch"
        '
        'nudPlayerVariable
        '
        Me.nudPlayerVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudPlayerVariable.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudPlayerVariable.Location = New System.Drawing.Point(477, 28)
        Me.nudPlayerVariable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPlayerVariable.Name = "nudPlayerVariable"
        Me.nudPlayerVariable.Size = New System.Drawing.Size(84, 26)
        Me.nudPlayerVariable.TabIndex = 4
        Me.nudPlayerVariable.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbPlayervarCompare
        '
        Me.cmbPlayervarCompare.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPlayervarCompare.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPlayervarCompare.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPlayervarCompare.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPlayervarCompare.ButtonIcon = CType(resources.GetObject("cmbPlayervarCompare.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPlayervarCompare.DrawDropdownHoverOutline = False
        Me.cmbPlayervarCompare.DrawFocusRectangle = False
        Me.cmbPlayervarCompare.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPlayervarCompare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayervarCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayervarCompare.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPlayervarCompare.FormattingEnabled = True
        Me.cmbPlayervarCompare.Items.AddRange(New Object() {"Igual à", "Great Than OrElse Equal To", "Less Than or Equal To", "Maior que", "Menor que", "Não é igual à"})
        Me.cmbPlayervarCompare.Location = New System.Drawing.Point(334, 26)
        Me.cmbPlayervarCompare.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPlayervarCompare.Name = "cmbPlayervarCompare"
        Me.cmbPlayervarCompare.Size = New System.Drawing.Size(132, 27)
        Me.cmbPlayervarCompare.TabIndex = 3
        Me.cmbPlayervarCompare.Text = "Igual à"
        Me.cmbPlayervarCompare.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel2
        '
        Me.DarkLabel2.AutoSize = True
        Me.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel2.Location = New System.Drawing.Point(304, 35)
        Me.DarkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel2.Name = "DarkLabel2"
        Me.DarkLabel2.Size = New System.Drawing.Size(18, 20)
        Me.DarkLabel2.TabIndex = 2
        Me.DarkLabel2.Text = "é"
        '
        'cmbPlayerVar
        '
        Me.cmbPlayerVar.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPlayerVar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPlayerVar.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPlayerVar.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPlayerVar.ButtonIcon = CType(resources.GetObject("cmbPlayerVar.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPlayerVar.DrawDropdownHoverOutline = False
        Me.cmbPlayerVar.DrawFocusRectangle = False
        Me.cmbPlayerVar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPlayerVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayerVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayerVar.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPlayerVar.FormattingEnabled = True
        Me.cmbPlayerVar.Location = New System.Drawing.Point(162, 26)
        Me.cmbPlayerVar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPlayerVar.Name = "cmbPlayerVar"
        Me.cmbPlayerVar.Size = New System.Drawing.Size(132, 27)
        Me.cmbPlayerVar.TabIndex = 1
        Me.cmbPlayerVar.Text = Nothing
        Me.cmbPlayerVar.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'chkPlayerVar
        '
        Me.chkPlayerVar.AutoSize = True
        Me.chkPlayerVar.Location = New System.Drawing.Point(9, 29)
        Me.chkPlayerVar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPlayerVar.Name = "chkPlayerVar"
        Me.chkPlayerVar.Size = New System.Drawing.Size(140, 24)
        Me.chkPlayerVar.TabIndex = 0
        Me.chkPlayerVar.Text = "Player Variable"
        '
        'DarkGroupBox6
        '
        Me.DarkGroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox6.Controls.Add(Me.chkShowName)
        Me.DarkGroupBox6.Controls.Add(Me.chkWalkThrough)
        Me.DarkGroupBox6.Controls.Add(Me.chkDirFix)
        Me.DarkGroupBox6.Controls.Add(Me.chkWalkAnim)
        Me.DarkGroupBox6.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox6.Location = New System.Drawing.Point(4, 703)
        Me.DarkGroupBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox6.Name = "DarkGroupBox6"
        Me.DarkGroupBox6.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox6.Size = New System.Drawing.Size(264, 172)
        Me.DarkGroupBox6.TabIndex = 5
        Me.DarkGroupBox6.TabStop = False
        Me.DarkGroupBox6.Text = "Opções"
        '
        'chkShowName
        '
        Me.chkShowName.AutoSize = True
        Me.chkShowName.Location = New System.Drawing.Point(9, 135)
        Me.chkShowName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkShowName.Name = "chkShowName"
        Me.chkShowName.Size = New System.Drawing.Size(121, 24)
        Me.chkShowName.TabIndex = 3
        Me.chkShowName.Text = "Show Name"
        '
        'chkWalkThrough
        '
        Me.chkWalkThrough.AutoSize = True
        Me.chkWalkThrough.Location = New System.Drawing.Point(9, 100)
        Me.chkWalkThrough.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkWalkThrough.Name = "chkWalkThrough"
        Me.chkWalkThrough.Size = New System.Drawing.Size(133, 24)
        Me.chkWalkThrough.TabIndex = 2
        Me.chkWalkThrough.Text = "Walk Through"
        '
        'chkDirFix
        '
        Me.chkDirFix.AutoSize = True
        Me.chkDirFix.Location = New System.Drawing.Point(9, 65)
        Me.chkDirFix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkDirFix.Name = "chkDirFix"
        Me.chkDirFix.Size = New System.Drawing.Size(140, 24)
        Me.chkDirFix.TabIndex = 1
        Me.chkDirFix.Text = "Direction Fixed"
        '
        'chkWalkAnim
        '
        Me.chkWalkAnim.AutoSize = True
        Me.chkWalkAnim.Location = New System.Drawing.Point(9, 29)
        Me.chkWalkAnim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkWalkAnim.Name = "chkWalkAnim"
        Me.chkWalkAnim.Size = New System.Drawing.Size(169, 24)
        Me.chkWalkAnim.TabIndex = 0
        Me.chkWalkAnim.Text = "No Walk Animation"
        '
        'btnLabeling
        '
        Me.btnLabeling.Location = New System.Drawing.Point(4, 898)
        Me.btnLabeling.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLabeling.Name = "btnLabeling"
        Me.btnLabeling.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnLabeling.Size = New System.Drawing.Size(255, 35)
        Me.btnLabeling.TabIndex = 6
        Me.btnLabeling.Text = "Editar Variáveis / Switches"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1078, 898)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancelar"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(957, 898)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnOk.Size = New System.Drawing.Size(112, 35)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "Confirmar"
        '
        'fraMoveRoute
        '
        Me.fraMoveRoute.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraMoveRoute.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraMoveRoute.Controls.Add(Me.btnMoveRouteOk)
        Me.fraMoveRoute.Controls.Add(Me.btnMoveRouteCancel)
        Me.fraMoveRoute.Controls.Add(Me.chkRepeatRoute)
        Me.fraMoveRoute.Controls.Add(Me.chkIgnoreMove)
        Me.fraMoveRoute.Controls.Add(Me.DarkGroupBox10)
        Me.fraMoveRoute.Controls.Add(Me.lstMoveRoute)
        Me.fraMoveRoute.Controls.Add(Me.cmbEvent)
        Me.fraMoveRoute.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraMoveRoute.Location = New System.Drawing.Point(1200, 18)
        Me.fraMoveRoute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraMoveRoute.Name = "fraMoveRoute"
        Me.fraMoveRoute.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraMoveRoute.Size = New System.Drawing.Size(140, 131)
        Me.fraMoveRoute.TabIndex = 0
        Me.fraMoveRoute.TabStop = False
        Me.fraMoveRoute.Text = "Move Route"
        Me.fraMoveRoute.Visible = False
        '
        'btnMoveRouteOk
        '
        Me.btnMoveRouteOk.Location = New System.Drawing.Point(963, 663)
        Me.btnMoveRouteOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMoveRouteOk.Name = "btnMoveRouteOk"
        Me.btnMoveRouteOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnMoveRouteOk.Size = New System.Drawing.Size(112, 35)
        Me.btnMoveRouteOk.TabIndex = 7
        Me.btnMoveRouteOk.Text = "Ok"
        '
        'btnMoveRouteCancel
        '
        Me.btnMoveRouteCancel.Location = New System.Drawing.Point(1084, 663)
        Me.btnMoveRouteCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMoveRouteCancel.Name = "btnMoveRouteCancel"
        Me.btnMoveRouteCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnMoveRouteCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnMoveRouteCancel.TabIndex = 6
        Me.btnMoveRouteCancel.Text = "Cancel"
        '
        'chkRepeatRoute
        '
        Me.chkRepeatRoute.AutoSize = True
        Me.chkRepeatRoute.Location = New System.Drawing.Point(9, 698)
        Me.chkRepeatRoute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkRepeatRoute.Name = "chkRepeatRoute"
        Me.chkRepeatRoute.Size = New System.Drawing.Size(136, 24)
        Me.chkRepeatRoute.TabIndex = 5
        Me.chkRepeatRoute.Text = "Repeat Route"
        '
        'chkIgnoreMove
        '
        Me.chkIgnoreMove.AutoSize = True
        Me.chkIgnoreMove.Location = New System.Drawing.Point(9, 663)
        Me.chkIgnoreMove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkIgnoreMove.Name = "chkIgnoreMove"
        Me.chkIgnoreMove.Size = New System.Drawing.Size(216, 24)
        Me.chkIgnoreMove.TabIndex = 4
        Me.chkIgnoreMove.Text = "Ignore if event can't move"
        '
        'DarkGroupBox10
        '
        Me.DarkGroupBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox10.Controls.Add(Me.lstvwMoveRoute)
        Me.DarkGroupBox10.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox10.Location = New System.Drawing.Point(304, 15)
        Me.DarkGroupBox10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox10.Name = "DarkGroupBox10"
        Me.DarkGroupBox10.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox10.Size = New System.Drawing.Size(892, 638)
        Me.DarkGroupBox10.TabIndex = 3
        Me.DarkGroupBox10.TabStop = False
        Me.DarkGroupBox10.Text = "Commands"
        '
        'lstvwMoveRoute
        '
        Me.lstvwMoveRoute.AutoArrange = False
        Me.lstvwMoveRoute.BackColor = System.Drawing.Color.DimGray
        Me.lstvwMoveRoute.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwMoveRoute.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstvwMoveRoute.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstvwMoveRoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwMoveRoute.ForeColor = System.Drawing.Color.Gainsboro
        ListViewGroup1.Header = "Movement"
        ListViewGroup1.Name = "lstVgMovement"
        ListViewGroup2.Header = "Wait"
        ListViewGroup2.Name = "lstVgWait"
        ListViewGroup3.Header = "Turning"
        ListViewGroup3.Name = "lstVgTurn"
        ListViewGroup4.Header = "Speed"
        ListViewGroup4.Name = "lstVgSpeed"
        ListViewGroup5.Header = "Walk Animation"
        ListViewGroup5.Name = "lstVgWalk"
        ListViewGroup6.Header = "Fixed Direction"
        ListViewGroup6.Name = "lstVgDirection"
        ListViewGroup7.Header = "WalkThrough"
        ListViewGroup7.Name = "lstVgWalkThrough"
        ListViewGroup8.Header = "Set Position"
        ListViewGroup8.Name = "lstVgSetposition"
        ListViewGroup9.Header = "Set Graphic"
        ListViewGroup9.Name = "lstVgSetGraphic"
        Me.lstvwMoveRoute.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4, ListViewGroup5, ListViewGroup6, ListViewGroup7, ListViewGroup8, ListViewGroup9})
        Me.lstvwMoveRoute.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstvwMoveRoute.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.IndentCount = 1
        ListViewItem3.Group = ListViewGroup1
        ListViewItem4.Group = ListViewGroup1
        ListViewItem4.IndentCount = 1
        ListViewItem5.Group = ListViewGroup1
        ListViewItem6.Group = ListViewGroup1
        ListViewItem7.Group = ListViewGroup1
        ListViewItem8.Group = ListViewGroup1
        ListViewItem9.Group = ListViewGroup1
        ListViewItem10.Group = ListViewGroup2
        ListViewItem11.Group = ListViewGroup2
        ListViewItem12.Group = ListViewGroup2
        ListViewItem13.Group = ListViewGroup3
        ListViewItem14.Group = ListViewGroup3
        ListViewItem15.Group = ListViewGroup3
        ListViewItem16.Group = ListViewGroup3
        ListViewItem17.Group = ListViewGroup3
        ListViewItem18.Group = ListViewGroup3
        ListViewItem19.Group = ListViewGroup3
        ListViewItem20.Group = ListViewGroup3
        ListViewItem21.Group = ListViewGroup3
        ListViewItem22.Group = ListViewGroup3
        ListViewItem23.Group = ListViewGroup4
        ListViewItem24.Group = ListViewGroup4
        ListViewItem25.Group = ListViewGroup4
        ListViewItem26.Group = ListViewGroup4
        ListViewItem27.Group = ListViewGroup4
        ListViewItem28.Group = ListViewGroup4
        ListViewItem29.Group = ListViewGroup4
        ListViewItem30.Group = ListViewGroup4
        ListViewItem31.Group = ListViewGroup4
        ListViewItem32.Group = ListViewGroup4
        ListViewItem33.Group = ListViewGroup4
        ListViewItem34.Group = ListViewGroup5
        ListViewItem35.Group = ListViewGroup5
        ListViewItem36.Group = ListViewGroup6
        ListViewItem37.Group = ListViewGroup6
        ListViewItem38.Group = ListViewGroup7
        ListViewItem39.Group = ListViewGroup7
        ListViewItem40.Group = ListViewGroup8
        ListViewItem41.Group = ListViewGroup8
        ListViewItem42.Group = ListViewGroup8
        ListViewItem43.Group = ListViewGroup9
        Me.lstvwMoveRoute.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32, ListViewItem33, ListViewItem34, ListViewItem35, ListViewItem36, ListViewItem37, ListViewItem38, ListViewItem39, ListViewItem40, ListViewItem41, ListViewItem42, ListViewItem43})
        Me.lstvwMoveRoute.LabelWrap = False
        Me.lstvwMoveRoute.Location = New System.Drawing.Point(4, 24)
        Me.lstvwMoveRoute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwMoveRoute.MultiSelect = False
        Me.lstvwMoveRoute.Name = "lstvwMoveRoute"
        Me.lstvwMoveRoute.Size = New System.Drawing.Size(884, 611)
        Me.lstvwMoveRoute.TabIndex = 5
        Me.lstvwMoveRoute.UseCompatibleStateImageBehavior = False
        Me.lstvwMoveRoute.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = ""
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = ""
        Me.ColumnHeader4.Width = 150
        '
        'lstMoveRoute
        '
        Me.lstMoveRoute.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lstMoveRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstMoveRoute.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstMoveRoute.FormattingEnabled = True
        Me.lstMoveRoute.ItemHeight = 20
        Me.lstMoveRoute.Location = New System.Drawing.Point(9, 71)
        Me.lstMoveRoute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstMoveRoute.Name = "lstMoveRoute"
        Me.lstMoveRoute.Size = New System.Drawing.Size(286, 582)
        Me.lstMoveRoute.TabIndex = 2
        '
        'cmbEvent
        '
        Me.cmbEvent.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbEvent.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbEvent.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbEvent.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbEvent.ButtonIcon = CType(resources.GetObject("cmbEvent.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbEvent.DrawDropdownHoverOutline = False
        Me.cmbEvent.DrawFocusRectangle = False
        Me.cmbEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEvent.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbEvent.FormattingEnabled = True
        Me.cmbEvent.Location = New System.Drawing.Point(9, 29)
        Me.cmbEvent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbEvent.Name = "cmbEvent"
        Me.cmbEvent.Size = New System.Drawing.Size(284, 27)
        Me.cmbEvent.TabIndex = 0
        Me.cmbEvent.Text = Nothing
        Me.cmbEvent.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraGraphic
        '
        Me.fraGraphic.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraGraphic.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraGraphic.Controls.Add(Me.pnlGraphicSel)
        Me.fraGraphic.Controls.Add(Me.btnGraphicOk)
        Me.fraGraphic.Controls.Add(Me.btnGraphicCancel)
        Me.fraGraphic.Controls.Add(Me.DarkLabel13)
        Me.fraGraphic.Controls.Add(Me.nudGraphic)
        Me.fraGraphic.Controls.Add(Me.DarkLabel12)
        Me.fraGraphic.Controls.Add(Me.cmbGraphic)
        Me.fraGraphic.Controls.Add(Me.DarkLabel11)
        Me.fraGraphic.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraGraphic.Location = New System.Drawing.Point(1209, 174)
        Me.fraGraphic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraGraphic.Name = "fraGraphic"
        Me.fraGraphic.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraGraphic.Size = New System.Drawing.Size(117, 111)
        Me.fraGraphic.TabIndex = 9
        Me.fraGraphic.TabStop = False
        Me.fraGraphic.Text = "Graphic Selection"
        Me.fraGraphic.Visible = False
        '
        'pnlGraphicSel
        '
        Me.pnlGraphicSel.AutoScroll = True
        Me.pnlGraphicSel.Controls.Add(Me.picGraphicSel)
        Me.pnlGraphicSel.Location = New System.Drawing.Point(9, 69)
        Me.pnlGraphicSel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlGraphicSel.Name = "pnlGraphicSel"
        Me.pnlGraphicSel.Size = New System.Drawing.Size(1212, 798)
        Me.pnlGraphicSel.TabIndex = 9
        '
        'picGraphicSel
        '
        Me.picGraphicSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picGraphicSel.Location = New System.Drawing.Point(0, 0)
        Me.picGraphicSel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picGraphicSel.Name = "picGraphicSel"
        Me.picGraphicSel.Size = New System.Drawing.Size(1203, 791)
        Me.picGraphicSel.TabIndex = 5
        Me.picGraphicSel.TabStop = False
        '
        'btnGraphicOk
        '
        Me.btnGraphicOk.Location = New System.Drawing.Point(978, 877)
        Me.btnGraphicOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGraphicOk.Name = "btnGraphicOk"
        Me.btnGraphicOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnGraphicOk.Size = New System.Drawing.Size(112, 35)
        Me.btnGraphicOk.TabIndex = 8
        Me.btnGraphicOk.Text = "Ok"
        '
        'btnGraphicCancel
        '
        Me.btnGraphicCancel.Location = New System.Drawing.Point(1100, 877)
        Me.btnGraphicCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGraphicCancel.Name = "btnGraphicCancel"
        Me.btnGraphicCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnGraphicCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnGraphicCancel.TabIndex = 7
        Me.btnGraphicCancel.Text = "Cancel"
        '
        'DarkLabel13
        '
        Me.DarkLabel13.AutoSize = True
        Me.DarkLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel13.Location = New System.Drawing.Point(14, 878)
        Me.DarkLabel13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel13.Name = "DarkLabel13"
        Me.DarkLabel13.Size = New System.Drawing.Size(237, 20)
        Me.DarkLabel13.TabIndex = 6
        Me.DarkLabel13.Text = "Hold Shift to select multiple tiles."
        '
        'nudGraphic
        '
        Me.nudGraphic.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudGraphic.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudGraphic.Location = New System.Drawing.Point(570, 29)
        Me.nudGraphic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudGraphic.Name = "nudGraphic"
        Me.nudGraphic.Size = New System.Drawing.Size(180, 26)
        Me.nudGraphic.TabIndex = 3
        Me.nudGraphic.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel12
        '
        Me.DarkLabel12.AutoSize = True
        Me.DarkLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel12.Location = New System.Drawing.Point(490, 32)
        Me.DarkLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel12.Name = "DarkLabel12"
        Me.DarkLabel12.Size = New System.Drawing.Size(69, 20)
        Me.DarkLabel12.TabIndex = 2
        Me.DarkLabel12.Text = "Number:"
        '
        'cmbGraphic
        '
        Me.cmbGraphic.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbGraphic.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbGraphic.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbGraphic.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbGraphic.ButtonIcon = CType(resources.GetObject("cmbGraphic.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbGraphic.DrawDropdownHoverOutline = False
        Me.cmbGraphic.DrawFocusRectangle = False
        Me.cmbGraphic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGraphic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGraphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGraphic.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbGraphic.FormattingEnabled = True
        Me.cmbGraphic.Items.AddRange(New Object() {"None", "Character", "Tileset"})
        Me.cmbGraphic.Location = New System.Drawing.Point(156, 28)
        Me.cmbGraphic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbGraphic.Name = "cmbGraphic"
        Me.cmbGraphic.Size = New System.Drawing.Size(324, 27)
        Me.cmbGraphic.TabIndex = 1
        Me.cmbGraphic.Text = Nothing
        Me.cmbGraphic.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel11
        '
        Me.DarkLabel11.AutoSize = True
        Me.DarkLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel11.Location = New System.Drawing.Point(28, 32)
        Me.DarkLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel11.Name = "DarkLabel11"
        Me.DarkLabel11.Size = New System.Drawing.Size(115, 20)
        Me.DarkLabel11.TabIndex = 0
        Me.DarkLabel11.Text = "Graphics Type:"
        '
        'fraDialogue
        '
        Me.fraDialogue.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraDialogue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraDialogue.Controls.Add(Me.fraConditionalBranch)
        Me.fraDialogue.Controls.Add(Me.fraPlayAnimation)
        Me.fraDialogue.Controls.Add(Me.fraMoveRouteWait)
        Me.fraDialogue.Controls.Add(Me.fraCustomScript)
        Me.fraDialogue.Controls.Add(Me.fraSetWeather)
        Me.fraDialogue.Controls.Add(Me.fraSpawnNpc)
        Me.fraDialogue.Controls.Add(Me.fraGiveExp)
        Me.fraDialogue.Controls.Add(Me.fraEndQuest)
        Me.fraDialogue.Controls.Add(Me.fraSetAccess)
        Me.fraDialogue.Controls.Add(Me.fraSetWait)
        Me.fraDialogue.Controls.Add(Me.fraShowPic)
        Me.fraDialogue.Controls.Add(Me.fraOpenShop)
        Me.fraDialogue.Controls.Add(Me.fraChangeLevel)
        Me.fraDialogue.Controls.Add(Me.fraChangeGender)
        Me.fraDialogue.Controls.Add(Me.fraGoToLabel)
        Me.fraDialogue.Controls.Add(Me.fraHidePic)
        Me.fraDialogue.Controls.Add(Me.fraBeginQuest)
        Me.fraDialogue.Controls.Add(Me.fraShowChoices)
        Me.fraDialogue.Controls.Add(Me.fraPlayerVariable)
        Me.fraDialogue.Controls.Add(Me.fraChangeSprite)
        Me.fraDialogue.Controls.Add(Me.fraSetSelfSwitch)
        Me.fraDialogue.Controls.Add(Me.fraMapTint)
        Me.fraDialogue.Controls.Add(Me.fraShowChatBubble)
        Me.fraDialogue.Controls.Add(Me.fraPlaySound)
        Me.fraDialogue.Controls.Add(Me.fraChangePK)
        Me.fraDialogue.Controls.Add(Me.fraCreateLabel)
        Me.fraDialogue.Controls.Add(Me.fraChangeClass)
        Me.fraDialogue.Controls.Add(Me.fraChangeSkills)
        Me.fraDialogue.Controls.Add(Me.fraCompleteTask)
        Me.fraDialogue.Controls.Add(Me.fraPlayerWarp)
        Me.fraDialogue.Controls.Add(Me.fraSetFog)
        Me.fraDialogue.Controls.Add(Me.fraShowText)
        Me.fraDialogue.Controls.Add(Me.fraAddText)
        Me.fraDialogue.Controls.Add(Me.fraPlayerSwitch)
        Me.fraDialogue.Controls.Add(Me.fraChangeItems)
        Me.fraDialogue.Controls.Add(Me.fraPlayBGM)
        Me.fraDialogue.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraDialogue.Location = New System.Drawing.Point(1358, 18)
        Me.fraDialogue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraDialogue.Name = "fraDialogue"
        Me.fraDialogue.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraDialogue.Size = New System.Drawing.Size(998, 915)
        Me.fraDialogue.TabIndex = 10
        Me.fraDialogue.TabStop = False
        Me.fraDialogue.Visible = False
        '
        'fraConditionalBranch
        '
        Me.fraConditionalBranch.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraConditionalBranch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_Time)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition9)
        Me.fraConditionalBranch.Controls.Add(Me.btnConditionalBranchOk)
        Me.fraConditionalBranch.Controls.Add(Me.btnConditionalBranchCancel)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_Gender)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition8)
        Me.fraConditionalBranch.Controls.Add(Me.fraConditions_Quest)
        Me.fraConditionalBranch.Controls.Add(Me.nudCondition_Quest)
        Me.fraConditionalBranch.Controls.Add(Me.DarkLabel18)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition7)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_SelfSwitchCondition)
        Me.fraConditionalBranch.Controls.Add(Me.DarkLabel17)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_SelfSwitch)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition6)
        Me.fraConditionalBranch.Controls.Add(Me.nudCondition_LevelAmount)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition5)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_LevelCompare)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_LearntSkill)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition4)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_ClassIs)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition3)
        Me.fraConditionalBranch.Controls.Add(Me.nudCondition_HasItem)
        Me.fraConditionalBranch.Controls.Add(Me.DarkLabel16)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_HasItem)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition2)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition1)
        Me.fraConditionalBranch.Controls.Add(Me.DarkLabel15)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondtion_PlayerSwitchCondition)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_PlayerSwitch)
        Me.fraConditionalBranch.Controls.Add(Me.nudCondition_PlayerVarCondition)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_PlayerVarCompare)
        Me.fraConditionalBranch.Controls.Add(Me.DarkLabel14)
        Me.fraConditionalBranch.Controls.Add(Me.cmbCondition_PlayerVarIndex)
        Me.fraConditionalBranch.Controls.Add(Me.optCondition0)
        Me.fraConditionalBranch.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraConditionalBranch.Location = New System.Drawing.Point(9, 11)
        Me.fraConditionalBranch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraConditionalBranch.Name = "fraConditionalBranch"
        Me.fraConditionalBranch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraConditionalBranch.Size = New System.Drawing.Size(584, 688)
        Me.fraConditionalBranch.TabIndex = 0
        Me.fraConditionalBranch.TabStop = False
        Me.fraConditionalBranch.Text = "Árvore Condicional"
        Me.fraConditionalBranch.Visible = False
        '
        'cmbCondition_Time
        '
        Me.cmbCondition_Time.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_Time.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_Time.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_Time.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_Time.ButtonIcon = CType(resources.GetObject("cmbCondition_Time.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_Time.DrawDropdownHoverOutline = False
        Me.cmbCondition_Time.DrawFocusRectangle = False
        Me.cmbCondition_Time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbCondition_Time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_Time.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_Time.FormattingEnabled = True
        Me.cmbCondition_Time.Items.AddRange(New Object() {"Day", "Night", "Dawn", "Dusk"})
        Me.cmbCondition_Time.Location = New System.Drawing.Point(358, 531)
        Me.cmbCondition_Time.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_Time.Name = "cmbCondition_Time"
        Me.cmbCondition_Time.Size = New System.Drawing.Size(214, 27)
        Me.cmbCondition_Time.TabIndex = 33
        Me.cmbCondition_Time.Text = Nothing
        Me.cmbCondition_Time.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'optCondition9
        '
        Me.optCondition9.AutoSize = True
        Me.optCondition9.Location = New System.Drawing.Point(9, 532)
        Me.optCondition9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition9.Name = "optCondition9"
        Me.optCondition9.Size = New System.Drawing.Size(136, 24)
        Me.optCondition9.TabIndex = 32
        Me.optCondition9.TabStop = True
        Me.optCondition9.Text = "Hora do Dia é:"
        '
        'btnConditionalBranchOk
        '
        Me.btnConditionalBranchOk.Location = New System.Drawing.Point(339, 640)
        Me.btnConditionalBranchOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConditionalBranchOk.Name = "btnConditionalBranchOk"
        Me.btnConditionalBranchOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnConditionalBranchOk.Size = New System.Drawing.Size(112, 35)
        Me.btnConditionalBranchOk.TabIndex = 31
        Me.btnConditionalBranchOk.Text = "Confirmar"
        '
        'btnConditionalBranchCancel
        '
        Me.btnConditionalBranchCancel.Location = New System.Drawing.Point(460, 640)
        Me.btnConditionalBranchCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConditionalBranchCancel.Name = "btnConditionalBranchCancel"
        Me.btnConditionalBranchCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnConditionalBranchCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnConditionalBranchCancel.TabIndex = 30
        Me.btnConditionalBranchCancel.Text = "Cancelar"
        '
        'cmbCondition_Gender
        '
        Me.cmbCondition_Gender.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_Gender.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_Gender.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_Gender.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_Gender.ButtonIcon = CType(resources.GetObject("cmbCondition_Gender.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_Gender.DrawDropdownHoverOutline = False
        Me.cmbCondition_Gender.DrawFocusRectangle = False
        Me.cmbCondition_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_Gender.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_Gender.FormattingEnabled = True
        Me.cmbCondition_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbCondition_Gender.Location = New System.Drawing.Point(358, 489)
        Me.cmbCondition_Gender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_Gender.Name = "cmbCondition_Gender"
        Me.cmbCondition_Gender.Size = New System.Drawing.Size(214, 27)
        Me.cmbCondition_Gender.TabIndex = 29
        Me.cmbCondition_Gender.Text = Nothing
        Me.cmbCondition_Gender.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'optCondition8
        '
        Me.optCondition8.AutoSize = True
        Me.optCondition8.Location = New System.Drawing.Point(9, 491)
        Me.optCondition8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition8.Name = "optCondition8"
        Me.optCondition8.Size = New System.Drawing.Size(189, 24)
        Me.optCondition8.TabIndex = 28
        Me.optCondition8.TabStop = True
        Me.optCondition8.Text = "Gênero do Jogador é:"
        '
        'fraConditions_Quest
        '
        Me.fraConditions_Quest.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraConditions_Quest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraConditions_Quest.Controls.Add(Me.DarkLabel20)
        Me.fraConditions_Quest.Controls.Add(Me.nudCondition_QuestTask)
        Me.fraConditions_Quest.Controls.Add(Me.cmbCondition_General)
        Me.fraConditions_Quest.Controls.Add(Me.DarkLabel19)
        Me.fraConditions_Quest.Controls.Add(Me.optCondition_Quest1)
        Me.fraConditions_Quest.Controls.Add(Me.optCondition_Quest0)
        Me.fraConditions_Quest.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraConditions_Quest.Location = New System.Drawing.Point(9, 363)
        Me.fraConditions_Quest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraConditions_Quest.Name = "fraConditions_Quest"
        Me.fraConditions_Quest.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraConditions_Quest.Size = New System.Drawing.Size(564, 118)
        Me.fraConditions_Quest.TabIndex = 27
        Me.fraConditions_Quest.TabStop = False
        Me.fraConditions_Quest.Text = "Condições da Quest"
        '
        'DarkLabel20
        '
        Me.DarkLabel20.AutoSize = True
        Me.DarkLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel20.Location = New System.Drawing.Point(184, 72)
        Me.DarkLabel20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel20.Name = "DarkLabel20"
        Me.DarkLabel20.Size = New System.Drawing.Size(135, 20)
        Me.DarkLabel20.TabIndex = 5
        Me.DarkLabel20.Text = "Player is on task..."
        '
        'nudCondition_QuestTask
        '
        Me.nudCondition_QuestTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudCondition_QuestTask.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudCondition_QuestTask.Location = New System.Drawing.Point(350, 69)
        Me.nudCondition_QuestTask.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudCondition_QuestTask.Name = "nudCondition_QuestTask"
        Me.nudCondition_QuestTask.Size = New System.Drawing.Size(206, 26)
        Me.nudCondition_QuestTask.TabIndex = 4
        Me.nudCondition_QuestTask.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbCondition_General
        '
        Me.cmbCondition_General.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_General.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_General.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_General.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_General.ButtonIcon = CType(resources.GetObject("cmbCondition_General.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_General.DrawDropdownHoverOutline = False
        Me.cmbCondition_General.DrawFocusRectangle = False
        Me.cmbCondition_General.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_General.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_General.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_General.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_General.FormattingEnabled = True
        Me.cmbCondition_General.Items.AddRange(New Object() {"Not Started", "Started", "Completed", "Can Start", "Can End"})
        Me.cmbCondition_General.Location = New System.Drawing.Point(350, 28)
        Me.cmbCondition_General.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_General.Name = "cmbCondition_General"
        Me.cmbCondition_General.Size = New System.Drawing.Size(204, 27)
        Me.cmbCondition_General.TabIndex = 3
        Me.cmbCondition_General.Text = "Not Started"
        Me.cmbCondition_General.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel19
        '
        Me.DarkLabel19.AutoSize = True
        Me.DarkLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel19.Location = New System.Drawing.Point(184, 32)
        Me.DarkLabel19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel19.Name = "DarkLabel19"
        Me.DarkLabel19.Size = New System.Drawing.Size(154, 20)
        Me.DarkLabel19.TabIndex = 2
        Me.DarkLabel19.Text = "If selected quest is..."
        '
        'optCondition_Quest1
        '
        Me.optCondition_Quest1.AutoSize = True
        Me.optCondition_Quest1.Location = New System.Drawing.Point(9, 69)
        Me.optCondition_Quest1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition_Quest1.Name = "optCondition_Quest1"
        Me.optCondition_Quest1.Size = New System.Drawing.Size(80, 24)
        Me.optCondition_Quest1.TabIndex = 1
        Me.optCondition_Quest1.TabStop = True
        Me.optCondition_Quest1.Text = "Tarefa"
        '
        'optCondition_Quest0
        '
        Me.optCondition_Quest0.AutoSize = True
        Me.optCondition_Quest0.Location = New System.Drawing.Point(9, 29)
        Me.optCondition_Quest0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition_Quest0.Name = "optCondition_Quest0"
        Me.optCondition_Quest0.Size = New System.Drawing.Size(91, 24)
        Me.optCondition_Quest0.TabIndex = 0
        Me.optCondition_Quest0.TabStop = True
        Me.optCondition_Quest0.Text = "General"
        '
        'nudCondition_Quest
        '
        Me.nudCondition_Quest.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudCondition_Quest.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudCondition_Quest.Location = New System.Drawing.Point(393, 323)
        Me.nudCondition_Quest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudCondition_Quest.Name = "nudCondition_Quest"
        Me.nudCondition_Quest.Size = New System.Drawing.Size(180, 26)
        Me.nudCondition_Quest.TabIndex = 26
        Me.nudCondition_Quest.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel18
        '
        Me.DarkLabel18.AutoSize = True
        Me.DarkLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel18.Location = New System.Drawing.Point(327, 328)
        Me.DarkLabel18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel18.Name = "DarkLabel18"
        Me.DarkLabel18.Size = New System.Drawing.Size(56, 20)
        Me.DarkLabel18.TabIndex = 25
        Me.DarkLabel18.Text = "Quest:"
        '
        'optCondition7
        '
        Me.optCondition7.AutoSize = True
        Me.optCondition7.Location = New System.Drawing.Point(9, 323)
        Me.optCondition7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition7.Name = "optCondition7"
        Me.optCondition7.Size = New System.Drawing.Size(128, 24)
        Me.optCondition7.TabIndex = 24
        Me.optCondition7.TabStop = True
        Me.optCondition7.Text = "Quest Status"
        '
        'cmbCondition_SelfSwitchCondition
        '
        Me.cmbCondition_SelfSwitchCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_SelfSwitchCondition.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_SelfSwitchCondition.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_SelfSwitchCondition.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_SelfSwitchCondition.ButtonIcon = CType(resources.GetObject("cmbCondition_SelfSwitchCondition.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_SelfSwitchCondition.DrawDropdownHoverOutline = False
        Me.cmbCondition_SelfSwitchCondition.DrawFocusRectangle = False
        Me.cmbCondition_SelfSwitchCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_SelfSwitchCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_SelfSwitchCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_SelfSwitchCondition.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_SelfSwitchCondition.FormattingEnabled = True
        Me.cmbCondition_SelfSwitchCondition.Items.AddRange(New Object() {"False", "True"})
        Me.cmbCondition_SelfSwitchCondition.Location = New System.Drawing.Point(393, 282)
        Me.cmbCondition_SelfSwitchCondition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_SelfSwitchCondition.Name = "cmbCondition_SelfSwitchCondition"
        Me.cmbCondition_SelfSwitchCondition.Size = New System.Drawing.Size(180, 27)
        Me.cmbCondition_SelfSwitchCondition.TabIndex = 23
        Me.cmbCondition_SelfSwitchCondition.Text = "False"
        Me.cmbCondition_SelfSwitchCondition.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel17
        '
        Me.DarkLabel17.AutoSize = True
        Me.DarkLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel17.Location = New System.Drawing.Point(351, 286)
        Me.DarkLabel17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel17.Name = "DarkLabel17"
        Me.DarkLabel17.Size = New System.Drawing.Size(20, 20)
        Me.DarkLabel17.TabIndex = 22
        Me.DarkLabel17.Text = "is"
        '
        'cmbCondition_SelfSwitch
        '
        Me.cmbCondition_SelfSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_SelfSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_SelfSwitch.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_SelfSwitch.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_SelfSwitch.ButtonIcon = CType(resources.GetObject("cmbCondition_SelfSwitch.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_SelfSwitch.DrawDropdownHoverOutline = False
        Me.cmbCondition_SelfSwitch.DrawFocusRectangle = False
        Me.cmbCondition_SelfSwitch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_SelfSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_SelfSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_SelfSwitch.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_SelfSwitch.FormattingEnabled = True
        Me.cmbCondition_SelfSwitch.Location = New System.Drawing.Point(160, 282)
        Me.cmbCondition_SelfSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_SelfSwitch.Name = "cmbCondition_SelfSwitch"
        Me.cmbCondition_SelfSwitch.Size = New System.Drawing.Size(180, 27)
        Me.cmbCondition_SelfSwitch.TabIndex = 21
        Me.cmbCondition_SelfSwitch.Text = Nothing
        Me.cmbCondition_SelfSwitch.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'optCondition6
        '
        Me.optCondition6.AutoSize = True
        Me.optCondition6.Location = New System.Drawing.Point(9, 283)
        Me.optCondition6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition6.Name = "optCondition6"
        Me.optCondition6.Size = New System.Drawing.Size(113, 24)
        Me.optCondition6.TabIndex = 20
        Me.optCondition6.TabStop = True
        Me.optCondition6.Text = "Self Switch"
        '
        'nudCondition_LevelAmount
        '
        Me.nudCondition_LevelAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudCondition_LevelAmount.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudCondition_LevelAmount.Location = New System.Drawing.Point(404, 242)
        Me.nudCondition_LevelAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudCondition_LevelAmount.Name = "nudCondition_LevelAmount"
        Me.nudCondition_LevelAmount.Size = New System.Drawing.Size(170, 26)
        Me.nudCondition_LevelAmount.TabIndex = 19
        Me.nudCondition_LevelAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'optCondition5
        '
        Me.optCondition5.AutoSize = True
        Me.optCondition5.Location = New System.Drawing.Point(9, 242)
        Me.optCondition5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition5.Name = "optCondition5"
        Me.optCondition5.Size = New System.Drawing.Size(86, 24)
        Me.optCondition5.TabIndex = 18
        Me.optCondition5.TabStop = True
        Me.optCondition5.Text = "Level is"
        '
        'cmbCondition_LevelCompare
        '
        Me.cmbCondition_LevelCompare.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_LevelCompare.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_LevelCompare.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_LevelCompare.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_LevelCompare.ButtonIcon = CType(resources.GetObject("cmbCondition_LevelCompare.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_LevelCompare.DrawDropdownHoverOutline = False
        Me.cmbCondition_LevelCompare.DrawFocusRectangle = False
        Me.cmbCondition_LevelCompare.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_LevelCompare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_LevelCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_LevelCompare.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_LevelCompare.FormattingEnabled = True
        Me.cmbCondition_LevelCompare.Items.AddRange(New Object() {"Equal To", "Great Than OrElse Equal To", "Less Than or Equal To", "Greater Than", "Less Than", "Does Not Equal"})
        Me.cmbCondition_LevelCompare.Location = New System.Drawing.Point(160, 240)
        Me.cmbCondition_LevelCompare.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_LevelCompare.Name = "cmbCondition_LevelCompare"
        Me.cmbCondition_LevelCompare.Size = New System.Drawing.Size(232, 27)
        Me.cmbCondition_LevelCompare.TabIndex = 17
        Me.cmbCondition_LevelCompare.Text = "Equal To"
        Me.cmbCondition_LevelCompare.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'cmbCondition_LearntSkill
        '
        Me.cmbCondition_LearntSkill.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_LearntSkill.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_LearntSkill.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_LearntSkill.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_LearntSkill.ButtonIcon = CType(resources.GetObject("cmbCondition_LearntSkill.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_LearntSkill.DrawDropdownHoverOutline = False
        Me.cmbCondition_LearntSkill.DrawFocusRectangle = False
        Me.cmbCondition_LearntSkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_LearntSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_LearntSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_LearntSkill.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_LearntSkill.FormattingEnabled = True
        Me.cmbCondition_LearntSkill.Location = New System.Drawing.Point(160, 198)
        Me.cmbCondition_LearntSkill.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_LearntSkill.Name = "cmbCondition_LearntSkill"
        Me.cmbCondition_LearntSkill.Size = New System.Drawing.Size(412, 27)
        Me.cmbCondition_LearntSkill.TabIndex = 16
        Me.cmbCondition_LearntSkill.Text = Nothing
        Me.cmbCondition_LearntSkill.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'optCondition4
        '
        Me.optCondition4.AutoSize = True
        Me.optCondition4.Location = New System.Drawing.Point(9, 200)
        Me.optCondition4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition4.Name = "optCondition4"
        Me.optCondition4.Size = New System.Drawing.Size(113, 24)
        Me.optCondition4.TabIndex = 15
        Me.optCondition4.TabStop = True
        Me.optCondition4.Text = "Knows Skill"
        '
        'cmbCondition_ClassIs
        '
        Me.cmbCondition_ClassIs.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_ClassIs.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_ClassIs.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_ClassIs.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_ClassIs.ButtonIcon = CType(resources.GetObject("cmbCondition_ClassIs.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_ClassIs.DrawDropdownHoverOutline = False
        Me.cmbCondition_ClassIs.DrawFocusRectangle = False
        Me.cmbCondition_ClassIs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_ClassIs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_ClassIs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_ClassIs.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_ClassIs.FormattingEnabled = True
        Me.cmbCondition_ClassIs.Location = New System.Drawing.Point(160, 157)
        Me.cmbCondition_ClassIs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_ClassIs.Name = "cmbCondition_ClassIs"
        Me.cmbCondition_ClassIs.Size = New System.Drawing.Size(412, 27)
        Me.cmbCondition_ClassIs.TabIndex = 14
        Me.cmbCondition_ClassIs.Text = Nothing
        Me.cmbCondition_ClassIs.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'optCondition3
        '
        Me.optCondition3.AutoSize = True
        Me.optCondition3.Location = New System.Drawing.Point(9, 158)
        Me.optCondition3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition3.Name = "optCondition3"
        Me.optCondition3.Size = New System.Drawing.Size(90, 24)
        Me.optCondition3.TabIndex = 13
        Me.optCondition3.TabStop = True
        Me.optCondition3.Text = "Class Is"
        '
        'nudCondition_HasItem
        '
        Me.nudCondition_HasItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudCondition_HasItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudCondition_HasItem.Location = New System.Drawing.Point(393, 117)
        Me.nudCondition_HasItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudCondition_HasItem.Name = "nudCondition_HasItem"
        Me.nudCondition_HasItem.Size = New System.Drawing.Size(180, 26)
        Me.nudCondition_HasItem.TabIndex = 12
        Me.nudCondition_HasItem.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel16
        '
        Me.DarkLabel16.AutoSize = True
        Me.DarkLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel16.Location = New System.Drawing.Point(351, 120)
        Me.DarkLabel16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel16.Name = "DarkLabel16"
        Me.DarkLabel16.Size = New System.Drawing.Size(20, 20)
        Me.DarkLabel16.TabIndex = 11
        Me.DarkLabel16.Text = "X"
        '
        'cmbCondition_HasItem
        '
        Me.cmbCondition_HasItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_HasItem.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_HasItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_HasItem.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_HasItem.ButtonIcon = CType(resources.GetObject("cmbCondition_HasItem.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_HasItem.DrawDropdownHoverOutline = False
        Me.cmbCondition_HasItem.DrawFocusRectangle = False
        Me.cmbCondition_HasItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_HasItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_HasItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_HasItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_HasItem.FormattingEnabled = True
        Me.cmbCondition_HasItem.Location = New System.Drawing.Point(160, 115)
        Me.cmbCondition_HasItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_HasItem.Name = "cmbCondition_HasItem"
        Me.cmbCondition_HasItem.Size = New System.Drawing.Size(180, 27)
        Me.cmbCondition_HasItem.TabIndex = 10
        Me.cmbCondition_HasItem.Text = Nothing
        Me.cmbCondition_HasItem.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'optCondition2
        '
        Me.optCondition2.AutoSize = True
        Me.optCondition2.Location = New System.Drawing.Point(9, 117)
        Me.optCondition2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition2.Name = "optCondition2"
        Me.optCondition2.Size = New System.Drawing.Size(99, 24)
        Me.optCondition2.TabIndex = 9
        Me.optCondition2.TabStop = True
        Me.optCondition2.Text = "Has Item"
        '
        'optCondition1
        '
        Me.optCondition1.AutoSize = True
        Me.optCondition1.Location = New System.Drawing.Point(9, 75)
        Me.optCondition1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition1.Name = "optCondition1"
        Me.optCondition1.Size = New System.Drawing.Size(128, 24)
        Me.optCondition1.TabIndex = 8
        Me.optCondition1.TabStop = True
        Me.optCondition1.Text = "Player Switch"
        '
        'DarkLabel15
        '
        Me.DarkLabel15.AutoSize = True
        Me.DarkLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel15.Location = New System.Drawing.Point(351, 78)
        Me.DarkLabel15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel15.Name = "DarkLabel15"
        Me.DarkLabel15.Size = New System.Drawing.Size(18, 20)
        Me.DarkLabel15.TabIndex = 7
        Me.DarkLabel15.Text = "é"
        '
        'cmbCondtion_PlayerSwitchCondition
        '
        Me.cmbCondtion_PlayerSwitchCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondtion_PlayerSwitchCondition.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondtion_PlayerSwitchCondition.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondtion_PlayerSwitchCondition.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondtion_PlayerSwitchCondition.ButtonIcon = CType(resources.GetObject("cmbCondtion_PlayerSwitchCondition.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondtion_PlayerSwitchCondition.DrawDropdownHoverOutline = False
        Me.cmbCondtion_PlayerSwitchCondition.DrawFocusRectangle = False
        Me.cmbCondtion_PlayerSwitchCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondtion_PlayerSwitchCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondtion_PlayerSwitchCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondtion_PlayerSwitchCondition.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondtion_PlayerSwitchCondition.FormattingEnabled = True
        Me.cmbCondtion_PlayerSwitchCondition.Items.AddRange(New Object() {"False", "True"})
        Me.cmbCondtion_PlayerSwitchCondition.Location = New System.Drawing.Point(393, 74)
        Me.cmbCondtion_PlayerSwitchCondition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondtion_PlayerSwitchCondition.Name = "cmbCondtion_PlayerSwitchCondition"
        Me.cmbCondtion_PlayerSwitchCondition.Size = New System.Drawing.Size(180, 27)
        Me.cmbCondtion_PlayerSwitchCondition.TabIndex = 6
        Me.cmbCondtion_PlayerSwitchCondition.Text = "False"
        Me.cmbCondtion_PlayerSwitchCondition.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'cmbCondition_PlayerSwitch
        '
        Me.cmbCondition_PlayerSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_PlayerSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_PlayerSwitch.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_PlayerSwitch.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_PlayerSwitch.ButtonIcon = CType(resources.GetObject("cmbCondition_PlayerSwitch.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_PlayerSwitch.DrawDropdownHoverOutline = False
        Me.cmbCondition_PlayerSwitch.DrawFocusRectangle = False
        Me.cmbCondition_PlayerSwitch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_PlayerSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_PlayerSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_PlayerSwitch.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_PlayerSwitch.FormattingEnabled = True
        Me.cmbCondition_PlayerSwitch.Location = New System.Drawing.Point(160, 74)
        Me.cmbCondition_PlayerSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_PlayerSwitch.Name = "cmbCondition_PlayerSwitch"
        Me.cmbCondition_PlayerSwitch.Size = New System.Drawing.Size(180, 27)
        Me.cmbCondition_PlayerSwitch.TabIndex = 5
        Me.cmbCondition_PlayerSwitch.Text = Nothing
        Me.cmbCondition_PlayerSwitch.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'nudCondition_PlayerVarCondition
        '
        Me.nudCondition_PlayerVarCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudCondition_PlayerVarCondition.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudCondition_PlayerVarCondition.Location = New System.Drawing.Point(502, 34)
        Me.nudCondition_PlayerVarCondition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudCondition_PlayerVarCondition.Name = "nudCondition_PlayerVarCondition"
        Me.nudCondition_PlayerVarCondition.Size = New System.Drawing.Size(70, 26)
        Me.nudCondition_PlayerVarCondition.TabIndex = 4
        Me.nudCondition_PlayerVarCondition.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbCondition_PlayerVarCompare
        '
        Me.cmbCondition_PlayerVarCompare.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_PlayerVarCompare.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_PlayerVarCompare.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_PlayerVarCompare.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_PlayerVarCompare.ButtonIcon = CType(resources.GetObject("cmbCondition_PlayerVarCompare.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_PlayerVarCompare.DrawDropdownHoverOutline = False
        Me.cmbCondition_PlayerVarCompare.DrawFocusRectangle = False
        Me.cmbCondition_PlayerVarCompare.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_PlayerVarCompare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_PlayerVarCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_PlayerVarCompare.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_PlayerVarCompare.FormattingEnabled = True
        Me.cmbCondition_PlayerVarCompare.Items.AddRange(New Object() {"Equal To", "Great Than OrElse Equal To", "Less Than or Equal To", "Greater Than", "Less Than", "Does Not Equal"})
        Me.cmbCondition_PlayerVarCompare.Location = New System.Drawing.Point(354, 32)
        Me.cmbCondition_PlayerVarCompare.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_PlayerVarCompare.Name = "cmbCondition_PlayerVarCompare"
        Me.cmbCondition_PlayerVarCompare.Size = New System.Drawing.Size(130, 27)
        Me.cmbCondition_PlayerVarCompare.TabIndex = 3
        Me.cmbCondition_PlayerVarCompare.Text = "Equal To"
        Me.cmbCondition_PlayerVarCompare.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel14
        '
        Me.DarkLabel14.AutoSize = True
        Me.DarkLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel14.Location = New System.Drawing.Point(324, 37)
        Me.DarkLabel14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel14.Name = "DarkLabel14"
        Me.DarkLabel14.Size = New System.Drawing.Size(18, 20)
        Me.DarkLabel14.TabIndex = 2
        Me.DarkLabel14.Text = "é"
        '
        'cmbCondition_PlayerVarIndex
        '
        Me.cmbCondition_PlayerVarIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCondition_PlayerVarIndex.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCondition_PlayerVarIndex.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCondition_PlayerVarIndex.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCondition_PlayerVarIndex.ButtonIcon = CType(resources.GetObject("cmbCondition_PlayerVarIndex.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCondition_PlayerVarIndex.DrawDropdownHoverOutline = False
        Me.cmbCondition_PlayerVarIndex.DrawFocusRectangle = False
        Me.cmbCondition_PlayerVarIndex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition_PlayerVarIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition_PlayerVarIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition_PlayerVarIndex.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCondition_PlayerVarIndex.FormattingEnabled = True
        Me.cmbCondition_PlayerVarIndex.Location = New System.Drawing.Point(160, 32)
        Me.cmbCondition_PlayerVarIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCondition_PlayerVarIndex.Name = "cmbCondition_PlayerVarIndex"
        Me.cmbCondition_PlayerVarIndex.Size = New System.Drawing.Size(152, 27)
        Me.cmbCondition_PlayerVarIndex.TabIndex = 1
        Me.cmbCondition_PlayerVarIndex.Text = Nothing
        Me.cmbCondition_PlayerVarIndex.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'optCondition0
        '
        Me.optCondition0.AutoSize = True
        Me.optCondition0.Location = New System.Drawing.Point(9, 34)
        Me.optCondition0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optCondition0.Name = "optCondition0"
        Me.optCondition0.Size = New System.Drawing.Size(139, 24)
        Me.optCondition0.TabIndex = 0
        Me.optCondition0.TabStop = True
        Me.optCondition0.Text = "Player Variable"
        '
        'fraPlayAnimation
        '
        Me.fraPlayAnimation.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraPlayAnimation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraPlayAnimation.Controls.Add(Me.btnPlayAnimationOk)
        Me.fraPlayAnimation.Controls.Add(Me.btnPlayAnimationCancel)
        Me.fraPlayAnimation.Controls.Add(Me.lblPlayAnimY)
        Me.fraPlayAnimation.Controls.Add(Me.lblPlayAnimX)
        Me.fraPlayAnimation.Controls.Add(Me.cmbPlayAnimEvent)
        Me.fraPlayAnimation.Controls.Add(Me.DarkLabel62)
        Me.fraPlayAnimation.Controls.Add(Me.cmbAnimTargetType)
        Me.fraPlayAnimation.Controls.Add(Me.nudPlayAnimTileY)
        Me.fraPlayAnimation.Controls.Add(Me.nudPlayAnimTileX)
        Me.fraPlayAnimation.Controls.Add(Me.DarkLabel61)
        Me.fraPlayAnimation.Controls.Add(Me.cmbPlayAnim)
        Me.fraPlayAnimation.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraPlayAnimation.Location = New System.Drawing.Point(602, 395)
        Me.fraPlayAnimation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayAnimation.Name = "fraPlayAnimation"
        Me.fraPlayAnimation.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayAnimation.Size = New System.Drawing.Size(372, 249)
        Me.fraPlayAnimation.TabIndex = 36
        Me.fraPlayAnimation.TabStop = False
        Me.fraPlayAnimation.Text = "Play Animation"
        Me.fraPlayAnimation.Visible = False
        '
        'btnPlayAnimationOk
        '
        Me.btnPlayAnimationOk.Location = New System.Drawing.Point(129, 203)
        Me.btnPlayAnimationOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlayAnimationOk.Name = "btnPlayAnimationOk"
        Me.btnPlayAnimationOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlayAnimationOk.Size = New System.Drawing.Size(112, 35)
        Me.btnPlayAnimationOk.TabIndex = 36
        Me.btnPlayAnimationOk.Text = "Ok"
        '
        'btnPlayAnimationCancel
        '
        Me.btnPlayAnimationCancel.Location = New System.Drawing.Point(250, 203)
        Me.btnPlayAnimationCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlayAnimationCancel.Name = "btnPlayAnimationCancel"
        Me.btnPlayAnimationCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlayAnimationCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnPlayAnimationCancel.TabIndex = 35
        Me.btnPlayAnimationCancel.Text = "Cancel"
        '
        'lblPlayAnimY
        '
        Me.lblPlayAnimY.AutoSize = True
        Me.lblPlayAnimY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblPlayAnimY.Location = New System.Drawing.Point(196, 163)
        Me.lblPlayAnimY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayAnimY.Name = "lblPlayAnimY"
        Me.lblPlayAnimY.Size = New System.Drawing.Size(87, 20)
        Me.lblPlayAnimY.TabIndex = 34
        Me.lblPlayAnimY.Text = "Map Tile Y:"
        '
        'lblPlayAnimX
        '
        Me.lblPlayAnimX.AutoSize = True
        Me.lblPlayAnimX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblPlayAnimX.Location = New System.Drawing.Point(9, 163)
        Me.lblPlayAnimX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayAnimX.Name = "lblPlayAnimX"
        Me.lblPlayAnimX.Size = New System.Drawing.Size(87, 20)
        Me.lblPlayAnimX.TabIndex = 33
        Me.lblPlayAnimX.Text = "Map Tile X:"
        '
        'cmbPlayAnimEvent
        '
        Me.cmbPlayAnimEvent.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPlayAnimEvent.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPlayAnimEvent.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPlayAnimEvent.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPlayAnimEvent.ButtonIcon = CType(resources.GetObject("cmbPlayAnimEvent.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPlayAnimEvent.DrawDropdownHoverOutline = False
        Me.cmbPlayAnimEvent.DrawFocusRectangle = False
        Me.cmbPlayAnimEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPlayAnimEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayAnimEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayAnimEvent.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPlayAnimEvent.FormattingEnabled = True
        Me.cmbPlayAnimEvent.Location = New System.Drawing.Point(124, 112)
        Me.cmbPlayAnimEvent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPlayAnimEvent.Name = "cmbPlayAnimEvent"
        Me.cmbPlayAnimEvent.Size = New System.Drawing.Size(236, 27)
        Me.cmbPlayAnimEvent.TabIndex = 32
        Me.cmbPlayAnimEvent.Text = Nothing
        Me.cmbPlayAnimEvent.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel62
        '
        Me.DarkLabel62.AutoSize = True
        Me.DarkLabel62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel62.Location = New System.Drawing.Point(6, 75)
        Me.DarkLabel62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel62.Name = "DarkLabel62"
        Me.DarkLabel62.Size = New System.Drawing.Size(93, 20)
        Me.DarkLabel62.TabIndex = 31
        Me.DarkLabel62.Text = "Target Type"
        '
        'cmbAnimTargetType
        '
        Me.cmbAnimTargetType.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbAnimTargetType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbAnimTargetType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbAnimTargetType.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbAnimTargetType.ButtonIcon = CType(resources.GetObject("cmbAnimTargetType.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbAnimTargetType.DrawDropdownHoverOutline = False
        Me.cmbAnimTargetType.DrawFocusRectangle = False
        Me.cmbAnimTargetType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAnimTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnimTargetType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAnimTargetType.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbAnimTargetType.FormattingEnabled = True
        Me.cmbAnimTargetType.Items.AddRange(New Object() {"Player", "Event", "Tile"})
        Me.cmbAnimTargetType.Location = New System.Drawing.Point(124, 71)
        Me.cmbAnimTargetType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbAnimTargetType.Name = "cmbAnimTargetType"
        Me.cmbAnimTargetType.Size = New System.Drawing.Size(236, 27)
        Me.cmbAnimTargetType.TabIndex = 30
        Me.cmbAnimTargetType.Text = Nothing
        Me.cmbAnimTargetType.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'nudPlayAnimTileY
        '
        Me.nudPlayAnimTileY.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudPlayAnimTileY.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudPlayAnimTileY.Location = New System.Drawing.Point(297, 160)
        Me.nudPlayAnimTileY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPlayAnimTileY.Name = "nudPlayAnimTileY"
        Me.nudPlayAnimTileY.Size = New System.Drawing.Size(66, 26)
        Me.nudPlayAnimTileY.TabIndex = 29
        Me.nudPlayAnimTileY.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'nudPlayAnimTileX
        '
        Me.nudPlayAnimTileX.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudPlayAnimTileX.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudPlayAnimTileX.Location = New System.Drawing.Point(110, 160)
        Me.nudPlayAnimTileX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPlayAnimTileX.Name = "nudPlayAnimTileX"
        Me.nudPlayAnimTileX.Size = New System.Drawing.Size(66, 26)
        Me.nudPlayAnimTileX.TabIndex = 28
        Me.nudPlayAnimTileX.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel61
        '
        Me.DarkLabel61.AutoSize = True
        Me.DarkLabel61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel61.Location = New System.Drawing.Point(9, 34)
        Me.DarkLabel61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel61.Name = "DarkLabel61"
        Me.DarkLabel61.Size = New System.Drawing.Size(84, 20)
        Me.DarkLabel61.TabIndex = 1
        Me.DarkLabel61.Text = "Animation:"
        '
        'cmbPlayAnim
        '
        Me.cmbPlayAnim.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPlayAnim.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPlayAnim.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPlayAnim.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPlayAnim.ButtonIcon = CType(resources.GetObject("cmbPlayAnim.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPlayAnim.DrawDropdownHoverOutline = False
        Me.cmbPlayAnim.DrawFocusRectangle = False
        Me.cmbPlayAnim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPlayAnim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayAnim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayAnim.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPlayAnim.FormattingEnabled = True
        Me.cmbPlayAnim.Location = New System.Drawing.Point(93, 29)
        Me.cmbPlayAnim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPlayAnim.Name = "cmbPlayAnim"
        Me.cmbPlayAnim.Size = New System.Drawing.Size(268, 27)
        Me.cmbPlayAnim.TabIndex = 0
        Me.cmbPlayAnim.Text = Nothing
        Me.cmbPlayAnim.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraMoveRouteWait
        '
        Me.fraMoveRouteWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraMoveRouteWait.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraMoveRouteWait.Controls.Add(Me.btnMoveWaitCancel)
        Me.fraMoveRouteWait.Controls.Add(Me.btnMoveWaitOk)
        Me.fraMoveRouteWait.Controls.Add(Me.DarkLabel79)
        Me.fraMoveRouteWait.Controls.Add(Me.cmbMoveWait)
        Me.fraMoveRouteWait.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraMoveRouteWait.Location = New System.Drawing.Point(602, 762)
        Me.fraMoveRouteWait.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraMoveRouteWait.Name = "fraMoveRouteWait"
        Me.fraMoveRouteWait.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraMoveRouteWait.Size = New System.Drawing.Size(372, 115)
        Me.fraMoveRouteWait.TabIndex = 48
        Me.fraMoveRouteWait.TabStop = False
        Me.fraMoveRouteWait.Text = "Move Route Wait"
        Me.fraMoveRouteWait.Visible = False
        '
        'btnMoveWaitCancel
        '
        Me.btnMoveWaitCancel.Location = New System.Drawing.Point(250, 71)
        Me.btnMoveWaitCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMoveWaitCancel.Name = "btnMoveWaitCancel"
        Me.btnMoveWaitCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnMoveWaitCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnMoveWaitCancel.TabIndex = 26
        Me.btnMoveWaitCancel.Text = "Cancel"
        '
        'btnMoveWaitOk
        '
        Me.btnMoveWaitOk.Location = New System.Drawing.Point(129, 71)
        Me.btnMoveWaitOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMoveWaitOk.Name = "btnMoveWaitOk"
        Me.btnMoveWaitOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnMoveWaitOk.Size = New System.Drawing.Size(112, 35)
        Me.btnMoveWaitOk.TabIndex = 27
        Me.btnMoveWaitOk.Text = "Ok"
        '
        'DarkLabel79
        '
        Me.DarkLabel79.AutoSize = True
        Me.DarkLabel79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel79.Location = New System.Drawing.Point(10, 34)
        Me.DarkLabel79.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel79.Name = "DarkLabel79"
        Me.DarkLabel79.Size = New System.Drawing.Size(54, 20)
        Me.DarkLabel79.TabIndex = 1
        Me.DarkLabel79.Text = "Event:"
        '
        'cmbMoveWait
        '
        Me.cmbMoveWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbMoveWait.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbMoveWait.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbMoveWait.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbMoveWait.ButtonIcon = CType(resources.GetObject("cmbMoveWait.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbMoveWait.DrawDropdownHoverOutline = False
        Me.cmbMoveWait.DrawFocusRectangle = False
        Me.cmbMoveWait.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMoveWait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoveWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMoveWait.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbMoveWait.FormattingEnabled = True
        Me.cmbMoveWait.Location = New System.Drawing.Point(76, 29)
        Me.cmbMoveWait.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbMoveWait.Name = "cmbMoveWait"
        Me.cmbMoveWait.Size = New System.Drawing.Size(284, 27)
        Me.cmbMoveWait.TabIndex = 0
        Me.cmbMoveWait.Text = Nothing
        Me.cmbMoveWait.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraCustomScript
        '
        Me.fraCustomScript.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraCustomScript.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraCustomScript.Controls.Add(Me.nudCustomScript)
        Me.fraCustomScript.Controls.Add(Me.DarkLabel78)
        Me.fraCustomScript.Controls.Add(Me.btnCustomScriptCancel)
        Me.fraCustomScript.Controls.Add(Me.btnCustomScriptOk)
        Me.fraCustomScript.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraCustomScript.Location = New System.Drawing.Point(602, 609)
        Me.fraCustomScript.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraCustomScript.Name = "fraCustomScript"
        Me.fraCustomScript.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraCustomScript.Size = New System.Drawing.Size(372, 146)
        Me.fraCustomScript.TabIndex = 47
        Me.fraCustomScript.TabStop = False
        Me.fraCustomScript.Text = "Execute Custom Script"
        Me.fraCustomScript.Visible = False
        '
        'nudCustomScript
        '
        Me.nudCustomScript.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudCustomScript.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudCustomScript.Location = New System.Drawing.Point(100, 29)
        Me.nudCustomScript.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudCustomScript.Name = "nudCustomScript"
        Me.nudCustomScript.Size = New System.Drawing.Size(254, 26)
        Me.nudCustomScript.TabIndex = 1
        Me.nudCustomScript.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel78
        '
        Me.DarkLabel78.AutoSize = True
        Me.DarkLabel78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel78.Location = New System.Drawing.Point(15, 32)
        Me.DarkLabel78.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel78.Name = "DarkLabel78"
        Me.DarkLabel78.Size = New System.Drawing.Size(50, 20)
        Me.DarkLabel78.TabIndex = 0
        Me.DarkLabel78.Text = "Case:"
        '
        'btnCustomScriptCancel
        '
        Me.btnCustomScriptCancel.Location = New System.Drawing.Point(242, 69)
        Me.btnCustomScriptCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCustomScriptCancel.Name = "btnCustomScriptCancel"
        Me.btnCustomScriptCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCustomScriptCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCustomScriptCancel.TabIndex = 24
        Me.btnCustomScriptCancel.Text = "Cancel"
        '
        'btnCustomScriptOk
        '
        Me.btnCustomScriptOk.Location = New System.Drawing.Point(120, 69)
        Me.btnCustomScriptOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCustomScriptOk.Name = "btnCustomScriptOk"
        Me.btnCustomScriptOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCustomScriptOk.Size = New System.Drawing.Size(112, 35)
        Me.btnCustomScriptOk.TabIndex = 25
        Me.btnCustomScriptOk.Text = "Ok"
        '
        'fraSetWeather
        '
        Me.fraSetWeather.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraSetWeather.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraSetWeather.Controls.Add(Me.btnSetWeatherOk)
        Me.fraSetWeather.Controls.Add(Me.btnSetWeatherCancel)
        Me.fraSetWeather.Controls.Add(Me.DarkLabel76)
        Me.fraSetWeather.Controls.Add(Me.nudWeatherIntensity)
        Me.fraSetWeather.Controls.Add(Me.DarkLabel75)
        Me.fraSetWeather.Controls.Add(Me.CmbWeather)
        Me.fraSetWeather.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraSetWeather.Location = New System.Drawing.Point(602, 542)
        Me.fraSetWeather.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetWeather.Name = "fraSetWeather"
        Me.fraSetWeather.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetWeather.Size = New System.Drawing.Size(372, 146)
        Me.fraSetWeather.TabIndex = 44
        Me.fraSetWeather.TabStop = False
        Me.fraSetWeather.Text = "Set Weather"
        Me.fraSetWeather.Visible = False
        '
        'btnSetWeatherOk
        '
        Me.btnSetWeatherOk.Location = New System.Drawing.Point(69, 102)
        Me.btnSetWeatherOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetWeatherOk.Name = "btnSetWeatherOk"
        Me.btnSetWeatherOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetWeatherOk.Size = New System.Drawing.Size(112, 35)
        Me.btnSetWeatherOk.TabIndex = 34
        Me.btnSetWeatherOk.Text = "Ok"
        '
        'btnSetWeatherCancel
        '
        Me.btnSetWeatherCancel.Location = New System.Drawing.Point(190, 102)
        Me.btnSetWeatherCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetWeatherCancel.Name = "btnSetWeatherCancel"
        Me.btnSetWeatherCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetWeatherCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnSetWeatherCancel.TabIndex = 33
        Me.btnSetWeatherCancel.Text = "Cancel"
        '
        'DarkLabel76
        '
        Me.DarkLabel76.AutoSize = True
        Me.DarkLabel76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel76.Location = New System.Drawing.Point(12, 68)
        Me.DarkLabel76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel76.Name = "DarkLabel76"
        Me.DarkLabel76.Size = New System.Drawing.Size(73, 20)
        Me.DarkLabel76.TabIndex = 32
        Me.DarkLabel76.Text = "Intensity:"
        '
        'nudWeatherIntensity
        '
        Me.nudWeatherIntensity.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudWeatherIntensity.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudWeatherIntensity.Location = New System.Drawing.Point(130, 63)
        Me.nudWeatherIntensity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudWeatherIntensity.Name = "nudWeatherIntensity"
        Me.nudWeatherIntensity.Size = New System.Drawing.Size(232, 26)
        Me.nudWeatherIntensity.TabIndex = 31
        Me.nudWeatherIntensity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel75
        '
        Me.DarkLabel75.AutoSize = True
        Me.DarkLabel75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel75.Location = New System.Drawing.Point(9, 28)
        Me.DarkLabel75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel75.Name = "DarkLabel75"
        Me.DarkLabel75.Size = New System.Drawing.Size(108, 20)
        Me.DarkLabel75.TabIndex = 1
        Me.DarkLabel75.Text = "Weather Type"
        '
        'CmbWeather
        '
        Me.CmbWeather.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.CmbWeather.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CmbWeather.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.CmbWeather.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.CmbWeather.ButtonIcon = CType(resources.GetObject("CmbWeather.ButtonIcon"), System.Drawing.Bitmap)
        Me.CmbWeather.DrawDropdownHoverOutline = False
        Me.CmbWeather.DrawFocusRectangle = False
        Me.CmbWeather.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbWeather.ForeColor = System.Drawing.Color.Gainsboro
        Me.CmbWeather.FormattingEnabled = True
        Me.CmbWeather.Items.AddRange(New Object() {"None", "Rain", "Snow", "Hail", "Sand Storm", "Storm"})
        Me.CmbWeather.Location = New System.Drawing.Point(129, 23)
        Me.CmbWeather.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbWeather.Name = "CmbWeather"
        Me.CmbWeather.Size = New System.Drawing.Size(230, 27)
        Me.CmbWeather.TabIndex = 0
        Me.CmbWeather.Text = Nothing
        Me.CmbWeather.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraSpawnNpc
        '
        Me.fraSpawnNpc.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraSpawnNpc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraSpawnNpc.Controls.Add(Me.btnSpawnNpcOk)
        Me.fraSpawnNpc.Controls.Add(Me.btnSpawnNpcCancel)
        Me.fraSpawnNpc.Controls.Add(Me.cmbSpawnNpc)
        Me.fraSpawnNpc.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraSpawnNpc.Location = New System.Drawing.Point(602, 634)
        Me.fraSpawnNpc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSpawnNpc.Name = "fraSpawnNpc"
        Me.fraSpawnNpc.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSpawnNpc.Size = New System.Drawing.Size(372, 118)
        Me.fraSpawnNpc.TabIndex = 46
        Me.fraSpawnNpc.TabStop = False
        Me.fraSpawnNpc.Text = "Spawn Npc"
        Me.fraSpawnNpc.Visible = False
        '
        'btnSpawnNpcOk
        '
        Me.btnSpawnNpcOk.Location = New System.Drawing.Point(69, 72)
        Me.btnSpawnNpcOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSpawnNpcOk.Name = "btnSpawnNpcOk"
        Me.btnSpawnNpcOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSpawnNpcOk.Size = New System.Drawing.Size(112, 35)
        Me.btnSpawnNpcOk.TabIndex = 27
        Me.btnSpawnNpcOk.Text = "Ok"
        '
        'btnSpawnNpcCancel
        '
        Me.btnSpawnNpcCancel.Location = New System.Drawing.Point(190, 72)
        Me.btnSpawnNpcCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSpawnNpcCancel.Name = "btnSpawnNpcCancel"
        Me.btnSpawnNpcCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSpawnNpcCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnSpawnNpcCancel.TabIndex = 26
        Me.btnSpawnNpcCancel.Text = "Cancel"
        '
        'cmbSpawnNpc
        '
        Me.cmbSpawnNpc.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbSpawnNpc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbSpawnNpc.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbSpawnNpc.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbSpawnNpc.ButtonIcon = CType(resources.GetObject("cmbSpawnNpc.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbSpawnNpc.DrawDropdownHoverOutline = False
        Me.cmbSpawnNpc.DrawFocusRectangle = False
        Me.cmbSpawnNpc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSpawnNpc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpawnNpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSpawnNpc.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbSpawnNpc.FormattingEnabled = True
        Me.cmbSpawnNpc.Location = New System.Drawing.Point(9, 29)
        Me.cmbSpawnNpc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSpawnNpc.Name = "cmbSpawnNpc"
        Me.cmbSpawnNpc.Size = New System.Drawing.Size(349, 27)
        Me.cmbSpawnNpc.TabIndex = 0
        Me.cmbSpawnNpc.Text = Nothing
        Me.cmbSpawnNpc.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraGiveExp
        '
        Me.fraGiveExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraGiveExp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraGiveExp.Controls.Add(Me.btnGiveExpOk)
        Me.fraGiveExp.Controls.Add(Me.btnGiveExpCancel)
        Me.fraGiveExp.Controls.Add(Me.nudGiveExp)
        Me.fraGiveExp.Controls.Add(Me.DarkLabel77)
        Me.fraGiveExp.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraGiveExp.Location = New System.Drawing.Point(602, 542)
        Me.fraGiveExp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraGiveExp.Name = "fraGiveExp"
        Me.fraGiveExp.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraGiveExp.Size = New System.Drawing.Size(372, 112)
        Me.fraGiveExp.TabIndex = 45
        Me.fraGiveExp.TabStop = False
        Me.fraGiveExp.Text = "Give Experience"
        Me.fraGiveExp.Visible = False
        '
        'btnGiveExpOk
        '
        Me.btnGiveExpOk.Location = New System.Drawing.Point(75, 69)
        Me.btnGiveExpOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGiveExpOk.Name = "btnGiveExpOk"
        Me.btnGiveExpOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnGiveExpOk.Size = New System.Drawing.Size(112, 35)
        Me.btnGiveExpOk.TabIndex = 27
        Me.btnGiveExpOk.Text = "Ok"
        '
        'btnGiveExpCancel
        '
        Me.btnGiveExpCancel.Location = New System.Drawing.Point(196, 69)
        Me.btnGiveExpCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGiveExpCancel.Name = "btnGiveExpCancel"
        Me.btnGiveExpCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnGiveExpCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnGiveExpCancel.TabIndex = 26
        Me.btnGiveExpCancel.Text = "Cancel"
        '
        'nudGiveExp
        '
        Me.nudGiveExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudGiveExp.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudGiveExp.Location = New System.Drawing.Point(116, 29)
        Me.nudGiveExp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudGiveExp.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudGiveExp.Name = "nudGiveExp"
        Me.nudGiveExp.Size = New System.Drawing.Size(248, 26)
        Me.nudGiveExp.TabIndex = 20
        Me.nudGiveExp.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel77
        '
        Me.DarkLabel77.AutoSize = True
        Me.DarkLabel77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel77.Location = New System.Drawing.Point(9, 32)
        Me.DarkLabel77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel77.Name = "DarkLabel77"
        Me.DarkLabel77.Size = New System.Drawing.Size(76, 20)
        Me.DarkLabel77.TabIndex = 0
        Me.DarkLabel77.Text = "Give Exp:"
        '
        'fraEndQuest
        '
        Me.fraEndQuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraEndQuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraEndQuest.Controls.Add(Me.btnEndQuestOk)
        Me.fraEndQuest.Controls.Add(Me.btnEndQuestCancel)
        Me.fraEndQuest.Controls.Add(Me.cmbEndQuest)
        Me.fraEndQuest.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraEndQuest.Location = New System.Drawing.Point(602, 640)
        Me.fraEndQuest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraEndQuest.Name = "fraEndQuest"
        Me.fraEndQuest.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraEndQuest.Size = New System.Drawing.Size(372, 112)
        Me.fraEndQuest.TabIndex = 43
        Me.fraEndQuest.TabStop = False
        Me.fraEndQuest.Text = "End Quest"
        Me.fraEndQuest.Visible = False
        '
        'btnEndQuestOk
        '
        Me.btnEndQuestOk.Location = New System.Drawing.Point(69, 68)
        Me.btnEndQuestOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEndQuestOk.Name = "btnEndQuestOk"
        Me.btnEndQuestOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnEndQuestOk.Size = New System.Drawing.Size(112, 35)
        Me.btnEndQuestOk.TabIndex = 30
        Me.btnEndQuestOk.Text = "Ok"
        '
        'btnEndQuestCancel
        '
        Me.btnEndQuestCancel.Location = New System.Drawing.Point(190, 68)
        Me.btnEndQuestCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEndQuestCancel.Name = "btnEndQuestCancel"
        Me.btnEndQuestCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnEndQuestCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnEndQuestCancel.TabIndex = 29
        Me.btnEndQuestCancel.Text = "Cancel"
        '
        'cmbEndQuest
        '
        Me.cmbEndQuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbEndQuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbEndQuest.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbEndQuest.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbEndQuest.ButtonIcon = CType(resources.GetObject("cmbEndQuest.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbEndQuest.DrawDropdownHoverOutline = False
        Me.cmbEndQuest.DrawFocusRectangle = False
        Me.cmbEndQuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEndQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEndQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEndQuest.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbEndQuest.FormattingEnabled = True
        Me.cmbEndQuest.Location = New System.Drawing.Point(50, 23)
        Me.cmbEndQuest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbEndQuest.Name = "cmbEndQuest"
        Me.cmbEndQuest.Size = New System.Drawing.Size(280, 27)
        Me.cmbEndQuest.TabIndex = 28
        Me.cmbEndQuest.Text = Nothing
        Me.cmbEndQuest.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraSetAccess
        '
        Me.fraSetAccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraSetAccess.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraSetAccess.Controls.Add(Me.btnSetAccessOk)
        Me.fraSetAccess.Controls.Add(Me.btnSetAccessCancel)
        Me.fraSetAccess.Controls.Add(Me.cmbSetAccess)
        Me.fraSetAccess.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraSetAccess.Location = New System.Drawing.Point(602, 543)
        Me.fraSetAccess.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetAccess.Name = "fraSetAccess"
        Me.fraSetAccess.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetAccess.Size = New System.Drawing.Size(372, 123)
        Me.fraSetAccess.TabIndex = 42
        Me.fraSetAccess.TabStop = False
        Me.fraSetAccess.Text = "Set Access"
        Me.fraSetAccess.Visible = False
        '
        'btnSetAccessOk
        '
        Me.btnSetAccessOk.Location = New System.Drawing.Point(69, 74)
        Me.btnSetAccessOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetAccessOk.Name = "btnSetAccessOk"
        Me.btnSetAccessOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetAccessOk.Size = New System.Drawing.Size(112, 35)
        Me.btnSetAccessOk.TabIndex = 27
        Me.btnSetAccessOk.Text = "Ok"
        '
        'btnSetAccessCancel
        '
        Me.btnSetAccessCancel.Location = New System.Drawing.Point(190, 74)
        Me.btnSetAccessCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetAccessCancel.Name = "btnSetAccessCancel"
        Me.btnSetAccessCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetAccessCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnSetAccessCancel.TabIndex = 26
        Me.btnSetAccessCancel.Text = "Cancel"
        '
        'cmbSetAccess
        '
        Me.cmbSetAccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbSetAccess.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbSetAccess.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbSetAccess.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbSetAccess.ButtonIcon = CType(resources.GetObject("cmbSetAccess.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbSetAccess.DrawDropdownHoverOutline = False
        Me.cmbSetAccess.DrawFocusRectangle = False
        Me.cmbSetAccess.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSetAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSetAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSetAccess.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbSetAccess.FormattingEnabled = True
        Me.cmbSetAccess.Items.AddRange(New Object() {"0: Player", "1: Monitor", "2: Mapper", "3: Developer", "4: Creator"})
        Me.cmbSetAccess.Location = New System.Drawing.Point(50, 29)
        Me.cmbSetAccess.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSetAccess.Name = "cmbSetAccess"
        Me.cmbSetAccess.Size = New System.Drawing.Size(280, 27)
        Me.cmbSetAccess.TabIndex = 0
        Me.cmbSetAccess.Text = Nothing
        Me.cmbSetAccess.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraSetWait
        '
        Me.fraSetWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraSetWait.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraSetWait.Controls.Add(Me.btnSetWaitOk)
        Me.fraSetWait.Controls.Add(Me.btnSetWaitCancel)
        Me.fraSetWait.Controls.Add(Me.DarkLabel74)
        Me.fraSetWait.Controls.Add(Me.DarkLabel72)
        Me.fraSetWait.Controls.Add(Me.DarkLabel73)
        Me.fraSetWait.Controls.Add(Me.nudWaitAmount)
        Me.fraSetWait.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraSetWait.Location = New System.Drawing.Point(602, 406)
        Me.fraSetWait.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetWait.Name = "fraSetWait"
        Me.fraSetWait.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetWait.Size = New System.Drawing.Size(372, 137)
        Me.fraSetWait.TabIndex = 41
        Me.fraSetWait.TabStop = False
        Me.fraSetWait.Text = "Wait..."
        Me.fraSetWait.Visible = False
        '
        'btnSetWaitOk
        '
        Me.btnSetWaitOk.Location = New System.Drawing.Point(75, 89)
        Me.btnSetWaitOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetWaitOk.Name = "btnSetWaitOk"
        Me.btnSetWaitOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetWaitOk.Size = New System.Drawing.Size(112, 35)
        Me.btnSetWaitOk.TabIndex = 37
        Me.btnSetWaitOk.Text = "Ok"
        '
        'btnSetWaitCancel
        '
        Me.btnSetWaitCancel.Location = New System.Drawing.Point(196, 89)
        Me.btnSetWaitCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetWaitCancel.Name = "btnSetWaitCancel"
        Me.btnSetWaitCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetWaitCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnSetWaitCancel.TabIndex = 36
        Me.btnSetWaitCancel.Text = "Cancel"
        '
        'DarkLabel74
        '
        Me.DarkLabel74.AutoSize = True
        Me.DarkLabel74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel74.Location = New System.Drawing.Point(105, 65)
        Me.DarkLabel74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel74.Name = "DarkLabel74"
        Me.DarkLabel74.Size = New System.Drawing.Size(165, 20)
        Me.DarkLabel74.TabIndex = 35
        Me.DarkLabel74.Text = "Hint: 1000 Ms = 1 Sec"
        '
        'DarkLabel72
        '
        Me.DarkLabel72.AutoSize = True
        Me.DarkLabel72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel72.Location = New System.Drawing.Point(327, 35)
        Me.DarkLabel72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel72.Name = "DarkLabel72"
        Me.DarkLabel72.Size = New System.Drawing.Size(30, 20)
        Me.DarkLabel72.TabIndex = 34
        Me.DarkLabel72.Text = "Ms"
        '
        'DarkLabel73
        '
        Me.DarkLabel73.AutoSize = True
        Me.DarkLabel73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel73.Location = New System.Drawing.Point(22, 35)
        Me.DarkLabel73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel73.Name = "DarkLabel73"
        Me.DarkLabel73.Size = New System.Drawing.Size(41, 20)
        Me.DarkLabel73.TabIndex = 33
        Me.DarkLabel73.Text = "Wait"
        '
        'nudWaitAmount
        '
        Me.nudWaitAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudWaitAmount.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudWaitAmount.Location = New System.Drawing.Point(75, 29)
        Me.nudWaitAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudWaitAmount.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudWaitAmount.Name = "nudWaitAmount"
        Me.nudWaitAmount.Size = New System.Drawing.Size(244, 26)
        Me.nudWaitAmount.TabIndex = 32
        Me.nudWaitAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'fraShowPic
        '
        Me.fraShowPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraShowPic.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraShowPic.Controls.Add(Me.btnShowPicOk)
        Me.fraShowPic.Controls.Add(Me.btnShowPicCancel)
        Me.fraShowPic.Controls.Add(Me.DarkLabel71)
        Me.fraShowPic.Controls.Add(Me.DarkLabel70)
        Me.fraShowPic.Controls.Add(Me.DarkLabel67)
        Me.fraShowPic.Controls.Add(Me.DarkLabel68)
        Me.fraShowPic.Controls.Add(Me.nudPicOffsetY)
        Me.fraShowPic.Controls.Add(Me.nudPicOffsetX)
        Me.fraShowPic.Controls.Add(Me.DarkLabel69)
        Me.fraShowPic.Controls.Add(Me.cmbPicLoc)
        Me.fraShowPic.Controls.Add(Me.nudShowPicture)
        Me.fraShowPic.Controls.Add(Me.picShowPic)
        Me.fraShowPic.Controls.Add(Me.cmbPicIndex)
        Me.fraShowPic.Controls.Add(Me.DarkLabel66)
        Me.fraShowPic.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraShowPic.Location = New System.Drawing.Point(602, 409)
        Me.fraShowPic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraShowPic.Name = "fraShowPic"
        Me.fraShowPic.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraShowPic.Size = New System.Drawing.Size(372, 343)
        Me.fraShowPic.TabIndex = 40
        Me.fraShowPic.TabStop = False
        Me.fraShowPic.Text = "Show Picture"
        Me.fraShowPic.Visible = False
        '
        'btnShowPicOk
        '
        Me.btnShowPicOk.Location = New System.Drawing.Point(129, 298)
        Me.btnShowPicOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowPicOk.Name = "btnShowPicOk"
        Me.btnShowPicOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnShowPicOk.Size = New System.Drawing.Size(112, 35)
        Me.btnShowPicOk.TabIndex = 55
        Me.btnShowPicOk.Text = "Ok"
        '
        'btnShowPicCancel
        '
        Me.btnShowPicCancel.Location = New System.Drawing.Point(250, 298)
        Me.btnShowPicCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowPicCancel.Name = "btnShowPicCancel"
        Me.btnShowPicCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnShowPicCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnShowPicCancel.TabIndex = 54
        Me.btnShowPicCancel.Text = "Cancel"
        '
        'DarkLabel71
        '
        Me.DarkLabel71.AutoSize = True
        Me.DarkLabel71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel71.Location = New System.Drawing.Point(15, 214)
        Me.DarkLabel71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel71.Name = "DarkLabel71"
        Me.DarkLabel71.Size = New System.Drawing.Size(158, 20)
        Me.DarkLabel71.TabIndex = 53
        Me.DarkLabel71.Text = "Offset from Location:"
        '
        'DarkLabel70
        '
        Me.DarkLabel70.AutoSize = True
        Me.DarkLabel70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel70.Location = New System.Drawing.Point(168, 123)
        Me.DarkLabel70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel70.Name = "DarkLabel70"
        Me.DarkLabel70.Size = New System.Drawing.Size(70, 20)
        Me.DarkLabel70.TabIndex = 52
        Me.DarkLabel70.Text = "Location"
        '
        'DarkLabel67
        '
        Me.DarkLabel67.AutoSize = True
        Me.DarkLabel67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel67.Location = New System.Drawing.Point(206, 249)
        Me.DarkLabel67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel67.Name = "DarkLabel67"
        Me.DarkLabel67.Size = New System.Drawing.Size(24, 20)
        Me.DarkLabel67.TabIndex = 51
        Me.DarkLabel67.Text = "Y:"
        '
        'DarkLabel68
        '
        Me.DarkLabel68.AutoSize = True
        Me.DarkLabel68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel68.Location = New System.Drawing.Point(15, 252)
        Me.DarkLabel68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel68.Name = "DarkLabel68"
        Me.DarkLabel68.Size = New System.Drawing.Size(24, 20)
        Me.DarkLabel68.TabIndex = 50
        Me.DarkLabel68.Text = "X:"
        '
        'nudPicOffsetY
        '
        Me.nudPicOffsetY.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudPicOffsetY.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudPicOffsetY.Location = New System.Drawing.Point(273, 246)
        Me.nudPicOffsetY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPicOffsetY.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPicOffsetY.Name = "nudPicOffsetY"
        Me.nudPicOffsetY.Size = New System.Drawing.Size(86, 26)
        Me.nudPicOffsetY.TabIndex = 49
        Me.nudPicOffsetY.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'nudPicOffsetX
        '
        Me.nudPicOffsetX.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudPicOffsetX.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudPicOffsetX.Location = New System.Drawing.Point(78, 246)
        Me.nudPicOffsetX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPicOffsetX.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPicOffsetX.Name = "nudPicOffsetX"
        Me.nudPicOffsetX.Size = New System.Drawing.Size(86, 26)
        Me.nudPicOffsetX.TabIndex = 48
        Me.nudPicOffsetX.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel69
        '
        Me.DarkLabel69.AutoSize = True
        Me.DarkLabel69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel69.Location = New System.Drawing.Point(174, 71)
        Me.DarkLabel69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel69.Name = "DarkLabel69"
        Me.DarkLabel69.Size = New System.Drawing.Size(62, 20)
        Me.DarkLabel69.TabIndex = 47
        Me.DarkLabel69.Text = "Picture:"
        '
        'cmbPicLoc
        '
        Me.cmbPicLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPicLoc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPicLoc.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPicLoc.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPicLoc.ButtonIcon = CType(resources.GetObject("cmbPicLoc.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPicLoc.DrawDropdownHoverOutline = False
        Me.cmbPicLoc.DrawFocusRectangle = False
        Me.cmbPicLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPicLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPicLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPicLoc.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPicLoc.FormattingEnabled = True
        Me.cmbPicLoc.Items.AddRange(New Object() {"Top Left of Screen", "Center Screen", "Centered on Player"})
        Me.cmbPicLoc.Location = New System.Drawing.Point(172, 151)
        Me.cmbPicLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPicLoc.Name = "cmbPicLoc"
        Me.cmbPicLoc.Size = New System.Drawing.Size(184, 27)
        Me.cmbPicLoc.TabIndex = 46
        Me.cmbPicLoc.Text = Nothing
        Me.cmbPicLoc.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'nudShowPicture
        '
        Me.nudShowPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudShowPicture.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudShowPicture.Location = New System.Drawing.Point(248, 68)
        Me.nudShowPicture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudShowPicture.Name = "nudShowPicture"
        Me.nudShowPicture.Size = New System.Drawing.Size(112, 26)
        Me.nudShowPicture.TabIndex = 45
        Me.nudShowPicture.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'picShowPic
        '
        Me.picShowPic.BackColor = System.Drawing.Color.Black
        Me.picShowPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShowPic.Location = New System.Drawing.Point(14, 66)
        Me.picShowPic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picShowPic.Name = "picShowPic"
        Me.picShowPic.Size = New System.Drawing.Size(150, 143)
        Me.picShowPic.TabIndex = 42
        Me.picShowPic.TabStop = False
        '
        'cmbPicIndex
        '
        Me.cmbPicIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPicIndex.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPicIndex.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPicIndex.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPicIndex.ButtonIcon = CType(resources.GetObject("cmbPicIndex.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPicIndex.DrawDropdownHoverOutline = False
        Me.cmbPicIndex.DrawFocusRectangle = False
        Me.cmbPicIndex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPicIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPicIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPicIndex.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPicIndex.FormattingEnabled = True
        Me.cmbPicIndex.Location = New System.Drawing.Point(117, 26)
        Me.cmbPicIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPicIndex.Name = "cmbPicIndex"
        Me.cmbPicIndex.Size = New System.Drawing.Size(241, 27)
        Me.cmbPicIndex.TabIndex = 1
        Me.cmbPicIndex.Text = Nothing
        Me.cmbPicIndex.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel66
        '
        Me.DarkLabel66.AutoSize = True
        Me.DarkLabel66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel66.Location = New System.Drawing.Point(9, 31)
        Me.DarkLabel66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel66.Name = "DarkLabel66"
        Me.DarkLabel66.Size = New System.Drawing.Size(105, 20)
        Me.DarkLabel66.TabIndex = 0
        Me.DarkLabel66.Text = "Picture Index:"
        '
        'fraOpenShop
        '
        Me.fraOpenShop.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraOpenShop.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraOpenShop.Controls.Add(Me.btnOpenShopOk)
        Me.fraOpenShop.Controls.Add(Me.btnOpenShopCancel)
        Me.fraOpenShop.Controls.Add(Me.cmbOpenShop)
        Me.fraOpenShop.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraOpenShop.Location = New System.Drawing.Point(604, 334)
        Me.fraOpenShop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraOpenShop.Name = "fraOpenShop"
        Me.fraOpenShop.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraOpenShop.Size = New System.Drawing.Size(369, 122)
        Me.fraOpenShop.TabIndex = 39
        Me.fraOpenShop.TabStop = False
        Me.fraOpenShop.Text = "Open Shop"
        Me.fraOpenShop.Visible = False
        '
        'btnOpenShopOk
        '
        Me.btnOpenShopOk.Location = New System.Drawing.Point(66, 72)
        Me.btnOpenShopOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpenShopOk.Name = "btnOpenShopOk"
        Me.btnOpenShopOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnOpenShopOk.Size = New System.Drawing.Size(112, 35)
        Me.btnOpenShopOk.TabIndex = 27
        Me.btnOpenShopOk.Text = "Ok"
        '
        'btnOpenShopCancel
        '
        Me.btnOpenShopCancel.Location = New System.Drawing.Point(188, 72)
        Me.btnOpenShopCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpenShopCancel.Name = "btnOpenShopCancel"
        Me.btnOpenShopCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnOpenShopCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnOpenShopCancel.TabIndex = 26
        Me.btnOpenShopCancel.Text = "Cancel"
        '
        'cmbOpenShop
        '
        Me.cmbOpenShop.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbOpenShop.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbOpenShop.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbOpenShop.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbOpenShop.ButtonIcon = CType(resources.GetObject("cmbOpenShop.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbOpenShop.DrawDropdownHoverOutline = False
        Me.cmbOpenShop.DrawFocusRectangle = False
        Me.cmbOpenShop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbOpenShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOpenShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOpenShop.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbOpenShop.FormattingEnabled = True
        Me.cmbOpenShop.Location = New System.Drawing.Point(14, 31)
        Me.cmbOpenShop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbOpenShop.Name = "cmbOpenShop"
        Me.cmbOpenShop.Size = New System.Drawing.Size(337, 27)
        Me.cmbOpenShop.TabIndex = 0
        Me.cmbOpenShop.Text = Nothing
        Me.cmbOpenShop.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraChangeLevel
        '
        Me.fraChangeLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraChangeLevel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraChangeLevel.Controls.Add(Me.btnChangeLevelOk)
        Me.fraChangeLevel.Controls.Add(Me.btnChangeLevelCancel)
        Me.fraChangeLevel.Controls.Add(Me.DarkLabel65)
        Me.fraChangeLevel.Controls.Add(Me.nudChangeLevel)
        Me.fraChangeLevel.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraChangeLevel.Location = New System.Drawing.Point(602, 451)
        Me.fraChangeLevel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeLevel.Name = "fraChangeLevel"
        Me.fraChangeLevel.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeLevel.Size = New System.Drawing.Size(372, 111)
        Me.fraChangeLevel.TabIndex = 38
        Me.fraChangeLevel.TabStop = False
        Me.fraChangeLevel.Text = "Change Level"
        Me.fraChangeLevel.Visible = False
        '
        'btnChangeLevelOk
        '
        Me.btnChangeLevelOk.Location = New System.Drawing.Point(69, 69)
        Me.btnChangeLevelOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeLevelOk.Name = "btnChangeLevelOk"
        Me.btnChangeLevelOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeLevelOk.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeLevelOk.TabIndex = 27
        Me.btnChangeLevelOk.Text = "Ok"
        '
        'btnChangeLevelCancel
        '
        Me.btnChangeLevelCancel.Location = New System.Drawing.Point(190, 69)
        Me.btnChangeLevelCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeLevelCancel.Name = "btnChangeLevelCancel"
        Me.btnChangeLevelCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeLevelCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeLevelCancel.TabIndex = 26
        Me.btnChangeLevelCancel.Text = "Cancel"
        '
        'DarkLabel65
        '
        Me.DarkLabel65.AutoSize = True
        Me.DarkLabel65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel65.Location = New System.Drawing.Point(10, 32)
        Me.DarkLabel65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel65.Name = "DarkLabel65"
        Me.DarkLabel65.Size = New System.Drawing.Size(50, 20)
        Me.DarkLabel65.TabIndex = 24
        Me.DarkLabel65.Text = "Level:"
        '
        'nudChangeLevel
        '
        Me.nudChangeLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudChangeLevel.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudChangeLevel.Location = New System.Drawing.Point(90, 29)
        Me.nudChangeLevel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudChangeLevel.Name = "nudChangeLevel"
        Me.nudChangeLevel.Size = New System.Drawing.Size(180, 26)
        Me.nudChangeLevel.TabIndex = 23
        Me.nudChangeLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'fraChangeGender
        '
        Me.fraChangeGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraChangeGender.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraChangeGender.Controls.Add(Me.btnChangeGenderOk)
        Me.fraChangeGender.Controls.Add(Me.btnChangeGenderCancel)
        Me.fraChangeGender.Controls.Add(Me.optChangeSexFemale)
        Me.fraChangeGender.Controls.Add(Me.optChangeSexMale)
        Me.fraChangeGender.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraChangeGender.Location = New System.Drawing.Point(602, 560)
        Me.fraChangeGender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeGender.Name = "fraChangeGender"
        Me.fraChangeGender.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeGender.Size = New System.Drawing.Size(372, 111)
        Me.fraChangeGender.TabIndex = 37
        Me.fraChangeGender.TabStop = False
        Me.fraChangeGender.Text = "Change Player Gender"
        Me.fraChangeGender.Visible = False
        '
        'btnChangeGenderOk
        '
        Me.btnChangeGenderOk.Location = New System.Drawing.Point(58, 65)
        Me.btnChangeGenderOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeGenderOk.Name = "btnChangeGenderOk"
        Me.btnChangeGenderOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeGenderOk.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeGenderOk.TabIndex = 27
        Me.btnChangeGenderOk.Text = "Ok"
        '
        'btnChangeGenderCancel
        '
        Me.btnChangeGenderCancel.Location = New System.Drawing.Point(180, 65)
        Me.btnChangeGenderCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeGenderCancel.Name = "btnChangeGenderCancel"
        Me.btnChangeGenderCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeGenderCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeGenderCancel.TabIndex = 26
        Me.btnChangeGenderCancel.Text = "Cancel"
        '
        'optChangeSexFemale
        '
        Me.optChangeSexFemale.AutoSize = True
        Me.optChangeSexFemale.Location = New System.Drawing.Point(212, 29)
        Me.optChangeSexFemale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optChangeSexFemale.Name = "optChangeSexFemale"
        Me.optChangeSexFemale.Size = New System.Drawing.Size(87, 24)
        Me.optChangeSexFemale.TabIndex = 1
        Me.optChangeSexFemale.TabStop = True
        Me.optChangeSexFemale.Text = "Female"
        '
        'optChangeSexMale
        '
        Me.optChangeSexMale.AutoSize = True
        Me.optChangeSexMale.Location = New System.Drawing.Point(78, 29)
        Me.optChangeSexMale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optChangeSexMale.Name = "optChangeSexMale"
        Me.optChangeSexMale.Size = New System.Drawing.Size(68, 24)
        Me.optChangeSexMale.TabIndex = 0
        Me.optChangeSexMale.TabStop = True
        Me.optChangeSexMale.Text = "Male"
        '
        'fraGoToLabel
        '
        Me.fraGoToLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraGoToLabel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraGoToLabel.Controls.Add(Me.btnGoToLabelOk)
        Me.fraGoToLabel.Controls.Add(Me.btnGoToLabelCancel)
        Me.fraGoToLabel.Controls.Add(Me.txtGotoLabel)
        Me.fraGoToLabel.Controls.Add(Me.DarkLabel60)
        Me.fraGoToLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraGoToLabel.Location = New System.Drawing.Point(602, 392)
        Me.fraGoToLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraGoToLabel.Name = "fraGoToLabel"
        Me.fraGoToLabel.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraGoToLabel.Size = New System.Drawing.Size(372, 112)
        Me.fraGoToLabel.TabIndex = 35
        Me.fraGoToLabel.TabStop = False
        Me.fraGoToLabel.Text = "GoTo Label"
        Me.fraGoToLabel.Visible = False
        '
        'btnGoToLabelOk
        '
        Me.btnGoToLabelOk.Location = New System.Drawing.Point(129, 68)
        Me.btnGoToLabelOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGoToLabelOk.Name = "btnGoToLabelOk"
        Me.btnGoToLabelOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnGoToLabelOk.Size = New System.Drawing.Size(112, 35)
        Me.btnGoToLabelOk.TabIndex = 27
        Me.btnGoToLabelOk.Text = "Ok"
        '
        'btnGoToLabelCancel
        '
        Me.btnGoToLabelCancel.Location = New System.Drawing.Point(250, 68)
        Me.btnGoToLabelCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGoToLabelCancel.Name = "btnGoToLabelCancel"
        Me.btnGoToLabelCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnGoToLabelCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnGoToLabelCancel.TabIndex = 26
        Me.btnGoToLabelCancel.Text = "Cancel"
        '
        'txtGotoLabel
        '
        Me.txtGotoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtGotoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGotoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtGotoLabel.Location = New System.Drawing.Point(117, 28)
        Me.txtGotoLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGotoLabel.Name = "txtGotoLabel"
        Me.txtGotoLabel.Size = New System.Drawing.Size(245, 26)
        Me.txtGotoLabel.TabIndex = 1
        '
        'DarkLabel60
        '
        Me.DarkLabel60.AutoSize = True
        Me.DarkLabel60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel60.Location = New System.Drawing.Point(4, 31)
        Me.DarkLabel60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel60.Name = "DarkLabel60"
        Me.DarkLabel60.Size = New System.Drawing.Size(98, 20)
        Me.DarkLabel60.TabIndex = 0
        Me.DarkLabel60.Text = "Label Name:"
        '
        'fraHidePic
        '
        Me.fraHidePic.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraHidePic.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraHidePic.Controls.Add(Me.btnHidePicOk)
        Me.fraHidePic.Controls.Add(Me.btnHidePicCancel)
        Me.fraHidePic.Controls.Add(Me.nudHidePic)
        Me.fraHidePic.Controls.Add(Me.DarkLabel59)
        Me.fraHidePic.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraHidePic.Location = New System.Drawing.Point(602, 283)
        Me.fraHidePic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraHidePic.Name = "fraHidePic"
        Me.fraHidePic.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraHidePic.Size = New System.Drawing.Size(372, 109)
        Me.fraHidePic.TabIndex = 34
        Me.fraHidePic.TabStop = False
        Me.fraHidePic.Text = "Hide Picture"
        Me.fraHidePic.Visible = False
        '
        'btnHidePicOk
        '
        Me.btnHidePicOk.Location = New System.Drawing.Point(129, 62)
        Me.btnHidePicOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHidePicOk.Name = "btnHidePicOk"
        Me.btnHidePicOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnHidePicOk.Size = New System.Drawing.Size(112, 35)
        Me.btnHidePicOk.TabIndex = 27
        Me.btnHidePicOk.Text = "Ok"
        '
        'btnHidePicCancel
        '
        Me.btnHidePicCancel.Location = New System.Drawing.Point(250, 62)
        Me.btnHidePicCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHidePicCancel.Name = "btnHidePicCancel"
        Me.btnHidePicCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnHidePicCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnHidePicCancel.TabIndex = 26
        Me.btnHidePicCancel.Text = "Cancel"
        '
        'nudHidePic
        '
        Me.nudHidePic.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudHidePic.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudHidePic.Location = New System.Drawing.Point(126, 22)
        Me.nudHidePic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudHidePic.Name = "nudHidePic"
        Me.nudHidePic.Size = New System.Drawing.Size(237, 26)
        Me.nudHidePic.TabIndex = 1
        Me.nudHidePic.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel59
        '
        Me.DarkLabel59.AutoSize = True
        Me.DarkLabel59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel59.Location = New System.Drawing.Point(9, 25)
        Me.DarkLabel59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel59.Name = "DarkLabel59"
        Me.DarkLabel59.Size = New System.Drawing.Size(105, 20)
        Me.DarkLabel59.TabIndex = 0
        Me.DarkLabel59.Text = "Picture Index:"
        '
        'fraBeginQuest
        '
        Me.fraBeginQuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraBeginQuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraBeginQuest.Controls.Add(Me.btnBeginQuestOk)
        Me.fraBeginQuest.Controls.Add(Me.btnBeginQuestCancel)
        Me.fraBeginQuest.Controls.Add(Me.cmbBeginQuest)
        Me.fraBeginQuest.Controls.Add(Me.DarkLabel58)
        Me.fraBeginQuest.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraBeginQuest.Location = New System.Drawing.Point(602, 162)
        Me.fraBeginQuest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraBeginQuest.Name = "fraBeginQuest"
        Me.fraBeginQuest.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraBeginQuest.Size = New System.Drawing.Size(372, 122)
        Me.fraBeginQuest.TabIndex = 33
        Me.fraBeginQuest.TabStop = False
        Me.fraBeginQuest.Text = "Begin Quest"
        Me.fraBeginQuest.Visible = False
        '
        'btnBeginQuestOk
        '
        Me.btnBeginQuestOk.Location = New System.Drawing.Point(129, 72)
        Me.btnBeginQuestOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBeginQuestOk.Name = "btnBeginQuestOk"
        Me.btnBeginQuestOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnBeginQuestOk.Size = New System.Drawing.Size(112, 35)
        Me.btnBeginQuestOk.TabIndex = 27
        Me.btnBeginQuestOk.Text = "Ok"
        '
        'btnBeginQuestCancel
        '
        Me.btnBeginQuestCancel.Location = New System.Drawing.Point(250, 72)
        Me.btnBeginQuestCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBeginQuestCancel.Name = "btnBeginQuestCancel"
        Me.btnBeginQuestCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnBeginQuestCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnBeginQuestCancel.TabIndex = 26
        Me.btnBeginQuestCancel.Text = "Cancel"
        '
        'cmbBeginQuest
        '
        Me.cmbBeginQuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbBeginQuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbBeginQuest.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbBeginQuest.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbBeginQuest.ButtonIcon = CType(resources.GetObject("cmbBeginQuest.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbBeginQuest.DrawDropdownHoverOutline = False
        Me.cmbBeginQuest.DrawFocusRectangle = False
        Me.cmbBeginQuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBeginQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBeginQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBeginQuest.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbBeginQuest.FormattingEnabled = True
        Me.cmbBeginQuest.Location = New System.Drawing.Point(75, 31)
        Me.cmbBeginQuest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbBeginQuest.Name = "cmbBeginQuest"
        Me.cmbBeginQuest.Size = New System.Drawing.Size(283, 27)
        Me.cmbBeginQuest.TabIndex = 1
        Me.cmbBeginQuest.Text = Nothing
        Me.cmbBeginQuest.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel58
        '
        Me.DarkLabel58.AutoSize = True
        Me.DarkLabel58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel58.Location = New System.Drawing.Point(9, 35)
        Me.DarkLabel58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel58.Name = "DarkLabel58"
        Me.DarkLabel58.Size = New System.Drawing.Size(56, 20)
        Me.DarkLabel58.TabIndex = 0
        Me.DarkLabel58.Text = "Quest:"
        '
        'fraShowChoices
        '
        Me.fraShowChoices.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraShowChoices.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraShowChoices.Controls.Add(Me.txtChoices4)
        Me.fraShowChoices.Controls.Add(Me.txtChoices3)
        Me.fraShowChoices.Controls.Add(Me.txtChoices2)
        Me.fraShowChoices.Controls.Add(Me.txtChoices1)
        Me.fraShowChoices.Controls.Add(Me.DarkLabel56)
        Me.fraShowChoices.Controls.Add(Me.DarkLabel57)
        Me.fraShowChoices.Controls.Add(Me.DarkLabel55)
        Me.fraShowChoices.Controls.Add(Me.DarkLabel54)
        Me.fraShowChoices.Controls.Add(Me.DarkLabel52)
        Me.fraShowChoices.Controls.Add(Me.txtChoicePrompt)
        Me.fraShowChoices.Controls.Add(Me.btnShowChoicesOk)
        Me.fraShowChoices.Controls.Add(Me.picShowChoicesFace)
        Me.fraShowChoices.Controls.Add(Me.btnShowChoicesCancel)
        Me.fraShowChoices.Controls.Add(Me.DarkLabel53)
        Me.fraShowChoices.Controls.Add(Me.nudShowChoicesFace)
        Me.fraShowChoices.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraShowChoices.Location = New System.Drawing.Point(602, 158)
        Me.fraShowChoices.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraShowChoices.Name = "fraShowChoices"
        Me.fraShowChoices.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraShowChoices.Size = New System.Drawing.Size(372, 512)
        Me.fraShowChoices.TabIndex = 32
        Me.fraShowChoices.TabStop = False
        Me.fraShowChoices.Text = "Show Choices"
        Me.fraShowChoices.Visible = False
        '
        'txtChoices4
        '
        Me.txtChoices4.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtChoices4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChoices4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtChoices4.Location = New System.Drawing.Point(212, 268)
        Me.txtChoices4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChoices4.Name = "txtChoices4"
        Me.txtChoices4.Size = New System.Drawing.Size(149, 26)
        Me.txtChoices4.TabIndex = 34
        '
        'txtChoices3
        '
        Me.txtChoices3.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtChoices3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChoices3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtChoices3.Location = New System.Drawing.Point(9, 266)
        Me.txtChoices3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChoices3.Name = "txtChoices3"
        Me.txtChoices3.Size = New System.Drawing.Size(149, 26)
        Me.txtChoices3.TabIndex = 33
        '
        'txtChoices2
        '
        Me.txtChoices2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtChoices2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChoices2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtChoices2.Location = New System.Drawing.Point(212, 206)
        Me.txtChoices2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChoices2.Name = "txtChoices2"
        Me.txtChoices2.Size = New System.Drawing.Size(149, 26)
        Me.txtChoices2.TabIndex = 32
        '
        'txtChoices1
        '
        Me.txtChoices1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtChoices1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChoices1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtChoices1.Location = New System.Drawing.Point(9, 206)
        Me.txtChoices1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChoices1.Name = "txtChoices1"
        Me.txtChoices1.Size = New System.Drawing.Size(149, 26)
        Me.txtChoices1.TabIndex = 31
        '
        'DarkLabel56
        '
        Me.DarkLabel56.AutoSize = True
        Me.DarkLabel56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel56.Location = New System.Drawing.Point(207, 242)
        Me.DarkLabel56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel56.Name = "DarkLabel56"
        Me.DarkLabel56.Size = New System.Drawing.Size(71, 20)
        Me.DarkLabel56.TabIndex = 30
        Me.DarkLabel56.Text = "Choice 4"
        '
        'DarkLabel57
        '
        Me.DarkLabel57.AutoSize = True
        Me.DarkLabel57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel57.Location = New System.Drawing.Point(10, 242)
        Me.DarkLabel57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel57.Name = "DarkLabel57"
        Me.DarkLabel57.Size = New System.Drawing.Size(71, 20)
        Me.DarkLabel57.TabIndex = 29
        Me.DarkLabel57.Text = "Choice 3"
        '
        'DarkLabel55
        '
        Me.DarkLabel55.AutoSize = True
        Me.DarkLabel55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel55.Location = New System.Drawing.Point(207, 182)
        Me.DarkLabel55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel55.Name = "DarkLabel55"
        Me.DarkLabel55.Size = New System.Drawing.Size(71, 20)
        Me.DarkLabel55.TabIndex = 28
        Me.DarkLabel55.Text = "Choice 2"
        '
        'DarkLabel54
        '
        Me.DarkLabel54.AutoSize = True
        Me.DarkLabel54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel54.Location = New System.Drawing.Point(9, 182)
        Me.DarkLabel54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel54.Name = "DarkLabel54"
        Me.DarkLabel54.Size = New System.Drawing.Size(71, 20)
        Me.DarkLabel54.TabIndex = 27
        Me.DarkLabel54.Text = "Choice 1"
        '
        'DarkLabel52
        '
        Me.DarkLabel52.AutoSize = True
        Me.DarkLabel52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel52.Location = New System.Drawing.Point(10, 29)
        Me.DarkLabel52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel52.Name = "DarkLabel52"
        Me.DarkLabel52.Size = New System.Drawing.Size(60, 20)
        Me.DarkLabel52.TabIndex = 26
        Me.DarkLabel52.Text = "Prompt"
        '
        'txtChoicePrompt
        '
        Me.txtChoicePrompt.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtChoicePrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChoicePrompt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtChoicePrompt.Location = New System.Drawing.Point(14, 58)
        Me.txtChoicePrompt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChoicePrompt.Multiline = True
        Me.txtChoicePrompt.Name = "txtChoicePrompt"
        Me.txtChoicePrompt.Size = New System.Drawing.Size(341, 117)
        Me.txtChoicePrompt.TabIndex = 21
        '
        'btnShowChoicesOk
        '
        Me.btnShowChoicesOk.Location = New System.Drawing.Point(126, 469)
        Me.btnShowChoicesOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowChoicesOk.Name = "btnShowChoicesOk"
        Me.btnShowChoicesOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnShowChoicesOk.Size = New System.Drawing.Size(112, 35)
        Me.btnShowChoicesOk.TabIndex = 25
        Me.btnShowChoicesOk.Text = "Ok"
        '
        'picShowChoicesFace
        '
        Me.picShowChoicesFace.BackColor = System.Drawing.Color.Black
        Me.picShowChoicesFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShowChoicesFace.Location = New System.Drawing.Point(9, 306)
        Me.picShowChoicesFace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picShowChoicesFace.Name = "picShowChoicesFace"
        Me.picShowChoicesFace.Size = New System.Drawing.Size(150, 143)
        Me.picShowChoicesFace.TabIndex = 2
        Me.picShowChoicesFace.TabStop = False
        '
        'btnShowChoicesCancel
        '
        Me.btnShowChoicesCancel.Location = New System.Drawing.Point(248, 469)
        Me.btnShowChoicesCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowChoicesCancel.Name = "btnShowChoicesCancel"
        Me.btnShowChoicesCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnShowChoicesCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnShowChoicesCancel.TabIndex = 24
        Me.btnShowChoicesCancel.Text = "Cancel"
        '
        'DarkLabel53
        '
        Me.DarkLabel53.AutoSize = True
        Me.DarkLabel53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel53.Location = New System.Drawing.Point(164, 422)
        Me.DarkLabel53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel53.Name = "DarkLabel53"
        Me.DarkLabel53.Size = New System.Drawing.Size(49, 20)
        Me.DarkLabel53.TabIndex = 22
        Me.DarkLabel53.Text = "Face:"
        '
        'nudShowChoicesFace
        '
        Me.nudShowChoicesFace.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudShowChoicesFace.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudShowChoicesFace.Location = New System.Drawing.Point(219, 418)
        Me.nudShowChoicesFace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudShowChoicesFace.Name = "nudShowChoicesFace"
        Me.nudShowChoicesFace.Size = New System.Drawing.Size(138, 26)
        Me.nudShowChoicesFace.TabIndex = 23
        Me.nudShowChoicesFace.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'fraPlayerVariable
        '
        Me.fraPlayerVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraPlayerVariable.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraPlayerVariable.Controls.Add(Me.nudVariableData2)
        Me.fraPlayerVariable.Controls.Add(Me.optVariableAction2)
        Me.fraPlayerVariable.Controls.Add(Me.btnPlayerVarOk)
        Me.fraPlayerVariable.Controls.Add(Me.btnPlayerVarCancel)
        Me.fraPlayerVariable.Controls.Add(Me.DarkLabel51)
        Me.fraPlayerVariable.Controls.Add(Me.DarkLabel50)
        Me.fraPlayerVariable.Controls.Add(Me.nudVariableData4)
        Me.fraPlayerVariable.Controls.Add(Me.nudVariableData3)
        Me.fraPlayerVariable.Controls.Add(Me.optVariableAction3)
        Me.fraPlayerVariable.Controls.Add(Me.optVariableAction1)
        Me.fraPlayerVariable.Controls.Add(Me.nudVariableData1)
        Me.fraPlayerVariable.Controls.Add(Me.nudVariableData0)
        Me.fraPlayerVariable.Controls.Add(Me.optVariableAction0)
        Me.fraPlayerVariable.Controls.Add(Me.cmbVariable)
        Me.fraPlayerVariable.Controls.Add(Me.DarkLabel49)
        Me.fraPlayerVariable.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraPlayerVariable.Location = New System.Drawing.Point(602, 434)
        Me.fraPlayerVariable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayerVariable.Name = "fraPlayerVariable"
        Me.fraPlayerVariable.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayerVariable.Size = New System.Drawing.Size(369, 237)
        Me.fraPlayerVariable.TabIndex = 31
        Me.fraPlayerVariable.TabStop = False
        Me.fraPlayerVariable.Text = "Player Variable"
        Me.fraPlayerVariable.Visible = False
        '
        'nudVariableData2
        '
        Me.nudVariableData2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudVariableData2.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudVariableData2.Location = New System.Drawing.Point(180, 111)
        Me.nudVariableData2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudVariableData2.Name = "nudVariableData2"
        Me.nudVariableData2.Size = New System.Drawing.Size(180, 26)
        Me.nudVariableData2.TabIndex = 29
        Me.nudVariableData2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'optVariableAction2
        '
        Me.optVariableAction2.AutoSize = True
        Me.optVariableAction2.Location = New System.Drawing.Point(9, 111)
        Me.optVariableAction2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optVariableAction2.Name = "optVariableAction2"
        Me.optVariableAction2.Size = New System.Drawing.Size(95, 24)
        Me.optVariableAction2.TabIndex = 28
        Me.optVariableAction2.TabStop = True
        Me.optVariableAction2.Text = "Subtract"
        '
        'btnPlayerVarOk
        '
        Me.btnPlayerVarOk.Location = New System.Drawing.Point(126, 191)
        Me.btnPlayerVarOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlayerVarOk.Name = "btnPlayerVarOk"
        Me.btnPlayerVarOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlayerVarOk.Size = New System.Drawing.Size(112, 35)
        Me.btnPlayerVarOk.TabIndex = 27
        Me.btnPlayerVarOk.Text = "Ok"
        '
        'btnPlayerVarCancel
        '
        Me.btnPlayerVarCancel.Location = New System.Drawing.Point(248, 191)
        Me.btnPlayerVarCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlayerVarCancel.Name = "btnPlayerVarCancel"
        Me.btnPlayerVarCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlayerVarCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnPlayerVarCancel.TabIndex = 26
        Me.btnPlayerVarCancel.Text = "Cancel"
        '
        'DarkLabel51
        '
        Me.DarkLabel51.AutoSize = True
        Me.DarkLabel51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel51.Location = New System.Drawing.Point(112, 154)
        Me.DarkLabel51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel51.Name = "DarkLabel51"
        Me.DarkLabel51.Size = New System.Drawing.Size(42, 20)
        Me.DarkLabel51.TabIndex = 16
        Me.DarkLabel51.Text = "Low:"
        '
        'DarkLabel50
        '
        Me.DarkLabel50.AutoSize = True
        Me.DarkLabel50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel50.Location = New System.Drawing.Point(237, 154)
        Me.DarkLabel50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel50.Name = "DarkLabel50"
        Me.DarkLabel50.Size = New System.Drawing.Size(46, 20)
        Me.DarkLabel50.TabIndex = 15
        Me.DarkLabel50.Text = "High:"
        '
        'nudVariableData4
        '
        Me.nudVariableData4.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudVariableData4.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudVariableData4.Location = New System.Drawing.Point(294, 151)
        Me.nudVariableData4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudVariableData4.Name = "nudVariableData4"
        Me.nudVariableData4.Size = New System.Drawing.Size(66, 26)
        Me.nudVariableData4.TabIndex = 14
        Me.nudVariableData4.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'nudVariableData3
        '
        Me.nudVariableData3.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudVariableData3.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudVariableData3.Location = New System.Drawing.Point(166, 151)
        Me.nudVariableData3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudVariableData3.Name = "nudVariableData3"
        Me.nudVariableData3.Size = New System.Drawing.Size(66, 26)
        Me.nudVariableData3.TabIndex = 13
        Me.nudVariableData3.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'optVariableAction3
        '
        Me.optVariableAction3.AutoSize = True
        Me.optVariableAction3.Location = New System.Drawing.Point(9, 151)
        Me.optVariableAction3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optVariableAction3.Name = "optVariableAction3"
        Me.optVariableAction3.Size = New System.Drawing.Size(95, 24)
        Me.optVariableAction3.TabIndex = 12
        Me.optVariableAction3.TabStop = True
        Me.optVariableAction3.Text = "Random"
        '
        'optVariableAction1
        '
        Me.optVariableAction1.AutoSize = True
        Me.optVariableAction1.Location = New System.Drawing.Point(219, 71)
        Me.optVariableAction1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optVariableAction1.Name = "optVariableAction1"
        Me.optVariableAction1.Size = New System.Drawing.Size(63, 24)
        Me.optVariableAction1.TabIndex = 11
        Me.optVariableAction1.TabStop = True
        Me.optVariableAction1.Text = "Add"
        '
        'nudVariableData1
        '
        Me.nudVariableData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudVariableData1.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudVariableData1.Location = New System.Drawing.Point(294, 71)
        Me.nudVariableData1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudVariableData1.Name = "nudVariableData1"
        Me.nudVariableData1.Size = New System.Drawing.Size(66, 26)
        Me.nudVariableData1.TabIndex = 10
        Me.nudVariableData1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'nudVariableData0
        '
        Me.nudVariableData0.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudVariableData0.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudVariableData0.Location = New System.Drawing.Point(93, 71)
        Me.nudVariableData0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudVariableData0.Name = "nudVariableData0"
        Me.nudVariableData0.Size = New System.Drawing.Size(66, 26)
        Me.nudVariableData0.TabIndex = 9
        Me.nudVariableData0.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'optVariableAction0
        '
        Me.optVariableAction0.AutoSize = True
        Me.optVariableAction0.Location = New System.Drawing.Point(9, 71)
        Me.optVariableAction0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optVariableAction0.Name = "optVariableAction0"
        Me.optVariableAction0.Size = New System.Drawing.Size(59, 24)
        Me.optVariableAction0.TabIndex = 2
        Me.optVariableAction0.TabStop = True
        Me.optVariableAction0.Text = "Set"
        '
        'cmbVariable
        '
        Me.cmbVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbVariable.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbVariable.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbVariable.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbVariable.ButtonIcon = CType(resources.GetObject("cmbVariable.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbVariable.DrawDropdownHoverOutline = False
        Me.cmbVariable.DrawFocusRectangle = False
        Me.cmbVariable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVariable.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbVariable.FormattingEnabled = True
        Me.cmbVariable.Location = New System.Drawing.Point(90, 29)
        Me.cmbVariable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbVariable.Name = "cmbVariable"
        Me.cmbVariable.Size = New System.Drawing.Size(266, 27)
        Me.cmbVariable.TabIndex = 1
        Me.cmbVariable.Text = Nothing
        Me.cmbVariable.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel49
        '
        Me.DarkLabel49.AutoSize = True
        Me.DarkLabel49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel49.Location = New System.Drawing.Point(9, 34)
        Me.DarkLabel49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel49.Name = "DarkLabel49"
        Me.DarkLabel49.Size = New System.Drawing.Size(71, 20)
        Me.DarkLabel49.TabIndex = 0
        Me.DarkLabel49.Text = "Variable:"
        '
        'fraChangeSprite
        '
        Me.fraChangeSprite.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraChangeSprite.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraChangeSprite.Controls.Add(Me.btnChangeSpriteOk)
        Me.fraChangeSprite.Controls.Add(Me.btnChangeSpriteCancel)
        Me.fraChangeSprite.Controls.Add(Me.DarkLabel48)
        Me.fraChangeSprite.Controls.Add(Me.nudChangeSprite)
        Me.fraChangeSprite.Controls.Add(Me.picChangeSprite)
        Me.fraChangeSprite.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraChangeSprite.Location = New System.Drawing.Point(602, 431)
        Me.fraChangeSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeSprite.Name = "fraChangeSprite"
        Me.fraChangeSprite.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeSprite.Size = New System.Drawing.Size(369, 180)
        Me.fraChangeSprite.TabIndex = 30
        Me.fraChangeSprite.TabStop = False
        Me.fraChangeSprite.Text = "Change Sprite"
        Me.fraChangeSprite.Visible = False
        '
        'btnChangeSpriteOk
        '
        Me.btnChangeSpriteOk.Location = New System.Drawing.Point(126, 137)
        Me.btnChangeSpriteOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeSpriteOk.Name = "btnChangeSpriteOk"
        Me.btnChangeSpriteOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeSpriteOk.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeSpriteOk.TabIndex = 30
        Me.btnChangeSpriteOk.Text = "Ok"
        '
        'btnChangeSpriteCancel
        '
        Me.btnChangeSpriteCancel.Location = New System.Drawing.Point(248, 137)
        Me.btnChangeSpriteCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeSpriteCancel.Name = "btnChangeSpriteCancel"
        Me.btnChangeSpriteCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeSpriteCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeSpriteCancel.TabIndex = 29
        Me.btnChangeSpriteCancel.Text = "Cancel"
        '
        'DarkLabel48
        '
        Me.DarkLabel48.AutoSize = True
        Me.DarkLabel48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel48.Location = New System.Drawing.Point(120, 103)
        Me.DarkLabel48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel48.Name = "DarkLabel48"
        Me.DarkLabel48.Size = New System.Drawing.Size(51, 20)
        Me.DarkLabel48.TabIndex = 28
        Me.DarkLabel48.Text = "Sprite"
        '
        'nudChangeSprite
        '
        Me.nudChangeSprite.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudChangeSprite.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudChangeSprite.Location = New System.Drawing.Point(180, 97)
        Me.nudChangeSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudChangeSprite.Name = "nudChangeSprite"
        Me.nudChangeSprite.Size = New System.Drawing.Size(180, 26)
        Me.nudChangeSprite.TabIndex = 27
        Me.nudChangeSprite.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'picChangeSprite
        '
        Me.picChangeSprite.BackColor = System.Drawing.Color.Black
        Me.picChangeSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picChangeSprite.Location = New System.Drawing.Point(9, 29)
        Me.picChangeSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picChangeSprite.Name = "picChangeSprite"
        Me.picChangeSprite.Size = New System.Drawing.Size(105, 143)
        Me.picChangeSprite.TabIndex = 3
        Me.picChangeSprite.TabStop = False
        '
        'fraSetSelfSwitch
        '
        Me.fraSetSelfSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraSetSelfSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraSetSelfSwitch.Controls.Add(Me.btnSelfswitchOk)
        Me.fraSetSelfSwitch.Controls.Add(Me.btnSelfswitchCancel)
        Me.fraSetSelfSwitch.Controls.Add(Me.DarkLabel47)
        Me.fraSetSelfSwitch.Controls.Add(Me.cmbSetSelfSwitchTo)
        Me.fraSetSelfSwitch.Controls.Add(Me.DarkLabel46)
        Me.fraSetSelfSwitch.Controls.Add(Me.cmbSetSelfSwitch)
        Me.fraSetSelfSwitch.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraSetSelfSwitch.Location = New System.Drawing.Point(602, 277)
        Me.fraSetSelfSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetSelfSwitch.Name = "fraSetSelfSwitch"
        Me.fraSetSelfSwitch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetSelfSwitch.Size = New System.Drawing.Size(369, 154)
        Me.fraSetSelfSwitch.TabIndex = 29
        Me.fraSetSelfSwitch.TabStop = False
        Me.fraSetSelfSwitch.Text = "Self Switches"
        Me.fraSetSelfSwitch.Visible = False
        '
        'btnSelfswitchOk
        '
        Me.btnSelfswitchOk.Location = New System.Drawing.Point(126, 112)
        Me.btnSelfswitchOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSelfswitchOk.Name = "btnSelfswitchOk"
        Me.btnSelfswitchOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSelfswitchOk.Size = New System.Drawing.Size(112, 35)
        Me.btnSelfswitchOk.TabIndex = 27
        Me.btnSelfswitchOk.Text = "Ok"
        '
        'btnSelfswitchCancel
        '
        Me.btnSelfswitchCancel.Location = New System.Drawing.Point(248, 112)
        Me.btnSelfswitchCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSelfswitchCancel.Name = "btnSelfswitchCancel"
        Me.btnSelfswitchCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSelfswitchCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnSelfswitchCancel.TabIndex = 26
        Me.btnSelfswitchCancel.Text = "Cancel"
        '
        'DarkLabel47
        '
        Me.DarkLabel47.AutoSize = True
        Me.DarkLabel47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel47.Location = New System.Drawing.Point(9, 75)
        Me.DarkLabel47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel47.Name = "DarkLabel47"
        Me.DarkLabel47.Size = New System.Drawing.Size(56, 20)
        Me.DarkLabel47.TabIndex = 3
        Me.DarkLabel47.Text = "Set To"
        '
        'cmbSetSelfSwitchTo
        '
        Me.cmbSetSelfSwitchTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbSetSelfSwitchTo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbSetSelfSwitchTo.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbSetSelfSwitchTo.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbSetSelfSwitchTo.ButtonIcon = CType(resources.GetObject("cmbSetSelfSwitchTo.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbSetSelfSwitchTo.DrawDropdownHoverOutline = False
        Me.cmbSetSelfSwitchTo.DrawFocusRectangle = False
        Me.cmbSetSelfSwitchTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSetSelfSwitchTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSetSelfSwitchTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSetSelfSwitchTo.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbSetSelfSwitchTo.FormattingEnabled = True
        Me.cmbSetSelfSwitchTo.Items.AddRange(New Object() {"Off", "On"})
        Me.cmbSetSelfSwitchTo.Location = New System.Drawing.Point(108, 71)
        Me.cmbSetSelfSwitchTo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSetSelfSwitchTo.Name = "cmbSetSelfSwitchTo"
        Me.cmbSetSelfSwitchTo.Size = New System.Drawing.Size(250, 27)
        Me.cmbSetSelfSwitchTo.TabIndex = 2
        Me.cmbSetSelfSwitchTo.Text = Nothing
        Me.cmbSetSelfSwitchTo.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel46
        '
        Me.DarkLabel46.AutoSize = True
        Me.DarkLabel46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel46.Location = New System.Drawing.Point(9, 34)
        Me.DarkLabel46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel46.Name = "DarkLabel46"
        Me.DarkLabel46.Size = New System.Drawing.Size(92, 20)
        Me.DarkLabel46.TabIndex = 1
        Me.DarkLabel46.Text = "Self Switch:"
        '
        'cmbSetSelfSwitch
        '
        Me.cmbSetSelfSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbSetSelfSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbSetSelfSwitch.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbSetSelfSwitch.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbSetSelfSwitch.ButtonIcon = CType(resources.GetObject("cmbSetSelfSwitch.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbSetSelfSwitch.DrawDropdownHoverOutline = False
        Me.cmbSetSelfSwitch.DrawFocusRectangle = False
        Me.cmbSetSelfSwitch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSetSelfSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSetSelfSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSetSelfSwitch.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbSetSelfSwitch.FormattingEnabled = True
        Me.cmbSetSelfSwitch.Location = New System.Drawing.Point(108, 29)
        Me.cmbSetSelfSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSetSelfSwitch.Name = "cmbSetSelfSwitch"
        Me.cmbSetSelfSwitch.Size = New System.Drawing.Size(250, 27)
        Me.cmbSetSelfSwitch.TabIndex = 0
        Me.cmbSetSelfSwitch.Text = Nothing
        Me.cmbSetSelfSwitch.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraMapTint
        '
        Me.fraMapTint.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraMapTint.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraMapTint.Controls.Add(Me.btnMapTintOk)
        Me.fraMapTint.Controls.Add(Me.btnMapTintCancel)
        Me.fraMapTint.Controls.Add(Me.DarkLabel42)
        Me.fraMapTint.Controls.Add(Me.nudMapTintData3)
        Me.fraMapTint.Controls.Add(Me.nudMapTintData2)
        Me.fraMapTint.Controls.Add(Me.DarkLabel43)
        Me.fraMapTint.Controls.Add(Me.DarkLabel44)
        Me.fraMapTint.Controls.Add(Me.nudMapTintData1)
        Me.fraMapTint.Controls.Add(Me.nudMapTintData0)
        Me.fraMapTint.Controls.Add(Me.DarkLabel45)
        Me.fraMapTint.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraMapTint.Location = New System.Drawing.Point(602, 278)
        Me.fraMapTint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraMapTint.Name = "fraMapTint"
        Me.fraMapTint.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraMapTint.Size = New System.Drawing.Size(369, 223)
        Me.fraMapTint.TabIndex = 28
        Me.fraMapTint.TabStop = False
        Me.fraMapTint.Text = "Map Tinting"
        Me.fraMapTint.Visible = False
        '
        'btnMapTintOk
        '
        Me.btnMapTintOk.Location = New System.Drawing.Point(126, 177)
        Me.btnMapTintOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMapTintOk.Name = "btnMapTintOk"
        Me.btnMapTintOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnMapTintOk.Size = New System.Drawing.Size(112, 35)
        Me.btnMapTintOk.TabIndex = 45
        Me.btnMapTintOk.Text = "Ok"
        '
        'btnMapTintCancel
        '
        Me.btnMapTintCancel.Location = New System.Drawing.Point(248, 177)
        Me.btnMapTintCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMapTintCancel.Name = "btnMapTintCancel"
        Me.btnMapTintCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnMapTintCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnMapTintCancel.TabIndex = 44
        Me.btnMapTintCancel.Text = "Cancel"
        '
        'DarkLabel42
        '
        Me.DarkLabel42.AutoSize = True
        Me.DarkLabel42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel42.Location = New System.Drawing.Point(8, 143)
        Me.DarkLabel42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel42.Name = "DarkLabel42"
        Me.DarkLabel42.Size = New System.Drawing.Size(66, 20)
        Me.DarkLabel42.TabIndex = 43
        Me.DarkLabel42.Text = "Opacity:"
        '
        'nudMapTintData3
        '
        Me.nudMapTintData3.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudMapTintData3.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudMapTintData3.Location = New System.Drawing.Point(142, 137)
        Me.nudMapTintData3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudMapTintData3.Name = "nudMapTintData3"
        Me.nudMapTintData3.Size = New System.Drawing.Size(216, 26)
        Me.nudMapTintData3.TabIndex = 42
        Me.nudMapTintData3.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'nudMapTintData2
        '
        Me.nudMapTintData2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudMapTintData2.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudMapTintData2.Location = New System.Drawing.Point(142, 98)
        Me.nudMapTintData2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudMapTintData2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudMapTintData2.Name = "nudMapTintData2"
        Me.nudMapTintData2.Size = New System.Drawing.Size(216, 26)
        Me.nudMapTintData2.TabIndex = 41
        Me.nudMapTintData2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel43
        '
        Me.DarkLabel43.AutoSize = True
        Me.DarkLabel43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel43.Location = New System.Drawing.Point(8, 102)
        Me.DarkLabel43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel43.Name = "DarkLabel43"
        Me.DarkLabel43.Size = New System.Drawing.Size(45, 20)
        Me.DarkLabel43.TabIndex = 40
        Me.DarkLabel43.Text = "Blue:"
        '
        'DarkLabel44
        '
        Me.DarkLabel44.AutoSize = True
        Me.DarkLabel44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel44.Location = New System.Drawing.Point(6, 66)
        Me.DarkLabel44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel44.Name = "DarkLabel44"
        Me.DarkLabel44.Size = New System.Drawing.Size(58, 20)
        Me.DarkLabel44.TabIndex = 39
        Me.DarkLabel44.Text = "Green:"
        '
        'nudMapTintData1
        '
        Me.nudMapTintData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudMapTintData1.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudMapTintData1.Location = New System.Drawing.Point(142, 60)
        Me.nudMapTintData1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudMapTintData1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudMapTintData1.Name = "nudMapTintData1"
        Me.nudMapTintData1.Size = New System.Drawing.Size(216, 26)
        Me.nudMapTintData1.TabIndex = 38
        Me.nudMapTintData1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'nudMapTintData0
        '
        Me.nudMapTintData0.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudMapTintData0.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudMapTintData0.Location = New System.Drawing.Point(142, 22)
        Me.nudMapTintData0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudMapTintData0.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudMapTintData0.Name = "nudMapTintData0"
        Me.nudMapTintData0.Size = New System.Drawing.Size(216, 26)
        Me.nudMapTintData0.TabIndex = 37
        Me.nudMapTintData0.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel45
        '
        Me.DarkLabel45.AutoSize = True
        Me.DarkLabel45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel45.Location = New System.Drawing.Point(8, 25)
        Me.DarkLabel45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel45.Name = "DarkLabel45"
        Me.DarkLabel45.Size = New System.Drawing.Size(43, 20)
        Me.DarkLabel45.TabIndex = 36
        Me.DarkLabel45.Text = "Red:"
        '
        'fraShowChatBubble
        '
        Me.fraShowChatBubble.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraShowChatBubble.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraShowChatBubble.Controls.Add(Me.btnShowChatBubbleOk)
        Me.fraShowChatBubble.Controls.Add(Me.btnShowChatBubbleCancel)
        Me.fraShowChatBubble.Controls.Add(Me.DarkLabel41)
        Me.fraShowChatBubble.Controls.Add(Me.cmbChatBubbleTarget)
        Me.fraShowChatBubble.Controls.Add(Me.cmbChatBubbleTargetType)
        Me.fraShowChatBubble.Controls.Add(Me.DarkLabel40)
        Me.fraShowChatBubble.Controls.Add(Me.txtChatbubbleText)
        Me.fraShowChatBubble.Controls.Add(Me.DarkLabel39)
        Me.fraShowChatBubble.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraShowChatBubble.Location = New System.Drawing.Point(602, 278)
        Me.fraShowChatBubble.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraShowChatBubble.Name = "fraShowChatBubble"
        Me.fraShowChatBubble.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraShowChatBubble.Size = New System.Drawing.Size(369, 217)
        Me.fraShowChatBubble.TabIndex = 27
        Me.fraShowChatBubble.TabStop = False
        Me.fraShowChatBubble.Text = "Show ChatBubble"
        Me.fraShowChatBubble.Visible = False
        '
        'btnShowChatBubbleOk
        '
        Me.btnShowChatBubbleOk.Location = New System.Drawing.Point(126, 172)
        Me.btnShowChatBubbleOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowChatBubbleOk.Name = "btnShowChatBubbleOk"
        Me.btnShowChatBubbleOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnShowChatBubbleOk.Size = New System.Drawing.Size(112, 35)
        Me.btnShowChatBubbleOk.TabIndex = 31
        Me.btnShowChatBubbleOk.Text = "Ok"
        '
        'btnShowChatBubbleCancel
        '
        Me.btnShowChatBubbleCancel.Location = New System.Drawing.Point(248, 172)
        Me.btnShowChatBubbleCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowChatBubbleCancel.Name = "btnShowChatBubbleCancel"
        Me.btnShowChatBubbleCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnShowChatBubbleCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnShowChatBubbleCancel.TabIndex = 30
        Me.btnShowChatBubbleCancel.Text = "Cancel"
        '
        'DarkLabel41
        '
        Me.DarkLabel41.AutoSize = True
        Me.DarkLabel41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel41.Location = New System.Drawing.Point(9, 135)
        Me.DarkLabel41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel41.Name = "DarkLabel41"
        Me.DarkLabel41.Size = New System.Drawing.Size(52, 20)
        Me.DarkLabel41.TabIndex = 29
        Me.DarkLabel41.Text = "Index:"
        '
        'cmbChatBubbleTarget
        '
        Me.cmbChatBubbleTarget.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbChatBubbleTarget.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbChatBubbleTarget.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbChatBubbleTarget.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbChatBubbleTarget.ButtonIcon = CType(resources.GetObject("cmbChatBubbleTarget.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbChatBubbleTarget.DrawDropdownHoverOutline = False
        Me.cmbChatBubbleTarget.DrawFocusRectangle = False
        Me.cmbChatBubbleTarget.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbChatBubbleTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChatBubbleTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbChatBubbleTarget.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbChatBubbleTarget.FormattingEnabled = True
        Me.cmbChatBubbleTarget.Location = New System.Drawing.Point(122, 131)
        Me.cmbChatBubbleTarget.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbChatBubbleTarget.Name = "cmbChatBubbleTarget"
        Me.cmbChatBubbleTarget.Size = New System.Drawing.Size(236, 27)
        Me.cmbChatBubbleTarget.TabIndex = 28
        Me.cmbChatBubbleTarget.Text = Nothing
        Me.cmbChatBubbleTarget.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'cmbChatBubbleTargetType
        '
        Me.cmbChatBubbleTargetType.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbChatBubbleTargetType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbChatBubbleTargetType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbChatBubbleTargetType.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbChatBubbleTargetType.ButtonIcon = CType(resources.GetObject("cmbChatBubbleTargetType.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbChatBubbleTargetType.DrawDropdownHoverOutline = False
        Me.cmbChatBubbleTargetType.DrawFocusRectangle = False
        Me.cmbChatBubbleTargetType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbChatBubbleTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChatBubbleTargetType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbChatBubbleTargetType.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbChatBubbleTargetType.FormattingEnabled = True
        Me.cmbChatBubbleTargetType.Items.AddRange(New Object() {"Player", "Npc", "Event"})
        Me.cmbChatBubbleTargetType.Location = New System.Drawing.Point(122, 89)
        Me.cmbChatBubbleTargetType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbChatBubbleTargetType.Name = "cmbChatBubbleTargetType"
        Me.cmbChatBubbleTargetType.Size = New System.Drawing.Size(236, 27)
        Me.cmbChatBubbleTargetType.TabIndex = 27
        Me.cmbChatBubbleTargetType.Text = Nothing
        Me.cmbChatBubbleTargetType.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel40
        '
        Me.DarkLabel40.AutoSize = True
        Me.DarkLabel40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel40.Location = New System.Drawing.Point(9, 94)
        Me.DarkLabel40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel40.Name = "DarkLabel40"
        Me.DarkLabel40.Size = New System.Drawing.Size(97, 20)
        Me.DarkLabel40.TabIndex = 2
        Me.DarkLabel40.Text = "Target Type:"
        '
        'txtChatbubbleText
        '
        Me.txtChatbubbleText.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtChatbubbleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChatbubbleText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtChatbubbleText.Location = New System.Drawing.Point(9, 49)
        Me.txtChatbubbleText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChatbubbleText.Name = "txtChatbubbleText"
        Me.txtChatbubbleText.Size = New System.Drawing.Size(350, 26)
        Me.txtChatbubbleText.TabIndex = 1
        '
        'DarkLabel39
        '
        Me.DarkLabel39.AutoSize = True
        Me.DarkLabel39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel39.Location = New System.Drawing.Point(9, 25)
        Me.DarkLabel39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel39.Name = "DarkLabel39"
        Me.DarkLabel39.Size = New System.Drawing.Size(127, 20)
        Me.DarkLabel39.TabIndex = 0
        Me.DarkLabel39.Text = "ChatBubble Text"
        '
        'fraPlaySound
        '
        Me.fraPlaySound.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraPlaySound.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraPlaySound.Controls.Add(Me.btnPlaySoundOk)
        Me.fraPlaySound.Controls.Add(Me.btnPlaySoundCancel)
        Me.fraPlaySound.Controls.Add(Me.cmbPlaySound)
        Me.fraPlaySound.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraPlaySound.Location = New System.Drawing.Point(602, 275)
        Me.fraPlaySound.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlaySound.Name = "fraPlaySound"
        Me.fraPlaySound.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlaySound.Size = New System.Drawing.Size(369, 117)
        Me.fraPlaySound.TabIndex = 26
        Me.fraPlaySound.TabStop = False
        Me.fraPlaySound.Text = "Play Sound"
        Me.fraPlaySound.Visible = False
        '
        'btnPlaySoundOk
        '
        Me.btnPlaySoundOk.Location = New System.Drawing.Point(126, 71)
        Me.btnPlaySoundOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlaySoundOk.Name = "btnPlaySoundOk"
        Me.btnPlaySoundOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlaySoundOk.Size = New System.Drawing.Size(112, 35)
        Me.btnPlaySoundOk.TabIndex = 27
        Me.btnPlaySoundOk.Text = "Ok"
        '
        'btnPlaySoundCancel
        '
        Me.btnPlaySoundCancel.Location = New System.Drawing.Point(248, 71)
        Me.btnPlaySoundCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlaySoundCancel.Name = "btnPlaySoundCancel"
        Me.btnPlaySoundCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlaySoundCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnPlaySoundCancel.TabIndex = 26
        Me.btnPlaySoundCancel.Text = "Cancel"
        '
        'cmbPlaySound
        '
        Me.cmbPlaySound.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPlaySound.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPlaySound.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPlaySound.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPlaySound.ButtonIcon = CType(resources.GetObject("cmbPlaySound.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPlaySound.DrawDropdownHoverOutline = False
        Me.cmbPlaySound.DrawFocusRectangle = False
        Me.cmbPlaySound.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPlaySound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlaySound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlaySound.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPlaySound.FormattingEnabled = True
        Me.cmbPlaySound.Location = New System.Drawing.Point(9, 29)
        Me.cmbPlaySound.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPlaySound.Name = "cmbPlaySound"
        Me.cmbPlaySound.Size = New System.Drawing.Size(349, 27)
        Me.cmbPlaySound.TabIndex = 0
        Me.cmbPlaySound.Text = Nothing
        Me.cmbPlaySound.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraChangePK
        '
        Me.fraChangePK.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraChangePK.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraChangePK.Controls.Add(Me.btnChangePkOk)
        Me.fraChangePK.Controls.Add(Me.btnChangePkCancel)
        Me.fraChangePK.Controls.Add(Me.cmbSetPK)
        Me.fraChangePK.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraChangePK.Location = New System.Drawing.Point(602, 160)
        Me.fraChangePK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangePK.Name = "fraChangePK"
        Me.fraChangePK.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangePK.Size = New System.Drawing.Size(369, 115)
        Me.fraChangePK.TabIndex = 25
        Me.fraChangePK.TabStop = False
        Me.fraChangePK.Text = "Set Player PK"
        Me.fraChangePK.Visible = False
        '
        'btnChangePkOk
        '
        Me.btnChangePkOk.Location = New System.Drawing.Point(120, 71)
        Me.btnChangePkOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangePkOk.Name = "btnChangePkOk"
        Me.btnChangePkOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangePkOk.Size = New System.Drawing.Size(112, 35)
        Me.btnChangePkOk.TabIndex = 27
        Me.btnChangePkOk.Text = "Ok"
        '
        'btnChangePkCancel
        '
        Me.btnChangePkCancel.Location = New System.Drawing.Point(242, 71)
        Me.btnChangePkCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangePkCancel.Name = "btnChangePkCancel"
        Me.btnChangePkCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangePkCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnChangePkCancel.TabIndex = 26
        Me.btnChangePkCancel.Text = "Cancel"
        '
        'cmbSetPK
        '
        Me.cmbSetPK.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbSetPK.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbSetPK.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbSetPK.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbSetPK.ButtonIcon = CType(resources.GetObject("cmbSetPK.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbSetPK.DrawDropdownHoverOutline = False
        Me.cmbSetPK.DrawFocusRectangle = False
        Me.cmbSetPK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSetPK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSetPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSetPK.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbSetPK.FormattingEnabled = True
        Me.cmbSetPK.Items.AddRange(New Object() {"No", "Yes"})
        Me.cmbSetPK.Location = New System.Drawing.Point(15, 29)
        Me.cmbSetPK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSetPK.Name = "cmbSetPK"
        Me.cmbSetPK.Size = New System.Drawing.Size(337, 27)
        Me.cmbSetPK.TabIndex = 18
        Me.cmbSetPK.Text = Nothing
        Me.cmbSetPK.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraCreateLabel
        '
        Me.fraCreateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraCreateLabel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraCreateLabel.Controls.Add(Me.btnCreatelabelOk)
        Me.fraCreateLabel.Controls.Add(Me.btnCreatelabelCancel)
        Me.fraCreateLabel.Controls.Add(Me.txtLabelName)
        Me.fraCreateLabel.Controls.Add(Me.lblLabelName)
        Me.fraCreateLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraCreateLabel.Location = New System.Drawing.Point(602, 203)
        Me.fraCreateLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraCreateLabel.Name = "fraCreateLabel"
        Me.fraCreateLabel.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraCreateLabel.Size = New System.Drawing.Size(369, 114)
        Me.fraCreateLabel.TabIndex = 24
        Me.fraCreateLabel.TabStop = False
        Me.fraCreateLabel.Text = "Create Label"
        Me.fraCreateLabel.Visible = False
        '
        'btnCreatelabelOk
        '
        Me.btnCreatelabelOk.Location = New System.Drawing.Point(126, 69)
        Me.btnCreatelabelOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCreatelabelOk.Name = "btnCreatelabelOk"
        Me.btnCreatelabelOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCreatelabelOk.Size = New System.Drawing.Size(112, 35)
        Me.btnCreatelabelOk.TabIndex = 27
        Me.btnCreatelabelOk.Text = "Ok"
        '
        'btnCreatelabelCancel
        '
        Me.btnCreatelabelCancel.Location = New System.Drawing.Point(248, 69)
        Me.btnCreatelabelCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCreatelabelCancel.Name = "btnCreatelabelCancel"
        Me.btnCreatelabelCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCreatelabelCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCreatelabelCancel.TabIndex = 26
        Me.btnCreatelabelCancel.Text = "Cancel"
        '
        'txtLabelName
        '
        Me.txtLabelName.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtLabelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtLabelName.Location = New System.Drawing.Point(120, 29)
        Me.txtLabelName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLabelName.Name = "txtLabelName"
        Me.txtLabelName.Size = New System.Drawing.Size(239, 26)
        Me.txtLabelName.TabIndex = 1
        '
        'lblLabelName
        '
        Me.lblLabelName.AutoSize = True
        Me.lblLabelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblLabelName.Location = New System.Drawing.Point(10, 32)
        Me.lblLabelName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabelName.Name = "lblLabelName"
        Me.lblLabelName.Size = New System.Drawing.Size(98, 20)
        Me.lblLabelName.TabIndex = 0
        Me.lblLabelName.Text = "Label Name:"
        '
        'fraChangeClass
        '
        Me.fraChangeClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraChangeClass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraChangeClass.Controls.Add(Me.btnChangeClassOk)
        Me.fraChangeClass.Controls.Add(Me.btnChangeClassCancel)
        Me.fraChangeClass.Controls.Add(Me.cmbChangeClass)
        Me.fraChangeClass.Controls.Add(Me.DarkLabel38)
        Me.fraChangeClass.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraChangeClass.Location = New System.Drawing.Point(602, 168)
        Me.fraChangeClass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeClass.Name = "fraChangeClass"
        Me.fraChangeClass.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeClass.Size = New System.Drawing.Size(369, 117)
        Me.fraChangeClass.TabIndex = 23
        Me.fraChangeClass.TabStop = False
        Me.fraChangeClass.Text = "Change Player Class"
        Me.fraChangeClass.Visible = False
        '
        'btnChangeClassOk
        '
        Me.btnChangeClassOk.Location = New System.Drawing.Point(126, 71)
        Me.btnChangeClassOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeClassOk.Name = "btnChangeClassOk"
        Me.btnChangeClassOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeClassOk.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeClassOk.TabIndex = 27
        Me.btnChangeClassOk.Text = "Ok"
        '
        'btnChangeClassCancel
        '
        Me.btnChangeClassCancel.Location = New System.Drawing.Point(248, 71)
        Me.btnChangeClassCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeClassCancel.Name = "btnChangeClassCancel"
        Me.btnChangeClassCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeClassCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeClassCancel.TabIndex = 26
        Me.btnChangeClassCancel.Text = "Cancel"
        '
        'cmbChangeClass
        '
        Me.cmbChangeClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbChangeClass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbChangeClass.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbChangeClass.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbChangeClass.ButtonIcon = CType(resources.GetObject("cmbChangeClass.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbChangeClass.DrawDropdownHoverOutline = False
        Me.cmbChangeClass.DrawFocusRectangle = False
        Me.cmbChangeClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbChangeClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChangeClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbChangeClass.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbChangeClass.FormattingEnabled = True
        Me.cmbChangeClass.Location = New System.Drawing.Point(74, 29)
        Me.cmbChangeClass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbChangeClass.Name = "cmbChangeClass"
        Me.cmbChangeClass.Size = New System.Drawing.Size(284, 27)
        Me.cmbChangeClass.TabIndex = 1
        Me.cmbChangeClass.Text = Nothing
        Me.cmbChangeClass.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel38
        '
        Me.DarkLabel38.AutoSize = True
        Me.DarkLabel38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel38.Location = New System.Drawing.Point(12, 34)
        Me.DarkLabel38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel38.Name = "DarkLabel38"
        Me.DarkLabel38.Size = New System.Drawing.Size(52, 20)
        Me.DarkLabel38.TabIndex = 0
        Me.DarkLabel38.Text = "Class:"
        '
        'fraChangeSkills
        '
        Me.fraChangeSkills.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraChangeSkills.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraChangeSkills.Controls.Add(Me.btnChangeSkillsOk)
        Me.fraChangeSkills.Controls.Add(Me.btnChangeSkillsCancel)
        Me.fraChangeSkills.Controls.Add(Me.optChangeSkillsRemove)
        Me.fraChangeSkills.Controls.Add(Me.optChangeSkillsAdd)
        Me.fraChangeSkills.Controls.Add(Me.cmbChangeSkills)
        Me.fraChangeSkills.Controls.Add(Me.DarkLabel37)
        Me.fraChangeSkills.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraChangeSkills.Location = New System.Drawing.Point(602, 166)
        Me.fraChangeSkills.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeSkills.Name = "fraChangeSkills"
        Me.fraChangeSkills.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeSkills.Size = New System.Drawing.Size(369, 151)
        Me.fraChangeSkills.TabIndex = 22
        Me.fraChangeSkills.TabStop = False
        Me.fraChangeSkills.Text = "Change Player Skills"
        Me.fraChangeSkills.Visible = False
        '
        'btnChangeSkillsOk
        '
        Me.btnChangeSkillsOk.Location = New System.Drawing.Point(126, 103)
        Me.btnChangeSkillsOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeSkillsOk.Name = "btnChangeSkillsOk"
        Me.btnChangeSkillsOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeSkillsOk.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeSkillsOk.TabIndex = 27
        Me.btnChangeSkillsOk.Text = "Ok"
        '
        'btnChangeSkillsCancel
        '
        Me.btnChangeSkillsCancel.Location = New System.Drawing.Point(248, 103)
        Me.btnChangeSkillsCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeSkillsCancel.Name = "btnChangeSkillsCancel"
        Me.btnChangeSkillsCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeSkillsCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeSkillsCancel.TabIndex = 26
        Me.btnChangeSkillsCancel.Text = "Cancel"
        '
        'optChangeSkillsRemove
        '
        Me.optChangeSkillsRemove.AutoSize = True
        Me.optChangeSkillsRemove.Location = New System.Drawing.Point(220, 68)
        Me.optChangeSkillsRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optChangeSkillsRemove.Name = "optChangeSkillsRemove"
        Me.optChangeSkillsRemove.Size = New System.Drawing.Size(81, 24)
        Me.optChangeSkillsRemove.TabIndex = 3
        Me.optChangeSkillsRemove.TabStop = True
        Me.optChangeSkillsRemove.Text = "Forget"
        '
        'optChangeSkillsAdd
        '
        Me.optChangeSkillsAdd.AutoSize = True
        Me.optChangeSkillsAdd.Location = New System.Drawing.Point(98, 68)
        Me.optChangeSkillsAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optChangeSkillsAdd.Name = "optChangeSkillsAdd"
        Me.optChangeSkillsAdd.Size = New System.Drawing.Size(78, 24)
        Me.optChangeSkillsAdd.TabIndex = 2
        Me.optChangeSkillsAdd.TabStop = True
        Me.optChangeSkillsAdd.Text = "Teach"
        '
        'cmbChangeSkills
        '
        Me.cmbChangeSkills.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbChangeSkills.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbChangeSkills.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbChangeSkills.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbChangeSkills.ButtonIcon = CType(resources.GetObject("cmbChangeSkills.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbChangeSkills.DrawDropdownHoverOutline = False
        Me.cmbChangeSkills.DrawFocusRectangle = False
        Me.cmbChangeSkills.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbChangeSkills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChangeSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbChangeSkills.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbChangeSkills.FormattingEnabled = True
        Me.cmbChangeSkills.Location = New System.Drawing.Point(62, 26)
        Me.cmbChangeSkills.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbChangeSkills.Name = "cmbChangeSkills"
        Me.cmbChangeSkills.Size = New System.Drawing.Size(295, 27)
        Me.cmbChangeSkills.TabIndex = 1
        Me.cmbChangeSkills.Text = Nothing
        Me.cmbChangeSkills.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel37
        '
        Me.DarkLabel37.AutoSize = True
        Me.DarkLabel37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel37.Location = New System.Drawing.Point(9, 31)
        Me.DarkLabel37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel37.Name = "DarkLabel37"
        Me.DarkLabel37.Size = New System.Drawing.Size(41, 20)
        Me.DarkLabel37.TabIndex = 0
        Me.DarkLabel37.Text = "Skill:"
        '
        'fraCompleteTask
        '
        Me.fraCompleteTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraCompleteTask.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraCompleteTask.Controls.Add(Me.btnCompleteQuestTaskOk)
        Me.fraCompleteTask.Controls.Add(Me.btnCompleteQuestTaskCancel)
        Me.fraCompleteTask.Controls.Add(Me.DarkLabel35)
        Me.fraCompleteTask.Controls.Add(Me.DarkLabel36)
        Me.fraCompleteTask.Controls.Add(Me.nudCompleteQuestTask)
        Me.fraCompleteTask.Controls.Add(Me.cmbCompleteQuest)
        Me.fraCompleteTask.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraCompleteTask.Location = New System.Drawing.Point(602, 5)
        Me.fraCompleteTask.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraCompleteTask.Name = "fraCompleteTask"
        Me.fraCompleteTask.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraCompleteTask.Size = New System.Drawing.Size(369, 154)
        Me.fraCompleteTask.TabIndex = 20
        Me.fraCompleteTask.TabStop = False
        Me.fraCompleteTask.Text = "Complete Quest Task"
        Me.fraCompleteTask.Visible = False
        '
        'btnCompleteQuestTaskOk
        '
        Me.btnCompleteQuestTaskOk.Location = New System.Drawing.Point(126, 114)
        Me.btnCompleteQuestTaskOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCompleteQuestTaskOk.Name = "btnCompleteQuestTaskOk"
        Me.btnCompleteQuestTaskOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCompleteQuestTaskOk.Size = New System.Drawing.Size(112, 35)
        Me.btnCompleteQuestTaskOk.TabIndex = 27
        Me.btnCompleteQuestTaskOk.Text = "Ok"
        '
        'btnCompleteQuestTaskCancel
        '
        Me.btnCompleteQuestTaskCancel.Location = New System.Drawing.Point(248, 114)
        Me.btnCompleteQuestTaskCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCompleteQuestTaskCancel.Name = "btnCompleteQuestTaskCancel"
        Me.btnCompleteQuestTaskCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCompleteQuestTaskCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCompleteQuestTaskCancel.TabIndex = 26
        Me.btnCompleteQuestTaskCancel.Text = "Cancel"
        '
        'DarkLabel35
        '
        Me.DarkLabel35.AutoSize = True
        Me.DarkLabel35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel35.Location = New System.Drawing.Point(15, 77)
        Me.DarkLabel35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel35.Name = "DarkLabel35"
        Me.DarkLabel35.Size = New System.Drawing.Size(47, 20)
        Me.DarkLabel35.TabIndex = 23
        Me.DarkLabel35.Text = "Task:"
        '
        'DarkLabel36
        '
        Me.DarkLabel36.AutoSize = True
        Me.DarkLabel36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel36.Location = New System.Drawing.Point(15, 34)
        Me.DarkLabel36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel36.Name = "DarkLabel36"
        Me.DarkLabel36.Size = New System.Drawing.Size(56, 20)
        Me.DarkLabel36.TabIndex = 22
        Me.DarkLabel36.Text = "Quest:"
        '
        'nudCompleteQuestTask
        '
        Me.nudCompleteQuestTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudCompleteQuestTask.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudCompleteQuestTask.Location = New System.Drawing.Point(90, 74)
        Me.nudCompleteQuestTask.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudCompleteQuestTask.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCompleteQuestTask.Name = "nudCompleteQuestTask"
        Me.nudCompleteQuestTask.Size = New System.Drawing.Size(268, 26)
        Me.nudCompleteQuestTask.TabIndex = 21
        Me.nudCompleteQuestTask.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbCompleteQuest
        '
        Me.cmbCompleteQuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbCompleteQuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbCompleteQuest.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbCompleteQuest.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbCompleteQuest.ButtonIcon = CType(resources.GetObject("cmbCompleteQuest.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbCompleteQuest.DrawDropdownHoverOutline = False
        Me.cmbCompleteQuest.DrawFocusRectangle = False
        Me.cmbCompleteQuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCompleteQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompleteQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCompleteQuest.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbCompleteQuest.FormattingEnabled = True
        Me.cmbCompleteQuest.Location = New System.Drawing.Point(90, 29)
        Me.cmbCompleteQuest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCompleteQuest.Name = "cmbCompleteQuest"
        Me.cmbCompleteQuest.Size = New System.Drawing.Size(266, 27)
        Me.cmbCompleteQuest.TabIndex = 20
        Me.cmbCompleteQuest.Text = Nothing
        Me.cmbCompleteQuest.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'fraPlayerWarp
        '
        Me.fraPlayerWarp.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraPlayerWarp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraPlayerWarp.Controls.Add(Me.btnPlayerWarpOk)
        Me.fraPlayerWarp.Controls.Add(Me.btnPlayerWarpCancel)
        Me.fraPlayerWarp.Controls.Add(Me.DarkLabel31)
        Me.fraPlayerWarp.Controls.Add(Me.cmbWarpPlayerDir)
        Me.fraPlayerWarp.Controls.Add(Me.nudWPY)
        Me.fraPlayerWarp.Controls.Add(Me.DarkLabel32)
        Me.fraPlayerWarp.Controls.Add(Me.nudWPX)
        Me.fraPlayerWarp.Controls.Add(Me.DarkLabel33)
        Me.fraPlayerWarp.Controls.Add(Me.nudWPMap)
        Me.fraPlayerWarp.Controls.Add(Me.DarkLabel34)
        Me.fraPlayerWarp.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraPlayerWarp.Location = New System.Drawing.Point(602, 9)
        Me.fraPlayerWarp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayerWarp.Name = "fraPlayerWarp"
        Me.fraPlayerWarp.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayerWarp.Size = New System.Drawing.Size(369, 149)
        Me.fraPlayerWarp.TabIndex = 19
        Me.fraPlayerWarp.TabStop = False
        Me.fraPlayerWarp.Text = "Warp Player"
        Me.fraPlayerWarp.Visible = False
        '
        'btnPlayerWarpOk
        '
        Me.btnPlayerWarpOk.Location = New System.Drawing.Point(124, 105)
        Me.btnPlayerWarpOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlayerWarpOk.Name = "btnPlayerWarpOk"
        Me.btnPlayerWarpOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlayerWarpOk.Size = New System.Drawing.Size(112, 35)
        Me.btnPlayerWarpOk.TabIndex = 46
        Me.btnPlayerWarpOk.Text = "Ok"
        '
        'btnPlayerWarpCancel
        '
        Me.btnPlayerWarpCancel.Location = New System.Drawing.Point(246, 105)
        Me.btnPlayerWarpCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlayerWarpCancel.Name = "btnPlayerWarpCancel"
        Me.btnPlayerWarpCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlayerWarpCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnPlayerWarpCancel.TabIndex = 45
        Me.btnPlayerWarpCancel.Text = "Cancel"
        '
        'DarkLabel31
        '
        Me.DarkLabel31.AutoSize = True
        Me.DarkLabel31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel31.Location = New System.Drawing.Point(12, 68)
        Me.DarkLabel31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel31.Name = "DarkLabel31"
        Me.DarkLabel31.Size = New System.Drawing.Size(76, 20)
        Me.DarkLabel31.TabIndex = 44
        Me.DarkLabel31.Text = "Direction:"
        '
        'cmbWarpPlayerDir
        '
        Me.cmbWarpPlayerDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbWarpPlayerDir.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbWarpPlayerDir.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbWarpPlayerDir.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbWarpPlayerDir.ButtonIcon = CType(resources.GetObject("cmbWarpPlayerDir.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbWarpPlayerDir.DrawDropdownHoverOutline = False
        Me.cmbWarpPlayerDir.DrawFocusRectangle = False
        Me.cmbWarpPlayerDir.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbWarpPlayerDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWarpPlayerDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbWarpPlayerDir.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbWarpPlayerDir.FormattingEnabled = True
        Me.cmbWarpPlayerDir.Items.AddRange(New Object() {"Retain Direction", "Up", "Down", "Left", "Right"})
        Me.cmbWarpPlayerDir.Location = New System.Drawing.Point(144, 63)
        Me.cmbWarpPlayerDir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbWarpPlayerDir.Name = "cmbWarpPlayerDir"
        Me.cmbWarpPlayerDir.Size = New System.Drawing.Size(212, 27)
        Me.cmbWarpPlayerDir.TabIndex = 43
        Me.cmbWarpPlayerDir.Text = Nothing
        Me.cmbWarpPlayerDir.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'nudWPY
        '
        Me.nudWPY.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudWPY.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudWPY.Location = New System.Drawing.Point(300, 23)
        Me.nudWPY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudWPY.Name = "nudWPY"
        Me.nudWPY.Size = New System.Drawing.Size(58, 26)
        Me.nudWPY.TabIndex = 42
        Me.nudWPY.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel32
        '
        Me.DarkLabel32.AutoSize = True
        Me.DarkLabel32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel32.Location = New System.Drawing.Point(266, 26)
        Me.DarkLabel32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel32.Name = "DarkLabel32"
        Me.DarkLabel32.Size = New System.Drawing.Size(24, 20)
        Me.DarkLabel32.TabIndex = 41
        Me.DarkLabel32.Text = "Y:"
        '
        'nudWPX
        '
        Me.nudWPX.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudWPX.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudWPX.Location = New System.Drawing.Point(195, 23)
        Me.nudWPX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudWPX.Name = "nudWPX"
        Me.nudWPX.Size = New System.Drawing.Size(58, 26)
        Me.nudWPX.TabIndex = 40
        Me.nudWPX.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel33
        '
        Me.DarkLabel33.AutoSize = True
        Me.DarkLabel33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel33.Location = New System.Drawing.Point(160, 26)
        Me.DarkLabel33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel33.Name = "DarkLabel33"
        Me.DarkLabel33.Size = New System.Drawing.Size(24, 20)
        Me.DarkLabel33.TabIndex = 39
        Me.DarkLabel33.Text = "X:"
        '
        'nudWPMap
        '
        Me.nudWPMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudWPMap.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudWPMap.Location = New System.Drawing.Point(64, 23)
        Me.nudWPMap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudWPMap.Name = "nudWPMap"
        Me.nudWPMap.Size = New System.Drawing.Size(87, 26)
        Me.nudWPMap.TabIndex = 38
        Me.nudWPMap.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel34
        '
        Me.DarkLabel34.AutoSize = True
        Me.DarkLabel34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel34.Location = New System.Drawing.Point(9, 26)
        Me.DarkLabel34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel34.Name = "DarkLabel34"
        Me.DarkLabel34.Size = New System.Drawing.Size(44, 20)
        Me.DarkLabel34.TabIndex = 37
        Me.DarkLabel34.Text = "Map:"
        '
        'fraSetFog
        '
        Me.fraSetFog.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraSetFog.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraSetFog.Controls.Add(Me.btnSetFogOk)
        Me.fraSetFog.Controls.Add(Me.btnSetFogCancel)
        Me.fraSetFog.Controls.Add(Me.DarkLabel30)
        Me.fraSetFog.Controls.Add(Me.DarkLabel29)
        Me.fraSetFog.Controls.Add(Me.DarkLabel28)
        Me.fraSetFog.Controls.Add(Me.nudFogData2)
        Me.fraSetFog.Controls.Add(Me.nudFogData1)
        Me.fraSetFog.Controls.Add(Me.nudFogData0)
        Me.fraSetFog.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraSetFog.Location = New System.Drawing.Point(602, 11)
        Me.fraSetFog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetFog.Name = "fraSetFog"
        Me.fraSetFog.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraSetFog.Size = New System.Drawing.Size(369, 148)
        Me.fraSetFog.TabIndex = 18
        Me.fraSetFog.TabStop = False
        Me.fraSetFog.Text = "Set Fog"
        Me.fraSetFog.Visible = False
        '
        'btnSetFogOk
        '
        Me.btnSetFogOk.Location = New System.Drawing.Point(126, 103)
        Me.btnSetFogOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetFogOk.Name = "btnSetFogOk"
        Me.btnSetFogOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetFogOk.Size = New System.Drawing.Size(112, 35)
        Me.btnSetFogOk.TabIndex = 41
        Me.btnSetFogOk.Text = "Ok"
        '
        'btnSetFogCancel
        '
        Me.btnSetFogCancel.Location = New System.Drawing.Point(248, 103)
        Me.btnSetFogCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetFogCancel.Name = "btnSetFogCancel"
        Me.btnSetFogCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetFogCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnSetFogCancel.TabIndex = 40
        Me.btnSetFogCancel.Text = "Cancel"
        '
        'DarkLabel30
        '
        Me.DarkLabel30.AutoSize = True
        Me.DarkLabel30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel30.Location = New System.Drawing.Point(186, 65)
        Me.DarkLabel30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel30.Name = "DarkLabel30"
        Me.DarkLabel30.Size = New System.Drawing.Size(98, 20)
        Me.DarkLabel30.TabIndex = 39
        Me.DarkLabel30.Text = "Fog Opacity:"
        '
        'DarkLabel29
        '
        Me.DarkLabel29.AutoSize = True
        Me.DarkLabel29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel29.Location = New System.Drawing.Point(10, 65)
        Me.DarkLabel29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel29.Name = "DarkLabel29"
        Me.DarkLabel29.Size = New System.Drawing.Size(92, 20)
        Me.DarkLabel29.TabIndex = 38
        Me.DarkLabel29.Text = "Fog Speed:"
        '
        'DarkLabel28
        '
        Me.DarkLabel28.AutoSize = True
        Me.DarkLabel28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel28.Location = New System.Drawing.Point(10, 23)
        Me.DarkLabel28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel28.Name = "DarkLabel28"
        Me.DarkLabel28.Size = New System.Drawing.Size(41, 20)
        Me.DarkLabel28.TabIndex = 37
        Me.DarkLabel28.Text = "Fog:"
        '
        'nudFogData2
        '
        Me.nudFogData2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudFogData2.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudFogData2.Location = New System.Drawing.Point(286, 60)
        Me.nudFogData2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudFogData2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudFogData2.Name = "nudFogData2"
        Me.nudFogData2.Size = New System.Drawing.Size(74, 26)
        Me.nudFogData2.TabIndex = 36
        Me.nudFogData2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'nudFogData1
        '
        Me.nudFogData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudFogData1.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudFogData1.Location = New System.Drawing.Point(108, 62)
        Me.nudFogData1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudFogData1.Name = "nudFogData1"
        Me.nudFogData1.Size = New System.Drawing.Size(72, 26)
        Me.nudFogData1.TabIndex = 35
        Me.nudFogData1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'nudFogData0
        '
        Me.nudFogData0.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudFogData0.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudFogData0.Location = New System.Drawing.Point(146, 18)
        Me.nudFogData0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudFogData0.Name = "nudFogData0"
        Me.nudFogData0.Size = New System.Drawing.Size(214, 26)
        Me.nudFogData0.TabIndex = 34
        Me.nudFogData0.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'fraShowText
        '
        Me.fraShowText.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraShowText.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraShowText.Controls.Add(Me.DarkLabel27)
        Me.fraShowText.Controls.Add(Me.txtShowText)
        Me.fraShowText.Controls.Add(Me.btnShowTextCancel)
        Me.fraShowText.Controls.Add(Me.btnShowTextOk)
        Me.fraShowText.Controls.Add(Me.picShowTextFace)
        Me.fraShowText.Controls.Add(Me.DarkLabel26)
        Me.fraShowText.Controls.Add(Me.nudShowTextFace)
        Me.fraShowText.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraShowText.Location = New System.Drawing.Point(9, 468)
        Me.fraShowText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraShowText.Name = "fraShowText"
        Me.fraShowText.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraShowText.Size = New System.Drawing.Size(372, 437)
        Me.fraShowText.TabIndex = 17
        Me.fraShowText.TabStop = False
        Me.fraShowText.Text = "Show Text"
        Me.fraShowText.Visible = False
        '
        'DarkLabel27
        '
        Me.DarkLabel27.AutoSize = True
        Me.DarkLabel27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel27.Location = New System.Drawing.Point(10, 29)
        Me.DarkLabel27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel27.Name = "DarkLabel27"
        Me.DarkLabel27.Size = New System.Drawing.Size(39, 20)
        Me.DarkLabel27.TabIndex = 26
        Me.DarkLabel27.Text = "Text"
        '
        'txtShowText
        '
        Me.txtShowText.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtShowText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShowText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtShowText.Location = New System.Drawing.Point(14, 58)
        Me.txtShowText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtShowText.Multiline = True
        Me.txtShowText.Name = "txtShowText"
        Me.txtShowText.Size = New System.Drawing.Size(341, 160)
        Me.txtShowText.TabIndex = 21
        '
        'btnShowTextCancel
        '
        Me.btnShowTextCancel.Location = New System.Drawing.Point(250, 388)
        Me.btnShowTextCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowTextCancel.Name = "btnShowTextCancel"
        Me.btnShowTextCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnShowTextCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnShowTextCancel.TabIndex = 24
        Me.btnShowTextCancel.Text = "Cancelar"
        '
        'btnShowTextOk
        '
        Me.btnShowTextOk.Location = New System.Drawing.Point(129, 388)
        Me.btnShowTextOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowTextOk.Name = "btnShowTextOk"
        Me.btnShowTextOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnShowTextOk.Size = New System.Drawing.Size(112, 35)
        Me.btnShowTextOk.TabIndex = 25
        Me.btnShowTextOk.Text = "Confirmar"
        '
        'picShowTextFace
        '
        Me.picShowTextFace.BackColor = System.Drawing.Color.Black
        Me.picShowTextFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShowTextFace.Location = New System.Drawing.Point(10, 229)
        Me.picShowTextFace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picShowTextFace.Name = "picShowTextFace"
        Me.picShowTextFace.Size = New System.Drawing.Size(150, 143)
        Me.picShowTextFace.TabIndex = 2
        Me.picShowTextFace.TabStop = False
        '
        'DarkLabel26
        '
        Me.DarkLabel26.AutoSize = True
        Me.DarkLabel26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel26.Location = New System.Drawing.Point(165, 345)
        Me.DarkLabel26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel26.Name = "DarkLabel26"
        Me.DarkLabel26.Size = New System.Drawing.Size(49, 20)
        Me.DarkLabel26.TabIndex = 22
        Me.DarkLabel26.Text = "Face:"
        '
        'nudShowTextFace
        '
        Me.nudShowTextFace.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudShowTextFace.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudShowTextFace.Location = New System.Drawing.Point(220, 342)
        Me.nudShowTextFace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudShowTextFace.Name = "nudShowTextFace"
        Me.nudShowTextFace.Size = New System.Drawing.Size(138, 26)
        Me.nudShowTextFace.TabIndex = 23
        Me.nudShowTextFace.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'fraAddText
        '
        Me.fraAddText.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraAddText.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraAddText.Controls.Add(Me.btnAddTextOk)
        Me.fraAddText.Controls.Add(Me.btnAddTextCancel)
        Me.fraAddText.Controls.Add(Me.optAddText_Global)
        Me.fraAddText.Controls.Add(Me.optAddText_Map)
        Me.fraAddText.Controls.Add(Me.optAddText_Player)
        Me.fraAddText.Controls.Add(Me.DarkLabel25)
        Me.fraAddText.Controls.Add(Me.txtAddText_Text)
        Me.fraAddText.Controls.Add(Me.DarkLabel24)
        Me.fraAddText.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraAddText.Location = New System.Drawing.Point(9, 558)
        Me.fraAddText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraAddText.Name = "fraAddText"
        Me.fraAddText.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraAddText.Size = New System.Drawing.Size(350, 288)
        Me.fraAddText.TabIndex = 3
        Me.fraAddText.TabStop = False
        Me.fraAddText.Text = "Add Text"
        Me.fraAddText.Visible = False
        '
        'btnAddTextOk
        '
        Me.btnAddTextOk.Location = New System.Drawing.Point(82, 240)
        Me.btnAddTextOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddTextOk.Name = "btnAddTextOk"
        Me.btnAddTextOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnAddTextOk.Size = New System.Drawing.Size(112, 35)
        Me.btnAddTextOk.TabIndex = 9
        Me.btnAddTextOk.Text = "Ok"
        '
        'btnAddTextCancel
        '
        Me.btnAddTextCancel.Location = New System.Drawing.Point(204, 240)
        Me.btnAddTextCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddTextCancel.Name = "btnAddTextCancel"
        Me.btnAddTextCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnAddTextCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnAddTextCancel.TabIndex = 8
        Me.btnAddTextCancel.Text = "Cancel"
        '
        'optAddText_Global
        '
        Me.optAddText_Global.AutoSize = True
        Me.optAddText_Global.Location = New System.Drawing.Point(260, 205)
        Me.optAddText_Global.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optAddText_Global.Name = "optAddText_Global"
        Me.optAddText_Global.Size = New System.Drawing.Size(80, 24)
        Me.optAddText_Global.TabIndex = 5
        Me.optAddText_Global.TabStop = True
        Me.optAddText_Global.Text = "Global"
        '
        'optAddText_Map
        '
        Me.optAddText_Map.AutoSize = True
        Me.optAddText_Map.Location = New System.Drawing.Point(182, 205)
        Me.optAddText_Map.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optAddText_Map.Name = "optAddText_Map"
        Me.optAddText_Map.Size = New System.Drawing.Size(65, 24)
        Me.optAddText_Map.TabIndex = 4
        Me.optAddText_Map.TabStop = True
        Me.optAddText_Map.Text = "Map"
        '
        'optAddText_Player
        '
        Me.optAddText_Player.AutoSize = True
        Me.optAddText_Player.Location = New System.Drawing.Point(92, 205)
        Me.optAddText_Player.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optAddText_Player.Name = "optAddText_Player"
        Me.optAddText_Player.Size = New System.Drawing.Size(77, 24)
        Me.optAddText_Player.TabIndex = 3
        Me.optAddText_Player.TabStop = True
        Me.optAddText_Player.Text = "Player"
        '
        'DarkLabel25
        '
        Me.DarkLabel25.AutoSize = True
        Me.DarkLabel25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel25.Location = New System.Drawing.Point(9, 208)
        Me.DarkLabel25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel25.Name = "DarkLabel25"
        Me.DarkLabel25.Size = New System.Drawing.Size(72, 20)
        Me.DarkLabel25.TabIndex = 2
        Me.DarkLabel25.Text = "Channel:"
        '
        'txtAddText_Text
        '
        Me.txtAddText_Text.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtAddText_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddText_Text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtAddText_Text.Location = New System.Drawing.Point(9, 48)
        Me.txtAddText_Text.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddText_Text.Multiline = True
        Me.txtAddText_Text.Name = "txtAddText_Text"
        Me.txtAddText_Text.Size = New System.Drawing.Size(332, 147)
        Me.txtAddText_Text.TabIndex = 1
        '
        'DarkLabel24
        '
        Me.DarkLabel24.AutoSize = True
        Me.DarkLabel24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel24.Location = New System.Drawing.Point(9, 23)
        Me.DarkLabel24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel24.Name = "DarkLabel24"
        Me.DarkLabel24.Size = New System.Drawing.Size(39, 20)
        Me.DarkLabel24.TabIndex = 0
        Me.DarkLabel24.Text = "Text"
        '
        'fraPlayerSwitch
        '
        Me.fraPlayerSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraPlayerSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraPlayerSwitch.Controls.Add(Me.btnSetPlayerSwitchOk)
        Me.fraPlayerSwitch.Controls.Add(Me.btnSetPlayerswitchCancel)
        Me.fraPlayerSwitch.Controls.Add(Me.cmbPlayerSwitchSet)
        Me.fraPlayerSwitch.Controls.Add(Me.DarkLabel23)
        Me.fraPlayerSwitch.Controls.Add(Me.cmbSwitch)
        Me.fraPlayerSwitch.Controls.Add(Me.DarkLabel22)
        Me.fraPlayerSwitch.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraPlayerSwitch.Location = New System.Drawing.Point(320, 600)
        Me.fraPlayerSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayerSwitch.Name = "fraPlayerSwitch"
        Me.fraPlayerSwitch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayerSwitch.Size = New System.Drawing.Size(273, 154)
        Me.fraPlayerSwitch.TabIndex = 2
        Me.fraPlayerSwitch.TabStop = False
        Me.fraPlayerSwitch.Text = "Change Items"
        Me.fraPlayerSwitch.Visible = False
        '
        'btnSetPlayerSwitchOk
        '
        Me.btnSetPlayerSwitchOk.Location = New System.Drawing.Point(30, 111)
        Me.btnSetPlayerSwitchOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetPlayerSwitchOk.Name = "btnSetPlayerSwitchOk"
        Me.btnSetPlayerSwitchOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetPlayerSwitchOk.Size = New System.Drawing.Size(112, 35)
        Me.btnSetPlayerSwitchOk.TabIndex = 9
        Me.btnSetPlayerSwitchOk.Text = "Confirmar"
        '
        'btnSetPlayerswitchCancel
        '
        Me.btnSetPlayerswitchCancel.Location = New System.Drawing.Point(152, 111)
        Me.btnSetPlayerswitchCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSetPlayerswitchCancel.Name = "btnSetPlayerswitchCancel"
        Me.btnSetPlayerswitchCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSetPlayerswitchCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnSetPlayerswitchCancel.TabIndex = 8
        Me.btnSetPlayerswitchCancel.Text = "Cancelar"
        '
        'cmbPlayerSwitchSet
        '
        Me.cmbPlayerSwitchSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPlayerSwitchSet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPlayerSwitchSet.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPlayerSwitchSet.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPlayerSwitchSet.ButtonIcon = CType(resources.GetObject("cmbPlayerSwitchSet.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPlayerSwitchSet.DrawDropdownHoverOutline = False
        Me.cmbPlayerSwitchSet.DrawFocusRectangle = False
        Me.cmbPlayerSwitchSet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPlayerSwitchSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayerSwitchSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayerSwitchSet.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPlayerSwitchSet.FormattingEnabled = True
        Me.cmbPlayerSwitchSet.Items.AddRange(New Object() {"False", "True"})
        Me.cmbPlayerSwitchSet.Location = New System.Drawing.Point(76, 63)
        Me.cmbPlayerSwitchSet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPlayerSwitchSet.Name = "cmbPlayerSwitchSet"
        Me.cmbPlayerSwitchSet.Size = New System.Drawing.Size(186, 27)
        Me.cmbPlayerSwitchSet.TabIndex = 3
        Me.cmbPlayerSwitchSet.Text = Nothing
        Me.cmbPlayerSwitchSet.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel23
        '
        Me.DarkLabel23.AutoSize = True
        Me.DarkLabel23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel23.Location = New System.Drawing.Point(9, 71)
        Me.DarkLabel23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel23.Name = "DarkLabel23"
        Me.DarkLabel23.Size = New System.Drawing.Size(52, 20)
        Me.DarkLabel23.TabIndex = 2
        Me.DarkLabel23.Text = "Set to"
        '
        'cmbSwitch
        '
        Me.cmbSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbSwitch.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbSwitch.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbSwitch.ButtonIcon = CType(resources.GetObject("cmbSwitch.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbSwitch.DrawDropdownHoverOutline = False
        Me.cmbSwitch.DrawFocusRectangle = False
        Me.cmbSwitch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSwitch.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbSwitch.FormattingEnabled = True
        Me.cmbSwitch.Location = New System.Drawing.Point(76, 20)
        Me.cmbSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSwitch.Name = "cmbSwitch"
        Me.cmbSwitch.Size = New System.Drawing.Size(186, 27)
        Me.cmbSwitch.TabIndex = 1
        Me.cmbSwitch.Text = Nothing
        Me.cmbSwitch.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel22
        '
        Me.DarkLabel22.AutoSize = True
        Me.DarkLabel22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel22.Location = New System.Drawing.Point(9, 25)
        Me.DarkLabel22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel22.Name = "DarkLabel22"
        Me.DarkLabel22.Size = New System.Drawing.Size(56, 20)
        Me.DarkLabel22.TabIndex = 0
        Me.DarkLabel22.Text = "Switch"
        '
        'fraChangeItems
        '
        Me.fraChangeItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraChangeItems.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraChangeItems.Controls.Add(Me.btnChangeItemsOk)
        Me.fraChangeItems.Controls.Add(Me.btnChangeItemsCancel)
        Me.fraChangeItems.Controls.Add(Me.nudChangeItemsAmount)
        Me.fraChangeItems.Controls.Add(Me.optChangeItemRemove)
        Me.fraChangeItems.Controls.Add(Me.optChangeItemAdd)
        Me.fraChangeItems.Controls.Add(Me.optChangeItemSet)
        Me.fraChangeItems.Controls.Add(Me.cmbChangeItemIndex)
        Me.fraChangeItems.Controls.Add(Me.DarkLabel21)
        Me.fraChangeItems.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraChangeItems.Location = New System.Drawing.Point(9, 600)
        Me.fraChangeItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeItems.Name = "fraChangeItems"
        Me.fraChangeItems.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraChangeItems.Size = New System.Drawing.Size(280, 185)
        Me.fraChangeItems.TabIndex = 1
        Me.fraChangeItems.TabStop = False
        Me.fraChangeItems.Text = "Change Items"
        Me.fraChangeItems.Visible = False
        '
        'btnChangeItemsOk
        '
        Me.btnChangeItemsOk.Location = New System.Drawing.Point(38, 140)
        Me.btnChangeItemsOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeItemsOk.Name = "btnChangeItemsOk"
        Me.btnChangeItemsOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeItemsOk.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeItemsOk.TabIndex = 7
        Me.btnChangeItemsOk.Text = "Ok"
        '
        'btnChangeItemsCancel
        '
        Me.btnChangeItemsCancel.Location = New System.Drawing.Point(159, 140)
        Me.btnChangeItemsCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeItemsCancel.Name = "btnChangeItemsCancel"
        Me.btnChangeItemsCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnChangeItemsCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnChangeItemsCancel.TabIndex = 6
        Me.btnChangeItemsCancel.Text = "Cancel"
        '
        'nudChangeItemsAmount
        '
        Me.nudChangeItemsAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudChangeItemsAmount.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudChangeItemsAmount.Location = New System.Drawing.Point(14, 100)
        Me.nudChangeItemsAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudChangeItemsAmount.Name = "nudChangeItemsAmount"
        Me.nudChangeItemsAmount.Size = New System.Drawing.Size(258, 26)
        Me.nudChangeItemsAmount.TabIndex = 5
        Me.nudChangeItemsAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'optChangeItemRemove
        '
        Me.optChangeItemRemove.AutoSize = True
        Me.optChangeItemRemove.Location = New System.Drawing.Point(182, 65)
        Me.optChangeItemRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optChangeItemRemove.Name = "optChangeItemRemove"
        Me.optChangeItemRemove.Size = New System.Drawing.Size(69, 24)
        Me.optChangeItemRemove.TabIndex = 4
        Me.optChangeItemRemove.TabStop = True
        Me.optChangeItemRemove.Text = "Take"
        '
        'optChangeItemAdd
        '
        Me.optChangeItemAdd.AutoSize = True
        Me.optChangeItemAdd.Location = New System.Drawing.Point(102, 65)
        Me.optChangeItemAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optChangeItemAdd.Name = "optChangeItemAdd"
        Me.optChangeItemAdd.Size = New System.Drawing.Size(66, 24)
        Me.optChangeItemAdd.TabIndex = 3
        Me.optChangeItemAdd.TabStop = True
        Me.optChangeItemAdd.Text = "Give"
        '
        'optChangeItemSet
        '
        Me.optChangeItemSet.AutoSize = True
        Me.optChangeItemSet.Location = New System.Drawing.Point(14, 65)
        Me.optChangeItemSet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optChangeItemSet.Name = "optChangeItemSet"
        Me.optChangeItemSet.Size = New System.Drawing.Size(77, 24)
        Me.optChangeItemSet.TabIndex = 2
        Me.optChangeItemSet.TabStop = True
        Me.optChangeItemSet.Text = "Set to"
        '
        'cmbChangeItemIndex
        '
        Me.cmbChangeItemIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbChangeItemIndex.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbChangeItemIndex.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbChangeItemIndex.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbChangeItemIndex.ButtonIcon = CType(resources.GetObject("cmbChangeItemIndex.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbChangeItemIndex.DrawDropdownHoverOutline = False
        Me.cmbChangeItemIndex.DrawFocusRectangle = False
        Me.cmbChangeItemIndex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbChangeItemIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChangeItemIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbChangeItemIndex.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbChangeItemIndex.FormattingEnabled = True
        Me.cmbChangeItemIndex.Location = New System.Drawing.Point(63, 20)
        Me.cmbChangeItemIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbChangeItemIndex.Name = "cmbChangeItemIndex"
        Me.cmbChangeItemIndex.Size = New System.Drawing.Size(206, 27)
        Me.cmbChangeItemIndex.TabIndex = 1
        Me.cmbChangeItemIndex.Text = Nothing
        Me.cmbChangeItemIndex.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel21
        '
        Me.DarkLabel21.AutoSize = True
        Me.DarkLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel21.Location = New System.Drawing.Point(9, 25)
        Me.DarkLabel21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel21.Name = "DarkLabel21"
        Me.DarkLabel21.Size = New System.Drawing.Size(45, 20)
        Me.DarkLabel21.TabIndex = 0
        Me.DarkLabel21.Text = "Item:"
        '
        'fraPlayBGM
        '
        Me.fraPlayBGM.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraPlayBGM.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraPlayBGM.Controls.Add(Me.btnPlayBgmOk)
        Me.fraPlayBGM.Controls.Add(Me.btnPlayBgmCancel)
        Me.fraPlayBGM.Controls.Add(Me.cmbPlayBGM)
        Me.fraPlayBGM.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraPlayBGM.Location = New System.Drawing.Point(602, 2)
        Me.fraPlayBGM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayBGM.Name = "fraPlayBGM"
        Me.fraPlayBGM.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraPlayBGM.Size = New System.Drawing.Size(369, 115)
        Me.fraPlayBGM.TabIndex = 21
        Me.fraPlayBGM.TabStop = False
        Me.fraPlayBGM.Text = "Play BGM"
        Me.fraPlayBGM.Visible = False
        '
        'btnPlayBgmOk
        '
        Me.btnPlayBgmOk.Location = New System.Drawing.Point(69, 71)
        Me.btnPlayBgmOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlayBgmOk.Name = "btnPlayBgmOk"
        Me.btnPlayBgmOk.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlayBgmOk.Size = New System.Drawing.Size(112, 35)
        Me.btnPlayBgmOk.TabIndex = 27
        Me.btnPlayBgmOk.Text = "Ok"
        '
        'btnPlayBgmCancel
        '
        Me.btnPlayBgmCancel.Location = New System.Drawing.Point(190, 71)
        Me.btnPlayBgmCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlayBgmCancel.Name = "btnPlayBgmCancel"
        Me.btnPlayBgmCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnPlayBgmCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnPlayBgmCancel.TabIndex = 26
        Me.btnPlayBgmCancel.Text = "Cancel"
        '
        'cmbPlayBGM
        '
        Me.cmbPlayBGM.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbPlayBGM.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPlayBGM.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPlayBGM.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPlayBGM.ButtonIcon = CType(resources.GetObject("cmbPlayBGM.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPlayBGM.DrawDropdownHoverOutline = False
        Me.cmbPlayBGM.DrawFocusRectangle = False
        Me.cmbPlayBGM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPlayBGM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayBGM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayBGM.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPlayBGM.FormattingEnabled = True
        Me.cmbPlayBGM.Location = New System.Drawing.Point(9, 29)
        Me.cmbPlayBGM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPlayBGM.Name = "cmbPlayBGM"
        Me.cmbPlayBGM.Size = New System.Drawing.Size(348, 27)
        Me.cmbPlayBGM.TabIndex = 0
        Me.cmbPlayBGM.Text = Nothing
        Me.cmbPlayBGM.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'pnlVariableSwitches
        '
        Me.pnlVariableSwitches.Controls.Add(Me.FraRenaming)
        Me.pnlVariableSwitches.Controls.Add(Me.fraLabeling)
        Me.pnlVariableSwitches.Location = New System.Drawing.Point(1200, 309)
        Me.pnlVariableSwitches.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlVariableSwitches.Name = "pnlVariableSwitches"
        Me.pnlVariableSwitches.Size = New System.Drawing.Size(140, 140)
        Me.pnlVariableSwitches.TabIndex = 11
        '
        'FraRenaming
        '
        Me.FraRenaming.Controls.Add(Me.btnRename_Cancel)
        Me.FraRenaming.Controls.Add(Me.btnRename_Ok)
        Me.FraRenaming.Controls.Add(Me.fraRandom10)
        Me.FraRenaming.ForeColor = System.Drawing.Color.Gainsboro
        Me.FraRenaming.Location = New System.Drawing.Point(354, 660)
        Me.FraRenaming.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FraRenaming.Name = "FraRenaming"
        Me.FraRenaming.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FraRenaming.Size = New System.Drawing.Size(546, 220)
        Me.FraRenaming.TabIndex = 8
        Me.FraRenaming.TabStop = False
        Me.FraRenaming.Text = "Renaming Variable/Switch"
        Me.FraRenaming.Visible = False
        '
        'btnRename_Cancel
        '
        Me.btnRename_Cancel.ForeColor = System.Drawing.Color.Black
        Me.btnRename_Cancel.Location = New System.Drawing.Point(344, 157)
        Me.btnRename_Cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRename_Cancel.Name = "btnRename_Cancel"
        Me.btnRename_Cancel.Size = New System.Drawing.Size(112, 35)
        Me.btnRename_Cancel.TabIndex = 2
        Me.btnRename_Cancel.Text = "Cancel"
        Me.btnRename_Cancel.UseVisualStyleBackColor = True
        '
        'btnRename_Ok
        '
        Me.btnRename_Ok.ForeColor = System.Drawing.Color.Black
        Me.btnRename_Ok.Location = New System.Drawing.Point(81, 157)
        Me.btnRename_Ok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRename_Ok.Name = "btnRename_Ok"
        Me.btnRename_Ok.Size = New System.Drawing.Size(112, 35)
        Me.btnRename_Ok.TabIndex = 1
        Me.btnRename_Ok.Text = "Ok"
        Me.btnRename_Ok.UseVisualStyleBackColor = True
        '
        'fraRandom10
        '
        Me.fraRandom10.Controls.Add(Me.txtRename)
        Me.fraRandom10.Controls.Add(Me.lblEditing)
        Me.fraRandom10.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraRandom10.Location = New System.Drawing.Point(9, 29)
        Me.fraRandom10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraRandom10.Name = "fraRandom10"
        Me.fraRandom10.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraRandom10.Size = New System.Drawing.Size(528, 118)
        Me.fraRandom10.TabIndex = 0
        Me.fraRandom10.TabStop = False
        Me.fraRandom10.Text = "Editing Variable/Switch"
        '
        'txtRename
        '
        Me.txtRename.Location = New System.Drawing.Point(9, 63)
        Me.txtRename.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRename.Name = "txtRename"
        Me.txtRename.Size = New System.Drawing.Size(508, 26)
        Me.txtRename.TabIndex = 1
        '
        'lblEditing
        '
        Me.lblEditing.AutoSize = True
        Me.lblEditing.Location = New System.Drawing.Point(4, 38)
        Me.lblEditing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEditing.Name = "lblEditing"
        Me.lblEditing.Size = New System.Drawing.Size(147, 20)
        Me.lblEditing.TabIndex = 0
        Me.lblEditing.Text = "Naming Variable #1"
        '
        'fraLabeling
        '
        Me.fraLabeling.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.fraLabeling.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.fraLabeling.Controls.Add(Me.lstSwitches)
        Me.fraLabeling.Controls.Add(Me.lstVariables)
        Me.fraLabeling.Controls.Add(Me.btnLabel_Cancel)
        Me.fraLabeling.Controls.Add(Me.lblRandomLabel36)
        Me.fraLabeling.Controls.Add(Me.btnRenameVariable)
        Me.fraLabeling.Controls.Add(Me.lblRandomLabel25)
        Me.fraLabeling.Controls.Add(Me.btnRenameSwitch)
        Me.fraLabeling.Controls.Add(Me.btnLabel_Ok)
        Me.fraLabeling.ForeColor = System.Drawing.Color.Gainsboro
        Me.fraLabeling.Location = New System.Drawing.Point(292, 45)
        Me.fraLabeling.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraLabeling.Name = "fraLabeling"
        Me.fraLabeling.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fraLabeling.Size = New System.Drawing.Size(684, 595)
        Me.fraLabeling.TabIndex = 0
        Me.fraLabeling.TabStop = False
        Me.fraLabeling.Text = "Label Variables and  Switches   "
        '
        'lstSwitches
        '
        Me.lstSwitches.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lstSwitches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSwitches.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstSwitches.FormattingEnabled = True
        Me.lstSwitches.ItemHeight = 20
        Me.lstSwitches.Location = New System.Drawing.Point(354, 60)
        Me.lstSwitches.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstSwitches.Name = "lstSwitches"
        Me.lstSwitches.Size = New System.Drawing.Size(306, 442)
        Me.lstSwitches.TabIndex = 7
        '
        'lstVariables
        '
        Me.lstVariables.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lstVariables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstVariables.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstVariables.FormattingEnabled = True
        Me.lstVariables.ItemHeight = 20
        Me.lstVariables.Location = New System.Drawing.Point(21, 60)
        Me.lstVariables.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstVariables.Name = "lstVariables"
        Me.lstVariables.Size = New System.Drawing.Size(306, 442)
        Me.lstVariables.TabIndex = 6
        '
        'btnLabel_Cancel
        '
        Me.btnLabel_Cancel.ForeColor = System.Drawing.Color.Black
        Me.btnLabel_Cancel.Location = New System.Drawing.Point(354, 525)
        Me.btnLabel_Cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLabel_Cancel.Name = "btnLabel_Cancel"
        Me.btnLabel_Cancel.Size = New System.Drawing.Size(112, 35)
        Me.btnLabel_Cancel.TabIndex = 12
        Me.btnLabel_Cancel.Text = "Cancel"
        Me.btnLabel_Cancel.UseVisualStyleBackColor = True
        '
        'lblRandomLabel36
        '
        Me.lblRandomLabel36.AutoSize = True
        Me.lblRandomLabel36.Location = New System.Drawing.Point(440, 35)
        Me.lblRandomLabel36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRandomLabel36.Name = "lblRandomLabel36"
        Me.lblRandomLabel36.Size = New System.Drawing.Size(120, 20)
        Me.lblRandomLabel36.TabIndex = 5
        Me.lblRandomLabel36.Text = "Player Switches"
        '
        'btnRenameVariable
        '
        Me.btnRenameVariable.ForeColor = System.Drawing.Color.Black
        Me.btnRenameVariable.Location = New System.Drawing.Point(21, 525)
        Me.btnRenameVariable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRenameVariable.Name = "btnRenameVariable"
        Me.btnRenameVariable.Size = New System.Drawing.Size(159, 35)
        Me.btnRenameVariable.TabIndex = 9
        Me.btnRenameVariable.Text = "Rename Variable"
        Me.btnRenameVariable.UseVisualStyleBackColor = True
        '
        'lblRandomLabel25
        '
        Me.lblRandomLabel25.AutoSize = True
        Me.lblRandomLabel25.Location = New System.Drawing.Point(120, 32)
        Me.lblRandomLabel25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRandomLabel25.Name = "lblRandomLabel25"
        Me.lblRandomLabel25.Size = New System.Drawing.Size(122, 20)
        Me.lblRandomLabel25.TabIndex = 4
        Me.lblRandomLabel25.Text = "Player Variables"
        '
        'btnRenameSwitch
        '
        Me.btnRenameSwitch.ForeColor = System.Drawing.Color.Black
        Me.btnRenameSwitch.Location = New System.Drawing.Point(498, 525)
        Me.btnRenameSwitch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRenameSwitch.Name = "btnRenameSwitch"
        Me.btnRenameSwitch.Size = New System.Drawing.Size(164, 35)
        Me.btnRenameSwitch.TabIndex = 10
        Me.btnRenameSwitch.Text = "Rename Switch"
        Me.btnRenameSwitch.UseVisualStyleBackColor = True
        '
        'btnLabel_Ok
        '
        Me.btnLabel_Ok.ForeColor = System.Drawing.Color.Black
        Me.btnLabel_Ok.Location = New System.Drawing.Point(216, 525)
        Me.btnLabel_Ok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLabel_Ok.Name = "btnLabel_Ok"
        Me.btnLabel_Ok.Size = New System.Drawing.Size(112, 35)
        Me.btnLabel_Ok.TabIndex = 11
        Me.btnLabel_Ok.Text = "Ok"
        Me.btnLabel_Ok.UseVisualStyleBackColor = True
        '
        'FrmEditor_Events
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 945)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraGraphic)
        Me.Controls.Add(Me.pnlVariableSwitches)
        Me.Controls.Add(Me.fraDialogue)
        Me.Controls.Add(Me.fraMoveRoute)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLabeling)
        Me.Controls.Add(Me.DarkGroupBox6)
        Me.Controls.Add(Me.pnlTabPage)
        Me.Controls.Add(Me.tabPages)
        Me.Controls.Add(Me.fraPageSetUp)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmEditor_Events"
        Me.Text = "Editor de Eventos"
        Me.fraPageSetUp.ResumeLayout(False)
        Me.fraPageSetUp.PerformLayout()
        Me.tabPages.ResumeLayout(False)
        Me.pnlTabPage.ResumeLayout(False)
        Me.fraCommands.ResumeLayout(False)
        Me.DarkGroupBox8.ResumeLayout(False)
        Me.DarkGroupBox7.ResumeLayout(False)
        Me.DarkGroupBox7.PerformLayout()
        Me.DarkGroupBox5.ResumeLayout(False)
        Me.DarkGroupBox4.ResumeLayout(False)
        Me.DarkGroupBox3.ResumeLayout(False)
        Me.DarkGroupBox3.PerformLayout()
        Me.DarkGroupBox2.ResumeLayout(False)
        CType(Me.picGraphic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DarkGroupBox1.ResumeLayout(False)
        Me.DarkGroupBox1.PerformLayout()
        CType(Me.nudPlayerVariable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DarkGroupBox6.ResumeLayout(False)
        Me.DarkGroupBox6.PerformLayout()
        Me.fraMoveRoute.ResumeLayout(False)
        Me.fraMoveRoute.PerformLayout()
        Me.DarkGroupBox10.ResumeLayout(False)
        Me.fraGraphic.ResumeLayout(False)
        Me.fraGraphic.PerformLayout()
        Me.pnlGraphicSel.ResumeLayout(False)
        CType(Me.picGraphicSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGraphic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDialogue.ResumeLayout(False)
        Me.fraConditionalBranch.ResumeLayout(False)
        Me.fraConditionalBranch.PerformLayout()
        Me.fraConditions_Quest.ResumeLayout(False)
        Me.fraConditions_Quest.PerformLayout()
        CType(Me.nudCondition_QuestTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCondition_Quest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCondition_LevelAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCondition_HasItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCondition_PlayerVarCondition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraPlayAnimation.ResumeLayout(False)
        Me.fraPlayAnimation.PerformLayout()
        CType(Me.nudPlayAnimTileY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlayAnimTileX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraMoveRouteWait.ResumeLayout(False)
        Me.fraMoveRouteWait.PerformLayout()
        Me.fraCustomScript.ResumeLayout(False)
        Me.fraCustomScript.PerformLayout()
        CType(Me.nudCustomScript, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraSetWeather.ResumeLayout(False)
        Me.fraSetWeather.PerformLayout()
        CType(Me.nudWeatherIntensity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraSpawnNpc.ResumeLayout(False)
        Me.fraGiveExp.ResumeLayout(False)
        Me.fraGiveExp.PerformLayout()
        CType(Me.nudGiveExp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraEndQuest.ResumeLayout(False)
        Me.fraSetAccess.ResumeLayout(False)
        Me.fraSetWait.ResumeLayout(False)
        Me.fraSetWait.PerformLayout()
        CType(Me.nudWaitAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraShowPic.ResumeLayout(False)
        Me.fraShowPic.PerformLayout()
        CType(Me.nudPicOffsetY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPicOffsetX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShowPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShowPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraOpenShop.ResumeLayout(False)
        Me.fraChangeLevel.ResumeLayout(False)
        Me.fraChangeLevel.PerformLayout()
        CType(Me.nudChangeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraChangeGender.ResumeLayout(False)
        Me.fraChangeGender.PerformLayout()
        Me.fraGoToLabel.ResumeLayout(False)
        Me.fraGoToLabel.PerformLayout()
        Me.fraHidePic.ResumeLayout(False)
        Me.fraHidePic.PerformLayout()
        CType(Me.nudHidePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraBeginQuest.ResumeLayout(False)
        Me.fraBeginQuest.PerformLayout()
        Me.fraShowChoices.ResumeLayout(False)
        Me.fraShowChoices.PerformLayout()
        CType(Me.picShowChoicesFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShowChoicesFace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraPlayerVariable.ResumeLayout(False)
        Me.fraPlayerVariable.PerformLayout()
        CType(Me.nudVariableData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVariableData4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVariableData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVariableData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVariableData0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraChangeSprite.ResumeLayout(False)
        Me.fraChangeSprite.PerformLayout()
        CType(Me.nudChangeSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChangeSprite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraSetSelfSwitch.ResumeLayout(False)
        Me.fraSetSelfSwitch.PerformLayout()
        Me.fraMapTint.ResumeLayout(False)
        Me.fraMapTint.PerformLayout()
        CType(Me.nudMapTintData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMapTintData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMapTintData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMapTintData0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraShowChatBubble.ResumeLayout(False)
        Me.fraShowChatBubble.PerformLayout()
        Me.fraPlaySound.ResumeLayout(False)
        Me.fraChangePK.ResumeLayout(False)
        Me.fraCreateLabel.ResumeLayout(False)
        Me.fraCreateLabel.PerformLayout()
        Me.fraChangeClass.ResumeLayout(False)
        Me.fraChangeClass.PerformLayout()
        Me.fraChangeSkills.ResumeLayout(False)
        Me.fraChangeSkills.PerformLayout()
        Me.fraCompleteTask.ResumeLayout(False)
        Me.fraCompleteTask.PerformLayout()
        CType(Me.nudCompleteQuestTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraPlayerWarp.ResumeLayout(False)
        Me.fraPlayerWarp.PerformLayout()
        CType(Me.nudWPY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWPX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWPMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraSetFog.ResumeLayout(False)
        Me.fraSetFog.PerformLayout()
        CType(Me.nudFogData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFogData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFogData0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraShowText.ResumeLayout(False)
        Me.fraShowText.PerformLayout()
        CType(Me.picShowTextFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShowTextFace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraAddText.ResumeLayout(False)
        Me.fraAddText.PerformLayout()
        Me.fraPlayerSwitch.ResumeLayout(False)
        Me.fraPlayerSwitch.PerformLayout()
        Me.fraChangeItems.ResumeLayout(False)
        Me.fraChangeItems.PerformLayout()
        CType(Me.nudChangeItemsAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraPlayBGM.ResumeLayout(False)
        Me.pnlVariableSwitches.ResumeLayout(False)
        Me.FraRenaming.ResumeLayout(False)
        Me.fraRandom10.ResumeLayout(False)
        Me.fraRandom10.PerformLayout()
        Me.fraLabeling.ResumeLayout(False)
        Me.fraLabeling.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvCommands As TreeView
    Friend WithEvents fraPageSetUp As DarkUI.Controls.DarkGroupBox
    Friend WithEvents tabPages As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtName As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnNewPage As DarkUI.Controls.DarkButton
    Friend WithEvents btnCopyPage As DarkUI.Controls.DarkButton
    Friend WithEvents btnPastePage As DarkUI.Controls.DarkButton
    Friend WithEvents btnClearPage As DarkUI.Controls.DarkButton
    Friend WithEvents btnDeletePage As DarkUI.Controls.DarkButton
    Friend WithEvents pnlTabPage As Panel
    Friend WithEvents DarkGroupBox1 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents chkPlayerVar As DarkUI.Controls.DarkCheckBox
    Friend WithEvents cmbPlayerVar As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbPlayervarCompare As DarkUI.Controls.DarkComboBox
    Friend WithEvents nudPlayerVariable As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents chkPlayerSwitch As DarkUI.Controls.DarkCheckBox
    Friend WithEvents cmbPlayerSwitch As DarkUI.Controls.DarkComboBox
    Friend WithEvents cmbPlayerSwitchCompare As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbHasItem As DarkUI.Controls.DarkComboBox
    Friend WithEvents chkHasItem As DarkUI.Controls.DarkCheckBox
    Friend WithEvents cmbSelfSwitch As DarkUI.Controls.DarkComboBox
    Friend WithEvents chkSelfSwitch As DarkUI.Controls.DarkCheckBox
    Friend WithEvents cmbSelfSwitchCompare As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel4 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkGroupBox2 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents picGraphic As PictureBox
    Friend WithEvents DarkGroupBox3 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents chkGlobal As DarkUI.Controls.DarkCheckBox
    Friend WithEvents DarkLabel5 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbMoveType As DarkUI.Controls.DarkComboBox
    Friend WithEvents btnMoveRoute As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel6 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbMoveSpeed As DarkUI.Controls.DarkComboBox
    Friend WithEvents cmbMoveFreq As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel7 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkGroupBox4 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbPositioning As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkGroupBox5 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbTrigger As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkGroupBox6 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents chkWalkAnim As DarkUI.Controls.DarkCheckBox
    Friend WithEvents chkDirFix As DarkUI.Controls.DarkCheckBox
    Friend WithEvents chkWalkThrough As DarkUI.Controls.DarkCheckBox
    Friend WithEvents chkShowName As DarkUI.Controls.DarkCheckBox
    Friend WithEvents DarkGroupBox7 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbEventQuest As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel8 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel10 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel9 As DarkUI.Controls.DarkLabel
    Friend WithEvents lstCommands As ListBox
    Friend WithEvents DarkGroupBox8 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnAddCommand As DarkUI.Controls.DarkButton
    Friend WithEvents btnDeleteCommand As DarkUI.Controls.DarkButton
    Friend WithEvents btnEditCommand As DarkUI.Controls.DarkButton
    Friend WithEvents btnClearCommand As DarkUI.Controls.DarkButton
    Friend WithEvents fraCommands As Panel
    Friend WithEvents btnLabeling As DarkUI.Controls.DarkButton
    Friend WithEvents btnCancel As DarkUI.Controls.DarkButton
    Friend WithEvents btnOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnCancelCommand As DarkUI.Controls.DarkButton
    Friend WithEvents fraMoveRoute As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbEvent As DarkUI.Controls.DarkComboBox
    Friend WithEvents lstMoveRoute As ListBox
    Friend WithEvents DarkGroupBox10 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstvwMoveRoute As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents chkRepeatRoute As DarkUI.Controls.DarkCheckBox
    Friend WithEvents chkIgnoreMove As DarkUI.Controls.DarkCheckBox
    Friend WithEvents btnMoveRouteOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnMoveRouteCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraGraphic As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkLabel11 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbGraphic As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel12 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudGraphic As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel13 As DarkUI.Controls.DarkLabel
    Friend WithEvents picGraphicSel As PictureBox
    Friend WithEvents btnGraphicOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnGraphicCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraDialogue As DarkUI.Controls.DarkGroupBox
    Friend WithEvents fraConditionalBranch As DarkUI.Controls.DarkGroupBox
    Friend WithEvents optCondition0 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents cmbCondition_PlayerVarIndex As DarkUI.Controls.DarkComboBox
    Friend WithEvents nudCondition_PlayerVarCondition As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents cmbCondition_PlayerVarCompare As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel14 As DarkUI.Controls.DarkLabel
    Friend WithEvents optCondition1 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents DarkLabel15 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbCondtion_PlayerSwitchCondition As DarkUI.Controls.DarkComboBox
    Friend WithEvents cmbCondition_PlayerSwitch As DarkUI.Controls.DarkComboBox
    Friend WithEvents optCondition2 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents nudCondition_HasItem As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel16 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbCondition_HasItem As DarkUI.Controls.DarkComboBox
    Friend WithEvents optCondition3 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents cmbCondition_ClassIs As DarkUI.Controls.DarkComboBox
    Friend WithEvents optCondition4 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents cmbCondition_LearntSkill As DarkUI.Controls.DarkComboBox
    Friend WithEvents optCondition5 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents cmbCondition_LevelCompare As DarkUI.Controls.DarkComboBox
    Friend WithEvents nudCondition_LevelAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents optCondition6 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents cmbCondition_SelfSwitchCondition As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel17 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbCondition_SelfSwitch As DarkUI.Controls.DarkComboBox
    Friend WithEvents optCondition7 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents nudCondition_Quest As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel18 As DarkUI.Controls.DarkLabel
    Friend WithEvents fraConditions_Quest As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkLabel19 As DarkUI.Controls.DarkLabel
    Friend WithEvents optCondition_Quest1 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optCondition_Quest0 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents cmbCondition_General As DarkUI.Controls.DarkComboBox
    Friend WithEvents nudCondition_QuestTask As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel20 As DarkUI.Controls.DarkLabel
    Friend WithEvents optCondition8 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents cmbCondition_Gender As DarkUI.Controls.DarkComboBox
    Friend WithEvents btnConditionalBranchOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnConditionalBranchCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraChangeItems As DarkUI.Controls.DarkGroupBox
    Friend WithEvents fraPlayerSwitch As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbChangeItemIndex As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel21 As DarkUI.Controls.DarkLabel
    Friend WithEvents optChangeItemSet As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optChangeItemRemove As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optChangeItemAdd As DarkUI.Controls.DarkRadioButton
    Friend WithEvents nudChangeItemsAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents btnChangeItemsOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnChangeItemsCancel As DarkUI.Controls.DarkButton
    Friend WithEvents cmbSwitch As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel22 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel23 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbPlayerSwitchSet As DarkUI.Controls.DarkComboBox
    Friend WithEvents btnSetPlayerSwitchOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnSetPlayerswitchCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraAddText As DarkUI.Controls.DarkGroupBox
    Friend WithEvents txtAddText_Text As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel24 As DarkUI.Controls.DarkLabel
    Friend WithEvents optAddText_Player As DarkUI.Controls.DarkRadioButton
    Friend WithEvents DarkLabel25 As DarkUI.Controls.DarkLabel
    Friend WithEvents optAddText_Map As DarkUI.Controls.DarkRadioButton
    Friend WithEvents btnAddTextOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnAddTextCancel As DarkUI.Controls.DarkButton
    Friend WithEvents optAddText_Global As DarkUI.Controls.DarkRadioButton
    Friend WithEvents btnShowTextOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnShowTextCancel As DarkUI.Controls.DarkButton
    Friend WithEvents nudShowTextFace As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel26 As DarkUI.Controls.DarkLabel
    Friend WithEvents txtShowText As DarkUI.Controls.DarkTextBox
    Friend WithEvents picShowTextFace As PictureBox
    Friend WithEvents DarkLabel27 As DarkUI.Controls.DarkLabel
    Friend WithEvents fraShowText As DarkUI.Controls.DarkGroupBox
    Friend WithEvents fraSetFog As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnSetFogOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnSetFogCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel30 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel29 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel28 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudFogData2 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudFogData1 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudFogData0 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents fraPlayerWarp As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnPlayerWarpOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnPlayerWarpCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel31 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbWarpPlayerDir As DarkUI.Controls.DarkComboBox
    Friend WithEvents nudWPY As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel32 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudWPX As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel33 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudWPMap As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel34 As DarkUI.Controls.DarkLabel
    Friend WithEvents fraCompleteTask As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnCompleteQuestTaskOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnCompleteQuestTaskCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel35 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel36 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudCompleteQuestTask As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents cmbCompleteQuest As DarkUI.Controls.DarkComboBox
    Friend WithEvents fraPlayBGM As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbPlayBGM As DarkUI.Controls.DarkComboBox
    Friend WithEvents btnPlayBgmOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnPlayBgmCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraChangeSkills As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbChangeSkills As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel37 As DarkUI.Controls.DarkLabel
    Friend WithEvents optChangeSkillsAdd As DarkUI.Controls.DarkRadioButton
    Friend WithEvents btnChangeSkillsOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnChangeSkillsCancel As DarkUI.Controls.DarkButton
    Friend WithEvents optChangeSkillsRemove As DarkUI.Controls.DarkRadioButton
    Friend WithEvents fraChangeClass As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbChangeClass As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel38 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnChangeClassOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnChangeClassCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraCreateLabel As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lblLabelName As DarkUI.Controls.DarkLabel
    Friend WithEvents txtLabelName As DarkUI.Controls.DarkTextBox
    Friend WithEvents btnCreatelabelOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnCreatelabelCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraChangePK As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnChangePkOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnChangePkCancel As DarkUI.Controls.DarkButton
    Friend WithEvents cmbSetPK As DarkUI.Controls.DarkComboBox
    Friend WithEvents fraPlaySound As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnPlaySoundOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnPlaySoundCancel As DarkUI.Controls.DarkButton
    Friend WithEvents cmbPlaySound As DarkUI.Controls.DarkComboBox
    Friend WithEvents fraShowChatBubble As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkLabel39 As DarkUI.Controls.DarkLabel
    Friend WithEvents txtChatbubbleText As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel40 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbChatBubbleTarget As DarkUI.Controls.DarkComboBox
    Friend WithEvents cmbChatBubbleTargetType As DarkUI.Controls.DarkComboBox
    Friend WithEvents btnShowChatBubbleOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnShowChatBubbleCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel41 As DarkUI.Controls.DarkLabel
    Friend WithEvents fraMapTint As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnMapTintOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnMapTintCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel42 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudMapTintData3 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudMapTintData2 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel43 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel44 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudMapTintData1 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudMapTintData0 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel45 As DarkUI.Controls.DarkLabel
    Friend WithEvents fraSetSelfSwitch As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbSetSelfSwitch As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel46 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnSelfswitchOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnSelfswitchCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel47 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbSetSelfSwitchTo As DarkUI.Controls.DarkComboBox
    Friend WithEvents fraChangeSprite As DarkUI.Controls.DarkGroupBox
    Friend WithEvents picChangeSprite As PictureBox
    Friend WithEvents btnChangeSpriteOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnChangeSpriteCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel48 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudChangeSprite As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents fraPlayerVariable As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbVariable As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel49 As DarkUI.Controls.DarkLabel
    Friend WithEvents optVariableAction0 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optVariableAction1 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents nudVariableData1 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudVariableData0 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents optVariableAction3 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents nudVariableData3 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents optVariableAction2 As DarkUI.Controls.DarkRadioButton
    Friend WithEvents btnPlayerVarOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnPlayerVarCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel51 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel50 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudVariableData4 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudVariableData2 As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents fraShowChoices As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkLabel52 As DarkUI.Controls.DarkLabel
    Friend WithEvents txtChoicePrompt As DarkUI.Controls.DarkTextBox
    Friend WithEvents btnShowChoicesOk As DarkUI.Controls.DarkButton
    Friend WithEvents picShowChoicesFace As PictureBox
    Friend WithEvents btnShowChoicesCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel53 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudShowChoicesFace As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel56 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel57 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel55 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel54 As DarkUI.Controls.DarkLabel
    Friend WithEvents txtChoices4 As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtChoices3 As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtChoices2 As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtChoices1 As DarkUI.Controls.DarkTextBox
    Friend WithEvents fraBeginQuest As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbBeginQuest As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel58 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnBeginQuestOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnBeginQuestCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraHidePic As DarkUI.Controls.DarkGroupBox
    Friend WithEvents nudHidePic As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel59 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnHidePicOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnHidePicCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraGoToLabel As DarkUI.Controls.DarkGroupBox
    Friend WithEvents txtGotoLabel As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel60 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnGoToLabelOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnGoToLabelCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraPlayAnimation As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkLabel61 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbPlayAnim As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel62 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbAnimTargetType As DarkUI.Controls.DarkComboBox
    Friend WithEvents nudPlayAnimTileY As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudPlayAnimTileX As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents cmbPlayAnimEvent As DarkUI.Controls.DarkComboBox
    Friend WithEvents btnPlayAnimationOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnPlayAnimationCancel As DarkUI.Controls.DarkButton
    Friend WithEvents lblPlayAnimY As DarkUI.Controls.DarkLabel
    Friend WithEvents lblPlayAnimX As DarkUI.Controls.DarkLabel
    Friend WithEvents fraChangeGender As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnChangeGenderOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnChangeGenderCancel As DarkUI.Controls.DarkButton
    Friend WithEvents optChangeSexFemale As DarkUI.Controls.DarkRadioButton
    Friend WithEvents optChangeSexMale As DarkUI.Controls.DarkRadioButton
    Friend WithEvents fraChangeLevel As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnChangeLevelOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnChangeLevelCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel65 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudChangeLevel As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents fraOpenShop As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbOpenShop As DarkUI.Controls.DarkComboBox
    Friend WithEvents btnOpenShopOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnOpenShopCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraShowPic As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbPicIndex As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel66 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel67 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel68 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudPicOffsetY As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents nudPicOffsetX As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel69 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbPicLoc As DarkUI.Controls.DarkComboBox
    Friend WithEvents nudShowPicture As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents picShowPic As PictureBox
    Friend WithEvents btnShowPicOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnShowPicCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel71 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel70 As DarkUI.Controls.DarkLabel
    Friend WithEvents fraSetWait As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnSetWaitOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnSetWaitCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel74 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel72 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel73 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudWaitAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents fraSetAccess As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnSetAccessOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnSetAccessCancel As DarkUI.Controls.DarkButton
    Friend WithEvents cmbSetAccess As DarkUI.Controls.DarkComboBox
    Friend WithEvents fraEndQuest As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnEndQuestOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnEndQuestCancel As DarkUI.Controls.DarkButton
    Friend WithEvents cmbEndQuest As DarkUI.Controls.DarkComboBox
    Friend WithEvents fraSetWeather As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkLabel75 As DarkUI.Controls.DarkLabel
    Friend WithEvents CmbWeather As DarkUI.Controls.DarkComboBox
    Friend WithEvents btnSetWeatherOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnSetWeatherCancel As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel76 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudWeatherIntensity As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents fraGiveExp As DarkUI.Controls.DarkGroupBox
    Friend WithEvents DarkLabel77 As DarkUI.Controls.DarkLabel
    Friend WithEvents fraSpawnNpc As DarkUI.Controls.DarkGroupBox
    Friend WithEvents cmbSpawnNpc As DarkUI.Controls.DarkComboBox
    Friend WithEvents btnGiveExpOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnGiveExpCancel As DarkUI.Controls.DarkButton
    Friend WithEvents nudGiveExp As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents btnSpawnNpcOk As DarkUI.Controls.DarkButton
    Friend WithEvents btnSpawnNpcCancel As DarkUI.Controls.DarkButton
    Friend WithEvents fraCustomScript As DarkUI.Controls.DarkGroupBox
    Friend WithEvents nudCustomScript As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel78 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnCustomScriptCancel As DarkUI.Controls.DarkButton
    Friend WithEvents btnCustomScriptOk As DarkUI.Controls.DarkButton
    Friend WithEvents fraMoveRouteWait As DarkUI.Controls.DarkGroupBox
    Friend WithEvents btnMoveWaitCancel As DarkUI.Controls.DarkButton
    Friend WithEvents btnMoveWaitOk As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel79 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbMoveWait As DarkUI.Controls.DarkComboBox
    Friend WithEvents pnlVariableSwitches As Panel
    Friend WithEvents fraLabeling As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstSwitches As ListBox
    Friend WithEvents lstVariables As ListBox
    Friend WithEvents lblRandomLabel36 As Label
    Friend WithEvents lblRandomLabel25 As Label
    Friend WithEvents FraRenaming As GroupBox
    Friend WithEvents btnRename_Cancel As Button
    Friend WithEvents btnRename_Ok As Button
    Friend WithEvents fraRandom10 As GroupBox
    Friend WithEvents txtRename As TextBox
    Friend WithEvents lblEditing As Label
    Friend WithEvents btnLabel_Cancel As Button
    Friend WithEvents btnRenameVariable As Button
    Friend WithEvents btnRenameSwitch As Button
    Friend WithEvents btnLabel_Ok As Button
    Friend WithEvents pnlGraphicSel As Panel
    Friend WithEvents cmbCondition_Time As DarkUI.Controls.DarkComboBox
    Friend WithEvents optCondition9 As DarkUI.Controls.DarkRadioButton
End Class
