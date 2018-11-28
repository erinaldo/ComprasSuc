Public Class frmDevCompraSeleccion
   Inherits System.Windows.Forms.Form

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAnticipo As Boolean
   Private mboolChanged As Boolean

   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents optAnticipo As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optEfectivo As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton

   Private milsList As ImageList

   Property Anticipo() As Boolean
      Get
         Return mboolAnticipo
      End Get

      Set(ByVal Value As Boolean)
         mboolAnticipo = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
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
   Friend WithEvents btnAceptar As Janus.Windows.EditControls.UIButton
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevCompraSeleccion))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.btnCancelar = New Janus.Windows.EditControls.UIButton
      Me.optAnticipo = New Janus.Windows.EditControls.UIRadioButton
      Me.optEfectivo = New Janus.Windows.EditControls.UIRadioButton
      Me.Label2 = New System.Windows.Forms.Label
      Me.btnAceptar = New Janus.Windows.EditControls.UIButton
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.SuspendLayout()
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 0)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(353, 179)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.btnCancelar)
      Me.grpMain.Controls.Add(Me.optAnticipo)
      Me.grpMain.Controls.Add(Me.optEfectivo)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.btnAceptar)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(324, 168)
      Me.grpMain.TabIndex = 159
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'btnCancelar
      '
      Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCancelar.Location = New System.Drawing.Point(180, 132)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(76, 20)
      Me.btnCancelar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnCancelar.TabIndex = 186
      Me.btnCancelar.Text = "Cancelar"
      Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optAnticipo
      '
      Me.optAnticipo.BackColor = System.Drawing.Color.Transparent
      Me.optAnticipo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optAnticipo.Checked = True
      Me.optAnticipo.CheckedValue = False
      Me.optAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optAnticipo.Location = New System.Drawing.Point(68, 84)
      Me.optAnticipo.Name = "optAnticipo"
      Me.optAnticipo.Size = New System.Drawing.Size(168, 24)
      Me.optAnticipo.TabIndex = 185
      Me.optAnticipo.TabStop = True
      Me.optAnticipo.Text = "Generar Anticipo"
      '
      'optEfectivo
      '
      Me.optEfectivo.BackColor = System.Drawing.Color.Transparent
      Me.optEfectivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optEfectivo.Checked = True
      Me.optEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optEfectivo.Location = New System.Drawing.Point(68, 56)
      Me.optEfectivo.Name = "optEfectivo"
      Me.optEfectivo.Size = New System.Drawing.Size(168, 24)
      Me.optEfectivo.TabIndex = 184
      Me.optEfectivo.TabStop = True
      Me.optEfectivo.Text = "Devolver Efectivo"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(36, 20)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(276, 20)
      Me.Label2.TabIndex = 183
      Me.Label2.Text = "¿ Cómo desea realizar la Devolución ?"
      '
      'btnAceptar
      '
      Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAceptar.Location = New System.Drawing.Point(80, 132)
      Me.btnAceptar.Name = "btnAceptar"
      Me.btnAceptar.Size = New System.Drawing.Size(76, 20)
      Me.btnAceptar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnAceptar.TabIndex = 2
      Me.btnAceptar.Text = "Aceptar"
      Me.btnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'frmDevCompraSeleccion
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(353, 179)
      Me.ControlBox = False
      Me.Controls.Add(Me.bcgMain)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmDevCompraSeleccion"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Forma de Devolución"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub frmDevVentaSeleccion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmDevVentaSeleccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      AddHandler Me.KeyDown, AddressOf Me.frmDevVentaSeleccion_KeyDown

      mboolLoading = True

      Call FormInit()
      ''Call ComboLoad()

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub SeleccionarFormaDevolucion()
      If FormCheck() Then
         mboolAnticipo = optAnticipo.Checked
         mboolChanged = True
         Me.Close()
      End If
   End Sub

   Private Function FormCheck()
      Dim boolValid As Integer
      boolValid = True

      ''If ListPosition(cboSucursal, cboSucursal.SelectedIndex) = 0 Then
      ''   MessageBox.Show("Seleccione una Sucursal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      ''   cboSucursal.Select()
      ''   boolValid = False
      ''End If

      FormCheck = boolValid
   End Function

   ''Public Function FindSucursal()
   ''   Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)

   ''   Try

   ''      With oSucursal
   ''         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)

   ''         If .FindByPK Then
   ''            mstrSucursalDes = .SucursalDes
   ''            FindSucursal = True

   ''         Else
   ''            MessageBox.Show("Seleccione una Sucursal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   ''            FindSucursal = False
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oSucursal.Dispose()
   ''   End Try
   ''End Function

   ''Private Sub ComboLoad()
   ''   Call cboSucursalLoad()
   ''End Sub

   ''Private Sub cboSucursalLoad()
   ''   Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)
   ''   Dim oItem As clsListItem

   ''   cboSucursal.Items.Clear()

   ''   Try
   ''      With oSucursal
   ''         .SelectFilter = clsSucursal.SelectFilters.ListBox
   ''         .WhereFilter = clsSucursal.WhereFilters.Grid
   ''         .OrderByFilter = clsSucursal.OrderByFilters.SucursalDes
   ''         .EmpresaId = clsAppInfo.EmpresaId

   ''         If .Open() Then
   ''            Do While .Read()
   ''               oItem = New clsListItem(.SucursalId, .SucursalDes)

   ''               cboSucursal.Items.Add(oItem)
   ''               .MoveNext()
   ''            Loop
   ''         End If
   ''      End With

   ''   Catch exp As Exception
   ''      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   ''   Finally
   ''      oSucursal.Dispose()
   ''      oItem = Nothing

   ''   End Try
   ''End Sub

   Private Sub FormInit()
      Call FormCenter(Me)
   End Sub

   Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
      Call SeleccionarFormaDevolucion()
   End Sub

   Private Sub frmDevVentaSeleccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            e.Handled = True
            Call SeleccionarFormaDevolucion()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            e.Handled = True
            End

         ElseIf (e.Alt) And (e.KeyValue = Keys.F4) Then
            e.Handled = True
         End If
      End If
   End Sub

   Private Sub frmDevVentaSeleccion_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

   Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub
End Class
