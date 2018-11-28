Imports System.Data
Imports System.Data.OleDb

Public Class clsAnticipo
   Implements IDisposable

   Private mlngAnticipoId As Long
   Private mlngEmpresaId As Long
   Private mlngTipoAnticipoId As Long
   Private mlngAnticipoNro As Long
   Private mstrFecha As String
   Private mlngPedCompraId As Long
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mstrAnticipoDes As String
   Private mstrAnticipoObs As String
   Private mdecMontoAnt As Decimal
   Private mdecMontoDes As Decimal
   Private mlngGestionId As Long
   Private mlngPlanId As Long
   Private mbytSinFac As Byte
   Private mbytConFac As Byte
   Private mlngCentroCostoId As Long
   Private mstrAnticipoOrden As String
   Private mlngAnticipoIdOrg As Long
   Private mlngSucursalId As Long
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
   Property AnticipoId() As Long
      Get
         Return mlngAnticipoId
      End Get

      Set(ByVal Value As Long)
         mlngAnticipoId = Value
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

   Property TipoAnticipoId() As Long
      Get
         Return mlngTipoAnticipoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoAnticipoId = Value
      End Set
   End Property

   Property AnticipoNro() As Long
      Get
         Return mlngAnticipoNro
      End Get

      Set(ByVal Value As Long)
         mlngAnticipoNro = Value
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

   Property PedCompraId() As Long
      Get
         Return mlngPedCompraId
      End Get

      Set(ByVal Value As Long)
         mlngPedCompraId = Value
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

   Property AnticipoDes() As String
      Get
         Return mstrAnticipoDes
      End Get

      Set(ByVal Value As String)
         mstrAnticipoDes = Value
      End Set
   End Property

   Property AnticipoObs() As String
      Get
         Return mstrAnticipoObs
      End Get

      Set(ByVal Value As String)
         mstrAnticipoObs = Value
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

   Property SinFac() As Byte
      Get
         Return mbytSinFac
      End Get

      Set(ByVal Value As Byte)
         mbytSinFac = Value
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

   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   Property AnticipoOrden() As String
      Get
         Return mstrAnticipoOrden
      End Get

      Set(ByVal Value As String)
         mstrAnticipoOrden = Value
      End Set
   End Property

   Property AnticipoIdOrg() As Long
      Get
         Return mlngAnticipoIdOrg
      End Get

      Set(ByVal Value As Long)
         mlngAnticipoIdOrg = Value
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
      GridCompraNew = 4
      GridCompraShow = 5
      FlujoCaja = 6
      GRID_IMPORT = 7
      ProveedorDistinct = 8
      PedCompraDistinct = 9
      AnticipoNro = 10
      NRO_ANTICIPO_PEDIDO = 11
      SucursalDistinct = 12
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      AlmacenId = 6
      GestionId = 7
      GridCompraNew = 8
      GridCompraEdit = 9
      GridCompraShow = 10
      GridPedCompraNew = 11
      PedCompraId = 12
      EstadoId = 13
      ProveedorId = 14
      ProveedorEstadoId = 15
      ProveedorIdDelete = 16
      FlujoCaja = 17
      FlujoCajaFecha = 18
      AnticipoNro = 19
      ProveedorDistinct = 20
      PedCompraDistinct = 21
      AnticipoNroDet = 22
      GRID_IMPORT = 23
      GridPagoNew = 24
      NRO_ANTICIPO_PEDIDO = 25
      TienePedCompraId = 26
      GestionMov = 27
      SucursalDistinct = 28
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      AnticipoId = 1
      Grid = 3
      Report = 4
      AnticipoDes = 5
      GridCompra = 6
      AnticipoNro = 7
      GridFecha = 8
      ProveedorId = 9
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
      mstrTableName = "comAnticipo"
      mstrClassName = "clsAnticipo"

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
      mlngAnticipoId = 0
      mlngEmpresaId = 0
      mlngTipoAnticipoId = 0
      mlngAnticipoNro = 0
      mstrFecha = ""
      mlngPedCompraId = 0
      mlngProveedorId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mstrAnticipoDes = ""
      mstrAnticipoObs = ""
      mdecMontoAnt = 0
      mdecMontoDes = 0
      mlngGestionId = 0
      mlngPlanId = 0
      mbytSinFac = 0
      mbytConFac = 0
      mlngCentroCostoId = 0
      mstrAnticipoOrden = ""
      mlngAnticipoIdOrg = 0
      mlngSucursalId = 0
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
            strSQL &= "    comAnticipo.AnticipoId,  "
            strSQL &= "    comAnticipo.EmpresaId,  "
            strSQL &= "    comAnticipo.TipoAnticipoId,  "
            strSQL &= "    comAnticipo.AnticipoNro,  "
            strSQL &= "    comAnticipo.Fecha,  "
            strSQL &= "    comAnticipo.PedCompraId,  "
            strSQL &= "    comAnticipo.ProveedorId,  "
            strSQL &= "    comAnticipo.MonedaId,  "
            strSQL &= "    comAnticipo.TipoCambio,  "
            strSQL &= "    comAnticipo.AnticipoDes,  "
            strSQL &= "    comAnticipo.AnticipoObs,  "
            strSQL &= "    comAnticipo.MontoAnt,  "
            strSQL &= "    comAnticipo.MontoDes,  "
            strSQL &= "    comAnticipo.GestionId,  "
            strSQL &= "    comAnticipo.PlanId,  "
            strSQL &= "    comAnticipo.SinFac,  "
            strSQL &= "    comAnticipo.ConFac,  "
            strSQL &= "    comAnticipo.CentroCostoId,  "
            strSQL &= "    comAnticipo.AnticipoOrden,  "
            strSQL &= "    comAnticipo.AnticipoIdOrg,  "
            strSQL &= "    comAnticipo.SucursalId,  "
            strSQL &= "    comAnticipo.CompId,  "
            strSQL &= "    comAnticipo.AppId,  "
            strSQL &= "    comAnticipo.TipoDocumentoId,  "
            strSQL &= "    comAnticipo.DocumentoId,  "
            strSQL &= "    comAnticipo.EstadoId,  "
            strSQL &= "    comAnticipo.sLastUpdate_id,  "
            strSQL &= "    comAnticipo.dtLastUpdate_dt,  "
            strSQL &= "    comAnticipo.iConcurrency_id  "
            strSQL &= " FROM comAnticipo "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comAnticipo.AnticipoId,  "
            strSQL &= "    comAnticipo.AnticipoDes  "
            strSQL &= " FROM comAnticipo "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            If mintRowsMax > 0 Then strSQL &= " TOP " & NumberToField(mintRowsMax) & "  "
            strSQL &= "    comAnticipo.AnticipoId,  "
            strSQL &= "    comAnticipo.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comAnticipo.Fecha,  "
            strSQL &= "    comTipoAnticipo.TipoAnticipoId,  "
            strSQL &= "    comTipoAnticipo.TipoAnticipoDes,  "
            strSQL &= "    comAnticipo.AnticipoNro,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comAnticipo.AnticipoOrden,  "
            strSQL &= "    comAnticipo.AnticipoDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comAnticipo.TipoCambio,  "
            strSQL &= "    comAnticipo.MontoAnt,  "
            strSQL &= "    comAnticipo.MontoDes,  "
            strSQL &= "    (comAnticipo.MontoAnt - comAnticipo.MontoDes) As MontoPen,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    comAnticipo.SinFac,  "
            strSQL &= "    comAnticipo.ConFac,  "
            strSQL &= "    comAnticipo.AnticipoObs,  "
            strSQL &= "    comAnticipo.sLastUpdate_id,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    secApp.AppId,  "
            strSQL &= "    secApp.AppDes,  "
            strSQL &= "    comAnticipo.TipoDocumentoId,  "
            strSQL &= "    comAnticipo.DocumentoId,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comAnticipo, comTipoAnticipo, comPedCompra, comProveedor, tblMoneda, tblComp, tblTipoComp, tblEstado, tblCentroCosto, tblSucursal, secApp "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    comAnticipo.AnticipoId,  "
            strSQL &= "    comAnticipo.EmpresaId,  "
            strSQL &= "    comAnticipo.Fecha,  "
            strSQL &= "    comTipoAnticipo.TipoAnticipoId,  "
            strSQL &= "    comTipoAnticipo.TipoAnticipoDes,  "
            strSQL &= "    comAnticipo.AnticipoNro,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comAnticipo.AnticipoDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comAnticipo.TipoCambio,  "
            strSQL &= "    comAnticipo.MontoAnt,  "
            strSQL &= "    comAnticipo.MontoDes,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    comAnticipo.AnticipoObs,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comAnticipo, comTipoAnticipo, comPedCompra, comProveedor, tblMoneda, tblComp, tblTipoComp, tblEstado, tblSucursal "

         Case SelectFilters.GridCompraNew
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comAnticipo.AnticipoId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comAnticipo.TipoAnticipoId,  "
            strSQL &= "    comAnticipo.AnticipoNro,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comAnticipo.SinFac,  "
            strSQL &= "    comAnticipo.ConFac,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    comAnticipo.MontoAnt,  "
            strSQL &= "    (comAnticipo.MontoAnt - comAnticipo.MontoDes) As MontoPen,  "
            strSQL &= "    (comAnticipo.MontoAnt - comAnticipo.MontoAnt) As Monto  "
            strSQL &= " FROM comAnticipo, comPedCompra, tblMoneda, tblCentroCosto, tblSucursal "

         Case SelectFilters.GridCompraShow
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comAnticipo.AnticipoId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comAnticipo.TipoAnticipoId,  "
            strSQL &= "    comAnticipo.AnticipoNro,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comAnticipo.SinFac,  "
            strSQL &= "    comAnticipo.ConFac,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    comAnticipo.MontoAnt,  "
            strSQL &= "    comAnticipo.MontoDes,  "
            strSQL &= "    comAnticipoDet.Monto  "
            strSQL &= " FROM comAnticipo, comPedCompra, tblMoneda, comAnticipoDet, tblCentroCosto, tblSucursal "

         Case SelectFilters.FlujoCaja
            strSQL = " SELECT  "
            strSQL &= "    comAnticipo.ProveedorId,  "
            strSQL &= "    comAnticipo.TipoAnticipoId,  "
            strSQL &= "    comAnticipo.MonedaId,  "
            strSQL &= "    comAnticipo.TipoCambio,  "
            strSQL &= "    comAnticipo.MontoAnt  "
            strSQL &= " FROM comAnticipo "

         Case SelectFilters.GRID_IMPORT
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comAnticipo.AnticipoId,  "
            strSQL &= "    comAnticipo.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comAnticipo.Fecha,  "
            strSQL &= "    comTipoAnticipo.TipoAnticipoId,  "
            strSQL &= "    comTipoAnticipo.TipoAnticipoDes,  "
            strSQL &= "    comAnticipo.AnticipoNro,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comAnticipo.AnticipoDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comAnticipo.TipoCambio,  "
            strSQL &= "    comAnticipo.MontoAnt,  "
            strSQL &= "    comAnticipo.MontoDes,  "
            strSQL &= "    (comAnticipo.MontoAnt - comAnticipo.MontoDes) As MontoPen,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.TipoPlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    comAnticipo.SinFac,  "
            strSQL &= "    comAnticipo.ConFac,  "
            strSQL &= "    comAnticipo.AnticipoObs,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    CONVERT(bit, 0) As RowImport  "
            strSQL &= " FROM comAnticipo, comTipoAnticipo, comPedCompra, comProveedor, tblMoneda, tblComp, tblTipoComp, tblEstado, tblPlan, tblSucursal "

         Case SelectFilters.ProveedorDistinct
            strSQL = " SELECT DISTINCT "
            strSQL &= "    comAnticipo.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorCod  "
            strSQL &= " FROM comAnticipo, comProveedor "

         Case SelectFilters.PedCompraDistinct
            strSQL = " SELECT DISTINCT "
            strSQL &= "    comAnticipo.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro  "
            strSQL &= " FROM comAnticipo, comPedCompra "

         Case SelectFilters.AnticipoNro
            strSQL = " SELECT "
            strSQL &= "    comAnticipo.AnticipoNro  "
            strSQL &= " FROM comAnticipo "

         Case SelectFilters.NRO_ANTICIPO_PEDIDO
            strSQL = " SELECT DISTINCT "
            strSQL &= "    comAnticipo.AnticipoId,  "
            strSQL &= "    comAnticipo.AnticipoNro,  "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompra.PedCompraNro  "
            strSQL &= " FROM comAnticipo, comPedCompra "

         Case SelectFilters.SucursalDistinct
            strSQL = " SELECT DISTINCT "
            strSQL &= "    comAnticipo.SucursalId  "
            strSQL &= " FROM comAnticipo "

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
            strSQL = " WHERE  comAnticipo.AnticipoId = " & NumberToField(mlngAnticipoId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.TipoAnticipoId = comTipoAnticipo.TipoAnticipoId "
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comAnticipo.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comAnticipo.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comAnticipo.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comAnticipo.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comAnticipo.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comAnticipo.AppId = secApp.AppId "
            strSQL &= " AND  comAnticipo.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.GRID_IMPORT
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.TipoAnticipoId = comTipoAnticipo.TipoAnticipoId "
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comAnticipo.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comAnticipo.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comAnticipo.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comAnticipo.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comAnticipo.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comAnticipo.PlanId = tblPlan.PlanId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.AnticipoId = " & NumberToField(mlngAnticipoId)
            strSQL &= " AND  comAnticipo.TipoAnticipoId = comTipoAnticipo.TipoAnticipoId "
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comAnticipo.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comAnticipo.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comAnticipo.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comAnticipo.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comAnticipo.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.AlmacenId

         Case WhereFilters.GestionId
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.GridCompraNew
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comAnticipo.TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId)
            strSQL &= " AND  comAnticipo.PedCompraId IN (" & mstrAnticipoDes & ")"
            strSQL &= " AND  comAnticipo.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comAnticipo.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comAnticipo.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comAnticipo.MonedaId = tblMoneda.MonedaId "

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comAnticipo.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If

            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comAnticipo.SucursalId = " & NumberToField(mlngSucursalId)
            End If

         Case WhereFilters.GridCompraEdit
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comAnticipo.TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId)
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comAnticipo.MonedaId = tblMoneda.MonedaId "

         Case WhereFilters.GridCompraShow
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.AnticipoId = comAnticipoDet.AnticipoId "
            strSQL &= " AND  comAnticipoDet.TipoCompraId = " & NumberToField(mlngTipoAnticipoId) 'TipoCompraId
            strSQL &= " AND  comAnticipoDet.DocumentoId = " & NumberToField(mlngPedCompraId) 'DocumentoId
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comAnticipo.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comAnticipo.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comAnticipo.MonedaId = tblMoneda.MonedaId "

         Case WhereFilters.PedCompraId
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.PedCompraId = " & NumberToField(mlngPedCompraId)

         Case WhereFilters.EstadoId
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.ProveedorId
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.ProveedorId = " & NumberToField(mlngProveedorId)

         Case WhereFilters.ProveedorEstadoId
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId)
            strSQL &= " AND  comAnticipo.ProveedorId = " & NumberToField(mlngProveedorId)

            If mlngAnticipoId = 0 Then
               strSQL &= " AND  comAnticipo.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (comAnticipo.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  comAnticipo.AnticipoId = " & NumberToField(mlngAnticipoId) & ") "
            End If

            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comAnticipo.SucursalId = " & NumberToField(mlngSucursalId)
            End If

         Case WhereFilters.ProveedorIdDelete
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.ProveedorId = " & NumberToField(mlngProveedorId)

         Case WhereFilters.FlujoCaja
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comAnticipo.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoAnticipoId <> 0 Then
               strSQL &= " AND  comAnticipo.TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comAnticipo.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comAnticipo.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comAnticipo.EstadoId <> 12 "
            strSQL &= " AND  comAnticipo.EstadoId <> 0 "

         Case WhereFilters.FlujoCajaFecha
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comAnticipo.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoAnticipoId <> 0 Then
               strSQL &= " AND  comAnticipo.TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comAnticipo.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comAnticipo.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comAnticipo.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comAnticipo.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  comAnticipo.EstadoId <> 12 "
            strSQL &= " AND  comAnticipo.EstadoId <> 0 "

         Case WhereFilters.GridPedCompraNew
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comAnticipo.TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId)
            strSQL &= " AND  comAnticipo.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comAnticipo.MonedaId = tblMoneda.MonedaId "

         Case WhereFilters.AnticipoNro
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.AnticipoNro = " & NumberToField(mlngAnticipoNro)

         Case WhereFilters.ProveedorDistinct
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.ProveedorId = comProveedor.ProveedorId "

         Case WhereFilters.PedCompraDistinct
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "

         Case WhereFilters.AnticipoNroDet
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.AnticipoId IN ( SELECT comAnticipoDet.AnticipoId "
            strSQL &= " FROM  comAnticipoDet "
            strSQL &= " WHERE comAnticipoDet.DocumentoId = " & NumberToField(mlngAnticipoId)
            strSQL &= " AND comAnticipoDet.TipoCompraId = " & NumberToField(mlngTipoAnticipoId)
            strSQL &= " ) "

         Case WhereFilters.GridPagoNew
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comAnticipo.TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId)
            strSQL &= " AND  (comAnticipo.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " OR  comAnticipo.PedCompraId = " & NumberToField(mlngCompId) & ")"
            strSQL &= " AND  comAnticipo.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comAnticipo.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comAnticipo.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comAnticipo.MonedaId = tblMoneda.MonedaId "

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comAnticipo.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If

            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comAnticipo.SucursalId = " & NumberToField(mlngSucursalId)
            End If

         Case WhereFilters.NRO_ANTICIPO_PEDIDO
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.EstadoId <> 12 "
            strSQL &= " AND  comAnticipo.PedCompraId = comPedCompra.PedCompraId "

         Case WhereFilters.TienePedCompraId
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " AND  comAnticipo.EstadoId <> 12"

         Case WhereFilters.GestionMov
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comAnticipo.EstadoId not in (12,0) "

         Case WhereFilters.SucursalDistinct
            strSQL = " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comAnticipo.GestionId = " & NumberToField(mlngGestionId)
            If mlngEstadoId <> 0 Then
               strSQL &= " AND  comAnticipo.EstadoId = " & NumberToField(mlngEstadoId)
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.AnticipoId
            strSQL = " ORDER BY comAnticipo.AnticipoId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comAnticipo.AnticipoId DESC"

         Case OrderByFilters.AnticipoDes
            strSQL = " ORDER BY comAnticipo.AnticipoDes "

         Case OrderByFilters.Report

         Case OrderByFilters.GridCompra
            strSQL = " ORDER BY comAnticipo.AnticipoId"

         Case OrderByFilters.AnticipoNro
            strSQL = " ORDER BY comAnticipo.AnticipoNro "

         Case OrderByFilters.GridFecha
            strSQL = " ORDER BY comAnticipo.Fecha, comAnticipo.AnticipoId "

         Case OrderByFilters.ProveedorId
            strSQL = " ORDER BY comAnticipo.ProveedorId "


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
            strSQL = "INSERT INTO comAnticipo ("
            strSQL &= "AnticipoId, "
            strSQL &= "EmpresaId, "
            strSQL &= "TipoAnticipoId, "
            strSQL &= "AnticipoNro, "
            strSQL &= "Fecha, "
            strSQL &= "PedCompraId, "
            strSQL &= "ProveedorId, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "AnticipoDes, "
            strSQL &= "AnticipoObs, "
            strSQL &= "MontoAnt, "
            strSQL &= "MontoDes, "
            strSQL &= "GestionId, "
            strSQL &= "PlanId, "
            strSQL &= "SinFac, "
            strSQL &= "ConFac, "
            strSQL &= "CentroCostoId, "
            strSQL &= "AnticipoOrden, "
            strSQL &= "AnticipoIdOrg, "
            strSQL &= "SucursalId, "
            strSQL &= "CompId, "
            strSQL &= "AppId, "
            strSQL &= "TipoDocumentoId, "
            strSQL &= "DocumentoId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngAnticipoId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngTipoAnticipoId) & ", "
            strSQL &= NumberToField(mlngAnticipoNro) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngPedCompraId) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= StringToField(mstrAnticipoDes) & ", "
            strSQL &= StringToField(mstrAnticipoObs) & ", "
            strSQL &= DecimalToField(mdecMontoAnt) & ", "
            strSQL &= DecimalToField(mdecMontoDes) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mbytSinFac) & ", "
            strSQL &= NumberToField(mbytConFac) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= StringToField(mstrAnticipoOrden) & ", "
            strSQL &= NumberToField(mlngAnticipoIdOrg) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
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
            strSQL = "UPDATE comAnticipo SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId) & ", "
            strSQL &= "AnticipoNro = " & NumberToField(mlngAnticipoNro) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "PedCompraId = " & NumberToField(mlngPedCompraId) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "AnticipoDes = " & StringToField(mstrAnticipoDes) & ", "
            strSQL &= "AnticipoObs = " & StringToField(mstrAnticipoObs) & ", "
            strSQL &= "MontoAnt = " & DecimalToField(mdecMontoAnt) & ", "
            strSQL &= "MontoDes = " & DecimalToField(mdecMontoDes) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "SinFac = " & NumberToField(mbytSinFac) & ", "
            strSQL &= "ConFac = " & NumberToField(mbytConFac) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "AnticipoOrden = " & StringToField(mstrAnticipoOrden) & ", "
            strSQL &= "AnticipoIdOrg = " & NumberToField(mlngAnticipoIdOrg) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " AnticipoId = " & NumberToField(mlngAnticipoId) & " "

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
               mlngAnticipoId = ToLong(oDataRow("AnticipoId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngTipoAnticipoId = ToLong(oDataRow("TipoAnticipoId"))
               mlngAnticipoNro = ToLong(oDataRow("AnticipoNro"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngPedCompraId = ToLong(oDataRow("PedCompraId"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mstrAnticipoDes = ToStr(oDataRow("AnticipoDes"))
               mstrAnticipoObs = ToStr(oDataRow("AnticipoObs"))
               mdecMontoAnt = ToDecimal(oDataRow("MontoAnt"))
               mdecMontoDes = ToDecimal(oDataRow("MontoDes"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mbytSinFac = ToBoolean(oDataRow("SinFac"))
               mbytConFac = ToBoolean(oDataRow("ConFac"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mstrAnticipoOrden = ToStr(oDataRow("AnticipoOrden"))
               mlngAnticipoIdOrg = ToLong(oDataRow("AnticipoIdOrg"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngTipoDocumentoId = ToLong(oDataRow("TipoDocumentoId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngAnticipoId = ToLong(oDataRow("AnticipoId"))
               mstrAnticipoDes = ToStr(oDataRow("AnticipoDes"))

            Case SelectFilters.FlujoCaja
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngTipoAnticipoId = ToLong(oDataRow("TipoAnticipoId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mdecMontoAnt = ToDecimal(oDataRow("MontoAnt"))

            Case SelectFilters.AnticipoNro
               mlngAnticipoNro = ToLong(oDataRow("AnticipoNro"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngAnticipoId = TableIDGet(mstrTableName, "AnticipoId", moConnection)

         If mlngAnticipoId = -1 Then
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

      If mlngSucursalId <= 0 Then
         strMsg &= "Sucursal Inválido" & vbCrLf
      End If

      If mlngTipoAnticipoId = 0 Then
         strMsg &= "Tipo Inválido" & vbCrLf
      End If

      If mdecMontoAnt = 0 Then
         strMsg &= "Monto Inválido" & vbCrLf
      End If

      If (mstrFecha.Trim() <> String.Empty) And (mstrFecha.Trim() <> "01/01/1990") Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha Inválida" & vbCrLf
         End If
      Else
         strMsg &= "Fecha Inválida" & vbCrLf
      End If

      'If mlngPedCompraId = 0 Then
      '   strMsg &= "Pedido de Compra Inválido" & vbCrLf
      'End If

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
         'strSQL &= " FROM comAnticipo "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comAnticipo.TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId)
         'Else
         '   strSQL &= " WHERE  comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comAnticipo.TipoAnticipoId = " & NumberToField(mlngTipoAnticipoId)
         '   strSQL &= " AND  comAnticipo.AnticipoId <> " & NumberToField(mlngAnticipoId)
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
