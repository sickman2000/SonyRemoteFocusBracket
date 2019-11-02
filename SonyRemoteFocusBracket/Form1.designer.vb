<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class From1

    Inherits System.Windows.Forms.Form

    Public Shared Amount As Integer = 10     'Number of photos
    Public Shared Coarsness As String = "y"    'Focus speed: y=fast, t=medium, r=slow
    Public Shared Intervall As Integer = 1000   'Time between each shoot in miliseconds
    Dim KeyStr As New Dictionary(Of String, String) From {{"Coarse", "y"}, {"Medium", "t"}, {"Fine", "r"}}
    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIntervall = New System.Windows.Forms.TextBox()
        Me.bxCoarse = New System.Windows.Forms.RadioButton()
        Me.bxMedium = New System.Windows.Forms.RadioButton()
        Me.bxFine = New System.Windows.Forms.RadioButton()
        Me.CoarseBox = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnReconnect = New System.Windows.Forms.Button()
        Me.Info = New System.Windows.Forms.Label()
        Me.CoarseBox.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(20, 77)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(91, 32)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Stacking"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Image Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(115, 38)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Time Intervall (s)"
        '
        'txtIntervall
        '
        Me.txtIntervall.Location = New System.Drawing.Point(115, 12)
        Me.txtIntervall.Name = "txtIntervall"
        Me.txtIntervall.Size = New System.Drawing.Size(100, 20)
        Me.txtIntervall.TabIndex = 5
        Me.txtIntervall.Text = "10"
        '
        'bxCoarse
        '
        Me.bxCoarse.AutoSize = True
        Me.bxCoarse.Location = New System.Drawing.Point(33, 19)
        Me.bxCoarse.Name = "bxCoarse"
        Me.bxCoarse.Size = New System.Drawing.Size(58, 17)
        Me.bxCoarse.TabIndex = 7
        Me.bxCoarse.Tag = ""
        Me.bxCoarse.Text = "Coarse"
        Me.bxCoarse.UseVisualStyleBackColor = True
        '
        'bxMedium
        '
        Me.bxMedium.AutoSize = True
        Me.bxMedium.Checked = True
        Me.bxMedium.Location = New System.Drawing.Point(33, 42)
        Me.bxMedium.Name = "bxMedium"
        Me.bxMedium.Size = New System.Drawing.Size(62, 17)
        Me.bxMedium.TabIndex = 8
        Me.bxMedium.TabStop = True
        Me.bxMedium.Tag = ""
        Me.bxMedium.Text = "Medium"
        Me.bxMedium.UseVisualStyleBackColor = True
        '
        'bxFine
        '
        Me.bxFine.AutoSize = True
        Me.bxFine.Location = New System.Drawing.Point(33, 65)
        Me.bxFine.Name = "bxFine"
        Me.bxFine.Size = New System.Drawing.Size(45, 17)
        Me.bxFine.TabIndex = 9
        Me.bxFine.Tag = ""
        Me.bxFine.Text = "Fine"
        Me.bxFine.UseVisualStyleBackColor = True
        '
        'CoarseBox
        '
        Me.CoarseBox.Controls.Add(Me.bxCoarse)
        Me.CoarseBox.Controls.Add(Me.bxFine)
        Me.CoarseBox.Controls.Add(Me.bxMedium)
        Me.CoarseBox.Location = New System.Drawing.Point(232, 12)
        Me.CoarseBox.Name = "CoarseBox"
        Me.CoarseBox.Size = New System.Drawing.Size(110, 97)
        Me.CoarseBox.TabIndex = 10
        Me.CoarseBox.TabStop = False
        Me.CoarseBox.Text = "Zoom Coarseness"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 169)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(504, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'btnReconnect
        '
        Me.btnReconnect.Location = New System.Drawing.Point(20, 115)
        Me.btnReconnect.Name = "btnReconnect"
        Me.btnReconnect.Size = New System.Drawing.Size(91, 31)
        Me.btnReconnect.TabIndex = 12
        Me.btnReconnect.Text = "Reconnect"
        Me.btnReconnect.UseVisualStyleBackColor = True
        '
        'Info
        '
        Me.Info.Location = New System.Drawing.Point(156, 96)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(332, 73)
        Me.Info.TabIndex = 13
        Me.Info.Text = "Info"
        '
        'From1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 191)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.btnReconnect)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CoarseBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIntervall)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "From1"
        Me.Text = "Sony Remote Focus Bracket Tool / Copyright 2019 Sigurd Krieger"
        Me.CoarseBox.ResumeLayout(False)
        Me.CoarseBox.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub rbCoarse()
        Throw New NotImplementedException()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIntervall As TextBox
    Friend WithEvents bxCoarse As RadioButton
    Friend WithEvents bxMedium As RadioButton
    Friend WithEvents bxFine As RadioButton
    Friend WithEvents CoarseBox As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btnReconnect As Button
    Friend WithEvents Info As Label
End Class
