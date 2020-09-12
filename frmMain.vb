Public Class frmMain
    Dim Bmp As New Bitmap(1, 1)
    Dim G As Graphics = Graphics.FromImage(Bmp)
    Dim HEX As String = ""
    Dim c As Color
    Dim IsLocked As Boolean = False

#Region "Colors"

    '   ultradark: #FF141617
    '   darkgray: #FF1C2023
    '   midgray: #FF141617
    '   gray: #FF282C2F
    '   lightergray: #FF627582
    '   lightgray: #FFE2E6E9 
    '   blue: #FF368BFC
    '   red: #FFDC3546

#End Region

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        G.CopyFromScreen(Cursor.Position, Point.Empty, Bmp.Size)
        c = Bmp.GetPixel(0, 0)
        btnLock.BackColor = c
        HEX = ColorTranslator.ToHtml(c).ToString

        Me.txtHEX.Text = HEX
        Me.txtMSHEX.Text = "#FF" + HEX.Remove(0, 1)
        Me.txtRGB.Text = c.R.ToString + ", " + c.G.ToString + ", " + c.B.ToString
        Me.txtCMYK.Text = ConvertRgbToCmyk(c.R, c.G, c.B)
        Me.txtHSV.Text = ConvertColorToHSV(c)
        Me.txtPosition.Text = "X:" + MousePosition.X.ToString + " Y:" + MousePosition.Y.ToString

    End Sub

    Private Sub ToggleLock()
        If IsLocked Then
            IsLocked = False
            Me.lblPressAny.Visible = True
            Me.picLock.Visible = False
            Timer1.Start()
        Else
            IsLocked = True
            Me.lblPressAny.Visible = False
            Me.picLock.Visible = True
            Timer1.Stop()
            My.Computer.Clipboard.SetText(HEX)
        End If
    End Sub

#Region "Color Converters"

    Public Function ConvertRgbToCmyk(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As String
        Dim c As Single
        Dim m As Single
        Dim y As Single
        Dim k As Single
        Dim rf As Single
        Dim gf As Single
        Dim bf As Single
        rf = r / 255.0F
        gf = g / 255.0F
        bf = b / 255.0F
        k = ClampCmyk(1 - Math.Max(Math.Max(rf, gf), bf))
        c = ClampCmyk((1 - rf - k) / (1 - k))
        m = ClampCmyk((1 - gf - k) / (1 - k))
        y = ClampCmyk((1 - bf - k) / (1 - k))

        c = Math.Round(c * 100, 0)
        m = Math.Round(m * 100, 0)
        y = Math.Round(y * 100, 0)
        k = Math.Round(k * 100, 0)

        Return c.ToString + ", " + m.ToString + ", " + y.ToString + ", " + k.ToString
    End Function

    Private Function ClampCmyk(ByVal value As Single) As Single
        If value < 0 OrElse Single.IsNaN(value) Then
            value = 0
        End If
        Return value
    End Function

    Private Function ConvertColorToHSV(ByVal Color As Color) As String

        Dim max As Integer = Math.Max(Color.R, Math.Max(Color.G, Color.B))
        Dim min As Integer = Math.Min(Color.R, Math.Min(Color.G, Color.B))
        Dim hue = Color.GetHue()
        Dim saturation = If((max = 0), 0, 1.0R - (1.0R * min / max))
        Dim value = max / 255.0R
        hue = Math.Round(hue, 0)
        saturation = Math.Round(saturation * 100, 0)
        value = Math.Round(value * 100, 0)
        Return hue.ToString + ", " + saturation.ToString + ", " + value.ToString

    End Function

#End Region

#Region "Button Presses"

    Private Sub btnCopy1_Click(sender As Object, e As EventArgs) Handles btnCopy1.Click
        My.Computer.Clipboard.SetText(Me.txtHEX.Text)
    End Sub

    Private Sub btnCopy2_Click(sender As Object, e As EventArgs) Handles btnCopy2.Click
        My.Computer.Clipboard.SetText(Me.txtMSHEX.Text)
    End Sub

    Private Sub btnCopy3_Click(sender As Object, e As EventArgs) Handles btnCopy3.Click
        My.Computer.Clipboard.SetText(Me.txtRGB.Text)
    End Sub

    Private Sub btnCopy4_Click(sender As Object, e As EventArgs) Handles btnCopy4.Click
        My.Computer.Clipboard.SetText(Me.txtCMYK.Text)
    End Sub

    Private Sub btnCopy5_Click(sender As Object, e As EventArgs) Handles btnCopy5.Click
        My.Computer.Clipboard.SetText(Me.txtHSV.Text)
    End Sub

    Private Sub btnCopy6_Click(sender As Object, e As EventArgs) Handles btnCopy6.Click
        My.Computer.Clipboard.SetText(Me.txtPosition.Text)
    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        ToggleLock()
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then e.SuppressKeyPress = True
        ToggleLock()
    End Sub

#End Region

End Class
