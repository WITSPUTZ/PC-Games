Public Class Options
    Inherits Mission
    Public Shared Optiones As String
    Public Shared Property FallDamage As String
    Public Shared Property DisplayRoundTime As String
    Public Shared Property EnableActionReplay As String
    Public Shared Property LandRetreatTime As String
    Public Shared Property RopeRetreatTime As String
    Public Shared Property RoundTime As String
    Public Shared Property TurnTime As String
    Public Shared Property MineFuse As String
    Public Shared Property WeaponCrateDrops As String
    Public Shared Property HealthCrateDrops As String
    Public Shared Property UtilityCrateDrops As String
    Public Shared Property HealthCrateEnergy As String
    Public Shared Property EnableSecretWeapons As String
    Public Shared Property SuddenDeathWaterRise As String
    Public Shared Property SuddenDeathWormDamage As String
    Public Shared Property SuddenDeathType As String
    Public Shared Property PauseBetweenTurns As String
    Public Shared Property GirderRadius As String
    Public Shared Property WormSelect As String
    Public Shared Property JetPackTimeLimit As String
    Public Shared Property WeaponsDontEndTurn As String
    Public Shared Property PauseTimerWhileFiring As String
    Public Shared Property LossOfControlDoesntEndTurn As String
    Public Shared Property Score As String
    Public Shared Property Sheep As String
    Public Shared Property TurnEndFinishesGame As String
    Public Shared Property ObjectType As String

    Public Shared Sub LoadOpt()
        Optiones = stream.ReadLine
        If Optiones.Contains("[Options]") Then
            Form1.RichTextBox1.AppendText(Optiones & vbNewLine)
        End If
        FallDamage = stream.ReadLine

        If FallDamage.Contains("FallDamage") Then
            Form1.NumericUpDown3.Text = FallDamage.Split("=").Last
            Form1.RichTextBox1.AppendText(FallDamage & vbNewLine)
        End If
        DisplayRoundTime = stream.ReadLine
        If DisplayRoundTime.Contains("DisplayRoundTime") Then
            If DisplayRoundTime.Split("=").Last = 1 Then
                Form1.CheckBox8.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(DisplayRoundTime & vbNewLine)
            Else
                Form1.CheckBox8.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(DisplayRoundTime & vbNewLine)
            End If
        End If
        EnableActionReplay = stream.ReadLine
        If EnableActionReplay.Contains("EnableActionReplay") Then
            If EnableActionReplay.Split("=").Last = 1 Then
                Form1.CheckBox12.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(EnableActionReplay & vbNewLine)
            Else
                Form1.CheckBox12.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(EnableActionReplay & vbNewLine)
            End If
        End If
        LandRetreatTime = stream.ReadLine

        If LandRetreatTime.Contains("LandRetreatTime") Then
            Form1.NumericUpDown8.Text = LandRetreatTime.Split("=").Last
            Form1.RichTextBox1.AppendText(LandRetreatTime & vbNewLine)
        End If
        RopeRetreatTime = stream.ReadLine

        If RopeRetreatTime.Contains("RopeRetreatTime") Then
            Form1.NumericUpDown9.Text = RopeRetreatTime.Split("=").Last
            Form1.RichTextBox1.AppendText(RopeRetreatTime & vbNewLine)
        End If

        RoundTime = stream.ReadLine

        If RoundTime.Contains("RoundTime") Then
            Form1.NumericUpDown10.Text = RoundTime.Split("=").Last
            Form1.RichTextBox1.AppendText(RoundTime & vbNewLine)
        End If

        TurnTime = stream.ReadLine

        If TurnTime.Contains("TurnTime") Then
            Form1.NumericUpDown11.Text = TurnTime.Split("=").Last
            Form1.RichTextBox1.AppendText(TurnTime & vbNewLine)
        End If
        MineFuse = stream.ReadLine

        If MineFuse.Contains("MineFuse") Then
            Form1.NumericUpDown1.Text = MineFuse.Split("=").Last
            Form1.RichTextBox1.AppendText(MineFuse & vbNewLine)
        End If
        ObjectType = stream.ReadLine
        If ObjectType.Contains("ObjectType") Then
            Form1.RichTextBox1.AppendText(ObjectType & vbNewLine)
        End If
        WeaponCrateDrops = stream.ReadLine

        If WeaponCrateDrops.Contains("WeaponCrateDrops") Then
            Form1.TextBox4.Text = WeaponCrateDrops.Split("=").Last
            Form1.RichTextBox1.AppendText(WeaponCrateDrops & vbNewLine)
        End If
        HealthCrateDrops = stream.ReadLine

        If HealthCrateDrops.Contains("HealthCrateDrops") Then
            Form1.TextBox5.Text = HealthCrateDrops.Split("=").Last
            Form1.RichTextBox1.AppendText(HealthCrateDrops & vbNewLine)
        End If
        UtilityCrateDrops = stream.ReadLine

        If UtilityCrateDrops.Contains("UtilityCrateDrops") Then
            Form1.TextBox6.Text = UtilityCrateDrops.Split("=").Last
            Form1.RichTextBox1.AppendText(UtilityCrateDrops & vbNewLine)
        End If
        HealthCrateEnergy = stream.ReadLine

        If HealthCrateEnergy.Contains("HealthCrateEnergy") Then
            Form1.TextBox7.Text = HealthCrateEnergy.Split("=").Last
            Form1.RichTextBox1.AppendText(HealthCrateEnergy & vbNewLine)
        End If
        EnableSecretWeapons = stream.ReadLine
        If EnableSecretWeapons.Contains("EnableSecretWeapons") Then
            If EnableSecretWeapons.Split("=").Last = 1 Then
                Form1.CheckBox6.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(EnableSecretWeapons & vbNewLine)
            Else
                Form1.CheckBox6.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(EnableSecretWeapons & vbNewLine)
            End If
        End If
        SuddenDeathWaterRise = stream.ReadLine

        If SuddenDeathWaterRise.Contains("SuddenDeathWaterRise") Then
            Form1.TextBox9.Text = SuddenDeathWaterRise.Split("=").Last
            Form1.RichTextBox1.AppendText(SuddenDeathWaterRise & vbNewLine)
        End If
        SuddenDeathWormDamage = stream.ReadLine

        If SuddenDeathWormDamage.Contains("SuddenDeathWormDamage") Then
            Form1.TextBox8.Text = SuddenDeathWormDamage.Split("=").Last
            Form1.RichTextBox1.AppendText(SuddenDeathWormDamage & vbNewLine)
        End If
        SuddenDeathType = stream.ReadLine

        If SuddenDeathType.Contains("SuddenDeathType") Then
            Form1.NumericUpDown6.Text = SuddenDeathType.Split("=").Last
            Form1.RichTextBox1.AppendText(SuddenDeathType & vbNewLine)
        End If
        PauseBetweenTurns = stream.ReadLine

        If PauseBetweenTurns.Contains("PauseBetweenTurns") Then
            Form1.NumericUpDown12.Text = PauseBetweenTurns.Split("=").Last
            Form1.RichTextBox1.AppendText(PauseBetweenTurns & vbNewLine)
        End If
        GirderRadius = stream.ReadLine

        If GirderRadius.Contains("GirderRadius") Then
            Form1.NumericUpDown4.Text = GirderRadius.Split("=").Last
            Form1.RichTextBox1.AppendText(GirderRadius & vbNewLine)
        End If
        WormSelect = stream.ReadLine
        If WormSelect.Contains("WormSelect") Then
            If WormSelect.Split("=").Last = 1 Then
                Form1.CheckBox9.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(WormSelect & vbNewLine)
            Else
                Form1.CheckBox9.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(WormSelect & vbNewLine)
            End If
        End If
        JetPackTimeLimit = stream.ReadLine

        If JetPackTimeLimit.Contains("JetPackTimeLimit") Then
            Form1.NumericUpDown5.Text = JetPackTimeLimit.Split("=").Last
            Form1.RichTextBox1.AppendText(JetPackTimeLimit & vbNewLine)
        End If
        WeaponsDontEndTurn = stream.ReadLine
        If WeaponsDontEndTurn.Contains("WeaponsDontEndTurn") Then
            If WeaponsDontEndTurn.Split("=").Last = 1 Then
                Form1.CheckBox4.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(WeaponsDontEndTurn & vbNewLine)
            Else
                Form1.CheckBox4.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(WeaponsDontEndTurn & vbNewLine)
            End If
        End If
        PauseTimerWhileFiring = stream.ReadLine
        If PauseTimerWhileFiring.Contains("PauseTimerWhileFiring") Then
            If PauseTimerWhileFiring.Split("=").Last = 1 Then
                Form1.CheckBox7.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(PauseTimerWhileFiring & vbNewLine)
            Else
                Form1.CheckBox7.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(PauseTimerWhileFiring & vbNewLine)
            End If
        End If
        TurnEndFinishesGame = stream.ReadLine
        If TurnEndFinishesGame.Contains("TurnEndFinishesGame") Then
            If TurnEndFinishesGame.Split("=").Last = 1 Then
                Form1.CheckBox33.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(TurnEndFinishesGame & vbNewLine)
            Else
                Form1.CheckBox33.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(TurnEndFinishesGame & vbNewLine)
            End If
        End If
        LossOfControlDoesntEndTurn = stream.ReadLine
        If LossOfControlDoesntEndTurn.Contains("LossOfControlDoesntEndTurn") Then
            If LossOfControlDoesntEndTurn.Split("=").Last = 1 Then
                Form1.CheckBox5.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(LossOfControlDoesntEndTurn & vbNewLine)
            Else
                Form1.CheckBox5.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(LossOfControlDoesntEndTurn & vbNewLine)
            End If
        End If
        Score = stream.ReadLine
        If Score.Contains("Score") Then
            If Score.Split("=").Last = 1 Then
                Form1.CheckBox10.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(Score & vbNewLine)
            Else
                Form1.CheckBox10.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(Score & vbNewLine)
            End If
        End If
        Sheep = stream.ReadLine
        If Sheep.Contains("Sheep") Then
            Form1.RichTextBox1.AppendText(Sheep & vbNewLine)
        End If
        stream.ReadLine()
    End Sub

    Public Shared Sub LoadOptions()
        If LineOfText.Contains("[Options]") Then
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("FallDamage=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                FallDamage = aryTextFile(i)
                Form1.NumericUpDown3.Text = FallDamage

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("DisplayRoundTime=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                DisplayRoundTime = aryTextFile(i)
                If DisplayRoundTime = "1" Then
                    Form1.CheckBox8.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox8.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("EnableActionReplay=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                EnableActionReplay = aryTextFile(i)
                If EnableActionReplay = "1" Then
                    Form1.CheckBox12.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox12.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("LandRetreatTime=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                LandRetreatTime = aryTextFile(i)
                Form1.NumericUpDown8.Text = LandRetreatTime

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("RopeRetreatTime=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                RopeRetreatTime = aryTextFile(i)
                Form1.NumericUpDown9.Text = RopeRetreatTime

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("RoundTime=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                RoundTime = aryTextFile(i)
                Form1.NumericUpDown10.Text = RoundTime

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("TurnTime=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                TurnTime = aryTextFile(i)
                Form1.NumericUpDown11.Text = TurnTime

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("MineFuse=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                MineFuse = aryTextFile(i)
                Form1.NumericUpDown1.Text = MineFuse

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("ObjectType=") Then
            aryTextFile = LineOfText.Split("=")
            For Mission.i = 0 To UBound(aryTextFile)
                ObjectType = aryTextFile(i)


            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("WeaponCrateDrops=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                WeaponCrateDrops = aryTextFile(i)
                Form1.TextBox4.Text = WeaponCrateDrops

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("HealthCrateDrops=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                HealthCrateDrops = aryTextFile(i)
                Form1.TextBox5.Text = HealthCrateDrops

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("UtilityCrateDrops=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                UtilityCrateDrops = aryTextFile(i)
                Form1.TextBox6.Text = UtilityCrateDrops

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("HealthCrateEnergy=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                HealthCrateEnergy = aryTextFile(i)
                Form1.TextBox7.Text = HealthCrateEnergy

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("EnableSecretWeapons=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                EnableSecretWeapons = aryTextFile(i)
                If EnableSecretWeapons = "1" Then
                    Form1.CheckBox6.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox6.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("SuddenDeathWaterRise=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                SuddenDeathWaterRise = aryTextFile(i)
                Form1.TextBox9.Text = SuddenDeathWaterRise

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("SuddenDeathWormDamage=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                SuddenDeathWormDamage = aryTextFile(i)
                Form1.TextBox8.Text = SuddenDeathWormDamage

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("SuddenDeathType=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                SuddenDeathType = aryTextFile(i)
                Form1.NumericUpDown6.Text = SuddenDeathType

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("PauseBetweenTurns=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                PauseBetweenTurns = aryTextFile(i)
                Form1.NumericUpDown12.Text = PauseBetweenTurns

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("GirderRadius=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                GirderRadius = aryTextFile(i)
                Form1.NumericUpDown4.Text = GirderRadius

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("WormSelect=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                WormSelect = aryTextFile(i)
                If WormSelect = "1" Then
                    Form1.CheckBox9.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox9.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("JetPackTimeLimit=") Then

            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                JetPackTimeLimit = aryTextFile(i)
                Form1.NumericUpDown5.Text = JetPackTimeLimit

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("WeaponsDontEndTurn=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                WeaponsDontEndTurn = aryTextFile(i)
                If WeaponsDontEndTurn = "1" Then
                    Form1.CheckBox4.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox4.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("PauseTimerWhileFiring=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                PauseTimerWhileFiring = aryTextFile(i)
                If PauseTimerWhileFiring = "1" Then
                    Form1.CheckBox7.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox7.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("TurnEndFinishesGame=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                TurnEndFinishesGame = aryTextFile(i)
                If TurnEndFinishesGame = "1" Then
                    Form1.CheckBox33.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox33.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("LossOfControlDoesntEndTurn=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                LossOfControlDoesntEndTurn = aryTextFile(i)
                If LossOfControlDoesntEndTurn = "1" Then
                    Form1.CheckBox5.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox5.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        ElseIf LineOfText.Contains("Score=") Then
            aryTextFile = LineOfText.Split("=")

            For Mission.i = 0 To UBound(aryTextFile)
                Score = aryTextFile(i)
                If Score = "1" Then
                    Form1.CheckBox10.CheckState = CheckState.Checked
                Else
                    Form1.CheckBox10.CheckState = CheckState.Unchecked
                End If

            Next i
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
    End Sub
    Public Shared Sub SaveOptions()
        writer.WriteLine()
        writer.WriteLine("[Options]")
        Form1.RichTextBox1.AppendText("[Options]" & vbNewLine)
        If Form1.NumericUpDown3.Value <> Nothing Then
            FallDamage = Form1.NumericUpDown3.Value
            
        Else
            FallDamage = 0
            debugline = "FallDamage=EmptyField"
            Form1.RichTextBox2.AppendText(debugline & vbNewLine)
        End If
        writer.WriteLine("FallDamage=" & FallDamage)
        LineOfText = "FallDamage=" & FallDamage
        Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        If DisplayRoundTime <> "" Then
            If Form1.CheckBox8.CheckState = CheckState.Checked Then
                DisplayRoundTime = 1
                writer.WriteLine("DisplayRoundTime=" & DisplayRoundTime)
                LineOfText = "DisplayRoundTime=" & DisplayRoundTime
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox8.CheckState = CheckState.Unchecked Then
                DisplayRoundTime = 0
                writer.WriteLine("DisplayRoundTime=" & DisplayRoundTime)
                LineOfText = "DisplayRoundTime=" & DisplayRoundTime
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If EnableActionReplay <> "" Then
            If Form1.CheckBox12.CheckState = CheckState.Checked Then
                EnableActionReplay = 1
                writer.WriteLine("EnableActionReplay=" & EnableActionReplay)
                LineOfText = "EnableActionReplay=" & EnableActionReplay
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox12.CheckState = CheckState.Unchecked Then
                EnableActionReplay = 0
                writer.WriteLine("EnableActionReplay=" & EnableActionReplay)
                LineOfText = "EnableActionReplay=" & EnableActionReplay
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If LandRetreatTime <> "" Then
            LandRetreatTime = Form1.NumericUpDown8.Value
            writer.WriteLine("LandRetreatTime=" & LandRetreatTime)
            LineOfText = "LandRetreatTime=" & LandRetreatTime
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If RopeRetreatTime <> "" Then
            RopeRetreatTime = Form1.NumericUpDown9.Value
            writer.WriteLine("RopeRetreatTime=" & RopeRetreatTime)
            LineOfText = "RopeRetreatTime=" & RopeRetreatTime
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If RoundTime <> "" Then
            RoundTime = Form1.NumericUpDown10.Value
            writer.WriteLine("RoundTime=" & RoundTime)
            LineOfText = "RoundTime=" & RoundTime
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If TurnTime <> "" Then
            TurnTime = Form1.NumericUpDown11.Value
            writer.WriteLine("TurnTime=" & TurnTime)
            LineOfText = "TurnTime=" & TurnTime
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If MineFuse <> "" Then
            MineFuse = Form1.NumericUpDown1.Value
            writer.WriteLine("MineFuse=" & MineFuse)
            LineOfText = "MineFuse=" & MineFuse
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If ObjectType <> "" Then

            writer.WriteLine(ObjectType)
            LineOfText = ObjectType
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If WeaponCrateDrops <> "" Then
            WeaponCrateDrops = Form1.TextBox4.Text
            writer.WriteLine("WeaponCrateDrops=" & WeaponCrateDrops)
            LineOfText = "WeaponCrateDrops=" & WeaponCrateDrops
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If HealthCrateDrops <> "" Then
            HealthCrateDrops = Form1.TextBox5.Text
            writer.WriteLine("HealthCrateDrops=" & HealthCrateDrops)
            LineOfText = "HealthCrateDrops=" & HealthCrateDrops
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If UtilityCrateDrops <> "" Then
            UtilityCrateDrops = Form1.TextBox6.Text
            writer.WriteLine("UtilityCrateDrops=" & UtilityCrateDrops)
            LineOfText = "UtilityCrateDrops=" & UtilityCrateDrops
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If HealthCrateEnergy <> "" Then
            HealthCrateEnergy = Form1.TextBox7.Text
            writer.WriteLine("HealthCrateEnergy=" & HealthCrateEnergy)
            LineOfText = "HealthCrateEnergy=" & HealthCrateEnergy
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If EnableSecretWeapons <> "" Then
            If Form1.CheckBox6.CheckState = CheckState.Checked Then
                EnableSecretWeapons = 1
                writer.WriteLine("EnableSecretWeapons=" & EnableSecretWeapons)
                LineOfText = "EnableSecretWeapons=" & EnableSecretWeapons
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox6.CheckState = CheckState.Unchecked Then
                EnableSecretWeapons = 0
                writer.WriteLine("EnableSecretWeapons=" & EnableSecretWeapons)
                LineOfText = "EnableSecretWeapons=" & EnableSecretWeapons
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If SuddenDeathWaterRise <> "" Then
            SuddenDeathWaterRise = Form1.TextBox9.Text
            writer.WriteLine("SuddenDeathWaterRise=" & SuddenDeathWaterRise)
            LineOfText = "SuddenDeathWaterRise=" & SuddenDeathWaterRise
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If SuddenDeathWormDamage <> "" Then
            SuddenDeathWormDamage = Form1.TextBox8.Text
            writer.WriteLine("SuddenDeathWormDamage=" & SuddenDeathWormDamage)
            LineOfText = "SuddenDeathWormDamage=" & SuddenDeathWormDamage
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If SuddenDeathType <> "" Then
            SuddenDeathType = Form1.NumericUpDown6.Value
            writer.WriteLine("SuddenDeathType=" & SuddenDeathType)
            LineOfText = "SuddenDeathType=" & SuddenDeathType
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If PauseBetweenTurns <> "" Then
            PauseBetweenTurns = Form1.NumericUpDown12.Value
            writer.WriteLine("PauseBetweenTurns=" & PauseBetweenTurns)
            LineOfText = "PauseBetweenTurns=" & PauseBetweenTurns
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If GirderRadius <> "" Then
            GirderRadius = Form1.NumericUpDown4.Value
            writer.WriteLine("GirderRadius=" & GirderRadius)
            LineOfText = "GirderRadius=" & GirderRadius
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If JetPackTimeLimit <> "" Then
            JetPackTimeLimit = Form1.NumericUpDown5.Value
            writer.WriteLine("JetPackTimeLimit=" & JetPackTimeLimit)
            LineOfText = "JetPackTimeLimit=" & JetPackTimeLimit
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
        If WormSelect <> "" Then
            If Form1.CheckBox9.CheckState = CheckState.Checked Then
                WormSelect = 1
                writer.WriteLine("WormSelect=" & WormSelect)
                LineOfText = "WormSelect=" & WormSelect
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox9.CheckState = CheckState.Unchecked Then
                WormSelect = 0
                writer.WriteLine("WormSelect=" & WormSelect)
                LineOfText = "WormSelect=" & WormSelect
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If WeaponsDontEndTurn <> "" Then
            If Form1.CheckBox4.CheckState = CheckState.Checked Then
                WeaponsDontEndTurn = 1
                writer.WriteLine("WeaponsDontEndTurn=" & WeaponsDontEndTurn)
                LineOfText = "WeaponsDontEndTurn=" & WeaponsDontEndTurn
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox4.CheckState = CheckState.Unchecked Then
                WeaponsDontEndTurn = 0
                writer.WriteLine("WeaponsDontEndTurn=" & WeaponsDontEndTurn)
                LineOfText = "WeaponsDontEndTurn=" & WeaponsDontEndTurn
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If PauseTimerWhileFiring <> "" Then
            If Form1.CheckBox7.CheckState = CheckState.Checked Then
                PauseTimerWhileFiring = 1
                writer.WriteLine("PauseTimerWhileFiring=" & PauseTimerWhileFiring)
                LineOfText = "PauseTimerWhileFiring=" & PauseTimerWhileFiring
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox7.CheckState = CheckState.Unchecked Then
                PauseTimerWhileFiring = 0
                writer.WriteLine("PauseTimerWhileFiring=" & PauseTimerWhileFiring)
                LineOfText = "PauseTimerWhileFiring=" & PauseTimerWhileFiring
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If TurnEndFinishesGame <> "" Then
            If Form1.CheckBox33.CheckState = CheckState.Checked Then
                TurnEndFinishesGame = 1
                writer.WriteLine("TurnEndFinishesGame=" & TurnEndFinishesGame)
                LineOfText = "TurnEndFinishesGame=" & TurnEndFinishesGame
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox33.CheckState = CheckState.Unchecked Then
                TurnEndFinishesGame = 0
                writer.WriteLine("TurnEndFinishesGame=" & TurnEndFinishesGame)
                LineOfText = "TurnEndFinishesGame=" & TurnEndFinishesGame
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If LossOfControlDoesntEndTurn <> "" Then
            If Form1.CheckBox5.CheckState = CheckState.Checked Then
                LossOfControlDoesntEndTurn = 1
                writer.WriteLine("LossOfControlDoesntEndTurn=" & LossOfControlDoesntEndTurn)
                LineOfText = "LossOfControlDoesntEndTurn=" & LossOfControlDoesntEndTurn
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox5.CheckState = CheckState.Unchecked Then
                LossOfControlDoesntEndTurn = 0
                writer.WriteLine("LossOfControlDoesntEndTurn=" & LossOfControlDoesntEndTurn)
                LineOfText = "LossOfControlDoesntEndTurn=" & LossOfControlDoesntEndTurn
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If Score <> "" Then
            If Form1.CheckBox10.CheckState = CheckState.Checked Then
                Score = 1
                writer.WriteLine("Score=" & Score)
                LineOfText = "Score=" & Score
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf Form1.CheckBox10.CheckState = CheckState.Unchecked Then
                Score = 0
                writer.WriteLine("Score=" & Score)
                LineOfText = "Score=" & Score
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            End If

        End If
        If Sheep <> "" Then

            writer.WriteLine(Sheep)
            LineOfText = Sheep
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
    End Sub
End Class
