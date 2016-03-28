Imports DataDynamics.ActiveReports
Imports System.IO
Imports System.Web.HttpContext




Public Class LogoCartaFiniquito
    Inherits Parameter

    Dim Paramlogo As New Parameter

    Public Sub New(ByVal idRazonSocial As String)
        Dim Path As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath")
        Dim picRazonSocial As String = "/logos/logoEmpresa6.jpg"
        Dim archivo As New FileInfo(System.Web.HttpContext.Current.Server.MapPath(Path) + picRazonSocial)

        Paramlogo.Key = "logo"
        Paramlogo.DefaultValue = archivo.FullName
    End Sub
End Class