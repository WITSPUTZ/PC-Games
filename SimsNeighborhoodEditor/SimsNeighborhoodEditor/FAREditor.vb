Imports SimsLib.FAR3
Imports SimsLib.FAR1
Imports SimsLib.IFF
Imports System.Drawing.Imaging
Imports System.IO

Public Class FAREditor
    Private far As FAR3Archive
    Private far1 As FARArchive
    Private farex As FAR3Exception
    Private decompress As Decompresser
    Private bytes As Byte()
    Private iff As Iff
    Private BitmapData As Bitmap


    Private Sub FAREditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "FAR File (*.FAR)|*.FAR|All Files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            far1 = New FARArchive(OpenFileDialog1.FileName)
            far1.GetAllEntries()
            Dim ns As New FarEntry()
            For Each entry In far1.GetEntry(ns)
                If ns.Filename.Contains(".iff") Then
                    ListBox1.Items.Add(ns.Filename)
                End If

            Next

        End If



    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim current As String = ListBox1.SelectedItem.ToString
        For Each entry In far1.GetAllEntries
            If entry.Key = ListBox1.SelectedItem Then


                iff = New Iff(entry.Value)
                My.Computer.FileSystem.WriteAllBytes("C:\Archivos de programas\TSO\" & current, entry.Value, False)
            End If
        Next




    End Sub
End Class