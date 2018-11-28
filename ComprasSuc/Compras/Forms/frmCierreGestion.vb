Public Class frmCierreGestion
   Inherits System.Windows.Forms.Form

   Private moCredito As clsCredito
   Private moCreditoDet As clsCreditoDet

   Private mlngEmpresaId As Long
   Private mlngGestionIdNew As Long
   Private mlngGestionNew As Long

   Private mlngTipoItemId As Long
   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long
   Private mboolControlLote As Boolean
   Private mboolControlSerie As Boolean

   Private mstrFechaIni As String
   Private mdatFechaIni As Date
   Private mdatFechaFin As Date
   Private mlngCuotaNro As Long
   Private mdecMontoLiq As Decimal

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mlngID As Long

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

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
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
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
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents cboGestion As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCierreGestion))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboGestion = New Janus.Windows.EditControls.UIComboBox
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
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
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
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
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(262, 78)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboGestion)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(244, 68)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboGestion
      '
      Me.cboGestion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboGestion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.Location = New System.Drawing.Point(112, 16)
      Me.cboGestion.Name = "cboGestion"
      Me.cboGestion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboGestion.Size = New System.Drawing.Size(124, 20)
      Me.cboGestion.TabIndex = 1
      Me.cboGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(112, 40)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(124, 20)
      Me.txtTipoCambio.TabIndex = 2
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 20)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(100, 16)
      Me.Label3.TabIndex = 152
      Me.Label3.Text = "Gestión a  Cerrar"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 44)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(100, 16)
      Me.Label4.TabIndex = 151
      Me.Label4.Text = "Tipo de Cambio"
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
      Me.cdmMain.Id = New System.Guid("5033e457-dd60-4879-8e21-4c01e8889c3c")
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(144, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      Me.Save1.Text = "Cierre"
      Me.Save1.ToolTipText = "Cierre de Gestión"
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
      Me.TopRebar1.Size = New System.Drawing.Size(262, 28)
      '
      'frmCierreGestion
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(262, 106)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCierreGestion"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Cierre de Gestión"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
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
            If RealizarCierreGestion() Then
               MessageBox.Show("Cierre de Gestión se Realizado Exitosamente, Verifique los Sados Iniciales en la Nueva Gestión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCierreGestion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCierreGestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ComboLoad()
      Call FormShow()

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      cboGestion.SelectedIndex = ListFindItem(cboGestion, clsAppInfo.GestionId)
      Call txtTipoCambioFind(ToDate(Now.Date))
      mboolShow = False
   End Sub

   Private Function RealizarCierreGestion() As Boolean
      Dim lngGestionId As Long
      Dim strMensajeSuc As String
      Dim boolCierre As Boolean = True

      RealizarCierreGestion = False

      If ListPosition(cboGestion, cboGestion.SelectedIndex) <> 0 Then

         If ToDecimal(txtTipoCambio.Text) > 0 Then

            lngGestionId = ListPosition(cboGestion, cboGestion.SelectedIndex)
            mlngGestionIdNew = GestionIdNextFind(GestionFind(lngGestionId), mlngEmpresaId)

            If mlngGestionIdNew > 0 Then
               If CompraParaExits(mlngEmpresaId, mlngGestionIdNew, clsAppInfo.SucursalId) Then
                  If Not GestionMovimiento(mlngGestionIdNew, mlngEmpresaId) And (Not AnticipoGestionMov(mlngGestionIdNew, mlngEmpresaId)) Then

                     If clsAppInfo.SucursalApli Then
                        boolCierre = False
                        If SaldoIniCompraParaSucursalCheck(mlngEmpresaId, clsAppInfo.GestionId, mlngGestionIdNew, strMensajeSuc) Then
                           If AnticipoCompraParaSucursalCheck(mlngEmpresaId, clsAppInfo.GestionId, mlngGestionIdNew, strMensajeSuc) Then
                              boolCierre = True
                           Else
                              MessageBox.Show("No Existen Parámetros Para la Nueva Gestión de las Siguientes Sucursales" + vbCrLf + vbCrLf + strMensajeSuc, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                           End If
                        Else
                           MessageBox.Show("No Existen Parámetros Para la Nueva Gestión de las Siguientes Sucursales" + vbCrLf + vbCrLf + strMensajeSuc, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                     End If

                     If boolCierre Then
                        If MessageBox.Show("Este Proceso Cierra la Gestión Seleccionada e Inicializa una Nueva con los Saldos Actuales" + vbCrLf + vbCrLf + "¿Realmente quiere Cerrar la Gestión?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                           mlngGestionNew = GestionFind(mlngGestionIdNew)

                           RealizarCierreGestion = CierreGestion()
                        End If

                     End If
                  Else
                     MessageBox.Show("La Nueva Gestión ya Tiene Movimiento, Revise por Favor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("No Existen Parámetros Para la Nueva Gestión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("No Existe una Gestión Nueva o en Estado Abierto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Else
            MessageBox.Show("Tipo de Cambio Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Else
         MessageBox.Show("Debe Seleccionar la Gestión a Cerrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Function CierreGestion() As Boolean
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)
      Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)
      Dim lngCreditoId As Long
      Dim lngTipoCompraId As Long
      Dim lngSucursalId As Long
      Dim boolCierre As Boolean

      mstrFechaIni = GestionFechaIni(mlngGestionIdNew)

      With oProveedor
         .SelectFilter = clsProveedor.SelectFilters.All
         .WhereFilter = clsProveedor.WhereFilters.EmpresaId
         .OrderByFilter = clsProveedor.OrderByFilters.ProveedorDes
         .EmpresaId = mlngEmpresaId

         If .Open() Then
            Do While .Read()
               With oCredito
                  .SelectFilter = clsCredito.SelectFilters.All
                  .WhereFilter = clsCredito.WhereFilters.EstadoId
                  .OrderByFilter = clsCredito.OrderByFilters.CreditoId
                  .EmpresaId = mlngEmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .ProveedorId = oProveedor.ProveedorId
                  .EstadoId = 15 'Programado

                  If .Open() Then
                     Do While .Read()
                        moCredito = New clsCredito(clsAppInfo.ConnectString)
                        boolCierre = False

                        If clsAppInfo.SucursalApli Then
                           lngSucursalId = .SucursalId
                        Else
                           lngSucursalId = clsAppInfo.SucursalId
                        End If

                        If CreditoAdd(oCredito, mlngGestionIdNew, lngSucursalId, lngCreditoId) Then
                           With oCreditoDet
                              .SelectFilter = clsCreditoDet.SelectFilters.All
                              .WhereFilter = clsCreditoDet.WhereFilters.CreditoId
                              .CreditoId = oCredito.CreditoId

                              If .Open() Then
                                 Do While .Read()
                                    moCreditoDet = New clsCreditoDet(clsAppInfo.ConnectString)

                                    If CreditoDetAdd(oCreditoDet, mlngGestionIdNew, lngSucursalId, lngCreditoId) Then
                                       boolCierre = True
                                    End If

                                    .MoveNext()
                                 Loop
                              End If
                           End With

                           If boolCierre Then
                              lngTipoCompraId = 8
                              'If CBool(moCredito.SaldoIni) Then
                              '   lngTipoCompraId = 8
                              'Else
                              '   lngTipoCompraId = 6
                              'End If

                              If ProveedorMovAdd(mlngGestionIdNew, moCredito.ProveedorId, lngTipoCompraId, moCredito.CreditoId, moCredito.MonedaId, 2, moCredito.FechaIni, moCredito.MontoLiq - moCredito.MontoAmo, moCredito.TipoCambio, moCredito.CentroCostoId, moCredito.SucursalId, 2) Then
                                 CierreGestion = True
                              End If
                           End If
                        End If

                        .MoveNext()
                     Loop
                  End If
               End With

               .MoveNext()
            Loop
         End If
      End With

      If AnticipoNew(mlngGestionIdNew) Then
         CierreGestion = True
      End If
   End Function

   'Private Function CierreGestionOld() As Boolean
   '   Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)
   '   Dim oCredito As New clsCredito(clsAppInfo.ConnectString)
   '   Dim oCreditoDet As New clsCreditoDet(clsAppInfo.ConnectString)
   '   Dim lngCreditoId As Long
   '   Dim lngCreditoDetId As Long
   '   Dim oRow As DataRow

   '   mstrFechaIni = GestionFechaIni(mlngGestionIdNew)

   '   With oProveedor
   '      .SelectFilter = clsProveedor.SelectFilters.All
   '      .WhereFilter = clsProveedor.WhereFilters.EmpresaId
   '      .EmpresaId = mlngEmpresaId

   '      If .Open() Then
   '         Do While .Read()
   '            With oCredito
   '               .SelectFilter = clsCredito.SelectFilters.All
   '               .WhereFilter = clsCredito.WhereFilters.EstadoId
   '               .EmpresaId = mlngEmpresaId
   '               .GestionId = clsAppInfo.GestionId
   '               .ProveedorId = oProveedor.ProveedorId
   '               .EstadoId = 15 'Programado

   '               If .Open() Then
   '                  mlngCuotaNro = 0
   '                  mdatFechaFin = mdatFechaIni
   '                  mdecMontoLiq = 0

   '                  If .DataSet.Tables(.TableName).Rows.Count > 0 Then
   '                     moCredito = New clsCredito(clsAppInfo.ConnectString)
   '                     Call CreditoAdd(mlngGestionIdNew, oProveedor.ProveedorId, lngCreditoId, .InteresAnual)
   '                  End If

   '                  Do While .Read()
   '                     With oCreditoDet
   '                        .SelectFilter = clsCreditoDet.SelectFilters.All
   '                        .WhereFilter = clsCreditoDet.WhereFilters.EstadoId
   '                        .CreditoId = oCredito.CreditoId
   '                        .EstadoId = 15 'Programado

   '                        If .Open() Then
   '                           For Each oRow In .DataSet.Tables(.TableName).Rows
   '                              mlngCuotaNro += 1
   '                              moCreditoDet = New clsCreditoDet(clsAppInfo.ConnectString)
   '                              Call CreditoDetAdd(mlngGestionIdNew, lngCreditoId, oRow("Fecha"), mlngCuotaNro, oRow("MonedaId"), oRow("Capital") - oRow("CapitalAmo"))

   '                              If oRow("Fecha") > mdatFechaFin Then
   '                                 mdatFechaFin = oRow("Fecha")
   '                              End If
   '                           Next
   '                        End If
   '                     End With

   '                     .MoveNext()
   '                  Loop

   '                  If mlngCuotaNro > 0 Then
   '                     If CreditoUpdate() Then
   '                        If ProveedorMovAdd(mlngGestionIdNew, oProveedor.ProveedorId, 8, moCredito.CreditoId, moCredito.MonedaId, 2, moCredito.MontoLiq, 2) Then
   '                           CierreGestion = True
   '                        End If
   '                     End If
   '                  End If
   '               End If
   '            End With

   '            .MoveNext()
   '         Loop
   '      End If
   '   End With

   '   If AnticipoNew(mlngGestionIdNew) Then
   '      CierreGestion = True
   '   End If
   'End Function

   Private Function CreditoAdd(ByVal oCreditoOld As clsCredito, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByRef lngCreditoId As Long) As Boolean
      CreditoAdd = False

      Try
         With moCredito
            .EmpresaId = oCreditoOld.EmpresaId
            .GestionId = lngGestionId
            .CompraId = oCreditoOld.CompraId
            .TipoCreditoId = oCreditoOld.TipoCreditoId

            .CreditoNro = CompraNroNext(8, lngGestionId, lngSucursalId)
            'If CBool(oCreditoOld.SaldoIni) Then
            '   .CreditoNro = CompraNroNext(8, lngGestionId)
            'Else
            '   .CreditoNro = CompraNroNext(6, lngGestionId)
            'End If

            .FechaIni = ToDate(oCreditoOld.FechaIni)
            .FechaFin = ToDate(oCreditoOld.FechaFin)
            .ProveedorId = oCreditoOld.ProveedorId
            .FrecuenciaId = oCreditoOld.FrecuenciaId
            .FrecuenciaNro = oCreditoOld.FrecuenciaNro
            .MonedaId = oCreditoOld.MonedaId
            .TipoCambio = oCreditoOld.TipoCambio
            .MontoLiq = oCreditoOld.MontoLiq
            .MontoAmo = oCreditoOld.MontoAmo
            .CantidadCuota = oCreditoOld.CantidadCuota
            .MontoCuota = oCreditoOld.MontoCuota
            .InteresAnual = oCreditoOld.InteresAnual
            '.SaldoIni = oCreditoOld.SaldoIni
            .SaldoIni = 1
            .ConFac = oCreditoOld.ConFac  '0
            .SinFac = oCreditoOld.SinFac  '1
            .CentroCostoId = oCreditoOld.CentroCostoId
            .CreditoIdOrg = oCreditoOld.CreditoId ''Referencia del Credito del la Anterior Gestion
            .SucursalId = lngSucursalId
            .EstadoId = oCreditoOld.EstadoId

            If .Insert() Then
               lngCreditoId = .CreditoId
               CreditoAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function CreditoDetAdd(ByVal oCreditoDetOld As clsCreditoDet, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByVal lngCreditoId As Long) As Boolean
      CreditoDetAdd = False

      Try
         With moCreditoDet
            .EmpresaId = oCreditoDetOld.EmpresaId
            .GestionId = lngGestionId
            .CompraId = oCreditoDetOld.CompraId
            .TipoCreditoId = oCreditoDetOld.TipoCreditoId
            .CreditoId = lngCreditoId
            .Fecha = ToDate(oCreditoDetOld.Fecha)
            .ProveedorId = oCreditoDetOld.ProveedorId
            .MonedaId = oCreditoDetOld.MonedaId
            .TipoCambio = oCreditoDetOld.TipoCambio
            .CuotaNro = oCreditoDetOld.CuotaNro
            .Capital = oCreditoDetOld.Capital
            .Interes = oCreditoDetOld.Interes
            .Importe = oCreditoDetOld.Importe
            .CapitalAmo = oCreditoDetOld.CapitalAmo
            .InteresAmo = oCreditoDetOld.InteresAmo
            .FechaAmo = ToDate(oCreditoDetOld.FechaAmo)
            .InteresPen = oCreditoDetOld.InteresPen
            .CentroCostoId = oCreditoDetOld.CentroCostoId
            .SucursalId = lngSucursalId
            .EstadoId = oCreditoDetOld.EstadoId

            If .Insert() Then
               CreditoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function CreditoUpdate() As Boolean
      CreditoUpdate = False

      Try
         With moCredito
            .MontoLiq = mdecMontoLiq
            .CantidadCuota = mlngCuotaNro
            .FechaFin = ToDate(mdatFechaFin)

            If .Update Then
               CreditoUpdate = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function AnticipoNew(ByVal lngGestionId As Long) As Boolean
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim lngTipoCompraId As Long
      Dim decMonto As Decimal
      Dim lngCol As Long

      AnticipoNew = True

      Try
         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.All
            .WhereFilter = clsAnticipo.WhereFilters.EstadoId
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .EstadoId = 13 'Pendiente

            If .Open() Then
               Do While .Read()
                  If .TipoAnticipoId = 2 Then 'Anticipo

                     If clsAppInfo.SucursalApli Then
                        .SucursalId = .SucursalId
                     Else
                        .SucursalId = clsAppInfo.SucursalId
                     End If

                     .AnticipoNro = CompraNroNext(4, lngGestionId, .SucursalId)

                     .Fecha = mstrFechaIni
                     .PedCompraId = 0
                     .TipoCambio = ToDecimal(txtTipoCambio.Text)
                     .MontoAnt -= .MontoDes
                     .MontoDes = 0
                     .GestionId = lngGestionId
                     '.TipoCompId = 0
                     '.CompNro = 0
                     .PlanId = 0
                     .AnticipoIdOrg = .AnticipoId ''Anticipo de la Anterior Gestión
                     .CompId = 0

                     If .MontoAnt > 0 Then
                        If .Insert() Then
                           lngCol = 1
                           decMonto = .MontoAnt
                           lngTipoCompraId = 4

                           If ProveedorMovAdd(lngGestionId, .ProveedorId, lngTipoCompraId, .AnticipoId, .MonedaId, 2, mstrFechaIni, decMonto, .TipoCambio, .CentroCostoId, .SucursalId, lngCol) Then
                              AnticipoNew = True
                           End If
                        End If
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function ProveedorMovAdd(ByVal lngGestionId As Long, ByVal lngProveedorId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, ByVal lngMonedaId As Long, _
                                    ByVal lngTipoPagoId As Long, ByVal strFecha As String, ByVal decValor As Decimal, ByVal decTipoCambio As Decimal, ByVal lngCentroCostoId As Long, _
                                    ByVal lngSucursalId As Long, ByVal lngCol As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = mlngEmpresaId
            .GestionId = lngGestionId
            .ProveedorId = lngProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = strFecha
            .ProveedorMovDes = "Saldo Inicial al " + ToDateDMY(strFecha)
            .MonedaId = lngMonedaId
            .TipoCambio = decTipoCambio
            .CentroCostoId = lngCentroCostoId ' moPago.CentroCostoId 
            .SucursalId = lngSucursalId
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

            .TipoCompId = 0
            .CompNro = 0
            .PlanId = 0

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

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraNroNext = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = mlngEmpresaId
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

   Private Sub txtTipoCambioFind(ByVal strFecha As String)
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
               txtTipoCambio.Text = ""
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub

   Private Function GestionFind(ByVal lngGestionId As Long) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionFind = 0

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               GestionFind = ToLong(.Gestion)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function GestionIdNextFind(ByVal lngGestion As Long, ByVal lngEmpresaId As Long) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdNextFind = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.Gestion
            .EmpresaId = lngEmpresaId
            .Gestion = lngGestion + 1
            .EstadoId = 11

            If .Find Then
               GestionIdNextFind = ToLong(.GestionId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function CompraParaExits(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Boolean
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      CompraParaExits = False

      Try
         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            '.WhereFilter = clsCompraPara.WhereFilters.GestionId
            .WhereFilter = clsCompraPara.WhereFilters.SucursalId
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId
            .EstadoId = 11

            If .Find Then
               CompraParaExits = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Private Function GestionNew() As Boolean
      Dim frm As New frmGestionEdit
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionNew = False

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oGestion.EmpresaId = mlngEmpresaId

            .DataObject = oGestion
            .ShowDialog()

            If .Changed Then
               mlngGestionIdNew = frm.ID
               GestionNew = True

            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function GestionFechaIni(ByVal GestionId As Long) As String
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = GestionId

            If .FindByPK Then
               mdatFechaIni = .DataSet.Tables(.TableName).Rows(0).Item("FechaIni")
               GestionFechaIni = ToDate(.DataSet.Tables(.TableName).Rows(0).Item("FechaIni"))
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function GestionMovimiento(ByVal lngGestionId As Long, ByVal lngEmpresaId As Long) As Boolean
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)

      GestionMovimiento = False

      Try
         With oCredito
            .RowCountFilter = clsCredito.RowCountFilters.All
            .WhereFilter = clsCredito.WhereFilters.GestionMov
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .SaldoIni = 1

            If .Find Then
               GestionMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function AnticipoGestionMov(ByVal lngGestionId As Long, ByVal lngEmpresaId As Long) As Boolean
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

      AnticipoGestionMov = False

      Try
         With oAnticipo
            .RowCountFilter = clsAnticipo.RowCountFilters.All
            .WhereFilter = clsAnticipo.WhereFilters.GestionMov
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId

            If .Find Then
               AnticipoGestionMov = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Sub ComboLoad()
      Call cboGestionLoad()
   End Sub

   Private Sub cboGestionLoad()
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboGestion.Items.Clear()

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.EmpresaId
            .OrderByFilter = clsGestion.OrderByFilters.Gestion
            .EmpresaId = mlngEmpresaId
            .EstadoId = 11

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.GestionId, .Gestion)

                  cboGestion.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      txtTipoCambio.FormatString = DecimalMask()
   End Sub

#Region "Numeracion Sucursal"

   Public Function TieneCompraParaSucursalId(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngTipoCompraId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         TieneCompraParaSucursalId = 0

         With oCompraPara
            .RowCountFilter = clsCompraPara.RowCountFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .TipoCompraId = lngTipoCompraId
            .SucursalId = lngSucursalId

            TieneCompraParaSucursalId = .RowCount()

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "Miscellaneous", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Private Function SaldoIniCompraParaSucursalCheck(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngGestionIdNew As Long, ByRef strMensaje As String) As Boolean
      Dim oCredito As New clsCredito(clsAppInfo.ConnectString)
      Dim oCompraPara As clsCompraPara
      Dim lngSucursalId As Long
      strMensaje = ""

      SaldoIniCompraParaSucursalCheck = True

      Try

         With oCredito
            .SelectFilter = clsCredito.SelectFilters.SucursalDistinct
            .WhereFilter = clsCredito.WhereFilters.SucursalDistinct
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .EstadoId = 15

            If .Open Then

               oCompraPara = compraParaFind(lngEmpresaId, lngGestionIdNew, clsTipoCompra.SALDO_INICIAL)

               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  lngSucursalId = ToLong(oRow("SucursalId"))
                  If (lngSucursalId > 0) Then
                     With oCompraPara
                        If (oCompraPara Is Nothing) OrElse (.DataSet.Tables(.TableName).Select("SucursalId = " & lngSucursalId).Count = 0) Then
                           strMensaje &= "- " & SucursalDesFind(lngSucursalId) & vbCrLf
                        End If
                     End With
                  Else
                     strMensaje &= " Sucursal Inválido : " & lngSucursalId & vbCrLf
                  End If
               Next
            End If

            If strMensaje <> String.Empty Then
               SaldoIniCompraParaSucursalCheck = False
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         SaldoIniCompraParaSucursalCheck = False

      Finally
         oCredito.Dispose()
      End Try
   End Function

   Private Function AnticipoCompraParaSucursalCheck(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngGestionIdNew As Long, ByRef strMensaje As String) As Boolean
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim oCompraPara As clsCompraPara
      Dim lngSucursalId As Long
      strMensaje = ""

      AnticipoCompraParaSucursalCheck = True

      Try

         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.SucursalDistinct
            .WhereFilter = clsAnticipo.WhereFilters.SucursalDistinct
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .EstadoId = 13

            If .Open Then

               oCompraPara = compraParaFind(lngEmpresaId, lngGestionIdNew, clsTipoCompra.ANTICIPO)

               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  lngSucursalId = ToLong(oRow("SucursalId"))
                  If (lngSucursalId > 0) Then
                     With oCompraPara
                        If (oCompraPara Is Nothing) OrElse (.DataSet.Tables(.TableName).Select("SucursalId = " & lngSucursalId).Count = 0) Then
                           strMensaje &= "- " & SucursalDesFind(lngSucursalId) & vbCrLf
                        End If
                     End With
                  Else
                     strMensaje &= " Sucursal Inválido : " & lngSucursalId & vbCrLf
                  End If
               Next
            End If

            If strMensaje <> String.Empty Then
               AnticipoCompraParaSucursalCheck = False
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         AnticipoCompraParaSucursalCheck = False

      Finally
         oAnticipo.Dispose()
      End Try
   End Function

   Public Function CompraParaFind(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngTipoCompraId As Long) As clsCompraPara
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)
      compraParaFind = Nothing

      Try

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraIdOnly
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .TipoCompraId = lngTipoCompraId

            If .Find Then
               Return oCompraPara
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "Miscellaneous", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Private Function SucursalDesFind(ByVal lngSucursalId As Long) As String
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)

      SucursalDesFind = ""

      Try
         With oSucursal
            .SucursalId = lngSucursalId

            If .FindByPK Then
               SucursalDesFind = .SucursalDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()

      End Try
   End Function

#End Region

   Private Sub frmCierreGestion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If RealizarCierreGestion() Then
                  MessageBox.Show("El Cierre de Gestión se Realizo Exitosamente, Verifique los Sados Iniciales en la Nueva Gestión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCierreGestion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      Call ClearMemory()
   End Sub

End Class
