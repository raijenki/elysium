<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor_Recipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditor_Recipe))
        Me.DarkGroupBox1 = New DarkUI.Controls.DarkGroupBox()
        Me.lstIndex = New System.Windows.Forms.ListBox()
        Me.DarkGroupBox2 = New DarkUI.Controls.DarkGroupBox()
        Me.btnCancel = New DarkUI.Controls.DarkButton()
        Me.btnDelete = New DarkUI.Controls.DarkButton()
        Me.btnSave = New DarkUI.Controls.DarkButton()
        Me.nudCreateTime = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel7 = New DarkUI.Controls.DarkLabel()
        Me.DarkGroupBox3 = New DarkUI.Controls.DarkGroupBox()
        Me.btnIngredientAdd = New DarkUI.Controls.DarkButton()
        Me.numItemAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel6 = New DarkUI.Controls.DarkLabel()
        Me.cmbIngredient = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel5 = New DarkUI.Controls.DarkLabel()
        Me.lstIngredients = New System.Windows.Forms.ListBox()
        Me.nudAmount = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel4 = New DarkUI.Controls.DarkLabel()
        Me.cmbMakeItem = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel3 = New DarkUI.Controls.DarkLabel()
        Me.cmbType = New DarkUI.Controls.DarkComboBox()
        Me.DarkLabel2 = New DarkUI.Controls.DarkLabel()
        Me.txtName = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel1 = New DarkUI.Controls.DarkLabel()
        Me.DarkGroupBox1.SuspendLayout()
        Me.DarkGroupBox2.SuspendLayout()
        CType(Me.nudCreateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DarkGroupBox3.SuspendLayout()
        CType(Me.numItemAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DarkGroupBox1
        '
        Me.DarkGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox1.Controls.Add(Me.lstIndex)
        Me.DarkGroupBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.DarkGroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox1.Name = "DarkGroupBox1"
        Me.DarkGroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox1.Size = New System.Drawing.Size(312, 518)
        Me.DarkGroupBox1.TabIndex = 0
        Me.DarkGroupBox1.TabStop = False
        Me.DarkGroupBox1.Text = "Lista de Receitas"
        '
        'lstIndex
        '
        Me.lstIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lstIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstIndex.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstIndex.FormattingEnabled = True
        Me.lstIndex.ItemHeight = 20
        Me.lstIndex.Location = New System.Drawing.Point(9, 23)
        Me.lstIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstIndex.Name = "lstIndex"
        Me.lstIndex.Size = New System.Drawing.Size(293, 482)
        Me.lstIndex.TabIndex = 1
        '
        'DarkGroupBox2
        '
        Me.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox2.Controls.Add(Me.btnCancel)
        Me.DarkGroupBox2.Controls.Add(Me.btnDelete)
        Me.DarkGroupBox2.Controls.Add(Me.btnSave)
        Me.DarkGroupBox2.Controls.Add(Me.nudCreateTime)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel7)
        Me.DarkGroupBox2.Controls.Add(Me.DarkGroupBox3)
        Me.DarkGroupBox2.Controls.Add(Me.nudAmount)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel4)
        Me.DarkGroupBox2.Controls.Add(Me.cmbMakeItem)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel3)
        Me.DarkGroupBox2.Controls.Add(Me.cmbType)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel2)
        Me.DarkGroupBox2.Controls.Add(Me.txtName)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel1)
        Me.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox2.Location = New System.Drawing.Point(326, 3)
        Me.DarkGroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox2.Name = "DarkGroupBox2"
        Me.DarkGroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox2.Size = New System.Drawing.Size(546, 518)
        Me.DarkGroupBox2.TabIndex = 1
        Me.DarkGroupBox2.TabStop = False
        Me.DarkGroupBox2.Text = "Propriedades da Receita"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(418, 471)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(8)
        Me.btnCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancelar"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(214, 471)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Padding = New System.Windows.Forms.Padding(8)
        Me.btnDelete.Size = New System.Drawing.Size(112, 35)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Excluir"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(14, 471)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(8)
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Salvar"
        '
        'nudCreateTime
        '
        Me.nudCreateTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudCreateTime.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudCreateTime.Location = New System.Drawing.Point(256, 182)
        Me.nudCreateTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudCreateTime.Name = "nudCreateTime"
        Me.nudCreateTime.Size = New System.Drawing.Size(180, 26)
        Me.nudCreateTime.TabIndex = 10
        Me.nudCreateTime.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel7
        '
        Me.DarkLabel7.AutoSize = True
        Me.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel7.Location = New System.Drawing.Point(9, 185)
        Me.DarkLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel7.Name = "DarkLabel7"
        Me.DarkLabel7.Size = New System.Drawing.Size(142, 20)
        Me.DarkLabel7.TabIndex = 9
        Me.DarkLabel7.Text = "Tempo de Criação:"
        '
        'DarkGroupBox3
        '
        Me.DarkGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox3.Controls.Add(Me.btnIngredientAdd)
        Me.DarkGroupBox3.Controls.Add(Me.numItemAmount)
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel6)
        Me.DarkGroupBox3.Controls.Add(Me.cmbIngredient)
        Me.DarkGroupBox3.Controls.Add(Me.DarkLabel5)
        Me.DarkGroupBox3.Controls.Add(Me.lstIngredients)
        Me.DarkGroupBox3.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox3.Location = New System.Drawing.Point(14, 222)
        Me.DarkGroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox3.Name = "DarkGroupBox3"
        Me.DarkGroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox3.Size = New System.Drawing.Size(518, 212)
        Me.DarkGroupBox3.TabIndex = 8
        Me.DarkGroupBox3.TabStop = False
        Me.DarkGroupBox3.Text = "Ingredientes"
        '
        'btnIngredientAdd
        '
        Me.btnIngredientAdd.Location = New System.Drawing.Point(262, 157)
        Me.btnIngredientAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnIngredientAdd.Name = "btnIngredientAdd"
        Me.btnIngredientAdd.Padding = New System.Windows.Forms.Padding(8)
        Me.btnIngredientAdd.Size = New System.Drawing.Size(216, 35)
        Me.btnIngredientAdd.TabIndex = 6
        Me.btnIngredientAdd.Text = "Atualizar Lista"
        '
        'numItemAmount
        '
        Me.numItemAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.numItemAmount.ForeColor = System.Drawing.Color.Gainsboro
        Me.numItemAmount.Location = New System.Drawing.Point(429, 95)
        Me.numItemAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numItemAmount.Name = "numItemAmount"
        Me.numItemAmount.Size = New System.Drawing.Size(80, 26)
        Me.numItemAmount.TabIndex = 5
        Me.numItemAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel6
        '
        Me.DarkLabel6.AutoSize = True
        Me.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel6.Location = New System.Drawing.Point(237, 98)
        Me.DarkLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel6.Name = "DarkLabel6"
        Me.DarkLabel6.Size = New System.Drawing.Size(126, 20)
        Me.DarkLabel6.TabIndex = 4
        Me.DarkLabel6.Text = "Qtd. Necessária:"
        '
        'cmbIngredient
        '
        Me.cmbIngredient.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbIngredient.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbIngredient.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbIngredient.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbIngredient.ButtonIcon = CType(resources.GetObject("cmbIngredient.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbIngredient.DrawDropdownHoverOutline = False
        Me.cmbIngredient.DrawFocusRectangle = False
        Me.cmbIngredient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbIngredient.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbIngredient.FormattingEnabled = True
        Me.cmbIngredient.Location = New System.Drawing.Point(242, 54)
        Me.cmbIngredient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbIngredient.Name = "cmbIngredient"
        Me.cmbIngredient.Size = New System.Drawing.Size(265, 27)
        Me.cmbIngredient.TabIndex = 3
        Me.cmbIngredient.Text = Nothing
        Me.cmbIngredient.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel5
        '
        Me.DarkLabel5.AutoSize = True
        Me.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel5.Location = New System.Drawing.Point(237, 29)
        Me.DarkLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel5.Name = "DarkLabel5"
        Me.DarkLabel5.Size = New System.Drawing.Size(151, 20)
        Me.DarkLabel5.TabIndex = 2
        Me.DarkLabel5.Text = "Escolha Ingrediente"
        '
        'lstIngredients
        '
        Me.lstIngredients.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lstIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstIngredients.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstIngredients.FormattingEnabled = True
        Me.lstIngredients.ItemHeight = 20
        Me.lstIngredients.Location = New System.Drawing.Point(9, 29)
        Me.lstIngredients.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstIngredients.Name = "lstIngredients"
        Me.lstIngredients.Size = New System.Drawing.Size(218, 162)
        Me.lstIngredients.TabIndex = 1
        '
        'nudAmount
        '
        Me.nudAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudAmount.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudAmount.Location = New System.Drawing.Point(468, 132)
        Me.nudAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(63, 26)
        Me.nudAmount.TabIndex = 7
        Me.nudAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel4
        '
        Me.DarkLabel4.AutoSize = True
        Me.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel4.Location = New System.Drawing.Point(446, 135)
        Me.DarkLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel4.Name = "DarkLabel4"
        Me.DarkLabel4.Size = New System.Drawing.Size(20, 20)
        Me.DarkLabel4.TabIndex = 6
        Me.DarkLabel4.Text = "X"
        '
        'cmbMakeItem
        '
        Me.cmbMakeItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbMakeItem.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbMakeItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbMakeItem.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbMakeItem.ButtonIcon = CType(resources.GetObject("cmbMakeItem.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbMakeItem.DrawDropdownHoverOutline = False
        Me.cmbMakeItem.DrawFocusRectangle = False
        Me.cmbMakeItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMakeItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMakeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMakeItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbMakeItem.FormattingEnabled = True
        Me.cmbMakeItem.Location = New System.Drawing.Point(130, 131)
        Me.cmbMakeItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbMakeItem.Name = "cmbMakeItem"
        Me.cmbMakeItem.Size = New System.Drawing.Size(304, 27)
        Me.cmbMakeItem.TabIndex = 5
        Me.cmbMakeItem.Text = Nothing
        Me.cmbMakeItem.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = True
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(9, 135)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(77, 20)
        Me.DarkLabel3.TabIndex = 4
        Me.DarkLabel3.Text = "Cria Item:"
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbType.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbType.ButtonIcon = CType(resources.GetObject("cmbType.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbType.DrawDropdownHoverOutline = False
        Me.cmbType.DrawFocusRectangle = False
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbType.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Herbalista", "Madereireiro", "Metalista"})
        Me.cmbType.Location = New System.Drawing.Point(130, 83)
        Me.cmbType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(398, 27)
        Me.cmbType.TabIndex = 3
        Me.cmbType.Text = "Herbalist"
        Me.cmbType.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'DarkLabel2
        '
        Me.DarkLabel2.AutoSize = True
        Me.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel2.Location = New System.Drawing.Point(9, 88)
        Me.DarkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel2.Name = "DarkLabel2"
        Me.DarkLabel2.Size = New System.Drawing.Size(43, 20)
        Me.DarkLabel2.TabIndex = 2
        Me.DarkLabel2.Text = "Tipo:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(130, 38)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(400, 26)
        Me.txtName.TabIndex = 1
        '
        'DarkLabel1
        '
        Me.DarkLabel1.AutoSize = True
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(9, 42)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(55, 20)
        Me.DarkLabel1.TabIndex = 0
        Me.DarkLabel1.Text = "Nome:"
        '
        'frmEditor_Recipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.DarkGroupBox2)
        Me.Controls.Add(Me.DarkGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEditor_Recipe"
        Me.Text = "Editor de Receitas"
        Me.DarkGroupBox1.ResumeLayout(False)
        Me.DarkGroupBox2.ResumeLayout(False)
        Me.DarkGroupBox2.PerformLayout()
        CType(Me.nudCreateTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DarkGroupBox3.ResumeLayout(False)
        Me.DarkGroupBox3.PerformLayout()
        CType(Me.numItemAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DarkGroupBox1 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstIndex As Windows.Forms.ListBox
    Friend WithEvents DarkGroupBox2 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents txtName As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbType As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents cmbMakeItem As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel4 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkGroupBox3 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstIngredients As Windows.Forms.ListBox
    Friend WithEvents cmbIngredient As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel5 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel6 As DarkUI.Controls.DarkLabel
    Friend WithEvents numItemAmount As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents btnIngredientAdd As DarkUI.Controls.DarkButton
    Friend WithEvents nudCreateTime As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel7 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnCancel As DarkUI.Controls.DarkButton
    Friend WithEvents btnDelete As DarkUI.Controls.DarkButton
    Friend WithEvents btnSave As DarkUI.Controls.DarkButton
End Class
