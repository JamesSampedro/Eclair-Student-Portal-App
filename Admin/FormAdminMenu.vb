Public Class FormAdminMenu
    Private Sub btnAddLogin_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Me.ActiveControl = Nothing
        FormAddStudent.Show()
    End Sub

    Private Sub btnModifyGrades_Click(sender As Object, e As EventArgs) Handles btnModifyGrades.Click
        Me.ActiveControl = Nothing
        FormModifyGrades.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.ActiveControl = Nothing
        FormLogin.Show()
        FormLogin.txtboxLoginID.Clear()
        FormLogin.txtboxPassword.Clear()
        FormLogin.cmbUserType.SelectedIndex = -1
        Me.Close()
    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        Me.ActiveControl = Nothing
        FormAddAdmin.Show()
    End Sub

    Private Sub btnViewGrades_Click(sender As Object, e As EventArgs) Handles btnViewGrades.Click
        Me.ActiveControl = Nothing
        FormViewStudentGrades.Show()
    End Sub
End Class