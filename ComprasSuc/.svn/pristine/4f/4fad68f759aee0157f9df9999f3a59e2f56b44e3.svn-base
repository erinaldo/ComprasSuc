Imports System.Data
Imports System.Data.OleDb

Public Class clsPedCompra
   Implements IDisposable

   Private mlngPedCompraId As Long
   Private mlngEmpresaId As Long
   Private mlngPedCompraNro As Long
   Private mstrFecha As String
   Private mlngAlmacenId As Long
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mstrPedCompraOrden As String
   Private mstrPedCompraDes As String
   Private mstrPedCompraObs As String
   Private mdecPedCompraMonto As Decimal
   Private mdecMontoRec As Decimal
   Private mdecMontoDes As Decimal
   Private mdecMontoLiq As Decimal
   Private mlngGestionId As Long
   Private mlngCompraId As Long
   Private mlngCentroCostoId As Long
   Private mstrFechaEnt As String
   Private mdecMontoEnt As Decimal
   Private mlngSucursalId As Long
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
   Property PedCompraId() As Long
      Get
         Return mlngPedCompraId
      End Get

      Set(ByVal Value As Long)
         mlngPedCompraId = Value
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

   Property PedCompraNro() As Long
      Get
         Return mlngPedCompraNro
      End Get

      Set(ByVal Value As Long)
         mlngPedCompraNro = Value
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

   Property PedCompraOrden() As String
      Get
         Return mstrPedCompraOrden
      End Get

      Set(ByVal Value As String)
         mstrPedCompraOrden = Value
      End Set
   End Property

   Property PedCompraDes() As String
      Get
         Return mstrPedCompraDes
      End Get

      Set(ByVal Value As String)
         mstrPedCompraDes = Value
      End Set
   End Property

   Property PedCompraObs() As String
      Get
         Return mstrPedCompraObs
      End Get

      Set(ByVal Value As String)
         mstrPedCompraObs = Value
      End Set
   End Property

   Property PedCompraMonto() As Decimal
      Get
         Return mdecPedCompraMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecPedCompraMonto = Value
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

   Property MontoDes() As Decimal
      Get
         Return mdecMontoDes
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoDes = Value
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

   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   Property FechaEnt() As String
      Get
         Return mstrFechaEnt
      End Get

      Set(ByVal Value As String)
         mstrFechaEnt = Value
      End Set
   End Property

   Property MontoEnt() As Decimal
      Get
         Return mdecMontoEnt
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoEnt = Value
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
      GridEstadoId = 4
      PedCompraMov = 5
        GRID_IMPORT = 6
        ComprasProveedor = 7
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      AlmacenId = 6
      GestionId = 7
      ProveedorId = 8
      GridEstadoId = 9
      EstadoId = 10
      ProveedorIdDelete = 11
      PedCompraMov = 12
      PedCompraMovFecha = 13
      PedCompraNro = 14
      EstadoId_CentroCosto = 15
      PedCompraMovAll = 16
      PedCompraMovAllFecha = 17
      PedCompraMovEntregaPend = 18
      PedCompraMovEntregaPendFecha = 19
        ComprasProveedor = 20
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PedCompraId = 1
      Grid = 3
      Report = 4
      PedCompraDes = 5
      PedCompraNro = 6
      Fecha = 7
      GridFecha = 8
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      CompraId = 1
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
      mstrTableName = "comPedCompra"
      mstrClassName = "clsPedCompra"

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
      mlngPedCompraId = 0
      mlngEmpresaId = 0
      mlngPedCompraNro = 0
      mstrFecha = ""
      mlngAlmacenId = 0
      mlngProveedorId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mstrPedCompraOrden = ""
      mstrPedCompraDes = ""
      mstrPedCompraObs = ""
      mdecPedCompraMonto = 0
      mdecMontoRec = 0
      mdecMontoDes = 0
      mdecMontoLiq = 0
      mlngGestionId = 0
      mlngCompraId = 0
      mlngCentroCostoId = 0
      mstrFechaEnt = ""
      mdecMontoEnt = 0
      mlngSucursalId = 0
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
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.EmpresaId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    comPedCompra.Fecha,  "
            strSQL &= "    comPedCompra.AlmacenId,  "
            strSQL &= "    comPedCompra.ProveedorId,  "
            strSQL &= "    comPedCompra.MonedaId,  "
            strSQL &= "    comPedCompra.TipoCambio,  "
            strSQL &= "    comPedCompra.PedCompraOrden,  "
            strSQL &= "    comPedCompra.PedCompraDes,  "
            strSQL &= "    comPedCompra.PedCompraObs,  "
            strSQL &= "    comPedCompra.PedCompraMonto,  "
            strSQL &= "    comPedCompra.MontoRec,  "
            strSQL &= "    comPedCompra.MontoDes,  "
            strSQL &= "    comPedCompra.MontoLiq,  "
            strSQL &= "    comPedCompra.GestionId,  "
            strSQL &= "    comPedCompra.CompraId,  "
            strSQL &= "    comPedCompra.CentroCostoId,  "
            strSQL &= "    comPedCompra.FechaEnt,  "
            strSQL &= "    comPedCompra.MontoEnt,  "
            strSQL &= "    comPedCompra.SucursalId,  "
            strSQL &= "    comPedCompra.AppId,  "
            strSQL &= "    comPedCompra.TipoDocumentoId,  "
            strSQL &= "    comPedCompra.DocumentoId,  "
            strSQL &= "    comPedCompra.EstadoId,  "
            strSQL &= "    comPedCompra.sLastUpdate_id,  "
            strSQL &= "    comPedCompra.dtLastUpdate_dt,  "
            strSQL &= "    comPedCompra.iConcurrency_id  "
            strSQL &= " FROM comPedCompra "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraDes  "
            strSQL &= " FROM comPedCompra "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            If mintRowsMax > 0 Then strSQL &= " TOP " & NumberToField(mintRowsMax) & "  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    comPedCompra.Fecha,  "
            strSQL &= "    comPedCompra.FechaEnt,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comPedCompra.PedCompraOrden,  "
            strSQL &= "    comPedCompra.PedCompraDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comPedCompra.TipoCambio,  "
            strSQL &= "    comPedCompra.PedCompraMonto,  "
            strSQL &= "    comPedCompra.MontoRec,  "
            strSQL &= "    comPedCompra.MontoDes,  "
            strSQL &= "    comPedCompra.MontoLiq,  "
            strSQL &= "    comPedCompra.MontoEnt,  "
            strSQL &= "    (comPedCompra.MontoLiq - comPedCompra.MontoEnt) As MontoPen,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comPedCompra.sLastUpdate_id,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    secApp.AppId,  "
            strSQL &= "    secApp.AppDes,  "
            strSQL &= "    comPedCompra.TipoDocumentoId,  "
            strSQL &= "    comPedCompra.DocumentoId  "
            strSQL &= " FROM comPedCompra, invAlmacen, tblMoneda, comCompra, tblEstado, comProveedor, tblCentroCosto, tblSucursal, secApp "

         Case SelectFilters.GridEstadoId
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    comPedCompra.Fecha,  "
            strSQL &= "    comPedCompra.FechaEnt,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comPedCompra.PedCompraOrden,  "
            strSQL &= "    comPedCompra.PedCompraDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comPedCompra.TipoCambio,  "
            strSQL &= "    comPedCompra.PedCompraMonto,  "
            strSQL &= "    comPedCompra.MontoRec,  "
            strSQL &= "    comPedCompra.MontoDes,  "
            strSQL &= "    comPedCompra.MontoLiq,  "
            strSQL &= "    comPedCompra.MontoEnt,  "
            strSQL &= "    (comPedCompra.MontoLiq - comPedCompra.MontoEnt) As MontoPen,  "
            strSQL &= "    '' As AnticipoNro,  "
            strSQL &= "    comPedCompra.sLastUpdate_id,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    secApp.AppId,  "
            strSQL &= "    secApp.AppDes,  "
            strSQL &= "    comPedCompra.TipoDocumentoId,  "
            strSQL &= "    comPedCompra.DocumentoId  "
            strSQL &= " FROM comPedCompra, invAlmacen, tblMoneda, tblEstado, comProveedor, tblCentroCosto, tblSucursal, secApp "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    0 As ItemNro,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.EmpresaId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    comPedCompra.PedCompraOrden,  "
            strSQL &= "    comPedCompra.Fecha,  "
            strSQL &= "    comPedCompra.FechaEnt,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.Telefono1,  "
            strSQL &= "    comProveedor.Telefono2,  "
            strSQL &= "    comProveedor.Movil,  "
            strSQL &= "    comProveedor.Fax,  "
            strSQL &= "    comProveedor.Email,  "
            strSQL &= "    comProveedor.ContactoDes,  "
            strSQL &= "    comProveedor.ContactoCargo,  "
            strSQL &= "    comProveedor.ContactoCI,  "
            strSQL &= "    comPedCompra.PedCompraOrden,  "
            strSQL &= "    comPedCompra.PedCompraDes,  "
            strSQL &= "    comPedCompra.PedCompraObs,  "
            strSQL &= "    comPedCompra.CentroCostoId,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comPedCompra.TipoCambio,  "
            'strSQL &= "    comPedCompra.PedCompraMonto,  "
            'strSQL &= "    comPedCompra.MontoRec,  "
            'strSQL &= "    comPedCompra.MontoDes,  "
            'strSQL &= "    comPedCompra.MontoLiq,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "

            strSQL &= "    comPedCompraDet.PedCompraDetId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.MarcaId,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comPedCompraDet.PedCompraDetDes,  "
            strSQL &= "    comPedCompraDet.Cantidad,  "
            strSQL &= "    comPedCompraDet.Precio,  "
            strSQL &= "    comPedCompraDet.Importe,  "

            ''strSQL &= "    (comPedCompraDet.Cantidad * comPedCompraDet.Precio) As  Importe,  "
            strSQL &= "    (comPedCompraDet.PrecioRec * comPedCompraDet.Cantidad ) As ImporteRec,  "
            strSQL &= "    (comPedCompraDet.PrecioDes * comPedCompraDet.Cantidad ) As ImporteDes, "
            ''strSQL &= "    ((comPedCompraDet.Precio + comPedCompraDet.PrecioRec - comPedCompraDet.PrecioDes)* comPedCompraDet.Cantidad ) As ImporteBru  "
            strSQL &= "    comPedCompraDet.ImporteBru,  "
            strSQL &= "    comPedCompraDet.FechaEnt As ItemFechaEnt  "
            strSQL &= " FROM comPedCompra, invAlmacen, comProveedor, tblMoneda, comCompra, tblEstado, comPedCompraDet, invItem, invMedida  "

         Case SelectFilters.PedCompraMov
            strSQL = " SELECT  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.EmpresaId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    comPedCompra.Fecha,  "
            strSQL &= "    comPedCompra.AlmacenId,  "
            strSQL &= "    comPedCompra.ProveedorId,  "
            strSQL &= "    comPedCompra.MonedaId,  "
            strSQL &= "    comPedCompra.TipoCambio,  "
            strSQL &= "    comPedCompra.PedCompraOrden,  "
            strSQL &= "    comPedCompra.PedCompraDes,  "
            strSQL &= "    comPedCompra.PedCompraObs,  "
            strSQL &= "    comPedCompra.PedCompraMonto,  "
            strSQL &= "    comPedCompra.MontoRec,  "
            strSQL &= "    comPedCompra.MontoDes,  "
            strSQL &= "    comPedCompra.MontoLiq,  "
            strSQL &= "    comPedCompra.GestionId,  "
            strSQL &= "    comPedCompra.CompraId,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comPedCompra, tblEstado "

         Case SelectFilters.GRID_IMPORT
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    comPedCompra.Fecha,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenCod,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comPedCompra.PedCompraOrden,  "
            strSQL &= "    comPedCompra.PedCompraDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comPedCompra.TipoCambio,  "
            strSQL &= "    comPedCompra.PedCompraMonto,  "
            strSQL &= "    comPedCompra.MontoRec,  "
            strSQL &= "    comPedCompra.MontoDes,  "
            strSQL &= "    comPedCompra.MontoLiq,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    CONVERT(bit, 0) As RowImport  "
            strSQL &= " FROM comPedCompra, invAlmacen, tblMoneda, comCompra, tblEstado, comProveedor, tblSucursal "

            Case SelectFilters.ComprasProveedor
                strSQL = " SELECT "
                strSQL &= " comPedCompra.Fecha, "
                strSQL &= " comPedCompra.MonedaId, "
                strSQL &= " comPedCompra.TipoCambio, "
                strSQL &= " comPedCompra.EstadoId, "
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
                'strSQL &= " comPedCompraDet.PedCompraDetId, "
                'strSQL &= " comPedCompraDet.Fecha as FechaDet, "
                'strSQL &= " comPedCompraDet.Cantidad "
                strSQL &= " comCompraPedidoDet.CompraId, "
                strSQL &= " comCompraPedidoDet.Cantidad "
                strSQL &= " FROM comPedCompra, invItem, invMedida, tblCentroCosto, comProveedor, comCompraPedidoDet "

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
            strSQL = " WHERE  comPedCompra.PedCompraId = " & NumberToField(mlngPedCompraId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comPedCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comPedCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comPedCompra.CompraId = comCompra.CompraId "
            strSQL &= " AND  comPedCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comPedCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comPedCompra.AppId = secApp.AppId "
            strSQL &= " AND  comPedCompra.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " AND  comPedCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comPedCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comPedCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comPedCompra.CompraId = comCompra.CompraId "
            strSQL &= " AND  comPedCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comPedCompra.PedCompraId = comPedCompraDet.PedCompraId "
            strSQL &= " AND  comPedCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comPedCompraDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.AlmacenId
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " AND  comPedCompra.AlmacenId = " & NumberToField(mlngAlmacenId)

         Case WhereFilters.GestionId
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.ProveedorId
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)

         Case WhereFilters.GridEstadoId
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            ''strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comPedCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comPedCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comPedCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comPedCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comPedCompra.AppId = secApp.AppId "
            strSQL &= " AND  comPedCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  ( comPedCompra.EstadoId = " & NumberToField(clsEstado.APROBADO)
            strSQL &= "  OR   comPedCompra.EstadoId = " & NumberToField(clsEstado.PARCIAL)
            strSQL &= "  ) "

            ''para ver Pedidos de Otras gestiones mas
            If mlngCentroCostoId = 0 Then
               strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            Else
               strSQL &= " AND  ( comPedCompra.GestionId = " & NumberToField(mlngGestionId)
               strSQL &= "       OR  comPedCompra.GestionId = " & NumberToField(mlngCentroCostoId) & ") "
               strSQL &= " AND  comPedCompra.PedCompraId NOT IN (SELECT PedCompraId FROM comAnticipo "
               strSQL &= "                                     WHERE GestionId =" & NumberToField(mlngCentroCostoId) & ") "

            End If

         Case WhereFilters.EstadoId
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)

            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            If mlngPedCompraId = 0 Then
               strSQL &= " AND  comPedCompra.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (comPedCompra.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  comPedCompra.PedCompraId = " & NumberToField(mlngPedCompraId) & ") "
            End If

         Case WhereFilters.ProveedorIdDelete
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)

         Case WhereFilters.PedCompraMov
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPedCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            If mlngEstadoId > 0 Then
               strSQL &= " AND  comPedCompra.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  comPedCompra.EstadoId <> 12 "
            End If
            strSQL &= " AND  comPedCompra.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.PedCompraMovFecha
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comPedCompra.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comPedCompra.Fecha <= " & DateToField(mstrLastUpdateDate)

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPedCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            If mlngEstadoId > 0 Then
               strSQL &= " AND  comPedCompra.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  comPedCompra.EstadoId <> 12 "
            End If
            strSQL &= " AND  comPedCompra.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.PedCompraNro
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompra.PedCompraNro = " & NumberToField(mlngPedCompraNro)

         Case WhereFilters.EstadoId_CentroCosto
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)

            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            If mlngPedCompraId = 0 Then
               strSQL &= " AND  comPedCompra.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (comPedCompra.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  comPedCompra.PedCompraId = " & NumberToField(mlngPedCompraId) & ") "
            End If

            strSQL &= " AND  comPedCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)

         Case WhereFilters.PedCompraMovAll
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comPedCompra.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPedCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comPedCompra.EstadoId = tblEstado.EstadoId "

            strSQL &= " AND  (comPedCompra.EstadoId = 13 "
            strSQL &= " OR  comPedCompra.EstadoId = 7 "
            strSQL &= " OR  comPedCompra.EstadoId = " & NumberToField(clsEstado.APROBADO)
            strSQL &= " OR  comPedCompra.EstadoId = 14 )"

         Case WhereFilters.PedCompraMovAllFecha
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comPedCompra.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPedCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            strSQL &= " AND  comPedCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comPedCompra.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comPedCompra.Fecha <= " & DateToField(mstrLastUpdateDate)

            strSQL &= " AND  (comPedCompra.EstadoId = 13 "
            strSQL &= " OR  comPedCompra.EstadoId = 7 "
            strSQL &= " OR  comPedCompra.EstadoId = " & NumberToField(clsEstado.APROBADO)
            strSQL &= " OR  comPedCompra.EstadoId = 14 )"

         Case WhereFilters.PedCompraMovEntregaPend
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comPedCompra.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPedCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comPedCompra.EstadoId = tblEstado.EstadoId "

            strSQL &= " AND  (comPedCompra.EstadoId = " & NumberToField(clsEstado.APROBADO)
            strSQL &= " OR  comPedCompra.EstadoId = " & NumberToField(clsEstado.PARCIAL) & ")"

            strSQL &= " AND  comPedCompra.PedCompraId IN (SELECT comPedCompraDet.PedCompraId FROM comPedCompraDet "
            strSQL &= " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompraDet.Cantidad - comPedCompraDet.CantidadEnt > 0 "
            strSQL &= " ) "

         Case WhereFilters.PedCompraMovEntregaPendFecha
            strSQL = " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompra.GestionId = " & NumberToField(mlngGestionId)
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPedCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comPedCompra.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPedCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            strSQL &= " AND  comPedCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comPedCompra.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comPedCompra.Fecha <= " & DateToField(mstrLastUpdateDate)

            strSQL &= " AND  (comPedCompra.EstadoId = " & NumberToField(clsEstado.APROBADO)
            strSQL &= " OR  comPedCompra.EstadoId = " & NumberToField(clsEstado.PARCIAL) & ")"

            strSQL &= " AND  comPedCompra.PedCompraId IN (SELECT comPedCompraDet.PedCompraId FROM comPedCompraDet "
            strSQL &= " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompraDet.Cantidad - comPedCompraDet.CantidadEnt > 0 "
            strSQL &= " ) "

            Case WhereFilters.ComprasProveedor
                strSQL = " WHERE comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
                strSQL &= " AND comPedCompra.GestionId = " & NumberToField(mlngGestionId) ''Por don Alejandro AMC
                If mlngSucursalId > 0 Then
                    strSQL &= " AND comPedCompra.SucursalId = " & NumberToField(mlngSucursalId)
                End If
                strSQL &= " AND comPedCompra.PedCompraId = comCompraPedidoDet.PedCompraId "
                strSQL &= " AND comPedCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
                strSQL &= " AND comPedCompra.ProveedorId = comProveedor.ProveedorId"
                strSQL &= " AND comCompraPedidoDet.ItemId = invItem.ItemId"
                strSQL &= " AND invItem.MedidaId = invMedida.MedidaId"
                strSQL &= " AND comPedCompra.EstadoId <> 12 "
                strSQL &= " AND comPedCompra.Fecha >= " & DateToField(mstrFecha)
                strSQL &= " AND comPedCompra.Fecha <= " & DateToField(mstrLastUpdateDate)

        End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PedCompraId
            strSQL = " ORDER BY comPedCompra.PedCompraId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comPedCompra.PedCompraId DESC"

         Case OrderByFilters.PedCompraDes
            strSQL = " ORDER BY comPedCompra.PedCompraDes "

         Case OrderByFilters.Report
                strSQL = " ORDER BY comPedCompra.PedCompraId "

         Case OrderByFilters.PedCompraNro
            strSQL = " ORDER BY comPedCompra.PedCompraNro "

         Case OrderByFilters.Fecha
            strSQL = " ORDER BY comPedCompra.Fecha, comPedCompra.PedCompraNro "

         Case OrderByFilters.GridFecha
            strSQL = " ORDER BY comPedCompra.Fecha, comPedCompra.PedCompraId "

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
            strSQL = "INSERT INTO comPedCompra ("
            strSQL &= "PedCompraId, "
            strSQL &= "EmpresaId, "
            strSQL &= "PedCompraNro, "
            strSQL &= "Fecha, "
            strSQL &= "AlmacenId, "
            strSQL &= "ProveedorId, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "PedCompraOrden, "
            strSQL &= "PedCompraDes, "
            strSQL &= "PedCompraObs, "
            strSQL &= "PedCompraMonto, "
            strSQL &= "MontoRec,  "
            strSQL &= "MontoDes,  "
            strSQL &= "MontoLiq,  "
            strSQL &= "GestionId, "
            strSQL &= "CompraId, "
            strSQL &= "CentroCostoId, "
            strSQL &= "FechaEnt,  "
            strSQL &= "MontoEnt,  "
            strSQL &= "SucursalId, "
            strSQL &= "AppId, "
            strSQL &= "TipoDocumentoId, "
            strSQL &= "DocumentoId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPedCompraId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngPedCompraNro) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= StringToField(mstrPedCompraOrden) & ", "
            strSQL &= StringToField(mstrPedCompraDes) & ", "
            strSQL &= StringToField(mstrPedCompraObs) & ", "
            strSQL &= DecimalToField(mdecPedCompraMonto) & ", "
            strSQL &= DecimalToField(mdecMontoRec) & ", "
            strSQL &= DecimalToField(mdecMontoDes) & ", "
            strSQL &= DecimalToField(mdecMontoLiq) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= DateToField(mstrFechaEnt) & ", "
            strSQL &= DecimalToField(mdecMontoEnt) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
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
            strSQL = "UPDATE comPedCompra SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "PedCompraNro = " & NumberToField(mlngPedCompraNro) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "PedCompraOrden = " & StringToField(mstrPedCompraOrden) & ", "
            strSQL &= "PedCompraDes = " & StringToField(mstrPedCompraDes) & ", "
            strSQL &= "PedCompraObs = " & StringToField(mstrPedCompraObs) & ", "
            strSQL &= "PedCompraMonto = " & DecimalToField(mdecPedCompraMonto) & ", "
            strSQL &= "MontoRec = " & DecimalToField(mdecMontoRec) & ", "
            strSQL &= "MontoDes = " & DecimalToField(mdecMontoDes) & ", "
            strSQL &= "MontoLiq = " & DecimalToField(mdecMontoLiq) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "FechaEnt = " & DateToField(mstrFechaEnt) & ", "
            strSQL &= "MontoEnt = " & DecimalToField(mdecMontoEnt) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PedCompraId = " & NumberToField(mlngPedCompraId) & " "

         Case UpdateFilters.CompraId
            strSQL = "UPDATE comPedCompra SET "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PedCompraId = " & NumberToField(mlngPedCompraId) & " "

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
               mlngPedCompraId = ToLong(oDataRow("PedCompraId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngPedCompraNro = ToLong(oDataRow("PedCompraNro"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mstrPedCompraOrden = ToStr(oDataRow("PedCompraOrden"))
               mstrPedCompraDes = ToStr(oDataRow("PedCompraDes"))
               mstrPedCompraObs = ToStr(oDataRow("PedCompraObs"))
               mdecPedCompraMonto = ToDecimal(oDataRow("PedCompraMonto"))
               mdecMontoRec = ToDecimal(oDataRow("MontoRec"))
               mdecMontoDes = ToDecimal(oDataRow("MontoDes"))
               mdecMontoLiq = ToDecimal(oDataRow("MontoLiq"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mstrFechaEnt = ToDateDMY(oDataRow("FechaEnt"))
               mdecMontoEnt = ToDecimal(oDataRow("MontoEnt"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngTipoDocumentoId = ToLong(oDataRow("TipoDocumentoId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPedCompraId = ToLong(oDataRow("PedCompraId"))
               mstrPedCompraDes = ToStr(oDataRow("PedCompraDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPedCompraId = TableIDGet(mstrTableName, "PedCompraId", moConnection)

         If mlngPedCompraId = -1 Then
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
            strMsg &= "Fecha Inválida" & vbCrLf
         End If
      Else
         strMsg &= "Fecha Inválida" & vbCrLf
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
         'strSQL &= " FROM comPedCompra "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comPedCompra.TipoPedCompraId = " & NumberToField(mlngTipoPedCompraId)
         'Else
         '   strSQL &= " WHERE  comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comPedCompra.TipoPedCompraId = " & NumberToField(mlngTipoPedCompraId)
         '   strSQL &= " AND  comPedCompra.PedCompraId <> " & NumberToField(mlngPedCompraId)
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
