Imports System.Drawing.Drawing2D
Imports System.Dynamic
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports Microsoft.VisualBasic.FileIO

Public Class Summary

    Public SelectedXType
    Public DimX
    Public SpindleX
    Dim GapOptionsDT As DataTable
    Public MasterGapsDT As DataTable
    Dim PanelLocationX As Integer
    Dim PanelLocationY As Integer
    Dim RowsCount As Integer
    Dim SpindleCount As Integer
    Dim RunCount As Integer
    Dim WheelsWidth As Integer
    Dim Run1CurrentSpindleCount As Integer
    Dim SelectedWheel
    Dim SelectedRunName

    Dim LineTop As New Panel
    Dim LineBot As New Panel
    Dim LineLeft As New Panel
    Dim LineRight As New Panel

    Public SummaryDT As DataTable

    Private Sub Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VersionNumber(LblVer, Me)

        PanelLocationX = PnlRun1.Location.X + PnlRun1.Width + 10
        PanelLocationY = PnlRun1.Location.Y
        RunCount = 1


        LblRunNumber01.Text = RunCount

        CreateWheels()

    End Sub

#Region "Buttons"

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        StartPage.Show()

        StartPage.TestForSummary()

        Close()


    End Sub

    Private Sub BtnMore_Click(sender As Object, e As EventArgs)

        AddSpindle()

    End Sub

    Private Sub BtnMore01_Click(sender As Object, e As EventArgs) Handles BtnMore01.Click

        AddSpindle()

    End Sub

    Private Sub BtnLess_Click(sender As Object, e As EventArgs)

        OmitSpindle(sender)

    End Sub

    Private Sub BtnLess01_Click(sender As Object, e As EventArgs) Handles BtnLess01.Click

        OmitSpindle(sender)

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs)

        Dim CurrentPanel As Panel = sender.Parent
        Dim CurrentRunNo = Mid(CurrentPanel.Name, 7)
        Dim CurrentPnlDetails As Panel = CurrentPanel.Controls("PnlDetails" & CurrentRunNo)
        Dim CurrentPnlTitle As Panel = CurrentPnlDetails.Controls("PnlTitle" & CurrentRunNo)
        Dim CurrentLblTitle As Label = CurrentPnlTitle.Controls("LblTitle" & CurrentRunNo)
        Dim CurrentRunName = CurrentLblTitle.Text

        Select Case MsgBox("Do you want to delete Run - " & CurrentRunName & "?", MsgBoxStyle.YesNoCancel, "caption")
            Case MsgBoxResult.Yes
                PnlWheelsHolding.Controls.Remove(CurrentPanel)
                Dim rowIndex = SummaryDT.AsEnumerable().[Select](Function(r) r.Field(Of String)("RunName")).ToList().FindIndex(Function(col) col = CurrentRunName)
                SummaryDT.Rows(rowIndex).Delete()
                RunCount -= 1
                CreateWheels()
            Case MsgBoxResult.Cancel
                'MessageBox.Show("Cancel button")
            Case MsgBoxResult.No
                ' MessageBox.Show("NO button")
        End Select

    End Sub

    Private Sub BtnDelete01_Click(sender As Object, e As EventArgs) Handles BtnDelete01.Click

        Select Case MsgBox("Do you want to delete Run - " & LblTitle1.Text & "?", MsgBoxStyle.YesNoCancel, "caption")
            Case MsgBoxResult.Yes
                PnlWheelsHolding.Controls.Remove(PnlRun1)
                Dim rowIndex = SummaryDT.AsEnumerable().[Select](Function(r) r.Field(Of String)("RunName")).ToList().FindIndex(Function(col) col = LblTitle1.Text)
                SummaryDT.Rows(rowIndex).Delete()
                RunCount -= 1
                CreateWheels()
            Case MsgBoxResult.Cancel
                'MessageBox.Show("Cancel button")
            Case MsgBoxResult.No
                ' MessageBox.Show("NO button")
        End Select

    End Sub


#End Region

