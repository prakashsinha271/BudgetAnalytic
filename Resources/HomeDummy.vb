Public Class HomeDummy

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CloseAllOpen()
        Dim frm As New NewTransaction
        frm.Show()
        frm.MdiParent = Home
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CloseAllOpen()
        Dim frm As New Administrator
        frm.Show()
        frm.MdiParent = Home
    End Sub
End Class