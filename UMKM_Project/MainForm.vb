Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(HomeForm)
        SplitContainer1.Panel1Collapsed = False
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If SplitContainer1.Panel1Collapsed = False Then
            SplitContainer1.Panel1Collapsed = True
        ElseIf SplitContainer1.Panel1Collapsed = True Then
            SplitContainer1.Panel1Collapsed = False
        End If
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

    Private Sub btnDebt_Click(sender As Object, e As EventArgs) Handles btnDebt.Click
        switchPanel(DebtForm)
    End Sub

    Private Sub btnPromote_Click(sender As Object, e As EventArgs) Handles btnPromote.Click
        switchPanel(PromoteForm)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        switchPanel(AboutForm)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
