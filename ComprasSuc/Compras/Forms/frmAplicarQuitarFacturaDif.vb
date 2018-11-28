Public Class frmAplicarQuitarFacturaDif
   Inherits System.Windows.Forms.Form

   Private moCompra As clsCompra
   Private moCompraDet As clsCompraDet
   Private moFactura As clsFactura
   Private moCompraFac As clsCompraFac

   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngTipoPlanId As Long
   Private mboolTieneComp As Boolean

   Private mlngTipoItemIdAux As Long
   Private mlngTipoCosteoIdAux As Long
   Private mlngMedidaIdAux As Long
   Private mlngMedidaIdEquiAux As Long
   Private mdecMedidaCantEquiAux As Decimal
   Private mlngMonedaIdCosAux As Long

   Private mdecPrecioPPPAux As Decimal
   Private mdecPrecioUPCAux As Decimal
   Private mdecSaldoItemAux As Decimal

   Private mboolControlLote As Boolean
   Private mboolControlSerie As Boolean

   Private mlngTipoItemId As Long
   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mlngEmpresaId As Long
   Private mboolChanged As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean

   Private mboolExigirFacturaDif As Long

   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtCompraNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboTipoPago As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtCompraOrden As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtCompraId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cboAlmacen As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblAlmacenDes As System.Windows.Forms.Label
   Friend WithEvents chkFacturaDif As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents mnuFactura As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowFactura As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeleteFactura As System.Windows.Forms.MenuItem
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtCompraDes As Janus.Windows.GridEX.EditControls.EditBox
   Private mlngID As Long


   WriteOnly Property DataObject() As clsCompra
      Set(ByVal Value As clsCompra)
         moCompra = Value
      End Set
   End Property

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

