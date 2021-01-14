Imports System.Data.SqlClient

Module DBConnection
    Public conn As New SqlConnection
    Public query As String '
    Public Dadapter As SqlDataAdapter
    Public Dtadapter As SqlDataAdapter
    Public Dset As New DataSet
    Public Dtset As New DataSet
    Public cmd As New SqlCommand
    Public cmd2 As New SqlCommand
    Public query2 As String

    Sub connection()

        conn = New SqlConnection
        conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DBBudget.mdf;Integrated Security=True;User Instance=True"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("connected")
            End If
        Catch ex As Exception
            MsgBox("Connection Failed with database" & Err.Description)
        End Try
    End Sub
    Public Sub CloseAllOpen()
        For Each aform As Form In Home.MdiChildren
            aform.Close()
        Next
        Dim frm As New HomeDummy
        frm.Show()
        frm.MdiParent = Home
    End Sub
End Module
