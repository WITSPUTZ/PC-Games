Imports System
Imports System.Drawing
Imports System.IO

Namespace SimsLib.IFF
    Public Class PaletteMap
        Inherits IffChunk
        ' Methods
        Public Sub New()
            MyBase.New("PMAP")
            Me.m_Colors = New Color(&H100  - 1) {}
            Dim i As Integer
            For i = 0 To &H100 - 1
                Me.m_Colors(i) = Color.FromArgb(&HFF, 0, 0, 0)
            Next i
        End Sub

        Public Sub New(ByVal Chunk As IffChunk)
            MyBase.New(Chunk)
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            Me.m_Colors = New Color(&H100  - 1) {}
            reader.BaseStream.Position = &H10
            Dim i As Integer
            For i = 0 To &H100 - 1
                Dim buffer As Byte() = New Byte(0  - 1) {}
                If ((reader.BaseStream.Length - reader.BaseStream.Position) >= 3) Then
                    Me.m_Colors(i) = Color.FromArgb(reader.ReadByte, reader.ReadByte, reader.ReadByte)
                Else
                    Me.m_Colors(i) = Color.FromArgb(&HFF, &H80, &H80, &H80)
                End If
            Next i
            reader.Close
        End Sub

        Public Function GetColorAtIndex(ByVal Index As Integer) As Color
            Return Me.m_Colors(Index)
        End Function


        ' Fields
        Private Const INDEX_PALTID As Integer = 1
        Private Const INDEX_PALTPX As Integer = &H54
        Private m_Colors As Color()
        Private Shared numPalettes As Integer
    End Class
End Namespace

