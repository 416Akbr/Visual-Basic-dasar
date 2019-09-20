Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Hide()
        Label20.Text = DateTimePicker1.Text
        Label11.Text = Form1.TextBox1.Text
        Label12.Text = Form1.TextBox2.Text
        Label13.Text = Form1.TextBox3.Text
        Label14.Text = Form3.TextBox1.Text
        Label15.Text = Form3.Label13.Text
        Label16.Text = Form3.Label9.Text
        Label17.Text = Form3.ComboBox1.Text
        Label18.Text = Form3.ComboBox2.Text
        Label19.Text = Form3.ComboBox3.Text

    End Sub
End Class