Public Class frmAnticipoEdit
   Inherits System.Windows.Forms.Form

   Private moAnticipo As clsAnticipo

   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngTipoPlanId As Long
   Private mboolTieneComp As Boolean
   Private mboolAplicarITF As Boolean
   Private mlngCompChequeId As Long

   Private mdecMontoOrg As Decimal
   Private mdecPosSuc As Decimal = 0

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditGrid As Boolean
   Friend WithEvents chkSinFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtAnticipoOrden As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents grpSucursal As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Private mlngID As Long

   WriteOnly Property NewRecord() As Boolean
      Set(ByVal Value As Boolean)
         mboolAdding = Value
      End Set
   End Property

   WriteOnly Property Editing() As Boolean
      Set(ByVal Value As Boolean)
         mboolEditing = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
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

   WriteOnly Property DataObject() As clsAnticipo
      Set(ByVal Value As clsAnticipo)
         moAnticipo = Value
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

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents grpDatos As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents grpObservacion As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Anular As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents chkProveedor As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents txtAnticipoObs As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtAnticipoDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtAnticipoNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtAnticipoId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents cboTipoAnticipo As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblPedCompra As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents lblImporte As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents grpMonto As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents cboPedCompra As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents dtpPedCompraFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents txtPedCompraTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPedCompraDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPedCompraMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPedCompraAlmacenDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPedCompraMonedaDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtMontoAnt As Janus.Windows.GridEX.EditControls.NumericEditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents txtMontoDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoPen As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents AnticipoDet As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents AnticipoDet1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents txtMonedaDesOrg As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtMontoOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents txtAnticipoDesOrg As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtTipoCambioOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label24 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaOrg As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label25 As System.Windows.Forms.Label
   Friend WithEvents Label26 As System.Windows.Forms.Label
   Friend WithEvents cboAnticipo As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblAnticipo As System.Windows.Forms.Label
   Friend WithEvents txtMontoDesOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents grbPedCompra As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grbAnticipo As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents txtMontoPenOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblMontoPen As System.Windows.Forms.Label
   Friend WithEvents lblMontoDes As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtPedCompraNroOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Anular1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnticipoEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMonto = New Janus.Windows.EditControls.UIGroupBox
      Me.txtMontoPen = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.lblMontoPen = New System.Windows.Forms.Label
      Me.txtMontoDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.lblMontoDes = New System.Windows.Forms.Label
      Me.txtMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.grpObservacion = New Janus.Windows.EditControls.UIGroupBox
      Me.chkSinFac = New Janus.Windows.EditControls.UICheckBox
      Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
      Me.txtAnticipoObs = New Janus.Windows.GridEX.EditControls.EditBox
      Me.grpDatos = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.lblCentroCosto = New System.Windows.Forms.Label
      Me.chkProveedor = New Janus.Windows.EditControls.UICheckBox
      Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtAnticipoDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboPedCompra = New Janus.Windows.EditControls.UIComboBox
      Me.lblPedCompra = New System.Windows.Forms.Label
      Me.cboAnticipo = New Janus.Windows.EditControls.UIComboBox
      Me.lblAnticipo = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtAnticipoOrden = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboTipoAnticipo = New Janus.Windows.EditControls.UIComboBox
      Me.Label17 = New System.Windows.Forms.Label
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.txtAnticipoNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtAnticipoId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.grbPedCompra = New Janus.Windows.EditControls.UIGroupBox
      Me.txtMontoAnt = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtPedCompraMonedaDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPedCompraAlmacenDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtPedCompraMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.lblImporte = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.txtPedCompraDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPedCompraTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.dtpPedCompraFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.grbAnticipo = New Janus.Windows.EditControls.UIGroupBox
      Me.txtPedCompraNroOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label20 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.txtMontoPenOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtMontoDesOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtMonedaDesOrg = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtMontoOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label22 = New System.Windows.Forms.Label
      Me.Label23 = New System.Windows.Forms.Label
      Me.txtAnticipoDesOrg = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtTipoCambioOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label24 = New System.Windows.Forms.Label
      Me.dtpFechaOrg = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label25 = New System.Windows.Forms.Label
      Me.Label26 = New System.Windows.Forms.Label
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.AnticipoDet1 = New Janus.Windows.UI.CommandBars.UICommand("AnticipoDet")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Anular1 = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Anular = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.AnticipoDet = New Janus.Windows.UI.CommandBars.UICommand("AnticipoDet")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.grpSucursal = New Janus.Windows.EditControls.UIGroupBox
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.lblSucursal = New System.Windows.Forms.Label
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMonto, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMonto.SuspendLayout()
      CType(Me.grpObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpObservacion.SuspendLayout()
      CType(Me.grpDatos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpDatos.SuspendLayout()
      CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.grbPedCompra, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbPedCompra.SuspendLayout()
      CType(Me.grbAnticipo, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbAnticipo.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpSucursal.SuspendLayout()
      Me.SuspendLayout()
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpSucursal)
      Me.bcgMain.Controls.Add(Me.grpMonto)
      Me.bcgMain.Controls.Add(Me.grpObservacion)
      Me.bcgMain.Controls.Add(Me.grpDatos)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Controls.Add(Me.grbPedCompra)
      Me.bcgMain.Controls.Add(Me.grbAnticipo)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(752, 406)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMonto
      '
      Me.grpMonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpMonto.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMonto.Controls.Add(Me.txtMontoPen)
      Me.grpMonto.Controls.Add(Me.lblMontoPen)
      Me.grpMonto.Controls.Add(Me.txtMontoDes)
      Me.grpMonto.Controls.Add(Me.lblMontoDes)
      Me.grpMonto.Controls.Add(Me.txtMonto)
      Me.grpMonto.Controls.Add(Me.Label14)
      Me.grpMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMonto.Location = New System.Drawing.Point(8, 272)
      Me.grpMonto.Name = "grpMonto"
      Me.grpMonto.Size = New System.Drawing.Size(736, 40)
      Me.grpMonto.TabIndex = 31
      Me.grpMonto.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtMontoPen
      '
      Me.txtMontoPen.BackColor = System.Drawing.Color.MistyRose
      Me.txtMontoPen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPen.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPen.FormatString = "##,##0.000"
      Me.txtMontoPen.Location = New System.Drawing.Point(628, 12)
      Me.txtMontoPen.Name = "txtMontoPen"
      Me.txtMontoPen.ReadOnly = True
      Me.txtMontoPen.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoPen.TabIndex = 34
      Me.txtMontoPen.TabStop = False
      Me.txtMontoPen.Text = "0,000"
      Me.txtMontoPen.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPen.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPen.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblMontoPen
      '
      Me.lblMontoPen.BackColor = System.Drawing.Color.Transparent
      Me.lblMontoPen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMontoPen.Location = New System.Drawing.Point(464, 16)
      Me.lblMontoPen.Name = "lblMontoPen"
      Me.lblMontoPen.Size = New System.Drawing.Size(160, 16)
      Me.lblMontoPen.TabIndex = 243
      Me.lblMontoPen.Text = "Monto Pendiente a Descargar"
      '
      'txtMontoDes
      '
      Me.txtMontoDes.BackColor = System.Drawing.Color.MistyRose
      Me.txtMontoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoDes.FormatString = "##,##0.000"
      Me.txtMontoDes.Location = New System.Drawing.Point(352, 12)
      Me.txtMontoDes.Name = "txtMontoDes"
      Me.txtMontoDes.ReadOnly = True
      Me.txtMontoDes.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoDes.TabIndex = 33
      Me.txtMontoDes.TabStop = False
      Me.txtMontoDes.Text = "0,000"
      Me.txtMontoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoDes.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblMontoDes
      '
      Me.lblMontoDes.BackColor = System.Drawing.Color.Transparent
      Me.lblMontoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMontoDes.Location = New System.Drawing.Point(240, 16)
      Me.lblMontoDes.Name = "lblMontoDes"
      Me.lblMontoDes.Size = New System.Drawing.Size(108, 16)
      Me.lblMontoDes.TabIndex = 241
      Me.lblMontoDes.Text = "Monto Descargado"
      '
      'txtMonto
      '
      Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMonto.FormatString = "##,##0.000"
      Me.txtMonto.Location = New System.Drawing.Point(92, 12)
      Me.txtMonto.Name = "txtMonto"
      Me.txtMonto.Size = New System.Drawing.Size(100, 20)
      Me.txtMonto.TabIndex = 32
      Me.txtMonto.Text = "0,000"
      Me.txtMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(8, 16)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(80, 16)
      Me.Label14.TabIndex = 239
      Me.Label14.Text = "Mto. Anticipo"
      '
      'grpObservacion
      '
      Me.grpObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpObservacion.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpObservacion.Controls.Add(Me.chkSinFac)
      Me.grpObservacion.Controls.Add(Me.chkConFac)
      Me.grpObservacion.Controls.Add(Me.txtAnticipoObs)
      Me.grpObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpObservacion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpObservacion.Location = New System.Drawing.Point(8, 320)
      Me.grpObservacion.Name = "grpObservacion"
      Me.grpObservacion.Size = New System.Drawing.Size(736, 76)
      Me.grpObservacion.TabIndex = 35
      Me.grpObservacion.Text = "Glosa"
      Me.grpObservacion.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkSinFac
      '
      Me.chkSinFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkSinFac.BackColor = System.Drawing.Color.Transparent
      Me.chkSinFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSinFac.Checked = True
      Me.chkSinFac.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkSinFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSinFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkSinFac.Location = New System.Drawing.Point(60, 0)
      Me.chkSinFac.Name = "chkSinFac"
      Me.chkSinFac.Size = New System.Drawing.Size(32, 16)
      Me.chkSinFac.TabIndex = 279
      Me.chkSinFac.Text = "I"
      Me.chkSinFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkConFac
      '
      Me.chkConFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkConFac.BackColor = System.Drawing.Color.Transparent
      Me.chkConFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkConFac.Checked = True
      Me.chkConFac.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkConFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkConFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkConFac.Location = New System.Drawing.Point(112, 0)
      Me.chkConFac.Name = "chkConFac"
      Me.chkConFac.Size = New System.Drawing.Size(32, 16)
      Me.chkConFac.TabIndex = 278
      Me.chkConFac.Text = "F"
      Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtAnticipoObs
      '
      Me.txtAnticipoObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtAnticipoObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAnticipoObs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAnticipoObs.Location = New System.Drawing.Point(8, 16)
      Me.txtAnticipoObs.Multiline = True
      Me.txtAnticipoObs.Name = "txtAnticipoObs"
      Me.txtAnticipoObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtAnticipoObs.Size = New System.Drawing.Size(720, 52)
      Me.txtAnticipoObs.TabIndex = 37
      Me.txtAnticipoObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAnticipoObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'grpDatos
      '
      Me.grpDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpDatos.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpDatos.Controls.Add(Me.cboCentroCosto)
      Me.grpDatos.Controls.Add(Me.lblCentroCosto)
      Me.grpDatos.Controls.Add(Me.chkProveedor)
      Me.grpDatos.Controls.Add(Me.cboProveedor)
      Me.grpDatos.Controls.Add(Me.Label4)
      Me.grpDatos.Controls.Add(Me.Label1)
      Me.grpDatos.Controls.Add(Me.txtAnticipoDes)
      Me.grpDatos.Controls.Add(Me.cboPedCompra)
      Me.grpDatos.Controls.Add(Me.lblPedCompra)
      Me.grpDatos.Controls.Add(Me.cboAnticipo)
      Me.grpDatos.Controls.Add(Me.lblAnticipo)
      Me.grpDatos.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpDatos.Location = New System.Drawing.Point(8, 104)
      Me.grpDatos.Name = "grpDatos"
      Me.grpDatos.Size = New System.Drawing.Size(736, 64)
      Me.grpDatos.TabIndex = 8
      Me.grpDatos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(452, 36)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(276, 20)
      Me.cboCentroCosto.TabIndex = 237
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCentroCosto.Location = New System.Drawing.Point(400, 40)
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Size = New System.Drawing.Size(44, 16)
      Me.lblCentroCosto.TabIndex = 238
      Me.lblCentroCosto.Text = "C. C. "
      '
      'chkProveedor
      '
      Me.chkProveedor.BackColor = System.Drawing.Color.Transparent
      Me.chkProveedor.Checked = True
      Me.chkProveedor.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkProveedor.Location = New System.Drawing.Point(76, 16)
      Me.chkProveedor.Name = "chkProveedor"
      Me.chkProveedor.Size = New System.Drawing.Size(16, 16)
      Me.chkProveedor.TabIndex = 9
      Me.chkProveedor.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboProveedor
      '
      cboProveedor_DesignTimeLayout.LayoutString = resources.GetString("cboProveedor_DesignTimeLayout.LayoutString")
      Me.cboProveedor.DesignTimeLayout = cboProveedor_DesignTimeLayout
      Me.cboProveedor.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProveedor.Location = New System.Drawing.Point(92, 12)
      Me.cboProveedor.Name = "cboProveedor"
      Me.cboProveedor.SelectedIndex = -1
      Me.cboProveedor.SelectedItem = Nothing
      Me.cboProveedor.Size = New System.Drawing.Size(280, 20)
      Me.cboProveedor.TabIndex = 10
      Me.cboProveedor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboProveedor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 16)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(80, 16)
      Me.Label4.TabIndex = 236
      Me.Label4.Text = "Proveedor"
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 40)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(80, 16)
      Me.Label1.TabIndex = 214
      Me.Label1.Text = "Por Concepto"
      '
      'txtAnticipoDes
      '
      Me.txtAnticipoDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtAnticipoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAnticipoDes.Location = New System.Drawing.Point(92, 36)
      Me.txtAnticipoDes.MaxLength = 1000
      Me.txtAnticipoDes.Multiline = True
      Me.txtAnticipoDes.Name = "txtAnticipoDes"
      Me.txtAnticipoDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtAnticipoDes.Size = New System.Drawing.Size(280, 20)
      Me.txtAnticipoDes.TabIndex = 13
      Me.txtAnticipoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAnticipoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPedCompra
      '
      Me.cboPedCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboPedCompra.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPedCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPedCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPedCompra.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPedCompra.Location = New System.Drawing.Point(628, 12)
      Me.cboPedCompra.Name = "cboPedCompra"
      Me.cboPedCompra.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPedCompra.Size = New System.Drawing.Size(100, 20)
      Me.cboPedCompra.TabIndex = 11
      Me.cboPedCompra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblPedCompra
      '
      Me.lblPedCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblPedCompra.BackColor = System.Drawing.Color.Transparent
      Me.lblPedCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPedCompra.Location = New System.Drawing.Point(568, 16)
      Me.lblPedCompra.Name = "lblPedCompra"
      Me.lblPedCompra.Size = New System.Drawing.Size(60, 16)
      Me.lblPedCompra.TabIndex = 205
      Me.lblPedCompra.Text = "Pedido"
      '
      'cboAnticipo
      '
      Me.cboAnticipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboAnticipo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboAnticipo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAnticipo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAnticipo.Location = New System.Drawing.Point(628, 12)
      Me.cboAnticipo.Name = "cboAnticipo"
      Me.cboAnticipo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboAnticipo.Size = New System.Drawing.Size(100, 20)
      Me.cboAnticipo.TabIndex = 12
      Me.cboAnticipo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblAnticipo
      '
      Me.lblAnticipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblAnticipo.BackColor = System.Drawing.Color.Transparent
      Me.lblAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAnticipo.Location = New System.Drawing.Point(568, 16)
      Me.lblAnticipo.Name = "lblAnticipo"
      Me.lblAnticipo.Size = New System.Drawing.Size(56, 16)
      Me.lblAnticipo.TabIndex = 205
      Me.lblAnticipo.Text = "Anticipo"
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.txtAnticipoOrden)
      Me.grpMain.Controls.Add(Me.cboTipoAnticipo)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.txtAnticipoNro)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.txtAnticipoId)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(736, 64)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(380, 16)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(68, 16)
      Me.Label2.TabIndex = 205
      Me.Label2.Text = "Nro. Orden"
      '
      'txtAnticipoOrden
      '
      Me.txtAnticipoOrden.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtAnticipoOrden.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAnticipoOrden.Location = New System.Drawing.Point(448, 12)
      Me.txtAnticipoOrden.MaxLength = 50
      Me.txtAnticipoOrden.Name = "txtAnticipoOrden"
      Me.txtAnticipoOrden.Size = New System.Drawing.Size(100, 20)
      Me.txtAnticipoOrden.TabIndex = 3
      Me.txtAnticipoOrden.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAnticipoOrden.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboTipoAnticipo
      '
      Me.cboTipoAnticipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboTipoAnticipo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAnticipo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAnticipo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAnticipo.Location = New System.Drawing.Point(614, 12)
      Me.cboTipoAnticipo.Name = "cboTipoAnticipo"
      Me.cboTipoAnticipo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoAnticipo.Size = New System.Drawing.Size(114, 20)
      Me.cboTipoAnticipo.TabIndex = 4
      Me.cboTipoAnticipo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label17
      '
      Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(574, 16)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(34, 16)
      Me.Label17.TabIndex = 203
      Me.Label17.Text = "Tipo"
      '
      'dtpFecha
      '
      Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFecha.DropDownCalendar.FirstMonth = New Date(2007, 12, 1, 0, 0, 0, 0)
      Me.dtpFecha.DropDownCalendar.Name = ""
      Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFecha.Location = New System.Drawing.Point(272, 12)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
      Me.dtpFecha.TabIndex = 2
      Me.dtpFecha.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(92, 36)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(100, 20)
      Me.cboEstado.TabIndex = 5
      Me.cboEstado.TabStop = False
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(272, 36)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
      Me.cboMoneda.TabIndex = 6
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtAnticipoNro
      '
      Me.txtAnticipoNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtAnticipoNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAnticipoNro.FormatString = "########"
      Me.txtAnticipoNro.Location = New System.Drawing.Point(614, 36)
      Me.txtAnticipoNro.Name = "txtAnticipoNro"
      Me.txtAnticipoNro.ReadOnly = True
      Me.txtAnticipoNro.Size = New System.Drawing.Size(114, 20)
      Me.txtAnticipoNro.TabIndex = 8
      Me.txtAnticipoNro.TabStop = False
      Me.txtAnticipoNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAnticipoNro.Value = 0
      Me.txtAnticipoNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtAnticipoNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(448, 36)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
      Me.txtTipoCambio.TabIndex = 7
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtAnticipoId
      '
      Me.txtAnticipoId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAnticipoId.Location = New System.Drawing.Point(92, 12)
      Me.txtAnticipoId.Name = "txtAnticipoId"
      Me.txtAnticipoId.ReadOnly = True
      Me.txtAnticipoId.Size = New System.Drawing.Size(100, 20)
      Me.txtAnticipoId.TabIndex = 1
      Me.txtAnticipoId.TabStop = False
      Me.txtAnticipoId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAnticipoId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(40, 40)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(46, 16)
      Me.Label6.TabIndex = 201
      Me.Label6.Text = "Estado"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(68, 16)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(20, 16)
      Me.Label7.TabIndex = 200
      Me.Label7.Text = "ID"
      '
      'Label11
      '
      Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(412, 40)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(32, 16)
      Me.Label11.TabIndex = 199
      Me.Label11.Text = "T.C."
      '
      'Label12
      '
      Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(562, 40)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(52, 16)
      Me.Label12.TabIndex = 198
      Me.Label12.Text = "Número"
      '
      'Label15
      '
      Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(216, 40)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(52, 16)
      Me.Label15.TabIndex = 196
      Me.Label15.Text = "Moneda"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(224, 16)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(44, 16)
      Me.Label16.TabIndex = 195
      Me.Label16.Text = "Fecha"
      '
      'grbPedCompra
      '
      Me.grbPedCompra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grbPedCompra.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbPedCompra.Controls.Add(Me.txtMontoAnt)
      Me.grbPedCompra.Controls.Add(Me.Label18)
      Me.grbPedCompra.Controls.Add(Me.txtPedCompraMonedaDes)
      Me.grbPedCompra.Controls.Add(Me.txtPedCompraAlmacenDes)
      Me.grbPedCompra.Controls.Add(Me.Label13)
      Me.grbPedCompra.Controls.Add(Me.txtPedCompraMonto)
      Me.grbPedCompra.Controls.Add(Me.lblImporte)
      Me.grbPedCompra.Controls.Add(Me.Label10)
      Me.grbPedCompra.Controls.Add(Me.txtPedCompraDes)
      Me.grbPedCompra.Controls.Add(Me.txtPedCompraTipoCambio)
      Me.grbPedCompra.Controls.Add(Me.Label8)
      Me.grbPedCompra.Controls.Add(Me.dtpPedCompraFecha)
      Me.grbPedCompra.Controls.Add(Me.Label3)
      Me.grbPedCompra.Controls.Add(Me.Label5)
      Me.grbPedCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbPedCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbPedCompra.Location = New System.Drawing.Point(8, 176)
      Me.grbPedCompra.Name = "grbPedCompra"
      Me.grbPedCompra.Size = New System.Drawing.Size(736, 96)
      Me.grbPedCompra.TabIndex = 14
      Me.grbPedCompra.Text = "Pedido de Compra"
      Me.grbPedCompra.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtMontoAnt
      '
      Me.txtMontoAnt.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoAnt.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoAnt.FormatString = "##,##0.000"
      Me.txtMontoAnt.Location = New System.Drawing.Point(628, 68)
      Me.txtMontoAnt.Name = "txtMontoAnt"
      Me.txtMontoAnt.ReadOnly = True
      Me.txtMontoAnt.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoAnt.TabIndex = 21
      Me.txtMontoAnt.TabStop = False
      Me.txtMontoAnt.Text = "0,000"
      Me.txtMontoAnt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoAnt.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoAnt.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(388, 72)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(236, 16)
      Me.Label18.TabIndex = 249
      Me.Label18.Text = "Monto de Otros Anticipos del Mismo Pedido"
      Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
      '
      'txtPedCompraMonedaDes
      '
      Me.txtPedCompraMonedaDes.BackColor = System.Drawing.SystemColors.Info
      Me.txtPedCompraMonedaDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPedCompraMonedaDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraMonedaDes.Location = New System.Drawing.Point(452, 16)
      Me.txtPedCompraMonedaDes.Name = "txtPedCompraMonedaDes"
      Me.txtPedCompraMonedaDes.ReadOnly = True
      Me.txtPedCompraMonedaDes.Size = New System.Drawing.Size(100, 20)
      Me.txtPedCompraMonedaDes.TabIndex = 17
      Me.txtPedCompraMonedaDes.TabStop = False
      Me.txtPedCompraMonedaDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPedCompraMonedaDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPedCompraAlmacenDes
      '
      Me.txtPedCompraAlmacenDes.BackColor = System.Drawing.SystemColors.Info
      Me.txtPedCompraAlmacenDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPedCompraAlmacenDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraAlmacenDes.Location = New System.Drawing.Point(92, 16)
      Me.txtPedCompraAlmacenDes.Name = "txtPedCompraAlmacenDes"
      Me.txtPedCompraAlmacenDes.ReadOnly = True
      Me.txtPedCompraAlmacenDes.Size = New System.Drawing.Size(100, 20)
      Me.txtPedCompraAlmacenDes.TabIndex = 15
      Me.txtPedCompraAlmacenDes.TabStop = False
      Me.txtPedCompraAlmacenDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPedCompraAlmacenDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(8, 20)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(80, 16)
      Me.Label13.TabIndex = 239
      Me.Label13.Text = "Almacén"
      '
      'txtPedCompraMonto
      '
      Me.txtPedCompraMonto.BackColor = System.Drawing.SystemColors.Info
      Me.txtPedCompraMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPedCompraMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraMonto.FormatString = "##,##0.000"
      Me.txtPedCompraMonto.Location = New System.Drawing.Point(92, 68)
      Me.txtPedCompraMonto.Name = "txtPedCompraMonto"
      Me.txtPedCompraMonto.ReadOnly = True
      Me.txtPedCompraMonto.Size = New System.Drawing.Size(100, 20)
      Me.txtPedCompraMonto.TabIndex = 20
      Me.txtPedCompraMonto.TabStop = False
      Me.txtPedCompraMonto.Text = "0,000"
      Me.txtPedCompraMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPedCompraMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPedCompraMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblImporte
      '
      Me.lblImporte.BackColor = System.Drawing.Color.Transparent
      Me.lblImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblImporte.Location = New System.Drawing.Point(8, 72)
      Me.lblImporte.Name = "lblImporte"
      Me.lblImporte.Size = New System.Drawing.Size(80, 16)
      Me.lblImporte.TabIndex = 237
      Me.lblImporte.Text = "Monto Pedido"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 44)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(80, 16)
      Me.Label10.TabIndex = 216
      Me.Label10.Text = "Descripción"
      '
      'txtPedCompraDes
      '
      Me.txtPedCompraDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPedCompraDes.BackColor = System.Drawing.SystemColors.Info
      Me.txtPedCompraDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPedCompraDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraDes.Location = New System.Drawing.Point(92, 40)
      Me.txtPedCompraDes.MaxLength = 255
      Me.txtPedCompraDes.Multiline = True
      Me.txtPedCompraDes.Name = "txtPedCompraDes"
      Me.txtPedCompraDes.ReadOnly = True
      Me.txtPedCompraDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtPedCompraDes.Size = New System.Drawing.Size(636, 20)
      Me.txtPedCompraDes.TabIndex = 19
      Me.txtPedCompraDes.TabStop = False
      Me.txtPedCompraDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPedCompraDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPedCompraTipoCambio
      '
      Me.txtPedCompraTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtPedCompraTipoCambio.BackColor = System.Drawing.SystemColors.Info
      Me.txtPedCompraTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPedCompraTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraTipoCambio.FormatString = "##,##0.000"
      Me.txtPedCompraTipoCambio.Location = New System.Drawing.Point(628, 16)
      Me.txtPedCompraTipoCambio.Name = "txtPedCompraTipoCambio"
      Me.txtPedCompraTipoCambio.ReadOnly = True
      Me.txtPedCompraTipoCambio.Size = New System.Drawing.Size(100, 20)
      Me.txtPedCompraTipoCambio.TabIndex = 18
      Me.txtPedCompraTipoCambio.TabStop = False
      Me.txtPedCompraTipoCambio.Text = "0,000"
      Me.txtPedCompraTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPedCompraTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPedCompraTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(592, 20)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(32, 16)
      Me.Label8.TabIndex = 211
      Me.Label8.Text = "T.C."
      '
      'dtpPedCompraFecha
      '
      Me.dtpPedCompraFecha.BackColor = System.Drawing.SystemColors.Info
      Me.dtpPedCompraFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpPedCompraFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpPedCompraFecha.DropDownCalendar.FirstMonth = New Date(2007, 12, 1, 0, 0, 0, 0)
      Me.dtpPedCompraFecha.DropDownCalendar.Name = ""
      Me.dtpPedCompraFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpPedCompraFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpPedCompraFecha.Location = New System.Drawing.Point(272, 16)
      Me.dtpPedCompraFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpPedCompraFecha.Name = "dtpPedCompraFecha"
      Me.dtpPedCompraFecha.ReadOnly = True
      Me.dtpPedCompraFecha.Size = New System.Drawing.Size(100, 20)
      Me.dtpPedCompraFecha.TabIndex = 16
      Me.dtpPedCompraFecha.TabStop = False
      Me.dtpPedCompraFecha.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpPedCompraFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(396, 20)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(52, 16)
      Me.Label3.TabIndex = 209
      Me.Label3.Text = "Moneda"
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(224, 20)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(44, 16)
      Me.Label5.TabIndex = 208
      Me.Label5.Text = "Fecha"
      '
      'grbAnticipo
      '
      Me.grbAnticipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grbAnticipo.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbAnticipo.Controls.Add(Me.txtPedCompraNroOrg)
      Me.grbAnticipo.Controls.Add(Me.Label20)
      Me.grbAnticipo.Controls.Add(Me.Label19)
      Me.grbAnticipo.Controls.Add(Me.txtMontoPenOrg)
      Me.grbAnticipo.Controls.Add(Me.Label9)
      Me.grbAnticipo.Controls.Add(Me.txtMontoDesOrg)
      Me.grbAnticipo.Controls.Add(Me.txtMonedaDesOrg)
      Me.grbAnticipo.Controls.Add(Me.txtMontoOrg)
      Me.grbAnticipo.Controls.Add(Me.Label22)
      Me.grbAnticipo.Controls.Add(Me.Label23)
      Me.grbAnticipo.Controls.Add(Me.txtAnticipoDesOrg)
      Me.grbAnticipo.Controls.Add(Me.txtTipoCambioOrg)
      Me.grbAnticipo.Controls.Add(Me.Label24)
      Me.grbAnticipo.Controls.Add(Me.dtpFechaOrg)
      Me.grbAnticipo.Controls.Add(Me.Label25)
      Me.grbAnticipo.Controls.Add(Me.Label26)
      Me.grbAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbAnticipo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbAnticipo.Location = New System.Drawing.Point(8, 176)
      Me.grbAnticipo.Name = "grbAnticipo"
      Me.grbAnticipo.Size = New System.Drawing.Size(736, 96)
      Me.grbAnticipo.TabIndex = 22
      Me.grbAnticipo.Text = "Anticipo"
      Me.grbAnticipo.Visible = False
      Me.grbAnticipo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtPedCompraNroOrg
      '
      Me.txtPedCompraNroOrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPedCompraNroOrg.BackColor = System.Drawing.SystemColors.Info
      Me.txtPedCompraNroOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPedCompraNroOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraNroOrg.FormatString = "########"
      Me.txtPedCompraNroOrg.Location = New System.Drawing.Point(92, 16)
      Me.txtPedCompraNroOrg.Name = "txtPedCompraNroOrg"
      Me.txtPedCompraNroOrg.ReadOnly = True
      Me.txtPedCompraNroOrg.Size = New System.Drawing.Size(100, 20)
      Me.txtPedCompraNroOrg.TabIndex = 23
      Me.txtPedCompraNroOrg.TabStop = False
      Me.txtPedCompraNroOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPedCompraNroOrg.Value = 0
      Me.txtPedCompraNroOrg.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtPedCompraNroOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label20
      '
      Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.Location = New System.Drawing.Point(8, 20)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(80, 16)
      Me.Label20.TabIndex = 246
      Me.Label20.Text = "Ped. compra"
      '
      'Label19
      '
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(464, 72)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(160, 16)
      Me.Label19.TabIndex = 244
      Me.Label19.Text = "Monto Pendiente a Descargar"
      '
      'txtMontoPenOrg
      '
      Me.txtMontoPenOrg.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoPenOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPenOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPenOrg.FormatString = "##,##0.000"
      Me.txtMontoPenOrg.Location = New System.Drawing.Point(628, 68)
      Me.txtMontoPenOrg.Name = "txtMontoPenOrg"
      Me.txtMontoPenOrg.ReadOnly = True
      Me.txtMontoPenOrg.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoPenOrg.TabIndex = 30
      Me.txtMontoPenOrg.TabStop = False
      Me.txtMontoPenOrg.Text = "0,000"
      Me.txtMontoPenOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPenOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPenOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(200, 72)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(68, 16)
      Me.Label9.TabIndex = 242
      Me.Label9.Text = "Descargado"
      '
      'txtMontoDesOrg
      '
      Me.txtMontoDesOrg.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoDesOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoDesOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoDesOrg.FormatString = "##,##0.000"
      Me.txtMontoDesOrg.Location = New System.Drawing.Point(272, 68)
      Me.txtMontoDesOrg.Name = "txtMontoDesOrg"
      Me.txtMontoDesOrg.ReadOnly = True
      Me.txtMontoDesOrg.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoDesOrg.TabIndex = 29
      Me.txtMontoDesOrg.TabStop = False
      Me.txtMontoDesOrg.Text = "0,000"
      Me.txtMontoDesOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoDesOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoDesOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMonedaDesOrg
      '
      Me.txtMonedaDesOrg.BackColor = System.Drawing.SystemColors.Info
      Me.txtMonedaDesOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMonedaDesOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMonedaDesOrg.Location = New System.Drawing.Point(452, 16)
      Me.txtMonedaDesOrg.Name = "txtMonedaDesOrg"
      Me.txtMonedaDesOrg.ReadOnly = True
      Me.txtMonedaDesOrg.Size = New System.Drawing.Size(100, 20)
      Me.txtMonedaDesOrg.TabIndex = 25
      Me.txtMonedaDesOrg.TabStop = False
      Me.txtMonedaDesOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtMonedaDesOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMontoOrg
      '
      Me.txtMontoOrg.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoOrg.FormatString = "##,##0.000"
      Me.txtMontoOrg.Location = New System.Drawing.Point(92, 68)
      Me.txtMontoOrg.Name = "txtMontoOrg"
      Me.txtMontoOrg.ReadOnly = True
      Me.txtMontoOrg.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoOrg.TabIndex = 28
      Me.txtMontoOrg.TabStop = False
      Me.txtMontoOrg.Text = "0,000"
      Me.txtMontoOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.Location = New System.Drawing.Point(8, 72)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(80, 16)
      Me.Label22.TabIndex = 237
      Me.Label22.Text = "Mto. Anticipo"
      '
      'Label23
      '
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.Location = New System.Drawing.Point(8, 44)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(80, 16)
      Me.Label23.TabIndex = 216
      Me.Label23.Text = "Por Concepto"
      '
      'txtAnticipoDesOrg
      '
      Me.txtAnticipoDesOrg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtAnticipoDesOrg.BackColor = System.Drawing.SystemColors.Info
      Me.txtAnticipoDesOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAnticipoDesOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAnticipoDesOrg.Location = New System.Drawing.Point(92, 40)
      Me.txtAnticipoDesOrg.MaxLength = 255
      Me.txtAnticipoDesOrg.Multiline = True
      Me.txtAnticipoDesOrg.Name = "txtAnticipoDesOrg"
      Me.txtAnticipoDesOrg.ReadOnly = True
      Me.txtAnticipoDesOrg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtAnticipoDesOrg.Size = New System.Drawing.Size(636, 20)
      Me.txtAnticipoDesOrg.TabIndex = 27
      Me.txtAnticipoDesOrg.TabStop = False
      Me.txtAnticipoDesOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAnticipoDesOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTipoCambioOrg
      '
      Me.txtTipoCambioOrg.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtTipoCambioOrg.BackColor = System.Drawing.SystemColors.Info
      Me.txtTipoCambioOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTipoCambioOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambioOrg.FormatString = "##,##0.000"
      Me.txtTipoCambioOrg.Location = New System.Drawing.Point(628, 16)
      Me.txtTipoCambioOrg.Name = "txtTipoCambioOrg"
      Me.txtTipoCambioOrg.ReadOnly = True
      Me.txtTipoCambioOrg.Size = New System.Drawing.Size(100, 20)
      Me.txtTipoCambioOrg.TabIndex = 26
      Me.txtTipoCambioOrg.TabStop = False
      Me.txtTipoCambioOrg.Text = "0,000"
      Me.txtTipoCambioOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambioOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambioOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label24
      '
      Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label24.BackColor = System.Drawing.Color.Transparent
      Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label24.Location = New System.Drawing.Point(592, 20)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(32, 16)
      Me.Label24.TabIndex = 211
      Me.Label24.Text = "T.C."
      '
      'dtpFechaOrg
      '
      Me.dtpFechaOrg.BackColor = System.Drawing.SystemColors.Info
      Me.dtpFechaOrg.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaOrg.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaOrg.DropDownCalendar.FirstMonth = New Date(2007, 12, 1, 0, 0, 0, 0)
      Me.dtpFechaOrg.DropDownCalendar.Name = ""
      Me.dtpFechaOrg.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFechaOrg.Location = New System.Drawing.Point(272, 16)
      Me.dtpFechaOrg.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaOrg.Name = "dtpFechaOrg"
      Me.dtpFechaOrg.ReadOnly = True
      Me.dtpFechaOrg.Size = New System.Drawing.Size(100, 20)
      Me.dtpFechaOrg.TabIndex = 24
      Me.dtpFechaOrg.TabStop = False
      Me.dtpFechaOrg.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaOrg.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label25
      '
      Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label25.BackColor = System.Drawing.Color.Transparent
      Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label25.Location = New System.Drawing.Point(396, 20)
      Me.Label25.Name = "Label25"
      Me.Label25.Size = New System.Drawing.Size(52, 16)
      Me.Label25.TabIndex = 209
      Me.Label25.Text = "Moneda"
      '
      'Label26
      '
      Me.Label26.BackColor = System.Drawing.Color.Transparent
      Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label26.Location = New System.Drawing.Point(224, 20)
      Me.Label26.Name = "Label26"
      Me.Label26.Size = New System.Drawing.Size(44, 16)
      Me.Label26.TabIndex = 208
      Me.Label26.Text = "Fecha"
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Anular, Me.Print, Me.AnticipoDet})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("b50eb266-db63-4929-957f-70003a512f95")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.AnticipoDet1, Me.Separator2, Me.Anular1, Me.Separator4, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(432, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'AnticipoDet1
      '
      Me.AnticipoDet1.Key = "AnticipoDet"
      Me.AnticipoDet1.Name = "AnticipoDet1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Anular1
      '
      Me.Anular1.Key = "Anular"
      Me.Anular1.Name = "Anular1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
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
      'Save
      '
      Me.Save.ImageIndex = 0
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.Text = "Guardar"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 4
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Anular
      '
      Me.Anular.ImageIndex = 1
      Me.Anular.Key = "Anular"
      Me.Anular.Name = "Anular"
      Me.Anular.Text = "Anular"
      '
      'Print
      '
      Me.Print.ImageIndex = 3
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'AnticipoDet
      '
      Me.AnticipoDet.ImageIndex = 2
      Me.AnticipoDet.Key = "AnticipoDet"
      Me.AnticipoDet.Name = "AnticipoDet"
      Me.AnticipoDet.Text = "Descargos Anticipo"
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
      'grpSucursal
      '
      Me.grpSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpSucursal.BackColor = System.Drawing.Color.WhiteSmoke
      Me.grpSucursal.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpSucursal.Controls.Add(Me.cboSucursal)
      Me.grpSucursal.Controls.Add(Me.lblSucursal)
      Me.grpSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpSucursal.Location = New System.Drawing.Point(8, 64)
      Me.grpSucursal.Name = "grpSucursal"
      Me.grpSucursal.Size = New System.Drawing.Size(736, 40)
      Me.grpSucursal.TabIndex = 36
      Me.grpSucursal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboSucursal
      '
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(92, 12)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.ReadOnly = True
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(280, 20)
      Me.cboSucursal.TabIndex = 10
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblSucursal
      '
      Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
      Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSucursal.Location = New System.Drawing.Point(8, 16)
      Me.lblSucursal.Name = "lblSucursal"
      Me.lblSucursal.Size = New System.Drawing.Size(80, 16)
      Me.lblSucursal.TabIndex = 214
      Me.lblSucursal.Text = "Sucursal"
      '
      'frmAnticipoEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 434)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MinimizeBox = False
      Me.Name = "frmAnticipoEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Anticipos"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMonto, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMonto.ResumeLayout(False)
      Me.grpMonto.PerformLayout()
      CType(Me.grpObservacion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpObservacion.ResumeLayout(False)
      Me.grpObservacion.PerformLayout()
      CType(Me.grpDatos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpDatos.ResumeLayout(False)
      Me.grpDatos.PerformLayout()
      CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.grbPedCompra, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbPedCompra.ResumeLayout(False)
      Me.grbPedCompra.PerformLayout()
      CType(Me.grbAnticipo, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbAnticipo.ResumeLayout(False)
      Me.grbAnticipo.PerformLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpSucursal.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Save"
            If DataSave() Then
               mlngID = moAnticipo.AnticipoId
               mboolChanged = True
               chkConFac.Enabled = False

               cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
               cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

               If MessageBox.Show("Documento Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Documento?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call PrintReport()
               End If

               Me.Close()
            End If

         Case "AnticipoDet"
            Call frmAnticipoDetLoad()

         Case "Anular"
            If Not TieneMovimiento() Then
               If AnticipoAnular() Then
                  mlngID = moAnticipo.AnticipoId
                  mboolChanged = True
                  Me.Close()
               End If
            Else
               MessageBox.Show("El Anticipo ya Tiene Movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmAnticipoEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmAnticipoEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim strMessaje As String
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call ViewComponent()
      Call FormInit()
      Call ComboLoad()

      If moAnticipo.TipoAnticipoId = 2 Then
         strMessaje = "Anticipo"

      ElseIf moAnticipo.TipoAnticipoId = 1 Then
         strMessaje = "Devolución Anticipo"
      Else
         strMessaje = ""
      End If

      If Not mboolAdding Then
         Call FormShow()

         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta " + strMessaje

         ElseIf OperaFechaHabil(ToDate(dtpFecha.Value)) Then
            Call HeaderReadOnly()
            Me.Text = "Editar " + strMessaje
         Else
            MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mboolEditing = False
            Call DataReadOnly()
            Me.Text = "Consulta " + strMessaje
         End If

      Else
         Me.Text = "Nuevo " + strMessaje
         Call FormNew()
      End If

      Call SecuritySet(Me, AppExeName)
      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moAnticipo
         txtAnticipoId.Text = ToStr(.AnticipoId)
         dtpFecha.Text = ToStr(.Fecha)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         cboTipoAnticipo.SelectedIndex = ListFindItem(cboTipoAnticipo, .TipoAnticipoId)

         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         txtAnticipoNro.Text = ToStr(.AnticipoNro)
         cboProveedor.Value = ListFindItem(cboProveedor, .ProveedorId)
         cboProveedor.Tag = cboProveedor.Text
         txtAnticipoDes.Text = ToStr(.AnticipoDes)
         txtAnticipoObs.Text = ToStr(.AnticipoObs)
         txtMonto.Text = ToDecStr(.MontoAnt)
         mdecMontoOrg = .MontoAnt
         txtMontoDes.Text = ToDecStr(.MontoDes)
         txtMontoPen.Text = ToDecStr(.MontoAnt - .MontoDes)
         txtAnticipoOrden.Text = ToStr(.AnticipoOrden)
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

         If .EstadoId = 12 Then
            cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
            cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False

            mboolAdding = False
            mboolEditing = False
         End If

         If .TipoAnticipoId = 2 Then 'Anticipo
            grbPedCompra.Visible = True
            grbAnticipo.Visible = False

            Call cboPedCompraLoad(.ProveedorId, .PedCompraId)
            cboPedCompra.SelectedIndex = ListFindItem(cboPedCompra, .PedCompraId)
            cboPedCompra.Tag = cboPedCompra.Text
            Call PedCompraIdLoad(ListPosition(cboPedCompra, cboPedCompra.SelectedIndex))

            If (.PedCompraId > 0) And (.MontoDes > 0) Then
               cboPedCompra.ReadOnly = True
               txtMonto.ReadOnly = True
               cboCentroCosto.ReadOnly = True

            ElseIf (.PedCompraId = 0) And (.MontoDes > 0) Then
               cboPedCompra.ReadOnly = True
               cboCentroCosto.ReadOnly = True

            ElseIf .PedCompraId = 0 Then
               cboCentroCosto.ReadOnly = True

            End If

         ElseIf .TipoAnticipoId = 1 Then 'Devolucion Anticipo
            grbPedCompra.Visible = False
            grbAnticipo.Visible = True

            Dim lngAnticipoId As Long = AnticipoDetAnticipoIdFind(5, .AnticipoId)
            Call cboAnticipoLoad(.ProveedorId, lngAnticipoId)
            cboAnticipo.SelectedIndex = ListFindItem(cboAnticipo, lngAnticipoId)
            cboAnticipo.Tag = cboAnticipo.Text
            Call AnticipoIdLoad(lngAnticipoId)
            txtMonto.ReadOnly = True

            lblMontoDes.Visible = False
            txtMontoDes.Visible = False
            lblMontoPen.Visible = False
            txtMontoPen.Visible = False

            lblPedCompra.Visible = False
            cboPedCompra.Visible = False
            lblAnticipo.Visible = True
            cboAnticipo.Visible = True

         End If

         chkConFac.Checked = .ConFac
         chkSinFac.Checked = .SinFac

         If Not clsAppInfo.MultipleNro Then
            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

      End With

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moAnticipo
         txtAnticipoId.Text = String.Empty
         dtpFecha.Text = ToStr(.Fecha)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
         cboTipoAnticipo.SelectedIndex = -1
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 13)
         txtTipoCambio.Text = "0"
         txtAnticipoNro.Text = "0"
         cboProveedor.Value = Nothing
         txtAnticipoDes.Text = String.Empty
         txtAnticipoObs.Text = String.Empty
         txtAnticipoOrden.Text = String.Empty
         txtMonto.Text = "0"
         txtMontoDes.Text = "0"
         txtMontoPen.Text = "0"
         Call txtTipoCambioLoad(ToDate(dtpFecha.Value))

         cboPedCompra.SelectedIndex = -1
         dtpPedCompraFecha.Text = String.Empty
         txtPedCompraMonedaDes.Text = String.Empty
         txtPedCompraTipoCambio.Text = "0"
         txtPedCompraAlmacenDes.Text = String.Empty
         txtPedCompraDes.Text = String.Empty
         txtPedCompraMonto.Text = "0"

         cboEstado.ReadOnly = True
         lblMontoDes.Visible = False
         txtMontoDes.Visible = False
         lblMontoPen.Visible = False
         txtMontoPen.Visible = False

         cboCentroCosto.SelectedIndex = -1
      End With

      If clsAppInfo.MultipleNro Then
         chkConFac.Checked = False
         chkSinFac.Checked = False
      Else
         chkConFac.Checked = False
         chkSinFac.Checked = True

         chkConFac.Visible = False
         chkSinFac.Visible = False
      End If

      If mboolAdding And clsAppInfo.CentroCostoApli Then
         txtAnticipoOrden.Text = "AC---"
      End If

      If clsAppInfo.SucursalApli Then
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, moAnticipo.SucursalId)
         cboSucursal.ReadOnly = False
      Else
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, clsAppInfo.SucursalId)
         cboSucursal.ReadOnly = True
      End If


      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtAnticipoId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboTipoAnticipo.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtAnticipoNro.ReadOnly = True
      cboProveedor.ReadOnly = True
      txtAnticipoDes.ReadOnly = True
      txtAnticipoObs.ReadOnly = True
      txtMonto.ReadOnly = True
      cboPedCompra.ReadOnly = True
      cboAnticipo.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False
      cboCentroCosto.ReadOnly = True
      txtAnticipoOrden.ReadOnly = True
      cboSucursal.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub HeaderReadOnly()
      txtAnticipoId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboTipoAnticipo.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtAnticipoNro.ReadOnly = True
      cboAnticipo.ReadOnly = True
      cboProveedor.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False
      cboSucursal.ReadOnly = True

      If moAnticipo.TipoAnticipoId = 1 Then 'Devolucion Anticipo
         cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      End If

   End Sub

   Private Sub ViewComponent()
      If clsAppInfo.SucursalApli Then
         grpSucursal.Visible = True
      Else
         grpSucursal.Visible = False
         mdecPosSuc = 40
      End If

      If clsAppInfo.CentroCostoApli Then
         cboCentroCosto.Visible = True
         lblCentroCosto.Visible = True
      Else
         cboCentroCosto.Visible = False
         lblCentroCosto.Visible = False
      End If

      Me.Size = New System.Drawing.Size(Me.Size.Width, Me.Size.Height - mdecPosSuc)
      grpDatos.Location = New System.Drawing.Point(grpDatos.Location.X, grpDatos.Location.Y - mdecPosSuc)
      grbPedCompra.Location = New System.Drawing.Point(grbPedCompra.Location.X, grbPedCompra.Location.Y - mdecPosSuc)
      grbAnticipo.Location = New System.Drawing.Point(grbAnticipo.Location.X, grbAnticipo.Location.Y - mdecPosSuc)
      grpMonto.Location = New System.Drawing.Point(grpMonto.Location.X, grpMonto.Location.Y - mdecPosSuc)
      grpObservacion.Location = New System.Drawing.Point(grpObservacion.Location.X, grpObservacion.Location.Y - mdecPosSuc)

   End Sub

   'Private Sub VisibleTipoAnticipo(ByVal lngTipoAnticipo As Long)
   '   Dim decPos As Decimal = 0
   '   Dim decAlto As Decimal = 0
   '   Dim decHeight As Decimal = 512 ''472

   '   If lngTipoAnticipo = 1 Then 'Devolucion Anticipo
   '      grpTarjeta.Visible = False
   '      'grpObservacion.Location = New System.Drawing.Point(8, 290)
   '      'Me.Size = New System.Drawing.Size(758, 394)

   '      decPos = grpTarjeta.Location.Y
   '      decAlto = grpTarjeta.Height
   '      decHeight = decHeight - mdecPosSuc - decAlto

   '   ElseIf lngTipoAnticipo = 2 Then 'Anticipo
   '      grpTarjeta.Visible = True
   '      'grpObservacion.Location = New System.Drawing.Point(8, 368)
   '      'Me.Size = New System.Drawing.Size(758, 472)

   '      decPos = grpTarjeta.Location.Y + grpTarjeta.Height
   '      decHeight = decHeight - mdecPosSuc

   '   End If

   '   grpObservacion.Location = New System.Drawing.Point(grpObservacion.Location.X, decPos)
   '   Me.Size = New System.Drawing.Size(Me.Size.Width, decHeight)

   'End Sub

   Private Sub DataMove()
      With moAnticipo
         If Not mboolAdding Then
            .AnticipoId = ToLong(txtAnticipoId.Text)
         End If
         .Fecha = ToDate(dtpFecha.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .TipoAnticipoId = ListPosition(cboTipoAnticipo, cboTipoAnticipo.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .AnticipoNro = ToLong(txtAnticipoNro.Text)
         .ProveedorId = ListPosition(cboProveedor)
         .AnticipoDes = ToStr(txtAnticipoDes.Text)
         .AnticipoObs = ToStr(txtAnticipoObs.Text)
         .PedCompraId = ListPosition(cboPedCompra, cboPedCompra.SelectedIndex)
         .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
         .AnticipoOrden = ToStr(txtAnticipoOrden.Text)

         If .TipoAnticipoId = 2 Then 'Anticipo
            .PedCompraId = ListPosition(cboPedCompra, cboPedCompra.SelectedIndex)
            .MontoAnt = ToDecimal(txtMonto.Text)
            .MontoDes = ToDecimal(txtMontoDes.Text)
            .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

            If .MontoAnt = .MontoDes Then
               .EstadoId = 14
            End If

         ElseIf .TipoAnticipoId = 1 Then 'Devolucion Anticipo
            .PedCompraId = ToLong(txtPedCompraNroOrg.Tag)
            .MontoAnt = ToDecimal(txtMonto.Text)
            .MontoDes = 0
            .EstadoId = 14
         End If

         .ConFac = ToBoolean(chkConFac.Checked)
         .SinFac = ToBoolean(chkSinFac.Checked)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)

      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.False

      dtpFecha.Select()
   End Sub

   Private Function DataSave() As Boolean
      Dim lngCompId As Long
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim lngProveedorMovId As Long
      Dim lngTipoCompraId As Long
      Dim decMonto As Decimal
      Dim lngCol As Long

      Try
         Call DataMove()

         With moAnticipo
            If .Validate Then
               If FormCheck() Then
                  If CheckValidacion() Then
                     If mboolAdding Then
                        If clsAppInfo.Inventario Then ' Integrado a Contabilidad
                           If frmCompPlanFill() Then
                              If .TipoAnticipoId = 2 Then 'Anticipo
                                 lngCol = 1
                                 decMonto = .MontoAnt
                                 lngTipoCompraId = 4
                                 .AnticipoNro = CompraNroNext(4, clsAppInfo.GestionId, moAnticipo.SucursalId)

                              ElseIf .TipoAnticipoId = 1 Then 'Devolucion Anticipo
                                 lngCol = 2
                                 decMonto = .MontoAnt
                                 lngTipoCompraId = 5
                                 .AnticipoNro = CompraNroNext(5, clsAppInfo.GestionId, moAnticipo.SucursalId)
                              End If

                              .PlanId = mlngPlanId 'Contra Cuenta del Comprobante

                              If DataAdd() Then
                                 txtAnticipoId.Text = ToStr(.AnticipoId)
                                 txtAnticipoNro.Text = ToStr(.AnticipoNro)

                                 If mboolTieneComp Then
                                    If CompNew(lngCompId, lngTipoCompId, lngCompNro) Then
                                       .CompId = lngCompId

                                       If lngTipoCompraId = 5 Then 'Descargar del Anticipo de la devolucion
                                          Call AnticipoUpdate(lngTipoCompraId, ListPosition(cboAnticipo, cboAnticipo.SelectedIndex), .MontoAnt, lngTipoCompId, lngCompNro)
                                       End If

                                       If ProveedorMovAdd(lngProveedorMovId, lngTipoCompraId, .AnticipoId, 2, decMonto, lngCol, lngTipoCompId, lngCompNro, .PlanId) Then
                                          If .Update Then
                                             mboolAdding = False
                                             DataSave = True
                                          End If
                                       End If
                                    End If
                                 Else

                                    If lngTipoCompraId = 5 Then 'Descargar del Anticipo de la devolucion
                                       Call AnticipoUpdate(lngTipoCompraId, ListPosition(cboAnticipo, cboAnticipo.SelectedIndex), .MontoAnt, 0, 0)
                                    End If

                                    If ProveedorMovAdd(lngProveedorMovId, lngTipoCompraId, .AnticipoId, 2, decMonto, lngCol, 0, 0, 0) Then
                                       DataSave = True
                                    End If
                                 End If
                              End If
                           End If
                        Else
                           If .TipoAnticipoId = 2 Then 'Anticipo
                              lngCol = 1
                              decMonto = .MontoAnt
                              lngTipoCompraId = 4
                              .AnticipoNro = CompraNroNext(4, clsAppInfo.GestionId, moAnticipo.SucursalId)
                           ElseIf .TipoAnticipoId = 1 Then 'Devolucion Anticipo
                              lngCol = 2
                              decMonto = .MontoAnt
                              lngTipoCompraId = 5
                              .AnticipoNro = CompraNroNext(5, clsAppInfo.GestionId, moAnticipo.SucursalId)
                           End If

                           If DataAdd() Then
                              txtAnticipoId.Text = ToStr(.AnticipoId)
                              txtAnticipoNro.Text = ToStr(.AnticipoNro)

                              If lngTipoCompraId = 5 Then 'Descargar del Anticipo de la devolucion
                                 Call AnticipoUpdate(lngTipoCompraId, ListPosition(cboAnticipo, cboAnticipo.SelectedIndex), .MontoAnt, 0, 0)
                              End If

                              If ProveedorMovAdd(lngProveedorMovId, lngTipoCompraId, .AnticipoId, 2, decMonto, lngCol, 0, 0, 0) Then
                                 mboolAdding = False
                                 DataSave = True
                              End If
                           End If
                        End If

                     Else
                        If DataUpdate() Then
                           If .TipoAnticipoId = 2 Then 'Anticipo
                              lngCol = 1
                              decMonto = .MontoAnt
                              lngTipoCompraId = 4
                           ElseIf .TipoAnticipoId = 1 Then 'Devolucion Anticipo
                              lngCol = 2
                              decMonto = .MontoAnt
                              lngTipoCompraId = 5
                           End If

                           If clsAppInfo.Inventario Then ' Integrado a Contabilidad
                              If frmCompPlanFillEdit() Then
                                 Call CompEdit(moAnticipo.CompId, lngTipoCompId, lngCompNro)

                                 If lngTipoCompraId = 5 Then 'Descargar del Anticipo de la devolucion
                                    Call AnticipoUpdate(lngTipoCompraId, ListPosition(cboAnticipo, cboAnticipo.SelectedIndex), .MontoAnt, lngTipoCompId, lngCompNro)
                                 End If

                                 If ProveedorMovUpdate(lngTipoCompraId, .AnticipoId, lngCol, decMonto) Then
                                    DataSave = True
                                 End If
                              End If

                           Else
                              If lngTipoCompraId = 5 Then 'Descargar del Anticipo de la devolucion
                                 Call AnticipoUpdate(lngTipoCompraId, ListPosition(cboAnticipo, cboAnticipo.SelectedIndex), .MontoAnt, lngTipoCompId, lngCompNro)
                              End If

                              If ProveedorMovUpdate(lngTipoCompraId, .AnticipoId, lngCol, decMonto) Then
                                 DataSave = True
                              End If
                           End If
                        End If
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moAnticipo.Insert() Then
            DataAdd = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moAnticipo.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

        If cboSucursal.SelectedIndex = -1 Then
            FormCheck = False
            Throw New Exception("Revise La Sucursal")
        End If

        If clsAppInfo.SucursalApli Then
            'If Not mboolNroAutoSucursal Then
            '    FormCheck = False
            '    Throw New Exception("Revise los Parámetros de Documento de la Sucursal")
            'Else
            If CompSucursalApeExist(moAnticipo.EmpresaId, moAnticipo.GestionId, moAnticipo.SucursalId) Then
                If Not NotaSucursalApeExist(moAnticipo.EmpresaId, moAnticipo.GestionId, moAnticipo.SucursalId) Then
                    FormCheck = False
                    Throw New Exception("No hay Apertura de Parámetros de Notas en 'Inventario' para esta Sucursal")
                End If
            Else
                FormCheck = False
                Throw New Exception("No hay Apertura de Parámetros de Comprobantes en 'Contabilidad' para esta Sucursal")
            End If
            'End If
        End If

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         FormCheck = False
         Throw New Exception("Fecha no Corresponde a la Gestion en Uso")

      ElseIf Not OperaFechaHabil(ToDate(dtpFecha.Value)) Then
         FormCheck = False
         Throw New Exception("Fecha de Operación Inhábil para el Usuario")
      End If

      If dtpFecha.Value > Now Then
         FormCheck = False
         Throw New Exception("Fecha no Valida, No puede ser mayor a la Actual")
      End If

      If (Not chkConFac.Checked) And (Not chkSinFac.Checked) Then
         FormCheck = False
         Throw New Exception("Valores Inválidos en (I o F)")
      End If

      If moAnticipo.TipoAnticipoId = 1 Then 'Devolucion Anticipo
         If cboAnticipo.SelectedIndex = -1 Then
            FormCheck = False
            Throw New Exception("Anticipo Inválido")
         End If

         If mboolAdding Then
            If ToDecimal(txtMontoPenOrg.Text) < moAnticipo.MontoAnt Then
               FormCheck = False
               Throw New Exception("El Monto es Inferior al Monto Pendiente de Descargo")
            End If
         Else
            If ToDecimal(txtMontoPenOrg.Text) + mdecMontoOrg < moAnticipo.MontoAnt Then
               FormCheck = False
               Throw New Exception("El Monto es Inferior al Monto Pendiente de Descargo")
            End If
         End If

         If clsAppInfo.CentroCostoApli Then
            If cboCentroCosto.SelectedIndex = -1 Then
               FormCheck = False
               Throw New Exception("Centro de Costo Inválido")
            End If
         End If

         'If ToDecimal(txtMonto.Text) > ToDecimal(txtMontoAnt.Text) - ToDecimal(txtMontoDev.Text) Then
         '   FormCheck = False
         '   Throw New Exception("El Monto Excede al Monto Total de las Devoluciones")
         'End If

      ElseIf moAnticipo.TipoAnticipoId = 2 Then 'Anticipo
         If cboPedCompra.SelectedIndex = -1 Then
            FormCheck = False
            Throw New Exception("Pedido Inválido")
         End If

         If ToDecimal(txtMontoDes.Text) > moAnticipo.MontoAnt Then
            FormCheck = False
            Throw New Exception("El Monto es Inferior al Monto Descargado")
         End If

         If clsAppInfo.CentroCostoApli Then
            If cboCentroCosto.SelectedIndex = -1 Then
               FormCheck = False
               Throw New Exception("Centro de Costo Inválido")
            End If

            If mboolAdding Then
               Dim strTexto As String = (txtAnticipoOrden.Text).Trim

               If txtAnticipoOrden.Text.Trim <> String.Empty Then
                  If strTexto.Chars(strTexto.Length - 1) = "-" Then
                     Throw New Exception("Nro de Orden Incompleto")
                  End If

               Else
                  Throw New Exception("Nro de Orden Incompleto")
               End If
            End If

         End If

         'If ToDecimal(txtMonto.Text) + ToDecimal(txtMontoAnt.Text) - ToDecimal(txtMontoDev.Text) > ToDecimal(txtPedCompraMonto.Text) Then
         '   FormCheck = False
         '   Throw New Exception("El Monto Excede al Monto Total del Pedido de Compra")
         'End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function CheckValidacion() As Boolean
      CheckValidacion = True
      With moAnticipo
         If mboolEditing Then
            If moAnticipo.TipoAnticipoId = 2 Then ''Anticipo
               If (.MontoAnt = .MontoDes) And (.MontoAnt > 0) Then
                  If MessageBox.Show("¿Realmente Quiere Guardar el Anticipo?" & vbCrLf & " Una vez Guardado no se podra editar, este quedará sin Pendientes de descargo ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     CheckValidacion = True
                  Else
                     CheckValidacion = False
                  End If
               End If
            End If
         End If
      End With

   End Function

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraNroNext = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moAnticipo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               .UpdateFilter = clsCompraPara.UpdateFilters.NroActual
               .NroActual = ToLong(.NroActual) + 1

               If .Update Then
                  CompraNroNext = .NroActual
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

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
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
      mlngTipoPlanId = 0
      mboolTieneComp = False
      mboolAplicarITF = False

      If clsAppInfo.SucursalApli Then
         mlngSucursalId = moAnticipo.SucursalId
      End If

      With frm
         .EmpresaId = moAnticipo.EmpresaId
         .PlanWhereFilter = clsPlan.WhereFilters.CajaBanco
         .CentroCostoId = moAnticipo.CentroCostoId
         .SucursalId = moAnticipo.SucursalId
         .chkTieneComp.Visible = True
         .ShowDialog()

         If .Changed Then
            mlngPlanId = frm.PlanId
            mlngPlanAddId = frm.PlanAddId
            mlngSucursalId = frm.SucursalId
            mlngCentroCostoId = frm.CentroCostoId
            mlngCentroCostoDetId = frm.CentroCostoDetId
            mlngTipoPlanId = TipoPlanIdFind(mlngPlanId, strPlanDes, lngMonedaIdPlan)
            mboolTieneComp = frm.TieneComp

            If mlngTipoPlanId = 3 And lngMonedaIdPlan = clsMoneda.DOLARES Then  'Tipo Cuenta 3 = Banco -- Cuenta Corriente
               If MessageBox.Show("¿Desea Aplicar I.T.F. a la Cuenta  " & strPlanDes & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  mboolAplicarITF = True
               End If
            End If

            frmCompPlanFill = True

         End If
         frm.Dispose()
      End With
   End Function

   Private Function frmCompPlanFillEdit() As Boolean
      Dim lngCompId As Long
      Dim lngCompDetId As Long
      Dim strPlanDes As String = ""
      Dim lngMonedaIdPlan As Long = 0

      frmCompPlanFillEdit = False
      mlngTipoPlanId = 0

      mboolAplicarITF = False
      If isCompFind(lngCompId, 0, 0) Then
         lngCompId = moAnticipo.CompId
      End If

      'If CompFind(0, 0, lngCompId) Then
      If lngCompId > 0 Then
         Call CompDetFind(lngCompId, lngCompDetId, moAnticipo.PlanId, 2, 0, 0)

         mlngTipoPlanId = TipoPlanIdFind(moAnticipo.PlanId, strPlanDes, lngMonedaIdPlan)
         If mlngTipoPlanId = 3 Then
            If moAnticipo.TipoAnticipoId = 2 Then
               If TieneChequeraCreada(moAnticipo.PlanId) Then
                  If frmCompChequeEditLoad(lngCompId, lngCompDetId, moAnticipo.PlanId, moAnticipo.MontoAnt) Then
                     frmCompPlanFillEdit = True
                  End If
               Else
                  MessageBox.Show("Debe Definir la Chequera para Esta Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  frmCompPlanFillEdit = True
               End If
            Else
               frmCompPlanFillEdit = True
            End If

            If frmCompPlanFillEdit Then
               If lngMonedaIdPlan = clsMoneda.DOLARES Then  'Tipo Cuenta 3 = Banco -- Cuenta Corriente
                  If MessageBox.Show("¿Desea Aplicar I.T.F. a la Cuenta  " & strPlanDes & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     mboolAplicarITF = True
                  End If
               End If
            End If
         Else
            frmCompPlanFillEdit = True
         End If
      Else
         frmCompPlanFillEdit = True
      End If

   End Function

   Private Function CompDetFind(ByVal lngCompId As Long, ByRef lngCompDetId As Long, ByVal lngPlanId As Long, _
                          ByVal lngCol As Long, Optional ByRef lngSucursalId As Long = 0, _
                          Optional ByRef lngCentroCostoId As Long = 0) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetFind = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompId
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .CompId = lngCompId
            .PlanId = lngPlanId

            If .Find Then

               While .Read()

                  If lngCol = 1 Then
                     If .DebeOrg <> 0 Then
                        CompDetFind = True
                        Exit While
                     End If

                  ElseIf lngCol = 2 Then
                     If .HaberOrg <> 0 Then
                        CompDetFind = True
                        Exit While
                     End If
                  End If

                  .MoveNext()
               End While

               If CompDetFind Then
                  lngCompDetId = .CompDetId
                  lngSucursalId = .SucursalId
                  lngCentroCostoId = .CentroCostoId
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function AnticipoUpdate(ByVal lngTipoCompraId As Long, ByVal lngAnticipoId As Long, ByVal decMonto As Decimal, ByVal lngTipoCompId As Long, ByVal lngCompNro As Long) As Boolean
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim lngProveedorMovId As Long

      AnticipoUpdate = False

      Try
         With oAnticipo
            .AnticipoId = lngAnticipoId

            If .FindByPK Then
               If mboolAdding Then
                  .Fecha = ToDate(.Fecha)
                  .MontoDes += decMonto

                  If .MontoAnt <= .MontoDes Then
                     .EstadoId = 14 'Realizado
                  Else
                     .EstadoId = 13 'Pendiente
                  End If

                  If .Update() Then
                     If AnticipoDetAdd(.AnticipoId, lngTipoCompraId, moAnticipo.AnticipoId, ToStr(txtAnticipoDes.Text), .MonedaId, decMonto, lngTipoCompId, lngCompNro, moAnticipo.PlanId) Then
                        AnticipoUpdate = True
                     End If
                  End If

               Else
                  .Fecha = ToDate(.Fecha)
                  .MontoDes = (.MontoDes - mdecMontoOrg) + decMonto

                  If .MontoAnt <= .MontoDes Then
                     .EstadoId = 14 'Realizado
                  Else
                     .EstadoId = 13 'Pendiente
                  End If

                  If .Update() Then
                     If AnticipoDetUpdate(.AnticipoId, lngTipoCompraId, moAnticipo.AnticipoId, ToStr(txtAnticipoDes.Text), .MonedaId, decMonto, lngTipoCompId, lngCompNro, moAnticipo.PlanId) Then
                        AnticipoUpdate = True
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function AnticipoDetAdd(ByVal lngAnticipoId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal strDes As String, ByVal lngMonedaId As Long, ByVal decMonto As Decimal, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoDetAdd = False

      Try
         With oAnticipoDet
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .AnticipoId = lngAnticipoId
            .ProveedorId = moAnticipo.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .Fecha = moAnticipo.Fecha
            .AnticipoDetDes = strDes
            .MonedaId = lngMonedaId
            .TipoCambio = moAnticipo.TipoCambio
            .Monto = decMonto
            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .PlanId = lngPlanId

            If .Insert() Then
               AnticipoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function AnticipoDetUpdate(ByVal lngAnticipoId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal strDes As String, ByVal lngMonedaId As Long, ByVal decMonto As Decimal, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoDetUpdate = False

      Try
         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.DocumentoId
            .EmpresaId = moAnticipo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId

            If .Find Then
               .AnticipoId = lngAnticipoId
               .ProveedorId = moAnticipo.ProveedorId
               .Fecha = moAnticipo.Fecha
               .AnticipoDetDes = strDes
               .MonedaId = lngMonedaId
               .TipoCambio = moAnticipo.TipoCambio
               .Monto = decMonto
               .TipoCompId = lngTipoCompId
               .CompNro = lngCompNro
               .PlanId = lngPlanId

               If .Update() Then
                  AnticipoDetUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function TipoPlanIdFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TipoPlanIdFind = 0

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               TipoPlanIdFind = .TipoPlanId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function TipoPlanIdFind(ByVal lngPlanId As Long, ByRef strPlanDes As String, ByRef lngMonedaIdPlan As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TipoPlanIdFind = 0

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               lngMonedaIdPlan = .MonedaId
               strPlanDes = .PlanDes
               TipoPlanIdFind = .TipoPlanId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function CompNew(ByRef lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal
      'Dim lngCompId As Long
      Dim lngCompDetId As Long
      Dim lngPlanIdAct As Long
      Dim lngPlanAddIdAct As Long

      Dim decITFBs As Decimal = 0
      Dim decITFUs As Decimal = 0

      Try
         With moAnticipo
            lngPlanIdAct = PlanIdActFind(.ProveedorId, lngPlanAddIdAct)

            If .MonedaId = 1 Then
               decMontoBs = ToDecimal(txtMonto.Text)
               decMontoUs = ToDecimal(ToDecimal(txtMonto.Text) / .TipoCambio)
               decMontoOrg = decMontoBs
            Else
               decMontoBs = ToDecimal(ToDecimal(txtMonto.Text) * .TipoCambio)
               decMontoUs = ToDecimal(txtMonto.Text)
               decMontoOrg = decMontoUs
            End If

            If mboolAplicarITF Then
               decITFBs = ToDecimal(decMontoBs * clsAppInfo.ITF)
               decITFUs = ToDecimal(decMontoUs * clsAppInfo.ITF)
            End If

            '(Anticipo) Comprobante de Egreso
            If .TipoAnticipoId = 2 Then
               If CompAdd(lngTipoCompId, lngCompNro, lngCompId, decMontoBs + decITFBs, decMontoUs + decITFUs) Then 'Cabecera Comprobante
                  CompNew = True

                  If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, decMontoBs, decMontoUs, 1, moAnticipo.SucursalId, moAnticipo.CentroCostoId, lngCompDetId) Then
                     If lngPlanAddIdAct <> 0 Then 'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 1, moAnticipo.SucursalId) Then
                           CompNew = True
                        End If
                     End If

                     If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, decMontoBs, decMontoUs, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                        If mlngPlanAddId <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decMontoBs, decMontoUs, 2, moAnticipo.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        If mlngCentroCostoDetId <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, decMontoBs, decMontoUs, 2, moAnticipo.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        If mlngTipoPlanId = 3 Then 'En Caso de que Tenga Chequera
                           If TieneChequeraCreada(mlngPlanId) Then
                              If frmCompChequeEditLoad(lngCompId, lngCompDetId, mlngPlanId, decMontoOrg) Then
                                 CompNew = True
                              End If
                           Else
                              MessageBox.Show("Debe Definir la Chequera para Esta Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                           End If
                        Else
                           CompNew = True
                        End If
                     End If

                  End If

                  'Aplicando ITF
                  If mboolAplicarITF Then
                     If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, decITFBs, decITFUs, 2, mlngSucursalId, moAnticipo.CentroCostoId, lngCompDetId, 1) Then
                        CompNew = True
                     End If

                     If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITFId, decITFBs, decITFUs, 1, mlngSucursalId, moAnticipo.CentroCostoId, lngCompDetId, 1) Then
                        CompNew = True
                     End If
                  End If
               End If

               '(Devolucion) Comprobante de Ingreso
            ElseIf .TipoAnticipoId = 1 Then
               CompNew = True

               If CompAdd(lngTipoCompId, lngCompNro, lngCompId, decMontoBs, decMontoUs) Then 'Cabecera Comprobante
                  If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, decMontoBs, decMontoUs, 1, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                     If mlngPlanAddId <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decMontoBs, decMontoUs, 1, moAnticipo.SucursalId) Then
                           CompNew = True
                        End If
                     End If

                     If mlngCentroCostoDetId <> 0 Then  'Actividad
                        If CompCentroCostoDetAdd(lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, decMontoBs, decMontoUs, 1, moAnticipo.SucursalId) Then
                           CompNew = True
                        End If
                     End If

                     If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, decMontoBs, decMontoUs, 2, moAnticipo.SucursalId, moAnticipo.CentroCostoId, lngCompDetId) Then
                        If lngPlanAddIdAct <> 0 Then 'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moAnticipo.SucursalId) Then
                              CompNew = True
                           End If
                        End If
                     End If
                  End If

                  'Aplicando ITF
                  If mboolAplicarITF Then
                     If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, decITFBs, decITFUs, 2, mlngSucursalId, moAnticipo.CentroCostoId, lngCompDetId, 1) Then
                        CompNew = True
                     End If

                     If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITFId, decITFBs, decITFUs, 1, mlngSucursalId, moAnticipo.CentroCostoId, lngCompDetId, 1) Then
                        CompNew = True
                     End If
                  End If

               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompAdd(ByRef lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long, ByVal decTotalBs As Decimal, ByVal decTotalUs As Decimal) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .TipoCompId = moAnticipo.TipoAnticipoId
            .CompNro = CompNroNext(.TipoCompId, moAnticipo.GestionId, moAnticipo.SucursalId)
            .Fecha = moAnticipo.Fecha
            .MonedaId = moAnticipo.MonedaId
            .TipoCambio = moAnticipo.TipoCambio
            .EntregadoA = ToStr(cboProveedor.Text)
            .PorConcepto = ToStr(cboTipoAnticipo.Text) + " Nro. " + ToStr(txtAnticipoNro.Text) + "; " + ToStr(txtAnticipoDes.Text)
            .DebeBs = decTotalBs
            .HaberBs = decTotalBs
            .DebeUs = decTotalUs
            .HaberUs = decTotalUs
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF
            .ConFac = moAnticipo.ConFac
            .SinFac = moAnticipo.SinFac
            .Automatico = 0
            .Glosa = ""
            '.TipoNotaId = 0
            '.NotaNro = 0
            .TipoAsientoId = 0
            .EstadoId = 10

            .SucursalId = moAnticipo.SucursalId
            .NotaId = 0
            .AppId = moAnticipo.AppId
            .TipoDocumentoId = IIf(moAnticipo.TipoAnticipoId = clsTipoAnticipo.ANTICIPO, clsTipoCompra.ANTICIPO, clsTipoCompra.DEVOLUCION_ANTICIPO)
            .DocumentoId = moAnticipo.AnticipoId

            If .Insert() Then
               lngCompId = .CompId
               lngTipoCompId = .TipoCompId
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

   Private Function CompUpdate(ByVal lngCompId As Long, ByVal decTotalBs As Decimal, ByVal decTotalUs As Decimal) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompUpdate = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               .DebeBs = decTotalBs
               .HaberBs = decTotalBs
               .DebeUs = decTotalUs
               .HaberUs = decTotalUs
               .Fecha = ToDate(.Fecha)
               .PorConcepto = ToStr(cboTipoAnticipo.Text) + " Nro. " + ToStr(txtAnticipoNro.Text) + "; " + ToStr(txtAnticipoDes.Text)
               .EstadoId = clsEstado.CERRADO

               If .Update Then
                  CompUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompDetAdd(ByRef lngTipoCompId As Long, ByVal lngCompId As Long, ByVal lngPlanId As Long, ByVal decValorBs As Decimal, _
                               ByVal decValorUs As Decimal, ByVal lngCol As Long, Optional ByVal lngSucursalId As Long = 0, _
                               Optional ByVal lngCentroCostoId As Long = 0, Optional ByRef lngCompDetId As Long = 0, _
                               Optional ByVal bytAutomatico As Byte = 0) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = moAnticipo.Fecha
            .PlanId = lngPlanId
            .CompDetDes = ToStr(cboProveedor.Text) + " , " + ToStr(cboTipoAnticipo.Text) + " Nro. " + ToStr(txtAnticipoNro.Text) + "; " + ToStr(txtAnticipoDes.Text)
            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId
            .MonedaId = moAnticipo.MonedaId

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorBs
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeBs = 0
                  .DebeUs = 0
               End If
            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorUs
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeUs = 0
                  .DebeBs = 0
               End If
            End If

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

   Private Function CompDetUpdate(ByVal lngCompId As Long, ByVal lngPlanId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, Optional ByVal lngSucursalId As Long = 0, Optional ByVal lngCentroCostoId As Long = 0, Optional ByRef lngCompDetId As Long = 0) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetUpdate = False
      lngCompDetId = 0

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompId
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .CompId = lngCompId
            .PlanId = lngPlanId

            If .Find Then
               If .MonedaId = 1 Then
                  If lngCol = 1 Then
                     .DebeOrg = decValorBs
                     .DebeBs = decValorBs
                     .DebeUs = decValorUs

                     .HaberOrg = 0
                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberOrg = decValorBs
                     .HaberBs = decValorBs
                     .HaberUs = decValorUs

                     .DebeOrg = 0
                     .DebeBs = 0
                     .DebeUs = 0
                  End If

               ElseIf .MonedaId = 2 Then
                  If lngCol = 1 Then
                     .DebeOrg = decValorUs
                     .DebeBs = decValorBs
                     .DebeUs = decValorUs

                     .HaberOrg = 0
                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberOrg = decValorUs
                     .HaberBs = decValorBs
                     .HaberUs = decValorUs

                     .DebeOrg = 0
                     .DebeUs = 0
                     .DebeBs = 0
                  End If
               End If

               .Fecha = ToDate(.Fecha)

               If .Update() Then
                  lngCompDetId = .CompDetId
                  CompDetUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompEdit(ByRef lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      'Dim lngCompId As Long
      Dim lngCompDetId As Long
      Dim lngPlanIdAct As Long
      Dim lngPlanAddIdAct As Long
      Dim lngCompPlanAddId As Long
      Dim lngCompCentroCostoDetId As Long

      Dim strPlanDes As String = ""
      Dim lngMonedaIdPlan As Long = 0

      Dim decITFBs As Decimal = 0
      Dim decITFUs As Decimal = 0

      'mboolAplicarITF = False

      Try
         With moAnticipo

            ' ''Preguntado el ITF
            ''mlngTipoPlanId = TipoPlanIdFind(.PlanId, strPlanDes, lngMonedaIdPlan)
            ''If mlngTipoPlanId = 3 And lngMonedaIdPlan = clsMoneda.DOLARES Then  'Tipo Cuenta 3 = Banco -- Cuenta Corriente
            ''   If MessageBox.Show("¿Desea Aplicar I.T.F. a la Cuenta  " & strPlanDes & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ''      mboolAplicarITF = True
            ''   End If
            ''End If

            lngPlanIdAct = PlanIdActFind(.ProveedorId, lngPlanAddIdAct)

            If .MonedaId = 1 Then
               decMontoBs = ToDecimal(txtMonto.Text)
               decMontoUs = ToDecimal(ToDecimal(txtMonto.Text) / .TipoCambio)
            Else
               decMontoBs = ToDecimal(ToDecimal(txtMonto.Text) * .TipoCambio)
               decMontoUs = ToDecimal(txtMonto.Text)
            End If

            If mboolAplicarITF Then
               decITFBs = ToDecimal(decMontoBs * clsAppInfo.ITF)
               decITFUs = ToDecimal(decMontoUs * clsAppInfo.ITF)
            End If

            If isCompFind(lngCompId, lngTipoCompId, lngCompNro) Then
               'If CompFind(lngTipoCompId, lngCompNro, lngCompId) Then
               Call CompDetDeleteAutomatico(lngCompId)
               If CompUpdate(lngCompId, decMontoBs + decITFBs, decMontoUs + decITFUs) Then
                  CompEdit = True

                  If .TipoAnticipoId = 2 Then 'Anticipo
                     If CompDetUpdate(lngCompId, lngPlanIdAct, decMontoBs, decMontoUs, 1, , , lngCompDetId) Then
                        If lngPlanAddIdAct <> 0 Then 'Analitico Adicional
                           If CompPlanAddFind(lngCompId, lngCompDetId, lngCompPlanAddId) Then
                              If CompPlanAddUpdate(lngCompPlanAddId, decMontoBs, decMontoUs, 1) Then
                                 CompEdit = True
                              End If
                           End If
                        End If

                        If CompDetUpdate(lngCompId, .PlanId, decMontoBs, decMontoUs, 2, , , lngCompDetId) Then
                           If CompPlanAddFind(lngCompId, lngCompDetId, lngCompPlanAddId) Then
                              If CompPlanAddUpdate(lngCompPlanAddId, decMontoBs, decMontoUs, 2) Then
                                 CompEdit = True
                              End If
                           End If

                           If CompCentroCostoDetFind(lngCompId, lngCompDetId, lngCompCentroCostoDetId) Then
                              If CompCentroCostoDetUpdate(lngCompCentroCostoDetId, decMontoBs, decMontoUs, 2) Then
                                 CompEdit = True
                              End If
                           End If

                           If CompChequeUpdateComp(mlngCompChequeId, lngCompId, lngCompDetId) Then 'Ponerle CompId a la Factura
                              CompEdit = True
                           End If

                           ''If mlngTipoPlanId = 3 Then 'En Caso de que Tenga Chequera
                           ''   If TieneChequeraCreada(.PlanId) Then
                           ''      mlngPlanId = .PlanId
                           ''      If frmCompChequeEditLoad(lngCompId, lngCompDetId, decMontoBs, decMontoUs) Then
                           ''         CompEdit = True
                           ''      End If
                           ''   Else
                           ''      MessageBox.Show("Debe Definir la Chequera para Esta Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                           ''   End If
                           ''Else
                           ''   CompEdit = True
                           ''End If
                        End If
                     End If

                     'Aplicando ITF
                     If mboolAplicarITF Then
                        If CompDetAdd(lngTipoCompId, lngCompId, .PlanId, decITFBs, decITFUs, 2, mlngSucursalId, moAnticipo.CentroCostoId, lngCompDetId, 1) Then
                           CompEdit = True
                        End If

                        If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITFId, decITFBs, decITFUs, 1, mlngSucursalId, moAnticipo.CentroCostoId, lngCompDetId, 1) Then
                           CompEdit = True
                        End If
                     End If

                  ElseIf .TipoAnticipoId = 1 Then 'Devolucion Anticipo
                     If CompDetUpdate(lngCompId, .PlanId, decMontoBs, decMontoUs, 1, , , lngCompDetId) Then
                        If CompPlanAddFind(lngCompId, lngCompDetId, lngCompPlanAddId) Then
                           If CompPlanAddUpdate(lngCompPlanAddId, decMontoBs, decMontoUs, 1) Then
                              CompEdit = True
                           End If
                        End If

                        If CompCentroCostoDetFind(lngCompId, lngCompDetId, lngCompCentroCostoDetId) Then
                           If CompCentroCostoDetUpdate(lngCompCentroCostoDetId, decMontoBs, decMontoUs, 1) Then
                              CompEdit = True
                           End If
                        End If

                        If CompDetUpdate(lngCompId, lngPlanIdAct, decMontoBs, decMontoUs, 2, , , lngCompDetId) Then
                           If lngPlanAddIdAct <> 0 Then 'Analitico Adicional
                              If CompPlanAddFind(lngCompId, lngCompDetId, lngCompPlanAddId) Then
                                 If CompPlanAddUpdate(lngCompPlanAddId, decMontoBs, decMontoUs, 2) Then
                                    CompEdit = True
                                 End If
                              End If
                           End If
                        End If
                     End If

                     'Aplicando ITF
                     If mboolAplicarITF Then
                        If CompDetAdd(lngTipoCompId, lngCompId, .PlanId, decITFBs, decITFUs, 1, mlngSucursalId, moAnticipo.CentroCostoId, lngCompDetId, 1) Then
                           CompEdit = True
                        End If

                        If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITFId, decITFBs, decITFUs, 2, mlngSucursalId, moAnticipo.CentroCostoId, lngCompDetId, 1) Then
                           CompEdit = True
                        End If
                     End If

                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompFind(ByRef lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompFind = False

      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.All
            .WhereFilter = clsComp.WhereFilters.CompNro
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .SucursalId = moAnticipo.SucursalId

            If .Find Then
               lngCompId = .CompId
               lngTipoCompId = .TipoCompId
               lngCompNro = .CompNro

               CompFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function isCompFind(ByVal lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      isCompFind = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               lngTipoCompId = .TipoCompId
               lngCompNro = .CompNro

               isCompFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompPlanAddAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
                                 ByVal lngPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAdd = False

      Try
         With oCompPlanAdd
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moAnticipo.Fecha
            .PlanId = lngPlanId
            .MonedaId = moAnticipo.MonedaId
            .PlanAddId = lngPlanAddId
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
               CompPlanAddAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CompPlanAddUpdate(ByVal lngCompPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddUpdate = False

      Try
         With oCompPlanAdd
            .CompPlanAddId = lngCompPlanAddId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)

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

               If .Update() Then
                  CompPlanAddUpdate = True
               End If
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
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moAnticipo.Fecha
            .PlanId = lngPlanId
            .MonedaId = moAnticipo.MonedaId
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

   Private Function CompCentroCostoDetUpdate(ByVal lngCompCentroCostoDetId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompCentroCostoDetUpdate = False

      Try
         With oCompCentroCostoDet
            .CompCentroCostoDetId = lngCompCentroCostoDetId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)

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

               If .Update() Then
                  CompCentroCostoDetUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddFind(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByRef lngCompPlanAddId As Long) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddFind = False

      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.All
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
            .EmpresaId = moAnticipo.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Find Then
               lngCompPlanAddId = .CompPlanAddId
               CompPlanAddFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetFind(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByRef lngCompCentroCostoDetId As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompCentroCostoDetFind = False

      Try
         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
            .EmpresaId = moAnticipo.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Find Then
               lngCompCentroCostoDetId = .CompCentroCostoDetId
               CompCentroCostoDetFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompDetDeleteAutomatico(ByVal lngCompId As Long) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompDetDeleteAutomatico = False

      Try
         With oCompDet

            .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
            .CompId = lngCompId
            .EmpresaId = moAnticipo.EmpresaId
            .Automatico = 1

            If .Delete Then  'Dell Detalle
               CompDetDeleteAutomatico = True
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()
         oCompPlanAdd.Dispose()
         oCompCentroCostoDet.Dispose()
      End Try
   End Function

   Private Function ProveedorMovAdd(ByRef lngProveedorMovId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal lngTipoPagoId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .ProveedorId = moAnticipo.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moAnticipo.Fecha
            .ProveedorMovDes = moAnticipo.AnticipoDes
            .MonedaId = moAnticipo.MonedaId
            .TipoCambio = moAnticipo.TipoCambio
            .CentroCostoId = moAnticipo.CentroCostoId
            .SucursalId = moAnticipo.SucursalId
            .EstadoId = 11 'Abierto

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeBs = decValor
                  .DebeUs = ToDecimal(decValor / .TipoCambio)

                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberBs = decValor
                  .HaberUs = ToDecimal(decValor / .TipoCambio)

                  .DebeBs = 0
                  .DebeUs = 0
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeBs = ToDecimal(decValor * .TipoCambio)
                  .DebeUs = decValor

                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberBs = ToDecimal(decValor * .TipoCambio)
                  .HaberUs = decValor

                  .DebeUs = 0
                  .DebeBs = 0
               End If
            End If

            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .PlanId = lngPlanId

            If .Insert() Then
               lngProveedorMovId = .ProveedorMovId
               ProveedorMovAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function ProveedorMovUpdate(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, ByVal lngCol As Long, ByVal decValor As Decimal) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovUpdate = False

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.DocumentoId
            .EmpresaId = moAnticipo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .EstadoId = 11 'Abierto

            If .Find Then
               .Fecha = ToDate(.Fecha)
               .ProveedorMovDes = moAnticipo.AnticipoDes

               If .MonedaId = 1 Then
                  If lngCol = 1 Then
                     .DebeBs = decValor
                     .DebeUs = ToDecimal(decValor / .TipoCambio)

                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberBs = decValor
                     .HaberUs = ToDecimal(decValor / .TipoCambio)

                     .DebeBs = 0
                     .DebeUs = 0
                  End If

               ElseIf .MonedaId = 2 Then
                  If lngCol = 1 Then
                     .DebeBs = ToDecimal(decValor * .TipoCambio)
                     .DebeUs = decValor

                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberBs = ToDecimal(decValor * .TipoCambio)
                     .HaberUs = decValor

                     .DebeUs = 0
                     .DebeBs = 0
                  End If
               End If

               If .Update() Then
                  ProveedorMovUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function PlanMonedaIdFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanMonedaIdFind = 0

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               Return .MonedaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompNroNext = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moAnticipo.EmpresaId
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
                        If chkConFac.Checked Then
                           .NroActualFis = .NroActualFis + 1

                           If .Update Then
                              CompNroNext = .NroActualFis
                           End If

                        ElseIf chkSinFac.Checked Then
                           .NroActual = .NroActual + 1

                           If .Update Then
                              CompNroNext = .NroActual
                           End If
                        End If
                     End If
                  Else
                     CompNroNext = CompNroMesNext(lngTipoCompId, lngGestionId, lngSucursalId, dtpFecha.Value.Month)
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

   Private Function CompNroMesNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByVal intMesId As Integer) As Long
      Dim oCompParaMes As New clsCompParaMes(clsAppInfo.ConnectString)

      Try
         CompNroMesNext = 0

         With oCompParaMes
            .SelectFilter = clsCompParaMes.SelectFilters.All
            .WhereFilter = clsCompParaMes.WhereFilters.MesId
            .EmpresaId = moAnticipo.EmpresaId
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
                  If chkConFac.Checked Then
                     .NroActualFis = .NroActualFis + 1

                     If .Update Then
                        CompNroMesNext = .NroActualFis
                     End If

                  ElseIf chkSinFac.Checked Then
                     .NroActual = .NroActual + 1

                     If .Update Then
                        CompNroMesNext = .NroActual
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompParaMes.Dispose()

      End Try
   End Function

   Private Function PlanIdActFind(ByVal lngProveedorId As Long, ByRef lngPlanAddIdAct As Long) As Long
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      PlanIdActFind = 0

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               lngPlanAddIdAct = .PlanAddIdAct
               Return .PlanIdAct
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function TieneChequeraCreada(ByVal lngPlanId As Long) As Boolean
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      TieneChequeraCreada = False

      Try
         With oCheque
            .SelectFilter = clsCheque.SelectFilters.All
            .WhereFilter = clsCheque.WhereFilters.PlanId
            .EmpresaId = moAnticipo.EmpresaId
            .PlanId = lngPlanId

            If .Find Then
               TieneChequeraCreada = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCheque.Dispose()

      End Try
   End Function

   Private Function frmCompChequeEditLoad(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal decMonto As Decimal) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      Dim frm As New frmCompChequeEdit
      Dim boolFind As Boolean = False

      Try
         frmCompChequeEditLoad = False

         With oCompCheque

            If lngCompId > 0 Then
               .SelectFilter = clsCompCheque.SelectFilters.All
               .WhereFilter = clsCompCheque.WhereFilters.CompDetId
               .CompDetId = lngCompDetId

               If .Find Then
                  boolFind = True
               End If
            End If

            Dim lngMonedaId As Long = MonedaIdFind(lngPlanId)

            If boolFind Then
               frm.NewRecord = False
               frm.Editing = True
               frm.DesdeComp = True

               .CompId = ToLong(lngCompId)
               .CompDetId = ToLong(lngCompDetId)
               '.Fecha = ConvertDMY(moAnticipo.Fecha)
               .MonedaId = lngMonedaId
               .TipoCambio = moAnticipo.TipoCambio
               .ChequeDes = IIf(.ChequeDes <> String.Empty, .ChequeDes, ToStr(cboProveedor.Text))
               .EstadoId = 10

               If moAnticipo.MonedaId = 1 Then
                  If lngMonedaId = 1 Then
                     .ChequeMonto = ToDecimal(decMonto)
                  Else
                     .ChequeMonto = ToDecimal(decMonto / ToDecimal(txtTipoCambio.Text))
                  End If

               Else
                  If lngMonedaId = 2 Then
                     .ChequeMonto = ToDecimal(decMonto)
                  Else
                     .ChequeMonto = ToDecimal(decMonto * ToDecimal(txtTipoCambio.Text))
                  End If
               End If

            Else
               frm.NewRecord = True
               frm.Editing = False
               frm.DesdeComp = True

               .EmpresaId = ToLong(moAnticipo.EmpresaId)
               .GestionId = ToLong(moAnticipo.GestionId)
               .CompId = lngCompId
               .CompDetId = lngCompDetId
               .PlanId = lngPlanId
               .MonedaId = lngMonedaId
               .TipoCambio = moAnticipo.TipoCambio
               .Fecha = ConvertDMY(moAnticipo.Fecha)
               .ChequeDes = ToStr(cboProveedor.Text)
               .EstadoId = 10

               If moAnticipo.MonedaId = 1 Then
                  If lngMonedaId = 1 Then
                     .ChequeMonto = ToDecimal(decMonto)
                  Else
                     .ChequeMonto = ToDecimal(decMonto / ToDecimal(txtTipoCambio.Text))
                  End If

               Else
                  If lngMonedaId = 2 Then
                     .ChequeMonto = ToDecimal(decMonto)
                  Else
                     .ChequeMonto = ToDecimal(decMonto * ToDecimal(txtTipoCambio.Text))
                  End If
               End If

            End If

            frm.DataObject = oCompCheque
            frm.ShowDialog()

            If frm.Changed Then
               mlngCompChequeId = frm.ID
               frmCompChequeEditLoad = True

            ElseIf boolFind Then
               frmCompChequeEditLoad = False

            Else
               frmCompChequeEditLoad = True
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Function CompChequeUpdateComp(ByVal lngCompChequeId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Boolean
      If lngCompChequeId = 0 Then
         Return True
      End If

      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      CompChequeUpdateComp = False

      Try
         With oCompCheque
            .CompChequeId = lngCompChequeId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .FechaCob = ToDate(.FechaCob)
               .CompId = lngCompId
               .CompDetId = lngCompDetId
               .EstadoId = 10

               Return .Update()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Function MonedaIdFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         MonedaIdFind = False

         oPlan.PlanId = lngPlanId

         If oPlan.FindByPK Then
            MonedaIdFind = oPlan.MonedaId
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
            .EmpresaId = moAnticipo.EmpresaId
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

   Private Sub FormInit()
      Call FormCenter(Me)

      txtTipoCambio.FormatString = DecimalMask()
      txtPedCompraTipoCambio.FormatString = DecimalMask()
      txtPedCompraMonto.FormatString = DecimalMask()
      txtMontoAnt.FormatString = DecimalMask()
      txtMonto.FormatString = DecimalMask()
      txtMontoDes.FormatString = DecimalMask()
      txtMontoPen.FormatString = DecimalMask()

   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboEstadoLoad()
      Call cboTipoAnticipoLoad()
      Call cboProveedorLoad()
      Call cboCentroCostoLoad(moAnticipo.CentroCostoId)
      Call cboSucursalLoad(moAnticipo.TipoAnticipoId)
   End Sub

   Private Sub cboMonedaLoad()
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMoneda.Items.Clear()

      Try
         With oMoneda
            .SelectFilter = clsMoneda.SelectFilters.ListBox
            .OrderByFilter = clsMoneda.OrderByFilters.MonedaDes

            If .Open() Then
               Do While .Read()
                  If .MonedaId > 0 Then
                     oItem = New clsListItem(.MonedaId, .MonedaDes)

                     cboMoneda.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMoneda.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoAnticipoLoad()
      Dim oTipoAnticipo As New clsTipoAnticipo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoAnticipo.Items.Clear()

      Try
         With oTipoAnticipo
            .SelectFilter = clsTipoAnticipo.SelectFilters.ListBox
            .OrderByFilter = clsTipoAnticipo.OrderByFilters.TipoAnticipoDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoAnticipoId, .TipoAnticipoDes)

                  cboTipoAnticipo.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoAnticipo.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboProveedorLoad()
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oListItem As clsListItem

      cboProveedor.DropDownList.Columns.Clear()

      Try
         With oProveedor
            .SelectFilter = clsProveedor.SelectFilters.ListBox
            .WhereFilter = clsProveedor.WhereFilters.EstadoId
            .OrderByFilter = clsProveedor.OrderByFilters.ProveedorDes
            .EmpresaId = moAnticipo.EmpresaId
            .ProveedorId = moAnticipo.ProveedorId
            .EstadoId = 1

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
                  oItem = New clsListItem(.EstadoId, .EstadoDes)

                  cboEstado.Items.Add(oItem)
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

   Private Sub cboPedCompraLoad(ByVal lngProveedorId As Long, Optional ByVal lngPedCompraId As Long = 0)
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPedCompra.Items.Clear()
      cboPedCompra.Text = ""

      Try
         With oPedCompra
            .SelectFilter = clsPedCompra.SelectFilters.All

            If (mboolEditing And clsAppInfo.CentroCostoApli) Then
               .WhereFilter = clsPedCompra.WhereFilters.EstadoId_CentroCosto
               .CentroCostoId = moAnticipo.CentroCostoId
               .EstadoId = clsEstado.APROBADO ''13
            Else
               .WhereFilter = clsPedCompra.WhereFilters.EstadoId
               .EstadoId = clsEstado.APROBADO ''13
            End If

            .OrderByFilter = clsPedCompra.OrderByFilters.PedCompraNro
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = lngProveedorId
            .SucursalId = moAnticipo.SucursalId
            .PedCompraId = lngPedCompraId

            If .Open() Then
               oItem = New clsListItem(0, "Sin Pedido")
               cboPedCompra.Items.Add(oItem)

               Do While .Read()
                  oItem = New clsListItem(.PedCompraId, ToStr(.PedCompraNro))

                  cboPedCompra.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboAnticipoLoad(ByVal lngProveedorId As Long, Optional ByVal lngAnticipoId As Long = 0)
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboAnticipo.Items.Clear()
      cboAnticipo.Text = ""

      Try
         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.All
            .WhereFilter = clsAnticipo.WhereFilters.ProveedorEstadoId
            .OrderByFilter = clsAnticipo.OrderByFilters.AnticipoNro
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = lngProveedorId
            .AnticipoId = lngAnticipoId
            .TipoAnticipoId = 2 'Anticipo
            .SucursalId = moAnticipo.SucursalId
            .EstadoId = 13

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.AnticipoId, ToStr(.AnticipoNro))

                  cboAnticipo.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboCentroCostoLoad(ByVal lngCentroCostoId As Long)
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCosto.Items.Clear()
      cboCentroCosto.Text = ""
      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.ListBox
            .WhereFilter = clsCentroCosto.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = clsAppInfo.EmpresaId
            .EstadoId = 1
            .CentroCostoId = lngCentroCostoId
            ''.CentroCostoId = moAnticipo.CentroCostoId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.CentroCostoId, .CentroCostoDes)

                  cboCentroCosto.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboSucursalLoad(ByVal lngTipoAnticipoId As Long)
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSucursal.Items.Clear()

      Try
         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.SucursalListBox
            .WhereFilter = clsCompraPara.WhereFilters.SucursalListBox
            .OrderByFilter = clsCompraPara.OrderByFilters.SucursalListBox
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoCompraId = IIf(lngTipoAnticipoId = clsTipoAnticipo.ANTICIPO, clsTipoCompra.ANTICIPO, clsTipoCompra.DEVOLUCION_ANTICIPO)

            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  oItem = New clsListItem(oRow("SucursalId"), oRow("SucursalDes"))

                  cboSucursal.Items.Add(oItem)
               Next

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub txtTipoCambioLoad(ByVal strFecha As String)
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      Try
         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = strFecha

            If .Find Then
               txtTipoCambio.Tag = .TipoCambioId
               txtTipoCambio.Text = ToStr(.Valor)
            Else
               txtTipoCambio.Tag = 0
               txtTipoCambio.Text = 0
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub

   Private Sub txtPedCompraNroOrgLoad(ByVal lngPedCompraId As Long)
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         With oPedCompra
            If lngPedCompraId <> 0 Then
               .PedCompraId = lngPedCompraId

               If .FindByPK Then
                  txtPedCompraNroOrg.Text = ToStr(.PedCompraNro)
                  txtPedCompraNroOrg.Tag = .PedCompraId
               Else
                  txtPedCompraNroOrg.Text = 0
                  txtPedCompraNroOrg.Tag = 0
               End If
            Else
               txtPedCompraNroOrg.Text = 0
               txtPedCompraNroOrg.Tag = 0
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub PedCompraIdLoad(ByVal lngPedCompraId As Long)
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         With oPedCompra
            If lngPedCompraId <> 0 Then
               .PedCompraId = lngPedCompraId

               If .FindByPK Then
                  dtpPedCompraFecha.Text = ToStr(.Fecha)
                  txtPedCompraMonedaDes.Text = MonedaDesFind(.MonedaId)
                  txtPedCompraTipoCambio.Text = ToDecStr(.TipoCambio)
                  txtPedCompraAlmacenDes.Text = AlmacenDesFind(.AlmacenId)
                  txtPedCompraDes.Text = ToStr(.PedCompraDes)
                  txtAnticipoDes.Text = ToStr(.PedCompraDes)
                  txtPedCompraMonto.Text = ToStr(.MontoLiq)
                  txtMontoAnt.Text = ToDecStr(AnticipoAnterior(lngPedCompraId))

                  If .CentroCostoId > 0 Then
                     Call cboCentroCostoLoad(.CentroCostoId)
                     cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
                     cboCentroCosto.ReadOnly = True
                  Else
                     Call cboCentroCostoLoad(moAnticipo.CentroCostoId)
                     cboCentroCosto.SelectedIndex = -1
                     cboCentroCosto.ReadOnly = True
                  End If


               Else
                  dtpPedCompraFecha.Text = String.Empty
                  txtPedCompraMonedaDes.Text = String.Empty
                  txtPedCompraTipoCambio.Text = "0"
                  txtPedCompraAlmacenDes.Text = String.Empty
                  txtPedCompraDes.Text = String.Empty
                  txtAnticipoDes.Text = String.Empty
                  txtPedCompraMonto.Text = "0"

                  txtMontoAnt.Text = "0"

                  If mboolAdding Then
                     Call cboCentroCostoLoad(moAnticipo.CentroCostoId)
                     cboCentroCosto.SelectedIndex = -1
                     cboCentroCosto.Enabled = True
                  End If
               End If
            Else
               dtpPedCompraFecha.Text = String.Empty
               txtPedCompraMonedaDes.Text = String.Empty
               txtPedCompraTipoCambio.Text = "0"
               txtPedCompraAlmacenDes.Text = String.Empty
               txtPedCompraDes.Text = String.Empty
               txtPedCompraMonto.Text = "0"

               txtMontoAnt.Text = "0"

               Call cboCentroCostoLoad(moAnticipo.CentroCostoId)
               cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, moAnticipo.CentroCostoId)

               If mboolAdding Then
                  cboCentroCosto.Enabled = True
                  cboCentroCosto.ReadOnly = False
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Function AnticipoAnterior(ByVal lngPedCompraId As Long) As Decimal
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim decMontoAnt As Decimal = 0
      Dim decMontoDev As Decimal = 0

      Try
         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.All
            .WhereFilter = clsAnticipo.WhereFilters.PedCompraId
            .EmpresaId = moAnticipo.EmpresaId
            .PedCompraId = lngPedCompraId

            If .Open Then
               Do While .Read
                  If .AnticipoId <> moAnticipo.AnticipoId Then
                     If .TipoAnticipoId = 2 Then 'Anticipo
                        decMontoAnt += (.MontoAnt - .MontoDes)
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         Return decMontoAnt

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Sub AnticipoIdLoad(ByVal lngAnticipoId As Long)
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

      Try
         With oAnticipo

            If clsAppInfo.MultipleNro Then
               chkConFac.Checked = False
               chkSinFac.Checked = False

            Else
               chkConFac.Checked = False
               chkSinFac.Checked = True

               chkConFac.Visible = False
               chkSinFac.Visible = False
            End If

            If lngAnticipoId <> 0 Then
               .AnticipoId = lngAnticipoId

               If .FindByPK Then
                  cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
                  dtpFechaOrg.Text = ToStr(.Fecha)
                  Call txtPedCompraNroOrgLoad(.PedCompraId)
                  txtMonedaDesOrg.Text = MonedaDesFind(.MonedaId)
                  txtTipoCambioOrg.Text = ToDecStr(.TipoCambio)
                  txtAnticipoDesOrg.Text = ToStr(.AnticipoDes)
                  txtMontoOrg.Text = ToDecStr(.MontoAnt)
                  txtMontoDesOrg.Text = ToDecStr(.MontoDes)
                  txtMontoPenOrg.Text = ToDecStr(.MontoAnt - .MontoDes)
                  txtAnticipoOrden.Text = ToStr(.AnticipoOrden)

                  chkConFac.Checked = .ConFac
                  chkSinFac.Checked = .SinFac

                  If Not clsAppInfo.MultipleNro Then
                     chkConFac.Visible = False
                     chkSinFac.Visible = False
                  End If

                  If .CentroCostoId > 0 Then
                     Call cboCentroCostoLoad(.CentroCostoId)
                     cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
                     cboCentroCosto.ReadOnly = True
                  Else
                     Call cboCentroCostoLoad(moAnticipo.CentroCostoId)
                     cboCentroCosto.SelectedIndex = -1
                     cboCentroCosto.ReadOnly = True
                  End If

               Else
                  dtpFechaOrg.Text = String.Empty
                  txtPedCompraNroOrg.Text = 0
                  txtPedCompraNroOrg.Tag = 0
                  txtMonedaDesOrg.Text = String.Empty
                  txtTipoCambioOrg.Text = "0"
                  txtAnticipoDesOrg.Text = String.Empty
                  txtMontoOrg.Text = "0"
                  txtMontoAnt.Text = "0"

                  If mboolAdding Then
                     Call cboCentroCostoLoad(moAnticipo.CentroCostoId)
                     cboCentroCosto.SelectedIndex = -1
                     cboCentroCosto.Enabled = True
                  End If
               End If
            Else
               dtpFechaOrg.Text = String.Empty
               txtPedCompraNroOrg.Text = 0
               txtPedCompraNroOrg.Tag = 0
               txtMonedaDesOrg.Text = String.Empty
               txtTipoCambioOrg.Text = "0"
               txtAnticipoDesOrg.Text = String.Empty
               txtMontoOrg.Text = "0"

               txtMontoAnt.Text = "0"

               Call cboCentroCostoLoad(moAnticipo.CentroCostoId)
               cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, moAnticipo.CentroCostoId)

               If mboolAdding Then
                  cboCentroCosto.Enabled = True
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Sub

   Private Function AnticipoDetAnticipoIdFind(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Long
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoDetAnticipoIdFind = 0

      Try
         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.DocumentoId
            .EmpresaId = moAnticipo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId

            If .Find Then
               AnticipoDetAnticipoIdFind = .AnticipoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

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

   Private Function AlmacenDesFind(ByVal lngAlmacenId As Long) As String
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)

      Try
         With oAlmacen
            .SelectFilter = clsAlmacen.SelectFilters.All
            .WhereFilter = clsAlmacen.WhereFilters.PrimaryKey
            .AlmacenId = lngAlmacenId

            If .Find Then
               AlmacenDesFind = .AlmacenDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAlmacen.Dispose()

      End Try
   End Function

   Private Sub frmAnticipoDetLoad()
      Dim frm As New frmAnticipoDet

      frm.EmpresaId = moAnticipo.EmpresaId
      frm.AnticipoId = moAnticipo.AnticipoId
      frm.ShowDialog()
      frm.Dispose()
   End Sub

   Private Function TieneMovimiento() As Boolean
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      TieneMovimiento = False

      Try
         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.AnticipoId
            .EmpresaId = moAnticipo.EmpresaId
            .AnticipoId = moAnticipo.AnticipoId
            .EstadoId = 11

            If .Find Then
               Return True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function AnticipoAnular() As Boolean
      AnticipoAnular = False
      Try
         If moAnticipo.TipoAnticipoId = 2 Then 'Anticipo
            If MessageBox.Show("¿Realmente quiere Anular el Anticipo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               'If CompAnular(moAnticipo.TipoCompId, moAnticipo.CompNro, clsAppInfo.SucursalId, 12) Then
               If CompAnular(moAnticipo.CompId, 12) Then
                  If ProveedorMovAnular(4, moAnticipo.AnticipoId) Then
                     If AnticipoAnular(moAnticipo.AnticipoId, 12) Then
                        AnticipoAnular = True
                     End If
                  End If
               End If
            End If

         ElseIf moAnticipo.TipoAnticipoId = 1 Then  'Devolucion
            If MessageBox.Show("¿Realmente quiere Anular la Devolución de Anticipo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               'If CompAnular(moAnticipo.TipoCompId, moAnticipo.CompNro, clsAppInfo.SucursalId, 12) Then
               If CompAnular(moAnticipo.CompId, 12) Then
                  If ProveedorMovAnular(5, moAnticipo.AnticipoId) Then
                     If AnticipoRestoreUpdate(5, moAnticipo.AnticipoId) Then
                        If AnticipoAnular(moAnticipo.AnticipoId, 12) Then
                           AnticipoAnular = True
                        End If
                     End If
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function ProveedorMovAnular(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAnular = False

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.DocumentoId
            .EmpresaId = moAnticipo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .EstadoId = 11 'Abierto

            If .Find Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = 12 'Anulado

               If .Update Then
                  ProveedorMovAnular = True
               End If
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function AnticipoAnular(ByVal lngAnticipoId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

      AnticipoAnular = False

      Try
         With oAnticipo
            .AnticipoId = lngAnticipoId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = lngEstadoId

               If .Update Then
                  AnticipoAnular = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function AnticipoRestoreUpdate(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Boolean
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      Try
         AnticipoRestoreUpdate = True

         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.DocumentoId
            .EmpresaId = moAnticipo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId

            If .Find Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = 12

               If .Update Then
                  oAnticipo.AnticipoId = oAnticipoDet.AnticipoId
                  If oAnticipo.FindByPK Then
                     oAnticipo.Fecha = ToDate(oAnticipo.Fecha)
                     oAnticipo.MontoDes -= oAnticipoDet.Monto
                     oAnticipo.EstadoId = 13 'Pendiente

                     If oAnticipo.Update() Then
                        AnticipoRestoreUpdate = True
                     End If
                  End If
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()
         oAnticipoDet.Dispose()
      End Try

   End Function

   Private Function CompAnular(ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngSucursalId As Long, ByVal lngEstadoId As Long) As Boolean

      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      CompAnular = True

      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.All
            .WhereFilter = clsComp.WhereFilters.CompNro
            .EmpresaId = moAnticipo.EmpresaId
            .GestionId = moAnticipo.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .SucursalId = lngSucursalId

            If .Find Then
               If CompDetAnular(.CompId, lngEstadoId) Then
                  If CompPlanAddAnular(.CompId, lngEstadoId) Then
                     If CompCCDetAnular(.CompId, lngEstadoId) Then
                        If CompChequeAnular(.CompId, lngEstadoId) Then
                           .Fecha = ToDate(.Fecha)
                           .EstadoId = lngEstadoId

                           If .Update Then
                              CompAnular = True
                           End If
                        End If
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      If lngCompId = 0 Then
         Return True
      End If

      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      CompAnular = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then

               If CompDetAnular(.CompId, lngEstadoId) Then
                  If CompPlanAddAnular(.CompId, lngEstadoId) Then
                     If CompCCDetAnular(.CompId, lngEstadoId) Then
                        If CompChequeAnular(.CompId, lngEstadoId) Then

                           .Fecha = ToDate(.Fecha)
                           .EstadoId = lngEstadoId

                           If .Update Then
                              CompAnular = True
                           End If
                        End If
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompDetAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetAnular = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moAnticipo.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     CompDetAnular = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAnular = False

      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.All
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompId
            .EmpresaId = moAnticipo.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     CompPlanAddAnular = True
                  End If

                  .MoveNext()
               Loop
            Else
               CompPlanAddAnular = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CompCCDetAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompCCDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      CompCCDetAnular = False

      Try
         With oCompCCDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompId
            .EmpresaId = moAnticipo.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .UpdateOnly Then
                     CompCCDetAnular = True
                  End If

                  .MoveNext()
               Loop

            Else
               CompCCDetAnular = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCCDet.Dispose()
      End Try
   End Function

   Private Function CompChequeAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      CompChequeAnular = False

      Try
         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompId
            .EmpresaId = moAnticipo.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .FechaCob = ToDate(.FechaCob)
                  .EstadoId = lngEstadoId

                  If .UpdateOnly Then
                     CompChequeAnular = True
                  End If

                  .MoveNext()
               Loop

            Else
               CompChequeAnular = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()
      End Try
   End Function

   Private Function GetCodNroOrden() As String
      Dim strTexto As String

      strTexto = "AC-"
      If ListPosition(cboProveedor) <> 0 Then
         strTexto = strTexto & ToStr(cboProveedor.DropDownList.GetRow.Cells("ProveedorCod").Value)
      End If

      strTexto = strTexto & "-"
      If cboCentroCosto.SelectedIndex <> -1 Then
         strTexto = strTexto & CentroCostoCodFind(ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex))

      End If

      strTexto = strTexto & "-"

      GetCodNroOrden = strTexto

   End Function

   Private Function CentroCostoCodFind(ByVal lngCentroCostoId As Long) As String
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)

      CentroCostoCodFind = ""

      Try
         With oCentroCosto
            .CentroCostoId = lngCentroCostoId

            If .FindByPK Then
               CentroCostoCodFind = .CentroCostoCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()

      End Try
   End Function

   Private Sub PrintReport()
      Dim MyFile
      Dim rpt As New rptAnticipoEdit
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim strTitulo As String

      Try
         oAnticipo.SelectFilter = clsAnticipo.SelectFilters.Report
         oAnticipo.WhereFilter = clsAnticipo.WhereFilters.Report
         oAnticipo.OrderByFilter = clsAnticipo.OrderByFilters.Report
         oAnticipo.EmpresaId = moAnticipo.EmpresaId
         oAnticipo.AnticipoId = moAnticipo.AnticipoId

         If oAnticipo.Find Then
            rpt.DataSource = oAnticipo.DataSet.Tables(oAnticipo.TableName).DefaultView

            If moAnticipo.TipoAnticipoId = 1 Then 'Devolucion
               rpt.lblEntregadoA.Text = "Hemos recibido de:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.txtFirma.Text = CompraParaFirma(5, moAnticipo.GestionId, moAnticipo.SucursalId, strTitulo, lngTipoHojaId)

            ElseIf moAnticipo.TipoAnticipoId = 2 Then 'Anticipo
               rpt.lblEntregadoA.Text = "Hemos entregado a:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.txtFirma.Text = CompraParaFirma(4, moAnticipo.GestionId, moAnticipo.SucursalId, strTitulo, lngTipoHojaId)
            End If

            rpt.lblTitle.Text = strTitulo
            rpt.Document.Name = strTitulo
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

            If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As frmReportPreview
               frm = New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As frmReportPreviewMultiple
               frm = New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = lngTipoHojaId
               frm.Show()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Sub

   Private Function CompraParaFirma(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByRef strTitulo As String, ByRef lngTipoHojaId As Long) As String
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaFirma = ""

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moAnticipo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               strTitulo = .Titulo
               lngTipoHojaId = .TipoHojaId
               CompraParaFirma = .Firma
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
      If mboolAdding Then
         If Not IsNothing(moAnticipo) Then
            If dtpFecha.Tag <> dtpFecha.Text Then
               If IsDate(dtpFecha.Text) Then
                  Call txtTipoCambioLoad(ToDate(dtpFecha.Value))
                  dtpFecha.Tag = dtpFecha.Text
               Else
                  txtTipoCambio.Text = 0
               End If
            End If
         End If
      End If
   End Sub

   Private Sub cboTipoAnticipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoAnticipo.LostFocus
      If cboTipoAnticipo.Tag <> cboTipoAnticipo.Text Then
         cboTipoAnticipo.Tag = cboTipoAnticipo.Text

         If clsAppInfo.MultipleNro Then
            chkConFac.Checked = False
            chkSinFac.Checked = False
         Else
            chkConFac.Checked = False
            chkSinFac.Checked = True

            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

         If mboolAdding Then
            If ListPosition(cboTipoAnticipo, cboTipoAnticipo.SelectedIndex) = 1 Then 'Devolucion Anticipo
               grbPedCompra.Visible = False
               grbAnticipo.Visible = True
               cboMoneda.ReadOnly = True
               cboMoneda.Text = String.Empty
               cboProveedor.Text = ""
               cboProveedor.Tag = ""

               cboPedCompra.Items.Clear()
               cboPedCompra.Text = ""
               lblPedCompra.Visible = False
               cboPedCompra.Visible = False
               lblAnticipo.Visible = True
               cboAnticipo.Visible = True

               cboCentroCosto.SelectedIndex = -1
               cboCentroCosto.ReadOnly = True
               Call cboSucursalLoad(1)
               cboSucursal.SelectedIndex = ListFindItem(cboSucursal, clsAppInfo.SucursalId)

            Else
               grbPedCompra.Visible = True
               grbAnticipo.Visible = False
               cboMoneda.ReadOnly = False
               cboProveedor.Text = ""
               cboProveedor.Tag = ""

               cboAnticipo.Items.Clear()
               cboAnticipo.Text = ""
               lblPedCompra.Visible = True
               cboPedCompra.Visible = True
               lblAnticipo.Visible = False
               cboAnticipo.Visible = False

               cboCentroCosto.SelectedIndex = -1
               cboCentroCosto.ReadOnly = False
               Call cboSucursalLoad(2)
               cboSucursal.SelectedIndex = ListFindItem(cboSucursal, clsAppInfo.SucursalId)

            End If

         End If
      End If
   End Sub

   Private Sub cboProveedor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProveedor.LostFocus
      If cboProveedor.Tag <> cboProveedor.Text Then
         cboProveedor.Tag = cboProveedor.Text

         If ListPosition(cboTipoAnticipo, cboTipoAnticipo.SelectedIndex) = 1 Then 'Devolucion Anticipo
            Call cboAnticipoLoad(ListPosition(cboProveedor))
         Else
            Call cboPedCompraLoad(ListPosition(cboProveedor))
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

   Private Sub cboAnticipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAnticipo.LostFocus
      If cboAnticipo.Tag <> cboAnticipo.Text Then
         cboAnticipo.Tag = cboAnticipo.Text

         Call AnticipoIdLoad(ListPosition(cboAnticipo, cboAnticipo.SelectedIndex))
      End If
   End Sub

   Private Sub cboCentroCosto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroCosto.SelectedIndexChanged
      If mboolAdding And clsAppInfo.CentroCostoApli Then
         txtAnticipoOrden.Text = GetCodNroOrden()
      End If
   End Sub

   Private Sub cboPedCompra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPedCompra.LostFocus
      If cboPedCompra.Tag <> cboPedCompra.Text Then
         cboPedCompra.Tag = cboPedCompra.Text

         Call PedCompraIdLoad(ListPosition(cboPedCompra, cboPedCompra.SelectedIndex))
      End If
   End Sub

   Private Sub cboProveedor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedor.ValueChanged
      If mboolAdding And clsAppInfo.CentroCostoApli Then
         txtAnticipoOrden.Text = GetCodNroOrden()
      End If
   End Sub

#Region "Numeracion Sucursal"

   Private Sub cboSucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSucursal.SelectedIndexChanged
      If Not mboolShow Then
         If mboolAdding Then
            moAnticipo.SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
            If ListPosition(cboTipoAnticipo, cboTipoAnticipo.SelectedIndex) = 1 Then 'Devolucion Anticipo
               Call cboAnticipoLoad(ListPosition(cboProveedor))
            Else
               Call cboPedCompraLoad(ListPosition(cboProveedor))
            End If
         End If
      End If
   End Sub

#End Region

   Private Sub frmAnticipoEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If Save.Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moAnticipo.AnticipoId
                  mboolChanged = True
                  chkConFac.Enabled = False

                  cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
                  cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

                  If MessageBox.Show("Documento Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Documento?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     Call PrintReport()
                  End If

                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmAnticipoEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moAnticipo.Dispose()
      Call ClearMemory()
   End Sub

End Class
