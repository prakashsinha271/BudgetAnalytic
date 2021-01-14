<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTransaction
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DescriptionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBBudgetDataSet = New MyBudgetAnalytic.DBBudgetDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DescriptionsTableAdapter = New MyBudgetAnalytic.DBBudgetDataSetTableAdapters.DescriptionsTableAdapter()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        CType(Me.DescriptionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBBudgetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Wallet", "Account"})
        Me.ComboBox1.Location = New System.Drawing.Point(63, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 29)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.ComboBox2.Location = New System.Drawing.Point(269, 39)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 29)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.DescriptionsBindingSource
        Me.ComboBox3.DisplayMember = "Abbrivation"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(475, 39)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 29)
        Me.ComboBox3.TabIndex = 2
        Me.ComboBox3.ValueMember = "Abbrivation"
        '
        'DescriptionsBindingSource
        '
        Me.DescriptionsBindingSource.DataMember = "Descriptions"
        Me.DescriptionsBindingSource.DataSource = Me.DBBudgetDataSet
        '
        'DBBudgetDataSet
        '
        Me.DBBudgetDataSet.DataSetName = "DBBudgetDataSet"
        Me.DBBudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(59, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Transaction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(265, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Source"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(471, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Description"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(269, 82)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 29)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Remark"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(854, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(933, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1012, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 30)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(96, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Available Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(708, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Debited Balance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(404, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Credited Balance"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(29, 174)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(150, 30)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(185, 174)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 30)
        Me.TextBox3.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(341, 174)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(150, 30)
        Me.TextBox4.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(497, 174)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(150, 30)
        Me.TextBox5.TabIndex = 17
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(653, 174)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(150, 30)
        Me.TextBox6.TabIndex = 18
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(809, 174)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(150, 30)
        Me.TextBox7.TabIndex = 19
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(965, 174)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(150, 30)
        Me.TextBox8.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(1001, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 21)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Month"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(274, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Account"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(130, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Wallet"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(442, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 18)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Wallet"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(586, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Account"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(754, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 18)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Wallet"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(898, 207)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 18)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Account"
        '
        'DataGridView1
        '
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(565, 389)
        Me.DataGridView1.TabIndex = 28
        '
        'DataGridView2
        '
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(575, 266)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(565, 389)
        Me.DataGridView2.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(3, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(293, 21)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Last Transactions from wallet:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(571, 242)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(313, 21)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Last Transactions from account:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(677, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 21)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Amount"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(681, 38)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(150, 29)
        Me.TextBox9.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(475, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 21)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Date/Time"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(591, 78)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(240, 30)
        Me.DateTimePicker1.TabIndex = 35
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1120, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 25)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DescriptionsTableAdapter
        '
        Me.DescriptionsTableAdapter.ClearBeforeFill = True
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(63, 82)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(200, 29)
        Me.TextBox10.TabIndex = 37
        Me.TextBox10.Text = "Trans"
        '
        'NewTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MyBudgetAnalytic.My.Resources.Resources.Ad_Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1145, 667)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(202, 65)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "NewTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NewTransaction"
        CType(Me.DescriptionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBBudgetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DBBudgetDataSet As MyBudgetAnalytic.DBBudgetDataSet
    Friend WithEvents DescriptionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescriptionsTableAdapter As MyBudgetAnalytic.DBBudgetDataSetTableAdapters.DescriptionsTableAdapter
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
End Class
