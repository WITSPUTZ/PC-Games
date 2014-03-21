Public Class Description
    Inherits Mission
    Public Shared Property Descriptions As String
    Public Shared Property Name As String
    Public Shared Property Difficulty As String
    Public Shared Property TerrainImg As String



    Public Shared Sub LoadDescription()


        Descriptions = stream.ReadLine
        If Descriptions.Contains("[Description]") Then
            Form1.RichTextBox1.AppendText(Descriptions & vbNewLine)
        End If
        Name = stream.ReadLine

        If Name.Contains("Name") Then
            Form1.TextBox50.Text = Name.Split("=").Last
            Form1.RichTextBox1.AppendText(Name & vbNewLine)
        End If
        Difficulty = stream.ReadLine
        If Difficulty.Contains("Difficulty") Then
            Form1.RichTextBox1.AppendText(Difficulty & vbNewLine)
        End If
        stream.ReadLine()

    End Sub

    Public Shared Sub Savedescription()
        writer.WriteLine()
        writer.WriteLine("[Description]")
        Form1.RichTextBox1.AppendText("[Description]" & vbNewLine)
        If Form1.TextBox50.Text <> "" Then
            Name = Form1.TextBox50.Text
            writer.WriteLine("Name=" & Name)
            LineOfText = "Name=" & Name
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        Else
            Name = 0
        End If
        If Difficulty <> "" Then

            writer.WriteLine(Difficulty)
            LineOfText = Difficulty
            Form1.RichTextBox1.AppendText(LineOfText & vbNewLine)
        End If
    End Sub
    Public Shared Sub MissionTerrain()
        If Name = "22" Then
            TerrainImg = "PUMPKINS.img"
            Form1.ComboBox1.Text = TerrainImg

        ElseIf Name = "3" Then
            TerrainImg = "FLOWERS.img"
            Form1.ComboBox1.Text = TerrainImg
        End If
    End Sub
End Class
