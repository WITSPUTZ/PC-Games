Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO

Namespace SimsLib.IFF
    Public Class SPR2Parser
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk, ByVal PMaps As List(Of PaletteMap))
            MyBase.New(Chunk)
            Dim match As Predicate(Of PaletteMap) = Nothing
            Me.m_FrameOffsets = New List(Of Integer)
            Me.m_Frames = New List(Of SpriteFrame)
            Me.m_Name = Me.Name
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            Me.m_Version = reader.ReadUInt32
            If (Me.m_Version = &H3E8) Then
                Me.m_ChunkData = Chunk.Data
            End If
            If (Me.m_Version = &H3E9) Then
                Me.m_PaletteID = reader.ReadUInt32
                Me.m_FrameCount = reader.ReadUInt32
            Else
                Me.m_FrameCount = reader.ReadUInt32
                Me.m_PaletteID = reader.ReadUInt32
            End If
            If ((PMaps.Count = 1) AndAlso (Me.m_PaletteID = 1)) Then
                Me.m_PMap = PMaps.Item(0)
            Else
                If (match Is Nothing) Then
                    match = PMap => (PMap.ID = Me.m_PaletteID)
                End If
                Me.m_PMap = PMaps.Find(match)
            End If
            If (Me.m_PMap Is Nothing) Then
                Me.m_PMap = PMaps.Item(0)
            End If
            Dim numArray As Integer() = New Integer(Me.m_FrameCount  - 1) {}
            If (Me.m_Version = &H3E8) Then
                Dim i As Integer
                For i = 0 To Me.m_FrameCount - 1
                    numArray(i) = reader.ReadInt32
                    Me.m_FrameOffsets.Add(numArray(i))
                Next i
            End If
            If (Me.m_Version = &H3E9) Then
                Dim j As Integer
                For j = 0 To Me.m_FrameCount - 1
                    Dim frame As New SpriteFrame With { _
                        .Version = reader.ReadUInt32, _
                        .Size = reader.ReadUInt32, _
                        .Width = reader.ReadUInt16, _
                        .Height = reader.ReadUInt16, _
                        .Flag = reader.ReadUInt32, _
                        .PaletteID = reader.ReadUInt16, _
                        .TransparentPixel = Me.m_PMap.GetColorAtIndex(reader.ReadUInt16), _
                        .YLocation = reader.ReadUInt16, _
                        .XLocation = reader.ReadUInt16 _
                    }
                    If (frame.Flag = 7) Then
                        frame.Init(True, True)
                    ElseIf (frame.Flag = 3) Then
                        frame.Init(False, True)
                    Else
                        frame.Init(False, False)
                    End If
                    Me.DecompressFrame2(frame, reader)
                    frame.BitmapData.Unlock(True)
                    If frame.HasZBuffer Then
                        frame.ZBuffer.Unlock(True)
                    End If
                    Me.m_Frames.Add(frame)
                Next j
            End If
            reader.Close
        End Sub

        Private Sub DecompressFrame2(ByRef Frame As SpriteFrame, ByRef Reader As BinaryReader)
            Dim flag As Boolean = False
            Dim y As Integer = 0
            Dim x As Integer = 0
            Dim num3 As Integer = 0
            Do While Not flag
                Dim num6 As Integer
                Dim num7 As Integer
                Dim decryptedValues As Integer() = Me.GetDecryptedValues(Reader.ReadUInt16)
                Select Case decryptedValues(0)
                    Case 4
                        num6 = 0
                        goto Label_045E
                    Case 5
                        flag = True
                        goto Label_0477
                    Case 0
                        Exit Select
                    Case Else
                        goto Label_0477
                End Select
                Dim num4 As Integer = decryptedValues(1)
                num4 = (num4 - 2)
                Do While (num4 > 0)
                    Dim color2 As Color
                    Dim numArray2 As Integer() = Me.GetDecryptedValues(Reader.ReadUInt16)
                    num4 = (num4 - 2)
                    Dim num5 As Integer = numArray2(1)
                    Select Case numArray2(0)
                        Case 1
                            num4 = (num4 - (num5 * 2))
                            goto Label_0135
                        Case 2
                            num3 = (num5 Mod 2)
                            num4 = (num4 - ((num5 * 3) + num3))
                            goto Label_01D4
                        Case 3
                            goto Label_0261
                        Case 6
                            num3 = (num5 Mod 2)
                            num4 = (num4 - (num5 + num3))
                            goto Label_0369
                        Case Else
                            goto Label_038B
                    End Select
                Label_00A6:
                    Frame.ZBuffer.SetPixel(New Point(x, y), Color.FromArgb(Reader.ReadByte, 0, 0, 0))
                    Dim colorAtIndex As Color = Me.m_PMap.GetColorAtIndex(Reader.ReadByte)
                    If (colorAtIndex <> Frame.TransparentPixel) Then
                        Frame.BitmapData.SetPixel(New Point(x, y), colorAtIndex)
                    Else
                        Frame.BitmapData.SetPixel(New Point(x, y), Color.FromArgb(0, 0, 0, 0))
                    End If
                    num5 -= 1
                    x += 1
                Label_0135:
                    If (num5 > 0) Then
                        goto Label_00A6
                    End If
                    goto Label_038B
                Label_015A:
                    color2 = Color.FromArgb(Reader.ReadByte)
                    colorAtIndex = Me.m_PMap.GetColorAtIndex(Reader.ReadByte)
                    colorAtIndex = Color.FromArgb(Reader.ReadByte, colorAtIndex)
                    color2 = Color.FromArgb(colorAtIndex.A, color2)
                    Frame.BitmapData.SetPixel(New Point(x, y), colorAtIndex)
                    Frame.ZBuffer.SetPixel(New Point(x, y), color2)
                    num5 -= 1
                    x += 1
                Label_01D4:
                    If (num5 > 0) Then
                        goto Label_015A
                    End If
                    If (num3 <> 0) Then
                        Reader.ReadByte
                    End If
                    goto Label_038B
                Label_01FB:
                    Frame.BitmapData.SetPixel(New Point(x, y), Color.FromArgb(0, 0, 0, 0))
                    If Frame.HasZBuffer Then
                        Frame.ZBuffer.SetPixel(New Point(x, y), Color.FromArgb(&HFF, &HFF, &HFF, &HFF))
                    End If
                    num5 -= 1
                    x += 1
                Label_0261:
                    If (num5 > 0) Then
                        goto Label_01FB
                    End If
                    goto Label_038B
                Label_0284:
                    colorAtIndex = Me.m_PMap.GetColorAtIndex(Reader.ReadByte)
                    If (colorAtIndex <> Frame.TransparentPixel) Then
                        Frame.BitmapData.SetPixel(New Point(x, y), colorAtIndex)
                    Else
                        Frame.BitmapData.SetPixel(New Point(x, y), Color.FromArgb(0, 0, 0, 0))
                    End If
                    If Frame.HasZBuffer Then
                        If (colorAtIndex <> Frame.TransparentPixel) Then
                            Frame.ZBuffer.SetPixel(New Point(x, y), Color.FromArgb(&HFF, 1, 1, 1))
                        Else
                            Frame.BitmapData.SetPixel(New Point(x, y), Color.FromArgb(&HFF, &HFF, &HFF, &HFF))
                        End If
                    End If
                    num5 -= 1
                    x += 1
                Label_0369:
                    If (num5 > 0) Then
                        goto Label_0284
                    End If
                    If (num3 <> 0) Then
                        Reader.ReadByte
                    End If
                Label_038B:
                    If (Reader.BaseStream.Position = Reader.BaseStream.Length) Then
                        Exit Do
                    End If
                Loop
                y += 1
                x = 0
                goto Label_0477
            Label_03D2:
                num7 = 0
                Do While (num7 < Frame.Width)
                    Frame.BitmapData.SetPixel(New Point(x, y), Color.FromArgb(0, 0, 0, 0))
                    If Frame.HasZBuffer Then
                        Frame.ZBuffer.SetPixel(New Point(x, y), Color.FromArgb(&HFF, &HFF, &HFF, &HFF))
                    End If
                    x += 1
                    num7 += 1
                Loop
                x = 0
                y += 1
                num6 += 1
            Label_045E:
                If (num6 < decryptedValues(1)) Then
                    goto Label_03D2
                End If
                x = 0
            Label_0477:
                If (Reader.BaseStream.Position = Reader.BaseStream.Length) Then
                    Exit Do
                End If
            Loop
        End Sub

        Public Sub ExportToBitmaps(ByVal directory As String)
            If (Me.m_Version = &H3E9) Then
                Dim frame As SpriteFrame
                For Each frame In Me.m_Frames
                    Dim path As String = String.Concat(New Object() { directory, "\"c, MyBase.m_ID, "_"c, frame.Width, "x"c, frame.Height, ".bmp" })
                    If File.Exists(path) Then
                        File.Delete(path)
                    End If
                    frame.BitmapData.BitMap.Save(path)
                    frame.BitmapData.Lock
                Next
            End If
        End Sub

        Private Function GetDecryptedValues(ByVal P As UInt16) As Integer()
            Return New Integer() { (P >> 13), (P And &H1FFF) }
        End Function

        Public Function GetFrame(ByVal Index As Integer) As SpriteFrame
            If (Me.m_Version = &H3E8) Then
                Dim frame As SpriteFrame
                For Each frame In Me.m_Frames
                    If (frame.FrameIndex = Index) Then
                        Return frame
                    End If
                Next
                Return Me.ReadFrame(Index)
            End If
            Return Me.m_Frames.Item(Index)
        End Function

        Public Function ReadFrame(ByVal Index As Integer) As SpriteFrame
            Dim reader As New BinaryReader(New MemoryStream(Me.m_ChunkData))
            reader.BaseStream.Seek(CLng(Me.m_FrameOffsets.Item(Index)), SeekOrigin.Begin)
            Dim frame As New SpriteFrame With { _
                .FrameIndex = DirectCast(Index, UInt32), _
                .Width = reader.ReadUInt16, _
                .Height = reader.ReadUInt16, _
                .Flag = reader.ReadUInt32, _
                .PaletteID = reader.ReadUInt16, _
                .TransparentPixel = Me.m_PMap.GetColorAtIndex(reader.ReadUInt16), _
                .YLocation = reader.ReadUInt16, _
                .XLocation = reader.ReadUInt16 _
            }
            If (frame.Flag = 7) Then
                frame.Init(True, True)
            ElseIf (frame.Flag = 3) Then
                frame.Init(False, True)
            Else
                frame.Init(False, False)
            End If
            Me.DecompressFrame2(frame, reader)
            frame.BitmapData.Unlock(True)
            If frame.HasZBuffer Then
                frame.ZBuffer.Unlock(True)
            End If
            reader.Close
            Me.m_Frames.Add(frame)
            Return frame
        End Function


        ' Properties
        Public ReadOnly Property FrameCount As UInt32
            Get
                If (Me.m_Version = &H3E8) Then
                    Return Me.m_FrameCount
                End If
                Return DirectCast(Me.m_Frames.Count, UInt32)
            End Get
        End Property

        Public ReadOnly Property Name As String
            Get
                Return Me.m_Name
            End Get
        End Property


        ' Fields
        Private Const INDEX_ROWPX As Integer = &H68
        Private Const INDEX_SPRID As Integer = 1
        Private Const INDEX_SPROFFSETTABLE As Integer = 80
        Private Const INDEX_SPRVERSION As Integer = &H44
        Private m_ChunkData As Byte()
        Private m_FrameCount As UInt32
        Private m_FrameOffsets As List(Of Integer)
        Private m_Frames As List(Of SpriteFrame)
        Private m_Name As String
        Private m_PaletteID As UInt32
        Private m_PMap As PaletteMap
        Private m_Version As UInt32
    End Class
End Namespace

