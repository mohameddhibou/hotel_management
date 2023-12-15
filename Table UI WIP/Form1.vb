Imports System.Data.SqlClient

Public Class Form1

    ''BOUTON FERMER
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Application.Exit()
    End Sub

    ''ON LOAD: APPELLATION DU FORM CHERCHER_HOT
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        chercher_hot.MdiParent = Me
        chercher_hot.Dock = DockStyle.Fill
        chercher_hot.BringToFront()
        chercher_hot.Show()
    End Sub

    ''APPELLATION DU FORM CHERCHER_HOT
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        chercher_hot.MdiParent = Me
        chercher_hot.Dock = DockStyle.Fill
        chercher_hot.BringToFront()
        chercher_hot.Show()
    End Sub

    ''APPELLATION DU FORM METTRE_A_JOUR
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        mettre_a_jour.MdiParent = Me
        mettre_a_jour.Dock = DockStyle.Fill
        mettre_a_jour.BringToFront()
        mettre_a_jour.Show()
    End Sub

    ''BOUTON REDUIRE
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    ''APPELLATION DU FORM TENDANCE
    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        tendance.MdiParent = Me
        tendance.Dock = DockStyle.Fill
        tendance.BringToFront()
        tendance.Show()
    End Sub
End Class
