Imports Microsoft.Reporting.WinForms
Imports CapaNegocio
Public Class frmReporteProfesor

    Private Sub frmReporteProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim negReporte As New negProfesor
        Dim dst As New Colegio_DBDataSet
        dst.Tables.Add(negReporte.ObtenerReporteProfesor)
        Dim rds As New ReportDataSource("DataSet1", dst.Tables(1))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class