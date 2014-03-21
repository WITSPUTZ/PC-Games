Imports System
Imports System.Collections.Generic
Imports System.IO

Namespace SimsLib.IFF
    Public Class DrawGroup
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk, ByVal Sprites As List(Of SPR2Parser))
            MyBase.New(Chunk)
            Me.m_Images = New List(Of DrawGroupImg)
            Me.m_Sprites = New List(Of SPR2Parser)
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            MyBase.m_ID = MyBase.ID
            Me.m_Sprites = Sprites
            Me.m_Version = (reader.ReadUInt16 - &H4E20)
            Dim num As UInt32 = If((Me.m_Version < 3), reader.ReadUInt16, reader.ReadUInt32)
            Dim i As Integer
            For i = 0 To num - 1
                Dim num2 As UInt32
                Dim num3 As UInt32
                Dim num4 As UInt32
                If (Me.m_Version < 3) Then
                    num2 = reader.ReadUInt16
                    num3 = reader.ReadByte
                    num4 = reader.ReadByte
                Else
                    num3 = reader.ReadUInt32
                    num4 = reader.ReadUInt32
                    num2 = reader.ReadUInt32
                End If
                Dim item As New DrawGroupImg(num2, num3, num4)
                Dim j As Integer
                For j = 0 To num2 - 1
                    Dim type As UInt16 = 0
                    Dim x As Integer = 0
                    Dim y As Integer = 0
                    Dim chunkID As UInt32 = 0
                    Dim frameIndex As UInt32 = 0
                    Dim flags As UInt32 = 0
                    Dim z As Single = 0!
                    Dim num14 As Single = 0!
                    Dim num15 As Single = 0!
                    If (Me.m_Version < 3) Then
                        type = reader.ReadUInt16
                        chunkID = reader.ReadUInt16
                        frameIndex = reader.ReadUInt16
                        flags = reader.ReadUInt16
                        x = reader.ReadInt16
                        y = reader.ReadInt16
                        If (Me.m_Version = 1) Then
                            z = reader.ReadUInt32
                        End If
                    Else
                        chunkID = reader.ReadUInt32
                        frameIndex = reader.ReadUInt32
                        x = reader.ReadInt32
                        y = reader.ReadInt32
                        z = reader.ReadUInt32
                        flags = reader.ReadUInt32
                        If (Me.m_Version = 4) Then
                            num14 = reader.ReadUInt32
                            num15 = reader.ReadUInt32
                        End If
                    End If
                    Dim frame As SpriteFrame = Me.FindSpriteFrame(chunkID, frameIndex)
                    If (Not frame Is Nothing) Then
                        Dim sprite As New DrawGroupSprite(type, flags, New PixelOffset(x, y), New WorldOffset(num14, num15, z), frame)
                        item.Sprites.Insert(0, sprite)
                    End If
                Next j
                Me.m_Images.Add(item)
            Next i
        End Sub

        Private Function FindSpriteFrame(ByVal chunkID As UInt32, ByVal frameIndex As UInt32) As SpriteFrame
            Dim parser As SPR2Parser
            For Each parser In Me.m_Sprites
                If ((parser.ID = chunkID) AndAlso (parser.FrameCount > frameIndex)) Then
                    Return parser.GetFrame(CInt(frameIndex))
                End If
            Next
            Return Nothing
        End Function

        Public Function GetImage(ByVal Index As Integer) As DrawGroupImg
            Return Me.LoadImage(Index)
        End Function

        Private Function LoadImage(ByVal Index As Integer) As DrawGroupImg
            Dim img As DrawGroupImg = Me.m_Images.Item(Index)
            img.CompileSprites
            Return img
        End Function


        ' Properties
        Public ReadOnly Property ImageCount As Integer
            Get
                Return Me.m_Images.Count
            End Get
        End Property

        Public ReadOnly Property Version As Integer
            Get
                Return Me.m_Version
            End Get
        End Property


        ' Fields
        Private Const INDEX_IMAGE As Integer = &HE2
        Private Const INDEX_VERSION As Integer = &H44
        Private m_Images As List(Of DrawGroupImg)
        Private m_Sprites As List(Of SPR2Parser)
        Private m_Version As Integer
    End Class
End Namespace

