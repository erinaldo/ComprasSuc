Public Class frmCompraParaEdit
   Inherits System.Windows.Forms.Form

   Private moCompraPara As clsCompraPara

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents txtTitulo As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtRowsMax As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkPrintAuto As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents tabGeneral As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabAutorizaciones As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents chkFacFechaMen As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkPagoAuto As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboTipoFormImp As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents cboTipoImpresion As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents tabImpresion As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents grpImpresion As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkEditarProvPed As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents grbFacturaCompu As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtRevisionDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtEmisionDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtIsoDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents chkAprobadoAutoDoc As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkUpdatePrecioVen As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkEditarAprobadoDoc As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents txtSucursalId As Janus.Windows.GridEX.EditControls.EditBox
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

   WriteOnly Property DataObject() As clsCompraPara
      Set(ByVal Value As clsCompraPara)
         moCompraPara = Value
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
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtCompraParaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtGestionId As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtTipoCompraId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEstadoId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtNroIni As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNroActual As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
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
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtFirma As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboTipoHoja As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraParaEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.tabGeneral = New Janus.Windows.UI.Tab.UITabPage
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtRowsMax = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtTitulo = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.cboTipoHoja = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtFirma = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtNroActual = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtNroIni = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtEstadoId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtTipoCompraId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtGestionId = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtCompraParaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.tabImpresion = New Janus.Windows.UI.Tab.UITabPage
      Me.grpImpresion = New Janus.Windows.EditControls.UIGroupBox
      Me.grbFacturaCompu = New Janus.Windows.EditControls.UIGroupBox
      Me.txtRevisionDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtEmisionDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtIsoDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.cboTipoFormImp = New Janus.Windows.EditControls.UIComboBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.cboTipoImpresion = New Janus.Windows.EditControls.UIComboBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.tabAutorizaciones = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkEditarAprobadoDoc = New Janus.Windows.EditControls.UICheckBox
      Me.chkUpdatePrecioVen = New Janus.Windows.EditControls.UICheckBox
      Me.chkAprobadoAutoDoc = New Janus.Windows.EditControls.UICheckBox
      Me.chkEditarProvPed = New Janus.Windows.EditControls.UICheckBox
      Me.chkPagoAuto = New Janus.Windows.EditControls.UICheckBox
      Me.chkFacFechaMen = New Janus.Windows.EditControls.UICheckBox
      Me.chkPrintAuto = New Janus.Windows.EditControls.UICheckBox
      Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.txtSucursalId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.lblSucursal = New System.Windows.Forms.Label
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabMain.SuspendLayout()
      Me.tabGeneral.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.tabImpresion.SuspendLayout()
      CType(Me.grpImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpImpresion.SuspendLayout()
      CType(Me.grbFacturaCompu, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbFacturaCompu.SuspendLayout()
      Me.tabAutorizaciones.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.tabMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(463, 367)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(4, 4)
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(456, 356)
      Me.tabMain.TabIndex = 161
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabGeneral, Me.tabImpresion, Me.tabAutorizaciones})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'tabGeneral
      '
      Me.tabGeneral.Controls.Add(Me.grpMain)
      Me.tabGeneral.Key = "General"
      Me.tabGeneral.Location = New System.Drawing.Point(1, 21)
      Me.tabGeneral.Name = "tabGeneral"
      Me.tabGeneral.Size = New System.Drawing.Size(454, 334)
      Me.tabGeneral.TabStop = True
      Me.tabGeneral.Text = "General"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtSucursalId)
      Me.grpMain.Controls.Add(Me.lblSucursal)
      Me.grpMain.Controls.Add(Me.txtRowsMax)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.txtTitulo)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.cboTipoHoja)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtFirma)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.txtNroActual)
      Me.grpMain.Controls.Add(Me.txtNroIni)
      Me.grpMain.Controls.Add(Me.txtEstadoId)
      Me.grpMain.Controls.Add(Me.txtTipoCompraId)
      Me.grpMain.Controls.Add(Me.txtGestionId)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtCompraParaId)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.Label8)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Location = New System.Drawing.Point(4, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 324)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtRowsMax
      '
      Me.txtRowsMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtRowsMax.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtRowsMax.Location = New System.Drawing.Point(116, 272)
      Me.txtRowsMax.Name = "txtRowsMax"
      Me.txtRowsMax.Size = New System.Drawing.Size(124, 20)
      Me.txtRowsMax.TabIndex = 10
      Me.txtRowsMax.Text = "0"
      Me.txtRowsMax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtRowsMax.Value = 0
      Me.txtRowsMax.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtRowsMax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 276)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 211
      Me.Label2.Text = "Max. Reg."
      '
      'txtTitulo
      '
      Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTitulo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTitulo.Location = New System.Drawing.Point(116, 160)
      Me.txtTitulo.MaxLength = 255
      Me.txtTitulo.Name = "txtTitulo"
      Me.txtTitulo.Size = New System.Drawing.Size(320, 20)
      Me.txtTitulo.TabIndex = 7
      Me.txtTitulo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTitulo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 164)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 205
      Me.Label4.Text = "Título"
      '
      'cboTipoHoja
      '
      Me.cboTipoHoja.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoHoja.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.Location = New System.Drawing.Point(116, 248)
      Me.cboTipoHoja.Name = "cboTipoHoja"
      Me.cboTipoHoja.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoHoja.Size = New System.Drawing.Size(320, 20)
      Me.cboTipoHoja.TabIndex = 9
      Me.cboTipoHoja.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 252)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 203
      Me.Label1.Text = "Tamaño Hoja"
      '
      'txtFirma
      '
      Me.txtFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFirma.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFirma.Location = New System.Drawing.Point(116, 184)
      Me.txtFirma.MaxLength = 1000
      Me.txtFirma.Multiline = True
      Me.txtFirma.Name = "txtFirma"
      Me.txtFirma.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.txtFirma.Size = New System.Drawing.Size(320, 60)
      Me.txtFirma.TabIndex = 8
      Me.txtFirma.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFirma.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      Me.txtFirma.WordWrap = False
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 188)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 201
      Me.Label18.Text = "Firma"
      '
      'txtNroActual
      '
      Me.txtNroActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNroActual.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroActual.Location = New System.Drawing.Point(116, 136)
      Me.txtNroActual.Name = "txtNroActual"
      Me.txtNroActual.Size = New System.Drawing.Size(124, 20)
      Me.txtNroActual.TabIndex = 6
      Me.txtNroActual.Text = "0"
      Me.txtNroActual.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroActual.Value = 0
      Me.txtNroActual.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtNroActual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNroIni
      '
      Me.txtNroIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNroIni.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroIni.Location = New System.Drawing.Point(116, 112)
      Me.txtNroIni.Name = "txtNroIni"
      Me.txtNroIni.Size = New System.Drawing.Size(124, 20)
      Me.txtNroIni.TabIndex = 5
      Me.txtNroIni.Text = "0"
      Me.txtNroIni.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroIni.Value = 0
      Me.txtNroIni.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtNroIni.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEstadoId
      '
      Me.txtEstadoId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEstadoId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEstadoId.Location = New System.Drawing.Point(116, 296)
      Me.txtEstadoId.Name = "txtEstadoId"
      Me.txtEstadoId.ReadOnly = True
      Me.txtEstadoId.Size = New System.Drawing.Size(320, 20)
      Me.txtEstadoId.TabIndex = 11
      Me.txtEstadoId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEstadoId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTipoCompraId
      '
      Me.txtTipoCompraId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTipoCompraId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCompraId.Location = New System.Drawing.Point(116, 88)
      Me.txtTipoCompraId.Name = "txtTipoCompraId"
      Me.txtTipoCompraId.ReadOnly = True
      Me.txtTipoCompraId.Size = New System.Drawing.Size(124, 20)
      Me.txtTipoCompraId.TabIndex = 4
      Me.txtTipoCompraId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTipoCompraId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtGestionId
      '
      Me.txtGestionId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtGestionId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtGestionId.Location = New System.Drawing.Point(116, 64)
      Me.txtGestionId.Name = "txtGestionId"
      Me.txtGestionId.ReadOnly = True
      Me.txtGestionId.Size = New System.Drawing.Size(124, 20)
      Me.txtGestionId.TabIndex = 3
      Me.txtGestionId.Text = "0"
      Me.txtGestionId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtGestionId.Value = 0
      Me.txtGestionId.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtGestionId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(116, 40)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(320, 20)
      Me.txtEmpresaId.TabIndex = 2
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCompraParaId
      '
      Me.txtCompraParaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCompraParaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompraParaId.Location = New System.Drawing.Point(116, 16)
      Me.txtCompraParaId.Name = "txtCompraParaId"
      Me.txtCompraParaId.ReadOnly = True
      Me.txtCompraParaId.Size = New System.Drawing.Size(124, 20)
      Me.txtCompraParaId.TabIndex = 1
      Me.txtCompraParaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompraParaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 92)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 190
      Me.Label6.Text = "Tipo Documento"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 140)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 189
      Me.Label7.Text = "Número Actual"
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 116)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 188
      Me.Label8.Text = "Número Inicial"
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 300)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 187
      Me.Label9.Text = "Estado"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 44)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 186
      Me.Label10.Text = "Empresa"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 68)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(104, 16)
      Me.Label11.TabIndex = 185
      Me.Label11.Text = "Gestión"
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 20)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 184
      Me.Label12.Text = "ID"
      '
      'tabImpresion
      '
      Me.tabImpresion.Controls.Add(Me.grpImpresion)
      Me.tabImpresion.Key = "Impresiones"
      Me.tabImpresion.Location = New System.Drawing.Point(1, 21)
      Me.tabImpresion.Name = "tabImpresion"
      Me.tabImpresion.Size = New System.Drawing.Size(454, 334)
      Me.tabImpresion.TabStop = True
      Me.tabImpresion.Text = "Impresiones"
      '
      'grpImpresion
      '
      Me.grpImpresion.BackColor = System.Drawing.Color.Transparent
      Me.grpImpresion.Controls.Add(Me.grbFacturaCompu)
      Me.grpImpresion.Controls.Add(Me.cboTipoFormImp)
      Me.grpImpresion.Controls.Add(Me.Label14)
      Me.grpImpresion.Controls.Add(Me.cboTipoImpresion)
      Me.grpImpresion.Controls.Add(Me.Label15)
      Me.grpImpresion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpImpresion.Location = New System.Drawing.Point(4, 0)
      Me.grpImpresion.Name = "grpImpresion"
      Me.grpImpresion.Size = New System.Drawing.Size(444, 324)
      Me.grpImpresion.TabIndex = 14
      Me.grpImpresion.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grbFacturaCompu
      '
      Me.grbFacturaCompu.BackColor = System.Drawing.Color.Transparent
      Me.grbFacturaCompu.Controls.Add(Me.txtRevisionDes)
      Me.grbFacturaCompu.Controls.Add(Me.Label13)
      Me.grbFacturaCompu.Controls.Add(Me.txtEmisionDes)
      Me.grbFacturaCompu.Controls.Add(Me.Label5)
      Me.grbFacturaCompu.Controls.Add(Me.txtIsoDes)
      Me.grbFacturaCompu.Controls.Add(Me.Label3)
      Me.grbFacturaCompu.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbFacturaCompu.Location = New System.Drawing.Point(8, 92)
      Me.grbFacturaCompu.Name = "grbFacturaCompu"
      Me.grbFacturaCompu.Size = New System.Drawing.Size(240, 92)
      Me.grbFacturaCompu.TabIndex = 13
      Me.grbFacturaCompu.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtRevisionDes
      '
      Me.txtRevisionDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtRevisionDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtRevisionDes.Location = New System.Drawing.Point(112, 64)
      Me.txtRevisionDes.MaxLength = 50
      Me.txtRevisionDes.Name = "txtRevisionDes"
      Me.txtRevisionDes.Size = New System.Drawing.Size(124, 20)
      Me.txtRevisionDes.TabIndex = 16
      Me.txtRevisionDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtRevisionDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(4, 68)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(104, 16)
      Me.Label13.TabIndex = 196
      Me.Label13.Text = "Revision"
      '
      'txtEmisionDes
      '
      Me.txtEmisionDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmisionDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmisionDes.Location = New System.Drawing.Point(112, 40)
      Me.txtEmisionDes.MaxLength = 50
      Me.txtEmisionDes.Name = "txtEmisionDes"
      Me.txtEmisionDes.Size = New System.Drawing.Size(124, 20)
      Me.txtEmisionDes.TabIndex = 15
      Me.txtEmisionDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmisionDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(4, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 194
      Me.Label5.Text = "Emision"
      '
      'txtIsoDes
      '
      Me.txtIsoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtIsoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIsoDes.Location = New System.Drawing.Point(112, 16)
      Me.txtIsoDes.MaxLength = 50
      Me.txtIsoDes.Name = "txtIsoDes"
      Me.txtIsoDes.Size = New System.Drawing.Size(124, 20)
      Me.txtIsoDes.TabIndex = 14
      Me.txtIsoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtIsoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(4, 20)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 192
      Me.Label3.Text = "ISO"
      '
      'cboTipoFormImp
      '
      Me.cboTipoFormImp.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFormImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFormImp.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFormImp.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFormImp.Location = New System.Drawing.Point(124, 52)
      Me.cboTipoFormImp.Name = "cboTipoFormImp"
      Me.cboTipoFormImp.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoFormImp.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoFormImp.TabIndex = 2
      Me.cboTipoFormImp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(12, 28)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(104, 16)
      Me.Label14.TabIndex = 287
      Me.Label14.Text = "Impresión"
      '
      'cboTipoImpresion
      '
      Me.cboTipoImpresion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoImpresion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoImpresion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoImpresion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoImpresion.Location = New System.Drawing.Point(124, 24)
      Me.cboTipoImpresion.Name = "cboTipoImpresion"
      Me.cboTipoImpresion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoImpresion.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoImpresion.TabIndex = 1
      Me.cboTipoImpresion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(12, 56)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(112, 16)
      Me.Label15.TabIndex = 289
      Me.Label15.Text = "Formato Impresión"
      '
      'tabAutorizaciones
      '
      Me.tabAutorizaciones.Controls.Add(Me.UiGroupBox3)
      Me.tabAutorizaciones.Key = "Autorizaciones"
      Me.tabAutorizaciones.Location = New System.Drawing.Point(1, 21)
      Me.tabAutorizaciones.Name = "tabAutorizaciones"
      Me.tabAutorizaciones.Size = New System.Drawing.Size(454, 334)
      Me.tabAutorizaciones.TabStop = True
      Me.tabAutorizaciones.Text = "Parámetros"
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.chkEditarAprobadoDoc)
      Me.UiGroupBox3.Controls.Add(Me.chkUpdatePrecioVen)
      Me.UiGroupBox3.Controls.Add(Me.chkAprobadoAutoDoc)
      Me.UiGroupBox3.Controls.Add(Me.chkEditarProvPed)
      Me.UiGroupBox3.Controls.Add(Me.chkPagoAuto)
      Me.UiGroupBox3.Controls.Add(Me.chkFacFechaMen)
      Me.UiGroupBox3.Controls.Add(Me.chkPrintAuto)
      Me.UiGroupBox3.Controls.Add(Me.chkConFac)
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(4, 0)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(444, 328)
      Me.UiGroupBox3.TabIndex = 12
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkEditarAprobadoDoc
      '
      Me.chkEditarAprobadoDoc.BackColor = System.Drawing.Color.Transparent
      Me.chkEditarAprobadoDoc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkEditarAprobadoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkEditarAprobadoDoc.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkEditarAprobadoDoc.Location = New System.Drawing.Point(12, 188)
      Me.chkEditarAprobadoDoc.Name = "chkEditarAprobadoDoc"
      Me.chkEditarAprobadoDoc.Size = New System.Drawing.Size(224, 16)
      Me.chkEditarAprobadoDoc.TabIndex = 47
      Me.chkEditarAprobadoDoc.Tag = "24"
      Me.chkEditarAprobadoDoc.Text = "Editar (PUST) "
      Me.chkEditarAprobadoDoc.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
      Me.chkEditarAprobadoDoc.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkUpdatePrecioVen
      '
      Me.chkUpdatePrecioVen.BackColor = System.Drawing.Color.Transparent
      Me.chkUpdatePrecioVen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkUpdatePrecioVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkUpdatePrecioVen.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkUpdatePrecioVen.Location = New System.Drawing.Point(60, 164)
      Me.chkUpdatePrecioVen.Name = "chkUpdatePrecioVen"
      Me.chkUpdatePrecioVen.Size = New System.Drawing.Size(176, 16)
      Me.chkUpdatePrecioVen.TabIndex = 46
      Me.chkUpdatePrecioVen.Tag = "24"
      Me.chkUpdatePrecioVen.Text = "Actualizar Precios de Venta"
      Me.chkUpdatePrecioVen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkAprobadoAutoDoc
      '
      Me.chkAprobadoAutoDoc.BackColor = System.Drawing.Color.Transparent
      Me.chkAprobadoAutoDoc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkAprobadoAutoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkAprobadoAutoDoc.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkAprobadoAutoDoc.Location = New System.Drawing.Point(12, 140)
      Me.chkAprobadoAutoDoc.Name = "chkAprobadoAutoDoc"
      Me.chkAprobadoAutoDoc.Size = New System.Drawing.Size(224, 16)
      Me.chkAprobadoAutoDoc.TabIndex = 45
      Me.chkAprobadoAutoDoc.Tag = "24"
      Me.chkAprobadoAutoDoc.Text = "Aprobación Automática en Pedidos "
      Me.chkAprobadoAutoDoc.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
      Me.chkAprobadoAutoDoc.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkEditarProvPed
      '
      Me.chkEditarProvPed.BackColor = System.Drawing.Color.Transparent
      Me.chkEditarProvPed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkEditarProvPed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkEditarProvPed.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkEditarProvPed.Location = New System.Drawing.Point(12, 116)
      Me.chkEditarProvPed.Name = "chkEditarProvPed"
      Me.chkEditarProvPed.Size = New System.Drawing.Size(224, 16)
      Me.chkEditarProvPed.TabIndex = 35
      Me.chkEditarProvPed.Text = "Permitir cambiar Proveedor (pedido)"
      Me.chkEditarProvPed.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkPagoAuto
      '
      Me.chkPagoAuto.BackColor = System.Drawing.Color.Transparent
      Me.chkPagoAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkPagoAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkPagoAuto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkPagoAuto.Location = New System.Drawing.Point(120, 92)
      Me.chkPagoAuto.Name = "chkPagoAuto"
      Me.chkPagoAuto.Size = New System.Drawing.Size(116, 16)
      Me.chkPagoAuto.TabIndex = 34
      Me.chkPagoAuto.Text = "Pago Automático"
      Me.chkPagoAuto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkFacFechaMen
      '
      Me.chkFacFechaMen.BackColor = System.Drawing.Color.Transparent
      Me.chkFacFechaMen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFacFechaMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFacFechaMen.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFacFechaMen.Location = New System.Drawing.Point(4, 68)
      Me.chkFacFechaMen.Name = "chkFacFechaMen"
      Me.chkFacFechaMen.Size = New System.Drawing.Size(232, 16)
      Me.chkFacFechaMen.TabIndex = 15
      Me.chkFacFechaMen.Text = "Facturas con Fecha Menor a la Compra"
      Me.chkFacFechaMen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkPrintAuto
      '
      Me.chkPrintAuto.BackColor = System.Drawing.Color.Transparent
      Me.chkPrintAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkPrintAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkPrintAuto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkPrintAuto.Location = New System.Drawing.Point(96, 20)
      Me.chkPrintAuto.Name = "chkPrintAuto"
      Me.chkPrintAuto.Size = New System.Drawing.Size(140, 16)
      Me.chkPrintAuto.TabIndex = 13
      Me.chkPrintAuto.Text = "Impresión Automática"
      Me.chkPrintAuto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkConFac
      '
      Me.chkConFac.BackColor = System.Drawing.Color.Transparent
      Me.chkConFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkConFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkConFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkConFac.Location = New System.Drawing.Point(136, 44)
      Me.chkConFac.Name = "chkConFac"
      Me.chkConFac.Size = New System.Drawing.Size(100, 16)
      Me.chkConFac.TabIndex = 14
      Me.chkConFac.Text = "Exigir Factura"
      Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("0da42c1f-4b6d-4f6c-8b74-ff497ec5f8c5")
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
      Me.TopRebar1.Size = New System.Drawing.Size(463, 28)
      '
      'txtSucursalId
      '
      Me.txtSucursalId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSucursalId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSucursalId.Location = New System.Drawing.Point(300, 64)
      Me.txtSucursalId.Name = "txtSucursalId"
      Me.txtSucursalId.ReadOnly = True
      Me.txtSucursalId.Size = New System.Drawing.Size(136, 20)
      Me.txtSucursalId.TabIndex = 218
      Me.txtSucursalId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtSucursalId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblSucursal
      '
      Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
      Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSucursal.Location = New System.Drawing.Point(243, 68)
      Me.lblSucursal.Name = "lblSucursal"
      Me.lblSucursal.Size = New System.Drawing.Size(60, 16)
      Me.lblSucursal.TabIndex = 217
      Me.lblSucursal.Text = "Sucursal"
      '
      'frmCompraParaEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(463, 395)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompraParaEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompraPara Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabMain.ResumeLayout(False)
      Me.tabGeneral.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      Me.tabImpresion.ResumeLayout(False)
      CType(Me.grpImpresion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpImpresion.ResumeLayout(False)
      CType(Me.grbFacturaCompu, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbFacturaCompu.ResumeLayout(False)
      Me.grbFacturaCompu.PerformLayout()
      Me.tabAutorizaciones.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
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
               mlngID = moCompraPara.CompraParaId
               Call CompraParaLoad(moCompraPara.EmpresaId, clsTipoCompra.COMPRA, moCompraPara.GestionId, clsAppInfo.SucursalId)
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompraParaEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompraParaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Parámetro de Documento"
         Else
            Me.Text = "Editar Parámetro de Documento"
         End If
      Else
         Me.Text = "Nuevo Parámetro de Documento"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCompraPara
         txtCompraParaId.Text = ToStr(.CompraParaId)
         Call txtEmpresaIdLoad(.EmpresaId)
         Call txtGestionIdLoad(.GestionId)
         Call txtTipoCompraIdLoad(.TipoCompraId)
         Call txtSucursalIdLoad(.SucursalId)
         txtNroIni.Text = ToStr(.NroIni)
         txtNroActual.Text = ToStr(.NroActual)
         chkConFac.Checked = ToBoolean(.ConFac)
         txtTitulo.Text = ToStr(.Titulo)
         txtFirma.Text = ToStr(.Firma)
         cboTipoHoja.SelectedIndex = ListFindItem(cboTipoHoja, .TipoHojaId)
         txtRowsMax.Text = ToStr(.RowsMax)
         chkPrintAuto.Checked = ToBoolean(.PrintAuto)
         chkFacFechaMen.Checked = ToBoolean(.FacFechaMen)
         chkPagoAuto.Checked = .PagoAuto
         chkEditarProvPed.Checked = .EditarProvPed
         Call txtEstadoIdLoad(.EstadoId)
         cboTipoImpresion.SelectedIndex = ListFindItem(cboTipoImpresion, .TipoImpresionId)
         cboTipoFormImp.SelectedIndex = ListFindItem(cboTipoFormImp, .TipoFormImpId)

         txtIsoDes.Text = ToStr(.IsoDes)
         txtEmisionDes.Text = ToStr(.EmisionDes)
         txtRevisionDes.Text = ToStr(.RevisionDes)
         chkAprobadoAutoDoc.Checked = ToBoolean(.AprobadoAutoDoc)
         chkUpdatePrecioVen.Checked = ToBoolean(.UpdatePrecioVen)
         chkEditarAprobadoDoc.Checked = ToBoolean(.EditarAprobadoDoc)

         Call DataVisible()
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCompraPara
         'txtCompraParaId.Text = String.Empty
         'Call txtEmpresaIdLoad(.EmpresaId)
         chkAprobadoAutoDoc.Checked = False
      End With
      mboolShow = False
   End Sub

   Private Sub DataVisible()
      chkPrintAuto.Visible = True

      chkConFac.Visible = False
      chkFacFechaMen.Visible = False
      chkPagoAuto.Visible = False
      chkEditarProvPed.Visible = False
      chkAprobadoAutoDoc.Visible = False
      chkUpdatePrecioVen.Visible = False
      chkEditarAprobadoDoc.Visible = False

      If moCompraPara.TipoCompraId = 2 Then 'Compras
         chkConFac.Visible = True
         chkFacFechaMen.Visible = True
         chkPagoAuto.Visible = True
         chkEditarProvPed.Visible = True
         chkUpdatePrecioVen.Visible = True

      ElseIf moCompraPara.TipoCompraId = 1 Then ''Pedido 
         chkAprobadoAutoDoc.Visible = True
         chkEditarAprobadoDoc.Visible = True

      End If

      Call AlignComponent()

   End Sub

   Private Sub DataReadOnly()
      txtCompraParaId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      txtGestionId.ReadOnly = True
      txtTipoCompraId.ReadOnly = True
      txtNroIni.ReadOnly = True
      txtNroActual.ReadOnly = True
      chkConFac.Enabled = False
      txtTitulo.ReadOnly = True
      txtFirma.ReadOnly = True
      cboTipoHoja.ReadOnly = True
      txtRowsMax.ReadOnly = True
      chkPrintAuto.Enabled = False
      chkFacFechaMen.Enabled = False
      chkPagoAuto.Enabled = False
      chkEditarProvPed.Enabled = False
      txtEstadoId.ReadOnly = True
      cboTipoImpresion.ReadOnly = True
      cboTipoFormImp.ReadOnly = True
      txtIsoDes.ReadOnly = True
      txtEmisionDes.ReadOnly = True
      txtRevisionDes.ReadOnly = True
      chkAprobadoAutoDoc.Enabled = False
      chkUpdatePrecioVen.Enabled = False
      chkEditarAprobadoDoc.Enabled = False

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCompraPara
         If Not mboolAdding Then
            .CompraParaId = ToLong(txtCompraParaId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .GestionId = ToLong(txtGestionId.Tag)
         .TipoCompraId = ToLong(txtTipoCompraId.Tag)
         .SucursalId = ToLong(txtSucursalId.Tag)
         .NroIni = ToLong(txtNroIni.Text)
         .NroActual = ToLong(txtNroActual.Text)
         .ConFac = ToBoolean(chkConFac.Checked)
         .Titulo = txtTitulo.Text
         .Firma = txtFirma.Text
         .TipoHojaId = ListPosition(cboTipoHoja, cboTipoHoja.SelectedIndex)
         .RowsMax = ToLong(txtRowsMax.Text)
         .PrintAuto = ToBoolean(chkPrintAuto.Checked)
         .FacFechaMen = ToBoolean(chkFacFechaMen.Checked)
         .PagoAuto = ToBoolean(chkPagoAuto.Checked)
         .EditarProvPed = ToBoolean(chkEditarProvPed.Checked)
         .EstadoId = ToLong(txtEstadoId.Tag)
         .TipoImpresionId = ListPosition(cboTipoImpresion, cboTipoImpresion.SelectedIndex)
         .TipoFormImpId = ListPosition(cboTipoFormImp, cboTipoFormImp.SelectedIndex)
         .IsoDes = txtIsoDes.Text
         .EmisionDes = txtEmisionDes.Text
         .RevisionDes = txtRevisionDes.Text
         .AprobadoAutoDoc = ToBoolean(chkAprobadoAutoDoc.Checked)
         .UpdatePrecioVen = ToBoolean(chkUpdatePrecioVen.Checked)
         .EditarAprobadoDoc = ToBoolean(chkEditarAprobadoDoc.Checked)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtNroIni.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If mboolAdding Then
            DataSave = DataAdd()
         Else
            DataSave = DataUpdate()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moCompraPara.Insert() Then
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

         If moCompraPara.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

   End Sub

   Private Sub ComboLoad()
      Call cboTipoHojaLoad()
      Call cboTipoImpresionLoad()
   End Sub

   Private Sub cboTipoHojaLoad()
      Dim oTipoHoja As New clsTipoHoja(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoHoja.Items.Clear()

      Try
         With oTipoHoja
            .SelectFilter = clsTipoHoja.SelectFilters.ListBox
            .OrderByFilter = clsTipoHoja.OrderByFilters.TipoHojaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoHojaId, .TipoHojaDes)

                  cboTipoHoja.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoHoja.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoImpresionLoad()
      Dim oTipoImpresion As New clsTipoImpresion(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoImpresion.Items.Clear()

      Try
         With oTipoImpresion
            .SelectFilter = clsTipoImpresion.SelectFilters.ListBox
            .OrderByFilter = clsTipoImpresion.OrderByFilters.TipoImpresionDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoImpresionId, .TipoImpresionDes)

                  cboTipoImpresion.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoImpresion.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoFormImpLoad(ByVal lngTipoImpresionId As Long)
      Dim oTipoFormImp As New clsTipoFormImp(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoFormImp.Items.Clear()
      cboTipoFormImp.Text = ""

      Try
         With oTipoFormImp
            .SelectFilter = clsTipoFormImp.SelectFilters.ListBox
            .WhereFilter = clsTipoFormImp.WhereFilters.AppId_TipoDocId
            .OrderByFilter = clsTipoFormImp.OrderByFilters.TipoFormImpId
            .AppId = clsAppInfo.AppId
            .TipoDocumentoId = moCompraPara.TipoCompraId
            .TipoImpresionId = lngTipoImpresionId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoFormImpId, .TipoFormImpDes)

                  cboTipoFormImp.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoFormImp.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoImpresion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoImpresion.SelectedIndexChanged
      Call cboTipoFormImpLoad(ListPosition(cboTipoImpresion, cboTipoImpresion.SelectedIndex))
   End Sub

   Private Sub txtEmpresaIdLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      Try
         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               txtEmpresaId.Tag = .EmpresaId
               txtEmpresaId.Text = ToStr(.EmpresaDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Sub

   Private Sub txtGestionIdLoad(ByVal lngGestionId As Long)
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               txtGestionId.Tag = .GestionId
               txtGestionId.Text = ToStr(.Gestion)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Sub

   Private Sub txtTipoCompraIdLoad(ByVal lngTipoCompraId As Long)
      Dim oTipoCompra As New clsTipoCompra(clsAppInfo.ConnectString)

      Try
         With oTipoCompra
            .TipoCompraId = lngTipoCompraId

            If .FindByPK Then
               txtTipoCompraId.Tag = .TipoCompraId
               txtTipoCompraId.Text = ToStr(.TipoCompraDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCompra.Dispose()

      End Try
   End Sub

   Private Sub txtSucursalIdLoad(ByVal lngSucursalId As Long)
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)

      Try
         With oSucursal
            .SucursalId = lngSucursalId

            If .FindByPK Then
               txtSucursalId.Tag = .SucursalId
               txtSucursalId.Text = ToStr(.SucursalDes)

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()

      End Try
   End Sub

   Private Sub txtEstadoIdLoad(ByVal lngEstadoId As Long)
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)

      Try
         With oEstado
            .EstadoId = lngEstadoId

            If .FindByPK Then
               txtEstadoId.Tag = .EstadoId
               txtEstadoId.Text = ToStr(.EstadoDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEstado.Dispose()

      End Try
   End Sub

#Region "Alineacion Controles"

   Private Sub AlignComponent()
      Dim lngDesplazo As Long = 20
      Dim lngConstSep As Long = 8 ''4
      Dim oPoint As System.Drawing.Point

      '' ''Parametros
      tabMain.TabPages.Item("Autorizaciones").Selected = True
      ControlNewPosicion(chkPrintAuto, lngDesplazo, lngConstSep, oPoint)
      ControlNewPosicion(chkConFac, lngDesplazo, lngConstSep, oPoint)
      ControlNewPosicion(chkFacFechaMen, lngDesplazo, lngConstSep, oPoint)
      ControlNewPosicion(chkPagoAuto, lngDesplazo, lngConstSep, oPoint)
      ControlNewPosicion(chkEditarProvPed, lngDesplazo, lngConstSep, oPoint)
      ControlNewPosicion(chkAprobadoAutoDoc, lngDesplazo, lngConstSep, oPoint)
      ControlNewPosicion(chkUpdatePrecioVen, lngDesplazo, lngConstSep, oPoint)
      ControlNewPosicion(chkEditarAprobadoDoc, lngDesplazo, lngConstSep, oPoint)

      tabMain.TabPages.Item("General").Selected = True

   End Sub

   Private Sub ControlNewPosicion(ByRef oControl As Control, ByRef lngDesplazo As Long, ByVal lngConstSep As Long, ByVal oPoint As System.Drawing.Point)
      oPoint.X = oControl.Location.X
      'oPoint.X = IIf(oControl.Location.X < 230, oControl.Location.X, 24)
      oPoint.Y = lngDesplazo
      oControl.Location = oPoint
      lngDesplazo += IIf(ToBoolean(oControl.Visible), oControl.Height + lngConstSep, 0)

   End Sub

#End Region

   Private Sub frmCompraParaEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moCompraPara.CompraParaId
               Call CompraParaLoad(moCompraPara.EmpresaId, clsTipoCompra.COMPRA, moCompraPara.GestionId, clsAppInfo.SucursalId)

               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompraParaEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompraPara.Dispose()
      Call ClearMemory()
   End Sub

End Class
