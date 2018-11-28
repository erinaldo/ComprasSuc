Public Class frmCreditoMovCre
   Inherits System.Windows.Forms.Form

   Private moCreditoDet As clsCreditoDet
   Private mlngCreditoId As Long

   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long
   Private mstrMonedaDes As String
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolOrdenarFecha As Boolean
   Private mdatFechaFinRep As Date

   Private mboolDetallado As Boolean
   Private mboolResumido As Boolean

   Private mdecMora As Decimal
   Private mdecInteres As Decimal

   Private mdecCapital As Decimal
   Private mdecCapitalAmo As Decimal
   Private mdecCapitalDif As Decimal

   Private mdecMoraCli As Decimal
   Private mdecInteresCli As Decimal
   Private mdecCapitalCli As Decimal
   Private mdecCapitalAmoCli As Decimal
   Private mdecCapitalDifCli As Decimal

   Private mdecMoraTotal As Decimal
   Private mdecInteresTotal As Decimal
   Private mdecCapitalTotal As Decimal
   Private mdecCapitalAmoTotal As Decimal
   Private mdecCapitalDifTotal As Decimal

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mboolShow As Boolean
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

   Property MonedaDes() As String
      Get
         Return mstrMonedaDes
      End Get

      Set(ByVal Value As String)
         mstrMonedaDes = Value
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

   WriteOnly Property Resumido() As Boolean
      Set(ByVal Value As Boolean)
         mboolResumido = Value
      End Set
   End Property

   WriteOnly Property FechaFinRep() As Date
      Set(ByVal Value As Date)
         mdatFechaFinRep = Value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditoMovCre))
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
      'frmCreditoMovCre
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmCreditoMovCre"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Estado de Créditos"
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
            Call frmCreditoEditLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCreditoMovCre_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCreditoMovCre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      Dim lngPosCred, lngPosProv As Long

      Try
         Call moDataSetInit()

         mdecMoraTotal = 0
         mdecInteresTotal = 0
         mdecCapitalTotal = 0
         mdecCapitalAmoTotal = 0
         mlngCreditoId = 0

         For Each lngProveedorId As Long In moLista
            If TieneMovimiento(lngProveedorId) Then
               With moCreditoDet
                  mdecMoraCli = 0
                  mdecInteresCli = 0
                  mdecCapitalCli = 0
                  mdecCapitalAmoCli = 0

                  lngPosProv = moDataTable.Rows.Count
                  moDataTable.Rows.Add(GetProveedor(lngProveedorId))

                  For Each oRow In .DataSet.Tables(.TableName).Rows
                     If mboolDetallado Then 'Para el Detallado
                        lngPosCred = moDataTable.Rows.Count
                        moDataTable.Rows.Add(GetCredito(oRow("CreditoId")))
                     End If

                     With oCreditoDet
                        .SelectFilter = clsCreditoDet.SelectFilters.All
                        .OrderByFilter = clsCreditoDet.OrderByFilters.CreditoDetId

                        If mboolIntervaloFecha Then
                           .WhereFilter = clsCreditoDet.WhereFilters.CuotaVencidaFecha
                           '.Fecha = mstrFechaIni
                           .FechaAmo = mstrFechaFin

                        Else
                           .WhereFilter = clsCreditoDet.WhereFilters.CuotaVencida
                        End If

                        .EmpresaId = mlngEmpresaId
                        .GestionId = mlngGestionId
                        .CreditoId = oRow("CreditoId")
                        .EstadoId = 15
                        .CreditoDetId = 14

                        If .Open Then
                           mdecMora = 0
                           mdecInteres = 0
                           mdecCapitalAmo = 0

                           While .Read

                              If mboolDetallado Then 'Para el Detallado
                                 moDataTable.Rows.Add(GetCreditoDet(oCreditoDet))
                              Else
                                 Call CreditoDetSuma(oCreditoDet)
                              End If

                              .MoveNext()
                           End While

                        End If
                     End With

                     If mboolDetallado Then 'Para el Detallado
                        Call GetCreditoFooter(lngPosCred)
                        moDataTable.Rows.Add(GetRowNull)
                     Else
                        lngPosCred = moDataTable.Rows.Count
                        moDataTable.Rows.Add(GetCredito(oRow("CreditoId")))
                        Call GetCreditoFooter(lngPosCred)

                        If mboolResumido Then
                           moDataTable.Rows.RemoveAt(moDataTable.Rows.Count - 1)
                        End If


                     End If
                  Next

                  If mboolDetallado Then 'Para el Detallado
                     moDataTable.Rows.RemoveAt(moDataTable.Rows.Count - 1)
                  End If

                  Call GetProveedorFooter(lngPosProv)
                  moDataTable.Rows.Add(GetRowNull)

                  If mboolResumido Then
                     moDataTable.Rows.RemoveAt(moDataTable.Rows.Count - 1)
                  End If

               End With
            End If
         Next

         moDataTable.Rows.Add(GetFooter())

         grdMain.DataSource = moDataSet.Tables(moCreditoDet.TableName).DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()

         moCreditoDet.CloseConection()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCreditoDet.TableName)

      moDataTable.Columns.Add("CreditoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CreditoEsp", Type.GetType("System.String"))
      moDataTable.Columns.Add("CreditoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompraOrden", Type.GetType("System.String"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.String"))
      moDataTable.Columns.Add("Mora", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Interes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Capital", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("CapitalAmo", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("CapitalDif", Type.GetType("System.Decimal"))
   End Sub

   Private Function GetProveedor(ByVal lngProveedorId As Long) As DataRow
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               oRow("CreditoId") = -1
               oRow("CreditoEsp") = "Prov. -  " & .ProveedorCod
               oRow("CreditoDes") = .ProveedorDes
            End If
         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function GetCredito(ByVal lngCreditoId As Long) As DataRow
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               oRow("CreditoId") = .CreditoId
               oRow("CreditoDes") = .FechaIni
               oRow("Fecha") = .FechaFin
               oRow("CompraOrden") = CompraOrdenFind(.CompraId)

               If ToBoolean(.SaldoIni) Then
                  oRow("CreditoEsp") = "    Saldo Inicial " & ToStr(.CreditoNro)
               Else
                  oRow("CreditoEsp") = "    Credito " & ToStr(.CreditoNro)
               End If

               If Not mboolDetallado Then 'Resumido
                  oRow("Mora") = mdecMora
                  oRow("Interes") = mdecInteres
               End If

               If .MonedaId = mlngMonedaId Then
                  oRow("Capital") = .MontoLiq

               ElseIf mlngMonedaId = 1 Then
                  oRow("Capital") = .MontoLiq * .TipoCambio

               ElseIf mlngMonedaId = 2 Then
                  oRow("Capital") = .MontoLiq / ToDivByCero(.TipoCambio)

               End If

               mdecCapital = oRow("Capital")
               mdecCapitalCli += oRow("Capital")
               mdecCapitalTotal += oRow("Capital")

            End If
         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function GetCreditoDet(ByVal oCreditoDet As clsCreditoDet) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Dim lngNroDias As Long

      With oCreditoDet

         oRow("CreditoId") = 0
         oRow("CreditoEsp") = "        Cuota " & .CuotaNro
         ''oRow("CreditoDes") = .CompraOrden
         oRow("Fecha") = .Fecha

         If mboolIntervaloFecha Then
            lngNroDias = DateDiff(DateInterval.Day, ToDate2(.Fecha), mdatFechaFinRep)

            If lngNroDias > 0 Then
               oRow("Mora") = lngNroDias
            Else
               oRow("Mora") = 0
            End If

            oRow("Interes") = InteresNuevo(.CreditoId, .CreditoDetId, .TipoCreditoId, ToDate2(.FechaAmo), _
                                           mdatFechaFinRep, CreditoInteresAnual(.CreditoId), .Interes, _
                                           .InteresAmo, .InteresPen)
         Else
            oRow("Mora") = 0
            oRow("Interes") = 0
         End If
         '.EstadoId = .EstadoId
         '.CapitalAmo = CreditoDetPago(.CreditoId, .CreditoDetId)


         If .MonedaId = mlngMonedaId Then
            oRow("Capital") = .Capital
            oRow("CapitalAmo") = .CapitalAmo
            oRow("CapitalDif") = ToDecimal(.Capital - .CapitalAmo)

         ElseIf mlngMonedaId = 1 Then
            oRow("Capital") = ToDecimal(.Capital * .TipoCambio)
            oRow("CapitalAmo") = ToDecimal(.CapitalAmo * .TipoCambio)
            oRow("CapitalDif") = ToDecimal((.Capital - .CapitalAmo) * .TipoCambio)

         ElseIf mlngMonedaId = 2 Then
            oRow("Capital") = ToDecimal(.Capital / ToDivByCero(.TipoCambio))
            oRow("CapitalAmo") = ToDecimal(.CapitalAmo / ToDivByCero(.TipoCambio))
            oRow("CapitalDif") = ToDecimal((.Capital - .CapitalAmo) / ToDivByCero(.TipoCambio))
         End If

         mdecMora += oRow("Mora")
         mdecInteres += oRow("Interes")
         mdecCapitalAmo += oRow("CapitalAmo")

         mdecMoraCli += oRow("Mora")
         mdecInteresCli += oRow("Interes")
         mdecCapitalAmoCli += oRow("CapitalAmo")

         mdecMoraTotal += oRow("Mora")
         mdecInteresTotal += oRow("Interes")
         mdecCapitalAmoTotal += oRow("CapitalAmo")

      End With

      Return oRow
   End Function

   Private Sub CreditoDetSuma(ByVal oCreditoDet As clsCreditoDet)
      Dim lngMora As Long
      Dim decInteres As Decimal

      With oCreditoDet

         If mboolIntervaloFecha Then
            lngMora = DateDiff(DateInterval.Day, ToDate2(.Fecha), mdatFechaFinRep)

            If lngMora < 0 Then
               lngMora = 0
            End If

            decInteres = InteresNuevo(.CreditoId, .CreditoDetId, .TipoCreditoId, ToDate2(.FechaAmo), _
                                           mdatFechaFinRep, CreditoInteresAnual(.CreditoId), .Interes, _
                                           .InteresAmo, .InteresPen)
         Else
            lngMora = 0
            decInteres = 0
         End If

         '.CapitalAmo = CreditoDetPago(.CreditoId, .CreditoDetId)

         If .MonedaId <> mlngMonedaId Then
            If mlngMonedaId = 1 Then
               .CapitalAmo = ToDecimal(.CapitalAmo * .TipoCambio)

            ElseIf mlngMonedaId = 2 Then
               .CapitalAmo = ToDecimal(.CapitalAmo / ToDivByCero(.TipoCambio))

            End If
         End If

         mdecMora += lngMora
         mdecInteres += decInteres
         mdecCapitalAmo += .CapitalAmo

         mdecMoraCli += lngMora
         mdecInteresCli += decInteres
         mdecCapitalAmoCli += .CapitalAmo

         mdecMoraTotal += lngMora
         mdecInteresTotal += decInteres
         mdecCapitalAmoTotal += .CapitalAmo

      End With

   End Sub

   Private Function InteresNuevo(ByVal lngCreditoId As Long, ByVal lngCreditoDetId As Long, ByVal lngTipoCreditoId As Long, _
                                 ByVal datFechaAmo As Date, ByVal datFechaFin As Date, _
                                 ByVal decInteresAnual As Decimal, ByVal decInteres As Decimal, _
                                 ByVal decInteresAmo As Decimal, ByVal decInteresPen As Decimal) As Decimal
      Dim lngNroDias As Long
      Dim decInteresDia As Decimal = (ToDecimal(decInteresAnual) / 100) / 360
      Dim decInteresNuevo As Decimal = 0

      Dim datFechaPenal As Date
      Dim decInteresPenal As Decimal = 0
      Dim decInteresDiaPenal As Decimal = 0
      Dim decInteresNuevoPenal As Decimal = 0

      If lngTipoCreditoId = 5 Then 'Personalizado
         If decInteres > decInteresAmo Then
            Return decInteres - decInteresAmo
         Else
            Return 0
         End If
      End If

      If lngTipoCreditoId = 4 Then 'Interes Sobre Saldo
         If mlngCreditoId <> lngCreditoId Then
            lngNroDias = DateDiff(DateInterval.Day, datFechaAmo, datFechaFin)

            If lngNroDias > 0 Then
               decInteresNuevo = ToDecimal(((decInteresDia * CreditoDetMontoLiq(lngCreditoId)) * lngNroDias) + decInteresPen)
            Else
               decInteresNuevo = decInteresPen
            End If

            ''decInteresPenal = CreditoInteresPenal(lngCreditoId, datFechaPenal)
            decInteresPenal = 0

            decInteresDiaPenal = (ToDecimal(decInteresPenal) / 100) / 360

            If DateDiff(DateInterval.Day, datFechaPenal, datFechaFin) > 0 Then
               decInteresNuevoPenal = ToDecimal((decInteresDiaPenal * CreditoDetMontoLiq(lngCreditoId)) * lngNroDias)
            Else
               decInteresNuevoPenal = 0
            End If
         Else
            decInteresNuevo = decInteresPen
         End If
      End If

      If lngTipoCreditoId = 2 Then 'Cuotas de Capital
         If mlngCreditoId <> lngCreditoId Then
            lngNroDias = DateDiff(DateInterval.Day, datFechaAmo, datFechaFin)

            If lngNroDias > 0 Then
               decInteresNuevo = ToDecimal(((decInteresDia * CreditoDetMontoLiq(lngCreditoId)) * lngNroDias) + decInteresPen)
            Else
               decInteresNuevo = decInteresPen
            End If

            ''decInteresPenal = CreditoInteresPenal(lngCreditoId, datFechaPenal)
            decInteresPenal = 0

            decInteresDiaPenal = (ToDecimal(decInteresPenal) / 100) / 360

            If DateDiff(DateInterval.Day, datFechaPenal, datFechaFin) > 0 Then
               decInteresNuevoPenal = ToDecimal((decInteresDiaPenal * CreditoDetMontoLiq(lngCreditoId)) * lngNroDias)
            Else
               decInteresNuevoPenal = 0
            End If
         Else
            decInteresNuevo = decInteresPen
         End If
      End If

      If lngTipoCreditoId = 3 Then 'Cuota Fija
         If mlngCreditoId <> lngCreditoId Then
            lngNroDias = DateDiff(DateInterval.Day, datFechaAmo, datFechaFin)

            If lngNroDias > 0 Then
               decInteresNuevo = ToDecimal(((decInteresDia * CreditoDetMontoLiq(lngCreditoId)) * lngNroDias) + decInteresPen)
            Else
               decInteresNuevo = decInteresPen
            End If

            ''decInteresPenal = CreditoInteresPenal(lngCreditoId, datFechaPenal)

            decInteresDiaPenal = (ToDecimal(decInteresPenal) / 100) / 360

            If DateDiff(DateInterval.Day, datFechaPenal, datFechaFin) > 0 Then
               decInteresNuevoPenal = ToDecimal((decInteresDiaPenal * CreditoDetMontoLiq(lngCreditoId)) * lngNroDias)
            Else
               decInteresNuevoPenal = 0
            End If
         Else
            decInteresNuevo = decInteresPen
         End If
      End If

      mlngCreditoId = lngCreditoId

      Return decInteresNuevo + decInteresNuevoPenal
   End Function

   Private Function CreditoDetMontoLiq(ByVal lngCreditoId As Long) As Decimal
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)
      Dim decCapital As Decimal = 0
      Dim decCapitalAmo As Decimal = 0

      Try
         With oCreditoDet
            .SelectFilter = clsCreditoDet.SelectFilters.All
            .WhereFilter = clsCreditoDet.WhereFilters.CreditoIdSinPago
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .CreditoId = lngCreditoId
            .EstadoId = 15 'Programado

            If .Open() Then
               Do While .Read()
                  decCapital += .Capital
                  decCapitalAmo += .CapitalAmo

                  .MoveNext()
               Loop
            End If
         End With

         Return decCapital - decCapitalAmo

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCreditoDet.Dispose()

      End Try
   End Function

   Private Function CreditoDetPago(ByVal lngCreditoId As Long, ByVal lngCreditoDetId As Long) As Decimal
      Dim oPagoDet As New clsPagoDet(clsAppInfo.ConnectString)

      Try
         With oPagoDet
            .SelectFilter = clsPagoDet.SelectFilters.All

            If mboolIntervaloFecha Then
               .WhereFilter = clsPagoDet.WhereFilters.CreditoDetIdFecha
               .Fecha = mstrFechaIni
               .LastUpdateDate = mstrFechaFin

            Else
               .WhereFilter = clsPagoDet.WhereFilters.CreditoDetId
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .CreditoId = lngCreditoId
            .CreditoDetId = lngCreditoDetId
            .EstadoId = 12 'Anulado

            CreditoDetPago = 0
            If .Open() Then
               Do While .Read()
                  CreditoDetPago += .CapitalAmo

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPagoDet.Dispose()

      End Try
   End Function

   Private Function CreditoInteresPenal(ByVal lngCreditoId As Long, ByRef datFechaPenal As Date) As Decimal
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               datFechaPenal = .DataSet.Tables(.TableName).Rows(0).Item("FechaPenal")
               ''Return .InteresPenal
               Return 0
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function CreditoInteresAnual(ByVal lngCreditoId As Long) As Decimal
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               Return .InteresAnual
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Sub GetCreditoFooter(ByVal lngPosId As Long)
      Dim oRow As DataRow
      oRow = moDataTable.Rows(lngPosId)

      oRow("Mora") = mdecMora
      oRow("Interes") = mdecInteres
      oRow("Capital") = mdecCapital
      oRow("CapitalAmo") = mdecCapitalAmo
      oRow("CapitalDif") = ToDecimal(mdecCapital - mdecCapitalAmo)

   End Sub

   Private Sub GetProveedorFooter(ByVal lngPosId As Long)
      Dim oRow As DataRow
      oRow = moDataTable.Rows(lngPosId)

      oRow("Mora") = mdecMoraCli
      oRow("Interes") = mdecInteresCli
      oRow("Capital") = mdecCapitalCli
      oRow("CapitalAmo") = mdecCapitalAmoCli
      oRow("CapitalDif") = ToDecimal(mdecCapitalCli - mdecCapitalAmoCli)

   End Sub

   Private Function GetFooter() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CreditoId") = -2
      oRow("CreditoEsp") = "Totales General"
      oRow("Mora") = mdecMoraTotal
      oRow("Interes") = mdecInteresTotal
      oRow("Capital") = mdecCapitalTotal
      oRow("CapitalAmo") = mdecCapitalAmoTotal
      oRow("CapitalDif") = ToDecimal(mdecCapitalTotal - mdecCapitalAmoTotal)

      Return oRow
   End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
   End Function

   Private Function CompraOrdenFind(ByVal lngCompraId As Long) As String
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      CompraOrdenFind = ""

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               Return .CompraOrden
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
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

   Private Function TieneMovimiento(ByVal lngProveedorId As Long) As Boolean

      TieneMovimiento = False

      Try
         With moCreditoDet
            '.SelectFilter = clsCreditoDet.SelectFilters.CreditoIdDistinct
            .SelectFilter = clsCreditoDet.SelectFilters.CREDITOID

            If mboolIntervaloFecha Then
               .WhereFilter = clsCreditoDet.WhereFilters.CREDITO_DETALLE_FECHA
               '.Fecha = mstrFechaIni
               .FechaAmo = mstrFechaFin

            Else
               .WhereFilter = clsCreditoDet.WhereFilters.CREDITO_DETALLE
            End If

            If (mboolOrdenarFecha) Then
               .OrderByFilter = clsCreditoDet.OrderByFilters.CREDITO_FECHA
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .ProveedorId = lngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            ''.VendedorId = mlngVendedorId
            ''.CompraId = mlngZonaId
            .EstadoId = 15
            .CreditoDetId = 14

            If .Find Then
               TieneMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Sub DataShow()
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("CreditoId")) > 0) Then
            With oCredito
               .CreditoId = ToLong(grdMain.GetValue("CreditoId"))

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
            MessageBox.Show("Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Sub

   Private Sub frmCreditoEditLoad()
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      Try
         If ToLong(grdMain.GetValue("CreditoId")) > 0 Then
            With oCredito
               .CreditoId = ToLong(grdMain.GetValue("CreditoId"))

               If .FindByPK Then
                  If ToBoolean(.SaldoIni) Then
                     Dim frm As New frmCreditoIniEdit

                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oCredito
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdMainLoad()
                        Call grdMainFindRow(frm.ID)
                        mboolChanged = True

                     End If
                     frm.Dispose()

                  Else
                     Dim frm As New frmCreditoEdit

                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oCredito
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdMainLoad()
                        Call grdMainFindRow(frm.ID)
                        mboolChanged = True

                     End If
                     frm.Dispose()
                  End If
               End If
            End With
         Else
            MessageBox.Show("Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

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
      ''Dim rpt As New rptCreditoMov
      If mboolResumido Then
         rpt = New rptCreditoMovResu
      Else
         rpt = New rptCreditoMov
      End If

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCreditoDet.TableName))

      rpt.lblTitle.Text = "Estado de Créditos"
      rpt.Document.Name = "Estado de Créditos"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)
      rpt.txtMonedaDes.Text = mstrMonedaDes
      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As frmReportPreview
      frm = New frmReportPreview(rpt.Document)
      frm.Show()
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CreditoId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moCreditoDet = New clsCreditoDet(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Estado de Créditos"

         .RootTable.Columns("CreditoId").Visible = False

         .RootTable.Columns("CreditoEsp").Caption = "Especificación"
         .RootTable.Columns("CreditoEsp").Width = 100
         .RootTable.Columns("CreditoEsp").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CreditoEsp").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CreditoDes").Caption = "Descripción"
         .RootTable.Columns("CreditoDes").Width = 150
         .RootTable.Columns("CreditoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CreditoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraOrden").Caption = "Nro. Orden"
         .RootTable.Columns("CompraOrden").Width = 80
         .RootTable.Columns("CompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center


         .RootTable.Columns("Fecha").Caption = "Vencimiento"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Mora").Caption = "Días Mora"
         .RootTable.Columns("Mora").Width = 80
         .RootTable.Columns("Mora").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Mora").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Interes").Caption = "Interés"
         .RootTable.Columns("Interes").FormatString = DecimalMask()
         .RootTable.Columns("Interes").Width = 80
         .RootTable.Columns("Interes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Interes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Interes").Visible = False

         .RootTable.Columns("Capital").Caption = "Capital"
         .RootTable.Columns("Capital").FormatString = DecimalMask()
         .RootTable.Columns("Capital").Width = 100
         .RootTable.Columns("Capital").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Capital").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CapitalAmo").Caption = "Capital Amort."
         .RootTable.Columns("CapitalAmo").FormatString = DecimalMask()
         .RootTable.Columns("CapitalAmo").Width = 100
         .RootTable.Columns("CapitalAmo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("CapitalAmo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CapitalDif").Caption = "Saldo"
         .RootTable.Columns("CapitalDif").FormatString = DecimalMask()
         .RootTable.Columns("CapitalDif").Width = 100
         .RootTable.Columns("CapitalDif").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("CapitalDif").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mboolResumido Then
            .RootTable.Columns("Fecha").Visible = False
            .RootTable.Columns("CompraOrden").Visible = False
         End If
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CreditoId"), Janus.Windows.GridEX.ConditionOperator.NotEqual, 0)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CreditoId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CreditoId"), Janus.Windows.GridEX.ConditionOperator.Equal, -2)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      If mboolShow Then
         'Call DataShow()
      End If
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmCreditoMovCre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            'Call DocumentoEditLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCreditoMovCre_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCreditoDet.Dispose()
      Call ClearMemory()
   End Sub

End Class
