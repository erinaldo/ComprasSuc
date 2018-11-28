Imports System.Data
Imports System.Data.OleDb

Public Class clsPagoDet
   Implements IDisposable

   Private mlngPagoDetId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoPagoId As Long
   Private mlngPagoId As Long
   Private mlngCompraId As Long
   Private mlngCreditoId As Long
   Private mlngCreditoDetId As Long
   Private mlngProveedorId As Long
   Private mstrFecha As String
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mdecCapitalOrg As Decimal
   Private mdecInteresOrg As Decimal
   Private mdecCapitalAmo As Decimal
   Private mdecInteresAmo As Decimal
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
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
   Property PagoDetId() As Long
      Get
         Return mlngPagoDetId
      End Get

      Set(ByVal Value As Long)
         mlngPagoDetId = Value
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

   Property TipoPagoId() As Long
      Get
         Return mlngTipoPagoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoPagoId = Value
      End Set
   End Property

   Property PagoId() As Long
      Get
         Return mlngPagoId
      End Get

      Set(ByVal Value As Long)
         mlngPagoId = Value
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

   Property CreditoId() As Long
      Get
         Return mlngCreditoId
      End Get

      Set(ByVal Value As Long)
         mlngCreditoId = Value
      End Set
   End Property

   Property CreditoDetId() As Long
      Get
         Return mlngCreditoDetId
      End Get

      Set(ByVal Value As Long)
         mlngCreditoDetId = Value
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

   Property Fecha() As String
      Get
         Return mstrFecha
      End Get

      Set(ByVal Value As String)
         mstrFecha = Value
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

   Property CapitalOrg() As Decimal
      Get
         Return mdecCapitalOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecCapitalOrg = Value
      End Set
   End Property

   Property InteresOrg() As Decimal
      Get
         Return mdecInteresOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecInteresOrg = Value
      End Set
   End Property

   Property CapitalAmo() As Decimal
      Get
         Return mdecCapitalAmo
      End Get

      Set(ByVal Value As Decimal)
         mdecCapitalAmo = Value
      End Set
   End Property

   Property InteresAmo() As Decimal
      Get
         Return mdecInteresAmo
      End Get

      Set(ByVal Value As Decimal)
         mdecInteresAmo = Value
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

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
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
      COMPRA_DISTINCT = 4
      CREDITO_DISTINCT = 5

      GridContado = 7
      NRO_CREDITO_COMPRA = 8
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      AlmacenId = 6
      GestionId = 7
      PagoId = 8
      COMPRA_DISTINCT = 9
      CREDITO_DISTINCT = 10

      CreditoDetId = 11
      CreditoDetIdFecha = 12
      NRO_CREDITO_COMPRA = 13
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PagoDetId = 1
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
      mstrTableName = "comPagoDet"
      mstrClassName = "clsPagoDet"

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
      mlngPagoDetId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngTipoPagoId = 0
      mlngPagoId = 0
      mlngCompraId = 0
      mlngCreditoId = 0
      mlngCreditoDetId = 0
      mlngProveedorId = 0
      mstrFecha = ""
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mdecCapitalOrg = 0
      mdecInteresOrg = 0
      mdecCapitalAmo = 0
      mdecInteresAmo = 0
      mlngCentroCostoId = 0
      mlngSucursalId = 0
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
            strSQL &= "    comPagoDet.PagoDetId,  "
            strSQL &= "    comPagoDet.EmpresaId,  "
            strSQL &= "    comPagoDet.GestionId,  "
            strSQL &= "    comPagoDet.TipoPagoId,  "
            strSQL &= "    comPagoDet.PagoId,  "
            strSQL &= "    comPagoDet.CompraId,  "
            strSQL &= "    comPagoDet.CreditoId,  "
            strSQL &= "    comPagoDet.CreditoDetId,  "
            strSQL &= "    comPagoDet.ProveedorId,  "
            strSQL &= "    comPagoDet.Fecha,  "
            strSQL &= "    comPagoDet.MonedaId,  "
            strSQL &= "    comPagoDet.TipoCambio,  "
            strSQL &= "    comPagoDet.CapitalOrg,  "
            strSQL &= "    comPagoDet.InteresOrg,  "
            strSQL &= "    comPagoDet.CapitalAmo,  "
            strSQL &= "    comPagoDet.InteresAmo,  "
            strSQL &= "    comPagoDet.CentroCostoId,  "
            strSQL &= "    comPagoDet.SucursalId,  "
            strSQL &= "    comPagoDet.EstadoId,  "
            strSQL &= "    comPagoDet.sLastUpdate_id,  "
            strSQL &= "    comPagoDet.dtLastUpdate_dt,  "
            strSQL &= "    comPagoDet.iConcurrency_id  "
            strSQL &= " FROM comPagoDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comPagoDet.PagoDetId  "
            strSQL &= " FROM comPagoDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    comPagoDet.PagoDetId,  "
            strSQL &= "    comPagoDet.PagoId,  "
            strSQL &= "    comCreditoDet.Fecha,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    comCreditoDet.CreditoDetId,  "
            strSQL &= "    comCreditoDet.CuotaNro,  "
            strSQL &= "    comPagoDet.CapitalOrg,  "
            strSQL &= "    comPagoDet.InteresOrg,  "
            strSQL &= "    comPagoDet.CapitalAmo,  "
            strSQL &= "    comPagoDet.InteresAmo,  "
            strSQL &= "    (comPagoDet.CapitalAmo + comPagoDet.InteresAmo) As Importe, "
            strSQL &= "    (comPagoDet.CapitalOrg - comPagoDet.CapitalAmo) As Saldo "
            strSQL &= " FROM comPagoDet, comCompra, comCredito, comCreditoDet "

         Case SelectFilters.GridContado
            strSQL = " SELECT  "
            strSQL &= "    comPagoDet.PagoDetId,  "
            strSQL &= "    comPagoDet.PagoId,  "
            'strSQL &= "    comCreditoDet.Fecha,  "
            strSQL &= "    comCompra.Fecha,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    comCreditoDet.CreditoDetId,  "
            strSQL &= "    comCreditoDet.CuotaNro,  "
            strSQL &= "    comPagoDet.CapitalOrg,  "
            strSQL &= "    comPagoDet.InteresOrg,  "
            strSQL &= "    comPagoDet.CapitalAmo,  "
            strSQL &= "    comPagoDet.InteresAmo,  "
            strSQL &= "    (comPagoDet.CapitalAmo + comPagoDet.InteresAmo) As Importe, "
            strSQL &= "    (comPagoDet.CapitalOrg - comPagoDet.CapitalAmo) As Saldo "
            strSQL &= " FROM comPagoDet, comCompra, comCredito, comCreditoDet "

         Case SelectFilters.COMPRA_DISTINCT
            strSQL = " SELECT DISTINCT "
            strSQL &= "    comPagoDet.CompraId,  "
            strSQL &= "    comCompra.CompraNro  "
            strSQL &= " FROM comPagoDet, comCompra "

         Case SelectFilters.CREDITO_DISTINCT
            strSQL = " SELECT DISTINCT "
            strSQL &= "    comPagoDet.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro  "
            strSQL &= " FROM comPagoDet, comCredito "

         Case SelectFilters.NRO_CREDITO_COMPRA
            strSQL = " SELECT  "
            strSQL &= "    comPagoDet.PagoDetId,  "
            strSQL &= "    comPagoDet.PagoId,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro  "
            strSQL &= " FROM comPagoDet, comCompra, comCredito  "

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
            strSQL = " WHERE  comPagoDet.PagoDetId = " & NumberToField(mlngPagoDetId)
            strSQL &= " FROM comPagoDet, , com, com "

         Case WhereFilters.Grid
            strSQL = " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPagoDet.PagoId = " & NumberToField(mlngPagoId)
            strSQL &= " AND  comPagoDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comPagoDet.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comPagoDet.CreditoDetId = comCreditoDet.CreditoDetId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.GestionId
            strSQL = " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPagoDet.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.PagoId
            strSQL = " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPagoDet.PagoId = " & NumberToField(mlngPagoId)

         Case WhereFilters.COMPRA_DISTINCT
            strSQL = " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPagoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPagoDet.CompraId = comCompra.CompraId "

         Case WhereFilters.CREDITO_DISTINCT
            strSQL = " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPagoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPagoDet.CreditoId = comCredito.CreditoId "

         Case WhereFilters.CreditoDetId
            strSQL = " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPagoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPagoDet.CreditoId =  " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comPagoDet.CreditoDetId =  " & NumberToField(mlngCreditoDetId)
            strSQL &= " AND  comPagoDet.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.CreditoDetIdFecha
            strSQL = " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPagoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPagoDet.CreditoId =  " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comPagoDet.CreditoDetId =  " & NumberToField(mlngCreditoDetId)
            'strSQL &= " AND  comPagoDet.EstadoId <> " & NumberToField(mlngEstadoId)
            'strSQL &= " AND  comPagoDet.Fecha >= " & DateToField(mstrFecha)
            'strSQL &= " AND  comPagoDet.Fecha <= " & DateToField(mstrLastUpdateDate)

         Case WhereFilters.NRO_CREDITO_COMPRA
            strSQL = " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPagoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPagoDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comPagoDet.CreditoId = comCredito.CreditoId "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PagoDetId
            strSQL = " ORDER BY comPagoDet.PagoDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comPagoDet.PagoDetId "

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
            strSQL = "INSERT INTO comPagoDet ("
            strSQL &= "PagoDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoPagoId, "
            strSQL &= "PagoId, "
            strSQL &= "CompraId, "
            strSQL &= "CreditoId, "
            strSQL &= "CreditoDetId, "
            strSQL &= "ProveedorId, "
            strSQL &= "Fecha, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "CapitalOrg, "
            strSQL &= "InteresOrg, "
            strSQL &= "CapitalAmo, "
            strSQL &= "InteresAmo, "
            strSQL &= "CentroCostoId, "
            strSQL &= "SucursalId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPagoDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoPagoId) & ", "
            strSQL &= NumberToField(mlngPagoId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= NumberToField(mlngCreditoId) & ", "
            strSQL &= NumberToField(mlngCreditoDetId) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= DecimalToField(mdecCapitalOrg) & ", "
            strSQL &= DecimalToField(mdecInteresOrg) & ", "
            strSQL &= DecimalToField(mdecCapitalAmo) & ", "
            strSQL &= DecimalToField(mdecInteresAmo) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comPagoDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoPagoId = " & NumberToField(mlngTipoPagoId) & ", "
            strSQL &= "PagoId = " & NumberToField(mlngPagoId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "CreditoId = " & NumberToField(mlngCreditoId) & ", "
            strSQL &= "CreditoDetId = " & NumberToField(mlngCreditoDetId) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "CapitalOrg = " & DecimalToField(mdecCapitalOrg) & ", "
            strSQL &= "InteresOrg = " & DecimalToField(mdecInteresOrg) & ", "
            strSQL &= "CapitalAmo = " & DecimalToField(mdecCapitalAmo) & ", "
            strSQL &= "InteresAmo = " & DecimalToField(mdecInteresAmo) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PagoDetId = " & NumberToField(mlngPagoDetId) & " "

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
               mlngPagoDetId = ToLong(oDataRow("PagoDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoPagoId = ToLong(oDataRow("TipoPagoId"))
               mlngPagoId = ToLong(oDataRow("PagoId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mlngCreditoId = ToLong(oDataRow("CreditoId"))
               mlngCreditoDetId = ToLong(oDataRow("CreditoDetId"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mdecCapitalOrg = ToDecimal(oDataRow("CapitalOrg"))
               mdecInteresOrg = ToDecimal(oDataRow("InteresOrg"))
               mdecCapitalAmo = ToDecimal(oDataRow("CapitalAmo"))
               mdecInteresAmo = ToDecimal(oDataRow("InteresAmo"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPagoDetId = ToLong(oDataRow("PagoDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPagoDetId = TableIDGet(mstrTableName, "PagoDetId", moConnection)

         If mlngPagoDetId = -1 Then
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

      'If mlngCreditoId = 0 Then
      '   strMsg &= "Credito Inválido" & vbCrLf
      'End If

      'If mlngCreditoDetId = 0 Then
      '   strMsg &= "Detalle Credito Inválido" & vbCrLf
      'End If

      If mlngProveedorId = 0 Then
         strMsg &= "Proveedor Inválido" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If mdecTipoCambio <= 0 Then
         strMsg &= "Tipo Cambio Inválido" & vbCrLf
      End If

      'If mdecCapitalOrg <= 0 Then
      '   strMsg &= "CapitalOrg Inválido" & vbCrLf
      'End If

      'If mdecCapitalAmo <= 0 Then
      '   strMsg &= "CapitalOrg Amortizado Inválido" & vbCrLf
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
         'strSQL &= " FROM comPagoDet "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comPagoDet.GestionId = " & NumberToField(mlngGestionId)
         'Else
         '   strSQL &= " WHERE  comPagoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comPagoDet.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  comPagoDet.PagoDetId <> " & NumberToField(mlngPagoDetId)
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
