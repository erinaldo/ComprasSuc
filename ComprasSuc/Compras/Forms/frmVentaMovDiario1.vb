Public Class frmVentaMovDiario1
    Inherits System.Windows.Forms.Form

    Private moCompra As clsCompra
    Private moPedCompra As clsPedCompra

    Private mlngEmpresaId As Long
    Private mlngGestionId As Long
    Private mlngMedidaId As Long
    Private mlngMonedaId As Long
    Private mlngSucursalId As Long
    Private moListaProveedor As New Queue
    Private moListaCentroCosto As New Queue

    Private mboolIntervaloFecha As Boolean
    Private mdatFechaIni As Date
    Private mdatFechaFin As Date

    Private moDataSet As DataSet
    Private moDataTable As DataTable

    Private mboolChanged As Boolean
    Private mboolSelected As Boolean
   
    Private mlngID As Long

#Region " Set and Get "
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

    Property ListaProveedor() As Queue
        Get
            Return moListaProveedor
        End Get

        Set(ByVal Value As Queue)
            moListaProveedor = Value
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

    Property ListaCentroCosto() As Queue
        Get
            Return moListaCentroCosto
        End Get

        Set(ByVal Value As Queue)
            moListaCentroCosto = Value
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
#End Region

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
    Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
    Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
    Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents ilsMain As System.Windows.Forms.ImageList
    Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentaMovDiario1))
        Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
        Me.grdMain = New Janus.Windows.GridEX.GridEX
        Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
        Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
        Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
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
        Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator3, Me.Exit1})
        Me.UiCommandBar1.Key = "ToolBar"
        Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.UiCommandBar1.Name = "UiCommandBar1"
        Me.UiCommandBar1.RowIndex = 0
        Me.UiCommandBar1.Size = New System.Drawing.Size(241, 28)
        Me.UiCommandBar1.Text = "ToolBar"
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
        'frmVentaMovDiario1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(752, 442)
        Me.Controls.Add(Me.uiBackground)
        Me.Controls.Add(Me.TopRebar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmVentaMovDiario1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Compras por Proveedor"
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
            'Case "Book"
            '    ' Call frmVentaEditLoad(ToLong(grdMain.GetValue("VentaId")))

            Case "ViewAll"
                Call DataViewAll()

            Case "Print"
                Call PrintReport()

            Case "Exit"
                Me.Close()
        End Select

        Me.Cursor = oCursor
    End Sub

    Private Sub frmVentaMovDiario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Call StatusFormDisplay(Me.Name)
    End Sub

    Private Sub frmVentaMovDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub FormInit()
        Call FormCenterChild(Me)

        moCompra = New clsCompra(clsAppInfo.ConnectString)
        moPedCompra = New clsPedCompra(clsAppInfo.ConnectString)
    End Sub

    Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
        If e.Control And e.KeyCode = Keys.C Then
            If Not grdMain.CurrentColumn Is Nothing Then
                Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
            End If
        End If
    End Sub

    Private Sub frmVentaMovDiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.WindowState <> FormWindowState.Minimized Then
            If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
                '  Call frmVentaEditLoad(ToLong(grdMain.GetValue("VentaId")))

            ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmVentaMovDiario_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        moCompra.Dispose()
        Call ClearMemory()
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
        Dim rpt As New rptVentaPorSucursal

        rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompra.TableName))

        rpt.lblTitle.Text = "Resumen de Compras por Proveedor"
        rpt.Document.Name = "Resumen de Compras por Proveedor"
        rpt.lblCompany.Text = clsAppInfo.EmpresaGral

        rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
        rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
        rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

        rpt.txtFechaIni.Text = ConvertDMY(ToDate(mdatFechaIni))
        rpt.txtFechaFin.Text = ConvertDMY(ToDate(mdatFechaFin))
        rpt.txtClienteDes.Text = MonedaDesFind(mlngMonedaId)

        Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

        rpt.Run(True)
        Dim frm As frmReportPreview
        frm = New frmReportPreview(rpt.Document)
        frm.Show()
    End Sub

