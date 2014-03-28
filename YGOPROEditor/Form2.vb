Public Class Form2

    Private Sub DatainfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DatainfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CardsDataSet1)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CardsDataSet1.textos' Puede moverla o quitarla según sea necesario.
        Me.TextosTableAdapter.Fill(Me.CardsDataSet1.textos)
        'TODO: esta línea de código carga datos en la tabla 'CardsDataSet1.datainfo' Puede moverla o quitarla según sea necesario.
        Me.DatainfoTableAdapter.Fill(Me.CardsDataSet1.datainfo)




    End Sub


    Private Sub NameToolStripLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim search As String = "%" + Me.TextBox1.Text + "%"

        Me.TextosTableAdapter.FillBy(Me.CardsDataSet1.textos, search)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveLastItem.Click
        Me.TextosBindingSource.MoveLast()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.Click
        Me.TextosBindingSource.MoveNext()
    End Sub

    Private Sub BindingNavigatorCountItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCountItem.Click

    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        Me.TextosBindingSource.MovePrevious()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        Me.TextosBindingSource.MoveFirst()
    End Sub

    Private Sub IdTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdTextBox1.TextChanged
        Me.PictureBox1.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\" & Me.IdTextBox1.Text & ".jpg"
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim searchd As String = "%" + Me.TextBox3.Text + "%"

        Me.TextosTableAdapter.FillByDesc(Me.CardsDataSet1.textos, searchd)
    End Sub

    Private Sub Monster1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster1ToolStripMenuItem.Click
        If Form1.TextBox21.Text = "" Then
            Try
                Form1.TextBox21.Text = Me.IdTextBox1.Text

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

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(2) currently have a card reference")
        End If
    End Sub

    Private Sub Monster3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster3ToolStripMenuItem.Click
        If Form1.TextBox21.Text = "" Then
            Try
                Form1.TextBox19.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub Monster4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster4ToolStripMenuItem.Click
        If Form1.TextBox21.Text = "" Then
            Try
                Form1.TextBox18.Text = Me.IdTextBox1.Text

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

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub Spell3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell3ToolStripMenuItem.Click
        If Form1.TextBox14.Text = "" Then
            Try
                Form1.TextBox14.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub Spell4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell4ToolStripMenuItem.Click
        If Form1.TextBox13.Text = "" Then
            Try
                Form1.TextBox13.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub Spell5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell5ToolStripMenuItem.Click
        If Form1.TextBox12.Text = "" Then
            Try
                Form1.TextBox12.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub FieldSpellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldSpellToolStripMenuItem.Click
        If Form1.TextBox6.Text = "" Then
            Try
                Form1.TextBox6.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub DeckZoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeckZoneToolStripMenuItem.Click
        If (Me.IdTextBox1.Text <> "") Then
            If (GlobalVariables.deck11 = "") Then
                Form1.ComboBox3.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox45.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.deck11 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck1p
                Interaction.MsgBox("Card(1) added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck12 = "") Then
                Form1.ComboBox3.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox44.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.deck12 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck1p
                Interaction.MsgBox("Card(2) added to yout deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck13 = "") Then
                Form1.ComboBox3.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox43.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.deck13 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck1p
                Interaction.MsgBox("Card(3) added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck14 = "") Then
                Form1.PictureBox42.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                Form1.ComboBox3.Items.Add(Me.IdTextBox1.Text)
                GlobalVariables.deck14 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck1p
                Interaction.MsgBox("Card(4) added to your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck15 = "") Then
                Form1.PictureBox41.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
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
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox55.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.grave11 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.gravept
                Interaction.MsgBox("Card(1) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave12 = "") Then
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox54.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.grave12 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.gravept
                Interaction.MsgBox("Card(2) added to yout graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave13 = "") Then
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox53.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.grave13 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.gravept
                Interaction.MsgBox("Card(3) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave14 = "") Then
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox52.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.grave14 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.gravept
                Interaction.MsgBox("Card(4) added to your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave15 = "") Then
                Form1.ComboBox4.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox51.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
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
                GlobalVariables.removed11 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt
                Interaction.MsgBox("Card(1) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed12 = "") Then
                Form1.ComboBox5.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox64.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.removed12 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt
                Interaction.MsgBox("Card(2) added to yout banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed13 = "") Then
                Form1.ComboBox5.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox63.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.removed13 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt
                Interaction.MsgBox("Card(3) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed14 = "") Then
                Form1.ComboBox5.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox62.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.removed14 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt
                Interaction.MsgBox("Card(4) added to your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed15 = "") Then
                Form1.ComboBox5.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox61.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
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
                GlobalVariables.extra11 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt
                Interaction.MsgBox("Card(1) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra12 = "") Then
                Form1.ComboBox6.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox74.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.extra12 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt
                Interaction.MsgBox("Card(2) added to yout extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra13 = "") Then
                Form1.ComboBox6.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox73.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.extra13 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt
                Interaction.MsgBox("Card(3) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra14 = "") Then
                Form1.ComboBox6.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox72.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.extra14 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt
                Interaction.MsgBox("Card(4) added to your extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra15 = "") Then
                Form1.ComboBox6.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox71.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
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
                GlobalVariables.deck21 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck2p
                Interaction.MsgBox("Card(1) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck22 = "") Then
                Form1.ComboBox7.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox49.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.deck22 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck2p
                Interaction.MsgBox("Card(2) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck23 = "") Then
                Form1.ComboBox7.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox48.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.deck23 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck2p
                Interaction.MsgBox("Card(3) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck24 = "") Then
                Form1.ComboBox7.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox47.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.deck24 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.deck2p
                Interaction.MsgBox("Card(4) added to opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck25 = "") Then
                Form1.ComboBox7.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox46.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
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
                GlobalVariables.grave21 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.grave2pt
                Interaction.MsgBox("Card(1) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave22 = "") Then
                Form1.ComboBox8.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox59.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.grave22 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.grave2pt
                Interaction.MsgBox("Card(2) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck23 = "") Then
                Form1.ComboBox8.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox58.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.grave23 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.grave2pt
                Interaction.MsgBox("Card(3) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave24 = "") Then
                Form1.ComboBox8.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox57.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.grave24 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.grave2pt
                Interaction.MsgBox("Card(4) added to opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave25 = "") Then
                Form1.ComboBox8.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox56.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
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
                GlobalVariables.removed21 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt2
                Interaction.MsgBox("Card(1) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed22 = "") Then
                Form1.ComboBox9.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox69.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.removed22 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt2
                Interaction.MsgBox("Card(2) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed23 = "") Then
                Form1.ComboBox9.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox68.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.removed23 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt2
                Interaction.MsgBox("Card(3) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed24 = "") Then
                Form1.ComboBox9.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox67.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.removed24 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.removedpt2
                Interaction.MsgBox("Card(4) added to opponent banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed25 = "") Then
                Form1.ComboBox9.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox66.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
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
                GlobalVariables.extra21 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt2
                Interaction.MsgBox("Card(1) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra22 = "") Then
                Form1.ComboBox10.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox79.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.extra22 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt2
                Interaction.MsgBox("Card(2) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra23 = "") Then
                Form1.ComboBox10.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox78.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.extra23 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt2
                Interaction.MsgBox("Card(3) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra24 = "") Then
                Form1.ComboBox10.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox77.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
                GlobalVariables.extra24 = My.Settings.AddCard & Me.IdTextBox1.Text & GlobalVariables.extrapt2
                Interaction.MsgBox("Card(4) added to opponent extra deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.extra25 = "") Then
                Form1.ComboBox10.Items.Add(Me.IdTextBox1.Text)
                Form1.PictureBox76.ImageLocation = Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.IdTextBox1.Text & ".jpg"
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

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Monster zone(5) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        If Form1.TextBox41.Text = "" Then
            Try
                Form1.TextBox41.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(1) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        If Form1.TextBox40.Text = "" Then
            Try
                Form1.TextBox40.Text = Me.IdTextBox1.Text

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

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(3) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        If Form1.TextBox38.Text = "" Then
            Try
                Form1.TextBox38.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Spell zone(4) currently have a card reference")
        End If
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        If Form1.TextBox37.Text = "" Then
            Try
                Form1.TextBox37.Text = Me.IdTextBox1.Text

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

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand2ToolStripMenuItem.Click
        If Form1.TextBox10.Text = "" Then
            Try
                Form1.TextBox10.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand3ToolStripMenuItem.Click
        If Form1.TextBox9.Text = "" Then
            Try
                Form1.TextBox9.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand4ToolStripMenuItem.Click
        If Form1.TextBox8.Text = "" Then
            Try
                Form1.TextBox8.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand5ToolStripMenuItem.Click
        If Form1.TextBox7.Text = "" Then
            Try
                Form1.TextBox7.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand1ToolStripMenuItem1.Click
        If Form1.TextBox27.Text = "" Then
            Try
                Form1.TextBox27.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand2ToolStripMenuItem1.Click
        If Form1.TextBox28.Text = "" Then
            Try
                Form1.TextBox28.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand3ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand3ToolStripMenuItem1.Click
        If Form1.TextBox29.Text = "" Then
            Try
                Form1.TextBox29.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand4ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand4ToolStripMenuItem1.Click
        If Form1.TextBox30.Text = "" Then
            Try
                Form1.TextBox30.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub Hand5ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hand5ToolStripMenuItem1.Click
        If Form1.TextBox31.Text = "" Then
            Try
                Form1.TextBox31.Text = Me.IdTextBox1.Text

            Catch ex As Exception
                MsgBox("You cannot add this reference to that zone")

            End Try
        Else
            MsgBox("Field zone currently have a card reference")
        End If
    End Sub

    Private Sub MainDeckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainDeckToolStripMenuItem.Click
        If (Me.IdTextBox1.Text > 0) Then
            If (GlobalVariables.deck15 <> "") Then
                Form1.PictureBox41.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(5))
                GlobalVariables.deck15 = ""
                Interaction.MsgBox("Card(5) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck14 <> "") Then
                Form1.PictureBox42.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(4))
                GlobalVariables.deck14 = ""
                Interaction.MsgBox("Card(4) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck13 <> "") Then
                Form1.PictureBox43.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(3))
                GlobalVariables.deck13 = ""
                Interaction.MsgBox("Card(3) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck12 <> "") Then
                Form1.PictureBox44.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(2))
                GlobalVariables.deck12 = ""
                Interaction.MsgBox("Card(2) removed from your deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck11 <> "") Then
                Form1.PictureBox45.ImageLocation = ""
                Form1.ComboBox3.Items.Remove(Form1.ComboBox3.Items.IndexOf(1))
                GlobalVariables.deck11 = ""
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
                Interaction.MsgBox("Card(5) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave14 <> "") Then
                Form1.PictureBox52.ImageLocation = ""
                Form1.ComboBox4.Items.Remove(Form1.ComboBox4.Items.IndexOf(5))
                GlobalVariables.grave14 = ""
                Interaction.MsgBox("Card(4) remvoed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave13 <> "") Then
                Form1.PictureBox53.ImageLocation = ""
                Form1.ComboBox4.Items.Remove(Form1.ComboBox4.Items.IndexOf(3))
                GlobalVariables.grave13 = ""
                Interaction.MsgBox("Card(3) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave12 <> "") Then
                Form1.PictureBox54.ImageLocation = ""
                Form1.ComboBox4.Items.Remove(Form1.ComboBox4.Items.IndexOf(2))
                GlobalVariables.grave12 = ""
                Interaction.MsgBox("Card(2) removed from your graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave11 <> "") Then
                Form1.PictureBox55.ImageLocation = ""
                Form1.ComboBox4.Items.Remove(Form1.ComboBox4.Items.IndexOf(1))
                GlobalVariables.grave11 = ""
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
                GlobalVariables.deck25 = ""
                Interaction.MsgBox("Card(5) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck24 <> "") Then
                Form1.PictureBox47.ImageLocation = ""
                Form1.ComboBox7.Items.Remove(Form1.ComboBox7.Items.IndexOf(4))
                GlobalVariables.deck24 = ""
                Interaction.MsgBox("Card(4) remvoed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck23 <> "") Then
                Form1.PictureBox48.ImageLocation = ""
                Form1.ComboBox7.Items.Remove(Form1.ComboBox7.Items.IndexOf(3))
                GlobalVariables.deck23 = ""
                Interaction.MsgBox("Card(3) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck22 <> "") Then
                Form1.PictureBox49.ImageLocation = ""
                Form1.ComboBox7.Items.Remove(Form1.ComboBox7.Items.IndexOf(2))
                GlobalVariables.deck22 = ""
                Interaction.MsgBox("Card(2) removed from opponent deck", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.deck21 <> "") Then
                Form1.PictureBox50.ImageLocation = ""
                Form1.ComboBox7.Items.Remove(Form1.ComboBox7.Items.IndexOf(1))
                GlobalVariables.deck21 = ""
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
                Interaction.MsgBox("Card(5) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave24 <> "") Then
                Form1.PictureBox57.ImageLocation = ""
                Form1.ComboBox8.Items.Remove(Form1.ComboBox8.Items.IndexOf(4))
                GlobalVariables.grave24 = ""
                Interaction.MsgBox("Card(4) remvoed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave23 <> "") Then
                Form1.PictureBox58.ImageLocation = ""
                Form1.ComboBox8.Items.Remove(Form1.ComboBox8.Items.IndexOf(3))
                GlobalVariables.grave23 = ""
                Interaction.MsgBox("Card(3) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave22 <> "") Then
                Form1.PictureBox59.ImageLocation = ""
                Form1.ComboBox8.Items.Remove(Form1.ComboBox8.Items.IndexOf(2))
                GlobalVariables.grave22 = ""
                Interaction.MsgBox("Card(2) removed from opponent graveyard", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.grave21 <> "") Then
                Form1.PictureBox60.ImageLocation = ""
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
                Interaction.MsgBox("Card(5) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed14 <> "") Then
                Form1.PictureBox62.ImageLocation = ""
                Form1.ComboBox5.Items.Remove(Form1.ComboBox5.Items.IndexOf(4))
                GlobalVariables.removed14 = ""
                Interaction.MsgBox("Card(4) remvoed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed13 <> "") Then
                Form1.PictureBox63.ImageLocation = ""
                Form1.ComboBox5.Items.Remove(Form1.ComboBox5.Items.IndexOf(3))
                GlobalVariables.removed13 = ""
                Interaction.MsgBox("Card(3) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed12 <> "") Then
                Form1.PictureBox64.ImageLocation = ""
                Form1.ComboBox5.Items.Remove(Form1.ComboBox5.Items.IndexOf(2))
                GlobalVariables.removed12 = ""
                Interaction.MsgBox("Card(2) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            ElseIf (GlobalVariables.removed11 <> "") Then
                Form1.PictureBox65.ImageLocation = ""
                Form1.ComboBox5.Items.Remove(Form1.ComboBox5.Items.IndexOf(1))
                GlobalVariables.removed11 = ""
                Interaction.MsgBox("Card(1) removed from your banished", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Interaction.MsgBox("No more cards removed your banished", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
        Form1.ComboBox5.Text = ""
    End Sub
End Class