Imports System
Imports System.IO
Imports System.Web
Imports DataDynamics.ActiveReports
Imports Intelexion.Framework.Model
Imports Intelexion.Nomina
Imports Intelexion.Framework.View

Partial Class ReporteConcentradoAnualAR_Visor

    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Dim path As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath")

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p As PresentationEntity
        p = DirectCast(Session("Presentation"), PresentationEntity)

        Dim ReportesHistoricos As New Entities.ReportesHistoricos

        If Not p Is Nothing Then
            If Not p.getValue("objReportesHistoricos") Is Nothing Then ReportesHistoricos = CType(p.getValue("objReportesHistoricos"), Entities.ReportesHistoricos)
        End If

        Dim sConnection As String = Intelexion.Framework.Model.SQLConnectionProvider.getConnection("default").getConnection.ConnectionString

        Dim RPT As New ReporteConcentradoAnualAR
        RPT.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" + sConnection, "sp_Reporte_ConcentradoAnual @IdRazonSocial=<%IdRazonSocial%>,@Anio=<%Anio%>," & _
        "@IdTipoNomina=<%IdTipoNomina%>,@UID=<%UID%>,@LID=<%LID%>,@idAccion=<%idAccion%>", 30)

        RPT.Parameters("IdRazonSocial").Value = ReportesHistoricos.IdRazonSocial
        RPT.Parameters("Anio").Value = ReportesHistoricos.Anio
        RPT.Parameters("IdTipoNomina").Value = "'" + ReportesHistoricos.IdTipoNomina + "'"
        RPT.Parameters("UID").Value = "'" + ReportesHistoricos.UID + "'"
        RPT.Parameters("LID").Value = "'" + ReportesHistoricos.LID + "'"
        RPT.Parameters("idAccion").Value = ReportesHistoricos.idAccion
        RPT.Document.Printer.PrinterName = ""
        RPT.Run()
        WebViewer1.Report = RPT
        Dim objExcel As New DataDynamics.ActiveReports.Export.Xls.XlsExport
        Dim pathFile As String
        Dim urlFile As String
        pathFile = MapPath("~")
        urlFile = "/ArchivosTemp/ConcentradoAnualNominas_" + ReportesHistoricos.UID.Trim + Date.Now.Day.ToString + "_" + Date.Now.Month.ToString + "_" + Date.Now.Year.ToString + "_" + Date.Now.Hour.ToString + "_" + Date.Now.Minute.ToString + "_" + Date.Now.Second.ToString + ".xls"
        pathFile = pathFile + urlFile.Replace("/", "\")
        urlFile = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath") + urlFile
        Try
            objExcel.Export(RPT.Document, pathFile)
            Me.LigaExcel.Text = "<A HREF='" + urlFile + "' > Descargar Archivo Excel </A>"
        Catch ex As Exception
            Me.LigaExcel.Text = ""
        End Try

    End Sub


End Class

