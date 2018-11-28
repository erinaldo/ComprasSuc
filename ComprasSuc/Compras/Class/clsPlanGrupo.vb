Imports System.Data
Imports System.Data.OleDb

Public Class clsPlanGrupo
   Implements IDisposable

   Private mlngPlanGrupoId As Long
   Private mlngEmpresaId As Long
   Private mstrPlanGrupoDes As String
   Private mlngPlanIdAct As Long
   Private mlngPlanIdTra As Long
   Private mlngPlanIdIng As Long
   Private mlngPlanIdCos As Long
   Private mlngTipoActEco1Id As Long
   Private mlngTipoActEco2Id As Long
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
   Property PlanGrupoId() As Long
      Get
         Return mlngPlanGrupoId
      End Get

      Set(ByVal Value As Long)
         mlngPlanGrupoId = Value
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

   Property PlanGrupoDes() As String
      Get
         Return mstrPlanGrupoDes
      End Get

      Set(ByVal Value As String)
         mstrPlanGrupoDes = Value
      End Set
   End Property

   Property PlanIdAct() As Long
      Get
         Return mlngPlanIdAct
      End Get

      Set(ByVal Value As Long)
         mlngPlanIdAct = Value
      End Set
   End Property

   Property PlanIdTra() As Long
      Get
         Return mlngPlanIdTra
      End Get

      Set(ByVal Value As Long)
         mlngPlanIdTra = Value
      End Set
   End Property

   Property PlanIdIng() As Long
      Get
         Return mlngPlanIdIng
      End Get

      Set(ByVal Value As Long)
         mlngPlanIdIng = Value
      End Set
   End Property

   Property PlanIdCos() As Long
      Get
         Return mlngPlanIdCos
      End Get

      Set(ByVal Value As Long)
         mlngPlanIdCos = Value
      End Set
   End Property

   Property TipoActEco1Id() As Long
      Get
         Return mlngTipoActEco1Id
      End Get

      Set(ByVal Value As Long)
         mlngTipoActEco1Id = Value
      End Set
   End Property

   Property TipoActEco2Id() As Long
      Get
         Return mlngTipoActEco2Id
      End Get

      Set(ByVal Value As Long)
         mlngTipoActEco2Id = Value
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
      GridCheck = 3
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      PlanGrupoDes = 2
      LIKEPlanGrupoDes = 3
      Grid = 4
      EmpresaId = 5
      GridCheck = 6
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PlanGrupoId = 1
      PlanGrupoDes = 2
      Grid = 3
      GridCheck = 4
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
      mstrTableName = "invPlanGrupo"
      mstrClassName = "clsPlanGrupo"

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
      mlngPlanGrupoId = 0
      mlngEmpresaId = 0
      mstrPlanGrupoDes = ""
      mlngPlanIdAct = 0
      mlngPlanIdTra = 0
      mlngPlanIdIng = 0
      mlngPlanIdCos = 0
      mlngTipoActEco1Id = 0
      mlngTipoActEco2Id = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    invPlanGrupo.PlanGrupoId,  "
            strSQL &= "    invPlanGrupo.EmpresaId,  "
            strSQL &= "    invPlanGrupo.PlanGrupoDes,  "
            strSQL &= "    invPlanGrupo.PlanIdAct,  "
            strSQL &= "    invPlanGrupo.PlanIdTra,  "
            strSQL &= "    invPlanGrupo.PlanIdIng,  "
            strSQL &= "    invPlanGrupo.PlanIdCos,  "
            strSQL &= "    invPlanGrupo.TipoActEco1Id,  "
            strSQL &= "    invPlanGrupo.TipoActEco2Id,  "
            strSQL &= "    invPlanGrupo.sLastUpdate_id,  "
            strSQL &= "    invPlanGrupo.dtLastUpdate_dt,  "
            strSQL &= "    invPlanGrupo.iConcurrency_id  "
            strSQL &= " FROM invPlanGrupo "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invPlanGrupo.PlanGrupoId,  "
            strSQL &= "    invPlanGrupo.PlanGrupoDes  "
            strSQL &= " FROM invPlanGrupo "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invPlanGrupo.PlanGrupoId,  "
            strSQL &= "    invPlanGrupo.EmpresaId,  "
            strSQL &= "    invPlanGrupo.PlanGrupoDes,  "

            strSQL &= "    tblPlanAct.PlanId As PlanIdAct,  "
            strSQL &= "    tblPlanAct.PlanDes As PlanDesAct,  "

            strSQL &= "    tblPlanTra.PlanId As PlanIdTra,  "
            strSQL &= "    tblPlanTra.PlanDes As PlanDesTra,  "

            strSQL &= "    tblPlanIng.PlanId As PlanIdIng,  "
            strSQL &= "    tblPlanIng.PlanDes As PlanDesIng,  "

            strSQL &= "    tblPlanCos.PlanId As PlanIdCos,  "
            strSQL &= "    tblPlanCos.PlanDes As PlanDesCos  "
            strSQL &= " FROM invPlanGrupo, tblPlan As tblPlanAct, tblPlan As tblPlanTra, tblPlan As tblPlanIng, tblPlan As tblPlanCos "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    invPlanGrupo.PlanGrupoId,  "
            strSQL &= "    invPlanGrupo.EmpresaId,  "
            strSQL &= "    invPlanGrupo.PlanGrupoDes,  "

            strSQL &= "    tblPlanAct.PlanId As PlanIdAct,  "
            strSQL &= "    tblPlanAct.PlanDes As PlanDesAct,  "

            strSQL &= "    tblPlanTra.PlanId As PlanIdTra,  "
            strSQL &= "    tblPlanTra.PlanDes As PlanDesTra,  "

            strSQL &= "    tblPlanIng.PlanId As PlanIdIng,  "
            strSQL &= "    tblPlanIng.PlanDes As PlanDesIng,  "

            strSQL &= "    tblPlanCos.PlanId As PlanIdCos,  "
            strSQL &= "    tblPlanCos.PlanDes As PlanDesCos  "
            strSQL &= " FROM invPlanGrupo, tblPlan As tblPlanAct, tblPlan As tblPlanTra, tblPlan As tblPlanIng, tblPlan As tblPlanCos "

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
            strSQL = " WHERE  invPlanGrupo.PlanGrupoId = " & NumberToField(mlngPlanGrupoId)

         Case WhereFilters.PlanGrupoDes
            strSQL = " WHERE  invPlanGrupo.PlanGrupoDes = " & StringToField(mstrPlanGrupoDes)

         Case WhereFilters.LIKEPlanGrupoDes
            strSQL = " WHERE  invPlanGrupo.PlanGrupoDes LIKE " & StringToField(mstrPlanGrupoDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  invPlanGrupo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invPlanGrupo.PlanIdAct = tblPlanAct.PlanId "
            strSQL &= " AND  invPlanGrupo.PlanIdTra = tblPlanTra.PlanId "
            strSQL &= " AND  invPlanGrupo.PlanIdIng = tblPlanIng.PlanId "
            strSQL &= " AND  invPlanGrupo.PlanIdCos = tblPlanCos.PlanId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  invPlanGrupo.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.GridCheck
            strSQL = " WHERE  invPlanGrupo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invPlanGrupo.PlanIdAct = tblPlanAct.PlanId "
            strSQL &= " AND  invPlanGrupo.PlanIdTra = tblPlanTra.PlanId "
            strSQL &= " AND  invPlanGrupo.PlanIdIng = tblPlanIng.PlanId "
            strSQL &= " AND  invPlanGrupo.PlanIdCos = tblPlanCos.PlanId "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PlanGrupoId
            strSQL = " ORDER BY invPlanGrupo.PlanGrupoId "

         Case OrderByFilters.PlanGrupoDes
            strSQL = " ORDER BY invPlanGrupo.PlanGrupoDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY invPlanGrupo.PlanGrupoDes "

         Case OrderByFilters.GridCheck
            strSQL = " ORDER BY invPlanGrupo.PlanGrupoDes "

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
            strSQL = "INSERT INTO invPlanGrupo ("
            strSQL &= "PlanGrupoId, "
            strSQL &= "EmpresaId, "
            strSQL &= "PlanGrupoDes, "
            strSQL &= "PlanIdAct, "
            strSQL &= "PlanIdTra, "
            strSQL &= "PlanIdIng, "
            strSQL &= "PlanIdCos, "
            strSQL &= "TipoActEco1Id, "
            strSQL &= "TipoActEco2Id, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPlanGrupoId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrPlanGrupoDes) & ", "
            strSQL &= NumberToField(mlngPlanIdAct) & ", "
            strSQL &= NumberToField(mlngPlanIdTra) & ", "
            strSQL &= NumberToField(mlngPlanIdIng) & ", "
            strSQL &= NumberToField(mlngPlanIdCos) & ", "
            strSQL &= NumberToField(mlngTipoActEco1Id) & ", "
            strSQL &= NumberToField(mlngTipoActEco2Id) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invPlanGrupo SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "PlanGrupoDes = " & StringToField(mstrPlanGrupoDes) & ", "
            strSQL &= "PlanIdAct = " & NumberToField(mlngPlanIdAct) & ", "
            strSQL &= "PlanIdTra = " & NumberToField(mlngPlanIdTra) & ", "
            strSQL &= "PlanIdIng = " & NumberToField(mlngPlanIdIng) & ", "
            strSQL &= "PlanIdCos = " & NumberToField(mlngPlanIdCos) & ", "
            strSQL &= "TipoActEco1Id = " & NumberToField(mlngTipoActEco1Id) & ", "
            strSQL &= "TipoActEco2Id = " & NumberToField(mlngTipoActEco2Id) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PlanGrupoId = " & NumberToField(mlngPlanGrupoId) & " "

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
               mlngPlanGrupoId = ToLong(oDataRow("PlanGrupoId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrPlanGrupoDes = ToStr(oDataRow("PlanGrupoDes"))
               mlngPlanIdAct = ToLong(oDataRow("PlanIdAct"))
               mlngPlanIdTra = ToLong(oDataRow("PlanIdTra"))
               mlngPlanIdIng = ToLong(oDataRow("PlanIdIng"))
               mlngPlanIdCos = ToLong(oDataRow("PlanIdCos"))
               mlngTipoActEco1Id = ToLong(oDataRow("TipoActEco1Id"))
               mlngTipoActEco2Id = ToLong(oDataRow("TipoActEco2Id"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPlanGrupoId = ToLong(oDataRow("PlanGrupoId"))
               mstrPlanGrupoDes = ToStr(oDataRow("PlanGrupoDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPlanGrupoId = TableIDGet(mstrTableName, "PlanGrupoId", moConnection)

         If mlngPlanGrupoId = -1 Then
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

      If mstrPlanGrupoDes.Length() = 0 Then
         strMsg &= "Ingrese la Descripción del Grupo de Cuentas" & vbCrLf
      End If

      If mlngPlanIdAct = 0 Then
         strMsg &= "Seleccione la Cuenta de Activo" & vbCrLf
      End If

      If mlngPlanIdTra = 0 Then
         strMsg &= "Seleccione la Cuenta de Transito" & vbCrLf
      End If

      If mlngPlanIdIng = 0 Then
         strMsg &= "Seleccione la Cuenta de Ingreso" & vbCrLf
      End If

      If mlngPlanIdCos = 0 Then
         strMsg &= "Seleccione la Cuenta de Costo" & vbCrLf
      End If

      If mlngTipoActEco1Id = 0 Then
         strMsg &= "Seleccione la Actividad" & vbCrLf
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
         'strSQL &= " FROM tblPlan "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)
         '   strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
         'Else
         '   strSQL &= " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)
         '   strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
         '   strSQL &= " AND  tblPlan.PlanId <> " & NumberToField(mlngPlanId)
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
