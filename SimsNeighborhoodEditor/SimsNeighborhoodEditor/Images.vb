Imports System
Imports System.Drawing
Imports System.IO
Imports SimsLib.IFF

Public Class Images

    Inherits IffChunk
    ' Methods
    Public Sub New(ByVal Chunk As IffChunk)
        MyBase.New(Chunk)
        Dim stream As New MemoryStream(Chunk.Data)
        m_BitmapData = New Bitmap(stream)

    End Sub


    ' Fields
    Public Shared m_BitmapData As Bitmap
End Class


