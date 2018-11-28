Imports System.Data
Imports System.Data.OleDb

Public Class clsVentaDet
   Implements IDisposable

   Private mlngVentaDetId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngVentaId As Long
   Private mstrFecha As String
   Private mlngAlmacenId As Long
   Private mlngClienteId As Long
   Private mlngVendedorId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mlngItemId As Long
   Private mlngItemPrecioId As Long
   Private mlngMedidaId As Long
   Private mdecCantidad As Decimal
   Private mdecPrecioOrg As Decimal
   Private mdecPrecioNet As Decimal
   Private mdecPrecioCos As Decimal
   Private mdecPrecioRec As Decimal
   Private mdecPrecioDes As Decimal
   Private mdecImporte As Decimal
   Private mdecImporteBru As Decimal
   Private mstrVentaDetDes As String
   Private mdecCantidadDev As Decimal
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer
   Private mdecCantidadEnt As Decimal

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
   Property VentaDetId() As Long
      Get
         Return mlngVentaDetId
      End Get

      Set(ByVal Value As Long)
         mlngVentaDetId = Value
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

   Property VentaId() As Long
      Get
         Return mlngVentaId
      End Get

      Set(ByVal Value As Long)
         mlngVentaId = Value
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

   Property ClienteId() As Long
      Get
         Return mlngClienteId
      End Get

      Set(ByVal Value As Long)
         mlngClienteId = Value
      End Set
   End Property

   Property VendedorId() As Long
      Get
         Return mlngVendedorId
      End Get

      Set(ByVal Value As Long)
         mlngVendedorId = Value
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

   Property ItemId() As Long
      Get
         Return mlngItemId
      End Get

      Set(ByVal Value As Long)
         mlngItemId = Value
      End Set
   End Property

   Property ItemPrecioId() As Long
      Get
         Return mlngItemPrecioId
      End Get

      Set(ByVal Value As Long)
         mlngItemPrecioId = Value
      End Set
   End Property

   Property MedidaId() As Long
      Get
         Return mlngMedidaId
      End Get

      Set(ByVal Value As Long)
         mlngMedidaId = Value
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

   Property PrecioOrg() As Decimal
      Get
         Return mdecPrecioOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioOrg = Value
      End Set
   End Property

   Property PrecioNet() As Decimal
      Get
         Return mdecPrecioNet
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioNet = Value
      End Set
   End Property

   Property PrecioCos() As Decimal
      Get
         Return mdecPrecioCos
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioCos = Value
      End Set
   End Property

   Property PrecioRec() As Decimal
      Get
         Return mdecPrecioRec
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioRec = Value
      End Set
   End Property

   Property PrecioDes() As Decimal
      Get
         Return mdecPrecioDes
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioDes = Value
      End Set
   End Property

   Property Importe() As Decimal
      Get
         Return mdecImporte
      End Get

      Set(ByVal Value As Decimal)
         mdecImporte = Value
      End Set
   End Property

   Property ImporteBru() As Decimal
      Get
         Return mdecImporteBru
      End Get

      Set(ByVal Value As Decimal)
         mdecImporteBru = Value
      End Set
   End Property

   Property VentaDetDes() As String
      Get
         Return mstrVentaDetDes
      End Get

      Set(ByVal Value As String)
         mstrVentaDetDes = Value
      End Set
   End Property

   Property CantidadDev() As Decimal
      Get
         Return mdecCantidadDev
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidadDev = Value
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

   Property CantidadEnt() As Decimal
      Get
         Return mdecCantidadEnt
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidadEnt = Value
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
      VentaMov = 4
      FechaDistinta = 5
      ItemClienteMov = 6
      ClienteItemMov = 7
      VentaMovResu = 8
      VendedorComi = 9
      VendedorComiCob = 10
      ClienteUPV = 11
      ClienteVentaMov = 12
      VentaDetMov = 13
      EstimacionMov = 14
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      VentaId = 6
      ItemId = 7
      TieneMovimiento = 8
      TieneMovimientoFecha = 9
      VentaMov = 10
      VentaMovFecha = 11
      SaldoActual = 12
      SaldoFecha = 13
      SaldoFechaIgual = 14
      SaldoFechaIntervalo = 15
      ItemClienteMov = 16
      ItemClienteMovFecha = 17
      ClienteItemMov = 18
      ClienteItemMovFecha = 19
      VendedorComi = 20
      VendedorComiFecha = 21
      VendedorComiCob = 22
      VendedorComiCobFecha = 23
      ClienteUPV = 24
      VentaItemId = 25
      GridClone = 26
      VentaMovConEntregaFecha = 27
      VentaMovConEntrega = 28
      ClienteVentaMovConEntregaFecha = 29
      ClienteVentaMovConEntrega = 30
      ClienteVentaMovFecha = 31
      ClienteVentaMov = 32
      VentaDetMov = 33
      VentaDetMovFecha = 34
      EstimacionMov = 35
      EstimacionMovFecha = 36
      VentaConEntrega = 37

      ItemIdTieneMov = 38
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      VentaDetId = 1
      Grid = 3
      Report = 4
      VentaMov = 5
      Fecha = 6
      FechaDESC = 7
      Estimacion = 8
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      CantidadEnt = 1
      CantidadDev = 2
      PrecioCos = 3
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
   End Enum

   Public Enum RowCountFilters As Byte
      All = 0
   End Enum

   Public Enum RowSumFilters As Byte
      Cantidad = 1
      CantidadSal = 2
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
      mstrTableName = "venVentaDet"
      mstrClassName = "clsVentaDet"

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
      mlngVentaDetId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngVentaId = 0
      mstrFecha = ""
      mlngAlmacenId = 0
      mlngClienteId = 0
      mlngVendedorId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mlngItemId = 0
      mlngItemPrecioId = 0
      mlngMedidaId = 0
      mdecCantidad = 0
      mdecPrecioOrg = 0
      mdecPrecioNet = 0
      mdecPrecioCos = 0
      mdecPrecioRec = 0
      mdecPrecioDes = 0
      mdecImporte = 0
      mdecImporteBru = 0
      VentaDetDes = ""
      mlngEstadoId = 0
      mdecCantidadEnt = 0
      mdecCantidadDev = 0
      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.EmpresaId,  "
            strSQL &= "    venVentaDet.GestionId,  "
            strSQL &= "    venVentaDet.VentaId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    venVentaDet.AlmacenId,  "
            strSQL &= "    venVentaDet.ClienteId,  "
            strSQL &= "    venVentaDet.VendedorId,  "
            strSQL &= "    venVentaDet.MonedaId,  "
            strSQL &= "    venVentaDet.TipoCambio,  "
            strSQL &= "    venVentaDet.ItemId,  "
            strSQL &= "    venVentaDet.ItemPrecioId,  "
            strSQL &= "    venVentaDet.MedidaId,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.PrecioOrg,  "
            strSQL &= "    venVentaDet.PrecioNet,  "
            strSQL &= "    venVentaDet.PrecioCos,  "
            strSQL &= "    venVentaDet.PrecioRec,  "
            strSQL &= "    venVentaDet.PrecioDes,  "
            strSQL &= "    venVentaDet.Importe,  "
            strSQL &= "    venVentaDet.ImporteBru,  "
            strSQL &= "    venVentaDet.VentaDetDes,  "
            strSQL &= "    venVentaDet.CantidadEnt,  "
            strSQL &= "    venVentaDet.CantidadDev,  "
            strSQL &= "    venVentaDet.EstadoId,  "
            strSQL &= "    venVentaDet.sLastUpdate_id,  "
            strSQL &= "    venVentaDet.dtLastUpdate_dt,  "
            strSQL &= "    venVentaDet.iConcurrency_id  "
            strSQL &= " FROM venVentaDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId  "
            strSQL &= " FROM venVentaDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.EmpresaId,  "
            strSQL &= "    venVentaDet.VentaId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ControlLote,  "
            strSQL &= "    invItem.ControlSerie,  "
            strSQL &= "    invItem.TipoItemId,  "
            strSQL &= "    venVentaDet.ItemPrecioId,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.CantidadEnt,  "
            strSQL &= "    venVentaDet.CantidadDev,  "
            strSQL &= "    venVentaDet.PrecioOrg,  "
            strSQL &= "    venVentaDet.PrecioNet,  "
            strSQL &= "    venVentaDet.PrecioCos,  "
            strSQL &= "    venVentaDet.PrecioRec,  "
            strSQL &= "    venVentaDet.PrecioDes,  "
            strSQL &= "    venVentaDet.Importe,  "
            strSQL &= "    venVentaDet.ImporteBru,  "
            strSQL &= "    venVentaDet.VentaDetDes,  "
            strSQL &= "    venVentaDet.EstadoId  "
            strSQL &= " FROM venVentaDet, invItem, invMedida "

         Case SelectFilters.Report

         Case SelectFilters.VentaMov
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.VentaId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    venVenta.VentaNro,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    venCliente.ClienteId,  "
            strSQL &= "    venCliente.ClienteDes,  "
            strSQL &= "    venVenta.VentaDes,  "
            strSQL &= "    venVentaDet.ItemId,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.CantidadEnt,  "
            strSQL &= "    venVentaDet.CantidadDev,  "
            strSQL &= "    venVentaDet.MonedaId,  "
            strSQL &= "    venVentaDet.TipoCambio,  "
            strSQL &= "    venVentaDet.PrecioOrg,  "
            strSQL &= "    venVentaDet.PrecioNet,  "
            strSQL &= "    venVentaDet.PrecioCos,  "
            strSQL &= "    venVentaDet.PrecioRec,  "
            strSQL &= "    venVentaDet.PrecioDes,  "
            strSQL &= "    venVentaDet.ImporteBru,  "
            strSQL &= "    venVentaDet.Importe  "
            strSQL &= " FROM venVentaDet, venVenta, comTipoPago, invAlmacen, venCliente, invMedida "

         Case SelectFilters.ClienteVentaMov
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.VentaId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    venVenta.VentaNro,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    venVenta.VentaDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.CantidadEnt,  "
            strSQL &= "    venVentaDet.MonedaId  "
            strSQL &= " FROM venVentaDet, venVenta, invAlmacen, invMedida, invItem "

         Case SelectFilters.VentaDetMov
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.CantidadEnt  "
            strSQL &= " FROM venVentaDet, invAlmacen, invMedida, invItem "

         Case SelectFilters.FechaDistinta
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    venVentaDet.ItemId  "
            strSQL &= " FROM venVentaDet, venVenta "

         Case SelectFilters.ItemClienteMov
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.VentaId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    venVenta.VentaNro,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.MonedaId,  "
            strSQL &= "    venVentaDet.TipoCambio,  "
            strSQL &= "    venVentaDet.PrecioOrg,  "
            strSQL &= "    venVentaDet.Importe  "
            strSQL &= " FROM venVentaDet, venVenta, invItem, invMedida "

         Case SelectFilters.ClienteItemMov
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.VentaId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    venVenta.VentaNro,  "
            strSQL &= "    venCliente.ClienteId,  "
            strSQL &= "    venCliente.ClienteCod,  "
            strSQL &= "    venCliente.ClienteDes,  "
            strSQL &= "    venVentaDet.ItemId,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.MonedaId,  "
            strSQL &= "    venVentaDet.TipoCambio,  "
            strSQL &= "    venVentaDet.PrecioOrg,  "
            strSQL &= "    venVentaDet.Importe  "
            strSQL &= " FROM venVentaDet, venVenta, venCliente, invMedida "

         Case SelectFilters.VentaMovResu
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.EmpresaId,  "
            strSQL &= "    venVentaDet.GestionId,  "
            strSQL &= "    venVentaDet.VentaId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    venVentaDet.AlmacenId,  "
            strSQL &= "    venVentaDet.ClienteId,  "
            strSQL &= "    venVentaDet.VendedorId,  "
            strSQL &= "    venVentaDet.MonedaId,  "
            strSQL &= "    venVentaDet.TipoCambio,  "
            strSQL &= "    venVentaDet.ItemId,  "
            strSQL &= "    venVentaDet.ItemPrecioId,  "
            strSQL &= "    venVentaDet.MedidaId,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.PrecioOrg,  "
            strSQL &= "    venVentaDet.PrecioNet,  "
            strSQL &= "    venVentaDet.PrecioCos,  "
            strSQL &= "    venVentaDet.Importe,  "
            strSQL &= "    venVentaDet.ImporteBru,  "
            strSQL &= "    venVentaDet.EstadoId  "
            strSQL &= " FROM venVentaDet, venVenta "

         Case SelectFilters.VendedorComi
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.VentaId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    venVenta.VentaNro,  "
            strSQL &= "    venVenta.VentaDes,  "
            strSQL &= "    venVenta.EstadoId,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    0 As PagoId,  "
            strSQL &= "    '' As FechaPago,  "
            strSQL &= "    venCliente.ClienteId,  "
            strSQL &= "    venCliente.ClienteCod,  "
            strSQL &= "    venCliente.ClienteDes,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.MonedaId,  "
            strSQL &= "    venVentaDet.TipoCambio,  "
            strSQL &= "    venVentaDet.PrecioOrg,  "
            strSQL &= "    venVentaDet.Importe  "
            strSQL &= " FROM venVentaDet, venVenta, comTipoPago, venCliente, invItem, invMedida "

         Case SelectFilters.VendedorComiCob
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.VentaDetId,  "
            strSQL &= "    venVentaDet.VentaId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    venVenta.VentaNro,  "
            strSQL &= "    venVenta.VentaDes,  "
            strSQL &= "    venVenta.EstadoId,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    0 As PagoId,  "
            strSQL &= "    '' As FechaPago,  "
            strSQL &= "    venCliente.ClienteId,  "
            strSQL &= "    venCliente.ClienteCod,  "
            strSQL &= "    venCliente.ClienteDes,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.MonedaId,  "
            strSQL &= "    venVentaDet.TipoCambio,  "
            strSQL &= "    venVentaDet.PrecioOrg,  "
            strSQL &= "    venVentaDet.Importe  "
            strSQL &= " FROM venVentaDet, venVenta, comTipoPago, venCliente, invItem, invMedida, venPagoDet "

         Case SelectFilters.ClienteUPV
            strSQL = " SELECT  TOP 5 "
            strSQL &= "    venVenta.VentaId,  "
            strSQL &= "    venVentaDet.Fecha,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.PrecioOrg  "
            strSQL &= " FROM venVentaDet, venVenta, tblMoneda, invMedida, comTipoPago "

         Case SelectFilters.EstimacionMov
            strSQL = " SELECT  "
            strSQL &= "    venVentaDet.MedidaId,  "
            strSQL &= "    venVentaDet.MonedaId,  "
            strSQL &= "    venVentaDet.TipoCambio,  "
            strSQL &= "    venVentaDet.Cantidad,  "
            strSQL &= "    venVentaDet.CantidadDev,  "
            strSQL &= "    venVentaDet.PrecioOrg ,  "
            strSQL &= "    venVentaDet.PrecioNet ,  "
            strSQL &= "    venVentaDet.PrecioCos ,  "
            strSQL &= "    venVentaDet.PrecioRec ,  "
            strSQL &= "    venVentaDet.PrecioDes ,  "
            strSQL &= "    venVentaDet.ImporteBru ,  "
            strSQL &= "    venVentaDet.Importe  "
            strSQL &= " FROM venVentaDet, venVendedor "

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
            strSQL = " WHERE  venVentaDet.VentaDetId = " & NumberToField(mlngVentaDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.VentaId = " & NumberToField(mlngVentaId)
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.GridClone
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.VentaId = " & NumberToField(mlngVentaId)
            strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.Report

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.VentaId
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.VentaId = " & NumberToField(mlngVentaId)

         Case WhereFilters.ItemId
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.VentaId = " & NumberToField(mlngVentaId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)

         Case WhereFilters.TieneMovimiento
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.TieneMovimientoFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.VentaMov
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVenta.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.VentaMovFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVenta.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.SaldoActual
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.SaldoFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.SaldoFechaIgual
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVentaDet.Fecha = " & DateToField(mstrFecha)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.SaldoFechaIntervalo
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.ItemClienteMov
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            If mlngVendedorId > 0 Then strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.ItemClienteMovFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            If mlngVendedorId > 0 Then strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.ClienteItemMov
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            If mlngVendedorId > 0 Then strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.ClienteItemMovFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            If mlngVendedorId > 0 Then strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.VendedorComi
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            strSQL &= " AND  venVenta.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.VendedorComiFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            strSQL &= " AND  venVenta.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.VendedorComiCob
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            strSQL &= " AND  venVentaDet.VentaId = venPagoDet.VentaId "
            strSQL &= " AND  venVenta.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  ( venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.VendedorComiCobFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            strSQL &= " AND  venVentaDet.VentaId = venPagoDet.VentaId "
            strSQL &= " AND  venVenta.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venPagoDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venPagoDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  ( venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.ClienteUPV
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            strSQL &= " AND  venVentaDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venVenta.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "


         Case WhereFilters.VentaMovConEntregaFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVenta.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

            strSQL &= " AND venVenta.VentaId IN (SELECT venEntrega.VentaId "
            strSQL &= " FROM venEntrega, venEntregaDet "
            strSQL &= " WHERE  venEntrega.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venEntrega.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venEntregaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venEntrega.EstadoId <> " & clsEstado.ANULADO
            strSQL &= " AND  venEntrega.EntregaId = venEntregaDet.EntregaId "
            strSQL &= " ) "

         Case WhereFilters.VentaMovConEntrega
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVenta.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.ClienteId = venCliente.ClienteId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

            strSQL &= " AND venVenta.VentaId IN (SELECT venEntrega.VentaId "
            strSQL &= " FROM venEntrega , venEntregaDet "
            strSQL &= " WHERE  venEntrega.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venEntrega.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venEntregaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  venEntrega.EstadoId <> " & clsEstado.ANULADO
            strSQL &= " AND  venEntrega.EntregaId = venEntregaDet.EntregaId "
            strSQL &= " ) "


         Case WhereFilters.ClienteVentaMovConEntregaFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
          
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

            strSQL &= " AND venVenta.VentaId IN (SELECT venEntrega.VentaId "
            strSQL &= " FROM venEntrega "
            strSQL &= " WHERE  venEntrega.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venEntrega.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venEntrega.ClienteId = " & NumberToField(mlngClienteId)
            strSQL &= " AND  venEntrega.EstadoId <> " & clsEstado.ANULADO
            strSQL &= " ) "

         Case WhereFilters.ClienteVentaMovConEntrega
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

            strSQL &= " AND venVenta.VentaId IN (SELECT venEntrega.VentaId "
            strSQL &= " FROM venEntrega  "
            strSQL &= " WHERE  venEntrega.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venEntrega.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venEntrega.ClienteId = " & NumberToField(mlngClienteId)
            strSQL &= " AND  venEntrega.EstadoId <> " & clsEstado.ANULADO
            strSQL &= " ) "

         Case WhereFilters.ClienteVentaMov
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.ClienteVentaMovFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VentaId = venVenta.VentaId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVenta.TipoPagoId = " & NumberToField(mlngVentaId)
            End If
            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.VentaDetMov
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            strSQL &= " AND  venVentaDet.VentaId = " & NumberToField(mlngVentaId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If

            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "


         Case WhereFilters.VentaDetMovFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            strSQL &= " AND  venVentaDet.VentaId = " & NumberToField(mlngVentaId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If

            strSQL &= " AND  venVentaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  venVentaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  venVentaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (venVentaDet.EstadoId = 13 "
            strSQL &= " OR  venVentaDet.EstadoId = 14 "
            strSQL &= " OR  venVentaDet.EstadoId = 15) "

         Case WhereFilters.EstimacionMov
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VendedorId = venVendedor.VendedorId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVendedor.CiudadId = " & NumberToField(mlngVentaId)
            End If
           
            strSQL &= " AND  venVentaDet.EstadoId <> " & NumberToField(clsEstado.ANULADO)

         Case WhereFilters.EstimacionMovFecha
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  venVentaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngClienteId <> 0 Then
               strSQL &= " AND  venVentaDet.ClienteId = " & NumberToField(mlngClienteId)
            End If
            If mlngVendedorId <> 0 Then
               strSQL &= " AND  venVentaDet.VendedorId = " & NumberToField(mlngVendedorId)
            End If
            strSQL &= " AND  venVentaDet.VendedorId = venVendedor.VendedorId "
            If mlngVentaId <> 0 Then
               strSQL &= " AND  venVendedor.CiudadId = " & NumberToField(mlngVentaId)
            End If
         
            strSQL &= " AND  venVentaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  venVentaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  venVentaDet.EstadoId <> " & NumberToField(clsEstado.ANULADO)


         Case WhereFilters.VentaConEntrega
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaDet.VentaId = " & NumberToField(mlngVentaId)
            strSQL &= " AND  venVentaDet.CantidadEnt > 0 "

         Case WhereFilters.ItemIdTieneMov
            strSQL = " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaDet.ItemId = " & NumberToField(mlngItemId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.VentaDetId
            strSQL = " ORDER BY venVentaDet.VentaDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY venVentaDet.VentaDetId "

         Case OrderByFilters.Report

         Case OrderByFilters.VentaMov
            strSQL = " ORDER BY venVentaDet.VentaId "

         Case OrderByFilters.Fecha
            strSQL = " ORDER BY venVentaDet.Fecha "

         Case OrderByFilters.FechaDESC
            strSQL = " ORDER BY venVentaDet.Fecha DESC "

         Case OrderByFilters.Estimacion
            strSQL = " GROUP BY invItem.ItemId, invItem.ItemDes "
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

         Case RowSumFilters.CantidadSal
            strSQL = "SELECT Sum(CantidadSal) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO venVentaDet ("
            strSQL &= "VentaDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "VentaId, "
            strSQL &= "Fecha, "
            strSQL &= "AlmacenId, "
            strSQL &= "ClienteId, "
            strSQL &= "VendedorId, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "ItemId, "
            strSQL &= "ItemPrecioId, "
            strSQL &= "MedidaId, "
            strSQL &= "Cantidad, "
            strSQL &= "PrecioOrg, "
            strSQL &= "PrecioNet, "
            strSQL &= "PrecioCos, "
            strSQL &= "PrecioRec,  "
            strSQL &= "PrecioDes,  "
            strSQL &= "Importe, "
            strSQL &= "ImporteBru, "
            strSQL &= "VentaDetDes,  "
            strSQL &= "EstadoId, "
            strSQL &= "CantidadEnt, "
            strSQL &= "CantidadDev, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngVentaDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngVentaId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngClienteId) & ", "
            strSQL &= NumberToField(mlngVendedorId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= NumberToField(mlngItemPrecioId) & ", "
            strSQL &= NumberToField(mlngMedidaId) & ", "
            strSQL &= DecimalToField(mdecCantidad) & ", "
            strSQL &= DecimalToField(mdecPrecioOrg) & ", "
            strSQL &= DecimalToField(mdecPrecioNet) & ", "
            strSQL &= DecimalToField(mdecPrecioCos) & ", "
            strSQL &= DecimalToField(mdecPrecioRec) & ", "
            strSQL &= DecimalToField(mdecPrecioDes) & ", "
            strSQL &= DecimalToField(mdecImporte) & ", "
            strSQL &= DecimalToField(mdecImporteBru) & ", "
            strSQL &= StringToField(mstrVentaDetDes) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= DecimalToField(mdecCantidadEnt) & ", "
            strSQL &= DecimalToField(mdecCantidadDev) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE venVentaDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "VentaId = " & NumberToField(mlngVentaId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "ClienteId = " & NumberToField(mlngClienteId) & ", "
            strSQL &= "VendedorId = " & NumberToField(mlngVendedorId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "ItemPrecioId = " & NumberToField(mlngItemPrecioId) & ", "
            strSQL &= "MedidaId = " & NumberToField(mlngMedidaId) & ", "
            strSQL &= "Cantidad = " & DecimalToField(mdecCantidad) & ", "
            strSQL &= "PrecioOrg = " & DecimalToField(mdecPrecioOrg) & ", "
            strSQL &= "PrecioNet = " & DecimalToField(mdecPrecioNet) & ", "
            strSQL &= "PrecioCos = " & DecimalToField(mdecPrecioCos) & ", "
            strSQL &= "PrecioRec = " & DecimalToField(mdecPrecioRec) & ", "
            strSQL &= "PrecioDes = " & DecimalToField(mdecPrecioDes) & ", "
            strSQL &= "Importe = " & DecimalToField(mdecImporte) & ", "
            strSQL &= "ImporteBru = " & DecimalToField(mdecImporteBru) & ", "
            strSQL &= "VentaDetDes = " & StringToField(mstrVentaDetDes) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= "CantidadEnt = " & DecimalToField(mdecCantidadEnt) & ", "
            strSQL &= "CantidadDev = " & DecimalToField(mdecCantidadDev) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " VentaDetId = " & NumberToField(mlngVentaDetId) & " "

         Case UpdateFilters.CantidadEnt
            strSQL = " UPDATE venVentaDet "
            strSQL &= " SET CantidadEnt = CantidadEnt + " & DecimalToField(mdecCantidadEnt) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND VentaId = " & NumberToField(mlngVentaId)
            strSQL &= " AND GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND AlmacenId = " & NumberToField(mlngAlmacenId)

         Case UpdateFilters.CantidadDev
            strSQL = " UPDATE venVentaDet "
            strSQL &= " SET CantidadDev = CantidadDev + " & DecimalToField(mdecCantidadDev) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND VentaId = " & NumberToField(mlngVentaId)
            strSQL &= " AND GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND AlmacenId = " & NumberToField(mlngAlmacenId)

         Case UpdateFilters.PrecioCos
            strSQL = "UPDATE venVentaDet SET "
            strSQL &= "PrecioCos = " & DecimalToField(mdecPrecioCos) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " VentaDetId = " & NumberToField(mlngVentaDetId) & " "

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
               mlngVentaDetId = ToLong(oDataRow("VentaDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngVentaId = ToLong(oDataRow("VentaId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngClienteId = ToLong(oDataRow("ClienteId"))
               mlngVendedorId = ToLong(oDataRow("VendedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mlngItemPrecioId = ToLong(oDataRow("ItemPrecioId"))
               mlngMedidaId = ToLong(oDataRow("MedidaId"))
               mdecCantidad = ToDecimal(oDataRow("Cantidad"))
               mdecPrecioOrg = ToDecimal(oDataRow("PrecioOrg"))
               mdecPrecioNet = ToDecimal(oDataRow("PrecioNet"))
               mdecPrecioCos = ToDecimal(oDataRow("PrecioCos"))
               mdecPrecioRec = ToDouble(oDataRow("PrecioRec"))
               mdecPrecioDes = ToDouble(oDataRow("PrecioDes"))
               mdecImporte = ToDecimal(oDataRow("Importe"))
               mdecImporteBru = ToDouble(oDataRow("ImporteBru"))
               mstrVentaDetDes = ToStr(oDataRow("VentaDetDes"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mdecCantidadEnt = ToDecimal(oDataRow("CantidadEnt"))
               mdecCantidadDev = ToDecimal(oDataRow("CantidadDev"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngVentaDetId = ToLong(oDataRow("VentaDetId"))

            Case SelectFilters.VentaMovResu
               mlngVentaDetId = ToLong(oDataRow("VentaDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngVentaId = ToLong(oDataRow("VentaId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngClienteId = ToLong(oDataRow("ClienteId"))
               mlngVendedorId = ToLong(oDataRow("VendedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mlngItemPrecioId = ToLong(oDataRow("ItemPrecioId"))
               mlngMedidaId = ToLong(oDataRow("MedidaId"))
               mdecCantidad = ToDecimal(oDataRow("Cantidad"))
               mdecPrecioOrg = ToDecimal(oDataRow("PrecioOrg"))
               mdecPrecioNet = ToDecimal(oDataRow("PrecioNet"))
               mdecPrecioCos = ToDecimal(oDataRow("PrecioCos"))
               mdecImporte = ToDecimal(oDataRow("Importe"))
               mdecImporteBru = ToDecimal(oDataRow("ImporteBru"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))

            Case SelectFilters.ClienteUPV
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecPrecioOrg = ToDecimal(oDataRow("PrecioOrg"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngVentaDetId = TableIDGet(mstrTableName, "VentaDetId", moConnection)

         If mlngVentaDetId = -1 Then
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

      If mlngVentaId = 0 Then
         strMsg &= "Seleccione el Tipo de VentaDetrobante" & vbCrLf
      End If

      If mlngAlmacenId = 0 Then
         strMsg &= "Almacen Inválido" & vbCrLf
      End If

      If mlngClienteId = 0 Then
         strMsg &= "Cliente Inválido" & vbCrLf
      End If

      If mlngVendedorId = 0 Then
         strMsg &= "Vendedor Inválido" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Seleccione la Moneda" & vbCrLf
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
         'strSQL &= " FROM venVentaDet "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  venVentaDet.TipoVentaId = " & NumberToField(mlngTipoVentaId)
         'Else
         '   strSQL &= " WHERE  venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  venVentaDet.TipoVentaId = " & NumberToField(mlngTipoVentaId)
         '   strSQL &= " AND  venVentaDet.VentaDetId <> " & NumberToField(mlngVentaDetId)
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
