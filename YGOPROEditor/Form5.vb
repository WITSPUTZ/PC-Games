Imports System.IO
Imports SyntaxHighlighter
Imports System.Windows.Forms.ListViewItem
Imports System.Reflection


Public Class Form5
    Private undoList As Stack(Of String) = New Stack(Of String)
    Private writer As StreamWriter

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.SyntaxRichTextBox1.Settings.Keywords.Add("function")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("if")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("then")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("return")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("local")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("not")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("and")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("else")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("elseif")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("end")
        Me.SyntaxRichTextBox1.Settings.Keywords.Add("require")
        Me.SyntaxRichTextBox1.Settings.Comment = "--"
        Me.SyntaxRichTextBox1.Settings.KeywordColor = Color.Blue
        Me.SyntaxRichTextBox1.Settings.CommentColor = Color.Green
        Me.SyntaxRichTextBox1.Settings.StringColor = Color.Gray
        Me.SyntaxRichTextBox1.Settings.IntegerColor = Color.Red
        Me.SyntaxRichTextBox1.SelectionBackColor = Color.Black
        Me.SyntaxRichTextBox1.SelectionColor = Color.Orange
        Me.SyntaxRichTextBox1.CompileKeywords()
        Dim read As StreamReader = New StreamReader(System.AppDomain.CurrentDomain.BaseDirectory & "\Misc\summon.lua")
        Dim mystring() As String = read.ReadToEnd.Split(vbNewLine)
        ListBox3.Items.AddRange(mystring)
        read.Close()

        Dim read2 As StreamReader = New StreamReader(System.AppDomain.CurrentDomain.BaseDirectory & "\Misc\activate.lua")
        Dim mystring2() As String = read2.ReadToEnd.Split(vbNewLine)
        ListBox4.Items.AddRange(mystring2)
        read2.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Lua Files (*.lua)|*.lua|All Files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.InitialDirectory = My.Settings.GameDirectory
        OpenFileDialog1.RestoreDirectory = True
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim file As New System.IO.StreamReader(OpenFileDialog1.FileName)
            TextBox1.Text = OpenFileDialog1.FileName
            SyntaxRichTextBox1.Text = file.ReadToEnd
            file.Close()
            SyntaxRichTextBox1.CompileKeywords()
            SyntaxRichTextBox1.ProcessAllLines()

        End If
    End Sub

    Private Sub CreateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateToolStripMenuItem.Click

    End Sub

    Private Sub SyntaxRichTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SyntaxRichTextBox1.KeyPress

        Dim pt As New Point(0, 0)
        Dim charIndexFromPosition As Integer = Me.SyntaxRichTextBox1.GetCharIndexFromPosition(pt)
        Dim lineFromCharIndex As Integer = Me.SyntaxRichTextBox1.GetLineFromCharIndex(charIndexFromPosition)
        pt.X = MyBase.ClientRectangle.Width
        pt.Y = MyBase.ClientRectangle.Height
        Dim index As Integer = Me.SyntaxRichTextBox1.GetCharIndexFromPosition(pt)
        Dim num4 As Integer = Me.SyntaxRichTextBox1.GetLineFromCharIndex(index)
        pt = Me.SyntaxRichTextBox1.GetPositionFromCharIndex(index)
        Me.SyntaxRichTextBox1.Text = ""
        Dim i As Integer = lineFromCharIndex
        Do While (i <= (num4 + 1))
            Me.SyntaxRichTextBox1.Text = (Me.SyntaxRichTextBox1.Text & (i + 1) & ChrW(10))
            i += 1
        Loop
        Me.undoList.Push(Me.SyntaxRichTextBox1.Text)
    End Sub

    Private Sub SyntaxRichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SyntaxRichTextBox1.TextChanged
        Dim pt As New Point(0, 0)
        Dim charIndexFromPosition As Integer = Me.SyntaxRichTextBox1.GetCharIndexFromPosition(pt)
        Dim lineFromCharIndex As Integer = Me.SyntaxRichTextBox1.GetLineFromCharIndex(charIndexFromPosition)
        pt.X = MyBase.ClientRectangle.Width
        pt.Y = MyBase.ClientRectangle.Height
        Dim index As Integer = Me.SyntaxRichTextBox1.GetCharIndexFromPosition(pt)
        Dim num4 As Integer = Me.SyntaxRichTextBox1.GetLineFromCharIndex(index)
        pt = Me.SyntaxRichTextBox1.GetPositionFromCharIndex(index)
        Me.numberLabel.Text = ""
        Dim i As Integer = lineFromCharIndex
        Do While (i <= (num4 + 1))
            Me.numberLabel.Text = (Me.numberLabel.Text & (i + 1) & ChrW(10))
            i += 1
        Loop
    End Sub

    Private Sub SyntaxRichTextBox1_VScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles SyntaxRichTextBox1.VScroll
        Dim pt As New Point(0, 0)
        Dim charIndexFromPosition As Integer = Me.SyntaxRichTextBox1.GetCharIndexFromPosition(pt)
        Dim lineFromCharIndex As Integer = Me.SyntaxRichTextBox1.GetLineFromCharIndex(charIndexFromPosition)
        pt.X = MyBase.ClientRectangle.Width
        pt.Y = MyBase.ClientRectangle.Height
        Dim index As Integer = Me.SyntaxRichTextBox1.GetCharIndexFromPosition(pt)
        Dim num4 As Integer = Me.SyntaxRichTextBox1.GetLineFromCharIndex(index)
        pt = Me.SyntaxRichTextBox1.GetPositionFromCharIndex(index)
        Me.numberLabel.Text = ""
        Dim i As Integer = lineFromCharIndex
        Do While (i <= (num4 + 1))
            Me.numberLabel.Text = (Me.numberLabel.Text & (i + 1) & ChrW(10))
            i += 1
        Loop
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Me.SyntaxRichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Me.SyntaxRichTextBox1.Paste()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Lua Files (*.lua)|*.lua|All Files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim writer As New StreamWriter(SaveFileDialog1.FileName)
            writer.WriteLine(SyntaxRichTextBox1.Text)
            writer.Close()
        End If
    End Sub



    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        Dim check As Boolean = False
        If check = False Then


            If Form1.TextBox21.Text <> "" Then
                ListBox2.Items.Add(Form1.TextBox21.Text)
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox1))

                Label12.Text += 1
            End If
            If Form1.TextBox20.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox2))
                ListBox2.Items.Add(Form1.TextBox20.Text)
                Label12.Text += 1
            End If
            If Form1.TextBox19.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox3))
                ListBox2.Items.Add(Form1.TextBox19.Text)
                Label12.Text += 1
            End If
            If Form1.TextBox18.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox4))
                ListBox2.Items.Add(Form1.TextBox18.Text)
                Label12.Text += 1
            End If
            If Form1.TextBox17.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox5))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox17.Text)
            End If
            If Form1.TextBox16.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox6))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox16.Text)
            End If
            If Form1.TextBox15.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox7))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox15.Text)
            End If
            If Form1.TextBox14.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox8))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox14.Text)
            End If
            If Form1.TextBox13.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox9))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox13.Text)
            End If
            If Form1.TextBox12.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox10))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox12.Text)
            End If
            If Form1.TextBox11.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox31))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox11.Text)
            End If
            If Form1.TextBox10.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox32))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox10.Text)
            End If
            If Form1.TextBox9.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox33))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox9.Text)
            End If
            If Form1.TextBox8.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox34))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox8.Text)
            End If
            If Form1.TextBox7.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox35))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox7.Text)
            End If
            If Form1.TextBox6.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox15))
                Label12.Text += 1
                ListBox2.Items.Add(Form1.TextBox6.Text)
            End If
            If GlobalVariables.card1 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox45))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card1)
            End If
            If GlobalVariables.card2 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox44))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card2)
            End If
            If GlobalVariables.card3 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox43))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card3)
            End If
            If GlobalVariables.card4 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox42))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card4)
            End If
            If GlobalVariables.card5 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox41))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card5)
            End If
            If GlobalVariables.grave11 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox55))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card6)
            End If
            If GlobalVariables.grave12 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox54))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card7)
            End If
            If GlobalVariables.grave13 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox53))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card8)
            End If
            If GlobalVariables.grave14 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox52))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card9)
            End If
            If GlobalVariables.grave15 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox51))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card10)
            End If
            If GlobalVariables.removed11 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox65))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card11)
            End If
            If GlobalVariables.removed12 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox64))
                Label12.Text += 1
                ListBox2.Items.Add(GlobalVariables.card12)
            End If
            If GlobalVariables.removed13 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox63))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card13)
            End If
            If GlobalVariables.removed14 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox62))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card14)
            End If
            If GlobalVariables.removed15 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox61))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card15)
            End If
            If GlobalVariables.extra11 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox75))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card16)
            End If
            If GlobalVariables.extra12 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox74))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card17)
            End If
            If GlobalVariables.extra13 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox73))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card18)
            End If
            If GlobalVariables.extra14 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox72))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card19)
            End If
            If GlobalVariables.extra15 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox71))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card20)
            End If




            If Form1.TextBox32.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox21))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox32.Text)
            End If
            If Form1.TextBox33.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox20))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox33.Text)
            End If
            If Form1.TextBox34.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox19))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox34.Text)
            End If
            If Form1.TextBox35.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox18))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox35.Text)
            End If
            If Form1.TextBox36.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox17))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox36.Text)
            End If
            If Form1.TextBox37.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox26))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox37.Text)
            End If
            If Form1.TextBox38.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox27))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox38.Text)
            End If
            If Form1.TextBox39.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox28))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox39.Text)
            End If
            If Form1.TextBox40.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox29))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox40.Text)
            End If
            If Form1.TextBox41.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox30))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox41.Text)
            End If
            If Form1.TextBox26.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox16))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox26.Text)
            End If
            If Form1.TextBox27.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox40))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox27.Text)
            End If
            If Form1.TextBox28.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox39))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox28.Text)
            End If
            If Form1.TextBox29.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox38))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox29.Text)
            End If
            If Form1.TextBox30.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox37))
                Label12.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox30.Text)
            End If
            If Form1.TextBox31.Text <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox36))
                Label8.Text += 1
                Me.ListBox2.Items.Add(Form1.TextBox31.Text)
            End If
            If GlobalVariables.deck21 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox50))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card21)
            End If
            If GlobalVariables.deck22 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox49))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card22)
            End If
            If GlobalVariables.deck23 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox48))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card23)
            End If
            If GlobalVariables.deck24 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox47))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card24)

            End If
            If GlobalVariables.deck25 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox46))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card25)
            End If
            If GlobalVariables.grave21 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox60))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card26)
            End If
            If GlobalVariables.grave22 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox59))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card27)
            End If
            If GlobalVariables.grave23 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox58))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card28)
            End If
            If GlobalVariables.grave24 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox57))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card29)
            End If
            If GlobalVariables.grave25 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox56))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card30)
            End If
            If GlobalVariables.removed21 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox70))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card31)
            End If
            If GlobalVariables.removed22 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox69))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card32)
            End If
            If GlobalVariables.removed23 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox68))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card33)
            End If
            If GlobalVariables.removed24 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox67))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card34)
            End If
            If GlobalVariables.removed25 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox66))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card35)
            End If
            If GlobalVariables.extra21 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox80))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card36)
            End If
            If GlobalVariables.extra22 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox79))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card37)
            End If
            If GlobalVariables.extra23 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox78))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card38)
            End If
            If GlobalVariables.extra24 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox77))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card39)
            End If
            If GlobalVariables.extra25 <> "" Then
                ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox76))
                Label12.Text += 1
                Me.ListBox2.Items.Add(GlobalVariables.card40)
            End If
        End If
        check = True
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged

        Dim selection As String = Me.CheckedListBox1.SelectedItem.ToString
        If CheckedListBox1.SelectedItem = "AI Default" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\ai.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Base" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\ai-base.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Simple" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\ai-template.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Gets Archetypes" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\AIArchetypeID.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Checks Possible Spells/Traps" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\AICheckPossibleST.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Use Helper Functions" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\AIHelperFunctions.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Use On Deck Select" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\AIOnDeckSelect.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Declare Attribute" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\DeclareAttribute.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Declare Card" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\DeclareCard.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Declare Monster Type" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\DeclareMonsterType.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Select Battle Command" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectBattleCommand.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Select Battle Chain" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectChain.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Select Card Target" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectCard.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Effect Activation" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectEffectYesNo.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Select Number" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectNumber.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Select Option" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectOption.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Select Position" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectPosition.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Select Tribute" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectTribute.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Select Choices" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectYesNo.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Init Commands" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\mod\SelectInitCommand.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Activatable Card" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\activate.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
        If CheckedListBox1.SelectedItem = "AI Summonable Card" Then
            Dim text As String = File.ReadAllText(My.Settings.GameDirectory & "\ai\summon.lua")
            SyntaxRichTextBox1.Clear()
            SyntaxRichTextBox1.SelectedText = text
        End If
    End Sub


    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim selection As String = Me.TreeView1.SelectedNode.ToString
        If TreeView1.SelectedNode.Text.Contains("Main Deck") Then
            Dim text As String = "LOCATION_DECK"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Hand") Then
            Dim text As String = "LOCATION_HAND"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Monster Zone") Then
            Dim text As String = "LOCATION_MZONE"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Spells Zone") Then
            Dim text As String = "LOCATION_SZONE"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Graveyard") Then
            Dim text As String = "LOCATION_GRAVE"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Banished") Then
            Dim text As String = "LOCATION_REMOVED"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Extra Deck") Then
            Dim text As String = "LOCATION_EXTRA"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Face-up") Then
            Dim text As String = "POS_FACEUP"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Face-down") Then
            Dim text As String = "POS_FACEDOWN"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Face-up atk") Then
            Dim text As String = "POS_FACEUP_ATTACK"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Face-up def") Then
            Dim text As String = "POS_FACEUP_DEFENCE"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Face-down def") Then
            Dim text As String = "POS_FACEDOWN_DEFENCE"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Draw Phase") Then
            Dim text As String = "PHASE_DRAW"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Standby Phase") Then
            Dim text As String = "PHASE_STANDBY"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Main Phase") Then
            Dim text As String = "PHASE_MAIN1"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Battle Phase") Then
            Dim text As String = "PHASE_BATTLE"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Damage Phase") Then
            Dim text As String = "PHASE_DAMAGE"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("Main Phase 2") Then
            Dim text As String = "PHASE_MAIN2"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
        If TreeView1.SelectedNode.Text.Contains("End Phase") Then
            Dim text As String = "PHASE_END"
            RichTextBox1.Clear()
            RichTextBox1.SelectedText = text
        End If
    End Sub


    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListBox5.Items.Count <> 0 Then

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ListBox2.SelectedItem <> 0 And ListBox1.SelectedItem <> "" Then
            ListBox5.Items.Add(ListBox2.SelectedItem)
            ListBox6.Items.Add(ListBox1.SelectedItem)
        Else
            MsgBox("Please select card code to add to AI use cards")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If ListBox2.SelectedItem <> 0 And ListBox1.SelectedItem <> "" Then
            ListBox7.Items.Add(ListBox2.SelectedItem)
            ListBox8.Items.Add(ListBox1.SelectedItem)
        Else
            MsgBox("Please select card code to add to AI use cards")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ListBox2.SelectedItem <> 0 Then
            Dim item As String = ListBox2.SelectedItem
            Dim item2 As String = ListBox1.SelectedItem
            If ListBox5.Items.Contains(ListBox2.SelectedItem) Then
                ListBox5.Items.Remove(ListBox2.SelectedItem)
                ListBox6.Items.Remove(ListBox1.SelectedItem)
            ElseIf ListBox7.Items.Contains(ListBox2.SelectedItem) Then
                ListBox7.Items.Remove(ListBox2.SelectedItem)
                ListBox8.Items.Remove(ListBox1.SelectedItem)
            Else
                MsgBox("The selected card is not in AI usable cards collection")
            End If


        Else
            MsgBox("Please select card code to add to AI activate cards")
        End If
    End Sub


    Private Sub DefaultToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultToolStripMenuItem1.Click
        Dim prompt As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ai-base.lua")
        Try
            writer = New StreamWriter(prompt)
            If TextBox2.Text <> "" And TextBox3.Text <> "" Then
                writer.WriteLine("--[[")
                writer.WriteLine(TextBox2.Text & ".lua")
                writer.WriteLine()
                writer.WriteLine("Author=" & TextBox3.Text)
                writer.WriteLine("--]]")
            Else
                MsgBox("Add AI name and author")
            End If
            writer.WriteLine()

            Dim aiarchetype As String = "require(" & My.Settings.CharSimple & "ai.mod.AIArchetypeID" & My.Settings.Chars
            writer.WriteLine(aiarchetype)

            Dim aicheckst As String = "require(" & My.Settings.CharSimple & "ai.mod.AICheckPossibleST" & My.Settings.Chars
            writer.WriteLine(aicheckst)

            Dim aihelper As String = "require(" & My.Settings.CharSimple & "ai.mod.AIHelperFunctions" & My.Settings.Chars
            writer.WriteLine(aihelper)

            Dim aideck As String = "require(" & My.Settings.CharSimple & "ai.mod.AIOnDeckSelect" & My.Settings.Chars
            writer.WriteLine(aideck)

            Dim aiattrib As String = "require(" & My.Settings.CharSimple & "ai.mod.DeclareAttribute" & My.Settings.Chars
            writer.WriteLine(aiattrib)


            Dim aicard As String = "require(" & My.Settings.CharSimple & "ai.mod.DeclareCard" & My.Settings.Chars
            writer.WriteLine(aicard)

            Dim aiamons As String = "require(" & My.Settings.CharSimple & "ai.mod.DeclareMonsterType" & My.Settings.Chars
            writer.WriteLine(aiamons)


            Dim aiascard As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectCard" & My.Settings.Chars
            writer.WriteLine(aiascard)


            Dim aischain As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectChain" & My.Settings.Chars
            writer.WriteLine(aischain)

            Dim aisyesno As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectEffectYesNo" & My.Settings.Chars
            writer.WriteLine(aisyesno)

            Dim aiscommand As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectBattleCommand" & My.Settings.Chars
            writer.WriteLine(aiscommand)

            Dim aisynum As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectNumber" & My.Settings.Chars
            writer.WriteLine(aisynum)

            Dim aisoption As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectOption" & My.Settings.Chars
            writer.WriteLine(aisoption)


            Dim aistribb As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectTribute" & My.Settings.Chars
            writer.WriteLine(aistribb)


            Dim aisspost As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectPosition" & My.Settings.Chars
            writer.WriteLine(aisspost)

            Dim aisyesnot As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectYesNo" & My.Settings.Chars
            writer.WriteLine(aisyesnot)

            Dim aisinit As String = "require(" & My.Settings.CharSimple & "ai.mod.SelectInitCommand" & My.Settings.Chars
            writer.WriteLine(aisinit)

            writer.WriteLine()
            writer.WriteLine(My.Settings.MathRandomset)
            writer.WriteLine()
            writer.WriteLine("function OnStartOfDuel()")
            writer.WriteLine("SaveState()")
            writer.WriteLine("end")
            writer.Close()
            writer.Dispose()
            MsgBox("AI default file has been created")
        Catch ex As Exception
            MsgBox("No AI file has been created")
        End Try
    End Sub

    Private Sub NeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeToolStripMenuItem.Click
        Try
            Dim strAppDir As String = Directory.GetCurrentDirectory
            Dim base As String = Path.Combine(strAppDir, "\Misc\ai-base.lua")
            Dim activate As String = Path.Combine(strAppDir, "\Misc\activate.lua")
            Dim summon As String = Path.Combine(strAppDir, "\Misc\summon.lua")
            My.Computer.FileSystem.CopyFile(Directory.GetCurrentDirectory & "\Misc\ai-base.lua", My.Settings.GameDirectory & "\ai\ai-base.lua")
            My.Computer.FileSystem.CopyFile(Directory.GetCurrentDirectory & "\Misc\activate.lua", My.Settings.GameDirectory & "\ai\activate.lua")
            My.Computer.FileSystem.CopyFile(Directory.GetCurrentDirectory & "\Misc\summon.lua", My.Settings.GameDirectory & "\ai\summon.lua")
            MsgBox("AI Base file succesfully created")
        Catch ex As Exception
            MsgBox("File cannot be created")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileDialog2.Filter = "Deck Files (*.ydk)|*.ydk|All Files (*.*)|*.*"
        OpenFileDialog2.FilterIndex = 1

        Try
            If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                TextBox6.Text = OpenFileDialog1.FileName


                Interaction.MsgBox("Deck File loaded", MsgBoxStyle.ApplicationModal, Nothing)
            End If

        Catch ex As Exception
            Interaction.MsgBox("File cannot be loaded", MsgBoxStyle.ApplicationModal, Nothing)
        End Try
    End Sub
End Class