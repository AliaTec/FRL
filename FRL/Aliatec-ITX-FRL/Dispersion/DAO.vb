Imports Intelexion.Framework.Model
Imports System.Data
Imports Intelexion.Nomina
Imports System.Web
Imports System.Collections
Imports System.Collections.Specialized
Imports Intelexion.Framework.Controller
Imports Intelexion.Framework.View
Imports System.IO
Imports System.Data.SqlClient

Public Class DAO
    Inherits Intelexion.Framework.Model.DAO


    Private Const LayoutSolicitudSantander As String = "sp_Reporte_BajasFondoAhorro '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@AnioDesde','@PeriodoDesde','@AnioHasta','@PeriodoHasta','@UID','@LID','@idAccion'"
    Private Const polizaPor As String = "spq_Reporte_logITXFortia '@IdRazonSocial','@folioDesde','@folioHasta','@UID','@LID','@idAccion'"



    Public Sub New(ByVal DataConnection As SQLDataConnection)
        MyBase.New(DataConnection)
    End Sub
    Public Function Layout(ByVal ReportesProceso As EntitiesITX.ReportesProceso, ByVal opL As String) As DataSet
        Dim ds As New DataSet
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            Select Case opL


                Case "polizaPor"
                    comandstr = polizaPor
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds



            End Select
        Catch e As Exception
        End Try
        Return ds
    End Function

    Public Function LayoutTxt(ByVal ReportesProceso As EntitiesITX.ReportesProceso, ByVal opL As String, ByVal context As System.Web.HttpContext) As String
        Dim ds As New DataSet
        Dim sFile As String
        Dim sPathApp As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath")
        Dim sPathArchivosTemp As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ArchivosTemporales")
        'Dim ruta As String
        Try
            Select Case opL




                Case "LayoutSolicitudSantander"
                    Dim results As ResultCollection
                    Dim objLayoutDispersion As Entities.LayoutDispersion
                    Dim dTotalImporte As Decimal
                    Dim sCadena As String
                    Dim i As Integer
                    results = New ResultCollection
                    ReportesProceso.tipoArchivo = 0
                    objLayoutDispersion = New Entities.LayoutDispersion
                    objLayoutDispersion.IdRazonSocial = context.Session("IdRazonSocial")
                    objLayoutDispersion.UID = context.Session("UID")
                    objLayoutDispersion.LID = context.Session("LID")
                    objLayoutDispersion.idAccion = context.Items.Item("idAccion")
                    Dim UserId As String
                    UserId = ReportesProceso.UID.ToString
                    UserId = UserId.Replace("/", "")
                    UserId = UserId.Replace("\", "")
                    UserId = UserId.Replace("%", "")
                    UserId = UserId.Replace("_", "")
                    UserId = UserId.Replace("-", "")
                    sFile = "\SolicitudSantander" + ReportesProceso.IdRazonSocial.ToString + UserId + Date.Now.Second.ToString + ".txt"

                    results.getEntitiesFromDataReader(objLayoutDispersion, Me.ReporteSolicitudSantander(ReportesProceso))
                    dTotalImporte = 0
                    If results.Count > 0 Then
                        Dim sb As New FileStream(context.Server.MapPath(sPathApp + sPathArchivosTemp) + sFile, FileMode.Create)
                        Dim sw As New StreamWriter(sb)

                        For i = 0 To results.Count - 1
                            sCadena = results(i).centroCosto
                            sw.WriteLine(sCadena)
                        Next i

                        sw.Close()

                    End If

                    Return sPathApp + sPathArchivosTemp + sFile



            End Select
        Catch e As Exception
        End Try
        Return ""
    End Function
    Public Function ReporteSolicitudSantander(ByVal ReportesProceso As EntitiesITX.ReportesProceso) As SqlDataReader
        Dim data As SqlDataReader = Nothing
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            comandstr = LayoutSolicitudSantander
            resultado = Me.ExecuteQuery(comandstr, data, ReportesProceso)
            Return data
        Catch e As Exception
        End Try
        Return data
    End Function






End Class