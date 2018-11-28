Public Class frmFacturaDifEdit
   Inherits System.Windows.Forms.Form

   Private moCompra As clsCompra
   Private mlngEmpresaId As Long
   Private mboolChanged As Boolean

   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngTipoPlanId As Long
   Private mboolTieneComp As Boolean

   Private mboolFacFechaMenor As Boolean

   Private mlngID As Long

   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtMontoPagUs As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents FacNoValida As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents txtImporteUs As Janus.Windows.GridEX.EditControls.NumericEditBox

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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaDifEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Label2 = New System.Windows.Forms.Label
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.FacNoValida = New Janus.Windows.UI.CommandBars.UICommand("FacNoValida")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Label8 = New System.Windows.Forms.Label
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtMontoPagUs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtImporteUs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtMontoPagBs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtImporteBs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label16 = New System.Windows.Forms.Label
      Me.txtProveedorDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(710, 283)
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
      Me.grdMain.Size = New System.Drawing.Size(710, 283)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Save1
      '
      Me.Save1.ImageIndex = 9
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      Me.Save1.Text = "Facturar"
      '
      'Label2
      '
      Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(834, 20)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(88, 16)
      Me.Label2.TabIndex = 200
      Me.Label2.Text = "Total Importe"
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Print1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(231, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Print, Me.FacNoValida})
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
      'FacNoValida
      '
      Me.FacNoValida.Key = "FacNoValida"
      Me.FacNoValida.Name = "FacNoValida"
      Me.FacNoValida.Text = "Factura No Válida"
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
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Label8
      '
      Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(488, 16)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(130, 16)
      Me.Label8.TabIndex = 251
      Me.Label8.Text = "Monto a  Facturar Bs"
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox3)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(742, 438)
      Me.bcgMain.TabIndex = 165
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
      ExplorerBarGroup1.ContainerHeight = 284
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(8, 48)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(726, 316)
      Me.ebrMain.TabIndex = 7
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.Label1)
      Me.UiGroupBox3.Controls.Add(Me.txtMontoPagUs)
      Me.UiGroupBox3.Controls.Add(Me.Label5)
      Me.UiGroupBox3.Controls.Add(Me.txtImporteUs)
      Me.UiGroupBox3.Controls.Add(Me.Label8)
      Me.UiGroupBox3.Controls.Add(Me.txtMontoPagBs)
      Me.UiGroupBox3.Controls.Add(Me.Label18)
      Me.UiGroupBox3.Controls.Add(Me.txtImporteBs)
      Me.UiGroupBox3.Controls.Add(Me.Label3)
      Me.UiGroupBox3.Controls.Add(Me.Label2)
      Me.UiGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(8, 364)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(726, 64)
      Me.UiGroupBox3.TabIndex = 6
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(488, 40)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(130, 16)
      Me.Label1.TabIndex = 255
      Me.Label1.Text = "Monto a  Facturar Us"
      '
      'txtMontoPagUs
      '
      Me.txtMontoPagUs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoPagUs.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoPagUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPagUs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPagUs.FormatString = "##,##0.000"
      Me.txtMontoPagUs.Location = New System.Drawing.Point(618, 36)
      Me.txtMontoPagUs.Name = "txtMontoPagUs"
      Me.txtMontoPagUs.ReadOnly = True
      Me.txtMontoPagUs.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoPagUs.TabIndex = 253
      Me.txtMontoPagUs.Text = "0,000"
      Me.txtMontoPagUs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPagUs.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPagUs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(272, 40)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(98, 16)
      Me.Label5.TabIndex = 254
      Me.Label5.Text = "Monto Total Us"
      '
      'txtImporteUs
      '
      Me.txtImporteUs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtImporteUs.BackColor = System.Drawing.SystemColors.Info
      Me.txtImporteUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtImporteUs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporteUs.FormatString = "##,##0.000"
      Me.txtImporteUs.Location = New System.Drawing.Point(374, 36)
      Me.txtImporteUs.Name = "txtImporteUs"
      Me.txtImporteUs.ReadOnly = True
      Me.txtImporteUs.Size = New System.Drawing.Size(100, 20)
      Me.txtImporteUs.TabIndex = 252
      Me.txtImporteUs.Text = "0,000"
      Me.txtImporteUs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporteUs.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporteUs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMontoPagBs
      '
      Me.txtMontoPagBs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoPagBs.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoPagBs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPagBs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPagBs.FormatString = "##,##0.000"
      Me.txtMontoPagBs.Location = New System.Drawing.Point(618, 12)
      Me.txtMontoPagBs.Name = "txtMontoPagBs"
      Me.txtMontoPagBs.ReadOnly = True
      Me.txtMontoPagBs.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoPagBs.TabIndex = 10
      Me.txtMontoPagBs.Text = "0,000"
      Me.txtMontoPagBs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPagBs.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPagBs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label18
      '
      Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(272, 16)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(98, 16)
      Me.Label18.TabIndex = 243
      Me.Label18.Text = "Monto Total Bs"
      '
      'txtImporteBs
      '
      Me.txtImporteBs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtImporteBs.BackColor = System.Drawing.SystemColors.Info
      Me.txtImporteBs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtImporteBs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporteBs.FormatString = "##,##0.000"
      Me.txtImporteBs.Location = New System.Drawing.Point(374, 12)
      Me.txtImporteBs.Name = "txtImporteBs"
      Me.txtImporteBs.ReadOnly = True
      Me.txtImporteBs.Size = New System.Drawing.Size(100, 20)
      Me.txtImporteBs.TabIndex = 9
      Me.txtImporteBs.Text = "0,000"
      Me.txtImporteBs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporteBs.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporteBs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(834, 44)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(88, 16)
      Me.Label3.TabIndex = 202
      Me.Label3.Text = "Cantidad Items"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtTipoCambio)
      Me.UiGroupBox1.Controls.Add(Me.Label11)
      Me.UiGroupBox1.Controls.Add(Me.dtpFecha)
      Me.UiGroupBox1.Controls.Add(Me.Label16)
      Me.UiGroupBox1.Controls.Add(Me.txtProveedorDes)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 4)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(726, 40)
      Me.UiGroupBox1.TabIndex = 0
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(620, 10)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
      Me.txtTipoCambio.TabIndex = 255
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label11
      '
      Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label11.Location = New System.Drawing.Point(540, 14)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(76, 16)
      Me.Label11.TabIndex = 257
      Me.Label11.Text = "Tipo Cambio"
      '
      'dtpFecha
      '
      Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFecha.DropDownCalendar.Name = ""
      Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dtpFecha.Location = New System.Drawing.Point(424, 10)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
      Me.dtpFecha.TabIndex = 254
      Me.dtpFecha.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label16
      '
      Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label16.Location = New System.Drawing.Point(376, 14)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(44, 16)
      Me.Label16.TabIndex = 256
      Me.Label16.Text = "Fecha"
      '
      'txtProveedorDes
      '
      Me.txtProveedorDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtProveedorDes.BackColor = System.Drawing.SystemColors.Info
      Me.txtProveedorDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtProveedorDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtProveedorDes.Location = New System.Drawing.Point(72, 12)
      Me.txtProveedorDes.Name = "txtProveedorDes"
      Me.txtProveedorDes.ReadOnly = True
      Me.txtProveedorDes.Size = New System.Drawing.Size(292, 20)
      Me.txtProveedorDes.TabIndex = 1
      Me.txtProveedorDes.TabStop = False
      Me.txtProveedorDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtProveedorDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 16)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(60, 16)
      Me.Label4.TabIndex = 236
      Me.Label4.Text = "Proveedor"
      '
      'frmFacturaDifEdit
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(742, 466)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmFacturaDifEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Nueva Factura"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      Me.UiGroupBox3.PerformLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtMontoPagBs As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtImporteBs As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtProveedorDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Save"
            If DataSave() Then
               mlngID = moCompra.ProveedorId
               mboolChanged = True
               Me.Close()
            End If

         Case "FacNoValida"
            ''If SaveFacturaNOValida() Then
            ''   mlngID = moCompra.ProveedorId
            ''   mboolChanged = True
            ''   Me.Close()
            ''End If

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

      Me.Text = "Nueva Factura"

      Call FormInit()
      Call FormNew()
      Call grdMainLoad()

      Call SecuritySet(Me, AppExeName)
      dtpFecha.Select()

   End Sub

   Private Sub FormNew()
      ''mboolAdding = True

      Call DataClear()

      dtpFecha.Select()
   End Sub

   Private Sub grdMainLoad()

      Try
         With moCompra

            Call ProveedorLoad(.ProveedorId)

            .SelectFilter = clsCompra.SelectFilters.GridFacturar
            .WhereFilter = clsCompra.WhereFilters.GridFacturar
            .OrderByFilter = clsCompra.OrderByFilters.GridContado
            .EmpresaId = moCompra.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = moCompra.ProveedorId

            If .Open() Then

               For Each oRow In .DataSet.Tables(.TableName).Rows

                  If ToDecimal(oRow("FactDifExento")) > 0 Then
                     oRow("ExentoFac") = FacturaDifExento(oRow("CompraId"), oRow("MonedaId"))
                     oRow("ExentoAFac") = ToDecimal(oRow("FactDifExento") - oRow("ExentoFac"))
                  End If

               Next

               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()

            End If

            Call CompraTotal(True)

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataClear()

      With moCompra
         Call ProveedorLoad(.ProveedorId)
         dtpFecha.Text = ToDateDMY(Now.Date)

      End With

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
      Dim rpt As New rptFacturaDifEdit

      rpt.DataSource = GetDataView(moCompra.DataSet.Tables(moCompra.TableName))

      rpt.lblTitle.Text = "Notas de Compra a Facturar : " & ToStr(txtProveedorDes.Text)
      rpt.Document.Name = "Notas de Compra a Facturar"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.txtFechaPago.Text = dtpFecha.Text

      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtMontoPagBs.Text = ToDecStrDos(ToDecimal(txtMontoPagBs.Text))
      rpt.txtMontoPagUs.Text = ToDecStrDos(ToDecimal(txtMontoPagUs.Text))

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As frmReportPreview
      frm = New frmReportPreview(rpt.Document)
      frm.Show()
   End Sub

   Private Sub DataReadOnly()
      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub FormInit()
      txtImporteBs.FormatString = DecimalMask()
      txtMontoPagBs.FormatString = DecimalMask()
      txtImporteUs.FormatString = DecimalMask()
      txtMontoPagUs.FormatString = DecimalMask()
      txtTipoCambio.FormatString = DecimalMask()

      Call CompraParaFechaMenor(clsTipoCompra.COMPRA, clsAppInfo.GestionId)

   End Sub

   Private Sub ProveedorLoad(ByVal lngProveedorId As Long)
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               txtProveedorDes.Tag = .ProveedorId
               txtProveedorDes.Text = ToStr(.ProveedorDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Sub

   Private Sub CompraParaFechaMenor(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long)
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = clsAppInfo.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId

            If .Find Then
               mboolFacFechaMenor = .FacFechaMen
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try

   End Sub

#Region " Factura "

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
         If FormCheck() Then
            If grdMain.RowCount > 0 Then
               Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
               Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
               DataSave = False

               With oCompra
                  .CompraId = ToLong(grdMain.GetValue("CompraId"))

                  If .FindByPK Then
                     Dim frm As New frmFacturaDifDetEdit

                     frm.Adding = True
                     frm.AnularFac = False

                     oFactura.EmpresaId = moCompra.EmpresaId
                     oFactura.GestionId = moCompra.GestionId
                     oFactura.FacturaFecha = ToDateDMY(dtpFecha.Value)
                     oFactura.SucursalId = AlmacenSucursalIdFind(oCompra.AlmacenId)
                     oFactura.TipoFacturaId = 2 'Compra               
                     oFactura.RegRUCDes = ProveedorDesFind(oCompra.ProveedorId, oFactura.NroRUC)
                     oFactura.EstadoId = 11

                     If oCompra.MonedaId = 1 Then
                        oFactura.FacturaMonto = ToDecimal(grdMain.GetValue("SaldoFactura"))
                        oFactura.Exento = ToDecimal(grdMain.GetValue("ExentoAFac"))
                     Else
                        oFactura.FacturaMonto = ToDecimal(ToDecimal(grdMain.GetValue("SaldoFactura")) * ToDecimal(txtTipoCambio.Text))
                        oFactura.Exento = ToDecimal(ToDecimal(grdMain.GetValue("ExentoAFac")) * ToDecimal(txtTipoCambio.Text))
                     End If

                     oFactura.SucursalIdOrg = clsAppInfo.SucursalId
                     If clsAppInfo.SucursalApli Then
                        oFactura.SucursalIdOrg = oCompra.SucursalId
                     End If

                     frm.DataObject = oFactura
                     frm.MonedaId = oCompra.MonedaId
                     frm.ProveedorId = oCompra.ProveedorId
                     frm.CompraId = oCompra.CompraId
                     frm.TipoCambio = ToDecimal(txtTipoCambio.Text)
                     frm.ExentoFac = ToDecimal(grdMain.GetValue("ExentoFac"))

                     frm.CentroCostoId = 0
                     If clsAppInfo.CentroCostoApli Then
                        frm.CentroCostoId = oCompra.CentroCostoId
                     End If

                     frm.ShowDialog()

                     If frm.Changed Then
                        DataSave = True
                     End If

                     frm.Dispose()
                  End If

               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim oRow As DataRow

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         FormCheck = False
         Throw New Exception("Fecha Inicial no Corresponde a la Gestion en Uso")

         ''ElseIf Not OperaFechaHabil(ToDate(dtpFecha.Value)) Then  ''Comentado a pedido de don AMC
         ''   FormCheck = False
         ''   Throw New Exception("Fecha de Operación Inhábil para el Usuario")
      End If

      If dtpFecha.Value > Now Then
         FormCheck = False
         Throw New Exception("Fecha no Válida, No puede ser mayor a la Actual")
      End If

      If Not mboolFacFechaMenor Then
      If dtpFecha.Value < grdMain.GetValue("Fecha") Then
         FormCheck = False
         Throw New Exception("Fecha no Válida, No puede ser Menor al de la Compra")
         End If
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

   Private Function ProveedorDesFind(ByVal lngProveedorId As Long, ByRef strClienteNIT As String) As String
      Dim oCliente As New clsProveedor(clsAppInfo.ConnectString)

      ProveedorDesFind = ""

      Try
         With oCliente
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               strClienteNIT = .ProveedorNIT
               Return .ProveedorDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCliente.Dispose()

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

   Private Sub CompraTotal(ByVal mboolCompraTotal As Boolean)
      Dim decImporteBs As Decimal = 0
      Dim decMontoBs As Decimal = 0

      Dim decImporteUs As Decimal = 0
      Dim decMontoUs As Decimal = 0


      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows

         If oRow.Cells("MonedaId").Value = 2 Then 'Si es Dolar
            decMontoUs = ToDecimal(ToDouble(oRow.Cells("SaldoFactura").Value))
            decMontoBs = ToDecimal(decMontoUs * ToDouble(oRow.Cells("TipoCambio").Value))
         Else
            decMontoBs = ToDecimal(ToDouble(oRow.Cells("SaldoFactura").Value))
            decMontoUs = ToDecimal(decMontoBs / ToDouble(oRow.Cells("TipoCambio").Value))
         End If

         If mboolCompraTotal Then
            decImporteBs += decMontoBs
            decImporteUs += decMontoUs
         End If

      Next

      If mboolCompraTotal Then
         txtImporteBs.Text = decImporteBs
         txtImporteUs.Text = decImporteUs
      End If

      If grdMain.GetValue("MonedaId") = 2 Then 'Si es Dolar
         decMontoUs = ToDecimal(grdMain.GetValue("SaldoFactura"))
         decMontoBs = ToDecimal(decMontoUs * ToDouble(grdMain.GetValue("TipoCambio")))

      ElseIf grdMain.GetValue("MonedaId") = 1 Then
         decMontoBs = ToDecimal(grdMain.GetValue("SaldoFactura"))
         decMontoUs = ToDecimal(decMontoBs / ToDouble(grdMain.GetValue("TipoCambio")))
      End If

      txtMontoPagBs.Text = decMontoBs
      txtMontoPagUs.Text = decMontoUs

   End Sub

   Private Function FacturaDifExento(ByVal lngCompraId As Long, ByVal lngMonedaId As Decimal) As Decimal
      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decExentoUs As Decimal = 0

      Try
         FacturaDifExento = False

         With oCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.All
            .WhereFilter = clsCompraFac.WhereFilters.CompraId
            .GestionId = clsAppInfo.GestionId
            .EmpresaId = clsAppInfo.EmpresaId
            .CompraId = lngCompraId

            If .Open Then
               Do While .Read()

                  oFactura.FacturaId = .FacturaId
                  If oFactura.FindByPK Then
                     FacturaDifExento += oFactura.Exento
                     decExentoUs += ToDecimal(oFactura.Exento / .TipoCambio)
                  End If

                  .MoveNext()
               Loop
            End If

            If lngMonedaId <> clsMoneda.BOLIVIANOS Then
               FacturaDifExento = decExentoUs
            End If

         End With


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraFac.Dispose()
      End Try
   End Function


#End Region

#Region " Factura NO Válida "

   ''Private Function SaveFacturaNOValida() As Boolean
   ''   Dim oRow As Janus.Windows.GridEX.GridEXRow

   ''   Try
   ''      If FormCheckNoValida() Then
   ''         If grdMain.RowCount > 0 Then
   ''            If ToDecimal(grdMain.GetValue("MontoFac")) = 0 Then

   ''               If MessageBox.Show("¿Realmente Quiere poner la Factura Diferida como NO VÁLIDA?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

   ''                  oRow = grdMain.GetRow()

   ''                  If (oRow.Cells("MontoBru").Value - oRow.Cells("FactDifExento").Value) > 0 Then
   ''                     If frmCompPlanFill() Then

   ''                        If CompNewCompraFacNoValida(oRow) Then
   ''                           If CompraUpdate(oRow.Cells("CompraId").Value, oRow.Cells("MontoBru").Value) Then
   ''                              SaveFacturaNOValida = True
   ''                           End If
   ''                        End If
   ''                     End If
   ''                  Else
   ''                     If CompraUpdate(oRow.Cells("CompraId").Value, oRow.Cells("MontoBru").Value) Then
   ''                        SaveFacturaNOValida = True
   ''                     End If

   ''                  End If
   ''               End If


   ''            Else
   ''               MessageBox.Show("La Compra NO debe tener Monto Facturado ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   ''            End If
   ''         Else
   ''            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   ''         End If
   ''      End If

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   ''      Return False
   ''   End Try
   ''End Function

   ''Private Function FormCheckNoValida() As Boolean
   ''   Dim strMsg As String = String.Empty
   ''   Dim oRow As DataRow

   ''   If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
   ''      FormCheckNoValida = False
   ''      Throw New Exception("Fecha Inicial no Corresponde a la Gestion en Uso")

   ''      ''ElseIf Not OperaFechaHabil(ToDate(dtpFecha.Value)) Then  ''Comentado a pedido de don AMC
   ''      ''   FormCheck = False
   ''      ''   Throw New Exception("Fecha de Operación Inhábil para el Usuario")
   ''   End If

   ''   If dtpFecha.Value > Now Then
   ''      FormCheckNoValida = False
   ''      Throw New Exception("Fecha no Válida, No puede ser mayor a la Actual")
   ''   End If

   ''   If dtpFecha.Value < grdMain.GetValue("Fecha") Then
   ''      FormCheckNoValida = False
   ''      Throw New Exception("Fecha no Válida, No puede ser Menor al de la Compra")
   ''   End If

   ''   ''If ToDecimal(txtTipoCambio.Text) <= 0 Then
   ''   ''   strMsg &= "Tipo de Cambio Inválido" & vbCrLf
   ''   ''End If

   ''   If strMsg.Trim <> String.Empty Then
   ''      Throw New Exception(strMsg)
   ''      FormCheckNoValida = False
   ''   Else
   ''      FormCheckNoValida = True
   ''   End If
   ''End Function

   ''Private Function CompNewCompraFacNoValida(ByVal oRow As Janus.Windows.GridEX.GridEXRow) As Boolean
   ''   Dim decTipoCambio As Decimal
   ''   Dim lngTipoCompId As Long = 3
   ''   Dim strDes As String
   ''   Dim lngCompId As Long
   ''   Dim lngCompNro As Long
   ''   Dim lngCompDetId As Long

   ''   Dim decMontoBs As Decimal
   ''   Dim decMontoUs As Decimal
   ''   Dim decMontoOrg As Decimal

   ''   Dim decMontoIvaBs As Decimal
   ''   Dim decMontoIvaUs As Decimal
   ''   Dim decIvaBs As Decimal = 0
   ''   Dim decIvaUs As Decimal = 0
   ''   Dim decIvaOrg As Decimal = 0

   ''   CompNewCompraFacNoValida = False

   ''   Try

   ''      If oRow.Cells("MonedaId").Value = 1 Then
   ''         decMontoBs = ToDecimal(oRow.Cells("MontoBru").Value - oRow.Cells("FactDifExento").Value)
   ''         decMontoUs = ToDecimal(ToDecimal(oRow.Cells("MontoBru").Value - oRow.Cells("FactDifExento").Value) / oRow.Cells("TipoCambio").Value)
   ''         decMontoOrg = decMontoBs

   ''      ElseIf (oRow.Cells("MonedaId").Value = 2) Then
   ''         decMontoBs = ToDecimal(ToDecimal(oRow.Cells("MontoBru").Value - oRow.Cells("FactDifExento").Value) * oRow.Cells("TipoCambio").Value)
   ''         decMontoUs = ToDecimal(oRow.Cells("MontoBru").Value - oRow.Cells("FactDifExento").Value)
   ''         decMontoOrg = decMontoUs
   ''      End If

   ''      decIvaBs = ToDecimal(decMontoBs * clsAppInfo.IVA)
   ''      decIvaUs = ToDecimal(decMontoUs * clsAppInfo.IVA)
   ''      decIvaOrg = ToDecimal(decMontoOrg * clsAppInfo.IVA)


   ''      If CompAdd(oRow, decIvaBs, decIvaUs, lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante
   ''         If CompDetAdd(oRow, lngTipoCompId, lngCompId, mlngPlanId, "", decIvaBs, decIvaUs, decIvaOrg, 1, mlngSucursalId, mlngCentroCostoId, lngCompDetId, ) Then

   ''            If mlngPlanAddId <> 0 Then  'Analitico Adicional
   ''               If CompPlanAddAdd(oRow, lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decIvaBs, decIvaUs, 1) Then
   ''                  CompNewCompraFacNoValida = True
   ''               End If
   ''            End If

   ''            If mlngCentroCostoDetId <> 0 Then  'Actividad
   ''               If CompCentroCostoDetAdd(oRow, lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, decIvaBs, decIvaUs, 1) Then
   ''                  CompNewCompraFacNoValida = True
   ''               End If
   ''            End If

   ''            ''Cuenta contra Cuenta
   ''            If CompDetAdd(oRow, lngTipoCompId, lngCompId, clsAppInfo.PlanCreDifId, "", decIvaBs, decIvaUs, decIvaOrg, 2, , , , 1) Then
   ''               CompNewCompraFacNoValida = True
   ''            End If

   ''         End If

   ''      End If

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   ''      Return False

   ''   End Try
   ''End Function

   ''Private Function CompAdd(ByVal oRow As Janus.Windows.GridEX.GridEXRow, ByVal decMontoBs As Decimal, ByVal decMontoUs As Decimal, _
   ''                     ByVal lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long) As Boolean
   ''   Dim oComp As New clsComp(clsAppInfo.ConnectString)

   ''   CompAdd = False

   ''   Try
   ''      With oComp
   ''         .EmpresaId = moCompra.EmpresaId
   ''         .GestionId = moCompra.GestionId
   ''         .TipoCompId = lngTipoCompId
   ''         .CompNro = CompNroNext(.TipoCompId, moCompra.EmpresaId, moCompra.GestionId, dtpFecha.Value)
   ''         .Fecha = ToDate(dtpFecha.Value)
   ''         .MonedaId = oRow.Cells("MonedaId").Value
   ''         .TipoCambio = oRow.Cells("TipoCambio").Value
   ''         .EntregadoA = txtProveedorDes.Text
   ''         .PorConcepto = "Compra Nro. " & ToStr(oRow.Cells("CompraNro").Value) & "; con Factura Diferida NO VÀLIDA"
   ''         .DebeBs = decMontoBs
   ''         .HaberBs = decMontoBs
   ''         .DebeUs = decMontoUs
   ''         .HaberUs = decMontoUs
   ''         .PorIVA = clsAppInfo.IVA
   ''         .PorIT = clsAppInfo.IT
   ''         .PorITF = clsAppInfo.ITF

   ''         If clsAppInfo.MultipleNro Then
   ''            .SinFac = 1
   ''            .ConFac = 1
   ''         Else
   ''            .SinFac = 1
   ''            .ConFac = 0
   ''         End If

   ''         .Automatico = 0
   ''         .Glosa = ""
   ''         .TipoNotaId = 0
   ''         .NotaNro = 0
   ''         .TipoAsientoId = 0
   ''         .EstadoId = 10

   ''         If .Insert() Then
   ''            lngCompId = .CompId
   ''            lngCompNro = .CompNro

   ''            CompAdd = True
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oComp.Dispose()

   ''   End Try
   ''End Function

   ''Private Function CompDetAdd(ByVal oRow As Janus.Windows.GridEX.GridEXRow, ByVal lngTipoCompId As Long, ByVal lngCompId As Long, ByVal lngPlanId As Long, _
   ''                        ByVal strDes As String, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, _
   ''                        ByVal decValorOrg As Decimal, ByVal lngCol As Long, Optional ByVal lngSucursalId As Long = 0, _
   ''                        Optional ByVal lngCentroCostoId As Long = 0, Optional ByRef lngCompDetId As Long = 0, _
   ''                        Optional ByVal bytAutomatico As Byte = 0) As Boolean

   ''   Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
   ''   Dim lngSucCCOId As Long

   ''   CompDetAdd = False

   ''   Try
   ''      With oCompDet
   ''         .CompId = lngCompId
   ''         .EmpresaId = moCompra.EmpresaId
   ''         .GestionId = moCompra.GestionId
   ''         .TipoCompId = lngTipoCompId
   ''         .Fecha = ToDate(dtpFecha.Value)
   ''         .PlanId = lngPlanId
   ''         .CompDetDes = "Compra Nro. " & ToStr(oRow.Cells("CompraNro").Value) & "; Factura Diferida NO VÀLIDA"
   ''         .SucursalId = lngSucursalId
   ''         .CentroCostoId = lngCentroCostoId
   ''         .MonedaId = oRow.Cells("MonedaId").Value

   ''         If .MonedaId = 1 Then
   ''            If lngCol = 1 Then
   ''               .DebeOrg = decValorOrg
   ''               .DebeBs = decValorBs
   ''               .DebeUs = decValorUs

   ''               .HaberOrg = 0
   ''               .HaberBs = 0
   ''               .HaberUs = 0

   ''            ElseIf lngCol = 2 Then
   ''               .HaberOrg = decValorOrg
   ''               .HaberBs = decValorBs
   ''               .HaberUs = decValorUs

   ''               .DebeOrg = 0
   ''               .DebeBs = 0
   ''               .DebeUs = 0
   ''            End If

   ''         ElseIf .MonedaId = 2 Then
   ''            If lngCol = 1 Then
   ''               .DebeOrg = decValorOrg
   ''               .DebeBs = decValorBs
   ''               .DebeUs = decValorUs

   ''               .HaberOrg = 0
   ''               .HaberBs = 0
   ''               .HaberUs = 0

   ''            ElseIf lngCol = 2 Then
   ''               .HaberOrg = decValorOrg
   ''               .HaberBs = decValorBs
   ''               .HaberUs = decValorUs

   ''               .DebeOrg = 0
   ''               .DebeUs = 0
   ''               .DebeBs = 0
   ''            End If
   ''         End If

   ''         .Orden = 0
   ''         .Automatico = bytAutomatico
   ''         .TipoRetencionId = 0
   ''         .EstadoId = 10

   ''         If .Insert() Then
   ''            lngCompDetId = .CompDetId
   ''            CompDetAdd = True
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oCompDet.Dispose()

   ''   End Try
   ''End Function

   ''Private Function CompPlanAddAdd(ByVal oRow As Janus.Windows.GridEX.GridEXRow, ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
   ''                          ByVal lngPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long) As Boolean

   ''   Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

   ''   CompPlanAddAdd = False

   ''   Try
   ''      With oCompPlanAdd
   ''         .EmpresaId = moCompra.EmpresaId
   ''         .GestionId = moCompra.GestionId
   ''         .CompId = lngCompId
   ''         .CompDetId = lngCompDetId
   ''         .Fecha = ToDate(dtpFecha.Value)
   ''         .PlanId = lngPlanId
   ''         .MonedaId = oRow.Cells("MonedaId").Value
   ''         .PlanAddId = lngPlanAddId
   ''         .EstadoId = 10

   ''         If .MonedaId = 1 Then
   ''            If lngCol = 1 Then
   ''               .DebeOrg = decValorBs
   ''               .HaberOrg = 0
   ''               .DebeBs = decValorBs
   ''               .HaberBs = 0
   ''               .DebeUs = decValorUs
   ''               .HaberUs = 0
   ''            Else
   ''               .DebeOrg = 0
   ''               .HaberOrg = decValorBs
   ''               .DebeBs = 0
   ''               .HaberBs = decValorBs
   ''               .DebeUs = 0
   ''               .HaberUs = decValorUs
   ''            End If

   ''         ElseIf .MonedaId = 2 Then
   ''            If lngCol = 1 Then
   ''               .DebeOrg = decValorUs
   ''               .HaberOrg = 0
   ''               .DebeBs = decValorBs
   ''               .HaberBs = 0
   ''               .DebeUs = decValorUs
   ''               .HaberUs = 0
   ''            Else
   ''               .DebeOrg = 0
   ''               .HaberOrg = decValorUs
   ''               .DebeBs = 0
   ''               .HaberBs = decValorBs
   ''               .DebeUs = 0
   ''               .HaberUs = decValorUs
   ''            End If
   ''         End If

   ''         .EstadoId = 10

   ''         If .Insert() Then
   ''            CompPlanAddAdd = True
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oCompPlanAdd.Dispose()

   ''   End Try
   ''End Function

   ''Private Function CompCentroCostoDetAdd(ByVal oRow As Janus.Windows.GridEX.GridEXRow, ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngCentroCostoId As Long, _
   ''                            ByVal lngCentroCostoDetId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long) As Boolean

   ''   Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

   ''   CompCentroCostoDetAdd = False

   ''   Try
   ''      With oCompCentroCostoDet
   ''         .EmpresaId = moCompra.EmpresaId
   ''         .GestionId = moCompra.GestionId
   ''         .CompId = lngCompId
   ''         .CompDetId = lngCompDetId
   ''         .Fecha = ToDate(dtpFecha.Value)
   ''         .PlanId = lngPlanId
   ''         .MonedaId = oRow.Cells("MonedaId").Value
   ''         .CentroCostoId = lngCentroCostoId
   ''         .CentroCostoDetId = lngCentroCostoDetId

   ''         If .MonedaId = 1 Then
   ''            If lngCol = 1 Then
   ''               .DebeOrg = decValorBs
   ''               .HaberOrg = 0
   ''               .DebeBs = decValorBs
   ''               .HaberBs = 0
   ''               .DebeUs = decValorUs
   ''               .HaberUs = 0
   ''            Else
   ''               .DebeOrg = 0
   ''               .HaberOrg = decValorBs
   ''               .DebeBs = 0
   ''               .HaberBs = decValorBs
   ''               .DebeUs = 0
   ''               .HaberUs = decValorUs
   ''            End If

   ''         ElseIf .MonedaId = 2 Then
   ''            If lngCol = 1 Then
   ''               .DebeOrg = decValorUs
   ''               .HaberOrg = 0
   ''               .DebeBs = decValorBs
   ''               .HaberBs = 0
   ''               .DebeUs = decValorUs
   ''               .HaberUs = 0
   ''            Else
   ''               .DebeOrg = 0
   ''               .HaberOrg = decValorUs
   ''               .DebeBs = 0
   ''               .HaberBs = decValorBs
   ''               .DebeUs = 0
   ''               .HaberUs = decValorUs
   ''            End If
   ''         End If

   ''         .EstadoId = 10

   ''         If .Insert() Then
   ''            CompCentroCostoDetAdd = True
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oCompCentroCostoDet.Dispose()

   ''   End Try
   ''End Function

   ''Private Function CompraUpdate(ByVal lngCompraId As Long, ByVal decMontoFac As Decimal) As Boolean
   ''   Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

   ''   CompraUpdate = False

   ''   Try
   ''      With oCompra
   ''         .CompraId = lngCompraId

   ''         If .FindByPK Then
   ''            .Fecha = ToDate(.Fecha)
   ''            .MontoFac = decMontoFac

   ''            .UpdateFilter = clsCompra.UpdateFilters.MontoFac
   ''            If .Update() Then
   ''               CompraUpdate = True
   ''            End If
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oCompra.Dispose()

   ''   End Try
   ''End Function

   ''Private Function frmCompPlanFill() As Boolean
   ''   Dim frm As New frmCompPlan
   ''   Dim strPlanDes As String = ""
   ''   Dim lngMonedaIdPlan As Long = 0

   ''   frmCompPlanFill = False

   ''   mlngPlanId = 0
   ''   mlngPlanAddId = 0
   ''   mlngSucursalId = 0
   ''   mlngCentroCostoId = 0
   ''   mlngCentroCostoDetId = 0
   ''   mlngTipoPlanId = 0

   ''   With frm
   ''      .EmpresaId = moCompra.EmpresaId
   ''      .PlanWhereFilter = clsPlan.WhereFilters.EsAna
   ''      ''.chkTieneComp.Visible = True
   ''      ''.Editing = False
   ''      ''.NewRecord = True
   ''      .ShowDialog()

   ''      If .Changed Then
   ''         mlngPlanId = frm.PlanId
   ''         mlngPlanAddId = frm.PlanAddId
   ''         mlngSucursalId = frm.SucursalId
   ''         mlngCentroCostoId = frm.CentroCostoId
   ''         mlngCentroCostoDetId = frm.CentroCostoDetId
   ''         ''mlngTipoPlanId = TipoPlanIdFind(mlngPlanId, strPlanDes, lngMonedaIdPlan)
   ''         mboolTieneComp = frm.TieneComp

   ''         ''If mlngTipoPlanId = 3 And lngMonedaIdPlan = clsMoneda.DOLARES Then  'Tipo Cuenta 3 = Banco -- Cuenta Corriente
   ''         ''   If MessageBox.Show("¿Desea Aplicar I.T.F. a la Cuenta  " & strPlanDes & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
   ''         ''      mboolAplicarITF = True
   ''         ''   End If
   ''         ''End If

   ''         frmCompPlanFill = True
   ''      End If
   ''         frm.Dispose()
   ''   End With

   ''End Function

   ''Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal datFecha As Date) As Long
   ''   Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

   ''   Try
   ''      CompNroNext = 0

   ''      With oCompPara
   ''         .SelectFilter = clsCompPara.SelectFilters.All
   ''         .WhereFilter = clsCompPara.WhereFilters.TipoCompId
   ''         .EmpresaId = lngEmpresaId
   ''         .TipoCompId = lngTipoCompId
   ''         .GestionId = lngGestionId

   ''         If .Find Then
   ''            If ToBoolean(.NroAuto) Then
   ''               If ToBoolean(.NroAutoGestion) Then
   ''                  .UpdateFilter = clsCompPara.UpdateFilters.NroActual

   ''                  If Not clsAppInfo.MultipleNro Then
   ''                     .NroActual = .NroActual + 1

   ''                     If .Update Then
   ''                        CompNroNext = .NroActual
   ''                     End If

   ''                  Else
   ''                     'If chkConFac.Checked Then
   ''                     .NroActualFis = .NroActualFis + 1

   ''                     If .Update Then
   ''                        CompNroNext = .NroActualFis
   ''                     End If

   ''                     'Else
   ''                     '   .NroActual = .NroActual + 1

   ''                     '   If .Update Then
   ''                     '      CompNroNext = .NroActual
   ''                     '   End If
   ''                     'End If
   ''                  End If
   ''               Else
   ''                  CompNroNext = CompNroMesNext(lngTipoCompId, lngEmpresaId, lngGestionId, datFecha.Month)
   ''               End If
   ''            End If
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oCompPara.Dispose()

   ''   End Try
   ''End Function

   ''Private Function CompNroMesNext(ByVal lngTipoCompId As Long, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal intMesId As Integer) As Long
   ''   Dim oCompParaMes As New clsCompParaMes(clsAppInfo.ConnectString)

   ''   Try
   ''      CompNroMesNext = 0

   ''      With oCompParaMes
   ''         .SelectFilter = clsCompParaMes.SelectFilters.All
   ''         .WhereFilter = clsCompParaMes.WhereFilters.MesId
   ''         .EmpresaId = lngEmpresaId
   ''         .TipoCompId = lngTipoCompId
   ''         .GestionId = lngGestionId
   ''         .MesId = intMesId

   ''         If .Find Then
   ''            .UpdateFilter = clsCompParaMes.UpdateFilters.NroActual

   ''            If Not clsAppInfo.MultipleNro Then
   ''               .NroActual = .NroActual + 1

   ''               If .Update Then
   ''                  CompNroMesNext = .NroActual
   ''               End If

   ''            Else
   ''               'If chkConFac.Checked Then
   ''               .NroActualFis = .NroActualFis + 1

   ''               If .Update Then
   ''                  CompNroMesNext = .NroActualFis
   ''               End If
   ''               'Else
   ''               '   .NroActual = .NroActual + 1

   ''               '   If .Update Then
   ''               '      CompNroMesNext = .NroActual
   ''               '   End If
   ''               'End If
   ''            End If
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oCompParaMes.Dispose()

   ''   End Try
   ''End Function

#End Region

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

   Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
      If Not IsNothing(moCompra) Then
         If dtpFecha.Tag <> dtpFecha.Text Then
            If IsDate(dtpFecha.Text) Then
               Call txtTipoCambioLoad(ToDate(dtpFecha.Value))
               ''Call grdMainLoad()
               dtpFecha.Tag = dtpFecha.Text
            Else
               txtTipoCambio.Text = 0
            End If
         End If
      End If
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Notas de Compra"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True
         .RootTable.Columns("Sel").Visible = False

         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("GestionId").Visible = False

         .RootTable.Columns("Gestion").Caption = "Gestión"
         .RootTable.Columns("Gestion").Width = 80
         .RootTable.Columns("Gestion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Gestion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraNro").Caption = "Compra"
         .RootTable.Columns("CompraNro").Width = 80
         .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraOrden").Caption = "Nro. Orden"
         .RootTable.Columns("CompraOrden").Width = 80
         .RootTable.Columns("CompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         ''.RootTable.Columns("IvaFac").Caption = ""
         ''.RootTable.Columns("IvaFac").Width = 20

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AlmacenId").Visible = False

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 80
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoOrg").Caption = "Total Venta"
         .RootTable.Columns("MontoOrg").FormatString = DecimalMask()
         .RootTable.Columns("MontoOrg").Width = 80
         .RootTable.Columns("MontoOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoOrg").Visible = False

         .RootTable.Columns("MontoNet").Visible = False

         .RootTable.Columns("MontoLiq").Caption = "Líquido Pag."
         .RootTable.Columns("MontoLiq").FormatString = DecimalMask()
         .RootTable.Columns("MontoLiq").Width = 80
         .RootTable.Columns("MontoLiq").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoLiq").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoLiq").Visible = False

         .RootTable.Columns("MontoAnt").Caption = "Anticipo"
         .RootTable.Columns("MontoAnt").FormatString = DecimalMask()
         .RootTable.Columns("MontoAnt").Width = 80
         .RootTable.Columns("MontoAnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoAnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoAnt").Visible = False

         .RootTable.Columns("MontoDes").Caption = "Descuento"
         .RootTable.Columns("MontoDes").FormatString = DecimalMask()
         .RootTable.Columns("MontoDes").Width = 80
         .RootTable.Columns("MontoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoDes").Visible = False

         .RootTable.Columns("MontoRec").Caption = "Recargo"
         .RootTable.Columns("MontoRec").FormatString = DecimalMask()
         .RootTable.Columns("MontoRec").Width = 80
         .RootTable.Columns("MontoRec").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoRec").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoRec").Visible = False

         .RootTable.Columns("MontoBru").Caption = "Compra"
         .RootTable.Columns("MontoBru").FormatString = DecimalMask()
         .RootTable.Columns("MontoBru").Width = 80
         .RootTable.Columns("MontoBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoFac").Caption = "Facturado"
         .RootTable.Columns("MontoFac").FormatString = DecimalMask()
         .RootTable.Columns("MontoFac").Width = 100
         .RootTable.Columns("MontoFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SaldoFactura").Caption = "Saldo Factura"
         .RootTable.Columns("SaldoFactura").FormatString = DecimalMask()
         .RootTable.Columns("SaldoFactura").Width = 100
         .RootTable.Columns("SaldoFactura").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SaldoFactura").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCambio").Caption = "Tipo Cambio"
         .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
         .RootTable.Columns("TipoCambio").Width = 80
         .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoPagoId").Visible = False

         .RootTable.Columns("TipoPagoDes").Caption = "Tipo Pago"
         .RootTable.Columns("TipoPagoDes").Width = 80
         .RootTable.Columns("TipoPagoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoPagoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaId").Visible = False
         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 80
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FactDifExento").Caption = "Exento"
         .RootTable.Columns("FactDifExento").FormatString = DecimalMask()
         .RootTable.Columns("FactDifExento").Width = 100
         .RootTable.Columns("FactDifExento").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("FactDifExento").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ExentoFac").Caption = "Exento Facturado"
         .RootTable.Columns("ExentoFac").FormatString = DecimalMask()
         .RootTable.Columns("ExentoFac").Width = 100
         .RootTable.Columns("ExentoFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ExentoFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ExentoAFac").Caption = "Saldo Exento "
         .RootTable.Columns("ExentoAFac").FormatString = DecimalMask()
         .RootTable.Columns("ExentoAFac").Width = 100
         .RootTable.Columns("ExentoAFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ExentoAFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center


      End With

      Call AddConditionalFormatting()

   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 9)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

   End Sub

   Private Sub grdMain_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyUp
      Call CompraTotal(True)
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If

      End If
   End Sub

   Private Sub grdMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.Click
      CompraTotal(True)
   End Sub

   Private Sub frmFacturaDifEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then

            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then

               If DataSave() Then
                  mlngID = moCompra.ProveedorId
                  mboolChanged = True
                  Me.Close()
               End If

            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmFacturaDifEdit_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
      moCompra.Dispose()
      Call ClearMemory()
   End Sub

End Class