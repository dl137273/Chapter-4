Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If txtInteger.Text = 1 Then
            lblRomanNumeral.Text = "I"
        ElseIf txtInteger.Text = 2 Then
            lblRomanNumeral.Text = "II"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInteger.Text = " "
        lblRomanNumeral.Text = " "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
