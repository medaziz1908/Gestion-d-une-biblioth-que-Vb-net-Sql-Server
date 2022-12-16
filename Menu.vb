Public Class Menu
    Private Sub RechercheLivreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechercheLivreToolStripMenuItem.Click
        Form1.Show()
        Form1.MdiParent = Me
    End Sub

    Private Sub AjoutLivreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutLivreToolStripMenuItem.Click
        Form2.Show()
        Form2.MdiParent = Me

    End Sub

    Private Sub ModifierLivreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierLivreToolStripMenuItem.Click
        Form3.Show()
        Form3.MdiParent = Me
    End Sub

    Private Sub SupprimerLivreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerLivreToolStripMenuItem.Click
        Form4.Show()
        Form4.MdiParent = Me
    End Sub
End Class