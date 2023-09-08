Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim title As String
        Dim msg As String
        title = txtTitle.Text

        Dim Part1 As String
        Part1 = txtPart1.Text
        Dim Part2 As String
        Part2 = txtPart2.Text
        Dim Part3 As String
        Part3 = txtPart3.Text
        msg = MsgBox(Part1 & vbNewLine & Part2 & vbNewLine & Part3, MsgBoxStyle.DefaultButton1, title)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class
