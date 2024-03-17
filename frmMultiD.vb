Public Class frmMultiD
    Private neighbours(,) As String = {
        {"Alice", "68"}, {"Bob", "78"}, {"Ali", "48"}, {"Allen", "78"}, {"Alisse", "128"}
        }
    Private Sub frmMultiD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewJiran.ColumnCount = 2
        DataGridViewJiran.Columns(0).Name = "Nama Jiran"
        DataGridViewJiran.Columns(1).Name = "Berat Jiran"

        For row As Integer = 0 To neighbours.GetLength(0) - 1
            Dim rowData As String() = {neighbours(row, 0), neighbours(row, 1)}
            DataGridViewJiran.Rows.Add(rowData)
        Next
    End Sub
End Class