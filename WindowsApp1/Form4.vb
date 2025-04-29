Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim totalSum = 500
        Dim finalTotal As Single
        If RadioButton1.Checked Then
            finalTotal = 0 + totalSum
            Me.Label1.Text = $"Total: {finalTotal:C}"
        ElseIf RadioButton2.Checked Then
            finalTotal = 10 + totalSum
            Me.Label1.Text = $"Total: {finalTotal:C}"
        ElseIf RadioButton3.Checked Then
            finalTotal = 15 + totalSum
            Me.Label1.Text = $"Total: {finalTotal:C}"
        End If

        Dim label2 = TextBox1.Text
        Dim label3 = TextBox2.Text
        Dim label4 = TextBox3.Text
        Dim label5 = TextBox4.Text
        Dim label6 = TextBox5.Text
        Dim label7 = TextBox6.Text
        Dim label8 = TextBox7.Text
        Dim label9 = TextBox8.Text
        Dim label10 = TextBox9.Text
        Dim label11 = TextBox10.Text

        Dim shippingName, shippingAddress As String, shippingZip As String, shippingState As String, shippingCell As String
        If RadioButton4.Checked Then
            shippingName = label2
            shippingAddress = label3
            shippingZip = label4
            shippingState = label5
            shippingCell = label6
        Else
            label6 = TextBox5.Text
            label7 = TextBox6.Text
            label8 = TextBox7.Text
            label9 = TextBox8.Text
            label10 = TextBox9.Text
            label11 = TextBox10.Text
        End If

        Dim cardName = TxtBx_cardName.Text
        Dim cardNumber = TxtBox_cardNumber.Text
        Dim cardDate = TxtBox_cardDate.Text
        Dim cardCode = TxtBox_cardCode.Text

        Label1.Text = $"Total: {finalTotal:C}"

    End Sub
End Class