Public Class Form_2

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.Text = "MOBIL"
        Dim a As Integer
        a = 150000000
        Form3.Label10.Text = a
        Form3.Label9.Text = PictureBox1.Text

        If Form1.TextBox5.Text >= 7000000 Then
            Form3.Show()
            Me.Hide()
            Form3.ComboBox1.Items.Add("HONDA")
            Form3.ComboBox1.Items.Add("TOYOTA")
            Form3.ComboBox1.Items.Add("SUZUKI")
            Form3.ComboBox1.Items.Add("MITSUBTSHI")
            Form3.ComboBox1.Items.Add("BMW")
        Else
            MsgBox("Maaf,kendaraan ini diperbolehkan untuk berpenghasilan diatas Rp 7.000.000")
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox2.Text = "MOTOR SPORT"
        Dim a As Integer
        a = 100000000
        Form3.Label10.Text = a
        Form3.Label9.Text = PictureBox2.Text

        If Form1.TextBox5.Text >= 7000000 Then
            Form3.Show()
            Me.Hide()
            Form3.ComboBox1.Items.Add("HONDA")
            Form3.ComboBox1.Items.Add("TOYOTA")
            Form3.ComboBox1.Items.Add("SUZUKI")
            Form3.ComboBox1.Items.Add("KAWASAKI")
            Form3.ComboBox1.Items.Add("YAMAHA")
        Else
            MsgBox("Maaf,kendaraan ini diperbolehkan untuk berpenghasilan diatas Rp 7.000.000")
        End If

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox3.Text = "MOTOR BEBEK"
        Dim a As Integer
        a = 25000000
        Form3.Label10.Text = a
        Form3.Label9.Text = PictureBox3.Text

        If Form1.TextBox5.Text >= 3000000 Then
            Form3.Show()
            Me.Hide()
            Form3.ComboBox1.Items.Add("HONDA")
            Form3.ComboBox1.Items.Add("TOYOTA")
            Form3.ComboBox1.Items.Add("SUZUKI")
            Form3.ComboBox1.Items.Add("KAWASAKI")
            Form3.ComboBox1.Items.Add("YAMAHA")
        Else
            MsgBox("Maaf,kendaraan ini diperbolehkan untuk berpenghasilan diatas Rp 3.000.000")
        End If


    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox4.Text = "SCOOTER"
        Dim a As Integer
        a = 15000000
        Form3.Label10.Text = a
        Form3.Label9.Text = PictureBox4.Text

        If Form1.TextBox5.Text >= 1500000 Then
            Form3.Show()
            Me.Hide()
            Form3.ComboBox1.Items.Add("HONDA")
            Form3.ComboBox1.Items.Add("TOYOTA")
            Form3.ComboBox1.Items.Add("SUZUKI")
            Form3.ComboBox1.Items.Add("KAWASAKI")
            Form3.ComboBox1.Items.Add("YAMAHA")
        Else
            MsgBox("Maaf,kendaraan ini diperbolehkan untuk berpenghasilan diatas Rp 1.500.000")
        End If

    End Sub
End Class