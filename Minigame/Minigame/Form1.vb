Public Class Form1
    Dim ImpostNumber As Int16
    Dim points As Int32
    Dim Randimage As Int16
    Dim Rand As Random = New Random

    Function PictureRandomizer()
        Randimage = Rand.Next(1, 6)
        If Randimage = 1 Then
            PictureBox1.Image = My.Resources.B
        End If
        If Randimage = 2 Then
            PictureBox1.Image = My.Resources.BL
        End If
        If Randimage = 3 Then
            PictureBox1.Image = My.Resources.Y
        End If
        If Randimage = 4 Then
            PictureBox1.Image = My.Resources.O
        End If
        If Randimage = 5 Then
            PictureBox1.Image = My.Resources.P
        End If
        'end code for image1

        ''Code for image 2
        Randimage = Rand.Next(1, 6)
        If Randimage = 1 Then
            PictureBox2.Image = My.Resources.B
        End If
        If Randimage = 2 Then
            PictureBox2.Image = My.Resources.BL
        End If
        If Randimage = 3 Then
            PictureBox2.Image = My.Resources.Y
        End If
        If Randimage = 4 Then
            PictureBox2.Image = My.Resources.O
        End If
        If Randimage = 5 Then
            PictureBox2.Image = My.Resources.P
        End If
        'end code for image2

        ''Code for image 2
        Randimage = Rand.Next(1, 6)
        If Randimage = 1 Then
            PictureBox3.Image = My.Resources.B
        End If
        If Randimage = 2 Then
            PictureBox3.Image = My.Resources.BL
        End If
        If Randimage = 3 Then
            PictureBox3.Image = My.Resources.Y
        End If
        If Randimage = 4 Then
            PictureBox3.Image = My.Resources.O
        End If
        If Randimage = 5 Then
            PictureBox3.Image = My.Resources.P
        End If
        'end code for image2
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImpostNumber = Rand.Next(1, 4)
        PictureRandomizer()

    End Sub
End Class
