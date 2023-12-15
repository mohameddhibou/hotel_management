Imports System.Data.SqlClient

Public Class ajout_hot

    ''L'EVENEMENT DUCHARGEMENT DE L'INTERFACE (REMPLISSAGE DU DES COMBOBOX + INCREMENTATION DU CODE)
    Private Sub ajout_hot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
        Dim Command1 As New SqlCommand("SELECT * FROM Provinces", connection)
        Dim Adapter1 As New SqlDataAdapter(Command1)
        Dim table1 As New DataTable()
        Adapter1.Fill(table1)
        GunaComboBox2.DataSource = table1
        GunaComboBox2.DisplayMember = "lib"
        GunaComboBox2.ValueMember = "cod_prov"

        Dim A0 As Integer
        For A0 = 1 To 12 Step 1
            GunaComboBox1.Items.Add(A0)
            GunaComboBox1.SelectedIndex = 0
        Next

        Dim A As Integer
        For A = 2021 To 1800 Step -1
            GunaComboBox3.Items.Add(A)
            GunaComboBox3.SelectedIndex = 0
            GunaComboBox5.Items.Add(A)
            GunaComboBox5.SelectedIndex = 0
            GunaComboBox6.Items.Add(A)
            GunaComboBox6.SelectedIndex = 0
        Next

        Dim Command2 As New SqlCommand("SELECT * FROM Catégorie", connection)
        Dim Adapter2 As New SqlDataAdapter(Command2)
        Dim table2 As New DataTable()
        Adapter2.Fill(table2)
        GunaComboBox4.DataSource = table2
        GunaComboBox4.DisplayMember = "cod_cat"
        GunaComboBox4.ValueMember = "cod_cat"

        connection.Open()
        Dim cmd0 As SqlCommand = New SqlCommand("SELECT max(cod_hot)+1 from hotels", connection)
        Dim r As SqlDataReader = cmd0.ExecuteReader
        If r.Read Then
            GunaTextBox1.Enabled = False
            GunaTextBox1.Text = r(0)
        End If
    End Sub

    ''BOUTON REDUIRE
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    ''BOUTON FERMER (POUR FERMER L INTERFACE DE L'AJOUT)
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Me.Close()
    End Sub

    ''BOUTON AJOUTER HÔTEL
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim con2 As SqlConnection = New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
        If (GunaTextBox1.Text <> Nothing And GunaTextBox2.Text <> Nothing And GunaTextBox3.Text <> Nothing And GunaTextBox4.Text <> Nothing And GunaTextBox5.Text <> Nothing And GunaTextBox7.Text <> Nothing And GunaComboBox3.SelectedIndex <> -1 And GunaTextBox6.Text <> Nothing And GunaComboBox1.SelectedIndex <> -1 And GunaTextBox8.Text <> Nothing And GunaTextBox9.Text <> Nothing And GunaTextBox10.Text <> Nothing And GunaTextBox11.Text <> Nothing) Then
            If GunaTextBox3.TextLength > 4 And GunaTextBox4.TextLength > 4 And GunaTextBox8.Text.IndexOf("@") <> -1 And GunaTextBox8.Text.IndexOf(".") <> -1 Then
                If Char.IsNumber(GunaTextBox5.Text) And Char.IsNumber(GunaTextBox6.Text) And Char.IsNumber(GunaTextBox7.Text) And Char.IsNumber(GunaTextBox11.Text) Then
                    If (Integer.Parse(GunaComboBox5.SelectedItem) < Integer.Parse(GunaComboBox6.SelectedItem)) Then
                        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO hotels
                VALUES
                ('" & GunaTextBox1.Text & "',
                 '" & GunaTextBox2.Text & "',
                 '" & GunaComboBox2.SelectedValue & "',
                 '" & GunaTextBox3.Text & "',
                 '" & GunaTextBox4.Text & "',
                 '" & GunaComboBox3.SelectedItem & "',
                 '" & GunaTextBox6.Text & "',
                 " & GunaComboBox1.SelectedItem & ",
                 '" & GunaTextBox8.Text & "',
                 '" & GunaTextBox9.Text & "',
                 '" & GunaTextBox10.Text & "')", con2)

                        Dim con3 As SqlConnection = New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
                        Dim cmd2 As SqlCommand = New SqlCommand("INSERT INTO hot_cat1
                VALUES
                ('" & GunaTextBox1.Text & "',
                 'inutile',
                 '" & GunaComboBox4.SelectedValue & "',
                 " & GunaTextBox5.Text & ",
                 " & GunaTextBox7.Text & ",
                 " & GunaTextBox11.Text & ",
                 " & GunaComboBox5.SelectedItem & ",
                 " & GunaComboBox6.SelectedItem & ")", con3)
                        con2.Open()
                        con3.Open()

                        If (cmd.ExecuteNonQuery().Equals(1) And cmd2.ExecuteNonQuery().Equals(1)) Then
                            Dim f As success = New success
                            f.setAlert("Hôtel: " + GunaTextBox1.Text + " a été ajouté avec succés!", success.alertTypeEnum.Success)
                            Me.Close()
                        End If
                        con2.Close()
                        con3.Close()
                    Else
                        Dim f As success = New success
                        f.setAlert("Date D doit être inférieur du Date F!", success.alertTypeEnum.Warning)
                    End If
                Else
                    Dim f As success = New success
                    f.setAlert("Les Nombres doit contenir des chiffres!", success.alertTypeEnum.Warning)
                End If
            Else
                Dim f As success = New success
                f.setAlert("Echec lors de l'ajout, vérifier votre saisies!", success.alertTypeEnum.Warning)
            End If
        Else
            Dim f As success = New success
            f.setAlert("Veuillez remplir tout les champs!", success.alertTypeEnum.Warning)

        End If

    End Sub

    ''BOUTON ANNULER (VIDER LES CHAMPS)
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        ''GunaTextBox1.Text = ""
        GunaTextBox2.Text = ""
        GunaTextBox3.Text = ""
        GunaTextBox4.Text = ""
        GunaComboBox3.SelectedIndex = 0
        GunaTextBox6.Text = ""
        GunaComboBox1.SelectedIndex = 0
        GunaTextBox8.Text = ""
        GunaTextBox9.Text = ""
        GunaTextBox10.Text = ""
        GunaComboBox2.SelectedIndex = 0
        GunaComboBox4.SelectedIndex = 0
        GunaTextBox5.Text = ""
        GunaTextBox7.Text = ""
        GunaTextBox11.Text = ""
        GunaComboBox5.SelectedIndex = 0
        GunaComboBox6.SelectedIndex = 0
    End Sub
End Class