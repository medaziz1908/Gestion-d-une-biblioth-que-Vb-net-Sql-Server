<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LivreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercheLivreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutLivreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierLivreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerLivreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.WinFormsApp1.My.Resources.Resources.nour1
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LivreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 43)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LivreToolStripMenuItem
        '
        Me.LivreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RechercheLivreToolStripMenuItem, Me.AjoutLivreToolStripMenuItem, Me.ModifierLivreToolStripMenuItem, Me.SupprimerLivreToolStripMenuItem})
        Me.LivreToolStripMenuItem.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LivreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LivreToolStripMenuItem.Name = "LivreToolStripMenuItem"
        Me.LivreToolStripMenuItem.Size = New System.Drawing.Size(109, 39)
        Me.LivreToolStripMenuItem.Text = "Livre"
        '
        'RechercheLivreToolStripMenuItem
        '
        Me.RechercheLivreToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Emoji", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RechercheLivreToolStripMenuItem.Name = "RechercheLivreToolStripMenuItem"
        Me.RechercheLivreToolStripMenuItem.Size = New System.Drawing.Size(268, 36)
        Me.RechercheLivreToolStripMenuItem.Text = "Recherche_Livre"
        '
        'AjoutLivreToolStripMenuItem
        '
        Me.AjoutLivreToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Emoji", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AjoutLivreToolStripMenuItem.Name = "AjoutLivreToolStripMenuItem"
        Me.AjoutLivreToolStripMenuItem.Size = New System.Drawing.Size(268, 36)
        Me.AjoutLivreToolStripMenuItem.Text = "Ajout_Livre"
        '
        'ModifierLivreToolStripMenuItem
        '
        Me.ModifierLivreToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Emoji", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ModifierLivreToolStripMenuItem.Name = "ModifierLivreToolStripMenuItem"
        Me.ModifierLivreToolStripMenuItem.Size = New System.Drawing.Size(268, 36)
        Me.ModifierLivreToolStripMenuItem.Text = "Modifier_Livre"
        '
        'SupprimerLivreToolStripMenuItem
        '
        Me.SupprimerLivreToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Emoji", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SupprimerLivreToolStripMenuItem.Name = "SupprimerLivreToolStripMenuItem"
        Me.SupprimerLivreToolStripMenuItem.Size = New System.Drawing.Size(268, 36)
        Me.SupprimerLivreToolStripMenuItem.Text = "Supprimer_Livre"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LivreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechercheLivreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutLivreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierLivreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerLivreToolStripMenuItem As ToolStripMenuItem
End Class
