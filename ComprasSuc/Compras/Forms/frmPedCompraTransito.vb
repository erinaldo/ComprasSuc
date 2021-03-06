Public Class frmPedCompraTransito
   Inherits System.Windows.Forms.Form

   Private moItem As clsItem
   Private moLista As New Queue
   Private moListaAlmacen As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMedidaId As Long
   Private mlngProveedorId As Long
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String

   Private mboolSinSaldo As Boolean
   Private mstrConsultAlmacen As String

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mboolChanged As Boolean
   Private mboolSelected As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Private mlngID As Long

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property GestionId() As Long
      Get
         Return mlngGestionId
      End Get

      Set(ByVal Value As Long)
         mlngGestionId = Value
      End Set
   End Property

   Property MedidaId() As Long
      Get
         Return mlngMedidaId
      End Get

      Set(ByVal Value As Long)
         mlngMedidaId = Value
      End Set
   End Property

   Property ProveedorId() As Long
      Get
         Return mlngProveedorId
      End Get

      Set(ByVal Value As Long)
         mlngProveedorId = Value
      End Set
   End Property

   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
      End Set
   End Property

   Property IntervaloFecha() As Boolean
      Get
         Return mboolIntervaloFecha
      End Get

      Set(ByVal Value As Boolean)
         mboolIntervaloFecha = Value
      End Set
   End Property

   Property FechaIni() As String
      Get
         Return mstrFechaIni
      End Get

      Set(ByVal Value As String)
         mstrFechaIni = Value
      End Set
   End Property

   Property FechaFin() As String
      Get
         Return mstrFechaFin
      End Get

      Set(ByVal Value As String)
         mstrFechaFin = Value
      End Set
   End Property

   Property SinSaldo() As Boolean
      Get
         Return mboolSinSaldo
      End Get

      Set(ByVal Value As Boolean)
         mboolSinSaldo = Value
      End Set
   End Property

   Property Lista() As Queue
      Get
         Return moLista
      End Get

      Set(ByVal Value As Queue)
         moLista = Value
      End Set
   End Property

   Property ListaAlmacen() As Queue
      Get
         Return moListaAlmacen
      End Get

      Set(ByVal Value As Queue)
         moListaAlmacen = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   ReadOnly Property Selected() As Boolean
      Get
         Return mboolSelected
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

