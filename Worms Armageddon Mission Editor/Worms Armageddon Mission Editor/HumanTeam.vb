Imports System.IO

Public Class HumanTeam
    Inherits Mission
    Public Shared Property HumanTeam As String
    Public Shared Property NumberOfWorms As String
    Public Shared Property Ammo As String
    Public Shared Property Weapon1 As String
    Public Shared Property Weapon2 As String
    Public Shared Property Weapon3 As String
    Public Shared Property Weapon4 As String
    Public Shared Property Weapon5 As String
    Public Shared Property Delay1 As String
    Public Shared Property Delay2 As String
    Public Shared Property Delay3 As String
    Public Shared Property Delay4 As String
    Public Shared Property Delay5 As String
    Public Shared Worm1a, worm1b, worm1c, worm1d As String
    Public Shared Worm2a, worm2b, worm2c, worm2d As String
    Public Shared Worm3a, worm3b, worm3c, worm3d As String
    Public Shared Worm4a, worm4b, worm4c, worm4d As String
    Public Shared Energy As String

    Public Shared Sub LoadHmTeam()
        stream.ReadLine()
        HumanTeam = stream.ReadLine
        If HumanTeam.Contains("[HumanTeam]") Then
            Form1.RichTextBox1.AppendText(HumanTeam & vbNewLine)
        End If
        NumberOfWorms = stream.ReadLine
        If NumberOfWorms.Contains("NumberOfWorms") Then
            Form1.NumericUpDown13.Text = NumberOfWorms.Split("=").Last
            Form1.RichTextBox1.AppendText(NumberOfWorms & vbNewLine)
        End If
        Weapon1 = stream.ReadLine
        If Weapon1.Contains("Ammo_") Then
            Form1.ListView1.Items.Add(Weapon1.Split("_").Last)
            Form1.RichTextBox1.AppendText(Weapon1 & vbNewLine)
        End If
        Weapon2 = stream.ReadLine
        If Weapon2.Contains("Ammo_") Then
            Form1.ListView1.Items.Add(Weapon2.Split("_").Last)
            Form1.RichTextBox1.AppendText(Weapon2 & vbNewLine)
        ElseIf Weapon2.Contains("Delay_") Then
            Form1.ListView1.Items.Item(0).SubItems.Add(Weapon2.Split("_").Last)
            Form1.RichTextBox1.AppendText(Weapon2 & vbNewLine)
        End If
        Weapon3 = stream.ReadLine
        If Weapon3.Contains("Ammo_") Then
            Form1.ListView1.Items.Add(Weapon3.Split("_").Last)
            Form1.RichTextBox1.AppendText(Weapon3 & vbNewLine)
        ElseIf Weapon3.Contains("Delay_") Then
            Form1.ListView1.Items.Item(1).SubItems.Add(Weapon3.Split("_").Last)
            Form1.RichTextBox1.AppendText(Weapon3 & vbNewLine)
        ElseIf Weapon3.Contains("Worm1_Energy") Then
            Form1.TextBox16.Text = Weapon3.Split("=").Last
            Form1.RichTextBox1.AppendText(Weapon3 & vbNewLine)
        End If
        Weapon4 = stream.ReadLine
        If Weapon4.Contains("Ammo_") Then
            Form1.ListView1.Items.Add(Weapon4.Split("_").Last)
            Form1.RichTextBox1.AppendText(Weapon4 & vbNewLine)
        ElseIf Weapon4.Contains("Delay_") Then
            Form1.ListView1.Items.Item(1).SubItems.Add(Weapon4.Split("_").Last)
            Form1.RichTextBox1.AppendText(Weapon4 & vbNewLine)
        ElseIf Weapon4.Contains("Worm1_DeseasePoints") Then
            Form1.TextBox10.Text = Weapon4.Split("=").Last
            Form1.RichTextBox1.AppendText(Weapon4 & vbNewLine)
        End If
        Weapon5 = stream.ReadLine
        If Weapon5.Contains("Ammo_") Then
            Form1.ListView1.Items.Add(Weapon5.Split("_").Last)
            Form1.RichTextBox1.AppendText(Weapon5 & vbNewLine)
        ElseIf Weapon5.Contains("Delay_") Then
            Form1.ListView1.Items.Item(2).SubItems.Add(Weapon5.Split("_").Last)
            Form1.RichTextBox1.AppendText(Weapon5 & vbNewLine)
        ElseIf Weapon5.Contains("Worm1_ArtileryMode") Then
            If Weapon5.Split("=").Last = 1 Then
                Form1.CheckBox14.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(Weapon5 & vbNewLine)
            Else
                Form1.CheckBox14.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(Weapon5 & vbNewLine)
            End If
        ElseIf Weapon5.Contains("Worm1_Energy") Then
            Form1.TextBox16.Text = Weapon5.Split("=").Last
            Form1.RichTextBox1.AppendText(Weapon5 & vbNewLine)
        End If
        Delay1 = stream.ReadLine
        If Delay1.Contains("Delay_") Then
            Form1.ListView1.Items.Item(0).SubItems.Add(Delay1.Split("_").Last)
            Form1.RichTextBox1.AppendText(Delay1 & vbNewLine)
        ElseIf Delay1.Contains("Worm1_DeseasePoints") Then
            Form1.TextBox10.Text = Delay1.Split("=").Last
            Form1.RichTextBox1.AppendText(Delay1 & vbNewLine)
        ElseIf Delay1.Contains("Worm1_PlaceWorm") Then
            If Delay1.Split("=").Last = 1 Then
                Form1.CheckBox34.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(Delay1 & vbNewLine)
            Else
                Form1.CheckBox34.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(Delay1 & vbNewLine)
            End If
        End If
        Delay2 = stream.ReadLine
        If Delay2.Contains("Delay_") Then
            Form1.ListView1.Items.Item(1).SubItems.Add(Delay2.Split("_").Last)
            Form1.RichTextBox1.AppendText(Delay2 & vbNewLine)
        ElseIf Delay2.Contains("Worm1_ArtileryMode") Then
            If Delay2.Split("=").Last = 1 Then
                Form1.CheckBox14.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(Weapon5 & vbNewLine)
            Else
                Form1.CheckBox14.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(Weapon5 & vbNewLine)
            End If
        ElseIf Delay2.Contains("Worm1_XPosition") Then
            Form1.TextBox18.Text = Delay2.Split("=").Last
            Form1.RichTextBox1.AppendText(Delay2 & vbNewLine)
        End If
        Delay3 = stream.ReadLine
        If Delay3.Contains("Delay_") Then
            Form1.ListView1.Items.Item(2).SubItems.Add(Delay3.Split("_").Last)
            Form1.RichTextBox1.AppendText(Delay3 & vbNewLine)
        ElseIf Delay3.Contains("Worm1_YPosition") Then
            Form1.TextBox19.Text = Delay3.Split("=").Last
            Form1.RichTextBox1.AppendText(Delay3 & vbNewLine)
        ElseIf Delay3.Contains("Worm1_PlaceWorm") Then
            If Delay3.Split("=").Last = 1 Then
                Form1.CheckBox34.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(Delay3 & vbNewLine)
            Else
                Form1.CheckBox34.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(Delay3 & vbNewLine)
            End If
        End If
        Delay4 = stream.ReadLine
        If Delay4.Contains("Delay_") Then
            Form1.ListView1.Items.Item(3).SubItems.Add(Delay4.Split("_").Last)
            Form1.RichTextBox1.AppendText(Delay4 & vbNewLine)
        ElseIf Delay4.Contains("Worm1_Vital") Then
            If Delay4.Split("=").Last = 1 Then
                Form1.CheckBox16.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(Delay4 & vbNewLine)
            Else
                Form1.CheckBox16.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(Delay4 & vbNewLine)
            End If
        ElseIf Delay4.Contains("Worm1_XPosition") Then
            Form1.TextBox18.Text = Delay4.Split("=").Last
            Form1.RichTextBox1.AppendText(Delay4 & vbNewLine)
        End If
        Delay5 = stream.ReadLine
        If Delay5.Contains("Delay_") Then
            Form1.ListView1.Items.Item(4).SubItems.Add(Delay5.Split("_").Last)
            Form1.RichTextBox1.AppendText(Delay5 & vbNewLine)
        ElseIf Delay5.Contains("Worm1_YPosition") Then
            Form1.TextBox19.Text = Delay5.Split("=").Last
            Form1.RichTextBox1.AppendText(Delay5 & vbNewLine)
        ElseIf Delay5.Contains("Worm2_Energy") Then
            Form1.TextBox17.Text = Delay5.Split("=").Last
            Form1.RichTextBox1.AppendText(Delay5 & vbNewLine)
        End If
        Worm1a = stream.ReadLine
        If Worm1a.Contains("Worm2_DeseasePoints") Then
            Form1.TextBox11.Text = Worm1a.Split("=").Last
            Form1.RichTextBox1.AppendText(Worm1a & vbNewLine)
        End If
        worm1b = stream.ReadLine
        If worm1b.Contains("Worm2_ArtileryMode") Then
            If worm1b.Split("=").Last = 1 Then
                Form1.CheckBox15.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(worm1b & vbNewLine)
            Else
                Form1.CheckBox15.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(worm1b & vbNewLine)
            End If
        End If
        worm1c = stream.ReadLine
        If worm1c.Contains("Worm2_PlaceWorm") Then
            If worm1c.Split("=").Last = 1 Then
                Form1.CheckBox35.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(worm1c & vbNewLine)
            Else
                Form1.CheckBox35.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(worm1c & vbNewLine)
            End If
        End If
        worm1d = stream.ReadLine
        If worm1d.Contains("Worm2_XPosition") Then
            Form1.TextBox17.Text = worm1d.Split("=").Last
            Form1.RichTextBox1.AppendText(worm1d & vbNewLine)
        End If

        Worm2a = stream.ReadLine
        If Worm2a.Contains("Worm2_YPosition") Then
            Form1.TextBox21.Text = Worm2a.Split("=").Last
            Form1.RichTextBox1.AppendText(Worm2a & vbNewLine)
        End If
    End Sub

    Public Shared Sub LoadHuman()

        If LineOfText.Contains("[HumanTeam]") Then
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("NumberOfWorms") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                NumberOfWorms = aryTextFile(i)
                Form1.NumericUpDown13.Text = NumberOfWorms

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("Ammo") Then
            aryTextFile2 = LineOfText.Split("_")

            For Mission.i = 0 To UBound(aryTextFile2)
                If Not LineOfText.Contains("Weapon") Then


                End If

            Next
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("Delay") Then
            aryTextFile2 = LineOfText.Split("_")

            For Mission.i = 0 To UBound(aryTextFile2)
                If Not LineOfText.Contains("Weapon") Then
                    Delay1 = LineOfText

                End If
            Next

            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.EndsWith("Energy") Then
            aryTextFile2 = LineOfText.Split("_")

            For Mission.i = 0 To UBound(aryTextFile2)

                Energy = LineOfText


            Next

            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If

    End Sub

End Class
