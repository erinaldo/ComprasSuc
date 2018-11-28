Public Class frmProveedorExtra
   Inherits System.Windows.Forms.Form

   Private moProveedorMov As clsProveedorMov
   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolOrdenarFecha As Boolean
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mboolSaldoCero As Boolean
   Private mboolDetalleCompra As Boolean

   Private mdecDebe As Decimal
   Private mdecHaber As Decimal
   Private mdecSaldo As Decimal
   Private mlngCompraId As Long = 0

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

   Property SaldoCero() As Boolean
      Get
         Return mboolSaldoCero
      End Get

      Set(ByVal Value As Boolean)
         mboolSaldoCero = Value
      End Set
   End Property

   Property DetalleCompra() As Boolean
      Get
         Return mboolDetalleCompra
      End Get

      Set(ByVal Value As Boolean)
         mboolDetalleCompra = Value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorExtra))
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
      'frmProveedorExtra
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmProveedorExtra"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Extracto de Proveedores"
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
            Call DocumentoEditLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmProveedorExtra_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmProveedorExtra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

      Try
         Call moDataSetInit()

         With moProveedorMov
            For Each lngProveedorId As Long In moLista
               If TieneMovimiento(lngProveedorId) Then
                  If Not mboolSaldoCero Then
                     If ProveedoresaldoActual(lngProveedorId) <> 0 Then
                        Call GetMovimiento(lngProveedorId)
                     End If
                  Else
                     Call GetMovimiento(lngProveedorId)
                  End If
               End If
            Next
                moDataTable.Rows.Add(GetFooterTotal)
            grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub GetMovimiento(ByVal lngProveedorId As Long)
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
      Dim oPagoDet As New clsPagoDet(clsAppInfo.ConnectString)
      Dim oRowCompra As DataRow
      Dim oRowCompraDet As DataRow
      Dim oRowPagoDet As DataRow
      Dim oRow As DataRow
      Dim decInteres As Decimal

      With moProveedorMov
         .SelectFilter = clsProveedorMov.SelectFilters.Kardex

         If mboolIntervaloFecha Then
            .WhereFilter = clsProveedorMov.WhereFilters.KardexFecha
            .Fecha = mstrFechaIni
            .ProveedorMovDes = mstrFechaFin
         Else
            .WhereFilter = clsProveedorMov.WhereFilters.Kardex
         End If

         If mboolOrdenarFecha Then
            .OrderByFilter = clsProveedorMov.OrderByFilters.Fecha
         Else
            .OrderByFilter = clsProveedorMov.OrderByFilters.ProveedorMovId
         End If

         .EmpresaId = mlngEmpresaId
         .GestionId = mlngGestionId
         .CentroCostoId = mlngCentroCostoId
         .SucursalId = mlngSucursalId
         .ProveedorId = lngProveedorId
         .EstadoId = 11 'Abierto

         If .Open() Then
            mdecDebe = 0
            mdecHaber = 0

            If mboolIntervaloFecha Then
               mdecSaldo = ProveedoresaldoAnterior(.ProveedorId)
            Else
               mdecSaldo = 0
            End If

            moDataTable.Rows.Add(GetHeader(.ProveedorId))

            For Each oRow In .DataSet.Tables(.TableName).Rows
               moDataTable.Rows.Add(GetRow(oRow, decInteres))

               If oRow("TipoCompraId") = 6 Then
                  If mboolDetalleCompra Then
                     With oCompra
                        .SelectFilter = clsCompra.SelectFilters.All
                        .WhereFilter = clsCompra.WhereFilters.CreditoId
                        .OrderByFilter = clsCompra.OrderByFilters.CompraId
                        .EmpresaId = mlngEmpresaId
                        .CreditoId = oRow("DocumentoId")

                        If .Open Then
                           For Each oRowCompra In .DataSet.Tables(.TableName).Rows
                              moDataTable.Rows.Add(GetCompra(oRowCompra, oRow("TipoCompraId")))

                              With oCompraDet
                                 .SelectFilter = clsCompraDet.SelectFilters.Grid
                                 .WhereFilter = clsCompraDet.WhereFilters.Grid
                                 .OrderByFilter = clsCompraDet.OrderByFilters.Grid
                                 .EmpresaId = mlngEmpresaId
                                 .CompraId = oRowCompra("CompraId")

                                 If .Open() Then
                                    For Each oRowCompraDet In .DataSet.Tables(.TableName).Rows
                                       moDataTable.Rows.Add(GetCompraDet(oRowCompraDet, oRow("TipoCompraId"), oRowCompra("MonedaId"), oRowCompra("TipoCambio")))
                                    Next
                                 End If
                              End With
                           Next

                           moDataTable.Rows.Add(GetRowNull)
                        End If
                     End With
                  End If
               End If

               If oRow("TipoCompraId") = 9 Then
                  If mboolDetalleCompra Then
                     With oCompra
                        .SelectFilter = clsCompra.SelectFilters.All
                        .WhereFilter = clsCompra.WhereFilters.PrimaryKey
                        .OrderByFilter = clsCompra.OrderByFilters.CompraId
                        .CompraId = AnticipoDetCompraIdFind(oRow("DocumentoId"), oRow("ProveedorMovDes"))

                        If .Open Then
                           For Each oRowCompra In .DataSet.Tables(.TableName).Rows
                              moDataTable.Rows.Add(GetCompra(oRowCompra, oRow("TipoCompraId")))

                              With oCompraDet
                                 .SelectFilter = clsCompraDet.SelectFilters.Grid
                                 .WhereFilter = clsCompraDet.WhereFilters.Grid
                                 .OrderByFilter = clsCompraDet.OrderByFilters.Grid
                                 .EmpresaId = mlngEmpresaId
                                 .CompraId = oRowCompra("CompraId")

                                 If .Open() Then
                                    For Each oRowCompraDet In .DataSet.Tables(.TableName).Rows
                                       moDataTable.Rows.Add(GetCompraDet(oRowCompraDet, oRow("TipoCompraId"), oRowCompra("MonedaId"), oRowCompra("TipoCambio")))
                                    Next
                                 End If
                              End With
                           Next

                           moDataTable.Rows.Add(GetRowNull)
                        End If
                     End With
                  End If
               End If

               If (oRow("TipoCompraId") = 7) Or (oRow("TipoCompraId") = 10) Then 'Cobro o Ajuste
                  If decInteres > 0 Then
                     moDataTable.Rows.Add(GetRowInteres(oRow, decInteres))
                  End If
               End If
            Next

            moDataTable.Rows.Add(GetFooter)
            moDataTable.Rows.Add(GetRowNull)
         End If
      End With
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moProveedorMov.TableName)

      moDataTable.Columns.Add("ProveedorMovId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ProveedorId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoCompraId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCompraDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("DocumentoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("DocumentoNro", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompraOrden", Type.GetType("System.String"))
      moDataTable.Columns.Add("ProveedorMovDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("MonedaId", Type.GetType("System.Int32"))

      If mboolDetalleCompra Then
         moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Precio", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Importe", Type.GetType("System.Decimal"))
      End If

      moDataTable.Columns.Add("Debe", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Haber", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Saldo", Type.GetType("System.Decimal"))
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow, ByRef decInteres As Decimal) As DataRow
      Dim lngDocumentoNro As Long
      Dim strCompraOrden As String

      decInteres = 0

      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("ProveedorMovId") = oDataRow("ProveedorMovId")
      oRow("ProveedorId") = oDataRow("ProveedorId")
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
      oRow("TipoCompraId") = oDataRow("TipoCompraId")
      oRow("TipoCompraDes") = oDataRow("TipoCompraDes")
      oRow("DocumentoId") = oDataRow("DocumentoId")
      oRow("CompraOrden") = ""

      If oRow("TipoCompraId") = 2 Then 'Compra
         oRow("TipoCompraDes") &= " Contado"
         oRow("DocumentoNro") = CompraNroFind(oRow("DocumentoId"), strCompraOrden)
         oRow("CompraOrden") = strCompraOrden
         oRow("ProveedorMovDes") = strCompraOrden

      ElseIf oRow("TipoCompraId") = 3 Then 'Devolución Compra
         oRow("DocumentoNro") = DevCompraNroFind(oRow("DocumentoId"))
         oRow("ProveedorMovDes") = oDataRow("ProveedorMovDes")

      ElseIf oRow("TipoCompraId") = 4 Then 'Anticipo
         oRow("DocumentoNro") = AnticipoNroFind(oRow("DocumentoId"))
         oRow("ProveedorMovDes") = oDataRow("ProveedorMovDes")

      ElseIf oRow("TipoCompraId") = 5 Then 'Devolución Anticipo
         oRow("DocumentoNro") = AnticipoNroFind(oRow("DocumentoId"))
         oRow("ProveedorMovDes") = oDataRow("ProveedorMovDes")

      ElseIf oRow("TipoCompraId") = 6 Then 'Credito
         oRow("DocumentoNro") = CreditoNroFind(oRow("DocumentoId"))
         strCompraOrden = CompraOrdenFind(oRow("DocumentoId"))
         oRow("CompraOrden") = strCompraOrden
         If ToStr(oDataRow("ProveedorMovDes")) <> "" Then
            oRow("ProveedorMovDes") = oDataRow("ProveedorMovDes") & "; "
         End If

         If strCompraOrden <> "" Then
            oRow("ProveedorMovDes") &= "Nro. Orden " & strCompraOrden
         End If

      ElseIf oRow("TipoCompraId") = 7 Then 'Cobro
         oRow("DocumentoNro") = PagoNroFind(oRow("DocumentoId"), decInteres)
         oRow("ProveedorMovDes") = oDataRow("ProveedorMovDes")
         oRow("CompraOrden") = PagoCompraOrdenFind(oRow("DocumentoId"))

         If oDataRow("TipoPagoId") = 1 Then
            oRow("TipoCompraDes") = "Cob. Vta Contado"
         Else
            oRow("TipoCompraDes") = "Cobranza Credito"
         End If

      ElseIf oRow("TipoCompraId") = 8 Then 'Saldo Inicial
         oRow("DocumentoNro") = CreditoNroFind(oRow("DocumentoId"))
         oRow("ProveedorMovDes") = oDataRow("ProveedorMovDes")

      ElseIf oRow("TipoCompraId") = 9 Then 'Descargo Anticipo
         oRow("DocumentoNro") = AnticipoNroFind(AnticipoIdFind(oRow("DocumentoId")))
         oRow("ProveedorMovDes") = oDataRow("ProveedorMovDes")

      ElseIf oRow("TipoCompraId") = 10 Then 'Ajuste
         oRow("DocumentoNro") = AjusteNroFind(oRow("DocumentoId"), decInteres)
         oRow("ProveedorMovDes") = oDataRow("ProveedorMovDes")
      End If

      oRow("MonedaId") = oDataRow("MonedaId")

      If mlngMonedaId = 1 Then
         oRow("Debe") = oDataRow("DebeBs")
         oRow("Haber") = oDataRow("HaberBs")

      ElseIf mlngMonedaId = 2 Then
         oRow("Debe") = oDataRow("DebeUs")
         oRow("Haber") = oDataRow("HaberUs")
      End If

      If (oRow("TipoCompraId") = 7) Or (oRow("TipoCompraId") = 10) Then 'Cobro o Ajuste
         oRow("Haber") += decInteres
      End If

      mdecDebe += ToDecimal(oRow("Debe"))
      mdecHaber += ToDecimal(oRow("Haber"))
      mdecSaldo += ToDecimal(oRow("Haber") - oRow("Debe"))

      oRow("Saldo") = mdecSaldo

      Return oRow
   End Function

   Private Function GetRowInteres(ByVal oDataRow As DataRow, ByVal decInteres As Decimal) As DataRow
      Dim lngDocumentoNro As Long
      Dim strCompraOrden As String

      decInteres = 0

      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("ProveedorMovId") = oDataRow("ProveedorMovId")
      oRow("ProveedorId") = oDataRow("ProveedorId")
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
      oRow("TipoCompraId") = oDataRow("TipoCompraId")
      oRow("DocumentoId") = oDataRow("DocumentoId")

      If oRow("TipoCompraId") = 7 Then 'Cobro
         oRow("DocumentoNro") = PagoNroFind(oRow("DocumentoId"), decInteres)
         oRow("TipoCompraDes") = "Interes Cobtranza"

      ElseIf oRow("TipoCompraId") = 10 Then 'Ajuste
         oRow("DocumentoNro") = AjusteNroFind(oRow("DocumentoId"), decInteres)
         oRow("TipoCompraDes") = "Interes Ajuste"
      End If

      oRow("MonedaId") = oDataRow("MonedaId")

      oRow("Debe") = decInteres
      oRow("Haber") = 0

      mdecDebe += ToDecimal(oRow("Debe"))
      mdecHaber += ToDecimal(oRow("Haber"))
      mdecSaldo += ToDecimal(oRow("Haber") - oRow("Debe"))

      oRow("Saldo") = mdecSaldo

      Return oRow
   End Function

   Private Function GetHeader(ByVal lngProveedorId As Long) As DataRow
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         oRow("ProveedorMovId") = -1
         oRow("TipoCompraDes") = "Proveedor"
         oRow("Saldo") = mdecSaldo

         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               oRow("DocumentoNro") = .ProveedorCod
               oRow("ProveedorMovDes") = .ProveedorDes
            End If
         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function GetCompra(ByVal oDataRow As DataRow, ByVal lngTipoCompraId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("ProveedorMovId") = -2
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
      oRow("TipoCompraId") = 2
      oRow("TipoCompraDes") = "Compra"
      oRow("DocumentoId") = oDataRow("CompraId")
      oRow("DocumentoNro") = oDataRow("CompraNro")



      If ToStr(oDataRow("CompraOrden")) <> "" Then
         oRow("CompraOrden") = oDataRow("CompraOrden")
         oRow("ProveedorMovDes") = oDataRow("CompraOrden") & "; " & oDataRow("CompraDes")
      Else
         oRow("ProveedorMovDes") = oDataRow("CompraDes")
      End If

      oRow("MonedaId") = oDataRow("MonedaId")

      If mboolDetalleCompra Then
         If lngTipoCompraId <> 9 Then
            If oDataRow("MonedaId") = mlngMonedaId Then
               oRow("Importe") = oDataRow("MontoLiq")

            ElseIf oDataRow("MonedaId") = 1 Then
               oRow("Importe") = oDataRow("MontoLiq") / ToDivByCero(oDataRow("TipoCambio"))

            ElseIf oDataRow("MonedaId") = 2 Then
               oRow("Importe") = oDataRow("MontoLiq") * oDataRow("TipoCambio")
            End If

         ElseIf mlngCompraId <> oDataRow("CompraId") Then
            If oDataRow("MonedaId") = mlngMonedaId Then
               oRow("Importe") = oDataRow("MontoLiq")

            ElseIf oDataRow("MonedaId") = 1 Then
               oRow("Importe") = oDataRow("MontoLiq") / ToDivByCero(oDataRow("TipoCambio"))

            ElseIf oDataRow("MonedaId") = 2 Then
               oRow("Importe") = oDataRow("MontoLiq") * oDataRow("TipoCambio")
            End If
         End If
      End If

      Return oRow
   End Function

   Private Function GetCompraDet(ByVal oDataRow As DataRow, ByVal lngTipoCompraId As Long, ByVal lngMonedaId As Long, ByVal decTipoCambio As Decimal) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("ProveedorMovId") = -2
      oRow("TipoCompraDes") = "Item"
      oRow("DocumentoNro") = oDataRow("ItemCod")
      'oRow("CompraOrden") = oDataRow("CompraOrden")
      oRow("ProveedorMovDes") = oDataRow("ItemDes")

      If mboolDetalleCompra Then
         If lngTipoCompraId <> 9 Then
            oRow("Cantidad") = oDataRow("Cantidad")

            If lngMonedaId = mlngMonedaId Then
               oRow("Precio") = oDataRow("PrecioOrg")
               oRow("Importe") = oDataRow("Importe")

            ElseIf lngMonedaId = 1 Then
               oRow("Precio") = oDataRow("PrecioOrg") / ToDivByCero(decTipoCambio)
               oRow("Importe") = oDataRow("Importe") / ToDivByCero(decTipoCambio)

            ElseIf lngMonedaId = 2 Then
               oRow("Precio") = oDataRow("PrecioOrg") * decTipoCambio
               oRow("Importe") = oDataRow("Importe") * decTipoCambio
            End If

         ElseIf mlngCompraId <> oDataRow("CompraId") Then
            oRow("Cantidad") = oDataRow("Cantidad")

            If lngMonedaId = mlngMonedaId Then
               oRow("Precio") = oDataRow("PrecioOrg")
               oRow("Importe") = oDataRow("Importe")

            ElseIf lngMonedaId = 1 Then
               oRow("Precio") = oDataRow("PrecioOrg") / ToDivByCero(decTipoCambio)
               oRow("Importe") = oDataRow("Importe") / ToDivByCero(decTipoCambio)

            ElseIf lngMonedaId = 2 Then
               oRow("Precio") = oDataRow("PrecioOrg") * decTipoCambio
               oRow("Importe") = oDataRow("Importe") * decTipoCambio
            End If

            mlngCompraId = oDataRow("CompraId")
         End If
      End If

      Return oRow
   End Function

   Private Function GetFooter() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("ProveedorMovId") = -1
      oRow("ProveedorMovDes") = "Total " & MonedaDesFind(mlngMonedaId) & " :"
      oRow("Debe") = mdecDebe
      oRow("Haber") = mdecHaber
      oRow("Saldo") = mdecSaldo

      Return oRow
   End Function

    Private Function GetFooterTotal() As DataRow
        Dim oRow As DataRow
        oRow = moDataTable.NewRow

        oRow("ProveedorMovId") = -3
        '  oRow("ProveedorMovDes") = "Total " & MonedaDesFind(mlngMonedaId) & " :"
        oRow("Debe") = ToDecimal(moDataTable.Compute("Sum(Debe)", "ProveedorMovId = -1"))
        oRow("Haber") = ToDecimal(moDataTable.Compute("Sum(Haber)", "ProveedorMovId = -1"))
        oRow("Saldo") = ToDecimal(moDataTable.Compute("Sum(Saldo)", "ProveedorMovId = -1"))

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
            .SelectFilter = clsMoneda.SelectFilters.All
            .WhereFilter = clsMoneda.WhereFilters.PrimaryKey
            .MonedaId = lngMonedaId

            If .Find Then
               MonedaDesFind = .MonedaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMoneda.Dispose()

      End Try
   End Function

   Private Function CompraNroFind(ByVal lngCompraId As Long, ByRef strCompraOrden As String) As Long
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      CompraNroFind = 0

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               strCompraOrden = .CompraOrden
               Return .CompraNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function DevCompraNroFind(ByVal lngDevCompraId As Long) As Long
      Dim oDevCompra As New clsDevCompra(clsAppInfo.ConnectString)

      DevCompraNroFind = 0

      Try
         With oDevCompra
            .DevCompraId = lngDevCompraId

            If .FindByPK Then
               Return .DevCompraNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDevCompra.Dispose()

      End Try
   End Function

   Private Function AnticipoNroFind(ByVal lngAnticipoId As Long) As Long
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

      AnticipoNroFind = 0

      Try
         With oAnticipo
            .AnticipoId = lngAnticipoId

            If .FindByPK Then
               Return .AnticipoNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function AnticipoIdFind(ByVal lngAnticipoDetId As Long) As Long
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoIdFind = 0

      Try
         With oAnticipoDet
            .AnticipoDetId = lngAnticipoDetId

            If .FindByPK Then
               AnticipoIdFind = .AnticipoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function CreditoNroFind(ByVal lngCreditoId As Long) As Long
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      CreditoNroFind = 0

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               Return .CreditoNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function PagoNroFind(ByVal lngPagoId As Long, ByRef decInteres As Decimal) As Long
      Dim oPago As New clsPago(clsAppInfo.ConnectString)

      PagoNroFind = 0

      Try
         With oPago
            .PagoId = lngPagoId

            If .FindByPK Then
               decInteres = ToDecimalByMoneda(mlngMonedaId, .MonedaId, .Interes, .TipoCambio)
               Return .PagoNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPago.Dispose()

      End Try
   End Function

   Private Function AjusteNroFind(ByVal lngAjusteId As Long, ByRef decInteres As Decimal) As Long
      Dim oAjuste As New clsAjuste(clsAppInfo.ConnectString)

      AjusteNroFind = 0

      Try
         With oAjuste
            .AjusteId = lngAjusteId

            If .FindByPK Then
               decInteres = ToDecimalByMoneda(mlngMonedaId, .MonedaId, .Interes, .TipoCambio)
               Return .AjusteNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAjuste.Dispose()

      End Try
   End Function

   Private Function CompraOrdenFind(ByVal lngCreditoId As Long) As String
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim strCompraOrden As String

      CompraOrdenFind = ""

      Try
         With oCompra
            .SelectFilter = clsCompra.SelectFilters.All
            .WhereFilter = clsCompra.WhereFilters.CreditoId
            .OrderByFilter = clsCompra.OrderByFilters.CompraId
            .EmpresaId = mlngEmpresaId
            .CreditoId = lngCreditoId

            If .Open Then
               Do While .Read
                  If .CompraOrden <> "" Then
                     strCompraOrden = .CompraOrden & " "
                  End If

                  .MoveNext()
               Loop

               Return strCompraOrden
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function AnticipoDetCompraIdFind(ByVal lngAnticipoId As Long, ByVal strProveedorMovDes As String) As Long
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoDetCompraIdFind = 0

      Try
         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.CompraId
            .EmpresaId = mlngEmpresaId
            .AnticipoId = lngAnticipoId
            .TipoCompraId = 2
            .AnticipoDetDes = strProveedorMovDes

            If .Find Then
               Return .DocumentoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function ProveedoresaldoAnterior(ByVal lngProveedorId As Long) As Decimal
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)
      Dim decDebe As Decimal = 0
      Dim decHaber As Decimal = 0

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.SaldoAnterior
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .ProveedorId = lngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            '.TipoPagoId = 2 'Solo Cobro de Creditos
            .Fecha = mstrFechaIni
            .EstadoId = 11 'Abierto

            If .Open() Then
               Do While .Read()
                  If mlngMonedaId = 1 Then
                     decDebe += .DebeBs
                     decHaber += .HaberBs

                  ElseIf mlngMonedaId = 2 Then
                     decDebe += .DebeUs
                     decHaber += .HaberUs
                  End If

                  .MoveNext()
               Loop
            End If

            ProveedoresaldoAnterior = ToDecimal(decHaber - decDebe)
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function ProveedoresaldoIntervalo(ByVal lngProveedorId As Long) As Decimal
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)
      Dim decDebe As Decimal = 0
      Dim decHaber As Decimal = 0

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.SaldoIntervalo
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .ProveedorId = lngProveedorId
            '.TipoPagoId = 2 'Solo Cobro de Creditos
            .Fecha = mstrFechaIni
            .ProveedorMovDes = mstrFechaFin
            .EstadoId = 11 'Abierto

            If .Open() Then
               Do While .Read()
                  If mlngMonedaId = 1 Then
                     decDebe += .DebeBs
                     decHaber += .HaberBs

                  ElseIf mlngMonedaId = 2 Then
                     decDebe += .DebeUs
                     decHaber += .HaberUs
                  End If

                  .MoveNext()
               Loop
            End If

            ProveedoresaldoIntervalo = ToDecimal(decHaber - decDebe)
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function ProveedoresaldoActual(ByVal lngProveedorId As Long) As Decimal
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)
      Dim decDebe As Decimal = 0
      Dim decHaber As Decimal = 0

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.SaldoActual
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .ProveedorId = lngProveedorId
            '.TipoPagoId = 2 'Solo Cobro de Creditos
            .EstadoId = 11 'Abierto

            If .Open() Then
               Do While .Read()
                  If mlngMonedaId = 1 Then
                     decDebe += .DebeBs
                     decHaber += .HaberBs

                  ElseIf mlngMonedaId = 2 Then
                     decDebe += .DebeUs
                     decHaber += .HaberUs
                  End If

                  .MoveNext()
               Loop
            End If

            ProveedoresaldoActual = ToDecimal(decHaber - decDebe)
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function TieneMovimiento(ByVal lngProveedorId As Long) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      TieneMovimiento = False

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All

            If mboolIntervaloFecha Then
               .WhereFilter = clsProveedorMov.WhereFilters.TieneMovimientoFecha
               .Fecha = mstrFechaIni
               .ProveedorMovDes = mstrFechaFin
            Else
               .WhereFilter = clsProveedorMov.WhereFilters.TieneMovimiento
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .ProveedorId = lngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .EstadoId = clsEstado.ABIERTO 'Abierto

            If .Find Then
               TieneMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Sub DocumentoEditLoad()
      If grdMain.RowCount > 0 Then
         If ToLong(grdMain.GetValue("ProveedorMovId")) <> 0 Then

            If ToLong(grdMain.GetValue("TipoCompraId")) = 2 Then 'Compra
               Call frmCompraEditLoad(ToLong(grdMain.GetValue("DocumentoId")), ToLong(grdMain.GetValue("ProveedorMovId")))

            ElseIf ToLong(grdMain.GetValue("TipoCompraId")) = 3 Then 'Devolución Compra
               Call frmDevCompraEditLoad(ToLong(grdMain.GetValue("DocumentoId")), ToLong(grdMain.GetValue("ProveedorMovId")))

            ElseIf ToLong(grdMain.GetValue("TipoCompraId")) = 4 Then 'Anticipo
               Call frmAnticipoEditLoad(ToLong(grdMain.GetValue("DocumentoId")), ToLong(grdMain.GetValue("ProveedorMovId")))

            ElseIf ToLong(grdMain.GetValue("TipoCompraId")) = 5 Then 'Devolución Anticipo
               Call frmAnticipoEditLoad(ToLong(grdMain.GetValue("DocumentoId")), ToLong(grdMain.GetValue("ProveedorMovId")))

            ElseIf ToLong(grdMain.GetValue("TipoCompraId")) = 6 Then 'Credito
               Call frmCreditoEditLoad(ToLong(grdMain.GetValue("DocumentoId")), ToLong(grdMain.GetValue("ProveedorMovId")))

            ElseIf ToLong(grdMain.GetValue("TipoCompraId")) = 7 Then 'Cobro
               Call frmPagoEditLoad(ToLong(grdMain.GetValue("DocumentoId")), ToLong(grdMain.GetValue("ProveedorMovId")))

            ElseIf ToLong(grdMain.GetValue("TipoCompraId")) = 8 Then 'Saldo Inicial
               Call frmCreditoEditLoad(ToLong(grdMain.GetValue("DocumentoId")), ToLong(grdMain.GetValue("ProveedorMovId")))

            ElseIf ToLong(grdMain.GetValue("TipoCompraId")) = 9 Then 'Descargo Anticipo
               Dim lngAnticipoId As Long = AnticipoId(ToLong(grdMain.GetValue("DocumentoId")))
               Call frmAnticipoEditLoad(lngAnticipoId, ToLong(grdMain.GetValue("ProveedorMovId")))

            ElseIf ToLong(grdMain.GetValue("TipoCompraId")) = 10 Then 'Ajuste
               Call frmAjusteEditLoad(ToLong(grdMain.GetValue("DocumentoId")), ToLong(grdMain.GetValue("ProveedorMovId")))

            End If
         Else
            MessageBox.Show("Registro Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Registro Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If

   End Sub

   Private Sub frmCompraEditLoad(ByVal lngCompraId As Long, ByVal lngProveedorMovId As Long)
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         If lngCompraId > 0 Then
            With oCompra
               .CompraId = lngCompraId

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
            MessageBox.Show("Número de Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   Private Sub frmDevCompraEditLoad(ByVal lngDevCompraId As Long, ByVal lngProveedorMovId As Long)
      Dim oDevCompra As New clsDevCompra(clsAppInfo.ConnectString)

      Try
         If lngDevCompraId > 0 Then
            With oDevCompra
               .DevCompraId = lngDevCompraId

               If .FindByPK Then
                  Dim frm As New frmDevCompraEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oDevCompra
                  frm.ShowDialog()

                  frm.Dispose()

               End If
            End With
         Else
            MessageBox.Show("Número de Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDevCompra.Dispose()

      End Try
   End Sub

   Private Sub frmAnticipoEditLoad(ByVal lngAnticipoId As Long, ByVal lngProveedorMovId As Long)
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

      Try
         If lngAnticipoId > 0 Then
            With oAnticipo
               .AnticipoId = lngAnticipoId

               If .FindByPK Then
                  Dim frm As New frmAnticipoEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oAnticipo
                  frm.ShowDialog()

                  frm.Dispose()

               End If
            End With
         Else
            MessageBox.Show("Número de Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Sub

   Private Function AnticipoId(ByVal lngAnticipoDetId As Long) As Long
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)
      Try
         With oAnticipoDet
            .AnticipoDetId = lngAnticipoDetId

            If .FindByPK Then
               AnticipoId = .AnticipoId
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Sub frmCreditoEditLoad(ByVal lngCreditoId As Long, ByVal lngProveedorMovId As Long)
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      Try
         If lngCreditoId > 0 Then
            With oCredito
               .CreditoId = lngCreditoId

               If .FindByPK Then
                  Dim frm As New frmCreditoEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oCredito
                  frm.ShowDialog()

                  frm.Dispose()

               End If
            End With
         Else
            MessageBox.Show("Número de Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Sub

   Private Sub frmPagoEditLoad(ByVal lngPagoId As Long, ByVal lngProveedorMovId As Long)
      Dim oPago As New clsPago(clsAppInfo.ConnectString)

      Try
         If lngPagoId > 0 Then
            With oPago
               .PagoId = lngPagoId

               If .FindByPK Then
                  Dim frm As New frmPagoEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oPago
                  frm.ShowDialog()

                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Número de Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPago.Dispose()

      End Try
   End Sub

   Private Sub frmAjusteEditLoad(ByVal lngAjusteId As Long, ByVal lngProveedorMovId As Long)
      Dim oAjuste As New clsAjuste(clsAppInfo.ConnectString)

      Try
         If lngAjusteId > 0 Then
            With oAjuste
               .AjusteId = lngAjusteId

               If .FindByPK Then
                  Dim frm As New frmAjusteEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oAjuste
                  frm.ShowDialog()

                  frm.Dispose()

               End If
            End With
         Else
            MessageBox.Show("Número de Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAjuste.Dispose()

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
      If Not mboolDetalleCompra Then
         Dim rpt As New rptProveedorExtra

         rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moProveedorMov.TableName))

         rpt.lblTitle.Text = "Extracto de Proveedores"
         rpt.Document.Name = "Extracto de Proveedores"
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

      Else
         Dim rpt As New rptProveedorExtraDet

         rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moProveedorMov.TableName))

         rpt.lblTitle.Text = "Extracto de Proveedores"
         rpt.Document.Name = "Extracto de Proveedores"
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
      End If
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("ProveedorMovId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moProveedorMov = New clsProveedorMov(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Extracto de Proveedores"

         .RootTable.Columns("ProveedorMovId").Visible = False

         .RootTable.Columns("ProveedorId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompraId").Visible = False

         .RootTable.Columns("TipoCompraDes").Caption = "Tipo"
         .RootTable.Columns("TipoCompraDes").Width = 100
         .RootTable.Columns("TipoCompraDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompraDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("DocumentoId").Visible = False

         .RootTable.Columns("DocumentoNro").Caption = "Número"
         .RootTable.Columns("DocumentoNro").Width = 80
         .RootTable.Columns("DocumentoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("DocumentoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center


         .RootTable.Columns("CompraOrden").Caption = "Nro. Orden"
         .RootTable.Columns("CompraOrden").Width = 80
         .RootTable.Columns("CompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ProveedorMovDes").Caption = "Descripción"
         .RootTable.Columns("ProveedorMovDes").Width = 150
         .RootTable.Columns("ProveedorMovDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorMovDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         If mboolDetalleCompra Then
            .RootTable.Columns("Cantidad").Caption = "Cantidad"
            .RootTable.Columns("Cantidad").FormatString = DecimalMask()
            .RootTable.Columns("Cantidad").Width = 80
            .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Precio").Caption = "Precio"
            .RootTable.Columns("Precio").FormatString = DecimalMask()
            .RootTable.Columns("Precio").Width = 80
            .RootTable.Columns("Precio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Precio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Importe").Caption = "Importe"
            .RootTable.Columns("Importe").FormatString = DecimalMask()
            .RootTable.Columns("Importe").Width = 80
            .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         End If

         .RootTable.Columns("Debe").Caption = "Debe"
         .RootTable.Columns("Debe").FormatString = DecimalMask()
         .RootTable.Columns("Debe").Width = 80
         .RootTable.Columns("Debe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Debe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Haber").Caption = "Haber"
         .RootTable.Columns("Haber").FormatString = DecimalMask()
         .RootTable.Columns("Haber").Width = 80
         .RootTable.Columns("Haber").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Haber").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Saldo").Caption = "Saldo"
         .RootTable.Columns("Saldo").FormatString = DecimalMask()
         .RootTable.Columns("Saldo").Width = 80
         .RootTable.Columns("Saldo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Saldo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

        fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Saldo"), Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
        fc.FormatStyle.ForeColor = Color.DarkRed
        grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("ProveedorMovId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("ProveedorMovId"), Janus.Windows.GridEX.ConditionOperator.Equal, -2)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

        fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("ProveedorMovId"), Janus.Windows.GridEX.ConditionOperator.Equal, -3)
        fc.FormatStyle.ForeColor = Color.DarkOrange
        grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call DocumentoEditLoad()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmProveedorExtra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call DocumentoEditLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmProveedorExtra_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moProveedorMov.Dispose()
      Call ClearMemory()
   End Sub

   Private Function PagoCompraOrdenFind(ByVal lngPagoId As Long) As String
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim oPagoDet As New clsPagoDet(clsAppInfo.ConnectString)
      Dim strCompraOrden As String = ""

      PagoCompraOrdenFind = ""

      Try
         With oPagoDet
            .SelectFilter = clsPagoDet.SelectFilters.All
            .WhereFilter = clsPagoDet.WhereFilters.PagoId
            .OrderByFilter = clsPagoDet.OrderByFilters.PagoDetId
            .EmpresaId = mlngEmpresaId
            .PagoId = lngPagoId

            If .Open Then

               For Each oRowPagoDet In .DataSet.Tables(.TableName).Rows
                  With oCompra
                     .SelectFilter = clsCompra.SelectFilters.All
                     .WhereFilter = clsCompra.WhereFilters.PrimaryKey
                     .EmpresaId = mlngEmpresaId
                     .CompraId = oRowPagoDet("CompraId")

                     If .Open Then
                        Do While .Read
                           If .CompraOrden <> "" Then
                              strCompraOrden = .CompraOrden & " "
                           End If

                           .MoveNext()
                        Loop

                        Return strCompraOrden

                     End If
                  End With
               Next

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()
         oPagoDet.Dispose()
      End Try

   End Function

End Class
