Imports System.Data
Imports System.Data.OleDb

Public Class clsCompra
   Implements IDisposable

   Private mlngCompraId As Long
   Private mlngEmpresaId As Long
   Private mlngCompraNro As Long
   Private mstrFecha As String
   Private mlngAlmacenId As Long
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mstrCompraOrden As String
   Private mstrCompraDes As String
   Private mstrCompraObs As String
   Private mlngTipoPagoId As Long
   Private mdecMontoOrg As Decimal
   Private mdecMontoCos As Decimal
   Private mdecMontoAnt As Decimal
   Private mdecMontoDes As Decimal
   Private mdecMontoRec As Decimal
   Private mdecMontoOtro As Decimal
   Private mdecMontoNet As Decimal
   Private mdecMontoLiq As Decimal
   Private mdecMontoBru As Decimal
   Private mdecMontoPorFac As Decimal
   Private mlngFacturaId As Long
   Private mlngPolizaId As Long
   Private mdecPorIVA As Decimal
   Private mdecPorPoliza As Decimal
   Private mlngGestionId As Long
   Private mlngPlanId As Long
   Private mlngPedCompraId As Long
   Private mlngCreditoId As Long
   Private mbytConFac As Byte
   Private mbytSinFac As Byte
   Private mbytFacturaDif As Byte
   Private mdecMontoFac As Decimal
   Private mlngTipoRetencionId As Long
   Private mdecFactDifExento As Decimal
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mlngNotaId As Long
   Private mlngCompId As Long
   Private mlngAppId As Long
   Private mlngTipoDocumentoId As Long
   Private mlngDocumentoId As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   Private moConnection As OleDbConnection
   Private moDataAdapter As OleDbDataAdapter
   Private moDataSet As DataSet
   Private mintRow As Integer
   Private mintRowsCount As Integer
   Private mintRowsMax As Integer

   Private mstrConnectionString As String
   Private mstrTableName As String
   Private mstrClassName As String
   Private mstrSQL As String

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CompraId() As Long
      Get
         Return mlngCompraId
      End Get

      Set(ByVal Value As Long)
         mlngCompraId = Value
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

   Property CompraNro() As Long
      Get
         Return mlngCompraNro
      End Get

      Set(ByVal Value As Long)
         mlngCompraNro = Value
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

   Property AlmacenId() As Long
      Get
         Return mlngAlmacenId
      End Get

      Set(ByVal Value As Long)
         mlngAlmacenId = Value
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

   Property CompraOrden() As String
      Get
         Return mstrCompraOrden
      End Get

      Set(ByVal Value As String)
         mstrCompraOrden = Value
      End Set
   End Property

   Property CompraDes() As String
      Get
         Return mstrCompraDes
      End Get

      Set(ByVal Value As String)
         mstrCompraDes = Value
      End Set
   End Property

   Property CompraObs() As String
      Get
         Return mstrCompraObs
      End Get

      Set(ByVal Value As String)
         mstrCompraObs = Value
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

   Property MontoOrg() As Decimal
      Get
         Return mdecMontoOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoOrg = Value
      End Set
   End Property

   Property MontoCos() As Decimal
      Get
         Return mdecMontoCos
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoCos = Value
      End Set
   End Property

   Property MontoAnt() As Decimal
      Get
         Return mdecMontoAnt
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoAnt = Value
      End Set
   End Property

   Property MontoDes() As Decimal
      Get
         Return mdecMontoDes
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoDes = Value
      End Set
   End Property

   Property MontoRec() As Decimal
      Get
         Return mdecMontoRec
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoRec = Value
      End Set
   End Property

   Property MontoOtro() As Decimal
      Get
         Return mdecMontoOtro
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoOtro = Value
      End Set
   End Property

   Property MontoNet() As Decimal
      Get
         Return mdecMontoNet
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoNet = Value
      End Set
   End Property

   Property MontoLiq() As Decimal
      Get
         Return mdecMontoLiq
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoLiq = Value
      End Set
   End Property

   Property MontoBru() As Decimal
      Get
         Return mdecMontoBru
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoBru = Value
      End Set
   End Property

   Property MontoPorFac() As Decimal
      Get
         Return mdecMontoPorFac
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoPorFac = Value
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

   Property PolizaId() As Long
      Get
         Return mlngPolizaId
      End Get

      Set(ByVal Value As Long)
         mlngPolizaId = Value
      End Set
   End Property

   Property PorIVA() As Decimal
      Get
         Return mdecPorIVA
      End Get

      Set(ByVal Value As Decimal)
         mdecPorIVA = Value
      End Set
   End Property

   Property PorPoliza() As Decimal
      Get
         Return mdecPorPoliza
      End Get

      Set(ByVal Value As Decimal)
         mdecPorPoliza = Value
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

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
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

   Property CreditoId() As Long
      Get
         Return mlngCreditoId
      End Get

      Set(ByVal Value As Long)
         mlngCreditoId = Value
      End Set
   End Property

   Property ConFac() As Byte
      Get
         Return mbytConFac
      End Get

      Set(ByVal Value As Byte)
         mbytConFac = Value
      End Set
   End Property

   Property SinFac() As Byte
      Get
         Return mbytSinFac
      End Get

      Set(ByVal Value As Byte)
         mbytSinFac = Value
      End Set
   End Property

   Property FacturaDif() As Byte
      Get
         Return mbytFacturaDif
      End Get

      Set(ByVal Value As Byte)
         mbytFacturaDif = Value
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

   Property TipoRetencionId() As Long
      Get
         Return mlngTipoRetencionId
      End Get

      Set(ByVal Value As Long)
         mlngTipoRetencionId = Value
      End Set
   End Property

   Property FactDifExento() As Decimal
      Get
         Return mdecFactDifExento
      End Get

      Set(ByVal Value As Decimal)
         mdecFactDifExento = Value
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

   Property NotaId() As Long
      Get
         Return mlngNotaId
      End Get

      Set(ByVal Value As Long)
         mlngNotaId = Value
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

   Property AppId() As Long
      Get
         Return mlngAppId
      End Get

      Set(ByVal Value As Long)
         mlngAppId = Value
      End Set
   End Property

   Property TipoDocumentoId() As Long
      Get
         Return mlngTipoDocumentoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoDocumentoId = Value
      End Set
   End Property

   Property DocumentoId() As Long
      Get
         Return mlngDocumentoId
      End Get

      Set(ByVal Value As Long)
         mlngDocumentoId = Value
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

   Property RowsMax() As Integer
      Get
         Return mintRowsMax
      End Get

      Set(ByVal Value As Integer)
         mintRowsMax = Value
      End Set
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
      GridContado = 4
      GridCheck = 5
      MovDiario = 6
      FlujoCaja = 7
      GRID_IMPORT = 8
      FacturaDistinct = 9
      GridFacturar = 10
        GridFacturaMultiple = 11
        ComprasProveedor = 12
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      AlmacenId = 6
      GestionId = 7
      GridCredito = 8
      GridContado = 9
      CreditoId = 10
      GridCreditoId = 11
      GridDevCompra = 12
      MovDiario = 13
      CompraOrden = 14
      ProveedorId = 15
      FlujoCaja = 16
      FlujoCajaFecha = 17
      COMPRA_NRO = 18
      GRID_IMPORT = 19
      GridFacturar = 20
      EstadoId_CentroCosto = 21
        GridFacturaMultiple = 22
        ComprasProveedor = 23
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompraId = 1
      Grid = 3
      Report = 4
      CompraDes = 5
      GridContado = 6
      GridFecha = 7
        ProveedorId = 8
        Fecha = 9
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      CREDITOID = 1
      MontoFac = 2
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
   End Enum

   Public Enum RowCountFilters As Byte
      All = 0
      MinId = 1
      MaxId = 2
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
      mstrTableName = "comCompra"
      mstrClassName = "clsCompra"

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
      mlngCompraId = 0
      mlngEmpresaId = 0
      mlngCompraNro = 0
      mstrFecha = ""
      mlngAlmacenId = 0
      mlngProveedorId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mstrCompraOrden = ""
      mstrCompraDes = ""
      mstrCompraObs = ""
      mlngTipoPagoId = 0
      mdecMontoOrg = 0
      mdecMontoCos = 0
      mdecMontoAnt = 0
      mdecMontoDes = 0
      mdecMontoRec = 0
      mdecMontoOtro = 0
      mdecMontoNet = 0
      mdecMontoLiq = 0
      mdecMontoBru = 0
      mdecMontoPorFac = 0
      mlngFacturaId = 0
      mlngPolizaId = 0
      mdecPorIVA = 0
      mdecPorPoliza = 0
      mlngGestionId = 0
      mlngPlanId = 0
      mlngPedCompraId = 0
      mlngCreditoId = 0
      mbytConFac = 0
      mbytSinFac = 0
      mbytFacturaDif = 0
      mdecMontoFac = 0
      mlngTipoRetencionId = 0
      mdecFactDifExento = 0
      mlngCentroCostoId = 0
      mlngSucursalId = 0
      mlngNotaId = 0
      mlngCompId = 0
      mlngAppId = 0
      mlngTipoDocumentoId = 0
      mlngDocumentoId = 0
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
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.EmpresaId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.Fecha,  "
            strSQL &= "    comCompra.AlmacenId,  "
            strSQL &= "    comCompra.ProveedorId,  "
            strSQL &= "    comCompra.MonedaId,  "
            strSQL &= "    comCompra.TipoCambio,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCompra.CompraDes,  "
            strSQL &= "    comCompra.CompraObs,  "
            strSQL &= "    comCompra.TipoPagoId,  "
            strSQL &= "    comCompra.MontoOrg,  "
            strSQL &= "    comCompra.MontoCos,  "
            strSQL &= "    comCompra.MontoAnt,  "
            strSQL &= "    comCompra.MontoDes,  "
            strSQL &= "    comCompra.MontoRec,  "
            strSQL &= "    comCompra.MontoOtro,  "
            strSQL &= "    comCompra.MontoNet,  "
            strSQL &= "    comCompra.MontoLiq,  "
            strSQL &= "    comCompra.MontoBru,  "
            strSQL &= "    comCompra.MontoPorFac,  "
            strSQL &= "    comCompra.FacturaId,  "
            strSQL &= "    comCompra.PolizaId,  "
            strSQL &= "    comCompra.PorIVA,  "
            strSQL &= "    comCompra.PorPoliza,  "
            strSQL &= "    comCompra.GestionId,  "
            strSQL &= "    comCompra.PlanId,  "
            strSQL &= "    comCompra.PedCompraId,  "
            strSQL &= "    comCompra.CreditoId,  "
            strSQL &= "    comCompra.ConFac,  "
            strSQL &= "    comCompra.SinFac,  "
            strSQL &= "    comCompra.FacturaDif,  "
            strSQL &= "    comCompra.MontoFac,  "
            strSQL &= "    comCompra.TipoRetencionId,  "
            strSQL &= "    comCompra.FactDifExento,  "
            strSQL &= "    comCompra.CentroCostoId,  "
            strSQL &= "    comCompra.SucursalId,  "
            strSQL &= "    comCompra.NotaId,  "
            strSQL &= "    comCompra.CompId,  "
            strSQL &= "    comCompra.AppId,  "
            strSQL &= "    comCompra.TipoDocumentoId,  "
            strSQL &= "    comCompra.DocumentoId,  "
            strSQL &= "    comCompra.EstadoId,  "
            strSQL &= "    comCompra.sLastUpdate_id,  "
            strSQL &= "    comCompra.dtLastUpdate_dt,  "
            strSQL &= "    comCompra.iConcurrency_id  "
            strSQL &= " FROM comCompra "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraDes  "
            strSQL &= " FROM comCompra "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            If mintRowsMax > 0 Then strSQL &= " TOP " & NumberToField(mintRowsMax) & "  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.Fecha,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCompra.CompraDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCompra.TipoCambio,  "
            strSQL &= "    comCompra.MontoOrg,  "
            strSQL &= "    comCompra.MontoAnt,  "
            strSQL &= "    comCompra.MontoDes,  "
            strSQL &= "    comCompra.MontoRec,  "
            strSQL &= "    comCompra.MontoOtro,  "
            strSQL &= "    0.0 As MontoRetencion, "
            strSQL &= "    comCompra.MontoBru,  "
            strSQL &= "    comCompra.MontoNet,  "
            strSQL &= "    comCompra.MontoCos, "
            strSQL &= "    comCompra.MontoLiq,  "

            strSQL &= "    ' ' As PedCompraNro,  "
            ''strSQL &= "    comPedCompra.PedCompraId,  "
            ''strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    comCompra.SinFac,  "
            strSQL &= "    comCompra.ConFac,  "
            strSQL &= "    comCompra.sLastUpdate_id,  "
            strSQL &= "    comCompra.FacturaDif,  "
            strSQL &= "    comCompra.FacturaId,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    '0' As FacturaNros,  "
            strSQL &= "    comCompra.TipoRetencionId,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    secApp.AppId,  "
            strSQL &= "    secApp.AppDes,  "
            strSQL &= "    comCompra.TipoDocumentoId,  "
            strSQL &= "    comCompra.DocumentoId,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comCompra, invAlmacen, comProveedor, comTipoPago, tblMoneda, comCredito, invNota, invTipoNota, tblComp, tblTipoComp, tblEstado, tblCentroCosto, tblFactura "
            strSQL &= "    , tblSucursal, secApp "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.Fecha,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCompra.CompraDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCompra.TipoCambio,  "
            strSQL &= "    comCompra.MontoOrg,  "
            strSQL &= "    comCompra.MontoAnt,  "
            strSQL &= "    comCompra.MontoDes,  "
            strSQL &= "    comCompra.MontoRec,  "
            strSQL &= "    comCompra.MontoOtro,  "
            strSQL &= "    0.0 As MontoRetencion, "
            strSQL &= "    comCompra.MontoBru,  "
            strSQL &= "    comCompra.MontoNet,  "
            strSQL &= "    comCompra.MontoCos, "
            strSQL &= "    comCompra.MontoLiq,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    comCompra.SinFac,  "
            strSQL &= "    comCompra.ConFac,  "
            strSQL &= "    comCompra.sLastUpdate_id,  "
            strSQL &= "    comCompra.FacturaDif,  "
            strSQL &= "    comCompra.FacturaId,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    comCompra.TipoRetencionId,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    secApp.AppId,  "
            strSQL &= "    secApp.AppDes,  "
            strSQL &= "    comCompra.TipoDocumentoId,  "
            strSQL &= "    comCompra.DocumentoId,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comCompra, invAlmacen, comProveedor, comTipoPago, tblMoneda, comPedCompra, comCredito, invNota, invTipoNota, tblComp, tblTipoComp, tblEstado, tblCentroCosto, tblFactura "
            strSQL &= "    ,tblSucursal, secApp "

         Case SelectFilters.GridContado
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCompra.Fecha,  "
            strSQL &= "    comCompra.AlmacenId,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCompra.MontoOrg,  "
            strSQL &= "    comCompra.MontoNet,  "
            strSQL &= "    comCompra.MontoLiq,  "
            strSQL &= "    comCompra.MontoBru,  "
            strSQL &= "    comCompra.MontoAnt,  "
            strSQL &= "    comCompra.MontoDes,  "
            strSQL &= "    comCompra.MontoRec,  "
            strSQL &= "    comCompra.MontoOtro,  "
            strSQL &= "    comCompra.TipoCambio,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    comCompra.SinFac,  "
            strSQL &= "    comCompra.ConFac,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comCompra, tblMoneda, comPedCompra, tblEstado, tblCentroCosto "
            strSQL &= "    ,tblSucursal "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.EmpresaId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCompra.Fecha,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.Telefono1,  "
            strSQL &= "    comProveedor.Telefono2,  "
            strSQL &= "    comProveedor.Fax,  "
            strSQL &= "    comProveedor.Email,  "
            strSQL &= "    comProveedor.ContactoDes,  "
            strSQL &= "    comProveedor.ContactoCargo,  "
            strSQL &= "    comProveedor.ContactoCI,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCompra.CompraDes,  "
            strSQL &= "    comCompra.CompraObs,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCompra.TipoCambio,  "
            strSQL &= "    comCompra.MontoAnt,  "
            strSQL &= "    comCompra.MontoBru,  "
            strSQL &= "    comCompra.FacturaId,  "
            strSQL &= "    comCompra.PolizaId,  "
            strSQL &= "    comCompra.CentroCostoId,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    comCompra.TipoRetencionId,  "
            strSQL &= "    comCompra.SucursalId,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "

            strSQL &= "    comCompraDet.CompraDetId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ControlLote,  "
            strSQL &= "    invItem.ControlSerie,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comCompraDet.CompraDetDes,  "
            strSQL &= "    comCompraDet.Cantidad,  "
            strSQL &= "    comCompraDet.PrecioOrg,  "
            strSQL &= "    comCompraDet.PrecioCos,  "
            strSQL &= "    comCompraDet.Importe,  "

            'strSQL &= "    (comCompraDet.Cantidad * comCompraDet.PrecioOrg) As  Importe,  "
            strSQL &= "    (comCompraDet.PrecioRec * comCompraDet.Cantidad ) As ImporteRec,  "
            strSQL &= "    (comCompraDet.PrecioDes * comCompraDet.Cantidad ) As ImporteDes, "
            strSQL &= "    comCompraDet.ImporteBru  "

            strSQL &= " FROM comCompra, invAlmacen, comProveedor, comTipoPago, tblMoneda, comPedCompra, comCredito, invNota, invTipoNota, tblComp, tblTipoComp, tblEstado, comCompraDet, invItem, invMedida "

         Case SelectFilters.MovDiario
            strSQL = " SELECT  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.EmpresaId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.Fecha,  "
            strSQL &= "    comCompra.AlmacenId,  "
            strSQL &= "    comCompra.ProveedorId,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCompra.TipoCambio,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCompra.CompraDes,  "
            strSQL &= "    comCompra.CompraObs,  "
            strSQL &= "    comCompra.TipoPagoId,  "
            strSQL &= "    comCompra.MontoOrg,  "
            strSQL &= "    comCompra.MontoCos,  "
            strSQL &= "    comCompra.MontoAnt,  "
            strSQL &= "    comCompra.MontoDes,  "
            strSQL &= "    comCompra.MontoRec,  "
            strSQL &= "    comCompra.MontoOtro,  "
            strSQL &= "    comCompra.MontoNet,  "
            strSQL &= "    comCompra.MontoLiq,  "
            strSQL &= "    comCompra.MontoBru,  "
            strSQL &= "    comCompra.FacturaId,  "
            strSQL &= "    comCompra.PolizaId,  "
            strSQL &= "    comCompra.PorIVA,  "
            strSQL &= "    comCompra.PorPoliza,  "
            strSQL &= "    comCompra.GestionId,  "
            strSQL &= "    comCompra.NotaId,  "
            strSQL &= "    comCompra.CompId,  "
            strSQL &= "    comCompra.PlanId,  "
            strSQL &= "    comCompra.PedCompraId,  "
            strSQL &= "    comCompra.CreditoId,  "
            strSQL &= "    comCompra.EstadoId  "
            strSQL &= " FROM comCompra, tblMoneda "

         Case SelectFilters.FlujoCaja
            strSQL = " SELECT  "
            strSQL &= "    comCompra.ProveedorId,  "
            strSQL &= "    comCompra.MonedaId,  "
            strSQL &= "    comCompra.TipoPagoId,  "
            strSQL &= "    comCompra.TipoCambio,  "
            strSQL &= "    comCompra.MontoOrg,  "
            strSQL &= "    comCompra.MontoCos,  "
            strSQL &= "    comCompra.MontoAnt,  "
            strSQL &= "    comCompra.MontoDes,  "
            strSQL &= "    comCompra.MontoRec,  "
            strSQL &= "    comCompra.MontoOtro,  "
            strSQL &= "    comCompra.MontoNet,  "
            strSQL &= "    comCompra.MontoLiq,  "
            strSQL &= "    comCompra.MontoBru  "
            strSQL &= " FROM comCompra "

         Case SelectFilters.GRID_IMPORT
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.Fecha,  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.NroAutorizacion,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    comCompra.PolizaId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.TipoPlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenCod,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCompra.CompraDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCompra.TipoCambio,  "
            strSQL &= "    comCompra.MontoOrg,  "
            strSQL &= "    comCompra.MontoAnt,  "
            strSQL &= "    comCompra.MontoDes,  "
            strSQL &= "    comCompra.MontoRec,  "
            strSQL &= "    comCompra.MontoOtro,  "
            strSQL &= "    comCompra.MontoNet,  "
            strSQL &= "    comCompra.MontoLiq,  "
            strSQL &= "    comCompra.MontoBru,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    comCompra.SinFac,  "
            strSQL &= "    comCompra.ConFac,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    CONVERT(bit, 0) As RowImport  "
            strSQL &= " FROM comCompra, invAlmacen, comProveedor, comTipoPago, tblMoneda, comPedCompra, comCredito, invNota, invTipoNota, tblComp, tblTipoComp, tblEstado, tblFactura, tblPlan "
            strSQL &= "    ,tblSucursal "

         Case SelectFilters.GridFacturar
            strSQL = "  SELECT   "
            strSQL &= "    '0' As Sel,   "
            strSQL &= "    tblGestion.GestionId,   "
            strSQL &= "    tblGestion.Gestion,   "
            strSQL &= "    comCompra.CompraId,   "
            strSQL &= "    comCompra.CompraNro,   "
            strSQL &= "    comCompra.CompraOrden,   "
            strSQL &= "    comCompra.Fecha,   "
            strSQL &= "    comTipoPago.TipoPagoId,   "
            strSQL &= "    comTipoPago.TipoPagoDes,   "
            strSQL &= "    comCompra.AlmacenId,   "
            strSQL &= "    tblMoneda.MonedaId,   "
            strSQL &= "    tblMoneda.MonedaDes,   "
            strSQL &= "    comCompra.FacturaId,   "
            strSQL &= "    comCompra.MontoOrg,   "
            strSQL &= "    comCompra.MontoNet,   "
            strSQL &= "    comCompra.MontoRec,   "
            strSQL &= "    comCompra.MontoDes,   "
            strSQL &= "    comCompra.MontoAnt,   "
            strSQL &= "    comCompra.MontoLiq,   "
            strSQL &= "    comCompra.TipoCambio,   "
            strSQL &= "    tblEstado.EstadoId,   "
            strSQL &= "    tblEstado.EstadoDes, "
            strSQL &= "    comCompra.MontoBru, "
            strSQL &= "    comCompra.MontoFac, "
            strSQL &= "    comCompra.MontoBru - comCompra.MontoFac As SaldoFactura,"
            strSQL &= "    comCompra.FactDifExento, "
            strSQL &= "    0.0 As ExentoFac, "
            strSQL &= "    0.0 As ExentoAFac "
            strSQL &= " FROM comCompra, tblMoneda, tblEstado, comTipoPago, tblGestion "

         Case SelectFilters.GridFacturaMultiple
            strSQL = "  SELECT   "
            strSQL &= "    '0' As Sel,   "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblGestion.GestionId,   "
            strSQL &= "    tblGestion.Gestion,   "
            strSQL &= "    comCompra.CompraId,   "
            strSQL &= "    comCompra.CompraNro,   "
            strSQL &= "    comCompra.CompraOrden,   "
            strSQL &= "    comCompra.Fecha,   "
            strSQL &= "    comTipoPago.TipoPagoId,   "
            strSQL &= "    comTipoPago.TipoPagoDes,   "
            strSQL &= "    invAlmacen.AlmacenId,   "
            strSQL &= "    invAlmacen.AlmacenDes,   "
            strSQL &= "    tblAlmacenSucursal.SucursalId as AlmacenSucursalId,   "
            strSQL &= "    tblAlmacenSucursal.SucursalDes as AlmacenSucursalDes,   "
            strSQL &= "    comCompra.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblMoneda.MonedaId,   "
            strSQL &= "    tblMoneda.MonedaDes,   "
            strSQL &= "    comCompra.FacturaId,   "
            strSQL &= "    comCompra.MontoOrg,   "
            strSQL &= "    comCompra.MontoNet,   "
            strSQL &= "    comCompra.MontoRec,   "
            strSQL &= "    comCompra.MontoDes,   "
            strSQL &= "    comCompra.MontoAnt,   "
            strSQL &= "    comCompra.MontoLiq,   "
            strSQL &= "    comCompra.TipoCambio,   "
            strSQL &= "    tblEstado.EstadoId,   "
            strSQL &= "    tblEstado.EstadoDes, "
            strSQL &= "    comCompra.MontoBru, "
            strSQL &= "    comCompra.MontoFac, "
            strSQL &= "    (comCompra.MontoBru - comCompra.MontoFac ) AS SaldoFactura, "
            strSQL &= "    comCompra.FactDifExento, "
            'strSQL &= "    0.0 As ExentoFac, "
            'strSQL &= "    0.0 As ExentoAFac "
            strSQL &= "    (SELECT isnull(SUM(MontoExento),0) FROM tblCompraFac WHERE tblCompraFac.CompraId = comCompra.CompraId ) As ExentoFac, "
            strSQL &= "    (comCompra.FactDifExento -(SELECT isnull(SUM(MontoExento),0) FROM tblCompraFac WHERE tblCompraFac.CompraId = comCompra.CompraId )) As ExentoAFac "
            strSQL &= " FROM comCompra, tblMoneda, tblEstado, comTipoPago, tblGestion, invAlmacen, tblSucursal as tblAlmacenSucursal, tblCentroCosto, tblSucursal "

            Case SelectFilters.ComprasProveedor
                strSQL = " SELECT "
                strSQL &= " comCompra.CompraId, "
                strSQL &= " comCompra.Fecha, "
                strSQL &= " comCompra.MonedaId, "
                strSQL &= " comCompra.CompraNro, "
                strSQL &= " comCompra.TipoCambio, "
                strSQL &= " comCompra.EstadoId, "
                strSQL &= " comCompra.CompraObs, "
                strSQL &= " invItem.ItemId, "
                strSQL &= " invItem.ItemCod, "
                strSQL &= " invItem.ItemDes, "
                strSQL &= " invItem.MedidaId as MedidaMinItem, "
                strSQL &= " invItem.MedidaIdEqui as MedidaEquiItem, "
                strSQL &= " invItem.MedidaCantEqui as MedidaCantEquiItem, "
                strSQL &= " invMedida.MedidaId, "
                strSQL &= " invMedida.MedidaDes, "
                strSQL &= " tblCentroCosto.CentroCostoId, "
                strSQL &= " tblCentroCosto.CentroCostoCod, "
                strSQL &= " tblCentroCosto.CentroCostoDes, "
                strSQL &= " comProveedor.ProveedorId, "
                strSQL &= " comProveedor.ProveedorCod, "
                strSQL &= " comProveedor.ProveedorDes, "
                strSQL &= " comCompraDet.CompraDetId, "
                strSQL &= " comCompraDet.Fecha as FechaDet, "
                strSQL &= " comCompraDet.CompraDetDes, "
                strSQL &= " comCompraDet.Cantidad, "
                strSQL &= " comCompraDet.PrecioOrg, "
                strSQL &= " comCompraDet.Importe "
                strSQL &= " FROM comCompra, invItem, invMedida, tblCentroCosto, comProveedor, comCompraDet "

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
            strSQL = " WHERE  comCompra.CompraId = " & NumberToField(mlngCompraId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            ''strSQL &= " AND  comCompra.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comCompra.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comCompra.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  comCompra.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comCompra.FacturaId = tblFactura.FacturaId "
            strSQL &= " AND  comCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCompra.AppId = secApp.AppId "
            strSQL &= " AND  comCompra.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.GRID_IMPORT
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCompra.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comCompra.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comCompra.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  comCompra.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comCompra.FacturaId = tblFactura.FacturaId "
            strSQL &= " AND  comCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCompra.PlanId = tblPlan.PlanId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND  comCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCompra.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comCompra.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comCompra.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  comCompra.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comCompra.EstadoId = tblEstado.EstadoId "

            strSQL &= " AND  comCompra.CompraId = comCompraDet.CompraId "
            strSQL &= " AND  comCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.AlmacenId
            'strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            'strSQL &= " AND  (comCompra.AlmacenId = " & NumberToField(mlngAlmacenId)
            'strSQL &= " OR  comCompra.ProveedorId = " & NumberToField(mlngProveedorId) & ") "

         Case WhereFilters.GestionId
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.GridCredito
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCompra.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comCompra.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comCompra.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  comCompra.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comCompra.FacturaId = tblFactura.FacturaId "
            strSQL &= " AND  comCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCompra.AppId = secApp.AppId "
            strSQL &= " AND  comCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comCompra.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            strSQL &= " AND  comCompra.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comCompra.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.GridContado
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCompra.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCompra.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            strSQL &= " AND  comCompra.EstadoId = " & NumberToField(mlngEstadoId)

            If mstrFecha.Length <> 0 Then
               strSQL &= " AND  comCompra.Fecha <= " & DateToField(mstrFecha)
            End If

         Case WhereFilters.CreditoId
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.CreditoId = " & NumberToField(mlngCreditoId)

         Case WhereFilters.GridCreditoId
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            ''strSQL &= " AND  comCompra.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comCompra.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comCompra.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  comCompra.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comCompra.FacturaId = tblFactura.FacturaId "
            strSQL &= " AND  comCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCompra.AppId = secApp.AppId "
            strSQL &= " AND  comCompra.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.GridDevCompra
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            ''strSQL &= " AND  comCompra.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comCompra.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comCompra.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  comCompra.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comCompra.FacturaId = tblFactura.FacturaId "
            strSQL &= " AND  comCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCompra.AppId = secApp.AppId "
            strSQL &= " AND  comCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  (comCompra.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " OR  comCompra.EstadoId = " & NumberToField(mlngCreditoId) & ") "

            strSQL &= " AND  comCompra.CompraId IN (SELECT comCompraDet.CompraId FROM comCompraDet "
            strSQL &= " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompra.CompraId = comCompraDet.CompraId "
            strSQL &= " AND  (comCompraDet.Cantidad - comCompraDet.CantidadDev) > 0 "
            strSQL &= " ) "

         Case WhereFilters.MovDiario
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompra.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            strSQL &= " AND  comCompra.Fecha = " & DateToField(mstrFecha)
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  (comCompra.EstadoId = 13 "
            strSQL &= " OR  comCompra.EstadoId = 14 "
            strSQL &= " OR  comCompra.EstadoId = 15) "

         Case WhereFilters.CompraOrden
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompra.CompraOrden = " & StringToField(mstrCompraOrden)
            If mlngCompraId <> 0 Then
               strSQL &= " AND  comCompra.CompraId <> " & NumberToField(mlngCompraId)
            End If
            strSQL &= " AND  (comCompra.EstadoId = 13 "
            strSQL &= " OR  comCompra.EstadoId = 14 "
            strSQL &= " OR  comCompra.EstadoId = 15) "

         Case WhereFilters.ProveedorId
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.ProveedorId = " & NumberToField(mlngProveedorId)

         Case WhereFilters.FlujoCaja
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoPagoId <> 0 Then
               strSQL &= " AND  comCompra.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            strSQL &= " AND  comCompra.EstadoId <> 12 "
            strSQL &= " AND  comCompra.EstadoId <> 0 "

         Case WhereFilters.FlujoCajaFecha
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoPagoId <> 0 Then
               strSQL &= " AND  comCompra.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comCompra.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCompra.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  comCompra.EstadoId <> 12 "
            strSQL &= " AND  comCompra.EstadoId <> 0 "

         Case WhereFilters.COMPRA_NRO
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompra.CompraNro = " & NumberToField(mlngCompraNro)

         Case WhereFilters.GridFacturar
            strSQL = " WHERE comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId <= " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompra.GestionId = tblGestion.GestionId"
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCompra.EstadoId <> 12 "
            strSQL &= " AND  comCompra.EstadoId <> 0 "
            strSQL &= " AND  comCompra.FacturaDif = 1"
            strSQL &= " AND  comCompra.MontoBru - comCompra.MontoFac > 0 "
            strSQL &= " AND  ( comCompra.MontoFac =  0 "
            strSQL &= " OR  comCompra.CompraId Not IN (SELECT tblCompraFac.CompraId FROM tblCompraFac "
            strSQL &= "                           WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "                            AND  tblCompraFac.MontoCompra > 0 )"
            strSQL &= " ) "

         Case WhereFilters.EstadoId_CentroCosto
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comPedCompra.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  comPedCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)

         Case WhereFilters.GridFacturaMultiple
            strSQL = " WHERE comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId <= " & NumberToField(mlngGestionId) ''Por don Alejandro AMC
            strSQL &= " AND  comCompra.GestionId = tblGestion.GestionId"
            strSQL &= " AND  comCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCompra.EstadoId <> 12 "
            strSQL &= " AND  comCompra.EstadoId <> 0 "
            strSQL &= " AND  comCompra.FacturaDif = 1"
            strSQL &= " AND  comCompra.MontoBru - comCompra.MontoFac > 0 "

            strSQL &= " AND  comCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invAlmacen.SucursalId = tblAlmacenSucursal.SucursalId "
            strSQL &= " AND  comCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  ( comCompra.MontoFac =  0 "
            strSQL &= " OR  comCompra.CompraId IN (SELECT tblCompraFac.CompraId FROM tblCompraFac "
            strSQL &= "                           WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "                            AND  tblCompraFac.MontoCompra > 0 )"
            strSQL &= " ) "

            Case WhereFilters.ComprasProveedor
                strSQL = " WHERE comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
                strSQL &= " AND comCompra.GestionId = " & NumberToField(mlngGestionId) ''Por don Alejandro AMC
                If mlngSucursalId > 0 Then
                    strSQL &= " AND comCompra.SucursalId = " & NumberToField(mlngSucursalId)
                End If
                strSQL &= " AND comCompra.CompraId = comCompraDet.CompraId "
                strSQL &= " AND comCompra.ProveedorId = comProveedor.ProveedorId "
                strSQL &= " AND comCompraDet.ItemId = invItem.ItemId "
                strSQL &= " AND comCompraDet.CentroCostoIdAct = tblCentroCosto.CentroCostoId "
                strSQL &= " AND comCompraDet.MedidaId = invMedida.MedidaId "
                strSQL &= " AND comCompra.EstadoId <> 12 "
                strSQL &= " AND comCompra.Fecha >= " & DateToField(mstrFecha)
                strSQL &= " AND comCompra.Fecha <= " & DateToField(mstrLastUpdateDate)

        End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompraId
            strSQL = " ORDER BY comCompra.CompraId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comCompra.CompraId DESC "

         Case OrderByFilters.CompraDes
            strSQL = " ORDER BY comCompra.CompraDes "

         Case OrderByFilters.Report
            strSQL = " ORDER BY comCompraDet.CompraDetId "

         Case OrderByFilters.GridContado
            strSQL = " ORDER BY comCompra.CompraId "

         Case OrderByFilters.GridFecha
            strSQL = " ORDER BY comCompra.Fecha, comCompra.CompraId "

         Case OrderByFilters.ProveedorId
            strSQL = " ORDER BY comCompra.ProveedorId "

            Case OrderByFilters.Fecha
                strSQL = " ORDER BY comCompra.Fecha desc "

        End Select

      Return strSQL
   End Function

   Private Function RowCountSQL() As String
      Dim strSQL As String

      Select Case mintRowCountFilter
         Case RowCountFilters.All
            strSQL = "SELECT Count(*) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

         Case RowCountFilters.MinId
            strSQL = "SELECT Min(CompraId) As CompraId FROM " & mstrTableName
            strSQL &= " WHERE CompraId > 0 "

         Case RowCountFilters.MaxId
            strSQL = "SELECT Max(CompraId) As CompraId FROM " & mstrTableName
            strSQL &= " WHERE CompraId > 0 "

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO comCompra ("
            strSQL &= "CompraId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CompraNro, "
            strSQL &= "Fecha, "
            strSQL &= "AlmacenId, "
            strSQL &= "ProveedorId, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "CompraOrden, "
            strSQL &= "CompraDes, "
            strSQL &= "CompraObs, "
            strSQL &= "TipoPagoId, "
            strSQL &= "MontoOrg, "
            strSQL &= "MontoCos, "
            strSQL &= "MontoAnt, "
            strSQL &= "MontoDes, "
            strSQL &= "MontoRec, "
            strSQL &= "MontoOtro, "
            strSQL &= "MontoNet, "
            strSQL &= "MontoLiq, "
            strSQL &= "MontoBru, "
            strSQL &= "MontoPorFac, "
            strSQL &= "FacturaId, "
            strSQL &= "PolizaId, "
            strSQL &= "PorIVA, "
            strSQL &= "PorPoliza, "
            strSQL &= "GestionId, "
            strSQL &= "PlanId, "
            strSQL &= "PedCompraId, "
            strSQL &= "CreditoId, "
            strSQL &= "ConFac, "
            strSQL &= "SinFac, "
            strSQL &= "FacturaDif, "
            strSQL &= "MontoFac, "
            strSQL &= "TipoRetencionId, "
            strSQL &= "FactDifExento, "
            strSQL &= "CentroCostoId, "
            strSQL &= "SucursalId, "
            strSQL &= "NotaId, "
            strSQL &= "CompId, "
            strSQL &= "AppId, "
            strSQL &= "TipoDocumentoId, "
            strSQL &= "DocumentoId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCompraNro) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= StringToField(mstrCompraOrden) & ", "
            strSQL &= StringToField(mstrCompraDes) & ", "
            strSQL &= StringToField(mstrCompraObs) & ", "
            strSQL &= NumberToField(mlngTipoPagoId) & ", "
            strSQL &= DecimalToField(mdecMontoOrg) & ", "
            strSQL &= DecimalToField(mdecMontoCos) & ", "
            strSQL &= DecimalToField(mdecMontoAnt) & ", "
            strSQL &= DecimalToField(mdecMontoDes) & ", "
            strSQL &= DecimalToField(mdecMontoRec) & ", "
            strSQL &= DecimalToField(mdecMontoOtro) & ", "
            strSQL &= DecimalToField(mdecMontoNet) & ", "
            strSQL &= DecimalToField(mdecMontoLiq) & ", "
            strSQL &= DecimalToField(mdecMontoBru) & ", "
            strSQL &= DecimalToField(mdecMontoPorFac) & ", "
            strSQL &= NumberToField(mlngFacturaId) & ", "
            strSQL &= NumberToField(mlngPolizaId) & ", "
            strSQL &= DecimalToField(mdecPorIVA) & ", "
            strSQL &= DecimalToField(mdecPorPoliza) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngPedCompraId) & ", "
            strSQL &= NumberToField(mlngCreditoId) & ", "
            strSQL &= NumberToField(mbytConFac) & ", "
            strSQL &= NumberToField(mbytSinFac) & ", "
            strSQL &= NumberToField(mbytFacturaDif) & ", "
            strSQL &= DecimalToField(mdecMontoFac) & ", "
            strSQL &= NumberToField(mlngTipoRetencionId) & ", "
            strSQL &= DecimalToField(mdecFactDifExento) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngNotaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngAppId) & ", "
            strSQL &= NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= NumberToField(mlngDocumentoId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comCompra SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CompraNro = " & NumberToField(mlngCompraNro) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "CompraOrden = " & StringToField(mstrCompraOrden) & ", "
            strSQL &= "CompraDes = " & StringToField(mstrCompraDes) & ", "
            strSQL &= "CompraObs = " & StringToField(mstrCompraObs) & ", "
            strSQL &= "TipoPagoId = " & NumberToField(mlngTipoPagoId) & ", "
            strSQL &= "MontoOrg = " & DecimalToField(mdecMontoOrg) & ", "
            strSQL &= "MontoCos = " & DecimalToField(mdecMontoCos) & ", "
            strSQL &= "MontoAnt = " & DecimalToField(mdecMontoAnt) & ", "
            strSQL &= "MontoDes = " & DecimalToField(mdecMontoDes) & ", "
            strSQL &= "MontoRec = " & DecimalToField(mdecMontoRec) & ", "
            strSQL &= "MontoOtro = " & DecimalToField(mdecMontoOtro) & ", "
            strSQL &= "MontoNet = " & DecimalToField(mdecMontoNet) & ", "
            strSQL &= "MontoLiq = " & DecimalToField(mdecMontoLiq) & ", "
            strSQL &= "MontoBru = " & DecimalToField(mdecMontoBru) & ", "
            strSQL &= "MontoPorFac = " & DecimalToField(mdecMontoPorFac) & ", "
            strSQL &= "FacturaId = " & NumberToField(mlngFacturaId) & ", "
            strSQL &= "PolizaId = " & NumberToField(mlngPolizaId) & ", "
            strSQL &= "PorIVA = " & DecimalToField(mdecPorIVA) & ", "
            strSQL &= "PorPoliza = " & DecimalToField(mdecPorPoliza) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "PedCompraId = " & NumberToField(mlngPedCompraId) & ", "
            strSQL &= "CreditoId = " & NumberToField(mlngCreditoId) & ", "
            strSQL &= "ConFac = " & NumberToField(mbytConFac) & ", "
            strSQL &= "SinFac = " & NumberToField(mbytSinFac) & ", "
            strSQL &= "FacturaDif = " & NumberToField(mbytFacturaDif) & ", "
            strSQL &= "MontoFac = " & DecimalToField(mdecMontoFac) & ", "
            strSQL &= "TipoRetencionId = " & NumberToField(mlngTipoRetencionId) & ", "
            strSQL &= "FactDifExento = " & DecimalToField(mdecFactDifExento) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "NotaId = " & NumberToField(mlngNotaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompraId = " & NumberToField(mlngCompraId) & " "

         Case UpdateFilters.CREDITOID
            strSQL = "UPDATE comCompra SET "
            strSQL &= "CreditoId = " & NumberToField(mlngCreditoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompraId = " & NumberToField(mlngCompraId) & " "

         Case UpdateFilters.MontoFac
            strSQL = " UPDATE comCompra "
            strSQL &= " SET MontoFac = MontoFac + " & DecimalToField(mdecMontoFac) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE CompraId = " & NumberToField(mlngCompraId)
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
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCompraNro = ToLong(oDataRow("CompraNro"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mstrCompraOrden = ToStr(oDataRow("CompraOrden"))
               mstrCompraDes = ToStr(oDataRow("CompraDes"))
               mstrCompraObs = ToStr(oDataRow("CompraObs"))
               mlngTipoPagoId = ToLong(oDataRow("TipoPagoId"))
               mdecMontoOrg = ToDecimal(oDataRow("MontoOrg"))
               mdecMontoCos = ToDecimal(oDataRow("MontoCos"))
               mdecMontoAnt = ToDecimal(oDataRow("MontoAnt"))
               mdecMontoDes = ToDecimal(oDataRow("MontoDes"))
               mdecMontoRec = ToDecimal(oDataRow("MontoRec"))
               mdecMontoOtro = ToDecimal(oDataRow("MontoOtro"))
               mdecMontoNet = ToDecimal(oDataRow("MontoNet"))
               mdecMontoLiq = ToDecimal(oDataRow("MontoLiq"))
               mdecMontoBru = ToDecimal(oDataRow("MontoBru"))
               mdecMontoPorFac = ToDecimal(oDataRow("MontoPorFac"))
               mlngFacturaId = ToLong(oDataRow("FacturaId"))
               mlngPolizaId = ToLong(oDataRow("PolizaId"))
               mdecPorIVA = ToDecimal(oDataRow("PorIVA"))
               mdecPorPoliza = ToDecimal(oDataRow("PorPoliza"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngPedCompraId = ToLong(oDataRow("PedCompraId"))
               mlngCreditoId = ToLong(oDataRow("CreditoId"))
               mbytConFac = ToBoolean(oDataRow("ConFac"))
               mbytSinFac = ToBoolean(oDataRow("SinFac"))
               mbytFacturaDif = ToBoolean(oDataRow("FacturaDif"))
               mdecMontoFac = ToDecimal(oDataRow("MontoFac"))
               mlngTipoRetencionId = ToLong(oDataRow("TipoRetencionId"))
               mdecFactDifExento = ToDecimal(oDataRow("FactDifExento"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngNotaId = ToLong(oDataRow("NotaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngTipoDocumentoId = ToLong(oDataRow("TipoDocumentoId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mstrCompraDes = ToStr(oDataRow("CompraDes"))

            Case SelectFilters.FlujoCaja
               mlngProveedorId = ToDecimal(oDataRow("ProveedorId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngTipoPagoId = ToLong(oDataRow("TipoPagoId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecMontoOrg = ToDecimal(oDataRow("MontoOrg"))
               mdecMontoCos = ToDecimal(oDataRow("MontoCos"))
               mdecMontoAnt = ToDecimal(oDataRow("MontoAnt"))
               mdecMontoDes = ToDecimal(oDataRow("MontoDes"))
               mdecMontoRec = ToDecimal(oDataRow("MontoRec"))
               mdecMontoOtro = ToDecimal(oDataRow("MontoOtro"))
               mdecMontoNet = ToDecimal(oDataRow("MontoNet"))
               mdecMontoLiq = ToDecimal(oDataRow("MontoLiq"))
               mdecMontoBru = ToDecimal(oDataRow("MontoBru"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompraId = TableIDGet(mstrTableName, "CompraId", moConnection)

         If mlngCompraId = -1 Then
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
         strMsg &= "Sucursal Inválido" & vbCrLf
      End If

      If (mstrFecha.Trim() <> String.Empty) And (mstrFecha.Trim() <> "01/01/1990") Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha no puede ser nula" & vbCrLf
      End If

      If mlngTipoPagoId = 0 Then
         strMsg &= "Tipo de Pago Inválido" & vbCrLf
      End If

      If mlngAlmacenId = 0 Then
         strMsg &= "Almacen Inválido" & vbCrLf
      End If

      If mlngProveedorId = 0 Then
         strMsg &= "Proveedor Inválido" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If mdecTipoCambio = 0 Then
         strMsg &= "Tipo de Cambio Inválido" & vbCrLf
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
         'strSQL &= " FROM comCompra "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCompra.TipoCompraId = " & NumberToField(mlngTipoCompraId)
         'Else
         '   strSQL &= " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCompra.TipoCompraId = " & NumberToField(mlngTipoCompraId)
         '   strSQL &= " AND  comCompra.CompraId <> " & NumberToField(mlngCompraId)
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
