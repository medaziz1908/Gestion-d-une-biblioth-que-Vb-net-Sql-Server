Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplirDGV(DataGridView1, "kteb")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        chercherLiv(DataGridView1, TextBox1.Text)
    End Sub
End Class
