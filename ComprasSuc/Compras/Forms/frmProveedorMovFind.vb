Public Class frmProveedorMovFind
   Inherits System.Windows.Forms.Form

   Private moListaCentroCosto As Queue
   Private moListaProveedor As Queue
   Private mlngEmpresaId As Long

   Private mstrFechaIni As String
   Private mstrFechaFin As String

   Private mboolCheckCentroCostoAll As Boolean
   Private mboolCheckClienteAll As Boolean

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

#Region " Código generado por el Diseñador de Windows Forms "

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

   'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Diseñador de Windows Forms. 
   'No lo modifique con el editor de código.
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboCentroCosto As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Friend WithEvents chkFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents optResumido As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optDetallado As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents chkOrdenarFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkDetalleCompra As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkSaldoCero As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkSaldoIni As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkAjuste As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkDesAnticipo As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkPago As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkCredito As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkDevAnticipo As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkCompra As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkDevCompra As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkAnticipo As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents optExtendido As Janus.Windows.EditControls.UIRadioButton
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboCentroCosto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorMovFind))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.lblSucursal = New System.Windows.Forms.Label
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkSaldoIni = New Janus.Windows.EditControls.UICheckBox
      Me.chkAjuste = New Janus.Windows.EditControls.UICheckBox
      Me.chkDesAnticipo = New Janus.Windows.EditControls.UICheckBox
      Me.chkPago = New Janus.Windows.EditControls.UICheckBox
      Me.chkCredito = New Janus.Windows.EditControls.UICheckBox
      Me.chkDevAnticipo = New Janus.Windows.EditControls.UICheckBox
      Me.chkCompra = New Janus.Windows.EditControls.UICheckBox
      Me.chkDevCompra = New Janus.Windows.EditControls.UICheckBox
      Me.chkAnticipo = New Janus.Windows.EditControls.UICheckBox
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkSaldoCero = New Janus.Windows.EditControls.UICheckBox
      Me.chkDetalleCompra = New Janus.Windows.EditControls.UICheckBox
      Me.chkOrdenarFecha = New Janus.Windows.EditControls.UICheckBox
      Me.chkFecha = New Janus.Windows.EditControls.UICheckBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.optExtendido = New Janus.Windows.EditControls.UIRadioButton
      Me.optResumido = New Janus.Windows.EditControls.UIRadioButton
      Me.optDetallado = New Janus.Windows.EditControls.UIRadioButton
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCosto = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.lblCentroCosto = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox4.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 271)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 271)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.cboSucursal)
      Me.bcgMain.Controls.Add(Me.lblSucursal)
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox4)
      Me.bcgMain.Controls.Add(Me.UiGroupBox3)
      Me.bcgMain.Controls.Add(Me.chkOrdenarFecha)
      Me.bcgMain.Controls.Add(Me.chkFecha)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(752, 438)
      Me.bcgMain.TabIndex = 163
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboSucursal
      '
      Me.cboSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(68, 410)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(120, 20)
      Me.cboSucursal.TabIndex = 214
      Me.cboSucursal.Visible = False
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblSucursal
      '
      Me.lblSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
      Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblSucursal.Location = New System.Drawing.Point(8, 414)
      Me.lblSucursal.Name = "lblSucursal"
      Me.lblSucursal.Size = New System.Drawing.Size(60, 16)
      Me.lblSucursal.TabIndex = 215
      Me.lblSucursal.Text = "Sucursal"
      Me.lblSucursal.Visible = False
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
      ExplorerBarGroup1.ContainerHeight = 272
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 4)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 304)
      Me.ebrMain.TabIndex = 23
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox4
      '
      Me.UiGroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox4.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox4.Controls.Add(Me.chkSaldoIni)
      Me.UiGroupBox4.Controls.Add(Me.chkAjuste)
      Me.UiGroupBox4.Controls.Add(Me.chkDesAnticipo)
      Me.UiGroupBox4.Controls.Add(Me.chkPago)
      Me.UiGroupBox4.Controls.Add(Me.chkCredito)
      Me.UiGroupBox4.Controls.Add(Me.chkDevAnticipo)
      Me.UiGroupBox4.Controls.Add(Me.chkCompra)
      Me.UiGroupBox4.Controls.Add(Me.chkDevCompra)
      Me.UiGroupBox4.Controls.Add(Me.chkAnticipo)
      Me.UiGroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox4.Location = New System.Drawing.Point(408, 318)
      Me.UiGroupBox4.Name = "UiGroupBox4"
      Me.UiGroupBox4.Size = New System.Drawing.Size(336, 84)
      Me.UiGroupBox4.TabIndex = 16
      Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkSaldoIni
      '
      Me.chkSaldoIni.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkSaldoIni.BackColor = System.Drawing.Color.Transparent
      Me.chkSaldoIni.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSaldoIni.Checked = True
      Me.chkSaldoIni.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkSaldoIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSaldoIni.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkSaldoIni.Location = New System.Drawing.Point(120, 64)
      Me.chkSaldoIni.Name = "chkSaldoIni"
      Me.chkSaldoIni.Size = New System.Drawing.Size(96, 16)
      Me.chkSaldoIni.TabIndex = 19
      Me.chkSaldoIni.Text = "Saldo Inicial"
      Me.chkSaldoIni.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkAjuste
      '
      Me.chkAjuste.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkAjuste.BackColor = System.Drawing.Color.Transparent
      Me.chkAjuste.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkAjuste.Checked = True
      Me.chkAjuste.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkAjuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkAjuste.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkAjuste.Location = New System.Drawing.Point(228, 64)
      Me.chkAjuste.Name = "chkAjuste"
      Me.chkAjuste.Size = New System.Drawing.Size(100, 16)
      Me.chkAjuste.TabIndex = 21
      Me.chkAjuste.Text = "Ajuste"
      Me.chkAjuste.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkDesAnticipo
      '
      Me.chkDesAnticipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkDesAnticipo.BackColor = System.Drawing.Color.Transparent
      Me.chkDesAnticipo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkDesAnticipo.Checked = True
      Me.chkDesAnticipo.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkDesAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkDesAnticipo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkDesAnticipo.Location = New System.Drawing.Point(8, 64)
      Me.chkDesAnticipo.Name = "chkDesAnticipo"
      Me.chkDesAnticipo.Size = New System.Drawing.Size(100, 16)
      Me.chkDesAnticipo.TabIndex = 16
      Me.chkDesAnticipo.Text = "Desc. Anticipo"
      Me.chkDesAnticipo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkPago
      '
      Me.chkPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkPago.BackColor = System.Drawing.Color.Transparent
      Me.chkPago.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkPago.Checked = True
      Me.chkPago.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkPago.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkPago.Location = New System.Drawing.Point(120, 40)
      Me.chkPago.Name = "chkPago"
      Me.chkPago.Size = New System.Drawing.Size(96, 16)
      Me.chkPago.TabIndex = 18
      Me.chkPago.Text = "Pago"
      Me.chkPago.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkCredito
      '
      Me.chkCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkCredito.BackColor = System.Drawing.Color.Transparent
      Me.chkCredito.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkCredito.Checked = True
      Me.chkCredito.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkCredito.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkCredito.Location = New System.Drawing.Point(120, 16)
      Me.chkCredito.Name = "chkCredito"
      Me.chkCredito.Size = New System.Drawing.Size(96, 16)
      Me.chkCredito.TabIndex = 17
      Me.chkCredito.Text = "Crédito"
      Me.chkCredito.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkDevAnticipo
      '
      Me.chkDevAnticipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkDevAnticipo.BackColor = System.Drawing.Color.Transparent
      Me.chkDevAnticipo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkDevAnticipo.Checked = True
      Me.chkDevAnticipo.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkDevAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkDevAnticipo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkDevAnticipo.Location = New System.Drawing.Point(8, 40)
      Me.chkDevAnticipo.Name = "chkDevAnticipo"
      Me.chkDevAnticipo.Size = New System.Drawing.Size(100, 16)
      Me.chkDevAnticipo.TabIndex = 15
      Me.chkDevAnticipo.Text = "Devol  Anticipo"
      Me.chkDevAnticipo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkCompra
      '
      Me.chkCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkCompra.BackColor = System.Drawing.Color.Transparent
      Me.chkCompra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkCompra.Checked = True
      Me.chkCompra.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkCompra.Location = New System.Drawing.Point(228, 16)
      Me.chkCompra.Name = "chkCompra"
      Me.chkCompra.Size = New System.Drawing.Size(100, 16)
      Me.chkCompra.TabIndex = 20
      Me.chkCompra.Text = "Compra Conta"
      Me.chkCompra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkDevCompra
      '
      Me.chkDevCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkDevCompra.BackColor = System.Drawing.Color.Transparent
      Me.chkDevCompra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkDevCompra.Checked = True
      Me.chkDevCompra.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkDevCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkDevCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkDevCompra.Location = New System.Drawing.Point(228, 40)
      Me.chkDevCompra.Name = "chkDevCompra"
      Me.chkDevCompra.Size = New System.Drawing.Size(100, 16)
      Me.chkDevCompra.TabIndex = 21
      Me.chkDevCompra.Text = "Devol. Compra"
      Me.chkDevCompra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkAnticipo
      '
      Me.chkAnticipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkAnticipo.BackColor = System.Drawing.Color.Transparent
      Me.chkAnticipo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkAnticipo.Checked = True
      Me.chkAnticipo.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkAnticipo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkAnticipo.Location = New System.Drawing.Point(8, 16)
      Me.chkAnticipo.Name = "chkAnticipo"
      Me.chkAnticipo.Size = New System.Drawing.Size(100, 16)
      Me.chkAnticipo.TabIndex = 14
      Me.chkAnticipo.Text = "Anticipo"
      Me.chkAnticipo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.chkSaldoCero)
      Me.UiGroupBox3.Controls.Add(Me.chkDetalleCompra)
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(408, 402)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(336, 28)
      Me.UiGroupBox3.TabIndex = 22
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkSaldoCero
      '
      Me.chkSaldoCero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkSaldoCero.BackColor = System.Drawing.Color.Transparent
      Me.chkSaldoCero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSaldoCero.Checked = True
      Me.chkSaldoCero.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkSaldoCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSaldoCero.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkSaldoCero.Location = New System.Drawing.Point(8, 8)
      Me.chkSaldoCero.Name = "chkSaldoCero"
      Me.chkSaldoCero.Size = New System.Drawing.Size(188, 16)
      Me.chkSaldoCero.TabIndex = 23
      Me.chkSaldoCero.Text = "Proveedores Con Saldo Cero"
      Me.chkSaldoCero.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkDetalleCompra
      '
      Me.chkDetalleCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkDetalleCompra.BackColor = System.Drawing.Color.Transparent
      Me.chkDetalleCompra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkDetalleCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkDetalleCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkDetalleCompra.Location = New System.Drawing.Point(212, 8)
      Me.chkDetalleCompra.Name = "chkDetalleCompra"
      Me.chkDetalleCompra.Size = New System.Drawing.Size(116, 16)
      Me.chkDetalleCompra.TabIndex = 24
      Me.chkDetalleCompra.Text = "Detallar Compras"
      Me.chkDetalleCompra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkOrdenarFecha
      '
      Me.chkOrdenarFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkOrdenarFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkOrdenarFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkOrdenarFecha.Checked = True
      Me.chkOrdenarFecha.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkOrdenarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkOrdenarFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkOrdenarFecha.Location = New System.Drawing.Point(136, 314)
      Me.chkOrdenarFecha.Name = "chkOrdenarFecha"
      Me.chkOrdenarFecha.Size = New System.Drawing.Size(44, 20)
      Me.chkOrdenarFecha.TabIndex = 3
      Me.chkOrdenarFecha.Text = "Ord."
      Me.chkOrdenarFecha.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkFecha
      '
      Me.chkFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFecha.Location = New System.Drawing.Point(16, 314)
      Me.chkFecha.Name = "chkFecha"
      Me.chkFecha.Size = New System.Drawing.Size(112, 20)
      Me.chkFecha.TabIndex = 2
      Me.chkFecha.Text = "Habilitar Fechas"
      Me.chkFecha.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.dtpFechaFin)
      Me.grpMain.Controls.Add(Me.dtpFechaIni)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 318)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(180, 84)
      Me.grpMain.TabIndex = 4
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dtpFechaFin
      '
      Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaFin.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaFin.DropDownCalendar.Name = ""
      Me.dtpFechaFin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaFin.Enabled = False
      Me.dtpFechaFin.Location = New System.Drawing.Point(56, 52)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(116, 20)
      Me.dtpFechaFin.TabIndex = 6
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'dtpFechaIni
      '
      Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaIni.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaIni.DropDownCalendar.Name = ""
      Me.dtpFechaIni.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaIni.Enabled = False
      Me.dtpFechaIni.Location = New System.Drawing.Point(56, 28)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(116, 20)
      Me.dtpFechaIni.TabIndex = 5
      Me.dtpFechaIni.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(8, 32)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(44, 16)
      Me.Label3.TabIndex = 154
      Me.Label3.Text = "Desde"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 56)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(44, 16)
      Me.Label4.TabIndex = 153
      Me.Label4.Text = "Hasta"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.optExtendido)
      Me.UiGroupBox2.Controls.Add(Me.optResumido)
      Me.UiGroupBox2.Controls.Add(Me.optDetallado)
      Me.UiGroupBox2.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox2.Controls.Add(Me.Label1)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(196, 318)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(204, 84)
      Me.UiGroupBox2.TabIndex = 7
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'optExtendido
      '
      Me.optExtendido.BackColor = System.Drawing.Color.Transparent
      Me.optExtendido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optExtendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optExtendido.Location = New System.Drawing.Point(8, 64)
      Me.optExtendido.Name = "optExtendido"
      Me.optExtendido.Size = New System.Drawing.Size(76, 16)
      Me.optExtendido.TabIndex = 10
      Me.optExtendido.Text = "Extendido"
      Me.optExtendido.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optResumido
      '
      Me.optResumido.BackColor = System.Drawing.Color.Transparent
      Me.optResumido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optResumido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optResumido.Location = New System.Drawing.Point(120, 40)
      Me.optResumido.Name = "optResumido"
      Me.optResumido.Size = New System.Drawing.Size(76, 16)
      Me.optResumido.TabIndex = 11
      Me.optResumido.Text = "Resumido"
      Me.optResumido.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optDetallado
      '
      Me.optDetallado.BackColor = System.Drawing.Color.Transparent
      Me.optDetallado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optDetallado.Checked = True
      Me.optDetallado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optDetallado.Location = New System.Drawing.Point(8, 40)
      Me.optDetallado.Name = "optDetallado"
      Me.optDetallado.Size = New System.Drawing.Size(76, 16)
      Me.optDetallado.TabIndex = 9
      Me.optDetallado.TabStop = True
      Me.optDetallado.Text = "Detallado"
      Me.optDetallado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(68, 12)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(128, 20)
      Me.cboMoneda.TabIndex = 8
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(56, 16)
      Me.Label1.TabIndex = 163
      Me.Label1.Text = "Moneda"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.cboCentroCosto)
      Me.UiGroupBox1.Controls.Add(Me.lblCentroCosto)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(196, 400)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(204, 32)
      Me.UiGroupBox1.TabIndex = 172
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.ControlStyle.ControlTextColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ControlStyle.WindowTextColor = System.Drawing.SystemColors.HotTrack
      cboCentroCosto_DesignTimeLayout.LayoutString = resources.GetString("cboCentroCosto_DesignTimeLayout.LayoutString")
      Me.cboCentroCosto.DesignTimeLayout = cboCentroCosto_DesignTimeLayout
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(52, 9)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SaveSettings = False
      Me.cboCentroCosto.Size = New System.Drawing.Size(144, 20)
      Me.cboCentroCosto.TabIndex = 198
      Me.cboCentroCosto.ValuesDataMember = Nothing
      Me.cboCentroCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblCentroCosto.Location = New System.Drawing.Point(5, 11)
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Size = New System.Drawing.Size(44, 16)
      Me.lblCentroCosto.TabIndex = 171
      Me.lblCentroCosto.Text = "C. C."
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
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll2, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("3585ee71-ff14-4ac4-8752-5d6b7253e051")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator3, Me.ViewAll1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(260, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Movimiento"
      Me.Book1.ToolTipText = "Movimiento de Proveedores"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'ViewAll1
      '
      Me.ViewAll1.Key = "ViewAll"
      Me.ViewAll1.Name = "ViewAll1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Book
      '
      Me.Book.ImageIndex = 0
      Me.Book.Key = "Book"
      Me.Book.Name = "Book"
      Me.Book.Text = "Libro"
      '
      'ViewAll2
      '
      Me.ViewAll2.ImageIndex = 3
      Me.ViewAll2.Key = "ViewAll"
      Me.ViewAll2.Name = "ViewAll2"
      Me.ViewAll2.Text = "Ver Todos"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
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
      'frmProveedorMovFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 466)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmProveedorMovFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Criterios Movimiento de Proveedores"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox4.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
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
         Case "Book"
            Call frmKardexLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmProveedorMovFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmProveedorMovFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call ComboLoad()
      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ViewComponent()
      Call grdMainLoad()

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
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

   Private Sub cboCentroCostoLoad()
      Dim oTipoAsiento As New clsCentroCosto(clsAppInfo.ConnectString)

      Try
         With oTipoAsiento
            .SelectFilter = clsCentroCosto.SelectFilters.ListBox
            .WhereFilter = clsCentroCosto.WhereFilters.EmpresaId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoId

            .EmpresaId = clsAppInfo.EmpresaId
            If .Open() Then
               Dim oRow As DataRow

               oRow = .DataSet.Tables(.TableName).NewRow
               oRow("CentroCostoId") = -1
               oRow("CentroCostoDes") = "(Todos)"

               .DataSet.Tables(.TableName).Rows.InsertAt(oRow, 0)

               With cboCentroCosto
                  .DropDownDataSource = oTipoAsiento.DataSet.Tables(oTipoAsiento.TableName)
                  .RetrieveStructure()

                  .ValueItemDataMember = "CentroCostoId"
                  .DropDownValueMember = "CentroCostoId"
                  .DropDownDisplayMember = "CentroCostoDes"
                  .DropDownList.Columns(0).UseHeaderSelector = True

                  .DropDownList.Columns("CentroCostoId").Visible = False

                  .DropDownList.Columns("CentroCostoDes").Caption = "Descripción"
                  .DropDownList.Columns("CentroCostoDes").Width = 300

                  Call cboCentroCostoEventos()
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oTipoAsiento.Dispose()
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
            .TipoCompraId = clsTipoCompra.COMPRA
            If .Open() Then
               oItem = New clsListItem(0, "(Todos)")
               cboSucursal.Items.Add(oItem)

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

#Region " cboCentroCosto-Metodos "
   Private Sub cboCentroCostoEventos()
      Dim b As New Janus.Windows.GridEX.RowCheckStateChangeEventHandler(AddressOf cboCentroCosto_RowCheckStateChanged)
      AddHandler cboCentroCosto.DropDownList.RowCheckStateChanged, b

      Dim c As New Janus.Windows.GridEX.RowCheckStateChangingEventHandler(AddressOf cboCentroCosto_RowCheckStateChanging)
      AddHandler cboCentroCosto.DropDownList.RowCheckStateChanging, c
   End Sub

   Private Sub cboCentroCosto_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs)
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         cboCentroCostoCheckAll(True)
      End If
   End Sub

   Private Sub cboCentroCosto_RowCheckStateChanging(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangingEventArgs)
      If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
         If cboCentroCosto.DropDownList.GetRow.Cells("CentroCostoId").Value = -1 And (cboCentroCosto.DropDownList.GetCheckedRows.Count > 0) Then
            If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
               cboCentroCostoCheckAll(True)
            End If

            e.Cancel = True

         ElseIf cboCentroCosto.DropDownList.GetRow.Cells("CentroCostoId").Value <> -1 Then
            cboCentroCosto_CheckTodos(False)
         End If
      End If
   End Sub

   Private Sub cboCentroCostoCheckAll(ByVal boolValue As Boolean)
      If mboolCheckCentroCostoAll Then
         mboolCheckCentroCostoAll = False
      Else
         mboolCheckCentroCostoAll = True
      End If

      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboCentroCosto.DropDownList.GetRows
         oRow.BeginEdit()

         If oRow.Cells("CentroCostoId").Value = -1 Then
            oRow.IsChecked = False
         Else
            oRow.IsChecked = mboolCheckCentroCostoAll
         End If

         oRow.EndEdit()
      Next
   End Sub

   Private Sub cboCentroCosto_CheckTodos(ByVal boolValue As Boolean)
      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboCentroCosto.DropDownList.GetRows
         oRow.BeginEdit()

         If oRow.Cells("CentroCostoId").Value = -1 Then
            oRow.IsChecked = boolValue
         End If

         oRow.EndEdit()

         Exit For
      Next
   End Sub
