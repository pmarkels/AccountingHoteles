Public Class Tablas

    Private Sub Tablas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oDs As Data.DataSet

        'cmbOpcion.Items.Add("(Buscar)")
        'cmbOpcion.Items.Add("DKNumber")
        'cmbOpcion.Items.Add("TMA")

        oDs = New DataSet
        oDs.ReadXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\Areas.xml")
        grdAreas.DataSource = oDs.Tables(0)
        grdAreas.Refresh()

        'oDs = New DataSet
        'oDs.ReadXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\DKsRes2.xml")

        'Dim i As Integer

        'For i = 0 To oDs.Tables(0).Rows.Count - 1

        '    grdDKNumbers.Rows.Add()

        '    grdDKNumbers.Rows(i).Cells("DKNumber").Value = oDs.Tables(0).Rows(i).Item("DKNumber")
        '    grdDKNumbers.Rows(i).Cells("TMA").Value = oDs.Tables(0).Rows(i).Item("TMA")
        '    grdDKNumbers.Rows(i).Cells("Empresa").Value = oDs.Tables(0).Rows(i).Item("Empresa")
        '    If IsDBNull(oDs.Tables(0).Rows(i).Item("ARAcuerdoCabotaje")) Then
        '        grdDKNumbers.Rows(i).Cells("ARAcuerdoCabotaje").Value = ""
        '    Else
        '        If oDs.Tables(0).Rows(i).Item("ARAcuerdoCabotaje") = "E" Then
        '            grdDKNumbers.Rows(i).Cells("ARAcuerdoCabotaje").Value = "Acuerdo Over"
        '        ElseIf oDs.Tables(0).Rows(i).Item("ARAcuerdoCabotaje") = "C" Then
        '            grdDKNumbers.Rows(i).Cells("ARAcuerdoCabotaje").Value = "General"
        '        Else
        '            grdDKNumbers.Rows(i).Cells("ARAcuerdoCabotaje").Value = ""
        '        End If
        '    End If

        '    If IsDBNull(oDs.Tables(0).Rows(i).Item("LANAcuerdoCabotaje")) Then
        '        grdDKNumbers.Rows(i).Cells("LANAcuerdoCabotaje").Value = ""
        '    Else
        '        If oDs.Tables(0).Rows(i).Item("LANAcuerdoCabotaje") = "C" Then
        '            grdDKNumbers.Rows(i).Cells("LANAcuerdoCabotaje").Value = "Tiene Acuerdo"
        '        Else
        '            grdDKNumbers.Rows(i).Cells("LANAcuerdoCabotaje").Value = ""
        '        End If

        '    End If

        '    If IsDBNull(oDs.Tables(0).Rows(i).Item("AcuerdoInternacional")) Then
        '        grdDKNumbers.Rows(i).Cells("AcuerdoInternacional").Value = ""
        '    Else
        '        If oDs.Tables(0).Rows(i).Item("AcuerdoInternacional") = "I" Then
        '            grdDKNumbers.Rows(i).Cells("AcuerdoInternacional").Value = "Tiene Acuerdo"
        '        Else
        '            grdDKNumbers.Rows(i).Cells("AcuerdoInternacional").Value = ""
        '        End If

        '    End If

        'Next
        'grdDKNumbers.Refresh()

        oDs = New DataSet
        oDs.ReadXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\TextosError.xml")
        grdTextos.DataSource = oDs.Tables(0)
        grdTextos.Columns(0).Width = 500
        grdAreas.Refresh()


        ''Cargo los textos de error
        'oDs = New DataSet
        'oDs.ReadXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\TextosError.xml")
        'For i = 0 To oDs.Tables(0).Rows.Count - 1
        '    grdTextos.Rows.Add()
        '    grdTextos.Rows(i).Cells("Texto").Value = oDs.Tables(0).Rows(i).Item("Texto")
        'Next
        'grdTextos.Refresh()

        'TabControl1.TabPages(1).Width = 0

        TabControl1.SelectedIndex = 0

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim oDs As Data.DataSet
        Dim oDt As DataTable

        oDs = New Data.DataSet("Areas")
        oDt = grdAreas.DataSource
        oDt.TableName = "Area"
        oDs.Tables.Add(oDt.Copy)
        oDs.WriteXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\Areas.xml")
        oDt = Nothing
        oDs = Nothing


        'oDt = New DataTable
        'oDt.TableName = "DK"
        'With oDt
        '    .Columns.Add("DKNumber", Type.GetType("System.String"))
        '    .Columns.Add("TMA", Type.GetType("System.String"))
        '    .Columns.Add("Empresa", Type.GetType("System.String"))
        '    .Columns.Add("ARAcuerdoCabotaje", Type.GetType("System.String"))
        '    .Columns.Add("LANAcuerdoCabotaje", Type.GetType("System.String"))
        '    .Columns.Add("AcuerdoInternacional", Type.GetType("System.String"))
        'End With

        'Dim i As Integer
        'Dim oRow As DataRow
        'For i = 0 To grdDKNumbers.Rows.Count - 1
        '    oRow = oDt.NewRow()
        '    oRow("DKNumber") = grdDKNumbers.Rows(i).Cells("DKNumber").Value
        '    oRow("TMA") = grdDKNumbers.Rows(i).Cells("TMA").Value
        '    oRow("Empresa") = grdDKNumbers.Rows(i).Cells("Empresa").Value

        '    If grdDKNumbers.Rows(i).Cells("ARAcuerdoCabotaje").Value = "" Then
        '        oRow("ARAcuerdoCabotaje") = ""
        '    Else
        '        If grdDKNumbers.Rows(i).Cells("ARAcuerdoCabotaje").Value = "Acuerdo Over" Then
        '            oRow("ARAcuerdoCabotaje") = "E"
        '        ElseIf grdDKNumbers.Rows(i).Cells("ARAcuerdoCabotaje").Value = "General" Then
        '            oRow("ARAcuerdoCabotaje") = "C"
        '        Else
        '            oRow("ARAcuerdoCabotaje") = ""
        '        End If
        '    End If

        '    If grdDKNumbers.Rows(i).Cells("LANAcuerdoCabotaje").Value = "" Then
        '        oRow("LANAcuerdoCabotaje") = ""
        '    Else
        '        If grdDKNumbers.Rows(i).Cells("LANAcuerdoCabotaje").Value = "Tiene Acuerdo" Then
        '            oRow("LANAcuerdoCabotaje") = "C"
        '        Else
        '            oRow("LANAcuerdoCabotaje") = ""
        '        End If
        '    End If

        '    If grdDKNumbers.Rows(i).Cells("AcuerdoInternacional").Value = "" Then
        '        oRow("AcuerdoInternacional") = ""
        '    Else
        '        If grdDKNumbers.Rows(i).Cells("AcuerdoInternacional").Value = "Tiene Acuerdo" Then
        '            oRow("AcuerdoInternacional") = "I"
        '        Else
        '            oRow("AcuerdoInternacional") = ""
        '        End If
        '    End If

        '    oDt.Rows.Add(oRow)

        'Next

        'oDs = New Data.DataSet("DKs")
        'oDs.Tables.Add(oDt.Copy)
        'oDs.WriteXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\DKsRes2.xml")
        'oDt = Nothing
        'oDs = Nothing


        oDs = New Data.DataSet("Textos")
        oDt = grdTextos.DataSource
        oDt.TableName = "Record"
        oDs.Tables.Add(oDt.Copy)
        oDs.WriteXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\TextosError.xml")
        oDt = Nothing
        oDs = Nothing

        'oDt = New DataTable
        'oDt.TableName = "Record"
        'oDt.Columns.Add("Texto", Type.GetType("System.String"))

        'For i = 0 To grdTextos.Rows.Count - 1
        '    oRow = oDt.NewRow()
        '    oRow("Texto") = grdTextos.Rows(i).Cells("Texto").Value
        '    oDt.Rows.Add(oRow)
        'Next

        'oDs = New Data.DataSet("Textos")
        'oDs.Tables.Add(oDt.Copy)
        'oDs.WriteXml(System.Configuration.ConfigurationManager.AppSettings("Datos") & "\TextosError.xml")
        'oDt = Nothing
        'oDs = Nothing

    End Sub

    Private Function DKRepetido(ByVal oDt As DataTable, ByVal sNombre As String) As Boolean

        Dim i, j As Integer
        Dim sDK As String

        For i = 0 To oDt.Rows.Count - 1
            sDK = oDt.Rows(i).Item(0)
            For j = i + 1 To oDt.Rows.Count - 1
                If oDt.Rows(j).Item(0) = sDK Then
                    MsgBox("El DKNumber " & sDK & " se encuentra repetido en la tabla: " & sNombre & ". Esta tabla no va a guardar los cambios.", MsgBoxStyle.Critical)
                    Return True
                End If
            Next
        Next

        Return False

    End Function

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim i As Integer

        'If cmbOpcion.Text = "DKNumber" Then
        '    For i = 0 To grdDKNumbers.Rows.Count - 1
        '        If grdDKNumbers.Rows(i).Cells("DKNumber").Value = txtBuscar.Text Then
        '            grdDKNumbers.Rows(i).Selected = True
        '            grdDKNumbers.

        '            grdDKNumbers.Refresh()
        '            Exit For
        '        End If

        '    Next

        'End If
    End Sub
End Class