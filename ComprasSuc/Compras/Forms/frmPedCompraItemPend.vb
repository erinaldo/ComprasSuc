Public Class frmPedCompraItemPend
   Inherits System.Windows.Forms.Form

   Private moPedCompra As clsPedCompra
   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngEstadoId As Long
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mlngMedidaId As Long
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolOrdenarFecha As Boolean
   Private mboolDetallado As Boolean
   Private mboolSaldoCero As Boolean

   Private mdecCantidad As Decimal
   Private mdecCantidadEnt As Decimal
   Private mdecSaldo As Decimal

   Private mdecCantidadOrgPed As Decimal
   Private mdecCantidadPed As Decimal
   Private mdecCantidadEntPed As Decimal
   Private mdecSaldoPed As Decimal

   Private mdecCantidadTotal As Decimal
   Private mdecCantidadEntTotal As Decimal
   Private mdecSaldoTotal As Decimal

   Private mdecMonto As Decimal
   Private mdecMontoPed As Decimal
   Private mdecMontoTotal As Decimal

   Private mlngItemTipoCosteoId As Long
   Private mlngItemMedidaId As Long
   Private mlngItemMedidaIdEqui As Long
   Private mdecItemMedidaCantEqui As Decimal
   Private mlngItemMonedaIdCos As Long

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mboolChanged As Boolean
   Private mboolSelected As Boolean
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

   Property EstadoId() As Long
      Get
         Return mlngEstadoId
      End Get

      Set(ByVal Value As Long)
         mlngEstadoId = Value
      End Set
   End Property

   Property ProveedorId() As Long
      Get
         Return mlngProveedorId
      End Get

      Set(ByVal Value As Long)
         mlngProveedorId = Value
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

   Property MedidaId() As Long
      Get
         Return mlngMedidaId
      End Get

      Set(ByVal Value As Long)
         mlngMedidaId = Value
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

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
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

   WriteOnly Property Detallado() As Boolean
      Set(ByVal Value As Boolean)
         mboolDetallado = Value
      End Set
   End Property

   Property SaldoCero() As Boolean
      Get
         Return mboolSaldoCero
      End Get

      Set(ByVal Value As Boolean)
         mboolSaldoCero = Value
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
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
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
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedCompraItemPend))
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
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 371
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(304, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Nota"
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
      Me.Book.Text = "Libro Mayor"
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
      'frmPedCompraItemPend
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmPedCompraItemPend"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Items de Pedidos Pendientes de Compra"
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
            Call frmPedCompraShowLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPedCompraItemPend_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPedCompraItemPend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

   Private Sub grdMainLoad()
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim oCompraPedidoDet As New clsCompraPedidoDet(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      Dim oRowDet As DataRow

      Dim oRowPed As DataRow
      Dim oRowPedDet As DataRow

      Dim lngPos As Long
      Dim decPrecioBru As Decimal

      Try
         Call moDataSetInit()

         With moPedCompra
            .SelectFilter = clsPedCompra.SelectFilters.PedCompraMov

            If mboolIntervaloFecha Then
               If Not mboolSaldoCero Then
                  .WhereFilter = clsPedCompra.WhereFilters.PedCompraMovEntregaPendFecha
               Else
                  .WhereFilter = clsPedCompra.WhereFilters.PedCompraMovAllFecha
               End If

               .Fecha = mstrFechaIni
               .LastUpdateDate = mstrFechaFin
            Else
               If Not mboolSaldoCero Then
                  .WhereFilter = clsPedCompra.WhereFilters.PedCompraMovEntregaPend
               Else
                  .WhereFilter = clsPedCompra.WhereFilters.PedCompraMovAll
               End If
            End If

            If mboolOrdenarFecha Then
               .OrderByFilter = clsPedCompra.OrderByFilters.Fecha
            Else
               .OrderByFilter = clsPedCompra.OrderByFilters.PedCompraId
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId

            If .Open Then

               mdecCantidadTotal = 0
               mdecCantidadEntTotal = 0
               mdecSaldoTotal = 0

               mdecMontoTotal = 0

               For Each oRow In .DataSet.Tables(.TableName).Rows

                  lngPos = moDataTable.Rows.Count()
                  oRowPed = GetPedCompra(oRow)
                  moDataTable.Rows.Add(oRowPed)

                  mdecCantidadPed = 0
                  mdecCantidadEntPed = 0
                  mdecSaldoPed = 0

                  mdecMontoPed = 0
                  mdecCantidadOrgPed = 0

                  With oPedCompraDet
                     .SelectFilter = clsPedCompraDet.SelectFilters.GridPedCompraId

                     If Not mboolSaldoCero Then
                        .WhereFilter = clsPedCompraDet.WhereFilters.GridPedCompraIdPend
                     Else
                        .WhereFilter = clsPedCompraDet.WhereFilters.GridPedCompraId
                     End If

                     .OrderByFilter = clsPedCompraDet.OrderByFilters.Grid
                     .EmpresaId = mlngEmpresaId
                     .PedCompraId = oRow("PedCompraId")

                     If .Open Then

                        If mboolDetallado Then 'Para el Detallado
                           For Each oRowDet In .DataSet.Tables(.TableName).Rows
                              For Each lngItemId As Long In moLista

                                 mdecCantidad = 0
                                 mdecCantidadEnt = 0
                                 mdecSaldo = 0

                                 mdecMonto = 0

                                 If oRowDet("ItemId") = lngItemId Then
                                    oRowPedDet = GetPedCompraDet(oRowDet, oRow("MonedaId"), oRow("TipoCambio"), decPrecioBru, oRowPed)
                                    moDataTable.Rows.Add(oRowPedDet)

                                    'CompraPedido
                                    With oCompraPedidoDet
                                       .SelectFilter = clsCompraPedidoDet.SelectFilters.PedidoItemComprados
                                       .WhereFilter = clsCompraPedidoDet.WhereFilters.PedidoItemComprados
                                       If mboolOrdenarFecha Then
                                          .OrderByFilter = clsCompraPedidoDet.OrderByFilters.FechaCompra
                                       Else
                                          .OrderByFilter = clsCompraPedidoDet.OrderByFilters.CompraPedidoDetId
                                       End If

                                       .EmpresaId = mlngEmpresaId
                                       .GestionId = mlngGestionId
                                       .ItemId = lngItemId
                                       .PedCompraId = oRow("PedCompraId")

                                       If .Open() Then
                                          For Each oRowCompra As DataRow In .DataSet.Tables(.TableName).Rows
                                             moDataTable.Rows.Add(GetCompraPedidoRow(oRowCompra, decPrecioBru, oRowPedDet))
                                          Next
                                       End If
                                    End With

                                 End If
                              Next
                           Next
                        Else
                           For Each oRowDet In .DataSet.Tables(.TableName).Rows
                              For Each lngItemId As Long In moLista
                                 If oRowDet("ItemId") = lngItemId Then
                                    moDataTable.Rows.Add(GetPedCompraDet(oRowDet, oRow("MonedaId"), oRow("TipoCambio"), decPrecioBru, oRowPed))
                                 End If
                              Next
                           Next
                        End If
                     End If
                  End With

                  If mdecCantidadOrgPed > 0 Then
                     Call PedCompraFooter(lngPos)

                     moDataTable.Rows.Add(GetRowNull)

                  Else
                     moDataTable.Rows.RemoveAt(moDataTable.Rows.Count - 1)
                  End If
               Next
            End If
         End With

         moDataTable.Rows.Add(GetFooter())
         grdMain.DataSource = moDataSet.Tables(moPedCompra.TableName).DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()

         moPedCompra.CloseConection()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPedCompraDet.Dispose()
         oCompraPedidoDet.Dispose()
      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moPedCompra.TableName)

      moDataTable.Columns.Add("PedCompraId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompraId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PedCompraEsp", Type.GetType("System.String"))
      moDataTable.Columns.Add("PedCompraNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PedCompraOrden", Type.GetType("System.String"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.String"))
      moDataTable.Columns.Add("ProveedorDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("PedCompraDes", Type.GetType("System.String"))

      moDataTable.Columns.Add("CompraNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompraFecha", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompraProveedorDes", Type.GetType("System.String"))

      'moDataTable.Columns.Add("AlmacenDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemId", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("PedCompraDetDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("CantidadEnt", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Saldo", Type.GetType("System.Decimal"))

      moDataTable.Columns.Add("Precio", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioRec", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioDes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioBru", Type.GetType("System.Decimal"))

      moDataTable.Columns.Add("Monto", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoRec", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoDes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoBru", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoSaldo", Type.GetType("System.Decimal"))

   End Sub

   Private Function GetProveedor(ByVal lngProveedorId As Long) As DataRow
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               oRow("PedCompraId") = -1
               oRow("PedCompraEsp") = "Proveedor " & .ProveedorCod
               oRow("PedCompraDes") = .ProveedorDes
            End If
         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function GetPedCompra(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PedCompraId") = oDataRow("PedCompraId")
      oRow("PedCompraEsp") = "Pedido " & oDataRow("PedCompraNro")
      oRow("PedCompraNro") = oDataRow("PedCompraNro")
      oRow("PedCompraOrden") = oDataRow("PedCompraOrden")
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
      oRow("ProveedorDes") = ProveedorDesFind(oDataRow("ProveedorId"))
      oRow("PedCompraDes") = oDataRow("PedCompraDes")

      oRow("Monto") = 0
      oRow("MontoRec") = 0
      oRow("MontoDes") = 0
      oRow("MontoBru") = 0

      oRow("Cantidad") = 0
      oRow("CantidadEnt") = 0
      oRow("Saldo") = 0
      oRow("MontoSaldo") = 0

      Return oRow
   End Function

   Private Function GetPedCompraDet(ByVal oDataRow As DataRow, ByVal lngMonedaId As Long, ByVal decTipoCambio As Decimal, ByRef decPrecioBru As Decimal, _
                                    ByVal oRowPed As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PedCompraId") = -1
      oRow("PedCompraEsp") = "    Ítem"
      ''oRow("PedCompraDes") = oDataRow("ItemDes")

      oRow("PedCompraNro") = oRowPed("PedCompraNro")
      oRow("PedCompraOrden") = oRowPed("PedCompraOrden")
      oRow("Fecha") = oRowPed("Fecha")
      oRow("ProveedorDes") = oRowPed("ProveedorDes")
      oRow("PedCompraDes") = oRowPed("PedCompraDes")

      oRow("ItemCod") = oDataRow("ItemCod")
      oRow("ItemDes") = oDataRow("ItemDes")
      oRow("PedCompraDetDes") = oDataRow("PedCompraDetDes")

      oRow("MedidaDes") = oDataRow("MedidaDes")
      oRow("Cantidad") = oDataRow("Cantidad")
      oRow("CantidadEnt") = oDataRow("CantidadEnt")

      If lngMonedaId = mlngMonedaId Then
         oRow("Precio") = oDataRow("Precio")
         oRow("PrecioRec") = oDataRow("PrecioRec")
         oRow("PrecioDes") = oDataRow("PrecioDes")

      ElseIf lngMonedaId = 1 Then
         oRow("Precio") = oDataRow("Precio") / ToDivByCero(decTipoCambio)
         oRow("PrecioRec") = oDataRow("PrecioRec") / ToDivByCero(decTipoCambio)
         oRow("PrecioDes") = oDataRow("PrecioDes") / ToDivByCero(decTipoCambio)

      ElseIf lngMonedaId = 2 Then
         oRow("Precio") = oDataRow("Precio") * decTipoCambio
         oRow("PrecioRec") = oDataRow("PrecioRec") * decTipoCambio
         oRow("PrecioDes") = oDataRow("PrecioDes") * decTipoCambio

      End If

      oRow("PrecioBru") = (oRow("Precio") + oRow("PrecioRec") - oRow("PrecioDes"))
      decPrecioBru = oRow("PrecioBru")

      Call ItemParametro(oDataRow("ItemId"))
      oRow("Monto") = oRow("Cantidad") * oRow("Precio")
      oRow("MontoRec") = oRow("Cantidad") * oRow("PrecioRec")
      oRow("MontoDes") = oRow("Cantidad") * oRow("PrecioDes")
      oRow("MontoBru") = oRow("Cantidad") * (oRow("Precio") + oRow("PrecioRec") - oRow("PrecioDes"))

      mdecCantidadOrgPed += oRow("Cantidad")

      mdecCantidad = oRow("Cantidad")
      If Not mboolDetallado Then
         mdecCantidadEnt = oRow("CantidadEnt")
         mdecSaldo = oRow("Cantidad") - oRow("CantidadEnt")
         mdecMonto = mdecSaldo * oRow("PrecioBru")
      Else
         mdecCantidadEnt = 0
         mdecSaldo = oRow("Cantidad")
         mdecMonto = oRow("MontoBru")
      End If

      oRow("Cantidad") = mdecCantidad
      oRow("CantidadEnt") = mdecCantidadEnt
      oRow("Saldo") = mdecSaldo
      oRow("MontoSaldo") = mdecMonto

      mdecCantidadPed += mdecCantidad
      mdecCantidadEntPed += mdecCantidadEnt
      mdecSaldoPed += mdecSaldo
      mdecMontoPed += mdecMonto

      Return oRow
   End Function

   Private Function GetCompraPedidoRow(ByVal oDataRow As DataRow, ByVal decPrecio As Decimal, ByVal oRowPed As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PedCompraId") = 0
      oRow("CompraId") = oDataRow("CompraId")
      'oRow("PedCompraOrden") = oDataRow("PedCompraOrden")
      oRow("PedCompraEsp") = "        Compra " & oDataRow("CompraNro")
      ''oRow("PedCompraNro") = lngPedVentaNro
      ''oRow("Numero") = oDataRow("CompraNro")
      ''oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
      ''oRow("ProveedorDes") = oDataRow("ProveedorDes")
      ''oRow("PedCompraDes") = oDataRow("CompraDes")

      oRow("PedCompraNro") = oRowPed("PedCompraNro")
      oRow("PedCompraOrden") = oRowPed("PedCompraOrden")
      oRow("Fecha") = oRowPed("Fecha")
      oRow("ProveedorDes") = oRowPed("ProveedorDes")
      oRow("PedCompraDes") = oRowPed("PedCompraDes")

      oRow("ItemCod") = oRowPed("ItemCod")
      oRow("ItemDes") = oRowPed("ItemDes")
      oRow("PedCompraDetDes") = oRowPed("PedCompraDetDes")

      oRow("CompraNro") = oDataRow("CompraNro")
      oRow("CompraFecha") = ToDateDMY(oDataRow("Fecha"))
      oRow("CompraProveedorDes") = oDataRow("ProveedorDes")

      oRow("MedidaDes") = oDataRow("MedidaDes")
      oRow("Cantidad") = oDataRow("Cantidad")
      oRow("PrecioBru") = decPrecio
      oRow("MontoBru") = oRow("Cantidad") * oRow("PrecioBru")

      mdecCantidadEnt += oRow("Cantidad")
      mdecSaldo = mdecSaldo - oRow("Cantidad")
      mdecMonto = mdecMonto - oRow("MontoBru")

      oRow("Saldo") = mdecSaldo
      oRow("MontoSaldo") = mdecMonto

      mdecCantidadEntPed += oRow("Cantidad")
      mdecSaldoPed = mdecSaldoPed - oRow("Cantidad")
      mdecMontoPed = mdecMontoPed - oRow("MontoBru")

      Return oRow
   End Function

   Private Sub PedCompraFooter(ByVal lngPos As Long)
      Dim oRow As DataRow = moDataTable.Rows(lngPos)

      If Not mboolDetallado Then
         oRow("Cantidad") = ToDecimal(mdecCantidadPed)
         oRow("CantidadEnt") = ToDecimal(mdecCantidadEntPed)
      Else
         oRow("Cantidad") = System.Convert.DBNull
         oRow("CantidadEnt") = System.Convert.DBNull
      End If

      oRow("Saldo") = ToDecimal(mdecSaldoPed)
      oRow("MontoSaldo") = ToDecimal(mdecMontoPed)

      mdecCantidadTotal += mdecCantidadPed
      mdecCantidadEntTotal += mdecCantidadEntPed
      mdecSaldoTotal += mdecSaldoPed

      mdecMontoTotal += mdecMontoPed
   End Sub

   Private Function GetFooter() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PedCompraId") = -2
      oRow("PedCompraDes") = "Totales General"

      If Not mboolDetallado Then
         oRow("Cantidad") = ToDecimal(mdecCantidadTotal)
         oRow("CantidadEnt") = ToDecimal(mdecCantidadEntTotal)
      Else
         oRow("Cantidad") = System.Convert.DBNull
         oRow("CantidadEnt") = System.Convert.DBNull
      End If

      oRow("Saldo") = ToDecimal(mdecSaldoTotal)
      oRow("MontoSaldo") = ToDecimal(mdecMontoTotal)

      Return oRow
   End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
   End Function

   Private Function ProveedorDesFind(ByVal lngProveedorId As Long) As String
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      ProveedorDesFind = ""

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               ProveedorDesFind = ToStr(.ProveedorDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function MedidaDesFind(ByVal lngMedidaId As Long) As String
      Dim oMedida As New clsMedida(clsAppInfo.ConnectString)

      MedidaDesFind = ""

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

   Private Sub ItemParametro(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngItemTipoCosteoId = 0
         mlngItemMedidaId = 0
         mlngItemMedidaIdEqui = 0
         mdecItemMedidaCantEqui = 0
         mlngItemMonedaIdCos = 0

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngItemTipoCosteoId = .TipoCosteoId
               mlngItemMedidaId = .MedidaId
               mlngItemMedidaIdEqui = .MedidaIdEqui
               mdecItemMedidaCantEqui = .MedidaCantEqui
               mlngItemMonedaIdCos = .MonedaIdCos
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub DataShow()
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("PedCompraId")) > 0) Then
            With oPedCompra
               .PedCompraId = ToLong(grdMain.GetValue("PedCompraId"))

               If .FindByPK Then
                  Dim frm As New frmPedCompraEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oPedCompra

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub frmPedCompraShowLoad()
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         If ToLong(grdMain.GetValue("PedCompraId")) > 0 Then
            With oPedCompra
               .PedCompraId = ToLong(grdMain.GetValue("PedCompraId"))

               If .FindByPK Then
                  Dim frm As New frmPedCompraEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oPedCompra
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdMainLoad()
                     Call grdMainFindRow(frm.ID)
                     mboolChanged = True
                  End If
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

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
      Dim rpt

      If mboolDetallado Then
         rpt = New rptPedCompraItemPend
      Else
         rpt = New rptPedCompraItemPendResu
      End If

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moPedCompra.TableName))

      rpt.lblTitle.Text = Me.Text
      rpt.Document.Name = Me.Text
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

      oCol = grdMain.RootTable.Columns("PedCompraId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moPedCompra = New clsPedCompra(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Listado de Pedidos de Compras"

         .RootTable.HeaderLines = 2
         .RootTable.Columns("PedCompraId").Visible = False
         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("PedCompraEsp").Caption = "Especificación"
         .RootTable.Columns("PedCompraEsp").Width = 100
         .RootTable.Columns("PedCompraEsp").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PedCompraEsp").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PedCompraNro").Caption = "Nro Pedido"
         .RootTable.Columns("PedCompraNro").Width = 80
         .RootTable.Columns("PedCompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PedCompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         '.RootTable.Columns("PedCompraNro").CellStyle.BackColor = Color.MistyRose

         .RootTable.Columns("PedCompraOrden").Caption = "Nro. Orden"
         .RootTable.Columns("PedCompraOrden").Width = 80
         .RootTable.Columns("PedCompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PedCompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         '.RootTable.Columns("PedCompraOrden").CellStyle.BackColor = Color.MistyRose

         .RootTable.Columns("Fecha").Caption = " Fecha Pedido"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         '.RootTable.Columns("Fecha").CellStyle.BackColor = Color.MistyRose

         .RootTable.Columns("ProveedorDes").Caption = "Proveedor Pedido"
         .RootTable.Columns("ProveedorDes").Width = 150
         .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PedCompraDes").Caption = "Descripción"
         .RootTable.Columns("PedCompraDes").Width = 100
         .RootTable.Columns("PedCompraDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PedCompraDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         '.RootTable.Columns("PedCompraDes").Visible = False

         .RootTable.Columns("CompraNro").Caption = "Nro Compra"
         .RootTable.Columns("CompraNro").Width = 80
         .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
 
         .RootTable.Columns("CompraFecha").Caption = "Fecha Compra"
         .RootTable.Columns("CompraFecha").Width = 80
         .RootTable.Columns("CompraFecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompraFecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
 
         .RootTable.Columns("CompraProveedorDes").Caption = "Proveedor Compra"
         .RootTable.Columns("CompraProveedorDes").Width = 150
         .RootTable.Columns("CompraProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompraProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
 
         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "Codigo"
         .RootTable.Columns("ItemCod").Width = 80
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Item"
         .RootTable.Columns("ItemDes").Width = 100
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PedCompraDetDes").Caption = "Descripción"
         .RootTable.Columns("PedCompraDetDes").Width = 150
         .RootTable.Columns("PedCompraDetDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PedCompraDetDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 80
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cantidad").Caption = "Cantidad"
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 100
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CantidadEnt").Caption = "Entregado"
         .RootTable.Columns("CantidadEnt").FormatString = DecimalMask()
         .RootTable.Columns("CantidadEnt").Width = 80
         .RootTable.Columns("CantidadEnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("CantidadEnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mboolDetallado Then
            .RootTable.Columns("CantidadEnt").Visible = False
         Else
            .RootTable.Columns("CompraNro").Visible = False
            .RootTable.Columns("CompraFecha").Visible = False
            .RootTable.Columns("CompraProveedorDes").Visible = False
         End If

         .RootTable.Columns("Saldo").Caption = "Saldo"
         .RootTable.Columns("Saldo").FormatString = DecimalMask()
         .RootTable.Columns("Saldo").Width = 100
         .RootTable.Columns("Saldo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Saldo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Precio").Visible = False
         .RootTable.Columns("PrecioRec").Visible = False
         .RootTable.Columns("PrecioDes").Visible = False

         .RootTable.Columns("Monto").Caption = "Importe"
         .RootTable.Columns("Monto").FormatString = DecimalMask()
         .RootTable.Columns("Monto").Width = 100
         .RootTable.Columns("Monto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Monto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Monto").Visible = False

         .RootTable.Columns("MontoRec").Caption = "Recargo"
         .RootTable.Columns("MontoRec").FormatString = DecimalMask()
         .RootTable.Columns("MontoRec").Width = 100
         .RootTable.Columns("MontoRec").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoRec").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoRec").Visible = False

         .RootTable.Columns("MontoDes").Caption = "Descuento"
         .RootTable.Columns("MontoDes").FormatString = DecimalMask()
         .RootTable.Columns("MontoDes").Width = 100
         .RootTable.Columns("MontoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoDes").Visible = False

         .RootTable.Columns("MontoBru").Caption = "Importe Bru"
         .RootTable.Columns("MontoBru").FormatString = DecimalMask()
         .RootTable.Columns("MontoBru").Width = 100
         .RootTable.Columns("MontoBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoBru").Visible = False

         .RootTable.Columns("PrecioBru").Caption = "Precio"
         .RootTable.Columns("PrecioBru").FormatString = DecimalMask()
         .RootTable.Columns("PrecioBru").Width = 100
         .RootTable.Columns("PrecioBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PrecioBru").Visible = False

         .RootTable.Columns("MontoSaldo").Caption = "Importe Saldo"
         .RootTable.Columns("MontoSaldo").FormatString = DecimalMask()
         .RootTable.Columns("MontoSaldo").Width = 100
         .RootTable.Columns("MontoSaldo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoSaldo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoSaldo").Visible = False

      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PedCompraId"), Janus.Windows.GridEX.ConditionOperator.NotEqual, 0)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PedCompraId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PedCompraId"), Janus.Windows.GridEX.ConditionOperator.Equal, -2)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      'Call DataShow()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmPedCompraItemPend_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            'Call frmPedCompraEditLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPedCompraItemPend_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPedCompra.Dispose()
      Call ClearMemory()
   End Sub

End Class
