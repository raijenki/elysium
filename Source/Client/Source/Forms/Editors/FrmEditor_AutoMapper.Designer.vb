<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor_AutoMapper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditor_AutoMapper))
        Me.pnlResources = New System.Windows.Forms.Panel()
        Me.btnAddResource = New DarkUI.Controls.DarkButton()
        Me.btnRemoveResource = New DarkUI.Controls.DarkButton()
        Me.btnUpdateResource = New DarkUI.Controls.DarkButton()
        Me.btnSaveResource = New DarkUI.Controls.DarkButton()
        Me.btnCloseResource = New DarkUI.Controls.DarkButton()
        Me.txtResource = New DarkUI.Controls.DarkTextBox()
        Me.DarkLabel8 = New DarkUI.Controls.DarkLabel()
        Me.lstResources = New System.Windows.Forms.ListBox()
        Me.pnlTileConfig = New System.Windows.Forms.Panel()
        Me.btnTileSetSave = New DarkUI.Controls.DarkButton()
        Me.btnTileSetClose = New DarkUI.Controls.DarkButton()
        Me.DarkLabel10 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel9 = New DarkUI.Controls.DarkLabel()
        Me.cmbLayer = New DarkUI.Controls.DarkComboBox()
        Me.cmbPrefab = New DarkUI.Controls.DarkComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAutotile = New DarkUI.Controls.DarkTextBox()
        Me.txtTileY = New DarkUI.Controls.DarkTextBox()
        Me.txtTileX = New DarkUI.Controls.DarkTextBox()
        Me.txtTileset = New DarkUI.Controls.DarkTextBox()
        Me.chkBlocked = New DarkUI.Controls.DarkCheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DarkMenu = New DarkUI.Controls.DarkMenuStrip()
        Me.ConfigurationsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TilesetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PathsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiversToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MountainsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverGrassToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourcesToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkLabel1 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel2 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel3 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel4 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel5 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel6 = New DarkUI.Controls.DarkLabel()
        Me.DarkLabel7 = New DarkUI.Controls.DarkLabel()
        Me.txtMapStart = New DarkUI.Controls.DarkTextBox()
        Me.txtMapSize = New DarkUI.Controls.DarkTextBox()
        Me.txtMapX = New DarkUI.Controls.DarkTextBox()
        Me.txtMapY = New DarkUI.Controls.DarkTextBox()
        Me.txtSandBorder = New DarkUI.Controls.DarkTextBox()
        Me.txtDetail = New DarkUI.Controls.DarkTextBox()
        Me.txtResourceFreq = New DarkUI.Controls.DarkTextBox()
        Me.btnStart = New DarkUI.Controls.DarkButton()
        Me.pnlResources.SuspendLayout()
        Me.pnlTileConfig.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.DarkMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlResources
        '
        Me.pnlResources.Controls.Add(Me.btnAddResource)
        Me.pnlResources.Controls.Add(Me.btnRemoveResource)
        Me.pnlResources.Controls.Add(Me.btnUpdateResource)
        Me.pnlResources.Controls.Add(Me.btnSaveResource)
        Me.pnlResources.Controls.Add(Me.btnCloseResource)
        Me.pnlResources.Controls.Add(Me.txtResource)
        Me.pnlResources.Controls.Add(Me.DarkLabel8)
        Me.pnlResources.Controls.Add(Me.lstResources)
        Me.pnlResources.Location = New System.Drawing.Point(591, 31)
        Me.pnlResources.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlResources.Name = "pnlResources"
        Me.pnlResources.Size = New System.Drawing.Size(578, 411)
        Me.pnlResources.TabIndex = 24
        Me.pnlResources.Visible = False
        '
        'btnAddResource
        '
        Me.btnAddResource.Location = New System.Drawing.Point(381, 237)
        Me.btnAddResource.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddResource.Name = "btnAddResource"
        Me.btnAddResource.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnAddResource.Size = New System.Drawing.Size(183, 35)
        Me.btnAddResource.TabIndex = 14
        Me.btnAddResource.Text = "Adicionar Recursos"
        '
        'btnRemoveResource
        '
        Me.btnRemoveResource.Location = New System.Drawing.Point(381, 282)
        Me.btnRemoveResource.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRemoveResource.Name = "btnRemoveResource"
        Me.btnRemoveResource.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnRemoveResource.Size = New System.Drawing.Size(183, 35)
        Me.btnRemoveResource.TabIndex = 13
        Me.btnRemoveResource.Text = "Remover Recursos"
        '
        'btnUpdateResource
        '
        Me.btnUpdateResource.Location = New System.Drawing.Point(381, 326)
        Me.btnUpdateResource.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateResource.Name = "btnUpdateResource"
        Me.btnUpdateResource.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnUpdateResource.Size = New System.Drawing.Size(183, 35)
        Me.btnUpdateResource.TabIndex = 12
        Me.btnUpdateResource.Text = "Atualizar Recursos"
        '
        'btnSaveResource
        '
        Me.btnSaveResource.Location = New System.Drawing.Point(381, 371)
        Me.btnSaveResource.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSaveResource.Name = "btnSaveResource"
        Me.btnSaveResource.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnSaveResource.Size = New System.Drawing.Size(183, 35)
        Me.btnSaveResource.TabIndex = 11
        Me.btnSaveResource.Text = "Salvar"
        '
        'btnCloseResource
        '
        Me.btnCloseResource.Location = New System.Drawing.Point(4, 369)
        Me.btnCloseResource.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCloseResource.Name = "btnCloseResource"
        Me.btnCloseResource.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnCloseResource.Size = New System.Drawing.Size(183, 35)
        Me.btnCloseResource.TabIndex = 10
        Me.btnCloseResource.Text = "Fechar"
        '
        'txtResource
        '
        Me.txtResource.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtResource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtResource.Location = New System.Drawing.Point(164, 240)
        Me.txtResource.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtResource.Name = "txtResource"
        Me.txtResource.Size = New System.Drawing.Size(149, 26)
        Me.txtResource.TabIndex = 9
        '
        'DarkLabel8
        '
        Me.DarkLabel8.AutoSize = True
        Me.DarkLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel8.Location = New System.Drawing.Point(10, 240)
        Me.DarkLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel8.Name = "DarkLabel8"
        Me.DarkLabel8.Size = New System.Drawing.Size(155, 20)
        Me.DarkLabel8.TabIndex = 8
        Me.DarkLabel8.Text = "Número do Recurso:"
        '
        'lstResources
        '
        Me.lstResources.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lstResources.ForeColor = System.Drawing.Color.Gainsboro
        Me.lstResources.FormattingEnabled = True
        Me.lstResources.ItemHeight = 20
        Me.lstResources.Location = New System.Drawing.Point(4, 5)
        Me.lstResources.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstResources.Name = "lstResources"
        Me.lstResources.Size = New System.Drawing.Size(558, 224)
        Me.lstResources.TabIndex = 0
        '
        'pnlTileConfig
        '
        Me.pnlTileConfig.Controls.Add(Me.btnTileSetSave)
        Me.pnlTileConfig.Controls.Add(Me.btnTileSetClose)
        Me.pnlTileConfig.Controls.Add(Me.DarkLabel10)
        Me.pnlTileConfig.Controls.Add(Me.DarkLabel9)
        Me.pnlTileConfig.Controls.Add(Me.cmbLayer)
        Me.pnlTileConfig.Controls.Add(Me.cmbPrefab)
        Me.pnlTileConfig.Controls.Add(Me.GroupBox1)
        Me.pnlTileConfig.Location = New System.Drawing.Point(1204, 35)
        Me.pnlTileConfig.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlTileConfig.Name = "pnlTileConfig"
        Me.pnlTileConfig.Size = New System.Drawing.Size(572, 415)
        Me.pnlTileConfig.TabIndex = 25
        Me.pnlTileConfig.Visible = False
        '
        'btnTileSetSave
        '
        Me.btnTileSetSave.Location = New System.Drawing.Point(447, 369)
        Me.btnTileSetSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTileSetSave.Name = "btnTileSetSave"
        Me.btnTileSetSave.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnTileSetSave.Size = New System.Drawing.Size(112, 35)
        Me.btnTileSetSave.TabIndex = 45
        Me.btnTileSetSave.Text = "Salvar"
        '
        'btnTileSetClose
        '
        Me.btnTileSetClose.Location = New System.Drawing.Point(10, 371)
        Me.btnTileSetClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTileSetClose.Name = "btnTileSetClose"
        Me.btnTileSetClose.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnTileSetClose.Size = New System.Drawing.Size(112, 35)
        Me.btnTileSetClose.TabIndex = 44
        Me.btnTileSetClose.Text = "Fechar"
        '
        'DarkLabel10
        '
        Me.DarkLabel10.AutoSize = True
        Me.DarkLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel10.Location = New System.Drawing.Point(10, 57)
        Me.DarkLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel10.Name = "DarkLabel10"
        Me.DarkLabel10.Size = New System.Drawing.Size(144, 20)
        Me.DarkLabel10.TabIndex = 43
        Me.DarkLabel10.Text = "Escolha a camada:"
        '
        'DarkLabel9
        '
        Me.DarkLabel9.AutoSize = True
        Me.DarkLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel9.Location = New System.Drawing.Point(10, 15)
        Me.DarkLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel9.Name = "DarkLabel9"
        Me.DarkLabel9.Size = New System.Drawing.Size(134, 20)
        Me.DarkLabel9.TabIndex = 43
        Me.DarkLabel9.Text = "Escolha o Prefab:"
        '
        'cmbLayer
        '
        Me.cmbLayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmbLayer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbLayer.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbLayer.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbLayer.ButtonIcon = CType(resources.GetObject("cmbLayer.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbLayer.DrawDropdownHoverOutline = False
        Me.cmbLayer.DrawFocusRectangle = False
        Me.cmbLayer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLayer.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbLayer.FormattingEnabled = True
        Me.cmbLayer.Items.AddRange(New Object() {"Ground", "Mask", "Mask 2", "Fringe", "Fringe 2"})
        Me.cmbLayer.Location = New System.Drawing.Point(172, 52)
        Me.cmbLayer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbLayer.Name = "cmbLayer"
        Me.cmbLayer.Size = New System.Drawing.Size(376, 27)
        Me.cmbLayer.TabIndex = 43
        Me.cmbLayer.Text = "Ground"
        Me.cmbLayer.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'cmbPrefab
        '
        Me.cmbPrefab.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmbPrefab.BorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.cmbPrefab.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid
        Me.cmbPrefab.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmbPrefab.ButtonIcon = CType(resources.GetObject("cmbPrefab.ButtonIcon"), System.Drawing.Bitmap)
        Me.cmbPrefab.DrawDropdownHoverOutline = False
        Me.cmbPrefab.DrawFocusRectangle = False
        Me.cmbPrefab.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPrefab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrefab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPrefab.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmbPrefab.FormattingEnabled = True
        Me.cmbPrefab.Items.AddRange(New Object() {"Water", "Sand", "Grass", "Passing", "Overgrass", "River", "Mountain"})
        Me.cmbPrefab.Location = New System.Drawing.Point(172, 11)
        Me.cmbPrefab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPrefab.Name = "cmbPrefab"
        Me.cmbPrefab.Size = New System.Drawing.Size(376, 27)
        Me.cmbPrefab.TabIndex = 43
        Me.cmbPrefab.Text = "Water"
        Me.cmbPrefab.TextPadding = New System.Windows.Forms.Padding(2)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAutotile)
        Me.GroupBox1.Controls.Add(Me.txtTileY)
        Me.GroupBox1.Controls.Add(Me.txtTileX)
        Me.GroupBox1.Controls.Add(Me.txtTileset)
        Me.GroupBox1.Controls.Add(Me.chkBlocked)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Location = New System.Drawing.Point(10, 102)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(549, 260)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configurações de Tile"
        '
        'txtAutotile
        '
        Me.txtAutotile.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtAutotile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAutotile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtAutotile.Location = New System.Drawing.Point(162, 151)
        Me.txtAutotile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAutotile.Name = "txtAutotile"
        Me.txtAutotile.Size = New System.Drawing.Size(377, 26)
        Me.txtAutotile.TabIndex = 47
        '
        'txtTileY
        '
        Me.txtTileY.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtTileY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTileY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtTileY.Location = New System.Drawing.Point(162, 111)
        Me.txtTileY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTileY.Name = "txtTileY"
        Me.txtTileY.Size = New System.Drawing.Size(377, 26)
        Me.txtTileY.TabIndex = 46
        '
        'txtTileX
        '
        Me.txtTileX.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtTileX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTileX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtTileX.Location = New System.Drawing.Point(162, 71)
        Me.txtTileX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTileX.Name = "txtTileX"
        Me.txtTileX.Size = New System.Drawing.Size(377, 26)
        Me.txtTileX.TabIndex = 45
        '
        'txtTileset
        '
        Me.txtTileset.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtTileset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTileset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtTileset.Location = New System.Drawing.Point(162, 31)
        Me.txtTileset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTileset.Name = "txtTileset"
        Me.txtTileset.Size = New System.Drawing.Size(377, 26)
        Me.txtTileset.TabIndex = 44
        '
        'chkBlocked
        '
        Me.chkBlocked.AutoSize = True
        Me.chkBlocked.Location = New System.Drawing.Point(12, 203)
        Me.chkBlocked.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkBlocked.Name = "chkBlocked"
        Me.chkBlocked.Size = New System.Drawing.Size(156, 24)
        Me.chkBlocked.TabIndex = 43
        Me.chkBlocked.Text = "Está bloqueado?"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 154)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "AutoTile:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 114)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 20)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "TileSet Y:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 74)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "TileSet X:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 34)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Número do TileSet:"
        '
        'DarkMenu
        '
        Me.DarkMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DarkMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.DarkMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.DarkMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurationsToolStripMenuItem2, Me.GenerateToolStripMenuItem1})
        Me.DarkMenu.Location = New System.Drawing.Point(0, 0)
        Me.DarkMenu.Name = "DarkMenu"
        Me.DarkMenu.Padding = New System.Windows.Forms.Padding(4, 3, 0, 3)
        Me.DarkMenu.Size = New System.Drawing.Size(1782, 36)
        Me.DarkMenu.TabIndex = 27
        '
        'ConfigurationsToolStripMenuItem2
        '
        Me.ConfigurationsToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TilesetsToolStripMenuItem, Me.ResourcesToolStripMenuItem})
        Me.ConfigurationsToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ConfigurationsToolStripMenuItem2.Name = "ConfigurationsToolStripMenuItem2"
        Me.ConfigurationsToolStripMenuItem2.Size = New System.Drawing.Size(134, 30)
        Me.ConfigurationsToolStripMenuItem2.Text = "Configuração"
        '
        'TilesetsToolStripMenuItem
        '
        Me.TilesetsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TilesetsToolStripMenuItem.Name = "TilesetsToolStripMenuItem"
        Me.TilesetsToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.TilesetsToolStripMenuItem.Text = "Tilesets"
        '
        'ResourcesToolStripMenuItem
        '
        Me.ResourcesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ResourcesToolStripMenuItem.Name = "ResourcesToolStripMenuItem"
        Me.ResourcesToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ResourcesToolStripMenuItem.Text = "Recursos"
        '
        'GenerateToolStripMenuItem1
        '
        Me.GenerateToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PathsToolStripMenuItem1, Me.RiversToolStripMenuItem1, Me.MountainsToolStripMenuItem1, Me.OverGrassToolStripMenuItem1, Me.ResourcesToolStripMenuItem3, Me.DetailsToolStripMenuItem1})
        Me.GenerateToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GenerateToolStripMenuItem1.Name = "GenerateToolStripMenuItem1"
        Me.GenerateToolStripMenuItem1.Size = New System.Drawing.Size(70, 30)
        Me.GenerateToolStripMenuItem1.Text = "Gerar"
        '
        'PathsToolStripMenuItem1
        '
        Me.PathsToolStripMenuItem1.Checked = True
        Me.PathsToolStripMenuItem1.CheckOnClick = True
        Me.PathsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PathsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.PathsToolStripMenuItem1.Name = "PathsToolStripMenuItem1"
        Me.PathsToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.PathsToolStripMenuItem1.Text = "Caminhos"
        '
        'RiversToolStripMenuItem1
        '
        Me.RiversToolStripMenuItem1.Checked = True
        Me.RiversToolStripMenuItem1.CheckOnClick = True
        Me.RiversToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RiversToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RiversToolStripMenuItem1.Name = "RiversToolStripMenuItem1"
        Me.RiversToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.RiversToolStripMenuItem1.Text = "Rios"
        '
        'MountainsToolStripMenuItem1
        '
        Me.MountainsToolStripMenuItem1.Checked = True
        Me.MountainsToolStripMenuItem1.CheckOnClick = True
        Me.MountainsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MountainsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.MountainsToolStripMenuItem1.Name = "MountainsToolStripMenuItem1"
        Me.MountainsToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.MountainsToolStripMenuItem1.Text = "Montanhas"
        '
        'OverGrassToolStripMenuItem1
        '
        Me.OverGrassToolStripMenuItem1.Checked = True
        Me.OverGrassToolStripMenuItem1.CheckOnClick = True
        Me.OverGrassToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OverGrassToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.OverGrassToolStripMenuItem1.Name = "OverGrassToolStripMenuItem1"
        Me.OverGrassToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.OverGrassToolStripMenuItem1.Text = "Sobre-grama"
        '
        'ResourcesToolStripMenuItem3
        '
        Me.ResourcesToolStripMenuItem3.Checked = True
        Me.ResourcesToolStripMenuItem3.CheckOnClick = True
        Me.ResourcesToolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ResourcesToolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ResourcesToolStripMenuItem3.Name = "ResourcesToolStripMenuItem3"
        Me.ResourcesToolStripMenuItem3.Size = New System.Drawing.Size(270, 34)
        Me.ResourcesToolStripMenuItem3.Text = "Recursos"
        '
        'DetailsToolStripMenuItem1
        '
        Me.DetailsToolStripMenuItem1.Checked = True
        Me.DetailsToolStripMenuItem1.CheckOnClick = True
        Me.DetailsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DetailsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DetailsToolStripMenuItem1.Name = "DetailsToolStripMenuItem1"
        Me.DetailsToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.DetailsToolStripMenuItem1.Text = "Detalhes"
        '
        'DarkLabel1
        '
        Me.DarkLabel1.AutoSize = True
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(18, 48)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(97, 20)
        Me.DarkLabel1.TabIndex = 28
        Me.DarkLabel1.Text = "Mapa Inicial:"
        '
        'DarkLabel2
        '
        Me.DarkLabel2.AutoSize = True
        Me.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel2.Location = New System.Drawing.Point(18, 88)
        Me.DarkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel2.Name = "DarkLabel2"
        Me.DarkLabel2.Size = New System.Drawing.Size(99, 20)
        Me.DarkLabel2.TabIndex = 29
        Me.DarkLabel2.Text = "Área de Ilha:"
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = True
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(20, 128)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(171, 20)
        Me.DarkLabel3.TabIndex = 30
        Me.DarkLabel3.Text = "Tamanho do Mapa (X):"
        '
        'DarkLabel4
        '
        Me.DarkLabel4.AutoSize = True
        Me.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel4.Location = New System.Drawing.Point(18, 168)
        Me.DarkLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel4.Name = "DarkLabel4"
        Me.DarkLabel4.Size = New System.Drawing.Size(171, 20)
        Me.DarkLabel4.TabIndex = 31
        Me.DarkLabel4.Text = "Tamanho do Mapa (Y):"
        '
        'DarkLabel5
        '
        Me.DarkLabel5.AutoSize = True
        Me.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel5.Location = New System.Drawing.Point(20, 208)
        Me.DarkLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel5.Name = "DarkLabel5"
        Me.DarkLabel5.Size = New System.Drawing.Size(119, 20)
        Me.DarkLabel5.TabIndex = 32
        Me.DarkLabel5.Text = "Borda de Areia:"
        '
        'DarkLabel6
        '
        Me.DarkLabel6.AutoSize = True
        Me.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel6.Location = New System.Drawing.Point(20, 248)
        Me.DarkLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel6.Name = "DarkLabel6"
        Me.DarkLabel6.Size = New System.Drawing.Size(171, 20)
        Me.DarkLabel6.TabIndex = 33
        Me.DarkLabel6.Text = "Freq. de Detalhes 1 de"
        '
        'DarkLabel7
        '
        Me.DarkLabel7.AutoSize = True
        Me.DarkLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel7.Location = New System.Drawing.Point(18, 288)
        Me.DarkLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DarkLabel7.Name = "DarkLabel7"
        Me.DarkLabel7.Size = New System.Drawing.Size(179, 20)
        Me.DarkLabel7.TabIndex = 34
        Me.DarkLabel7.Text = "Freq. de Recursos 1 de "
        '
        'txtMapStart
        '
        Me.txtMapStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtMapStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMapStart.Location = New System.Drawing.Point(218, 43)
        Me.txtMapStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMapStart.Name = "txtMapStart"
        Me.txtMapStart.Size = New System.Drawing.Size(336, 26)
        Me.txtMapStart.TabIndex = 35
        Me.txtMapStart.Text = "1"
        '
        'txtMapSize
        '
        Me.txtMapSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtMapSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMapSize.Location = New System.Drawing.Point(218, 83)
        Me.txtMapSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMapSize.Name = "txtMapSize"
        Me.txtMapSize.Size = New System.Drawing.Size(336, 26)
        Me.txtMapSize.TabIndex = 36
        Me.txtMapSize.Text = "4"
        '
        'txtMapX
        '
        Me.txtMapX.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtMapX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMapX.Location = New System.Drawing.Point(218, 123)
        Me.txtMapX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMapX.Name = "txtMapX"
        Me.txtMapX.Size = New System.Drawing.Size(336, 26)
        Me.txtMapX.TabIndex = 37
        Me.txtMapX.Text = "50"
        '
        'txtMapY
        '
        Me.txtMapY.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtMapY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMapY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMapY.Location = New System.Drawing.Point(218, 163)
        Me.txtMapY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMapY.Name = "txtMapY"
        Me.txtMapY.Size = New System.Drawing.Size(336, 26)
        Me.txtMapY.TabIndex = 38
        Me.txtMapY.Text = "50"
        '
        'txtSandBorder
        '
        Me.txtSandBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtSandBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSandBorder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtSandBorder.Location = New System.Drawing.Point(218, 203)
        Me.txtSandBorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSandBorder.Name = "txtSandBorder"
        Me.txtSandBorder.Size = New System.Drawing.Size(336, 26)
        Me.txtSandBorder.TabIndex = 39
        Me.txtSandBorder.Text = "4"
        '
        'txtDetail
        '
        Me.txtDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtDetail.Location = New System.Drawing.Point(218, 243)
        Me.txtDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(336, 26)
        Me.txtDetail.TabIndex = 40
        Me.txtDetail.Text = "10"
        '
        'txtResourceFreq
        '
        Me.txtResourceFreq.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtResourceFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResourceFreq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtResourceFreq.Location = New System.Drawing.Point(218, 283)
        Me.txtResourceFreq.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtResourceFreq.Name = "txtResourceFreq"
        Me.txtResourceFreq.Size = New System.Drawing.Size(336, 26)
        Me.txtResourceFreq.TabIndex = 41
        Me.txtResourceFreq.Text = "20"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(24, 357)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnStart.Size = New System.Drawing.Size(531, 51)
        Me.btnStart.TabIndex = 42
        Me.btnStart.Text = "Criar Mundo"
        '
        'frmEditor_AutoMapper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1782, 455)
        Me.Controls.Add(Me.pnlResources)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtResourceFreq)
        Me.Controls.Add(Me.txtDetail)
        Me.Controls.Add(Me.txtSandBorder)
        Me.Controls.Add(Me.txtMapY)
        Me.Controls.Add(Me.txtMapX)
        Me.Controls.Add(Me.txtMapSize)
        Me.Controls.Add(Me.txtMapStart)
        Me.Controls.Add(Me.DarkLabel7)
        Me.Controls.Add(Me.DarkLabel6)
        Me.Controls.Add(Me.DarkLabel5)
        Me.Controls.Add(Me.DarkLabel4)
        Me.Controls.Add(Me.DarkLabel3)
        Me.Controls.Add(Me.DarkLabel2)
        Me.Controls.Add(Me.DarkLabel1)
        Me.Controls.Add(Me.pnlTileConfig)
        Me.Controls.Add(Me.DarkMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEditor_AutoMapper"
        Me.Text = "Gerador Procedural de Mapas"
        Me.pnlResources.ResumeLayout(False)
        Me.pnlResources.PerformLayout()
        Me.pnlTileConfig.ResumeLayout(False)
        Me.pnlTileConfig.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.DarkMenu.ResumeLayout(False)
        Me.DarkMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlResources As Windows.Forms.Panel
    Friend WithEvents lstResources As Windows.Forms.ListBox
    Friend WithEvents pnlTileConfig As Windows.Forms.Panel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents DarkMenu As DarkUI.Controls.DarkMenuStrip
    Friend WithEvents ConfigurationsToolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents TilesetsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResourcesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents PathsToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RiversToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MountainsToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OverGrassToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResourcesToolStripMenuItem3 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel4 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel5 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel6 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel7 As DarkUI.Controls.DarkLabel
    Friend WithEvents txtMapStart As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtMapSize As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtMapX As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtMapY As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtSandBorder As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtDetail As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtResourceFreq As DarkUI.Controls.DarkTextBox
    Friend WithEvents btnStart As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel8 As DarkUI.Controls.DarkLabel
    Friend WithEvents btnCloseResource As DarkUI.Controls.DarkButton
    Friend WithEvents txtResource As DarkUI.Controls.DarkTextBox
    Friend WithEvents btnSaveResource As DarkUI.Controls.DarkButton
    Friend WithEvents btnUpdateResource As DarkUI.Controls.DarkButton
    Friend WithEvents btnRemoveResource As DarkUI.Controls.DarkButton
    Friend WithEvents btnAddResource As DarkUI.Controls.DarkButton
    Friend WithEvents cmbPrefab As DarkUI.Controls.DarkComboBox
    Friend WithEvents cmbLayer As DarkUI.Controls.DarkComboBox
    Friend WithEvents DarkLabel10 As DarkUI.Controls.DarkLabel
    Friend WithEvents DarkLabel9 As DarkUI.Controls.DarkLabel
    Friend WithEvents chkBlocked As DarkUI.Controls.DarkCheckBox
    Friend WithEvents txtTileset As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtAutotile As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtTileY As DarkUI.Controls.DarkTextBox
    Friend WithEvents txtTileX As DarkUI.Controls.DarkTextBox
    Friend WithEvents btnTileSetClose As DarkUI.Controls.DarkButton
    Friend WithEvents btnTileSetSave As DarkUI.Controls.DarkButton
End Class
