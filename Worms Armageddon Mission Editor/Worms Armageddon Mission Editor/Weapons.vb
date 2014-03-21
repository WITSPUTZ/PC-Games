Imports System.IO
Imports System.Reflection
Imports WormsNET.Image

Public Class Weapons
    Private image As WormsNET.Image.Image
    Private directoryinfo As IO.DirectoryInfo
    Private directory As String

    Private Sub Weapons_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strAppDir As String = Path.GetDirectoryName( _
    Assembly.GetExecutingAssembly().GetName().CodeBase)
        directory = My.Settings.GamePath & "\DATA\Weapons\"
        Try
            ComboBox1.Items.Clear()
            directoryinfo = New IO.DirectoryInfo(directory)

            Dim File As IO.FileInfo


            For Each File In directoryinfo.GetFiles
                    ComboBox1.Items.Add(File.Name)


            Next


        Catch ex As Exception
            MsgBox("Cannot load images folder, please setup settings")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim current As String = My.Settings.GamePath & "\DATA\Weapons\" & ComboBox1.SelectedItem
        Image = New Image(current)
        PictureBox1.BackgroundImage = image.Bitmap
    End Sub
End Class