Public Class frmCreditoAjusteEdit
   Inherits System.Windows.Forms.Form

   Private moAjuste As clsAjuste
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

   Private mdecCapitalBs As Decimal
   Private mdecInteresBs As Decimal
   Private mdecAmortizaBs As Decimal
   Private mdecMontoPagBs As Decimal
   Private mdecCapitalUs As Decimal
   Private mdecInteresUs As Decimal
   Private mdecAmortizaUs As Decimal
   Private mdecMontoPagUs As Decimal

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents chkSinFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Private mlngID As Long

   Property AjusteDataTable() As DataTable
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

   Property DataObject() As clsAjuste
      Get
         Return moAjuste
      End Get

      Set(ByVal Value As clsAjuste)
         moAjuste = Value
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
   Friend WithEvents grpDatos As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtProveedorId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents txtAjusteId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtMontoPag As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtCapital As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtInteres As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtAjusteDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditoAjusteEdit))
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
      Me.grpDatos = New Janus.Windows.EditControls.UIGroupBox
      Me.chkSinFac = New Janus.Windows.EditControls.UICheckBox
      Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtAjusteDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtInteres = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtCapital = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtMontoPag = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.lblCentroCosto = New System.Windows.Forms.Label
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label16 = New System.Windows.Forms.Label
      Me.txtProveedorId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtAjusteId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.lblSucursal = New System.Windows.Forms.Label
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpDatos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpDatos.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.SuspendLayout()
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
      Me.TopRebar1.Size = New System.Drawing.Size(462, 28)
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpDatos)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 327)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpDatos
      '
      Me.grpDatos.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpDatos.Controls.Add(Me.chkSinFac)
      Me.grpDatos.Controls.Add(Me.chkConFac)
      Me.grpDatos.Controls.Add(Me.Label9)
      Me.grpDatos.Controls.Add(Me.txtAjusteDes)
      Me.grpDatos.Controls.Add(Me.txtInteres)
      Me.grpDatos.Controls.Add(Me.Label8)
      Me.grpDatos.Controls.Add(Me.txtCapital)
      Me.grpDatos.Controls.Add(Me.Label4)
      Me.grpDatos.Controls.Add(Me.cboMoneda)
      Me.grpDatos.Controls.Add(Me.Label2)
      Me.grpDatos.Controls.Add(Me.txtMontoPag)
      Me.grpDatos.Controls.Add(Me.Label6)
      Me.grpDatos.Location = New System.Drawing.Point(8, 164)
      Me.grpDatos.Name = "grpDatos"
      Me.grpDatos.Size = New System.Drawing.Size(444, 156)
      Me.grpDatos.TabIndex = 6
      Me.grpDatos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
      Me.chkSinFac.Location = New System.Drawing.Point(8, 132)
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
      Me.chkConFac.Location = New System.Drawing.Point(60, 132)
      Me.chkConFac.Name = "chkConFac"
      Me.chkConFac.Size = New System.Drawing.Size(32, 16)
      Me.chkConFac.TabIndex = 278
      Me.chkConFac.Text = "F"
      Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 112)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 255
      Me.Label9.Text = "Descripción"
      '
      'txtAjusteDes
      '
      Me.txtAjusteDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtAjusteDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAjusteDes.Location = New System.Drawing.Point(116, 108)
      Me.txtAjusteDes.MaxLength = 255
      Me.txtAjusteDes.Multiline = True
      Me.txtAjusteDes.Name = "txtAjusteDes"
      Me.txtAjusteDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtAjusteDes.Size = New System.Drawing.Size(320, 40)
      Me.txtAjusteDes.TabIndex = 19
      Me.txtAjusteDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAjusteDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtInteres
      '
      Me.txtInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtInteres.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtInteres.FormatString = "##,##0.000"
      Me.txtInteres.Location = New System.Drawing.Point(116, 60)
      Me.txtInteres.Name = "txtInteres"
      Me.txtInteres.ReadOnly = True
      Me.txtInteres.Size = New System.Drawing.Size(124, 20)
      Me.txtInteres.TabIndex = 9
      Me.txtInteres.Text = "0,000"
      Me.txtInteres.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtInteres.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtInteres.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 64)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 254
      Me.Label8.Text = "Interés"
      '
      'txtCapital
      '
      Me.txtCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCapital.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCapital.FormatString = "##,##0.000"
      Me.txtCapital.Location = New System.Drawing.Point(116, 36)
      Me.txtCapital.Name = "txtCapital"
      Me.txtCapital.ReadOnly = True
      Me.txtCapital.Size = New System.Drawing.Size(124, 20)
      Me.txtCapital.TabIndex = 8
      Me.txtCapital.Text = "0,000"
      Me.txtCapital.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCapital.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCapital.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 40)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 252
      Me.Label4.Text = "Capital"
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
      Me.txtMontoPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPag.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPag.FormatString = "##,##0.000"
      Me.txtMontoPag.Location = New System.Drawing.Point(116, 84)
      Me.txtMontoPag.Name = "txtMontoPag"
      Me.txtMontoPag.ReadOnly = True
      Me.txtMontoPag.Size = New System.Drawing.Size(124, 20)
      Me.txtMontoPag.TabIndex = 11
      Me.txtMontoPag.Text = "0,000"
      Me.txtMontoPag.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPag.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPag.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 88)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 230
      Me.Label6.Text = "Monto a Pagar"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboSucursal)
      Me.grpMain.Controls.Add(Me.lblSucursal)
      Me.grpMain.Controls.Add(Me.lblCentroCosto)
      Me.grpMain.Controls.Add(Me.cboCentroCosto)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.txtProveedorId)
      Me.grpMain.Controls.Add(Me.txtAjusteId)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 164)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCentroCosto.Location = New System.Drawing.Point(8, 140)
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Size = New System.Drawing.Size(104, 15)
      Me.lblCentroCosto.TabIndex = 264
      Me.lblCentroCosto.Text = "Centro de Costo"
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(116, 136)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCosto.TabIndex = 263
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
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
      Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
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
      Me.txtProveedorId.Size = New System.Drawing.Size(320, 20)
      Me.txtProveedorId.TabIndex = 2
      Me.txtProveedorId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtProveedorId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtAjusteId
      '
      Me.txtAjusteId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAjusteId.Location = New System.Drawing.Point(116, 16)
      Me.txtAjusteId.Name = "txtAjusteId"
      Me.txtAjusteId.ReadOnly = True
      Me.txtAjusteId.Size = New System.Drawing.Size(124, 20)
      Me.txtAjusteId.TabIndex = 1
      Me.txtAjusteId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAjusteId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      'cboSucursal
      '
      Me.cboSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboSucursal.BackColor = System.Drawing.SystemColors.Info
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(116, 112)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(320, 20)
      Me.cboSucursal.TabIndex = 282
      Me.cboSucursal.TabStop = False
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblSucursal
      '
      Me.lblSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
      Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSucursal.Location = New System.Drawing.Point(8, 116)
      Me.lblSucursal.Name = "lblSucursal"
      Me.lblSucursal.Size = New System.Drawing.Size(104, 16)
      Me.lblSucursal.TabIndex = 283
      Me.lblSucursal.Text = "Sucursal"
      '
      'frmCreditoAjusteEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 355)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCreditoAjusteEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "frmCreditoAjuste Edit"
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpDatos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpDatos.ResumeLayout(False)
      Me.grpDatos.PerformLayout()
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
               mlngID = moAjuste.AjusteId
               mboolChanged = True
               Call DataReadOnly()

               If MessageBox.Show("Ajuste Realizado Exitosamente" + vbCrLf + "¿Desea Imprimir el Ajuste?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call PrintReport()
               Else
                  Me.Close()
               End If

               'Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCreditoAjusteEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCreditoAjusteEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Ajuste de Notas al Crédito"
         Else
            Me.Text = "Editar Ajuste de Notas al Crédito"
         End If
      Else
         Me.Text = "Nuevo Ajuste de Notas al Crédito"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moAjuste
         txtAjusteId.Text = ToStr(.AjusteId)
         Call txtProveedorIdLoad(.ProveedorId)
         dtpFecha.Text = ToStr(.Fecha)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtCapital.Text = ToDecStr(.Capital)
         txtInteres.Text = ToDecStr(.Interes)
         txtMontoPag.Text = ToDecStr(.MontoPag)
         txtAjusteDes.Text = ToStr(.AjusteDes)
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
      With moAjuste
         txtAjusteId.Text = String.Empty
         Call txtProveedorIdLoad(.ProveedorId)
         dtpFecha.Text = .Fecha
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtAjusteDes.Text = String.Empty

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

         cboCentroCosto.SelectedIndex = -1
         If clsAppInfo.CentroCostoApli Then
            cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
            cboCentroCosto.ReadOnly = True
         End If

         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)
         cboSucursal.ReadOnly = True

      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtAjusteId.ReadOnly = True
      txtProveedorId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtCapital.ReadOnly = True
      txtInteres.ReadOnly = True
      txtMontoPag.ReadOnly = True
      txtAjusteDes.ReadOnly = True
      'chkConFac.Enabled = False
      'chkSinFac.Enabled = False
      cboCentroCosto.ReadOnly = True
      cboSucursal.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub ViewComponent()
      Dim decPosSuc As Decimal = 0
      Dim decPosCC As Decimal = 0

      If clsAppInfo.SucursalApli Then
         lblSucursal.Visible = True
         cboSucursal.Visible = True
      Else
         lblSucursal.Visible = False
         cboSucursal.Visible = False
         decPosSuc = 24
      End If

      If clsAppInfo.CentroCostoApli Then
         lblCentroCosto.Visible = True
         cboCentroCosto.Visible = True

         lblCentroCosto.Location = New System.Drawing.Point(lblCentroCosto.Location.X, lblCentroCosto.Location.Y - decPosSuc)
         cboCentroCosto.Location = New System.Drawing.Point(cboCentroCosto.Location.X, cboCentroCosto.Location.Y - decPosSuc)

      Else
         lblCentroCosto.Visible = False
         cboCentroCosto.Visible = False
         decPosCC = 24

         'Me.Size = New System.Drawing.Size(468, 354)
         'grpMain.Size = New System.Drawing.Size(444, 136)

         'grpDatos.Location = New System.Drawing.Point(8, 136)

      End If

      Me.Size = New System.Drawing.Point(Me.Size.Width, Me.Size.Height - decPosSuc - decPosCC)
      grpMain.Size = New System.Drawing.Size(grpMain.Width, grpMain.Height - decPosSuc - decPosCC)
      grpDatos.Location = New System.Drawing.Point(grpDatos.Location.X, grpDatos.Location.Y - decPosSuc - decPosCC)

   End Sub


   Private Sub DataMove()
      With moAjuste
         If Not mboolAdding Then
            .AjusteId = ToLong(txtAjusteId.Text)
         End If

         .Fecha = ToDate(dtpFecha.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .Capital = ToDecimal(txtCapital.Text)
         .Interes = ToDecimal(txtInteres.Text)
         .MontoPag = ToDecimal(txtMontoPag.Text)
         .AjusteDes = ToStr(txtAjusteDes.Text)
         .ConFac = ToBoolean(chkConFac.Checked)
         .SinFac = ToBoolean(chkSinFac.Checked)
         .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
         .EstadoId = 11
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
         Call DataMove()

         If FormCheck() Then
            If mboolAdding Then
               If clsAppInfo.Inventario Then 'Adicion Integrado a Contabilidad
                  If frmCompPlanFill() Then
                     moAjuste.AjusteNro = CompraNroNext(10, clsAppInfo.GestionId, moAjuste.SucursalId)

                     If DataAdd() Then
                        If grdMainSave() Then
                           If mboolTieneComp Then
                              If CompNew(lngCompId, lngTipoCompId, lngCompNro) Then
                                 If ProveedorMovAdd(ProveedorMovId, 10, moAjuste.AjusteId, 2, moAjuste.Capital, 1, lngTipoCompId, lngCompNro, mlngPlanId) Then
                                    moAjuste.CompId = lngCompId
                                    moAjuste.PlanId = mlngPlanId 'Cuenta Variable

                                    If DataUpdate() Then
                                       DataSave = True
                                    End If
                                 End If
                              End If

                           Else
                              If ProveedorMovAdd(ProveedorMovId, 10, moAjuste.AjusteId, 2, moAjuste.Capital, 1, 0, 0, 0) Then
                                 DataSave = True
                              End If
                           End If
                        End If
                     End If
                  End If

               Else
                  moAjuste.AjusteNro = CompraNroNext(10, clsAppInfo.GestionId, moAjuste.SucursalId)

                  If DataAdd() Then
                     If grdMainSave() Then
                        If ProveedorMovAdd(ProveedorMovId, 10, moAjuste.AjusteId, 2, moAjuste.Capital, 1, 0, 0, 0) Then
                           DataSave = True
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

         If moAjuste.Insert() Then
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

         If moAjuste.Update() Then
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

      If ToDecimal(txtTipoCambio.Text) <= 0 Then
         strMsg &= "Tipo de Cambio Inválido" & vbCrLf
      End If

      If moAjuste.MonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If moAjuste.TipoCambio <= 0 Then
         strMsg &= "Monto a Pagar Inválido" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
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

      Dim decMontoOrg As Decimal
      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0

      CompNew = True

      Try
         lngTipoCompId = 3 'Traspaso
         lngPlanIdPas = PlanIdPasFind(moAjuste.ProveedorId, lngPlanAddIdPas, lngPlanIdInt, lngPlanAddIdInt)

         If CompAdd(lngTipoCompId, lngCompNro, lngCompId, mdecCapitalBs + mdecInteresBs, mdecCapitalUs + mdecInteresUs) Then 'Cabecera Comprobante
            'Capital
            If moAjuste.MonedaId = 1 Then
               decMontoOrg = mdecCapitalBs

            ElseIf moAjuste.MonedaId = 2 Then
               decMontoOrg = mdecCapitalUs
            End If

            If (mdecCapitalBs > 0) And (mdecCapitalUs > 0) Then
               If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdPas, "", mdecCapitalBs, mdecCapitalUs, decMontoOrg, 1, moAjuste.SucursalId, moAjuste.CentroCostoId, lngCompDetId) Then
                  If lngPlanAddIdPas <> 0 Then  'Analitico Adicional
                     If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdPas, lngPlanAddIdPas, mdecCapitalBs, mdecCapitalUs, 1, moAjuste.SucursalId) Then
                        CompNew = True
                     End If
                  End If
               End If
            End If

            'Interes
            If (mdecInteresBs > 0) And (mdecInteresUs > 0) Then
               If moAjuste.MonedaId = 1 Then
                  decMontoOrg = mdecInteresBs

               ElseIf moAjuste.MonedaId = 2 Then
                  decMontoOrg = mdecInteresUs
               End If

               If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdInt, "", mdecInteresBs, mdecInteresUs, decMontoOrg, 1, moAjuste.SucursalId, moAjuste.CentroCostoId, lngCompDetId) Then
                  If lngPlanAddIdInt <> 0 Then  'Analitico Adicional
                     If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdInt, lngPlanAddIdInt, mdecInteresBs, mdecInteresUs, 1, moAjuste.SucursalId) Then
                        CompNew = True
                     End If
                  End If
               End If
            End If

            'Monto Pagado
            If (mdecMontoPagBs > 0) And (mdecMontoPagUs > 0) Then
               If moAjuste.MonedaId = 1 Then
                  decMontoOrg = mdecMontoPagBs

               ElseIf moAjuste.MonedaId = 2 Then
                  decMontoOrg = mdecMontoPagUs
               End If

               If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", mdecMontoPagBs, mdecMontoPagUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                  If mlngPlanAddId <> 0 Then  'Analitico Adicional
                     If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, mdecMontoPagBs, mdecMontoPagUs, 2, moAjuste.SucursalId) Then
                        CompNew = True
                     End If
                  End If

                  If mlngCentroCostoDetId <> 0 Then  'Actividad
                     If CompCentroCostoDetAdd(lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, mdecMontoPagBs, mdecMontoPagUs, 2, moAjuste.SucursalId) Then
                        CompNew = True
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

   Private Function CompAdd(ByVal lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long, ByVal decTotalBs As Decimal, ByVal decTotalUs As Decimal) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = moAjuste.EmpresaId
            .GestionId = moAjuste.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = CompNroNext(.TipoCompId, moAjuste.GestionId, moAjuste.SucursalId)
            .Fecha = moAjuste.Fecha
            .MonedaId = moAjuste.MonedaId
            .TipoCambio = moAjuste.TipoCambio
            .EntregadoA = ToStr(txtProveedorId.Text)
            .PorConcepto = "Ajuste Nro. " & ToStr(moAjuste.AjusteNro) + "; " + ToStr(txtAjusteDes.Text)
            .DebeBs = decTotalBs
            .HaberBs = decTotalBs
            .DebeUs = decTotalUs
            .HaberUs = decTotalUs
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF
            .ConFac = 0
            .Automatico = 0
            .Glosa = ""
            '.TipoNotaId = 0
            '.NotaNro = 0
            .TipoAsientoId = 0
            .EstadoId = 10
            .ConFac = moAjuste.ConFac
            .SinFac = moAjuste.SinFac
            .SucursalId = moAjuste.SucursalId
            .NotaId = 0
            .AppId = clsAppInfo.AppId
            .TipoDocumentoId = clsTipoCompra.AJUSTE
            .DocumentoId = moAjuste.AjusteId

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
            .EmpresaId = moAjuste.EmpresaId
            .GestionId = moAjuste.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = moAjuste.Fecha
            .PlanId = lngPlanId
            .CompDetDes = "Ajuste Nro. " & ToStr(moAjuste.AjusteNro) & "; " & ToStr(txtAjusteDes.Text)
            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId
            .MonedaId = moAjuste.MonedaId

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
            .EmpresaId = moAjuste.EmpresaId
            .GestionId = moAjuste.GestionId
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

   Private Function CompFind(ByRef lngTipoCompId As Long, ByRef lngCompNro As Long, ByVal lngSucursalId As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompFind = False

      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.All
            .WhereFilter = clsComp.WhereFilters.CompNro
            .EmpresaId = moAjuste.EmpresaId
            .GestionId = moAjuste.GestionId
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
            .EmpresaId = moAjuste.EmpresaId
            .GestionId = moAjuste.GestionId
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
            .EmpresaId = moAjuste.EmpresaId
            .GestionId = moAjuste.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moAjuste.Fecha
            .PlanId = lngPlanId
            .MonedaId = moAjuste.MonedaId
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
            .EmpresaId = moAjuste.EmpresaId
            .GestionId = moAjuste.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moAjuste.Fecha
            .PlanId = lngPlanId
            .MonedaId = moAjuste.MonedaId
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

   Private Function ProveedorMovAdd(ByRef lngProveedorMovId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal lngTipoPagoId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moAjuste.EmpresaId
            .GestionId = moAjuste.GestionId
            .ProveedorId = moAjuste.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moAjuste.Fecha
            .ProveedorMovDes = moAjuste.AjusteDes
            .MonedaId = moAjuste.MonedaId
            .TipoCambio = moAjuste.TipoCambio
            .CentroCostoId = moAjuste.CentroCostoId
            .SucursalId = moAjuste.SucursalId
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
            .EmpresaId = moAjuste.EmpresaId
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
            .EmpresaId = moAjuste.EmpresaId
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
            .EmpresaId = moAjuste.EmpresaId
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

   Private Function frmCompPlanFill() As Boolean
      Dim frm As New frmCompPlan

      frmCompPlanFill = False

      mlngPlanId = 0
      mlngPlanAddId = 0
      mlngSucursalId = 0
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
      mlngTipoPlanId = 0

      If clsAppInfo.SucursalApli Then
         mlngSucursalId = moAjuste.SucursalId
      End If

      With frm
         .EmpresaId = moAjuste.EmpresaId
         .PlanWhereFilter = clsPlan.WhereFilters.EsAna
         .CentroCostoId = moAjuste.CentroCostoId
         .SucursalId = moAjuste.SucursalId
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

   Private Sub FormInit()
      Call FormCenter(Me)

      txtTipoCambio.FormatString = DecimalMask()
      txtCapital.FormatString = DecimalMask()
      txtInteres.FormatString = DecimalMask()
      txtMontoPag.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
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
            .CentroCostoId = moAjuste.CentroCostoId

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
            .TipoCompraId = clsTipoCompra.AJUSTE

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

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraNroNext = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moAjuste.EmpresaId
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

   Private Sub MontoPagar(ByVal lngMonedaId As Long)
      Dim oRow As DataRow
      Dim decCapitalBs As Decimal = 0
      Dim decInteresBs As Decimal = 0
      Dim decAmortizaBs As Decimal = 0
      Dim decCapitalUs As Decimal = 0
      Dim decInteresUs As Decimal = 0
      Dim decAmortizaUs As Decimal = 0

      For Each oRow In moDataTable.Rows
         If ToDecimal(oRow("Amortiza")) > 0 Then
            If oRow("MonedaId") = 1 Then
               decAmortizaBs += ToDecimal(oRow("Amortiza"))

               If ToDecimal(oRow("Amortiza")) > oRow("Interes") Then
                  decInteresBs += oRow("Interes")
                  decCapitalBs += ToDecimal(oRow("Amortiza")) - oRow("Interes")
               Else
                  decInteresBs += ToDecimal(oRow("Amortiza"))
                  decCapitalBs += 0
               End If

            ElseIf oRow("MonedaId") = 2 Then
               decAmortizaUs += ToDecimal(oRow("Amortiza"))

               If ToDecimal(oRow("Amortiza")) > oRow("Interes") Then
                  decInteresUs += oRow("Interes")
                  decCapitalUs += ToDecimal(oRow("Amortiza")) - oRow("Interes")
               Else
                  decInteresUs += ToDecimal(oRow("Amortiza"))
                  decCapitalUs += 0
               End If
            End If
         End If
      Next

      mdecCapitalBs = ToDecimal(decCapitalBs + (decCapitalUs * ToDecimal(txtTipoCambio.Text)))
      mdecInteresBs = ToDecimal(decInteresBs + (decInteresUs * ToDecimal(txtTipoCambio.Text)))
      mdecAmortizaBs = ToDecimal(decAmortizaBs + (decAmortizaUs * ToDecimal(txtTipoCambio.Text)))
      mdecMontoPagBs = mdecAmortizaBs

      mdecCapitalUs = ToDecimal(decCapitalUs + (decCapitalBs / ToDecimal(txtTipoCambio.Text)))
      mdecInteresUs = ToDecimal(decInteresUs + (decInteresBs / ToDecimal(txtTipoCambio.Text)))
      mdecAmortizaUs = ToDecimal(decAmortizaUs + (decAmortizaBs / ToDecimal(txtTipoCambio.Text)))
      mdecMontoPagUs = mdecAmortizaUs

      If lngMonedaId = 1 Then
         txtCapital.Text = mdecCapitalBs
         txtInteres.Text = mdecInteresBs
         txtMontoPag.Text = mdecMontoPagBs
      Else
         txtCapital.Text = mdecCapitalUs
         txtInteres.Text = mdecInteresUs
         txtMontoPag.Text = mdecMontoPagUs
      End If
   End Sub

   Private Function grdMainSave() As Boolean
      Dim oRow As DataRow
      Dim decCapitalCre As Decimal = 0
      Dim decInteresCre As Decimal = 0
      Dim decInteresAct As Decimal = 0
      Dim decCapitalPag As Decimal = 0
      Dim decInteresPag As Decimal = 0

      grdMainSave = True

      Try
         For Each oRow In moDataTable.Rows
            decInteresCre = 0
            decCapitalCre = 0
            decInteresPag = 0
            decCapitalPag = 0

            If ToDecimal(oRow("Amortiza")) > 0 Then
               If ToDecimal(oRow("Amortiza")) > oRow("Interes") Then
                  decInteresCre = oRow("Interes")
                  decCapitalCre = ToDecimal(oRow("Amortiza") - oRow("Interes"))
                  decInteresAct = oRow("Interes")
               Else
                  decInteresCre = oRow("Amortiza")
                  decCapitalCre = 0
                  decInteresAct = oRow("Interes")
               End If

               If oRow("MonedaId") = 1 Then
                  If moAjuste.MonedaId = 1 Then
                     decInteresPag = decInteresCre
                     decCapitalPag = decCapitalCre
                  Else
                     decInteresPag = ToDecimal(decInteresCre / ToDecimal(txtTipoCambio.Text))
                     decCapitalPag = ToDecimal(decCapitalCre / ToDecimal(txtTipoCambio.Text))
                  End If

               ElseIf oRow("MonedaId") = 2 Then
                  If moAjuste.MonedaId = 1 Then
                     decInteresPag = ToDecimal(decInteresCre * ToDecimal(txtTipoCambio.Text))
                     decCapitalPag = ToDecimal(decCapitalCre * ToDecimal(txtTipoCambio.Text))
                  Else
                     decInteresPag = decInteresCre
                     decCapitalPag = decCapitalCre
                  End If
               End If
            End If

            If (decCapitalCre > 0) Or (decInteresCre > 0) Then
               If AjusteDetAdd(oRow, decCapitalCre, decInteresCre, decCapitalPag, decInteresPag, decInteresAct) Then
                  grdMainSave = True
               End If
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function AjusteDetAdd(ByVal oRow As DataRow, ByVal decCapitalCre As Decimal, ByVal decInteresCre As Decimal, ByVal decCapitalPag As Decimal, ByVal decInteresPag As Decimal, ByVal decInteresAct As Decimal) As Boolean
      Dim oAjusteDet As New clsAjusteDet(clsAppInfo.ConnectString)
      Dim decCapitalOrg As Decimal
      Dim decInteresOrg As Decimal

      AjusteDetAdd = False

      Try
         With oAjusteDet
            If CreditoDetUpdate(ToLong(oRow("CreditoDetId")), decCapitalCre, decInteresCre, decInteresAct, decCapitalOrg, decInteresOrg, ToDate(dtpFecha.Value)) Then
               .EmpresaId = moAjuste.EmpresaId
               .GestionId = moAjuste.GestionId
               .AjusteId = moAjuste.AjusteId
               .CompraId = ToLong(oRow("CompraId"))
               .CreditoId = ToLong(oRow("CreditoId"))
               .CreditoDetId = ToLong(oRow("CreditoDetId"))
               .ProveedorId = moAjuste.ProveedorId
               .Fecha = ToDate(dtpFecha.Value)
               .MonedaId = moAjuste.MonedaId
               .TipoCambio = moAjuste.TipoCambio
               .CentroCostoId = moAjuste.CentroCostoId
               .SucursalId = moAjuste.SucursalId
               .CapitalOrg = decCapitalPag
               .InteresOrg = decInteresPag
               .ImporteOrg = decCapitalPag + decInteresPag
               .EstadoId = 14

               If .Insert() Then
                  If CreditoUpdate(ToLong(oRow("CreditoId")), decCapitalCre) Then
                     AjusteDetAdd = True
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAjusteDet.Dispose()

      End Try
   End Function

   Private Function CreditoUpdate(ByVal lngCreditoId As Long, ByVal decCapital As Decimal) As Boolean
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      CreditoUpdate = False

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               .FechaIni = ToDate(.FechaIni)
               .FechaFin = ToDate(.FechaFin)

               .MontoAmo += decCapital

               If .MontoLiq <= .MontoAmo Then
                  .EstadoId = 14 'Realizado
               Else
                  .EstadoId = 15 'Programado
               End If

               If .Update() Then
                  If .EstadoId = 14 Then
                     If CompraUpdate(lngCreditoId, 14) Then 'Estado Realizado
                        CreditoUpdate = True
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

   Private Function CreditoDetUpdate(ByVal lngCreditoDetId As Long, ByVal decCapital As Decimal, ByVal decInteres As Decimal, ByVal decInteresAct As Decimal, ByRef decCapitalOrg As Decimal, ByRef decInteresOrg As Decimal, ByVal strFechaAmo As String) As Boolean
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)

      CreditoDetUpdate = False

      Try
         With oCreditoDet
            .CreditoDetId = lngCreditoDetId

            If .FindByPK Then
               decCapitalOrg = .Capital - .CapitalAmo

               If .InteresAmo < .Interes Then
                  decInteresOrg = .Interes - .InteresAmo
               Else
                  decInteresOrg = 0
               End If

               If decInteres < decInteresAct Then 'Interes Pendiente de Pago
                  .InteresPen = decInteresAct - decInteres
               Else
                  .InteresPen = 0
               End If

               .Fecha = ToDate(.Fecha)
               .FechaAmo = strFechaAmo

               .CapitalAmo += decCapital
               .InteresAmo += decInteres

               If .Capital <= .CapitalAmo Then
                  .EstadoId = 14

                  Call CreditoDetSiguienteUpdate(.CreditoId, .CuotaNro + 1, strFechaAmo)
               Else
                  .EstadoId = 15
               End If

               If .Update() Then
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

   Private Function CreditoDetSiguienteUpdate(ByVal lngCreditoId As Long, ByVal lngCuotaNro As Long, ByVal strFechaAmo As String) As Boolean
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)

      CreditoDetSiguienteUpdate = False

      Try
         With oCreditoDet
            .SelectFilter = clsCreditoDet.SelectFilters.All
            .WhereFilter = clsCreditoDet.WhereFilters.CuotaNro
            .EmpresaId = moAjuste.EmpresaId
            .CreditoId = lngCreditoId
            .CuotaNro = lngCuotaNro

            If .Find Then
               .Fecha = ToDate(.Fecha)
               .FechaAmo = strFechaAmo

               If .Update() Then
                  CreditoDetSiguienteUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCreditoDet.Dispose()

      End Try
   End Function

   Private Function CompraUpdate(ByVal lngCreditoId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      CompraUpdate = False

      Try
         With oCompra
            .SelectFilter = clsCompra.SelectFilters.All
            .WhereFilter = clsCompra.WhereFilters.CreditoId
            .EmpresaId = moAjuste.EmpresaId
            .CreditoId = lngCreditoId

            If .Open() Then
               Do While .Read()
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update() Then
                     If CompraDetUpdate(.CompraId, lngEstadoId) Then
                        CompraUpdate = True
                     End If
                  End If

                  .MoveNext()
               Loop
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
            .EmpresaId = moAjuste.EmpresaId
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

   Private Sub PrintReport()
      Dim rpt As New rptAjusteEdit
      Dim oAjuste As New clsAjuste(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim strTitulo As String

      Try
         oAjuste.SelectFilter = clsAjuste.SelectFilters.Report
         oAjuste.WhereFilter = clsAjuste.WhereFilters.Report
         oAjuste.OrderByFilter = clsAjuste.OrderByFilters.Report
         oAjuste.EmpresaId = moAjuste.EmpresaId
         oAjuste.AjusteId = moAjuste.AjusteId

         If oAjuste.Find Then
            rpt.DataSource = oAjuste.DataSet.Tables(oAjuste.TableName).DefaultView

            rpt.txtFirma.Text = CompraParaFirma(10, moAjuste.GestionId, moAjuste.SucursalId, strTitulo, lngTipoHojaId)
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
         oAjuste.Dispose()

      End Try
   End Sub

   Private Function CompraParaFirma(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByRef strTitulo As String, ByRef lngTipoHojaId As Long) As String
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaFirma = ""

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moAjuste.EmpresaId
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

   Private Sub cboMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.SelectedIndexChanged
      If cboMoneda.Tag <> cboMoneda.Text Then
         cboMoneda.Tag = cboMoneda.Text

         Call MontoPagar(ListPosition(cboMoneda, cboMoneda.SelectedIndex))
      End If
   End Sub

   Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
      If Not mboolLoading Then
         If Not IsNothing(moAjuste) Then
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

   Private Sub frmCreditoAjusteEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moAjuste.AjusteId
               mboolChanged = True
               Call DataReadOnly()

               If MessageBox.Show("Ajuste Realizado Exitosamente" + vbCrLf + "¿Desea Imprimir el Ajuste?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call PrintReport()
               Else
                  Me.Close()
               End If

               'Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCreditoAjusteEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moAjuste.Dispose()
      Call ClearMemory()
   End Sub

End Class
