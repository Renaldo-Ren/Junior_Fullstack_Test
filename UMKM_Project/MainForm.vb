Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(HomeForm)
    End Sub
    Public Sub switchPanel(ByVal contentPanel As Form)
        SplitContainer1.Panel2.Controls.Clear()
        contentPanel.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(contentPanel)
        contentPanel.Dock = DockStyle.Fill
        contentPanel.BringToFront()
        contentPanel.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        switchPanel(HomeForm)
    End Sub

    Private Sub btnBookKeep_Click(sender As Object, e As EventArgs) Handles btnBookKeep.Click
        switchPanel(Bookkeep)
    End Sub
End Class
