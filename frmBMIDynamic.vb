Public Class frmBMIDynamic
    Dim students As New List(Of String())
    Private Sub frmBMIDynamic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewStudents.Columns.Add("Nama Pelajar", "Name")
        DataGridViewStudents.Columns.Add("Bacaan BMI", "BMI")
    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click
        Dim name As String = TextBoxName.Text.Trim()
        Dim bmi As String = TextBoxBMI.Text.Trim()
    End Sub
End Class