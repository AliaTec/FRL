Imports Intelexion.Nomina
Imports Intelexion.Framework.Controller
Imports Intelexion.Framework
Imports System.Collections.Specialized


Public Class BPBBReciboNomina
    Implements IBPBBRecibo

    Private ForwardMap As New NameValueCollection()

    Public Function ReciboNomina(ByVal recibo As String) As Intelexion.Framework.Controller.Forward Implements Intelexion.Nomina.IBPBBRecibo.ReciboNomina
        Dim fwd As New Forward()

        'fwd.Redirect = False
        'fwd.URL = 
        'ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath") & ForwardMap.Get(recibo)

        Return fwd
    End Function

    Public Function ReciboNominaHistorico(ByVal recibo As String) As Intelexion.Framework.Controller.Forward Implements Intelexion.Nomina.IBPBBRecibo.ReciboNominaHistorico
        Dim fwd As New Forward()

        fwd.Redirect = False
        fwd.URL = ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath") & ForwardMap.Get(recibo)

        Return fwd
    End Function
End Class
