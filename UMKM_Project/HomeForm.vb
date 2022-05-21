Public Class HomeForm
    Private Sub lbTotalIncome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTotalIncome.SelectedIndexChanged

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbTotalIncome.Items.Add("20 May 2022, 18:36" + vbTab + vbTab + vbTab + vbTab + "+Rp 50.000")
        lbTotalIncome.Items.Add("20 May 2022, 15:33" + vbTab + vbTab + vbTab + vbTab + "+Rp 30.000")
        lbTotalIncome.Items.Add("20 May 2022, 14:24" + vbTab + vbTab + vbTab + vbTab + "-Rp 20.000")
        lbTotalIncome.Items.Add("20 May 2022, 10:12" + vbTab + vbTab + vbTab + vbTab + "-Rp 10.000")
        lbTotalIncome.Items.Add("20 May 2022, 8:07" + vbTab + vbTab + vbTab + vbTab + "+Rp 15.000")
        lbTotalIncome.Items.Add("19 May 2022, 20:17" + vbTab + vbTab + vbTab + vbTab + "+Rp 45.000")
        lbTotalIncome.Items.Add("19 May 2022, 19:23" + vbTab + vbTab + vbTab + vbTab + "-Rp 18.000")
        lbTotalIncome.Items.Add("19 May 2022, 18:07" + vbTab + vbTab + vbTab + vbTab + "+Rp 15.000")
        lbTotalIncome.Items.Add("19 May 2022, 15:33" + vbTab + vbTab + vbTab + vbTab + "+Rp 26.000")
        lbTotalIncome.Items.Add("19 May 2022, 13:47" + vbTab + vbTab + vbTab + vbTab + "-Rp 35.000")
    End Sub
End Class