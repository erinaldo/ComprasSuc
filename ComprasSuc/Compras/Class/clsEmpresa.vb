Imports System.Data
Imports System.Data.OleDb

Public Class clsEmpresa
   Implements IDisposable

   Private mlngEmpresaId As Long
   Private mstrEmpresaDes As String
   Private mstrEmpresaRUC As String
   Private mstrDireccion As String
   Private mlngCiudadId As Long
   Private mstrTelefono1 As String
   Private mstrTelefono2 As String
   Private mstrMovil As String
   Private mstrFax As String
   Private mstrCodPostal As String
   Private mstrEmail As String
   Private mstrWeb As String
   Private mlngMesAperturaId As Long
   Private mlngMesCierreId As Long
   Private mlngMonedaId As Long
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
   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property EmpresaDes() As String
      Get
         Return mstrEmpresaDes
      End Get

      Set(ByVal Value As String)
         mstrEmpresaDes = Value
      End Set
   End Property

   Property EmpresaRUC() As String
      Get
         Return mstrEmpresaRUC
      End Get

      Set(ByVal Value As String)
         mstrEmpresaRUC = Value
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

   Property Telefono1() As String
      Get
         Return mstrTelefono1
      End Get

      Set(ByVal Value As String)
         mstrTelefono1 = Value
      End Set
   End Property

   Property Telefono2() As String
      Get
         Return mstrTelefono2
      End Get

      Set(ByVal Value As String)
         mstrTelefono2 = Value
      End Set
   End Property

   Property Movil() As String
      Get
         Return mstrMovil
      End Get

      Set(ByVal Value As String)
         mstrMovil = Value
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

   Property CodPostal() As String
      Get
         Return mstrCodPostal
      End Get

      Set(ByVal Value As String)
         mstrCodPostal = Value
      End Set
   End Property

   Property Email() As String
      Get
         Return mstrEmail
      End Get

      Set(ByVal Value As String)
         mstrEmail = Value
      End Set
   End Property

   Property Web() As String
      Get
         Return mstrWeb
      End Get

      Set(ByVal Value As String)
         mstrWeb = Value
      End Set
   End Property

   Property MesAperturaId() As Long
      Get
         Return mlngMesAperturaId
      End Get

      Set(ByVal Value As Long)
         mlngMesAperturaId = Value
      End Set
   End Property

   Property MesCierreId() As Long
      Get
         Return mlngMesCierreId
      End Get

      Set(ByVal Value As Long)
         mlngMesCierreId = Value
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
      EmpresaDes = 2
      LIKEEmpresaDes = 3
      Grid = 4
      Report = 5
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      EmpresaId = 1
      EmpresaDes = 2
      Grid = 3
      Report = 4
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
      mstrTableName = "tblEmpresa"
      mstrClassName = "clsEmpresa"

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
      mlngEmpresaId = 0
      mstrEmpresaDes = ""
      mstrEmpresaRUC = ""
      mstrDireccion = ""
      mlngCiudadId = 0
      mstrTelefono1 = ""
      mstrTelefono2 = ""
      mstrMovil = ""
      mstrFax = ""
      mstrCodPostal = ""
      mstrEmail = ""
      mstrWeb = ""
      mlngMesAperturaId = 0
      mlngMesCierreId = 0
      mlngMonedaId = 0
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
            strSQL &= "    tblEmpresa.EmpresaId,  "
            strSQL &= "    tblEmpresa.EmpresaDes,  "
            strSQL &= "    tblEmpresa.EmpresaRUC,  "
            strSQL &= "    tblEmpresa.Direccion,  "
            strSQL &= "    tblEmpresa.CiudadId,  "
            strSQL &= "    tblEmpresa.Telefono1,  "
            strSQL &= "    tblEmpresa.Telefono2,  "
            strSQL &= "    tblEmpresa.Movil,  "
            strSQL &= "    tblEmpresa.Fax,  "
            strSQL &= "    tblEmpresa.CodPostal,  "
            strSQL &= "    tblEmpresa.Email,  "
            strSQL &= "    tblEmpresa.Web,  "
            strSQL &= "    tblEmpresa.MesAperturaId,  "
            strSQL &= "    tblEmpresa.MesCierreId,  "
            strSQL &= "    tblEmpresa.MonedaId,  "
            strSQL &= "    tblEmpresa.EstadoId,  "
            strSQL &= "    tblEmpresa.sLastUpdate_id,  "
            strSQL &= "    tblEmpresa.dtLastUpdate_dt,  "
            strSQL &= "    tblEmpresa.iConcurrency_id  "
            strSQL &= " FROM tblEmpresa "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblEmpresa.EmpresaId,  "
            strSQL &= "    tblEmpresa.EmpresaDes  "
            strSQL &= " FROM tblEmpresa "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblEmpresa.EmpresaId,  "
            strSQL &= "    tblEmpresa.EmpresaDes,  "
            strSQL &= "    tblEmpresa.EmpresaRUC,  "
            strSQL &= "    tblEmpresa.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    tblEmpresa.Telefono1,  "
            strSQL &= "    tblEmpresa.Telefono2,  "
            strSQL &= "    tblEmpresa.Movil,  "
            strSQL &= "    tblEmpresa.Fax,  "
            strSQL &= "    tblEmpresa.CodPostal,  "
            strSQL &= "    tblEmpresa.Email,  "
            strSQL &= "    tblEmpresa.Web,  "
            strSQL &= "    tblEmpresa.MesAperturaId,  "
            strSQL &= "    tblMesApertura.MesDes As MesAperturaDes,  "
            strSQL &= "    tblEmpresa.MesCierreId,  "
            strSQL &= "    tblMesCierre.MesDes As MesCierreDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblEmpresa, tblCiudad, tblEstado, tblMes As tblMesApertura, tblMes As tblMesCierre, tblMoneda "

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
            strSQL = " WHERE  tblEmpresa.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.EmpresaDes
            strSQL = " WHERE  tblEmpresa.EmpresaDes = " & StringToField(mstrEmpresaDes)

         Case WhereFilters.LIKEEmpresaDes
            strSQL = " WHERE  tblEmpresa.EmpresaDes LIKE " & StringToField(mstrEmpresaDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblEmpresa.CiudadId = tblCiudad.CiudadId "
            strSQL &= " AND  tblEmpresa.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblEmpresa.MesAperturaId = tblMesApertura.MesId "
            strSQL &= " AND  tblEmpresa.MesCierreId = tblMesCierre.MesId "
            strSQL &= " AND  tblEmpresa.MonedaId = tblMoneda.MonedaId "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.EmpresaId
            strSQL = " ORDER BY tblEmpresa.EmpresaId "

         Case OrderByFilters.EmpresaDes
            strSQL = " ORDER BY tblEmpresa.EmpresaDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblEmpresa.EmpresaDes "

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
            strSQL = "INSERT INTO tblEmpresa ("
            strSQL &= "EmpresaId, "
            strSQL &= "EmpresaDes, "
            strSQL &= "EmpresaRUC, "
            strSQL &= "Direccion, "
            strSQL &= "CiudadId, "
            strSQL &= "Telefono1, "
            strSQL &= "Telefono2, "
            strSQL &= "Movil, "
            strSQL &= "Fax, "
            strSQL &= "CodPostal, "
            strSQL &= "Email, "
            strSQL &= "Web, "
            strSQL &= "MesAperturaId, "
            strSQL &= "MesCierreId, "
            strSQL &= "MonedaId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrEmpresaDes) & ", "
            strSQL &= StringToField(mstrEmpresaRUC) & ", "
            strSQL &= StringToField(mstrDireccion) & ", "
            strSQL &= NumberToField(mlngCiudadId) & ", "
            strSQL &= StringToField(mstrTelefono1) & ", "
            strSQL &= StringToField(mstrTelefono2) & ", "
            strSQL &= StringToField(mstrMovil) & ", "
            strSQL &= StringToField(mstrFax) & ", "
            strSQL &= StringToField(mstrCodPostal) & ", "
            strSQL &= StringToField(mstrEmail) & ", "
            strSQL &= StringToField(mstrWeb) & ", "
            strSQL &= NumberToField(mlngMesAperturaId) & ", "
            strSQL &= NumberToField(mlngMesCierreId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblEmpresa SET "
            strSQL &= "EmpresaDes = " & StringToField(mstrEmpresaDes) & ", "
            strSQL &= "EmpresaRUC = " & StringToField(mstrEmpresaRUC) & ", "
            strSQL &= "Direccion = " & StringToField(mstrDireccion) & ", "
            strSQL &= "CiudadId = " & NumberToField(mlngCiudadId) & ", "
            strSQL &= "Telefono1 = " & StringToField(mstrTelefono1) & ", "
            strSQL &= "Telefono2 = " & StringToField(mstrTelefono2) & ", "
            strSQL &= "Movil = " & StringToField(mstrMovil) & ", "
            strSQL &= "Fax = " & StringToField(mstrFax) & ", "
            strSQL &= "CodPostal = " & StringToField(mstrCodPostal) & ", "
            strSQL &= "Email = " & StringToField(mstrEmail) & ", "
            strSQL &= "Web = " & StringToField(mstrWeb) & ", "
            strSQL &= "MesAperturaId = " & NumberToField(mlngMesAperturaId) & ", "
            strSQL &= "MesCierreId = " & NumberToField(mlngMesCierreId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " EmpresaId = " & NumberToField(mlngEmpresaId) & " "

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
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrEmpresaDes = ToStr(oDataRow("EmpresaDes"))
               mstrEmpresaRUC = ToStr(oDataRow("EmpresaRUC"))
               mstrDireccion = ToStr(oDataRow("Direccion"))
               mlngCiudadId = ToLong(oDataRow("CiudadId"))
               mstrTelefono1 = ToStr(oDataRow("Telefono1"))
               mstrTelefono2 = ToStr(oDataRow("Telefono2"))
               mstrMovil = ToStr(oDataRow("Movil"))
               mstrFax = ToStr(oDataRow("Fax"))
               mstrCodPostal = ToStr(oDataRow("CodPostal"))
               mstrEmail = ToStr(oDataRow("Email"))
               mstrWeb = ToStr(oDataRow("Web"))
               mlngMesAperturaId = ToLong(oDataRow("MesAperturaId"))
               mlngMesCierreId = ToLong(oDataRow("MesCierreId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrEmpresaDes = ToStr(oDataRow("EmpresaDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngEmpresaId = TableIDGet(mstrTableName, "EmpresaId", moConnection)

         If mlngEmpresaId = -1 Then
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

      If mstrEmpresaDes.Length() = 0 Then
         strMsg &= "Ingrese el Empresa" & vbCrLf
      End If

      If mlngMesCierreId = 0 Then
         strMsg &= "Seleccione el Mes de Cierre" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Seleccione la Moneda" & vbCrLf
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
         strSQL &= " FROM tblEmpresa "

         If Not boolReplace Then
            strSQL &= " WHERE  tblEmpresa.EmpresaDes = " & StringToField(mstrEmpresaDes)
            strSQL &= " AND  tblEmpresa.EmpresaRUC = " & StringToField(mstrEmpresaRUC)
         Else
            strSQL &= " WHERE  tblEmpresa.EmpresaDes = " & StringToField(mstrEmpresaDes)
            strSQL &= " AND  tblEmpresa.EmpresaRUC = " & StringToField(mstrEmpresaRUC)
            strSQL &= " AND  tblEmpresa.EmpresaId <> " & NumberToField(mlngEmpresaId)
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
