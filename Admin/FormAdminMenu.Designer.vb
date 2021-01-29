<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminMenu))
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnModifyGrades = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.btnViewGrades = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(24, 58)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(123, 41)
        Me.btnAddStudent.TabIndex = 0
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnModifyGrades
        '
        Me.btnModifyGrades.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyGrades.Location = New System.Drawing.Point(24, 118)
        Me.btnModifyGrades.Name = "btnModifyGrades"
        Me.btnModifyGrades.Size = New System.Drawing.Size(123, 41)
        Me.btnModifyGrades.TabIndex = 1
        Me.btnModifyGrades.Text = "Modify Grades"
        Me.btnModifyGrades.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(279, 179)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(123, 41)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.Location = New System.Drawing.Point(210, 58)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(123, 41)
        Me.btnAddAdmin.TabIndex = 3
        Me.btnAddAdmin.Text = "Add Admin"
        Me.btnAddAdmin.UseVisualStyleBackColor = True
        '
        'btnViewGrades
        '
        Me.btnViewGrades.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewGrades.Location = New System.Drawing.Point(210, 118)
        Me.btnViewGrades.Name = "btnViewGrades"
        Me.btnViewGrades.Size = New System.Drawing.Size(123, 41)
        Me.btnViewGrades.TabIndex = 4
        Me.btnViewGrades.Text = "View Grades"
        Me.btnViewGrades.UseVisualStyleBackColor = True
        '
        'FormAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(414, 232)
        Me.Controls.Add(Me.btnViewGrades)
        Me.Controls.Add(Me.btnAddAdmin)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnModifyGrades)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnModifyGrades As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAddAdmin As Button
    Friend WithEvents btnViewGrades As Button
End Class
