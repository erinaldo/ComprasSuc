Public Class frmPedCompraEdit
   Inherits System.Windows.Forms.Form

   Private moPedCompra As clsPedCompra
   Private moPedCompraDet As clsPedCompraDet
   Private mqueItem As New Queue

   Private mdecMontoOrg As Decimal
   Private mdecMontoRec As Decimal
   Private mdecMontoDes As Decimal
   Private mlngItemCant As Long

   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long

   Private mdecPrecioPPP As Decimal
   Private mdecPrecioUPC As Decimal
   Private mdecSaldoItem As Decimal

   Private mboolAprobadoAutoDoc As Boolean
   Private mboolAprobadoAutoDocEdit As Boolean
   Private mboolEditarAprobado As Boolean
   Private mlngEstadoIdPed As Long

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private modtDelete As DataTable

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditGrid As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents grbDesRec As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtPorcentajeDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPorcentajeRec As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtMontoDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtMontoRec As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoLiq As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cmdRealizarPedido1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents RealizarPedido As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents dtpFechaEnt As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents AprobarPedido As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CancelarAprobar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents AprobarPedido1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CancelarAprobar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CancelarRealizar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CancelarRealizar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents grpSucursal As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Friend WithEvents cboAlmacen As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblAlmacenOrg As System.Windows.Forms.Label
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

   WriteOnly Property DataObject() As clsPedCompra
      Set(ByVal Value As clsPedCompra)
         moPedCompra = Value
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
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
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
   Friend WithEvents Anular1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtMontoOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPedCompraObs As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPedCompraDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPedCompraNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPedCompraId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents chkProveedor As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtPedCompraOrden As Janus.Windows.GridEX.EditControls.EditBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedCompraEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpSucursal = New Janus.Windows.EditControls.UIGroupBox
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.lblSucursal = New System.Windows.Forms.Label
      Me.cboAlmacen = New Janus.Windows.EditControls.UIComboBox
      Me.lblAlmacenOrg = New System.Windows.Forms.Label
      Me.grbDesRec = New Janus.Windows.EditControls.UIGroupBox
      Me.txtPorcentajeDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtPorcentajeRec = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtMontoDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtMontoRec = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtMontoLiq = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtMontoOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtPedCompraObs = New Janus.Windows.GridEX.EditControls.EditBox
      Me.grpDatos = New Janus.Windows.EditControls.UIGroupBox
      Me.lblCentroCosto = New System.Windows.Forms.Label
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.chkProveedor = New Janus.Windows.EditControls.UICheckBox
      Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtPedCompraDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaEnt = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtPedCompraOrden = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.txtPedCompraNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtPedCompraId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
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
      Me.AprobarPedido1 = New Janus.Windows.UI.CommandBars.UICommand("AprobarPedido")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CancelarAprobar1 = New Janus.Windows.UI.CommandBars.UICommand("CancelarAprobar")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Anular1 = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.cmdRealizarPedido1 = New Janus.Windows.UI.CommandBars.UICommand("RealizarPedido")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CancelarRealizar1 = New Janus.Windows.UI.CommandBars.UICommand("CancelarRealizar")
      Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.SaveTemp = New Janus.Windows.UI.CommandBars.UICommand("SaveTemp")
      Me.Anular = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.RealizarPedido = New Janus.Windows.UI.CommandBars.UICommand("RealizarPedido")
      Me.AprobarPedido = New Janus.Windows.UI.CommandBars.UICommand("AprobarPedido")
      Me.CancelarAprobar = New Janus.Windows.UI.CommandBars.UICommand("CancelarAprobar")
      Me.CancelarRealizar = New Janus.Windows.UI.CommandBars.UICommand("CancelarRealizar")
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
      CType(Me.grbDesRec, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbDesRec.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(720, 171)
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
      Me.grdMain.Size = New System.Drawing.Size(720, 171)
      Me.grdMain.TabIndex = 15
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
      Me.bcgMain.Controls.Add(Me.grbDesRec)
      Me.bcgMain.Controls.Add(Me.ebrMain)
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
      Me.grpSucursal.Controls.Add(Me.lblAlmacenOrg)
      Me.grpSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpSucursal.Location = New System.Drawing.Point(8, 64)
      Me.grpSucursal.Name = "grpSucursal"
      Me.grpSucursal.Size = New System.Drawing.Size(736, 40)
      Me.grpSucursal.TabIndex = 8
      Me.grpSucursal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboSucursal
      '
      Me.cboSucursal.BackColor = System.Drawing.SystemColors.Info
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(452, 12)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.ReadOnly = True
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(276, 20)
      Me.cboSucursal.TabIndex = 10
      Me.cboSucursal.TabStop = False
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblSucursal
      '
      Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
      Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSucursal.Location = New System.Drawing.Point(384, 16)
      Me.lblSucursal.Name = "lblSucursal"
      Me.lblSucursal.Size = New System.Drawing.Size(64, 16)
      Me.lblSucursal.TabIndex = 214
      Me.lblSucursal.Text = "Sucursal"
      Me.lblSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
      Me.cboAlmacen.TabIndex = 9
      Me.cboAlmacen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblAlmacenOrg
      '
      Me.lblAlmacenOrg.BackColor = System.Drawing.Color.Transparent
      Me.lblAlmacenOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAlmacenOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblAlmacenOrg.Location = New System.Drawing.Point(8, 16)
      Me.lblAlmacenOrg.Name = "lblAlmacenOrg"
      Me.lblAlmacenOrg.Size = New System.Drawing.Size(80, 16)
      Me.lblAlmacenOrg.TabIndex = 210
      Me.lblAlmacenOrg.Text = "Almacén"
      '
      'grbDesRec
      '
      Me.grbDesRec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grbDesRec.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbDesRec.Controls.Add(Me.txtPorcentajeDes)
      Me.grbDesRec.Controls.Add(Me.txtPorcentajeRec)
      Me.grbDesRec.Controls.Add(Me.Label5)
      Me.grbDesRec.Controls.Add(Me.txtMontoDes)
      Me.grbDesRec.Controls.Add(Me.Label14)
      Me.grbDesRec.Controls.Add(Me.Label13)
      Me.grbDesRec.Controls.Add(Me.Label18)
      Me.grbDesRec.Controls.Add(Me.txtMontoRec)
      Me.grbDesRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbDesRec.Location = New System.Drawing.Point(252, 380)
      Me.grbDesRec.Name = "grbDesRec"
      Me.grbDesRec.Size = New System.Drawing.Size(280, 64)
      Me.grbDesRec.TabIndex = 18
      Me.grbDesRec.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtPorcentajeDes
      '
      Me.txtPorcentajeDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPorcentajeDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPorcentajeDes.FormatString = "##,##0.000"
      Me.txtPorcentajeDes.Location = New System.Drawing.Point(196, 36)
      Me.txtPorcentajeDes.Name = "txtPorcentajeDes"
      Me.txtPorcentajeDes.Size = New System.Drawing.Size(78, 20)
      Me.txtPorcentajeDes.TabIndex = 22
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
      Me.txtPorcentajeRec.Location = New System.Drawing.Point(196, 12)
      Me.txtPorcentajeRec.Name = "txtPorcentajeRec"
      Me.txtPorcentajeRec.Size = New System.Drawing.Size(78, 20)
      Me.txtPorcentajeRec.TabIndex = 20
      Me.txtPorcentajeRec.Text = "0,000"
      Me.txtPorcentajeRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPorcentajeRec.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPorcentajeRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label5.Location = New System.Drawing.Point(172, 12)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(19, 18)
      Me.Label5.TabIndex = 263
      Me.Label5.Text = "%"
      '
      'txtMontoDes
      '
      Me.txtMontoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoDes.FormatString = "##,##0.000"
      Me.txtMontoDes.Location = New System.Drawing.Point(88, 36)
      Me.txtMontoDes.Name = "txtMontoDes"
      Me.txtMontoDes.Size = New System.Drawing.Size(78, 20)
      Me.txtMontoDes.TabIndex = 21
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
      Me.Label13.Location = New System.Drawing.Point(172, 38)
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
      Me.txtMontoRec.TabIndex = 19
      Me.txtMontoRec.Text = "0,000"
      Me.txtMontoRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoRec.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      ExplorerBarGroup1.ContainerHeight = 172
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(8, 172)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(736, 204)
      Me.ebrMain.TabIndex = 14
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
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
      Me.UiGroupBox3.Location = New System.Drawing.Point(536, 380)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(208, 64)
      Me.UiGroupBox3.TabIndex = 23
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
      Me.txtMontoLiq.TabIndex = 25
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
      Me.txtMontoOrg.TabIndex = 24
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
      Me.UiGroupBox2.Controls.Add(Me.txtPedCompraObs)
      Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 380)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(240, 64)
      Me.UiGroupBox2.TabIndex = 16
      Me.UiGroupBox2.Text = "Observaciones"
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtPedCompraObs
      '
      Me.txtPedCompraObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPedCompraObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPedCompraObs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraObs.Location = New System.Drawing.Point(8, 16)
      Me.txtPedCompraObs.Multiline = True
      Me.txtPedCompraObs.Name = "txtPedCompraObs"
      Me.txtPedCompraObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtPedCompraObs.Size = New System.Drawing.Size(224, 40)
      Me.txtPedCompraObs.TabIndex = 17
      Me.txtPedCompraObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPedCompraObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.grpDatos.Controls.Add(Me.txtPedCompraDes)
      Me.grpDatos.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpDatos.Location = New System.Drawing.Point(8, 104)
      Me.grpDatos.Name = "grpDatos"
      Me.grpDatos.Size = New System.Drawing.Size(736, 64)
      Me.grpDatos.TabIndex = 11
      Me.grpDatos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCentroCosto.Location = New System.Drawing.Point(372, 14)
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Size = New System.Drawing.Size(76, 16)
      Me.lblCentroCosto.TabIndex = 243
      Me.lblCentroCosto.Text = "C. C."
      Me.lblCentroCosto.TextAlign = System.Drawing.ContentAlignment.TopRight
      Me.lblCentroCosto.Visible = False
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.WindowFrame
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(452, 12)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(276, 20)
      Me.cboCentroCosto.TabIndex = 12
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
      Me.chkProveedor.TabIndex = 9
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
      Me.Label1.Text = "Descripción"
      '
      'txtPedCompraDes
      '
      Me.txtPedCompraDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPedCompraDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraDes.Location = New System.Drawing.Point(92, 36)
      Me.txtPedCompraDes.MaxLength = 1000
      Me.txtPedCompraDes.Multiline = True
      Me.txtPedCompraDes.Name = "txtPedCompraDes"
      Me.txtPedCompraDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtPedCompraDes.Size = New System.Drawing.Size(636, 20)
      Me.txtPedCompraDes.TabIndex = 13
      Me.txtPedCompraDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPedCompraDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.dtpFechaEnt)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.txtPedCompraOrden)
      Me.grpMain.Controls.Add(Me.Label8)
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.txtPedCompraNro)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.txtPedCompraId)
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
      'dtpFechaEnt
      '
      Me.dtpFechaEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.dtpFechaEnt.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaEnt.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaEnt.DropDownCalendar.Name = ""
      Me.dtpFechaEnt.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaEnt.Location = New System.Drawing.Point(248, 36)
      Me.dtpFechaEnt.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaEnt.Name = "dtpFechaEnt"
      Me.dtpFechaEnt.Size = New System.Drawing.Size(100, 20)
      Me.dtpFechaEnt.TabIndex = 4
      Me.dtpFechaEnt.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaEnt.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(180, 40)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(72, 16)
      Me.Label9.TabIndex = 211
      Me.Label9.Text = "Fecha Ent."
      '
      'txtPedCompraOrden
      '
      Me.txtPedCompraOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPedCompraOrden.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraOrden.Location = New System.Drawing.Point(628, 36)
      Me.txtPedCompraOrden.MaxLength = 50
      Me.txtPedCompraOrden.Name = "txtPedCompraOrden"
      Me.txtPedCompraOrden.Size = New System.Drawing.Size(100, 20)
      Me.txtPedCompraOrden.TabIndex = 8
      Me.txtPedCompraOrden.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPedCompraOrden.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(560, 40)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(72, 16)
      Me.Label8.TabIndex = 209
      Me.Label8.Text = "Nro. Orden"
      '
      'dtpFecha
      '
      Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFecha.DropDownCalendar.Name = ""
      Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFecha.Location = New System.Drawing.Point(248, 12)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
      Me.dtpFecha.TabIndex = 3
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
      Me.cboEstado.TabIndex = 2
      Me.cboEstado.TabStop = False
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      Me.cboMoneda.TabIndex = 5
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtPedCompraNro
      '
      Me.txtPedCompraNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPedCompraNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraNro.FormatString = "########"
      Me.txtPedCompraNro.Location = New System.Drawing.Point(628, 12)
      Me.txtPedCompraNro.Name = "txtPedCompraNro"
      Me.txtPedCompraNro.ReadOnly = True
      Me.txtPedCompraNro.Size = New System.Drawing.Size(100, 20)
      Me.txtPedCompraNro.TabIndex = 7
      Me.txtPedCompraNro.TabStop = False
      Me.txtPedCompraNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPedCompraNro.Value = 0
      Me.txtPedCompraNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtPedCompraNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(452, 36)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(101, 20)
      Me.txtTipoCambio.TabIndex = 6
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPedCompraId
      '
      Me.txtPedCompraId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPedCompraId.Location = New System.Drawing.Point(60, 12)
      Me.txtPedCompraId.Name = "txtPedCompraId"
      Me.txtPedCompraId.ReadOnly = True
      Me.txtPedCompraId.Size = New System.Drawing.Size(100, 20)
      Me.txtPedCompraId.TabIndex = 1
      Me.txtPedCompraId.TabStop = False
      Me.txtPedCompraId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPedCompraId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.Label11.Location = New System.Drawing.Point(368, 40)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(80, 16)
      Me.Label11.TabIndex = 199
      Me.Label11.Text = "Tipo Cambio"
      '
      'Label12
      '
      Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(572, 16)
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
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.SaveTemp, Me.Anular, Me.Print, Me.RealizarPedido, Me.AprobarPedido, Me.CancelarAprobar, Me.CancelarRealizar})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.AprobarPedido1, Me.Separator7, Me.CancelarAprobar1, Me.Separator6, Me.Anular1, Me.Separator2, Me.cmdRealizarPedido1, Me.Separator4, Me.CancelarRealizar1, Me.Separator8, Me.Print1, Me.Separator5, Me.Exit1, Me.Separator3})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(752, 28)
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
      'AprobarPedido1
      '
      Me.AprobarPedido1.Key = "AprobarPedido"
      Me.AprobarPedido1.Name = "AprobarPedido1"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
      '
      'CancelarAprobar1
      '
      Me.CancelarAprobar1.Key = "CancelarAprobar"
      Me.CancelarAprobar1.Name = "CancelarAprobar1"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'Anular1
      '
      Me.Anular1.Key = "Anular"
      Me.Anular1.Name = "Anular1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'cmdRealizarPedido1
      '
      Me.cmdRealizarPedido1.Key = "RealizarPedido"
      Me.cmdRealizarPedido1.Name = "cmdRealizarPedido1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'CancelarRealizar1
      '
      Me.CancelarRealizar1.Key = "CancelarRealizar"
      Me.CancelarRealizar1.Name = "CancelarRealizar1"
      '
      'Separator8
      '
      Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator8.Key = "Separator"
      Me.Separator8.Name = "Separator8"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Save
      '
      Me.Save.ImageIndex = 1
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
      'RealizarPedido
      '
      Me.RealizarPedido.ImageIndex = 8
      Me.RealizarPedido.Key = "RealizarPedido"
      Me.RealizarPedido.Name = "RealizarPedido"
      Me.RealizarPedido.Text = "Finalizar"
      '
      'AprobarPedido
      '
      Me.AprobarPedido.ImageIndex = 8
      Me.AprobarPedido.Key = "AprobarPedido"
      Me.AprobarPedido.Name = "AprobarPedido"
      Me.AprobarPedido.Text = "Aprobar Pedido"
      '
      'CancelarAprobar
      '
      Me.CancelarAprobar.ImageIndex = 6
      Me.CancelarAprobar.Key = "CancelarAprobar"
      Me.CancelarAprobar.Name = "CancelarAprobar"
      Me.CancelarAprobar.Text = "Cancelar Aprobación"
      '
      'CancelarRealizar
      '
      Me.CancelarRealizar.ImageIndex = 6
      Me.CancelarRealizar.Key = "CancelarRealizar"
      Me.CancelarRealizar.Name = "CancelarRealizar"
      Me.CancelarRealizar.Text = "Cancelar Finalización"
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
      Me.ilsMain.Images.SetKeyName(8, "check.ico")
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
      'frmPedCompraEdit
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
      Me.Name = "frmPedCompraEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Pedido de Compra"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpSucursal.ResumeLayout(False)
      CType(Me.grbDesRec, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbDesRec.ResumeLayout(False)
      Me.grbDesRec.PerformLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
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
               mlngID = moPedCompra.PedCompraId
               mboolChanged = True

               RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
               cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

               'If MessageBox.Show("Pedido de Compra Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Pedido de Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               '   Call PrintReport()
               'End If

               Me.Close()
            End If

         Case "Anular"
            Call PedCompraAnular()

         Case "AprobarPedido"
            Call PedCompraAprobar()

         Case "CancelarAprobar"
            Call PedCompraCancelarAprobar()

         Case RealizarPedido.Key
            Call RealizarPedCompra()

         Case "CancelarRealizar"
            Call CancelarRealizarPedCompra()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPedCompraEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPedCompraEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call ViewComponent()
      Call FormInit()
      Call ComboLoad()

      If Not mboolAdding Then
         Call FormShow()
         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta Pedido de Compra"
         Else
            Call HeaderReadOnly()
            Me.Text = "Editar Pedido de Compra"
         End If
      Else
         Me.Text = "Nuevo Pedido de Compra"
         Call FormNew()
      End If

      Call SecuritySet(Me, AppExeName)
      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

#Region " PedCompra "

   Private Sub FormShow()
      mboolShow = True
      With moPedCompra
         txtPedCompraId.Text = ToStr(.PedCompraId)
         dtpFecha.Text = ToStr(.Fecha)
         dtpFechaEnt.Text = ToStr(.FechaEnt)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, .AlmacenId)
         cboProveedor.Value = ListFindItem(cboProveedor, .ProveedorId)
         txtPedCompraNro.Text = ToStr(.PedCompraNro)
         txtPedCompraOrden.Text = ToStr(.PedCompraOrden)
         txtPedCompraDes.Text = ToStr(.PedCompraDes)
         txtPedCompraObs.Text = ToStr(.PedCompraObs)
         cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

         If .EstadoId = clsEstado.ANULADO Then
            cdmMain.Commands.Item("AprobarPedido").Enabled = Janus.Windows.UI.InheritableBoolean.False
            cdmMain.Commands.Item("CancelarAprobar").Enabled = Janus.Windows.UI.InheritableBoolean.False
            cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
            cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
            RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False

            mboolAdding = False
            mboolEditing = False
         End If
      End With

      Call grdMainLoad()

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moPedCompra
         txtPedCompraId.Text = String.Empty
         dtpFecha.Text = ToStr(.Fecha)
         dtpFechaEnt.Text = ToStr(.Fecha)
         'dtpFechaEnt.Text = String.Empty
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 13)
         txtTipoCambio.Text = "0"
         cboAlmacen.SelectedIndex = -1
         cboProveedor.Value = Nothing
         txtPedCompraNro.Text = "0"
         txtPedCompraOrden.Text = String.Empty
         txtPedCompraDes.Text = String.Empty
         txtPedCompraObs.Text = String.Empty
         cboCentroCosto.SelectedIndex = -1
         Call txtTipoCambioLoad(ToDate(dtpFecha.Value))

         cboEstado.ReadOnly = True

         mdecMontoOrg = 0
         mlngItemCant = 0

         If mboolAdding And clsAppInfo.CentroCostoApli Then
            txtPedCompraOrden.Text = "PC---"
         End If

         If clsAppInfo.SucursalApli Then
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)
            'cboSucursal.ReadOnly = False
            'mboolNroAutoSucursal = False
            CompraParaOrden(clsTipoCompra.PEDIDO, clsAppInfo.GestionId, IIf(.SucursalId = 0, clsAppInfo.SucursalId, .SucursalId))
         Else
            'mboolNroAutoSucursal = IIf(mboolAdding, False, True)
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, clsAppInfo.SucursalId)
            'cboSucursal.ReadOnly = True
            'mboolNroAutoSucursal = False
         End If

         Call grdMainLoad()
      End With
      mboolShow = False
   End Sub

   Private Sub ViewComponent()
      Dim decPosCC As Decimal = 0
      If clsAppInfo.SucursalApli Then
         lblSucursal.Visible = True
         cboSucursal.Visible = True
      Else
         lblSucursal.Visible = False
         cboSucursal.Visible = False
      End If

      If clsAppInfo.CentroCostoApli Then
         lblCentroCosto.Visible = True
         cboCentroCosto.Visible = True

      Else
         lblCentroCosto.Visible = False
         cboCentroCosto.Visible = False
         decPosCC = 24

         'grpDatos.Size = New System.Drawing.Size(736, 64)
         'Label1.Location = New System.Drawing.Point(8, 40)
         'txtPedCompraDes.Location = New System.Drawing.Point(92, 36)

         'ebrMain.Location = New System.Drawing.Point(8, 132)
         'ebrMain.Size = New System.Drawing.Size(736, 211)

      End If


   End Sub

   Private Sub DataReadOnly()
      txtPedCompraId.ReadOnly = True
      dtpFecha.ReadOnly = True
      dtpFechaEnt.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      cboAlmacen.ReadOnly = True
      cboProveedor.ReadOnly = True
      txtPedCompraNro.ReadOnly = True
      txtPedCompraOrden.ReadOnly = True
      txtPedCompraDes.ReadOnly = True
      txtPedCompraObs.ReadOnly = True
      txtMontoRec.ReadOnly = True
      txtMontoDes.ReadOnly = True
      txtPorcentajeRec.ReadOnly = True
      txtPorcentajeDes.ReadOnly = True
      cboCentroCosto.ReadOnly = True
      cboSucursal.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("AprobarPedido").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CancelarAprobar").Enabled = Janus.Windows.UI.InheritableBoolean.False
      RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CancelarRealizar").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CancelarRealizar").Visible = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   'Private Sub HeaderReadOnly()

   '   If moPedCompra.EstadoId = clsEstado.PENDIENTE Then
   '      txtPedCompraId.ReadOnly = True
   '      dtpFecha.ReadOnly = True
   '      ''dtpFechaEnt.ReadOnly = True 
   '      cboMoneda.ReadOnly = True
   '      cboEstado.ReadOnly = True
   '      txtTipoCambio.ReadOnly = True
   '      cboAlmacen.ReadOnly = True
   '      cboProveedor.ReadOnly = True
   '      txtPedCompraNro.ReadOnly = True
   '      cboCentroCosto.ReadOnly = True

   '      cdmMain.Commands.Item("AprobarPedido").Enabled = Janus.Windows.UI.InheritableBoolean.True
   '      cdmMain.Commands.Item("CancelarAprobar").Enabled = Janus.Windows.UI.InheritableBoolean.False
   '      RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False
   '      cdmMain.Commands.Item("CancelarRealizar").Enabled = Janus.Windows.UI.InheritableBoolean.False
   '      cdmMain.Commands.Item("CancelarRealizar").Visible = Janus.Windows.UI.InheritableBoolean.False
   '   Else

   '      Call DataReadOnly()

   '      If (moPedCompra.EstadoId = clsEstado.APROBADO) Then
   '         cdmMain.Commands.Item("CancelarAprobar").Enabled = Janus.Windows.UI.InheritableBoolean.True
   '         RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.True

   '      ElseIf (moPedCompra.EstadoId = clsEstado.PARCIAL) Then
   '         RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.True

   '      ElseIf (moPedCompra.EstadoId = clsEstado.REALIZADO) Then
   '         If (mlngEstadoIdPed = clsEstado.APROBADO) Or (mlngEstadoIdPed = clsEstado.PARCIAL) Then
   '            cdmMain.Commands.Item("CancelarRealizar").Enabled = Janus.Windows.UI.InheritableBoolean.True
   '         End If
   '      End If
   '   End If
   'End Sub

   Private Sub HeaderReadOnly()
      txtPedCompraId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      cboAlmacen.ReadOnly = True
      cboProveedor.ReadOnly = True
      txtPedCompraNro.ReadOnly = True
      cboCentroCosto.ReadOnly = True
      cboSucursal.ReadOnly = True

      cdmMain.Commands.Item("AprobarPedido").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CancelarAprobar").Enabled = Janus.Windows.UI.InheritableBoolean.False
      RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CancelarRealizar").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CancelarRealizar").Visible = Janus.Windows.UI.InheritableBoolean.False

      If moPedCompra.EstadoId = clsEstado.PENDIENTE Then
         cdmMain.Commands.Item("AprobarPedido").Enabled = Janus.Windows.UI.InheritableBoolean.True

      Else
         txtPedCompraOrden.ReadOnly = True
         txtMontoRec.ReadOnly = True
         txtMontoDes.ReadOnly = True
         txtPorcentajeRec.ReadOnly = True
         txtPorcentajeDes.ReadOnly = True
         mboolEditarAprobado = False

         'cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
         cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False

         mboolEditing = False
         mboolAdding = False

         If (moPedCompra.EstadoId = clsEstado.APROBADO) Then
            cdmMain.Commands.Item("CancelarAprobar").Enabled = Janus.Windows.UI.InheritableBoolean.True
            RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.True
            mboolEditarAprobado = IIf(mboolAprobadoAutoDocEdit, True, False)
            mboolEditing = mboolEditarAprobado

         ElseIf (moPedCompra.EstadoId = clsEstado.PARCIAL) Then
            RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.True
            mboolEditarAprobado = IIf(mboolAprobadoAutoDocEdit, True, False)
            mboolEditing = mboolEditarAprobado

         ElseIf (moPedCompra.EstadoId = clsEstado.REALIZADO) Then
            dtpFechaEnt.ReadOnly = True
            txtPedCompraDes.ReadOnly = True
            txtPedCompraObs.ReadOnly = True

            cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
            If (mlngEstadoIdPed = clsEstado.APROBADO) Or (mlngEstadoIdPed = clsEstado.PARCIAL) Then
               cdmMain.Commands.Item("CancelarRealizar").Enabled = Janus.Windows.UI.InheritableBoolean.True
               cdmMain.Commands.Item("CancelarRealizar").Visible = Janus.Windows.UI.InheritableBoolean.True
               cdmMain.Commands.Item("Anular").Visible = Janus.Windows.UI.InheritableBoolean.False
            End If
         End If

      End If

   End Sub

   Private Sub DataMove()
      With moPedCompra
         If Not mboolAdding Then
            .PedCompraId = ToLong(txtPedCompraId.Text)
         End If

         .Fecha = ToDate(dtpFecha.Value)
         .FechaEnt = ToDate(dtpFechaEnt.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .AlmacenId = ListPosition(cboAlmacen, cboAlmacen.SelectedIndex)
         .ProveedorId = ListPosition(cboProveedor)
         .PedCompraNro = ToLong(txtPedCompraNro.Text)
         .PedCompraOrden = ToStr(txtPedCompraOrden.Text)
         .PedCompraDes = ToStr(txtPedCompraDes.Text)
         .PedCompraObs = ToStr(txtPedCompraObs.Text)
         .PedCompraMonto = mdecMontoOrg
         .MontoRec = mdecMontoRec
         .MontoDes = mdecMontoDes
         .MontoLiq = mdecMontoOrg + mdecMontoRec - mdecMontoDes
         .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cdmMain.Commands.Item("AprobarPedido").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CancelarAprobar").Enabled = Janus.Windows.UI.InheritableBoolean.False
      RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CancelarRealizar").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CancelarRealizar").Visible = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.False

      dtpFecha.Select()
   End Sub

   Private Function DataSave() As Boolean
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long

      Try
         Call DataMove()

         If moPedCompra.Validate Then
            If grdMainCheck() Then
               If mboolAdding Then
                  moPedCompra.PedCompraNro = CompraNroNext(1, clsAppInfo.GestionId, moPedCompra.SucursalId)

                  If DataAdd() Then
                     If grdMainSave() Then
                        txtPedCompraId.Text = ToStr(moPedCompra.PedCompraId)
                        txtPedCompraNro.Text = ToStr(moPedCompra.PedCompraNro)
                        Call HeaderReadOnly()

                        If DataUpdate() Then
                           If mboolAprobadoAutoDoc Then
                              If PedCompraUpdateEstadoId(moPedCompra.PedCompraId, clsEstado.APROBADO) Then
                                 DataSave = True
                              End If
                           Else
                              Call grdMainEstadoShow()
                              DataSave = True
                           End If
                        End If
                     End If
                  End If

               ElseIf mboolEditing Then
                  If DataUpdate() Then
                     If grdMainSave() Then
                        Call grdMainEstadoShow()
                        DataSave = True
                     End If
                  End If
               Else
                  If DataUpdate() Then
                     DataSave = True
                  End If
               End If
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

         If moPedCompra.Insert() Then
            mboolAdding = False
            DataAdd = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moPedCompra.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function grdMainCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim oRow As DataRow
      Dim decCantidad As Decimal

        If cboSucursal.SelectedIndex = -1 Then
            grdMainCheck = False
            Throw New Exception("Revise La Sucursal")
        Else
            If CompSucursalApeExist(moPedCompra.EmpresaId, moPedCompra.GestionId, moPedCompra.SucursalId) Then
                If Not NotaSucursalApeExist(moPedCompra.EmpresaId, moPedCompra.GestionId, moPedCompra.SucursalId) Then
                    grdMainCheck = False
                    Throw New Exception("No hay Apertura de Parámetros de Notas en 'Inventario' para esta Sucursal")
                End If
            Else
                grdMainCheck = False
                Throw New Exception("No hay Apertura de Parámetros de Comprobantes en 'Contabilidad' para esta Sucursal")
            End If
        End If

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         grdMainCheck = False
         Throw New Exception("Fecha no Corresponde a la Gestion en Uso")
      End If

      ''If dtpFecha.Value > Now Then
      ''   grdMainCheck = False
      ''   Throw New Exception("Fecha no Valida, No puede ser mayor a la Actual")
      ''End If

      If clsAppInfo.CentroCostoApli Then
         If cboCentroCosto.SelectedIndex = -1 Then
            grdMainCheck = False
            Throw New Exception("Revise El Centro de Costo")
         End If

         If mboolAdding Then
            Dim strTexto As String = (txtPedCompraOrden.Text).Trim

            If txtPedCompraOrden.Text.Trim <> String.Empty Then
               If strTexto.Chars(strTexto.Length - 1) = "-" Then
                  Throw New Exception("Nro de Orden Incompleto")
               End If

            Else
               Throw New Exception("Nro de Orden Incompleto")
            End If
         End If

      End If

      If moDataSet.Tables(moPedCompraDet.TableName).Rows.Count = 0 Then
         strMsg &= "Pedido de Compra Sin Detalle"
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         grdMainCheck = False
      Else
         grdMainCheck = True
      End If
   End Function

   Private Function mqueItemExist(ByVal lngPlanId As Long) As Boolean
      mqueItemExist = False

      For Each lngId As Long In mqueItem
         If lngId = lngPlanId Then
            Return True
         End If
      Next
   End Function

   Private Function grdMainImporte(ByVal lngPlanId As Long) As Decimal
      Dim decImporte As Decimal = 0

      For Each oRow As DataRow In moDataSet.Tables(moPedCompraDet.TableName).Rows
         If oRow("PlanId") = lngPlanId Then
            decImporte = decImporte + oRow("Importe")
         End If
      Next

      Return decImporte
   End Function

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraNroNext = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moPedCompra.EmpresaId
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

   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
            .EmpresaId = moPedCompra.EmpresaId
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

      Call CompraParaOrden(clsTipoCompra.PEDIDO, clsAppInfo.GestionId, clsAppInfo.SucursalId)
      moPedCompraDet = New clsPedCompraDet(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboEstadoLoad()
      Call cboAlmacenLoad()
      Call cboProveedorLoad()
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

   Private Sub cboAlmacenLoad()
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboAlmacen.Items.Clear()

      Try
         With oAlmacen
            .SelectFilter = clsAlmacen.SelectFilters.ListBox
            .WhereFilter = clsAlmacen.WhereFilters.TipoAlmacenId
            .OrderByFilter = clsAlmacen.OrderByFilters.AlmacenDes
            .EmpresaId = moPedCompra.EmpresaId
            .TipoAlmacenId = clsTipoAlmacen.INVENTARIO
            .AlmacenId = moPedCompra.AlmacenId
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

   Private Sub cboProveedorLoad()
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oListItem As clsListItem

      cboProveedor.DropDownList.Columns.Clear()

      Try
         With oProveedor
            .SelectFilter = clsProveedor.SelectFilters.ListBox
            .WhereFilter = clsProveedor.WhereFilters.EstadoId
            .OrderByFilter = clsProveedor.OrderByFilters.ProveedorDes
            .EmpresaId = moPedCompra.EmpresaId
            .ProveedorId = moPedCompra.ProveedorId
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
            .CentroCostoId = moPedCompra.CentroCostoId

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
            .TipoCompraId = clsTipoCompra.PEDIDO

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

   Private Function GetCodNroOrden() As String
      Dim strTexto As String

      strTexto = "PC-"
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

   Public Sub printPedidoReport()
      If MessageBox.Show("Pedido de Compra Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Pedido de Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
            .EmpresaId = moPedCompra.EmpresaId
            .GestionId = moPedCompra.GestionId
            .TipoCompraId = clsTipoCompra.PEDIDO
            .SucursalId = moPedCompra.SucursalId

            If .Find Then

               If .TipoImpresionId = clsTipoImpresion.GRAPHIC Then 'Gráfica

                  oTipoFormImp.TipoFormImpId = .TipoFormImpId
                  If oTipoFormImp.FindByPK() Then

                     Select Case oTipoFormImp.TipoFormImpDes

                        Case "Zucar"  ''TipoFormImpId = 43 Then  'SOLO ZUCAR
                           Call PrintReportZucar()

                        Case "Pust"  ''TipoFormImpId = 49 Then  'SOLO PUST
                           Call PrintReportPust()

                        Case "GEU"  ''TipoFormImpId = 142 Then  'SOLO GEU 138
                           Call PrintReportGEU(oCompraPara)

                        Case "Bolland"  ''TipoFormImpId = 166 Then  'SOLO BOLLAND 166
                           Call PrintReportBolland(oCompraPara)

                        Case "SYS Import"  ''TipoFormImpId = 166 Then  'SOLO BOLLAND 166
                           Call PrintReportSYSImport(oCompraPara)

                        Case Else  ''TipoFormImpId = 42   'Impresion Estandar
                           Call PrintReportGraphic()

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
         MessageBox.Show(exp.Message, "Pedido de Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()
         oTipoFormImp.Dispose()

      End Try

   End Sub

   Private Sub PrintReportGraphic()
      Dim rpt As New rptPedCompraEdit
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim strTitulo As String
      Dim index = 1

      Try
         oPedCompra.SelectFilter = clsPedCompra.SelectFilters.Report
         oPedCompra.WhereFilter = clsPedCompra.WhereFilters.Report
         oPedCompra.OrderByFilter = clsPedCompra.OrderByFilters.Report
         oPedCompra.EmpresaId = moPedCompra.EmpresaId
         oPedCompra.PedCompraId = moPedCompra.PedCompraId

         If oPedCompra.Find Then

            For Each oRow In oPedCompra.DataSet.Tables(oPedCompra.TableName).Rows
               oRow("ItemNro") = index
               index += 1
            Next

            rpt.DataSource = oPedCompra.DataSet.Tables(oPedCompra.TableName).DefaultView

            rpt.txtFirma.Text = CompraParaFirma(1, moPedCompra.GestionId, moPedCompra.SucursalId, strTitulo, lngTipoHojaId)
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
               'frm.PrintReport()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub PrintReportZucar()
      Dim rpt As New rptPedCompraEditZucar
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim strTitulo As String

      Try
         oPedCompra.SelectFilter = clsPedCompra.SelectFilters.Report
         oPedCompra.WhereFilter = clsPedCompra.WhereFilters.Report
         oPedCompra.OrderByFilter = clsPedCompra.OrderByFilters.Report
         oPedCompra.EmpresaId = moPedCompra.EmpresaId
         oPedCompra.PedCompraId = moPedCompra.PedCompraId

         If oPedCompra.Find Then
            rpt.DataSource = oPedCompra.DataSet.Tables(oPedCompra.TableName).DefaultView

            rpt.txtFirma.Text = CompraParaFirma(1, moPedCompra.GestionId, moPedCompra.SucursalId, strTitulo, lngTipoHojaId)
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
               'frm.PrintReport()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub PrintReportPust()
      Dim rpt As New rptPedCompraEditPust
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim strTitulo As String

      Try
         oPedCompra.SelectFilter = clsPedCompra.SelectFilters.Report
         oPedCompra.WhereFilter = clsPedCompra.WhereFilters.Report
         oPedCompra.OrderByFilter = clsPedCompra.OrderByFilters.Report
         oPedCompra.EmpresaId = moPedCompra.EmpresaId
         oPedCompra.PedCompraId = moPedCompra.PedCompraId

         If oPedCompra.Find Then
            rpt.DataSource = oPedCompra.DataSet.Tables(oPedCompra.TableName).DefaultView

            rpt.txtFirma.Text = CompraParaFirma(1, moPedCompra.GestionId, moPedCompra.SucursalId, strTitulo, lngTipoHojaId)
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
               'frm.PrintReport()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub PrintReportGEU(ByVal oCompraPara As clsCompraPara)
      Dim rpt As New rptPedCompraEditGEU
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         oPedCompra.SelectFilter = clsPedCompra.SelectFilters.Report
         oPedCompra.WhereFilter = clsPedCompra.WhereFilters.Report
         oPedCompra.OrderByFilter = clsPedCompra.OrderByFilters.Report
         oPedCompra.EmpresaId = moPedCompra.EmpresaId
         oPedCompra.PedCompraId = moPedCompra.PedCompraId

         If oPedCompra.Find Then

            rpt.DataSource = oPedCompra.DataSet.Tables(oPedCompra.TableName).DefaultView

            rpt.txtFirma.Text = oCompraPara.Firma
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

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, oCompraPara.TipoHojaId)

            If (oCompraPara.TipoHojaId = 1) Or (oCompraPara.TipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As frmReportPreview
               frm = New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (oCompraPara.TipoHojaId = 2) Or (oCompraPara.TipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As frmReportPreviewMultiple
               frm = New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = oCompraPara.TipoHojaId
               frm.Show()
               'frm.PrintReport()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub PrintReportBolland(ByVal oCompraPara As clsCompraPara)
      Dim rpt As New rptPedCompraEditBolland
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim oEmpresa As clsEmpresa

      Try
         oPedCompra.SelectFilter = clsPedCompra.SelectFilters.Report
         oPedCompra.WhereFilter = clsPedCompra.WhereFilters.Report
         oPedCompra.OrderByFilter = clsPedCompra.OrderByFilters.Report
         oPedCompra.EmpresaId = moPedCompra.EmpresaId
         oPedCompra.PedCompraId = moPedCompra.PedCompraId

         If oPedCompra.Find Then

            rpt.DataSource = oPedCompra.DataSet.Tables(oPedCompra.TableName).DefaultView

            rpt.txtFirma.Text = oCompraPara.Firma
            rpt.lblTitle.Text = oCompraPara.Titulo
            rpt.Document.Name = oCompraPara.Titulo
            'rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            oEmpresa = EmpresaFind(clsAppInfo.EmpresaId)
            If Not oEmpresa Is Nothing Then
               rpt.lblEmpresaDes.Text = oEmpresa.EmpresaDes
               rpt.lblEmpresaRUC.Text = "NIT: " & oEmpresa.EmpresaRUC
               rpt.lblFax.Text = "Fax: " & oEmpresa.Fax
               rpt.lblTelefono.Text = "Teléfono: " & oEmpresa.Telefono1 & IIf(oEmpresa.Telefono2 <> String.Empty, " - " & oEmpresa.Telefono2, "")
               rpt.lblDireccion.Text = oEmpresa.Direccion
               'rpt.lblCorreo.Text = "Email: " & oEmpresa.Email
               rpt.txtCiudadDes.Text = CiudadDesFind(oEmpresa.CiudadId) & " - Bolivia"
            End If

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, oCompraPara.TipoHojaId)

            If (oCompraPara.TipoHojaId = 1) Or (oCompraPara.TipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As frmReportPreview
               frm = New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (oCompraPara.TipoHojaId = 2) Or (oCompraPara.TipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As frmReportPreviewMultiple
               frm = New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = oCompraPara.TipoHojaId
               frm.Show()
               'frm.PrintReport()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub PrintReportSYSImport(ByVal oCompraPara As clsCompraPara)
      Dim rpt As New rptPedCompraEditSYSImport
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim index = 1

      Try
         oPedCompra.SelectFilter = clsPedCompra.SelectFilters.Report
         oPedCompra.WhereFilter = clsPedCompra.WhereFilters.Report
         oPedCompra.OrderByFilter = clsPedCompra.OrderByFilters.Report
         oPedCompra.EmpresaId = moPedCompra.EmpresaId
         oPedCompra.PedCompraId = moPedCompra.PedCompraId

         If oPedCompra.Find Then

            For Each oRow In oPedCompra.DataSet.Tables(oPedCompra.TableName).Rows
               oRow("ItemNro") = index
               index += 1
            Next

            rpt.DataSource = oPedCompra.DataSet.Tables(oPedCompra.TableName).DefaultView
            rpt.lblTitle.Text = oCompraPara.Titulo
            rpt.Document.Name = oCompraPara.Titulo
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, oCompraPara.TipoHojaId)

            If (oCompraPara.TipoHojaId = 1) Or (oCompraPara.TipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As frmReportPreview
               frm = New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (oCompraPara.TipoHojaId = 2) Or (oCompraPara.TipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As frmReportPreviewMultiple
               frm = New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = oCompraPara.TipoHojaId
               frm.Show()
               'frm.PrintReport()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Function CompraParaFirma(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByRef strTitulo As String, ByRef lngTipoHojaId As Long) As String
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaFirma = ""

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moPedCompra.EmpresaId
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

   Private Function CiudadDesFind(ByVal lngCiudadId As Long) As String
      Dim oCiudad As New clsCiudad(clsAppInfo.ConnectString)

      CiudadDesFind = ""

      Try
         With oCiudad
            .CiudadId = lngCiudadId

            If .FindByPK Then
               Return .CiudadDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCiudad.Dispose()

      End Try
   End Function

   Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
      If mboolAdding Then
         If Not IsNothing(moPedCompra) Then
            If dtpFecha.Tag <> dtpFecha.Text Then
               If IsDate(dtpFecha.Text) Then
                  Call txtTipoCambioLoad(ToDate(dtpFecha.Value))
                  dtpFecha.Tag = dtpFecha.Text
                  dtpFechaEnt.MinDate = ToDateDMY(dtpFecha.Value)
               Else
                  txtTipoCambio.Text = 0
               End If
            End If
         End If
      End If
   End Sub

   Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
      dtpFechaEnt.MinDate = ToDateDMY(dtpFecha.Value)
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

   Private Sub cboCentroCosto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroCosto.SelectedIndexChanged
      If mboolAdding And clsAppInfo.CentroCostoApli Then
         txtPedCompraOrden.Text = GetCodNroOrden()
      End If
   End Sub

   Private Sub cboProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Then
               Dim frm As New frmProveedorEdit
               Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oProveedor.EmpresaId = moPedCompra.EmpresaId

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

   Private Sub cboProveedor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedor.ValueChanged
      If mboolAdding And clsAppInfo.CentroCostoApli Then
         txtPedCompraOrden.Text = GetCodNroOrden()
      End If
   End Sub

#End Region

#Region " Aprobar Pedido"

   Public Function PedCompraAprobar() As Boolean

      Try

         If moPedCompra.EstadoId <> clsEstado.ANULADO Then
            If moPedCompra.EstadoId = clsEstado.PENDIENTE Then
               If MessageBox.Show("¿Realmente quiere Aprobar el Pedido de Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  If PedCompraUpdateEstadoId(moPedCompra.PedCompraId, clsEstado.APROBADO) Then
                     mlngID = moPedCompra.PedCompraId
                     mboolChanged = True
                     cdmMain.Commands.Item("AprobarPedido").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     cdmMain.Commands.Item("CancelarAprobar").Enabled = Janus.Windows.UI.InheritableBoolean.True
                     RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.True
                     cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     Me.Close()
                  End If
               End If
            Else
               MessageBox.Show("El Pedido de Compra ya tiene Movimiento ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("El Pedido de Compra ya Fue Anulado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Public Function PedCompraCancelarAprobar() As Boolean

      Try
         If moPedCompra.EstadoId <> clsEstado.ANULADO Then
            If moPedCompra.EstadoId = clsEstado.APROBADO Then
               If Not AnticipoExiste(moPedCompra.PedCompraId) Then
                  If MessageBox.Show("¿Realmente quiere cancelar la Aprobación del Pedido de Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     If PedCompraUpdateEstadoId(moPedCompra.PedCompraId, clsEstado.PENDIENTE) Then
                        mlngID = moPedCompra.PedCompraId
                        mboolChanged = True
                        cdmMain.Commands.Item("AprobarPedido").Enabled = Janus.Windows.UI.InheritableBoolean.True
                        cdmMain.Commands.Item("CancelarAprobar").Enabled = Janus.Windows.UI.InheritableBoolean.False
                        RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False
                        cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
                        cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
                        Me.Close()
                     End If
                  End If
               Else
                  MessageBox.Show("El Pedido de Compra tiene Anticipo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("El Pedido de Compra ya tiene Movimiento ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("El Pedido de Compra ya Fue Anulado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Public Function RealizarPedCompra() As Boolean

      Try

         If moPedCompra.EstadoId <> clsEstado.ANULADO Then
            If (moPedCompra.EstadoId = clsEstado.APROBADO) Or (moPedCompra.EstadoId = clsEstado.PARCIAL) Then
               If MessageBox.Show("¿Realmente Quiere Realizar el Pedido de Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  If PedCompraAnular(clsEstado.REALIZADO) Then
                     cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False
                     mlngID = moPedCompra.PedCompraId
                     mboolChanged = True
                     Me.Close()
                  End If
               End If
            Else
               MessageBox.Show("El Pedido de Compra debe estar Aprobado o Parcial", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("El Pedido de Compra ya Fue Anulado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Public Function CancelarRealizarPedCompra() As Boolean

      Try

         If moPedCompra.EstadoId <> clsEstado.ANULADO Then
            If (moPedCompra.EstadoId = clsEstado.REALIZADO) Then
               If MessageBox.Show("¿Realmente Quiere cancelar la realización del Pedido de Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  If PedCompraUpdateCancel(moPedCompra.PedCompraId) Then
                     cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False
                     mlngID = moPedCompra.PedCompraId
                     mboolChanged = True
                     Me.Close()
                  End If
               End If
            Else
               MessageBox.Show("El Pedido de Compra debe estar Realizado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("El Pedido de Compra ya Fue Anulado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function PedCompraUpdateEstadoId(ByVal lngPedCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)

      Try
         PedCompraUpdateEstadoId = False

         With oPedCompra
            .PedCompraId = lngPedCompraId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .FechaEnt = ToDate(.FechaEnt)

               .EstadoId = lngEstadoId

               If .Update() Then

                  With oPedCompraDet
                     .SelectFilter = clsPedCompraDet.SelectFilters.All
                     .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraId
                     .EmpresaId = oPedCompra.EmpresaId
                     .PedCompraId = lngPedCompraId

                     If .Open() Then
                        Do While .Read()
                           .Fecha = ToDate(.Fecha)
                           .FechaEnt = ToDate(.FechaEnt)
                           .EstadoId = lngEstadoId

                           PedCompraUpdateEstadoId = .Update()

                           .MoveNext()
                        Loop

                        Call .CloseConection()
                     End If
                  End With
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPedCompra.Dispose()
         oPedCompraDet.Dispose()
      End Try

   End Function

   Private Function PedCompraUpdateCancel(ByVal lngPedCompraId As Long) As Boolean

      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim decCantidad, decCantidadEnt As Decimal

      Try
         PedCompraUpdateCancel = False

         With oPedCompra

            .PedCompraId = lngPedCompraId

            If .FindByPK Then

               With oPedCompraDet

                  .SelectFilter = clsPedCompraDet.SelectFilters.All
                  .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraId
                  .EmpresaId = oPedCompra.EmpresaId
                  .PedCompraId = lngPedCompraId

                  If .Find Then
                     decCantidad = 0
                     decCantidadEnt = 0

                     While .Read

                        .EstadoId = clsEstado.APROBADO ''clsEstado.PENDIENTE 'Pendiente

                        If .Cantidad = .CantidadEnt Then
                           .EstadoId = clsEstado.REALIZADO  'Realizado                        
                        ElseIf .CantidadEnt > 0 Then
                           .EstadoId = clsEstado.PARCIAL 'Parcial                        
                        End If

                        decCantidad += .Cantidad
                        decCantidadEnt += .CantidadEnt

                        .UpdateFilter = clsPedCompraDet.UpdateFilters.EstadoIdPK
                        If .Update Then
                           PedCompraUpdateCancel = True
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
                  PedCompraUpdateCancel = True
               End If

            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPedCompra.Dispose()
         oPedCompraDet.Dispose()
      End Try

   End Function

#End Region

#Region " Detalle del Pedido de Compra "

   Private Sub grdMainLoad()
      Dim oRow As DataRow
      Dim decCantidad As Decimal
      Dim decCantidadEnt As Decimal

      Try
         With moPedCompraDet
            .SelectFilter = clsPedCompraDet.SelectFilters.Grid
            .WhereFilter = clsPedCompraDet.WhereFilters.Grid
            .OrderByFilter = clsPedCompraDet.OrderByFilters.Grid
            .EmpresaId = moPedCompra.EmpresaId
            .PedCompraId = moPedCompra.PedCompraId

            mdecMontoOrg = 0
            mdecMontoDes = 0
            mdecMontoRec = 0

            If .Open() Then
               Call moDataSetInit()

               For Each oRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRowShow(oRow))

                  decCantidad += oRow("Cantidad")
                  decCantidadEnt += oRow("CantidadEnt")

                  mlngItemCant += 1
                  mdecMontoOrg += oRow("Importe")
                  mdecMontoRec += ToDecimal(oRow("PrecioRec") * oRow("Cantidad"))
                  mdecMontoDes += ToDecimal(oRow("PrecioDes") * oRow("Cantidad"))
               Next

               grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            mlngEstadoIdPed = IIf(decCantidadEnt = 0, clsEstado.APROBADO, IIf(decCantidad <= decCantidadEnt, clsEstado.REALIZADO, clsEstado.PARCIAL))

            Call ItemTotal()
            Call ItemTotalPorcentajes()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moPedCompraDet.TableName)

      moDataTable.Columns.Add("PedCompraDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("MedidaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("CantidadEnt", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Precio", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Importe", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioRec", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioDes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoRec", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoDes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("ImporteBru", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PedCompraDetDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CentroCostoDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("FechaEnt", Type.GetType("System.String"))
      moDataTable.Columns.Add("Estado", Type.GetType("System.String"))

      modtDelete = moDataSet.Tables.Add("DataDelete")

      modtDelete.Columns.Add("PedCompraDetId", Type.GetType("System.Int32"))
      modtDelete.Columns.Add("ItemId", Type.GetType("System.Int32"))
      modtDelete.Columns.Add("Estado", Type.GetType("System.String"))
   End Sub

   Private Function GetRowShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PedCompraDetId") = oDataRow("PedCompraDetId")
      oRow("ItemId") = oDataRow("ItemId")
      oRow("ItemCod") = oDataRow("ItemCod")
      oRow("ItemDes") = oDataRow("ItemDes")
      oRow("MedidaId") = oDataRow("MedidaId")
      oRow("MedidaDes") = oDataRow("MedidaDes")
      oRow("Cantidad") = oDataRow("Cantidad")
      oRow("CantidadEnt") = oDataRow("CantidadEnt")
      oRow("Precio") = oDataRow("Precio")
      oRow("Importe") = ToDecimal(oDataRow("Importe"))
      oRow("PrecioRec") = oDataRow("PrecioRec")
      oRow("PrecioDes") = oDataRow("PrecioDes")
      oRow("MontoRec") = ToDecimal(oDataRow("PrecioRec") * oDataRow("Cantidad"))
      oRow("MontoDes") = ToDecimal(oDataRow("PrecioDes") * oDataRow("Cantidad"))
      oRow("ImporteBru") = oDataRow("ImporteBru")
      oRow("PedCompraDetDes") = oDataRow("PedCompraDetDes")
      oRow("CentroCostoDetId") = oDataRow("CentroCostoDetId")
      oRow("FechaEnt") = ToDateDMY(oDataRow("FechaEnt"))
      oRow("Estado") = "Show"

      Return oRow
   End Function

   Private Function GetRowNew(ByVal oPedCompraDet As clsPedCompraDet) As DataRow
      Dim strItemCod As String
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PedCompraDetId") = 0
      oRow("ItemId") = oPedCompraDet.ItemId
      oRow("ItemDes") = ItemDesFind(oPedCompraDet.ItemId, strItemCod)
      oRow("ItemCod") = strItemCod
      oRow("MedidaId") = oPedCompraDet.MedidaId
      oRow("MedidaDes") = MedidaDesFind(oPedCompraDet.MedidaId)
      oRow("Cantidad") = oPedCompraDet.Cantidad
      oRow("CantidadEnt") = oPedCompraDet.CantidadEnt
      oRow("Precio") = oPedCompraDet.Precio
      oRow("Importe") = oPedCompraDet.Importe
      oRow("PrecioRec") = oPedCompraDet.PrecioRec
      oRow("PrecioDes") = oPedCompraDet.PrecioDes
      oRow("MontoRec") = ToDecimal(oPedCompraDet.PrecioRec * oPedCompraDet.Cantidad)
      oRow("MontoDes") = ToDecimal(oPedCompraDet.PrecioDes * oPedCompraDet.Cantidad)
      oRow("ImporteBru") = oPedCompraDet.ImporteBru
      oRow("PedCompraDetDes") = oPedCompraDet.PedCompraDetDes
      oRow("CentroCostoDetId") = oPedCompraDet.CentroCostoDetId
      oRow("FechaEnt") = oPedCompraDet.FechaEnt
      oRow("Estado") = "New"

      Return oRow
   End Function

   Private Sub RowNewEdit(ByRef oRow As DataRow, ByVal oPedCompraDet As clsPedCompraDet, ByVal strEstado As String)
      Dim strItemCod As String

      oRow("PedCompraDetId") = oPedCompraDet.PedCompraDetId
      oRow("ItemId") = oPedCompraDet.ItemId
      oRow("ItemDes") = ItemDesFind(oPedCompraDet.ItemId, strItemCod)
      oRow("ItemCod") = strItemCod
      oRow("MedidaId") = oPedCompraDet.MedidaId
      oRow("MedidaDes") = MedidaDesFind(oPedCompraDet.MedidaId)
      oRow("Cantidad") = oPedCompraDet.Cantidad
      oRow("CantidadEnt") = oPedCompraDet.CantidadEnt
      oRow("Precio") = oPedCompraDet.Precio
      oRow("Importe") = oPedCompraDet.Importe
      oRow("PrecioRec") = oPedCompraDet.PrecioRec
      oRow("PrecioDes") = oPedCompraDet.PrecioDes
      oRow("MontoRec") = ToDecimal(oPedCompraDet.PrecioRec * oPedCompraDet.Cantidad)
      oRow("MontoDes") = ToDecimal(oPedCompraDet.PrecioDes * oPedCompraDet.Cantidad)
      oRow("ImporteBru") = oPedCompraDet.ImporteBru
      oRow("PedCompraDetDes") = oPedCompraDet.PedCompraDetDes
      oRow("CentroCostoDetId") = oPedCompraDet.CentroCostoDetId
      oRow("FechaEnt") = oPedCompraDet.FechaEnt
      oRow("Estado") = strEstado
   End Sub

   Private Function GetRowDelete(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = modtDelete.NewRow

      oRow("PedCompraDetId") = oDataRow("PedCompraDetId")
      oRow("ItemId") = oDataRow("ItemId")
      oRow("Estado") = "Delete"

      Return oRow
   End Function

   Private Sub grdMainShow()
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim frm As New frmPedCompraDetEdit

      Try
         If grdMain.RowCount > 0 Then
            If (ToLong(grdMain.GetValue("ItemId")) > 0) Then
               If ToStr(grdMain.GetValue("Estado")) = "Show" Then
                  With oPedCompraDet
                     .PedCompraDetId = ToLong(grdMain.GetValue("PedCompraDetId"))

                     If .FindByPK Then
                        frm.NewRecord = False
                        frm.Editing = False
                        frm.DataObject = oPedCompraDet
                        frm.ShowDialog()
                        frm.Dispose()
                     End If
                  End With

               ElseIf ToStr(grdMain.GetValue("Estado")) = "New" Then
                  With frm
                     .NewRecord = False
                     .Editing = False

                     oPedCompraDet.EmpresaId = ToLong(moPedCompra.EmpresaId)
                     oPedCompraDet.PedCompraId = ToLong(moPedCompra.PedCompraId)
                     oPedCompraDet.Fecha = ToDate(dtpFecha.Value)
                     oPedCompraDet.AlmacenId = ToLong(moPedCompra.AlmacenId)
                     oPedCompraDet.ProveedorId = ToLong(moPedCompra.ProveedorId)
                     oPedCompraDet.MonedaId = ToLong(moPedCompra.MonedaId)
                     oPedCompraDet.TipoCambio = ToDecimal(moPedCompra.TipoCambio)
                     oPedCompraDet.CentroCostoId = ToLong(moPedCompra.CentroCostoId)
                     oPedCompraDet.EstadoId = 13

                     oPedCompraDet.ItemId = ToLong(grdMain.GetValue("ItemId"))
                     oPedCompraDet.MedidaId = ToLong(grdMain.GetValue("MedidaId"))
                     oPedCompraDet.Cantidad = ToDecimal(grdMain.GetValue("Cantidad"))
                     oPedCompraDet.Precio = ToDecimal(grdMain.GetValue("Precio"))
                     oPedCompraDet.Importe = ToDecimal(grdMain.GetValue("Importe"))
                     oPedCompraDet.PrecioDes = ToDouble(grdMain.GetValue("PrecioDes"))
                     oPedCompraDet.PrecioRec = ToDouble(grdMain.GetValue("PrecioRec"))
                     oPedCompraDet.PedCompraDetDes = ToStr(grdMain.GetValue("PedCompraDetDes"))
                     oPedCompraDet.CentroCostoDetId = ToLong(grdMain.GetValue("CentroCostoDetId"))
                     oPedCompraDet.FechaEnt = ToStr(grdMain.GetValue("FechaEnt"))

                     .DataObject = oPedCompraDet
                     .ShowDialog()
                     frm.Dispose()
                  End With
               End If
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompraDet.Dispose()

      End Try
   End Sub

   Private Sub grdMainNew()
      Dim frm As New frmPedCompraDetEdit
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)

      Try
         If mboolAdding Then
            Call DataMove()
            Call moPedCompra.Validate()

            ''If dtpFecha.Value > Now Then
            ''   Throw New Exception("Fecha no Valida, No puede ser mayor a la Actual")
            ''End If

            If clsAppInfo.CentroCostoApli Then
               If cboCentroCosto.SelectedIndex = -1 Then
                  MessageBox.Show("Centro de Costo Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub
               End If
            End If

         End If

         ''If moPedCompra.EstadoId = 13 Then
         'If ((moPedCompra.EstadoId = clsEstado.PENDIENTE) Or (moPedCompra.EstadoId = clsEstado.PARCIAL))  Then
         If ((moPedCompra.EstadoId = clsEstado.PENDIENTE) Or (mboolEditarAprobado)) Then
            With frm
               .NewRecord = True
               .Editing = False

               oPedCompraDet.EmpresaId = ToLong(moPedCompra.EmpresaId)
               oPedCompraDet.PedCompraId = ToLong(moPedCompra.PedCompraId)
               oPedCompraDet.Fecha = ToDate(dtpFecha.Value)
               oPedCompraDet.AlmacenId = ToLong(moPedCompra.AlmacenId)
               oPedCompraDet.ProveedorId = ToLong(moPedCompra.ProveedorId)
               oPedCompraDet.MonedaId = ToLong(moPedCompra.MonedaId)
               oPedCompraDet.TipoCambio = ToDecimal(moPedCompra.TipoCambio)
               oPedCompraDet.CentroCostoId = ToLong(moPedCompra.CentroCostoId)
               oPedCompraDet.FechaEnt = ToStr(dtpFechaEnt.Text)
               oPedCompraDet.EstadoId = 13

               Do
                  Call mqueItemLoad()
                  .ItemList = mqueItem
                  .DataObject = oPedCompraDet

                  .NewRecord = True
                  .Editing = False

                  .ShowDialog()

                  If .Changed Then
                     Call DataViewAll()
                     moDataTable.Rows.Add(GetRowNew(frm.DataObject))

                     Call grdMainFindRow(frm.ID)

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
                        cboProveedor.ReadOnly = True
                        cboCentroCosto.ReadOnly = True
                     End If
                     mboolEditing = True

                  End If
               Loop Until .Changed = False

               frm.Dispose()
               'mboolEditing = True
            End With
         Else
            MessageBox.Show("Imposible Modificar el Pedido de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompraDet.Dispose()

      End Try
   End Sub

   Private Sub grdMainEdit()
      Dim frm As New frmPedCompraDetEdit
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim decImporteOld, decMontoDesOld, decMontoRecOld As Decimal

      Try
         'If moPedCompra.EstadoId = 13 Then
         If moPedCompra.EstadoId = clsEstado.PENDIENTE Then
            If grdMain.RowCount > 0 Then
               If (ToLong(grdMain.GetValue("ItemId")) > 0) Then
                  If moPedCompra.EstadoId = clsEstado.PARCIAL Then
                     If grdMain.GetValue("CantidadEnt") <> 0 Then
                        Throw New Exception("No se Puede Editar el Item")
                     End If
                  End If

                  If ToStr(grdMain.GetValue("Estado")) = "Show" Then
                     With oPedCompraDet
                        .PedCompraDetId = ToLong(grdMain.GetValue("PedCompraDetId"))

                        If .FindByPK Then
                           decImporteOld = .Importe
                           decMontoDesOld = .PrecioDes * .Cantidad
                           decMontoRecOld = .PrecioRec * .Cantidad

                           frm.NewRecord = False
                           frm.Editing = True
                           frm.DataObject = oPedCompraDet
                           frm.ShowDialog()

                           If frm.Changed Then
                              Call DataViewAll()
                              Call RowNewEdit(moDataTable.Rows(grdMainFindRowId(frm.ID)), frm.DataObject, "Edit")

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

                  ElseIf ToStr(grdMain.GetValue("Estado")) = "New" Then
                     With frm
                        .NewRecord = False
                        .Editing = True

                        oPedCompraDet.EmpresaId = ToLong(moPedCompra.EmpresaId)
                        oPedCompraDet.PedCompraId = ToLong(moPedCompra.PedCompraId)
                        oPedCompraDet.Fecha = ToDate(dtpFecha.Value)
                        oPedCompraDet.AlmacenId = ToLong(moPedCompra.AlmacenId)
                        oPedCompraDet.ProveedorId = ToLong(moPedCompra.ProveedorId)
                        oPedCompraDet.MonedaId = ToLong(moPedCompra.MonedaId)
                        oPedCompraDet.TipoCambio = ToDecimal(moPedCompra.TipoCambio)
                        oPedCompraDet.CentroCostoId = ToLong(moPedCompra.CentroCostoId)
                        oPedCompraDet.EstadoId = 13

                        oPedCompraDet.ItemId = ToLong(grdMain.GetValue("ItemId"))
                        oPedCompraDet.MedidaId = ToLong(grdMain.GetValue("MedidaId"))
                        oPedCompraDet.Cantidad = ToDecimal(grdMain.GetValue("Cantidad"))
                        oPedCompraDet.Precio = ToDecimal(grdMain.GetValue("Precio"))
                        oPedCompraDet.Importe = ToDecimal(grdMain.GetValue("Importe"))
                        oPedCompraDet.PrecioDes = ToDouble(grdMain.GetValue("PrecioDes"))
                        oPedCompraDet.PrecioRec = ToDouble(grdMain.GetValue("PrecioRec"))
                        oPedCompraDet.PedCompraDetDes = ToStr(grdMain.GetValue("PedCompraDetDes"))
                        oPedCompraDet.CentroCostoDetId = ToStr(grdMain.GetValue("CentroCostoDetId"))
                        oPedCompraDet.FechaEnt = ToStr(grdMain.GetValue("FechaEnt"))

                        decImporteOld = oPedCompraDet.Importe
                        decMontoDesOld = oPedCompraDet.PrecioDes * oPedCompraDet.Cantidad
                        decMontoRecOld = oPedCompraDet.PrecioRec * oPedCompraDet.Cantidad

                        Call mqueItemLoad(oPedCompraDet.ItemId)
                        .ItemList = mqueItem
                        .DataObject = oPedCompraDet
                        .ShowDialog()

                        If .Changed Then
                           Call DataViewAll()
                           Call RowNewEdit(moDataTable.Rows(grdMainFindRowId(frm.ID)), frm.DataObject, "New")

                           mdecMontoOrg = (mdecMontoOrg - decImporteOld) + frm.DataObject.Importe
                           mdecMontoDes = (mdecMontoDes - decMontoDesOld) + (frm.DataObject.PrecioDes * frm.DataObject.Cantidad)
                           mdecMontoRec = (mdecMontoRec - decMontoRecOld) + (frm.DataObject.PrecioRec * frm.DataObject.Cantidad)

                           Call ItemTotal()
                           Call ItemTotalPorcentajes()

                           mboolEditGrid = True

                        End If

                        frm.Dispose()
                        mboolEditing = True
                     End With

                  ElseIf ToStr(grdMain.GetValue("Estado")) = "Edit" Then
                     With frm
                        .NewRecord = False
                        .Editing = True

                        oPedCompraDet.EmpresaId = ToLong(moPedCompra.EmpresaId)
                        oPedCompraDet.PedCompraId = ToLong(moPedCompra.PedCompraId)
                        oPedCompraDet.Fecha = ToDate(dtpFecha.Value)
                        oPedCompraDet.AlmacenId = ToLong(moPedCompra.AlmacenId)
                        oPedCompraDet.ProveedorId = ToLong(moPedCompra.ProveedorId)
                        oPedCompraDet.MonedaId = ToLong(moPedCompra.MonedaId)
                        oPedCompraDet.TipoCambio = ToDecimal(moPedCompra.TipoCambio)
                        oPedCompraDet.CentroCostoId = ToDecimal(moPedCompra.CentroCostoId)
                        oPedCompraDet.EstadoId = 13

                        oPedCompraDet.ItemId = ToLong(grdMain.GetValue("ItemId"))
                        oPedCompraDet.MedidaId = ToLong(grdMain.GetValue("MedidaId"))
                        oPedCompraDet.Cantidad = ToDecimal(grdMain.GetValue("Cantidad"))
                        oPedCompraDet.Precio = ToDecimal(grdMain.GetValue("Precio"))
                        oPedCompraDet.Importe = ToDecimal(grdMain.GetValue("Importe"))
                        oPedCompraDet.PrecioDes = ToDouble(grdMain.GetValue("PrecioDes"))
                        oPedCompraDet.PrecioRec = ToDouble(grdMain.GetValue("PrecioRec"))
                        oPedCompraDet.PedCompraDetDes = ToStr(grdMain.GetValue("PedCompraDetDes"))
                        oPedCompraDet.CentroCostoDetId = ToStr(grdMain.GetValue("CentroCostoDetId"))
                        oPedCompraDet.FechaEnt = ToStr(grdMain.GetValue("FechaEnt"))

                        decImporteOld = oPedCompraDet.Importe
                        decMontoDesOld = oPedCompraDet.PrecioDes * oPedCompraDet.Cantidad
                        decMontoRecOld = oPedCompraDet.PrecioRec * oPedCompraDet.Cantidad

                        Call mqueItemLoad(oPedCompraDet.ItemId)
                        .ItemList = mqueItem
                        .DataObject = oPedCompraDet
                        .ShowDialog()

                        If .Changed Then
                           Call DataViewAll()
                           Call RowNewEdit(moDataTable.Rows(grdMainFindRowId(frm.ID)), frm.DataObject, "Edit")

                           mdecMontoOrg = (mdecMontoOrg - decImporteOld) + frm.DataObject.Importe
                           mdecMontoDes = (mdecMontoDes - decMontoDesOld) + (frm.DataObject.PrecioDes * frm.DataObject.Cantidad)
                           mdecMontoRec = (mdecMontoRec - decMontoRecOld) + (frm.DataObject.PrecioRec * frm.DataObject.Cantidad)

                           Call ItemTotal()
                           Call ItemTotalPorcentajes()

                           mboolEditGrid = True

                        End If

                        frm.Dispose()
                        mboolEditing = True
                     End With
                  End If
               End If
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Imposible Modificar el Pedido de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompraDet.Dispose()

      End Try
   End Sub

   Private Sub grdMainDelete()
      Dim lngCol As Long
      Dim decImporteOld, decMontoDesOld, decMontoRecOld As Decimal

      Try
         If moPedCompra.EstadoId = clsEstado.PENDIENTE Then
            If grdMain.RowCount > 0 Then
               If (ToLong(grdMain.GetValue("ItemId")) > 0) Then
                  If moPedCompra.EstadoId = clsEstado.PARCIAL Then
                     If grdMain.GetValue("CantidadEnt") <> 0 Then
                        Throw New Exception("Imposible Eliminar el Registro")
                     End If
                  End If

                  If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     Call DataViewAll()
                     decImporteOld = ToDecimal(grdMain.GetValue("Importe"))
                     decMontoDesOld = ToDecimal(grdMain.GetValue("PrecioDes") * grdMain.GetValue("Cantidad"))
                     decMontoRecOld = ToDecimal(grdMain.GetValue("PrecioRec") * grdMain.GetValue("Cantidad"))

                     If ToStr(grdMain.GetValue("Estado")) <> "New" Then
                        modtDelete.Rows.Add(GetRowDelete(moDataTable.Rows.Item(grdMain.Row)))
                     End If

                     moDataTable.Rows.RemoveAt(grdMain.Row)

                     grdMain.RetrieveStructure()
                     Call grdMainInit()

                     mlngItemCant -= 1
                     mdecMontoOrg = mdecMontoOrg - decImporteOld
                     mdecMontoDes = mdecMontoDes - decMontoDesOld
                     mdecMontoRec = mdecMontoRec - decMontoRecOld

                     Call ItemTotal()
                     Call ItemTotalPorcentajes()

                     If grdMain.RowCount = 0 Then 'Para habilitar la moneda
                        cboMoneda.ReadOnly = False
                        cboAlmacen.ReadOnly = False
                        cboProveedor.ReadOnly = False
                        cboCentroCosto.ReadOnly = False
                     End If


                  End If
               End If
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Imposible Modificar el Pedido de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Sub

   Private Function PedCompraDetDelete(ByVal lngPedCompraDetId As Long) As Boolean
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)

      Try
         PedCompraDetDelete = False

         With oPedCompraDet
            .WhereFilter = clsPedCompraDet.WhereFilters.PrimaryKey
            .PedCompraDetId = lngPedCompraDetId

            If .Delete Then
               PedCompraDetDelete = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompraDet.Dispose()

      End Try
   End Function

   Private Function PedCompraAnular() As Boolean
      Try
         If moPedCompra.EstadoId <> clsEstado.ANULADO Then
            If moPedCompra.EstadoId = clsEstado.PENDIENTE Then
               If Not AnticipoExiste(moPedCompra.PedCompraId) Then
                  If MessageBox.Show("¿Realmente Quiere Anular el Pedido de Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     If PedCompraAnular(clsEstado.ANULADO) Then
                        mlngID = moPedCompra.PedCompraId
                        mboolChanged = True

                        cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
                        cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
                        RealizarPedido.Enabled = Janus.Windows.UI.InheritableBoolean.False
                        Me.Close()
                     End If
                  End If
               Else
                  MessageBox.Show("El Pedido de Compra tiene Anticipo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("El Pedido de Compra ya tiene Movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("El Pedido de Compra ya Fue Anulado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function PedCompraAnular(ByVal lngEstado As Long) As Boolean
      Try
         PedCompraAnular = False

         moPedCompra.Fecha = ToDate(dtpFecha.Text)
         moPedCompra.FechaEnt = ToDate(dtpFechaEnt.Text)
         moPedCompra.EstadoId = lngEstado

         If moPedCompra.Update() Then
            Call moPedCompra.CloseConection()
            cboEstado.SelectedIndex = ListFindItem(cboEstado, moPedCompra.EstadoId)

            With moPedCompraDet
               .SelectFilter = clsPedCompraDet.SelectFilters.All
               .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraId
               .EmpresaId = moPedCompra.EmpresaId
               .PedCompraId = moPedCompra.PedCompraId

               If .Open() Then
                  Do While .Read()
                     .Fecha = ToDate(.Fecha)
                     .FechaEnt = ToDate(.FechaEnt)

                     .EstadoId = lngEstado
                     PedCompraAnular = .Update()

                     .MoveNext()
                  Loop

                  Call .CloseConection()
               End If
            End With
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function AnticipoExiste(ByVal lngPedCompraId As Long) As Boolean
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

      Try
         AnticipoExiste = False

         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.All
            .WhereFilter = clsAnticipo.WhereFilters.TienePedCompraId
            .EmpresaId = moPedCompra.EmpresaId
            .GestionId = moPedCompra.GestionId
            .PedCompraId = lngPedCompraId

            If .Find Then
               AnticipoExiste = True
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()
      End Try

   End Function

   Private Sub grdMainMove(ByRef oRow As DataRow)
      With moPedCompraDet
         .PedCompraDetId = ToLong(oRow("PedCompraDetId"))
         .EmpresaId = ToLong(moPedCompra.EmpresaId)
         .GestionId = ToLong(moPedCompra.GestionId)
         .PedCompraId = ToLong(moPedCompra.PedCompraId)
         .Fecha = ToDate(dtpFecha.Value)
         '.FechaEnt = ToDate(dtpFechaEnt.Value)
         .FechaEnt = ToDate(oRow("FechaEnt"))
         .AlmacenId = ToLong(moPedCompra.AlmacenId)
         .ProveedorId = ToLong(moPedCompra.ProveedorId)
         .MonedaId = ToLong(moPedCompra.MonedaId)
         .TipoCambio = ToDecimal(moPedCompra.TipoCambio)
         .CentroCostoId = ToLong(moPedCompra.CentroCostoId)
         .ItemId = ToLong(oRow("ItemId"))
         .MedidaId = ToLong(oRow("MedidaId"))
         .Cantidad = ToDecimal(oRow("Cantidad"))
         .CantidadEnt = ToDecimal(oRow("CantidadEnt"))
         .Precio = ToDecimal(oRow("Precio"))
         .PrecioRec = ToDouble(oRow("PrecioRec"))
         .PrecioDes = ToDouble(oRow("PrecioDes"))
         .Importe = ToDecimal(oRow("Importe"))
         .ImporteBru = ToDouble(oRow("ImporteBru"))
         .PedCompraDetDes = ToStr(oRow("PedCompraDetDes"))
         .CentroCostoDetId = ToLong(oRow("CentroCostoDetId"))
         .EstadoId = 13
      End With
   End Sub

   Private Function grdMainSave() As Boolean
      Dim oRow As DataRow

      grdMainSave = True

      Try

         For Each oRow In moDataSet.Tables("DataDelete").Rows
            If ToStr(oRow("Estado")) = "Delete" Then
               If PedCompraDetDelete(oRow("PedCompraDetId")) Then

               End If
            End If
         Next

         For Each oRow In moDataSet.Tables(moPedCompraDet.TableName).Rows
            If ToStr(oRow("Estado")) = "New" Then
               Call grdMainMove(oRow)

               If moPedCompraDet.Insert() Then
                  Call moPedCompraDet.CloseConection()
               End If

            ElseIf ToStr(oRow("Estado")) = "Edit" Then
               Call grdMainMove(oRow)

               If moPedCompraDet.Update() Then
                  Call moPedCompraDet.CloseConection()
               End If
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function ItemDesFind(ByVal lngItemId As Long, ByRef strItemCod As String) As String
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      ItemDesFind = ""

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               ItemDesFind = .ItemDes
               strItemCod = .ItemCod
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

   Private Function CompraParaOrden(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaOrden = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = clsAppInfo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               CompraParaOrden = .PrintAuto
               mboolAprobadoAutoDoc = .AprobadoAutoDoc
               mboolAprobadoAutoDocEdit = .EditarAprobadoDoc
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try

   End Function

   Private Sub ItemTotal()
      txtMontoOrg.Text = ToDecimal(mdecMontoOrg)
      txtMontoRec.Text = ToDecimal(mdecMontoRec)
      txtMontoDes.Text = ToDecimal(mdecMontoDes)
      txtMontoLiq.Text = ToDecimal(ToDecimal(txtMontoOrg.Text) + ToDecimal(txtMontoRec.Text) - ToDecimal(txtMontoDes.Text))

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

   End Sub

   Private Sub grdRecargoLoad(ByVal decMontoRec As Decimal)

      Dim oRow As DataRow

      For Each oRow In moDataSet.Tables(moPedCompraDet.TableName).Rows

         oRow("MontoRec") = ToDouble(oRow("Importe") / mdecMontoOrg * decMontoRec)
         oRow("PrecioRec") = ToDouble(oRow("MontoRec") / oRow("Cantidad"))

         oRow("ImporteBru") = ToDecimal(oRow("Importe") + oRow("MontoRec") - oRow("MontoDes"))

         oRow("MontoRec") = ToDecimal(oRow("MontoRec"))

         If ToStr(oRow("Estado")) = "Show" Then
            oRow("Estado") = "Edit"
         End If

      Next

      Call ItemTotal()

   End Sub

   Private Sub grdDescuentoLoad(ByVal decMontoDes As Decimal)

      Dim oRow As DataRow

      For Each oRow In moDataSet.Tables(moPedCompraDet.TableName).Rows

         oRow("MontoDes") = ToDouble(oRow("Importe") / mdecMontoOrg * decMontoDes)
         oRow("PrecioDes") = ToDouble(oRow("MontoDes") / oRow("Cantidad"))

         oRow("ImporteBru") = ToDecimal(oRow("Importe") + oRow("MontoRec") - oRow("MontoDes"))

         oRow("MontoDes") = ToDecimal(oRow("MontoDes"))

         If ToStr(oRow("Estado")) = "Show" Then
            oRow("Estado") = "Edit"
         End If

      Next

      Call ItemTotal()

   End Sub

   Private Sub mqueItemLoad(Optional ByVal lngItemId As Long = 0)
      Dim oRow As DataRow

      mqueItem.Clear()

      For Each oRow In moDataSet.Tables(moPedCompraDet.TableName).Rows
         If ToLong(oRow("ItemId")) <> lngItemId Then
            mqueItem.Enqueue(oRow("ItemId"))
         End If
      Next
   End Sub

   Private Sub grdMainEstadoShow()
      Dim oRow As DataRow

      For Each oRow In moDataSet.Tables(moPedCompraDet.TableName).Rows
         oRow("Estado") = "Show"
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

      For Each oRow As DataRow In moDataSet.Tables(moPedCompraDet.TableName).Rows
         If oRow("ItemId") = lngID Then
            Return intRow
         End If

         intRow += 1
      Next

      Return 0
   End Function

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("ItemId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Detalle del Pedido de Compra"
         .ContextMenu = mnuMain

         .RootTable.Columns("PedCompraDetId").Visible = False

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

         .RootTable.Columns("CantidadEnt").Caption = "Cantidad Ent"
         .RootTable.Columns("CantidadEnt").FormatString = DecimalMask()
         .RootTable.Columns("CantidadEnt").Width = 100
         .RootTable.Columns("CantidadEnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("CantidadEnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mboolAdding Then
            .RootTable.Columns("CantidadEnt").Visible = False
         End If

         .RootTable.Columns("Precio").Caption = "Precio"
         .RootTable.Columns("Precio").FormatString = DecimalMask()
         .RootTable.Columns("Precio").Width = 100
         .RootTable.Columns("Precio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Precio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

         .RootTable.Columns("ImporteBru").Caption = "Importe Neto"
         .RootTable.Columns("ImporteBru").FormatString = DecimalMask()
         .RootTable.Columns("ImporteBru").Width = 100
         .RootTable.Columns("ImporteBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PedCompraDetDes").Caption = "Observación"
         .RootTable.Columns("PedCompraDetDes").Width = 150
         .RootTable.Columns("PedCompraDetDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PedCompraDetDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CentroCostoDetId").Visible = False
         '.RootTable.Columns("FechaEnt").Visible = False

         .RootTable.Columns("FechaEnt").Caption = "F. Entrega"
         '.RootTable.Columns("FechaEnt").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FechaEnt").Width = 100
         .RootTable.Columns("FechaEnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FechaEnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

#End Region


#Region "Numeracion Sucursal"

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

   Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged

      If mboolAdding Then
         If clsAppInfo.SucursalApli Then
            Dim lngSucursaId As Long = AlmacenSucursalIdFind(ListPosition(cboAlmacen, cboAlmacen.SelectedIndex))
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, lngSucursaId)
            Call CompraParaOrden(clsTipoCompra.PEDIDO, clsAppInfo.GestionId, lngSucursaId)

         Else
            'mboolNroAutoSucursal = True
         End If

      End If
   End Sub

#End Region

   Private Sub txtMontoRec_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoRec.KeyUp
      If txtMontoRec.ContainsFocus Then

         If ToDecimal(txtMontoRec.Text) <> ToDecimal(txtMontoRec.Tag) Then
            If mdecMontoOrg = 0 Then
               txtPorcentajeRec.Text = 0
               txtMontoRec.Text = 0
            Else
               txtPorcentajeRec.Text = ToDecStr((ToDecimal(txtMontoRec.Text) * 100) / mdecMontoOrg)
            End If

            mdecMontoRec = ToDouble(txtMontoRec.Text)

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

   Private Sub frmPedCompraEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moPedCompra.PedCompraId
                  mboolChanged = True

                  cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
                  cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

                  'If MessageBox.Show("Pedido de Compra Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Pedido de Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPedCompraEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPedCompra.Dispose()
      moPedCompraDet.Dispose()
      Call ClearMemory()
   End Sub

End Class
