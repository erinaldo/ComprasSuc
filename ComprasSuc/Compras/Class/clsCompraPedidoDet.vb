Imports System.Data
Imports System.Data.OleDb

Public Class clsCompraPedidoDet
   Implements IDisposable

   Private mlngCompraPedidoDetId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngCompraId As Long
   Private mlngPedCompraId As Long
   Private mlngItemId As Long
   Private mdecCantidad As Decimal
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
   Property CompraPedidoDetId() As Long
      Get
         Return mlngCompraPedidoDetId
      End Get

      Set(ByVal Value As Long)
         mlngCompraPedidoDetId = Value
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

   Property PedCompraId() As Long
      Get
         Return mlngPedCompraId
      End Get

      Set(ByVal Value As Long)
         mlngPedCompraId = Value
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

   Property Cantidad() As Decimal
      Get
         Return mdecCantidad
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidad = Value
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
      PEDIDO_Compra = 3
      PedidoItemComprados = 4
      NRO_PEDIDO_CompraId = 5
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      GestionId = 2
      LIKEGestionId = 3
      Grid = 4
      CompraId = 5
      PedidoCompraItemId = 6
      PEDIDO_Compra = 7
      PedidoItemComprados = 8
      NRO_PEDIDO_CompraId = 9
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompraPedidoDetId = 1
      GestionId = 2
      Grid = 3
      FechaCompra = 4
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      PedidoCompraItemId = 1
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
      mstrTableName = "comCompraPedidoDet"
      mstrClassName = "clsCompraPedidoDet"

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
      mlngCompraPedidoDetId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngCompraId = 0
      mlngPedCompraId = 0
      mlngItemId = 0
      mdecCantidad = 0
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
            strSQL &= "    comCompraPedidoDet.CompraPedidoDetId,  "
            strSQL &= "    comCompraPedidoDet.EmpresaId,  "
            strSQL &= "    comCompraPedidoDet.GestionId,  "
            strSQL &= "    comCompraPedidoDet.CompraId,  "
            strSQL &= "    comCompraPedidoDet.PedCompraId,  "
            strSQL &= "    comCompraPedidoDet.ItemId,  "
            strSQL &= "    comCompraPedidoDet.Cantidad,  "
            strSQL &= "    comCompraPedidoDet.EstadoId,  "
            strSQL &= "    comCompraPedidoDet.sLastUpdate_id,  "
            strSQL &= "    comCompraPedidoDet.dtLastUpdate_dt,  "
            strSQL &= "    comCompraPedidoDet.iConcurrency_id  "
            strSQL &= " FROM comCompraPedidoDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comCompraPedidoDet.CompraPedidoDetId,  "
            strSQL &= "    comCompraPedidoDet.EmpresaId,  "
            strSQL &= "    comCompraPedidoDet.GestionId  "
            strSQL &= " FROM comCompraPedidoDet "

         Case SelectFilters.PEDIDO_Compra
            strSQL = " SELECT  "
            strSQL &= "  comCompraPedidoDet.PedCompraId ,  "
            strSQL &= "  comCompraPedidoDet.CompraId,  "
            strSQL &= "  comPedCompra.PedCompraNro  "
            strSQL &= " FROM comCompraPedidoDet , comPedCompra "

         Case SelectFilters.PedidoItemComprados
            strSQL = " SELECT  "
            strSQL &= "  comCompraPedidoDet.CompraPedidoDetId,  "
            strSQL &= "  comCompraPedidoDet.PedCompraId,  "
            strSQL &= "  comCompraPedidoDet.CompraId,  "
            strSQL &= "  comCompra.Fecha,  "
            strSQL &= "  comCompra.CompraNro,  "
            strSQL &= "  comCompra.CompraOrden,  "
            strSQL &= "  comCompra.CompraDes,  "
            strSQL &= "  comCompra.ProveedorId,  "
            strSQL &= "  comProveedor.ProveedorDes,  "
            strSQL &= "  comCompraPedidoDet.ItemId,  "
            strSQL &= "  comCompraPedidoDet.Cantidad, "
            strSQL &= "  invMedida.MedidaId,  "
            strSQL &= "  invMedida.MedidaDes,  "
            strSQL &= "  comCompraDet.PrecioOrg, "
            strSQL &= "  comCompraDet.CompraDetDes "
            strSQL &= " FROM comCompraPedidoDet, comCompra, comProveedor, comCompraDet, invMedida  "

         Case SelectFilters.NRO_PEDIDO_CompraId
            strSQL = " SELECT DISTINCT "
            strSQL &= "  comCompraPedidoDet.PedCompraId ,  "
            strSQL &= "  comCompraPedidoDet.CompraId,  "
            strSQL &= "  comPedCompra.PedCompraNro  "
            strSQL &= " FROM comCompraPedidoDet , comPedCompra "

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
            strSQL = " WHERE  comCompraPedidoDet.CompraPedidoDetId = " & NumberToField(mlngCompraPedidoDetId)

         Case WhereFilters.GestionId
            strSQL = " WHERE  comCompraPedidoDet.GestionId = " & StringToField(mlngGestionId)

         Case WhereFilters.LIKEGestionId
            strSQL = " WHERE  comCompraPedidoDet.GestionId LIKE " & StringToField(mlngGestionId & LikeOperator)

         Case WhereFilters.CompraId
            strSQL = " WHERE  comCompraPedidoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraPedidoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraPedidoDet.CompraId = " & NumberToField(mlngCompraId)

         Case WhereFilters.PedidoCompraItemId
            strSQL = " WHERE  comCompraPedidoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraPedidoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraPedidoDet.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " AND  comCompraPedidoDet.CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND  comCompraPedidoDet.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.PEDIDO_Compra
            strSQL = " WHERE  comCompraPedidoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraPedidoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraPedidoDet.PedCompraId = comPedCompra.PedCompraId "

         Case WhereFilters.PedidoItemComprados
            strSQL = " WHERE  comCompraPedidoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraPedidoDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngPedCompraId <> 0 Then
               strSQL &= " AND comCompraPedidoDet.PedCompraId = " & NumberToField(mlngPedCompraId)
            End If
            strSQL &= " AND  comCompraPedidoDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  comCompraPedidoDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCompraPedidoDet.ItemId = comCompraDet.ItemId "
            strSQL &= " AND  comCompraPedidoDet.CompraId = comCompraDet.CompraId "
            strSQL &= " AND  comCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompra.CompraId = comCompraDet.CompraId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  comCompraPedidoDet.EstadoId <> " & clsEstado.ANULADO

         Case WhereFilters.NRO_PEDIDO_CompraId
            strSQL = " WHERE  comCompraPedidoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraPedidoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraPedidoDet.CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND  comCompraPedidoDet.PedCompraId = comPedCompra.PedCompraId "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompraPedidoDetId
            strSQL = " ORDER BY comCompraPedidoDet.CompraPedidoDetId"

         Case OrderByFilters.FechaCompra
            strSQL = " ORDER BY comCompra.Fecha DESC"


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
            strSQL = "INSERT INTO comCompraPedidoDet ("
            strSQL &= "CompraPedidoDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "CompraId, "
            strSQL &= "PedCompraId, "
            strSQL &= "ItemId, "
            strSQL &= "Cantidad, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompraPedidoDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= NumberToField(mlngPedCompraId) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= DecimalToField(mdecCantidad) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comCompraPedidoDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "PedCompraId = " & NumberToField(mlngPedCompraId) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "Cantidad = " & DecimalToField(mdecCantidad) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompraPedidoDetId = " & NumberToField(mlngCompraPedidoDetId) & " "

         Case UpdateFilters.PedidoCompraItemId
            strSQL = "UPDATE comCompraPedidoDet SET "
            strSQL &= "Cantidad = " & DecimalToField(mdecCantidad) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= WhereFilterGet()

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
               mlngCompraPedidoDetId = ToLong(oDataRow("CompraPedidoDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mlngPedCompraId = ToLong(oDataRow("PedCompraId"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mdecCantidad = ToDecimal(oDataRow("Cantidad"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompraPedidoDetId = ToLong(oDataRow("CompraPedidoDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompraPedidoDetId = TableIDGet(mstrTableName, "CompraPedidoDetId", moConnection)

         If mlngCompraPedidoDetId = -1 Then
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
         '   strSQL &= " AND  tblPlan.CompraPedidoDetId = " & NumberToField(mlngCompraPedidoDetId)
         'Else
         '   strSQL &= " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)
         '   strSQL &= " AND  tblPlan.CompraPedidoDetId = " & NumberToField(mlngCompraPedidoDetId)
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
