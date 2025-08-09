<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblBetween = New System.Windows.Forms.Label()
        Me.LblOveralRun = New System.Windows.Forms.Label()
        Me.LblNewelToOverall = New System.Windows.Forms.Label()
        Me.PicBetween = New System.Windows.Forms.PictureBox()
        Me.PicOverall = New System.Windows.Forms.PictureBox()
        Me.PicNeweltoOver = New System.Windows.Forms.PictureBox()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.PnlScreenOptions = New System.Windows.Forms.Panel()
        Me.BtnOtherScreen2 = New System.Windows.Forms.Button()
        Me.BtnOtherScreen1 = New System.Windows.Forms.Button()
        Me.BtnPrimaryScreen = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.PnlFooter = New System.Windows.Forms.Panel()
        Me.LblVer = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlXType = New System.Windows.Forms.Panel()
        Me.LblDimX = New System.Windows.Forms.Label()
        Me.PnlSpindleX = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSpindleX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PnlDimX = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlBetween = New System.Windows.Forms.Panel()
        Me.PnlNewelToOver = New System.Windows.Forms.Panel()
        Me.PnlOverall = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlRight = New System.Windows.Forms.Panel()
        Me.BtnSummary = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnSelectAgain = New System.Windows.Forms.Button()
        Me.PnlLeft = New System.Windows.Forms.Panel()
        CType(Me.PicBetween, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOverall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNeweltoOver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlHeader.SuspendLayout()
        Me.PnlScreenOptions.SuspendLayout()
        Me.PnlFooter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlXType.SuspendLayout()
        Me.PnlSpindleX.SuspendLayout()
        Me.PnlDimX.SuspendLayout()
        Me.PnlBetween.SuspendLayout()
        Me.PnlNewelToOver.SuspendLayout()
        Me.PnlOverall.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PnlRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(749, 108)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Spindle Spacing"
        '
        'LblBetween
        '
        Me.LblBetween.AutoSize = True
        Me.LblBetween.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblBetween.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBetween.Location = New System.Drawing.Point(0, 0)
        Me.LblBetween.Name = "LblBetween"
        Me.LblBetween.Size = New System.Drawing.Size(185, 25)
        Me.LblBetween.TabIndex = 1
        Me.LblBetween.Text = "Between Newels"
        '
        'LblOveralRun
        '
        Me.LblOveralRun.AutoSize = True
        Me.LblOveralRun.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblOveralRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOveralRun.Location = New System.Drawing.Point(0, 0)
        Me.LblOveralRun.Name = "LblOveralRun"
        Me.LblOveralRun.Size = New System.Drawing.Size(136, 25)
        Me.LblOveralRun.TabIndex = 2
        Me.LblOveralRun.Text = "Overall Run"
        '
        'LblNewelToOverall
        '
        Me.LblNewelToOverall.AutoSize = True
        Me.LblNewelToOverall.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblNewelToOverall.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewelToOverall.Location = New System.Drawing.Point(0, 0)
        Me.LblNewelToOverall.Name = "LblNewelToOverall"
        Me.LblNewelToOverall.Size = New System.Drawing.Size(185, 25)
        Me.LblNewelToOverall.TabIndex = 3
        Me.LblNewelToOverall.Text = "Newel to Overall"
        '
        'PicBetween
        '
        Me.PicBetween.BackColor = System.Drawing.SystemColors.Control
        Me.PicBetween.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBetween.Image = Global.Spindle_Spacing.My.Resources.Resources.SpindlesDim3
        Me.PicBetween.Location = New System.Drawing.Point(2, 32)
        Me.PicBetween.Name = "PicBetween"
        Me.PicBetween.Size = New System.Drawing.Size(493, 155)
        Me.PicBetween.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicBetween.TabIndex = 6
        Me.PicBetween.TabStop = False
        '
        'PicOverall
        '
        Me.PicOverall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicOverall.Image = Global.Spindle_Spacing.My.Resources.Resources.SpindlesDim1
        Me.PicOverall.Location = New System.Drawing.Point(2, 32)
        Me.PicOverall.Name = "PicOverall"
        Me.PicOverall.Size = New System.Drawing.Size(347, 132)
        Me.PicOverall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicOverall.TabIndex = 5
        Me.PicOverall.TabStop = False
        '
        'PicNeweltoOver
        '
        Me.PicNeweltoOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicNeweltoOver.Image = Global.Spindle_Spacing.My.Resources.Resources.SpindlesDim2
        Me.PicNeweltoOver.Location = New System.Drawing.Point(2, 32)
        Me.PicNeweltoOver.Name = "PicNeweltoOver"
        Me.PicNeweltoOver.Size = New System.Drawing.Size(340, 152)
        Me.PicNeweltoOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicNeweltoOver.TabIndex = 4
        Me.PicNeweltoOver.TabStop = False
        '
        'PnlHeader
        '
        Me.PnlHeader.Controls.Add(Me.PnlScreenOptions)
        Me.PnlHeader.Controls.Add(Me.BtnExit)
        Me.PnlHeader.Controls.Add(Me.Label1)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Padding = New System.Windows.Forms.Padding(20)
        Me.PnlHeader.Size = New System.Drawing.Size(1287, 160)
        Me.PnlHeader.TabIndex = 7
        '
        'PnlScreenOptions
        '
        Me.PnlScreenOptions.Controls.Add(Me.BtnOtherScreen2)
        Me.PnlScreenOptions.Controls.Add(Me.BtnOtherScreen1)
        Me.PnlScreenOptions.Controls.Add(Me.BtnPrimaryScreen)
        Me.PnlScreenOptions.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlScreenOptions.Location = New System.Drawing.Point(775, 20)
        Me.PnlScreenOptions.Name = "PnlScreenOptions"
        Me.PnlScreenOptions.Size = New System.Drawing.Size(332, 120)
        Me.PnlScreenOptions.TabIndex = 53
        '
        'BtnOtherScreen2
        '
        Me.BtnOtherScreen2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnOtherScreen2.Location = New System.Drawing.Point(5, 0)
        Me.BtnOtherScreen2.Name = "BtnOtherScreen2"
        Me.BtnOtherScreen2.Size = New System.Drawing.Size(122, 120)
        Me.BtnOtherScreen2.TabIndex = 50
        Me.BtnOtherScreen2.Text = "Other Screen 2"
        Me.BtnOtherScreen2.UseVisualStyleBackColor = True
        Me.BtnOtherScreen2.Visible = False
        '
        'BtnOtherScreen1
        '
        Me.BtnOtherScreen1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnOtherScreen1.Location = New System.Drawing.Point(127, 0)
        Me.BtnOtherScreen1.Name = "BtnOtherScreen1"
        Me.BtnOtherScreen1.Size = New System.Drawing.Size(113, 120)
        Me.BtnOtherScreen1.TabIndex = 49
        Me.BtnOtherScreen1.Text = "Other Screen 1"
        Me.BtnOtherScreen1.UseVisualStyleBackColor = True
        Me.BtnOtherScreen1.Visible = False
        '
        'BtnPrimaryScreen
        '
        Me.BtnPrimaryScreen.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnPrimaryScreen.Location = New System.Drawing.Point(240, 0)
        Me.BtnPrimaryScreen.Name = "BtnPrimaryScreen"
        Me.BtnPrimaryScreen.Size = New System.Drawing.Size(92, 120)
        Me.BtnPrimaryScreen.TabIndex = 51
        Me.BtnPrimaryScreen.Text = "Primary Screen"
        Me.BtnPrimaryScreen.UseVisualStyleBackColor = True
        Me.BtnPrimaryScreen.Visible = False
        '
        'BtnExit
        '
        Me.BtnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(1107, 20)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(160, 120)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'PnlFooter
        '
        Me.PnlFooter.Controls.Add(Me.LblVer)
        Me.PnlFooter.Controls.Add(Me.Label6)
        Me.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlFooter.Location = New System.Drawing.Point(0, 942)
        Me.PnlFooter.Name = "PnlFooter"
        Me.PnlFooter.Size = New System.Drawing.Size(1287, 38)
        Me.PnlFooter.TabIndex = 19
        '
        'LblVer
        '
        Me.LblVer.AutoSize = True
        Me.LblVer.Dock = System.Windows.Forms.DockStyle.Left
        Me.LblVer.Location = New System.Drawing.Point(0, 0)
        Me.LblVer.Name = "LblVer"
        Me.LblVer.Size = New System.Drawing.Size(0, 13)
        Me.LblVer.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PnlXType)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PnlRight)
        Me.Panel2.Controls.Add(Me.PnlLeft)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1287, 782)
        Me.Panel2.TabIndex = 20
        '
        'PnlXType
        '
        Me.PnlXType.Controls.Add(Me.LblDimX)
        Me.PnlXType.Controls.Add(Me.PnlSpindleX)
        Me.PnlXType.Controls.Add(Me.PnlDimX)
        Me.PnlXType.Controls.Add(Me.PnlBetween)
        Me.PnlXType.Controls.Add(Me.PnlNewelToOver)
        Me.PnlXType.Controls.Add(Me.PnlOverall)
        Me.PnlXType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlXType.Location = New System.Drawing.Point(68, 88)
        Me.PnlXType.Name = "PnlXType"
        Me.PnlXType.Size = New System.Drawing.Size(1024, 694)
        Me.PnlXType.TabIndex = 8
        '
        'LblDimX
        '
        Me.LblDimX.AutoSize = True
        Me.LblDimX.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblDimX.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDimX.Location = New System.Drawing.Point(0, 586)
        Me.LblDimX.Name = "LblDimX"
        Me.LblDimX.Size = New System.Drawing.Size(413, 108)
        Me.LblDimX.TabIndex = 13
        Me.LblDimX.Text = "LblDimX"
        Me.LblDimX.Visible = False
        '
        'PnlSpindleX
        '
        Me.PnlSpindleX.Controls.Add(Me.Label7)
        Me.PnlSpindleX.Controls.Add(Me.TxtSpindleX)
        Me.PnlSpindleX.Controls.Add(Me.Label4)
        Me.PnlSpindleX.Controls.Add(Me.Label5)
        Me.PnlSpindleX.Location = New System.Drawing.Point(467, 215)
        Me.PnlSpindleX.Name = "PnlSpindleX"
        Me.PnlSpindleX.Size = New System.Drawing.Size(242, 144)
        Me.PnlSpindleX.TabIndex = 12
        Me.PnlSpindleX.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(156, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 42)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "mm"
        '
        'TxtSpindleX
        '
        Me.TxtSpindleX.Dock = System.Windows.Forms.DockStyle.Left
        Me.TxtSpindleX.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSpindleX.Location = New System.Drawing.Point(0, 16)
        Me.TxtSpindleX.Name = "TxtSpindleX"
        Me.TxtSpindleX.Size = New System.Drawing.Size(156, 116)
        Me.TxtSpindleX.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 42)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "mm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Spindle Size (In the 'X' direction)"
        '
        'PnlDimX
        '
        Me.PnlDimX.Controls.Add(Me.Label3)
        Me.PnlDimX.Controls.Add(Me.TxtX)
        Me.PnlDimX.Controls.Add(Me.Label2)
        Me.PnlDimX.Location = New System.Drawing.Point(435, 39)
        Me.PnlDimX.Name = "PnlDimX"
        Me.PnlDimX.Size = New System.Drawing.Size(362, 144)
        Me.PnlDimX.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 42)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "mm"
        '
        'TxtX
        '
        Me.TxtX.Dock = System.Windows.Forms.DockStyle.Left
        Me.TxtX.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtX.Location = New System.Drawing.Point(0, 16)
        Me.TxtX.MinimumSize = New System.Drawing.Size(268, 4)
        Me.TxtX.Name = "TxtX"
        Me.TxtX.Size = New System.Drawing.Size(268, 116)
        Me.TxtX.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Dimension 'X'"
        '
        'PnlBetween
        '
        Me.PnlBetween.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBetween.Controls.Add(Me.LblBetween)
        Me.PnlBetween.Controls.Add(Me.PicBetween)
        Me.PnlBetween.Location = New System.Drawing.Point(6, 378)
        Me.PnlBetween.Name = "PnlBetween"
        Me.PnlBetween.Size = New System.Drawing.Size(499, 193)
        Me.PnlBetween.TabIndex = 9
        '
        'PnlNewelToOver
        '
        Me.PnlNewelToOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlNewelToOver.Controls.Add(Me.PicNeweltoOver)
        Me.PnlNewelToOver.Controls.Add(Me.LblNewelToOverall)
        Me.PnlNewelToOver.Location = New System.Drawing.Point(6, 182)
        Me.PnlNewelToOver.Name = "PnlNewelToOver"
        Me.PnlNewelToOver.Size = New System.Drawing.Size(346, 190)
        Me.PnlNewelToOver.TabIndex = 8
        '
        'PnlOverall
        '
        Me.PnlOverall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOverall.Controls.Add(Me.PicOverall)
        Me.PnlOverall.Controls.Add(Me.LblOveralRun)
        Me.PnlOverall.Location = New System.Drawing.Point(6, 6)
        Me.PnlOverall.Name = "PnlOverall"
        Me.PnlOverall.Size = New System.Drawing.Size(353, 170)
        Me.PnlOverall.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LblMessage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(68, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel3.Size = New System.Drawing.Size(1024, 88)
        Me.Panel3.TabIndex = 10
        '
        'LblMessage
        '
        Me.LblMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.Location = New System.Drawing.Point(20, 20)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(984, 42)
        Me.LblMessage.TabIndex = 0
        Me.LblMessage.Text = "Select Dimension (X) Type ?"
        Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PnlRight
        '
        Me.PnlRight.Controls.Add(Me.BtnSummary)
        Me.PnlRight.Controls.Add(Me.BtnCalculate)
        Me.PnlRight.Controls.Add(Me.BtnSelectAgain)
        Me.PnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlRight.Location = New System.Drawing.Point(1092, 0)
        Me.PnlRight.Name = "PnlRight"
        Me.PnlRight.Size = New System.Drawing.Size(195, 782)
        Me.PnlRight.TabIndex = 9
        '
        'BtnSummary
        '
        Me.BtnSummary.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSummary.Location = New System.Drawing.Point(0, 126)
        Me.BtnSummary.Name = "BtnSummary"
        Me.BtnSummary.Size = New System.Drawing.Size(195, 63)
        Me.BtnSummary.TabIndex = 2
        Me.BtnSummary.Text = "Summary"
        Me.BtnSummary.UseVisualStyleBackColor = True
        Me.BtnSummary.Visible = False
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(0, 63)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(195, 63)
        Me.BtnCalculate.TabIndex = 1
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        Me.BtnCalculate.Visible = False
        '
        'BtnSelectAgain
        '
        Me.BtnSelectAgain.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSelectAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectAgain.Location = New System.Drawing.Point(0, 0)
        Me.BtnSelectAgain.Name = "BtnSelectAgain"
        Me.BtnSelectAgain.Size = New System.Drawing.Size(195, 63)
        Me.BtnSelectAgain.TabIndex = 0
        Me.BtnSelectAgain.Text = "Select again"
        Me.BtnSelectAgain.UseVisualStyleBackColor = True
        Me.BtnSelectAgain.Visible = False
        '
        'PnlLeft
        '
        Me.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.PnlLeft.Name = "PnlLeft"
        Me.PnlLeft.Size = New System.Drawing.Size(68, 782)
        Me.PnlLeft.TabIndex = 7
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 980)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PnlFooter)
        Me.Controls.Add(Me.PnlHeader)
        Me.Name = "StartPage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PicBetween, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOverall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNeweltoOver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.PnlScreenOptions.ResumeLayout(False)
        Me.PnlFooter.ResumeLayout(False)
        Me.PnlFooter.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PnlXType.ResumeLayout(False)
        Me.PnlXType.PerformLayout()
        Me.PnlSpindleX.ResumeLayout(False)
        Me.PnlSpindleX.PerformLayout()
        Me.PnlDimX.ResumeLayout(False)
        Me.PnlDimX.PerformLayout()
        Me.PnlBetween.ResumeLayout(False)
        Me.PnlBetween.PerformLayout()
        Me.PnlNewelToOver.ResumeLayout(False)
        Me.PnlNewelToOver.PerformLayout()
        Me.PnlOverall.ResumeLayout(False)
        Me.PnlOverall.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PnlRight.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblBetween As Label
    Friend WithEvents LblOveralRun As Label
    Friend WithEvents LblNewelToOverall As Label
    Friend WithEvents PicNeweltoOver As PictureBox
    Friend WithEvents PicOverall As PictureBox
    Friend WithEvents PicBetween As PictureBox
    Friend WithEvents PnlHeader As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents PnlFooter As Panel
    Friend WithEvents LblVer As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlXType As Panel
    Friend WithEvents PnlLeft As Panel
    Friend WithEvents PnlRight As Panel
    Friend WithEvents PnlOverall As Panel
    Friend WithEvents PnlNewelToOver As Panel
    Friend WithEvents PnlBetween As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblMessage As Label
    Friend WithEvents BtnSelectAgain As Button
    Friend WithEvents TxtX As TextBox
    Friend WithEvents PnlDimX As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PnlSpindleX As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSpindleX As TextBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents LblDimX As Label
    Friend WithEvents PnlScreenOptions As Panel
    Friend WithEvents BtnOtherScreen2 As Button
    Friend WithEvents BtnOtherScreen1 As Button
    Friend WithEvents BtnPrimaryScreen As Button
    Friend WithEvents BtnSummary As Button
    Friend WithEvents Label7 As Label
End Class
