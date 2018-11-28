Public Class frmCompraOtroCostoEdit
   Inherits System.Windows.Forms.Form

   Private moCompraOtroCosto As clsCompraOtroCosto

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents cboPlanAdd As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents cboCentroCostoDet As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
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

   ''WriteOnly Property DataObject() As clsCompraOtroCosto
   Property DataObject() As clsCompraOtroCosto
      Get
         Return moCompraOtroCosto
      End Get

      Set(ByVal Value As clsCompraOtroCosto)
         moCompraOtroCosto = Value
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
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboPlanOtroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtCompraOtroCostoId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtCompraOtroCostoDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents chkPlan As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents lblPlan As System.Windows.Forms.Label
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraOtroCostoEdit))
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
      Me.cboPlanAdd = New Janus.Windows.EditControls.UIComboBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCostoDet = New Janus.Windows.EditControls.UIComboBox
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.chkPlan = New Janus.Windows.EditControls.UICheckBox
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.lblPlan = New System.Windows.Forms.Label
      Me.txtCompraOtroCostoDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboPlanOtroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtCompraOtroCostoId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.bcgMain.Controls.Add(Me.cboPlanAdd)
      Me.bcgMain.Controls.Add(Me.Label6)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 308)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboPlanAdd
      '
      Me.cboPlanAdd.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAdd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAdd.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAdd.Location = New System.Drawing.Point(124, 186)
      Me.cboPlanAdd.Name = "cboPlanAdd"
      Me.cboPlanAdd.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanAdd.Size = New System.Drawing.Size(320, 20)
      Me.cboPlanAdd.TabIndex = 215
      Me.cboPlanAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(16, 190)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(100, 16)
      Me.Label6.TabIndex = 216
      Me.Label6.Text = "Analítico Adicional"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboCentroCostoDet)
      Me.grpMain.Controls.Add(Me.cboCentroCosto)
      Me.grpMain.Controls.Add(Me.cboSucursal)
      Me.grpMain.Controls.Add(Me.Label8)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.chkPlan)
      Me.grpMain.Controls.Add(Me.cboPlan)
      Me.grpMain.Controls.Add(Me.lblPlan)
      Me.grpMain.Controls.Add(Me.txtCompraOtroCostoDes)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.txtMonto)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.cboPlanOtroCosto)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtCompraOtroCostoId)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 300)
      Me.grpMain.TabIndex = 160
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCostoDet
      '
      Me.cboCentroCostoDet.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCostoDet.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCostoDet.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCostoDet.Location = New System.Drawing.Point(116, 236)
      Me.cboCentroCostoDet.Name = "cboCentroCostoDet"
      Me.cboCentroCostoDet.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCostoDet.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCostoDet.TabIndex = 221
      Me.cboCentroCostoDet.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(116, 212)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCosto.TabIndex = 220
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboSucursal
      '
      Me.cboSucursal.Enabled = False
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(116, 260)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.ReadOnly = True
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(320, 20)
      Me.cboSucursal.TabIndex = 222
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(7, 240)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 219
      Me.Label8.Text = "Actividad de C.C."
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(7, 216)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 218
      Me.Label9.Text = "Centro de Costo"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(7, 264)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 217
      Me.Label10.Text = "Sucursal"
      '
      'chkPlan
      '
      Me.chkPlan.BackColor = System.Drawing.Color.Transparent
      Me.chkPlan.Checked = True
      Me.chkPlan.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkPlan.Location = New System.Drawing.Point(100, 160)
      Me.chkPlan.Name = "chkPlan"
      Me.chkPlan.Size = New System.Drawing.Size(16, 16)
      Me.chkPlan.TabIndex = 202
      Me.chkPlan.TabStop = False
      Me.chkPlan.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboPlan
      '
      cboPlan_DesignTimeLayout.LayoutString = resources.GetString("cboPlan_DesignTimeLayout.LayoutString")
      Me.cboPlan.DesignTimeLayout = cboPlan_DesignTimeLayout
      Me.cboPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlan.Location = New System.Drawing.Point(116, 160)
      Me.cboPlan.Name = "cboPlan"
      Me.cboPlan.SelectedIndex = -1
      Me.cboPlan.SelectedItem = Nothing
      Me.cboPlan.Size = New System.Drawing.Size(320, 20)
      Me.cboPlan.TabIndex = 6
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblPlan
      '
      Me.lblPlan.BackColor = System.Drawing.Color.Transparent
      Me.lblPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPlan.Location = New System.Drawing.Point(8, 164)
      Me.lblPlan.Name = "lblPlan"
      Me.lblPlan.Size = New System.Drawing.Size(88, 16)
      Me.lblPlan.TabIndex = 203
      Me.lblPlan.Text = "Contra Cuenta"
      '
      'txtCompraOtroCostoDes
      '
      Me.txtCompraOtroCostoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompraOtroCostoDes.Location = New System.Drawing.Point(116, 88)
      Me.txtCompraOtroCostoDes.MaxLength = 100
      Me.txtCompraOtroCostoDes.Name = "txtCompraOtroCostoDes"
      Me.txtCompraOtroCostoDes.Size = New System.Drawing.Size(320, 20)
      Me.txtCompraOtroCostoDes.TabIndex = 3
      Me.txtCompraOtroCostoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompraOtroCostoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 92)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 179
      Me.Label5.Text = "Descripción"
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
      Me.dtpFecha.Location = New System.Drawing.Point(116, 40)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(124, 20)
      Me.dtpFecha.TabIndex = 1
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 44)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 177
      Me.Label3.Text = "Fecha"
      '
      'txtMonto
      '
      Me.txtMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMonto.FormatString = "##,##0.000"
      Me.txtMonto.Location = New System.Drawing.Point(116, 136)
      Me.txtMonto.Name = "txtMonto"
      Me.txtMonto.Size = New System.Drawing.Size(124, 20)
      Me.txtMonto.TabIndex = 5
      Me.txtMonto.Text = "0,000"
      Me.txtMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(116, 112)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.ReadOnly = True
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(124, 20)
      Me.cboMoneda.TabIndex = 4
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 116)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 175
      Me.Label2.Text = "Moneda"
      '
      'cboPlanOtroCosto
      '
      Me.cboPlanOtroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanOtroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanOtroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanOtroCosto.Location = New System.Drawing.Point(116, 64)
      Me.cboPlanOtroCosto.Name = "cboPlanOtroCosto"
      Me.cboPlanOtroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanOtroCosto.Size = New System.Drawing.Size(320, 20)
      Me.cboPlanOtroCosto.TabIndex = 2
      Me.cboPlanOtroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 68)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 173
      Me.Label1.Text = "Otro Costo"
      '
      'txtCompraOtroCostoId
      '
      Me.txtCompraOtroCostoId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompraOtroCostoId.Location = New System.Drawing.Point(116, 16)
      Me.txtCompraOtroCostoId.Name = "txtCompraOtroCostoId"
      Me.txtCompraOtroCostoId.ReadOnly = True
      Me.txtCompraOtroCostoId.Size = New System.Drawing.Size(124, 20)
      Me.txtCompraOtroCostoId.TabIndex = 0
      Me.txtCompraOtroCostoId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompraOtroCostoId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 140)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 171
      Me.Label4.Text = "Monto"
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
      'frmCompraOtroCostoEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 336)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompraOtroCostoEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompraOtroCosto Edit"
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).EndInit()
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
               ''mlngID = moCompraOtroCosto.CompraOtroCostoId 

               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompraOtroCostoEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompraOtroCostoEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Otro Costo"
         Else
            Me.Text = "Editar Otro Costo"
         End If
      Else
         Me.Text = "Nuevo Otro Costo"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCompraOtroCosto
         txtCompraOtroCostoId.Text = ToStr(.CompraOtroCostoId)
         cboPlanOtroCosto.SelectedIndex = ListFindItem(cboPlanOtroCosto, .PlanOtroCostoId)
         dtpFecha.Text = .Fecha
         txtCompraOtroCostoDes.Text = ToStr(.CompraOtroCostoDes)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtMonto.Text = ToDecStr(.Monto)

         If Not clsAppInfo.Inventario Then
            lblPlan.Visible = False
            chkPlan.Visible = False
            cboPlan.Visible = False
         Else
            cboPlan.Value = ListFindItem(cboPlan, .PlanId)
            cboPlanAdd.SelectedIndex = ListFindItem(cboPlanAdd, .PlanAddId)
            cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
            cboCentroCostoDet.SelectedIndex = ListFindItem(cboCentroCostoDet, .CentroCostoDetId)
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

            If clsAppInfo.CentroCostoApli Then
               cboCentroCosto.Enabled = False
               cboCentroCosto.ReadOnly = True
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCompraOtroCosto
         txtCompraOtroCostoId.Text = String.Empty
         cboPlanOtroCosto.SelectedIndex = -1
         dtpFecha.Text = .Fecha
         txtCompraOtroCostoDes.Text = String.Empty
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtMonto.Text = String.Empty
         cboPlan.Value = Nothing

         If Not clsAppInfo.Inventario Then
            lblPlan.Visible = False
            chkPlan.Visible = False
            cboPlan.Visible = False
         End If

         cboPlanAdd.SelectedIndex = -1
         cboPlanAdd.Enabled = False
         cboCentroCosto.SelectedIndex = -1
         cboCentroCosto.Enabled = False
         cboCentroCostoDet.SelectedIndex = -1
         cboCentroCostoDet.Enabled = False

         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)
         cboSucursal.Enabled = False
         cboSucursal.ReadOnly = True

         If clsAppInfo.CentroCostoApli Then
            cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
            cboCentroCosto.Enabled = False
            cboCentroCosto.ReadOnly = True

            Call cboCentroCostoDetLoad(.CentroCostoId)
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCompraOtroCostoId.ReadOnly = True
      cboPlanOtroCosto.ReadOnly = True
      dtpFecha.ReadOnly = True
      txtCompraOtroCostoDes.ReadOnly = True
      cboMoneda.ReadOnly = True
      txtMonto.ReadOnly = True
      cboPlan.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCompraOtroCosto
         If Not mboolAdding Then
            .CompraOtroCostoId = ToLong(txtCompraOtroCostoId.Text)
         End If

         .PlanOtroCostoId = ListPosition(cboPlanOtroCosto, cboPlanOtroCosto.SelectedIndex)
         '.Fecha = ToDate(dtpFecha.Value)
         .Fecha = ToDateDMY(dtpFecha.Value)
         .CompraOtroCostoDes = ToStr(txtCompraOtroCostoDes.Text)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .Monto = ToDecimal(txtMonto.Text)
         .PlanId = ListPosition(cboPlan)

         .PlanAddId = ListPosition(cboPlanAdd, cboPlanAdd.SelectedIndex)
         .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
         .CentroCostoDetId = ListPosition(cboCentroCostoDet, cboCentroCostoDet.SelectedIndex)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)


      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      dtpFecha.Select()
   End Sub


   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If FormCheck() Then
            If mboolAdding Then
               'DataSave = DataAdd()
               DataSave = True
            Else
               'DataSave = DataUpdate()
               DataSave = True
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

         If moCompraOtroCosto.Insert() Then
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

         If moCompraOtroCosto.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If moCompraOtroCosto.PlanOtroCostoId = 0 Then
         strMsg &= "Grupo de Cuenta Inválido" & vbCrLf
      End If

      If moCompraOtroCosto.Monto <= 0 Then
         strMsg &= "Monto Inválido" & vbCrLf
      End If

      If clsAppInfo.Inventario Then
         If moCompraOtroCosto.PlanId = 0 Then
            strMsg &= "Contra Cuenta Inválida" & vbCrLf
         Else
            If cboPlanAdd.Enabled Then
               If ListPosition(cboPlanAdd, cboPlanAdd.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione el Analítico Adicional" & vbCrLf
               End If
            End If

            If cboSucursal.Enabled Then
               If ListPosition(cboSucursal, cboSucursal.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione la Sucursal" & vbCrLf
               End If
            End If

            If cboCentroCosto.Enabled Then
               If ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione el Centro de Costo" & vbCrLf
               End If
            End If

            If cboCentroCostoDet.Enabled Then
               If ListPosition(cboCentroCostoDet, cboCentroCostoDet.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione la Actividad de Centro de Costo" & vbCrLf
               End If
            End If
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtMonto.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()
      Call cboPlanOtroCostoLoad()
      Call cboMonedaLoad()
      Call cboPlanLoad()

      Call cboSucursalLoad()
      Call cboCentroCostoLoad()
   End Sub

   Private Sub cboPlanOtroCostoLoad()
      Dim oPlanOtroCosto As New clsPlanOtroCosto(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPlanOtroCosto.Items.Clear()

      Try
         With oPlanOtroCosto
            .SelectFilter = clsPlanOtroCosto.SelectFilters.ListBox
            .WhereFilter = clsPlanOtroCosto.WhereFilters.EmpresaId
            .OrderByFilter = clsPlanOtroCosto.OrderByFilters.PlanOtroCostoDes
            .EmpresaId = moCompraOtroCosto.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.PlanOtroCostoId, .PlanOtroCostoDes)

                  cboPlanOtroCosto.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanOtroCosto.Dispose()
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

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.EsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moCompraOtroCosto.EmpresaId
            .EsAna = 1
            .PlanId = moCompraOtroCosto.PlanId
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then
               With cboPlan
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = 205

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Sub chkPlan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlan.CheckedChanged
      If chkPlan.Checked Then
         cboPlan.DisplayMember = "PlanDes"
      Else
         cboPlan.DisplayMember = "PlanCta"
      End If
   End Sub

   Private Sub cboPlanOtroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPlanOtroCosto.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then


               Dim frm As New frmPlanOtroCostoEdit
               Dim oPlanOtroCosto As New clsPlanOtroCosto(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oPlanOtroCosto.EmpresaId = moCompraOtroCosto.EmpresaId

                     .DataObject = oPlanOtroCosto
                     .ShowDialog()

                     If .Changed Then
                        Call cboPlanOtroCostoLoad()
                        cboPlanOtroCosto.SelectedIndex = ListFindItem(cboPlanOtroCosto, ToLong(frm.ID))

                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oPlanOtroCosto.Dispose()

               End Try

            End If
         End If
      End If
   End Sub

   Private Sub frmCompraOtroCostoEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               ''mlngID = moCompraOtroCosto.CompraOtroCostoId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompraOtroCostoEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompraOtroCosto.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub cboPlan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlan.ValueChanged
      If cboPlan.Tag <> cboPlan.Text Then
         cboPlan.Tag = cboPlan.Text

         Dim lngPlanId As Long = ListPosition(cboPlan)
         Dim boolTieneAnaAdd As Long
         Dim lngSucCCO As Long = TieneSucCCO(lngPlanId, boolTieneAnaAdd)

         If boolTieneAnaAdd Then
            Call cboPlanAddLoad(lngPlanId)
            cboPlanAdd.SelectedIndex = -1
            cboPlanAdd.Text = ""
            cboPlanAdd.Enabled = True

         Else
            cboPlanAdd.Items.Clear()
            cboPlanAdd.SelectedIndex = -1
            cboPlanAdd.Text = ""
            cboPlanAdd.Enabled = False
         End If

         If Not clsAppInfo.CentroCostoApli Then
            If lngSucCCO = 1 Then
               ''cboSucursal.SelectedIndex = -1
               ''cboSucursal.Enabled = True
               ''cboSucursal.Text = ""
               cboCentroCosto.SelectedIndex = -1
               cboCentroCosto.Enabled = False
               cboCentroCosto.Text = ""
               cboCentroCostoDet.SelectedIndex = -1
               cboCentroCostoDet.Enabled = False
               cboCentroCostoDet.Text = ""

            ElseIf lngSucCCO = 2 Then
               ''cboSucursal.SelectedIndex = -1
               ''cboSucursal.Enabled = False
               ''cboSucursal.Text = ""
               cboCentroCosto.SelectedIndex = -1
               cboCentroCosto.Enabled = True
               cboCentroCosto.Text = ""
               cboCentroCostoDet.SelectedIndex = -1
               cboCentroCostoDet.Enabled = False
               cboCentroCostoDet.Text = ""

            Else
               ''cboSucursal.SelectedIndex = -1
               ''cboSucursal.Enabled = False
               ''cboSucursal.Text = ""
               cboCentroCosto.SelectedIndex = -1
               cboCentroCosto.Enabled = False
               cboCentroCosto.Text = ""
               cboCentroCostoDet.SelectedIndex = -1
               cboCentroCostoDet.Enabled = False
               cboCentroCostoDet.Text = ""
            End If
         Else

            If lngSucCCO = 1 Then
               cboSucursal.SelectedIndex = -1
               cboSucursal.Enabled = True
               cboSucursal.Text = ""

            ElseIf lngSucCCO = 2 Then
               cboSucursal.SelectedIndex = -1
               cboSucursal.Enabled = False
               cboSucursal.Text = ""

            End If
         End If


      End If
   End Sub

   Private Sub cboPlanAddLoad(ByVal lngPlanId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPlanAdd.Items.Clear()

      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.ListBox
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes
            .EmpresaId = clsAppInfo.EmpresaId
            .PlanId = lngPlanId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.PlanAddId, .PlanAddDes)

                  cboPlanAdd.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanAdd.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboSucursalLoad()
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSucursal.Items.Clear()

      Try
         With oSucursal
            .SelectFilter = clsSucursal.SelectFilters.ListBox
            .WhereFilter = clsSucursal.WhereFilters.EmpresaId
            .OrderByFilter = clsSucursal.OrderByFilters.SucursalDes
            .EmpresaId = moCompraOtroCosto.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.SucursalId, .SucursalDes)

                  cboSucursal.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()
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
            .EmpresaId = moCompraOtroCosto.EmpresaId
            .EstadoId = clsEstado.ACTIVO
            .CentroCostoId = moCompraOtroCosto.CentroCostoId

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

   Private Sub cboCentroCostoDetLoad(ByVal lngCentroCostoId As Long)
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCostoDet.Items.Clear()

      Try
         With oCentroCostoDet
            .SelectFilter = clsCentroCostoDet.SelectFilters.ListBox
            .WhereFilter = clsCentroCostoDet.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCostoDet.OrderByFilters.CentroCostoDetDes
            .EmpresaId = moCompraOtroCosto.EmpresaId
            .CentroCostoId = lngCentroCostoId
            .EstadoId = clsEstado.ACTIVO
            .CentroCostoDetId = moCompraOtroCosto.CentroCostoDetId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.CentroCostoDetId, .CentroCostoDetDes)

                  cboCentroCostoDet.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCostoDet.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Function TieneSucCCO(ByVal lngPlanId As Long, ByRef boolTieneAnaAdd As Boolean) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TieneSucCCO = 0

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               TieneSucCCO = .SucCCOId
               boolTieneAnaAdd = ToBoolean(.TieneAnaAdd)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Sub cboCentroCosto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroCosto.SelectedIndexChanged
      If cboCentroCosto.Tag <> cboCentroCosto.Text Then
         cboCentroCosto.Tag = cboCentroCosto.Text
         cboCentroCostoDet.Text = ""

         Call cboCentroCostoDetLoad(ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex))

         If cboCentroCostoDet.Items.Count > 0 Then
            cboCentroCostoDet.Enabled = True
         Else
            cboCentroCostoDet.Enabled = False
         End If
      End If
   End Sub

End Class
