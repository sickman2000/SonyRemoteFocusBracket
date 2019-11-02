Public Class From1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Try
            From1.Amount = txtAmount.Text
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Wrong Amount Number Format only must use Integer Values"
            Exit Sub
        End Try


        Try
            From1.Intervall = txtIntervall.Text
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

        'MsgBox(FireKey)
        checkForRemote()
        ToolStripStatusLabel1.Text = "Fire Focus Forward " + frKey + " and Release Camera Image 1"
        System.Windows.Forms.SendKeys.SendWait("1")
        Me.wait(From1.Intervall)
        For i As Integer = 1 To From1.Amount - 1
            'ToolStripStatusLabel1.Text = "Waiting " + Form1.Intervall.ToString + "ms ..."
            checkForRemote()
            ToolStripStatusLabel1.Text = "Fire Focus Forward " + frKey + " and Release Camera Image " + (i + 1).ToString
            System.Windows.Forms.SendKeys.SendWait(FireKey)
            System.Windows.Forms.SendKeys.SendWait("1")
            Me.wait(From1.Intervall)
        Next
        ToolStripStatusLabel1.Text = "Finished !!!"
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
    Private Sub checkForRemote()
        Try
            Microsoft.VisualBasic.Interaction.AppActivate("Remote")
            Me.btnStart.Enabled = True
            ToolStripStatusLabel1.Text = "Successful Conected To Sony Remote"
        Catch ex As Exception
            Console.WriteLine("Error:" + ex.ToString)
            ToolStripStatusLabel1.Text = "Cannot Connected To Sony Remote, Please Connect Camera and start Sony Remote"
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReconnect.Click
        checkForRemote()
    End Sub

End Class
