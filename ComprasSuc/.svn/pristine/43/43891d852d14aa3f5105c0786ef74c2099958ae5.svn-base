Public Class frmPlanGrupoEdit
   Inherits System.Windows.Forms.Form

   Private moPlanGrupo As clsPlanGrupo

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents UiTabPage5 As Janus.Windows.UI.Tab.UITabPage
   Public WithEvents UiGroupBox5 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents Label24 As System.Windows.Forms.Label
   Friend WithEvents cboTipoActEco1 As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboTipoActEco2 As Janus.Windows.EditControls.UIComboBox
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

   WriteOnly Property DataObject() As clsPlanGrupo
      Set(ByVal Value As clsPlanGrupo)
         moPlanGrupo = Value
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
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtPlanGrupoDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPlanGrupoId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents lblActivo As System.Windows.Forms.Label
   Friend WithEvents cboPlanAct As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanTra As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanIng As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanCos As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboPlanCos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanGrupoEdit))
      Dim cboPlanIng_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanTra_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanAct_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
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
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboPlanCos = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboPlanIng = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboPlanTra = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboPlanAct = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label8 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.lblActivo = New System.Windows.Forms.Label
      Me.txtPlanGrupoDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPlanGrupoId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.UiTabPage5 = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox5 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboTipoActEco1 = New Janus.Windows.EditControls.UIComboBox
      Me.cboTipoActEco2 = New Janus.Windows.EditControls.UIComboBox
      Me.Label23 = New System.Windows.Forms.Label
      Me.Label24 = New System.Windows.Forms.Label
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabMain.SuspendLayout()
      Me.UiTabPage1.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cboPlanCos, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanIng, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanTra, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanAct, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiTabPage5.SuspendLayout()
      CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox5.SuspendLayout()
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
      Me.TopRebar1.Size = New System.Drawing.Size(469, 28)
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.tabMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(469, 227)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(4, 4)
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(460, 220)
      Me.tabMain.TabIndex = 161
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage5})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'UiTabPage1
      '
      Me.UiTabPage1.Controls.Add(Me.grpMain)
      Me.UiTabPage1.Key = "General"
      Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
      Me.UiTabPage1.Name = "UiTabPage1"
      Me.UiTabPage1.Size = New System.Drawing.Size(458, 198)
      Me.UiTabPage1.TabStop = True
      Me.UiTabPage1.Text = "General"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboPlanCos)
      Me.grpMain.Controls.Add(Me.cboPlanIng)
      Me.grpMain.Controls.Add(Me.cboPlanTra)
      Me.grpMain.Controls.Add(Me.cboPlanAct)
      Me.grpMain.Controls.Add(Me.Label8)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.lblActivo)
      Me.grpMain.Controls.Add(Me.txtPlanGrupoDes)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtPlanGrupoId)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Location = New System.Drawing.Point(7, 3)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 188)
      Me.grpMain.TabIndex = 160
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboPlanCos
      '
      cboPlanCos_DesignTimeLayout.LayoutString = resources.GetString("cboPlanCos_DesignTimeLayout.LayoutString")
      Me.cboPlanCos.DesignTimeLayout = cboPlanCos_DesignTimeLayout
      Me.cboPlanCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanCos.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanCos.Location = New System.Drawing.Point(116, 160)
      Me.cboPlanCos.Name = "cboPlanCos"
      Me.cboPlanCos.SelectedIndex = -1
      Me.cboPlanCos.SelectedItem = Nothing
      Me.cboPlanCos.Size = New System.Drawing.Size(320, 20)
      Me.cboPlanCos.TabIndex = 6
      Me.cboPlanCos.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanCos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanIng
      '
      cboPlanIng_DesignTimeLayout.LayoutString = resources.GetString("cboPlanIng_DesignTimeLayout.LayoutString")
      Me.cboPlanIng.DesignTimeLayout = cboPlanIng_DesignTimeLayout
      Me.cboPlanIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanIng.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanIng.Location = New System.Drawing.Point(116, 136)
      Me.cboPlanIng.Name = "cboPlanIng"
      Me.cboPlanIng.SelectedIndex = -1
      Me.cboPlanIng.SelectedItem = Nothing
      Me.cboPlanIng.Size = New System.Drawing.Size(320, 20)
      Me.cboPlanIng.TabIndex = 5
      Me.cboPlanIng.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanIng.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanTra
      '
      cboPlanTra_DesignTimeLayout.LayoutString = resources.GetString("cboPlanTra_DesignTimeLayout.LayoutString")
      Me.cboPlanTra.DesignTimeLayout = cboPlanTra_DesignTimeLayout
      Me.cboPlanTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanTra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanTra.Location = New System.Drawing.Point(116, 112)
      Me.cboPlanTra.Name = "cboPlanTra"
      Me.cboPlanTra.SelectedIndex = -1
      Me.cboPlanTra.SelectedItem = Nothing
      Me.cboPlanTra.Size = New System.Drawing.Size(320, 20)
      Me.cboPlanTra.TabIndex = 4
      Me.cboPlanTra.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanTra.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanAct
      '
      cboPlanAct_DesignTimeLayout.LayoutString = resources.GetString("cboPlanAct_DesignTimeLayout.LayoutString")
      Me.cboPlanAct.DesignTimeLayout = cboPlanAct_DesignTimeLayout
      Me.cboPlanAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanAct.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAct.Location = New System.Drawing.Point(116, 88)
      Me.cboPlanAct.Name = "cboPlanAct"
      Me.cboPlanAct.SelectedIndex = -1
      Me.cboPlanAct.SelectedItem = Nothing
      Me.cboPlanAct.Size = New System.Drawing.Size(320, 20)
      Me.cboPlanAct.TabIndex = 3
      Me.cboPlanAct.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanAct.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 164)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 182
      Me.Label8.Text = "Costos"
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 140)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 180
      Me.Label3.Text = "Ingreso"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 116)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 178
      Me.Label2.Text = "Transito"
      '
      'lblActivo
      '
      Me.lblActivo.BackColor = System.Drawing.Color.Transparent
      Me.lblActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblActivo.Location = New System.Drawing.Point(8, 92)
      Me.lblActivo.Name = "lblActivo"
      Me.lblActivo.Size = New System.Drawing.Size(104, 16)
      Me.lblActivo.TabIndex = 176
      Me.lblActivo.Text = "Activo"
      '
      'txtPlanGrupoDes
      '
      Me.txtPlanGrupoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPlanGrupoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanGrupoDes.Location = New System.Drawing.Point(116, 64)
      Me.txtPlanGrupoDes.MaxLength = 255
      Me.txtPlanGrupoDes.Name = "txtPlanGrupoDes"
      Me.txtPlanGrupoDes.Size = New System.Drawing.Size(320, 20)
      Me.txtPlanGrupoDes.TabIndex = 2
      Me.txtPlanGrupoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanGrupoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(116, 40)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(320, 20)
      Me.txtEmpresaId.TabIndex = 1
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPlanGrupoId
      '
      Me.txtPlanGrupoId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPlanGrupoId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanGrupoId.Location = New System.Drawing.Point(116, 16)
      Me.txtPlanGrupoId.Name = "txtPlanGrupoId"
      Me.txtPlanGrupoId.ReadOnly = True
      Me.txtPlanGrupoId.Size = New System.Drawing.Size(124, 20)
      Me.txtPlanGrupoId.TabIndex = 0
      Me.txtPlanGrupoId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanGrupoId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 68)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 171
      Me.Label4.Text = "Grupo de Cuentas"
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 170
      Me.Label5.Text = "Empresa"
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
      'UiTabPage5
      '
      Me.UiTabPage5.Controls.Add(Me.UiGroupBox5)
      Me.UiTabPage5.Key = "Transitorio"
      Me.UiTabPage5.Location = New System.Drawing.Point(1, 21)
      Me.UiTabPage5.Name = "UiTabPage5"
      Me.UiTabPage5.Size = New System.Drawing.Size(458, 198)
      Me.UiTabPage5.TabStop = True
      Me.UiTabPage5.Tag = "TipoActEco"
      Me.UiTabPage5.Text = "Activida Económica"
      '
      'UiGroupBox5
      '
      Me.UiGroupBox5.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox5.Controls.Add(Me.cboTipoActEco1)
      Me.UiGroupBox5.Controls.Add(Me.cboTipoActEco2)
      Me.UiGroupBox5.Controls.Add(Me.Label23)
      Me.UiGroupBox5.Controls.Add(Me.Label24)
      Me.UiGroupBox5.Location = New System.Drawing.Point(7, 3)
      Me.UiGroupBox5.Name = "UiGroupBox5"
      Me.UiGroupBox5.Size = New System.Drawing.Size(445, 189)
      Me.UiGroupBox5.TabIndex = 17
      Me.UiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboTipoActEco1
      '
      Me.cboTipoActEco1.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoActEco1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoActEco1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoActEco1.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoActEco1.Location = New System.Drawing.Point(128, 16)
      Me.cboTipoActEco1.Name = "cboTipoActEco1"
      Me.cboTipoActEco1.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoActEco1.Size = New System.Drawing.Size(308, 20)
      Me.cboTipoActEco1.TabIndex = 192
      Me.cboTipoActEco1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboTipoActEco2
      '
      Me.cboTipoActEco2.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoActEco2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoActEco2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoActEco2.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoActEco2.Location = New System.Drawing.Point(128, 40)
      Me.cboTipoActEco2.Name = "cboTipoActEco2"
      Me.cboTipoActEco2.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoActEco2.Size = New System.Drawing.Size(308, 20)
      Me.cboTipoActEco2.TabIndex = 193
      Me.cboTipoActEco2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label23
      '
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.Location = New System.Drawing.Point(8, 44)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(112, 16)
      Me.Label23.TabIndex = 189
      Me.Label23.Text = "Actividad Eco. 2"
      '
      'Label24
      '
      Me.Label24.BackColor = System.Drawing.Color.Transparent
      Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label24.Location = New System.Drawing.Point(8, 20)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(112, 16)
      Me.Label24.TabIndex = 187
      Me.Label24.Text = "Actividad Eco. 1"
      '
      'frmPlanGrupoEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(469, 255)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmPlanGrupoEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "PlanGrupo Edit"
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabMain.ResumeLayout(False)
      Me.UiTabPage1.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboPlanCos, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanIng, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanTra, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanAct, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiTabPage5.ResumeLayout(False)
      CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox5.ResumeLayout(False)
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
               mlngID = moPlanGrupo.PlanGrupoId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPlanGrupoEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPlanGrupoEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Grupo de Cuentas"
         Else
            Me.Text = "Editar Grupo de Cuentas"
         End If
      Else
         Me.Text = "Nueva Grupo de Cuentas"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moPlanGrupo
         txtPlanGrupoId.Text = ToStr(.PlanGrupoId)
         Call txtEmpresaIdLoad(.EmpresaId)
         txtPlanGrupoDes.Text = ToStr(.PlanGrupoDes)
         cboPlanAct.Value = ListFindItem(cboPlanAct, .PlanIdAct)
         cboPlanTra.Value = ListFindItem(cboPlanTra, .PlanIdTra)
         cboPlanIng.Value = ListFindItem(cboPlanIng, .PlanIdIng)
         cboPlanCos.Value = ListFindItem(cboPlanCos, .PlanIdCos)


         cboTipoActEco1.SelectedIndex = ListFindItem(cboTipoActEco1, .TipoActEco1Id)
         cboTipoActEco2.SelectedIndex = ListFindItem(cboTipoActEco2, .TipoActEco2Id)
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moPlanGrupo
         txtPlanGrupoId.Text = String.Empty
         Call txtEmpresaIdLoad(.EmpresaId)
         txtPlanGrupoDes.Text = String.Empty
         cboPlanAct.Value = Nothing
         cboPlanTra.Value = Nothing
         cboPlanIng.Value = Nothing
         cboPlanCos.Value = Nothing
         cboTipoActEco1.SelectedIndex = -1
         cboTipoActEco2.SelectedIndex = -1
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtPlanGrupoId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      txtPlanGrupoDes.ReadOnly = True
      cboPlanAct.ReadOnly = True
      cboPlanTra.ReadOnly = True
      cboPlanIng.ReadOnly = True
      cboPlanCos.ReadOnly = True
      cboTipoActEco1.ReadOnly = True
      cboTipoActEco2.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moPlanGrupo
         If Not mboolAdding Then
            .PlanGrupoId = ToLong(txtPlanGrupoId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .PlanGrupoDes = ToStr(txtPlanGrupoDes.Text)
         .PlanIdAct = ListPosition(cboPlanAct)
         .PlanIdTra = ListPosition(cboPlanTra)
         .PlanIdIng = ListPosition(cboPlanIng)
         .PlanIdCos = ListPosition(cboPlanCos)
         .TipoActEco1Id = ListPosition(cboTipoActEco1, cboTipoActEco1.SelectedIndex)
         .TipoActEco2Id = ListPosition(cboTipoActEco2, cboTipoActEco2.SelectedIndex)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtPlanGrupoDes.Select()
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

         If moPlanGrupo.Insert() Then
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

         If moPlanGrupo.Update() Then
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
      Call cboPlanLoad()
      Call cboTipoActEcoLoad()
   End Sub

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.EsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moPlanGrupo.EmpresaId
            .EsAna = 1

            If .Open() Then
               With cboPlanAct
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

               With cboPlanTra
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

               With cboPlanIng
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

               With cboPlanCos
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

   Private Sub cboTipoActEcoLoad()
      Dim oRubro As New clsTipoActEco(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoActEco1.Items.Clear()
      cboTipoActEco2.Items.Clear()

      Try
         With oRubro
            .SelectFilter = clsTipoActEco.SelectFilters.ListBox
            .WhereFilter = clsTipoActEco.WhereFilters.EmpresaId
            .OrderByFilter = clsTipoActEco.OrderByFilters.TipoActEcoDes
            .EmpresaId = moPlanGrupo.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoActEcoId, .TipoActEcoDes)

                  cboTipoActEco1.Items.Add(oItem)
                  cboTipoActEco2.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRubro.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Function PlanDesFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               Return ToStr(.PlanDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

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

   Private Sub frmPlanGrupoEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moPlanGrupo.PlanGrupoId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPlanGrupoEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlanGrupo.Dispose()
      Call ClearMemory()
   End Sub

End Class
