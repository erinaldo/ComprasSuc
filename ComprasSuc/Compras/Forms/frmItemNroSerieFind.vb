Public Class frmItemNroSerieFind
   Inherits System.Windows.Forms.Form

   Private moItemNroSerie As clsItemNroSerie
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngAlmacenId As Long
   Private mlngItemId As Long
   Private mlngItemLoteId As Long
   Private mlngNotaId As Long
   Private mlngDocumentoDetId As Long

   Private mlstNroSeries As New Queue()

   Private mboolSelecCheck As Boolean
   Private mlngTipoFind As Long
   Public Const FIND_PEND_SALIDA As Byte = 1
   Public Const FIND_DEV_SALIDA As Byte = 2
   Public Const FIND_DEV_ENTRADA As Byte = 3

   Private mlngTipoItemId As Long
   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdVen As Long
   Private mlngMonedaIdCos As Long
   Private mdecCantidadMin As Decimal
   Private mdecCantidadMax As Decimal
   Private mboolControlLote As Boolean
   Private mboolControlSerie As Boolean
   Private mstrUbicacion As String
   Private mboolEditarPrecio As Boolean
   Private mdecTipoTasaMonto As Decimal
   Private mlngTipoTasaId As Long

   Private mstrSepDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Private mlngID As Long

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property GestionId() As Long
      Get
         Return mlngGestionId
      End Get

      Set(ByVal Value As Long)
         mlngGestionId = Value
      End Set
   End Property

   Property AlmacenId() As Long
      Get
         Return mlngAlmacenId
      End Get

      Set(ByVal Value As Long)
         mlngAlmacenId = Value
      End Set
   End Property

   Property ItemId() As Long
      Get
         Return mlngItemId
      End Get

      Set(ByVal Value As Long)
         mlngItemId = Value
      End Set
   End Property

   Property ItemLoteId() As Long
      Get
         Return mlngItemLoteId
      End Get

      Set(ByVal Value As Long)
         mlngItemLoteId = Value
      End Set
   End Property

   Property NotaId() As Long
      Get
         Return mlngNotaId
      End Get

      Set(ByVal Value As Long)
         mlngNotaId = Value
      End Set
   End Property

   Property DocumentoDetId() As Long
      Get
         Return mlngDocumentoDetId
      End Get

      Set(ByVal Value As Long)
         mlngDocumentoDetId = Value
      End Set
   End Property

   ReadOnly Property NroSeries() As Queue
      Get
         Return mlstNroSeries
      End Get
   End Property

   Property SelecCheck() As Boolean
      Get
         Return mboolSelecCheck
      End Get

      Set(ByVal Value As Boolean)
         mboolSelecCheck = Value
      End Set
   End Property

   Property TipoFind() As Long
      Get
         Return mlngTipoFind
      End Get

      Set(ByVal Value As Long)
         mlngTipoFind = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
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
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ViewAll2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents Check As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Check1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Consultar As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemNroSerieFind))
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Check1 = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit3 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Check = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Consultar = New Janus.Windows.UI.CommandBars.UICommand("Consultar")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(718, 244)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdMain
      '
      Me.grdMain.AllowCardSizing = False
      Me.grdMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdMain.AlternatingColors = True
      Me.grdMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdMain.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdMain.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
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
      Me.grdMain.Size = New System.Drawing.Size(718, 244)
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Refrescar, Me.ViewAll2, Me.Exit3, Me.Check, Me.Consultar})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Check1, Me.Separator5, Me.Refrescar1, Me.Separator6, Me.ViewAll1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(348, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Check1
      '
      Me.Check1.Key = "Check"
      Me.Check1.Name = "Check1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'ViewAll1
      '
      Me.ViewAll1.Key = "ViewAll"
      Me.ViewAll1.Name = "ViewAll1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 1
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
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
      'Check
      '
      Me.Check.ImageIndex = 0
      Me.Check.Key = "Check"
      Me.Check.Name = "Check"
      Me.Check.Text = "Seleccionar"
      '
      'Consultar
      '
      Me.Consultar.ImageIndex = 4
      Me.Consultar.Key = "Consultar"
      Me.Consultar.Name = "Consultar"
      Me.Consultar.Text = "Consultar"
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
      Me.TopRebar1.Size = New System.Drawing.Size(742, 28)
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
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(742, 284)
      Me.uiBackground.TabIndex = 5
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 245
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 4)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(734, 277)
      Me.ebrMain.TabIndex = 1
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow})
      '
      'mnuShow
      '
      Me.mnuShow.Index = 0
      Me.mnuShow.Text = "Consultar"
      '
      'frmItemNroSerieFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(742, 312)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MinimizeBox = False
      Me.Name = "frmItemNroSerieFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Buscar Nro de Serie"
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

         Case "Check"
            Call SeleccionarItem()

         Case "Refrescar"
            Call grdMainLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmItemNroSerieFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmItemNroSerieFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True
      mboolChanged = False

      Call FormInit()
      Call ComboLoad()

      Call grdMainLoad()

      grdMain.Select()
      grdMain.Col = IIf(mlngTipoFind = FIND_DEV_SALIDA, 14, 12)
      ''grdMain.Row = Janus.Windows.GridEX.GridEX.filterRowPosition
      grdMain.Row = grdMain.filterRowPosition

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad()

      Try
         With moItemNroSerie

            If mlngTipoFind = FIND_PEND_SALIDA Then
               .SelectFilter = clsItemNroSerie.SelectFilters.GridFind
               .WhereFilter = clsItemNroSerie.WhereFilters.GridSalida
               .OrderByFilter = clsItemNroSerie.OrderByFilters.GridFind
               .ItemLoteId = mlngItemLoteId
               .NotaIdSal = mlngNotaId

            ElseIf mlngTipoFind = FIND_DEV_SALIDA Then
               .SelectFilter = clsItemNroSerie.SelectFilters.GridDevSalida
               .WhereFilter = clsItemNroSerie.WhereFilters.GridDevSalida
               .OrderByFilter = clsItemNroSerie.OrderByFilters.GridDevSalida
               ''.DocumentoId = mlngDocumentoId
               .ItemLoteIdSal = mlngItemLoteId
               .NotaIdSal = mlngNotaId

            ElseIf mlngTipoFind = FIND_DEV_ENTRADA Then
               .SelectFilter = clsItemNroSerie.SelectFilters.GridFind
               .WhereFilter = clsItemNroSerie.WhereFilters.GridDevEntrada
               .OrderByFilter = clsItemNroSerie.OrderByFilters.GridFind
               .ItemLoteId = mlngItemLoteId
               .NotaIdEnt = mlngNotaId

            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .AlmacenId = mlngAlmacenId
            .ItemId = mlngItemId

            If .Open() Then
               Call ItemParametro(mlngItemId)

               If TipoFind = FIND_DEV_SALIDA Then
                  isMismoDocumentoDetId(.DataSet.Tables(.TableName))
               End If

               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub isMismoDocumentoDetId(ByVal oDataTable As DataTable)
      Dim oRow As DataRow

      For Each oRow In oDataTable.Rows
         oRow("isDocumentoDetId") = ToBoolean(IIf(oRow("DocumentoDetId") = mlngDocumentoDetId, True, False))
      Next
   End Sub

   Private Sub SeleccionarItem()

      If grdMain.RowCount > 0 Then
         mlstNroSeries.Clear()
         Dim strMsg = String.Empty

         If Not mboolSelecCheck Then '' Una seleccion
            If (grdMain.GetRow.Selected) And Not (ToLong(grdMain.GetValue("ItemNroSerieId")) > 0) Then
               grdMain.Row = grdMain.FirstRow
            End If

            If mlngTipoFind = FIND_DEV_SALIDA Then
               If ToLong(grdMain.GetValue("DocumentoDetId")) <> mlngDocumentoDetId Then
                  strMsg = "* La Serie seleccionada, no pertenece a la Salida del Ítem" & vbCrLf
               End If
            End If
         Else
            If grdMain.GetCheckedRows.Length > 0 Then
               For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  If oRow.Cells("Sel").Value Then

                     If mlngTipoFind = FIND_DEV_SALIDA Then
                        If ToLong(oRow.Cells("DocumentoDetId").Value) <> mlngDocumentoDetId Then
                           strMsg = "* Algun(as) Series seleccionadas, no pertenece(n) a la Salida del Ítem" & vbCrLf
                        End If
                     End If

                     mlstNroSeries.Enqueue(ToLong(oRow.Cells("ItemNroSerieId").Value))

                  End If
               Next
            Else
               MessageBox.Show("Debe Seleccionar al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If

         If (strMsg.Trim <> String.Empty) Then
            If MessageBox.Show(strMsg & vbCrLf & "¿Quiere continuar con la Seleccion?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
               Exit Sub
            End If
         End If

         mlngID = ToLong(grdMain.GetValue("ItemNroSerieId"))
         mboolChanged = True
         Me.Close()

      Else
         MessageBox.Show("Debe Seleccionar al menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("ItemNroSerieId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      ''If Me.WindowState <> FormWindowState.Minimized Then
      ''   Me.Location = New Point(20, Me.Location.Y)
      ''   Me.Width = gfrmMain.ClientSize.Width - 40
      ''End If

      Call FormCenter(Me)

      moItemNroSerie = New clsItemNroSerie(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()

   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = " Nros de Series - Resultado de Búsqueda "
         .ContextMenu = mnuMain

         If Not mboolSelecCheck Then
            .RootTable.Columns("Sel").Visible = False
         End If

         .RootTable.Columns("Sel").Caption = "Sel"
         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("ItemNroSerieId").Visible = False
         .RootTable.Columns("EmpresaId").Visible = False
         .RootTable.Columns("GestionId").Visible = False
         .RootTable.Columns("AlmacenId").Visible = False
         .RootTable.Columns("TipoNotaIdEnt").Visible = False
         .RootTable.Columns("NotaIdEnt").Visible = False
         .RootTable.Columns("TipoNotaIdSal").Visible = False
         .RootTable.Columns("NotaIdSal").Visible = False
         .RootTable.Columns("ItemLoteIdSal").Visible = False

         .RootTable.Columns("ItemId").Visible = False
         .RootTable.Columns("ItemDes").Caption = "Item"
         .RootTable.Columns("ItemDes").Width = 100
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ItemDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("ItemDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         If (mlngTipoFind <> FIND_DEV_SALIDA) Then
            .RootTable.Columns("ItemLoteId").Visible = False
            .RootTable.Columns("ItemLoteIdSal").Visible = False

            .RootTable.Columns("ItemLoteDes").Visible = mboolControlLote
            .RootTable.Columns("ItemLoteDes").Caption = "Lote"
            .RootTable.Columns("ItemLoteDes").Width = 150
            .RootTable.Columns("ItemLoteDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ItemLoteDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("ItemLoteDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
            .RootTable.Columns("ItemLoteDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         Else
            .RootTable.Columns("ItemLoteId").Visible = False
            .RootTable.Columns("ItemLoteIdSal").Visible = False

            .RootTable.Columns("ItemLoteDes").Visible = False
            .RootTable.Columns("ItemLoteDes").Caption = "Lote"
            .RootTable.Columns("ItemLoteDes").Width = 150
            .RootTable.Columns("ItemLoteDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ItemLoteDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("ItemLoteDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
            .RootTable.Columns("ItemLoteDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

            .RootTable.Columns("ItemLoteDesSal").Visible = mboolControlLote
            .RootTable.Columns("ItemLoteDesSal").Caption = "Lote"
            .RootTable.Columns("ItemLoteDesSal").Width = 150
            .RootTable.Columns("ItemLoteDesSal").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ItemLoteDesSal").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("ItemLoteDesSal").EditType = Janus.Windows.GridEX.EditType.NoEdit
            .RootTable.Columns("ItemLoteDesSal").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox
         End If

         .RootTable.Columns("ItemNroSerieCod").Caption = "Código Serie"
         .RootTable.Columns("ItemNroSerieCod").Width = 200
         .RootTable.Columns("ItemNroSerieCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemNroSerieCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AppId").Visible = False
         .RootTable.Columns("TipoDocumentoId").Visible = False
         .RootTable.Columns("DocumentoId").Visible = False
         .RootTable.Columns("DocumentoDetId").Visible = False

         .RootTable.Columns("isDocumentoDetId").Visible = False
         .RootTable.Columns("isDocumentoDetId").Caption = " "
         .RootTable.Columns("isDocumentoDetId").Width = 50
         .RootTable.Columns("isDocumentoDetId").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("isDocumentoDetId").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("isDocumentoDetId").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("isDocumentoDetId").FilterEditType = Janus.Windows.GridEX.FilterEditType.CheckBox

         .RootTable.Columns("EstadoId").Visible = False

      End With
      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      If mlngDocumentoDetId > 0 Then
         fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("DocumentoDetId"), Janus.Windows.GridEX.ConditionOperator.Equal, mlngDocumentoDetId)
         ''fc.FormatStyle.ForeColor = Color.DarkGreen
         fc.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
         grdMain.RootTable.FormatConditions.Add(fc)
      End If
     
   End Sub

   Private Sub grdMainExpander()
      If grdMain.RootTable.Columns("isDocumentoDetId").Visible Then
         grdMain.RootTable.Columns("isDocumentoDetId").Visible = False
         grdMain.RootTable().FilterParentRows = True

         ''Dim grdEXCol As Janus.Windows.GridEX.GridEXColumn = grdMain.RootTable.Columns("LineaId")
         ''Dim grdFilterCond As New Janus.Windows.GridEX.GridEXFilterCondition(grdEXCol, , .)

         ''grdMain.RootTable.FilterCondition = grdFilterCond
      Else
         grdMain.RootTable.Columns("isDocumentoDetId").Visible = True
         grdMain.RootTable().FilterParentRows = True
      End If

   End Sub

   Private Sub ItemParametro(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngTipoItemId = 0
         mlngTipoCosteoId = 0
         mlngMedidaId = 0
         mlngMedidaIdEqui = 0
         mdecMedidaCantEqui = 0
         mlngMonedaIdVen = 0
         mlngMonedaIdCos = 0
         mdecCantidadMin = 0
         mdecCantidadMax = 0
         mboolControlLote = False
         mboolControlSerie = False
         mstrUbicacion = ""
         mlngTipoTasaId = 0
         mdecTipoTasaMonto = 0

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngTipoItemId = ToLong(.TipoItemId)
               mlngTipoCosteoId = ToLong(.TipoCosteoId)
               mlngMedidaId = ToLong(.MedidaId)
               mlngMedidaIdEqui = ToLong(.MedidaIdEqui)
               mdecMedidaCantEqui = ToDecimal(.MedidaCantEqui)
               mlngMonedaIdVen = ToLong(.MonedaIdVen)
               mlngMonedaIdCos = ToLong(.MonedaIdCos)
               mdecCantidadMin = ToDecimal(.CantidadMin)
               mdecCantidadMax = ToDecimal(.CantidadMax)
               mboolControlLote = ToBoolean(.ControlLote)
               mboolControlSerie = ToBoolean(.ControlSerie)
               mstrUbicacion = ToStr(.Ubicacion)
               mlngTipoTasaId = ToLong(.TipoTasaId)
               mdecTipoTasaMonto = ToDecimal(.TipoTasaMonto)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call SeleccionarItem()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmItemNroSerieFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.Return Then
            Call SeleccionarItem()

         ElseIf e.KeyCode = Keys.Menu Then
            'cdmMain.CommandBars.Item("tbrMain").

         ElseIf (e.KeyCode = Keys.Enter) Then
            Call SeleccionarItem()

         ElseIf (e.KeyCode = Keys.F10) Then
            Call grdMainExpander()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmItemNroSerieFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moItemNroSerie.Dispose()
      Call ClearMemory()
   End Sub

End Class
