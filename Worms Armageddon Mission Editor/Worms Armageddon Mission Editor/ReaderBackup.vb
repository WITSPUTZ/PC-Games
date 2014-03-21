Imports System.IO

Public Class ReaderBackup
    Inherits Mission
    Public Shared Sub ReaderBck()


        Do While Stream.Peek() <> -1


            LineOfText = Stream.ReadLine()



            If LineOfText.Contains("[Mission]") Then
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf LineOfText.Contains("MissionNumber") Then

                aryTextFile = LineOfText.Split("=")

                For Mission.i = 0 To UBound(aryTextFile)
                    MissionNumber = aryTextFile(i)
                    Form1.TextBox48.Text = MissionNumber

                Next i
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf LineOfText.Contains("WinningCondition") Then
                aryTextFile = LineOfText.Split("=")
                For Mission.i = 0 To UBound(aryTextFile)
                    WinningCondition = aryTextFile(i)
                    Form1.TextBox49.Text = WinningCondition
                Next i
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf LineOfText.Contains("WinningWeapon") Then


                aryTextFile = LineOfText.Split("=")
                For Mission.i = 0 To UBound(aryTextFile)
                    WinningWeapon = aryTextFile(i)
                    If aryTextFile(i) = "1" Then

                        Form1.CheckBox32.CheckState = CheckState.Checked

                    Else
                        Form1.CheckBox32.CheckState = CheckState.Unchecked
                    End If
                Next i
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)

            End If
            If LineOfText.Contains("[Description]") Then
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf LineOfText.Contains("Name=") Then

                aryTextFile = LineOfText.Split("=")

                For Mission.i = 0 To UBound(aryTextFile)
                    Description.Name = aryTextFile(i)
                    Form1.TextBox50.Text = Description.Name

                Next i
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
            ElseIf LineOfText.Contains("Difficulty=") Then
                aryTextFile = LineOfText.Split("=")

                For Mission.i = 0 To UBound(aryTextFile)
                    Description.Difficulty = aryTextFile(i)


                Next i
                Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)

            End If
        Loop
    End Sub
End Class
