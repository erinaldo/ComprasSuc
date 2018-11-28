Imports Microsoft.Office.Interop

Module modExcel
   Dim boolRunning As Boolean

   Public Function ExcelNew(ByRef oExcel As Excel.Application) As Boolean
      Try
         boolRunning = True

         If oExcel Is Nothing Then
            'oExcel = GetObject(, "Excel.Application")
            oExcel = New Excel.Application
            boolRunning = False
         End If

         If oExcel Is Nothing Then
            MsgBox("No se pudo crear el objeto Excel")
            ExcelNew = False

         Else
            If Not oExcel.Visible Then
               oExcel.Visible = True
            End If

            ExcelNew = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function ExcelOpen(ByRef oExcel As Excel.Application, ByVal strSource As String) As Boolean
      Try
         boolRunning = True

         oExcel = New Excel.Application
         oExcel.Workbooks.Open(strSource)

         If oExcel Is Nothing Then
            oExcel = New Excel.Application
            boolRunning = False
         End If

         If oExcel Is Nothing Then
            MsgBox("No se pudo abrir el objeto Excel")
            ExcelOpen = False

         Else
            If Not oExcel.Visible Then
               oExcel.Visible = False
            End If

            ExcelOpen = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Sub ExcelKill(ByRef oExcel As Excel.Application)
      Try
         If Not oExcel Is Nothing Then
            If oExcel.Workbooks.Count > 0 Then
               'If MsgBox("Quiere cerrar el libro Excel", vbYesNo + vbQuestion, "Reportes en Excel") = vbYes Then
               oExcel.ActiveWorkbook.Close(False)
               'End If
            End If

            If Not boolRunning Then
               oExcel.Quit()
            End If

            oExcel = Nothing
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Sub

   Public Function getHojasExcel2(ByVal strSource As String, ByRef lstHojas As List(Of String)) As Boolean
      Dim oConnection As Data.OleDb.OleDbConnection
      Dim oDataTable As New DataTable
      Dim dbNull As System.DBNull
      Dim oRestrictions() As Object = {dbNull, dbNull, dbNull, "TABLE"}
      getHojasExcel2 = False

      Try

         Dim oExcel As Excel.Application

         If ExcelOpen(oExcel, strSource) Then

            'Creamos un objecto OLEDBConnection con el nombre del archivo seleccionado
            ' como Data Source
            oConnection = New System.Data.OleDb.OleDbConnection( _
                  "Provider=Microsoft.ACE.OLEDB.12.0; " & _
                  "Data Source=" & strSource.Trim & "; Extended Properties=""Excel 12.0 Xml; HDR=YES; IMEX=2"";")

            If oConnection.State = ConnectionState.Closed Then
               oConnection.Open()
            End If

            'oDataTable = oConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables)
            oDataTable = oConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, oRestrictions)

            For Each oDataRow As DataRow In oDataTable.Rows
               'lstHojas.Add(oDataRow("TABLE_NAME").ToString())
               lstHojas.Add(oDataRow("TABLE_NAME"))
            Next

            oConnection.Close()

            Call ExcelKill(oExcel)

            Return True

         End If

      Catch ex As Exception
         MessageBox.Show(ex.Message, "Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      Finally
         oConnection.Close()
         oConnection = Nothing
      End Try

   End Function

   Public Function getHojasExcel(ByVal strSource As String, ByRef lstHojas As List(Of String)) As Boolean
      Try

         Dim oExcel As Excel.Application

         If ExcelOpen(oExcel, strSource) Then

            For Each Hoja As Microsoft.Office.Interop.Excel.Worksheet In oExcel.Worksheets
               lstHojas.Add(Hoja.Name)
            Next

            Call ExcelKill(oExcel)

            Return True
         End If
      Catch exp As Exception
         Throw exp

      End Try
   End Function

End Module
