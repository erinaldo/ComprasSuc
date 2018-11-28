Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptSRItemLoteSerie
   Inherits DataDynamics.ActiveReports.ActiveReport3

#Region " ActiveReports Designer generated code "
   Public Sub New()

      'This call is required by the ActiveReports Designer.
      InitializeComponent()

      'Add any initialization after the InitializeComponent() call

   End Sub

   'Form overrides dispose to clean up the component list.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
      End If
      MyBase.Dispose(disposing)
   End Sub

   Private WithEvents GroupHeader As DataDynamics.ActiveReports.GroupHeader = Nothing
   Public WithEvents Detail As DataDynamics.ActiveReports.Detail
   Public WithEvents GroupFooter As DataDynamics.ActiveReports.GroupFooter
   Private WithEvents Label15 As DataDynamics.ActiveReports.Label
   Private WithEvents Label9 As DataDynamics.ActiveReports.Label
   Private WithEvents txtCantidad As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtFechaVen As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label6 As DataDynamics.ActiveReports.Label
   Public WithEvents txtSeries As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label1 As DataDynamics.ActiveReports.Label
   Private WithEvents txtSerieLote As DataDynamics.ActiveReports.TextBox
   Private WithEvents lblSerieLote As DataDynamics.ActiveReports.Label
   Private WithEvents txtItemLoteDes As DataDynamics.ActiveReports.TextBox

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSRItemLoteSerie))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtItemLoteDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCantidad = New DataDynamics.ActiveReports.TextBox
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label15 = New DataDynamics.ActiveReports.Label
      Me.txtFechaVen = New DataDynamics.ActiveReports.TextBox
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.txtSerieLote = New DataDynamics.ActiveReports.TextBox
      Me.lblSerieLote = New DataDynamics.ActiveReports.Label
      Me.GroupHeader = New DataDynamics.ActiveReports.GroupHeader
      Me.GroupFooter = New DataDynamics.ActiveReports.GroupFooter
      Me.txtSeries = New DataDynamics.ActiveReports.TextBox
      Me.Label1 = New DataDynamics.ActiveReports.Label
      CType(Me.txtItemLoteDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaVen, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSerieLote, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSerieLote, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSeries, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtItemLoteDes, Me.txtCantidad, Me.Label9, Me.Label15, Me.txtFechaVen, Me.Label6, Me.txtSerieLote, Me.lblSerieLote})
      Me.Detail.Height = 0.1979167!
      Me.Detail.Name = "Detail"
      '
      'txtItemLoteDes
      '
      Me.txtItemLoteDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtItemLoteDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemLoteDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtItemLoteDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemLoteDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtItemLoteDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemLoteDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtItemLoteDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemLoteDes.DataField = "ItemLoteDes"
      Me.txtItemLoteDes.Height = 0.1875!
      Me.txtItemLoteDes.Left = 0.1875!
      Me.txtItemLoteDes.Name = "txtItemLoteDes"
      Me.txtItemLoteDes.OutputFormat = resources.GetString("txtItemLoteDes.OutputFormat")
      Me.txtItemLoteDes.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; white-space: inherit; vertical" & _
          "-align: middle; "
      Me.txtItemLoteDes.Text = "Descripcion"
      Me.txtItemLoteDes.Top = 0.0!
      Me.txtItemLoteDes.Width = 0.75!
      '
      'txtCantidad
      '
      Me.txtCantidad.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCantidad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidad.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCantidad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidad.Border.RightColor = System.Drawing.Color.Black
      Me.txtCantidad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidad.Border.TopColor = System.Drawing.Color.Black
      Me.txtCantidad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidad.DataField = "SaldoOrg"
      Me.txtCantidad.Height = 0.1875!
      Me.txtCantidad.Left = 1.1875!
      Me.txtCantidad.Name = "txtCantidad"
      Me.txtCantidad.OutputFormat = resources.GetString("txtCantidad.OutputFormat")
      Me.txtCantidad.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtCantidad.Text = "Cantidad"
      Me.txtCantidad.Top = 0.0!
      Me.txtCantidad.Width = 0.4791667!
      '
      'Label9
      '
      Me.Label9.Border.BottomColor = System.Drawing.Color.Black
      Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.LeftColor = System.Drawing.Color.Black
      Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.RightColor = System.Drawing.Color.Black
      Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.TopColor = System.Drawing.Color.Black
      Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Height = 0.1875!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 1.0!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "text-decoration: none; ddo-char-set: 1; text-align: center; font-weight: bold; fo" & _
          "nt-size: 8pt; vertical-align: middle; "
      Me.Label9.Text = "C:"
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.2!
      '
      'Label15
      '
      Me.Label15.Border.BottomColor = System.Drawing.Color.Black
      Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.LeftColor = System.Drawing.Color.Black
      Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.RightColor = System.Drawing.Color.Black
      Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.TopColor = System.Drawing.Color.Black
      Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Height = 0.1875!
      Me.Label15.HyperLink = Nothing
      Me.Label15.Left = 0.0!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-decoration: none; text-align: left; font-weight: bold; font" & _
          "-size: 8pt; vertical-align: middle; "
      Me.Label15.Text = "L: "
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 0.2!
      '
      'txtFechaVen
      '
      Me.txtFechaVen.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaVen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaVen.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaVen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaVen.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaVen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaVen.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaVen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaVen.DataField = "FechaVen"
      Me.txtFechaVen.Height = 0.1875!
      Me.txtFechaVen.Left = 1.947917!
      Me.txtFechaVen.Name = "txtFechaVen"
      Me.txtFechaVen.OutputFormat = resources.GetString("txtFechaVen.OutputFormat")
      Me.txtFechaVen.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaVen.Text = "Fecha"
      Me.txtFechaVen.Top = 0.0!
      Me.txtFechaVen.Width = 0.7291667!
      '
      'Label6
      '
      Me.Label6.Border.BottomColor = System.Drawing.Color.Black
      Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.LeftColor = System.Drawing.Color.Black
      Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.RightColor = System.Drawing.Color.Black
      Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.TopColor = System.Drawing.Color.Black
      Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Height = 0.1875!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 1.78125!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label6.Text = "F:"
      Me.Label6.Top = 0.0!
      Me.Label6.Width = 0.15625!
      '
      'txtSerieLote
      '
      Me.txtSerieLote.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSerieLote.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSerieLote.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSerieLote.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSerieLote.Border.RightColor = System.Drawing.Color.Black
      Me.txtSerieLote.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSerieLote.Border.TopColor = System.Drawing.Color.Black
      Me.txtSerieLote.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSerieLote.DataField = "ItemNroSerieLote"
      Me.txtSerieLote.Height = 0.1770833!
      Me.txtSerieLote.Left = 0.1875!
      Me.txtSerieLote.Name = "txtSerieLote"
      Me.txtSerieLote.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtSerieLote.Text = "Series"
      Me.txtSerieLote.Top = 0.1875!
      Me.txtSerieLote.Width = 2.375!
      '
      'lblSerieLote
      '
      Me.lblSerieLote.Border.BottomColor = System.Drawing.Color.Black
      Me.lblSerieLote.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSerieLote.Border.LeftColor = System.Drawing.Color.Black
      Me.lblSerieLote.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSerieLote.Border.RightColor = System.Drawing.Color.Black
      Me.lblSerieLote.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSerieLote.Border.TopColor = System.Drawing.Color.Black
      Me.lblSerieLote.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSerieLote.Height = 0.1770833!
      Me.lblSerieLote.HyperLink = Nothing
      Me.lblSerieLote.Left = 0.0!
      Me.lblSerieLote.Name = "lblSerieLote"
      Me.lblSerieLote.Style = "text-decoration: none; ddo-char-set: 1; text-align: left; font-weight: bold; font" & _
          "-size: 8pt; vertical-align: middle; "
      Me.lblSerieLote.Text = "S: "
      Me.lblSerieLote.Top = 0.1875!
      Me.lblSerieLote.Width = 0.1875!
      '
      'GroupHeader
      '
      Me.GroupHeader.DataField = "MonedaID"
      Me.GroupHeader.Height = 0.0!
      Me.GroupHeader.Name = "GroupHeader"
      '
      'GroupFooter
      '
      Me.GroupFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSeries, Me.Label1})
      Me.GroupFooter.Height = 0.1968504!
      Me.GroupFooter.Name = "GroupFooter"
      '
      'txtSeries
      '
      Me.txtSeries.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSeries.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSeries.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSeries.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSeries.Border.RightColor = System.Drawing.Color.Black
      Me.txtSeries.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSeries.Border.TopColor = System.Drawing.Color.Black
      Me.txtSeries.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSeries.Height = 0.1968504!
      Me.txtSeries.Left = 0.246063!
      Me.txtSeries.Name = "txtSeries"
      Me.txtSeries.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtSeries.Text = "Series"
      Me.txtSeries.Top = 0.0!
      Me.txtSeries.Width = 2.386811!
      '
      'Label1
      '
      Me.Label1.Border.BottomColor = System.Drawing.Color.Black
      Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.LeftColor = System.Drawing.Color.Black
      Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.RightColor = System.Drawing.Color.Black
      Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.TopColor = System.Drawing.Color.Black
      Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Height = 0.1875!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 0.0!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-decoration: none; text-align: left; font-weight: bold; font" & _
          "-size: 8pt; vertical-align: middle; "
      Me.Label1.Text = "S: "
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 0.2!
      '
      'rptSRItemLoteSerie
      '
      Me.MasterReport = False
      Me.PageSettings.PaperHeight = 11.69!
      Me.PageSettings.PaperWidth = 8.27!
      Me.PrintWidth = 2.703333!
      Me.Sections.Add(Me.GroupHeader)
      Me.Sections.Add(Me.Detail)
      Me.Sections.Add(Me.GroupFooter)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                  "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
      CType(Me.txtItemLoteDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaVen, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSerieLote, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSerieLote, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSeries, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      If ToStr(Me.Fields("ItemNroSerieLote").Value) <> String.Empty Then
         lblSerieLote.Visible = True
         txtSerieLote.Visible = True
      Else
         lblSerieLote.Visible = False
         lblSerieLote.Height = 0
         txtSerieLote.Visible = False
         txtSerieLote.Height = 0
      End If
   End Sub
End Class