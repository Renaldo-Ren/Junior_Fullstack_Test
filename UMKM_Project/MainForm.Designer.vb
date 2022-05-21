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
        Me.btnDebt = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnPromote = New System.Windows.Forms.Button()
        Me.btnBookKeep = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDebt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAbout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPromote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnBookKeep)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnHome)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(827, 528)
        Me.SplitContainer1.SplitterDistance = 177
        Me.SplitContainer1.TabIndex = 0
        '
        'btnDebt
        '
        Me.btnDebt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDebt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDebt.BackColor = System.Drawing.Color.Aqua
        Me.btnDebt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDebt.FlatAppearance.BorderSize = 2
        Me.btnDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebt.Location = New System.Drawing.Point(2, 135)
        Me.btnDebt.Name = "btnDebt"
        Me.btnDebt.Size = New System.Drawing.Size(179, 66)
        Me.btnDebt.TabIndex = 4
        Me.btnDebt.Text = "Debt"
        Me.btnDebt.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAbout.BackColor = System.Drawing.Color.Aqua
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAbout.FlatAppearance.BorderSize = 2
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(3, 267)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(179, 66)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnPromote
        '
        Me.btnPromote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPromote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPromote.BackColor = System.Drawing.Color.Aqua
        Me.btnPromote.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPromote.FlatAppearance.BorderSize = 2
        Me.btnPromote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPromote.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromote.Location = New System.Drawing.Point(3, 201)
        Me.btnPromote.Name = "btnPromote"
        Me.btnPromote.Size = New System.Drawing.Size(179, 66)
        Me.btnPromote.TabIndex = 2
        Me.btnPromote.Text = "Promote"
        Me.btnPromote.UseVisualStyleBackColor = False
        '
        'btnBookKeep
        '
        Me.btnBookKeep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBookKeep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBookKeep.BackColor = System.Drawing.Color.Aqua
        Me.btnBookKeep.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBookKeep.FlatAppearance.BorderSize = 2
        Me.btnBookKeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookKeep.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookKeep.Location = New System.Drawing.Point(3, 69)
        Me.btnBookKeep.Name = "btnBookKeep"
        Me.btnBookKeep.Size = New System.Drawing.Size(179, 66)
        Me.btnBookKeep.TabIndex = 1
        Me.btnBookKeep.Text = "Bookkeep"
        Me.btnBookKeep.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHome.BackColor = System.Drawing.Color.Aqua
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnHome.FlatAppearance.BorderSize = 2
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(3, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(178, 66)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.Control
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(10, 4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(81, 34)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.BackColor = System.Drawing.Color.Aqua
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(2, 333)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(179, 66)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(848, 496)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnPromote As Button
    Friend WithEvents btnBookKeep As Button
    Friend WithEvents btnDebt As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnExit As Button
End Class
