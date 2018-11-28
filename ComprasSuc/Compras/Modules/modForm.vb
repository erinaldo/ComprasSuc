Module modForm

    Sub FormCenter(ByVal frmCurrent As Form)
      'frmCurrent.Top = (Screen.PrimaryScreen.WorkingArea.Height - frmCurrent.Height) \ 2
      'frmCurrent.Left = (Screen.PrimaryScreen.WorkingArea.Width - frmCurrent.Width) \ 2
    End Sub

    Public Sub FormCenterChild(ByVal frmCurrent As Form)
      'frmCurrent.Top = ((frmMain.ActiveForm.Height) - frmCurrent.Height) \ 2
      'frmCurrent.Left = (frmMain.ActiveForm.Width - frmCurrent.Width) \ 2

      'frmCurrent.Top = (gfrmMain.Height - frmCurrent.Height) \ 2
      'frmCurrent.Left = (gfrmMain.Width - frmCurrent.Width) \ 2

      If frmCurrent.WindowState <> FormWindowState.Minimized Then
         frmCurrent.Location = New Point(20, 20)
         frmCurrent.Height = gfrmMain.ClientSize.Height - gfrmMain.TopRebar1.Height - gfrmMain.sbrMain.Height - 40
         frmCurrent.Width = gfrmMain.ClientSize.Width - 40
      End If
   End Sub

   'Public Function ForcePageSize(ByRef oPrintDocument As System.Drawing.Printing.PrintDocument, ByVal oPaperKind As System.Drawing.Printing.PaperKind) As Boolean
   '   For i As Integer = 0 To oPrintDocument.PrinterSettings.PaperSizes.Count
   '      If oPrintDocument.PrinterSettings.PaperSizes(i).Kind = oPaperKind Then
   '         oPrintDocument.DefaultPageSettings.PaperSize = oPrintDocument.PrinterSettings.PaperSizes(i)

   '         Return True
   '      End If
   '   Next

   '   Return False
   'End Function

   Public Sub ForcePageSize(ByRef oPrinter As DataDynamics.ActiveReports.Document.Printer, ByRef oPageSettings As DataDynamics.ActiveReports.PageSettings, ByVal lngTipoHojaId As Long)
      oPrinter.PrinterName = ""

      With oPageSettings
         .Margins.Left = 0.5
         .Margins.Right = 0.5
         .Margins.Top = 0.5
         .Margins.Bottom = 0.3
      End With

      If lngTipoHojaId = 1 Then 'Carta
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Letter
         End With

      ElseIf lngTipoHojaId = 2 Then 'Media Carta
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Custom
            .PaperHeight = 5.5
            .PaperWidth = 8.5
         End With

      ElseIf lngTipoHojaId = 3 Then 'Oficio
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Custom
            .PaperHeight = 13
            .PaperWidth = 8.5
         End With

      ElseIf lngTipoHojaId = 4 Then 'Medio Oficio
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Custom
            .PaperHeight = 6.5
            .PaperWidth = 8.5
         End With

      Else
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Letter
         End With
      End If
   End Sub

   'Dim p As System.Drawing.Printing.PaperSize = New System.Drawing.Printing.PaperSize("Media Carta", 850, 550)

   ''rpt.Document.Printer.PrinterName = ""
   'rpt.Document.Printer.PaperKind = System.Drawing.Printing.PaperKind.Custom
   'rpt.Document.Printer.PaperSize = p
   'rpt.Document.Printer.DefaultPageSettings.PaperSize = p

   'Dim oCustomSize As New Drawing.Printing.PaperSize("Media Carta", 850, 550)

   'rpt.Document.Printer.PaperKind = System.Drawing.Printing.PaperKind.Custom
   'rpt.Document.Printer.DefaultPageSettings.PaperSize = oCustomSize

   'rpt.Document.Printer.PaperSize = oCustomSize

   'For i As Integer = 0 To rpt.Document.Printer.PrinterSettings.PaperSizes.Count - 1
   '   MessageBox.Show(CInt(i) & " " & rpt.Document.Printer.PrinterSettings.PaperSizes(i).PaperName)
   'Next

   'rpt.Document.Printer.PrinterName = ""

   'With rpt.PageSettings
   '   .PaperKind = Drawing.Printing.PaperKind.Custom
   '   .PaperHeight = 5.5
   '   .PaperWidth = 8.5
   '   .Margins.Left = 0.5
   '   .Margins.Right = 0.5
   '   .Margins.Top = 0.5
   '   .Margins.Bottom = 0.3
   'End With

   'rpt.Document.Printer.PrinterName = ""
   'rpt.PageSettings.PaperKind = Printing.PaperKind.Custom
   'rpt.PageSettings.PaperHeight = 5.5 '11
   'rpt.PageSettings.PaperWidth = 8.5

   'rpt.Document.Printer.PaperKind = Printing.PaperKind.Custom
   'rpt.Document.Printer.DefaultPageSettings.PaperSize.Height = 550
   'rpt.Document.Printer.DefaultPageSettings.PaperSize.Width = 850

End Module
