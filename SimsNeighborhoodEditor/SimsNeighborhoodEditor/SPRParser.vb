Imports SimsLib
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO

Namespace SimsLib.IFF
    Public Class SPRParser
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk, ByVal PaletteMaps As List(Of PaletteMap))
            MyBase.New(Chunk)
            Dim num2 As UInt32
            Dim match As Predicate(Of PaletteMap) = Nothing
            Dim predicate2 As Predicate(Of PaletteMap) = Nothing
            Dim predicate3 As Predicate(Of PaletteMap) = Nothing
            Dim predicate4 As Predicate(Of PaletteMap) = Nothing
            Me.m_Frames = New List(Of SpriteFrame)
            Me.m_OffsetTable = New List(Of UInt32)
            Me.m_IsBigEndian = False
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            Dim num As UInt16 = reader.ReadUInt16
            If (num = 0) Then
                Me.m_IsBigEndian = True
                Me.m_Version = Endian.SwapUInt16(reader.ReadUInt16)
            Else
                Me.m_Version = num
                reader.ReadUInt16
            End If
            If (Me.m_Version <> &H3E9) Then
                Me.m_ChunkData = Chunk.Data
            End If
            If Me.m_IsBigEndian Then
                If (Me.m_Version <> &H3E9) Then
                    Me.m_FrameCount = Endian.SwapUInt32(reader.ReadUInt32)
                    Me.m_PaletteID = Endian.SwapUInt32(reader.ReadUInt32)
                    num2
                    For num2 = 0 To Me.m_FrameCount - 1
                        Me.m_OffsetTable.Add(Endian.SwapUInt32(reader.ReadUInt32))
                    Next num2
                    If ((PaletteMaps.Count = 1) AndAlso (Me.m_PaletteID = 1)) Then
                        Me.m_PMap = PaletteMaps.Item(0)
                    Else
                        If (match Is Nothing) Then
                            match = PMap => (PMap.ID = Me.m_PaletteID)
                        End If
                        Me.m_PMap = PaletteMaps.Find(match)
                    End If
                Else
                    Me.m_FrameCount = Endian.SwapUInt32(reader.ReadUInt32)
                    Me.m_PaletteID = Endian.SwapUInt32(reader.ReadUInt32)
                    If ((PaletteMaps.Count = 1) AndAlso (Me.m_PaletteID = 1)) Then
                        Me.m_PMap = PaletteMaps.Item(0)
                    Else
                        If (predicate2 Is Nothing) Then
                            predicate2 = PMap => (PMap.ID = Me.m_PaletteID)
                        End If
                        Me.m_PMap = PaletteMaps.Find(predicate2)
                    End If
                End If
            ElseIf (Me.m_Version <> &H3E9) Then
                Me.m_FrameCount = reader.ReadUInt32
                Me.m_PaletteID = reader.ReadUInt32
                num2
                For num2 = 0 To Me.m_FrameCount - 1
                    Me.m_OffsetTable.Add(reader.ReadUInt32)
                Next num2
                If ((PaletteMaps.Count = 1) AndAlso (Me.m_PaletteID = 1)) Then
                    Me.m_PMap = PaletteMaps.Item(0)
                Else
                    If (predicate3 Is Nothing) Then
                        predicate3 = PMap => (PMap.ID = Me.m_PaletteID)
                    End If
                    Me.m_PMap = PaletteMaps.Find(predicate3)
                End If
            Else
                Me.m_FrameCount = reader.ReadUInt32
                Me.m_PaletteID = reader.ReadUInt32
                If ((PaletteMaps.Count = 1) AndAlso (Me.m_PaletteID = 1)) Then
                    Me.m_PMap = PaletteMaps.Item(0)
                Else
                    If (predicate4 Is Nothing) Then
                        predicate4 = PMap => (PMap.ID = Me.m_PaletteID)
                    End If
                    Me.m_PMap = PaletteMaps.Find(predicate4)
                End If
            End If
            If (Me.m_Version = &H3E9) Then
                Do
                    Dim frame As New SpriteFrame With { _
                        .Version = reader.ReadUInt32, _
                        .Size = reader.ReadUInt32 _
                    }
                    reader.ReadBytes(4)
                    frame.Height = reader.ReadUInt16
                    frame.Width = reader.ReadUInt16
                    frame.Init(True, False)
                    Me.DecompressFrame2(frame, reader)
                    frame.BitmapData.Unlock(True)
                    Me.m_Frames.Add(frame)
                Loop While ((reader.BaseStream.Position <> reader.BaseStream.Length) AndAlso ((reader.BaseStream.Position - reader.BaseStream.Length) >= 14))
            End If
            reader.Close
        End Sub

        Private Sub DecompressFrame2(ByRef Frame As SpriteFrame, ByRef Reader As BinaryReader)
            Dim flag As Boolean = False
            Dim index As Byte = 0
            Dim y As Integer = 0
            Dim num3 As Integer = 0
            Dim num5 As Byte = 0
            If (Me.m_PMap Is Nothing) Then
                Me.m_PMap = New PaletteMap
            End If
            Do While Not flag
                Dim color As Color
                Dim num4 As Byte
                Dim num8 As Integer
                Dim num9 As Byte
                Dim num6 As Byte = Reader.ReadByte
                Dim num7 As Byte = Reader.ReadByte
                Select Case num6
                    Case 4
                        num7 = CByte((num7 - 2))
                        num3 = 0
                        goto Label_01FE
                    Case 5
                        Reader.ReadBytes(2)
                        flag = True
                        Exit Select
                    Case 9
                        num4 = Reader.ReadByte
                        num5 = Reader.ReadByte
                        color = Color.FromArgb(0, 0, 0, 0)
                        Dim i As Integer
                        For i = 0 To num7 - 1
                            num8
                            For num8 = num3 To Frame.Width - 1
                                Frame.BitmapData.SetPixel(New Point(num8, y), color)
                            Next num8
                            y += 1
                        Next i
                        Exit Select
                End Select
                goto Label_028F
            Label_0091:
                num4 = Reader.ReadByte
                num5 = Reader.ReadByte
                num7 = CByte((num7 - 2))
                Select Case num4
                    Case 1
                        color = Color.FromArgb(0, 0, 0, 0)
                        num8 = num3
                        goto Label_00F7
                    Case 2
                        index = Reader.ReadByte
                        Reader.ReadByte
                        num7 = CByte((num7 - 2))
                        num8 = num3
                        goto Label_0158
                    Case 3
                        num9 = CByte((num5 Mod 2))
                        If (num9 = 0) Then
                            goto Label_0193
                        End If
                        num7 = CByte((num7 - CByte((num5 + num9))))
                        goto Label_019B
                    Case Else
                        goto Label_01FE
                End Select
            Label_00D9:
                Frame.BitmapData.SetPixel(New Point(num8, y), color)
                num8 += 1
            Label_00F7:
                If (num8 < (num3 + num5)) Then
                    goto Label_00D9
                End If
                num3 = (num3 + num5)
                goto Label_01FE
            Label_012F:
                Frame.BitmapData.SetPixel(New Point(num8, y), Me.m_PMap.GetColorAtIndex(index))
                num8 += 1
            Label_0158:
                If (num8 < (num3 + num5)) Then
                    goto Label_012F
                End If
                num3 = (num3 + num5)
                goto Label_01FE
            Label_0193:
                num7 = CByte((num7 - num5))
            Label_019B:
                num8 = num3
                Do While (num8 < (num3 + num5))
                    index = Reader.ReadByte
                    Frame.BitmapData.SetPixel(New Point(num8, y), Me.m_PMap.GetColorAtIndex(index))
                    num8 += 1
                Loop
                num3 = (num3 + num5)
                If (num9 <> 0) Then
                    Reader.ReadByte
                End If
            Label_01FE:
                If (num7 > 0) Then
                    goto Label_0091
                End If
                y += 1
            Label_028F:
                If (Reader.BaseStream.Position = Reader.BaseStream.Length) Then
                    Exit Do
                End If
            Loop
        End Sub

        Public Function GetFrame(ByVal Index As Integer) As SpriteFrame
            If (Me.m_Version <> &H3E9) Then
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

        Private Function ReadFrame(ByVal Index As Integer) As SpriteFrame
            Dim input As New MemoryStream(Me.m_ChunkData)
            Dim reader As New BinaryReader(input) With { _
                .BaseStream = { Position:=CULng(Me.m_OffsetTable.Item(Index)) } _
            }
            Dim frame As New SpriteFrame
            If Not Me.m_IsBigEndian Then
                reader.ReadBytes(4)
                frame.Height = reader.ReadUInt16
                frame.Width = reader.ReadUInt16
                frame.PaletteID = CUShort(Me.m_PaletteID)
            Else
                reader.ReadBytes(4)
                frame.Height = Endian.SwapUInt16(reader.ReadUInt16)
                frame.Width = Endian.SwapUInt16(reader.ReadUInt16)
                frame.PaletteID = CUShort(Me.m_PaletteID)
            End If
            frame.Init(True, False)
            Me.DecompressFrame2(frame, reader)
            frame.BitmapData.Unlock(True)
            Me.m_Frames.Add(frame)
            Return frame
        End Function


        ' Properties
        Public ReadOnly Property FrameCount As UInt32
            Get
                Return Me.m_FrameCount
            End Get
        End Property


        ' Fields
        Private m_ChunkData As Byte()
        Private m_FrameCount As UInt32
        Private m_Frames As List(Of SpriteFrame)
        Private m_IsBigEndian As Boolean
        Private m_OffsetTable As List(Of UInt32)
        Private m_PaletteID As UInt32
        Private m_PMap As PaletteMap
        Private m_Version As UInt32
    End Class
End Namespace

