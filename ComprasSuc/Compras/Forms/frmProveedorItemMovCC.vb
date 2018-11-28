Public Class frmProveedorItemMovCC
   Inherits System.Windows.Forms.Form

   Private moCompraDet As clsCompraDet
   Private moLista As New Queue
   Private moListaItem As New Queue
   Private moListaCC As New Queue

   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMedidaId As Long
   Private mlngMonedaId As Long
   Private mlngVendedorId As Long
   Private mlngCentroCostoId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolOrdenarFecha As Boolean
   Private mboolDetallado As Boolean

   Private mdecCantidad As Decimal
   Private mdecImporte As Decimal
   Private mdecCantidadProv As Decimal
   Private mdecImporteProv As Decimal
   Private mdecCantidadTot As Decimal
   Private mdecImporteTot As Decimal

   Private mdecCantidadCC As Decimal
   Private mdecImporteCC As Decimal

   Private mlngItemTipoCosteoId As Long
   Private mlngItemMedidaId As Long
   Private mlngItemMedidaIdEqui As Long
   Private mdecItemMedidaCantEqui As Decimal

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mboolChanged As Boolean
   Private mboolSelected As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
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

   Property MedidaId() As Long
      Get
         Return mlngMedidaId
      End Get

      Set(ByVal Value As Long)
         mlngMedidaId = Value
      End Set
   End Property

   Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngMonedaId = Value
      End Set
   End Property

   Property VendedorId() As Long
      Get
         Return mlngVendedorId
      End Get

      Set(ByVal Value As Long)
         mlngVendedorId = Value
      End Set
   End Property

   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   Property IntervaloFecha() As Boolean
      Get
         Return mboolIntervaloFecha
      End Get

      Set(ByVal Value As Boolean)
         mboolIntervaloFecha = Value
      End Set
   End Property

   Property FechaIni() As String
      Get
         Return mstrFechaIni
      End Get

      Set(ByVal Value As String)
         mstrFechaIni = Value
      End Set
   End Property

   Property FechaFin() As String
      Get
         Return mstrFechaFin
      End Get

      Set(ByVal Value As String)
         mstrFechaFin = Value
      End Set
   End Property

   Property OrdenarFecha() As Boolean
      Get
         Return mboolOrdenarFecha
      End Get

      Set(ByVal Value As Boolean)
         mboolOrdenarFecha = Value
      End Set
   End Property

   Property Detallado() As Boolean
      Get
         Return mboolDetallado
      End Get

      Set(ByVal Value As Boolean)
         mboolDetallado = Value
      End Set
   End Property

   Property Lista() As Queue
      Get
         Return moLista
      End Get

      Set(ByVal Value As Queue)
         moLista = Value
      End Set
   End Property

   Property ListaItem() As Queue
      Get
         Return moListaItem
      End Get

      Set(ByVal Value As Queue)
         moListaItem = Value
      End Set
   End Property

   Property ListaCC() As Queue
      Get
         Return moListaCC
      End Get

      Set(ByVal Value As Queue)
         moListaCC = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   ReadOnly Property Selected() As Boolean
      Get
         Return mboolSelected
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
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorItemMovCC))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 370)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 370)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 9
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup3.Container = True
      ExplorerBarGroup3.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup3.ContainerHeight = 371
      ExplorerBarGroup3.Expandable = False
      ExplorerBarGroup3.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup3})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 403)
      Me.ebrMain.TabIndex = 2
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
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
      Me.ilsMain.Images.SetKeyName(5, "")
      Me.ilsMain.Images.SetKeyName(6, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("aea013d3-db27-46fd-b9c2-6b48dddfb8f8")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(317, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
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
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Book
      '
      Me.Book.ImageIndex = 6
      Me.Book.Key = "Book"
      Me.Book.Name = "Book"
      Me.Book.Text = "Compra"
      '
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 3
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
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
      'frmProveedorItemMovCC
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmProveedorItemMovCC"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Proveedores a los que se Compró un Ítem"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Book"
            Call frmCompraEditLoad(ToLong(grdMain.GetValue("CompraId")))

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmProveedorItem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmProveedorItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      mboolSelected = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   ''Private Sub grdMainLoad()
   ''   Dim lngProveedorId As Long
   ''   Dim lngItemId As Long
   ''   Dim oRow As DataRow
   ''   Dim boolHeader As Boolean
   ''   Dim strMonedaDes As String

   ''   Try
   ''      Call moDataSetInit()

   ''      mdecCantidadTot = 0
   ''      mdecImporteTot = 0
   ''      strMonedaDes = MonedaDesFind(mlngMonedaId)

   ''      With moCompraDet
   ''         For Each lngItemId In moListaItem
   ''            boolHeader = False
   ''            mdecCantidad = 0
   ''            mdecImporte = 0
   ''            Call ItemParametro(lngItemId)

   ''            For Each lngProveedorId In moLista
   ''               .SelectFilter = clsCompraDet.SelectFilters.ProveedorItemMov

   ''               If mboolIntervaloFecha Then
   ''                  .WhereFilter = clsCompraDet.WhereFilters.ProveedorItemMovFecha
   ''                  .Fecha = mstrFechaIni
   ''                  .LastUpdateDate = mstrFechaFin
   ''               Else
   ''                  .WhereFilter = clsCompraDet.WhereFilters.ProveedorItemMov
   ''               End If

   ''               If mboolOrdenarFecha Then
   ''                  .OrderByFilter = clsCompraDet.OrderByFilters.Fecha
   ''               Else
   ''                  .OrderByFilter = clsCompraDet.OrderByFilters.CompraDetId
   ''               End If

   ''               .EmpresaId = mlngEmpresaId
   ''               .GestionId = mlngGestionId
   ''               .ProveedorId = lngProveedorId
   ''               .CentroCostoIdAct = mlngCentroCostoId
   ''               .ItemId = lngItemId

   ''               If .Open() Then
   ''                  mdecCantidadResu = 0
   ''                  mdecImporteResu = 0

   ''                  For Each oRow In .DataSet.Tables(.TableName).Rows
   ''                     If Not boolHeader Then
   ''                        moDataTable.Rows.Add(GetHeader(lngItemId))
   ''                        boolHeader = True
   ''                     End If

   ''                     If mboolDetallado Then
   ''                        moDataTable.Rows.Add(GetRow(oRow))
   ''                     Else
   ''                        Call GetRow(oRow)
   ''                     End If
   ''                  Next
   ''               End If

   ''               If Not mboolDetallado Then
   ''                  If mdecCantidadResu > 0 Then
   ''                     moDataTable.Rows.Add(GetRowResu(oRow))
   ''                  End If
   ''               End If
   ''            Next

   ''            If boolHeader Then
   ''               moDataTable.Rows.Add(GetRowFooter(strMonedaDes))
   ''               moDataTable.Rows.Add(GetRowNull)
   ''            End If
   ''         Next

   ''         moDataTable.Rows.Add(GetRowFooterTotal(strMonedaDes))
   ''         moDataTable.Rows.Add(GetRowNull)

   ''         grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
   ''         grdMain.RetrieveStructure()
   ''         Call grdMainInit()

   ''         .CloseConection()
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   ''   End Try
   ''End Sub

   Private Sub grdMainLoad()
      Dim lngProveedorId As Long
      Dim lngItemId As Long
      Dim oRow As DataRow
      Dim boolHeader As Boolean
      Dim strMonedaDes As String
      Dim strCentroCostoDes As String
      Dim booProveedor As Boolean

      Try
         Call moDataSetInit()

         mdecCantidadTot = 0
         mdecImporteTot = 0
         strMonedaDes = MonedaDesFind(mlngMonedaId)

         With moCompraDet
            For Each lngItemId In moListaItem
               boolHeader = False
               mdecCantidad = 0
               mdecImporte = 0
               Call ItemParametro(lngItemId)

               For Each lngProveedorId In moLista
                  mdecCantidadProv = 0
                  mdecImporteProv = 0
                  booProveedor = False

                  For Each lngCentroCostoId In moListaCC

                     .SelectFilter = clsCompraDet.SelectFilters.ProveedorItemMov
                     If mboolIntervaloFecha Then
                        .WhereFilter = clsCompraDet.WhereFilters.ProveedorItemMovFecha
                        .Fecha = mstrFechaIni
                        .LastUpdateDate = mstrFechaFin
                     Else
                        .WhereFilter = clsCompraDet.WhereFilters.ProveedorItemMov
                     End If

                     If mboolOrdenarFecha Then
                        .OrderByFilter = clsCompraDet.OrderByFilters.Fecha
                     Else
                        .OrderByFilter = clsCompraDet.OrderByFilters.CompraDetId
                     End If

                     .EmpresaId = mlngEmpresaId
                     .GestionId = mlngGestionId
                     .ProveedorId = lngProveedorId
                     .CentroCostoIdAct = lngCentroCostoId
                     .ItemId = lngItemId

                     If .Open() Then
                        mdecCantidadCC = 0
                        mdecImporteCC = 0

                        strCentroCostoDes = CentroCostoDesFind(lngCentroCostoId)

                        For Each oRow In .DataSet.Tables(.TableName).Rows
                           If Not boolHeader Then
                              moDataTable.Rows.Add(GetHeader(lngItemId))
                              boolHeader = True
                           End If


                           If mboolDetallado Then
                              moDataTable.Rows.Add(GetRow(oRow, strCentroCostoDes))
                              booProveedor = True

                           Else
                              If Not booProveedor Then
                                 moDataTable.Rows.Add(GetHeaderProv(oRow))
                                 booProveedor = True
                              End If

                              Call GetRow(oRow, strCentroCostoDes)
                           End If
                        Next

                        If mdecCantidadCC > 0 Then
                           If mboolDetallado Then
                              moDataTable.Rows.Add(GetRowFooterCC(strCentroCostoDes))
                              moDataTable.Rows.Add(GetRowNull)
                           Else
                              moDataTable.Rows.Add(GetRowFooterCCResu(strCentroCostoDes))
                           End If
                        End If

                     End If

                  Next

                  If booProveedor Then
                     If mboolDetallado Then
                        moDataTable.Rows.RemoveAt(moDataTable.Rows.Count - 1)
                     End If

                     moDataTable.Rows.Add(GetRowFooterProv(strMonedaDes))
                     moDataTable.Rows.Add(GetRowNull)
                  End If

               Next

               If boolHeader Then
                  moDataTable.Rows.RemoveAt(moDataTable.Rows.Count - 1)
                  moDataTable.Rows.Add(GetRowFooter(strMonedaDes))
                  moDataTable.Rows.Add(GetRowNull)
               End If
            Next

            moDataTable.Rows.Add(GetRowFooterTotal(strMonedaDes))
            moDataTable.Rows.Add(GetRowNull)

            grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCompraDet.TableName)

      moDataTable.Columns.Add("CompraId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.DateTime"))
      moDataTable.Columns.Add("CompraNro", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompraOrden", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CentroCostoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Importe", Type.GetType("System.Decimal"))
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow, ByVal strCentroCostoDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraId") = oDataRow("CompraId")
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
      oRow("CompraNro") = oDataRow("CompraNro")
      oRow("CompraOrden") = oDataRow("CompraOrden")
      oRow("ItemId") = oDataRow("ProveedorId")
      oRow("ItemCod") = oDataRow("ProveedorCod")
      oRow("ItemDes") = oDataRow("ProveedorDes")
      oRow("CentroCostoDes") = strCentroCostoDes

      If mlngMedidaId = 1 Then 'Medida Minima del Reporte
         If ToLong(oDataRow("MedidaId")) = mlngItemMedidaId Then
            oRow("MedidaDes") = oDataRow("MedidaDes")
            oRow("Cantidad") = oDataRow("Cantidad")
            oRow("PrecioOrg") = oDataRow("PrecioOrg")
         Else
            oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaId)
            oRow("Cantidad") = oDataRow("Cantidad") * mdecItemMedidaCantEqui
            If oDataRow("PrecioOrg") <> 0 Then oRow("PrecioOrg") = oDataRow("PrecioOrg") / mdecItemMedidaCantEqui
         End If

      ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
         If ToLong(oDataRow("MedidaId")) = mlngItemMedidaIdEqui Then
            oRow("MedidaDes") = oDataRow("MedidaDes")
            oRow("Cantidad") = oDataRow("Cantidad")
            oRow("PrecioOrg") = oDataRow("PrecioOrg")
         Else
            oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaIdEqui)
            If oDataRow("Cantidad") <> 0 Then oRow("Cantidad") = oDataRow("Cantidad") / mdecItemMedidaCantEqui
            oRow("PrecioOrg") = oDataRow("PrecioOrg") * mdecItemMedidaCantEqui
         End If
      End If

      If mlngMonedaId = 1 Then
         If oDataRow("MonedaId") <> mlngMonedaId Then
            oRow("PrecioOrg") *= oDataRow("TipoCambio")
         End If

      ElseIf mlngMonedaId = 2 Then
         If oDataRow("MonedaId") <> mlngMonedaId Then
            oRow("PrecioOrg") /= oDataRow("TipoCambio")
         End If
      End If

      oRow("Importe") = oRow("Cantidad") * oRow("PrecioOrg")

      ''If Not mboolDetallado Then
      ''   mdecCantidadProv += ToDecimal(oRow("Cantidad"))
      ''   mdecImporteProv += ToDecimal(oRow("Importe"))
      ''End If

      mdecCantidadCC += ToDecimal(oRow("Cantidad"))
      mdecImporteCC += ToDecimal(oRow("Importe"))

      mdecCantidadProv += ToDecimal(oRow("Cantidad"))
      mdecImporteProv += ToDecimal(oRow("Importe"))

      mdecCantidad += ToDecimal(oRow("Cantidad"))
      mdecImporte += ToDecimal(oRow("Importe"))

      mdecCantidadTot += ToDecimal(oRow("Cantidad"))
      mdecImporteTot += ToDecimal(oRow("Importe"))

      Return oRow
   End Function

   Private Function GetRowResu(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraId") = 0
      oRow("ItemId") = oDataRow("ProveedorId")
      oRow("ItemCod") = oDataRow("ProveedorCod")
      oRow("ItemDes") = oDataRow("ProveedorDes")

      If mlngMedidaId = 1 Then 'Medida Minima del Reporte
         If ToLong(oDataRow("MedidaId")) = mlngItemMedidaId Then
            oRow("MedidaDes") = oDataRow("MedidaDes")
         Else
            oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaId)
         End If

      ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
         If ToLong(oDataRow("MedidaId")) = mlngItemMedidaIdEqui Then
            oRow("MedidaDes") = oDataRow("MedidaDes")
         Else
            oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaIdEqui)
         End If
      End If

      oRow("Cantidad") = mdecCantidadProv
      oRow("PrecioOrg") = ToDecimal(mdecImporteProv / ToDivByCero(mdecCantidadProv))
      oRow("Importe") = mdecImporteProv

      Return oRow
   End Function

   ''Private Function GetRowResuCC(ByVal oDataRow As DataRow) As DataRow
   ''   Dim oRow As DataRow
   ''   oRow = moDataTable.NewRow

   ''   oRow("CompraId") = 0
   ''   oRow("ItemId") = oDataRow("ProveedorId")
   ''   oRow("ItemCod") = oDataRow("ProveedorCod")
   ''   oRow("ItemDes") = oDataRow("ProveedorDes")

   ''   ''If mlngMedidaId = 1 Then 'Medida Minima del Reporte
   ''   ''   If ToLong(oDataRow("MedidaId")) = mlngItemMedidaId Then
   ''   ''      oRow("MedidaDes") = oDataRow("MedidaDes")
   ''   ''   Else
   ''   ''      oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaId)
   ''   ''   End If

   ''   ''ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
   ''   ''   If ToLong(oDataRow("MedidaId")) = mlngItemMedidaIdEqui Then
   ''   ''      oRow("MedidaDes") = oDataRow("MedidaDes")
   ''   ''   Else
   ''   ''      oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaIdEqui)
   ''   ''   End If
   ''   ''End If

   ''   oRow("Cantidad") = mdecCantidadResu
   ''   oRow("PrecioOrg") = ToDecimal(mdecImporteResu / ToDivByCero(mdecCantidadResu))
   ''   oRow("Importe") = mdecImporteResu

   ''   Return oRow
   ''End Function

   Private Function GetHeader(ByVal lngItemId As Long) As DataRow
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         oRow("CompraId") = -1
         oRow("CompraNro") = "Ítem"

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               oRow("ItemCod") = .ItemCod
               oRow("ItemDes") = .ItemDes
            End If
         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Function

   Private Function GetHeaderProv(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraId") = 0
      oRow("ItemId") = oDataRow("ProveedorId")
      oRow("ItemCod") = oDataRow("ProveedorCod")
      oRow("ItemDes") = oDataRow("ProveedorDes")

      Return oRow
   End Function

   Private Function GetRowFooter(ByVal strMonedaDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraId") = -1
      oRow("ItemDes") = "Total " & strMonedaDes
      oRow("Cantidad") = mdecCantidad
      oRow("Importe") = mdecImporte

      Return oRow
   End Function

   Private Function GetRowFooterProv(ByVal strMonedaDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraId") = 0
      oRow("ItemDes") = "   Total Proveedor " & strMonedaDes
      oRow("Cantidad") = mdecCantidadProv
      oRow("Importe") = mdecImporteProv

      Return oRow
   End Function

   Private Function GetRowFooterCC(ByVal strMonedaDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraId") = -3
      oRow("CentroCostoDes") = "SubTotal " & strMonedaDes
      oRow("Cantidad") = mdecCantidadCC
         oRow("PrecioOrg") = ToDecimal(mdecImporteCC / ToDivByCero(mdecCantidadCC))
         oRow("Importe") = mdecImporteCC

         Return oRow
   End Function

   Private Function GetRowFooterCCResu(ByVal strMonedaDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraId") = -3
      oRow("ItemDes") = "       Centro Costo"
      oRow("CentroCostoDes") = strMonedaDes

      If mlngMedidaId = 1 Then 'Medida Minima del Reporte
         oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaId)
      ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
         oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaIdEqui)
      End If

      oRow("Cantidad") = mdecCantidadCC
      oRow("PrecioOrg") = ToDecimal(mdecImporteCC / ToDivByCero(mdecCantidadCC))
      oRow("Importe") = mdecImporteCC

      Return oRow
   End Function

   Private Function GetRowFooterTotal(ByVal strMonedaDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraId") = -2
      oRow("ItemDes") = "Total General " & strMonedaDes
      oRow("Cantidad") = mdecCantidadTot
      oRow("Importe") = mdecImporteTot

      Return oRow
   End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
   End Function

   Private Function MonedaDesFind(ByVal lngMonedaId As Long) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      Try
         With oMoneda
            .MonedaId = lngMonedaId

            If .FindByPK Then
               MonedaDesFind = ToStr(.MonedaDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMoneda.Dispose()

      End Try
   End Function

   Private Function MedidaDesFind(ByVal lngMedidaId As Long) As String
      Dim oMedida As New clsMedida(clsAppInfo.ConnectString)

      Try
         With oMedida
            .MedidaId = lngMedidaId

            If .FindByPK Then
               MedidaDesFind = ToStr(.MedidaDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMedida.Dispose()

      End Try
   End Function

   Private Function CentroCostoDesFind(ByVal lngCentroCostoId As Long) As String
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)
      CentroCostoDesFind = ""
      Try
         With oCentroCosto
            .CentroCostoId = lngCentroCostoId

            If .FindByPK Then
               CentroCostoDesFind = ToStr(.CentroCostoDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()

      End Try
   End Function

   Private Sub frmCompraEditLoad(ByVal lngCompraId As Long)
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         If lngCompraId > 0 Then
            With oCompra
               .CompraId = lngCompraId

               If .FindByPK Then
                  Dim frm As New frmCompraEdit

                  frm.NewRecord = False
                  frm.Editing = True
                  frm.DataObject = oCompra
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdMainLoad()
                     Call grdMainFindRow(lngCompraId)
                     mboolChanged = True

                  End If
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Número de Compra Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   Private Sub ItemParametro(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngItemTipoCosteoId = 0
         mlngItemMedidaId = 0
         mlngItemMedidaIdEqui = 0
         mdecItemMedidaCantEqui = 0

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngItemTipoCosteoId = .TipoCosteoId
               mlngItemMedidaId = .MedidaId
               mlngItemMedidaIdEqui = .MedidaIdEqui
               mdecItemMedidaCantEqui = .MedidaCantEqui
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Function GetDataView(ByVal oDataTableOrg As DataTable) As System.Data.DataView
      If grdMain.RootTable.FilterApplied Is Nothing Then
         Return oDataTableOrg.DefaultView

      Else
         Dim oDataTable As DataTable
         Dim oRow As DataRow

         oDataTable = oDataTableOrg.Clone

         For Each oRowMain In grdMain.GetRows()
            oRow = oDataTable.NewRow

            For i = 0 To oRowMain.Cells.Count - 1
               oRow(i) = oRowMain.Cells(i).Value
            Next

            oDataTable.Rows.Add(oRow)
         Next

         Return oDataTable.DefaultView
      End If
   End Function

   Private Sub PrintReport()

      Dim rpt As New rptItemProveedorMov

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompraDet.TableName))

      rpt.lblTitle.Text = "Proveedores a los que se Compró un Ítem"
      rpt.Document.Name = "Proveedores a los que se Compró un Ítem"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
      rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As frmReportPreview
      frm = New frmReportPreview(rpt.Document)
      frm.Show()

   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompraDetId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moCompraDet = New clsCompraDet(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Proveedores a los que se Compró un Ítem"

         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraNro").Caption = "Venta Nro"
         .RootTable.Columns("CompraNro").Width = 80
         .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraOrden").Caption = "Nro. Orden"
         .RootTable.Columns("CompraOrden").Width = 80
         .RootTable.Columns("CompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 80
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Proveedor"
         .RootTable.Columns("ItemDes").Width = 200
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CentroCostoDes").Caption = "Centro Costo"
         .RootTable.Columns("CentroCostoDes").Width = 120
         .RootTable.Columns("CentroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CentroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 80
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cantidad").Caption = "Cantidad"
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 80
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioOrg").Caption = "Precio"
         .RootTable.Columns("PrecioOrg").FormatString = DecimalMask()
         .RootTable.Columns("PrecioOrg").Width = 80
         .RootTable.Columns("PrecioOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Importe").Caption = "Importe"
         .RootTable.Columns("Importe").FormatString = DecimalMask()
         .RootTable.Columns("Importe").Width = 80
         .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If Not Detallado Then
            .RootTable.Columns("Fecha").Visible = False
            .RootTable.Columns("CompraOrden").Visible = False
         End If

      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompraId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompraId"), Janus.Windows.GridEX.ConditionOperator.Equal, -2)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompraId"), Janus.Windows.GridEX.ConditionOperator.Equal, -3)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call frmCompraEditLoad(ToLong(grdMain.GetValue("CompraId")))
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmProveedorItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmCompraEditLoad(ToLong(grdMain.GetValue("CompraId")))

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmProveedorItem_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompraDet.Dispose()
      Call ClearMemory()
   End Sub

End Class
