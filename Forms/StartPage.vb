Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class StartPage

    Dim SelectedXType

    Public MasterGapsDT As DataTable

    Public SelectedScreen As Integer


    Private Sub FmOpening_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VersionNumber(LblVer, Me)

        MasterGapsDT = New DataTable

        If MasterGapsDT.Columns.Count = 0 Then
            MasterGapsDT.Columns.Add("RunName")
            MasterGapsDT.Columns.Add("Spindles")
            MasterGapsDT.Columns.Add("Gaps")
            MasterGapsDT.Columns.Add("XType")
            MasterGapsDT.Columns.Add("DimX")
            MasterGapsDT.Columns.Add("SpindleX")
            MasterGapsDT.Columns.Add("Reducer")
        End If

        SelectedScreen = 0

        DetectMonitors()

        WindowState = FormWindowState.Maximized

        ResizeForm()

        TestForSummary()

    End Sub

    Private Sub DetectMonitors()

        If Screen.AllScreens.Length > 1 Then

            SelectedScreen = GetScreenNumber()

            SetButtons()

        End If

    End Sub

    Private Function GetScreenNumber()

        Dim FoundScreen As Integer

        Dim s = Screen.FromControl(Me)

        Select Case s.DeviceName

            Case "\\.\DISPLAY1"
                FoundScreen = 0

            Case "\\.\DISPLAY2"
                FoundScreen = 1

            Case "\\.\DISPLAY3"
                FoundScreen = 2

        End Select

        Return FoundScreen

    End Function

    Private Sub ResizeForm()

        Dim ScreenWidth = Screen.AllScreens(SelectedScreen).Bounds.Width

        Dim PanelWidth = ScreenWidth / 4

        PnlLeft.Width = PanelWidth
        PnlRight.Width = PanelWidth

        PicOverall.Location = New Point(2, LblOveralRun.Height)
        PnlOverall.Width = PicOverall.Width + 6
        PnlOverall.Height = LblOveralRun.Height + PicOverall.Height + 5

        PicNeweltoOver.Location = New Point(2, LblNewelToOverall.Height)
        PnlNewelToOver.Width = PicNeweltoOver.Width + 6
        PnlNewelToOver.Height = LblNewelToOverall.Height + PicNeweltoOver.Height + 5

        PicBetween.Location = New Point(2, LblBetween.Height)
        PnlBetween.Width = PicBetween.Width + 6
        PnlBetween.Height = LblBetween.Height + PicBetween.Height + 5

        Dim PnlHeights = PnlOverall.Height + PnlNewelToOver.Height + PnlBetween.Height

        Dim VertGap = (PnlXType.Height - PnlHeights) / 4

        PnlOverall.Location = New Point((PnlXType.Width - PnlOverall.Width) / 2, VertGap)

        PnlNewelToOver.Location = New Point((PnlXType.Width - PnlNewelToOver.Width) / 2, PnlOverall.Height + (2 * VertGap))

        PnlBetween.Location = New Point((PnlXType.Width - PnlBetween.Width) / 2, PnlOverall.Height + PnlNewelToOver.Height + (3 * VertGap))

        BtnSelectAgain.Visible = False

        PnlDimX.Visible = False

        TxtX.Width = TxtX.MinimumSize.Width

        PnlDimX.Width = TxtX.MinimumSize.Width + Label3.Width + 10

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Application.Exit()

    End Sub

    Private Sub PicOverall_Click(sender As Object, e As EventArgs) Handles PicOverall.Click

        PnlNewelToOver.Visible = False

        PnlBetween.Visible = False

        ResetMessages(PnlOverall)

        SelectedXType = "Overall"

    End Sub

    Private Sub PicNeweltoOver_Click(sender As Object, e As EventArgs) Handles PicNeweltoOver.Click

        PnlBetween.Visible = False

        Dim Distance
        Dim SleepTime
        Dim StartLocationY

        Distance = PnlNewelToOver.Location.Y - PnlOverall.Location.Y
        SleepTime = Distance / 1000
        StartLocationY = PnlNewelToOver.Location.Y

        For i = 0 To Distance
            Dim NewLocationY = StartLocationY - i

            PnlNewelToOver.Location = New Point(PnlNewelToOver.Location.X, NewLocationY)

            Threading.Thread.Sleep(SleepTime)

            Refresh()

            If NewLocationY = PnlOverall.Location.Y + PnlOverall.Height Then

                PnlOverall.Visible = False

            End If

        Next

        ResetMessages(PnlNewelToOver)

        SelectedXType = "NewelToOver"

    End Sub

    Private Sub PicBetween_Click(sender As Object, e As EventArgs) Handles PicBetween.Click

        Dim Distance
        Dim SleepTime
        Dim StartLocationY

        Distance = PnlBetween.Location.Y - PnlOverall.Location.Y
        SleepTime = Distance / 1000
        StartLocationY = PnlBetween.Location.Y

        For i = 0 To Distance
            Dim NewLocationY = StartLocationY - i

            PnlBetween.Location = New Point(PnlBetween.Location.X, NewLocationY)

            Threading.Thread.Sleep(SleepTime)

            Refresh()

            If NewLocationY = PnlOverall.Location.Y + PnlOverall.Height Then

                PnlOverall.Visible = False

            End If

            If NewLocationY = PnlNewelToOver.Location.Y + PnlNewelToOver.Height Then

                PnlNewelToOver.Visible = False

            End If

        Next

        ResetMessages(PnlBetween)

        SelectedXType = "BetweenNewels"

    End Sub

    Private Sub ResetMessages(SenderType As Control)

        LblMessage.Text = "Enter 'X' Dimension"

        BtnSelectAgain.Visible = True


        PnlDimX.Location = New Point((PnlXType.Width - PnlDimX.Width) / 2, SenderType.Location.Y + SenderType.Height + 50)

        PnlDimX.Visible = True

        TxtX.Select()


    End Sub

    Private Sub BtnSelectAgain_Click(sender As Object, e As EventArgs) Handles BtnSelectAgain.Click

        PnlOverall.Visible = True
        PnlNewelToOver.Visible = True
        PnlBetween.Visible = True
        BtnCalculate.Visible = False

        ResizeForm()

        LblMessage.Text = "Select Dimension (X) Type ?"

        TxtX.Text = ""

    End Sub

    Private Sub TestForDimX()

        If TxtX.TextLength > 0 Then

            TxtX.Width = LblDimX.Width

            PnlDimX.Width = TxtX.Width + Label3.Width + 10

            PnlDimX.Location = New Point((PnlXType.Width - PnlDimX.Width) / 2, PnlDimX.Location.Y)

            TxtX.SelectionStart = 0

            TxtX.SelectionStart = TxtX.TextLength

            PnlSpindleX.Location = New Point((PnlXType.Width - PnlSpindleX.Width) / 2, PnlDimX.Location.Y + PnlDimX.Height + 50)

            PnlSpindleX.Visible = True

            'TxtSpindleX.Select()

            TestForCalculate()

        Else
            PnlSpindleX.Visible = False
        End If

    End Sub

    Public Sub TestForSummary()

        If MasterGapsDT.Rows.Count > 0 Then
            BtnSummary.Visible = True
        Else
            BtnSummary.Visible = False
        End If
    End Sub

    Private Sub TestForCalculate()

        If TxtX.TextLength > 0 And TxtSpindleX.TextLength > 0 Then

            BtnCalculate.Visible = True

        Else

            BtnCalculate.Visible = False

        End If
    End Sub

    Private Sub TxtX_TextChanged(sender As Object, e As EventArgs) Handles TxtX.TextChanged

        LblDimX.Text = TxtX.Text

        TestForDimX()

    End Sub

    Private Sub TxtSpindleX_TextChanged(sender As Object, e As EventArgs) Handles TxtSpindleX.TextChanged

        TestForCalculate()

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        Try

            Dim FmCalculations As New Calculations

            With FmCalculations
                .SelectedXType = SelectedXType
                .DimX = TxtX.Text
                .SpindleX = TxtSpindleX.Text
                .MasterGapsDT = MasterGapsDT
                .StartPosition = FormStartPosition.Manual
                .Location = Screen.AllScreens(SelectedScreen).Bounds.Location
                .SelectedScreen = SelectedScreen
            End With

            FmCalculations.Show()

            Hide()

        Catch ex As Exception

            MsgBox("Something was wrong " & vbCr & "Go BACK and check the dims",, "Check the dims")
        End Try
    End Sub


    Private Sub BtnPrimaryScreen_Click(sender As Object, e As EventArgs) Handles BtnPrimaryScreen.Click

        SelectedScreen = 0

        SetButtons()

        WindowState = FormWindowState.Normal

        Bounds = Screen.AllScreens(SelectedScreen).Bounds

        StartPosition = FormStartPosition.Manual

        Location = Screen.AllScreens(SelectedScreen).Bounds.Location

        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub BtnOtherScreen1_Click(sender As Object, e As EventArgs) Handles BtnOtherScreen1.Click

        SelectedScreen = 1

        SetButtons()

        WindowState = FormWindowState.Normal

        Bounds = Screen.AllScreens(SelectedScreen).Bounds

        StartPosition = FormStartPosition.Manual

        Location = Screen.AllScreens(SelectedScreen).Bounds.Location

        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub BtnOtherScreen2_Click(sender As Object, e As EventArgs) Handles BtnOtherScreen2.Click

        SelectedScreen = 2

        SetButtons()

        WindowState = FormWindowState.Normal

        Bounds = Screen.AllScreens(SelectedScreen).Bounds

        StartPosition = FormStartPosition.Manual

        Location = Screen.AllScreens(SelectedScreen).Bounds.Location

        WindowState = FormWindowState.Maximized

    End Sub


    Private Sub SetButtons()

        BtnPrimaryScreen.Visible = False
        BtnOtherScreen1.Visible = False
        BtnOtherScreen2.Visible = False

        Select Case SelectedScreen

            Case 0
                BtnPrimaryScreen.Visible = False
                BtnOtherScreen1.Visible = True
                BtnOtherScreen2.Visible = True

            Case 1
                BtnPrimaryScreen.Visible = True
                BtnOtherScreen1.Visible = False
                BtnOtherScreen2.Visible = True

            Case 2
                BtnPrimaryScreen.Visible = True
                BtnOtherScreen1.Visible = True
                BtnOtherScreen2.Visible = False

        End Select

    End Sub

    Private Sub BtnSummary_Click(sender As Object, e As EventArgs) Handles BtnSummary.Click

        Dim FmSummary As New Summary

        With FmSummary
            .SummaryDT = MasterGapsDT
            .StartPosition = FormStartPosition.Manual
            .Location = Screen.AllScreens(SelectedScreen).Bounds.Location
        End With

        FmSummary.Show()

        Hide()

    End Sub

End Class
