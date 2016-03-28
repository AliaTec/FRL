Imports System.Data

Public Class Items
    Inherits DataTable

    Public Sub New()
        Me.Columns.Add("Label")
        Me.Columns.Add("Accion")
        Me.Columns.Add("Case")

        Dim newRow As DataRow

        newRow = Me.NewRow()
        newRow.Item("Label") = 100001
        newRow.Item("Accion") = 100001
        newRow.Item("Case") = 100001
        Me.Rows.Add(newRow)



        newRow = Me.NewRow()
        newRow.Item("Label") = 100002
        newRow.Item("Accion") = 100002
        newRow.Item("Case") = 100002
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100004
        newRow.Item("Accion") = 100004
        newRow.Item("Case") = 100004
        Me.Rows.Add(newRow)
    End Sub
End Class
