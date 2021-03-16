Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        'TextBox1.Text = TextBox1.Text & sender.text
        TextBox1.AppendText(sender.text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click, Button14.Click, Button13.Click, Button12.Click
        'TextBox1.AppendText(sender.text)

        If TextBox1.Text.Length > 0 Then

            If TextBox1.Text.Chars(TextBox1.Text.Length - 1) = "+" Or TextBox1.Text.Chars(TextBox1.Text.Length - 1) = "-" Or TextBox1.Text.Chars(TextBox1.Text.Length - 1) = "*" Or TextBox1.Text.Chars(TextBox1.Text.Length - 1) = "/" Then

                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)

            End If

            TextBox1.AppendText(sender.text)

        End If


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub bclear_Click(sender As Object, e As EventArgs) Handles bclear.Click
        TextBox1.Clear()
    End Sub

    Private Sub Bretour_Click(sender As Object, e As EventArgs) Handles Bretour.Click
        If TextBox1.Text.Length <> 0 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
