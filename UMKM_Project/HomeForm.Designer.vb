<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.gbProfit = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbBookkeep = New System.Windows.Forms.GroupBox()
        Me.gbDebt = New System.Windows.Forms.GroupBox()
        Me.gbTotalIncome = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbTotalIncome = New System.Windows.Forms.ListBox()
        Me.gbProfit.SuspendLayout()
        Me.gbBookkeep.SuspendLayout()
        Me.gbDebt.SuspendLayout()
        Me.gbTotalIncome.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbProfit
        '
        Me.gbProfit.BackColor = System.Drawing.Color.White
        Me.gbProfit.Controls.Add(Me.Label1)
        Me.gbProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProfit.Location = New System.Drawing.Point(5, 32)
        Me.gbProfit.Name = "gbProfit"
        Me.gbProfit.Size = New System.Drawing.Size(680, 74)
        Me.gbProfit.TabIndex = 0
        Me.gbProfit.TabStop = False
        Me.gbProfit.Text = "Profit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rp 3.500.000"
        '
        'gbBookkeep
        '
        Me.gbBookkeep.BackColor = System.Drawing.Color.White
        Me.gbBookkeep.Controls.Add(Me.Label5)
        Me.gbBookkeep.Controls.Add(Me.Label4)
        Me.gbBookkeep.Controls.Add(Me.Label3)
        Me.gbBookkeep.Controls.Add(Me.Label2)
        Me.gbBookkeep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBookkeep.Location = New System.Drawing.Point(7, 112)
        Me.gbBookkeep.Name = "gbBookkeep"
        Me.gbBookkeep.Size = New System.Drawing.Size(335, 140)
        Me.gbBookkeep.TabIndex = 1
        Me.gbBookkeep.TabStop = False
        Me.gbBookkeep.Text = "Bookkeep"
        '
        'gbDebt
        '
        Me.gbDebt.BackColor = System.Drawing.Color.White
        Me.gbDebt.Controls.Add(Me.Label6)
        Me.gbDebt.Controls.Add(Me.Label7)
        Me.gbDebt.Controls.Add(Me.Label8)
        Me.gbDebt.Controls.Add(Me.Label9)
        Me.gbDebt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDebt.Location = New System.Drawing.Point(349, 112)
        Me.gbDebt.Name = "gbDebt"
        Me.gbDebt.Size = New System.Drawing.Size(335, 140)
        Me.gbDebt.TabIndex = 2
        Me.gbDebt.TabStop = False
        Me.gbDebt.Text = "Debt"
        '
        'gbTotalIncome
        '
        Me.gbTotalIncome.BackColor = System.Drawing.Color.White
        Me.gbTotalIncome.Controls.Add(Me.lbTotalIncome)
        Me.gbTotalIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTotalIncome.Location = New System.Drawing.Point(5, 265)
        Me.gbTotalIncome.Name = "gbTotalIncome"
        Me.gbTotalIncome.Size = New System.Drawing.Size(679, 207)
        Me.gbTotalIncome.TabIndex = 3
        Me.gbTotalIncome.TabStop = False
        Me.gbTotalIncome.Text = "Total Income"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Income"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "expense"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rp 6.000.000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(20, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Rp 2.500.000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(16, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Rp 500.000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Rp 30.000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Cutomer Debt"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "My Debt"
        '
        'lbTotalIncome
        '
        Me.lbTotalIncome.FormattingEnabled = True
        Me.lbTotalIncome.ItemHeight = 25
        Me.lbTotalIncome.Location = New System.Drawing.Point(17, 34)
        Me.lbTotalIncome.Name = "lbTotalIncome"
        Me.lbTotalIncome.Size = New System.Drawing.Size(639, 154)
        Me.lbTotalIncome.TabIndex = 0
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(697, 387)
        Me.Controls.Add(Me.gbTotalIncome)
        Me.Controls.Add(Me.gbDebt)
        Me.Controls.Add(Me.gbBookkeep)
        Me.Controls.Add(Me.gbProfit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        Me.gbProfit.ResumeLayout(False)
        Me.gbProfit.PerformLayout()
        Me.gbBookkeep.ResumeLayout(False)
        Me.gbBookkeep.PerformLayout()
        Me.gbDebt.ResumeLayout(False)
        Me.gbDebt.PerformLayout()
        Me.gbTotalIncome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbProfit As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbBookkeep As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbDebt As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents gbTotalIncome As GroupBox
    Friend WithEvents lbTotalIncome As ListBox
End Class
