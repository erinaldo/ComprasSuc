Imports System.Data
Imports System.Data.OleDb

Public Class clsDatoTecnico
   Implements IDisposable

   Private mlngDatoTecnicoId As Long
   Private mlngEmpresaId As Long
   Private mlngLineaId As Long
   Private mlngTipoDatoTecnicoId As Long
   Private mlngItemId As Long
   Private mstrDatoTecnicoDes As String
   Private mdecValor As Decimal
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
   Property DatoTecnicoId() As Long
      Get
         Return mlngDatoTecnicoId
      End Get

      Set(ByVal Value As Long)
         mlngDatoTecnicoId = Value
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

   Property TipoDatoTecnicoId() As Long
      Get
         Return mlngTipoDatoTecnicoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoDatoTecnicoId = Value
      End Set
   End Property

   Property ItemId() As Long
      Get
         Return mlngItemId
      End Get

      Set(ByVal Value As Long)
         mlngItemId = Value
      End Set
   End Property

   Property DatoTecnicoDes() As String
      Get
         Return mstrDatoTecnicoDes
      End Get

      Set(ByVal Value As String)
         mstrDatoTecnicoDes = Value
      End Set
   End Property

   Property Valor() As Decimal
      Get
         Return mdecValor
      End Get

      Set(ByVal Value As Decimal)
         mdecValor = Value
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
      GridFind = 3
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      DatoTecnicoDes = 2
      LIKEDatoTecnicoDes = 3
      Grid = 4
      TipoDatoTecnicoId = 5
      ItemId = 6
      GridFind = 7
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      DatoTecnicoId = 1
      DatoTecnicoDes = 2
      Grid = 3
      GridFind = 4

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
      mstrTableName = "invDatoTecnico"
      mstrClassName = "clsDatoTecnico"

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
      mlngDatoTecnicoId = 0
      mlngEmpresaId = 0
      mlngLineaId = 0
      mlngTipoDatoTecnicoId = 0
      mlngItemId = 0
      mstrDatoTecnicoDes = ""
      mdecValor = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    invDatoTecnico.DatoTecnicoId,  "
            strSQL &= "    invDatoTecnico.EmpresaId,  "
            strSQL &= "    invDatoTecnico.LineaId,  "
            strSQL &= "    invDatoTecnico.TipoDatoTecnicoId,  "
            strSQL &= "    invDatoTecnico.ItemId,  "
            strSQL &= "    invDatoTecnico.DatoTecnicoDes,  "
            strSQL &= "    invDatoTecnico.Valor,  "
            strSQL &= "    invDatoTecnico.sLastUpdate_id,  "
            strSQL &= "    invDatoTecnico.dtLastUpdate_dt,  "
            strSQL &= "    invDatoTecnico.iConcurrency_id  "
            strSQL &= " FROM invDatoTecnico "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invDatoTecnico.DatoTecnicoId,  "
            strSQL &= "    invDatoTecnico.DatoTecnicoDes  "
            strSQL &= " FROM invDatoTecnico "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invDatoTecnico.DatoTecnicoId,  "
            strSQL &= "    invDatoTecnico.EmpresaId,  "
            strSQL &= "    invDatoTecnico.LineaId,  "
            strSQL &= "    invTipoDatoTecnico.TipoDatoTecnicoId,  "
            strSQL &= "    invTipoDatoTecnico.TipoDatoTecnicoDes,  "
            strSQL &= "    invDatoTecnico.ItemId,  "
            strSQL &= "    invDatoTecnico.DatoTecnicoDes,  "
            strSQL &= "    invDatoTecnico.Valor  "
            strSQL &= " FROM invDatoTecnico, invTipoDatoTecnico "

         Case SelectFilters.GridFind
            strSQL = " SELECT  "
            strSQL &= "    DISTINCT(invDatoTecnico.TipoDatoTecnicoId), "
            strSQL &= "    invTipoDatoTecnico.TipoDatoTecnicoDes,  "
            strSQL &= "    '' DatoTecnicoDes, "
            strSQL &= "    '' ValorMin, "
            strSQL &= "    '' ValorMax "
            strSQL &= " FROM invDatoTecnico, invTipoDatoTecnico, invItem "

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
            strSQL = " WHERE  invDatoTecnico.DatoTecnicoId = " & NumberToField(mlngDatoTecnicoId)

         Case WhereFilters.DatoTecnicoDes

         Case WhereFilters.LIKEDatoTecnicoDes

         Case WhereFilters.Grid
            strSQL = " WHERE  invDatoTecnico.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invDatoTecnico.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invDatoTecnico.TipoDatoTecnicoId = invTipoDatoTecnico.TipoDatoTecnicoId "

         Case WhereFilters.TipoDatoTecnicoId
            strSQL = " WHERE  invDatoTecnico.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invDatoTecnico.TipoDatoTecnicoId = " & NumberToField(mlngTipoDatoTecnicoId)

         Case WhereFilters.ItemId
            strSQL = " WHERE  invDatoTecnico.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invDatoTecnico.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.GridFind
            strSQL = " WHERE  invDatoTecnico.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invDatoTecnico.TipoDatoTecnicoId = invTipoDatoTecnico.TipoDatoTecnicoId "
            strSQL &= " AND  invDatoTecnico.ItemId = invItem.ItemId "
            strSQL &= " AND  invItem.TipoItemId <> 3 "     ''Inventario y Servicio
            strSQL &= " AND  invItem.EstadoId = 1 "     ''Item Activos

            If mlngLineaId <> 0 Then
               strSQL &= " AND  invDatoTecnico.LineaId = " & NumberToField(mlngLineaId)
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.DatoTecnicoId
            strSQL = " ORDER BY invDatoTecnico.DatoTecnicoId "

         Case OrderByFilters.DatoTecnicoDes
            strSQL = " ORDER BY invDatoTecnico.DatoTecnicoDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY invTipoDatoTecnico.TipoDatoTecnicoDes "

         Case OrderByFilters.GridFind
            strSQL = " ORDER BY invTipoDatoTecnico.TipoDatoTecnicoDes "

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
            strSQL = "INSERT INTO invDatoTecnico ("
            strSQL &= "DatoTecnicoId, "
            strSQL &= "EmpresaId, "
            strSQL &= "LineaId, "
            strSQL &= "TipoDatoTecnicoId, "
            strSQL &= "ItemId, "
            strSQL &= "DatoTecnicoDes, "
            strSQL &= "Valor, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngDatoTecnicoId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngLineaId) & ", "
            strSQL &= NumberToField(mlngTipoDatoTecnicoId) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= StringToField(mstrDatoTecnicoDes) & ", "
            strSQL &= DecimalToField(mdecValor) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invDatoTecnico SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "LineaId = " & NumberToField(mlngLineaId) & ", "
            strSQL &= "TipoDatoTecnicoId = " & NumberToField(mlngTipoDatoTecnicoId) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "DatoTecnicoDes = " & StringToField(mstrDatoTecnicoDes) & ", "
            strSQL &= "Valor = " & DecimalToField(mdecValor) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " DatoTecnicoId = " & NumberToField(mlngDatoTecnicoId) & " "

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
               mlngDatoTecnicoId = ToLong(oDataRow("DatoTecnicoId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngLineaId = ToLong(oDataRow("LineaId"))
               mlngTipoDatoTecnicoId = ToLong(oDataRow("TipoDatoTecnicoId"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mstrDatoTecnicoDes = ToStr(oDataRow("DatoTecnicoDes"))
               mdecValor = ToDecimal(oDataRow("Valor"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngDatoTecnicoId = ToLong(oDataRow("DatoTecnicoId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngDatoTecnicoId = TableIDGet(mstrTableName, "DatoTecnicoId", moConnection)

         If mlngDatoTecnicoId = -1 Then
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
         strMsg &= "Seleccione la Item" & vbCrLf
      End If

      If mlngTipoDatoTecnicoId = 0 Then
         strMsg &= "Seleccione el Item DatoTecnico" & vbCrLf
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
