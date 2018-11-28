Public Class frmPagoEdit
   Inherits System.Windows.Forms.Form

   Private moPago As clsPago
   Private moPagoDet As clsPagoDet

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditGrid As Boolean
   
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

    WriteOnly Property DataObject() As clsPago
        Set(ByVal Value As clsPago)
            moPago = Value
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
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMontoAntPag As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents chkSinFac As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
    Friend WithEvents grpSucursal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
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
    Friend WithEvents txtPagoDes As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtPagoNro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtPagoId As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents chkProveedor As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents grpRecargo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMontoPag As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtInteres As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtCapital As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboPlanRecargo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtMontoRec As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMontoDes As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboPlanDescuento As Janus.Windows.EditControls.UIComboBox
    Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents cboTipoPago As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Anular1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagoEdit))
        Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
        Me.grdMain = New Janus.Windows.GridEX.GridEX
        Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
        Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.grpRecargo = New Janus.Windows.EditControls.UIGroupBox
        Me.txtMontoDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboPlanDescuento = New Janus.Windows.EditControls.UIComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMontoRec = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboPlanRecargo = New Janus.Windows.EditControls.UIComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.chkSinFac = New Janus.Windows.EditControls.UICheckBox
        Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMontoAntPag = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtCapital = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtInteres = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMontoPag = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpDatos = New Janus.Windows.EditControls.UIGroupBox
        Me.lblCentroCosto = New System.Windows.Forms.Label
        Me.chkProveedor = New Janus.Windows.EditControls.UICheckBox
        Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPagoDes = New Janus.Windows.GridEX.EditControls.EditBox
        Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
        Me.cboTipoPago = New Janus.Windows.EditControls.UIComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
        Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
        Me.txtPagoNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtPagoId = New Janus.Windows.GridEX.EditControls.EditBox
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
        Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
        Me.grpSucursal = New Janus.Windows.EditControls.UIGroupBox
        Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.ExplorerBarContainerControl4.SuspendLayout()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bcgMain.SuspendLayout()
        CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ebrMain.SuspendLayout()
        CType(Me.grpRecargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRecargo.SuspendLayout()
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
        Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(720, 139)
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
        Me.grdMain.Size = New System.Drawing.Size(720, 139)
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
        Me.bcgMain.Controls.Add(Me.grpRecargo)
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
        ExplorerBarGroup2.Container = True
        ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl4
        ExplorerBarGroup2.ContainerHeight = 140
        ExplorerBarGroup2.Expandable = False
        ExplorerBarGroup2.Key = "Group1"
        Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
        Me.ebrMain.GroupSeparation = 4
        Me.ebrMain.Location = New System.Drawing.Point(8, 236)
        Me.ebrMain.Name = "ebrMain"
        Me.ebrMain.Size = New System.Drawing.Size(736, 172)
        Me.ebrMain.TabIndex = 20
        Me.ebrMain.Text = "ExplorerBar2"
        Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
        Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        '
        'grpRecargo
        '
        Me.grpRecargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRecargo.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grpRecargo.Controls.Add(Me.txtMontoDes)
        Me.grpRecargo.Controls.Add(Me.Label8)
        Me.grpRecargo.Controls.Add(Me.cboPlanDescuento)
        Me.grpRecargo.Controls.Add(Me.Label10)
        Me.grpRecargo.Controls.Add(Me.txtMontoRec)
        Me.grpRecargo.Controls.Add(Me.Label5)
        Me.grpRecargo.Controls.Add(Me.cboPlanRecargo)
        Me.grpRecargo.Controls.Add(Me.Label9)
        Me.grpRecargo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpRecargo.Location = New System.Drawing.Point(8, 168)
        Me.grpRecargo.Name = "grpRecargo"
        Me.grpRecargo.Size = New System.Drawing.Size(736, 64)
        Me.grpRecargo.TabIndex = 12
        Me.grpRecargo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'txtMontoDes
        '
        Me.txtMontoDes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMontoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMontoDes.FormatString = "##,##0.000"
        Me.txtMontoDes.Location = New System.Drawing.Point(452, 36)
        Me.txtMontoDes.Name = "txtMontoDes"
        Me.txtMontoDes.ReadOnly = True
        Me.txtMontoDes.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoDes.TabIndex = 16
        Me.txtMontoDes.Text = "0,000"
        Me.txtMontoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtMontoDes.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtMontoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(408, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 216
        Me.Label8.Text = "Monto"
        '
        'cboPlanDescuento
        '
        Me.cboPlanDescuento.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanDescuento.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanDescuento.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanDescuento.Location = New System.Drawing.Point(92, 36)
        Me.cboPlanDescuento.Name = "cboPlanDescuento"
        Me.cboPlanDescuento.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboPlanDescuento.Size = New System.Drawing.Size(256, 20)
        Me.cboPlanDescuento.TabIndex = 15
        Me.cboPlanDescuento.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(8, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 214
        Me.Label10.Text = "Descuento"
        '
        'txtMontoRec
        '
        Me.txtMontoRec.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMontoRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoRec.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMontoRec.FormatString = "##,##0.000"
        Me.txtMontoRec.Location = New System.Drawing.Point(452, 12)
        Me.txtMontoRec.Name = "txtMontoRec"
        Me.txtMontoRec.ReadOnly = True
        Me.txtMontoRec.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoRec.TabIndex = 14
        Me.txtMontoRec.Text = "0,000"
        Me.txtMontoRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtMontoRec.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtMontoRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 212
        Me.Label5.Text = "Monto"
        '
        'cboPlanRecargo
        '
        Me.cboPlanRecargo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanRecargo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanRecargo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanRecargo.Location = New System.Drawing.Point(92, 12)
        Me.cboPlanRecargo.Name = "cboPlanRecargo"
        Me.cboPlanRecargo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboPlanRecargo.Size = New System.Drawing.Size(256, 20)
        Me.cboPlanRecargo.TabIndex = 13
        Me.cboPlanRecargo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 210
        Me.Label9.Text = "Recargo"
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.UiGroupBox3.Controls.Add(Me.chkSinFac)
        Me.UiGroupBox3.Controls.Add(Me.chkConFac)
        Me.UiGroupBox3.Controls.Add(Me.Label17)
        Me.UiGroupBox3.Controls.Add(Me.txtMontoAntPag)
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
        Me.chkConFac.Location = New System.Drawing.Point(52, 12)
        Me.chkConFac.Name = "chkConFac"
        Me.chkConFac.Size = New System.Drawing.Size(32, 16)
        Me.chkConFac.TabIndex = 278
        Me.chkConFac.Text = "F"
        Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(396, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 273
        Me.Label17.Text = "Anticipo"
        '
        'txtMontoAntPag
        '
        Me.txtMontoAntPag.BackColor = System.Drawing.SystemColors.Info
        Me.txtMontoAntPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoAntPag.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMontoAntPag.FormatString = "##,##0.000"
        Me.txtMontoAntPag.Location = New System.Drawing.Point(452, 14)
        Me.txtMontoAntPag.Name = "txtMontoAntPag"
        Me.txtMontoAntPag.ReadOnly = True
        Me.txtMontoAntPag.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoAntPag.TabIndex = 272
        Me.txtMontoAntPag.Text = "0,000"
        Me.txtMontoAntPag.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtMontoAntPag.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtMontoAntPag.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtCapital
        '
        Me.txtCapital.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCapital.BackColor = System.Drawing.SystemColors.Info
        Me.txtCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapital.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCapital.FormatString = "##,##0.000"
        Me.txtCapital.Location = New System.Drawing.Point(132, 16)
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
        Me.Label13.Location = New System.Drawing.Point(88, 20)
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
        Me.txtInteres.Location = New System.Drawing.Point(280, 16)
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
        Me.Label3.Location = New System.Drawing.Point(236, 20)
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
        Me.grpDatos.Controls.Add(Me.cboCentroCosto)
        Me.grpDatos.Controls.Add(Me.lblCentroCosto)
        Me.grpDatos.Controls.Add(Me.chkProveedor)
        Me.grpDatos.Controls.Add(Me.cboProveedor)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.txtPagoDes)
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
        Me.lblCentroCosto.Size = New System.Drawing.Size(44, 16)
        Me.lblCentroCosto.TabIndex = 237
        Me.lblCentroCosto.Text = "C. C."
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
        'txtPagoDes
        '
        Me.txtPagoDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPagoDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPagoDes.Location = New System.Drawing.Point(92, 36)
        Me.txtPagoDes.MaxLength = 1000
        Me.txtPagoDes.Multiline = True
        Me.txtPagoDes.Name = "txtPagoDes"
        Me.txtPagoDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPagoDes.Size = New System.Drawing.Size(636, 20)
        Me.txtPagoDes.TabIndex = 11
        Me.txtPagoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtPagoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grpMain.Controls.Add(Me.cboTipoPago)
        Me.grpMain.Controls.Add(Me.Label14)
        Me.grpMain.Controls.Add(Me.dtpFecha)
        Me.grpMain.Controls.Add(Me.cboEstado)
        Me.grpMain.Controls.Add(Me.cboMoneda)
        Me.grpMain.Controls.Add(Me.txtPagoNro)
        Me.grpMain.Controls.Add(Me.txtTipoCambio)
        Me.grpMain.Controls.Add(Me.txtPagoId)
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
        'cboTipoPago
        '
        Me.cboTipoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoPago.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboTipoPago.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboTipoPago.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboTipoPago.Location = New System.Drawing.Point(628, 36)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboTipoPago.Size = New System.Drawing.Size(100, 20)
        Me.cboTipoPago.TabIndex = 7
        Me.cboTipoPago.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(552, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 205
        Me.Label14.Text = "Tipo Compra"
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
        Me.dtpFecha.Location = New System.Drawing.Point(232, 12)
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
        Me.cboEstado.Location = New System.Drawing.Point(232, 36)
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
        Me.cboMoneda.Location = New System.Drawing.Point(436, 12)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
        Me.cboMoneda.TabIndex = 3
        Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'txtPagoNro
        '
        Me.txtPagoNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPagoNro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPagoNro.FormatString = "########"
        Me.txtPagoNro.Location = New System.Drawing.Point(628, 12)
        Me.txtPagoNro.Name = "txtPagoNro"
        Me.txtPagoNro.ReadOnly = True
        Me.txtPagoNro.Size = New System.Drawing.Size(100, 20)
        Me.txtPagoNro.TabIndex = 4
        Me.txtPagoNro.TabStop = False
        Me.txtPagoNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtPagoNro.Value = 0
        Me.txtPagoNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
        Me.txtPagoNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtTipoCambio.FormatString = "##,##0.000"
        Me.txtTipoCambio.Location = New System.Drawing.Point(436, 36)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoCambio.TabIndex = 6
        Me.txtTipoCambio.Text = "0,000"
        Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtPagoId
        '
        Me.txtPagoId.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPagoId.Location = New System.Drawing.Point(48, 12)
        Me.txtPagoId.Name = "txtPagoId"
        Me.txtPagoId.ReadOnly = True
        Me.txtPagoId.Size = New System.Drawing.Size(100, 20)
        Me.txtPagoId.TabIndex = 1
        Me.txtPagoId.TabStop = False
        Me.txtPagoId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtPagoId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(180, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "Estado"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 16)
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
        Me.Label11.Location = New System.Drawing.Point(356, 40)
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
        Me.Label12.Location = New System.Drawing.Point(576, 16)
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
        Me.Label15.Location = New System.Drawing.Point(380, 16)
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
        Me.Label16.Location = New System.Drawing.Point(184, 16)
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
        Me.cboCentroCosto.TabIndex = 260
        Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
        Me.grpSucursal.TabIndex = 21
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
        'frmPagoEdit
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
        Me.Name = "frmPagoEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        Me.ExplorerBarContainerControl4.ResumeLayout(False)
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bcgMain.ResumeLayout(False)
        CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ebrMain.ResumeLayout(False)
        CType(Me.grpRecargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRecargo.ResumeLayout(False)
        Me.grpRecargo.PerformLayout()
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
                    mlngID = moPago.PagoId
                    mboolChanged = True

                    cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

                    If MessageBox.Show("Pago Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Pago?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Call PrintReport()
                    End If

                    Me.Close()
                End If

            Case "Anular"
                If PagoAnular() Then
                    mlngID = moPago.PagoId
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

    Private Sub frmPagoEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Call StatusFormDisplay(Me.Name)
    End Sub

    Private Sub frmPagoEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                Me.Text = "Consulta Pago"

            ElseIf OperaFechaHabil(ToDate(dtpFecha.Value)) Then
                Call HeaderReadOnly()
                Me.Text = "Editar Pago"

            Else
                MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                mboolEditing = False
                Call DataReadOnly()
                Me.Text = "Consulta Pago"
            End If

        Else
            Me.Text = "Nuevo Pago"
            Call FormNew()
        End If

        Call SecuritySet(Me, AppExeName)
        mboolLoading = False

        Call ClearMemory()
        Me.Cursor = oCursor
    End Sub

#Region " Pago "

    Private Sub FormShow()
        mboolShow = True
        With moPago
            txtPagoId.Text = ToStr(.PagoId)
            dtpFecha.Text = ToStr(.Fecha)
            cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
            cboTipoPago.SelectedIndex = ListFindItem(cboTipoPago, .TipoPagoId)
            txtPagoNro.Text = ToStr(.PagoNro)
            cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
            txtTipoCambio.Text = ToDecStr(.TipoCambio)
            cboProveedor.Value = ListFindItem(cboProveedor, .ProveedorId)
            txtPagoDes.Text = ToStr(.PagoDes)
            cboPlanRecargo.SelectedIndex = ListFindItem(cboPlanRecargo, .PlanRecargoId)
            txtMontoRec.Text = ToDecStr(.MontoRec)
            cboPlanDescuento.SelectedIndex = ListFindItem(cboPlanDescuento, .PlanDescuentoId)
            txtMontoDes.Text = ToDecStr(.MontoDes)
            txtCapital.Text = ToDecStr(.Capital)
            txtInteres.Text = ToDecStr(.Interes)
            txtMontoPag.Text = ToDecStr(.MontoPag)
            txtMontoAntPag.Text = ToDecimal(AnticipoMontoLoad(7, .PagoId))

            cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

            chkConFac.Checked = .ConFac
            chkSinFac.Checked = .SinFac

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
        With moPago
            txtPagoId.Text = String.Empty
            dtpFecha.Text = String.Empty
            cboMoneda.SelectedIndex = -1
            cboTipoPago.SelectedIndex = -1
            txtPagoNro.Text = "0"
            cboEstado.SelectedIndex = ListFindItem(cboEstado, 14)
            txtTipoCambio.Text = "0"
            cboProveedor.Value = Nothing
            txtPagoDes.Text = String.Empty
            cboPlanRecargo.SelectedIndex = -1
            txtMontoRec.Text = "0"
            cboPlanDescuento.SelectedIndex = -1
            txtMontoDes.Text = "0"
            txtCapital.Text = "0"
            txtInteres.Text = "0"
            txtMontoPag.Text = "0"
            cboCentroCosto.SelectedIndex = -1
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, clsAppInfo.SucursalId)

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
        mboolShow = False
    End Sub

    Private Sub DataReadOnly()
        txtPagoId.ReadOnly = True
        dtpFecha.ReadOnly = True
        cboMoneda.ReadOnly = True
        cboTipoPago.ReadOnly = True
        txtPagoNro.ReadOnly = True
        cboEstado.ReadOnly = True
        txtTipoCambio.ReadOnly = True
        cboProveedor.ReadOnly = True
        txtPagoDes.ReadOnly = True
        cboPlanRecargo.ReadOnly = True
        txtMontoRec.ReadOnly = True
        cboPlanDescuento.ReadOnly = True
        txtMontoDes.ReadOnly = True
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
        txtPagoId.ReadOnly = True
        dtpFecha.ReadOnly = True
        cboMoneda.ReadOnly = True
        cboTipoPago.ReadOnly = True
        txtPagoNro.ReadOnly = True
        cboEstado.ReadOnly = True
        txtTipoCambio.ReadOnly = True
        cboProveedor.ReadOnly = True
        cboPlanRecargo.ReadOnly = True
        txtMontoRec.ReadOnly = True
        cboPlanDescuento.ReadOnly = True
        txtMontoDes.ReadOnly = True
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
        grpRecargo.Location = New System.Drawing.Point(grpRecargo.Location.X, grpRecargo.Location.Y - decPosSuc)
        ebrMain.Location = New System.Drawing.Point(ebrMain.Location.X, ebrMain.Location.Y - decPosSuc)
        ebrMain.Size = New System.Drawing.Size(ebrMain.Width, ebrMain.Height + decPosSuc)

    End Sub

    Private Sub DataMove()
        With moPago
            If Not mboolAdding Then
                .PagoId = ToLong(txtPagoId.Text)
            End If

            .Fecha = ToDate(dtpFecha.Value)
            .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
            .TipoPagoId = ListPosition(cboTipoPago, cboTipoPago.SelectedIndex)
            .PagoNro = ToLong(txtPagoNro.Text)
            .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
            .TipoCambio = ToDecimal(txtTipoCambio.Text)
            .ProveedorId = ListPosition(cboProveedor)
            .PagoDes = ToStr(txtPagoDes.Text)
            .PlanRecargoId = ListPosition(cboPlanRecargo, cboPlanRecargo.SelectedIndex)
            .MontoRec = ToDecimal(txtMontoRec.Text)
            .PlanDescuentoId = ListPosition(cboPlanDescuento, cboPlanDescuento.SelectedIndex)
            .MontoDes = ToDecimal(txtMontoDes.Text)
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
        Dim lngTipoCompId As Long
        Dim lngCompNro As Long

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
        Dim oRow As DataRow

        If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
            FormCheck = False
            Throw New Exception("Fecha Inicial no Corresponde a la Gestion en Uso")

        ElseIf Not OperaFechaHabil(ToDate(dtpFecha.Value)) Then
            FormCheck = False
            Throw New Exception("Fecha de Operación Inhábil para el Usuario")
        End If

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

        If moPagoDet.DataSet.Tables(moPagoDet.TableName).Rows.Count = 0 Then
            strMsg &= "Pago Sin Detalle"
        End If

        If strMsg.Trim <> String.Empty Then
            Throw New Exception(strMsg)
            FormCheck = False
        Else
            FormCheck = True
        End If
    End Function

    Private Function PagoAnular() As Boolean
        Dim lngCompId As Long

        Try
            If FormCheck() Then
                If MessageBox.Show("¿Realmente quiere Anular el Pago?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If moPago.TipoPagoId = clsTipoPago.CONTADO Then 'Contado
                        For Each oRow As DataRow In moPagoDet.DataSet.Tables(moPagoDet.TableName).Rows
                            If CompraRestore(oRow("CompraId"), clsEstado.PENDIENTE) Then
                                PagoAnular = True
                            End If
                        Next

                    Else 'Credito
                        For Each oRow As DataRow In moPagoDet.DataSet.Tables(moPagoDet.TableName).Rows
                            If CreditoRestore(oRow("CreditoId"), oRow("CreditoDetId"), oRow("CapitalAmo"), oRow("InteresAmo")) Then
                                If CompraRestore(oRow("CompraId"), 15) Then
                                    PagoAnular = True
                                End If
                            End If
                        Next
                    End If

                    'If CompAnular(moPago.TipoCompId, moPago.CompNro, clsAppInfo.SucursalId, clsEstado.ANULADO) Then
                    '   If PagoAnular(moPago.PagoId, clsEstado.ANULADO) Then
                    '      If ProveedorMovAnular(7, moPago.PagoId) Then
                    '         PagoAnular = True
                    '      End If
                    '   End If
                    'End If

                    If isCompFind(moPago.CompId, 0, 0) Then
                        lngCompId = moPago.CompId
                    End If

                    If CompAnular(lngCompId, clsEstado.ANULADO) Then
                        If PagoAnular(moPago.PagoId, clsEstado.ANULADO) Then
                            If ProveedorMovAnular(7, moPago.PagoId) Then
                                PagoAnular = True
                            End If
                        End If
                    End If

                    If AnticipoRestoreUpdate(7, moPago.PagoId) Then
                        PagoAnular = True
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
                        If .MonedaId <> moPago.MonedaId Then
                            decCapitalAmo *= .TipoCambio
                            decInteresAmo *= .TipoCambio
                        End If

                    ElseIf .MonedaId = 2 Then
                        If .MonedaId <> moPago.MonedaId Then
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
                .EmpresaId = moPago.EmpresaId
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
        Dim oComp As New clsComp(clsAppInfo.ConnectString)
        CompAnular = True

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
                    If CompDetAnular(.CompId, lngEstadoId) Then
                        If CompPlanAddAnular(.CompId, lngEstadoId) Then
                            If CompCCDetAnular(.CompId, lngEstadoId) Then
                                If CompChequeAnular(.CompId, lngEstadoId) Then

                                    .Fecha = ToDate(.Fecha)
                                    .EstadoId = lngEstadoId

                                    If .Update Then
                                        CompAnular = True
                                    End If
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
        Dim oComp As New clsComp(clsAppInfo.ConnectString)

        CompAnular = True

        Try
            With oComp

                If lngCompId <> 0 Then
                    .CompId = lngCompId

                    If .FindByPK Then
                        If CompDetAnular(.CompId, lngEstadoId) Then
                            If CompPlanAddAnular(.CompId, lngEstadoId) Then
                                If CompCCDetAnular(.CompId, lngEstadoId) Then
                                    If CompChequeAnular(.CompId, lngEstadoId) Then

                                        .Fecha = ToDate(.Fecha)
                                        .EstadoId = lngEstadoId

                                        If .Update Then
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

        CompDetAnular = False

        Try
            With oCompDet
                .SelectFilter = clsCompDet.SelectFilters.All
                .WhereFilter = clsCompDet.WhereFilters.CompId
                .EmpresaId = moPago.EmpresaId
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
                .EmpresaId = moPago.EmpresaId
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
                .EmpresaId = moPago.EmpresaId
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

    Private Function CompChequeAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
        Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
        CompChequeAnular = False

        Try
            With oCompCheque
                .SelectFilter = clsCompCheque.SelectFilters.All
                .WhereFilter = clsCompCheque.WhereFilters.CompId
                .EmpresaId = moPago.EmpresaId
                .CompId = lngCompId

                If .Find Then
                    Do While .Read
                        .Fecha = ToDate(.Fecha)
                        .FechaCob = ToDate(.FechaCob)
                        .EstadoId = lngEstadoId

                        If .UpdateOnly Then
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

    Private Function PagoAnular(ByVal lngPagoId As Long, ByVal lngEstadoId As Long) As Boolean
        Dim oPago As New clsPago(clsAppInfo.ConnectString)

        PagoAnular = False

        Try
            With oPago
                .PagoId = lngPagoId

                If .FindByPK Then
                    If PagoDetAnular(.PagoId, lngEstadoId) Then
                        .Fecha = ToDate(.Fecha)
                        .EstadoId = lngEstadoId

                        If .Update Then
                            PagoAnular = True
                        End If
                    End If
                End If
            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Finally
            oPago.Dispose()

        End Try
    End Function

    Private Function PagoDetAnular(ByVal lngPagoId As Long, ByVal lngEstadoId As Long) As Boolean
        Dim oPagoDet As New clsPagoDet(clsAppInfo.ConnectString)

        PagoDetAnular = False

        Try
            With oPagoDet
                .SelectFilter = clsPagoDet.SelectFilters.All
                .WhereFilter = clsPagoDet.WhereFilters.PagoId
                .EmpresaId = moPago.EmpresaId
                .PagoId = lngPagoId

                If .Find Then
                    Do While .Read
                        .Fecha = ToDate(.Fecha)
                        .EstadoId = lngEstadoId

                        If .Update Then
                            PagoDetAnular = True
                        End If

                        .MoveNext()
                    Loop
                End If
            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Finally
            oPagoDet.Dispose()

        End Try
    End Function

    Private Function CompraRestore(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
        Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

        CompraRestore = False

        Try
            With oCompra
                .CompraId = lngCompraId

                If .FindByPK Then
                    If CompraDetRestore(.CompraId, lngEstadoId) Then
                        .Fecha = ToDate(.Fecha)
                        .EstadoId = lngEstadoId

                        If .Update Then
                            CompraRestore = True
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

    Private Function CompraDetRestore(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
        Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

        CompraDetRestore = False

        Try
            With oCompraDet
                .SelectFilter = clsCompraDet.SelectFilters.All
                .WhereFilter = clsCompraDet.WhereFilters.CompraId
                .EmpresaId = moPago.EmpresaId
                .CompraId = lngCompraId

                If .Find Then
                    Do While .Read
                        .Fecha = ToDate(.Fecha)
                        .EstadoId = lngEstadoId

                        If .Update Then
                            CompraDetRestore = True
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

    Private Function GestionIdFind(ByVal strFecha As String) As Long
        Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

        GestionIdFind = 0

        Try
            With oGestion
                .SelectFilter = clsGestion.SelectFilters.All
                .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
                .EmpresaId = moPago.EmpresaId
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
        txtMontoRec.FormatString = DecimalMask()
        txtMontoDes.FormatString = DecimalMask()
        txtCapital.FormatString = DecimalMask()
        txtInteres.FormatString = DecimalMask()
        txtMontoPag.FormatString = DecimalMask()
        txtMontoAntPag.FormatString = DecimalMask()

        moPagoDet = New clsPagoDet(clsAppInfo.ConnectString)
        Call ViewComponent()
    End Sub

    Private Sub ComboLoad()
        Call cboMonedaLoad()
        Call cboTipoPagoLoad()
        Call cboEstadoLoad()
        Call cboProveedorLoad()
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

    Private Sub cboProveedorLoad()
        Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
        Dim oListItem As clsListItem

        cboProveedor.DropDownList.Columns.Clear()

        Try
            With oProveedor
                .SelectFilter = clsProveedor.SelectFilters.ListBox
                .WhereFilter = clsProveedor.WhereFilters.EstadoId
                .OrderByFilter = clsProveedor.OrderByFilters.ProveedorDes
                .EmpresaId = moPago.EmpresaId
                .ProveedorId = moPago.ProveedorId
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
        PrintReportPago(moPago.TipoPagoId, moPago.PagoId, moPago.SucursalId, ToDecimalDos(txtMontoAntPag.Text), ToDecimalDos(txtCapital.Text))
    End Sub

    Private Function AnticipoMontoLoad(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Decimal

        Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

        AnticipoMontoLoad = 0

        Try
            With oAnticipoDet
                .SelectFilter = clsAnticipoDet.SelectFilters.All
                .WhereFilter = clsAnticipoDet.WhereFilters.DocumentoId
                .EmpresaId = moPago.EmpresaId
                .GestionId = moPago.GestionId
                .TipoCompraId = lngTipoCompraId
                .DocumentoId = lngDocumentoId

                If .Open Then
                    While .Read

                        If moPago.MonedaId = .MonedaId Then
                            AnticipoMontoLoad += .Monto

                        ElseIf .MonedaId = 1 Then
                            AnticipoMontoLoad += .Monto / .TipoCambio

                        ElseIf .MonedaId = 2 Then
                            AnticipoMontoLoad += .Monto * .TipoCambio

                        End If

                        .MoveNext()
                    End While

                End If

                AnticipoMontoLoad = ToDecimal(AnticipoMontoLoad)

            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Finally
            oAnticipoDet.Dispose()

        End Try
    End Function

    Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
        If mboolAdding Then
            If Not IsNothing(moPago) Then
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

#Region " Detalle del Pago "

    Private Sub grdMainLoad()
        Dim oRow As DataRow

        Try
            With moPagoDet
                If moPago.TipoPagoId = 1 Then
                    .SelectFilter = clsPagoDet.SelectFilters.GridContado
                Else
                    .SelectFilter = clsPagoDet.SelectFilters.Grid
                End If

                .WhereFilter = clsPagoDet.WhereFilters.Grid
                .OrderByFilter = clsPagoDet.OrderByFilters.Grid
                .EmpresaId = moPago.EmpresaId
                .PagoId = moPago.PagoId

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
            ebrMain.Groups(0).Text = "Detalle del Pago"

            .RootTable.Columns("PagoDetId").Visible = False

            .RootTable.Columns("PagoId").Visible = False

            .RootTable.Columns("Fecha").Caption = "Fecha"
            .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
            .RootTable.Columns("Fecha").Width = 70
            .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CompraId").Visible = False

            .RootTable.Columns("CompraNro").Caption = "Compra"
            .RootTable.Columns("CompraNro").Width = 70
            .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CompraOrden").Caption = "Orden"
            .RootTable.Columns("CompraOrden").Width = 70
            .RootTable.Columns("CompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CapitalOrg").Visible = False

            .RootTable.Columns("InteresOrg").Visible = False

            .RootTable.Columns("CapitalAmo").Caption = "Amortizado"
            .RootTable.Columns("CapitalAmo").FormatString = DecimalMask()
            .RootTable.Columns("CapitalAmo").Width = 70
            .RootTable.Columns("CapitalAmo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("CapitalAmo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("InteresAmo").Caption = "Interés"
            .RootTable.Columns("InteresAmo").FormatString = DecimalMask()
            .RootTable.Columns("InteresAmo").Width = 70
            .RootTable.Columns("InteresAmo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("InteresAmo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Importe").Caption = "A Cuenta"
            .RootTable.Columns("Importe").FormatString = DecimalMask()
            .RootTable.Columns("Importe").Width = 70
            .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Saldo").Caption = "Saldo"
            .RootTable.Columns("Saldo").FormatString = DecimalMask()
            .RootTable.Columns("Saldo").Width = 70
            .RootTable.Columns("Saldo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Saldo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CreditoId").Visible = False

            .RootTable.Columns("CreditoDetId").Visible = False

            If moPago.TipoPagoId = 1 Then
                .RootTable.Columns("CreditoNro").Visible = False

                .RootTable.Columns("CuotaNro").Visible = False
            Else
                .RootTable.Columns("CreditoNro").Caption = "Crédito"
                .RootTable.Columns("CreditoNro").Width = 70
                .RootTable.Columns("CreditoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                .RootTable.Columns("CreditoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

                .RootTable.Columns("CuotaNro").Caption = "Cuota"
                .RootTable.Columns("CuotaNro").Width = 70
                .RootTable.Columns("CuotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                .RootTable.Columns("CuotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            End If
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

#Region "Anticipo"

    Private Function AnticipoRestoreUpdate(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Boolean
        Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
        Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

        Try
            AnticipoRestoreUpdate = True

            With oAnticipoDet
                .SelectFilter = clsAnticipoDet.SelectFilters.All
                .WhereFilter = clsAnticipoDet.WhereFilters.DocumentoId
                .EmpresaId = moPago.EmpresaId
                .TipoCompraId = lngTipoCompraId
                .DocumentoId = lngDocumentoId

                If .Open() Then
                    Do While .Read()
                        With oAnticipo
                            .AnticipoId = oAnticipoDet.AnticipoId

                            If .FindByPK Then
                                .Fecha = ToDate(.Fecha)
                                .MontoDes -= oAnticipoDet.Monto
                                .EstadoId = clsEstado.PENDIENTE  'Pendiente

                                If .Update() Then
                                    If ProveedorMovAnular(9, oAnticipoDet.AnticipoDetId) Then 'Descargo de Anticipos
                                        AnticipoRestoreUpdate = True
                                    End If
                                End If
                            End If
                        End With

                        .MoveNext()
                    Loop

                    If AnticipoDetUpdate(lngTipoCompraId, lngDocumentoId, clsEstado.ANULADO) Then
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
                .EmpresaId = moPago.EmpresaId
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

#End Region

    Private Sub frmPagoEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.WindowState <> FormWindowState.Minimized Then
            If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
                If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
                    If DataSave() Then
                        mlngID = moPago.PagoId
                        mboolChanged = True

                        cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
                        cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

                        If MessageBox.Show("Pago Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Pago?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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

    Private Sub frmPagoEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        moPago.Dispose()
        moPagoDet.Dispose()
        Call ClearMemory()
    End Sub

End Class
