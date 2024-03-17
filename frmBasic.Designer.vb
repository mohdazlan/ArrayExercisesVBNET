<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBasic
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
        Me.ListBoxStudents = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxStudents
        '
        Me.ListBoxStudents.FormattingEnabled = True
        Me.ListBoxStudents.Location = New System.Drawing.Point(78, 85)
        Me.ListBoxStudents.Name = "ListBoxStudents"
        Me.ListBoxStudents.Size = New System.Drawing.Size(183, 147)
        Me.ListBoxStudents.TabIndex = 0
        '
        'frmBasic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBoxStudents)
        Me.Name = "frmBasic"
        Me.Text = "frmBasic"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxStudents As ListBox
End Class
