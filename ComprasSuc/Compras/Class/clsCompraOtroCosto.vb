Imports System.Data
Imports System.Data.OleDb

Public Class clsCompraOtroCosto
   Implements IDisposable

   Private mlngCompraOtroCostoId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngCompraId As Long
   Private mlngPlanOtroCostoId As Long
   Private mstrFecha As String
   Private mstrCompraOtroCostoDes As String
   Private mlngMonedaId As Long
   Private mdecMonto As Decimal
   Private mlngCompId As Long
   Private mlngPlanId As Long
   Private mlngFacturaId As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   Private mlngPlanAddId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngSucursalId As Long

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
   Property CompraOtroCostoId() As Long
      Get
         Return mlngCompraOtroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCompraOtroCostoId = Value
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

   Property CompraId() As Long
      Get
         Return mlngCompraId
      End Get

      Set(ByVal Value As Long)
         mlngCompraId = Value
      End Set
   End Property

   Property PlanOtroCostoId() As Long
      Get
         Return mlngPlanOtroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngPlanOtroCostoId = Value
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

   Property CompraOtroCostoDes() As String
      Get
         Return mstrCompraOtroCostoDes
      End Get

      Set(ByVal Value As String)
         mstrCompraOtroCostoDes = Value
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

   Property Monto() As Decimal
      Get
         Return mdecMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecMonto = Value
      End Set
   End Property

   Property CompId() As Long
      Get
         Return mlngCompId
      End Get

      Set(ByVal Value As Long)
         mlngCompId = Value
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

   Property FacturaId() As Long
      Get
         Return mlngFacturaId
      End Get

      Set(ByVal Value As Long)
         mlngFacturaId = Value
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

   Property PlanAddId() As Long
      Get
         Return mlngPlanAddId
      End Get

      Set(ByVal Value As Long)
         mlngPlanAddId = Value
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

   Property CentroCostoDetId() As Long
      Get
         Return mlngCentroCostoDetId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoDetId = Value
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
      AlmacenId = 6
      GestionId = 7
      CompraId = 8
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompraOtroCostoId = 1
      Grid = 3
      Report = 4
      CompraOtroCostoDes = 5
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
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
      mstrTableName = "comCompraOtroCosto"
      mstrClassName = "clsCompraOtroCosto"

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
      mlngCompraOtroCostoId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngCompraId = 0
      mlngPlanOtroCostoId = 0
      mstrFecha = ""
      mstrCompraOtroCostoDes = ""
      mlngMonedaId = 0
      mdecMonto = 0
      mlngCompId = 0
      mlngPlanId = 0
      mlngPlanAddId = 0
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
      mlngSucursalId = 0
      mlngFacturaId = 0
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
            strSQL &= "    comCompraOtroCosto.CompraOtroCostoId,  "
            strSQL &= "    comCompraOtroCosto.EmpresaId,  "
            strSQL &= "    comCompraOtroCosto.GestionId,  "
            strSQL &= "    comCompraOtroCosto.CompraId,  "
            strSQL &= "    comCompraOtroCosto.PlanOtroCostoId,  "
            strSQL &= "    comCompraOtroCosto.Fecha,  "
            strSQL &= "    comCompraOtroCosto.CompraOtroCostoDes,  "
            strSQL &= "    comCompraOtroCosto.MonedaId,  "
            strSQL &= "    comCompraOtroCosto.Monto,  "
            strSQL &= "    comCompraOtroCosto.CompId,  "
            strSQL &= "    comCompraOtroCosto.PlanId,  "
            strSQL &= "    comCompraOtroCosto.FacturaId,  "
            strSQL &= "    comCompraOtroCosto.EstadoId,  "
            strSQL &= "    comCompraOtroCosto.PlanAddId,  "
            strSQL &= "    comCompraOtroCosto.CentroCostoId,  "
            strSQL &= "    comCompraOtroCosto.CentroCostoDetId,  "
            strSQL &= "    comCompraOtroCosto.SucursalId,  "
            strSQL &= "    comCompraOtroCosto.sLastUpdate_id,  "
            strSQL &= "    comCompraOtroCosto.dtLastUpdate_dt,  "
            strSQL &= "    comCompraOtroCosto.iConcurrency_id  "
            strSQL &= " FROM comCompraOtroCosto "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comCompraOtroCosto.CompraOtroCostoId  "
            strSQL &= " FROM comCompraOtroCosto "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    comCompraOtroCosto.CompraOtroCostoId,  "
            strSQL &= "    comCompraOtroCosto.CompraId,  "
            strSQL &= "    comCompraOtroCosto.Fecha,  "
            strSQL &= "    comPlanOtroCosto.PlanOtroCostoId,  "
            strSQL &= "    comPlanOtroCosto.PlanOtroCostoDes,  "
            strSQL &= "    comPlanOtroCosto.PlanId As PlanIdOtroCosto,  "
            strSQL &= "    comCompraOtroCosto.CompraOtroCostoDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCompraOtroCosto.Monto,  "
            strSQL &= "    comCompraOtroCosto.CompId,  "
            strSQL &= "    comCompraOtroCosto.PlanId,  "
            strSQL &= "    comCompraOtroCosto.FacturaId,  "
            strSQL &= "    comCompraOtroCosto.PlanAddId,  "
            strSQL &= "    comCompraOtroCosto.CentroCostoId,  "
            strSQL &= "    comCompraOtroCosto.CentroCostoDetId,  "
            strSQL &= "    comCompraOtroCosto.SucursalId  "
            strSQL &= " FROM comCompraOtroCosto, comPlanOtroCosto, tblMoneda "

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
            strSQL = " WHERE  comCompraOtroCosto.CompraOtroCostoId = " & NumberToField(mlngCompraOtroCostoId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comCompraOtroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraOtroCosto.CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND  comCompraOtroCosto.PlanOtroCostoId = comPlanOtroCosto.PlanOtroCostoId "
            strSQL &= " AND  comCompraOtroCosto.MonedaId = tblMoneda.MonedaId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comCompraOtroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report

         Case WhereFilters.AlmacenId

         Case WhereFilters.GestionId
            strSQL = " WHERE  comCompraOtroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraOtroCosto.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.CompraId
            strSQL = " WHERE  comCompraOtroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraOtroCosto.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraOtroCosto.CompraId = " & NumberToField(mlngCompraId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompraOtroCostoId
            strSQL = " ORDER BY comCompraOtroCosto.CompraOtroCostoId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comCompraOtroCosto.CompraOtroCostoId "

         Case OrderByFilters.CompraOtroCostoDes
            strSQL = " ORDER BY comCompraOtroCosto.CompraOtroCostoDes "

         Case OrderByFilters.Report

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
            strSQL = "INSERT INTO comCompraOtroCosto ("
            strSQL &= "CompraOtroCostoId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "CompraId, "
            strSQL &= "PlanOtroCostoId, "
            strSQL &= "Fecha, "
            strSQL &= "CompraOtroCostoDes, "
            strSQL &= "MonedaId, "
            strSQL &= "Monto, "
            strSQL &= "CompId, "
            strSQL &= "PlanId, "
            strSQL &= "FacturaId, "
            strSQL &= "EstadoId, "
            strSQL &= "PlanAddId, "
            strSQL &= "CentroCostoId, "
            strSQL &= "CentroCostoDetId, "
            strSQL &= "SucursalId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompraOtroCostoId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= NumberToField(mlngPlanOtroCostoId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= StringToField(mstrCompraOtroCostoDes) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecMonto) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngFacturaId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= NumberToField(mlngPlanAddId) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comCompraOtroCosto SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "PlanOtroCostoId = " & NumberToField(mlngPlanOtroCostoId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "CompraOtroCostoDes = " & StringToField(mstrCompraOtroCostoDes) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "Monto = " & DecimalToField(mdecMonto) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "FacturaId = " & NumberToField(mlngFacturaId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= "PlanAddId = " & NumberToField(mlngPlanAddId) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompraOtroCostoId = " & NumberToField(mlngCompraOtroCostoId) & " "

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
               mlngCompraOtroCostoId = ToLong(oDataRow("CompraOtroCostoId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mlngPlanOtroCostoId = ToLong(oDataRow("PlanOtroCostoId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mstrCompraOtroCostoDes = ToStr(oDataRow("CompraOtroCostoDes"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecMonto = ToDecimal(oDataRow("Monto"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngFacturaId = ToLong(oDataRow("FacturaId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mlngPlanAddId = ToLong(oDataRow("PlanAddId"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngCentroCostoDetId = ToLong(oDataRow("CentroCostoDetId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompraOtroCostoId = ToLong(oDataRow("CompraOtroCostoId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompraOtroCostoId = TableIDGet(mstrTableName, "CompraOtroCostoId", moConnection)

         If mlngCompraOtroCostoId = -1 Then
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

      If mlngCompraId = 0 Then
         strMsg &= "CompraId Inválida" & vbCrLf
      End If

      If mlngPlanOtroCostoId = 0 Then
         strMsg &= "Grupo de Cuenta Inválido" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If mdecMonto <= 0 Then
         strMsg &= "Monto Inválido" & vbCrLf
      End If

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
         'strSQL &= " FROM comCompraOtroCosto "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comCompraOtroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCompraOtroCosto.GestionId = " & NumberToField(mlngGestionId)
         'Else
         '   strSQL &= " WHERE  comCompraOtroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCompraOtroCosto.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  comCompraOtroCosto.CompraOtroCostoId <> " & NumberToField(mlngCompraOtroCostoId)
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
