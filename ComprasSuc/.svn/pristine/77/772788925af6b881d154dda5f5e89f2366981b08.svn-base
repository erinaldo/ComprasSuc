Imports System.Data
Imports System.Data.OleDb

Public Class clsCompraFac
   Implements IDisposable

   Private mlngCompraFacId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngFacturaId As Long
   Private mlngCompraId As Long
   Private mdecTipoCambio As Decimal
   Private mdecMontoCompra As Decimal
   Private mdecMontoExento As Decimal
   Private mdecMontoFac As Decimal
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
   Property CompraFacId() As Long
      Get
         Return mlngCompraFacId
      End Get

      Set(ByVal Value As Long)
         mlngCompraFacId = Value
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

   Property FacturaId() As Long
      Get
         Return mlngFacturaId
      End Get

      Set(ByVal Value As Long)
         mlngFacturaId = Value
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

   Property TipoCambio() As Decimal
      Get
         Return mdecTipoCambio
      End Get

      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

   Property MontoCompra() As Decimal
      Get
         Return mdecMontoCompra
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoCompra = Value
      End Set
   End Property

   Property MontoExento() As Decimal
      Get
         Return mdecMontoExento
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoExento = Value
      End Set
   End Property

   Property MontoFac() As Decimal
      Get
         Return mdecMontoFac
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoFac = Value
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
      Cantidad = 4
      GridCompra = 5
      FacturaProveedorMov = 6
      NRO_FACTURA_COMPRA = 7
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 2
      Report = 3
      FacturaId = 4
      GridCompra = 5
      CompraId = 6
      FacturaProveedorMov = 7
      FacturaProveedorMovFecha = 8
      NRO_FACTURA_COMPRA = 9
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompraFacId = 1
      Grid = 2
      Report = 3
      GridCompra = 4
      CompraId = 5
      FechaFacturaDESC = 6
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      MontoCompra = 1
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
   End Enum

   Public Enum RowCountFilters As Byte
      All = 0
   End Enum

   Public Enum RowSumFilters As Byte
      Cantidad = 1
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
   Private mintRowSumFilter As RowSumFilters

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

   Property RowSumFilter() As RowSumFilters
      Get
         Return mintRowSumFilter
      End Get

      Set(ByVal Value As RowSumFilters)
         mintRowSumFilter = Value
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
      mstrTableName = "tblCompraFac"
      mstrClassName = "clsCompraFac"

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
      mlngCompraFacId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngFacturaId = 0
      mlngCompraId = 0
      mdecTipoCambio = 0
      mdecMontoCompra = 0
      mdecMontoExento = 0
      mdecMontoFac = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblCompraFac.CompraFacId,  "
            strSQL &= "    tblCompraFac.EmpresaId,  "
            strSQL &= "    tblCompraFac.GestionId,  "
            strSQL &= "    tblCompraFac.FacturaId,  "
            strSQL &= "    tblCompraFac.CompraId,  "
            strSQL &= "    tblCompraFac.TipoCambio,  "
            strSQL &= "    tblCompraFac.MontoCompra,  "
            strSQL &= "    tblCompraFac.MontoExento,  "
            strSQL &= "    tblCompraFac.MontoFac,  "
            strSQL &= "    tblCompraFac.sLastUpdate_id,  "
            strSQL &= "    tblCompraFac.dtLastUpdate_dt,  "
            strSQL &= "    tblCompraFac.iConcurrency_id  "
            strSQL &= " FROM tblCompraFac "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCompraFac.CompraFacId  "
            strSQL &= " FROM tblCompraFac "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCompraFac.CompraFacId,  "
            strSQL &= "    tblCompraFac.EmpresaId,  "
            strSQL &= "    tblCompraFac.FacturaId,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= " FROM tblCompraFac"

         Case SelectFilters.Report

         Case SelectFilters.GridCompra
            strSQL = " SELECT  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.FacturaFecha,  "
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.NroRUC,  "
            strSQL &= "    tblFactura.RegRUCDes,  "
            strSQL &= "    tblFactura.NroAutorizacion,  "
            strSQL &= "    tblFactura.CodControl,  "
            strSQL &= "    tblFactura.FacturaMonto,  "
            strSQL &= "    tblFactura.Exento,  "
            strSQL &= "    tblFactura.IceIehd,  "
            ''strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As Neto,  "
            ''strSQL &= "    tblFactura.IVA,  "
            ''strSQL &= "    (tblFactura.FacturaMonto - tblFactura.IVA) As ImporteIva  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As SubTotal,  "
            strSQL &= "    tblFactura.Descuento,  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd + tblFactura.Descuento)) As Neto,  "
            strSQL &= "    tblFactura.IVA,  "
            strSQL &= "    ((tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd + tblFactura.Descuento)) - tblFactura.IVA) As ImporteIva  "
            strSQL &= " FROM tblFactura, tblCompraFac "

         Case SelectFilters.FacturaProveedorMov
            strSQL = " SELECT "
            strSQL &= "    comProveedor.ProveedorId,"
            strSQL &= "    comProveedor.ProveedorDes,"
            strSQL &= "    comCompra.CompraId,"
            strSQL &= "    comCompra.Fecha,"
            strSQL &= "    comCompra.CompraNro,"
            strSQL &= "    tblFactura.FacturaId,"
            strSQL &= "    tblFactura.FacturaFecha,"
            strSQL &= "    tblFactura.FacturaNro,"
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.RegRUCDes,"
            strSQL &= "    tblFactura.NroRUC,"
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCompra.TipoCambio,"
            strSQL &= "    comCompra.MontoBru,"
            strSQL &= "    tblFactura.FacturaMonto,"
            strSQL &= "    tblEstado.EstadoId,"
            strSQL &= "    tblEstado.EstadoDes"
            strSQL &= " FROM 	tblCompraFac, tblFactura, comCompra, comProveedor, tblMoneda, tblEstado "

         Case SelectFilters.NRO_FACTURA_COMPRA
            strSQL = " SELECT  "
            strSQL &= "    tblCompraFac.CompraFacId,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.FacturaNro  "
            strSQL &= " FROM tblCompraFac, comCompra, tblFactura  "

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
            strSQL = " WHERE  tblCompraFac.CompraFacId = " & NumberToField(mlngCompraFacId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompraFac.FacturaId = " & NumberToField(mlngFacturaId)
            strSQL &= " AND  tblCompraFac.CompraId = comCompra.CompraId "

         Case WhereFilters.Report

         Case WhereFilters.FacturaId
            strSQL = " WHERE  tblCompraFac.FacturaId = " & NumberToField(mlngFacturaId)

         Case WhereFilters.GridCompra
            strSQL = " WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            ''strSQL &= " AND  tblCompraFac.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompraFac.CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND  tblFactura.FacturaId = tblCompraFac.FacturaId "
            strSQL &= " AND  tblFactura.FacturaId <> 0 "

         Case WhereFilters.CompraId
            strSQL = " WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            ''strSQL &= " AND  tblCompraFac.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompraFac.CompraId = " & NumberToField(mlngCompraId)

         Case WhereFilters.FacturaProveedorMov
            strSQL = " WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompraFac.FacturaId = tblFactura.FacturaId "
            strSQL &= " AND  tblCompraFac.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblFactura.EstadoId = tblEstado.EstadoId "

            If mlngCompraFacId = 0 Then
               strSQL &= " AND tblFactura.RegRUCId <> 1 "
               strSQL &= " AND tblFactura.RegRUCId <> 2 "
               strSQL &= " AND tblFactura.RegRUCId <> 3 "
            End If
            strSQL &= " AND  comProveedor.ProveedorId = " & NumberToField(mlngCompraId)
            If mdecMontoFac > 0 Then
               strSQL &= " AND  comCompra.SucursalId = " & NumberToField(mdecMontoFac)
            End If

         Case WhereFilters.FacturaProveedorMovFecha
            strSQL = " WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompraFac.FacturaId = tblFactura.FacturaId "
            strSQL &= " AND  tblCompraFac.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblFactura.EstadoId = tblEstado.EstadoId "

            If mlngCompraFacId = 0 Then
               strSQL &= " AND tblFactura.RegRUCId <> 1 "
               strSQL &= " AND tblFactura.RegRUCId <> 2 "
               strSQL &= " AND tblFactura.RegRUCId <> 3 "
            End If

            strSQL &= " AND  tblFactura.FacturaFecha >= " & DateToField(mstrLastUpdateId)
            strSQL &= " AND  tblFactura.FacturaFecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  comProveedor.ProveedorId = " & NumberToField(mlngCompraId)
            If mdecMontoFac > 0 Then
               strSQL &= " AND  comCompra.SucursalId = " & NumberToField(mdecMontoFac)
            End If

         Case WhereFilters.NRO_FACTURA_COMPRA
            strSQL = " WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            ''strSQL &= " AND  tblCompraFac.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompraFac.CompraId = comCompra.CompraId "
            strSQL &= " AND  tblCompraFac.FacturaId = tblFactura.FacturaId "
            strSQL &= " AND  tblFactura.FacturaId <> 0 "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompraFacId
            strSQL = " ORDER BY tblCompraFac.CompraFacId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblCompraFac.CompraFacId "

         Case OrderByFilters.GridCompra
            strSQL = " ORDER BY tblFactura.FacturaId "

         Case OrderByFilters.Report


         Case OrderByFilters.CompraId
            strSQL = " ORDER BY tblCompraFac.CompraId "

         Case OrderByFilters.FechaFacturaDESC
            strSQL = " ORDER BY tblFactura.FacturaFecha DESC "

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

   Private Function RowSumSQL() As String
      Dim strSQL As String

      Select Case mintRowSumFilter
         Case RowSumFilters.Cantidad
            strSQL = "SELECT Sum(Cantidad) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO tblCompraFac ("
            strSQL &= "CompraFacId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "FacturaId, "
            strSQL &= "CompraId, "
            strSQL &= "TipoCambio, "
            strSQL &= "MontoCompra, "
            strSQL &= "MontoExento, "
            strSQL &= "MontoFac, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompraFacId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngFacturaId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= DecimalToField(mdecMontoCompra) & ", "
            strSQL &= DecimalToField(mdecMontoExento) & ", "
            strSQL &= DecimalToField(mdecMontoFac) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCompraFac SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "FacturaId = " & NumberToField(mlngFacturaId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "MontoCompra = " & DecimalToField(mdecMontoCompra) & ", "
            strSQL &= "MontoExento = " & DecimalToField(mdecMontoExento) & ", "
            strSQL &= "MontoFac = " & DecimalToField(mdecMontoFac) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompraFacId = " & NumberToField(mlngCompraFacId) & " "

         Case UpdateFilters.MontoCompra
            strSQL = " UPDATE tblCompraFac SET"
            strSQL &= "MontoCompra = " & DecimalToField(mdecMontoCompra) & ", "
            strSQL &= "MontoExento = " & DecimalToField(mdecMontoExento) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE CompraFacId = " & NumberToField(mlngCompraFacId)
            strSQL &= " AND GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND EmpresaId = " & NumberToField(mlngEmpresaId)

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
               mlngCompraFacId = ToLong(oDataRow("CompraFacId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngFacturaId = ToLong(oDataRow("FacturaId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mdecMontoCompra = ToDecimal(oDataRow("MontoCompra"))
               mdecMontoExento = ToDecimal(oDataRow("MontoExento"))
               mdecMontoFac = ToDecimal(oDataRow("MontoFac"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompraFacId = ToLong(oDataRow("CompraFacId"))

            Case SelectFilters.Cantidad
               mlngCompraFacId = ToLong(oDataRow("CompraFacId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompraFacId = TableIDGet(mstrTableName, "CompraFacId", moConnection)

         If mlngCompraFacId = -1 Then
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

      If mlngGestionId = 0 Then
         strMsg &= "Gestion Inválida" & vbCrLf
      End If

      If mlngFacturaId = 0 Then
         strMsg &= "Seleccione el Tipo de CompraFacrobante" & vbCrLf
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
         'strSQL &= " FROM tblCompraFac "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompraFac.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
         'Else
         '   strSQL &= " WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompraFac.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
         '   strSQL &= " AND  tblCompraFac.CompraFacId <> " & NumberToField(mlngCompraFacId)
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

   Public Function RowSum() As Decimal
      Dim oCommand As OleDbCommand
      Dim decRecordsAffected As Decimal

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowSumSQL()
         oCommand.Connection = moConnection

         decRecordsAffected = ToDecimal(oCommand.ExecuteScalar)

         Return decRecordsAffected

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
