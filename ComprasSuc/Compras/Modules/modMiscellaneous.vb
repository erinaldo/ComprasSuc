Module ModMiscellaneous

   'Metodo que realiza el calculo de saldo de item, saldo = (entradas - salidas)
   Public Function ItemSaldoActual(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngMedidaId As Long, _
                                    ByVal decMedidaCantEqui As Decimal, ByVal lngMonedaIdCos As Long, _
                                    ByVal lngItemId As Long, ByVal lngAlmacenId As Long, ByRef decPPP As Decimal, _
                                    ByRef decUPC As Decimal) As Decimal

      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)
      Dim decCantidadAcu As Decimal = 0
      Dim decImporteAcu As Decimal = 0
      Dim decCantidad As Decimal = 0
      Dim decImporte As Decimal = 0

      ItemSaldoActual = 0
      decPPP = 0
      decUPC = 0

      Try
         With oNotaDet
            .SelectFilter = clsNotaDet.SelectFilters.All
            .WhereFilter = clsNotaDet.WhereFilters.SaldoActual
            .OrderByFilter = clsNotaDet.OrderByFilters.NotaDetId
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Open() Then
               Do While .Read()

                  If .TipoMovId = 1 Then 'Entrada
                     If .MedidaId = lngMedidaId Then
                        decCantidad = .CantidadEnt
                     Else
                        decCantidad = .CantidadEnt * decMedidaCantEqui
                     End If

                     If lngMonedaIdCos = clsMoneda.BOLIVIANOS Then
                        If .MonedaId = lngMonedaIdCos Then
                           decImporte = .CantidadEnt * .PrecioCos

                           If .MedidaId = lngMedidaId Then
                              decUPC = .PrecioCos
                           Else
                              decUPC = ToDecimal(.PrecioCos / decMedidaCantEqui)
                           End If
                        Else
                           decImporte = .CantidadEnt * (.PrecioCos * .TipoCambio)

                           If .MedidaId = lngMedidaId Then
                              decUPC = .PrecioCos * .TipoCambio
                           Else
                              decUPC = ToDecimal((.PrecioCos * .TipoCambio) / decMedidaCantEqui)
                           End If
                        End If

                     ElseIf lngMonedaIdCos = clsMoneda.DOLARES Then
                        If .MonedaId = lngMonedaIdCos Then
                           decImporte = .CantidadEnt * .PrecioCos

                           If .MedidaId = lngMedidaId Then
                              decUPC = .PrecioCos
                           Else
                              decUPC = ToDecimal(.PrecioCos / decMedidaCantEqui)
                           End If
                        Else
                           decImporte = .CantidadEnt * (.PrecioCos / .TipoCambio)

                           If .MedidaId = lngMedidaId Then
                              decUPC = .PrecioCos / .TipoCambio
                           Else
                              decUPC = ToDecimal((.PrecioCos / .TipoCambio) / decMedidaCantEqui)
                           End If
                        End If
                     End If

                     decCantidadAcu += decCantidad
                     decImporteAcu += decImporte

                  Else 'Salida
                     If .MedidaId = lngMedidaId Then
                        decCantidad = .CantidadSal
                     Else
                        decCantidad = .CantidadSal * decMedidaCantEqui
                     End If

                     If lngMonedaIdCos = clsMoneda.BOLIVIANOS Then
                        If .MonedaId = lngMonedaIdCos Then
                           decImporte = .CantidadSal * .PrecioCos
                        Else
                           decImporte = .CantidadSal * (.PrecioCos * .TipoCambio)
                        End If

                     ElseIf lngMonedaIdCos = clsMoneda.DOLARES Then
                        If .MonedaId = lngMonedaIdCos Then
                           decImporte = .CantidadSal * .PrecioCos
                        Else
                           decImporte = .CantidadSal * (.PrecioCos / .TipoCambio)
                        End If
                     End If

                     decCantidadAcu -= decCantidad
                     decImporteAcu -= decImporte
                  End If

                  .MoveNext()
               Loop
            End If

            decPPP = decImporteAcu / ToDivByCero(decCantidadAcu)

            If decPPP = 0 Then
               decPPP = decUPC
            Else
               decPPP = ToDecimal(decPPP)
               decUPC = ToDecimal(decUPC)
            End If

            ItemSaldoActual = ToDecimal(decCantidadAcu)
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "Miscellaneous", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNotaDet.Dispose()

      End Try
   End Function

   'Metodo que habilita el filtrado en la columna del componente Grid
   Public Sub grdMainColumFilter(ByVal grdMain As Janus.Windows.GridEX.GridEX, ByVal intColum As Integer)
      grdMain.Select()
      grdMain.Col = intColum
      grdMain.Row = Janus.Windows.GridEX.GridEX.filterRowPosition
   End Sub

   'Metodo que obtiene el parametros de compra
   Public Function CompraParaFind(ByVal lngTipoCompraId As Long, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As clsCompraPara
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .TipoCompraId = lngTipoCompraId
            .SucursalId = lngSucursalID

            If .Find Then
               Return oCompraPara
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "Miscellaneous", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Public Function EmpresaFind(ByVal lngEmpresaId As Long) As clsEmpresa
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      EmpresaFind = oEmpresa

      Try
         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               Return oEmpresa
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Function

End Module