#Region "Functions"

    Private Function WheelValues(Spindles, XType, Dimx, SpindleX, Reducer)

        Dim Gaps As New ArrayList

        For i = 0 To 4

            Select Case i
                Case 0
                    Gaps.Add(CalculateGap(Spindles - 2, XType, Dimx, SpindleX, Reducer))
                Case 1
                    Gaps.Add(CalculateGap(Spindles - 1, XType, Dimx, SpindleX, Reducer))
                Case 2
                    Gaps.Add(CalculateGap(Spindles, XType, Dimx, SpindleX, Reducer))
                Case 3
                    Gaps.Add(CalculateGap(Spindles + 1, XType, Dimx, SpindleX, Reducer))
                Case 4
                    Gaps.Add(CalculateGap(Spindles + 2, XType, Dimx, SpindleX, Reducer))

            End Select

        Next

        Return Gaps

    End Function

    Private Function CalculateGap(SpindleCount, XType, DimX, SpindleX, Reducer)
        Dim Gap As Double

        Select Case XType
            Case "Overall"
                Gap = (DimX - (SpindleX * SpindleCount)) / (SpindleCount - 1)

            Case "NewelToOver"
                Gap = (DimX - (SpindleX * SpindleCount)) / (SpindleCount)

            Case "BetweenNewels"
                Gap = (DimX + (2 * Reducer) - (SpindleX * SpindleCount)) / (SpindleCount + 1)

        End Select

        Gap = Math.Round(Gap, 2)

        Return Gap

    End Function

    Public Function FindControlStartsWith(root As Control, Partname As String)

        Dim controls = New List(Of Control)

        Dim contrls As New Stack(Of Control)(root.Controls.Cast(Of Control)())
        While contrls.Count > 0
            Dim currentControl As Control = contrls.Pop()
            If currentControl.Name.StartsWith(Partname) Then
                controls.Add(currentControl)
            End If
            For Each child As Control In currentControl.Controls
                contrls.Push(child)
            Next

        End While

        Return controls.ToArray()

    End Function

