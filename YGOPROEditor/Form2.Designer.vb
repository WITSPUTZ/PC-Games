﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DescrpLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.CardsDataSet1 = New YGOPROEditor.cardsDataSet1()
        Me.DatainfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatainfoTableAdapter = New YGOPROEditor.cardsDataSet1TableAdapters.datainfoTableAdapter()
        Me.TableAdapterManager = New YGOPROEditor.cardsDataSet1TableAdapters.TableAdapterManager()
        Me.DatainfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextosTableAdapter = New YGOPROEditor.cardsDataSet1TableAdapters.textosTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DescrpTextBox = New System.Windows.Forms.TextBox()
        Me.TextosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonsterZoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Monster1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Monster2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Monster3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Monster4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Monster5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpellZoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Spell1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Spell2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Spell3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Spell4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Spell5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldSpellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeckZoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraveyardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanishedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraDeckToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand3ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand4ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hand5ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFromPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainDeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraveyardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanishedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraDeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFromOpponentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainDeckToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraveyardToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanishedToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraDeckToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        IdLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DescrpLabel = New System.Windows.Forms.Label()
        CType(Me.CardsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatainfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatainfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatainfoBindingNavigator.SuspendLayout()
        CType(Me.TextosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(495, 54)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 6
        IdLabel.Text = "id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(477, 90)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(36, 13)
        NameLabel.TabIndex = 8
        NameLabel.Text = "name:"
        '
        'DescrpLabel
        '
        DescrpLabel.AutoSize = True
        DescrpLabel.Location = New System.Drawing.Point(477, 130)
        DescrpLabel.Name = "DescrpLabel"
        DescrpLabel.Size = New System.Drawing.Size(42, 13)
        DescrpLabel.TabIndex = 10
        DescrpLabel.Text = "descrp:"
        '
        'CardsDataSet1
        '
        Me.CardsDataSet1.DataSetName = "cardsDataSet1"
        Me.CardsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatainfoBindingSource
        '
        Me.DatainfoBindingSource.DataMember = "datainfo"
        Me.DatainfoBindingSource.DataSource = Me.CardsDataSet1
        '
        'DatainfoTableAdapter
        '
        Me.DatainfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.datainfoTableAdapter = Me.DatainfoTableAdapter
        Me.TableAdapterManager.textosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = YGOPROEditor.cardsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DatainfoBindingNavigator
        '
        Me.DatainfoBindingNavigator.AddNewItem = Nothing
        Me.DatainfoBindingNavigator.BindingSource = Me.DatainfoBindingSource
        Me.DatainfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DatainfoBindingNavigator.DeleteItem = Nothing
        Me.DatainfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.DatainfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DatainfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DatainfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DatainfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DatainfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DatainfoBindingNavigator.Name = "DatainfoBindingNavigator"
        Me.DatainfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DatainfoBindingNavigator.Size = New System.Drawing.Size(799, 25)
        Me.DatainfoBindingNavigator.TabIndex = 0
        Me.DatainfoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TextosBindingSource
        '
        Me.TextosBindingSource.DataMember = "textos"
        Me.TextosBindingSource.DataSource = Me.CardsDataSet1
        '
        'TextosTableAdapter
        '
        Me.TextosTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search by Name"
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TextosBindingSource, "id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(556, 47)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.ReadOnly = True
        Me.IdTextBox1.Size = New System.Drawing.Size(148, 20)
        Me.IdTextBox1.TabIndex = 7
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TextosBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(556, 90)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(148, 20)
        Me.NameTextBox.TabIndex = 9
        '
        'DescrpTextBox
        '
        Me.DescrpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TextosBindingSource, "descrp", True))
        Me.DescrpTextBox.Location = New System.Drawing.Point(556, 130)
        Me.DescrpTextBox.Multiline = True
        Me.DescrpTextBox.Name = "DescrpTextBox"
        Me.DescrpTextBox.ReadOnly = True
        Me.DescrpTextBox.Size = New System.Drawing.Size(148, 53)
        Me.DescrpTextBox.TabIndex = 11
        '
        'TextosDataGridView
        '
        Me.TextosDataGridView.AutoGenerateColumns = False
        Me.TextosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TextosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TextosDataGridView.DataSource = Me.TextosBindingSource
        Me.TextosDataGridView.Location = New System.Drawing.Point(368, 201)
        Me.TextosDataGridView.Name = "TextosDataGridView"
        Me.TextosDataGridView.Size = New System.Drawing.Size(404, 239)
        Me.TextosDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descrp"
        Me.DataGridViewTextBoxColumn3.HeaderText = "descrp"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "str1"
        Me.DataGridViewTextBoxColumn4.HeaderText = "str1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "str2"
        Me.DataGridViewTextBoxColumn5.HeaderText = "str2"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "str3"
        Me.DataGridViewTextBoxColumn6.HeaderText = "str3"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(39, 201)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 254)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Card Image"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(407, 453)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(365, 20)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Search by Description"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(39, 150)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(198, 20)
        Me.TextBox3.TabIndex = 22
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToToolStripMenuItem, Me.ToolStripMenuItem1, Me.RemoveFromPlayerToolStripMenuItem, Me.RemoveFromOpponentToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(204, 114)
        '
        'AddToToolStripMenuItem
        '
        Me.AddToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonsterZoneToolStripMenuItem, Me.SpellZoneToolStripMenuItem, Me.HandToolStripMenuItem, Me.DeckZoneToolStripMenuItem, Me.GraveyardToolStripMenuItem, Me.BanishedToolStripMenuItem, Me.ExtraDeckToolStripMenuItem1})
        Me.AddToToolStripMenuItem.Name = "AddToToolStripMenuItem"
        Me.AddToToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddToToolStripMenuItem.Text = "Add to Player"
        '
        'MonsterZoneToolStripMenuItem
        '
        Me.MonsterZoneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Monster1ToolStripMenuItem, Me.Monster2ToolStripMenuItem, Me.Monster3ToolStripMenuItem, Me.Monster4ToolStripMenuItem, Me.Monster5ToolStripMenuItem})
        Me.MonsterZoneToolStripMenuItem.Name = "MonsterZoneToolStripMenuItem"
        Me.MonsterZoneToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.MonsterZoneToolStripMenuItem.Text = "Monster Zone"
        '
        'Monster1ToolStripMenuItem
        '
        Me.Monster1ToolStripMenuItem.Name = "Monster1ToolStripMenuItem"
        Me.Monster1ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Monster1ToolStripMenuItem.Text = "Monster 1"
        '
        'Monster2ToolStripMenuItem
        '
        Me.Monster2ToolStripMenuItem.Name = "Monster2ToolStripMenuItem"
        Me.Monster2ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Monster2ToolStripMenuItem.Text = "Monster 2"
        '
        'Monster3ToolStripMenuItem
        '
        Me.Monster3ToolStripMenuItem.Name = "Monster3ToolStripMenuItem"
        Me.Monster3ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Monster3ToolStripMenuItem.Text = "Monster 3"
        '
        'Monster4ToolStripMenuItem
        '
        Me.Monster4ToolStripMenuItem.Name = "Monster4ToolStripMenuItem"
        Me.Monster4ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Monster4ToolStripMenuItem.Text = "Monster 4"
        '
        'Monster5ToolStripMenuItem
        '
        Me.Monster5ToolStripMenuItem.Name = "Monster5ToolStripMenuItem"
        Me.Monster5ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Monster5ToolStripMenuItem.Text = "Monster 5"
        '
        'SpellZoneToolStripMenuItem
        '
        Me.SpellZoneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Spell1ToolStripMenuItem, Me.Spell2ToolStripMenuItem, Me.Spell3ToolStripMenuItem, Me.Spell4ToolStripMenuItem, Me.Spell5ToolStripMenuItem, Me.FieldSpellToolStripMenuItem})
        Me.SpellZoneToolStripMenuItem.Name = "SpellZoneToolStripMenuItem"
        Me.SpellZoneToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SpellZoneToolStripMenuItem.Text = "Spell Zone"
        '
        'Spell1ToolStripMenuItem
        '
        Me.Spell1ToolStripMenuItem.Name = "Spell1ToolStripMenuItem"
        Me.Spell1ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Spell1ToolStripMenuItem.Text = "Spell 1"
        '
        'Spell2ToolStripMenuItem
        '
        Me.Spell2ToolStripMenuItem.Name = "Spell2ToolStripMenuItem"
        Me.Spell2ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Spell2ToolStripMenuItem.Text = "Spell 2"
        '
        'Spell3ToolStripMenuItem
        '
        Me.Spell3ToolStripMenuItem.Name = "Spell3ToolStripMenuItem"
        Me.Spell3ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Spell3ToolStripMenuItem.Text = "Spell 3"
        '
        'Spell4ToolStripMenuItem
        '
        Me.Spell4ToolStripMenuItem.Name = "Spell4ToolStripMenuItem"
        Me.Spell4ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Spell4ToolStripMenuItem.Text = "Spell 4"
        '
        'Spell5ToolStripMenuItem
        '
        Me.Spell5ToolStripMenuItem.Name = "Spell5ToolStripMenuItem"
        Me.Spell5ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Spell5ToolStripMenuItem.Text = "Spell 5"
        '
        'FieldSpellToolStripMenuItem
        '
        Me.FieldSpellToolStripMenuItem.Name = "FieldSpellToolStripMenuItem"
        Me.FieldSpellToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.FieldSpellToolStripMenuItem.Text = "Field Spell"
        '
        'HandToolStripMenuItem
        '
        Me.HandToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Hand1ToolStripMenuItem, Me.Hand2ToolStripMenuItem, Me.Hand3ToolStripMenuItem, Me.Hand4ToolStripMenuItem, Me.Hand5ToolStripMenuItem})
        Me.HandToolStripMenuItem.Name = "HandToolStripMenuItem"
        Me.HandToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.HandToolStripMenuItem.Text = "Hand"
        '
        'Hand1ToolStripMenuItem
        '
        Me.Hand1ToolStripMenuItem.Name = "Hand1ToolStripMenuItem"
        Me.Hand1ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.Hand1ToolStripMenuItem.Text = "Hand 1"
        '
        'Hand2ToolStripMenuItem
        '
        Me.Hand2ToolStripMenuItem.Name = "Hand2ToolStripMenuItem"
        Me.Hand2ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.Hand2ToolStripMenuItem.Text = "Hand 2"
        '
        'Hand3ToolStripMenuItem
        '
        Me.Hand3ToolStripMenuItem.Name = "Hand3ToolStripMenuItem"
        Me.Hand3ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.Hand3ToolStripMenuItem.Text = "Hand 3"
        '
        'Hand4ToolStripMenuItem
        '
        Me.Hand4ToolStripMenuItem.Name = "Hand4ToolStripMenuItem"
        Me.Hand4ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.Hand4ToolStripMenuItem.Text = "Hand 4"
        '
        'Hand5ToolStripMenuItem
        '
        Me.Hand5ToolStripMenuItem.Name = "Hand5ToolStripMenuItem"
        Me.Hand5ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.Hand5ToolStripMenuItem.Text = "Hand 5"
        '
        'DeckZoneToolStripMenuItem
        '
        Me.DeckZoneToolStripMenuItem.Name = "DeckZoneToolStripMenuItem"
        Me.DeckZoneToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.DeckZoneToolStripMenuItem.Text = "Main Deck"
        '
        'GraveyardToolStripMenuItem
        '
        Me.GraveyardToolStripMenuItem.Name = "GraveyardToolStripMenuItem"
        Me.GraveyardToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GraveyardToolStripMenuItem.Text = "Graveyard"
        '
        'BanishedToolStripMenuItem
        '
        Me.BanishedToolStripMenuItem.Name = "BanishedToolStripMenuItem"
        Me.BanishedToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.BanishedToolStripMenuItem.Text = "Banished"
        '
        'ExtraDeckToolStripMenuItem1
        '
        Me.ExtraDeckToolStripMenuItem1.Name = "ExtraDeckToolStripMenuItem1"
        Me.ExtraDeckToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.ExtraDeckToolStripMenuItem1.Text = "Extra Deck"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem8, Me.ToolStripMenuItem19, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripMenuItem17, Me.ToolStripMenuItem18})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem1.Text = "Add to Opponent"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem2.Text = "Monster Zone"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem3.Text = "Monster 1"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem4.Text = "Monster 2"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem5.Text = "Monster 3"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem6.Text = "Monster 4"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem7.Text = "Monster 5"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12, Me.ToolStripMenuItem13, Me.ToolStripMenuItem14})
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem8.Text = "Spell Zone"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem9.Text = "Spell 1"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem10.Text = "Spell 2"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem11.Text = "Spell 3"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem12.Text = "Spell 4"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem13.Text = "Spell 5"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem14.Text = "Field Spell"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Hand1ToolStripMenuItem1, Me.Hand2ToolStripMenuItem1, Me.Hand3ToolStripMenuItem1, Me.Hand4ToolStripMenuItem1, Me.Hand5ToolStripMenuItem1})
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem19.Text = "Hand"
        '
        'Hand1ToolStripMenuItem1
        '
        Me.Hand1ToolStripMenuItem1.Name = "Hand1ToolStripMenuItem1"
        Me.Hand1ToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.Hand1ToolStripMenuItem1.Text = "Hand 1"
        '
        'Hand2ToolStripMenuItem1
        '
        Me.Hand2ToolStripMenuItem1.Name = "Hand2ToolStripMenuItem1"
        Me.Hand2ToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.Hand2ToolStripMenuItem1.Text = "Hand 2"
        '
        'Hand3ToolStripMenuItem1
        '
        Me.Hand3ToolStripMenuItem1.Name = "Hand3ToolStripMenuItem1"
        Me.Hand3ToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.Hand3ToolStripMenuItem1.Text = "Hand 3"
        '
        'Hand4ToolStripMenuItem1
        '
        Me.Hand4ToolStripMenuItem1.Name = "Hand4ToolStripMenuItem1"
        Me.Hand4ToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.Hand4ToolStripMenuItem1.Text = "Hand 4"
        '
        'Hand5ToolStripMenuItem1
        '
        Me.Hand5ToolStripMenuItem1.Name = "Hand5ToolStripMenuItem1"
        Me.Hand5ToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.Hand5ToolStripMenuItem1.Text = "Hand 5"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem15.Text = "Main Deck"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem16.Text = "Graveyard"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem17.Text = "Banished"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem18.Text = "Extra Deck"
        '
        'RemoveFromPlayerToolStripMenuItem
        '
        Me.RemoveFromPlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainDeckToolStripMenuItem, Me.GraveyardToolStripMenuItem1, Me.BanishedToolStripMenuItem1, Me.ExtraDeckToolStripMenuItem})
        Me.RemoveFromPlayerToolStripMenuItem.Name = "RemoveFromPlayerToolStripMenuItem"
        Me.RemoveFromPlayerToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RemoveFromPlayerToolStripMenuItem.Text = "Remove from Player"
        '
        'MainDeckToolStripMenuItem
        '
        Me.MainDeckToolStripMenuItem.Name = "MainDeckToolStripMenuItem"
        Me.MainDeckToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.MainDeckToolStripMenuItem.Text = "Main Deck"
        '
        'GraveyardToolStripMenuItem1
        '
        Me.GraveyardToolStripMenuItem1.Name = "GraveyardToolStripMenuItem1"
        Me.GraveyardToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.GraveyardToolStripMenuItem1.Text = "Graveyard"
        '
        'BanishedToolStripMenuItem1
        '
        Me.BanishedToolStripMenuItem1.Name = "BanishedToolStripMenuItem1"
        Me.BanishedToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.BanishedToolStripMenuItem1.Text = "Banished"
        '
        'ExtraDeckToolStripMenuItem
        '
        Me.ExtraDeckToolStripMenuItem.Name = "ExtraDeckToolStripMenuItem"
        Me.ExtraDeckToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExtraDeckToolStripMenuItem.Text = "Extra Deck"
        '
        'RemoveFromOpponentToolStripMenuItem
        '
        Me.RemoveFromOpponentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainDeckToolStripMenuItem1, Me.GraveyardToolStripMenuItem2, Me.BanishedToolStripMenuItem2, Me.ExtraDeckToolStripMenuItem2})
        Me.RemoveFromOpponentToolStripMenuItem.Name = "RemoveFromOpponentToolStripMenuItem"
        Me.RemoveFromOpponentToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RemoveFromOpponentToolStripMenuItem.Text = "Remove from Opponent"
        '
        'MainDeckToolStripMenuItem1
        '
        Me.MainDeckToolStripMenuItem1.Name = "MainDeckToolStripMenuItem1"
        Me.MainDeckToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.MainDeckToolStripMenuItem1.Text = "Main Deck"
        '
        'GraveyardToolStripMenuItem2
        '
        Me.GraveyardToolStripMenuItem2.Name = "GraveyardToolStripMenuItem2"
        Me.GraveyardToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
        Me.GraveyardToolStripMenuItem2.Text = "Graveyard"
        '
        'BanishedToolStripMenuItem2
        '
        Me.BanishedToolStripMenuItem2.Name = "BanishedToolStripMenuItem2"
        Me.BanishedToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
        Me.BanishedToolStripMenuItem2.Text = "Banished"
        '
        'ExtraDeckToolStripMenuItem2
        '
        Me.ExtraDeckToolStripMenuItem2.Name = "ExtraDeckToolStripMenuItem2"
        Me.ExtraDeckToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
        Me.ExtraDeckToolStripMenuItem2.Text = "Extra Deck"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 485)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextosDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(DescrpLabel)
        Me.Controls.Add(Me.DescrpTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DatainfoBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "CardDatabaseTest"
        CType(Me.CardsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatainfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatainfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatainfoBindingNavigator.ResumeLayout(False)
        Me.DatainfoBindingNavigator.PerformLayout()
        CType(Me.TextosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CardsDataSet1 As YGOPROEditor.cardsDataSet1
    Friend WithEvents DatainfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatainfoTableAdapter As YGOPROEditor.cardsDataSet1TableAdapters.datainfoTableAdapter
    Friend WithEvents TableAdapterManager As YGOPROEditor.cardsDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DatainfoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextosTableAdapter As YGOPROEditor.cardsDataSet1TableAdapters.textosTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonsterZoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Monster1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Monster2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Monster3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Monster4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Monster5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpellZoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Spell1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Spell2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Spell3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Spell4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Spell5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FieldSpellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeckZoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraveyardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BanishedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtraDeckToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand1ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand2ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand3ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand4ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hand5ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFromPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainDeckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraveyardToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BanishedToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtraDeckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFromOpponentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainDeckToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraveyardToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BanishedToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtraDeckToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
