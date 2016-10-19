Public Class Form1
    Dim word = "TOMMY"


    Dim corrects = New Boolean() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button31.Click, Button30.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        testPress((DirectCast(sender, Button).Text))

        MsgBox(corrects(0) & corrects(1) & corrects(2) & corrects(3) & corrects(4))
    End Sub



    Function testPress(check As String)
        For i = 0 To word.length - 1
            If check = word.Substring(i, 1) Then
                corrects(i) = 1
            End If

        Next
    End Function














    ' Dim wordL = word.length
    ' Dim labels = New Label() {New Label, New Label, New Label, New Label}
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    For i = 0 To 3

    '        labels(i).Location = New System.Drawing.Point(200 + i * 70, 100)
    '        labels(i).Text = "her " & i
    '        Me.Controls.Add(labels(i))
    '    Next

    'End Sub

End Class
