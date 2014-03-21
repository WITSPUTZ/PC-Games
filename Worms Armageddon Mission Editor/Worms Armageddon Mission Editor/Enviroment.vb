Public Class Enviroment
    Inherits Mission
    Public Shared Property Eviromets As String
    Public Shared Property LandFile As String
    Public Shared Property Wind As String
    Public Shared Property FixedWind As String
    Public Shared Property Friction As String
    Public Shared Property IndestructableBorder As String
    Public Shared Property IndestructableLandscape As String
    Public Shared Property LogicRandomSeed As String
    Public Shared Property AlliedGroupToGoFirst As String
    Public Shared Property Sound As String
    Public Shared Property Teams As String
    Public Shared Property TeamsInMission As String
    Public Shared Sub LoadEnvr()
        Eviromets = stream.ReadLine
        If Eviromets.Contains("[Enviroment]") Then
            Form1.RichTextBox1.AppendText(Eviromets & vbNewLine)
        End If
        LandFile = stream.ReadLine

        If LandFile.Contains("LandFile") Then
            Form1.Label8.Text = LandFile.Split("=").Last
            Form1.RichTextBox1.AppendText(LandFile & vbNewLine)
        End If
        Wind = stream.ReadLine

        If Wind.Contains("Wind") Then
            Form1.TextBox2.Text = Wind.Split("=").Last
            Form1.RichTextBox1.AppendText(Wind & vbNewLine)
        End If
        FixedWind = stream.ReadLine
        If FixedWind.Contains("FixedWind") Then
            If FixedWind.Split("=").Last = 1 Then
                Form1.CheckBox3.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(FixedWind & vbNewLine)
            Else
                Form1.CheckBox3.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(FixedWind & vbNewLine)
            End If
        End If
        Friction = stream.ReadLine

        If Friction.Contains("Friction") Then
            Form1.TextBox3.Text = Friction.Split("=").Last
            Form1.RichTextBox1.AppendText(Friction & vbNewLine)
        End If

        IndestructableBorder = stream.ReadLine
        If IndestructableBorder.Contains("IndestructableBorder") Then
            If IndestructableBorder.Split("=").Last = 1 Then
                Form1.CheckBox1.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(IndestructableBorder & vbNewLine)
            Else
                Form1.CheckBox1.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(IndestructableBorder & vbNewLine)
            End If
        End If
        IndestructableLandscape = stream.ReadLine
        If IndestructableLandscape.Contains("IndestructableLandscape") Then
            If IndestructableLandscape.Split("=").Last = 1 Then
                Form1.CheckBox2.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(IndestructableLandscape & vbNewLine)
            Else
                Form1.CheckBox2.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(IndestructableLandscape & vbNewLine)
            End If
        End If
        LogicRandomSeed = stream.ReadLine
        If LogicRandomSeed.Contains("LogicRandomSeed") Then
            Form1.RichTextBox1.AppendText(LogicRandomSeed & vbNewLine)
        End If
        AlliedGroupToGoFirst = stream.ReadLine
        If AlliedGroupToGoFirst.Contains("AlliedGroupToGoFirst") Then
            If AlliedGroupToGoFirst.Split("=").Last = 1 Then
                Form1.CheckBox11.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(AlliedGroupToGoFirst & vbNewLine)
            Else
                Form1.CheckBox11.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(AlliedGroupToGoFirst & vbNewLine)
            End If
        End If
        Sound = stream.ReadLine

        If Sound.Contains("Sound") Then
            Form1.NumericUpDown2.Text = Sound.Split("=").Last
            Form1.RichTextBox1.AppendText(Sound & vbNewLine)
        End If
        stream.ReadLine()

        Teams = stream.ReadLine
        If Teams.Contains("[Teams]") Then
            Form1.RichTextBox1.AppendText(Teams & vbNewLine)
        End If
        TeamsInMission = stream.ReadLine

        If TeamsInMission.Contains("TeamsInMission") Then
            Form1.NumericUpDown7.Text = TeamsInMission.Split("=").Last
            Form1.RichTextBox1.AppendText(TeamsInMission & vbNewLine)
        End If

    End Sub


    Public Shared Sub LoadEnv()
        If LineOfText.Contains("[Enviroment]") Then
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("LandFile") Then
            LandFile = LineOfText
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("Wind") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                Enviroment.Wind = aryTextFile(i)
                Form1.TextBox2.Text = Enviroment.Wind

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("FixedWind") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                Enviroment.FixedWind = aryTextFile(i)
                If Enviroment.FixedWind = "1" Then
                    Form1.CheckBox3.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox3.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("Friction") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                Enviroment.Friction = aryTextFile(i)
                Form1.TextBox3.Text = Enviroment.Friction

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("IndestructableBorder") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                Enviroment.IndestructableBorder = aryTextFile(i)
                If Enviroment.IndestructableBorder = "1" Then
                    Form1.CheckBox1.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox1.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("IndestructableLandscape") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                Enviroment.IndestructableLandscape = aryTextFile(i)
                If Enviroment.IndestructableLandscape = "1" Then
                    Form1.CheckBox2.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox2.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("LogicRandomSeed") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                Enviroment.LogicRandomSeed = aryTextFile(i)


            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("AlliedGroupToGoFirst") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                Enviroment.AlliedGroupToGoFirst = aryTextFile(i)
                If Enviroment.AlliedGroupToGoFirst = "0" Then
                    Form1.CheckBox11.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox11.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("Sound=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                Enviroment.Sound = aryTextFile(i)
                Form1.NumericUpDown2.Text = Enviroment.Sound

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If LineOfText.Contains("[Teams]") Then
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("Teams") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                TeamsInMission = aryTextFile(i)
                Form1.NumericUpDown7.Text = TeamsInMission

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If

    End Sub

    Public Shared Sub SaveEnviroment()
        writer.WriteLine()
        writer.WriteLine("[Enviroment]")
        Form1.RichTextBox1.AppendText("[Enviroment]" & vbNewLine)
        If LandFile <> "" Then
            writer.WriteLine("LandFile=data\land.dat")
            LineOfText = "LandFile=data\land.dat"
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If Wind <> "" Then
            Wind = Form1.TextBox2.Text
            writer.WriteLine("Wind=" & Wind)
            LineOfText = "Wind=" & Wind
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If FixedWind <> "" Then
            If Form1.CheckBox3.CheckState = CheckState.Checked Then
                FixedWind = 1
                writer.WriteLine("FixedWind=" & FixedWind)
                LineOfText = "FixedWind=" & FixedWind
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox3.CheckState = CheckState.Unchecked Then
                FixedWind = 0
                writer.WriteLine("FixedWind=" & FixedWind)
                LineOfText = "FixedWind=" & FixedWind
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If Friction <> "" Then
            Friction = Form1.TextBox3.Text
            writer.WriteLine("Friction=" & Friction)
            LineOfText = "Friction=" & Friction
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If IndestructableBorder <> "" Then
            If Form1.CheckBox1.CheckState = CheckState.Checked Then
                IndestructableBorder = 1
                writer.WriteLine("IndestructableBorder=" & IndestructableBorder)
                LineOfText = "IndestructableBorder=" & IndestructableBorder
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox1.CheckState = CheckState.Unchecked Then
                IndestructableBorder = 0
                writer.WriteLine("IndestructableBorder=" & IndestructableBorder)
                LineOfText = "IndestructableBorder=" & IndestructableBorder
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If IndestructableLandscape <> "" Then
            If Form1.CheckBox2.CheckState = CheckState.Checked Then
                IndestructableLandscape = 1
                writer.WriteLine("IndestructableLandscape=" & IndestructableLandscape)
                LineOfText = "IndestructableLandscape=" & IndestructableLandscape
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox2.CheckState = CheckState.Unchecked Then
                IndestructableLandscape = 0
                writer.WriteLine("IndestructableLandscape=" & IndestructableLandscape)
                LineOfText = "IndestructableLandscape=" & IndestructableLandscape
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If LogicRandomSeed <> "" Then
            writer.WriteLine(LogicRandomSeed)
            LineOfText = LogicRandomSeed
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If AlliedGroupToGoFirst <> "" Then
            If Form1.CheckBox11.CheckState = CheckState.Checked Then
                AlliedGroupToGoFirst = 1
                writer.WriteLine("AlliedGroupToGoFirst=" & AlliedGroupToGoFirst)
                LineOfText = "AlliedGroupToGoFirst=" & AlliedGroupToGoFirst
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox11.CheckState = CheckState.Unchecked Then
                IndestructableLandscape = 0
                writer.WriteLine(AlliedGroupToGoFirst)
                LineOfText = AlliedGroupToGoFirst
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If Sound <> "" Then
            Sound = Form1.NumericUpDown2.Value
            writer.WriteLine("Sound=" & Sound)
            LineOfText = "Sound=" & Sound
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
    End Sub
End Class
