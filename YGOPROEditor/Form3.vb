Imports System
Imports System.Reflection
Imports System.Data.SQLite
Imports System.IO



Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CardsDataSet2.texts' table. You can move, or remove it, as needed.
        Me.TextsTableAdapter.Fill(Me.CardsDataSet2.texts)
        'TODO: This line of code loads data into the 'CardsDataSet.textos' table. You can move, or remove it, as needed.

       

    End Sub



    Private Sub TextsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TextsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CardsDataSet2)

    End Sub


    Private Sub Monster1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster1ToolStripMenuItem.Click
        If Form1.TextBox21.Text = "" Then
            Try
                Form1.TextBox21.Text = Me.IdTextBox1.Text
                Form1.PictureBox1.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox21.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox1, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(1) currently have a card reference")
        End If

    End Sub

    Private Sub Monster2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster2ToolStripMenuItem.Click
        If Form1.TextBox20.Text = "" Then
            Try

                Form1.TextBox20.Text = Me.IdTextBox1.Text
                Form1.ToolTip1.SetToolTip(Form1.PictureBox2, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
                Form1.PictureBox2.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox20.Text & ".jpg"
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(2) currently have a card reference")
        End If
    End Sub

    Private Sub Monster3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster3ToolStripMenuItem.Click
        If Form1.TextBox19.Text = "" Then
            Try
                Form1.TextBox19.Text = Me.IdTextBox1.Text
                Form1.PictureBox3.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox19.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox3, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub Monster4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster4ToolStripMenuItem.Click
        If Form1.TextBox18.Text = "" Then
            Try
                Form1.TextBox18.Text = Me.IdTextBox1.Text
                Form1.PictureBox4.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox18.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox4, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(4) currently have a card reference")
        End If
    End Sub

    Private Sub Monster5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster5ToolStripMenuItem.Click
        If Form1.TextBox17.Text = "" Then
            Try
                Form1.TextBox17.Text = Me.IdTextBox1.Text
                Form1.PictureBox5.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox17.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox5, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub Spell1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell1ToolStripMenuItem.Click
        If Form1.TextBox16.Text = "" Then
            Try
                Form1.TextBox16.Text = Me.IdTextBox1.Text
                Form1.ToolTip1.SetToolTip(Form1.PictureBox6, Me.NameTextBox.Text)
                Form1.PictureBox6.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox16.Text & ".jpg"
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(0) currently have a card reference")
        End If
    End Sub

    Private Sub Spell2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell2ToolStripMenuItem.Click
        If Form1.TextBox15.Text = "" Then
            Try
                Form1.TextBox15.Text = Me.IdTextBox1.Text
                Form1.ToolTip1.SetToolTip(Form1.PictureBox7, Me.NameTextBox.Text)
                Form1.PictureBox7.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox15.Text & ".jpg"
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(1) currently have a card reference")
        End If
    End Sub

    Private Sub Spell3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell3ToolStripMenuItem.Click
        If Form1.TextBox14.Text = "" Then
            Try
                Form1.TextBox14.Text = Me.IdTextBox1.Text
                Form1.PictureBox8.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox14.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox8, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(2) currently have a card reference")
        End If
    End Sub

    Private Sub Spell4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell4ToolStripMenuItem.Click
        If Form1.TextBox13.Text = "" Then
            Try
                Form1.TextBox13.Text = Me.IdTextBox1.Text
                Form1.PictureBox9.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox13.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox9, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub Spell5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell5ToolStripMenuItem.Click
        If Form1.TextBox12.Text = "" Then
            Try
                Form1.TextBox12.Text = Me.IdTextBox1.Text
                Form1.PictureBox10.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox12.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox10, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(4) currently have a card reference")
        End If
    End Sub

    Private Sub FieldSpellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldSpellToolStripMenuItem.Click
        If Form1.TextBox6.Text = "" Then
            Try
                Form1.TextBox6.Text = Me.IdTextBox1.Text
                Form1.ToolTip1.SetToolTip(Form1.PictureBox15, Me.NameTextBox.Text)
                Form1.PictureBox15.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox6.Text & ".jpg"
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field Spell zone currently have a card reference")
        End If
    End Sub

    Private Sub DeckZoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeckZoneToolStripMenuItem.Click
        If (Me.IdTextBox1.Text <> "") Then
            If (GlobalVariables.deck11 = "") Then
                Form1.ComboBox3.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox45.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox45, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
                GlobalVariables.card1 = Me.IdTextBox1.Text
                GlobalVariables.deck11 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck1p
                Interaction.MsgBox("Card(1) added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck12 = "") Then
                Form1.ComboBox3.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox44.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox44, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
                GlobalVariables.card2 = Me.IdTextBox1.Text
                GlobalVariables.deck12 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck1p
                Interaction.MsgBox("Card(2) added to yout deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck13 = "") Then
                Form1.ComboBox3.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox43.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox43, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
                GlobalVariables.card3 = Me.IdTextBox1.Text
                GlobalVariables.deck13 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck1p
                Interaction.MsgBox("Card(3) added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck14 = "") Then
                Form1.PictureBox42.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox42, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
                Form1.ComboBox3.Items.Add(Me.IdTextBox1.Text)
                GlobalVariables.card4 = Me.IdTextBox1.Text
                GlobalVariables.deck14 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck1p
                Interaction.MsgBox("Card(4) added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck15 = "") Then
                Form1.PictureBox41.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox41, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
                GlobalVariables.card5 = Me.IdTextBox1.Text
                Form1.ComboBox3.Items.Add(Me.IdTextBox1.Text)
                GlobalVariables.deck15 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck1p
                Interaction.MsgBox("Card(5) added to your your deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If

    End Sub

    Private Sub GraveyardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraveyardToolStripMenuItem.Click
        If (Me.IdTextBox1.Text <> "") Then
            If (GlobalVariables.grave11 = "") Then
                GlobalVariables.card6 = Me.IdTextBox1.Text
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox55.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox55, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
                GlobalVariables.grave11 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.gravept
                Interaction.MsgBox("Card(1) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave12 = "") Then
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox54.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox54, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
                GlobalVariables.card7 = Me.IdTextBox1.Text
                GlobalVariables.grave12 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.gravept
                Interaction.MsgBox("Card(2) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave13 = "") Then
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox53.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox53, Me.NameTextBox.Text)
                GlobalVariables.card8 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.grave13 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.gravept
                Interaction.MsgBox("Card(3) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave14 = "") Then
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox52.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox52, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
                GlobalVariables.card9 = Me.IdTextBox1.Text
                GlobalVariables.grave14 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.gravept
                Interaction.MsgBox("Card(4) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave15 = "") Then
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox51.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox51, Me.NameTextBox.Text)
                GlobalVariables.card10 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.grave15 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.gravept
                Interaction.MsgBox("Card(5) added to your your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub BanishedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanishedToolStripMenuItem.Click
        If (Me.IdTextBox1.Text <> "") Then
            If (GlobalVariables.removed11 = "") Then
                Form1.ComboBox5.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox65.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox65, Me.NameTextBox.Text)
                GlobalVariables.card11 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.removed11 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt
                Interaction.MsgBox("Card(1) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed12 = "") Then
                Form1.ComboBox5.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox64.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox64, Me.NameTextBox.Text)
                GlobalVariables.card12 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.removed12 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt
                Interaction.MsgBox("Card(2) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed13 = "") Then
                Form1.ComboBox5.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox63.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox63, Me.NameTextBox.Text)
                GlobalVariables.card13 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.removed13 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt
                Interaction.MsgBox("Card(3) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed14 = "") Then
                Form1.ComboBox5.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox62.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox62, Me.NameTextBox.Text)
                GlobalVariables.card14 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.removed14 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt
                Interaction.MsgBox("Card(4) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed15 = "") Then
                Form1.ComboBox5.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox61.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox61, Me.NameTextBox.Text)
                GlobalVariables.card15 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.removed15 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt
                Interaction.MsgBox("Card(5) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub ExtraDeckToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraDeckToolStripMenuItem1.Click
        If (Me.IdTextBox1.Text <> "") Then
            If (GlobalVariables.extra11 = "") Then
                Form1.ComboBox6.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox75.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox75, Me.NameTextBox.Text)
                GlobalVariables.card16 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.extra11 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt
                Interaction.MsgBox("Card(1) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra12 = "") Then
                Form1.ComboBox6.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox74.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox74, Me.NameTextBox.Text)
                GlobalVariables.card17 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.extra12 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt
                Interaction.MsgBox("Card(2) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra13 = "") Then
                Form1.ComboBox6.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox73.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox73, Me.NameTextBox.Text)
                GlobalVariables.card18 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.extra13 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt
                Interaction.MsgBox("Card(3) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra14 = "") Then
                Form1.ComboBox6.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox72.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox72, Me.NameTextBox.Text)
                GlobalVariables.card19 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.extra14 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt
                Interaction.MsgBox("Card(4) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra15 = "") Then
                Form1.ComboBox6.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox71.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox71, Me.NameTextBox.Text)
                GlobalVariables.card20 = Me.IdTextBox1.Text
                Form1.Label54.Text += 1
                GlobalVariables.extra15 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt
                Interaction.MsgBox("Card(5) added to your your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        If (Me.IdTextBox1.Text <> "") Then
            If (GlobalVariables.deck21 = "") Then
                Form1.ComboBox7.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox50.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox50, Me.NameTextBox.Text)
                GlobalVariables.card21 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.deck21 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck2p
                Interaction.MsgBox("Card(1) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck22 = "") Then
                Form1.ComboBox7.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox49.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox49, Me.NameTextBox.Text)
                GlobalVariables.card22 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.deck22 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck2p
                Interaction.MsgBox("Card(2) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck23 = "") Then
                Form1.ComboBox7.Items.Add(Me.IdTextBox1.Text)
                Form1.Label55.Text += 1
                Form1.PictureBox48.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox48, Me.NameTextBox.Text)
                GlobalVariables.card23 = Me.IdTextBox1.Text
                GlobalVariables.deck23 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck2p
                Interaction.MsgBox("Card(3) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck24 = "") Then
                Form1.ComboBox7.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox47.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox47, Me.NameTextBox.Text)
                GlobalVariables.card24 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.deck24 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck2p
                Interaction.MsgBox("Card(4) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck25 = "") Then
                Form1.ComboBox7.Items.Add(Me.IdTextBox1.Text)
                Form1.Label55.Text += 1
                Form1.PictureBox46.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox46, Me.NameTextBox.Text)
                GlobalVariables.card25 = Me.IdTextBox1.Text
                GlobalVariables.deck25 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck2p
                Interaction.MsgBox("Card(5) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        If (Me.IdTextBox1.Text <> "") Then
            If (GlobalVariables.grave21 = "") Then
                Form1.ComboBox8.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox60.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox60, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
                GlobalVariables.card26 = Me.IdTextBox1.Text
                GlobalVariables.grave21 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.grave2pt
                Interaction.MsgBox("Card(1) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave22 = "") Then
                Form1.ComboBox8.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox59.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox59, Me.NameTextBox.Text)
                GlobalVariables.card27 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.grave22 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.grave2pt
                Interaction.MsgBox("Card(2) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck23 = "") Then
                Form1.ComboBox8.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox58.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox58, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
                GlobalVariables.card28 = Me.IdTextBox1.Text
                GlobalVariables.grave23 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.grave2pt
                Interaction.MsgBox("Card(3) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave24 = "") Then
                Form1.ComboBox8.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox57.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox57, Me.NameTextBox.Text)
                GlobalVariables.card29 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.grave24 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.grave2pt
                Interaction.MsgBox("Card(4) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave25 = "") Then
                Form1.ComboBox8.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox56.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox56, Me.NameTextBox.Text)
                GlobalVariables.card30 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.grave25 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.grave2pt
                Interaction.MsgBox("Card(5) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        If (Me.IdTextBox1.Text <> "") Then
            If (GlobalVariables.removed21 = "") Then
                Form1.ComboBox9.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox70.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox70, Me.NameTextBox.Text)
                GlobalVariables.card31 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.removed21 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt2
                Interaction.MsgBox("Card(1) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed22 = "") Then
                Form1.ComboBox9.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox69.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox69, Me.NameTextBox.Text)
                GlobalVariables.card32 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.removed22 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt2
                Interaction.MsgBox("Card(2) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed23 = "") Then
                Form1.ComboBox9.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox68.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox68, Me.NameTextBox.Text)
                GlobalVariables.card33 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.removed23 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt2
                Interaction.MsgBox("Card(3) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed24 = "") Then
                Form1.ComboBox9.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox67.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox67, Me.NameTextBox.Text)
                GlobalVariables.card34 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.removed24 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt2
                Interaction.MsgBox("Card(4) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed25 = "") Then
                Form1.ComboBox9.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox66.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox66, Me.NameTextBox.Text)
                GlobalVariables.card35 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.removed25 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt2
                Interaction.MsgBox("Card(5) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        If (Me.IdTextBox1.Text <> "") Then
            If (GlobalVariables.extra21 = "") Then
                Form1.ComboBox10.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox80.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox80, Me.NameTextBox.Text)
                GlobalVariables.card36 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.extra21 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt2
                Interaction.MsgBox("Card(1) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra22 = "") Then
                Form1.ComboBox10.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox79.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox79, Me.NameTextBox.Text)
                GlobalVariables.card37 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.extra22 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt2
                Interaction.MsgBox("Card(2) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra23 = "") Then
                Form1.ComboBox10.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox78.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox78, Me.NameTextBox.Text)
                GlobalVariables.card38 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.extra23 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt2
                Interaction.MsgBox("Card(3) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra24 = "") Then
                Form1.ComboBox10.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox77.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox77, Me.NameTextBox.Text)
                GlobalVariables.card39 = Me.IdTextBox1.Text
                Form1.Label55.Text += 1
                GlobalVariables.extra24 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt2
                Interaction.MsgBox("Card(4) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra25 = "") Then
                Form1.ComboBox10.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox76.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox76, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
                GlobalVariables.card40 = Me.IdTextBox1.Text
                GlobalVariables.extra25 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt2
                Interaction.MsgBox("Card(5) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If Form1.TextBox32.Text = "" Then
            Try
                Form1.TextBox32.Text = Me.IdTextBox1.Text
                Form1.PictureBox21.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox32.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox21, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(1) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If Form1.TextBox33.Text = "" Then
            Try
                Form1.TextBox33.Text = Me.IdTextBox1.Text
                Form1.PictureBox20.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox33.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox20, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(2) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If Form1.TextBox34.Text = "" Then
            Try
                Form1.TextBox34.Text = Me.IdTextBox1.Text
                Form1.PictureBox19.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox34.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox19, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        If Form1.TextBox35.Text = "" Then
            Try
                Form1.TextBox35.Text = Me.IdTextBox1.Text
                Form1.PictureBox18.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox35.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox18, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(4) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        If Form1.TextBox36.Text = "" Then
            Try
                Form1.TextBox36.Text = Me.IdTextBox1.Text
                Form1.PictureBox17.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox36.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox17, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        If Form1.TextBox37.Text = "" Then
            Try
                Form1.TextBox37.Text = Me.IdTextBox1.Text
                Form1.PictureBox26.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox37.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox26, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(1) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        If Form1.TextBox38.Text = "" Then
            Try
                Form1.TextBox38.Text = Me.IdTextBox1.Text
                Form1.PictureBox27.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox38.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox27, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(2) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        If Form1.TextBox39.Text = "" Then
            Try
                Form1.TextBox39.Text = Me.IdTextBox1.Text
                Form1.PictureBox28.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox39.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox28, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        If Form1.TextBox40.Text = "" Then
            Try
                Form1.TextBox40.Text = Me.IdTextBox1.Text
                Form1.PictureBox29.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox40.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox29, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(4) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        If Form1.TextBox41.Text = "" Then
            Try
                Form1.TextBox41.Text = Me.IdTextBox1.Text
                Form1.PictureBox30.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox41.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox30, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        If Form1.TextBox26.Text = "" Then
            Try
                Form1.TextBox26.Text = Me.IdTextBox1.Text
                Form1.PictureBox16.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox26.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox16, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand1ToolStripMenuItem.Click
        If Form1.TextBox11.Text = "" Then
            Try
                Form1.TextBox11.Text = Me.IdTextBox1.Text
                Form1.PictureBox31.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox11.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox31, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(1) currently have a card reference")
        End If
    End Sub

    Private Sub Hand2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand2ToolStripMenuItem.Click
        If Form1.TextBox10.Text = "" Then
            Try
                Form1.TextBox10.Text = Me.IdTextBox1.Text
                Form1.PictureBox32.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox10.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox32, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(2) currently have a card reference")
        End If
    End Sub

    Private Sub Hand3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand3ToolStripMenuItem.Click
        If Form1.TextBox9.Text = "" Then
            Try
                Form1.TextBox9.Text = Me.IdTextBox1.Text
                Form1.PictureBox33.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox9.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox33, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(3) currently have a card reference")
        End If
    End Sub

    Private Sub Hand4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand4ToolStripMenuItem.Click
        If Form1.TextBox8.Text = "" Then
            Try
                Form1.TextBox8.Text = Me.IdTextBox1.Text
                Form1.PictureBox34.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox8.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox34, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(4) currently have a card reference")
        End If
    End Sub

    Private Sub Hand5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand5ToolStripMenuItem.Click
        If Form1.TextBox7.Text = "" Then
            Try
                Form1.TextBox7.Text = Me.IdTextBox1.Text
                Form1.PictureBox35.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox7.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox35, Me.NameTextBox.Text)
                Form1.Label54.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand(5) currently have a card reference")
        End If
    End Sub

    Private Sub Hand1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand1ToolStripMenuItem1.Click
        If Form1.TextBox27.Text = "" Then
            Try
                Form1.TextBox27.Text = Me.IdTextBox1.Text
                Form1.PictureBox40.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox27.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox40, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(1) currently have a card reference")
        End If
    End Sub

    Private Sub Hand2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand2ToolStripMenuItem1.Click
        If Form1.TextBox28.Text = "" Then
            Try
                Form1.TextBox28.Text = Me.IdTextBox1.Text
                Form1.PictureBox39.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox28.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox39, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(2) currently have a card reference")
        End If
    End Sub

    Private Sub Hand3ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand3ToolStripMenuItem1.Click
        If Form1.TextBox29.Text = "" Then
            Try
                Form1.TextBox29.Text = Me.IdTextBox1.Text
                Form1.PictureBox38.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox29.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox38, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(3) currently have a card reference")
        End If
    End Sub

    Private Sub Hand4ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand4ToolStripMenuItem1.Click
        If Form1.TextBox30.Text = "" Then
            Try
                Form1.TextBox30.Text = Me.IdTextBox1.Text
                Form1.PictureBox37.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox30.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox37, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(4) currently have a card reference")
        End If
    End Sub

    Private Sub Hand5ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand5ToolStripMenuItem1.Click
        If Form1.TextBox31.Text = "" Then
            Try
                Form1.TextBox31.Text = Me.IdTextBox1.Text
                Form1.PictureBox36.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Form1.TextBox31.Text & ".jpg"
                Form1.ToolTip1.SetToolTip(Form1.PictureBox36, Me.NameTextBox.Text)
                Form1.Label55.Text += 1
            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Hand2(5) currently have a card reference")
        End If
    End Sub

    Private Sub MainDeckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainDeckToolStripMenuItem.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (GlobalVariables.deck15 <> "") Then
                Form1.PictureBox41.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(5))
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox41, "")
                GlobalVariables.deck15 = ""
                GlobalVariables.card5 = ""
                
                Interaction.MsgBox("Card(5) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck14 <> "") Then
                Form1.PictureBox42.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(4))
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox42, "")
                GlobalVariables.deck14 = ""
                GlobalVariables.card4 = ""
                Interaction.MsgBox("Card(4) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck13 <> "") Then
                Form1.PictureBox43.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(3))
                GlobalVariables.deck13 = ""
                GlobalVariables.card3 = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox43, "")
                Interaction.MsgBox("Card(3) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck12 <> "") Then
                Form1.PictureBox44.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(2))
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox44, "")
                GlobalVariables.deck12 = ""
                GlobalVariables.card2 = ""
                Interaction.MsgBox("Card(2) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck11 <> "") Then
                Form1.PictureBox45.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(1))
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox45, "")
                GlobalVariables.deck11 = ""
                GlobalVariables.card1 = ""
                Interaction.MsgBox("Card(1) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Form1.ComboBox3.Text = ""
    End Sub

    Private Sub GraveyardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraveyardToolStripMenuItem1.Click
        If (Form1.ComboBox4.Text.Length > 0) Then
            If (GlobalVariables.grave15 <> "") Then
                Form1.PictureBox51.ImageLocation = ""
                Form1.ComboBox4.Items.Remove(Form1.ComboBox4.Items.IndexOf(5))
                GlobalVariables.grave15 = ""
                GlobalVariables.card10 = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox51, "")
                Interaction.MsgBox("Card(5) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave14 <> "") Then
                Form1.PictureBox52.ImageLocation = ""
                Form1.ComboBox4.Items.Remove(Form1.ComboBox4.Items.IndexOf(5))
                GlobalVariables.grave14 = ""
                GlobalVariables.card9 = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox52, "")
                Interaction.MsgBox("Card(4) remvoed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave13 <> "") Then
                Form1.PictureBox53.ImageLocation = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox53, "")
                Form1.ComboBox4.Items.Remove(Form1.ComboBox4.Items.IndexOf(3))
                GlobalVariables.grave13 = ""
                GlobalVariables.card8 = ""
                Interaction.MsgBox("Card(3) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave12 <> "") Then
                Form1.PictureBox54.ImageLocation = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox54, "")
                Form1.ComboBox4.Items.Remove(Form1.ComboBox4.Items.IndexOf(2))
                GlobalVariables.grave12 = ""
                GlobalVariables.card7 = ""
                Interaction.MsgBox("Card(2) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave11 <> "") Then
                Form1.PictureBox55.ImageLocation = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox55, "")
                Form1.ComboBox4.Items.Remove(Form1.ComboBox4.Items.IndexOf(1))
                GlobalVariables.grave11 = ""
                GlobalVariables.card6 = ""
                Interaction.MsgBox("Card(1) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Form1.ComboBox4.Text = ""
    End Sub

    Private Sub MainDeckToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainDeckToolStripMenuItem1.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (GlobalVariables.deck25 <> "") Then
                Form1.PictureBox46.ImageLocation = ""
                Form1.ComboBox7.Items.Remove(Form1.ComboBox7.Items.IndexOf(5))
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox46, "")
                GlobalVariables.deck25 = ""
                GlobalVariables.card25 = ""
                Interaction.MsgBox("Card(5) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck24 <> "") Then
                Form1.PictureBox47.ImageLocation = ""
                Form1.ComboBox7.Items.Remove(Form1.ComboBox7.Items.IndexOf(4))
                GlobalVariables.deck24 = ""
                GlobalVariables.card24 = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox47, "")
                Interaction.MsgBox("Card(4) remvoed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck23 <> "") Then
                Form1.PictureBox48.ImageLocation = ""
                Form1.ComboBox7.Items.Remove(Form1.ComboBox7.Items.IndexOf(3))
                GlobalVariables.deck23 = ""
                GlobalVariables.card23 = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox48, "")
                Interaction.MsgBox("Card(3) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck22 <> "") Then
                Form1.PictureBox49.ImageLocation = ""
                Form1.ComboBox7.Items.Remove(Form1.ComboBox7.Items.IndexOf(2))
                GlobalVariables.deck22 = ""
                GlobalVariables.card22 = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox49, "")
                Interaction.MsgBox("Card(2) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck21 <> "") Then
                Form1.PictureBox50.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox50, "")
                Form1.ComboBox7.Items.Remove(Form1.ComboBox7.Items.IndexOf(1))
                GlobalVariables.deck21 = ""
                GlobalVariables.card21 = ""
                Interaction.MsgBox("Card(1) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Form1.ComboBox7.Text = ""
    End Sub

    Private Sub GraveyardToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraveyardToolStripMenuItem2.Click
        If (Form1.ComboBox8.Text.Length > 0) Then
            If (GlobalVariables.grave25 <> "") Then
                Form1.PictureBox56.ImageLocation = ""
                Form1.ComboBox8.Items.Remove(Form1.ComboBox8.Items.IndexOf(5))
                GlobalVariables.grave25 = ""
                GlobalVariables.card30 = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox56, "")
                Interaction.MsgBox("Card(5) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave24 <> "") Then
                Form1.PictureBox57.ImageLocation = ""
                Form1.ComboBox8.Items.Remove(Form1.ComboBox8.Items.IndexOf(4))
                GlobalVariables.grave24 = ""
                GlobalVariables.card29 = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox57, "")
                Interaction.MsgBox("Card(4) remvoed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave23 <> "") Then
                Form1.PictureBox58.ImageLocation = ""
                Form1.Label55.Text -= 1
                GlobalVariables.card28 = ""
                Form1.ToolTip1.SetToolTip(Form1.PictureBox58, "")
                Form1.ComboBox8.Items.Remove(Form1.ComboBox8.Items.IndexOf(3))
                GlobalVariables.grave23 = ""
                Interaction.MsgBox("Card(3) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave22 <> "") Then
                Form1.PictureBox59.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox59, "")
                GlobalVariables.card27 = ""
                Form1.ComboBox8.Items.Remove(Form1.ComboBox8.Items.IndexOf(2))
                GlobalVariables.grave22 = ""
                Interaction.MsgBox("Card(2) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave21 <> "") Then
                Form1.PictureBox60.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox60, "")
                GlobalVariables.card26 = ""
                Form1.ComboBox8.Items.Remove(Form1.ComboBox8.Items.IndexOf(1))
                GlobalVariables.grave21 = ""
                Interaction.MsgBox("Card(1) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Form1.ComboBox8.Text = ""
    End Sub

    Private Sub BanishedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanishedToolStripMenuItem1.Click
        If (Form1.ComboBox5.Text.Length > 0) Then
            If (GlobalVariables.removed15 <> "") Then
                Form1.PictureBox61.ImageLocation = ""
                Form1.ComboBox5.Items.Remove(Form1.ComboBox5.Items.IndexOf(5))
                GlobalVariables.removed15 = ""
                GlobalVariables.card15 = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox61, "")
                Interaction.MsgBox("Card(5) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed14 <> "") Then
                Form1.PictureBox62.ImageLocation = ""
                Form1.ComboBox5.Items.Remove(Form1.ComboBox5.Items.IndexOf(4))
                GlobalVariables.removed14 = ""
                GlobalVariables.card14 = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox62, "")
                Interaction.MsgBox("Card(4) remvoed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed13 <> "") Then
                Form1.PictureBox63.ImageLocation = ""
                Form1.Label54.Text -= 1
                GlobalVariables.card13 = ""
                Form1.ToolTip1.SetToolTip(Form1.PictureBox63, "")
                Form1.ComboBox5.Items.Remove(Form1.ComboBox5.Items.IndexOf(3))
                GlobalVariables.removed13 = ""
                Interaction.MsgBox("Card(3) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed12 <> "") Then
                Form1.PictureBox64.ImageLocation = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox64, "")
                GlobalVariables.card12 = ""
                Form1.ComboBox5.Items.Remove(Form1.ComboBox5.Items.IndexOf(2))
                GlobalVariables.removed12 = ""
                Interaction.MsgBox("Card(2) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed11 <> "") Then
                Form1.PictureBox65.ImageLocation = ""
                Form1.ComboBox5.Items.Remove(Form1.ComboBox5.Items.IndexOf(1))
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox65, "")
                GlobalVariables.card11 = ""
                GlobalVariables.removed11 = ""
                Interaction.MsgBox("Card(1) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed your banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Form1.ComboBox5.Text = ""
    End Sub

    Private Sub IdTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdTextBox1.TextChanged
        Me.PictureBox1.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\" & Me.IdTextBox1.Text & ".jpg"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim search As String = "%" + Me.TextBox1.Text + "%"

        Me.TextsTableAdapter.FillByName(Me.CardsDataSet2.texts, search)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim searchd As String = "%" + Me.TextBox2.Text + "%"

        Me.TextsTableAdapter.FillByDesc(Me.CardsDataSet2.texts, searchd)
    End Sub

    Private Sub MonsterZoneToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonsterZoneToolStripMenuItem2.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (Form1.TextBox36.Text <> "") Then
                Form1.PictureBox17.ImageLocation = ""
                Form1.TextBox36.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox17, "")
                Interaction.MsgBox("Card(5) removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox35.Text <> "") Then
                Form1.PictureBox18.ImageLocation = ""
                Form1.TextBox35.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox18, "")
                Interaction.MsgBox("Card(4) remvoed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox34.Text <> "") Then
                Form1.PictureBox19.ImageLocation = ""
                Form1.TextBox34.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox19, "")
                Interaction.MsgBox("Card(3) removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox33.Text <> "") Then
                Form1.PictureBox20.ImageLocation = ""
                Form1.TextBox33.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox20, "")
                Interaction.MsgBox("Card(2) removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox32.Text <> "") Then
                Form1.PictureBox21.ImageLocation = ""
                Form1.TextBox32.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox21, "")
                Interaction.MsgBox("Card(1) removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent monsters", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub MonsterZoneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonsterZoneToolStripMenuItem1.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (Form1.TextBox17.Text <> "") Then
                Form1.PictureBox5.ImageLocation = ""
                Form1.TextBox17.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox5, "")
                Interaction.MsgBox("Card(5) removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox18.Text <> "") Then
                Form1.PictureBox4.ImageLocation = ""
                Form1.TextBox18.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox4, "")
                Interaction.MsgBox("Card(4) remvoed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox19.Text <> "") Then
                Form1.PictureBox3.ImageLocation = ""
                Form1.TextBox19.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox3, "")
                Interaction.MsgBox("Card(3) removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox20.Text <> "") Then
                Form1.PictureBox2.ImageLocation = ""
                Form1.TextBox20.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox2, "")
                Interaction.MsgBox("Card(2) removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox21.Text <> "") Then
                Form1.PictureBox1.ImageLocation = ""
                Form1.TextBox21.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox1, "")
                Interaction.MsgBox("Card(1) removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from your monsters", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub SpellZoneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellZoneToolStripMenuItem1.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (Form1.TextBox12.Text <> "") Then
                Form1.PictureBox10.ImageLocation = ""
                Form1.TextBox12.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox10, "")
                Interaction.MsgBox("Card(5) removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox13.Text <> "") Then
                Form1.PictureBox9.ImageLocation = ""
                Form1.TextBox13.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox9, "")
                Interaction.MsgBox("Card(4) remvoed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox14.Text <> "") Then
                Form1.PictureBox8.ImageLocation = ""
                Form1.TextBox14.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox8, "")
                Interaction.MsgBox("Card(3) removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox15.Text <> "") Then
                Form1.PictureBox7.ImageLocation = ""
                Form1.TextBox15.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox7, "")
                Interaction.MsgBox("Card(2) removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox16.Text <> "") Then
                Form1.PictureBox6.ImageLocation = ""
                Form1.TextBox16.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox6, "")
                Interaction.MsgBox("Card(1) removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from your spells", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub SpellZoneToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellZoneToolStripMenuItem2.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (Form1.TextBox41.Text <> "") Then
                Form1.PictureBox30.ImageLocation = ""
                Form1.TextBox41.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox30, "")
                Interaction.MsgBox("Card(5) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox40.Text <> "") Then
                Form1.PictureBox29.ImageLocation = ""
                Form1.TextBox40.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox29, "")
                Interaction.MsgBox("Card(4) remvoed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox39.Text <> "") Then
                Form1.PictureBox28.ImageLocation = ""
                Form1.TextBox39.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox28, "")
                Interaction.MsgBox("Card(3) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox38.Text <> "") Then
                Form1.PictureBox27.ImageLocation = ""
                Form1.TextBox38.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox27, "")
                Interaction.MsgBox("Card(2) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox37.Text <> "") Then
                Form1.PictureBox26.ImageLocation = ""
                Form1.TextBox37.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox26, "")
                Interaction.MsgBox("Card(1) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub FieldZoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldZoneToolStripMenuItem.Click
        If (Form1.TextBox6.Text <> "") Then
            Form1.PictureBox15.ImageLocation = ""
            Form1.TextBox6.Text = ""
            Form1.Label54.Text -= 1
            Form1.ToolTip1.SetToolTip(Form1.PictureBox15, "")
            Interaction.MsgBox("Card(5) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
        End If

    End Sub

    Private Sub FieldZoneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldZoneToolStripMenuItem1.Click
        If (Form1.TextBox26.Text <> "") Then
            Form1.PictureBox16.ImageLocation = ""
            Form1.TextBox26.Text = ""
            Form1.Label55.Text -= 1
            Form1.ToolTip1.SetToolTip(Form1.PictureBox16, "")
            Interaction.MsgBox("Card(5) removed from opponent spells", MsgBoxStyle.ApplicationModal, Nothing)
        End If
    End Sub

    Private Sub ExtraDeckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraDeckToolStripMenuItem.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (GlobalVariables.extra15 <> "") Then
                Form1.PictureBox71.ImageLocation = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox71, "")
                Form1.ComboBox6.Items.Remove(Form1.ComboBox6.Items.IndexOf(5))
                GlobalVariables.card20 = ""
                GlobalVariables.extra15 = ""
                Interaction.MsgBox("Card(5) removed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra14 <> "") Then
                Form1.PictureBox72.ImageLocation = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox72, "")
                Form1.ComboBox6.Items.Remove(Form1.ComboBox6.Items.IndexOf(4))
                GlobalVariables.extra14 = ""
                GlobalVariables.card19 = ""
                Interaction.MsgBox("Card(4) remvoed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra13 <> "") Then
                Form1.PictureBox73.ImageLocation = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox73, "")
                Form1.ComboBox6.Items.Remove(Form1.ComboBox6.Items.IndexOf(3))
                GlobalVariables.card18 = ""
                GlobalVariables.extra13 = ""
                Interaction.MsgBox("Card(3) removed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra12 <> "") Then
                Form1.PictureBox74.ImageLocation = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox74, "")
                GlobalVariables.card17 = ""
                Form1.ComboBox6.Items.Remove(Form1.ComboBox6.Items.IndexOf(2))
                GlobalVariables.extra12 = ""
                Interaction.MsgBox("Card(2) removed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra11 <> "") Then
                Form1.PictureBox75.ImageLocation = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox75, "")
                GlobalVariables.card16 = ""
                Form1.ComboBox6.Items.Remove(Form1.ComboBox6.Items.IndexOf(1))
                GlobalVariables.extra11 = ""
                Interaction.MsgBox("Card(1) removed from your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Form1.ComboBox6.Text = ""
    End Sub

    Private Sub BanishedToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanishedToolStripMenuItem2.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (GlobalVariables.removed25 <> "") Then
                Form1.PictureBox66.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox66, "")
                Form1.ComboBox9.Items.Remove(Form1.ComboBox9.Items.IndexOf(5))
                GlobalVariables.card35 = ""
                GlobalVariables.removed25 = ""
                Interaction.MsgBox("Card(5) removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed24 <> "") Then
                Form1.PictureBox67.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox67, "")
                Form1.ComboBox9.Items.Remove(Form1.ComboBox9.Items.IndexOf(4))
                GlobalVariables.removed24 = ""
                GlobalVariables.card34 = ""
                Interaction.MsgBox("Card(4) remvoed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed23 <> "") Then
                Form1.PictureBox68.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox68, "")
                Form1.ComboBox9.Items.Remove(Form1.ComboBox9.Items.IndexOf(3))
                GlobalVariables.card33 = ""
                GlobalVariables.removed23 = ""
                Interaction.MsgBox("Card(3) removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed22 <> "") Then
                Form1.PictureBox69.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox69, "")
                Form1.ComboBox9.Items.Remove(Form1.ComboBox9.Items.IndexOf(2))
                GlobalVariables.card32 = ""
                GlobalVariables.removed22 = ""
                Interaction.MsgBox("Card(2) removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed21 <> "") Then
                Form1.PictureBox70.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox70, "")
                Form1.ComboBox9.Items.Remove(Form1.ComboBox9.Items.IndexOf(1))
                GlobalVariables.card31 = ""
                GlobalVariables.removed21 = ""
                Interaction.MsgBox("Card(1) removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Form1.ComboBox9.Text = ""
    End Sub

    Private Sub ExtraDeckToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraDeckToolStripMenuItem2.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (GlobalVariables.extra25 <> "") Then
                Form1.PictureBox76.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox76, "")
                Form1.ComboBox10.Items.Remove(Form1.ComboBox10.Items.IndexOf(5))
                GlobalVariables.card40 = ""
                GlobalVariables.extra25 = ""
                Interaction.MsgBox("Card(5) removed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra24 <> "") Then
                Form1.PictureBox77.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox77, "")
                Form1.ComboBox10.Items.Remove(Form1.ComboBox10.Items.IndexOf(4))
                GlobalVariables.card39 = ""
                GlobalVariables.extra24 = ""
                Interaction.MsgBox("Card(4) remvoed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra23 <> "") Then
                Form1.PictureBox78.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox78, "")
                GlobalVariables.card38 = ""
                Form1.ComboBox10.Items.Remove(Form1.ComboBox10.Items.IndexOf(3))
                GlobalVariables.extra23 = ""
                Interaction.MsgBox("Card(3) removed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra22 <> "") Then
                Form1.PictureBox79.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox79, "")
                GlobalVariables.card37 = ""
                Form1.ComboBox10.Items.Remove(Form1.ComboBox10.Items.IndexOf(2))
                GlobalVariables.extra22 = ""
                Interaction.MsgBox("Card(2) removed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra25 <> "") Then
                Form1.PictureBox80.ImageLocation = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox80, "")
                Form1.ComboBox10.Items.Remove(Form1.ComboBox10.Items.IndexOf(1))
                GlobalVariables.card36 = ""
                GlobalVariables.extra25 = ""
                Interaction.MsgBox("Card(1) removed from your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed your opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Form1.ComboBox10.Text = ""
    End Sub

    Private Sub HandZoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HandZoneToolStripMenuItem.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (Form1.TextBox7.Text <> "") Then
                Form1.PictureBox35.ImageLocation = ""
                Form1.TextBox7.Text = ""
                Form1.Label54.Text -= 1

                Form1.ToolTip1.SetToolTip(Form1.PictureBox35, "")
                Interaction.MsgBox("Card(5) removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox8.Text <> "") Then
                Form1.PictureBox34.ImageLocation = ""
                Form1.TextBox8.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox34, "")
                Interaction.MsgBox("Card(4) remvoed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox9.Text <> "") Then
                Form1.PictureBox33.ImageLocation = ""
                Form1.TextBox9.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox33, "")
                Interaction.MsgBox("Card(3) removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox10.Text <> "") Then
                Form1.PictureBox32.ImageLocation = ""
                Form1.TextBox10.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox32, "")
                Interaction.MsgBox("Card(2) removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox11.Text <> "") Then
                Form1.PictureBox31.ImageLocation = ""
                Form1.TextBox11.Text = ""
                Form1.Label54.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox31, "")
                Interaction.MsgBox("Card(1) removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from your hand", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub HandZoneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HandZoneToolStripMenuItem1.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (Form1.TextBox31.Text <> "") Then
                Form1.PictureBox36.ImageLocation = ""
                Form1.TextBox31.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox36, "")
                Interaction.MsgBox("Card(5) removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox30.Text <> "") Then
                Form1.PictureBox37.ImageLocation = ""
                Form1.TextBox30.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox37, "")
                Interaction.MsgBox("Card(4) remvoed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox29.Text <> "") Then
                Form1.PictureBox38.ImageLocation = ""
                Form1.TextBox29.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox38, "")
                Interaction.MsgBox("Card(3) removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox28.Text <> "") Then
                Form1.PictureBox39.ImageLocation = ""
                Form1.TextBox28.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox39, "")
                Interaction.MsgBox("Card(2) removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (Form1.TextBox27.Text <> "") Then
                Form1.PictureBox40.ImageLocation = ""
                Form1.TextBox27.Text = ""
                Form1.Label55.Text -= 1
                Form1.ToolTip1.SetToolTip(Form1.PictureBox40, "")
                Interaction.MsgBox("Card(1) removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed from opponent hand", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub

    Private Sub PlayerCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerCardToolStripMenuItem.Click
        If IdTextBox1.Text <> "" Then
            Form4.ListBox4.Items.Add(Me.IdTextBox1.Text)
            Form4.ListBox1.Items.Add(Me.NameTextBox.Text)
        Else
            MsgBox("Please select card in database")
        End If
    End Sub

    Private Sub OpponentCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpponentCardToolStripMenuItem.Click
        If IdTextBox1.Text <> "" Then
            Form4.ListBox3.Items.Add(Me.IdTextBox1.Text)
            Form4.ListBox2.Items.Add(Me.NameTextBox.Text)
        Else
            MsgBox("Please select card in database")
        End If
    End Sub

    Private Sub UsableCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsableCardToolStripMenuItem.Click
        If IdTextBox1.Text <> "" Then
            Form5.ListBox5.Items.Add(Me.IdTextBox1.Text)
            Form5.ListBox6.Items.Add(Me.NameTextBox.Text)
        Else
            MsgBox("Please select card in database")
        End If
    End Sub

    Private Sub NotUsableCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotUsableCardToolStripMenuItem.Click
        If IdTextBox1.Text <> "" Then
            Form5.ListBox7.Items.Add(Me.IdTextBox1.Text)
            Form5.ListBox8.Items.Add(Me.NameTextBox.Text)
        Else
            MsgBox("Please select card in database")
        End If
    End Sub

    Private Sub AllSelectedCardsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllSelectedCardsToolStripMenuItem.Click
        Dim selectedCellCount As Integer = _
            TextsDataGridView.GetCellCount(DataGridViewElementStates.Selected)

        If selectedCellCount > 0 Then

            If TextsDataGridView.AreAllCellsSelected(True) Then

                MessageBox.Show("All cells are selected", "Selected Cells")

            Else

                Dim sb As New System.Text.StringBuilder()

                Dim i As Integer
                For i = 0 To selectedCellCount - 1

                    sb.Append("Row: ")
                    sb.Append(TextsDataGridView.SelectedCells(i).RowIndex _
                        .ToString())
                    sb.Append(", Column: ")
                    sb.Append(TextsDataGridView.SelectedCells(i).ColumnIndex _
                        .ToString())
                    sb.Append(Environment.NewLine)

                Next i

                sb.Append("Total: " + selectedCellCount.ToString())
                MessageBox.Show(sb.ToString(), "Selected Cells")
                
            End If

        End If
    End Sub
End Class