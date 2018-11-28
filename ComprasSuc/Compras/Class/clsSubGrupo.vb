Imports System.Data
Imports System.Data.OleDb

Public Class clsSubGrupo
   Implements IDisposable

   Private mlngSubGrupoId As Long
   Private mlngEmpresaId As Long
   Private mlngLineaId As Long
   Private mlngGrupoId As Long
   Private mstrSubGrupoDes As String
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
   Property SubGrupoId() As Long
      Get
         Return mlngSubGrupoId
      End Get

      Set(ByVal Value As Long)
         mlngSubGrupoId = Value
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

   Property LineaId() As Long
      Get
         Return mlngLineaId
      End Get

      Set(ByVal Value As Long)
         mlngLineaId = Value
      End Set
   End Property

   Property GrupoId() As Long
      Get
         Return mlngGrupoId
      End Get

      Set(ByVal Value As Long)
         mlngGrupoId = Value
      End Set
   End Property

   Property SubGrupoDes() As String
      Get
         Return mstrSubGrupoDes
      End Get

      Set(ByVal Value As String)
         mstrSubGrupoDes = Value
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
      SubGrupoDes = 2
      LIKESubGrupoDes = 3
      Grid = 4
      GrupoId = 5
      GridCheck = 6
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      SubGrupoId = 1
      SubGrupoDes = 2
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
      mstrTableName = "invSubGrupo"
      mstrClassName = "clsSubGrupo"

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
      mlngSubGrupoId = 0
      mlngEmpresaId = 0
      mlngLineaId = 0
      mlngGrupoId = 0
      mstrSubGrupoDes = ""

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.EmpresaId,  "
            strSQL &= "    invSubGrupo.LineaId,  "
            strSQL &= "    invSubGrupo.GrupoId,  "
            strSQL &= "    invSubGrupo.SubGrupoDes,  "
            strSQL &= "    invSubGrupo.sLastUpdate_id,  "
            strSQL &= "    invSubGrupo.dtLastUpdate_dt,  "
            strSQL &= "    invSubGrupo.iConcurrency_id  "
            strSQL &= " FROM invSubGrupo "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.SubGrupoDes  "
            strSQL &= " FROM invSubGrupo "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.EmpresaId,  "
            strSQL &= "    invLinea.LineaId,  "
            strSQL &= "    invLinea.LineaDes,  "
            strSQL &= "    invGrupo.GrupoId,  "
            strSQL &= "    invGrupo.GrupoDes,  "
            strSQL &= "    invSubGrupo.SubGrupoDes  "
            strSQL &= " FROM invSubGrupo, invLinea, invGrupo "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.EmpresaId,  "
            strSQL &= "    invLinea.LineaId,  "
            strSQL &= "    invLinea.LineaDes,  "
            strSQL &= "    invGrupo.GrupoId,  "
            strSQL &= "    invGrupo.GrupoDes,  "
            strSQL &= "    invSubGrupo.SubGrupoDes  "
            strSQL &= " FROM invSubGrupo, invLinea, invGrupo "

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
            strSQL = " WHERE  invSubGrupo.SubGrupoId = " & NumberToField(mlngSubGrupoId)

         Case WhereFilters.SubGrupoDes
            strSQL = " WHERE  invSubGrupo.SubGrupoDes = " & StringToField(mstrSubGrupoDes)

         Case WhereFilters.LIKESubGrupoDes
            strSQL = " WHERE  invSubGrupo.SubGrupoDes LIKE " & StringToField(mstrSubGrupoDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  invSubGrupo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invSubGrupo.LineaId = invLinea.LineaId "
            strSQL &= " AND  invSubGrupo.GrupoId = invGrupo.GrupoId "

         Case WhereFilters.GrupoId
            strSQL = " WHERE  invSubGrupo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invSubGrupo.GrupoId = " & NumberToField(mlngGrupoId)

         Case WhereFilters.GridCheck
            strSQL = " WHERE  invSubGrupo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invSubGrupo.LineaId = invLinea.LineaId "
            strSQL &= " AND  invSubGrupo.GrupoId = invGrupo.GrupoId "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.SubGrupoId
            strSQL = " ORDER BY invSubGrupo.SubGrupoId "

         Case OrderByFilters.SubGrupoDes
            strSQL = " ORDER BY invSubGrupo.SubGrupoDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY invSubGrupo.SubGrupoDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY invSubGrupo.SubGrupoDes "

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
            strSQL = "INSERT INTO invSubGrupo ("
            strSQL &= "SubGrupoId, "
            strSQL &= "EmpresaId, "
            strSQL &= "LineaId, "
            strSQL &= "GrupoId, "
            strSQL &= "SubGrupoDes, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngSubGrupoId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngLineaId) & ", "
            strSQL &= NumberToField(mlngGrupoId) & ", "
            strSQL &= StringToField(mstrSubGrupoDes) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invSubGrupo SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "LineaId = " & NumberToField(mlngLineaId) & ", "
            strSQL &= "GrupoId = " & NumberToField(mlngGrupoId) & ", "
            strSQL &= "SubGrupoDes = " & StringToField(mstrSubGrupoDes) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " SubGrupoId = " & NumberToField(mlngSubGrupoId) & " "

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
               mlngSubGrupoId = ToLong(oDataRow("SubGrupoId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngLineaId = ToLong(oDataRow("LineaId"))
               mlngGrupoId = ToLong(oDataRow("GrupoId"))
               mstrSubGrupoDes = ToStr(oDataRow("SubGrupoDes"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngSubGrupoId = ToLong(oDataRow("SubGrupoId"))
               mstrSubGrupoDes = ToStr(oDataRow("SubGrupoDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngSubGrupoId = TableIDGet(mstrTableName, "SubGrupoId", moConnection)

         If mlngSubGrupoId = -1 Then
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

      If mlngLineaId = 0 Then
         strMsg &= "Seleccione la Linea" & vbCrLf
      End If

      If mlngGrupoId = 0 Then
         strMsg &= "Seleccione el Grupo" & vbCrLf
      End If

      If mstrSubGrupoDes.Length() = 0 Then
         strMsg &= "Ingrese el SubGrupo" & vbCrLf
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
         strSQL = " SELECT  "
         strSQL &= " Count(*) As NumRecs  "
         strSQL &= " FROM invSubGrupo "

         If Not boolReplace Then
            strSQL &= " WHERE  invSubGrupo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invSubGrupo.LineaId = " & NumberToField(mlngLineaId)
            strSQL &= " AND  invSubGrupo.GrupoId = " & NumberToField(mlngGrupoId)
            strSQL &= " AND  invSubGrupo.SubGrupoDes = " & StringToField(mstrSubGrupoDes)
         Else
            strSQL &= " WHERE  invSubGrupo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invSubGrupo.LineaId = " & NumberToField(mlngLineaId)
            strSQL &= " AND  invSubGrupo.GrupoId = " & NumberToField(mlngGrupoId)
            strSQL &= " AND  invSubGrupo.SubGrupoDes = " & StringToField(mstrSubGrupoDes)
            strSQL &= " AND  invSubGrupo.SubGrupoId <> " & NumberToField(mlngSubGrupoId)
         End If

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
