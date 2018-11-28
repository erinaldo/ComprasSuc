Imports System.Data
Imports System.Data.OleDb

Public Class clsVentaPara
   Implements IDisposable

   Private mlngVentaParaId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoVentaId As Long
   Private mlngSucursalId As Long
   Private mlngNroIni As Long
   Private mlngNroActual As Long
   Private mbytPagoAuto As Byte
   Private mbytPrintAuto As Byte
   Private mbytUltimoRegistro As Byte
   Private mbytConFac As Byte
   Private mstrTitulo As String
   Private mstrFirma As String
   Private mstrObs As String
   Private mlngTipoHojaId As Long
   Private mlngRowsMax As Long
   Private mlngEstadoId As Long
   Private mboolRestricted As Boolean
   Private mlngGroupId As Long
   Private mboolViewCosto As Boolean
   Private mlngDosificaId As Long
   Private mboolFacturaCompu As Boolean
   Private mbytMultiSuc As Byte
   Private mdecCantItem As Decimal
   Private mlngTipoImpresionId As Long
   Private mlngNroCopia As Long
   Private mbytPrintOrigCopia As Byte
   Private mlngOrden As Long
   Private mboolTicketFac As Boolean
   Private mboolTicketNota As Boolean
   Private mlngTipoFormImpId As Long
   Private mbytNroOrdenDup As Byte
   Private mbytExigirNroOrden As Byte
   Private mbytExigirFacturaDif As Byte
   Private mbytFacFechaMen As Byte
   Private mbytEditarPrecio As Byte
   Private mbytSaldoItemPed As Byte
   Private mdecMontoMaxVtaNit As Decimal
   Private mbytComisionItem As Byte
   Private mbytNotaEntregaAuto As Byte
   Private mbytIncluirNotaEntregaCons As Byte
   Private mbytAprobadoAutoDoc As Byte
   Private mstrIsoDes As String
   Private mstrEmisionDes As String
   Private mstrRevisionDes As String
   Private mbytPrintSave As Byte
   Private mstrDirPrintSave As String
   Private mbytCopyPed As Byte
   Private mbytEditarAlmPed As Byte
   Private mstrRepIsoDes As String
   Private mstrRepEmisionDes As String
   Private mstrRepRevisionDes As String
   Private mbytItemConSaldo As Byte
   Private mbytViewGestionOld As Byte

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
   Property VentaParaId() As Long
      Get
         Return mlngVentaParaId
      End Get

      Set(ByVal Value As Long)
         mlngVentaParaId = Value
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

   Property TipoVentaId() As Long
      Get
         Return mlngTipoVentaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoVentaId = Value
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

   Property NroIni() As Long
      Get
         Return mlngNroIni
      End Get

      Set(ByVal Value As Long)
         mlngNroIni = Value
      End Set
   End Property

   Property NroActual() As Long
      Get
         Return mlngNroActual
      End Get

      Set(ByVal Value As Long)
         mlngNroActual = Value
      End Set
   End Property

   Property PagoAuto() As Byte
      Get
         Return mbytPagoAuto
      End Get

      Set(ByVal Value As Byte)
         mbytPagoAuto = Value
      End Set
   End Property

   Property PrintAuto() As Byte
      Get
         Return mbytPrintAuto
      End Get

      Set(ByVal Value As Byte)
         mbytPrintAuto = Value
      End Set
   End Property

   Property UltimoRegistro() As Byte
      Get
         Return mbytUltimoRegistro
      End Get

      Set(ByVal Value As Byte)
         mbytUltimoRegistro = Value
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

   Property Titulo() As String
      Get
         Return mstrTitulo
      End Get

      Set(ByVal Value As String)
         mstrTitulo = Value
      End Set
   End Property

   Property Firma() As String
      Get
         Return mstrFirma
      End Get

      Set(ByVal Value As String)
         mstrFirma = Value
      End Set
   End Property

   Property Obs() As String
      Get
         Return mstrObs
      End Get

      Set(ByVal Value As String)
         mstrObs = Value
      End Set
   End Property

   Property TipoHojaId() As Long
      Get
         Return mlngTipoHojaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoHojaId = Value
      End Set
   End Property

   Property RowsMax() As Long
      Get
         Return mlngRowsMax
      End Get

      Set(ByVal Value As Long)
         mlngRowsMax = Value
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

   Property Restricted() As Boolean
      Get
         Return mboolRestricted
      End Get

      Set(ByVal Value As Boolean)
         mboolRestricted = Value
      End Set
   End Property

   Property GroupId() As Long
      Get
         Return mlngGroupId
      End Get

      Set(ByVal Value As Long)
         mlngGroupId = Value
      End Set
   End Property

   Property ViewCosto() As Boolean
      Get
         Return mboolViewCosto
      End Get

      Set(ByVal Value As Boolean)
         mboolViewCosto = Value
      End Set
   End Property

   Property DosificaId() As Long
      Get
         Return mlngDosificaId
      End Get

      Set(ByVal Value As Long)
         mlngDosificaId = Value
      End Set
   End Property

   Property TipoImpresionId() As Long
      Get
         Return mlngTipoImpresionId
      End Get

      Set(ByVal Value As Long)
         mlngTipoImpresionId = Value
      End Set
   End Property

   Property FacturaCompu() As Boolean
      Get
         Return mboolFacturaCompu
      End Get

      Set(ByVal Value As Boolean)
         mboolFacturaCompu = Value
      End Set
   End Property

   Property MultiSuc() As Byte
      Get
         Return mbytMultiSuc
      End Get

      Set(ByVal Value As Byte)
         mbytMultiSuc = Value
      End Set
   End Property

   Property CantItem() As Decimal
      Get
         Return mdecCantItem
      End Get

      Set(ByVal Value As Decimal)
         mdecCantItem = Value
      End Set
   End Property

   Property NroCopia() As Long
      Get
         Return mlngNroCopia
      End Get

      Set(ByVal Value As Long)
         mlngNroCopia = Value
      End Set
   End Property

   Property PrintOrigCopia() As Byte
      Get
         Return mbytPrintOrigCopia
      End Get

      Set(ByVal Value As Byte)
         mbytPrintOrigCopia = Value
      End Set
   End Property

   Property Orden() As Long
      Get
         Return mlngOrden
      End Get

      Set(ByVal Value As Long)
         mlngOrden = Value
      End Set
   End Property

   Property TicketFac() As Boolean
      Get
         Return mboolTicketFac
      End Get

      Set(ByVal Value As Boolean)
         mboolTicketFac = Value
      End Set
   End Property

   Property TicketNota() As Boolean
      Get
         Return mboolTicketNota
      End Get

      Set(ByVal Value As Boolean)
         mboolTicketNota = Value
      End Set
   End Property

   Property TipoFormImpId() As Long
      Get
         Return mlngTipoFormImpId
      End Get

      Set(ByVal Value As Long)
         mlngTipoFormImpId = Value
      End Set
   End Property

   Property NroOrdenDup() As Byte
      Get
         Return mbytNroOrdenDup
      End Get

      Set(ByVal Value As Byte)
         mbytNroOrdenDup = Value
      End Set
   End Property

   Property ExigirNroOrden() As Byte
      Get
         Return mbytExigirNroOrden
      End Get

      Set(ByVal Value As Byte)
         mbytExigirNroOrden = Value
      End Set
   End Property


   Property ExigirFacturaDif() As Byte
      Get
         Return mbytExigirFacturaDif
      End Get

      Set(ByVal Value As Byte)
         mbytExigirFacturaDif = Value
      End Set
   End Property

   Property FacFechaMen() As Byte
      Get
         Return mbytFacFechaMen
      End Get

      Set(ByVal Value As Byte)
         mbytFacFechaMen = Value
      End Set
   End Property

   Property EditarPrecio() As Byte
      Get
         Return mbytEditarPrecio
      End Get

      Set(ByVal Value As Byte)
         mbytEditarPrecio = Value
      End Set
   End Property

   Property SaldoItemPed() As Byte
      Get
         Return mbytSaldoItemPed
      End Get

      Set(ByVal Value As Byte)
         mbytSaldoItemPed = Value
      End Set
   End Property

   Property MontoMaxVtaNit() As Decimal
      Get
         Return mdecMontoMaxVtaNit
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoMaxVtaNit = Value
      End Set
   End Property

   Property ComisionItem() As Byte
      Get
         Return mbytComisionItem
      End Get

      Set(ByVal Value As Byte)
         mbytComisionItem = Value
      End Set
   End Property

   Property NotaEntregaAuto() As Byte
      Get
         Return mbytNotaEntregaAuto
      End Get

      Set(ByVal Value As Byte)
         mbytNotaEntregaAuto = Value
      End Set
   End Property

   Property IncluirNotaEntregaCons() As Byte
      Get
         Return mbytIncluirNotaEntregaCons
      End Get
      Set(ByVal value As Byte)
         mbytIncluirNotaEntregaCons = value
      End Set
   End Property

   Property AprobadoAutoDoc() As Byte
      Get
         Return mbytAprobadoAutoDoc
      End Get

      Set(ByVal value As Byte)
         mbytAprobadoAutoDoc = value
      End Set
   End Property

   Property IsoDes() As String
      Get
         Return mstrIsoDes
      End Get

      Set(ByVal Value As String)
         mstrIsoDes = Value
      End Set
   End Property

   Property EmisionDes() As String
      Get
         Return mstrEmisionDes
      End Get

      Set(ByVal Value As String)
         mstrEmisionDes = Value
      End Set
   End Property

   Property RevisionDes() As String
      Get
         Return mstrRevisionDes
      End Get

      Set(ByVal Value As String)
         mstrRevisionDes = Value
      End Set
   End Property

   Property PrintSave() As Byte
      Get
         Return mbytPrintSave
      End Get

      Set(ByVal value As Byte)
         mbytPrintSave = value
      End Set
   End Property

   Property DirPrintSave() As String
      Get
         Return mstrDirPrintSave
      End Get

      Set(ByVal Value As String)
         mstrDirPrintSave = Value
      End Set
   End Property

   Property CopyPed() As Byte
      Get
         Return mbytCopyPed
      End Get

      Set(ByVal value As Byte)
         mbytCopyPed = value
      End Set
   End Property

   Property EditarAlmPed() As Byte
      Get
         Return mbytEditarAlmPed
      End Get

      Set(ByVal value As Byte)
         mbytEditarAlmPed = value
      End Set
   End Property

   Property RepIsoDes() As String
      Get
         Return mstrRepIsoDes
      End Get

      Set(ByVal Value As String)
         mstrRepIsoDes = Value
      End Set
   End Property

   Property RepEmisionDes() As String
      Get
         Return mstrRepEmisionDes
      End Get

      Set(ByVal Value As String)
         mstrRepEmisionDes = Value
      End Set
   End Property

   Property RepRevisionDes() As String
      Get
         Return mstrRepRevisionDes
      End Get

      Set(ByVal Value As String)
         mstrRepRevisionDes = Value
      End Set
   End Property

   Property ItemConSaldo() As Byte
      Get
         Return mbytItemConSaldo
      End Get

      Set(ByVal value As Byte)
         mbytItemConSaldo = value
      End Set
   End Property

   Property ViewGestionOld() As Byte
      Get
         Return mbytViewGestionOld
      End Get

      Set(ByVal value As Byte)
         mbytViewGestionOld = value
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
      PrintAuto = 3
      Autorizacion = 4
      SucursalListBox = 5
      SucursalDistinct = 6
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 2
      TipoVentaId = 3
      GestionId = 4
      EmpresaId = 5
      Duplicate = 6
      SucursalListBox = 7
      SucursalId = 8
      TipoVentaIdOnly = 9
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      VentaParaId = 1
      Grid = 3
      SucursalId = 4
      SucursalListBox = 5
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      NroActual = 1
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
      mstrTableName = "venVentaPara"
      mstrClassName = "clsVentaPara"

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
      mlngVentaParaId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngTipoVentaId = 0
      mlngSucursalId = 0
      mlngNroIni = 0
      mlngNroActual = 0
      mbytPagoAuto = 0
      mbytPrintAuto = 0
      mbytUltimoRegistro = 0
      mbytConFac = 0
      mstrTitulo = ""
      mstrFirma = ""
      mstrObs = ""
      mlngTipoHojaId = 0
      mlngRowsMax = 0
      mlngEstadoId = 0
      mboolRestricted = False
      mboolViewCosto = False
      mlngGroupId = 0
      mlngDosificaId = 0
      mboolFacturaCompu = False
      mbytMultiSuc = 0
      mdecCantItem = 0
      mlngTipoImpresionId = 0
      mlngNroCopia = 1
      mbytPrintOrigCopia = 0
      mlngOrden = 0
      mboolTicketFac = 0
      mboolTicketNota = 0
      mlngTipoFormImpId = 0
      mbytNroOrdenDup = 0
      mbytExigirNroOrden = 0
      mbytExigirFacturaDif = 0
      mbytFacFechaMen = 0
      mbytEditarPrecio = 0
      mbytSaldoItemPed = 0
      mdecMontoMaxVtaNit = 0
      mbytComisionItem = 0
      mbytNotaEntregaAuto = 0
      mbytIncluirNotaEntregaCons = 0
      mbytAprobadoAutoDoc = 0
      mstrIsoDes = ""
      mstrEmisionDes = ""
      mstrRevisionDes = ""
      mbytPrintSave = 0
      mstrDirPrintSave = ""
      mbytCopyPed = 0
      mbytEditarAlmPed = 0
      mstrRepIsoDes = ""
      mstrRepEmisionDes = ""
      mstrRepRevisionDes = ""
      mbytItemConSaldo = 0
      mbytViewGestionOld = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    venVentaPara.VentaParaId,  "
            strSQL &= "    venVentaPara.EmpresaId,  "
            strSQL &= "    venVentaPara.GestionId,  "
            strSQL &= "    venVentaPara.TipoVentaId,  "
            strSQL &= "    venVentaPara.SucursalId,  "
            strSQL &= "    venVentaPara.NroIni,  "
            strSQL &= "    venVentaPara.NroActual,  "
            strSQL &= "    venVentaPara.PagoAuto,  "
            strSQL &= "    venVentaPara.PrintAuto,  "
            strSQL &= "    venVentaPara.UltimoRegistro,  "
            strSQL &= "    venVentaPara.ConFac,  "
            strSQL &= "    venVentaPara.Titulo,  "
            strSQL &= "    venVentaPara.Firma,  "
            strSQL &= "    venVentaPara.Obs,  "
            strSQL &= "    venVentaPara.TipoHojaId,  "
            strSQL &= "    venVentaPara.RowsMax,  "
            strSQL &= "    venVentaPara.EstadoId,  "
            strSQL &= "    venVentaPara.Restricted,  "
            strSQL &= "    venVentaPara.GroupId,  "
            strSQL &= "    venVentaPara.ViewCosto,  "
            strSQL &= "    venVentaPara.DosificaId,  "
            strSQL &= "    venVentaPara.FacturaCompu,  "
            strSQL &= "    venVentaPara.MultiSuc,  "
            strSQL &= "    venVentaPara.CantItem,  "
            strSQL &= "    venVentaPara.TipoImpresionId,  "
            strSQL &= "    venVentaPara.NroCopia,  "
            strSQL &= "    venVentaPara.PrintOrigCopia,  "
            strSQL &= "    venVentaPara.Orden,  "
            strSQL &= "    venVentaPara.TicketFac,  "
            strSQL &= "    venVentaPara.TicketNota,  "
            strSQL &= "    venVentaPara.TipoFormImpId,  "
            strSQL &= "    venVentaPara.NroOrdenDup,  "
            strSQL &= "    venVentaPara.ExigirNroOrden,  "
            strSQL &= "    venVentaPara.ExigirFacturaDif,  "
            strSQL &= "    venVentaPara.FacFechaMen,  "
            strSQL &= "    venVentaPara.EditarPrecio,  "
            strSQL &= "    venVentaPara.SaldoItemPed,  "
            strSQL &= "    venVentaPara.MontoMaxVtaNit,  "
            strSQL &= "    venVentaPara.ComisionItem,  "
            strSQL &= "    venVentaPara.NotaEntregaAuto,  "
            strSQL &= "    venVentaPara.IncluirNotaEntregaCons,"
            strSQL &= "    venVentaPara.AprobadoAutoDoc,"
            strSQL &= "    venVentaPara.IsoDes,  "
            strSQL &= "    venVentaPara.EmisionDes,  "
            strSQL &= "    venVentaPara.RevisionDes,  "
            strSQL &= "    venVentaPara.PrintSave,"
            strSQL &= "    venVentaPara.DirPrintSave,  "
            strSQL &= "    venVentaPara.CopyPed,"
            strSQL &= "    venVentaPara.EditarAlmPed,"
            strSQL &= "    venVentaPara.RepIsoDes,  "
            strSQL &= "    venVentaPara.RepEmisionDes,  "
            strSQL &= "    venVentaPara.RepRevisionDes,  "
            strSQL &= "    venVentaPara.ItemConSaldo,"
            strSQL &= "    venVentaPara.ViewGestionOld,"
            strSQL &= "    venVentaPara.sLastUpdate_id,  "
            strSQL &= "    venVentaPara.dtLastUpdate_dt,  "
            strSQL &= "    venVentaPara.iConcurrency_id  "
            strSQL &= " FROM venVentaPara "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    venVentaPara.VentaParaId  "
            strSQL &= " FROM venVentaPara "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    venVentaPara.VentaParaId,  "
            strSQL &= "    venVentaPara.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblGestion.GestionId,  "
            strSQL &= "    tblGestion.Gestion,  "
            strSQL &= "    venTipoVenta.TipoVentaId,  "
            strSQL &= "    venTipoVenta.TipoVentaDes,  "
            strSQL &= "    venVentaPara.NroIni,  "
            strSQL &= "    venVentaPara.NroActual,  "
            strSQL &= "    venVentaPara.Titulo,  "
            strSQL &= "    venVentaPara.Firma,  "
            strSQL &= "    venVentaPara.Obs,  "
            strSQL &= "    tblTipoHoja.TipoHojaId,  "
            strSQL &= "    tblTipoHoja.TipoHojaDes,  "
            strSQL &= "    venVentaPara.Restricted,  "
            strSQL &= "    secGroup.GroupId,  "
            strSQL &= "    secGroup.GroupDes,  "
            strSQL &= "    venVentaPara.RowsMax,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    venVentaPara.Orden  "
            strSQL &= " FROM venVentaPara, tblSucursal, tblGestion, venTipoVenta, tblTipoHoja, secGroup, tblEstado "

         Case SelectFilters.PrintAuto
            strSQL = " SELECT  "
            strSQL &= "    venVentaPara.PrintAuto, "
            strSQL &= "    venVentaPara.IncluirNotaEntregaCons "
            strSQL &= " FROM venVentaPara "

         Case SelectFilters.Autorizacion
            strSQL = " SELECT  "
            strSQL &= "    venVentaPara.VentaParaId,  "
            strSQL &= "    venVentaPara.Restricted,  "
            strSQL &= "    venVentaPara.ViewCosto,  "
            strSQL &= "    venVentaPara.GroupId,  "
            strSQL &= "    venVentaPara.UltimoRegistro  "
            strSQL &= " FROM venVentaPara "

         Case SelectFilters.SucursalListBox
            strSQL = " SELECT  "
            strSQL &= "    venVentaPara.VentaParaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    venVentaPara.TipoVentaId  "
            strSQL &= " FROM venVentaPara, tblSucursal "

         Case SelectFilters.SucursalDistinct
            strSQL = " SELECT  "
            strSQL &= "    venVentaPara.SucursalId  "
            strSQL &= " FROM venVentaPara "

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
            strSQL = " WHERE  venVentaPara.VentaParaId = " & NumberToField(mlngVentaParaId)

         Case WhereFilters.Grid
            strSQL = " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaPara.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaPara.GestionId = tblGestion.GestionId "
            strSQL &= " AND  venVentaPara.TipoVentaId = venTipoVenta.TipoVentaId "
            strSQL &= " AND  venVentaPara.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  venVentaPara.TipoHojaId = tblTipoHoja.TipoHojaId "
            strSQL &= " AND  venVentaPara.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  venVentaPara.GroupId = secGroup.GroupId "
            strSQL &= " AND  venVentaPara.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.TipoVentaId
            strSQL = " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaPara.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaPara.TipoVentaId = " & NumberToField(mlngTipoVentaId)
            strSQL &= " AND  venVentaPara.SucursalId = " & NumberToField(mlngSucursalId)

         Case WhereFilters.GestionId
            strSQL = " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaPara.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Duplicate
            strSQL = " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaPara.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaPara.TipoVentaId = " & NumberToField(mlngTipoVentaId)
            strSQL &= " AND  venVentaPara.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngVentaParaId <> 0 Then
               strSQL &= " AND  venVentaPara.VentaParaId <> " & NumberToField(mlngVentaParaId)
            End If

         Case WhereFilters.SucursalListBox
            strSQL = " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaPara.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaPara.TipoVentaId = " & NumberToField(mlngTipoVentaId)
            strSQL &= " AND  venVentaPara.SucursalId = tblSucursal.SucursalId "

         Case WhereFilters.SucursalId
            strSQL = " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaPara.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaPara.SucursalId = " & NumberToField(mlngSucursalId)

         Case WhereFilters.TipoVentaIdOnly
            strSQL = " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  venVentaPara.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  venVentaPara.TipoVentaId = " & NumberToField(mlngTipoVentaId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.VentaParaId
            strSQL = " ORDER BY venVentaPara.VentaParaId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblSucursal.SucursalId ASC, tblGestion.Gestion, venTipoVenta.TipoVentaId "

         Case OrderByFilters.SucursalListBox
            strSQL = " ORDER BY tblSucursal.TipoSucursalId ASC, tblSucursal.SucursalDes ASC "

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
            strSQL = "INSERT INTO venVentaPara ("
            strSQL &= "VentaParaId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoVentaId, "
            strSQL &= "SucursalId, "
            strSQL &= "NroIni, "
            strSQL &= "NroActual, "
            strSQL &= "PagoAuto, "
            strSQL &= "PrintAuto, "
            strSQL &= "UltimoRegistro,  "
            strSQL &= "ConFac, "
            strSQL &= "Titulo, "
            strSQL &= "Firma, "
            strSQL &= "Obs, "
            strSQL &= "TipoHojaId, "
            strSQL &= "RowsMax, "
            strSQL &= "EstadoId, "
            strSQL &= "Restricted, "
            strSQL &= "GroupId, "
            strSQL &= "ViewCosto, "
            strSQL &= "DosificaId, "
            strSQL &= "FacturaCompu, "
            strSQL &= "MultiSuc, "
            strSQL &= "CantItem, "
            strSQL &= "TipoImpresionId, "
            strSQL &= "NroCopia,  "
            strSQL &= "PrintOrigCopia,  "
            strSQL &= "Orden,  "
            strSQL &= "TicketFac,  "
            strSQL &= "TicketNota,  "
            strSQL &= "TipoFormImpId, "
            strSQL &= "NroOrdenDup, "
            strSQL &= "ExigirNroOrden, "
            strSQL &= "ExigirFacturaDif, "
            strSQL &= "FacFechaMen,  "
            strSQL &= "EditarPrecio,  "
            strSQL &= "SaldoItemPed,  "
            strSQL &= "MontoMaxVtaNit,  "
            strSQL &= "ComisionItem,  "
            strSQL &= "NotaEntregaAuto, "
            strSQL &= "IncluirNotaEntregaCons, "
            strSQL &= "AprobadoAutoDoc, "
            strSQL &= "IsoDes, "
            strSQL &= "EmisionDes, "
            strSQL &= "RevisionDes, "
            strSQL &= "PrintSave, "
            strSQL &= "DirPrintSave, "
            strSQL &= "CopyPed, "
            strSQL &= "EditarAlmPed, "
            strSQL &= "RepIsoDes, "
            strSQL &= "RepEmisionDes, "
            strSQL &= "RepRevisionDes, "
            strSQL &= "ItemConSaldo, "
            strSQL &= "ViewGestionOld, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngVentaParaId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoVentaId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngNroIni) & ", "
            strSQL &= NumberToField(mlngNroActual) & ", "
            strSQL &= NumberToField(mbytPagoAuto) & ", "
            strSQL &= NumberToField(mbytPrintAuto) & ", "
            strSQL &= NumberToField(mbytUltimoRegistro) & ", "
            strSQL &= NumberToField(mbytConFac) & ", "
            strSQL &= StringToField(mstrTitulo) & ", "
            strSQL &= StringToField(mstrFirma) & ", "
            strSQL &= StringToField(mstrObs) & ", "
            strSQL &= NumberToField(mlngTipoHojaId) & ", "
            strSQL &= NumberToField(mlngRowsMax) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= BooleanToField(mboolRestricted) & ", "
            strSQL &= NumberToField(mlngGroupId) & ", "
            strSQL &= BooleanToField(mboolViewCosto) & ", "
            strSQL &= NumberToField(mlngDosificaId) & ", "
            strSQL &= BooleanToField(mboolFacturaCompu) & ", "
            strSQL &= NumberToField(mbytMultiSuc) & ", "
            strSQL &= DecimalToField(mdecCantItem) & ", "
            strSQL &= NumberToField(mlngTipoImpresionId) & ", "
            strSQL &= NumberToField(mlngNroCopia) & ", "
            strSQL &= NumberToField(mbytPrintOrigCopia) & ", "
            strSQL &= NumberToField(mlngOrden) & ", "
            strSQL &= BooleanToField(mboolTicketFac) & ", "
            strSQL &= BooleanToField(mboolTicketNota) & ", "
            strSQL &= NumberToField(mlngTipoFormImpId) & ", "
            strSQL &= NumberToField(mbytNroOrdenDup) & ", "
            strSQL &= NumberToField(mbytExigirNroOrden) & ", "
            strSQL &= NumberToField(mbytExigirFacturaDif) & ", "
            strSQL &= NumberToField(mbytFacFechaMen) & ", "
            strSQL &= NumberToField(mbytEditarPrecio) & ", "
            strSQL &= NumberToField(mbytSaldoItemPed) & ", "
            strSQL &= DecimalToField(mdecMontoMaxVtaNit) & ", "
            strSQL &= NumberToField(mbytComisionItem) & ", "
            strSQL &= NumberToField(mbytNotaEntregaAuto) & ", "
            strSQL &= NumberToField(mbytIncluirNotaEntregaCons) & ", "
            strSQL &= NumberToField(mbytAprobadoAutoDoc) & ", "
            strSQL &= StringToField(mstrIsoDes) & ", "
            strSQL &= StringToField(mstrEmisionDes) & ", "
            strSQL &= StringToField(mstrRevisionDes) & ", "
            strSQL &= NumberToField(mbytPrintSave) & ", "
            strSQL &= StringToField(mstrDirPrintSave) & ", "
            strSQL &= NumberToField(mbytCopyPed) & ", "
            strSQL &= NumberToField(mbytEditarAlmPed) & ", "
            strSQL &= StringToField(mstrRepIsoDes) & ", "
            strSQL &= StringToField(mstrRepEmisionDes) & ", "
            strSQL &= StringToField(mstrRepRevisionDes) & ", "
            strSQL &= NumberToField(mbytItemConSaldo) & ", "
            strSQL &= NumberToField(mbytViewGestionOld) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE venVentaPara SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoVentaId = " & NumberToField(mlngTipoVentaId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "NroIni = " & NumberToField(mlngNroIni) & ", "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual) & ", "
            strSQL &= "PagoAuto = " & NumberToField(mbytPagoAuto) & ", "
            strSQL &= "PrintAuto = " & NumberToField(mbytPrintAuto) & ", "
            strSQL &= "UltimoRegistro = " & NumberToField(mbytUltimoRegistro) & ", "
            strSQL &= "ConFac = " & NumberToField(mbytConFac) & ", "
            strSQL &= "Titulo = " & "'" & mstrTitulo & "', "
            strSQL &= "Firma = " & "'" & mstrFirma & "', "
            strSQL &= "Obs = " & "'" & mstrObs & "', "
            strSQL &= "TipoHojaId = " & NumberToField(mlngTipoHojaId) & ", "
            strSQL &= "RowsMax = " & NumberToField(mlngRowsMax) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= "Restricted = " & BooleanToField(mboolRestricted) & ", "
            strSQL &= "GroupId = " & NumberToField(mlngGroupId) & ", "
            strSQL &= "ViewCosto = " & BooleanToField(mboolViewCosto) & ", "
            strSQL &= "DosificaId = " & NumberToField(mlngDosificaId) & ", "
            strSQL &= "FacturaCompu = " & BooleanToField(mboolFacturaCompu) & ", "
            strSQL &= "MultiSuc = " & NumberToField(mbytMultiSuc) & ", "
            strSQL &= "CantItem = " & DecimalToField(mdecCantItem) & ", "
            strSQL &= "TipoImpresionId = " & NumberToField(mlngTipoImpresionId) & ", "
            strSQL &= "NroCopia = " & NumberToField(mlngNroCopia) & ", "
            strSQL &= "PrintOrigCopia = " & NumberToField(mbytPrintOrigCopia) & ", "
            strSQL &= "Orden = " & NumberToField(mlngOrden) & ", "
            strSQL &= "TicketFac = " & BooleanToField(mboolTicketFac) & ", "
            strSQL &= "TicketNota = " & BooleanToField(mboolTicketNota) & ", "
            strSQL &= "TipoFormImpId = " & NumberToField(mlngTipoFormImpId) & ", "
            strSQL &= "NroOrdenDup = " & NumberToField(mbytNroOrdenDup) & ", "
            strSQL &= "ExigirNroOrden = " & NumberToField(mbytExigirNroOrden) & ", "
            strSQL &= "ExigirFacturaDif = " & NumberToField(mbytExigirFacturaDif) & ", "
            strSQL &= "FacFechaMen = " & NumberToField(mbytFacFechaMen) & ", "
            strSQL &= "EditarPrecio = " & NumberToField(mbytEditarPrecio) & ", "
            strSQL &= "SaldoItemPed = " & NumberToField(mbytSaldoItemPed) & ", "
            strSQL &= "MontoMaxVtaNit = " & DecimalToField(mdecMontoMaxVtaNit) & ", "
            strSQL &= "ComisionItem = " & NumberToField(mbytComisionItem) & ", "
            strSQL &= "NotaEntregaAuto = " & NumberToField(mbytNotaEntregaAuto) & ", "
            strSQL &= "IncluirNotaEntregaCons = " & NumberToField(mbytIncluirNotaEntregaCons) & ", "
            strSQL &= "AprobadoAutoDoc = " & NumberToField(mbytAprobadoAutoDoc) & ", "
            strSQL &= "IsoDes = " & StringToField(mstrIsoDes) & ", "
            strSQL &= "EmisionDes = " & StringToField(mstrEmisionDes) & ", "
            strSQL &= "RevisionDes = " & StringToField(mstrRevisionDes) & ", "
            strSQL &= "PrintSave = " & NumberToField(mbytPrintSave) & ", "
            strSQL &= "DirPrintSave = " & StringToField(mstrDirPrintSave) & ", "
            strSQL &= "CopyPed = " & NumberToField(mbytCopyPed) & ", "
            strSQL &= "EditarAlmPed = " & NumberToField(mbytEditarAlmPed) & ", "
            strSQL &= "RepIsoDes = " & StringToField(mstrRepIsoDes) & ", "
            strSQL &= "RepEmisionDes = " & StringToField(mstrRepEmisionDes) & ", "
            strSQL &= "RepRevisionDes = " & StringToField(mstrRepRevisionDes) & ", "
            strSQL &= "ItemConSaldo = " & NumberToField(mbytItemConSaldo) & ", "
            strSQL &= "ViewGestionOld = " & NumberToField(mbytViewGestionOld) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " VentaParaId = " & NumberToField(mlngVentaParaId) & " "

         Case UpdateFilters.NroActual
            strSQL = "UPDATE venVentaPara SET "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " VentaParaId = " & NumberToField(mlngVentaParaId) & " "

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
               mlngVentaParaId = ToLong(oDataRow("VentaParaId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoVentaId = ToLong(oDataRow("TipoVentaId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngNroIni = ToLong(oDataRow("NroIni"))
               mlngNroActual = ToLong(oDataRow("NroActual"))
               mbytPagoAuto = ToByte(oDataRow("PagoAuto"))
               mbytPrintAuto = ToByte(oDataRow("PrintAuto"))
               mbytUltimoRegistro = ToByte(oDataRow("UltimoRegistro"))
               mbytConFac = ToByte(oDataRow("ConFac"))
               mstrTitulo = ToStr(oDataRow("Titulo"))
               mstrFirma = ToStr(oDataRow("Firma"))
               mstrObs = ToStr(oDataRow("Obs"))
               mlngTipoHojaId = ToLong(oDataRow("TipoHojaId"))
               mlngRowsMax = ToLong(oDataRow("RowsMax"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mboolRestricted = ToBoolean(oDataRow("Restricted"))
               mlngGroupId = ToLong(oDataRow("GroupId"))
               mboolViewCosto = ToBoolean(oDataRow("ViewCosto"))
               mlngDosificaId = ToLong(oDataRow("DosificaId"))
               mboolFacturaCompu = ToBoolean(oDataRow("FacturaCompu"))
               mbytMultiSuc = ToByte(oDataRow("MultiSuc"))
               mdecCantItem = ToDecimal(oDataRow("CantItem"))
               mlngTipoImpresionId = ToLong(oDataRow("TipoImpresionId"))
               mlngNroCopia = ToLong(oDataRow("NroCopia"))
               mbytPrintOrigCopia = ToByte(oDataRow("PrintOrigCopia"))
               mlngOrden = ToLong(oDataRow("Orden"))
               mboolTicketFac = ToBoolean(oDataRow("TicketFac"))
               mboolTicketNota = ToBoolean(oDataRow("TicketNota"))
               mlngTipoFormImpId = ToLong(oDataRow("TipoFormImpId"))
               mbytNroOrdenDup = ToByte(oDataRow("NroOrdenDup"))
               mbytExigirNroOrden = ToByte(oDataRow("ExigirNroOrden"))
               mbytExigirFacturaDif = ToByte(oDataRow("ExigirFacturaDif"))
               mbytFacFechaMen = ToByte(oDataRow("FacFechaMen"))
               mbytEditarPrecio = ToByte(oDataRow("EditarPrecio"))
               mbytSaldoItemPed = ToByte(oDataRow("SaldoItemPed"))
               mdecMontoMaxVtaNit = ToDecimal(oDataRow("MontoMaxVtaNit"))
               mbytComisionItem = ToByte(oDataRow("ComisionItem"))
               mbytNotaEntregaAuto = ToByte(oDataRow("NotaEntregaAuto"))
               mbytIncluirNotaEntregaCons = ToByte(oDataRow("IncluirNotaEntregaCons"))
               mbytAprobadoAutoDoc = ToByte(oDataRow("AprobadoAutoDoc"))
               mstrIsoDes = ToStr(oDataRow("IsoDes"))
               mstrEmisionDes = ToStr(oDataRow("EmisionDes"))
               mstrRevisionDes = ToStr(oDataRow("RevisionDes"))
               mbytPrintSave = ToByte(oDataRow("PrintSave"))
               mstrDirPrintSave = ToStr(oDataRow("DirPrintSave"))
               mbytCopyPed = ToByte(oDataRow("CopyPed"))
               mbytEditarAlmPed = ToByte(oDataRow("EditarAlmPed"))
               mstrRepIsoDes = ToStr(oDataRow("RepIsoDes"))
               mstrRepEmisionDes = ToStr(oDataRow("RepEmisionDes"))
               mstrRepRevisionDes = ToStr(oDataRow("RepRevisionDes"))
               mbytItemConSaldo = ToByte(oDataRow("ItemConSaldo"))
               mbytViewGestionOld = ToByte(oDataRow("ViewGestionOld"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngVentaParaId = ToLong(oDataRow("VentaParaId"))

            Case SelectFilters.PrintAuto
               mbytPrintAuto = ToByte(oDataRow("PrintAuto"))
               mbytIncluirNotaEntregaCons = ToByte(oDataRow("IncluirNotaEntregaCons"))

            Case SelectFilters.Autorizacion
               mlngVentaParaId = ToLong(oDataRow("VentaParaId"))
               mboolRestricted = ToBoolean(oDataRow("Restricted"))
               mlngGroupId = ToLong(oDataRow("GroupId"))
               mboolViewCosto = ToBoolean(oDataRow("ViewCosto"))
               mbytUltimoRegistro = ToByte(oDataRow("UltimoRegistro"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngVentaParaId = TableIDGet(mstrTableName, "VentaParaId", moConnection)

         If mlngVentaParaId = -1 Then
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

      'If mstrVentaParaDes.Length() = 0 Then
      '   strMsg &= "Ingrese la Descripción" & vbCrLf
      'End If

      'If mstrFecha.Trim() <> String.Empty Then
      '   If Not IsDate(mstrFecha) Then
      '      strMsg &= "Fecha no es una fecha válida" & vbCrLf
      '   End If
      'Else
      '   strMsg &= "La Fecha no puede ser nula" & vbCrLf
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
         'strSQL &= " FROM venVentaPara "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  venVentaPara.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  venVentaPara.TipoVentaId = " & NumberToField(mlngTipoVentaId)
         '   strSQL &= " AND  venVentaPara.SucursalId = " & NumberToField(mlngSucursalId)
         'Else
         '   strSQL &= " WHERE  venVentaPara.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  venVentaPara.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  venVentaPara.TipoVentaId = " & NumberToField(mlngTipoVentaId)
         '   strSQL &= " AND  venVentaPara.SucursalId = " & NumberToField(mlngSucursalId)
         '   strSQL &= " AND  venVentaPara.VentaParaId <> " & NumberToField(mlngVentaParaId)
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
