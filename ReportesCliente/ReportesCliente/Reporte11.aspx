<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Reporte11.aspx.vb" Inherits="ReportesCliente.Reporte11" %>
<%@ Register TagPrefix="activereportsweb1" Namespace="DataDynamics.ActiveReports.Web" Assembly="ActiveReports.Web, Version=5.2.1013.1, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Reporte11</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" name="Form1" method="post" runat="server">
		<asp:Label ID="ligaExcel" runat="server" name="ExportarExcel"></asp:Label>
			    <ActiveReportsWeb1:WebViewer id="WebViewer11" runat="server" height="696" width="1120" ViewerType="AcrobatReader"></ActiveReportsWeb1:WebViewer>
		</form>
	</body>
</HTML>