#End Region

   Private Sub FormInit()
      Call FormCenterChild(Me)

      If GestionFecha(clsAppInfo.GestionId, mstrFechaIni, mstrFechaFin) Then
         dtpFechaIni.Value = mstrFechaIni
         dtpFechaFin.Value = mstrFechaFin
      End If

      cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
      cboSucursal.SelectedIndex = ListFindItem(cboSucursal, 0)
      Dim lista As New List(Of Object)
      For Each orow In cboCentroCosto.DropDownList.GetRows()
         If orow.Cells("CentroCostoId").Value = -1 Then
            orow.IsChecked = True
            lista.Add(orow.Cells("CentroCostoId").Value)
         End If
      Next
      cboCentroCosto.Values = lista
   End Sub

   Private Sub ViewComponent()
      If Not clsAppInfo.CentroCostoApli Then
         lblCentroCosto.Visible = False
         cboCentroCosto.Visible = False
         UiGroupBox1.Visible = False
      End If

      If clsAppInfo.SucursalApli Then
         lblSucursal.Visible = True
         cboSucursal.Visible = True
      Else
         lblSucursal.Visible = False
         cboSucursal.Visible = False
      End If
   End Sub

   Private Sub frmProveedorMovFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmKardexLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmProveedorMovFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
     Call ClearMemory()
   End Sub

   Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
      If ToBoolean(chkFecha.Checked) = 0 Then
         dtpFechaIni.Value = mstrFechaIni
         dtpFechaFin.Value = mstrFechaFin
      End If

      dtpFechaIni.Enabled = chkFecha.Checked
      dtpFechaFin.Enabled = chkFecha.Checked
   End Sub

