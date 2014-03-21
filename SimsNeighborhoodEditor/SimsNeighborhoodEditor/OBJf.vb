Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text

Namespace SimsLib.IFF
    Public Class OBJf
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk)
            MyBase.New(Chunk)
            Me.m_FuncIDs = New List(Of IDPair)
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            reader.ReadBytes(8)
            If (Encoding.ASCII.GetString(reader.ReadBytes(4)) = "fJBO") Then
                Me.m_NumEntries = reader.ReadInt32
                Dim i As Integer
                For i = 0 To Me.m_NumEntries - 1
                    Dim item As New IDPair With { _
                        .GuardFuncID = reader.ReadUInt16, _
                        .FunctionID = reader.ReadUInt16 _
                    }
                    Me.m_FuncIDs.Add(item)
                Next i
            End If
        End Sub


        ' Properties
        Public ReadOnly Property FunctionIDs As List(Of IDPair)
            Get
                Return Me.m_FuncIDs
            End Get
        End Property


        ' Fields
        Private m_FuncIDs As List(Of IDPair)
        Private m_NumEntries As Integer
    End Class
End Namespace

