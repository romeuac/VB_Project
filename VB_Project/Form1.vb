Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the application'
        Me.Close()

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Mostra uma caixa de texto ao ser clicado'
        MessageBox.Show("Olá " & txtName.Text & ", welcome to this brandnew application!!", "Message to the user")
    End Sub
End Class
