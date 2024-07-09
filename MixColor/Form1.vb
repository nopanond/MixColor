Public Class Form1
    'Dev By Nopanond Ch
    Dim RedColor, GreenColor, BlueColor, Transparent As Integer
    Public Function MixColor()
        lblColor.BackColor = Color.FromArgb(Transparent, RedColor, GreenColor, BlueColor)

        'Change ForColor
        If RedColor >= 128 Or GreenColor >= 128 Or BlueColor >= 128 Then
            lblColor.ForeColor = Color.Black
        Else
            lblColor.ForeColor = Color.White
        End If

        lblColor.Text = "#" & Transparent.ToString("X2") & RedColor.ToString("X2") & GreenColor.ToString("X2") & BlueColor.ToString("X2")
    End Function









    Private Sub trcGreen_Scroll(sender As Object, e As EventArgs) Handles trcGreen.Scroll
        GreenColor = Val(trcGreen.Value)
        lblGreen.Text = GreenColor
        lblGreen.ForeColor = Color.FromArgb(0, GreenColor, 0)
        MixColor()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Red color
        RedColor = 128
        trcRed.Value = RedColor
        lblRed.Text = RedColor


        'Green color
        GreenColor = 128
        trcGreen.Value = GreenColor
        lblGreen.Text = GreenColor
        lblGreen.ForeColor = Color.FromArgb(0, GreenColor, 0)

        'Blue color
        BlueColor = 128
        trcBlue.Value = BlueColor
        lblBlue.Text = BlueColor
        lblBlue.ForeColor = Color.FromArgb(0, 0, BlueColor)

        'Transparent
        Transparent = 255
        trcTransparent.Value = Transparent
        lblTransparent.Text = Format(Transparent / 255, "0" & " %")

        MixColor()
    End Sub



    Private Sub trcBlue_Scroll(sender As Object, e As EventArgs) Handles trcBlue.Scroll
        BlueColor = Val(trcBlue.Value)
        lblBlue.Text = BlueColor
        lblBlue.ForeColor = Color.FromArgb(0, 0, BlueColor)
        MixColor()
    End Sub

    Private Sub trcTransparent_Scroll(sender As Object, e As EventArgs) Handles trcTransparent.Scroll
        Transparent = Val(trcTransparent.Value)
        lblTransparent.Text = Format(Transparent / 255, "0" & " %")
        MixColor()
    End Sub

    Private Sub trcRed_Scroll(sender As Object, e As EventArgs) Handles trcRed.Scroll
        RedColor = Val(trcRed.Value)
        lblRed.Text = RedColor
        lblRed.ForeColor = Color.FromArgb(RedColor, 0, 0)
        MixColor()
    End Sub
End Class