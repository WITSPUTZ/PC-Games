Imports System.IO

Public Class Mission

    Public Shared Property MissionFile As String
    Public Shared Property Missiones As String
    Public Shared Property MissionNumber As String
    Public Shared Property WinningCondition As String
    Public Shared Property WinningWeapon As String
    Public Shared Property Comment As String
    Public Shared stream As IO.StreamReader
    Public Shared writer As IO.StreamWriter
    Public Shared lines As List(Of String)
    Public Shared LineOfText As String
    Public Shared i As Integer
    Public Shared aryTextFile() As String
    Public Shared aryTextFile2() As String
    Public Shared debugline As String
    Public Shared lineoftext2 As String

    Public Sub LoadMission()
        MissionFile = Form1.ListBox1.SelectedItem
        Dim current As String = My.Settings.GamePath & "\DATA\Mission\" & MissionFile

        stream = New StreamReader(current)

        Missiones = stream.ReadLine
        If Missiones.Contains("[Mission]") Then
            Form1.RichTextBox1.AppendText(Missiones & vbNewLine)
        End If
        MissionNumber = stream.ReadLine

        If MissionNumber.Contains("MissionNumber") Then
            Form1.TextBox48.Text = MissionNumber.Split("=").Last
            Form1.RichTextBox1.AppendText(MissionNumber & vbNewLine)
        End If
        WinningCondition = stream.ReadLine

        If WinningCondition.Contains("WinningCondition") Then
            Form1.TextBox49.Text = WinningCondition.Split("=").Last
            Form1.RichTextBox1.AppendText(WinningCondition & vbNewLine)
        End If
        WinningWeapon = stream.ReadLine

        If WinningWeapon.Contains("WinningWeapon") Then
            If WinningWeapon.Split("=").Last = 1 Then
                Form1.CheckBox32.CheckState = CheckState.Checked
                Form1.RichTextBox1.AppendText(WinningWeapon & vbNewLine)
            Else
                Form1.CheckBox32.CheckState = CheckState.Unchecked
                Form1.RichTextBox1.AppendText(WinningWeapon & vbNewLine)
            End If
        End If
        Comment = stream.ReadLine
        Form1.RichTextBox1.AppendText(Comment & vbNewLine)
        stream.ReadLine()
        Description.LoadDescription()
        Options.LoadOpt()
        Enviroment.LoadEnvr()
        HumanTeam.LoadHmTeam()
    End Sub

    Public Sub SaveMission()
        Dim current As String = My.Settings.GamePath & "\DATA\Mission\" & "Test.wam"

        writer = New StreamWriter(current)
        writer.WriteLine("[Mission]")
        Form1.RichTextBox1.AppendText("[Mission]" & vbNewLine)
        If MissionNumber <> "" Then
            MissionNumber = Form1.TextBox48.Text
            writer.WriteLine("MissionNumber=" & MissionNumber)
            LineOfText = "MissionNumber=" & MissionNumber
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)

        Else
            debugline = "MissionNumber=EmptyField"
            Form1.RichTextBox2.AppendText(debugline & vbNewLine)
        End If
        
        If WinningCondition <> "" Then
            WinningCondition = Form1.TextBox49.Text
            writer.WriteLine("WiningCondition=" & WinningCondition)
            LineOfText = "WiningCondition=" & WinningCondition
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        Else
            WinningCondition = 0
        End If
        If WinningWeapon <> "" Then
            If Form1.CheckBox32.CheckState = CheckState.Checked Then
                WinningWeapon = 1
                writer.WriteLine("WiningWeapon=" & WinningWeapon)
                lineoftext = "WiningWeapon=" & WinningWeapon
                Form1.RichTextBox1.AppendText(lineoftext & vbNewLine)
            ElseIf Form1.CheckBox32.CheckState = CheckState.Unchecked Then
                WinningWeapon = 0
                writer.WriteLine("WiningWeapon=" & WinningWeapon)
                lineoftext = "WiningWeapon=" & WinningWeapon
                Form1.RichTextBox1.AppendText(lineoftext & vbNewLine)
            End If

        End If
        Description.Savedescription()
        Options.SaveOptions()
        Enviroment.SaveEnviroment()
        writer.Close()
        writer.Dispose()
    End Sub
End Class
