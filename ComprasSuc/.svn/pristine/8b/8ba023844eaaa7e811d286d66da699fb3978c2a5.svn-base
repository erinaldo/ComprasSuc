Imports System.Data
Imports System.Data.OleDb

Public Class clsAnticipoDet
   Implements IDisposable

   Private mlngAnticipoDetId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngAnticipoId As Long
   Private mlngProveedorId As Long
   Private mlngTipoCompraId As Long
   Private mlngDocumentoId As Long
   Private mstrFecha As String
   Private mstrAnticipoDetDes As String
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mdecMonto As Decimal
   Private mlngTipoCompId As Long
   Private mlngCompNro As Long
   Private mlngPlanId As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   Private moConnection As OleDbConnection
   Private moDataAdapter As OleDbDataAdapter
   Private moDataSet As DataSet
   Private mintRow As Integer
   Private mintRowsCount As Integer

   Private mstrConnectionString As String
   Private mstrTableName As String
   Private mstrClassName As String
   Private mstrSQL As String

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property AnticipoDetId() As Long
      Get
         Return mlngAnticipoDetId
      End Get

      Set(ByVal Value As Long)
         mlngAnticipoDetId = Value
      End Set
   End Property

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

   Property AnticipoId() As Long
      Get
         Return mlngAnticipoId
      End Get

      Set(ByVal Value As Long)
         mlngAnticipoId = Value
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

   Property TipoCompraId() As Long
      Get
         Return mlngTipoCompraId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCompraId = Value
      End Set
   End Property

   Property DocumentoId() As Long
      Get
         Return mlngDocumentoId
      End Get

      Set(ByVal Value As Long)
         mlngDocumentoId = Value
      End Set
   End Property

   Property Fecha() As String
      Get
         Return mstrFecha
      End Get

      Set(ByVal Value As String)
         mstrFecha = Value
      End Set
   End Property

   Property AnticipoDetDes() As String
      Get
         Return mstrAnticipoDetDes
      End Get

      Set(ByVal Value As String)
         mstrAnticipoDetDes = Value
      End Set
   End Property

   Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngMonedaId = Value
      End Set
   End Property

   Property TipoCambio() As Decimal
      Get
         Return mdecTipoCambio
      End Get

      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

   Property Monto() As Decimal
      Get
         Return mdecMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecMonto = Value
      End Set
   End Property

   Property TipoCompId() As Long
      Get
         Return mlngTipoCompId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCompId = Value
      End Set
   End Property

   Property CompNro() As Long
      Get
         Return mlngCompNro
      End Get

      Set(ByVal Value As Long)
         mlngCompNro = Value
      End Set
   End Property

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
      End Set
   End Property

   Property EstadoId() As Long
      Get
         Return mlngEstadoId
      End Get

      Set(ByVal Value As Long)
         mlngEstadoId = Value
      End Set
   End Property

   '******************************************************
   ' Private Data To Concurrency Table Definition
   '******************************************************
   Property LastUpdateId() As String
      Get
         Return mstrLastUpdateId
      End Get

      Set(ByVal Value As String)
         mstrLastUpdateId = Value
      End Set
   End Property

   Property LastUpdateDate() As String
      Get
         Return mstrLastUpdateDate
      End Get

      Set(ByVal Value As String)
         mstrLastUpdateDate = Value
      End Set
   End Property

   Property ConcurrencyId() As Integer
      Get
         Return mintConcurrencyId
      End Get

      Set(ByVal Value As Integer)
         mintConcurrencyId = Value
      End Set
   End Property

   Property ConnectionString() As String
      Get
         Return mstrConnectionString
      End Get

      Set(ByVal Value As String)
         mstrConnectionString = Value
      End Set
   End Property

   Property DataSet() As DataSet
      Get
         Return moDataSet
      End Get

      Set(ByVal Value As DataSet)
         moDataSet = Value
      End Set
   End Property

   ReadOnly Property TableName() As String
      Get
         Return mstrTableName
      End Get
   End Property

   ReadOnly Property ClassName() As String
      Get
         Return mstrClassName
      End Get
   End Property

   ReadOnly Property SQL() As String
      Get
         Return mstrSQL
      End Get
   End Property

   '******************************************************
   '* The following enumerations will change for each
   '* data access class
   '******************************************************
   Public Enum SelectFilters As Byte
      All = 0
      ListBox = 1
      Grid = 2
      Report = 3
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      DocumentoId = 6
      AnticipoId = 7
      DOCUMENTO_FECHA = 8
      CompraId = 9

   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      AnticipoDetId = 1
      Grid = 3
      Report = 4
      AnticipoDetDes = 5
      Fecha = 6
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      DocumentoId = 1
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
   End Enum

   Public Enum RowCountFilters As Byte
      All = 0
   End Enum

   '*********************************************************
   '* The following filters will change for each
   '* data access class
   '*********************************************************
   Private mintSelectFilter As SelectFilters
   Private mintWhereFilter As WhereFilters
   Private mintOrderByFilter As OrderByFilters
   Private mintInsertFilter As InsertFilters
   Private mintUpdateFilter As UpdateFilters
   Private mintDeleteFilter As DeleteFilters
   Private mintRowCountFilter As RowCountFilters

   Property SelectFilter() As SelectFilters
      Get
         Return mintSelectFilter
      End Get

      Set(ByVal Value As SelectFilters)
         mintSelectFilter = Value
      End Set
   End Property

   Property WhereFilter() As WhereFilters
      Get
         Return mintWhereFilter
      End Get

      Set(ByVal Value As WhereFilters)
         mintWhereFilter = Value
      End Set
   End Property

   Property OrderByFilter() As OrderByFilters
      Get
         Return mintOrderByFilter
      End Get

      Set(ByVal Value As OrderByFilters)
         mintOrderByFilter = Value
      End Set
   End Property

   Property InsertFilter() As InsertFilters
      Get
         Return mintInsertFilter
      End Get

      Set(ByVal Value As InsertFilters)
         mintInsertFilter = Value
      End Set
   End Property

   Property UpdateFilter() As UpdateFilters
      Get
         Return mintUpdateFilter
      End Get

      Set(ByVal Value As UpdateFilters)
         mintUpdateFilter = Value
      End Set
   End Property

   Property DeleteFilter() As DeleteFilters
      Get
         Return mintDeleteFilter
      End Get

      Set(ByVal Value As DeleteFilters)
         mintDeleteFilter = Value
      End Set
   End Property

   Property RowCountFilter() As RowCountFilters
      Get
         Return mintRowCountFilter
      End Get

      Set(ByVal Value As RowCountFilters)
         mintRowCountFilter = Value
      End Set
   End Property

   '************************************************************
   '* Method Name  : New()
   '* Syntax       : Constructor
   '* Parameters   : None
   '*
   '* Description  : This event is called when the object is created.
   '* It can be used to initialize private data variables.
   '*
   '************************************************************
   Public Sub New()
      mstrTableName = "comAnticipoDet"
      mstrClassName = "clsAnticipoDet"

      moConnection = New OleDbConnection

      Call PropertyInit()
      Call FilterInit()
   End Sub

   Public Sub New(ByVal ConnectString As String)
      Me.New()

      mstrConnectionString = ConnectString
   End Sub

   Public Sub New(ByVal ConnectString As String, ByVal bytSelectFilter As SelectFilters)
      Me.New()

      mstrConnectionString = ConnectString
      mintSelectFilter = bytSelectFilter
   End Sub

   Public Sub New(ByVal ConnectString As String, _
                  ByVal bytSelectFilter As SelectFilters, _
                  ByVal bytWhereFilter As WhereFilters)
      Me.New()

      mstrConnectionString = ConnectString
      mintSelectFilter = bytSelectFilter
      mintWhereFilter = bytWhereFilter
   End Sub

   Public Sub New(ByVal ConnectString As String, _
                  ByVal bytSelectFilter As SelectFilters, _
                  ByVal bytWhereFilter As WhereFilters, _
                  ByVal bytOrderByFilter As OrderByFilters)
      Me.New()

      mstrConnectionString = ConnectString
      mintSelectFilter = bytSelectFilter
      mintWhereFilter = bytWhereFilter
      mintOrderByFilter = bytOrderByFilter
   End Sub

   Public Sub PropertyInit()
      mlngAnticipoDetId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngAnticipoId = 0
      mlngProveedorId = 0
      mlngTipoCompraId = 0
      mlngDocumentoId = 0
      mstrFecha = ""
      mstrAnticipoDetDes = ""
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mdecMonto = 0
      mlngTipoCompId = 0
      mlngCompNro = 0
      mlngPlanId = 0
      mlngEstadoId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    comAnticipoDet.AnticipoDetId,  "
            strSQL &= "    comAnticipoDet.EmpresaId,  "
            strSQL &= "    comAnticipoDet.GestionId,  "
            strSQL &= "    comAnticipoDet.AnticipoId,  "
            strSQL &= "    comAnticipoDet.ProveedorId,  "
            strSQL &= "    comAnticipoDet.TipoCompraId,  "
            strSQL &= "    comAnticipoDet.DocumentoId,  "
            strSQL &= "    comAnticipoDet.Fecha,  "
            strSQL &= "    comAnticipoDet.AnticipoDetDes,  "
            strSQL &= "    comAnticipoDet.MonedaId,  "
            strSQL &= "    comAnticipoDet.TipoCambio,  "
            strSQL &= "    comAnticipoDet.Monto,  "
            strSQL &= "    comAnticipoDet.TipoCompId,  "
            strSQL &= "    comAnticipoDet.CompNro,  "
            strSQL &= "    comAnticipoDet.PlanId,  "
            strSQL &= "    comAnticipoDet.EstadoId,  "
            strSQL &= "    comAnticipoDet.sLastUpdate_id,  "
            strSQL &= "    comAnticipoDet.dtLastUpdate_dt,  "
            strSQL &= "    comAnticipoDet.iConcurrency_id  "
            strSQL &= " FROM comAnticipoDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comAnticipoDet.AnticipoDetId  "
            strSQL &= " FROM comAnticipoDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    comAnticipoDet.AnticipoDetId,  "
            strSQL &= "    comAnticipoDet.AnticipoId,  "
            strSQL &= "    comAnticipoDet.ProveedorId,  "
            strSQL &= "    comTipoCompra.TipoCompraId,  "
            strSQL &= "    comTipoCompra.TipoCompraDes,  "
            strSQL &= "    comAnticipoDet.DocumentoId,  "
            strSQL &= "    comAnticipoDet.Fecha,  "
            strSQL &= "    comAnticipoDet.AnticipoDetDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comAnticipoDet.TipoCambio,  "
            strSQL &= "    comAnticipoDet.Monto,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    comAnticipoDet.CompNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comAnticipoDet, comTipoCompra, tblMoneda, tblTipoComp, tblEstado  "

         Case SelectFilters.Report

      End Select

      strSQL &= WhereFilterGet()

      strSQL &= OrderByFilterGet()

      mstrSQL = strSQL

      Return strSQL
   End Function

   Private Function WhereFilterGet() As String
      Dim strSQL As String

      Select Case mintWhereFilter
         Case WhereFilters.PrimaryKey
            strSQL = " WHERE  comAnticipoDet.AnticipoDetId = " & NumberToField(mlngAnticipoDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comAnticipoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipoDet.AnticipoId = " & NumberToField(mlngAnticipoId)
            strSQL &= " AND  comAnticipoDet.TipoCompraId = comTipoCompra.TipoCompraId "
            strSQL &= " AND  comAnticipoDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comAnticipoDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comAnticipoDet.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comAnticipoDet.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report

         Case WhereFilters.DocumentoId
            strSQL = " WHERE  comAnticipoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipoDet.TipoCompraId = " & NumberToField(mlngTipoCompraId)
            strSQL &= " AND  comAnticipoDet.DocumentoId = " & NumberToField(mlngDocumentoId)

         Case WhereFilters.AnticipoId
            strSQL = " WHERE  comAnticipoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipoDet.AnticipoId = " & NumberToField(mlngAnticipoId)
            If mlngEstadoId <> 0 Then
               strSQL &= " AND  ( comAnticipoDet.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  comAnticipoDet.EstadoId = 0 )" ''Esto es para las Devoluciones
            End If

         Case WhereFilters.DOCUMENTO_FECHA
            strSQL = " WHERE  comAnticipoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipoDet.TipoCompraId = " & NumberToField(mlngTipoCompraId)
            strSQL &= " AND  comAnticipoDet.DocumentoId = " & NumberToField(mlngDocumentoId)
            strSQL &= " AND  comAnticipoDet.Fecha = " & DateToField(mstrFecha)

         Case WhereFilters.CompraId
            strSQL = " WHERE  comAnticipoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipoDet.AnticipoId = " & NumberToField(mlngAnticipoId)
            strSQL &= " AND  comAnticipoDet.TipoCompraId = " & NumberToField(mlngTipoCompraId)
            strSQL &= " AND  comAnticipoDet.AnticipoDetDes = " & StringToField(mstrAnticipoDetDes)


      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.AnticipoDetId
            strSQL = " ORDER BY comAnticipoDet.AnticipoDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comAnticipoDet.AnticipoDetId "

         Case OrderByFilters.AnticipoDetDes
            strSQL = " ORDER BY comAnticipoDet.AnticipoDetDes "

         Case OrderByFilters.Report

         Case OrderByFilters.Fecha
            strSQL = " ORDER BY comAnticipoDet.Fecha, comAnticipoDet.AnticipoDetId "

      End Select

      Return strSQL
   End Function

   Private Function RowCountSQL() As String
      Dim strSQL As String

      Select Case mintRowCountFilter
         Case RowCountFilters.All
            strSQL = "SELECT Count(*) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO comAnticipoDet ("
            strSQL &= "AnticipoDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "AnticipoId, "
            strSQL &= "ProveedorId, "
            strSQL &= "TipoCompraId, "
            strSQL &= "DocumentoId, "
            strSQL &= "Fecha, "
            strSQL &= "AnticipoDetDes, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "Monto, "
            strSQL &= "TipoCompId, "
            strSQL &= "CompNro, "
            strSQL &= "PlanId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngAnticipoDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngAnticipoId) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngTipoCompraId) & ", "
            strSQL &= NumberToField(mlngDocumentoId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= StringToField(mstrAnticipoDetDes) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= DecimalToField(mdecMonto) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            strSQL &= NumberToField(mlngCompNro) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comAnticipoDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "AnticipoId = " & NumberToField(mlngAnticipoId) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "TipoCompraId = " & NumberToField(mlngTipoCompraId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AnticipoDetDes = " & StringToField(mstrAnticipoDetDes) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "Monto = " & DecimalToField(mdecMonto) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "CompNro = " & NumberToField(mlngCompNro) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " AnticipoDetId = " & NumberToField(mlngAnticipoDetId) & " "

         Case UpdateFilters.DocumentoId
            strSQL = "UPDATE comAnticipoDet SET "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " AnticipoId = " & NumberToField(mlngAnticipoId) & " "
            strSQL &= " TipoCompraId = " & NumberToField(mlngTipoCompraId) & " "

      End Select

      Return strSQL
   End Function

   Private Function DeleteSQL() As String
      Dim strSQL As String

      Select Case mintDeleteFilter
         Case DeleteFilters.All
            strSQL = "DELETE FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Sub Retrieve(ByVal oDataRow As DataRow)
      Try
         Call PropertyInit()

         Select Case mintSelectFilter
            Case SelectFilters.All
               mlngAnticipoDetId = ToLong(oDataRow("AnticipoDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngAnticipoId = ToLong(oDataRow("AnticipoId"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngTipoCompraId = ToLong(oDataRow("TipoCompraId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mstrAnticipoDetDes = ToStr(oDataRow("AnticipoDetDes"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mdecMonto = ToDecimal(oDataRow("Monto"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               mlngCompNro = ToLong(oDataRow("CompNro"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngAnticipoDetId = ToLong(oDataRow("AnticipoDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngAnticipoDetId = TableIDGet(mstrTableName, "AnticipoDetId", moConnection)

         If mlngAnticipoDetId = -1 Then
            Throw New Exception("No se puede generar un identificador unico para esta tabla: " & mstrTableName)
         Else
            GetNewPrimaryKey = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Validate() As Boolean
      Dim strMsg As String = String.Empty

      If mlngEmpresaId = 0 Then
         strMsg &= "Empresa Inválida" & vbCrLf
      End If

      If mlngProveedorId = 0 Then
         strMsg &= "Proveedor Inválido" & vbCrLf
      End If

      If mlngTipoCompraId = 0 Then
         strMsg &= "Tipo Documento Inválido" & vbCrLf
      End If

      'If mlngDocumentoId = 0 Then
      '   strMsg &= "Número Documento Inválido" & vbCrLf
      'End If

      If mlngMonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If mdecTipoCambio <= 0 Then
         strMsg &= "Tipo Cambio Inválido" & vbCrLf
      End If

      'If mdecMonto <= 0 Then
      '   strMsg &= "Monto Inválido" & vbCrLf
      'End If

      'If mdecDebeUs <= 0 Then
      '   strMsg &= "Monto Pagado Inválido" & vbCrLf
      'End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         Validate = False
      Else
         Validate = True
      End If
   End Function

   Public Function NoDuplicates(ByVal boolReplace As Boolean) As Boolean
      Dim strSQL As String
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM comAnticipoDet "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comAnticipoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comAnticipoDet.GestionId = " & NumberToField(mlngGestionId)
         'Else
         '   strSQL &= " WHERE  comAnticipoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comAnticipoDet.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  comAnticipoDet.AnticipoDetId <> " & NumberToField(mlngAnticipoDetId)
         'End If

         If strSQL <> "" Then
            Call OpenConection()

            oCommand = New OleDbCommand
            oCommand.CommandText = strSQL
            oCommand.Connection = moConnection

            intRecordsAffected = oCommand.ExecuteScalar

            If intRecordsAffected = 0 Then
               NoDuplicates = True
            Else
               NoDuplicates = False
            End If
         Else
            NoDuplicates = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Open() As Boolean
      Try
         Open = False

         Call OpenConection()

         moDataSet = New DataSet

         moDataAdapter = New OleDbDataAdapter(SelectSQL, moConnection)

         moDataAdapter.Fill(moDataSet, mstrTableName)

         moDataAdapter.Dispose()

         mintRow = 0
         mintRowsCount = moDataSet.Tables(mstrTableName).Rows.Count()

         Open = True

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Read() As Boolean
      Dim oDataRow As Data.DataRow

      Read = False

      Try
         If mintRowsCount > 0 Then
            If mintRow <= mintRowsCount - 1 Then
               oDataRow = moDataSet.Tables(mstrTableName).Rows(mintRow)

               Call Retrieve(oDataRow)
               Read = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Find() As Boolean
      Find = False

      Try
         If Open() Then
            If Read() Then
               Find = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function FindByPK() As Boolean
      FindByPK = False

      Try
         mintSelectFilter = SelectFilters.All
         mintWhereFilter = WhereFilters.PrimaryKey
         mintOrderByFilter = OrderByFilters.None

         If Open() Then
            If Read() Then
               FindByPK = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Sub MoveNext()
      If mintRowsCount > 0 Then
         If mintRow < mintRowsCount Then
            mintRow += 1
         End If
      End If
   End Sub

   Public Sub MovePrevious()
      If mintRowsCount > 0 Then
         If mintRow > 0 Then
            mintRow -= 1
         End If
      End If
   End Sub

   Public Sub MoveFirst()
      If mintRowsCount > 0 Then
         mintRow = 0
      End If
   End Sub

   Public Sub MoveLast()
      If mintRowsCount > 0 Then
         mintRow = mintRowsCount - 1
      End If
   End Sub

   Public Function Insert() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Insert = False

      Try
         If Validate() Then
            If NoDuplicates(False) Then
               If GetNewPrimaryKey() Then
                  Call OpenConection()

                  oCommand = New OleDbCommand
                  oCommand.CommandText = InsertSQL()
                  oCommand.Connection = moConnection

                  intRecordsAffected = oCommand.ExecuteNonQuery()

                  If intRecordsAffected > 0 Then
                     Insert = True
                  End If
               End If
            Else
               Throw New Exception("Registro Duplicado")
               Return False
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Update() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Update = False

      Try
         If Validate() Then
            If NoDuplicates(True) Then
               Call OpenConection()

               oCommand = New OleDbCommand
               oCommand.CommandText = UpdateSQL()
               oCommand.Connection = moConnection

               intRecordsAffected = oCommand.ExecuteNonQuery()

               If intRecordsAffected > 0 Then
                  Update = True
               End If
            Else
               Throw New Exception("Registro Duplicado")
               Return False
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function UpdateOnly() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      UpdateOnly = False

      Try
            If NoDuplicates(True) Then
            Call OpenConection()

            oCommand = New OleDbCommand
            oCommand.CommandText = UpdateSQL()
            oCommand.Connection = moConnection

            intRecordsAffected = oCommand.ExecuteNonQuery()

            If intRecordsAffected > 0 Then
               UpdateOnly = True
            End If
         Else
            Throw New Exception("Registro Duplicado")
            Return False
         End If
       
      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Delete() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Delete = False

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = DeleteSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = oCommand.ExecuteNonQuery()

         If intRecordsAffected > 0 Then
            Delete = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function RowCount() As Integer
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowCountSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = CInt(oCommand.ExecuteScalar)

         Return intRecordsAffected

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Sub FilterInit()
      mintWhereFilter = 0
      mintOrderByFilter = 0
      mintSelectFilter = 0
      mintInsertFilter = 0
      mintUpdateFilter = 0
      mintDeleteFilter = 0
      mintRowCountFilter = 0
   End Sub

   Private Sub OpenConection()
      If moConnection.State = ConnectionState.Closed Then
         moConnection = New OleDbConnection(mstrConnectionString)
         moConnection.Open()
      End If
   End Sub

   Public Sub CloseConection()
      If moConnection.State = ConnectionState.Open Then
         moConnection.Close()
      End If
   End Sub

   Overridable Sub Dispose() Implements IDisposable.Dispose
      Call CloseConection()
   End Sub

End Class
