Public Class frmContadoPagoEdit
   Inherits System.Windows.Forms.Form

   Private moCompra As clsCompra
   Private mlngCreditoId As Long

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditGrid As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean

   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long

   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents chkPorFecha As Janus.Windows.EditControls.UICheckBox
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
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
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
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Venta As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Programar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents txtImporteBs As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtImporteUs As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtMontoPagUs As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoPagBs As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtProveedorDes As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContadoPagoEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtMontoPagUs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtMontoPagBs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtImporteUs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtImporteBs = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label16 = New System.Windows.Forms.Label
      Me.txtProveedorDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label4 = New System.Windows.Forms.Label
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
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.SaveTemp = New Janus.Windows.UI.CommandBars.UICommand("SaveTemp")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Venta = New Janus.Windows.UI.CommandBars.UICommand("Venta")
      Me.Programar = New Janus.Windows.UI.CommandBars.UICommand("Programar")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.chkPorFecha = New Janus.Windows.EditControls.UICheckBox
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 267)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 267)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.bcgMain.Size = New System.Drawing.Size(752, 414)
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
      ExplorerBarGroup1.ContainerHeight = 268
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 44)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 300)
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
      Me.UiGroupBox3.Controls.Add(Me.Label7)
      Me.UiGroupBox3.Controls.Add(Me.txtMontoPagUs)
      Me.UiGroupBox3.Controls.Add(Me.Label8)
      Me.UiGroupBox3.Controls.Add(Me.txtMontoPagBs)
      Me.UiGroupBox3.Controls.Add(Me.Label1)
      Me.UiGroupBox3.Controls.Add(Me.txtImporteUs)
      Me.UiGroupBox3.Controls.Add(Me.Label18)
      Me.UiGroupBox3.Controls.Add(Me.txtImporteBs)
      Me.UiGroupBox3.Controls.Add(Me.Label3)
      Me.UiGroupBox3.Controls.Add(Me.Label2)
      Me.UiGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(8, 342)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(736, 64)
      Me.UiGroupBox3.TabIndex = 6
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(524, 40)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(100, 16)
      Me.Label7.TabIndex = 253
      Me.Label7.Text = "Monto a Pagar Us"
      '
      'txtMontoPagUs
      '
      Me.txtMontoPagUs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoPagUs.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoPagUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPagUs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPagUs.FormatString = "##,##0.000"
      Me.txtMontoPagUs.Location = New System.Drawing.Point(628, 36)
      Me.txtMontoPagUs.Name = "txtMontoPagUs"
      Me.txtMontoPagUs.ReadOnly = True
      Me.txtMontoPagUs.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoPagUs.TabIndex = 14
      Me.txtMontoPagUs.Text = "0,000"
      Me.txtMontoPagUs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPagUs.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPagUs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(524, 16)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(100, 16)
      Me.Label8.TabIndex = 251
      Me.Label8.Text = "Monto a Pagar Bs"
      '
      'txtMontoPagBs
      '
      Me.txtMontoPagBs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoPagBs.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoPagBs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPagBs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPagBs.FormatString = "##,##0.000"
      Me.txtMontoPagBs.Location = New System.Drawing.Point(628, 12)
      Me.txtMontoPagBs.Name = "txtMontoPagBs"
      Me.txtMontoPagBs.ReadOnly = True
      Me.txtMontoPagBs.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoPagBs.TabIndex = 10
      Me.txtMontoPagBs.Text = "0,000"
      Me.txtMontoPagBs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPagBs.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPagBs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(352, 40)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(48, 16)
      Me.Label1.TabIndex = 249
      Me.Label1.Text = "Total Us"
      '
      'txtImporteUs
      '
      Me.txtImporteUs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtImporteUs.BackColor = System.Drawing.SystemColors.Info
      Me.txtImporteUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtImporteUs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporteUs.FormatString = "##,##0.000"
      Me.txtImporteUs.Location = New System.Drawing.Point(404, 36)
      Me.txtImporteUs.Name = "txtImporteUs"
      Me.txtImporteUs.ReadOnly = True
      Me.txtImporteUs.Size = New System.Drawing.Size(100, 20)
      Me.txtImporteUs.TabIndex = 13
      Me.txtImporteUs.Text = "0,000"
      Me.txtImporteUs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporteUs.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporteUs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label18
      '
      Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(352, 16)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(48, 16)
      Me.Label18.TabIndex = 243
      Me.Label18.Text = "Total Bs"
      '
      'txtImporteBs
      '
      Me.txtImporteBs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtImporteBs.BackColor = System.Drawing.SystemColors.Info
      Me.txtImporteBs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtImporteBs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporteBs.FormatString = "##,##0.000"
      Me.txtImporteBs.Location = New System.Drawing.Point(404, 12)
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
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.chkPorFecha)
      Me.UiGroupBox1.Controls.Add(Me.txtTipoCambio)
      Me.UiGroupBox1.Controls.Add(Me.Label11)
      Me.UiGroupBox1.Controls.Add(Me.dtpFecha)
      Me.UiGroupBox1.Controls.Add(Me.Label16)
      Me.UiGroupBox1.Controls.Add(Me.txtProveedorDes)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 0)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(736, 40)
      Me.UiGroupBox1.TabIndex = 0
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(628, 12)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
      Me.txtTipoCambio.TabIndex = 3
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
      Me.Label11.Location = New System.Drawing.Point(548, 16)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(76, 16)
      Me.Label11.TabIndex = 253
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
      Me.dtpFecha.Location = New System.Drawing.Point(436, 12)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
      Me.dtpFecha.TabIndex = 2
      Me.dtpFecha.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label16
      '
      Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label16.Location = New System.Drawing.Point(376, 16)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(44, 16)
      Me.Label16.TabIndex = 251
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
      Me.txtProveedorDes.Size = New System.Drawing.Size(296, 20)
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
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.SaveTemp, Me.Print, Me.Venta, Me.Programar})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(258, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.ImageIndex = 9
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      Me.Save1.Text = "Realizar Pago"
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
      'Programar
      '
      Me.Programar.ImageIndex = 8
      Me.Programar.Key = "Programar"
      Me.Programar.Name = "Programar"
      Me.Programar.Text = "Programar"
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
      Me.ilsMain.Images.SetKeyName(9, "")
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
      'chkPorFecha
      '
      Me.chkPorFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkPorFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkPorFecha.Location = New System.Drawing.Point(420, 16)
      Me.chkPorFecha.Name = "chkPorFecha"
      Me.chkPorFecha.Size = New System.Drawing.Size(16, 16)
      Me.chkPorFecha.TabIndex = 263
      Me.chkPorFecha.ToolTipText = "Filtrar Compras menor a la Fecha"
      Me.chkPorFecha.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'frmContadoPagoEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MinimizeBox = False
      Me.Name = "frmContadoPagoEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Pago de Notas al Contado"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
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
               mlngID = moCompra.ProveedorId
               mboolChanged = True
               Call grdMainLoad()
               'Me.Close()
            End If

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmContadoPagoEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmContadoPagoEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

#Region " Cabecera "

   Private Sub FormShow()
      mboolShow = True

      With moCompra
         Call ProveedorLoad(.ProveedorId)
         dtpFecha.Text = ToDateDMY(Now.Date)
      End With

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True

      With moCompra
         Call ProveedorLoad(.ProveedorId)
         dtpFecha.Text = ToDateDMY(Now.Date)
      End With

      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCompra
         If Not mboolAdding Then

         End If

      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      dtpFecha.Select()
   End Sub

   Private Function GetDataTableCheck(ByVal oDataSetOrg As DataSet) As DataTable
      Dim oDataTable As DataTable
      Dim oRow As DataRow

      oDataTable = oDataSetOrg.Tables(moCompra.TableName).Clone

      For Each oRowMain As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRowMain.Cells("Sel").Value Then
            oRow = oDataTable.NewRow

            For i = 0 To oRowMain.Cells.Count - 1
               oRow(i) = oRowMain.Cells(i).Value
            Next

            oDataTable.Rows.Add(oRow)
         End If
      Next

      Return oDataTable
   End Function

   Private Function DataSave() As Boolean
      Dim frm As New frmContadoPagoDetEdit
      Dim oPago As New clsPago(clsAppInfo.ConnectString)

      Try
         If FormCheck() Then
            If GridCheck() Then
               With frm
                  .NewRecord = True
                  .Editing = False

                  oPago.EmpresaId = moCompra.EmpresaId
                  oPago.GestionId = clsAppInfo.GestionId
                  oPago.TipoPagoId = 1 'Contado
                  oPago.ProveedorId = moCompra.ProveedorId
                  oPago.Fecha = ToDateDMY(dtpFecha.Value)
                  oPago.MonedaId = grdMainMonedaId()
                  oPago.TipoCambio = ToDecimal(txtTipoCambio.Text)
                  oPago.AppId = clsAppInfo.AppId

                  .SinFac = mboolSinFac
                  .ConFac = mboolConFac

                  oPago.CentroCostoId = 0
                  If clsAppInfo.CentroCostoApli Then
                     oPago.CentroCostoId = mlngCentroCostoId
                  End If

                  oPago.SucursalId = clsAppInfo.SucursalId
                  If clsAppInfo.SucursalApli Then
                     oPago.SucursalId = mlngSucursalId
                  End If

                  .PagoDataTable = GetDataTableCheck(moCompra.DataSet)
                  .DataObject = oPago
                  .ShowDialog()

                  If .Changed Then
                     'Call grdMainLoad()
                     mboolChanged = True
                     DataSave = True

                  End If
                  frm.Dispose()
               End With
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

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

   Private Function GridCheck() As Boolean
      If grdMain.RowCount > 0 Then
         Dim strMsg As String = String.Empty
         Dim boolFirt As Boolean

         If (ToDecimal(txtMontoPagBs.Text) <= 0) And (ToDecimal(txtMontoPagUs.Text) <= 0) Then
            GridCheck = False
            Throw New Exception("Debe Seleccionar la(s) Nota(s) de Compra a Pagar")
         End If

         boolFirt = True

         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If boolFirt Then
               mboolSinFac = oRow.Cells("SinFac").Value
               mboolConFac = oRow.Cells("ConFac").Value
               mlngCentroCostoId = ToLong(oRow.Cells("CentroCostoId").Value)
               mlngSucursalId = ToLong(oRow.Cells("SucursalId").Value)

               boolFirt = False
            Else
               If (oRow.Cells("SinFac").Value <> mboolSinFac) Or (oRow.Cells("ConFac").Value <> mboolConFac) Then
                  GridCheck = False
                  Throw New Exception("No puede ser diferente (I y F) de las Compras")
               End If

               If clsAppInfo.CentroCostoApli Then
                  If (ToLong(oRow.Cells("CentroCostoId").Value) <> mlngCentroCostoId) Then
                     GridCheck = False
                     Throw New Exception("Debe Seleccionar Compras de un mismo Centro de Costo")
                  End If
               End If

               If clsAppInfo.SucursalApli Then
                  If (ToLong(oRow.Cells("SucursalId").Value) <> mlngSucursalId) Then
                     GridCheck = False
                     Throw New Exception("Debe Seleccionar Compras de una misma Sucursal")
                  End If
               End If

            End If

            If dtpFecha.Value < oRow.Cells("Fecha").Value Then
               GridCheck = False
               Throw New Exception("Debe Seleccionar Compras con Fecha Menor a la Fecha Establecida ")
            End If

         Next

         If strMsg.Trim <> String.Empty Then
            Throw New Exception(strMsg)
            GridCheck = False
         Else
            GridCheck = True
         End If
      Else
         MessageBox.Show("Debe Seleccionar al menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
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

   Private Function grdMainMonedaId() As Long
      Dim boolFind As Boolean = False
      Dim lngMonedaId As Long

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
         If Not boolFind Then
            lngMonedaId = ToLong(oRow.Cells("MonedaId").Value)
            boolFind = True
         End If

         If lngMonedaId <> ToLong(oRow.Cells("MonedaId").Value) Then
            Return clsAppInfo.MonedaId
         End If
      Next

      Return lngMonedaId
   End Function

   Private Sub FormInit()
      Call FormCenterChild(Me)

      txtTipoCambio.FormatString = DecimalMask()
      txtImporteBs.FormatString = DecimalMask()
      txtImporteUs.FormatString = DecimalMask()
      txtMontoPagBs.FormatString = DecimalMask()
      txtMontoPagUs.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()

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
      Dim rpt As New rptContadoPagoEdit

      rpt.DataSource = GetDataView(moCompra.DataSet.Tables(moCompra.TableName))

      rpt.lblTitle.Text = "Pago de Notas al Contado : " & ToStr(txtProveedorDes.Text)
      rpt.Document.Name = "Pago de Notas al Contado"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.txtFechaPago.Text = dtpFecha.Text

      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As frmReportPreview
      frm = New frmReportPreview(rpt.Document)
      frm.Show()
   End Sub

   Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
      If Not IsNothing(moCompra) Then
         If dtpFecha.Tag <> dtpFecha.Text Then
            If IsDate(dtpFecha.Text) Then
               Call txtTipoCambioLoad(ToDate(dtpFecha.Value))
               Call grdMainLoad()
               dtpFecha.Tag = dtpFecha.Text
            Else
               txtTipoCambio.Text = 0
            End If
         End If
      End If
   End Sub

   Private Sub chkPorFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPorFecha.CheckedChanged
      If Not IsNothing(moCompra) Then
         Call grdMainLoad()
      End If
   End Sub

#End Region

#Region " Detalle "

   Private Sub grdMainLoad()
      Try
         With moCompra
            .SelectFilter = clsCompra.SelectFilters.GridContado
            .WhereFilter = clsCompra.WhereFilters.GridContado
            .OrderByFilter = clsCompra.OrderByFilters.GridContado
            .EmpresaId = moCompra.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .ProveedorId = moCompra.ProveedorId
            .TipoPagoId = 1
            .EstadoId = 13

            If chkPorFecha.Checked Then
               .Fecha = ToDate(dtpFecha.Value)
            Else
               .Fecha = ""
            End If

            If .Open() Then
               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            Call CompraTotal()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub CompraTotal()
      Dim decImporteBs As Decimal = 0
      Dim decImporteUs As Decimal = 0

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("MonedaId").Value = 1 Then
            decImporteBs += oRow.Cells("MontoLiq").Value

         ElseIf oRow.Cells("MonedaId").Value = 2 Then
            decImporteUs += oRow.Cells("MontoLiq").Value
         End If
      Next

      txtImporteBs.Text = decImporteBs
      txtImporteUs.Text = decImporteUs
      txtMontoPagBs.Text = "0"
      txtMontoPagUs.Text = "0"
   End Sub

   Private Sub MontoPagar()
      Dim decMontoLiqBs As Decimal = 0
      Dim decMontoLiqUs As Decimal = 0

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
         If oRow.Cells("MonedaId").Value = 1 Then
            decMontoLiqBs += ToDecimal(oRow.Cells("MontoLiq").Value)

         ElseIf oRow.Cells("MonedaId").Value = 2 Then
            decMontoLiqUs += ToDecimal(oRow.Cells("MontoLiq").Value)
         End If
      Next

      txtMontoPagBs.Text = decMontoLiqBs
      txtMontoPagUs.Text = decMontoLiqUs
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CuotaNro")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Detalle Pago de Notas al Contado"
         .ContextMenu = mnuMain

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         If Not mboolAdding Then
            .RootTable.Columns("Sel").Visible = False
         End If
         .RootTable.Columns("CompraId").Visible = False

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

         .RootTable.Columns("CompraNro").Caption = "Compra"
         .RootTable.Columns("CompraNro").Width = 80
         .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraOrden").Caption = "Nro. Orden"
         .RootTable.Columns("CompraOrden").Width = 80
         .RootTable.Columns("CompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

         .RootTable.Columns("MontoOrg").Caption = "Total Compra"
         .RootTable.Columns("MontoOrg").FormatString = DecimalMask()
         .RootTable.Columns("MontoOrg").Width = 80
         .RootTable.Columns("MontoOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoNet").Caption = "Total Costo"
         .RootTable.Columns("MontoNet").FormatString = DecimalMask()
         .RootTable.Columns("MontoNet").Width = 80
         .RootTable.Columns("MontoNet").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoNet").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoBru").Visible = False

         .RootTable.Columns("MontoLiq").Caption = "Líquido Pag."
         .RootTable.Columns("MontoLiq").FormatString = DecimalMask()
         .RootTable.Columns("MontoLiq").Width = 80
         .RootTable.Columns("MontoLiq").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoLiq").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoAnt").Caption = "Anticipo"
         .RootTable.Columns("MontoAnt").FormatString = DecimalMask()
         .RootTable.Columns("MontoAnt").Width = 80
         .RootTable.Columns("MontoAnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoAnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoDes").Caption = "Descuento"
         .RootTable.Columns("MontoDes").FormatString = DecimalMask()
         .RootTable.Columns("MontoDes").Width = 80
         .RootTable.Columns("MontoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoRec").Caption = "Recargo"
         .RootTable.Columns("MontoRec").FormatString = DecimalMask()
         .RootTable.Columns("MontoRec").Width = 80
         .RootTable.Columns("MontoRec").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoRec").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoOtro").Caption = "Otros Costos"
         .RootTable.Columns("MontoOtro").FormatString = DecimalMask()
         .RootTable.Columns("MontoOtro").Width = 80
         .RootTable.Columns("MontoOtro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoOtro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCambio").Caption = "Tipo Cambio"
         .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
         .RootTable.Columns("TipoCambio").Width = 80
         .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PedCompraId").Visible = False

         .RootTable.Columns("PedCompraNro").Caption = "Nro Pedido"
         .RootTable.Columns("PedCompraNro").Width = 80
         .RootTable.Columns("PedCompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PedCompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SinFac").Caption = "I"
         .RootTable.Columns("SinFac").Width = 50
         .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ConFac").Caption = "F"
         .RootTable.Columns("ConFac").Width = 50
         .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 80
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Fecha"), Janus.Windows.GridEX.ConditionOperator.LessThan, dtpFecha.Value)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Fecha"), Janus.Windows.GridEX.ConditionOperator.GreaterThan, dtpFecha.Value)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Fecha"), Janus.Windows.GridEX.ConditionOperator.Equal, dtpFecha.Value)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMain_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdMain.RowCheckStateChanged
      Call MontoPagar()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

#End Region

   Private Sub frmContadoPagoEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moCompra.ProveedorId
               mboolChanged = True
               Call grdMainLoad()
               'Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmContadoPagoEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompra.Dispose()
      Call ClearMemory()
   End Sub

End Class
