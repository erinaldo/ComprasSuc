Public Class frmDevCompraEdit
   Inherits System.Windows.Forms.Form

   Private moDevCompra As clsDevCompra
   Private moDevCompraDet As clsDevCompraDet

   Private mdecDevCompraMonto As Decimal
   Private mdecCreditoSaldo As Decimal
   Private mlngItemCant As Long

   Private mboolCompraFacDif As Boolean

   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngTipoPlanId As Long
   Private mboolTieneComp As Boolean

   Private mboolAnticipo As Boolean

   Private mlngTipoItemId As Long
   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long
   Private mboolControlLote As Boolean
   Private mboolControlSerie As Boolean

   Private mdecPrecioPPP As Decimal
   Private mdecPrecioUPC As Decimal
   Private mdecSaldoItem As Decimal

   Private mlngCompraEstadoId As Long

   Private mstrSepDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   'Dataset que contiene dos tablas de lotes y series
   Private moDataSetDet As DataSet
   Private mlngNotaId As Long
   Private mqueItem As New Queue

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditGrid As Boolean
   Private mlngID As Long
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents chkSinFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   Friend WithEvents Anular1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
   Friend WithEvents grpSucursal As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Friend WithEvents cboAlmacen As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblAlmacenOrg As System.Windows.Forms.Label
   Private mboolGridCancel As Boolean

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

   WriteOnly Property DataObject() As clsDevCompra
      Set(ByVal Value As clsDevCompra)
         moDevCompra = Value
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
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Anular As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtItemCant As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtDevCompraMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtDevCompraObs As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtDevCompraDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtDevCompraNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtDevCompraId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents chkProveedor As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents txtCompraNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents CompraLoad As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CompraLoad1 As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevCompraEdit))
        Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
        Me.grdMain = New Janus.Windows.GridEX.GridEX
        Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
        Me.grpSucursal = New Janus.Windows.EditControls.UIGroupBox
        Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.cboAlmacen = New Janus.Windows.EditControls.UIComboBox
        Me.lblAlmacenOrg = New System.Windows.Forms.Label
        Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.txtDevCompraMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtItemCant = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.chkSinFac = New Janus.Windows.EditControls.UICheckBox
        Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
        Me.txtDevCompraObs = New Janus.Windows.GridEX.EditControls.EditBox
        Me.grpDatos = New Janus.Windows.EditControls.UIGroupBox
        Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
        Me.lblCentroCosto = New System.Windows.Forms.Label
        Me.chkProveedor = New Janus.Windows.EditControls.UICheckBox
        Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDevCompraDes = New Janus.Windows.GridEX.EditControls.EditBox
        Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
        Me.txtCompraNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
        Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
        Me.txtDevCompraNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtDevCompraId = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.CompraLoad1 = New Janus.Windows.UI.CommandBars.UICommand("CompraLoad")
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
        Me.CompraLoad = New Janus.Windows.UI.CommandBars.UICommand("CompraLoad")
        Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.mnuMain = New System.Windows.Forms.ContextMenu
        Me.mnuShow = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.ExplorerBarContainerControl4.SuspendLayout()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bcgMain.SuspendLayout()
        CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSucursal.SuspendLayout()
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
        Me.grdMain.AlternatingColors = True
        Me.grdMain.AutomaticSort = False
        Me.grdMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdMain.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMain.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMain.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdMain.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
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
        Me.grpSucursal.TabIndex = 20
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
        Me.cboSucursal.TabIndex = 9
        Me.cboSucursal.TabStop = False
        Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'lblSucursal
        '
        Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(368, 16)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(80, 16)
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
        Me.cboAlmacen.TabIndex = 8
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
        Me.ebrMain.TabIndex = 8
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
        Me.UiGroupBox3.Controls.Add(Me.txtDevCompraMonto)
        Me.UiGroupBox3.Controls.Add(Me.Label3)
        Me.UiGroupBox3.Controls.Add(Me.txtItemCant)
        Me.UiGroupBox3.Controls.Add(Me.Label2)
        Me.UiGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UiGroupBox3.Location = New System.Drawing.Point(536, 378)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(208, 68)
        Me.UiGroupBox3.TabIndex = 18
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'txtDevCompraMonto
        '
        Me.txtDevCompraMonto.BackColor = System.Drawing.SystemColors.Info
        Me.txtDevCompraMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevCompraMonto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtDevCompraMonto.FormatString = "##,##0.000"
        Me.txtDevCompraMonto.Location = New System.Drawing.Point(100, 16)
        Me.txtDevCompraMonto.Name = "txtDevCompraMonto"
        Me.txtDevCompraMonto.ReadOnly = True
        Me.txtDevCompraMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtDevCompraMonto.TabIndex = 19
        Me.txtDevCompraMonto.Text = "0.000"
        Me.txtDevCompraMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtDevCompraMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtDevCompraMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Cantidad Items"
        '
        'txtItemCant
        '
        Me.txtItemCant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemCant.BackColor = System.Drawing.SystemColors.Info
        Me.txtItemCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCant.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtItemCant.Location = New System.Drawing.Point(100, 40)
        Me.txtItemCant.Name = "txtItemCant"
        Me.txtItemCant.ReadOnly = True
        Me.txtItemCant.Size = New System.Drawing.Size(100, 20)
        Me.txtItemCant.TabIndex = 20
        Me.txtItemCant.TabStop = False
        Me.txtItemCant.Text = "0"
        Me.txtItemCant.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtItemCant.Value = 0
        Me.txtItemCant.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
        Me.txtItemCant.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 20)
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
        Me.UiGroupBox2.Controls.Add(Me.txtDevCompraObs)
        Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 378)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(520, 68)
        Me.UiGroupBox2.TabIndex = 15
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
        Me.chkSinFac.Location = New System.Drawing.Point(108, -1)
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
        Me.chkConFac.Location = New System.Drawing.Point(160, -1)
        Me.chkConFac.Name = "chkConFac"
        Me.chkConFac.Size = New System.Drawing.Size(32, 16)
        Me.chkConFac.TabIndex = 278
        Me.chkConFac.Text = "F"
        Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'txtDevCompraObs
        '
        Me.txtDevCompraObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDevCompraObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevCompraObs.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtDevCompraObs.Location = New System.Drawing.Point(8, 16)
        Me.txtDevCompraObs.Multiline = True
        Me.txtDevCompraObs.Name = "txtDevCompraObs"
        Me.txtDevCompraObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDevCompraObs.Size = New System.Drawing.Size(504, 44)
        Me.txtDevCompraObs.TabIndex = 17
        Me.txtDevCompraObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtDevCompraObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
        Me.grpDatos.Controls.Add(Me.txtDevCompraDes)
        Me.grpDatos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpDatos.Location = New System.Drawing.Point(8, 104)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(736, 64)
        Me.grpDatos.TabIndex = 7
        Me.grpDatos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'cboCentroCosto
        '
        Me.cboCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCosto.Location = New System.Drawing.Point(452, 12)
        Me.cboCentroCosto.Name = "cboCentroCosto"
        Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboCentroCosto.Size = New System.Drawing.Size(276, 20)
        Me.cboCentroCosto.TabIndex = 9
        Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'lblCentroCosto
        '
        Me.lblCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroCosto.Location = New System.Drawing.Point(404, 16)
        Me.lblCentroCosto.Name = "lblCentroCosto"
        Me.lblCentroCosto.Size = New System.Drawing.Size(44, 16)
        Me.lblCentroCosto.TabIndex = 263
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
        Me.chkProveedor.TabIndex = 10
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
        Me.cboProveedor.TabIndex = 11
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
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "Descripción"
        '
        'txtDevCompraDes
        '
        Me.txtDevCompraDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDevCompraDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtDevCompraDes.Location = New System.Drawing.Point(92, 36)
        Me.txtDevCompraDes.MaxLength = 1000
        Me.txtDevCompraDes.Multiline = True
        Me.txtDevCompraDes.Name = "txtDevCompraDes"
        Me.txtDevCompraDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDevCompraDes.Size = New System.Drawing.Size(636, 20)
        Me.txtDevCompraDes.TabIndex = 12
        Me.txtDevCompraDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtDevCompraDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grpMain.Controls.Add(Me.txtCompraNro)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.dtpFecha)
        Me.grpMain.Controls.Add(Me.cboEstado)
        Me.grpMain.Controls.Add(Me.cboMoneda)
        Me.grpMain.Controls.Add(Me.txtDevCompraNro)
        Me.grpMain.Controls.Add(Me.txtTipoCambio)
        Me.grpMain.Controls.Add(Me.txtDevCompraId)
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
        'txtCompraNro
        '
        Me.txtCompraNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCompraNro.BackColor = System.Drawing.SystemColors.Info
        Me.txtCompraNro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCompraNro.FormatString = "########"
        Me.txtCompraNro.Location = New System.Drawing.Point(628, 36)
        Me.txtCompraNro.Name = "txtCompraNro"
        Me.txtCompraNro.ReadOnly = True
        Me.txtCompraNro.Size = New System.Drawing.Size(100, 20)
        Me.txtCompraNro.TabIndex = 202
        Me.txtCompraNro.TabStop = False
        Me.txtCompraNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtCompraNro.Value = 0
        Me.txtCompraNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
        Me.txtCompraNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(556, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "Compra Nro"
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
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        '
        'cboEstado
        '
        Me.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboEstado.Location = New System.Drawing.Point(248, 36)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.ReadOnly = True
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
        Me.cboMoneda.Location = New System.Drawing.Point(452, 12)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.ReadOnly = True
        Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
        Me.cboMoneda.TabIndex = 3
        Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'txtDevCompraNro
        '
        Me.txtDevCompraNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDevCompraNro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtDevCompraNro.FormatString = "########"
        Me.txtDevCompraNro.Location = New System.Drawing.Point(628, 12)
        Me.txtDevCompraNro.Name = "txtDevCompraNro"
        Me.txtDevCompraNro.ReadOnly = True
        Me.txtDevCompraNro.Size = New System.Drawing.Size(100, 20)
        Me.txtDevCompraNro.TabIndex = 4
        Me.txtDevCompraNro.TabStop = False
        Me.txtDevCompraNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtDevCompraNro.Value = 0
        Me.txtDevCompraNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
        Me.txtDevCompraNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
        Me.txtTipoCambio.Text = "0.000"
        Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtDevCompraId
        '
        Me.txtDevCompraId.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtDevCompraId.Location = New System.Drawing.Point(60, 12)
        Me.txtDevCompraId.Name = "txtDevCompraId"
        Me.txtDevCompraId.ReadOnly = True
        Me.txtDevCompraId.Size = New System.Drawing.Size(100, 20)
        Me.txtDevCompraId.TabIndex = 1
        Me.txtDevCompraId.TabStop = False
        Me.txtDevCompraId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtDevCompraId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(196, 40)
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
        Me.Label11.Location = New System.Drawing.Point(372, 40)
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
        'cdmMain
        '
        Me.cdmMain.AllowMerge = False
        Me.cdmMain.AlwaysShowFullMenus = True
        Me.cdmMain.BottomRebar = Me.BottomRebar1
        Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Anular, Me.Print, Me.CompraLoad})
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
        Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.CompraLoad1, Me.Separator2, Me.Anular1, Me.Separator4, Me.Print1, Me.Separator3, Me.Exit1})
        Me.UiCommandBar1.Key = "tbrMain"
        Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.UiCommandBar1.Name = "UiCommandBar1"
        Me.UiCommandBar1.RowIndex = 0
        Me.UiCommandBar1.Size = New System.Drawing.Size(376, 28)
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
        'CompraLoad1
        '
        Me.CompraLoad1.Key = "CompraLoad"
        Me.CompraLoad1.Name = "CompraLoad1"
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
        'CompraLoad
        '
        Me.CompraLoad.ImageIndex = 3
        Me.CompraLoad.Key = "CompraLoad"
        Me.CompraLoad.Name = "CompraLoad"
        Me.CompraLoad.Text = "Compra"
        Me.CompraLoad.ToolTipText = "Cargar Compra"
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
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuEdit})
        '
        'mnuShow
        '
        Me.mnuShow.Index = 0
        Me.mnuShow.Text = "Consultar"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "Editar"
        '
        'frmDevCompraEdit
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
        Me.Name = "frmDevCompraEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución Sobre Compra"
        Me.ExplorerBarContainerControl4.ResumeLayout(False)
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bcgMain.ResumeLayout(False)
        CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSucursal.ResumeLayout(False)
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
               mlngID = moDevCompra.DevCompraId
               mboolChanged = True
               chkConFac.Enabled = False

               cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
               cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

               If MessageBox.Show("Devolución Sobre Compra Guardada Exitosamente" + vbCrLf + "¿Desea Imprimir la Devolución Sobre Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call PrintReport()
               End If

               Me.Close()
            End If

         Case "CompraLoad"
            Call frmCompraLoad()

         Case "Anular"
            Call DevCompraAnular()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmDevCompraEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmDevCompraEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Devolución Sobre Compra"

         ElseIf OperaFechaHabil(ToDate(dtpFecha.Value)) Then
            Call HeaderReadOnly()
            Me.Text = "Editar Devolución Sobre Compra"

            cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True
            cdmMain.Commands.Item("CompraLoad").Enabled = Janus.Windows.UI.InheritableBoolean.False


         Else
            MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mboolEditing = False
            Call DataReadOnly()
            Me.Text = "Consulta Devolución Sobre Compra"
         End If

      Else
         Me.Text = "Nuevo Devolución Sobre Compra"
         Call FormNew()
      End If

      Call SecuritySet(Me, AppExeName)
      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

#Region " DevCompra "

   Private Sub FormShow()
      mboolShow = True
      With moDevCompra
         txtDevCompraId.Text = ToStr(.DevCompraId)
         dtpFecha.Text = ToStr(.Fecha)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, .AlmacenId)
         cboProveedor.Value = ListFindItem(cboProveedor, .ProveedorId)
         txtDevCompraNro.Text = ToStr(.DevCompraNro)
         txtCompraNro.Tag = .CompraId
         txtCompraNro.Text = CompraNroFind(.CompraId)
         txtDevCompraDes.Text = ToStr(.DevCompraDes)
         txtDevCompraObs.Text = ToStr(.DevCompraObs)
         chkConFac.Checked = .ConFac
         chkSinFac.Checked = .SinFac
         cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

         If Not clsAppInfo.MultipleNro Then
            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

         cdmMain.Commands.Item("CompraLoad").Enabled = Janus.Windows.UI.InheritableBoolean.False
      End With

      Call grdMainLoad()

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moDevCompra
         txtDevCompraId.Text = String.Empty
         dtpFecha.Text = ToStr(.Fecha)
         cboMoneda.SelectedIndex = -1
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 14)
         txtTipoCambio.Text = "0"
         cboAlmacen.SelectedIndex = -1
         cboProveedor.Value = Nothing
         txtDevCompraNro.Text = "0"
         txtDevCompraDes.Text = String.Empty
         txtDevCompraObs.Text = String.Empty
         Call txtTipoCambioLoad(ToDate(dtpFecha.Value))

         cboEstado.ReadOnly = True

         mdecDevCompraMonto = 0
         mlngItemCant = 0

         If clsAppInfo.MultipleNro Then
            chkConFac.Checked = False
            chkSinFac.Checked = False
         Else
            chkConFac.Checked = False
            chkSinFac.Checked = True

            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

         cboCentroCosto.SelectedIndex = -1
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, clsAppInfo.SucursalId)

         Call grdMainLoad()
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtDevCompraId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      cboAlmacen.ReadOnly = True
      cboProveedor.ReadOnly = True
      txtDevCompraNro.ReadOnly = True
      txtDevCompraDes.ReadOnly = True
      txtDevCompraObs.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False
      cboCentroCosto.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("CompraLoad").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False

   End Sub

   Private Sub HeaderReadOnly()
      txtDevCompraId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      cboAlmacen.ReadOnly = True
      cboProveedor.ReadOnly = True
      txtDevCompraNro.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False
      cboCentroCosto.ReadOnly = True
   End Sub

   Private Sub ViewComponent()
      If clsAppInfo.CentroCostoApli Then
         cboCentroCosto.Visible = True
         lblCentroCosto.Visible = True
      Else
         cboCentroCosto.Visible = False
         lblCentroCosto.Visible = False
      End If

      If clsAppInfo.SucursalApli Then
         lblSucursal.Visible = True
         cboSucursal.Visible = True
      Else
         lblSucursal.Visible = False
         cboSucursal.Visible = False
      End If
   End Sub

   Private Sub DataMove()
      With moDevCompra
         If Not mboolAdding Then
            .DevCompraId = ToLong(txtDevCompraId.Text)
         End If

         .Fecha = ToDate(dtpFecha.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .AlmacenId = ListPosition(cboAlmacen, cboAlmacen.SelectedIndex)
         .ProveedorId = ListPosition(cboProveedor)
         .DevCompraNro = ToLong(txtDevCompraNro.Text)
         .DevCompraDes = ToStr(txtDevCompraDes.Text)
         .DevCompraObs = ToStr(txtDevCompraObs.Text)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         .ConFac = ToBoolean(chkConFac.Checked)
         .SinFac = ToBoolean(chkSinFac.Checked)
         .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)

      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.False

      dtpFecha.Select()
   End Sub

   Private Function DataSave() As Boolean
      Dim lngTipoNotaId As Long
      Dim lngNotaId As Long
      Dim lngNotaNro As Long
      Dim lngCompId As Long
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim ProveedorMovId As Long

      Dim lngCol As Long = 1 'Columna q indica q debe ir al Haber

      Try
         Call DataMove()

         If moDevCompra.Validate Then
            If FormCheck() Then
               If DevMontoCheck() Then
                  If MessageBox.Show("¿Realmente Quiere Guardar la Devolución Sobre Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     If mboolAdding Then
                        If clsAppInfo.Inventario Then 'Adicion Integrado a Contabilidad
                           If frmCompPlanFill() Then
                              moDevCompra.DevCompraNro = CompraNroNext(clsTipoCompra.DEVOLUCION_COMPRA, clsAppInfo.GestionId, moDevCompra.SucursalId)

                              If DataAdd() Then
                                 txtDevCompraId.Text = ToStr(moDevCompra.DevCompraId)
                                 txtDevCompraNro.Text = ToStr(moDevCompra.DevCompraNro)

                                 If NotaAdd(lngNotaId, lngTipoNotaId, lngNotaNro) Then 'Cabecera de la Nota
                                    moDevCompra.NotaId = lngNotaId

                                    If grdMainSave(lngNotaId) Then
                                       Call grdMainDevCompraMonto()

                                       If CompNew(lngCompId, lngTipoCompId, lngCompNro) Then
                                          moDevCompra.CompId = lngCompId
                                          moDevCompra.PlanId = mlngPlanId 'Cuenta Variable

                                          If DataUpdate() Then

                                             If mboolAnticipo Then
                                                lngCol = 3  'Si el va ir DEBE y Haber
                                             End If

                                             If ProveedorMovAdd(ProveedorMovId, clsTipoCompra.DEVOLUCION_COMPRA, moDevCompra.DevCompraId, moDevCompra.TipoPagoId, moDevCompra.DevCompraDes, moDevCompra.MontoOrg, lngCol, lngTipoCompId, lngCompNro, mlngPlanId, mlngTipoPlanId) Then
                                                If AnticipoAdd() Then
                                                   If moDevCompra.TipoPagoId = clsTipoPago.CREDITO Then 'Credito
                                                      If moDevCompra.MontoOrg <= mdecCreditoSaldo Then 'Si el saldo del credito es mayor o igual al monto devuelto
                                                         If CreditoUpdate(moDevCompra.CreditoId) Then
                                                            If NotaUpdate(lngNotaId) Then
                                                               Call grdMainEstadoShow()
                                                               Call HeaderReadOnly()
                                                               If DataUpdate() Then
                                                                  DataSave = True
                                                               End If
                                                            End If
                                                         End If
                                                      Else
                                                         If DataUpdate() Then
                                                            DataSave = True
                                                         End If
                                                      End If
                                                   Else
                                                      If NotaUpdate(lngNotaId) Then
                                                         Call grdMainEstadoShow()
                                                         Call HeaderReadOnly()
                                                         If DataUpdate() Then
                                                            DataSave = True
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
                           End If

                        Else
                           moDevCompra.DevCompraNro = CompraNroNext(clsTipoCompra.DEVOLUCION_COMPRA, clsAppInfo.GestionId, moDevCompra.SucursalId)
                           mlngSucursalId = SucursalIdFind(moDevCompra.AlmacenId)
                           mlngCentroCostoId = moDevCompra.CentroCostoId

                           If DataAdd() Then
                              txtDevCompraId.Text = ToStr(moDevCompra.DevCompraId)
                              txtDevCompraNro.Text = ToStr(moDevCompra.DevCompraNro)

                              If NotaAdd(lngNotaId, lngTipoNotaId, lngNotaNro) Then 'Cabecera de la Nota
                                 'moDevCompra.TipoNotaId = lngTipoNotaId
                                 'moDevCompra.NotaNro = lngNotaNro
                                 moDevCompra.NotaId = lngNotaId

                                 If grdMainSave(lngNotaId) Then
                                    Call grdMainDevCompraMonto()

                                    If DataUpdate() Then
                                       If ProveedorMovAdd(ProveedorMovId, clsTipoCompra.DEVOLUCION_COMPRA, moDevCompra.DevCompraId, moDevCompra.TipoPagoId, moDevCompra.DevCompraDes, moDevCompra.MontoOrg, lngCol, lngTipoCompId, lngCompNro, mlngPlanId, mlngTipoPlanId) Then
                                          If moDevCompra.TipoPagoId = clsTipoPago.CREDITO Then 'Credito
                                             If moDevCompra.MontoOrg <= mdecCreditoSaldo Then 'Si el saldo del credito es mayor o igual al monto devuelto
                                                If CreditoUpdate(moDevCompra.CreditoId) Then
                                                   If NotaUpdate(lngNotaId) Then
                                                      Call grdMainEstadoShow()
                                                      Call HeaderReadOnly()
                                                      DataSave = True
                                                   End If
                                                End If
                                             End If
                                          Else
                                             If NotaUpdate(lngNotaId) Then
                                                Call grdMainEstadoShow()
                                                Call HeaderReadOnly()
                                                DataSave = True
                                             End If
                                          End If
                                       End If
                                    End If
                                 End If
                              End If
                           End If
                        End If

                     Else
                        If DataUpdate() Then
                           DataSave = True
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

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moDevCompra.Insert() Then
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

         If moDevCompra.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim i As Long = 0
      Dim intCol As Integer

        If cboSucursal.SelectedIndex = -1 Then
            FormCheck = False
            Throw New Exception("Revise La Sucursal")
        Else
            If CompSucursalApeExist(moDevCompra.EmpresaId, moDevCompra.GestionId, moDevCompra.SucursalId) Then
                If Not NotaSucursalApeExist(moDevCompra.EmpresaId, moDevCompra.GestionId, moDevCompra.SucursalId) Then
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

      If dtpFecha.Value > Now Then
         FormCheck = False
         Throw New Exception("Fecha no Valida, No puede ser mayor a la Actual")
      End If

      If (Not chkConFac.Checked) And (Not chkSinFac.Checked) Then
         FormCheck = False
         Throw New Exception("Valores Inválidos en (I o F)")
      End If

      If clsAppInfo.CentroCostoApli Then
         If cboCentroCosto.SelectedIndex = -1 Then
            FormCheck = False
            Throw New Exception("Revise El Centro de Costo")
         End If
      End If

      If moDevCompra.CompraId = 0 Then
         strMsg &= "Compra Inválida" + vbCrLf
      End If

      intCol = grdMain.Col
      grdMain.Col = 0
      grdMain.Col = intCol

      If mboolGridCancel Then
         Return False
      End If

      If grdMain.RowCount <= 0 Then
         strMsg &= "Devolución Sobre Compra Sin Detalle" + vbCrLf
      End If

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If (oRow.Cells("CantidadDev").Value > 0) And (oRow.Cells("Importe").Value <= 0) Then
            strMsg &= oRow.Cells("ItemDes").Value & " : Importe Invalido" + vbCrLf

         ElseIf (oRow.Cells("CantidadDev").Value > 0) And (oRow.Cells("Importe").Value > 0) Then
            i += 1
         End If
      Next

      If i = 0 Then
         strMsg &= "Detalle de Devolución Sobre Compra Inválida" + vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub grdMainDevCompraMonto()
      Dim decMontoOrg As Decimal = 0
      Dim decMontoCos As Decimal = 0
      Dim decMontoNet As Decimal = 0

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("CantidadDev").Value > 0 Then
            decMontoOrg += ToDecimal(oRow.Cells("PrecioOrg").Value * oRow.Cells("CantidadDev").Value)
            decMontoCos += ToDecimal(oRow.Cells("PrecioCos").Value * oRow.Cells("CantidadDev").Value)
            decMontoNet += ToDecimal(oRow.Cells("PrecioNet").Value * oRow.Cells("CantidadDev").Value)
         End If
      Next

      moDevCompra.MontoOrg = decMontoOrg
      moDevCompra.MontoCos = decMontoCos
      moDevCompra.MontoNet = decMontoNet
   End Sub

   Private Function grdMainImporte(ByVal lngPlanId As Long) As Decimal
      Dim decImporte As Decimal = 0

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("PlanId").Value = lngPlanId Then
            decImporte = decImporte + oRow.Cells("Importe").Value
         End If
      Next

      Return decImporte
   End Function

   Private Function grdMainItemInventario() As Boolean
      grdMainItemInventario = False

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("CantidadDev").Value > 0 Then
            If oRow.Cells("TipoItemId").Value = 1 Then 'Inventario
               Return True
            End If
         End If
      Next
   End Function

   Private Function CompraMontoInv() As Decimal
      CompraMontoInv = 0

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("CantidadDev").Value > 0 Then
            If oRow.Cells("TipoItemId").Value = 1 Then
               CompraMontoInv += ToDecimal(oRow.Cells("PrecioCos").Value * oRow.Cells("CantidadDev").Value)
            End If
         End If
      Next

   End Function

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraNroNext = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moDevCompra.EmpresaId
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
            .EmpresaId = moDevCompra.EmpresaId
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

   Private Function CompraNroFind(ByVal lngCompraId As Long) As Long
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               Return .CompraNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function NotaAdd(ByRef lngNotaId As Long, ByRef lngTipoNotaId As Long, ByRef lngNotaNro As Long) As Boolean
      If Not (grdMainItemInventario()) Then
         Return True
      End If

      Dim oNota As New clsNota(clsAppInfo.ConnectString)

      NotaAdd = False

      Try
         With oNota
            .EmpresaId = moDevCompra.EmpresaId
            .TipoNotaId = 3 'Salida
            .NotaNro = NotaNroNext(.TipoNotaId, moDevCompra.GestionId, moDevCompra.SucursalId)
            .Fecha = moDevCompra.Fecha
            .AlmacenIdOrg = moDevCompra.AlmacenId
            .AlmacenIdDes = 0
            .MonedaId = moDevCompra.MonedaId
            .TipoCambio = moDevCompra.TipoCambio
            .NotaDes = "Devolución Sobre Compra Nro. " + txtDevCompraNro.Text
            .NotaObs = ""
            .NotaMonto = 0
            .GestionId = moDevCompra.GestionId
            '.TipoCompId = 0
            '.CompNro = 0
            .PlanId = 0
            .EstadoId = clsEstado.CERRADO
            .ConFac = moDevCompra.ConFac
            .SinFac = moDevCompra.SinFac
            .CentroCostoIdOrg = moDevCompra.CentroCostoId
            .CentroCostoIdDes = 0

            .SucursalId = moDevCompra.SucursalId
            .CompId = 0
            .AppId = moDevCompra.AppId
            .TipoDocumentoId = clsTipoCompra.DEVOLUCION_COMPRA
            .DocumentoId = moDevCompra.DevCompraId

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

   Private Function NotaUpdate(ByVal lngNotaId As Long) As Boolean
      If Not (grdMainItemInventario()) Then
         Return True
      End If

      Dim oNota As New clsNota(clsAppInfo.ConnectString)

      NotaUpdate = False

      Try
         With oNota
            .NotaId = lngNotaId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               '.TipoCompId = moDevCompra.TipoCompId
               '.CompNro = moDevCompra.CompNro
               .PlanId = moDevCompra.PlanId
               '.NotaMonto = moDevCompra.MontoCos
               .NotaMonto = ToDecimal(CompraMontoInv())
               .CompId = moDevCompra.CompId

               If .Update Then
                  NotaUpdate = True
               End If
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
            .EmpresaId = moDevCompraDet.EmpresaId
            .GestionId = moDevCompraDet.GestionId
            .TipoNotaId = 3
            .TipoMovId = 2
            .NotaId = lngNotaId
            .Fecha = moDevCompraDet.Fecha
            .AlmacenId = moDevCompraDet.AlmacenId
            .MonedaId = moDevCompraDet.MonedaId
            .TipoCambio = moDevCompraDet.TipoCambio
            .ItemId = moDevCompraDet.ItemId
            .MedidaId = moDevCompraDet.MedidaId
            .CantidadEnt = 0
            .CantidadSal = moDevCompraDet.CantidadDev
            .PrecioOrg = moDevCompraDet.PrecioNet

            If mlngTipoItemId <> 2 Then 'servicio
               .PrecioCos = moDevCompraDet.PrecioCos
               .Importe = moDevCompraDet.CantidadDev * moDevCompraDet.PrecioCos
            Else
               .PrecioCos = moDevCompraDet.PrecioNet
               .Importe = moDevCompraDet.CantidadDev * moDevCompraDet.PrecioNet
            End If

            .SucursalId = mlngSucursalId
            .CentroCostoId = mlngCentroCostoId
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

   Private Function NotaFind(ByVal lngTipoNotaId As Long, ByVal lngNotaNro As Long, ByVal lngSucursalId As Long, ByRef lngNotaId As Long) As Boolean
      Dim oNota As New clsNota(clsAppInfo.ConnectString)

      NotaFind = False

      Try
         With oNota
            .SelectFilter = clsNota.SelectFilters.All
            .WhereFilter = clsNota.WhereFilters.NotaNro
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
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

   Private Function NotaNroNext(ByVal lngTipoNotaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oNotaPara As New clsNotaPara(clsAppInfo.ConnectString)

      Try
         NotaNroNext = 0

         With oNotaPara
            .SelectFilter = clsNotaPara.SelectFilters.All
            .WhereFilter = clsNotaPara.WhereFilters.TipoNotaId
            .EmpresaId = moDevCompra.EmpresaId
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

   Private Sub grdMainPlanId()
      Dim lngPlanIdCos As Long

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("Importe").Value > 0 Then
            oRow.BeginEdit()
            oRow.Cells("PlanIdAct").Value = PlanIdActFind(oRow.Cells("ItemId").Value, lngPlanIdCos)
            oRow.Cells("PlanIdCos").Value = lngPlanIdCos
            oRow.EndEdit()
         End If
      Next
   End Sub

   Private Function PlanIdActFind(ByVal lngItemId As Long, ByRef lngPlanIdCos As Long) As Long
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
                     lngPlanIdCos = .PlanIdCos
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

   Private Function ProveedorPlanIdPasFind(ByVal lngProveedorId As Long, ByRef lngPlanAddIdPas As Long) As Long
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      ProveedorPlanIdPasFind = 0

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               lngPlanAddIdPas = .PlanAddIdPas
               Return .PlanIdPas
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function TipoItemIdFind(ByVal lngItemId As Long) As Long
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               Return .TipoItemId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Function

   ''Private Function CompNew(ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
   ''   Dim oRow As Janus.Windows.GridEX.GridEXRow
   ''   Dim decMontoBs As Decimal
   ''   Dim decMontoUs As Decimal
   ''   Dim decMontoOrg As Decimal
   ''   Dim decMontoBsOld As Decimal = 0
   ''   Dim decMontoUsOld As Decimal = 0
   ''   Dim decMontoOrgOld As Decimal = 0
   ''   Dim lngCompId As Long
   ''   Dim lngCompDetId As Long
   ''   Dim lngCompPlanAddId As Long
   ''   Dim lngCompCentroCostoDetId As Long

   ''   Dim decTotalMontoBs As Decimal = 0
   ''   Dim decTotalMontoUs As Decimal = 0
   ''   Dim decTotalMontoOrg As Decimal = 0

   ''   CompNew = True

   ''   Try
   ''      Call grdMainPlanId()

   ''      ''If grdMainItemInventario() Then
   ''      lngTipoCompId = 3 'Traspaso

   ''      If CompAdd(lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante
   ''         For Each oRow In grdMain.GetRows
   ''            If (ToStr(oRow.Cells("Estado").Value) = "New") And (oRow.Cells("Importe").Value > 0) Then
   ''               If TipoItemIdFind(oRow.Cells("ItemId").Value) <> 3 Then 'Item Paquete
   ''                  If moDevCompra.MonedaId = 1 Then
   ''                     decMontoBs = ToDecimal(oRow.Cells("CantidadDev").Value * oRow.Cells("PrecioOrg").Value)
   ''                     decMontoUs = ToDecimal(decMontoBs / moDevCompra.TipoCambio)
   ''                     decMontoOrg = decMontoBs
   ''                     decTotalMontoBs += decMontoBs
   ''                     decTotalMontoUs += decMontoUs
   ''                     decTotalMontoOrg += decMontoOrg

   ''                  ElseIf moDevCompra.MonedaId = 2 Then
   ''                     decMontoUs = ToDecimal(oRow.Cells("CantidadDev").Value * oRow.Cells("PrecioOrg").Value)
   ''                     decMontoBs = ToDecimal(decMontoUs * moDevCompra.TipoCambio)
   ''                     decMontoOrg = decMontoUs
   ''                     decTotalMontoBs += decMontoBs
   ''                     decTotalMontoUs += decMontoUs
   ''                     decTotalMontoOrg += decMontoOrg
   ''                  End If
   ''               End If
   ''            End If
   ''         Next

   ''         If (decTotalMontoBs > 0) And (decTotalMontoUs > 0) Then
   ''            'Cuenta de Pasivo del Proveedor
   ''            If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 1, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
   ''               If mlngPlanAddId <> 0 Then  'Analitico Adicional
   ''                  If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 1) Then
   ''                     CompNew = True
   ''                  End If
   ''               End If

   ''               If mlngCentroCostoDetId <> 0 Then  'Actividad
   ''                  If CompCentroCostoDetAdd(lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, decMontoBs, decMontoUs, 1) Then
   ''                     CompNew = True
   ''                  End If
   ''               End If
   ''            End If
   ''         End If

   ''         For Each oRow In grdMain.GetRows
   ''            If (ToStr(oRow.Cells("Estado").Value) = "New") And (oRow.Cells("Importe").Value > 0) Then
   ''               If TipoItemIdFind(oRow.Cells("ItemId").Value) <> 3 Then 'Item Servicio
   ''                  If moDevCompra.MonedaId = 1 Then
   ''                     decMontoBs = ToDecimal(oRow.Cells("CantidadDev").Value * oRow.Cells("PrecioOrg").Value)
   ''                     decMontoUs = ToDecimal(decMontoBs / moDevCompra.TipoCambio)
   ''                     decMontoOrg = decMontoBs

   ''                  ElseIf moDevCompra.MonedaId = 2 Then
   ''                     decMontoUs = ToDecimal(oRow.Cells("CantidadDev").Value * oRow.Cells("PrecioOrg").Value)
   ''                     decMontoBs = ToDecimal(decMontoUs * moDevCompra.TipoCambio)
   ''                     decMontoOrg = decMontoUs
   ''                  End If

   ''                  'Cuenta Activo Item
   ''                  If Not CompDetFind(lngCompId, lngCompDetId, oRow.Cells("PlanIdAct").Value, 2, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
   ''                     If CompDetAdd(lngTipoCompId, lngCompId, oRow.Cells("PlanIdAct").Value, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
   ''                        CompNew = True

   ''                        If mlngCentroCostoDetId <> 0 Then  'Actividad
   ''                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow.Cells("PlanIdAct").Value, mlngCentroCostoId, mlngCentroCostoDetId, decMontoBs, decMontoUs, 2) Then
   ''                              CompNew = True
   ''                           End If
   ''                        End If
   ''                     End If

   ''                  ElseIf CompDetUpdate(lngCompDetId, "", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 2) Then
   ''                     'If CompPlanAddFind(lngCompId, lngCompDetId, lngCompPlanAddId) Then
   ''                     '   If CompPlanAddUpdate(lngCompPlanAddId, decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, 2) Then
   ''                     '      CompNew = True
   ''                     '   End If
   ''                     'End If

   ''                     'If CompCentroCostoDetFind(lngCompId, lngCompDetId, lngCompCentroCostoDetId) Then
   ''                     '   If CompCentroCostoDetUpdate(lngCompCentroCostoDetId, decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, 2) Then
   ''                     '      CompNew = True
   ''                     '   End If
   ''                     'End If

   ''                     CompNew = True

   ''                     If mlngCentroCostoDetId <> 0 Then  'Actividad
   ''                        If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow.Cells("PlanIdAct").Value, mlngCentroCostoId, mlngCentroCostoDetId, decMontoBs, decMontoUs, 2) Then
   ''                           CompNew = True
   ''                        End If
   ''                     End If
   ''                  End If
   ''               End If
   ''            End If
   ''         Next

   ''         If CompUpdate(lngCompId, decTotalMontoBs, decTotalMontoUs) Then
   ''            CompNew = True
   ''         End If
   ''      End If
   ''      ''Else
   ''      ''CompNew = True
   ''      ''End If

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   ''      Return False

   ''   End Try
   ''End Function

   Private Function CompNew(ByRef lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      Dim oRow As Janus.Windows.GridEX.GridEXRow
      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal
      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0
      'Dim lngCompId As Long
      Dim lngCompDetId As Long
      Dim lngCompPlanAddId As Long
      Dim lngCompCentroCostoDetId As Long

      Dim decTotalMontoBs As Decimal = 0
      Dim decTotalMontoUs As Decimal = 0
      Dim decTotalMontoOrg As Decimal = 0

      Dim decDevMontoBs As Decimal = 0
      Dim decDevMontoUs As Decimal = 0
      Dim decDevMontoOrg As Decimal = 0

      Dim decExeIcePor As Decimal

      Dim decIvaBs As Decimal = 0
      Dim decIvaUs As Decimal = 0
      Dim decIvaOrg As Decimal = 0

      Dim decICE_IEHDBs As Decimal = 0
      Dim decICE_IEHDUs As Decimal = 0
      Dim decICE_IEHDOrg As Decimal = 0

      Dim decGralMontoBs As Decimal = 0
      Dim decGralMontoUs As Decimal = 0

      CompNew = True

      Try
         Call grdMainPlanId()

         ''If grdMainItemInventario() Then
         lngTipoCompId = 3 'Traspaso

         If CompAdd(lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante
            For Each oRow In grdMain.GetRows
               If (ToStr(oRow.Cells("Estado").Value) = "New") And (oRow.Cells("Importe").Value > 0) Then
                  If TipoItemIdFind(oRow.Cells("ItemId").Value) <> 3 Then 'Item Paquete
                     If moDevCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(oRow.Cells("CantidadDev").Value * oRow.Cells("PrecioOrg").Value)
                        decMontoUs = ToDecimal(decMontoBs / moDevCompra.TipoCambio)
                        decMontoOrg = decMontoBs
                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moDevCompra.MonedaId = 2 Then
                        decMontoUs = ToDecimal(oRow.Cells("CantidadDev").Value * oRow.Cells("PrecioOrg").Value)
                        decMontoBs = ToDecimal(decMontoUs * moDevCompra.TipoCambio)
                        decMontoOrg = decMontoUs
                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg
                     End If
                  End If
               End If
            Next

            If (decTotalMontoBs > 0) And (decTotalMontoUs > 0) Then
               'Cuenta de Pasivo del Proveedor
               If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 1, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                  If mlngPlanAddId <> 0 Then  'Analitico Adicional
                     If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 1, moDevCompra.SucursalId) Then
                        CompNew = True
                     End If
                  End If

                  If mlngCentroCostoDetId <> 0 Then  'Actividad
                     If CompCentroCostoDetAdd(lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, decMontoBs, decMontoUs, 1, moDevCompra.SucursalId) Then
                        CompNew = True
                     End If
                  End If
               End If
            End If

            For Each oRow In grdMain.GetRows
               If (ToStr(oRow.Cells("Estado").Value) = "New") And (oRow.Cells("Importe").Value > 0) Then
                  If TipoItemIdFind(oRow.Cells("ItemId").Value) <> 3 Then 'Item Servicio
                     If moDevCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(oRow.Cells("CantidadDev").Value * oRow.Cells("PrecioOrg").Value)
                        decMontoUs = ToDecimal(decMontoBs / moDevCompra.TipoCambio)
                        decMontoOrg = decMontoBs

                     ElseIf moDevCompra.MonedaId = 2 Then
                        decMontoUs = ToDecimal(oRow.Cells("CantidadDev").Value * oRow.Cells("PrecioOrg").Value)
                        decMontoBs = ToDecimal(decMontoUs * moDevCompra.TipoCambio)
                        decMontoOrg = decMontoUs
                     End If

                     'Cuenta Activo Item
                     If Not CompDetFind(lngCompId, lngCompDetId, oRow.Cells("PlanIdAct").Value, 2, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
                        If CompDetAdd(lngTipoCompId, lngCompId, oRow.Cells("PlanIdAct").Value, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                           CompNew = True

                           If mlngCentroCostoDetId <> 0 Then  'Actividad
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow.Cells("PlanIdAct").Value, mlngCentroCostoId, mlngCentroCostoDetId, decMontoBs, decMontoUs, 2, moDevCompra.SucursalId) Then
                                 CompNew = True
                              End If
                           End If
                        End If

                     ElseIf CompDetUpdate(lngCompDetId, "", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 2) Then
                        'If CompPlanAddFind(lngCompId, lngCompDetId, lngCompPlanAddId) Then
                        '   If CompPlanAddUpdate(lngCompPlanAddId, decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, 2) Then
                        '      CompNew = True
                        '   End If
                        'End If

                        'If CompCentroCostoDetFind(lngCompId, lngCompDetId, lngCompCentroCostoDetId) Then
                        '   If CompCentroCostoDetUpdate(lngCompCentroCostoDetId, decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, 2) Then
                        '      CompNew = True
                        '   End If
                        'End If

                        CompNew = True

                        If mlngCentroCostoDetId <> 0 Then  'Actividad
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow.Cells("PlanIdAct").Value, mlngCentroCostoId, mlngCentroCostoDetId, decMontoBs, decMontoUs, 2, moDevCompra.SucursalId) Then
                              CompNew = True
                           End If
                        End If
                     End If
                  End If
               End If
            Next

            If CompUpdate(lngCompId, decTotalMontoBs, decTotalMontoUs) Then
               CompNew = True
            End If
         End If
         ''Else
         ''CompNew = True
         ''End If

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
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = CompNroNext(.TipoCompId, moDevCompra.GestionId, moDevCompra.SucursalId)
            .Fecha = moDevCompra.Fecha
            .MonedaId = moDevCompra.MonedaId
            .TipoCambio = moDevCompra.TipoCambio
            .EntregadoA = ToStr(cboProveedor.Text)
            .PorConcepto = "Devolución Sobre Compra Nro. " + txtDevCompraNro.Text
            .DebeBs = 0
            .HaberBs = 0
            .DebeUs = 0
            .HaberUs = 0
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF
            .Automatico = 0
            .Glosa = ""
            '.TipoNotaId = moDevCompra.TipoNotaId
            '.NotaNro = moDevCompra.NotaNro
            .TipoAsientoId = 0
            .EstadoId = 10
            .ConFac = moDevCompra.ConFac
            .SinFac = moDevCompra.SinFac

            .SucursalId = moDevCompra.SucursalId
            .NotaId = moDevCompra.NotaId
            .AppId = moDevCompra.AppId
            .TipoDocumentoId = clsTipoCompra.DEVOLUCION_COMPRA
            .DocumentoId = moDevCompra.DevCompraId


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

   Private Function CompDetAdd(ByVal lngTipoCompId As Long, ByVal lngCompId As Long, ByVal lngPlanId As Long, _
                              ByVal strDes As String, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, _
                              ByVal decValorOrg As Decimal, ByVal lngCol As Long, Optional ByVal lngSucursalId As Long = 0, _
                              Optional ByVal lngCentroCostoId As Long = 0, Optional ByRef lngCompDetId As Long = 0, _
                              Optional ByVal bytAutomatico As Byte = 0) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = moDevCompra.Fecha
            .PlanId = lngPlanId
            .CompDetDes = ToStr("Devolución Sobre Compra Nro. " + txtDevCompraNro.Text + " " + strDes)
            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId
            .MonedaId = moDevCompra.MonedaId

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

   Private Function CompIdFind(ByVal lngSucursalId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Long
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompIdFind = 0

      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.All
            .WhereFilter = clsComp.WhereFilters.CompNro
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .SucursalId = lngSucursalId

            If .Find Then
               CompIdFind = .CompId
               lngTipoCompId = .TipoCompId
               lngCompNro = .CompNro
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
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
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

   Private Function CompPlanAddAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
                                 ByVal lngPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAdd = False

      Try
         With oCompPlanAdd
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moDevCompra.Fecha
            .PlanId = lngPlanId
            .MonedaId = moDevCompra.MonedaId
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
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moDevCompra.Fecha
            .PlanId = lngPlanId
            .MonedaId = moDevCompra.MonedaId
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
            .EmpresaId = moDevCompra.EmpresaId
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
            .EmpresaId = moDevCompra.EmpresaId
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

   Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompNroNext = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moDevCompra.EmpresaId
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
            .EmpresaId = moDevCompra.EmpresaId
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

   Private Function frmCompPlanFill() As Boolean
      Dim frmDevCompraSelec As New frmDevCompraSeleccion
      Dim boolGenAnticipo As Boolean

      Dim frm As New frmCompPlan
      frmCompPlanFill = False

      mlngPlanId = 0
      mlngPlanAddId = 0
      mlngSucursalId = 0
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
      mlngTipoPlanId = 0

      If clsAppInfo.CentroCostoApli Then
         mlngCentroCostoId = moDevCompra.CentroCostoId
      End If

      If clsAppInfo.SucursalApli Then
         mlngSucursalId = moDevCompra.SucursalId
      End If

      If moDevCompra.TipoPagoId = 1 Then 'Contado
         With frmDevCompraSelec
            .ShowDialog()

            If .Changed Then
               mboolAnticipo = .Anticipo

               If mboolAnticipo Then
                  mlngPlanId = ClientePlanIdPasFind(moDevCompra.ProveedorId, mlngPlanAddId)
                  mlngTipoPlanId = TipoPlanIdFind(mlngPlanId)
                  mboolTieneComp = True
                  frmCompPlanFill = True
               Else

                  With frm
                     .EmpresaId = moDevCompra.EmpresaId
                     ''.PlanWhereFilter = clsPlan.WhereFilters.EsAna
                     .PlanWhereFilter = clsPlan.WhereFilters.CajaBanco
                     .CentroCostoId = moDevCompra.CentroCostoId
                     .SucursalId = moDevCompra.SucursalId
                     .ShowDialog()

                     If .Changed Then
                        mlngPlanId = frm.PlanId
                        mlngPlanAddId = frm.PlanAddId
                        mlngSucursalId = frm.SucursalId
                        mlngCentroCostoId = frm.CentroCostoId
                        mlngCentroCostoDetId = frm.CentroCostoDetId
                        mlngTipoPlanId = TipoPlanIdFind(mlngPlanId)
                        mboolTieneComp = frm.TieneComp

                        frmCompPlanFill = True
                     End If

                     frm.Dispose()
                  End With
               End If

            End If 'frm Changed Select

            frmDevCompraSelec.Dispose()
         End With 'FrmSelect

      Else 'Credito
         Call grdMainDevCompraMonto()
         mdecCreditoSaldo = CreditoSaldoFind(moDevCompra.CreditoId)

         If moDevCompra.MontoOrg <= mdecCreditoSaldo Then
            mlngPlanId = ProveedorPlanIdPasFind(moDevCompra.ProveedorId, mlngPlanAddId)
            mboolTieneComp = True
            frmCompPlanFill = True
         Else
            With frmDevCompraSelec
               .ShowDialog()

               If .Changed Then
                  mboolAnticipo = .Anticipo

                  If mboolAnticipo Then
                     mlngPlanId = ClientePlanIdPasFind(moDevCompra.ProveedorId, mlngPlanAddId)
                     mlngTipoPlanId = TipoPlanIdFind(mlngPlanId)
                     mboolTieneComp = True
                     frmCompPlanFill = True
                  Else

                     With frm
                        .EmpresaId = moDevCompra.EmpresaId
                        ''.PlanWhereFilter = clsPlan.WhereFilters.EsAna
                        .PlanWhereFilter = clsPlan.WhereFilters.CajaBanco
                        .CentroCostoId = moDevCompra.CentroCostoId
                        .ShowDialog()

                        If .Changed Then
                           mlngPlanId = frm.PlanId
                           mlngPlanAddId = frm.PlanAddId
                           mlngSucursalId = frm.SucursalId
                           mlngCentroCostoId = frm.CentroCostoId
                           mlngCentroCostoDetId = frm.CentroCostoDetId
                           mlngTipoPlanId = TipoPlanIdFind(mlngPlanId)
                           mboolTieneComp = frm.TieneComp

                           frmCompPlanFill = True

                        End If

                        frm.Dispose()
                     End With
                  End If

               End If 'frm Changed Select   

               frmDevCompraSelec.Dispose()
            End With 'FrmSelect

         End If
      End If
   End Function

   Private Function CreditoSaldoFind(ByVal lngCreditoId As Long) As Decimal
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      CreditoSaldoFind = 0

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               Return .MontoLiq - .MontoAmo
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function CreditoUpdate(ByVal lngCreditoId As Long) As Boolean
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      CreditoUpdate = False

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               If CreditoDetUpdate(lngCreditoId) Then

                  If moDevCompra.MontoOrg <= mdecCreditoSaldo Then
                     .FechaIni = ToDate(.FechaIni)
                     .FechaFin = ToDate(.FechaFin)
                     .MontoAmo += moDevCompra.MontoOrg

                     If moDevCompra.MontoOrg < mdecCreditoSaldo Then
                        .EstadoId = 15 'Programado
                     Else
                        .EstadoId = 14 'Realizado
                     End If

                     If .Update Then
                        If .EstadoId = 14 Then
                           CompraUpdate(.CompraId, .EstadoId)
                           CreditoUpdate = True
                        Else
                           CreditoUpdate = True
                        End If

                     End If
                  Else
                     CreditoUpdate = True
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function CreditoDetUpdate(ByVal lngCreditoId As Long) As Boolean
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)
      Dim decMontoDev As Decimal
      Dim decCapitalPen As Decimal

      CreditoDetUpdate = False

      Try
         With oCreditoDet
            .SelectFilter = clsCreditoDet.SelectFilters.All
            .WhereFilter = clsCreditoDet.WhereFilters.CreditoIdSinPago
            .OrderByFilter = clsCreditoDet.OrderByFilters.CreditoDetId
            .EmpresaId = moDevCompra.EmpresaId
            .CreditoId = lngCreditoId
            .EstadoId = 15 'Programado

            If .Open Then
               decMontoDev = moDevCompra.MontoOrg

               Do While .Read
                  If (.Capital - .CapitalAmo) > decMontoDev Then
                     .CapitalAmo += decMontoDev
                     .Fecha = ToDate(.Fecha)
                     .FechaAmo = moDevCompra.Fecha

                     If .Update Then
                        decMontoDev = 0
                        CreditoDetUpdate = True
                        Exit Do
                     End If

                  ElseIf (.Capital - .CapitalAmo) = decMontoDev Then
                     .CapitalAmo += decMontoDev
                     .Fecha = ToDate(.Fecha)
                     .FechaAmo = moDevCompra.Fecha
                     .EstadoId = 14 'Realizado

                     If .Update Then
                        decMontoDev = 0
                        CreditoDetUpdate = True
                        Exit Do
                     End If

                  Else
                     decCapitalPen = decMontoDev - (.Capital - .CapitalAmo)
                     .CapitalAmo += (.Capital - .CapitalAmo)
                     .Fecha = ToDate(.Fecha)
                     .FechaAmo = moDevCompra.Fecha
                     .EstadoId = 14 'Realizado

                     If .Update Then
                        decMontoDev = decCapitalPen
                     End If
                  End If

                  Call .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCreditoDet.Dispose()

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

   Private Function ProveedorMovAdd(ByRef lngProveedorMovId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal lngTipoPagoId As Long, ByVal strProveedorMovDes As String, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long, ByVal lngTipoPlanId As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
            .ProveedorId = moDevCompra.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moDevCompra.Fecha
            .ProveedorMovDes = strProveedorMovDes
            .MonedaId = moDevCompra.MonedaId
            .TipoCambio = moDevCompra.TipoCambio
            .CentroCostoId = moDevCompra.CentroCostoId
            .SucursalId = moDevCompra.SucursalId
            .EstadoId = clsEstado.ABIERTO 'Abierto

            If lngTipoPagoId = clsTipoPago.CONTADO Then 'Contado
               If (lngTipoPlanId = clsPlan.CAJA Or lngTipoPlanId = clsPlan.CUENTA_CORRIENTE) Then
                  If .MonedaId = clsMoneda.BOLIVIANOS Then
                     .DebeBs = decValor
                     .DebeUs = ToDecimal(decValor / .TipoCambio)

                     .HaberBs = .DebeBs
                     .HaberUs = .DebeUs

                  ElseIf .MonedaId = clsMoneda.DOLARES Then
                     .DebeBs = ToDecimal(decValor * .TipoCambio)
                     .DebeUs = decValor

                     .HaberBs = .DebeBs
                     .HaberUs = .DebeUs
                  End If
               Else
                  If .MonedaId = clsMoneda.BOLIVIANOS Then
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


                  ElseIf .MonedaId = clsMoneda.DOLARES Then
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
               End If

            Else 'Credito

               If Not (mlngCompraEstadoId = clsEstado.REALIZADO) Then
                  If .MonedaId = clsMoneda.BOLIVIANOS Then
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

                  ElseIf .MonedaId = clsMoneda.DOLARES Then
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

               ElseIf (lngTipoPlanId = clsPlan.CAJA Or lngTipoPlanId = clsPlan.CUENTA_CORRIENTE) Then
                  If .MonedaId = clsMoneda.BOLIVIANOS Then
                     .DebeBs = decValor
                     .DebeUs = ToDecimal(decValor / .TipoCambio)

                     .HaberBs = .DebeBs
                     .HaberUs = .DebeUs

                  ElseIf .MonedaId = clsMoneda.DOLARES Then
                     .DebeBs = ToDecimal(decValor * .TipoCambio)
                     .DebeUs = decValor

                     .HaberBs = .DebeBs
                     .HaberUs = .DebeUs
                  End If
               Else
                  If .MonedaId = clsMoneda.BOLIVIANOS Then
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

                  ElseIf .MonedaId = clsMoneda.DOLARES Then
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

   Private Sub FormInit()
      Call FormCenter(Me)

      txtTipoCambio.FormatString = DecimalMask()
      txtDevCompraMonto.FormatString = DecimalMask()

      moDevCompraDet = New clsDevCompraDet(clsAppInfo.ConnectString)
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
            .EmpresaId = moDevCompra.EmpresaId
            .TipoAlmacenId = clsTipoAlmacen.INVENTARIO
            .AlmacenId = moDevCompra.AlmacenId
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
            .EmpresaId = moDevCompra.EmpresaId
            .ProveedorId = moDevCompra.ProveedorId
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
            .CentroCostoId = moDevCompra.CentroCostoId

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
            .TipoCompraId = clsTipoCompra.DEVOLUCION_COMPRA

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

   Private Sub frmCompraLoad()
      Dim frm As New frmCompra

      frm.Find = True
      frm.TipoPagoId = 3
      frm.EmpresaId = moDevCompra.EmpresaId
      frm.ShowDialog()

      If frm.Changed Then
         If CompraClone(frm.ID) Then
            moDevCompra.CompraId = frm.ID
            ItemTotal()
            cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True
         End If

      End If
      frm.Dispose()
   End Sub

   Private Function CompraClone(ByVal lngCompraId As Long) As Boolean
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
      Dim oDevCompraDet As New clsDevCompraDet(clsAppInfo.ConnectString)

      Dim boolNotaFind As Boolean
      Dim lngCantDev As Long = 0

      CompraClone = True

      Try
         Call grdMainClear()
         Call moDataSetInitLote(clsItemLote.TABLE_NAME)
         Call moDataSetInitSerie(clsItemNroSerie.TABLE_NAME)

         oCompra.CompraId = lngCompraId

         If oCompra.FindByPK Then
            cboMoneda.SelectedIndex = ListFindItem(cboMoneda, oCompra.MonedaId)
            cboProveedor.Value = ListFindItem(cboProveedor, oCompra.ProveedorId)
            cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, oCompra.AlmacenId)
            cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, oCompra.CentroCostoId)
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, oCompra.SucursalId)

            chkSinFac.Checked = oCompra.SinFac
            chkConFac.Checked = oCompra.ConFac
            chkSinFac.Enabled = False
            chkConFac.Enabled = False

            moDevCompra.TipoPagoId = oCompra.TipoPagoId
            moDevCompra.CompraId = oCompra.CompraId
            txtCompraNro.Tag = oCompra.CompraId
            txtCompraNro.Text = ToStr(oCompra.CompraNro)
            moDevCompra.CreditoId = oCompra.CreditoId
            moDevCompra.SucursalId = oCompra.SucursalId

            mlngCompraEstadoId = oCompra.EstadoId
            mboolCompraFacDif = oCompra.FacturaDif

            With oCompraDet
               .SelectFilter = clsCompraDet.SelectFilters.All
               .WhereFilter = clsCompraDet.WhereFilters.CompraId
               .EmpresaId = moDevCompra.EmpresaId
               .CompraId = lngCompraId

               'boolNotaFind = NotaFind(oCompra.TipoNotaId, oCompra.NotaNro, clsAppInfo.SucursalId, mlngNotaId)
               If oCompra.NotaId > 0 Then
                  boolNotaFind = isNotaFind(oCompra.NotaId, 0, 0)
                  mlngNotaId = oCompra.NotaId
                  boolNotaFind = True
               End If

               If .Open Then

                  Do While .Read

                     'lngCantDev = DevCompraDetCantidadDev(.CompraId, .ItemId)

                     lngCantDev = .Cantidad - .CantidadDev

                     ''If .Cantidad > lngCantDev Then ' Si Existe item para devolver
                     If lngCantDev > 0 Then

                        oDevCompraDet.ItemId = .ItemId
                        oDevCompraDet.MedidaId = .MedidaId
                        oDevCompraDet.CantidadOrg = .Cantidad - .CantidadDev

                        oDevCompraDet.CantidadDev = 0
                        ''oDevCompraDet.PrecioOrg = .PrecioOrg
                        oDevCompraDet.PrecioOrg = .PrecioOrg + .PrecioRec - .PrecioDes
                        oDevCompraDet.PrecioCos = .PrecioCos
                        oDevCompraDet.PrecioNet = .PrecioCos
                        oDevCompraDet.Importe = 0

                        moDataTable.Rows.Add(GetRowNew(oDevCompraDet))

                        ItemParametro(.ItemId)

                        If boolNotaFind Then
                           If mboolControlLote Then  ' verificando si tienes control el item 
                              Call itemLoteRowNew(mlngNotaId, .ItemId)
                           End If
                        End If

                        mlngItemCant += 1
                        'mdecDevCompraMonto += .Importe
                     End If
                     Call .MoveNext()
                  Loop
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      Finally
         oCompra.Dispose()
         oCompraDet.Dispose()
         oDevCompraDet.Dispose()

      End Try
   End Function

   Private Sub DevCompraAnular()

      Try
         If moDevCompra.EstadoId <> clsEstado.ANULADO Then
            If Not AnticipoTieneMovimiento(moDevCompra.AnticipoId) Then
               If MessageBox.Show("¿Realmente Quiere Anular la Devolución Sobre Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  If DevCompraAnular(moDevCompra.DevCompraId, clsEstado.ANULADO) Then
                     mlngID = moDevCompra.DevCompraId
                     mboolChanged = True
                     cboEstado.SelectedIndex = ListFindItem(cboEstado, clsEstado.ANULADO)
                     cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False

                     Me.Close()
                  End If
               End If
            Else
               MessageBox.Show("El Anticipo creado de la devolución ya tiene movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("La Devolución Sobre Compra ya Fue Anulada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try

   End Sub

   Private Function DevCompraAnular(ByVal lngDevCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oDevCompra As New clsDevCompra(clsAppInfo.ConnectString)
      Dim lngNotaId As Long
      Dim lngCompId As Long
      Dim lngCompNro As Long
      Dim lngTipoCompId As Long

      Try
         DevCompraAnular = False

         With oDevCompra
            .DevCompraId = lngDevCompraId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = lngEstadoId

               If .UpdateOnly() Then
                  If DevCompraDetAnular(lngDevCompraId, lngEstadoId) Then
                     moDevCompra.EstadoId = lngEstadoId
                     'NotaFind(moDevCompra.TipoNotaId, moDevCompra.NotaNro, clsAppInfo.SucursalId, lngNotaId)
                     If isNotaFind(moDevCompra.NotaId, 0, 0) Then
                        lngNotaId = moDevCompra.NotaId
                     End If

                     If moDevCompra.AnticipoId > 0 Then
                        AnticipoAnular(moDevCompra.AnticipoId, 12)
                     End If

                     If moDevCompra.TipoPagoId = 2 Then
                        If moDevCompra.CreditoId <> 0 Then
                           If EsProveedorMovDEBE(moDevCompra.DevCompraId) Then  'Si la devolución modifico el crédito

                              If CreditoAnular(moDevCompra.CreditoId) Then
                                 DevCompraAnular = True
                              End If

                           End If
                        End If

                     End If

                     If clsAppInfo.Inventario Then
                        'lngCompId = CompIdFind(clsAppInfo.SucursalId, lngTipoCompId, lngCompNro)
                        If isCompFind(moDevCompra.CompId, 0, 0) Then
                           lngCompId = moDevCompra.CompId
                        End If

                        If CompAnular(lngCompId, lngEstadoId) Then
                           If ProveedorMovAnular(3, lngDevCompraId) Then
                              DevCompraAnular = True
                           End If
                        End If
                     Else
                        If ProveedorMovAnular(3, lngDevCompraId) Then
                           DevCompraAnular = True
                        End If
                     End If

                     If lngNotaId <> 0 Then
                        If NotaAnular(lngNotaId, lngEstadoId) Then
                           DevCompraAnular = True
                        End If
                     Else
                        DevCompraAnular = True
                     End If

                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oDevCompra.Dispose()
      End Try

   End Function

   Private Function DevCompraDetAnular(ByVal lngDevCompraId As Long, ByVal lngEstado As Long) As Boolean
      Dim oDevCompraDet As New clsDevCompraDet(clsAppInfo.ConnectString)

      Try
         DevCompraDetAnular = False

         With oDevCompraDet
            .SelectFilter = clsDevCompraDet.SelectFilters.All
            .WhereFilter = clsDevCompraDet.WhereFilters.DEVCOMPRAID
            .EmpresaId = moDevCompra.EmpresaId
            .DevCompraId = lngDevCompraId

            If .Open() Then
               Do While .Read()
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstado

                  If .Update Then
                     Call UpdateCompraDetCantidadDev(.AlmacenId, .ItemId, -.CantidadDev)
                     DevCompraDetAnular = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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
                                 CompAnular = True
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
            .EmpresaId = moDevCompra.EmpresaId
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

   Private Function CompFacturaAnular(ByVal lngCompId As Long, ByVal lngEstado As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      CompFacturaAnular = False

      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompId
            .EmpresaId = moDevCompra.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .FacturaFecha = ToDate(.FacturaFecha)
                  .EstadoId = lngEstado

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
            .EmpresaId = moDevCompra.EmpresaId
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
            .EmpresaId = moDevCompra.EmpresaId
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
            .EmpresaId = moDevCompra.EmpresaId
            .NotaId = lngNotaId

            If .Open() Then
               Do While .Read()
                  Call ItemParametro(.ItemId)

                  If ItemSaldoRestore(lngNotaId, .NotaDetId, .ItemId, oNotaDet.AlmacenId, Constant.STATE_VOID) Then
                     .Fecha = ToDate(.Fecha)
                     .EstadoId = lngEstadoId

                     If .Update Then
                        NotaDetAnular = True
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function ItemSaldoRestore(ByVal lngNotaId As Long, ByVal lngNotaDetId As Long, ByVal lngItemId As Long, _
                                  ByVal lngAlmacenId As Long, ByVal byteEstado As Byte) As Boolean
      If (mlngTipoCosteoId = 1) Or (mlngTipoCosteoId = 2) Then
         ItemSaldoRestore = ItemSaldoRestoreDif(lngNotaDetId, lngItemId, lngAlmacenId)

      ElseIf mlngTipoCosteoId = 3 Then
         If ItemPepsRestoreAdd(lngNotaDetId, lngAlmacenId) Then
            ItemSaldoRestore = ItemSaldoRestoreDif(lngNotaDetId, lngItemId, lngAlmacenId)
         End If

      ElseIf mlngTipoCosteoId = 4 Then
         If ItemUepsRestoreAdd(lngNotaDetId, lngAlmacenId) Then
            ItemSaldoRestore = ItemSaldoRestoreDif(lngNotaDetId, lngItemId, lngAlmacenId)
         End If
      End If

      'Item Lote y Serie
      If ItemSaldoRestore Then
         If mboolControlLote Then
            ItemSaldoRestore = itemLoteSaldoRestore(lngNotaId, lngNotaDetId)
         End If

         If mboolControlSerie Then
            ItemSaldoRestore = itemNroSerieRestore(lngNotaId, lngItemId)
         End If

      End If

   End Function

   Private Function ItemSaldoRestoreDif(ByVal lngNotaDetId As Long, ByVal lngItemId As Long, ByVal lngAlmacenId As Long) As Boolean
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)
      Dim strFechaIni As String

      Try
         ItemSaldoRestoreDif = False

         With oItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.All
            .WhereFilter = clsItemSaldo.WhereFilters.ItemId
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Find Then
               Dim decSaldo As Decimal
               Dim decPPP As Decimal
               Dim decUPC As Decimal

               decSaldo = ItemSaldoActual(lngNotaDetId, lngItemId, lngAlmacenId, decPPP, decUPC)

               .PrecioFecha = ToDate(.PrecioFecha)
               .Saldo = decSaldo
               .PrecioUPC = decUPC
               .PrecioPPP = decPPP

               If .Update Then
                  ItemSaldoRestoreDif = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemSaldo.Dispose()

      End Try
   End Function

   Private Function ItemSaldoActual(ByVal lngNotaDetId As Long, ByVal lngItemId As Long, ByVal lngAlmacenId As Long, _
                                    ByRef decPPP As Decimal, ByRef decUPC As Decimal) As Decimal
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)
      Dim decCantidadAcu As Decimal = 0
      Dim decImporteAcu As Decimal = 0
      Dim decCantidad As Decimal = 0
      Dim decImporte As Decimal = 0

      ItemSaldoActual = 0
      decPPP = 0
      decUPC = 0

      Try
         With oNotaDet
            .SelectFilter = clsNotaDet.SelectFilters.All
            .WhereFilter = clsNotaDet.WhereFilters.SaldoActual
            .OrderByFilter = clsNotaDet.OrderByFilters.NotaDetId
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Open() Then
               Do While .Read()
                  If .NotaDetId <> lngNotaDetId Then
                     If .TipoMovId = 1 Then 'Entrada
                        If .MedidaId = mlngMedidaId Then
                           decCantidad = .CantidadEnt
                        Else
                           decCantidad = .CantidadEnt * mdecMedidaCantEqui
                        End If

                        If mlngMonedaIdCos = 1 Then
                           If .MonedaId = mlngMonedaIdCos Then
                              decImporte = .CantidadEnt * .PrecioCos

                              If .MedidaId = mlngMedidaId Then
                                 decUPC = .PrecioCos
                              Else
                                 decUPC = ToDecimal(.PrecioCos / mdecMedidaCantEqui)
                              End If
                           Else
                              decImporte = .CantidadEnt * (.PrecioCos * .TipoCambio)

                              If .MedidaId = mlngMedidaId Then
                                 decUPC = .PrecioCos * .TipoCambio
                              Else
                                 decUPC = ToDecimal((.PrecioCos * .TipoCambio) / mdecMedidaCantEqui)
                              End If
                           End If

                        ElseIf mlngMonedaIdCos = 2 Then
                           If .MonedaId = mlngMonedaIdCos Then
                              decImporte = .CantidadEnt * .PrecioCos

                              If .MedidaId = mlngMedidaId Then
                                 decUPC = .PrecioCos
                              Else
                                 decUPC = ToDecimal(.PrecioCos / mdecMedidaCantEqui)
                              End If
                           Else
                              decImporte = .CantidadEnt * (.PrecioCos / .TipoCambio)

                              If .MedidaId = mlngMedidaId Then
                                 decUPC = .PrecioCos / .TipoCambio
                              Else
                                 decUPC = ToDecimal((.PrecioCos / .TipoCambio) / mdecMedidaCantEqui)
                              End If
                           End If
                        End If

                        decCantidadAcu += decCantidad
                        decImporteAcu += decImporte

                     Else 'Salida
                        If .MedidaId = mlngMedidaId Then
                           decCantidad = .CantidadSal
                        Else
                           decCantidad = .CantidadSal * mdecMedidaCantEqui
                        End If

                        If mlngMonedaIdCos = 1 Then
                           If .MonedaId = mlngMonedaIdCos Then
                              decImporte = .CantidadSal * .PrecioCos
                           Else
                              decImporte = .CantidadSal * (.PrecioCos * .TipoCambio)
                           End If

                        ElseIf mlngMonedaIdCos = 2 Then
                           If .MonedaId = mlngMonedaIdCos Then
                              decImporte = .CantidadSal * .PrecioCos
                           Else
                              decImporte = .CantidadSal * (.PrecioCos / .TipoCambio)
                           End If
                        End If

                        decCantidadAcu -= decCantidad
                        decImporteAcu -= decImporte
                     End If
                  End If

                  .MoveNext()
               Loop
            End If

            decPPP = decImporteAcu / ToDivByCero(decCantidadAcu)

            If decPPP = 0 Then
               decPPP = decUPC
               ItemSaldoActual = 0
            Else
               decPPP = ToDecimal(decPPP)
               decUPC = ToDecimal(decUPC)
               ItemSaldoActual = ToDecimal(decCantidadAcu)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNotaDet.Dispose()

      End Try
   End Function

   Private Function ItemPepsRestoreAdd(ByVal lngNotaDetId As Long, ByVal lngAlmacenId As Long) As Boolean
      Dim oItemPeps As New clsItemPeps(clsAppInfo.ConnectString)
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)

      Try
         ItemPepsRestoreAdd = False

         oNotaDet.NotaDetId = lngNotaDetId

         If oNotaDet.FindByPK Then
            With oItemPeps
               .EmpresaId = oNotaDet.EmpresaId
               .GestionId = oNotaDet.GestionId
               .AlmacenId = lngAlmacenId
               .NotaId = oNotaDet.NotaId
               .NotaDetId = oNotaDet.NotaDetId
               .ItemId = oNotaDet.ItemId
               .Fecha = ToDate(oNotaDet.Fecha)
               .FechaNro = ItemPepsFechaNroNext(lngAlmacenId)

               If mlngMedidaId = oNotaDet.MedidaId Then
                  .Precio = ItemPEPS(oNotaDet.PrecioCos)
                  .Saldo = oNotaDet.CantidadSal
               Else
                  .Precio = ItemPEPS(oNotaDet.PrecioCos / mdecMedidaCantEqui)
                  .Saldo = ToDecimal(oNotaDet.CantidadSal * mdecMedidaCantEqui)
               End If

               If .Insert Then
                  ItemPepsRestoreAdd = True
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

   Private Function ItemPepsFechaNroNext(ByVal lngAlmacenId As Long) As Long
      Dim oItemPeps As New clsItemPeps(clsAppInfo.ConnectString)

      Try
         ItemPepsFechaNroNext = 0

         With oItemPeps
            .RowMaxFilter = clsItemPeps.RowMaxFilters.FechaNro
            .WhereFilter = clsItemPeps.WhereFilters.Fecha

            .EmpresaId = moDevCompraDet.EmpresaId
            .GestionId = moDevCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = moDevCompraDet.ItemId
            .Fecha = moDevCompraDet.Fecha

            ItemPepsFechaNroNext = .RowMax + 1
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPeps.Dispose()

      End Try
   End Function

   Private Function ItemPEPS(ByVal decPrecioCos As Decimal) As Decimal
      Dim decPrecio As Decimal = decPrecioCos

      If moDevCompra.MonedaId = 1 Then
         If moDevCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos / moDevCompra.TipoCambio)
         End If

      ElseIf moDevCompra.MonedaId = 2 Then
         If moDevCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos * moDevCompra.TipoCambio)
         End If
      End If

      Return decPrecio
   End Function

   Private Function ItemUepsRestoreAdd(ByVal lngNotaDetId As Long, ByVal lngAlmacenId As Long) As Boolean
      Dim oItemUeps As New clsItemUeps(clsAppInfo.ConnectString)
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)

      Try
         ItemUepsRestoreAdd = False

         oNotaDet.NotaDetId = lngNotaDetId

         If oNotaDet.FindByPK Then
            With oItemUeps
               .EmpresaId = oNotaDet.EmpresaId
               .GestionId = oNotaDet.GestionId
               .AlmacenId = lngAlmacenId
               .NotaId = oNotaDet.NotaId
               .NotaDetId = oNotaDet.NotaDetId
               .ItemId = oNotaDet.ItemId
               .Fecha = ToDate(oNotaDet.Fecha)
               .FechaNro = ItemUepsFechaNroNext(lngAlmacenId)

               If mlngMedidaId = oNotaDet.MedidaId Then
                  .Precio = ItemUEPS(oNotaDet.PrecioCos)
                  .Saldo = oNotaDet.CantidadSal
               Else
                  .Precio = ItemUEPS(oNotaDet.PrecioCos / mdecMedidaCantEqui)
                  .Saldo = ToDecimal(oNotaDet.CantidadSal * mdecMedidaCantEqui)
               End If

               If .Insert Then
                  ItemUepsRestoreAdd = True
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

   Private Function ItemUepsFechaNroNext(ByVal lngAlmacenId As Long) As Long
      Dim oItemUeps As New clsItemUeps(clsAppInfo.ConnectString)

      Try
         ItemUepsFechaNroNext = 0

         With oItemUeps
            .RowMaxFilter = clsItemUeps.RowMaxFilters.FechaNro
            .WhereFilter = clsItemUeps.WhereFilters.Fecha

            .EmpresaId = moDevCompraDet.EmpresaId
            .GestionId = moDevCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = moDevCompraDet.ItemId
            .Fecha = moDevCompraDet.Fecha

            ItemUepsFechaNroNext = .RowMax + 1
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemUeps.Dispose()

      End Try
   End Function

   Private Function ItemUEPS(ByVal decPrecioCos As Decimal) As Decimal
      Dim decPrecio As Decimal = decPrecioCos

      If moDevCompra.MonedaId = 1 Then
         If moDevCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos / moDevCompra.TipoCambio)
         End If

      ElseIf moDevCompra.MonedaId = 2 Then
         If moDevCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos * moDevCompra.TipoCambio)
         End If
      End If

      Return decPrecio
   End Function

   ' --  Devuelve la Canidad de devolucion que se realizaron de una Compra
   Private Function DevCompraDetCantidadDev(ByVal lngCompraId As Long, ByVal lngItemId As Long) As Decimal
      Dim oDevCompraDet As New clsDevCompraDet(clsAppInfo.ConnectString)

      Dim SumaDevolucion As Decimal = 0
      Try
         With oDevCompraDet
            .SelectFilter = clsDevCompraDet.SelectFilters.All
            .WhereFilter = clsDevCompraDet.WhereFilters.CompraItemId
            .EmpresaId = clsAppInfo.EmpresaId
            .CompraId = lngCompraId
            .ItemId = lngItemId

            If .Open() Then
               Do While .Read()
                  SumaDevolucion += .CantidadDev

                  .MoveNext()
               Loop

            End If

         End With

         Return SumaDevolucion

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oDevCompraDet.Dispose()
      End Try
   End Function

   Private Function CompraUpdate(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      CompraUpdate = False

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = lngEstadoId

               If .Update() Then
                  If CompraDetUpdate(lngCompraId, lngEstadoId) Then
                     CompraUpdate = True
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

   Private Function CompraDetUpdate(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

      CompraDetUpdate = False

      Try
         With oCompraDet
            .SelectFilter = clsCompraDet.SelectFilters.All
            .WhereFilter = clsCompraDet.WhereFilters.CompraId
            .EmpresaId = moDevCompra.EmpresaId
            .CompraId = lngCompraId

            If .Open Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update() Then
                     CompraDetUpdate = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try
   End Function

   Private Function ClientePlanIdPasFind(ByVal lngProveedorId As Long, ByRef lngPlanAddId As Long) As Long
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      ClientePlanIdPasFind = 0

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

   Private Function DevMontoCheck() As Boolean
      Dim strMsg As String = String.Empty

      If moDevCompra.TipoPagoId = 2 Then 'Credito
         mdecCreditoSaldo = CreditoSaldoFind(moDevCompra.CreditoId)
         Call grdMainDevCompraMonto()

         If moDevCompra.MontoOrg > mdecCreditoSaldo And mdecCreditoSaldo > 0 Then
            strMsg &= "La Devolución Sobre Compra Crédito esta Programada" + vbCrLf
            strMsg &= "por lo tanto, el monto de la devolución no debe ser mayor al saldo del Credito" + vbCrLf
         End If

      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         DevMontoCheck = False
      Else
         DevMontoCheck = True
      End If
   End Function

   Private Function AnticipoAdd() As Boolean

      If mboolAnticipo Then

         AnticipoAdd = False
         Dim ProveedorMovId As Long
         Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

         Try
            With oAnticipo
               .EmpresaId = moDevCompra.EmpresaId
               .GestionId = moDevCompra.GestionId
               .Fecha = ToDate(dtpFecha.Value)
               .MonedaId = moDevCompra.MonedaId
               .TipoAnticipoId = 2
               .TipoCambio = ToDecimal(txtTipoCambio.Text)
               .AnticipoNro = CompraNroNext(4, clsAppInfo.GestionId, moDevCompra.SucursalId)
               .ProveedorId = moDevCompra.ProveedorId
               .AnticipoDes = "ANT/ DEVOLUCION SOBRE COMPRA # " + ToStr(moDevCompra.DevCompraNro)
               .AnticipoObs = ""
               .PedCompraId = 0
               .CentroCostoId = moDevCompra.CentroCostoId

               .MontoAnt = moDevCompra.MontoOrg
               .MontoDes = 0
               .EstadoId = 13

               If clsAppInfo.MultipleNro Then
                  ''chkConFac.Checked = False
                  ''chkSinFac.Checked = False
               Else
                  .ConFac = False
                  .SinFac = True

               End If

               .ConFac = moDevCompra.ConFac
               .SinFac = moDevCompra.SinFac

               .SucursalId = moDevCompra.SucursalId
               .AppId = clsAppInfo.AppId
               .TipoDocumentoId = clsTipoCompra.DEVOLUCION_COMPRA
               .DocumentoId = moDevCompra.DocumentoId

               If .Insert Then
                  If ProveedorMovAdd(ProveedorMovId, clsTipoCompra.ANTICIPO, .AnticipoId, 2, .AnticipoDes, .MontoAnt, 1, 0, 0, mlngPlanId, mlngTipoPlanId) Then
                     moDevCompra.AnticipoId = .AnticipoId
                     AnticipoAdd = True
                  End If
               End If

            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         Finally
            oAnticipo.Dispose()

         End Try
      Else
         AnticipoAdd = True
      End If
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

                  If ProveedorMovAnular(4, .AnticipoId) Then
                     AnticipoAnular = True
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

   Private Function AnticipoTieneMovimiento(ByVal lngAnticipoId As Long) As Boolean
      If lngAnticipoId <= 0 Then
         Return False
      End If

      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)
      AnticipoTieneMovimiento = False

      Try
         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.AnticipoId
            .EmpresaId = clsAppInfo.EmpresaId
            .AnticipoId = lngAnticipoId

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

   Private Function ProveedorMovAnular(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAnular = False

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.DocumentoId
            .EmpresaId = moDevCompra.EmpresaId
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

   Private Function CreditoAnular(ByVal lngCreditoId As Long) As Boolean
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      CreditoAnular = False

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               If CreditoDetAnular(lngCreditoId) Then

                  .FechaIni = ToDate(.FechaIni)
                  .FechaFin = ToDate(.FechaFin)
                  .MontoAmo -= moDevCompra.MontoOrg
                  .EstadoId = 15 'Programado

                  If .MontoAmo < 0 Then
                     .MontoAmo = 0
                  End If

                  If .Update Then

                     If CompraUpdate(.CompraId, 15) Then
                        CreditoAnular = True
                     End If

                  End If

               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function CreditoDetAnular(ByVal lngCreditoId As Long) As Boolean
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)

      CreditoDetAnular = False

      Try
         With oCreditoDet
            .SelectFilter = clsCreditoDet.SelectFilters.All
            .WhereFilter = clsCreditoDet.WhereFilters.CompraId
            .EmpresaId = moDevCompra.EmpresaId
            .CompraId = moDevCompra.CompraId

            If .Find Then

               .CapitalAmo -= moDevCompra.MontoOrg

               .Fecha = ToDate(.Fecha)
               .FechaAmo = moDevCompra.Fecha
               .EstadoId = 15 'Programado

               If .CapitalAmo < 0 Then
                  .CapitalAmo = 0
               End If

               If .Update Then
                  CreditoDetAnular = True
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCreditoDet.Dispose()

      End Try
   End Function

   Private Function EsProveedorMovDEBE(ByVal lngDevCompraId As Long) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      EsProveedorMovDEBE = False

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.DocumentoId

            .DocumentoId = lngDevCompraId
            .EmpresaId = clsAppInfo.EmpresaId
            .TipoCompraId = 3  'Devolucion de Compra
            .EstadoId = 11

            If .Find Then
               If .DebeBs > 0 And .HaberBs = 0 And .DebeUs > 0 And .HaberUs = 0 Then
                  EsProveedorMovDEBE = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

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
      Dim rpt As New rptDevCompraEdit
      Dim oDevCompra As New clsDevCompra(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim strTitulo As String

      Try
         oDevCompra.SelectFilter = clsDevCompra.SelectFilters.Report
         oDevCompra.WhereFilter = clsDevCompra.WhereFilters.Report
         oDevCompra.OrderByFilter = clsDevCompra.OrderByFilters.Report
         oDevCompra.EmpresaId = moDevCompra.EmpresaId
         oDevCompra.DevCompraId = moDevCompra.DevCompraId

         If oDevCompra.Find Then
            rpt.DataSource = oDevCompra.DataSet.Tables(oDevCompra.TableName).DefaultView

            rpt.txtFirma.Text = CompraParaFirma(3, moDevCompra.GestionId, moDevCompra.SucursalId, strTitulo, lngTipoHojaId)
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
         oDevCompra.Dispose()

      End Try
   End Sub

   Private Function CompraParaFirma(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByRef strTitulo As String, ByRef lngTipoHojaId As Long) As String
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaFirma = ""

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moDevCompra.EmpresaId
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
         If Not IsNothing(moDevCompra) Then
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
      Else
         cboProveedor.DisplayMember = "ProveedorCod"
      End If
   End Sub

#End Region

#Region " Detalle del Pedido de Compra "

   Private Sub grdMainLoad()
      Dim oRow As DataRow
      Dim boolNotaFind As Boolean

      Try
         With moDevCompraDet
            .SelectFilter = clsDevCompraDet.SelectFilters.Grid
            .WhereFilter = clsDevCompraDet.WhereFilters.Grid
            .OrderByFilter = clsDevCompraDet.OrderByFilters.Grid
            .EmpresaId = moDevCompra.EmpresaId
            .DevCompraId = moDevCompra.DevCompraId


            If .Open() Then
               Call moDataSetInit()
               Call moDataSetInitLote(clsItemLote.TABLE_NAME)
               Call moDataSetInitSerie(clsItemNroSerie.TABLE_NAME)

               'boolNotaFind = NotaFind(moDevCompra.TipoNotaId, moDevCompra.NotaNro, moDevCompra.SucursalId, mlngNotaId)
               If moDevCompra.NotaId > 0 Then
                  boolNotaFind = isNotaFind(moDevCompra.NotaId, 0, 0)
                  mlngNotaId = moDevCompra.NotaId
                  boolNotaFind = True
               End If

               For Each oRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRowShow(oRow))

                  If boolNotaFind Then
                     If ToBoolean(oRow("ControlLote")) Then  ' verificando si tienes control el item 
                        Call itemLoteRowShow(mlngNotaId, oRow("ItemId"))
                     End If

                     If ToBoolean(oRow("ControlSerie")) Then
                        Call itemNroSerieRowShow(mlngNotaId, oRow("ItemId"))
                     End If
                  End If


                  mlngItemCant += 1
                  mdecDevCompraMonto += oRow("Importe")
               Next

               grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            Call ItemTotal()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moDevCompraDet.TableName)

      moDataTable.Columns.Add("DevCompraDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanIdAct", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanIdCos", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MedidaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CantidadOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("CantidadDev", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioCos", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioNet", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Importe", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Estado", Type.GetType("System.String"))
   End Sub

   Private Function GetRowShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("DevCompraDetId") = oDataRow("DevCompraDetId")
      oRow("ItemId") = oDataRow("ItemId")
      oRow("ItemCod") = oDataRow("ItemCod")
      oRow("ItemDes") = oDataRow("ItemDes")
      oRow("TipoItemId") = oDataRow("TipoItemId")
      oRow("MedidaId") = oDataRow("MedidaId")
      oRow("MedidaDes") = oDataRow("MedidaDes")
      oRow("CantidadOrg") = oDataRow("CantidadOrg")
      oRow("CantidadDev") = oDataRow("CantidadDev")
      oRow("PrecioOrg") = oDataRow("PrecioOrg")
      oRow("PrecioCos") = oDataRow("PrecioCos")
      oRow("PrecioNet") = oDataRow("PrecioNet")
      oRow("Importe") = oDataRow("Importe")
      oRow("Estado") = "Show"

      Return oRow
   End Function

   Private Function GetRowNew(ByVal oDevCompraDet As clsDevCompraDet) As DataRow
      Dim strItemCod As String
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Dim lngTipoItemId As Long

      oRow("DevCompraDetId") = 0
      oRow("ItemId") = oDevCompraDet.ItemId
      oRow("ItemDes") = ItemDesFind(oDevCompraDet.ItemId, strItemCod, lngTipoItemId)
      oRow("ItemCod") = strItemCod
      oRow("TipoItemId") = lngTipoItemId
      oRow("MedidaId") = oDevCompraDet.MedidaId
      oRow("MedidaDes") = MedidaDesFind(oDevCompraDet.MedidaId)
      oRow("CantidadOrg") = oDevCompraDet.CantidadOrg
      oRow("CantidadDev") = oDevCompraDet.CantidadDev
      oRow("PrecioOrg") = oDevCompraDet.PrecioOrg
      oRow("PrecioCos") = oDevCompraDet.PrecioCos
      oRow("PrecioNet") = oDevCompraDet.PrecioNet
      oRow("Importe") = oDevCompraDet.Importe
      oRow("Estado") = "New"

      Return oRow
   End Function

   Private Sub RowNewEdit(ByRef oRow As DataRow, ByVal oDevCompraDet As clsDevCompraDet, ByVal strEstado As String)
      Dim strItemCod As String
      Dim lngTipoItemId As Long

      oRow("DevCompraDetId") = 0
      oRow("ItemId") = oDevCompraDet.ItemId
      oRow("ItemDes") = ItemDesFind(oDevCompraDet.ItemId, strItemCod, lngTipoItemId)
      oRow("ItemCod") = strItemCod
      oRow("TipoItemId") = lngTipoItemId
      oRow("MedidaId") = oDevCompraDet.MedidaId
      oRow("MedidaDes") = MedidaDesFind(oDevCompraDet.MedidaId)
      oRow("CantidadOrg") = oDevCompraDet.CantidadOrg
      oRow("CantidadDev") = oDevCompraDet.CantidadDev
      oRow("PrecioOrg") = oDevCompraDet.PrecioOrg
      oRow("PrecioCos") = oDevCompraDet.PrecioCos
      oRow("PrecioNet") = oDevCompraDet.PrecioNet
      oRow("Importe") = oDevCompraDet.Importe
      oRow("Estado") = strEstado

   End Sub

   Private Sub grdMainShow()
      Dim oDevCompraDet As New clsDevCompraDet(clsAppInfo.ConnectString)
      Dim frm As New frmDevCompraDetEdit

      Try
         If grdMain.RowCount > 0 Then
            If ToStr(grdMain.GetValue("Estado")) = "Show" Then
               With oDevCompraDet
                  .DevCompraDetId = ToLong(grdMain.GetValue("DevCompraDetId"))


                  frm.DataTableLote = itemLoteRowFilter(ToLong(grdMain.GetValue("ItemId")))
                  frm.DataTableSerie = itemNroSerieRowFilter(ToLong(grdMain.GetValue("ItemId")))
                  frm.NotaId = mlngNotaId

                  If .FindByPK Then
                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oDevCompraDet
                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With


            ElseIf ToStr(grdMain.GetValue("Estado")) = "New" Then
               If mboolAdding Then
                  If OperaFechaHabil(ToDate(dtpFecha.Value)) Then
                     Call DataMove()
                     Call moDevCompra.Validate()

                     If dtpFecha.Value > Now Then
                        Throw New Exception("Fecha no Valida, No puede ser mayor a la Actual")
                     End If

                  Else
                     MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     Exit Sub
                  End If
               End If

               With frm
                  .NewRecord = False
                  .Editing = False
                  .NewCloneDevVentaDet = True

                  oDevCompraDet.EmpresaId = ToLong(moDevCompra.EmpresaId)
                  oDevCompraDet.GestionId = ToLong(moDevCompra.GestionId)
                  oDevCompraDet.DevCompraId = ToLong(moDevCompra.DevCompraId)
                  oDevCompraDet.Fecha = ToDate(dtpFecha.Value)
                  oDevCompraDet.AlmacenId = ToLong(moDevCompra.AlmacenId)
                  oDevCompraDet.ProveedorId = ToLong(moDevCompra.ProveedorId)
                  oDevCompraDet.MonedaId = ToLong(moDevCompra.MonedaId)
                  oDevCompraDet.TipoCambio = ToDecimal(moDevCompra.TipoCambio)

                  oDevCompraDet.CompraId = ToLong(moDevCompra.CompraId)
                  oDevCompraDet.ItemId = ToLong(grdMain.GetValue("ItemId"))
                  oDevCompraDet.MedidaId = ToLong(grdMain.GetValue("MedidaId"))
                  oDevCompraDet.CantidadOrg = ToDecimal(grdMain.GetValue("CantidadOrg"))
                  oDevCompraDet.CantidadDev = ToDecimal(grdMain.GetValue("CantidadDev"))
                  oDevCompraDet.PrecioCos = ToDecimal(grdMain.GetValue("PrecioCos"))
                  oDevCompraDet.PrecioOrg = ToDecimal(grdMain.GetValue("PrecioOrg"))
                  oDevCompraDet.Importe = ToDecimal(grdMain.GetValue("Importe"))

                  .DataObject = oDevCompraDet

                  .DataTableLote = itemLoteRowFilter(ToLong(grdMain.GetValue("ItemId")))
                  .DataTableSerie = itemNroSerieRowFilter(ToLong(grdMain.GetValue("ItemId")))
                  .NotaId = mlngNotaId

                  .ShowDialog()
                  frm.Dispose()
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDevCompraDet.Dispose()

      End Try
   End Sub

   Private Sub grdMainEdit()
      Dim frm As New frmDevCompraDetEdit
      Dim oDevCompraDet As New clsDevCompraDet(clsAppInfo.ConnectString)
      Dim decImporteOld As Decimal

      Try
         If grdMain.RowCount > 0 Then
            If ToStr(grdMain.GetValue("Estado")) = "New" Then
               If mboolAdding Then
                  If OperaFechaHabil(ToDate(dtpFecha.Value)) Then
                     Call DataMove()
                     Call moDevCompra.Validate()
                  Else
                     MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     Exit Sub
                  End If
               End If

               With frm
                  .NewRecord = False
                  .Editing = True
                  .NewCloneDevVentaDet = True

                  oDevCompraDet.EmpresaId = ToLong(moDevCompra.EmpresaId)
                  oDevCompraDet.GestionId = ToLong(moDevCompra.GestionId)
                  oDevCompraDet.DevCompraId = ToLong(moDevCompra.DevCompraId)
                  oDevCompraDet.Fecha = ToDate(dtpFecha.Value)
                  oDevCompraDet.AlmacenId = ToLong(moDevCompra.AlmacenId)
                  oDevCompraDet.ProveedorId = ToLong(moDevCompra.ProveedorId)
                  oDevCompraDet.MonedaId = ToLong(moDevCompra.MonedaId)
                  oDevCompraDet.TipoCambio = ToDecimal(moDevCompra.TipoCambio)
                  oDevCompraDet.CentroCostoId = ToLong(moDevCompra.CentroCostoId)

                  'oDevVentaDet.VentaId = ToLong(grdMain.GetValue("VentaId"))
                  oDevCompraDet.ItemId = ToLong(grdMain.GetValue("ItemId"))
                  oDevCompraDet.MedidaId = ToLong(grdMain.GetValue("MedidaId"))
                  oDevCompraDet.CantidadOrg = ToDecimal(grdMain.GetValue("CantidadOrg"))
                  oDevCompraDet.CantidadDev = ToDecimal(grdMain.GetValue("CantidadDev"))
                  oDevCompraDet.PrecioCos = ToDecimal(grdMain.GetValue("PrecioCos"))
                  oDevCompraDet.PrecioOrg = ToDecimal(grdMain.GetValue("PrecioOrg"))
                  oDevCompraDet.PrecioNet = ToDecimal(grdMain.GetValue("PrecioNet"))
                  oDevCompraDet.Importe = ToDecimal(grdMain.GetValue("Importe"))
                  decImporteOld = oDevCompraDet.Importe

                  Call mqueItemLoad(oDevCompraDet.ItemId)
                  .ItemList = mqueItem
                  .DataObject = oDevCompraDet

                  .DataTableLote = itemLoteRowFilter(ToLong(grdMain.GetValue("ItemId")))
                  .DataTableSerie = itemNroSerieRowFilter(ToLong(grdMain.GetValue("ItemId")))
                  .NotaId = mlngNotaId

                  .DataTableLoteDelete = itemLoteTablaDelete()

                  .ShowDialog()

                  If .Changed Then
                     Call DataViewAll()
                     Call RowNewEdit(moDataTable.Rows(grdMainFindRowId(frm.ID)), frm.DataObject, "New")
                     Call itemLoteRowFill(frm.ID)
                     Call itemNroSerieRowFill(frm.ID)

                     mdecDevCompraMonto = (mdecDevCompraMonto - decImporteOld) + frm.DataObject.Importe
                     Call ItemTotal()

                     mboolEditGrid = True

                  End If

                  frm.Dispose()
                  mboolEditing = True
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDevCompraDet.Dispose()

      End Try
   End Sub

   Private Sub ItemTotal()
      txtDevCompraMonto.Text = mdecDevCompraMonto
      txtItemCant.Text = mlngItemCant
   End Sub

   Private Sub DevCompraTotal()
      mdecDevCompraMonto = 0
      mlngItemCant = 0

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("Importe").Value > 0 Then
            mdecDevCompraMonto += oRow.Cells("Importe").Value
            mlngItemCant += 1
         End If
      Next

      txtDevCompraMonto.Text = mdecDevCompraMonto
      txtItemCant.Text = mlngItemCant
   End Sub

   Private Sub mqueItemLoad(Optional ByVal lngItemId As Long = 0)
      Dim oRow As DataRow

      mqueItem.Clear()

      For Each oRow In moDataSet.Tables(moDevCompraDet.TableName).Rows
         If ToLong(oRow("ItemId")) <> lngItemId Then
            mqueItem.Enqueue(oRow("ItemId"))
         End If
      Next
   End Sub

   Private Sub grdMainClear()
      Call moDataSetInit()
      grdMain.DataSource = moDataSet.Tables(moDevCompraDet.TableName).DefaultView
      grdMain.RetrieveStructure()
      Call grdMainInit()

      mdecDevCompraMonto = 0
      mlngItemCant = 0
      Call ItemTotal()
   End Sub

   Private Sub grdMainEstadoShow()
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         oRow.BeginEdit()
         oRow.Cells("Estado").Value = "Show"
         oRow.EndEdit()
      Next
   End Sub

   Private Function grdMainSave(Optional ByVal lngNotaId As Long = 0) As Boolean
      Dim lngNotaDetId As Long

      grdMainSave = True

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
            If oRow.Cells("CantidadDev").Value > 0 Then
               If ToStr(oRow.Cells("Estado").Value) = "New" Then
                  Call ItemParametro(oRow.Cells("ItemId").Value)
                  Call ItemSaldoParametro(oRow.Cells("ItemId").Value, moDevCompra.AlmacenId)
                  Call grdMainMove(oRow)

                  If moDevCompraDet.Insert() Then
                     Call moDevCompraDet.CloseConection()

                     If mlngTipoItemId <> 2 Then 'Item de Servicio
                        Call NotaDetAdd(lngNotaId, lngNotaDetId)
                        Call ItemSaldoRestar(moDevCompra.AlmacenId, lngNotaId, lngNotaDetId)
                     End If
                  End If

                  Call UpdateCompraDetCantidadDev(moDevCompraDet.AlmacenId, oRow.Cells("ItemId").Value, oRow.Cells("CantidadDev").Value)
               End If
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function UpdateCompraDetCantidadDev(ByVal lngAlmacenId As Long, ByVal lngItemId As Long, ByVal decCantDevuelto As Decimal) As Boolean
      Dim oVentaDet As New clsCompraDet(clsAppInfo.ConnectString)
      UpdateCompraDetCantidadDev = False

      With oVentaDet
         .SelectFilter = clsCompraDet.SelectFilters.All
         .WhereFilter = clsCompraDet.WhereFilters.ItemId
         .GestionId = moDevCompra.GestionId
         .EmpresaId = moDevCompra.EmpresaId
         .CompraId = moDevCompra.CompraId
         .ItemId = lngItemId
         .AlmacenId = lngAlmacenId

         If (.Open) Then

            If (.Read) Then

               .UpdateFilter = clsCompraDet.UpdateFilters.CantidadDev
               .CantidadDev = decCantDevuelto

               If (.Update) Then
                  UpdateCompraDetCantidadDev = True
               End If
            End If
         End If

         .CloseConection()
      End With

   End Function

   Private Sub grdMainMove(ByRef oRow As Janus.Windows.GridEX.GridEXRow)
      Dim decPrecioCos As Decimal
      With moDevCompraDet
         .DevCompraDetId = ToLong(oRow.Cells("DevCompraDetId").Value)
         .EmpresaId = ToLong(moDevCompra.EmpresaId)
         .GestionId = ToLong(moDevCompra.GestionId)
         .CompraId = ToLong(moDevCompra.CompraId)
         .DevCompraId = ToLong(moDevCompra.DevCompraId)
         .Fecha = ToDate(dtpFecha.Value)
         .AlmacenId = ToLong(moDevCompra.AlmacenId)
         .ProveedorId = ToLong(moDevCompra.ProveedorId)
         .MonedaId = ToLong(moDevCompra.MonedaId)
         .TipoCambio = ToDecimal(moDevCompra.TipoCambio)
         .CentroCostoId = ToLong(moDevCompra.CentroCostoId)
         .SucursalId = ToLong(moDevCompra.SucursalId)
         .ItemId = ToLong(oRow.Cells("ItemId").Value)
         .MedidaId = ToLong(oRow.Cells("MedidaId").Value)
         .CantidadOrg = ToDecimal(oRow.Cells("CantidadOrg").Value)
         .CantidadDev = ToDecimal(oRow.Cells("CantidadDev").Value)
         .PrecioOrg = ToDecimal(oRow.Cells("PrecioOrg").Value)
         .PrecioNet = ToDecimal(oRow.Cells("PrecioNet").Value)
         .Importe = ToDecimal(oRow.Cells("Importe").Value)
         .EstadoId = 14

         decPrecioCos = ToDecimal(oRow.Cells("PrecioCos").Value)

         'Establecer el Precio de Costo
         If mlngTipoItemId <> 2 Then
            If mlngTipoCosteoId = 1 Then
               If mlngMedidaId = .MedidaId Then
                  .PrecioCos = ItemPrecioCos(mdecPrecioPPP)
               Else
                  .PrecioCos = ItemPrecioCos(mdecPrecioPPP * mdecMedidaCantEqui)
               End If

            ElseIf mlngTipoCosteoId = 2 Then
               If mlngMedidaId = .MedidaId Then
                  .PrecioCos = ItemPrecioCos(mdecPrecioUPC)
               Else
                  .PrecioCos = ItemPrecioCos(mdecPrecioUPC * mdecMedidaCantEqui)
               End If

            ElseIf mlngTipoCosteoId = 3 Then
               If mlngMedidaId = .MedidaId Then
                  .PrecioCos = ItemPrecioCos(ItemPepsPPP(moDevCompra.AlmacenId, .CantidadDev))
               Else
                  .PrecioCos = ItemPrecioCos(ItemPepsPPP(moDevCompra.AlmacenId, .CantidadDev * mdecMedidaCantEqui) * mdecMedidaCantEqui)
               End If

            ElseIf mlngTipoCosteoId = 4 Then
               If mlngMedidaId = .MedidaId Then
                  .PrecioCos = ItemPrecioCos(ItemUepsPPP(moDevCompra.AlmacenId, .CantidadDev))
               Else
                  .PrecioCos = ItemPrecioCos(ItemUepsPPP(moDevCompra.AlmacenId, .CantidadDev * mdecMedidaCantEqui) * mdecMedidaCantEqui)
               End If
            End If

            .PrecioCos = decPrecioCos
         Else
            .PrecioCos = 0
         End If

         oRow.BeginEdit()
         oRow.Cells("PrecioCos").Value = .PrecioCos
         oRow.EndEdit()
      End With
   End Sub

   Private Function ItemSaldoRestar(ByVal lngAlmacenId As Long, ByVal lngNotaId As Long, ByRef lngNotaDetId As Long) As Boolean
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)
      Dim strFechaIni As String

      Try
         ItemSaldoRestar = False

         With oItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.All
            .WhereFilter = clsItemSaldo.WhereFilters.ItemId
            .EmpresaId = moDevCompraDet.EmpresaId
            .GestionId = moDevCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = moDevCompraDet.ItemId

            If .Find Then
               .UpdateFilter = clsItemSaldo.UpdateFilters.All

               If mlngMedidaId = moDevCompraDet.MedidaId Then
                  .Saldo = .Saldo - moDevCompraDet.CantidadDev
               Else
                  .Saldo = .Saldo - ToDecimal(moDevCompraDet.CantidadDev * mdecMedidaCantEqui)
               End If

               'Actualizar los PPP tambien en una salida en caso de PEPS o UEPS
               If mlngTipoCosteoId = 3 Then
                  .PrecioPPP = ItemPepsPPP(.ItemId, lngAlmacenId)

               ElseIf mlngTipoCosteoId = 4 Then
                  .PrecioPPP = ItemUepsPPP(.ItemId, lngAlmacenId)
               End If

               strFechaIni = ToDate(.PrecioFecha)
               .PrecioFecha = ToDate(dtpFecha.Text)

               If ItemHistAdd(.AlmacenId, .ItemId, strFechaIni, ToDate(dtpFecha.Text), .Saldo, .PrecioUPC, .PrecioPPP) Then
                  If .Update Then
                     ItemSaldoRestar = True
                  End If
               End If

               'Item Lote Retar
               If ItemSaldoRestar And mboolControlLote Then
                  ItemSaldoRestar = grdItemLoteRestar(3, lngNotaId, lngNotaDetId, moDevCompraDet.ItemId, moDevCompra.AlmacenId)
               End If

               If mboolControlSerie Then
                  Call itemNroSerieUpdate(clsTipoNota.SALIDA, lngNotaId, moDevCompraDet.ItemId)
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemSaldo.Dispose()

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

            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
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

            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
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
            .EmpresaId = moDevCompraDet.EmpresaId
            .GestionId = moDevCompraDet.GestionId
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
                     .EmpresaId = moDevCompraDet.EmpresaId
                     .GestionId = moDevCompraDet.GestionId
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
               .EmpresaId = moDevCompraDet.EmpresaId
               .GestionId = moDevCompraDet.GestionId
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

   Private Function ItemPrecioCos(ByVal decPrecioCos As Decimal) As Decimal
      Dim decPrecio As Decimal = decPrecioCos

      If moDevCompra.MonedaId = 1 Then
         If moDevCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos * moDevCompra.TipoCambio)
         End If

      ElseIf moDevCompra.MonedaId = 2 Then
         If moDevCompra.MonedaId <> mlngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos / moDevCompra.TipoCambio)
         End If
      End If

      Return decPrecio
   End Function

   Private Function ItemPepsPPP(ByVal lngAlmacenId As Long, ByVal decCantidad As Decimal) As Decimal
      Dim oItemPeps As New clsItemPeps(clsAppInfo.ConnectString)
      Dim decImporte As Decimal = 0
      Dim decDif As Decimal = 0

      Try
         ItemPepsPPP = 0

         With oItemPeps
            .SelectFilter = clsItemPeps.SelectFilters.All
            .WhereFilter = clsItemPeps.WhereFilters.ItemId
            .OrderByFilter = clsItemPeps.OrderByFilters.Fecha

            .EmpresaId = moDevCompraDet.EmpresaId
            .GestionId = moDevCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = moDevCompraDet.ItemId

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
                     Else
                        Call .Update()
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

            .EmpresaId = moDevCompraDet.EmpresaId
            .GestionId = moDevCompraDet.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = moDevCompraDet.ItemId

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

   Private Sub ItemParametro(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngTipoItemId = 0
         mlngTipoCosteoId = 0
         mlngMedidaId = 0
         mlngMedidaIdEqui = 0
         mdecMedidaCantEqui = 0
         mlngMonedaIdCos = 0
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
            .EmpresaId = moDevCompra.EmpresaId
            .GestionId = moDevCompra.GestionId
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

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Function grdMainFindRowId(ByVal lngID As Long) As Integer
      Dim intRow As Long = 0

      For Each oRow As DataRow In moDataSet.Tables(moDevCompraDet.TableName).Rows
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
         ebrMain.Groups(0).Text = "Detalle de la Devolución Sobre Compra"
         .ContextMenu = mnuMain

         .RootTable.Columns("DevCompraDetId").Visible = False

         .RootTable.Columns("PlanIdAct").Visible = False

         .RootTable.Columns("PlanIdCos").Visible = False

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 80
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ItemCod").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("ItemCod").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("ItemDes").Caption = "Descripción"
         .RootTable.Columns("ItemDes").Width = 200
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ItemDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("ItemDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("TipoItemId").Visible = False

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 60
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MedidaDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("MedidaDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("CantidadOrg").Caption = "Cant. Compra"
         .RootTable.Columns("CantidadOrg").FormatString = DecimalMask()
         .RootTable.Columns("CantidadOrg").Width = 80
         .RootTable.Columns("CantidadOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("CantidadOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CantidadOrg").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("CantidadOrg").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("CantidadDev").Caption = "Cant. Devol"
         .RootTable.Columns("CantidadDev").FormatString = DecimalMask()
         .RootTable.Columns("CantidadDev").Width = 80
         .RootTable.Columns("CantidadDev").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("CantidadDev").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CantidadDev").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("CantidadDev").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox


         .RootTable.Columns("PrecioOrg").Caption = "Precio"
         .RootTable.Columns("PrecioOrg").FormatString = DecimalMask()
         .RootTable.Columns("PrecioOrg").Width = 80
         .RootTable.Columns("PrecioOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PrecioOrg").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("PrecioOrg").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("PrecioCos").Visible = False

         .RootTable.Columns("PrecioNet").Visible = False

         .RootTable.Columns("Importe").Caption = "Importe"
         .RootTable.Columns("Importe").FormatString = DecimalMask()
         .RootTable.Columns("Importe").Width = 80
         .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Importe").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("Importe").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("Estado").Visible = False
      End With
   End Sub

   Private Sub grdMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMain.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Then
            If grdMain.RowCount > 0 Then
               mnuShow.Enabled = True
               mnuEdit.Enabled = True
            Else
               mnuShow.Enabled = False
               mnuEdit.Enabled = False
            End If
         Else
            mnuShow.Enabled = True
            mnuEdit.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdMain_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdMain.UpdatingCell
      mboolGridCancel = False

      If ToDecimal(e.Value) = 0 Then
         grdMain.SetValue("Importe", 0)

      ElseIf ToDecimal(e.Value) < 0 Then
         e.Cancel = True
         mboolGridCancel = True
         grdMain.SetValue("Importe", 0)
         MessageBox.Show("Monto Negativo Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      ElseIf ToDecimal(e.Value) > ToDecimal(grdMain.GetValue("CantidadOrg")) Then
         e.Cancel = True
         mboolGridCancel = True
         grdMain.SetValue("Importe", 0)
         MessageBox.Show("Cantidad de Devolución es Superior a la Cantidad de la Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Else
         grdMain.SetValue("Importe", ToDecimal(e.Value * grdMain.GetValue("PrecioOrg")))
         Call DevCompraTotal()
      End If
   End Sub

   Private Sub grdMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdMain.KeyPress
      ''If Not grdMain.CurrentColumn Is Nothing Then
      ''   If ToStr(grdMain.RootTable.Columns(grdMain.Col).DataMember) = "CantidadDev" Then
      ''      If mstrSepDecimal = "," Then
      ''         If e.KeyChar = "." Then
      ''            e.Handled = True
      ''            SendKeys.Send(",")
      ''         End If
      ''      End If
      ''   End If
      ''End If
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      grdMainShow()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      grdMainEdit()
   End Sub

#End Region

#Region " ItemLote "

   Private Sub itemLoteRowShow(ByVal lngNotaId As Long, ByVal lngItemId As Long)
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      Dim oDataTable As DataTable

      With oItemLote
         .SelectFilter = clsItemLote.SelectFilters.All
         .WhereFilter = clsItemLote.WhereFilters.NotaItemId
         .EmpresaId = moDevCompra.EmpresaId
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
               oRow("ItemLoteIdDev") = .ItemLoteIdDev
               oDataTable.Rows.Add(oRow)
               .MoveNext()
            Loop
         End If
      End With

   End Sub

   Private Sub itemLoteRowNew(ByVal lngNotaId As Long, ByVal lngItemId As Long)
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      Dim oDataTable As DataTable
      Dim lngCantDev As Long = 0

      With oItemLote
         .SelectFilter = clsItemLote.SelectFilters.All
         .WhereFilter = clsItemLote.WhereFilters.NotaItemId
         .EmpresaId = moDevCompra.EmpresaId
         .NotaId = lngNotaId
         .ItemId = lngItemId

         If .Open() Then
            Dim oRow As DataRow
            oDataTable = moDataSetDet.Tables(clsItemLote.TABLE_NAME)

            Do While .Read()

               lngCantDev = CantidadDevolucion(.ItemLoteId)

               If (.SaldoOrg > .SaldoAct) And (.SaldoOrg > lngCantDev) Then

                  'mboolNewCloneDevVentaDet = True

                  oRow = oDataTable.NewRow
                  oRow("ItemLoteId") = 0
                  oRow("ItemId") = .ItemId
                  oRow("ItemLoteDes") = .ItemLoteDes
                  oRow("SaldoOrg") = 0
                  oRow("SaldoAct") = .SaldoOrg - .SaldoAct
                  'oRow("SaldoAct") = .SaldoOrg - lngCantDev
                  oRow("FechaVen") = .FechaVen
                  oRow("ItemLoteIdOrg") = .ItemLoteId
                  oRow("Estado") = "New"
                  oRow("ItemLoteIdDev") = .ItemLoteId
                  oDataTable.Rows.Add(oRow)
               End If
               .MoveNext()
            Loop
         End If
      End With

   End Sub

   Private Function CantidadDevolucion(ByVal lngItemLoteId As Long) As Decimal
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Dim SumaDevolucion As Decimal = 0
      Try
         With oItemLote
            .SelectFilter = clsItemLote.SelectFilters.All
            .WhereFilter = clsItemLote.WhereFilters.TieneItemLoteIdDev
            .EmpresaId = clsAppInfo.EmpresaId
            .ItemLoteIdDev = lngItemLoteId

            If .Open() Then
               Do While .Read()
                  SumaDevolucion += .SaldoOrg

                  .MoveNext()
               Loop

            End If

         End With

         Return SumaDevolucion

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oItemLote.Dispose()
      End Try
   End Function

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
      oDataTable.Columns.Add("ItemLoteIdDev", Type.GetType("System.Int32"))

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
            oRow("ItemLoteIdDev") = oDataRow("ItemLoteIdDev")
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
            oRow("ItemLoteIdDev") = oDataRow("ItemLoteIdDev")
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
         oRow("ItemLoteIdDev") = oDataRow("ItemLoteIdDev")
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
      oRow("ItemLoteIdDev") = oDataRow("ItemLoteIdDev")
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

   Private Function grdItemLoteRestar(ByVal lngTipoNotaId As Integer, ByVal lngNotaId As Integer, ByVal lngNotaDetId As Integer, ByVal lngItemId As Long, ByVal lngAlmacenId As Integer) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      Dim oRow As DataRow

      grdItemLoteRestar = True

      Try
         For Each oRow In moDataSetDet.Tables(clsItemLote.TABLE_NAME).Rows
            If (oRow("ItemId") = lngItemId) And (oRow("Estado") = "New") And ToDecimal(oRow("SaldoOrg")) > 0 Then
               With oItemLote
                  .EmpresaId = moDevCompra.EmpresaId
                  .GestionId = moDevCompra.GestionId
                  .AlmacenId = lngAlmacenId
                  .TipoNotaId = lngTipoNotaId
                  .NotaId = lngNotaId
                  .NotaDetId = lngNotaDetId
                  .ItemId = lngItemId
                  .ItemLoteDes = ToStr(oRow("ItemLoteDes"))
                  .MedidaId = moDevCompraDet.MedidaId
                  .SaldoOrg = ToDecimal(oRow("SaldoOrg"))
                  .SaldoAct = 0
                  .FechaVen = ToDate(oRow("FechaVen"))
                  .ItemLoteIdOrg = ToLong(oRow("ItemLoteIdOrg"))
                  .ItemLoteIdDev = ToLong(oRow("ItemLoteIdDev"))
                  .EstadoId = clsEstado.ABIERTO

                  If .Insert() Then
                     If ItemLoteSaldoUpdate(.ItemLoteIdOrg, .MedidaId, .SaldoOrg) Then
                        grdItemLoteRestar = True
                     End If

                     If mboolControlSerie Then
                        Call cargarItemLoteIdEnSerie(.ItemLoteId, .ItemLoteIdOrg, .ItemId)
                     End If
                  End If

               End With
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function ItemLoteSaldoUpdate(ByVal lngItemLoteId As Long, ByVal lngMedidaIdLote As Long, ByVal decSaldoAct As Decimal) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      ItemLoteSaldoUpdate = False

      Try
         With oItemLote
            .ItemLoteId = lngItemLoteId

            If .FindByPK Then
               .FechaVen = ToDate(.FechaVen)

               If .MedidaId = mlngMedidaId Then
                  If .MedidaId = lngMedidaIdLote Then
                     .SaldoAct += decSaldoAct
                  Else
                     .SaldoAct += ToDecimal(decSaldoAct * mdecMedidaCantEqui)
                  End If

               ElseIf .MedidaId = mlngMedidaIdEqui Then
                  If .MedidaId = lngMedidaIdLote Then
                     .SaldoAct += decSaldoAct
                  Else
                     .SaldoAct += ToDecimal(decSaldoAct / mdecMedidaCantEqui)
                  End If
               End If

               .EstadoId = IIf(.SaldoAct >= .SaldoOrg, clsEstado.ABIERTO, clsEstado.PENDIENTE)

               If .Update() Then
                  ItemLoteSaldoUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function itemLoteSaldoRestore(ByVal lngNotaId As Long, ByVal lngNotaDetId As Long) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      Dim oItemLoteOrg As New clsItemLote(clsAppInfo.ConnectString)
      Dim oItemLoteDel As New clsItemLote(clsAppInfo.ConnectString)
      itemLoteSaldoRestore = True

      Try
         With oItemLote
            .SelectFilter = clsItemLote.SelectFilters.All
            .WhereFilter = clsItemLote.WhereFilters.NotaDetId
            .EmpresaId = moDevCompra.EmpresaId
            .NotaId = lngNotaId
            .NotaDetId = lngNotaDetId

            If .Open Then
               Do While .Read
                  itemLoteSaldoRestore = False

                  oItemLoteOrg.ItemLoteId = .ItemLoteIdOrg

                  If oItemLoteOrg.FindByPK Then
                     oItemLoteOrg.FechaVen = ToDate(oItemLoteOrg.FechaVen)
                     oItemLoteOrg.SaldoAct -= .SaldoOrg
                     oItemLoteOrg.EstadoId = clsEstado.PENDIENTE

                     If oItemLoteOrg.Update() Then
                        itemLoteSaldoRestore = True
                     End If
                  End If

                  If itemLoteSaldoRestore Then
                     oItemLoteDel.WhereFilter = clsItemLote.WhereFilters.PrimaryKey
                     oItemLoteDel.ItemLoteId = .ItemLoteId

                     If moDevCompra.EstadoId = clsEstado.ANULADO Then
                        If oItemLoteDel.FindByPK Then
                           oItemLoteDel.FechaVen = ToDate(oItemLoteDel.FechaVen)
                           oItemLoteDel.EstadoId = clsEstado.ANULADO

                           If oItemLoteDel.Update() Then
                              itemLoteSaldoRestore = True
                           End If
                        End If

                     Else
                        If oItemLoteDel.Delete Then
                           itemLoteSaldoRestore = True
                        End If
                     End If
                  End If

                  Call .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()
         oItemLoteDel.Dispose()
         oItemLoteOrg.Dispose()
      End Try

   End Function

   Private Sub cargarItemLoteIdEnSerie(ByVal lngItemLoteId As Long, ByVal lngItemLoteIdOrg As Long, ByVal lngItemId As Long)
      Dim oDataTable As DataTable

      For Each oRow As DataRow In moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME).Rows
         If (oRow("ItemId") = lngItemId) Then
            If (oRow("ItemLoteId") = lngItemLoteIdOrg) Then
               oRow("ItemLoteIdSal") = lngItemLoteId
            End If
         End If
      Next

   End Sub

   Private Function CargarItemLote()

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
      oDataTable.Columns.Add("ItemNroSerieCodTag", Type.GetType("System.String"))
      oDataTable.Columns.Add("TipoNotaIdSal", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("NotaIdSal", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("ItemLoteIdSal", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
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
            ''.WhereFilter = clsItemNroSerie.WhereFilters.NotaIdEnt
            .WhereFilter = clsItemNroSerie.WhereFilters.NotaIdSal
            .OrderByFilter = clsItemNroSerie.OrderByFilters.ItemNroSerieId
            .EmpresaId = moDevCompra.EmpresaId
            .NotaIdSal = lngNotaId
            .ItemId = lngItemId

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
                  oRow("ItemNroSerieCodTag") = .ItemNroSerieCod
                  oRow("ItemId") = .ItemId
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
            oRow("ItemNroSerieCodTag") = oDataRow("ItemNroSerieCodTag")
            oRow("ItemId") = oDataRow("ItemId")
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
         ''If oDataRow("ItemId") = lngItemId Then
         oRow = oDataTable.NewRow
         oRow("ItemLoteId") = oDataRow("ItemLoteId")
         oRow("TipoNotaIdSal") = oDataRow("TipoNotaIdSal")
         oRow("NotaIdSal") = oDataRow("NotaIdSal")
         oRow("ItemLoteIdSal") = oDataRow("ItemLoteIdSal")
         oRow("ItemLoteDes") = oDataRow("ItemLoteDes")
         oRow("ItemNroSerieId") = oDataRow("ItemNroSerieId")
         oRow("ItemNroSerieCod") = oDataRow("ItemNroSerieCod")
         oRow("ItemNroSerieCodTag") = oDataRow("ItemNroSerieCodTag")
         oRow("ItemId") = oDataRow("ItemId")
         oRow("Estado") = oDataRow("Estado")
         oDataTable.Rows.Add(oRow)
         ''End If
      Next

   End Sub

   Private Function itemNroSerieUpdate(ByVal lngTipoNotaId As Long, ByVal lngNotaId As Long, ByVal lngItemId As Long) As Boolean
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim oRow As DataRow

      Try
         For Each oRow In moDataSetDet.Tables(clsItemNroSerie.TABLE_NAME).Rows
            If oRow("ItemId") = lngItemId Then
               With oItemNroSerie
                  .ItemNroSerieId = ToLong(oRow("ItemNroSerieId"))
                  If .FindByPK Then
                     .TipoNotaIdSal = lngTipoNotaId
                     .NotaIdSal = lngNotaId
                     .ItemLoteIdSal = ToLong(oRow("ItemLoteIdSal"))

                     .AppId = clsAppInfo.AppId
                     .TipoDocumentoId = clsTipoCompra.DEVOLUCION_COMPRA
                     .DocumentoId = moDevCompra.DevCompraId
                     .DocumentoDetId = moDevCompraDet.DevCompraDetId

                     If .Update() Then
                        itemNroSerieUpdate = True
                     End If
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

   Private Function itemNroSerieRestore(ByVal lngNotaId As Long, ByVal lngItemId As Long) As Boolean
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim oItemNroSerieClone As New clsItemNroSerie(clsAppInfo.ConnectString)
      itemNroSerieRestore = True

      Try
         With oItemNroSerie
            .SelectFilter = clsItemNroSerie.SelectFilters.All
            .WhereFilter = clsItemNroSerie.WhereFilters.NotaIdSal
            .EmpresaId = moDevCompra.EmpresaId
            .ItemId = lngItemId
            .NotaIdSal = lngNotaId

            If .Open Then
               While .Read
                  .TipoNotaIdSal = 0
                  .NotaIdSal = 0
                  .ItemLoteIdSal = 0

                  .AppId = 0
                  .TipoDocumentoId = 0
                  .DocumentoId = 0
                  .DocumentoDetId = 0

                  If moDevCompra.EstadoId = clsEstado.ANULADO Then
                     oItemNroSerieClone.ItemNroSerieId = .ItemNroSerieId
                     If oItemNroSerieClone.FindByPK() Then
                        oItemNroSerieClone.TipoNotaIdEnt = 0
                        oItemNroSerieClone.NotaIdEnt = 0
                        oItemNroSerieClone.EstadoId = clsEstado.ANULADO
                        oItemNroSerieClone.InsertOnly()
                     End If
                  End If

                  If .Update() Then
                     itemNroSerieRestore = True
                  End If
                  .MoveNext()
               End While
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemNroSerie.Dispose()
         oItemNroSerieClone.Dispose()
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

#End Region

#Region "Numeracion Sucursal"

   Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged


        If mboolAdding Then
            If clsAppInfo.SucursalApli Then
                Dim lngSucursaId As Long = AlmacenSucursalIdFind(ListPosition(cboAlmacen, cboAlmacen.SelectedIndex))
                cboSucursal.SelectedIndex = ListFindItem(cboSucursal, lngSucursaId)

                ' Call CompraParaLoad(clsTipoCompra.COMPRA, clsAppInfo.GestionId, lngSucursaId)

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

   Private Sub frmDevCompraEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moDevCompra.DevCompraId
                  mboolChanged = True
                  chkConFac.Enabled = False

                  cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
                  cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

                  If MessageBox.Show("Devolución Sobre Compra Guardada Exitosamente" + vbCrLf + "¿Desea Imprimir la Devolución Sobre Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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

   Private Sub frmDevCompraEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moDevCompra.Dispose()
      moDevCompraDet.Dispose()
      Call ClearMemory()
   End Sub

End Class

