Imports System
Imports System.IO
Imports System.Web
Imports DataDynamics.ActiveReports
Imports Intelexion.Framework.Model
Imports Intelexion.Nomina
Imports Intelexion.Framework.View
Imports System.Collections.Generic
Imports System.Web.HttpContext


Partial Class ReporteCarta

    Inherits System.Web.UI.Page

    Public RPT As New CartaFiniquito

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


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sConnection As String = Intelexion.Framework.Model.SQLConnectionProvider.getConnection("default").getConnection.ConnectionString
        'Dim sConnection As String = "Data Source=DCW319V1\MSSQLSERVER8; Initial Catalog=V5McGrawHillNominaTest; User Id=ITXTV5; Password=ITXTV5; Connection Lifetime=60; Max Pool Size=50; Min Pool Size=3"



        RPT.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" + sConnection, "sp_Reporte_CartaFiniquitoMc @IdRazonSocial = <%IdRazonSocial%>,@IdTipoNominaAsig=<" & _
                "%IdTipoNominaAsig%>,@IdTipoNominaProc = <%IdTipoNominaProc%>,@Anio = <%Anio%>,@Periodo = <%Periodo%>,@IdEmpleado = <%IdEmpleado%>,@UID = <%UID%>, @LID = <%LID%>, @idAccion = <%idAccion%>", 90)



        Dim ParamIdRazonSocial As New Parameter
        ParamIdRazonSocial.Key = "IdRazonSocial"
        'L0g 30/10/2013
        Dim ParamIdCategoria As New Parameter
        ParamIdCategoria.Key = "IdCategoria"

        Dim ParamIdTipoNominaAsig As New Parameter
        ParamIdTipoNominaAsig.Key = "IdTipoNominaAsig"
        ParamIdTipoNominaAsig.Type = Parameter.DataType.String

        Dim ParamIdTipoNominaProc As New Parameter
        ParamIdTipoNominaProc.Key = "IdTipoNominaProc"
        ParamIdTipoNominaProc.Type = Parameter.DataType.String

        Dim ParamAnio As New Parameter
        ParamAnio.Key = "Anio"

        Dim ParamPeriodo As New Parameter
        ParamPeriodo.Key = "Periodo"

        Dim ParamIdEmpleado As New Parameter
        ParamIdEmpleado.Key = "IdEmpleado"
        ParamIdEmpleado.Type = Parameter.DataType.String


        Dim ParamUID As New Parameter
        ParamUID.Key = "UID"
        ParamUID.Type = Parameter.DataType.String

        Dim ParamLID As New Parameter
        ParamLID.Key = "LID"
        ParamLID.Type = Parameter.DataType.String

        Dim ParamidAccion As New Parameter
        ParamidAccion.Key = "idAccion"

        RPT.Parameters.Clear()
        RPT.Parameters.Add(ParamIdRazonSocial)
        RPT.Parameters.Add(ParamIdTipoNominaAsig)
        RPT.Parameters.Add(ParamIdTipoNominaProc)
        RPT.Parameters.Add(ParamAnio)
        RPT.Parameters.Add(ParamPeriodo)
        RPT.Parameters.Add(ParamIdEmpleado)
        RPT.Parameters.Add(ParamUID)
        RPT.Parameters.Add(ParamLID)
        RPT.Parameters.Add(ParamidAccion)


        RPT.Parameters("IdRazonSocial").Value = Request.Params("IdRazonSocial")
        RPT.Parameters("Anio").Value = Request.Params("Periodo").Split("-")(1)
        RPT.Parameters("Periodo").Value = Request.Params("Periodo").Split("-")(0)
        RPT.Parameters("IdEmpleado").Value = Request.Params("IdEmpleado")
        RPT.Parameters("UID").Value = "'" + Context.Session("UID") + "'"
        RPT.Parameters("LID").Value = "'" + Context.Session("LID") + "'"
        RPT.Parameters("idAccion").Value = Request.Params("idAccion")
        RPT.Parameters("IdTipoNominaAsig").Value = "'" + Request.Params("IdTipoNominaAsig") + "'"
        RPT.Parameters("IdTipoNominaProc").Value = "'" + Request.Params("IdTipoNominaProc") + "'"

        'LogoEmpresa("4", RPT)

        Try
            RPT.Run()
            WebViewer1.Report = RPT
        Catch ex As Exception

        End Try
        Try
            Dim pathApp = MapPath("~")
            pathApp = pathApp + "\ArchivosTemp\"
            Dim strName As String
            strName = "CartaFiniquitoSuntory" + Context.Session("UID").trim + Date.Now.Day.ToString + Date.Now.Month.ToString + Date.Now.Year.ToString + Date.Now.Minute.ToString + Date.Now.Second.ToString + ".xls"
            Dim objXls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
            objXls.Export(RPT.Document, pathApp + strName)
            ligaExcel.Text = "<a href='" + Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath") + "/ArchivosTemp/" + strName + "' >" + "Exportar Excel" + "</a>"
        Catch ex As Exception



        End Try



        'RPT.Document.Save(context.Server.MapPath(path + "\ReportOutput\axreport.rdf"), DataDynamics.ActiveReports.Document.RdfFormat.AR20)

    End Sub



End Class




