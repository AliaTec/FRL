Imports System.Data
Imports System.Web
Imports System.IO
Imports System.Data.OleDb
Imports Intelexion.Framework.Model

Namespace ImportExport

    Public Class Archivos

        Private Const nombre As String = "sp_Reporte_LayoutDispersionBANCOMER '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@folioDesde','@folioHasta','@UID','@LID','@idAccion'"

        Protected NombreArchivo As String

        Public Sub New()
            MyBase.New()
        End Sub


        Public Function DescargarArchivo(ByVal context As HttpContext, ByVal PathDir As String, ByVal Nombre As String, ByVal NombreAlternativo As Boolean) As String

            Dim Tamaño As Integer
            Dim nomAux As String


            Try
                Dim Archivo As HttpPostedFile = context.Request.Files("Archivo")
                Dim Dir As New DirectoryInfo(PathDir)

                If Not Archivo Is Nothing Then

                    Tamaño = Archivo.ContentLength

                    Nombre = Archivo.FileName.Substring(Archivo.FileName.LastIndexOf("\") + 1)
                    Dim Arch As FileInfo
                    Dim i As Integer = 0

                    Arch = New FileInfo(Dir.ToString + "\" + Nombre)

                    Try
                        If Arch.Exists Then
                            Arch.Delete()
                        End If
                    Catch Exep As Exception
                    End Try
                    If Arch.Exists And NombreAlternativo = False Then
                        Return Nothing
                    End If


                    nomAux = Nombre

                    Do
                        Nombre = nomAux
                        Nombre = i.ToString + Nombre
                        i = i + 1
                        Arch = New FileInfo(Dir.ToString + "\" + Nombre)
                        nomAux = Nombre
                    Loop While Arch.Exists


                    If Archivo.FileName.EndsWith(".xls") Then

                        If Not Dir.Exists Then
                            Dir.Create()
                        End If
                        Archivo.SaveAs(Dir.ToString + "\" + Nombre)

                    Else
                        Return Nothing
                    End If

                    Return Dir.ToString + "\" + Nombre

                Else
                    Return Nothing
                End If

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function Exporta_Excel_Stream(ByVal ds As DataSet, ByVal nombre As String, ByVal Directorio As String) As Boolean

            Try
                Dim dir As New DirectoryInfo(Directorio)

                If Not dir.Exists Then
                    Return False
                End If

                Dim arch As StreamWriter = New StreamWriter(dir.ToString + "\" + nombre, False, System.Text.Encoding.Unicode)
                'Dim arch As StreamWriter = New StreamWriter("C:\" + nombre, False)
                Dim renglon As DataRow

                Dim cols As Integer = ds.Tables(0).Columns.Count
                Dim i As Integer = 0

                For i = 0 To cols - 1
                    arch.Write(ds.Tables(0).Columns(i).ColumnName)
                    arch.Write(Chr(9))
                Next
                arch.WriteLine()

                For Each renglon In ds.Tables(0).Rows

                    i = 0

                    For i = 0 To cols - 1
                        arch.Write(renglon.Item(i))
                        arch.Write(Chr(9))
                    Next

                    arch.WriteLine()
                Next

                arch.Flush()
                arch.Close()

                Return True

            Catch ex As Exception
                Return False
            End Try


        End Function

        Public Function Borrar_Archivo(ByVal nombre As String, ByVal path As String) As Boolean

            Try
                Dim dir As New DirectoryInfo(path)

                If Not dir.Exists Then
                    Return False
                End If

                Dim file As New FileInfo(path + "\" + nombre)

                If Not file.Exists Then
                    Return False
                End If


                file.Delete()

                Return True

            Catch ex As Exception
                Return False
            End Try

        End Function

    End Class

End Namespace