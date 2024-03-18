<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMIDynamic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridViewStudents = New System.Windows.Forms.DataGridView()
        Me.LabelAverageBMI = New System.Windows.Forms.Label()
        Me.ButtonAddStudent = New System.Windows.Forms.Button()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxBMI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStudents
        '
        Me.DataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStudents.Location = New System.Drawing.Point(12, 59)
        Me.DataGridViewStudents.Name = "DataGridViewStudents"
        Me.DataGridViewStudents.Size = New System.Drawing.Size(285, 150)
        Me.DataGridViewStudents.TabIndex = 0
        '
        'LabelAverageBMI
        '
        Me.LabelAverageBMI.AutoSize = True
        Me.LabelAverageBMI.Location = New System.Drawing.Point(12, 234)
        Me.LabelAverageBMI.Name = "LabelAverageBMI"
        Me.LabelAverageBMI.Size = New System.Drawing.Size(102, 13)
        Me.LabelAverageBMI.TabIndex = 1
        Me.LabelAverageBMI.Text = "Average BMI Result"
        '
        'ButtonAddStudent
        '
        Me.ButtonAddStudent.Location = New System.Drawing.Point(12, 250)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddStudent.TabIndex = 2
        Me.ButtonAddStudent.Text = "Add Data"
        Me.ButtonAddStudent.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(197, 7)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxName.TabIndex = 3
        '
        'TextBoxBMI
        '
        Me.TextBoxBMI.Location = New System.Drawing.Point(197, 33)
        Me.TextBoxBMI.Name = "TextBoxBMI"
        Me.TextBoxBMI.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBMI.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BMI Reading"
        '
        'frmBMIDynamic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 279)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxBMI)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ButtonAddStudent)
        Me.Controls.Add(Me.LabelAverageBMI)
        Me.Controls.Add(Me.DataGridViewStudents)
        Me.Name = "frmBMIDynamic"
        Me.Text = "frmBMIDynamic"
        CType(Me.DataGridViewStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewStudents As DataGridView
    Friend WithEvents LabelAverageBMI As Label
    Friend WithEvents ButtonAddStudent As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxBMI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
