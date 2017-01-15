Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Type only numbers")
        ElseIf Not TextBox1.Text.StartsWith("69") Then
            MsgBox("Should start with '69' ")
        Else
            MsgBox("The phone number is correct")

        End If
    End Sub
End Class
