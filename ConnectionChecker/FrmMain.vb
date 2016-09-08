Imports System.ComponentModel

Public Class FrmMain
    WithEvents pinger As New Net.NetworkInformation.Ping
    Dim LastCheckAllReached As Boolean = False, loaded As Boolean = False
    Dim ip As String
    Dim settings As New Settings

    Private Sub FrmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        NI.Visible = False
    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Hide() 'Hide in tray
        e.Cancel = True
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon_neu
        NI.Icon = My.Resources.icon
        TsLblStatus.Text = "Loading settings..."
        LoadSettings()
        TsLblStatus.Text = ""
        If settings.StartHidden Then
            Opacity = 0
        End If
    End Sub

    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If settings.StartHidden = True Then
            Hide()
            Opacity = 100
        End If
        PingIps(Me, New EventArgs)
    End Sub

    Private Sub ShowForm(sender As Object, e As EventArgs) Handles NI.MouseDoubleClick, TsmiShow.Click
        Show()
    End Sub

    Private Sub PingIps(sender As Object, e As EventArgs) Handles TmrCheck.Tick, TsmiCheck.Click
        If ClbIps.Items.Count = 0 Then
            NI.Icon = My.Resources.icon_neu
            Exit Sub
        Else
            NI.Icon = My.Resources.icon
        End If
        TmrCheck.Enabled = False
        ClbIps.Enabled = False
        TbIp.Enabled = False
        TlpIpsAddRemove.Enabled = False

        TsPb.Value = 0
        Dim clbTemp As New CheckedListBox
        For Each item As String In ClbIps.Items
            clbTemp.Items.Add(item)
        Next
        TsPb.Maximum = clbTemp.Items.Count
        For Each ip In clbTemp.Items
            ClbIps.SetItemCheckState(clbTemp.Items.IndexOf(ip), CheckState.Unchecked)
        Next
        For Each ip As String In clbTemp.Items
            TsLblStatus.Text = "Pinging " & ip
            ClbIps.SetItemCheckState(clbTemp.Items.IndexOf(ip), CheckState.Indeterminate)
            Update()
            Try
                Dim pingReply As Net.NetworkInformation.PingReply
                pingReply = pinger.Send(ip, 3000)
                If pingReply.Status = Net.NetworkInformation.IPStatus.Success Then
                    ClbIps.SetItemCheckState(clbTemp.Items.IndexOf(ip), CheckState.Checked)
                Else
                    ClbIps.SetItemCheckState(clbTemp.Items.IndexOf(ip), CheckState.Unchecked)
                End If
            Catch ex As Exception
                ClbIps.SetItemCheckState(clbTemp.Items.IndexOf(ip), CheckState.Unchecked)
            End Try
            TsPb.PerformStep()
            Update()
        Next

        If ClbIps.CheckedItems.Count = ClbIps.Items.Count Then
            NI.Icon = My.Resources.icon_okay
            NI.BalloonTipIcon = ToolTipIcon.Info
            If LastCheckAllReached = False Or sender Is TsmiCheck Then
                NI.BalloonTipText = "All ips are pingable!"
                LastCheckAllReached = True
                NI.ShowBalloonTip(3000)
            End If
        Else
            NI.Icon = My.Resources.icon_error
            NI.BalloonTipIcon = ToolTipIcon.Warning
            NI.BalloonTipText = "Following ips are not pingable:" & Environment.NewLine
            For Each item As String In ClbIps.Items
                If ClbIps.CheckedItems.Contains(item) = False Then
                    NI.BalloonTipText &= item & ", "
                End If
            Next
            NI.BalloonTipText = NI.BalloonTipText.Remove(NI.BalloonTipText.Count - 2)
            LastCheckAllReached = False
            NI.ShowBalloonTip(3000)
        End If
        TmrCheck.Enabled = True
        ClbIps.Enabled = True
        TbIp.Enabled = True
        TlpIpsAddRemove.Enabled = True
        TsLblStatus.Text = "Finished at " & Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub BtnAddIp_Click(sender As Object, e As EventArgs) Handles BtnAddIp.Click
        If TbIp.Text.Contains(",") Or TbIp.Text.Contains(" ") Then
            MessageBox.Show(Me, "The IP contains invalid chars!", "Invalid chars", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(TbIp.Text) = False Then
            If ClbIps.Items.Contains(TbIp.Text) Then
                MessageBox.Show(Me, "The IP you have entered already exists!", "IP already exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                ClbIps.Items.Add(TbIp.Text)
                TbIp.Clear()
                SaveSettings()
            End If
        End If
    End Sub

    Private Sub NudInterval_ValueChanged(sender As Object, e As EventArgs) Handles NudInterval.ValueChanged
        If NudInterval.Value = 0 Then
            TmrCheck.Interval = CInt(30 * 1000)
        Else
            TmrCheck.Interval = CInt(NudInterval.Value * 60 * 1000)
        End If
        SaveSettings()
    End Sub

    Private Sub ExitApplication(sender As Object, e As EventArgs) Handles TsmiExit.Click, TsBtnExit.Click
        TmrCheck.Enabled = False
        NI.Visible = False
        Application.Exit()
    End Sub

    Private Sub BtnRemoveIp_Click(sender As Object, e As EventArgs) Handles BtnRemoveIp.Click
        If ClbIps.SelectedItems.Count = 0 Then
            MessageBox.Show(Me, "Please select an ip to remove it.", "No ip selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            ClbIps.Items.Remove(ClbIps.SelectedItem)
            SaveSettings()
        End If
    End Sub

    Private Sub CbStartHidden_CheckedChanged(sender As Object, e As EventArgs) Handles CbStartHidden.CheckedChanged
        SaveSettings()
    End Sub

    Private Sub LoadSettings()
        ClbIps.Items.Clear()

        Dim settingsFilePath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ConnectionChecker\ConnectionChecker.xml")
        If IO.File.Exists(settingsFilePath) = True Then
            Try
                Using reader As New IO.StreamReader(settingsFilePath)
                    Dim serializer As New Xml.Serialization.XmlSerializer(settings.GetType())
                    settings = CType(serializer.Deserialize(reader), Settings)
                End Using
                ClbIps.Items.AddRange(settings.Ips.ToArray)
                NudInterval.Value = settings.Interval
                CbStartHidden.Checked = settings.StartHidden
            Catch ex As Exception
                MessageBox.Show(Me, ex.ToString, "Can't load settings!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                NudInterval.Value = 10
            End Try
        Else
            NudInterval.Value = 10
        End If
        loaded = True
    End Sub

    Private Sub SaveSettings()
        If loaded = False Then
            Exit Sub
        End If

        settings.Ips.Clear()
        For Each item As String In ClbIps.Items
            settings.Ips.Add(item)
        Next
        settings.Interval = CInt(NudInterval.Value)
        settings.StartHidden = CbStartHidden.Checked

        Try
            Dim settingsFilePath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ConnectionChecker\ConnectionChecker.xml")

            If IO.Directory.Exists(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ConnectionChecker")) = False Then
                IO.Directory.CreateDirectory(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ConnectionChecker"))
            End If

            'Serialize settings
            Using writer As New IO.StreamWriter(settingsFilePath)
                Dim serializer As New Xml.Serialization.XmlSerializer(settings.GetType())
                serializer.Serialize(writer, settings)
            End Using
        Catch ex As Exception
            MessageBox.Show(Me, ex.ToString, "Can't save settings!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class
