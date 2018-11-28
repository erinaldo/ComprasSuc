Public Class frmFacturaDifMultipleDetEdit
   Inherits System.Windows.Forms.Form

   Private moFactura As clsFactura
   Private moFacturaDet As clsFacturaDet

   Private moCompraFac As clsCompraFac

   Private mlngEmpresaId As Long
   Private mqueItem As New Queue

   Private mboolAdding As Boolean = False
   Private mboolAnular As Boolean = False
   Private mboolEditing As Boolean = False
   Private mboolChanged As Boolean = False
   Private mboolClose As Boolean

   Private mboolDetallado As Boolean
   Private mboolIvaFac As Boolean
   Private mstrFechaFin As String
   Private mstrLlaveDosifica As String

   Private mboolExigirInfAdi As Boolean
   Private mboolEditarPrecio As Boolean

   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mdecMontoFac As Decimal
   Private mdecMontoFacOrig As Decimal
   Private mlngID As Long

   Private mdecTipoCambio As Decimal
   Private mstrNroCompras As String
   Private mstrNroAutorizacion As String

   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngTipoPlanId As Long
   Private mboolTieneComp As Boolean

   Private mstrFechaIniDosifica As String
   Private mstrFechaFinDosifica As String
   Private mlngCantItemDosifica As Long
   Private mlngTipoDosificaId As Long

   Private mlngTipoItemId As Long
   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long
   Private mlngTipoTasaId As Long
   Private mdecTipoTasaMonto As Decimal

   Private mboolICE_IEHD As Boolean
   Private mboolExento As Boolean

   Private mdecMontoFacturado As Decimal
   Private mdecExentoFacturado As Decimal

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moCompraDetTable As DataTable
   Private modtCompraDetItem As DataTable ''CompraDetItem
   Private mlngCompraDetItemId As Long ''CompraDetItem

   Private moDataTableVenOrg As DataTable

   Private modsFacturaDet As DataSet
   Private modtFacturaDet As DataTable

   Private mstrSepDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents chkProveedor As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents chkBancarizar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtMontoPorFacBs As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtMontoBruBs As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents grpCompra As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents tabCompras As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents txtMontoPorFacSus As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoBruSus As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents mnuFacturaDet As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowFacturaDet As System.Windows.Forms.MenuItem
   Friend WithEvents tabFac As Janus.Windows.UI.Tab.UITab
   Friend WithEvents tabObservacion As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtFacturaObs As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents tabOtros As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents txtFacturaOC As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtFacturaNE As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtFacturaPL As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtFacturaTC As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents Label24 As System.Windows.Forms.Label
   Friend WithEvents lblFacturaPL As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtSubTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtDescuento As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtImporteIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNeto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtExento As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIceIehd As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtFacturaMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label25 As System.Windows.Forms.Label
   Friend WithEvents Label28 As System.Windows.Forms.Label
   Friend WithEvents tabDescuento As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents cboPlanDescuento As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label26 As System.Windows.Forms.Label
   Friend WithEvents txtMontoDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents chkFacturaNoValida As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents txtFacturaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents cboTipoFacCompra As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblTipoFacCompraId As System.Windows.Forms.Label
   Friend WithEvents mnuEditFacturaDet As System.Windows.Forms.MenuItem

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get
      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   WriteOnly Property NewRecord() As Boolean
      Set(ByVal Value As Boolean)
         mboolAdding = Value
      End Set
   End Property

   WriteOnly Property AnularFac() As Boolean

      Set(ByVal Value As Boolean)
         mboolAnular = Value
      End Set

   End Property

   WriteOnly Property Editing() As Boolean
      Set(ByVal Value As Boolean)
         mboolEditing = Value
      End Set
   End Property

   Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get

      Set(ByVal Value As Boolean)
         mboolChanged = Value
      End Set
   End Property

   WriteOnly Property IvaFac() As Boolean
      Set(ByVal Value As Boolean)
         mboolIvaFac = Value
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

   Property CompraDataTable() As DataTable
      Get
         Return moDataTableVenOrg
      End Get

      Set(ByVal Value As DataTable)
         moDataTableVenOrg = Value
      End Set
   End Property

   WriteOnly Property DataObject() As clsFactura

      Set(ByVal Value As clsFactura)
         moFactura = Value
      End Set

   End Property

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property

   WriteOnly Property ProveedorId() As Long
      Set(ByVal Value As Long)
         mlngProveedorId = Value
      End Set
   End Property

   WriteOnly Property CentroCostoId() As Long
      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   WriteOnly Property MonedaId() As Long
      Set(ByVal Value As Long)
         mlngMonedaId = Value
      End Set
   End Property

   WriteOnly Property TipoCambio() As Decimal
      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

