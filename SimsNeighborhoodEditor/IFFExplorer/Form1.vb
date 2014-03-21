Imports SimsLib.IFF
Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports SimsLib
Imports SimsLib.FAR1


Public Class Form1
    Private list As List(Of IffChunk) = New List(Of IffChunk)
    Private bmps As List(Of Images) = New List(Of Images)
    Private strs As New StringTableString
    Private strx As List(Of StringTableString)
    Private BitmapData As Bitmap
    Private far1 As FARArchive
    Private builder As New StringBuilder
    Private read As BinaryWriter
    Private data As String
    Dim bytes As Byte()
    Dim iff As Iff
    Private m_CurrentBHAV As BHAV
    Private m_Analyzer As Analyzer
    Private m_DecodedInstructions As New List(Of IFFDecode)
    Private ifflist As New List(Of Iff)
    Private dirs As New List(Of IO.DirectoryInfo)
    Private directories As IO.DirectoryInfo

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Settings.GamePath = Nothing Then
                Dim Response As Integer

                ' Displays a message box with the yes and no options.
                Response = MsgBox(Prompt:="Please select The Sims Game Folder?", Buttons:=vbYesNo)

                ' If statement to check if the yes button was selected.
                If Response = vbYes Then
                    FolderBrowserGame.ShowDialog()
                    My.Settings.GamePath = FolderBrowserGame.SelectedPath
                    My.Settings.UserData = My.Settings.GamePath & "\UserData"
                    My.Settings.Downloads = My.Settings.GamePath & "\Downloads\"
                    My.Settings.GameData = My.Settings.GamePath & "\GameData\"
                    My.Settings.Save()



                Else
                    ' The no button was selected.
                    MsgBox("Now you cannot preview files")
                End If

            End If
        Catch ex As Exception
            MsgBox("Cannot select the Game Path")
        End Try



        Control.CheckForIllegalCrossThreadCalls = False
        Dim readValue = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims", "Version", Nothing)
        Dim languangevalue = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims", "SIMS_LANGUAGE", Nothing)

        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Maxis\The Sims",
