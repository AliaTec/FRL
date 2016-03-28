Imports System
Imports System.IO
Imports System.Web
Imports DataDynamics.ActiveReports
Imports Intelexion.Framework.Model
Imports Intelexion.Nomina
Imports Intelexion.Framework.View
Imports System.Collections.Generic

Partial Public Class Reporte7

    Inherits System.Web.UI.Page

    Public RPT As New ISNMEX

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sConnection As String = Intelexion.Framework.Model.SQLConnectionProvider.getConnection("default").getConnection.ConnectionString
        'Dim sConnection As String = "Data Source=DCW319V1\MSSQLSERVER8; Initial Catalog=V5McGrawHillNominaTest; User Id=ITXTV5; Password=ITXTV5; Connection Lifetime=60; Max Pool Size=50; Min Pool Size=3"
        'RPT.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" + sConnection, "spq_nomGraExenMensualesMensual @IdRazonSocial =<%IdRazonSocial%>, @IdTipoNominaAsig = <%I" & _
        '"dTipoNominaAsig%>,@IdTipoNominaProc=<%IdTipoNominaProc%>,@Anio=<%Anio%>,@Mes" & _
        '"=<%Mes%>,@UID=<%UID%>,@LID=<%LID%>,@idAccion=<%idAccion%>", 30)

        RPT.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" + sConnection, "spq_nomISNmex @IdRazonSocial = <%IdRazonSocial%>" & _
               "@Anio = <%Anio%>,@Mes = <%Mes%>,@UID = <%UID%>, @LID = <%LID%>, @idAccion = <%idAccion%>", 90)

        Dim ParamIdRazonSocial As New Parameter
        ParamIdRazonSocial.Key = "IdRazonSocial"

        Dim ParamAnio As New Parameter
        ParamAnio.Key = "Anio"

        Dim ParamMes As New Parameter
        ParamMes.Key = "Mes"

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
        RPT.Parameters.Add(ParamAnio)
        RPT.Parameters.Add(ParamMes)
        RPT.Parameters.Add(ParamUID)
        RPT.Parameters.Add(ParamLID)
        RPT.Parameters.Add(ParamidAccion)


        RPT.Parameters("IdRazonSocial").Value = Request.Params("IdRazonSocial")
        RPT.Parameters("Anio").Value = Request.Params("Anio")
        RPT.Parameters("Mes").Value = Request.Params("Mes")
        RPT.Parameters("UID").Value = "'" + Context.Session("UID") + "'"
        RPT.Parameters("LID").Value = "'" + Context.Session("LID") + "'"
        RPT.Parameters("idAccion").Value = Request.Params("idAccion")


        Try
            RPT.Run()
            WebViewer7.Report = RPT
        Catch ex As Exception

        End Try
        Try


            Dim pathApp = MapPath("~")
            pathApp = pathApp + "\ArchivosTemp\"
            Dim strName As String
            strName = "ISNMEX" + Context.Session("UID").trim + Date.Now.Day.ToString + Date.Now.Month.ToString + Date.Now.Year.ToString + Date.Now.Minute.ToString + Date.Now.Second.ToString + ".xls"
            Dim objXls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
            objXls.Export(RPT.Document, pathApp + strName)
            ligaExcel.Text = "<a href='" + Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath") + "/ArchivosTemp/" + strName + "' >" + "Exportar Excel" + "</a>"
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