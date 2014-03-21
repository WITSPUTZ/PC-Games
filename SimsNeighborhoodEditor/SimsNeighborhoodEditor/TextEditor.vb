Imports System.Text
Imports System.IO
Imports SimsLib.IFF

Public Class TextEditor
    Dim m_Chunks = New List(Of IffChunk)


    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'check if textbox can undo

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Clipboard.Clear()
        If RichTextBox1.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(RichTextBox1.SelectedText)
        End If
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Clipboard.Clear()
        If RichTextBox1.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(RichTextBox1.SelectedText)
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If My.Computer.Clipboard.ContainsText Then
            RichTextBox1.Paste()
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As String
        Dim b As String
        a = InputBox("Enter text to be found")
        b = InStr(RichTextBox1.Text, a)
        If b Then
            RichTextBox1.Focus()
            RichTextBox1.SelectionStart = b - 1
            RichTextBox1.SelectionLength = Len(a)
        Else
            MsgBox("Text not found.")
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color
    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("IFF Strings Editor v1.0 by Francot514")
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'Check if there's text added to the textbox
        If RichTextBox1.Modified Then
            'If the text of notepad changed, the program will ask the user if they want to save the changes
            Dim ask As MsgBoxResult
            ask = MsgBox("Do you want to save the changes", MsgBoxStyle.YesNoCancel, "New Document")
            If ask = MsgBoxResult.No Then
                RichTextBox1.Clear()
            ElseIf ask = MsgBoxResult.Cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                RichTextBox1.Clear()
            End If
            'If textbox's text is still the same, notepad will open a new page:
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'Check if there's text added to the textbox
        If RichTextBox1.Modified Then
            'If the text of notepad changed, the program will ask the user if they want to save the changes
            Dim ask As MsgBoxResult
            ask = MsgBox("Do you want to save the changes", MsgBoxStyle.YesNoCancel, "Open Document")
            If ask = MsgBoxResult.No Then
                OpenFileDialog1.ShowDialog()
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            ElseIf ask = MsgBoxResult.Cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                RichTextBox1.Clear()
            End If
        Else
            'If textbox's text is still the same, notepad will show the OpenFileDialog
            OpenFileDialog1.Filter = "IIF String File (*.iff)|*.iff|All Files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.ShowDialog()

            Dim bitm As Bitmap
            Dim chunk As IffChunk
            m_Chunks = File.ReadAllBytes(OpenFileDialog1.FileName)
            For Each chunk In m_Chunks
                chunk.NameString = OpenFileDialog1.FileName
                chunk.Data = m_Chunks
                Dim stream As New MemoryStream(OpenFileDialog1.FileName)
                bitm = New Bitmap(stream)
                PictureBox1.Image = bitm
            Next
            Dim reader As StreamReader
            reader = IO.File.OpenText((OpenFileDialog1.FileName))
            Dim mystring() As String = reader.ReadToEnd.Split(ChrW(vbBinaryCompare))
            reader.Close()
            TextBox3.Text = OpenFileDialog1.FileName
            Dim withoutNulls As String = System.IO.File.ReadAllText(OpenFileDialog1.FileName).Replace(Microsoft.VisualBasic.ChrW(0), vbBinaryCompare)
            RichTextBox1.Text = withoutNulls
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "IIF String File (*.iff)|*.iff|All Files (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 1

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)

        Else
            MsgBox("File has not been saved")
        End If


    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub UndoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        If RichTextBox1.CanUndo Then
            RichTextBox1.Undo()
        Else
        End If
    End Sub

    Private Sub TextEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.TextLength > 0 Then
            Dim NewString As String = RichTextBox1.Text
            Dim CurrPos As Integer = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(CurrPos)
            ListBox1.Items.Insert(CurrPos, NewString)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RichTextBox1.SelectedText.Length < 100 Then
            ListBox1.Items.Add(RichTextBox1.SelectedText)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox2.Text = ListBox1.SelectedItem
    End Sub
End Class
