Public Class Calculations

    Public SelectedXType
    Public DimX As Double
    Public SpindleX
    Dim GapOptionsDT As DataTable
    Public MasterGapsDT As DataTable
    Dim PanelLocationX As Integer
    Dim PanelLocationY As Integer
    Dim RowsCount As Integer
    Dim SpindleCount As Integer
    Dim WidthPnlDetails
    Dim OptimalGap As Double
    Dim ActualDimX
    Dim Reducer As Double
    Public SelectedScreen As Integer


    Private Sub Calculations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WidthPnlDetails = 0

        VersionNumber(LblVer, Me)

        SelectPicture()

        'RePositionControls()

        PanelLocationX = PnlRow1.Location.X
        PanelLocationY = PnlRow1.Location.Y + PnlRow1.Height + 10

        TestForSummary()

    End Sub

    Private Sub SelectPicture()

        Dim SelectedPicture As Image = Nothing
        Dim TypeText = ""

        Select Case SelectedXType

            Case "Overall"

                SelectedPicture = My.Resources.SpindlesDim1
                TypeText = "Overall Run"


            Case "NewelToOver"

                SelectedPicture = My.Resources.SpindlesDim2
                TypeText = "Newel to Overall"
                BtnFirst.Visible = True

            Case "BetweenNewels"

                SelectedPicture = My.Resources.SpindlesDim3
                TypeText = "Between Newels"
                BtnFirst.Visible = True

        End Select

        CalcGaps()
        PicSelectedType.Image = SelectedPicture
        PicGaps.Image = My.Resources.Gap_Std1
        LblDimType.Text = TypeText

        Dim Dim_X_Rounded = Math.Round(DimX, 2)

        LblDimX.Text = Dim_X_Rounded & "mm"
        LblSpindleX.Text = SpindleX & "mm"

        RePositionControls()

    End Sub

    Private Sub RePositionControls()

        Dim fff = PnlPic.Height / PicSelectedType.Height * PicSelectedType.Width

        Dim PicWidth = PicSelectedType.Width
        Dim DimWidth = LblDimX.Width

        WidthPnlDetails = PnlDetails.Width

        'If PicSelectedType.Width + 20 > WidthPnlDetails Then
        '    WidthPnlDetails = PicSelectedType.Width + 20
        'End If

        'PnlDimX.Location = New Point(PicSelectedType.Location.X, PicSelectedType.Location.Y + PicSelectedType.Height + 30)

        'PnlSpindleX.Location = New Point(PicSelectedType.Location.X, PnlDimX.Location.Y + PnlDimX.Height + 30)

        ' PnlDimX.Width = LblDimX.Width + 10

        If DimWidth > PicWidth Then
            PnlDetails.Width = DimWidth
        Else
            PnlDetails.Width = PicWidth
        End If
        ' WidthPnlDetails = PnlDimX.Width + 20


        ' PnlDetails.Width = WidthPnlDetails

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        StartPage.Show()

        StartPage.TestForSummary()

        Close()

    End Sub

    Private Sub CalcGaps()

        Dim MaxRunningDim = 99 + SpindleX
        Dim DimToCheck As Integer
        Dim WholeDivide As Double

        'Dim OptimalGap As Double

        Select Case SelectedXType
            Case "Overall"
                DimToCheck = DimX - SpindleX
                WholeDivide = DimToCheck / MaxRunningDim
                If WholeDivide - Int(WholeDivide) = 0 Then
                    SpindleCount = WholeDivide + 1
                    LblSpindleOpti.Text = SpindleCount + 1
                Else
                    SpindleCount = Int(WholeDivide) + 2
                    LblSpindleOpti.Text = SpindleCount + 1
                End If

            Case "NewelToOver"
                DimToCheck = DimX
                WholeDivide = DimToCheck / MaxRunningDim
                If WholeDivide - Int(WholeDivide) = 0 Then
                    SpindleCount = WholeDivide
                    LblSpindleOpti.Text = SpindleCount
                Else
                    SpindleCount = Int(WholeDivide) + 1
                    LblSpindleOpti.Text = SpindleCount
                End If

            Case "BetweenNewels"
                If TxtReduce_r.Visible = True Then
                    DimToCheck = DimX + (2 * TxtReduce_r.Text) - 99
                Else
                    DimToCheck = DimX
                End If

                WholeDivide = DimToCheck / MaxRunningDim
                If WholeDivide - Int(WholeDivide) = 0 Then
                    SpindleCount = WholeDivide
                    LblSpindleOpti.Text = SpindleCount
                Else
                    SpindleCount = Int(WholeDivide) + 1
                    LblSpindleOpti.Text = SpindleCount
                End If

        End Select

        ActualDimX = DimToCheck

        OptimalGap = CalculateGap(SpindleCount)

        Dim RoundedOptiGap = Math.Round(OptimalGap, 2)



        LblGapOpti.Text = RoundedOptiGap & "mm"
        RowsCount = 1

        GapOptionsDT = New DataTable

        If GapOptionsDT.Columns.Count = 0 Then
            GapOptionsDT.Columns.Add("Spindles")
            GapOptionsDT.Columns.Add("Gaps")
            GapOptionsDT.Columns.Add("XType")
            GapOptionsDT.Columns.Add("DimX")
            GapOptionsDT.Columns.Add("SpindleX")
        End If

        Dim NewRow = GapOptionsDT.NewRow

        NewRow("Spindles") = SpindleCount
        NewRow("Gaps") = OptimalGap
        NewRow("XType") = SelectedXType
        NewRow("DimX") = DimX
        NewRow("SpindleX") = SpindleX

        GapOptionsDT.Rows.Add(NewRow)

        If LblGapOpti.Width < PnlGapTitle.Width Then
            LblGapOpti.Width = PnlGapTitle.Width
        Else
            PnlGapTitle.Width = LblGapOpti.Width
        End If

        PnlGapTable.Width = 20 + LblSpindleOpti.Width + Panel2.Width + LblGapOpti.Width + Panel10.Width + LblGapFirst.Width + 20 + 6

    End Sub

    Private Function CalculateGap(SpindleCount)
        Dim Gap As Double

        Select Case SelectedXType
            Case "Overall"
                Gap = (ActualDimX - (SpindleX * SpindleCount)) / (SpindleCount)

            Case "NewelToOver"
                Gap = (ActualDimX - (SpindleX * SpindleCount)) / (SpindleCount)

            Case "BetweenNewels"
                Gap = (ActualDimX - (SpindleX * SpindleCount)) / (SpindleCount + 1)

        End Select

        Return Gap

    End Function

    Private Sub BtnAddSpindle_Click(sender As Object, e As EventArgs) Handles BtnAddSpindle.Click

        Dim NewPanel As Panel
        Dim NewLabelSpindles As Label
        Dim NewLabelGap As Label
        Dim NewLabelFirstGap As Label
        Dim NewSpindleCount

        NewSpindleCount = RowsCount + SpindleCount

        NewPanel = New Panel
        NewLabelSpindles = New Label
        NewLabelGap = New Label
        NewLabelFirstGap = New Label

        With NewPanel
            .Width = PnlRow1.Width
            .Height = PnlRow1.Height
            .Location = New Point(PanelLocationX, PanelLocationY)
            .Padding = New Padding(5)
        End With

        With NewLabelSpindles
            .Location = LblSpindleOpti.Location
            .BorderStyle = BorderStyle.FixedSingle
            .Size = New Size(LblSpindleOpti.Width, LblSpindleOpti.Height)
            .Text = NewSpindleCount
            .Font = LblSpindleOpti.Font
        End With

        Dim NewGap = Math.Round((CalculateGap(SpindleCount + RowsCount)), 2)

        With NewLabelGap
            .Location = LblGapOpti.Location
            .BorderStyle = BorderStyle.FixedSingle
            .Size = New Size(LblGapOpti.Width, LblGapOpti.Height)
            .Text = NewGap & "mm"
            .Font = LblGapOpti.Font
        End With

        Dim NewGapFirst = 0

        If TxtReduce_r.Visible = True Then
            NewGapFirst = Math.Round((CalculateGap(SpindleCount + RowsCount)), 2) - TxtReduce_r.Text
        End If

        With NewLabelFirstGap
            .Location = LblGapFirst.Location
            .BorderStyle = BorderStyle.FixedSingle
            .Size = New Size(LblGapFirst.Width, LblGapFirst.Height)
            .Text = NewGapFirst & "mm"
            .Font = LblGapFirst.Font
        End With

        'AddHandler NewPanel.Click, AddressOf ClickedAGap
        AddHandler NewLabelSpindles.Click, AddressOf ClickedSpindles
        AddHandler NewLabelGap.Click, AddressOf ClickedAGap
        AddHandler NewLabelFirstGap.Click, AddressOf ClickedAFirstGap

        NewPanel.Controls.Add(NewLabelSpindles)
        NewPanel.Controls.Add(NewLabelGap)

        If TxtReduce_r.Visible = True Then
            NewPanel.Controls.Add(NewLabelFirstGap)
        End If

        PnlTable.Controls.Add(NewPanel)


        PanelLocationY += NewPanel.Height + 10

        RowsCount += 1

        Dim NewRow = GapOptionsDT.NewRow

        NewRow("Spindles") = NewSpindleCount
        NewRow("Gaps") = NewGap
        NewRow("XType") = SelectedXType
        NewRow("DimX") = DimX
        NewRow("SpindleX") = SpindleX

        GapOptionsDT.Rows.Add(NewRow)

    End Sub

    Private Sub ClickedSpindles(sender As Object, e As EventArgs)

        Dim FoundValue = DirectCast(sender.text, String)

        MsgBox("Use " & FoundValue & " spindles")

    End Sub

    Private Sub ClickedAGap(sender As Object, e As EventArgs)

        Dim FoundText = DirectCast(sender.text, String)

        Dim FoundValue = Mid(FoundText, 1, (FoundText.Length - 2))

        My.Computer.Clipboard.SetText(FoundValue)

        MsgBox("Use " & FoundText & " gap")

    End Sub

    Private Sub ClickedAFirstGap(sender As Object, e As EventArgs)

        Dim FoundText = DirectCast(sender.text, String)

        Dim FoundValue = Mid(FoundText, 1, (FoundText.Length - 2))

        My.Computer.Clipboard.SetText(FoundValue)

        MsgBox("Use " & FoundText & " First gap")

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim FmNameRun As New NameRun

        With FmNameRun
            .MasterGapsDT = MasterGapsDT
        End With

        If FmNameRun.ShowDialog = DialogResult.OK Then
            Dim RunName = FmNameRun.RunName

            Dim NewRow = MasterGapsDT.NewRow
            NewRow("RunName") = RunName
            NewRow("Spindles") = LblSpindleOpti.Text
            NewRow("Gaps") = LblGapOpti.Text
            NewRow("XType") = SelectedXType
            NewRow("DimX") = DimX
            NewRow("SpindleX") = SpindleX
            NewRow("Reducer") = Reducer

            MasterGapsDT.Rows.Add(NewRow)

            TestForSummary()

        End If

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

    Public Sub TestForSummary()

        If MasterGapsDT.Rows.Count > 0 Then
            BtnSummary.Visible = True
        Else
            BtnSummary.Visible = False
        End If
    End Sub

    Private Sub LblSpindleOpti_Click(sender As Object, e As EventArgs) Handles LblSpindleOpti.Click

        Dim FoundValue = DirectCast(sender.text, String)

        MsgBox("Use " & FoundValue & " spindles")

    End Sub

    Private Sub LblGapOpti_Click(sender As Object, e As EventArgs) Handles LblGapOpti.Click

        Dim FoundText = DirectCast(sender.text, String)

        Dim FoundValue = Mid(FoundText, 1, (FoundText.Length - 2))

        My.Computer.Clipboard.SetText(FoundValue)

        MsgBox("Use " & FoundText & " as STANDARD gap",, "Standard Gaps")

    End Sub


    Private Sub LblGapFirst_Click(sender As Object, e As EventArgs) Handles LblGapFirst.Click

        Dim FoundText = DirectCast(sender.text, String)

        Dim FoundValue = Mid(FoundText, 1, (FoundText.Length - 2))

        My.Computer.Clipboard.SetText(FoundValue)

        MsgBox("Use " & FoundText & " as FIRST and LAST gap",, "First and Last Gaps")


    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click

        If BtnFirst.Text = "Cancel Reduce First Gap" Then
            BtnFirst.Text = "Reduce First Gap ?"

            PnlReduceGap.Visible = False

            SelectPicture()

        Else
            BtnFirst.Text = "Cancel Reduce First Gap"

            PicGaps.Image = My.Resources.Reduce_Gap

            BtnFirst.Text = "Cancel Reduce First Gap"

            PnlReduceGap.Visible = True

            TxtReduce_r.Focus()

        End If

    End Sub

    Private Sub TxtReduce_r_TextChanged(sender As Object, e As EventArgs) Handles TxtReduce_r.TextChanged

        If TxtReduce_r.TextLength > 0 Then

            LblGapFirst.Visible = True
            PnlFirstTitle.Visible = True

            Try
                Reducer = TxtReduce_r.Text

                CalcGaps()

                LblGapFirst.Text = OptimalGap - Reducer & "mm"

            Catch ex As Exception
                MsgBox("Typed something wrong in the box",, "Dimension (r) Box")
            End Try
        Else
            LblGapFirst.Visible = False
            PnlFirstTitle.Visible = False

        End If

    End Sub

End Class