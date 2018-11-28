Public Class frmFlujoCaja
   Inherits System.Windows.Forms.Form

   Private moCompra As clsCompra

   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mboolIntervaloFecha As Boolean
   Private mdatFechaIni As Date
   Private mdatFechaFin As Date

   Private mboolDetallado As Boolean

   Private mdecMontoTotal As Decimal

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

   Property FechaIni() As Date
      Get
         Return mdatFechaIni
      End Get

      Set(ByVal Value As Date)
         mdatFechaIni = Value
      End Set
   End Property

   Property FechaFin() As Date
      Get
         Return mdatFechaFin
      End Get

      Set(ByVal Value As Date)
         mdatFechaFin = Value
      End Set
   End Property

   WriteOnly Property Detallado() As Boolean
      Set(ByVal Value As Boolean)
         mboolDetallado = Value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlujoCaja))
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
      'frmFlujoCaja
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmFlujoCaja"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Flujo de Caja de Compras"
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

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmFlujoCaja_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmFlujoCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

      Try
         Call moDataSetInit()

         Call oRowSaldoInicialAdd()
         Call oRowNullAdd()

         Call oRowCompraAdd()
         Call oRowNullAdd()

         Call oRowDevCompraAdd()
         Call oRowNullAdd()

         Call oRowPagoAdd()
         Call oRowNullAdd()

         Call oRowAnticipoAdd()
         Call oRowNullAdd()

         Call oRowTotalAdd()

         grdMain.DataSource = moDataSet.Tables("FlujoCaja").DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add("FlujoCaja")

      moDataTable.Columns.Add("Tipo", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("DocumentoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Op", Type.GetType("System.String"))
      moDataTable.Columns.Add("Monto", Type.GetType("System.Decimal"))

   End Sub

   Private Sub oRowSaldoInicialAdd()
      Dim oRowCred As DataRow
      Dim oRowAnt As DataRow
      Dim oRowTotal As DataRow
      Dim decMontoCred As Decimal = 0
      Dim decMontoAnt As Decimal = 0
      Dim lngPosRow As Long = 0

      oRowAnt = moDataTable.NewRow
      oRowCred = moDataTable.NewRow
      oRowTotal = moDataTable.NewRow

      If Not mboolDetallado Then

         If mboolIntervaloFecha Then
            oRowAnt("Tipo") = 0
            oRowAnt("Op") = "+"
            oRowAnt("DocumentoDes") = " Saldo Anterior"
            decMontoAnt = ToDecimal(SaldoAnterior())
            oRowAnt("Monto") = decMontoAnt

            moDataTable.Rows.Add(oRowAnt)
         End If

         oRowCred("Tipo") = 0
         oRowCred("Op") = "+"
         oRowCred("DocumentoDes") = " Saldo Inicial"
         oRowCred("Monto") = ToDecimal(SaldoIniMontoFind())

         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "+"
         oRowTotal("DocumentoDes") = " Total Saldos Inicial"
         oRowTotal("Monto") = ToDecimal(oRowCred("Monto") + decMontoAnt)

         mdecMontoTotal += oRowTotal("Monto")

         moDataTable.Rows.Add(oRowCred)
         moDataTable.Rows.Add(oRowTotal)

      Else

         If mboolIntervaloFecha Then
            oRowAnt("Tipo") = 0
            oRowAnt("Op") = "+"
            oRowAnt("DocumentoDes") = " Saldo Anterior"
            decMontoAnt = ToDecimal(SaldoAnterior())
            oRowAnt("Monto") = decMontoAnt

            moDataTable.Rows.Add(oRowAnt)
         End If

         oRowCred("Tipo") = 0
         oRowCred("Op") = "+"
         oRowCred("DocumentoDes") = " Saldos Inicial"
         oRowCred("Monto") = 0

         moDataTable.Rows.Add(oRowCred)
         lngPosRow = moDataTable.Rows.Count - 1
         decMontoCred = ToDecimal(SaldoIniMontoCreditoFind())
         moDataTable.Rows(lngPosRow)("Monto") = decMontoCred


         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "+"
         oRowTotal("DocumentoDes") = " Totales Saldo Inicial"
         oRowTotal("Monto") = ToDecimal(decMontoCred + decMontoAnt)

         mdecMontoTotal += oRowTotal("Monto")

         moDataTable.Rows.Add(oRowTotal)
      End If

   End Sub

   Private Sub oRowCompraAdd()
      Dim oRowCont As DataRow
      Dim oRowCred As DataRow
      Dim oRowTotal As DataRow
      Dim decMontoCred As Decimal = 0
      Dim decMontoCont As Decimal = 0
      Dim lngPosRow As Long = 0

      oRowCont = moDataTable.NewRow
      oRowCred = moDataTable.NewRow
      oRowTotal = moDataTable.NewRow

      If Not mboolDetallado Then
         oRowCont("Tipo") = 0
         oRowCont("Op") = "+"
         oRowCont("DocumentoDes") = " Compras al Contado"
         oRowCont("Monto") = ToDecimal(compraMontoContFind(decMontoCred))

         oRowCred("Tipo") = 0
         oRowCred("Op") = "+"
         oRowCred("DocumentoDes") = " Compras al Crédito"
         oRowCred("Monto") = ToDecimal(decMontoCred)

         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "+"
         oRowTotal("DocumentoDes") = " Totales Compras"
         oRowTotal("Monto") = ToDecimal(oRowCont("Monto") + oRowCred("Monto"))

         mdecMontoTotal += oRowTotal("Monto")

         moDataTable.Rows.Add(oRowCont)
         moDataTable.Rows.Add(oRowCred)
         moDataTable.Rows.Add(oRowTotal)

      Else

         oRowCont("Tipo") = 0
         oRowCont("Op") = "+"
         oRowCont("DocumentoDes") = " Compras al Contado"
         oRowCont("Monto") = 0
         moDataTable.Rows.Add(oRowCont)
         lngPosRow = moDataTable.Rows.Count - 1
         decMontoCont = ToDecimal(compraMontoContadoFind())
         moDataTable.Rows(lngPosRow)("Monto") = decMontoCont

         oRowCred("Tipo") = 0
         oRowCred("Op") = "+"
         oRowCred("DocumentoDes") = " Compras al Crédito"
         oRowCred("Monto") = 0

         moDataTable.Rows.Add(oRowCred)
         lngPosRow = moDataTable.Rows.Count - 1
         decMontoCred = ToDecimal(compraMontoCreditoFind())
         moDataTable.Rows(lngPosRow)("Monto") = decMontoCred

         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "+"
         oRowTotal("DocumentoDes") = " Totales Compras"
         oRowTotal("Monto") = ToDecimal(decMontoCont + decMontoCred)

         mdecMontoTotal += oRowTotal("Monto")

         moDataTable.Rows.Add(oRowTotal)
      End If

   End Sub

   Private Sub oRowDevCompraAdd()
      Dim oRowCont As DataRow
      Dim oRowCred As DataRow
      Dim oRowTotal As DataRow
      Dim decMontoCred As Decimal = 0
      Dim decMontoCont As Decimal = 0
      Dim lngPosRow As Long = 0

      oRowCont = moDataTable.NewRow
      oRowCred = moDataTable.NewRow
      oRowTotal = moDataTable.NewRow

      If Not mboolDetallado Then

         oRowCont("Tipo") = 0
         oRowCont("Op") = "-"
         oRowCont("DocumentoDes") = " Devoluciones de Compras al Contado"
         oRowCont("Monto") = ToDecimal(devCompraMontoContFind(decMontoCred))

         oRowCred("Tipo") = 0
         oRowCred("Op") = ""
         oRowCred("DocumentoDes") = " Devoluciones de Compras al Crédito"
         oRowCred("Monto") = ToDecimal(decMontoCred)

         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "-"
         oRowTotal("DocumentoDes") = " Totales Devoluciones de Compras"
         oRowTotal("Monto") = ToDecimal(oRowCont("Monto"))

         mdecMontoTotal -= oRowTotal("Monto")

         moDataTable.Rows.Add(oRowCont)
         moDataTable.Rows.Add(oRowCred)
         moDataTable.Rows.Add(oRowTotal)

      Else

         oRowCont("Tipo") = 0
         oRowCont("Op") = "-"
         oRowCont("DocumentoDes") = " Devoluciones de Compras al Contado"
         oRowCont("Monto") = 0
         moDataTable.Rows.Add(oRowCont)
         lngPosRow = moDataTable.Rows.Count - 1
         decMontoCont = ToDecimal(devCompraMontoContadoFind())
         moDataTable.Rows(lngPosRow)("Monto") = decMontoCont

         oRowCred("Tipo") = 0
         oRowCred("Op") = ""
         oRowCred("DocumentoDes") = " Devoluciones de Compras al Crédito"
         oRowCred("Monto") = 0
         moDataTable.Rows.Add(oRowCred)
         lngPosRow = moDataTable.Rows.Count - 1
         decMontoCred = ToDecimal(devCompraMontoCreditoFind())
         moDataTable.Rows(lngPosRow)("Monto") = decMontoCred

         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "-"
         oRowTotal("DocumentoDes") = " Totales Devoluciones de Compras"
         oRowTotal("Monto") = ToDecimal(decMontoCont)

         mdecMontoTotal -= oRowTotal("Monto")

         moDataTable.Rows.Add(oRowTotal)
      End If

   End Sub

   Private Sub oRowPagoAdd()
      Dim oRowCont As DataRow
      Dim oRowCred As DataRow
      Dim oRowTotal As DataRow
      Dim decMontoCred As Decimal = 0
      Dim decMontoCont As Decimal = 0
      Dim lngPosRow As Long = 0

      oRowCont = moDataTable.NewRow
      oRowCred = moDataTable.NewRow
      oRowTotal = moDataTable.NewRow

      If Not mboolDetallado Then

         oRowCont("Tipo") = 0
         oRowCont("Op") = "+"
         oRowCont("DocumentoDes") = " Pagos al Contado"
         oRowCont("Monto") = ToDecimal(PagoMontoContFind(decMontoCred))

         oRowCred("Tipo") = 0
         oRowCred("Op") = "+"
         oRowCred("DocumentoDes") = " Pagos al Crédito"
         oRowCred("Monto") = ToDecimal(decMontoCred)

         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "-"
         oRowTotal("DocumentoDes") = " Totales Pagos"
         oRowTotal("Monto") = ToDecimal(oRowCont("Monto") + oRowCred("Monto"))

         mdecMontoTotal -= oRowTotal("Monto")

         moDataTable.Rows.Add(oRowCont)
         moDataTable.Rows.Add(oRowCred)
         moDataTable.Rows.Add(oRowTotal)

      Else

         oRowCont("Tipo") = 0
         oRowCont("Op") = "+"
         oRowCont("DocumentoDes") = " Pagos al Contado"
         oRowCont("Monto") = 0
         moDataTable.Rows.Add(oRowCont)
         lngPosRow = moDataTable.Rows.Count - 1
         decMontoCont = ToDecimal(PagoMontoContadoFind())
         moDataTable.Rows(lngPosRow)("Monto") = decMontoCont

         oRowCred("Tipo") = 0
         oRowCred("Op") = "+"
         oRowCred("DocumentoDes") = " Pagos al Crédito"
         oRowCred("Monto") = 0
         moDataTable.Rows.Add(oRowCred)
         lngPosRow = moDataTable.Rows.Count - 1
         decMontoCred = ToDecimal(PagoMontoCreditoFind())
         moDataTable.Rows(lngPosRow)("Monto") = decMontoCred

         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "-"
         oRowTotal("DocumentoDes") = " Totales Pagos"
         oRowTotal("Monto") = ToDecimal(decMontoCont + decMontoCred)

         mdecMontoTotal -= oRowTotal("Monto")

         moDataTable.Rows.Add(oRowTotal)
      End If


   End Sub

   Private Sub oRowAnticipoAdd()
      Dim oRowAnt As DataRow
      Dim oRowDev As DataRow
      Dim oRowTotal As DataRow
      Dim decMontoDev As Decimal = 0
      Dim decMontoAnt As Decimal = 0
      Dim lngPosRow As Long = 0

      oRowAnt = moDataTable.NewRow
      oRowDev = moDataTable.NewRow
      oRowTotal = moDataTable.NewRow

      If Not mboolDetallado Then
         oRowAnt("Tipo") = 0
         oRowAnt("Op") = "+"
         oRowAnt("DocumentoDes") = " Anticipos"
         oRowAnt("Monto") = ToDecimal(AnticipoMontoFind(decMontoDev))

         oRowDev("Tipo") = 0
         oRowDev("Op") = "-"
         oRowDev("DocumentoDes") = " Devoluciones de Anticipo"
         oRowDev("Monto") = ToDecimal(decMontoDev)

         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "-"
         oRowTotal("DocumentoDes") = " Totales Anticipos"
         oRowTotal("Monto") = ToDecimal(oRowAnt("Monto") - oRowDev("Monto"))

         mdecMontoTotal -= oRowTotal("Monto")

         moDataTable.Rows.Add(oRowAnt)
         moDataTable.Rows.Add(oRowDev)
         moDataTable.Rows.Add(oRowTotal)

      Else
         oRowAnt("Tipo") = 0
         oRowAnt("Op") = "+"
         oRowAnt("DocumentoDes") = " Anticipos"
         oRowAnt("Monto") = 0
         moDataTable.Rows.Add(oRowAnt)
         lngPosRow = moDataTable.Rows.Count - 1
         decMontoAnt = ToDecimal(AnticipoMontoFind())
         moDataTable.Rows(lngPosRow)("Monto") = decMontoAnt

         oRowDev("Tipo") = 0
         oRowDev("Op") = "-"
         oRowDev("DocumentoDes") = " Devoluciones de Anticipo"
         oRowDev("Monto") = 0
         moDataTable.Rows.Add(oRowDev)
         lngPosRow = moDataTable.Rows.Count - 1
         decMontoDev = ToDecimal(DevAnticipoMontoFind())
         moDataTable.Rows(lngPosRow)("Monto") = decMontoDev

         oRowTotal("Tipo") = -1
         oRowTotal("Op") = "-"
         oRowTotal("DocumentoDes") = " Totales Anticipos"
         oRowTotal("Monto") = ToDecimal(decMontoAnt - decMontoDev)

         mdecMontoTotal -= oRowTotal("Monto")

         moDataTable.Rows.Add(oRowTotal)
      End If

   End Sub

   Private Function oRowTotalAdd() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("Tipo") = -2
      oRow("DocumentoDes") = "         Totales General"
      oRow("Monto") = ToDecimal(mdecMontoTotal)

      moDataTable.Rows.Add(oRow)
   End Function

   Private Function GetRowProveedor(ByVal lngProveedorId As Long, ByVal decMonto As Decimal) As DataRow
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               oRow("Tipo") = -3
               oRow("Op") = " "
               oRow("DocumentoDes") = "        " & .ProveedorDes
               oRow("Monto") = decMonto

            End If
         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Sub oRowNullAdd()
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      moDataTable.Rows.Add(oRow)
   End Sub

   Private Function SaldoAnterior() As Decimal
      Dim datFechaFin, datFechaIni As Date
      Dim decCompra, decDevCompra, decPago, decAnticipo, decDevAnticipo As Decimal

      datFechaIni = ToDate(GestionFechaIni(clsAppInfo.GestionId))
      datFechaFin = mdatFechaIni.AddDays(-1)

      SaldoAnterior = SaldoIniAntMontoFind(datFechaFin)
      decCompra = CompraMontoAntFind(datFechaIni, datFechaFin)
      decDevCompra = devCompraMontoAntFind(datFechaIni, datFechaFin)
      decPago = PagoMontoAntFind(datFechaIni, datFechaFin)
      decAnticipo = AnticipoMontoAntFind(datFechaIni, datFechaFin, decDevAnticipo)

      SaldoAnterior = ToDecimal(SaldoAnterior + decCompra - decDevCompra - decPago - (decAnticipo - decDevAnticipo))

   End Function

   Private Function CompraMontoAntFind(ByVal datFechaIni As Date, ByVal datFechaFin As Date) As Decimal
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         CompraMontoAntFind = 0

         With oCompra
            .SelectFilter = clsCompra.SelectFilters.FlujoCaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId

            .Fecha = ToDate(datFechaIni)
            .LastUpdateDate = ToDate(datFechaFin)
            .WhereFilter = clsCompra.WhereFilters.FlujoCajaFecha

            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then

                     '' Monto Compra menos descuentos + recargas
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoBru = (.MontoBru / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoBru = (.MontoBru * .TipoCambio)

                     End If
                  End If

                  CompraMontoAntFind += .MontoBru

                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function devCompraMontoAntFind(ByVal datFechaIni As Date, ByVal datFechaFin As Date) As Decimal
      Dim oDevCompra As New clsDevCompra(clsAppInfo.ConnectString)

      Try
         devCompraMontoAntFind = 0

         With oDevCompra
            .SelectFilter = clsDevCompra.SelectFilters.FlujoCaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId

            .Fecha = ToDate(datFechaIni)
            .LastUpdateDate = ToDate(datFechaFin)
            .WhereFilter = clsDevCompra.WhereFilters.FlujoCajaFecha

            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoOrg = (.MontoOrg / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoOrg = (.MontoOrg * .TipoCambio)

                     End If
                  End If

                  If .TipoPagoId = clsTipoPago.CONTADO Then
                     devCompraMontoAntFind += .MontoOrg
                  End If

                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDevCompra.Dispose()

      End Try
   End Function

   Private Function PagoMontoAntFind(ByVal datFechaIni As Date, ByVal datFechaFin As Date) As Decimal
      Dim oPago As New clsPago(clsAppInfo.ConnectString)

      Try
         PagoMontoAntFind = 0

         With oPago
            .SelectFilter = clsPago.SelectFilters.FlujoCaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId

            .Fecha = ToDate(datFechaIni)
            .LastUpdateDate = ToDate(datFechaFin)

            .WhereFilter = clsPago.WhereFilters.FlujoCajaFecha


            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = 1 Then
                        .MontoPag = (.MontoPag / .TipoCambio)

                     ElseIf .MonedaId = 2 Then
                        .MontoPag = (.MontoPag * .TipoCambio)

                     End If
                  End If

                  PagoMontoAntFind += .MontoPag

                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPago.Dispose()

      End Try
   End Function

   Private Function AnticipoMontoAntFind(ByVal datFechaIni As Date, ByVal datFechaFin As Date, ByRef decMontoDev As Decimal) As Decimal
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

      Try
         AnticipoMontoAntFind = 0
         decMontoDev = 0

         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.FlujoCaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId

            .Fecha = ToDate(datFechaIni)
            .LastUpdateDate = ToDate(datFechaFin)

            .WhereFilter = clsAnticipo.WhereFilters.FlujoCajaFecha


            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = 1 Then
                        .MontoAnt = (.MontoAnt / .TipoCambio)

                     ElseIf .MonedaId = 2 Then
                        .MontoAnt = (.MontoAnt * .TipoCambio)

                     End If
                  End If

                  If .TipoAnticipoId = 1 Then
                     decMontoDev += .MontoAnt

                  ElseIf .TipoAnticipoId = 2 Then
                     AnticipoMontoAntFind += .MontoAnt

                  End If

                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function SaldoIniAntMontoFind(ByVal datFechaFin As Date) As Decimal
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      Try
         SaldoIniAntMontoFind = 0

         With oCredito
            .SelectFilter = clsCredito.SelectFilters.Flujocaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .SaldoIni = 1

            If mboolIntervaloFecha Then
               .FechaIni = ToDate(datFechaFin)
               .WhereFilter = clsCredito.WhereFilters.FlujoCajaSaldoIniAnt_Fecha
            End If

            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoLiq = (.MontoLiq / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoLiq = (.MontoLiq * .TipoCambio)

                     End If
                  End If

                  SaldoIniAntMontoFind += .MontoLiq


                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function SaldoIniMontoFind() As Decimal
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      Try
         SaldoIniMontoFind = 0

         With oCredito
            .SelectFilter = clsCredito.SelectFilters.Flujocaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .SaldoIni = 1

            If mboolIntervaloFecha Then
               .FechaIni = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)
               .WhereFilter = clsCredito.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsCredito.WhereFilters.FlujoCaja
            End If

            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoLiq = (.MontoLiq / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoLiq = (.MontoLiq * .TipoCambio)

                     End If
                  End If

                  SaldoIniMontoFind += .MontoLiq


                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function SaldoIniMontoCreditoFind() As Decimal
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)
      Dim lngProveedorId As Long
      Dim decMontoProv As Decimal
      Dim lngPosProv As Long

      Try
         SaldoIniMontoCreditoFind = 0
         decMontoProv = 0

         With oCredito
            .SelectFilter = clsCredito.SelectFilters.Flujocaja
            .OrderByFilter = clsCredito.OrderByFilters.ProveedorId

            If mboolIntervaloFecha Then
               .FechaIni = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)
               .WhereFilter = clsCredito.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsCredito.WhereFilters.FlujoCaja
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .SaldoIni = 1


            If .Open Then

               lngProveedorId = 0
               lngPosProv = moDataTable.Rows.Count

               While .Read

                  If lngProveedorId <> .ProveedorId Then
                     moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
                     lngProveedorId = .ProveedorId
                     decMontoProv = 0
                  End If

                  If .MonedaId <> mlngMonedaId Then

                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoLiq = (.MontoLiq / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoLiq = (.MontoLiq * .TipoCambio)

                     End If
                  End If

                  decMontoProv += .MontoLiq
                  SaldoIniMontoCreditoFind += .MontoLiq

                  .MoveNext()
               End While

               If lngProveedorId <> 0 Then   '' que si hay datos
                  moDataTable.Rows.RemoveAt(lngPosProv)
                  moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
               End If


            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function compraMontoContFind(ByRef decMontoCred As Decimal) As Decimal
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         compraMontoContFind = 0
         decMontoCred = 0

         With oCompra
            .SelectFilter = clsCompra.SelectFilters.FlujoCaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)
               .WhereFilter = clsCompra.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsCompra.WhereFilters.FlujoCaja
            End If

            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then
                     ''If .MonedaId = clsMoneda.BOLIVIANOS Then
                     ''   .MontoOrg = (.MontoOrg / .TipoCambio)

                     ''ElseIf .MonedaId = clsMoneda.DOLARES Then
                     ''   .MontoOrg = (.MontoOrg * .TipoCambio)

                     ''End If

                     '' Monto Compra menos descuentos + recargas
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoBru = (.MontoBru / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoBru = (.MontoBru * .TipoCambio)

                     End If
                  End If

                  ''If .TipoPagoId = clsTipoPago.CONTADO Then
                  ''   compraMontoContFind += .MontoOrg

                  ''ElseIf .TipoPagoId = clsTipoPago.CREDITO Then
                  ''   decMontoCred += .MontoOrg

                  ''End If

                  If .TipoPagoId = clsTipoPago.CONTADO Then
                     compraMontoContFind += .MontoBru

                  ElseIf .TipoPagoId = clsTipoPago.CREDITO Then
                     decMontoCred += .MontoBru

                  End If

                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function compraMontoContadoFind() As Decimal
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim lngProveedorId As Long
      Dim decMontoProv As Decimal
      Dim lngPosProv As Long

      Try
         compraMontoContadoFind = 0
         decMontoProv = 0

         With oCompra
            .SelectFilter = clsCompra.SelectFilters.FlujoCaja
            .OrderByFilter = clsCompra.OrderByFilters.ProveedorId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)
               .WhereFilter = clsCompra.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsCompra.WhereFilters.FlujoCaja
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .TipoPagoId = clsTipoPago.CONTADO


            If .Open Then

               lngProveedorId = 0
               lngPosProv = moDataTable.Rows.Count

               While .Read

                  If lngProveedorId <> .ProveedorId Then
                     moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
                     lngProveedorId = .ProveedorId
                     decMontoProv = 0
                  End If

                  If .MonedaId <> mlngMonedaId Then

                     ''If .MonedaId = clsMoneda.BOLIVIANOS Then
                     ''   .MontoOrg = (.MontoOrg / .TipoCambio)

                     ''ElseIf .MonedaId = clsMoneda.DOLARES Then
                     ''   .MontoOrg = (.MontoOrg * .TipoCambio)

                     ''End If

                     '' Monto Compra menos descuentos + recargas
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoBru = (.MontoBru / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoBru = (.MontoBru * .TipoCambio)

                     End If
                  End If

                  ''decMontoProv += .MontoOrg
                  ''compraMontoContadoFind += .MontoOrg

                  decMontoProv += .MontoBru
                  compraMontoContadoFind += .MontoBru

                  .MoveNext()
               End While

               If lngProveedorId <> 0 Then   '' que si hay datos
                  moDataTable.Rows.RemoveAt(lngPosProv)
                  moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
               End If


            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function compraMontoCreditoFind() As Decimal
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim lngProveedorId As Long
      Dim decMontoProv As Decimal
      Dim lngPosProv As Long

      Try
         compraMontoCreditoFind = 0
         decMontoProv = 0

         With oCompra
            .SelectFilter = clsCompra.SelectFilters.FlujoCaja
            .OrderByFilter = clsCompra.OrderByFilters.ProveedorId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)
               .WhereFilter = clsCompra.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsCompra.WhereFilters.FlujoCaja
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .TipoPagoId = clsTipoPago.CREDITO

            If .Open Then

               lngProveedorId = 0
               lngPosProv = moDataTable.Rows.Count

               While .Read

                  If lngProveedorId <> .ProveedorId Then
                     moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
                     lngProveedorId = .ProveedorId
                     decMontoProv = 0
                  End If

                  If .MonedaId <> mlngMonedaId Then

                     ''If .MonedaId = clsMoneda.BOLIVIANOS Then
                     ''   .MontoOrg = (.MontoOrg / .TipoCambio)

                     ''ElseIf .MonedaId = clsMoneda.DOLARES Then
                     ''   .MontoOrg = (.MontoOrg * .TipoCambio)

                     ''End If

                     '' Monto Compra menos descuentos + recargas
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoBru = (.MontoBru / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoBru = (.MontoBru * .TipoCambio)

                     End If
                  End If

                  ''decMontoProv += .MontoOrg
                  ''compraMontoCreditoFind += .MontoOrg

                  decMontoProv += .MontoBru
                  compraMontoCreditoFind += .MontoBru

                  .MoveNext()
               End While

               If lngProveedorId <> 0 Then   '' que si hay datos
                  moDataTable.Rows.RemoveAt(lngPosProv)
                  moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
               End If


            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function devCompraMontoContFind(ByRef decMontoCred As Decimal) As Decimal
      Dim oDevCompra As New clsDevCompra(clsAppInfo.ConnectString)

      Try
         devCompraMontoContFind = 0
         decMontoCred = 0

         With oDevCompra
            .SelectFilter = clsDevCompra.SelectFilters.FlujoCaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)
               .WhereFilter = clsDevCompra.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsDevCompra.WhereFilters.FlujoCaja
            End If

            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoOrg = (.MontoOrg / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoOrg = (.MontoOrg * .TipoCambio)

                     End If
                  End If

                  If .TipoPagoId = clsTipoPago.CONTADO Then
                     devCompraMontoContFind += .MontoOrg

                  ElseIf .TipoPagoId = clsTipoPago.CREDITO Then
                     decMontoCred += .MontoOrg

                  End If

                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDevCompra.Dispose()

      End Try
   End Function

   Private Function devCompraMontoContadoFind() As Decimal
      Dim oDevCompra As New clsDevCompra(clsAppInfo.ConnectString)
      Dim lngProveedorId As Long
      Dim decMontoProv As Decimal
      Dim lngPosProv As Long

      Try
         devCompraMontoContadoFind = 0
         decMontoProv = 0

         With oDevCompra
            .SelectFilter = clsDevCompra.SelectFilters.FlujoCaja
            .OrderByFilter = clsDevCompra.OrderByFilters.ProveedorId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)
               .WhereFilter = clsDevCompra.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsDevCompra.WhereFilters.FlujoCaja
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .TipoPagoId = clsTipoPago.CONTADO

            If .Open Then

               lngProveedorId = 0
               lngPosProv = moDataTable.Rows.Count

               While .Read

                  If lngProveedorId <> .ProveedorId Then
                     moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
                     lngProveedorId = .ProveedorId
                     decMontoProv = 0
                  End If

                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoOrg = (.MontoOrg / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoOrg = (.MontoOrg * .TipoCambio)

                     End If
                  End If

                  decMontoProv += .MontoOrg
                  devCompraMontoContadoFind += .MontoOrg

                  .MoveNext()
               End While

               If lngProveedorId <> 0 Then   '' que si hay datos
                  moDataTable.Rows.RemoveAt(lngPosProv)
                  moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
               End If

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDevCompra.Dispose()

      End Try
   End Function

   Private Function devCompraMontoCreditoFind() As Decimal
      Dim oDevCompra As New clsDevCompra(clsAppInfo.ConnectString)
      Dim lngProveedorId As Long
      Dim decMontoProv As Decimal
      Dim lngPosProv As Long

      Try
         devCompraMontoCreditoFind = 0
         decMontoProv = 0

         With oDevCompra
            .SelectFilter = clsDevCompra.SelectFilters.FlujoCaja
            .OrderByFilter = clsDevCompra.OrderByFilters.ProveedorId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)
               .WhereFilter = clsDevCompra.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsDevCompra.WhereFilters.FlujoCaja
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .TipoPagoId = clsTipoPago.CREDITO

            If .Open Then

               lngProveedorId = 0
               lngPosProv = moDataTable.Rows.Count

               While .Read

                  If lngProveedorId <> .ProveedorId Then
                     moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
                     lngProveedorId = .ProveedorId
                     decMontoProv = 0
                  End If

                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = clsMoneda.BOLIVIANOS Then
                        .MontoOrg = (.MontoOrg / .TipoCambio)

                     ElseIf .MonedaId = clsMoneda.DOLARES Then
                        .MontoOrg = (.MontoOrg * .TipoCambio)

                     End If
                  End If

                  decMontoProv += .MontoOrg
                  devCompraMontoCreditoFind += .MontoOrg

                  .MoveNext()
               End While

               If lngProveedorId <> 0 Then   '' que si hay datos
                  moDataTable.Rows.RemoveAt(lngPosProv)
                  moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
               End If

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDevCompra.Dispose()

      End Try
   End Function

   Private Function PagoMontoContFind(ByRef decMontoCred As Decimal) As Decimal
      Dim oPago As New clsPago(clsAppInfo.ConnectString)

      Try
         PagoMontoContFind = 0

         With oPago
            .SelectFilter = clsPago.SelectFilters.FlujoCaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)

               .WhereFilter = clsPago.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsPago.WhereFilters.FlujoCaja
            End If

            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = 1 Then
                        .Capital = (.Capital / .TipoCambio)

                     ElseIf .MonedaId = 2 Then
                        .Capital = (.Capital * .TipoCambio)

                     End If
                  End If

                  If .TipoPagoId = 1 Then
                     PagoMontoContFind += .Capital

                  ElseIf .TipoPagoId = 2 Then
                     decMontoCred += .Capital

                  End If

                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPago.Dispose()

      End Try
   End Function

   Private Function PagoMontoContadoFind() As Decimal
      Dim oPago As New clsPago(clsAppInfo.ConnectString)
      Dim lngProveedorId As Long
      Dim decMontoProv As Decimal
      Dim lngPosProv As Long

      Try
         PagoMontoContadoFind = 0
         decMontoProv = 0

         With oPago
            .SelectFilter = clsPago.SelectFilters.FlujoCaja
            .OrderByFilter = clsPago.OrderByFilters.ProveedorId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)

               .WhereFilter = clsPago.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsPago.WhereFilters.FlujoCaja
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .TipoPagoId = clsTipoPago.CONTADO

            If .Open Then

               lngProveedorId = 0
               lngPosProv = moDataTable.Rows.Count

               While .Read

                  If lngProveedorId <> .ProveedorId Then
                     moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
                     lngProveedorId = .ProveedorId
                     decMontoProv = 0
                  End If

                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = 1 Then
                        .Capital = (.Capital / .TipoCambio)

                     ElseIf .MonedaId = 2 Then
                        .Capital = (.Capital * .TipoCambio)

                     End If
                  End If

                  decMontoProv += .Capital
                  PagoMontoContadoFind += .Capital

                  .MoveNext()
               End While

               If lngProveedorId <> 0 Then   '' que si hay datos
                  moDataTable.Rows.RemoveAt(lngPosProv)
                  moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
               End If

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPago.Dispose()

      End Try
   End Function

   Private Function PagoMontoCreditoFind() As Decimal
      Dim oPago As New clsPago(clsAppInfo.ConnectString)
      Dim lngProveedorId As Long
      Dim decMontoProv As Decimal
      Dim lngPosProv As Long

      Try
         PagoMontoCreditoFind = 0
         decMontoProv = 0

         With oPago
            .SelectFilter = clsPago.SelectFilters.FlujoCaja
            .OrderByFilter = clsPago.OrderByFilters.ProveedorId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)

               .WhereFilter = clsPago.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsPago.WhereFilters.FlujoCaja
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .TipoPagoId = clsTipoPago.CREDITO

            If .Open Then

               lngProveedorId = 0
               lngPosProv = moDataTable.Rows.Count

               While .Read

                  If lngProveedorId <> .ProveedorId Then
                     moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
                     lngProveedorId = .ProveedorId
                     decMontoProv = 0
                  End If

                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = 1 Then
                        .Capital = (.Capital / .TipoCambio)

                     ElseIf .MonedaId = 2 Then
                        .Capital = (.Capital * .TipoCambio)

                     End If
                  End If

                  decMontoProv += .Capital
                  PagoMontoCreditoFind += .Capital

                  .MoveNext()
               End While

               If lngProveedorId <> 0 Then   '' que si hay datos
                  moDataTable.Rows.RemoveAt(lngPosProv)
                  moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
               End If

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPago.Dispose()

      End Try
   End Function

   Private Function AnticipoMontoFind(ByRef decMontoDev As Decimal) As Decimal
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

      Try
         AnticipoMontoFind = 0
         decMontoDev = 0

         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.FlujoCaja
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)

               .WhereFilter = clsAnticipo.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsAnticipo.WhereFilters.FlujoCaja
            End If

            If .Open Then

               While .Read
                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = 1 Then
                        .MontoAnt = (.MontoAnt / .TipoCambio)

                     ElseIf .MonedaId = 2 Then
                        .MontoAnt = (.MontoAnt * .TipoCambio)

                     End If
                  End If

                  If .TipoAnticipoId = 1 Then
                     decMontoDev += .MontoAnt

                  ElseIf .TipoAnticipoId = 2 Then
                     AnticipoMontoFind += .MontoAnt

                  End If

                  .MoveNext()
               End While

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function AnticipoMontoFind() As Decimal
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim lngProveedorId As Long
      Dim decMontoProv As Decimal
      Dim lngPosProv As Long

      Try
         AnticipoMontoFind = 0
         decMontoProv = 0

         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.FlujoCaja
            .OrderByFilter = clsAnticipo.OrderByFilters.ProveedorId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)

               .WhereFilter = clsAnticipo.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsAnticipo.WhereFilters.FlujoCaja
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .TipoAnticipoId = 2

            If .Open Then

               lngProveedorId = 0
               lngPosProv = moDataTable.Rows.Count

               While .Read

                  If lngProveedorId <> .ProveedorId Then
                     moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
                     lngProveedorId = .ProveedorId
                     decMontoProv = 0
                  End If

                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = 1 Then
                        .MontoAnt = (.MontoAnt / .TipoCambio)

                     ElseIf .MonedaId = 2 Then
                        .MontoAnt = (.MontoAnt * .TipoCambio)

                     End If
                  End If

                  decMontoProv += .MontoAnt
                  AnticipoMontoFind += .MontoAnt

                  .MoveNext()
               End While

               If lngProveedorId <> 0 Then   '' que si hay datos
                  moDataTable.Rows.RemoveAt(lngPosProv)
                  moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
               End If

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function DevAnticipoMontoFind() As Decimal
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim lngProveedorId As Long
      Dim decMontoProv As Decimal
      Dim lngPosProv As Long

      Try
         DevAnticipoMontoFind = 0
         decMontoProv = 0

         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.FlujoCaja
            .OrderByFilter = clsAnticipo.OrderByFilters.ProveedorId

            If mboolIntervaloFecha Then
               .Fecha = ToDate(mdatFechaIni)
               .LastUpdateDate = ToDate(mdatFechaFin)

               .WhereFilter = clsAnticipo.WhereFilters.FlujoCajaFecha
            Else
               .WhereFilter = clsAnticipo.WhereFilters.FlujoCaja
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .TipoAnticipoId = 1

            If .Open Then

               lngProveedorId = 0
               lngPosProv = moDataTable.Rows.Count

               While .Read

                  If lngProveedorId <> .ProveedorId Then
                     moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
                     lngProveedorId = .ProveedorId
                     decMontoProv = 0
                  End If

                  If .MonedaId <> mlngMonedaId Then
                     If .MonedaId = 1 Then
                        .MontoAnt = (.MontoAnt / .TipoCambio)

                     ElseIf .MonedaId = 2 Then
                        .MontoAnt = (.MontoAnt * .TipoCambio)

                     End If
                  End If

                  decMontoProv += .MontoAnt
                  DevAnticipoMontoFind += .MontoAnt

                  .MoveNext()
               End While

               If lngProveedorId <> 0 Then   '' que si hay datos
                  moDataTable.Rows.RemoveAt(lngPosProv)
                  moDataTable.Rows.Add(GetRowProveedor(lngProveedorId, decMontoProv))
               End If

            End If

         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function GestionFechaIni(ByVal GestionId As Long) As String
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = GestionId

            If .FindByPK Then
               GestionFechaIni = .FechaIni
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
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
      If Not mboolDetallado Then
         Dim rpt As New rptFlujoCaja
         rpt.DataSource = GetDataView(moDataTable.DataSet.Tables("FlujoCaja"))

         rpt.lblTitle.Text = "Flujo de Caja de Compras"
         rpt.Document.Name = "Flujo de Caja de Compras"
         rpt.lblCompany.Text = clsAppInfo.EmpresaGral
         rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
         rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
         rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

         rpt.txtFechaIni.Text = ConvertDMY(mdatFechaIni)
         rpt.txtFechaFin.Text = ConvertDMY(mdatFechaFin)
         rpt.txtMonedaDes.Text = MonedaDesFind(mlngMonedaId)

         rpt.lblProveedor.Text = "(Todos)"
         If (mlngProveedorId > 0) Then
            rpt.lblProveedor.Text = ProveedorDesFind(mlngProveedorId)
         End If

         Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

         rpt.Run(True)
         Dim frm As frmReportPreview
         frm = New frmReportPreview(rpt.Document)
         frm.Show()

      Else

         Dim rpt As New rptFlujoCajaDetallado
         rpt.DataSource = GetDataView(moDataTable.DataSet.Tables("FlujoCaja"))

         rpt.lblTitle.Text = "Flujo de Caja de Compras"
         rpt.Document.Name = "Flujo de Caja de Compras"
         rpt.lblCompany.Text = clsAppInfo.EmpresaGral
         rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
         rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
         rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

         rpt.txtFechaIni.Text = ConvertDMY(mdatFechaIni)
         rpt.txtFechaFin.Text = ConvertDMY(mdatFechaFin)
         rpt.txtMonedaDes.Text = MonedaDesFind(mlngMonedaId)

         rpt.txtFechaIni2.Text = ConvertDMY(mdatFechaIni)
         rpt.txtFechaFin2.Text = ConvertDMY(mdatFechaFin)
         rpt.txtMonedaDes2.Text = MonedaDesFind(mlngMonedaId)

         ''rpt.lblProveedor.Text = "(Todos)"
         ''If (mlngProveedorId > 0) Then
         ''   rpt.lblProveedor.Text = ProveedorDesFind(mlngProveedorId)
         ''End If
         Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

         rpt.Run(True)
         Dim frm As frmReportPreview
         frm = New frmReportPreview(rpt.Document)
         frm.Show()
      End If

   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompraId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moCompra = New clsCompra(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Flujo de Caja de Compras"

         .RootTable.Columns("Tipo").Visible = False

         .RootTable.Columns("DocumentoDes").Caption = "Descripción"
         .RootTable.Columns("DocumentoDes").Width = 250
         .RootTable.Columns("DocumentoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("DocumentoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Op").Caption = ""
         .RootTable.Columns("Op").Width = 30
         .RootTable.Columns("Op").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Op").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Monto").Caption = "Monto"
         .RootTable.Columns("Monto").Width = 100
         .RootTable.Columns("Monto").FormatString = DecimalMask()
         .RootTable.Columns("Monto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Monto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Tipo"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Tipo"), Janus.Windows.GridEX.ConditionOperator.Equal, -2)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Tipo"), Janus.Windows.GridEX.ConditionOperator.Equal, 0)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmFlujoCaja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
         Me.Close()
      End If
   End Sub

   Private Sub frmFlujoCaja_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompra.Dispose()
      Call ClearMemory()
   End Sub

End Class
