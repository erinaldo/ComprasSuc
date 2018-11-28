Public Class frmAbonoProveedor
   Inherits System.Windows.Forms.Form

   Private moPago As clsPago
   Private moProveedor As clsProveedor
   Private mlngPagoId As Long

   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long
   Private mstrMonedaDes As String
   Private mlngBancoId As Long
   Private mstrBancoCta As String
   Private mlngNroCovenio As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolOrdenarFecha As Boolean
   Private mdatFechaFinRep As Date
   Private mstrSepDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

   Private mboolDetallado As Boolean
   Private mboolResumido As Boolean
   Private mboolOtrosBancos As Boolean

   Private mlngSucursalId As Long

   Private mdecCapital As Decimal
   Private mdecMontoPag As Decimal
   Private mdecMonto As Decimal
   Private mdecMontoAbono As Decimal

   Private mdecCapitalCli As Decimal
   Private mdecMontoPagCli As Decimal
   Private mdecMontoCli As Decimal
   Private mdecMontoAbonoCli As Decimal

   Private mdecCapitalTotal As Decimal
   Private mdecMontoPagTotal As Decimal
   Private mdecMontoTotal As Decimal
   Private mdecMontoAbonoTotal As Decimal

   Private mstrProvBancoCod As String
   Private mstrProvMonedaDes As String

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private moDataSetExportar As DataSet
   Private moDataTableExportar As DataTable

   Private mboolShow As Boolean
   Private mboolChanged As Boolean
   Private mboolSelected As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportExcelMain As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportExcelBMS1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportTextoMain As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportExcelBMS As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportTextoBNB As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportExcelMain1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportTextoMain1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Export1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportTextoBNB1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Export As Janus.Windows.UI.CommandBars.UICommand
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

   Property BancoId() As Long
      Get
         Return mlngBancoId
      End Get

      Set(ByVal Value As Long)
         mlngBancoId = Value
      End Set
   End Property

   Property BancoCta() As String
      Get
         Return mstrBancoCta
      End Get

      Set(ByVal Value As String)
         mstrBancoCta = Value
      End Set
   End Property

   Property NroCovenio() As Long
      Get
         Return mlngNroCovenio
      End Get

      Set(ByVal Value As Long)
         mlngNroCovenio = Value
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

   Property OtrosBancos() As Boolean
      Get
         Return mboolOtrosBancos
      End Get

      Set(ByVal Value As Boolean)
         mboolOtrosBancos = Value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbonoProveedor))
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
      Me.ExportExcelMain1 = New Janus.Windows.UI.CommandBars.UICommand("ExportExcelMain")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ExportTextoMain1 = New Janus.Windows.UI.CommandBars.UICommand("ExportTextoMain")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Export1 = New Janus.Windows.UI.CommandBars.UICommand("Export")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ExportExcelMain = New Janus.Windows.UI.CommandBars.UICommand("ExportExcelMain")
      Me.ExportExcelBMS1 = New Janus.Windows.UI.CommandBars.UICommand("ExportExcelBMS")
      Me.ExportTextoMain = New Janus.Windows.UI.CommandBars.UICommand("ExportTextoMain")
      Me.ExportTextoBNB1 = New Janus.Windows.UI.CommandBars.UICommand("ExportTextoBNB")
      Me.ExportExcelBMS = New Janus.Windows.UI.CommandBars.UICommand("ExportExcelBMS")
      Me.ExportTextoBNB = New Janus.Windows.UI.CommandBars.UICommand("ExportTextoBNB")
      Me.Export = New Janus.Windows.UI.CommandBars.UICommand("Export")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.gexMain = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
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
      Me.ilsMain.Images.SetKeyName(7, "Excel.JPG")
      Me.ilsMain.Images.SetKeyName(8, "Text Document_ico_4.ico")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2, Me.ExportExcelMain, Me.ExportTextoMain, Me.ExportExcelBMS, Me.ExportTextoBNB, Me.Export})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.ExportExcelMain1, Me.Separator4, Me.ExportTextoMain1, Me.Separator5, Me.Export1, Me.Separator6, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(473, 28)
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
      'ExportExcelMain1
      '
      Me.ExportExcelMain1.Key = "ExportExcelMain"
      Me.ExportExcelMain1.Name = "ExportExcelMain1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'ExportTextoMain1
      '
      Me.ExportTextoMain1.Key = "ExportTextoMain"
      Me.ExportTextoMain1.Name = "ExportTextoMain1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Export1
      '
      Me.Export1.Key = "Export"
      Me.Export1.Name = "Export1"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
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
      'ExportExcelMain
      '
      Me.ExportExcelMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ExportExcelBMS1})
      Me.ExportExcelMain.ImageIndex = 7
      Me.ExportExcelMain.Key = "ExportExcelMain"
      Me.ExportExcelMain.Name = "ExportExcelMain"
      Me.ExportExcelMain.Text = "Exportar"
      Me.ExportExcelMain.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'ExportExcelBMS1
      '
      Me.ExportExcelBMS1.Key = "ExportExcelBMS"
      Me.ExportExcelBMS1.Name = "ExportExcelBMS1"
      '
      'ExportTextoMain
      '
      Me.ExportTextoMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ExportTextoBNB1})
      Me.ExportTextoMain.ImageIndex = 8
      Me.ExportTextoMain.Key = "ExportTextoMain"
      Me.ExportTextoMain.Name = "ExportTextoMain"
      Me.ExportTextoMain.Text = "Exportar"
      '
      'ExportTextoBNB1
      '
      Me.ExportTextoBNB1.Key = "ExportTextoBNB"
      Me.ExportTextoBNB1.Name = "ExportTextoBNB1"
      '
      'ExportExcelBMS
      '
      Me.ExportExcelBMS.ImageIndex = 7
      Me.ExportExcelBMS.Key = "ExportExcelBMS"
      Me.ExportExcelBMS.Name = "ExportExcelBMS"
      Me.ExportExcelBMS.Text = "Mercantil Santa Cruz"
      '
      'ExportTextoBNB
      '
      Me.ExportTextoBNB.ImageIndex = 8
      Me.ExportTextoBNB.Key = "ExportTextoBNB"
      Me.ExportTextoBNB.Name = "ExportTextoBNB"
      Me.ExportTextoBNB.Text = "BNB"
      '
      'Export
      '
      Me.Export.ImageIndex = 7
      Me.Export.Key = "Export"
      Me.Export.Name = "Export"
      Me.Export.Text = "Exportar"
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
      'gexMain
      '
      Me.gexMain.GridEX = Me.grdMain
      '
      'frmAbonoProveedor
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmAbonoProveedor"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = " Abono a proveedores "
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
            ''Call frmCreditoEditLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Export"
            Call ExportToExcelLoad()

         Case "ExportExcelBMS"
            Call ExportarToExcelLoad()

         Case "ExportTextoBNB"
            Call BancoBNBExportarLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmAbonoProveedor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmAbonoProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

         mdecCapitalTotal = 0
         mdecMontoPagTotal = 0
         mdecMontoTotal = 0
         mdecMontoAbonoTotal = 0
         mlngPagoId = 0

         For Each lngProveedorId As Long In moLista
            If TieneMovimiento(lngProveedorId) Then

               moProveedor.ProveedorId = lngProveedorId
               moProveedor.FindByPK()

               With moPago
                  mdecCapitalCli = 0
                  mdecMontoPagCli = 0
                  mdecMontoCli = 0
                  mdecMontoAbonoCli = 0

                  lngPosProv = moDataTable.Rows.Count
                  moDataTable.Rows.Add(GetProveedor(lngProveedorId))

                  For Each oRow In .DataSet.Tables(.TableName).Rows
                     moDataTable.Rows.Add(GetPago(oRow))

                     If mboolDetallado Then
                        'decMontoCobranza = oRow("Capital")
                        'decMontoPag = oRow("MontoPag")

                        ''For Each oRow In .DataSet.Tables(.TableName).Rows
                        'While .Read
                        ''If mboolDetallado Then 'Para el Detallado
                        ''   lngPosCred = moDataTable.Rows.Count
                        ''   moDataTable.Rows.Add(GetCredito(oRow("CreditoId")))
                        ''End If

                        '   GetCredito(moPago)

                        '   With oCreditoDet
                        '      .SelectFilter = clsCreditoDet.SelectFilters.All
                        '      .OrderByFilter = clsCreditoDet.OrderByFilters.CreditoDetId

                        '      If mboolIntervaloFecha Then
                        '         .WhereFilter = clsCreditoDet.WhereFilters.CuotaVencidaFecha
                        '         '.Fecha = mstrFechaIni
                        '         .FechaAmo = mstrFechaFin

                        '      Else
                        '         .WhereFilter = clsCreditoDet.WhereFilters.CuotaVencida
                        '      End If

                        '      .EmpresaId = mlngEmpresaId
                        '      .GestionId = mlngGestionId
                        '      .CreditoId = moPago.CreditoId
                        '      .EstadoId = 15
                        '      .CreditoDetId = 14

                        '      If .Open Then
                        '         mdecMora = 0
                        '         mdecInteres = 0
                        '         mdecCapitalAmo = 0
                        '         mdecAmortiza = 0
                        '         mdecAmortizaOrg = 0

                        '         While .Read
                        '            moDataTable.Rows.Add(GetCreditoDet(oCreditoDet))
                        '            .MoveNext()
                        '         End While
                        '      End If
                        '   End With

                        '   .MoveNext()
                        'End While

                     End If

                  Next

                  Call GetProveedorFooter(lngPosProv)
                  ''moDataTable.Rows.Add(GetRowNull)

               End With
            End If
         Next

         ''moDataTable.Rows.Add(GetFooter())

         grdMain.DataSource = moDataSet.Tables(moPago.TableName).DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()

         moPago.CloseConection()
         moProveedor.CloseConection()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCreditoDet.Dispose()

      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moPago.TableName)

      ''moDataTable.Columns.Add("TipoId", Type.GetType("System.Int32"))
      ''moDataTable.Columns.Add("PagoId", Type.GetType("System.Int32"))
      ''moDataTable.Columns.Add("PagoEsp", Type.GetType("System.String"))
      ''moDataTable.Columns.Add("PagoDes", Type.GetType("System.String"))
      ''moDataTable.Columns.Add("VentaOrden", Type.GetType("System.String"))
      ''moDataTable.Columns.Add("Fecha", Type.GetType("System.String"))
      ''moDataTable.Columns.Add("Capital", Type.GetType("System.Decimal"))
      ''moDataTable.Columns.Add("MontoPag", Type.GetType("System.Decimal"))
      ''moDataTable.Columns.Add("MontoBs", Type.GetType("System.Decimal"))
      ''moDataTable.Columns.Add("MontoSus", Type.GetType("System.Decimal"))

      moDataTable.Columns.Add("Sel", Type.GetType("System.String"))
      moDataTable.Columns.Add("PagoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CI", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoDocIdentidadId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ProveedorId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ProveedorDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("BancoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("BancoCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("BancoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("NroCuenta", Type.GetType("System.String"))
      moDataTable.Columns.Add("MonedaIdCuenta", Type.GetType("System.Int32"))
      ''moDataTable.Columns.Add("MonedaCuentaDes", Type.GetType("System.String")) 
      moDataTable.Columns.Add("PagoNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PagoEsp", Type.GetType("System.String"))
      moDataTable.Columns.Add("PagoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompraOrden", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompNro", Type.GetType("System.String"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.String"))
      moDataTable.Columns.Add("Capital", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoPag", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Monto", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoAbono", Type.GetType("System.Decimal"))
   End Sub

   Private Function GetProveedor(ByVal lngProveedorId As Long) As DataRow
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               oRow("PagoId") = -1
               oRow("CI") = .ContactoCI
               oRow("ProveedorId") = .ProveedorId
               oRow("ProveedorDes") = .ContactoDes
               oRow("BancoId") = .BancoId
               oRow("BancoDes") = BancoDesFind(.BancoId, mstrProvBancoCod)
               oRow("BancoCod") = mstrProvBancoCod
               oRow("NroCuenta") = .NroCuenta
               oRow("MonedaIdCuenta") = .MonedaIdCuenta
               ''oRow("MonedaCuentaDes") = .NroCuenta
               oRow("PagoEsp") = "Prov. - " & .ProveedorCod
               oRow("PagoDes") = .ContactoDes
               oRow("CompraOrden") = "Cuenta. - " & .NroCuenta
               oRow("CompNro") = mstrProvBancoCod
               oRow("Fecha") = oRow("BancoDes")
            End If

         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()
      End Try
   End Function

   Private Function GetPago(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      ''oRow("TipoId") = 2
      oRow("PagoId") = oDataRow("PagoId")

      With moProveedor
         oRow("CI") = .ContactoCI
         oRow("TipoDocIdentidadId") = .TipoDocIdentidadId
         oRow("ProveedorId") = .ProveedorId
         oRow("ProveedorDes") = .ContactoDes
         oRow("BancoId") = .BancoId
         oRow("BancoCod") = mstrProvBancoCod
         oRow("NroCuenta") = .NroCuenta
         oRow("MonedaIdCuenta") = .MonedaIdCuenta
         ''oRow("MonedaCuentaDes") = .MonedaIdCuenta
      End With

      oRow("PagoEsp") = "    Cobranza " & ToStr(oDataRow("PagoNro"))
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))

      If oDataRow("TipoPagoId") = 1 Then
         oRow("PagoDes") = " Cobranza Contado "
      Else
         oRow("PagoDes") = " Cobranza Crédito "
      End If

      oRow("CompNro") = oDataRow("CompNro")

      'oRow("Capital") = oDataRow("Capital")

      If oDataRow("MonedaId") = mlngMonedaId Then
         oRow("Capital") = oDataRow("Capital")
         oRow("MontoPag") = oDataRow("MontoPag")

      ElseIf mlngMonedaId = 1 Then
         oRow("Capital") = ToDecimal(oDataRow("Capital") * oDataRow("TipoCambio"))
         oRow("MontoPag") = ToDecimal(oDataRow("MontoPag") * oDataRow("TipoCambio"))

      ElseIf mlngMonedaId = 2 Then
         oRow("Capital") = ToDecimal(oDataRow("Capital") / ToDivByCero(oDataRow("TipoCambio")))
         oRow("MontoPag") = ToDecimal(oDataRow("MontoPag") / ToDivByCero(oDataRow("TipoCambio")))

      End If
      oRow("Monto") = oRow("MontoPag")
      oRow("MontoAbono") = 0

      mdecCapital += oRow("Capital")
      mdecMontoPag += oRow("MontoPag")
      mdecMonto += oRow("Monto")
      mdecMontoAbono += oRow("MontoAbono")

      mdecCapitalCli += oRow("Capital")
      mdecMontoPagCli += oRow("MontoPag")
      mdecMontoCli += oRow("Monto")
      mdecMontoAbonoCli += oRow("MontoAbono")

      mdecCapitalTotal += oRow("Capital")
      mdecMontoPagTotal += oRow("MontoPag")
      mdecMontoTotal += oRow("Monto")
      mdecMontoAbonoTotal += oRow("MontoAbono")

      Return oRow

   End Function

   Private Sub GetProveedorFooter(ByVal lngPosId As Long)
      Dim oRow As DataRow
      oRow = moDataTable.Rows(lngPosId)

      oRow("Capital") = mdecCapitalCli
      oRow("MontoPag") = mdecMontoPagCli
      oRow("Monto") = mdecMontoCli
      oRow("MontoAbono") = mdecMontoAbonoCli

   End Sub

   Private Function GetFooter() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PagoId") = -2
      oRow("PagoEsp") = "Totales General"
      oRow("Capital") = mdecCapitalTotal
      oRow("MontoPag") = mdecMontoPagTotal
      oRow("Monto") = mdecMontoTotal
      oRow("MontoAbono") = mdecMontoAbonoTotal

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

   Private Function BancoDesFind(ByVal lngBancoId As Long, ByRef strCodigoBanco As String) As String
      Dim oBanco As New clsBanco(clsAppInfo.ConnectString)

      Try
         With oBanco
            .SelectFilter = clsBanco.SelectFilters.All
            .WhereFilter = clsBanco.WhereFilters.PrimaryKey
            .BancoId = lngBancoId

            If .Find Then
               strCodigoBanco = .BancoCod
               BancoDesFind = .BancoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oBanco.Dispose()

      End Try
   End Function

   Private Function TieneMovimiento(ByVal lngProveedorId As Long) As Boolean

      TieneMovimiento = False

      Try
         With moPago
            .SelectFilter = clsPago.SelectFilters.AbonoProveedor

            If mboolIntervaloFecha Then
               .WhereFilter = clsPago.WhereFilters.AbonoProveedorFecha
               .Fecha = mstrFechaIni
               .LastUpdateDate = mstrFechaFin

            Else
               .WhereFilter = clsPago.WhereFilters.AbonoProveedor
            End If

            If (mboolOrdenarFecha) Then
               .OrderByFilter = clsPago.OrderByFilters.FechaDesc
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .ProveedorId = lngProveedorId
            .PagoNro = mlngBancoId
            .PlanDescuentoId = mlngMonedaId
            .SucursalId = mlngSucursalId

            .PlanRecargoId = IIf(OtrosBancos, 2, 1)

            If .Find Then
               TieneMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Sub DataShow()
      Dim oPago As New clsPago(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("PagoId")) > 0) Then
            With oPago
               .PagoId = ToLong(grdMain.GetValue("PagoId"))

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
            MessageBox.Show("Documento Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPago.Dispose()

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

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moPago.TableName))

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

