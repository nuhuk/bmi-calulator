Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim height As Single = Single.Parse(TextBox1.Text) / 100
            Dim weight As Single = Single.Parse(TextBox2.Text)
            Dim result As Single = weight / height ^ 2
            Select Case result
                Case 0 To 18.5
                    RichTextBox1.AppendText($"Your BMI " & result.ToString & ", which is under weight...")
                Case 18.5 To 24.9
                    RichTextBox1.AppendText($"Your BMI " & result.ToString & ", that is normal weight.")
                Case 25 To 29.9
                    RichTextBox1.AppendText($"Your BMI " & result.ToString & ", you are over weight...")
                Case 30 To 200
                    RichTextBox1.AppendText($"Your BMI " & result.ToString & ", you are obese")
                Case Else
                    MessageBox.Show("Kindly add your height and weight, thank you.")
            End Select
        Catch ex As FormatException
            MessageBox.Show("Please enter valid numeric values for height and weight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
