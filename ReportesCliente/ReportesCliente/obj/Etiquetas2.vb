Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Intelexion.Nomina
Imports Nomina
Imports System.IO


Public Class Etiquetas2
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


    Public Sub Etiquetas2_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.ShowParameterUI = False


        Me.SetLicense("Hector Ramirez,Intelexion,DD-APN-30-C000260,S4VKSH448MS77HKH9FH9")

        Dim Path As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath")
        Dim picRazonSocial As String = "/logos/Logoempresa" + Me.Parameters("IdRazonSocial").Value + ".jpg"
        Dim archivo As New FileInfo(System.Web.HttpContext.Current.Server.MapPath(Path) + picRazonSocial)


        Picture1.Image = Image.FromFile(archivo.FullName)
        Picture1.Visible = True

        Me.DataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource("Provider=SQLOLEDB.1;" & _
                sConnection, "spq_Reporte_Etiquetas2 @IdRazonSocial = " + Me.Parameters("IdRazonSocial").Value + "," & _
                "@IdTipoNominaAsig = " + Me.Parameters("IdTipoNominaAsig").Value + "," & _
                "@folioDesde = " + Me.Parameters("folioDesde").Value + "," & _
                "@folioHasta = " + Me.Parameters("folioHasta").Value + "," & _
                "@IdElementoUsuario = " + "'" + Me.Parameters("IdElementoUsuario").Value + "'" + "," & _
                "@UID = " + Me.Parameters("UID").Value + "," & _
                "@LID = " + Me.Parameters("LID").Value + "," & _
                "@idAccion = " + Me.Parameters("idAccion").Value + "", 90)


        'AQUI

        Dim ParamIdRazonSocial As New Parameter
        ParamIdRazonSocial.Key = "IdRazonSocial"

        Dim ParamIdTipoNominaAsig As New Parameter
        ParamIdTipoNominaAsig.Key = "IdTipoNominaAsig"
        ParamIdTipoNominaAsig.Type = Parameter.DataType.String

        Dim ParamFolioDesde As New Parameter
        ParamFolioDesde.Key = "folioDesde"

        Dim ParamFolioHasta As New Parameter
        ParamFolioHasta.Key = "folioHasta"

        Dim ParamIdElementoUsuario As New Parameter
        ParamIdElementoUsuario.Key = "IdElementoUsuario"
        ParamIdElementoUsuario.Type = Parameter.DataType.String

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
        Dim SubReporteEtiquetas2 As New SubEtiquetas2
        SubReporteEtiquetas2.Parameters.Clear()

        'aqui se agregan
        SubReporteEtiquetas2.Parameters.Add(ParamIdRazonSocial)
        SubReporteEtiquetas2.Parameters.Add(ParamIdElementoUsuario)
        SubReporteEtiquetas2.Parameters.Add(ParamUID)
        SubReporteEtiquetas2.Parameters.Add(ParamLID)
        SubReporteEtiquetas2.Parameters.Add(ParamidAccion)


        'aqui se les asigna el valor
        SubReporteEtiquetas2.Parameters("IdRazonSocial").Value = Me.Parameters("IdRazonSocial").Value
        SubReporteEtiquetas2.Parameters("IdElementoUsuario").Value = Me.Parameters("IdElementoUsuario").Value
        SubReporteEtiquetas2.Parameters("UID").Value = Me.Parameters("UID").Value
        SubReporteEtiquetas2.Parameters("LID").Value = Me.Parameters("LID").Value
        SubReporteEtiquetas2.Parameters("idAccion").Value = Me.Parameters("idAccion").Value
        Me.SubReport1.Report = SubReporteEtiquetas2

    End Sub
End Class

