Public Class frmBMIDynamic
    Dim students As New List(Of String())
    Private Sub frmBMIDynamic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewStudents.Columns.Add("Nama Pelajar", "Name")
        DataGridViewStudents.Columns.Add("Bacaan BMI", "BMI")

        UpdateDataGridView()
    End Sub
    Sub UpdateDataGridView()
        DataGridViewStudents.Rows.Clear()
        For Each student In students
            DataGridViewStudents.Rows.Add(student)
        Next

        Dim totalBMI As Double
        For Each stud In students
            totalBMI += Convert.ToDouble(stud(1))
        Next
        LabelAverageBMI.Text = $"The Average BMI of students {totalBMI / students.Count}"
    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click
        Dim name As String = TextBoxName.Text.Trim()
        Dim bmi As String = TextBoxBMI.Text.Trim()

        students.Add({name, bmi})

        UpdateDataGridView()
    End Sub
End Class