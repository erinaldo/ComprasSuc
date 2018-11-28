Public Class frmAjusteEdit
   Inherits System.Windows.Forms.Form

   Private moAjuste As clsAjuste
   Private moAjusteDet As clsAjusteDet

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditGrid As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents chkSinFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
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

   WriteOnly Property DataObject() As clsAjuste
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
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
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
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents SaveTemp As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Anular As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtAjusteDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtAjusteNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtAjusteId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents chkProveedor As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtMontoPag As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtInteres As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtCapital As Janus.Windows.GridEX.EditControls.NumericEditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Anular1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjusteEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkSinFac = New Janus.Windows.EditControls.UICheckBox
      Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
      Me.txtCapital = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtInteres = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtMontoPag = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.grpDatos = New Janus.Windows.EditControls.UIGroupBox
      Me.lblCentroCosto = New System.Windows.Forms.Label
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.chkProveedor = New Janus.Windows.EditControls.UICheckBox
      Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtAjusteDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.txtAjusteNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtAjusteId = New Janus.Windows.GridEX.EditControls.EditBox
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
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Anular1 = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.SaveTemp = New Janus.Windows.UI.CommandBars.UICommand("SaveTemp")
      Me.Anular = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.grpSucursal = New Janus.Windows.EditControls.UIGroupBox
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.lblSucursal = New System.Windows.Forms.Label
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
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
      CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpSucursal.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(720, 203)
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
      Me.grdMain.Size = New System.Drawing.Size(720, 203)
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
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 204
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(8, 172)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(736, 236)
      Me.ebrMain.TabIndex = 20
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
      Me.UiGroupBox3.Controls.Add(Me.chkSinFac)
      Me.UiGroupBox3.Controls.Add(Me.chkConFac)
      Me.UiGroupBox3.Controls.Add(Me.txtCapital)
      Me.UiGroupBox3.Controls.Add(Me.Label13)
      Me.UiGroupBox3.Controls.Add(Me.txtInteres)
      Me.UiGroupBox3.Controls.Add(Me.Label3)
      Me.UiGroupBox3.Controls.Add(Me.txtMontoPag)
      Me.UiGroupBox3.Controls.Add(Me.Label2)
      Me.UiGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(8, 406)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(736, 40)
      Me.UiGroupBox3.TabIndex = 19
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
      Me.chkSinFac.Location = New System.Drawing.Point(8, 12)
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
      Me.chkConFac.Location = New System.Drawing.Point(60, 12)
      Me.chkConFac.Name = "chkConFac"
      Me.chkConFac.Size = New System.Drawing.Size(32, 16)
      Me.chkConFac.TabIndex = 278
      Me.chkConFac.Text = "F"
      Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtCapital
      '
      Me.txtCapital.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtCapital.BackColor = System.Drawing.SystemColors.Info
      Me.txtCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCapital.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCapital.FormatString = "##,##0.000"
      Me.txtCapital.Location = New System.Drawing.Point(248, 12)
      Me.txtCapital.Name = "txtCapital"
      Me.txtCapital.ReadOnly = True
      Me.txtCapital.Size = New System.Drawing.Size(100, 20)
      Me.txtCapital.TabIndex = 20
      Me.txtCapital.Text = "0,000"
      Me.txtCapital.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCapital.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCapital.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(200, 16)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(44, 16)
      Me.Label13.TabIndex = 204
      Me.Label13.Text = "Capital"
      '
      'txtInteres
      '
      Me.txtInteres.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtInteres.BackColor = System.Drawing.SystemColors.Info
      Me.txtInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtInteres.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtInteres.FormatString = "##,##0.000"
      Me.txtInteres.Location = New System.Drawing.Point(452, 12)
      Me.txtInteres.Name = "txtInteres"
      Me.txtInteres.ReadOnly = True
      Me.txtInteres.Size = New System.Drawing.Size(100, 20)
      Me.txtInteres.TabIndex = 21
      Me.txtInteres.Text = "0,000"
      Me.txtInteres.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtInteres.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtInteres.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(404, 16)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(44, 16)
      Me.Label3.TabIndex = 202
      Me.Label3.Text = "Interés"
      '
      'txtMontoPag
      '
      Me.txtMontoPag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoPag.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPag.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPag.FormatString = "##,##0.000"
      Me.txtMontoPag.Location = New System.Drawing.Point(628, 12)
      Me.txtMontoPag.Name = "txtMontoPag"
      Me.txtMontoPag.ReadOnly = True
      Me.txtMontoPag.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoPag.TabIndex = 22
      Me.txtMontoPag.Text = "0,000"
      Me.txtMontoPag.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPag.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPag.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(560, 16)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(64, 16)
      Me.Label2.TabIndex = 200
      Me.Label2.Text = "Monto Pag"
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
      Me.grpDatos.Controls.Add(Me.txtAjusteDes)
      Me.grpDatos.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpDatos.Location = New System.Drawing.Point(8, 104)
      Me.grpDatos.Name = "grpDatos"
      Me.grpDatos.Size = New System.Drawing.Size(736, 64)
      Me.grpDatos.TabIndex = 8
      Me.grpDatos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCentroCosto.Location = New System.Drawing.Point(424, 16)
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Size = New System.Drawing.Size(44, 15)
      Me.lblCentroCosto.TabIndex = 262
      Me.lblCentroCosto.Text = "C. C."
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(472, 12)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(256, 20)
      Me.cboCentroCosto.TabIndex = 261
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
      'txtAjusteDes
      '
      Me.txtAjusteDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtAjusteDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAjusteDes.Location = New System.Drawing.Point(92, 36)
      Me.txtAjusteDes.MaxLength = 255
      Me.txtAjusteDes.Multiline = True
      Me.txtAjusteDes.Name = "txtAjusteDes"
      Me.txtAjusteDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtAjusteDes.Size = New System.Drawing.Size(636, 20)
      Me.txtAjusteDes.TabIndex = 11
      Me.txtAjusteDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAjusteDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.txtAjusteNro)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.txtAjusteId)
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
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
      Me.cboMoneda.TabIndex = 3
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtAjusteNro
      '
      Me.txtAjusteNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtAjusteNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAjusteNro.FormatString = "########"
      Me.txtAjusteNro.Location = New System.Drawing.Point(628, 12)
      Me.txtAjusteNro.Name = "txtAjusteNro"
      Me.txtAjusteNro.ReadOnly = True
      Me.txtAjusteNro.Size = New System.Drawing.Size(100, 20)
      Me.txtAjusteNro.TabIndex = 4
      Me.txtAjusteNro.TabStop = False
      Me.txtAjusteNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAjusteNro.Value = 0
      Me.txtAjusteNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtAjusteNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      'txtAjusteId
      '
      Me.txtAjusteId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAjusteId.Location = New System.Drawing.Point(60, 12)
      Me.txtAjusteId.Name = "txtAjusteId"
      Me.txtAjusteId.ReadOnly = True
      Me.txtAjusteId.Size = New System.Drawing.Size(100, 20)
      Me.txtAjusteId.TabIndex = 1
      Me.txtAjusteId.TabStop = False
      Me.txtAjusteId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAjusteId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.SaveTemp, Me.Anular, Me.Print})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator2, Me.Anular1, Me.Separator1, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(300, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
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
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
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
      Me.grpSucursal.TabIndex = 22
      Me.grpSucursal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboSucursal
      '
      Me.cboSucursal.BackColor = System.Drawing.SystemColors.Info
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(92, 12)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.ReadOnly = True
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(256, 20)
      Me.cboSucursal.TabIndex = 10
      Me.cboSucursal.TabStop = False
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
      'frmAjusteEdit
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
      Me.Name = "frmAjusteEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ajuste"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      Me.UiGroupBox3.PerformLayout()
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
               mlngID = moAjuste.AjusteId
               mboolChanged = True
               chkConFac.Enabled = False

               cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

               If MessageBox.Show("Ajuste Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Ajuste?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call PrintReport()
               End If
            End If

         Case "Anular"
            If AjusteAnular() Then
               mlngID = moAjuste.AjusteId
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

   Private Sub frmAjusteEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmAjusteEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()

      If Not mboolAdding Then
         Call FormShow()

         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta Ajuste"

         ElseIf OperaFechaHabil(ToDate(dtpFecha.Value)) Then
            Call HeaderReadOnly()
            Me.Text = "Editar Ajuste"

         Else
            MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mboolEditing = False
            Call DataReadOnly()
            Me.Text = "Consulta Ajuste"
         End If

      Else
         Me.Text = "Nuevo Ajuste"
         Call FormNew()
      End If

      Call SecuritySet(Me, AppExeName)
      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub


#Region " Ajuste "

   Private Sub FormShow()
      mboolShow = True
      With moAjuste
         txtAjusteId.Text = ToStr(.AjusteId)
         dtpFecha.Text = ToStr(.Fecha)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtAjusteNro.Text = ToStr(.AjusteNro)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         cboProveedor.Value = ListFindItem(cboProveedor, .ProveedorId)
         txtAjusteDes.Text = ToStr(.AjusteDes)
         txtCapital.Text = ToDecStr(.Capital)
         txtInteres.Text = ToDecStr(.Interes)
         txtMontoPag.Text = ToDecStr(.MontoPag)
         chkConFac.Checked = .ConFac
         chkSinFac.Checked = .SinFac

         cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

         If Not clsAppInfo.MultipleNro Then
            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

      End With

      Call grdMainLoad()

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moAjuste
         txtAjusteId.Text = String.Empty
         dtpFecha.Text = String.Empty
         cboMoneda.SelectedIndex = -1
         txtAjusteNro.Text = "0"
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 14)
         txtTipoCambio.Text = "0"
         cboProveedor.Value = Nothing
         txtAjusteDes.Text = String.Empty
         txtCapital.Text = "0"
         txtInteres.Text = "0"
         txtMontoPag.Text = "0"
         cboCentroCosto.SelectedIndex = -1

         If clsAppInfo.MultipleNro Then
            chkConFac.Checked = False
            chkSinFac.Checked = False
         Else
            chkConFac.Checked = False
            chkSinFac.Checked = True

            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, clsAppInfo.SucursalId)
         Call grdMainLoad()
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtAjusteId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      txtAjusteNro.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      cboProveedor.ReadOnly = True
      txtAjusteDes.ReadOnly = True
      txtCapital.ReadOnly = True
      txtInteres.ReadOnly = True
      txtMontoPag.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False
      cboCentroCosto.ReadOnly = True
      cboSucursal.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub HeaderReadOnly()
      txtAjusteId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboMoneda.ReadOnly = True
      txtAjusteNro.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      cboProveedor.ReadOnly = True
      txtCapital.ReadOnly = True
      txtInteres.ReadOnly = True
      txtMontoPag.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False
      cboCentroCosto.ReadOnly = True
      cboSucursal.ReadOnly = True

   End Sub

   Private Sub ViewComponent()
      Dim decPosSuc As Decimal = 0

      If clsAppInfo.SucursalApli Then
         grpSucursal.Visible = True
      Else
         grpSucursal.Visible = False
         decPosSuc = 40
      End If

      If clsAppInfo.CentroCostoApli Then
         cboCentroCosto.Visible = True
         lblCentroCosto.Visible = True
      Else
         cboCentroCosto.Visible = False
         lblCentroCosto.Visible = False
      End If

      Me.Size = New System.Drawing.Size(Me.Size.Width, Me.Size.Height - decPosSuc)
      grpDatos.Location = New System.Drawing.Point(grpDatos.Location.X, grpDatos.Location.Y - decPosSuc)
      ebrMain.Location = New System.Drawing.Point(ebrMain.Location.X, ebrMain.Location.Y - decPosSuc)
      ebrMain.Size = New System.Drawing.Size(ebrMain.Width, ebrMain.Height + decPosSuc)

   End Sub

   Private Sub DataMove()
      With moAjuste
         If Not mboolAdding Then
            .AjusteId = ToLong(txtAjusteId.Text)
         End If

         .Fecha = ToDate(dtpFecha.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .AjusteNro = ToLong(txtAjusteNro.Text)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .ProveedorId = ListPosition(cboProveedor)
         .AjusteDes = ToStr(txtAjusteDes.Text)
         .Capital = ToDecimal(txtCapital.Text)
         .Interes = ToDecimal(txtInteres.Text)
         .MontoPag = ToDecimal(txtMontoPag.Text)
         .ConFac = ToBoolean(chkConFac.Checked)
         .SinFac = ToBoolean(chkSinFac.Checked)
         .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)

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

      Try
         Call DataMove()

         If FormCheck() Then
            If mboolAdding Then
               DataSave = DataAdd()
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
      Dim oRow As DataRow

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         FormCheck = False
         Throw New Exception("Fecha Inicial no Corresponde a la Gestion en Uso")

      ElseIf Not OperaFechaHabil(ToDate(dtpFecha.Value)) Then
         FormCheck = False
         Throw New Exception("Fecha de Operación Inhábil para el Usuario")
      End If

      ''If dtpFecha.Value > Now Then
      ''   FormCheck = False
      ''   Throw New Exception("Fecha no Valida, No puede ser mayor a la Actual")
      ''End If

      If (Not chkConFac.Checked) And (Not chkSinFac.Checked) Then
         FormCheck = False
         Throw New Exception("Valores Inválidos en (I o F)")
      End If

      If ListPosition(cboProveedor) = 0 Then
         strMsg &= "Proveedor Inválido" & vbCrLf
      End If

      If ToDecimal(txtTipoCambio.Text) <= 0 Then
         strMsg &= "Tipo de Cambio Inválido" & vbCrLf
      End If

      If clsAppInfo.CentroCostoApli Then
         If cboCentroCosto.SelectedIndex = -1 Then
            FormCheck = False
            Throw New Exception("Revise El Centro de Costo")
         End If
      End If

      If moAjusteDet.DataSet.Tables(moAjusteDet.TableName).Rows.Count = 0 Then
         strMsg &= "Ajuste Sin Detalle"
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function AjusteAnular() As Boolean
      Dim lngCompId As Long

      Try
         If FormCheck() Then
            If MessageBox.Show("¿Realmente quiere Anular el Ajuste?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               For Each oRow As DataRow In moAjusteDet.DataSet.Tables(moAjusteDet.TableName).Rows
                  If CreditoRestore(oRow("CreditoId"), oRow("CreditoDetId"), oRow("CapitalOrg"), oRow("InteresOrg")) Then
                     AjusteAnular = True
                  End If
               Next

               If ProveedorMovAnular(10, moAjuste.AjusteId) Then
                  'If CompAnular(moAjuste.TipoCompId, moAjuste.CompNro, moAjuste.SucursalId, 12) Then
                  '   If AjusteAnular(moAjuste.AjusteId, 12) Then
                  '      AjusteAnular = True
                  '   End If
                  'End If
                  If isCompFind(moAjuste.CompId, 0, 0) Then
                     lngCompId = moAjuste.CompId
                  End If

                  If CompAnular(lngCompId, 12) Then
                     If AjusteAnular(moAjuste.AjusteId, 12) Then
                        AjusteAnular = True
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

   Private Function CreditoRestore(ByVal lngCreditoId As Long, ByVal lngCreditoDetId As Long, ByVal decCapitalAmo As Decimal, ByVal decInteresAmo As Decimal) As Boolean
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      CreditoRestore = False

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               If .MonedaId = 1 Then
                  If .MonedaId <> moAjuste.MonedaId Then
                     decCapitalAmo *= .TipoCambio
                     decInteresAmo *= .TipoCambio
                  End If

               ElseIf .MonedaId = 2 Then
                  If .MonedaId <> moAjuste.MonedaId Then
                     decCapitalAmo /= .TipoCambio
                     decInteresAmo /= .TipoCambio
                  End If
               End If

               If CreditoDetRestore(lngCreditoDetId, decCapitalAmo, decInteresAmo) Then
                  .MontoAmo -= decCapitalAmo

                  If Math.Abs(.MontoAmo) <= 0.05 Then
                     .MontoAmo = 0
                  End If

                  .FechaIni = ToDate(.FechaIni)
                  .FechaFin = ToDate(.FechaFin)
                  .EstadoId = 15

                  If .Update Then
                     CreditoRestore = True
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

   Private Function CreditoDetRestore(ByVal lngCreditoDetId As Long, ByVal decCapitalAmo As Decimal, ByVal decInteresAmo As Decimal) As Boolean
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)

      CreditoDetRestore = False

      Try
         With oCreditoDet
            .CreditoDetId = lngCreditoDetId

            If .FindByPK Then
               .CapitalAmo -= decCapitalAmo
               .InteresAmo -= decInteresAmo

               If Math.Abs(.CapitalAmo) <= 0.05 Then
                  .CapitalAmo = 0
               End If

               If Math.Abs(.InteresAmo) <= 0.05 Then
                  .InteresAmo = 0
               End If

               .InteresPen += decInteresAmo
               .Fecha = ToDate(.Fecha)
               .FechaAmo = ToDate(.FechaAmo)
               .EstadoId = 15

               If .Update Then
                  CreditoDetRestore = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCreditoDet.Dispose()

      End Try
   End Function

   Private Function ProveedorMovAnular(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAnular = False

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

   Private Function CompAnular(ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngSucursalId As Long, ByVal lngEstadoId As Long) As Boolean
      If lngCompNro = 0 Then
         Return True   'True si es el Comprobante es 0
      End If

      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      CompAnular = True

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
               If CompDetAnular(.CompId, lngEstadoId) Then
                  If CompPlanAddAnular(.CompId, lngEstadoId) Then
                     If CompCCDetAnular(.CompId, lngEstadoId) Then

                        .Fecha = ToDate(.Fecha)
                        .EstadoId = lngEstadoId

                        If .Update Then
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

   Private Function CompAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      If lngCompId = 0 Then
         Return True   'True si es el Comprobante es 0
      End If

      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      CompAnular = True

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               If CompDetAnular(.CompId, lngEstadoId) Then
                  If CompPlanAddAnular(.CompId, lngEstadoId) Then
                     If CompCCDetAnular(.CompId, lngEstadoId) Then

                        .Fecha = ToDate(.Fecha)
                        .EstadoId = lngEstadoId

                        If .Update Then
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

      CompDetAnular = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moAjuste.EmpresaId
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
            .EmpresaId = moAjuste.EmpresaId
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
            .EmpresaId = moAjuste.EmpresaId
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

   Private Function AjusteAnular(ByVal lngAjusteId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oAjuste As New clsAjuste(clsAppInfo.ConnectString)

      AjusteAnular = False

      Try
         With oAjuste
            .AjusteId = lngAjusteId

            If .FindByPK Then
               If AjusteDetAnular(.AjusteId, lngEstadoId) Then
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     AjusteAnular = True
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAjuste.Dispose()

      End Try
   End Function

   Private Function AjusteDetAnular(ByVal lngAjusteId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oAjusteDet As New clsAjusteDet(clsAppInfo.ConnectString)

      AjusteDetAnular = False

      Try
         With oAjusteDet
            .SelectFilter = clsAjusteDet.SelectFilters.All
            .WhereFilter = clsAjusteDet.WhereFilters.AjusteId
            .EmpresaId = moAjuste.EmpresaId
            .AjusteId = lngAjusteId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     AjusteDetAnular = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAjusteDet.Dispose()

      End Try
   End Function

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

   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
            .EmpresaId = moAjuste.EmpresaId
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
      txtCapital.FormatString = DecimalMask()
      txtInteres.FormatString = DecimalMask()
      txtMontoPag.FormatString = DecimalMask()

      moAjusteDet = New clsAjusteDet(clsAppInfo.ConnectString)
      Call ViewComponent()
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboEstadoLoad()
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

   Private Sub cboProveedorLoad()
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oListItem As clsListItem

      cboProveedor.DropDownList.Columns.Clear()

      Try
         With oProveedor
            .SelectFilter = clsProveedor.SelectFilters.ListBox
            .WhereFilter = clsProveedor.WhereFilters.EstadoId
            .OrderByFilter = clsProveedor.OrderByFilters.ProveedorDes
            .EmpresaId = moAjuste.EmpresaId
            .ProveedorId = moAjuste.ProveedorId
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

   Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
      If mboolAdding Then
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

   Private Sub chkProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProveedor.CheckedChanged
      If chkProveedor.Checked Then
         cboProveedor.DisplayMember = "ProveedorDes"
      Else
         cboProveedor.DisplayMember = "ProveedorCod"
      End If
   End Sub

#End Region


#Region " Detalle del Ajuste "

   Private Sub grdMainLoad()
      Dim oRow As DataRow

      Try
         With moAjusteDet
            .SelectFilter = clsAjusteDet.SelectFilters.Grid
            .WhereFilter = clsAjusteDet.WhereFilters.Grid
            .OrderByFilter = clsAjusteDet.OrderByFilters.Grid
            .EmpresaId = moAjuste.EmpresaId
            .AjusteId = moAjuste.AjusteId

            If .Open() Then
               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
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

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Detalle del Ajuste"

         .RootTable.Columns("AjusteDetId").Visible = False

         .RootTable.Columns("AjusteId").Visible = False

         .RootTable.Columns("CapitalOrg").Caption = "Capital"
         .RootTable.Columns("CapitalOrg").FormatString = DecimalMask()
         .RootTable.Columns("CapitalOrg").Width = 100
         .RootTable.Columns("CapitalOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("CapitalOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("InteresOrg").Caption = "Interés"
         .RootTable.Columns("InteresOrg").FormatString = DecimalMask()
         .RootTable.Columns("InteresOrg").Width = 100
         .RootTable.Columns("InteresOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("InteresOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteOrg").Caption = "Importe"
         .RootTable.Columns("ImporteOrg").FormatString = DecimalMask()
         .RootTable.Columns("ImporteOrg").Width = 100
         .RootTable.Columns("ImporteOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("CompraNro").Caption = "Nro Compra"
         .RootTable.Columns("CompraNro").Width = 100
         .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CreditoId").Visible = False

         .RootTable.Columns("CreditoDetId").Visible = False

         .RootTable.Columns("CreditoNro").Caption = "Nro Crédito"
         .RootTable.Columns("CreditoNro").Width = 100
         .RootTable.Columns("CreditoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CreditoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CuotaNro").Caption = "Nro. Cuota"
         .RootTable.Columns("CuotaNro").Width = 100
         .RootTable.Columns("CuotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CuotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

#End Region


   Private Sub frmAjusteEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moAjuste.AjusteId
                  mboolChanged = True

                  cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
                  cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

                  If MessageBox.Show("Ajuste Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Ajuste?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     Call PrintReport()
                  End If
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmAjusteEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moAjuste.Dispose()
      moAjusteDet.Dispose()
      Call ClearMemory()
   End Sub

End Class
