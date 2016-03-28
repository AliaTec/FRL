Imports DataDynamics.ActiveReports
Imports Nomina
Imports System.IO
Imports System.Web
Imports System
Imports Intelexion.Framework.Model
Imports Intelexion.Nomina
Imports Intelexion.Framework.View
Imports Intelexion.Framework

Public Class PercepcionesProvisionesCentroCostos
    Inherits DataDynamics.ActiveReports.ActiveReport3

    Public Sub New()

        'This call is required by the ActiveReports Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub


    Private Sub PercepcionesProvisionesCentroCostos_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

        Me.ShowParameterUI = False
        Me.SetLicense("Hector Ramirez,Intelexion,DD-APN-30-C000260,S4VKSH448MS77HKH9FH9")
        Dim sConnection As String = Intelexion.Framework.Model.SQLConnectionProvider.getConnection("default").getConnection.ConnectionString

        Me.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" & _
        sConnection, "sp_reporteProvisionesCentroCostos @IdRazonSocial = " + Me.Parameters("IdRazonSocial").Value + "," & _
        "@IdTipoNominaAsig = " + Me.Parameters("IdTipoNominaAsig").Value + "," & _
        "@IdTipoNominaProc = " + Me.Parameters("IdTipoNominaProc").Value + "," & _
        "@Anio = " + Me.Parameters("Anio").Value + "," & _
        "@Periodo = " + Me.Parameters("Periodo").Value + "," & _
        "@IdElementoUsuario = " + Me.Parameters("IdElementoUsuario").Value + "," & _
        "@UID = " + Me.Parameters("UID").Value + "," & _
        "@LID = " + Me.Parameters("LID").Value + "," & _
        "@idAccion = " + Me.Parameters("idAccion").Value + "", 90)

    End Sub
End Class
