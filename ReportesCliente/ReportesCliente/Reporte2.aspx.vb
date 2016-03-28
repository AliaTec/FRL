Imports System
Imports System.IO
Imports System.Web
Imports DataDynamics.ActiveReports
Imports Intelexion.Framework.Model
Imports Intelexion.Nomina
Imports Intelexion.Framework.View
Imports System.Collections.Generic

Partial Public Class Reporte2
    Inherits System.Web.UI.Page

    Public RPT As New CartaFiniquito

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sConnection As String = Intelexion.Framework.Model.SQLConnectionProvider.getConnection("default").getConnection.ConnectionString
        'Dim sConnection As String = "Data Source=DCW319V1\MSSQLSERVER8; Initial Catalog=V5McGrawHillNominaTest; User Id=ITXTV5; Password=ITXTV5; Connection Lifetime=60; Max Pool Size=50; Min Pool Size=3"
        'RPT.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" + sConnection, "sp_Reporte_Comparativo @IdRazonSocial =<%IdRazonSocial%>, @IdTipoNominaAsig = <%I" & _
        '"dTipoNominaAsig%>,@IdTipoNominaProc=<%IdTipoNominaProc%>,@Anio=<%Anio%>,@Periodo" & _
        '"=<%Periodo%>,@UID=<%UID%>,@LID=<%LID%>,@idAccion=<%idAccion%>", 30)

        RPT.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" + sConnection, "spq_nomAcumuladoConceptoEmpleado @IdRazonSocial = <%IdRazonSocial%>,@IdTipoNominaAsig=<" & _
        "%IdTipoNominaAsig%>,@IdTipoNominaProc = <%IdTipoNominaProc%>,@Anio = <%Anio%>,@Periodo = <%Periodo%>,@IdEmpleado = <%IdEmpleado%>, @UID = <%UID%>, @LID = <%LID%>, @idAccion = <%idAccion%>", 90)

        Dim ParamIdRazonSocial As New Parameter
        ParamIdRazonSocial.Key = "IdRazonSocial"

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
        RPT.Parameters("IdEmpleado").Value = "''"
        RPT.Parameters("UID").Value = "'" + Context.Session("UID") + "'"
        RPT.Parameters("LID").Value = "'" + Context.Session("LID") + "'"
        RPT.Parameters("idAccion").Value = Request.Params("idAccion")
        RPT.Parameters("IdTipoNominaAsig").Value = "'" + Request.Params("IdTipoNominaAsig") + "'"
        RPT.Parameters("IdTipoNominaProc").Value = "'" + Request.Params("IdTipoNominaProc") + "'"

        Try
            RPT.Run()
            WebViewer2.Report = RPT
        Catch ex As Exception

        End Try

        Try
            Dim pathApp = MapPath("~")
            pathApp = pathApp + "\ArchivosTemp\"
            Dim strName As String
            strName = "CartaFiniquito" + Context.Session("UID").trim + Date.Now.Day.ToString + Date.Now.Month.ToString + Date.Now.Year.ToString + Date.Now.Minute.ToString + Date.Now.Second.ToString + ".xls"
            Dim objXls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
            objXls.Export(RPT.Document, pathApp + strName)
            ligaExcel1.Text = "<a href='" + Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath") + "/ArchivosTemp/" + strName + "' >" + pathApp + strName + "</a>"
        Catch ex As Exception

        End Try

        'RPT.Document.Save(context.Server.MapPath(path + "\ReportOutput\axreport.rdf"), DataDynamics.ActiveReports.Document.RdfFormat.AR20)

    End Sub

    Private Function GenerateParameterValue(ByVal parameterName As String, ByVal EmpleadoMovto As Intelexion.Nomina.Entities.EmpleadoMovtoEntity) As String
        If (parameterName.ToLower() = "idrazonsocial") Then
            Return EmpleadoMovto.IdRazonSocial
        End If
        If (parameterName.ToLower() = "idtiponominaasig") Then
            Return EmpleadoMovto.IdTipoNominaAsig
        End If
        If (parameterName.ToLower() = "idtiponominaproc") Then
            Return EmpleadoMovto.IdTipoNominaProc
        End If
        If (parameterName.ToLower() = "anio") Then
            Return EmpleadoMovto.Anio
        End If
        If (parameterName.ToLower() = "periodo") Then
            Return EmpleadoMovto.Periodo
        End If
        If (parameterName.ToLower() = "idempleado") Then
            Return IIf(String.IsNullOrEmpty(EmpleadoMovto.IdEmpleado), " ", EmpleadoMovto.IdEmpleado)
        End If
        If (parameterName.ToLower() = "uid") Then
            Return EmpleadoMovto.UID
        End If
        If (parameterName.ToLower() = "lid") Then
            Return EmpleadoMovto.LID
        End If
        If (parameterName.ToLower() = "idaccion") Then
            Return EmpleadoMovto.idAccion
        End If

    End Function

End Class