#Region " Windows Form Designer generated code "

   Public Sub New()
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()

      'Add any initialization after the InitializeComponent() call

   End Sub

   'Form overrides dispose to clean up the component list.
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

   'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Diseñador de Windows Forms.  
   'No lo modifique con el editor de código.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaDifMultipleDetEdit))
      Dim cboNroRUC_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboRegRUC_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtSubTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtDescuento = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.txtImporteIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtNeto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtExento = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIceIehd = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtFacturaMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.Label25 = New System.Windows.Forms.Label
      Me.Label28 = New System.Windows.Forms.Label
      Me.tabFac = New Janus.Windows.UI.Tab.UITab
      Me.tabObservacion = New Janus.Windows.UI.Tab.UITabPage
      Me.cboTipoFacCompra = New Janus.Windows.EditControls.UIComboBox
      Me.lblTipoFacCompraId = New System.Windows.Forms.Label
      Me.chkFacturaNoValida = New Janus.Windows.EditControls.UICheckBox
      Me.chkBancarizar = New Janus.Windows.EditControls.UICheckBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtFacturaObs = New Janus.Windows.GridEX.EditControls.EditBox
      Me.tabOtros = New Janus.Windows.UI.Tab.UITabPage
      Me.txtFacturaOC = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtFacturaNE = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtFacturaPL = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtFacturaTC = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label22 = New System.Windows.Forms.Label
      Me.Label23 = New System.Windows.Forms.Label
      Me.Label24 = New System.Windows.Forms.Label
      Me.lblFacturaPL = New System.Windows.Forms.Label
      Me.tabDescuento = New Janus.Windows.UI.Tab.UITabPage
      Me.txtMontoDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label26 = New System.Windows.Forms.Label
      Me.cboPlanDescuento = New Janus.Windows.EditControls.UIComboBox
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.tabCompras = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpCompra = New Janus.Windows.EditControls.UIGroupBox
      Me.txtMontoPorFacSus = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtMontoBruSus = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtMontoPorFacBs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label12 = New System.Windows.Forms.Label
      Me.txtMontoBruBs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.chkProveedor = New Janus.Windows.EditControls.UICheckBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtFacturaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label21 = New System.Windows.Forms.Label
      Me.cboNroRUC = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.txtCodControl = New Janus.Windows.GridEX.EditControls.MaskedEditBox
      Me.txtNroAutorizacion = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboRegRUC = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.txtFacturaNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.dtpFacturaFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.Label18 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.Label20 = New System.Windows.Forms.Label
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit3 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.mnuFacturaDet = New System.Windows.Forms.ContextMenu
      Me.mnuShowFacturaDet = New System.Windows.Forms.MenuItem
      Me.mnuEditFacturaDet = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.tabFac, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabFac.SuspendLayout()
      Me.tabObservacion.SuspendLayout()
      Me.tabOtros.SuspendLayout()
      Me.tabDescuento.SuspendLayout()
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabMain.SuspendLayout()
      Me.tabCompras.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.grpCompra, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpCompra.SuspendLayout()
      CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cboNroRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboRegRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(734, 167)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdMain
      '
      Me.grdMain.AllowCardSizing = False
      Me.grdMain.AlternatingColors = True
      Me.grdMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdMain.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdMain.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdMain.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdMain.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdMain.FocusCellFormatStyle.BackColor = System.Drawing.Color.White
      Me.grdMain.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdMain.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdMain.GroupByBoxVisible = False
      Me.grdMain.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdMain.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdMain.Location = New System.Drawing.Point(0, 0)
      Me.grdMain.Name = "grdMain"
      Me.grdMain.RecordNavigator = True
      Me.grdMain.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdMain.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdMain.Size = New System.Drawing.Size(734, 167)
      Me.grdMain.TabIndex = 13
      Me.grdMain.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
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
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.UiGroupBox1)
      Me.uiBackground.Controls.Add(Me.tabFac)
      Me.uiBackground.Controls.Add(Me.tabMain)
      Me.uiBackground.Controls.Add(Me.grpCompra)
      Me.uiBackground.Controls.Add(Me.grpMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(770, 466)
      Me.uiBackground.TabIndex = 17
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtSubTotal)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.txtDescuento)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.txtImporteIVA)
      Me.UiGroupBox1.Controls.Add(Me.txtIVA)
      Me.UiGroupBox1.Controls.Add(Me.txtNeto)
      Me.UiGroupBox1.Controls.Add(Me.txtExento)
      Me.UiGroupBox1.Controls.Add(Me.txtIceIehd)
      Me.UiGroupBox1.Controls.Add(Me.txtFacturaMonto)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.Label8)
      Me.UiGroupBox1.Controls.Add(Me.Label25)
      Me.UiGroupBox1.Controls.Add(Me.Label28)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(345, 351)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(417, 113)
      Me.UiGroupBox1.TabIndex = 19
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtSubTotal
      '
      Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Info
      Me.txtSubTotal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSubTotal.FormatString = "##,##0.000"
      Me.txtSubTotal.Location = New System.Drawing.Point(301, 14)
      Me.txtSubTotal.Name = "txtSubTotal"
      Me.txtSubTotal.ReadOnly = True
      Me.txtSubTotal.Size = New System.Drawing.Size(108, 20)
      Me.txtSubTotal.TabIndex = 25
      Me.txtSubTotal.TabStop = False
      Me.txtSubTotal.Text = "0,000"
      Me.txtSubTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtSubTotal.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtSubTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(236, 18)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(60, 16)
      Me.Label3.TabIndex = 200
      Me.Label3.Text = "SubTotal "
      '
      'txtDescuento
      '
      Me.txtDescuento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDescuento.FormatString = "##,##0.000"
      Me.txtDescuento.Location = New System.Drawing.Point(93, 86)
      Me.txtDescuento.Name = "txtDescuento"
      Me.txtDescuento.ReadOnly = True
      Me.txtDescuento.Size = New System.Drawing.Size(108, 20)
      Me.txtDescuento.TabIndex = 24
      Me.txtDescuento.TabStop = False
      Me.txtDescuento.Text = "0,000"
      Me.txtDescuento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDescuento.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDescuento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(9, 90)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(79, 16)
      Me.Label4.TabIndex = 198
      Me.Label4.Text = "Descuento"
      '
      'txtImporteIVA
      '
      Me.txtImporteIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtImporteIVA.BackColor = System.Drawing.SystemColors.Info
      Me.txtImporteIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporteIVA.FormatString = "##,##0.000"
      Me.txtImporteIVA.Location = New System.Drawing.Point(301, 86)
      Me.txtImporteIVA.Name = "txtImporteIVA"
      Me.txtImporteIVA.ReadOnly = True
      Me.txtImporteIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtImporteIVA.TabIndex = 28
      Me.txtImporteIVA.TabStop = False
      Me.txtImporteIVA.Text = "0,000"
      Me.txtImporteIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporteIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporteIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIVA
      '
      Me.txtIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtIVA.BackColor = System.Drawing.SystemColors.Info
      Me.txtIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIVA.FormatString = "##,##0.000"
      Me.txtIVA.Location = New System.Drawing.Point(301, 62)
      Me.txtIVA.Name = "txtIVA"
      Me.txtIVA.ReadOnly = True
      Me.txtIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtIVA.TabIndex = 27
      Me.txtIVA.TabStop = False
      Me.txtIVA.Text = "0,000"
      Me.txtIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNeto
      '
      Me.txtNeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtNeto.BackColor = System.Drawing.SystemColors.Info
      Me.txtNeto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNeto.FormatString = "##,##0.000"
      Me.txtNeto.Location = New System.Drawing.Point(301, 38)
      Me.txtNeto.Name = "txtNeto"
      Me.txtNeto.ReadOnly = True
      Me.txtNeto.Size = New System.Drawing.Size(108, 20)
      Me.txtNeto.TabIndex = 26
      Me.txtNeto.TabStop = False
      Me.txtNeto.Text = "0,000"
      Me.txtNeto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtNeto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtNeto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtExento
      '
      Me.txtExento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtExento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtExento.FormatString = "##,##0.000"
      Me.txtExento.Location = New System.Drawing.Point(93, 62)
      Me.txtExento.Name = "txtExento"
      Me.txtExento.ReadOnly = True
      Me.txtExento.Size = New System.Drawing.Size(108, 20)
      Me.txtExento.TabIndex = 23
      Me.txtExento.TabStop = False
      Me.txtExento.Text = "0,000"
      Me.txtExento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtExento.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtExento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIceIehd
      '
      Me.txtIceIehd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtIceIehd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIceIehd.FormatString = "##,##0.000"
      Me.txtIceIehd.Location = New System.Drawing.Point(93, 38)
      Me.txtIceIehd.Name = "txtIceIehd"
      Me.txtIceIehd.ReadOnly = True
      Me.txtIceIehd.Size = New System.Drawing.Size(108, 20)
      Me.txtIceIehd.TabIndex = 22
      Me.txtIceIehd.TabStop = False
      Me.txtIceIehd.Text = "0,000"
      Me.txtIceIehd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIceIehd.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIceIehd.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtFacturaMonto
      '
      Me.txtFacturaMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtFacturaMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaMonto.FormatString = "##,##0.000"
      Me.txtFacturaMonto.Location = New System.Drawing.Point(93, 14)
      Me.txtFacturaMonto.Name = "txtFacturaMonto"
      Me.txtFacturaMonto.ReadOnly = True
      Me.txtFacturaMonto.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaMonto.TabIndex = 21
      Me.txtFacturaMonto.TabStop = False
      Me.txtFacturaMonto.Text = "0,000"
      Me.txtFacturaMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtFacturaMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtFacturaMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(212, 87)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(88, 17)
      Me.Label5.TabIndex = 194
      Me.Label5.Text = "Imp Base-IVA"
      '
      'Label6
      '
      Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(265, 66)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(33, 16)
      Me.Label6.TabIndex = 193
      Me.Label6.Text = "IVA"
      '
      'Label7
      '
      Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(212, 41)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(88, 17)
      Me.Label7.TabIndex = 192
      Me.Label7.Text = "Importe Base"
      '
      'Label8
      '
      Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(9, 64)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(79, 17)
      Me.Label8.TabIndex = 13
      Me.Label8.Text = "Exento"
      '
      'Label25
      '
      Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label25.BackColor = System.Drawing.Color.Transparent
      Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label25.Location = New System.Drawing.Point(9, 41)
      Me.Label25.Name = "Label25"
      Me.Label25.Size = New System.Drawing.Size(79, 17)
      Me.Label25.TabIndex = 12
      Me.Label25.Text = "ICE / IEHD"
      '
      'Label28
      '
      Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label28.BackColor = System.Drawing.Color.Transparent
      Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label28.Location = New System.Drawing.Point(9, 18)
      Me.Label28.Name = "Label28"
      Me.Label28.Size = New System.Drawing.Size(96, 16)
      Me.Label28.TabIndex = 11
      Me.Label28.Text = "Importe Total"
      '
      'tabFac
      '
      Me.tabFac.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.tabFac.FirstTabOffset = 10
      Me.tabFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.tabFac.Location = New System.Drawing.Point(4, 352)
      Me.tabFac.Name = "tabFac"
      Me.tabFac.Size = New System.Drawing.Size(336, 112)
      Me.tabFac.TabDisplay = Janus.Windows.UI.Tab.TabDisplay.Text
      Me.tabFac.TabIndex = 12
      Me.tabFac.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabObservacion, Me.tabOtros, Me.tabDescuento})
      Me.tabFac.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'tabObservacion
      '
      Me.tabObservacion.Controls.Add(Me.cboTipoFacCompra)
      Me.tabObservacion.Controls.Add(Me.lblTipoFacCompraId)
      Me.tabObservacion.Controls.Add(Me.chkFacturaNoValida)
      Me.tabObservacion.Controls.Add(Me.chkBancarizar)
      Me.tabObservacion.Controls.Add(Me.Label13)
      Me.tabObservacion.Controls.Add(Me.txtFacturaObs)
      Me.tabObservacion.Key = "Observacion"
      Me.tabObservacion.Location = New System.Drawing.Point(1, 20)
      Me.tabObservacion.Name = "tabObservacion"
      Me.tabObservacion.Size = New System.Drawing.Size(334, 91)
      Me.tabObservacion.TabStop = True
      Me.tabObservacion.Text = "Observación"
      '
      'cboTipoFacCompra
      '
      Me.cboTipoFacCompra.DropListFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFacCompra.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFacCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.Location = New System.Drawing.Point(96, 43)
      Me.cboTipoFacCompra.Name = "cboTipoFacCompra"
      Me.cboTipoFacCompra.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoFacCompra.Size = New System.Drawing.Size(232, 20)
      Me.cboTipoFacCompra.TabIndex = 14
      Me.cboTipoFacCompra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblTipoFacCompraId
      '
      Me.lblTipoFacCompraId.BackColor = System.Drawing.Color.Transparent
      Me.lblTipoFacCompraId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTipoFacCompraId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblTipoFacCompraId.Location = New System.Drawing.Point(8, 47)
      Me.lblTipoFacCompraId.Name = "lblTipoFacCompraId"
      Me.lblTipoFacCompraId.Size = New System.Drawing.Size(88, 16)
      Me.lblTipoFacCompraId.TabIndex = 284
      Me.lblTipoFacCompraId.Text = "Tipo Compra"
      '
      'chkFacturaNoValida
      '
      Me.chkFacturaNoValida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkFacturaNoValida.BackColor = System.Drawing.Color.Transparent
      Me.chkFacturaNoValida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFacturaNoValida.Enabled = False
      Me.chkFacturaNoValida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFacturaNoValida.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFacturaNoValida.Location = New System.Drawing.Point(196, 70)
      Me.chkFacturaNoValida.Name = "chkFacturaNoValida"
      Me.chkFacturaNoValida.Size = New System.Drawing.Size(128, 16)
      Me.chkFacturaNoValida.TabIndex = 16
      Me.chkFacturaNoValida.TabStop = False
      Me.chkFacturaNoValida.Text = "Factura No Válida"
      Me.chkFacturaNoValida.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkBancarizar
      '
      Me.chkBancarizar.BackColor = System.Drawing.Color.Transparent
      Me.chkBancarizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkBancarizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkBancarizar.Location = New System.Drawing.Point(8, 70)
      Me.chkBancarizar.Name = "chkBancarizar"
      Me.chkBancarizar.Size = New System.Drawing.Size(175, 16)
      Me.chkBancarizar.TabIndex = 15
      Me.chkBancarizar.TabStop = False
      Me.chkBancarizar.Text = "Bancarizar esta Factura"
      Me.chkBancarizar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label13.Location = New System.Drawing.Point(8, 11)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(85, 16)
      Me.Label13.TabIndex = 222
      Me.Label13.Text = "Observación"
      '
      'txtFacturaObs
      '
      Me.txtFacturaObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtFacturaObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFacturaObs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaObs.Location = New System.Drawing.Point(96, 7)
      Me.txtFacturaObs.MaxLength = 255
      Me.txtFacturaObs.Multiline = True
      Me.txtFacturaObs.Name = "txtFacturaObs"
      Me.txtFacturaObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtFacturaObs.Size = New System.Drawing.Size(232, 32)
      Me.txtFacturaObs.TabIndex = 13
      Me.txtFacturaObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'tabOtros
      '
      Me.tabOtros.Controls.Add(Me.txtFacturaOC)
      Me.tabOtros.Controls.Add(Me.txtFacturaNE)
      Me.tabOtros.Controls.Add(Me.txtFacturaPL)
      Me.tabOtros.Controls.Add(Me.txtFacturaTC)
      Me.tabOtros.Controls.Add(Me.Label22)
      Me.tabOtros.Controls.Add(Me.Label23)
      Me.tabOtros.Controls.Add(Me.Label24)
      Me.tabOtros.Controls.Add(Me.lblFacturaPL)
      Me.tabOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabOtros.Key = "Otros"
      Me.tabOtros.Location = New System.Drawing.Point(1, 20)
      Me.tabOtros.Name = "tabOtros"
      Me.tabOtros.Size = New System.Drawing.Size(334, 89)
      Me.tabOtros.TabStop = True
      Me.tabOtros.Text = "Otros"
      '
      'txtFacturaOC
      '
      Me.txtFacturaOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFacturaOC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaOC.Location = New System.Drawing.Point(64, 56)
      Me.txtFacturaOC.MaxLength = 50
      Me.txtFacturaOC.Name = "txtFacturaOC"
      Me.txtFacturaOC.Size = New System.Drawing.Size(96, 20)
      Me.txtFacturaOC.TabIndex = 19
      Me.txtFacturaOC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaOC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtFacturaNE
      '
      Me.txtFacturaNE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFacturaNE.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaNE.Location = New System.Drawing.Point(64, 32)
      Me.txtFacturaNE.MaxLength = 50
      Me.txtFacturaNE.Name = "txtFacturaNE"
      Me.txtFacturaNE.Size = New System.Drawing.Size(96, 20)
      Me.txtFacturaNE.TabIndex = 18
      Me.txtFacturaNE.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaNE.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtFacturaPL
      '
      Me.txtFacturaPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFacturaPL.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaPL.Location = New System.Drawing.Point(64, 8)
      Me.txtFacturaPL.MaxLength = 50
      Me.txtFacturaPL.Name = "txtFacturaPL"
      Me.txtFacturaPL.Size = New System.Drawing.Size(96, 20)
      Me.txtFacturaPL.TabIndex = 17
      Me.txtFacturaPL.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaPL.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtFacturaTC
      '
      Me.txtFacturaTC.BackColor = System.Drawing.SystemColors.Info
      Me.txtFacturaTC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaTC.FormatString = "##,##0.000"
      Me.txtFacturaTC.Location = New System.Drawing.Point(236, 8)
      Me.txtFacturaTC.Name = "txtFacturaTC"
      Me.txtFacturaTC.ReadOnly = True
      Me.txtFacturaTC.Size = New System.Drawing.Size(92, 20)
      Me.txtFacturaTC.TabIndex = 20
      Me.txtFacturaTC.TabStop = False
      Me.txtFacturaTC.Text = "0,000"
      Me.txtFacturaTC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtFacturaTC.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtFacturaTC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label22.Location = New System.Drawing.Point(12, 60)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(52, 16)
      Me.Label22.TabIndex = 233
      Me.Label22.Text = "O. C."
      '
      'Label23
      '
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label23.Location = New System.Drawing.Point(180, 11)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(56, 16)
      Me.Label23.TabIndex = 231
      Me.Label23.Text = "T. C."
      Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label24
      '
      Me.Label24.BackColor = System.Drawing.Color.Transparent
      Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label24.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label24.Location = New System.Drawing.Point(9, 36)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(52, 16)
      Me.Label24.TabIndex = 229
      Me.Label24.Text = "N.E"
      '
      'lblFacturaPL
      '
      Me.lblFacturaPL.BackColor = System.Drawing.Color.Transparent
      Me.lblFacturaPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblFacturaPL.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblFacturaPL.Location = New System.Drawing.Point(8, 12)
      Me.lblFacturaPL.Name = "lblFacturaPL"
      Me.lblFacturaPL.Size = New System.Drawing.Size(56, 16)
      Me.lblFacturaPL.TabIndex = 227
      Me.lblFacturaPL.Text = "P.L."
      Me.lblFacturaPL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'tabDescuento
      '
      Me.tabDescuento.Controls.Add(Me.txtMontoDes)
      Me.tabDescuento.Controls.Add(Me.Label26)
      Me.tabDescuento.Controls.Add(Me.cboPlanDescuento)
      Me.tabDescuento.Enabled = False
      Me.tabDescuento.Key = "Descuento"
      Me.tabDescuento.Location = New System.Drawing.Point(1, 20)
      Me.tabDescuento.Name = "tabDescuento"
      Me.tabDescuento.Size = New System.Drawing.Size(334, 87)
      Me.tabDescuento.TabStop = True
      Me.tabDescuento.Text = "Descuento"
      '
      'txtMontoDes
      '
      Me.txtMontoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoDes.FormatString = "##,##0.000"
      Me.txtMontoDes.Location = New System.Drawing.Point(252, 12)
      Me.txtMontoDes.Name = "txtMontoDes"
      Me.txtMontoDes.Size = New System.Drawing.Size(76, 20)
      Me.txtMontoDes.TabIndex = 288
      Me.txtMontoDes.Text = "0,000"
      Me.txtMontoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoDes.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label26
      '
      Me.Label26.BackColor = System.Drawing.Color.Transparent
      Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label26.Location = New System.Drawing.Point(4, 16)
      Me.Label26.Name = "Label26"
      Me.Label26.Size = New System.Drawing.Size(72, 16)
      Me.Label26.TabIndex = 287
      Me.Label26.Text = "Descuento"
      '
      'cboPlanDescuento
      '
      Me.cboPlanDescuento.DropListFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanDescuento.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanDescuento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanDescuento.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanDescuento.Location = New System.Drawing.Point(80, 13)
      Me.cboPlanDescuento.Name = "cboPlanDescuento"
      Me.cboPlanDescuento.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanDescuento.Size = New System.Drawing.Size(156, 20)
      Me.cboPlanDescuento.TabIndex = 286
      Me.cboPlanDescuento.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.tabMain.Location = New System.Drawing.Point(4, 120)
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(762, 230)
      Me.tabMain.TabIndex = 14
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabCompras})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'tabCompras
      '
      Me.tabCompras.Controls.Add(Me.ebrMain)
      Me.tabCompras.Key = "General"
      Me.tabCompras.Location = New System.Drawing.Point(1, 21)
      Me.tabCompras.Name = "tabCompras"
      Me.tabCompras.Size = New System.Drawing.Size(760, 208)
      Me.tabCompras.TabStop = True
      Me.tabCompras.Text = "Compras"
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup2.Container = True
      ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup2.ContainerHeight = 168
      ExplorerBarGroup2.Expandable = False
      ExplorerBarGroup2.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 4)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(750, 200)
      Me.ebrMain.TabIndex = 13
      Me.ebrMain.TabStop = False
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'grpCompra
      '
      Me.grpCompra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpCompra.BackColor = System.Drawing.Color.WhiteSmoke
      Me.grpCompra.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpCompra.Controls.Add(Me.txtMontoPorFacSus)
      Me.grpCompra.Controls.Add(Me.txtMontoBruSus)
      Me.grpCompra.Controls.Add(Me.txtMontoPorFacBs)
      Me.grpCompra.Controls.Add(Me.cboProveedor)
      Me.grpCompra.Controls.Add(Me.Label12)
      Me.grpCompra.Controls.Add(Me.txtMontoBruBs)
      Me.grpCompra.Controls.Add(Me.Label2)
      Me.grpCompra.Controls.Add(Me.Label11)
      Me.grpCompra.Controls.Add(Me.txtTipoCambio)
      Me.grpCompra.Controls.Add(Me.Label1)
      Me.grpCompra.Controls.Add(Me.chkProveedor)
      Me.grpCompra.Controls.Add(Me.Label10)
      Me.grpCompra.Controls.Add(Me.Label9)
      Me.grpCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpCompra.Location = New System.Drawing.Point(432, 0)
      Me.grpCompra.Name = "grpCompra"
      Me.grpCompra.Size = New System.Drawing.Size(333, 116)
      Me.grpCompra.TabIndex = 9
      Me.grpCompra.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtMontoPorFacSus
      '
      Me.txtMontoPorFacSus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoPorFacSus.BackColor = System.Drawing.Color.LightPink
      Me.txtMontoPorFacSus.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPorFacSus.FormatString = "##,##0.000"
      Me.txtMontoPorFacSus.Location = New System.Drawing.Point(242, 64)
      Me.txtMontoPorFacSus.Name = "txtMontoPorFacSus"
      Me.txtMontoPorFacSus.ReadOnly = True
      Me.txtMontoPorFacSus.Size = New System.Drawing.Size(84, 20)
      Me.txtMontoPorFacSus.TabIndex = 369
      Me.txtMontoPorFacSus.TabStop = False
      Me.txtMontoPorFacSus.Text = "0,000"
      Me.txtMontoPorFacSus.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPorFacSus.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPorFacSus.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMontoBruSus
      '
      Me.txtMontoBruSus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoBruSus.BackColor = System.Drawing.Color.MistyRose
      Me.txtMontoBruSus.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoBruSus.FormatString = "##,##0.000"
      Me.txtMontoBruSus.Location = New System.Drawing.Point(76, 64)
      Me.txtMontoBruSus.Name = "txtMontoBruSus"
      Me.txtMontoBruSus.ReadOnly = True
      Me.txtMontoBruSus.Size = New System.Drawing.Size(84, 20)
      Me.txtMontoBruSus.TabIndex = 368
      Me.txtMontoBruSus.TabStop = False
      Me.txtMontoBruSus.Text = "0,000"
      Me.txtMontoBruSus.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoBruSus.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoBruSus.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMontoPorFacBs
      '
      Me.txtMontoPorFacBs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoPorFacBs.BackColor = System.Drawing.Color.LightPink
      Me.txtMontoPorFacBs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPorFacBs.FormatString = "##,##0.000"
      Me.txtMontoPorFacBs.Location = New System.Drawing.Point(242, 88)
      Me.txtMontoPorFacBs.Name = "txtMontoPorFacBs"
      Me.txtMontoPorFacBs.ReadOnly = True
      Me.txtMontoPorFacBs.Size = New System.Drawing.Size(84, 20)
      Me.txtMontoPorFacBs.TabIndex = 16
      Me.txtMontoPorFacBs.TabStop = False
      Me.txtMontoPorFacBs.Text = "0,000"
      Me.txtMontoPorFacBs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPorFacBs.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPorFacBs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboProveedor
      '
      Me.cboProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboProveedor.BackColor = System.Drawing.SystemColors.Info
      cboProveedor_DesignTimeLayout.LayoutString = resources.GetString("cboProveedor_DesignTimeLayout.LayoutString")
      Me.cboProveedor.DesignTimeLayout = cboProveedor_DesignTimeLayout
      Me.cboProveedor.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProveedor.Location = New System.Drawing.Point(76, 12)
      Me.cboProveedor.Name = "cboProveedor"
      Me.cboProveedor.ReadOnly = True
      Me.cboProveedor.SelectedIndex = -1
      Me.cboProveedor.SelectedItem = Nothing
      Me.cboProveedor.Size = New System.Drawing.Size(248, 20)
      Me.cboProveedor.TabIndex = 10
      Me.cboProveedor.TabStop = False
      Me.cboProveedor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboProveedor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(168, 91)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(72, 16)
      Me.Label12.TabIndex = 367
      Me.Label12.Text = "Factura Bs."
      '
      'txtMontoBruBs
      '
      Me.txtMontoBruBs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoBruBs.BackColor = System.Drawing.Color.MistyRose
      Me.txtMontoBruBs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoBruBs.FormatString = "##,##0.000"
      Me.txtMontoBruBs.Location = New System.Drawing.Point(76, 88)
      Me.txtMontoBruBs.Name = "txtMontoBruBs"
      Me.txtMontoBruBs.ReadOnly = True
      Me.txtMontoBruBs.Size = New System.Drawing.Size(84, 20)
      Me.txtMontoBruBs.TabIndex = 15
      Me.txtMontoBruBs.TabStop = False
      Me.txtMontoBruBs.Text = "0,000"
      Me.txtMontoBruBs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoBruBs.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoBruBs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(4, 91)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(76, 16)
      Me.Label2.TabIndex = 365
      Me.Label2.Text = "M. Bruto Bs."
      '
      'Label11
      '
      Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(4, 40)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(36, 16)
      Me.Label11.TabIndex = 327
      Me.Label11.Text = "T.C."
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTipoCambio.BackColor = System.Drawing.SystemColors.Info
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(76, 38)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.ReadOnly = True
      Me.txtTipoCambio.Size = New System.Drawing.Size(84, 20)
      Me.txtTipoCambio.TabIndex = 14
      Me.txtTipoCambio.TabStop = False
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label1.Location = New System.Drawing.Point(4, 65)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(76, 16)
      Me.Label1.TabIndex = 363
      Me.Label1.Text = "M. Bruto Sus."
      '
      'chkProveedor
      '
      Me.chkProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkProveedor.BackColor = System.Drawing.Color.Transparent
      Me.chkProveedor.Checked = True
      Me.chkProveedor.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkProveedor.Location = New System.Drawing.Point(60, 16)
      Me.chkProveedor.Name = "chkProveedor"
      Me.chkProveedor.Size = New System.Drawing.Size(16, 16)
      Me.chkProveedor.TabIndex = 4
      Me.chkProveedor.TabStop = False
      Me.chkProveedor.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label10.Location = New System.Drawing.Point(168, 65)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(76, 16)
      Me.Label10.TabIndex = 325
      Me.Label10.Text = "Factura Sus."
      '
      'Label9
      '
      Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(4, 16)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(52, 16)
      Me.Label9.TabIndex = 359
      Me.Label9.Text = "Proveedor"
      '
      'grpMain
      '
      Me.grpMain.BackColor = System.Drawing.Color.WhiteSmoke
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtFacturaId)
      Me.grpMain.Controls.Add(Me.Label21)
      Me.grpMain.Controls.Add(Me.cboNroRUC)
      Me.grpMain.Controls.Add(Me.txtCodControl)
      Me.grpMain.Controls.Add(Me.txtNroAutorizacion)
      Me.grpMain.Controls.Add(Me.cboRegRUC)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.txtFacturaNro)
      Me.grpMain.Controls.Add(Me.dtpFacturaFecha)
      Me.grpMain.Controls.Add(Me.Label14)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.Label19)
      Me.grpMain.Controls.Add(Me.Label20)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(4, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(424, 116)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtFacturaId
      '
      Me.txtFacturaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaId.Location = New System.Drawing.Point(64, 12)
      Me.txtFacturaId.Name = "txtFacturaId"
      Me.txtFacturaId.ReadOnly = True
      Me.txtFacturaId.Size = New System.Drawing.Size(96, 20)
      Me.txtFacturaId.TabIndex = 1
      Me.txtFacturaId.TabStop = False
      Me.txtFacturaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label21
      '
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label21.Location = New System.Drawing.Point(4, 16)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(56, 16)
      Me.Label21.TabIndex = 214
      Me.Label21.Text = "ID"
      '
      'cboNroRUC
      '
      cboNroRUC_DesignTimeLayout.LayoutString = resources.GetString("cboNroRUC_DesignTimeLayout.LayoutString")
      Me.cboNroRUC.DesignTimeLayout = cboNroRUC_DesignTimeLayout
      Me.cboNroRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboNroRUC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboNroRUC.Location = New System.Drawing.Point(252, 12)
      Me.cboNroRUC.MaxLength = 12
      Me.cboNroRUC.Name = "cboNroRUC"
      Me.cboNroRUC.SelectedIndex = -1
      Me.cboNroRUC.SelectedItem = Nothing
      Me.cboNroRUC.Size = New System.Drawing.Size(108, 20)
      Me.cboNroRUC.TabIndex = 5
      Me.cboNroRUC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboNroRUC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCodControl
      '
      Me.txtCodControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCodControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.txtCodControl.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCodControl.Location = New System.Drawing.Point(252, 89)
      Me.txtCodControl.Mask = "&&-&&-&&-&&-&&"
      Me.txtCodControl.Name = "txtCodControl"
      Me.txtCodControl.Size = New System.Drawing.Size(108, 20)
      Me.txtCodControl.TabIndex = 8
      Me.txtCodControl.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCodControl.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNroAutorizacion
      '
      Me.txtNroAutorizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtNroAutorizacion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroAutorizacion.FormatString = "###############0"
      Me.txtNroAutorizacion.Location = New System.Drawing.Point(252, 64)
      Me.txtNroAutorizacion.MaxLength = 15
      Me.txtNroAutorizacion.Name = "txtNroAutorizacion"
      Me.txtNroAutorizacion.Size = New System.Drawing.Size(108, 20)
      Me.txtNroAutorizacion.TabIndex = 7
      Me.txtNroAutorizacion.Text = "0"
      Me.txtNroAutorizacion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroAutorizacion.Value = CType(0, Long)
      Me.txtNroAutorizacion.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtNroAutorizacion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboRegRUC
      '
      Me.cboRegRUC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      cboRegRUC_DesignTimeLayout.LayoutString = resources.GetString("cboRegRUC_DesignTimeLayout.LayoutString")
      Me.cboRegRUC.DesignTimeLayout = cboRegRUC_DesignTimeLayout
      Me.cboRegRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboRegRUC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboRegRUC.Location = New System.Drawing.Point(252, 40)
      Me.cboRegRUC.Name = "cboRegRUC"
      Me.cboRegRUC.SelectedIndex = -1
      Me.cboRegRUC.SelectedItem = Nothing
      Me.cboRegRUC.Size = New System.Drawing.Size(168, 20)
      Me.cboRegRUC.TabIndex = 6
      Me.cboRegRUC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboRegRUC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(64, 38)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.ReadOnly = True
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(96, 20)
      Me.cboEstado.TabIndex = 2
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtFacturaNro
      '
      Me.txtFacturaNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaNro.FormatString = "##################"
      Me.txtFacturaNro.Location = New System.Drawing.Point(64, 90)
      Me.txtFacturaNro.MaxLength = 18
      Me.txtFacturaNro.Name = "txtFacturaNro"
      Me.txtFacturaNro.Size = New System.Drawing.Size(96, 20)
      Me.txtFacturaNro.TabIndex = 4
      Me.txtFacturaNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaNro.Value = CType(0, Long)
      Me.txtFacturaNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtFacturaNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'dtpFacturaFecha
      '
      Me.dtpFacturaFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFacturaFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFacturaFecha.DropDownCalendar.FirstMonth = New Date(2008, 1, 1, 0, 0, 0, 0)
      Me.dtpFacturaFecha.DropDownCalendar.Name = ""
      Me.dtpFacturaFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFacturaFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dtpFacturaFecha.Location = New System.Drawing.Point(64, 64)
      Me.dtpFacturaFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFacturaFecha.Name = "dtpFacturaFecha"
      Me.dtpFacturaFecha.ReadOnly = True
      Me.dtpFacturaFecha.Size = New System.Drawing.Size(96, 20)
      Me.dtpFacturaFecha.TabIndex = 3
      Me.dtpFacturaFecha.TabStop = False
      Me.dtpFacturaFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label14.Location = New System.Drawing.Point(4, 42)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(48, 16)
      Me.Label14.TabIndex = 203
      Me.Label14.Text = "Estado"
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label15.Location = New System.Drawing.Point(4, 94)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(52, 16)
      Me.Label15.TabIndex = 202
      Me.Label15.Text = "Número"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label16.Location = New System.Drawing.Point(4, 68)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(56, 16)
      Me.Label16.TabIndex = 201
      Me.Label16.Text = "Fecha"
      '
      'Label17
      '
      Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label17.Location = New System.Drawing.Point(168, 68)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(76, 16)
      Me.Label17.TabIndex = 200
      Me.Label17.Text = "Nro Autoriz."
      '
      'Label18
      '
      Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label18.Location = New System.Drawing.Point(168, 93)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(80, 16)
      Me.Label18.TabIndex = 199
      Me.Label18.Text = "Cod. Control"
      '
      'Label19
      '
      Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label19.Location = New System.Drawing.Point(168, 43)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(84, 16)
      Me.Label19.TabIndex = 198
      Me.Label19.Text = "Razón Social"
      '
      'Label20
      '
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label20.Location = New System.Drawing.Point(168, 16)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(76, 16)
      Me.Label20.TabIndex = 197
      Me.Label20.Text = "Número NIT"
      '
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Delete
      '
      Me.Delete.ImageIndex = 2
      Me.Delete.Key = "Delete"
      Me.Delete.Name = "Delete"
      Me.Delete.Text = "Eliminar"
      '
      'BottomRebar1
      '
      Me.BottomRebar1.CommandManager = Me.cdmMain
      Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.BottomRebar1.Location = New System.Drawing.Point(0, 475)
      Me.BottomRebar1.Name = "BottomRebar1"
      Me.BottomRebar1.Size = New System.Drawing.Size(759, 0)
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Exit3, Me.Save})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("55df5f76-479b-4f4e-8e69-68c99cb73b74")
      Me.cdmMain.ImageList = Me.ilsMain
      Me.cdmMain.LeftRebar = Me.LeftRebar1
      Me.cdmMain.RightRebar = Me.RightRebar1
      Me.cdmMain.TopRebar = Me.TopRebar1
      Me.cdmMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'UiCommandBar1
      '
      Me.UiCommandBar1.CommandManager = Me.cdmMain
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(155, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.ImageIndex = 1
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Exit3
      '
      Me.Exit3.ImageIndex = 5
      Me.Exit3.Key = "Exit"
      Me.Exit3.Name = "Exit3"
      Me.Exit3.Text = "Salir"
      '
      'Save
      '
      Me.Save.ImageIndex = 1
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.Text = "Guardar"
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
      Me.ilsMain.Images.SetKeyName(7, "")
      Me.ilsMain.Images.SetKeyName(8, "Compras.ico")
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 28)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 447)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(759, 28)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 447)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(770, 28)
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'mnuFacturaDet
      '
      Me.mnuFacturaDet.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowFacturaDet, Me.mnuEditFacturaDet})
      '
      'mnuShowFacturaDet
      '
      Me.mnuShowFacturaDet.Index = 0
      Me.mnuShowFacturaDet.Text = "Consultar"
      '
      'mnuEditFacturaDet
      '
      Me.mnuEditFacturaDet.Index = 1
      Me.mnuEditFacturaDet.Text = "Editar"
      '
      'frmFacturaDifMultipleDetEdit
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(770, 494)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmFacturaDifMultipleDetEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Nueva Factura"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.tabFac, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabFac.ResumeLayout(False)
      Me.tabObservacion.ResumeLayout(False)
      Me.tabObservacion.PerformLayout()
      Me.tabOtros.ResumeLayout(False)
      Me.tabOtros.PerformLayout()
      Me.tabDescuento.ResumeLayout(False)
      Me.tabDescuento.PerformLayout()
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabMain.ResumeLayout(False)
      Me.tabCompras.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.grpCompra, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpCompra.ResumeLayout(False)
      Me.grpCompra.PerformLayout()
      CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboNroRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboRegRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents Exit3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboNroRUC As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents txtCodControl As Janus.Windows.GridEX.EditControls.MaskedEditBox
   Friend WithEvents txtNroAutorizacion As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboRegRUC As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtFacturaNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents dtpFacturaFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key

         Case "Save"
            If DataSave() Then
               mlngID = moFactura.FacturaId
               mboolChanged = True

               MessageBox.Show("Factura Guardada Exitosamente" + vbCrLf, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Me.Close()
            End If

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor

   End Sub

   Private Sub frmFacturaDifMultipleDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)

   End Sub

   Private Sub frmFacturaDifMultipleDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call ComboLoad()

      If Not mboolAdding Then
         Call FormShow()
         Call DataReadOnly()
         Me.Text = "Consulta Factura Diferida"
      Else
         Me.Text = "Nueva Factura Diferida"
         Call FormNew()
      End If

      ''mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      ''mboolShow = True
      With moFactura
         txtFacturaId.Text = ToStr(.FacturaId)
         txtFacturaNro.Text = ToStr(.FacturaNro)
         dtpFacturaFecha.Text = ToStr(.FacturaFecha)
         cboRegRUC.Tag = ToStr(.RegRUCDes)
         cboRegRUC.Text = ToStr(.RegRUCDes)
         cboNroRUC.Tag = ToStr(.NroRUC)
         cboNroRUC.Text = ToStr(.NroRUC)
         txtNroAutorizacion.Text = ToStr(.NroAutorizacion)
         txtCodControl.Text = ToStr(.CodControl)

         txtFacturaNro.Text = ToStr(.FacturaNro)
         txtFacturaMonto.Text = ToDecStr(.FacturaMonto)
         txtIceIehd.Text = ToDecStr(.IceIehd)
         txtExento.Text = ToDecStr(.Exento)
         txtNeto.Text = ToDecStr(.FacturaMonto - (.Exento + .IceIehd))
         txtIVA.Text = ToDecStr(.IVA)
         txtImporteIVA.Text = ToDecStr(.FacturaMonto - .IVA)
         txtFacturaObs.Text = ToStr(.FacturaObs)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         cboEstado.ReadOnly = True

         chkBancarizar.Checked = .Bancarizar
         CompraFacLoad(.FacturaId, .FacturaMonto)

         txtFacturaNro.Select()
         Call grdMainLoad()
         Call MontoPagarFactura()

      End With
      ''mboolShow = False
   End Sub

   Private Sub DataClear()
      ''mboolShow = True
      With moFactura
         txtFacturaId.Text = String.Empty
         dtpFacturaFecha.Text = ToStr(.FacturaFecha)
         dtpFacturaFecha.Tag = dtpFacturaFecha.Text
         cboRegRUC.Value = Nothing
         cboRegRUC.Tag = Nothing
         cboNroRUC.Value = Nothing
         cboNroRUC.Tag = Nothing

         If moFactura.TipoFacturaId = 1 Then 'Compra
            txtNroAutorizacion.ReadOnly = True
         Else 'Compra
            txtNroAutorizacion.Text = String.Empty
         End If

         txtCodControl.Text = String.Empty
         txtFacturaNro.Text = ToStr(.FacturaNro)
         txtFacturaMonto.Text = ToDecStr(.FacturaMonto)
         txtIceIehd.Text = "0"
         txtExento.Text = "0"
         txtNeto.Text = ToDecStr(.FacturaMonto)
         txtIVA.Text = ToDecStr(.FacturaMonto * clsAppInfo.IVA)
         txtImporteIVA.Text = ToDecStr(.FacturaMonto - (.FacturaMonto * clsAppInfo.IVA))
         txtFacturaObs.Text = String.Empty

         cboTipoFacCompra.SelectedIndex = -1
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)

         If .FacturaMonto >= 50000 Then
            chkBancarizar.Checked = True
         Else
            chkBancarizar.Checked = False
         End If

         mdecMontoFacOrig = .FacturaMonto
         cboProveedor.Value = ListFindItem(cboProveedor, mlngProveedorId)
         txtTipoCambio.Text = mdecTipoCambio
         ''Call CompraLoad(mlngCompraId)

         txtFacturaTC.Text = mdecTipoCambio
         txtFacturaPL.Text = String.Empty
         txtFacturaNE.Text = String.Empty
         txtFacturaOC.Text = String.Empty

         cboPlanDescuento.SelectedIndex = -1

         Call grdMainLoad()

         mboolEditarPrecio = True
         If (mdecMontoFacturado = 0) And (mdecExentoFacturado = 0) Then
            chkFacturaNoValida.Enabled = True
         End If
      End With
      ''mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      dtpFacturaFecha.ReadOnly = True
      cboRegRUC.ReadOnly = True
      cboNroRUC.ReadOnly = True
      txtFacturaNro.ReadOnly = True
      txtFacturaObs.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtNroAutorizacion.ReadOnly = True
      txtCodControl.ReadOnly = True

      cboTipoFacCompra.ReadOnly = True
      cboEstado.ReadOnly = True

      chkBancarizar.Enabled = False
      txtFacturaTC.ReadOnly = True
      txtFacturaPL.ReadOnly = True
      txtFacturaNE.ReadOnly = True
      txtFacturaOC.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtFacturaNro.Select()
   End Sub

   Private Sub DataMove()
      With moFactura
         If Not mboolAdding Then
            .FacturaId = ToLong(txtFacturaId.Text)
         End If

         .MesId = dtpFacturaFecha.Value.Month
         .FacturaFecha = ToDate(dtpFacturaFecha.Value)
         .FacturaNro = ToLong(txtFacturaNro.Text)
         .FacturaMonto = ToDecimalDos(txtFacturaMonto.Text)

         If ListPosition(cboNroRUC) > 0 Then
            .RegRUCId = ListPosition(cboNroRUC)
            If RegRucIdFind(ListPosition(cboNroRUC)) = 0 Then
               .RegRUCId = 0
            End If

         ElseIf ListPosition(cboRegRUC) > 0 Then
            .RegRUCId = ListPosition(cboRegRUC)

            If RegRucIdFind(ListPosition(cboRegRUC)) = 0 Then
               .RegRUCId = 0
            End If

         Else
            .RegRUCId = 0
         End If

         .RegRUCDes = ToStr(cboRegRUC.Text)
         .NroRUC = ToStr(cboNroRUC.Text)
         .NroAutorizacion = ToStr(txtNroAutorizacion.Text)

         .IVA = ToDecimalDos(txtIVA.Text)
         .IceIehd = ToDecimalDos(txtIceIehd.Text)
         .Exento = ToDecimalDos(txtExento.Text)
         .Descuento = ToDecimalDos(txtDescuento.Text)
         .FacturaObs = ToStr(txtFacturaObs.Text)
         .Bancarizar = ToBoolean(chkBancarizar.Checked)
         .TipoFacCompraId = ListPosition(cboTipoFacCompra, cboTipoFacCompra.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

         .CodControl = ToStr(txtCodControl.Text)
         Do While (Microsoft.VisualBasic.Right(.CodControl, 1) = "-") And (.CodControl.Length > 2)
            .CodControl = Microsoft.VisualBasic.Left(.CodControl, .CodControl.Length - 1)
         Loop

         mdecMontoFac = ToDecimal(txtMontoPorFacBs.Text)

         '.TipoCambio = ToDecimalDos(txtFacturaTC.Text)
         '.FacturaPL = ToStr(txtFacturaPL.Text)
         '.FacturaNE = ToStr(txtFacturaNE.Text)
         '.FacturaOC = ToStr(txtFacturaOC.Text)

         .AppId = clsAppInfo.AppId
         .TipoDocumentoId = 0
         .DocumentoId = moFactura.FacturaId

      End With
   End Sub

   Private Function RegRUCAdd() As Boolean
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.RegRUC
            .EmpresaId = moFactura.EmpresaId
            .NroRUC = moFactura.NroRUC
            '.RegRUCDes = moFactura.RegRUCDes

            If Not .Find Then
               .EmpresaId = moFactura.EmpresaId
               .NroRUC = moFactura.NroRUC
               .RegRUCDes = moFactura.RegRUCDes
               .NroAutorizacion = moFactura.NroAutorizacion
               .PlanId = 0

               If moFactura.TipoFacturaId = 1 Then 'Compras
                  .NroAutorizacion = "0"
               Else
                  .NroAutorizacion = moFactura.NroAutorizacion
               End If

               If .Insert Then
                  RegRUCAdd = True
               End If

            Else
               RegRUCAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Function DataSave() As Boolean
      Try
         txtFacturaNro.Select()
         Call DataMove()

         If mboolAdding Then
            If Not (chkFacturaNoValida.Checked) Then  ''Factura Normal 
               DataSave = DataAdd()
            Else
               DataSave = DataAddNoValida()
            End If


         Else
            DataSave = DataUpdate()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Dim lngTipoCompId As Long
      Dim lngCompId As Long

      Try
         Dim CompraFacId As Long
         DataAdd = False

         If CompraDetCheck() Then
            If FormCheck() Then
               If MessageBox.Show("¿Realmente Quiere Guardar la Facturación Diferida?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                  If moFactura.Insert() Then
                     If moFactura.RegRUCId = 0 Then
                        Call RegRUCAdd()
                     Else
                        If mstrNroAutorizacion <> (txtNroAutorizacion.Text).Trim Then
                           RegRUCUpdate()
                        End If
                     End If

                     If CompraFacSave() Then
                        If CompNew(lngTipoCompId, lngCompId) Then
                           If DataUpdate() Then
                              DataAdd = True
                           End If
                        End If
                     End If
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function frmCompPlanFill() As Boolean
      Dim frm As New frmCompPlan
      Dim strPlanDes As String = ""
      Dim lngMonedaIdPlan As Long = 0

      frmCompPlanFill = False

      mlngPlanId = 0
      mlngPlanAddId = 0
      mlngSucursalId = 0
      If Not clsAppInfo.CentroCostoApli Then
         mlngCentroCostoId = 0
      End If
      mlngCentroCostoDetId = 0
      mlngTipoPlanId = 0

      mlngSucursalId = moFactura.SucursalIdOrg

      With frm
         .EmpresaId = moFactura.EmpresaId
         .PlanWhereFilter = clsPlan.WhereFilters.EsAna
         ''.chkTieneComp.Visible = True
         ''.Editing = False
         ''.NewRecord = True
         .ShowDialog()

         If .Changed Then
            mlngPlanId = frm.PlanId
            mlngPlanAddId = frm.PlanAddId
            mlngSucursalId = frm.SucursalId
            mlngCentroCostoId = frm.CentroCostoId
            mlngCentroCostoDetId = frm.CentroCostoDetId
            mboolTieneComp = frm.TieneComp

            frmCompPlanFill = True
         End If
         frm.Dispose()
      End With

   End Function

   Private Function RegRUCUpdate() As Boolean
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC

            .RegRUCId = moFactura.RegRUCId

            If .FindByPK Then
               .NroAutorizacion = moFactura.NroAutorizacion

               If .Update() Then
                  RegRUCUpdate = True
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Function DataAddNoValida() As Boolean
      Dim lngTipoCompId As Long
      Dim lngCompId As Long

      Try
         Dim CompraFacId As Long
         DataAddNoValida = False

         If CompraDetCheck() Then
            If FormCheck() Then

               If MessageBox.Show("¿Realmente Quiere Guardar la Facturación Diferida?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                  If (moFactura.FacturaMonto - moFactura.Exento) > 0 Then ''Genera Comprobante

                     If frmCompPlanFill() Then  '' Va a ir a Contabilidad

                        If moFactura.Insert() Then
                           If moFactura.RegRUCId = 0 Then
                              Call RegRUCAdd()
                           Else
                              If mstrNroAutorizacion <> (txtNroAutorizacion.Text).Trim Then
                                 RegRUCUpdate()
                              End If
                           End If

                           If CompraFacSave() Then
                              If CompNewCompraFacNoValida() Then
                                 If DataUpdate() Then
                                    DataAddNoValida = True
                                 End If
                              End If
                           End If
                        End If
                     End If
                  Else

                     If moFactura.Insert() Then
                        If moFactura.RegRUCId = 0 Then
                           Call RegRUCAdd()
                        Else
                           If mstrNroAutorizacion <> (txtNroAutorizacion.Text).Trim Then
                              RegRUCUpdate()
                           End If
                        End If

                        If CompraFacSave() Then
                           DataAddNoValida = True
                           If DataUpdate() Then
                              DataAddNoValida = True
                           End If

                        End If
                     End If
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moFactura.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function CompraFacSave() As Boolean
      Dim oRow As DataRow
      mstrNroCompras = ""
      CompraFacSave = True

      Try

         For Each oRow In moDataTable.Rows
            If oRow("MontoFacturar") > 0 Then

               Call CompraFacMove(oRow)

               If moCompraFac.Insert() Then
                  mstrNroCompras = mstrNroCompras & ", " & oRow("CompraNro")

                  ''If CompraUpdate(oRow("CompraId"), oRow("MontoFacturar")) Then
                  If CompraUpdate(oRow("CompraId"), oRow("MontoFacturar")) Then
                     'If CompraFacDetSave(moCompraFac.CompraFacId, oRow("CompraId")) Then

                  End If
               End If

               moCompraFac.CloseConection()
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      Finally

      End Try
   End Function

   Private Sub CompraFacMove(ByRef oRow As DataRow)

      With moCompraFac
         .EmpresaId = moFactura.EmpresaId
         .GestionId = moFactura.GestionId
         .FacturaId = moFactura.FacturaId
         .CompraId = oRow("CompraId")
         .TipoCambio = mdecTipoCambio
         ''.MontoCompra = oRow("MontoFacturar")
         .MontoCompra = oRow("MontoFacturar")
         .MontoExento = oRow("MontoExentoAFac")
         .MontoFac = oRow("MontoFacturar")

      End With
   End Sub

   Private Function CompraUpdate(ByVal lngCompraId As Long, ByVal decMontoFac As Decimal) As Boolean
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      CompraUpdate = False

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .MontoFac = decMontoFac

               .UpdateFilter = clsCompra.UpdateFilters.MontoFac

               If .Update() Then
                  CompraUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function FacturaDetAdd(ByVal lngFacturaId As Long) As Boolean
      Dim oFacturaDet As New clsFacturaDet(clsAppInfo.ConnectString)

      Try
         With oFacturaDet
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .FacturaId = lngFacturaId

            For Each oRow In moCompraDetTable.Rows
               .MedidaId = ToLong(oRow("MedidaId"))
               .ItemId = ToLong(oRow("ItemId"))
               .Cantidad = ToDecimalDos(oRow("Cantidad"))

               .Precio = ToDouble(oRow("Precio"))

               If ToLong(oRow("MonedaId")) = clsMoneda.DOLARES Then
                  .Precio *= mdecTipoCambio
               End If

               .Importe = ToDecimalDos(.Cantidad * .Precio)
               .Precio = ToDecimalDos(.Precio)
               .EstadoId = clsEstado.ABIERTO

               If .Insert Then
                  FacturaDetAdd = True
               End If
            Next
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaDet.Dispose()
      End Try
   End Function

   Private Function CompNew(ByRef lngTipoCompId As Long, ByRef lngCompId As Long) As Boolean
      lngTipoCompId = 3
      Dim lngCompNro As Long
      Dim lngCompDetId As Long

      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal

      Dim decMontoIvaBs As Decimal
      Dim decMontoIvaUs As Decimal
      Dim decIvaBs As Decimal = 0
      Dim decIvaUs As Decimal = 0
      Dim decIvaOrg As Decimal = 0

      Dim decITBs As Decimal = 0
      Dim decITUs As Decimal = 0
      Dim decITOrg As Decimal = 0

      CompNew = False
      Try

         decMontoBs = ToDecimal(moFactura.FacturaMonto)
         decMontoUs = ToDecimal(decMontoBs / mdecTipoCambio)
         decMontoOrg = decMontoBs

         decIvaBs = ToDecimal(moFactura.IVA)
         decIvaUs = ToDecimal(decIvaBs / mdecTipoCambio)
         decIvaOrg = ToDecimal(moFactura.IVA)

         decMontoIvaBs = decMontoBs - decIvaBs
         decMontoIvaUs = decMontoUs - decIvaUs

         If decIvaOrg > 0 Then

            If CompAdd(mdecTipoCambio, "", decIvaBs, decIvaUs, lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante
               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreId, "", decIvaBs, decIvaUs, decIvaOrg, 1, moFactura.SucursalIdOrg, mlngCentroCostoId, , 1) Then
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreDifId, "", decIvaBs, decIvaUs, decIvaOrg, 2, moFactura.SucursalIdOrg, mlngCentroCostoId, , 1) Then

                     moFactura.TipoCompId = lngTipoCompId
                     moFactura.CompId = lngCompId
                     moFactura.CompDetId = lngCompDetId
                     CompNew = True
                  End If
               End If

            End If
         Else
            '' No va a generar Factura
            moFactura.TipoCompId = 0
            moFactura.CompId = 0
            moFactura.CompDetId = 0
            CompNew = True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompNewCompraFacNoValida() As Boolean
      Dim decTipoCambio As Decimal
      Dim lngTipoCompId As Long = 3
      Dim strDes As String
      Dim lngCompId As Long
      Dim lngCompNro As Long
      Dim lngCompDetId As Long

      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal

      Dim decMontoIvaBs As Decimal
      Dim decMontoIvaUs As Decimal
      Dim decIvaBs As Decimal = 0
      Dim decIvaUs As Decimal = 0
      Dim decIvaOrg As Decimal = 0

      CompNewCompraFacNoValida = False

      Try

         decMontoBs = ToDecimal(moFactura.FacturaMonto)
         decMontoUs = ToDecimal(decMontoBs / mdecTipoCambio)
         decMontoOrg = decMontoBs

         decIvaBs = ToDecimal(moFactura.IVA)
         decIvaUs = ToDecimal(decIvaBs / mdecTipoCambio)
         decIvaOrg = ToDecimal(moFactura.IVA)

         decMontoIvaBs = decMontoBs - decIvaBs
         decMontoIvaUs = decMontoUs - decIvaUs

         If CompAdd(mdecTipoCambio, "; con Factura Diferida NO VÀLIDA", decIvaBs, decIvaUs, lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante
            If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "; con Factura Diferida NO VÀLIDA", decIvaBs, decIvaUs, decIvaOrg, 1, mlngSucursalId, mlngCentroCostoId, lngCompDetId, ) Then

               If mlngPlanAddId <> 0 Then  'Analitico Adicional
                  If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decIvaBs, decIvaUs, 1, moFactura.SucursalIdOrg) Then
                     CompNewCompraFacNoValida = True
                  End If
               End If

               If mlngCentroCostoDetId <> 0 Then  'Actividad
                  If CompCentroCostoDetAdd(lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, decIvaBs, decIvaUs, 1, moFactura.SucursalIdOrg) Then
                     CompNewCompraFacNoValida = True
                  End If
               End If

               ''Cuenta contra Cuenta
               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreDifId, "", decIvaBs, decIvaUs, decIvaOrg, 2, moFactura.SucursalIdOrg, mlngCentroCostoId, , 1) Then

                  moFactura.TipoCompId = lngTipoCompId
                  moFactura.CompId = lngCompId
                  moFactura.CompDetId = lngCompDetId
                  CompNewCompraFacNoValida = True

               End If

            End If

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompAdd(ByVal decTipoCambio As Decimal, ByVal strDes As String, ByVal decMontoBs As Decimal, ByVal decMontoUs As Decimal, _
                        ByVal lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = CompNroNext(.TipoCompId, moFactura.EmpresaId, moFactura.GestionId, moFactura.SucursalIdOrg, dtpFacturaFecha.Value)
            .Fecha = moFactura.FacturaFecha
            .MonedaId = 1
            .TipoCambio = decTipoCambio
            .EntregadoA = moFactura.RegRUCDes
            .PorConcepto = "Factura Nro. " & moFactura.FacturaNro & "; Factura Diferida de Compra(s) " & ToStr(mstrNroCompras) & strDes
            .DebeBs = decMontoBs
            .HaberBs = decMontoBs
            .DebeUs = decMontoUs
            .HaberUs = decMontoUs
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF

            If clsAppInfo.MultipleNro Then
               .SinFac = 1
               .ConFac = 1
            Else
               .SinFac = 1
               .ConFac = 0
            End If

            .Automatico = 0
            .Glosa = ""
            .TipoAsientoId = 0
            .EstadoId = 10

            .SucursalId = moFactura.SucursalIdOrg
            .NotaId = 0
            .AppId = clsAppInfo.AppId
            .DocumentoId = moFactura.FacturaId

            If .Insert() Then
               lngCompId = .CompId
               lngCompNro = .CompNro

               CompAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompDetAdd(ByVal lngTipoCompId As Long, ByVal lngCompId As Long, ByVal lngPlanId As Long, _
                             ByVal strDes As String, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, _
                             ByVal decValorOrg As Decimal, ByVal lngCol As Long, Optional ByVal lngSucursalId As Long = 0, _
                             Optional ByVal lngCentroCostoId As Long = 0, Optional ByRef lngCompDetId As Long = 0, _
                             Optional ByVal bytAutomatico As Byte = 0) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim lngSucCCOId As Long

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = moFactura.FacturaFecha
            .PlanId = lngPlanId
            .CompDetDes = "Factura Nro. " & moFactura.FacturaNro & strDes
            .MonedaId = 1

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorOrg
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorOrg
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeBs = 0
                  .DebeUs = 0
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorOrg
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorOrg
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeUs = 0
                  .DebeBs = 0
               End If
            End If

            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId

            .Orden = 0
            .Automatico = bytAutomatico
            .TipoRetencionId = 0
            .EstadoId = 10

            If .Insert() Then
               lngCompDetId = .CompDetId
               CompDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
                          ByVal lngPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAdd = False

      Try
         With oCompPlanAdd
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moFactura.FacturaFecha
            .PlanId = lngPlanId
            .MonedaId = 1
            .PlanAddId = lngPlanAddId
            .SucursalId = lngSucursalId
            .EstadoId = 10

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorBs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorUs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If
            End If

            .EstadoId = 10

            If .Insert() Then
               CompPlanAddAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngCentroCostoId As Long, _
                               ByVal lngCentroCostoDetId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompCentroCostoDetAdd = False

      Try
         With oCompCentroCostoDet
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moFactura.FacturaFecha
            .PlanId = lngPlanId
            .MonedaId = 1
            .CentroCostoId = lngCentroCostoId
            .CentroCostoDetId = lngCentroCostoDetId
            .SucursalId = lngSucursalId

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorBs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorUs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If
            End If

            .EstadoId = 10

            If .Insert() Then
               CompCentroCostoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByVal datFecha As Date) As Long
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompNroNext = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = lngEmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               If ToBoolean(.NroAuto) Then
                  If ToBoolean(.NroAutoGestion) Then
                     .UpdateFilter = clsCompPara.UpdateFilters.NroActual

                     If Not clsAppInfo.MultipleNro Then
                        .NroActual = .NroActual + 1

                        If .Update Then
                           CompNroNext = .NroActual
                        End If

                     Else
                        'If chkConFac.Checked Then
                        .NroActualFis = .NroActualFis + 1

                        If .Update Then
                           CompNroNext = .NroActualFis
                        End If

                        'Else
                        '   .NroActual = .NroActual + 1

                        '   If .Update Then
                        '      CompNroNext = .NroActual
                        '   End If
                        'End If
                     End If
                  Else
                     CompNroNext = CompNroMesNext(lngTipoCompId, lngEmpresaId, lngGestionId, lngSucursalId, datFecha.Month)
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Function

   Private Function CompNroMesNext(ByVal lngTipoCompId As Long, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByVal intMesId As Integer) As Long
      Dim oCompParaMes As New clsCompParaMes(clsAppInfo.ConnectString)

      Try
         CompNroMesNext = 0

         With oCompParaMes
            .SelectFilter = clsCompParaMes.SelectFilters.All
            .WhereFilter = clsCompParaMes.WhereFilters.MesId
            .EmpresaId = lngEmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId
            .MesId = intMesId
            .SucursalId = lngSucursalId

            If .Find Then
               .UpdateFilter = clsCompParaMes.UpdateFilters.NroActual

               If Not clsAppInfo.MultipleNro Then
                  .NroActual = .NroActual + 1

                  If .Update Then
                     CompNroMesNext = .NroActual
                  End If

               Else
                  'If chkConFac.Checked Then
                  .NroActualFis = .NroActualFis + 1

                  If .Update Then
                     CompNroMesNext = .NroActualFis
                  End If

                  'Else
                  '   .NroActual = .NroActual + 1

                  '   If .Update Then
                  '      CompNroMesNext = .NroActual
                  '   End If
                  'End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompParaMes.Dispose()

      End Try
   End Function

   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
            .EmpresaId = moFactura.EmpresaId
            .FechaIni = strFecha
            .EstadoId = 11

            If .Find Then
               GestionIdFind = ToLong(.GestionId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function PlanSucCCOId(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanSucCCOId = 0

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanSucCCOId = .SucCCOId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Sub CompraFacLoad(ByVal lngFacturaId As Long, ByVal decMontoFactura As Decimal)
      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)

      Try

         With oCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.All
            .WhereFilter = clsCompraFac.WhereFilters.FacturaId
            .FacturaId = lngFacturaId

            If .Find Then
               txtTipoCambio.Text = ToDecStr(.TipoCambio)
               cboProveedor.Value = ListFindItem(cboProveedor, mlngProveedorId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraFac.Dispose()
      End Try

   End Sub

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If ToStr(dtpFacturaFecha.Text) = "" Then
         strMsg &= "Fecha de Factura no Válida" & vbCrLf
      End If

      If moFactura.TipoFacturaId = 1 Then 'Compra
         If moFactura.RegRUCDes = "" Then
            strMsg &= "Razón Social Inválida" & vbCrLf

            'If (moFactura.FacturaNro <= 0) And (mlngTipoDosificaId = clsTipoDosifica.MANUAL) Then
            '   strMsg &= "Número de Factura Inválido" & vbCrLf
            'End If

            If moFactura.NroRUC = "0" Then
               strMsg &= "Número de NIT Inválido" & vbCrLf
            End If

            If moFactura.NroAutorizacion = "0" Then
               strMsg &= "Número de Autorización Inválido" & vbCrLf
            End If

            If ToDate2(dtpFacturaFecha.Text) < ToDate2(mstrFechaIniDosifica) Then
               strMsg &= "La Fecha es Menor a la Fecha Inicial de la Dosificación" & vbCrLf
            ElseIf ToDate2(dtpFacturaFecha.Text) > ToDate2(mstrFechaFinDosifica) Then
               strMsg &= "La Fecha es Mayor a la Fecha Final de la Dosificación" & vbCrLf
            End If

            If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
               strMsg &= "Código de Control Inválido" & vbCrLf
            End If

            If moFactura.FacturaMonto <= 0 Then
               strMsg &= "Importe Inválido" & vbCrLf

            ElseIf moFactura.IceIehd + moFactura.Exento + moFactura.Descuento >= moFactura.FacturaMonto Then
               strMsg &= "El ICE/IEHD y el Exento Deben Ser Menor al Importe" & vbCrLf
            End If

         ElseIf (moFactura.RegRUCId > 0) And (moFactura.RegRUCId < 5) Then 'Anuladas
            ''If (moFactura.FacturaNro <= 0) And (mlngTipoDosificaId = clsTipoDosifica.MANUAL) Then
            ''   strMsg &= "Número de Factura Inválido" & vbCrLf
            ''End If

            ''If moFactura.NroRUC <> "0" Then
            ''   strMsg &= "Número de NIT Inválido" & vbCrLf
            ''End If

            ''If moFactura.NroAutorizacion = "0" Then
            ''   strMsg &= "Número de Autorización Inválido" & vbCrLf
            ''End If

            ''If ToDate2(dtpFacturaFecha.Text) < ToDate2(mstrFechaIniDosifica) Then
            ''   strMsg &= "La Fecha es Menor a la Fecha Inicial de la Dosificación" & vbCrLf
            ''ElseIf ToDate2(dtpFacturaFecha.Text) > ToDate2(mstrFechaFinDosifica) Then
            ''   strMsg &= "La Fecha es Mayor a la Fecha Final de la Dosificación" & vbCrLf
            ''End If

            ''If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
            ''   strMsg &= "Código de Control Inválido" & vbCrLf
            ''End If

            ''If moFactura.FacturaMonto <> 0 Then
            ''   strMsg &= "Importe Inválido" & vbCrLf
            ''End If

            strMsg &= "No se Puede Registrar este tipo de Facturas" & vbCrLf

         Else
            'If (moFactura.FacturaNro <= 0) And (mlngTipoDosificaId = clsTipoDosifica.MANUAL) Then
            '   strMsg &= "Número de Factura Inválido" & vbCrLf
            'End If

            ''If moFactura.NroRUC = "0" Then
            ''   strMsg &= "Número de NIT Inválido" & vbCrLf
            ''End If

            If moFactura.NroAutorizacion = "0" Then
               strMsg &= "Número de Autorización Inválido" & vbCrLf
            End If

            If ToDate2(dtpFacturaFecha.Text) < ToDate2(mstrFechaIniDosifica) Then
               strMsg &= "La Fecha es Menor a la Fecha Inicial de la Dosificación" & vbCrLf
            ElseIf ToDate2(dtpFacturaFecha.Text) > ToDate2(mstrFechaFinDosifica) Then
               strMsg &= "La Fecha es Mayor a la Fecha Final de la Dosificación" & vbCrLf
            End If

            If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
               strMsg &= "Código de Control Inválido" & vbCrLf
            End If

            If moFactura.FacturaMonto <= 0 Then
               strMsg &= "Factura con Importe Inválido" & vbCrLf

               ''ElseIf moFactura.FacturaMonto > mdecMontoFacOrig Then
               ''   strMsg &= "Importe Inválido NO puede Mayor al Monto a Facturar" & vbCrLf

            ElseIf moFactura.IceIehd + moFactura.Exento + moFactura.Descuento >= moFactura.FacturaMonto Then
               strMsg &= "El ICE/IEHD y el Exento Deben Ser Menor al Importe" & vbCrLf
            End If

         End If

      Else 'Compra
         If moFactura.FacturaNro <= 0 Then
            strMsg &= "Número de Factura Inválido" & vbCrLf
         End If

         If moFactura.RegRUCDes = "" Then
            strMsg &= "Razón Social Inválida" & vbCrLf

         ElseIf (moFactura.RegRUCId > 0) And (moFactura.RegRUCId < 5) Then
            FormCheck = False
            Throw New Exception("Razón Social Inválida en Factura de Compra")
         End If

         If moFactura.NroRUC = "0" Then
            strMsg &= "Número de NIT Inválido" & vbCrLf
         End If

         If moFactura.NroAutorizacion = "0" Then
            strMsg &= "Número de Autorización Inválido" & vbCrLf
         End If

         If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
            strMsg &= "Código de Control Inválido" & vbCrLf
         End If

         If moFactura.FacturaMonto <= 0 Then
            strMsg &= "Importe Inválido" & vbCrLf

         ElseIf moFactura.IceIehd + moFactura.Exento + moFactura.Descuento >= moFactura.FacturaMonto Then
            strMsg &= "El ICE/IEHD y el Exento Deben Ser Menor al Importe" & vbCrLf
         End If

         If moFactura.TipoFacCompraId <= 0 Then
            strMsg &= "Tipo de Compra Inválido" & vbCrLf
         End If

         Dim lngFacturaDup As Long = DuplicateFacturaIdFind(moFactura.FacturaId, moFactura.FacturaNro, moFactura.NroAutorizacion)
         If (lngFacturaDup > 0) Then
            strMsg &= "Factura Duplicada" & vbCrLf
         End If
      End If

      ''Descuento
      If ListPosition(cboPlanDescuento, cboPlanDescuento.SelectedIndex) <> 0 Then
         If ToDecimal(txtMontoDes.Text) <= 0 Then
            strMsg &= "Monto de Descuento Inválido" & vbCrLf
         End If
      ElseIf ToDecimal(txtMontoDes.Text) > 0 Then
         If ListPosition(cboPlanDescuento, cboPlanDescuento.SelectedIndex) = 0 Then
            strMsg &= "Descuento Inválido" & vbCrLf
         End If
      ElseIf ToDecimal(txtMontoDes.Text) < 0 Then
         strMsg &= "Monto de Descuento Inválido" & vbCrLf
      End If

      ''If mboolExigirInfAdi Then
      ''   If moFactura.FacturaPL = String.Empty Then
      ''      strMsg &= "PL inválido" & vbCrLf
      ''   End If

      ''   If moFactura.FacturaNE = String.Empty Then
      ''      strMsg &= "NE inválido" & vbCrLf
      ''   End If

      ''   If moFactura.FacturaOC = String.Empty Then
      ''      strMsg &= "OC inválido" & vbCrLf
      ''   End If
      ''End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function CompraDetCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim strMsgAll As String = String.Empty
      Dim decIceIehd As Decimal
      Dim decMonto As Decimal
      Dim decExento As Decimal
      Dim lngItemId As Long
      Dim htbList As New Hashtable()

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         For Each oDataRow As Janus.Windows.GridEX.GridEXRow In oRow.GetChildRows()

            If ToDecimal(oDataRow.Cells("Importe").Value) > 0 Then
               decIceIehd = ToDecimal(oDataRow.Cells("IceIehd").Value)
               lngItemId = ToLong(oDataRow.Cells("ItemId").Value)
               If (htbList.ContainsKey(lngItemId)) Then
                  If decIceIehd <> ToDecimal(htbList.Item(lngItemId)) Then
                     strMsg &= "-Compra Nro. " & ToStr(oRow.Cells("CompraNro").Value) & ": " & ToStr(oDataRow.Cells("ItemDes").Value) & "=" & ToStr(oDataRow.Cells("IceIehd").Value) & vbCrLf
                  End If
               Else
                  htbList(lngItemId) = decIceIehd
               End If
            End If

         Next
      Next

      If strMsg <> String.Empty Then
         CompraDetCheck = False
         strMsgAll &= "Items con ICE/IEHD diferentes " & vbCrLf & strMsg
         Throw New Exception(strMsgAll)
      End If

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If ToDecimal(oRow.Cells("MontoFacturar").Value) > 0 Then
            If (ToDecimal(oRow.Cells("SaldoFactura").Value) < ToDecimal(oRow.Cells("MontoFacturar").Value)) Then
               If Math.Abs(ToDecimal(oRow.Cells("SaldoFactura").Value) - ToDecimal(oRow.Cells("MontoFacturar").Value)) >= 0.05 Then
                  If ToDecimal(oRow.Cells("SaldoFactura").Value) < ToDecimal(oRow.Cells("MontoFacturarBru").Value) Then
                     CompraDetCheck = False
                     Throw New Exception("Compra Nro. " & ToStr(oRow.Cells("CompraNro").Value) & ": Saldo Factura menor al Monto a Facturar ")
                  End If
               End If
            End If
            ''Exentos
            If ToDecimal(oRow.Cells("SaldoExento").Value) > 0 Then
               If (ToDecimal(oRow.Cells("SaldoExento").Value) < ToDecimal(oRow.Cells("MontoExentoAFac").Value)) Then
                  CompraDetCheck = False
                  Throw New Exception("Compra Nro. " & ToStr(oRow.Cells("CompraNro").Value) & ": Exento Inválido Negativo ")

               ElseIf ToDecimal(oRow.Cells("MontoFacturar").Value) = ToDecimal(oRow.Cells("SaldoFactura").Value) Then
                  If ToDecimal(oRow.Cells("MontoExentoAFac").Value) <> ToDecimal(oRow.Cells("SaldoExento").Value) Then
                     CompraDetCheck = False
                     Throw New Exception("Compra Nro. " & ToStr(oRow.Cells("CompraNro").Value) & ": Exento Inválido DEBE Ingresar el Exento establecido ")
                  End If
               ElseIf (ToDecimal(oRow.Cells("SaldoFactura").Value) - ToDecimal(oRow.Cells("SaldoExento").Value)) = 0 Then
                  If ToDecimal(oRow.Cells("MontoExentoAFac").Value) <> ToDecimal(oRow.Cells("MontoFacturar").Value) Then
                     CompraDetCheck = False
                     Throw New Exception("Compra Nro. " & ToStr(oRow.Cells("CompraNro").Value) & ": Monto Facturar y Exento Inválido, Ambos tienen q ser iguales ")
                  End If
               Else
                  decMonto = ToDecimal(oRow.Cells("SaldoFactura").Value) - ToDecimal(oRow.Cells("MontoFacturar").Value)
                  decExento = ToDecimal(oRow.Cells("SaldoExento").Value) - ToDecimal(oRow.Cells("MontoExentoAFac").Value)
                  If (decMonto < decExento) Then
                     CompraDetCheck = False
                     Throw New Exception("Compra Nro. " & ToStr(oRow.Cells("CompraNro").Value) & ": Exento Inválido DEBE Ingresar el Exento establecido ")
                  End If
               End If
            End If

         End If

      Next

      If strMsgAll.Trim <> String.Empty Then
         Throw New Exception(strMsgAll)
         CompraDetCheck = False
      Else
         CompraDetCheck = True
      End If

   End Function

   Private Sub grdMainClear()
      Call grdMainLoad()
   End Sub

   Private Function GestionFind(ByVal lngGestionId As Long) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionFind = 0

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               GestionFind = .Gestion
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()
      End Try
   End Function

   Private Sub FormInit()

      txtFacturaMonto.FormatString = DecimalMaskDos()
      txtIceIehd.FormatString = DecimalMaskDos()
      txtExento.FormatString = DecimalMaskDos()
      txtDescuento.FormatString = DecimalMaskDos()
      txtSubTotal.FormatString = DecimalMaskDos()
      txtNeto.FormatString = DecimalMaskDos()
      txtIVA.FormatString = DecimalMaskDos()
      txtImporteIVA.FormatString = DecimalMaskDos()
      txtFacturaTC.FormatString = DecimalMaskDos()

      txtMontoPorFacBs.FormatString = DecimalMask()
      txtMontoPorFacSus.FormatString = DecimalMask()
      txtMontoBruBs.FormatString = DecimalMask()
      txtMontoBruSus.FormatString = DecimalMask()
      txtTipoCambio.FormatString = DecimalMask()

      txtMontoDes.FormatString = DecimalMaskDos()

      mboolChanged = False
      moFacturaDet = New clsFacturaDet(clsAppInfo.ConnectString)
      moCompraFac = New clsCompraFac(clsAppInfo.ConnectString)

      ''Call grdMainClear()

   End Sub

   Private Sub ComboLoad()
      Call cboRegRUCLoad()
      Call cboEstadoLoad()
      Call cboProveedorLoad()
      Call cboTipoFacCompraLoad()
      Call cboPlanDescuentoLoad()
   End Sub

   Private Sub cboProveedorLoad()
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oListItem As clsListItem

      cboProveedor.DropDownList.Columns.Clear()

      Try
         With oProveedor
            .SelectFilter = clsProveedor.SelectFilters.ListBox
            .WhereFilter = clsProveedor.WhereFilters.EmpresaId
            .OrderByFilter = clsProveedor.OrderByFilters.ProveedorDes
            .EmpresaId = moFactura.EmpresaId

            If .Open() Then
               With cboProveedor
                  .DropDownList.Columns.Add("ProveedorId")
                  .DropDownList.Columns("ProveedorId").DataMember = "ProveedorId"
                  .DropDownList.Columns("ProveedorId").Visible = False

                  .DropDownList.Columns.Add("ProveedorCod")
                  .DropDownList.Columns("ProveedorCod").Caption = "Código"
                  .DropDownList.Columns("ProveedorCod").DataMember = "ProveedorCod"
                  .DropDownList.Columns("ProveedorCod").Width = 100

                  .DropDownList.Columns.Add("ProveedorDes")
                  .DropDownList.Columns("ProveedorDes").Caption = "Descripción"
                  .DropDownList.Columns("ProveedorDes").DataMember = "ProveedorDes"
                  .DropDownList.Columns("ProveedorDes").Width = 205

                  .DataMember = oProveedor.TableName
                  .DataSource = oProveedor.DataSet

                  .ValueMember = "ProveedorId"
                  .DisplayMember = "ProveedorDes"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()
         oListItem = Nothing

      End Try
   End Sub

   Private Sub cboRegRUCLoad()
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.EmpresaId
            .OrderByFilter = clsRegRUC.OrderByFilters.RegRUCDes
            .EmpresaId = moFactura.EmpresaId

            If .Open() Then
               With cboRegRUC
                  .DropDownList.Columns.Clear()

                  .DropDownList.Columns.Add("RegRUCId")
                  .DropDownList.Columns("RegRUCId").DataMember = "RegRUCId"
                  .DropDownList.Columns("RegRUCId").Visible = False

                  .DropDownList.Columns.Add("NroRUC")
                  .DropDownList.Columns("NroRUC").Caption = "NIT"
                  .DropDownList.Columns("NroRUC").DataMember = "NroRUC"
                  .DropDownList.Columns("NroRUC").Width = 100

                  .DropDownList.Columns.Add("RegRUCDes")
                  .DropDownList.Columns("RegRUCDes").Caption = "Descripción"
                  .DropDownList.Columns("RegRUCDes").DataMember = "RegRUCDes"
                  .DropDownList.Columns("RegRUCDes").Width = 205

                  .DataMember = oRegRUC.TableName
                  .DataSource = oRegRUC.DataSet

                  .ValueMember = "RegRUCId"
                  .DisplayMember = "RegRUCDes"
               End With

               With cboNroRUC
                  .DropDownList.Columns.Clear()

                  .DropDownList.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False

                  .DropDownList.Columns.Add("RegRUCId")
                  .DropDownList.Columns("RegRUCId").DataMember = "RegRUCId"
                  .DropDownList.Columns("RegRUCId").Visible = False

                  .DropDownList.Columns.Add("NroRUC")
                  .DropDownList.Columns("NroRUC").DataMember = "NroRUC"
                  .DropDownList.Columns("NroRUC").Width = 90

                  .DataMember = oRegRUC.TableName
                  .DataSource = oRegRUC.DataSet

                  .ValueMember = "RegRUCId"
                  .DisplayMember = "NroRUC"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Sub

   Private Sub cboTipoFacCompraLoad()
      Dim oTipoFacCompra As New clsTipoFacCompra(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoFacCompra.Items.Clear()

      Try
         With oTipoFacCompra
            .SelectFilter = clsTipoFacCompra.SelectFilters.ListBox
            .OrderByFilter = clsTipoFacCompra.OrderByFilters.TipoFacCompraId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoFacCompraId, .TipoFacCompraDes)

                  cboTipoFacCompra.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoFacCompra.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboPlanDescuentoLoad()
      Dim oPlanDescuento As New clsPlanDescuento(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPlanDescuento.Items.Clear()

      Try
         With oPlanDescuento
            .SelectFilter = clsPlanDescuento.SelectFilters.ListBox
            .WhereFilter = clsPlanDescuento.WhereFilters.EmpresaId
            .OrderByFilter = clsPlanDescuento.OrderByFilters.PlanDescuentoDes
            .EmpresaId = moFactura.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.PlanDescuentoId, .PlanDescuentoDes)

                  cboPlanDescuento.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanDescuento.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboEstadoLoad()
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboEstado.Items.Clear()

      Try
         With oEstado
            .SelectFilter = clsEstado.SelectFilters.ListBox
            .WhereFilter = clsEstado.WhereFilters.TipoId
            .OrderByFilter = clsEstado.OrderByFilters.EstadoDes
            .TipoId = 2

            If .Open() Then
               Do While .Read()

                  If ((.EstadoId = 11 Or .EstadoId = 12) And mboolAnular) Or Not mboolAnular Then
                     oItem = New clsListItem(.EstadoId, .EstadoDes)
                     cboEstado.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEstado.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Function DuplicateFacturaIdFind(ByVal lngFacturaId As Long, ByVal lngFacturaNro As Long, ByVal strNroAutorzacion As String) As Long
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      DuplicateFacturaIdFind = 0

      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.FacturaDuplicada
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoFacturaId = 2
            .NroAutorizacion = strNroAutorzacion
            .FacturaNro = lngFacturaNro
            .FacturaId = lngFacturaId

            If .Find Then
               DuplicateFacturaIdFind = .FacturaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function RegRucNroIdFind(ByVal strNroRuc As String) As Long
      Dim oRegRuc As New clsRegRUC(clsAppInfo.ConnectString)

      RegRucNroIdFind = 0

      Try
         With oRegRuc
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.NroRUC

            .NroRUC = strNroRuc
            .EmpresaId = moFactura.EmpresaId

            If .Find Then
               RegRucNroIdFind = .RegRUCId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRuc.Dispose()

      End Try
   End Function

   Private Function RegRucIdFind(ByVal strRegRucDes As String) As Long
      Dim oRegRuc As New clsRegRUC(clsAppInfo.ConnectString)

      RegRucIdFind = 0

      Try
         With oRegRuc
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.RegRUCDes

            .RegRUCDes = strRegRucDes
            .EmpresaId = moFactura.EmpresaId

            If .Find Then
               RegRucIdFind = .RegRUCId
            End If
         End With


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRuc.Dispose()

      End Try
   End Function

   Private Function NroAutorizacionFind(ByVal lngRegRUCId As Long) As String
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC
            .RegRUCId = lngRegRUCId

            If .FindByPK Then
               NroAutorizacionFind = .NroAutorizacion
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Function DosificaLoad(ByVal lngEmpresaId As Long) As Boolean
      'Dim oDosifica As New clsDosifica(clsAppInfo.ConnectString)

      'Try
      '   With oDosifica
      '      .SelectFilter = clsDosifica.SelectFilters.All
      '      .WhereFilter = clsDosifica.WhereFilters.TipoDosificaId
      '      .OrderByFilter = clsDosifica.OrderByFilters.NumeroIni
      '      .EmpresaId = lngEmpresaId
      '      .TipoDosificaId = 1 'Manual
      '      .SucursalId = moFactura.SucursalId
      '      .EstadoId = 11

      '      If .Open() Then
      '         For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
      '            If (ToLong(txtFacturaNro.Text) >= oRow("NumeroIni")) And (ToLong(txtFacturaNro.Text) <= oRow("NumeroFin")) Then
      '               moFactura.SucursalId = oRow("SucursalId")
      '               moFactura.DosificaId = oRow("DosificaId")
      '               txtNroAutorizacion.Text = ToStr(oRow("NroAutorizacion"))
      '               mstrFechaIniDosifica = ToDateDMY(oRow("FechaIni"))
      '               mstrFechaFinDosifica = ToDateDMY(oRow("FechaFin"))
      '            End If
      '         Next
      '      End If
      '   End With

      'Catch exp As Exception
      '   MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      'Finally
      '   oDosifica.Dispose()

      'End Try
   End Function

   Private Sub dtpFacturaFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFacturaFecha.LostFocus
      If mboolAdding Then
         If Not IsNothing(moFactura) Then
            If dtpFacturaFecha.Tag <> dtpFacturaFecha.Text Then
               If IsDate(dtpFacturaFecha.Text) Then
                  dtpFacturaFecha.Tag = dtpFacturaFecha.Text
               Else
                  txtTipoCambio.Text = 0
               End If
            End If
         End If
      End If
   End Sub

   Private Sub txtFacturaNro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturaNro.LostFocus
      If mboolAdding Then
         If txtFacturaNro.Tag <> txtFacturaNro.Text Then
            txtFacturaNro.Tag = txtFacturaNro.Text
            If moFactura.TipoFacturaId = 1 Then 'Venta
               txtNroAutorizacion.Text = "0"
               ''Call DosificaLoad(moFactura.EmpresaId)
            End If
         End If
      End If
   End Sub

   Private Sub cboRegRUC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRegRUC.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            Dim frm As New frmRegRUCEdit
            Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

            Try
               With frm
                  .NewRecord = True
                  .Editing = False

                  oRegRUC.EmpresaId = moFactura.EmpresaId
                  .DataObject = oRegRUC
                  .ShowDialog()

                  If .Changed Then
                     Call cboRegRUCLoad()
                     cboRegRUC.Value = ListFindItem(cboRegRUC, ToLong(frm.ID))

                  End If
                  frm.Dispose()
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Finally
               oRegRUC.Dispose()

            End Try

         ElseIf e.KeyCode = Keys.F2 Then
            If ListPosition(cboRegRUC) <> 0 Then
               Dim frm As New frmRegRUCEdit
               Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

               Try
                  With frm
                     oRegRUC.RegRUCId = ListPosition(cboRegRUC)

                     If oRegRUC.FindByPK Then
                        .NewRecord = False
                        .Editing = True

                        .DataObject = oRegRUC
                        .ShowDialog()

                        If .Changed Then
                           Call cboRegRUCLoad()
                           cboRegRUC.Value = ListFindItem(cboRegRUC, ToLong(frm.ID))
                        End If
                        frm.Dispose()
                     End If
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oRegRUC.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboRegRUC_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegRUC.LostFocus

      If mboolAdding Then
         If cboRegRUC.Tag <> cboRegRUC.Text Then
            cboRegRUC.Tag = cboRegRUC.Text

            If ListPosition(cboRegRUC) <> 0 Then
               cboNroRUC.Value = ListFindItem(cboNroRUC, ListPosition(cboRegRUC))
               cboNroRUC.Tag = cboNroRUC.Text

               If moFactura.TipoFacturaId = 2 Then 'Compra
                  txtNroAutorizacion.Text = NroAutorizacionFind(ListPosition(cboRegRUC))
                  mstrNroAutorizacion = txtNroAutorizacion.Text
               End If

               txtCodControl.Text = ""
            End If
         End If
      End If
   End Sub

   Private Sub cboNroRUC_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNroRUC.LostFocus

      If mboolAdding Then
         If cboNroRUC.Tag <> cboNroRUC.Text Then
            cboNroRUC.Tag = cboNroRUC.Text

            If ListPosition(cboNroRUC) <> 0 Then
               cboRegRUC.Value = ListFindItem(cboRegRUC, ListPosition(cboNroRUC))
               cboRegRUC.Tag = cboRegRUC.Text

               If moFactura.TipoFacturaId = 2 Then 'Compra
                  txtNroAutorizacion.Text = NroAutorizacionFind(ListPosition(cboNroRUC))
                  mstrNroAutorizacion = txtNroAutorizacion.Text
               End If
               txtCodControl.Text = ""
            End If
         End If
      End If
   End Sub

   Private Sub cboNroRUC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboNroRUC.KeyPress

      If mboolAdding Then
         Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

         KeyAscii = CShort(SoloNumeros(KeyAscii))
         If KeyAscii = 0 Then
            e.Handled = True
         End If
      End If

   End Sub

   Private Sub txtNroAutorizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroAutorizacion.KeyPress

      If mboolAdding Then

         Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

         KeyAscii = CShort(SoloNumeros(KeyAscii))
         If KeyAscii = 0 Then
            e.Handled = True
         End If
      End If

   End Sub

   Private Sub txtFacturaNro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFacturaNro.KeyPress

      If mboolAdding Then
         Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

         KeyAscii = CShort(SoloNumeros(KeyAscii))
         If KeyAscii = 0 Then
            e.Handled = True
         End If

      End If
   End Sub

   Private Sub chkProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProveedor.CheckedChanged
      If chkProveedor.Checked Then
         cboProveedor.DisplayMember = "ProveedorDes"
      Else
         cboProveedor.DisplayMember = "ProveedorCod"
      End If
   End Sub

   Private Sub txtFacturaMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFacturaMonto.ValueChanged
      txtSubTotal.Text = ToDecStr(ToDecimalDos(txtFacturaMonto.Text) - (ToDecimalDos(txtIceIehd.Text) + ToDecimalDos(txtExento.Text)))
      txtNeto.Text = ToDecStr(ToDecimalDos(txtFacturaMonto.Text) - (ToDecimalDos(txtIceIehd.Text) + ToDecimalDos(txtExento.Text) + ToDecimalDos(txtDescuento.Text)))
      txtIVA.Text = ToDecStr(ToDecimalDos(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimalDos(txtNeto.Text) - ToDecimalDos(txtIVA.Text))

      If ToDecimalDos(txtFacturaMonto.Text) >= 50000 Then
         chkBancarizar.Checked = True
      Else
         chkBancarizar.Checked = False
      End If
   End Sub

   Private Sub txtIceIehd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIceIehd.ValueChanged
      txtSubTotal.Text = ToDecStr(ToDecimalDos(txtFacturaMonto.Text) - (ToDecimalDos(txtIceIehd.Text) + ToDecimalDos(txtExento.Text)))
      txtNeto.Text = ToDecStr(ToDecimalDos(txtFacturaMonto.Text) - (ToDecimalDos(txtIceIehd.Text) + ToDecimalDos(txtExento.Text) + ToDecimalDos(txtDescuento.Text)))
      txtIVA.Text = ToDecStr(ToDecimalDos(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimalDos(txtNeto.Text) - ToDecimalDos(txtIVA.Text))

      If ToDecimalDos(txtFacturaMonto.Text) >= 50000 Then
         chkBancarizar.Checked = True
      Else
         chkBancarizar.Checked = False
      End If
   End Sub

   Private Sub txtExento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExento.ValueChanged
      txtSubTotal.Text = ToDecStr(ToDecimalDos(txtFacturaMonto.Text) - (ToDecimalDos(txtIceIehd.Text) + ToDecimalDos(txtExento.Text)))
      txtNeto.Text = ToDecStr(ToDecimalDos(txtFacturaMonto.Text) - (ToDecimalDos(txtIceIehd.Text) + ToDecimalDos(txtExento.Text) + ToDecimalDos(txtDescuento.Text)))
      txtIVA.Text = ToDecStr(ToDecimalDos(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimalDos(txtNeto.Text) - ToDecimalDos(txtIVA.Text))

      If ToDecimalDos(txtFacturaMonto.Text) >= 50000 Then
         chkBancarizar.Checked = True
      Else
         chkBancarizar.Checked = False
      End If
   End Sub

   Private Sub txtDescuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescuento.ValueChanged
      txtSubTotal.Text = ToDecStr(ToDecimalDos(txtFacturaMonto.Text) - (ToDecimalDos(txtIceIehd.Text) + ToDecimalDos(txtExento.Text)))
      txtNeto.Text = ToDecStr(ToDecimalDos(txtFacturaMonto.Text) - (ToDecimalDos(txtIceIehd.Text) + ToDecimalDos(txtExento.Text) + ToDecimalDos(txtDescuento.Text)))
      txtIVA.Text = ToDecStr(ToDecimalDos(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimalDos(txtNeto.Text) - ToDecimalDos(txtIVA.Text))

      If ToDecimalDos(txtFacturaMonto.Text) >= 50000 Then
         chkBancarizar.Checked = True
      Else
         chkBancarizar.Checked = False
      End If
   End Sub

   Private Sub txtMontoDes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoDes.TextChanged
      If txtMontoDes.ContainsFocus Then
         If ToDecimalDos(txtMontoDes.Text) <> ToDecimalDos(txtMontoDes.Tag) Then
            Call MontoPagarFactura()
            ''txtDescuento.Text = ToDecStr(ToDecimalDos(txtMontoDes.Text) + ToDecimalDos(txtDescuento.Text))
            txtMontoDes.Tag = txtMontoDes.Text
         End If
      End If
   End Sub

   Private Sub chkFacturaNoValida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFacturaNoValida.CheckedChanged
      If chkFacturaNoValida.Checked Then
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 5)
         txtFacturaObs.Text = "Factura Diferida NO VÀLIDA"
         mboolEditarPrecio = False
         Call grdMainCheckFacNOVal()
      Else
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)
         txtFacturaObs.Text = ""
         mboolEditarPrecio = True

      End If
   End Sub

   Private Sub frmFacturaDifMultipleDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then

            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moFactura.FacturaId
                  txtCodControl.Text = moFactura.CodControl

                  mboolChanged = True

                  Call DataReadOnly()

                  MessageBox.Show("Factura Guardada Exitosamente" + vbCrLf, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmFacturaDifMultipleDetEdit_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
      grdMain.Refresh()
   End Sub

   Private Sub frmFacturaDifMultipleDetEdit_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
      moFactura.Dispose()
      moFacturaDet.Dispose()
      moCompraFac.Dispose()

      Call ClearMemory()
   End Sub

#Region " Detalle Compras "

   Private Sub grdMainLoad()
      mdecMontoFacturado = 0
      mdecExentoFacturado = 0

      Try
         Call moDataSetInit()

         mlngCompraDetItemId = 0

         If mboolAdding Then
            For Each oRow As DataRow In moDataTableVenOrg.Rows
               moDataTable.Rows.Add(GetRowNew(oRow))
               moDataTable.AcceptChanges()

               If ToDecimal(oRow("ExentoAFac")) > 0 Then
                  mboolExento = True
               End If

               mdecMontoFacturado += oRow("MontoFac")
               mdecExentoFacturado += oRow("ExentoFac")

            Next
         Else
            With moCompraFac
               '.SelectFilter = clsCompraFac.SelectFilters.GridFacturaId
               '.WhereFilter = clsCompraFac.WhereFilters.GridFacturaId
               '.OrderByFilter = clsCompraFac.OrderByFilters.GridFacturaId
               '.EmpresaId = moFactura.EmpresaId
               '.FacturaId = moFactura.FacturaId

               'If .Open() Then

               '   For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
               '      moDataTable.Rows.Add(GetRowShow(oRow))
               '      moDataTable.AcceptChanges()
               '   Next
               'End If
            End With
         End If

         grdMain.SetDataBinding(moDataTable, "")
         'Call grdMainRefresh()
         'grdMain.RootTable.ChildTables(0).ChildTables(0).GridEX.Refresh() ''CompraDetItem

         grdMain.RetrieveStructure()
         grdMain.Refresh()
         grdMain.Update()
         Call grdMainInit()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub moDataSetInit()

      moDataSet = New DataSet(moFactura.TableName)
      moDataTable = moDataSet.Tables.Add(moFactura.TableName)

      moDataTable.Columns.Add("Sel", Type.GetType("System.Boolean"))
      moDataTable.Columns.Add("CompraId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("GestionId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Gestion", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompraNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompraOrden", Type.GetType("System.String"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.DateTime"))
      moDataTable.Columns.Add("MonedaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MonedaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoCambio", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoBru", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoFac", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoFactura", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoFacturar", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoFacturarBru", Type.GetType("System.Decimal"))

      moDataTable.Columns.Add("MontoPorFac", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoPorFacAFac", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoDes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoDesAFac", Type.GetType("System.Decimal"))

      moDataTable.Columns.Add("FactDifExento", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoExentoFac", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoExento", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoExentoAFac", Type.GetType("System.Decimal"))

   End Sub

   Private Function GetRowShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("Sel") = True
      oRow("CompraId") = oDataRow("CompraId")
      oRow("GestionId") = oDataRow("GestionId")
      oRow("Gestion") = oDataRow("Gestion")
      oRow("CompraNro") = oDataRow("CompraNro")
      oRow("CompraOrden") = oDataRow("CompraOrden")
      oRow("Fecha") = oDataRow("Fecha")
      oRow("MonedaId") = oDataRow("MonedaId")
      oRow("MonedaDes") = oDataRow("MonedaDes")
      oRow("TipoCambio") = oDataRow("TipoCambio")
      oRow("MontoOrg") = oDataRow("MontoOrg")
      oRow("MontoBru") = oDataRow("MontoBru")
      oRow("MontoFac") = oDataRow("MontoFac")
      oRow("SaldoFactura") = 0
      oRow("MontoFacturar") = oDataRow("MontoCompra")
      oRow("MontoPorFacAFac") = 0
      oRow("MontoDesAFac") = 0

      oRow("FactDifExento") = 0
      oRow("MontoExentoFac") = 0
      oRow("MontoExentoAFac") = 0

      Return oRow

   End Function

   Private Function GetRowNew(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("Sel") = False
      oRow("CompraId") = oDataRow("CompraId")
      oRow("GestionId") = oDataRow("GestionId")
      oRow("Gestion") = oDataRow("Gestion")
      oRow("CompraNro") = oDataRow("CompraNro")
      oRow("CompraOrden") = oDataRow("CompraOrden")
      oRow("Fecha") = oDataRow("Fecha")
      oRow("MonedaId") = oDataRow("MonedaId")
      oRow("MonedaDes") = oDataRow("MonedaDes")
      oRow("TipoCambio") = oDataRow("TipoCambio")
      oRow("MontoOrg") = oDataRow("MontoOrg")
      oRow("MontoBru") = oDataRow("MontoBru")
      oRow("MontoFac") = oDataRow("MontoFac")
      oRow("SaldoFactura") = oDataRow("SaldoFactura")
      oRow("MontoFacturar") = 0
      oRow("MontoFacturarBru") = 0
      oRow("MontoPorFac") = oDataRow("MontoOrg") + oDataRow("MontoRec")
      oRow("MontoPorFacAFac") = 0
      oRow("MontoDes") = oDataRow("MontoDes")
      oRow("MontoDesAFac") = 0
      oRow("FactDifExento") = oDataRow("FactDifExento")
      oRow("MontoExentoFac") = oDataRow("ExentoFac")
      oRow("SaldoExento") = oDataRow("ExentoAFac")
      oRow("MontoExentoAFac") = 0

      Return oRow

   End Function

   'Private Sub GetRowCompraDetNew(ByVal lngCompraId As Long)
   '   Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
   '   Dim oRow As DataRow
   '   Dim decCantidad As Decimal = 0
   '   Dim decImporteFac As Decimal = 0
   '   Dim decPrecioBru As Decimal = 0

   '   Dim decTotalFac As Decimal = 0

   '   Dim strItemCod As String

   '   Dim decTotalImporteFac As Decimal = 0
   '   Dim decCantidadOrg As Decimal = 0
   '   Dim decImporteOrg As Decimal = 0
   '   Dim lngAct2 As Long = 0

   '   Try
   '      With oCompraDet

   '         .SelectFilter = clsCompraDet.SelectFilters.All
   '         .WhereFilter = clsCompraDet.WhereFilters.CompraId
   '         .OrderByFilter = clsCompraDet.OrderByFilters.CompraDetId
   '         .EmpresaId = clsAppInfo.EmpresaId
   '         .CompraId = lngCompraId

   '         If .Open Then

   '            While .Read()
   '               decCantidad = .Cantidad - .CantidadDev - .CantidadFac
   '               decCantidadOrg = .Cantidad - .CantidadDev
   '               decPrecioBru = ToDouble(.PrecioOrg - .PrecioDes + .PrecioRec)
   '               decImporteFac = .ImporteFac

   '               decTotalFac = (decCantidad * decPrecioBru) - decImporteFac
   '               ''If decCantidad > 0 Then
   '               If decTotalFac > 0 Then

   '                  If decImporteFac > 0 Then
   '                     decCantidad -= decImporteFac / decPrecioBru
   '                  End If

   '                  oRow = moCompraDetTable.NewRow

   '                  oRow("Sel") = True
   '                  oRow("CompraId") = lngCompraId
   '                  oRow("CompraDetId") = .CompraDetId
   '                  oRow("ItemId") = .ItemId
   '                  oRow("ItemDes") = ItemDesFind(.ItemId, strItemCod, "", 0)
   '                  oRow("ItemCod") = strItemCod
   '                  oRow("MedidaId") = .MedidaId
   '                  oRow("MedidaDes") = MedidaDesFind(oCompraDet.MedidaId)
   '                  oRow("MonedaId") = .MonedaId
   '                  oRow("TipoCambio") = .TipoCambio
   '                  oRow("CantidadFac") = ToDecimal(decCantidad)
   '                  oRow("Cantidad") = 0
   '                  oRow("PrecioOrg") = ToDouble(.PrecioOrg)
   '                  oRow("Precio") = ToDouble(.PrecioOrg - .PrecioDes + .PrecioRec)
   '                  oRow("Importe") = 0
   '                  oRow("MontoRec") = ToDouble(.PrecioRec * oCompraDet.Cantidad)
   '                  oRow("MontoDes") = ToDouble(.PrecioDes * oCompraDet.Cantidad)
   '                  oRow("ImporteNet") = ToDecimal(ToDecimal(oRow("Importe")) + ToDecimal(oRow("MontoRec")) - ToDecimal(oRow("MontoDes")))

   '                  oRow("PrecioFactura") = ToDouble(.PrecioPorFac)
   '                  oRow("PrecioPorFac") = ToDouble(.PrecioPorFac)
   '                  oRow("ImportePorFacFac") = ToDouble(oRow("PrecioPorFac") * decCantidad)
   '                  oRow("ImportePorFac") = 0

   '                  oRow("PrecioDes") = ToDouble(.PrecioDes)
   '                  oRow("ImporteDesFac") = ToDouble(oRow("PrecioDes") * decCantidad)
   '                  oRow("ImporteDes") = 0

   '                  oRow("IceIehd") = ToDouble(.IceIehd / 100)
   '                  oRow("ImporteIceIehdFac") = ToDouble(oRow("IceIehd") * decCantidad)
   '                  oRow("ImporteIceIehd") = 0

   '                  oRow("EditPrecio") = 0
   '                  oRow("CompraDetDes") = .CompraDetDes

   '                  Call ItemParametro(.ItemId)
   '                  If (mlngTipoItemId = clsTipoItem.INCompraRIO) And (.IceIehd > 0) Then
   '                     oRow("PorImporte") = False
   '                     oRow("EditImporte") = 0
   '                     oRow("CantImpFac") = oRow("CantidadFac")
   '                     oRow("PrecioFacOrg") = oRow("Precio")

   '                  Else

   '                     If decImporteFac > 0 Then
   '                        decImporteOrg = (decCantidadOrg * oRow("Precio"))

   '                        oRow("PorImporte") = True
   '                        oRow("EditImporte") = 0

   '                        oRow("CantidadFac") = 1  ''Cantidad A facturar 
   '                        oRow("ImporteFac") = decImporteOrg - decImporteFac  ''Importe a facturar
   '                        oRow("PrecioFacOrg") = oRow("Precio")    ''Precio Real de la Compra o PrecioNeto

   '                        oRow("Cantidad") = 0
   '                        oRow("Importe") = 0
   '                        ''oRow("Precio") = oRow("ImporteFac") / decCantidadOrg  ''Precio Promedio
   '                        oRow("Precio") = oRow("ImporteFac")   ''Precio Promedio 
   '                        oRow("CantImpFac") = oRow("ImporteFac")

   '                     ElseIf (decCantidadOrg = decCantidad) Then ''SI no se hizo ninguna Facturacion
   '                        oRow("CantImpFac") = oRow("CantidadFac")
   '                        oRow("PorImporte") = False
   '                        oRow("EditImporte") = 1
   '                        oRow("ImporteFac") = oRow("Precio") * oRow("CantidadFac")
   '                        oRow("PrecioFacOrg") = oRow("Precio")    ''Precio Real de la Compra o PrecioNeto

   '                     Else ''Si se hizo Facturacion por Cantidad
   '                        oRow("PorImporte") = False
   '                        oRow("EditImporte") = 0
   '                        oRow("CantImpFac") = oRow("CantidadFac")
   '                        oRow("PrecioFacOrg") = oRow("Precio")
   '                     End If

   '                     If (mlngTipoItemId <> clsTipoItem.SERVICIO) And (oRow("EditImporte") = 1) Then
   '                        oRow("EditImporte") = IIf(mboolFacItemInvPorImp, 1, 0)
   '                        ''oRow("EditImporte") = IIf(mboolEditarPrecio, 1, 0)
   '                     End If
   '                  End If

   '                  oRow("TipoActEco1Id") = PlanTipoActEcoIdFind(.ItemId, lngAct2)
   '                  oRow("TipoActEco2Id") = lngAct2

   '                  moCompraDetTable.Rows.Add(oRow)
   '                  moCompraDetTable.AcceptChanges()

   '                  ''CompraDetItem
   '                  Call CompraDetItemRowsLoad(oRow)
   '               End If

   '               .MoveNext()
   '            End While

   '         End If

   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oCompraDet.Dispose()

   '   End Try
   'End Sub

   'Private Function GetRowCompraDetItemNew(ByVal oDataRow As DataRow, ByVal lngNro As Long) As DataRow
   '   Dim oRow As DataRow ''CompraDetItem
   '   oRow = modtCompraDetItem.NewRow

   '   oRow("CompraDetItemId") = mlngCompraDetItemId
   '   oRow("Nro") = lngNro
   '   oRow("CompraId") = oDataRow("CompraId")
   '   oRow("CompraDetId") = oDataRow("CompraDetId")
   '   oRow("ItemId") = oDataRow("ItemId")
   '   oRow("Item") = ""


   '   If lngNro = 1 Then
   '      oRow("Descripcion") = "PrecioFac"
   '      oRow("PrecioOrg") = oDataRow("PrecioPorFac")
   '      oRow("Precio") = oDataRow("PrecioPorFac")
   '      oRow("ImporteFac") = oDataRow("ImportePorFacFac")
   '      oRow("Importe") = 0

   '   ElseIf lngNro = 2 Then
   '      oRow("Descripcion") = "Descuento"
   '      oRow("PrecioOrg") = oDataRow("PrecioDes")
   '      oRow("Precio") = oDataRow("PrecioDes")
   '      oRow("ImporteFac") = oDataRow("ImporteDesFac")
   '      oRow("Importe") = 0

   '   ElseIf lngNro = 3 Then
   '      oRow("Descripcion") = "Ice/Iehd"
   '      oRow("PrecioOrg") = oDataRow("IceIehd")
   '      oRow("Precio") = oDataRow("IceIehd")
   '      oRow("ImporteFac") = oDataRow("ImporteIceIehdFac")
   '      oRow("Importe") = 0

   '   End If

   '   Return oRow

   'End Function

   'Private Sub CompraDetItemRowsLoad(ByVal oRow As DataRow)
   '   ''CompraDetItem
   '   Dim lngCantItem As Long = 0
   '   Dim lngTotal As Long = 3
   '   Try

   '      While lngCantItem < lngTotal
   '         lngCantItem += 1
   '         mlngCompraDetItemId += 1
   '         If (lngCantItem = 1) Or (lngCantItem = 2) Then
   '            modtCompraDetItem.Rows.Add(GetRowCompraDetItemNew(oRow, lngCantItem))
   '            modtCompraDetItem.AcceptChanges()

   '         ElseIf lngCantItem = 3 Then
   '            If (mlngTipoTasaId = clsTipoTasa.ICE_IEHD) Or (oRow("IceIehd") > 0) Then

   '               modtCompraDetItem.Rows.Add(GetRowCompraDetItemNew(oRow, lngCantItem))
   '               modtCompraDetItem.AcceptChanges()
   '               mboolICE_IEHD = True
   '            End If
   '         End If

   '      End While

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '   End Try
   'End Sub

   'Private Function PlanTipoActEcoIdFind(ByVal lngItemId As Long, ByRef TipoActEco2Id As Long) As Long
   '   Dim oItem As New clsItem(clsAppInfo.ConnectString)
   '   Dim oPlanGrupo As New clsPlanGrupo(clsAppInfo.ConnectString)

   '   PlanTipoActEcoIdFind = 0

   '   Try
   '      With oItem
   '         .ItemId = lngItemId

   '         If .FindByPK Then
   '            With oPlanGrupo
   '               .PlanGrupoId = oItem.PlanGrupoId

   '               If .FindByPK Then
   '                  TipoActEco2Id = .TipoActEco2Id
   '                  Return .TipoActEco1Id
   '               End If
   '            End With
   '         End If
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oItem.Dispose()
   '      oPlanGrupo.Dispose()

   '   End Try
   'End Function

   'Private Function ItemDesFind(ByVal lngItemId As Long, ByRef strItemCod As String, ByRef strItemDesAbr As String, ByRef lngTipoItemId As Long) As String
   '   Dim oItem As New clsItem(clsAppInfo.ConnectString)

   '   ItemDesFind = ""

   '   Try
   '      With oItem
   '         .ItemId = lngItemId

   '         If .FindByPK Then
   '            ItemDesFind = .ItemDes
   '            strItemCod = ToStr(.ItemCod)
   '            strItemDesAbr = ToStr(.ItemDesAbr)
   '            lngTipoItemId = .TipoItemId
   '            lngTipoItemId = .TipoTasaId
   '         End If
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oItem.Dispose()

   '   End Try
   'End Function

   'Private Function MedidaDesFind(ByVal lngMedidaId As Long) As String
   '   Dim oMedida As New clsMedida(clsAppInfo.ConnectString)

   '   MedidaDesFind = ""

   '   Try
   '      With oMedida
   '         .MedidaId = lngMedidaId

   '         If .FindByPK Then
   '            MedidaDesFind = .MedidaDes
   '         End If
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oMedida.Dispose()

   '   End Try
   'End Function

   'Private Sub grdMainRefresh()
   '   Dim oDataTable As New Janus.Windows.GridEX.GridEXTable
   '   Dim oDataTableDet As New Janus.Windows.GridEX.GridEXTable

   '   grdMain.RetrieveStructure()

   '   Call ChildrenLoad(oDataTable)  ' CompraDet
   '   grdMain.RootTable.ChildTables.Add(oDataTable)

   '   Call ChildrenItemLoad(oDataTableDet) ' CompraDetItem
   '   grdMain.RootTable.ChildTables(0).ChildTables.Add(oDataTableDet)

   '   Call grdMainInit()

   'End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Detalle de Compras"

         .RootTable.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.True
         .RootTable.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
         .RootTable.HeaderLines = 2
         .RootTable.GridEX.AlternatingColors = False
         .RootTable.RowHeight = 20

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True
         .RootTable.Columns("Sel").Visible = mboolAdding

         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("GestionId").Visible = False

         .RootTable.Columns("Gestion").Caption = "Gestión" & vbCrLf & " "
         .RootTable.Columns("Gestion").Width = 70
         .RootTable.Columns("Gestion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Gestion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Gestion").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("CompraNro").Caption = "Compra" & vbCrLf & " "
         .RootTable.Columns("CompraNro").Width = 70
         .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("CompraOrden").Caption = "Nro. Orden" & vbCrLf & " "
         .RootTable.Columns("CompraOrden").Width = 80
         .RootTable.Columns("CompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraOrden").EditType = Janus.Windows.GridEX.EditType.NoEdit

         ''.RootTable.Columns("IvaFac").Caption = ""
         ''.RootTable.Columns("IvaFac").Width = 20

         .RootTable.Columns("Fecha").Caption = "Fecha" & vbCrLf & " "
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").EditType = Janus.Windows.GridEX.EditType.NoEdit

         ''.RootTable.Columns("AlmacenId").Visible = False

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda" & vbCrLf & " "
         .RootTable.Columns("MonedaDes").Width = 80
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MonedaDes").EditType = Janus.Windows.GridEX.EditType.NoEdit

         '.RootTable.Columns("TipoCambio").Caption = "Tipo Cambio" & vbCrLf & "It. Saldo"
         .RootTable.Columns("TipoCambio").Caption = "Tipo Cambio"
         .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
         .RootTable.Columns("TipoCambio").Width = 80
         .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("TipoCambio").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("MontoOrg").Caption = "Total Compra"
         .RootTable.Columns("MontoOrg").FormatString = DecimalMask()
         .RootTable.Columns("MontoOrg").Width = 80
         .RootTable.Columns("MontoOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoOrg").Visible = False
         .RootTable.Columns("MontoOrg").EditType = Janus.Windows.GridEX.EditType.NoEdit

         '.RootTable.Columns("MontoBru").Caption = "Monto Compra" & vbCrLf & "It. Cant."
         .RootTable.Columns("MontoBru").Caption = "Monto Compra"
         .RootTable.Columns("MontoBru").FormatString = DecimalMask()
         .RootTable.Columns("MontoBru").Width = 100
         .RootTable.Columns("MontoBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoBru").EditType = Janus.Windows.GridEX.EditType.NoEdit

         '.RootTable.Columns("MontoFac").Caption = "M. Facturado" & vbCrLf & "It.Precio"
         .RootTable.Columns("MontoFac").Caption = "M. Facturado"
         .RootTable.Columns("MontoFac").FormatString = DecimalMask()
         .RootTable.Columns("MontoFac").Width = 100
         .RootTable.Columns("MontoFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoFac").EditType = Janus.Windows.GridEX.EditType.NoEdit

         '.RootTable.Columns("SaldoFactura").Caption = "Saldo Factura" & vbCrLf & "It. Importe"
         .RootTable.Columns("SaldoFactura").Caption = "Saldo Factura"
         .RootTable.Columns("SaldoFactura").FormatString = DecimalMask()
         .RootTable.Columns("SaldoFactura").Width = 100
         .RootTable.Columns("SaldoFactura").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SaldoFactura").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SaldoFactura").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("MontoFacturar").Caption = "Monto Facturar" & vbCrLf & " "
         .RootTable.Columns("MontoFacturar").FormatString = DecimalMask()
         .RootTable.Columns("MontoFacturar").Width = 100
         .RootTable.Columns("MontoFacturar").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoFacturar").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         '.RootTable.Columns("MontoFacturar").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("MontoFacturarBru").Caption = "Monto Compra" & vbCrLf & " "
         .RootTable.Columns("MontoFacturarBru").FormatString = DecimalMask()
         .RootTable.Columns("MontoFacturarBru").Width = 100
         .RootTable.Columns("MontoFacturarBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoFacturarBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoFacturarBru").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("MontoFacturarBru").Visible = False

         ''Monto Factura
         .RootTable.Columns("MontoPorFac").Caption = "Factura PorFac" & vbCrLf & " "
         .RootTable.Columns("MontoPorFac").FormatString = DecimalMask()
         .RootTable.Columns("MontoPorFac").Visible = False

         .RootTable.Columns("MontoPorFacAFac").Caption = "Factura Monto" & vbCrLf & " "
         .RootTable.Columns("MontoPorFacAFac").FormatString = DecimalMask()
         .RootTable.Columns("MontoPorFacAFac").Width = 90
         .RootTable.Columns("MontoPorFacAFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoPorFacAFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoPorFacAFac").EditType = Janus.Windows.GridEX.EditType.NoEdit

         ''Descuentos
         .RootTable.Columns("MontoDes").Caption = "Exento" & vbCrLf & " "
         .RootTable.Columns("MontoDes").FormatString = DecimalMask()
         .RootTable.Columns("MontoDes").Visible = False

         .RootTable.Columns("MontoDesAFac").Caption = "Descuento" & vbCrLf & " "
         .RootTable.Columns("MontoDesAFac").FormatString = DecimalMask()
         .RootTable.Columns("MontoDesAFac").Width = 90
         .RootTable.Columns("MontoDesAFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoDesAFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoDesAFac").EditType = Janus.Windows.GridEX.EditType.NoEdit

         ''Exentos
         .RootTable.Columns("FactDifExento").Caption = "Exento" & vbCrLf & " "
         .RootTable.Columns("FactDifExento").FormatString = DecimalMask()
         .RootTable.Columns("FactDifExento").Visible = False

         .RootTable.Columns("MontoExentoFac").Caption = "Exento" & vbCrLf & " "
         .RootTable.Columns("MontoExentoFac").FormatString = DecimalMask()
         .RootTable.Columns("MontoExentoFac").Visible = False

         .RootTable.Columns("SaldoExento").Caption = "Exento" & vbCrLf & " "
         .RootTable.Columns("SaldoExento").FormatString = DecimalMask()
         .RootTable.Columns("SaldoExento").Width = 90
         .RootTable.Columns("SaldoExento").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SaldoExento").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SaldoExento").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("SaldoExento").Visible = False

         .RootTable.Columns("MontoExentoAFac").Caption = "Exento" & vbCrLf & " "
         .RootTable.Columns("MontoExentoAFac").FormatString = DecimalMask()
         .RootTable.Columns("MontoExentoAFac").Width = 90
         .RootTable.Columns("MontoExentoAFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoExentoAFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         ''.RootTable.Columns("MontoExentoAFac").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("MontoExentoAFac").Visible = mboolExento

         Call AddConditionalFormatting()
         Call grdMainExpand()

         ''.ExpandRecords()

         ''.RootTable.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.True

      End With
   End Sub

   Private Sub grdMainExpand()
      With grdMain
         ''.ColumnAutoResize = True
         '.RootTable.ChildTables(0).HierarchicalMode = Janus.Windows.GridEX.HierarchicalMode.UseChildTables ' 
         '.RootTable.ChildTables(0).ChildTables(0).HierarchicalMode = Janus.Windows.GridEX.HierarchicalMode.UseChildTables 'UseChildTables
         '.CollapseRecords()

         'Dim tblToExpand As Janus.Windows.GridEX.GridEXTable

         'tblToExpand = .RootTable

         '.ExpandRecords(tblToExpand)

      End With
   End Sub

   Private Sub grdMainExpander()
      ''If grdMain.RowCount > 0 Then
      ''   If grdMain.RootTable.ChildTables(0).GridEX.Hierarchical Then

      ''      grdMain.RootTable.ChildTables(0).GridEX.Hierarchical = False

      ''      grdMain.RootTable.ChildTables(0).HierarchicalMode = Janus.Windows.GridEX.HierarchicalMode.UseChildTables ' 
      ''      grdMain.RootTable.ChildTables(0).ChildTables(0).HierarchicalMode = Janus.Windows.GridEX.HierarchicalMode.UseChildTables 'UseChildTables
      ''      grdMain.CollapseRecords()

      ''      Dim tblToExpand As Janus.Windows.GridEX.GridEXTable

      ''      tblToExpand = grdMain.RootTable
      ''      grdMain.ExpandRecords(tblToExpand)

      ''   Else
      ''      grdMain.RootTable.ChildTables(0).GridEX.Hierarchical = True
      ''      grdMain.RootTable.ChildTables(0).HierarchicalMode = Janus.Windows.GridEX.HierarchicalMode.UseChildTables ' 
      ''      grdMain.RootTable.ChildTables(0).ChildTables(0).HierarchicalMode = Janus.Windows.GridEX.HierarchicalMode.UseChildTables 'UseChildTables
      ''      grdMain.CollapseRecords()

      ''      Dim tblToExpand As Janus.Windows.GridEX.GridEXTable

      ''      tblToExpand = grdMain.RootTable
      ''      grdMain.ExpandRecords(tblToExpand)
      ''   End If

      ''End If

   End Sub

   Private Sub ChildrenLoad(ByRef odatatable As Janus.Windows.GridEX.GridEXTable)
      Try

         odatatable.Columns.Add("Sel")
         odatatable.Columns.Add("CompraId")
         odatatable.Columns.Add("CompraDetId")
         odatatable.Columns.Add("ItemId")
         odatatable.Columns.Add("ItemCod")
         odatatable.Columns.Add("ItemDes")
         odatatable.Columns.Add("MedidaId")
         odatatable.Columns.Add("MedidaDes")
         odatatable.Columns.Add("MonedaId")
         odatatable.Columns.Add("TipoCambio")
         odatatable.Columns.Add("CantImpFac")
         odatatable.Columns.Add("CantidadFac")
         odatatable.Columns.Add("Cantidad")
         odatatable.Columns.Add("PrecioOrg")
         odatatable.Columns.Add("Precio")
         odatatable.Columns.Add("Importe")
         odatatable.Columns.Add("MontoRec")
         odatatable.Columns.Add("MontoDes")
         odatatable.Columns.Add("ImporteNet")
         odatatable.Columns.Add("PorImporte", Janus.Windows.GridEX.ColumnType.CheckBox)
         odatatable.Columns.Add("EditImporte")
         odatatable.Columns.Add("EditPrecio")
         odatatable.Columns.Add("PrecioFacOrg")
         odatatable.Columns.Add("ImporteFac")

         odatatable.Columns.Add("PrecioFactura")
         odatatable.Columns.Add("PrecioPorFac")
         odatatable.Columns.Add("ImportePorFacFac")
         odatatable.Columns.Add("ImportePorFac")

         odatatable.Columns.Add("PrecioDes")
         odatatable.Columns.Add("ImporteDesFac")
         odatatable.Columns.Add("ImporteDes")

         odatatable.Columns.Add("IceIehd")
         odatatable.Columns.Add("ImporteIceIehdFac")
         odatatable.Columns.Add("ImporteIceIehd")
         odatatable.Columns.Add("CompraDetDes")

         odatatable.Columns.Add("TipoActEco1Id")
         odatatable.Columns.Add("TipoActEco2Id")
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("MontoPorFacAFac"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0)
      fc.FormatStyle.BackColor = Color.LightPink
      fc.TargetColumn = grdMain.RootTable.Columns("MontoPorFacAFac")
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("MontoPorFacAFac"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0)
      fc.FormatStyle.BackColor = Color.LightPink
      fc.TargetColumn = grdMain.RootTable.Columns("MontoDesAFac")
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("MontoPorFacAFac"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0)
      fc.FormatStyle.BackColor = Color.LightPink
      fc.TargetColumn = grdMain.RootTable.Columns("MontoExentoAFac")
      grdMain.RootTable.FormatConditions.Add(fc)


   End Sub

   Private Sub MontoPagarFactura()

      Dim decImporteBru As Decimal = 0

      Dim decMontoCompra As Decimal = 0
      Dim decMontoCompraPorFac As Decimal = 0
      Dim decMontoCompraDes As Decimal = 0
      Dim decMontoCompraBru As Decimal = 0

      Dim decMontoTotalBs As Decimal = 0
      Dim decMontoTotalUs As Decimal = 0

      Dim decMontoPorFacBs As Decimal = 0
      Dim decMontoPorFacUs As Decimal = 0

      Dim decMontoDesBs As Decimal = 0
      Dim decMontoDesUs As Decimal = 0

      Dim decTot_MontoTotalBs As Decimal = 0
      Dim decTot_MontoPorFacBs As Decimal = 0
      Dim decTot_MontoDesBs As Decimal = 0
      Dim decTot_MontoExentoBs As Decimal = 0

      Dim decPor As Double = 0


      Try

         grdMain.UpdateData()
         For Each oRow As DataRow In moDataTable.Rows
            decMontoCompraBru = 0
            decMontoCompra = 0
            decMontoCompraPorFac = 0
            decMontoCompraDes = 0

            If (oRow("MontoFacturar") > 0) Then
               decPor = (oRow("MontoFacturar") / ToDivByCero(oRow("MontoBru")))
            Else
               decPor = 0
            End If

            oRow("MontoFacturarBru") = oRow("MontoBru") * decPor
            oRow("MontoPorFacAFac") = oRow("MontoPorFac") * decPor
            oRow("MontoDesAFac") = oRow("MontoDes") * decPor

            If oRow("MonedaId") = 1 Then
               decMontoTotalBs += oRow("MontoFacturar")
               decMontoPorFacBs += oRow("MontoPorFacAFac")
               decMontoDesBs += oRow("MontoDesAFac")

               decTot_MontoTotalBs += ToDecimalDos(oRow("MontoFacturar"))
               decTot_MontoPorFacBs += ToDecimalDos(oRow("MontoPorFacAFac"))
               decTot_MontoDesBs += ToDecimalDos(oRow("MontoDesAFac"))
               decTot_MontoExentoBs += ToDecimalDos(oRow("MontoExentoAFac"))

            ElseIf oRow("MonedaId") = 2 Then
               decMontoTotalUs += oRow("MontoFacturar")
               decMontoPorFacUs += oRow("MontoPorFacAFac")
               decMontoDesUs += oRow("MontoDesAFac")

               decTot_MontoTotalBs += ToDecimalDos(oRow("MontoFacturar") * ToDecimalDos(txtTipoCambio.Text))
               decTot_MontoPorFacBs += ToDecimalDos(oRow("MontoPorFacAFac") * ToDecimalDos(txtTipoCambio.Text))
               decTot_MontoDesBs += ToDecimalDos(oRow("MontoDesAFac") * ToDecimalDos(txtTipoCambio.Text))
               decTot_MontoExentoBs += ToDecimalDos(oRow("MontoExentoAFac") * ToDecimalDos(txtTipoCambio.Text))
            End If

         Next

         txtMontoBruBs.Text = ToDecimal(decMontoTotalBs)
         txtMontoBruSus.Text = ToDecimal(decMontoTotalUs)
         txtMontoPorFacBs.Text = ToDecimal(decMontoPorFacBs)
         txtMontoPorFacSus.Text = ToDecimal(decMontoPorFacUs)

         ''txtFacturaMonto.Text = ToDecimalDos(decMontoPorFacBs + ToDecimalDos(decMontoPorFacUs * ToDecimalDos(txtTipoCambio.Text)))
         ''txtIceIehd.Text = ToDecimalDos(decMontoIceIehdBs + (decMontoIceIehdUs * ToDecimalDos(txtTipoCambio.Text)))
         ''txtDescuento.Text = ToDecimalDos(decMontoDesBs + (decMontoDesUs * ToDecimalDos(txtTipoCambio.Text)))

         If mboolAdding Then
            txtFacturaMonto.Text = ToDecimalDos(decTot_MontoPorFacBs)
            txtExento.Text = ToDecimalDos(decTot_MontoExentoBs)
            txtDescuento.Text = ToDecimalDos(decTot_MontoDesBs)

            txtDescuento.Text = ToDecimalDos(ToDecimalDos(txtMontoDes.Text) + ToDecimalDos(txtDescuento.Text))

         End If

         grdMain.Update()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try

   End Sub

   'Private Sub mdtCompraDetItemRefresh(ByVal oRow As DataRow)
   '   ''CompraDetItem
   '   Dim lngCantItem As Long = 0
   '   Dim lngTotal As Long = 3
   '   Try

   '      For Each oRowCompraDet As DataRow In modtCompraDetItem.Rows
   '         If oRowCompraDet("CompraDetId") = oRow("CompraDetId") Then
   '            If oRowCompraDet("Nro") = 1 Then
   '               oRowCompraDet("Precio") = oRow("PrecioFactura")
   '               oRowCompraDet("Importe") = oRow("ImportePorFac")

   '            ElseIf oRowCompraDet("Nro") = 2 Then
   '               oRowCompraDet("Precio") = oRow("PrecioDes")
   '               oRowCompraDet("Importe") = oRow("ImporteDes")

   '            ElseIf oRowCompraDet("Nro") = 3 Then
   '               oRowCompraDet("Precio") = oRow("IceIehd")
   '               oRowCompraDet("Importe") = oRow("ImporteIceIehd")
   '            End If
   '         End If
   '      Next

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '   End Try
   'End Sub

   Private Sub grdMainCheckAll(ByVal boolValue As Boolean)

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         oRow.BeginEdit()
         If boolValue Then
            oRow.IsChecked = True
            oRow.Cells("MontoFacturar").Value = oRow.Cells("SaldoFactura").Value
            oRow.Cells("MontoExentoAFac").Value = oRow.Cells("SaldoExento").Value
         Else
            oRow.IsChecked = False
            oRow.Cells("MontoFacturar").Value = 0
            oRow.Cells("MontoExentoAFac").Value = 0
         End If
         oRow.EndEdit()
      Next

      Call MontoPagarFactura()

   End Sub

   Private Sub grdMainCheckFacNOVal()

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         oRow.BeginEdit()

         If oRow.IsChecked Then
            oRow.Cells("MontoFacturar").Value = oRow.Cells("SaldoFactura").Value
            oRow.Cells("MontoExentoAFac").Value = oRow.Cells("SaldoExento").Value
         Else
            oRow.Cells("MontoFacturar").Value = 0
            oRow.Cells("MontoExentoAFac").Value = 0
         End If

         oRow.EndEdit()
      Next

      Call MontoPagarFactura()

   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub grdMain_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdMain.KeyPress
      If Not grdMain.CurrentColumn Is Nothing Then
         If (ToStr(grdMain.RootTable.Columns(grdMain.Col).DataMember) = "MontoFacturar") Or _
            (ToStr(grdMain.RootTable.Columns(grdMain.Col).DataMember) = "MontoExentoAFac") Then
            If mstrSepDecimal = "," Then
               If e.KeyChar = "." Then
                  e.Handled = True
                  SendKeys.Send(",")
               End If
            End If
         End If
      End If
   End Sub

   Private Sub grdMain_CellUpdated(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdMain.CellUpdated
      Call MontoPagarFactura()
   End Sub

   'Private Sub grdMain_CellValueChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdMain.CellValueChanged
   '   If ToStr(grdMain.SelectedItems(0).GetRow.Table.DataMember = "relacion") Then
   '      If ToStr(grdMain.SelectedItems(0).GetRow.Table.Columns(grdMain.Col).DataMember) = "PorImporte" Then
   '         If grdMain.GetValue("PorImporte") Then

   '            grdMain.SetValue("PorImporte", True)
   '            grdMain.SetValue("Cantidad", 1)
   '            grdMain.SetValue("Precio", grdMain.GetValue("ImporteFac"))
   '            grdMain.SetValue("Importe", grdMain.GetValue("ImporteFac"))

   '            grdMain.SetValue("Sel", True)
   '            grdMain.SetValue("CantImpFac", grdMain.GetValue("ImporteFac"))
   '         Else

   '            grdMain.SetValue("Precio", grdMain.GetValue("PrecioFacOrg"))
   '            If grdMain.GetValue("Sel") Then
   '               grdMain.SetValue("Cantidad", grdMain.GetValue("CantidadFac"))
   '            Else
   '               grdMain.SetValue("Cantidad", 0)
   '            End If
   '            ''grdMain.SetValue("Cantidad", 0)
   '            grdMain.SetValue("CantImpFac", grdMain.GetValue("CantidadFac"))
   '            grdMain.SetValue("PorImporte", False)
   '         End If

   '         grdMain.UpdateData()
   '         ''Call MontoPagarFactura()
   '      End If

   '   End If
   'End Sub

   Private Sub grdMain_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grdMain.EditingCell
      If mboolAdding Then
         If mboolEditarPrecio Then
            If e.Column.DataMember = "MontoFacturar" Then
               If ToDecimal(grdMain.GetValue("SaldoFactura")) <= 0 Then
                  e.Cancel = True
               End If
            End If

            If e.Column.DataMember = "MontoExentoAFac" Then
               If ToDecimal(grdMain.GetValue("SaldoExento")) <= 0 Then
                  e.Cancel = True
               End If
            End If

         Else
            e.Cancel = True
         End If
      Else
         e.Cancel = True
      End If

   End Sub

   Private Sub grdMain_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdMain.UpdatingCell

      If e.Column.DataMember = "MontoFacturar" Then
         If ToDecimal(e.Value) = 0 Then
            e.Value = 0
            'grdMain.SetValue("Precio", grdMain.GetValue("PrecioFacOrg"))
            grdMain.SetValue("Sel", False)

         ElseIf ToDecimal(e.Value) < 0 Then
            e.Cancel = True
            MessageBox.Show("Monto Negativo Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         ElseIf (ToDecimal(e.Value) > ToDecimal(grdMain.GetValue("SaldoFactura"))) Then
            e.Cancel = True
            MessageBox.Show("Monto Superior al Saldo ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Else
            grdMain.SetValue("Sel", True)
         End If
      End If

      If e.Column.DataMember = "MontoExentoAFac" Then
         If ToDecimal(e.Value) < 0 Then
            e.Cancel = True
            MessageBox.Show("Exento Negativo Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         ElseIf (ToDecimal(e.Value) > ToDecimal(grdMain.GetValue("SaldoExento"))) Then
            e.Cancel = True
            MessageBox.Show("Exento Superior al Saldo ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      End If

   End Sub

   Private Sub grdMain_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdMain.RowCheckStateChanged
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            Call grdMainCheckAll(True)
         ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            Call grdMainCheckAll(False)
         End If

      Else
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            grdMain.SetValue("MontoFacturar", grdMain.GetValue("SaldoFactura"))
            grdMain.SetValue("MontoExentoAFac", grdMain.GetValue("SaldoExento"))
         ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            grdMain.SetValue("MontoFacturar", 0)
            grdMain.SetValue("MontoExentoAFac", 0)
         End If

         Call MontoPagarFactura()

      End If
   End Sub

#End Region

End Class