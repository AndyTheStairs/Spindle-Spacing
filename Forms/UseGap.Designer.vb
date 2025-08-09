<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UseGap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblStdCalculated = New System.Windows.Forms.Label()
        Me.ContextMenuStdCalc = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToClipboardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImgClip = New System.Windows.Forms.PictureBox()
        Me.PnlStdCalcBorder = New System.Windows.Forms.Panel()
        Me.PnlStdRoundedBorder = New System.Windows.Forms.Panel()
        Me.LblStdRounded = New System.Windows.Forms.Label()
        Me.ContextMenuStdRounded = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlRedRoundedBorder = New System.Windows.Forms.Panel()
        Me.LblRedRounded = New System.Windows.Forms.Label()
        Me.ContextMenuRedRounded = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToClipboardToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlRedCalcBorder = New System.Windows.Forms.Panel()
        Me.LblRedCalculated = New System.Windows.Forms.Label()
        Me.ContextMenuRedCalc = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToClipboardToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContextMenuStdCalc.SuspendLayout()
        CType(Me.ImgClip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlStdCalcBorder.SuspendLayout()
        Me.PnlStdRoundedBorder.SuspendLayout()
        Me.ContextMenuStdRounded.SuspendLayout()
        Me.PnlRedRoundedBorder.SuspendLayout()
        Me.ContextMenuRedRounded.SuspendLayout()
        Me.PnlRedCalcBorder.SuspendLayout()
        Me.ContextMenuRedCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(766, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(83, 42)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Use the Selected Gap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Standard Gap (Rounded)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Standard Gap (Calculated)"
        '
        'LblStdCalculated
        '
        Me.LblStdCalculated.AutoSize = True
        Me.LblStdCalculated.BackColor = System.Drawing.SystemColors.Control
        Me.LblStdCalculated.ContextMenuStrip = Me.ContextMenuStdCalc
        Me.LblStdCalculated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblStdCalculated.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStdCalculated.Location = New System.Drawing.Point(3, 3)
        Me.LblStdCalculated.Name = "LblStdCalculated"
        Me.LblStdCalculated.Size = New System.Drawing.Size(174, 25)
        Me.LblStdCalculated.TabIndex = 5
        Me.LblStdCalculated.Text = "Calculated Gap"
        '
        'ContextMenuStdCalc
        '
        Me.ContextMenuStdCalc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToClipboardToolStripMenuItem1})
        Me.ContextMenuStdCalc.Name = "ContextMenuCalc"
        Me.ContextMenuStdCalc.Size = New System.Drawing.Size(172, 26)
        '
        'CopyToClipboardToolStripMenuItem1
        '
        Me.CopyToClipboardToolStripMenuItem1.Name = "CopyToClipboardToolStripMenuItem1"
        Me.CopyToClipboardToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.CopyToClipboardToolStripMenuItem1.Text = "Copy to Clipboard"
        '
        'ImgClip
        '
        Me.ImgClip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImgClip.Location = New System.Drawing.Point(0, 0)
        Me.ImgClip.Name = "ImgClip"
        Me.ImgClip.Size = New System.Drawing.Size(861, 299)
        Me.ImgClip.TabIndex = 110
        Me.ImgClip.TabStop = False
        '
        'PnlStdCalcBorder
        '
        Me.PnlStdCalcBorder.Controls.Add(Me.LblStdCalculated)
        Me.PnlStdCalcBorder.Location = New System.Drawing.Point(140, 178)
        Me.PnlStdCalcBorder.Name = "PnlStdCalcBorder"
        Me.PnlStdCalcBorder.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlStdCalcBorder.Size = New System.Drawing.Size(187, 39)
        Me.PnlStdCalcBorder.TabIndex = 111
        '
        'PnlStdRoundedBorder
        '
        Me.PnlStdRoundedBorder.Controls.Add(Me.LblStdRounded)
        Me.PnlStdRoundedBorder.Location = New System.Drawing.Point(140, 80)
        Me.PnlStdRoundedBorder.Name = "PnlStdRoundedBorder"
        Me.PnlStdRoundedBorder.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlStdRoundedBorder.Size = New System.Drawing.Size(187, 39)
        Me.PnlStdRoundedBorder.TabIndex = 113
        '
        'LblStdRounded
        '
        Me.LblStdRounded.AutoSize = True
        Me.LblStdRounded.BackColor = System.Drawing.SystemColors.Control
        Me.LblStdRounded.ContextMenuStrip = Me.ContextMenuStdRounded
        Me.LblStdRounded.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblStdRounded.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStdRounded.Location = New System.Drawing.Point(3, 3)
        Me.LblStdRounded.Name = "LblStdRounded"
        Me.LblStdRounded.Size = New System.Drawing.Size(156, 25)
        Me.LblStdRounded.TabIndex = 5
        Me.LblStdRounded.Text = "Rounded Gap"
        '
        'ContextMenuStdRounded
        '
        Me.ContextMenuStdRounded.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToClipboardToolStripMenuItem})
        Me.ContextMenuStdRounded.Name = "ContextMenuRounded"
        Me.ContextMenuStdRounded.Size = New System.Drawing.Size(172, 26)
        '
        'CopyToClipboardToolStripMenuItem
        '
        Me.CopyToClipboardToolStripMenuItem.Name = "CopyToClipboardToolStripMenuItem"
        Me.CopyToClipboardToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CopyToClipboardToolStripMenuItem.Text = "Copy to Clipboard"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(205, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 39)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "X"
        '
        'PnlRedRoundedBorder
        '
        Me.PnlRedRoundedBorder.Controls.Add(Me.LblRedRounded)
        Me.PnlRedRoundedBorder.Location = New System.Drawing.Point(471, 80)
        Me.PnlRedRoundedBorder.Name = "PnlRedRoundedBorder"
        Me.PnlRedRoundedBorder.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlRedRoundedBorder.Size = New System.Drawing.Size(187, 39)
        Me.PnlRedRoundedBorder.TabIndex = 118
        '
        'LblRedRounded
        '
        Me.LblRedRounded.AutoSize = True
        Me.LblRedRounded.BackColor = System.Drawing.SystemColors.Control
        Me.LblRedRounded.ContextMenuStrip = Me.ContextMenuRedRounded
        Me.LblRedRounded.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblRedRounded.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRedRounded.Location = New System.Drawing.Point(3, 3)
        Me.LblRedRounded.Name = "LblRedRounded"
        Me.LblRedRounded.Size = New System.Drawing.Size(156, 25)
        Me.LblRedRounded.TabIndex = 5
        Me.LblRedRounded.Text = "Rounded Gap"
        '
        'ContextMenuRedRounded
        '
        Me.ContextMenuRedRounded.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToClipboardToolStripMenuItem2})
        Me.ContextMenuRedRounded.Name = "ContextMenuRedRounded"
        Me.ContextMenuRedRounded.Size = New System.Drawing.Size(172, 26)
        '
        'CopyToClipboardToolStripMenuItem2
        '
        Me.CopyToClipboardToolStripMenuItem2.Name = "CopyToClipboardToolStripMenuItem2"
        Me.CopyToClipboardToolStripMenuItem2.Size = New System.Drawing.Size(171, 22)
        Me.CopyToClipboardToolStripMenuItem2.Text = "Copy to Clipboard"
        '
        'PnlRedCalcBorder
        '
        Me.PnlRedCalcBorder.Controls.Add(Me.LblRedCalculated)
        Me.PnlRedCalcBorder.Location = New System.Drawing.Point(471, 178)
        Me.PnlRedCalcBorder.Name = "PnlRedCalcBorder"
        Me.PnlRedCalcBorder.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlRedCalcBorder.Size = New System.Drawing.Size(187, 39)
        Me.PnlRedCalcBorder.TabIndex = 117
        '
        'LblRedCalculated
        '
        Me.LblRedCalculated.AutoSize = True
        Me.LblRedCalculated.BackColor = System.Drawing.SystemColors.Control
        Me.LblRedCalculated.ContextMenuStrip = Me.ContextMenuRedCalc
        Me.LblRedCalculated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblRedCalculated.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRedCalculated.Location = New System.Drawing.Point(3, 3)
        Me.LblRedCalculated.Name = "LblRedCalculated"
        Me.LblRedCalculated.Size = New System.Drawing.Size(174, 25)
        Me.LblRedCalculated.TabIndex = 5
        Me.LblRedCalculated.Text = "Calculated Gap"
        '
        'ContextMenuRedCalc
        '
        Me.ContextMenuRedCalc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToClipboardToolStripMenuItem3})
        Me.ContextMenuRedCalc.Name = "ContextMenuRedCalc"
        Me.ContextMenuRedCalc.Size = New System.Drawing.Size(172, 26)
        '
        'CopyToClipboardToolStripMenuItem3
        '
        Me.CopyToClipboardToolStripMenuItem3.Name = "CopyToClipboardToolStripMenuItem3"
        Me.CopyToClipboardToolStripMenuItem3.Size = New System.Drawing.Size(171, 22)
        Me.CopyToClipboardToolStripMenuItem3.Text = "Copy to Clipboard"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(382, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 13)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Reduced Gap (Calculated)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 13)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Reduced Gap (Rounded)"
        '
        'UseGap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnlRedRoundedBorder)
        Me.Controls.Add(Me.PnlRedCalcBorder)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PnlStdRoundedBorder)
        Me.Controls.Add(Me.PnlStdCalcBorder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.ImgClip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "UseGap"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContextMenuStdCalc.ResumeLayout(False)
        CType(Me.ImgClip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlStdCalcBorder.ResumeLayout(False)
        Me.PnlStdCalcBorder.PerformLayout()
        Me.PnlStdRoundedBorder.ResumeLayout(False)
        Me.PnlStdRoundedBorder.PerformLayout()
        Me.ContextMenuStdRounded.ResumeLayout(False)
        Me.PnlRedRoundedBorder.ResumeLayout(False)
        Me.PnlRedRoundedBorder.PerformLayout()
        Me.ContextMenuRedRounded.ResumeLayout(False)
        Me.PnlRedCalcBorder.ResumeLayout(False)
        Me.PnlRedCalcBorder.PerformLayout()
        Me.ContextMenuRedCalc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblStdCalculated As Label
    Friend WithEvents ImgClip As PictureBox
    Friend WithEvents PnlStdCalcBorder As Panel
    Friend WithEvents PnlStdRoundedBorder As Panel
    Friend WithEvents LblStdRounded As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStdCalc As ContextMenuStrip
    Friend WithEvents CopyToClipboardToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStdRounded As ContextMenuStrip
    Friend WithEvents CopyToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PnlRedRoundedBorder As Panel
    Friend WithEvents LblRedRounded As Label
    Friend WithEvents PnlRedCalcBorder As Panel
    Friend WithEvents LblRedCalculated As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ContextMenuRedRounded As ContextMenuStrip
    Friend WithEvents CopyToClipboardToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ContextMenuRedCalc As ContextMenuStrip
    Friend WithEvents CopyToClipboardToolStripMenuItem3 As ToolStripMenuItem
End Class
