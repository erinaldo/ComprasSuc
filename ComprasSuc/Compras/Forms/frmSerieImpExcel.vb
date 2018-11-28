Imports Microsoft.Office.Interop

Public Class frmSerieImpExcel
    Inherits System.Windows.Forms.Form

    Private moDataSetExcel As DataSet
    Private mstrRutaExcel As String

    Private moDataSet As DataSet
    Private moDataTable As DataTable

    Private moDataSetErrores As DataSet
    Private moDataTableErrores As DataTable
  
    Private mboolError As Boolean
    Private mboolCheckError As Boolean

    Private moLista As Queue
    Private mboolChanged As Boolean

    WriteOnly Property DataObject() As DataSet
        Set(ByVal Value As DataSet)
            moDataSetExcel = Value
        End Set
    End Property

    ReadOnly Property Changed() As Boolean
        Get
            Return mboolChanged
        End Get
    End Property

    WriteOnly Property RutaExcel() As String
        Set(ByVal Value As String)
            mstrRutaExcel = Value
        End Set
    End Property

    ReadOnly Property Lista() As Queue
        Get
            Return moLista
        End Get
    End Property

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
    Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
    Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents Import As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Import1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents grpImportar As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnRuta As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtHoja As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtRuta As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRuta As System.Windows.Forms.Label
    Friend WithEvents tipInfo As System.Windows.Forms.ToolTip
    Friend WithEvents ofdDialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ilsMain As System.Windows.Forms.ImageList
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
    Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents ViewAll2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Exit3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerieImpExcel))
        Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
        Me.grdMain = New Janus.Windows.GridEX.GridEX
        Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
        Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.Import1 = New Janus.Windows.UI.CommandBars.UICommand("Import")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
        Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
        Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
        Me.Exit3 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
        Me.Import = New Janus.Windows.UI.CommandBars.UICommand("Import")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
        Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
        Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
        Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
        Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
        Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
        Me.grpImportar = New Janus.Windows.EditControls.UIGroupBox
        Me.btnImportar = New Janus.Windows.EditControls.UIButton
        Me.btnRuta = New Janus.Windows.EditControls.UIButton
        Me.txtHoja = New Janus.Windows.GridEX.EditControls.EditBox
        Me.txtRuta = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblRuta = New System.Windows.Forms.Label
        Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.ofdDialogo = New System.Windows.Forms.OpenFileDialog
        Me.tipInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExplorerBarContainerControl4.SuspendLayout()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopRebar1.SuspendLayout()
        CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiBackground.SuspendLayout()
        CType(Me.grpImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImportar.SuspendLayout()
        CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ebrMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExplorerBarContainerControl4
        '
        Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExplorerBarContainerControl4.Controls.Add(Me.grdMain)
        Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
        Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
        Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(720, 323)
        Me.ExplorerBarContainerControl4.TabIndex = 1
        '
        'grdMain
        '
        Me.grdMain.AllowCardSizing = False
        Me.grdMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMain.AlternatingColors = True
        Me.grdMain.AutomaticSort = False
        Me.grdMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdMain.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMain.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMain.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdMain.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMain.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdMain.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grdMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grdMain.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMain.GroupByBoxVisible = False
        Me.grdMain.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
        Me.grdMain.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMain.Location = New System.Drawing.Point(0, 0)
        Me.grdMain.Name = "grdMain"
        Me.grdMain.RecordNavigator = True
        Me.grdMain.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMain.SelectedInactiveFormatStyle.Blend = 0.0!
        Me.grdMain.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.grdMain.Size = New System.Drawing.Size(720, 323)
        Me.grdMain.TabIndex = 3
        Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ilsMain
        '
        Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsMain.Images.SetKeyName(0, "")
        Me.ilsMain.Images.SetKeyName(1, "")
        Me.ilsMain.Images.SetKeyName(2, "")
        Me.ilsMain.Images.SetKeyName(3, "")
        Me.ilsMain.Images.SetKeyName(4, "")
        Me.ilsMain.Images.SetKeyName(5, "save16_h.ico")
        Me.ilsMain.Images.SetKeyName(6, "Report Check.ico")
        '
        'cdmMain
        '
        Me.cdmMain.AllowMerge = False
        Me.cdmMain.BottomRebar = Me.BottomRebar1
        Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ViewAll2, Me.Exit3, Me.Import})
        Me.cdmMain.ContainerControl = Me
        Me.cdmMain.Id = New System.Guid("55df5f76-479b-4f4e-8e69-68c99cb73b74")
        Me.cdmMain.ImageList = Me.ilsMain
        Me.cdmMain.LeftRebar = Me.LeftRebar1
        Me.cdmMain.RightRebar = Me.RightRebar1
        Me.cdmMain.TopRebar = Me.TopRebar1
        Me.cdmMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.cdmMain
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'UiCommandBar1
        '
        Me.UiCommandBar1.CommandManager = Me.cdmMain
        Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Import1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.Exit1})
        Me.UiCommandBar1.Key = "tbrMain"
        Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.UiCommandBar1.Name = "UiCommandBar1"
        Me.UiCommandBar1.RowIndex = 0
        Me.UiCommandBar1.Size = New System.Drawing.Size(244, 28)
        Me.UiCommandBar1.Text = "tbrMain"
        '
        'Import1
        '
        Me.Import1.Key = "Import"
        Me.Import1.Name = "Import1"
        '
        'Separator1
        '
        Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator1.Key = "Separator"
        Me.Separator1.Name = "Separator1"
        '
        'ViewAll1
        '
        Me.ViewAll1.Key = "ViewAll"
        Me.ViewAll1.Name = "ViewAll1"
        '
        'Separator2
        '
        Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator2.Key = "Separator"
        Me.Separator2.Name = "Separator2"
        '
        'Exit1
        '
        Me.Exit1.Key = "Exit"
        Me.Exit1.Name = "Exit1"
        '
        'ViewAll2
        '
        Me.ViewAll2.ImageIndex = 2
        Me.ViewAll2.Key = "ViewAll"
        Me.ViewAll2.Name = "ViewAll2"
        Me.ViewAll2.Text = "Ver Todos"
        '
        'Exit3
        '
        Me.Exit3.ImageIndex = 3
        Me.Exit3.Key = "Exit"
        Me.Exit3.Name = "Exit3"
        Me.Exit3.Text = "Salir"
        '
        'Import
        '
        Me.Import.ImageIndex = 5
        Me.Import.Key = "Import"
        Me.Import.Name = "Import"
        Me.Import.Text = "Importar"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.cdmMain
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.cdmMain
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.TopRebar1.CommandManager = Me.cdmMain
        Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(752, 28)
        '
        'New2
        '
        Me.New2.ImageIndex = 0
        Me.New2.Key = "New"
        Me.New2.Name = "New2"
        Me.New2.Text = "Nuevo"
        '
        'Edit
        '
        Me.Edit.ImageIndex = 1
        Me.Edit.Key = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Text = "Editar"
        '
        'Delete
        '
        Me.Delete.ImageIndex = 2
        Me.Delete.Key = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Text = "Eliminar"
        '
        'Print
        '
        Me.Print.ImageIndex = 4
        Me.Print.Key = "Print"
        Me.Print.Name = "Print"
        Me.Print.Text = "Imprimir"
        '
        'Exit2
        '
        Me.Exit2.ImageIndex = 5
        Me.Exit2.Key = "Exit"
        Me.Exit2.Name = "Exit2"
        Me.Exit2.Text = "Salir"
        '
        'uiBackground
        '
        Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.uiBackground.Controls.Add(Me.grpImportar)
        Me.uiBackground.Controls.Add(Me.ebrMain)
        Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
        Me.uiBackground.Location = New System.Drawing.Point(0, 28)
        Me.uiBackground.Name = "uiBackground"
        Me.uiBackground.Size = New System.Drawing.Size(752, 418)
        Me.uiBackground.TabIndex = 5
        Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'grpImportar
        '
        Me.grpImportar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpImportar.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grpImportar.Controls.Add(Me.btnImportar)
        Me.grpImportar.Controls.Add(Me.btnRuta)
        Me.grpImportar.Controls.Add(Me.txtHoja)
        Me.grpImportar.Controls.Add(Me.txtRuta)
        Me.grpImportar.Controls.Add(Me.Label4)
        Me.grpImportar.Controls.Add(Me.lblRuta)
        Me.grpImportar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpImportar.Location = New System.Drawing.Point(8, 4)
        Me.grpImportar.Name = "grpImportar"
        Me.grpImportar.Size = New System.Drawing.Size(736, 46)
        Me.grpImportar.TabIndex = 162
        Me.grpImportar.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'btnImportar
        '
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ImageIndex = 0
        Me.btnImportar.ImageList = Me.ilsMain
        Me.btnImportar.Location = New System.Drawing.Point(680, 16)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(19, 20)
        Me.btnImportar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnImportar.TabIndex = 172
        Me.btnImportar.TabStop = False
        Me.btnImportar.Tag = "Ruta"
        Me.btnImportar.ToolTipText = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'btnRuta
        '
        Me.btnRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuta.ImageIndex = 2
        Me.btnRuta.ImageList = Me.ilsMain
        Me.btnRuta.Location = New System.Drawing.Point(398, 17)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(19, 20)
        Me.btnRuta.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnRuta.TabIndex = 2
        Me.btnRuta.TabStop = False
        Me.btnRuta.Tag = "Ruta"
        Me.btnRuta.ToolTipText = "Busca la Ruta de la Hoja de Excel"
        Me.btnRuta.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'txtHoja
        '
        Me.txtHoja.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
        Me.txtHoja.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtHoja.Location = New System.Drawing.Point(525, 17)
        Me.txtHoja.MaxLength = 255
        Me.txtHoja.Name = "txtHoja"
        Me.txtHoja.Size = New System.Drawing.Size(143, 20)
        Me.txtHoja.TabIndex = 3
        Me.txtHoja.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.tipInfo.SetToolTip(Me.txtHoja, "Presione F2 para Seleccionar una Hoja diferente del Excel")
        Me.txtHoja.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtRuta
        '
        Me.txtRuta.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtRuta.Location = New System.Drawing.Point(76, 17)
        Me.txtRuta.MaxLength = 255
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(320, 20)
        Me.txtRuta.TabIndex = 1
        Me.txtRuta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtRuta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(426, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 171
        Me.Label4.Text = "Nombre de Hoja"
        '
        'lblRuta
        '
        Me.lblRuta.BackColor = System.Drawing.Color.Transparent
        Me.lblRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuta.Location = New System.Drawing.Point(8, 20)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(68, 16)
        Me.lblRuta.TabIndex = 168
        Me.lblRuta.Text = "Ruta"
        '
        'ebrMain
        '
        Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
        Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
        ExplorerBarGroup2.Container = True
        ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl4
        ExplorerBarGroup2.ContainerHeight = 324
        ExplorerBarGroup2.Expandable = False
        ExplorerBarGroup2.Key = "Group1"
        Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
        Me.ebrMain.GroupSeparation = 4
        Me.ebrMain.Location = New System.Drawing.Point(8, 56)
        Me.ebrMain.Name = "ebrMain"
        Me.ebrMain.Size = New System.Drawing.Size(736, 356)
        Me.ebrMain.TabIndex = 3
        Me.ebrMain.Text = "ExplorerBar2"
        Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
        Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        '
        'ofdDialogo
        '
        Me.ofdDialogo.Title = "Cargar Pedido de Excel"
        '
        'frmSerieImpExcel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(752, 446)
        Me.Controls.Add(Me.uiBackground)
        Me.Controls.Add(Me.TopRebar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSerieImpExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Ítems a Base de Datos"
        Me.ExplorerBarContainerControl4.ResumeLayout(False)
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopRebar1.ResumeLayout(False)
        CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiBackground.ResumeLayout(False)
        CType(Me.grpImportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImportar.ResumeLayout(False)
        Me.grpImportar.PerformLayout()
        CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ebrMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
        Dim oCursor As Cursor
        oCursor = Me.Cursor
        Me.Cursor = Cursors.WaitCursor

        Select Case e.Command.Key
            Case "Import"
                If DataImport() Then
                    mboolChanged = True
                    Me.Close()
                End If

            Case "ViewAll"
                Call DataViewAll()

            Case "Exit"
                Me.Close()
        End Select

        Me.Cursor = oCursor
    End Sub

    Private Sub frmItemImpExcel_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Call StatusFormDisplay(Me.Name)
    End Sub

    Private Sub frmItemImpExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCursor As Cursor
        oCursor = Me.Cursor
        Me.Cursor = Cursors.WaitCursor

        mboolChanged = False

        Call FormInit()
        Call grdMainClear()

        Call ClearMemory()

        Me.Cursor = oCursor
    End Sub

    Private Sub FormInit()
        Call FormCenter(Me)

        moLista = New Queue
    End Sub

    Private Sub btnRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuta.Click
        BuscarExcel()
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Call DataImportExcel()
    End Sub

    Private Function DataImport() As Boolean
        DataImport = False

        mboolCheckError = False
        Call AddConditionalFormatting()

        Try
            moLista.Clear()
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
                If oRow.Cells("Sel").Value Then
                    moLista.Enqueue(oRow.Cells("CodSerie").Value)
                End If
            Next
            If moLista.Count Then
                If Not ExistenElementError() Then
                    If MessageBox.Show("¿Realmente Quiere Importar la Información Seleccionada?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        DataImport = True
                    End If
                Else
                    MessageBox.Show("Existen Elementos Seleccionados no Validos para Importar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Seleccione al Menos un Registro de la Lista", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Function

    Private Sub frmItemImpExcel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.WindowState <> FormWindowState.Minimized Then
            If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
                If DataImport() Then
                    mboolChanged = True
                    Me.Close()
                End If

            ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmItemImpExcel_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Call ClearMemory()
    End Sub

    Private Sub txtHoja_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoja.ButtonClick
        If txtRuta.Text.Length <> 0 Then
            txtHoja.Text = BuscarHojaExcel(txtRuta.Text, False, txtHoja.Text)
        End If
    End Sub

    Private Function ExistenElementError() As Boolean
        ExistenElementError = False
        For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
            If oRow.Cells("Sel").Value And ToLong(oRow.Cells("Error").Value) > 0 Then
                ExistenElementError = True
                Exit For
            End If
        Next
    End Function

#Region " EXCEL "
    Dim moDataAdapter As System.Data.OleDb.OleDbDataAdapter
    Dim moConnection As System.Data.OleDb.OleDbConnection

    Private Sub BuscarExcel()
        ofdDialogo.DefaultExt = "*.xls*"
        ofdDialogo.Filter = "Excel (Todos) | *.xls*|Excel 2007 (*.xlsx)| *.xlsx|Excel 2003 (*.xls)| *.xls"

        If ofdDialogo.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        txtRuta.Text = ofdDialogo.FileName
        txtHoja.Text = BuscarHojaExcel(txtRuta.Text, True, "")
    End Sub

    Private Function BuscarHojaExcel(ByVal strSource As String, ByVal bool As Boolean, ByVal strHojaOld As String) As String
        Dim frmSeleccion As New frmSeleccionEdit
        Dim queHojas As New List(Of String)
        Dim strSeleccion As String

        BuscarHojaExcel = String.Empty
        strSeleccion = strHojaOld
        If getHojasExcel(strSource, queHojas) Then
            If bool Then
                strSeleccion = queHojas(0)
                bool = IIf(queHojas.Count > 1, True, False)
            Else
                bool = True
            End If

            If bool Then
                With frmSeleccion
                    .TipoSel = .SEL_HOJA_EXCEL
                    .SeleccionDes = strSeleccion
                    .DataObject = queHojas
                    .ShowDialog()

                    If .Changed Then
                        strSeleccion = .SeleccionDes
                    End If

                    frmSeleccion.Dispose()
                End With
            End If
        End If

        BuscarHojaExcel = strSeleccion
    End Function

    Private Function DataImportExcel() As Boolean
        Try
            If Abrir_Excel() Then
                If moDataSetExcel.Tables(0).Rows.Count() > 0 Then
                    mstrRutaExcel = txtRuta.Text
                    Call grdMainLoad()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function

    Private Function Abrir_Excel() As Boolean
        Try
            If ExcelFormCheck() Then 'Validar ruta y hoja
                Dim oExcel As Excel.Application
                If ExcelOpen(oExcel, txtRuta.Text) Then

                    'Creamos un objecto OLEDBConnection con el nombre del archivo seleccionado
                    ' como Data Source
                    moConnection = New System.Data.OleDb.OleDbConnection( _
                          "Provider=Microsoft.ACE.OLEDB.12.0; " & _
                          "Data Source=" & txtRuta.Text.Trim & "; Extended Properties=""Excel 12.0 Xml; HDR=YES; IMEX=2"";")

                    '* Si queremos seleccionar toda la hoja solo especificamos [Sheet1$]
                    moDataAdapter = New System.Data.OleDb.OleDbDataAdapter( _
                         "select * from [" & txtHoja.Text & "$]  ", moConnection)
                    'where [Sheet1$A4] = 'Aruba'

                    moDataSetExcel = New System.Data.DataSet
                    moDataAdapter.Fill(moDataSetExcel)
                    moConnection.Close()

                    Call ExcelKill(oExcel)

                    Return True

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function

    Private Function ExcelFormCheck() As Boolean
        Dim strMsg As String = String.Empty

        If txtRuta.Text.Length = 0 Then
            strMsg &= "Busque y Seleccione la Ruta del Excel" & vbCrLf
        End If

        If txtHoja.Text.Length = 0 Then
            strMsg &= "Escriba el nombre de la Hoja" & vbCrLf
        End If

        If strMsg.Trim <> String.Empty Then
            Throw New Exception(strMsg)
            ExcelFormCheck = False
        Else
            ExcelFormCheck = True
        End If
    End Function

    Private Sub grdMainLoad()
        Dim oRowAux As DataRow
        Dim lngNro As Long
        mboolError = False
        mboolCheckError = False
        Try
            Call DataViewAll()
            Call moDataSetInit()

            lngNro = 0
            For Each oRow As DataRow In moDataSetExcel.Tables(0).Rows
                lngNro = lngNro + 1
                oRowAux = GetRow(oRow)

                If Not oRowAux Is Nothing Then
                    moDataTable.Rows.Add(oRowAux)
                End If
            Next

            Call grdMainErrorLoad()

            grdMain.DataSource = moDataSet.Tables(0).DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()

        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub grdMainErrorLoad()
        Dim oRow As DataRow
        Dim strError As String
        Dim strErrorCol As String
        Dim inPosError As Long

        Dim boolNumerico As Boolean
        Dim lngCantPed As Long

        lngCantPed = 0

        For Each oRow In moDataSet.Tables("ExcelCodSerie").Rows
            strError = ""
            strErrorCol = ""
            boolNumerico = True


            Call RowEditItem(oRow, strError, strErrorCol, boolNumerico)

            If strError.Length > 0 Then
                mboolError = True
                oRow("Error") = 1
            End If

            oRow("ErrorDes") = strError
            oRow("ErrorColumna") = strErrorCol
        Next

    End Sub
#End Region

#Region " DETALLE "
#Region " DataSet Detalle "
    Private Sub moDataSetInit()
        moDataSet = New DataSet("Tablas")
        moDataTable = moDataSet.Tables.Add("ExcelCodSerie")

        moDataTable.Columns.Add("Sel", Type.GetType("System.String"))
        moDataTable.Columns.Add("CodSerie", Type.GetType("System.String"))

        moDataTable.Columns.Add("Error", Type.GetType("System.Int32"))
        moDataTable.Columns.Add("ErrorDes", Type.GetType("System.String"))
        moDataTable.Columns.Add("ErrorSave", Type.GetType("System.String"))
        moDataTable.Columns.Add("ErrorColumna", Type.GetType("System.String"))
    End Sub

    Private Function GetRow(ByVal oDataRow As DataRow) As DataRow
        Dim oRow As DataRow
        oRow = moDataTable.NewRow

        If Not IsDBNull(oDataRow(0)) And ToStr(oDataRow(0)).Trim.Length > 0 Then
            oRow("Sel") = 0
            oRow("CodSerie") = ToStr(oDataRow(0))
            oRow("Error") = 0
            oRow("ErrorDes") = ""
            oRow("ErrorSave") = ""
            oRow("ErrorColumna") = ""
            Return oRow
        Else
            Return Nothing
        End If
    End Function

    Private Sub RowEditItem(ByRef oRow As DataRow, ByRef strError As String, ByRef strErrorCol As String, ByRef boolNumerico As Boolean)
        If ToStr(oRow("CodSerie")).Length <= 0 Or ToStr(oRow("CodSerie")).Length > 50 Then
            strError = strError & "-Nro. de Serie no Valido, "
            strErrorCol &= ", CodSerie "
        End If
    End Sub
#End Region

#Region " Grid Detalle "
    Private Sub grdMainClear()
        Call moDataSetInit()

        mboolError = False
        mboolCheckError = False

        grdMain.DataSource = moDataSet.Tables(0).DefaultView
        grdMain.RetrieveStructure()
        Call grdMainInit()
    End Sub

    Private Sub grdMainInit()
        With grdMain
            ebrMain.Groups(0).Text = "Item -- Excel = " & mstrRutaExcel
            .RootTable.HeaderLines = 3

            .RootTable.Columns("Sel").Width = 40
            .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Sel").ActAsSelector = True

            .RootTable.Columns("CodSerie").Caption = "Código Serie" & vbCrLf & "[ F ]"
            .RootTable.Columns("CodSerie").Width = 120
            .RootTable.Columns("CodSerie").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CodSerie").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("CodSerie").CellStyle.FontBold = Janus.Windows.GridEX.TriState.False

            .RootTable.Columns("Error").Visible = False

            .RootTable.Columns("ErrorDes").Caption = "Descripción Errores"
            .RootTable.Columns("ErrorDes").Width = 550
            .RootTable.Columns("ErrorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ErrorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("ErrorDes").Visible = mboolError

            .RootTable.Columns("ErrorSave").Caption = "Check Errores"
            .RootTable.Columns("ErrorSave").Width = 550
            .RootTable.Columns("ErrorSave").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ErrorSave").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("ErrorSave").Visible = False

            .RootTable.Columns("ErrorColumna").Visible = False
        End With

        Call AddConditionalFormatting()
    End Sub

    Private Sub DataViewAll()
        grdMain.RemoveFilters()
    End Sub

    Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
        If e.Control And e.KeyCode = Keys.C Then
            If Not grdMain.CurrentColumn Is Nothing Then
                Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
            End If
        End If
    End Sub

    Private Sub AddConditionalFormatting()
        Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

        fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CodSerie"), Janus.Windows.GridEX.ConditionOperator.Equal, 0)
        fc.FormatStyle.ForeColor = Color.DarkBlue
        grdMain.RootTable.FormatConditions.Add(fc)

        fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("ErrorDes"), Janus.Windows.GridEX.ConditionOperator.NotEqual, "")
        fc.FormatStyle.ForeColor = Color.DarkRed
        grdMain.RootTable.FormatConditions.Add(fc)

        grdMain.RootTable.Columns("ErrorSave").Visible = mboolCheckError

        Dim filterCD As Janus.Windows.GridEX.GridEXFilterCondition
        For Each oRow As Janus.Windows.GridEX.GridEXColumn In grdMain.RootTable.Columns
            filterCD = New Janus.Windows.GridEX.GridEXFilterCondition(grdMain.RootTable.Columns("ErrorColumna"), Janus.Windows.GridEX.ConditionOperator.NotEqual, "")
            filterCD.AddCondition(1, New Janus.Windows.GridEX.GridEXFilterCondition(grdMain.RootTable.Columns("ErrorColumna"), Janus.Windows.GridEX.ConditionOperator.Contains, oRow.Key))

            'fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("ErrorDes"), Janus.Windows.GridEX.ConditionOperator.NotEqual, "")
            'fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("ErrorDes"), Janus.Windows.GridEX.ConditionOperator.NotEqual, "")
            fc = New Janus.Windows.GridEX.GridEXFormatCondition()
            fc.FilterCondition = filterCD
            fc.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
            fc.FormatStyle.ForeColor = Color.Red
            fc.TargetColumn = grdMain.RootTable.Columns(oRow.Key)
            grdMain.RootTable.FormatConditions.Add(fc)
        Next
    End Sub
#End Region
#End Region

#Region "Excel"
    Private Sub txtHoja_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHoja.KeyDown
        If Me.WindowState <> FormWindowState.Minimized Then
            If e.KeyCode = Keys.F2 Then
                If txtRuta.Text.Length <> 0 Then
                    txtHoja.Text = BuscarHojaExcel(txtRuta.Text, False, txtHoja.Text)
                End If
            End If
        End If
    End Sub
#End Region

End Class
