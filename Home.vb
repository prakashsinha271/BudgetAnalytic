Public Class Home

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CloseAllOpen()
        Dim frm As New HomeDummy
        frm.Show()
        frm.MdiParent = Me
    End Sub
End Class