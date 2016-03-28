Imports DataDynamics.ActiveReports
Imports Nomina
Imports System.IO
Imports System.Web
Imports System
Imports Intelexion.Framework.Model
Imports Intelexion.Nomina
Imports Intelexion.Framework.View
Imports Intelexion.Framework
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DataDynamics.ActiveReports.Document

Public Class ReciboNomina
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Dim sConnection As String = Intelexion.Framework.Model.SQLConnectionProvider.getConnection("default").getConnection.ConnectionString

    Public Sub New()

        'This call is required by the ActiveReports Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub ReciboNomina8_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.ShowParameterUI = False
        Me.SetLicense("Hector Ramirez,Intelexion,DD-APN-30-C000260,S4VKSH448MS77HKH9FH9")


        Picture3.Image = System.Drawing.Image.FromFile(Me.Parameters("logo").Value)
        Picture1.Image = System.Drawing.Image.FromFile(Me.Parameters("logo").Value)

        Me.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" & _
        sConnection, "sp_Reporte_ReciboNomina16 @IdRazonSocial = " + Me.Parameters("IdRazonSocial").Value + "," & _
        "@IdTipoNominaAsig = " + Me.Parameters("IdTipoNominaAsig").Value + "," & _
        "@IdTipoNominaProc = " + Me.Parameters("IdTipoNominaProc").Value + "," & _
        "@Anio = " + Me.Parameters("Anio").Value + "," & _
        "@Periodo = " + Me.Parameters("Periodo").Value + "," & _
        "@IdEmpleado = " + Me.Parameters("IdEmpleado").Value + "," & _
        "@UID = " + Me.Parameters("UID").Value + "," & _
        "@LID = " + Me.Parameters("LID").Value + "," & _
        "@idAccion = " + Me.Parameters("idAccion").Value + "", 90)

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

        Dim ParamTipo As New Parameter
        ParamTipo.Key = "Tipo"
        ParamTipo.Type = Parameter.DataType.String

        Dim ParamUID As New Parameter
        ParamUID.Key = "UID"
        ParamUID.Type = Parameter.DataType.String

        Dim ParamLID As New Parameter
        ParamLID.Key = "LID"
        ParamLID.Type = Parameter.DataType.String

        Dim ParamidAccion As New Parameter
        ParamidAccion.Key = "idAccion"

        ''******* SUBREPORTE PERCEPCIONES **************/
        Dim SubReportePercepciones As New ReciboNomina16Percepcion
        SubReportePercepciones.Parameters.Clear()

        SubReportePercepciones.Parameters.Add(ParamIdRazonSocial)
        SubReportePercepciones.Parameters.Add(ParamIdTipoNominaAsig)
        SubReportePercepciones.Parameters.Add(ParamIdTipoNominaProc)
        SubReportePercepciones.Parameters.Add(ParamAnio)
        SubReportePercepciones.Parameters.Add(ParamPeriodo)
        SubReportePercepciones.Parameters.Add(ParamIdEmpleado)
        SubReportePercepciones.Parameters.Add(ParamTipo)
        SubReportePercepciones.Parameters.Add(ParamUID)
        SubReportePercepciones.Parameters.Add(ParamLID)
        SubReportePercepciones.Parameters.Add(ParamidAccion)

        SubReportePercepciones.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReportePercepciones.Parameters("IdTipoNominaAsig").Value = Me.Parameters("IdTipoNominaAsig").Value
        SubReportePercepciones.Parameters("IdTipoNominaProc").Value = Me.Parameters("IdTipoNominaProc").Value
        SubReportePercepciones.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReportePercepciones.Parameters("Periodo").Value = Me.Parameters("Periodo").Value
        SubReportePercepciones.Parameters("IdEmpleado").Value = "'" + TextBox1.Text + "'"
        SubReportePercepciones.Parameters("Tipo").Value = 0
        SubReportePercepciones.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReportePercepciones.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReportePercepciones.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport1.Report = SubReportePercepciones

        '******* SUBREPORTE PERCEPCIONES COPIA **************/
        Dim SubReportePercepcionesCopia As New ReciboNomina16Percepcion
        SubReportePercepcionesCopia.Parameters.Clear()

        SubReportePercepcionesCopia.Parameters.Add(ParamIdRazonSocial)
        SubReportePercepcionesCopia.Parameters.Add(ParamIdTipoNominaAsig)
        SubReportePercepcionesCopia.Parameters.Add(ParamIdTipoNominaProc)
        SubReportePercepcionesCopia.Parameters.Add(ParamAnio)
        SubReportePercepcionesCopia.Parameters.Add(ParamPeriodo)
        SubReportePercepcionesCopia.Parameters.Add(ParamIdEmpleado)
        SubReportePercepcionesCopia.Parameters.Add(ParamTipo)
        SubReportePercepcionesCopia.Parameters.Add(ParamUID)
        SubReportePercepcionesCopia.Parameters.Add(ParamLID)
        SubReportePercepcionesCopia.Parameters.Add(ParamidAccion)

        SubReportePercepcionesCopia.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReportePercepcionesCopia.Parameters("IdTipoNominaAsig").Value = Me.Parameters("IdTipoNominaAsig").Value
        SubReportePercepcionesCopia.Parameters("IdTipoNominaProc").Value = Me.Parameters("IdTipoNominaProc").Value
        SubReportePercepcionesCopia.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReportePercepcionesCopia.Parameters("Periodo").Value = Me.Parameters("Periodo").Value
        SubReportePercepcionesCopia.Parameters("IdEmpleado").Value = "'" + TextBox1.Text + "'"
        SubReportePercepcionesCopia.Parameters("Tipo").Value = 0
        SubReportePercepcionesCopia.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReportePercepcionesCopia.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReportePercepcionesCopia.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport3.Report = SubReportePercepcionesCopia

        '******* SUBREPORTE DEDUCCIONES **************/
        Dim SubReporteDeducciones As New ReciboNomina16Deduccion
        SubReporteDeducciones.Parameters.Clear()

        SubReporteDeducciones.Parameters.Add(ParamIdRazonSocial)
        SubReporteDeducciones.Parameters.Add(ParamIdTipoNominaAsig)
        SubReporteDeducciones.Parameters.Add(ParamIdTipoNominaProc)
        SubReporteDeducciones.Parameters.Add(ParamAnio)
        SubReporteDeducciones.Parameters.Add(ParamPeriodo)
        SubReporteDeducciones.Parameters.Add(ParamIdEmpleado)
        SubReporteDeducciones.Parameters.Add(ParamTipo)
        SubReporteDeducciones.Parameters.Add(ParamUID)
        SubReporteDeducciones.Parameters.Add(ParamLID)
        SubReporteDeducciones.Parameters.Add(ParamidAccion)

        SubReporteDeducciones.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReporteDeducciones.Parameters("IdTipoNominaAsig").Value = Me.Parameters("IdTipoNominaAsig").Value
        SubReporteDeducciones.Parameters("IdTipoNominaProc").Value = Me.Parameters("IdTipoNominaProc").Value
        SubReporteDeducciones.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReporteDeducciones.Parameters("Periodo").Value = Me.Parameters("Periodo").Value
        SubReporteDeducciones.Parameters("IdEmpleado").Value = "'" + TextBox1.Text + "'"
        SubReporteDeducciones.Parameters("Tipo").Value = 1
        SubReporteDeducciones.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReporteDeducciones.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReporteDeducciones.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport4.Report = SubReporteDeducciones

        '******* SUBREPORTE DEDUCCIONES COPIA**************/
        Dim SubReporteDeduccionesCopia As New ReciboNomina16Deduccion
        SubReporteDeduccionesCopia.Parameters.Clear()

        SubReporteDeduccionesCopia.Parameters.Add(ParamIdRazonSocial)
        SubReporteDeduccionesCopia.Parameters.Add(ParamIdTipoNominaAsig)
        SubReporteDeduccionesCopia.Parameters.Add(ParamIdTipoNominaProc)
        SubReporteDeduccionesCopia.Parameters.Add(ParamAnio)
        SubReporteDeduccionesCopia.Parameters.Add(ParamPeriodo)
        SubReporteDeduccionesCopia.Parameters.Add(ParamIdEmpleado)
        SubReporteDeduccionesCopia.Parameters.Add(ParamTipo)
        SubReporteDeduccionesCopia.Parameters.Add(ParamUID)
        SubReporteDeduccionesCopia.Parameters.Add(ParamLID)
        SubReporteDeduccionesCopia.Parameters.Add(ParamidAccion)

        SubReporteDeduccionesCopia.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReporteDeduccionesCopia.Parameters("IdTipoNominaAsig").Value = Me.Parameters("IdTipoNominaAsig").Value
        SubReporteDeduccionesCopia.Parameters("IdTipoNominaProc").Value = Me.Parameters("IdTipoNominaProc").Value
        SubReporteDeduccionesCopia.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReporteDeduccionesCopia.Parameters("Periodo").Value = Me.Parameters("Periodo").Value
        SubReporteDeduccionesCopia.Parameters("IdEmpleado").Value = "'" + TextBox1.Text + "'"
        SubReporteDeduccionesCopia.Parameters("Tipo").Value = 1
        SubReporteDeduccionesCopia.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReporteDeduccionesCopia.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReporteDeduccionesCopia.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport5.Report = SubReporteDeduccionesCopia

        '******* SUBREPORTE SALDOS **************/
        Dim SubReporteSaldos As New ReciboNominaSaldos21
        SubReporteSaldos.Parameters.Clear()

        SubReporteSaldos.Parameters.Add(ParamIdRazonSocial)
        SubReporteSaldos.Parameters.Add(ParamIdTipoNominaAsig)
        SubReporteSaldos.Parameters.Add(ParamIdTipoNominaProc)
        SubReporteSaldos.Parameters.Add(ParamAnio)
        SubReporteSaldos.Parameters.Add(ParamPeriodo)
        SubReporteSaldos.Parameters.Add(ParamIdEmpleado)
        SubReporteSaldos.Parameters.Add(ParamUID)
        SubReporteSaldos.Parameters.Add(ParamLID)
        SubReporteSaldos.Parameters.Add(ParamidAccion)

        SubReporteSaldos.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReporteSaldos.Parameters("IdTipoNominaAsig").Value = Me.Parameters("IdTipoNominaAsig").Value
        SubReporteSaldos.Parameters("IdTipoNominaProc").Value = Me.Parameters("IdTipoNominaProc").Value
        SubReporteSaldos.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReporteSaldos.Parameters("Periodo").Value = Me.Parameters("Periodo").Value
        SubReporteSaldos.Parameters("IdEmpleado").Value = "'" + TextBox1.Text + "'"
        SubReporteSaldos.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReporteSaldos.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReporteSaldos.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport6.Report = SubReporteSaldos

        ''******* SUBREPORTE SALDOS COPIA **************/
        Dim SubReporteSaldosCopia As New ReciboNominaSaldos21
        SubReporteSaldosCopia.Parameters.Clear()

        SubReporteSaldosCopia.Parameters.Add(ParamIdRazonSocial)
        SubReporteSaldosCopia.Parameters.Add(ParamIdTipoNominaAsig)
        SubReporteSaldosCopia.Parameters.Add(ParamIdTipoNominaProc)
        SubReporteSaldosCopia.Parameters.Add(ParamAnio)
        SubReporteSaldosCopia.Parameters.Add(ParamPeriodo)
        SubReporteSaldosCopia.Parameters.Add(ParamIdEmpleado)
        SubReporteSaldosCopia.Parameters.Add(ParamUID)
        SubReporteSaldosCopia.Parameters.Add(ParamLID)
        SubReporteSaldosCopia.Parameters.Add(ParamidAccion)

        SubReporteSaldosCopia.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReporteSaldosCopia.Parameters("IdTipoNominaAsig").Value = Me.Parameters("IdTipoNominaAsig").Value
        SubReporteSaldosCopia.Parameters("IdTipoNominaProc").Value = Me.Parameters("IdTipoNominaProc").Value
        SubReporteSaldosCopia.Parameters("Anio").Value = Me.Parameters("Anio").Value
        SubReporteSaldosCopia.Parameters("Periodo").Value = Me.Parameters("Periodo").Value
        SubReporteSaldosCopia.Parameters("IdEmpleado").Value = "'" + TextBox1.Text + "'"
        SubReporteSaldosCopia.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReporteSaldosCopia.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReporteSaldosCopia.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport2.Report = SubReporteSaldosCopia
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format

    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format

    End Sub
End Class
