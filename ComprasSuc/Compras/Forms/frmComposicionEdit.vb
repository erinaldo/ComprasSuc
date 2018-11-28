Public Class frmComposicionEdit
   Inherits System.Windows.Forms.Form

   Private moComposicion As clsComposicion

   Private mlngTipoItemId As Long
   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long
   Private mdecCantidadMin As Decimal
   Private mdecCantidadMax As Decimal
   Private mboolControlLote As Boolean
   Private mboolControlSerie As Boolean

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents chkItemCom As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboItemCom As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents txtPrecioCos As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblPrecioCos As System.Windows.Forms.Label
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

   WriteOnly Property DataObject() As clsComposicion
      Set(ByVal Value As clsComposicion)
         moComposicion = Value
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
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtComposicionId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtItemId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtCantidad As Janus.Windows.GridEX.EditControls.NumericEditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents cboMedida As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboItemCom_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComposicionEdit))
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
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtPrecioCos = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.lblPrecioCos = New System.Windows.Forms.Label
      Me.chkItemCom = New Janus.Windows.EditControls.UICheckBox
      Me.cboItemCom = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboMedida = New Janus.Windows.EditControls.UIComboBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtCantidad = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.txtItemId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtComposicionId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
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
      CType(Me.cboItemCom, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 173)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtPrecioCos)
      Me.grpMain.Controls.Add(Me.lblPrecioCos)
      Me.grpMain.Controls.Add(Me.chkItemCom)
      Me.grpMain.Controls.Add(Me.cboItemCom)
      Me.grpMain.Controls.Add(Me.cboMedida)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.txtCantidad)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.txtItemId)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtComposicionId)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 164)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtPrecioCos
      '
      Me.txtPrecioCos.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPrecioCos.FormatString = "##,##0.000"
      Me.txtPrecioCos.Location = New System.Drawing.Point(324, 136)
      Me.txtPrecioCos.Name = "txtPrecioCos"
      Me.txtPrecioCos.Size = New System.Drawing.Size(112, 20)
      Me.txtPrecioCos.TabIndex = 7
      Me.txtPrecioCos.Text = "0,000"
      Me.txtPrecioCos.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPrecioCos.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPrecioCos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblPrecioCos
      '
      Me.lblPrecioCos.BackColor = System.Drawing.Color.Transparent
      Me.lblPrecioCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPrecioCos.Location = New System.Drawing.Point(268, 140)
      Me.lblPrecioCos.Name = "lblPrecioCos"
      Me.lblPrecioCos.Size = New System.Drawing.Size(56, 16)
      Me.lblPrecioCos.TabIndex = 245
      Me.lblPrecioCos.Text = "Costo"
      '
      'chkItemCom
      '
      Me.chkItemCom.BackColor = System.Drawing.Color.Transparent
      Me.chkItemCom.Checked = True
      Me.chkItemCom.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkItemCom.Location = New System.Drawing.Point(100, 92)
      Me.chkItemCom.Name = "chkItemCom"
      Me.chkItemCom.Size = New System.Drawing.Size(16, 16)
      Me.chkItemCom.TabIndex = 243
      Me.chkItemCom.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboItemCom
      '
      cboItemCom_DesignTimeLayout.LayoutString = resources.GetString("cboItemCom_DesignTimeLayout.LayoutString")
      Me.cboItemCom.DesignTimeLayout = cboItemCom_DesignTimeLayout
      Me.cboItemCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboItemCom.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboItemCom.Location = New System.Drawing.Point(116, 88)
      Me.cboItemCom.Name = "cboItemCom"
      Me.cboItemCom.SelectedIndex = -1
      Me.cboItemCom.SelectedItem = Nothing
      Me.cboItemCom.Size = New System.Drawing.Size(320, 20)
      Me.cboItemCom.TabIndex = 4
      Me.cboItemCom.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboItemCom.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboMedida
      '
      Me.cboMedida.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMedida.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.Location = New System.Drawing.Point(116, 112)
      Me.cboMedida.Name = "cboMedida"
      Me.cboMedida.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMedida.Size = New System.Drawing.Size(124, 20)
      Me.cboMedida.TabIndex = 5
      Me.cboMedida.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(8, 116)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 242
      Me.Label3.Text = "Medida"
      '
      'txtCantidad
      '
      Me.txtCantidad.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCantidad.FormatString = "##,##0.000"
      Me.txtCantidad.Location = New System.Drawing.Point(116, 136)
      Me.txtCantidad.Name = "txtCantidad"
      Me.txtCantidad.Size = New System.Drawing.Size(124, 20)
      Me.txtCantidad.TabIndex = 6
      Me.txtCantidad.Text = "0,000"
      Me.txtCantidad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCantidad.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCantidad.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 140)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 177
      Me.Label4.Text = "Cantidad"
      '
      'txtItemId
      '
      Me.txtItemId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemId.Location = New System.Drawing.Point(116, 64)
      Me.txtItemId.Name = "txtItemId"
      Me.txtItemId.ReadOnly = True
      Me.txtItemId.Size = New System.Drawing.Size(320, 20)
      Me.txtItemId.TabIndex = 3
      Me.txtItemId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 92)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(88, 16)
      Me.Label2.TabIndex = 175
      Me.Label2.Text = "Composición"
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 68)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 173
      Me.Label1.Text = "Ítem"
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(116, 40)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(320, 20)
      Me.txtEmpresaId.TabIndex = 2
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtComposicionId
      '
      Me.txtComposicionId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtComposicionId.Location = New System.Drawing.Point(116, 16)
      Me.txtComposicionId.Name = "txtComposicionId"
      Me.txtComposicionId.ReadOnly = True
      Me.txtComposicionId.Size = New System.Drawing.Size(124, 20)
      Me.txtComposicionId.TabIndex = 1
      Me.txtComposicionId.TabStop = False
      Me.txtComposicionId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtComposicionId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      'frmComposicionEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 201)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmComposicionEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Composicion Edit"
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
      CType(Me.cboItemCom, System.ComponentModel.ISupportInitialize).EndInit()
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
               mlngID = moComposicion.ComposicionId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmComposicionEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmComposicionEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()
      Call viewComponent()

      If Not mboolAdding Then
         Call FormShow()
         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta Composición"
         Else
            Me.Text = "Editar Composición"
         End If
      Else
         Me.Text = "Nueva Composición"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub viewComponent()
      lblPrecioCos.Visible = False
      txtPrecioCos.Visible = False
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moComposicion
         txtComposicionId.Text = ToStr(.ComposicionId)
         Call txtEmpresaIdLoad(.EmpresaId)
         Call txtItemIdLoad(.ItemId)
         ''cboItemCom.SelectedIndex = ListFindItem(cboItemCom, .ItemIdCom)
         ''Call cboItemCom_LostFocus(cboItemCom, Nothing)

         cboItemCom.Value = ListFindItem(cboItemCom, .ItemIdCom)
         cboItemCom.Tag = ToStr(cboItemCom.Text)

         ''Call ItemParametro(.ItemId)
         Call ItemParametro(.ItemIdCom)
         Call cboMedidaLoad()

         cboMedida.SelectedIndex = ListFindItem(cboMedida, .MedidaId)
         txtCantidad.Text = ToDecStr(.Cantidad)
         txtPrecioCos.Text = ToDecStr(.PrecioCos)

         If mlngTipoItemId = clsTipoItem.SERVICIO Then
            lblPrecioCos.Visible = True
            txtPrecioCos.Visible = True
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moComposicion
         txtComposicionId.Text = String.Empty
         Call txtEmpresaIdLoad(.EmpresaId)
         Call txtItemIdLoad(.ItemId)
         cboItemCom.SelectedIndex = -1
         cboMedida.SelectedIndex = -1
         txtCantidad.Text = String.Empty
         txtPrecioCos.Text = String.Empty

      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtComposicionId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      txtItemId.ReadOnly = True
      cboItemCom.ReadOnly = True
      cboMedida.ReadOnly = True
      txtCantidad.ReadOnly = True
      txtPrecioCos.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moComposicion
         If Not mboolAdding Then
            .ComposicionId = ToLong(txtComposicionId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .ItemId = ToLong(txtItemId.Tag)
         .ItemIdCom = ListPosition(cboItemCom)
         .MedidaId = ListPosition(cboMedida, cboMedida.SelectedIndex)
         .Cantidad = ToDecimal(txtCantidad.Text)
         .PrecioCos = ToDecimal(txtPrecioCos.Text)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboItemCom.Select()
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

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If mlngTipoItemId = clsTipoItem.SERVICIO Then
         If moComposicion.PrecioCos = 0 Then
            strMsg &= "Precio de Costo Inválido"
            Throw New Exception(strMsg)
            Return False
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moComposicion.Insert() Then
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

         If moComposicion.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub ItemParametro(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngTipoItemId = 0
         mlngTipoCosteoId = 0
         mlngMedidaId = 0
         mlngMedidaIdEqui = 0
         mdecMedidaCantEqui = 0
         mlngMonedaIdCos = 0
         mdecCantidadMin = 0
         mdecCantidadMax = 0
         mboolControlLote = False
         mboolControlSerie = False

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngTipoItemId = .TipoItemId
               mlngTipoCosteoId = .TipoCosteoId
               mlngMedidaId = .MedidaId
               mlngMedidaIdEqui = .MedidaIdEqui
               mdecMedidaCantEqui = .MedidaCantEqui
               mlngMonedaIdCos = .MonedaIdCos
               mdecCantidadMin = .CantidadMin
               mdecCantidadMax = .CantidadMax
               mboolControlLote = ToBoolean(.ControlLote)
               mboolControlSerie = ToBoolean(.ControlSerie)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      txtCantidad.FormatString = DecimalMask()
      txtPrecioCos.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()
      Call cboItemLoad()
   End Sub

   Private Sub cboItemLoad()
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Dim oListItem As clsListItem

      cboItemCom.DropDownList.Columns.Clear()

      Try
         With oItem
            .SelectFilter = clsItem.SelectFilters.ListBox
            .WhereFilter = clsItem.WhereFilters.TipoItemIdNot

            If clsAppInfo.ItemCodShow Then
               .OrderByFilter = clsItem.OrderByFilters.ItemCod
            Else
               .OrderByFilter = clsItem.OrderByFilters.ItemDes
            End If

            .EmpresaId = moComposicion.EmpresaId
            .ItemId = moComposicion.ItemIdCom
            .EstadoId = 1
            .TipoItemId = 3 'No Inventario


            If .Open() Then
               With cboItemCom
                  .DropDownList.Columns.Add("ItemId")
                  .DropDownList.Columns("ItemId").DataMember = "ItemId"
                  .DropDownList.Columns("ItemId").Visible = False

                  .DropDownList.Columns.Add("ItemCod")
                  .DropDownList.Columns("ItemCod").Caption = "Código"
                  .DropDownList.Columns("ItemCod").DataMember = "ItemCod"
                  .DropDownList.Columns("ItemCod").Width = 100

                  .DropDownList.Columns.Add("ItemDes")
                  .DropDownList.Columns("ItemDes").Caption = "Descripción"
                  .DropDownList.Columns("ItemDes").DataMember = "ItemDes"
                  .DropDownList.Columns("ItemDes").Width = 205

                  .DataMember = oItem.TableName
                  .DataSource = oItem.DataSet

                  If clsAppInfo.ItemCodShow Then
                     .ValueMember = "ItemId"
                     .DisplayMember = "ItemCod"
                     chkItemCom.Checked = False
                  Else
                     .ValueMember = "ItemId"
                     .DisplayMember = "ItemDes"
                     chkItemCom.Checked = True
                  End If
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()
         oListItem = Nothing

      End Try
   End Sub

   Private Sub cboMedidaLoad()
      Dim oMedida As New clsMedida(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMedida.Items.Clear()

      Try
         With oMedida
            .SelectFilter = clsMedida.SelectFilters.ListBox
            .WhereFilter = clsMedida.WhereFilters.MedidaItem
            .OrderByFilter = clsMedida.OrderByFilters.MedidaDes
            .EmpresaId = moComposicion.EmpresaId
            .MedidaId = mlngMedidaId
            .ConcurrencyId = mlngMedidaIdEqui

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.MedidaId, .MedidaDes)

                  cboMedida.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMedida.Dispose()
         oItem = Nothing

      End Try
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

   Private Sub txtItemIdLoad(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               txtItemId.Tag = .ItemId
               txtItemId.Text = ToStr(.ItemDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub cboItemCom_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItemCom.LostFocus
      If cboItemCom.Tag <> cboItemCom.Text Then
         cboItemCom.Tag = cboItemCom.Text

         Dim lngItemId As Long = ListPosition(cboItemCom)
         txtPrecioCos.Text = "0.0"

         If lngItemId <> 0 Then
            Call ItemParametro(lngItemId)
            Call cboMedidaLoad()
            cboMedida.Tag = ""
            cboMedida.SelectedIndex = ListFindItem(cboMedida, mlngMedidaId)

            If mlngTipoItemId = clsTipoItem.SERVICIO Then
               lblPrecioCos.Visible = True
               txtPrecioCos.Visible = True
            Else
               lblPrecioCos.Visible = False
               txtPrecioCos.Visible = False
            End If

         Else
            cboMedida.Items.Clear()
            cboMedida.Text = ""
         End If
      End If
   End Sub

   Private Sub cboItemCom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F2 Then
            Dim frm As New frmItemFind

            Try
               With frm
                  .EmpresaId = moComposicion.EmpresaId
                  ''.AlmacenId = moComposicion.AlmacenId
                  ''.ClienteId = moComposicion.ClienteId
                  .ShowDialog()

                  If .Changed Then
                     Call cboItemLoad()
                     cboItemCom.SelectedIndex = ListFindItem(cboItemCom, frm.ID)
                  End If

                  frm.Dispose()
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

         End If
      End If

   End Sub

   Private Sub chkItemCom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemCom.CheckedChanged
      If chkItemCom.Checked Then
         cboItemCom.DisplayMember = "ItemDes"
      Else
         cboItemCom.DisplayMember = "ItemCod"
      End If
   End Sub

   Private Sub frmComposicionEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moComposicion.ComposicionId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmComposicionEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moComposicion.Dispose()
      Call ClearMemory()
   End Sub

End Class
