Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A1(4, 3) As String
        A1(0, 0) = "1.00"
        A1(0, 1) = "1.50"
        A1(0, 2) = "1.65"
        A1(0, 3) = "1.85"
        A1(1, 0) = "1.58"
        A1(1, 1) = "2.00"
        A1(1, 2) = "2.40"
        A1(1, 3) = "3.05"
        A1(2, 0) = "1.71"
        A1(2, 1) = "2.52"
        A1(2, 2) = "3.10"
        A1(2, 3) = "4.00"
        A1(3, 0) = "2.04"
        A1(3, 1) = "3.12"
        A1(3, 2) = "4.00"
        A1(3, 3) = "5.01"
        A1(4, 0) = "2.52"
        A1(4, 1) = "3.75"
        A1(4, 2) = "5.10"
        A1(4, 3) = "7.25"

        TextBox1.Text = A1(weightListBox.SelectedIndex, zoneListBox.SelectedIndex)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles TextBox1.Click

    End Sub
End Class
