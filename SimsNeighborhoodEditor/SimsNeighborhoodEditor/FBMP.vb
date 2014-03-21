Imports System
Imports System.Drawing
Imports System.IO

Namespace SimsLib.IFF
    Public Class FBMP
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk)
            MyBase.New(Chunk)
            Dim stream As New MemoryStream(Chunk.Data)
            Me.m_BitmapData = New Bitmap(stream)
        End Sub


        ' Fields
        Private m_BitmapData As Bitmap
    End Class
End Namespace

