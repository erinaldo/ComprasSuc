Public Class frmContadoPagoDetEdit
   Inherits System.Windows.Forms.Form

   Private moPago As clsPago
   Private mdecUfv As Decimal
   Private moDataTable As DataTable

   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngTipoPlanId As Long
   Private mboolTieneComp As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean
   Private mboolAplicarITF As Boolean

   Private mstrCompraNro As String
   Private mdecMontoPagBs As Decimal
   Private mdecMontoPagUs As Decimal
   Private mdecMontoRecBs As Decimal
   Private mdecMontoRecUs As Decimal
   Private mdecMontoDesBs As Decimal
   Private mdecMontoDesUs As Decimal
   Private mdecMontoPagAntBs As Decimal
   Private mdecMontoPagAntUs As Decimal
   Private mdecMontoPagOrg As Decimal

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents ebrAnticipos As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdAnticipo As Janus.Windows.GridEX.GridEX
   Friend WithEvents txtMontoEfecPag As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtMontoAntPag As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtMontoDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboPlanDescuento As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtMontoRec As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboPlanRecargo As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents chkSinFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents txtCapital As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Private mlngID As Long

   Property PagoDataTable() As DataTable
      Get
         Return moDataTable
      End Get

      Set(ByVal Value As DataTable)
         moDataTable = Value
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

   WriteOnly Property SinFac() As Boolean
      Set(ByVal Value As Boolean)
         mboolSinFac = Value
      End Set
   End Property

   WriteOnly Property ConFac() As Boolean
      Set(ByVal Value As Boolean)
         mboolConFac = Value
      End Set
   End Property

   Property DataObject() As clsPago
      Get
         Return moPago
      End Get

      Set(ByVal Value As clsPago)
         moPago = Value
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
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtProveedorId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents txtMontoPag As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtPagoId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPagoDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEquiUfv As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContadoPagoDetEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdAnticipo = New Janus.Windows.GridEX.GridEX
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrAnticipos = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtCapital = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.chkSinFac = New Janus.Windows.EditControls.UICheckBox
      Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
      Me.txtMontoDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboPlanDescuento = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtMontoRec = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboPlanRecargo = New Janus.Windows.EditControls.UIComboBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtMontoEfecPag = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.txtMontoAntPag = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtPagoDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtMontoPag = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.lblCentroCosto = New System.Windows.Forms.Label
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label16 = New System.Windows.Forms.Label
      Me.txtProveedorId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPagoId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtEquiUfv = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.lblSucursal = New System.Windows.Forms.Label
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdAnticipo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrAnticipos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrAnticipos.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdAnticipo)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(676, 143)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdAnticipo
      '
      Me.grdAnticipo.AllowCardSizing = False
      Me.grdAnticipo.AlternatingColors = True
      Me.grdAnticipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdAnticipo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdAnticipo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdAnticipo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdAnticipo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdAnticipo.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdAnticipo.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdAnticipo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdAnticipo.GroupByBoxVisible = False
      Me.grdAnticipo.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdAnticipo.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdAnticipo.Location = New System.Drawing.Point(0, 0)
      Me.grdAnticipo.Name = "grdAnticipo"
      Me.grdAnticipo.RecordNavigator = True
      Me.grdAnticipo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdAnticipo.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdAnticipo.Size = New System.Drawing.Size(676, 143)
      Me.grdAnticipo.TabIndex = 19
      Me.grdAnticipo.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdAnticipo.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdAnticipo.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdAnticipo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("0e9a011c-64a3-47fa-80f4-631873a99f25")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(155, 28)
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
      Me.Exit2.ImageIndex = 1
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
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
      Me.TopRebar1.Size = New System.Drawing.Size(708, 28)
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.ebrAnticipos)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(708, 477)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'ebrAnticipos
      '
      Me.ebrAnticipos.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrAnticipos.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 144
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrAnticipos.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrAnticipos.GroupSeparation = 4
      Me.ebrAnticipos.Location = New System.Drawing.Point(8, 285)
      Me.ebrAnticipos.Name = "ebrAnticipos"
      Me.ebrAnticipos.Size = New System.Drawing.Size(692, 176)
      Me.ebrAnticipos.TabIndex = 18
      Me.ebrAnticipos.Text = "ExplorerBar2"
      Me.ebrAnticipos.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrAnticipos.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrAnticipos.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrAnticipos.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtCapital)
      Me.UiGroupBox1.Controls.Add(Me.Label12)
      Me.UiGroupBox1.Controls.Add(Me.chkSinFac)
      Me.UiGroupBox1.Controls.Add(Me.chkConFac)
      Me.UiGroupBox1.Controls.Add(Me.txtMontoDes)
      Me.UiGroupBox1.Controls.Add(Me.cboPlanDescuento)
      Me.UiGroupBox1.Controls.Add(Me.Label1)
      Me.UiGroupBox1.Controls.Add(Me.txtMontoRec)
      Me.UiGroupBox1.Controls.Add(Me.cboPlanRecargo)
      Me.UiGroupBox1.Controls.Add(Me.Label8)
      Me.UiGroupBox1.Controls.Add(Me.txtMontoEfecPag)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.txtMontoAntPag)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.Label9)
      Me.UiGroupBox1.Controls.Add(Me.txtPagoDes)
      Me.UiGroupBox1.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox1.Controls.Add(Me.Label2)
      Me.UiGroupBox1.Controls.Add(Me.txtMontoPag)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 116)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(692, 161)
      Me.UiGroupBox1.TabIndex = 6
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtCapital
      '
      Me.txtCapital.BackColor = System.Drawing.SystemColors.Info
      Me.txtCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCapital.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCapital.FormatString = "##,##0.000"
      Me.txtCapital.Location = New System.Drawing.Point(560, 12)
      Me.txtCapital.Name = "txtCapital"
      Me.txtCapital.ReadOnly = True
      Me.txtCapital.Size = New System.Drawing.Size(124, 20)
      Me.txtCapital.TabIndex = 288
      Me.txtCapital.TabStop = False
      Me.txtCapital.Text = "0,000"
      Me.txtCapital.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCapital.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCapital.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(456, 16)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 289
      Me.Label12.Text = "Capital"
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
      Me.chkSinFac.Location = New System.Drawing.Point(115, 132)
      Me.chkSinFac.Name = "chkSinFac"
      Me.chkSinFac.Size = New System.Drawing.Size(32, 16)
      Me.chkSinFac.TabIndex = 277
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
      Me.chkConFac.Location = New System.Drawing.Point(167, 132)
      Me.chkConFac.Name = "chkConFac"
      Me.chkConFac.Size = New System.Drawing.Size(32, 16)
      Me.chkConFac.TabIndex = 276
      Me.chkConFac.Text = "F"
      Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtMontoDes
      '
      Me.txtMontoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoDes.FormatString = "##,##0.000"
      Me.txtMontoDes.Location = New System.Drawing.Point(560, 59)
      Me.txtMontoDes.Name = "txtMontoDes"
      Me.txtMontoDes.Size = New System.Drawing.Size(124, 20)
      Me.txtMontoDes.TabIndex = 14
      Me.txtMontoDes.Text = "0,000"
      Me.txtMontoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoDes.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanDescuento
      '
      Me.cboPlanDescuento.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanDescuento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanDescuento.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanDescuento.Location = New System.Drawing.Point(116, 59)
      Me.cboPlanDescuento.Name = "cboPlanDescuento"
      Me.cboPlanDescuento.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanDescuento.Size = New System.Drawing.Size(306, 20)
      Me.cboPlanDescuento.TabIndex = 13
      Me.cboPlanDescuento.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 63)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 275
      Me.Label1.Text = "Descuento"
      '
      'txtMontoRec
      '
      Me.txtMontoRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoRec.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoRec.FormatString = "##,##0.000"
      Me.txtMontoRec.Location = New System.Drawing.Point(560, 35)
      Me.txtMontoRec.Name = "txtMontoRec"
      Me.txtMontoRec.Size = New System.Drawing.Size(124, 20)
      Me.txtMontoRec.TabIndex = 11
      Me.txtMontoRec.Text = "0,000"
      Me.txtMontoRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoRec.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanRecargo
      '
      Me.cboPlanRecargo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanRecargo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanRecargo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanRecargo.Location = New System.Drawing.Point(116, 35)
      Me.cboPlanRecargo.Name = "cboPlanRecargo"
      Me.cboPlanRecargo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanRecargo.Size = New System.Drawing.Size(306, 20)
      Me.cboPlanRecargo.TabIndex = 10
      Me.cboPlanRecargo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 39)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 274
      Me.Label8.Text = "Recargo"
      '
      'txtMontoEfecPag
      '
      Me.txtMontoEfecPag.BackColor = System.Drawing.Color.MistyRose
      Me.txtMontoEfecPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoEfecPag.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoEfecPag.FormatString = "##,##0.000"
      Me.txtMontoEfecPag.Location = New System.Drawing.Point(560, 132)
      Me.txtMontoEfecPag.Name = "txtMontoEfecPag"
      Me.txtMontoEfecPag.ReadOnly = True
      Me.txtMontoEfecPag.Size = New System.Drawing.Size(124, 20)
      Me.txtMontoEfecPag.TabIndex = 12
      Me.txtMontoEfecPag.TabStop = False
      Me.txtMontoEfecPag.Text = "0,000"
      Me.txtMontoEfecPag.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoEfecPag.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoEfecPag.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(456, 136)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 269
      Me.Label4.Text = "Monto Efectivo"
      '
      'txtMontoAntPag
      '
      Me.txtMontoAntPag.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoAntPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoAntPag.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoAntPag.FormatString = "##,##0.000"
      Me.txtMontoAntPag.Location = New System.Drawing.Point(560, 108)
      Me.txtMontoAntPag.Name = "txtMontoAntPag"
      Me.txtMontoAntPag.ReadOnly = True
      Me.txtMontoAntPag.Size = New System.Drawing.Size(124, 20)
      Me.txtMontoAntPag.TabIndex = 15
      Me.txtMontoAntPag.TabStop = False
      Me.txtMontoAntPag.Text = "0,000"
      Me.txtMontoAntPag.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoAntPag.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoAntPag.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(456, 112)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 267
      Me.Label3.Text = "Monto Anticipo"
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(7, 92)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 255
      Me.Label9.Text = "Observaciones"
      '
      'txtPagoDes
      '
      Me.txtPagoDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPagoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPagoDes.Location = New System.Drawing.Point(115, 88)
      Me.txtPagoDes.MaxLength = 1000
      Me.txtPagoDes.Multiline = True
      Me.txtPagoDes.Name = "txtPagoDes"
      Me.txtPagoDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtPagoDes.Size = New System.Drawing.Size(308, 40)
      Me.txtPagoDes.TabIndex = 17
      Me.txtPagoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPagoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(116, 12)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(124, 20)
      Me.cboMoneda.TabIndex = 7
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(8, 16)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 240
      Me.Label2.Text = "Moneda"
      '
      'txtMontoPag
      '
      Me.txtMontoPag.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPag.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPag.FormatString = "##,##0.000"
      Me.txtMontoPag.Location = New System.Drawing.Point(560, 83)
      Me.txtMontoPag.Name = "txtMontoPag"
      Me.txtMontoPag.ReadOnly = True
      Me.txtMontoPag.Size = New System.Drawing.Size(124, 20)
      Me.txtMontoPag.TabIndex = 8
      Me.txtMontoPag.Text = "0,000"
      Me.txtMontoPag.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPag.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPag.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(456, 87)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(101, 16)
      Me.Label6.TabIndex = 230
      Me.Label6.Text = "Monto a Pagar"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboSucursal)
      Me.grpMain.Controls.Add(Me.lblSucursal)
      Me.grpMain.Controls.Add(Me.cboCentroCosto)
      Me.grpMain.Controls.Add(Me.lblCentroCosto)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.txtProveedorId)
      Me.grpMain.Controls.Add(Me.txtPagoId)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.txtEquiUfv)
      Me.grpMain.Controls.Add(Me.Label13)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(692, 116)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(490, 88)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(194, 20)
      Me.cboCentroCosto.TabIndex = 258
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCentroCosto.Location = New System.Drawing.Point(444, 92)
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Size = New System.Drawing.Size(44, 16)
      Me.lblCentroCosto.TabIndex = 259
      Me.lblCentroCosto.Text = "C. C. "
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(116, 88)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.ReadOnly = True
      Me.txtTipoCambio.Size = New System.Drawing.Size(124, 20)
      Me.txtTipoCambio.TabIndex = 4
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label11.Location = New System.Drawing.Point(8, 92)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(104, 16)
      Me.Label11.TabIndex = 257
      Me.Label11.Text = "Tipo Cambio"
      '
      'dtpFecha
      '
      Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFecha.DropDownCalendar.Name = ""
      Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dtpFecha.Location = New System.Drawing.Point(116, 64)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.ReadOnly = True
      Me.dtpFecha.Size = New System.Drawing.Size(124, 20)
      Me.dtpFecha.TabIndex = 3
      Me.dtpFecha.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label16.Location = New System.Drawing.Point(8, 68)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 255
      Me.Label16.Text = "Fecha"
      '
      'txtProveedorId
      '
      Me.txtProveedorId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtProveedorId.Location = New System.Drawing.Point(116, 40)
      Me.txtProveedorId.Name = "txtProveedorId"
      Me.txtProveedorId.ReadOnly = True
      Me.txtProveedorId.Size = New System.Drawing.Size(308, 20)
      Me.txtProveedorId.TabIndex = 2
      Me.txtProveedorId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtProveedorId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPagoId
      '
      Me.txtPagoId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPagoId.Location = New System.Drawing.Point(116, 16)
      Me.txtPagoId.Name = "txtPagoId"
      Me.txtPagoId.ReadOnly = True
      Me.txtPagoId.Size = New System.Drawing.Size(124, 20)
      Me.txtPagoId.TabIndex = 1
      Me.txtPagoId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPagoId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 170
      Me.Label5.Text = "Proveedor"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 20)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 168
      Me.Label7.Text = "ID"
      '
      'txtEquiUfv
      '
      Me.txtEquiUfv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEquiUfv.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEquiUfv.FormatString = "##,##0.000"
      Me.txtEquiUfv.Location = New System.Drawing.Point(532, 40)
      Me.txtEquiUfv.Name = "txtEquiUfv"
      Me.txtEquiUfv.ReadOnly = True
      Me.txtEquiUfv.Size = New System.Drawing.Size(124, 20)
      Me.txtEquiUfv.TabIndex = 9
      Me.txtEquiUfv.TabStop = False
      Me.txtEquiUfv.Text = "0,000"
      Me.txtEquiUfv.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtEquiUfv.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtEquiUfv.Visible = False
      Me.txtEquiUfv.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(500, 44)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(28, 16)
      Me.Label13.TabIndex = 261
      Me.Label13.Text = "UFV"
      Me.Label13.Visible = False
      '
      'cboSucursal
      '
      Me.cboSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboSucursal.BackColor = System.Drawing.SystemColors.Info
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(490, 64)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(194, 20)
      Me.cboSucursal.TabIndex = 272
      Me.cboSucursal.TabStop = False
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblSucursal
      '
      Me.lblSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
      Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSucursal.Location = New System.Drawing.Point(435, 68)
      Me.lblSucursal.Name = "lblSucursal"
      Me.lblSucursal.Size = New System.Drawing.Size(56, 16)
      Me.lblSucursal.TabIndex = 273
      Me.lblSucursal.Text = "Sucursal"
      '
      'frmContadoPagoDetEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(708, 505)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmContadoPagoDetEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "frmContadoPagoDet Edit"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdAnticipo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.ebrAnticipos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrAnticipos.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
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
               mlngID = moPago.PagoId
               mboolChanged = True

               Call DataReadOnly()

               If MessageBox.Show("Pago Realizado Exitosamente" + vbCrLf + "¿Desea Imprimir el Pago?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        PrintReportPago(moPago.TipoPagoId, moPago.PagoId, moPago.SucursalId, ToDecimalDos(txtMontoAntPag.Text), ToDecimalDos(txtCapital.Text))
               Else
                  Me.Close()
               End If

            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmContadoPagoDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmContadoPagoDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Pago de Notas al Contado"
         Else
            Me.Text = "Editar Pago de Notas al Contado"
         End If
      Else
         Me.Text = "Nuevo Pago de Notas al Contado"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moPago
         txtPagoId.Text = ToStr(.PagoId)
         Call txtProveedorIdLoad(.ProveedorId)
         dtpFecha.Text = ToStr(.Fecha)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         cboPlanRecargo.SelectedIndex = ListFindItem(cboPlanRecargo, .PlanRecargoId)
         txtMontoRec.Text = ToDecStr(.MontoRec)
         cboPlanDescuento.SelectedIndex = ListFindItem(cboPlanDescuento, .PlanDescuentoId)
         txtMontoDes.Text = ToDecStr(.MontoDes)
         txtPagoDes.Text = ToStr(.PagoDes)

         chkConFac.Checked = .ConFac
         chkSinFac.Checked = .SinFac
         cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

         If Not clsAppInfo.MultipleNro Then
            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moPago
         txtPagoId.Text = String.Empty
         Call txtProveedorIdLoad(.ProveedorId)
         dtpFecha.Text = ToStr(.Fecha)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtPagoDes.Text = String.Empty

         If clsAppInfo.MultipleNro Then
            chkConFac.Enabled = False
            chkSinFac.Enabled = False

            chkConFac.Checked = mboolConFac
            chkSinFac.Checked = mboolSinFac

         Else
            chkConFac.Checked = False
            chkSinFac.Checked = True

            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

         cboPlanRecargo.SelectedIndex = -1
         txtMontoRec.Text = "0"
         cboPlanDescuento.SelectedIndex = -1
         txtMontoDes.Text = "0"

         cboCentroCosto.SelectedIndex = -1
         If clsAppInfo.CentroCostoApli Then
            cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
            cboCentroCosto.ReadOnly = True
         End If

         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)
         cboSucursal.ReadOnly = True

         Call grdAnticipoLoad()
         Call MontoPagar()
         Call txtMontoPagar()

      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtPagoId.ReadOnly = True
      txtProveedorId.ReadOnly = True
      dtpFecha.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      cboMoneda.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtMontoPag.ReadOnly = True
      txtPagoDes.ReadOnly = True
      cboCentroCosto.ReadOnly = True
      'chkConFac.Enabled = True
      'chkSinFac.Enabled = True
      cboSucursal.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
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
         cboSucursal.Visible = True
         lblSucursal.Visible = True
      Else
         cboSucursal.Visible = False
         lblSucursal.Visible = False
      End If

   End Sub

   Private Sub DataMove()
      With moPago
         If Not mboolAdding Then
            .PagoId = ToLong(txtPagoId.Text)
         End If

         .Fecha = ToDate(dtpFecha.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .Capital = ToDecimal(txtMontoPag.Text)
         .Interes = 0
         .MontoPag = ToDecimal(txtMontoEfecPag.Text)
         .PlanRecargoId = ListPosition(cboPlanRecargo, cboPlanRecargo.SelectedIndex)
         .MontoRec = ToDecimal(txtMontoRec.Text)
         .PlanDescuentoId = ListPosition(cboPlanDescuento, cboPlanDescuento.SelectedIndex)
         .MontoDes = ToDecimal(txtMontoDes.Text)
         .PagoDes = ToStr(txtPagoDes.Text)
         .EstadoId = 11
         .ConFac = ToBoolean(chkConFac.Checked)
         .SinFac = ToBoolean(chkSinFac.Checked)
         .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)

      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboMoneda.Select()
   End Sub

   Private Function DataSave() As Boolean
      Dim lngCompId As Long
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim ProveedorMovId As Long

      Try
         txtProveedorId.Select()

         Call DataMove()

         If FormCheck() Then
            If mboolAdding Then
               If clsAppInfo.Inventario Then 'Adicion Integrado a Contabilidad
                  If frmCompPlanFill() Then
                     moPago.PagoNro = CompraNroNext(7, clsAppInfo.GestionId, moPago.SucursalId)

                     If DataAdd() Then
                        If grdMainSave() Then
                           If mboolTieneComp Then
                              If CompNew(lngCompId, lngTipoCompId, lngCompNro) Then
                                 If ProveedorMovAdd(ProveedorMovId, 7, moPago.PagoId, 1, moPago.PagoDes, moPago.MonedaId, moPago.Capital, 3, lngTipoCompId, lngCompNro, mlngPlanId) Then
                                    moPago.CompId = lngCompId
                                    moPago.PlanId = mlngPlanId 'Cuenta Variable

                                    If DataUpdate() Then
                                       If AnticipoUpdate() Then
                                          DataSave = True
                                       End If
                                    End If
                                 End If
                              End If

                           Else
                              If ProveedorMovAdd(ProveedorMovId, 7, moPago.PagoId, 1, moPago.PagoDes, moPago.MonedaId, moPago.Capital, 3, 0, 0, 0) Then
                                 If AnticipoUpdate() Then
                                    DataSave = True
                                 End If
                              End If
                           End If
                        End If
                     End If
                  End If

               Else
                  moPago.PagoNro = CompraNroNext(7, clsAppInfo.GestionId, moPago.SucursalId)

                  If DataAdd() Then
                     If grdMainSave() Then
                        If ProveedorMovAdd(ProveedorMovId, 7, moPago.PagoId, 1, moPago.PagoDes, moPago.MonedaId, moPago.Capital, 3, 0, 0, 0) Then
                           If AnticipoUpdate() Then
                              DataSave = True
                           End If
                        End If
                     End If
                  End If
               End If
            Else
               DataSave = DataUpdate()
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

         If moPago.Insert() Then
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

         If moPago.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If (Not chkConFac.Checked) And (Not chkSinFac.Checked) Then
         FormCheck = False
         Throw New Exception("Valores Inválidos en (I o F)")
      End If

      If (chkConFac.Checked <> mboolConFac) Or (chkSinFac.Checked <> mboolSinFac) Then
         FormCheck = False
         Throw New Exception("No puede ser diferente (I y F) de la Compra con el Pago")
      End If

      If grdAnticipo.RowCount > 0 Then
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdAnticipo.GetCheckedRows
            If (CBool(oRow.Cells("SinFac").Value) <> mboolSinFac) Or (CBool(oRow.Cells("ConFac").Value) <> mboolConFac) Then
               FormCheck = False
               Throw New Exception("No puede ser diferente (I y F) Pago con los Anticipos")
            End If
         Next
      End If

      If moPago.MonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If ToDecimal(txtMontoPag.Text) <= 0 Then
         strMsg &= "Monto a Pagar Inválido" & vbCrLf
      End If

      If moPago.PlanRecargoId <> 0 Then
         If ToDecimal(txtMontoRec.Text) <= 0 Then
            strMsg &= "Monto de Recargo Inválido" & vbCrLf
         End If
      End If

      If ToDecimal(txtMontoRec.Text) > 0 Then
         If moPago.PlanRecargoId = 0 Then
            strMsg &= "Recargo Inválido" & vbCrLf
         End If
      End If

      If moPago.PlanDescuentoId <> 0 Then
         If ToDecimal(txtMontoDes.Text) <= 0 Then
            strMsg &= "Monto de Descuento Inválido" & vbCrLf
         End If
      End If

      If ToDecimal(txtMontoDes.Text) > 0 Then
         If moPago.PlanDescuentoId = 0 Then
            strMsg &= "Descuento Inválido" & vbCrLf
         End If
      End If

      If ToDecimal(txtMontoEfecPag.Text) < 0 Then
         strMsg &= "Monto Anticipo Mayor al Monto a Pagar" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function grdMainSave() As Boolean
      Dim oRow As DataRow
      Dim decCapital As Decimal = 0
      Dim decInteres As Decimal = 0

      grdMainSave = True

      Try
         With moPago
            For Each oRow In moDataTable.Rows
               decInteres = 0
               decCapital = 0

               If ToBoolean(CBool(oRow("Sel"))) Then
                  If oRow("MonedaId") = 1 Then
                     If moPago.MonedaId = 1 Then
                        decCapital = ToDecimal(oRow("MontoLiq"))
                     Else
                        decCapital = ToDecimal(oRow("MontoLiq") / ToDecimal(txtTipoCambio.Text))
                     End If

                  ElseIf oRow("MonedaId") = 2 Then
                     If moPago.MonedaId = 1 Then
                        decCapital = ToDecimal(oRow("MontoLiq") * ToDecimal(txtTipoCambio.Text))
                     Else
                        decCapital = ToDecimal(oRow("MontoLiq"))
                     End If
                  End If

                  If decCapital > 0 Then
                     If PagoDetAdd(oRow("CompraId"), decCapital, decInteres) Then
                        If CompraUpdate(oRow("CompraId"), 14) Then 'Estado Realizado
                           grdMainSave = True
                        End If
                     End If
                  End If
               End If
            Next
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function PagoDetAdd(ByVal lngCompraId As Long, ByVal decCapital As Decimal, ByVal decInteres As Decimal) As Boolean
      Dim oPagoDet As New clsPagoDet(clsAppInfo.ConnectString)

      PagoDetAdd = False

      Try
         With oPagoDet
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .TipoPagoId = moPago.TipoPagoId
            .PagoId = moPago.PagoId
            .CompraId = lngCompraId
            .CreditoId = 0
            .CreditoDetId = 0
            .ProveedorId = moPago.ProveedorId
            .Fecha = ToDate(dtpFecha.Value)
            .MonedaId = moPago.MonedaId
            .TipoCambio = moPago.TipoCambio
            .CapitalOrg = decCapital
            .InteresOrg = decInteres
            .CapitalAmo = decCapital
            .InteresAmo = decInteres
            .CentroCostoId = moPago.CentroCostoId
            .SucursalId = moPago.SucursalId
            .EstadoId = 14

            If .Insert() Then
               PagoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPagoDet.Dispose()

      End Try
   End Function

   Private Function ProveedorMovAdd(ByRef lngProveedorMovId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                   ByVal lngTipoPagoId As Long, ByVal strDes As String, ByVal lngMonedaId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                   ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .ProveedorId = moPago.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moPago.Fecha
            .ProveedorMovDes = strDes
            .MonedaId = lngMonedaId
            .TipoCambio = moPago.TipoCambio
            .CentroCostoId = moPago.CentroCostoId
            .SucursalId = moPago.SucursalId
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
            .EmpresaId = moPago.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .EstadoId = 11 'Abierto

            If .Find Then
               .Fecha = ToDate(.Fecha)

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
                  End If

               ElseIf lngCol = 3 Then
                  .DebeBs = ToDecimal(decValor * .TipoCambio)
                  .DebeUs = decValor

                  .HaberBs = .DebeBs
                  .HaberUs = .DebeUs
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

   Private Function CompNew(ByRef lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      'Dim lngCompId As Long
      Dim lngCompDetId As Long
      Dim lngPlanIdPas As Long
      Dim lngPlanAddIdPas As Long
      Dim lngPlanIdInt As Long
      Dim lngPlanAddIdInt As Long
      Dim lngCompPlanAddId As Long
      Dim lngPlanIdRecargo As Long
      Dim lngPlanIdDescuento As Long

      Dim decITFBs As Decimal = 0
      Dim decITFUs As Decimal = 0
      Dim decITFOrg As Decimal = 0

      Dim decMontoOrg As Decimal
      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0
      Dim decMontoOrgAnt As Decimal
      Dim decMontoBsTotal As Decimal = 0
      Dim decMontoUsTotal As Decimal = 0
      Dim decMontoOrgTotal As Decimal = 0

      CompNew = True

      Try
         If ToDecimal(txtMontoEfecPag.Text) > 0 Then
            lngTipoCompId = 2 'Egreso

         ElseIf ToDecimal(txtMontoAntPag.Text) > 0 Then
            lngTipoCompId = 3 'Traspaso

         End If

         lngPlanIdPas = PlanIdPasFind(moPago.ProveedorId, lngPlanAddIdPas, lngPlanIdInt, lngPlanAddIdInt)

         If moPago.MonedaId = 1 Then
            decMontoOrg = mdecMontoPagBs - mdecMontoPagAntBs
            decMontoOrgAnt = mdecMontoPagAntBs
            decMontoBsTotal = mdecMontoPagBs - mdecMontoPagAntBs + mdecMontoRecBs - mdecMontoDesBs
            decMontoUsTotal = ToDecimal(decMontoBsTotal / moPago.TipoCambio)
            decMontoOrgTotal = decMontoBsTotal
            mdecMontoPagOrg = mdecMontoPagBs

            If mboolAplicarITF Then
               decITFUs = ToDecimal(decMontoUsTotal * clsAppInfo.ITF)
               decITFBs = ToDecimal(decMontoBsTotal * clsAppInfo.ITF)
               decITFOrg = decITFBs
            End If

         ElseIf moPago.MonedaId = 2 Then
            decMontoOrg = mdecMontoPagUs - mdecMontoPagAntUs
            decMontoOrgAnt = mdecMontoPagAntUs
            decMontoUsTotal = mdecMontoPagUs - mdecMontoPagAntUs + mdecMontoRecUs - mdecMontoDesUs
            decMontoBsTotal = ToDecimal(decMontoUsTotal * moPago.TipoCambio)
            decMontoOrgTotal = decMontoUsTotal
            mdecMontoPagOrg = mdecMontoPagUs

            If mboolAplicarITF Then
               decITFUs = ToDecimal(decMontoUsTotal * clsAppInfo.ITF)
               decITFBs = ToDecimal(decMontoBsTotal * clsAppInfo.ITF)
               decITFOrg = decITFUs
            End If

         End If

         If (mdecMontoPagBs > 0) And (mdecMontoPagUs > 0) Then 'Monto Pagar

            If CompAdd(lngTipoCompId, lngCompNro, lngCompId, mdecMontoPagBs, mdecMontoPagUs) Then 'Cabecera Comprobante

               'Cuenta Pasivo Proveedor
               If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdPas, "", mdecMontoPagBs, mdecMontoPagUs, mdecMontoPagOrg, 1, moPago.SucursalId, moPago.CentroCostoId, lngCompDetId) Then
                  If lngPlanAddIdPas <> 0 Then  'Analitico Adicional
                     If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdPas, lngPlanAddIdPas, mdecMontoPagBs, mdecMontoPagUs, 1, moPago.SucursalId) Then
                        CompNew = True
                     End If
                  End If
               End If

               'Cuenta Caja o banco
               If (decMontoBsTotal > 0) And (decMontoUsTotal > 0) Then 'Monto Pagar
                  If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decMontoBsTotal, decMontoUsTotal, decMontoOrgTotal, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                     If mlngPlanAddId <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decMontoBsTotal, decMontoUsTotal, 2, moPago.SucursalId) Then
                           CompNew = True
                        End If
                     End If

                     If mlngCentroCostoDetId <> 0 Then  'Actividad
                        If CompCentroCostoDetAdd(lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, decMontoBsTotal, decMontoUsTotal, 2, moPago.SucursalId) Then
                           CompNew = True
                        End If
                     End If

                     If mlngTipoPlanId = 3 Then 'En Caso de que Tenga Chequera
                        If TieneChequeraCreada(mlngPlanId) Then
                           If frmCompChequeEditLoad(lngCompId, lngCompDetId, mlngPlanId, decMontoBsTotal, decMontoUsTotal) Then
                              CompNew = True
                           End If
                        Else
                           MessageBox.Show("Debe Definir la Chequera para Esta Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                     End If
                  End If

                  'Aplicando ITF
                  If mboolAplicarITF Then
                     If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decITFBs, decITFUs, decITFOrg, 2, mlngSucursalId, moPago.CentroCostoId, lngCompDetId, 1) Then
                        CompNew = True
                     End If

                     If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITFId, "", decITFBs, decITFUs, decITFOrg, 1, mlngSucursalId, moPago.CentroCostoId, lngCompDetId, 1) Then
                        CompNew = True
                     End If
                  End If

               End If

               If (mdecMontoRecBs > 0) And (mdecMontoRecUs > 0) Then 'Recargo
                  lngPlanIdRecargo = PlanRecargoPlanIdFind(moPago.PlanRecargoId)

                  If moPago.MonedaId = 1 Then
                     decMontoOrg = mdecMontoRecBs

                  ElseIf moPago.MonedaId = 2 Then
                     decMontoOrg = mdecMontoRecUs
                  End If

                  If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdRecargo, "", mdecMontoRecBs, mdecMontoRecUs, decMontoOrg, 1, moPago.SucursalId, moPago.CentroCostoId) Then
                     CompNew = True
                  End If
               End If

               If (mdecMontoDesBs > 0) And (mdecMontoDesUs > 0) Then 'Descuento
                  lngPlanIdDescuento = PlanDescuentoPlanIdFind(moPago.PlanDescuentoId)

                  If moPago.MonedaId = 1 Then
                     decMontoOrg = mdecMontoDesBs

                  ElseIf moPago.MonedaId = 2 Then
                     decMontoOrg = mdecMontoDesUs
                  End If

                  If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdDescuento, "", mdecMontoDesBs, mdecMontoDesUs, decMontoOrg, 2, moPago.SucursalId, moPago.CentroCostoId) Then
                     CompNew = True
                  End If
               End If

               'Anticipos de Proveedor
               If mdecMontoPagAntBs > 0 And mdecMontoPagAntUs > 0 Then 'Monto con Anticipo
                  Dim lngPlanAddIdAct As Long
                  Dim lngPlanIdAct As Long = ProveedorPlanIdActFind(moPago.ProveedorId, lngPlanAddIdAct)

                  If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", mdecMontoPagAntBs, mdecMontoPagAntUs, decMontoOrgAnt, 2, moPago.SucursalId, moPago.CentroCostoId, lngCompDetId) Then
                     If lngPlanAddIdAct <> 0 Then  'Analitico Adicional
                        If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdAct, lngPlanAddIdAct, mdecMontoPagAntBs, mdecMontoPagAntUs, 2, moPago.SucursalId) Then
                           CompNew = True
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

   Private Function CompAdd(ByVal lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long, ByVal decTotalBs As Decimal _
                            , ByVal decTotalUs As Decimal) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = CompNroNext(.TipoCompId, moPago.GestionId, moPago.SucursalId)
            .Fecha = moPago.Fecha
            .MonedaId = moPago.MonedaId
            .TipoCambio = moPago.TipoCambio
            .EntregadoA = ToStr(txtProveedorId.Text)
            .PorConcepto = "Pago Nota de Compra al Contado Nro. " & mstrCompraNro & "; " & ToStr(txtPagoDes.Text)
            .DebeBs = decTotalBs
            .HaberBs = decTotalBs
            .DebeUs = decTotalUs
            .HaberUs = decTotalUs
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF
            .ConFac = moPago.ConFac
            .SinFac = moPago.SinFac
            .Automatico = 0
            .Glosa = ""
            '.TipoNotaId = 0
            '.NotaNro = 0
            .TipoAsientoId = 0
            .EstadoId = 10

            .SucursalId = moPago.SucursalId
            .NotaId = 0
            .AppId = clsAppInfo.AppId
            .TipoDocumentoId = clsTipoCompra.PAGO_CREDITO
            .DocumentoId = moPago.PagoId

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

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = moPago.Fecha
            .PlanId = lngPlanId
            .CompDetDes = "Pago Nota de Compra al Contado Nro. " & mstrCompraNro & " " & ToStr(txtPagoDes.Text)
            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId
            .MonedaId = moPago.MonedaId
            .EstadoId = 10

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

   Private Function CompDetUpdate(ByVal lngCompId As Long, ByVal lngPlanId As Long, ByVal strDes As String, _
                                 ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal decValorOrg As Decimal, _
                                 ByVal lngCol As Long, Optional ByRef lngCompDetId As Long = 0) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetUpdate = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompId
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .CompId = lngCompId
            .PlanId = lngPlanId

            If .Find Then
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

               .CompDetDes += " " + strDes + ";"
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

   Private Function CompFind(ByRef lngTipoCompId As Long, ByRef lngCompNro As Long, ByVal lngSucursalId As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompFind = False

      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.All
            .WhereFilter = clsComp.WhereFilters.CompNro
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
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

   Private Function CompDetFind(ByVal lngCompId As Long, ByRef lngCompDetId As Long, ByVal lngPlanId As Long, _
                               ByVal lngCol As Long, ByRef decValorBs As Decimal, ByRef decValorUs As Decimal, _
                               ByRef decValorOrg As Decimal) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetFind = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompId
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
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
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moPago.Fecha
            .PlanId = lngPlanId
            .MonedaId = moPago.MonedaId
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

   Private Function CompCentroCostoDetAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngCentroCostoId As Long, _
                                 ByVal lngCentroCostoDetId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompCentroCostoDetAdd = False

      Try
         With oCompCentroCostoDet
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moPago.Fecha
            .PlanId = lngPlanId
            .MonedaId = moPago.MonedaId
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

   Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompNroNext = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moPago.EmpresaId
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
            .EmpresaId = moPago.EmpresaId
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

   Private Function PlanIdPasFind(ByVal lngProveedorId As Long, ByRef lngPlanAddIdPas As Long, ByRef lngPlanIdInt As Long, ByRef lngPlanAddIdInt As Long) As Long
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      PlanIdPasFind = 0

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               lngPlanIdInt = .PlanIdInt
               lngPlanAddIdInt = .PlanAddIdInt
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

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraNroNext = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moPago.EmpresaId
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

   Private Function TieneChequeraCreada(ByVal lngPlanId As Long) As Boolean
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      TieneChequeraCreada = False

      Try
         With oCheque
            .SelectFilter = clsCheque.SelectFilters.All
            .WhereFilter = clsCheque.WhereFilters.PlanId
            .EmpresaId = moPago.EmpresaId
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

   Private Function frmCompChequeEditLoad(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal decMontoBs As Decimal, ByVal decMontoUs As Decimal) As Boolean
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

            Dim lngMonedaId As Long = PlanMonedaIdFind(lngPlanId)

            If boolFind Then
               frm.NewRecord = False
               frm.Editing = True
               frm.DesdeComp = True

               .MonedaId = lngMonedaId
               .TipoCambio = moPago.TipoCambio
               .EstadoId = 10

               If lngMonedaId = 1 Then
                  .ChequeMonto = ToDecimal(decMontoBs)
               ElseIf lngMonedaId = 2 Then
                  .ChequeMonto = ToDecimal(decMontoUs)
               End If

            Else
               frm.NewRecord = True
               frm.Editing = False
               frm.DesdeComp = True

               .EmpresaId = ToLong(moPago.EmpresaId)
               .GestionId = ToLong(moPago.GestionId)
               .CompId = lngCompId
               .CompDetId = lngCompDetId
               .PlanId = lngPlanId
               .MonedaId = lngMonedaId
               .TipoCambio = moPago.TipoCambio
               .Fecha = ConvertDMY(moPago.Fecha)
               .ChequeDes = ToStr(txtProveedorId.Text)
               .EstadoId = 10

               If lngMonedaId = 1 Then
                  .ChequeMonto = ToDecimal(decMontoBs)
               ElseIf lngMonedaId = 2 Then
                  .ChequeMonto = ToDecimal(decMontoUs)
               End If

            End If

            frm.DataObject = oCompCheque
            frm.ShowDialog()

            If frm.Changed Then
               ''mlngCompChequeId = frm.ID
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
      mboolAplicarITF = False

      If clsAppInfo.SucursalApli Then
         mlngSucursalId = moPago.SucursalId
      End If

      If ToDecimal(txtMontoEfecPag.Text) > 0 Then

         With frm
            .EmpresaId = moPago.EmpresaId
            .PlanWhereFilter = clsPlan.WhereFilters.CajaBanco
            .CentroCostoId = moPago.CentroCostoId
            .SucursalId = moPago.SucursalId
            .ShowDialog()

            If .Changed Then
               mlngPlanId = frm.PlanId
               mlngPlanAddId = frm.PlanAddId
               mlngSucursalId = frm.SucursalId
               mlngCentroCostoId = frm.CentroCostoId
               mlngCentroCostoDetId = frm.CentroCostoDetId
               mlngTipoPlanId = TipoPlanIdFind(mlngPlanId, strPlanDes, lngMonedaIdPlan)
               mboolTieneComp = frm.TieneComp

               If (mlngTipoPlanId = 3) And (lngMonedaIdPlan = clsMoneda.DOLARES) Then  'Tipo Cuenta 3 = Banco -- Cuenta Corriente
                  If MessageBox.Show("¿Desea Aplicar I.T.F. a la Cuenta  " & strPlanDes & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     mboolAplicarITF = True
                  End If
               End If

               frmCompPlanFill = True

            End If
            frm.Dispose()
         End With
      Else
         frmCompPlanFill = True
         mboolTieneComp = True  'Si en caso de q tega anticipos descargados
      End If
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

   Private Sub FormInit()
      Call FormCenter(Me)

      txtTipoCambio.FormatString = DecimalMask()
      txtCapital.FormatString = DecimalMask()
      txtMontoPag.FormatString = DecimalMask()
      txtMontoRec.FormatString = DecimalMask()
      txtMontoDes.FormatString = DecimalMask()
      txtMontoAntPag.FormatString = DecimalMask()
      txtMontoEfecPag.FormatString = DecimalMask()

   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboPlanRecargoLoad()
      Call cboPlanDescuentoLoad()
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

   Private Sub cboPlanRecargoLoad()
      Dim oPlanRecargo As New clsPlanRecargo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPlanRecargo.Items.Clear()

      Try
         With oPlanRecargo
            .SelectFilter = clsPlanRecargo.SelectFilters.ListBox
            .WhereFilter = clsPlanRecargo.WhereFilters.EmpresaId
            .OrderByFilter = clsPlanRecargo.OrderByFilters.PlanRecargoDes
            .EmpresaId = moPago.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.PlanRecargoId, .PlanRecargoDes)

                  cboPlanRecargo.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanRecargo.Dispose()
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
            .EmpresaId = moPago.EmpresaId

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
            .CentroCostoId = moPago.CentroCostoId

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
            .TipoCompraId = clsTipoCompra.PAGO_CREDITO

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

   Private Sub txtProveedorIdLoad(ByVal lngProveedorId As Long)
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               txtProveedorId.Tag = .ProveedorId
               txtProveedorId.Text = ToStr(.ProveedorDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Sub

   Private Sub txtUfvLoad(ByVal strFecha As String)
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      Try
         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = strFecha

            If .Find Then
               mdecUfv = .Ufv
            Else
               mdecUfv = 0
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub

   Private Sub MontoPagar()
      Dim oRow As DataRow
      Dim decMontoLiqBs As Decimal = 0
      Dim decMontoLiqUs As Decimal = 0
      Dim strCompraNro As String = ""

      For Each oRow In moDataTable.Rows
         If ToBoolean(CBool(oRow("Sel"))) Then
            If oRow("MonedaId") = 1 Then
               decMontoLiqBs += ToDecimal(oRow("MontoLiq"))
               strCompraNro &= ToStr(oRow("CompraNro")) & ", "

            ElseIf oRow("MonedaId") = 2 Then
               decMontoLiqUs += ToDecimal(oRow("MontoLiq"))
               strCompraNro &= ToStr(oRow("CompraNro")) & ", "
            End If
         End If
      Next

      mdecMontoPagBs = ToDecimal(decMontoLiqBs + (decMontoLiqUs * ToDecimal(txtTipoCambio.Text)))
      mdecMontoPagUs = ToDecimal(decMontoLiqUs + (decMontoLiqBs / ToDecimal(txtTipoCambio.Text)))
      mstrCompraNro = strCompraNro

   End Sub

   Private Sub txtMontoPagar()
      Dim lngMonedaId As Long = ListPosition(cboMoneda, cboMoneda.SelectedIndex)

      If lngMonedaId = 1 Then
         txtMontoRec.Text = ToDecimal(mdecMontoRecBs)
         txtMontoDes.Text = ToDecimal(mdecMontoDesBs)
         txtCapital.Text = ToDecimal(mdecMontoPagBs)
         txtMontoPag.Text = ToDecimal(mdecMontoPagBs)
         txtMontoAntPag.Text = ToDecimal(mdecMontoPagAntBs)
         txtMontoEfecPag.Text = ToDecimal(mdecMontoPagBs + mdecMontoRecBs - mdecMontoDesBs - mdecMontoPagAntBs)

         If mdecUfv > 0 Then
            txtEquiUfv.Text = ToDecimal(mdecMontoPagBs / mdecUfv)
         Else
            txtEquiUfv.Text = 0
         End If
      Else
         txtMontoRec.Text = ToDecimal(mdecMontoRecUs)
         txtMontoDes.Text = ToDecimal(mdecMontoDesUs)
         txtCapital.Text = ToDecimal(mdecMontoPagUs)
         txtMontoPag.Text = ToDecimal(mdecMontoPagUs)
         txtMontoAntPag.Text = ToDecimal(mdecMontoPagAntUs)
         txtMontoEfecPag.Text = ToDecimal(mdecMontoPagUs + mdecMontoRecUs - mdecMontoDesUs - mdecMontoPagAntUs)

         If mdecUfv > 0 Then
            txtEquiUfv.Text = ToDecimal((mdecMontoPagUs * ToDecimal(txtTipoCambio.Text)) / mdecUfv)
         Else
            txtEquiUfv.Text = 0
         End If
      End If

   End Sub

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
            .EmpresaId = moPago.EmpresaId
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

#Region " Anticipo "
   Private moAnticipo As clsAnticipo
   Private mstrSepDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

   Private Sub grdAnticipoLoad()
      moAnticipo = New clsAnticipo(clsAppInfo.ConnectString)

      Try
         With moAnticipo

            .SelectFilter = clsAnticipo.SelectFilters.GridCompraNew
            ''.WhereFilter = clsAnticipo.WhereFilters.GridPedCompraNew
            .WhereFilter = clsAnticipo.WhereFilters.GridPagoNew
            .OrderByFilter = clsAnticipo.OrderByFilters.AnticipoNro
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .ProveedorId = moPago.ProveedorId
            .TipoAnticipoId = 2 'Solo Anticipos
            .EstadoId = 13
            ''.TipoCambio = 0
            .CompId = 0
            .PedCompraId = 0
            .CentroCostoId = moPago.CentroCostoId
            .SucursalId = moPago.SucursalId

            If .Open() Then
               grdAnticipo.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdAnticipo.RetrieveStructure()
               Call grdAnticipoInit()

            End If
            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdAnticipoFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdAnticipo.RootTable.Columns("AnticipoId")

      grdAnticipo.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdAnticipoInit()
      With grdAnticipo
         ebrAnticipos.Groups(0).Text = "Anticipos"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         If clsAppInfo.SucursalApli Then
            .RootTable.Columns("SucursalId").Visible = False
            .RootTable.Columns("SucursalDes").Caption = "Sucursal"
            .RootTable.Columns("SucursalDes").Width = 100
            .RootTable.Columns("SucursalDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("SucursalDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         Else
            .RootTable.Columns("SucursalId").Visible = False
            .RootTable.Columns("SucursalDes").Visible = False
         End If

         .RootTable.Columns("MontoPen").Caption = "Pendiente"
         .RootTable.Columns("MontoPen").FormatString = DecimalMask()
         .RootTable.Columns("MontoPen").Width = 100
         .RootTable.Columns("MontoPen").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoPen").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoPen").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("MontoPen").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("AnticipoId").Visible = False

         .RootTable.Columns("TipoAnticipoId").Visible = False

         .RootTable.Columns("AnticipoNro").Caption = "Número"
         .RootTable.Columns("AnticipoNro").Width = 100
         .RootTable.Columns("AnticipoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("AnticipoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("AnticipoNro").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("AnticipoNro").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("PedCompraId").Visible = False

         .RootTable.Columns("PedCompraNro").Caption = "Nro Pedido"
         .RootTable.Columns("PedCompraNro").Width = 100
         .RootTable.Columns("PedCompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PedCompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PedCompraNro").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("PedCompraNro").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox
         .RootTable.Columns("PedCompraNro").Visible = False

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MonedaDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("MonedaDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("MontoAnt").Caption = "Anticipo"
         .RootTable.Columns("MontoAnt").FormatString = DecimalMask()
         .RootTable.Columns("MontoAnt").Width = 100
         .RootTable.Columns("MontoAnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoAnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoAnt").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("MontoAnt").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("SinFac").Caption = "I"
         .RootTable.Columns("SinFac").Width = 50
         .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("SinFac").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("ConFac").Caption = "F"
         .RootTable.Columns("ConFac").Width = 50
         .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("ConFac").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         If clsAppInfo.CentroCostoApli Then
            .RootTable.Columns("CentroCostoId").Visible = False
            .RootTable.Columns("CentroCostoDes").Caption = "Centro Costo"
            .RootTable.Columns("CentroCostoDes").Width = 150
            .RootTable.Columns("CentroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CentroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("CentroCostoDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         Else
            .RootTable.Columns("CentroCostoId").Visible = False
            .RootTable.Columns("CentroCostoDes").Visible = False
         End If


         .RootTable.Columns("Monto").Caption = "Descargo"
         .RootTable.Columns("Monto").FormatString = DecimalMask()
         .RootTable.Columns("Monto").Width = 100
         .RootTable.Columns("Monto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Monto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdAnticipoCheck(ByVal boolValue As Boolean)

      Dim decMonto As Decimal = ToDouble(txtMontoPag.Text)

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdAnticipo.GetRows
         oRow.BeginEdit()

         If boolValue And decMonto > 0 Then
            oRow.IsChecked = True
            oRow.Cells("Monto").Value = oRow.Cells("MontoPen").Value
         Else
            oRow.IsChecked = False
            oRow.Cells("Monto").Value = 0
         End If

         oRow.EndEdit()
      Next

      Call MontoPagarAnticipo(ListPosition(cboMoneda, cboMoneda.SelectedIndex))

   End Sub

   Private Sub MontoPagarAnticipo(ByVal lngMonedaId As Long)
      Dim decMontoLiqBs As Decimal = 0
      Dim decMontoLiqUs As Decimal = 0

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdAnticipo.GetRows
         If ToDecimal(oRow.Cells("Monto").Value) > 0 Then
            If oRow.Cells("MonedaId").Value = 1 Then
               decMontoLiqBs += ToDouble(oRow.Cells("Monto").Value)

            ElseIf oRow.Cells("MonedaId").Value = 2 Then
               decMontoLiqUs += ToDouble(oRow.Cells("Monto").Value)
            End If
         End If
      Next

      mdecMontoPagAntBs = ToDecimal(decMontoLiqBs + (decMontoLiqUs * moPago.TipoCambio))
      mdecMontoPagAntUs = ToDecimal(decMontoLiqUs + (decMontoLiqBs / moPago.TipoCambio))

      If lngMonedaId = 1 Then
         txtMontoPag.Text = ToDecimal(mdecMontoPagBs + mdecMontoRecBs - mdecMontoDesBs)
         txtMontoAntPag.Text = mdecMontoPagAntBs
         txtMontoEfecPag.Text = ToDecimal(mdecMontoPagBs - mdecMontoPagAntBs + mdecMontoRecBs - mdecMontoDesBs)
      ElseIf lngMonedaId = 2 Then
         txtMontoPag.Text = ToDecimal(mdecMontoPagUs + mdecMontoRecUs - mdecMontoDesUs)
         txtMontoAntPag.Text = mdecMontoPagAntUs
         txtMontoEfecPag.Text = ToDecimal(mdecMontoPagUs - mdecMontoPagAntUs + mdecMontoRecUs - mdecMontoDesUs)
      End If

   End Sub


   Private Function AnticipoUpdate() As Boolean

      If ToDecimal(txtMontoAntPag.Text) > 0 Then

         Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
         Dim lngTipoCompId As Long
         Dim lngCompNro As Long
         Dim lngProveedorMovId As Long

         AnticipoUpdate = True

         Try
            Call isCompFind(moPago.CompId, lngTipoCompId, lngCompNro)
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdAnticipo.GetCheckedRows
               Dim lngAnticipoDetId As Long

               With oAnticipo
                  .AnticipoId = oRow.Cells("AnticipoId").Value

                  If .FindByPK Then
                     .Fecha = ToDate(.Fecha)
                     .MontoDes += ToDecimal(oRow.Cells("Monto").Value)

                     If .MontoAnt <= .MontoDes Then
                        .EstadoId = 14 'Realizado
                     Else
                        .EstadoId = 13 'Pendiente
                     End If

                     If .Update() Then
                        If AnticipoDetAdd(.AnticipoId, 7, moPago.PagoId, "Pago Nro. " & moPago.PagoNro, .MonedaId, ToDecimal(oRow.Cells("Monto").Value), lngTipoCompId, lngCompNro, moPago.PlanId, 11, lngAnticipoDetId) Then
                           If ProveedorMovAdd(lngProveedorMovId, 9, lngAnticipoDetId, 2, "Pago Nro. " & moPago.PagoNro, .MonedaId, ToDecimal(oRow.Cells("Monto").Value), 2, lngTipoCompId, lngCompNro, moPago.PlanId) Then
                              AnticipoUpdate = True
                           End If
                        End If
                     End If
                  End If
               End With
            Next

         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         Finally
            oAnticipo.Dispose()

         End Try
      Else
         AnticipoUpdate = True
      End If

   End Function

   Private Function AnticipoDetAdd(ByVal lngAnticipoId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal strDes As String, ByVal lngMonedaId As Long, ByVal decMonto As Decimal, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long, _
                                    ByVal lngEstadoId As Long, ByRef lngAnticipoDetId As Long) As Boolean

      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoDetAdd = False

      Try
         With oAnticipoDet
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .AnticipoId = lngAnticipoId
            .ProveedorId = moPago.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .Fecha = moPago.Fecha
            .AnticipoDetDes = strDes
            .MonedaId = lngMonedaId
            .TipoCambio = moPago.TipoCambio
            .Monto = decMonto
            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .PlanId = lngPlanId
            .EstadoId = lngEstadoId

            If .Insert() Then
               lngAnticipoDetId = .AnticipoDetId
               AnticipoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Sub grdAnticipo_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdAnticipo.UpdatingCell
      If ToStr(e.Column.DataMember) = "Monto" Then
         If ToDecimal(e.Value) = 0 Then
            e.Value = 0
            grdAnticipo.SetValue("Sel", False)

         ElseIf ToDecimal(e.Value) < 0 Then
            e.Cancel = True
            grdAnticipo.SetValue("Sel", False)
            MessageBox.Show("Monto Negativo Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         ElseIf ToDecimal(e.Value) > ToDecimal(grdAnticipo.GetValue("MontoPen")) Then
            e.Cancel = True
            grdAnticipo.SetValue("Sel", False)
            MessageBox.Show("Monto Superior al Importe Pendiente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         ElseIf ToLong(grdAnticipo.GetValue("PedCompraId")) > 0 Then
            e.Cancel = True
            grdAnticipo.SetValue("Sel", True)
            MessageBox.Show("El Anticipo esta Asociado al Pedido de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Else
            grdAnticipo.SetValue("Sel", True)
         End If
      End If
   End Sub

   Private Sub grdAnticipo_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdAnticipo.RowCheckStateChanged
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            Call grdAnticipoCheck(True)
         ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            Call grdAnticipoCheck(False)
         End If
      Else
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            grdAnticipo.SetValue("Monto", grdAnticipo.GetValue("MontoPen"))
         Else
            grdAnticipo.SetValue("Monto", 0)
         End If
         Call MontoPagarAnticipo(ListPosition(cboMoneda, cboMoneda.SelectedIndex))
      End If
   End Sub

   Private Sub grdAnticipo_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAnticipo.CellUpdated
      Call MontoPagarAnticipo(ListPosition(cboMoneda, cboMoneda.SelectedIndex))
   End Sub

   Private Sub grdAnticipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdAnticipo.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdAnticipo.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdAnticipo.GetRow.Cells(grdAnticipo.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub grdAnticipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdAnticipo.KeyPress
      If Not grdAnticipo.CurrentColumn Is Nothing Then
         If ToStr(grdAnticipo.RootTable.Columns(grdAnticipo.Col).DataMember) = "Monto" Then
            If mstrSepDecimal = "," Then
               If e.KeyChar = "." Then
                  e.Handled = True
                  SendKeys.Send(",")
               End If
            End If
         End If
      End If
   End Sub

#End Region

   Private Sub cboMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.SelectedIndexChanged
      Dim lngMonedaId As Long = ListPosition(cboMoneda, cboMoneda.SelectedIndex)

      If cboMoneda.Tag <> cboMoneda.Text Then
         cboMoneda.Tag = cboMoneda.Text
         Call txtMontoPagar()
      End If

   End Sub

   Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
      If Not IsNothing(moPago) Then
         If dtpFecha.Tag <> dtpFecha.Text Then
            If IsDate(dtpFecha.Text) Then
               Call txtUfvLoad(ToDate(dtpFecha.Value))
               dtpFecha.Tag = dtpFecha.Text
            Else
               mdecUfv = 0
            End If
         End If
      End If
   End Sub

   Private Sub txtMontoRec_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoRec.TextChanged

      If txtMontoRec.ContainsFocus Then

         Dim lngMonedaId As Long = ListPosition(cboMoneda, cboMoneda.SelectedIndex)

         If lngMonedaId <> 0 Then
            If lngMonedaId = 1 Then
               mdecMontoRecBs = ToDouble(txtMontoRec.Text)
               mdecMontoRecUs = ToDecimal(mdecMontoRecBs / moPago.TipoCambio)

               mdecMontoDesBs = ToDouble(txtMontoDes.Text)
               mdecMontoDesUs = ToDouble(mdecMontoDesBs / moPago.TipoCambio)
            ElseIf lngMonedaId = 2 Then
               mdecMontoRecUs = ToDouble(txtMontoRec.Text)
               mdecMontoRecBs = ToDouble(mdecMontoRecUs * moPago.TipoCambio)

               mdecMontoDesUs = ToDouble(txtMontoDes.Text)
               mdecMontoDesBs = ToDouble(mdecMontoDesUs * moPago.TipoCambio)
            End If

            Call MontoPagarAnticipo(lngMonedaId)
         End If
      End If
   End Sub

   Private Sub txtMontoDes_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoDes.TextChanged
      Dim lngMonedaId As Long = ListPosition(cboMoneda, cboMoneda.SelectedIndex)

      If txtMontoDes.ContainsFocus Then

         If lngMonedaId <> 0 Then
            If lngMonedaId = 1 Then
               mdecMontoRecBs = ToDouble(txtMontoRec.Text)
               mdecMontoRecUs = ToDouble(mdecMontoRecBs / moPago.TipoCambio)

               mdecMontoDesBs = ToDouble(txtMontoDes.Text)
               mdecMontoDesUs = ToDouble(mdecMontoDesBs / moPago.TipoCambio)
            ElseIf lngMonedaId = 2 Then
               mdecMontoRecUs = ToDouble(txtMontoRec.Text)
               mdecMontoRecBs = ToDouble(mdecMontoRecUs * moPago.TipoCambio)

               mdecMontoDesUs = ToDouble(txtMontoDes.Text)
               mdecMontoDesBs = ToDouble(mdecMontoDesUs * moPago.TipoCambio)
            End If

            Call MontoPagarAnticipo(lngMonedaId)
         End If
      End If
   End Sub

   Private Sub frmContadoPagoDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moPago.PagoId
                  mboolChanged = True

                  Call DataReadOnly()

                  If MessageBox.Show("Pago Realizado Exitosamente" + vbCrLf + "¿Desea Imprimir el Pago?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            PrintReportPago(moPago.TipoPagoId, moPago.PagoId, moPago.SucursalId, ToDecimalDos(txtMontoAntPag.Text), ToDecimalDos(txtCapital.Text))
                  Else
                     Me.Close()
                  End If
               End If

            End If

            ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
               Me.Close()
            End If
         End If
   End Sub

   Private Sub frmContadoPagoDetEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPago.Dispose()
      Call ClearMemory()
   End Sub

End Class
