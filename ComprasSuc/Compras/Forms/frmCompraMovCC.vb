Public Class frmCompraMovCC
   Inherits System.Windows.Forms.Form

   Private moCompraDet As clsCompraDet
   Private moLista As New Queue
   Private moListaCC As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngAlmacenId As Long
   Private mlngProveedorId As Long
   Private mlngMedidaId As Long
   Private mlngTipoPagoId As Long
   Private mlngMonedaId As Long
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolOrdenarFecha As Boolean

   Private mdecTotalCan As Decimal
   Private mdecTotalOrg As Decimal
   Private mdecTotalCos As Decimal
   Private mdecTotalUti As Decimal

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

   Property ProveedorId() As Long
      Get
         Return mlngProveedorId
      End Get

      Set(ByVal Value As Long)
         mlngProveedorId = Value
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

   Property TipoPagoId() As Long
      Get
         Return mlngTipoPagoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoPagoId = Value
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

   Property Lista() As Queue
      Get
         Return moLista
      End Get

      Set(ByVal Value As Queue)
         moLista = Value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraMovCC))
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(317, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Compra"
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
      'frmCompraMovCC
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmCompraMovCC"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Movimiento de Compras por Items"
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
            Call frmCompraEditLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompraMovCC_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompraMovCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      Dim oRow As DataRow
      Dim datDate As DateTime
      Dim decSumTotalCan As Decimal
      Dim decSumTotalOrg As Decimal
      Dim decSumTotalCos As Decimal

      Dim decItemTotalCan As Decimal
      Dim decItemTotalOrg As Decimal
      Dim decItemTotalCos As Decimal

      Dim boolHead As Boolean
      Dim strCentroCostoDes As String

      datDate = Nothing
      Try
         Call moDataSetInit()

         With moCompraDet
            For Each lngItemId As Long In moLista

               decItemTotalCan = 0
               decItemTotalOrg = 0
               decItemTotalCos = 0
               boolHead = False

               For Each lngCentroCostoId As Long In moListaCC

                  If TieneMovimiento(lngItemId, lngCentroCostoId) Then

                     .SelectFilter = clsCompraDet.SelectFilters.CompraMov

                     If mboolIntervaloFecha Then
                        .WhereFilter = clsCompraDet.WhereFilters.CompraMovFecha
                        .Fecha = mstrFechaIni
                        .LastUpdateDate = mstrFechaFin
                     Else
                        .WhereFilter = clsCompraDet.WhereFilters.CompraMov
                     End If

                     If mboolOrdenarFecha Then
                        .OrderByFilter = clsCompraDet.OrderByFilters.Fecha
                     Else
                        .OrderByFilter = clsCompraDet.OrderByFilters.CompraDetId
                     End If

                     .EmpresaId = mlngEmpresaId
                     .GestionId = mlngGestionId
                     .CompraId = mlngTipoPagoId
                     .AlmacenId = mlngAlmacenId
                     .ProveedorId = mlngProveedorId
                     .CentroCostoIdAct = lngCentroCostoId
                     .SucursalIdAct = mlngSucursalId
                     .ItemId = lngItemId

                     If .Open() Then
                        mdecTotalCan = 0
                        mdecTotalOrg = 0
                        mdecTotalCos = 0
                        mdecTotalUti = 0

                        strCentroCostoDes = CentroCostoDesFind(lngCentroCostoId)

                        ''Call ItemParametro(.ItemId)
                        ''moDataTable.Rows.Add(GetHeader(.ItemId))

                        If Not boolHead Then
                           Call ItemParametro(.ItemId)
                           moDataTable.Rows.Add(GetHeader(.ItemId))
                           boolHead = True
                        End If

                        For Each oRow In .DataSet.Tables(.TableName).Rows
                           moDataTable.Rows.Add(GetRow(oRow, strCentroCostoDes))
                        Next

                        decItemTotalCan += mdecTotalCan
                        decItemTotalOrg += mdecTotalOrg
                        decItemTotalCos += mdecTotalCos

                        decSumTotalCan += mdecTotalCan
                        decSumTotalOrg += mdecTotalOrg
                        decSumTotalCos += mdecTotalCos

                        moDataTable.Rows.Add(GetFooter("SubTotal C.C. " & strCentroCostoDes, mdecTotalCan, _
                                                       mdecTotalOrg, mdecTotalCos))
                        moDataTable.Rows.Add(GetRowNull)
                     End If
                  End If
               Next

               If boolHead Then
                  moDataTable.Rows.RemoveAt(moDataTable.Rows.Count - 1)
                  moDataTable.Rows.Add(GetFooter("Total Item" & MonedaDesFind(mlngMonedaId), decItemTotalCan, _
                                                      decItemTotalOrg, decItemTotalCos))
                  moDataTable.Rows.Add(GetRowNull)
               End If
            Next


            If moDataTable.Rows.Count > 0 Then
               moDataTable.Rows.Add(GetFooter("Total " & MonedaDesFind(mlngMonedaId), decSumTotalCan, _
                                                    decSumTotalOrg, decSumTotalCos))
               moDataTable.Rows.Add(GetRowNull)
            End If

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

      moDataTable.Columns.Add("CompraDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompraId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoPagoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoPagoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompraNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("AlmacenDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CentroCostoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("ProveedorDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompraDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCambio", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("ImporteOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioCos", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("ImporteCos", Type.GetType("System.Decimal"))
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow, ByVal strCentroCostoDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraDetId") = oDataRow("CompraDetId")
      oRow("CompraId") = oDataRow("CompraId")
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
      oRow("TipoPagoId") = oDataRow("TipoPagoId")
      oRow("TipoPagoDes") = oDataRow("TipoPagoDes")
      oRow("CompraNro") = oDataRow("CompraNro")
      oRow("AlmacenDes") = oDataRow("AlmacenDes")
      oRow("CentroCostoDes") = strCentroCostoDes
      oRow("ProveedorDes") = oDataRow("ProveedorDes")
      oRow("CompraDes") = oDataRow("CompraDes")
      oRow("ItemId") = oDataRow("ItemId")
      oRow("TipoCambio") = oDataRow("TipoCambio")
      oRow("Cantidad") = 0.0
      oRow("PrecioOrg") = 0.0
      oRow("PrecioCos") = 0.0

      'convirtiendo a numero con cinco decimales
      oDataRow("Cantidad") = ToDecimalCinco(oDataRow("Cantidad"))
      oDataRow("PrecioOrg") = ToDecimalCinco(oDataRow("PrecioOrg"))
      oDataRow("PrecioCos") = ToDecimalCinco(oDataRow("PrecioCos"))

      If mlngMedidaId = 1 Then 'Medida Minima del Reporte
         If ToLong(oDataRow("MedidaId")) = mlngItemMedidaId Then
            oRow("MedidaDes") = oDataRow("MedidaDes")
            oRow("Cantidad") = oDataRow("Cantidad")
            oRow("PrecioOrg") = oDataRow("PrecioOrg")
            oRow("PrecioCos") = oDataRow("PrecioCos")
         Else
            oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaId)
            oRow("Cantidad") = oDataRow("Cantidad") * mdecItemMedidaCantEqui
            If oDataRow("PrecioOrg") <> 0 Then oRow("PrecioOrg") = oDataRow("PrecioOrg") / mdecItemMedidaCantEqui
            If oDataRow("PrecioCos") <> 0 Then oRow("PrecioCos") = oDataRow("PrecioCos") / mdecItemMedidaCantEqui
         End If

      ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
         If ToLong(oDataRow("MedidaId")) = mlngItemMedidaIdEqui Then
            oRow("MedidaDes") = oDataRow("MedidaDes")
            oRow("Cantidad") = oDataRow("Cantidad")
            oRow("PrecioOrg") = oDataRow("PrecioOrg")
            oRow("PrecioCos") = oDataRow("PrecioCos")
         Else
            oRow("MedidaDes") = MedidaDesFind(mlngItemMedidaIdEqui)
            If oDataRow("Cantidad") <> 0 Then oRow("Cantidad") = oDataRow("Cantidad") / mdecItemMedidaCantEqui
            oRow("PrecioOrg") = oDataRow("PrecioOrg") * mdecItemMedidaCantEqui
            oRow("PrecioCos") = oDataRow("PrecioCos") * mdecItemMedidaCantEqui
         End If
      End If

      If mlngMonedaId = 1 Then
         If oDataRow("MonedaId") <> mlngMonedaId Then
            oRow("PrecioOrg") *= oRow("TipoCambio")
            oRow("PrecioCos") *= oRow("TipoCambio")
         End If

      ElseIf mlngMonedaId = 2 Then
         If oDataRow("MonedaId") <> mlngMonedaId Then
            oRow("PrecioOrg") /= oRow("TipoCambio")
            oRow("PrecioCos") /= oRow("TipoCambio")
         End If
      End If

      oRow("ImporteOrg") = ToDecimal(oRow("Cantidad") * oRow("PrecioOrg"))
      oRow("ImporteCos") = ToDecimal(oRow("Cantidad") * oRow("PrecioCos"))

      'convirtiendo a numero con cantidad de decimales preconfigurado por el ususario
      oRow("Cantidad") = ToDecimal(oRow("Cantidad"))
      oRow("PrecioOrg") = ToDecimal(oRow("PrecioOrg"))
      oRow("PrecioCos") = ToDecimal(oRow("PrecioCos"))

      mdecTotalCan += oRow("Cantidad")
      mdecTotalOrg += oRow("ImporteOrg")
      mdecTotalCos += oRow("ImporteCos")

      Return oRow
   End Function

   Private Function GetHeader(ByVal lngItemId As Long) As DataRow
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         oRow("CompraDetId") = 0
         oRow("AlmacenDes") = "Item"

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               oRow("ProveedorDes") = ToStr(.ItemCod)
               oRow("CompraDes") = ToStr(.ItemDes)
            End If
         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Function

   Private Function GetFooter(ByVal strDes As String, ByVal decCantidad As Decimal, ByVal decImporteOrg As Decimal, _
                              ByVal decImporteCos As Decimal) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraDetId") = 0
      oRow("CompraDes") = strDes
      oRow("Cantidad") = decCantidad
      oRow("ImporteOrg") = decImporteOrg
      oRow("ImporteCos") = decImporteCos

      Return oRow
   End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
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

   Private Function MonedaDesFind(ByVal lngMonedaId As Long) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)
      MonedaDesFind = ""
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

   Private Function ProveedorDesFind(ByVal lngProveedorId As Long) As String
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      ProveedorDesFind = ""

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               ProveedorDesFind = .ProveedorDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

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
               mlngItemTipoCosteoId = ToLong(.TipoCosteoId)
               mlngItemMedidaId = ToLong(.MedidaId)
               mlngItemMedidaIdEqui = ToLong(.MedidaIdEqui)
               mdecItemMedidaCantEqui = ToDecimal(.MedidaCantEqui)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Function TieneMovimiento(ByVal lngItemId As Long, ByVal lngCentroCostoId As Long) As Boolean
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

      TieneMovimiento = False

      Try
         With oCompraDet
            .SelectFilter = clsCompraDet.SelectFilters.All

            If mboolIntervaloFecha Then
               .WhereFilter = clsCompraDet.WhereFilters.TieneMovimientoFecha
               .Fecha = mstrFechaIni
               .LastUpdateDate = mstrFechaFin
            Else
               .WhereFilter = clsCompraDet.WhereFilters.TieneMovimiento
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .AlmacenId = mlngAlmacenId
            .ProveedorId = mlngProveedorId
            .CentroCostoIdAct = lngCentroCostoId
            .SucursalIdAct = mlngSucursalId
            .ItemId = lngItemId

            If .Find Then
               TieneMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try
   End Function

   Private Sub DataShow()
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("CompraId")) > 0) Then
            With oCompra
               .CompraId = ToLong(grdMain.GetValue("CompraId"))

               If .FindByPK Then
                  Dim frm As New frmCompraEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oCompra

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Registro Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   Private Sub frmCompraEditLoad()
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim lngCompraDetId As Long

      Try
         If grdMain.RowCount > 0 Then
            With oCompra
               .CompraId = ToLong(grdMain.GetValue("CompraId"))
               lngCompraDetId = ToLong(grdMain.GetValue("CompraDetId"))

               If .FindByPK Then
                  Dim frm As New frmCompraEdit

                  frm.NewRecord = False
                  frm.Editing = True
                  frm.DataObject = oCompra
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdMainLoad()
                     Call grdMainFindRow(lngCompraDetId)
                     mboolChanged = True

                  End If
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Seleccione un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

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
      Dim rpt As New rptCompraMov

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompraDet.TableName))

      rpt.lblTitle.Text = "Movimiento de Compras por Items"
      rpt.Document.Name = "Movimiento de Compras por Items"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
      rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)

      rpt.lblProveedor.Text = "Todos"
      If (mlngProveedorId > 0) Then
         rpt.lblProveedor.Text = ProveedorDesFind(mlngProveedorId)
      End If
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
         ebrMain.Groups(0).Text = "Movimiento de Compras por Items"

         .RootTable.Columns("CompraDetId").Visible = False

         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoPagoId").Visible = False

         .RootTable.Columns("TipoPagoDes").Caption = "Tipo"
         .RootTable.Columns("TipoPagoDes").Width = 80
         .RootTable.Columns("TipoPagoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoPagoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraNro").Caption = "Nro"
         .RootTable.Columns("CompraNro").Width = 80
         .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AlmacenDes").Caption = "Almacén"
         .RootTable.Columns("AlmacenDes").Width = 100
         .RootTable.Columns("AlmacenDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AlmacenDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CentroCostoDes").Caption = "Centro Costo"
         .RootTable.Columns("CentroCostoDes").Width = 100
         .RootTable.Columns("CentroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CentroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
         .RootTable.Columns("ProveedorDes").Width = 100
         .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraDes").Caption = "Descripción"
         .RootTable.Columns("CompraDes").Width = 150
         .RootTable.Columns("CompraDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompraDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("TipoCambio").Caption = "Tipo Cambio"
         .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
         .RootTable.Columns("TipoCambio").Width = 80
         .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 80
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cantidad").Caption = "Cantidad"
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 80
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioOrg").Caption = "Precio Orig"
         .RootTable.Columns("PrecioOrg").FormatString = DecimalMask()
         .RootTable.Columns("PrecioOrg").Width = 80
         .RootTable.Columns("PrecioOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteOrg").Caption = "Importe Orig"
         .RootTable.Columns("ImporteOrg").FormatString = DecimalMask()
         .RootTable.Columns("ImporteOrg").Width = 80
         .RootTable.Columns("ImporteOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioCos").Caption = "Precio Costo"
         .RootTable.Columns("PrecioCos").FormatString = DecimalMask()
         .RootTable.Columns("PrecioCos").Width = 80
         .RootTable.Columns("PrecioCos").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioCos").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteCos").Caption = "Importe Costo"
         .RootTable.Columns("ImporteCos").FormatString = DecimalMask()
         .RootTable.Columns("ImporteCos").Width = 80
         .RootTable.Columns("ImporteCos").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteCos").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompraDetId"), Janus.Windows.GridEX.ConditionOperator.Equal, 0)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call DataShow()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmCompraMovCC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmCompraEditLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompraMovCC_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompraDet.Dispose()
      Call ClearMemory()
   End Sub

End Class
