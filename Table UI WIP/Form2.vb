Imports System.Data.SqlClient
Imports System.Data
Public Class mettre_a_jour

    ''REMPLISSAGE DES COMBOBOX
    Private Sub mettre_a_jour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
        Dim Command1 As New SqlCommand("SELECT * FROM HOTELS", connection)
        Dim Adapter1 As New SqlDataAdapter(Command1)
        Dim table1 As New DataTable()
        Adapter1.Fill(table1)
        GunaComboBox1.DataSource = table1
        GunaComboBox1.DisplayMember = "lib"
        GunaComboBox1.ValueMember = "cod_hot"

        Dim Command2 As New SqlCommand("SELECT * FROM Catégorie", connection)
        Dim Adapter2 As New SqlDataAdapter(Command2)
        Dim table2 As New DataTable()
        Adapter2.Fill(table2)
        GunaComboBox2.DataSource = table2
        GunaComboBox2.DisplayMember = "cod_cat"
        GunaComboBox2.ValueMember = "cod_cat"

        Dim A As Integer
        For A = 2021 To 1800 Step -1
            GunaComboBox3.Items.Add(A)
            GunaComboBox3.SelectedIndex = 0
            GunaComboBox4.Items.Add(A)
            GunaComboBox4.SelectedIndex = 0
        Next
    End Sub

    ''BOUTON D'ENREGISTREMENT D'UNE MISE A JOUR
    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim con As SqlConnection = New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
        If (GunaTextBox1.Text <> Nothing And GunaTextBox2.Text <> Nothing And GunaTextBox3.Text <> Nothing) Then
            If Char.IsNumber(GunaTextBox1.Text) And Char.IsNumber(GunaTextBox2.Text) And Char.IsNumber(GunaTextBox3.Text) Then
                Dim cod_hot As String = GunaComboBox1.SelectedValue.ToString()
                Dim cod_cat As String = GunaComboBox2.SelectedValue.ToString()
                Dim nb_ch As Integer = Integer.Parse(GunaTextBox1.Text)
                Dim nb_lits As Integer = Integer.Parse(GunaTextBox2.Text)
                Dim nb_emploi As Integer = Integer.Parse(GunaTextBox3.Text)
                If (Integer.Parse(GunaComboBox3.SelectedItem) < Integer.Parse(GunaComboBox4.SelectedItem)) Then

                    Dim command3 As SqlCommand = New SqlCommand("SELECT * FROM hot_cat1 WHERE 
                anclas1 =" & Integer.Parse(GunaComboBox3.SelectedItem) &
                    " AND anclas2 =" & Integer.Parse(GunaComboBox4.SelectedItem) &
                    " AND cod_hot ='" & GunaComboBox1.SelectedValue.ToString() & "'", con)
                    con.Open()
                    Dim lecteur As SqlDataReader = command3.ExecuteReader
                    If lecteur.Read Then
                        Dim f As success = New success
                        f.setAlert("Erreur: Période déja saisie pour " & GunaComboBox1.SelectedValue.ToString(), success.alertTypeEnum.Error1)
                        con.Close()
                    Else
                        Dim con2 As SqlConnection = New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")

                        Dim anclas1 As Integer = Integer.Parse(GunaComboBox3.SelectedItem)
                        Dim anclas2 As Integer = Integer.Parse(GunaComboBox4.SelectedItem)
                        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO hot_cat1
     VALUES
           ('" & cod_hot & "'
           ,'inutile'
           ,'" & cod_cat & "'
           ," & nb_ch & "
           ," & nb_lits & "
           ," & nb_emploi & "
           ," & anclas1 & "
           ," & anclas2 & ")", con2)
                        con2.Open()
                        If (cmd.ExecuteNonQuery().Equals(1)) Then
                            Dim f As success = New success
                            f.setAlert(cod_hot + " a été mise à jour!", success.alertTypeEnum.Success)
                        End If
                        con2.Close()
                    End If
                Else
                    Dim f As success = New success
                    f.setAlert("Erreur: Année début < Année fin!", success.alertTypeEnum.Info)
                End If
            Else
                Dim f As success = New success
                f.setAlert("Les Nombres doit contenir des chiffres!", success.alertTypeEnum.Error1)
            End If
        Else
            Dim f As success = New success
            f.setAlert("Info: Veuillez remplir tout les champs!", success.alertTypeEnum.Info)
        End If
    End Sub

    ''BOUTON ANNULER (VIDER LES CHAMPS)
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        GunaComboBox1.SelectedIndex = 0
        GunaComboBox2.SelectedIndex = 0
        GunaTextBox1.Text = ""
        GunaTextBox2.Text = ""
        GunaTextBox3.Text = ""
        GunaComboBox3.SelectedIndex = 0
        GunaComboBox4.SelectedIndex = 0
    End Sub
End Class