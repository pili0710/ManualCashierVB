Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox4.Visible = True
        PictureBox5.Visible = False
    End Sub

    Private Sub PictureBox(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover, PictureBox2.MouseHover, PictureBox3.MouseHover
        Dim kocheng = DirectCast(sender, PictureBox)
        kocheng.BackColor = Color.Moccasin
    End Sub

    Private Sub PictureBox_leave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave, PictureBox2.MouseLeave, PictureBox3.MouseLeave
        Dim kocheng = DirectCast(sender, PictureBox)
        kocheng.BackColor = Color.LemonChiffon
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("You Choose Naruto")
        Dim frm2 As New Form2
        gambar = Label1.Text
        frm2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("You Choose Sasuke")
        Dim frm2 As New Form2
        gambar = Label2.Text
        frm2.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("You Choose Hinata")
        Dim frm2 As New Form2
        gambar = Label3.Text
        frm2.Show()
        Me.Close()
    End Sub


End Class
