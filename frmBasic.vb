Public Class frmBasic
    Public studentNames() As String = {"Alice", "Bob", "Char", "Dave", "Eve"}
    Private Sub frmBasic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBoxStudents.Items.AddRange(studentNames)
    End Sub

    Private Sub ListBoxStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxStudents.SelectedIndexChanged
        Dim pilihan As Integer = ListBoxStudents.SelectedIndex

        If pilihan >= 0 AndAlso pilihan < studentNames.Length Then
            Dim pelajarTerpilih As String = studentNames(pilihan)
            MsgBox(pelajarTerpilih)
            MessageBox.Show($"The student at index {pilihan} is {pelajarTerpilih}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class