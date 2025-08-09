Public Class NameRun

    Public RunName
    Public MasterGapsDT As DataTable

    Private Sub NameRun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetData()

    End Sub

    Private Sub GetData()

        For Each row In MasterGapsDT.Rows

            Dim FoundRun = row("RunName")

            LstExisting.Items.Add(FoundRun)

        Next

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        RunName = TxtRunName.Text

        DialogResult = DialogResult.OK

        'Close()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        DialogResult = DialogResult.Cancel

        'Close()

    End Sub


End Class