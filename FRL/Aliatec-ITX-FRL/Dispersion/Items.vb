Imports System.Data

Public Class Items
    Inherits DataTable

    Public Sub New()
        Me.Columns.Add("Label")
        Me.Columns.Add("Accion")
        Me.Columns.Add("Case")

        Dim newRow As DataRow


        newRow = Me.NewRow()
        newRow.Item("Label") = 100015
        'accion
        newRow.Item("Accion") = 100015
        'case del aspx
        newRow.Item("Case") = 100015
        Me.Rows.Add(newRow)

     

        newRow = Me.NewRow()
        newRow.Item("Label") = 100017
        'accion
        newRow.Item("Accion") = 100017
        'case del aspx
        newRow.Item("Case") = 100017
        Me.Rows.Add(newRow)

     
    
    End Sub
End Class