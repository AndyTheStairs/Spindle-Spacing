Module Functions

    Public Function FindControlRecursively(ByVal ParentControl As Control, ByVal ControlTobeSearched As String) As Control
        Dim FoundControl As Control = Nothing
        For Each CurrentControl As Control In ParentControl.Controls
            If CurrentControl.Name.ToLower() = ControlTobeSearched.ToLower() Then
                FoundControl = CurrentControl
            ElseIf CurrentControl.HasChildren Then
                FoundControl = FindControlRecursively(CurrentControl, ControlTobeSearched)
            End If
            If FoundControl IsNot Nothing Then
                Exit For
            End If
        Next
        Return FoundControl
    End Function


End Module
