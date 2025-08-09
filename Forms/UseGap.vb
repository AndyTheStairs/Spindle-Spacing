Public Class UseGap

    Dim mousex
    Dim mousey

    Public DisplayedGap
    Public DT As DataTable
    Public FoundIndex As Integer
    Public UseSpindleCount
    Public LocationY
    Public LocationX
    Public Reducer

    Private Sub UseGap_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim Gap = Mid(DisplayedGap, 1, InStr(DisplayedGap, "mm") - 1)

        LblStdRounded.Text = Gap & "mm"
        LblRedRounded.Text = Gap - Reducer & "mm"

        Dim FoundDimX = DT(FoundIndex)("DimX")
        Dim FoundXType = DT(FoundIndex)("XType")
        Dim FoundSpindleX = DT(FoundIndex)("SpindleX")

        Dim CalculatedGap = CalculateGap(UseSpindleCount, FoundXType, FoundDimX, FoundSpindleX)

        LblStdCalculated.Text = CalculatedGap & "mm"
        LblRedCalculated.Text = CalculatedGap - Reducer & "mm"

        Location = New Point(LocationX, LocationY)

    End Sub

    Private Sub ImgClip_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ImgClip.MouseDown

        If e.Button = MouseButtons.Right Then
            mousex = Cursor.Position.X - Me.Left
            mousey = Cursor.Position.Y - Me.Top
        End If

    End Sub

    Private Sub ImgClip_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ImgClip.MouseMove

        If e.Button = MouseButtons.Right Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        DialogResult = DialogResult.OK

    End Sub

    Private Function CalculateGap(SpindleCount, XType, DimX, SpindleX)
        Dim Gap As Double

        Select Case XType
            Case "Overall"
                Gap = (DimX - (SpindleX * SpindleCount)) / (SpindleCount - 1)

            Case "NewelToOver"
                Gap = (DimX - (SpindleX * SpindleCount)) / (SpindleCount)

            Case "BetweenNewels"
                Gap = (DimX + (2 * Reducer) - (SpindleX * SpindleCount)) / (SpindleCount + 1)

        End Select

        'Gap = Math.Round(Gap, 2)

        Return Gap

    End Function

    Private Sub LblStdRounded_MouseHover(sender As Object, e As EventArgs) Handles LblStdRounded.MouseHover

        PnlStdRoundedBorder.BackColor = Color.Red
        PnlStdCalcBorder.BackColor = SystemColors.Control
        PnlRedRoundedBorder.BackColor = SystemColors.Control
        PnlRedCalcBorder.BackColor = SystemColors.Control

    End Sub

    Private Sub LblStdCalculated_MouseHover(sender As Object, e As EventArgs) Handles LblStdCalculated.MouseHover

        PnlStdCalcBorder.BackColor = Color.Red
        PnlStdRoundedBorder.BackColor = SystemColors.Control
        PnlRedRoundedBorder.BackColor = SystemColors.Control
        PnlRedCalcBorder.BackColor = SystemColors.Control

    End Sub

    Private Sub LblRedRounded_MouseHover(sender As Object, e As EventArgs) Handles LblRedRounded.MouseHover

        PnlRedRoundedBorder.BackColor = Color.Red
        PnlRedCalcBorder.BackColor = SystemColors.Control
        PnlStdRoundedBorder.BackColor = SystemColors.Control
        PnlStdCalcBorder.BackColor = SystemColors.Control

    End Sub

    Private Sub LblRedCalculated_MouseHover(sender As Object, e As EventArgs) Handles LblRedCalculated.MouseHover

        PnlRedCalcBorder.BackColor = Color.Red
        PnlRedRoundedBorder.BackColor = SystemColors.Control
        PnlStdRoundedBorder.BackColor = SystemColors.Control
        PnlStdCalcBorder.BackColor = SystemColors.Control

    End Sub

    Private Sub LblStdRounded_TextChanged(sender As Object, e As EventArgs) Handles LblStdRounded.TextChanged

        PnlStdRoundedBorder.Width = LblStdRounded.PreferredWidth + 6
        PnlStdRoundedBorder.Height = LblStdRounded.PreferredHeight + 6

    End Sub

    Private Sub LblStdCalculated_TextChanged(sender As Object, e As EventArgs) Handles LblStdCalculated.TextChanged

        PnlStdCalcBorder.Width = LblStdCalculated.PreferredWidth + 6
        PnlStdCalcBorder.Height = LblStdCalculated.PreferredHeight + 6

    End Sub

    Private Sub LblRedRounded_TextChanged(sender As Object, e As EventArgs) Handles LblRedRounded.TextChanged

        PnlRedRoundedBorder.Width = LblRedRounded.PreferredWidth + 6
        PnlRedRoundedBorder.Height = LblRedRounded.PreferredHeight + 6

    End Sub

    Private Sub LblRedCalculated_TextChanged(sender As Object, e As EventArgs) Handles LblRedCalculated.TextChanged

        PnlRedCalcBorder.Width = LblRedCalculated.PreferredWidth + 6
        PnlRedCalcBorder.Height = LblRedCalculated.PreferredHeight + 6

    End Sub

    Private Sub CopyToClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToClipboardToolStripMenuItem.Click

        Dim GapToClip = Mid(LblStdRounded.Text, 1, (Len(LblStdRounded.Text) - 2))

        My.Computer.Clipboard.SetText(GapToClip)

        DialogResult = DialogResult.OK

    End Sub

    Private Sub CopyToClipboardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToClipboardToolStripMenuItem1.Click

        Dim GapToClip = Mid(LblStdCalculated.Text, 1, (Len(LblStdCalculated.Text) - 2))

        My.Computer.Clipboard.SetText(GapToClip)

        DialogResult = DialogResult.OK

    End Sub

    Private Sub CopyToClipboardToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CopyToClipboardToolStripMenuItem2.Click

        Dim GapToClip = Mid(LblRedRounded.Text, 1, (Len(LblRedRounded.Text) - 2))

        My.Computer.Clipboard.SetText(GapToClip)

        DialogResult = DialogResult.OK

    End Sub

    Private Sub CopyToClipboardToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CopyToClipboardToolStripMenuItem3.Click

        Dim GapToClip = Mid(LblRedCalculated.Text, 1, (Len(LblRedCalculated.Text) - 2))

        My.Computer.Clipboard.SetText(GapToClip)

        DialogResult = DialogResult.OK

    End Sub
End Class