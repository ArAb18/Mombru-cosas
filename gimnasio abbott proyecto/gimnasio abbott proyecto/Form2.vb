Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Ingreso exitoso")
        Me.Hide()
        Form3.Show()

    End Sub
End Class