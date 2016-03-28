Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Intelexion.Nomina
Imports Nomina

Public Class ExentosGravadosMensual
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Dim sConnection As String = Intelexion.Framework.Model.SQLConnectionProvider.getConnection("default").getConnection.ConnectionString
    'Dim sConnection As String = "Data Source=DCW319V1\MSSQLSERVER8; Initial Catalog=V5McGrawHillNominaTest; User Id=ITXTV5; Password=ITXTV5; Connection Lifetime=60; Max Pool Size=50; Min Pool Size=3"
    Public Sub New()

        'This call is required by the ActiveReports Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal reporte As Entities.ReportesProceso)

        'This call is required by the ActiveReports Designer.
        InitializeComponent()

    End Sub


    Public Sub ExentosGravadosMensual_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.ShowParameterUI = False


        Me.SetLicense("Hector Ramirez,Intelexion,DD-APN-30-C000260,S4VKSH448MS77HKH9FH9")

        Me.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" & _
                sConnection, "spq_nomGraExenMensual @IdRazonSocial = " + Me.Parameters("IdRazonSocial").Value + "," & _
                "@Anio = " + Me.Parameters("Anio").Value + "," & _
                "@Mes = " + Me.Parameters("Mes").Value + "," & _
                "@UID = " + Me.Parameters("UID").Value + "," & _
                "@LID = " + Me.Parameters("LID").Value + "," & _
                "@idAccion = " + Me.Parameters("idAccion").Value + "", 90)


        'AQUI

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

        ' ''******* SUBREPORTE PERCEPCIONES **************/
        ''                                  nombre del subreporte
        Dim SubReportePercepcionesMensual As New PercepcionesMensual
        SubReportePercepcionesMensual.Parameters.Clear()

        'aqui se agregan
        SubReportePercepcionesMensual.Parameters.Add(ParamIdRazonSocial)
        SubReportePercepcionesMensual.Parameters.Add(ParamAnio)
        SubReportePercepcionesMensual.Parameters.Add(ParamMes)
        SubReportePercepcionesMensual.Parameters.Add(ParamUID)
        SubReportePercepcionesMensual.Parameters.Add(ParamLID)
        SubReportePercepcionesMensual.Parameters.Add(ParamidAccion)


        'aqui se les asigna el valor
        SubReportePercepcionesMensual.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReportePercepcionesMensual.Parameters("Mes").Value = Me.Parameters("Mes").Value
        SubReportePercepcionesMensual.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReportePercepcionesMensual.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        SubReportePercepcionesMensual.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReportePercepcionesMensual.Parameters("UID").Value = Me.Parameters("UID").Value
        Me.SubReport1.Report = SubReportePercepcionesMensual


        '*************************************************************************
        ''******* SUBREPORTE DEDUCCIONES **************/
        '                                  nombre del subreporte
        Dim SubReporteDeduccionesMensual As New DeduccionesMensual
        SubReporteDeduccionesMensual.Parameters.Clear()

        'aqui se agregan
        SubReporteDeduccionesMensual.Parameters.Add(ParamIdRazonSocial)
        SubReporteDeduccionesMensual.Parameters.Add(ParamAnio)
        SubReporteDeduccionesMensual.Parameters.Add(ParamMes)
        SubReporteDeduccionesMensual.Parameters.Add(ParamUID)
        SubReporteDeduccionesMensual.Parameters.Add(ParamLID)
        SubReporteDeduccionesMensual.Parameters.Add(ParamidAccion)


        'aqui se les asigna el valor
        SubReporteDeduccionesMensual.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReporteDeduccionesMensual.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReporteDeduccionesMensual.Parameters("Mes").Value = Me.Parameters("Mes").Value
        SubReporteDeduccionesMensual.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReporteDeduccionesMensual.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReporteDeduccionesMensual.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport2.Report = SubReporteDeduccionesMensual


        '*************************************************************************
        ''******* SUBREPORTE DEDUCCIONES **************/
        '                                  nombre del subreporte
        Dim SubReporteEmpresaMensual As New EmpresaMensual
        SubReporteEmpresaMensual.Parameters.Clear()

        'aqui se agregan
        SubReporteEmpresaMensual.Parameters.Add(ParamIdRazonSocial)
        SubReporteEmpresaMensual.Parameters.Add(ParamAnio)
        SubReporteEmpresaMensual.Parameters.Add(ParamMes)
        SubReporteEmpresaMensual.Parameters.Add(ParamUID)
        SubReporteEmpresaMensual.Parameters.Add(ParamLID)
        SubReporteEmpresaMensual.Parameters.Add(ParamidAccion)


        'aqui se les asigna el valor
        SubReporteEmpresaMensual.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReporteEmpresaMensual.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReporteEmpresaMensual.Parameters("Mes").Value = Me.Parameters("Mes").Value
        SubReporteEmpresaMensual.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReporteEmpresaMensual.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReporteEmpresaMensual.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport3.Report = SubReporteEmpresaMensual


    End Sub
End Class

