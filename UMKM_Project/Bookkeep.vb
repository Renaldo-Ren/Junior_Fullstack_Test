Public Class Bookkeep

    Private Sub Bookkeep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIncome.Text = 0
        txtIncome.ForeColor = Color.Gray
        txtFunds.Text = 0
        txtFunds.ForeColor = Color.Gray
        lblProfit.Text = "Rp 0"
        txtIncomeNote.Text = "e.g. Jual Beras"
        txtIncomeNote.ForeColor = Color.Gray
        txtExpense.Text = 0
        txtExpense.ForeColor = Color.Gray
        txtExpenseFunds.Text = 0
        txtExpenseFunds.ForeColor = Color.Gray
        lblTotExpense.Text = "Rp 0"
        txtExpenseNote.Text = "e.g. Beli Tepung"
        txtExpenseNote.ForeColor = Color.Gray
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim income As Double = CInt(txtIncome.Text)
        Dim fund As Double = CInt(txtFunds.Text)
        lblProfit.Text = "Rp " + (income - fund).ToString
        lblProfit.ForeColor = Color.Green
    End Sub

    Private Sub txtIncome_Click(sender As Object, e As EventArgs) Handles txtIncome.Click
        txtIncome.Text = ""
        txtIncome.ForeColor = Color.Lime
    End Sub

    Private Sub txtFunds_Click(sender As Object, e As EventArgs) Handles txtFunds.Click
        txtFunds.Text = ""
        txtFunds.ForeColor = Color.Red
    End Sub

    Private Sub txtIncomeNote_Click(sender As Object, e As EventArgs) Handles txtIncomeNote.Click
        txtIncomeNote.Text = ""
        txtIncomeNote.ForeColor = Color.Black
    End Sub

    Private Sub txtExpense_Click(sender As Object, e As EventArgs) Handles txtExpense.Click
        txtExpense.Text = ""
        txtExpense.ForeColor = Color.Red
    End Sub

    Private Sub txtExpenseFunds_Click(sender As Object, e As EventArgs) Handles txtExpenseFunds.Click
        txtExpenseFunds.Text = ""
        txtExpenseFunds.ForeColor = Color.Red
    End Sub

    Private Sub txtExpenseNote_Click(sender As Object, e As EventArgs) Handles txtExpenseNote.Click
        txtExpenseNote.Text = ""
        txtExpenseNote.ForeColor = Color.Black
    End Sub

    Private Sub btnExpenseSubmit_Click(sender As Object, e As EventArgs) Handles btnExpenseSubmit.Click
        Dim expense As Double = CInt(txtExpense.Text)
        Dim exfund As Double = CInt(txtExpenseFunds.Text)
        lblTotExpense.Text = "Rp " + (expense - exfund).ToString
        lblTotExpense.ForeColor = Color.Green
    End Sub
End Class