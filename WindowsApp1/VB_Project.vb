Imports System.Windows

Public Class Form1
    Dim Username As String
    Dim Password As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Username = TextBox1.Text
        Password = TextBox2.Text

        If Username = "1234" And Password = "iseN162" Then
            Label3.Text = "Welcome"
        Else
            Label3.Text = "Try again"
        End If

        Form2.show()

    End Sub
End Class
