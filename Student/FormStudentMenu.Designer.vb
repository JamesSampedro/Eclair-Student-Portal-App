<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudentMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStudentMenu))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btn1stSem = New System.Windows.Forms.Button()
        Me.btn2ndSem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(279, 179)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(123, 41)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Location = New System.Drawing.Point(12, 179)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(123, 41)
        Me.btnProfile.TabIndex = 3
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btn1stSem
        '
        Me.btn1stSem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1stSem.Location = New System.Drawing.Point(23, 16)
        Me.btn1stSem.Name = "btn1stSem"
        Me.btn1stSem.Size = New System.Drawing.Size(123, 41)
        Me.btn1stSem.TabIndex = 6
        Me.btn1stSem.Text = "1st Semester"
        Me.btn1stSem.UseVisualStyleBackColor = True
        '
        'btn2ndSem
        '
        Me.btn2ndSem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2ndSem.Location = New System.Drawing.Point(152, 16)
        Me.btn2ndSem.Name = "btn2ndSem"
        Me.btn2ndSem.Size = New System.Drawing.Size(123, 41)
        Me.btn2ndSem.TabIndex = 7
        Me.btn2ndSem.Text = "2nd Semester"
        Me.btn2ndSem.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn2ndSem)
        Me.GroupBox1.Controls.Add(Me.btn1stSem)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 71)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Grades"
        '
        'FormStudentMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(414, 232)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnProfile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormStudentMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btn1stSem As Button
    Friend WithEvents btn2ndSem As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