#Region " Windows Form Designer generated code "
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

   'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Diseñador de Windows Forms.  
   'No lo modifique con el editor de código.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAplicarQuitarFacturaDif))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdFactura = New Janus.Windows.GridEX.GridEX
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Venta = New Janus.Windows.UI.CommandBars.UICommand("Venta")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrFactura = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtCompraDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.chkFacturaDif = New Janus.Windows.EditControls.UICheckBox
      Me.cboAlmacen = New Janus.Windows.EditControls.UIComboBox
      Me.lblAlmacenDes = New System.Windows.Forms.Label
      Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label4 = New System.Windows.Forms.Label
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.txtCompraId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtCompraOrden = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtCompraNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label23 = New System.Windows.Forms.Label
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboTipoPago = New Janus.Windows.EditControls.UIComboBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label16 = New System.Windows.Forms.Label
      Me.mnuFactura = New System.Windows.Forms.ContextMenu
      Me.mnuShowFactura = New System.Windows.Forms.MenuItem
      Me.mnuDeleteFactura = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdFactura, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrFactura, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrFactura.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdFactura)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(710, 267)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdFactura
      '
      Me.grdFactura.AllowCardSizing = False
      Me.grdFactura.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdFactura.AlternatingColors = True
      Me.grdFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdFactura.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdFactura.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdFactura.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdFactura.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdFactura.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdFactura.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdFactura.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdFactura.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdFactura.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdFactura.GroupByBoxVisible = False
      Me.grdFactura.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdFactura.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdFactura.Location = New System.Drawing.Point(0, 0)
      Me.grdFactura.Name = "grdFactura"
      Me.grdFactura.RecordNavigator = True
      Me.grdFactura.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdFactura.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdFactura.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdFactura.Size = New System.Drawing.Size(710, 267)
      Me.grdFactura.TabIndex = 3
      Me.grdFactura.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdFactura.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdFactura.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdFactura.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'UiCommandBar1
      '
      Me.UiCommandBar1.CommandManager = Me.cdmMain
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Separator1, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(152, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Print, Me.Venta})
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
      Me.BottomRebar1.Location = New System.Drawing.Point(0, 466)
      Me.BottomRebar1.Name = "BottomRebar1"
      Me.BottomRebar1.Size = New System.Drawing.Size(742, 0)
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
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Venta
      '
      Me.Venta.ImageIndex = 3
      Me.Venta.Key = "Venta"
      Me.Venta.Name = "Venta"
      Me.Venta.Text = "Venta"
      Me.Venta.ToolTipText = "Cargar Venta"
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
      Me.ilsMain.Images.SetKeyName(9, "LCV.ico")
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 466)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(742, 0)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 466)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(742, 28)
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
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.ebrFactura)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(742, 438)
      Me.bcgMain.TabIndex = 165
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'ebrFactura
      '
      Me.ebrFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrFactura.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrFactura.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 268
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrFactura.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrFactura.GroupSeparation = 4
      Me.ebrFactura.Location = New System.Drawing.Point(8, 128)
      Me.ebrFactura.Name = "ebrFactura"
      Me.ebrFactura.Size = New System.Drawing.Size(726, 300)
      Me.ebrFactura.TabIndex = 7
      Me.ebrFactura.Text = "ExplorerBar2"
      Me.ebrFactura.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrFactura.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrFactura.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrFactura.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.txtCompraDes)
      Me.UiGroupBox1.Controls.Add(Me.chkFacturaDif)
      Me.UiGroupBox1.Controls.Add(Me.cboAlmacen)
      Me.UiGroupBox1.Controls.Add(Me.lblAlmacenDes)
      Me.UiGroupBox1.Controls.Add(Me.cboProveedor)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.cboEstado)
      Me.UiGroupBox1.Controls.Add(Me.txtCompraId)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.Label8)
      Me.UiGroupBox1.Controls.Add(Me.txtCompraOrden)
      Me.UiGroupBox1.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox1.Controls.Add(Me.Label1)
      Me.UiGroupBox1.Controls.Add(Me.txtCompraNro)
      Me.UiGroupBox1.Controls.Add(Me.Label23)
      Me.UiGroupBox1.Controls.Add(Me.txtTipoCambio)
      Me.UiGroupBox1.Controls.Add(Me.Label2)
      Me.UiGroupBox1.Controls.Add(Me.cboTipoPago)
      Me.UiGroupBox1.Controls.Add(Me.Label10)
      Me.UiGroupBox1.Controls.Add(Me.dtpFecha)
      Me.UiGroupBox1.Controls.Add(Me.Label16)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 4)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(726, 120)
      Me.UiGroupBox1.TabIndex = 0
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(4, 96)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(76, 16)
      Me.Label3.TabIndex = 386
      Me.Label3.Text = "Descripción"
      '
      'txtCompraDes
      '
      Me.txtCompraDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCompraDes.BackColor = System.Drawing.SystemColors.Info
      Me.txtCompraDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompraDes.Location = New System.Drawing.Point(80, 92)
      Me.txtCompraDes.MaxLength = 1000
      Me.txtCompraDes.Multiline = True
      Me.txtCompraDes.Name = "txtCompraDes"
      Me.txtCompraDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtCompraDes.Size = New System.Drawing.Size(432, 20)
      Me.txtCompraDes.TabIndex = 385
      Me.txtCompraDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompraDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'chkFacturaDif
      '
      Me.chkFacturaDif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkFacturaDif.BackColor = System.Drawing.Color.Transparent
      Me.chkFacturaDif.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFacturaDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFacturaDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFacturaDif.Location = New System.Drawing.Point(608, 96)
      Me.chkFacturaDif.Name = "chkFacturaDif"
      Me.chkFacturaDif.Size = New System.Drawing.Size(112, 16)
      Me.chkFacturaDif.TabIndex = 384
      Me.chkFacturaDif.TabStop = False
      Me.chkFacturaDif.Text = "Factura Diferida"
      Me.chkFacturaDif.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboAlmacen
      '
      Me.cboAlmacen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.cboAlmacen.BackColor = System.Drawing.SystemColors.Info
      Me.cboAlmacen.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboAlmacen.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAlmacen.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAlmacen.Location = New System.Drawing.Point(80, 68)
      Me.cboAlmacen.Name = "cboAlmacen"
      Me.cboAlmacen.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboAlmacen.Size = New System.Drawing.Size(256, 20)
      Me.cboAlmacen.TabIndex = 382
      Me.cboAlmacen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblAlmacenDes
      '
      Me.lblAlmacenDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.lblAlmacenDes.BackColor = System.Drawing.Color.Transparent
      Me.lblAlmacenDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAlmacenDes.Location = New System.Drawing.Point(4, 72)
      Me.lblAlmacenDes.Name = "lblAlmacenDes"
      Me.lblAlmacenDes.Size = New System.Drawing.Size(72, 16)
      Me.lblAlmacenDes.TabIndex = 383
      Me.lblAlmacenDes.Text = "Almacén"
      '
      'cboProveedor
      '
      Me.cboProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboProveedor.BackColor = System.Drawing.SystemColors.Info
      cboProveedor_DesignTimeLayout.LayoutString = resources.GetString("cboProveedor_DesignTimeLayout.LayoutString")
      Me.cboProveedor.DesignTimeLayout = cboProveedor_DesignTimeLayout
      Me.cboProveedor.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProveedor.Location = New System.Drawing.Point(444, 68)
      Me.cboProveedor.Name = "cboProveedor"
      Me.cboProveedor.SelectedIndex = -1
      Me.cboProveedor.SelectedItem = Nothing
      Me.cboProveedor.Size = New System.Drawing.Size(276, 20)
      Me.cboProveedor.TabIndex = 378
      Me.cboProveedor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboProveedor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(376, 72)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(64, 16)
      Me.Label4.TabIndex = 380
      Me.Label4.Text = "Proveedor"
      '
      'cboEstado
      '
      Me.cboEstado.BackColor = System.Drawing.SystemColors.Info
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(56, 36)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(100, 20)
      Me.cboEstado.TabIndex = 375
      Me.cboEstado.TabStop = False
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtCompraId
      '
      Me.txtCompraId.BackColor = System.Drawing.SystemColors.Info
      Me.txtCompraId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompraId.Location = New System.Drawing.Point(56, 12)
      Me.txtCompraId.Name = "txtCompraId"
      Me.txtCompraId.ReadOnly = True
      Me.txtCompraId.Size = New System.Drawing.Size(100, 20)
      Me.txtCompraId.TabIndex = 374
      Me.txtCompraId.TabStop = False
      Me.txtCompraId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompraId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(4, 40)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(46, 16)
      Me.Label6.TabIndex = 377
      Me.Label6.Text = "Estado"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(32, 16)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(20, 16)
      Me.Label7.TabIndex = 376
      Me.Label7.Text = "ID"
      '
      'Label8
      '
      Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(372, 40)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(68, 16)
      Me.Label8.TabIndex = 373
      Me.Label8.Text = "Nro. Orden"
      '
      'txtCompraOrden
      '
      Me.txtCompraOrden.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtCompraOrden.BackColor = System.Drawing.SystemColors.Info
      Me.txtCompraOrden.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompraOrden.Location = New System.Drawing.Point(444, 36)
      Me.txtCompraOrden.MaxLength = 50
      Me.txtCompraOrden.Name = "txtCompraOrden"
      Me.txtCompraOrden.Size = New System.Drawing.Size(88, 20)
      Me.txtCompraOrden.TabIndex = 372
      Me.txtCompraOrden.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompraOrden.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.cboMoneda.BackColor = System.Drawing.SystemColors.Info
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(444, 12)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.ReadOnly = True
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(88, 20)
      Me.cboMoneda.TabIndex = 369
      Me.cboMoneda.TabStop = False
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label1.Location = New System.Drawing.Point(388, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(52, 16)
      Me.Label1.TabIndex = 371
      Me.Label1.Text = "Moneda"
      '
      'txtCompraNro
      '
      Me.txtCompraNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCompraNro.BackColor = System.Drawing.SystemColors.Info
      Me.txtCompraNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompraNro.FormatString = "########"
      Me.txtCompraNro.Location = New System.Drawing.Point(632, 36)
      Me.txtCompraNro.Name = "txtCompraNro"
      Me.txtCompraNro.ReadOnly = True
      Me.txtCompraNro.Size = New System.Drawing.Size(88, 20)
      Me.txtCompraNro.TabIndex = 368
      Me.txtCompraNro.TabStop = False
      Me.txtCompraNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompraNro.Value = 0
      Me.txtCompraNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtCompraNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label23
      '
      Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.Location = New System.Drawing.Point(560, 40)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(68, 16)
      Me.Label23.TabIndex = 370
      Me.Label23.Text = "N. Compra"
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtTipoCambio.BackColor = System.Drawing.SystemColors.Info
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(236, 36)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.ReadOnly = True
      Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
      Me.txtTipoCambio.TabIndex = 364
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(200, 38)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(36, 16)
      Me.Label2.TabIndex = 367
      Me.Label2.Text = "T.C."
      '
      'cboTipoPago
      '
      Me.cboTipoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboTipoPago.BackColor = System.Drawing.SystemColors.Info
      Me.cboTipoPago.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoPago.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPago.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPago.Location = New System.Drawing.Point(632, 12)
      Me.cboTipoPago.Name = "cboTipoPago"
      Me.cboTipoPago.ReadOnly = True
      Me.cboTipoPago.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoPago.Size = New System.Drawing.Size(88, 20)
      Me.cboTipoPago.TabIndex = 365
      Me.cboTipoPago.TabStop = False
      Me.cboTipoPago.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label10.Location = New System.Drawing.Point(584, 16)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(44, 16)
      Me.Label10.TabIndex = 366
      Me.Label10.Text = "Forma"
      '
      'dtpFecha
      '
      Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.dtpFecha.BackColor = System.Drawing.SystemColors.Info
      Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFecha.DropDownCalendar.Name = ""
      Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dtpFecha.Location = New System.Drawing.Point(236, 11)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
      Me.dtpFecha.TabIndex = 254
      Me.dtpFecha.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label16
      '
      Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label16.Location = New System.Drawing.Point(188, 15)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(44, 16)
      Me.Label16.TabIndex = 256
      Me.Label16.Text = "Fecha"
      '
      'mnuFactura
      '
      Me.mnuFactura.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowFactura, Me.mnuDeleteFactura})
      '
      'mnuShowFactura
      '
      Me.mnuShowFactura.Index = 0
      Me.mnuShowFactura.Text = "Consultar"
      '
      'mnuDeleteFactura
      '
      Me.mnuDeleteFactura.Index = 1
      Me.mnuDeleteFactura.Text = "Eliminar"
      '
      'frmAplicarQuitarFacturaDif
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(742, 466)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmAplicarQuitarFacturaDif"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Compra - Aplicar/Quitar Facturación Diferida"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdFactura, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.ebrFactura, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrFactura.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Venta As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ebrFactura As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdFactura As Janus.Windows.GridEX.GridEX
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand

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
               Me.Close()
            End If

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor

   End Sub

   Private Sub frmFacturaLoadEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmFacturaLoadEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      Me.Text = "Compra - Aplicar/Quitar Facturación Diferida"

      Call FormInit()
      Call ComboLoad()

      Call FormShow()
      Call DataReadOnly()

      ''Call grdFacturaLoad()

      dtpFecha.Select()

   End Sub

   Private Sub FormShow()
      ''mboolShow = True
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
         chkFacturaDif.Checked = .FacturaDif


         cboMoneda.ReadOnly = True
         cboEstado.ReadOnly = True

      End With

      Call CompraDetDataTableLoad()
      Call grdFacturaLoad()

      ''mboolShow = False
   End Sub

   Private Sub DataMove()
      With moCompra
         .CompraId = ToLong(txtCompraId.Text)
         .Fecha = ToDate(dtpFecha.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .TipoPagoId = ListPosition(cboTipoPago, cboTipoPago.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .ProveedorId = ListPosition(cboProveedor)
         .AlmacenId = ListPosition(cboAlmacen, cboAlmacen.SelectedIndex)
         .CompraNro = ToLong(txtCompraNro.Text)
         .CompraOrden = ToStr(txtCompraOrden.Text)

         .FacturaDif = ToBoolean(chkFacturaDif.Checked)
         ''.TipoDosificaId = ListPosition(cboTipoDosifica, cboTipoDosifica.SelectedIndex)
      End With
   End Sub

   Private Sub FormNew()
      ''mboolAdding = True

      Call DataClear()

      dtpFecha.Select()
   End Sub

   Private Sub DataClear()
   End Sub

   Private Function GetDataView(ByVal oDataTableOrg As DataTable) As System.Data.DataView
      If grdFactura.RootTable.FilterApplied Is Nothing Then
         Return oDataTableOrg.DefaultView

      Else
         Dim oDataTable As DataTable
         Dim oRow As DataRow

         oDataTable = oDataTableOrg.Clone

         For Each oRowMain In grdFactura.GetRows()
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
      ''Dim rpt As New rptFacturarEdit


      ''rpt.DataSource = GetDataView(moCompra.DataSet.Tables(moCompra.TableName))

      ''rpt.lblTitle.Text = "NOTAS DE VENTAS A FACTURAR"
      ''rpt.Document.Name = "Notas de Ventas a Facturar"
      ''rpt.txtCliente.Text = txtProveedorDes.Text
      ' ''rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      ''rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      ''rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      ''rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      ''Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      ''rpt.Run(True)
      ''Dim frm As New frmReportPreview(rpt.Document)
      ''frm.Show()
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
      chkFacturaDif.Enabled = False
      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Print").Visible = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub FormInit()
      txtTipoCambio.FormatString = DecimalMask()

      moFactura = New clsFactura(clsAppInfo.ConnectString)
      moCompraFac = New clsCompraFac(clsAppInfo.ConnectString)
      moCompraDet = New clsCompraDet(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboTipoPagoLoad()
      Call cboProveedorLoad()
      Call cboAlmacenLoad()
      Call cboEstadoLoad()
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
                  If .TipoPagoId > 0 Then
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
            .EstadoId = clsEstado.ACTIVO

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

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If moCompra.Validate Then

            If FormCheck() Then
               If clsAppInfo.Inventario Then 'Adicion Integrado a Contabilidad
                  Call frmCompPlanFill()

                  'If CompEdit() Then
                  '   If DataUpdate() Then
                  '      DataSave = True
                  '   End If
                  'End If

                  If moCompra.CompId > 0 Then
                     If CompEdit(moCompra.CompId, 0, 0) Then
                        If DataUpdate() Then
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
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End Try
   End Function

   ''Private Function frmCompPlanFill() As Boolean
   ''   frmCompPlanFill = False
   ''   mlngPlanId = ClientePlanIdActFind(moCompra.ProveedorId, mlngPlanAddId)
   ''   mlngSucursalId = SucursalIdFind(moCompra.AlmacenId)
   ''   mlngCentroCostoId = 0
   ''   mlngCentroCostoDetId = 0
   ''   mlngTipoPlanId = TipoPlanIdFind(mlngPlanId)
   ''   mboolTieneComp = True

   ''   frmCompPlanFill = True
   ''End Function

   Private Function frmCompPlanFill() As Boolean

      mlngPlanId = ProveedorPlanIdPasFind(moCompra.ProveedorId, mlngPlanAddId)
      mlngSucursalId = SucursalIdFind(moCompra.AlmacenId)
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
      mlngTipoPlanId = TipoPlanIdFind(mlngPlanId)

      mboolTieneComp = True
      frmCompPlanFill = True

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

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moCompra.Update() Then
            ''If ventaDetUpdate(moCompra.CompraId, moCompra.EstadoId) Then
            DataUpdate = True
            ''End If

         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim oRow As DataRow

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         FormCheck = False
         Throw New Exception("Fecha Inicial no Corresponde a la Gestion en Uso")

      ElseIf Not OperaFechaHabil(ToDate(dtpFecha.Value)) Then
         FormCheck = False
         Throw New Exception("Fecha de Operación Inhábil para el Usuario")
      End If

      If dtpFecha.Value > Now Then
         FormCheck = False
         Throw New Exception("Fecha no Valida, No puede ser mayor a la Actual")
      End If

      If dtpFecha.Value < grdFactura.GetValue("Fecha") Then
         FormCheck = False
         Throw New Exception("Fecha no Válida, No puede ser Menor al de la Compra")
      End If

      If ToDecimal(txtTipoCambio.Text) <= 0 Then
         strMsg &= "Tipo de Cambio Inválido" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub ItemParametroAux(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngTipoItemIdAux = 0
         mlngTipoCosteoIdAux = 0
         mlngMedidaIdAux = 0
         mlngMedidaIdEquiAux = 0
         mdecMedidaCantEquiAux = 0
         mlngMonedaIdCosAux = 0
         ''mboolControlLoteAux = False
         ''mboolControlSerieAux = False

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngTipoItemIdAux = ToLong(.TipoItemId)
               mlngTipoCosteoIdAux = ToLong(.TipoCosteoId)
               mlngMedidaIdAux = ToLong(.MedidaId)
               mlngMedidaIdEquiAux = ToLong(.MedidaIdEqui)
               mdecMedidaCantEquiAux = ToDecimal(.MedidaCantEqui)
               mlngMonedaIdCosAux = ToLong(.MonedaIdCos)
               ''mboolControlLoteAux = ToBoolean(.ControlLote)
               ''mboolControlSerieAux = ToBoolean(.ControlSerie)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub ItemSaldoParametroAux(ByVal lngItemId As Long, ByVal lngAlmacenId As Long)
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)

      Try
         mdecPrecioPPPAux = 0
         mdecPrecioUPCAux = 0
         mdecSaldoItemAux = 0

         With oItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.All
            .WhereFilter = clsItemSaldo.WhereFilters.ItemId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Find Then
               mdecPrecioPPPAux = ToDecimal(.PrecioPPP)
               mdecPrecioUPCAux = ToDecimal(.PrecioUPC)
               mdecSaldoItemAux = ToDecimal(.Saldo)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemSaldo.Dispose()

      End Try
   End Sub

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

   Private Function ItemPrecioCos(ByVal decPrecioCos As Decimal, ByVal lngMonedaIdCos As Long) As Decimal
      Dim decPrecio As Decimal = decPrecioCos

      If moCompra.MonedaId = 1 Then
         If moCompra.MonedaId <> lngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos * moCompra.TipoCambio)
         End If

      ElseIf moCompra.MonedaId = 2 Then
         If moCompra.MonedaId <> lngMonedaIdCos Then
            decPrecio = ToDecimal(decPrecioCos / moCompra.TipoCambio)
         End If
      End If

      Return decPrecio
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

            .EmpresaId = moCompraDet.EmpresaId
            .GestionId = moCompraDet.GestionId
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

            .EmpresaId = moCompraDet.EmpresaId
            .GestionId = moCompraDet.GestionId
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

   Private Function ItemPrecioCostoTotal(ByVal lngItemId As Long) As Decimal
      Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

      Try
         ItemPrecioCostoTotal = 0

         With oComposicion
            .SelectFilter = clsComposicion.SelectFilters.All
            .WhereFilter = clsComposicion.WhereFilters.ItemId
            .EmpresaId = moCompra.EmpresaId
            .ItemId = lngItemId

            If .Open() Then

               While .Read
                  Call ItemParametroAux(.ItemIdCom)
                  Call ItemSaldoParametroAux(.ItemIdCom, moCompra.AlmacenId)

                  If mlngTipoItemIdAux = 1 Then 'Item de Inventario

                     If mlngTipoCosteoIdAux = 1 Then
                        If mlngMedidaIdAux = .MedidaId Then
                           ItemPrecioCostoTotal += (ItemPrecioCos(mdecPrecioPPPAux, mlngMonedaIdCosAux) * .Cantidad)
                        Else
                           ItemPrecioCostoTotal += (ItemPrecioCos(mdecPrecioPPPAux * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                        End If

                     ElseIf mlngTipoCosteoIdAux = 2 Then
                        If mlngMedidaIdAux = .MedidaId Then
                           ItemPrecioCostoTotal += (ItemPrecioCos(mdecPrecioUPCAux, mlngMonedaIdCosAux) * .Cantidad)
                        Else
                           ItemPrecioCostoTotal += (ItemPrecioCos(mdecPrecioUPCAux * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                        End If

                     ElseIf mlngTipoCosteoIdAux = 3 Then
                        If mlngMedidaIdAux = .MedidaId Then
                           ItemPrecioCostoTotal += (ItemPrecioCos(ItemPepsPPP(moCompra.AlmacenId, .Cantidad, .ItemIdCom), mlngMonedaIdCosAux) * .Cantidad)
                        Else
                           ItemPrecioCostoTotal += (ItemPrecioCos(ItemPepsPPP(moCompra.AlmacenId, .Cantidad * mdecMedidaCantEquiAux, .ItemIdCom) * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                        End If

                     ElseIf mlngTipoCosteoIdAux = 4 Then
                        If mlngMedidaIdAux = .MedidaId Then
                           ItemPrecioCostoTotal += (ItemPrecioCos(ItemUepsPPP(moCompra.AlmacenId, .Cantidad, .ItemIdCom), mlngMonedaIdCosAux) * .Cantidad)
                        Else
                           ItemPrecioCostoTotal += (ItemPrecioCos(ItemUepsPPP(moCompra.AlmacenId, .Cantidad * mdecMedidaCantEquiAux, .ItemIdCom) * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                        End If
                     End If

                  End If

                  .MoveNext()
               End While

            End If
         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oComposicion.Dispose()
      End Try

   End Function

   Private Function ItemComPrecioCostoTotal(ByVal lngItemId As Long) As Decimal
      Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

      Try
         ItemComPrecioCostoTotal = 0

         With oComposicion
            .SelectFilter = clsComposicion.SelectFilters.All
            .WhereFilter = clsComposicion.WhereFilters.ItemId
            .EmpresaId = moCompra.EmpresaId
            .ItemId = lngItemId

            If .Open() Then

               While .Read
                  Call ItemParametroAux(.ItemIdCom)
                  Call ItemSaldoParametroAux(.ItemIdCom, moCompra.AlmacenId)

                  If mlngTipoItemIdAux = 1 Then 'Item de Inventario

                     If mlngTipoCosteoIdAux = 1 Then
                        If mlngMedidaIdAux = .MedidaId Then
                           ItemComPrecioCostoTotal += (ItemPrecioCos(mdecPrecioPPPAux, mlngMonedaIdCosAux) * .Cantidad)
                        Else
                           ItemComPrecioCostoTotal += (ItemPrecioCos(mdecPrecioPPPAux * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                        End If

                     ElseIf mlngTipoCosteoIdAux = 2 Then
                        If mlngMedidaIdAux = .MedidaId Then
                           ItemComPrecioCostoTotal += (ItemPrecioCos(mdecPrecioUPCAux, mlngMonedaIdCosAux) * .Cantidad)
                        Else
                           ItemComPrecioCostoTotal += (ItemPrecioCos(mdecPrecioUPCAux * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                        End If

                     ElseIf mlngTipoCosteoIdAux = 3 Then
                        If mlngMedidaIdAux = .MedidaId Then
                           ItemComPrecioCostoTotal += (ItemPrecioCos(ItemPepsPPP(moCompra.AlmacenId, .Cantidad, .ItemIdCom), mlngMonedaIdCosAux) * .Cantidad)
                        Else
                           ItemComPrecioCostoTotal += (ItemPrecioCos(ItemPepsPPP(moCompra.AlmacenId, .Cantidad * mdecMedidaCantEquiAux, .ItemIdCom) * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                        End If

                     ElseIf mlngTipoCosteoIdAux = 4 Then
                        If mlngMedidaIdAux = .MedidaId Then
                           ItemComPrecioCostoTotal += (ItemPrecioCos(ItemUepsPPP(moCompra.AlmacenId, .Cantidad, .ItemIdCom), mlngMonedaIdCosAux) * .Cantidad)
                        Else
                           ItemComPrecioCostoTotal += (ItemPrecioCos(ItemUepsPPP(moCompra.AlmacenId, .Cantidad * mdecMedidaCantEquiAux, .ItemIdCom) * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                        End If
                     End If

                  End If

                  .MoveNext()
               End While

            End If
         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oComposicion.Dispose()
      End Try

   End Function

   Private Function ItemComPrecioCosto(ByVal lngItemId As Long, ByVal lngItemIdCom As Long) As Decimal
      Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

      Try
         ItemComPrecioCosto = 0

         With oComposicion
            .SelectFilter = clsComposicion.SelectFilters.All
            .WhereFilter = clsComposicion.WhereFilters.ItemId
            .EmpresaId = moCompra.EmpresaId
            .ItemId = lngItemId

            If .Open() Then

               While .Read

                  If .ItemIdCom = lngItemIdCom Then

                     Call ItemParametroAux(.ItemIdCom)
                     Call ItemSaldoParametroAux(.ItemIdCom, moCompra.AlmacenId)

                     If mlngTipoItemIdAux = 1 Then 'Item de Inventario

                        If mlngTipoCosteoIdAux = 1 Then
                           If mlngMedidaIdAux = .MedidaId Then
                              ItemComPrecioCosto += (ItemPrecioCos(mdecPrecioPPPAux, mlngMonedaIdCosAux) * .Cantidad)
                           Else
                              ItemComPrecioCosto += (ItemPrecioCos(mdecPrecioPPPAux * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                           End If

                        ElseIf mlngTipoCosteoIdAux = 2 Then
                           If mlngMedidaIdAux = .MedidaId Then
                              ItemComPrecioCosto += (ItemPrecioCos(mdecPrecioUPCAux, mlngMonedaIdCosAux) * .Cantidad)
                           Else
                              ItemComPrecioCosto += (ItemPrecioCos(mdecPrecioUPCAux * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                           End If

                        ElseIf mlngTipoCosteoIdAux = 3 Then
                           If mlngMedidaIdAux = .MedidaId Then
                              ItemComPrecioCosto += (ItemPrecioCos(ItemPepsPPP(moCompra.AlmacenId, .Cantidad, .ItemIdCom), mlngMonedaIdCosAux) * .Cantidad)
                           Else
                              ItemComPrecioCosto += (ItemPrecioCos(ItemPepsPPP(moCompra.AlmacenId, .Cantidad * mdecMedidaCantEquiAux, .ItemIdCom) * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                           End If

                        ElseIf mlngTipoCosteoIdAux = 4 Then
                           If mlngMedidaIdAux = .MedidaId Then
                              ItemComPrecioCosto += (ItemPrecioCos(ItemUepsPPP(moCompra.AlmacenId, .Cantidad, .ItemIdCom), mlngMonedaIdCosAux) * .Cantidad)
                           Else
                              ItemComPrecioCosto += (ItemPrecioCos(ItemUepsPPP(moCompra.AlmacenId, .Cantidad * mdecMedidaCantEquiAux, .ItemIdCom) * mdecMedidaCantEquiAux, mlngMonedaIdCosAux) * .Cantidad)
                           End If
                        End If

                     End If
                     Exit While

                  End If
                  .MoveNext()
               End While

            End If
         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oComposicion.Dispose()
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

   Private Sub grdMainPlanId()
      For Each oRow As DataRow In moDataSet.Tables(moCompraDet.TableName).Rows
         oRow("PlanId") = PlanIdActFind(oRow("ItemId"))
      Next
   End Sub

   Private Function grdMainItemInventario() As Boolean
      grdMainItemInventario = False

      For Each oRow As DataRow In moDataSet.Tables(moCompraDet.TableName).Rows
         If oRow("TipoItemId") = 1 Then 'Inventario
            Return True

         ElseIf oRow("TipoItemId") = 3 Then 'Paquete
            Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

            Try
               With oComposicion
                  .SelectFilter = clsComposicion.SelectFilters.All
                  .WhereFilter = clsComposicion.WhereFilters.ItemId
                  .EmpresaId = moCompra.EmpresaId
                  .ItemId = ToLong(oRow("ItemId"))

                  If .Open() Then
                     While .Read
                        Call ItemParametroAux(.ItemIdCom)

                        If mlngTipoItemIdAux = 1 Then 'Inventario
                           Return True
                        End If

                        .MoveNext()
                     End While
                  End If
               End With

            Catch ex As Exception
               MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
               oComposicion.Dispose()
            End Try
         End If
      Next
   End Function

   Private Function ExeIcePorFind(ByVal lngFacturaId As Long) As Decimal
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               If .FacturaMonto <> 0 Then
                  Return (.Exento + .IceIehd) / .FacturaMonto
               Else
                  Return 0
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

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
               ''.PorConcepto &= IIf(Trim(strDes) <> String.Empty, "; " & strDes, "")
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
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = moCompra.Fecha
            .PlanId = lngPlanId
            .CompDetDes = ToStr("Nota de Compra al " + cboTipoPago.Text + " Nro. " + txtCompraNro.Text + "; " + moCompra.CompraDes + " " + strDes)
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
            .TipoRetencionId = 0
            .EstadoId = clsEstado.CERRADO

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
               If .MonedaId = clsMoneda.BOLIVIANOS Then
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

               ElseIf .MonedaId = clsMoneda.DOLARES Then
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

   Private Function CompFind(ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngSucursalId As Long, ByRef lngCompId As Long) As Boolean
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

      CompEdit = True

      Try
         'If CompFind(moCompra.TipoCompId, moCompra.CompNro, clsAppInfo.SucursalId, lngCompId) Then
         If isCompFind(lngCompId, lngTipoCompId, lngCompNro) Then
            If CompDetDeleteAll(lngCompId) Then 'Elimina el detalle del Comprobante
               '' Call grdMainPlanId()

               If moCompra.FacturaId > 0 Then
                  decFacturaIvaBs = FacturaIvaBsFind(moCompra.FacturaId, decFacturaIvaUs)

               ElseIf chkFacturaDif.Checked Then 'Factura Diferida
                  If moCompra.MonedaId = 1 Then
                     decFacturaIvaBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IVA)
                     decFacturaIvaUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IVA)

                  ElseIf moCompra.MonedaId = 2 Then
                     decFacturaIvaBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IVA)
                     decFacturaIvaUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IVA)
                  End If
               End If

               For Each oRow In moDataSet.Tables(moCompraDet.TableName).Rows
                  decParticipa = oRow("ImporteBru") / moCompra.MontoBru
                  decImporte = oRow("ImporteBru") '+ (decRecargoApli * decParticipa) - (decDescuentoApli * decParticipa)

                  If (moCompra.FacturaId = 0) And (Not chkFacturaDif.Checked) Then 'Compra Sin Factura
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
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoBs, decMontoUs, 1, moFactura.SucursalIdOrg) Then
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
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoBs, decMontoUs, 1, moFactura.SucursalIdOrg) Then
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

                     If Not CompDetCentroCostoFind(lngCompId, lngCompDetId, oRow("PlanIdAct"), 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld, oRow("PlanIdAct")) Then
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
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moFactura.SucursalIdOrg) Then
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
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moFactura.SucursalIdOrg) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     End If

                  ElseIf chkFacturaDif.Checked Then 'Factura Diferida
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
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moFactura.SucursalIdOrg) Then
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
                              If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanIdAct"), ToLong(oRow("CentroCostoIdAct")), ToLong(oRow("CentroCostoDetIdAct")), decMontoIvaBs, decMontoIvaUs, 1, moFactura.SucursalIdOrg) Then
                                 CompEdit = True
                              End If
                           End If
                        End If
                     End If
                  End If
               Next

               decGralMontoBs += decTotalMontoBs
               decGralMontoUs += decTotalMontoUs

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

                  If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 2, mlngSucursalId, moCompra.CentroCostoId, lngCompDetId) Then
                     If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                           CompEdit = True
                        End If
                     End If
                  End If
               End If

               If (decTotalMontoBs > 0) And (decTotalMontoUs > 0) Then 'Contra Cuenta
                  If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 2, mlngSucursalId, moCompra.CentroCostoId, lngCompDetId) Then
                     If mlngPlanAddId <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 2, moCompra.SucursalId) Then
                           CompEdit = True
                        End If
                     End If
                  End If

               ElseIf (decTotalMontoBs < 0) And (decTotalMontoUs < 0) Then
                  decTotalMontoBs = Math.Abs(decTotalMontoBs)
                  decTotalMontoUs = Math.Abs(decTotalMontoUs)
                  decTotalMontoOrg = Math.Abs(decTotalMontoOrg)

                  decGralMontoBs += decTotalMontoBs
                  decGralMontoUs += decTotalMontoUs

                  If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decTotalMontoBs, decTotalMontoUs, decTotalMontoOrg, 1, mlngSucursalId, , lngCompDetId) Then
                     If mlngPlanAddId <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decTotalMontoBs, decTotalMontoUs, 1, moCompra.SucursalId) Then
                           CompEdit = True
                        End If
                     End If
                  End If
               End If

               If moCompra.FacturaId <> 0 Then 'Cuenta de Credito Fiscal
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreId, "", decIvaBs, decIvaUs, decIvaOrg, 1, mlngSucursalId, , , 1) Then
                     If FacturaUpdate(moCompra.FacturaId, lngTipoCompId, lngCompId, 0) Then 'Ponerle CompId a la Factura
                        CompEdit = True
                     End If
                  End If

               ElseIf chkFacturaDif.Checked Then 'Factura Diferida
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreDifId, "", decIvaBs, decIvaUs, decIvaOrg, 1, mlngSucursalId, , , 0) Then
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
            .Fecha = moCompra.Fecha
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
               CompDetDeleteAll = True

               With oCompPlanAdd

                  .WhereFilter = clsCompPlanAdd.WhereFilters.CompId
                  .CompId = lngCompId
                  .EmpresaId = moCompra.EmpresaId

                  Call .Delete()   'Delete Analiticos

               End With

               With oCompCentroCostoDet  'Delete Actividades

                  .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompId
                  .CompId = lngCompId
                  .EmpresaId = moCompra.EmpresaId

                  Call .Delete()

               End With

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
            .Fecha = moCompra.Fecha
            .PlanId = lngPlanId
            .MonedaId = moCompra.MonedaId
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

            .EstadoId = clsEstado.CERRADO

            ''If .Insert() Then
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
               .EstadoId = clsEstado.CERRADO

               Return .Update()
            End If
         End With

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FacturaIvaBsFind(ByVal lngFacturaId As Long, ByRef decFacturaIvaUs As Decimal) As Decimal
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      FacturaIvaBsFind = 0

      Try
         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               FacturaIvaBsFind = .IVA
               decFacturaIvaUs = ToDecimal(.IVA / moCompra.TipoCambio)
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oFactura.Dispose()

      End Try
   End Function

#Region " Factura "

   Private Sub grdFacturaLoad()
      Try

         With moCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.GridCompra
            .WhereFilter = clsCompraFac.WhereFilters.GridCompra
            .OrderByFilter = clsCompraFac.OrderByFilters.GridCompra
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = moCompra.CompraId

            If .Open() Then
               grdFactura.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdFactura.RetrieveStructure()
               Call grdFacturaInit()
            End If
            .CloseConection()
         End With

      Catch exp As Exception

         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try


   End Sub

   Private Sub FacturaDataShow()
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         If grdFactura.RowCount > 0 Then
            With oFactura
               .FacturaId = ToLong(grdFactura.GetValue("FacturaId"))

               If .FindByPK Then
                  Dim frm As New frmFacturaEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oFactura

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura = Nothing

      End Try
   End Sub

   Private Sub FacturaDataDelete()
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         If grdFactura.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               With oFactura
                  .WhereFilter = clsFactura.WhereFilters.PrimaryKey
                  .FacturaId = ToLong(grdFactura.GetValue("FacturaId"))

                  ''If FacturaDifAnular(.FacturaId, 12) Then
                  If FacturaDifAnular(.FacturaId, 12) Then
                     '' Anular el comprobante de la Factura y eliminar el CompraFac y restaurar el tipo el MOnto de la Factura
                     Call grdFacturaLoad()
                  End If

               End With

            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura = Nothing

      End Try
   End Sub

   Private Sub FacturaDataEdit(ByVal lngRegRUCId As Long, ByVal strRegRUCDes As String)
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decTipoCambio As Decimal
      Dim decMontoFactura As Decimal = 0

      Try
         If grdFactura.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere poner la Factura en " & strRegRUCDes & " ? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               With oFactura
                  .WhereFilter = clsFactura.WhereFilters.PrimaryKey
                  .FacturaId = ToLong(grdFactura.GetValue("FacturaId"))

                  If .FindByPK Then
                     decMontoFactura = .FacturaMonto
                     .RegRUCId = lngRegRUCId
                     .NroRUC = 0
                     .RegRUCDes = strRegRUCDes

                     .FacturaFecha = ToDate(.FacturaFecha)

                     .IceIehd = 0
                     .Exento = 0
                     .FacturaMonto = 0

                     .Bancarizar = ToBoolean(False)
                     .IVA = ToDecimal(0)

                     If .Update Then
                        '' Anular el comprobante de la Factura y eliminar el CompraFac y restaurar el tipo el MOnto de la Factura
                        If CompAnular(.CompId, 12, decTipoCambio, " - Anulado por Nro. de Factura ") Then

                           If moCompra.MonedaId = clsMoneda.DOLARES Then
                              decMontoFactura = decMontoFactura / decTipoCambio
                           End If

                           If CompraUpdateMontoFac(moCompra.CompraId, -decMontoFactura) Then  'Actualizando el monto de la Compra facturado
                              Call grdFacturaLoad()
                           End If

                        End If
                     End If
                  End If
               End With

            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura = Nothing

      End Try
   End Sub

   Private Function FacturaDifAnular(ByVal lngFacturaId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decTipoCambio As Decimal
      Dim decMontoFactura As Decimal = 0
      Dim strDes As String = ""

      Try
         FacturaDifAnular = False

         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               .EstadoId = lngEstadoId
               .FacturaFecha = ToDate(.FacturaFecha)
               decMontoFactura = .FacturaMonto

               'Anulando el comprobante
               If .CompId <> 0 Then
                  If .Update Then  'Anulando la Factura

                     'Anulando el comprobante
                     strDes = " - Anulado por Nro. de Factura "
                     If CompAnular(.CompId, lngEstadoId, decTipoCambio, strDes) Then

                        If CompraFacRestoreDelete(lngFacturaId, decMontoFactura) Then
                           FacturaDifAnular = True
                        End If

                     End If
                  End If

               ElseIf .CompId = 0 Then

                  .WhereFilter = clsFactura.WhereFilters.PrimaryKey
                  If .Delete() Then

                     If CompraFacRestoreDelete(lngFacturaId, decMontoFactura) Then
                        FacturaDifAnular = True
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()
      End Try
   End Function

   Private Function CompraFacRestoreDelete(ByVal lngFacturaId As Long, ByVal decMontoFactura As Decimal) As Boolean
      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)
      Dim decTipoCambio As Decimal

      Try
         CompraFacRestoreDelete = True

         With oCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.All
            .WhereFilter = clsCompraFac.WhereFilters.FacturaId
            .FacturaId = lngFacturaId

            If .Open() Then
               Do While .Read()

                  If (.MontoCompra = 0) And (.CompraId = moCompra.CompraId) Then    ''Lo que hacia antes
                     ''Lo que hacia antes Una Factura una Compra
                     decTipoCambio = .TipoCambio

                     If moCompra.MonedaId = clsMoneda.DOLARES Then
                        decMontoFactura = ToDecimal(decMontoFactura / decTipoCambio)
                     End If

                     .WhereFilter = clsCompraFac.WhereFilters.PrimaryKey
                     If .Delete Then
                        If CompraUpdateMontoFac(moCompra.CompraId, -decMontoFactura) Then  'Actualizando el monto de la Compra facturado
                           CompraFacRestoreDelete = True
                           ''Exit Do
                        End If
                     End If

                  Else
                     ''Multiple Factura
                     .WhereFilter = clsCompraFac.WhereFilters.PrimaryKey
                     If .Delete Then    'eliminado la relacion de la Factura y Compra
                        If CompraUpdateMontoFac(.CompraId, -.MontoCompra) Then  'Actualizando el monto de la Compra facturado
                           CompraFacRestoreDelete = True
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
      End Try

   End Function

   Private Function CompraUpdateMontoFac(ByVal lngCompraId As Long, ByVal decMontoFac As Decimal) As Boolean
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      CompraUpdateMontoFac = False

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .MontoFac = decMontoFac

               .UpdateFilter = clsCompra.UpdateFilters.MontoFac

               If .Update() Then
                  If moCompra.CompraId = lngCompraId Then
                     moCompra.MontoFac += decMontoFac ''Sumamos por q esta decMontofac en Negativo  
                     CompraUpdateMontoFac = True
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

   Private Function CompAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long, ByRef decTipoCambio As Decimal, ByRef strDes As String) As Boolean
      If lngCompId = 0 Then
         Return True
      End If

      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      Try
         CompAnular = False

         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               .EstadoId = lngEstadoId
               .Fecha = ToDate(.Fecha)
               .PorConcepto = .PorConcepto & strDes
               decTipoCambio = .TipoCambio

               If .Update Then
                  If CompDetAnular(lngCompId, lngEstadoId) Then
                     If CompPlanAddAnular(lngCompId, lngEstadoId) Then
                        If CompCCDetAnular(lngCompId, lngEstadoId) Then
                           CompAnular = True
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

   Private Sub grdFacturaFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdFactura.RootTable.Columns("FacturaId")

      grdFactura.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Function grdFacturaTotal() As Decimal
      Dim decTotal As Decimal = 0

      ''With moFactura
      ''   For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
      ''      decTotal += oRow("IVA")
      ''   Next
      ''End With

      If moCompra.FacturaId <> 0 Then
         For Each oRow As DataRow In moFactura.DataSet.Tables(moFactura.TableName).Rows
            decTotal += oRow("IVA")
         Next
      Else
         For Each oRow As DataRow In moCompraFac.DataSet.Tables(moCompraFac.TableName).Rows
            decTotal += oRow("IVA")
         Next
      End If


      If decTotal > 0 Then
         If moCompra.MonedaId = clsMoneda.BOLIVIANOS Then
            Return decTotal
         Else
            Return ToDecimal(decTotal / moCompra.TipoCambio)
         End If
      Else
         Return decTotal
      End If
   End Function

   Private Sub grdFacturaInit()
      With grdFactura
         ebrFactura.Groups(0).Text = "Facturas "
         .ContextMenu = mnuFactura

         .RootTable.Columns("FacturaId").Visible = False

         .RootTable.Columns("TipoFacturaId").Visible = False

         .RootTable.Columns("FacturaNro").Caption = "Nro Factura"
         .RootTable.Columns("FacturaNro").Width = 100
         .RootTable.Columns("FacturaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FacturaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaFecha").Caption = "Fecha"
         .RootTable.Columns("FacturaFecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FacturaFecha").Width = 100
         .RootTable.Columns("FacturaFecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FacturaFecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("RegRUCId").Visible = False

         .RootTable.Columns("NroRUC").Caption = "NIT"
         .RootTable.Columns("NroRUC").Width = 100
         .RootTable.Columns("NroRUC").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("NroRUC").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("RegRUCDes").Caption = "Razón Social"
         .RootTable.Columns("RegRUCDes").Width = 150
         .RootTable.Columns("RegRUCDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("RegRUCDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroAutorizacion").Caption = "Nro Autorización"
         .RootTable.Columns("NroAutorizacion").Width = 100
         .RootTable.Columns("NroAutorizacion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("NroAutorizacion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CodControl").Caption = "Código Control"
         .RootTable.Columns("CodControl").Width = 100
         .RootTable.Columns("CodControl").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CodControl").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaMonto").Caption = "Importe"
         .RootTable.Columns("FacturaMonto").FormatString = DecimalMask()
         .RootTable.Columns("FacturaMonto").Width = 100
         .RootTable.Columns("FacturaMonto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("FacturaMonto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("IceIehd").Caption = "ICE/IEHD"
         .RootTable.Columns("IceIehd").FormatString = DecimalMask()
         .RootTable.Columns("IceIehd").Width = 100
         .RootTable.Columns("IceIehd").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IceIehd").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Exento").Caption = "Exento"
         .RootTable.Columns("Exento").FormatString = DecimalMask()
         .RootTable.Columns("Exento").Width = 100
         .RootTable.Columns("Exento").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Exento").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SubTotal").Caption = "Sub-Total"
         .RootTable.Columns("SubTotal").FormatString = DecimalMask()
         .RootTable.Columns("SubTotal").Width = 100
         .RootTable.Columns("SubTotal").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SubTotal").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Descuento").Caption = "Descuento"
         .RootTable.Columns("Descuento").FormatString = DecimalMask()
         .RootTable.Columns("Descuento").Width = 100
         .RootTable.Columns("Descuento").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Descuento").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Neto").Caption = "Neto"
         .RootTable.Columns("Neto").FormatString = DecimalMask()
         .RootTable.Columns("Neto").Width = 100
         .RootTable.Columns("Neto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Neto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("IVA").Caption = "IVA"
         .RootTable.Columns("IVA").FormatString = DecimalMask()
         .RootTable.Columns("IVA").Width = 100
         .RootTable.Columns("IVA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IVA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteIVA").Caption = "Importe - IVA"
         .RootTable.Columns("ImporteIVA").FormatString = DecimalMask()
         .RootTable.Columns("ImporteIVA").Width = 100
         .RootTable.Columns("ImporteIVA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteIVA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With
   End Sub

   Private Sub grdFactura_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdFactura.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then

            If grdFactura.RowCount > 0 Then
               mnuShowFactura.Enabled = True
               mnuDeleteFactura.Enabled = True
            Else
               mnuShowFactura.Enabled = False
               mnuDeleteFactura.Enabled = False
            End If
         Else
            mnuShowFactura.Enabled = True
            mnuDeleteFactura.Enabled = False
         End If

      End If
   End Sub

   Private Sub grdFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdFactura.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdFactura.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdFactura.GetRow.Cells(grdFactura.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub grdFactura_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdFactura.DoubleClick
      Call FacturaDataShow()
   End Sub

   Private Sub mnuShowFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowFactura.Click
      Call FacturaDataShow()
   End Sub

   Private Sub mnuDeleteFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteFactura.Click
      Call FacturaDataDelete()
   End Sub

#End Region

#Region " Detalle de la Compra "

   Private Sub CompraDetDataTableLoad()

      Try
         With moCompraDet
            .SelectFilter = clsCompraDet.SelectFilters.Grid
            .WhereFilter = clsCompraDet.WhereFilters.Grid
            .OrderByFilter = clsCompraDet.OrderByFilters.Grid
            .EmpresaId = moCompra.EmpresaId
            .CompraId = moCompra.CompraId

            If .Open() Then
               Call moDataSetInit()

               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows

                  'Esto es para las Compras viejas
                  If oRow("PlanIdAct") = 0 Then
                     oRow("PlanIdAct") = PlanIdActFind(oRow("ItemId"))
                  End If

                  moDataTable.Rows.Add(GetRowShow(oRow))

               Next
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

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
      moDataTable.Columns.Add("CompraDetDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Estado", Type.GetType("System.String"))

      moDataTable.Columns.Add("PlanIdAct", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanAddIdAct", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CentroCostoIdAct", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CentroCostoDetIdAct", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SucursalIdAct", Type.GetType("System.Int32"))

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

      Return oRow
   End Function


#End Region

   Private Sub frmAplicarQuitarFacturaDif_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmAplicarQuitarFacturaDif_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
      moCompra.Dispose()
      Call ClearMemory()
   End Sub

End Class