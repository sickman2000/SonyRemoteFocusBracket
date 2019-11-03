Public Class From1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If boStackState = True Then
            boStackState = False
            btnStart.Text = strButtonText(boStackState)
            btnStart.FlatStyle = FlatStyle.Standard
            Exit Sub
        End If

        Try
            Amount = txtAmount.Text
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Wrong Amount Number Format only must use Integer Values"
            Exit Sub
        End Try


        Try
            Intervall = txtIntervall.Text
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Wrong Intervall Number Format only must use Integer Values"
            Exit Sub
        End Try

        Static FireKey As String
        Static frKey As String

        For Each b As RadioButton In CoarseBox.Controls.OfType(Of RadioButton)()
            If b.Checked = True Then
                frKey = b.Text
                FireKey = KeyStr(frKey)
            End If
        Next


        If checkForRemote() = False Then Exit Sub

        btnStart.FlatStyle = FlatStyle.Flat

        Timer1.Start()
        boStackState = True
        btnStart.Text = strButtonText(boStackState)
        ToolStripStatusLabel1.Text = "Fire Focus Forward " + frKey + " and Release Camera Image 1"
        If cbxShoot.Checked = False Then System.Windows.Forms.SendKeys.SendWait("1")
        wait(From1.Intervall)

        For i As Integer = 1 To From1.Amount - 1

            If boStackState = False Then
                btnStart.FlatStyle = FlatStyle.Standard
                Exit For
            End If
            If checkForRemote() = False Then
                btnStart.FlatStyle = FlatStyle.Standard
                boStackState = False
                btnStart.Text = strButtonText(boStackState)
                Exit Sub
            End If

            ToolStripStatusLabel1.Text = "Fire Focus Forward " + frKey + " and Release Camera Image " + (i + 1).ToString
            System.Windows.Forms.SendKeys.SendWait(FireKey)
            If cbxShoot.Checked = False Then System.Windows.Forms.SendKeys.SendWait("1")
            wait(From1.Intervall)

        Next

        ToolStripStatusLabel1.Text = "Finished !!!"

        Timer1.Stop()
        boStackState = False
        btnStart.FlatStyle = FlatStyle.Standard
        btnStart.Text = strButtonText(boStackState)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim msg As String = "Procedure:" + vbCrLf + "Start Imaging Edge Remote," + vbCrLf + "connect your camera," + vbCrLf + "change camera to manual focus mode," + vbCrLf + "focus on start position"
        Info.Text = msg
        checkForRemote()

    End Sub
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Function checkForRemote()
        Try
            Microsoft.VisualBasic.Interaction.AppActivate("Remote")
            btnStart.Enabled = True
            ToolStripStatusLabel1.Text = "Successful Conected To Sony Remote"
            Return True
        Catch ex As Exception
            Console.WriteLine("Error:" + ex.ToString)
            ToolStripStatusLabel1.Text = "Cannot Connected To Sony Remote, Please Connect Camera and start Sony Remote"
            btnStart.Enabled = False
            Return False
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReconnect.Click
        checkForRemote()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If btnStart.FlatAppearance.BorderColor = Color.Red Then
            btnStart.FlatAppearance.BorderColor = Color.Black
        Else
            btnStart.FlatAppearance.BorderColor = Color.Red
        End If
    End Sub
End Class
