Imports System.Data.SqlClient

Public Class NewTransaction

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub NewTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBBudgetDataSet.Descriptions' table. You can move, or remove it, as needed.
        Me.DescriptionsTableAdapter.Fill(Me.DBBudgetDataSet.Descriptions)
        connection()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.SelectedIndex = 0 Then         ''''''"""WALLET
                If ComboBox2.SelectedIndex = 0 Then         ''''""""DEBIT
                    cmd = New SqlCommand
                    cmd.Connection = conn
                    query = Nothing
                    query = "insert into Wallet values('" + TextBox10.Text + "','" + DateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + ComboBox3.SelectedValue + "','" + TextBox9.Text + "','" + TextBox1.Text + "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    MsgBox("done")
                ElseIf ComboBox2.SelectedIndex = 1 Then     ''''""""CREDIT
                    cmd = New SqlCommand
                    cmd.Connection = conn
                    query = Nothing
                    query = "insert into Wallet values('" + TextBox10.Text + "','" + DateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + ComboBox3.SelectedValue + "','" + TextBox9.Text + "','" + TextBox1.Text + "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    MsgBox("done")
                End If
            ElseIf ComboBox1.SelectedIndex = 1 Then     ''''''"""ACCOUNT
                If ComboBox2.SelectedIndex = 0 Then         ''''""""DEBIT
                    cmd = New SqlCommand
                    cmd.Connection = conn
                    query = Nothing
                    query = "insert into Account values('" + TextBox10.Text + "','" + DateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + ComboBox3.SelectedValue + "','" + TextBox9.Text + "','" + TextBox1.Text + "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    MsgBox("done")
                ElseIf ComboBox2.SelectedIndex = 1 Then     ''''""""CREDIT
                    cmd = New SqlCommand
                    cmd.Connection = conn
                    query = Nothing
                    query = "insert into Account values('" + TextBox10.Text + "','" + DateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + ComboBox3.SelectedValue + "','" + TextBox9.Text + "','" + TextBox1.Text + "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    MsgBox("done")
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class