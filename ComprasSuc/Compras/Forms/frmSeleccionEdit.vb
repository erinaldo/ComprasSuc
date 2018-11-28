Public Class frmSeleccionEdit
   Inherits System.Windows.Forms.Form

   Private mlngTipoSel As Long
   Private mlngSeleccionId As Long
   Private mstrSeleccionDes As String
   Private moDataObject As Object
   Private mlngID As Long

   Public Const SEL_SUCURSAL_IMAGEN As Byte = 1
   Public Const SEL_EDIT_EXPORTACION As Byte = 2
   Public Const SEL_PRINT_FACTURA As Byte = 3
   Public Const SEL_HOJA_EXCEL As Byte = 4

   Private mlngTipoFind As Long
   Public Const FIND_SELECCIONID As Byte = 1
   Public Const FIND_LIKE_SELECCIONDES As Byte = 2

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean

   Private milsList As ImageList

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

   Property TipoSel() As Long
      Get
         Return mlngTipoSel
      End Get

      Set(ByVal Value As Long)
         mlngTipoSel = Value
      End Set
   End Property

   Property TipoFind() As Long
      Get
         Return mlngTipoFind
      End Get

      Set(ByVal Value As Long)
         mlngTipoFind = Value
      End Set
   End Property

   Property SeleccionId() As Long
      Get
         Return mlngSeleccionId
      End Get

      Set(ByVal Value As Long)
         mlngSeleccionId = Value
      End Set
   End Property

   Property SeleccionDes() As String
      Get
         Return mstrSeleccionDes
      End Get

      Set(ByVal Value As String)
         mstrSeleccionDes = Value
      End Set
   End Property

   Property DataObject() As Object
      Get
         Return moDataObject
      End Get

      Set(ByVal Value As Object)
         moDataObject = Value
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
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSeleccionDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents lblDescripcion As System.Windows.Forms.Label
   Friend WithEvents btnAceptar As Janus.Windows.EditControls.UIButton
   Friend WithEvents cboSeleccion As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionEdit))
        Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
        Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
        Me.txtSeleccionDes = New Janus.Windows.GridEX.EditControls.EditBox
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.cboSeleccion = New Janus.Windows.EditControls.UIComboBox
        Me.btnAceptar = New Janus.Windows.EditControls.UIButton
        Me.lblDescripcion = New System.Windows.Forms.Label
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
        Me.bcgMain.Size = New System.Drawing.Size(364, 129)
        Me.bcgMain.TabIndex = 161
        Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'grpMain
        '
        Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grpMain.Controls.Add(Me.txtSeleccionDes)
        Me.grpMain.Controls.Add(Me.btnCancelar)
        Me.grpMain.Controls.Add(Me.lblTitulo)
        Me.grpMain.Controls.Add(Me.cboSeleccion)
        Me.grpMain.Controls.Add(Me.btnAceptar)
        Me.grpMain.Controls.Add(Me.lblDescripcion)
        Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpMain.Location = New System.Drawing.Point(5, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(352, 124)
        Me.grpMain.TabIndex = 159
        Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'txtSeleccionDes
        '
        Me.txtSeleccionDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeleccionDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtSeleccionDes.Location = New System.Drawing.Point(84, 52)
        Me.txtSeleccionDes.MaxLength = 255
        Me.txtSeleccionDes.Multiline = True
        Me.txtSeleccionDes.Name = "txtSeleccionDes"
        Me.txtSeleccionDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSeleccionDes.Size = New System.Drawing.Size(256, 32)
        Me.txtSeleccionDes.TabIndex = 188
        Me.txtSeleccionDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtSeleccionDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(192, 92)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 20)
        Me.btnCancelar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelar.TabIndex = 187
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(332, 24)
        Me.lblTitulo.TabIndex = 183
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboSeleccion
        '
        Me.cboSeleccion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboSeleccion.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboSeleccion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboSeleccion.Location = New System.Drawing.Point(84, 52)
        Me.cboSeleccion.Name = "cboSeleccion"
        Me.cboSeleccion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboSeleccion.Size = New System.Drawing.Size(232, 20)
        Me.cboSeleccion.TabIndex = 0
        Me.cboSeleccion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(100, 92)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(76, 20)
        Me.btnAceptar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(8, 56)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(76, 16)
        Me.lblDescripcion.TabIndex = 182
        Me.lblDescripcion.Text = "Descripción"
        '
        'frmSeleccionEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(364, 129)
        Me.ControlBox = False
        Me.Controls.Add(Me.bcgMain)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeleccionEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imagen de Impresión"
        CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bcgMain.ResumeLayout(False)
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

   Private Sub frmSeleccionEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmSeleccionEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      AddHandler Me.KeyDown, AddressOf Me.frmSeleccionEdit_KeyDown

      mboolLoading = True

      Call FormInit()

      Call Formshow()

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

    Private Sub FormInit()

        Call FormCenter(Me)
    End Sub

   Private Sub Formshow()

      If mlngTipoSel = SEL_SUCURSAL_IMAGEN Then
         Call FormSucursalImaShow()

      ElseIf mlngTipoSel = SEL_EDIT_EXPORTACION Then
         Call FormExportacionEditShow()

      ElseIf mlngTipoSel = SEL_PRINT_FACTURA Then
         Call FormPrintFacturaSelShow()

      ElseIf mlngTipoSel = SEL_HOJA_EXCEL Then
         Call FormHojaExcelSelShow()


      End If
   End Sub

   Private Sub Datasave()

      If mlngTipoSel = SEL_SUCURSAL_IMAGEN Then
         Call SeleccionarSucursal()

      ElseIf mlngTipoSel = SEL_EDIT_EXPORTACION Then
         Call SeleccionarExportacionEdit()

      ElseIf mlngTipoSel = SEL_PRINT_FACTURA Then
         Call SeleccionarPrintFacturaSel()

      ElseIf mlngTipoSel = SEL_HOJA_EXCEL Then
         Call SeleccionarHojaExcelSel()

      End If
   End Sub

   Private Function FormCheck()
      Dim boolValid As Integer
      boolValid = True

      If ListPosition(cboSeleccion, cboSeleccion.SelectedIndex) = 0 Then
         MessageBox.Show("Seleccione una Sucursal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         cboSeleccion.Select()
         boolValid = False
      End If

      FormCheck = boolValid
   End Function

   Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
      Call Datasave()
   End Sub

   Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub

#Region "Sucursal Imagen"

   Private Sub FormSucursalImaShow()
      cboSucursalLoad()

      Me.Text = "Imagen de Impresión"

      lblTitulo.Text = "Seleccione la Sucursal para la imagen del reporte"
      lblDescripcion.Text = "Sucursal"

      txtSeleccionDes.Visible = False
      cboSeleccion.Visible = True

   End Sub

   Private Sub cboSucursalLoad()
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSeleccion.Items.Clear()

      Try
         With oSucursal
            .SelectFilter = clsSucursal.SelectFilters.ListBox
            '.WhereFilter = clsSucursal.WhereFilters.Grid
            .WhereFilter = clsSucursal.WhereFilters.EmpresaId
            .OrderByFilter = clsSucursal.OrderByFilters.SucursalDes
            .EmpresaId = clsAppInfo.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.SucursalId, .SucursalDes)

                  cboSeleccion.Items.Add(oItem)
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

   Private Sub SeleccionarSucursal()
      If FormCheckSucursalIma() Then
         mstrSeleccionDes = cboSeleccion.Text
         mboolChanged = True
         Me.Close()
      End If
   End Sub

   Private Function FormCheckSucursalIma()
      Dim boolValid As Integer
      boolValid = True

      If ListPosition(cboSeleccion, cboSeleccion.SelectedIndex) = 0 Then
         MessageBox.Show("Seleccione una Sucursal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         cboSeleccion.Select()
         boolValid = False
      End If

      FormCheckSucursalIma = boolValid
   End Function

   Public Function FindSucursal()
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)

      Try

         With oSucursal
            .SucursalId = ListPosition(cboSeleccion, cboSeleccion.SelectedIndex)

            If .FindByPK Then
               mstrSeleccionDes = .SucursalDes
               FindSucursal = True

            Else
               MessageBox.Show("Seleccione una Sucursal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               FindSucursal = False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()
      End Try
   End Function

#End Region

#Region "Edicion Datos Exportación"

   Private Sub FormExportacionEditShow()

      Me.Text = "Editar Descripción de Exportación"

      lblTitulo.Text = "Editar Descripción de Exportación"
      lblDescripcion.Text = "Descripción"

      txtSeleccionDes.Text = mstrSeleccionDes
      txtSeleccionDes.MaxLength = 100

      txtSeleccionDes.Visible = True
      cboSeleccion.Visible = False

   End Sub

   Private Sub SeleccionarExportacionEdit()
      If FormCheckExportacionEdit() Then
         mstrSeleccionDes = txtSeleccionDes.Text
         mboolChanged = True
         Me.Close()
      End If
   End Sub

   Private Function FormCheckExportacionEdit()
      Dim boolValid As Boolean = True

      If txtSeleccionDes.Text.Trim = String.Empty Then
         MessageBox.Show("Descripción Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         txtSeleccionDes.Select()
         boolValid = False
      End If

      FormCheckExportacionEdit = boolValid
   End Function

#End Region

#Region "Seleccion Impresion Factura"

   Private Sub FormPrintFacturaSelShow()

      Me.Text = "Formato de Impresión de Factura"

      lblTitulo.Text = "Seleccione el Formato de Impresión"
      lblDescripcion.Text = "Formato" ''"Formato Impresión"

      Call cboTipoFormImpLoad()

      cboSeleccion.SelectedIndex = ListFindItem(cboSeleccion, mlngSeleccionId)

      txtSeleccionDes.Visible = False
      cboSeleccion.Visible = True

   End Sub

   Private Sub cboTipoFormImpLoad()
      Dim oTipoFormImp As New clsTipoFormImp(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSeleccion.Items.Clear()
      cboSeleccion.Text = ""

      Try
            'With oTipoFormImp
            '   .SelectFilter = clsTipoFormImp.SelectFilters.ListBox

            '   If mlngTipoFind = FIND_LIKE_SELECCIONDES Then
            '      .WhereFilter = clsTipoFormImp.WhereFilters.LIKE_ImpDes_TipoDocId
            '      .AppId = clsAppInfo.AppId
            '      .TipoDocumentoId = clsTipoVenta.FACTURA
            '      .TipoFormImpDes = mstrSeleccionDes

            '   ElseIf mlngTipoFind = FIND_SELECCIONID Then
            '      .WhereFilter = clsTipoFormImp.WhereFilters.AppId_TipoDocId
            '      .AppId = clsAppInfo.AppId
            '      .TipoDocumentoId = clsTipoVenta.FACTURA
            '      .TipoImpresionId = mlngSeleccionId

            '   End If

            '   .OrderByFilter = clsTipoFormImp.OrderByFilters.TipoFormImpDes

            '   If .Open() Then
            '      Do While .Read()
            '         oItem = New clsListItem(.TipoFormImpId, .TipoFormImpDes)

            '         cboSeleccion.Items.Add(oItem)
            '         .MoveNext()
            '      Loop
            '   End If
            'End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoFormImp.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub SeleccionarPrintFacturaSel()
      If FormCheckPrintFacturaSel() Then
         mlngID = ListPosition(cboSeleccion, cboSeleccion.SelectedIndex)
         mstrSeleccionDes = cboSeleccion.Text
         mboolChanged = True
         Me.Close()
      End If
   End Sub

   Private Function FormCheckPrintFacturaSel()
      Dim boolValid As Boolean = True

      If ListPosition(cboSeleccion, cboSeleccion.SelectedIndex) = 0 Then
         MessageBox.Show("Seleccione el Formato de Impresión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         cboSeleccion.Select()
         boolValid = False
      End If

      FormCheckPrintFacturaSel = boolValid
   End Function

#End Region

#Region "Seleccion Hoja Excel"

   Private Sub FormHojaExcelSelShow()

      Me.Text = "Hojas de Excel"

      lblTitulo.Text = "Seleccione la Hoja para la Importación del Excel"
      lblDescripcion.Text = "Hoja" ''"Formato Impresión"

      Call cboHojaExcelLoad()

      cboSeleccion.Text = mstrSeleccionDes
      'cboSeleccion.SelectedIndex = ListFindItem(cboSeleccion, ListPosition(cboSeleccion, cboSeleccion.SelectedIndex))
      If cboSeleccion.SelectedIndex = -1 Then
         cboSeleccion.Text = ""
      End If

      txtSeleccionDes.Visible = False
      cboSeleccion.Visible = True

   End Sub

   Private Sub cboHojaExcelLoad()
      Dim oItem As clsListItem
      Dim lngCant As Long

      cboSeleccion.Items.Clear()
      cboSeleccion.Text = ""

      Try
         For Each oDato As String In moDataObject

            lngCant += 1

            oItem = New clsListItem(lngCant, ToStr(oDato))
            cboSeleccion.Items.Add(oItem)

         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem = Nothing

      End Try
   End Sub

   Private Sub SeleccionarHojaExcelSel()
      If FormCheckHojaExcelSel() Then
         mlngID = ListPosition(cboSeleccion, cboSeleccion.SelectedIndex)
         mstrSeleccionDes = cboSeleccion.Text
         mboolChanged = True
         Me.Close()
      End If
   End Sub

   Private Function FormCheckHojaExcelSel()
      Dim boolValid As Boolean = True

      If ListPosition(cboSeleccion, cboSeleccion.SelectedIndex) = 0 Then
         MessageBox.Show("Seleccione el nombre de la Hoja", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         cboSeleccion.Select()
         boolValid = False
      End If

      FormCheckHojaExcelSel = boolValid
   End Function

#End Region

   Private Sub frmSeleccionEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call Datasave()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
             Me.Close()

         ElseIf (e.Alt) And (e.KeyValue = Keys.F4) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmSeleccionEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

End Class
