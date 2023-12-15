Imports System.Data.SqlClient

Public Class tendance
    ''ON LOAD (PEMPLISSAGE DES COMBOBOX + DATAGRID)
    Private Sub tendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
        Dim Command1 As New SqlCommand("SELECT cod_hot,lib FROM Hotels", connection)
        Dim Adapter1 As New SqlDataAdapter(Command1)
        Dim table1 As New DataTable()
        Adapter1.Fill(table1)
        GunaComboBox1.DataSource = table1
        GunaComboBox1.DisplayMember = "lib"
        GunaComboBox1.ValueMember = "cod_hot"
        connection.Close()

        Dim connection0 As New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
        connection0.Open()
        Dim Command As New SqlCommand("SELECT cod_cat,nb_ch,nb_lits,nb_emploi,CONCAT(anclas1,'-',anclas2) AS PERIODE
        FROM hot_cat1
        WHERE cod_hot in (select cod_hot from hotels where lib = '" & GunaComboBox1.SelectedValue.ToString & "')
        ORDER BY anclas1", connection0)
        Dim r As SqlDataReader = Command.ExecuteReader
        While r.Read
            GunaDataGridView1.Rows.Add(r(0), r(1), r(2), r(3), r(4))
        End While
        r.Close()

        GunaDataGridView1.ClearSelection()
    End Sub

    ''BOUTON D'IMPRESSION
    Private bitmap As Bitmap
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        GunaLabel3.Text = GunaComboBox1.GetItemText(GunaComboBox1.SelectedItem)



        Dim heightInitial As Integer = GunaDataGridView1.Height
        Dim height As Integer = 0
        If GunaDataGridView1.RowCount > 0 Then

            ''CHART 
            ''Dim connection3 As New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=true")
            ''connection3.Open()
            ''Dim Command3 As New SqlCommand("SELECT *
            ''From hot_cat1
            ''WHERE cod_hot  = '" & GunaComboBox1.SelectedValue.ToString & "'
            ''ORDER BY anclas1", connection3)
            ''Dim r3 As SqlDataReader = Command3.ExecuteReader
            ''While r3.Read
            ''Chart1.Series("Historique").Points.AddXY(r3(2), r3(6))
            ''End While
            ''r3.Close()
            ''connection3.Close()

            height = GunaDataGridView1.Rows.GetRowsHeight(Nothing) + GunaDataGridView1.ColumnHeadersHeight


            GunaDataGridView1.Height = height
            '' bitmap = New Bitmap(Me.GunaDataGridView1.Width, Me.GunaDataGridView1.Height)
            bitmap = New Bitmap(Me.GunaDataGridView1.Width, 700)
            GunaDataGridView1.DrawToBitmap(bitmap, New Rectangle(65, 150, Me.GunaDataGridView1.Width, 700))
            GunaLabel3.DrawToBitmap(bitmap, New Rectangle(320, 50, Me.GunaLabel3.Width, 700))
            ''Chart1.DrawToBitmap(bitmap, New Rectangle(85, 470, Chart1.Width, 700))
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()
            GunaDataGridView1.Height = heightInitial
        Else
            Dim f As success = New success
            f.setAlert("La table ne contient auccune ligne!", success.alertTypeEnum.Warning)
        End If
    End Sub

    ''ACTION D'IMPRESSION
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim printView As RectangleF = e.PageSettings.PrintableArea
        If Me.GunaDataGridView1.Height - printView.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub

    Private Sub GunaComboBox1_Click(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedValueChanged
        Dim connection0 As New SqlConnection("Server=DHIBOU\SQLEXPRESS;Database=dbo;Integrated Security=True")
        connection0.Open()

        Dim Command As New SqlCommand("Select cod_cat,nb_ch,nb_lits,nb_emploi,CONCAT(anclas1,'-',anclas2) AS PERIODE
        FROM hot_cat1 WHERE cod_hot = '" & GunaComboBox1.SelectedValue.ToString & "' ORDER BY anclas1", connection0)
        Dim r As SqlDataReader = Command.ExecuteReader

        ''VIDER LA TABLE
        GunaDataGridView1.Rows.Clear()
        While r.Read
            ''REMPLIR LA TABLE PAR LES DONNEES DU REQUETTE
            GunaDataGridView1.Rows.Add(r(0), r(1), r(2), r(3), r(4))
        End While
        r.Close()
        connection0.Close()
        GunaDataGridView1.ClearSelection()
    End Sub

End Class