Imports System.Data.SqlClient

Public Class Administrator


    Private Sub Administrator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        viewdata()
    End Sub

    Private Sub viewdata()
        Dset = New DataSet
        query = "SELECT * FROM Login"
        Dadapter = New SqlDataAdapter(query, conn)
        Dadapter.Fill(Dset)
        DataGridView1.DataSource = Dset.Tables(0)

        Dtset = New DataSet
        query2 = "SELECT * FROM Descriptions"
        Dtadapter = New SqlDataAdapter(query2, conn)
        Dtadapter.Fill(Dtset)
        DataGridView2.DataSource = Dtset.Tables(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox2.Text <> TextBox3.Text Or TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Then
                MsgBox("Password isn't match!!" + vbCrLf + "or some fields are missing", MessageBoxIcon.Error)
            Else
                Dim flag As Boolean = False
                Using Com As New SqlCommand("Select * From Login where Email ='" + TextBox5.Text + "'", conn)
                    Using RDR = Com.ExecuteReader()
                        If RDR.HasRows Then
                            Do While RDR.Read
                                flag = True
                            Loop
                        Else
                            flag = False
                        End If
                    End Using
                End Using
                If flag = True Then
                    MsgBox("Email address is already in use, please try another mail address.", MsgBoxStyle.Information)
                    TextBox5.Focus()
                    flag = False
                Else
                    cmd = New SqlCommand
                    cmd.Connection = conn
                    query = Nothing
                    query = "insert into Login values('" + TextBox1.Text.ToString + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    flag = False
                    'viewdata()
                    MsgBox("Registratin successful" + vbCrLf + "Please keep safe your login credential", MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        viewdata()
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub TextBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.Clear()
        TextBox2.Focus()
    End Sub

    Private Sub TextBox3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox3.MouseClick
        TextBox3.Clear()
        TextBox3.Focus()
    End Sub

    Private Sub TextBox4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox4.MouseClick
        TextBox4.Clear()
        TextBox4.Focus()
    End Sub

    Private Sub TextBox5_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox5.MouseClick
        TextBox5.Clear()
        TextBox5.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "LoginID"
        TextBox2.Text = "Password"
        TextBox3.Text = "Confirm Password"
        TextBox4.Text = "Name"
        TextBox5.Text = "Email"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If TextBox6.Text = Nothing Or TextBox7.Text = Nothing Then
                MsgBox("All field are required", MessageBoxIcon.Error)
            Else
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "insert into Descriptions values('" & TextBox7.Text.ToString & "','" & TextBox6.Text.ToString & "')"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        viewdata()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox6.Text = "Description"
        TextBox7.Text = "Abbrivation"
    End Sub
End Class