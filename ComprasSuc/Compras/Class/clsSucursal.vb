Imports System.Data
Imports System.Data.OleDb

Public Class clsSucursal
   Implements IDisposable

   Private mlngSucursalId As Long
   Private mlngEmpresaId As Long
   Private mstrSucursalDes As String
   Private mstrSucursalCod As String
   Private mstrDireccion As String
   Private mlngCiudadId As Long
   Private mstrTelefono As String
   Private mlngTipoSucursalId As Long
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
   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
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

   Property SucursalDes() As String
      Get
         Return mstrSucursalDes
      End Get

      Set(ByVal Value As String)
         mstrSucursalDes = Value
      End Set
   End Property

   Property SucursalCod() As String
      Get
         Return mstrSucursalCod
      End Get

      Set(ByVal Value As String)
         mstrSucursalCod = Value
      End Set
   End Property

   Property Direccion() As String
      Get
         Return mstrDireccion
      End Get

      Set(ByVal Value As String)
         mstrDireccion = Value
      End Set
   End Property

   Property CiudadId() As Long
      Get
         Return mlngCiudadId
      End Get

      Set(ByVal Value As Long)
         mlngCiudadId = Value
      End Set
   End Property

   Property Telefono() As String
      Get
         Return mstrTelefono
      End Get

      Set(ByVal Value As String)
         mstrTelefono = Value
      End Set
   End Property

   Property TipoSucursalId() As Long
      Get
         Return mlngTipoSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngTipoSucursalId = Value
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
      CompId = 3
      GridCheck = 4
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      SucursalDes = 2
      LIKESucursalDes = 3
      Grid = 4
      CompId = 5
      EmpresaId = 6
      SucursalCod = 7
      TipoSucursalId = 8
      AperturaPara = 9
   End Enum

   Public Enum InWhereFilters As Byte
      None = 0
      NotIN_VentaPara = 1
      NotIN_NotaPara = 2
      NotIN_CompraPara = 3
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      SucursalId = 1
      SucursalDes = 2
      Grid = 3
      CompId = 4
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
   Private mintInWhereFilter As InWhereFilters
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

   Property InWhereFilter() As InWhereFilters
      Get
         Return mintInWhereFilter
      End Get

      Set(ByVal Value As InWhereFilters)
         mintInWhereFilter = Value
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
      mstrTableName = "tblSucursal"
      mstrClassName = "clsSucursal"

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
      mlngSucursalId = 0
      mlngEmpresaId = 0
      mstrSucursalDes = ""
      mstrSucursalCod = ""
      mstrDireccion = ""
      mlngCiudadId = 0
      mstrTelefono = ""
      mlngTipoSucursalId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.Direccion,  "
            strSQL &= "    tblSucursal.CiudadId,  "
            strSQL &= "    tblSucursal.Telefono,  "
            strSQL &= "    tblSucursal.TipoSucursalId,  "
            strSQL &= "    tblSucursal.sLastUpdate_id,  "
            strSQL &= "    tblSucursal.dtLastUpdate_dt,  "
            strSQL &= "    tblSucursal.iConcurrency_id  "
            strSQL &= " FROM tblSucursal "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes  "
            strSQL &= " FROM tblSucursal "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblSucursal.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    tblSucursal.Telefono,  "
            strSQL &= "    tblSucursal.TipoSucursalId  "
            strSQL &= " FROM tblSucursal, tblCiudad "

         Case SelectFilters.CompId
            strSQL = " SELECT  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.EmpresaId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes  "
            strSQL &= " FROM tblSucursal, tblPlan, tblCompDet "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblSucursal.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    tblSucursal.Telefono  "
            strSQL &= " FROM tblSucursal, tblCiudad "

      End Select

      strSQL &= WhereFilterGet()

      strSQL &= InWhereFilterGet()

      strSQL &= OrderByFilterGet()

      mstrSQL = strSQL

      Return strSQL
   End Function

   Private Function WhereFilterGet() As String
      Dim strSQL As String

      Select Case mintWhereFilter
         Case WhereFilters.PrimaryKey
            strSQL = " WHERE  tblSucursal.SucursalId = " & NumberToField(mlngSucursalId)

         Case WhereFilters.SucursalDes
            strSQL = " WHERE  tblSucursal.SucursalDes = " & StringToField(mstrSucursalDes)
            strSQL &= "  AND  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.LIKESucursalDes
            strSQL = " WHERE  tblSucursal.SucursalDes LIKE " & StringToField(mstrSucursalDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.CiudadId = tblCiudad.CiudadId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.SucursalId = tblCompDet.SucursalId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblCompDet.SucursalId <> 0 "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.SucursalCod
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.SucursalCod = " & StringToField(mstrSucursalCod)

         Case WhereFilters.TipoSucursalId
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.TipoSucursalId = " & NumberToField(mlngTipoSucursalId)

         Case WhereFilters.AperturaPara
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)

            If mlngSucursalId > 0 Then
               strSQL &= " AND  (tblSucursal.TipoSucursalId = " & NumberToField(mlngTipoSucursalId)
               strSQL &= " OR  tblSucursal.SucursalId = " & NumberToField(mlngSucursalId) & " )"
            Else
               strSQL &= " AND  tblSucursal.TipoSucursalId = " & NumberToField(mlngTipoSucursalId)
            End If
            strSQL &= " AND  tblSucursal.SucursalId <> 0 "

      End Select

      Return strSQL
   End Function

   Private Function InWhereFilterGet() As String
      Dim strSQL As String

      Select Case mintInWhereFilter
         Case InWhereFilter.None

         Case InWhereFilter.NotIN_VentaPara
            strSQL = " AND tblSucursal.SucursalId NOT IN (SELECT venVentaPara.SucursalId "
            strSQL &= "    FROM venVentaPara "
            strSQL &= "    WHERE venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "       AND venVentaPara.GestionId = " & NumberToField(mlngCiudadId)
            strSQL &= "    ) "

         Case InWhereFilter.NotIN_NotaPara
            strSQL = " AND tblSucursal.SucursalId NOT IN (SELECT invNotaPara.SucursalId "
            strSQL &= "    FROM invNotaPara "
            strSQL &= "    WHERE invNotaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "       AND invNotaPara.GestionId = " & NumberToField(mlngCiudadId)
            strSQL &= "    ) "

         Case InWhereFilter.NotIN_CompraPara
            strSQL = " AND tblSucursal.SucursalId NOT IN (SELECT comCompraPara.SucursalId "
            strSQL &= "    FROM comCompraPara "
            strSQL &= "    WHERE comCompraPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "       AND comCompraPara.GestionId = " & NumberToField(mlngCiudadId)
            strSQL &= "    ) "


      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.SucursalId
            strSQL = " ORDER BY tblSucursal.SucursalId "

         Case OrderByFilters.SucursalDes
            strSQL = " ORDER BY tblSucursal.SucursalDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblSucursal.SucursalDes "

         Case OrderByFilters.CompId
            strSQL = " ORDER BY tblPlan.PlanCta "

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
            strSQL = "INSERT INTO tblSucursal ("
            strSQL &= "SucursalId, "
            strSQL &= "EmpresaId, "
            strSQL &= "SucursalDes, "
            strSQL &= "SucursalCod, "
            strSQL &= "Direccion, "
            strSQL &= "CiudadId, "
            strSQL &= "Telefono, "
            strSQL &= "TipoSucursalId,  "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrSucursalDes) & ", "
            strSQL &= StringToField(mstrSucursalCod) & ", "
            strSQL &= StringToField(mstrDireccion) & ", "
            strSQL &= NumberToField(mlngCiudadId) & ", "
            strSQL &= StringToField(mstrTelefono) & ", "
            strSQL &= NumberToField(mlngTipoSucursalId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblSucursal SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "SucursalDes = " & StringToField(mstrSucursalDes) & ", "
            strSQL &= "SucursalCod = " & StringToField(mstrSucursalCod) & ", "
            strSQL &= "Direccion = " & StringToField(mstrDireccion) & ", "
            strSQL &= "CiudadId = " & NumberToField(mlngCiudadId) & ", "
            strSQL &= "Telefono = " & StringToField(mstrTelefono) & ", "
            strSQL &= "TipoSucursalId = " & NumberToField(mlngTipoSucursalId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " SucursalId = " & NumberToField(mlngSucursalId) & " "

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
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrSucursalDes = ToStr(oDataRow("SucursalDes"))
               mstrSucursalCod = ToStr(oDataRow("SucursalCod"))
               mstrDireccion = ToStr(oDataRow("Direccion"))
               mlngCiudadId = ToLong(oDataRow("CiudadId"))
               mstrTelefono = ToStr(oDataRow("Telefono"))
               mlngTipoSucursalId = ToLong(oDataRow("TipoSucursalId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mstrSucursalDes = ToStr(oDataRow("SucursalDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngSucursalId = TableIDGet(mstrTableName, "SucursalId", moConnection)

         If mlngSucursalId = -1 Then
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

      If mstrSucursalDes.Length() = 0 Then
         strMsg &= "Ingrese el Sucursal" & vbCrLf
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
         strSQL &= " FROM tblSucursal "

         If Not boolReplace Then
            strSQL &= " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.SucursalCod = " & StringToField(mstrSucursalCod)
         Else
            strSQL &= " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.SucursalCod = " & StringToField(mstrSucursalCod)
            strSQL &= " AND  tblSucursal.SucursalId <> " & NumberToField(mlngSucursalId)
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
      mintInWhereFilter = 0
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
