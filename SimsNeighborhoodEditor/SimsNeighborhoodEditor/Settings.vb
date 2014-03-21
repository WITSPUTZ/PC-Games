Public Class Settings

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.UserData = Me.TextBox1.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If FolderBrowserUserData.ShowDialog() = DialogResult.OK Then
            Me.TextBox1.Text = FolderBrowserUserData.SelectedPath
            Me.TextBox3.Text = FolderBrowserUserData.SelectedPath & "\Houses"
        Else

        End If


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.TextBox3.Text <> "" Then
            Dim directory As New IO.DirectoryInfo(TextBox3.Text)
            Dim getfiles As IO.FileInfo()
            getfiles = directory.GetFiles()
            Dim fileinfos As IO.FileInfo
            For Each fileinfos In getfiles
                MainEditor.ListBox1.Items.Add(fileinfos)

            Next fileinfos
        End If

    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.UserData
        TextBox4.Text = My.Settings.UIPATH
    End Sub
End Class