#End Region

    Private Sub CreateViewer(X, Y, W, H)

        W += 100

        With LineTop
            .Enabled = False
            .Width = W
            .Height = 2
            .Location = New Point(X, Y)
            .BackColor = Color.Red
        End With

        With LineBot
            .Enabled = False
            .Width = W
            .Height = 2
            .Location = New Point(X, Y + LblOpti031.Height)
            .BackColor = Color.Red
        End With

        With LineLeft
            .Enabled = False
            .Width = 2
            .Height = H
            .Location = New Point(X, Y)
            .BackColor = Color.Red
        End With

        With LineRight
            .Enabled = False
            .Width = 2
            .Height = H + 2
            .Location = New Point(X + W, Y)
            .BackColor = Color.Red
        End With

        Controls.Add(LineTop)
        Controls.Add(LineBot)
        Controls.Add(LineLeft)
        Controls.Add(LineRight)

        LineTop.BringToFront()
        LineBot.BringToFront()
        LineLeft.BringToFront()
        LineRight.BringToFront()

    End Sub

    Private Sub RemoveViewer()

        Controls.Remove(LineTop)
        Controls.Remove(LineBot)
        Controls.Remove(LineLeft)
        Controls.Remove(LineRight)

    End Sub

    Private Sub CreateWheels()

        Dim CurrentRunName As String
        WheelsWidth = 0
        CurrentRunName = "None"

        If SummaryDT.Rows.Count > 0 Then
            Dim WheelCount As Integer = 1
            For Each row As DataRow In SummaryDT.Rows
                Dim FoundRunName = row("RunName")
                Dim FoundGap = row("Gaps")
                Dim FoundXType = row("XType")
                Dim FoundSpindles = row("Spindles")
                Dim FoundDimX = row("DimX")
                Dim FoundSpindleX = row("SpindleX")
                Dim CurrentIndex = row.Table.Rows.IndexOf(row)
                Dim FoundReduce = row("Reducer")

                If FoundRunName <> CurrentRunName Then
                    If CurrentRunName = "None" Then

                        Dim GapsArray As New ArrayList
                        GapsArray = WheelValues(FoundSpindles, FoundXType, FoundDimX, FoundSpindleX, FoundReduce)

                        Run1CurrentSpindleCount = FoundSpindles

                        LblTitle1.Text = FoundRunName
                        LblType1.Text = FoundXType
                        Lbl_X1.Text = FoundDimX & "mm"
                        LblCount1.Text = FoundSpindles
                        Lbl_r1.Text = FoundReduce & "mm"

                        LblOpti011.Text = GapsArray.Item(0) & "mm"
                        LblOpti021.Text = GapsArray.Item(1) & "mm"
                        LblOpti031.Text = GapsArray.Item(2) & "mm"
                        LblOpti041.Text = GapsArray.Item(3) & "mm"
                        LblOpti051.Text = GapsArray.Item(4) & "mm"

                        If Not SummaryDT.Columns.Contains("WheelNo") Then
                            SummaryDT.Columns.Add("WheelNo")
                            SummaryDT.Columns.Add("Count")
                            SummaryDT.Columns.Add("Gap01")
                            SummaryDT.Columns.Add("Gap02")
                            SummaryDT.Columns.Add("Gap03")
                            SummaryDT.Columns.Add("Gap04")
                            SummaryDT.Columns.Add("Gap05")
                        End If

                    Else
                        Dim GapsArray As New ArrayList
                        GapsArray = WheelValues(FoundSpindles, FoundXType, FoundDimX, FoundSpindleX, FoundReduce)

                        Dim Opti01 As String = GapsArray.Item(0) & "mm"
                        Dim Opti02 As String = GapsArray.Item(1) & "mm"
                        Dim Opti03 As String = GapsArray.Item(2) & "mm"
                        Dim Opti04 As String = GapsArray.Item(3) & "mm"
                        Dim Opti05 As String = GapsArray.Item(4) & "mm"

                        CreateNewRun(FoundRunName, FoundXType, FoundDimX, FoundReduce, FoundSpindles, Opti01, Opti02, Opti03, Opti04, Opti05)

                        WheelCount += 1

                    End If

                End If

                SummaryDT.Rows(CurrentIndex)("WheelNo") = WheelCount
                SummaryDT.Rows(CurrentIndex)("Count") = "LblCount" & WheelCount
                SummaryDT.Rows(CurrentIndex)("Gap01") = "LblOpti01" & WheelCount
                SummaryDT.Rows(CurrentIndex)("Gap02") = "LblOpti02" & WheelCount
                SummaryDT.Rows(CurrentIndex)("Gap03") = "LblOpti03" & WheelCount
                SummaryDT.Rows(CurrentIndex)("Gap04") = "LblOpti04" & WheelCount
                SummaryDT.Rows(CurrentIndex)("Gap05") = "LblOpti05" & WheelCount

                CurrentRunName = FoundRunName

                RunCount += 1
                WheelsWidth += PnlRun1.Width + 10

            Next

            ReSizeWheelArray()

            Dim BoxY = PnlWheel1.PointToScreen(LblOpti031.Location).Y

            Dim VX = PnlWheelsHolding.Location.X - 50
            Dim VY = BoxY
            Dim VW = PnlWheelsHolding.Width
            Dim VH = LblOpti031.Height

            CreateViewer(VX, VY, VW, VH)

            If SummaryDT.Rows.Count = 1 Then
                PnlWheelsHolding.Controls.Add(PnlRun1)
            End If

        Else

            RemoveViewer()

        End If

    End Sub

    Private Sub ReSizeWheelArray()

        PnlWheelsHolding.Width = WheelsWidth - 8

        PnlWheelsHolding.Location = New Point((PnlRunsHolding.Width - PnlWheelsHolding.Width) / 2, PnlWheelsHolding.Location.Y)

    End Sub

    Private Sub CreateNewRun(Name, XType, DimX, Dim_r, Spindles, Gap01, Gap02, Gap03, Gap04, Gap05)

        Dim ThisPanel As Panel
        Dim ThisPanelName As String
        Dim ThisLabel As Label
        Dim ThisLabelName As String
        Dim ThisButton As Button
        Dim ThisButtonName As String


