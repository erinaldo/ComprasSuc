Public Class frmCompraMovFind
   Inherits System.Windows.Forms.Form

   Private moListaItem As Queue
   Private moListaCentroCosto As Queue
   Private mlngEmpresaId As Long

   Private mstrFechaIni As String
   Private mstrFechaFin As String

   Private mboolCheckCentroCostoAll As Boolean

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
   Friend WithEvents cboCentroCosto As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
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
   Friend WithEvents cboAlmacen As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents optResumido As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optDetallado As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents cboTipoPago As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents optDiario As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents cboProveedor As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents chkOrdenarFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboMedida As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboCentroCosto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraMovFind))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.lblSucursal = New System.Windows.Forms.Label
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.chkOrdenarFecha = New Janus.Windows.EditControls.UICheckBox
      Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboMedida = New Janus.Windows.EditControls.UIComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.cboTipoPago = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.optDiario = New Janus.Windows.EditControls.UIRadioButton
      Me.optResumido = New Janus.Windows.EditControls.UIRadioButton
      Me.optDetallado = New Janus.Windows.EditControls.UIRadioButton
      Me.chkFecha = New Janus.Windows.EditControls.UICheckBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCosto = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.lblCentroCosto = New System.Windows.Forms.Label
      Me.cboProveedor = New Janus.Windows.EditControls.UIComboBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.cboAlmacen = New Janus.Windows.EditControls.UIComboBox
      Me.Label5 = New System.Windows.Forms.Label
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 273)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 273)
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
      Me.bcgMain.Controls.Add(Me.chkOrdenarFecha)
      Me.bcgMain.Controls.Add(Me.UiGroupBox4)
      Me.bcgMain.Controls.Add(Me.UiGroupBox3)
      Me.bcgMain.Controls.Add(Me.chkFecha)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(752, 414)
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
      Me.cboSucursal.Location = New System.Drawing.Point(64, 392)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(148, 20)
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
      Me.lblSucursal.Location = New System.Drawing.Point(4, 396)
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
      ExplorerBarGroup1.ContainerHeight = 274
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 306)
      Me.ebrMain.TabIndex = 15
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
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
      Me.chkOrdenarFecha.Location = New System.Drawing.Point(144, 318)
      Me.chkOrdenarFecha.Name = "chkOrdenarFecha"
      Me.chkOrdenarFecha.Size = New System.Drawing.Size(44, 20)
      Me.chkOrdenarFecha.TabIndex = 3
      Me.chkOrdenarFecha.Text = "Ord."
      Me.chkOrdenarFecha.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'UiGroupBox4
      '
      Me.UiGroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox4.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox4.Controls.Add(Me.cboMedida)
      Me.UiGroupBox4.Controls.Add(Me.Label2)
      Me.UiGroupBox4.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox4.Controls.Add(Me.Label6)
      Me.UiGroupBox4.Controls.Add(Me.cboTipoPago)
      Me.UiGroupBox4.Controls.Add(Me.Label1)
      Me.UiGroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox4.Location = New System.Drawing.Point(484, 322)
      Me.UiGroupBox4.Name = "UiGroupBox4"
      Me.UiGroupBox4.Size = New System.Drawing.Size(168, 84)
      Me.UiGroupBox4.TabIndex = 10
      Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboMedida
      '
      Me.cboMedida.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMedida.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.Location = New System.Drawing.Point(60, 12)
      Me.cboMedida.Name = "cboMedida"
      Me.cboMedida.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMedida.Size = New System.Drawing.Size(100, 20)
      Me.cboMedida.TabIndex = 11
      Me.cboMedida.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 16)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(48, 16)
      Me.Label2.TabIndex = 169
      Me.Label2.Text = "Medida"
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(60, 60)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
      Me.cboMoneda.TabIndex = 13
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 64)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(48, 16)
      Me.Label6.TabIndex = 167
      Me.Label6.Text = "Moneda"
      '
      'cboTipoPago
      '
      Me.cboTipoPago.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoPago.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPago.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPago.Location = New System.Drawing.Point(60, 36)
      Me.cboTipoPago.Name = "cboTipoPago"
      Me.cboTipoPago.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoPago.Size = New System.Drawing.Size(100, 20)
      Me.cboTipoPago.TabIndex = 12
      Me.cboTipoPago.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 40)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(48, 16)
      Me.Label1.TabIndex = 165
      Me.Label1.Text = "Pago"
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.optDiario)
      Me.UiGroupBox3.Controls.Add(Me.optResumido)
      Me.UiGroupBox3.Controls.Add(Me.optDetallado)
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(660, 322)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(84, 84)
      Me.UiGroupBox3.TabIndex = 14
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'optDiario
      '
      Me.optDiario.BackColor = System.Drawing.Color.Transparent
      Me.optDiario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optDiario.Location = New System.Drawing.Point(4, 40)
      Me.optDiario.Name = "optDiario"
      Me.optDiario.Size = New System.Drawing.Size(76, 16)
      Me.optDiario.TabIndex = 16
      Me.optDiario.Text = "Diario"
      Me.optDiario.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optResumido
      '
      Me.optResumido.BackColor = System.Drawing.Color.Transparent
      Me.optResumido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optResumido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optResumido.Location = New System.Drawing.Point(4, 64)
      Me.optResumido.Name = "optResumido"
      Me.optResumido.Size = New System.Drawing.Size(76, 16)
      Me.optResumido.TabIndex = 17
      Me.optResumido.Text = "Resumido"
      Me.optResumido.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optDetallado
      '
      Me.optDetallado.BackColor = System.Drawing.Color.Transparent
      Me.optDetallado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optDetallado.Checked = True
      Me.optDetallado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optDetallado.Location = New System.Drawing.Point(4, 16)
      Me.optDetallado.Name = "optDetallado"
      Me.optDetallado.Size = New System.Drawing.Size(76, 16)
      Me.optDetallado.TabIndex = 15
      Me.optDetallado.TabStop = True
      Me.optDetallado.Text = "Detallado"
      Me.optDetallado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkFecha
      '
      Me.chkFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFecha.Location = New System.Drawing.Point(20, 318)
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
      Me.grpMain.Location = New System.Drawing.Point(8, 322)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(188, 66)
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
      Me.dtpFechaFin.Location = New System.Drawing.Point(56, 40)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(124, 20)
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
      Me.dtpFechaIni.Location = New System.Drawing.Point(56, 16)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaIni.TabIndex = 5
      Me.dtpFechaIni.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(8, 20)
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
      Me.Label4.Location = New System.Drawing.Point(8, 44)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(44, 16)
      Me.Label4.TabIndex = 153
      Me.Label4.Text = "Hasta"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.cboCentroCosto)
      Me.UiGroupBox2.Controls.Add(Me.lblCentroCosto)
      Me.UiGroupBox2.Controls.Add(Me.cboProveedor)
      Me.UiGroupBox2.Controls.Add(Me.Label8)
      Me.UiGroupBox2.Controls.Add(Me.cboAlmacen)
      Me.UiGroupBox2.Controls.Add(Me.Label5)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(204, 322)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(272, 84)
      Me.UiGroupBox2.TabIndex = 7
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.ControlStyle.ControlTextColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ControlStyle.WindowTextColor = System.Drawing.SystemColors.HotTrack
      cboCentroCosto_DesignTimeLayout.LayoutString = resources.GetString("cboCentroCosto_DesignTimeLayout.LayoutString")
      Me.cboCentroCosto.DesignTimeLayout = cboCentroCosto_DesignTimeLayout
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(72, 60)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SaveSettings = False
      Me.cboCentroCosto.Size = New System.Drawing.Size(192, 20)
      Me.cboCentroCosto.TabIndex = 199
      Me.cboCentroCosto.ValuesDataMember = Nothing
      Me.cboCentroCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCentroCosto.Location = New System.Drawing.Point(8, 64)
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Size = New System.Drawing.Size(60, 16)
      Me.lblCentroCosto.TabIndex = 167
      Me.lblCentroCosto.Text = "C. C."
      '
      'cboProveedor
      '
      Me.cboProveedor.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboProveedor.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProveedor.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProveedor.Location = New System.Drawing.Point(72, 36)
      Me.cboProveedor.Name = "cboProveedor"
      Me.cboProveedor.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboProveedor.Size = New System.Drawing.Size(192, 20)
      Me.cboProveedor.TabIndex = 9
      Me.cboProveedor.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 40)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(60, 16)
      Me.Label8.TabIndex = 165
      Me.Label8.Text = "Proveedor"
      '
      'cboAlmacen
      '
      Me.cboAlmacen.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboAlmacen.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAlmacen.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAlmacen.Location = New System.Drawing.Point(72, 12)
      Me.cboAlmacen.Name = "cboAlmacen"
      Me.cboAlmacen.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboAlmacen.Size = New System.Drawing.Size(192, 20)
      Me.cboAlmacen.TabIndex = 8
      Me.cboAlmacen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 16)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(60, 16)
      Me.Label5.TabIndex = 161
      Me.Label5.Text = "Almacén"
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
      Me.Book1.ToolTipText = "Movimiento de Compras"
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
      'frmCompraMovFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmCompraMovFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Criterios Movimiento de Compras por Ítems"
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
      Me.UiGroupBox2.PerformLayout()
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
            Call frmCompraMovLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompraMovFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompraMovFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      Call cboAlmacenLoad()
      Call cboProveedorLoad()
      Call cboMedidaLoad()
      Call cboTipoPagoLoad()
      Call cboMonedaLoad()
      Call cboCentroCostoLoad()
      Call cboSucursalLoad()
   End Sub

