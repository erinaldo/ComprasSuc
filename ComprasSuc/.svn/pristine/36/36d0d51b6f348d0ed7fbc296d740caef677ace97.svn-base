Public Class frmCompraEdit
   Inherits System.Windows.Forms.Form

   Private moCompra As clsCompra
   Private moCompraDet As clsCompraDet
   Private mqueItem As New Queue

   Private mdecMontoOrg As Decimal
   Private mdecMontoRec As Decimal
   Private mdecMontoDes As Decimal
   Private mlngItemCant As Long

   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngTipoPlanId As Long

   Private mlngTipoItemId As Long
   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long
   Private mboolControlLote As Boolean
   Private mboolControlSerie As Boolean
   Private mboolTieneInv As Boolean

   Private mboolCreditoAuto As Boolean
   Private mlngCreditoDias As Long
   Private mdecInteresAnual As Decimal

   Private mdecPrecioPPP As Decimal
   Private mdecPrecioUPC As Decimal
   Private mdecSaldoItem As Decimal

   Private mdecCantidadMin As Decimal
   Private mdecCantidadMax As Decimal

   Private mdecPrecioCif As Decimal
   Private mdecImporteCif As Decimal

   Private mdatFecha As Date

   Private mlngCompraIdDuplicate As Long
   Private mboolDuplicate As Boolean

   Private mboolNotaEditDelete As Boolean

   Private mboolEditarProvPed As Boolean
   Private mboolUpdatePrecioVen As Boolean
   Private mboolActualizarPreciosVenta As Boolean

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private modtDelete As DataTable

   'Dataset que contiene dos tablas de lotes y series
   Private moDataSetDet As DataSet
   Private mlstPedidos As New Hashtable
   Private mlstPedCompra As New Queue

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditGrid As Boolean

   Friend WithEvents grbDesRec As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtPorcentajeDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPorcentajeRec As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtMontoDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtMontoRec As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoLiq As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents chkSinFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents grpSucursal As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Friend WithEvents cboAlmacen As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblAlmacenDes As System.Windows.Forms.Label
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

   WriteOnly Property DataObject() As clsCompra
      Set(ByVal Value As clsCompra)
         moCompra = Value
      End Set
   End Property

   WriteOnly Property Duplicate() As Boolean
      Set(ByVal Value As Boolean)
         mboolDuplicate = Value
      End Set
   End Property

   Property CompraIdDuplicate() As Long
      Get
         Return mlngCompraIdDuplicate
      End Get

      Set(ByVal Value As Long)
         mlngCompraIdDuplicate = Value
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
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents txtCompraId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents grpDatos As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtCompraNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtCompraDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtCompraObs As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNew As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents SaveTemp As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Anular As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtMontoOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents chkProveedor As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cboTipoPago As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents PedCompra As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents PedCompra1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents txtCompraOrden As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Anular1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraEdit))
        Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
        Me.grdMain = New Janus.Windows.GridEX.GridEX
        Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
        Me.grpSucursal = New Janus.Windows.EditControls.UIGroupBox
        Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.cboAlmacen = New Janus.Windows.EditControls.UIComboBox
        Me.lblAlmacenDes = New System.Windows.Forms.Label
        Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.grbDesRec = New Janus.Windows.EditControls.UIGroupBox
        Me.txtPorcentajeDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtPorcentajeRec = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMontoDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtMontoRec = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.txtMontoLiq = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMontoOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.chkSinFac = New Janus.Windows.EditControls.UICheckBox
        Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
        Me.txtCompraObs = New Janus.Windows.GridEX.EditControls.EditBox
        Me.grpDatos = New Janus.Windows.EditControls.UIGroupBox
        Me.lblCentroCosto = New System.Windows.Forms.Label
        Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
        Me.chkProveedor = New Janus.Windows.EditControls.UICheckBox
        Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCompraDes = New Janus.Windows.GridEX.EditControls.EditBox
        Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCompraOrden = New Janus.Windows.GridEX.EditControls.EditBox
        Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
        Me.cboTipoPago = New Janus.Windows.EditControls.UIComboBox
        Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
        Me.txtCompraNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtCompraId = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.mnuMain = New System.Windows.Forms.ContextMenu
        Me.mnuShow = New System.Windows.Forms.MenuItem
        Me.mnuNew = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.PedCompra1 = New Janus.Windows.UI.CommandBars.UICommand("PedCompra")
        Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Anular1 = New Janus.Windows.UI.CommandBars.UICommand("Anular")
        Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
        Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
        Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
        Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
        Me.SaveTemp = New Janus.Windows.UI.CommandBars.UICommand("SaveTemp")
        Me.Anular = New Janus.Windows.UI.CommandBars.UICommand("Anular")
        Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
        Me.PedCompra = New Janus.Windows.UI.CommandBars.UICommand("PedCompra")
        Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.ExplorerBarContainerControl4.SuspendLayout()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bcgMain.SuspendLayout()
        CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSucursal.SuspendLayout()
        CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ebrMain.SuspendLayout()
        CType(Me.grbDesRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDesRec.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grpDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatos.SuspendLayout()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
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
        Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(720, 170)
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
        Me.grdMain.Size = New System.Drawing.Size(720, 170)
        Me.grdMain.TabIndex = 3
        Me.grdMain.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'bcgMain
        '
        Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.bcgMain.Controls.Add(Me.grpSucursal)
        Me.bcgMain.Controls.Add(Me.ebrMain)
        Me.bcgMain.Controls.Add(Me.grbDesRec)
        Me.bcgMain.Controls.Add(Me.UiGroupBox3)
        Me.bcgMain.Controls.Add(Me.UiGroupBox2)
        Me.bcgMain.Controls.Add(Me.grpDatos)
        Me.bcgMain.Controls.Add(Me.grpMain)
        Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
        Me.bcgMain.Location = New System.Drawing.Point(0, 28)
        Me.bcgMain.Name = "bcgMain"
        Me.bcgMain.Size = New System.Drawing.Size(752, 454)
        Me.bcgMain.TabIndex = 161
        Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'grpSucursal
        '
        Me.grpSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSucursal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpSucursal.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grpSucursal.Controls.Add(Me.cboSucursal)
        Me.grpSucursal.Controls.Add(Me.lblSucursal)
        Me.grpSucursal.Controls.Add(Me.cboAlmacen)
        Me.grpSucursal.Controls.Add(Me.lblAlmacenDes)
        Me.grpSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpSucursal.Location = New System.Drawing.Point(8, 64)
        Me.grpSucursal.Name = "grpSucursal"
        Me.grpSucursal.Size = New System.Drawing.Size(736, 40)
        Me.grpSucursal.TabIndex = 9
        Me.grpSucursal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'cboSucursal
        '
        Me.cboSucursal.BackColor = System.Drawing.SystemColors.Info
        Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboSucursal.Location = New System.Drawing.Point(448, 12)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.ReadOnly = True
        Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboSucursal.Size = New System.Drawing.Size(280, 20)
        Me.cboSucursal.TabIndex = 11
        Me.cboSucursal.TabStop = False
        Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'lblSucursal
        '
        Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(380, 16)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(64, 16)
        Me.lblSucursal.TabIndex = 214
        Me.lblSucursal.Text = "Sucursal"
        Me.lblSucursal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboAlmacen.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboAlmacen.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboAlmacen.Location = New System.Drawing.Point(92, 12)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboAlmacen.Size = New System.Drawing.Size(256, 20)
        Me.cboAlmacen.TabIndex = 10
        Me.cboAlmacen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'lblAlmacenDes
        '
        Me.lblAlmacenDes.BackColor = System.Drawing.Color.Transparent
        Me.lblAlmacenDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlmacenDes.Location = New System.Drawing.Point(8, 16)
        Me.lblAlmacenDes.Name = "lblAlmacenDes"
        Me.lblAlmacenDes.Size = New System.Drawing.Size(80, 16)
        Me.lblAlmacenDes.TabIndex = 212
        Me.lblAlmacenDes.Text = "Almacén"
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
        ExplorerBarGroup1.ContainerHeight = 171
        ExplorerBarGroup1.Expandable = False
        ExplorerBarGroup1.Key = "Group1"
        Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
        Me.ebrMain.GroupSeparation = 4
        Me.ebrMain.Location = New System.Drawing.Point(8, 172)
        Me.ebrMain.Name = "ebrMain"
        Me.ebrMain.Size = New System.Drawing.Size(736, 203)
        Me.ebrMain.TabIndex = 16
        Me.ebrMain.Text = "ExplorerBar2"
        Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
        Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        '
        'grbDesRec
        '
        Me.grbDesRec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbDesRec.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grbDesRec.Controls.Add(Me.txtPorcentajeDes)
        Me.grbDesRec.Controls.Add(Me.txtPorcentajeRec)
        Me.grbDesRec.Controls.Add(Me.Label8)
        Me.grbDesRec.Controls.Add(Me.txtMontoDes)
        Me.grbDesRec.Controls.Add(Me.Label14)
        Me.grbDesRec.Controls.Add(Me.Label13)
        Me.grbDesRec.Controls.Add(Me.Label18)
        Me.grbDesRec.Controls.Add(Me.txtMontoRec)
        Me.grbDesRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDesRec.Location = New System.Drawing.Point(248, 384)
        Me.grbDesRec.Name = "grbDesRec"
        Me.grbDesRec.Size = New System.Drawing.Size(280, 62)
        Me.grbDesRec.TabIndex = 19
        Me.grbDesRec.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'txtPorcentajeDes
        '
        Me.txtPorcentajeDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentajeDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPorcentajeDes.FormatString = "##,##0.000"
        Me.txtPorcentajeDes.Location = New System.Drawing.Point(192, 36)
        Me.txtPorcentajeDes.Name = "txtPorcentajeDes"
        Me.txtPorcentajeDes.Size = New System.Drawing.Size(78, 20)
        Me.txtPorcentajeDes.TabIndex = 23
        Me.txtPorcentajeDes.TabStop = False
        Me.txtPorcentajeDes.Text = "0,000"
        Me.txtPorcentajeDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtPorcentajeDes.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtPorcentajeDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtPorcentajeRec
        '
        Me.txtPorcentajeRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentajeRec.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPorcentajeRec.FormatString = "##,##0.000"
        Me.txtPorcentajeRec.Location = New System.Drawing.Point(192, 12)
        Me.txtPorcentajeRec.Name = "txtPorcentajeRec"
        Me.txtPorcentajeRec.Size = New System.Drawing.Size(78, 20)
        Me.txtPorcentajeRec.TabIndex = 21
        Me.txtPorcentajeRec.TabStop = False
        Me.txtPorcentajeRec.Text = "0,000"
        Me.txtPorcentajeRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtPorcentajeRec.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtPorcentajeRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(166, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 18)
        Me.Label8.TabIndex = 263
        Me.Label8.Text = "%"
        '
        'txtMontoDes
        '
        Me.txtMontoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMontoDes.FormatString = "##,##0.000"
        Me.txtMontoDes.Location = New System.Drawing.Point(88, 36)
        Me.txtMontoDes.Name = "txtMontoDes"
        Me.txtMontoDes.Size = New System.Drawing.Size(78, 20)
        Me.txtMontoDes.TabIndex = 22
        Me.txtMontoDes.Text = "0,000"
        Me.txtMontoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtMontoDes.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtMontoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 16)
        Me.Label14.TabIndex = 206
        Me.Label14.Text = "Descuento (-)"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(166, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 18)
        Me.Label13.TabIndex = 259
        Me.Label13.Text = "%"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(4, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 16)
        Me.Label18.TabIndex = 204
        Me.Label18.Text = "Recargo (+)"
        '
        'txtMontoRec
        '
        Me.txtMontoRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoRec.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMontoRec.FormatString = "##,##0.000"
        Me.txtMontoRec.Location = New System.Drawing.Point(88, 12)
        Me.txtMontoRec.Name = "txtMontoRec"
        Me.txtMontoRec.Size = New System.Drawing.Size(78, 20)
        Me.txtMontoRec.TabIndex = 20
        Me.txtMontoRec.Text = "0,000"
        Me.txtMontoRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtMontoRec.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtMontoRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.UiGroupBox3.Controls.Add(Me.txtMontoLiq)
        Me.UiGroupBox3.Controls.Add(Me.Label3)
        Me.UiGroupBox3.Controls.Add(Me.txtMontoOrg)
        Me.UiGroupBox3.Controls.Add(Me.Label2)
        Me.UiGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UiGroupBox3.Location = New System.Drawing.Point(536, 384)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(208, 62)
        Me.UiGroupBox3.TabIndex = 24
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'txtMontoLiq
        '
        Me.txtMontoLiq.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoLiq.BackColor = System.Drawing.SystemColors.Info
        Me.txtMontoLiq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoLiq.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMontoLiq.FormatString = "##,##0.000"
        Me.txtMontoLiq.Location = New System.Drawing.Point(100, 36)
        Me.txtMontoLiq.Name = "txtMontoLiq"
        Me.txtMontoLiq.ReadOnly = True
        Me.txtMontoLiq.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoLiq.TabIndex = 26
        Me.txtMontoLiq.TabStop = False
        Me.txtMontoLiq.Text = "0,000"
        Me.txtMontoLiq.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtMontoLiq.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtMontoLiq.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 210
        Me.Label3.Text = "Total a Pagar"
        '
        'txtMontoOrg
        '
        Me.txtMontoOrg.BackColor = System.Drawing.SystemColors.Info
        Me.txtMontoOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoOrg.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMontoOrg.FormatString = "##,##0.000"
        Me.txtMontoOrg.Location = New System.Drawing.Point(100, 12)
        Me.txtMontoOrg.Name = "txtMontoOrg"
        Me.txtMontoOrg.ReadOnly = True
        Me.txtMontoOrg.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoOrg.TabIndex = 25
        Me.txtMontoOrg.TabStop = False
        Me.txtMontoOrg.Text = "0,000"
        Me.txtMontoOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtMontoOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtMontoOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 200
        Me.Label2.Text = "Total Importe"
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.UiGroupBox2.Controls.Add(Me.chkSinFac)
        Me.UiGroupBox2.Controls.Add(Me.chkConFac)
        Me.UiGroupBox2.Controls.Add(Me.txtCompraObs)
        Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 384)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(236, 62)
        Me.UiGroupBox2.TabIndex = 17
        Me.UiGroupBox2.Text = "Observaciones"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
        Me.chkSinFac.Location = New System.Drawing.Point(104, 0)
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
        Me.chkConFac.Location = New System.Drawing.Point(156, 0)
        Me.chkConFac.Name = "chkConFac"
        Me.chkConFac.Size = New System.Drawing.Size(32, 16)
        Me.chkConFac.TabIndex = 278
        Me.chkConFac.Text = "F"
        Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'txtCompraObs
        '
        Me.txtCompraObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCompraObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompraObs.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCompraObs.Location = New System.Drawing.Point(8, 16)
        Me.txtCompraObs.Multiline = True
        Me.txtCompraObs.Name = "txtCompraObs"
        Me.txtCompraObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCompraObs.Size = New System.Drawing.Size(220, 40)
        Me.txtCompraObs.TabIndex = 18
        Me.txtCompraObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtCompraObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grpDatos
        '
        Me.grpDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDatos.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grpDatos.Controls.Add(Me.lblCentroCosto)
        Me.grpDatos.Controls.Add(Me.cboCentroCosto)
        Me.grpDatos.Controls.Add(Me.chkProveedor)
        Me.grpDatos.Controls.Add(Me.cboProveedor)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.txtCompraDes)
        Me.grpDatos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpDatos.Location = New System.Drawing.Point(8, 104)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(736, 64)
        Me.grpDatos.TabIndex = 12
        Me.grpDatos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'lblCentroCosto
        '
        Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroCosto.Location = New System.Drawing.Point(392, 14)
        Me.lblCentroCosto.Name = "lblCentroCosto"
        Me.lblCentroCosto.Size = New System.Drawing.Size(52, 16)
        Me.lblCentroCosto.TabIndex = 241
        Me.lblCentroCosto.Text = "C. C."
        Me.lblCentroCosto.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblCentroCosto.Visible = False
        '
        'cboCentroCosto
        '
        Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.WindowFrame
        Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCosto.Location = New System.Drawing.Point(448, 12)
        Me.cboCentroCosto.Name = "cboCentroCosto"
        Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboCentroCosto.Size = New System.Drawing.Size(280, 20)
        Me.cboCentroCosto.TabIndex = 14
        Me.cboCentroCosto.Visible = False
        Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'chkProveedor
        '
        Me.chkProveedor.BackColor = System.Drawing.Color.Transparent
        Me.chkProveedor.Checked = True
        Me.chkProveedor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProveedor.Location = New System.Drawing.Point(76, 16)
        Me.chkProveedor.Name = "chkProveedor"
        Me.chkProveedor.Size = New System.Drawing.Size(16, 16)
        Me.chkProveedor.TabIndex = 10
        Me.chkProveedor.TabStop = False
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
        Me.cboProveedor.Size = New System.Drawing.Size(256, 20)
        Me.cboProveedor.TabIndex = 13
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
        Me.Label4.TabIndex = 239
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
        Me.Label1.Text = "Descripción"
        '
        'txtCompraDes
        '
        Me.txtCompraDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCompraDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCompraDes.Location = New System.Drawing.Point(92, 36)
        Me.txtCompraDes.MaxLength = 1000
        Me.txtCompraDes.Multiline = True
        Me.txtCompraDes.Name = "txtCompraDes"
        Me.txtCompraDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCompraDes.Size = New System.Drawing.Size(636, 20)
        Me.txtCompraDes.TabIndex = 15
        Me.txtCompraDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtCompraDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.txtCompraOrden)
        Me.grpMain.Controls.Add(Me.dtpFecha)
        Me.grpMain.Controls.Add(Me.cboEstado)
        Me.grpMain.Controls.Add(Me.cboTipoPago)
        Me.grpMain.Controls.Add(Me.cboMoneda)
        Me.grpMain.Controls.Add(Me.txtCompraNro)
        Me.grpMain.Controls.Add(Me.txtTipoCambio)
        Me.grpMain.Controls.Add(Me.txtCompraId)
        Me.grpMain.Controls.Add(Me.Label6)
        Me.grpMain.Controls.Add(Me.Label7)
        Me.grpMain.Controls.Add(Me.Label11)
        Me.grpMain.Controls.Add(Me.Label12)
        Me.grpMain.Controls.Add(Me.Label15)
        Me.grpMain.Controls.Add(Me.Label16)
        Me.grpMain.Controls.Add(Me.Label17)
        Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpMain.Location = New System.Drawing.Point(8, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(736, 64)
        Me.grpMain.TabIndex = 0
        Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(380, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "Nro. Orden"
        '
        'txtCompraOrden
        '
        Me.txtCompraOrden.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCompraOrden.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCompraOrden.Location = New System.Drawing.Point(452, 36)
        Me.txtCompraOrden.MaxLength = 50
        Me.txtCompraOrden.Name = "txtCompraOrden"
        Me.txtCompraOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtCompraOrden.TabIndex = 7
        Me.txtCompraOrden.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtCompraOrden.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpFecha.DropDownCalendar.FirstMonth = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.DropDownCalendar.Name = ""
        Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.dtpFecha.Location = New System.Drawing.Point(248, 12)
        Me.dtpFecha.MaxDate = New Date(2050, 1, 31, 0, 0, 0, 0)
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
        Me.cboEstado.Location = New System.Drawing.Point(60, 36)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboEstado.Size = New System.Drawing.Size(100, 20)
        Me.cboEstado.TabIndex = 5
        Me.cboEstado.TabStop = False
        Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'cboTipoPago
        '
        Me.cboTipoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoPago.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboTipoPago.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboTipoPago.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboTipoPago.Location = New System.Drawing.Point(628, 12)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboTipoPago.Size = New System.Drawing.Size(100, 20)
        Me.cboTipoPago.TabIndex = 4
        Me.cboTipoPago.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'cboMoneda
        '
        Me.cboMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboMoneda.Location = New System.Drawing.Point(452, 12)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
        Me.cboMoneda.TabIndex = 3
        Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'txtCompraNro
        '
        Me.txtCompraNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCompraNro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCompraNro.FormatString = "########"
        Me.txtCompraNro.Location = New System.Drawing.Point(628, 36)
        Me.txtCompraNro.Name = "txtCompraNro"
        Me.txtCompraNro.ReadOnly = True
        Me.txtCompraNro.Size = New System.Drawing.Size(100, 20)
        Me.txtCompraNro.TabIndex = 8
        Me.txtCompraNro.TabStop = False
        Me.txtCompraNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtCompraNro.Value = 0
        Me.txtCompraNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
        Me.txtCompraNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtTipoCambio.FormatString = "##,##0.000"
        Me.txtTipoCambio.Location = New System.Drawing.Point(248, 36)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoCambio.TabIndex = 6
        Me.txtTipoCambio.Text = "0,000"
        Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtCompraId
        '
        Me.txtCompraId.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCompraId.Location = New System.Drawing.Point(60, 12)
        Me.txtCompraId.Name = "txtCompraId"
        Me.txtCompraId.ReadOnly = True
        Me.txtCompraId.Size = New System.Drawing.Size(100, 20)
        Me.txtCompraId.TabIndex = 1
        Me.txtCompraId.TabStop = False
        Me.txtCompraId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtCompraId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "Estado"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 16)
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
        Me.Label11.Location = New System.Drawing.Point(168, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 199
        Me.Label11.Text = "Tipo Cambio"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(572, 40)
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
        Me.Label15.Location = New System.Drawing.Point(396, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 16)
        Me.Label15.TabIndex = 196
        Me.Label15.Text = "Moneda"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(200, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 16)
        Me.Label16.TabIndex = 195
        Me.Label16.Text = "Fecha"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(580, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 16)
        Me.Label17.TabIndex = 194
        Me.Label17.Text = "Forma"
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuNew, Me.mnuEdit, Me.mnuDelete})
        '
        'mnuShow
        '
        Me.mnuShow.Index = 0
        Me.mnuShow.Text = "Consultar"
        '
        'mnuNew
        '
        Me.mnuNew.Index = 1
        Me.mnuNew.Text = "Nuevo"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 2
        Me.mnuEdit.Text = "Editar"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 3
        Me.mnuDelete.Text = "Eliminar"
        '
        'cdmMain
        '
        Me.cdmMain.AllowMerge = False
        Me.cdmMain.AlwaysShowFullMenus = True
        Me.cdmMain.BottomRebar = Me.BottomRebar1
        Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.SaveTemp, Me.Anular, Me.Print, Me.PedCompra})
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
        Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.PedCompra1, Me.Separator2, Me.Anular1, Me.Separator4, Me.Print1, Me.Separator3, Me.Exit1})
        Me.UiCommandBar1.Key = "tbrMain"
        Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.UiCommandBar1.Name = "UiCommandBar1"
        Me.UiCommandBar1.RowIndex = 0
        Me.UiCommandBar1.Size = New System.Drawing.Size(433, 28)
        Me.UiCommandBar1.Text = "tbrMain"
        '
        'Save1
        '
        Me.Save1.Key = "Save"
        Me.Save1.Name = "Save1"
        Me.Save1.Text = "Siguiente"
        '
        'Separator1
        '
        Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator1.Key = "Separator"
        Me.Separator1.Name = "Separator1"
        '
        'PedCompra1
        '
        Me.PedCompra1.Key = "PedCompra"
        Me.PedCompra1.Name = "PedCompra1"
        Me.PedCompra1.Text = "Pedido de Compra"
        Me.PedCompra1.ToolTipText = "Cargar Desde un Pedido de Compra"
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
        Me.Save.ImageIndex = 8
        Me.Save.Key = "Save"
        Me.Save.Name = "Save"
        Me.Save.Text = "Guardar"
        '
        'Exit2
        '
        Me.Exit2.ImageIndex = 5
        Me.Exit2.Key = "Exit"
        Me.Exit2.Name = "Exit2"
        Me.Exit2.Text = "Salir"
        '
        'SaveTemp
        '
        Me.SaveTemp.ImageIndex = 0
        Me.SaveTemp.Key = "SaveTemp"
        Me.SaveTemp.Name = "SaveTemp"
        Me.SaveTemp.Text = "Guardar Pendiente"
        '
        'Anular
        '
        Me.Anular.ImageIndex = 2
        Me.Anular.Key = "Anular"
        Me.Anular.Name = "Anular"
        Me.Anular.Text = "Anular"
        '
        'Print
        '
        Me.Print.ImageIndex = 4
        Me.Print.Key = "Print"
        Me.Print.Name = "Print"
        Me.Print.Text = "Imprimir"
        '
        'PedCompra
        '
        Me.PedCompra.ImageIndex = 3
        Me.PedCompra.Key = "PedCompra"
        Me.PedCompra.Name = "PedCompra"
        Me.PedCompra.Text = "Desde un Pedido de Compra"
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
        Me.ilsMain.Images.SetKeyName(8, "")
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
        'frmCompraEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(752, 482)
        Me.Controls.Add(Me.bcgMain)
        Me.Controls.Add(Me.TopRebar1)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frmCompraEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota de Compra"
        Me.ExplorerBarContainerControl4.ResumeLayout(False)
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bcgMain.ResumeLayout(False)
        CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSucursal.ResumeLayout(False)
        CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ebrMain.ResumeLayout(False)
        CType(Me.grbDesRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDesRec.ResumeLayout(False)
        Me.grbDesRec.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grpDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
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
         Case "Save"
            If DataSave() Then
               mlngID = moCompra.CompraId
               mboolChanged = True
               mboolAdding = False
               mboolEditing = True
               chkConFac.Enabled = False

               cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True
               Me.Close()
            End If

         Case "PedCompra"
            Call frmPedCompraLoad()

         Case "Anular"
            Call CompraAnular()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompraEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompraEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call ViewComponent()
      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ComboLoad()

      If Not mboolAdding Then
         Call FormShow()

         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta Nota de Compra"

         ElseIf OperaFechaHabil(ToDate(dtpFecha.Value)) Then
            Call HeaderReadOnly()
            Me.Text = "Editar Nota de Compra"

         Else
            MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mboolEditing = False
            Call DataReadOnly()
            Me.Text = "Consulta Nota de Compra"
         End If

      Else
         Me.Text = "Nueva Nota de Compra"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

#Region " Compra "

   Private Sub FormShow()
      mboolShow = True
      With moCompra
         txtCompraId.Text = ToStr(.CompraId)
         dtpFecha.Text = ToStr(.Fecha)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         cboTipoPago.SelectedIndex = ListFindItem(cboTipoPago, .TipoPagoId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         txtCompraNro.Text = ToStr(.CompraNro)
         cboProveedor.Value = ListFindItem(cboProveedor, .ProveedorId)
         cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, .AlmacenId)
         txtCompraOrden.Text = ToStr(.CompraOrden)
         txtCompraDes.Text = ToStr(.CompraDes)
         txtCompraObs.Text = ToStr(.CompraObs)

         chkConFac.Checked = .ConFac
         chkSinFac.Checked = .SinFac

         cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

         If Not clsAppInfo.MultipleNro Then
            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

         Call cargarLstPedidos(.CompraId)

         cboMoneda.ReadOnly = True
         cboEstado.ReadOnly = True
         PedCompra.Enabled = Janus.Windows.UI.InheritableBoolean.False

         If clsAppInfo.CentroCostoApli Then  ''Si tiene facturas Diferidas no permitir modificar
            cboCentroCosto.ReadOnly = False
         End If

      End With

      Call grdMainLoad()

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCompra
         txtCompraId.Text = String.Empty
         dtpFecha.Text = ToStr(.Fecha)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
         cboTipoPago.SelectedIndex = -1
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         txtTipoCambio.Text = "0"
         cboProveedor.Value = Nothing
         cboAlmacen.SelectedIndex = -1
         txtCompraNro.Text = "0"
         txtCompraOrden.Text = String.Empty
         txtCompraDes.Text = String.Empty
         txtCompraObs.Text = String.Empty
         cboCentroCosto.SelectedIndex = -1
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

         Call txtTipoCambioLoad(ToDate(dtpFecha.Value))

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
            txtCompraOrden.Text = GetCodNroOrden()
         End If

         cboSucursal.ReadOnly = True
         If clsAppInfo.SucursalApli Then
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)
         Else
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, clsAppInfo.SucursalId)
         End If

         cboEstado.ReadOnly = True
      End With
      mboolShow = False
   End Sub

   Private Sub ViewComponent()
      If clsAppInfo.CentroCostoApli Then
         lblCentroCosto.Visible = True
         cboCentroCosto.Visible = True

      Else
         lblCentroCosto.Visible = False
         cboCentroCosto.Visible = False

         'grpDatos.Size = New System.Drawing.Size(736, 64)
         'Label1.Location = New System.Drawing.Point(8, 40)
         'txtCompraDes.Location = New System.Drawing.Point(92, 36)

         'ebrMain.Location = New System.Drawing.Point(8, 132)
         'ebrMain.Size = New System.Drawing.Size(736, 211)
      End If

      If clsAppInfo.SucursalApli Then
         lblSucursal.Visible = True
         cboSucursal.Visible = True
      Else
         lblSucursal.Visible = False
         cboSucursal.Visible = False
      End If

   End Sub

   Private Sub DataReadOnly()
      txtCompraId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboTipoPago.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      cboProveedor.ReadOnly = True
      cboAlmacen.ReadOnly = True
      txtCompraNro.ReadOnly = True
      txtCompraOrden.ReadOnly = True
      txtCompraDes.ReadOnly = True
      txtCompraObs.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False
      txtMontoRec.ReadOnly = True
      txtMontoDes.ReadOnly = True
      txtPorcentajeRec.ReadOnly = True
      txtPorcentajeDes.ReadOnly = True
      cboCentroCosto.ReadOnly = True


      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("PedCompra").Enabled = Janus.Windows.UI.InheritableBoolean.False

   End Sub

   Private Sub HeaderReadOnly()
      txtCompraId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboTipoPago.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      cboProveedor.ReadOnly = True
      cboAlmacen.ReadOnly = True
      txtCompraNro.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False
      cboCentroCosto.ReadOnly = True

      cdmMain.Commands.Item("PedCompra").Enabled = Janus.Windows.UI.InheritableBoolean.False

   End Sub

   Private Sub DataMove()
      With moCompra
         If Not mboolAdding Then
            .CompraId = ToLong(txtCompraId.Text)
         Else
            .PorIVA = clsAppInfo.IVA
         End If

         .Fecha = ToDate(dtpFecha.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .TipoPagoId = ListPosition(cboTipoPago, cboTipoPago.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .ProveedorId = ListPosition(cboProveedor)
         .AlmacenId = ListPosition(cboAlmacen, cboAlmacen.SelectedIndex)
         .CompraNro = ToLong(txtCompraNro.Text)
         .CompraOrden = ToStr(txtCompraOrden.Text)
         .CompraDes = ToStr(txtCompraDes.Text)
         .CompraObs = ToStr(txtCompraObs.Text)
         .ConFac = ToBoolean(chkConFac.Checked)
         .SinFac = ToBoolean(chkSinFac.Checked)
         .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)

         .MontoOrg = mdecMontoOrg
         .MontoRec = mdecMontoRec
         .MontoDes = mdecMontoDes
         .MontoBru = mdecMontoOrg + mdecMontoRec - mdecMontoDes

         .MontoLiq = .MontoBru - .MontoAnt
         .MontoCos = .MontoBru

         If mboolAdding Or mboolEditing Then
            .MontoPorFac = mdecMontoOrg + mdecMontoRec
         End If

      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()
      Call grdMainClear()

      If mboolDuplicate Then
         If CompraDuplicateLoad(mlngCompraIdDuplicate) Then
            If grdMain.RowCount > 0 Then 'Para deshabilitar la moneda
               'cboMoneda.ReadOnly = True
               'cboAlmacen.ReadOnly = True
               'cboCliente.ReadOnly = True
               'cboVendedor.ReadOnly = True
               'cboCentroCosto.ReadOnly = IIf(cboCentroCosto.SelectedIndex = -1, False, True)
               Call DataMove()

               Dim txtNroOrden As String = ToStr(txtCompraOrden.Text)
               If clsAppInfo.CentroCostoApli Then
                  txtCompraOrden.Text = txtNroOrden
                  If (txtCompraOrden.Text.Trim = String.Empty) Then
                     txtCompraOrden.Text = GetCodNroOrden()
                  End If
               End If

            End If
         End If
      End If

      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.False

      dtpFecha.Select()
   End Sub

   Private Function PedCompraUpdate(ByVal lngPedCompraId As Long, ByVal lngCompraId As Long) As Boolean

      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim decCantidad, decCantidadEnt As Decimal

      PedCompraUpdate = False

      Try
         If lngPedCompraId > 0 Then
            With oPedCompra

               .PedCompraId = lngPedCompraId
               .CompraId = lngCompraId

               If .FindByPK Then

                  With oPedCompraDet

                     .SelectFilter = clsPedCompraDet.SelectFilters.All
                     .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraId
                     .EmpresaId = moCompra.EmpresaId
                     .PedCompraId = lngPedCompraId

                     If .Find Then
                        decCantidad = 0
                        decCantidadEnt = 0

                        While .Read

                           .EstadoId = clsEstado.PENDIENTE  'Pendiente

                           If .Cantidad = .CantidadEnt Then
                              .EstadoId = clsEstado.REALIZADO  'Realizado                        
                           ElseIf .CantidadEnt > 0 Then
                              .EstadoId = clsEstado.PARCIAL 'Parcial                        
                           End If

                           decCantidad += .Cantidad
                           decCantidadEnt += .CantidadEnt

                           .UpdateFilter = clsPedCompraDet.UpdateFilters.EstadoIdPK
                           If .Update Then
                              PedCompraUpdate = True
                           End If

                           .MoveNext()

                        End While
                     End If
                  End With

                  '.EstadoId = IIf(decCantidadEnt = 0, clsEstado.PENDIENTE, IIf(decCantidad = decCantidadEnt, clsEstado.REALIZADO, clsEstado.PARCIAL))
                  .EstadoId = IIf(decCantidadEnt = 0, clsEstado.APROBADO, IIf(decCantidad = decCantidadEnt, clsEstado.REALIZADO, clsEstado.PARCIAL))

                  .Fecha = ToDate(.Fecha)
                  .FechaEnt = ToDate(.FechaEnt)

                  If .Update Then
                     PedCompraUpdate = True
                  End If

               End If

               ''.CloseConection()
            End With

         Else
            PedCompraUpdate = True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()
         oPedCompraDet.Dispose()

      End Try

   End Function

   Private Function DataSave() As Boolean
      Dim lngTipoNotaId As Long
      Dim lngNotaId As Long
      Dim lngNotaNro As Long
      Dim lngCompId As Long
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim boolInv As Boolean
      Dim ProveedorMovId As Long
      Dim lngNotaIdAux As Long
      Dim lngCreditoId As Long

      Try
         Call DataMove()

         If moCompra.Validate Then
            If mboolAdding Then
               Call CheckRemoveItemPrecioCero()
               If FormCheck() Then
                  If ItemSaldoCheck() Then
                     If ItemLoteCheckEliminados() Then
                        If ItemSaldoLoteCheck() Then

                           Call ValidarOtherProcess()

                           If clsAppInfo.Inventario Then 'Adicion Integrado a Contabilidad
                              If DataAdd() Then
                                 If frmCompraNextNew() Then

                                    txtCompraId.Text = ToStr(moCompra.CompraId)
                                    txtCompraNro.Text = ToStr(moCompra.CompraNro)
                                    cboEstado.SelectedIndex = ListFindItem(cboEstado, moCompra.EstadoId)

                                    If moCompra.MontoLiq = 0 Then
                                       moCompra.EstadoId = clsEstado.REALIZADO 'Realizado
                                    Else
                                       Call CreditoNew(lngCreditoId, lngTipoCompId, lngCompNro)
                                       moCompra.CreditoId = lngCreditoId
                                       Call ContadoPagoNew()
                                    End If

                                    If frmCompPlanFill() Then
                                       Call HeaderReadOnly()

                                       If NotaAdd(lngNotaId, lngTipoNotaId, lngNotaNro) Then 'Cabecera de la Nota
                                          'moCompra.TipoNotaId = lngTipoNotaId
                                          'moCompra.NotaNro = lngNotaNro
                                          moCompra.NotaId = lngNotaId

                                          If grdMainSave(lngNotaId) Then
                                             If CompNewPoliza() Then

                                                If CompNew(lngCompId, lngTipoCompId, lngCompNro) Then
                                                   moCompra.CompId = lngCompId
                                                   moCompra.PlanId = mlngPlanId 'Cuenta Variable

                                                   If DataUpdate() Then
                                                      If NotaUpdate(lngNotaId) Then
                                                         Call grdMainEstadoShow()
                                                         DataSave = True
                                                      End If
                                                   End If

                                                End If

                                             End If

                                             If (mlstPedidos.Count > 0) Then
                                                Call pedCompraUpdateList()
                                                Call pedidoCompraSelectAdd(moCompra.CompraId, moCompra.EstadoId)
                                             End If

                                             If DataSave Then
                                                Call grdMain_UpdateItemPrecio()
                                             End If

                                          End If
                                       End If
                                    End If
                                 End If
                              End If

                           Else 'Adicion Sin Integracion a Contabilidad
                              If DataAdd() Then
                                 If frmCompraNextNew() Then
                                    Call HeaderReadOnly()

                                    If moCompra.MontoLiq <= 0 Then
                                       moCompra.EstadoId = clsEstado.REALIZADO  'Realizado
                                    Else
                                       Call CreditoNew(lngCreditoId, lngTipoCompId, lngCompNro)
                                       moCompra.CreditoId = lngCreditoId
                                       Call ContadoPagoNew()
                                    End If

                                    txtCompraId.Text = ToStr(moCompra.CompraId)
                                    txtCompraNro.Text = ToStr(moCompra.CompraNro)
                                    cboEstado.SelectedIndex = ListFindItem(cboEstado, moCompra.EstadoId)

                                    If NotaAdd(lngNotaId, lngTipoNotaId, lngNotaNro) Then 'Cabecera de la Nota
                                       moCompra.NotaId = lngNotaId

                                       If grdMainSave(lngNotaId) Then

                                          If DataUpdate() Then
                                             If NotaUpdate(lngNotaId) Then
                                                Call grdMainEstadoShow()
                                                DataSave = True
                                             End If
                                          End If

                                          If (mlstPedidos.Count > 0) Then
                                             Call pedCompraUpdateList()
                                             Call pedidoCompraSelectAdd(moCompra.CompraId, moCompra.EstadoId)
                                          End If

                                          If DataSave Then
                                             Call grdMain_UpdateItemPrecio()
                                          End If

                                       End If
                                    End If
                                 End If
                              End If
                           End If
                        End If
                     End If
                  End If
               End If
            ElseIf mboolEditing Then 'Editar
               If FormCheck() Then
                  If ItemSaldoCheck() Then
                     If ItemLoteCheckEliminados() Then
                        If ItemSaldoLoteCheck() Then
                           Call ValidarOtherProcess()

                           Dim lngCompPolizaId As Long
                           If clsAppInfo.Inventario Then 'Adicion Integrado a Contabilidad
                              Call PolizaIvaFind(moCompra.PolizaId, 0, 0, 0, 0, 0, 0, 0, lngCompPolizaId)

                              If frmCompraNextEdit() Then

                                 moCompra.EstadoId = IIf(moCompra.MontoLiq = 0, clsEstado.REALIZADO, clsEstado.PENDIENTE)
                                 cboEstado.SelectedIndex = ListFindItem(cboEstado, moCompra.EstadoId)

                                 If frmCompPlanFill() Then
                                    'lngNotaId = NotaIdFind(moCompra.TipoNotaId, moCompra.NotaNro, moCompra.SucursalId)
                                    If isNotaFind(moCompra.NotaId, lngTipoNotaId, lngNotaNro) Then
                                       lngNotaId = moCompra.NotaId
                                    End If

                                    If NotaUpdateAdd(lngTipoNotaId, lngNotaNro, lngNotaId, lngNotaIdAux) Then
                                       'moCompra.NotaId = lngNotaId
                                       moCompra.NotaId = lngNotaIdAux

                                       If grdMainSave(lngNotaId) Then
                                          If lngCompPolizaId > 0 Then
                                             Call CompEditPoliza(lngCompPolizaId)
                                          Else
                                             Call CompNewPoliza()
                                          End If

                                          'If CompEdit() Then
                                          If CompEdit(moCompra.CompId, lngTipoCompId, lngCompNro) Then

                                             If moCompra.MontoLiq > 0 Then
                                                Call CreditoEdit(moCompra.CreditoId, lngTipoCompId, lngCompNro)
                                                Call ContadoPagoNew()
                                             Else
                                                moCompra.EstadoId = clsEstado.REALIZADO
                                             End If

                                             If DataUpdate() Then

                                                If lngNotaIdAux = lngNotaId And lngNotaIdAux <> 0 Then
                                                   If NotaUpdate(lngNotaId) Then
                                                      Call grdMainEstadoShow()
                                                      DataSave = True
                                                   End If
                                                Else
                                                   Call grdMainEstadoShow()
                                                   DataSave = True
                                                End If

                                             End If
                                          End If

                                          If (mlstPedidos.Count > 0) Then
                                             Call pedCompraUpdateList()
                                             Call pedidoCompraSelectUpdate(moCompra.CompraId, moCompra.EstadoId)
                                          End If

                                          If DataSave Then
                                             Call grdMain_UpdateItemPrecio()
                                          End If

                                       End If
                                    End If
                                 End If
                              End If

                           Else 'Adicion Sin Integracion a Contabilidad

                              If frmCompraNextEdit() Then
                                 'lngNotaId = NotaIdFind(moCompra.TipoNotaId, moCompra.NotaNro, moCompra.SucursalId)
                                 If isNotaFind(moCompra.NotaId, lngTipoNotaId, lngNotaNro) Then
                                    lngNotaId = moCompra.NotaId
                                 End If

                                 'If NotaUpdateAdd(moCompra.TipoNotaId, moCompra.NotaNro, lngNotaId, lngNotaIdAux) Then
                                 If NotaUpdateAdd(lngTipoNotaId, lngNotaNro, lngNotaId, lngNotaIdAux) Then
                                    moCompra.NotaId = lngNotaIdAux
                                    moCompra.EstadoId = IIf(moCompra.MontoLiq = 0, clsEstado.REALIZADO, clsEstado.PENDIENTE)
                                    cboEstado.SelectedIndex = ListFindItem(cboEstado, moCompra.EstadoId)

                                    If grdMainSave(lngNotaId) Then

                                       If moCompra.MontoLiq > 0 Then
                                          Call CreditoEdit(moCompra.CreditoId, lngTipoCompId, lngCompNro)

                                          Call ContadoPagoNew()
                                       Else
                                          moCompra.EstadoId = clsEstado.REALIZADO
                                       End If

                                       If DataUpdate() Then

                                          If lngNotaIdAux = lngNotaId And lngNotaIdAux <> 0 Then
                                             If NotaUpdate(lngNotaId) Then
                                                Call grdMainEstadoShow()
                                                DataSave = True
                                             End If
                                          Else
                                             Call grdMainEstadoShow()
                                             DataSave = True
                                          End If

                                       End If

                                       If (mlstPedidos.Count > 0) Then
                                          Call pedCompraUpdateList()
                                          Call pedidoCompraSelectUpdate(moCompra.CompraId, moCompra.EstadoId)
                                       End If

                                       If DataSave Then
                                          Call grdMain_UpdateItemPrecio()
                                       End If

                                    End If
                                 End If
                              End If
                           End If
                        End If
                     End If
                  End If
               End If

            Else 'Show
               Call frmCompraNextShow()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moCompra.CompraId = 0 Then 'Pa que no inserte dos veces
            If moCompra.Insert() Then
               DataAdd = True
            End If
         Else
            If moCompra.Update() Then
               DataAdd = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moCompra.Update() Then
            'Call PedCompraUpdate(moCompra.PedCompraId, moCompra.CompraId, getPedidoEstadoId(moCompra.PedCompraId))  'Pedido de Compra a Estado Realizado
            Call PedCompraUpdate(moCompra.PedCompraId, moCompra.CompraId)
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function ProveedorMovAdd(ByRef lngProveedorMovId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
               ByVal lngTipoPagoId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, _
               ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .ProveedorId = moCompra.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = ToDate(dtpFecha.Value)
            .ProveedorMovDes = "Compra Nro. " + txtCompraNro.Text + "; " + txtCompraDes.Text
            .MonedaId = moCompra.MonedaId
            .TipoCambio = moCompra.TipoCambio
            .CentroCostoId = moCompra.CentroCostoId
            .SucursalId = moCompra.SucursalId
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

               ElseIf lngCol = 3 Then
                  .DebeBs = decValor
                  .DebeUs = ToDecimal(decValor / .TipoCambio)

                  .HaberBs = .DebeBs
                  .HaberUs = .DebeUs
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

               ElseIf lngCol = 3 Then
                  .DebeBs = ToDecimal(decValor * .TipoCambio)
                  .DebeUs = decValor

                  .HaberBs = .DebeBs
                  .HaberUs = .DebeUs
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
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .EstadoId = 11 'Abierto

            If .Find Then
               .Fecha = ToDate(.Fecha)
               ''.ProveedorMovDes = ""

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

                  ElseIf lngCol = 3 Then
                     .DebeBs = decValor
                     .DebeUs = ToDecimal(decValor / .TipoCambio)

                     .HaberBs = .DebeBs
                     .HaberUs = .DebeUs
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

                  ElseIf lngCol = 3 Then
                     .DebeBs = ToDecimal(decValor * .TipoCambio)
                     .DebeUs = decValor

                     .HaberBs = .DebeBs
                     .HaberUs = .DebeUs
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

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraNroNext = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moCompra.EmpresaId
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

   Public Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

        If cboSucursal.SelectedIndex = -1 Then
            FormCheck = False
            Throw New Exception("Revise La Sucursal")
        Else
            If CompSucursalApeExist(moCompra.EmpresaId, moCompra.GestionId, moCompra.SucursalId) Then
                If Not NotaSucursalApeExist(moCompra.EmpresaId, moCompra.GestionId, moCompra.SucursalId) Then
                    FormCheck = False
                    Throw New Exception("No hay Apertura de Parámetros de Notas en 'Inventario' para esta Sucursal")
                End If
            Else
                FormCheck = False
                Throw New Exception("No hay Apertura de Parámetros de Comprobantes en 'Contabilidad' para esta Sucursal")
            End If
        End If

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         FormCheck = False
         Throw New Exception("Fecha no Corresponde a la Gestion en Uso")

      ElseIf Not OperaFechaHabil(ToDate(dtpFecha.Value)) Then
         FormCheck = False
         Throw New Exception("Fecha de Operación Inhábil para el Usuario")
      End If

      ''If dtpFecha.Value > Now Then
      ''   FormCheck = False
      ''   Throw New Exception("Fecha no Valida, No puede ser mayor a la Actual")
      ''End If

      If moDataSet.Tables(moCompraDet.TableName).Rows.Count <= 0 Then
         FormCheck = False
         Throw New Exception("Nota de Compra Sin Detalle")
      End If

      If (Not chkConFac.Checked) And (Not chkSinFac.Checked) Then
         FormCheck = False
         Throw New Exception("Valores Inválidos en (I o F)")
      End If

      For Each oRow As DataRow In moDataSet.Tables(moCompraDet.TableName).Rows
         'Controla que el la venta no se guarde con importe bruto cero
         If Not ToDecimal(oRow("ImporteBru")) > 0 Then
            FormCheck = False
            Throw New Exception("Existen Item(s) con Importe Bruto igual a cero")
         End If
      Next

       
      ''If moCompra.CompraOrden <> "" Then
      ''   If DuplicateCompraOrden(moCompra.CompraId, moCompra.CompraOrden) Then
      ''      strMsg &= "Numero de Orden Duplicado" & vbCrLf
      ''   End If
      ''End If

      mboolCreditoAuto = CreditoAutoFind(moCompra.ProveedorId)

      ''If (moVenta.TipoPagoId = clsTipoPago.CREDITO) Then
      ''   If mdecCreditoLimite > 0 Then
      ''      If moVenta.MontoOrg > ToDecimal(txtClienteSaldo.Text) Then
      ''         strMsg &= "El Monto de la Venta Excede al Saldo de Credito" & vbCrLf
      ''      End If
      ''   End If
      ''End If

      If clsAppInfo.CentroCostoApli Then
         If cboCentroCosto.SelectedIndex = -1 Then
            FormCheck = False
            Throw New Exception("Revise El Centro de Costo")
         End If

         For Each oRow As DataRow In moDataSet.Tables(moCompraDet.TableName).Rows
            If CentroCostoDetFind(ToLong(oRow("CentroCostoIdAct"))) And ToLong(oRow("CentroCostoDetIdAct")) = 0 Then
               FormCheck = False
               Throw New Exception("Existen C.C. con Actividades sin Seleccionar")
            End If
         Next
         If mboolAdding Then
            Dim strTexto As String = (txtCompraOrden.Text).Trim

            If txtCompraOrden.Text.Trim <> String.Empty Then
               If strTexto.Chars(strTexto.Length - 1) = "-" Then
                  Throw New Exception("Nro de Orden Incompleto")
               End If

            Else
               Throw New Exception("Nro de Orden Incompleto")
            End If
         End If

      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function DuplicateCompraOrden(ByVal lngCompraId As Long, ByVal strCompraOrden As String) As Boolean
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      DuplicateCompraOrden = False

      Try
         With oCompra
            .SelectFilter = clsCompra.SelectFilters.All
            .WhereFilter = clsCompra.WhereFilters.CompraOrden
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraOrden = strCompraOrden
            .CompraId = lngCompraId

            If .Find Then
               DuplicateCompraOrden = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   'Public Function ItemSaldoCheck() As Boolean
   '   Dim strMsg As String = String.Empty
   '   Dim strMsg2 As String = String.Empty
   '   Dim decCantidadItem As Decimal
   '   Dim oRow As DataRow

   '   For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
   '      Call ItemParametro(oRow("ItemId"))

   '      If mlngTipoItemId = 1 Then 'Inventario

   '         If mlngMedidaId = ToLong(oRow("MedidaId")) Then
   '            decCantidadItem = ToDecimal(oRow("Cantidad"))
   '         Else
   '            decCantidadItem = ToDouble(ToDecimal(oRow("Cantidad")) * mdecMedidaCantEqui)
   '         End If

   '         If mboolControlLote Then
   '            strMsg2 = ItemLoteCheck(oRow("ItemId"), ToLong(oRow("MedidaId")), decCantidadItem)

   '            If strMsg2 <> String.Empty Then
   '               strMsg &= ToStr(oRow("ItemDes")) & ", " & strMsg2 & vbCrLf
   '            End If
   '         End If

   '         If mboolControlSerie Then
   '            strMsg2 = ItemSerieCheck(oRow("ItemId"), decCantidadItem)

   '            If strMsg2 <> String.Empty Then
   '               strMsg &= ToStr(oRow("ItemDes")) & ", " & strMsg2 & vbCrLf
   '            End If
   '         End If

   '      End If

   '   Next

   '   If strMsg.Trim <> String.Empty Then
   '      Throw New Exception(strMsg)
   '      ItemSaldoCheck = False
   '   Else
   '      ItemSaldoCheck = True
   '   End If

   'End Function

   Public Function ItemSaldoCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim strMsg2 As String = String.Empty
      Dim decCantidadItem As Decimal
      Dim decCantidadMin, decSaldoActual As Decimal
      Dim oRow As DataRow

      For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
         Call ItemParametro(oRow("ItemId"))

         If mlngTipoItemId = 1 Then 'Inventario
            Call ItemSaldoParametro(oRow("ItemId"), moCompra.AlmacenId)

            If mlngMedidaId = ToLong(oRow("MedidaId")) Then
               decCantidadItem = ToDecimal(oRow("Cantidad"))
               decCantidadMin = ToDecimal(oRow("Cantidad") - oRow("CantidadAnt"))
               decSaldoActual = mdecSaldoItem
            Else
               decCantidadItem = ToDouble(ToDecimal(oRow("Cantidad")) * mdecMedidaCantEqui)
               decCantidadMin = ToDouble(ToDecimal(oRow("Cantidad") - oRow("CantidadAnt")) * mdecMedidaCantEqui)
               decSaldoActual = ToDecimal(mdecSaldoItem / mdecMedidaCantEqui)
            End If

            'If mdecSaldoItem + decCantidadMin < 0 Then
            '   strMsg &= ToStr(oRow("ItemDes")) + ", El Saldo es Inferior a la Compra, Cantidad en Stock : " + ToStr(decSaldoActual + ToDecimal(oRow("Cantidad") - oRow("CantidadAnt")) & " " & ToStr(oRow("MedidaDes"))) & vbCrLf
            'End If

            'If mdecSaldoItem < decCantidadItem Then
            If mdecSaldoItem + decCantidadMin < 0 Then
               strMsg &= "Saldo de Item: " & ToStr(oRow("ItemDes")) & " es Inferior al de la Compra, Cantidad en Stock: " + ToStr(decSaldoActual) & " " & ToStr(oRow("MedidaDes")) & vbCrLf
            End If

            If mboolControlLote Then
               strMsg2 = ItemLoteCheck(oRow("ItemId"), ToLong(oRow("MedidaId")), decCantidadItem)

               If strMsg2 <> String.Empty Then
                  strMsg &= ToStr(oRow("ItemDes")) & ", " & strMsg2 & vbCrLf
               End If
            End If

            If mboolControlSerie Then
               strMsg2 = ItemSerieCheck(oRow("ItemId"), decCantidadItem)

               If strMsg2 <> String.Empty Then
                  strMsg &= ToStr(oRow("ItemDes")) & ", " & strMsg2 & vbCrLf
               End If
            End If

         End If

      Next

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         ItemSaldoCheck = False
      Else
         ItemSaldoCheck = True
      End If

   End Function

   Private Function ItemLoteCheck(ByVal lngItemId As Long, ByVal lngMedidaIdNota As Long, ByVal decCantidadItem As Decimal) As String
      Dim strMsg As String = String.Empty
      Dim oRow As DataRow
      Dim decCantidadLote As Decimal = 0

      For Each oRow In moDataSetDet.Tables(clsItemLote.TABLE_NAME).Rows
         If oRow("ItemId") = lngItemId Then
            If lngMedidaIdNota = mlngMedidaId Then
               decCantidadLote += oRow("SaldoOrg")

            ElseIf lngMedidaIdNota = mlngMedidaIdEqui Then
               decCantidadLote += oRow("SaldoOrg") * mdecMedidaCantEqui
            End If
         End If
      Next

      If decCantidadLote = decCantidadItem Then
         Return strMsg
      Else
         Return "Cantidad del Item con los Lotes No Coinciden" & vbCrLf
      End If
   End Function

   Private Function ItemSerieCheck(ByVal lngItemId As Long, ByVal decCantidadItem As Decimal) As String
      Dim strMsg As String = String.Empty
      Dim strMsgDup As String = String.Empty
      Dim strMsgDel As String = String.Empty
      Dim strMsgVacio As String = String.Empty
      Dim oRow As DataRow
      Dim decCantidadSerie As Decimal = 0
      Dim lngItemNroSerieId As Long = 0

      For Each oRow In moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME).Rows
         If (oRow("ItemId") = lngItemId) Then
            lngItemNroSerieId = oRow("ItemNroSerieId")

            If ToStr(oRow("ItemNroSerieCod")) <> String.Empty Then
               ''decItemLoteSaldo = serieFind(lngItemId, ToStr(oRow("ItemNroSerieCod")))
               ''If lngItemNroSerieId > 0 Then
               ''   ''strMsgDup &= ToStr(oRow("ItemNroSerieCod")) & ", "
               ''   ''decCantidadSerie += 1
               ''Else
               ''   strMsgDel &= ToStr(oRow("ItemNroSerieCod")) & ", "
               ''End If
               decCantidadSerie += 1
            Else
               strMsgVacio = "Algunos Codigos de Series son invalidos" & vbCrLf
               decCantidadSerie += 1
            End If

         End If
      Next

      If strMsgDup <> String.Empty Then
         strMsg &= "  Existen Series Duplicado: " & strMsgDup & vbCrLf
      End If

      If strMsgDel <> String.Empty Then
         strMsg &= "  Las serie ha sido Eliminado: " & strMsgDel & vbCrLf
      End If

      strMsg &= strMsgVacio

      If decCantidadSerie = decCantidadItem Then
         Return strMsg
      Else
         Return "Cantidad del Item con las Series No Coinciden" & vbCrLf
      End If
   End Function

   Private Sub CheckRemoveItemPrecioCero()
      If mboolAdding Then
         If mboolEditarProvPed And (mlstPedidos.Count > 0) Then
            Dim lngCant As Long = 0
            Dim decImporteOld, decMontoDesOld, decMontoRecOld As Decimal
            For Each oRow As DataRow In moDataSet.Tables(moCompraDet.TableName).Rows
               If (Not ToDecimal(oRow("ImporteBru")) > 0) Then
                  lngCant += 1
               End If
            Next

            If lngCant > 0 Then
               If MessageBox.Show("Existen Item(s) con Precio/Importe Bruto igual a cero " & vbCrLf & "¿Quiere quitar los mismos del detalle, Antes de Guardar la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                  Dim index As Integer = 0
                  Do While index < moDataTable.Rows.Count
                     Dim oRow As DataRow = moDataTable.Rows(index)
                     If (ToStr(oRow("Estado")) = "New") And Not (ToDecimal(oRow("ImporteBru")) > 0) Then

                        decImporteOld = ToDouble(oRow("Importe"))
                        decMontoDesOld = ToDouble(oRow("PrecioDes") * oRow("Cantidad"))
                        decMontoRecOld = ToDouble(oRow("PrecioRec") * oRow("Cantidad"))

                        Call itemRowRemove(clsItemLote.TABLE_NAME, ToLong(oRow("ItemId")))
                        Call itemRowRemove(clsItemNroSerie.TABLE_NAME, ToLong(oRow("ItemId")))

                        moDataTable.Rows.RemoveAt(index)

                        mlngItemCant -= 1
                        mdecMontoOrg = mdecMontoOrg - decImporteOld
                        mdecMontoDes = mdecMontoDes - decMontoDesOld
                        mdecMontoRec = mdecMontoRec - decMontoRecOld
                     Else
                        index += 1
                     End If
                  Loop

                  grdMain.RetrieveStructure()
                  Call grdMainInit()

                  Call ItemTotal()
                  Call ItemTotalPorcentajes()

                  Call DataMove()
               End If
            End If
         End If
      End If

   End Sub

   Private Sub ValidarOtherProcess()
      If mboolAdding Or mboolEditing Then

         ''Update Precios de Venta
         mboolActualizarPreciosVenta = False
         If mboolUpdatePrecioVen Then
            If ExistePrecioVenta(moCompra.AlmacenId, moDataSet.Tables(moCompraDet.TableName)) Then
               mboolActualizarPreciosVenta = True
               moItemSaldo = ItemSaldoFind(moCompra.AlmacenId)
               'Call ItemSaldoLoad(moCompra.AlmacenId)
            End If
         End If
      End If

   End Sub

   Private Function CreditoAutoFind(ByVal lngProveedorId As Long) As Boolean
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      CreditoAutoFind = False

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               CreditoAutoFind = ToBoolean(.CreditoAuto)
               mlngCreditoDias = .CreditoDias
               mdecInteresAnual = .InteresAnual
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function frmCompraNextShow() As Boolean
      Dim frm As New frmCompraNext

      frmCompraNextShow = True

      Try
         With frm
            .NewRecord = False
            .Editing = False

            moCompra.Fecha = ToDate(dtpFecha.Value)

            .DataObject = moCompra
            .CompraDet = moDataSet
            .Fecha = dtpFecha.Value
            ''.FacturaDif = chkFacturaDif.Checked

            .ShowDialog()
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Function

   Private Function frmCompraNextNew() As Boolean
      Dim frm As New frmCompraNext
      Dim oCompraOld As New clsCompra(clsAppInfo.ConnectString)

      frmCompraNextNew = False

      Try
         With frm
            .NewRecord = True
            .Editing = False

            .DataObject = moCompra
            .lstPedCompra = mlstPedCompra
            .CompraDet = moDataSet
            .Fecha = dtpFecha.Value
            .ConFac = chkConFac.Checked
            ''.FacturaDif = chkFacturaDif.Checked

            oCompraOld.CompraId = moCompra.CompraId
            oCompraOld.FindByPK()

            .CompraEdit = Me
            .ShowDialog()

            If .Changed Then

               If moCompra.FindByPK Then
                  moCompra.Fecha = ToDate(dtpFecha.Value)
                  frmCompraNextNew = True

                  If moCompra.FacturaId <> 0 Then
                     If BoolFacturaDet() Then
                        Call FacturaDetAdd(moCompra.FacturaId)
                     End If
                  End If

               End If
            Else

               mlngID = frm.ID
               Call CompraOldLoad(oCompraOld)

            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraOld.Dispose()
      End Try
   End Function

   Private Function frmCompraNextEdit() As Boolean
      Dim frm As New frmCompraNext
      Dim oCompraOld As New clsCompra(clsAppInfo.ConnectString)

      frmCompraNextEdit = False

      Try
         With frm
            .NewRecord = False
            .Editing = True

            moCompra.Fecha = ToDate(dtpFecha.Value)

            .DataObject = moCompra
            .CompraDet = moDataSet
            .Fecha = dtpFecha.Value
            ''.FacturaDif = chkFacturaDif.Checked

            oCompraOld.CompraId = moCompra.CompraId
            oCompraOld.FindByPK()

            .CompraEdit = Me

            .ShowDialog()

            If .Changed Then
               frmCompraNextEdit = True

               ''Call FacturaDetDelete(moCompra.FacturaId)

               If moCompra.FacturaId <> 0 Then
                  Call FacturaDetDelete(moCompra.FacturaId)
                  If BoolFacturaDet() Then
                     Call FacturaDetAdd(moCompra.FacturaId)
                  End If
               End If

            Else

               Call CompraOldLoad(oCompraOld)

            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraOld.Dispose()
      End Try
   End Function

   Private Sub CompraOldLoad(ByVal oCompraOld As clsCompra)

      '' ''moCompra.MontoRec += oCompraOld.MontoRec
      '' ''moCompra.MontoDes += oCompraOld.MontoDes
      ''moCompra.MontoAnt = oCompraOld.MontoAnt
      ''moCompra.MontoOtro = oCompraOld.MontoOtro
      ''moCompra.MontoCos = oCompraOld.MontoCos
      ''moCompra.MontoNet = oCompraOld.MontoNet
      ''moCompra.MontoLiq = oCompraOld.MontoLiq

      moCompra.FacturaId = oCompraOld.FacturaId
      moCompra.FacturaDif = oCompraOld.FacturaDif
      moCompra.FactDifExento = oCompraOld.FactDifExento
      moCompra.TipoRetencionId = oCompraOld.TipoRetencionId
      moCompra.PolizaId = oCompraOld.PolizaId

   End Sub

   Private Function FacturaDetAdd(ByVal lngFacturaId As Long) As Boolean
      Dim oFacturaDet As New clsFacturaDet(clsAppInfo.ConnectString)

      Try
         With oFacturaDet

            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .FacturaId = lngFacturaId

            For Each oRow In moDataTable.Rows

               .MedidaId = ToLong(oRow("MedidaId"))
               .ItemId = ToLong(oRow("ItemId"))
               .Cantidad = ToDecimal(oRow("Cantidad"))
               .Precio = ToDecimal(oRow("PrecioOrg")) - ToDecimal(oRow("PrecioDes")) + ToDecimal(oRow("PrecioRec"))

               If moCompra.MonedaId = 2 Then
                  .Precio *= moCompra.TipoCambio
               End If

               .Importe = ToDecimal(.Cantidad * .Precio)
               .Precio = ToDecimal(.Precio)
               .EstadoId = 11

               If .Insert Then
                  FacturaDetAdd = True
               End If

            Next
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function BoolFacturaDet() As Boolean
      Dim oFacturaPara As New clsFacturaPara(clsAppInfo.ConnectString)

      Try
         With oFacturaPara

            .SelectFilter = clsFacturaPara.SelectFilters.All
            .WhereFilter = clsFacturaPara.WhereFilters.TipoFacturaId
            .EmpresaId = moCompra.EmpresaId
            .TipoFacturaId = 2 'Compra

            If .Find Then
               BoolFacturaDet = CBool(.FacturaDet)
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oFacturaPara.Dispose()
      End Try


   End Function

   Private Function FacturaDetDelete(ByVal lngFacturaId As Long) As Boolean
      Dim oFacturaDet As New clsFacturaDet(clsAppInfo.ConnectString)

      Try
         With oFacturaDet
            .WhereFilter = clsFacturaDet.WhereFilters.FacturaId
            .FacturaId = lngFacturaId

            FacturaDetDelete = .Delete

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaDet = Nothing

      End Try
   End Function

   Private Function FacturaDelete(ByVal lngFacturaId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         With oFactura
            .WhereFilter = clsFactura.WhereFilters.PrimaryKey
            .FacturaId = lngFacturaId

            If .Delete Then
               FacturaDetDelete(lngFacturaId)
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function frmCompPlanFill() As Boolean

      mlngPlanId = ProveedorPlanIdPasFind(moCompra.ProveedorId, mlngPlanAddId)
      'mlngSucursalId = SucursalIdFind(moCompra.AlmacenId)
      mlngSucursalId = moCompra.SucursalId
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
      mlngTipoPlanId = TipoPlanIdFind(mlngPlanId)

      frmCompPlanFill = True

      If clsAppInfo.CentroCostoApli Then
         mlngCentroCostoId = moCompra.CentroCostoId
      End If

   End Function

   Private Function SucursalIdFind(ByVal lngAlmacenId As Long) As Long
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)

      SucursalIdFind = 0

      Try
         With oAlmacen

            .AlmacenId = lngAlmacenId

            If .FindByPK Then
               SucursalIdFind = .SucursalId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAlmacen.Dispose()

      End Try
   End Function

   Private Function ProveedorPlanIdPasFind(ByVal lngProveedorId As Long, ByRef lngPlanAddId As Long) As Long
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      ProveedorPlanIdPasFind = 0

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               lngPlanAddId = .PlanAddIdPas
               Return .PlanIdPas
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function PlanIdActFind(ByVal lngItemId As Long) As Long
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Dim oPlanGrupo As New clsPlanGrupo(clsAppInfo.ConnectString)

      PlanIdActFind = 0

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               With oPlanGrupo
                  .PlanGrupoId = oItem.PlanGrupoId

                  If .FindByPK Then
                     Return .PlanIdAct
                  End If
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()
         oPlanGrupo.Dispose()

      End Try
   End Function

   Private Function mqueItemExist(ByVal lngPlanId As Long) As Boolean
      mqueItemExist = False

      For Each lngId As Long In mqueItem
         If lngId = lngPlanId Then
            Return True
         End If
      Next
   End Function

   Private Sub grdMainPlanId()
      For Each oRow As DataRow In moDataSet.Tables(moCompraDet.TableName).Rows
         oRow("PlanId") = PlanIdActFind(oRow("ItemId"))
      Next
   End Sub

   Private Function grdMainCentroCostoEdit(ByVal lngCentroCostoId As Long) As Boolean
      If clsAppInfo.CentroCostoApli Then
         For Each oRow As DataRow In moDataSet.Tables(moCompraDet.TableName).Rows
            oRow("CentroCostoIdAct") = lngCentroCostoId
         Next
      End If
   End Function

   Private Function ContadoPagoNew() As Boolean
      If moCompra.TipoPagoId = clsTipoPago.CONTADO Then 'Contado
         If clsAppInfo.PagoAuto Then
            ''If True Then
            Dim frm As New frmCompraPagoAutoEdit
            Dim oPago As New clsPago(clsAppInfo.ConnectString)

            Try
               With frm
                  .NewRecord = True
                  .Editing = False

                  oPago.EmpresaId = moCompra.EmpresaId
                  oPago.GestionId = moCompra.GestionId
                  oPago.TipoPagoId = moCompra.TipoPagoId
                  oPago.ProveedorId = moCompra.ProveedorId
                  oPago.Fecha = moCompra.Fecha
                  oPago.TipoCambio = moCompra.TipoCambio
                  oPago.MonedaId = moCompra.MonedaId
                  oPago.MontoPag = moCompra.MontoLiq
                  oPago.ConFac = moCompra.ConFac
                  oPago.SinFac = moCompra.SinFac
                  oPago.CentroCostoId = moCompra.CentroCostoId
                  oPago.SucursalId = moCompra.SucursalId
                  oPago.AppId = clsAppInfo.AppId

                  .CompraId = moCompra.CompraId
                  .CompraNro = ToStr(moCompra.CompraNro)
                  .Fecha = dtpFecha.Value
                  .ProveedorDes = ToStr(cboProveedor.Text)

                  .DataObject = oPago
                  .ShowDialog()

                  If .Changed Then
                     moCompra.EstadoId = clsEstado.REALIZADO
                     cboEstado.SelectedIndex = ListFindItem(cboEstado, moCompra.EstadoId)
                     ContadoPagoNew = True

                  Else
                     moCompra.EstadoId = clsEstado.PENDIENTE
                     ContadoPagoNew = True

                  End If
                  frm.Dispose()
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Return False

            End Try
         Else
            moCompra.EstadoId = clsEstado.PENDIENTE
            ContadoPagoNew = True
         End If
      Else
         ContadoPagoNew = True
      End If
   End Function

   Private Function CreditoNew(ByRef lngCreditoId As Long, ByVal lngTipoCompId As Long, ByVal lngCompNro As Long) As Boolean
      If moCompra.TipoPagoId = clsTipoPago.CREDITO Then 'Credito
         Dim ClienteMovId As Long

         If mboolCreditoAuto Then
            If CreditoAdd(lngCreditoId) Then
               If CreditoDetAdd(lngCreditoId) Then
                  If ProveedorMovAdd(ClienteMovId, 6, lngCreditoId, 2, moCompra.MontoLiq, 2, lngTipoCompId, lngCompNro, moCompra.PlanId) Then
                     moCompra.EstadoId = clsEstado.PROGRAMADO
                     cboEstado.SelectedIndex = ListFindItem(cboEstado, moCompra.EstadoId)

                     Return True
                  End If
               End If
            End If

         Else
            lngCreditoId = 0
            Return True
         End If

      Else
         lngCreditoId = 0
         Return True
      End If
   End Function

   Private Function CreditoAdd(ByRef lngCreditoId As Long) As Boolean
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      CreditoAdd = False

      Try
         With oCredito
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = moCompra.CompraId
            .TipoCreditoId = 4 'Interes Sobre Saldo
            .CreditoNro = CompraNroNext(6, .GestionId, moCompra.SucursalId)
            .FechaIni = moCompra.Fecha
            .FechaFin = ToDate(DateAdd(DateInterval.Day, mlngCreditoDias, dtpFecha.Value))
            .ProveedorId = moCompra.ProveedorId
            .CreditoDes = "Nota de Compra Nro. " + txtCompraNro.Text + "; " + txtCompraDes.Text
            .FrecuenciaId = 1
            .FrecuenciaNro = mlngCreditoDias
            .MonedaId = moCompra.MonedaId
            .TipoCambio = moCompra.TipoCambio
            .MontoLiq = moCompra.MontoLiq
            .MontoAmo = 0
            .CantidadCuota = 1
            .MontoCuota = moCompra.MontoLiq
            .InteresAnual = mdecInteresAnual
            .SaldoIni = 0
            .SinFac = chkSinFac.Checked
            .ConFac = chkConFac.Checked
            .CentroCostoId = moCompra.CentroCostoId
            .EstadoId = clsEstado.PROGRAMADO
                .SucursalId = moCompra.SucursalId
            If .Insert() Then
               lngCreditoId = .CreditoId
               CreditoAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function CreditoDetAdd(ByVal lngCreditoId As Long) As Boolean
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)

      CreditoDetAdd = False

      Try
         With oCreditoDet
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = moCompra.CompraId
            .TipoCreditoId = 4 'Interes Sobre Saldo
            .CreditoId = lngCreditoId
            .Fecha = ToDate(DateAdd(DateInterval.Day, mlngCreditoDias, dtpFecha.Value))
            .ProveedorId = moCompra.ProveedorId
            .MonedaId = moCompra.MonedaId
            .TipoCambio = moCompra.TipoCambio
            ''.CompraOrden = moCompra.CompraOrden
            .CuotaNro = 1
            .Capital = moCompra.MontoLiq
            .Interes = 0
            .Importe = moCompra.MontoLiq
            .CapitalAmo = 0
            .InteresAmo = 0
            .FechaAmo = ToDate(DateAdd(DateInterval.Day, 0, dtpFecha.Value))
            .InteresPen = 0
            .CentroCostoId = moCompra.CentroCostoId
            .EstadoId = clsEstado.PROGRAMADO

            If .Insert() Then
               CreditoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCreditoDet.Dispose()

      End Try
   End Function

   Private Function CreditoEdit(ByRef lngCreditoId As Long, ByVal lngTipoCompId As Long, ByVal lngCompNro As Long) As Boolean

      If moCompra.TipoPagoId = clsTipoPago.CREDITO Then 'Credito
         If mboolCreditoAuto Then
            If lngCreditoId > 0 Then
               If CreditoUpdate(lngCreditoId) Then
                  If CreditoDetUpdate(lngCreditoId) Then
                     If ProveedorMovUpdate(6, lngCreditoId, 1, moCompra.MontoLiq) Then
                        moCompra.EstadoId = clsEstado.PROGRAMADO
                        Return True
                     End If
                  End If
               End If
            Else
               Call CreditoNew(lngCreditoId, lngTipoCompId, lngCompNro)
               Return True
            End If
         Else
            lngCreditoId = 0
            Return True
         End If

      Else
         lngCreditoId = 0
         Return True
      End If
   End Function

   Private Function CreditoUpdate(ByVal lngCreditoId As Long) As Boolean
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      CreditoUpdate = False

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               .EmpresaId = moCompra.EmpresaId
               .GestionId = moCompra.GestionId
               .CompraId = moCompra.CompraId
               .TipoCreditoId = 4 'Interes Sobre Saldo
               .FechaIni = moCompra.Fecha
               .FechaFin = ToDate(DateAdd(DateInterval.Day, mlngCreditoDias, dtpFecha.Value))
               .ProveedorId = moCompra.ProveedorId
               .CreditoDes = "Nota de Compra Nro. " + txtCompraNro.Text + "; " + txtCompraDes.Text
               .FrecuenciaId = 1
               .FrecuenciaNro = mlngCreditoDias
               .MonedaId = moCompra.MonedaId
               .TipoCambio = moCompra.TipoCambio
               .MontoLiq = moCompra.MontoLiq
               .MontoAmo = 0
               .CantidadCuota = 1
               .MontoCuota = moCompra.MontoLiq
               .InteresAnual = mdecInteresAnual
               .SaldoIni = 0
               .SinFac = chkSinFac.Checked
               .ConFac = chkConFac.Checked
               .CentroCostoId = moCompra.CentroCostoId
               .EstadoId = clsEstado.PROGRAMADO

               If .Update Then
                  CreditoUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function CreditoDetUpdate(ByRef lngCreditoId As Long) As Boolean
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)

      CreditoDetUpdate = False

      Try
         With oCreditoDet
            .SelectFilter = clsCreditoDet.SelectFilters.All
            .WhereFilter = clsCreditoDet.WhereFilters.CreditoId
            .CreditoId = lngCreditoId

            If .Find Then
               .EmpresaId = moCompra.EmpresaId
               .GestionId = moCompra.GestionId
               .CompraId = moCompra.CompraId
               .TipoCreditoId = 4 'Interes Sobre Saldo
               .CreditoId = lngCreditoId
               .Fecha = ToDate(DateAdd(DateInterval.Day, mlngCreditoDias, dtpFecha.Value))
               .ProveedorId = moCompra.ProveedorId
               .MonedaId = moCompra.MonedaId
               .TipoCambio = moCompra.TipoCambio
               .CuotaNro = 1
               .Capital = moCompra.MontoLiq
               .Interes = 0
               .Importe = moCompra.MontoLiq
               .CapitalAmo = 0
               .InteresAmo = 0
               ''.FechaAmo = ToDate(DateAdd(DateInterval.Day, mlngDiasGracia, dtpFecha.Value))
               .FechaAmo = ToDate(DateAdd(DateInterval.Day, 0, dtpFecha.Value))
               .InteresPen = 0
               .CentroCostoId = moCompra.CentroCostoId
               .EstadoId = clsEstado.PROGRAMADO

               If .Update Then
                  CreditoDetUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCreditoDet.Dispose()

      End Try
   End Function

   Private Function NotaAdd(ByRef lngNotaId As Long, ByRef lngTipoNotaId As Long, ByRef lngNotaNro As Long) As Boolean

      If Not (generarInventario()) Then
         Return True
      End If

      Dim oNota As New clsNota(clsAppInfo.ConnectString)
      NotaAdd = False

      Try
         With oNota
            .EmpresaId = moCompra.EmpresaId
            .TipoNotaId = 2
            .NotaNro = NotaNroNext(.TipoNotaId, moCompra.GestionId, moCompra.SucursalId)
            .Fecha = moCompra.Fecha
            .AlmacenIdOrg = moCompra.AlmacenId
            .AlmacenIdDes = 0
            .MonedaId = moCompra.MonedaId
            .TipoCambio = moCompra.TipoCambio
            .NotaDes = "Nota de Compra al  " + cboTipoPago.Text + " Nro. " + txtCompraNro.Text + "; Nro. Orden " + moCompra.CompraOrden + "; Proveedor. " + cboProveedor.Text + "; " + txtCompraDes.Text
            .NotaObs = ""
            .NotaMonto = 0
            .GestionId = moCompra.GestionId
            '.TipoCompId = 0
            '.CompNro = 0
            .PlanId = 0
            .EstadoId = clsEstado.CERRADO
            .ConFac = moCompra.ConFac
            .SinFac = moCompra.SinFac
            .NotaOrden = moCompra.CompraOrden

            .CentroCostoIdOrg = moCompra.CentroCostoId
            .CentroCostoIdDes = 0
            .SucursalId = moCompra.SucursalId
            .CompId = 0 ''moVenta.CompId
            .AppId = clsAppInfo.AppId
            .TipoDocumentoId = clsTipoCompra.COMPRA
            .DocumentoId = moCompra.CompraId

            If .Insert() Then
               lngNotaId = .NotaId
               lngTipoNotaId = .TipoNotaId
               lngNotaNro = .NotaNro

               NotaAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNota.Dispose()

      End Try
   End Function

   Private Function CompraMontoInv() As Decimal
      CompraMontoInv = 0

      For Each oRow As DataRow In moDataSet.Tables(moCompraDet.TableName).Rows
         Call ItemParametro(oRow("ItemId"))

         If mlngTipoItemId <> 2 Then
            CompraMontoInv += ToDecimal(oRow("Cantidad")) * ToDecimal(oRow("PrecioCos"))
         End If

      Next

   End Function

   Private Function NotaUpdate(ByVal lngNotaId As Long) As Boolean
      If Not (generarInventario()) Then
         Return True
      End If

      Dim oNota As New clsNota(clsAppInfo.ConnectString)
      NotaUpdate = False

      Try
         With oNota

            If (lngNotaId <> 0) Then
               .NotaId = lngNotaId

               If .FindByPK Then
                  .Fecha = ToDate(.Fecha)
                  '.TipoCompId = moCompra.TipoCompId
                  '.CompNro = moCompra.CompNro
                  .PlanId = moCompra.PlanId

                  .NotaMonto = ToDecimal(CompraMontoInv())
                  '.EstadoId = IIf(mboolTieneInv, 11, 12)
                  .EstadoId = clsEstado.CERRADO

                  'If moCompra.FacturaId <> 0 Then
                  '   .NotaMonto = .NotaMonto * (1 - clsAppInfo.IVA)
                  'End If

                  .NotaDes = "Nota de Compra al  " + cboTipoPago.Text + " Nro. " + txtCompraNro.Text + "; Nro. Orden " + moCompra.CompraOrden + "; Proveedor. " + cboProveedor.Text + "; " + txtCompraDes.Text
                  .NotaOrden = moCompra.CompraOrden

                  .CentroCostoIdOrg = moCompra.CentroCostoId
                  .CentroCostoIdDes = 0
                  .CompId = moCompra.CompId

                  If .Update Then
                     NotaUpdate = True
                  End If
               End If
            Else
               NotaUpdate = True
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNota.Dispose()

      End Try
   End Function

   Private Function NotaDetAdd(ByVal lngNotaId As Long, ByRef lngNotaDetId As Long) As Boolean
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)

      NotaDetAdd = False

      Try
         With oNotaDet
            .EmpresaId = moCompraDet.EmpresaId
            .GestionId = moCompraDet.GestionId
            .TipoNotaId = 2
            .TipoMovId = 1
            .NotaId = lngNotaId
            .Fecha = moCompraDet.Fecha
            .AlmacenId = moCompraDet.AlmacenId
            .MonedaId = moCompraDet.MonedaId
            .TipoCambio = moCompraDet.TipoCambio
            .ItemId = moCompraDet.ItemId
            .MedidaId = moCompraDet.MedidaId
            .NotaDetDes = moCompraDet.CompraDetDes
            .CantidadEnt = moCompraDet.Cantidad
            .CantidadSal = 0
            .PrecioOrg = moCompraDet.PrecioOrg 'Costo FOB Original
            .PrecioCos = moCompraDet.PrecioCos 'Costo CIF Con todos los costos adicionales

            If mdecImporteCif > 0 Then
               .Importe = mdecImporteCif
            Else
               .Importe = moCompraDet.Cantidad * moCompraDet.PrecioCos
            End If

            .CentroCostoId = moCompraDet.CentroCostoIdAct
            .CentroCostoDetId = moCompraDet.CentroCostoDetIdAct
            .SucursalId = moCompraDet.SucursalIdAct
            .EstadoId = clsEstado.CERRADO

            If .Insert() Then
               lngNotaDetId = .NotaDetId
               NotaDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNotaDet.Dispose()

      End Try
   End Function

   Private Function NotaDetUpdate(ByVal lngNotaDetId As Long) As Boolean
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)

      NotaDetUpdate = False

      Try
         With oNotaDet
            .NotaDetId = lngNotaDetId

            If .FindByPK Then
               .Fecha = moCompraDet.Fecha
               .NotaDetDes = moCompraDet.CompraDetDes
               .CantidadEnt = moCompraDet.Cantidad 'Cantidad de Entrada actual
               .PrecioOrg = moCompraDet.PrecioOrg 'Costo FOB Original
               .PrecioCos = moCompraDet.PrecioCos 'Costo CIF Con todos los costos adicionales
               '.Importe = moCompraDet.Cantidad * moCompraDet.PrecioCos

               If mdecImporteCif > 0 Then
                  .Importe = mdecImporteCif
               Else
                  .Importe = moCompraDet.Cantidad * moCompraDet.PrecioCos
               End If

               .CentroCostoId = moCompraDet.CentroCostoIdAct
               .CentroCostoDetId = moCompraDet.CentroCostoDetIdAct
               .SucursalId = moCompraDet.SucursalIdAct

               .EstadoId = clsEstado.CERRADO

               If .Update() Then
                  NotaDetUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNotaDet.Dispose()

      End Try
   End Function

   Private Function NotaDetDelete(ByVal lngNotaDetId As Long) As Boolean
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)

      NotaDetDelete = False

      Try
         With oNotaDet
            .NotaDetId = lngNotaDetId

            .WhereFilter = clsNotaDet.WhereFilters.PrimaryKey

            If .Delete() Then
               NotaDetDelete = True
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNotaDet.Dispose()

      End Try
   End Function

   Private Function NotaDetIdFind(ByVal lngNotaId As Long, ByVal lngItemId As Long) As Long
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)

      NotaDetIdFind = 0

      Try
         With oNotaDet
            .SelectFilter = clsNotaDet.SelectFilters.All
            .WhereFilter = clsNotaDet.WhereFilters.TipoMovId
            .EmpresaId = moCompra.EmpresaId
            .NotaId = lngNotaId
            .ItemId = lngItemId
            .TipoMovId = 1

            If .Find Then
               NotaDetIdFind = .NotaDetId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNotaDet.Dispose()

      End Try
   End Function

   Private Function PolizaUpdate(ByVal lngPolizaId As Long, ByVal lngCompId As Long) As Boolean
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      PolizaUpdate = False

      Try
         With oPoliza

            .PolizaId = lngPolizaId

            If .FindByPK Then
               .CompId = lngCompId
               .PolizaFecha = ToDate(.PolizaFecha)

               If .Update() Then
                  PolizaUpdate = True
               End If

            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza.Dispose()

      End Try
   End Function

   Private Function CompraRecargoTotal(ByVal lngCompraId As Long, ByVal bytAplicarCosto As Byte, ByRef lngPlanIdRecargo As Long) As Decimal
      Dim oCompraRecargo As New clsCompraRecargo(clsAppInfo.ConnectString)
      Dim decRecargo As Decimal = 0

      Try
         With oCompraRecargo
            .SelectFilter = clsCompraRecargo.SelectFilters.All
            .WhereFilter = clsCompraRecargo.WhereFilters.AplicarCosto
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = lngCompraId
            .AplicarCosto = bytAplicarCosto

            If .Open() Then
               Do While .Read()
                  decRecargo += .Monto
                  lngPlanIdRecargo = PlanRecargoPlanIdFind(.PlanRecargoId)
                  .MoveNext()
               Loop
            End If
         End With

         Return decRecargo

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraRecargo.Dispose()

      End Try
   End Function

   Private Function CompraDescuentoTotal(ByVal lngCompraId As Long, ByVal bytAplicarCosto As Byte, ByRef lngPlanIdDescuento As Long) As Decimal
      Dim oCompraDescuento As New clsCompraDescuento(clsAppInfo.ConnectString)
      Dim decDescuento As Decimal = 0

      Try
         With oCompraDescuento
            .SelectFilter = clsCompraDescuento.SelectFilters.All
            .WhereFilter = clsCompraDescuento.WhereFilters.AplicarCosto
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = lngCompraId
            .AplicarCosto = bytAplicarCosto

            If .Open() Then
               Do While .Read()
                  decDescuento += .Monto
                  lngPlanIdDescuento = PlanDescuentoPlanIdFind(.PlanDescuentoId)
                  .MoveNext()
               Loop
            End If
         End With

         Return decDescuento

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDescuento.Dispose()

      End Try
   End Function

   Private Function CompNewRecargoDescuento() As Boolean
      '   Dim lngTipoCompId As Long
      '   Dim lngCompNro As Long
      '   Dim oRow As DataRow
      '   Dim decMontoBs As Decimal
      '   Dim decMontoUs As Decimal
      '   Dim decMontoOrg As Decimal
      '   Dim decMontoBsOld As Decimal = 0
      '   Dim decMontoUsOld As Decimal = 0
      '   Dim decMontoOrgOld As Decimal = 0
      '   Dim lngCompId As Long
      '   Dim lngCompDetId As Long

      '   Dim decTotalMontoBs As Decimal = 0
      '   Dim decTotalMontoUs As Decimal = 0
      '   Dim decTotalMontoOrg As Decimal = 0

      '   Dim decRecargoNoApli As Decimal = 0
      '   Dim decDescuentoNoApli As Decimal = 0

      '   CompNewRecargoDescuento = True

      '   Try
      '      lngTipoCompId = 3 'Traspaso
      '      decRecargoNoApli = CompraRecargoTotal(moCompra.CompraId, 0)
      '      decDescuentoNoApli = CompraDescuentoTotal(moCompra.CompraId, 0)

      '      If (decRecargoNoApli > 0) Or (decDescuentoNoApli > 0) Then
      '         If CompAdd(lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante

      '            'Recargos
      '            If decRecargoNoApli > 0 Then
      '               Dim oCompraRecargo As New clsCompraRecargo(clsAppInfo.ConnectString)

      '               With oCompraRecargo
      '                  .SelectFilter = clsCompraRecargo.SelectFilters.All
      '                  .WhereFilter = clsCompraRecargo.WhereFilters.AplicarCosto
      '                  .EmpresaId = moCompra.EmpresaId
      '                  .GestionId = moCompra.GestionId
      '                  .CompraId = moCompra.CompraId
      '                  .AplicarCosto = 0

      '                  If .Open Then
      '                     Dim lngPlanIdRecargo As Long

      '                     Do While .Read
      '                        lngPlanIdRecargo = PlanRecargoPlanIdFind(.PlanRecargoId)

      '                        If moCompra.MonedaId = 1 Then
      '                           decMontoBs = .Monto
      '                           decMontoUs = ToDecimal(.Monto / moCompra.TipoCambio)
      '                           decMontoOrg = decMontoBs
      '                           decTotalMontoBs += decMontoBs
      '                           decTotalMontoUs += decMontoUs
      '                           decTotalMontoOrg += decMontoOrg

      '                        ElseIf moCompra.MonedaId = 2 Then
      '                           decMontoBs = ToDecimal(.Monto * moCompra.TipoCambio)
      '                           decMontoUs = .Monto
      '                           decMontoOrg = decMontoUs
      '                           decTotalMontoBs += decMontoBs
      '                           decTotalMontoUs += decMontoUs
      '                           decTotalMontoOrg += decMontoOrg
      '                        End If

      '                        If Not CompDetFind(lngCompId, lngCompDetId, lngPlanIdRecargo, 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
      '                           If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdRecargo, "", decMontoBs, decMontoUs, decMontoOrg, 1, , , lngCompDetId) Then
      '                              CompNewRecargoDescuento = True
      '                           End If
      '                        Else
      '                           If CompDetUpdate(lngCompDetId, "", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 1) Then
      '                              CompNewRecargoDescuento = True
      '                           End If
      '                        End If

      '                        .MoveNext()
      '                     Loop
      '                  End If
      '               End With
      '            End If

      '            'Descuentos
      '            If decDescuentoNoApli > 0 Then
      '               Dim oCompraDescuento As New clsCompraDescuento(clsAppInfo.ConnectString)

      '               With oCompraDescuento
      '                  .SelectFilter = clsCompraDescuento.SelectFilters.All
      '                  .WhereFilter = clsCompraDescuento.WhereFilters.AplicarCosto
      '                  .EmpresaId = moCompra.EmpresaId
      '                  .GestionId = moCompra.GestionId
      '                  .CompraId = moCompra.CompraId
      '                  .AplicarCosto = 0

      '                  If .Open Then
      '                     Dim lngPlanIdDescuento As Long

      '                     Do While .Read
      '                        lngPlanIdDescuento = PlanDescuentoPlanIdFind(.PlanDescuentoId)

      '                        If moCompra.MonedaId = 1 Then
      '                           decMontoBs = .Monto
      '                           decMontoUs = ToDecimal(.Monto / moCompra.TipoCambio)
      '                           decMontoOrg = decMontoBs
      '                           decTotalMontoBs -= decMontoBs
      '                           decTotalMontoUs -= decMontoUs
      '                           decTotalMontoOrg -= decMontoOrg

      '                        ElseIf moCompra.MonedaId = 2 Then
      '                           decMontoBs = ToDecimal(.Monto * moCompra.TipoCambio)
      '                           decMontoUs = .Monto
      '                           decMontoOrg = decMontoUs
      '                           decTotalMontoBs -= decMontoBs
      '                           decTotalMontoUs -= decMontoUs
      '                           decTotalMontoOrg -= decMontoOrg
      '                        End If

      '                        If Not CompDetFind(lngCompId, lngCompDetId, lngPlanIdDescuento, 2, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
      '                           If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdDescuento, "", decMontoBs, decMontoUs, decMontoOrg, 2, , , lngCompDetId) Then
      '                              CompNewRecargoDescuento = True
      '                           End If
      '                        Else
      '                           If CompDetUpdate(lngCompDetId, "", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 2) Then
      '                              CompNewRecargoDescuento = True
      '                           End If
      '                        End If

      '                        .MoveNext()
      '                     Loop
      '                  End If
      '               End With
      '            End If

      '            If decTotalMontoOrg > 0 Then 'Contra Cuenta Al Haber
      '               If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 2, , , lngCompDetId) Then
      '                  If mlngPlanAddId <> 0 Then  'Analitico Adicional
      '                     If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 2) Then
      '                        CompNewRecargoDescuento = True
      '                     End If
      '                  End If
      '               End If

      '            ElseIf decTotalMontoOrg < 0 Then 'Contra Cuenta Al Debe
      '               decTotalMontoBs = Math.Abs(decTotalMontoBs)
      '               decTotalMontoUs = Math.Abs(decTotalMontoUs)
      '               decTotalMontoOrg = Math.Abs(decTotalMontoOrg)

      '               If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 1, , , lngCompDetId) Then
      '                  If mlngPlanAddId <> 0 Then  'Analitico Adicional
      '                     If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 1) Then
      '                        CompNewRecargoDescuento = True
      '                     End If
      '                  End If
      '               End If
      '            End If
      '         End If

      '         If decRecargoNoApli >= decDescuentoNoApli Then 'Totales del Comp
      '            If moCompra.MonedaId = 1 Then
      '               decMontoBs = decRecargoNoApli
      '               decMontoUs = ToDecimal(decRecargoNoApli / moCompra.TipoCambio)

      '            ElseIf moCompra.MonedaId = 2 Then
      '               decMontoBs = ToDecimal(decRecargoNoApli * moCompra.TipoCambio)
      '               decMontoUs = decRecargoNoApli
      '            End If

      '            If CompUpdate(lngCompId, decMontoBs, decMontoUs, "") Then
      '               CompNewRecargoDescuento = True
      '            End If

      '         Else
      '            If moCompra.MonedaId = 1 Then
      '               decMontoBs = moCompra.MontoAnt
      '               decMontoUs = ToDecimal(moCompra.MontoAnt / moCompra.TipoCambio)

      '            ElseIf moCompra.MonedaId = 2 Then
      '               decMontoBs = ToDecimal(moCompra.MontoAnt * moCompra.TipoCambio)
      '               decMontoUs = moCompra.MontoAnt
      '            End If

      '            If CompUpdate(lngCompId, decMontoBs, decMontoUs, "") Then
      '               CompNewRecargoDescuento = True
      '            End If
      '         End If
      '      End If

      '   Catch exp As Exception
      '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      '      Return False

      '   End Try
   End Function

   Private Function CompNewPoliza() As Boolean
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal
      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0
      Dim lngCompId As Long
      Dim lngCompDetId As Long
      Dim strFecha As String

      CompNewPoliza = True

      Try
         If moCompra.PolizaId > 0 Then
            Dim lngPlanIdPoliza, lngPlanAddIdPoliza, lngCentroCostoIdPoliza, lngCentroCostoDetIdPoliza, lngSucursalIdPoliza As Long
            Dim strPolizaNro As String
            Dim decPolizaIva As Decimal = PolizaIvaFind(moCompra.PolizaId, strFecha, lngPlanIdPoliza, strPolizaNro, lngPlanAddIdPoliza, lngCentroCostoIdPoliza, lngCentroCostoDetIdPoliza, lngSucursalIdPoliza)
            mdatFecha = ToDate2(strFecha)

            If decPolizaIva > 0 Then
               Dim lngTipoPlanId As Long = TipoPlanIdFind(lngPlanIdPoliza)

               If (lngTipoPlanId = 2) Or (lngTipoPlanId = 3) Then
                  lngTipoCompId = 2  'Egreso
               Else
                  lngTipoCompId = 3  'Traspaso
               End If

               If CompAdd(lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante
                  decMontoBs = decPolizaIva
                  decMontoUs = ToDecimal(decPolizaIva / moCompra.TipoCambio)
                  decMontoOrg = decMontoBs

                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreId, "Poliza Nro. " & strPolizaNro, decMontoBs, decMontoUs, decMontoOrg, 1, , mlngCentroCostoId, lngCompDetId) Then
                     CompNewPoliza = True
                  End If

                  If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdPoliza, "Poliza Nro. " & strPolizaNro, decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, lngCentroCostoIdPoliza, lngCompDetId) Then
                     CompNewPoliza = True

                     If lngPlanAddIdPoliza <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdPoliza, lngPlanAddIdPoliza, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                           CompNewPoliza = True
                        End If
                     End If

                     CompNewPoliza = True

                     If lngCentroCostoDetIdPoliza <> 0 Then  'Actividad
                        If CompCentroCostoDetAdd(lngCompId, lngCompDetId, lngPlanIdPoliza, lngCentroCostoIdPoliza, lngCentroCostoDetIdPoliza, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                           CompNewPoliza = True
                        End If
                     End If



                  End If

                  If CompUpdate(lngCompId, decMontoBs, decMontoUs, "Poliza Nro. " & strPolizaNro) Then
                     CompNewPoliza = True
                  End If

                  If PolizaUpdate(moCompra.PolizaId, lngCompId) Then
                     CompNewPoliza = True
                  End If

               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompEditPoliza(ByVal lngCompId As Long) As Boolean
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal
      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0
      Dim lngCompDetId As Long
      Dim lngPlanIdPoliza As Long
      Dim strPolizaNro As String
      Dim strFecha As String

      CompEditPoliza = True

      Try
         If moCompra.PolizaId > 0 Then
            Dim lngPlanAddIdPoliza, lngCentroCostoIdPoliza, lngCentroCostoDetIdPoliza, lngSucursalIdPoliza As Long
            Dim decPolizaIva As Decimal = PolizaIvaFind(moCompra.PolizaId, strFecha, lngPlanIdPoliza, strPolizaNro, lngPlanAddIdPoliza, lngCentroCostoIdPoliza, lngCentroCostoDetIdPoliza, lngSucursalIdPoliza, lngCompId)
            mdatFecha = ToDate2(strFecha)

            If decPolizaIva > 0 Then
               Dim lngTipoPlanId As Long = TipoPlanIdFind(lngPlanIdPoliza)

               If (lngTipoPlanId = 2) Or (lngTipoPlanId = 3) Then
                  lngTipoCompId = 2  'Egreso
               Else
                  lngTipoCompId = 3  'Traspaso
               End If

               If CompDetDeleteAll(lngCompId) Then 'Elimina el detalle del Comprobante
                  decMontoBs = decPolizaIva
                  decMontoUs = ToDecimal(decPolizaIva / moCompra.TipoCambio)
                  decMontoOrg = decMontoBs

                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreId, "Poliza Nro. " & strPolizaNro, decMontoBs, decMontoUs, decMontoOrg, 1, , mlngCentroCostoId, lngCompDetId) Then
                     CompEditPoliza = True
                  End If

                  If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdPoliza, "Poliza Nro. " & strPolizaNro, decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, lngCentroCostoIdPoliza, lngCompDetId) Then
                     CompEditPoliza = True

                     If lngPlanAddIdPoliza <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdPoliza, lngPlanAddIdPoliza, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                           CompEditPoliza = True
                        End If
                     End If

                     CompEditPoliza = True

                     If lngCentroCostoDetIdPoliza <> 0 Then  'Actividad
                        If CompCentroCostoDetAdd(lngCompId, lngCompDetId, lngPlanIdPoliza, lngCentroCostoIdPoliza, lngCentroCostoDetIdPoliza, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                           CompEditPoliza = True
                        End If
                     End If
                  End If

                  If CompUpdate(lngCompId, decMontoBs, decMontoUs, "Póliza Nro. " + strPolizaNro + " ; ") Then
                     CompEditPoliza = True
                  End If
               End If
            End If
         Else

            If lngCompId > 0 Then
               If CompAnular(lngCompId) Then 'Anular  Comprobante
                  If CompDetDeleteAll(lngCompId) Then 'Elimina el detalle del Comprobante
                     CompEditPoliza = True
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompNew(ByRef lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      Dim oRow As DataRow
      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal
      Dim decMontoOrgDif As Decimal
      Dim decMontoIvaBs As Decimal
      Dim decMontoIvaUs As Decimal
      Dim decIvaBs As Decimal = 0
      Dim decIvaUs As Decimal = 0
      Dim decIvaOrg As Decimal = 0

      Dim decFacturaIvaBs As Decimal = 0
      Dim decFacturaIvaUs As Decimal = 0

      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0
      'Dim lngCompId As Long
      Dim lngCompDetId As Long

      Dim decTotalMontoBs As Decimal = 0
      Dim decTotalMontoUs As Decimal = 0
      Dim decTotalMontoOrg As Decimal = 0

      Dim decGralMontoBs As Decimal = 0
      Dim decGralMontoUs As Decimal = 0

      Dim decImporte As Decimal = 0
      Dim decParticipa As Decimal = 0

      Dim lngCompDetIdCre As Long
      Dim lngPlanIdCreCount As Long = 0

      Dim lngPlanIdRecargo As Long
      Dim lngPlanIdDescuento As Long
      Dim decMontoSinCostos As Decimal

      Dim decRetencionIUE_ITBs As Decimal = 0
      Dim decRetencionIUE_ITUs As Decimal = 0

      Dim decIUEBs As Decimal = 0
      Dim decIUEUs As Decimal = 0
      Dim decIUEOrg As Decimal = 0

      Dim decITBs As Decimal = 0
      Dim decITUs As Decimal = 0
      Dim decITOrg As Decimal = 0

      Dim decRetencionBs As Decimal = 0
      Dim decRetencionUs As Decimal = 0
      Dim decRetencionOrg As Decimal = 0

      Dim decExentoIvaBs As Decimal = 0
      Dim decExentoIvaUs As Decimal = 0

      Dim decMontoIvaOrgBs As Decimal = 0
      Dim decMontoIvaOrgUs As Decimal = 0

      Dim decExentoBs As Decimal = 0
      Dim decExentoUs As Decimal = 0
      Dim decExentoOrg As Decimal = 0

      Dim boolRet_AsuEmp As Boolean = False      'Retencion Asume Proveedor entonces no afecta inventario
      Dim lngFacturaNro As Long = 0

      CompNew = True

      Try
         lngTipoCompId = 3 'Traspaso
         mdatFecha = dtpFecha.Value

         If CompAdd(lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante
            Call grdMainPlanId()

            decMontoSinCostos = CompraDescuentoTotal(moCompra.CompraId, 0, lngPlanIdDescuento) - CompraRecargoTotal(moCompra.CompraId, 0, lngPlanIdRecargo)

            If moCompra.FacturaId > 0 Then
               decFacturaIvaBs = FacturaIvaBsFind(moCompra.FacturaId, decFacturaIvaUs, lngFacturaNro, decExentoIvaBs, decExentoIvaUs)

            ElseIf ToBool(moCompra.FacturaDif) Then 'Factura Diferida 
               If moCompra.MonedaId = 1 Then
                  decFacturaIvaBs = ToDecimal((moCompra.MontoBru - moCompra.FactDifExento) * clsAppInfo.IVA)
                  decFacturaIvaUs = ToDecimal(((moCompra.MontoBru - moCompra.FactDifExento) / moCompra.TipoCambio) * clsAppInfo.IVA)

                  decExentoIvaBs = ToDecimal(moCompra.FactDifExento * clsAppInfo.IVA)
                  decExentoIvaUs = ToDecimal((moCompra.FactDifExento / moCompra.TipoCambio) * clsAppInfo.IVA)

               ElseIf moCompra.MonedaId = 2 Then

                  decFacturaIvaBs = ToDecimal(((moCompra.MontoBru - moCompra.FactDifExento) * moCompra.TipoCambio) * clsAppInfo.IVA)
                  decFacturaIvaUs = ToDecimal((moCompra.MontoBru - moCompra.FactDifExento) * clsAppInfo.IVA)

                  decExentoIvaBs = ToDecimal((moCompra.FactDifExento * moCompra.TipoCambio) * clsAppInfo.IVA)
                  decExentoIvaUs = ToDecimal(moCompra.FactDifExento * clsAppInfo.IVA)

               End If
            ElseIf moCompra.TipoRetencionId > 0 Then 'Retencion

               RetencionBsUsCalc(boolRet_AsuEmp, decRetencionIUE_ITBs, decRetencionIUE_ITUs, decIUEBs, decIUEUs, decIUEOrg, _
                                 decITBs, decITUs, decITOrg, decRetencionBs, decRetencionUs, decRetencionOrg)
            End If

            For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
               decParticipa = oRow("ImporteBru") / moCompra.MontoBru
               decImporte = oRow("ImporteBru")

               If (moCompra.FacturaId = 0) And (Not ToBool(moCompra.FacturaDif)) And (Not boolRet_AsuEmp) Then 'Compra Sin Factura   y sin Retencion  o Asume Prov
                  If moCompra.MonedaId = 1 Then
                     decMontoBs = ToDecimal(decImporte)
                     decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                     decMontoOrg = decMontoBs
                     decTotalMontoBs += decMontoBs
                     decTotalMontoUs += decMontoUs
                     decTotalMontoOrg += decMontoOrg

                  ElseIf moCompra.MonedaId = 2 Then
                     decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                     decMontoUs = ToDecimal(decImporte)
                     decMontoOrg = decMontoUs
                     decTotalMontoBs += decMontoBs
                     decTotalMontoUs += decMontoUs
                     decTotalMontoOrg += decMontoOrg
                  End If

                  If Not CompDetCentroCostoFind(lngCompId, lngCompDetId, oRow("PlanIdAct"), 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld, oRow("CentroCostoIdAct")) Then
                     If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdAct"), "", decMontoBs, decMontoUs, decMontoOrg, 1, mlngSucursalId, oRow("CentroCostoIdAct"), lngCompDetId) Then
                        If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoBs, decMontoUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        CompNew = True

                        If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoBs, decMontoUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                     End If
                  Else
                     If CompDetUpdate(lngCompDetId, "", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 1) Then
                        If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoBs, decMontoUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        CompNew = True

                        If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoBs, decMontoUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                     End If
                  End If

               ElseIf moCompra.FacturaId > 0 Then 'Compra Con Factura
                  If Not clsAppInfo.SepararExento Then
                     If moCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(decImporte)
                        decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                        decMontoOrg = decMontoBs

                        decMontoIvaBs = decMontoBs - ToDecimal(decParticipa * decFacturaIvaBs)
                        decMontoIvaUs = decMontoUs - ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)
                        decIvaBs += ToDecimal(decParticipa * decFacturaIvaBs)
                        decIvaUs += ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)

                        decIvaOrg = decIvaBs

                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moCompra.MonedaId = 2 Then
                        decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                        decMontoUs = ToDecimal(decImporte)
                        decMontoOrg = decMontoUs

                        decMontoIvaBs = decMontoBs - ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                        decMontoIvaUs = decMontoUs - ToDecimal(decParticipa * decFacturaIvaUs)
                        decIvaBs += ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                        decIvaUs += ToDecimal(decParticipa * decFacturaIvaUs)

                        decIvaOrg = decIvaUs

                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg
                     End If
                  Else

                     If moCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(decImporte)
                        decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                        decMontoOrg = decMontoBs

                        decMontoIvaOrgBs = decMontoBs - ToDecimal(decParticipa * decFacturaIvaBs)
                        decMontoIvaOrgUs = decMontoUs - ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)
                        ''Separando Exento
                        decMontoIvaBs = decMontoIvaOrgBs - ToDecimal(decParticipa * decExentoIvaBs)
                        decMontoIvaUs = decMontoIvaOrgUs - ToDecimal(decParticipa * decExentoIvaUs)

                        decIvaBs += ToDecimal(decParticipa * decFacturaIvaBs)
                        decIvaUs += ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)
                        decIvaOrg = decIvaBs

                        decExentoBs += ToDecimal(decParticipa * decExentoIvaBs)
                        decExentoUs += ToDecimal(decParticipa * decExentoIvaUs)
                        decExentoOrg = decExentoBs

                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moCompra.MonedaId = 2 Then
                        decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                        decMontoUs = ToDecimal(decImporte)
                        decMontoOrg = decMontoUs

                        decMontoIvaOrgBs = decMontoBs - ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                        decMontoIvaOrgUs = decMontoUs - ToDecimal(decParticipa * decFacturaIvaUs)

                        decMontoIvaBs = decMontoIvaOrgBs - ToDecimal(decParticipa * decExentoIvaBs)
                        decMontoIvaUs = decMontoIvaOrgUs - ToDecimal(decParticipa * decExentoIvaUs)

                        decIvaBs += ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                        decIvaUs += ToDecimal(decParticipa * decFacturaIvaUs)
                        decIvaOrg = decIvaUs

                        decExentoBs += ToDecimal(decParticipa * decExentoIvaBs)
                        decExentoUs += ToDecimal(decParticipa * decExentoIvaUs)
                        decExentoOrg = decExentoUs

                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg
                     End If
                  End If

                  If Not CompDetCentroCostoFind(lngCompId, lngCompDetId, oRow("PlanIdAct"), 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld, oRow("CentroCostoIdAct")) Then
                     If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdAct"), "", decMontoIvaBs, decMontoIvaUs, decMontoOrg, 1, mlngSucursalId, oRow("CentroCostoIdAct"), lngCompDetId) Then
                        lngCompDetIdCre = lngCompDetId
                        lngPlanIdCreCount += 1

                        If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        CompNew = True

                        If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If
                     End If
                  Else
                     If CompDetUpdate(lngCompDetId, "", decMontoIvaBs + decMontoBsOld, decMontoIvaUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 1) Then

                        If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        CompNew = True

                        If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If
                     End If
                  End If

               ElseIf ToBool(moCompra.FacturaDif) Then 'Factura Diferida 
                  If moCompra.MonedaId = 1 Then
                     decMontoBs = ToDecimal(decImporte)
                     decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                     decMontoOrg = decMontoBs

                     decMontoIvaBs = decMontoBs - ToDecimal(decParticipa * decFacturaIvaBs)
                     decMontoIvaUs = decMontoUs - ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)
                     decIvaBs += ToDecimal(decParticipa * decFacturaIvaBs)
                     decIvaUs += ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)

                     decMontoOrgDif = decMontoIvaBs
                     decIvaOrg = decIvaBs

                     decTotalMontoBs += decMontoBs
                     decTotalMontoUs += decMontoUs
                     decTotalMontoOrg += decMontoOrg

                  ElseIf moCompra.MonedaId = 2 Then
                     decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                     decMontoUs = ToDecimal(decImporte)
                     decMontoOrg = decMontoUs

                     decMontoIvaBs = decMontoBs - ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                     decMontoIvaUs = decMontoUs - ToDecimal(decParticipa * decFacturaIvaUs)
                     decIvaBs += ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                     decIvaUs += ToDecimal(decParticipa * decFacturaIvaUs)

                     decMontoOrgDif = decMontoIvaUs
                     decIvaOrg = decIvaUs

                     decTotalMontoBs += decMontoBs
                     decTotalMontoUs += decMontoUs
                     decTotalMontoOrg += decMontoOrg
                  End If

                  If clsAppInfo.SepararExento And (decExentoIvaBs > 0) Then
                     If moCompra.MonedaId = 1 Then
                        decMontoIvaBs = decMontoIvaBs - ToDecimal(decParticipa * decExentoIvaBs)
                        decMontoIvaUs = decMontoIvaUs - ToDecimal(decParticipa * decExentoIvaUs)
                        decMontoOrgDif = decMontoIvaBs

                        decExentoBs += ToDecimal(decParticipa * decExentoIvaBs)
                        decExentoUs += ToDecimal(decParticipa * decExentoIvaUs)
                        decExentoOrg = decExentoBs
                     Else
                        decMontoIvaBs = decMontoIvaBs - ToDecimal(decParticipa * decExentoIvaBs)
                        decMontoIvaUs = decMontoIvaUs - ToDecimal(decParticipa * decExentoIvaUs)
                        decMontoOrgDif = decMontoIvaUs

                        decExentoBs += ToDecimal(decParticipa * decExentoIvaBs)
                        decExentoUs += ToDecimal(decParticipa * decExentoIvaUs)
                        decExentoOrg = decExentoUs
                     End If
                  End If

                  If Not CompDetCentroCostoFind(lngCompId, lngCompDetId, oRow("PlanIdAct"), 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld, oRow("CentroCostoIdAct")) Then
                     If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdAct"), "", decMontoIvaBs, decMontoIvaUs, decMontoOrgDif, 1, mlngSucursalId, oRow("CentroCostoIdAct"), lngCompDetId) Then
                        lngCompDetIdCre = lngCompDetId
                        lngPlanIdCreCount += 1
                        CompNew = True

                        If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        CompNew = True

                        If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                     End If
                  Else
                     If CompDetUpdate(lngCompDetId, "", decMontoIvaBs + decMontoBsOld, decMontoIvaUs + decMontoUsOld, decMontoOrgDif + decMontoOrgOld, 1) Then
                        If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        CompNew = True

                        If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If
                     End If
                  End If

               ElseIf boolRet_AsuEmp Then 'Retencion  Asume Empresa

                  If moCompra.TipoRetencionId = 1 Then   'Servicio
                     If moCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(decImporte)
                        decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                        decMontoOrg = decMontoBs

                        decMontoIvaBs = ToDecimal(decParticipa * decRetencionIUE_ITBs)
                        decMontoIvaUs = ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio)
                        decIUEBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IUE_Servicios
                        decIUEUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IUE_Servicios
                        decIUEOrg = decIUEBs

                        decITBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IT
                        decITUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IT
                        decITOrg = decITBs

                        ''decMontoOrgDif = decMontoIvaBs
                        ''decIvaOrg = decIvaBs

                        decRetencionBs += decMontoIvaBs - decMontoBs
                        decRetencionUs += decMontoIvaUs - decMontoUs
                        decRetencionOrg += decRetencionBs

                        decTotalMontoBs += decMontoIvaBs
                        decTotalMontoUs += decMontoIvaUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moCompra.MonedaId = 2 Then
                        decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                        decMontoUs = ToDecimal(decImporte)
                        decMontoOrg = decMontoUs

                        decMontoIvaBs = ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio)
                        decMontoIvaUs = ToDecimal(decParticipa * decRetencionIUE_ITUs)

                        decIUEBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IUE_Servicios
                        decIUEUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IUE_Servicios
                        decIUEOrg = decIUEUs

                        decITBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IT
                        decITUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IT
                        decITOrg = decITUs

                        ''decMontoOrgDif = decMontoIvaUs
                        ''decIvaOrg = decIvaUs

                        decRetencionBs += decMontoIvaBs - decMontoBs
                        decRetencionUs += decMontoIvaUs - decMontoUs
                        decRetencionOrg += decRetencionUs

                        decTotalMontoBs += decMontoIvaBs
                        decTotalMontoUs += decMontoIvaUs
                        decTotalMontoOrg += decMontoOrg

                     End If

                  ElseIf moCompra.TipoRetencionId = 2 Then      ''Bienes

                     If moCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(decImporte)
                        decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                        decMontoOrg = decMontoBs

                        decMontoIvaBs = ToDecimal(decParticipa * decRetencionIUE_ITBs)
                        decMontoIvaUs = ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio)
                        decIUEBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IUE_Bienes
                        decIUEUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IUE_Bienes
                        decIUEOrg = decIUEBs

                        decITBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IT
                        decITUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IT
                        decITOrg = decITBs

                        ''decMontoOrgDif = decMontoIvaBs
                        ''decIvaOrg = decIvaBs

                        decRetencionBs += decMontoIvaBs - decMontoBs
                        decRetencionUs += decMontoIvaUs - decMontoUs
                        decRetencionOrg += decRetencionBs

                        decTotalMontoBs += decMontoIvaBs
                        decTotalMontoUs += decMontoIvaUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moCompra.MonedaId = 2 Then
                        decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                        decMontoUs = ToDecimal(decImporte)
                        decMontoOrg = decMontoUs

                        decMontoIvaBs = ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio)
                        decMontoIvaUs = ToDecimal(decParticipa * decRetencionIUE_ITUs)

                        decIUEBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IUE_Bienes
                        decIUEUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IUE_Bienes
                        decIUEOrg = decIUEUs

                        decITBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IT
                        decITUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IT
                        decITOrg = decITUs

                        ''decMontoOrgDif = decMontoIvaUs
                        ''decIvaOrg = decIvaUs

                        decRetencionBs += decMontoIvaBs - decMontoBs
                        decRetencionUs += decMontoIvaUs - decMontoUs
                        decRetencionOrg += decRetencionUs

                        decTotalMontoBs += decMontoIvaBs
                        decTotalMontoUs += decMontoIvaUs
                        decTotalMontoOrg += decMontoOrg
                     End If

                  ElseIf moCompra.TipoRetencionId = 3 Then      ''Alquiler

                     If moCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(decImporte)
                        decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                        decMontoOrg = decMontoBs

                        decMontoIvaBs = ToDecimal(decParticipa * decRetencionIUE_ITBs)
                        decMontoIvaUs = ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio)
                        decIUEBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IVA
                        decIUEUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IVA
                        decIUEOrg = decIUEBs

                        decITBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IT
                        decITUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IT
                        decITOrg = decITBs

                        ''decMontoOrgDif = decMontoIvaBs
                        ''decIvaOrg = decIvaBs

                        decRetencionBs += decMontoIvaBs - decMontoBs
                        decRetencionUs += decMontoIvaUs - decMontoUs
                        decRetencionOrg += decRetencionBs

                        decTotalMontoBs += decMontoIvaBs
                        decTotalMontoUs += decMontoIvaUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moCompra.MonedaId = 2 Then
                        decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                        decMontoUs = ToDecimal(decImporte)
                        decMontoOrg = decMontoUs

                        decMontoIvaBs = ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio)
                        decMontoIvaUs = ToDecimal(decParticipa * decRetencionIUE_ITUs)

                        decIUEBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IVA
                        decIUEUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IVA
                        decIUEOrg = decIUEUs

                        decITBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IT
                        decITUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IT
                        decITOrg = decITUs


                        ''decMontoOrgDif = decMontoIvaUs
                        ''decIvaOrg = decIvaUs

                        decRetencionBs += decMontoIvaBs - decMontoBs
                        decRetencionUs += decMontoIvaUs - decMontoUs
                        decRetencionOrg += decRetencionUs

                        decTotalMontoBs += decMontoIvaBs
                        decTotalMontoUs += decMontoIvaUs
                        decTotalMontoOrg += decMontoOrg
                     End If
                  End If


                  If Not CompDetCentroCostoFind(lngCompId, lngCompDetId, oRow("PlanIdAct"), 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld, oRow("CentroCostoIdAct")) Then
                     If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdAct"), "", decMontoIvaBs, decMontoIvaUs, decMontoOrg, 1, mlngSucursalId, oRow("CentroCostoIdAct"), lngCompDetId, , moCompra.TipoRetencionId) Then
                        lngCompDetIdCre = lngCompDetId
                        lngPlanIdCreCount += 1
                        CompNew = True

                        If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        CompNew = True

                        If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                     End If
                  Else
                     If CompDetUpdate(lngCompDetId, "", decMontoIvaBs + decMontoBsOld, decMontoIvaUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 1) Then
                        If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If

                        CompNew = True

                        If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If
                     End If
                  End If

               End If
            Next

            decGralMontoBs += decTotalMontoBs
            decGralMontoUs += decTotalMontoUs

            decTotalMontoBs = decTotalMontoBs - decRetencionBs
            decTotalMontoUs = decTotalMontoUs - decRetencionUs


            If moCompra.MontoAnt > 0 Then 'Anticipos de Proveedores
               Dim lngPlanAddIdAct As Long
               Dim lngPlanIdAct As Long = ProveedorPlanIdActFind(moCompra.ProveedorId, lngPlanAddIdAct)

               If moCompra.MonedaId = 1 Then
                  decMontoBs = moCompra.MontoAnt
                  decMontoUs = ToDecimal(moCompra.MontoAnt / moCompra.TipoCambio)
                  decMontoOrg = decMontoBs
                  decTotalMontoBs -= decMontoBs
                  decTotalMontoUs -= decMontoUs
                  decTotalMontoOrg -= decMontoOrg

               ElseIf moCompra.MonedaId = 2 Then
                  decMontoBs = ToDecimal(moCompra.MontoAnt * moCompra.TipoCambio)
                  decMontoUs = moCompra.MontoAnt
                  decMontoOrg = decMontoUs
                  decTotalMontoBs -= decMontoBs
                  decTotalMontoUs -= decMontoUs
                  decTotalMontoOrg -= decMontoOrg

               End If


               If moCompra.TipoRetencionId = 0 Then       '' Sin Retencion = Normal

                  If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                     If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                           CompNew = True
                        End If
                     End If
                  End If

               ElseIf moCompra.TipoRetencionId > 0 Then     '' Con Retencion asume Empresa 

                  If boolRet_AsuEmp Then
                     If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                        If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If
                     End If

                  ElseIf (Not boolRet_AsuEmp) Then  '' Con Retencion asume Provedor 

                     If (decTotalMontoBs > 0) And (decTotalMontoUs > 0) Then 'Solo con Retenciones
                        'Aplicando Retencin a la cuenta del anticipo asume Proveedor y cuando todo se haya cancelado una parte con el Anticipo
                        If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId, ) Then
                           If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                 CompNew = True
                              End If
                           End If
                        End If

                     ElseIf ((decTotalMontoBs = 0) Or (decTotalMontoUs = 0)) Then 'Solo con Retenciones
                        'Aplicando Retencin a la cuenta del anticipo asume Proveedor y cuando todo se haya cancelado totalmente con el Anticipo
                        ''Descargado total con Anticipo
                        If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId, , moCompra.TipoRetencionId) Then
                           If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                 CompNew = True
                              End If
                           End If
                        End If
                     End If
                  End If
               End If

            End If


            If (decTotalMontoBs > 0) And (decTotalMontoUs > 0) Then 'Contra Cuenta

               If moCompra.TipoRetencionId = 0 Then       '' Sin Retencion
                  If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                     If mlngPlanAddId <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 2, moCompra.SucursalId) Then
                           CompNew = True
                        End If
                     End If
                  End If

               ElseIf moCompra.TipoRetencionId > 0 Then     '' Con Retencion

                  If boolRet_AsuEmp Then      '' Con Retencion asume Empresa
                     If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                        If mlngPlanAddId <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 2, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If
                     End If

                  ElseIf Not boolRet_AsuEmp Then 'Solo con Retenciones Asume Proveedor

                     If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId, , moCompra.TipoRetencionId) Then
                        If mlngPlanAddId <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 2, moCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If
                     End If
                  End If
               End If

            ElseIf (decTotalMontoBs < 0) And (decTotalMontoUs < 0) Then

               decTotalMontoBs = Math.Abs(decTotalMontoBs)
               decTotalMontoUs = Math.Abs(decTotalMontoUs)
               decTotalMontoOrg = Math.Abs(decTotalMontoOrg)

               decGralMontoBs += decTotalMontoBs
               decGralMontoUs += decTotalMontoUs

               If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 1, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                  If mlngPlanAddId <> 0 Then  'Analitico Adicional
                     If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 1, moCompra.SucursalId) Then
                        CompNew = True
                     End If
                  End If
               End If
            End If

            If moCompra.FacturaId > 0 Then 'Cuenta de Credito Fiscal
               If (decIvaBs > 0) Or (decIvaUs > 0) Then
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreId, "Factura Nro. " & ToStr(lngFacturaNro), decIvaBs, decIvaUs, decIvaOrg, 1, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompNew = True
                  End If
               End If

               If FacturaUpdate(moCompra.FacturaId, lngTipoCompId, lngCompId, 0) Then 'Ponerle CompId a la Factura
                  CompNew = True
               End If

               If (decExentoBs > 0) Or (decExentoUs > 0) Then
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanExentoId, "Factura Nro. " & ToStr(lngFacturaNro), decExentoBs, decExentoUs, decExentoOrg, 1, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompNew = True
                  End If
               End If

            ElseIf ToBool(moCompra.FacturaDif) Then 'Factura Diferida 
               If (decIvaBs > 0) Or (decIvaUs > 0) Then
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreDifId, "", decIvaBs, decIvaUs, decIvaOrg, 1, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompNew = True
                  End If
               End If

               If (decExentoBs > 0) Or (decExentoUs > 0) Then
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanExentoId, "", decExentoBs, decExentoUs, decExentoOrg, 1, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompNew = True
                  End If
               End If

               '' Cuentas de Retenciones
            ElseIf (moCompra.TipoRetencionId = 1) Or (moCompra.TipoRetencionId = 4) Then 'Retencion    Servicio
               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITRetId, "", decITBs, decITUs, decITOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                  CompNew = True
               End If

               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanIUERetSerId, "", decIUEBs, decIUEUs, decIUEOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                  CompNew = True
               End If

            ElseIf (moCompra.TipoRetencionId = 2) Or (moCompra.TipoRetencionId = 5) Then 'Retencion    Bienes
               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITRetId, "", decITBs, decITUs, decITOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                  CompNew = True
               End If

               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanIUERetBieId, "", decIUEBs, decIUEUs, decIUEOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                  CompNew = True
               End If

            ElseIf (moCompra.TipoRetencionId = 3) Or (moCompra.TipoRetencionId = 6) Then 'Retencion    Alquiler
               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITRetId, "", decITBs, decITUs, decITOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                  CompNew = True
               End If

               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreRetId, "", decIUEBs, decIUEUs, decIUEOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                  CompNew = True
               End If
            End If

            If (decGralMontoBs > 0) And (decGralMontoUs > 0) Then 'Contra Cuenta
               If CompUpdate(lngCompId, decGralMontoBs, decGralMontoUs, "") Then
                  CompNew = True
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function RetencionBsUsCalc(ByRef boolAsuEmp As Boolean, ByRef decRetencionIUE_ITBs As Decimal, _
                                    ByRef decRetencionIUE_ITUs As Decimal, ByRef decIUEBs As Decimal, _
                                    ByRef decIUEUs As Decimal, ByRef decIUEOrg As Decimal, _
                                    ByRef decITBs As Decimal, ByRef decITUs As Decimal, ByRef decITOrg As Decimal, _
                                    ByRef decRetencionBs As Decimal, ByRef decRetencionUs As Decimal, _
                                    ByRef decRetencionOrg As Decimal) As Boolean

      Dim decPorcentajeRet As Decimal

      If moCompra.TipoRetencionId = 1 Then
         'Por Servicios Asume Empresa

         decPorcentajeRet = 1 - clsAppInfo.IUE_Servicios - clsAppInfo.IT '' 0.845
         boolAsuEmp = True

         If moCompra.MonedaId = 1 Then
            decRetencionIUE_ITBs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) / decPorcentajeRet)

         ElseIf moCompra.MonedaId = 2 Then
            decRetencionIUE_ITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)
         End If

      ElseIf moCompra.TipoRetencionId = 2 Then
         'Por Bienes Asume Empresa

         decPorcentajeRet = 1 - clsAppInfo.IUE_Bienes - clsAppInfo.IT '' 0.92
         boolAsuEmp = True

         If moCompra.MonedaId = 1 Then
            decRetencionIUE_ITBs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) / decPorcentajeRet)

         ElseIf moCompra.MonedaId = 2 Then
            decRetencionIUE_ITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)
         End If

      ElseIf moCompra.TipoRetencionId = 3 Then
         'Por Alquiler Asume Empresa

         decPorcentajeRet = 1 - clsAppInfo.IT - clsAppInfo.IVA '' 0.84
         boolAsuEmp = True

         If moCompra.MonedaId = 1 Then
            decRetencionIUE_ITBs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) / decPorcentajeRet)

         ElseIf moCompra.MonedaId = 2 Then
            decRetencionIUE_ITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)
         End If

      ElseIf moCompra.TipoRetencionId = 4 Then
         'Por Servicios Asume Provedor
         boolAsuEmp = False
         If moCompra.MonedaId = 1 Then

            decIUEBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Servicios)
            decIUEUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IUE_Servicios)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            decRetencionIUE_ITBs = decIUEBs + decITBs
            decRetencionIUE_ITUs = decIUEUs + decITUs

            decRetencionBs = decRetencionIUE_ITBs
            decRetencionUs = decRetencionIUE_ITUs
            decRetencionOrg = decRetencionBs

         ElseIf moCompra.MonedaId = 2 Then

            decIUEBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IUE_Servicios)
            decIUEUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Servicios)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            decRetencionIUE_ITBs = decIUEBs + decITBs
            decRetencionIUE_ITUs = decIUEUs + decITUs

            decRetencionBs = decRetencionIUE_ITBs
            decRetencionUs = decRetencionIUE_ITUs
            decRetencionOrg = decRetencionUs
         End If

      ElseIf moCompra.TipoRetencionId = 5 Then
         'Por Bienes Asume Provedor
         boolAsuEmp = False
         If moCompra.MonedaId = 1 Then

            decIUEBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Bienes)
            decIUEUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IUE_Bienes)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            decRetencionIUE_ITBs = decIUEBs + decITBs
            decRetencionIUE_ITUs = decIUEUs + decITUs

            decRetencionBs = decRetencionIUE_ITBs
            decRetencionUs = decRetencionIUE_ITUs
            decRetencionOrg = decRetencionBs

         ElseIf moCompra.MonedaId = 2 Then

            decIUEBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IUE_Bienes)
            decIUEUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Bienes)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            decRetencionIUE_ITBs = decIUEBs + decITBs
            decRetencionIUE_ITUs = decIUEUs + decITUs

            decRetencionBs = decRetencionIUE_ITBs
            decRetencionUs = decRetencionIUE_ITUs
            decRetencionOrg = decRetencionUs
         End If

      ElseIf moCompra.TipoRetencionId = 6 Then
         'Por Bienes Asume Provedor
         boolAsuEmp = False
         If moCompra.MonedaId = 1 Then

            decIUEBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IVA)
            decIUEUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IVA)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            decRetencionIUE_ITBs = decIUEBs + decITBs
            decRetencionIUE_ITUs = decIUEUs + decITUs

            decRetencionBs = decRetencionIUE_ITBs
            decRetencionUs = decRetencionIUE_ITUs
            decRetencionOrg = decRetencionBs

         ElseIf moCompra.MonedaId = 2 Then

            decIUEBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IVA)
            decIUEUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IVA)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            decRetencionIUE_ITBs = decIUEBs + decITBs
            decRetencionIUE_ITUs = decIUEUs + decITUs

            decRetencionBs = decRetencionIUE_ITBs
            decRetencionUs = decRetencionIUE_ITUs
            decRetencionOrg = decRetencionUs
         End If
      End If

      RetencionBsUsCalc = boolAsuEmp

   End Function

   Private Function CompEdit(ByVal lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      Dim oRow As DataRow
      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal
      Dim decMontoOrgDif As Decimal
      Dim decMontoIvaBs As Decimal
      Dim decMontoIvaUs As Decimal
      Dim decIvaBs As Decimal = 0
      Dim decIvaUs As Decimal = 0
      Dim decIvaOrg As Decimal = 0
      Dim decFacturaIvaBs As Decimal = 0
      Dim decFacturaIvaUs As Decimal = 0
      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0
      'Dim lngCompId As Long
      Dim lngCompDetId As Long

      Dim decTotalMontoBs As Decimal = 0
      Dim decTotalMontoUs As Decimal = 0
      Dim decTotalMontoOrg As Decimal = 0

      Dim decGralMontoBs As Decimal = 0
      Dim decGralMontoUs As Decimal = 0

      Dim decImporte As Decimal = 0
      Dim decParticipa As Decimal = 0

      Dim lngCompDetIdCre As Long
      Dim lngPlanIdCreCount As Long = 0
      Dim decRecargoNoApli As Decimal = 0
      Dim decDescuentoNoApli As Decimal = 0

      Dim decRetencionIUE_ITBs As Decimal = 0
      Dim decRetencionIUE_ITUs As Decimal = 0

      Dim decIUEBs As Decimal = 0
      Dim decIUEUs As Decimal = 0
      Dim decIUEOrg As Decimal = 0

      Dim decITBs As Decimal = 0
      Dim decITUs As Decimal = 0
      Dim decITOrg As Decimal = 0

      Dim decRetencionBs As Decimal = 0
      Dim decRetencionUs As Decimal = 0
      Dim decRetencionOrg As Decimal = 0

      Dim decExentoIvaBs As Decimal = 0
      Dim decExentoIvaUs As Decimal = 0

      Dim decExentoBs As Decimal = 0
      Dim decExentoUs As Decimal = 0
      Dim decExentoOrg As Decimal = 0

      Dim boolRet_AsuEmp As Boolean = False      'Retencion Asume Proveedor entonces no afecta inventario
      Dim lngFacturaNro As Long = 0

      CompEdit = True

      Try
         mdatFecha = dtpFecha.Value

         'If CompFind(moCompra.TipoCompId, moCompra.CompNro, moCompra.SucursalId, lngCompId) Then
         If isCompFind(lngCompId, lngTipoCompId, lngCompNro) Then
            If CompDetDeleteAll(lngCompId) Then 'Elimina el detalle del Comprobante
               '' Call grdMainPlanId()

               If moCompra.FacturaId > 0 Then
                  decFacturaIvaBs = FacturaIvaBsFind(moCompra.FacturaId, decFacturaIvaUs, lngFacturaNro, decExentoIvaBs, decExentoIvaUs)

               ElseIf ToBool(moCompra.FacturaDif) Then 'Factura Diferida 
                  If moCompra.MonedaId = 1 Then
                     decFacturaIvaBs = ToDecimal((moCompra.MontoBru - moCompra.FactDifExento) * clsAppInfo.IVA)
                     decFacturaIvaUs = ToDecimal(((moCompra.MontoBru - moCompra.FactDifExento) / moCompra.TipoCambio) * clsAppInfo.IVA)

                     decExentoIvaBs = ToDecimal(moCompra.FactDifExento * clsAppInfo.IVA)
                     decExentoIvaUs = ToDecimal((moCompra.FactDifExento / moCompra.TipoCambio) * clsAppInfo.IVA)
                  ElseIf moCompra.MonedaId = 2 Then
                     decFacturaIvaBs = ToDecimal(((moCompra.MontoBru - moCompra.FactDifExento) * moCompra.TipoCambio) * clsAppInfo.IVA)
                     decFacturaIvaUs = ToDecimal((moCompra.MontoBru - moCompra.FactDifExento) * clsAppInfo.IVA)

                     decExentoIvaBs = ToDecimal((moCompra.FactDifExento * moCompra.TipoCambio) * clsAppInfo.IVA)
                     decExentoIvaUs = ToDecimal(moCompra.FactDifExento * clsAppInfo.IVA)
                  End If


               ElseIf moCompra.TipoRetencionId > 0 Then 'Retencion

                  RetencionBsUsCalc(boolRet_AsuEmp, decRetencionIUE_ITBs, decRetencionIUE_ITUs, decIUEBs, decIUEUs, decIUEOrg, _
                                    decITBs, decITUs, decITOrg, decRetencionBs, decRetencionUs, decRetencionOrg)
               End If


               For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
                  decParticipa = oRow("ImporteBru") / moCompra.MontoBru
                  decImporte = oRow("ImporteBru") '+ (decRecargoApli * decParticipa) - (decDescuentoApli * decParticipa)

                  If (moCompra.FacturaId = 0) And (Not ToBool(moCompra.FacturaDif)) And (Not boolRet_AsuEmp) Then 'Compra Sin Factura   y sin Retencion  o Asume Prov
                     If moCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(decImporte)
                        decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                        decMontoOrg = decMontoBs
                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moCompra.MonedaId = 2 Then
                        decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                        decMontoUs = ToDecimal(decImporte)
                        decMontoOrg = decMontoUs
                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg
                     End If

                     If Not CompDetCentroCostoFind(lngCompId, lngCompDetId, oRow("PlanIdAct"), 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld, oRow("CentroCostoIdAct")) Then
                        If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdAct"), "", decMontoBs, decMontoUs, decMontoOrg, 1, mlngSucursalId, oRow("CentroCostoIdAct"), lngCompDetId) Then
                           If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoBs, decMontoUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If

                           CompEdit = True

                           If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoBs, decMontoUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     Else
                        If CompDetUpdate(lngCompDetId, "", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 1) Then
                           If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoBs, decMontoUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If

                           CompEdit = True

                           If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoBs, decMontoUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     End If

                  ElseIf moCompra.FacturaId > 0 Then 'Compra Con Factura
                     If moCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(decImporte)
                        decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                        decMontoOrg = decMontoBs

                        decMontoIvaBs = decMontoBs - ToDecimal(decParticipa * decFacturaIvaBs)
                        decMontoIvaUs = decMontoUs - ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)
                        decIvaBs += ToDecimal(decParticipa * decFacturaIvaBs)
                        decIvaUs += ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)

                        decIvaOrg = decIvaBs

                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moCompra.MonedaId = 2 Then
                        decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                        decMontoUs = ToDecimal(decImporte)
                        decMontoOrg = decMontoUs

                        decMontoIvaBs = decMontoBs - ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                        decMontoIvaUs = decMontoUs - ToDecimal(decParticipa * decFacturaIvaUs)
                        decIvaBs += ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                        decIvaUs += ToDecimal(decParticipa * decFacturaIvaUs)

                        decIvaOrg = decIvaUs

                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg
                     End If

                     If clsAppInfo.SepararExento And (decExentoIvaBs > 0) Then
                        If moCompra.MonedaId = 1 Then
                           decMontoIvaBs = decMontoIvaBs - ToDecimal(decParticipa * decExentoIvaBs)
                           decMontoIvaUs = decMontoIvaUs - ToDecimal(decParticipa * decExentoIvaUs)

                           decExentoBs += ToDecimal(decParticipa * decExentoIvaBs)
                           decExentoUs += ToDecimal(decParticipa * decExentoIvaUs)
                           decExentoOrg = decExentoBs
                        Else
                           decMontoIvaBs = decMontoIvaBs - ToDecimal(decParticipa * decExentoIvaBs)
                           decMontoIvaUs = decMontoIvaUs - ToDecimal(decParticipa * decExentoIvaUs)
                           decMontoOrgDif = decMontoIvaUs

                           decExentoBs += ToDecimal(decParticipa * decExentoIvaBs)
                           decExentoUs += ToDecimal(decParticipa * decExentoIvaUs)
                           decExentoOrg = decExentoUs
                        End If
                     End If

                     If Not CompDetCentroCostoFind(lngCompId, lngCompDetId, oRow("PlanIdAct"), 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld, oRow("CentroCostoIdAct")) Then
                        If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdAct"), "", decMontoIvaBs, decMontoIvaUs, decMontoOrg, 1, mlngSucursalId, oRow("CentroCostoIdAct"), lngCompDetId) Then
                           lngCompDetIdCre = lngCompDetId
                           lngPlanIdCreCount += 1
                           If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If

                           CompEdit = True

                           If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     Else
                        If CompDetUpdate(lngCompDetId, "", decMontoIvaBs + decMontoBsOld, decMontoIvaUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 1) Then
                           If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If

                           CompEdit = True

                           If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     End If

                  ElseIf ToBool(moCompra.FacturaDif) Then 'Factura Diferida  
                     If moCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(decImporte)
                        decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                        decMontoOrg = decMontoBs

                        decMontoIvaBs = decMontoBs - ToDecimal(decParticipa * decFacturaIvaBs)
                        decMontoIvaUs = decMontoUs - ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)
                        decIvaBs += ToDecimal(decParticipa * decFacturaIvaBs)
                        decIvaUs += ToDecimal((decParticipa * decFacturaIvaBs) / moCompra.TipoCambio)

                        decMontoOrgDif = decMontoIvaBs
                        decIvaOrg = decIvaBs

                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moCompra.MonedaId = 2 Then
                        decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                        decMontoUs = ToDecimal(decImporte)
                        decMontoOrg = decMontoUs

                        decMontoIvaBs = decMontoBs - ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                        decMontoIvaUs = decMontoUs - ToDecimal(decParticipa * decFacturaIvaUs)
                        decIvaBs += ToDecimal((decParticipa * decFacturaIvaUs) * moCompra.TipoCambio)
                        decIvaUs += ToDecimal(decParticipa * decFacturaIvaUs)

                        decMontoOrgDif = decMontoIvaUs
                        decIvaOrg = decIvaUs

                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg
                     End If

                     If clsAppInfo.SepararExento And (decExentoIvaBs > 0) Then
                        If moCompra.MonedaId = 1 Then
                           decMontoIvaBs = decMontoIvaBs - ToDecimal(decParticipa * decExentoIvaBs)
                           decMontoIvaUs = decMontoIvaUs - ToDecimal(decParticipa * decExentoIvaUs)
                           decMontoOrgDif = decMontoIvaBs

                           decExentoBs += ToDecimal(decParticipa * decExentoIvaBs)
                           decExentoUs += ToDecimal(decParticipa * decExentoIvaUs)
                           decExentoOrg = decExentoBs
                        Else
                           decMontoIvaBs = decMontoIvaBs - ToDecimal(decParticipa * decExentoIvaBs)
                           decMontoIvaUs = decMontoIvaUs - ToDecimal(decParticipa * decExentoIvaUs)
                           decMontoOrgDif = decMontoIvaUs

                           decExentoBs += ToDecimal(decParticipa * decExentoIvaBs)
                           decExentoUs += ToDecimal(decParticipa * decExentoIvaUs)
                           decExentoOrg = decExentoUs
                        End If
                     End If

                     If Not CompDetCentroCostoFind(lngCompId, lngCompDetId, oRow("PlanIdAct"), 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld, oRow("CentroCostoIdAct")) Then
                        If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdAct"), "", decMontoIvaBs, decMontoIvaUs, decMontoOrgDif, 1, mlngSucursalId, oRow("CentroCostoIdAct"), lngCompDetId) Then
                           lngCompDetIdCre = lngCompDetId
                           If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If

                           CompEdit = True

                           If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     Else
                        If CompDetUpdate(lngCompDetId, "", decMontoIvaBs + decMontoBsOld, decMontoIvaUs + decMontoUsOld, decMontoOrgDif + decMontoOrgOld, 1) Then
                           If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If

                           CompEdit = True

                           If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     End If

                  ElseIf boolRet_AsuEmp Then 'Retencion  Asume Empresa

                     If moCompra.TipoRetencionId = 1 Then   'Servicio
                        If moCompra.MonedaId = 1 Then
                           decMontoBs = ToDecimal(decImporte)
                           decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                           decMontoOrg = decMontoBs

                           decMontoIvaBs = ToDecimal(decParticipa * decRetencionIUE_ITBs)
                           decMontoIvaUs = ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio)
                           decIUEBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IUE_Servicios
                           decIUEUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IUE_Servicios
                           decIUEOrg = decIUEBs

                           decITBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IT
                           decITUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IT
                           decITOrg = decITBs

                           ''decMontoOrgDif = decMontoIvaBs
                           ''decIvaOrg = decIvaBs

                           decRetencionBs += decMontoIvaBs - decMontoBs
                           decRetencionUs += decMontoIvaUs - decMontoUs
                           decRetencionOrg += decRetencionBs

                           decTotalMontoBs += decMontoIvaBs
                           decTotalMontoUs += decMontoIvaUs
                           decTotalMontoOrg += decMontoOrg

                        ElseIf moCompra.MonedaId = 2 Then
                           decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                           decMontoUs = ToDecimal(decImporte)
                           decMontoOrg = decMontoUs

                           decMontoIvaBs = ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio)
                           decMontoIvaUs = ToDecimal(decParticipa * decRetencionIUE_ITUs)

                           decIUEBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IUE_Servicios
                           decIUEUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IUE_Servicios
                           decIUEOrg = decIUEUs

                           decITBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IT
                           decITUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IT
                           decITOrg = decITUs


                           ''decMontoOrgDif = decMontoIvaUs
                           ''decIvaOrg = decIvaUs

                           decRetencionBs += decMontoIvaBs - decMontoBs
                           decRetencionUs += decMontoIvaUs - decMontoUs
                           decRetencionOrg += decRetencionUs

                           decTotalMontoBs += decMontoIvaBs
                           decTotalMontoUs += decMontoIvaUs
                           decTotalMontoOrg += decMontoOrg
                        End If

                     ElseIf moCompra.TipoRetencionId = 2 Then      ''Bienes

                        If moCompra.MonedaId = 1 Then
                           decMontoBs = ToDecimal(decImporte)
                           decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                           decMontoOrg = decMontoBs

                           decMontoIvaBs = ToDecimal(decParticipa * decRetencionIUE_ITBs)
                           decMontoIvaUs = ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio)
                           decIUEBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IUE_Bienes
                           decIUEUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IUE_Bienes
                           decIUEOrg = decIUEBs

                           decITBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IT
                           decITUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IT
                           decITOrg = decITBs

                           ''decMontoOrgDif = decMontoIvaBs
                           ''decIvaOrg = decIvaBs

                           decRetencionBs += decMontoIvaBs - decMontoBs
                           decRetencionUs += decMontoIvaUs - decMontoUs
                           decRetencionOrg += decRetencionBs

                           decTotalMontoBs += decMontoIvaBs
                           decTotalMontoUs += decMontoIvaUs
                           decTotalMontoOrg += decMontoOrg

                        ElseIf moCompra.MonedaId = 2 Then
                           decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                           decMontoUs = ToDecimal(decImporte)
                           decMontoOrg = decMontoUs

                           decMontoIvaBs = ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio)
                           decMontoIvaUs = ToDecimal(decParticipa * decRetencionIUE_ITUs)

                           decIUEBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IUE_Bienes
                           decIUEUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IUE_Bienes
                           decIUEOrg = decIUEUs

                           decITBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IT
                           decITUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IT
                           decITOrg = decITUs


                           ''decMontoOrgDif = decMontoIvaUs
                           ''decIvaOrg = decIvaUs

                           decRetencionBs += decMontoIvaBs - decMontoBs
                           decRetencionUs += decMontoIvaUs - decMontoUs
                           decRetencionOrg += decRetencionUs

                           decTotalMontoBs += decMontoIvaBs
                           decTotalMontoUs += decMontoIvaUs
                           decTotalMontoOrg += decMontoOrg
                        End If

                     ElseIf moCompra.TipoRetencionId = 3 Then      ''Alquiler

                        If moCompra.MonedaId = 1 Then
                           decMontoBs = ToDecimal(decImporte)
                           decMontoUs = ToDecimal(decImporte / moCompra.TipoCambio)
                           decMontoOrg = decMontoBs

                           decMontoIvaBs = ToDecimal(decParticipa * decRetencionIUE_ITBs)
                           decMontoIvaUs = ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio)
                           decIUEBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IVA
                           decIUEUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IVA
                           decIUEOrg = decIUEBs

                           decITBs += ToDecimal(decParticipa * decRetencionIUE_ITBs) * clsAppInfo.IT
                           decITUs += ToDecimal((decParticipa * decRetencionIUE_ITBs) / moCompra.TipoCambio) * clsAppInfo.IT
                           decITOrg = decITBs

                           ''decMontoOrgDif = decMontoIvaBs
                           ''decIvaOrg = decIvaBs

                           decRetencionBs += decMontoIvaBs - decMontoBs
                           decRetencionUs += decMontoIvaUs - decMontoUs
                           decRetencionOrg += decRetencionBs

                           decTotalMontoBs += decMontoIvaBs
                           decTotalMontoUs += decMontoIvaUs
                           decTotalMontoOrg += decMontoOrg

                        ElseIf moCompra.MonedaId = 2 Then
                           decMontoBs = ToDecimal(decImporte * moCompra.TipoCambio)
                           decMontoUs = ToDecimal(decImporte)
                           decMontoOrg = decMontoUs

                           decMontoIvaBs = ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio)
                           decMontoIvaUs = ToDecimal(decParticipa * decRetencionIUE_ITUs)

                           decIUEBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IVA
                           decIUEUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IVA
                           decIUEOrg = decIUEUs

                           decITBs += ToDecimal((decParticipa * decRetencionIUE_ITUs) * moCompra.TipoCambio) * clsAppInfo.IT
                           decITUs += ToDecimal(decParticipa * decRetencionIUE_ITUs) * clsAppInfo.IT
                           decITOrg = decITUs

                           ''decMontoOrgDif = decMontoIvaUs
                           ''decIvaOrg = decIvaUs

                           decRetencionBs += decMontoIvaBs - decMontoBs
                           decRetencionUs += decMontoIvaUs - decMontoUs
                           decRetencionOrg += decRetencionUs

                           decTotalMontoBs += decMontoIvaBs
                           decTotalMontoUs += decMontoIvaUs
                           decTotalMontoOrg += decMontoOrg
                        End If
                     End If

                     If Not CompDetCentroCostoFind(lngCompId, lngCompDetId, oRow("PlanIdAct"), 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld, oRow("CentroCostoIdAct")) Then
                        If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdAct"), "", decMontoIvaBs, decMontoIvaUs, decMontoOrg, 1, mlngSucursalId, oRow("CentroCostoIdAct"), lngCompDetId, , moCompra.TipoRetencionId) Then
                           lngCompDetIdCre = lngCompDetId
                           lngPlanIdCreCount += 1
                           CompEdit = True

                           If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If

                           CompEdit = True

                           If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If

                        End If
                     Else
                        If CompDetUpdate(lngCompDetId, "", decMontoIvaBs + decMontoBsOld, decMontoIvaUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 1) Then
                           If oRow("PlanAddIdAct") <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), oRow("PlanAddIdAct"), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If

                           CompEdit = True

                           If oRow("CentroCostoDetIdAct") <> 0 Then  'Actividad
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     End If

                  End If
               Next

               decGralMontoBs += decTotalMontoBs
               decGralMontoUs += decTotalMontoUs

               decTotalMontoBs = decTotalMontoBs - decRetencionBs
               decTotalMontoUs = decTotalMontoUs - decRetencionUs
               '' decTotalMontoUs = decTotalMontoOrg - decRetencionOrg

               If moCompra.MontoAnt > 0 Then 'Anticipos de Proveedores
                  Dim lngPlanAddIdAct As Long
                  Dim lngPlanIdAct As Long = ProveedorPlanIdActFind(moCompra.ProveedorId, lngPlanAddIdAct)

                  If moCompra.MonedaId = 1 Then
                     decMontoBs = moCompra.MontoAnt
                     decMontoUs = ToDecimal(moCompra.MontoAnt / moCompra.TipoCambio)
                     decMontoOrg = decMontoBs
                     decTotalMontoBs -= decMontoBs
                     decTotalMontoUs -= decMontoUs
                     decTotalMontoOrg -= decMontoOrg

                  ElseIf moCompra.MonedaId = 2 Then
                     decMontoBs = ToDecimal(moCompra.MontoAnt * moCompra.TipoCambio)
                     decMontoUs = moCompra.MontoAnt
                     decMontoOrg = decMontoUs
                     decTotalMontoBs -= decMontoBs
                     decTotalMontoUs -= decMontoUs
                     decTotalMontoOrg -= decMontoOrg
                  End If

                  ''If CompDetAdd(moCompra.TipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, , lngCompDetId) Then
                  ''   If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                  ''      If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2) Then
                  ''         CompEdit = True
                  ''      End If
                  ''   End If
                  ''End If

                  If moCompra.TipoRetencionId = 0 Then       '' Sin Retencion = Normal

                     If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                        If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                              CompEdit = True
                           End If
                        End If
                     End If

                  ElseIf moCompra.TipoRetencionId > 0 Then     '' Con Retencion asume Empresa 

                     If boolRet_AsuEmp Then
                        If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                           If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If

                     ElseIf (Not boolRet_AsuEmp) Then  '' Con Retencion asume Provedor 

                        If (decTotalMontoBs > 0) And (decTotalMontoUs > 0) Then 'Solo con Retenciones
                           'Aplicando Retencin a la cuenta del anticipo asume Proveedor y cuando todo se haya cancelado una parte con el Anticipo
                           If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId, ) Then
                              If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                                 If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                    CompEdit = True
                                 End If
                              End If
                           End If

                        ElseIf ((decTotalMontoBs = 0) Or (decTotalMontoUs = 0)) Then 'Solo con Retenciones
                           'Aplicando Retencin a la cuenta del anticipo asume Proveedor y cuando todo se haya cancelado totalmente con el Anticipo
                           ''Descargado total con Anticipo
                           If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId, , moCompra.TipoRetencionId) Then
                              If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                                 If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                    CompEdit = True
                                 End If
                              End If
                           End If
                        End If
                     End If
                  End If

               End If

               If (decTotalMontoBs > 0) And (decTotalMontoUs > 0) Then 'Contra Cuenta
                  ''If CompDetAdd(moCompra.TipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 2, mlngSucursalId, , lngCompDetId) Then
                  ''   If mlngPlanAddId <> 0 Then  'Analitico Adicional
                  ''      If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 2) Then
                  ''         CompEdit = True
                  ''      End If
                  ''   End If
                  ''End If

                  If moCompra.TipoRetencionId = 0 Then       '' Sin Retencion
                     If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                        If mlngPlanAddId <> 0 Then  'Analitico Adicional
                           If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 2, moCompra.SucursalId) Then
                              CompEdit = True
                           End If
                        End If
                     End If

                  ElseIf moCompra.TipoRetencionId > 0 Then     '' Con Retencion

                     If boolRet_AsuEmp Then      '' Con Retencion asume Empresa
                        If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                           If mlngPlanAddId <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 2, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If

                     ElseIf Not boolRet_AsuEmp Then 'Solo con Retenciones Asume Proveedor

                        If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId, , moCompra.TipoRetencionId) Then
                           If mlngPlanAddId <> 0 Then  'Analitico Adicional
                              If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 2, moCompra.SucursalId) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     End If
                  End If

               ElseIf (decTotalMontoBs < 0) And (decTotalMontoUs < 0) Then
                  decTotalMontoBs = Math.Abs(decTotalMontoBs)
                  decTotalMontoUs = Math.Abs(decTotalMontoUs)
                  decTotalMontoOrg = Math.Abs(decTotalMontoOrg)

                  decGralMontoBs += decTotalMontoBs
                  decGralMontoUs += decTotalMontoUs

                  If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 1, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                     If mlngPlanAddId <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 1, moCompra.SucursalId) Then
                           CompEdit = True
                        End If
                     End If
                  End If
               End If

               If moCompra.FacturaId <> 0 Then 'Cuenta de Credito Fiscal
                  If (decIvaBs > 0) Or (decIvaUs > 0) Then
                     If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreId, "Factura Nro. " & ToStr(lngFacturaNro), decIvaBs, decIvaUs, decIvaOrg, 1, mlngSucursalId, mlngCentroCostoId, , 1) Then
                        CompEdit = True
                     End If
                  End If

                  If FacturaUpdate(moCompra.FacturaId, lngTipoCompId, lngCompId, 0) Then 'Ponerle CompId a la Factura
                     CompEdit = True
                  End If

                  If (decExentoBs > 0) Or (decExentoUs > 0) Then
                     If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanExentoId, "Factura Nro. " & ToStr(lngFacturaNro), decExentoBs, decExentoUs, decExentoOrg, 1, mlngSucursalId, mlngCentroCostoId, , 1) Then
                        CompEdit = True
                     End If
                  End If

               ElseIf ToBool(moCompra.FacturaDif) Then 'Factura Diferida  
                  If (decIvaBs > 0) Or (decIvaUs > 0) Then
                     If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreDifId, "", decIvaBs, decIvaUs, decIvaOrg, 1, mlngSucursalId, mlngCentroCostoId, , 0) Then
                        CompEdit = True
                     End If
                  End If

                  If (decExentoBs > 0) Or (decExentoUs > 0) Then
                     If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanExentoId, "", decExentoBs, decExentoUs, decExentoOrg, 1, mlngSucursalId, mlngCentroCostoId, , 1) Then
                        CompEdit = True
                     End If
                  End If

                  '' Cuentas de Retenciones
               ElseIf (moCompra.TipoRetencionId = 1) Or (moCompra.TipoRetencionId = 4) Then 'Retencion    Servicio
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITRetId, "", decITBs, decITUs, decITOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompEdit = True
                  End If

                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanIUERetSerId, "", decIUEBs, decIUEUs, decIUEOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompEdit = True
                  End If

               ElseIf (moCompra.TipoRetencionId = 2) Or (moCompra.TipoRetencionId = 5) Then 'Retencion    Bienes
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITRetId, "", decITBs, decITUs, decITOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompEdit = True
                  End If

                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanIUERetBieId, "", decIUEBs, decIUEUs, decIUEOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompEdit = True
                  End If

               ElseIf (moCompra.TipoRetencionId = 3) Or (moCompra.TipoRetencionId = 6) Then 'Retencion    Alquiler
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITRetId, "", decITBs, decITUs, decITOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompEdit = True
                  End If

                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreRetId, "", decIUEBs, decIUEUs, decIUEOrg, 2, mlngSucursalId, mlngCentroCostoId, , 1) Then
                     CompEdit = True
                  End If
               End If

               If (decGralMontoBs > 0) And (decGralMontoUs > 0) Then 'Contra Cuenta
                  If CompUpdate(lngCompId, decGralMontoBs, decGralMontoUs, "") Then
                     CompEdit = True
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompAdd(ByVal lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = CompNroNext(.TipoCompId, moCompra.GestionId, moCompra.SucursalId, mdatFecha)
            .Fecha = ToDate(mdatFecha)
            .MonedaId = moCompra.MonedaId
            .TipoCambio = moCompra.TipoCambio
            .EntregadoA = ToStr(cboProveedor.Text)
            .PorConcepto = "Nota de Compra al " + cboTipoPago.Text + " Nro. " + txtCompraNro.Text + "; " + txtCompraDes.Text + "; Según Nro Orden. " + txtCompraOrden.Text
            .DebeBs = 0
            .HaberBs = 0
            .DebeUs = 0
            .HaberUs = 0
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF
            .ConFac = moCompra.ConFac
            .SinFac = moCompra.SinFac
            .Automatico = 0
            .Glosa = ""
            '.TipoNotaId = moCompra.TipoNotaId
            '.NotaNro = moCompra.NotaNro
            .TipoAsientoId = 0
            .SucursalId = moCompra.SucursalId
            .NotaId = moCompra.NotaId
            .AppId = clsAppInfo.AppId
            .TipoDocumentoId = clsTipoCompra.COMPRA
            .DocumentoId = moCompra.CompraId
            .EstadoId = 10

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

   Private Function CompUpdate(ByVal lngCompId As Long, ByVal decTotalBs As Decimal, ByVal decTotalUs As Decimal, ByVal strDes As String) As Boolean
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
               .PorConcepto = strDes + "Nota de Compra al " + cboTipoPago.Text + " Nro. " + txtCompraNro.Text + "; " + ToStr(txtCompraDes.Text) + "; Según Nro Orden. " + txtCompraOrden.Text
               .EstadoId = 10

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

   Private Function CompAnular(ByVal lngCompId As Long) As Boolean

      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAnular = False

      Try
         With oComp

            .CompId = lngCompId
            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = 12 'Anulado

               If .Update Then
                  CompAnular = True
               End If
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
                              Optional ByVal bytAutomatico As Byte = 0, Optional ByVal lngTipoRetencionId As Long = 0) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = ToDate(mdatFecha)
            .PlanId = lngPlanId
            ''.CompDetDes = ToStr("Nota de Compra al " + cboTipoPago.Text + " Nro. " + txtCompraNro.Text + "; " + txtCompraDes.Text + " " + strDes)
            .CompDetDes = ToStr("Nota de Compra al " + cboTipoPago.Text + " Nro. " + txtCompraNro.Text + "; " + txtCompraDes.Text + "; " + strDes + "; Según Nro Orden " + txtCompraOrden.Text)
            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId
            .MonedaId = moCompra.MonedaId

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

            .Orden = 0
            .Automatico = bytAutomatico
            .TipoRetencionId = lngTipoRetencionId
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

   Private Function CompDetUpdate(ByVal lngCompDetId As Long, ByVal strDes As String, ByVal decValorBs As Decimal, _
                                 ByVal decValorUs As Decimal, ByVal decValorOrg As Decimal, ByVal lngCol As Long) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetUpdate = False

      Try
         With oCompDet
            .CompDetId = lngCompDetId

            If .FindByPK Then
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

               .CompDetDes = ToStr(.CompDetDes + " " + strDes)
               .Fecha = ToDate(.Fecha)

               If .Update() Then
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

   Private Function CompDetDeleteAll(ByVal lngCompId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompDetDeleteAll = False

      Try
         With oCompDet
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .CompId = lngCompId
            .EmpresaId = moCompra.EmpresaId

            If .Delete Then  'Dell Detalle
               With oCompPlanAdd
                  .WhereFilter = clsCompPlanAdd.WhereFilters.CompId
                  .CompId = lngCompId
                  .EmpresaId = moCompra.EmpresaId

                  Call .Delete() 'Delete Analiticos
               End With

               With oCompCentroCostoDet  'Delete Actividades

                  .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompId
                  .CompId = lngCompId
                  .EmpresaId = moCompra.EmpresaId

                  Call .Delete()

               End With
            End If
         End With

         CompDetDeleteAll = True

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()
         oCompPlanAdd.Dispose()
         oCompCentroCostoDet.Dispose()
      End Try
   End Function

   Private Function CompFind(ByRef lngTipoCompId As Long, ByRef lngCompNro As Long, ByVal lngSucursalId As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompFind = False

      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.All
            .WhereFilter = clsComp.WhereFilters.CompNro
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .SucursalId = lngSucursalId

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

   Private Function CompDetFind(ByVal lngCompId As Long, ByRef lngCompDetId As Long, ByVal lngPlanId As Long, _
                              ByVal lngCol As Long, ByRef decValorBs As Decimal, ByRef decValorUs As Decimal, _
                              ByRef decValorOrg As Decimal) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetFind = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompId = lngCompId
            .PlanId = lngPlanId

            If .Find Then
               If lngCol = 1 Then
                  If .DebeOrg = 0 Then
                     Return False
                  End If

               ElseIf lngCol = 2 Then
                  If .HaberOrg = 0 Then
                     Return False
                  End If
               End If

               lngCompDetId = .CompDetId

               If lngCol = 1 Then
                  decValorOrg = .DebeOrg
                  decValorBs = .DebeBs
                  decValorUs = .DebeUs

               ElseIf lngCol = 2 Then
                  decValorOrg = .HaberOrg
                  decValorBs = .HaberBs
                  decValorUs = .HaberUs
               End If

               CompDetFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompDetCentroCostoFind(ByVal lngCompId As Long, ByRef lngCompDetId As Long, ByVal lngPlanId As Long, _
                              ByVal lngCol As Long, ByRef decValorBs As Decimal, ByRef decValorUs As Decimal, _
                              ByRef decValorOrg As Decimal, ByVal lngCentroCostoId As Long) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetCentroCostoFind = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompIdCentroCostoId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompId = lngCompId
            .PlanId = lngPlanId
            .CentroCostoId = lngCentroCostoId

            If .Find Then
               If lngCol = 1 Then
                  If .DebeOrg = 0 Then
                     Return False
                  End If

               ElseIf lngCol = 2 Then
                  If .HaberOrg = 0 Then
                     Return False
                  End If
               End If

               lngCompDetId = .CompDetId

               If lngCol = 1 Then
                  decValorOrg = .DebeOrg
                  decValorBs = .DebeBs
                  decValorUs = .DebeUs

               ElseIf lngCol = 2 Then
                  decValorOrg = .HaberOrg
                  decValorBs = .HaberBs
                  decValorUs = .HaberUs
               End If

               CompDetCentroCostoFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngCentroCostoId As Long, _
                                  ByVal lngCentroCostoDetId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompCentroCostoDetAdd = False

      Try
         With oCompCentroCostoDet
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = ToDate(mdatFecha)
            .PlanId = lngPlanId
            .MonedaId = moCompra.MonedaId
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

            If .InsertOnly() Then
               CompCentroCostoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
                                 ByVal lngPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAdd = False

      Try
         With oCompPlanAdd
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = ToDate(mdatFecha)
            .PlanId = lngPlanId
            .MonedaId = moCompra.MonedaId
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

            'If .Insert() Then
            If .InsertOnly() Then
               CompPlanAddAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function NotaUpdateAdd(ByRef lngTipoNotaId As Long, ByRef lngNotaNro As Long, ByRef lngNotaId As Long, ByRef lngNotaIdAux As Long) As Boolean
      If lngNotaId <> 0 Then
         If Not (generarInventario()) Then
            NotaUpdateAdd = NotaUpdateAnular(lngNotaId)
            lngTipoNotaId = 0
            lngNotaNro = 0
            lngNotaIdAux = 0
         Else
            NotaUpdateAdd = True
            lngNotaIdAux = lngNotaId
         End If
      Else
         NotaUpdateAdd = NotaAdd(lngNotaId, lngTipoNotaId, lngNotaNro)
         lngNotaIdAux = lngNotaId
      End If

   End Function

   'Anular Inventario por Notas de Compra  SOLO de tipo Servicios
   Private Function NotaUpdateAnular(ByVal lngNotaId As Long) As Boolean
      Dim oNota As New clsNota(clsAppInfo.ConnectString)

      Try
         NotaUpdateAnular = False

         With oNota
            .NotaId = lngNotaId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = 12
               .NotaMonto = ToDecimal(0)
               .NotaDes = .NotaDes & " (Nota Original solo de Servicios)"
               If .Update() Then
                  NotaUpdateAnular = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function PolizaIvaFind(ByVal lngPolizaId As Long, ByRef datFecha As String, ByRef lngPlanIdPoliza As Long, ByRef strPolizaNro As String, _
                                ByRef lngPlanAddIdPoliza As Long, ByRef lngCentroCostoIdPoliza As Long, ByRef lngCentroCostoDetIdPoliza As Long, _
                                ByRef lngSucursalIdPoliza As Long, Optional ByRef lngCompId As Long = 0) As Decimal
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      PolizaIvaFind = 0

      Try
         With oPoliza
            .PolizaId = lngPolizaId

            If .FindByPK Then
               lngPlanIdPoliza = .PlanId
               datFecha = .PolizaFecha
               lngPlanAddIdPoliza = .PlanAddId
               lngCentroCostoIdPoliza = .CentroCostoId
               lngCentroCostoDetIdPoliza = .CentroCostoDetId
               lngSucursalIdPoliza = .SucursalId
               strPolizaNro = .PolizaNro
               PolizaIvaFind = .IVA
               lngCompId = .CompId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza.Dispose()

      End Try
   End Function

   Private Function FacturaUpdate(ByVal lngFacturaId As Long, ByVal lngTipoCompId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      FacturaUpdate = False

      Try
         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               .TipoCompId = lngTipoCompId
               .CompId = lngCompId
               .CompDetId = lngCompDetId
               .FacturaFecha = ToDate(.FacturaFecha)

               Return .Update()
            End If
         End With

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FacturaIvaBsFind(ByVal lngFacturaId As Long, ByRef decFacturaIvaUs As Decimal, Optional ByRef lngFacturaNro As Long = 0, _
                                    Optional ByRef decExentoBs As Decimal = 0, Optional ByRef decExentoUs As Decimal = 0) As Decimal
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      FacturaIvaBsFind = 0

      Try
         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               lngFacturaNro = .FacturaNro

               FacturaIvaBsFind = .IVA
               decFacturaIvaUs = ToDecimal(.IVA / moCompra.TipoCambio)
               decExentoBs = ToDecimal(.Exento * clsAppInfo.IVA)
               decExentoUs = ToDecimal((.Exento / moCompra.TipoCambio) * clsAppInfo.IVA)
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function PlanRecargoPlanIdFind(ByVal lngPlanRecargoId As Long) As Long
      Dim oPlanRecargo As New clsPlanRecargo(clsAppInfo.ConnectString)

      PlanRecargoPlanIdFind = 0

      Try
         With oPlanRecargo
            .PlanRecargoId = lngPlanRecargoId

            If .FindByPK Then
               Return .PlanId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanRecargo.Dispose()

      End Try
   End Function

   Private Function PlanDescuentoPlanIdFind(ByVal lngPlanDescuentoId As Long) As Long
      Dim oPlanDescuento As New clsPlanDescuento(clsAppInfo.ConnectString)

      PlanDescuentoPlanIdFind = 0

      Try
         With oPlanDescuento
            .PlanDescuentoId = lngPlanDescuentoId

            If .FindByPK Then
               Return .PlanId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanDescuento.Dispose()

      End Try
   End Function

   Private Function ProveedorPlanIdActFind(ByVal lngProveedorId As Long, ByRef lngPlanAddIdAct As Long) As Long
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      ProveedorPlanIdActFind = 0

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

   Private Function NotaNroNext(ByVal lngTipoNotaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oNotaPara As New clsNotaPara(clsAppInfo.ConnectString)

      Try
         NotaNroNext = 0

         With oNotaPara
            .SelectFilter = clsNotaPara.SelectFilters.All
            .WhereFilter = clsNotaPara.WhereFilters.TipoNotaId
            .EmpresaId = moCompra.EmpresaId
            .TipoNotaId = lngTipoNotaId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               .UpdateFilter = clsNotaPara.UpdateFilters.NroActual
               .NroActual = ToLong(.NroActual) + 1

               If .Update Then
                  NotaNroNext = .NroActual
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNotaPara.Dispose()

      End Try
   End Function

   Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByVal datFecha As Date) As Long
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompNroNext = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moCompra.EmpresaId
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
                     CompNroNext = CompNroMesNext(lngTipoCompId, lngGestionId, lngSucursalId, datFecha.Month)
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
            .EmpresaId = moCompra.EmpresaId
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

   Private Function TieneChequeraCreada(ByVal lngPlanId As Long) As Boolean
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      TieneChequeraCreada = False

      Try
         With oCheque
            .SelectFilter = clsCheque.SelectFilters.All
            .WhereFilter = clsCheque.WhereFilters.PlanId
            .EmpresaId = moCompra.EmpresaId
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

   Private Function frmCompChequeEditLoad(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decMontoBs As Decimal, ByVal decMontoUs As Decimal) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      Dim frm As New frmCompChequeEdit

      Try
         frmCompChequeEditLoad = False

         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompDetId
            .CompDetId = lngCompDetId

            Dim lngMonedaId As Long = MonedaIdFind(mlngPlanId)

            If .Find Then
               frm.NewRecord = False
               frm.Editing = True

               If lngMonedaId = 1 Then
                  .ChequeMonto = ToDecimal(decMontoBs)
               ElseIf lngMonedaId = 2 Then
                  .ChequeMonto = ToDecimal(decMontoUs)
               End If
            Else
               frm.NewRecord = True
               frm.Editing = False

               .EmpresaId = ToLong(moCompra.EmpresaId)
               .GestionId = ToLong(moCompra.GestionId)
               .CompId = lngCompId
               .CompDetId = lngCompDetId
               .PlanId = mlngPlanId
               .Fecha = ConvertDMY(moCompra.Fecha)
               .ChequeDes = ToStr(txtCompraDes.Text)

               If lngMonedaId = 1 Then
                  .ChequeMonto = ToDecimal(decMontoBs)
               ElseIf lngMonedaId = 2 Then
                  .ChequeMonto = ToDecimal(decMontoUs)
               End If
            End If

            frm.DataObject = oCompCheque
            frm.ShowDialog()

            If frm.Changed Then
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
            .EmpresaId = moCompra.EmpresaId
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
      txtMontoOrg.FormatString = DecimalMask()

      txtPorcentajeDes.FormatString = DecimalMask()
      txtMontoDes.FormatString = DecimalMask()
      txtPorcentajeRec.FormatString = DecimalMask()
      txtMontoRec.FormatString = DecimalMask()
      txtMontoLiq.FormatString = DecimalMask()

      moCompraDet = New clsCompraDet(clsAppInfo.ConnectString)
      CompraParaLoad(clsTipoCompra.COMPRA, clsAppInfo.GestionId, moCompra.SucursalId)
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboTipoPagoLoad()
      Call cboProveedorLoad()
      Call cboAlmacenLoad()
      Call cboEstadoLoad()
      Call cboCentroCostoLoad()
      Call cboSucursalLoad()

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

   Private Sub cboTipoPagoLoad()
      Dim oTipoPago As New clsTipoPago(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoPago.Items.Clear()

      Try
         With oTipoPago
            .SelectFilter = clsTipoPago.SelectFilters.ListBox
            .OrderByFilter = clsTipoPago.OrderByFilters.TipoPagoDes

            If .Open() Then
               Do While .Read()
                  If (.TipoPagoId = clsTipoPago.CREDITO) Or (.TipoPagoId = clsTipoPago.CONTADO) Then
                     oItem = New clsListItem(.TipoPagoId, .TipoPagoDes)

                     cboTipoPago.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoPago.Dispose()
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
            .EmpresaId = moCompra.EmpresaId
            .ProveedorId = moCompra.ProveedorId
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

   Private Sub cboAlmacenLoad()
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboAlmacen.Items.Clear()

      Try
         With oAlmacen
            .SelectFilter = clsAlmacen.SelectFilters.ListBox
            .WhereFilter = clsAlmacen.WhereFilters.TipoAlmacenId
            .OrderByFilter = clsAlmacen.OrderByFilters.AlmacenDes
            .EmpresaId = moCompra.EmpresaId
            .TipoAlmacenId = clsTipoAlmacen.INVENTARIO
            .AlmacenId = moCompra.AlmacenId
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.AlmacenId, .AlmacenDes)

                  cboAlmacen.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAlmacen.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboCentroCostoLoad()
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCosto.Items.Clear()

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.ListBox
            .WhereFilter = clsCentroCosto.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = clsAppInfo.EmpresaId
            .EstadoId = 1
            .CentroCostoId = moCompra.CentroCostoId

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

   Private Sub cboSucursalLoad()
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
            .TipoCompraId = clsTipoCompra.COMPRA

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

   Private Sub frmPedCompraLoad()
      Dim frm As New frmPedCompra

      frm.Find = True
      frm.EmpresaId = moCompra.EmpresaId
      frm.AlmacenId = ListPosition(cboAlmacen, cboAlmacen.SelectedIndex)
      frm.SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)

      If (mlstPedidos.Count > 0) And Not (cboProveedor.ReadOnly) Then
         frm.ProveedorId = -1  '' Pedidos de diferentes Proveedores
      Else
         frm.ProveedorId = ListPosition(cboProveedor)
      End If
      frm.ShowDialog()

      Dim lngMonedaId As Long = ListPosition(cboMoneda, cboMoneda.SelectedIndex)

      If frm.Changed Then
         ''If (frm.MonedaId = lngMonedaId Or lngMonedaId = 0) And (ToDecimal(txtTipoCambio.Text) <> 0) Then
         If (frm.MonedaId = lngMonedaId Or lngMonedaId = 0) Then
            mlstPedCompra = frm.Pedidos
            Call pedCompraCloneList(mlstPedCompra, frm.MonedaId)
         Else
            If CheckClone("Antes de seleccionar el Pedido(s) verifique los siguientes datos, ") Then
               mlstPedCompra = frm.Pedidos
               Call pedCompraCloneList(mlstPedCompra, lngMonedaId)

            End If
         End If

         Dim txtNroOrden As String = ToStr(txtCompraOrden.Text)
         If (mlstPedidos.Count > 0) And (frm.ProveedorId > 0) Then
                '' Si hay lista de pedidos y si esta habilitado cambiar
            If Not (mboolEditarProvPed) Then
               cboProveedor.ReadOnly = True
            End If
            cboProveedor.Value = ListFindItem(cboProveedor, frm.ProveedorId)
         End If

         If clsAppInfo.CentroCostoApli Then
            txtCompraOrden.Text = txtNroOrden
            If (mlstPedidos.Count <> 1) Or (txtCompraOrden.Text.Trim = String.Empty) Then
               txtCompraOrden.Text = GetCodNroOrden()
            End If
         End If

      End If
      frm.Dispose()
   End Sub

   Private Function CheckClone(ByVal strSMS As String) As Boolean

      Dim strMsg As String = String.Empty
      Dim strFecha As String = ToDate(dtpFecha.Value)
      Dim decTipoCambio As Decimal = ToDecimal(txtTipoCambio.Text)

      If (strFecha.Trim() <> String.Empty) And (strFecha.Trim() <> "01/01/1990") Then
         If Not IsDate(ToDateDMY(strFecha)) Then
            strMsg &= "Fecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha no puede ser nula" & vbCrLf
      End If

      If decTipoCambio = 0 Then
         strMsg &= "Tipo de Cambio Inválido" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         strMsg = " Monedas Diferentes: " & vbCrLf & strSMS & vbCrLf & vbCrLf & strMsg
         MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         CheckClone = False
      Else
         CheckClone = True
      End If
   End Function

   Private Function pedCompraCloneList(ByVal lstPedCompra As Queue, ByVal lngMonedaId As Long) As Boolean

      For Each lngPedCompraId As Long In lstPedCompra
         Dim lstItems As New Hashtable

         If Not (mlstPedidos.ContainsKey(lngPedCompraId)) Then
            If pedCompraClone(lngPedCompraId, lstItems, lngMonedaId) Then
               'moVenta.PedVentaId = frm.ID
               mlstPedidos.Add(lngPedCompraId, lstItems)
               pedCompraCloneList = True

               cboMoneda.ReadOnly = True
               cboAlmacen.ReadOnly = True
               ''cboProveedor.ReadOnly = True 
               cboCentroCosto.ReadOnly = True

            End If
         Else
            MessageBox.Show("Pedido Duplicado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Next

      ''If clsAppInfo.CentroCostoApli Then
      ''   If (mlstPedidos.Count <> 1) Or (txtCompraOrden.Text.Trim = String.Empty) Then
      ''      txtCompraOrden.Text = GetCodNroOrden()
      ''   End If
      ''End If

      Call ItemTotal()
      Call ItemTotalPorcentajes()

   End Function

   Private Function pedCompraClone(ByVal lngPedCompraId As Long, ByRef lstItems As Hashtable, ByVal lngMonedaId As Long) As Boolean
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
      Dim oCompra As New clsCompraDet(clsAppInfo.ConnectString)
      Dim decTipoCambio As Decimal = ToDecimal(txtTipoCambio.Text)
      Dim lngPlanIdCos As Long
      Dim lngPlanIdIng As Long

      pedCompraClone = True

      Try

         oPedCompra.PedCompraId = lngPedCompraId

         If (oPedCompra.FindByPK) Then
            cboMoneda.SelectedIndex = ListFindItem(cboMoneda, lngMonedaId)
            ''cboProveedor.Value = ListFindItem(cboProveedor, oPedCompra.ProveedorId)
            cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, oPedCompra.AlmacenId)
            cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, oPedCompra.CentroCostoId)
            txtCompraOrden.Text = oPedCompra.PedCompraOrden
            txtCompraDes.Text = oPedCompra.PedCompraDes

            With oPedCompraDet
               .SelectFilter = clsPedCompraDet.SelectFilters.All
               .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraId
               .OrderByFilter = clsPedCompraDet.OrderByFilters.PedCompraDetId
               .EmpresaId = moCompra.EmpresaId
               .PedCompraId = lngPedCompraId
               'moCompra.GarantiaId = GarantiaIdFind(oPedCompra.PedCompraId)

               If (.Open) Then

                  If oPedCompra.MonedaId = lngMonedaId Then      '' Mismas monedas

                     Do While (.Read)
                        oCompraDet.ItemId = .ItemId
                        oCompraDet.MedidaId = .MedidaId
                        oCompraDet.Cantidad = .Cantidad - .CantidadEnt
                        oCompraDet.CompraDetDes = .PedCompraDetDes

                        If .CantidadEnt = 0 Then
                           oCompraDet.PrecioOrg = .Precio
                           oCompraDet.PrecioRec = .PrecioRec
                           oCompraDet.PrecioDes = .PrecioDes
                           oCompraDet.Importe = .Importe
                           oCompraDet.ImporteBru = .ImporteBru

                        Else

                           oCompraDet.PrecioOrg = .Precio
                           oCompraDet.PrecioRec = .PrecioRec
                           oCompraDet.PrecioDes = .PrecioDes
                           oCompraDet.Importe = ToDecimal(oCompraDet.PrecioOrg * oCompraDet.Cantidad)
                           oCompraDet.ImporteBru = ToDecimal((oCompraDet.PrecioOrg + oCompraDet.PrecioRec - oCompraDet.PrecioDes) * oCompraDet.Cantidad)

                        End If

                        If oCompraDet.Cantidad > 0 Then

                           Call ItemParametro(.ItemId)
                           oCompraDet.PlanIdAct = PlanIdActFind(.ItemId)
                           oCompraDet.PlanAddIdAct = 0
                           ''oCompraDet.CentroCostoIdAct = 0
                           oCompraDet.CentroCostoIdAct = oPedCompraDet.CentroCostoId
                           oCompraDet.CentroCostoDetIdAct = oPedCompraDet.CentroCostoDetId
                           oCompraDet.SucursalIdAct = 0

                           If Not UnirRowPedCompraClone(oCompraDet) Then
                              moDataTable.Rows.Add(GetRowNew(oCompraDet))
                              mlngItemCant += 1
                           End If

                           mdecMontoOrg += oCompraDet.Importe
                           mdecMontoRec += (oCompraDet.PrecioRec * oCompraDet.Cantidad)
                           mdecMontoDes += (oCompraDet.PrecioDes * oCompraDet.Cantidad)

                        End If

                        Dim vecItem As Object() = {0, oCompraDet.Cantidad}
                        lstItems.Add(oCompraDet.ItemId, vecItem)

                        Call .MoveNext()
                     Loop

                  ElseIf lngMonedaId = 1 And oPedCompra.MonedaId = 2 Then      '' diferentes monedas

                     Do While (.Read)
                        oCompraDet.ItemId = .ItemId
                        oCompraDet.MedidaId = .MedidaId
                        oCompraDet.Cantidad = .Cantidad - .CantidadEnt
                        oCompraDet.CompraDetDes = .PedCompraDetDes

                        If .CantidadEnt = 0 Then

                           oCompraDet.PrecioOrg = .Precio * decTipoCambio
                           oCompraDet.PrecioRec = .PrecioRec * decTipoCambio
                           oCompraDet.PrecioDes = .PrecioDes * decTipoCambio
                           oCompraDet.Importe = .Importe * decTipoCambio
                           oCompraDet.ImporteBru = .ImporteBru * decTipoCambio

                        Else
                           oCompraDet.PrecioOrg = .Precio * decTipoCambio
                           oCompraDet.PrecioRec = .PrecioRec * decTipoCambio
                           oCompraDet.PrecioDes = .PrecioDes * decTipoCambio
                           oCompraDet.Importe = ToDecimal(oCompraDet.PrecioOrg * oCompraDet.Cantidad)
                           oCompraDet.ImporteBru = ToDecimal((oCompraDet.PrecioOrg + oCompraDet.PrecioRec - oCompraDet.PrecioDes) * oCompraDet.Cantidad)

                        End If


                        If oCompraDet.Cantidad > 0 Then

                           Call ItemParametro(.ItemId)
                           oCompraDet.PlanIdAct = PlanIdActFind(.ItemId)
                           oCompraDet.PlanAddIdAct = 0
                           ''oCompraDet.CentroCostoIdAct = 0
                           oCompraDet.CentroCostoIdAct = oPedCompraDet.CentroCostoId
                           oCompraDet.CentroCostoDetIdAct = oPedCompraDet.CentroCostoDetId
                           oCompraDet.SucursalIdAct = 0

                           If Not UnirRowPedCompraClone(oCompraDet) Then
                              moDataTable.Rows.Add(GetRowNew(oCompraDet))
                              mlngItemCant += 1
                           End If

                           mdecMontoOrg += oCompraDet.Importe
                           mdecMontoRec += (oCompraDet.PrecioRec * oCompraDet.Cantidad)
                           mdecMontoDes += (oCompraDet.PrecioDes * oCompraDet.Cantidad)

                        End If

                        ''Dim vecItem As Object() = {oCompraDet.Cantidad, 0}
                        Dim vecItem As Object() = {0, oCompraDet.Cantidad}
                        lstItems.Add(oCompraDet.ItemId, vecItem)

                        Call .MoveNext()
                     Loop

                  ElseIf lngMonedaId = 2 And oPedCompra.MonedaId = 1 Then      '' diferentes monedas

                     Do While (.Read)
                        oCompraDet.ItemId = .ItemId
                        ''oCompraDet.ItemPrecioId = .ItemPrecioId
                        oCompraDet.MedidaId = .MedidaId
                        oCompraDet.Cantidad = .Cantidad - .CantidadEnt
                        ''oCompraDet.PrecioOrg = .Precio / decTipoCambio
                        ''oCompraDet.PrecioRec = .PrecioRec / decTipoCambio
                        ''oCompraDet.PrecioDes = .PrecioDes / decTipoCambio
                        ''oCompraDet.Importe = ToDecimal(oCompraDet.PrecioOrg * oCompraDet.Cantidad)
                        ''oCompraDet.ImporteBru = ToDecimal((oCompraDet.PrecioOrg + oCompraDet.PrecioRec - oCompraDet.PrecioDes) * oCompraDet.Cantidad)
                        oCompraDet.CompraDetDes = .PedCompraDetDes

                        If .CantidadEnt = 0 Then

                           oCompraDet.PrecioOrg = .Precio / decTipoCambio
                           oCompraDet.PrecioRec = .PrecioRec / decTipoCambio
                           oCompraDet.PrecioDes = .PrecioDes / decTipoCambio
                           oCompraDet.Importe = .Importe / decTipoCambio
                           oCompraDet.ImporteBru = .ImporteBru / decTipoCambio

                        Else
                           oCompraDet.PrecioOrg = .Precio / decTipoCambio
                           oCompraDet.PrecioRec = .PrecioRec / decTipoCambio
                           oCompraDet.PrecioDes = .PrecioDes / decTipoCambio
                           oCompraDet.Importe = ToDecimal(oCompraDet.PrecioOrg * oCompraDet.Cantidad)
                           oCompraDet.ImporteBru = ToDecimal((oCompraDet.PrecioOrg + oCompraDet.PrecioRec - oCompraDet.PrecioDes) * oCompraDet.Cantidad)

                        End If


                        If oCompraDet.Cantidad > 0 Then

                           Call ItemParametro(.ItemId)
                           oCompraDet.PlanIdAct = PlanIdActFind(.ItemId)
                           oCompraDet.PlanAddIdAct = 0
                           ''oCompraDet.CentroCostoIdAct = 0
                           oCompraDet.CentroCostoIdAct = oPedCompraDet.CentroCostoId
                           oCompraDet.CentroCostoDetIdAct = oPedCompraDet.CentroCostoDetId
                           oCompraDet.SucursalIdAct = 0

                           If Not UnirRowPedCompraClone(oCompraDet) Then
                              moDataTable.Rows.Add(GetRowNew(oCompraDet))
                              mlngItemCant += 1
                           End If

                           mdecMontoOrg += oCompraDet.Importe
                           mdecMontoRec += (oCompraDet.PrecioRec * oCompraDet.Cantidad)
                           mdecMontoDes += (oCompraDet.PrecioDes * oCompraDet.Cantidad)

                        End If

                        ''Dim vecItem As Object() = {oCompraDet.Cantidad, 0}
                        Dim vecItem As Object() = {0, oCompraDet.Cantidad}
                        lstItems.Add(oCompraDet.ItemId, vecItem)

                        Call .MoveNext()
                     Loop

                  End If

               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      Finally
         oPedCompra.Dispose()
         oPedCompraDet.Dispose()
         oCompraDet.Dispose()

      End Try
   End Function

   Private Function UnirRowPedCompraClone(ByVal oCompraDet As clsCompraDet) As Boolean

      UnirRowPedCompraClone = False

      With oCompraDet

         For Each oRow In moDataTable.DataSet.Tables(moCompraDet.TableName).Rows

            If oRow("ItemId") = .ItemId Then

               If (.PrecioOrg = 0) Or (oRow("PrecioOrg") = 0) Then

                  oRow("MontoRec") = 0
                  oRow("MontoDes") = 0
                  oRow("Importe") = 0
                  oRow("ImporteBru") = 0

               Else
                  oRow("MontoRec") += (.PrecioRec * .Cantidad)
                  oRow("MontoDes") += (.PrecioDes * .Cantidad)
                  oRow("Importe") += oCompraDet.Importe
                  oRow("ImporteBru") += oCompraDet.ImporteBru

               End If

               oRow("Cantidad") += .Cantidad

               ''oRow("MontoRec") += (.PrecioRec * .Cantidad)
               ''oRow("MontoDes") += (.PrecioDes * .Cantidad)
               ''oRow("Importe") += oCompraDet.Importe
               ''oRow("ImporteBru") += oCompraDet.ImporteBru

               oRow("PrecioOrg") = ToDouble(oRow("Importe") / oRow("Cantidad"))
               oRow("PrecioRec") = ToDouble(oRow("MontoRec") / oRow("Cantidad"))
               oRow("PrecioDes") = ToDouble(oRow("MontoDes") / oRow("Cantidad"))

               If ToLong(oRow("CentroCostoDetIdAct")) <> .CentroCostoDetIdAct Then
                  oRow("CentroCostoDetIdAct") = 0
               End If

               UnirRowPedCompraClone = True
               Exit For
            End If

         Next

      End With
   End Function

   Private Function CompraDuplicateLoad(ByVal lngCompraId As Long) As Boolean
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      CompraDuplicateLoad = True

      Try

         oCompra.CompraId = lngCompraId

         If oCompra.FindByPK Then
            cboMoneda.SelectedIndex = ListFindItem(cboMoneda, oCompra.MonedaId)
            cboProveedor.Value = ListFindItem(cboProveedor, oCompra.ProveedorId)
            cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, oCompra.AlmacenId)
            cboTipoPago.SelectedIndex = ListFindItem(cboTipoPago, oCompra.TipoPagoId)
            'cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, oCompra.CentroCostoId)
            If oCompra.CentroCostoId <> 0 Then
               cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, oCompra.CentroCostoId)
            End If

            'txtCompraOrden.Text = oCompra.CompraOrden
            txtCompraDes.Text = oCompra.CompraDes
            txtCompraObs.Text = oCompra.CompraObs

            With oCompraDet
               .SelectFilter = clsCompraDet.SelectFilters.All
               .WhereFilter = clsCompraDet.WhereFilters.CompraId
               .OrderByFilter = clsCompraDet.OrderByFilters.CompraDetId
               .EmpresaId = oCompra.EmpresaId
               .CompraId = oCompra.CompraId

               If .Open Then

                  Do While .Read
                     Call ItemParametro(oCompraDet.ItemId)
                     moDataTable.Rows.Add(GetRowNew(oCompraDet))

                     mlngItemCant += 1
                     mdecMontoOrg += oCompraDet.Importe
                     mdecMontoRec += (oCompraDet.PrecioRec * oCompraDet.Cantidad)
                     mdecMontoDes += (oCompraDet.PrecioDes * oCompraDet.Cantidad)

                     Call .MoveNext()
                  Loop

               End If
            End With

            Call grdMainCentroCostoEdit(ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex))

            Call ItemTotal()
            Call ItemTotalPorcentajes()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      Finally
         oCompra.Dispose()
         oCompraDet.Dispose()

      End Try
   End Function

   Private Sub CompraAnular()

      Try
         If moCompra.EstadoId <> clsEstado.ANULADO Then
            If AnularCheck() Then
               If MessageBox.Show("¿Realmente Quiere Anular la Nota de Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  If CompraAnular(moCompra.CompraId, clsEstado.ANULADO) Then
                     mlngID = moCompra.CompraId
                     mboolChanged = True

                     cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     cdmMain.Commands.Item("PedCompra").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False

                     Call DataReadOnly()
                     mboolAdding = False
                     Editing = False

                     Me.Close()
                  End If
               End If
            End If
         Else
            MessageBox.Show("La Nota de Compra ya Fue Anulada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   ''Private Function grdSaldoCheck antes
   Private Function AnularCheck() As Boolean
      Dim oRow As DataRow
      Dim decSaldoActual As Decimal
      Dim strMsg As String = String.Empty

      Dim lngNotaId As Long
      Dim lngNotaDetId As Long

      'NotaFind(moCompra.TipoNotaId, moCompra.NotaNro, moCompra.SucursalId, lngNotaId)
      If moCompra.NotaId > 0 Then
         If isNotaFind(moCompra.NotaId, 0, 0) Then
            lngNotaId = moCompra.NotaId
         End If
      End If

      For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
         Call ItemParametro(oRow("ItemId"))
         Call ItemSaldoParametro(oRow("ItemId"), moCompra.AlmacenId)
         ''strMsg = cantidadMinCheck(oRow("ItemDes"), oRow("MedidaId"), oRow("Cantidad")) & vbCrLf

         If mlngTipoItemId <> 2 Then
            If mlngMedidaId = oRow("MedidaId") Then
               decSaldoActual = mdecSaldoItem
               If mdecSaldoItem < ToDecimal(oRow("Cantidad")) Then
                  strMsg &= "Saldo de Item: " & ToStr(oRow("ItemDes")) & " es Inferior al de la Compra, Cantidad en Stock: " + ToStr(decSaldoActual) & " " & ToStr(oRow("MedidaDes")) & vbCrLf
               End If

            Else
               If mdecSaldoItem < (ToDecimal(oRow("Cantidad")) * mdecMedidaCantEqui) Then
                  decSaldoActual = ToDecimal(mdecSaldoItem / mdecMedidaCantEqui)
                  strMsg &= "Saldo de Item: " & ToStr(oRow("ItemDes")) & " es Inferior al de la Compra, Cantidad en Stock: " + ToStr(decSaldoActual) & " " & ToStr(oRow("MedidaDes")) & vbCrLf
               End If
            End If

            lngNotaDetId = NotaDetIdFind(lngNotaId, oRow("ItemId"))
            If mboolControlLote Then
               If ItemLoteTieneMov(lngNotaId, lngNotaDetId) Then
                  strMsg &= ToStr(oRow("ItemDes")) & ", Lote(s) ya Tiene(n) Movimiento" & vbCrLf
               End If
            End If

            If mboolControlSerie Then
               If ItemNroSerieTieneMov(lngNotaId, oRow("ItemId")) Then
                  strMsg &= ToStr(oRow("ItemDes")) & ", Series(s) ya Tiene(n) Movimiento" & vbCrLf
               End If
            End If
         End If
      Next

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         AnularCheck = False
      Else
         AnularCheck = True
      End If
   End Function

   Private Function CompraAnular(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim lngNotaId As Long
      Dim lngCompId As Long

      Try
         CompraAnular = False

         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = lngEstadoId

               If .Update() Then
                  If CompraDetAnular(lngCompraId, lngEstadoId) Then

                     cboEstado.SelectedIndex = ListFindItem(cboEstado, lngEstadoId)

                     If clsAppInfo.Inventario Then
                        'If CompFind(moCompra.TipoCompId, moCompra.CompNro, moCompra.SucursalId, lngCompId) Then
                        '   If CompAnular(lngCompId, lngEstadoId) Then
                        '      CompraAnular = True
                        '   End If
                        'End If

                        If isCompFind(moCompra.CompId, 0, 0) Then
                           lngCompId = moCompra.CompId
                           If CompAnular(lngCompId, lngEstadoId) Then
                              CompraAnular = True
                           End If
                        End If

                     Else
                        CompraAnular = True
                     End If

                     'Aumentado
                     If ProveedorMovAnular(clsTipoCompra.COMPRA, .CompraId) Then 'Compra
                        CompraAnular = True
                     End If
                     '-------------

                     If AnticipoRestoreUpdate(clsTipoCompra.COMPRA, lngCompraId) Then
                        CompraAnular = True
                     End If

                     ''Call PedCompraUpdate(.PedCompraId, .CompraId, getPedidoEstadoId(.PedCompraId))
                     ' ''Call PedCompraUpdate(.PedCompraId, .CompraId)

                     If (mlstPedidos.Count > 0) Then
                        Call PedCompraAnular()
                        Call pedCompraUpdateList()
                        Call pedidoCompraSelectUpdate(moCompra.CompraId, .EstadoId)

                     End If

                     'If NotaFind(moCompra.TipoNotaId, moCompra.NotaNro, moCompra.SucursalId, lngNotaId) Then
                     If isNotaFind(moCompra.NotaId, 0, 0) Then
                        lngNotaId = moCompra.NotaId
                        If NotaAnular(lngNotaId, lngEstadoId) Then
                           CompraAnular = True
                        End If
                     Else
                        CompraAnular = True
                     End If

                     If moCompra.FacturaId <> 0 Then  '' Si tiene una sola Factura
                        ''If FacturaAnular(moCompra.FacturaId) Then
                        CompraAnular = True
                        ''End If
                     Else
                        If FacturasDifAnular(moCompra.CompraId, 12) Then
                           CompraAnular = True
                        End If
                     End If

                     If CompraOtrosCostosAnular(moCompra.CompraId, 12) Then
                        CompraAnular = True
                     End If

                     If moCompra.PolizaId <> 0 Then
                        If CompraPolizaAnular(moCompra.PolizaId, 12) Then
                           CompraAnular = True
                        End If
                     End If

                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()
      End Try
   End Function

   Private Function CompraDetAnular(ByVal lngCompraId As Long, ByVal lngEstado As Long) As Boolean
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

      Try
         CompraDetAnular = False

         With oCompraDet
            .SelectFilter = clsCompraDet.SelectFilters.All
            .WhereFilter = clsCompraDet.WhereFilters.CompraId
            .EmpresaId = moCompra.EmpresaId
            .CompraId = lngCompraId

            If .Open() Then
               Do While .Read()
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstado

                  If .Update Then
                     Call pedCompraDetUpdateSum(.ItemId, .Cantidad)
                     CompraDetAnular = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function NotaAnular(ByVal lngNotaId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oNota As New clsNota(clsAppInfo.ConnectString)

      Try
         NotaAnular = False

         With oNota
            .NotaId = lngNotaId

            If .FindByPK Then

               .Fecha = ToDate(.Fecha)
               .EstadoId = lngEstadoId

               If .Update() Then
                  If NotaDetAnular(lngNotaId, lngEstadoId) Then
                     NotaAnular = True
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function NotaDetAnular(ByVal lngNotaId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)

      Try
         NotaDetAnular = False

         With oNotaDet
            .SelectFilter = clsNotaDet.SelectFilters.All
            .WhereFilter = clsNotaDet.WhereFilters.NotaId
            .EmpresaId = moCompra.EmpresaId
            .NotaId = lngNotaId

            If .Open() Then
               Do While .Read()
                  Call ItemParametro(.ItemId)
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     Call ItemSaldoRestoreDelete(lngNotaId, .NotaDetId, .ItemId, .AlmacenId)
                     Call itemLoteAnular(lngNotaId, .NotaDetId)
                     Call itemNroSerieAnular(lngNotaId, .ItemId)
                     NotaDetAnular = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNotaDet.Dispose()

      End Try
   End Function

   Private Function CompAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      Try
         CompAnular = False

         With oComp
            .CompId = lngCompId

            If lngCompId <> 0 Then
               If .FindByPK Then
                  .EstadoId = lngEstadoId
                  .Fecha = ToDate(.Fecha)

                  If .Update Then
                     If CompDetAnular(lngCompId, lngEstadoId) Then
                        If CompFacturaAnular(lngCompId, lngEstadoId) Then
                           If CompChequeAnular(lngCompId, lngEstadoId) Then
                              If CompPlanAddAnular(lngCompId, lngEstadoId) Then
                                 If CompCCDetAnular(lngCompId, lngEstadoId) Then
                                    CompAnular = True
                                 End If
                              End If
                           End If
                        End If
                     End If
                  End If
               End If
            Else
               CompAnular = True
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

      Try
         CompDetAnular = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moCompra.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read
                  .EstadoId = lngEstadoId
                  .Fecha = ToDate(.Fecha)

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

   Private Function CompFacturaAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      CompFacturaAnular = False

      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompId
            .EmpresaId = moCompra.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .FacturaFecha = ToDate(.FacturaFecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     CompFacturaAnular = True
                  End If
                  .MoveNext()
               Loop
            Else
               CompFacturaAnular = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function CompChequeAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)

      CompChequeAnular = False

      Try
         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompId
            .EmpresaId = moCompra.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
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

   Private Function CompPlanAddAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAnular = False

      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.All
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompId
            .EmpresaId = moCompra.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .UpdateOnly Then
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
            .EmpresaId = moCompra.EmpresaId
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

   Private Function NotaDetDeleteAll(ByVal lngNotaId As Long) As Boolean
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)

      Try
         NotaDetDeleteAll = False

         With oNotaDet
            .SelectFilter = clsNotaDet.SelectFilters.All
            .WhereFilter = clsNotaDet.WhereFilters.NotaId
            .EmpresaId = moCompra.EmpresaId
            .NotaId = lngNotaId

            If .Open() Then
               Do While .Read()
                  Call NotaDetDelete(.NotaDetId)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oNotaDet.Dispose()
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
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId

            If .Open() Then
               Do While .Read()
                  With oAnticipo
                     .AnticipoId = oAnticipoDet.AnticipoId

                     If .FindByPK Then
                        .Fecha = ToDate(.Fecha)
                        .MontoDes -= oAnticipoDet.Monto
                        .EstadoId = 13 'Pendiente

                        If .Update() Then
                           If ProveedorMovAnular(9, oAnticipoDet.AnticipoDetId) Then 'Descargo de Anticipos
                              AnticipoRestoreUpdate = True
                           End If
                        End If
                     End If
                  End With

                  .MoveNext()
               Loop

               If AnticipoDetUpdate(lngTipoCompraId, lngDocumentoId, 12) Then
                  AnticipoRestoreUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function AnticipoDetUpdate(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoDetUpdate = False

      Try
         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.DocumentoId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId

            If .Find Then
               Do While .Read()

                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     AnticipoDetUpdate = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function ProveedorMovAnular(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAnular = False

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.DocumentoId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .EstadoId = 11 'Abierto

            If .Find Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = clsEstado.ANULADO 'Anulado

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

   Private Function FacturasDifAnular(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)
      Dim lngCompId As Long

      Try
         FacturasDifAnular = False

         With oCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.All
            .WhereFilter = clsCompraFac.WhereFilters.CompraId
            .CompraId = lngCompraId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId

            If .Find Then
               Do While .Read

                  oFactura.FacturaId = .FacturaId
                  If oFactura.FindByPK Then
                     oFactura.FacturaFecha = ToDate(oFactura.FacturaFecha)
                     oFactura.EstadoId = lngEstadoId
                     lngCompId = oFactura.CompId

                     If oFactura.Update Then  'Anulando la Factura

                        If lngCompId <> 0 Then ''La factura esta con todo exento 
                           oComp.CompId = lngCompId
                           If oComp.FindByPK Then
                              oComp.Fecha = ToDate(oComp.Fecha)
                              oComp.PorConcepto = oComp.PorConcepto & " - Anulado por Nro. de Compra " & (moCompra.CompraNro)
                              oComp.EstadoId = lngEstadoId

                              If oComp.Update Then  'Anulando el comprobante
                                 If CompDetAnular(oComp.CompId, lngEstadoId) Then
                                    If CompPlanAddAnular(oComp.CompId, lngEstadoId) Then
                                       If CompCCDetAnular(oComp.CompId, lngEstadoId) Then
                                          FacturasDifAnular = True
                                       End If
                                    End If
                                 End If
                              End If
                           End If

                        ElseIf lngCompId = 0 Then  ''La factura esta con todo exento 
                           FacturasDifAnular = True

                        End If

                        If .MontoCompra > 0 Then
                           CompraFacRestore(.FacturaId)
                        End If

                     End If
                     'End If
                  End If

                  .MoveNext()
               Loop

            Else
               FacturasDifAnular = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()
         oComp.Dispose()
         oCompraFac.Dispose()
      End Try
   End Function

   Private Function CompraFacRestore(ByVal lngFacturaId As Long) As Boolean
      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      ''Para Factura es de Varias Compras

      Try
         CompraFacRestore = True

         With oCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.All
            .WhereFilter = clsCompraFac.WhereFilters.FacturaId
            .FacturaId = lngFacturaId

            If .Open() Then
               Do While .Read()

                  If (.CompraId <> moCompra.CompraId) Then    ''Lo que hacia antes
                     .WhereFilter = clsCompraFac.WhereFilters.PrimaryKey

                     If .Delete Then    'eliminado la relacion de la Factura y Compra

                        oCompra.CompraId = .CompraId
                        If oCompra.FindByPK Then
                           oCompra.Fecha = ToDate(oCompra.Fecha)
                           oCompra.MontoFac = -.MontoCompra

                           oCompra.UpdateFilter = clsCompra.UpdateFilters.MontoFac
                           oCompra.Update()

                        End If
                     End If

                  End If

                  .MoveNext()

               Loop

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraFac.Dispose()
         oCompra.Dispose()
      End Try

   End Function

   Private Function CompraOtrosCostosAnular(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)
      Dim lngCompId As Long

      Try
         CompraOtrosCostosAnular = False

         With oCompraOtroCosto
            .SelectFilter = clsCompraOtroCosto.SelectFilters.All
            .WhereFilter = clsCompraOtroCosto.WhereFilters.CompraId
            .CompraId = lngCompraId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId

            If .Find Then
               Do While .Read

                  .EstadoId = lngEstadoId
                  .Fecha = ToDate(.Fecha)
                  lngCompId = .CompId

                  If .Update Then

                     If .FacturaId <> 0 Then
                        oFactura.FacturaId = .FacturaId
                        If oFactura.FindByPK Then
                           oFactura.FacturaFecha = ToDate(oFactura.FacturaFecha)
                           oFactura.EstadoId = lngEstadoId

                           If oFactura.Update Then  'Anulando la Factura
                              CompraOtrosCostosAnular = True
                           End If

                        End If

                     Else
                        CompraOtrosCostosAnular = True
                     End If

                  End If
                  .MoveNext()

               Loop

               ''Anulando el Comprobante
               If lngCompId <> 0 Then

                  oComp.CompId = lngCompId
                  If oComp.FindByPK Then
                     oComp.EstadoId = lngEstadoId
                     oComp.Fecha = ToDate(oComp.Fecha)

                     If oComp.Update Then  'Anulando el comprobante
                        If CompDetAnular(lngCompId, lngEstadoId) Then
                           If CompFacturaAnular(lngCompId, lngEstadoId) Then
                              If CompPlanAddAnular(lngCompId, lngEstadoId) Then
                                 If CompCCDetAnular(lngCompId, lngEstadoId) Then
                                    CompraOtrosCostosAnular = True
                                 End If
                              End If
                           End If
                        End If
                     End If
                  End If

               End If

            Else
               CompraOtrosCostosAnular = True
            End If

         End With


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()
         oComp.Dispose()
         oCompraOtroCosto.Dispose()
      End Try

   End Function

   Private Function CompraPolizaAnular(ByVal lngPolizaId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)
      Dim lngCompId As Long

      Try
         CompraPolizaAnular = False

         If lngPolizaId <> 0 Then

            With oPoliza
               .PolizaId = lngPolizaId

               If .FindByPK Then

                  .PolizaFecha = ToDate(.PolizaFecha)
                  .EstadoId = lngEstadoId
                  lngCompId = .CompId

                  If .Update Then

                     ''Anulando el Comprobante
                     If .CompId <> 0 Then

                        oComp.CompId = lngCompId
                        If oComp.FindByPK Then
                           oComp.EstadoId = lngEstadoId
                           oComp.Fecha = ToDate(oComp.Fecha)

                           If oComp.Update Then  'Anulando el comprobante
                              If CompDetAnular(lngCompId, lngEstadoId) Then
                                 If CompPlanAddAnular(lngCompId, lngEstadoId) Then
                                    If CompCCDetAnular(lngCompId, lngEstadoId) Then
                                       CompraPolizaAnular = True
                                    End If
                                 End If
                              End If
                           End If
                        End If

                     End If

                  End If
               End If

            End With

         Else
            CompraPolizaAnular = True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()
         oPoliza.Dispose()

      End Try

   End Function

   Public Sub printCompraReport()
      If MessageBox.Show("Compra Guardada Exitosamente" + vbCrLf + "¿Desea Imprimir la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
         Call PrintReport()
      End If
   End Sub

   Public Sub PrintReport()
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)
      Dim oTipoFormImp As New clsTipoFormImp(clsAppInfo.ConnectString)

      Try
         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .TipoCompraId = clsTipoCompra.COMPRA
            .SucursalId = moCompra.SucursalId

            If .Find Then

               If .TipoImpresionId = clsTipoImpresion.GRAPHIC Then 'Gráfica

                  oTipoFormImp.TipoFormImpId = .TipoFormImpId
                  If oTipoFormImp.FindByPK() Then

                     Select Case oTipoFormImp.TipoFormImpDes

                        Case "GEU"  ''TipoFormImpId = 143 Then  'SOLO GEU 139
                           Call PrintReportGEU(oCompraPara)

                        Case Else  ''TipoFormImpId= 44   'Impresion Estandar
                           Call PrintReportGraphic()  'Por defecto la impresion Grafica Estandar

                     End Select

                  Else
                     Call PrintReportGraphic()  'Por defecto la impresion Grafica Estandar

                  End If

               ElseIf .TipoImpresionId = clsTipoImpresion.TEXT Then 'Texto
                  '' NO hace Nada

               Else
                  Call PrintReportGraphic()  'Por defecto la impresion Grafica Estandar

               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()
         oTipoFormImp.Dispose()
      End Try

   End Sub

   Private Sub PrintReportGraphic()
      Dim rpt As New rptCompraEdit
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim oCompraPara As clsCompraPara

      Try
         oCompra.SelectFilter = clsCompra.SelectFilters.Report
         oCompra.WhereFilter = clsCompra.WhereFilters.Report
         oCompra.OrderByFilter = clsCompra.OrderByFilters.Report
         oCompra.EmpresaId = moCompra.EmpresaId
         oCompra.CompraId = moCompra.CompraId

         If oCompra.Find Then
            oCompraPara = CompraParaFind(clsTipoCompra.COMPRA, moCompra.EmpresaId, moCompra.GestionId, moCompra.SucursalId)
            If Not oCompraPara Is Nothing Then
               rpt.DataSource = oCompra.DataSet.Tables(oCompra.TableName).DefaultView

               rpt.txtFirma.Text = oCompraPara.Firma  'CompraParaFirma(2, moCompra.GestionId, strTitulo, lngTipoHojaId, boolPrintAuto)
               rpt.lblTitle.Text = oCompraPara.Titulo
               rpt.Document.Name = oCompraPara.Titulo
               rpt.lblCompany.Text = clsAppInfo.EmpresaGral
               rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
               rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
               rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

               Dim oDataRow As DataRow = oCompra.DataSet.Tables(oCompra.TableName).Rows(0)
               If oDataRow("TipoRetencionId") > 0 Then
                  If isRetencionAsuProv(oDataRow("TipoRetencionId")) Then
                     'rpt.lblMontoRet.Text = TipoRetencionDesFind(oDataRow("TipoRetencionId")) & " (-) :"
                     rpt.lblMontoRet.Text = "Retencion Asume Proveedor " & " (-) :"
                     rpt.txtMontoRet.Text = RetencionCalc(oDataRow("TipoRetencionId"), ToDecimal(oDataRow("MontoBru")), 0, 0, 0)
                  End If
               End If

               Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, oCompraPara.TipoHojaId)

               If oCompraPara.PrintAuto Then
                  Dim oInstance As New Printing.PrinterSettings
                  rpt.Run(False)
                  rpt.Document.Printer.PrinterName = oInstance.PrinterName
                  rpt.Document.Print(False, True)

               ElseIf (oCompraPara.TipoHojaId = clsTipoHoja.CARTA) Or (oCompraPara.TipoHojaId = clsTipoHoja.OFICIO) Then 'Carta o Oficio
                  rpt.Run(True)
                  Dim frm As frmReportPreview
                  frm = New frmReportPreview(rpt.Document)
                  frm.Show()

               ElseIf (oCompraPara.TipoHojaId = clsTipoHoja.MEDIA_CARTA) Or (oCompraPara.TipoHojaId = clsTipoHoja.MEDIO_OFICIO) Then 'Media Carta o Medio Oficio
                  rpt.Run(True)
                  Dim frm As frmReportPreviewMultiple
                  frm = New frmReportPreviewMultiple(rpt.Document)
                  frm.numberOfPagesPerPrinterPage = 2
                  frm.TipoHojaId = oCompraPara.TipoHojaId
                  frm.Show()
                  'frm.PrintReport()
               End If

            Else
               MessageBox.Show("No Existe Parametros de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   Private Sub PrintReportGEU(ByVal oCompraPara As clsCompraPara)
      Dim rpt As New rptCompraEditGEU
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         oCompra.SelectFilter = clsCompra.SelectFilters.Report
         oCompra.WhereFilter = clsCompra.WhereFilters.Report
         oCompra.OrderByFilter = clsCompra.OrderByFilters.Report
         oCompra.EmpresaId = moCompra.EmpresaId
         oCompra.CompraId = moCompra.CompraId

         If oCompra.Find Then
            If Not oCompraPara Is Nothing Then
               rpt.DataSource = oCompra.DataSet.Tables(oCompra.TableName).DefaultView

               rpt.txtFirma.Text = oCompraPara.Firma  'CompraParaFirma(2, moCompra.GestionId, strTitulo, lngTipoHojaId, boolPrintAuto)
               rpt.lblTitle.Text = oCompraPara.Titulo
               rpt.Document.Name = oCompraPara.Titulo
               'rpt.lblCompany.Text = clsAppInfo.EmpresaGral
               rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
               rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
               rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

               If Dir(AppPath(True) & clsAppInfo.EmpresaDes & ".jpg") <> "" Then
                  rpt.picLogo.Image = System.Drawing.Image.FromFile(AppPath(True) & clsAppInfo.EmpresaDes & ".jpg")
               End If

               rpt.txtIsoDes.Text = oCompraPara.IsoDes
               rpt.txtEmisionDes.Text = oCompraPara.EmisionDes
               rpt.txtRevisionDes.Text = oCompraPara.RevisionDes

               Dim oDataRow As DataRow = oCompra.DataSet.Tables(oCompra.TableName).Rows(0)
               If oDataRow("TipoRetencionId") > 0 Then
                  If isRetencionAsuProv(oDataRow("TipoRetencionId")) Then
                     'rpt.lblMontoRet.Text = TipoRetencionDesFind(oDataRow("TipoRetencionId")) & " (-) :"
                     rpt.lblMontoRet.Text = "Retencion Asume Proveedor " & " (-) :"
                     rpt.txtMontoRet.Text = RetencionCalc(oDataRow("TipoRetencionId"), ToDecimal(oDataRow("MontoBru")), 0, 0, 0)
                  End If
               End If

               Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, oCompraPara.TipoHojaId)

               If oCompraPara.PrintAuto Then
                  Dim oInstance As New Printing.PrinterSettings
                  rpt.Run(False)
                  rpt.Document.Printer.PrinterName = oInstance.PrinterName
                  rpt.Document.Print(False, True)

               ElseIf (oCompraPara.TipoHojaId = clsTipoHoja.CARTA) Or (oCompraPara.TipoHojaId = clsTipoHoja.OFICIO) Then 'Carta o Oficio
                  rpt.Run(True)
                  Dim frm As frmReportPreview
                  frm = New frmReportPreview(rpt.Document)
                  frm.Show()

               ElseIf (oCompraPara.TipoHojaId = clsTipoHoja.MEDIA_CARTA) Or (oCompraPara.TipoHojaId = clsTipoHoja.MEDIO_OFICIO) Then 'Media Carta o Medio Oficio
                  rpt.Run(True)
                  Dim frm As frmReportPreviewMultiple
                  frm = New frmReportPreviewMultiple(rpt.Document)
                  frm.numberOfPagesPerPrinterPage = 2
                  frm.TipoHojaId = oCompraPara.TipoHojaId
                  frm.Show()
                  'frm.PrintReport()
               End If

            Else
               MessageBox.Show("No Existe Parametros de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   Private Function CompraParaFirma(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByRef strTitulo As String, _
                                    ByRef lngTipoHojaId As Long, ByRef boolPrintAuto As Boolean) As String
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaFirma = ""

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               strTitulo = .Titulo
               lngTipoHojaId = .TipoHojaId
               CompraParaFirma = .Firma
               boolPrintAuto = .PrintAuto
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Private Function CompraFacturasDifFind(ByVal lngCompraId As Long) As Boolean
      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)

      Try
         With oCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.All
            .WhereFilter = clsCompraFac.WhereFilters.CompraId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = lngCompraId

            If .Find Then
               Return True
            Else
               Return False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraFac.Dispose()

      End Try
   End Function

   Private Function RetencionCalcProveedor(ByRef boolAsuEmp As Boolean, ByRef decRetencionBs As Decimal, ByRef decRetencionUs As Decimal, _
                               ByRef decRetencionOrg As Decimal) As Decimal


      Dim decIUEBs As Decimal = 0
      Dim decIUEUs As Decimal = 0
      Dim decIUEOrg As Decimal = 0

      Dim decITBs As Decimal = 0
      Dim decITUs As Decimal = 0
      Dim decITOrg As Decimal = 0

      If moCompra.TipoRetencionId = 4 Then
         'Por Servicios Asume Provedor
         boolAsuEmp = False
         If moCompra.MonedaId = 1 Then

            decIUEBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Servicios)
            decIUEUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IUE_Servicios)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            decRetencionBs = decIUEBs + decITBs
            decRetencionUs = decIUEUs + decITUs
            decRetencionOrg = decRetencionBs

            RetencionCalcProveedor = decRetencionBs

         ElseIf moCompra.MonedaId = 2 Then

            decIUEBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IUE_Servicios)
            decIUEUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Servicios)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            decRetencionBs = decIUEBs + decITBs
            decRetencionUs = decIUEUs + decITUs
            decRetencionOrg = decRetencionUs

            RetencionCalcProveedor = decRetencionUs
         End If

      ElseIf moCompra.TipoRetencionId = 5 Then
         'Por Bienes Asume Provedor
         boolAsuEmp = False
         If moCompra.MonedaId = 1 Then

            decIUEBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Bienes)
            decIUEUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IUE_Bienes)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            decRetencionBs = decIUEBs + decITBs
            decRetencionUs = decIUEUs + decITUs
            decRetencionOrg = decRetencionBs

            RetencionCalcProveedor = decRetencionBs

         ElseIf moCompra.MonedaId = 2 Then

            decIUEBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IUE_Bienes)
            decIUEUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Bienes)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            decRetencionBs = decIUEBs + decITBs
            decRetencionUs = decIUEUs + decITUs
            decRetencionOrg = decRetencionUs

            RetencionCalcProveedor = decRetencionUs
         End If

      ElseIf moCompra.TipoRetencionId = 6 Then
         'Por Bienes Asume Provedor
         boolAsuEmp = False
         If moCompra.MonedaId = 1 Then

            decIUEBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IVA)
            decIUEUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IVA)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            decRetencionBs = decIUEBs + decITBs
            decRetencionUs = decIUEUs + decITUs
            decRetencionOrg = decRetencionBs

            RetencionCalcProveedor = decRetencionBs

         ElseIf moCompra.MonedaId = 2 Then

            decIUEBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IVA)
            decIUEUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IVA)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            decRetencionBs = decIUEBs + decITBs
            decRetencionUs = decIUEUs + decITUs
            decRetencionOrg = decRetencionUs
            RetencionCalcProveedor = decRetencionUs
         End If

      Else
         decRetencionBs = 0
         decRetencionUs = 0
         RetencionCalcProveedor = 0
      End If

   End Function

   Private Function GetCodNroOrden() As String
      Dim strTexto As String

      strTexto = "NC-"
      If ListPosition(cboProveedor) <> 0 Then
         strTexto = strTexto & ProveedorCodFind(ListPosition(cboProveedor))
      End If

      strTexto = strTexto & "-"
      If cboCentroCosto.SelectedIndex <> -1 Then
         strTexto = strTexto & CentroCostoCodFind(ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex))

      End If

      strTexto = strTexto & "-"

      GetCodNroOrden = strTexto

   End Function

    Private Function CentroCostoDetFind(ByVal lngCentroCostoId As Long) As Boolean
        Dim oCentroCosto As New clsCentroCostoDet(clsAppInfo.ConnectString)

        CentroCostoDetFind = False
        Try
            With oCentroCosto
                .SelectFilter = clsCentroCostoDet.SelectFilters.All
                .WhereFilter = clsCentroCostoDet.WhereFilters.CentroCostoId

                .CentroCostoId = lngCentroCostoId
                .EmpresaId = clsAppInfo.EmpresaId
                If .Find Then
                    CentroCostoDetFind = True
                End If
            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Finally
            oCentroCosto.Dispose()

        End Try
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

   Private Function CompraParaLoad(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaLoad = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = clsAppInfo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               mboolEditarProvPed = .EditarProvPed
               mboolUpdatePrecioVen = .UpdatePrecioVen
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try

   End Function

   Private Function ProveedorCodFind(ByVal lngProveedorId As Long) As String
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      ProveedorCodFind = ""

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               ProveedorCodFind = .ProveedorCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
      If mboolAdding Then
         If Not IsNothing(moCompra) Then
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

   Private Sub chkProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProveedor.CheckedChanged
      If chkProveedor.Checked Then
         cboProveedor.DisplayMember = "ProveedorDes"
         cboProveedor.Tag = cboProveedor.Text
      Else
         cboProveedor.DisplayMember = "ProveedorCod"
         cboProveedor.Tag = cboProveedor.Text
      End If
   End Sub

   Private Sub cboProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmProveedorEdit
               Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oProveedor.EmpresaId = moCompra.EmpresaId

                     .DataObject = oProveedor
                     .ShowDialog()

                     If .Changed Then
                        Call cboProveedorLoad()
                        cboProveedor.Value = ListFindItem(cboProveedor, ToLong(frm.ID))
                     End If

                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oProveedor.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

#End Region

#Region " Detalle de la Compra "

   Private Sub grdMainLoad()
      Dim oRow As DataRow
      Dim boolNotaFind As Boolean
      Dim lngNotaId As Long

      Try
         With moCompraDet
            .SelectFilter = clsCompraDet.SelectFilters.Grid
            .WhereFilter = clsCompraDet.WhereFilters.Grid
            .OrderByFilter = clsCompraDet.OrderByFilters.Grid
            .EmpresaId = moCompra.EmpresaId
            .CompraId = moCompra.CompraId

            mdecMontoOrg = 0
            mdecMontoDes = 0
            mdecMontoRec = 0

            If .Open() Then
               Call moDataSetInit()
               Call moDataSetInitLote(clsItemLote.TABLE_NAME)
               Call moDataSetInitSerie(clsItemNroSerie.TABLE_NAME)

               'boolNotaFind = NotaFind(moCompra.TipoNotaId, moCompra.NotaNro, moCompra.SucursalId, lngNotaId)
               If moCompra.NotaId > 0 Then
                  boolNotaFind = isNotaFind(moCompra.NotaId, 0, 0)
                  lngNotaId = moCompra.NotaId
                  boolNotaFind = True
               End If

               For Each oRow In .DataSet.Tables(.TableName).Rows
                  'Esto es para las Compras viejas
                  If oRow("PlanIdAct") = 0 Then
                     oRow("PlanIdAct") = PlanIdActFind(oRow("ItemId"))
                  End If

                  moDataTable.Rows.Add(GetRowShow(oRow))

                  If boolNotaFind Then
                     If ToBoolean(oRow("ControlLote")) Then
                        Call itemLoteRowShow(lngNotaId, oRow("ItemId"))
                     End If

                     If ToBoolean(oRow("ControlSerie")) Then
                        Call itemNroSerieRowShow(lngNotaId, oRow("ItemId"))
                     End If
                  End If

                  mlngItemCant += 1
                  mdecMontoOrg += ToDouble(oRow("Importe"))
                  mdecMontoRec += ToDouble(oRow("PrecioRec") * oRow("Cantidad"))
                  mdecMontoDes += ToDouble(oRow("PrecioDes") * oRow("Cantidad"))

               Next

               grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            mdecMontoDes = moCompra.MontoDes
            mdecMontoRec = moCompra.MontoRec
            ''Call grdDescuentoLoad(moCompra.MontoDes)
            ''Call grdRecargoLoad(moCompra.MontoRec)

            Call ItemTotal()
            Call ItemTotalPorcentajes()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function NotaFind(ByVal lngTipoNotaId As Long, ByVal lngNotaNro As Long, ByVal lngSucursalId As Long, ByRef lngNotaId As Long) As Boolean
      Dim oNota As New clsNota(clsAppInfo.ConnectString)

      NotaFind = False

      Try
         With oNota
            .SelectFilter = clsNota.SelectFilters.All
            .WhereFilter = clsNota.WhereFilters.NotaNro
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .TipoNotaId = lngTipoNotaId
            .NotaNro = lngNotaNro
            .SucursalId = lngSucursalId

            If .Find Then
               lngNotaId = .NotaId
               NotaFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNota.Dispose()

      End Try
   End Function

   Private Function NotaIdFind(ByVal lngTipoNotaId As Long, ByVal lngNotaNro As Long, ByVal lngSucursalId As Long) As Long
      Dim oNota As New clsNota(clsAppInfo.ConnectString)

      NotaIdFind = False

      Try
         With oNota
            .SelectFilter = clsNota.SelectFilters.All
            .WhereFilter = clsNota.WhereFilters.NotaNro
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .TipoNotaId = lngTipoNotaId
            .NotaNro = lngNotaNro
            .SucursalId = lngSucursalId

            If .Find Then
               NotaIdFind = .NotaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNota.Dispose()

      End Try
   End Function

   Private Function isNotaFind(ByVal lngNotaId As Long, ByRef lngTipoNotaId As Long, ByRef lngNotaNro As Long) As Boolean
      Dim oNota As New clsNota(clsAppInfo.ConnectString)

      isNotaFind = False

      Try
         With oNota
            .NotaId = lngNotaId

            If .FindByPK Then
               lngNotaNro = .NotaNro
               lngTipoNotaId = .TipoNotaId

               isNotaFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNota.Dispose()

      End Try
   End Function

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCompraDet.TableName)

      moDataTable.Columns.Add("CompraDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("MedidaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("CantidadAnt", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioCos", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Importe", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioRec", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioDes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoRec", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoDes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioBru", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("ImporteBru", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioPorFac", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("CompraDetDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCosteoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Estado", Type.GetType("System.String"))

      moDataTable.Columns.Add("PlanIdAct", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanAddIdAct", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CentroCostoIdAct", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CentroCostoDetIdAct", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SucursalIdAct", Type.GetType("System.Int32"))

      modtDelete = moDataSet.Tables.Add("DataDelete")

      modtDelete.Columns.Add("CompraDetId", Type.GetType("System.Int32"))
      modtDelete.Columns.Add("PlanId", Type.GetType("System.Int32"))
      modtDelete.Columns.Add("ItemId", Type.GetType("System.Int32"))
      modtDelete.Columns.Add("ItemCod", Type.GetType("System.String"))
      modtDelete.Columns.Add("ItemDes", Type.GetType("System.String"))
      modtDelete.Columns.Add("MedidaId", Type.GetType("System.Int32"))
      modtDelete.Columns.Add("MedidaDes", Type.GetType("System.String"))
      modtDelete.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
      modtDelete.Columns.Add("CantidadAnt", Type.GetType("System.Decimal"))
      modtDelete.Columns.Add("PrecioOrg", Type.GetType("System.Decimal"))
      modtDelete.Columns.Add("PrecioCos", Type.GetType("System.Decimal"))
      modtDelete.Columns.Add("Importe", Type.GetType("System.Decimal"))
      modtDelete.Columns.Add("PrecioPorFac", Type.GetType("System.Decimal"))
      modtDelete.Columns.Add("TipoItemId", Type.GetType("System.Int32"))
      modtDelete.Columns.Add("Estado", Type.GetType("System.String"))
   End Sub

   Private Function GetRowShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraDetId") = oDataRow("CompraDetId")
      oRow("ItemId") = oDataRow("ItemId")
      oRow("ItemCod") = oDataRow("ItemCod")
      oRow("ItemDes") = oDataRow("ItemDes")
      oRow("MedidaId") = oDataRow("MedidaId")
      oRow("MedidaDes") = oDataRow("MedidaDes")
      oRow("Cantidad") = oDataRow("Cantidad")
      oRow("CantidadAnt") = oDataRow("Cantidad")
      oRow("PrecioOrg") = oDataRow("PrecioOrg")
      oRow("PrecioCos") = oDataRow("PrecioCos")
      oRow("Importe") = oDataRow("Importe")
      oRow("PrecioRec") = oDataRow("PrecioRec")
      oRow("PrecioDes") = oDataRow("PrecioDes")
      oRow("MontoRec") = ToDouble(oDataRow("PrecioRec") * oDataRow("Cantidad"))
      oRow("MontoDes") = ToDouble(oDataRow("PrecioDes") * oDataRow("Cantidad"))
      oRow("ImporteBru") = oDataRow("ImporteBru")
      oRow("PrecioBru") = ToDouble(oRow("ImporteBru") / oRow("Cantidad"))
      oRow("CompraDetDes") = oDataRow("CompraDetDes")
      oRow("Estado") = "Show"

      oRow("PlanIdAct") = oDataRow("PlanIdAct")
      oRow("PlanAddIdAct") = oDataRow("PlanAddIdAct")
      oRow("CentroCostoIdAct") = oDataRow("CentroCostoIdAct")
      oRow("CentroCostoDetIdAct") = oDataRow("CentroCostoDetIdAct")
      oRow("SucursalIdAct") = oDataRow("SucursalIdAct")
      oRow("TipoItemId") = oDataRow("TipoItemId")
      oRow("TipoCosteoId") = oDataRow("TipoCosteoId")

      Return oRow
   End Function

   Private Function GetRowDelete(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = modtDelete.NewRow

      oRow("CompraDetId") = oDataRow("CompraDetId")
      oRow("ItemId") = oDataRow("ItemId")
      oRow("ItemCod") = oDataRow("ItemCod")
      oRow("ItemDes") = oDataRow("ItemDes")
      oRow("MedidaId") = oDataRow("MedidaId")
      oRow("MedidaDes") = oDataRow("MedidaDes")
      oRow("Cantidad") = oDataRow("Cantidad")
      oRow("CantidadAnt") = oDataRow("CantidadAnt")
      oRow("PrecioOrg") = oDataRow("PrecioOrg")
      oRow("Importe") = oDataRow("Importe")
      oRow("TipoItemId") = oDataRow("TipoItemId")
      oRow("Estado") = "Delete"

      Return oRow
   End Function

   Private Function GetRowNew(ByVal oCompraDet As clsCompraDet) As DataRow
      Dim strItemCod As String
      Dim lngTipoItemId, lngTipoCosteoId As Long
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompraDetId") = 0
      oRow("PlanId") = 0
      oRow("ItemId") = oCompraDet.ItemId
      oRow("ItemDes") = ItemDesFind(oCompraDet.ItemId, strItemCod, lngTipoItemId, lngTipoCosteoId)
      oRow("ItemCod") = strItemCod
      oRow("TipoItemId") = lngTipoItemId
      oRow("TipoCosteoId") = lngTipoCosteoId
      oRow("MedidaId") = oCompraDet.MedidaId
      oRow("MedidaDes") = MedidaDesFind(oCompraDet.MedidaId)
      oRow("Cantidad") = oCompraDet.Cantidad
      oRow("CantidadAnt") = 0
      oRow("PrecioOrg") = oCompraDet.PrecioOrg
      oRow("Importe") = oCompraDet.Importe
      oRow("PrecioRec") = oCompraDet.PrecioRec
      oRow("PrecioDes") = oCompraDet.PrecioDes
      oRow("MontoRec") = ToDouble(oCompraDet.PrecioRec * oCompraDet.Cantidad)
      oRow("MontoDes") = ToDouble(oCompraDet.PrecioDes * oCompraDet.Cantidad)
      oRow("ImporteBru") = oCompraDet.ImporteBru
      oRow("PrecioBru") = ToDouble(oCompraDet.ImporteBru / oCompraDet.Cantidad)
      oRow("CompraDetDes") = oCompraDet.CompraDetDes
      oRow("Estado") = "New"

      oRow("PlanIdAct") = oCompraDet.PlanIdAct
      oRow("PlanAddIdAct") = oCompraDet.PlanAddIdAct
      oRow("CentroCostoIdAct") = oCompraDet.CentroCostoIdAct
      oRow("CentroCostoDetIdAct") = oCompraDet.CentroCostoDetIdAct
      oRow("SucursalIdAct") = oCompraDet.SucursalIdAct

      Return oRow
   End Function

   Private Sub RowNewEdit(ByRef oRow As DataRow, ByVal oCompraDet As clsCompraDet, ByVal strEstado As String)
      Dim strItemCod As String
      Dim lngTipoItemId As Long
      Dim lngTipoCosteoId As Long

      'oRow("CompraDetId") = 0
      oRow("ItemId") = oCompraDet.ItemId
      oRow("ItemDes") = ItemDesFind(oCompraDet.ItemId, strItemCod, lngTipoItemId, lngTipoCosteoId)
      oRow("ItemCod") = strItemCod
      oRow("TipoItemId") = lngTipoItemId
      oRow("TipoCosteoId") = lngTipoCosteoId
      oRow("MedidaId") = oCompraDet.MedidaId
      oRow("MedidaDes") = MedidaDesFind(oCompraDet.MedidaId)
      oRow("Cantidad") = oCompraDet.Cantidad

      oRow("PrecioOrg") = oCompraDet.PrecioOrg
      oRow("Importe") = oCompraDet.Importe
      oRow("PrecioRec") = oCompraDet.PrecioRec
      oRow("PrecioDes") = oCompraDet.PrecioDes
      oRow("MontoRec") = ToDouble(oCompraDet.PrecioRec * oCompraDet.Cantidad)
      oRow("MontoDes") = ToDouble(oCompraDet.PrecioDes * oCompraDet.Cantidad)
      oRow("ImporteBru") = oCompraDet.ImporteBru
      oRow("PrecioBru") = ToDouble(oCompraDet.ImporteBru / oCompraDet.Cantidad)
      oRow("CompraDetDes") = oCompraDet.CompraDetDes
      oRow("Estado") = strEstado

      oRow("PlanIdAct") = oCompraDet.PlanIdAct
      oRow("PlanAddIdAct") = oCompraDet.PlanAddIdAct
      oRow("CentroCostoIdAct") = oCompraDet.CentroCostoIdAct
      oRow("CentroCostoDetIdAct") = oCompraDet.CentroCostoDetIdAct
      oRow("SucursalIdAct") = oCompraDet.SucursalIdAct

   End Sub

   Private Sub grdMainShow()
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
      Dim frm As New frmCompraDetEdit

      Try
         If grdMain.RowCount > 0 Then
            If (ToLong(grdMain.GetValue("ItemId")) > 0) Then
               If ToStr(grdMain.GetValue("Estado")) = "Show" Then
                  With oCompraDet
                     .CompraDetId = ToLong(grdMain.GetValue("CompraDetId"))

                     If .FindByPK Then

                        oCompraDet.PlanIdAct = ToLong(grdMain.GetValue("PlanIdAct"))
                        oCompraDet.PlanAddIdAct = ToLong(grdMain.GetValue("PlanAddIdAct"))
                        oCompraDet.CentroCostoIdAct = ToLong(grdMain.GetValue("CentroCostoIdAct"))
                        oCompraDet.CentroCostoDetIdAct = ToLong(grdMain.GetValue("CentroCostoDetIdAct"))
                        oCompraDet.SucursalIdAct = ToLong(grdMain.GetValue("SucursalIdAct"))

                        frm.NewRecord = False
                        frm.Editing = False
                        frm.DataObject = oCompraDet
                        frm.DataTableLote = itemLoteRowFilter(.ItemId)
                        frm.DataTableSerie = itemNroSerieRowFilter(.ItemId)

                        frm.ShowDialog()
                        frm.Dispose()
                     End If
                  End With

               ElseIf (ToStr(grdMain.GetValue("Estado")) = "New") Or (ToStr(grdMain.GetValue("Estado")) = "Edit") Then
                  With frm
                     .NewRecord = False
                     .Editing = False

                     oCompraDet.EmpresaId = ToLong(moCompra.EmpresaId)
                     oCompraDet.CompraId = ToLong(moCompra.CompraId)
                     oCompraDet.Fecha = ToDate(dtpFecha.Value)
                     oCompraDet.AlmacenId = ListPosition(cboAlmacen, cboAlmacen.SelectedIndex)
                     oCompraDet.ProveedorId = ListPosition(cboProveedor)
                     oCompraDet.MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                     oCompraDet.TipoCambio = ToDecimal(txtTipoCambio.Text)
                     oCompraDet.EstadoId = 13

                     oCompraDet.CompraDetId = ToLong(grdMain.GetValue("CompraDetId"))
                     oCompraDet.ItemId = ToLong(grdMain.GetValue("ItemId"))
                     oCompraDet.MedidaId = ToLong(grdMain.GetValue("MedidaId"))
                     oCompraDet.Cantidad = ToDecimal(grdMain.GetValue("Cantidad"))
                     oCompraDet.PrecioOrg = ToDouble(grdMain.GetValue("PrecioOrg"))
                     oCompraDet.Importe = ToDouble(grdMain.GetValue("Importe"))
                     oCompraDet.PrecioDes = ToDouble(grdMain.GetValue("PrecioDes"))
                     oCompraDet.PrecioRec = ToDouble(grdMain.GetValue("PrecioRec"))
                     oCompraDet.CompraDetDes = ToStr(grdMain.GetValue("CompraDetDes"))


                     oCompraDet.PlanIdAct = ToLong(grdMain.GetValue("PlanIdAct"))
                     oCompraDet.PlanAddIdAct = ToLong(grdMain.GetValue("PlanAddIdAct"))
                     oCompraDet.CentroCostoIdAct = ToLong(grdMain.GetValue("CentroCostoIdAct"))
                     oCompraDet.CentroCostoDetIdAct = ToLong(grdMain.GetValue("CentroCostoDetIdAct"))
                     oCompraDet.SucursalIdAct = ToLong(grdMain.GetValue("SucursalIdAct"))

                     .DataObject = oCompraDet
                     .DataTableLote = itemLoteRowFilter(ToLong(grdMain.GetValue("ItemId")))
                     .DataTableSerie = itemNroSerieRowFilter(ToLong(grdMain.GetValue("ItemId")))

                     .ShowDialog()
                     frm.Dispose()
                  End With
               End If
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try
   End Sub

   Private Sub grdMainNew()
      Dim frm As New frmCompraDetEdit
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

      Try
         If mboolAdding Then
            If OperaFechaHabil(ToDate(dtpFecha.Value)) Then
               Call DataMove()
               Call moCompra.Validate()

               If clsAppInfo.CentroCostoApli Then
                  If cboCentroCosto.SelectedIndex = -1 Then
                     MessageBox.Show("Centro de Costo Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     Exit Sub
                  End If
               End If
            Else
               MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Exit Sub
            End If
         End If

         With frm
            oCompraDet.EmpresaId = ToLong(moCompra.EmpresaId)
            oCompraDet.CompraId = ToLong(moCompra.CompraId)
            oCompraDet.Fecha = ToDate(dtpFecha.Value)
            oCompraDet.AlmacenId = ToLong(moCompra.AlmacenId)
            oCompraDet.ProveedorId = ToLong(moCompra.ProveedorId)
            oCompraDet.MonedaId = ToLong(moCompra.MonedaId)
            oCompraDet.TipoCambio = ToDecimal(moCompra.TipoCambio)
            oCompraDet.CentroCostoIdAct = ToLong(moCompra.CentroCostoId)
            oCompraDet.SucursalIdAct = ToLong(moCompra.SucursalId)
            oCompraDet.EstadoId = 13

            Do
               Call mqueItemLoad()
               .ItemList = mqueItem
               .DataObject = oCompraDet

               .DataTableLote = itemLoteRowFilter(0)
               .DataTableSerie = itemNroSerieRowFilter(0)

               .DataTableLoteDelete = itemLoteTablaDelete()

               .NewRecord = True
               .Editing = False
               .ShowDialog()

               If .Changed Then
                  Call DataViewAll()
                  moDataTable.Rows.Add(GetRowNew(frm.DataObject))

                  Call grdMainFindRow(frm.ID)
                  Call itemLoteRowFill(frm.ID)
                  Call itemNroSerieRowFill(frm.ID)

                  mlngItemCant += 1
                  mdecMontoOrg += frm.DataObject.Importe
                  mdecMontoDes += (.DataObject.PrecioDes * .DataObject.Cantidad)
                  mdecMontoRec += (.DataObject.PrecioRec * .DataObject.Cantidad)

                  Call ItemTotal()
                  Call ItemTotalPorcentajes()

                  mboolEditGrid = True

                  If grdMain.RowCount > 0 Then 'Para deshabilitar la moneda
                     cboMoneda.ReadOnly = True
                     cboAlmacen.ReadOnly = True
                     cboCentroCosto.ReadOnly = True
                  End If

               End If
            Loop Until .Changed = False

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try
   End Sub

   Private Sub grdMainEdit()
      Dim frm As New frmCompraDetEdit
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
      Dim decImporteOld, decMontoDesOld, decMontoRecOld As Decimal

      Try
         If grdMain.RowCount > 0 Then
            If (ToLong(grdMain.GetValue("ItemId")) > 0) Then
               If ToStr(grdMain.GetValue("Estado")) = "Show" Then
                  With oCompraDet

                     .CompraDetId = ToLong(grdMain.GetValue("CompraDetId"))

                     If .FindByPK Then

                        oCompraDet.PlanIdAct = ToLong(grdMain.GetValue("PlanIdAct"))
                        oCompraDet.PlanAddIdAct = ToLong(grdMain.GetValue("PlanAddIdAct"))
                        oCompraDet.CentroCostoIdAct = ToLong(grdMain.GetValue("CentroCostoIdAct"))
                        oCompraDet.CentroCostoDetIdAct = ToLong(grdMain.GetValue("CentroCostoDetIdAct"))
                        oCompraDet.SucursalIdAct = ToLong(grdMain.GetValue("SucursalIdAct"))

                        decImporteOld = .Importe
                        decMontoDesOld = .PrecioDes * .Cantidad
                        decMontoRecOld = .PrecioRec * .Cantidad

                        frm.NewRecord = False
                        frm.Editing = True
                        frm.DataObject = oCompraDet
                        frm.DataTableLote = itemLoteRowFilter(.ItemId)
                        frm.DataTableSerie = itemNroSerieRowFilter(.ItemId)

                        frm.DataTableLoteDelete = itemLoteTablaDelete()

                        frm.ShowDialog()

                        If frm.Changed Then
                           Call DataViewAll()
                           Call RowNewEdit(moDataTable.Rows(grdMainFindRowId(frm.ID)), frm.DataObject, "Edit")
                           Call itemLoteRowFill(frm.ID)
                           Call itemNroSerieRowFill(frm.ID)

                           mdecMontoOrg = (mdecMontoOrg - decImporteOld) + frm.DataObject.Importe
                           mdecMontoDes = (mdecMontoDes - decMontoDesOld) + (frm.DataObject.PrecioDes * frm.DataObject.Cantidad)
                           mdecMontoRec = (mdecMontoRec - decMontoRecOld) + (frm.DataObject.PrecioRec * frm.DataObject.Cantidad)

                           Call ItemTotal()
                           Call ItemTotalPorcentajes()

                           mboolEditGrid = True

                        End If

                        frm.Dispose()
                        mboolEditing = True
                     End If

                  End With
               ElseIf ToStr(grdMain.GetValue("Estado")) = "New" Or ToStr(grdMain.GetValue("Estado")) = "Edit" Then
                  With frm
                     .NewRecord = False
                     .Editing = True

                     oCompraDet.EmpresaId = ToLong(moCompra.EmpresaId)
                     oCompraDet.CompraId = ToLong(moCompra.CompraId)
                     oCompraDet.Fecha = ToDate(dtpFecha.Value)
                     oCompraDet.AlmacenId = ListPosition(cboAlmacen, cboAlmacen.SelectedIndex)
                     oCompraDet.ProveedorId = ListPosition(cboProveedor)
                     oCompraDet.MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                     oCompraDet.TipoCambio = ToDecimal(txtTipoCambio.Text)
                     oCompraDet.EstadoId = 13

                     oCompraDet.CompraDetId = ToLong(grdMain.GetValue("CompraDetId"))
                     oCompraDet.ItemId = ToLong(grdMain.GetValue("ItemId"))
                     oCompraDet.MedidaId = ToLong(grdMain.GetValue("MedidaId"))
                     oCompraDet.Cantidad = ToDecimal(grdMain.GetValue("Cantidad"))
                     oCompraDet.PrecioOrg = ToDouble(grdMain.GetValue("PrecioOrg"))
                     oCompraDet.Importe = ToDouble(grdMain.GetValue("Importe"))
                     oCompraDet.PrecioDes = ToDouble(grdMain.GetValue("PrecioDes"))
                     oCompraDet.PrecioRec = ToDouble(grdMain.GetValue("PrecioRec"))
                     oCompraDet.CompraDetDes = ToStr(grdMain.GetValue("CompraDetDes"))

                     oCompraDet.PlanIdAct = ToLong(grdMain.GetValue("PlanIdAct"))
                     oCompraDet.PlanAddIdAct = ToLong(grdMain.GetValue("PlanAddIdAct"))
                     oCompraDet.CentroCostoIdAct = ToLong(grdMain.GetValue("CentroCostoIdAct"))
                     oCompraDet.CentroCostoDetIdAct = ToLong(grdMain.GetValue("CentroCostoDetIdAct"))
                     oCompraDet.SucursalIdAct = ToLong(grdMain.GetValue("SucursalIdAct"))

                     decImporteOld = oCompraDet.Importe
                     decMontoDesOld = oCompraDet.PrecioDes * oCompraDet.Cantidad
                     decMontoRecOld = oCompraDet.PrecioRec * oCompraDet.Cantidad

                     Call mqueItemLoad(oCompraDet.ItemId)
                     .ItemList = mqueItem
                     .DataObject = oCompraDet
                     .DataTableLote = itemLoteRowFilter(ToLong(grdMain.GetValue("ItemId")))
                     .DataTableSerie = itemNroSerieRowFilter(ToLong(grdMain.GetValue("ItemId")))

                     .DataTableLoteDelete = itemLoteTablaDelete()

                     .ShowDialog()

                     If .Changed Then
                        Call DataViewAll()

                        If ToStr(grdMain.GetValue("Estado")) = "Edit" Then
                           Call RowNewEdit(moDataTable.Rows(grdMainFindRowId(frm.ID)), frm.DataObject, "Edit")
                        Else
                           Call RowNewEdit(moDataTable.Rows(grdMainFindRowId(frm.ID)), frm.DataObject, "New")
                        End If

                        Call itemLoteRowFill(frm.ID)
                        Call itemNroSerieRowFill(frm.ID)

                        mdecMontoOrg = (mdecMontoOrg - decImporteOld) + frm.DataObject.Importe
                        mdecMontoDes = (mdecMontoDes - decMontoDesOld) + (frm.DataObject.PrecioDes * frm.DataObject.Cantidad)
                        mdecMontoRec = (mdecMontoRec - decMontoRecOld) + (frm.DataObject.PrecioRec * frm.DataObject.Cantidad)

                        Call ItemTotal()
                        Call ItemTotalPorcentajes()

                        mboolEditGrid = True

                     End If
                     frm.Dispose()
                  End With
               Else
                  MessageBox.Show("Imposible Editar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try
   End Sub

   Private Sub grdMainDelete()
      Dim lngCol As Long
      Dim decImporteOld, decMontoDesOld, decMontoRecOld As Decimal

      Try

         If grdMain.RowCount > 0 Then
            If (ToLong(grdMain.GetValue("ItemId")) > 0) Then
               If moCompra.EstadoId = clsEstado.PENDIENTE Then 'Pendiente

                  If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     Call DataViewAll()

                     If ToStr(grdMain.GetValue("Estado")) = "New" Then

                        decImporteOld = ToDouble(grdMain.GetValue("Importe"))
                        decMontoDesOld = ToDouble(grdMain.GetValue("PrecioDes") * grdMain.GetValue("Cantidad"))
                        decMontoRecOld = ToDouble(grdMain.GetValue("PrecioRec") * grdMain.GetValue("Cantidad"))

                        Call itemRowRemove(clsItemLote.TABLE_NAME, ToLong(grdMain.GetValue("ItemId")))
                        Call itemRowRemove(clsItemNroSerie.TABLE_NAME, ToLong(grdMain.GetValue("ItemId")))

                        moDataTable.Rows.RemoveAt(grdMain.Row)

                        mlngItemCant -= 1
                        mdecMontoOrg = mdecMontoOrg - decImporteOld
                        mdecMontoDes = mdecMontoDes - decMontoDesOld
                        mdecMontoRec = mdecMontoRec - decMontoRecOld

                        grdMain.RetrieveStructure()
                        Call grdMainInit()

                        Call ItemTotal()
                        Call ItemTotalPorcentajes()
                     Else
                        If DeleteCheck(moDataTable.Rows.Item(grdMain.Row)) Then
                           Call DataViewAll() '--

                           modtDelete.Rows.Add(GetRowDelete(moDataTable.Rows.Item(grdMain.Row)))
                           decImporteOld = ToDouble(grdMain.GetValue("Importe"))
                           decMontoDesOld = ToDouble(grdMain.GetValue("PrecioDes") * grdMain.GetValue("Cantidad"))
                           decMontoRecOld = ToDouble(grdMain.GetValue("PrecioRec") * grdMain.GetValue("Cantidad"))

                           Call itemRowRemove(clsItemLote.TABLE_NAME, ToLong(grdMain.GetValue("ItemId")))
                           Call itemRowRemove(clsItemNroSerie.TABLE_NAME, ToLong(grdMain.GetValue("ItemId")))

                           moDataTable.Rows.RemoveAt(grdMain.Row)
                           grdMain.RetrieveStructure()
                           Call grdMainInit()

                           grdMain.Refetch()

                           mlngItemCant -= 1
                           mdecMontoOrg = mdecMontoOrg - decImporteOld
                           mdecMontoDes = mdecMontoDes - decMontoDesOld
                           mdecMontoRec = mdecMontoRec - decMontoRecOld

                           Call ItemTotal()
                           Call ItemTotalPorcentajes()
                        End If

                     End If

                     If grdMain.RowCount = 0 Then 'Para Habilitar la moneda
                        If mboolAdding Then
                           cboMoneda.ReadOnly = False
                           cboAlmacen.ReadOnly = False
                           cboCentroCosto.ReadOnly = False
                        End If
                     End If
                  End If
               Else
                  MessageBox.Show("Imposible Eliminar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Sub

   Private Function DeleteCheck(ByVal oRow As DataRow) As Boolean
      Dim strMsg As String = String.Empty
      Dim decCantidad As Decimal
      Dim decCantidadOld As Decimal
      Dim decSaldoActual As Decimal
      Dim strMsgLote As String = String.Empty

      Dim lngNotaDetId As Long
      Dim lngNotaId As Long
      Dim boolNotaFind As Long

      'boolNotaFind = NotaFind(moCompra.TipoNotaId, moCompra.NotaNro, moCompra.SucursalId, lngNotaId)
      If moCompra.NotaId > 0 Then
         boolNotaFind = isNotaFind(moCompra.NotaId, 0, 0)
         lngNotaId = moCompra.NotaId
         boolNotaFind = True
      End If

      lngNotaDetId = NotaDetIdFind(lngNotaId, oRow("ItemId"))

      Call ItemParametro(oRow("ItemId"))
      If mlngTipoItemId <> 2 Then  'Tipo servicio

         Call ItemSaldoParametro(oRow("ItemId"), moCompra.AlmacenId)

         If mlngMedidaId = ToLong(oRow("MedidaId")) Then
            decCantidad = ToDecimal(oRow("Cantidad"))
            decSaldoActual = mdecSaldoItem
         Else
            decCantidad = ToDecimal(ToDecimal(oRow("Cantidad")) * mdecMedidaCantEqui)
            decSaldoActual = ToDecimal(mdecSaldoItem / mdecMedidaCantEqui)
         End If

         If mdecSaldoItem < decCantidad Then
            strMsg &= ToStr(oRow("ItemDes")) + ", Saldo Insuficiente, Cantidad en Stock : " + ToStr(decSaldoActual) & " " & ToStr(oRow("MedidaDes")) & vbCrLf
         End If

         If mboolControlLote Then
            If ItemLoteTieneMovAnulado(lngNotaId, lngNotaDetId) Then
               strMsg &= ToStr(oRow("ItemDes")) & ", Lote(s) ya Tiene(n) Movimiento" & vbCrLf
            End If
         End If

         If mboolControlSerie Then
            If ItemNroSerieTieneMov(lngNotaId, oRow("ItemId")) Then
               strMsg &= ToStr(oRow("ItemDes")) & ", Serie(s) ya Tiene(n) Movimiento" & vbCrLf
            End If
         End If

      End If

      ''If mlngTipoCosteoId = 3 Then 'PEPS
      ''   If ItemPepsTieneMov(moNota.NotaId, oRow("NotaDetId"), oRow("CantidadEnt")) Then
      ''      strMsg &= ToStr(oRow("ItemDes")) & ", Item PEPS ya Tiene Movimiento" & vbCrLf
      ''   End If
      ''End If

      ''If mlngTipoCosteoId = 4 Then 'UEPS
      ''   If ItemUepsTieneMov(moNota.NotaId, oRow("NotaDetId"), oRow("CantidadEnt")) Then
      ''      strMsg &= ToStr(oRow("ItemDes")) & ", Item UEPS ya Tiene Movimiento" & vbCrLf
      ''   End If
      ''End If


      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         DeleteCheck = False
      Else
         DeleteCheck = True
      End If
   End Function

   Private Function ItemDesFind(ByVal lngItemId As Long, ByRef strItemCod As String, ByRef lngTipoItemId As Long) As String
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      ItemDesFind = ""

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               ItemDesFind = .ItemDes
               strItemCod = .ItemCod
               lngTipoItemId = .TipoItemId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Function

   Private Function ItemDesFind(ByVal lngItemId As Long, ByRef strItemCod As String, ByRef lngTipoItemId As Long, ByRef lngTipoCosteoId As Long) As String
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      ItemDesFind = ""

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               ItemDesFind = .ItemDes
               strItemCod = .ItemCod
               lngTipoItemId = .TipoItemId
               lngTipoCosteoId = .TipoCosteoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Function

   Private Function MedidaDesFind(ByVal lngMedidaId As Long) As String
      Dim oMedida As New clsMedida(clsAppInfo.ConnectString)

      MedidaDesFind = ""

      Try
         With oMedida
            .MedidaId = lngMedidaId

            If .FindByPK Then
               MedidaDesFind = .MedidaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMedida.Dispose()

      End Try
   End Function

   Private Sub grdMainEstadoShow()
      Dim oRow As DataRow

      For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
         oRow("Estado") = "Show"
      Next
   End Sub

   Private Sub ItemTotal()
      txtMontoOrg.Text = ToDecimal(mdecMontoOrg)
      txtMontoRec.Text = ToDecimal(mdecMontoRec)
      txtMontoDes.Text = ToDecimal(mdecMontoDes)
      txtMontoLiq.Text = ToDecimal(ToDecimal(txtMontoOrg.Text) + ToDecimal(txtMontoRec.Text) - ToDecimal(txtMontoDes.Text))
      ''txtMontoLiq.Text = ToDecimal(txtMontoOrg.Text) + ToDecimal(txtMontoRec.Text) - ToDecimal(txtMontoDes.Text)

      txtMontoRec.Tag = txtMontoRec.Text
      txtMontoDes.Tag = txtMontoDes.Text

   End Sub

   Private Sub ItemTotalPorcentajes()

      If mdecMontoRec <> 0 Then
         txtPorcentajeRec.Text = ToDecimal(txtMontoRec.Text * 100 / mdecMontoOrg)
      Else
         txtPorcentajeRec.Text = "0"
      End If

      If mdecMontoDes <> 0 Then
         txtPorcentajeDes.Text = ToDecimal(txtMontoDes.Text * 100 / mdecMontoOrg)
      Else
         txtPorcentajeDes.Text = "0"
      End If

      txtPorcentajeRec.Tag = txtPorcentajeRec.Text
      txtPorcentajeDes.Tag = txtPorcentajeDes.Text

      ''txtMontoDes.Text = ToDecStr((ToDecimal(txtPorcentajeDes.Text) * mdecMontoOrg) / 100)
      ''txtMontoDes.Tag = txtPorcentajeDes.Text
      ''txtMontoLiq.Text = ToDecimal(ToDecimal(txtMontoOrg.Text) + ToDecimal(txtMontoRec.Text) - ToDecimal(txtMontoDes.Text))

   End Sub

   Private Sub grdRecargoLoad(ByVal decMontoRec As Decimal)

      Dim oRow As DataRow

      For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows

         oRow("MontoRec") = ToDecimal(oRow("Importe") / mdecMontoOrg * decMontoRec)
         oRow("PrecioRec") = ToDecimal(oRow("MontoRec") / oRow("Cantidad"))
         oRow("ImporteBru") = ToDecimal(oRow("Importe") + oRow("MontoRec") - oRow("MontoDes"))
         oRow("PrecioBru") = ToDecimal(oRow("ImporteBru") / oRow("Cantidad"))
         oRow("MontoRec") = ToDecimal(oRow("MontoRec"))

         If ToStr(oRow("Estado")) = "Show" Then
            oRow("Estado") = "Edit"
         End If

      Next

      Call ItemTotal()

   End Sub

   Private Sub grdDescuentoLoad(ByVal decMontoDes As Decimal)

      Dim oRow As DataRow

      For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows

         oRow("MontoDes") = ToDouble(oRow("Importe") / mdecMontoOrg * decMontoDes)
         Dim ll As Decimal = oRow("MontoDes")
         oRow("PrecioDes") = ToDouble(oRow("MontoDes") / oRow("Cantidad"))
         oRow("ImporteBru") = ToDouble(oRow("Importe") + oRow("MontoRec") - oRow("MontoDes"))
         oRow("PrecioBru") = ToDouble(oRow("ImporteBru") / oRow("Cantidad"))
         oRow("MontoDes") = oRow("MontoDes")

         If ToStr(oRow("Estado")) = "Show" Then
            oRow("Estado") = "Edit"
         End If

      Next

      Call ItemTotal()

   End Sub

   Private Sub mqueItemLoad(Optional ByVal lngItemId As Long = 0)
      Dim oRow As DataRow

      mqueItem.Clear()

      For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
         If ToLong(oRow("ItemId")) <> lngItemId Then
            mqueItem.Enqueue(oRow("ItemId"))
         End If
      Next
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

   Private Function grdMainFindRowId(ByVal lngID As Long) As Integer
      Dim intRow As Long = 0

      For Each oRow As DataRow In moDataSet.Tables(moCompraDet.TableName).Rows
         If oRow("ItemId") = lngID Then
            Return intRow
         End If

         intRow += 1
      Next

      Return 0
   End Function

   Private Function DataTableRowFindId(ByVal lngID As Long, ByVal oDataTable As DataTable, ByVal strColName As String) As DataRow
      For Each oRow As DataRow In oDataTable.Rows
         If ToLong(oRow(strColName)) = lngID Then
            Return oRow
         End If
      Next
      Return Nothing
   End Function

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("ItemId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdMainClear()
      Call moDataSetInit()
      Call moDataSetInitLote(clsItemLote.TABLE_NAME)
      Call moDataSetInitSerie(clsItemNroSerie.TABLE_NAME)

      grdMain.DataSource = moDataSet.Tables(moCompraDet.TableName).DefaultView
      grdMain.RetrieveStructure()
      Call grdMainInit()

      mdecMontoOrg = 0
      mlngItemCant = 0
      mdecMontoRec = 0
      mdecMontoDes = 0
      Call ItemTotal()
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Detalle de la Nota de Compra"
         .ContextMenu = mnuMain

         .RootTable.Columns("CompraDetId").Visible = False

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 100
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Descripción"
         .RootTable.Columns("ItemDes").Width = 200
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 60
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cantidad").Caption = "Cantidad"
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 100
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CantidadAnt").Visible = False

         .RootTable.Columns("PrecioOrg").Caption = "Precio"
         .RootTable.Columns("PrecioOrg").FormatString = DecimalMask()
         .RootTable.Columns("PrecioOrg").Width = 100
         .RootTable.Columns("PrecioOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioCos").Visible = False

         .RootTable.Columns("Importe").Caption = "Importe"
         .RootTable.Columns("Importe").FormatString = DecimalMask()
         .RootTable.Columns("Importe").Width = 100
         .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioRec").Visible = False

         .RootTable.Columns("MontoRec").Caption = "Recargo"
         .RootTable.Columns("MontoRec").FormatString = DecimalMask()
         .RootTable.Columns("MontoRec").Width = 100
         .RootTable.Columns("MontoRec").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoRec").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioDes").Visible = False

         .RootTable.Columns("MontoDes").Caption = "Descuento"
         .RootTable.Columns("MontoDes").FormatString = DecimalMask()
         .RootTable.Columns("MontoDes").Width = 100
         .RootTable.Columns("MontoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Importe").Caption = "Importe"
         .RootTable.Columns("Importe").FormatString = DecimalMask()
         .RootTable.Columns("Importe").Width = 100
         .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioBru").Caption = "Precio Bruto"
         .RootTable.Columns("PrecioBru").FormatString = DecimalMask()
         .RootTable.Columns("PrecioBru").Width = 100
         .RootTable.Columns("PrecioBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteBru").Caption = "Importe Bruto"
         .RootTable.Columns("ImporteBru").FormatString = DecimalMask()
         .RootTable.Columns("ImporteBru").Width = 100
         .RootTable.Columns("ImporteBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioPorFac").Visible = False

         .RootTable.Columns("CompraDetDes").Caption = "Observación"
         .RootTable.Columns("CompraDetDes").Width = 150
         .RootTable.Columns("CompraDetDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompraDetDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanIdAct").Visible = False
         .RootTable.Columns("PlanAddIdAct").Visible = False
         .RootTable.Columns("CentroCostoIdAct").Visible = False
         .RootTable.Columns("CentroCostoDetIdAct").Visible = False
         .RootTable.Columns("SucursalIdAct").Visible = False
         .RootTable.Columns("TipoItemId").Visible = False
         .RootTable.Columns("TipoCosteoId").Visible = False

         .RootTable.Columns("Estado").Visible = False
      End With
   End Sub

   Private Sub grdMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMain.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdMain.RowCount > 0 Then
               mnuShow.Enabled = True
               mnuNew.Enabled = True
               mnuEdit.Enabled = True
               mnuDelete.Enabled = True
            Else
               mnuShow.Enabled = False
               mnuNew.Enabled = True
               mnuEdit.Enabled = False
               mnuDelete.Enabled = False
            End If
         Else
            mnuShow.Enabled = True
            mnuNew.Enabled = False
            mnuEdit.Enabled = False
            mnuDelete.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdMain.RowCount > 0 Then
               mnuShow.Enabled = True
               mnuNew.Enabled = True
               mnuEdit.Enabled = True
               mnuDelete.Enabled = True
            Else
               mnuShow.Enabled = False
               mnuNew.Enabled = True
               mnuEdit.Enabled = False
               mnuDelete.Enabled = False
            End If
         Else
            mnuShow.Enabled = True
            mnuNew.Enabled = False
            mnuEdit.Enabled = False
            mnuDelete.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call grdMainShow()
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call grdMainShow()
   End Sub

   Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
      Call grdMainNew()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      Call grdMainEdit()
   End Sub

   Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
      Call grdMainDelete()
   End Sub

   Private Function CompraDetDelete(ByVal lngCompraDetId As Long) As Boolean
      '' Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

      Try
         CompraDetDelete = False

         With moCompraDet

            .WhereFilter = clsCompraDet.WhereFilters.PrimaryKey
            .CompraDetId = lngCompraDetId

            .FindByPK()

            .Fecha = ToDate(.Fecha)

            If .Delete Then
               CompraDetDelete = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         ''oCompraDet.Dispose()

      End Try
   End Function

   Private Function generarInventario() As Boolean

      generarInventario = False

      For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
         Call ItemParametro(oRow("ItemId"))

         If mlngTipoItemId = 1 Then
            generarInventario = True
            Exit For
         End If
      Next

      mboolTieneInv = generarInventario

   End Function

   Private Function pedCompraDetUpdate(ByVal lngItemId As Long, ByVal decCantidad As Decimal, ByVal decCantidadAnt As Decimal) As Boolean
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Try
         With oPedCompraDet
            .SelectFilter = clsPedCompraDet.SelectFilters.All
            .WhereFilter = clsPedCompraDet.WhereFilters.ItemId
            .EmpresaId = moCompra.EmpresaId
            .PedCompraId = moCompra.PedCompraId
            .ItemId = lngItemId

            If .Find Then
               If .Cantidad >= .CantidadEnt Then
                  .UpdateFilter = clsPedCompraDet.UpdateFilters.CantidadEnt
                  .CantidadEnt += (decCantidad - decCantidadAnt)
                  If .Update Then
                     pedCompraDetUpdate = True
                  End If
               End If
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPedCompraDet.Dispose()
      End Try
   End Function

   Private Function pedCompraDetUpdateSum(ByVal lngItemId As Long, ByVal decCantidad As Decimal) As Boolean
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Try
         With oPedCompraDet
            .SelectFilter = clsPedCompraDet.SelectFilters.All
            .WhereFilter = clsPedCompraDet.WhereFilters.ItemId
            .EmpresaId = moCompra.EmpresaId
            .PedCompraId = moCompra.PedCompraId
            .ItemId = lngItemId

            If .Find Then
               If .CantidadEnt >= decCantidad Then
                  .UpdateFilter = clsPedCompraDet.UpdateFilters.CantidadEnt
                  .CantidadEnt = (.CantidadEnt - decCantidad)
                  If .Update Then
                     pedCompraDetUpdateSum = True
                  End If
               End If
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPedCompraDet.Dispose()
      End Try
   End Function

   Private Function grdMainSave(ByVal lngNotaId As Long) As Boolean
      Dim oRow As DataRow
      Dim lngNotaDetId As Long

      grdMainSave = True

      Try

         For Each oRow In modtDelete.Rows
            If ToStr(oRow("Estado")) = "Delete" Then

               mboolNotaEditDelete = True
               If CompraDetDelete(oRow("CompraDetId")) Then
                  Call ItemParametro(oRow("ItemId"))
                  Call ItemSaldoParametro(oRow("ItemId"), moCompra.AlmacenId)

                  lngNotaDetId = NotaDetIdFind(lngNotaId, oRow("ItemId"))
                  Call ProrrateoDelete(moCompra.CompraId, oRow("ItemId"))

                  If mlngTipoItemId <> 2 Then 'Item de Servicio
                     'Elimina el lote desde la base de datos
                     Call ItemLoteDelete(lngNotaId, lngNotaDetId)
                     'Elimina la serie desde la base de datos
                     Call itemNroSerieDelete(lngNotaId, oRow("ItemId"))

                     If ItemSaldoRestoreDelete(lngNotaId, lngNotaDetId, oRow("ItemId"), moCompra.AlmacenId) Then
                        Call NotaDetDelete(lngNotaDetId)

                     End If

                  End If

                  'Actualiza la cantidad consumido desde pedido de compra
                  If (mlstPedidos.Count > 0) Then
                     Call PedCompraCantidadEntUpdate(moCompra.AlmacenId, oRow("ItemId"), -oRow("Cantidad"), 0)
                  End If

               End If
            End If

         Next

         For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
            If ToStr(oRow("Estado")) = "New" Then
               Call grdMainMove(oRow)

               If moCompraDet.Insert() Then
                  Call ItemParametro(oRow("ItemId"))
                  Call ItemSaldoParametro(oRow("ItemId"), moCompra.AlmacenId)

                  oRow("CompraDetId") = moCompraDet.CompraDetId
                  Call moCompraDet.CloseConection()

                  If mlngTipoItemId <> 2 Then 'Item de Servicio
                     If NotaDetAdd(lngNotaId, lngNotaDetId) Then
                        If ItemSaldoUpdate(lngNotaId, lngNotaDetId, moCompraDet.ItemId, moCompra.AlmacenId, oRow("CantidadAnt")) Then

                           'Registra el lote a la base de datos
                           If mboolControlLote Then
                              Call itemLoteAddUpdate(clsTipoNota.ENTRADA, lngNotaId, lngNotaDetId, moCompraDet.ItemId, moCompra.AlmacenId)
                           End If
                           'Registra la serie a la base de datos
                           If mboolControlSerie Then
                              Call itemNroSerieAdd(clsTipoNota.ENTRADA, lngNotaId, moCompraDet.ItemId)
                           End If

                        End If
                     End If
                  End If

                  Call ItemProveedorAdd(moCompraDet.ProveedorId, moCompraDet.ItemId, moCompraDet.PrecioOrg)
               End If

            ElseIf ToStr(oRow("Estado")) = "Edit" Or ToStr(oRow("Estado")) = "Show" Then
               ' Actualizar si o si en en Edit y show para actualizar los Costos nuevos CIF 
               Call grdMainMove(oRow)

               mboolNotaEditDelete = False
               If moCompraDet.Update() Then
                  Call ItemParametro(oRow("ItemId"))
                  Call ItemSaldoParametro(oRow("ItemId"), moCompra.AlmacenId)
                  Call moCompraDet.CloseConection()

                  If mlngTipoItemId <> 2 Then 'Item de Servicio
                     lngNotaDetId = NotaDetIdFind(lngNotaId, oRow("ItemId"))

                     'Elimina el lote desde la base de datos
                     Call ItemLoteDelete(lngNotaId, lngNotaDetId)
                     'Elimina la serie desde la base de datos
                     Call itemNroSerieDelete(lngNotaId, oRow("ItemId"))

                     If NotaDetUpdate(lngNotaDetId) Then
                        If ItemSaldoUpdate(lngNotaId, lngNotaDetId, moCompraDet.ItemId, moCompra.AlmacenId, oRow("CantidadAnt")) Then
                           'Registra el lote a la base de datos
                           If mboolControlLote Then
                              Call itemLoteAddUpdate(clsTipoNota.ENTRADA, lngNotaId, lngNotaDetId, moCompraDet.ItemId, moCompra.AlmacenId)
                           End If
                           'Registra la serie a la base de datos
                           If mboolControlSerie Then
                              Call itemNroSerieAdd(clsTipoNota.ENTRADA, lngNotaId, moCompraDet.ItemId)
                           End If
                           'Actualiza la cantidad consumido desde pedido de compra
                           ''Call pedCompraDetUpdate(oRow("ItemId"), oRow("Cantidad"), oRow("CantidadAnt"))
                        End If
                     End If

                  End If
               End If
            End If

            If (mlstPedidos.Count > 0) Then
               Call PedCompraCantidadEntUpdate(moCompra.AlmacenId, oRow("ItemId"), oRow("Cantidad"), oRow("CantidadAnt"))
            End If

         Next


         For Each oRow In moDataSetDet.Tables("DataDeleteLote").Rows
            If ToStr(oRow("Estado")) = "Delete" Then
               If ItemLoteDeleteById(oRow("ItemLoteId")) Then
               End If
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Sub grdMainMove(ByRef oRow As DataRow)
      With moCompraDet
         .CompraDetId = ToLong(oRow("CompraDetId"))
         .EmpresaId = ToLong(moCompra.EmpresaId)
         .GestionId = ToLong(moCompra.GestionId)
         .CompraId = ToLong(moCompra.CompraId)
         .Fecha = ToDate(dtpFecha.Value)
         .AlmacenId = ToLong(moCompra.AlmacenId)
         .ProveedorId = ToLong(moCompra.ProveedorId)
         .MonedaId = ToLong(moCompra.MonedaId)
         .TipoCambio = ToDecimal(moCompra.TipoCambio)
         .ItemId = ToLong(oRow("ItemId"))
         .MedidaId = ToLong(oRow("MedidaId"))
         .CompraDetId = ToLong(oRow("CompraDetId"))
         .CompraDetDes = ToStr(oRow("CompraDetDes"))

         If moCompra.TipoPagoId = 2 Then ' Venta Credito 
            If mboolCreditoAuto Then
               .EstadoId = clsEstado.PROGRAMADO
            Else
               .EstadoId = clsEstado.PENDIENTE
            End If
         Else
            .EstadoId = clsEstado.PENDIENTE
         End If

         If moCompra.MontoLiq > 0 Then
            .EstadoId = 13 'Pendiente
         Else
            .EstadoId = 14 'Realizado
         End If

         .Cantidad = ToDecimal(oRow("Cantidad"))
         .PrecioOrg = ToDecimal(oRow("PrecioOrg"))
         .PrecioRec = ToDecimal(oRow("PrecioRec"))
         .PrecioDes = ToDecimal(oRow("PrecioDes"))
         .Importe = ToDecimal(oRow("Importe"))
         .ImporteBru = ToDecimal(oRow("ImporteBru"))
         .PrecioPorFac = .PrecioOrg + .PrecioRec

         mdecPrecioCif = ProrrateoPrecioCifFind(.CompraId, .ItemId, mdecImporteCif)

         If mdecPrecioCif > 0 Then
            .PrecioCos = mdecPrecioCif
         Else
            .PrecioCos = ToDecimal(oRow("ImporteBru") / oRow("Cantidad"))
         End If

         oRow("PrecioCos") = .PrecioCos

         .PlanIdAct = ToLong(oRow("PlanIdAct"))
         .PlanAddIdAct = ToLong(oRow("PlanAddIdAct"))
         .CentroCostoIdAct = ToLong(oRow("CentroCostoIdAct"))
         .CentroCostoDetIdAct = ToLong(oRow("CentroCostoDetIdAct"))
         '.SucursalIdAct = ToLong(oRow("SucursalIdAct"))
         .SucursalIdAct = moCompra.SucursalId

      End With
   End Sub

   Private Function ProrrateoPrecioCifFind(ByVal lngCompraId As Long, ByVal lngItemId As Long, ByRef decImporteCif As Decimal) As Decimal
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      Try
         ProrrateoPrecioCifFind = 0

         With oProrrateo
            .SelectFilter = clsProrrateo.SelectFilters.All
            .WhereFilter = clsProrrateo.WhereFilters.ItemId

            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = lngCompraId
            .ItemId = lngItemId

            If .Find Then
               decImporteCif = .ImporteCif
               ProrrateoPrecioCifFind = .PrecioCif
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo.Dispose()

      End Try
   End Function

   Private Function ProrrateoDelete(ByVal lngCompraId As Long, ByVal lngItemId As Long) As Boolean
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      ProrrateoDelete = False

      Try
         With oProrrateo
            .WhereFilter = clsProrrateo.WhereFilters.ItemId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = lngCompraId
            .ItemId = lngItemId

            If .Delete Then
               ProrrateoDelete = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo.Dispose()

      End Try
   End Function

   Private Function ItemSaldoActualUpdate(ByVal lngItemId As Long, ByVal lngAlmacenId As Long) As Boolean
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)
      Dim strFechaIni As String
      Dim decSaldo As Decimal
      Dim decPPP As Decimal
      Dim decUPC As Decimal

      Try
         ItemSaldoActualUpdate = False

         With oItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.All
            .WhereFilter = clsItemSaldo.WhereFilters.ItemId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            decSaldo = ItemSaldoActual(moCompra.EmpresaId, moCompra.GestionId, mlngMedidaId, mdecMedidaCantEqui, mlngMonedaIdCos, lngItemId, lngAlmacenId, decPPP, decUPC)

            If .Find Then
               .PrecioFecha = ToDate(.PrecioFecha)
               .Saldo = decSaldo
               .PrecioUPC = decUPC
               .PrecioPPP = decPPP

               If .Update Then
                  ItemSaldoActualUpdate = True
               End If
            Else

               .PrecioFecha = ToDate(dtpFecha.Text)
               .Saldo = decSaldo
               .PrecioUPC = decUPC
               .PrecioPPP = decPPP

               If .Insert Then
                  ItemSaldoActualUpdate = True
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      Finally
         oItemSaldo.Dispose()

      End Try
   End Function

   Private Function ItemSaldoRestoreDelete(ByVal lngNotaId As Long, ByVal lngNotaDetId As Long, ByVal lngItemId As Long, ByVal lngAlmacenId As Long) As Boolean
      If (mlngTipoCosteoId = clsTipoCosteo.PPP) Or (mlngTipoCosteoId = clsTipoCosteo.UPC) Then
         ItemSaldoRestoreDelete = ItemSaldoActualUpdate(lngItemId, lngAlmacenId)

      ElseIf mlngTipoCosteoId = clsTipoCosteo.PEPS Then
         If ItemPepsRestoreDelete(lngNotaDetId, lngAlmacenId) Then
            ItemSaldoRestoreDelete = ItemSaldoActualUpdate(lngItemId, lngAlmacenId)
         End If

      ElseIf mlngTipoCosteoId = clsTipoCosteo.UEPS Then
         If ItemUepsRestoreDelete(lngNotaDetId, lngAlmacenId) Then
            ItemSaldoRestoreDelete = ItemSaldoActualUpdate(lngItemId, lngAlmacenId)
         End If
      End If

   End Function

   Private Function ItemSaldoUpdate(ByVal lngNotaId As Long, ByVal lngNotaDetId As Long, ByVal lngItemId As Long, _
                                    ByVal lngAlmacenId As Long, ByVal decCantidadOrg As Decimal) As Boolean
      If (mlngTipoCosteoId = clsTipoCosteo.PPP) Or (mlngTipoCosteoId = clsTipoCosteo.UPC) Then
         ItemSaldoUpdate = ItemSaldoActualUpdate(lngItemId, lngAlmacenId)

      ElseIf mlngTipoCosteoId = clsTipoCosteo.PEPS Then
         If ItemPepsUpdateAdd(lngAlmacenId, lngNotaId, lngNotaDetId, decCantidadOrg) Then
            ItemSaldoUpdate = ItemSaldoActualUpdate(lngItemId, lngAlmacenId)
         End If

      ElseIf mlngTipoCosteoId = clsTipoCosteo.UEPS Then
         If ItemUepsUpdateAdd(lngAlmacenId, lngNotaId, lngNotaDetId, decCantidadOrg) Then
            ItemSaldoUpdate = ItemSaldoActualUpdate(lngItemId, lngAlmacenId)
         End If
      End If

   End Function

   Private Function ItemPepsRestoreDelete(ByVal lngNotaDetId As Long, ByVal lngAlmacenId As Long) As Boolean
      Dim oItemPeps As New clsItemPeps(clsAppInfo.ConnectString)
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)
      Dim decDif As Decimal

      Try
         ItemPepsRestoreDelete = False

         oNotaDet.NotaDetId = lngNotaDetId

         If oNotaDet.FindByPK Then

            With oItemPeps
               .SelectFilter = clsItemPeps.SelectFilters.All
               .WhereFilter = clsItemPeps.WhereFilters.NotaDetId
               .EmpresaId = moCompraDet.EmpresaId
               .NotaDetId = lngNotaDetId

               If .Find Then

                  If mlngMedidaId = oNotaDet.MedidaId Then
                     decDif = ToDecimal(oNotaDet.CantidadEnt)
                  Else
                     decDif = ToDecimal(oNotaDet.CantidadEnt * mdecMedidaCantEqui)
                  End If

                  decDif = decDif - .Saldo

                  If .Delete() Then
                     ItemPepsRestoreDelete = True
                  End If

                  If decDif > 0 Then  ''si el saldo del Item es menor a la Original
                     ItemPepsPPP(lngAlmacenId, decDif, oNotaDet.ItemId)
                     ItemPepsRestoreDelete = True
                  End If

               Else

                  If mlngMedidaId = oNotaDet.MedidaId Then
                     decDif = ToDecimal(oNotaDet.CantidadEnt)
                  Else
                     decDif = ToDecimal(oNotaDet.CantidadEnt * mdecMedidaCantEqui)
                  End If

                  ItemPepsPPP(lngAlmacenId, decDif, oNotaDet.ItemId)
                  ItemPepsRestoreDelete = True
               End If

            End With

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPeps.Dispose()
         oNotaDet.Dispose()
      End Try
   End Function

   Private Function ItemUepsRestoreDelete(ByVal lngNotaDetId As Long, ByVal lngAlmacenId As Long) As Boolean
      Dim oItemUeps As New clsItemUeps(clsAppInfo.ConnectString)
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)
      Dim decDif As Decimal

      Try
         ItemUepsRestoreDelete = False

         oNotaDet.NotaDetId = lngNotaDetId

         If oNotaDet.FindByPK Then

            With oItemUeps
               .SelectFilter = clsItemUeps.SelectFilters.All
               .WhereFilter = clsItemUeps.WhereFilters.NotaDetId
               .EmpresaId = moCompra.EmpresaId
               .NotaDetId = lngNotaDetId

               If .Find Then

                  If mlngMedidaId = oNotaDet.MedidaId Then
                     decDif = ToDecimal(oNotaDet.CantidadEnt)
                  Else
                     decDif = ToDecimal(oNotaDet.CantidadEnt * mdecMedidaCantEqui)
                  End If

                  decDif = decDif - .Saldo

                  If .Delete() Then
                     ItemUepsRestoreDelete = True
                  End If

                  If decDif > 0 Then  ''si el saldo del Item es menor a la Original
                     ItemUepsPPP(lngAlmacenId, decDif, oNotaDet.ItemId)
                     ItemUepsRestoreDelete = True
                  End If

               Else

                  If mlngMedidaId = oNotaDet.MedidaId Then
                     decDif = ToDecimal(oNotaDet.CantidadEnt)
                  Else
                     decDif = ToDecimal(oNotaDet.CantidadEnt * mdecMedidaCantEqui)
                  End If

                  ItemUepsPPP(lngAlmacenId, decDif, oNotaDet.ItemId)
                  ItemUepsRestoreDelete = True
               End If

            End With
         End If


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemUeps.Dispose()
         oNotaDet.Dispose()
      End Try
   End Function

   Private Function ItemPepsAdd(ByVal lngAlmacenId As Long, ByVal decCantidad As Decimal, ByVal lngNotaId As Long, ByVal lngNotaDetId As Long) As Boolean
      Dim oItemPeps As New clsItemPeps(clsAppInfo.ConnectString)

      Try
         ItemPepsAdd = False

         With oItemPeps
            .EmpresaId = moCompraDet.EmpresaId
            .GestionId = moCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .NotaId = lngNotaId
            .NotaDetId = lngNotaDetId
            .ItemId = moCompraDet.ItemId
            .Fecha = moCompraDet.Fecha
            .FechaNro = ItemPepsFechaNroNext(lngAlmacenId)

            If mlngMedidaId = moCompraDet.MedidaId Then
               .Precio = ItemPEPS(moCompraDet.PrecioCos)
               .Saldo = decCantidad
            Else
               .Precio = ItemPEPS(moCompraDet.PrecioCos / mdecMedidaCantEqui)
               .Saldo = ToDecimal(decCantidad * mdecMedidaCantEqui)
            End If

            If .Insert Then
               ItemPepsAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPeps.Dispose()

      End Try
   End Function

   Private Function ItemPepsFechaNroNext(ByVal lngAlmacenId As Long) As Long
      Dim oItemPeps As New clsItemPeps(clsAppInfo.ConnectString)

      Try
         ItemPepsFechaNroNext = 0

         With oItemPeps
            .RowMaxFilter = clsItemPeps.RowMaxFilters.FechaNro
            .WhereFilter = clsItemPeps.WhereFilters.Fecha

            .EmpresaId = moCompraDet.EmpresaId
            .GestionId = moCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = moCompraDet.ItemId
            .Fecha = moCompraDet.Fecha

            ItemPepsFechaNroNext = .RowMax + 1
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPeps.Dispose()

      End Try
   End Function

   Private Function ItemUepsAdd(ByVal lngAlmacenId As Long, ByVal decCantidad As Decimal, ByVal lngNotaId As Long, ByVal lngNotaDetId As Long) As Boolean
      Dim oItemUeps As New clsItemUeps(clsAppInfo.ConnectString)

      Try
         ItemUepsAdd = False

         With oItemUeps
            .EmpresaId = moCompraDet.EmpresaId
            .GestionId = moCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .NotaId = lngNotaId
            .NotaDetId = lngNotaDetId
            .ItemId = moCompraDet.ItemId
            .Fecha = moCompraDet.Fecha
            .FechaNro = ItemUepsFechaNroNext(lngAlmacenId)

            If mlngMedidaId = moCompraDet.MedidaId Then
               .Precio = ItemUEPS(moCompraDet.PrecioCos)
               .Saldo = decCantidad
            Else
               .Precio = ItemUEPS(moCompraDet.PrecioCos / mdecMedidaCantEqui)
               .Saldo = ToDecimal(decCantidad * mdecMedidaCantEqui)
            End If

            If .Insert Then
               ItemUepsAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemUeps.Dispose()

      End Try
   End Function

   Private Function ItemPepsUpdateAdd(ByVal lngAlmacenId As Long, ByVal lngNotaId As Long, ByVal lngNotaDetId As Long, _
                                      ByVal decCantidadOrg As Decimal) As Boolean

      Dim oItemPeps As New clsItemPeps(clsAppInfo.ConnectString)
      Dim decSaldo As Decimal
      Dim decDif As Decimal
      ItemPepsUpdateAdd = False

      Try

         With oItemPeps
            .SelectFilter = clsItemPeps.SelectFilters.All
            .WhereFilter = clsItemPeps.WhereFilters.NotaDetId
            .EmpresaId = moCompraDet.EmpresaId
            .NotaDetId = lngNotaDetId

            If .Find Then
               decSaldo = .Saldo
               ''decDif = mdecCantidadEntOrg

               .Fecha = ToDate(.Fecha)
               '.Precio = ItemPEPS(moNotaDet.PrecioCos)
               '.Saldo = mdecCantidadEnt

               .WhereFilter = clsItemPeps.WhereFilters.PrimaryKey

               If decCantidadOrg = decSaldo Then

                  .Saldo = moCompraDet.Cantidad
                  .Precio = ItemPEPS(moCompraDet.PrecioCos)

                  If mlngMedidaId <> moCompraDet.MedidaId Then
                     .Precio = ItemPEPS(moCompraDet.PrecioCos / mdecMedidaCantEqui)
                     .Saldo = ToDecimal(moCompraDet.Cantidad * mdecMedidaCantEqui)
                  End If

                  Call .Update()
                  ItemPepsUpdateAdd = True

               ElseIf moCompraDet.Cantidad >= decCantidadOrg Then
                  decDif = moCompraDet.Cantidad - decCantidadOrg
                  .Precio = ItemPEPS(moCompraDet.PrecioCos)

                  If mlngMedidaId <> moCompraDet.MedidaId Then
                     .Precio = ItemPEPS(moCompraDet.PrecioCos / mdecMedidaCantEqui)
                     decDif = ToDecimal(decDif * mdecMedidaCantEqui)
                  End If

                  .Saldo = ToDecimal(.Saldo + decDif)

                  Call .Update()
                  ItemPepsUpdateAdd = True

               ElseIf moCompraDet.Cantidad < decCantidadOrg Then
                  decDif = decCantidadOrg - moCompraDet.Cantidad
                  .Precio = ItemPEPS(moCompraDet.PrecioCos)

                  If mlngMedidaId <> moCompraDet.MedidaId Then
                     .Precio = ItemPEPS(moCompraDet.PrecioCos / mdecMedidaCantEqui)
                     decDif = ToDecimal(decDif * mdecMedidaCantEqui)
                  End If

                  .Saldo = ToDecimal(.Saldo - decDif)

                  If .Saldo > 0 Then
                     Call .Update()
                     ItemPepsUpdateAdd = True

                  ElseIf .Saldo = 0 Then
                     Call .Delete()
                     ItemPepsUpdateAdd = True

                  ElseIf .Saldo < 0 Then
                     Call .Delete()

                     ItemPepsPPP(lngAlmacenId, Math.Abs(.Saldo), moCompraDet.ItemId)
                     ItemPepsUpdateAdd = True
                  End If

               End If

            Else

               If moCompraDet.Cantidad > decCantidadOrg Then
                  decDif = moCompraDet.Cantidad - decCantidadOrg
                  ItemPepsUpdateAdd = ItemPepsAdd(lngAlmacenId, decDif, lngNotaId, lngNotaDetId)

               ElseIf moCompraDet.Cantidad < decCantidadOrg Then
                  decDif = decCantidadOrg - moCompraDet.Cantidad

                  If mlngMedidaId <> moCompraDet.MedidaId Then
                     decDif = ToDecimal(decDif * mdecMedidaCantEqui)
                  End If

                  ItemPepsPPP(lngAlmacenId, decDif, moCompraDet.ItemId)
                  ItemPepsUpdateAdd = True

               ElseIf moCompraDet.Cantidad = decCantidadOrg Then
                  ItemPepsUpdateAdd = True
               End If

            End If
         End With


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPeps.Dispose()

      End Try
   End Function

   Private Function ItemUepsPPP(ByVal lngAlmacenId As Long, ByVal decCantidad As Decimal) As Decimal
      Dim oItemUeps As New clsItemUeps(clsAppInfo.ConnectString)
      Dim decImporte As Decimal = 0
      Dim decDif As Decimal = 0

      Try
         ItemUepsPPP = 0

         With oItemUeps
            .SelectFilter = clsItemUeps.SelectFilters.All
            .WhereFilter = clsItemUeps.WhereFilters.ItemId
            .OrderByFilter = clsItemUeps.OrderByFilters.Fecha

            .EmpresaId = moCompraDet.EmpresaId
            .GestionId = moCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = moCompraDet.ItemId

            If .Open Then
               decDif = decCantidad

               Do While .Read()
                  If decDif > .Saldo Then
                     decImporte = decImporte + (.Saldo * .Precio)
                     decDif = decDif - .Saldo

                     .WhereFilter = clsItemUeps.WhereFilters.PrimaryKey
                     Call .Delete()
                  Else
                     decImporte = decImporte + (decDif * .Precio)

                     .Fecha = ToDate(.Fecha)
                     .Saldo = ToDecimal(.Saldo - decDif)

                     .WhereFilter = clsItemUeps.WhereFilters.PrimaryKey

                     If .Saldo = 0 Then
                        Call .Delete()
                     Else
                        Call .Update()
                     End If

                     ItemUepsPPP = ToDecimal(decImporte / decCantidad)

                     Exit Do
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemUeps.Dispose()

      End Try
   End Function

   Private Function ItemUepsFechaNroNext(ByVal lngAlmacenId As Long) As Long
      Dim oItemUeps As New clsItemUeps(clsAppInfo.ConnectString)

      Try
         ItemUepsFechaNroNext = 0

         With oItemUeps
            .RowMaxFilter = clsItemUeps.RowMaxFilters.FechaNro
            .WhereFilter = clsItemUeps.WhereFilters.Fecha

            .EmpresaId = moCompraDet.EmpresaId
            .GestionId = moCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = moCompraDet.ItemId
            .Fecha = moCompraDet.Fecha

            ItemUepsFechaNroNext = .RowMax + 1
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemUeps.Dispose()

      End Try
   End Function

   Private Function ItemPepsPPP(ByVal lngItemId As Long, ByVal lngAlmacenId As Long) As Decimal
      Dim oItemPeps As New clsItemPeps(clsAppInfo.ConnectString)
      Dim decImporte As Decimal = 0
      Dim decSaldo As Decimal = 0

      Try
         ItemPepsPPP = 0

         With oItemPeps
            .SelectFilter = clsItemPeps.SelectFilters.All
            .WhereFilter = clsItemPeps.WhereFilters.ItemId
            .OrderByFilter = clsItemPeps.OrderByFilters.Fecha

            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Open Then
               Do While .Read()
                  decImporte = decImporte + (.Saldo * .Precio)
                  decSaldo = decSaldo + .Saldo

                  .MoveNext()
               Loop

               If decSaldo <> 0 Then
                  ItemPepsPPP = ToDecimal(decImporte / decSaldo)
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPeps.Dispose()

      End Try
   End Function

   Private Function ItemPepsPPP(ByVal lngAlmacenId As Long, ByVal decCantidad As Decimal, ByVal lngItemId As Long) As Decimal
      Dim oItemPeps As New clsItemPeps(clsAppInfo.ConnectString)
      Dim decImporte As Decimal = 0
      Dim decDif As Decimal = 0

      Try
         ItemPepsPPP = 0

         With oItemPeps
            .SelectFilter = clsItemPeps.SelectFilters.All
            .WhereFilter = clsItemPeps.WhereFilters.ItemId
            .OrderByFilter = clsItemPeps.OrderByFilters.Fecha

            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Open Then
               decDif = decCantidad

               Do While .Read()
                  If decDif > .Saldo Then
                     decImporte = decImporte + (.Saldo * .Precio)
                     decDif = decDif - .Saldo

                     .WhereFilter = clsItemPeps.WhereFilters.PrimaryKey
                     Call .Delete()
                  Else
                     decImporte = decImporte + (decDif * .Precio)

                     .Fecha = ToDate(.Fecha)
                     .Saldo = ToDecimal(.Saldo - decDif)

                     .WhereFilter = clsItemPeps.WhereFilters.PrimaryKey

                     If .Saldo = 0 Then
                        Call .Delete()
                        ItemPepsPPP = True
                     Else
                        Call .Update()
                        ItemPepsPPP = True
                     End If

                     ItemPepsPPP = ToDecimal(decImporte / decCantidad)

                     Exit Do
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPeps.Dispose()

      End Try
   End Function

   Private Function ItemUepsPPP(ByVal lngItemId As Long, ByVal lngAlmacenId As Long) As Decimal
      Dim oItemUeps As New clsItemUeps(clsAppInfo.ConnectString)
      Dim decImporte As Decimal = 0
      Dim decSaldo As Decimal = 0

      Try
         ItemUepsPPP = 0

         With oItemUeps
            .SelectFilter = clsItemUeps.SelectFilters.All
            .WhereFilter = clsItemUeps.WhereFilters.ItemId
            .OrderByFilter = clsItemUeps.OrderByFilters.Fecha

            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Open Then
               Do While .Read()
                  decImporte = decImporte + (.Saldo * .Precio)
                  decSaldo = decSaldo + .Saldo

                  .MoveNext()
               Loop

               If decSaldo <> 0 Then
                  ItemUepsPPP = ToDecimal(decImporte / decSaldo)
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemUeps.Dispose()

      End Try
   End Function

   Private Function ItemUepsPPP(ByVal lngAlmacenId As Long, ByVal decCantidad As Decimal, ByVal lngItemId As Long) As Decimal
      Dim oItemUeps As New clsItemUeps(clsAppInfo.ConnectString)
      Dim decImporte As Decimal = 0
      Dim decDif As Decimal = 0

      Try
         ItemUepsPPP = 0

         With oItemUeps
            .SelectFilter = clsItemUeps.SelectFilters.All
            .WhereFilter = clsItemUeps.WhereFilters.ItemId
            .OrderByFilter = clsItemUeps.OrderByFilters.Fecha

            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Open Then
               decDif = decCantidad

               Do While .Read()
                  If decDif > .Saldo Then
                     decImporte = decImporte + (.Saldo * .Precio)
                     decDif = decDif - .Saldo

                     .WhereFilter = clsItemUeps.WhereFilters.PrimaryKey
                     Call .Delete()
                  Else
                     decImporte = decImporte + (decDif * .Precio)

                     .Fecha = ToDate(.Fecha)
                     .Saldo = ToDecimal(.Saldo - decDif)

                     .WhereFilter = clsItemUeps.WhereFilters.PrimaryKey

                     If .Saldo = 0 Then
                        Call .Delete()
                     Else
                        Call .Update()
                     End If

                     ItemUepsPPP = ToDecimal(decImporte / decCantidad)

                     Exit Do
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemUeps.Dispose()

      End Try
   End Function

   Private Function ItemUepsUpdateAdd(ByVal lngAlmacenId As Long, ByVal lngNotaId As Long, ByVal lngNotaDetId As Long, _
                                      ByVal decCantidadOrg As Decimal) As Boolean

      Dim oItemUeps As New clsItemUeps(clsAppInfo.ConnectString)
      Dim decSaldo As Decimal
      Dim decDif As Decimal
      ItemUepsUpdateAdd = False

      Try

         With oItemUeps
            .SelectFilter = clsItemUeps.SelectFilters.All
            .WhereFilter = clsItemUeps.WhereFilters.NotaDetId
            .EmpresaId = moCompraDet.EmpresaId
            .NotaDetId = lngNotaDetId

            If .Find Then
               decSaldo = .Saldo
               ''decDif = mdecCantidadEntOrg

               .Fecha = ToDate(.Fecha)
               '.Precio = ItemUeps(moNotaDet.PrecioCos)
               '.Saldo = mdecCantidadEnt

               .WhereFilter = clsItemUeps.WhereFilters.PrimaryKey

               If decCantidadOrg = decSaldo Then

                  .Saldo = moCompraDet.Cantidad
                  .Precio = ItemUEPS(moCompraDet.PrecioCos)

                  If mlngMedidaId <> moCompraDet.MedidaId Then
                     .Precio = ItemUEPS(moCompraDet.PrecioCos / mdecMedidaCantEqui)
                     .Saldo = ToDecimal(moCompraDet.Cantidad * mdecMedidaCantEqui)
                  End If

                  Call .Update()
                  ItemUepsUpdateAdd = True

               ElseIf moCompraDet.Cantidad >= decCantidadOrg Then
                  decDif = moCompraDet.Cantidad - decCantidadOrg
                  .Precio = ItemUEPS(moCompraDet.PrecioCos)

                  If mlngMedidaId <> moCompraDet.MedidaId Then
                     .Precio = ItemUEPS(moCompraDet.PrecioCos / mdecMedidaCantEqui)
                     decDif = ToDecimal(decDif * mdecMedidaCantEqui)
                  End If

                  .Saldo = ToDecimal(.Saldo + decDif)

                  Call .Update()
                  ItemUepsUpdateAdd = True

               ElseIf moCompraDet.Cantidad < decCantidadOrg Then
                  decDif = decCantidadOrg - moCompraDet.Cantidad
                  .Precio = ItemUEPS(moCompraDet.PrecioCos)

                  If mlngMedidaId <> moCompraDet.MedidaId Then
                     .Precio = ItemUEPS(moCompraDet.PrecioCos / mdecMedidaCantEqui)
                     decDif = ToDecimal(decDif * mdecMedidaCantEqui)
                  End If

                  .Saldo = ToDecimal(.Saldo - decDif)

                  If .Saldo > 0 Then
                     Call .Update()
                     ItemUepsUpdateAdd = True

                  ElseIf .Saldo = 0 Then
                     Call .Delete()
                     ItemUepsUpdateAdd = True

                  ElseIf .Saldo < 0 Then
                     Call .Delete()

                     ItemUepsPPP(lngAlmacenId, Math.Abs(.Saldo), moCompraDet.ItemId)
                     ItemUepsUpdateAdd = True
                  End If

               End If

            Else

               If moCompraDet.Cantidad > decCantidadOrg Then
                  decDif = moCompraDet.Cantidad - decCantidadOrg
                  ItemUepsUpdateAdd = ItemUepsAdd(lngAlmacenId, decDif, lngNotaId, lngNotaDetId)

               ElseIf moCompraDet.Cantidad < decCantidadOrg Then
                  decDif = decCantidadOrg - moCompraDet.Cantidad

                  If mlngMedidaId <> moCompraDet.MedidaId Then
                     decDif = ToDecimal(decDif * mdecMedidaCantEqui)
                  End If

                  ItemUepsPPP(lngAlmacenId, decDif, moCompraDet.ItemId)
                  ItemUepsUpdateAdd = True

               ElseIf moCompraDet.Cantidad = decCantidadOrg Then
                  ItemUepsUpdateAdd = True
               End If

            End If
         End With


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemUeps.Dispose()

      End Try
   End Function

   Private Function ItemPPP(ByVal decCantidadEnt As Decimal, ByVal decPrecioCos As Decimal) As Decimal
      Dim decPrecio As Decimal = 0
      Dim decCantidad As Decimal = 0

      If moCompra.MonedaId = 1 Then
         If moCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecioCos = ToDecimal(decPrecioCos / moCompra.TipoCambio)
         End If

      ElseIf moCompra.MonedaId = 2 Then
         If moCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecioCos = ToDecimal(decPrecioCos * moCompra.TipoCambio)
         End If
      End If

      decPrecio = (mdecSaldoItem * mdecPrecioPPP) + (decCantidadEnt * decPrecioCos)
      decCantidad = mdecSaldoItem + decCantidadEnt

      Return ToDecimal(decPrecio / decCantidad)
   End Function

   Private Function ItemUPC(ByVal decPrecioCos As Decimal) As Decimal
      Dim decPrecio As Decimal = decPrecioCos

      If moCompra.MonedaId = 1 Then
         If moCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos / moCompra.TipoCambio)
         End If

      ElseIf moCompra.MonedaId = 2 Then
         If moCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos * moCompra.TipoCambio)
         End If
      End If

      Return decPrecio
   End Function

   Private Function ItemPEPS(ByVal decPrecioCos As Decimal) As Decimal
      Dim decPrecio As Decimal = decPrecioCos

      If moCompra.MonedaId = 1 Then
         If moCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos / moCompra.TipoCambio)
         End If

      ElseIf moCompra.MonedaId = 2 Then
         If moCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos * moCompra.TipoCambio)
         End If
      End If

      Return decPrecio
   End Function

   Private Function ItemUEPS(ByVal decPrecioCos As Decimal) As Decimal
      Dim decPrecio As Decimal = decPrecioCos

      If moCompra.MonedaId = 1 Then
         If moCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos / moCompra.TipoCambio)
         End If

      ElseIf moCompra.MonedaId = 2 Then
         If moCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos * moCompra.TipoCambio)
         End If
      End If

      Return decPrecio
   End Function

   Private Function ItemHistAdd(ByVal lngAlmacenId As Long, ByVal lngItemId As Long, _
                                 ByVal strFechaIni As String, ByVal strFechaFin As String, _
                                 ByVal decSaldo As Decimal, ByVal decUPC As Decimal, ByVal decPPP As Decimal) As Boolean
      Dim oItemHist As New clsItemHist(clsAppInfo.ConnectString)
      Dim lngItemHistId As Long

      Try
         ItemHistAdd = False

         With oItemHist
            .RowMaxFilter = clsItemHist.RowMaxFilters.PrimaryKey
            .WhereFilter = clsItemHist.WhereFilters.ItemId
            .EmpresaId = moCompraDet.EmpresaId
            .GestionId = moCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            lngItemHistId = .RowMax

            If lngItemHistId > 0 Then
               .ItemHistId = lngItemHistId

               If .FindByPK Then
                  If .PrecioPPP = decPPP Then 'Si el PPP sigue siendo el mismo
                     .FechaIni = ToDate(.FechaIni)
                     .FechaFin = strFechaFin
                     .Saldo = decSaldo
                     .PrecioUPC = decUPC

                     If .Update Then
                        ItemHistAdd = True
                     End If

                  Else  'En caso de que el PPP haya cambiado
                     .EmpresaId = moCompraDet.EmpresaId
                     .GestionId = moCompraDet.GestionId
                     .AlmacenId = lngAlmacenId
                     .ItemId = lngItemId
                     .FechaIni = strFechaIni
                     .FechaFin = strFechaFin
                     .Saldo = decSaldo
                     .PrecioUPC = decUPC
                     .PrecioPPP = decPPP

                     If .Insert Then
                        ItemHistAdd = True
                     End If
                  End If
               End If

            Else ' Si no existe registro Historico
               .EmpresaId = moCompraDet.EmpresaId
               .GestionId = moCompraDet.GestionId
               .AlmacenId = lngAlmacenId
               .ItemId = lngItemId
               .FechaIni = strFechaIni
               .FechaFin = strFechaFin
               .Saldo = decSaldo
               .PrecioUPC = decUPC
               .PrecioPPP = decPPP

               If .Insert Then
                  ItemHistAdd = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemHist.Dispose()

      End Try
   End Function

   Private Function ItemProveedorAdd(ByVal lngProveedorId As Long, ByVal lngItemId As Long, ByVal decPrecioUPC As Decimal) As Boolean
      Dim oItemProveedor As New clsItemProveedor(clsAppInfo.ConnectString)
      Dim decUPC As Decimal

      Try
         ItemProveedorAdd = False

         If moCompraDet.MonedaId <> mlngMonedaIdCos Then
            If moCompraDet.MonedaId = 1 Then
               decUPC = decPrecioUPC / moCompraDet.TipoCambio
            Else
               decUPC = decPrecioUPC * moCompraDet.TipoCambio
            End If
         Else
            decUPC = decPrecioUPC
         End If

         If mlngMedidaId <> moCompraDet.MedidaId Then
            decUPC = ToDecimal(decUPC / mdecMedidaCantEqui)
         End If

         With oItemProveedor
            .SelectFilter = clsItemProveedor.SelectFilters.All
            .WhereFilter = clsItemProveedor.WhereFilters.ItemId
            .EmpresaId = moCompraDet.EmpresaId
            .ProveedorId = lngProveedorId
            .ItemId = lngItemId

            If decUPC > 0 Then
               If .Find Then
                  If .PrecioUPC <> decUPC Then 'Si el UPC ha cambiado
                     .PrecioUPC = decUPC

                     ItemProveedorAdd = .Update
                  Else
                     ItemProveedorAdd = True
                  End If

               Else
                  .EmpresaId = moCompraDet.EmpresaId
                  .ProveedorId = lngProveedorId
                  .ItemId = lngItemId
                  .PrecioUPC = decUPC

                  If .Insert Then
                     ItemProveedorAdd = True
                  End If
               End If

            Else
               ItemProveedorAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemProveedor.Dispose()

      End Try
   End Function

   Private Sub ItemParametro(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngTipoItemId = 0
         mlngTipoCosteoId = 0
         mlngMedidaId = 0
         mlngMedidaIdEqui = 0
         mdecMedidaCantEqui = 0
         mlngMonedaIdCos = 0
         mdecCantidadMin = 0
         mdecCantidadMax = 0
         mboolControlLote = False
         mboolControlSerie = False

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngTipoItemId = ToLong(.TipoItemId)
               mlngTipoCosteoId = ToLong(.TipoCosteoId)
               mlngMedidaId = ToLong(.MedidaId)
               mlngMedidaIdEqui = ToLong(.MedidaIdEqui)
               mdecMedidaCantEqui = ToDecimal(.MedidaCantEqui)
               mlngMonedaIdCos = ToLong(.MonedaIdCos)
               mdecCantidadMin = ToDecimal(.CantidadMin)
               mdecCantidadMax = ToDecimal(.CantidadMax)
               mboolControlLote = ToBoolean(.ControlLote)
               mboolControlSerie = ToBoolean(.ControlSerie)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub ItemSaldoParametro(ByVal lngItemId As Long, ByVal lngAlmacenId As Long)
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)

      Try
         mdecPrecioPPP = 0
         mdecPrecioUPC = 0
         mdecSaldoItem = 0

         With oItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.All
            .WhereFilter = clsItemSaldo.WhereFilters.ItemId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Find Then
               mdecPrecioPPP = ToDecimal(.PrecioPPP)
               mdecPrecioUPC = ToDecimal(.PrecioUPC)
               mdecSaldoItem = ToDecimal(.Saldo)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemSaldo.Dispose()

      End Try
   End Sub

#End Region

#Region " ItemLote "

   Private Sub itemLoteRowShow(ByVal lngNotaId As Long, ByVal lngItemId As Long)
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      Dim oDataTable As DataTable

      With oItemLote
         .SelectFilter = clsItemLote.SelectFilters.All
         .WhereFilter = clsItemLote.WhereFilters.NotaItemId
         .EmpresaId = moCompra.EmpresaId
         .NotaId = lngNotaId
         .ItemId = lngItemId

         If .Open() Then
            Dim oRow As DataRow
            oDataTable = moDataSetDet.Tables(clsItemLote.TABLE_NAME)

            Do While .Read()
               oRow = oDataTable.NewRow

               oRow("ItemLoteId") = .ItemLoteId
               oRow("ItemId") = .ItemId
               oRow("ItemLoteDes") = .ItemLoteDes
               oRow("SaldoOrg") = .SaldoOrg
               oRow("SaldoAct") = .SaldoAct
               oRow("FechaVen") = .FechaVen
               oRow("ItemLoteIdOrg") = .ItemLoteIdOrg
               oRow("Estado") = "Show"

               oDataTable.Rows.Add(oRow)
               .MoveNext()
            Loop
         End If
      End With

   End Sub

   Private Sub moDataSetInitLote(ByVal strTableName As String)
      Dim oDataTable As DataTable

      If moDataSetDet Is Nothing Then
         moDataSetDet = New DataSet("Tablas")
      End If

      If moDataSetDet.Tables.Contains(strTableName) Then
         moDataSetDet.Tables.Remove(strTableName)
      End If
      oDataTable = moDataSetDet.Tables.Add(strTableName)
      oDataTable.Columns.Add("ItemLoteId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("ItemLoteDes", Type.GetType("System.String"))
      oDataTable.Columns.Add("SaldoOrg", Type.GetType("System.Decimal"))
      oDataTable.Columns.Add("SaldoAct", Type.GetType("System.Decimal"))
      oDataTable.Columns.Add("FechaVen", Type.GetType("System.String"))
      oDataTable.Columns.Add("ItemLoteIdOrg", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("Estado", Type.GetType("System.String"))


      If Not moDataSetDet.Tables.Contains("DataDeleteLote") Then
         Dim oDataTable2 As DataTable
         oDataTable2 = moDataSetDet.Tables.Add("DataDeleteLote")
         oDataTable2.Columns.Add("ItemLoteId", Type.GetType("System.Int32"))
         oDataTable2.Columns.Add("ItemId", Type.GetType("System.Int32"))
         oDataTable2.Columns.Add("ItemLoteDes", Type.GetType("System.String"))
         oDataTable2.Columns.Add("SaldoOrg", Type.GetType("System.Decimal"))
         oDataTable2.Columns.Add("SaldoAct", Type.GetType("System.Decimal"))
         oDataTable2.Columns.Add("FechaVen", Type.GetType("System.String"))
         oDataTable2.Columns.Add("ItemLoteIdOrg", Type.GetType("System.Int32"))
         oDataTable2.Columns.Add("Estado", Type.GetType("System.String"))
      End If

   End Sub

   'Metodo que crea un DataTable para cargar los lotes de un item
   Private Function itemLoteRowFilter(ByVal lngItemId As Long) As DataTable
      Dim oDataTable As DataTable
      Dim oRow As DataRow

      Call moDataSetInitLote(clsItemLote.TABLE_NAME + "ITEM")
      oDataTable = moDataSetDet.Tables(clsItemLote.TABLE_NAME + "ITEM")

      For Each oDataRow As DataRow In moDataSetDet.Tables(clsItemLote.TABLE_NAME).Rows
         If oDataRow("ItemId") = lngItemId Then
            oRow = oDataTable.NewRow
            oRow("ItemLoteId") = oDataRow("ItemLoteId")
            oRow("ItemId") = oDataRow("ItemId")
            oRow("ItemLoteDes") = oDataRow("ItemLoteDes")
            oRow("SaldoOrg") = oDataRow("SaldoOrg")
            oRow("SaldoAct") = oDataRow("SaldoAct")
            oRow("FechaVen") = oDataRow("FechaVen")
            oRow("ItemLoteIdOrg") = oDataRow("ItemLoteIdOrg")
            oRow("Estado") = oDataRow("Estado")
            oDataTable.Rows.Add(oRow)
         End If
      Next

      itemLoteRowFilter = oDataTable
   End Function

   Private Sub itemLoteRowFill(ByVal lngItemId As Long)
      Dim oDataTable As DataTable
      Dim oRow As DataRow
      Dim lngItemLoteId As Decimal
      Call itemRowRemoveNew(clsItemLote.TABLE_NAME, lngItemId, "New")
      oDataTable = moDataSetDet.Tables(clsItemLote.TABLE_NAME)

      For Each oDataRow As DataRow In moDataSetDet.Tables(clsItemLote.TABLE_NAME + "ITEM").Rows
         If oDataRow("Estado") = "Edit" Or oDataRow("Estado") = "Show" Then
            lngItemLoteId = oDataRow("ItemLoteId")
            ItemLoteRowNewEdit(oDataTable.Rows(ItemLoteFindRowId(lngItemLoteId, clsItemLote.TABLE_NAME)), oDataRow)
         Else
            oRow = oDataTable.NewRow
            oRow("ItemLoteId") = oDataRow("ItemLoteId")
            oRow("ItemId") = oDataRow("ItemId")
            oRow("ItemLoteDes") = oDataRow("ItemLoteDes")
            oRow("SaldoOrg") = oDataRow("SaldoOrg")
            oRow("SaldoAct") = oDataRow("SaldoAct")
            oRow("FechaVen") = oDataRow("FechaVen")
            oRow("ItemLoteIdOrg") = oDataRow("ItemLoteIdOrg")
            oRow("Estado") = oDataRow("Estado")
            oDataTable.Rows.Add(oRow)
         End If
      Next

      itemLoteDeleteRowFill()
   End Sub

   Private Sub itemLoteDeleteRowFill()
      Dim oDataTable As DataTable
      Dim oDataTableLote As DataTable
      Dim oRow As DataRow
      Dim lngItemLoteId As Decimal
      'Call itemRowRemove(clsItemLote.TABLE_NAME, lngItemId)
      oDataTable = moDataSetDet.Tables("DataDeleteLote")
      oDataTableLote = moDataSetDet.Tables(clsItemLote.TABLE_NAME)

      For Each oDataRow As DataRow In moDataSetDet.Tables("DataDeleteLote" + "ITEM").Rows

         oRow = oDataTable.NewRow
         oRow("ItemLoteId") = oDataRow("ItemLoteId")
         oRow("ItemId") = oDataRow("ItemId")
         oRow("ItemLoteDes") = oDataRow("ItemLoteDes")
         oRow("SaldoOrg") = oDataRow("SaldoOrg")
         oRow("SaldoAct") = oDataRow("SaldoAct")
         oRow("FechaVen") = oDataRow("FechaVen")
         oRow("ItemLoteIdOrg") = oDataRow("ItemLoteIdOrg")
         oRow("Estado") = oDataRow("Estado")
         oDataTable.Rows.Add(oRow)

         oDataTableLote.Rows.RemoveAt(ItemLoteFindRowId(oRow("ItemLoteId"), clsItemLote.TABLE_NAME))

      Next
   End Sub

   'Metodo que elimina todos los registros de un item en la tabla que esten en NEW
   Private Sub itemRowRemoveNew(ByVal strTableName As String, ByVal lngItemId As Long, ByVal strEstado As String)
      Dim oDataTable As DataTable
      Dim index As Integer = 0
      oDataTable = moDataSetDet.Tables(strTableName)

      Do While index < oDataTable.Rows.Count
         Dim oRow As DataRow = oDataTable.Rows(index)
         If oRow("ItemId") = lngItemId And oRow("Estado") = strEstado Then
            oDataTable.Rows.RemoveAt(index)
         Else
            index += 1
         End If
      Loop

   End Sub

   Private Sub ItemLoteRowNewEdit(ByRef oRow As DataRow, ByRef oDataRow As DataRow)
      oRow("ItemLoteId") = oDataRow("ItemLoteId")
      oRow("ItemId") = oDataRow("ItemId")
      oRow("ItemLoteDes") = oDataRow("ItemLoteDes")
      oRow("SaldoOrg") = oDataRow("SaldoOrg")
      oRow("SaldoAct") = oDataRow("SaldoAct")
      oRow("FechaVen") = oDataRow("FechaVen")
      oRow("ItemLoteIdOrg") = oDataRow("ItemLoteIdOrg")
      oRow("Estado") = oDataRow("Estado")
   End Sub

   Private Function ItemLoteFindRowId(ByVal lngID As Long, ByVal strTableName As String) As Integer
      Dim intRow As Long = 0

      For Each oRow As DataRow In moDataSetDet.Tables(strTableName).Rows
         If oRow("ItemLoteId") = lngID Then
            Return intRow
         End If

         intRow += 1
      Next

      Return 0
   End Function

   'Metodo que devuelve una tabla de eliminados
   Private Function itemLoteTablaDelete() As DataTable
      Dim oDataTable As DataTable
      Dim oRow As DataRow

      Call moDataSetInitLote("DataDeleteLote" + "ITEM")
      oDataTable = moDataSetDet.Tables("DataDeleteLote" + "ITEM")
      itemLoteTablaDelete = oDataTable

   End Function

   ''Private Function itemLoteAdd  ''antes
   Private Function itemLoteAddUpdate(ByVal lngTipoNotaId As Integer, ByVal lngNotaId As Integer, ByVal lngNotaDetId As Integer, _
                              ByVal lngItemId As Long, ByVal lngAlmacenId As Integer) As Boolean

      ''itemLoteAdd(lngTipoNotaId, lngNotaId, lngNotaDetId, lngItemId, lngAlmacenId)
      ''ItemLoteUpdate(lngTipoNotaId, lngNotaId, lngNotaDetId, lngItemId, lngAlmacenId)
      itemLoteAddUpdate = True

      For Each oRow In moDataSetDet.Tables(clsItemLote.TABLE_NAME).Rows
         If oRow("ItemId") = lngItemId Then
            If oRow("Estado") = "New" Then
               itemLoteAdd(lngTipoNotaId, lngNotaId, lngNotaDetId, lngItemId, lngAlmacenId, oRow)
            ElseIf (oRow("Estado") = "Edit") Then
               ''ElseIf (oRow("Estado") = "Edit") Or (oRow("Estado") = "Show") Then
               ItemLoteUpdate(lngTipoNotaId, lngNotaId, lngNotaDetId, lngItemId, lngAlmacenId, oRow)
            End If

         End If
      Next

   End Function

   ''Private Function itemLoteAdd2  ''antes
   Private Function itemLoteAdd(ByVal lngTipoNotaId As Integer, ByVal lngNotaId As Integer, ByVal lngNotaDetId As Integer, _
                                ByVal lngItemId As Long, ByVal lngAlmacenId As Integer, ByVal oRow As DataRow) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      itemLoteAdd = True

      Try
         With oItemLote
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = lngAlmacenId
            .TipoNotaId = lngTipoNotaId
            .NotaId = lngNotaId
            .NotaDetId = lngNotaDetId
            .ItemId = lngItemId
            .ItemLoteDes = ToStr(oRow("ItemLoteDes"))
            .MedidaId = moCompraDet.MedidaId
            .SaldoOrg = ToDecimal(oRow("SaldoOrg"))
            .SaldoAct = 0
            .FechaVen = ToDate(oRow("FechaVen"))
            .ItemLoteIdOrg = 0
            .EstadoId = clsEstado.PENDIENTE

            If .Insert() Then
               If mboolControlSerie Then
                  Call cargarItemLoteIdEnSerie(.ItemLoteId, .ItemLoteDes, .ItemId)
               End If
               itemLoteAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         itemLoteAdd = False
      Finally
         oItemLote.Dispose()

      End Try
   End Function

   'Private Function ItemLoteUpdate(ByVal lngNotaId As Long, ByVal lngNotaDetId As Long) As Boolean
   Private Function ItemLoteUpdate(ByVal lngTipoNotaId As Integer, ByVal lngNotaId As Integer, ByVal lngNotaDetId As Integer, _
                          ByVal lngItemId As Long, ByVal lngAlmacenId As Integer, ByVal oRow As DataRow) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      ItemLoteUpdate = False

      Try
         With oItemLote
            .ItemLoteId = ToLong(oRow("ItemLoteId"))

            If .FindByPK Then
               .FechaVen = ToDate(.FechaVen)
               .EmpresaId = moCompra.EmpresaId
               .GestionId = moCompra.GestionId
               .AlmacenId = moCompraDet.AlmacenId
               .TipoNotaId = lngTipoNotaId
               .NotaId = lngNotaId
               .NotaDetId = lngNotaDetId
               .ItemId = lngItemId
               .ItemLoteDes = ToStr(oRow("ItemLoteDes"))
               .MedidaId = moCompraDet.MedidaId
               .SaldoOrg = ToDecimal(oRow("SaldoOrg"))
               '.SaldoAct = ToDecimal(oRow("SaldoAct"))
               .SaldoAct = .SaldoAct
               .FechaVen = ToDate(oRow("FechaVen"))
               .ItemLoteIdOrg = ToDecimal(oRow("ItemLoteIdOrg"))
               .EstadoId = clsEstado.PENDIENTE

               If .Update() Then
                  ItemLoteUpdate = ItemLoteDesUpdate(.ItemLoteId, .ItemLoteDes, lngTipoNotaId, lngNotaId, lngNotaDetId, lngItemId, lngAlmacenId)

                  ItemLoteUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   ''Private Function ItemLoteDelete2 antes
   Private Function itemLoteDelete(ByVal lngNotaId As Integer, ByVal lngNotaDetId As Integer) As Boolean
      If Not mboolNotaEditDelete Then
         Return True
      End If

      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      itemLoteDelete = True

      Try

         With oItemLote
            .WhereFilter = clsItemLote.WhereFilters.NotaDetId
            .EmpresaId = moCompra.EmpresaId
            .NotaId = lngNotaId
            .NotaDetId = lngNotaDetId

            If .Delete() Then
               itemLoteDelete = True
            End If
         End With


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   ''Private Function ItemLoteDelete3 antes
   Private Function ItemLoteDeleteById(ByVal lngLoteItemId As Long) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Try
         ItemLoteDeleteById = False

         With oItemLote
            .DeleteFilter = clsItemLote.DeleteFilters.PrimaryKey
            .WhereFilter = clsItemLote.WhereFilters.PrimaryKey
            .ItemLoteId = lngLoteItemId

            If .Delete Then
               ItemLoteDeleteById = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function itemLoteAnular(ByVal lngNotaId As Integer, ByVal lngNotaDetId As Integer) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      itemLoteAnular = True

      Try

         With oItemLote
            .SelectFilter = clsItemLote.SelectFilters.All
            .WhereFilter = clsItemLote.WhereFilters.NotaDetId
            .EmpresaId = moCompra.EmpresaId
            .NotaId = lngNotaId
            .NotaDetId = lngNotaDetId

            If .Open Then
               While .Read
                  .FechaVen = ToDate(.FechaVen)
                  .EstadoId = clsEstado.ANULADO

                  If .Update() Then
                     itemLoteAnular = True
                  End If
                  .MoveNext()
               End While
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   ''Validaciones
   Public Function ItemLoteCheckEliminados() As Boolean
      'Dim strMsg As String = String.Empty
      Dim oRow As DataRow

      Dim strMsg As String = String.Empty
      Dim decCantidad As Decimal
      Dim decCantidadOld As Decimal
      Dim decSaldoActual As Decimal
      Dim strMsgLote As String = String.Empty

      Dim lngNotaDetId As Long
      Dim lngNotaId As Long
      Dim boolNotaFind As Long

      'boolNotaFind = NotaFind(moCompra.TipoNotaId, moCompra.NotaNro, moCompra.SucursalId, lngNotaId)
      If moCompra.NotaId > 0 Then
         boolNotaFind = isNotaFind(moCompra.NotaId, 0, 0)
         lngNotaId = moCompra.NotaId
         boolNotaFind = True
      End If

      If lngNotaId > 0 Then

         For Each oRow In modtDelete.Rows

            Call ItemParametro(oRow("ItemId"))
            ''Call ItemSaldoParametro(oRow("ItemId"), moCompra.AlmacenId)

            If mboolControlLote Then
               lngNotaDetId = NotaDetIdFind(lngNotaId, oRow("ItemId"))
               If ItemLoteTieneMovAnulado(lngNotaId, lngNotaDetId) Then
                  strMsg &= ToStr(oRow("ItemDes")) & ", Lote(s) Eliminado(s) ya Tiene(n) Movimiento" & vbCrLf
               End If
            End If

            If mboolControlSerie Then
               If ItemNroSerieTieneMov(lngNotaId, oRow("ItemId")) Then
                  strMsg &= ToStr(oRow("ItemDes")) & ", Serie(s) Eliminado(s) ya Tiene(n) Movimiento" & vbCrLf
               End If
            End If

         Next

      End If


      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         ItemLoteCheckEliminados = False
      Else
         ItemLoteCheckEliminados = True
      End If
   End Function

   Private Function ItemLoteTieneMovAnulado(ByVal lngNotaId As Long, ByVal lngNotaDetId As Long) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)


      Try
         ItemLoteTieneMovAnulado = False

         With oItemLote
            .SelectFilter = clsItemLote.SelectFilters.All
            .WhereFilter = clsItemLote.WhereFilters.NotaDetId
            .EmpresaId = moCompra.EmpresaId
            .NotaId = lngNotaId
            .NotaDetId = lngNotaDetId

            If .Open Then
               Do While .Read
                  If .SaldoAct > 0 Then
                     ItemLoteTieneMovAnulado = True
                     Exit Do

                  ElseIf ItemLoteTieneMovimiento(.ItemLoteId) Then
                     ItemLoteTieneMovAnulado = True
                     Exit Do

                  End If

                  Call .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function ItemLoteTieneMovimiento(ByVal lngItemLoteId As Long) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Try
         With oItemLote
            .SelectFilter = clsItemLote.SelectFilters.All
            .WhereFilter = clsItemLote.WhereFilters.TieneItemLoteIdOrg
            .EmpresaId = moCompra.EmpresaId
            .ItemLoteIdOrg = lngItemLoteId

            If .Find Then
               Return True
            Else
               Return False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Public Function ItemSaldoLoteCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim oRow As DataRow
      Dim decCantidad As Decimal
      Dim decCantidadOld As Decimal
      Dim decSaldoActual As Decimal
      Dim decMedidaId As Decimal
      Dim strMsgLote As String = String.Empty

      For Each oRow In moDataSetDet.Tables(clsItemLote.TABLE_NAME).Rows
         If oRow("Estado") = "Edit" Or oRow("Estado") = "Show" Then
            Call ItemParametro(oRow("ItemId"))

            If mlngTipoItemId <> 2 Then 'Servicio
               Call ItemSaldoParametro(oRow("ItemId"), moCompra.AlmacenId)

               decCantidadOld = ItemLoteSaldoNuevoFind(oRow("ItemLoteId"), decMedidaId, oRow("SaldoOrg"))

               If decCantidadOld < 0 Then
                  'strMsg &= ToStr(oRow("ItemDes")) + ", Saldo Insuficiente, Cantidad en Stock : " + ToStr(decSaldoActual + decCantidadOld) & " " & ToStr(oRow("MedidaDes")) & vbCrLf
                  strMsg &= ToStr(oRow("ItemLoteDes")) + ", Saldo Insuficiente, Cantidad de lote : " + ToStr(decSaldoActual + decCantidadOld) & " " & vbCrLf
               End If
            End If
         End If
      Next


      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         ItemSaldoLoteCheck = False
      Else
         ItemSaldoLoteCheck = True
      End If
   End Function

   Private Function ItemLoteSaldoNuevoFind(ByVal lngItemLoteId As Long, ByRef lngMedidaId As Decimal, ByVal decSaldoOrg As Decimal) As Decimal
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      ItemLoteSaldoNuevoFind = 0

      Try
         With oItemLote
            .ItemLoteId = lngItemLoteId
            lngItemLoteId = 0

            If .FindByPK Then
               lngMedidaId = .MedidaId
               lngItemLoteId = .ItemLoteId
               Return ToDecimal(decSaldoOrg - .SaldoAct)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function ItemLoteDesUpdate(ByVal lngItemloteId As Long, ByVal strItemLoteDes As String, ByVal lngTipoNotaId As Integer, ByVal lngNotaId As Integer, ByVal lngNotaDetId As Integer, _
                          ByVal lngItemId As Long, ByVal lngAlmacenId As Integer) As Boolean
      If lngItemloteId = 0 Then
         Return True
      End If

      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      ItemLoteDesUpdate = False

      Try
         With oItemLote
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = moCompraDet.AlmacenId
            .TipoNotaId = lngTipoNotaId
            .NotaId = lngNotaId
            .NotaDetId = lngNotaDetId
            .ItemId = lngItemId

            .ItemLoteIdOrg = lngItemloteId
            .ItemLoteDes = strItemLoteDes
            .UpdateFilter = clsItemLote.UpdateFilters.LoteDesConIdOrg

            If .Update() Then
            End If

            ItemLoteDesUpdate = True
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function ItemLoteTieneMov(ByVal lngNotaId As Long, ByVal lngNotaDetId As Long) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Try
         ItemLoteTieneMov = False

         With oItemLote
            .SelectFilter = clsItemLote.SelectFilters.All
            .WhereFilter = clsItemLote.WhereFilters.NotaDetId
            .EmpresaId = moCompra.EmpresaId
            .NotaId = lngNotaId
            .NotaDetId = lngNotaDetId

            If .Open Then
               Do While .Read
                  If .SaldoAct > 0 Then
                     ItemLoteTieneMov = True
                     Exit Do
                  End If

                  Call .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

#End Region

#Region " ItemSerie"

   'Metodo que crea la estructura de la tabla de series
   Private Sub moDataSetInitSerie(ByVal strTableName As String)
      If moDataSetDet Is Nothing Then
         moDataSetDet = New DataSet("Tablas")
      End If

      Dim oDataTable As DataTable
      If moDataSetDet.Tables.Contains(strTableName) Then
         moDataSetDet.Tables.Remove(strTableName)
      End If
      oDataTable = moDataSetDet.Tables.Add(strTableName)
      oDataTable.Columns.Add("ItemNroSerieId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("ItemLoteId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("ItemLoteDes", Type.GetType("System.String"))
      oDataTable.Columns.Add("ItemNroSerieCod", Type.GetType("System.String"))
      oDataTable.Columns.Add("TipoNotaIdSal", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("NotaIdSal", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("ItemLoteIdSal", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("ItemNroSerieIdDev", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("AppId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("TipoDocumentoId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("DocumentoId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("DocumentoDetId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("Estado", Type.GetType("System.Byte"))
   End Sub

   Private Sub itemNroSerieRowShow(ByVal lngNotaId As Long, ByVal lngItemId As Long)
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      Dim oItemLote As clsItemLote
      Dim oDataTable As DataTable

      Try
         With oItemNroSerie
            .SelectFilter = clsItemNroSerie.SelectFilters.All
            .WhereFilter = clsItemNroSerie.WhereFilters.NotaIdEnt
            .OrderByFilter = clsItemNroSerie.OrderByFilters.ItemNroSerieId
            .EmpresaId = moCompra.EmpresaId
            .NotaIdEnt = lngNotaId
            .ItemId = lngItemId
            .EstadoId = moCompra.EstadoId

            If .Open() Then
               oDataTable = moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME)

               Do While .Read()
                  oRow = oDataTable.NewRow
                  oRow("ItemLoteId") = .ItemLoteId
                  oRow("ItemLoteIdSal") = .ItemLoteIdSal
                  oRow("TipoNotaIdSal") = .TipoNotaIdSal
                  oRow("NotaIdSal") = .NotaIdSal
                  oItemLote = itemLoteFindByPk(.ItemLoteId)
                  If Not oItemLote Is Nothing Then
                     oRow("ItemLoteDes") = oItemLote.ItemLoteDes
                  End If
                  oRow("ItemNroSerieId") = .ItemNroSerieId
                  oRow("ItemNroSerieCod") = .ItemNroSerieCod
                  oRow("ItemId") = .ItemId
                  oRow("ItemNroSerieIdDev") = .ItemNroSerieIdDev
                  oRow("AppId") = .AppId
                  oRow("TipoDocumentoId") = .TipoDocumentoId
                  oRow("DocumentoId") = .DocumentoId
                  oRow("DocumentoDetId") = .DocumentoDetId
                  oRow("Estado") = Constant.STATE_SHOW

                  oDataTable.Rows.Add(oRow)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemNroSerie.Dispose()
      End Try
   End Sub

   'Metodo que carga registros de series de un item en una estructura de DataTable
   Private Function itemNroSerieRowFilter(ByVal lngItemId As Long) As DataTable
      Dim oDataTable As DataTable
      Dim oRow As DataRow
      Call moDataSetInitSerie(clsItemNroSerie.TABLE_NAME + "ITEM")
      oDataTable = moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME + "ITEM")

      For Each oDataRow As DataRow In moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME).Rows
         If oDataRow("ItemId") = lngItemId Then
            oRow = oDataTable.NewRow
            oRow("ItemLoteId") = oDataRow("ItemLoteId")
            oRow("TipoNotaIdSal") = oDataRow("TipoNotaIdSal")
            oRow("NotaIdSal") = oDataRow("NotaIdSal")
            oRow("ItemLoteIdSal") = oDataRow("ItemLoteIdSal")
            oRow("ItemLoteDes") = oDataRow("ItemLoteDes")
            oRow("ItemNroSerieId") = oDataRow("ItemNroSerieId")
            oRow("ItemNroSerieCod") = oDataRow("ItemNroSerieCod")
            oRow("ItemId") = oDataRow("ItemId")
            oRow("ItemNroSerieIdDev") = oDataRow("ItemNroSerieIdDev")
            oRow("AppId") = oDataRow("AppId")
            oRow("TipoDocumentoId") = oDataRow("TipoDocumentoId")
            oRow("DocumentoId") = oDataRow("DocumentoId")
            oRow("DocumentoDetId") = oDataRow("DocumentoDetId")
            oRow("Estado") = oDataRow("Estado")
            oDataTable.Rows.Add(oRow)
         End If
      Next
      itemNroSerieRowFilter = oDataTable
   End Function

   Private Sub itemNroSerieRowFill(ByVal lngItemId As Long)
      Dim oDataTable As DataTable
      Dim oRow As DataRow

      Call itemRowRemove(clsItemNroSerie.TABLE_NAME, lngItemId)
      oDataTable = moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME)

      For Each oDataRow As DataRow In moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME + "ITEM").Rows
         If oDataRow("ItemId") = lngItemId Then
            oRow = oDataTable.NewRow
            oRow("ItemLoteId") = oDataRow("ItemLoteId")
            oRow("TipoNotaIdSal") = oDataRow("TipoNotaIdSal")
            oRow("NotaIdSal") = oDataRow("NotaIdSal")
            oRow("ItemLoteIdSal") = oDataRow("ItemLoteIdSal")
            oRow("ItemLoteDes") = oDataRow("ItemLoteDes")
            oRow("ItemNroSerieId") = oDataRow("ItemNroSerieId")
            oRow("ItemNroSerieCod") = oDataRow("ItemNroSerieCod")
            oRow("ItemId") = oDataRow("ItemId")
            oRow("ItemNroSerieIdDev") = oDataRow("ItemNroSerieIdDev")
            oRow("AppId") = oDataRow("AppId")
            oRow("TipoDocumentoId") = oDataRow("TipoDocumentoId")
            oRow("DocumentoId") = oDataRow("DocumentoId")
            oRow("DocumentoDetId") = oDataRow("DocumentoDetId")
            oRow("Estado") = oDataRow("Estado")
            oDataTable.Rows.Add(oRow)
         End If
      Next

   End Sub

   Private Sub cargarItemLoteIdEnSerie(ByVal lngItemLoteId As Long, ByVal strItemLoteDes As String, ByVal lngItemId As Long)
      For Each oRow As DataRow In moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME).Rows
         If oRow("ItemId") = lngItemId Then
            If oRow("ItemLoteDes") = strItemLoteDes Then
               oRow("ItemLoteId") = lngItemLoteId
            End If
         End If
      Next
   End Sub

   'Metodo que registra las series del item de compra
   Private Function itemNroSerieAdd(ByVal lngTipoNotaId As Integer, ByVal lngNotaId As Integer, ByVal lngItemId As Long) As Boolean
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      Dim lngItemNroSerieIdOrg As Long
      itemNroSerieAdd = False

      Try
         For Each oRow In moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME).Rows
            If oRow("ItemId") = lngItemId Then
               With oItemNroSerie
                  .EmpresaId = moCompra.EmpresaId
                  .GestionId = moCompra.GestionId
                  .AlmacenId = moCompra.AlmacenId
                  .ItemLoteId = ToLong(oRow("ItemLoteId"))
                  .ItemNroSerieId = ToLong(oRow("ItemNroSerieId"))
                  .ItemNroSerieCod = ToStr(oRow("ItemNroSerieCod"))
                  .TipoNotaIdEnt = lngTipoNotaId
                  .NotaIdEnt = lngNotaId
                  .ItemId = lngItemId
                  .TipoNotaIdSal = ToLong(oRow("TipoNotaIdSal"))
                  .NotaIdSal = ToLong(oRow("NotaIdSal"))
                  .ItemLoteIdSal = ToLong(oRow("ItemLoteIdSal"))
                  .ItemNroSerieIdDev = ToLong(oRow("ItemNroSerieIdDev"))
                  .AppId = ToLong(oRow("AppId"))
                  .TipoDocumentoId = ToLong(oRow("TipoDocumentoId"))
                  .DocumentoId = ToLong(oRow("DocumentoId"))
                  .DocumentoDetId = ToLong(oRow("DocumentoDetId"))
                  .EstadoId = clsEstado.ABIERTO

                  lngItemNroSerieIdOrg = ToLong(oRow("ItemNroSerieId"))

                  If .Insert() Then
                     Call ItemNroSerieUpdateDev(lngItemNroSerieIdOrg, .ItemNroSerieId, lngItemId)
                     itemNroSerieAdd = True
                  End If
               End With
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemNroSerie.Dispose()

      End Try
   End Function

   'Metodo que elimina todos los registros de un item en la tabla de series
   Private Sub itemRowRemove(ByVal strTableName As String, ByVal lngItemId As Long)
      Dim oDataTable As DataTable
      Dim index As Integer = 0
      oDataTable = moDataSetDet.Tables(strTableName)

      Do While index < oDataTable.Rows.Count
         Dim oRow As DataRow = oDataTable.Rows(index)
         If oRow("ItemId") = lngItemId Then
            oDataTable.Rows.RemoveAt(index)
         Else
            index += 1
         End If
      Loop

   End Sub

   Private Function itemNroSerieDelete(ByVal lngNotaId As Long, ByVal lngItemId As Long) As Boolean
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      itemNroSerieDelete = True

      Try
         With oItemNroSerie
            .DeleteFilter = clsItemNroSerie.DeleteFilters.All
            ''.WhereFilter = clsItemNroSerie.WhereFilters.NotaIdEnt
            .WhereFilter = clsItemNroSerie.WhereFilters.DeleteNotaIdEnt
            .EmpresaId = moCompra.EmpresaId
            .NotaIdEnt = lngNotaId
            .ItemId = lngItemId

            If .Delete() Then
               itemNroSerieDelete = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oItemNroSerie.Dispose()
      End Try

   End Function

   Private Function itemNroSerieAnular(ByVal lngNotaId As Long, ByVal lngItemId As Long) As Boolean
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim oRow As DataRow

      itemNroSerieAnular = False

      Try
         With oItemNroSerie
            .SelectFilter = clsItemNroSerie.SelectFilters.All
            .WhereFilter = clsItemNroSerie.WhereFilters.NotaIdEnt
            .EmpresaId = moCompra.EmpresaId
            .NotaIdEnt = lngNotaId
            .ItemId = lngItemId
            .EstadoId = moCompra.EstadoId

            If .Open Then
               While .Read
                  .EstadoId = clsEstado.ANULADO
                  If .Update() Then
                     itemNroSerieAnular = True
                  End If
                  .MoveNext()
               End While
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oItemNroSerie.Dispose()
      End Try

   End Function

   Private Function itemLoteFindByPk(ByVal intItemLoteId As Long) As clsItemLote
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      With oItemLote
         .ItemLoteId = intItemLoteId
         If Not .FindByPK Then
            Return Nothing
         End If
      End With
      Return oItemLote

   End Function

   Private Function ItemNroSerieTieneMov(ByVal lngNotaId As Long, ByVal lngItemId As Long) As Boolean
      Dim ItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)


      Try
         ItemNroSerieTieneMov = False

         With ItemNroSerie
            .SelectFilter = clsItemNroSerie.SelectFilters.All
            .WhereFilter = clsItemNroSerie.WhereFilters.TieneMovimiento
            .EmpresaId = moCompra.EmpresaId
            .NotaIdEnt = lngNotaId
            .ItemId = lngItemId

            If .Find Then
               Return True
            Else
               Return False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         ItemNroSerie.Dispose()

      End Try
   End Function

   Private Function ItemNroSerieUpdateDev(ByVal lngItemNroSerieId As Long, ByVal lngNroSerieIdNew As Long, _
                                          ByVal lngItemId As Long) As Boolean
      If lngItemNroSerieId = 0 Then
         Return True
      End If

      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      ItemNroSerieUpdateDev = False
      Try
         With oItemNroSerie
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = moCompra.AlmacenId
            .ItemId = lngItemId

            .ItemNroSerieIdDev = lngItemNroSerieId
            .ItemNroSerieId = lngNroSerieIdNew
            .UpdateFilter = clsItemNroSerie.UpdateFilters.ConSerieIdDev

            If .UpdateOnly() Then
            End If

            ItemNroSerieUpdateDev = True

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemNroSerie.Dispose()

      End Try
   End Function

#End Region

#Region "Pedidos"

   'Metodo que carga multiples pedidos a la Compra
   Private Sub cargarLstPedidos(ByVal lngCompraId As Long)
      Dim oVentaPedido As New clsCompraPedidoDet(clsAppInfo.ConnectString)
      mlstPedidos.Clear()
      Dim hstItems As Hashtable
      Try
         With oVentaPedido
            .SelectFilter = clsCompraPedidoDet.SelectFilters.All
            .WhereFilter = clsCompraPedidoDet.WhereFilters.CompraId
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .CompraId = lngCompraId

            If (.Open) Then
               Do While .Read
                  If (mlstPedidos.ContainsKey(.PedCompraId)) Then
                     Dim vecItem As Object() = {.Cantidad, .Cantidad}
                     hstItems.Add(.ItemId, vecItem)
                  Else
                     hstItems = New Hashtable
                     Dim vecItem As Object() = {.Cantidad, .Cantidad}
                     hstItems.Add(.ItemId, vecItem)
                     mlstPedidos.Add(.PedCompraId, hstItems)
                  End If
                  .MoveNext()
               Loop
            End If

         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oVentaPedido.Dispose()
      End Try
   End Sub

   Private Function pedidoCompraSelectAdd(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompraPedido As New clsCompraPedidoDet(clsAppInfo.ConnectString)

      Try
         For Each dicPedido As DictionaryEntry In mlstPedidos
            If pedidoCompraAdd(oCompraPedido, dicPedido.Key, dicPedido.Value, lngCompraId, lngEstadoId) Then
               pedidoCompraSelectAdd = True
            End If
         Next
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      Finally
         oCompraPedido.Dispose()
      End Try

   End Function

   Private Function pedidoCompraSelectUpdate(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompraPedido As New clsCompraPedidoDet(clsAppInfo.ConnectString)
      Try
         For Each dicPedido As DictionaryEntry In mlstPedidos
            If pedidoCompraUpdate(oCompraPedido, dicPedido.Key, dicPedido.Value, lngCompraId, lngEstadoId) Then
               pedidoCompraSelectUpdate = True
            End If
         Next
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      Finally
         oCompraPedido.Dispose()

      End Try
   End Function

   Private Function pedidoCompraAdd(ByVal oVentaPedido As clsCompraPedidoDet, ByVal lngPedido As Long, ByVal lstItems As Hashtable _
                                         , ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      With oVentaPedido
         .EmpresaId = clsAppInfo.EmpresaId
         .GestionId = clsAppInfo.GestionId
         .CompraId = lngCompraId
         .PedCompraId = lngPedido
         .EstadoId = lngEstadoId

         Dim vecItem As Object()

         For Each dicItem As DictionaryEntry In lstItems
            .ItemId = dicItem.Key
            vecItem = dicItem.Value
            .Cantidad = vecItem(0)

            If (.Insert) Then
               pedidoCompraAdd = True
            End If
         Next

      End With
   End Function

   Private Function pedidoCompraUpdate(ByVal oCompraPedido As clsCompraPedidoDet, ByVal lngPedido As Long, ByVal lstItems As Hashtable _
                                         , ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      With oCompraPedido
         .UpdateFilter = clsCompraPedidoDet.UpdateFilters.PedidoCompraItemId
         .WhereFilter = clsCompraPedidoDet.WhereFilters.PedidoCompraItemId
         .EmpresaId = clsAppInfo.EmpresaId
         .GestionId = clsAppInfo.GestionId
         .CompraId = lngCompraId
         .PedCompraId = lngPedido
         .EstadoId = lngEstadoId

         Dim vecItem As Object()

         For Each dicItem As DictionaryEntry In lstItems
            .ItemId = dicItem.Key
            vecItem = dicItem.Value
            .Cantidad = vecItem(0)

            If lngEstadoId = 12 Then
               .Cantidad = vecItem(1)
            End If

            If (.UpdateOnly) Then
               pedidoCompraUpdate = True
            End If
         Next

      End With
   End Function

   Private Function pedCompraUpdateList() As Boolean
      Dim lngPedCompraId As Long
      For Each dicPedido As DictionaryEntry In mlstPedidos
         lngPedCompraId = dicPedido.Key
         Call PedCompraUpdate(lngPedCompraId)
         pedCompraUpdateList = True
      Next
   End Function

   Private Function PedCompraUpdate(ByVal lngPedCompraId As Long) As Boolean
      Dim oPedVenta As New clsPedCompra(clsAppInfo.ConnectString)
      Dim oPedVentaDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim decCantidad, decCantidadEnt As Decimal
      Dim decMonto As Decimal

      PedCompraUpdate = False

      With oPedVenta

         .PedCompraId = lngPedCompraId

         If .FindByPK Then

            With oPedVentaDet

               .SelectFilter = clsPedCompraDet.SelectFilters.All
               .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraId
               .EmpresaId = oPedVenta.EmpresaId
               .PedCompraId = lngPedCompraId

               If .Find Then
                  decCantidad = 0
                  decCantidadEnt = 0

                  While .Read

                     .EstadoId = clsEstado.APROBADO ''clsEstado.PENDIENTE  'Pendiente

                     If .Cantidad = .CantidadEnt Then
                        .EstadoId = clsEstado.REALIZADO  'Realizado                        
                     ElseIf .CantidadEnt > 0 Then
                        .EstadoId = clsEstado.PARCIAL 'Parcial                        
                     End If

                     decCantidad += .Cantidad
                     decCantidadEnt += .CantidadEnt

                     .UpdateFilter = clsPedCompraDet.UpdateFilters.EstadoIdPK
                     If .Update Then
                        PedCompraUpdate = True
                     End If

                     .MoveNext()

                  End While
               End If
            End With

            '.EstadoId = IIf(decCantidadEnt = 0, clsEstado.PENDIENTE, IIf(decCantidad = decCantidadEnt, clsEstado.REALIZADO, clsEstado.PARCIAL))
            .EstadoId = IIf(decCantidadEnt = 0, clsEstado.APROBADO, IIf(decCantidad = decCantidadEnt, clsEstado.REALIZADO, clsEstado.PARCIAL))

            If .EstadoId = clsEstado.APROBADO Then
               .MontoEnt = 0
            Else
               decMonto = ImportePedidos(lngPedCompraId)
               If .MonedaId <> moCompra.MonedaId Then
                  If .MonedaId = 1 Then
                     decMonto = decMonto * moCompra.TipoCambio
                  ElseIf .MonedaId = 2 Then
                     decMonto = decMonto / ToDivByCero(moCompra.TipoCambio)
                  End If
               End If

               .MontoEnt += decMonto
            End If

            .Fecha = ToDate(.Fecha)
            .FechaEnt = ToDate(.FechaEnt)

            If .Update Then
               PedCompraUpdate = True
            End If

         End If

         .CloseConection()
      End With

   End Function

   Private Function PedVentaAnular() As Boolean

      Try
         PedVentaAnular = False

         For Each oRow In moDataTable.Rows
            If PedCompraCantidadEntUpdate(moCompra.AlmacenId, oRow("ItemId"), 0, oRow("CantAnterior")) Then
               PedVentaAnular = True
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function PedCompraCantidadEntUpdate(ByVal lngAlmacenId As Long, ByVal lngItemId As Long, ByVal decCantidad As Decimal _
                                                , ByVal decCantAnterior As Decimal) As Boolean

      Dim decTotal As Decimal
      Dim decCant As Decimal = decCantidad - decCantAnterior
      Dim decCantSum As Decimal

      If decCant > 0 Then 'Sumar Candidad de Entrada
         decTotal = CantidadItemPedCompra(lngAlmacenId, lngItemId)

         If decTotal >= decCantAnterior Then
            decTotal = decTotal - decCantAnterior

            If decCant > decTotal Then
               decCant = decTotal
            End If

            For Each dicPedido As DictionaryEntry In mlstPedidos
               If (decCant > 0) Then
                  Dim lngPedCompraId As Long = dicPedido.Key
                  Dim hstItems As Hashtable = dicPedido.Value
                  decCantSum = 0
                  Dim vecItem As Object() = hstItems.Item(lngItemId)
                  'si encontro el item
                  If Not (vecItem Is Nothing) Then
                     Call PedCompraDetCantidadEntSuma(lngPedCompraId, lngAlmacenId, lngItemId, decCant, decCantSum)

                     'Actualizar CompraPedidoDet
                     ''vecItem(0) = ToDecimal(vecItem(1)) + decCantSum
                     vecItem(0) = ToDecimal(vecItem(0)) + decCantSum
                     ''If mboolAdding Then   ''Si es Nuevo
                     ''   vecItem(0) = ToDecimal(vecItem(0)) + decCantSum
                     ''Else
                     ''   vecItem(0) = ToDecimal(vecItem(1)) + decCantSum
                     ''End If
                     ''vecItem(2) = "Edit"
                  End If
               Else
                  Exit For
               End If
            Next

         End If

      ElseIf decCant < 0 Then 'Restar Candidad de Entrada

         ''decTotal = CantidadItemPedCompra(lngAlmacenId, lngItemId)
         decTotal = CantidadItemPedidos(lngAlmacenId, lngItemId)

         If decTotal >= decCantidad Then
            decTotal = decCantAnterior - decTotal

            If decTotal > 0 Then
               decCant += decTotal
            End If

            'Pedidos
            For Each dicPedido As DictionaryEntry In mlstPedidos
               Dim lngPedCompraId As Long = dicPedido.Key
               Dim hstItems As Hashtable = dicPedido.Value

               decCant = Math.Abs(decCant)
               If (decCant > 0) Then

                  Dim vecItem As Object() = hstItems.Item(lngItemId)
                  'si encontro el item
                  If Not (vecItem Is Nothing) Then
                     Dim _decCantidad As Decimal = vecItem(0)
                     decCantSum = 0
                     Dim _decCant As Decimal = decCant

                     If (_decCantidad < decCant) Then
                        _decCant = _decCantidad
                     End If

                     Call PedCompraDetCantidadEntResta(lngPedCompraId, lngAlmacenId, lngItemId, _decCant, decCantSum)
                     decCant -= decCantSum

                     'Actualizar CompraPedidoDet
                     vecItem(0) -= decCantSum
                     ''vecItem(2) = "Edit"
                  End If

               Else
                  Exit For
               End If
            Next
         End If
      End If

   End Function

   Private Function CantidadItemPedCompra(ByVal lngAlmacenId As Long, ByVal lngItemId As Long) As Decimal
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      CantidadItemPedCompra = 0
      Try

         For Each dicPedido As DictionaryEntry In mlstPedidos
            Dim lngPedCompraId As Long = dicPedido.Key
            Dim hstItems As Hashtable = dicPedido.Value

            If Not (hstItems.Item(lngItemId) Is Nothing) Then
               With oPedCompraDet
                  .SelectFilter = clsPedCompraDet.SelectFilters.All
                  .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraItemId
                  .GestionId = moCompra.GestionId
                  .EmpresaId = moCompra.EmpresaId
                  .PedCompraId = lngPedCompraId
                  .ItemId = lngItemId
                  .AlmacenId = lngAlmacenId

                  If .Find Then
                     CantidadItemPedCompra += .Cantidad
                  End If
               End With
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPedCompraDet.Dispose()
      End Try

   End Function

   Private Function CantidadItemPedidos(ByVal lngAlmacenId As Long, ByVal lngItemId As Long) As Decimal
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim _decCantidad As Decimal = 0
      CantidadItemPedidos = 0
      Try

         For Each dicPedido As DictionaryEntry In mlstPedidos
            Dim lngPedCompraId As Long = dicPedido.Key
            Dim hstItems As Hashtable = dicPedido.Value

            If Not (hstItems.Item(lngItemId) Is Nothing) Then
               Dim vecItem As Object() = hstItems.Item(lngItemId)
               _decCantidad = vecItem(0)
               CantidadItemPedidos += _decCantidad

            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPedCompraDet.Dispose()
      End Try

   End Function

   Private Function PedCompraDetCantidadEntSuma(ByVal lngPedCompraId As Long, ByVal lngAlmacenId As Long, ByVal lngItemId As Long _
                                               , ByRef decCant As Decimal, ByRef decCantSum As Decimal) As Boolean
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim decCantSaldo As Decimal

      PedCompraDetCantidadEntSuma = False

      With oPedCompraDet
         .SelectFilter = clsPedCompraDet.SelectFilters.All
         .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraItemId
         .GestionId = moCompra.GestionId
         .EmpresaId = moCompra.EmpresaId
         .AlmacenId = lngAlmacenId
         .ItemId = lngItemId
         .PedCompraId = lngPedCompraId

         If .Find Then
            If .Cantidad > .CantidadEnt Then

               decCantSaldo = .Cantidad - .CantidadEnt
               If decCantSaldo >= decCant Then
                  .CantidadEnt += decCant
                  decCantSum = decCant
                  decCant = 0
               Else
                  .CantidadEnt += decCantSaldo
                  decCant -= decCantSaldo
                  decCantSum = decCantSaldo
               End If

               .UpdateFilter = clsPedCompraDet.UpdateFilters.CantidadEnt
               If .Update Then
                  PedCompraDetCantidadEntSuma = True
               End If
            End If
         End If

         .CloseConection()
      End With

   End Function

   Private Function PedCompraDetCantidadEntResta(ByVal lngPedCompraId As Long, ByVal lngAlmacenId As Long, ByVal lngItemId As Long _
                                              , ByRef decCant As Decimal, ByRef decCantSum As Decimal) As Boolean

      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim decCantEnt As Decimal

      PedCompraDetCantidadEntResta = False

      With oPedCompraDet
         .SelectFilter = clsPedCompraDet.SelectFilters.All
         .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraItemId
         .GestionId = moCompra.GestionId
         .EmpresaId = moCompra.EmpresaId
         .AlmacenId = lngAlmacenId
         .ItemId = lngItemId
         .PedCompraId = lngPedCompraId

         If .Find Then
            If .CantidadEnt > 0 Then

               decCantEnt = .CantidadEnt
               If decCantEnt >= decCant Then
                  .CantidadEnt -= decCant
                  decCantSum = decCant
                  decCant = 0

               Else
                  decCant -= decCantEnt
                  .CantidadEnt -= decCantEnt
                  decCantSum = decCantEnt
               End If

               .UpdateFilter = clsPedCompraDet.UpdateFilters.CantidadEnt
               If .Update Then
                  PedCompraDetCantidadEntResta = True
               End If

            End If
         End If

         .CloseConection()
      End With

   End Function

   Private Function PedCompraAnular() As Boolean

      Try
         PedCompraAnular = False

         For Each oRow In moDataTable.Rows
            If PedCompraCantidadEntUpdate(moCompra.AlmacenId, oRow("ItemId"), 0, oRow("CantidadAnt")) Then
               PedCompraAnular = True
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function ImportePedidos(ByVal lngPedidoId As Long) As Decimal
      Dim _decPrecio As Decimal = 0
      Dim oRow As DataRow

      ImportePedidos = 0
      Try

         Dim dicPedido As DictionaryEntry
         Dim lngItemId As Long
         Dim decImporte As Decimal
         Dim decImporteOld As Decimal
         Dim decImporteDel As Decimal

         Dim hstItems As Hashtable = mlstPedidos.Item(lngPedidoId)

         Dim vecItem As Object()
         For Each dicItem As DictionaryEntry In hstItems
            lngItemId = dicItem.Key
            vecItem = dicItem.Value

            ''Sumando los Eliminados
            oRow = DataTableRowFindId(lngItemId, modtDelete, "ItemId")
            If Not (oRow Is Nothing) Then
               _decPrecio = oRow("PrecioOrg") + oRow("PrecioRec") - oRow("PrecioDes")

               decImporteDel = vecItem(1) * _decPrecio
               ImportePedidos -= decImporteDel
            Else
               decImporteDel = 0
            End If

            ''Sumando los De la Tabla
            'oRow = (moDataTable.Rows(grdMainFindRowId(lngItemId)))
            oRow = DataTableRowFindId(lngItemId, moDataTable, "ItemId")
            If Not (oRow Is Nothing) Then
               _decPrecio = oRow("PrecioBru")

               decImporte = vecItem(0) * _decPrecio
               decImporteOld = vecItem(1) * _decPrecio

               If mboolEditing And (decImporteDel = 0) Then
                  decImporte = decImporte - decImporteOld
               End If

               ImportePedidos += decImporte
            End If
         Next

         ''ImportePedidos += decImporte

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try

   End Function

#End Region

#Region " Precios de Venta"

   Private moItemSaldo As clsItemSaldo

   Private Function ExistePrecioVenta(ByVal lngAlmacenId As Long, ByVal oTable As DataTable) As Boolean
      Dim oItemPrecio As New clsItemPrecio(clsAppInfo.ConnectString)
      ExistePrecioVenta = False

      Try
         With oItemPrecio
            .SelectFilter = clsItemPrecio.SelectFilters.ItemIdDistinct
            .WhereFilter = clsItemPrecio.WhereFilters.AlmacenId
            .EmpresaId = clsAppInfo.EmpresaId
            .AlmacenId = lngAlmacenId
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then
               If .DataSet.Tables(.TableName).Rows.Count > 0 Then
                  For Each oRow In oTable.Rows
                     If .DataSet.Tables(.TableName).Select("ItemId = " & ToStr(oRow("ItemId"))).Count > 0 Then ''Para todos los Items
                        ExistePrecioVenta = True
                        Exit For
                     End If
                  Next
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPrecio.Dispose()

      End Try
   End Function

#Region "Precios Estandar"
   ''Private Function grdMain_UpdateItemPrecio() As Boolean
   ''   grdMain_UpdateItemPrecio = False

   ''   'If mboolUpdatePrecioVen Then
   ''   If mboolActualizarPreciosVenta Then

   ''      Dim oItemSaldoNew As clsItemSaldo
   ''      Dim oItem As New clsItem(clsAppInfo.ConnectString)

   ''      Try

   ''         Dim boolUpdatePrecios As Boolean = False
   ''         Dim decPrecioUPC_Old, decPrecioUPC As Decimal
   ''         Dim decPrecio As Decimal
   ''         oItemSaldoNew = ItemSaldoFind(moCompra.AlmacenId)

   ''         For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
   ''            'If oRow("TipoItemId") = clsTipoItem.INVENTARIO Then ''Todos Los Items
   ''            If (oRow("TipoItemId") = clsTipoItem.INVENTARIO) And (oRow("TipoCosteoId") = clsTipoCosteo.UPC) Then
   ''               decPrecioUPC_Old = getItemPrecioCos(oRow("ItemId"), moItemSaldo.DataSet.Tables(0))
   ''               decPrecioUPC = getItemPrecioCos(oRow("ItemId"), oItemSaldoNew.DataSet.Tables(0))

   ''               decPrecio = ToDecimal(decPrecioUPC - decPrecioUPC_Old)
   ''               'If (decPrecio <> 0) And (decPrecioUPC_Old > 0) Then
   ''               If (decPrecio > 0) And (decPrecioUPC_Old > 0) Then ''Bateforte
   ''                  boolUpdatePrecios = True
   ''                  Exit For
   ''               End If
   ''            End If
   ''         Next

   ''         If boolUpdatePrecios Then
   ''            boolUpdatePrecios = False
   ''            ''Todos Los Items
   ''            'If MessageBox.Show("Desea Actualizar el UPC/PPP a todas las Listas de Precios? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
   ''            If MessageBox.Show("Desea Actualizar el UPC a todas las Listas de Precios? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
   ''               boolUpdatePrecios = True
   ''            End If

   ''            If boolUpdatePrecios Then

   ''               Dim decPrecioBs, decPrecioEquiBs As Decimal
   ''               Dim decPrecioUs, decPrecioEquiUs As Decimal
   ''               Dim decPrecioUPCBs, decPrecioUPCUs As Decimal

   ''               'oItemSaldoNew = ItemSaldoFind(moCompra.AlmacenId)

   ''               For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
   ''                  'If oRow("TipoItemId") = clsTipoItem.INVENTARIO Then ''Todos Los Items
   ''                  If (oRow("TipoItemId") = clsTipoItem.INVENTARIO) And (oRow("TipoCosteoId") = clsTipoCosteo.UPC) Then

   ''                     decPrecioUPC_Old = getItemPrecioCos(oRow("ItemId"), moItemSaldo.DataSet.Tables(0))
   ''                     decPrecioUPC = getItemPrecioCos(oRow("ItemId"), oItemSaldoNew.DataSet.Tables(0))
   ''                     'decPrecioUPC = oRow("PrecioCos")

   ''                     decPrecio = ToDecimal(decPrecioUPC - decPrecioUPC_Old)

   ''                     'If (decPrecio <> 0) And (decPrecioUPC_Old > 0) Then
   ''                     If (decPrecio > 0) And (decPrecioUPC_Old > 0) Then ''Bateforte
   ''                        oItem.ItemId = oRow("ItemId")

   ''                        If oItem.FindByPK Then
   ''                           If oItem.MonedaIdCos = 1 Then
   ''                              decPrecioBs = decPrecio
   ''                              decPrecioUs = ToDecimal(decPrecio / moCompra.TipoCambio)

   ''                              decPrecioUPCBs = decPrecioUPC
   ''                              decPrecioUPCUs = ToDecimal(decPrecioUPC / moCompra.TipoCambio)
   ''                           Else
   ''                              decPrecioBs = ToDecimal(decPrecio * moCompra.TipoCambio)
   ''                              decPrecioUs = decPrecio

   ''                              decPrecioUPCBs = ToDecimal(decPrecioUPC * moCompra.TipoCambio)
   ''                              decPrecioUPCUs = decPrecioUPC
   ''                           End If

   ''                           If oItem.MedidaId <> oItem.MedidaIdEqui Then
   ''                              decPrecioEquiBs = ToDecimal(decPrecioBs * oItem.MedidaCantEqui)
   ''                              decPrecioEquiUs = ToDecimal(decPrecioUs * oItem.MedidaCantEqui)
   ''                           Else
   ''                              decPrecioEquiBs = decPrecioBs
   ''                              decPrecioEquiUs = decPrecioUs
   ''                           End If

   ''                           ItemPrecioUpdate(oRow("ItemId"), decPrecioBs, decPrecioEquiBs, decPrecioUs, decPrecioEquiUs, decPrecioUPCBs, decPrecioUPCUs)
   ''                        End If
   ''                     End If
   ''                  End If
   ''               Next

   ''            End If
   ''         End If
   ''      Catch exp As Exception
   ''         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   ''         Return False
   ''      Finally
   ''         oItem.Dispose()
   ''      End Try
   ''   End If
   ''End Function

   ''Private Function ItemPrecioUpdate(ByVal lngItemId As Long, _
   ''                                  ByRef decPrecioBs As Decimal, ByRef decPrecioEquiBs As Decimal, _
   ''                                  ByVal decPrecioUs As Decimal, ByVal decPrecioEquiUs As Decimal, _
   ''                                  ByVal decPrecioCosBs As Decimal, ByVal decPrecioCosUs As Decimal) As Boolean
   ''   Dim oItemPrecio As New clsItemPrecio(clsAppInfo.ConnectString)
   ''   Dim decPrecio, decPrecioEqui, decPrecioCos As Decimal
   ''   Dim decPrecioNew, decPrecioEquiNew As Decimal
   ''   Dim decValor, decValorEqui As Decimal

   ''   ItemPrecioUpdate = True

   ''   Try
   ''      With oItemPrecio
   ''         .SelectFilter = clsItemPrecio.SelectFilters.All
   ''         .WhereFilter = clsItemPrecio.WhereFilters.ItemId

   ''         .EmpresaId = moCompra.EmpresaId
   ''         .AlmacenId = moCompra.AlmacenId
   ''         .ItemId = lngItemId
   ''         .EstadoId = clsEstado.ACTIVO

   ''         If .Open() Then

   ''            While .Read()

   ''               If .MonedaId = 1 Then
   ''                  .Precio += decPrecioBs
   ''                  .PrecioEqui += decPrecioEquiBs

   ''                  decPrecioCos = decPrecioCosBs

   ''               Else
   ''                  .Precio += decPrecioUs
   ''                  .PrecioEqui += decPrecioEquiUs

   ''                  decPrecioCos = decPrecioCosUs
   ''               End If

   ''               .Porcentaje = ToDecimal(((.Precio - decPrecioCos) * 100) / ToDivByCero(decPrecioCos))

   ''               If (.Precio > 0) And (.PrecioEqui > 0) Then
   ''                  .UpdateFilter = clsItemPrecio.UpdateFilters.Precio
   ''                  If .Update Then
   ''                     ItemPrecioUpdate = True
   ''                  End If
   ''               End If

   ''               .MoveNext()
   ''            End While
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oItemPrecio.Dispose()
   ''   End Try
   ''End Function

   '' Para Bateforte
#End Region

#Region "Precios Bateforte 15-05-2017"
   ''El siguiente codigo esta quemado para lista de Precios de Bateforte tal como solicitan en el correo de Fecha 10-05-2017
   Private Function grdMain_UpdateItemPrecio() As Boolean
      grdMain_UpdateItemPrecio = False

      'If mboolUpdatePrecioVen Then
      If mboolActualizarPreciosVenta Then

         Dim oItemSaldoNew As clsItemSaldo
         Dim oItem As New clsItem(clsAppInfo.ConnectString)

         Try

            Dim boolUpdatePrecios As Boolean = False
            Dim decPrecioUPC_Old, decPrecioUPC As Decimal
            Dim decPrecio As Decimal
            oItemSaldoNew = ItemSaldoFind(moCompra.AlmacenId)

            For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
               'If oRow("TipoItemId") = clsTipoItem.INVENTARIO Then ''Todos Los Items
               If (oRow("TipoItemId") = clsTipoItem.INVENTARIO) And (oRow("TipoCosteoId") = clsTipoCosteo.UPC) Then
                  decPrecioUPC_Old = getItemPrecioCos(oRow("ItemId"), moItemSaldo.DataSet.Tables(0))
                  decPrecioUPC = getItemPrecioCos(oRow("ItemId"), oItemSaldoNew.DataSet.Tables(0))

                  decPrecio = ToDecimal(decPrecioUPC - decPrecioUPC_Old)
                  'If (decPrecio <> 0) And (decPrecioUPC_Old > 0) Then
                  'If (decPrecio > 0) And (decPrecioUPC_Old > 0) Then ''Bateforte
                  If (decPrecioUPC_Old > 0) Then ''Bateforte
                     boolUpdatePrecios = True
                     Exit For
                  End If
               End If
            Next

            If boolUpdatePrecios Then
               boolUpdatePrecios = False
               ''Todos Los Items
               'If MessageBox.Show("Desea Actualizar el UPC/PPP a todas las Listas de Precios? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               If MessageBox.Show("Desea Actualizar el UPC a todas las Listas de Precios? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  boolUpdatePrecios = True
               End If

               If boolUpdatePrecios Then

                  Dim decPrecioBs, decPrecioEquiBs As Decimal
                  Dim decPrecioUs, decPrecioEquiUs As Decimal
                  Dim decPrecioUPCBs, decPrecioUPCUs As Decimal

                  'oItemSaldoNew = ItemSaldoFind(moCompra.AlmacenId)

                  For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
                     'If oRow("TipoItemId") = clsTipoItem.INVENTARIO Then ''Todos Los Items
                     If (oRow("TipoItemId") = clsTipoItem.INVENTARIO) And (oRow("TipoCosteoId") = clsTipoCosteo.UPC) Then

                        decPrecioUPC_Old = getItemPrecioCos(oRow("ItemId"), moItemSaldo.DataSet.Tables(0))
                        decPrecioUPC = getItemPrecioCos(oRow("ItemId"), oItemSaldoNew.DataSet.Tables(0))
                        'decPrecioUPC = oRow("PrecioCos")

                        decPrecio = ToDecimal(decPrecioUPC - decPrecioUPC_Old)

                        'If (decPrecio <> 0) And (decPrecioUPC_Old > 0) Then
                        'If (decPrecio > 0) And (decPrecioUPC_Old > 0) Then ''Bateforte
                        If (decPrecioUPC_Old > 0) Then ''Bateforte

                           decPrecio = ToDecimal(decPrecioUPC) ''Bateforte Precio de la Compra Nuevo
                           oItem.ItemId = oRow("ItemId")

                           If oItem.FindByPK Then
                              If oItem.MonedaIdCos = 1 Then
                                 decPrecioBs = decPrecio
                                 decPrecioUs = ToDecimal(decPrecio / moCompra.TipoCambio)

                                 decPrecioUPCBs = decPrecioUPC
                                 decPrecioUPCUs = ToDecimal(decPrecioUPC / moCompra.TipoCambio)
                              Else
                                 decPrecioBs = ToDecimal(decPrecio * moCompra.TipoCambio)
                                 decPrecioUs = decPrecio

                                 decPrecioUPCBs = ToDecimal(decPrecioUPC * moCompra.TipoCambio)
                                 decPrecioUPCUs = decPrecioUPC
                              End If

                              If oItem.MedidaId <> oItem.MedidaIdEqui Then
                                 decPrecioEquiBs = ToDecimal(decPrecioBs * oItem.MedidaCantEqui)
                                 decPrecioEquiUs = ToDecimal(decPrecioUs * oItem.MedidaCantEqui)
                              Else
                                 decPrecioEquiBs = decPrecioBs
                                 decPrecioEquiUs = decPrecioUs
                              End If

                              ItemPrecioUpdate(oRow("ItemId"), decPrecioBs, decPrecioEquiBs, decPrecioUs, decPrecioEquiUs, decPrecioUPCBs, decPrecioUPCUs)
                           End If
                        End If
                     End If
                  Next

               End If
            End If
         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
         Finally
            oItem.Dispose()
         End Try
      End If
   End Function

   Private Function ItemPrecioUpdate(ByVal lngItemId As Long, _
                                     ByRef decPrecioBs As Decimal, ByRef decPrecioEquiBs As Decimal, _
                                     ByVal decPrecioUs As Decimal, ByVal decPrecioEquiUs As Decimal, _
                                     ByVal decPrecioCosBs As Decimal, ByVal decPrecioCosUs As Decimal) As Boolean
      Dim oItemPrecio As New clsItemPrecio(clsAppInfo.ConnectString)
      Dim decPrecio, decPrecioEqui, decPrecioCos As Decimal
      Dim decPrecioNew, decPrecioEquiNew As Decimal
      Dim decValor, decValorEqui As Decimal

      ItemPrecioUpdate = True

      Try
         With oItemPrecio
            .SelectFilter = clsItemPrecio.SelectFilters.All
            .WhereFilter = clsItemPrecio.WhereFilters.ItemId

            .EmpresaId = moCompra.EmpresaId
            .AlmacenId = moCompra.AlmacenId
            .ItemId = lngItemId
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then

               While .Read()

                  If .MonedaId = 1 Then

                     If (.Orden = 1) Or (.Orden = 3) Then ''100/0.57
                        .Precio = ToDecimal(decPrecioBs / 0.57)
                        .PrecioEqui = ToDecimal(decPrecioEquiBs / 0.57)

                     Else ''100/0.62 Lista de Precios 2,4,5.....
                        .Precio = ToDecimal(decPrecioBs / 0.62)
                        .PrecioEqui = ToDecimal(decPrecioEquiBs / 0.62)
                     End If

                     '.Precio = decPrecioBs
                     '.PrecioEqui = decPrecioEquiBs

                     decPrecioCos = decPrecioCosBs

                  Else

                     If .Orden = 1 Then ''100/0.57
                        .Precio = ToDecimal(decPrecioUs / 0.57)
                        .PrecioEqui = ToDecimal(decPrecioEquiUs / 0.57)

                     Else ''100/0.62 Lista de Precios 2,3,4,5.....
                        .Precio = ToDecimal(decPrecioUs / 0.62)
                        .PrecioEqui = ToDecimal(decPrecioEquiUs / 0.62)
                     End If

                     ''.Precio += decPrecioUs
                     ''.PrecioEqui += decPrecioEquiUs

                     decPrecioCos = decPrecioCosUs
                  End If

                  .Porcentaje = ToDecimal(((.Precio - decPrecioCos) * 100) / ToDivByCero(decPrecioCos))

                  If (.Precio > 0) And (.PrecioEqui > 0) Then
                     .UpdateFilter = clsItemPrecio.UpdateFilters.Precio
                     If .Update Then
                        ItemPrecioUpdate = True
                     End If
                  End If

                  .MoveNext()
               End While
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPrecio.Dispose()
      End Try
   End Function

#End Region

   Private Function ItemSaldoFind(ByVal lngAlmacenId As Long) As clsItemSaldo
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)
      ItemSaldoFind = Nothing

      Try
         With oItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.AlmacenSaldo
            .WhereFilter = clsItemSaldo.WhereFilters.AlmacenSaldoAll
            .OrderByFilter = clsItemSaldo.OrderByFilters.ItemSaldoId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = lngAlmacenId

            If .Open() Then
               Return oItemSaldo
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemSaldo.Dispose()

      End Try
   End Function

   Private Function getItemPrecioCos(ByVal lngItemId As Long, ByVal oTable As DataTable) As Decimal

      Try
         getItemPrecioCos = 0
         For Each oRow In oTable.Select("ItemId = " & lngItemId)
            If oRow("TipoCosteoId") = clsTipoCosteo.PPP Then
               getItemPrecioCos = oRow("PrecioPPP")
            Else
               getItemPrecioCos = oRow("PrecioUPC")
            End If
            Exit For
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Function

#End Region

#Region " Retenciones "

   Private Function isRetencionAsuEmp(ByVal lngTipoRetencionId As Long) As Boolean
      If (lngTipoRetencionId = 1) Or (lngTipoRetencionId = 2) Or (lngTipoRetencionId = 3) Then
         isRetencionAsuEmp = True
      Else
         isRetencionAsuEmp = False
      End If
   End Function

   Private Function isRetencionAsuProv(ByVal lngTipoRetencionId As Long) As Boolean
      If (lngTipoRetencionId = 4) Or (lngTipoRetencionId = 5) Or (lngTipoRetencionId = 6) Then
         isRetencionAsuProv = True
      Else
         isRetencionAsuProv = False
      End If
   End Function

   Private Function RetencionCalc(ByVal lngTipoRetencionId As Long, ByVal decMonto As Decimal, ByRef decRetencionIUE_IT As Decimal, ByRef decIUE As Decimal, _
                                      ByRef decIT As Decimal) As Decimal

      Dim decPorcentajeRet As Decimal
      Dim decIUEOrg As Decimal = 0
      Dim decITOrg As Decimal = 0
      Dim decRetencionIUE_ITOrg As Decimal = 0

      If lngTipoRetencionId = 1 Then
         'Por Servicios Asume Empresa

         decPorcentajeRet = 1 - clsAppInfo.IUE_Servicios - clsAppInfo.IT '' 0.845
         decRetencionIUE_ITOrg = ToDecimal(decMonto / decPorcentajeRet)

         decIUEOrg = ToDecimal(decRetencionIUE_ITOrg * clsAppInfo.IUE_Servicios)
         decITOrg = ToDecimal(decRetencionIUE_ITOrg * clsAppInfo.IT)

      ElseIf lngTipoRetencionId = 2 Then
         'Por Bienes Asume Empresa
         decPorcentajeRet = 1 - clsAppInfo.IUE_Bienes - clsAppInfo.IT '' 0.92
         decRetencionIUE_ITOrg = ToDecimal(decMonto / decPorcentajeRet)

         decIUEOrg = ToDecimal(decRetencionIUE_ITOrg * clsAppInfo.IUE_Bienes)
         decITOrg = ToDecimal(decRetencionIUE_ITOrg * clsAppInfo.IT)

      ElseIf lngTipoRetencionId = 3 Then
         'Por Alquiler Asume Empresa
         decPorcentajeRet = 1 - clsAppInfo.IT - clsAppInfo.IVA '' 0.84
         decRetencionIUE_ITOrg = ToDecimal(decMonto / decPorcentajeRet)

         decIUEOrg = ToDecimal(decRetencionIUE_ITOrg * clsAppInfo.IVA)
         decITOrg = ToDecimal(decRetencionIUE_ITOrg * clsAppInfo.IT)

      ElseIf lngTipoRetencionId = 4 Then
         'Por Servicios Asume Provedor

         decIUEOrg = ToDecimal(decMonto * clsAppInfo.IUE_Servicios)
         decITOrg = ToDecimal(decMonto * clsAppInfo.IT)

         decRetencionIUE_ITOrg = decMonto - decIUEOrg + decITOrg
         RetencionCalc = decIUEOrg + decITOrg

      ElseIf lngTipoRetencionId = 5 Then
         'Por Bienes Asume Provedor
         decIUEOrg = ToDecimal(decMonto * clsAppInfo.IUE_Bienes)
         decITOrg = ToDecimal(decMonto * clsAppInfo.IT)

         decRetencionIUE_ITOrg = decMonto - decIUEOrg + decITOrg
         RetencionCalc = decIUEOrg + decITOrg

      ElseIf lngTipoRetencionId = 6 Then
         'Por Bienes Asume Provedor
         decIUEOrg = ToDecimal(decMonto * clsAppInfo.IVA)
         decITOrg = ToDecimal(decMonto * clsAppInfo.IT)

         decRetencionIUE_ITOrg = decMonto - decIUEOrg + decITOrg
         RetencionCalc = decIUEOrg + decITOrg
      End If

      decIUE = decIUEOrg
      decIT = decITOrg
      decRetencionIUE_IT = decRetencionIUE_ITOrg

   End Function

   Private Function TipoRetencionDesFind(ByVal lngTipoRetencionId As Long) As String
      Dim oTipoRetencion As New clsTipoRetencion(clsAppInfo.ConnectString)

      Try
         TipoRetencionDesFind = ""
         With oTipoRetencion
            .TipoRetencionId = lngTipoRetencionId

            If .FindByPK Then
               TipoRetencionDesFind = .TipoRetencionDes

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoRetencion.Dispose()

      End Try
   End Function

#End Region

   Private Sub cboCentroCosto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroCosto.SelectedIndexChanged
      If mboolAdding And clsAppInfo.CentroCostoApli Then
         txtCompraOrden.Text = GetCodNroOrden()
      End If

      If mboolAdding And (Not mboolShow) Then
         grdMainCentroCostoEdit(ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex))
      End If
   End Sub

   Private Sub cboProveedor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedor.ValueChanged
      If mboolAdding And clsAppInfo.CentroCostoApli Then
         txtCompraOrden.Text = GetCodNroOrden()
      End If
   End Sub

   Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
      Call txtTipoCambioLoad(ToDate(dtpFecha.Value))
   End Sub

   Private Sub txtMontoRec_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoRec.KeyUp
      If txtMontoRec.ContainsFocus Then

         If ToDecimal(txtMontoRec.Text) <> ToDecimal(txtMontoRec.Tag) Then
            If mdecMontoOrg = 0 Then
               txtPorcentajeRec.Text = 0
               txtMontoRec.Text = 0
            Else
               txtPorcentajeRec.Text = ToDecStr((ToDouble(txtMontoRec.Text) * 100) / mdecMontoOrg)
            End If

            mdecMontoRec = ToDecimal(txtMontoRec.Text)

            Call grdRecargoLoad(mdecMontoRec)

            txtPorcentajeRec.Tag = txtPorcentajeRec.Text

         End If
      End If
   End Sub

   Private Sub txtPorcentajeRec_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPorcentajeRec.KeyUp
      If txtPorcentajeRec.ContainsFocus Then
         If ToDecimal(txtPorcentajeRec.Text) <> (txtPorcentajeRec.Tag) Then
            If (mdecMontoOrg = 0) Then
               txtPorcentajeRec.Text = 0
               mdecMontoRec = 0
            Else
               mdecMontoRec = ToDecimal(ToDecimal(txtPorcentajeRec.Text) * mdecMontoOrg / 100)
            End If

            Call grdRecargoLoad(mdecMontoRec)

            txtPorcentajeRec.Tag = txtPorcentajeRec.Text

         End If
      End If
   End Sub

   Private Sub txtMontoDes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoDes.KeyUp
      If txtMontoDes.ContainsFocus Then
         If ToDecimal(txtMontoDes.Text) <> ToDecimal(txtMontoDes.Tag) Then

            If mdecMontoOrg = 0 Then
               txtPorcentajeDes.Text = 0
               txtMontoDes.Text = 0
            Else
               txtPorcentajeDes.Text = ToDecStr((ToDecimal(txtMontoDes.Text) * 100) / mdecMontoOrg)
            End If

            mdecMontoDes = ToDouble(txtMontoDes.Text)

            Call grdDescuentoLoad(mdecMontoDes)

            txtPorcentajeDes.Tag = txtPorcentajeDes.Text

         End If
      End If
   End Sub

   Private Sub txtPorcentajeDes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPorcentajeDes.KeyUp

      If txtPorcentajeDes.ContainsFocus Then
         If ToDecimal(txtPorcentajeDes.Text) <> ToDecimal(txtPorcentajeDes.Tag) Then
            If mdecMontoOrg = 0 Then
               txtPorcentajeDes.Text = 0
               mdecMontoDes = 0
            Else
               mdecMontoDes = ToDecStr((ToDecimal(txtPorcentajeDes.Text) * mdecMontoOrg) / 100)
            End If

            Call grdDescuentoLoad(mdecMontoDes)

            txtPorcentajeDes.Tag = txtPorcentajeDes.Text

         End If
      End If
   End Sub

#Region "Numeracion Sucursal"

   Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged

      If mboolAdding Then
         If clsAppInfo.SucursalApli Then
            Dim lngSucursaId As Long = AlmacenSucursalIdFind(ListPosition(cboAlmacen, cboAlmacen.SelectedIndex))
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, lngSucursaId)

            Call CompraParaLoad(clsTipoCompra.COMPRA, clsAppInfo.GestionId, lngSucursaId)

         Else
            'mboolNroAutoSucursal = True
         End If

      End If
   End Sub

   Private Function AlmacenSucursalIdFind(ByVal lngAlmacenId As Long) As Long
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)

      AlmacenSucursalIdFind = 0

      Try
         With oAlmacen
            .AlmacenId = lngAlmacenId

            If .FindByPK Then
               Return .SucursalId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAlmacen.Dispose()

      End Try
   End Function

#End Region

   Private Sub frmCompraEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moCompra.CompraId
                  mboolChanged = True
                  mboolAdding = False
                  mboolEditing = True
                  chkConFac.Enabled = False

                  cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

                  'If MessageBox.Show("Compra Guardada Exitosamente" + vbCrLf + "¿Desea Imprimir la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  '   Call PrintReport()
                  'End If

                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            If mnuNew.Enabled Then
               If mboolAdding Or mboolEditing Then
                  Call grdMainNew()
               End If
            End If

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            If mnuEdit.Enabled Then
               If mboolAdding Or mboolEditing Then
                  Call grdMainEdit()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Delete) And (e.Shift = True) Then
            If mnuDelete.Enabled Then
               If mboolAdding Or mboolEditing Then
                  Call grdMainDelete()
               End If
            End If

         ElseIf (PedCompra.Enabled = Janus.Windows.UI.InheritableBoolean.True) And (e.KeyCode = Keys.F5) Then
            If mboolAdding Then
               Call frmPedCompraLoad()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompraEdit_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      moCompra.Dispose()
      moCompraDet.Dispose()
      Call ClearMemory()
   End Sub

End Class
