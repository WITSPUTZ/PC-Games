Public Class Settings

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.GamePath
        TextBox2.Text = My.Settings.Downloads
        TextBox4.Text = My.Settings.UserData
        TextBox3.Text = My.Settings.Houses
        TextBox6.Text = My.Settings.Characters
        TextBox5.Text = My.Settings.GameData
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.GamePath = Me.TextBox1.Text
        My.Settings.UserData = Me.TextBox4.Text
        My.Settings.Houses = Me.TextBox3.Text
        My.Settings.Characters = Me.TextBox6.Text
        My.Settings.GameData = Me.TextBox5.Text
        My.Settings.Downloads = Me.TextBox2.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If FolderBrowserUserData.ShowDialog() = DialogResult.OK Then
            Me.TextBox1.Text = FolderBrowserUserData.SelectedPath
            Me.TextBox4.Text = FolderBrowserUserData.SelectedPath & "\UserData" & ComboBox1.SelectedItem
        Else
            MsgBox("Cannot open game path folder")
        End If


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        My.Settings.Houses = My.Settings.UserData & ComboBox1.SelectedItem & "\Houses\"
        TextBox3.Text = My.Settings.Houses
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        Else
            MsgBox("Cannot open downloads folder")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox5.Text = FolderBrowserDialog1.SelectedPath
        Else
            MsgBox("Cannot open gamedata folder")
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        My.Settings.Characters = My.Settings.UserData & ComboBox1.SelectedItem & "\Characters\"
        TextBox6.Text = My.Settings.Characters
        My.Settings.Save()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim readValue = My.Computer.Registry.GetValue(
"HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims", "Version", Nothing)
        Dim languangevalue = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims", "SIMS_LANGUAGE", Nothing)
        Dim gamevalue = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims", "SIMS_DATA", Nothing)
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims",
"Version", Nothing) > 0 Then
            Me.TextBox7.Text = readValue & languangevalue
            Me.TextBox1.Text = gamevalue
        Else
            MsgBox("Cannot found registry version in" & readValue)
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        Else
            MsgBox("Cannot open downloads folder")
        End If
    End Sub
End Class