#Region " C�digo generado por el Dise�ador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Dise�ador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

   'Requerido por el Dise�ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Dise�ador de Windows Forms. 
   'No lo modifique con el editor de c�digo.
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedCompraTransito))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 370)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 370)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 9
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
      ExplorerBarGroup1.ContainerHeight = 371
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 403)
      Me.ebrMain.TabIndex = 2
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("aea013d3-db27-46fd-b9c2-6b48dddfb8f8")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(241, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'ViewAll1
      '
      Me.ViewAll1.Key = "ViewAll"
      Me.ViewAll1.Name = "ViewAll1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Book
      '
      Me.Book.ImageIndex = 6
      Me.Book.Key = "Book"
      Me.Book.Name = "Book"
      Me.Book.Text = "Libro Mayor"
      '
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 3
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
      '
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
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
      'frmPedCompraTransito
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmPedCompraTransito"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Pedidos de Compra en tr�nsito por Almac�n"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
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
            'Call frmVentaEditLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPedCompraTransito_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPedCompraTransito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      mboolSelected = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad()
      Dim oRow As DataRow
      Dim decTotal As Decimal
      Dim decSaldo As Decimal

      Try
         Call moDataSetInit()

         With moItem

            mstrConsultAlmacen = getAlmacenConsulta()
            For Each lngItemId As Long In moLista

               If TieneMovimiento(lngItemId) Then

                  oRow = moDataTable.NewRow
                  decTotal = 0

                  .ItemId = lngItemId
                  If .FindByPK Then

                     oRow("ItemId") = .ItemId
                     oRow("ItemCod") = .ItemCod
                     oRow("ItemDes") = .ItemDes

                     If mlngMedidaId = 1 Then
                        oRow("MedidaDes") = MedidaDesFind(.MedidaId)

                     ElseIf mlngMedidaId = 2 Then
                        oRow("MedidaDes") = MedidaDesFind(.MedidaIdEqui)
                     End If

                     For Each lngAlmacenId As Long In moListaAlmacen

                        If Not mboolIntervaloFecha Then
                           decSaldo = ItemCantidadPendActual(lngItemId, lngAlmacenId)
                           decTotal += decSaldo

                        Else
                           decSaldo = ItemCantidadPendFecha(lngItemId, lngAlmacenId)
                           decTotal += decSaldo

                        End If

                        oRow("AlmacenDes" & lngAlmacenId) = decSaldo

                     Next

                     oRow("CantidadTotal") = decTotal

                     ''If mboolSinSaldo Then
                     ''   moDataTable.Rows.Add(oRow)

                     ''ElseIf decTotal > 0 Then
                     moDataTable.Rows.Add(oRow)

                     ''End If

                  End If
               End If

            Next


            grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moItem.TableName)

      moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))

      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("MonedaDes", Type.GetType("System.String"))

      For Each lngAlmacenId As Long In moListaAlmacen
         moDataTable.Columns.Add("AlmacenId" & lngAlmacenId, Type.GetType("System.Int32"))
         moDataTable.Columns.Add("AlmacenDes" & lngAlmacenId, Type.GetType("System.Decimal"))
      Next

      moDataTable.Columns.Add("CantidadTotal", Type.GetType("System.Decimal"))

   End Sub

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
   End Function

   Private Function MedidaDesFind(ByVal lngMedidaId As Long) As String
      Dim oMedida As New clsMedida(clsAppInfo.ConnectString)

      MedidaDesFind = ""

      Try
         With oMedida
            .MedidaId = lngMedidaId

            If .FindByPK Then
               MedidaDesFind = ToStr(.MedidaDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMedida.Dispose()

      End Try
   End Function

   Private Function getAlmacenConsulta() As String

      Dim lngCant As Long


      getAlmacenConsulta = " ( "
      For Each lngAlmacenId As Long In moListaAlmacen

         lngCant += 1

         If moListaAlmacen.Count > lngCant Then
            getAlmacenConsulta = getAlmacenConsulta & " comPedCompraDet.AlmacenId = " & ToStr(lngAlmacenId) & " OR "
         Else
            getAlmacenConsulta = getAlmacenConsulta & " comPedCompraDet.AlmacenId = " & ToStr(lngAlmacenId) & " )"
         End If

      Next

   End Function

   Private Function ItemCantidadPendActual(ByVal lngItemId As Long, ByVal lngAlmacenId As Long) As Decimal
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim decCantidad As Decimal = 0
      Dim decCantidadEnt As Decimal = 0

      ItemCantidadPendActual = 0


      Try
         With oPedCompraDet
            .SelectFilter = clsPedCompraDet.SelectFilters.All
            .WhereFilter = clsPedCompraDet.WhereFilters.EntregaPend
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Open() Then
               Do While .Read()

                  If mlngMedidaId = 1 Then 'Medida Minima del Reporte
                     If .MedidaId = moItem.MedidaId Then
                        decCantidad = decCantidad + .Cantidad
                        decCantidadEnt = decCantidadEnt + .CantidadEnt

                     ElseIf .MedidaId = moItem.MedidaIdEqui Then
                        decCantidad = decCantidad + ToDecimal(.Cantidad * moItem.MedidaCantEqui)
                        decCantidadEnt = decCantidadEnt + ToDecimal(.CantidadEnt * moItem.MedidaCantEqui)
                     End If

                  ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
                     If .MedidaId = moItem.MedidaIdEqui Then
                        decCantidad = decCantidad + .Cantidad
                        decCantidadEnt = decCantidadEnt + .CantidadEnt

                     ElseIf .MedidaId = moItem.MedidaId Then
                        decCantidad = decCantidad + ToDecimal(.Cantidad / moItem.MedidaCantEqui)
                        decCantidadEnt = decCantidadEnt + ToDecimal(.CantidadEnt / moItem.MedidaCantEqui)
                     End If
                  End If

                  .MoveNext()
               Loop
            End If

            ItemCantidadPendActual = decCantidad - decCantidadEnt
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompraDet.Dispose()

      End Try
   End Function

   Private Function ItemCantidadPendFecha(ByVal lngItemId As Long, ByVal lngAlmacenId As Long) As Decimal
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)
      Dim decCantidad As Decimal = 0
      Dim decCantidadEnt As Decimal = 0

      ItemCantidadPendFecha = 0

      Try
         With oPedCompraDet
            .SelectFilter = clsPedCompraDet.SelectFilters.All
            .WhereFilter = clsPedCompraDet.WhereFilters.EntregaPendFecha
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .AlmacenId = lngAlmacenId
            .SucursalId = mlngSucursalId
            .ItemId = lngItemId
            .FechaEnt = mstrFechaIni
            .LastUpdateDate = mstrFechaFin

            If .Open() Then
               Do While .Read()

                  If mlngMedidaId = 1 Then 'Medida Minima del Reporte
                     If .MedidaId = moItem.MedidaId Then
                        decCantidad = decCantidad + .Cantidad
                        decCantidadEnt = decCantidadEnt + .CantidadEnt

                     ElseIf .MedidaId = moItem.MedidaIdEqui Then
                        decCantidad = decCantidad + ToDecimal(.Cantidad * moItem.MedidaCantEqui)
                        decCantidadEnt = decCantidadEnt + ToDecimal(.CantidadEnt * moItem.MedidaCantEqui)
                     End If

                  ElseIf mlngMedidaId = 2 Then 'Medida Equivalente del Reporte
                     If .MedidaId = moItem.MedidaIdEqui Then
                        decCantidad = decCantidad + .Cantidad
                        decCantidadEnt = decCantidadEnt + .CantidadEnt

                     ElseIf .MedidaId = moItem.MedidaId Then
                        decCantidad = decCantidad + ToDecimal(.Cantidad / moItem.MedidaCantEqui)
                        decCantidadEnt = decCantidadEnt + ToDecimal(.CantidadEnt / moItem.MedidaCantEqui)
                     End If
                  End If

                  .MoveNext()
               Loop
            End If

            ItemCantidadPendFecha = decCantidad - decCantidadEnt
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompraDet.Dispose()

      End Try
   End Function

   Private Function TieneMovimiento(ByVal lngItemId As Long) As Boolean
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)

      TieneMovimiento = False

      Try
         With oPedCompraDet
            .SelectFilter = clsPedCompraDet.SelectFilters.All

            If mboolIntervaloFecha Then
               .WhereFilter = clsPedCompraDet.WhereFilters.EntregaPendFecha
               .FechaEnt = mstrFechaIni
               .LastUpdateDate = mstrFechaFin
            Else
               .WhereFilter = clsPedCompraDet.WhereFilters.EntregaPend
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .ProveedorId = mlngProveedorId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .PedCompraDetDes = mstrConsultAlmacen
            .ItemId = lngItemId

            If .Find Then
               TieneMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompraDet.Dispose()

      End Try
   End Function

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Function GetDataView(ByVal oDataTableOrg As DataTable) As System.Data.DataView
      ''If grdMain.RootTable.FilterApplied Is Nothing Then
      ''   Return oDataTableOrg.DefaultView

      ''Else
      Dim oDataTable As DataTable
      Dim oRow As DataRow
      Dim decOtros As Decimal = 0

      oDataTable = oDataTableOrg.Clone

      For Each oRowMain In grdMain.GetRows()
         oRow = oDataTable.NewRow

         For i = 0 To oRowMain.Cells.Count - 1
            oRow(i) = oRowMain.Cells(i).Value
         Next

         oDataTable.Rows.Add(oRow)
      Next

      Return oDataTable.DefaultView
      ''End If
   End Function

   Private Sub PrintReport()
      Dim rpt As New rptPedCompraTransito
      Dim lngCant As Long
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)
      Dim oListaAlmacen As New Queue

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moItem.TableName))

      rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
      rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)

      rpt.lblTitle.Text = "Pedidos de compra en tr�nsito por Almac�n"
      rpt.Document.Name = "Pedidos de compra  tr�nsito por Almac�n"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      For Each lngAlmacenId As Long In moListaAlmacen
         lngCant += 1

         oAlmacen.AlmacenId = lngAlmacenId
         If oAlmacen.FindByPK() Then

            If lngCant = 1 Then
               rpt.lblAlmacen1.Text = oAlmacen.AlmacenDes
               rpt.txtAlmacen1.DataField = "AlmacenDes" & lngAlmacenId

            ElseIf lngCant = 2 Then
               rpt.lblAlmacen2.Text = oAlmacen.AlmacenDes
               rpt.txtAlmacen2.DataField = "AlmacenDes" & lngAlmacenId

            ElseIf lngCant = 3 Then
               rpt.lblAlmacen3.Text = oAlmacen.AlmacenDes
               rpt.txtAlmacen3.DataField = "AlmacenDes" & lngAlmacenId

            ElseIf lngCant = 4 Then
               rpt.lblAlmacen4.Text = oAlmacen.AlmacenDes
               rpt.txtAlmacen4.DataField = "AlmacenDes" & lngAlmacenId
               oListaAlmacen.Enqueue("AlmacenDes" & lngAlmacenId)

            ElseIf lngCant >= 5 Then
               rpt.lblAlmacen4.Text = "OTROS"
               oListaAlmacen.Enqueue("AlmacenDes" & lngAlmacenId)
               ''Exit For

            End If
         End If

      Next

      oAlmacen.Dispose()
      rpt.ListaAlmacen = oListaAlmacen

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As frmReportPreview
      frm = New frmReportPreview(rpt.Document)
      frm.Show()


   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("ItemPrecioId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moItem = New clsItem(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)
      With grdMain
         ebrMain.Groups(0).Text = "�tem por Almac�n"

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "C�digo"
         .RootTable.Columns("ItemCod").Width = 100
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "�tem"
         .RootTable.Columns("ItemDes").Width = 200
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 100
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaDes").Visible = False
         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center


         For Each lngAlmacenId As Long In moListaAlmacen

            oAlmacen.AlmacenId = lngAlmacenId
            If oAlmacen.FindByPK() Then

               .RootTable.Columns("AlmacenId" & lngAlmacenId).Visible = False

               .RootTable.Columns("AlmacenDes" & lngAlmacenId).Caption = ToStr(oAlmacen.AlmacenDes)
               .RootTable.Columns("AlmacenDes" & lngAlmacenId).FormatString = DecimalMask()
               .RootTable.Columns("AlmacenDes" & lngAlmacenId).Width = 100
               .RootTable.Columns("AlmacenDes" & lngAlmacenId).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("AlmacenDes" & lngAlmacenId).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            End If

         Next
         oAlmacen.Dispose()

         .RootTable.Columns("CantidadTotal").Caption = "TOTAL"
         .RootTable.Columns("CantidadTotal").FormatString = DecimalMask()
         .RootTable.Columns("CantidadTotal").Width = 100
         .RootTable.Columns("CantidadTotal").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("CantidadTotal").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center


      End With
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmPedCompraTransito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPedCompraTransito_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moItem.Dispose()
      Call ClearMemory()
   End Sub

End Class
