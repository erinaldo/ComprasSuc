Public Class frmCompraMovResu
   Inherits System.Windows.Forms.Form

   Private moItem As clsItem
   Private moLista As New Queue
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

   Private mboolDiario As Boolean
   Private mboolResumido As Boolean

   Private mstrFecha As String
   Private mdecTotalCan As Decimal
   Private mdecTotalOrg As Decimal
   Private mdecTotalCos As Decimal

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

   Property Diario() As Boolean
      Get
         Return mboolDiario
      End Get

      Set(ByVal Value As Boolean)
         mboolDiario = Value
      End Set
   End Property

   Property Resumido() As Boolean
      Get
         Return mboolResumido
      End Get

      Set(ByVal Value As Boolean)
         mboolResumido = Value
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

#Region " C�digo generado por el Dise�ador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Dise�ador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

   'Requerido por el Dise�ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Dise�ador de Windows Forms. 
   'No lo modifique con el editor de c�digo.
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraMovResu))
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(314, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Kardex"
      Me.Book1.ToolTipText = "Kardex de Item"
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
      'frmCompraMovResu
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmCompraMovResu"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Movimiento de Compras por Items Resumido"
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
            Call frmCompraMovLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompraMovResu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompraMovResu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      Dim lngAlmacenId As Long
      Dim decSumTotalCan As Decimal
      Dim decSumTotalOrg As Decimal
      Dim decSumTotalCos As Decimal

      Try
         Call moDataSetInit()

         If mboolResumido Then
            With moItem
               mdecTotalCan = 0
               mdecTotalOrg = 0
               mdecTotalCos = 0

               For Each lngItemId As Long In moLista
                  If TieneMovimiento(lngItemId) Then
                     .ItemId = lngItemId

                     If .FindByPK Then
                        moDataTable.Rows.Add(GetRow(mlngAlmacenId))
                     End If
                  End If
               Next

               moDataTable.Rows.Add(GetRowFooter("Totales " & MonedaDesFind(mlngMonedaId), mdecTotalCan, _
                                                   mdecTotalOrg, mdecTotalCos))

               grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()

               .CloseConection()
            End With

         ElseIf mboolDiario Then
            With moItem
               For Each lngItemId As Long In moLista
                  .ItemId = lngItemId

                  If .FindByPK Then
                     Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

                     mdecTotalCan = 0
                     mdecTotalOrg = 0
                     mdecTotalCos = 0

                     With oCompraDet
                        .SelectFilter = clsCompraDet.SelectFilters.FechaDistinta
                        .EmpresaId = mlngEmpresaId
                        .GestionId = mlngGestionId
                        .AlmacenId = mlngAlmacenId
                        .ProveedorId = mlngProveedorId
                        .CentroCostoIdAct = mlngCentroCostoId
                        .SucursalIdAct = mlngSucursalId
                        .ItemId = lngItemId

                        If mboolIntervaloFecha Then
                           .WhereFilter = clsCompraDet.WhereFilters.SaldoFecha
                           .Fecha = mstrFechaIni
                           .LastUpdateDate = mstrFechaFin
                        Else
                           .WhereFilter = clsCompraDet.WhereFilters.SaldoActual
                        End If

                        .OrderByFilter = clsCompraDet.OrderByFilters.Fecha

                        If .Open Then
                           If .DataSet.Tables(.TableName).Rows.Count > 0 Then
                              moDataTable.Rows.Add(GetRowHeader)

                              For Each oRow In .DataSet.Tables(.TableName).Rows
                                 mstrFecha = ToDate(oRow("Fecha"))
                                 moDataTable.Rows.Add(GetRow(mlngAlmacenId))
                              Next

                              decSumTotalCan += mdecTotalCan
                              decSumTotalOrg += mdecTotalOrg
                              decSumTotalCos += mdecTotalCos

                              moDataTable.Rows.Add(GetRowFooter("Totales " & MonedaDesFind(mlngMonedaId), mdecTotalCan, _
                                                    mdecTotalOrg, mdecTotalCos))
                              moDataTable.Rows.Add(GetRowNull)
                           End If
                        End If
                     End With
                  End If
               Next

               If moDataTable.Rows.Count > 0 Then
                  moDataTable.Rows.Add(GetRowFooter("Total " & MonedaDesFind(mlngMonedaId), decSumTotalCan, _
                                                       decSumTotalOrg, decSumTotalCos))
                  moDataTable.Rows.Add(GetRowNull)
               End If

               grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()

               .CloseConection()
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moItem.TableName)

      moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("ImporteOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("ImporteCos", Type.GetType("System.Decimal"))
   End Sub

   Private Function GetRow(ByVal lngAlmacenId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Dim decImporteOrg As Decimal
      Dim decImporteCos As Decimal

      If mlngMedidaId = 1 Then
         oRow("MedidaDes") = MedidaDesFind(moItem.MedidaId)
      ElseIf mlngMedidaId = 2 Then
         oRow("MedidaDes") = MedidaDesFind(moItem.MedidaIdEqui)
      End If

      If mboolResumido Then
         oRow("ItemId") = moItem.ItemId
         oRow("ItemCod") = moItem.ItemCod
         oRow("ItemDes") = moItem.ItemDes

         oRow("Cantidad") = ItemCantidad(moItem.ItemId, lngAlmacenId, decImporteOrg, decImporteCos)

      ElseIf mboolDiario Then
         oRow("ItemId") = moItem.ItemId
         oRow("ItemCod") = System.Convert.DBNull
         oRow("ItemDes") = ConvertDMY(mstrFecha)

         oRow("Cantidad") = ItemCantidadFecha(moItem.ItemId, lngAlmacenId, decImporteOrg, decImporteCos)
      End If

      oRow("ImporteOrg") = decImporteOrg
      oRow("ImporteCos") = decImporteCos

      mdecTotalCan += oRow("Cantidad")
      mdecTotalOrg += decImporteOrg
      mdecTotalCos += decImporteCos

      Return oRow
   End Function

   Private Function GetRowHeader() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("ItemId") = moItem.ItemId
      oRow("ItemCod") = moItem.ItemCod
      oRow("ItemDes") = moItem.ItemDes
      oRow("MedidaDes") = System.Convert.DBNull
      oRow("Cantidad") = System.Convert.DBNull
      oRow("ImporteOrg") = System.Convert.DBNull
      oRow("ImporteCos") = System.Convert.DBNull

      Return oRow
   End Function

   Private Function GetRowFooter(ByVal strDes As String, ByVal decCantidad As Decimal, ByVal decImporteOrg As Decimal, _
                           ByVal decImporteCos As Decimal) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      oRow("ItemId") = System.Convert.DBNull
      oRow("ItemCod") = System.Convert.DBNull
      oRow("MedidaDes") = System.Convert.DBNull
      oRow("ItemDes") = strDes
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

   Private Function ItemCantidad(ByVal lngItemId As Long, ByVal lngAlmacenId As Long, ByRef decImporteOrg As Decimal, ByRef decImporteCos As Decimal) As Decimal
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
      Dim decCantidad As Decimal = 0
      Dim decImpOrg As Decimal
      Dim decImpCos As Decimal

      ItemCantidad = 0
      decImporteOrg = 0
      decImporteCos = 0

      Try
         With oCompraDet
            .SelectFilter = clsCompraDet.SelectFilters.All
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .AlmacenId = mlngAlmacenId
            .ProveedorId = mlngProveedorId
            .CentroCostoIdAct = mlngCentroCostoId
            .SucursalIdAct = mlngSucursalId
            .ItemId = lngItemId

            If mboolIntervaloFecha Then
               .WhereFilter = clsCompraDet.WhereFilters.SaldoFecha
               .Fecha = mstrFechaIni
               .LastUpdateDate = mstrFechaFin
            Else
               .WhereFilter = clsCompraDet.WhereFilters.SaldoActual
            End If

            If .Open() Then
               Do While .Read()

                  If mlngMedidaId = 1 Then 'Medida Minima del Reporte
                     If .MedidaId = moItem.MedidaId Then
                        decCantidad += .Cantidad
                        decImpOrg = .Cantidad * .PrecioOrg
                        decImpCos = .Cantidad * .PrecioCos

                     ElseIf .MedidaId = moItem.MedidaIdEqui Then
                        decCantidad += (.Cantidad * moItem.MedidaCantEqui)
                        decImpOrg = .Cantidad * .PrecioOrg
                        decImpCos = .Cantidad * .PrecioCos
                     End If

                  ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
                     If .MedidaId = moItem.MedidaIdEqui Then
                        decCantidad += .Cantidad
                        decImpOrg = .Cantidad * .PrecioOrg
                        decImpCos = .Cantidad * .PrecioCos

                     ElseIf .MedidaId = moItem.MedidaId Then
                        decCantidad += (.Cantidad / moItem.MedidaCantEqui)
                        decImpOrg = .Cantidad * .PrecioOrg
                        decImpCos = .Cantidad * .PrecioCos
                     End If
                  End If

                  If mlngMonedaId = 1 Then
                     If .MonedaId = mlngMonedaId Then
                        decImporteOrg += decImpOrg
                        decImporteCos += decImpCos
                     Else
                        decImporteOrg += decImpOrg * .TipoCambio
                        decImporteCos += decImpCos * .TipoCambio
                     End If

                  ElseIf mlngMonedaId = 2 Then
                     If .MonedaId = mlngMonedaId Then
                        decImporteOrg += decImpOrg
                        decImporteCos += decImpCos
                     Else
                        decImporteOrg += decImpOrg / .TipoCambio
                        decImporteCos += decImpCos / .TipoCambio
                     End If
                  End If

                  .MoveNext()
               Loop
            End If

            ItemCantidad = decCantidad
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try
   End Function

   Private Function ItemCantidadFecha(ByVal lngItemId As Long, ByVal lngAlmacenId As Long, ByRef decImporteOrg As Decimal, ByRef decImporteCos As Decimal) As Decimal
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
      Dim decCantidad As Decimal = 0
      Dim decImpOrg As Decimal
      Dim decImpCos As Decimal

      ItemCantidadFecha = 0
      decImporteOrg = 0
      decImporteCos = 0

      Try
         With oCompraDet
            .SelectFilter = clsCompraDet.SelectFilters.All
            .WhereFilter = clsCompraDet.WhereFilters.SaldoFechaIgual
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .AlmacenId = mlngAlmacenId
            .ProveedorId = mlngProveedorId
            .CentroCostoIdAct = mlngCentroCostoId
            .SucursalIdAct = mlngSucursalId
            .ItemId = lngItemId
            .Fecha = mstrFecha

            If .Open() Then
               Do While .Read()

                  If mlngMedidaId = 1 Then 'Medida Minima del Reporte
                     If .MedidaId = moItem.MedidaId Then
                        decCantidad += .Cantidad
                        decImpOrg = .Cantidad * .PrecioOrg
                        decImpCos = .Cantidad * .PrecioCos

                     ElseIf .MedidaId = moItem.MedidaIdEqui Then
                        decCantidad += (.Cantidad * moItem.MedidaCantEqui)
                        decImpOrg = .Cantidad * .PrecioOrg
                        decImpCos = .Cantidad * .PrecioCos
                     End If

                  ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
                     If .MedidaId = moItem.MedidaIdEqui Then
                        decCantidad += .Cantidad
                        decImpOrg = .Cantidad * .PrecioOrg
                        decImpCos = .Cantidad * .PrecioCos

                     ElseIf .MedidaId = moItem.MedidaId Then
                        decCantidad += (.Cantidad / moItem.MedidaCantEqui)
                        decImpOrg = .Cantidad * .PrecioOrg
                        decImpCos = .Cantidad * .PrecioCos
                     End If
                  End If

                  If mlngMonedaId = 1 Then
                     If .MonedaId = mlngMonedaId Then
                        decImporteOrg += decImpOrg
                        decImporteCos += decImpCos
                     Else
                        decImporteOrg += decImpOrg * .TipoCambio
                        decImporteCos += decImpCos * .TipoCambio
                     End If

                  ElseIf mlngMonedaId = 2 Then
                     If .MonedaId = mlngMonedaId Then
                        decImporteOrg += decImpOrg
                        decImporteCos += decImpCos
                     Else
                        decImporteOrg += decImpOrg / .TipoCambio
                        decImporteCos += decImpCos / .TipoCambio
                     End If
                  End If

                  .MoveNext()
               Loop
            End If

            ItemCantidadFecha = decCantidad
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try
   End Function

   Private Function TieneMovimiento(ByVal lngItemId As Long) As Boolean
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
            .CentroCostoIdAct = mlngCentroCostoId
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

   Private Sub frmCompraMovLoad()
      Dim oLista As New Queue
      Dim frm As New frmCompraMov

      If grdMain.RowCount > 0 Then
         oLista.Enqueue(ToLong(grdMain.GetValue("ItemId")))

         With frm
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .AlmacenId = mlngAlmacenId
            .ProveedorId = mlngProveedorId
            .MedidaId = mlngMedidaId
            .TipoPagoId = mlngTipoPagoId
            .MonedaId = mlngMonedaId

            If mboolResumido Then
               .IntervaloFecha = mboolIntervaloFecha
               .FechaIni = mstrFechaIni
               .FechaFin = mstrFechaFin
            ElseIf mboolDiario Then
               .IntervaloFecha = True
               .FechaIni = ToDate(grdMain.GetValue("ItemDes"))
               .FechaFin = ToDate(grdMain.GetValue("ItemDes"))
            End If
            .OrdenarFecha = True

            .Lista = oLista
            .MdiParent = Me.MdiParent
            .Show()
         End With
      Else
         MessageBox.Show("Seleccione un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
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
      Dim rpt As New rptCompraMovResu

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moItem.TableName))

      rpt.lblTitle.Text = "Movimiento de Compras por Items Resumido"
      rpt.Document.Name = "Movimiento de Compras por Items Resumido"
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

      oCol = grdMain.RootTable.Columns("ItemId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moItem = New clsItem(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Movimiento de Compras por Items Resumido"

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "C�digo"
         .RootTable.Columns("ItemCod").Width = 100
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Descripci�n"
         .RootTable.Columns("ItemDes").Width = 200
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 80
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cantidad").Caption = "Cantidad"
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 80
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteOrg").Caption = "Importe Orig"
         .RootTable.Columns("ImporteOrg").FormatString = DecimalMask()
         .RootTable.Columns("ImporteOrg").Width = 80
         .RootTable.Columns("ImporteOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("MedidaDes"), Janus.Windows.GridEX.ConditionOperator.Equal, "")
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmCompraMovFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmCompraMovLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompraMovResu_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moItem.Dispose()
      Call ClearMemory()
   End Sub

End Class
