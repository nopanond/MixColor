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
        txtGreen.Text = GreenColor
        lblGreen.ForeColor = Color.FromArgb(0, GreenColor, 0)
        txtGreen.ForeColor = Color.FromArgb(0, GreenColor, 0)
        MixColor()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Red color
        RedColor = 128
        txtRed.ForeColor = Color.FromArgb(RedColor, 0, 0)
        trcRed.Value = RedColor
        lblRed.Text = RedColor
        txtRed.Text = RedColor

        'Green color
        GreenColor = 128
        txtGreen.ForeColor = Color.FromArgb(0, GreenColor, 0)
        trcGreen.Value = GreenColor
        lblGreen.Text = GreenColor
        txtGreen.Text = GreenColor

        'Blue color
        BlueColor = 128
        txtBlue.ForeColor = Color.FromArgb(0, 0, BlueColor)
        trcBlue.Value = BlueColor
        lblBlue.Text = BlueColor
        txtBlue.Text = BlueColor

        'Transparent
        Transparent = 255
        trcTransparent.Value = Transparent
        lblTransparent.Text = Format(Transparent / 255, "0" & " %")
        txtTransparent.Text = Format(Transparent / 255, "0" & " %")

        MixColor()
    End Sub

    Private Sub txtRed_TextChanged(sender As Object, e As EventArgs) Handles txtRed.TextChanged
        If Val(txtRed.Text) > 255 Then
            txtRed.Text = 255
        End If

        RedColor = Val(txtRed.Text)

        lblRed.Text = RedColor
        txtRed.Text = RedColor
        trcRed.Value = RedColor
        lblRed.ForeColor = Color.FromArgb(0, RedColor, 0)
        txtRed.ForeColor = Color.FromArgb(0, RedColor, 0)
        MixColor()
    End Sub

    Private Sub txtGreen_TextChanged(sender As Object, e As EventArgs) Handles txtGreen.TextChanged
        If Val(txtGreen.Text) > 255 Then
            txtGreen.Text = 255
        End If

        GreenColor = Val(txtGreen.Text)

        lblGreen.Text = GreenColor
        txtGreen.Text = GreenColor
        trcGreen.Value = GreenColor
        lblGreen.ForeColor = Color.FromArgb(0, GreenColor, 0)
        txtGreen.ForeColor = Color.FromArgb(0, GreenColor, 0)
        MixColor()
    End Sub

    Private Sub trcBlue_Scroll(sender As Object, e As EventArgs) Handles trcBlue.Scroll
        BlueColor = Val(trcBlue.Value)
        lblBlue.Text = BlueColor
        txtBlue.Text = BlueColor
        lblBlue.ForeColor = Color.FromArgb(0, 0, BlueColor)
        txtBlue.ForeColor = Color.FromArgb(0, 0, BlueColor)
        MixColor()
    End Sub

    Private Sub txtBlue_TextChanged(sender As Object, e As EventArgs) Handles txtBlue.TextChanged
        If Val(txtBlue.Text) > 255 Then
            txtBlue.Text = 255
        End If

        BlueColor = Val(txtBlue.Text)

        lblBlue.Text = BlueColor
        txtBlue.Text = BlueColor
        trcBlue.Value = BlueColor
        lblBlue.ForeColor = Color.FromArgb(0, BlueColor, 0)
        txtBlue.ForeColor = Color.FromArgb(0, BlueColor, 0)
        MixColor()
    End Sub

    Private Sub trcTransparent_Scroll(sender As Object, e As EventArgs) Handles trcTransparent.Scroll
        Transparent = Val(trcTransparent.Value)
        txtTransparent.Text = Format(Transparent / 255, "0" & " %")
        lblTransparent.Text = Format(Transparent / 255, "0" & " %")
        MixColor()
    End Sub

    Private Sub trcRed_Scroll(sender As Object, e As EventArgs) Handles trcRed.Scroll
        RedColor = Val(trcRed.Value)
        lblRed.Text = RedColor
        txtRed.Text = RedColor
        txtRed.ForeColor = Color.FromArgb(RedColor, 0, 0)
        lblRed.ForeColor = Color.FromArgb(RedColor, 0, 0)
        MixColor()
    End Sub

    Private Sub txtGreen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGreen.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57 ' Ascii Code 48-57 คือเลขตั้งแต่ 0 ถึง 9 ตามลำดับ, ปุ่ม Backspace = 8 , ปุ่ม Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtBlue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBlue.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57 ' Ascii Code 48-57 คือเลขตั้งแต่ 0 ถึง 9 ตามลำดับ, ปุ่ม Backspace = 8 , ปุ่ม Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtRed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRed.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57 ' Ascii Code 48-57 คือเลขตั้งแต่ 0 ถึง 9 ตามลำดับ, ปุ่ม Backspace = 8 , ปุ่ม Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class