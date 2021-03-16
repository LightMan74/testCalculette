Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String = "1+2-3" '"2/1-3*4+5"

        lcalcfinal.Visible = True
        'lcalcfinal.Text = checkplus(str, "+")
        '0                          10 
        'For longeurstr = 0 To str.Length - 1

        Dim calc As String = str 'Decimal
        Dim operation() As String = {"*", "/", "+", "-"}
        Dim numberofcalc As Integer

        For Each ope As String In operation
            For i = 0 To UBound(Split(str, New Char() {"*", "/", "+", "-"}))
                calc = check(Split(calc, ope)(i), ope)
            Next i
        Next ope


        'calc = calc + check(Split(str, ope)(i), ope)

        lcalcfinal.Text = calc

        Dim ca = str


    End Sub



    Public Function check(sansleplus As String, delimiter As String) As Decimal
        Dim avant As String
        Dim apres As String = Nothing

        avant = Split(sansleplus, delimiter)(0)
        If UBound(Split(sansleplus, delimiter)) > 0 Then

            apres = Split(sansleplus, delimiter)(1)
        End If
        If apres = Nothing Then
            Return CDec(checkafter(avant, True))
        End If
        Select Case delimiter
            Case "+"
                Return CDec(CDec(checkafter(avant, True)) + CDec(checkafter(apres, False)))
            Case "-"
                Return CDec(CDec(checkafter(avant, True)) - CDec(checkafter(apres, False)))
            Case "*"
                Return CDec(CDec(checkafter(avant, True)) * CDec(checkafter(apres, False)))
            Case "/"
                Return CDec(CDec(checkafter(avant, True)) / CDec(checkafter(apres, False)))
        End Select


    End Function

    Public Function checkafter(sanslerien As String, isbefore As Boolean) As Decimal
        If sanslerien = "" Then
            Exit Function
        End If
        If isbefore Then
                sanslerien = Split(sanslerien, "+")(UBound(Split(sanslerien, "+")))
                sanslerien = Split(sanslerien, "-")(UBound(Split(sanslerien, "-")))
                sanslerien = Split(sanslerien, "/")(UBound(Split(sanslerien, "/")))
                sanslerien = Split(sanslerien, "*")(UBound(Split(sanslerien, "*")))
            Else
                sanslerien = Split(sanslerien, "+")(LBound(Split(sanslerien, "+")))
            sanslerien = Split(sanslerien, "-")(LBound(Split(sanslerien, "-")))
            sanslerien = Split(sanslerien, "/")(LBound(Split(sanslerien, "/")))
            sanslerien = Split(sanslerien, "*")(LBound(Split(sanslerien, "*")))
        End If

        Return sanslerien

    End Function


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
