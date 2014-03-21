Imports System
Imports System.Collections.Generic
Imports System.IO

Namespace SimsLib.IFF
    Public Class BCON
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk)
            MyBase.New(Chunk)
            Me.m_Constants = New List(Of Short)
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            Me.m_NumConstants = reader.ReadByte
            Me.m_Type = reader.ReadByte
            Dim i As Byte = 0
            Do While (i < Me.m_NumConstants)
                Dim item As Short = reader.ReadInt16
                Me.m_Constants.Add(item)
                i = CByte((i + 1))
            Loop
        End Sub


        ' Properties
        Public ReadOnly Property Constants As List(Of Short)
            Get
                Return Me.m_Constants
            End Get
        End Property

        Public ReadOnly Property NumConstants As Byte
            Get
                Return Me.m_NumConstants
            End Get
        End Property


        ' Fields
        Private m_Constants As List(Of Short)
        Private m_NumConstants As Byte
        Private m_Type As Byte
    End Class
End Namespace