#Region "Create New Run Panel"

        Dim NewRunPanel As New Panel
        Dim NewRunDetailsPanel As New Panel
        Dim NewGapsHoldingPanel As New Panel
        Dim NewDeleteButton As New Button
        Dim NewRunNumberLable As New Label

        ThisPanel = PnlRun1
        ThisPanelName = "PnlRun"
        With NewRunPanel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = New Point(PanelLocationX, PanelLocationY)
            .BorderStyle = ThisPanel.BorderStyle
        End With

        ThisPanel = PnlDetails1
        ThisPanelName = "PnlDetails"
        With NewRunDetailsPanel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .BorderStyle = ThisPanel.BorderStyle
            .Enabled = ThisPanel.Enabled
            .Dock = ThisPanel.Dock
        End With

        ThisPanel = PnlGapsHolding1
        ThisPanelName = "PnlGapsHolding"
        With NewGapsHoldingPanel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .BorderStyle = ThisPanel.BorderStyle
            .Enabled = ThisPanel.Enabled
            .Dock = ThisPanel.Dock
        End With

        ThisButton = BtnDelete01
        ThisButtonName = "BtnDelete"
        With NewDeleteButton
            .Name = ThisButtonName & RunCount
            .Width = ThisButton.Width
            .Height = ThisButton.Height
            .Location = ThisButton.Location
            .Enabled = ThisButton.Enabled
            .Dock = ThisButton.Dock
            .Font = ThisButton.Font
            .Text = "Delete"
        End With

        ThisLabel = LblRunNumber01
        ThisLabelName = "LblRunNumber"
        With NewRunNumberLable
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = RunCount
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
        End With

#End Region

#Region "Create New Details Panels"

        Dim NewTitlePanel As New Panel
        Dim NewTypePanel As New Panel
        Dim New_X_Panel As New Panel
        Dim New_r_Panel As New Panel
        Dim NewCountPanel As New Panel

        ThisPanel = PnlTitle1
        ThisPanelName = "PnlTitle"
        With NewTitlePanel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .BorderStyle = ThisPanel.BorderStyle
        End With

        ThisPanel = PnlType1
        ThisPanelName = "PnlType"
        With NewTypePanel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .BorderStyle = ThisPanel.BorderStyle
        End With

        ThisPanel = Pnl_X1
        ThisPanelName = "Pnl_X"
        With New_X_Panel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .BorderStyle = ThisPanel.BorderStyle
        End With

        ThisPanel = Pnl_r1
        ThisPanelName = "Pnl_r"
        With New_r_Panel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .BorderStyle = ThisPanel.BorderStyle
        End With

        ThisPanel = PnlCount1
        ThisPanelName = "PnlCount"
        With NewCountPanel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .BorderStyle = ThisPanel.BorderStyle
        End With

#End Region

#Region "Fill in Details Panels"

        Dim NewLblTitleLabel As New Label
        Dim NewTitle As New Label
        Dim NewLblTypeLabel As New Label
        Dim NewType As New Label
        Dim NewLbl_XLabel As New Label
        Dim New_X As New Label
        Dim NewLbl_rLabel As New Label
        Dim New_r As New Label
        Dim NewLblCountLabel As New Label
        Dim NewCount As New Label

        ThisLabel = LblTitleLabel1
        ThisLabelName = "LblTitleLabel"
        With NewLblTitleLabel
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = ThisLabel.Text
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
        End With

        ThisLabel = LblTitle1
        ThisLabelName = "LblTitle"
        With NewTitle
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = Name
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
            .TextAlign = ThisLabel.TextAlign
        End With

        ThisLabel = LblTypeLabel1
        ThisLabelName = "LblTypeLabel"
        With NewLblTypeLabel
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = ThisLabel.Text
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
        End With

        ThisLabel = LblType1
        ThisLabelName = "LblType"
        With NewType
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = XType
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
            .TextAlign = ThisLabel.TextAlign
        End With

        ThisLabel = Lbl_XLabel1
        ThisLabelName = "Lbl_XLabel"
        With NewLbl_XLabel
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = ThisLabel.Text
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
            .ForeColor = ThisLabel.ForeColor
        End With

        ThisLabel = Lbl_X1
        ThisLabelName = "Lbl_X"
        With New_X
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = DimX & "mm"
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
            .TextAlign = ThisLabel.TextAlign
        End With

        ThisLabel = Lbl_rLabel1
        ThisLabelName = "Lbl_rLabel"
        With NewLbl_rLabel
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = ThisLabel.Text
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
            .ForeColor = ThisLabel.ForeColor
        End With

        ThisLabel = Lbl_r1
        ThisLabelName = "Lbl_r"
        With New_r
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = Dim_r & "mm"
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
            .TextAlign = ThisLabel.TextAlign
        End With

        ThisLabel = LblCountLabel1
        ThisLabelName = "LblCountLabel"
        With NewLblCountLabel
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = ThisLabel.Text
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
            .ForeColor = ThisLabel.ForeColor
        End With

        ThisLabel = LblCount1
        ThisLabelName = "LblCount"
        With NewCount
            .Name = ThisLabelName & RunCount
            .Location = ThisLabel.Location
            .Text = Spindles
            .Font = ThisLabel.Font
            .AutoSize = ThisLabel.AutoSize
            .Width = ThisLabel.Width
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
            .TextAlign = ThisLabel.TextAlign
        End With

        NewTitlePanel.Controls.Add(NewTitle)
        NewTitlePanel.Controls.Add(NewLblTitleLabel)
        NewTypePanel.Controls.Add(NewType)
        NewTypePanel.Controls.Add(NewLblTypeLabel)
        New_X_Panel.Controls.Add(New_X)
        New_X_Panel.Controls.Add(NewLbl_XLabel)
        New_r_Panel.Controls.Add(New_r)
        New_r_Panel.Controls.Add(NewLbl_rLabel)
        NewCountPanel.Controls.Add(NewCount)
        NewCountPanel.Controls.Add(NewLblCountLabel)

