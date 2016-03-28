<%@ Register TagPrefix="cc1" Namespace="Intelexion.Framework.View.UI.Controles" Assembly="Intelexion.Framework.View.UI.Controles" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ReporteConcentradoAnualAR_Visor.aspx.vb" Inherits="Nomina.ReporteConcentradoAnualAR_Visor" %>
<%@ Register TagPrefix="activereportsweb" Namespace="DataDynamics.ActiveReports.Web" Assembly="ActiveReports.Web, Version=5.2.1013.1, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script type="text/javascript" src='<%=Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("PathJS")+"/Nomina/EmbedArv.js"%>'></script>
	</HEAD>
	<body>
		<form id="Form1" name="Form1" method="post" runat="server">
    	    <asp:Label runat="server" ID="LigaExcel"></asp:Label>
			<activereportsweb:WebViewer id="WebViewer1" runat="server" height="696" width="1120" ViewerType="AcrobatReader"></activereportsweb:WebViewer>
			<script type="text/javascript">
				//EmbedARV();			
			</script>
		</form>
	</body>
</HTML>
