Imports System.Deployment.Application
Module CurrentVersion

    Public Sub VersionNumber(ByVal LblVer, ByVal Form)

        Dim CurrentAssembly = Reflection.Assembly.GetExecutingAssembly()

        If ApplicationDeployment.IsNetworkDeployed Then
            Dim VersionNumber As Version
            VersionNumber = ApplicationDeployment.CurrentDeployment.CurrentVersion
            LblVer.Text = String.Concat("Version : ", VersionNumber)
        Else
            If Debugger.IsAttached = False Then
                Dim VersionNumber = CurrentAssembly.GetName().Version.ToString()
                LblVer.Text = "Version : " & VersionNumber
            Else
                LblVer.Text = Form.Name
            End If

        End If


        'ALTERNATIVE
        'If ApplicationDeployment.IsNetworkDeployed Then
        '    Form.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        'Else
        '    Form.Text = Application.ProductVersion
        'End If


    End Sub


End Module
