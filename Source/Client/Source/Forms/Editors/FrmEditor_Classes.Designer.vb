<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor_Classes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditor_Classes))
        Me.DarkGroupBox1 = New GroupBox()
        Me.lstIndex = New System.Windows.Forms.ListBox()
        Me.DarkGroupBox2 = New GroupBox()
        Me.DarkGroupBox7 = New GroupBox()
        Me.nudStartY = New NumericUpDown()
        Me.DarkLabel15 = New Label()
        Me.nudStartX = New NumericUpDown()
        Me.DarkLabel14 = New Label()
        Me.nudStartMap = New NumericUpDown()
        Me.DarkLabel13 = New Label()
        Me.DarkGroupBox6 = New GroupBox()
        Me.btnItemAdd = New Button()
        Me.nudItemAmount = New NumericUpDown()
        Me.DarkLabel12 = New Label()
        Me.cmbItems = New ComboBox()
        Me.DarkLabel11 = New Label()
        Me.lstStartItems = New System.Windows.Forms.ListBox()
        Me.DarkGroupBox5 = New GroupBox()
        Me.nudBaseExp = New NumericUpDown()
        Me.DarkLabel10 = New Label()
        Me.nudSpirit = New NumericUpDown()
        Me.nudEndurance = New NumericUpDown()
        Me.DarkLabel8 = New Label()
        Me.DarkLabel9 = New Label()
        Me.nudVitality = New NumericUpDown()
        Me.nudLuck = New NumericUpDown()
        Me.DarkLabel6 = New Label()
        Me.DarkLabel7 = New Label()
        Me.nudIntelligence = New NumericUpDown()
        Me.nudStrength = New NumericUpDown()
        Me.DarkLabel5 = New Label()
        Me.DarkLabel3 = New Label()
        Me.DarkGroupBox4 = New GroupBox()
        Me.nudFemaleSprite = New NumericUpDown()
        Me.DarkLabel4 = New Label()
        Me.btnDeleteFemaleSprite = New Button()
        Me.btnAddFemaleSprite = New Button()
        Me.cmbFemaleSprite = New ComboBox()
        Me.picFemale = New System.Windows.Forms.PictureBox()
        Me.DarkGroupBox3 = New GroupBox()
        Me.nudMaleSprite = New NumericUpDown()
        Me.lblMaleSprite = New Label()
        Me.btnDeleteMaleSprite = New Button()
        Me.btnAddMaleSprite = New Button()
        Me.cmbMaleSprite = New ComboBox()
        Me.picMale = New System.Windows.Forms.PictureBox()
        Me.txtDescription = New TextBox()
        Me.DarkLabel2 = New Label()
        Me.txtName = New TextBox()
        Me.DarkLabel1 = New Label()
        Me.btnAddClass = New Button()
        Me.btnRemoveClass = New Button()
        Me.btnCancel = New Button()
        Me.btnSave = New Button()
        Me.DarkGroupBox1.SuspendLayout()
        Me.DarkGroupBox2.SuspendLayout()
        Me.DarkGroupBox7.SuspendLayout()
        CType(Me.nudStartY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DarkGroupBox6.SuspendLayout()
        CType(Me.nudItemAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DarkGroupBox5.SuspendLayout()
        CType(Me.nudBaseExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpirit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEndurance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVitality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLuck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIntelligence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStrength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DarkGroupBox4.SuspendLayout()
        CType(Me.nudFemaleSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFemale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DarkGroupBox3.SuspendLayout()
        CType(Me.nudMaleSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DarkGroupBox1
        '
        Me.DarkGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        'Me.DarkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox1.Controls.Add(Me.lstIndex)
        Me.DarkGroupBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.DarkGroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox1.Name = "DarkGroupBox1"
        Me.DarkGroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox1.Size = New System.Drawing.Size(260, 478)
        Me.DarkGroupBox1.TabIndex = 0
        Me.DarkGroupBox1.TabStop = False
        Me.DarkGroupBox1.Text = "Lista de Classes"
        '
        'lstIndex
        '
        Me.lstIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lstIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstIndex.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstIndex.FormattingEnabled = True
        Me.lstIndex.ItemHeight = 20
        Me.lstIndex.Location = New System.Drawing.Point(9, 25)
        Me.lstIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstIndex.Name = "lstIndex"
        Me.lstIndex.Size = New System.Drawing.Size(239, 442)
        Me.lstIndex.TabIndex = 0
        '
        'DarkGroupBox2
        '
        Me.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        'Me.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox7)
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox6)
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox5)
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox4)
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox3)
        Me.DarkGroupBox2.Controls.Add(Me.txtDescription)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel2)
        Me.DarkGroupBox2.Controls.Add(Me.txtName)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel1)
        Me.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox2.Location = New System.Drawing.Point(272, 3)
        Me.DarkGroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox2.Name = "DarkGroupBox2"
        Me.DarkGroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox2.Size = New System.Drawing.Size(512, 726)
        Me.DarkGroupBox2.TabIndex = 1
        Me.DarkGroupBox2.TabStop = False
        Me.DarkGroupBox2.Text = "Propriedades"
        '
        'DarkGroupBox7
        '
        Me.DarkGroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        'Me.DarkGroupBox7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox7.Controls.Add(Me.nudStartY)
        Me.DarkGroupBox7.Controls.Add(Me.DarkLabel15)
        Me.DarkGroupBox7.Controls.Add(Me.nudStartX)
        Me.DarkGroupBox7.Controls.Add(Me.DarkLabel14)
        Me.DarkGroupBox7.Controls.Add(Me.nudStartMap)
        Me.DarkGroupBox7.Controls.Add(Me.DarkLabel13)
        Me.DarkGroupBox7.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox7.Location = New System.Drawing.Point(9, 649)
        Me.DarkGroupBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox7.Name = "DarkGroupBox7"
        Me.DarkGroupBox7.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox7.Size = New System.Drawing.Size(492, 66)
        Me.DarkGroupBox7.TabIndex = 8
        Me.DarkGroupBox7.TabStop = False
        Me.DarkGroupBox7.Text = "Ponto de Início"
        '
        'nudStartY
        '
        Me.nudStartY.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudStartY.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudStartY.Location = New System.Drawing.Point(411, 22)
        Me.nudStartY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudStartY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStartY.Name = "nudStartY"
        Me.nudStartY.Size = New System.Drawing.Size(72, 26)
        Me.nudStartY.TabIndex = 5
        Me.nudStartY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel15
        '
        Me.DarkLabel15.AutoSize = True
        Me.DarkLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel15.Location = New System.Drawing.Point(339, 25)
        Me.DarkLabel15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel15.Name = "DarkLabel15"
        Me.DarkLabel15.Size = New System.Drawing.Size(68, 20)
        Me.DarkLabel15.TabIndex = 4
        Me.DarkLabel15.Text = "Y Inicial:"
        '
        'nudStartX
        '
        Me.nudStartX.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudStartX.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudStartX.Location = New System.Drawing.Point(252, 22)
        Me.nudStartX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudStartX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStartX.Name = "nudStartX"
        Me.nudStartX.Size = New System.Drawing.Size(72, 26)
        Me.nudStartX.TabIndex = 3
        Me.nudStartX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel14
        '
        Me.DarkLabel14.AutoSize = True
        Me.DarkLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel14.Location = New System.Drawing.Point(180, 25)
        Me.DarkLabel14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel14.Name = "DarkLabel14"
        Me.DarkLabel14.Size = New System.Drawing.Size(68, 20)
        Me.DarkLabel14.TabIndex = 2
        Me.DarkLabel14.Text = "X Inicial:"
        '
        'nudStartMap
        '
        Me.nudStartMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudStartMap.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudStartMap.Location = New System.Drawing.Point(102, 22)
        Me.nudStartMap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudStartMap.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStartMap.Name = "nudStartMap"
        Me.nudStartMap.Size = New System.Drawing.Size(69, 26)
        Me.nudStartMap.TabIndex = 1
        Me.nudStartMap.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel13
        '
        Me.DarkLabel13.AutoSize = True
        Me.DarkLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel13.Location = New System.Drawing.Point(9, 25)
        Me.DarkLabel13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel13.Name = "DarkLabel13"
        Me.DarkLabel13.Size = New System.Drawing.Size(97, 20)
        Me.DarkLabel13.TabIndex = 0
        Me.DarkLabel13.Text = "Mapa Inicial:"
        '
        'DarkGroupBox6
        '
        Me.DarkGroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        'Me.DarkGroupBox6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox6.Controls.Add(Me.btnItemAdd)
        Me.DarkGroupBox6.Controls.Add(Me.nudItemAmount)
        Me.DarkGroupBox6.Controls.Add(Me.DarkLabel12)
        Me.DarkGroupBox6.Controls.Add(Me.cmbItems)
        Me.DarkGroupBox6.Controls.Add(Me.DarkLabel11)
        Me.DarkGroupBox6.Controls.Add(Me.lstStartItems)
        Me.DarkGroupBox6.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox6.Location = New System.Drawing.Point(9, 477)
        Me.DarkGroupBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox6.Name = "DarkGroupBox6"
        Me.DarkGroupBox6.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox6.Size = New System.Drawing.Size(492, 163)
        Me.DarkGroupBox6.TabIndex = 7
        Me.DarkGroupBox6.TabStop = False
        Me.DarkGroupBox6.Text = "Itens Iniciais"
        '
        'btnItemAdd
        '
        Me.btnItemAdd.Location = New System.Drawing.Point(274, 112)
        Me.btnItemAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnItemAdd.Name = "btnItemAdd"
        Me.btnItemAdd.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnItemAdd.Size = New System.Drawing.Size(208, 40)
        Me.btnItemAdd.TabIndex = 6
        Me.btnItemAdd.Text = "Atualizar Lista"
        '
        'nudItemAmount
        '
        Me.nudItemAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudItemAmount.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudItemAmount.Location = New System.Drawing.Point(352, 77)
        Me.nudItemAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudItemAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudItemAmount.Name = "nudItemAmount"
        Me.nudItemAmount.Size = New System.Drawing.Size(130, 26)
        Me.nudItemAmount.TabIndex = 5
        Me.nudItemAmount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel12
        '
        Me.DarkLabel12.AutoSize = True
        Me.DarkLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel12.Location = New System.Drawing.Point(274, 80)
        Me.DarkLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel12.Name = "DarkLabel12"
        Me.DarkLabel12.Size = New System.Drawing.Size(61, 20)
        Me.DarkLabel12.TabIndex = 4
        Me.DarkLabel12.Text = "Quant.:"
        '
        'cmbItems
        '
        Me.cmbItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        'Me.cmbItems.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        'Me.cmbItems.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        'Me.cmbItems.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        'Me.cmbItems.ButtonIcon = CType(resources.GetObject("cmbItems.ButtonIcon"), System.Drawing.Bitmap)
        'Me.cmbItems.DrawDropdownHoverOutline = False
        'Me.cmbItems.DrawFocusRectangle = False
        Me.cmbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbItems.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbItems.FormattingEnabled = True
        Me.cmbItems.Location = New System.Drawing.Point(274, 35)
        Me.cmbItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbItems.Name = "cmbItems"
        Me.cmbItems.Size = New System.Drawing.Size(206, 27)
        Me.cmbItems.TabIndex = 3
        Me.cmbItems.Text = Nothing
        'Me.cmbItems.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel11
        '
        Me.DarkLabel11.AutoSize = True
        Me.DarkLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel11.Location = New System.Drawing.Point(274, 11)
        Me.DarkLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel11.Name = "DarkLabel11"
        Me.DarkLabel11.Size = New System.Drawing.Size(85, 20)
        Me.DarkLabel11.TabIndex = 2
        Me.DarkLabel11.Text = "Item Inicial"
        '
        'lstStartItems
        '
        Me.lstStartItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lstStartItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstStartItems.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstStartItems.FormattingEnabled = True
        Me.lstStartItems.ItemHeight = 20
        Me.lstStartItems.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.lstStartItems.Location = New System.Drawing.Point(9, 29)
        Me.lstStartItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstStartItems.Name = "lstStartItems"
        Me.lstStartItems.Size = New System.Drawing.Size(256, 122)
        Me.lstStartItems.TabIndex = 1
        '
        'DarkGroupBox5
        '
        Me.DarkGroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        'Me.DarkGroupBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox5.Controls.Add(Me.nudBaseExp)
        Me.DarkGroupBox5.Controls.Add(Me.DarkLabel10)
        Me.DarkGroupBox5.Controls.Add(Me.nudSpirit)
        Me.DarkGroupBox5.Controls.Add(Me.nudEndurance)
        Me.DarkGroupBox5.Controls.Add(Me.DarkLabel8)
        Me.DarkGroupBox5.Controls.Add(Me.DarkLabel9)
        Me.DarkGroupBox5.Controls.Add(Me.nudVitality)
        Me.DarkGroupBox5.Controls.Add(Me.nudLuck)
        Me.DarkGroupBox5.Controls.Add(Me.DarkLabel6)
        Me.DarkGroupBox5.Controls.Add(Me.DarkLabel7)
        Me.DarkGroupBox5.Controls.Add(Me.nudIntelligence)
        Me.DarkGroupBox5.Controls.Add(Me.nudStrength)
        Me.DarkGroupBox5.Controls.Add(Me.DarkLabel5)
        Me.DarkGroupBox5.Controls.Add(Me.DarkLabel3)
        Me.DarkGroupBox5.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox5.Location = New System.Drawing.Point(9, 314)
        Me.DarkGroupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox5.Name = "DarkGroupBox5"
        Me.DarkGroupBox5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox5.Size = New System.Drawing.Size(492, 154)
        Me.DarkGroupBox5.TabIndex = 6
        Me.DarkGroupBox5.TabStop = False
        Me.DarkGroupBox5.Text = "Atributos Iniciais"
        '
        'nudBaseExp
        '
        Me.nudBaseExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudBaseExp.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudBaseExp.Location = New System.Drawing.Point(153, 108)
        Me.nudBaseExp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudBaseExp.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudBaseExp.Name = "nudBaseExp"
        Me.nudBaseExp.Size = New System.Drawing.Size(154, 26)
        Me.nudBaseExp.TabIndex = 13
        Me.nudBaseExp.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'DarkLabel10
        '
        Me.DarkLabel10.AutoSize = True
        Me.DarkLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel10.Location = New System.Drawing.Point(9, 111)
        Me.DarkLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel10.Name = "DarkLabel10"
        Me.DarkLabel10.Size = New System.Drawing.Size(136, 20)
        Me.DarkLabel10.TabIndex = 12
        Me.DarkLabel10.Text = "Experiência Base:"
        '
        'nudSpirit
        '
        Me.nudSpirit.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudSpirit.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudSpirit.Location = New System.Drawing.Point(416, 62)
        Me.nudSpirit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudSpirit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSpirit.Name = "nudSpirit"
        Me.nudSpirit.Size = New System.Drawing.Size(68, 26)
        Me.nudSpirit.TabIndex = 11
        Me.nudSpirit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudEndurance
        '
        Me.nudEndurance.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudEndurance.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudEndurance.Location = New System.Drawing.Point(416, 22)
        Me.nudEndurance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudEndurance.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudEndurance.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEndurance.Name = "nudEndurance"
        Me.nudEndurance.Size = New System.Drawing.Size(68, 26)
        Me.nudEndurance.TabIndex = 10
        Me.nudEndurance.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel8
        '
        Me.DarkLabel8.AutoSize = True
        Me.DarkLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel8.Location = New System.Drawing.Point(316, 65)
        Me.DarkLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel8.Name = "DarkLabel8"
        Me.DarkLabel8.Size = New System.Drawing.Size(66, 20)
        Me.DarkLabel8.TabIndex = 9
        Me.DarkLabel8.Text = "Espírito:"
        '
        'DarkLabel9
        '
        Me.DarkLabel9.AutoSize = True
        Me.DarkLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel9.Location = New System.Drawing.Point(316, 25)
        Me.DarkLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel9.Name = "DarkLabel9"
        Me.DarkLabel9.Size = New System.Drawing.Size(96, 20)
        Me.DarkLabel9.TabIndex = 8
        Me.DarkLabel9.Text = "Resistência:"
        '
        'nudVitality
        '
        Me.nudVitality.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudVitality.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudVitality.Location = New System.Drawing.Point(240, 62)
        Me.nudVitality.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudVitality.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudVitality.Name = "nudVitality"
        Me.nudVitality.Size = New System.Drawing.Size(68, 26)
        Me.nudVitality.TabIndex = 7
        Me.nudVitality.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudLuck
        '
        Me.nudLuck.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudLuck.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudLuck.Location = New System.Drawing.Point(240, 22)
        Me.nudLuck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudLuck.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudLuck.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLuck.Name = "nudLuck"
        Me.nudLuck.Size = New System.Drawing.Size(68, 26)
        Me.nudLuck.TabIndex = 6
        Me.nudLuck.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel6
        '
        Me.DarkLabel6.AutoSize = True
        Me.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel6.Location = New System.Drawing.Point(180, 65)
        Me.DarkLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel6.Name = "DarkLabel6"
        Me.DarkLabel6.Size = New System.Drawing.Size(38, 20)
        Me.DarkLabel6.TabIndex = 5
        Me.DarkLabel6.Text = "VIT:"
        '
        'DarkLabel7
        '
        Me.DarkLabel7.AutoSize = True
        Me.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel7.Location = New System.Drawing.Point(180, 25)
        Me.DarkLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel7.Name = "DarkLabel7"
        Me.DarkLabel7.Size = New System.Drawing.Size(52, 20)
        Me.DarkLabel7.TabIndex = 4
        Me.DarkLabel7.Text = "Sorte:"
        '
        'nudIntelligence
        '
        Me.nudIntelligence.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudIntelligence.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudIntelligence.Location = New System.Drawing.Point(104, 62)
        Me.nudIntelligence.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudIntelligence.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudIntelligence.Name = "nudIntelligence"
        Me.nudIntelligence.Size = New System.Drawing.Size(68, 26)
        Me.nudIntelligence.TabIndex = 3
        Me.nudIntelligence.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudStrength
        '
        Me.nudStrength.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudStrength.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudStrength.Location = New System.Drawing.Point(104, 22)
        Me.nudStrength.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudStrength.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudStrength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStrength.Name = "nudStrength"
        Me.nudStrength.Size = New System.Drawing.Size(68, 26)
        Me.nudStrength.TabIndex = 2
        Me.nudStrength.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel5
        '
        Me.DarkLabel5.AutoSize = True
        Me.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel5.Location = New System.Drawing.Point(9, 65)
        Me.DarkLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel5.Name = "DarkLabel5"
        Me.DarkLabel5.Size = New System.Drawing.Size(94, 20)
        Me.DarkLabel5.TabIndex = 1
        Me.DarkLabel5.Text = "Inteligência:"
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = True
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(9, 25)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(54, 20)
        Me.DarkLabel3.TabIndex = 0
        Me.DarkLabel3.Text = "Força:"
        '
        'DarkGroupBox4
        '
        Me.DarkGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        'Me.DarkGroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox4.Controls.Add(Me.nudFemaleSprite)
        Me.DarkGroupBox4.Controls.Add(Me.DarkLabel4)
        Me.DarkGroupBox4.Controls.Add(Me.btnDeleteFemaleSprite)
        Me.DarkGroupBox4.Controls.Add(Me.btnAddFemaleSprite)
        Me.DarkGroupBox4.Controls.Add(Me.cmbFemaleSprite)
        Me.DarkGroupBox4.Controls.Add(Me.picFemale)
        Me.DarkGroupBox4.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox4.Location = New System.Drawing.Point(260, 134)
        Me.DarkGroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox4.Name = "DarkGroupBox4"
        Me.DarkGroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox4.Size = New System.Drawing.Size(242, 171)
        Me.DarkGroupBox4.TabIndex = 5
        Me.DarkGroupBox4.TabStop = False
        Me.DarkGroupBox4.Text = "Sprite Feminina"
        '
        'nudFemaleSprite
        '
        Me.nudFemaleSprite.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudFemaleSprite.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudFemaleSprite.Location = New System.Drawing.Point(69, 83)
        Me.nudFemaleSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudFemaleSprite.Name = "nudFemaleSprite"
        Me.nudFemaleSprite.Size = New System.Drawing.Size(82, 26)
        Me.nudFemaleSprite.TabIndex = 18
        Me.nudFemaleSprite.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel4
        '
        Me.DarkLabel4.AutoSize = True
        Me.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel4.Location = New System.Drawing.Point(4, 86)
        Me.DarkLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel4.Name = "DarkLabel4"
        Me.DarkLabel4.Size = New System.Drawing.Size(55, 20)
        Me.DarkLabel4.TabIndex = 17
        Me.DarkLabel4.Text = "Sprite:"
        '
        'btnDeleteFemaleSprite
        '
        Me.btnDeleteFemaleSprite.Image = CType(resources.GetObject("btnDeleteFemaleSprite.Image"), System.Drawing.Image)
        Me.btnDeleteFemaleSprite.Location = New System.Drawing.Point(54, 29)
        Me.btnDeleteFemaleSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeleteFemaleSprite.Name = "btnDeleteFemaleSprite"
        Me.btnDeleteFemaleSprite.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnDeleteFemaleSprite.Size = New System.Drawing.Size(36, 37)
        Me.btnDeleteFemaleSprite.TabIndex = 16
        '
        'btnAddFemaleSprite
        '
        Me.btnAddFemaleSprite.Image = CType(resources.GetObject("btnAddFemaleSprite.Image"), System.Drawing.Image)
        Me.btnAddFemaleSprite.Location = New System.Drawing.Point(9, 29)
        Me.btnAddFemaleSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddFemaleSprite.Name = "btnAddFemaleSprite"
        Me.btnAddFemaleSprite.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnAddFemaleSprite.Size = New System.Drawing.Size(36, 37)
        Me.btnAddFemaleSprite.TabIndex = 13
        '
        'cmbFemaleSprite
        '
        Me.cmbFemaleSprite.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        'Me.cmbFemaleSprite.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        'Me.cmbFemaleSprite.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        'Me.cmbFemaleSprite.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        'Me.cmbFemaleSprite.ButtonIcon = CType(resources.GetObject("cmbFemaleSprite.ButtonIcon"), System.Drawing.Bitmap)
        'Me.cmbFemaleSprite.DrawDropdownHoverOutline = False
        'Me.cmbFemaleSprite.DrawFocusRectangle = False
        Me.cmbFemaleSprite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFemaleSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFemaleSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFemaleSprite.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbFemaleSprite.FormattingEnabled = True
        Me.cmbFemaleSprite.Location = New System.Drawing.Point(9, 123)
        Me.cmbFemaleSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbFemaleSprite.Name = "cmbFemaleSprite"
        Me.cmbFemaleSprite.Size = New System.Drawing.Size(222, 27)
        Me.cmbFemaleSprite.TabIndex = 15
        Me.cmbFemaleSprite.Text = Nothing
        'Me.cmbFemaleSprite.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'picFemale
        '
        Me.picFemale.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picFemale.Location = New System.Drawing.Point(160, 15)
        Me.picFemale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picFemale.Name = "picFemale"
        Me.picFemale.Size = New System.Drawing.Size(72, 98)
        Me.picFemale.TabIndex = 14
        Me.picFemale.TabStop = False
        '
        'DarkGroupBox3
        '
        Me.DarkGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        'Me.DarkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox3.Controls.Add(Me.nudMaleSprite)
        Me.DarkGroupBox3.Controls.Add(Me.lblMaleSprite)
        Me.DarkGroupBox3.Controls.Add(Me.btnDeleteMaleSprite)
        Me.DarkGroupBox3.Controls.Add(Me.btnAddMaleSprite)
        Me.DarkGroupBox3.Controls.Add(Me.cmbMaleSprite)
        Me.DarkGroupBox3.Controls.Add(Me.picMale)
        Me.DarkGroupBox3.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox3.Location = New System.Drawing.Point(9, 134)
        Me.DarkGroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox3.Name = "DarkGroupBox3"
        Me.DarkGroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox3.Size = New System.Drawing.Size(242, 171)
        Me.DarkGroupBox3.TabIndex = 4
        Me.DarkGroupBox3.TabStop = False
        Me.DarkGroupBox3.Text = "Sprite Masculina"
        '
        'nudMaleSprite
        '
        Me.nudMaleSprite.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudMaleSprite.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudMaleSprite.Location = New System.Drawing.Point(69, 83)
        Me.nudMaleSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudMaleSprite.Name = "nudMaleSprite"
        Me.nudMaleSprite.Size = New System.Drawing.Size(82, 26)
        Me.nudMaleSprite.TabIndex = 12
        Me.nudMaleSprite.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMaleSprite
        '
        Me.lblMaleSprite.AutoSize = True
        Me.lblMaleSprite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblMaleSprite.Location = New System.Drawing.Point(4, 86)
        Me.lblMaleSprite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaleSprite.Name = "lblMaleSprite"
        Me.lblMaleSprite.Size = New System.Drawing.Size(55, 20)
        Me.lblMaleSprite.TabIndex = 11
        Me.lblMaleSprite.Text = "Sprite:"
        '
        'btnDeleteMaleSprite
        '
        Me.btnDeleteMaleSprite.Image = CType(resources.GetObject("btnDeleteMaleSprite.Image"), System.Drawing.Image)
        Me.btnDeleteMaleSprite.Location = New System.Drawing.Point(54, 29)
        Me.btnDeleteMaleSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeleteMaleSprite.Name = "btnDeleteMaleSprite"
        Me.btnDeleteMaleSprite.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnDeleteMaleSprite.Size = New System.Drawing.Size(36, 37)
        Me.btnDeleteMaleSprite.TabIndex = 10
        '
        'btnAddMaleSprite
        '
        Me.btnAddMaleSprite.Image = CType(resources.GetObject("btnAddMaleSprite.Image"), System.Drawing.Image)
        Me.btnAddMaleSprite.Location = New System.Drawing.Point(9, 29)
        Me.btnAddMaleSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddMaleSprite.Name = "btnAddMaleSprite"
        Me.btnAddMaleSprite.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnAddMaleSprite.Size = New System.Drawing.Size(36, 37)
        Me.btnAddMaleSprite.TabIndex = 6
        '
        'cmbMaleSprite
        '
        Me.cmbMaleSprite.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        'Me.cmbMaleSprite.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        'Me.cmbMaleSprite.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        'Me.cmbMaleSprite.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        'Me.cmbMaleSprite.ButtonIcon = CType(resources.GetObject("cmbMaleSprite.ButtonIcon"), System.Drawing.Bitmap)
        'Me.cmbMaleSprite.DrawDropdownHoverOutline = False
        'Me.cmbMaleSprite.DrawFocusRectangle = False
        Me.cmbMaleSprite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMaleSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaleSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMaleSprite.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbMaleSprite.FormattingEnabled = True
        Me.cmbMaleSprite.Location = New System.Drawing.Point(9, 123)
        Me.cmbMaleSprite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbMaleSprite.Name = "cmbMaleSprite"
        Me.cmbMaleSprite.Size = New System.Drawing.Size(222, 27)
        Me.cmbMaleSprite.TabIndex = 9
        Me.cmbMaleSprite.Text = Nothing
        'Me.cmbMaleSprite.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'picMale
        '
        Me.picMale.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picMale.Location = New System.Drawing.Point(160, 15)
        Me.picMale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picMale.Name = "picMale"
        Me.picMale.Size = New System.Drawing.Size(72, 98)
        Me.picMale.TabIndex = 8
        Me.picMale.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(112, 72)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(388, 51)
        Me.txtDescription.TabIndex = 3
        '
        'DarkLabel2
        '
        Me.DarkLabel2.AutoSize = True
        Me.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel2.Location = New System.Drawing.Point(9, 75)
        Me.DarkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel2.Name = "DarkLabel2"
        Me.DarkLabel2.Size = New System.Drawing.Size(84, 20)
        Me.DarkLabel2.TabIndex = 2
        Me.DarkLabel2.Text = "Descrição:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(75, 22)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(425, 29)
        Me.txtName.TabIndex = 1
        '
        'DarkLabel1
        '
        Me.DarkLabel1.AutoSize = True
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(9, 25)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(55, 20)
        Me.DarkLabel1.TabIndex = 0
        Me.DarkLabel1.Text = "Nome:"
        '
        'btnAddClass
        '
        Me.btnAddClass.Location = New System.Drawing.Point(12, 491)
        Me.btnAddClass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddClass.Name = "btnAddClass"
        Me.btnAddClass.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnAddClass.Size = New System.Drawing.Size(240, 35)
        Me.btnAddClass.TabIndex = 2
        Me.btnAddClass.Text = "Adicionar Classe"
        '
        'btnRemoveClass
        '
        Me.btnRemoveClass.Location = New System.Drawing.Point(12, 535)
        Me.btnRemoveClass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRemoveClass.Name = "btnRemoveClass"
        Me.btnRemoveClass.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnRemoveClass.Size = New System.Drawing.Size(240, 35)
        Me.btnRemoveClass.TabIndex = 3
        Me.btnRemoveClass.Text = "Excluir Classe"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 694)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCancel.Size = New System.Drawing.Size(240, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancelar"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 649)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSave.Size = New System.Drawing.Size(240, 35)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Salvar"
        '
        'frmEditor_Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(849, 775)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRemoveClass)
        Me.Controls.Add(Me.btnAddClass)
        Me.Controls.Add(Me.DarkGroupBox2)
        Me.Controls.Add(Me.DarkGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEditor_Classes"
        Me.Text = "Editor de Classes"
        Me.DarkGroupBox1.ResumeLayout(False)
        Me.DarkGroupBox2.ResumeLayout(False)
        Me.DarkGroupBox2.PerformLayout()
        Me.DarkGroupBox7.ResumeLayout(False)
        Me.DarkGroupBox7.PerformLayout()
        CType(Me.nudStartY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DarkGroupBox6.ResumeLayout(False)
        Me.DarkGroupBox6.PerformLayout()
        CType(Me.nudItemAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DarkGroupBox5.ResumeLayout(False)
        Me.DarkGroupBox5.PerformLayout()
        CType(Me.nudBaseExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpirit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEndurance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVitality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLuck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIntelligence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStrength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DarkGroupBox4.ResumeLayout(False)
        Me.DarkGroupBox4.PerformLayout()
        CType(Me.nudFemaleSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFemale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DarkGroupBox3.ResumeLayout(False)
        Me.DarkGroupBox3.PerformLayout()
        CType(Me.nudMaleSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DarkGroupBox1 As GroupBox
    Friend WithEvents DarkGroupBox2 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents DarkLabel1 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents DarkLabel2 As Label
    Friend WithEvents lstIndex As Windows.Forms.ListBox
    Friend WithEvents DarkGroupBox4 As GroupBox
    Friend WithEvents DarkGroupBox3 As GroupBox
    Friend WithEvents picMale As Windows.Forms.PictureBox
    Friend WithEvents cmbMaleSprite As ComboBox
    Friend WithEvents btnAddMaleSprite As Button
    Friend WithEvents btnDeleteMaleSprite As Button
    Friend WithEvents DarkLabel4 As Label
    Friend WithEvents btnDeleteFemaleSprite As Button
    Friend WithEvents btnAddFemaleSprite As Button
    Friend WithEvents cmbFemaleSprite As ComboBox
    Friend WithEvents picFemale As Windows.Forms.PictureBox
    Friend WithEvents lblMaleSprite As Label
    Friend WithEvents btnAddClass As Button
    Friend WithEvents btnRemoveClass As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DarkGroupBox5 As GroupBox
    Friend WithEvents nudFemaleSprite As NumericUpDown
    Friend WithEvents nudMaleSprite As NumericUpDown
    Friend WithEvents DarkLabel5 As Label
    Friend WithEvents DarkLabel3 As Label
    Friend WithEvents nudIntelligence As NumericUpDown
    Friend WithEvents nudStrength As NumericUpDown
    Friend WithEvents nudVitality As NumericUpDown
    Friend WithEvents nudLuck As NumericUpDown
    Friend WithEvents DarkLabel6 As Label
    Friend WithEvents DarkLabel7 As Label
    Friend WithEvents nudSpirit As NumericUpDown
    Friend WithEvents nudEndurance As NumericUpDown
    Friend WithEvents DarkLabel8 As Label
    Friend WithEvents DarkLabel9 As Label
    Friend WithEvents nudBaseExp As NumericUpDown
    Friend WithEvents DarkLabel10 As Label
    Friend WithEvents DarkGroupBox6 As GroupBox
    Friend WithEvents lstStartItems As Windows.Forms.ListBox
    Friend WithEvents cmbItems As ComboBox
    Friend WithEvents DarkLabel11 As Label
    Friend WithEvents nudItemAmount As NumericUpDown
    Friend WithEvents DarkLabel12 As Label
    Friend WithEvents btnItemAdd As Button
    Friend WithEvents DarkGroupBox7 As GroupBox
    Friend WithEvents nudStartMap As NumericUpDown
    Friend WithEvents DarkLabel13 As Label
    Friend WithEvents nudStartY As NumericUpDown
    Friend WithEvents DarkLabel15 As Label
    Friend WithEvents nudStartX As NumericUpDown
    Friend WithEvents DarkLabel14 As Label
End Class