"Version", Nothing) > 0 Then
            Settings.TextBox7.Text = readValue & languangevalue
        Else
            MsgBox("Cannot found registry version in" & readValue)
        End If

        ListBox8.Items.Clear()
        directories = New IO.DirectoryInfo(My.Settings.GamePath)
        Dim Directory As IO.DirectoryInfo
        Dim File As IO.FileInfo

        For Each Directory In directories.GetDirectories
            For Each File In Directory.GetFiles
                If File.Extension = ".far" Then
                    ListBox8.Items.Add(File.Name)

                End If

            Next

        Next


    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.ListBox1.Items.Clear()
        Me.ListBox2.Items.Clear()
        ImageList1.Images.Clear()
        RichTextBox1.Text = Nothing
        builder.Clear()
        OpenFileDialog1.Filter = "IIF Files (*.iff)|*.iff|All Files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            bytes = My.Computer.FileSystem.ReadAllBytes(OpenFileDialog1.FileName)
            iff = New Iff(bytes)

            TextBox1.Text = OpenFileDialog1.FileName

            For Each chunk In iff.Chunks
                If (chunk.Resource = "BMP_") Then
                    Dim stream As New MemoryStream(chunk.Data)
                    bmps.Add(New Images(chunk))
                    BitmapData = New Bitmap(stream)

                    ImageList1.Images.Add(BitmapData)
                End If
            Next


            For Each table In iff.StringTables

                ListBox1.Items.Add(table.ID)
                ListBox2.Items.Add(table.Resource)
                ListBox3.Items.Add(table.NameString)

            Next
            For Each ctss In iff.StringTables
                If ctss.Resource = "CTSS" Then
                    TextBox2.Text = ctss.Strings.Item(0).Str.ToString
                    RichTextBox1.Text = ctss.Strings.Item(1).Str.ToString
                End If
            Next

            PictureBox1.Image = ImageList1.Images.Item(0)
            PictureBox2.Image = ImageList1.Images.Item(1)


        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "IIF Files (*.iff)|*.iff|All Files (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 1
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then

            data = SaveFileDialog1.FileName

            iff = New Iff(bytes)

            For Each chunk In iff.Chunks

                Dim stream As MemoryStream = New MemoryStream(bytes)
                read = New BinaryWriter(stream)
                My.Computer.FileSystem.WriteAllBytes(data, bytes, False)
                read.Write(bytes, 0, bytes.Length)
                read.Close()
                read.Dispose()

            Next



        End If
    End Sub

    Private Sub TabPageObjects_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageObjects.Enter
        Try

        
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        directories = New IO.DirectoryInfo(My.Settings.GamePath & "\Downloads\")
        Dim Directory As IO.DirectoryInfo
        Dim File As IO.FileInfo

        For Each Directory In directories.GetDirectories
            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox4.Items.Add(File.Name)
                    ListBox5.Items.Add(File.FullName)
                End If

            Next

            Next
        Catch ex As Exception
            MsgBox("Cannot load objects folder, please setup settings")
        End Try
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox4.SelectedIndexChanged

    End Sub

    Private Sub ListBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox5.SelectedIndexChanged
        Dim path As String = My.Settings.GamePath & "\Downloads\"
        Dim current As String = ListBox5.SelectedItem.ToString
        bytes = My.Computer.FileSystem.ReadAllBytes(current)
        iff = New Iff(bytes)
        For Each chunk In iff.Chunks
            If (chunk.Resource = "BMP_") Then

                Dim stream As New MemoryStream(chunk.Data)

                BitmapData = New Bitmap(stream)

                ImageListObjects.Images.Add(BitmapData)
            End If
        Next
        PictureBox3.Image = BitmapData


        For Each ctss In iff.StringTables
            If ctss.Resource = "CTSS" Then
                TextBox3.Text = ctss.Strings.Item(0).Str.ToString
                RichTextBox2.Text = ctss.Strings.Item(1).Str.ToString
            End If
        Next
    End Sub

    Private Sub TabPageCompressed_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageCompressed.Enter
        Try

        
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        directories = New IO.DirectoryInfo(My.Settings.GamePath & "\Downloads")
        Dim Directory As IO.DirectoryInfo
        Dim File As IO.FileInfo

        For Each Directory In directories.GetDirectories
            For Each File In Directory.GetFiles
                If File.Extension = ".far" Then
                    ListBox6.Items.Add(File.Name)
                    ListBox7.Items.Add(File.FullName)
                End If

            Next

            Next
        Catch ex As Exception
            MsgBox("Cannot load far compressed files, please setup settings")
        End Try
    End Sub


    Private Sub ListBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox6.SelectedIndexChanged



    End Sub

    Private Sub ListBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox7.SelectedIndexChanged
        Dim path As String = My.Settings.GamePath & "\Downloads"
        Dim current As String = ListBox7.SelectedItem.ToString
        bytes = My.Computer.FileSystem.ReadAllBytes(current)
        far1 = New FARArchive(current)



    End Sub


    Private Sub TabPageHouses_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageHouses.Enter
        Try

        
        ListBox9.Items.Clear()
        ListBox10.Items.Clear()

        Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.Houses)
        Dim File As IO.FileInfo


        For Each File In Directory.GetFiles
            If File.Extension = ".iff" Then
                ListBox9.Items.Add(File.Name)
                ListBox10.Items.Add(File.FullName)
            End If

        Next
        Catch ex As Exception
            MsgBox("Cannot load houses files, please setup settings")
        End Try

    End Sub

    Private Sub ListBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox10.SelectedIndexChanged
        ListBox11.Items.Clear()
        ListBox12.Items.Clear()
        Dim path As String = My.Settings.Houses
        Dim current As String = ListBox10.SelectedItem.ToString
        bytes = My.Computer.FileSystem.ReadAllBytes(current)
        iff = New Iff(bytes)
        For Each chunk In iff.Chunks
            If (chunk.Resource = "BMP_") Then

                Dim stream As New MemoryStream(chunk.Data)

                BitmapData = New Bitmap(stream)

                ImageListObjects.Images.Add(BitmapData)
            End If
        Next
        PictureBox5.Image = BitmapData


        For Each stx In iff.StringTables

            ListBox11.Items.Add(stx.Strings.Item(0).Str)
            ListBox12.Items.Add(stx.Strings.Item(1).Str)

        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "1" Then
            ListBox9.Items.Clear()
            ListBox10.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData\Houses\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox9.Items.Add(File.Name)
                    ListBox10.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox1.SelectedItem = "2" Then
            ListBox9.Items.Clear()
            ListBox10.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData2\Houses\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox9.Items.Add(File.Name)
                    ListBox10.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox1.SelectedItem = "3" Then
            ListBox9.Items.Clear()
            ListBox10.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData3\Houses\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox9.Items.Add(File.Name)
                    ListBox10.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox1.SelectedItem = "4" Then
            ListBox9.Items.Clear()
            ListBox10.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData4\Houses\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox9.Items.Add(File.Name)
                    ListBox10.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox1.SelectedItem = "5" Then
            ListBox9.Items.Clear()
            ListBox10.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData5\Houses\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox9.Items.Add(File.Name)
                    ListBox10.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox1.SelectedItem = "6" Then
            ListBox9.Items.Clear()
            ListBox10.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData6\Houses\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox9.Items.Add(File.Name)
                    ListBox10.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox1.SelectedItem = "7" Then
            ListBox9.Items.Clear()
            ListBox10.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData7\Houses\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox9.Items.Add(File.Name)
                    ListBox10.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox1.SelectedItem = "8" Then
            ListBox9.Items.Clear()
            ListBox10.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData8\Houses\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox9.Items.Add(File.Name)
                    ListBox10.Items.Add(File.FullName)
                End If

            Next
        End If
    End Sub


    Private Sub TabPageCharacters_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageCharacters.Enter
        Try

        
        ListBox13.Items.Clear()
        ListBox14.Items.Clear()

        Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.Characters)
        Dim File As IO.FileInfo


        For Each File In Directory.GetFiles
            If File.Extension = ".iff" Then
                ListBox13.Items.Add(File.Name)
                ListBox14.Items.Add(File.FullName)
            End If

            Next
        Catch ex As Exception
            MsgBox("Cannot load characters, please setup settings")
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "1" Then
            ListBox13.Items.Clear()
            ListBox14.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData\Characters\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox13.Items.Add(File.Name)
                    ListBox14.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox2.SelectedItem = "2" Then
            ListBox13.Items.Clear()
            ListBox14.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData2\Characters\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox13.Items.Add(File.Name)
                    ListBox14.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox2.SelectedItem = "3" Then
            ListBox13.Items.Clear()
            ListBox14.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData3\Characters\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox13.Items.Add(File.Name)
                    ListBox14.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox2.SelectedItem = "4" Then
            ListBox13.Items.Clear()
            ListBox14.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData4\Characters\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox13.Items.Add(File.Name)
                    ListBox14.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox2.SelectedItem = "5" Then
            ListBox13.Items.Clear()
            ListBox14.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData5\Characters\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox13.Items.Add(File.Name)
                    ListBox14.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox2.SelectedItem = "6" Then
            ListBox13.Items.Clear()
            ListBox14.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData6\Characters\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox13.Items.Add(File.Name)
                    ListBox14.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox2.SelectedItem = "7" Then
            ListBox13.Items.Clear()
            ListBox14.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData7\Characters\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox13.Items.Add(File.Name)
                    ListBox14.Items.Add(File.FullName)
                End If

            Next
        ElseIf ComboBox2.SelectedItem = "8" Then
            ListBox13.Items.Clear()
            ListBox14.Items.Clear()

            Dim Directory As IO.DirectoryInfo = New DirectoryInfo(My.Settings.GamePath & "\UserData8\Characters\")
            Dim File As IO.FileInfo


            For Each File In Directory.GetFiles
                If File.Extension = ".iff" Then
                    ListBox13.Items.Add(File.Name)
                    ListBox14.Items.Add(File.FullName)
                End If

            Next
        End If
    End Sub

    Private Sub ListBox14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox14.SelectedIndexChanged

        Dim path As String = My.Settings.Characters
        Dim current As String = ListBox14.SelectedItem.ToString
        bytes = My.Computer.FileSystem.ReadAllBytes(current)
        iff = New Iff(bytes)
        For Each chunk In iff.Chunks
            If (chunk.Resource = "BMP_") Then

                Dim stream As New MemoryStream(chunk.Data)

                BitmapData = New Bitmap(stream)

                ImageListObjects.Images.Add(BitmapData)
            End If
        Next
        PictureBox6.Image = BitmapData

        For Each ctss In iff.StringTables
            If ctss.Resource = "CTSS" Then
                TextBox4.Text = ctss.Strings.Item(0).Str.ToString
            End If
            If ctss.ID = 200 Then
                TextBox5.Text = ctss.Strings.Item(12).Str.ToString
                TextBox6.Text = ctss.Strings.Item(0).Str.ToString
                TextBox7.Text = ctss.Strings.Item(14).Str.ToString
            End If
            If ctss.ID = 304 Then
                TextBox8.Text = ctss.Strings.Item(0).Str.ToString
            End If
        Next

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("IFF Explorer created for The Sims, by fracot514 2014.")
    End Sub
End Class
