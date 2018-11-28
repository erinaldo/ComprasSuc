Module modAppCode
   Public gfrmMain As frmMain

   Public Sub Main()
      Dim splash As New frmSplash
      Try
         splash.Show()
         splash.Update()

         clsAppInfo.Init()

         If AppLoad(4) Then
            gfrmMain = New frmMain

            splash.Close()
            splash.Dispose()

            gfrmMain.ShowDialog()
            gfrmMain.Update()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Public Function AppLoad(ByVal lngAppId As Long) As Boolean
      Dim oApp As New clsApp(clsAppInfo.ConnectString)

      clsAppInfo.AppId = 0
      clsAppInfo.AppDes = ""

      Try
         With oApp
            .AppId = lngAppId

            If .FindByPK Then
               clsAppInfo.AppId = ToLong(.AppId)
               clsAppInfo.AppDes = ToStr(.AppDes)
               clsAppInfo.DataBaseSource = ToStr(.DataBaseSource)
               clsAppInfo.DataBaseName = ToStr(.DataBaseName)

               AppLoad = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         AppLoad = False

      Finally
         oApp.Dispose()

      End Try
   End Function

   Public Sub PreferenceLoad(ByVal lngAppId As Long, ByVal lngUserId As Long)
      Dim oPreference As New clsPreference(clsAppInfo.ConnectString)

      clsAppInfo.EmpresaId = 0
      clsAppInfo.GestionId = 0

      Try
         With oPreference
            .SelectFilter = clsPreference.SelectFilters.All
            .WhereFilter = clsPreference.WhereFilters.UserId
            .AppId = lngAppId
            .UserId = lngUserId

            If .Find Then
               clsAppInfo.EmpresaId = ToLong(.EmpresaId)
               clsAppInfo.GestionId = ToLong(.GestionId)

               Call GestionParaLoad(.GestionId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPreference.Dispose()

      End Try
   End Sub

   Public Sub GestionParaLoad(ByVal lngGestionId As Long)
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      clsAppInfo.Gestion = 0

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               clsAppInfo.Gestion = ToLong(.Gestion)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Sub

   Public Sub EmpresaParaLoad(ByVal lngEmpresaId As Long)
      Call EmpresaLoad(lngEmpresaId)
      Call PlanIdParaLoad(lngEmpresaId)
      Call CompraParaLoad(lngEmpresaId, 2, clsAppInfo.GestionId, clsAppInfo.SucursalId)
      Call SucursalCentralLoad(lngEmpresaId)
      Call EmpresaParaCheck()

   End Sub

   Public Sub EmpresaLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      clsAppInfo.EmpresaId = 0
      clsAppInfo.EmpresaDes = ""
      clsAppInfo.EmpresaGral = ""
      clsAppInfo.MonedaId = 0
      clsAppInfo.CiudadId = 0

      Try
         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               clsAppInfo.EmpresaId = ToLong(.EmpresaId)
               clsAppInfo.EmpresaDes = ToStr(.EmpresaDes)
               clsAppInfo.MonedaId = ToLong(.MonedaId)
               clsAppInfo.CiudadId = ToLong(.CiudadId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Sub

   Public Sub SucursalCentralLoad(ByVal lngEmpresaId As Long)
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)

      clsAppInfo.SucursalId = 0
      clsAppInfo.SucursalDes = ""

      Try
         With oSucursal
            .SelectFilter = clsSucursal.SelectFilters.All
            .WhereFilter = clsSucursal.WhereFilters.TipoSucursalId
            .EmpresaId = lngEmpresaId
            .TipoSucursalId = 1

            If .Find Then
               clsAppInfo.SucursalId = ToLong(.SucursalId)
               clsAppInfo.SucursalDes = ToStr(.SucursalDes)
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()

      End Try
   End Sub

   Public Sub EmpresaParaCheck()
      Dim strMsg As String = String.Empty

      If clsAppInfo.PlanCreId = 0 Then
         strMsg &= "Cuenta para Crédito Fiscal" & vbCrLf
      End If

      If clsAppInfo.PlanDebId = 0 Then
         strMsg &= "Cuenta para Débito Fiscal" & vbCrLf
      End If

      If clsAppInfo.PlanITId = 0 Then
         strMsg &= "Cuenta para Impuesto a las Transacciones" & vbCrLf
      End If

      If clsAppInfo.PlanITPId = 0 Then
         strMsg &= "Cuenta para Impuesto a las Transacciones por Pagar" & vbCrLf
      End If

      If clsAppInfo.PlanITFId = 0 Then
         strMsg &= "Cuenta para Impuesto a las Transacciones Financieras" & vbCrLf
      End If

      If clsAppInfo.PlanDifId = 0 Then
         strMsg &= "Cuenta para Diferencia de Cambio" & vbCrLf
      End If

      If clsAppInfo.PlanResId = 0 Then
         strMsg &= "Cuenta para Resultado de la Gestion" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         If MessageBox.Show("La(s) Siguiente(s) Aun no Fueron Parametrisadas y esto Podria Ocasionar Problemas con los Asientos Automaticos" & vbCrLf & vbCrLf & strMsg & vbCrLf & "¿Desea Parametrisarla(s) Ahora?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim frm As New frmEmpresaPara

            With frm
               .MdiParent = gfrmMain
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With
         End If
      End If
   End Sub

   Public Sub ImpuestoLoad()
      Dim oImpuesto As New clsImpuesto(clsAppInfo.ConnectString)

      clsAppInfo.IVA = 0

      Try
         With oImpuesto
            .SelectFilter = clsImpuesto.SelectFilters.All

            If .Open Then
               Do While .Read
                  If .ImpuestoId = 1 Then
                     clsAppInfo.IVA = .Valor
                  ElseIf .ImpuestoId = 2 Then
                     clsAppInfo.IT = .Valor
                  ElseIf .ImpuestoId = 3 Then
                     clsAppInfo.ITF = .Valor
                  ElseIf .ImpuestoId = 5 Then
                     clsAppInfo.IUE_Servicios = .Valor
                  ElseIf .ImpuestoId = 6 Then
                     clsAppInfo.IUE_Bienes = .Valor
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oImpuesto.Dispose()

      End Try
   End Sub

   Public Sub PlanIdParaLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresaPara As New clsEmpresaPara(clsAppInfo.ConnectString)

      clsAppInfo.PlanCreId = 0

      Try
         With oEmpresaPara
            .SelectFilter = clsEmpresaPara.SelectFilters.All
            .WhereFilter = clsEmpresaPara.WhereFilters.EmpresaId
            .EmpresaId = lngEmpresaId

            If .Find Then
               clsAppInfo.DecimalNro = ToInteger(.DecimalNro)
               clsAppInfo.PlanCreId = ToLong(.PlanCreId)
               clsAppInfo.PlanCreDifId = ToLong(.PlanCreDifId)
               clsAppInfo.PlanDebId = ToLong(.PlanDebId)
               clsAppInfo.PlanDebDifId = ToLong(.PlanDebDifId)
               clsAppInfo.PlanITId = ToLong(.PlanITId)
               clsAppInfo.PlanITPId = ToLong(.PlanITPId)
               clsAppInfo.PlanITFId = ToLong(.PlanITFId)
               clsAppInfo.PlanDifId = ToLong(.PlanDifId)
               clsAppInfo.PlanResId = ToLong(.PlanResId)

               clsAppInfo.PlanCreRetId = ToLong(.PlanCreRetId)
               clsAppInfo.PlanITRetId = ToLong(.PlanITRetId)
               clsAppInfo.PlanIUERetSerId = ToLong(.PlanIUERetSerId)
               clsAppInfo.PlanIUERetBieId = ToLong(.PlanIUERetBieId)
               clsAppInfo.PlanExentoId = ToLong(.PlanExentoId)

               clsAppInfo.EmpresaGral = ToStr(.EmpresaGral)
               clsAppInfo.TipoHojaId = ToLong(.TipoHojaId)
               clsAppInfo.Inventario = ToBoolean(.Inventario)
               clsAppInfo.ItemCodShow = ToBoolean(.ItemCodShow)
               clsAppInfo.PlanCtaShow = ToBoolean(.PlanCtaShow)
               clsAppInfo.FechaOpera = ToBoolean(.FechaOpera)
               clsAppInfo.CodBarra = ToBoolean(.CodBarra)
               clsAppInfo.SepararExento = ToBoolean(.SepararExento)
               clsAppInfo.MultipleNro = ToBoolean(.MultipleNro)
               clsAppInfo.CentroCostoApli = ToBoolean(.CentroCostoApli)
               clsAppInfo.SucursalApli = ToBoolean(.SucursalApli)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresaPara.Dispose()

      End Try
   End Sub

   Public Sub CompraParaLoad(ByVal lngEmpresaId As Long, ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long)
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         clsAppInfo.ExigirFac = False
         clsAppInfo.PagoAuto = False

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = lngEmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               clsAppInfo.ExigirFac = ToBoolean(.ConFac)
               clsAppInfo.PagoAuto = ToBoolean(.PagoAuto)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Sub

   Public Function CompraParaRowsMaxFind(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngTipoCompraId As Long, ByVal lngSucursalId As Long) As Integer
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaRowsMaxFind = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = lngEmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               CompraParaRowsMaxFind = .RowsMax
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Public Function OperaFechaHabil(ByVal strFecha As String) As Boolean
      If clsAppInfo.FechaOpera Then
         Dim oOpera As New clsOpera(clsAppInfo.ConnectString)

         Try
            With oOpera
               .SelectFilter = clsOpera.SelectFilters.All
               .WhereFilter = clsOpera.WhereFilters.Fecha
               .AppId = clsAppInfo.AppId
               .GroupId = clsAppInfo.GroupId
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .Fecha = strFecha

               If .Find Then
                  OperaFechaHabil = ToBoolean(.Enabled)
               Else
                  OperaFechaHabil = False
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         Finally
            oOpera.Dispose()
         End Try

      Else
         Return True
      End If
   End Function

   Public Sub SecuritySet(ByRef frmCurrent As Object, ByVal strAppExe As String)
      Dim ctrUno As Control
      Dim oRight As New clsRight(clsAppInfo.ConnectString)

      Try
         With oRight
            .SelectFilter = clsRight.SelectFilters.All
            .WhereFilter = clsRight.WhereFilters.FormName
            .AppExe = strAppExe
            .FormName = frmCurrent.Name
            .GroupId = clsAppInfo.GroupId

            If .Open Then
               Do While .Read
                  For Each ctrUno In frmCurrent.Controls
                     If UCase$(ctrUno.GetType.Name) = UCase$("UIReBar") Then
                        Dim ctrDos As Janus.Windows.UI.CommandBars.UICommand

                        For Each ctrDos In frmCurrent.cdmMain.Commands
                           If UCase$(ctrDos.Key) = UCase$(.CtrlName) Then
                              ctrDos.Visible = BooleamToJanus(.Visible)
                              ctrDos.Enabled = BooleamToJanus(.Enabled)

                              Exit For
                           End If
                        Next
                     End If
                  Next

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRight.Dispose()

      End Try
   End Sub

   Public Sub SecuritySetTouch(ByRef frmCurrent As Object, ByVal strAppExe As String)
      Dim ctrUno As Control
      Dim oRight As New clsRight(clsAppInfo.ConnectString)

      Try
         With oRight
            .SelectFilter = clsRight.SelectFilters.All
            .WhereFilter = clsRight.WhereFilters.FormName
            .AppExe = strAppExe
            .FormName = frmCurrent.Name
            .GroupId = clsAppInfo.GroupId
            Dim frmName As String = ""
            If .Open Then
               Do While .Read
                  For Each ctrUno In frmCurrent.Controls

                     frmName &= "," & ctrUno.GetType.Name

                     If SecuritySetTouchRec(ctrUno, oRight.CtrlName, oRight) Then
                        Exit For
                     End If

                  Next

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oRight.Dispose()

      End Try
   End Sub

   Public Function SecuritySetTouchRec(ByRef ctrUno As Object, ByVal strFindControl As String, ByVal oRight As clsRight) As Boolean
      Try
         If UCase$(ctrUno.GetType.Name) = UCase$("UIButton") Then
            Dim ctrDos As Janus.Windows.EditControls.UIButton = CType(ctrUno, Janus.Windows.EditControls.UIButton)
            If ctrDos.Name = strFindControl Then
               ctrUno.Visible = ToBoolean(oRight.Visible)
               ctrUno.Enabled = ToBoolean(oRight.Enabled)

               Return True
            End If

         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UICheckBox") Then
            Dim ctrDos As Janus.Windows.EditControls.UICheckBox = CType(ctrUno, Janus.Windows.EditControls.UICheckBox)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIComboBox") Then
            Dim ctrDos As Janus.Windows.EditControls.UIComboBox = CType(ctrUno, Janus.Windows.EditControls.UIComboBox)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("CheckBox") Then
            Dim ctrDos As System.Windows.Forms.CheckBox = CType(ctrUno, System.Windows.Forms.CheckBox)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("Button") Then
            Dim ctrDos As System.Windows.Forms.Button = CType(ctrUno, System.Windows.Forms.Button)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("ComboBox") Then
            Dim ctrDos As System.Windows.Forms.ComboBox = CType(ctrUno, System.Windows.Forms.ComboBox)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
            '----------------  CONTENEDORES -----------------------------------------
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIContainer") Then
            Dim ctrAux As Janus.Windows.UI.Dock.UIPanel = CType(ctrUno, Janus.Windows.UI.Dock.UIPanel)
            For Each ctrDos In ctrAux.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIPanel") Then
            Dim ctrAux As Janus.Windows.UI.Dock.UIPanel = CType(ctrUno, Janus.Windows.UI.Dock.UIPanel)
            For Each ctrDos In ctrAux.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIPanelInnerContainer") Then
            Dim ctrAux As Janus.Windows.UI.Dock.UIPanelInnerContainer = CType(ctrUno, Janus.Windows.UI.Dock.UIPanelInnerContainer)
            For Each ctrDos In ctrAux.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIReBar") Then
            Dim ctrDos As Janus.Windows.UI.CommandBars.UICommand
            For Each ctrDos In ctrUno.cdmMain.Commands
               If UCase$(ctrDos.Key) = UCase$(strFindControl) Then
                  ctrDos.Visible = BooleamToJanus(oRight.Visible)
                  ctrDos.Enabled = BooleamToJanus(oRight.Enabled)
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UITab") Then
            Dim ctrAux As Janus.Windows.UI.Tab.UITab = CType(ctrUno, Janus.Windows.UI.Tab.UITab)
            For Each ctrDos In ctrAux.TabPages
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UITabPage") Then
            Dim ctrAux As Janus.Windows.UI.Tab.UITabPage = CType(ctrUno, Janus.Windows.UI.Tab.UITabPage)
            For Each ctrDos In ctrAux.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIGroupBox") Then
            'Dim ctrAux As Janus.Windows.UI.Tab.UITabPage = CType(ctrUno, Janus.Windows.UI.Tab.UITabPage)
            For Each ctrDos In ctrUno.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         End If

         Return False
      Catch exp As Exception
         Throw exp

      Finally
         oRight.Dispose()

      End Try
   End Function


    Public Function NotaSucursalApeExist(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Boolean
        Dim oNotaPara As New clsNotaPara(clsAppInfo.ConnectString)

        Try
            NotaSucursalApeExist = False

            With oNotaPara
                .RowCountFilter = clsNotaPara.RowCountFilters.All
                .WhereFilter = clsNotaPara.WhereFilters.AperturaNotaPorSucursal
                .EmpresaId = lngEmpresaId
                .GestionId = lngGestionId
                .SucursalId = lngSucursalId

                If .RowCount() > 0 Then
                    NotaSucursalApeExist = True
                End If

            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Finally
            oNotaPara.Dispose()

        End Try
    End Function

    Public Function CompSucursalApeExist(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Boolean
        Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

        Try
            CompSucursalApeExist = False

            With oCompPara
                .RowCountFilter = clsCompPara.RowCountFilters.All
                .WhereFilter = clsCompPara.WhereFilters.AperturaCompPorSucursal
                .EmpresaId = lngEmpresaId
                .GestionId = lngGestionId
                .SucursalId = lngSucursalId

                If .RowCount() > 0 Then
                    CompSucursalApeExist = True
                End If

            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Finally
            oCompPara.Dispose()

        End Try
    End Function

   Public Function BooleamToJanus(ByVal bytValue As Byte) As Byte
      If ToBoolean(bytValue) Then
         Return Janus.Windows.UI.InheritableBoolean.True
      Else
         Return Janus.Windows.UI.InheritableBoolean.False
      End If
   End Function

   Public Function JanusToBooleam(ByVal bytValue As Byte) As Byte
      If bytValue = Janus.Windows.UI.InheritableBoolean.True Then
         Return 1
      ElseIf bytValue = Janus.Windows.UI.InheritableBoolean.False Then
         Return 0
      End If
   End Function

End Module