#End Region

#Region "Create New Gap Holding Panel"

        Dim NewMore0Btn As New Button
        Dim NewSpacerTop As New Panel
        Dim NewWheelPanel As New Panel
        Dim NewSpacerBot As New Panel
        Dim NewLess0Btn As New Button

        ThisButton = BtnMore01
        ThisButtonName = "BtnMore0"
        With NewMore0Btn
            .Name = ThisButtonName & RunCount
            .Width = ThisButton.Width
            .Height = ThisButton.Height
            .Location = ThisButton.Location
            .Dock = ThisButton.Dock
            .Text = ThisButton.Text
            .Font = ThisButton.Font
        End With

        ThisPanel = SpacerTop1
        ThisPanelName = "SpacerTop"
        With NewSpacerTop
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .Dock = ThisPanel.Dock
        End With

        ThisPanel = PnlWheel1
        ThisPanelName = "PnlWheel"
        With NewWheelPanel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .BorderStyle = ThisPanel.BorderStyle
            .Dock = ThisPanel.Dock
        End With

        ThisPanel = SpacerBot1
        ThisPanelName = "SpacerBot"
        With NewSpacerBot
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Location = ThisPanel.Location
            .Dock = ThisPanel.Dock
        End With

        ThisButton = BtnLess01
        ThisButtonName = "BtnLess0"
        With NewLess0Btn
            .Name = ThisButtonName & RunCount
            .Width = ThisButton.Width
            .Height = ThisButton.Height
            .Location = ThisButton.Location
            .Dock = ThisButton.Dock
            .Text = ThisButton.Text
            .Font = ThisButton.Font
        End With

#End Region

#Region "Create New Wheel (g) Panel"

        Dim New_g_TitlePanel As New Panel
        Dim Lbl_g_Label As New Label

        ThisPanel = Pnl_g_Title01
        ThisPanelName = "Pnl_g_Title0"
        With New_g_TitlePanel
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Dock = ThisPanel.Dock
            .BorderStyle = ThisPanel.BorderStyle
        End With

        ThisLabel = Lbl_g01
        ThisLabelName = "Lbl_g0"
        With Lbl_g_Label
            .Name = ThisLabelName & RunCount
            .Text = ThisLabel.Text
            .Font = ThisLabel.Font
            .ForeColor = ThisLabel.ForeColor
            .Dock = ThisLabel.Dock
            .BorderStyle = ThisLabel.BorderStyle
        End With

#End Region

