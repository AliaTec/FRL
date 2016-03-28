Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Intelexion.Nomina
Imports Nomina

Public Class CartaFiniquito
    Inherits DataDynamics.ActiveReports.ActiveReport3

    Dim ReportesProceso As New Entities.ReportesProceso
    Dim sConnection As String = Intelexion.Framework.Model.SQLConnectionProvider.getConnection("default").getConnection.ConnectionString
    Public Sub New(ByVal reporte As Entities.ReportesProceso)

        'This call is required by the ActiveReports Designer.
        InitializeComponent()
        ReportesProceso = reporte
        Me.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" + sConnection, "sp_Reporte_CartaFiniquitoMc @IdRazonSocial = <%IdRazonSocial%>,@IdTipoNominaAsig=<" & _
        "%IdTipoNominaAsig%>,@IdTipoNominaProc = <%IdTipoNominaProc%>,@Anio = <%Anio%>,@Periodo = <%Periodo%>, @IdEmpleado = <%IdEmpleado%>, @UID = <%UID%>, @LID = <%LID%>, @idAccion = <%idAccion%>", 90)

    End Sub


    Public Sub CartaFiniquito_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.ShowParameterUI = False
        Me.SetLicense("Hector Ramirez,Intelexion,DD-APN-30-C000260,S4VKSH448MS77HKH9FH9")
        Me.Parameters("IdRazonSocial").Value = ReportesProceso.IdRazonSocial
        Me.Parameters("IdTipoNominaAsig").Value = "'" + ReportesProceso.IdTipoNominaAsig + "'"
        Me.Parameters("IdTipoNominaProc").Value = "'" + ReportesProceso.IdTipoNominaProc + "'"
        Me.Parameters("Anio").Value = ReportesProceso.Anio
        Me.Parameters("Periodo").Value = ReportesProceso.Periodo
        Me.Parameters("IdEmpleado").Value = "'" + ReportesProceso.IdEmpleado + "'"
        Me.Parameters("UID").Value = "'" + ReportesProceso.UID + "'"
        Me.Parameters("LID").Value = "'" + ReportesProceso.LID + "'"
        Me.Parameters("idAccion").Value = ReportesProceso.idAccion

        'parametros que se envian al subreporte abajo mencionados
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

        ''******* SUBREPORTE PERCEPCIONES **************/
        '                                  nombre del subreporte
        Dim SubReportePercepciones As New Percepciones
        SubReportePercepciones.Parameters.Clear()

        'aqui se agregan
        SubReportePercepciones.Parameters.Add(ParamIdRazonSocial)
        SubReportePercepciones.Parameters.Add(ParamIdTipoNominaAsig)
        SubReportePercepciones.Parameters.Add(ParamIdTipoNominaProc)
        SubReportePercepciones.Parameters.Add(ParamAnio)
        SubReportePercepciones.Parameters.Add(ParamPeriodo)
        SubReportePercepciones.Parameters.Add(ParamIdEmpleado)
        SubReportePercepciones.Parameters.Add(ParamUID)
        SubReportePercepciones.Parameters.Add(ParamLID)
        SubReportePercepciones.Parameters.Add(ParamidAccion)


        'aqui se les asigna el valor
        SubReportePercepciones.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReportePercepciones.Parameters("IdTipoNominaAsig").Value = Me.Parameters("IdTipoNominaAsig").Value
        SubReportePercepciones.Parameters("IdTipoNominaProc").Value = Me.Parameters("IdTipoNominaProc").Value
        SubReportePercepciones.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReportePercepciones.Parameters("Periodo").Value = Me.Parameters("Periodo").Value
        SubReportePercepciones.Parameters("IdEmpleado").Value = ReportesProceso.IdEmpleado
        SubReportePercepciones.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReportePercepciones.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReportePercepciones.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport1.Report = SubReportePercepciones


        '*************************************************************************
        ''******* SUBREPORTE DEDUCCIONES **************/
        '                                  nombre del subreporte
        Dim SubReporteDeducciones As New Deducciones
        SubReporteDeducciones.Parameters.Clear()

        'aqui se agregan
        SubReporteDeducciones.Parameters.Add(ParamIdRazonSocial)
        SubReporteDeducciones.Parameters.Add(ParamIdTipoNominaAsig)
        SubReporteDeducciones.Parameters.Add(ParamIdTipoNominaProc)
        SubReporteDeducciones.Parameters.Add(ParamAnio)
        SubReporteDeducciones.Parameters.Add(ParamPeriodo)
        SubReporteDeducciones.Parameters.Add(ParamIdEmpleado)
        SubReporteDeducciones.Parameters.Add(ParamUID)
        SubReporteDeducciones.Parameters.Add(ParamLID)
        SubReporteDeducciones.Parameters.Add(ParamidAccion)


        'aqui se les asigna el valor
        SubReporteDeducciones.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReporteDeducciones.Parameters("IdTipoNominaAsig").Value = Me.Parameters("IdTipoNominaAsig").Value
        SubReporteDeducciones.Parameters("IdTipoNominaProc").Value = Me.Parameters("IdTipoNominaProc").Value
        SubReporteDeducciones.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReporteDeducciones.Parameters("Periodo").Value = Me.Parameters("Periodo").Value
        SubReporteDeducciones.Parameters("IdEmpleado").Value = ReportesProceso.IdEmpleado
        SubReporteDeducciones.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReporteDeducciones.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReporteDeducciones.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport2.Report = SubReporteDeducciones

    End Sub
End Class
