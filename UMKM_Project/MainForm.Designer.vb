<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnPromote = New System.Windows.Forms.Button()
        Me.btnBookKeep = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnDebt = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDebt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAbout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPromote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnBookKeep)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnHome)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.SplitContainer1.Size = New System.Drawing.Size(885, 516)
        Me.SplitContainer1.SplitterDistance = 190
        Me.SplitContainer1.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Aqua
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAbout.FlatAppearance.BorderSize = 2
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(3, 267)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(192, 66)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnPromote
        '
        Me.btnPromote.BackColor = System.Drawing.Color.Aqua
        Me.btnPromote.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPromote.FlatAppearance.BorderSize = 2
        Me.btnPromote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPromote.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromote.Location = New System.Drawing.Point(3, 201)
        Me.btnPromote.Name = "btnPromote"
        Me.btnPromote.Size = New System.Drawing.Size(192, 66)
        Me.btnPromote.TabIndex = 2
        Me.btnPromote.Text = "Promote"
        Me.btnPromote.UseVisualStyleBackColor = False
        '
        'btnBookKeep
        '
        Me.btnBookKeep.BackColor = System.Drawing.Color.Aqua
        Me.btnBookKeep.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBookKeep.FlatAppearance.BorderSize = 2
        Me.btnBookKeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookKeep.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookKeep.Location = New System.Drawing.Point(3, 69)
        Me.btnBookKeep.Name = "btnBookKeep"
        Me.btnBookKeep.Size = New System.Drawing.Size(192, 66)
        Me.btnBookKeep.TabIndex = 1
        Me.btnBookKeep.Text = "Bookkeep"
        Me.btnBookKeep.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Aqua
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnHome.FlatAppearance.BorderSize = 2
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(3, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(192, 66)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnDebt
        '
        Me.btnDebt.BackColor = System.Drawing.Color.Aqua
        Me.btnDebt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDebt.FlatAppearance.BorderSize = 2
        Me.btnDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebt.Location = New System.Drawing.Point(2, 135)
        Me.btnDebt.Name = "btnDebt"
        Me.btnDebt.Size = New System.Drawing.Size(192, 66)
        Me.btnDebt.TabIndex = 4
        Me.btnDebt.Text = "Debt"
        Me.btnDebt.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 516)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnPromote As Button
    Friend WithEvents btnBookKeep As Button
    Friend WithEvents btnDebt As Button
End Class
