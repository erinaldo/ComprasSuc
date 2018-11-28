Public Class frmFacturaDifDetEdit
   Inherits System.Windows.Forms.Form

   Private moFactura As clsFactura
   Private mlngEmpresaId As Long

   Private mboolAdding As Boolean = False
   Private mboolAnular As Boolean = False
   Private mboolChanged As Boolean = False
   Private mboolClose As Boolean

   Private mboolDetallado As Boolean
   Private mboolIvaFac As Boolean
   Private mstrFechaFin As String
   Private mstrLlaveDosifica As String

   Private mlngProveedorId As Long
   Private mlngUnidadNegoId As Long
   Private mlngCentroCostoId As Long
   Private mlngTipoPagoId As Long
   Private mlngItemId As Long
   Private mlngMonedaId As Long
   Private mdecMontoFac As Decimal
   Private mdecMontoFacOrig As Decimal
   Private mdecExentoOrig As Decimal      ''A Facturar Original
   Private mdecExentoFac As Decimal      ''Facturado Moneda Compra

   Private mdecMontoCompra As Decimal
   Private mdecExentoCompra As Decimal

   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngSucursalId As Long
   ''Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngTipoPlanId As Long
   Private mboolTieneComp As Boolean

   Private mstrCompras As String
   Private mlngID As Long
   Private mListCompra As ArrayList

   Private mlngCompraId As Long
   Private mdecTipoCambio As Decimal

   Private moDataSet As DataSet
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents chkBancarizar As Janus.Windows.EditControls.UICheckBox
   Private moDataTable As DataTable
   Friend WithEvents grpCompra As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtMontoAFact As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtMontoFact As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtCompraNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents chkCliente As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents cboTipoPago As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents grpFactura As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboNroRUC As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents txtCodControl As Janus.Windows.GridEX.EditControls.MaskedEditBox
   Friend WithEvents txtNroAutorizacion As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboRegRUC As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtFacturaNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents dtpFacturaFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtFacturaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents txtExentoAFac As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtExentoFac As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents chkFacturaNoValida As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboTipoFacCompra As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblTipoFacCompraId As System.Windows.Forms.Label
   Private mstrNroAutorizacion As String

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get
      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   WriteOnly Property Adding() As Boolean
      Set(ByVal Value As Boolean)
         mboolAdding = Value
      End Set
   End Property

   WriteOnly Property AnularFac() As Boolean

      Set(ByVal Value As Boolean)
         mboolAnular = Value
      End Set

   End Property

   Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get

      Set(ByVal Value As Boolean)
         mboolChanged = Value
      End Set
   End Property

   WriteOnly Property IvaFac() As Boolean
      Set(ByVal Value As Boolean)
         mboolIvaFac = Value
      End Set
   End Property

   Property Detallado() As Boolean
      Get
         Return mboolDetallado
      End Get
      Set(ByVal Value As Boolean)
         mboolDetallado = Value
      End Set

   End Property

   WriteOnly Property DataObject() As clsFactura

      Set(ByVal Value As clsFactura)
         moFactura = Value
      End Set

   End Property

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property

   WriteOnly Property ProveedorId() As Long
      Set(ByVal Value As Long)
         mlngProveedorId = Value
      End Set
   End Property

   WriteOnly Property CentroCostoId() As Long
      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   WriteOnly Property UnidadNegoId() As Long
      Set(ByVal Value As Long)
         mlngUnidadNegoId = Value
      End Set
   End Property

   WriteOnly Property ListaCompra() As ArrayList
      Set(ByVal Value As ArrayList)
         mListCompra = Value
      End Set

   End Property

   WriteOnly Property TipoPagoId() As Long
      Set(ByVal Value As Long)
         mlngTipoPagoId = Value
      End Set
   End Property

   WriteOnly Property MonedaId() As Long
      Set(ByVal Value As Long)
         mlngMonedaId = Value
      End Set
   End Property

   WriteOnly Property CompraId() As Long
      Set(ByVal Value As Long)
         mlngCompraId = Value
      End Set
   End Property

   WriteOnly Property TipoCambio() As Decimal
      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

   WriteOnly Property ExentoFac() As Decimal
      Set(ByVal Value As Decimal)
         mdecExentoFac = Value
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

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Diseñador de Windows Forms.  
   'No lo modifique con el editor de código.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboNroRUC_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaDifDetEdit))
      Dim cboRegRUC_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.grpFactura = New Janus.Windows.EditControls.UIGroupBox
      Me.cboNroRUC = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.txtCodControl = New Janus.Windows.GridEX.EditControls.MaskedEditBox
      Me.txtNroAutorizacion = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboRegRUC = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.txtFacturaNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.dtpFacturaFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtFacturaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.Label18 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.Label20 = New System.Windows.Forms.Label
      Me.Label21 = New System.Windows.Forms.Label
      Me.grpCompra = New Janus.Windows.EditControls.UIGroupBox
      Me.txtExentoAFac = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtExentoFac = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label22 = New System.Windows.Forms.Label
      Me.txtMontoAFact = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.txtMontoFact = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtCompraNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label23 = New System.Windows.Forms.Label
      Me.chkCliente = New Janus.Windows.EditControls.UICheckBox
      Me.cboProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.cboTipoPago = New Janus.Windows.EditControls.UIComboBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtFacturaObs = New Janus.Windows.GridEX.EditControls.EditBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkFacturaNoValida = New Janus.Windows.EditControls.UICheckBox
      Me.chkBancarizar = New Janus.Windows.EditControls.UICheckBox
      Me.txtImporteIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtNeto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtExento = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIceIehd = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtFacturaMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit3 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.cboTipoFacCompra = New Janus.Windows.EditControls.UIComboBox
      Me.lblTipoFacCompraId = New System.Windows.Forms.Label
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.grpFactura, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpFactura.SuspendLayout()
      CType(Me.cboNroRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboRegRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.grpCompra, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpCompra.SuspendLayout()
      CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(746, 167)
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
      Me.grdMain.Size = New System.Drawing.Size(746, 167)
      Me.grdMain.TabIndex = 13
      Me.grdMain.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'New2
      '
      Me.New2.ImageIndex = 0
      Me.New2.Key = "New"
      Me.New2.Name = "New2"
      Me.New2.Text = "Nuevo"
      '
      'Edit
      '
      Me.Edit.ImageIndex = 1
      Me.Edit.Key = "Edit"
      Me.Edit.Name = "Edit"
      Me.Edit.Text = "Editar"
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.grpFactura)
      Me.uiBackground.Controls.Add(Me.grpCompra)
      Me.uiBackground.Controls.Add(Me.UiGroupBox2)
      Me.uiBackground.Controls.Add(Me.UiGroupBox1)
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(770, 466)
      Me.uiBackground.TabIndex = 17
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpFactura
      '
      Me.grpFactura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpFactura.BackColor = System.Drawing.Color.WhiteSmoke
      Me.grpFactura.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpFactura.Controls.Add(Me.cboNroRUC)
      Me.grpFactura.Controls.Add(Me.txtCodControl)
      Me.grpFactura.Controls.Add(Me.txtNroAutorizacion)
      Me.grpFactura.Controls.Add(Me.cboRegRUC)
      Me.grpFactura.Controls.Add(Me.cboEstado)
      Me.grpFactura.Controls.Add(Me.txtFacturaNro)
      Me.grpFactura.Controls.Add(Me.dtpFacturaFecha)
      Me.grpFactura.Controls.Add(Me.txtFacturaId)
      Me.grpFactura.Controls.Add(Me.Label14)
      Me.grpFactura.Controls.Add(Me.Label15)
      Me.grpFactura.Controls.Add(Me.Label16)
      Me.grpFactura.Controls.Add(Me.Label17)
      Me.grpFactura.Controls.Add(Me.Label18)
      Me.grpFactura.Controls.Add(Me.Label19)
      Me.grpFactura.Controls.Add(Me.Label20)
      Me.grpFactura.Controls.Add(Me.Label21)
      Me.grpFactura.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpFactura.Location = New System.Drawing.Point(4, 0)
      Me.grpFactura.Name = "grpFactura"
      Me.grpFactura.Size = New System.Drawing.Size(424, 140)
      Me.grpFactura.TabIndex = 0
      Me.grpFactura.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboNroRUC
      '
      Me.cboNroRUC.Anchor = System.Windows.Forms.AnchorStyles.Top
      cboNroRUC_DesignTimeLayout.LayoutString = resources.GetString("cboNroRUC_DesignTimeLayout.LayoutString")
      Me.cboNroRUC.DesignTimeLayout = cboNroRUC_DesignTimeLayout
      Me.cboNroRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboNroRUC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboNroRUC.Location = New System.Drawing.Point(262, 12)
      Me.cboNroRUC.MaxLength = 12
      Me.cboNroRUC.Name = "cboNroRUC"
      Me.cboNroRUC.SelectedIndex = -1
      Me.cboNroRUC.SelectedItem = Nothing
      Me.cboNroRUC.Size = New System.Drawing.Size(108, 20)
      Me.cboNroRUC.TabIndex = 5
      Me.cboNroRUC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboNroRUC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCodControl
      '
      Me.txtCodControl.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtCodControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.txtCodControl.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCodControl.Location = New System.Drawing.Point(262, 88)
      Me.txtCodControl.Mask = "&&-&&-&&-&&-&&"
      Me.txtCodControl.Name = "txtCodControl"
      Me.txtCodControl.Size = New System.Drawing.Size(108, 20)
      Me.txtCodControl.TabIndex = 8
      Me.txtCodControl.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCodControl.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNroAutorizacion
      '
      Me.txtNroAutorizacion.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtNroAutorizacion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroAutorizacion.FormatString = "###############0"
      Me.txtNroAutorizacion.Location = New System.Drawing.Point(262, 62)
      Me.txtNroAutorizacion.MaxLength = 15
      Me.txtNroAutorizacion.Name = "txtNroAutorizacion"
      Me.txtNroAutorizacion.Size = New System.Drawing.Size(108, 20)
      Me.txtNroAutorizacion.TabIndex = 7
      Me.txtNroAutorizacion.Text = "0"
      Me.txtNroAutorizacion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroAutorizacion.Value = CType(0, Long)
      Me.txtNroAutorizacion.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtNroAutorizacion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboRegRUC
      '
      Me.cboRegRUC.Anchor = System.Windows.Forms.AnchorStyles.Top
      cboRegRUC_DesignTimeLayout.LayoutString = resources.GetString("cboRegRUC_DesignTimeLayout.LayoutString")
      Me.cboRegRUC.DesignTimeLayout = cboRegRUC_DesignTimeLayout
      Me.cboRegRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboRegRUC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboRegRUC.Location = New System.Drawing.Point(262, 37)
      Me.cboRegRUC.Name = "cboRegRUC"
      Me.cboRegRUC.SelectedIndex = -1
      Me.cboRegRUC.SelectedItem = Nothing
      Me.cboRegRUC.Size = New System.Drawing.Size(156, 20)
      Me.cboRegRUC.TabIndex = 6
      Me.cboRegRUC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboRegRUC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(64, 36)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.ReadOnly = True
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(96, 20)
      Me.cboEstado.TabIndex = 2
      Me.cboEstado.TabStop = False
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtFacturaNro
      '
      Me.txtFacturaNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaNro.FormatString = "##################"
      Me.txtFacturaNro.Location = New System.Drawing.Point(64, 89)
      Me.txtFacturaNro.MaxLength = 18
      Me.txtFacturaNro.Name = "txtFacturaNro"
      Me.txtFacturaNro.Size = New System.Drawing.Size(96, 20)
      Me.txtFacturaNro.TabIndex = 4
      Me.txtFacturaNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaNro.Value = CType(0, Long)
      Me.txtFacturaNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtFacturaNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'dtpFacturaFecha
      '
      Me.dtpFacturaFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFacturaFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFacturaFecha.DropDownCalendar.FirstMonth = New Date(2008, 1, 1, 0, 0, 0, 0)
      Me.dtpFacturaFecha.DropDownCalendar.Name = ""
      Me.dtpFacturaFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFacturaFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dtpFacturaFecha.Location = New System.Drawing.Point(64, 62)
      Me.dtpFacturaFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFacturaFecha.Name = "dtpFacturaFecha"
      Me.dtpFacturaFecha.ReadOnly = True
      Me.dtpFacturaFecha.Size = New System.Drawing.Size(96, 20)
      Me.dtpFacturaFecha.TabIndex = 3
      Me.dtpFacturaFecha.TabStop = False
      Me.dtpFacturaFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtFacturaId
      '
      Me.txtFacturaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaId.Location = New System.Drawing.Point(64, 12)
      Me.txtFacturaId.Name = "txtFacturaId"
      Me.txtFacturaId.ReadOnly = True
      Me.txtFacturaId.Size = New System.Drawing.Size(96, 20)
      Me.txtFacturaId.TabIndex = 1
      Me.txtFacturaId.TabStop = False
      Me.txtFacturaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label14.Location = New System.Drawing.Point(4, 40)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(48, 16)
      Me.Label14.TabIndex = 219
      Me.Label14.Text = "Estado"
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label15.Location = New System.Drawing.Point(4, 93)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(52, 16)
      Me.Label15.TabIndex = 218
      Me.Label15.Text = "Número"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label16.Location = New System.Drawing.Point(4, 66)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(52, 16)
      Me.Label16.TabIndex = 217
      Me.Label16.Text = "Fecha"
      '
      'Label17
      '
      Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label17.Location = New System.Drawing.Point(174, 66)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(76, 16)
      Me.Label17.TabIndex = 216
      Me.Label17.Text = "Nro Autoriz."
      '
      'Label18
      '
      Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label18.Location = New System.Drawing.Point(174, 92)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(80, 16)
      Me.Label18.TabIndex = 215
      Me.Label18.Text = "Cod. Control"
      '
      'Label19
      '
      Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label19.Location = New System.Drawing.Point(174, 41)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(84, 16)
      Me.Label19.TabIndex = 214
      Me.Label19.Text = "Razón Social"
      '
      'Label20
      '
      Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label20.Location = New System.Drawing.Point(174, 16)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(76, 16)
      Me.Label20.TabIndex = 213
      Me.Label20.Text = "Número NIT"
      '
      'Label21
      '
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label21.Location = New System.Drawing.Point(4, 16)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(56, 16)
      Me.Label21.TabIndex = 212
      Me.Label21.Text = "ID"
      '
      'grpCompra
      '
      Me.grpCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpCompra.BackColor = System.Drawing.Color.WhiteSmoke
      Me.grpCompra.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpCompra.Controls.Add(Me.txtExentoAFac)
      Me.grpCompra.Controls.Add(Me.Label13)
      Me.grpCompra.Controls.Add(Me.txtExentoFac)
      Me.grpCompra.Controls.Add(Me.Label22)
      Me.grpCompra.Controls.Add(Me.txtMontoAFact)
      Me.grpCompra.Controls.Add(Me.Label12)
      Me.grpCompra.Controls.Add(Me.txtMontoFact)
      Me.grpCompra.Controls.Add(Me.Label1)
      Me.grpCompra.Controls.Add(Me.cboMoneda)
      Me.grpCompra.Controls.Add(Me.Label2)
      Me.grpCompra.Controls.Add(Me.txtCompraNro)
      Me.grpCompra.Controls.Add(Me.Label23)
      Me.grpCompra.Controls.Add(Me.chkCliente)
      Me.grpCompra.Controls.Add(Me.cboProveedor)
      Me.grpCompra.Controls.Add(Me.Label9)
      Me.grpCompra.Controls.Add(Me.txtTipoCambio)
      Me.grpCompra.Controls.Add(Me.Label11)
      Me.grpCompra.Controls.Add(Me.cboTipoPago)
      Me.grpCompra.Controls.Add(Me.Label10)
      Me.grpCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpCompra.Location = New System.Drawing.Point(432, 0)
      Me.grpCompra.Name = "grpCompra"
      Me.grpCompra.Size = New System.Drawing.Size(333, 140)
      Me.grpCompra.TabIndex = 9
      Me.grpCompra.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtExentoAFac
      '
      Me.txtExentoAFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtExentoAFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtExentoAFac.FormatString = "##,##0.000"
      Me.txtExentoAFac.Location = New System.Drawing.Point(240, 114)
      Me.txtExentoAFac.Name = "txtExentoAFac"
      Me.txtExentoAFac.Size = New System.Drawing.Size(88, 20)
      Me.txtExentoAFac.TabIndex = 18
      Me.txtExentoAFac.Text = "0,000"
      Me.txtExentoAFac.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtExentoAFac.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtExentoAFac.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(176, 112)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(64, 28)
      Me.Label13.TabIndex = 371
      Me.Label13.Text = "Exento a Facturar"
      '
      'txtExentoFac
      '
      Me.txtExentoFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtExentoFac.BackColor = System.Drawing.SystemColors.Info
      Me.txtExentoFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtExentoFac.FormatString = "##,##0.000"
      Me.txtExentoFac.Location = New System.Drawing.Point(84, 114)
      Me.txtExentoFac.Name = "txtExentoFac"
      Me.txtExentoFac.ReadOnly = True
      Me.txtExentoFac.Size = New System.Drawing.Size(88, 20)
      Me.txtExentoFac.TabIndex = 17
      Me.txtExentoFac.TabStop = False
      Me.txtExentoFac.Text = "0,000"
      Me.txtExentoFac.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtExentoFac.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtExentoFac.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label22
      '
      Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.Location = New System.Drawing.Point(4, 116)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(64, 16)
      Me.Label22.TabIndex = 370
      Me.Label22.Text = "Exento Fac"
      '
      'txtMontoAFact
      '
      Me.txtMontoAFact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoAFact.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoAFact.FormatString = "##,##0.000"
      Me.txtMontoAFact.Location = New System.Drawing.Point(240, 88)
      Me.txtMontoAFact.Name = "txtMontoAFact"
      Me.txtMontoAFact.Size = New System.Drawing.Size(88, 20)
      Me.txtMontoAFact.TabIndex = 16
      Me.txtMontoAFact.Text = "0,000"
      Me.txtMontoAFact.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoAFact.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoAFact.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(176, 90)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(64, 16)
      Me.Label12.TabIndex = 367
      Me.Label12.Text = "A Facturar"
      '
      'txtMontoFact
      '
      Me.txtMontoFact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoFact.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoFact.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoFact.FormatString = "##,##0.000"
      Me.txtMontoFact.Location = New System.Drawing.Point(84, 88)
      Me.txtMontoFact.Name = "txtMontoFact"
      Me.txtMontoFact.ReadOnly = True
      Me.txtMontoFact.Size = New System.Drawing.Size(88, 20)
      Me.txtMontoFact.TabIndex = 15
      Me.txtMontoFact.TabStop = False
      Me.txtMontoFact.Text = "0,000"
      Me.txtMontoFact.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoFact.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoFact.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(4, 90)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(64, 16)
      Me.Label1.TabIndex = 365
      Me.Label1.Text = "Facturado"
      '
      'cboMoneda
      '
      Me.cboMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboMoneda.BackColor = System.Drawing.SystemColors.Info
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(84, 61)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.ReadOnly = True
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(88, 20)
      Me.cboMoneda.TabIndex = 13
      Me.cboMoneda.TabStop = False
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(4, 64)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(56, 16)
      Me.Label2.TabIndex = 363
      Me.Label2.Text = "Moneda"
      '
      'txtCompraNro
      '
      Me.txtCompraNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCompraNro.BackColor = System.Drawing.SystemColors.Info
      Me.txtCompraNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompraNro.FormatString = "########"
      Me.txtCompraNro.Location = New System.Drawing.Point(84, 36)
      Me.txtCompraNro.Name = "txtCompraNro"
      Me.txtCompraNro.ReadOnly = True
      Me.txtCompraNro.Size = New System.Drawing.Size(88, 20)
      Me.txtCompraNro.TabIndex = 11
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
      Me.Label23.Location = New System.Drawing.Point(4, 40)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(68, 16)
      Me.Label23.TabIndex = 362
      Me.Label23.Text = "N. Compra"
      '
      'chkCliente
      '
      Me.chkCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkCliente.BackColor = System.Drawing.Color.Transparent
      Me.chkCliente.Checked = True
      Me.chkCliente.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkCliente.Location = New System.Drawing.Point(69, 16)
      Me.chkCliente.Name = "chkCliente"
      Me.chkCliente.Size = New System.Drawing.Size(11, 16)
      Me.chkCliente.TabIndex = 4
      Me.chkCliente.TabStop = False
      Me.chkCliente.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboProveedor
      '
      Me.cboProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboProveedor.BackColor = System.Drawing.SystemColors.Info
      cboProveedor_DesignTimeLayout.LayoutString = resources.GetString("cboProveedor_DesignTimeLayout.LayoutString")
      Me.cboProveedor.DesignTimeLayout = cboProveedor_DesignTimeLayout
      Me.cboProveedor.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProveedor.Location = New System.Drawing.Point(84, 12)
      Me.cboProveedor.Name = "cboProveedor"
      Me.cboProveedor.ReadOnly = True
      Me.cboProveedor.SelectedIndex = -1
      Me.cboProveedor.SelectedItem = Nothing
      Me.cboProveedor.Size = New System.Drawing.Size(244, 20)
      Me.cboProveedor.TabIndex = 10
      Me.cboProveedor.TabStop = False
      Me.cboProveedor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboProveedor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(4, 16)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(64, 16)
      Me.Label9.TabIndex = 359
      Me.Label9.Text = "Proveedor"
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTipoCambio.BackColor = System.Drawing.SystemColors.Info
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(240, 61)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.ReadOnly = True
      Me.txtTipoCambio.Size = New System.Drawing.Size(88, 20)
      Me.txtTipoCambio.TabIndex = 14
      Me.txtTipoCambio.TabStop = False
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
      Me.Label11.Location = New System.Drawing.Point(180, 63)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(36, 16)
      Me.Label11.TabIndex = 327
      Me.Label11.Text = "T.C."
      '
      'cboTipoPago
      '
      Me.cboTipoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboTipoPago.BackColor = System.Drawing.SystemColors.Info
      Me.cboTipoPago.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoPago.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPago.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPago.Location = New System.Drawing.Point(240, 36)
      Me.cboTipoPago.Name = "cboTipoPago"
      Me.cboTipoPago.ReadOnly = True
      Me.cboTipoPago.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoPago.Size = New System.Drawing.Size(88, 20)
      Me.cboTipoPago.TabIndex = 12
      Me.cboTipoPago.TabStop = False
      Me.cboTipoPago.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label10.Location = New System.Drawing.Point(176, 40)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(72, 16)
      Me.Label10.TabIndex = 325
      Me.Label10.Text = "T. Compra"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.cboTipoFacCompra)
      Me.UiGroupBox2.Controls.Add(Me.lblTipoFacCompraId)
      Me.UiGroupBox2.Controls.Add(Me.txtFacturaObs)
      Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(4, 352)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(336, 108)
      Me.UiGroupBox2.TabIndex = 12
      Me.UiGroupBox2.Text = "Observación"
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtFacturaObs
      '
      Me.txtFacturaObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtFacturaObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFacturaObs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaObs.Location = New System.Drawing.Point(8, 16)
      Me.txtFacturaObs.MaxLength = 255
      Me.txtFacturaObs.Multiline = True
      Me.txtFacturaObs.Name = "txtFacturaObs"
      Me.txtFacturaObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtFacturaObs.Size = New System.Drawing.Size(320, 60)
      Me.txtFacturaObs.TabIndex = 14
      Me.txtFacturaObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.chkFacturaNoValida)
      Me.UiGroupBox1.Controls.Add(Me.chkBancarizar)
      Me.UiGroupBox1.Controls.Add(Me.txtImporteIVA)
      Me.UiGroupBox1.Controls.Add(Me.txtIVA)
      Me.UiGroupBox1.Controls.Add(Me.txtNeto)
      Me.UiGroupBox1.Controls.Add(Me.txtExento)
      Me.UiGroupBox1.Controls.Add(Me.txtIceIehd)
      Me.UiGroupBox1.Controls.Add(Me.txtFacturaMonto)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.Label8)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(348, 352)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(417, 108)
      Me.UiGroupBox1.TabIndex = 13
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkFacturaNoValida
      '
      Me.chkFacturaNoValida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkFacturaNoValida.BackColor = System.Drawing.Color.Transparent
      Me.chkFacturaNoValida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFacturaNoValida.Enabled = False
      Me.chkFacturaNoValida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFacturaNoValida.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFacturaNoValida.Location = New System.Drawing.Point(280, 84)
      Me.chkFacturaNoValida.Name = "chkFacturaNoValida"
      Me.chkFacturaNoValida.Size = New System.Drawing.Size(128, 16)
      Me.chkFacturaNoValida.TabIndex = 281
      Me.chkFacturaNoValida.TabStop = False
      Me.chkFacturaNoValida.Text = "Factura No Válida"
      Me.chkFacturaNoValida.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkBancarizar
      '
      Me.chkBancarizar.BackColor = System.Drawing.Color.Transparent
      Me.chkBancarizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkBancarizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkBancarizar.Location = New System.Drawing.Point(8, 84)
      Me.chkBancarizar.Name = "chkBancarizar"
      Me.chkBancarizar.Size = New System.Drawing.Size(216, 20)
      Me.chkBancarizar.TabIndex = 197
      Me.chkBancarizar.TabStop = False
      Me.chkBancarizar.Text = "Bancarizar esta Factura"
      Me.chkBancarizar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtImporteIVA
      '
      Me.txtImporteIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtImporteIVA.BackColor = System.Drawing.SystemColors.Info
      Me.txtImporteIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporteIVA.FormatString = "##,##0.000"
      Me.txtImporteIVA.Location = New System.Drawing.Point(301, 60)
      Me.txtImporteIVA.Name = "txtImporteIVA"
      Me.txtImporteIVA.ReadOnly = True
      Me.txtImporteIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtImporteIVA.TabIndex = 22
      Me.txtImporteIVA.TabStop = False
      Me.txtImporteIVA.Text = "0,000"
      Me.txtImporteIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporteIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporteIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIVA
      '
      Me.txtIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtIVA.BackColor = System.Drawing.SystemColors.Info
      Me.txtIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIVA.FormatString = "##,##0.000"
      Me.txtIVA.Location = New System.Drawing.Point(301, 36)
      Me.txtIVA.Name = "txtIVA"
      Me.txtIVA.ReadOnly = True
      Me.txtIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtIVA.TabIndex = 21
      Me.txtIVA.TabStop = False
      Me.txtIVA.Text = "0,000"
      Me.txtIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNeto
      '
      Me.txtNeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtNeto.BackColor = System.Drawing.SystemColors.Info
      Me.txtNeto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNeto.FormatString = "##,##0.000"
      Me.txtNeto.Location = New System.Drawing.Point(301, 12)
      Me.txtNeto.Name = "txtNeto"
      Me.txtNeto.ReadOnly = True
      Me.txtNeto.Size = New System.Drawing.Size(108, 20)
      Me.txtNeto.TabIndex = 20
      Me.txtNeto.TabStop = False
      Me.txtNeto.Text = "0,000"
      Me.txtNeto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtNeto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtNeto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtExento
      '
      Me.txtExento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtExento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtExento.FormatString = "##,##0.000"
      Me.txtExento.Location = New System.Drawing.Point(93, 60)
      Me.txtExento.Name = "txtExento"
      Me.txtExento.ReadOnly = True
      Me.txtExento.Size = New System.Drawing.Size(108, 20)
      Me.txtExento.TabIndex = 19
      Me.txtExento.TabStop = False
      Me.txtExento.Text = "0,000"
      Me.txtExento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtExento.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtExento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIceIehd
      '
      Me.txtIceIehd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtIceIehd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIceIehd.FormatString = "##,##0.000"
      Me.txtIceIehd.Location = New System.Drawing.Point(93, 36)
      Me.txtIceIehd.Name = "txtIceIehd"
      Me.txtIceIehd.ReadOnly = True
      Me.txtIceIehd.Size = New System.Drawing.Size(108, 20)
      Me.txtIceIehd.TabIndex = 18
      Me.txtIceIehd.TabStop = False
      Me.txtIceIehd.Text = "0,000"
      Me.txtIceIehd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIceIehd.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIceIehd.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtFacturaMonto
      '
      Me.txtFacturaMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtFacturaMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaMonto.FormatString = "##,##0.000"
      Me.txtFacturaMonto.Location = New System.Drawing.Point(93, 12)
      Me.txtFacturaMonto.Name = "txtFacturaMonto"
      Me.txtFacturaMonto.ReadOnly = True
      Me.txtFacturaMonto.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaMonto.TabIndex = 17
      Me.txtFacturaMonto.TabStop = False
      Me.txtFacturaMonto.Text = "0,000"
      Me.txtFacturaMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtFacturaMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtFacturaMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(212, 61)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(88, 17)
      Me.Label3.TabIndex = 194
      Me.Label3.Text = "Imp Bruto-IVA"
      '
      'Label4
      '
      Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(212, 40)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(88, 16)
      Me.Label4.TabIndex = 193
      Me.Label4.Text = "IVA"
      '
      'Label5
      '
      Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(212, 15)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(88, 17)
      Me.Label5.TabIndex = 192
      Me.Label5.Text = "Importe Neto"
      '
      'Label6
      '
      Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(9, 62)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(79, 17)
      Me.Label6.TabIndex = 13
      Me.Label6.Text = "Exento"
      '
      'Label7
      '
      Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(9, 39)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(79, 17)
      Me.Label7.TabIndex = 12
      Me.Label7.Text = "ICE / IEHD"
      '
      'Label8
      '
      Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(9, 16)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(96, 16)
      Me.Label8.TabIndex = 11
      Me.Label8.Text = "Importe Bruto"
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
      ExplorerBarGroup1.ContainerHeight = 168
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 148)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(762, 200)
      Me.ebrMain.TabIndex = 12
      Me.ebrMain.TabStop = False
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Delete
      '
      Me.Delete.ImageIndex = 2
      Me.Delete.Key = "Delete"
      Me.Delete.Name = "Delete"
      Me.Delete.Text = "Eliminar"
      '
      'BottomRebar1
      '
      Me.BottomRebar1.CommandManager = Me.cdmMain
      Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.BottomRebar1.Location = New System.Drawing.Point(0, 475)
      Me.BottomRebar1.Name = "BottomRebar1"
      Me.BottomRebar1.Size = New System.Drawing.Size(759, 0)
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Exit3, Me.Save})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("55df5f76-479b-4f4e-8e69-68c99cb73b74")
      Me.cdmMain.ImageList = Me.ilsMain
      Me.cdmMain.LeftRebar = Me.LeftRebar1
      Me.cdmMain.RightRebar = Me.RightRebar1
      Me.cdmMain.TopRebar = Me.TopRebar1
      Me.cdmMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'UiCommandBar1
      '
      Me.UiCommandBar1.CommandManager = Me.cdmMain
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(155, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.ImageIndex = 1
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Exit3
      '
      Me.Exit3.ImageIndex = 5
      Me.Exit3.Key = "Exit"
      Me.Exit3.Name = "Exit3"
      Me.Exit3.Text = "Salir"
      '
      'Save
      '
      Me.Save.ImageIndex = 1
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.Text = "Guardar"
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
      Me.ilsMain.Images.SetKeyName(8, "Ventas.ico")
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 28)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 447)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(759, 28)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 447)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(770, 28)
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'cboTipoFacCompra
      '
      Me.cboTipoFacCompra.DropListFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFacCompra.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFacCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.Location = New System.Drawing.Point(96, 80)
      Me.cboTipoFacCompra.Name = "cboTipoFacCompra"
      Me.cboTipoFacCompra.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoFacCompra.Size = New System.Drawing.Size(232, 20)
      Me.cboTipoFacCompra.TabIndex = 15
      Me.cboTipoFacCompra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblTipoFacCompraId
      '
      Me.lblTipoFacCompraId.BackColor = System.Drawing.Color.Transparent
      Me.lblTipoFacCompraId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTipoFacCompraId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblTipoFacCompraId.Location = New System.Drawing.Point(8, 84)
      Me.lblTipoFacCompraId.Name = "lblTipoFacCompraId"
      Me.lblTipoFacCompraId.Size = New System.Drawing.Size(88, 16)
      Me.lblTipoFacCompraId.TabIndex = 288
      Me.lblTipoFacCompraId.Text = "Tipo Compra"
      '
      'frmFacturaDifDetEdit
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(770, 494)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmFacturaDifDetEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Nueva Factura"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.grpFactura, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpFactura.ResumeLayout(False)
      Me.grpFactura.PerformLayout()
      CType(Me.cboNroRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboRegRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.grpCompra, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpCompra.ResumeLayout(False)
      Me.grpCompra.PerformLayout()
      CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents Exit3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtFacturaObs As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtImporteIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNeto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtExento As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIceIehd As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtFacturaMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key

         Case "Save"
            If DataSave() Then
               mlngID = moFactura.FacturaId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor

   End Sub

   Private Sub frmFacturaDifDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)

   End Sub

   Private Sub frmFacturaDifDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      ''''''''''''''''''''''''''''''''''''''''''
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor
      Dim strTipoFactura As String

      ''mboolLoading = True

      Call FormInit()
      Call ComboLoad()

      If moFactura.TipoFacturaId = 1 Then
         strTipoFactura = "Factura de venta"

      ElseIf moFactura.TipoFacturaId = 2 Then
         strTipoFactura = "Factura de Compra"
      End If

      If Not mboolAdding Then
         Call FormShow()
         ''If Not mboolEditing Then
         ''   Call DataReadOnly()
         ''   Me.Text = "Consulta " + strTipoFactura
         ''Else
         ''   Me.Text = "Editar " + strTipoFactura
         ''End If
      Else
         Me.Text = "Nueva " + strTipoFactura
         Call FormNew()
      End If

      ''mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      ''mboolShow = True
      With moFactura
         txtFacturaId.Text = ToStr(.FacturaId)
         dtpFacturaFecha.Text = ToStr(.FacturaFecha)
         cboRegRUC.Tag = ToStr(.RegRUCDes)
         cboRegRUC.Text = ToStr(.RegRUCDes)
         cboNroRUC.Tag = ToStr(.NroRUC)
         cboNroRUC.Text = ToStr(.NroRUC)
         txtNroAutorizacion.Text = ToStr(.NroAutorizacion)
         txtCodControl.Text = ToStr(.CodControl)

         txtFacturaNro.Text = ToStr(.FacturaNro)
         txtFacturaMonto.Text = ToDecStr(.FacturaMonto)
         txtIceIehd.Text = ToDecStr(.IceIehd)
         txtExento.Text = ToDecStr(.Exento)
         txtNeto.Text = ToDecStr(.FacturaMonto - (.Exento + .IceIehd))
         txtIVA.Text = ToDecStr(.IVA)
         txtImporteIVA.Text = ToDecStr(.FacturaMonto - .IVA)
         txtFacturaObs.Text = ToStr(.FacturaObs)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         cboEstado.ReadOnly = True

         If .FacturaMonto >= 50000 Then
            chkBancarizar.Checked = True
         Else
            chkBancarizar.Checked = False
         End If

         txtFacturaNro.Select()
      End With
      ''mboolShow = False
   End Sub

   Private Sub DataClear()
      With moFactura
         txtFacturaId.Text = String.Empty
         dtpFacturaFecha.Text = .FacturaFecha
         cboRegRUC.Value = Nothing
         cboRegRUC.Tag = Nothing
         cboNroRUC.Value = Nothing
         cboNroRUC.Tag = Nothing

         If moFactura.TipoFacturaId = 1 Then 'Venta
            txtNroAutorizacion.ReadOnly = True

         Else 'Compra
            txtNroAutorizacion.Text = String.Empty
         End If

         txtCodControl.Text = String.Empty
         txtFacturaNro.Text = ToStr(.FacturaNro)
         txtFacturaMonto.Text = .FacturaMonto
         txtIceIehd.Text = "0"
         txtExento.Text = "0"
         txtNeto.Text = ToDecStr(.FacturaMonto)
         txtIVA.Text = ToDecStr(.FacturaMonto * clsAppInfo.IVA)
         txtImporteIVA.Text = ToDecStr(.FacturaMonto - (.FacturaMonto * clsAppInfo.IVA))
         txtFacturaObs.Text = String.Empty

         cboTipoFacCompra.SelectedIndex = -1
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)

         If .FacturaMonto >= 50000 Then
            chkBancarizar.Checked = True
         Else
            chkBancarizar.Checked = False
         End If

         mdecMontoFacOrig = .FacturaMonto
         mdecExentoOrig = .Exento
         cboProveedor.Value = ListFindItem(cboProveedor, mlngProveedorId)
         txtTipoCambio.Text = mdecTipoCambio
         Call CompraLoad(mlngCompraId)

         If (ToDecimal(txtMontoFact.Text) = 0) And (ToDecimal(txtExentoFac.Text) = 0) Then
            chkFacturaNoValida.Enabled = True
         End If

         If ToDecimal(txtExentoAFac.Text) = 0 Then
            txtExentoAFac.ReadOnly = True
         End If

         Call grdMainLoad()

      End With
   End Sub

   Private Sub DataReadOnly()
      dtpFacturaFecha.ReadOnly = True
      cboRegRUC.ReadOnly = True
      cboNroRUC.ReadOnly = True
      txtFacturaNro.ReadOnly = True
      txtFacturaObs.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtNroAutorizacion.ReadOnly = True
      txtCodControl.ReadOnly = True

      cboTipoFacCompra.ReadOnly = True
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtFacturaNro.Select()
   End Sub

   Private Sub grdMainLoad()
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

      Try
         With oCompraDet
            .SelectFilter = clsCompraDet.SelectFilters.Grid
            .WhereFilter = clsCompraDet.WhereFilters.Grid
            .OrderByFilter = clsCompraDet.OrderByFilters.Grid
            .EmpresaId = moFactura.EmpresaId
            .CompraId = mlngCompraId

            If .Open() Then
               Call moDataSetInit()

               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRowShow(oRow))

               Next

               grdMain.DataSource = moDataSet.Tables(moFactura.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataMove()
      With moFactura
         If Not mboolAdding Then
            .FacturaId = ToLong(txtFacturaId.Text)
         End If

         .MesId = dtpFacturaFecha.Value.Month
         .FacturaFecha = ToDate(dtpFacturaFecha.Value)
         .FacturaNro = ToLong(txtFacturaNro.Text)
         .FacturaMonto = ToDecimal(txtFacturaMonto.Text)

         If ListPosition(cboNroRUC) > 0 Then
            .RegRUCId = ListPosition(cboNroRUC)
            If RegRucIdFind(ListPosition(cboNroRUC)) = 0 Then
               .RegRUCId = 0
            End If

         ElseIf ListPosition(cboRegRUC) > 0 Then
            .RegRUCId = ListPosition(cboRegRUC)

            If RegRucIdFind(ListPosition(cboRegRUC)) = 0 Then
               .RegRUCId = 0
            End If

         Else
            .RegRUCId = 0
         End If

         .RegRUCDes = ToStr(cboRegRUC.Text)
         .NroRUC = ToStr(cboNroRUC.Text)
         .NroAutorizacion = ToStr(txtNroAutorizacion.Text)

         .IVA = ToDecimal(txtIVA.Text)
         .IceIehd = ToDecimal(txtIceIehd.Text)
         .Exento = ToDecimal(txtExento.Text)
         .FacturaObs = ToStr(txtFacturaObs.Text)
         .Bancarizar = ToBoolean(chkBancarizar.Checked)
         .TipoFacCompraId = ListPosition(cboTipoFacCompra, cboTipoFacCompra.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

         .CodControl = ToStr(txtCodControl.Text)
         Do While (Microsoft.VisualBasic.Right(.CodControl, 1) = "-") And (.CodControl.Length > 2)
            .CodControl = Microsoft.VisualBasic.Left(.CodControl, .CodControl.Length - 1)
         Loop

         mdecMontoFac = ToDecimal(txtMontoAFact.Text)

         .AppId = clsAppInfo.AppId
         .TipoDocumentoId = 0
         .DocumentoId = moFactura.FacturaId
      End With
   End Sub

   Private Function RegRUCAdd() As Boolean
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.RegRUC
            .EmpresaId = moFactura.EmpresaId
            .NroRUC = moFactura.NroRUC
            .RegRUCDes = moFactura.RegRUCDes

            If Not .Find Then
               .EmpresaId = moFactura.EmpresaId
               .NroRUC = moFactura.NroRUC
               .RegRUCDes = moFactura.RegRUCDes
               .PlanId = 0

               If moFactura.TipoFacturaId = 1 Then 'Ventas
                  .NroAutorizacion = "0"
               Else
                  .NroAutorizacion = moFactura.NroAutorizacion
               End If

               If .Insert Then
                  RegRUCAdd = True
               End If

            Else
               RegRUCAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Function DataSave() As Boolean
      Try
         txtFacturaNro.Select()
         Call DataMove()

         If Not (chkFacturaNoValida.Checked) Then  ''Factura Normal 
            DataSave = DataAdd()
         Else
            DataSave = DataAddNoValida()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Dim lngTipoCompId As Long
      Dim lngCompId As Long

      Try
         Dim CompraFacId As Long
         DataAdd = False

         If FormCheck() Then
            If FormCheckFacDif() Then
               If moFactura.Insert() Then
                  If moFactura.RegRUCId = 0 Then
                     Call RegRUCAdd()
                  Else
                     If mstrNroAutorizacion <> (txtNroAutorizacion.Text).Trim Then
                        RegRUCUpdate()
                     End If
                  End If

                  If CompraFacAdd(CompraFacId) Then

                     If CompNew(lngTipoCompId, lngCompId) Then
                        If CompraUpdate(mlngCompraId, mdecMontoFac) Then 'Estado Realizado
                           DataAdd = True
                           If DataUpdate() Then
                              DataAdd = True
                           End If

                        End If
                     End If
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         Throw exp

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
      If Not clsAppInfo.CentroCostoApli Then
         mlngCentroCostoId = 0
      End If
      mlngCentroCostoDetId = 0
      mlngTipoPlanId = 0

      mlngSucursalId = moFactura.SucursalIdOrg

      With frm
         .EmpresaId = moFactura.EmpresaId
         .PlanWhereFilter = clsPlan.WhereFilters.EsAna
         ''.chkTieneComp.Visible = True
         ''.Editing = False
         ''.NewRecord = True
         .ShowDialog()

         If .Changed Then
            mlngPlanId = frm.PlanId
            mlngPlanAddId = frm.PlanAddId
            mlngSucursalId = frm.SucursalId
            mlngCentroCostoId = frm.CentroCostoId
            mlngCentroCostoDetId = frm.CentroCostoDetId
            mboolTieneComp = frm.TieneComp

            frmCompPlanFill = True
         End If
         frm.Dispose()
      End With

   End Function

   Private Function RegRUCUpdate() As Boolean
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC

            .RegRUCId = moFactura.RegRUCId

            If .FindByPK Then
               .NroAutorizacion = moFactura.NroAutorizacion

               If .Update() Then
                  RegRUCUpdate = True
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Function DataAddNoValida() As Boolean
      Dim lngTipoCompId As Long
      Dim lngCompId As Long

      Try
         Dim CompraFacId As Long
         DataAddNoValida = False

         If FormCheck() Then
            If FormCheckFacDif() Then
               If (moFactura.FacturaMonto - moFactura.Exento) > 0 Then ''Genera Comprobante

                  If frmCompPlanFill() Then  '' Va a ir a Contabilidad

                     If moFactura.Insert() Then
                        If moFactura.RegRUCId = 0 Then
                           Call RegRUCAdd()
                        Else
                           If mstrNroAutorizacion <> (txtNroAutorizacion.Text).Trim Then
                              RegRUCUpdate()
                           End If
                        End If

                        If CompraFacAdd(CompraFacId) Then
                           If CompNewCompraFacNoValida() Then
                              If CompraUpdate(mlngCompraId, mdecMontoFac) Then 'Estado Realizado
                                 DataAddNoValida = True
                                 If DataUpdate() Then
                                    DataAddNoValida = True
                                 End If
                              End If
                           End If

                        End If
                     End If
                  End If
               Else

                  If moFactura.Insert() Then
                     If moFactura.RegRUCId = 0 Then
                        Call RegRUCAdd()
                     Else
                        If mstrNroAutorizacion <> (txtNroAutorizacion.Text).Trim Then
                           RegRUCUpdate()
                        End If
                     End If

                     If CompraFacAdd(CompraFacId) Then
                        If CompraUpdate(mlngCompraId, mdecMontoFac) Then 'Estado Realizado
                           DataAddNoValida = True
                           If DataUpdate() Then
                              DataAddNoValida = True
                           End If
                        End If

                     End If
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moFactura.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function CompraFacAdd(ByRef lngCompraFacId As Long) As Boolean

      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)

      CompraFacAdd = False

      Try
         With oCompraFac
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .FacturaId = moFactura.FacturaId
            .CompraId = mlngCompraId
            .TipoCambio = mdecTipoCambio

            If .Insert() Then
               lngCompraFacId = .CompraFacId
               CompraFacAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraFac.Dispose()

      End Try
   End Function

   Private Function CompraUpdate(ByVal lngCompraId As Long, ByVal decMontoFac As Decimal) As Boolean
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      CompraUpdate = False

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .MontoFac = decMontoFac

               .UpdateFilter = clsCompra.UpdateFilters.MontoFac

               If .Update() Then
                  CompraUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function CompNew(ByRef lngTipoCompId As Long, ByRef lngCompId As Long) As Boolean
      lngTipoCompId = 3
      Dim lngCompNro As Long
      Dim lngCompDetId As Long

      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal

      Dim decMontoIvaBs As Decimal
      Dim decMontoIvaUs As Decimal
      Dim decIvaBs As Decimal = 0
      Dim decIvaUs As Decimal = 0
      Dim decIvaOrg As Decimal = 0

      Dim decITBs As Decimal = 0
      Dim decITUs As Decimal = 0
      Dim decITOrg As Decimal = 0

      CompNew = False
      Try

         decMontoBs = ToDecimal(moFactura.FacturaMonto)
         decMontoUs = ToDecimal(decMontoBs / mdecTipoCambio)
         decMontoOrg = decMontoBs

         decIvaBs = ToDecimal(moFactura.IVA)
         decIvaUs = ToDecimal(decIvaBs / mdecTipoCambio)
         decIvaOrg = ToDecimal(moFactura.IVA)

         decMontoIvaBs = decMontoBs - decIvaBs
         decMontoIvaUs = decMontoUs - decIvaUs

         If decIvaOrg > 0 Then

            If CompAdd(mdecTipoCambio, "", decIvaBs, decIvaUs, lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante
               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreId, "", decIvaBs, decIvaUs, decIvaOrg, 1, moFactura.SucursalIdOrg, mlngCentroCostoId, , 1) Then
                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreDifId, "", decIvaBs, decIvaUs, decIvaOrg, 2, moFactura.SucursalIdOrg, mlngCentroCostoId, , 1) Then

                     moFactura.TipoCompId = lngTipoCompId
                     moFactura.CompId = lngCompId
                     moFactura.CompDetId = lngCompDetId
                     CompNew = True
                  End If
               End If

            End If
         Else
            '' No va a generar Factura
            moFactura.TipoCompId = 0
            moFactura.CompId = 0
            moFactura.CompDetId = 0
            CompNew = True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompNewCompraFacNoValida() As Boolean
      Dim decTipoCambio As Decimal
      Dim lngTipoCompId As Long = 3
      Dim strDes As String
      Dim lngCompId As Long
      Dim lngCompNro As Long
      Dim lngCompDetId As Long

      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal

      Dim decMontoIvaBs As Decimal
      Dim decMontoIvaUs As Decimal
      Dim decIvaBs As Decimal = 0
      Dim decIvaUs As Decimal = 0
      Dim decIvaOrg As Decimal = 0

      CompNewCompraFacNoValida = False

      Try

         decMontoBs = ToDecimal(moFactura.FacturaMonto)
         decMontoUs = ToDecimal(decMontoBs / mdecTipoCambio)
         decMontoOrg = decMontoBs

         decIvaBs = ToDecimal(moFactura.IVA)
         decIvaUs = ToDecimal(decIvaBs / mdecTipoCambio)
         decIvaOrg = ToDecimal(moFactura.IVA)

         decMontoIvaBs = decMontoBs - decIvaBs
         decMontoIvaUs = decMontoUs - decIvaUs

         If CompAdd(mdecTipoCambio, "; con Factura Diferida NO VÀLIDA", decIvaBs, decIvaUs, lngTipoCompId, lngCompNro, lngCompId) Then 'Cabecera Comprobante
            If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "; con Factura Diferida NO VÀLIDA", decIvaBs, decIvaUs, decIvaOrg, 1, moFactura.SucursalIdOrg, mlngCentroCostoId, lngCompDetId, ) Then

               If mlngPlanAddId <> 0 Then  'Analitico Adicional
                  If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, decIvaBs, decIvaUs, 1, moFactura.SucursalIdOrg) Then
                     CompNewCompraFacNoValida = True
                  End If
               End If

               If mlngCentroCostoDetId <> 0 Then  'Actividad
                  If CompCentroCostoDetAdd(lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, decIvaBs, decIvaUs, 1, moFactura.SucursalIdOrg) Then
                     CompNewCompraFacNoValida = True
                  End If
               End If

               ''Cuenta contra Cuenta
               If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreDifId, "", decIvaBs, decIvaUs, decIvaOrg, 2, moFactura.SucursalIdOrg, mlngCentroCostoId, lngCompDetId, 1) Then

                  moFactura.TipoCompId = lngTipoCompId
                  moFactura.CompId = lngCompId
                  moFactura.CompDetId = lngCompDetId
                  CompNewCompraFacNoValida = True

               End If

            End If

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompAdd(ByVal decTipoCambio As Decimal, ByVal strDes As String, ByVal decMontoBs As Decimal, ByVal decMontoUs As Decimal, _
                        ByVal lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = CompNroNext(.TipoCompId, moFactura.EmpresaId, moFactura.GestionId, moFactura.SucursalIdOrg, dtpFacturaFecha.Value)
            .Fecha = moFactura.FacturaFecha
            .MonedaId = 1
            .TipoCambio = decTipoCambio
            .EntregadoA = moFactura.RegRUCDes
            .PorConcepto = "Factura Nro. " & moFactura.FacturaNro & "; Factura Diferida de Compra Nro. " & ToStr(txtCompraNro.Text) & strDes
            .DebeBs = decMontoBs
            .HaberBs = decMontoBs
            .DebeUs = decMontoUs
            .HaberUs = decMontoUs
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF

            If clsAppInfo.MultipleNro Then
               .SinFac = 1
               .ConFac = 1
            Else
               .SinFac = 1
               .ConFac = 0
            End If

            .Automatico = 0
            .Glosa = ""
            '.TipoNotaId = 0
            '.NotaNro = 0
            .TipoAsientoId = 0
            .EstadoId = 10

            .SucursalId = moFactura.SucursalIdOrg
            .NotaId = 0
            .AppId = clsAppInfo.AppId
            .DocumentoId = moFactura.FacturaId

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
      Dim lngSucCCOId As Long

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = moFactura.FacturaFecha
            .PlanId = lngPlanId
            .CompDetDes = "Factura Nro. " & moFactura.FacturaNro & strDes
            .MonedaId = 1

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

            'lngSucCCOId = PlanSucCCOId(.PlanId)

            'If lngSucCCOId = 1 Then
            .SucursalId = lngSucursalId

            'ElseIf lngSucCCOId = 2 Then
            .CentroCostoId = lngCentroCostoId
            'End If

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

   Private Function CompPlanAddAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
                          ByVal lngPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAdd = False

      Try
         With oCompPlanAdd
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moFactura.FacturaFecha
            .PlanId = lngPlanId
            .MonedaId = 1
            .PlanAddId = lngPlanAddId
            .SucursalId = lngSucursalId
            .EstadoId = 10

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
            .EmpresaId = moFactura.EmpresaId
            .GestionId = moFactura.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moFactura.FacturaFecha
            .PlanId = lngPlanId
            .MonedaId = 1
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

   Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByVal datFecha As Date) As Long
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompNroNext = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = lngEmpresaId
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
                        'If chkConFac.Checked Then
                        .NroActualFis = .NroActualFis + 1

                        If .Update Then
                           CompNroNext = .NroActualFis
                        End If

                        'Else
                        '   .NroActual = .NroActual + 1

                        '   If .Update Then
                        '      CompNroNext = .NroActual
                        '   End If
                        'End If
                     End If
                  Else
                     CompNroNext = CompNroMesNext(lngTipoCompId, lngEmpresaId, lngGestionId, lngSucursalId, datFecha.Month)
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

   Private Function CompNroMesNext(ByVal lngTipoCompId As Long, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByVal intMesId As Integer) As Long
      Dim oCompParaMes As New clsCompParaMes(clsAppInfo.ConnectString)

      Try
         CompNroMesNext = 0

         With oCompParaMes
            .SelectFilter = clsCompParaMes.SelectFilters.All
            .WhereFilter = clsCompParaMes.WhereFilters.MesId
            .EmpresaId = lngEmpresaId
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
                  'If chkConFac.Checked Then
                  .NroActualFis = .NroActualFis + 1

                  If .Update Then
                     CompNroMesNext = .NroActualFis
                  End If

                  'Else
                  '   .NroActual = .NroActual + 1

                  '   If .Update Then
                  '      CompNroMesNext = .NroActual
                  '   End If
                  'End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompParaMes.Dispose()

      End Try
   End Function

   Private Function PlanSucCCOId(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanSucCCOId = 0

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanSucCCOId = .SucCCOId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Sub CompraLoad(ByVal lngCompraId As Long)
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               txtCompraNro.Text = ToStr(.CompraNro)
               cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
               cboTipoPago.SelectedIndex = ListFindItem(cboTipoPago, .TipoPagoId)
               txtMontoFact.Text = ToDecStr(.MontoFac)
               txtMontoAFact.Text = ToDecStr(.MontoBru - .MontoFac)
               txtExentoFac.Text = ToDecStr(mdecExentoFac)
               txtExentoAFac.Text = ToDecStr(.FactDifExento - mdecExentoFac)
               mdecMontoCompra = .MontoBru
               mdecExentoCompra = .FactDifExento

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
            .EmpresaId = moFactura.EmpresaId
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

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If ToStr(dtpFacturaFecha.Text) = "" Then
         strMsg &= "Fecha de Factura no Válida" & vbCrLf
      End If

      If moFactura.TipoFacturaId = 1 Then 'Venta
         If moFactura.RegRUCDes = "" Then
            strMsg &= "Razón Social Inválida" & vbCrLf

            If moFactura.FacturaNro <= 0 Then
               strMsg &= "Número de Factura Inválido" & vbCrLf
            End If

            If moFactura.NroRUC = "0" Then
               strMsg &= "Número de NIT Inválido" & vbCrLf
            End If

            If moFactura.NroAutorizacion = "0" Then
               strMsg &= "Número de Autorización Inválido" & vbCrLf
            End If

            If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
               strMsg &= "Código de Control Inválido" & vbCrLf
            End If

            If moFactura.FacturaMonto <= 0 Then
               strMsg &= "Importe Inválido" & vbCrLf

            ElseIf moFactura.IceIehd + moFactura.Exento > moFactura.FacturaMonto Then
               strMsg &= "El ICE/IEHD y el Exento Deben Ser Menor al Importe" & vbCrLf
            End If

         ElseIf (moFactura.RegRUCId > 0) And (moFactura.RegRUCId < 4) Then 'Anuladas
            If moFactura.FacturaNro <= 0 Then
               strMsg &= "Número de Factura Inválido" & vbCrLf
            End If

            If moFactura.NroRUC <> "0" Then
               strMsg &= "Número de NIT Inválido" & vbCrLf
            End If

            If moFactura.NroAutorizacion = "0" Then
               strMsg &= "Número de Autorización Inválido" & vbCrLf
            End If

            If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
               strMsg &= "Código de Control Inválido" & vbCrLf
            End If

            If moFactura.FacturaMonto <> 0 Then
               strMsg &= "Importe Inválido" & vbCrLf
            End If

         Else
            If moFactura.FacturaNro <= 0 Then
               strMsg &= "Número de Factura Inválido" & vbCrLf
            End If

            If moFactura.NroRUC = "0" Then
               strMsg &= "Número de NIT Inválido" & vbCrLf
            End If

            If moFactura.NroAutorizacion = "0" Then
               strMsg &= "Número de Autorización Inválido" & vbCrLf
            End If

            If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
               strMsg &= "Código de Control Inválido" & vbCrLf
            End If

            If moFactura.FacturaMonto <= 0 Then
               strMsg &= "Importe Inválido" & vbCrLf

            ElseIf moFactura.FacturaMonto > mdecMontoFacOrig Then
               strMsg &= "Importe Inválido NO puede Mayor al Monto a Facturar" & vbCrLf

            ElseIf moFactura.Exento > mdecExentoOrig Then
               strMsg &= "Exento Inválido NO puede Mayor al Exento a Facturar" & vbCrLf

            ElseIf moFactura.IceIehd + moFactura.Exento > moFactura.FacturaMonto Then
               strMsg &= "El ICE/IEHD y el Exento Deben Ser Menor al Importe" & vbCrLf
            End If
         End If

      Else 'Compra
         If moFactura.FacturaNro <= 0 Then
            strMsg &= "Número de Factura Inválido" & vbCrLf
         End If

         If moFactura.RegRUCDes = "" Then
            strMsg &= "Razón Social Inválida" & vbCrLf

         ElseIf (moFactura.RegRUCId > 0) And (moFactura.RegRUCId < 4) Then
            FormCheck = False
            Throw New Exception("Razón Social Inválida en Factura de Compra")
         End If

         If moFactura.NroRUC = "0" Then
            strMsg &= "Número de NIT Inválido" & vbCrLf
         End If

         If moFactura.NroAutorizacion = "0" Then
            strMsg &= "Número de Autorización Inválido" & vbCrLf
         End If

         If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
            strMsg &= "Código de Control Inválido" & vbCrLf
         End If

         If moFactura.FacturaMonto <= 0 Then
            strMsg &= "Importe Inválido" & vbCrLf

         ElseIf moFactura.FacturaMonto > mdecMontoFacOrig Then
            strMsg &= "Importe Inválido NO puede Mayor al Monto a Facturar" & vbCrLf

         ElseIf moFactura.Exento > mdecExentoOrig Then
            strMsg &= "Exento Inválido NO puede Mayor al Exento a Facturar" & vbCrLf

         ElseIf moFactura.IceIehd + moFactura.Exento > moFactura.FacturaMonto Then
            strMsg &= "El ICE/IEHD y el Exento Deben Ser Menor al Importe" & vbCrLf
         End If

         If moFactura.TipoFacCompraId <= 0 Then
            strMsg &= "Tipo de Compra Inválido" & vbCrLf
         End If

      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function FormCheckFacDif() As Boolean
      Dim strMsg As String = String.Empty

      If moFactura.FacturaMonto > mdecMontoFacOrig Then
         strMsg &= "Importe Inválido NO puede Mayor al Monto a Facturar" & vbCrLf

      ElseIf moFactura.Exento < 0 Then
         strMsg &= "Exento Inválido" & vbCrLf

      ElseIf moFactura.IceIehd < 0 Then
         strMsg &= "ICE/IEHD Inválido" & vbCrLf

      ElseIf moFactura.Exento > mdecExentoOrig Then
         strMsg &= "Exento Inválido NO puede Mayor al Exento a Facturar" & vbCrLf

      ElseIf moFactura.IceIehd + moFactura.Exento > moFactura.FacturaMonto Then
         strMsg &= "El ICE/IEHD y el Exento Deben Ser Menor al Importe" & vbCrLf

      ElseIf moFactura.FacturaMonto = mdecMontoFacOrig Then
         If moFactura.Exento <> mdecExentoOrig Then
            strMsg &= "Exento Inválido DEBE Ingresar el Exento establecido" & vbCrLf
         End If
      ElseIf (mdecMontoFacOrig - mdecExentoOrig) = 0 Then
         If moFactura.Exento <> moFactura.FacturaMonto Then
            strMsg &= "Importe y Exento Inválido, Ambos tienen q ser iguales" & vbCrLf
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheckFacDif = False
      Else
         FormCheckFacDif = True
      End If
   End Function

   Private Sub grdMainClear()
      Call grdMainLoad()
   End Sub

   Private Sub PrintReport()
      ''PrintReportGautier()  'SOLO PARA GAUTIER
      ''PrintReportRacco() 'SOLO PARA RACCO

   End Sub

   Private Function SucursalDesFind(ByVal lngSucursalId As Long, ByRef strDireccion As String, ByRef strTelefono As String, ByRef lngCiudadId As Long) As String
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)

      SucursalDesFind = ""

      Try
         With oSucursal
            .SucursalId = lngSucursalId

            If .FindByPK Then
               strDireccion = .Direccion
               strTelefono = .Telefono
               lngCiudadId = .CiudadId
               Return .SucursalDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()

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
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCiudad.Dispose()

      End Try
   End Function

   Private Function GestionFind(ByVal lngGestionId As Long) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionFind = 0

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               GestionFind = .Gestion
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()
      End Try
   End Function

   Private Function CompUpdate(ByVal lngCompId As Long, ByVal decTotalBs As Decimal, ByVal decTotalUs As Decimal) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompUpdate = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               .Fecha = moFactura.FacturaFecha
               .MonedaId = mlngMonedaId
               .TipoCambio = ToDecimal(txtTipoCambio.Text)
               .EntregadoA = "Factura Nro. " & ToStr(moFactura.FacturaNro)
               .PorConcepto = ""
               .DebeBs = decTotalBs
               .HaberBs = decTotalBs
               .DebeUs = decTotalUs
               .HaberUs = decTotalUs
               .EstadoId = 10

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

   Private Sub ComboLoad()
      Call cboRegRUCLoad()
      Call cboEstadoLoad()

      Call cboTipoPagoLoad()
      Call cboProveedorLoad()
      Call cboMonedaLoad()
      Call cboTipoFacCompraLoad()
   End Sub

   Private Sub cboProveedorLoad()
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oListItem As clsListItem

      cboProveedor.DropDownList.Columns.Clear()

      Try
         With oProveedor
            .SelectFilter = clsProveedor.SelectFilters.ListBox
            .WhereFilter = clsProveedor.WhereFilters.EmpresaId
            .OrderByFilter = clsProveedor.OrderByFilters.ProveedorDes
            .EmpresaId = moFactura.EmpresaId

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

   Private Sub cboRegRUCLoad()
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.EmpresaId
            .OrderByFilter = clsRegRUC.OrderByFilters.RegRUCDes
            .EmpresaId = moFactura.EmpresaId

            If .Open() Then
               With cboRegRUC
                  .DropDownList.Columns.Clear()

                  .DropDownList.Columns.Add("RegRUCId")
                  .DropDownList.Columns("RegRUCId").DataMember = "RegRUCId"
                  .DropDownList.Columns("RegRUCId").Visible = False

                  .DropDownList.Columns.Add("NroRUC")
                  .DropDownList.Columns("NroRUC").Caption = "NIT"
                  .DropDownList.Columns("NroRUC").DataMember = "NroRUC"
                  .DropDownList.Columns("NroRUC").Width = 100

                  .DropDownList.Columns.Add("RegRUCDes")
                  .DropDownList.Columns("RegRUCDes").Caption = "Descripción"
                  .DropDownList.Columns("RegRUCDes").DataMember = "RegRUCDes"
                  .DropDownList.Columns("RegRUCDes").Width = 205

                  .DataMember = oRegRUC.TableName
                  .DataSource = oRegRUC.DataSet

                  .ValueMember = "RegRUCId"
                  .DisplayMember = "RegRUCDes"
               End With

               With cboNroRUC
                  .DropDownList.Columns.Clear()

                  .DropDownList.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False

                  .DropDownList.Columns.Add("RegRUCId")
                  .DropDownList.Columns("RegRUCId").DataMember = "RegRUCId"
                  .DropDownList.Columns("RegRUCId").Visible = False

                  .DropDownList.Columns.Add("NroRUC")
                  .DropDownList.Columns("NroRUC").DataMember = "NroRUC"
                  .DropDownList.Columns("NroRUC").Width = 90

                  .DataMember = oRegRUC.TableName
                  .DataSource = oRegRUC.DataSet

                  .ValueMember = "RegRUCId"
                  .DisplayMember = "NroRUC"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

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

                  If ((.EstadoId = 11 Or .EstadoId = 12) And mboolAnular) Or Not mboolAnular Then
                     oItem = New clsListItem(.EstadoId, .EstadoDes)
                     cboEstado.Items.Add(oItem)
                  End If

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

   Private Sub cboTipoFacCompraLoad()
      Dim oTipoFacCompra As New clsTipoFacCompra(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoFacCompra.Items.Clear()

      Try
         With oTipoFacCompra
            .SelectFilter = clsTipoFacCompra.SelectFilters.ListBox
            .OrderByFilter = clsTipoFacCompra.OrderByFilters.TipoFacCompraId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoFacCompraId, .TipoFacCompraDes)

                  cboTipoFacCompra.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoFacCompra.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub FormInit()

      txtFacturaMonto.FormatString = DecimalMask()
      txtIceIehd.FormatString = DecimalMask()
      txtExento.FormatString = DecimalMask()
      txtNeto.FormatString = DecimalMask()
      txtIVA.FormatString = DecimalMask()
      txtImporteIVA.FormatString = DecimalMask()
      txtTipoCambio.FormatString = DecimalMask()
      txtMontoAFact.FormatString = DecimalMask()
      txtMontoFact.FormatString = DecimalMask()
      txtExento.FormatString = DecimalMask()
      txtExentoAFac.FormatString = DecimalMask()

      mboolChanged = False

      txtFacturaNro.Select()

      Call grdMainClear()

   End Sub

   Private Function NroAutorizacionFind(ByVal lngRegRUCId As Long) As String
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC
            .RegRUCId = lngRegRUCId

            If .FindByPK Then
               NroAutorizacionFind = .NroAutorizacion
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Function DosificaLoad(ByVal lngEmpresaId As Long) As Boolean
      ' ''Dim oDosifica As New clsDosifica(clsAppInfo.ConnectString)

      ' ''Try
      ' ''   With oDosifica
      ' ''      .SelectFilter = clsDosifica.SelectFilters.All
      ' ''      .WhereFilter = clsDosifica.WhereFilters.TipoDosificaId
      ' ''      .OrderByFilter = clsDosifica.OrderByFilters.NumeroIni
      ' ''      .EmpresaId = lngEmpresaId
      ' ''      .TipoDosificaId = 1 'Manual
      ' ''      .SucursalId = moFactura.SucursalId
      ' ''      .EstadoId = 11

      ' ''      If .Open() Then
      ' ''         For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
      ' ''            If (ToLong(txtFacturaNro.Text) >= oRow("NumeroIni")) And (ToLong(txtFacturaNro.Text) <= oRow("NumeroFin")) Then
      ' ''               moFactura.SucursalId = oRow("SucursalId")
      ' ''               moFactura.DosificaId = oRow("DosificaId")
      ' ''               txtNroAutorizacion.Text = ToStr(oRow("NroAutorizacion"))
      ' ''            End If
      ' ''         Next
      ' ''      End If
      ' ''   End With

      ' ''Catch exp As Exception
      ' ''   MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      ' ''Finally
      ' ''   oDosifica.Dispose()

      ' ''End Try
   End Function

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

   Private Function RegRucIdFind(ByVal lngNroRuc As Long) As Long
      Dim oRegRuc As New clsRegRUC(clsAppInfo.ConnectString)

      RegRucIdFind = 0

      Try
         With oRegRuc
            .NroRUC = lngNroRuc
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.NroRUC

            If .Find Then
               RegRucIdFind = .RegRUCId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRuc.Dispose()

      End Try
   End Function

   Private Function RegRucIdFind(ByVal strRegRucDes As String) As Long
      Dim oRegRuc As New clsRegRUC(clsAppInfo.ConnectString)

      RegRucIdFind = 0

      Try
         With oRegRuc
            .RegRUCDes = strRegRucDes
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.RegRUCDes

            If .Find Then
               RegRucIdFind = .RegRUCId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRuc.Dispose()

      End Try
   End Function

   Private Sub moDataSetInit()
      moDataSet = New DataSet(moFactura.TableName)
      moDataTable = moDataSet.Tables.Add(moFactura.TableName)
      moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      ''moDataTable.Columns.Add("MonedaId", Type.GetType("System.Int32"))
      ''moDataTable.Columns.Add("TipoCambio", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Importe", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoRec", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("MontoDes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("ImporteNet", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Preciofac", Type.GetType("System.Decimal"))
   End Sub

   Private Function GetRowShow(ByVal oDataRow As DataRow) As DataRow

      '  Dim mModeda As Decimal = ToLong(oDataRow("MonedaId"))

      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("ItemId") = oDataRow("ItemId")
      oRow("ItemDes") = oDataRow("ItemDes")
      ''oRow("MonedaId") = oDataRow("MonedaId")
      ''oRow("TipoCambio") = oDataRow("TipoCambio")
      oRow("Cantidad") = oDataRow("Cantidad")

      If ToLong(oDataRow("MedidaId")) = 0 Then
         oRow("MedidaDes") = oDataRow("MedidaObs")
      Else
         oRow("MedidaDes") = oDataRow("MedidaDes")
      End If

      'If mModeda = 1 Then
      oRow("Importe") = ToDecimal(oDataRow("PrecioOrg")) * oDataRow("Cantidad")
      oRow("PrecioOrg") = ToDecimal(oDataRow("PrecioOrg"))
      oRow("MontoRec") = oDataRow("PrecioRec") * oDataRow("Cantidad")
      oRow("MontoDes") = oDataRow("PrecioDes") * oDataRow("Cantidad")

      'ElseIf mModeda = 2 Then
      '   oRow("PrecioOrg") = ToDecimal((oDataRow("PrecioOrg") - oDataRow("PrecioRec") + oDataRow("PrecioDes")) * oDataRow("TipoCambio"))
      '   oRow("Importe") = ToDecimal(oDataRow("ImporteOrg") * oDataRow("TipoCambio"))
      '   oRow("MontoRec") = ToDecimal(oDataRow("PrecioRec") * oDataRow("Cantidad") * oDataRow("TipoCambio"))
      '   oRow("MontoDes") = ToDecimal(oDataRow("PrecioDes") * oDataRow("Cantidad") * oDataRow("TipoCambio"))

      'End If

      oRow("ImporteNet") = ToDecimal(ToDecimal(oRow("Importe")) + ToDecimal(oRow("MontoRec")) - ToDecimal(oRow("MontoDes")))

      mdecMontoFac += oRow("ImporteNet")

      Return oRow
   End Function

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Detalle de la Factura"

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemDes").Caption = "Descripción"
         .RootTable.Columns("ItemDes").Width = 200
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         ''.RootTable.Columns("MonedaId").Visible = False

         ''.RootTable.Columns("TipoCambio").Visible = False

         .RootTable.Columns("Cantidad").Caption = "Cantidad"
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 100
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioOrg").Caption = "Precio Uni."
         .RootTable.Columns("PrecioOrg").FormatString = DecimalMask()
         .RootTable.Columns("PrecioOrg").Width = 100
         .RootTable.Columns("PrecioOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Importe").Caption = "Importe"
         .RootTable.Columns("Importe").FormatString = DecimalMask()
         .RootTable.Columns("Importe").Width = 100
         .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoRec").Caption = "Recargo"
         .RootTable.Columns("MontoRec").FormatString = DecimalMask()
         .RootTable.Columns("MontoRec").Width = 100
         .RootTable.Columns("MontoRec").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoRec").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoDes").Caption = "Descuento"
         .RootTable.Columns("MontoDes").FormatString = DecimalMask()
         .RootTable.Columns("MontoDes").Width = 100
         .RootTable.Columns("MontoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteNet").Caption = "Importe Neto"
         .RootTable.Columns("ImporteNet").FormatString = DecimalMask()
         .RootTable.Columns("ImporteNet").Width = 100
         .RootTable.Columns("ImporteNet").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteNet").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 60
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Preciofac").Visible = False
      End With
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub dtpFacturaFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFacturaFecha.LostFocus
      If mboolAdding Then
         If Not IsNothing(moFactura) Then
            If dtpFacturaFecha.Tag <> dtpFacturaFecha.Text Then
               If IsDate(dtpFacturaFecha.Text) Then
                  Call txtTipoCambioLoad(ToDate(dtpFacturaFecha.Value))
                  dtpFacturaFecha.Tag = dtpFacturaFecha.Text
               Else
                  txtTipoCambio.Text = 0
               End If
            End If
         End If
      End If
   End Sub

   Private Sub cboRegRUC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRegRUC.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            Dim frm As New frmRegRUCEdit
            Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

            Try
               With frm
                  .NewRecord = True
                  .Editing = False

                  oRegRUC.EmpresaId = moFactura.EmpresaId
                  .DataObject = oRegRUC
                  .ShowDialog()

                  If .Changed Then
                     Call cboRegRUCLoad()
                     cboRegRUC.Value = ListFindItem(cboRegRUC, ToLong(frm.ID))

                  End If
                  frm.Dispose()
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Finally
               oRegRUC.Dispose()

            End Try

         ElseIf e.KeyCode = Keys.F2 Then
            If ListPosition(cboRegRUC) <> 0 Then
               Dim frm As New frmRegRUCEdit
               Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

               Try
                  With frm
                     oRegRUC.RegRUCId = ListPosition(cboRegRUC)

                     If oRegRUC.FindByPK Then
                        .NewRecord = False
                        .Editing = True

                        .DataObject = oRegRUC
                        .ShowDialog()

                        If .Changed Then
                           Call cboRegRUCLoad()
                           cboRegRUC.Value = ListFindItem(cboRegRUC, ToLong(frm.ID))
                        End If
                        frm.Dispose()
                     End If
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oRegRUC.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboRegRUC_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegRUC.LostFocus

      If mboolAdding Then
         If cboRegRUC.Tag <> cboRegRUC.Text Then
            cboRegRUC.Tag = cboRegRUC.Text

            If ListPosition(cboRegRUC) <> 0 Then
               cboNroRUC.Value = ListFindItem(cboNroRUC, ListPosition(cboRegRUC))
               cboNroRUC.Tag = cboNroRUC.Text

               If moFactura.TipoFacturaId = 2 Then 'Compra
                  txtNroAutorizacion.Text = NroAutorizacionFind(ListPosition(cboRegRUC))
                  mstrNroAutorizacion = txtNroAutorizacion.Text
               End If

               txtCodControl.Text = ""
            End If
         End If
      End If
   End Sub

   Private Sub cboNroRUC_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNroRUC.LostFocus

      If mboolAdding Then
         If cboNroRUC.Tag <> cboNroRUC.Text Then
            cboNroRUC.Tag = cboNroRUC.Text

            If ListPosition(cboNroRUC) <> 0 Then
               cboRegRUC.Value = ListFindItem(cboRegRUC, ListPosition(cboNroRUC))
               cboRegRUC.Tag = cboRegRUC.Text

               If moFactura.TipoFacturaId = 2 Then 'Compra
                  txtNroAutorizacion.Text = NroAutorizacionFind(ListPosition(cboNroRUC))
                  mstrNroAutorizacion = txtNroAutorizacion.Text
               End If
               txtCodControl.Text = ""
            End If
         End If
      End If
   End Sub

   Private Sub cboNroRUC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboNroRUC.KeyPress

      If mboolAdding Then
         Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

         KeyAscii = CShort(SoloNumeros(KeyAscii))
         If KeyAscii = 0 Then
            e.Handled = True
         End If
      End If

   End Sub

   Private Sub chkCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      If chkCliente.Checked Then
         cboProveedor.DisplayMember = "ProveedorDes"
      Else
         cboProveedor.DisplayMember = "ClienteCod"
      End If
   End Sub

   Private Sub txtFacturaNro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturaNro.LostFocus

      If mboolAdding Then
         If txtFacturaNro.Tag <> txtFacturaNro.Text Then
            txtFacturaNro.Tag = txtFacturaNro.Text
            If moFactura.TipoFacturaId = 1 Then 'Venta
               txtNroAutorizacion.Text = "0"
               Call DosificaLoad(moFactura.EmpresaId)
            End If
         End If
      End If
   End Sub

   Private Sub txtNroAutorizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroAutorizacion.KeyPress

      ''If mboolAdding Then

      ''   Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

      ''   KeyAscii = CShort(SoloNumeros(KeyAscii))
      ''   If KeyAscii = 0 Then
      ''      e.Handled = True
      ''   End If
      ''End If

      Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

      KeyAscii = CShort(SoloNumeros(KeyAscii))
      If KeyAscii = 0 Then
         e.Handled = True
      End If

   End Sub

   Private Sub txtFacturaNro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFacturaNro.KeyPress

      If mboolAdding Then
         Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

         KeyAscii = CShort(SoloNumeros(KeyAscii))
         If KeyAscii = 0 Then
            e.Handled = True
         End If

      End If
   End Sub

   Private Sub txtFacturaMonto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFacturaMonto.KeyUp

      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - ToDecimal(txtIVA.Text))

      If ToDecimal(txtFacturaMonto.Text) >= 50000 Then
         chkBancarizar.Checked = True
      Else
         chkBancarizar.Checked = False
      End If

   End Sub

   Private Sub txtIceIehd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIceIehd.KeyUp

      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - ToDecimal(txtIVA.Text))

   End Sub

   Private Sub txtExento_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExento.KeyUp
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - ToDecimal(txtIVA.Text))
   End Sub

   Private Sub txtMontoAFact_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoAFact.ValueChanged
      If mlngMonedaId = 1 Then
         txtFacturaMonto.Text = ToDecimal(txtMontoAFact.Text)
      Else
         txtFacturaMonto.Text = ToDecimal(txtMontoAFact.Text) * mdecTipoCambio
      End If
   End Sub

   Private Sub txtFacturaMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFacturaMonto.ValueChanged
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - ToDecimal(txtIVA.Text))

      If ToDecimal(txtFacturaMonto.Text) >= 50000 Then
         chkBancarizar.Checked = True
      Else
         chkBancarizar.Checked = False
      End If
   End Sub

   Private Sub txtMontoAFact_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoAFact.KeyUp
      If mlngMonedaId = 1 Then
         txtFacturaMonto.Text = ToDecimal(txtMontoAFact.Text)
      Else
         txtFacturaMonto.Text = ToDecimal(txtMontoAFact.Text) * mdecTipoCambio
      End If

      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - ToDecimal(txtIVA.Text))

      If ToDecimal(txtFacturaMonto.Text) >= 50000 Then
         chkBancarizar.Checked = True
      Else
         chkBancarizar.Checked = False
      End If
   End Sub

   Private Sub txtExentoAFac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExentoAFac.ValueChanged
      If mlngMonedaId = 1 Then
         txtExento.Text = ToDecimal(txtExentoAFac.Text)
      Else
         txtExento.Text = ToDecimal(txtExentoAFac.Text) * mdecTipoCambio
      End If
   End Sub

   Private Sub txtExentoAFac_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExentoAFac.KeyUp
      If mlngMonedaId = 1 Then
         txtExento.Text = ToDecimal(txtExentoAFac.Text)
      Else
         txtExento.Text = ToDecimal(txtExentoAFac.Text) * mdecTipoCambio
      End If

      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - ToDecimal(txtIVA.Text))

   End Sub

   Private Sub txtExento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExento.ValueChanged
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - ToDecimal(txtIVA.Text))

   End Sub

   Private Sub chkFacturaNoValida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFacturaNoValida.CheckedChanged
      If chkFacturaNoValida.Checked Then
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 5)
         txtFacturaObs.Text = "Factura Diferida NO VÀLIDA"
         txtMontoAFact.Text = ToDecStr(mdecMontoCompra)
         txtExentoAFac.Text = ToDecStr(mdecExentoCompra)
         txtMontoAFact.ReadOnly = True
         txtExentoAFac.ReadOnly = True
      Else
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)
         txtFacturaObs.Text = ""
         txtMontoAFact.ReadOnly = False
         txtExentoAFac.ReadOnly = False
         If ToDecimal(txtExentoAFac.Text) = 0 Then
            txtExentoAFac.ReadOnly = True
         End If
      End If
   End Sub

   Private Sub frmFacturaDifDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then

            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then

               If DataSave() Then

                  mlngID = moFactura.FacturaId
                  txtCodControl.Text = moFactura.CodControl

                  mboolChanged = True

                  Call DataReadOnly()
                  Call Close()
               End If

            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmFacturaDifDetEdit_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
      moFactura.Dispose()
      Call ClearMemory()
   End Sub

End Class