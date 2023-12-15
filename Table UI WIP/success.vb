Public Class success
    Enum alertTypeEnum
        Success
        Warning
        Error1
        Info
    End Enum

    Dim x, y As Integer
    Public Sub setAlert(msg As String, type As alertTypeEnum)
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.Manual
        Dim fname As String
        For i As Integer = 1 To 10
            fname = "alert" & i.ToString
            Dim f As success = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Me.Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
        Select Case type
            Case alertTypeEnum.Error1
                Me.GunaPictureBox1.Image = My.Resources.error2
                Me.BackColor = Color.FromArgb(9, 188, 138)
            Case alertTypeEnum.Info
                Me.GunaPictureBox1.Image = My.Resources.info2
                Me.BackColor = Color.FromArgb(9, 188, 138)
            Case alertTypeEnum.Success
                Me.GunaPictureBox1.Image = My.Resources.success2
                Me.BackColor = Color.FromArgb(9, 188, 138)
            Case alertTypeEnum.Warning
                Me.GunaPictureBox1.Image = My.Resources.warning
                Me.BackColor = Color.FromArgb(9, 188, 138)
        End Select
        Me.Label1.Text = msg
        Me.Show()
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub

    Enum action1
        wait
        start
        close
    End Enum
    Private action As action1 = action1.start

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Me.Timer1.Interval = 1
        action = action1.close
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case action1.start
                Me.Timer1.Interval = 1
                Me.Opacity += 0.1
                If x < Me.Location.X Then
                    Me.Left -= 1
                Else
                    If Me.Opacity = 1 Then
                        action = action1.wait
                    End If
                End If
            Case action1.wait
                Timer1.Interval = 5000
                action = action1.close
            Case action1.close
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Close()
                End If
        End Select
    End Sub
End Class