#Region "Create New Gaps"

        Dim NewOptiGap01 As New Label
        Dim NewOptiGap02 As New Label
        Dim NewOptiGap03 As New Label
        Dim NewOptiGap04 As New Label
        Dim NewOptiGap05 As New Label
        Dim NewSpacer10 As New Panel
        Dim NewSpacer20 As New Panel
        Dim NewSpacer30 As New Panel
        Dim NewSpacer40 As New Panel

        ThisLabel = LblOpti011
        ThisLabelName = "LblOpti01"
        With NewOptiGap01
            .Name = ThisLabelName & RunCount
            .Text = Gap01
            .Font = ThisLabel.Font
            .Dock = ThisLabel.Dock
            .TextAlign = ThisLabel.TextAlign
            .Height = ThisLabel.Height
            .AutoSize = ThisLabel.AutoSize
        End With

        ThisLabel = LblOpti021
        ThisLabelName = "LblOpti02"
        With NewOptiGap02
            .Name = ThisLabelName & RunCount
            .Text = Gap02
            .Font = ThisLabel.Font
            .Dock = ThisLabel.Dock
            .TextAlign = ThisLabel.TextAlign
            .Height = ThisLabel.Height
            .AutoSize = ThisLabel.AutoSize
        End With

        ThisLabel = LblOpti031
        ThisLabelName = "LblOpti03"
        With NewOptiGap03
            .Name = ThisLabelName & RunCount
            .Text = Gap03
            .Font = ThisLabel.Font
            .Dock = ThisLabel.Dock
            .TextAlign = ThisLabel.TextAlign
            .Height = ThisLabel.Height
            .AutoSize = ThisLabel.AutoSize
        End With

        ThisLabel = LblOpti041
        ThisLabelName = "LblOpti04"
        With NewOptiGap04
            .Name = ThisLabelName & RunCount
            .Text = Gap04
            .Font = ThisLabel.Font
            .Dock = ThisLabel.Dock
            .TextAlign = ThisLabel.TextAlign
            .Height = ThisLabel.Height
            .AutoSize = ThisLabel.AutoSize
        End With

        ThisLabel = LblOpti051
        ThisLabelName = "LblOpti05"
        With NewOptiGap05
            .Name = ThisLabelName & RunCount
            .Text = Gap05
            .Font = ThisLabel.Font
            .Dock = ThisLabel.Dock
            .TextAlign = ThisLabel.TextAlign
            .Height = ThisLabel.Height
            .AutoSize = ThisLabel.AutoSize
        End With

        ThisPanel = PnlSpacer001
        ThisPanelName = "PnlSpacer00"
        With NewSpacer10
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Dock = ThisPanel.Dock
        End With

        ThisPanel = PnlSpacer201
        ThisPanelName = "PnlSpacer20"
        With NewSpacer20
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Dock = ThisPanel.Dock
        End With

        ThisPanel = PnlSpacer301
        ThisPanelName = "PnlSpacer30"
        With NewSpacer30
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Dock = ThisPanel.Dock
        End With

        ThisPanel = PnlSpacer401
        ThisPanelName = "PnlSpacer40"
        With NewSpacer40
            .Name = ThisPanelName & RunCount
            .Width = ThisPanel.Width
            .Height = ThisPanel.Height
            .Dock = ThisPanel.Dock
        End With

