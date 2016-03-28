Imports DataDynamics.ActiveReports
Imports System.IO
Imports System.Web.HttpContext

Public Class LogoReciboNomina
    Inherits Parameter

    Dim Paramlogo As New Parameter

    Public Sub New(ByVal idRazonSocial As String)
        Dim Path As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath")
        Dim picRazonSocial As String = "/logos/logoEmpresa" + idRazonSocial + ".jpg"
        Dim archivo As New FileInfo(System.Web.HttpContext.Current.Server.MapPath(Path) + picRazonSocial)

        Me.Key = "logo"
        Me.DefaultValue = archivo.FullName
    End Sub
End Class