#Region " Grid Proveedor "
   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Proveedores"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("ProveedorId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("ProveedorCod").Caption = "Código"
         .RootTable.Columns("ProveedorCod").Width = 100
         .RootTable.Columns("ProveedorCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
         .RootTable.Columns("ProveedorDes").Width = 200
         .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ProveedorNIT").Caption = "NIT"
         .RootTable.Columns("ProveedorNIT").Width = 100
         .RootTable.Columns("ProveedorNIT").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorNIT").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ContactoDes").Caption = "Contacto"
         .RootTable.Columns("ContactoDes").Width = 200
         .RootTable.Columns("ContactoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ContactoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ContactoCI").Caption = "C.I."
         .RootTable.Columns("ContactoCI").Width = 100
         .RootTable.Columns("ContactoCI").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ContactoCI").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ContactoCargo").Caption = "Cargo"
         .RootTable.Columns("ContactoCargo").Width = 100
         .RootTable.Columns("ContactoCargo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ContactoCargo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Direccion").Caption = "Dirección"
         .RootTable.Columns("Direccion").Width = 100
         .RootTable.Columns("Direccion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Direccion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CiudadId").Visible = False

         .RootTable.Columns("CiudadDes").Caption = "Ciudad"
         .RootTable.Columns("CiudadDes").Width = 100
         .RootTable.Columns("CiudadDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CiudadDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Telefono1").Caption = "Teléfono 1"
         .RootTable.Columns("Telefono1").Width = 100
         .RootTable.Columns("Telefono1").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Telefono1").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Telefono2").Caption = "Teléfono 2"
         .RootTable.Columns("Telefono2").Width = 100
         .RootTable.Columns("Telefono2").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Telefono2").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Movil").Caption = "Móvil"
         .RootTable.Columns("Movil").Width = 100
         .RootTable.Columns("Movil").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Movil").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Fax").Caption = "Fax"
         .RootTable.Columns("Fax").Width = 100
         .RootTable.Columns("Fax").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Fax").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Email").Caption = "Correo Electrónico"
         .RootTable.Columns("Email").Width = 100
         .RootTable.Columns("Email").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Email").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Web").Caption = "Página Web"
         .RootTable.Columns("Web").Width = 100
         .RootTable.Columns("Web").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Web").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ProcedenciaId").Visible = False

         .RootTable.Columns("ProcedenciaDes").Caption = "Procedencia"
         .RootTable.Columns("ProcedenciaDes").Width = 150
         .RootTable.Columns("ProcedenciaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProcedenciaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("RubroId").Visible = False

         .RootTable.Columns("RubroDes").Caption = "Rubro"
         .RootTable.Columns("RubroDes").Width = 150
         .RootTable.Columns("RubroDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("RubroDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("BancoId").Visible = False

         .RootTable.Columns("BancoDes").Caption = "Banco"
         .RootTable.Columns("BancoDes").Width = 150
         .RootTable.Columns("BancoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("BancoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroCuenta").Caption = "Nro. Cuenta"
         .RootTable.Columns("NroCuenta").Width = 100
         .RootTable.Columns("NroCuenta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("NroCuenta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdMainLoad()
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Try
         With oProveedor
            .SelectFilter = clsProveedor.SelectFilters.GridCheck
            .WhereFilter = clsProveedor.WhereFilters.GridCheck
            .OrderByFilter = clsProveedor.OrderByFilters.GridCheck

            .EmpresaId = mlngEmpresaId
            If .Open() Then
               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oProveedor.Dispose()
      End Try
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub
#End Region

   Private Sub frmKardexLoad()
      Try
         If FormCheck() Then
            Dim frm As New frmProveedorMov

            With frm
               .EmpresaId = mlngEmpresaId
               .GestionId = clsAppInfo.GestionId
               .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
               .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
               .IntervaloFecha = ToBoolean(chkFecha.Checked)
               .FechaIni = ToDate(dtpFechaIni.Value)
               .FechaFin = ToDate(dtpFechaFin.Value)
               .OrdenarFecha = ToBoolean(chkOrdenarFecha.Checked)
               .SaldoCero = ToBoolean(chkSaldoCero.Checked)
               .DetalleCompra = ToBoolean(chkDetalleCompra.Checked)

               .Compra = ToBoolean(chkCompra.Checked)
               .DevCompra = ToBoolean(chkDevCompra.Checked)
               .Anticipo = ToBoolean(chkAnticipo.Checked)
               .DevAnticipo = ToBoolean(chkDevAnticipo.Checked)
               .Credito = ToBoolean(chkCredito.Checked)
               .Pago = ToBoolean(chkPago.Checked)
               .SaldoIni = ToBoolean(chkSaldoIni.Checked)
               .DesAnticipo = ToBoolean(chkDesAnticipo.Checked)
               .Ajuste = ToBoolean(chkAjuste.Checked)

               .Resumido = ToBoolean(optResumido.Checked)
               .Extendido = ToBoolean(optExtendido.Checked)

               .ListaProveedor = moListaProveedor
               .ListaCentroCosto = moListaCentroCosto

               .MdiParent = Me.MdiParent
               .Show()
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      moListaProveedor = New Queue
      moListaCentroCosto = New Queue

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("Sel").Value Then
            moListaProveedor.Enqueue(oRow.Cells("ProveedorId").Value)
         End If
      Next
      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboCentroCosto.DropDownList.GetCheckedRows
         moListaCentroCosto.Enqueue(oRow.Cells("CentroCostoId").Value)
      Next

      If moListaProveedor.Count = 0 Then
         strMsg &= "Seleccione al Menos un Proveedor" & vbCrLf
      End If

      If ToBoolean(chkFecha.Checked) = 1 Then
         If dtpFechaIni.Value > dtpFechaFin.Value Then
            strMsg &= "La Fecha de Inicio no Puede Ser Mayor a la Fecha Final" & vbCrLf
         End If
      End If

      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) = 0 Then
         strMsg &= "Seleccione una Moneda" & vbCrLf
      End If

      If clsAppInfo.CentroCostoApli Then
         If moListaCentroCosto.Count = 0 Then
            strMsg &= "Seleccione al Menos un Centro de Costo" & vbCrLf
         End If
      End If

      If clsAppInfo.SucursalApli Then
         If cboSucursal.SelectedIndex = -1 Then
            strMsg &= "Seleccione una Sucursal" & vbCrLf
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub optResumido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optResumido.CheckedChanged
      If optResumido.Checked Then
         chkDetalleCompra.Checked = False
         chkDetalleCompra.Enabled = False
      Else
         chkDetalleCompra.Enabled = True
      End If
   End Sub

#Region " Otros Metodos "
   Private Function GestionFecha(ByVal GestionId As Long, ByRef strFechaIni As String, ByRef strFechaFin As String) As Boolean
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionFecha = False
      Try
         With oGestion
            .GestionId = GestionId

            If .FindByPK Then
               strFechaIni = .FechaIni
               strFechaFin = .FechaFin
               GestionFecha = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oGestion.Dispose()
      End Try
   End Function
#End Region
End Class