#Region " ComboLoads "
   Private Sub cboAlmacenLoad(Optional ByVal lngSucursalId As Long = 0)
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboAlmacen.Items.Clear()
      Try
         With oAlmacen
            .SelectFilter = clsAlmacen.SelectFilters.ListBox
            If lngSucursalId = 0 Then
               .WhereFilter = clsAlmacen.WhereFilters.EmpresaId
            Else
               .WhereFilter = clsAlmacen.WhereFilters.SucursalId
               .SucursalId = lngSucursalId
            End If

            .OrderByFilter = clsAlmacen.OrderByFilters.AlmacenDes
            .EmpresaId = mlngEmpresaId
            If .Open() Then
               oItem = New clsListItem(0, "(Todos)")
               cboAlmacen.Items.Add(oItem)

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

   Private Sub cboProveedorLoad()
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboProveedor.Items.Clear()
      Try
         With oProveedor
            .SelectFilter = clsProveedor.SelectFilters.ListBox
            .WhereFilter = clsProveedor.WhereFilters.EmpresaId
            .OrderByFilter = clsProveedor.OrderByFilters.ProveedorDes

            .EmpresaId = mlngEmpresaId
            .ProveedorId = 0
            .EstadoId = 1
            If .Open() Then
               oItem = New clsListItem(0, "(Todos)")
               cboProveedor.Items.Add(oItem)

               Do While .Read()
                  oItem = New clsListItem(.ProveedorId, .ProveedorDes)

                  cboProveedor.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oProveedor.Dispose()
         oItem = Nothing
      End Try
   End Sub

   Private Sub cboMedidaLoad()
      Dim oItem As clsListItem

      oItem = New clsListItem(1, "Mínima")
      cboMedida.Items.Add(oItem)

      oItem = New clsListItem(2, "Equivalente")
      cboMedida.Items.Add(oItem)
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
               oItem = New clsListItem(0, "(Todos)")
               cboTipoPago.Items.Add(oItem)

               Do While .Read()
                  If .TipoPagoId = clsTipoPago.CREDITO Or .TipoPagoId = clsTipoPago.CONTADO Then
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

      dtpFechaIni.MaxDate = mstrFechaFin
      dtpFechaIni.MinDate = mstrFechaIni
      dtpFechaFin.MaxDate = mstrFechaFin
      dtpFechaFin.MinDate = mstrFechaIni

      cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, 0)
      cboProveedor.SelectedIndex = ListFindItem(cboProveedor, 0)
      cboMedida.SelectedIndex = ListFindItem(cboMedida, 1)
      cboTipoPago.SelectedIndex = ListFindItem(cboTipoPago, 0)
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
      End If

      If clsAppInfo.SucursalApli Then
         lblSucursal.Visible = True
         cboSucursal.Visible = True
      Else
         lblSucursal.Visible = False
         cboSucursal.Visible = False
      End If
   End Sub

   Private Sub frmCompraMovFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmCompraMovLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompraMovFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
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

