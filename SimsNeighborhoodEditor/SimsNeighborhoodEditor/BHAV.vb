Imports System
Imports System.Collections.Generic
Imports System.IO

Namespace SimsLib.IFF
    Public Class BHAV
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk)
            MyBase.New(Chunk)
            Me.m_ChunkID = Me.ChunkID
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            Me.m_Instructions = New List(Of Byte())
            Dim buffer As Byte() = reader.ReadBytes(12)
            Me.m_Signature = CUShort(((buffer(1) << 8) Or buffer(0)))
            Dim num As Integer = 0
            Select Case Me.m_Signature
                Case &H8000, &H8001
                    Me.m_HeaderLength = 12
                    num = ((buffer(3) << 8) Or buffer(4))
                    Me.m_Locals = 0
                    Me.m_Params = 4
                    Exit Select
                Case &H8002
                    Me.m_HeaderLength = 12
                    num = ((buffer(3) << 8) Or buffer(4))
                    Me.m_Type = buffer(5)
                    Me.m_Params = buffer(6)
                    Me.m_Locals = CUShort(((buffer(7) << 8) Or buffer(8)))
                    Me.m_Flags = CUShort(((buffer(9) << 8) Or buffer(10)))
                    Exit Select
                Case &H8003
                    Me.m_HeaderLength = 13
                    num = ((((((reader.ReadByte << 8) Or buffer(11)) << 8) Or buffer(10)) << 8) Or buffer(9))
                    Me.m_Type = buffer(3)
                    Me.m_Params = buffer(4)
                    Me.m_Locals = buffer(5)
                    Me.m_Flags = CUShort(((buffer(8) << 8) Or buffer(9)))
                    Exit Select
            End Select
            Me.m_NumInstructions = CByte(num)
            If ((num > 0) AndAlso (num <= &HFD)) Then
                Dim i As Integer
                For i = 0 To num - 1
                    Me.m_Instructions.Add(reader.ReadBytes(12))
                Next i
            End If
        End Sub


        ' Properties
        Public ReadOnly Property ChunkID As Integer
            Get
                Return Me.m_ChunkID
            End Get
        End Property

        Public ReadOnly Property HeaderLength As Byte
            Get
                Return Me.m_HeaderLength
            End Get
        End Property

        Public ReadOnly Property Instructions As List(Of Byte())
            Get
                Return Me.m_Instructions
            End Get
        End Property

        Public ReadOnly Property Locals As UInt16
            Get
                Return Me.m_Locals
            End Get
        End Property

        Public ReadOnly Property NumInstructions As Byte
            Get
                Return Me.m_NumInstructions
            End Get
        End Property

        Public ReadOnly Property Params As Byte
            Get
                Return Me.m_Params
            End Get
        End Property


        ' Fields
        Private m_ChunkID As Integer
        Private m_Field1 As UInt16
        Private m_Field2 As Integer
        Private m_Flags As UInt16
        Private m_HeaderLength As Byte
        Private m_Instructions As List(Of Byte())
        Private m_Locals As UInt16
        Private m_NumInstructions As Byte
        Private m_Params As Byte
        Private m_Signature As UInt16
        Private m_Type As Byte
    End Class
End Namespace

