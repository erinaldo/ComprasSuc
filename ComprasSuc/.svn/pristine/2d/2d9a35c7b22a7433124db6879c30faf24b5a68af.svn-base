Public Class frmCreditoIniEdit
   Inherits System.Windows.Forms.Form

   Private moCredito As clsCredito
   Private moCreditoDet As clsCreditoDet

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private modtDelete As DataTable
   Private mlngIndexNewCreditoDet As Long

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean

   Private mlngID As Long

#Region " Set and Get "
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

   WriteOnly Property DataObject() As clsCredito
      Set(ByVal Value As clsCredito)
         moCredito = Value
      End Set
   End Property
#End Region

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
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtCreditoDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents chkSinFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents grpSucursal As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtProformaOrden As Janus.Windows.GridEX.EditControls.EditBox
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
   Friend WithEvents grpDatos As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNew As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents SaveTemp As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Compra As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Programar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents txtCapital As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtInteres As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtCreditoNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtCreditoId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents chkProveedor As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents grpCuotas As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboTipoCredito As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents txtInteresAnual As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents dudCantidadCuota As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Anular As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Anular1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditoIniEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpSucursal = New Janus.Windows.EditControls.UIGroupBox
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.lblSucursal = New System.Windows.Forms.Label
      Me.chkSinFac = New Janus.Windows.EditControls.UICheckBox
      Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpCuotas = New Janus.Windows.EditControls.UIGroupBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtCreditoDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtInteresAnual = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.dudCantidadCuota = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.Label9 = New System.Windows.Forms.Label
      Me.cboTipoCredito = New Janus.Windows.EditControls.UIComboBox
      Me.Label17 = New System.Windows.Forms.Label
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtInteres = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtCapital = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.grpDatos = New Janus.Windows.EditControls.UIGroupBox
      Me.lblCentroCosto = New System.Windows.Forms.Label
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.chkProveedor = New Janus.Windows.EditControls.UICheckBox
      Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label4 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label16 = New System.Windows.Forms.Label
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtCreditoNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.txtCreditoId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
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
      Me.Anular1 = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.SaveTemp = New Janus.Windows.UI.CommandBars.UICommand("SaveTemp")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Compra = New Janus.Windows.UI.CommandBars.UICommand("Compra")
      Me.Programar = New Janus.Windows.UI.CommandBars.UICommand("Programar")
      Me.Anular = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtProformaOrden = New Janus.Windows.GridEX.EditControls.EditBox
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpSucursal.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.grpCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpCuotas.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(720, 159)
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
      Me.grdMain.Size = New System.Drawing.Size(720, 159)
      Me.grdMain.TabIndex = 16
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
      Me.bcgMain.Controls.Add(Me.chkSinFac)
      Me.bcgMain.Controls.Add(Me.chkConFac)
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.grpCuotas)
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
      Me.grpSucursal.TabIndex = 10
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
      Me.cboSucursal.Size = New System.Drawing.Size(264, 20)
      Me.cboSucursal.TabIndex = 11
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
      'chkSinFac
      '
      Me.chkSinFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkSinFac.BackColor = System.Drawing.Color.Transparent
      Me.chkSinFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSinFac.Checked = True
      Me.chkSinFac.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkSinFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSinFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkSinFac.Location = New System.Drawing.Point(76, 424)
      Me.chkSinFac.Name = "chkSinFac"
      Me.chkSinFac.Size = New System.Drawing.Size(32, 16)
      Me.chkSinFac.TabIndex = 283
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
      Me.chkConFac.Location = New System.Drawing.Point(128, 424)
      Me.chkConFac.Name = "chkConFac"
      Me.chkConFac.Size = New System.Drawing.Size(32, 16)
      Me.chkConFac.TabIndex = 282
      Me.chkConFac.Text = "F"
      Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup3.Container = True
      ExplorerBarGroup3.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup3.ContainerHeight = 160
      ExplorerBarGroup3.Expandable = False
      ExplorerBarGroup3.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup3})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(8, 216)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(736, 192)
      Me.ebrMain.TabIndex = 16
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'grpCuotas
      '
      Me.grpCuotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpCuotas.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpCuotas.Controls.Add(Me.Label8)
      Me.grpCuotas.Controls.Add(Me.txtProformaOrden)
      Me.grpCuotas.Controls.Add(Me.Label1)
      Me.grpCuotas.Controls.Add(Me.txtCreditoDes)
      Me.grpCuotas.Controls.Add(Me.txtInteresAnual)
      Me.grpCuotas.Controls.Add(Me.Label5)
      Me.grpCuotas.Controls.Add(Me.dudCantidadCuota)
      Me.grpCuotas.Controls.Add(Me.Label9)
      Me.grpCuotas.Controls.Add(Me.cboTipoCredito)
      Me.grpCuotas.Controls.Add(Me.Label17)
      Me.grpCuotas.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpCuotas.Location = New System.Drawing.Point(8, 144)
      Me.grpCuotas.Name = "grpCuotas"
      Me.grpCuotas.Size = New System.Drawing.Size(736, 68)
      Me.grpCuotas.TabIndex = 15
      Me.grpCuotas.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(80, 16)
      Me.Label1.TabIndex = 261
      Me.Label1.Text = "Descripción"
      '
      'txtCreditoDes
      '
      Me.txtCreditoDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCreditoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCreditoDes.Location = New System.Drawing.Point(92, 40)
      Me.txtCreditoDes.MaxLength = 1000
      Me.txtCreditoDes.Multiline = True
      Me.txtCreditoDes.Name = "txtCreditoDes"
      Me.txtCreditoDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtCreditoDes.Size = New System.Drawing.Size(436, 20)
      Me.txtCreditoDes.TabIndex = 14
      Me.txtCreditoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCreditoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtInteresAnual
      '
      Me.txtInteresAnual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtInteresAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtInteresAnual.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtInteresAnual.FormatString = "##,##0.000"
      Me.txtInteresAnual.Location = New System.Drawing.Point(628, 12)
      Me.txtInteresAnual.Name = "txtInteresAnual"
      Me.txtInteresAnual.Size = New System.Drawing.Size(100, 20)
      Me.txtInteresAnual.TabIndex = 13
      Me.txtInteresAnual.Text = "0,000"
      Me.txtInteresAnual.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtInteresAnual.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtInteresAnual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(568, 16)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(56, 16)
      Me.Label5.TabIndex = 259
      Me.Label5.Text = "Int. Anual"
      '
      'dudCantidadCuota
      '
      Me.dudCantidadCuota.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.dudCantidadCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudCantidadCuota.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudCantidadCuota.Location = New System.Drawing.Point(440, 12)
      Me.dudCantidadCuota.Maximum = 50
      Me.dudCantidadCuota.Name = "dudCantidadCuota"
      Me.dudCantidadCuota.ReadOnly = True
      Me.dudCantidadCuota.Size = New System.Drawing.Size(100, 20)
      Me.dudCantidadCuota.TabIndex = 12
      Me.dudCantidadCuota.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudCantidadCuota.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(392, 16)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(44, 16)
      Me.Label9.TabIndex = 258
      Me.Label9.Text = "Cuotas"
      '
      'cboTipoCredito
      '
      Me.cboTipoCredito.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoCredito.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoCredito.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoCredito.Location = New System.Drawing.Point(92, 12)
      Me.cboTipoCredito.Name = "cboTipoCredito"
      Me.cboTipoCredito.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoCredito.Size = New System.Drawing.Size(264, 20)
      Me.cboTipoCredito.TabIndex = 11
      Me.cboTipoCredito.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label17.Location = New System.Drawing.Point(8, 16)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(34, 16)
      Me.Label17.TabIndex = 255
      Me.Label17.Text = "Tipo"
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.Label18)
      Me.UiGroupBox3.Controls.Add(Me.txtImporte)
      Me.UiGroupBox3.Controls.Add(Me.Label14)
      Me.UiGroupBox3.Controls.Add(Me.Label13)
      Me.UiGroupBox3.Controls.Add(Me.txtInteres)
      Me.UiGroupBox3.Controls.Add(Me.txtCapital)
      Me.UiGroupBox3.Controls.Add(Me.Label3)
      Me.UiGroupBox3.Controls.Add(Me.Label2)
      Me.UiGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(8, 408)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(736, 40)
      Me.UiGroupBox3.TabIndex = 17
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(588, 16)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(36, 16)
      Me.Label18.TabIndex = 243
      Me.Label18.Text = "Total"
      '
      'txtImporte
      '
      Me.txtImporte.BackColor = System.Drawing.SystemColors.Info
      Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtImporte.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporte.FormatString = "##,##0.000"
      Me.txtImporte.Location = New System.Drawing.Point(628, 12)
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.ReadOnly = True
      Me.txtImporte.Size = New System.Drawing.Size(100, 20)
      Me.txtImporte.TabIndex = 20
      Me.txtImporte.Text = "0,000"
      Me.txtImporte.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporte.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporte.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(412, 16)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(44, 16)
      Me.Label14.TabIndex = 241
      Me.Label14.Text = "Interés"
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(236, 16)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(44, 16)
      Me.Label13.TabIndex = 240
      Me.Label13.Text = "Capital"
      '
      'txtInteres
      '
      Me.txtInteres.BackColor = System.Drawing.SystemColors.Info
      Me.txtInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtInteres.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtInteres.FormatString = "##,##0.000"
      Me.txtInteres.Location = New System.Drawing.Point(460, 12)
      Me.txtInteres.Name = "txtInteres"
      Me.txtInteres.ReadOnly = True
      Me.txtInteres.Size = New System.Drawing.Size(100, 20)
      Me.txtInteres.TabIndex = 19
      Me.txtInteres.Text = "0,000"
      Me.txtInteres.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtInteres.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtInteres.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCapital
      '
      Me.txtCapital.BackColor = System.Drawing.SystemColors.Info
      Me.txtCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCapital.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCapital.FormatString = "##,##0.000"
      Me.txtCapital.Location = New System.Drawing.Point(284, 12)
      Me.txtCapital.Name = "txtCapital"
      Me.txtCapital.ReadOnly = True
      Me.txtCapital.Size = New System.Drawing.Size(100, 20)
      Me.txtCapital.TabIndex = 18
      Me.txtCapital.Text = "0,000"
      Me.txtCapital.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCapital.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCapital.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(844, 44)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(88, 16)
      Me.Label3.TabIndex = 202
      Me.Label3.Text = "Cantidad Items"
      '
      'Label2
      '
      Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(844, 20)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(88, 16)
      Me.Label2.TabIndex = 200
      Me.Label2.Text = "Total Importe"
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
      Me.grpDatos.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpDatos.Location = New System.Drawing.Point(8, 104)
      Me.grpDatos.Name = "grpDatos"
      Me.grpDatos.Size = New System.Drawing.Size(736, 40)
      Me.grpDatos.TabIndex = 12
      Me.grpDatos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCentroCosto.Location = New System.Drawing.Point(384, 14)
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Size = New System.Drawing.Size(52, 16)
      Me.lblCentroCosto.TabIndex = 248
      Me.lblCentroCosto.Text = "C. C."
      Me.lblCentroCosto.TextAlign = System.Drawing.ContentAlignment.TopRight
      Me.lblCentroCosto.Visible = False
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.WindowFrame
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(440, 12)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(288, 20)
      Me.cboCentroCosto.TabIndex = 14
      Me.cboCentroCosto.Visible = False
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkProveedor
      '
      Me.chkProveedor.BackColor = System.Drawing.Color.Transparent
      Me.chkProveedor.Checked = True
      Me.chkProveedor.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkProveedor.Location = New System.Drawing.Point(72, 16)
      Me.chkProveedor.Name = "chkProveedor"
      Me.chkProveedor.Size = New System.Drawing.Size(16, 16)
      Me.chkProveedor.TabIndex = 6
      Me.chkProveedor.TabStop = False
      Me.chkProveedor.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
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
      Me.cboProveedor.Size = New System.Drawing.Size(264, 20)
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
      Me.Label4.Size = New System.Drawing.Size(64, 16)
      Me.Label4.TabIndex = 242
      Me.Label4.Text = "Proveedor"
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackColor = System.Drawing.Color.WhiteSmoke
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.dtpFechaIni)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.txtCreditoNro)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.txtCreditoId)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(736, 64)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(60, 36)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(100, 20)
      Me.cboEstado.TabIndex = 3
      Me.cboEstado.TabStop = False
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label6.Location = New System.Drawing.Point(8, 40)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(46, 16)
      Me.Label6.TabIndex = 253
      Me.Label6.Text = "Estado"
      '
      'cboMoneda
      '
      Me.cboMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(440, 12)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
      Me.cboMoneda.TabIndex = 8
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label15.Location = New System.Drawing.Point(384, 16)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(52, 16)
      Me.Label15.TabIndex = 246
      Me.Label15.Text = "Moneda"
      '
      'dtpFechaIni
      '
      Me.dtpFechaIni.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaIni.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaIni.DropDownCalendar.Name = ""
      Me.dtpFechaIni.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaIni.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dtpFechaIni.Location = New System.Drawing.Point(256, 12)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(100, 20)
      Me.dtpFechaIni.TabIndex = 2
      Me.dtpFechaIni.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label16
      '
      Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label16.Location = New System.Drawing.Point(208, 16)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(44, 16)
      Me.Label16.TabIndex = 251
      Me.Label16.Text = "Fecha"
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(256, 36)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
      Me.txtTipoCambio.TabIndex = 9
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCreditoNro
      '
      Me.txtCreditoNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCreditoNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCreditoNro.FormatString = "########"
      Me.txtCreditoNro.Location = New System.Drawing.Point(628, 12)
      Me.txtCreditoNro.Name = "txtCreditoNro"
      Me.txtCreditoNro.ReadOnly = True
      Me.txtCreditoNro.Size = New System.Drawing.Size(100, 20)
      Me.txtCreditoNro.TabIndex = 4
      Me.txtCreditoNro.TabStop = False
      Me.txtCreditoNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCreditoNro.Value = 0
      Me.txtCreditoNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtCreditoNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label11
      '
      Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label11.Location = New System.Drawing.Point(200, 40)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(52, 16)
      Me.Label11.TabIndex = 244
      Me.Label11.Text = "T. C."
      Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
      '
      'txtCreditoId
      '
      Me.txtCreditoId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCreditoId.Location = New System.Drawing.Point(60, 12)
      Me.txtCreditoId.Name = "txtCreditoId"
      Me.txtCreditoId.ReadOnly = True
      Me.txtCreditoId.Size = New System.Drawing.Size(100, 20)
      Me.txtCreditoId.TabIndex = 1
      Me.txtCreditoId.TabStop = False
      Me.txtCreditoId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCreditoId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label7.Location = New System.Drawing.Point(36, 16)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(20, 16)
      Me.Label7.TabIndex = 200
      Me.Label7.Text = "ID"
      '
      'Label12
      '
      Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label12.Location = New System.Drawing.Point(572, 16)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(52, 16)
      Me.Label12.TabIndex = 198
      Me.Label12.Text = "Número"
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
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.SaveTemp, Me.Print, Me.Compra, Me.Programar, Me.Anular})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Anular1, Me.Separator2, Me.Print1, Me.Separator3, Me.Exit1})
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
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
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
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Compra
      '
      Me.Compra.ImageIndex = 3
      Me.Compra.Key = "Compra"
      Me.Compra.Name = "Compra"
      Me.Compra.Text = "Compra"
      Me.Compra.ToolTipText = "Cargar Compra"
      '
      'Programar
      '
      Me.Programar.ImageIndex = 8
      Me.Programar.Key = "Programar"
      Me.Programar.Name = "Programar"
      Me.Programar.Text = "Programar"
      '
      'Anular
      '
      Me.Anular.ImageIndex = 2
      Me.Anular.Key = "Anular"
      Me.Anular.Name = "Anular"
      Me.Anular.Text = "Anular"
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
      'Label8
      '
      Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(560, 44)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(64, 16)
      Me.Label8.TabIndex = 265
      Me.Label8.Text = "Nro. Orden"
      '
      'txtProformaOrden
      '
      Me.txtProformaOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtProformaOrden.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtProformaOrden.Location = New System.Drawing.Point(628, 40)
      Me.txtProformaOrden.MaxLength = 50
      Me.txtProformaOrden.Name = "txtProformaOrden"
      Me.txtProformaOrden.Size = New System.Drawing.Size(100, 20)
      Me.txtProformaOrden.TabIndex = 264
      Me.txtProformaOrden.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtProformaOrden.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'frmCreditoIniEdit
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
      Me.Name = "frmCreditoIniEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Saldo Inicial de Proveedor"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpSucursal, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpSucursal.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.grpCuotas, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpCuotas.ResumeLayout(False)
      Me.grpCuotas.PerformLayout()
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
               mlngID = moCredito.CreditoId
               mboolChanged = True
               mboolAdding = False
               mboolEditing = True

               cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

               If MessageBox.Show("Saldo Inicial Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Saldo Inicial?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call PrintReport()
               End If
            End If

         Case "Anular"
            If Not TieneMovimiento() Then
               If MessageBox.Show("¿Realmente Quiere Anular el Saldo Inicial?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  If CreditoAnular() Then
                     mlngID = moCredito.CreditoId
                     mboolChanged = True
                     Me.Close()
                  End If
               End If
            Else
               MessageBox.Show("El Plan de Pago ya Tiene Movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCreditoIniEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCreditoIniEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call ViewComponent()
      Call ComboLoad()

      If Not mboolAdding Then
         Call FormShow()
         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta Saldo Inicial de Proveedor"
         Else
            If moCredito.EstadoId = 12 Then
               Call DataReadOnly()
               Me.Text = "Consulta Saldo Inicial de Proveedor"
            Else
               Call HeaderReadOnly()
               Me.Text = "Editar Saldo Inicial de Proveedor"
            End If
         End If
      Else
         Me.Text = "Nuevo Saldo Inicial de Proveedor"
         Call FormNew()
      End If

      Call SecuritySet(Me, AppExeName)
      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      txtTipoCambio.FormatString = DecimalMask()
      txtInteresAnual.FormatString = DecimalMask()
      txtCapital.FormatString = DecimalMask()
      txtInteres.FormatString = DecimalMask()
      txtImporte.FormatString = DecimalMask()
      mlngIndexNewCreditoDet = -1
      moCreditoDet = New clsCreditoDet(clsAppInfo.ConnectString)
   End Sub

   Private Sub ViewComponent()
      Dim decPosSuc As Decimal = 0
      Dim decPosCC As Decimal = 0

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
      grpCuotas.Location = New System.Drawing.Point(grpCuotas.Location.X, grpCuotas.Location.Y - decPosSuc - decPosCC)
      ebrMain.Location = New System.Drawing.Point(ebrMain.Location.X, ebrMain.Location.Y - decPosSuc - decPosCC)
      ebrMain.Size = New System.Drawing.Size(ebrMain.Width, ebrMain.Height + decPosSuc + decPosCC)
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboEstadoLoad()
      Call cboTipoCreditoLoad()
      Call cboProveedorLoad()
      Call cboCentroCostoLoad()
      Call cboSucursalLoad()
   End Sub

#Region " ComboLoads "
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

   Private Sub cboTipoCreditoLoad()
      Dim oTipoCredito As New clsTipoCredito(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoCredito.Items.Clear()
      Try
         With oTipoCredito
            .SelectFilter = clsTipoCredito.SelectFilters.ListBox
            .OrderByFilter = clsTipoCredito.OrderByFilters.TipoCreditoDes
            If .Open() Then
               Do While .Read()
                  If .TipoCreditoId > 1 Then
                     oItem = New clsListItem(.TipoCreditoId, .TipoCreditoDes)

                     cboTipoCredito.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oTipoCredito.Dispose()
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

            .EmpresaId = moCredito.EmpresaId
            .ProveedorId = moCredito.ProveedorId
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
            .CentroCostoId = moCredito.CentroCostoId
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
            .TipoCompraId = clsTipoCompra.SALDO_INICIAL
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
#End Region

   Private Sub FormNew()
      mboolAdding = True

      dtpFechaIni.Select()
      Call DataClear()
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCredito
         txtCreditoId.Text = ToStr(.CreditoId)
         dtpFechaIni.Text = ToStr(.FechaIni)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         txtCreditoNro.Text = ToStr(.CreditoNro)
         txtProformaOrden.Text = ToStr(.CreditoOrden)
         cboTipoCredito.SelectedIndex = ListFindItem(cboTipoCredito, .TipoCreditoId)
         cboProveedor.Value = ListFindItem(cboProveedor, .ProveedorId)
         txtCreditoDes.Text = ToStr(.CreditoDes)
         dudCantidadCuota.Text = ToStr(.CantidadCuota)
         txtInteresAnual.Text = ToDecStr(.InteresAnual)
         cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

         If Not clsAppInfo.MultipleNro Then
            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If
         Call grdMainLoad()
      End With
      mboolShow = False
   End Sub

   Private Function CreditoAnular() As Boolean
      CreditoAnular = False

      If ProveedorMovAnular(8, moCredito.CreditoId) Then
         If CreditoAnular(moCredito.CreditoId, 12) Then
            CreditoAnular = True
         End If
      End If
   End Function

#Region " Anular "
   Private Function ProveedorMovAnular(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAnular = False
      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.DocumentoId

            .EmpresaId = moCredito.EmpresaId
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

   Private Function CreditoAnular(ByVal lngCreditoId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      CreditoAnular = False
      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               If CreditoDetAnular(.CreditoId, lngEstadoId) Then
                  .FechaIni = ToDate(.FechaIni)
                  .FechaFin = ToDate(.FechaFin)
                  .EstadoId = lngEstadoId
                  If .Update Then
                     CreditoAnular = True
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

   Private Function CreditoDetAnular(ByVal lngCreditoId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)

      CreditoDetAnular = False
      Try
         With oCreditoDet
            .SelectFilter = clsCreditoDet.SelectFilters.All
            .WhereFilter = clsCreditoDet.WhereFilters.CreditoId

            .EmpresaId = moCredito.EmpresaId
            .CreditoId = lngCreditoId
            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .FechaAmo = ToDate(.FechaAmo)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     CreditoDetAnular = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCreditoDet.Dispose()
      End Try
   End Function
#End Region

   Private Sub PrintReport()
      Dim rpt As New rptCreditoEdit
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim strTitulo As String
      Try
         oCredito.SelectFilter = clsCredito.SelectFilters.Report
         oCredito.WhereFilter = clsCredito.WhereFilters.Report
         oCredito.OrderByFilter = clsCredito.OrderByFilters.Report

         oCredito.EmpresaId = moCredito.EmpresaId
         oCredito.CreditoId = moCredito.CreditoId
         If oCredito.Find Then
            rpt.DataSource = oCredito.DataSet.Tables(oCredito.TableName).DefaultView

            rpt.txtFirma.Text = CompraParaFirma(8, moCredito.GestionId, moCredito.SucursalId, strTitulo, lngTipoHojaId)
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
         oCredito.Dispose()
      End Try
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCredito
         txtCreditoId.Text = String.Empty
         dtpFechaIni.Text = ToStr(.FechaIni)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         txtCreditoNro.Text = "0"
         txtProformaOrden.Text = String.Empty
         cboTipoCredito.SelectedIndex = ListFindItem(cboTipoCredito, .TipoCreditoId)
         cboProveedor.Value = Nothing
         txtCreditoDes.Text = String.Empty
         dudCantidadCuota.Text = "0"
         txtInteresAnual.Text = ToDecStr(.InteresAnual)
         cboCentroCosto.SelectedIndex = -1

         If clsAppInfo.SucursalApli Then
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)
            cboSucursal.ReadOnly = False
         Else
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, clsAppInfo.SucursalId)
            cboSucursal.ReadOnly = True
         End If

         If clsAppInfo.MultipleNro Then
            chkConFac.Checked = False
            chkSinFac.Checked = False
         Else
            chkConFac.Checked = False
            chkSinFac.Checked = True

            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

         Call grdMainLoad()
      End With

      cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCreditoId.ReadOnly = True
      dtpFechaIni.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtCreditoNro.ReadOnly = True
      txtProformaOrden.ReadOnly = True
      cboTipoCredito.ReadOnly = True
      dudCantidadCuota.ReadOnly = True
      txtInteresAnual.ReadOnly = True
      cboProveedor.ReadOnly = True
      txtCreditoDes.ReadOnly = True
      cboCentroCosto.ReadOnly = True
      cboSucursal.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub HeaderReadOnly()
      txtCreditoId.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboEstado.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtCreditoNro.ReadOnly = True
      cboProveedor.ReadOnly = True
      cboCentroCosto.ReadOnly = True
      cboSucursal.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False

      If TieneMovimiento() Then
         dtpFechaIni.ReadOnly = True
         cboTipoCredito.ReadOnly = True
         dudCantidadCuota.ReadOnly = True
         txtInteresAnual.ReadOnly = True
      Else
         dtpFechaIni.ReadOnly = False
         cboTipoCredito.ReadOnly = False
         dudCantidadCuota.ReadOnly = False
         txtInteresAnual.ReadOnly = False
      End If
   End Sub

   Private Sub DataMove()
      With moCredito
         If Not mboolAdding Then
            .CreditoId = ToLong(txtCreditoId.Text)

            If moCredito.MontoLiq <> 0 Then
               .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
            ElseIf moCredito.MontoLiq = 0 Then
               cboEstado.SelectedIndex = ListFindItem(cboEstado, 14)
               .EstadoId = 14
            End If
         Else
            .MontoAmo = 0
            .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         End If

         .FechaIni = ToDate(dtpFechaIni.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .CreditoNro = ToLong(txtCreditoNro.Text)
         .CreditoOrden = ToStr(txtProformaOrden.Text)
         .TipoCreditoId = ListPosition(cboTipoCredito, cboTipoCredito.SelectedIndex)
         .CompraId = 0
         .ProveedorId = ListPosition(cboProveedor)
         .CreditoDes = ToStr(txtCreditoDes.Text)
         .MontoLiq = ToDecimal(txtCapital.Text)
         .CantidadCuota = ToLong(dudCantidadCuota.Text)
         .InteresAnual = ToDecimal(txtInteresAnual.Text)
         .MontoCuota = 0
         .InteresAnual = ToDecimal(txtInteresAnual.Text)
         .ConFac = ToBoolean(chkConFac.Checked)
         .SinFac = ToBoolean(chkSinFac.Checked)
         .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
      End With
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

        If FormCheck() And moCredito.Validate And GridCheck() Then
            moCredito.FechaFin = ToDate(moDataSet.Tables(moCreditoDet.TableName).Rows(moDataSet.Tables(moCreditoDet.TableName).Rows.Count - 1).Item("Fecha"))
            If mboolAdding Then
               moCredito.CreditoNro = CompraNroNext(8, clsAppInfo.GestionId, moCredito.SucursalId)

               If DataAdd() Then
                  If grdMainSave() Then
                     txtCreditoId.Text = ToStr(moCredito.CreditoId)
                     txtCreditoNro.Text = ToStr(moCredito.CreditoNro)
                     Call HeaderReadOnly()
                     Call grdMainEstadoShow()

                     If moCredito.MontoLiq > 0 Then
                        If ProveedorMovAdd(8, moCredito.CreditoId, 2, moCredito.MontoLiq, 2, 0, 0, 0) Then
                           DataSave = True
                        End If

                     ElseIf moCredito.MontoLiq < 0 Then
                        If ProveedorMovAdd(8, moCredito.CreditoId, 2, Math.Abs(moCredito.MontoLiq), 1, 0, 0, 0) Then
                           DataSave = True
                        End If
                     End If
                  End If
               End If
            Else
               If DataUpdate() Then
                  If grdMainSave() Then
                     Call grdMainEstadoShow()
                     DataSave = True

                     If moCredito.MontoLiq > 0 Then
                        If ProveedorMovUpdate(8, moCredito.CreditoId, 2, moCredito.MontoLiq) Then
                           DataSave = True
                        End If

                     ElseIf moCredito.MontoLiq < 0 Then
                        If ProveedorMovUpdate(8, moCredito.CreditoId, 1, Math.Abs(moCredito.MontoLiq)) Then
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

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If GestionIdFind(ToDate(dtpFechaIni.Value)) <> clsAppInfo.GestionId Then
         FormCheck = False
         strMsg &= "Fecha no Corresponde a la Gestión en Uso" & vbCrLf
      End If

      If cboMoneda.SelectedIndex = -1 Then
         strMsg &= "Seleccione una Moneda" & vbCrLf
      End If

      If ToDecimal(txtTipoCambio.Text) <= 0 Then
         strMsg &= "Tipo de Cambio Inválido" & vbCrLf
      End If

      If clsAppInfo.SucursalApli Then
         If cboSucursal.SelectedIndex = -1 Then
            strMsg &= "Seleccione una Sucursal" & vbCrLf
         End If
      End If

      If ListPosition(cboProveedor) = 0 Then
         strMsg &= "Seleccione un Proveedor" & vbCrLf
      End If

      If clsAppInfo.CentroCostoApli Then
         If cboCentroCosto.SelectedIndex = -1 Then
            strMsg &= "Seleccione un Centro de Costo" & vbCrLf
         End If
      End If

      If cboTipoCredito.SelectedIndex = -1 Then
         strMsg &= "Seleccione un Tipo de Credito" & vbCrLf
      End If

      If Not chkConFac.Checked And Not chkSinFac.Checked Then
         strMsg &= "Valores Inválidos en (I o F)" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function GridCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim lngCuotaNro As Long = 1
      Dim datFecha As Date = dtpFechaIni.Value

      If moDataSet.Tables(moCreditoDet.TableName).Rows.Count = 0 Then
         strMsg &= "Saldo Inicial Sin Detalle" & vbCrLf
      Else
         For Each oRow In moDataSet.Tables(moCreditoDet.TableName).Rows
            If oRow("CuotaNro") <> lngCuotaNro Then
               strMsg &= "Correlativo de Cuotas Inválido" & vbCrLf
               Exit For
            End If
            If oRow("Fecha").Date < datFecha.Date Then
               strMsg &= "Correlativo de Fechas Inválido" & vbCrLf
               Exit For
            End If
            lngCuotaNro += 1
            datFecha = oRow("Fecha")
         Next
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         GridCheck = False
      Else
         GridCheck = True
      End If
   End Function

   Private Function DataAdd() As Boolean
      DataAdd = False
      Try
         If moCredito.Insert() Then
            DataAdd = True
         End If

      Catch exp As Exception
         Throw exp
      End Try
   End Function

   Private Function DataUpdate() As Boolean
      DataUpdate = False
      Try
         If moCredito.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp
      End Try
   End Function

   Private Sub frmCreditoIniEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moCredito.CreditoId
                  mboolChanged = True
                  mboolAdding = False
                  mboolEditing = True

                  cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

                  If MessageBox.Show("Saldo Inicial Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Saldo Inicial?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     Call PrintReport()
                  End If
               End If
            End If

         ElseIf (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            If mnuNew.Enabled Then
               Call grdMainNew()
            End If

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            If mnuEdit.Enabled Then
               Call grdMainEdit()
            End If

         ElseIf (e.KeyCode = Keys.Delete) And (e.Shift = True) Then
            If mnuDelete.Enabled Then
               Call grdMainDelete()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCreditoIniEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCredito.Dispose()
      moCreditoDet.Dispose()
      Call ClearMemory()
   End Sub

#Region " Otros Metodos "
   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0
      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo

            .EmpresaId = moCredito.EmpresaId
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

   Private Function TieneMovimiento() As Boolean
      TieneMovimiento = False

      For Each oRow As DataRow In moDataSet.Tables(moCreditoDet.TableName).Rows
         If oRow("CapitalAmo") > 0 Or oRow("InteresAmo") > 0 Then
            TieneMovimiento = True
            Exit For
         End If
      Next
   End Function

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      CompraNroNext = 0
      Try
         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId

            .EmpresaId = moCredito.EmpresaId
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

   Private Function CompraParaFirma(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByRef strTitulo As String, ByRef lngTipoHojaId As Long) As String
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      CompraParaFirma = String.Empty
      Try
         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId

            .EmpresaId = moCredito.EmpresaId
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

   Private Sub grdMainEstadoShow()
      For Each oRow In moDataSet.Tables(moCreditoDet.TableName).Rows
         oRow("Estado") = "Show"
      Next
   End Sub

   Private Function ProveedorMovAdd(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal lngTipoPagoId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False
      Try
         With oProveedorMov
            .EmpresaId = moCredito.EmpresaId
            .GestionId = moCredito.GestionId
            .ProveedorId = moCredito.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = ToDate(dtpFechaIni.Value)
            .ProveedorMovDes = ""
            .MonedaId = moCredito.MonedaId
            .TipoCambio = moCredito.TipoCambio
            .CentroCostoId = moCredito.CentroCostoId
            .SucursalId = moCredito.SucursalId
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

            .EmpresaId = moCredito.EmpresaId
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
#End Region

#Region " Otros Eventos "
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

   Private Sub dtpFechaIni_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIni.LostFocus
      If mboolAdding Then
         If Not IsNothing(moCredito) Then
            If dtpFechaIni.Tag <> dtpFechaIni.Text Then
               If IsDate(dtpFechaIni.Text) Then
                  Call txtTipoCambioLoad(ToDate(dtpFechaIni.Value))
                  dtpFechaIni.Tag = dtpFechaIni.Text
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

#Region " DETALLE "
#Region " DataSet "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCreditoDet.TableName)

      moDataTable.Columns.Add("CreditoDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CuotaNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.DateTime"))
      moDataTable.Columns.Add("Capital", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Interes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Importe", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("CapitalAmo", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("InteresAmo", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("FechaAmo", Type.GetType("System.DateTime"))
      moDataTable.Columns.Add("InteresPen", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("EstadoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EstadoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Estado", Type.GetType("System.String"))

      modtDelete = moDataSet.Tables.Add("DataDelete")
      modtDelete.Columns.Add("CreditoDetId", Type.GetType("System.Int32"))
      modtDelete.Columns.Add("Estado", Type.GetType("System.String"))
   End Sub

   Private Function GetRowShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CreditoDetId") = oDataRow("CreditoDetId")
      oRow("CuotaNro") = oDataRow("CuotaNro")
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
      oRow("Capital") = oDataRow("Capital")
      oRow("Interes") = oDataRow("Interes")
      oRow("Importe") = oDataRow("Importe")
      oRow("CapitalAmo") = oDataRow("CapitalAmo")
      oRow("InteresAmo") = oDataRow("InteresAmo")
      oRow("FechaAmo") = ToDateDMY(oDataRow("FechaAmo"))
      oRow("InteresPen") = oDataRow("InteresPen")
      oRow("EstadoId") = oDataRow("EstadoId")
      oRow("EstadoDes") = oDataRow("EstadoDes")
      oRow("Estado") = "Show"

      Return oRow
   End Function

   Private Function GetRowNew(ByVal oCreditoDet As clsCreditoDet, ByVal lngCreditoDetId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CreditoDetId") = lngCreditoDetId
      oRow("CuotaNro") = oCreditoDet.CuotaNro
      oRow("Fecha") = oCreditoDet.Fecha
      oRow("Capital") = oCreditoDet.Capital
      oRow("Interes") = oCreditoDet.Interes
      oRow("Importe") = oCreditoDet.Importe
      oRow("CapitalAmo") = 0
      oRow("InteresAmo") = 0
      oRow("FechaAmo") = ToDateDMY(dtpFechaIni.Value)
      oRow("InteresPen") = oCreditoDet.Interes
      oRow("EstadoId") = oCreditoDet.EstadoId
      oRow("EstadoDes") = EstadoDesFind(oCreditoDet.EstadoId)
      oRow("Estado") = "New"

      Return oRow
   End Function

   Private Sub RowNewEdit(ByRef oRow As DataRow, ByVal oCreditoDet As clsCreditoDet, ByVal strEstado As String)
      Dim strItemCod As String

      oRow("CreditoDetId") = oCreditoDet.CreditoDetId
      oRow("CuotaNro") = oCreditoDet.CuotaNro
      oRow("Fecha") = oCreditoDet.Fecha
      oRow("Capital") = oCreditoDet.Capital
      oRow("Interes") = oCreditoDet.Interes
      oRow("Importe") = oCreditoDet.Importe
      oRow("CapitalAmo") = 0
      oRow("InteresAmo") = 0
      oRow("FechaAmo") = ToDateDMY(dtpFechaIni.Value)
      oRow("InteresPen") = oCreditoDet.Interes
      oRow("EstadoId") = oCreditoDet.EstadoId
      oRow("EstadoDes") = EstadoDesFind(oCreditoDet.EstadoId)
      oRow("Estado") = strEstado
   End Sub

   Private Function GetRowDelete(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = modtDelete.NewRow

      oRow("CreditoDetId") = oDataRow("CreditoDetId")
      oRow("Estado") = "Delete"

      Return oRow
   End Function
#End Region

#Region " Metodo "
   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Fecha"), Janus.Windows.GridEX.ConditionOperator.LessThan, Now.Date)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Fecha"), Janus.Windows.GridEX.ConditionOperator.GreaterThan, Now.Date)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 14)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CreditoDetId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub CuotaTotal()
      txtCapital.Text = ToDecimal(moDataTable.Compute("Sum(Capital)", "CuotaNro > 0"))
      txtInteres.Text = ToDecimal(moDataTable.Compute("Sum(Interes)", "CuotaNro > 0"))
      txtImporte.Text = ToDecimal(moDataTable.Compute("Sum(Importe)", "CuotaNro > 0"))
      dudCantidadCuota.Text = moDataTable.Rows.Count
   End Sub

   Private Function grdMainFindRowId(ByVal lngCreditoDetId As Long) As Integer
      Dim intRow As Long = 0

      For Each oRow As DataRow In moDataSet.Tables(moCreditoDet.TableName).Rows
         If oRow("CreditoDetId") = lngCreditoDetId Then
            Return intRow
         End If

         intRow += 1
      Next

      Return 0
   End Function

   Private Function EstadoDesFind(ByVal lngEstadoId As Long) As String
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)

      EstadoDesFind = String.Empty
      Try
         With oEstado
            .EstadoId = lngEstadoId

            If .FindByPK Then
               EstadoDesFind = .EstadoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oEstado.Dispose()
      End Try
   End Function

   Private Sub CuotaEnumerar()
      Dim lngNro As Long = 0

      For Each oRow In moDataSet.Tables(moCreditoDet.TableName).Rows
         lngNro += 1
         oRow("CuotaNro") = lngNro

         If oRow("Estado") <> "New" Then
            oRow("Estado") = "Edit"
         ElseIf oRow("Estado") = "New" Then
            oRow("Estado") = "New"
         End If
      Next
   End Sub

   Private Function CreditoDetDelete(ByVal lngCreditoDetId As Long) As Boolean
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)

      CreditoDetDelete = False
      Try
         With oCreditoDet
            .WhereFilter = clsCreditoDet.WhereFilters.PrimaryKey

            .CreditoDetId = lngCreditoDetId
            If .Delete Then
               CreditoDetDelete = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCreditoDet.Dispose()
      End Try
   End Function
#End Region

#Region " Grid "
   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Detalle Saldo Inicial"
         .ContextMenu = mnuMain

         .RootTable.Columns("CreditoDetId").Visible = False

         .RootTable.Columns("CuotaNro").Caption = "Cuota"
         .RootTable.Columns("CuotaNro").Width = 80
         .RootTable.Columns("CuotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CuotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Capital").Caption = "Capital"
         .RootTable.Columns("Capital").FormatString = DecimalMask()
         .RootTable.Columns("Capital").Width = 80
         .RootTable.Columns("Capital").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Capital").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Interes").Caption = "Interés"
         .RootTable.Columns("Interes").FormatString = DecimalMask()
         .RootTable.Columns("Interes").Width = 80
         .RootTable.Columns("Interes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Interes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Importe").Caption = "Importe"
         .RootTable.Columns("Importe").FormatString = DecimalMask()
         .RootTable.Columns("Importe").Width = 80
         .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CapitalAmo").Caption = "Capital Amo."
         .RootTable.Columns("CapitalAmo").FormatString = DecimalMask()
         .RootTable.Columns("CapitalAmo").Width = 80
         .RootTable.Columns("CapitalAmo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("CapitalAmo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("InteresAmo").Caption = "Interés Amo."
         .RootTable.Columns("InteresAmo").FormatString = DecimalMask()
         .RootTable.Columns("InteresAmo").Width = 80
         .RootTable.Columns("InteresAmo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("InteresAmo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FechaAmo").Visible = False

         .RootTable.Columns("InteresPen").Visible = False

         .RootTable.Columns("Estado").Visible = False

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 80
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub grdMainLoad()
      Try
         Call moDataSetInit()
         With moCreditoDet
            .SelectFilter = clsCreditoDet.SelectFilters.Grid
            .WhereFilter = clsCreditoDet.WhereFilters.Grid
            .OrderByFilter = clsCreditoDet.OrderByFilters.Grid

            .EmpresaId = moCredito.EmpresaId
            .CreditoId = moCredito.CreditoId
            If .Open() Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRowShow(oRow))
               Next

               grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
            End If

            Call CuotaTotal()
            .CloseConection()
         End With
         Call grdMainInit()
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMain.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If Not TieneMovimiento() Then
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
         Else
            mnuShow.Enabled = True
            mnuNew.Enabled = False
            mnuEdit.Enabled = False
            mnuDelete.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
      Call grdMainNew()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      Call grdMainEdit()
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call grdMainShow()
   End Sub

   Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
      Call grdMainDelete()
   End Sub

   Private Sub grdMainNew()
      Dim frm As New frmCreditoDetEdit
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)
      Try
         Call DataMove()
         If FormCheck() Then
            If moCredito.EstadoId = 15 Then
               With frm
                  .NewRecord = True
                  .Editing = False
                  oCreditoDet.CompraId = ToLong(moCredito.CompraId)
                  oCreditoDet.ProveedorId = ToLong(moCredito.ProveedorId)
                  oCreditoDet.CuotaNro = moDataTable.Rows.Count + 1
                  oCreditoDet.Fecha = ToDateDMY(dtpFechaIni.Value)
                  oCreditoDet.Capital = 0
                  oCreditoDet.Interes = 0
                  .DataObject = oCreditoDet

                  .ShowDialog()
                  If .Changed Then
                     If oCreditoDet.Capital <> 0 Then
                        oCreditoDet.EstadoId = 15
                     ElseIf oCreditoDet.Capital = 0 Then
                        oCreditoDet.EstadoId = 14
                     End If

                     Call DataViewAll()
                     moDataTable.Rows.Add(GetRowNew(frm.DataObject, mlngIndexNewCreditoDet))
                     Call grdMainFindRow(mlngIndexNewCreditoDet)
                     mlngIndexNewCreditoDet -= 1
                     Call CuotaTotal()
                  End If
               End With
            Else
               MessageBox.Show("Imposible Modificar el Saldo Inicial del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCreditoDet.Dispose()
         frm.Dispose()
      End Try
   End Sub

   Private Sub grdMainEdit()
      Dim frm As New frmCreditoDetEdit
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)
      Try
         If FormCheck() Then
            If grdMain.RowCount > 0 And ToStr(grdMain.GetValue("Estado")) <> Nothing Then
               If moCredito.EstadoId = 15 Then
                  Dim strEstado As String = String.Empty
                  With frm
                     .NewRecord = False
                     .Editing = True
                     oCreditoDet.CreditoDetId = ToLong(grdMain.GetValue("CreditoDetId"))
                     'oCreditoDet.EmpresaId
                     'oCreditoDet.GestionId
                     oCreditoDet.CompraId = ToLong(moCredito.CompraId)
                     'oCreditoDet.TipoCreditoId
                     'oCreditoDet.CreditoId
                     oCreditoDet.Fecha = ToDateDMY(grdMain.GetValue("Fecha"))
                     oCreditoDet.ProveedorId = ToLong(moCredito.ProveedorId)
                     'oCreditoDet.MonedaId
                     'oCreditoDet.TipoCambio
                     oCreditoDet.CuotaNro = ToLong(grdMain.GetValue("CuotaNro"))
                     oCreditoDet.Capital = ToDecimal(grdMain.GetValue("Capital"))
                     oCreditoDet.Interes = ToDecimal(grdMain.GetValue("Interes"))
                     oCreditoDet.Importe = ToDecimal(grdMain.GetValue("Importe"))
                     'oCreditoDet.CapitalAmo    0
                     'oCreditoDet.InteresAmo    0
                     'oCreditoDet.FechaAmo      FechaIni
                     'oCreditoDet.InteresPen
                     oCreditoDet.EstadoId = ToDecimal(grdMain.GetValue("EstadoId"))
                     'oCreditoDet.CentroCostoId
                     .DataObject = oCreditoDet

                     .ShowDialog()
                     If .Changed Then
                        Call DataViewAll()

                        If oCreditoDet.Capital <> 0 Then
                           oCreditoDet.EstadoId = 15
                        ElseIf oCreditoDet.Capital = 0 Then
                           oCreditoDet.EstadoId = 14
                        End If
                        If ToStr(grdMain.GetValue("Estado")) <> "New" Then
                           strEstado = "Edit"
                        ElseIf ToStr(grdMain.GetValue("Estado")) = "New" Then
                           strEstado = "New"
                        End If

                        Call RowNewEdit(moDataTable.Rows(grdMainFindRowId(oCreditoDet.CreditoDetId)), frm.DataObject, strEstado)
                        Call CuotaTotal()
                     End If
                  End With
               Else
                  MessageBox.Show("Imposible Modificar el Saldo Inicial del Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCreditoDet.Dispose()
         frm.Dispose()
      End Try
   End Sub

   Private Sub grdMainShow()
      If grdMain.RowCount > 0 And ToStr(grdMain.GetValue("Estado")) <> Nothing Then
         Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)
         Dim frm As New frmCreditoDetEdit
         Try
            With frm
               .NewRecord = False
               .Editing = False
               oCreditoDet.CreditoDetId = ToLong(grdMain.GetValue("CreditoDetId"))
               oCreditoDet.CompraId = ToLong(moCredito.CompraId)
               'oCreditoDet.TipoCreditoId
               'oCreditoDet.CreditoId
               oCreditoDet.Fecha = ToDateDMY(grdMain.GetValue("Fecha"))
               oCreditoDet.ProveedorId = ToLong(moCredito.ProveedorId)
               'oCreditoDet.MonedaId
               'oCreditoDet.TipoCambio
               oCreditoDet.CuotaNro = ToLong(grdMain.GetValue("CuotaNro"))
               oCreditoDet.Capital = ToDecimal(grdMain.GetValue("Capital"))
               oCreditoDet.Interes = ToDecimal(grdMain.GetValue("Interes"))
               oCreditoDet.Importe = ToDecimal(grdMain.GetValue("Importe"))
               'oCreditoDet.CapitalAmo
               'oCreditoDet.InteresAmo
               'oCreditoDet.FechaAmo
               'oCreditoDet.InteresPen
               oCreditoDet.EstadoId = ToDecimal(grdMain.GetValue("EstadoId"))
               'oCreditoDet.CentroCostoId
               .DataObject = oCreditoDet

               .ShowDialog()
            End With
         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Finally
            oCreditoDet.Dispose()
            frm.Dispose()
         End Try
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub grdMainDelete()
      If grdMain.RowCount > 0 And ToStr(grdMain.GetValue("Estado")) <> Nothing Then
         If moCredito.EstadoId = 15 Then
            If MessageBox.Show("¿Realmente Quiere Eliminar el Registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               Call DataViewAll()

               If ToStr(grdMain.GetValue("Estado")) <> "New" Then
                  modtDelete.Rows.Add(GetRowDelete(moDataTable.Rows.Item(grdMain.Row)))
               End If
               moDataTable.Rows.RemoveAt(grdMain.Row)
               grdMain.RetrieveStructure()
               Call grdMainInit()

               Call CuotaEnumerar()
               Call CuotaTotal()
            End If
         Else
            MessageBox.Show("Imposible Modificar el Saldo Inicial de Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub grdMainMove(ByRef oRow As DataRow)
      With moCreditoDet
         .CreditoDetId = ToLong(oRow("CreditoDetId"))
         .EmpresaId = ToLong(moCredito.EmpresaId)
         .GestionId = ToLong(moCredito.GestionId)
         .CompraId = ToLong(moCredito.CompraId)
         .TipoCreditoId = ToLong(moCredito.TipoCreditoId)
         .CreditoId = ToLong(moCredito.CreditoId)
         .Fecha = ToDate(oRow("Fecha"))
         .ProveedorId = ToLong(moCredito.ProveedorId)
         .MonedaId = ToLong(moCredito.MonedaId)
         .TipoCambio = ToDecimal(moCredito.TipoCambio)
         .CuotaNro = ToLong(oRow("CuotaNro"))
         .Capital = ToDecimal(oRow("Capital"))
         .Interes = ToDecimal(oRow("Interes"))
         .Importe = ToDecimal(oRow("Importe"))
         .CapitalAmo = ToDecimal(oRow("CapitalAmo"))
         .InteresAmo = ToDecimal(oRow("InteresAmo"))
         .FechaAmo = ToDate(oRow("FechaAmo"))
         .InteresPen = ToDecimal(oRow("InteresPen"))
         .EstadoId = ToLong(oRow("EstadoId"))
         .CentroCostoId = ToLong(moCredito.CentroCostoId)
         .SucursalId = ToLong(moCredito.SucursalId)
      End With
   End Sub

   Private Function grdMainSave() As Boolean
      grdMainSave = True
      Try
         For Each oRow In moDataSet.Tables("DataDelete").Rows
            If ToStr(oRow("Estado")) = "Delete" Then
               If CreditoDetDelete(oRow("CreditoDetId")) Then
               End If
            End If
         Next

         For Each oRow In moDataSet.Tables(moCreditoDet.TableName).Rows
            Call grdMainMove(oRow)

            If ToStr(oRow("Estado")) = "New" Then
               If moCreditoDet.Insert() Then
                  oRow("CreditoDetId") = moCreditoDet.CreditoDetId
                  Call moCreditoDet.CloseConection()
               End If
            ElseIf ToStr(oRow("Estado")) = "Edit" Then
               If moCreditoDet.Update() Then
                  Call moCreditoDet.CloseConection()
               End If
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End Try
   End Function

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub
#End Region
#End Region
End Class
