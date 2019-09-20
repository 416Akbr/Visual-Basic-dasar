Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox5.Text >= 7000000 Then
            MsgBox("Boleh pesan semua kendaraan")
            Form_2.Show()
            Me.Hide()
        ElseIf TextBox5.Text >= 5000000 Then
            MsgBox("Boleh beli sampai harga Rp 50.000.000")
            Form_2.Show()
            Me.Hide()
        ElseIf TextBox5.Text >= 3000000 Then
            MsgBox("Boleh beli sampai harga Rp 25.000.000")
            Form_2.Show()
            Me.Hide()
        ElseIf TextBox5.Text >= 1500000 Then
            MsgBox("Boleh beli sampai harga RP 18.000.000")
            Form_2.Show()
            Me.Hide()
        Else
            MsgBox("Kredit tidak diperbolehkan")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ComboBox1.Items.Add("KAWIN")
        ComboBox1.Items.Add("BELUM KAWIN")

        ComboBox3.Items.Add("A")
        ComboBox3.Items.Add("B")
        ComboBox3.Items.Add("O")
        ComboBox3.Items.Add("AB")

        Dim jt As Integer
        For jt = 1 To 10
            ComboBox4.Items.Add(jt)
        Next

        ComboBox5.Items.Add("WIRASWASTA")
        ComboBox5.Items.Add("DOKTER")
        ComboBox5.Items.Add("KARYAWAN")
        ComboBox5.Items.Add("PILOT")



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1


    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.Aqua

    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub
    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.BackColor = Color.Aqua

    End Sub
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.BackColor = Color.White
    End Sub
    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        TextBox3.BackColor = Color.Aqua

    End Sub
    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox3.BackColor = Color.White

    End Sub
    Private Sub TextBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.GotFocus
        TextBox4.BackColor = Color.Aqua
    End Sub
    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.LostFocus
        TextBox4.BackColor = Color.White

    End Sub
    Private Sub TextBox5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.GotFocus
        TextBox5.BackColor = Color.Aqua
    End Sub
    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        TextBox5.BackColor = Color.White

    End Sub
    Private Sub TextBox6_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.GotFocus
        TextBox6.BackColor = Color.Aqua
    End Sub
    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        TextBox6.BackColor = Color.White

    End Sub
    Private Sub TextBox7_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.GotFocus
        TextBox7.BackColor = Color.Aqua
    End Sub
    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        TextBox7.BackColor = Color.White

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim a As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse a = Keys.Back) Then
            a = 0
        End If
        e.Handled = CBool(a)
        TextBox1.MaxLength = 16

    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim a As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse a = Keys.Back) Then
            a = 0
        End If
        e.Handled = CBool(a)
        TextBox7.MaxLength = 13
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim a As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" _
            OrElse a = Keys.Back) Then
            a = 0
        End If
        e.Handled = CBool(a)
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim a As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" _
            OrElse a = Keys.Back) Then
            a = 0
        End If
        e.Handled = CBool(a)
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim a As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse a = Keys.Back) Then
            a = 0
        End If
        e.Handled = CBool(a)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As String
        a = InputBox("Tambahan, ketik ")
        ComboBox5.Items.Add(a)
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class
