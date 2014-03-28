Imports System.Text
Imports System.IO.File
Imports System.IO
Imports System.Net
Imports System.Data.SQLite



Public Class Form1



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try
            Dim Response As Integer

            ' Displays a message box with the yes and no options.
            Response = MsgBox(Prompt:="Please open the YGO PRO cards.cdb folder?", Buttons:=vbYesNo)

            ' If statement to check if the yes button was selected.
            If Response = vbYes Then
                FolderBrowserDialog1.Description = "YGO PRO FOLDER"
                If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                    GameDirectoryBox.Text = FolderBrowserDialog1.SelectedPath
                    My.Settings.GameDirectory = GameDirectoryBox.Text
                End If

            Else
                ' The no button was selected.
                MsgBox("Now you cannot edit files using database")
            End If

        Catch ex As Exception
            MsgBox("Now you cannot edit files using database")
        End Try

        Dim conenction As New SQLiteConnection((GameDirectoryBox.Text & "\cards.cdb"))
        Dim path As String
        path = (GameDirectoryBox.Text & "\cards.cdb")
        If Not File.Exists("C:\cards.cdb") Then
            File.Copy(GameDirectoryBox.Text & "\cards.cdb", "C:\cards.cdb")

        End If
        My.Settings.GameDirectory = GameDirectoryBox.Text
        My.Settings.Save()
    End Sub


    Private Sub CreateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateToolStripMenuItem.Click
        Try
            Dim prompt As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\New.lua")

            If Not File.Exists(prompt) Then
                File.Create(prompt).Dispose()
            End If
            Dim writer As New StreamWriter(prompt)
            writer.WriteLine("--" & TextBox46.Text)
            writer.WriteLine()
            writer.WriteLine(My.Settings.AINAME & TextBox42.Text & My.Settings.Chars)
            writer.WriteLine(My.Settings.BeginReload & ComboBox1.SelectedItem & "+" & ComboBox2.SelectedItem & My.Settings.Bars)
            writer.WriteLine()
            writer.WriteLine((My.Settings.PlayerInfo & TextBox45.Text & My.Settings.PlayerInfo2))
            writer.WriteLine((My.Settings.AIInfo & Me.TextBox43.Text & My.Settings.AIinfo2))
            writer.WriteLine()
            writer.WriteLine(GlobalVariables.deck11)
            writer.WriteLine(GlobalVariables.deck12)
            writer.WriteLine(GlobalVariables.deck13)
            writer.WriteLine(GlobalVariables.deck14)
            writer.WriteLine(GlobalVariables.deck15)
            writer.WriteLine(GlobalVariables.grave11)
            writer.WriteLine(GlobalVariables.grave12)
            writer.WriteLine(GlobalVariables.grave13)
            writer.WriteLine(GlobalVariables.grave14)
            writer.WriteLine(GlobalVariables.grave15)
            writer.WriteLine(GlobalVariables.removed11)
            writer.WriteLine(GlobalVariables.removed12)
            writer.WriteLine(GlobalVariables.removed13)
            writer.WriteLine(GlobalVariables.removed14)
            writer.WriteLine(GlobalVariables.removed15)
            writer.WriteLine(GlobalVariables.extra11)
            writer.WriteLine(GlobalVariables.extra12)
            writer.WriteLine(GlobalVariables.extra13)
            writer.WriteLine(GlobalVariables.extra14)
            writer.WriteLine(GlobalVariables.extra15)
            If (Me.TextBox6.Text <> "") Then
                GlobalVariables.field1 = (My.Settings.AddCard & Me.TextBox6.Text & GlobalVariables.fieldpt & Me.ComboBox31.Text)
                writer.WriteLine(GlobalVariables.field1)
            End If
            If (Me.TextBox21.Text <> "") Then
                GlobalVariables.monster11 = (My.Settings.AddCard & Me.TextBox21.Text & ",0,0,LOCATION_MZONE,0," & Me.ComboBox11.Text)
                writer.WriteLine(GlobalVariables.monster11)
            End If
            If (Me.TextBox20.Text <> "") Then
                GlobalVariables.monster12 = (My.Settings.AddCard & Me.TextBox20.Text & ",0,0,LOCATION_MZONE,1," & Me.ComboBox12.Text)
                writer.WriteLine(GlobalVariables.monster12)
            End If
            If (Me.TextBox19.Text <> "") Then
                GlobalVariables.monster13 = (My.Settings.AddCard & Me.TextBox19.Text & ",0,0,LOCATION_MZONE,2," & Me.ComboBox13.Text)
                writer.WriteLine(GlobalVariables.monster13)
            End If
            If (Me.TextBox18.Text <> "") Then
                GlobalVariables.monster14 = (My.Settings.AddCard & Me.TextBox18.Text & ",0,0,LOCATION_MZONE,3," & Me.ComboBox14.Text)
                writer.WriteLine(GlobalVariables.monster14)
            End If
            If (Me.TextBox17.Text <> "") Then
                GlobalVariables.monster15 = (My.Settings.AddCard & Me.TextBox17.Text & ",0,0,LOCATION_SZONE,4," & Me.ComboBox15.Text)
                writer.WriteLine(GlobalVariables.monster15)
            End If
            If (Me.TextBox16.Text <> "") Then
                GlobalVariables.szone11 = (My.Settings.AddCard & Me.TextBox16.Text & ",0,0,LOCATION_SZONE,0," & Me.ComboBox21.Text)
                writer.WriteLine(GlobalVariables.szone11)
            End If
            If (Me.TextBox15.Text <> "") Then
                GlobalVariables.szone12 = (My.Settings.AddCard & Me.TextBox15.Text & ",0,0,LOCATION_SZONE,1," & Me.ComboBox22.Text)
                writer.WriteLine(GlobalVariables.szone12)
            End If
            If (Me.TextBox14.Text <> "") Then
                GlobalVariables.szone13 = (My.Settings.AddCard & Me.TextBox14.Text & ",0,0,LOCATION_SZONE,2," & Me.ComboBox23.Text)
                writer.WriteLine(GlobalVariables.szone13)
            End If
            If (Me.TextBox13.Text <> "") Then
                GlobalVariables.szone14 = (My.Settings.AddCard & Me.TextBox13.Text & ",0,0,LOCATION_SZONE,3," & Me.ComboBox24.Text)
                writer.WriteLine(GlobalVariables.szone14)
            End If
            If (Me.TextBox12.Text <> "") Then
                GlobalVariables.szone15 = (My.Settings.AddCard & Me.TextBox12.Text & ",0,0,LOCATION_SZONE,4," & Me.ComboBox25.Text)
                writer.WriteLine(GlobalVariables.szone15)
            End If
            If (Me.TextBox11.Text <> "") Then
                GlobalVariables.hand11 = (My.Settings.AddCard & Me.TextBox11.Text & GlobalVariables.handpt)
                writer.WriteLine(GlobalVariables.hand11)
            End If
            If (Me.TextBox10.Text <> "") Then
                GlobalVariables.hand12 = (My.Settings.AddCard & Me.TextBox10.Text & GlobalVariables.handpt)
                writer.WriteLine(GlobalVariables.hand12)
            End If
            If (Me.TextBox9.Text <> "") Then
                GlobalVariables.hand13 = (My.Settings.AddCard & Me.TextBox9.Text & GlobalVariables.handpt)
                writer.WriteLine(GlobalVariables.hand13)
            End If
            If (Me.TextBox8.Text <> "") Then
                GlobalVariables.hand14 = (My.Settings.AddCard & Me.TextBox8.Text & GlobalVariables.handpt)
                writer.WriteLine(GlobalVariables.hand14)
            End If
            If (Me.TextBox7.Text <> "") Then
                GlobalVariables.hand15 = (My.Settings.AddCard & Me.TextBox7.Text & GlobalVariables.handpt)
                writer.WriteLine(GlobalVariables.hand15)
            End If
            writer.WriteLine(GlobalVariables.deck21)
            writer.WriteLine(GlobalVariables.deck22)
            writer.WriteLine(GlobalVariables.deck23)
            writer.WriteLine(GlobalVariables.deck24)
            writer.WriteLine(GlobalVariables.deck25)
            writer.WriteLine(GlobalVariables.grave21)
            writer.WriteLine(GlobalVariables.grave22)
            writer.WriteLine(GlobalVariables.grave23)
            writer.WriteLine(GlobalVariables.grave24)
            writer.WriteLine(GlobalVariables.grave25)
            writer.WriteLine(GlobalVariables.removed21)
            writer.WriteLine(GlobalVariables.removed22)
            writer.WriteLine(GlobalVariables.removed23)
            writer.WriteLine(GlobalVariables.removed24)
            writer.WriteLine(GlobalVariables.removed25)
            writer.WriteLine(GlobalVariables.extra21)
            writer.WriteLine(GlobalVariables.extra22)
            writer.WriteLine(GlobalVariables.extra23)
            writer.WriteLine(GlobalVariables.extra24)
            writer.WriteLine(GlobalVariables.extra25)
            If (Me.TextBox26.Text <> "") Then
                GlobalVariables.field2 = (My.Settings.AddCard & Me.TextBox26.Text & GlobalVariables.field2pt & Me.ComboBox32.Text)
                writer.WriteLine(GlobalVariables.field2)
            End If
            If (Me.TextBox32.Text <> "") Then
                GlobalVariables.monster21 = (My.Settings.AddCard & Me.TextBox32.Text & ",1,1,LOCATION_MZONE,0," & Me.ComboBox16.Text)
                writer.WriteLine(GlobalVariables.monster21)
            End If
            If (Me.TextBox33.Text <> "") Then
                GlobalVariables.monster22 = (My.Settings.AddCard & Me.TextBox33.Text & ",1,1,LOCATION_MZONE,1," & Me.ComboBox17.Text)
                writer.WriteLine(GlobalVariables.monster22)
            End If
            If (Me.TextBox34.Text <> "") Then
                GlobalVariables.monster23 = (My.Settings.AddCard & Me.TextBox34.Text & ",1,1,LOCATION_MZONE,2," & Me.ComboBox18.Text)
                writer.WriteLine(GlobalVariables.monster23)
            End If
            If (Me.TextBox35.Text <> "") Then
                GlobalVariables.monster24 = (My.Settings.AddCard & Me.TextBox35.Text & ",1,1,LOCATION_MZONE,3," & Me.ComboBox19.Text)
                writer.WriteLine(GlobalVariables.monster24)
            End If
            If (Me.TextBox36.Text <> "") Then
                GlobalVariables.monster25 = (My.Settings.AddCard & Me.TextBox36.Text & ",1,1,LOCATION_MZONE,4," & Me.ComboBox20.Text)
                writer.WriteLine(GlobalVariables.monster25)
            End If
            If (Me.TextBox37.Text <> "") Then
                GlobalVariables.szone21 = (My.Settings.AddCard & Me.TextBox37.Text & ",1,1,LOCATION_SZONE,0," & Me.ComboBox26.Text)
                writer.WriteLine(GlobalVariables.szone21)
            End If
            If (Me.TextBox38.Text <> "") Then
                GlobalVariables.szone22 = (My.Settings.AddCard & Me.TextBox38.Text & ",1,1,LOCATION_SZONE,1," & Me.ComboBox27.Text)
                writer.WriteLine(GlobalVariables.szone22)
            End If
            If (Me.TextBox39.Text <> "") Then
                GlobalVariables.szone23 = (My.Settings.AddCard & Me.TextBox39.Text & ",1,1,LOCATION_SZONE,2," & Me.ComboBox28.Text)
                writer.WriteLine(GlobalVariables.szone23)
            End If
            If (Me.TextBox40.Text <> "") Then
                GlobalVariables.szone24 = (My.Settings.AddCard & Me.TextBox40.Text & ",1,1,LOCATION_SZONE,3," & Me.ComboBox29.Text)
                writer.WriteLine(GlobalVariables.szone24)
            End If
            If (Me.TextBox41.Text <> "") Then
                GlobalVariables.szone25 = (My.Settings.AddCard & Me.TextBox41.Text & ",1,1,LOCATION_SZONE,4," & Me.ComboBox30.Text)
                writer.WriteLine(GlobalVariables.szone25)
            End If
            If (Me.TextBox27.Text <> "") Then
                GlobalVariables.hand21 = (My.Settings.AddCard & Me.TextBox27.Text & GlobalVariables.handpt2)
                writer.WriteLine(GlobalVariables.hand21)
            End If
            If (Me.TextBox28.Text <> "") Then
                GlobalVariables.hand22 = (My.Settings.AddCard & Me.TextBox28.Text & GlobalVariables.handpt2)
                writer.WriteLine(GlobalVariables.hand22)
            End If
            If (Me.TextBox29.Text <> "") Then
                GlobalVariables.hand23 = (My.Settings.AddCard & Me.TextBox29.Text & GlobalVariables.handpt2)
                writer.WriteLine(GlobalVariables.hand23)
            End If
            If (Me.TextBox30.Text <> "") Then
                GlobalVariables.hand24 = (My.Settings.AddCard & Me.TextBox30.Text & GlobalVariables.handpt2)
                writer.WriteLine(GlobalVariables.hand24)
            End If
            If (Me.TextBox31.Text <> "") Then
                GlobalVariables.hand25 = (My.Settings.AddCard & Me.TextBox31.Text & GlobalVariables.handpt2)
                writer.WriteLine(GlobalVariables.hand25)
            End If
            writer.WriteLine(My.Settings.ReloadField)
            writer.WriteLine(My.Settings.ShowHint & TextBox47.Text & My.Settings.ShowHint2)

            If CheckBox4.Checked Then
                writer.WriteLine(My.Settings.BeginPuzzle)

            Else
                If CheckBox3.Checked Then
                    writer.WriteLine(My.Settings.TurnCount)
                End If
            End If

            writer.Close()
            Interaction.MsgBox(prompt & vbNewLine & "File created", MsgBoxStyle.ApplicationModal, Nothing)
        Catch exception1 As Exception

            Dim exception As Exception = exception1
            Interaction.MsgBox("File cannot be created", MsgBoxStyle.ApplicationModal, Nothing)

        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If (Me.ComboBox3.Text <> "") Then
            If (GlobalVariables.deck11 = "") Then
                Me.PictureBox45.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox3.SelectedItem & ".jpg"
                GlobalVariables.deck11 = My.Settings.AddCard & Me.ComboBox3.SelectedItem & GlobalVariables.deck1p
                GlobalVariables.card1 = Me.ComboBox3.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox45, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(1) added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck12 = "") Then
                Me.PictureBox44.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox3.SelectedItem & ".jpg"
                GlobalVariables.deck12 = My.Settings.AddCard & Me.ComboBox3.SelectedItem & GlobalVariables.deck1p
                GlobalVariables.card2 = Me.ComboBox3.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox44, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(2) added to yout deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck13 = "") Then
                Me.PictureBox43.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox3.SelectedItem & ".jpg"
                GlobalVariables.deck13 = My.Settings.AddCard & Me.ComboBox3.SelectedItem & GlobalVariables.deck1p
                GlobalVariables.card3 = Me.ComboBox3.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox43, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(3) added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck14 = "") Then
                Me.PictureBox42.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox3.SelectedItem & ".jpg"
                GlobalVariables.deck14 = My.Settings.AddCard & Me.ComboBox3.SelectedItem & GlobalVariables.deck1p
                GlobalVariables.card4 = Me.ComboBox3.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox42, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(4) added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck15 = "") Then
                Me.PictureBox41.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox3.SelectedItem & ".jpg"
                GlobalVariables.deck15 = My.Settings.AddCard & Me.ComboBox3.SelectedItem & GlobalVariables.deck1p
                GlobalVariables.card5 = Me.ComboBox3.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox41, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(5) added to your your deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        If ((Me.TextBox2.Text.Length > 0) And (Me.TextBox2.Text.Length > 0)) Then
            Me.TextBox2.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If (Me.ComboBox4.Text <> "") Then
            If (GlobalVariables.grave11 = "") Then
                Me.PictureBox55.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox4.SelectedItem & ".jpg"
                GlobalVariables.grave11 = My.Settings.AddCard & Me.ComboBox4.SelectedItem & GlobalVariables.gravept
                GlobalVariables.card6 = Me.ComboBox4.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox55, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(1) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave12 = "") Then
                Me.PictureBox54.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox4.SelectedItem & ".jpg"
                GlobalVariables.grave12 = My.Settings.AddCard & Me.ComboBox4.SelectedItem & GlobalVariables.gravept
                GlobalVariables.card7 = Me.ComboBox4.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox54, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(2) added to yout graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave13 = "") Then
                Me.PictureBox53.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox4.SelectedItem & ".jpg"
                GlobalVariables.grave13 = My.Settings.AddCard & Me.ComboBox4.SelectedItem & GlobalVariables.gravept
                GlobalVariables.card8 = Me.ComboBox4.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox53, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(3) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave14 = "") Then
                Me.PictureBox52.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox4.SelectedItem & ".jpg"
                GlobalVariables.grave14 = My.Settings.AddCard & Me.ComboBox4.SelectedItem & GlobalVariables.gravept
                GlobalVariables.card9 = Me.ComboBox4.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox52, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(4) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave15 = "") Then
                Me.PictureBox51.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox4.SelectedItem & ".jpg"
                GlobalVariables.grave15 = My.Settings.AddCard & Me.ComboBox4.SelectedItem & GlobalVariables.gravept
                GlobalVariables.card10 = Me.ComboBox4.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox51, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(5) added to your your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        If ((Me.TextBox3.Text.Length > 0) And (Me.TextBox3.Text.Length > 0)) Then
            Me.TextBox3.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        If (Me.ComboBox5.Text <> "") Then
            If (GlobalVariables.removed11 = "") Then
                Me.PictureBox65.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox5.SelectedItem & ".jpg"
                GlobalVariables.removed11 = My.Settings.AddCard & Me.ComboBox5.SelectedItem & GlobalVariables.removedpt
                GlobalVariables.card11 = Me.ComboBox5.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox65, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(1) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed12 = "") Then
                Me.PictureBox64.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox5.SelectedItem & ".jpg"
                GlobalVariables.removed12 = My.Settings.AddCard & Me.ComboBox5.SelectedItem & GlobalVariables.removedpt
                GlobalVariables.card12 = Me.ComboBox5.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox64, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(2) added to yout banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed13 = "") Then
                Me.PictureBox63.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox5.SelectedItem & ".jpg"
                GlobalVariables.removed13 = My.Settings.AddCard & Me.ComboBox5.SelectedItem & GlobalVariables.removedpt
                GlobalVariables.card13 = Me.ComboBox5.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox63, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(3) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed14 = "") Then
                Me.PictureBox62.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox5.SelectedItem & ".jpg"
                GlobalVariables.removed14 = My.Settings.AddCard & Me.ComboBox5.SelectedItem & GlobalVariables.removedpt
                GlobalVariables.card14 = Me.ComboBox5.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox62, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(4) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed15 = "") Then
                Me.PictureBox61.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox5.SelectedItem & ".jpg"
                GlobalVariables.removed15 = My.Settings.AddCard & Me.ComboBox5.SelectedItem & GlobalVariables.removedpt
                GlobalVariables.card15 = Me.ComboBox5.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox61, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(5) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        If ((Me.TextBox4.Text.Length > 0) And (Me.TextBox4.Text.Length > 0)) Then
            Me.TextBox4.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        If (Me.ComboBox6.Text <> "") Then
            If (GlobalVariables.extra11 = "") Then
                Me.PictureBox75.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox6.SelectedItem & ".jpg"
                GlobalVariables.extra11 = My.Settings.AddCard & Me.ComboBox6.SelectedItem & GlobalVariables.extrapt
                GlobalVariables.card16 = Me.ComboBox6.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox75, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(1) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra12 = "") Then
                Me.PictureBox74.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox6.SelectedItem & ".jpg"
                GlobalVariables.extra12 = My.Settings.AddCard & Me.ComboBox6.SelectedItem & GlobalVariables.extrapt
                GlobalVariables.card17 = Me.ComboBox6.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox74, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(2) added to yout extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra13 = "") Then
                Me.PictureBox73.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox6.SelectedItem & ".jpg"
                GlobalVariables.extra13 = My.Settings.AddCard & Me.ComboBox6.SelectedItem & GlobalVariables.extrapt
                GlobalVariables.card18 = Me.ComboBox6.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox73, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(3) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)

            ElseIf (GlobalVariables.extra14 = "") Then
                Me.PictureBox72.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox6.SelectedItem & ".jpg"
                GlobalVariables.extra14 = My.Settings.AddCard & Me.ComboBox6.SelectedItem & GlobalVariables.extrapt
                GlobalVariables.card19 = Me.ComboBox6.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox72, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(4) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra15 = "") Then
                Me.PictureBox71.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox6.SelectedItem & ".jpg"
                GlobalVariables.extra15 = My.Settings.AddCard & Me.ComboBox6.SelectedItem & GlobalVariables.extrapt
                GlobalVariables.card20 = Me.ComboBox6.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox71, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
                Interaction.MsgBox("Card(5) added to your your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        If ((Me.TextBox5.Text.Length > 0) And (Me.TextBox5.Text.Length > 0)) Then
            Me.TextBox5.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        If (Me.ComboBox7.Text <> "") Then
            If (GlobalVariables.deck21 = "") Then
                Me.PictureBox50.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox7.SelectedItem & ".jpg"
                GlobalVariables.deck21 = My.Settings.AddCard & Me.ComboBox7.SelectedItem & GlobalVariables.deck2p
                GlobalVariables.card21 = Me.ComboBox7.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox50, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(1) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck22 = "") Then
                Me.PictureBox49.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox7.SelectedItem & ".jpg"
                GlobalVariables.deck22 = My.Settings.AddCard & Me.ComboBox7.SelectedItem & GlobalVariables.deck2p
                GlobalVariables.card22 = Me.ComboBox7.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox49, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(2) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck23 = "") Then
                Me.PictureBox48.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox7.SelectedItem & ".jpg"
                GlobalVariables.deck23 = My.Settings.AddCard & Me.ComboBox7.SelectedItem & GlobalVariables.deck2p
                GlobalVariables.card23 = Me.ComboBox7.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox48, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(3) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck24 = "") Then
                Me.PictureBox47.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox7.SelectedItem & ".jpg"
                GlobalVariables.deck24 = My.Settings.AddCard & Me.ComboBox7.SelectedItem & GlobalVariables.deck2p
                GlobalVariables.card24 = Me.ComboBox7.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox47, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(4) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck25 = "") Then
                Me.PictureBox46.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox7.SelectedItem & ".jpg"
                GlobalVariables.deck25 = My.Settings.AddCard & Me.ComboBox7.SelectedItem & GlobalVariables.deck2p
                GlobalVariables.card25 = Me.ComboBox7.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox46, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(5) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        If ((Me.TextBox22.Text.Length > 0) And (Me.TextBox22.Text.Length > 0)) Then
            Me.TextBox22.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        If (Me.ComboBox8.Text <> "") Then
            If (GlobalVariables.grave21 = "") Then
                Me.PictureBox60.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox8.SelectedItem & ".jpg"
                GlobalVariables.grave21 = My.Settings.AddCard & Me.ComboBox8.SelectedItem & GlobalVariables.grave2pt
                GlobalVariables.card26 = Me.ComboBox8.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox60, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(1) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave22 = "") Then
                Me.PictureBox59.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox8.SelectedItem & ".jpg"
                GlobalVariables.grave22 = My.Settings.AddCard & Me.ComboBox8.SelectedItem & GlobalVariables.grave2pt
                GlobalVariables.card27 = Me.ComboBox8.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox59, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(2) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck23 = "") Then
                Me.PictureBox58.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox8.SelectedItem & ".jpg"
                GlobalVariables.grave23 = My.Settings.AddCard & Me.ComboBox8.SelectedItem & GlobalVariables.grave2pt
                GlobalVariables.card28 = Me.ComboBox8.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox58, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(3) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave24 = "") Then
                Me.PictureBox57.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox8.SelectedItem & ".jpg"
                GlobalVariables.grave24 = My.Settings.AddCard & Me.ComboBox8.SelectedItem & GlobalVariables.grave2pt
                GlobalVariables.card29 = Me.ComboBox8.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox57, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(4) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave25 = "") Then
                Me.PictureBox56.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox8.SelectedItem & ".jpg"
                GlobalVariables.grave25 = My.Settings.AddCard & Me.ComboBox8.SelectedItem & GlobalVariables.grave2pt
                GlobalVariables.card30 = Me.ComboBox8.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox56, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(5) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        If ((Me.TextBox23.Text.Length > 0) And (Me.TextBox23.Text.Length > 0)) Then
            Me.TextBox23.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        If (Me.ComboBox9.Text <> "") Then
            If (GlobalVariables.removed21 = "") Then
                Me.PictureBox70.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox9.SelectedItem & ".jpg"
                GlobalVariables.removed21 = My.Settings.AddCard & Me.ComboBox9.SelectedItem & GlobalVariables.removedpt2
                GlobalVariables.card31 = Me.ComboBox9.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox70, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(1) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed22 = "") Then
                Me.PictureBox69.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox9.SelectedItem & ".jpg"
                GlobalVariables.removed22 = My.Settings.AddCard & Me.ComboBox9.SelectedItem & GlobalVariables.removedpt2
                GlobalVariables.card32 = Me.ComboBox9.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox69, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(2) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed23 = "") Then
                Me.PictureBox68.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox9.SelectedItem & ".jpg"
                GlobalVariables.removed23 = My.Settings.AddCard & Me.ComboBox9.SelectedItem & GlobalVariables.removedpt2
                GlobalVariables.card33 = Me.ComboBox9.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox68, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(3) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed24 = "") Then
                Me.PictureBox67.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox9.SelectedItem & ".jpg"
                GlobalVariables.removed24 = My.Settings.AddCard & Me.ComboBox9.SelectedItem & GlobalVariables.removedpt2
                GlobalVariables.card34 = Me.ComboBox9.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox67, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(4) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed25 = "") Then
                Me.PictureBox66.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox9.SelectedItem & ".jpg"
                GlobalVariables.removed25 = My.Settings.AddCard & Me.ComboBox9.SelectedItem & GlobalVariables.removedpt2
                GlobalVariables.card35 = Me.ComboBox9.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox66, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(5) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        If ((Me.TextBox24.Text.Length > 0) And (Me.TextBox24.Text.Length > 0)) Then
            Me.TextBox24.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        If (Me.ComboBox10.Text <> "") Then
            If (GlobalVariables.extra21 = "") Then
                Me.PictureBox80.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox10.SelectedItem & ".jpg"
                GlobalVariables.extra21 = My.Settings.AddCard & Me.ComboBox10.SelectedItem & GlobalVariables.extrapt2
                GlobalVariables.card36 = Me.ComboBox10.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox80, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(1) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra22 = "") Then
                Me.PictureBox79.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox10.SelectedItem & ".jpg"
                GlobalVariables.extra22 = My.Settings.AddCard & Me.ComboBox10.SelectedItem & GlobalVariables.extrapt2
                GlobalVariables.card37 = Me.ComboBox10.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox79, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(2) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra23 = "") Then
                Me.PictureBox78.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox10.SelectedItem & ".jpg"
                GlobalVariables.extra23 = My.Settings.AddCard & Me.ComboBox10.SelectedItem & GlobalVariables.extrapt2
                GlobalVariables.card38 = Me.ComboBox10.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox78, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(3) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra24 = "") Then
                Me.PictureBox77.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox10.SelectedItem & ".jpg"
                GlobalVariables.extra24 = My.Settings.AddCard & Me.ComboBox10.SelectedItem & GlobalVariables.extrapt2
                GlobalVariables.card39 = Me.ComboBox10.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox77, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(4) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra25 = "") Then
                Me.PictureBox76.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ComboBox10.SelectedItem & ".jpg"
                GlobalVariables.extra25 = My.Settings.AddCard & Me.ComboBox10.SelectedItem & GlobalVariables.extrapt2
                GlobalVariables.card40 = Me.ComboBox10.SelectedItem
                Me.ToolTip1.SetToolTip(Me.PictureBox76, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
                Interaction.MsgBox("Card(5) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        If ((Me.TextBox25.Text.Length > 0) And (Me.TextBox25.Text.Length > 0)) Then
            Me.TextBox25.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        If (Me.ComboBox3.Text.Length > 0) Then
            If (GlobalVariables.deck15 <> "") Then
                PictureBox41.ImageLocation = ""
                Me.ComboBox3.Items.Remove(Me.ComboBox3.SelectedItem)
                GlobalVariables.card5 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox41, "")
                Me.Label54.Text -= 1
                GlobalVariables.deck15 = ""
                Interaction.MsgBox("Card(5) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck14 <> "") Then
                PictureBox42.ImageLocation = ""
                GlobalVariables.card4 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox42, "")
                Me.Label54.Text -= 1
                Me.ComboBox3.Items.Remove(Me.ComboBox3.SelectedItem)
                GlobalVariables.deck14 = ""
                Interaction.MsgBox("Card(4) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck13 <> "") Then
                PictureBox43.ImageLocation = ""
                GlobalVariables.card3 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox43, "")
                Me.Label54.Text -= 1
                Me.ComboBox3.Items.Remove(Me.ComboBox3.SelectedItem)
                GlobalVariables.deck13 = ""
                Interaction.MsgBox("Card(3) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck12 <> "") Then
                PictureBox44.ImageLocation = ""
                GlobalVariables.card2 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox44, "")
                Me.Label54.Text -= 1
                Me.ComboBox3.Items.Remove(Me.ComboBox3.SelectedItem)
                GlobalVariables.deck12 = ""
                Interaction.MsgBox("Card(2) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck11 <> "") Then
                PictureBox45.ImageLocation = ""
                GlobalVariables.card1 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox45, "")
                Me.Label54.Text -= 1
                Me.ComboBox3.Items.Remove(Me.ComboBox3.SelectedItem)
                GlobalVariables.deck11 = ""
                Interaction.MsgBox("Card(1) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Me.ComboBox3.Text = ""
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        If (Me.ComboBox7.Text.Length > 0) Then
            If (GlobalVariables.deck25 <> "") Then
                PictureBox46.ImageLocation = ""
                Me.ComboBox7.Items.Remove(Me.ComboBox7.SelectedItem)
                GlobalVariables.card25 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox46, "")
                Me.Label55.Text -= 1
                GlobalVariables.deck25 = ""
                Interaction.MsgBox("Card(5) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck24 <> "") Then
                PictureBox47.ImageLocation = ""
                Me.ComboBox7.Items.Remove(Me.ComboBox7.SelectedItem)
                GlobalVariables.card24 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox47, "")
                Me.Label55.Text -= 1
                GlobalVariables.deck24 = ""
                Interaction.MsgBox("Card(4) remvoed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck23 <> "") Then
                PictureBox48.ImageLocation = ""
                GlobalVariables.card23 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox48, "")
                Me.Label55.Text -= 1
                Me.ComboBox7.Items.Remove(Me.ComboBox7.SelectedItem)
                GlobalVariables.deck23 = ""
                Interaction.MsgBox("Card(3) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck22 <> "") Then
                PictureBox49.ImageLocation = ""
                GlobalVariables.card22 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox49, "")
                Me.Label55.Text -= 1
                Me.ComboBox7.Items.Remove(Me.ComboBox7.SelectedItem)
                GlobalVariables.deck22 = ""
                Interaction.MsgBox("Card(2) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck21 <> "") Then
                PictureBox50.ImageLocation = ""
                GlobalVariables.card21 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox50, "")
                Me.Label55.Text -= 1
                Me.ComboBox7.Items.Remove(Me.ComboBox7.SelectedItem)
                GlobalVariables.deck21 = ""
                Interaction.MsgBox("Card(1) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Me.ComboBox7.Text = ""
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        If (Me.ComboBox4.Text.Length > 0) Then
            If (GlobalVariables.grave15 <> "") Then
                PictureBox51.ImageLocation = ""
                Me.ComboBox4.Items.Remove(Me.ComboBox4.SelectedItem)
                GlobalVariables.card10 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox51, "")
                Me.Label54.Text -= 1
                GlobalVariables.grave15 = ""
                Interaction.MsgBox("Card(5) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave14 <> "") Then
                PictureBox52.ImageLocation = ""
                Me.ComboBox4.Items.Remove(Me.ComboBox4.SelectedItem)
                GlobalVariables.card9 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox52, "")
                Me.Label54.Text -= 1
                GlobalVariables.grave14 = ""
                Interaction.MsgBox("Card(4) remvoed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave13 <> "") Then
                PictureBox53.ImageLocation = ""
                GlobalVariables.card8 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox53, "")
                Me.Label54.Text -= 1
                Me.ComboBox4.Items.Remove(Me.ComboBox4.SelectedItem)
                GlobalVariables.grave13 = ""
                Interaction.MsgBox("Card(3) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave12 <> "") Then
                PictureBox54.ImageLocation = ""
                GlobalVariables.card7 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox54, "")
                Me.Label54.Text -= 1
                Me.ComboBox4.Items.Remove(Me.ComboBox4.SelectedItem)
                GlobalVariables.grave12 = ""
                Interaction.MsgBox("Card(2) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave11 <> "") Then
                PictureBox55.ImageLocation = ""
                GlobalVariables.card6 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox55, "")
                Me.Label54.Text -= 1
                Me.ComboBox4.Items.Remove(Me.ComboBox4.SelectedItem)
                GlobalVariables.grave11 = ""
                Interaction.MsgBox("Card(1) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Me.ComboBox4.Text = ""
    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click
        If (Me.ComboBox8.Text.Length > 0) Then
            If (GlobalVariables.grave25 <> "") Then
                PictureBox56.ImageLocation = ""
                GlobalVariables.card30 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox56, "")
                Me.Label55.Text -= 1
                Me.ComboBox8.Items.Remove(Me.ComboBox8.SelectedItem)
                GlobalVariables.grave25 = ""
                Interaction.MsgBox("Card(5) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave24 <> "") Then
                PictureBox57.ImageLocation = ""
                GlobalVariables.card29 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox57, "")
                Me.Label55.Text -= 1
                Me.ComboBox8.Items.Remove(Me.ComboBox8.SelectedItem)
                GlobalVariables.grave24 = ""
                Interaction.MsgBox("Card(4) remvoed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave23 <> "") Then
                PictureBox58.ImageLocation = ""
                GlobalVariables.card28 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox58, "")
                Me.Label55.Text -= 1
                Me.ComboBox8.Items.Remove(Me.ComboBox8.SelectedItem)
                GlobalVariables.grave23 = ""
                Interaction.MsgBox("Card(3) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave22 <> "") Then
                PictureBox59.ImageLocation = ""
                GlobalVariables.card27 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox59, "")
                Me.Label55.Text -= 1
                Me.ComboBox8.Items.Remove(Me.ComboBox8.SelectedItem)
                GlobalVariables.grave22 = ""
                Interaction.MsgBox("Card(2) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave21 <> "") Then
                PictureBox60.ImageLocation = ""
                GlobalVariables.card26 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox60, "")
                Me.Label55.Text -= 1
                Me.ComboBox8.Items.Remove(Me.ComboBox8.SelectedItem)
                GlobalVariables.grave21 = ""
                Interaction.MsgBox("Card(1) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Me.ComboBox8.Text = ""
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        If (Me.ComboBox5.Text.Length > 0) Then
            If (GlobalVariables.removed15 <> "") Then
                PictureBox61.ImageLocation = ""
                GlobalVariables.card15 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox61, "")
                Me.Label54.Text -= 1
                Me.ComboBox5.Items.Remove(Me.ComboBox5.SelectedItem)
                GlobalVariables.removed15 = ""
                Interaction.MsgBox("Card(5) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed14 <> "") Then
                PictureBox62.ImageLocation = ""
                GlobalVariables.card14 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox62, "")
                Me.Label54.Text -= 1
                Me.ComboBox5.Items.Remove(Me.ComboBox5.SelectedItem)
                GlobalVariables.removed14 = ""
                Interaction.MsgBox("Card(4) remvoed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed13 <> "") Then
                PictureBox63.ImageLocation = ""
                GlobalVariables.card13 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox63, "")
                Me.Label54.Text -= 1
                Me.ComboBox5.Items.Remove(Me.ComboBox5.SelectedItem)
                GlobalVariables.removed13 = ""
                Interaction.MsgBox("Card(3) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed12 <> "") Then
                PictureBox64.ImageLocation = ""
                GlobalVariables.card12 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox64, "")
                Me.Label54.Text -= 1
                Me.ComboBox5.Items.Remove(Me.ComboBox5.SelectedItem)
                GlobalVariables.removed12 = ""
                Interaction.MsgBox("Card(2) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed11 <> "") Then
                PictureBox65.ImageLocation = ""
                GlobalVariables.card11 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox65, "")
                Me.Label54.Text -= 1
                Me.ComboBox5.Items.Remove(Me.ComboBox5.SelectedItem)
                GlobalVariables.removed11 = ""
                Interaction.MsgBox("Card(1) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed your banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Me.ComboBox5.Text = ""
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click
        If (Me.ComboBox9.Text.Length > 0) Then
            If (GlobalVariables.removed25 <> "") Then
                PictureBox66.ImageLocation = ""
                GlobalVariables.card35 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox66, "")
                Me.Label55.Text -= 1
                Me.ComboBox9.Items.Remove(Me.ComboBox9.SelectedItem)
                GlobalVariables.removed25 = ""
                Interaction.MsgBox("Card(5) removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed24 <> "") Then
                PictureBox67.ImageLocation = ""
                GlobalVariables.card34 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox67, "")
                Me.Label55.Text -= 1
                Me.ComboBox9.Items.Remove(Me.ComboBox9.SelectedItem)
                GlobalVariables.removed24 = ""

                Interaction.MsgBox("Card(4) remvoed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed23 <> "") Then
                PictureBox68.ImageLocation = ""
                Me.ComboBox9.Items.Remove(Me.ComboBox9.SelectedItem)
                GlobalVariables.removed23 = ""
                GlobalVariables.card33 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox68, "")
                Me.Label55.Text -= 1
                Interaction.MsgBox("Card(3) removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed22 <> "") Then
                PictureBox69.ImageLocation = ""
                GlobalVariables.card32 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox69, "")
                Me.Label55.Text -= 1
                Me.ComboBox9.Items.Remove(Me.ComboBox9.SelectedItem)
                GlobalVariables.removed22 = ""
                Interaction.MsgBox("Card(2) removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed21 <> "") Then
                PictureBox70.ImageLocation = ""
                GlobalVariables.card31 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox70, "")
                Me.Label55.Text -= 1
                Me.ComboBox9.Items.Remove(Me.ComboBox9.SelectedItem)
                GlobalVariables.removed21 = ""
                Interaction.MsgBox("Card(1) removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Me.ComboBox9.Text = ""
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        If (Me.ComboBox6.Text.Length > 0) Then
            If (GlobalVariables.extra15 <> "") Then
                PictureBox71.ImageLocation = ""
                GlobalVariables.card20 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox71, "")
                Me.Label54.Text -= 1
                Me.ComboBox6.Items.Remove(Me.ComboBox6.SelectedItem)
                GlobalVariables.extra15 = ""
                Interaction.MsgBox("Card(5) removed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra14 <> "") Then
                PictureBox72.ImageLocation = ""
                GlobalVariables.card19 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox72, "")
                Me.Label54.Text -= 1
                Me.ComboBox6.Items.Remove(Me.ComboBox6.SelectedItem)
                GlobalVariables.extra14 = ""
                Interaction.MsgBox("Card(4) remvoed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra13 <> "") Then
                PictureBox73.ImageLocation = ""
                GlobalVariables.card18 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox73, "")
                Me.Label54.Text -= 1
                Me.ComboBox6.Items.Remove(Me.ComboBox6.SelectedItem)
                GlobalVariables.extra13 = ""
                Interaction.MsgBox("Card(3) removed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra12 <> "") Then
                PictureBox74.ImageLocation = ""
                GlobalVariables.card17 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox74, "")
                Me.Label54.Text -= 1
                Me.ComboBox6.Items.Remove(Me.ComboBox6.SelectedItem)
                GlobalVariables.extra12 = ""
                Interaction.MsgBox("Card(2) removed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra11 <> "") Then
                PictureBox75.ImageLocation = ""
                GlobalVariables.card6 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox75, "")
                Me.Label54.Text -= 1
                Me.ComboBox6.Items.Remove(Me.ComboBox6.SelectedItem)
                GlobalVariables.extra11 = ""
                Interaction.MsgBox("Card(1) removed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Me.ComboBox6.Text = ""
    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton18.Click
        If (Me.ComboBox10.Text.Length > 0) Then
            If (GlobalVariables.extra25 <> "") Then
                PictureBox76.ImageLocation = ""
                GlobalVariables.card40 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox76, "")
                Me.Label55.Text -= 1
                Me.ComboBox10.Items.Remove(Me.ComboBox10.SelectedItem)
                GlobalVariables.extra25 = ""
                Interaction.MsgBox("Card(5) removed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra24 <> "") Then
                PictureBox77.ImageLocation = ""
                GlobalVariables.card39 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox77, "")
                Me.Label55.Text -= 1
                Me.ComboBox10.Items.Remove(Me.ComboBox10.SelectedItem)
                GlobalVariables.extra24 = ""
                Interaction.MsgBox("Card(4) remvoed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra23 <> "") Then
                PictureBox78.ImageLocation = ""
                GlobalVariables.card38 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox78, "")
                Me.Label55.Text -= 1
                Me.ComboBox10.Items.Remove(Me.ComboBox10.SelectedItem)
                GlobalVariables.extra23 = ""
                Interaction.MsgBox("Card(3) removed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra22 <> "") Then
                PictureBox79.ImageLocation = ""
                GlobalVariables.card37 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox79, "")
                Me.Label55.Text -= 1
                Me.ComboBox10.Items.Remove(Me.ComboBox10.SelectedItem)
                GlobalVariables.extra22 = ""
                Interaction.MsgBox("Card(2) removed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra25 <> "") Then
                PictureBox80.ImageLocation = ""
                GlobalVariables.card36 = ""
                Me.ToolTip1.SetToolTip(Me.PictureBox80, "")
                Me.Label55.Text -= 1
                Me.ComboBox10.Items.Remove(Me.ComboBox10.SelectedItem)
                GlobalVariables.extra25 = ""
                Interaction.MsgBox("Card(1) removed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Me.ComboBox10.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Me.TextBox2.Text.Length > 0) Then
            If (Me.ComboBox3.MaxDropDownItems > 5) Then
                Interaction.MsgBox("No more items can be added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
            Me.ComboBox3.Items.Add(Me.TextBox2.Text)

        End If
        If ((Me.TextBox2.Text.Length > 0) And (Me.TextBox2.Text.Length > 0)) Then
            Me.TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (Me.TextBox3.Text.Length > 0) Then
            If (Me.ComboBox4.MaxDropDownItems > 5) Then
                Interaction.MsgBox("No more items can be added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
            Me.ComboBox4.Items.Add(Me.TextBox3.Text)

        End If
        If ((Me.TextBox3.Text.Length > 0) And (Me.TextBox3.Text.Length > 0)) Then
            Me.TextBox3.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (Me.TextBox4.Text.Length > 0) Then
            If (Me.ComboBox5.MaxDropDownItems > 5) Then
                Interaction.MsgBox("No more items can be added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
            Me.ComboBox5.Items.Add(Me.TextBox4.Text)
        End If
        If ((Me.TextBox4.Text.Length > 0) And (Me.TextBox4.Text.Length > 0)) Then
            Me.TextBox4.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (Me.TextBox5.Text.Length > 0) Then
            If (Me.ComboBox6.MaxDropDownItems > 5) Then
                Interaction.MsgBox("No more items can be added to your extra", MsgBoxStyle.ApplicationModal, Nothing)
            End If
            Me.ComboBox6.Items.Add(Me.TextBox5.Text)
        End If
        If ((Me.TextBox5.Text.Length > 0) And (Me.TextBox5.Text.Length > 0)) Then
            Me.TextBox5.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If (Me.TextBox22.Text.Length > 0) Then
            If (Me.ComboBox7.MaxDropDownItems > 5) Then
                Interaction.MsgBox("No more items can be added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
            Me.ComboBox7.Items.Add(Me.TextBox22.Text)
        End If
        If ((Me.TextBox22.Text.Length > 0) And (Me.TextBox22.Text.Length > 0)) Then
            Me.TextBox22.Text = ""
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If (Me.TextBox23.Text.Length > 0) Then
            If (Me.ComboBox8.MaxDropDownItems > 5) Then
                Interaction.MsgBox("No more items can be added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
            Me.ComboBox8.Items.Add(Me.TextBox23.Text)
        End If
        If ((Me.TextBox23.Text.Length > 0) And (Me.TextBox23.Text.Length > 0)) Then
            Me.TextBox23.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If (Me.TextBox24.Text.Length > 0) Then
            If (Me.ComboBox9.MaxDropDownItems > 5) Then
                Interaction.MsgBox("No more items can be added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
            Me.ComboBox9.Items.Add(Me.TextBox24.Text)
        End If
        If ((Me.TextBox24.Text.Length > 0) And (Me.TextBox24.Text.Length > 0)) Then
            Me.TextBox24.Text = ""
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If (Me.TextBox25.Text.Length > 0) Then
            If (Me.ComboBox10.MaxDropDownItems > 5) Then
                Interaction.MsgBox("No more items can be added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
            Me.ComboBox10.Items.Add(Me.TextBox25.Text)
        End If
        If ((Me.TextBox25.Text.Length > 0) And (Me.TextBox25.Text.Length > 0)) Then
            Me.TextBox25.Text = ""
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.OpenFileDialog1.ShowDialog()
        Me.TextBox1.Text = Me.OpenFileDialog1.FileName
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            OpenFileDialog1.Filter = "Lua Files (*.lua)|*.lua|All Files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1

            If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                Dim file As New System.IO.StreamReader(OpenFileDialog1.FileName)
                TextBox1.Text = OpenFileDialog1.FileName
                RichTextBox1.Text = file.ReadToEnd
                file.Close()

                Interaction.MsgBox("File loaded", MsgBoxStyle.ApplicationModal, Nothing)
            End If

        Catch ex As Exception
            Interaction.MsgBox("File cannot be loaded", MsgBoxStyle.ApplicationModal, Nothing)
        End Try

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.SaveFileDialog1.ShowDialog()
        Me.TextBox1.Text = SaveFileDialog1.FileName


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            SaveFileDialog1.Filter = "Lua Files (*.lua)|*.lua|All Files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            If (Me.SaveFileDialog1.ShowDialog = DialogResult.OK) Then
                Dim sw As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                sw.Write(RichTextBox1.Text)
                sw.Close()

                Interaction.MsgBox("File saved", MsgBoxStyle.ApplicationModal, Nothing)
            End If

        Catch ex As Exception
            Interaction.MsgBox("File cannot be saved", MsgBoxStyle.ApplicationModal, Nothing)
        End Try
    End Sub

    Private Sub CardsDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardsDatabaseToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub DeckGeneratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeckGeneratorToolStripMenuItem.Click
        Form4.Show()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Form3.Show()

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub PuzzleGeneratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuzzleGeneratorToolStripMenuItem.Click
        MsgBox("Unavaliable at this time")
    End Sub

    Private Sub AIEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AIEditorToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub WebpageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebpageToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.ygoproleague.net78.net/")
    End Sub

    Private Sub ForumsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForumsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://ygoproleague.foro.bz/")
    End Sub

    Private Sub TutorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutorialToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://challonge.com/ygoproleague")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            SaveFileDialog1.Filter = "Lua Files (*.lua)|*.lua|All Files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            Me.SaveFileDialog1.ShowDialog()
            My.Computer.FileSystem.CopyFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\New.lua"), Me.SaveFileDialog1.FileName, True)
            MsgBox("File has been succesfully saved")
        Catch ex As Exception
            MsgBox("File has not been saved")
        End Try

    End Sub

    

    Private Sub TabPageScript_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPageScript.Enter
        Try

            Me.RichTextBox1.LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\New.lua", RichTextBoxStreamType.PlainText)
            TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\New.lua"
            Interaction.MsgBox("Current File loaded", MsgBoxStyle.ApplicationModal, Nothing)

            
        Catch ex As Exception
            Interaction.MsgBox("No file has been created", MsgBoxStyle.ApplicationModal, Nothing)
        End Try
        
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        If TextBox16.Text <> "" Then
            TextBox16.Text = ""
        End If
        If TextBox15.Text <> "" Then
            TextBox15.Text = ""
        End If
        If TextBox14.Text <> "" Then
            TextBox14.Text = ""
        End If
        If TextBox13.Text <> "" Then
            TextBox13.Text = ""
        End If
        If TextBox19.Text <> "" Then
            TextBox19.Text = ""
        End If
        If TextBox17.Text <> "" Then
            TextBox17.Text = ""
        End If
        If TextBox18.Text <> "" Then
            TextBox18.Text = ""
        End If
        If TextBox9.Text <> "" Then
            TextBox9.Text = ""
        End If
        If TextBox8.Text <> "" Then
            TextBox8.Text = ""
        End If
        If TextBox11.Text <> "" Then
            TextBox11.Text = ""
        End If
        If TextBox7.Text <> "" Then
            TextBox7.Text = ""
        End If
        If TextBox6.Text <> "" Then
            TextBox6.Text = ""
        End If
        If TextBox27.Text <> "" Then
            TextBox27.Text = ""
        End If
        If TextBox28.Text <> "" Then
            TextBox28.Text = ""
        End If
        If TextBox29.Text <> "" Then
            TextBox29.Text = ""
        End If
        If TextBox30.Text <> "" Then
            TextBox30.Text = ""
        End If
        If TextBox31.Text <> "" Then
            TextBox31.Text = ""
        End If
        If TextBox32.Text <> "" Then
            TextBox32.Text = ""
        End If
        If TextBox33.Text <> "" Then
            TextBox33.Text = ""
        End If
        If TextBox34.Text <> "" Then
            TextBox34.Text = ""
        End If
        If TextBox35.Text <> "" Then
            TextBox35.Text = ""
        End If
        If TextBox36.Text <> "" Then
            TextBox36.Text = ""
        End If
        If TextBox37.Text <> "" Then
            TextBox37.Text = ""
        End If
        If TextBox38.Text <> "" Then
            TextBox38.Text = ""
        End If
        If TextBox39.Text <> "" Then
            TextBox39.Text = ""
        End If
        If TextBox40.Text <> "" Then
            TextBox40.Text = ""
        End If
        If TextBox41.Text <> "" Then
            TextBox41.Text = ""
        End If

    End Sub

    Private Sub Monster1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster1ToolStripMenuItem.Click
        If Me.TextBox21.Text = "" Then
            Try

                Me.PictureBox1.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox21.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox1, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(1) currently have a card reference")
        End If
    End Sub

    Private Sub Monster2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster2ToolStripMenuItem.Click
        If Me.TextBox20.Text = "" Then
            Try

                Me.PictureBox2.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox20.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox2, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(2) currently have a card reference")
        End If
    End Sub

    Private Sub Monster3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster3ToolStripMenuItem.Click
        If Me.TextBox19.Text = "" Then
            Try

                Me.PictureBox3.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox19.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox3, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub Monster4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster4ToolStripMenuItem.Click
        If Me.TextBox18.Text = "" Then
            Try

                Me.PictureBox4.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox18.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox4, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(4) currently have a card reference")
        End If
    End Sub

    Private Sub Monster5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster5ToolStripMenuItem.Click
        If Me.TextBox17.Text = "" Then
            Try

                Me.PictureBox5.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox17.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox5, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub Spell1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell1ToolStripMenuItem.Click
        If Me.TextBox16.Text = "" Then
            Try

                Me.PictureBox6.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox16.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox6, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(0) currently have a card reference")
        End If
    End Sub

    Private Sub Spell2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell2ToolStripMenuItem.Click
        If Me.TextBox15.Text = "" Then
            Try

                Me.PictureBox7.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox15.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox7, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(1) currently have a card reference")
        End If
    End Sub

    Private Sub Spell3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell3ToolStripMenuItem.Click
        If Me.TextBox14.Text = "" Then
            Try

                Me.PictureBox8.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox14.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox8, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(2) currently have a card reference")
        End If
    End Sub

    Private Sub Spell4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell4ToolStripMenuItem.Click
        If Me.TextBox13.Text = "" Then
            Try

                Me.PictureBox9.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox13.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox9, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub Spell5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell5ToolStripMenuItem.Click
        If Me.TextBox12.Text = "" Then
            Try

                Me.PictureBox10.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox12.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox10, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub FieldSpellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldSpellToolStripMenuItem.Click
        If Me.TextBox6.Text = "" Then
            Try

                Me.PictureBox15.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox6.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox15, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub Monster1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster1ToolStripMenuItem1.Click
        If Me.TextBox32.Text = "" Then
            Try
                Me.PictureBox21.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox32.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox21, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(1) currently have a card reference")
        End If
    End Sub

    Private Sub Monster2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster2ToolStripMenuItem1.Click
        If Me.TextBox33.Text = "" Then
            Try
                Me.PictureBox20.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox33.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox20, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(2) currently have a card reference")
        End If
    End Sub

    Private Sub Monster3ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster3ToolStripMenuItem1.Click
        If Me.TextBox34.Text = "" Then
            Try
                Me.PictureBox19.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox34.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox19, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub Monster4ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster4ToolStripMenuItem1.Click
        If Me.TextBox35.Text = "" Then
            Try
                Me.PictureBox18.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox35.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox18, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(4) currently have a card reference")
        End If
    End Sub

    Private Sub Monster5ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster5ToolStripMenuItem1.Click
        If Me.TextBox36.Text = "" Then
            Try
                Me.PictureBox17.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox36.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox17, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub Spell1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell1ToolStripMenuItem1.Click
        If Me.TextBox37.Text = "" Then
            Try
                Me.PictureBox26.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox37.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox26, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(1) currently have a card reference")
        End If
    End Sub

    Private Sub Spell2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell2ToolStripMenuItem1.Click
        If Me.TextBox38.Text = "" Then
            Try
                Me.PictureBox27.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox38.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox27, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(2) currently have a card reference")
        End If
    End Sub

    Private Sub Spell3ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell3ToolStripMenuItem1.Click
        If Me.TextBox39.Text = "" Then
            Try
                Me.PictureBox28.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox39.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox28, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub Spell4ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell4ToolStripMenuItem1.Click
        If Me.TextBox40.Text = "" Then
            Try
                Me.PictureBox29.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox40.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox29, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(4) currently have a card reference")
        End If
    End Sub

    Private Sub Spell5ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell5ToolStripMenuItem1.Click
        If Me.TextBox41.Text = "" Then
            Try
                Me.PictureBox30.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox41.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox30, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub FieldSpellToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldSpellToolStripMenuItem1.Click
        If Me.TextBox26.Text = "" Then
            Try
                Me.PictureBox16.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox26.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox16, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand1ToolStripMenuItem.Click
        If Me.TextBox11.Text = "" Then
            Try
                Me.PictureBox31.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox11.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox31, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(1) currently have a card reference")
        End If
    End Sub

    Private Sub Hand2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand2ToolStripMenuItem.Click
        If Me.TextBox10.Text = "" Then
            Try
                Me.PictureBox32.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox10.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox32, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(2) currently have a card reference")
        End If
    End Sub

    Private Sub Hand3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand3ToolStripMenuItem.Click
        If Me.TextBox9.Text = "" Then
            Try
                Me.PictureBox33.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox9.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox33, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(3) currently have a card reference")
        End If
    End Sub

    Private Sub Hand4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand4ToolStripMenuItem.Click
        If Me.TextBox8.Text = "" Then
            Try
                Me.PictureBox34.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox8.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox34, Form2.NameTextBox.Text)
                Me.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(4) currently have a card reference")
        End If
    End Sub

    Private Sub Hand5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand5ToolStripMenuItem.Click
        If Me.TextBox7.Text = "" Then
            Try
                Me.PictureBox35.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox7.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox35, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(5) currently have a card reference")
        End If
    End Sub

    Private Sub Hand1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand1ToolStripMenuItem1.Click
        If Me.TextBox27.Text = "" Then
            Try
                Me.PictureBox40.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox27.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox40, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(1) currently have a card reference")
        End If
    End Sub

    Private Sub Hand2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand2ToolStripMenuItem1.Click
        If Me.TextBox28.Text = "" Then
            Try
                Me.PictureBox39.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox28.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox39, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(2) currently have a card reference")
        End If
    End Sub

    Private Sub Hand3ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand3ToolStripMenuItem1.Click
        If Me.TextBox29.Text = "" Then
            Try
                Me.PictureBox38.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox29.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox38, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(3) currently have a card reference")
        End If
    End Sub

    Private Sub Hand4ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand4ToolStripMenuItem1.Click
        If Me.TextBox30.Text = "" Then
            Try
                Me.PictureBox37.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox30.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox37, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(4) currently have a card reference")
        End If
    End Sub

    Private Sub Hand5ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand5ToolStripMenuItem1.Click
        If Me.TextBox31.Text = "" Then
            Try
                Me.PictureBox36.ImageLocation = Me.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.TextBox31.Text & ".jpg"
                Me.ToolTip1.SetToolTip(Me.PictureBox36, Form2.NameTextBox.Text)
                Me.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(5) currently have a card reference")
        End If
    End Sub

    Private Sub MonstersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonstersToolStripMenuItem.Click
        If (Form2.IdTextBox1.Text > 0) Then
            If (Me.TextBox17.Text <> "") Then
                Me.PictureBox5.ImageLocation = ""
                Me.TextBox17.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox5, "")
                Interaction.MsgBox("Card(5) removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox18.Text <> "") Then
                Me.PictureBox4.ImageLocation = ""
                Me.TextBox18.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox4, "")
                Interaction.MsgBox("Card(4) remvoed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox19.Text <> "") Then
                Me.PictureBox3.ImageLocation = ""
                Me.TextBox19.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox3, "")
                Interaction.MsgBox("Card(3) removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox20.Text <> "") Then
                Me.PictureBox2.ImageLocation = ""
                Me.TextBox20.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox2, "")
                Interaction.MsgBox("Card(2) removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox21.Text <> "") Then
                Me.PictureBox1.ImageLocation = ""
                Me.TextBox21.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox1, "")
                Interaction.MsgBox("Card(1) removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub SpellsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellsToolStripMenuItem1.Click
        If (Form2.IdTextBox1.Text > 0) Then
            If (Me.TextBox12.Text <> "") Then
                Me.PictureBox10.ImageLocation = ""
                Me.TextBox12.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox10, "")
                Interaction.MsgBox("Card(5) removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox13.Text <> "") Then
                Me.PictureBox9.ImageLocation = ""
                Me.TextBox13.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox9, "")
                Interaction.MsgBox("Card(4) remvoed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox14.Text <> "") Then
                Me.PictureBox8.ImageLocation = ""
                Me.TextBox14.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox8, "")
                Interaction.MsgBox("Card(3) removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox15.Text <> "") Then
                Me.PictureBox7.ImageLocation = ""
                Me.TextBox15.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox7, "")
                Interaction.MsgBox("Card(2) removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox16.Text <> "") Then
                Me.PictureBox6.ImageLocation = ""
                Me.TextBox16.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox6, "")
                Interaction.MsgBox("Card(1) removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub MonstersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonstersToolStripMenuItem1.Click
        If (Form2.IdTextBox1.Text > 0) Then
            If (Me.TextBox36.Text <> "") Then
                Me.PictureBox17.ImageLocation = ""
                Me.TextBox36.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox17, "")
                Interaction.MsgBox("Card(5) removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox35.Text <> "") Then
                Me.PictureBox18.ImageLocation = ""
                Me.TextBox35.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox18, "")
                Interaction.MsgBox("Card(4) remvoed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox34.Text <> "") Then
                Me.PictureBox19.ImageLocation = ""
                Me.TextBox34.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox19, "")
                Interaction.MsgBox("Card(3) removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox33.Text <> "") Then
                Me.PictureBox20.ImageLocation = ""
                Me.TextBox33.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox20, "")
                Interaction.MsgBox("Card(2) removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox32.Text <> "") Then
                Me.PictureBox21.ImageLocation = ""
                Me.TextBox32.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox21, "")
                Interaction.MsgBox("Card(1) removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub SpellsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellsToolStripMenuItem.Click
        If (Form2.IdTextBox1.Text > 0) Then
            If (Me.TextBox41.Text <> "") Then
                Me.PictureBox30.ImageLocation = ""
                Me.TextBox41.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox30, "")
                Interaction.MsgBox("Card(5) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox40.Text <> "") Then
                Me.PictureBox29.ImageLocation = ""
                Me.TextBox40.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox29, "")
                Interaction.MsgBox("Card(4) remvoed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox39.Text <> "") Then
                Me.PictureBox28.ImageLocation = ""
                Me.TextBox39.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox28, "")
                Interaction.MsgBox("Card(3) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox38.Text <> "") Then
                Me.PictureBox27.ImageLocation = ""
                Me.TextBox38.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox27, "")
                Interaction.MsgBox("Card(2) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox37.Text <> "") Then
                Me.PictureBox26.ImageLocation = ""
                Me.TextBox37.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox26, "")
                Interaction.MsgBox("Card(1) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub FieldToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldToolStripMenuItem1.Click
        If (Me.TextBox6.Text <> "") Then
            Me.PictureBox15.ImageLocation = ""
            Me.TextBox6.Text = ""
            Me.Label54.Text -= 1
            Me.ToolTip1.SetToolTip(Me.PictureBox15, "")
            Interaction.MsgBox("Card(5) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
        End If
    End Sub

    Private Sub FieldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldToolStripMenuItem.Click
        If (Me.TextBox26.Text <> "") Then
            Me.PictureBox16.ImageLocation = ""
            Me.TextBox26.Text = ""
            Me.Label55.Text -= 1
            Me.ToolTip1.SetToolTip(Me.PictureBox16, "")
            Interaction.MsgBox("Card(5) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
        End If
    End Sub

    Private Sub HandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HandToolStripMenuItem.Click
        If (Form2.IdTextBox1.Text > 0) Then
            If (Me.TextBox7.Text <> "") Then
                Me.PictureBox35.ImageLocation = ""
                Me.TextBox7.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox35, "")
                Interaction.MsgBox("Card(5) removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox8.Text <> "") Then
                Me.PictureBox34.ImageLocation = ""
                Me.TextBox8.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox34, "")
                Interaction.MsgBox("Card(4) remvoed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox9.Text <> "") Then
                Me.PictureBox33.ImageLocation = ""
                Me.TextBox9.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox33, "")
                Interaction.MsgBox("Card(3) removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox10.Text <> "") Then
                Me.PictureBox32.ImageLocation = ""
                Me.TextBox10.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox32, "")
                Interaction.MsgBox("Card(2) removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox11.Text <> "") Then
                Me.PictureBox31.ImageLocation = ""
                Me.TextBox11.Text = ""
                Me.Label54.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox31, "")
                Interaction.MsgBox("Card(1) removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub HandToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HandToolStripMenuItem1.Click
        If (Form2.IdTextBox1.Text > 0) Then
            If (Me.TextBox31.Text <> "") Then
                Me.PictureBox36.ImageLocation = ""
                Me.TextBox31.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox36, "")
                Interaction.MsgBox("Card(5) removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox30.Text <> "") Then
                Me.PictureBox37.ImageLocation = ""
                Me.TextBox30.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox37, "")
                Interaction.MsgBox("Card(4) remvoed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox29.Text <> "") Then
                Me.PictureBox38.ImageLocation = ""
                Me.TextBox29.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox38, "")
                Interaction.MsgBox("Card(3) removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox28.Text <> "") Then
                Me.PictureBox39.ImageLocation = ""
                Me.TextBox28.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox39, "")
                Interaction.MsgBox("Card(2) removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Me.TextBox27.Text <> "") Then
                Me.PictureBox40.ImageLocation = ""
                Me.TextBox27.Text = ""
                Me.Label55.Text -= 1
                Me.ToolTip1.SetToolTip(Me.PictureBox40, "")
                Interaction.MsgBox("Card(1) removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub
End Class