#Region " Grid Item "
   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Ítems"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("LineaId").Visible = False

         .RootTable.Columns("LineaDes").Caption = "Línea"
         .RootTable.Columns("LineaDes").Width = 100
         .RootTable.Columns("LineaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("LineaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GrupoId").Visible = False

         .RootTable.Columns("GrupoDes").Caption = "Grupo"
         .RootTable.Columns("GrupoDes").Width = 100
         .RootTable.Columns("GrupoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("GrupoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SubGrupoId").Visible = False

         .RootTable.Columns("SubGrupoDes").Caption = "SubGrupo"
         .RootTable.Columns("SubGrupoDes").Width = 100
         .RootTable.Columns("SubGrupoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("SubGrupoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 100
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Descripción Ítem"
         .RootTable.Columns("ItemDes").Width = 200
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDesAbr").Caption = "Desc. Abreviada"
         .RootTable.Columns("ItemDesAbr").Width = 100
         .RootTable.Columns("ItemDesAbr").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDesAbr").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Ubicacion").Caption = "Ubicación"
         .RootTable.Columns("Ubicacion").Width = 100
         .RootTable.Columns("Ubicacion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Ubicacion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MarcaId").Visible = False

         .RootTable.Columns("MarcaDes").Caption = "Marca"
         .RootTable.Columns("MarcaDes").Width = 100
         .RootTable.Columns("MarcaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MarcaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FabricaId").Visible = False

         .RootTable.Columns("FabricaDes").Caption = "Fabricación"
         .RootTable.Columns("FabricaDes").Width = 100
         .RootTable.Columns("FabricaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FabricaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 100
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaIdEqui").Visible = False

         .RootTable.Columns("MedidaDesEqui").Caption = "Medida Equi."
         .RootTable.Columns("MedidaDesEqui").Width = 100
         .RootTable.Columns("MedidaDesEqui").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDesEqui").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoItemId").Visible = False

         .RootTable.Columns("TipoItemDes").Caption = "Tipo Ítem"
         .RootTable.Columns("TipoItemDes").Width = 100
         .RootTable.Columns("TipoItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCosteoId").Visible = False

         .RootTable.Columns("TipoCosteoDes").Caption = "Tipo Costeo"
         .RootTable.Columns("TipoCosteoDes").Width = 100
         .RootTable.Columns("TipoCosteoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCosteoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanGrupoId").Visible = False

         .RootTable.Columns("PlanGrupoDes").Caption = "Grupo Cuentas"
         .RootTable.Columns("PlanGrupoDes").Width = 100
         .RootTable.Columns("PlanGrupoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanGrupoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdMainLoad()
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Try
         With oItem
            .SelectFilter = clsItem.SelectFilters.GridCheck
            .WhereFilter = clsItem.WhereFilters.GridCheck
            .OrderByFilter = clsItem.OrderByFilters.GridCheck

            .EmpresaId = mlngEmpresaId
            .TipoItemId = clsTipoItem.PAQUETE
            .TipoTasaId = 1
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
         oItem.Dispose()
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

   Private Sub frmCompraMovLoad()
      Try
         If FormCheck() Then
            Dim frm As New frmCompraMov

            With frm
               .EmpresaId = mlngEmpresaId
               .GestionId = clsAppInfo.GestionId
               .AlmacenId = ListPosition(cboAlmacen, cboAlmacen.SelectedIndex)
               .ProveedorId = ListPosition(cboProveedor, cboProveedor.SelectedIndex)
               .MedidaId = ListPosition(cboMedida, cboMedida.SelectedIndex)
               .TipoPagoId = ListPosition(cboTipoPago, cboTipoPago.SelectedIndex)
               .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
               .Resumido = ToBoolean(optResumido.Checked)
               .Diario = ToBoolean(optDiario.Checked)
               .IntervaloFecha = ToBoolean(chkFecha.Checked)
               .FechaIni = ToDate(dtpFechaIni.Value)
               .FechaFin = ToDate(dtpFechaFin.Value)
               .OrdenarFecha = ToBoolean(chkOrdenarFecha.Checked)
               .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)

               .ListaItem = moListaItem
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
      moListaItem = New Queue
      moListaCentroCosto = New Queue

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("Sel").Value Then
            moListaItem.Enqueue(oRow.Cells("ItemId").Value)
         End If
      Next
      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboCentroCosto.DropDownList.GetCheckedRows
         moListaCentroCosto.Enqueue(oRow.Cells("CentroCostoId").Value)
      Next
      If moListaItem.Count = 0 Then
         strMsg &= "Seleccione al Menos un Ítem" & vbCrLf
      End If

      If clsAppInfo.SucursalApli Then
         If cboSucursal.SelectedIndex = -1 Then
            strMsg &= "Seleccione una Sucursal" & vbCrLf
         End If
      End If

      If cboAlmacen.SelectedIndex = -1 Then
         strMsg &= "Seleccione un Almacén" & vbCrLf
      End If

      If cboProveedor.SelectedIndex = -1 Then
         strMsg &= "Seleccione un Proveedor" & vbCrLf
      End If

      If clsAppInfo.CentroCostoApli Then
         If moListaCentroCosto.Count = 0 Then
            strMsg &= "Seleccione al Menos un Centro de Costo" & vbCrLf
         End If
      End If

      If ListPosition(cboMedida, cboMedida.SelectedIndex) = 0 Then
         strMsg &= "Seleccione una Medida" & vbCrLf
      End If

      If cboTipoPago.SelectedIndex = -1 Then
         strMsg &= "Seleccione un Tipo de Pago" & vbCrLf
      End If

      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) = 0 Then
         strMsg &= "Seleccione una Moneda" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

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

#Region " Otros Eventos "
   Private Sub cboSucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSucursal.SelectedIndexChanged
      Dim lngSucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
      If lngSucursalId <> 0 Then
         cboAlmacenLoad(lngSucursalId)
         cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, 0)
      Else
         cboAlmacenLoad(0)
         cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, 0)
      End If
   End Sub
#End Region
End Class