#Region " DataSet "
    Private Sub moDataSetInit()
        moDataSet = New DataSet("Tablas")
        moDataTable = moDataSet.Tables.Add(moCompra.TableName)
        moDataTable.Columns.Add("CompraId", Type.GetType("System.Int32"))
        moDataTable.Columns.Add("CompraNro", Type.GetType("System.Int32"))
        moDataTable.Columns.Add("CompraDetId", Type.GetType("System.Int32"))
        moDataTable.Columns.Add("Fecha", Type.GetType("System.String"))
        moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
        moDataTable.Columns.Add("ItemCod", Type.GetType("System.String"))
        moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))
        moDataTable.Columns.Add("MedidaId", Type.GetType("System.Int32"))
        moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
        moDataTable.Columns.Add("ProveedorId", Type.GetType("System.Int32"))
        moDataTable.Columns.Add("ProveedorCod", Type.GetType("System.String"))
        moDataTable.Columns.Add("ProveedorDes", Type.GetType("System.String"))
        moDataTable.Columns.Add("CentroCostoId", Type.GetType("System.Int32"))
        moDataTable.Columns.Add("CentroCostoCod", Type.GetType("System.String"))
        moDataTable.Columns.Add("CentroCostoDes", Type.GetType("System.String"))
        moDataTable.Columns.Add("CantidadPed", Type.GetType("System.Decimal"))
        moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
        moDataTable.Columns.Add("PrecioOrg", Type.GetType("System.Decimal"))
        moDataTable.Columns.Add("Importe", Type.GetType("System.Decimal"))
        moDataTable.Columns.Add("CompraObs", Type.GetType("System.String"))
        moDataTable.Columns.Add("Acumulado", Type.GetType("System.Int32"))
        moDataTable.Columns.Add("Estado", Type.GetType("System.Int32"))
    End Sub

    Private Function GetRowNew(ByVal oDataRow As DataRow) As DataRow
        Dim oRow As DataRow
        oRow = moDataTable.NewRow

        oRow("CompraId") = oDataRow("CompraId")
        oRow("CompraNro") = oDataRow("CompraNro")
        oRow("CompraDetId") = oDataRow("CompraDetId")
        oRow("Fecha") = ConvertDMY(ToDate(oDataRow("FechaDet")))
        oRow("ItemId") = oDataRow("ItemId")
        oRow("ItemCod") = oDataRow("ItemCod")
        oRow("ItemDes") = oDataRow("ItemDes")
        
        oRow("ProveedorId") = oDataRow("ProveedorId")
        oRow("ProveedorCod") = oDataRow("ProveedorCod")
        oRow("ProveedorDes") = oDataRow("ProveedorDes")
        oRow("CentroCostoId") = oDataRow("CentroCostoId")
        oRow("CentroCostoCod") = oDataRow("CentroCostoCod")
        oRow("CentroCostoDes") = oDataRow("CentroCostoDes")


        If ToStr(oDataRow("CompraDetDes")) <> String.Empty Then
            oRow("CompraObs") = oDataRow("CompraDetDes")
        End If



        If mlngMedidaId = 1 Then 'Medida Minima del Reporte
            If ToLong(oDataRow("MedidaId")) = ToLong(oDataRow("MedidaMinItem")) Then
                oRow("MedidaId") = oDataRow("MedidaId")
                oRow("MedidaDes") = oDataRow("MedidaDes")
                oRow("Cantidad") = oDataRow("Cantidad")
                oRow("PrecioOrg") = oDataRow("PrecioOrg")
                oRow("Importe") = oDataRow("Importe")
            Else
                oRow("MedidaId") = oDataRow("MedidaMinItem")
                oRow("MedidaDes") = MedidaDesFind(ToLong(oDataRow("MedidaMinItem")))
                oRow("Cantidad") = ToDecimal(oDataRow("Cantidad")) * ToDecimal(oDataRow("MedidaCantEquiItem"))
                If oDataRow("PrecioOrg") <> 0 Then oRow("PrecioOrg") = ToDecimal(oDataRow("PrecioOrg")) / ToDecimal(oDataRow("MedidaCantEquiItem"))
                If oDataRow("Importe") <> 0 Then oRow("Importe") = ToDecimal(oDataRow("PrecioCos")) / ToDecimal(oDataRow("MedidaCantEquiItem"))
            End If

        ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
            If ToLong(oDataRow("MedidaId")) = ToLong(oDataRow("MedidaEquiItem")) Then
                oRow("MedidaId") = oDataRow("MedidaId")
                oRow("MedidaDes") = oDataRow("MedidaDes")
                oRow("Cantidad") = oDataRow("Cantidad")
                oRow("PrecioOrg") = oDataRow("PrecioOrg")
                oRow("Importe") = oDataRow("Importe")
            Else
                oRow("MedidaId") = oDataRow("MedidaEquiItem")
                oRow("MedidaDes") = MedidaDesFind(ToLong(oDataRow("MedidaEquiItem")))
                If oDataRow("Cantidad") <> 0 Then oRow("Cantidad") = ToDecimal(oDataRow("Cantidad")) / ToDecimal(oDataRow("MedidaCantEquiItem"))
                oRow("PrecioOrg") = ToDecimal(oDataRow("PrecioOrg")) * ToDecimal(oDataRow("MedidaCantEquiItem"))
                oRow("Importe") = ToDecimal(oDataRow("Importe")) * ToDecimal(oDataRow("MedidaCantEquiItem"))
            End If
        End If
        oRow("CantidadPed") = 0
        oRow("Acumulado") = 1
        Return oRow
    End Function

    Private Sub RowEdit(ByVal oRow As DataRow, ByVal oDataRow As DataRow)
        If ToStr(oRow("CompraObs")) = String.Empty And ToStr(oDataRow("CompraDetDes")) <> String.Empty Then
            oRow("CompraObs") = oDataRow("CompraDetDes")
        End If

        If mlngMedidaId = 1 Then 'Medida Minima del Reporte
            If ToLong(oDataRow("MedidaId")) = ToLong(oDataRow("MedidaMinItem")) Then
                oRow("Cantidad") = ToDecimal(oRow("Cantidad")) + ToDecimal(oDataRow("Cantidad"))
                oRow("Importe") = ToDecimal(oRow("Importe")) + ToDecimal(oDataRow("Importe"))
                If oRow("Cantidad") <> 0 Then
                    oRow("PrecioOrg") = ToDecimal(oRow("Importe")) / ToDecimal(oRow("Cantidad"))
                End If

            Else
                oRow("Cantidad") = ToDecimal(oRow("Cantidad")) + (ToDecimal(oDataRow("Cantidad")) * ToDecimal(oDataRow("MedidaCantEquiItem")))
                If oDataRow("Importe") <> 0 Then oRow("Importe") = ToDecimal(oRow("Importe")) + (ToDecimal(oDataRow("PrecioCos")) / ToDecimal(oDataRow("MedidaCantEquiItem")))
                If oRow("Cantidad") <> 0 Then
                    oRow("PrecioOrg") = ToDecimal(oRow("Importe")) / ToDecimal(oRow("Cantidad"))
                End If
            End If

        ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
            If ToLong(oDataRow("MedidaId")) = ToLong(oDataRow("MedidaEquiItem")) Then
                oRow("Cantidad") = ToDecimal(oRow("Cantidad")) + ToDecimal(oDataRow("Cantidad"))
                oRow("Importe") = ToDecimal(oRow("Importe")) + ToDecimal(oDataRow("Importe"))
                If oRow("Cantidad") <> 0 Then
                    oRow("PrecioOrg") = ToDecimal(oRow("Importe")) / ToDecimal(oRow("Cantidad"))
                End If
            Else
                If oDataRow("Cantidad") <> 0 Then oRow("Cantidad") = ToDecimal(oRow("Cantidad")) + (ToDecimal(oDataRow("Cantidad")) / ToDecimal(oDataRow("MedidaCantEquiItem")))
                oRow("Importe") = ToDecimal(oRow("Importe")) + (ToDecimal(oDataRow("Importe")) * ToDecimal(oDataRow("MedidaCantEquiItem")))
                If oRow("Cantidad") <> 0 Then
                    oRow("PrecioOrg") = ToDecimal(oRow("Importe")) / ToDecimal(oRow("Cantidad"))
                End If
            End If
        End If
        oRow("Acumulado") = ToLong(oRow("Acumulado")) + 1
    End Sub

    Private Sub RowEditPedido(ByVal oRow As DataRow, ByVal oDataRow As DataRow)
        If mlngMedidaId = 1 Then 'Medida Minima del Reporte
            If ToLong(oDataRow("MedidaId")) = ToLong(oDataRow("MedidaMinItem")) Then
                oRow("CantidadPed") = ToDecimal(oRow("CantidadPed")) + ToDecimal(oDataRow("Cantidad"))
            Else
                oRow("CantidadPed") = ToDecimal(oRow("CantidadPed")) + (ToDecimal(oDataRow("Cantidad")) * ToDecimal(oDataRow("MedidaCantEquiItem")))
            End If

        ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
            If ToLong(oDataRow("MedidaId")) = ToLong(oDataRow("MedidaEquiItem")) Then
                oRow("CantidadPed") = ToDecimal(oRow("CantidadPed")) + ToDecimal(oDataRow("Cantidad"))
            Else
                If oDataRow("Cantidad") <> 0 Then oRow("CantidadPed") = ToDecimal(oRow("CantidadPed")) + (ToDecimal(oDataRow("Cantidad")) / ToDecimal(oDataRow("MedidaCantEquiItem")))
            End If
        End If
    End Sub

    Private Function GetRowNull() As DataRow
        Dim oRow As DataRow
        oRow = moDataTable.NewRow

        Return oRow
    End Function

    Private Function GetProveedor(ByVal lngProveedorId As Long) As DataRow
        Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
        Dim oRow As DataRow
        oRow = moDataTable.NewRow

        oProveedor.ProveedorId = lngProveedorId
        oRow("Estado") = 1
        If oProveedor.FindByPK Then

            oRow("ItemCod") = oProveedor.ProveedorCod
            oRow("ItemDes") = oProveedor.ProveedorDes
        End If

        oProveedor.Dispose()
        Return oRow
    End Function
