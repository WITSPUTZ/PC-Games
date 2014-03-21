Imports System
Imports Worms_Armageddon_Mission_Editor.Mission
Imports System.IO
Imports System.Reflection
Imports WormsNET.Image

Public Class Form1

    Private mission As New Mission
    Private image As Image
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If My.Settings.GamePath = Nothing Then
                Dim Response As Integer

                ' Displays a message box with the yes and no options.
                Response = MsgBox(Prompt:="Please select the Worms Armageddon Game Folder", Buttons:=vbYesNo)

                ' If statement to check if the yes button was selected.
                If Response = vbYes Then
                    FolderBrowserGame.Description = "Worms Armageddon Game Folder"
                    FolderBrowserGame.ShowDialog()
                    TextBox1.Text = FolderBrowserGame.SelectedPath


                    My.Settings.GamePath = Me.TextBox1.Text
                    My.Settings.Save()

                Else
                    ' The no button was selected.
                    MsgBox("Now you cannot edit mission files")
                End If
            Else

            End If

            TextBox1.Text = My.Settings.GamePath
        Catch ex As Exception
            MsgBox("Cannot select the Game Path")
        End Try
        Try
            ListBox1.Items.Clear()
            Dim directoryinfo As IO.DirectoryInfo = New IO.DirectoryInfo(My.Settings.GamePath & "\DATA\Mission\")
            Dim File As IO.FileInfo


            For Each File In directoryinfo.GetFiles
                If File.Extension = ".wam" Then

                    ListBox1.Items.Add(File.Name)
                End If

            Next


        Catch ex As Exception
            MsgBox("Cannot load files folder, please setup settings")
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.RichTextBox1.Clear()
        Me.ListView1.Items.Clear()
        Try

            mission.LoadMission()

            MsgBox("Mission loaded")
        Catch ex As Exception
            Me.RichTextBox2.AppendText("Missing Some Fields" & vbNewLine)
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub


    Private Sub TabPageTerrain_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageTerrain.Enter
        Dim strAppDir As String = Path.GetDirectoryName( _
    Assembly.GetExecutingAssembly().GetName().CodeBase)
        Try
            ComboBox1.Items.Clear()
            Dim directoryinfo As IO.DirectoryInfo = New IO.DirectoryInfo(My.Settings.GamePath & "\DATA\Image\")
            Dim File As IO.FileInfo


            For Each File In directoryinfo.GetFiles
                If File.Extension = ".IMG" Then

                    ComboBox1.Items.Add(File.Name)
                End If

            Next


        Catch ex As Exception
            MsgBox("Cannot load images folder, please setup settings")
        End Try
        If Description.TerrainImg = "" Then
            ComboBox1.Text = ""
            
        Else
            Dim current As String = My.Settings.GamePath & "\DATA\Image\" & ComboBox1.Text
            image = New Image(current)
            PictureBox6.BackgroundImage = image.Bitmap
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        
        Dim current As String = My.Settings.GamePath & "\DATA\Image\" & ComboBox1.SelectedItem
        image = New Image(current)
        PictureBox6.BackgroundImage = image.Bitmap

        If ComboBox1.SelectedItem = "PUMPKINS.IMG" Then
            Me.TextBox50.Text = "22"
        ElseIf ComboBox1.SelectedItem = "FLOWERS.IMG" Then

            Me.TextBox50.Text = "3"
        ElseIf ComboBox1.SelectedItem = "Books.img" Then

            Me.TextBox50.Text = "2"
        ElseIf ComboBox1.SelectedItem = "Polar.img" Then

            Me.TextBox50.Text = "30"
        ElseIf ComboBox1.SelectedItem = "Train.img" Then

            Me.TextBox50.Text = "31"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Terrain.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub



    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Terrain.Show()
        Variables.Item = 1
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Terrain.Show()
        Variables.Item = 2
    End Sub


    Private Sub NumericUpDown6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown6.ValueChanged
        If NumericUpDown6.Value = 0 Then
            ComboBox10.Text = "End Round"
        ElseIf NumericUpDown6.Value = 1 Then
            ComboBox10.Text = "Nuke"
        ElseIf NumericUpDown6.Value = 2 Then
            ComboBox10.Text = "Nuke water rise"
        ElseIf NumericUpDown6.Value = 3 Then
            ComboBox10.Text = "Worm damage water rise"
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        OpenFileDialog1.InitialDirectory = My.Settings.GamePath
        OpenFileDialog1.Filter = "Wors Armageddon Mission File (*.wam)|*.wam|All Files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then

        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        SaveFileDialog1.InitialDirectory = My.Settings.GamePath
        SaveFileDialog1.Filter = "Wors Armageddon Mission File (*.wam)|*.wam|All Files (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 1
        If (Me.SaveFileDialog1.ShowDialog = DialogResult.OK) Then

        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.RichTextBox1.Clear()
        Try
            mission.SaveMission()
            MsgBox("Mission saved ")
        Catch ex As Exception
            MsgBox("Cannot save the mission")
        End Try
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Weapons.Show()
    End Sub
End Class
