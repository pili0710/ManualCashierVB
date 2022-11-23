Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = gambar
        If Label2.Text = "NARUTO" Then
            Label6.Text = 430000
        ElseIf Label2.Text = "SASUKE" Then
            Label6.Text = 445000
        Else
            Label6.Text = 450000
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = Format(DateTimePicker1.Value, "MMMM - d - yyyy")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Label2.Text = "NARUTO" Then

            If CheckBox1.Checked Then
                TextBox1.Text = CheckBox1.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 430000 + 50000
                Else
                    Button2.Text = NumericUpDown1.Value * 430000 + 50000
                End If
            End If
            If CheckBox2.Checked Then
                TextBox1.Text = CheckBox2.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 430000 + 50000
                Else
                    Button2.Text = NumericUpDown1.Value * 430000 + 50000
                End If
            End If
            If CheckBox3.Checked Then
                TextBox1.Text = CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 430000 + 50000
                Else
                    Button2.Text = NumericUpDown1.Value * 430000 + 50000
                End If
            End If
            If CheckBox1.Checked And CheckBox3.Checked Then
                TextBox1.Text = CheckBox1.Text + ", " + CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 430000 + 100000
                Else
                    Button2.Text = NumericUpDown1.Value * 430000 + 100000
                End If
            End If
            If CheckBox2.Checked And CheckBox1.Checked Then
                TextBox1.Text = CheckBox1.Text + ", " + CheckBox2.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 430000 + 100000
                Else
                    Button2.Text = NumericUpDown1.Value * 430000 + 100000
                End If
            End If
            If CheckBox2.Checked And CheckBox3.Checked Then
                TextBox1.Text = CheckBox2.Text + ", " + CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 430000 + 100000
                Else
                    Button2.Text = NumericUpDown1.Value * 430000 + 100000
                End If
            End If
            If CheckBox3.Checked And CheckBox2.Checked And CheckBox1.Checked Then
                TextBox1.Text = CheckBox1.Text + ", " + CheckBox2.Text + ", " + CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 430000 + 150000
                Else
                    Button2.Text = NumericUpDown1.Value * 430000 + 150000
                End If
            End If

            If RadioButton1.Checked Then
                TextBox2.Text = RadioButton1.Text
            End If
            If RadioButton2.Checked Then
                TextBox2.Text = RadioButton2.Text
            End If
        End If

        If Label2.Text = "SASUKE" Then
            If CheckBox1.Checked Then
                TextBox1.Text = CheckBox1.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 445000 + 50000
                Else
                    Button2.Text = NumericUpDown1.Value * 445000 + 50000
                End If
            End If
            If CheckBox2.Checked Then
                TextBox1.Text = CheckBox2.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 445000 + 50000
                Else
                    Button2.Text = NumericUpDown1.Value * 445000 + 50000
                End If
            End If
            If CheckBox3.Checked Then
                TextBox1.Text = CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 445000 + 50000
                Else
                    Button2.Text = NumericUpDown1.Value * 445000 + 50000
                End If
            End If
            If CheckBox1.Checked And CheckBox3.Checked Then
                TextBox1.Text = CheckBox1.Text + ", " + CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 445000 + 100000
                Else
                    Button2.Text = NumericUpDown1.Value * 445000 + 100000
                End If
            End If
            If CheckBox2.Checked And CheckBox1.Checked Then
                TextBox1.Text = CheckBox1.Text + ", " + CheckBox2.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 445000 + 100000
                Else
                    Button2.Text = NumericUpDown1.Value * 445000 + 100000
                End If
            End If
            If CheckBox2.Checked And CheckBox3.Checked Then
                TextBox1.Text = CheckBox2.Text + ", " + CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 445000 + 100000
                Else
                    Button2.Text = NumericUpDown1.Value * 445000 + 100000
                End If
            End If
            If CheckBox3.Checked And CheckBox2.Checked And CheckBox1.Checked Then
                TextBox1.Text = CheckBox1.Text + ", " + CheckBox2.Text + ", " + CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 445000 + 150000
                Else
                    Button2.Text = NumericUpDown1.Value * 445000 + 150000
                End If
            End If

            If RadioButton1.Checked Then
                TextBox2.Text = RadioButton1.Text
            End If
            If RadioButton2.Checked Then
                TextBox2.Text = RadioButton2.Text
            End If

            If RadioButton1.Checked Then
                TextBox2.Text = RadioButton1.Text
            End If
            If RadioButton2.Checked Then
                TextBox2.Text = RadioButton2.Text
            End If
        End If

        If Label2.Text = "HINATA" Then
            If CheckBox1.Checked Then
                TextBox1.Text = CheckBox1.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 450000 + 50000
                Else
                    Button2.Text = NumericUpDown1.Value * 450000 + 50000
                End If
            End If
            If CheckBox2.Checked Then
                TextBox1.Text = CheckBox2.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 450000 + 50000
                Else
                    Button2.Text = NumericUpDown1.Value * 450000 + 50000
                End If
            End If
            If CheckBox3.Checked Then
                TextBox1.Text = CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 450000 + 50000
                Else
                    Button2.Text = NumericUpDown1.Value * 450000 + 50000
                End If
            End If
            If CheckBox1.Checked And CheckBox3.Checked Then
                TextBox1.Text = CheckBox1.Text + ", " + CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 450000 + 100000
                Else
                    Button2.Text = NumericUpDown1.Value * 450000 + 100000
                End If
            End If
            If CheckBox2.Checked And CheckBox1.Checked Then
                TextBox1.Text = CheckBox1.Text + ", " + CheckBox2.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 450000 + 100000
                Else
                    Button2.Text = NumericUpDown1.Value * 450000 + 100000
                End If
            End If
            If CheckBox2.Checked And CheckBox3.Checked Then
                TextBox1.Text = CheckBox2.Text + ", " + CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 450000 + 100000
                Else
                    Button2.Text = NumericUpDown1.Value * 450000 + 100000
                End If
            End If
            If CheckBox3.Checked And CheckBox2.Checked And CheckBox1.Checked Then
                TextBox1.Text = CheckBox1.Text + ", " + CheckBox2.Text + ", " + CheckBox3.Text
                If NumericUpDown1.Value = 1 Then
                    Button2.Text = 450000 + 150000
                Else
                    Button2.Text = NumericUpDown1.Value * 450000 + 150000
                End If
            End If

            If RadioButton1.Checked Then
                TextBox2.Text = RadioButton1.Text
            End If
            If RadioButton2.Checked Then
                TextBox2.Text = RadioButton2.Text
            End If
        End If
        NotifyIcon1.ShowBalloonTip(5000)
    End Sub


End Class