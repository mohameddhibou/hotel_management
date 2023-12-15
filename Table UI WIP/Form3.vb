Imports System.Data.SqlClient

Public Class chercher_hot

    ''ON LOAD: REMPLISSAGE DATAGRID
    Private Sub chercher_hot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
        connection.Open()
        Dim Command As New SqlCommand("SELECT h.cod_hot,h.lib,p.lib,h.tél
        FROM Hotels h,Provinces p
        WHERE h.cod_prov = p.cod_prov 
        ORDER BY h.cod_hot", connection)
        Dim r As SqlDataReader = Command.ExecuteReader
        While r.Read
            GunaDataGridView1.Rows.Add(r(0), r(1), r(2), r(3))
        End While
        r.Close()

        GunaDataGridView1.ClearSelection()
    End Sub

    ''BOUTON RECHERCHER
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click


        Dim connection As New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
        connection.Open()
        Dim Command As New SqlCommand("SELECT h.cod_hot,h.lib,p.lib,h.tél
        FROM Hotels h,Provinces p
        WHERE h.cod_prov = p.cod_prov 
        AND lower(h.lib) ='" & GunaTextBox1.Text & "'
        ORDER BY h.cod_hot", connection)
        Dim r As SqlDataReader = Command.ExecuteReader

        Dim flag As Boolean = False

        GunaDataGridView1.Rows.Clear()
        While r.Read
            flag = True
            GunaDataGridView1.Rows.Add(r(0), r(1), r(2), r(3))
            GunaDataGridView1.ClearSelection()
        End While

        If Not flag Then
            Dim f As success = New success
            f.setAlert("Info: Hôtel introuvable!", success.alertTypeEnum.Info)
        End If
        r.Close()
        connection.Close()
    End Sub

    ''POUR VIDER LE TEXTBOX
    Private Sub GunaTextBox1_Click(sender As Object, e As EventArgs) Handles GunaTextBox1.Click
        GunaTextBox1.Text = ""
    End Sub

    ''BOUTON AJOUTER HOTEL
    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim var As ajout_hot = New ajout_hot
        var.Show()
    End Sub

    ''ACTUALISATION DU DATAGRID
    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        Dim connection3 As New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
        connection3.Open()
        Dim Command3 As New SqlCommand("SELECT h.cod_hot,h.lib,p.lib,h.tél
        FROM Hotels h,Provinces p
        WHERE h.cod_prov = p.cod_prov 
        ORDER BY h.cod_hot", connection3)
        Dim r3 As SqlDataReader = Command3.ExecuteReader
        GunaDataGridView1.Rows.Clear()
        While r3.Read
            GunaDataGridView1.Rows.Add(r3(0), r3(1), r3(2), r3(3))
        End While
        r3.Close()
        GunaDataGridView1.ClearSelection()
    End Sub
End Class