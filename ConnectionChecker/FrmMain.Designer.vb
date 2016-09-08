<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NI = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CsmNotifier = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TsmiShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiCheck = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.ClbIps = New System.Windows.Forms.CheckedListBox()
        Me.StSt = New System.Windows.Forms.StatusStrip()
        Me.TsBtnExit = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TsPb = New System.Windows.Forms.ToolStripProgressBar()
        Me.TsLblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TbIp = New System.Windows.Forms.TextBox()
        Me.BtnAddIp = New System.Windows.Forms.Button()
        Me.BtnRemoveIp = New System.Windows.Forms.Button()
        Me.TlpIpsAddRemove = New System.Windows.Forms.TableLayoutPanel()
        Me.LblInterval1 = New System.Windows.Forms.Label()
        Me.NudInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbStartHidden = New System.Windows.Forms.CheckBox()
        Me.CsmNotifier.SuspendLayout()
        Me.StSt.SuspendLayout()
        Me.TlpIpsAddRemove.SuspendLayout()
        CType(Me.NudInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NI
        '
        Me.NI.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NI.BalloonTipTitle = "Connection check result"
        Me.NI.ContextMenuStrip = Me.CsmNotifier
        Me.NI.Visible = True
        '
        'CsmNotifier
        '
        Me.CsmNotifier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmiShow, Me.TsmiCheck, Me.TsmiExit})
        Me.CsmNotifier.Name = "CsmNotifier"
        Me.CsmNotifier.Size = New System.Drawing.Size(108, 70)
        '
        'TsmiShow
        '
        Me.TsmiShow.Name = "TsmiShow"
        Me.TsmiShow.Size = New System.Drawing.Size(107, 22)
        Me.TsmiShow.Text = "Show"
        '
        'TsmiCheck
        '
        Me.TsmiCheck.Name = "TsmiCheck"
        Me.TsmiCheck.Size = New System.Drawing.Size(107, 22)
        Me.TsmiCheck.Text = "Check"
        '
        'TsmiExit
        '
        Me.TsmiExit.Name = "TsmiExit"
        Me.TsmiExit.Size = New System.Drawing.Size(107, 22)
        Me.TsmiExit.Text = "Exit"
        '
        'TmrCheck
        '
        Me.TmrCheck.Enabled = True
        Me.TmrCheck.Interval = 10000
        '
        'ClbIps
        '
        Me.ClbIps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClbIps.FormattingEnabled = True
        Me.ClbIps.IntegralHeight = False
        Me.ClbIps.Location = New System.Drawing.Point(12, 12)
        Me.ClbIps.Name = "ClbIps"
        Me.ClbIps.Size = New System.Drawing.Size(260, 107)
        Me.ClbIps.TabIndex = 0
        Me.ClbIps.UseCompatibleTextRendering = True
        '
        'StSt
        '
        Me.StSt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsBtnExit, Me.TsPb, Me.TsLblStatus})
        Me.StSt.Location = New System.Drawing.Point(0, 239)
        Me.StSt.Name = "StSt"
        Me.StSt.Size = New System.Drawing.Size(284, 22)
        Me.StSt.TabIndex = 6
        Me.StSt.Text = "StatusStrip1"
        '
        'TsBtnExit
        '
        Me.TsBtnExit.Image = Global.ConnectionChecker.My.Resources.Resources.Cancel
        Me.TsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsBtnExit.Name = "TsBtnExit"
        Me.TsBtnExit.ShowDropDownArrow = False
        Me.TsBtnExit.Size = New System.Drawing.Size(45, 20)
        Me.TsBtnExit.Text = "Exit"
        '
        'TsPb
        '
        Me.TsPb.Name = "TsPb"
        Me.TsPb.Size = New System.Drawing.Size(100, 16)
        '
        'TsLblStatus
        '
        Me.TsLblStatus.Name = "TsLblStatus"
        Me.TsLblStatus.Size = New System.Drawing.Size(39, 17)
        Me.TsLblStatus.Text = "Status"
        '
        'TbIp
        '
        Me.TbIp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbIp.Location = New System.Drawing.Point(12, 125)
        Me.TbIp.Name = "TbIp"
        Me.TbIp.Size = New System.Drawing.Size(260, 22)
        Me.TbIp.TabIndex = 1
        '
        'BtnAddIp
        '
        Me.BtnAddIp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAddIp.Image = Global.ConnectionChecker.My.Resources.Resources.Add
        Me.BtnAddIp.Location = New System.Drawing.Point(3, 3)
        Me.BtnAddIp.Name = "BtnAddIp"
        Me.BtnAddIp.Size = New System.Drawing.Size(124, 23)
        Me.BtnAddIp.TabIndex = 0
        Me.BtnAddIp.Text = "&Add IP"
        Me.BtnAddIp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddIp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddIp.UseVisualStyleBackColor = True
        '
        'BtnRemoveIp
        '
        Me.BtnRemoveIp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRemoveIp.Image = Global.ConnectionChecker.My.Resources.Resources.Remove
        Me.BtnRemoveIp.Location = New System.Drawing.Point(133, 3)
        Me.BtnRemoveIp.Name = "BtnRemoveIp"
        Me.BtnRemoveIp.Size = New System.Drawing.Size(124, 23)
        Me.BtnRemoveIp.TabIndex = 1
        Me.BtnRemoveIp.Text = "&Remove"
        Me.BtnRemoveIp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRemoveIp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRemoveIp.UseVisualStyleBackColor = True
        '
        'TlpIpsAddRemove
        '
        Me.TlpIpsAddRemove.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TlpIpsAddRemove.ColumnCount = 2
        Me.TlpIpsAddRemove.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpIpsAddRemove.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpIpsAddRemove.Controls.Add(Me.BtnAddIp, 0, 0)
        Me.TlpIpsAddRemove.Controls.Add(Me.BtnRemoveIp, 1, 0)
        Me.TlpIpsAddRemove.Location = New System.Drawing.Point(12, 153)
        Me.TlpIpsAddRemove.Name = "TlpIpsAddRemove"
        Me.TlpIpsAddRemove.RowCount = 1
        Me.TlpIpsAddRemove.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpIpsAddRemove.Size = New System.Drawing.Size(260, 29)
        Me.TlpIpsAddRemove.TabIndex = 2
        '
        'LblInterval1
        '
        Me.LblInterval1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblInterval1.AutoSize = True
        Me.LblInterval1.Location = New System.Drawing.Point(12, 193)
        Me.LblInterval1.Name = "LblInterval1"
        Me.LblInterval1.Size = New System.Drawing.Size(111, 13)
        Me.LblInterval1.TabIndex = 3
        Me.LblInterval1.Text = "&Interval: Check every"
        '
        'NudInterval
        '
        Me.NudInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NudInterval.Location = New System.Drawing.Point(129, 191)
        Me.NudInterval.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.NudInterval.Name = "NudInterval"
        Me.NudInterval.Size = New System.Drawing.Size(60, 22)
        Me.NudInterval.TabIndex = 4
        Me.NudInterval.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "minutes"
        '
        'CbStartHidden
        '
        Me.CbStartHidden.AutoSize = True
        Me.CbStartHidden.Location = New System.Drawing.Point(12, 219)
        Me.CbStartHidden.Name = "CbStartHidden"
        Me.CbStartHidden.Size = New System.Drawing.Size(90, 17)
        Me.CbStartHidden.TabIndex = 7
        Me.CbStartHidden.Text = "Start &hidden"
        Me.CbStartHidden.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CbStartHidden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NudInterval)
        Me.Controls.Add(Me.LblInterval1)
        Me.Controls.Add(Me.TlpIpsAddRemove)
        Me.Controls.Add(Me.TbIp)
        Me.Controls.Add(Me.StSt)
        Me.Controls.Add(Me.ClbIps)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(260, 230)
        Me.Name = "FrmMain"
        Me.Text = "ConnectionChecker"
        Me.CsmNotifier.ResumeLayout(False)
        Me.StSt.ResumeLayout(False)
        Me.StSt.PerformLayout()
        Me.TlpIpsAddRemove.ResumeLayout(False)
        CType(Me.NudInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NI As NotifyIcon
    Friend WithEvents TmrCheck As Timer
    Friend WithEvents CsmNotifier As ContextMenuStrip
    Friend WithEvents TsmiShow As ToolStripMenuItem
    Friend WithEvents TsmiCheck As ToolStripMenuItem
    Friend WithEvents TsmiExit As ToolStripMenuItem
    Friend WithEvents ClbIps As CheckedListBox
    Friend WithEvents StSt As StatusStrip
    Friend WithEvents TsPb As ToolStripProgressBar
    Friend WithEvents TsLblStatus As ToolStripStatusLabel
    Friend WithEvents TbIp As TextBox
    Friend WithEvents BtnAddIp As Button
    Friend WithEvents BtnRemoveIp As Button
    Friend WithEvents TsBtnExit As ToolStripDropDownButton
    Friend WithEvents TlpIpsAddRemove As TableLayoutPanel
    Friend WithEvents LblInterval1 As Label
    Friend WithEvents NudInterval As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents CbStartHidden As CheckBox
End Class
