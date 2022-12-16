Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cat As String
        cat = ""
        If RadioButton1.Checked Then
            cat = "ROMAIN"
        End If
        If RadioButton3.Checked Then
            cat = "POLICIER"
        End If
        If RadioButton2.Checked Then
            cat = "SCENTIFQUE"
        End If
        Call connecter()
        cmd.CommandText = "INSERT INTO kteb ([titre],
          [auteur],
          [annee_parution],
          [nb_page],
          [categorie]) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & datee.Value & "'," & TextBox3.Text & ",'" & cat & "')"
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        Call deconnecter()
        viderformulaire(Me)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class