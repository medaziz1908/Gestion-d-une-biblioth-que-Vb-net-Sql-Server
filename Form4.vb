Public Class Form4
    Dim num As String
    Dim titre As String
    Dim auteur As String
    Dim NbreDePage As String
    Dim cat As String
    Dim an As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As MsgBoxResult
        res = MsgBox("Voulez vous vraiment supprimer les informations sur ce livre?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then

            Call connecter()


            cmd.CommandText = "DELETE kteb where id_livre =" & num


            cmd.ExecuteNonQuery()
            Call deconnecter()
            viderformulaire(Me)
            ds.Tables("dt_kteb").Clear()
            remplirDGV(DataGridView1, "kteb")


        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplirDGV(DataGridView1, "kteb")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Récuperation des différents valeurs de la dataCrid DGV

        num = DataGridView1.CurrentRow.Cells(0).Value.ToString
        titre = DataGridView1.CurrentRow.Cells("titre").Value.ToString
        auteur = DataGridView1.CurrentRow.Cells("auteur").Value.ToString
        NbreDePage = DataGridView1.CurrentRow.Cells("nb_page").Value.ToString
        cat = DataGridView1.CurrentRow.Cells("categorie").Value.ToString
        an = DataGridView1.CurrentRow.Cells("annee_parution").Value.ToString

        Label6.Text = "LIVRE ID : " & num
        'Attribuer les différents valeurs 

        TextBox1.Text = titre
        TextBox2.Text = auteur
        TextBox3.Text = NbreDePage


        If Trim(cat).CompareTo("Roman") = 0 Then
            RadioButton1.Checked = True
        End If

        If Trim(cat).CompareTo("Policier") = 0 Then
            RadioButton3.Checked = True
        End If

        If Trim(cat).CompareTo("SCIETIFQUE") = 0 Then
            RadioButton2.Checked = True
        End If
        datee.Value = an


    End Sub

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ds.Tables("dt_kteb").Clear()
    End Sub
End Class