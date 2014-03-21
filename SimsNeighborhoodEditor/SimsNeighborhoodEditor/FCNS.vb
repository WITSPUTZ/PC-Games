Imports System
Imports System.Collections.Generic
Imports System.IO

Namespace SimsLib.IFF
    Public Class FCNS
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk)
            MyBase.New(Chunk)
            Me.m_TuningConstants = New List(Of TuningConstant)
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            reader.ReadBytes(4)
            Me.m_Version = reader.ReadInt32
            reader.ReadBytes(4)
            Me.m_ConstantCount = reader.ReadUInt32
            Dim i As Integer
            For i = 0 To Me.m_ConstantCount - 1
                Dim item As New TuningConstant
                If (Me.m_Version = 1) Then
                    item.Name = Me.ReadZeroPaddedString(reader)
                    Dim buffer As Byte() = reader.ReadBytes(4)
                    If (buffer.Length = 0) Then
                        Me.m_TuningConstants.Add(item)
                        Exit For
                    End If
                    item.Value = BitConverter.ToSingle(buffer, 0)
                    item.Description = Me.ReadZeroPaddedString(reader)
                ElseIf (Me.m_Version = 2) Then
                    item.Name = reader.ReadString
                    item.Value = reader.ReadSingle
                    item.Description = reader.ReadString
                End If
                Me.m_TuningConstants.Add(item)
            Next i
        End Sub

        Private Function ReadZeroPaddedString(ByVal Reader As BinaryReader) As String
            Dim str As String = ""
            Dim num As Byte = 0
            Do While (num <> &HA3)
                num = Reader.ReadByte
                str = (str & DirectCast(num, Char))
            Loop
            Return str
        End Function


        ' Fields
        Private m_ConstantCount As UInt32
        Private m_TuningConstants As List(Of TuningConstant)
        Private m_Version As Integer
    End Class
End Namespace

