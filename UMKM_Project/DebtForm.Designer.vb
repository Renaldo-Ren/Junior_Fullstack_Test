<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebtForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDebt = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDebtName = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpDebtDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDebt)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Debt Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rp"
        '
        'txtDebt
        '
        Me.txtDebt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebt.ForeColor = System.Drawing.Color.Red
        Me.txtDebt.Location = New System.Drawing.Point(78, 37)
        Me.txtDebt.Name = "txtDebt"
        Me.txtDebt.Size = New System.Drawing.Size(535, 45)
        Me.txtDebt.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtDebtName)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(2, 225)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(637, 83)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Debt Name"
        '
        'txtDebtName
        '
        Me.txtDebtName.Location = New System.Drawing.Point(19, 35)
        Me.txtDebtName.Name = "txtDebtName"
        Me.txtDebtName.Size = New System.Drawing.Size(592, 36)
        Me.txtDebtName.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(2, 398)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(637, 46)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtCustName)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(637, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Name"
        '
        'txtCustName
        '
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCustName.Location = New System.Drawing.Point(19, 37)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(594, 45)
        Me.txtCustName.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.dtpDebtDate)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(2, 309)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(637, 83)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Debt Date"
        '
        'dtpDebtDate
        '
        Me.dtpDebtDate.Location = New System.Drawing.Point(19, 35)
        Me.dtpDebtDate.Name = "dtpDebtDate"
        Me.dtpDebtDate.Size = New System.Drawing.Size(592, 36)
        Me.dtpDebtDate.TabIndex = 0
        '
        'DebtForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(642, 454)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DebtForm"
        Me.Text = "DebtForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDebt As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtDebtName As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dtpDebtDate As DateTimePicker
End Class
