Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ComboBox2.Items.Add("MERAH")
        ComboBox2.Items.Add("COKLAT")
        ComboBox2.Items.Add("HITAM")
        ComboBox2.Items.Add("KUNING")
        ComboBox2.Items.Add("HIJAU")
        ComboBox2.Items.Add("BIRU")
        ComboBox2.Items.Add("UNGU")
        ComboBox2.Items.Add("SILVER")
        ComboBox2.Items.Add("GOLD")
        ComboBox2.Items.Add("VINK")
        ComboBox2.Items.Add("CREAM")

        ComboBox3.Items.Add("36")
        ComboBox3.Items.Add("24")
        ComboBox3.Items.Add("12")

        If Form_2.PictureBox1.CanSelect Then
            Label9.Text = Form_2.PictureBox1.Text
        ElseIf Form_2.PictureBox2.CanSelect Then
            Label9.Text = Form_2.PictureBox2.Text
        ElseIf Form_2.PictureBox3.CanSelect Then
            Label9.Text = Form_2.PictureBox3.Text
        ElseIf Form_2.PictureBox4.CanSelect Then
            Label9.Text = Form_2.PictureBox4.Text
        End If



    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.Aqua

    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim a As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse a = Keys.Back) Then
            a = 0
        End If
        e.Handled = CBool(a)
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        Label11.Text = Val(Label10.Text) - Val(TextBox1.Text)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "36" Then
            Label13.Text = Val(Label11.Text) / 36
        ElseIf ComboBox3.Text = "24" Then
            Label13.Text = Val(Label11.Text) / 24
        ElseIf ComboBox3.Text = "12" Then
            Label13.Text = Val(Label11.Text) / 12
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "HONDA" Then
            Label10.Text = 200000000
        ElseIf ComboBox1.Text = "SUZUKI" Then
            Label10.Text = 190000000
        ElseIf ComboBox1.Text = "TOYOTA" Then
            Label10.Text = 210000000

        End If
    End Sub
End Class
