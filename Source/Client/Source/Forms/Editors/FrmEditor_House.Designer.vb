<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditor_House
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DarkGroupBox1 = New DarkUI.Controls.DarkGroupBox()
        Me.lstIndex = New System.Windows.Forms.ListBox()
        Me.DarkGroupBox2 = New DarkUI.Controls.DarkGroupBox()
        Me.nudFurniture = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel6 = New DarkUI.Controls.DarkLabel()
        Me.nudPrice = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel5 = New DarkUI.Controls.DarkLabel()
        Me.nudY = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel4 = New DarkUI.Controls.DarkLabel()
        Me.nudX = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel3 = New DarkUI.Controls.DarkLabel()
        Me.nudBaseMap = New DarkUI.Controls.DarkNumericUpDown()
        Me.DarkLabel2 = New DarkUI.Controls.DarkLabel()
        Me.txtName = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel1 = New DarkUI.Controls.DarkLabel()
        Me.btnCancel = New DarkUI.Controls.DarkButton()
        Me.btnSave = New DarkUI.Controls.DarkButton()
        Me.DarkGroupBox1.SuspendLayout()
        Me.DarkGroupBox2.SuspendLayout()
        CType(Me.nudFurniture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBaseMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DarkGroupBox1
        '
        Me.DarkGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox1.Controls.Add(Me.lstIndex)
        Me.DarkGroupBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox1.Location = New System.Drawing.Point(4, 5)
        Me.DarkGroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox1.Name = "DarkGroupBox1"
        Me.DarkGroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox1.Size = New System.Drawing.Size(300, 560)
        Me.DarkGroupBox1.TabIndex = 0
        Me.DarkGroupBox1.TabStop = False
        Me.DarkGroupBox1.Text = "Lista de Casas"
        '
        'lstIndex
        '
        Me.lstIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lstIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstIndex.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstIndex.FormattingEnabled = True
        Me.lstIndex.ItemHeight = 20
        Me.lstIndex.Location = New System.Drawing.Point(9, 29)
        Me.lstIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstIndex.Name = "lstIndex"
        Me.lstIndex.Size = New System.Drawing.Size(281, 522)
        Me.lstIndex.TabIndex = 1
        '
        'DarkGroupBox2
        '
        Me.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DarkGroupBox2.Controls.Add(Me.nudFurniture)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel6)
        Me.DarkGroupBox2.Controls.Add(Me.nudPrice)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel5)
        Me.DarkGroupBox2.Controls.Add(Me.nudY)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel4)
        Me.DarkGroupBox2.Controls.Add(Me.nudX)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel3)
        Me.DarkGroupBox2.Controls.Add(Me.nudBaseMap)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel2)
        Me.DarkGroupBox2.Controls.Add(Me.txtName)
        Me.DarkGroupBox2.Controls.Add(Me.DarkLabel1)
        Me.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro
        Me.DarkGroupBox2.Location = New System.Drawing.Point(314, 5)
        Me.DarkGroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox2.Name = "DarkGroupBox2"
        Me.DarkGroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DarkGroupBox2.Size = New System.Drawing.Size(408, 515)
        Me.DarkGroupBox2.TabIndex = 1
        Me.DarkGroupBox2.TabStop = False
        Me.DarkGroupBox2.Text = "Atributos da Casa"
        '
        'nudFurniture
        '
        Me.nudFurniture.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudFurniture.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudFurniture.Location = New System.Drawing.Point(298, 338)
        Me.nudFurniture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudFurniture.Name = "nudFurniture"
        Me.nudFurniture.Size = New System.Drawing.Size(93, 26)
        Me.nudFurniture.TabIndex = 11
        Me.nudFurniture.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DarkLabel6
        '
        Me.DarkLabel6.AutoSize = True
        Me.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel6.Location = New System.Drawing.Point(9, 342)
        Me.DarkLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel6.Name = "DarkLabel6"
        Me.DarkLabel6.Size = New System.Drawing.Size(275, 20)
        Me.DarkLabel6.TabIndex = 10
        Me.DarkLabel6.Text = "Máximo de Mobília (0 para sem limite):"
        '
        'nudPrice
        '
        Me.nudPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudPrice.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudPrice.Location = New System.Drawing.Point(126, 277)
        Me.nudPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPrice.Name = "nudPrice"
        Me.nudPrice.Size = New System.Drawing.Size(266, 26)
        Me.nudPrice.TabIndex = 9
        Me.nudPrice.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel5
        '
        Me.DarkLabel5.AutoSize = True
        Me.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel5.Location = New System.Drawing.Point(9, 280)
        Me.DarkLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel5.Name = "DarkLabel5"
        Me.DarkLabel5.Size = New System.Drawing.Size(54, 20)
        Me.DarkLabel5.TabIndex = 8
        Me.DarkLabel5.Text = "Preço:"
        '
        'nudY
        '
        Me.nudY.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudY.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudY.Location = New System.Drawing.Point(126, 211)
        Me.nudY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudY.Name = "nudY"
        Me.nudY.Size = New System.Drawing.Size(266, 26)
        Me.nudY.TabIndex = 7
        Me.nudY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel4
        '
        Me.DarkLabel4.AutoSize = True
        Me.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel4.Location = New System.Drawing.Point(9, 214)
        Me.DarkLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel4.Name = "DarkLabel4"
        Me.DarkLabel4.Size = New System.Drawing.Size(95, 20)
        Me.DarkLabel4.TabIndex = 6
        Me.DarkLabel4.Text = "Entrada (Y):"
        '
        'nudX
        '
        Me.nudX.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudX.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudX.Location = New System.Drawing.Point(126, 145)
        Me.nudX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudX.Name = "nudX"
        Me.nudX.Size = New System.Drawing.Size(266, 26)
        Me.nudX.TabIndex = 5
        Me.nudX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = True
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(9, 148)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(95, 20)
        Me.DarkLabel3.TabIndex = 4
        Me.DarkLabel3.Text = "Entrada (X):"
        '
        'nudBaseMap
        '
        Me.nudBaseMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudBaseMap.ForeColor = System.Drawing.Color.Gainsboro
        Me.nudBaseMap.Location = New System.Drawing.Point(126, 78)
        Me.nudBaseMap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudBaseMap.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBaseMap.Name = "nudBaseMap"
        Me.nudBaseMap.Size = New System.Drawing.Size(266, 26)
        Me.nudBaseMap.TabIndex = 3
        Me.nudBaseMap.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DarkLabel2
        '
        Me.DarkLabel2.AutoSize = True
        Me.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel2.Location = New System.Drawing.Point(9, 82)
        Me.DarkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel2.Name = "DarkLabel2"
        Me.DarkLabel2.Size = New System.Drawing.Size(94, 20)
        Me.DarkLabel2.TabIndex = 2
        Me.DarkLabel2.Text = "Mapa Base:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(126, 26)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(264, 26)
        Me.txtName.TabIndex = 1
        '
        'DarkLabel1
        '
        Me.DarkLabel1.AutoSize = True
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(9, 29)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(55, 20)
        Me.DarkLabel1.TabIndex = 0
        Me.DarkLabel1.Text = "Nome:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(609, 529)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(488, 529)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Salvar"
        '
        'frmEditor_House
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 571)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.DarkGroupBox2)
        Me.Controls.Add(Me.DarkGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEditor_House"
        Me.Text = "Editor de Casa"
        Me.DarkGroupBox1.ResumeLayout(False)
        Me.DarkGroupBox2.ResumeLayout(False)
        Me.DarkGroupBox2.PerformLayout()
        CType(Me.nudFurniture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBaseMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DarkGroupBox1 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents lstIndex As Windows.Forms.ListBox
    Friend WithEvents DarkGroupBox2 As DarkUI.Controls.DarkGroupBox
    Friend WithEvents txtName As DarkUI.Controls.DarkTextBox
    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudBaseMap As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudY As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel4 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudX As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudPrice As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel5 As DarkUI.Controls.DarkLabel
    Friend WithEvents nudFurniture As DarkUI.Controls.DarkNumericUpDown
    Friend WithEvents DarkLabel6 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnCancel As DarkUI.Controls.DarkButton
    Friend WithEvents btnSave As DarkUI.Controls.DarkButton
End Class
