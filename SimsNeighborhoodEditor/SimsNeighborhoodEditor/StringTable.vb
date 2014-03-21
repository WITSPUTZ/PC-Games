Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text

Namespace SimsLib.IFF
    Public Class StringTable
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk)
            MyBase.New(Chunk)
            Dim num As Integer
            Dim str As StringTableString
            Dim ch As Char
            Dim builder As StringBuilder
            Dim flag As Boolean
            Me.m_Strings = New List(Of StringTableString)
            Me.m_StringSets = New List(Of StringSet)
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            Dim array As Byte() = reader.ReadBytes(2)
            Array.Reverse(array)
            Me.m_FormatCode = BitConverter.ToUInt16(array, 0)
            Select Case Me.m_FormatCode
                Case &HFDFF
                    Me.m_NumEntries = reader.ReadUInt16
                    num
                    For num = 0 To Me.m_NumEntries - 1
                        str = New StringTableString With { _
                            .LanguageCode = reader.ReadByte _
                        }
                        builder = New StringBuilder
                        goto Label_029A
                    Label_0276:
                        ch = DirectCast(reader.ReadByte, Char)
                        If (ch = ChrW(0)) Then
                            goto Label_029F
                        End If
                        builder.Append(ch)
                    Label_029A:
                        flag = True
                        goto Label_0276
                    Label_029F:
                        str.Str = builder.ToString
                        ch = ChrW(0)
                        builder = New StringBuilder
                        goto Label_02DD
                    Label_02B9:
                        ch = DirectCast(reader.ReadByte, Char)
                        If (ch = ChrW(0)) Then
                            goto Label_02E2
                        End If
                        builder.Append(ch)
                    Label_02DD:
                        flag = True
                        goto Label_02B9
                    Label_02E2:
                        str.Str2 = builder.ToString
                        Me.m_Strings.Add(str)
                    Next num
                    Exit Select
                Case &HFEFF
                    Me.m_NumEntries = reader.ReadUInt16
                    num
                    For num = 0 To Me.m_NumEntries - 1
                        str = New StringTableString
                        builder = New StringBuilder
                        goto Label_01D5
                    Label_01B1:
                        ch = reader.ReadChar
                        builder.Append(ch)
                        If (ch = ChrW(0)) Then
                            goto Label_01DA
                        End If
                    Label_01D5:
                        flag = True
                        goto Label_01B1
                    Label_01DA:
                        str.Str = builder.ToString
                        Me.m_Strings.Add(str)
                        builder = New StringBuilder
                        goto Label_0223
                    Label_01FF:
                        ch = reader.ReadChar
                        builder.Append(ch)
                        If (ch = ChrW(0)) Then
                            Continue For
                        End If
                    Label_0223:
                        flag = True
                        goto Label_01FF
                    Next num
                    Exit Select
                Case &HFFFF
                    Me.m_NumEntries = reader.ReadUInt16
                    num = 0
                    Do While (num < Me.m_NumEntries)
                        str = New StringTableString
                        builder = New StringBuilder
                        goto Label_0152
                    Label_012E:
                        ch = reader.ReadChar
                        builder.Append(ch)
                        If (ch = ChrW(0)) Then
                            goto Label_0157
                        End If
                    Label_0152:
                        flag = True
                        goto Label_012E
                    Label_0157:
                        str.Str = builder.ToString
                        Me.m_Strings.Add(str)
                        num += 1
                    Loop
                    Exit Select
                Case 0
                    If (reader.BaseStream.Position < reader.BaseStream.Length) Then
                        Me.m_NumEntries = reader.ReadUInt16
                        num
                        For num = 0 To Me.m_NumEntries - 1
                            str = New StringTableString With { _
                                .Str = Me.ReadPascalString(reader) _
                            }
                            Me.m_Strings.Add(str)
                        Next num
                    End If
                    Exit Select
                Case &HFCFF
                    Me.m_NumSets = reader.ReadByte
                    If (Me.m_NumSets >= 1) Then
                        num
                        For num = 0 To Me.m_NumSets - 1
                            Dim item As New StringSet With { _
                                .NumEntries = reader.ReadInt16 _
                            }
                            Dim i As Integer
                            For i = 0 To item.NumEntries - 1
                                str = New StringTableString With { _
                                    .LanguageCode = CByte((reader.ReadByte + 1)), _
                                    .Str = Me.ReadPascalString1(reader), _
                                    .Str2 = Me.ReadPascalString1(reader) _
                                }
                                item.Strings.Add(str)
                            Next i
                            Me.m_StringSets.Add(item)
                        Next num
                    End If
                    Exit Select
            End Select
            reader.Close
        End Sub

        Private Function ReadPascalString(ByVal Reader As BinaryReader) As String
            Dim count As Byte = Reader.ReadByte
            If (count = 0) Then
                Return ""
            End If
            Return New String(Reader.ReadChars(count))
        End Function

        Private Function ReadPascalString1(ByVal Reader As BinaryReader) As String
            Return Reader.ReadString
        End Function

        Private Function ReadZeroString(ByVal Reader As BinaryReader) As String
            Dim builder As New StringBuilder
            Dim chArray As Char() = New Char(2  - 1) {}
            Do While True
                chArray = Reader.ReadChars(2)
                builder.Append(chArray)
                If (New String(chArray) = ChrW(0) & ChrW(0)) Then
                    Return builder.ToString
                End If
            Loop
        End Function


        ' Properties
        Public ReadOnly Property FormatCode As Integer
            Get
                Return Me.m_FormatCode
            End Get
        End Property

        Public ReadOnly Property ResourceType As String
            Get
                Return MyBase.Resource
            End Get
        End Property

        Public ReadOnly Property Strings As List(Of StringTableString)
            Get
                Return Me.m_Strings
            End Get
        End Property

        Public ReadOnly Property StringSets As List(Of StringSet)
            Get
                Return Me.m_StringSets
            End Get
        End Property


        ' Fields
        Private m_FormatCode As UInt16
        Private m_NumEntries As UInt16
        Private m_NumSets As Byte
        Private m_Strings As List(Of StringTableString)
        Private m_StringSets As List(Of StringSet)
    End Class
End Namespace

