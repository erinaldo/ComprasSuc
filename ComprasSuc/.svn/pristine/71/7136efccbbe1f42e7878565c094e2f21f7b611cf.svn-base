Imports System.Data
Imports System.Data.OleDb

Public Class clsAlmacen
   Implements IDisposable

   Private mlngAlmacenId As Long
   Private mlngEmpresaId As Long
   Private mlngSucursalId As Long
   Private mstrAlmacenDes As String
   Private mstrAlmacenCod As String
   Private mstrResponsable As String
   Private mstrDireccion As String
   Private mstrTelefono As String
   Private mstrFax As String
   Private mlngTipoAlmacenId As Long
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
   Property AlmacenId() As Long
      Get
         Return mlngAlmacenId
      End Get

      Set(ByVal Value As Long)
         mlngAlmacenId = Value
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

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
      End Set
   End Property

   Property AlmacenDes() As String
      Get
         Return mstrAlmacenDes
      End Get

      Set(ByVal Value As String)
         mstrAlmacenDes = Value
      End Set
   End Property

   Property AlmacenCod() As String
      Get
         Return mstrAlmacenCod
      End Get

      Set(ByVal Value As String)
         mstrAlmacenCod = Value
      End Set
   End Property

   Property Responsable() As String
      Get
         Return mstrResponsable
      End Get

      Set(ByVal Value As String)
         mstrResponsable = Value
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

   Property Telefono() As String
      Get
         Return mstrTelefono
      End Get

      Set(ByVal Value As String)
         mstrTelefono = Value
      End Set
   End Property

   Property Fax() As String
      Get
         Return mstrFax
      End Get

      Set(ByVal Value As String)
         mstrFax = Value
      End Set
   End Property

   Property TipoAlmacenId() As Long
      Get
         Return mlngTipoAlmacenId
      End Get

      Set(ByVal Value As Long)
         mlngTipoAlmacenId = Value
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
      GridCheck = 3
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      AlmacenDes = 2
      LIKEAlmacenDes = 3
      Grid = 4
      EmpresaId = 5
      AlmacenCod = 7
      GridCheck = 8
      TipoAlmacenId = 9
      SucursalTipoAlmacenId = 10
      EstadoId = 11
      SucursalId = 12
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      AlmacenId = 1
      AlmacenDes = 2
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
      mstrTableName = "invAlmacen"
      mstrClassName = "clsAlmacen"

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
      mlngAlmacenId = 0
      mlngEmpresaId = 0
      mlngSucursalId = 0
      mstrAlmacenDes = ""
      mstrAlmacenCod = ""
      mstrResponsable = ""
      mstrDireccion = ""
      mstrTelefono = ""
      mstrFax = ""
      mlngTipoAlmacenId = 0
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
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.EmpresaId,  "
            strSQL &= "    invAlmacen.SucursalId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    invAlmacen.AlmacenCod,  "
            strSQL &= "    invAlmacen.Responsable,  "
            strSQL &= "    invAlmacen.Direccion,  "
            strSQL &= "    invAlmacen.Telefono,  "
            strSQL &= "    invAlmacen.Fax,  "
            strSQL &= "    invAlmacen.TipoAlmacenId,  "
            strSQL &= "    invAlmacen.EstadoId,  "
            strSQL &= "    invAlmacen.sLastUpdate_id,  "
            strSQL &= "    invAlmacen.dtLastUpdate_dt,  "
            strSQL &= "    invAlmacen.iConcurrency_id  "
            strSQL &= " FROM invAlmacen "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes  "
            strSQL &= " FROM invAlmacen "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    invAlmacen.AlmacenCod,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    invAlmacen.Responsable,  "
            strSQL &= "    invAlmacen.Direccion,  "
            strSQL &= "    invAlmacen.Telefono,  "
            strSQL &= "    invAlmacen.Fax,  "
            strSQL &= "    invTipoAlmacen.TipoAlmacenId,  "
            strSQL &= "    invTipoAlmacen.TipoAlmacenDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM invAlmacen, tblSucursal, invTipoAlmacen, tblEstado "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    invAlmacen.AlmacenCod,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    invAlmacen.Responsable,  "
            strSQL &= "    invAlmacen.Direccion,  "
            strSQL &= "    invAlmacen.Telefono,  "
            strSQL &= "    invAlmacen.Fax,  "
            strSQL &= "    invTipoAlmacen.TipoAlmacenId,  "
            strSQL &= "    invTipoAlmacen.TipoAlmacenDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM invAlmacen, tblSucursal, invTipoAlmacen, tblEstado "

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
            strSQL = " WHERE  invAlmacen.AlmacenId = " & NumberToField(mlngAlmacenId)

         Case WhereFilters.AlmacenDes
            strSQL = " WHERE  invAlmacen.AlmacenDes = " & StringToField(mstrAlmacenDes)

         Case WhereFilters.LIKEAlmacenDes
            strSQL = " WHERE  invAlmacen.AlmacenDes LIKE " & StringToField(mstrAlmacenDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  invAlmacen.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invAlmacen.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  invAlmacen.TipoAlmacenId = invTipoAlmacen.TipoAlmacenId "
            strSQL &= " AND  invAlmacen.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  invAlmacen.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.AlmacenCod
            strSQL = " WHERE  invAlmacen.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invAlmacen.AlmacenCod = " & StringToField(mstrAlmacenCod)

         Case WhereFilters.GridCheck
            strSQL = " WHERE  invAlmacen.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invAlmacen.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  invAlmacen.TipoAlmacenId = invTipoAlmacen.TipoAlmacenId "
            strSQL &= " AND  invAlmacen.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.TipoAlmacenId
            strSQL = " WHERE  invAlmacen.EmpresaId = " & NumberToField(mlngEmpresaId)

            If mlngAlmacenId = 0 Then
               strSQL &= " AND  invAlmacen.TipoAlmacenId = " & NumberToField(mlngTipoAlmacenId)
               strSQL &= " AND  invAlmacen.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  ( (invAlmacen.TipoAlmacenId = " & NumberToField(mlngTipoAlmacenId)
               strSQL &= " AND  invAlmacen.EstadoId = " & NumberToField(mlngEstadoId) & ") "
               strSQL &= " OR  invAlmacen.AlmacenId = " & NumberToField(mlngAlmacenId) & ") "
            End If

         Case WhereFilters.SucursalTipoAlmacenId
            strSQL &= " WHERE  invAlmacen.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  invAlmacen.TipoAlmacenId = " & NumberToField(mlngTipoAlmacenId)

         Case WhereFilters.EstadoId
            strSQL = " WHERE  invAlmacen.EmpresaId = " & NumberToField(mlngEmpresaId)

            If mlngAlmacenId = 0 Then
               strSQL &= " AND  invAlmacen.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (invAlmacen.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  invAlmacen.AlmacenId = " & NumberToField(mlngAlmacenId) & ") "
            End If

         Case WhereFilters.SucursalId
            strSQL = " WHERE  invAlmacen.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invAlmacen.SucursalId = " & NumberToField(mlngSucursalId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.AlmacenId
            strSQL = " ORDER BY invAlmacen.AlmacenId "

         Case OrderByFilters.AlmacenDes
            strSQL = " ORDER BY invAlmacen.AlmacenDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblSucursal.SucursalDes, invAlmacen.AlmacenDes "

         Case OrderByFilters.GridCheck
            strSQL = " ORDER BY tblSucursal.SucursalDes, invAlmacen.AlmacenDes "

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
            strSQL = "INSERT INTO invAlmacen ("
            strSQL &= "AlmacenId, "
            strSQL &= "EmpresaId, "
            strSQL &= "SucursalId, "
            strSQL &= "AlmacenDes, "
            strSQL &= "AlmacenCod, "
            strSQL &= "Responsable, "
            strSQL &= "Direccion, "
            strSQL &= "Telefono, "
            strSQL &= "Fax, "
            strSQL &= "TipoAlmacenId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= StringToField(mstrAlmacenDes) & ", "
            strSQL &= StringToField(mstrAlmacenCod) & ", "
            strSQL &= StringToField(mstrResponsable) & ", "
            strSQL &= StringToField(mstrDireccion) & ", "
            strSQL &= StringToField(mstrTelefono) & ", "
            strSQL &= StringToField(mstrFax) & ", "
            strSQL &= NumberToField(mlngTipoAlmacenId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invAlmacen SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "AlmacenDes = " & StringToField(mstrAlmacenDes) & ", "
            strSQL &= "AlmacenCod = " & StringToField(mstrAlmacenCod) & ", "
            strSQL &= "Responsable = " & StringToField(mstrResponsable) & ", "
            strSQL &= "Direccion = " & StringToField(mstrDireccion) & ", "
            strSQL &= "Telefono = " & StringToField(mstrTelefono) & ", "
            strSQL &= "Fax = " & StringToField(mstrFax) & ", "
            strSQL &= "TipoAlmacenId = " & NumberToField(mlngTipoAlmacenId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " AlmacenId = " & NumberToField(mlngAlmacenId) & " "

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
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mstrAlmacenDes = ToStr(oDataRow("AlmacenDes"))
               mstrAlmacenCod = ToStr(oDataRow("AlmacenCod"))
               mstrResponsable = ToStr(oDataRow("Responsable"))
               mstrDireccion = ToStr(oDataRow("Direccion"))
               mstrTelefono = ToStr(oDataRow("Telefono"))
               mstrFax = ToStr(oDataRow("Fax"))
               mlngTipoAlmacenId = ToLong(oDataRow("TipoAlmacenId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mstrAlmacenDes = ToStr(oDataRow("AlmacenDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngAlmacenId = TableIDGet(mstrTableName, "AlmacenId", moConnection)

         If mlngAlmacenId = -1 Then
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

      If mlngSucursalId = 0 Then
         strMsg &= "Seleccione la Sucursal" & vbCrLf
      End If

      If mstrAlmacenDes.Length() = 0 Then
         strMsg &= "Ingrese el Almacen" & vbCrLf
      End If

      If mlngTipoAlmacenId = 0 Then
         strMsg &= "Seleccione el Tipo de Almacen" & vbCrLf
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
         ''strSQL = " SELECT  "
         ''strSQL &= " Count(*) As NumRecs  "
         ''strSQL &= " FROM invAlmacen "

         ''If Not boolReplace Then
         ''   strSQL &= " WHERE  invAlmacen.EmpresaId = " & NumberToField(mlngEmpresaId)
         ''   strSQL &= " AND  invAlmacen.SucursalId = " & NumberToField(mlngSucursalId)
         ''   strSQL &= " AND  invAlmacen.TipoAlmacenId =  " & NumberToField(clsTipoAlmacen.CONSIGNACION)
         ''Else
         ''   strSQL &= " WHERE  invAlmacen.EmpresaId = " & NumberToField(mlngEmpresaId)
         ''   strSQL &= " AND  invAlmacen.SucursalId = " & NumberToField(mlngSucursalId)
         ''   strSQL &= " AND  invAlmacen.TipoAlmacenId =  " & NumberToField(clsTipoAlmacen.CONSIGNACION)
         ''   strSQL &= " AND  invAlmacen.AlmacenId <> " & NumberToField(mlngAlmacenId)
         ''End If

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