#End Region

#Region " Metodo "
    Private Function ExisteEnLista(ByVal lngCompraId As Long, ByVal lngItemId As Long, ByVal lngProveedorId As Long, ByRef lngIndex As Long) As Boolean
        ExisteEnLista = False
        lngIndex = 0
        For Each oRow In moDataSet.Tables(moCompra.TableName).Rows
            If ToLong(oRow("CompraId")) = lngCompraId And ToLong(oRow("ItemId")) = lngItemId And ToLong(oRow("ProveedorId")) = lngProveedorId Then
                ExisteEnLista = True
                Exit Function
            End If
            lngIndex = lngIndex + 1
        Next
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
        Try
            With oMoneda
                .MonedaId = lngMonedaId

                If .FindByPK Then
                    MonedaDesFind = .MonedaDes
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            oMoneda.Dispose()
        End Try
    End Function
#End Region

#Region " Grid "
    Private Sub DataViewAll()
        grdMain.RemoveFilters()
    End Sub

    Private Sub grdMainLoad()
        Dim oDataRow As DataRow()
        Dim lngIndex As Long
        Try
            Call moDataSetInit()
            With moCompra
                .SelectFilter = clsCompra.SelectFilters.ComprasProveedor
                .WhereFilter = clsCompra.WhereFilters.ComprasProveedor
                .OrderByFilter = clsCompra.OrderByFilters.Fecha

                .EmpresaId = mlngEmpresaId
                .GestionId = mlngGestionId
                .SucursalId = mlngSucursalId
                .Fecha = ToDate(mdatFechaIni)
                .LastUpdateDate = ToDate(mdatFechaFin)
                If .Open Then
                    If .DataSet.Tables(.TableName).Rows.Count > 0 Then
                        For Each lngProveedorId As Integer In moListaProveedor
                            oDataRow = .DataSet.Tables(.TableName).Select("ProveedorId = " & lngProveedorId)
                            If oDataRow.Length > 0 Then
                                'moDataTable.Rows.Add(GetProveedor(lngProveedorId))
                                For Each oRow In oDataRow
                                    For Each lngCentroCostoId As Integer In moListaCentroCosto
                                        If ToLong(oRow("CentroCostoId")) = lngCentroCostoId Or lngCentroCostoId = -1 Then
                                            If ToLong(oRow("MonedaId")) <> mlngMonedaId Then
                                                If ToLong(oRow("MonedaId")) = clsMoneda.BOLIVIANOS Then
                                                    oRow("PrecioOrg") = ToDecimal(oRow("PrecioOrg")) / ToDecimal(oRow("TipoCambio"))
                                                    oRow("Importe") = ToDecimal(oRow("Importe")) / ToDecimal(oRow("TipoCambio"))
                                                ElseIf ToLong(oRow("MonedaId")) = clsMoneda.DOLARES Then
                                                    oRow("PrecioOrg") = ToDecimal(oRow("PrecioOrg")) * ToDecimal(oRow("TipoCambio"))
                                                    oRow("Importe") = ToDecimal(oRow("Importe")) * ToDecimal(oRow("TipoCambio"))
                                                End If
                                            End If

                                            If Not ExisteEnLista(oRow("CompraId"), oRow("ItemId"), lngProveedorId, lngIndex) Then
                                                moDataTable.Rows.Add(GetRowNew(oRow))
                                            Else
                                                moDataTable.Rows.Add(GetRowNew(oRow))
                                                '   Call RowEdit(moDataSet.Tables(moCompra.TableName).Rows(lngIndex), oRow)
                                            End If
                                        End If
                                    Next
                                Next
                                moDataTable.Rows.Add(GetRowNull)
                            End If
                        Next
                    End If
                End If

                With moPedCompra
                    .SelectFilter = clsPedCompra.SelectFilters.ComprasProveedor
                    .WhereFilter = clsPedCompra.WhereFilters.ComprasProveedor

                    .EmpresaId = mlngEmpresaId
                    .GestionId = mlngGestionId
                    .SucursalId = mlngSucursalId
                    .Fecha = ToDate(mdatFechaIni)
                    .LastUpdateDate = ToDate(mdatFechaFin)
                    If .Open Then
                        If .DataSet.Tables(.TableName).Rows.Count > 0 Then
                            For Each lngProveedorId As Integer In moListaProveedor
                                oDataRow = .DataSet.Tables(.TableName).Select("ProveedorId = " & lngProveedorId)
                                If oDataRow.Length > 0 Then
                                    For Each oRow In oDataRow
                                        For Each lngCentroCostoId As Integer In moListaCentroCosto
                                            If ToLong(oRow("CentroCostoId")) = lngCentroCostoId Or lngCentroCostoId = -1 Then
                                                If ExisteEnLista(oRow("CompraId"), oRow("ItemId"), lngProveedorId, lngIndex) Then
                                                    Call RowEditPedido(moDataSet.Tables(moCompra.TableName).Rows(lngIndex), oRow)
                                                    'Else
                                                    '    MessageBox.Show("Aqui si estamos mal")
                                                End If
                                            End If
                                        Next
                                    Next
                                    'moDataTable.Rows.Add(GetRowNull)
                                End If
                            Next
                        End If
                    End If
                End With

                grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
                grdMain.RetrieveStructure()
                Call grdMainInit()

                .CloseConection()
            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub grdMainInit()
        With grdMain
            ebrMain.Groups(0).Text = "Resumen de Compras por Proveedor"

            .RootTable.Columns("CompraId").Visible = False
            .RootTable.Columns("CompraDetId").Visible = False

            .RootTable.Columns("CompraNro").Caption = "Nro. Compra"
            .RootTable.Columns("CompraNro").Width = 70
            .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Fecha").Visible = False
            .RootTable.Columns("Fecha").Caption = "Fecha"
            .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
            .RootTable.Columns("Fecha").Width = 70
            .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ItemId").Visible = False

            .RootTable.Columns("ItemCod").Caption = "Código Prod."
            .RootTable.Columns("ItemCod").Width = 70
            .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ItemDes").Caption = "Producto"
            .RootTable.Columns("ItemDes").Width = 110
            .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MedidaId").Visible = False

            .RootTable.Columns("MedidaDes").Caption = "Medida"
            .RootTable.Columns("MedidaDes").Width = 75
            .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ProveedorId").Visible = False

            .RootTable.Columns("ProveedorCod").Caption = "Código Prov."
            .RootTable.Columns("ProveedorCod").Width = 70
            .RootTable.Columns("ProveedorCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ProveedorCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
            .RootTable.Columns("ProveedorDes").Width = 110
            .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CentroCostoId").Visible = False

            .RootTable.Columns("CentroCostoCod").Caption = "Código C.C."
            .RootTable.Columns("CentroCostoCod").Width = 70
            .RootTable.Columns("CentroCostoCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CentroCostoCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CentroCostoDes").Caption = "C.C."
            .RootTable.Columns("CentroCostoDes").Width = 110
            .RootTable.Columns("CentroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CentroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Cantidad").Caption = "Cantidad"
            .RootTable.Columns("Cantidad").FormatString = DecimalMask()
            .RootTable.Columns("Cantidad").Width = 80
            .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CantidadPed").Caption = "Cant. Ped."
            .RootTable.Columns("CantidadPed").FormatString = DecimalMask()
            .RootTable.Columns("CantidadPed").Width = 80
            .RootTable.Columns("CantidadPed").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("CantidadPed").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("PrecioOrg").Caption = "Precio Unitario"
            .RootTable.Columns("PrecioOrg").FormatString = DecimalMask()
            .RootTable.Columns("PrecioOrg").Width = 80
            .RootTable.Columns("PrecioOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("PrecioOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Importe").Caption = "Importe Neto"
            .RootTable.Columns("Importe").FormatString = DecimalMask()
            .RootTable.Columns("Importe").Width = 80
            .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CompraObs").Caption = "Observacion"
            .RootTable.Columns("CompraObs").FormatString = DecimalMask()
            .RootTable.Columns("CompraObs").Width = 100
            .RootTable.Columns("CompraObs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("CompraObs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Acumulado").Visible = False
            .RootTable.Columns("Estado").Visible = False
        End With

        Call AddConditionalFormatting()
    End Sub

    Private Sub AddConditionalFormatting()
        Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

        fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Estado"), Janus.Windows.GridEX.ConditionOperator.Equal, 1)
        fc.FormatStyle.ForeColor = Color.DarkBlue
        grdMain.RootTable.FormatConditions.Add(fc)
    End Sub
#End Region

End Class
