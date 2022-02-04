Imports System.Data.Odbc
Imports System.Data
Public Class Login
    Dim CMD As New OdbcCommand
    Dim DR As OdbcDataReader
    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        Me.Close()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBox1.MaxLength = 6
        Guna2TextBox2.PasswordChar = "*"
        Guna2TextBox1.Clear()
        Guna2TextBox2.Clear()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Then
            MessageBox.Show("username & password kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Call bukaDB()
            CMD = New OdbcCommand("select * from users where username='" & Guna2TextBox1.Text & "' and password='" & Guna2TextBox2.Text & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                Me.Close()
                Form1.Show()
                Form1.Guna2GradientButton2.Enabled = True
                Form1.Guna2GradientButton1.Enabled = True
            Else
                MessageBox.Show("LOGIN GAGAL! username/password salah", "Gagal",
               MessageBoxButtons.OK, MessageBoxIcon.Error)
                Guna2TextBox1.Text = ""
                Guna2TextBox2.Text = ""
            End If
        End If
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked = True Then
            Guna2TextBox2.PasswordChar = ""
        Else
            Guna2TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class