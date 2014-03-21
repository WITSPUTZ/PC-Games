Imports System
Imports System.Text
Imports System.IO
Imports System.Net
Imports ComponentAce.Compression.ZipForge
Imports ComponentAce.Compression.Archiver
Imports System.ComponentModel


Public Class MainEditor
    Dim int As Integer = 0
    Dim label As New Label
    Dim locs As New System.Drawing.Point(x:=MousePosition.X, y:=MousePosition.Y)
    Dim process As String
    Dim client1 As WebClient
    Dim client2 As WebClient
    Dim client3 As WebClient
    Dim client4 As WebClient
    Dim client5 As WebClient
    Dim client6 As WebClient
    Dim bg As Image




    Private Sub MainEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Settings.GamePath = "" Then
                Dim Response As Integer

                ' Displays a message box with the yes and no options.
                Response = MsgBox(Prompt:="Wanna open the Sims Collection game folder?", Buttons:=vbYesNo)

                ' If statement to check if the yes button was selected.
                If Response = vbYes Then
                    FolderBrowserGame.ShowDialog()
                    Me.TextBox1.Text = FolderBrowserGame.SelectedPath



                Else
                    ' The no button was selected.
                    MsgBox("Now you cannot donwload files")
                End If

            End If
        Catch ex As Exception
            MsgBox("Cannot select the Game Path")
        End Try

        TextBox1.Text = My.Settings.GamePath
        My.Settings.GamePath = Me.TextBox1.Text
        My.Settings.UserData = My.Settings.GamePath & "\UserData\"
        My.Settings.UIPATH = My.Settings.GamePath & "\UIGraphics\"
        My.Settings.Save()



        Control.CheckForIllegalCrossThreadCalls = False
        Dim readValue = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims", "Version", Nothing)
        Dim languangevalue = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims", "SIMS_LANGUAGE", Nothing)

        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims",