#End Region

        AddHandler NewMore0Btn.Click, AddressOf BtnMore_Click
        AddHandler NewLess0Btn.Click, AddressOf BtnLess_Click
        AddHandler NewRunPanel.Click, AddressOf EnableWheel_Click
        AddHandler NewOptiGap03.MouseClick, AddressOf RightMouseLabel_MouseClick
        AddHandler NewDeleteButton.Click, AddressOf BtnDelete_Click

        PnlWheelsHolding.Controls.Add(NewRunPanel)

        NewRunPanel.Controls.Add(NewRunNumberLable)
        NewRunPanel.Controls.Add(NewDeleteButton)
        NewRunPanel.Controls.Add(NewGapsHoldingPanel)
        NewRunPanel.Controls.Add(NewRunDetailsPanel)


        NewRunDetailsPanel.Controls.Add(NewTitlePanel)
        NewRunDetailsPanel.Controls.Add(NewTypePanel)
        NewRunDetailsPanel.Controls.Add(New_X_Panel)
        NewRunDetailsPanel.Controls.Add(New_r_Panel)
        NewRunDetailsPanel.Controls.Add(NewCountPanel)

        NewGapsHoldingPanel.Controls.Add(NewLess0Btn)
        NewGapsHoldingPanel.Controls.Add(NewSpacerBot)
        NewGapsHoldingPanel.Controls.Add(NewWheelPanel)
        NewGapsHoldingPanel.Controls.Add(NewSpacerTop)
        NewGapsHoldingPanel.Controls.Add(NewMore0Btn)

        New_g_TitlePanel.Controls.Add(Lbl_g_Label)

        NewWheelPanel.Controls.Add(NewOptiGap05)
        NewWheelPanel.Controls.Add(NewSpacer40)
        NewWheelPanel.Controls.Add(NewOptiGap04)
        NewWheelPanel.Controls.Add(NewSpacer30)
        NewWheelPanel.Controls.Add(NewOptiGap03)
        NewWheelPanel.Controls.Add(NewSpacer20)
        NewWheelPanel.Controls.Add(NewOptiGap02)
        NewWheelPanel.Controls.Add(NewSpacer10)
        NewWheelPanel.Controls.Add(NewOptiGap01)
        NewWheelPanel.Controls.Add(New_g_TitlePanel)

        PanelLocationX += NewRunPanel.Width + 10

    End Sub

    Private Sub LblOpti031_MouseClick(sender As Object, e As MouseEventArgs) Handles LblOpti031.MouseClick

        Dim Reducer = Mid(Lbl_r1.Text, 1, InStr(Lbl_r1.Text, "mm") - 1)

        ShowUseGap(e.Button, sender.text, sender.name, Reducer)

    End Sub

    Private Sub RightMouseLabel_MouseClick(sender As Object, e As MouseEventArgs)

        Dim LabelPosition = New Point(e.Location)

        Dim RunNo = Mid(sender.Name, Len(sender.name))

        Dim LableName = "Lbl_r" & RunNo

        Dim DetailsPanel = "PnlDetails1" & RunNo


        Dim FoundControl = FindControlRecursively(PnlWheelsHolding, LableName)

        Dim Reducer = Mid(FoundControl.Text, 1, InStr(FoundControl.Text, "mm") - 1)

        ShowUseGap(e.Button, sender.text, sender.name, Reducer)

    End Sub

    Private Sub ShowUseGap(Mouse As MouseButtons, Gap As String, LableName As String, Reducer As String)

        If Mouse = MouseButtons.Right Then
            Dim FmUseGap As New UseGap
            Dim WheelNumber = SelectedWheel

            Dim SearchString As String = "WheelNo='" & WheelNumber & "'"
            Dim FoundIndex = SummaryDT.Rows.IndexOf(SummaryDT.Select(SearchString).FirstOrDefault)
            Dim FoundSpindles = Controls.Find("LblCount" & WheelNumber, True).FirstOrDefault.Text
            Dim GapLocationLabel As Label = Controls.Find("LblOpti03" & WheelNumber, True).FirstOrDefault
            Dim WheelLocation As Panel = Controls.Find("PnlWheel" & WheelNumber, True).FirstOrDefault

            Dim LocY = WheelLocation.PointToScreen(GapLocationLabel.Location).Y + GapLocationLabel.Height + 6
            Dim LocX = WheelLocation.PointToScreen(GapLocationLabel.Location).X

            With FmUseGap
                .DisplayedGap = Gap
                .LocationY = LocY
                .LocationX = LocX
                .FoundIndex = FoundIndex
                .DT = SummaryDT
                .UseSpindleCount = FoundSpindles
                .Reducer = Reducer
            End With

            If FmUseGap.ShowDialog = DialogResult.OK Then

            End If
        End If

    End Sub

    Private Sub AddSpindle()

        Dim WheelNumber = SelectedWheel

        Dim SearchString As String = "WheelNo='" & WheelNumber & "'"
        Dim CurrentIndex = SummaryDT.Rows.IndexOf(SummaryDT.Select(SearchString).FirstOrDefault)

        Dim FoundOptiSpindleCount = SummaryDT(CurrentIndex)("Spindles")
        Dim FoundXType = SummaryDT(CurrentIndex)("XType")
        Dim FoundDimX = SummaryDT(CurrentIndex)("DimX")
        Dim FoundSpindleX = SummaryDT(CurrentIndex)("SpindleX")
        Dim FoundSpindleLabel = SummaryDT(CurrentIndex)("Count")
        Dim CurrentSpindleCount = Controls.Find(FoundSpindleLabel, searchAllChildren:=True).FirstOrDefault.Text
        Dim FoundReduce = SummaryDT(CurrentIndex)("Reducer")

        Dim GapsArray As ArrayList
        GapsArray = WheelValues(CurrentSpindleCount + 1, FoundXType, FoundDimX, FoundSpindleX, FoundReduce)

        Dim FoundLabel01 = SummaryDT(CurrentIndex)("Gap01")
        Dim FoundLabel02 = SummaryDT(CurrentIndex)("Gap02")
        Dim FoundLabel03 = SummaryDT(CurrentIndex)("Gap03")
        Dim FoundLabel04 = SummaryDT(CurrentIndex)("Gap04")
        Dim FoundLabel05 = SummaryDT(CurrentIndex)("Gap05")

        Controls.Find(FoundLabel01, True).FirstOrDefault.Text = GapsArray.Item(0) & "mm"
        Controls.Find(FoundLabel02, True).FirstOrDefault.Text = GapsArray.Item(1) & "mm"
        Controls.Find(FoundLabel03, True).FirstOrDefault.Text = GapsArray.Item(2) & "mm"
        Controls.Find(FoundLabel04, True).FirstOrDefault.Text = GapsArray.Item(3) & "mm"
        Controls.Find(FoundLabel05, True).FirstOrDefault.Text = GapsArray.Item(4) & "mm"

        Controls.Find(FoundSpindleLabel, True).FirstOrDefault.Text = CurrentSpindleCount + 1

    End Sub

    Private Sub OmitSpindle(From)

        'Dim WheelNumber = Mid(From.parent.name, 7)

        Dim WheelNumber = SelectedWheel

        Dim SearchString As String = "WheelNo='" & WheelNumber & "'"
        Dim CurrentIndex = SummaryDT.Rows.IndexOf(SummaryDT.Select(SearchString).FirstOrDefault)

        Dim FoundOptiSpindleCount = SummaryDT(CurrentIndex)("Spindles")
        Dim FoundXType = SummaryDT(CurrentIndex)("XType")
        Dim FoundDimX = SummaryDT(CurrentIndex)("DimX")
        Dim FoundSpindleX = SummaryDT(CurrentIndex)("SpindleX")
        Dim FoundSpindleLabel = SummaryDT(CurrentIndex)("Count")
        Dim CurrentSpindleCount = Controls.Find(FoundSpindleLabel, True).FirstOrDefault.Text
        Dim FoundReduce = SummaryDT(CurrentIndex)("Reducer")

        Dim GapsArray As ArrayList
        GapsArray = WheelValues(CurrentSpindleCount - 1, FoundXType, FoundDimX, FoundSpindleX, FoundReduce)

        Dim FoundLabel01 = SummaryDT(CurrentIndex)("Gap01")
        Dim FoundLabel02 = SummaryDT(CurrentIndex)("Gap02")
        Dim FoundLabel03 = SummaryDT(CurrentIndex)("Gap03")
        Dim FoundLabel04 = SummaryDT(CurrentIndex)("Gap04")
        Dim FoundLabel05 = SummaryDT(CurrentIndex)("Gap05")

        Controls.Find(FoundLabel01, True).FirstOrDefault.Text = GapsArray.Item(0) & "mm"
        Controls.Find(FoundLabel02, True).FirstOrDefault.Text = GapsArray.Item(1) & "mm"
        Controls.Find(FoundLabel03, True).FirstOrDefault.Text = GapsArray.Item(2) & "mm"
        Controls.Find(FoundLabel04, True).FirstOrDefault.Text = GapsArray.Item(3) & "mm"
        Controls.Find(FoundLabel05, True).FirstOrDefault.Text = GapsArray.Item(4) & "mm"

        Controls.Find(FoundSpindleLabel, True).FirstOrDefault.Text = CurrentSpindleCount - 1

    End Sub

    Private Sub EnableWheel_Click(sender As Object, e As MouseEventArgs)

        SelectWheel(sender)

    End Sub

    Private Sub PnlRun1_Click(sender As Object, e As MouseEventArgs) Handles PnlRun1.Click

        SelectWheel(sender)

    End Sub

    Private Sub SelectWheel(From)

        Dim WheelNumber = Mid(From.name, 7)

        SelectedWheel = WheelNumber

        Dim FoundPanel = "PnlGapsHolding" & SelectedWheel

        ResetEnabledPanels()

        Controls.Find(FoundPanel, True).FirstOrDefault.Enabled = True

    End Sub

    Private Sub ResetEnabledPanels()

        Dim obj() As Control = FindControlStartsWith(PnlWheelsHolding, "PnlGapsHolding")

        For Each Ctrl As Control In obj
            Ctrl.Enabled = False
        Next


    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click

        Me.WindowState = FormWindowState.Minimized


    End Sub


End Class