#Region " Exportar"

   Private Sub ExportToExcelLoad()
      Try

         ''Dim oDataTable As DataTable
         ''Dim oRow As DataRow

         ''oDataTable = moDataSet.Tables(moCreditoDet.TableName).Clone

         ''For Each oRowMain As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
         ''   oRow = oDataTable.NewRow

         ''   For i = 0 To oRowMain.Cells.Count - 1
         ''      oRow(i) = oRowMain.Cells(i).Value
         ''   Next

         ''   oDataTable.Rows.Add(oRow)
         ''Next

         Call ExportToExcelActiveMdiChild(grdMain)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub ExportToExcelActiveMdiChild(ByRef oControl As Control)
      If TypeOf oControl Is Janus.Windows.GridEX.GridEX Then
         Dim sfd As New SaveFileDialog
         sfd.Title = "Export Report Document"
         sfd.AddExtension = True
         sfd.DefaultExt = "xls"
         sfd.Filter = "Microsoft Excel Files (*.xls)|*.xls"

         If sfd.ShowDialog() = DialogResult.OK Then
            Dim fs As New System.IO.FileStream(sfd.FileName, IO.FileMode.Create, IO.FileAccess.ReadWrite)
            Dim oGrid As Janus.Windows.GridEX.GridEX = CType(oControl, Janus.Windows.GridEX.GridEX)

            gexMain.GridEX = oGrid
            gexMain.Export(fs)

            fs.Close()
         End If
      End If
   End Sub

   Private Sub ExportarToExcelLoad()
      Dim oRow As DataRow
      Dim lngCantDetalle As Long = 0
      Dim lngPos As Integer = -1

      Try

         Call moDataSetInitExportar()


         If (grdMain.GetCheckedRows.Count > 0) And (mdecMontoAbonoTotal > 0) Then
            lngPos = 0
            oRow = moDataTableExportar.NewRow

            oRow("Color") = 1
            oRow("Ci") = mlngNroCovenio
            oRow("Nombre") = mstrBancoCta

            If mlngMonedaId = 1 Then 'Bs
               oRow("Cuenta") = 0            'US
               oRow("TotalDeposito") = mdecMontoAbonoTotal
            Else
               oRow("Cuenta") = 2
               oRow("TotalDeposito") = mdecMontoAbonoTotal
            End If

            oRow("Fecha") = "??"
            oRow("PagoPlanilla") = ConvertDMY(mstrFechaFin)
            oRow("LiquidoPagable") = ConvertDMY(mstrFechaFin)
            oRow("PagoPlanillaXBco") = 1

            moDataTableExportar.Rows.Add(oRow)
         End If

         If lngPos > -1 Then
            For Each oRowMain As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
               If oRowMain.Cells("Sel").Value Then
                  If oRowMain.Cells("PagoId").Value() > 0 Then
                     oRow = moDataTableExportar.NewRow

                     'oRow("Color") = 0
                     oRow("Ci") = oRowMain.Cells("CI").Value()
                     oRow("Nombre") = oRowMain.Cells("ProveedorDes").Value()
                     oRow("Cuenta") = oRowMain.Cells("NroCuenta").Value()
                     oRow("Fecha") = ConvertDMY(mstrFechaFin)
                     oRow("PagoPlanilla") = 1
                     oRow("LiquidoPagable") = oRowMain.Cells("Amortiza").Value()
                     oRow("TotalDeposito") = System.DBNull.Value
                     oRow("PagoPlanillaXBco") = System.DBNull.Value
                     oRow("Concepto") = oRowMain.Cells("PagoEsp").Value()

                     moDataTableExportar.Rows.Add(oRow)
                     lngCantDetalle += 1
                  End If
               End If
            Next

         End If

         Dim oGrid As Janus.Windows.GridEX.GridEX = New Janus.Windows.GridEX.GridEX
         oGrid.DataSource = moDataTableExportar.DefaultView
         oGrid.RetrieveStructure()
         Call grdMainInitExportar(oGrid)

         Call ExportToExcelActiveMdiChild(oGrid)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub moDataSetInitExportar()
      moDataSetExportar = New DataSet("Tablas")
      moDataTableExportar = moDataSetExportar.Tables.Add("Banco")
      moDataTableExportar.Columns.Add("Color", Type.GetType("System.Int32"))
      moDataTableExportar.Columns.Add("Ci", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("Nombre", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("Cuenta", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("Fecha", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("PagoPlanilla", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("LiquidoPagable", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("TotalDeposito", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("PagoPlanillaXBco", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("Concepto", Type.GetType("System.String"))
   End Sub

   Private Sub grdMainInitExportar(ByRef oGrid As Janus.Windows.GridEX.GridEX)
      With oGrid
         ebrMain.Groups(0).Text = "Cuentas Depósito Banco"

         .RootTable.Columns("Color").Visible = False

         .RootTable.Columns("Ci").Caption = "C.I."
         .RootTable.Columns("Ci").Width = 100
         .RootTable.Columns("Ci").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Ci").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Nombre").Caption = "Nombre Completo"
         .RootTable.Columns("Nombre").Width = 200
         .RootTable.Columns("Nombre").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Nombre").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cuenta").Caption = "Cuenta"
         .RootTable.Columns("Cuenta").Width = 200
         .RootTable.Columns("Cuenta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Cuenta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").Width = 200
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PagoPlanilla").Caption = "Pago Planilla"
         .RootTable.Columns("PagoPlanilla").Width = 200
         .RootTable.Columns("PagoPlanilla").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PagoPlanilla").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("LiquidoPagable").Caption = "Líquido Pagable"
         .RootTable.Columns("LiquidoPagable").Width = 200
         .RootTable.Columns("LiquidoPagable").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("LiquidoPagable").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TotalDeposito").Caption = "Total Depósito"
         .RootTable.Columns("TotalDeposito").Width = 200
         .RootTable.Columns("TotalDeposito").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TotalDeposito").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PagoPlanillaXBco").Caption = "Pago Planilla p/Banco"
         .RootTable.Columns("PagoPlanillaXBco").Width = 200
         .RootTable.Columns("PagoPlanillaXBco").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PagoPlanillaXBco").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Concepto").Caption = "Concepto"
         .RootTable.Columns("Concepto").Width = 200
         .RootTable.Columns("Concepto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Concepto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With

      Call AddConditionalFormattingExportar(oGrid)
   End Sub

   Private Sub AddConditionalFormattingExportar(ByRef oGrid As Janus.Windows.GridEX.GridEX)
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(oGrid.RootTable.Columns("Color"), Janus.Windows.GridEX.ConditionOperator.Equal, 1)
      fc.FormatStyle.ForeColor = Color.DarkRed
      oGrid.RootTable.FormatConditions.Add(fc)

   End Sub

#End Region

#Region " Banco BNB"

   Private Sub moDataSetInitBNB()
      moDataSetExportar = New DataSet("Tablas")
      moDataTableExportar = moDataSetExportar.Tables.Add("Banco")
      moDataTableExportar.Columns.Add("color", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("Index", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("BancoId", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("BancoCod", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("CI", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("TipoDocIdentidadId", Type.GetType("System.String"))
      ''moDataTableExportar.Columns.Add("ExpedidoCod", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("Nombre", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("AñoMes", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("Planilla", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("LiquidoPagable", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("Cuenta", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("Formato", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("NroCuenta", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("MonedaIdCuenta", Type.GetType("System.String"))
      moDataTableExportar.Columns.Add("LiqPagable", Type.GetType("System.Decimal"))
      moDataTableExportar.Columns.Add("DatoRef", Type.GetType("System.String"))

   End Sub

   Private Sub BancoBNBExportarLoad()
      Dim oRow As DataRow
      Dim lngCantDetalle As Long = 0
      Dim lngPos As Integer = -1
      Dim datFecha As Date = ToDate2(ConvertDMY(mstrFechaFin))

      Try

         Call moDataSetInitBNB()

         If (grdMain.GetCheckedRows.Count > 0) And (mdecMontoAbonoTotal > 0) Then
            lngPos = 0
            oRow = moDataTableExportar.NewRow
            oRow("color") = 1
            ''Call FindCuentaBanco()
            oRow("Index") = mlngNroCovenio
            oRow("Nombre") = mstrBancoCta
            oRow("AñoMes") = FechaToNumberAMD(datFecha)
            oRow("Planilla") = reemplazarStr("000000", ToStr(lngCantDetalle))

            If mlngMonedaId = 1 Then
               oRow("LiquidoPagable") = reemplazarStr("0000000000000", ToDecStrDos(mdecMontoAbonoTotal)).Replace(",", "")
               oRow("Cuenta") = reemplazarStr("0000000000000", 0).Replace(",", "")
            Else
               oRow("LiquidoPagable") = reemplazarStr("0000000000000", 0).Replace(",", "")
               oRow("Cuenta") = reemplazarStr("0000000000000", ToDecStrDos(mdecMontoAbonoTotal)).Replace(",", "")
            End If
            oRow("Formato") = "010"

            moDataTableExportar.Rows.Add(oRow)
         End If

         If lngPos > -1 Then
            For Each oRowMain As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
               If oRowMain.Cells("Sel").Value Then

                  oRow = moDataTableExportar.NewRow

                  If oRowMain.Cells("PagoId").Value() > 0 Then
                     oRow("Color") = 0
                     datFecha = ToDate2(oRowMain.Cells("Fecha").Value())
                     oRow("Index") = oRowMain.Cells("CI").Value()
                     oRow("BancoId") = oRowMain.Cells("BancoId").Value()
                     oRow("BancoCod") = oRowMain.Cells("BancoCod").Value()
                     oRow("Ci") = oRowMain.Cells("CI").Value()
                     oRow("TipoDocIdentidadId") = oRowMain.Cells("TipoDocIdentidadId").Value()
                     oRow("Nombre") = oRowMain.Cells("ProveedorDes").Value()
                     oRow("AñoMes") = FechaToNumberAM(datFecha)  ''ConvertDMY(mstrFechaFin)
                     oRow("Planilla") = 1
                     oRow("LiquidoPagable") = oRowMain.Cells("MontoAbono").Value()
                     oRow("Cuenta") = oRowMain.Cells("NroCuenta").Value()
                     oRow("Formato") = "007"
                     oRow("NroCuenta") = oRowMain.Cells("NroCuenta").Value()
                     oRow("MonedaIdCuenta") = oRowMain.Cells("MonedaIdCuenta").Value()
                     oRow("LiqPagable") = oRowMain.Cells("MontoAbono").Value()
                     oRow("DatoRef") = GetDatoRefBNB(datFecha, oRowMain.Cells("CompNro").Value())

                     moDataTableExportar.Rows.Add(oRow)
                     lngCantDetalle += 1
                  End If
               End If
            Next

            oRow = moDataTableExportar.Rows(lngPos)
            oRow("Planilla") = reemplazarStr("000000", ToStr(lngCantDetalle))

         End If

         Dim oGrid As Janus.Windows.GridEX.GridEX = New Janus.Windows.GridEX.GridEX
         oGrid.DataSource = moDataTableExportar.DefaultView
         oGrid.RetrieveStructure()
         Call grdMainInitBNB(oGrid)

         Call ExportTextBNB()
         ''Call ExportToExcelActiveMdiChild(oGrid)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub grdMainInitBNB(ByRef oGrid As Janus.Windows.GridEX.GridEX)
      With oGrid
         ebrMain.Groups(0).Text = "Cuentas Depósito Banco Nacional Boliviano"

         .RootTable.Columns("color").Visible = False
         .RootTable.Columns("BancoId").Visible = False
         .RootTable.Columns("CI").Visible = False
         ''.RootTable.Columns("ExpedidoCod").Visible = False
         .RootTable.Columns("NroCuenta").Visible = False
         .RootTable.Columns("MonedaIdCuenta").Visible = False
         .RootTable.Columns("LiqPagable").Visible = False
         .RootTable.Columns("BancoCod").Visible = False

         .RootTable.Columns("Index").Caption = "Nro."
         .RootTable.Columns("Index").Width = 100
         .RootTable.Columns("Index").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Index").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Nombre").Caption = "Nombre Completo"
         .RootTable.Columns("Nombre").Width = 300
         .RootTable.Columns("Nombre").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Nombre").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AñoMes").Caption = "Año/Mes"
         .RootTable.Columns("AñoMes").Width = 100
         .RootTable.Columns("AñoMes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("AñoMes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Planilla").Caption = "Planilla"
         .RootTable.Columns("Planilla").Width = 80
         .RootTable.Columns("Planilla").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Planilla").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("LiquidoPagable").Caption = "Líquido Pagable"
         .RootTable.Columns("LiquidoPagable").Width = 200
         .RootTable.Columns("LiquidoPagable").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("LiquidoPagable").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cuenta").Caption = "Cuenta"
         .RootTable.Columns("Cuenta").Width = 100
         .RootTable.Columns("Cuenta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cuenta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Formato").Caption = "Formato"
         .RootTable.Columns("Formato").Width = 100
         .RootTable.Columns("Formato").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Formato").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("DatoRef").Caption = "Dato Ref"
         .RootTable.Columns("DatoRef").Width = 100
         .RootTable.Columns("DatoRef").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("DatoRef").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With

      Call AddConditionalFormattingBNB(oGrid)
   End Sub

   Private Sub AddConditionalFormattingBNB(ByRef oGrid As Janus.Windows.GridEX.GridEX)
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(oGrid.RootTable.Columns("Color"), Janus.Windows.GridEX.ConditionOperator.Equal, 1)
      fc.FormatStyle.ForeColor = Color.DarkRed
      oGrid.RootTable.FormatConditions.Add(fc)

   End Sub

   Private Sub ExportTextBNB()
      Dim strFilename As String
      Dim strLine, strLine1, strLine2, strLine3, strLine4, strLine5 As String
      Dim sfd As New SaveFileDialog

      'Dim oRow As DataRow
      Dim strTipoTran, strTipoCI, strMes, strEntero, strDecimal, strBanco As String
      Dim decLiqPagable As Decimal
      Try
         sfd.DefaultExt = "txt"
         sfd.Filter = "Text Files (*.txt)|*.txt"
         sfd.FilterIndex = 2
         sfd.RestoreDirectory = True

         If sfd.ShowDialog() = DialogResult.OK Then
            strFilename = sfd.FileName
            Dim file As New System.IO.StreamWriter(strFilename)

            For Each oRow In moDataTableExportar.Rows
               If ToLong(oRow("Color")) = 1 Then

                  strLine = reemplazarStrAll(FillCharacter(10, "0"), ToStr(mlngNroCovenio)) & reemplazarStrAll(FillCharacter(10, "0"), ToStr(mstrBancoCta)) & ToStr(oRow("AñoMes")) _
                 & ToStr(oRow("Planilla")) & ToStr(oRow("LiquidoPagable").Replace(".", "")).PadLeft(13, "0") _
                 & ToStr(oRow("Cuenta").Replace(".", "")).PadLeft(13, "0") _
                 & FillCharacter(137, " ")

               ElseIf ToLong(oRow("Color")) = 0 Then
                  ''If ToStr(oRow("BancoCod")) = "1001" Then
                  If mlngBancoId = oRow("BancoId") Then
                     strTipoTran = "01"
                     strBanco = "1001" ''3 datos del banco
                  Else
                     strTipoTran = "04"
                     strBanco = reemplazarStrAll("0000", ToStr(oRow("BancoCod")))
                  End If

                  strTipoCI = "00"   ''01 CI ''2
                  If oRow("TipoDocIdentidadId") = 1 Then
                     strTipoCI = "01"    ''CI
                  ElseIf oRow("TipoDocIdentidadId") = 2 Then
                     strTipoCI = "02"  ''RUN
                  ElseIf oRow("TipoDocIdentidadId") = 3 Then
                     strTipoCI = "09"   ''NIT
                  End If

                  ''1,2,3
                  strLine1 = Trim(strTipoTran & strTipoCI & ToStr(oRow("CI")).Replace("-", ""))
                  strLine1 &= FillCharacter(19 - strLine1.Length, " ")

                  ''4
                  strLine2 = Trim(ToStr(oRow("Nombre")))
                  strLine2 &= FillCharacter(40 - strLine2.Length, " ")

                  ''-5
                  strMes = Trim(ToStr(oRow("AñoMes")))

                  ''-7
                  decLiqPagable = ToDecimalDos(oRow("LiqPagable"))
                  strEntero = Math.Floor(decLiqPagable)
                  strEntero = strEntero.PadLeft(11, "0")

                  strDecimal = ToStr(Math.Floor((decLiqPagable - Math.Floor(decLiqPagable)) * 100))
                  If strDecimal.Length = 1 Then
                     strDecimal = "0" & strDecimal
                  End If

                  ''5,6,7,8,9
                  ''strLine3 = mstrGestion & strMes & ToStr(ListPosition(cboMoneda, cboMoneda.SelectedIndex)) & strEntero & strDecimal & strTipo & ToStr(oRow("NroCuenta"))
                  strLine3 = strMes & ToStr(oRow("MonedaIdCuenta")) & strEntero & strDecimal & strBanco & ToStr(oRow("NroCuenta"))
                  strLine3 = Trim(strLine3)
                  strLine3 &= FillCharacter(44 - strLine3.Length, " ")

                  ''strLine = strLine1 & strLine2 & strLine3 & FillCharacter(32, "0") & "PAGO DE FACTURA" & FillCharacter(45, " ") & "10" & ""
                  ''11
                  strLine4 = "02"

                  ''12
                  strLine4 &= oRow("DatoRef")
                  strLine4 &= FillCharacter(17 - strLine4.Length, " ")

                  ''13
                  strLine5 = "PAGO DE FACTURA"
                  strLine5 &= FillCharacter(60 - strLine5.Length, " ")

                  ''10,11,12,14
                  strLine = strLine1 & strLine2 & strLine3 & FillCharacter(15, " ") & strLine4 & strLine5 & "10" & ""

               End If

               file.WriteLine(strLine)

            Next

            file.Close()

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

#End Region

#Region " Exportar Texto"

   Private Sub ExportText()
      Dim strFilename As String
      Dim strLine, strLine1, strLine2, strLine3 As String
      Dim sfd As New SaveFileDialog

      'Dim oRow As DataRow
      Dim strBanco, strTipoCI, strMes, strEntero, strDecimal, strTipo As String
      Dim decLiqPagable As Decimal
      Try
         sfd.DefaultExt = "txt"
         sfd.Filter = "Text Files (*.txt)|*.txt"
         sfd.FilterIndex = 2
         sfd.RestoreDirectory = True

         If sfd.ShowDialog() = DialogResult.OK Then
            strFilename = sfd.FileName
            Dim file As New System.IO.StreamWriter(strFilename)

            For Each oRow In moDataTable.Rows
               If ToLong(oRow("Color")) = 1 Then

                  strLine = ToStr(mlngNroCovenio) & ToStr(mstrBancoCta) & ToStr(oRow("AñoMes")) _
                   & ToStr(oRow("Planilla")) & ToStr(oRow("LiquidoPagable").Replace(".", "")).PadLeft(13, "0") _
                   & ToStr(oRow("Cuenta").Replace(".", "")).PadLeft(13, "0")

               ElseIf ToLong(oRow("Color")) = 0 Then
                  ''If ToStr(oRow("CodClienteCuenta")) = "1001" Then
                  If mlngBancoId = mlngBancoId Then
                     strBanco = "01"
                     strTipo = "1001"
                  Else
                     strBanco = "04"
                     strTipo = ToStr(oRow("CodClienteCuenta")) ''Codigo de Banco ???
                  End If
                  strTipoCI = "01" ''2
                  strLine1 = Trim(strBanco & strTipoCI & ToStr(oRow("CI")).Replace("-", "") & ToStr(oRow("ExpedidoCod")))
                  strLine1 &= FillCharacter(19 - strLine1.Length, " ")

                  strLine2 = Trim(ToStr(oRow("Nombre")))
                  ''strLine2 &= FillCharacter(40 - strLine2.Length, " ")
                  strLine2 &= strEntero.PadRight(40 - strLine2.Length, " ")

                  ''If mlngMesId < 10 Then
                  ''   strMes = "0" & ToStr(mlngMesId)
                  ''ElseIf mlngMesId > 9 Then
                  ''   strMes = ToStr(mlngMesId)
                  ''End If

                  strMes = Trim(ToStr(oRow("AñoMes")))

                  decLiqPagable = ToDecimalDos(oRow("LiqPagable"))
                  strEntero = Math.Floor(decLiqPagable)
                  strEntero = strEntero.PadLeft(11, "0")

                  strDecimal = ToStr(Math.Floor((decLiqPagable - Math.Floor(decLiqPagable)) * 100))
                  If strDecimal.Length = 1 Then
                     strDecimal = "0" & strDecimal
                  End If
                  ''strLine3 = mstrGestion & strMes & ToStr(ListPosition(cboMoneda, cboMoneda.SelectedIndex)) & strEntero & strDecimal & strTipo & ToStr(oRow("NroCuenta"))
                  strLine3 = strMes & mlngMonedaId & strEntero & strDecimal & strTipo & ToStr(oRow("NroCuenta"))
                  strLine3 = Trim(strLine3)
                  strLine3 &= FillCharacter(44 - strLine3.Length, " ")

                  ''10
                  strLine = strLine1 & strLine2 & strLine3 & FillCharacter(32, "0") & "PAGO DE SUELDOS" & FillCharacter(45, " ") & "10" & ""

               End If

               file.WriteLine(strLine)

            Next

            file.Close()

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function FillCharacter(ByVal intCantCharacter As Integer, ByVal strCharacter As String) As String
      Dim strCadena As String = ""
      For intCont As Integer = 1 To intCantCharacter
         strCadena &= strCharacter
      Next
      Return strCadena
   End Function

   Public Function reemplazarStr(ByVal ceros As String, ByVal numero As String) As String
      ceros = ceros.Remove(0, numero.Length)
      Return ceros & numero
   End Function

   Public Function reemplazarStrAll(ByVal ceros As String, ByVal numero As String) As String
      If numero.Length > ceros.Length Then
         numero = Trim(numero).Substring(0, ceros.Length)
      End If
      ceros = ceros.Remove(0, numero.Length)
      Return ceros & numero
   End Function

   Public Function ToStringTruncate(ByVal Value As String, ByVal maxLength As Long) As String
      If IsDBNull(Value) Then
         Return "''"
      ElseIf Value = Nothing Then
         Return "''"
      ElseIf Value.Trim() <> String.Empty Then
         If Value.Length <= maxLength Then
            Return "'" & Trim(Value) & "'"
         Else
            Return "'" & Trim(Value).Substring(0, maxLength) & "'"
         End If
      Else
         Return "''"
      End If
   End Function

   Private Function FechaToNumberAMD(ByVal datFecha As Date) As String
      Dim lngFecha As Long
      Dim strFecha As String

      strFecha = ToStr(datFecha.Year)

      lngFecha = ToLong(datFecha.Month)
      If lngFecha < 10 Then
         strFecha &= "0" & ToStr(lngFecha)
      ElseIf lngFecha > 9 Then
         strFecha &= ToStr(lngFecha)
      End If

      lngFecha = ToLong(datFecha.Day)
      If lngFecha < 10 Then
         strFecha &= "0" & ToStr(lngFecha)
      ElseIf lngFecha > 9 Then
         strFecha &= ToStr(lngFecha)
      End If

      FechaToNumberAMD = strFecha
   End Function

   Private Function FechaToNumberAM(ByVal datFecha As Date) As String
      Dim lngFecha As Long
      Dim strFecha As String

      strFecha = ToStr(datFecha.Year)

      lngFecha = ToLong(datFecha.Month)
      If lngFecha < 10 Then
         strFecha &= "0" & ToStr(lngFecha)
      ElseIf lngFecha > 9 Then
         strFecha &= ToStr(lngFecha)
      End If

      FechaToNumberAM = strFecha
   End Function

   Private Function GetDatoRefBNB(ByVal datFecha As Date, ByVal lngCompNro As Long) As String
      Dim strDatoRef As String
      Dim lngMes As String = datFecha.Month

      If lngMes < 10 Then
         strDatoRef &= "0" & ToStr(lngMes)
      Else
         strDatoRef &= ToStr(lngMes)
      End If

      strDatoRef &= "E" ''Comp
      strDatoRef &= ToStr(datFecha.Year) ''Año
      strDatoRef &= ToStr(lngCompNro) ''NroComprobante

      GetDatoRefBNB = strDatoRef
   End Function

#End Region

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("PagoId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moPago = New clsPago(clsAppInfo.ConnectString)
      moProveedor = New clsProveedor(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainCheckAll(ByVal boolValue As Boolean)
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         oRow.BeginEdit()

         If boolValue Then
            oRow.IsChecked = True
            oRow.Cells("MontoAbono").Value = oRow.Cells("Monto").Value
         Else
            oRow.IsChecked = False
            oRow.Cells("MontoAbono").Value = 0
         End If

         oRow.EndEdit()
      Next
      Call MontoPagar()
   End Sub

   Private Sub grdMainCheck(ByVal lngProveedorId As Long, ByVal boolValue As Boolean)
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If lngProveedorId = oRow.Cells("ProveedorId").Value Then
            oRow.BeginEdit()

            If boolValue Then
               oRow.IsChecked = True
               oRow.Cells("MontoAbono").Value = oRow.Cells("Monto").Value
            Else
               oRow.IsChecked = False
               oRow.Cells("MontoAbono").Value = 0
            End If

            oRow.EndEdit()
         End If
      Next
      Call MontoPagar()
   End Sub

   Private Sub MontoPagar()

      Dim decMontoAbonoProv As Decimal = 0
      Dim decMontoAbono As Decimal = 0
      Dim lngPos As Integer = 0
      Dim lngPosProv As Integer = 0
      Dim lngPosProvOrg As Integer = -1
      Dim oRowProv As Janus.Windows.GridEX.GridEXRow

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If ToDecimal(oRow.Cells("PagoId").Value) = -1 Then
            oRowProv = grdMain.GetRow(lngPosProv)
            oRowProv.BeginEdit()
            oRowProv.Cells("MontoAbono").Value = decMontoAbonoProv
            oRowProv.EndEdit()

            lngPosProv = lngPos
            lngPosProvOrg = lngPos
            decMontoAbonoProv = 0
         Else
            If ToDecimal(oRow.Cells("MontoAbono").Value) > 0 Then

               decMontoAbonoProv += ToDecimal(oRow.Cells("MontoAbono").Value)
               decMontoAbono += ToDecimal(oRow.Cells("MontoAbono").Value)

            End If
         End If
         lngPos += 1
      Next

      If lngPosProvOrg > -1 Then
         oRowProv = grdMain.GetRow(lngPosProv)
         oRowProv.BeginEdit()
         oRowProv.Cells("MontoAbono").Value = decMontoAbonoProv
         oRowProv.EndEdit()
      End If

      mdecMontoAbonoTotal = decMontoAbono
      grdMain.UpdateData()
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Pago a Proveedores"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("PagoId").Visible = False
         .RootTable.Columns("PagoNro").Visible = False

         .RootTable.Columns("CI").Caption = "CI"
         .RootTable.Columns("CI").Width = 100
         .RootTable.Columns("CI").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CI").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CI").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("CI").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox
         .RootTable.Columns("CI").Visible = False

         .RootTable.Columns("TipoDocIdentidadId").Visible = False

         .RootTable.Columns("ProveedorId").Visible = False
         .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
         .RootTable.Columns("ProveedorDes").Width = 100
         .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ProveedorDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("ProveedorDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox
         .RootTable.Columns("ProveedorDes").Visible = False

         .RootTable.Columns("BancoId").Visible = False
         .RootTable.Columns("BancoDes").Visible = False

         .RootTable.Columns("NroCuenta").Caption = "Nro Cuenta"
         .RootTable.Columns("NroCuenta").Width = 80
         .RootTable.Columns("NroCuenta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("NroCuenta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NroCuenta").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("NroCuenta").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox
         .RootTable.Columns("NroCuenta").Visible = False

         .RootTable.Columns("BancoCod").Visible = False

         .RootTable.Columns("MonedaIdCuenta").Visible = False
         '.RootTable.Columns("MonedaCuentaDes").Visible = False

         .RootTable.Columns("PagoEsp").Caption = "Especificación"
         .RootTable.Columns("PagoEsp").Width = 150
         .RootTable.Columns("PagoEsp").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PagoEsp").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PagoEsp").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("PagoEsp").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("PagoDes").Caption = "Descripción"
         .RootTable.Columns("PagoDes").Width = 150
         .RootTable.Columns("PagoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PagoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PagoDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("PagoDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("CompraOrden").Caption = "Nro. Orden"
         .RootTable.Columns("CompraOrden").Width = 100
         .RootTable.Columns("CompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraOrden").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("CompraOrden").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("CompNro").Caption = "Nro. Comp"
         .RootTable.Columns("CompNro").Width = 80
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("CompNro").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("Fecha").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("Capital").Caption = "Capital"
         .RootTable.Columns("Capital").FormatString = DecimalMask()
         .RootTable.Columns("Capital").Width = 100
         .RootTable.Columns("Capital").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Capital").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Capital").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("Capital").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("MontoPag").Caption = "Monto Pag"
         .RootTable.Columns("MontoPag").FormatString = DecimalMask()
         .RootTable.Columns("MontoPag").Width = 100
         .RootTable.Columns("MontoPag").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoPag").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoPag").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("MontoPag").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("Monto").Caption = "Monto Pag"
         .RootTable.Columns("Monto").FormatString = DecimalMask()
         .RootTable.Columns("Monto").Width = 100
         .RootTable.Columns("Monto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Monto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Monto").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("Monto").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox
         .RootTable.Columns("Monto").Visible = False

         .RootTable.Columns("MontoAbono").Caption = "Depósito"
         .RootTable.Columns("MontoAbono").FormatString = DecimalMask()
         .RootTable.Columns("MontoAbono").Width = 90
         .RootTable.Columns("MontoAbono").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoAbono").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoAbono").CellStyle.BackColor = Color.MistyRose
         .RootTable.Columns("MontoAbono").EditType = Janus.Windows.GridEX.EditType.NoEdit

         'If mboolResumido Then
         '   .RootTable.Columns("Fecha").Visible = False
         '   .RootTable.Columns("CompraOrden").Visible = False
         'End If
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PagoId"), Janus.Windows.GridEX.ConditionOperator.NotEqual, 0)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PagoId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PagoId"), Janus.Windows.GridEX.ConditionOperator.Equal, -2)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMain_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grdMain.EditingCell
      If e.Column.DataMember = "MontoAbono" Then
         If ToLong(grdMain.GetValue("PagoId")) <= 0 Then
            e.Cancel = True
         End If
      End If
   End Sub

   Private Sub grdMain_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdMain.UpdatingCell

      If e.Column.DataMember = "Amortiza" Then
         If ToDecimal(e.Value) = 0 Then
            e.Value = 0
            grdMain.SetValue("Sel", False)

         ElseIf ToDecimal(e.Value) < 0 Then
            e.Cancel = True
            grdMain.SetValue("Sel", False)
            MessageBox.Show("Monto Negativo Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         ElseIf ToDecimal(e.Value) > ToDecimal(grdMain.GetValue("CapitalDif")) Then
            e.Cancel = True
            grdMain.SetValue("Sel", False)
            MessageBox.Show("Monto Superior al Importe de la Cuota", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Else
            grdMain.SetValue("Sel", True)
         End If
      End If
   End Sub

   Private Sub grdMain_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdMain.CellUpdated
      Call MontoPagar()
   End Sub

   Private Sub grdMain_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdMain.RowCheckStateChanged
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            Call grdMainCheckAll(True)
         ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            Call grdMainCheckAll(False)
         End If
      Else
         If grdMain.GetValue("PagoId") = -1 Then
            If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
               Call grdMainCheck(grdMain.GetValue("ProveedorId"), True)
            ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
               Call grdMainCheck(grdMain.GetValue("ProveedorId"), False)
            End If
         Else
            If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
               grdMain.SetValue("MontoAbono", grdMain.GetValue("Monto"))
            ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
               grdMain.SetValue("MontoAbono", 0)
            End If
            Call MontoPagar()
         End If
      End If
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmAbonoProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            'Call DocumentoEditLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmAbonoProveedor_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPago.Dispose()
      Call ClearMemory()
   End Sub

End Class
