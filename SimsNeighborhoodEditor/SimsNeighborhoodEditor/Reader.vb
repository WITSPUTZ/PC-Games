Imports SimsLib.IFF
Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports SimsLib



Public Class Reader







    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

    End Sub
    Private Function StringBuilderCommand(ByVal Field, ByVal Table, ByVal CurrentCellValue, ByVal SearchParameter) 'Creates a suitable SQL string.
        Dim SqlCommand As New SqlCommand()
        Dim MyStringBuilder As New StringBuilder("")
        MyStringBuilder.Append("SELECT @Field FROM @Table WHERE @SearchParameter = @CurrentCellValue")
        With SqlCommand



            SqlCommand.CommandText = MyStringBuilder.ToString()
            .Parameters.AddWithValue("@Field", Field)
            .Parameters.AddWithValue("@Table", Table)
            .Parameters.AddWithValue("@SearchParameter", SearchParameter)
            .Parameters.AddWithValue("@CurrentCellValue", CurrentCellValue)
        End With
        Return SqlCommand
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub LoadFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadFilesToolStripMenuItem.Click


    End Sub
    Private Sub ListFiles(ByVal strPath As String, Optional ByVal Extention As String = "iff")
        'Leave Extention blank for all files
        Dim File As String

        If RTrim(strPath) <> "\" Then strPath = strPath & "\"

        If Trim$(Extention) = "" Then
            Extention = "*.*"
        ElseIf LTrim(Extention) <> "*." Then
            Extention = "*." & Extention
        End If

        File = Dir$(strPath & Extention)
        Do While Len(File)
            ListBox5.Items.Add(File)
            File = Dir$()
        Loop
    End Sub


    Private Sub LoadFilesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadFilesToolStripMenuItem1.Click

    End Sub

    Private Sub ListBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox5.SelectedIndexChanged



    End Sub

    Private Sub HousesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HousesToolStripMenuItem.Click
        ListBox5.Items.Clear()

        Dim directory As New IO.DirectoryInfo(My.Settings.GamePath & "\UserData\Houses\")
        Dim getfiles As IO.FileInfo()
        getfiles = directory.GetFiles()
        Dim fileinfos As IO.FileInfo
        For Each fileinfos In getfiles
            Me.ListBox5.Items.Add(fileinfos)

        Next fileinfos

       
    End Sub

    Private Sub CharactersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CharactersToolStripMenuItem.Click
        ListBox5.Items.Clear()

        Dim directory As New IO.DirectoryInfo(My.Settings.GamePath & "\UserData\Characters\")
        Dim getfiles As IO.FileInfo()
        getfiles = directory.GetFiles()
        Dim fileinfos As IO.FileInfo
        For Each fileinfos In getfiles
            Me.ListBox5.Items.Add(fileinfos)

        Next fileinfos
        

    End Sub

    Private Sub ObjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObjectsToolStripMenuItem.Click

    End Sub
End Class
