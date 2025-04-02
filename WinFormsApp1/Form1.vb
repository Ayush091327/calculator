Public Class Form1
    Dim n1(4) As Integer
    Dim count As Integer = 0
    Dim total As Integer = 0

    Private Sub Button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        If count < 5 Then  'ensures only 5 inputs are taken 
            n1(count) = Val(TextBox1.Text)
            Label3.Text = Label3.Text & Str(n1(count)) & Space(3)
            count += 1
            TextBox1.Clear()
            TextBox1.Focus()

        Else
            MessageBox.Show("You can enter only 5 numbers!")
        End If


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sum As Integer = 0
        Dim avg As Double

        For j = 0 To 4 ' Fix: Use correct index range
            sum = sum + n1(j)
        Next

        Label10.Text = sum.ToString()
        avg = sum / 5 ' Calculate average
        Label6.Text = avg.ToString()

        If avg > 80 Then
            Label8.Text = "A"
        ElseIf avg > 60 And avg < 80 Then
            Label8.Text = "B"
        ElseIf avg > 40 And avg < 60 Then
            Label8.Text = "C"
        Else
            Label8.Text = "FAIL"
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        Label3.Text = " "
        Label6.Text = " "
        Label8.Text = " "
        Label10.Text = " "

        count = 0
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sum As Integer
        For j = 0 To 4 ' Fix: Use correct index range
            sum = sum + n1(j)
        Next

        Label10.Text = sum.ToString()
    End Sub
End Class