"Version", Nothing) > 0 Then
            TextBox7.Text = readValue & languangevalue
        Else
            MsgBox("Cannot found registry version in" & readValue)
        End If
    End Sub


    Public Function ReadLine(ByVal lineNumber As Integer, ByVal lines As List(Of String)) As String
        Return lines(lineNumber - 1)


    End Function

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim sts As New StreamWriter(SaveFileDialog1.FileName)
            sts.WriteLine(RichTextBox1.Text)
            sts.WriteLine(Label12.Text)
            sts.WriteLine(Label13.Text)
            sts.WriteLine(Label18.Text)
            sts.WriteLine(Label19.Text)
            sts.WriteLine(Label20.Text)
            sts.WriteLine(Label21.Text)
            sts.WriteLine(Label22.Text)
            sts.WriteLine(Label23.Text)
            sts.WriteLine(Label24.Text)
            sts.WriteLine(Label25.Text)
            sts.Close()
        End If

    End Sub

    Private Sub TextEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEditorToolStripMenuItem.Click
        TextEditor.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Settings.Show()
    End Sub

    Private Sub HouseBuildToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseBuildToolStripMenuItem.Click
        LotsBuild.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Dim backgr As BackgroundWorker
        Dim backgr2 As BackgroundWorker
        backgr = BackgroundWorkerCreate
        backgr2 = BackgroundWorkerDownload
        If backgr.IsBusy Or backgr2.IsBusy Then
            MsgBox("Current operation in progress")
        Else
            If ComboBox2.SelectedItem <> "" And ComboBox1.Text <> "" Then

                Try

                    My.Computer.FileSystem.CopyDirectory((My.Settings.GamePath & "\TemplateUserData"), My.Settings.GamePath & "\" & ComboBox1.Text, True)
                    BackgroundWorkerCreate.RunWorkerAsync()

                    If Me.TextBox1.Text <> "" Then
                        Dim directory As New IO.DirectoryInfo(My.Settings.GamePath & "\UserData9\Houses\")
                        Dim getfiles As IO.FileInfo()
                        getfiles = directory.GetFiles()
                        Dim fileinfos As IO.FileInfo
                        For Each fileinfos In getfiles
                            Me.ListBox1.Items.Add(fileinfos)

                        Next fileinfos
                    End If

                    Dim info As String = (My.Settings.GamePath & "\" & ComboBox1.Text & "\" & "info.txt")

                    NumericUpDown1.Value = 9

                    Dim infor As FileInfo
                    infor = My.Computer.FileSystem.GetFileInfo(My.Settings.GamePath & "\" & ComboBox1.Text & "\" & "info.txt")
                    RichTextBox1.Text = ComboBox1.Text & vbNewLine & ComboBox2.Text & vbNewLine & infor.LastAccessTime & "Created neighborhood"
                    Label17.Text = infor.LastWriteTime
                    Dim writer As New StreamWriter(My.Settings.GamePath & "\" & ComboBox1.Text & "\" & "info.txt", False)
                    writer.WriteLine(RichTextBox1.Text)
                    writer.Close()

                Catch exception1 As Exception

                    MessageBox.Show("Files cannot be created")

                End Try
            Else
                MessageBox.Show("Select neighborhood to create and his name")
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If bg Is Nothing Then


            Dim bg As Image
            If TextBox2.Text <> "" Then

                bg = Image.FromFile(OpenFileImageBg.FileName)

                TabPageCommunity.BackgroundImage = bg
                My.Computer.FileSystem.CopyFile(OpenFileImageBg.FileName, (My.Settings.UIPATH & "Community\") & "NScreen_unleashed.bmp")

            ElseIf TextBox3.Text <> "" Then
                bg = Image.FromFile(OpenFileImageBg.FileName)

                TabPageDowntown.BackgroundImage = bg
                My.Computer.FileSystem.CopyFile(OpenFileImageBg.FileName, (My.Settings.UIPATH & "Downtown\") & "DScreen.bmp")
            ElseIf TextBox4.Text <> "" Then
                bg = Image.FromFile(OpenFileImageBg.FileName)

                TabPageVacation.BackgroundImage = bg
                My.Computer.FileSystem.CopyFile(OpenFileImageBg.FileName, (My.Settings.UIPATH & "VIsland\") & "visland.bmp")
            ElseIf TextBox5.Text <> "" Then
                bg = Image.FromFile(OpenFileImageBg.FileName)

                TabPageStudio.BackgroundImage = bg
                My.Computer.FileSystem.CopyFile(OpenFileImageBg.FileName, (My.Settings.UIPATH & "Studiotown\") & "DScreen.bmp")
            ElseIf TextBox6.Text <> "" Then
                bg = Image.FromFile(OpenFileImageBg.FileName)

                TabPageMagic.BackgroundImage = bg
                My.Computer.FileSystem.CopyFile(OpenFileImageBg.FileName, (My.Settings.UIPATH & "Magicland\") & "DScreen.bmp")
            ElseIf TextBox8.Text <> "" Then
                bg = Image.FromFile(OpenFileImageBg.FileName)

                TabPageSimple.BackgroundImage = bg
                My.Computer.FileSystem.CopyFile(OpenFileImageBg.FileName, (My.Settings.UIPATH & "Nbhd\") & "NScreen.bmp")
            Else
                MsgBox("Please select background image to import")

            End If
        Else
            MsgBox("Currently there are a background image created")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileImageBg.Filter = "BMP Images (*.bmp)|*.bmp|All Files (*.*)|*.*"
        OpenFileImageBg.FilterIndex = 1
        OpenFileImageBg.FileName = "NScreen_unleashed"
        If Me.OpenFileImageBg.ShowDialog = DialogResult.OK Then
            TextBox2.Text = OpenFileImageBg.FileName
        End If
    End Sub

    Private Sub BackgroundWorkerCreate_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerCreate.DoWork
        process = "Creating Neighborhood"

        If ComboBox2.SelectedItem = "Beachland (40 lots)" Then
            Me.client1 = New WebClient
            Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/1/NScreen_unleashed.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed.bmp")
            Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
            Me.client2 = New WebClient
            Me.client2.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/1/NScreen_unleashed_waves001.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed_waves001.bmp")
            Me.client2.Credentials = New NetworkCredential("a6174471", "simsville1")
            Me.client3 = New WebClient
            Me.client3.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/1/NScreen_unleashed_waves002.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed_waves002.bmp")
            Me.client3.Credentials = New NetworkCredential("a6174471", "simsville1")
            Me.client4 = New WebClient
            Me.client4.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/1/NScreen_unleashed_waves003.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed_waves003.bmp")
            Me.client4.Credentials = New NetworkCredential("a6174471", "simsville1")
            bg = Image.FromFile(My.Settings.GamePath & "\UIGraphics\Community\NScreen_unleashed.bmp")
            TabPageCommunity.BackgroundImage = bg
        ElseIf ComboBox2.SelectedItem = "Desertland (40 lots)" Then
            Me.client1 = New WebClient
            Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/2/NScreen_unleashed.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed.bmp")
            Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
            Me.client2 = New WebClient
            Me.client2.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/2/NScreen_unleashed_waves001.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed_waves001.bmp")
            Me.client2.Credentials = New NetworkCredential("a6174471", "simsville1")
            Me.client3 = New WebClient
            Me.client3.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/2/NScreen_unleashed_waves002.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed_waves002.bmp")
            Me.client3.Credentials = New NetworkCredential("a6174471", "simsville1")
            Me.client4 = New WebClient
            Me.client4.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/2/NScreen_unleashed_waves003.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed_waves003.bmp")
            Me.client4.Credentials = New NetworkCredential("a6174471", "simsville1")
            bg = Image.FromFile(My.Settings.GamePath & "\UIGraphics\Community\NScreen_unleashed.bmp")
            TabPageCommunity.BackgroundImage = bg
        ElseIf ComboBox2.SelectedItem = "Snowland (40 lots)" Then
            Me.client1 = New WebClient
            Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/3/NScreen_unleashed.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed.bmp")
            Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
            Me.client2 = New WebClient
            Me.client2.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/3/NScreen_unleashed_waves001.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed_waves001.bmp")
            Me.client2.Credentials = New NetworkCredential("a6174471", "simsville1")
            Me.client3 = New WebClient
            Me.client3.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/3/NScreen_unleashed_waves002.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed_waves002.bmp")
            Me.client3.Credentials = New NetworkCredential("a6174471", "simsville1")
            Me.client4 = New WebClient
            Me.client4.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/3/NScreen_unleashed_waves003.bmp")), My.Settings.UIPATH & "\Community\" & "NScreen_unleashed_waves003.bmp")
            Me.client4.Credentials = New NetworkCredential("a6174471", "simsville1")
            bg = Image.FromFile(My.Settings.GamePath & "\UIGraphics\Community\NScreen_unleashed.bmp")
            TabPageCommunity.BackgroundImage = bg
        End If
        For i = 1 To 100

            ToolStripStatusLabel3.Text = i
            ToolStripStatusLabel4.Text = process
            BackgroundWorkerCreate.ReportProgress(i)
            System.Threading.Thread.Sleep(200)

            ToolStripProgressBar1.Value = i
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserGame.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FolderBrowserGame.SelectedPath
            My.Settings.GamePath = Me.TextBox1.Text
            My.Settings.UserData = My.Settings.GamePath & "\UserData\"
            My.Settings.UIPATH = My.Settings.GamePath & "\UIGraphics\"
            My.Settings.Save()
        End If
    End Sub



    Private Sub BackgroundWorkerCreate_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerCreate.RunWorkerCompleted
        MsgBox("Neighborhood succesfully created")
        ToolStripStatusLabel3.Text = "Completed"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileImageBg.Filter = "BMP Images (*.bmp)|*.bmp|All Files (*.*)|*.*"
        OpenFileImageBg.FilterIndex = 1
        OpenFileImageBg.FileName = "DScreen"
        If Me.OpenFileImageBg.ShowDialog = DialogResult.OK Then
            TextBox3.Text = OpenFileImageBg.FileName
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileImageBg.Filter = "BMP Images (*.bmp)|*.bmp|All Files (*.*)|*.*"
        OpenFileImageBg.FilterIndex = 1
        OpenFileImageBg.FileName = "visland"
        If Me.OpenFileImageBg.ShowDialog = DialogResult.OK Then
            TextBox4.Text = OpenFileImageBg.FileName
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileImageBg.Filter = "BMP Images (*.bmp)|*.bmp|All Files (*.*)|*.*"
        OpenFileImageBg.FilterIndex = 1
        OpenFileImageBg.FileName = "DScreen"
        If Me.OpenFileImageBg.ShowDialog = DialogResult.OK Then
            TextBox5.Text = OpenFileImageBg.FileName
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OpenFileImageBg.Filter = "BMP Images (*.bmp)|*.bmp|All Files (*.*)|*.*"
        OpenFileImageBg.FilterIndex = 1
        OpenFileImageBg.FileName = "DScreen"
        If Me.OpenFileImageBg.ShowDialog = DialogResult.OK Then
            TextBox6.Text = OpenFileImageBg.FileName
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        OpenFileImageBg.Filter = "BMP Images (*.bmp)|*.bmp|All Files (*.*)|*.*"
        OpenFileImageBg.FilterIndex = 1
        OpenFileImageBg.FileName = "NScreen"
        If Me.OpenFileImageBg.ShowDialog = DialogResult.OK Then
            TextBox8.Text = OpenFileImageBg.FileName
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        If ComboBox3.Text = "Community" Then

            bg = Image.FromFile(OpenFileImageBg.FileName)

            TabPageCommunity.BackgroundImage = bg
            Me.client1 = New WebClient
            Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/Def/NScreen_unleashed.bmp")), (My.Settings.UIPATH & "Community\") & "NScreen_unleashed.bmp")
            Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")

        ElseIf ComboBox3.Text = "Downtown" Then
            bg = Image.FromFile(OpenFileImageBg.FileName)

            TabPageDowntown.BackgroundImage = bg
            Me.client1 = New WebClient
            Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/Def/DScreen.bmp")), (My.Settings.UIPATH & "Downtown\") & "DScreen.bmp")
            Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
        ElseIf ComboBox3.Text = "Vacation" Then
            bg = Image.FromFile(OpenFileImageBg.FileName)

            TabPageVacation.BackgroundImage = bg
            Me.client1 = New WebClient
            Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/Def/visland.bmp")), (My.Settings.UIPATH & "VIsland\") & "visland.bmp")
            Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
        ElseIf ComboBox3.Text = "Studiotown" Then
            bg = Image.FromFile(OpenFileImageBg.FileName)

            TabPageStudio.BackgroundImage = bg
            Me.client1 = New WebClient
            Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/Def/Studio/DScreen.bmp")), (My.Settings.UIPATH & "Studiotown\") & "DScreen.bmp")
            Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
        ElseIf ComboBox3.Text = "Magictown" Then
            bg = Image.FromFile(OpenFileImageBg.FileName)

            TabPageMagic.BackgroundImage = bg
            Me.client1 = New WebClient
            Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/Def/Magic/DScreen.bmp")), (My.Settings.UIPATH & "Magicland\") & "DScreen.bmp")
            Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
        ElseIf ComboBox3.Text = "Simple" Then
            bg = Image.FromFile(OpenFileImageBg.FileName)

            TabPageSimple.BackgroundImage = bg
            Me.client1 = New WebClient
            Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/Def/NScreen.BMP")), (My.Settings.UIPATH & "Nbhd\") & "NScreen.bmp")
            Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
        Else
            MsgBox("Please select background image to import")

        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        process = "Downloading neighborhood"
        Dim locs As String = My.Settings.GamePath & "\UserData9.zip"
        Dim backgr As BackgroundWorker
        Dim backgr2 As BackgroundWorker
        backgr = BackgroundWorkerDownload
        backgr2 = BackgroundWorkerCreate
        If backgr.IsBusy Or backgr2.IsBusy Then
            MsgBox("Current operation in progress")
        Else

            If ComboBox4.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Select negihborhood and his name to download")
            Else
                Try
                    BackgroundWorkerDownload.RunWorkerAsync()
                    
                Catch ex As Exception
                    MsgBox("Cannot download the neighborhood")
                End Try



            End If


        End If


    End Sub

    Private Sub BackgroundWorkerDownload_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerDownload.DoWork
        Dim locs As String = My.Settings.GamePath & "\UserData9.zip"
        If ComboBox4.SelectedItem <> "" And ComboBox1.SelectedItem <> "" Then
            If ComboBox4.SelectedItem = "Downtown (20 lots)" Then
                Me.client6 = New WebClient
                client6.DownloadFileAsync(New Uri("http://download1485.mediafire.com/dm1vp4za60eg/rtt91i9nch5rrip/DowntownNhood.zip"), (locs))
                client6.Dispose()


            ElseIf ComboBox4.SelectedItem = "VacationIsle (20 lots)" Then
                Me.client6 = New WebClient
                client6.DownloadFileAsync(New Uri("http://download1652.mediafire.com/m8tg63cry6ig/lu54vtcz64lh0th/VIslandNhood.zip"), (locs))
                client6.Dispose()


            ElseIf ComboBox4.SelectedItem = "Original (40 lots)" Then
                Me.client6 = New WebClient
                client6.DownloadFileAsync(New Uri("http://download1585.mediafire.com/amw8ij2etohg/gp9crsjyk8dq7kd/OriginalNhood.zip"), (locs))
                client6.Dispose()

            End If
            For i = 1 To 100

                ToolStripStatusLabel3.Text = i
                ToolStripStatusLabel4.Text = process
                BackgroundWorkerDownload.ReportProgress(i)
                System.Threading.Thread.Sleep(200)
                ToolStripProgressBar1.Value = i
            Next
        End If
        

    End Sub

    Private Sub BackgroundWorkerDownload_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerDownload.RunWorkerCompleted
        MsgBox("Neighborhood succesfully downloaded")
        ToolStripStatusLabel3.Text = "Completed"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Not Label12.Visible Then

            int += 1
            label = Label12
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        ElseIf Not Label13.Visible Then


            int += 1
            label = Label13
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        ElseIf Not Label18.Visible Then


            int += 1
            label = Label18
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        ElseIf Not Label19.Visible Then


            int += 1
            label = Label19
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        ElseIf Not Label20.Visible Then


            int += 1
            label = Label20
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        ElseIf Not Label21.Visible Then


            int += 1
            label = Label21
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        ElseIf Not Label22.Visible Then


            int += 1
            label = Label22
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        ElseIf Not Label23.Visible Then


            int += 1
            label = Label23
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        ElseIf Not Label24.Visible Then


            int += 1
            label = Label24
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        ElseIf Not Label25.Visible Then


            int += 1
            label = Label25
            label.Location = locs
            label.Name = int
            label.Enabled = True
            label.Visible = True
            label.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        End If

    End Sub
    Private Sub IFFReaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IFFReaderToolStripMenuItem.Click
        Reader.Show()

    End Sub



    Private Sub Label12_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.LocationChanged
        Label12.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label12.Refresh()
    End Sub
    Private Sub Label13_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.LocationChanged
        Label13.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label13.Refresh()
    End Sub
    Private Sub Label18_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label18.LocationChanged
        Label18.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label18.Refresh()
    End Sub
    Private Sub Label19_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label19.LocationChanged
        Label19.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label19.Refresh()
    End Sub
    Private Sub Label20_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label20.LocationChanged
        Label20.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label20.Refresh()
    End Sub
    Private Sub Label21_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label21.LocationChanged
        Label21.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label21.Refresh()
    End Sub
    Private Sub Label22_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label22.LocationChanged
        Label22.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label22.Refresh()
    End Sub
    Private Sub Label23_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label23.LocationChanged
        Label23.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label23.Refresh()
    End Sub
    Private Sub Label24_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label24.LocationChanged
        Label24.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label24.Refresh()
    End Sub
    Private Sub Label25_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label25.LocationChanged
        Label25.Text = "House" & int & vbNewLine & MousePosition.X & "," & MousePosition.Y
        Label25.Refresh()
    End Sub



    Private Sub TabPageCommunity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPageCommunity.Click

    End Sub

    Private Sub TabPageCommunity_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabPageCommunity.MouseClick
        Dim location As New System.Drawing.Point(x:=e.X, y:=e.Y)
        label.Location = location

    End Sub

    Private Sub TabPageCommunity_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabPageCommunity.MouseMove
        ToolStripLabel2.Text = "X." & e.X
        ToolStripLabel3.Text = "Y." & e.Y
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        If Label25.Visible Then
            label = Label25
        ElseIf Label24.Visible Then
            label = Label24
        ElseIf Label23.Visible Then
            label = Label23
        ElseIf Label22.Visible Then
            label = Label22
        ElseIf Label21.Visible Then
            label = Label21
        ElseIf Label20.Visible Then
            label = Label20
        ElseIf Label19.Visible Then
            label = Label19
        ElseIf Label18.Visible Then
            label = Label18
        ElseIf Label13.Visible Then
            label = Label13
        ElseIf Label12.Visible Then
            label = Label12
        End If

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If Label25.Visible Then
            label = Label25
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1
        ElseIf Label24.Visible Then
            label = Label24
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1

        ElseIf Label23.Visible Then
            label = Label23
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1
        ElseIf Label22.Visible Then
            label = Label22
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1
        ElseIf Label21.Visible Then
            label = Label21
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1
        ElseIf Label20.Visible Then
            label = Label20
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1
        ElseIf Label19.Visible Then
            label = Label19
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1
        ElseIf Label18.Visible Then
            label = Label18
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1
        ElseIf Label13.Visible Then
            label = Label13
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1

        ElseIf Label12.Visible Then
            label = Label12
            label.Visible = False
            label.Location = locs
            label.Name = int
            int = int - 1

        Else
            MsgBox("No more houses can be deleted")
        End If
    End Sub


    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        MsgBox("You cannot upload neighborhoods right now")
    End Sub

    Private Sub StartGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartGameToolStripMenuItem.Click
        System.Diagnostics.Process.Start(My.Settings.GamePath & "\" & "Sims.exe", arguments:="-w")
    End Sub

    Private Sub WebpageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebpageToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://simsvilleroleplay.webnode.es/nhood-editor/")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If File.Exists(My.Settings.GamePath & "\UserData9.zip") Then


            Dim zip As New ZipForge
            zip.FileName = My.Settings.GamePath & "\UserData9.zip"
            zip.OpenArchive(System.IO.FileMode.Open)
            zip.BaseDir = My.Settings.GamePath
            zip.ExtractFiles("*.*")
            zip.CloseArchive()
            NumericUpDown1.Value = 9
            If Me.TextBox1.Text <> "" Then
                Dim directory As New IO.DirectoryInfo(My.Settings.GamePath & "\UserData9\Houses\")
                Dim getfiles As IO.FileInfo()
                getfiles = directory.GetFiles()
                Dim fileinfos As IO.FileInfo
                For Each fileinfos In getfiles
                    Me.ListBox1.Items.Add(fileinfos)

                Next fileinfos
            End If
            Dim info As String = (My.Settings.GamePath & "\" & ComboBox1.Text & "\" & "info.txt")
            Dim infor As FileInfo
            infor = My.Computer.FileSystem.GetFileInfo(My.Settings.GamePath & "\" & ComboBox1.Text & "\" & "info.txt")
            Label17.Text = infor.LastWriteTime
            RichTextBox1.Text = ComboBox4.Text & ComboBox2.Text & vbNewLine & infor.LastAccessTime & "Downloaded neighborhood"
            Dim writer As New StreamWriter(My.Settings.GamePath & "\" & ComboBox1.Text & "\" & "info.txt", False)
            writer.WriteLine(RichTextBox1.Text)
            writer.Close()
            MsgBox("files succesfully extracted")
        Else
            MsgBox("No file has been downloaded")
        End If
    End Sub

    Private Sub FARReaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FARReaderToolStripMenuItem.Click
        FAREditor.Show()
    End Sub
End Class
