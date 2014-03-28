Imports System
Imports System.IO
Imports System.IO.File
Imports System.Text


Public Class Form4






    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.TextBox21.Text <> "" Then
            ListBox4.Items.Add(Form1.TextBox21.Text)
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox1))

            Label6.Text += 1
        End If
        If Form1.TextBox20.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox2))
            ListBox4.Items.Add(Form1.TextBox20.Text)
            Label6.Text += 1
        End If
        If Form1.TextBox19.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox3))
            ListBox4.Items.Add(Form1.TextBox19.Text)
            Label6.Text += 1
        End If
        If Form1.TextBox18.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox4))
            ListBox4.Items.Add(Form1.TextBox18.Text)
            Label6.Text += 1
        End If
        If Form1.TextBox17.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox5))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox17.Text)
        End If
        If Form1.TextBox16.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox6))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox16.Text)
        End If
        If Form1.TextBox15.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox7))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox15.Text)
        End If
        If Form1.TextBox14.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox8))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox14.Text)
        End If
        If Form1.TextBox13.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox9))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox13.Text)
        End If
        If Form1.TextBox12.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox10))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox12.Text)
        End If
        If Form1.TextBox11.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox31))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox11.Text)
        End If
        If Form1.TextBox10.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox32))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox10.Text)
        End If
        If Form1.TextBox9.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox33))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox9.Text)
        End If
        If Form1.TextBox8.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox34))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox8.Text)
        End If
        If Form1.TextBox7.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox35))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox7.Text)
        End If
        If Form1.TextBox6.Text <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox15))
            Label6.Text += 1
            ListBox4.Items.Add(Form1.TextBox6.Text)
        End If
        If GlobalVariables.card1 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox45))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card1)
        End If
        If GlobalVariables.card2 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox44))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card2)
        End If
        If GlobalVariables.card3 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox43))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card3)
        End If
        If GlobalVariables.card4 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox42))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card4)
        End If
        If GlobalVariables.card5 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox41))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card5)
        End If
        If GlobalVariables.grave11 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox55))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card6)
        End If
        If GlobalVariables.grave12 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox54))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card7)
        End If
        If GlobalVariables.grave13 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox53))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card8)
        End If
        If GlobalVariables.grave14 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox52))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card9)
        End If
        If GlobalVariables.grave15 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox51))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card10)
        End If
        If GlobalVariables.removed11 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox65))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card11)
        End If
        If GlobalVariables.removed12 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox64))
            Label6.Text += 1
            ListBox4.Items.Add(GlobalVariables.card12)
        End If
        If GlobalVariables.removed13 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox63))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card13)
        End If
        If GlobalVariables.removed14 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox62))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card14)
        End If
        If GlobalVariables.removed15 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox61))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card15)
        End If
        If GlobalVariables.extra11 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox75))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card16)
        End If
        If GlobalVariables.extra12 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox74))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card17)
        End If
        If GlobalVariables.extra13 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox73))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card18)
        End If
        If GlobalVariables.extra14 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox72))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card19)
        End If
        If GlobalVariables.extra15 <> "" Then
            ListBox1.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox71))
            Label6.Text += 1
            Me.ListBox4.Items.Add(GlobalVariables.card20)
        End If




        If Form1.TextBox32.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox21))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox32.Text)
        End If
        If Form1.TextBox33.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox20))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox33.Text)
        End If
        If Form1.TextBox34.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox19))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox34.Text)
        End If
        If Form1.TextBox35.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox18))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox35.Text)
        End If
        If Form1.TextBox36.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox17))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox36.Text)
        End If
        If Form1.TextBox37.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox26))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox37.Text)
        End If
        If Form1.TextBox38.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox27))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox38.Text)
        End If
        If Form1.TextBox39.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox28))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox39.Text)
        End If
        If Form1.TextBox40.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox29))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox40.Text)
        End If
        If Form1.TextBox41.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox30))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox41.Text)
        End If
        If Form1.TextBox26.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox16))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox26.Text)
        End If
        If Form1.TextBox27.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox40))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox27.Text)
        End If
        If Form1.TextBox28.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox39))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox28.Text)
        End If
        If Form1.TextBox29.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox38))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox29.Text)
        End If
        If Form1.TextBox30.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox37))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox30.Text)
        End If
        If Form1.TextBox31.Text <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox36))
            Label8.Text += 1
            Me.ListBox3.Items.Add(Form1.TextBox31.Text)
        End If
        If GlobalVariables.deck21 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox50))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card21)
        End If
        If GlobalVariables.deck22 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox49))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card22)
        End If
        If GlobalVariables.deck23 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox48))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card23)
        End If
        If GlobalVariables.deck24 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox47))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card24)

        End If
        If GlobalVariables.deck25 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox46))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card25)
        End If
        If GlobalVariables.grave21 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox60))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card26)
        End If
        If GlobalVariables.grave22 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox59))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card27)
        End If
        If GlobalVariables.grave23 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox58))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card28)
        End If
        If GlobalVariables.grave24 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox57))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card29)
        End If
        If GlobalVariables.grave25 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox56))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card30)
        End If
        If GlobalVariables.removed21 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox70))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card31)
        End If
        If GlobalVariables.removed22 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox69))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card32)
        End If
        If GlobalVariables.removed23 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox68))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card33)
        End If
        If GlobalVariables.removed24 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox67))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card34)
        End If
        If GlobalVariables.removed25 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox66))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card35)
        End If
        If GlobalVariables.extra21 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox80))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card36)
        End If
        If GlobalVariables.extra22 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox79))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card37)
        End If
        If GlobalVariables.extra23 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox78))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card38)
        End If
        If GlobalVariables.extra24 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox77))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card39)
        End If
        If GlobalVariables.extra25 <> "" Then
            ListBox2.Items.Add(Form1.ToolTip1.GetToolTip(Form1.PictureBox76))
            Label8.Text += 1
            Me.ListBox3.Items.Add(GlobalVariables.card40)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" And Label6.Text <= 20 Then
                Me.TextBox1.Text = Me.ListBox4.SelectedItem
                PictureBox1.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox2.Text = "" Then
                Me.TextBox2.Text = Me.ListBox4.SelectedItem
                PictureBox2.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox3.Text = "" Then
                Me.TextBox3.Text = Me.ListBox4.SelectedItem
                PictureBox3.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox4.Text = "" Then
                Me.TextBox4.Text = Me.ListBox4.SelectedItem
                PictureBox4.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox5.Text = "" Then
                Me.TextBox5.Text = Me.ListBox4.SelectedItem
                PictureBox5.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox6.Text = "" Then
                Me.TextBox6.Text = Me.ListBox4.SelectedItem
                PictureBox6.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox7.Text = "" Then
                Me.TextBox7.Text = Me.ListBox4.SelectedItem
                PictureBox7.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox8.Text = "" Then
                Me.TextBox8.Text = Me.ListBox4.SelectedItem
                PictureBox8.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox9.Text = "" Then
                Me.TextBox9.Text = Me.ListBox4.SelectedItem
                PictureBox9.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox10.Text = "" Then
                Me.TextBox10.Text = Me.ListBox4.SelectedItem
                PictureBox10.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox11.Text = "" Then
                Me.TextBox11.Text = Me.ListBox4.SelectedItem
                PictureBox11.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox12.Text = "" Then
                Me.TextBox12.Text = Me.ListBox4.SelectedItem
                PictureBox12.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox13.Text = "" Then
                Me.TextBox13.Text = Me.ListBox4.SelectedItem
                PictureBox13.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox14.Text = "" Then
                Me.TextBox14.Text = Me.ListBox4.SelectedItem
                PictureBox14.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox15.Text = "" Then
                Me.TextBox15.Text = Me.ListBox4.SelectedItem
                PictureBox15.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox16.Text = "" Then
                Me.TextBox16.Text = Me.ListBox4.SelectedItem
                PictureBox16.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox17.Text = "" Then
                Me.TextBox17.Text = Me.ListBox4.SelectedItem
                PictureBox17.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox18.Text = "" Then
                Me.TextBox18.Text = Me.ListBox4.SelectedItem
                PictureBox18.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox19.Text = "" Then
                Me.TextBox19.Text = Me.ListBox4.SelectedItem
                PictureBox19.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            ElseIf TextBox20.Text = "" Then
                Me.TextBox20.Text = Me.ListBox4.SelectedItem
                PictureBox20.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label4.Text += 1
                Label6.Text += 1
            End If

        Catch ex As Exception
            MsgBox("No more players cards can be assigned to main deck")
        End Try
    End Sub
    Private Sub cardscount()
        Dim cards(60) As Long
        Dim num As Integer
        For num = 1 To 60
            cards(num) += cards(num + 1)


        Next

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If TextBox21.Text = "" And Label8.Text <= 20 Then
                Me.TextBox21.Text = Me.ListBox3.SelectedItem
                PictureBox21.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox22.Text = "" Then
                Me.TextBox22.Text = Me.ListBox3.SelectedItem
                PictureBox22.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox23.Text = "" Then
                Me.TextBox23.Text = Me.ListBox3.SelectedItem
                PictureBox23.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox24.Text = "" Then
                Me.TextBox24.Text = Me.ListBox3.SelectedItem
                PictureBox24.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox25.Text = "" Then
                Me.TextBox25.Text = Me.ListBox3.SelectedItem
                PictureBox25.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox26.Text = "" Then
                Me.TextBox26.Text = Me.ListBox3.SelectedItem
                PictureBox26.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox27.Text = "" Then
                Me.TextBox27.Text = Me.ListBox3.SelectedItem
                PictureBox27.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox28.Text = "" Then
                Me.TextBox28.Text = Me.ListBox3.SelectedItem
                PictureBox28.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox29.Text = "" Then
                Me.TextBox29.Text = Me.ListBox3.SelectedItem
                PictureBox29.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox30.Text = "" Then
                Me.TextBox30.Text = Me.ListBox3.SelectedItem
                PictureBox30.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox31.Text = "" Then
                Me.TextBox31.Text = Me.ListBox3.SelectedItem
                PictureBox31.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox32.Text = "" Then
                Me.TextBox32.Text = Me.ListBox3.SelectedItem
                PictureBox32.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox33.Text = "" Then
                Me.TextBox33.Text = Me.ListBox3.SelectedItem
                PictureBox33.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox34.Text = "" Then
                Me.TextBox34.Text = Me.ListBox3.SelectedItem
                PictureBox34.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox35.Text = "" Then
                Me.TextBox35.Text = Me.ListBox3.SelectedItem
                PictureBox35.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox36.Text = "" Then
                Me.TextBox36.Text = Me.ListBox3.SelectedItem
                PictureBox36.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox37.Text = "" Then
                Me.TextBox37.Text = Me.ListBox3.SelectedItem
                PictureBox37.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox38.Text = "" Then
                Me.TextBox38.Text = Me.ListBox3.SelectedItem
                PictureBox38.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox39.Text = "" Then
                Me.TextBox39.Text = Me.ListBox3.SelectedItem
                PictureBox39.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            ElseIf TextBox40.Text = "" Then
                Me.TextBox40.Text = Me.ListBox3.SelectedItem
                PictureBox40.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label4.Text += 1
                Label8.Text += 1
            End If

        Catch ex As Exception
            MsgBox("No more opponent cards can be assigned to main deck")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text = ListBox4.SelectedItem Then
                Me.TextBox1.Text = ""
                PictureBox1.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox2.Text = ListBox4.SelectedItem Then
                Me.TextBox2.Text = ""
                PictureBox2.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox3.Text = ListBox4.SelectedItem Then
                Me.TextBox3.Text = ""
                PictureBox3.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox4.Text = ListBox4.SelectedItem Then
                Me.TextBox4.Text = ""
                PictureBox4.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox5.Text = ListBox4.SelectedItem Then
                Me.TextBox5.Text = ""
                PictureBox5.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox6.Text = ListBox4.SelectedItem Then
                Me.TextBox6.Text = ""
                PictureBox6.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox7.Text = ListBox4.SelectedItem Then
                Me.TextBox7.Text = ""
                PictureBox7.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox8.Text = ListBox4.SelectedItem Then
                Me.TextBox8.Text = ""
                PictureBox8.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox9.Text = ListBox4.SelectedItem Then
                Me.TextBox9.Text = ""
                PictureBox9.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox10.Text = ListBox4.SelectedItem Then
                Me.TextBox10.Text = ""
                PictureBox10.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox11.Text = ListBox4.SelectedItem Then
                Me.TextBox11.Text = ""
                PictureBox11.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox12.Text = ListBox4.SelectedItem Then
                Me.TextBox12.Text = ""
                PictureBox12.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox13.Text = ListBox4.SelectedItem Then
                Me.TextBox13.Text = ""
                PictureBox13.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox14.Text = ListBox4.SelectedItem Then
                Me.TextBox14.Text = ""
                PictureBox14.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox15.Text = ListBox4.SelectedItem Then
                Me.TextBox15.Text = ""
                PictureBox15.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox16.Text = ListBox4.SelectedItem Then
                Me.TextBox16.Text = ""
                PictureBox16.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox17.Text = ListBox4.SelectedItem Then
                Me.TextBox17.Text = ""
                PictureBox17.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox18.Text = ListBox4.SelectedItem Then
                Me.TextBox18.Text = ""
                PictureBox18.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox19.Text = ListBox4.SelectedItem Then
                Me.TextBox19.Text = ""
                PictureBox19.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            ElseIf TextBox20.Text = ListBox4.SelectedItem Then
                Me.TextBox20.Text = ""
                PictureBox20.ImageLocation = ""
                Label4.Text -= 1
                Label6.Text -= 1
            End If


        Catch ex As Exception
            MsgBox("No more players cards can be deleted from main deck")
        End Try
    End Sub

    Private Sub PlayerDeckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerDeckToolStripMenuItem.Click
        Try
            Dim prompt As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\New.ydk")
            Interaction.MsgBox(prompt, MsgBoxStyle.ApplicationModal, Nothing)
            If Not File.Exists(prompt) Then
                File.Create(prompt).Dispose()
            End If
            Dim writer As New StreamWriter(prompt)
            writer.WriteLine("#created by ...")
            writer.WriteLine("#main")

            If Me.TextBox1.Text <> "" Then
                writer.WriteLine(TextBox1.Text)
            End If

            If Me.TextBox2.Text <> "" Then
                writer.WriteLine(TextBox2.Text)
            End If

            If Me.TextBox3.Text <> "" Then
                writer.WriteLine(TextBox3.Text)
            End If

            If Me.TextBox4.Text <> "" Then
                writer.WriteLine(TextBox4.Text)
            End If

            If Me.TextBox5.Text <> "" Then
                writer.WriteLine(TextBox5.Text)
            End If

            If Me.TextBox6.Text <> "" Then
                writer.WriteLine(TextBox6.Text)
            End If
            If Me.TextBox7.Text <> "" Then
                writer.WriteLine(TextBox7.Text)
            End If
            If Me.TextBox8.Text <> "" Then
                writer.WriteLine(TextBox8.Text)
            End If
            If Me.TextBox9.Text <> "" Then
                writer.WriteLine(TextBox9.Text)
            End If
            If Me.TextBox10.Text <> "" Then
                writer.WriteLine(TextBox10.Text)
            End If
            If Me.TextBox11.Text <> "" Then
                writer.WriteLine(TextBox11.Text)
            End If
            If Me.TextBox12.Text <> "" Then
                writer.WriteLine(TextBox12.Text)
            End If
            If Me.TextBox13.Text <> "" Then
                writer.WriteLine(TextBox3.Text)
            End If
            If Me.TextBox14.Text <> "" Then
                writer.WriteLine(TextBox14.Text)
            End If
            If Me.TextBox15.Text <> "" Then
                writer.WriteLine(TextBox15.Text)
            End If
            If Me.TextBox16.Text <> "" Then
                writer.WriteLine(TextBox16.Text)
            End If
            If Me.TextBox17.Text <> "" Then
                writer.WriteLine(TextBox17.Text)
            End If
            If Me.TextBox18.Text <> "" Then
                writer.WriteLine(TextBox18.Text)
            End If
            If Me.TextBox19.Text <> "" Then
                writer.WriteLine(TextBox19.Text)
            End If
            If Me.TextBox20.Text <> "" Then
                writer.WriteLine(TextBox20.Text)
            End If
            If Me.TextBox21.Text <> "" Then
                writer.WriteLine(TextBox21.Text)
            End If
            If Me.TextBox22.Text <> "" Then
                writer.WriteLine(TextBox22.Text)
            End If
            If Me.TextBox23.Text <> "" Then
                writer.WriteLine(TextBox23.Text)
            End If
            If Me.TextBox24.Text <> "" Then
                writer.WriteLine(TextBox24.Text)
            End If
            If Me.TextBox25.Text <> "" Then
                writer.WriteLine(TextBox25.Text)
            End If
            If Me.TextBox26.Text <> "" Then
                writer.WriteLine(TextBox26.Text)
            End If
            If Me.TextBox27.Text <> "" Then
                writer.WriteLine(TextBox27.Text)
            End If
            If Me.TextBox28.Text <> "" Then
                writer.WriteLine(TextBox28.Text)
            End If
            If Me.TextBox29.Text <> "" Then
                writer.WriteLine(TextBox29.Text)
            End If
            If Me.TextBox30.Text <> "" Then
                writer.WriteLine(TextBox30.Text)
            End If
            If Me.TextBox31.Text <> "" Then
                writer.WriteLine(TextBox31.Text)
            End If
            If Me.TextBox32.Text <> "" Then
                writer.WriteLine(TextBox32.Text)
            End If
            If Me.TextBox33.Text <> "" Then
                writer.WriteLine(TextBox33.Text)
            End If
            If Me.TextBox34.Text <> "" Then
                writer.WriteLine(TextBox34.Text)
            End If
            If Me.TextBox35.Text <> "" Then
                writer.WriteLine(TextBox35.Text)
            End If
            If Me.TextBox36.Text <> "" Then
                writer.WriteLine(TextBox36.Text)
            End If
            If Me.TextBox37.Text <> "" Then
                writer.WriteLine(TextBox37.Text)
            End If
            If Me.TextBox38.Text <> "" Then
                writer.WriteLine(TextBox38.Text)
            End If
            If Me.TextBox39.Text <> "" Then
                writer.WriteLine(TextBox39.Text)
            End If
            If Me.TextBox40.Text <> "" Then
                writer.WriteLine(TextBox40.Text)
            End If
            writer.WriteLine("#extra")
            If Me.TextBox41.Text <> "" Then
                writer.WriteLine(TextBox41.Text)
            End If
            If Me.TextBox42.Text <> "" Then
                writer.WriteLine(TextBox42.Text)
            End If
            If Me.TextBox43.Text <> "" Then
                writer.WriteLine(TextBox43.Text)
            End If
            If Me.TextBox44.Text <> "" Then
                writer.WriteLine(TextBox44.Text)
            End If
            If Me.TextBox45.Text <> "" Then
                writer.WriteLine(TextBox45.Text)
            End If
            If Me.TextBox46.Text <> "" Then
                writer.WriteLine(TextBox46.Text)
            End If
            If Me.TextBox47.Text <> "" Then
                writer.WriteLine(TextBox47.Text)
            End If
            If Me.TextBox48.Text <> "" Then
                writer.WriteLine(TextBox48.Text)
            End If
            If Me.TextBox49.Text <> "" Then
                writer.WriteLine(TextBox49.Text)
            End If
            If Me.TextBox50.Text <> "" Then
                writer.WriteLine(TextBox50.Text)
            End If
            writer.WriteLine("!side")
            If Me.TextBox51.Text <> "" Then
                writer.WriteLine(TextBox51.Text)
            End If
            If Me.TextBox52.Text <> "" Then
                writer.WriteLine(TextBox52.Text)
            End If
            If Me.TextBox53.Text <> "" Then
                writer.WriteLine(TextBox53.Text)
            End If
            If Me.TextBox54.Text <> "" Then
                writer.WriteLine(TextBox54.Text)
            End If
            If Me.TextBox55.Text <> "" Then
                writer.WriteLine(TextBox55.Text)
            End If
            If Me.TextBox56.Text <> "" Then
                writer.WriteLine(TextBox56.Text)
            End If
            If Me.TextBox57.Text <> "" Then
                writer.WriteLine(TextBox57.Text)
            End If
            If Me.TextBox58.Text <> "" Then
                writer.WriteLine(TextBox58.Text)
            End If
            If Me.TextBox59.Text <> "" Then
                writer.WriteLine(TextBox59.Text)
            End If
            If Me.TextBox60.Text <> "" Then
                writer.WriteLine(TextBox60.Text)
            End If
            writer.WriteLine()
            writer.Close()

            Interaction.MsgBox(prompt & vbNewLine & "Deck File created")
        Catch ex As Exception
            Interaction.MsgBox("File cannot be created", MsgBoxStyle.ApplicationModal, Nothing)
        End Try







    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            If TextBox41.Text = "" And Label10.Text <= 10 Then
                Me.TextBox41.Text = Me.ListBox4.SelectedItem
                PictureBox41.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1

            ElseIf TextBox42.Text = "" And Label10.Text <= 10 Then

                Me.TextBox42.Text = Me.ListBox4.SelectedItem
                PictureBox42.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox43.Text = "" And Label10.Text <= 10 Then

                Me.TextBox43.Text = Me.ListBox4.SelectedItem
                PictureBox43.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox44.Text = "" And Label10.Text <= 10 Then

                Me.TextBox44.Text = Me.ListBox4.SelectedItem
                PictureBox44.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox45.Text = "" And Label10.Text <= 10 Then

                Me.TextBox45.Text = Me.ListBox4.SelectedItem
                PictureBox45.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox46.Text = "" And Label10.Text <= 10 Then

                Me.TextBox46.Text = Me.ListBox4.SelectedItem
                PictureBox46.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox47.Text = "" And Label10.Text <= 10 Then

                Me.TextBox47.Text = Me.ListBox4.SelectedItem
                PictureBox47.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox48.Text = "" And Label10.Text <= 10 Then

                Me.TextBox48.Text = Me.ListBox4.SelectedItem
                PictureBox48.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox49.Text = "" And Label10.Text <= 10 Then

                Me.TextBox49.Text = Me.ListBox4.SelectedItem
                PictureBox49.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox50.Text = "" And Label10.Text <= 10 Then

                Me.TextBox50.Text = Me.ListBox4.SelectedItem
                PictureBox50.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            End If
        Catch ex As Exception
            MsgBox("No more players cards can be assigned to extra deck")
        End Try
        


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            If TextBox51.Text = "" And Label10.Text <= 20 Then
                Me.TextBox51.Text = Me.ListBox4.SelectedItem
                PictureBox51.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1

            ElseIf TextBox52.Text = "" And Label10.Text <= 20 Then

                Me.TextBox52.Text = Me.ListBox4.SelectedItem
                PictureBox52.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox53.Text = "" And Label10.Text <= 20 Then

                Me.TextBox53.Text = Me.ListBox4.SelectedItem
                PictureBox53.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox54.Text = "" And Label10.Text <= 20 Then

                Me.TextBox54.Text = Me.ListBox4.SelectedItem
                PictureBox54.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox55.Text = "" And Label10.Text <= 20 Then

                Me.TextBox55.Text = Me.ListBox4.SelectedItem
                PictureBox55.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox56.Text = "" And Label10.Text <= 20 Then

                Me.TextBox56.Text = Me.ListBox4.SelectedItem
                PictureBox56.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox57.Text = "" And Label10.Text <= 20 Then

                Me.TextBox57.Text = Me.ListBox4.SelectedItem
                PictureBox57.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox58.Text = "" And Label10.Text <= 20 Then

                Me.TextBox58.Text = Me.ListBox4.SelectedItem
                PictureBox58.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox59.Text = "" And Label10.Text <= 20 Then

                Me.TextBox59.Text = Me.ListBox4.SelectedItem
                PictureBox59.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox60.Text = "" And Label10.Text <= 20 Then

                Me.TextBox60.Text = Me.ListBox4.SelectedItem
                PictureBox60.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox4.SelectedItem & ".jpg")
                Label10.Text += 1
            End If
        Catch ex As Exception
            MsgBox("No more players cards can be assigned to side deck")
        End Try

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            If TextBox41.Text = ListBox4.SelectedItem Then
                Me.TextBox41.Text = ""
                PictureBox41.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox42.Text = ListBox4.SelectedItem Then
                Me.TextBox42.Text = ""
                PictureBox42.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox43.Text = ListBox4.SelectedItem Then
                Me.TextBox43.Text = ""
                PictureBox43.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox44.Text = ListBox4.SelectedItem Then
                Me.TextBox44.Text = ""
                PictureBox44.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox45.Text = ListBox4.SelectedItem Then
                Me.TextBox45.Text = ""
                PictureBox45.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox46.Text = ListBox4.SelectedItem Then
                Me.TextBox46.Text = ""
                PictureBox46.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox47.Text = ListBox4.SelectedItem Then
                Me.TextBox47.Text = ""
                PictureBox47.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox48.Text = ListBox4.SelectedItem Then
                Me.TextBox48.Text = ""
                PictureBox48.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox49.Text = ListBox4.SelectedItem Then
                Me.TextBox49.Text = ""
                PictureBox49.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox50.Text = ListBox4.SelectedItem Then
                Me.TextBox50.Text = ""
                PictureBox50.ImageLocation = ""

                Label10.Text -= 1
            End If

        Catch ex As Exception
            MsgBox("No more player cards can be removed from extra deck")
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            If TextBox51.Text = ListBox4.SelectedItem Then
                Me.TextBox51.Text = ""
                PictureBox51.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox52.Text = ListBox4.SelectedItem Then
                Me.TextBox52.Text = ""
                PictureBox52.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox53.Text = ListBox4.SelectedItem Then
                Me.TextBox53.Text = ""
                PictureBox53.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox54.Text = ListBox4.SelectedItem Then
                Me.TextBox54.Text = ""
                PictureBox54.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox55.Text = ListBox4.SelectedItem Then
                Me.TextBox55.Text = ""
                PictureBox55.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox56.Text = ListBox4.SelectedItem Then
                Me.TextBox56.Text = ""
                PictureBox56.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox57.Text = ListBox4.SelectedItem Then
                Me.TextBox57.Text = ""
                PictureBox57.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox58.Text = ListBox4.SelectedItem Then
                Me.TextBox58.Text = ""
                PictureBox58.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox59.Text = ListBox4.SelectedItem Then
                Me.TextBox59.Text = ""
                PictureBox59.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox60.Text = ListBox4.SelectedItem Then
                Me.TextBox60.Text = ""
                PictureBox60.ImageLocation = ""

                Label10.Text -= 1
            End If

        Catch ex As Exception
            MsgBox("No more player cards can be removed from side deck")
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            If TextBox21.Text = ListBox3.SelectedItem Then
                Me.TextBox21.Text = ""
                PictureBox21.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox22.Text = ListBox3.SelectedItem Then
                Me.TextBox22.Text = ""
                PictureBox22.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox23.Text = ListBox3.SelectedItem Then
                Me.TextBox23.Text = ""
                PictureBox23.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox24.Text = ListBox3.SelectedItem Then
                Me.TextBox24.Text = ""
                PictureBox24.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox25.Text = ListBox3.SelectedItem Then
                Me.TextBox25.Text = ""
                PictureBox25.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox26.Text = ListBox3.SelectedItem Then
                Me.TextBox26.Text = ""
                PictureBox26.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox27.Text = ListBox3.SelectedItem Then
                Me.TextBox27.Text = ""
                PictureBox27.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox28.Text = ListBox3.SelectedItem Then
                Me.TextBox28.Text = ""
                PictureBox28.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox29.Text = ListBox3.SelectedItem Then
                Me.TextBox29.Text = ""
                PictureBox29.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox30.Text = ListBox3.SelectedItem Then
                Me.TextBox30.Text = ""
                PictureBox30.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox31.Text = ListBox3.SelectedItem Then
                Me.TextBox31.Text = ""
                PictureBox31.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox32.Text = ListBox3.SelectedItem Then
                Me.TextBox32.Text = ""
                PictureBox32.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox33.Text = ListBox3.SelectedItem Then
                Me.TextBox33.Text = ""
                PictureBox33.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox34.Text = ListBox3.SelectedItem Then
                Me.TextBox34.Text = ""
                PictureBox34.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox35.Text = ListBox3.SelectedItem Then
                Me.TextBox35.Text = ""
                PictureBox35.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox36.Text = ListBox3.SelectedItem Then
                Me.TextBox36.Text = ""
                PictureBox36.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox37.Text = ListBox3.SelectedItem Then
                Me.TextBox37.Text = ""
                PictureBox37.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox38.Text = ListBox3.SelectedItem Then
                Me.TextBox38.Text = ""
                PictureBox38.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox39.Text = ListBox3.SelectedItem Then
                Me.TextBox39.Text = ""
                PictureBox39.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            ElseIf TextBox40.Text = ListBox3.SelectedItem Then
                Me.TextBox40.Text = ""
                PictureBox40.ImageLocation = ""
                Label4.Text -= 1
                Label8.Text -= 1
            End If


        Catch ex As Exception
            MsgBox("No more opponent cards can be deleted from main deck")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If TextBox41.Text = "" And Label10.Text <= 10 Then
                Me.TextBox41.Text = Me.ListBox3.SelectedItem
                PictureBox41.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1

            ElseIf TextBox42.Text = "" And Label10.Text <= 10 Then

                Me.TextBox42.Text = Me.ListBox3.SelectedItem
                PictureBox42.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox43.Text = "" And Label10.Text <= 10 Then

                Me.TextBox43.Text = Me.ListBox3.SelectedItem
                PictureBox43.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox44.Text = "" And Label10.Text <= 10 Then

                Me.TextBox44.Text = Me.ListBox3.SelectedItem
                PictureBox44.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox45.Text = "" And Label10.Text <= 10 Then

                Me.TextBox45.Text = Me.ListBox3.SelectedItem
                PictureBox45.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox46.Text = "" And Label10.Text <= 10 Then

                Me.TextBox46.Text = Me.ListBox3.SelectedItem
                PictureBox46.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox47.Text = "" And Label10.Text <= 10 Then

                Me.TextBox47.Text = Me.ListBox3.SelectedItem
                PictureBox47.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox48.Text = "" And Label10.Text <= 10 Then

                Me.TextBox48.Text = Me.ListBox3.SelectedItem
                PictureBox48.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox49.Text = "" And Label10.Text <= 10 Then

                Me.TextBox49.Text = Me.ListBox3.SelectedItem
                PictureBox49.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox50.Text = "" And Label10.Text <= 10 Then

                Me.TextBox50.Text = Me.ListBox3.SelectedItem
                PictureBox50.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            End If
        Catch ex As Exception
            MsgBox("No more opponent cards can be assigned to extra deck")
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If TextBox41.Text = ListBox3.SelectedItem Then
                Me.TextBox41.Text = ""
                PictureBox41.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox42.Text = ListBox3.SelectedItem Then
                Me.TextBox42.Text = ""
                PictureBox42.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox43.Text = ListBox3.SelectedItem Then
                Me.TextBox43.Text = ""
                PictureBox43.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox44.Text = ListBox3.SelectedItem Then
                Me.TextBox44.Text = ""
                PictureBox44.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox45.Text = ListBox3.SelectedItem Then
                Me.TextBox45.Text = ""
                PictureBox45.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox46.Text = ListBox3.SelectedItem Then
                Me.TextBox46.Text = ""
                PictureBox46.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox47.Text = ListBox3.SelectedItem Then
                Me.TextBox47.Text = ""
                PictureBox47.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox48.Text = ListBox3.SelectedItem Then
                Me.TextBox48.Text = ""
                PictureBox48.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox49.Text = ListBox3.SelectedItem Then
                Me.TextBox49.Text = ""
                PictureBox49.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox50.Text = ListBox3.SelectedItem Then
                Me.TextBox50.Text = ""
                PictureBox50.ImageLocation = ""

                Label10.Text -= 1
            End If

        Catch ex As Exception
            MsgBox("No more opponent cards can be removed from extra deck")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If TextBox51.Text = "" And Label10.Text <= 20 Then
                Me.TextBox51.Text = Me.ListBox3.SelectedItem
                PictureBox51.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1

            ElseIf TextBox52.Text = "" And Label10.Text <= 20 Then

                Me.TextBox52.Text = Me.ListBox3.SelectedItem
                PictureBox52.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox53.Text = "" And Label10.Text <= 20 Then

                Me.TextBox53.Text = Me.ListBox3.SelectedItem
                PictureBox53.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox54.Text = "" And Label10.Text <= 20 Then

                Me.TextBox54.Text = Me.ListBox3.SelectedItem
                PictureBox54.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox55.Text = "" And Label10.Text <= 20 Then

                Me.TextBox55.Text = Me.ListBox3.SelectedItem
                PictureBox55.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox56.Text = "" And Label10.Text <= 20 Then

                Me.TextBox56.Text = Me.ListBox3.SelectedItem
                PictureBox56.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox57.Text = "" And Label10.Text <= 20 Then

                Me.TextBox57.Text = Me.ListBox3.SelectedItem
                PictureBox57.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox58.Text = "" And Label10.Text <= 20 Then

                Me.TextBox58.Text = Me.ListBox3.SelectedItem
                PictureBox58.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox59.Text = "" And Label10.Text <= 20 Then

                Me.TextBox59.Text = Me.ListBox3.SelectedItem
                PictureBox59.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            ElseIf TextBox60.Text = "" And Label10.Text <= 20 Then

                Me.TextBox60.Text = Me.ListBox3.SelectedItem
                PictureBox60.ImageLocation = (Form1.GameDirectoryBox.Text & "\pics\thumbnail\" & Me.ListBox3.SelectedItem & ".jpg")
                Label10.Text += 1
            End If
        Catch ex As Exception
            MsgBox("No more opponent cards can be assigned to side deck")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            If TextBox51.Text = ListBox3.SelectedItem Then
                Me.TextBox51.Text = ""
                PictureBox51.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox52.Text = ListBox3.SelectedItem Then
                Me.TextBox52.Text = ""
                PictureBox52.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox53.Text = ListBox3.SelectedItem Then
                Me.TextBox53.Text = ""
                PictureBox53.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox54.Text = ListBox3.SelectedItem Then
                Me.TextBox54.Text = ""
                PictureBox54.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox55.Text = ListBox3.SelectedItem Then
                Me.TextBox55.Text = ""
                PictureBox55.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox56.Text = ListBox3.SelectedItem Then
                Me.TextBox56.Text = ""
                PictureBox56.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox57.Text = ListBox3.SelectedItem Then
                Me.TextBox57.Text = ""
                PictureBox57.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox58.Text = ListBox3.SelectedItem Then
                Me.TextBox58.Text = ""
                PictureBox58.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox59.Text = ListBox3.SelectedItem Then
                Me.TextBox59.Text = ""
                PictureBox59.ImageLocation = ""

                Label10.Text -= 1
            ElseIf TextBox60.Text = ListBox3.SelectedItem Then
                Me.TextBox60.Text = ""
                PictureBox60.ImageLocation = ""

                Label10.Text -= 1
            End If

        Catch ex As Exception
            MsgBox("No more opponent cards can be removed from side deck")
        End Try
    End Sub

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        Try
            OpenFileDialog1.Filter = "Deck Files (*.ydk)|*.ydk|All Files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1


            If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                Dim file As New System.IO.StreamReader(OpenFileDialog1.FileName)
                TextBox61.Text = OpenFileDialog1.FileName
                RichTextBox1.Text = file.ReadToEnd
                file.Close()

                Interaction.MsgBox("File loaded", MsgBoxStyle.ApplicationModal, Nothing)
            End If

        Catch ex As Exception
            Interaction.MsgBox("File cannot be loaded", MsgBoxStyle.ApplicationModal, Nothing)
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            SaveFileDialog1.Filter = "Deck Files (*.ydk)|*.ydk|All Files (*.*)|*.*"
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

    Private Sub AIDeckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AIDeckToolStripMenuItem.Click
        Try
            Dim prompt As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\NewAI.ydk")
            Interaction.MsgBox(prompt, MsgBoxStyle.ApplicationModal, Nothing)
            If Not File.Exists(prompt) Then
                File.Create(prompt).Dispose()
            End If
            Dim writer As New StreamWriter(prompt)
            writer.WriteLine("#created by...")
            writer.WriteLine("#main")

            If Me.TextBox1.Text <> "" Then
                writer.WriteLine(TextBox1.Text)
            End If

            If Me.TextBox2.Text <> "" Then
                writer.WriteLine(TextBox2.Text)
            End If

            If Me.TextBox3.Text <> "" Then
                writer.WriteLine(TextBox3.Text)
            End If

            If Me.TextBox4.Text <> "" Then
                writer.WriteLine(TextBox4.Text)
            End If

            If Me.TextBox5.Text <> "" Then
                writer.WriteLine(TextBox5.Text)
            End If

            If Me.TextBox6.Text <> "" Then
                writer.WriteLine(TextBox6.Text)
            End If
            If Me.TextBox7.Text <> "" Then
                writer.WriteLine(TextBox7.Text)
            End If
            If Me.TextBox8.Text <> "" Then
                writer.WriteLine(TextBox8.Text)
            End If
            If Me.TextBox9.Text <> "" Then
                writer.WriteLine(TextBox9.Text)
            End If
            If Me.TextBox10.Text <> "" Then
                writer.WriteLine(TextBox10.Text)
            End If
            If Me.TextBox11.Text <> "" Then
                writer.WriteLine(TextBox11.Text)
            End If
            If Me.TextBox12.Text <> "" Then
                writer.WriteLine(TextBox12.Text)
            End If
            If Me.TextBox13.Text <> "" Then
                writer.WriteLine(TextBox3.Text)
            End If
            If Me.TextBox14.Text <> "" Then
                writer.WriteLine(TextBox14.Text)
            End If
            If Me.TextBox15.Text <> "" Then
                writer.WriteLine(TextBox15.Text)
            End If
            If Me.TextBox16.Text <> "" Then
                writer.WriteLine(TextBox16.Text)
            End If
            If Me.TextBox17.Text <> "" Then
                writer.WriteLine(TextBox17.Text)
            End If
            If Me.TextBox18.Text <> "" Then
                writer.WriteLine(TextBox18.Text)
            End If
            If Me.TextBox19.Text <> "" Then
                writer.WriteLine(TextBox19.Text)
            End If
            If Me.TextBox20.Text <> "" Then
                writer.WriteLine(TextBox20.Text)
            End If
            If Me.TextBox21.Text <> "" Then
                writer.WriteLine(TextBox21.Text)
            End If
            If Me.TextBox22.Text <> "" Then
                writer.WriteLine(TextBox22.Text)
            End If
            If Me.TextBox23.Text <> "" Then
                writer.WriteLine(TextBox23.Text)
            End If
            If Me.TextBox24.Text <> "" Then
                writer.WriteLine(TextBox24.Text)
            End If
            If Me.TextBox25.Text <> "" Then
                writer.WriteLine(TextBox25.Text)
            End If
            If Me.TextBox26.Text <> "" Then
                writer.WriteLine(TextBox26.Text)
            End If
            If Me.TextBox27.Text <> "" Then
                writer.WriteLine(TextBox27.Text)
            End If
            If Me.TextBox28.Text <> "" Then
                writer.WriteLine(TextBox28.Text)
            End If
            If Me.TextBox29.Text <> "" Then
                writer.WriteLine(TextBox29.Text)
            End If
            If Me.TextBox30.Text <> "" Then
                writer.WriteLine(TextBox30.Text)
            End If
            If Me.TextBox31.Text <> "" Then
                writer.WriteLine(TextBox31.Text)
            End If
            If Me.TextBox32.Text <> "" Then
                writer.WriteLine(TextBox32.Text)
            End If
            If Me.TextBox33.Text <> "" Then
                writer.WriteLine(TextBox33.Text)
            End If
            If Me.TextBox34.Text <> "" Then
                writer.WriteLine(TextBox34.Text)
            End If
            If Me.TextBox35.Text <> "" Then
                writer.WriteLine(TextBox35.Text)
            End If
            If Me.TextBox36.Text <> "" Then
                writer.WriteLine(TextBox36.Text)
            End If
            If Me.TextBox37.Text <> "" Then
                writer.WriteLine(TextBox37.Text)
            End If
            If Me.TextBox38.Text <> "" Then
                writer.WriteLine(TextBox38.Text)
            End If
            If Me.TextBox39.Text <> "" Then
                writer.WriteLine(TextBox39.Text)
            End If
            If Me.TextBox40.Text <> "" Then
                writer.WriteLine(TextBox40.Text)
            End If
            writer.WriteLine("#extra")
            If Me.TextBox41.Text <> "" Then
                writer.WriteLine(TextBox41.Text)
            End If
            If Me.TextBox42.Text <> "" Then
                writer.WriteLine(TextBox42.Text)
            End If
            If Me.TextBox43.Text <> "" Then
                writer.WriteLine(TextBox43.Text)
            End If
            If Me.TextBox44.Text <> "" Then
                writer.WriteLine(TextBox44.Text)
            End If
            If Me.TextBox45.Text <> "" Then
                writer.WriteLine(TextBox45.Text)
            End If
            If Me.TextBox46.Text <> "" Then
                writer.WriteLine(TextBox46.Text)
            End If
            If Me.TextBox47.Text <> "" Then
                writer.WriteLine(TextBox47.Text)
            End If
            If Me.TextBox48.Text <> "" Then
                writer.WriteLine(TextBox48.Text)
            End If
            If Me.TextBox49.Text <> "" Then
                writer.WriteLine(TextBox49.Text)
            End If
            If Me.TextBox50.Text <> "" Then
                writer.WriteLine(TextBox50.Text)
            End If
            writer.WriteLine("!side")
            writer.WriteLine()
            writer.Close()
            Interaction.MsgBox(prompt & vbNewLine & "AI Deck file created", MsgBoxStyle.ApplicationModal, Nothing)
        Catch ex As Exception
            Interaction.MsgBox("File cannot be created", MsgBoxStyle.ApplicationModal, Nothing)
        End Try
    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        Try
            SaveFileDialog1.Filter = "Deck Files (*.ydk)|*.ydk|All Files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            Me.SaveFileDialog1.ShowDialog()
            My.Computer.FileSystem.CopyFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\New.ydk"), Me.SaveFileDialog1.FileName, True)
            MsgBox("File has been succesfully exported")
        Catch ex As Exception
            MsgBox("File has not been exported")
        End Try
    End Sub

    Private Sub ExportAIDeckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAIDeckToolStripMenuItem.Click
        Try
            SaveFileDialog1.Filter = "Deck Files (*.ydk)|*.ydk|All Files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            Me.SaveFileDialog1.ShowDialog()
            My.Computer.FileSystem.CopyFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\NewAI.ydk"), Me.SaveFileDialog1.FileName, True)
            MsgBox("File has been succesfully exported")
        Catch ex As Exception
            MsgBox("File has not been exported")
        End Try
    End Sub
End Class