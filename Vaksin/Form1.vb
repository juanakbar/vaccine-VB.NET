Public Class Form1
    Sub Terkunci()
        Guna2GradientButton3.Enabled = True
        Guna2GradientButton2.Enabled = False
        Guna2GradientButton1.Enabled = False
    End Sub
    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        Me.Close()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
        Login.ShowDialog()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientButton2_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Register.ShowDialog()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Login.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub Guna2GradientButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        sudahvaksin.ShowDialog()
    End Sub
End Class
