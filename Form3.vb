Public Class Form3
    Dim num As String
    Dim titre As String
    Dim auteur As String
    Dim nb_Page As String
    Dim cat As String
    Dim an As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As MsgBoxResult
        res = MsgBox("Voulez vous vraiment modifier les informations sur ce livre?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then
            titre = TextBox1.Text
            auteur = TextBox2.Text
            an = datee.Value
            nb_Page = TextBox3.Text

            If RadioButton3.Checked Then
                cat = "POLICIER"
            End If
            If RadioButton2.Checked Then
                cat = "SCIETIFQUE"
            End If
            If RadioButton1.Checked Then
                cat = "ROMAN"
            End If
            Call connecter()
            cmd.CommandText = "UPDATE kteb set titre='" & titre & "' , auteur ='" & auteur & "', annee_parution ='" & an & "'  , nb_page =" & nb_Page & " ,categorie='" & cat & "'  WHERE id_livre=" & num
            cmd.ExecuteNonQuery()
            Call deconnecter()

            ds.Tables("dt_kteb").Clear()
            remplirDGV(DataGridView1, "kteb")
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplirDGV(DataGridView1, "kteb")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Récuperation des différentes valeurs de la dataGrid DGV
        num = DataGridView1.CurrentRow.Cells("id_livre").Value.ToString
        titre = DataGridView1.CurrentRow.Cells("titre").Value.ToString
        auteur = DataGridView1.CurrentRow.Cells("auteur").Value.ToString
        nb_Page = DataGridView1.CurrentRow.Cells("nb_page").Value.ToString
        cat = DataGridView1.CurrentRow.Cells("categorie").Value.ToString
        an = DataGridView1.CurrentRow.Cells("annee_parution").Value.ToString
        Label6.Text = "LIVRE ID:  " & num
        'Attribuer les différentes valeurs de la dataGrid DGV aux zone
        TextBox1.Text = titre
        TextBox2.Text = auteur
        TextBox3.Text = nb_Page
        datee.Value = an
        If Trim(cat).CompareTo("ROMAN") = 0 Then
            RadioButton1.Checked = True
        End If
        If Trim(cat).CompareTo("POLICIER") = 0 Then
            RadioButton3.Checked = True
        End If
        If Trim(cat).CompareTo("SCIETIFQUE") = 0 Then
            RadioButton2.Checked = True
        End If
    End Sub
    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ds.Tables("dt_kteb").Clear()
    End Sub

End Class
