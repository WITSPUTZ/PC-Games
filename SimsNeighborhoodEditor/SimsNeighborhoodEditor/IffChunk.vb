Imports System
Imports System.Collections.Generic

Namespace SimsLib.IFF
    Public Class IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk)
            Me.m_Children = New List(Of IffChunk)
            Me.m_ID = Chunk.ID
            Me.m_Length = Chunk.Length
            Me.m_NameStr = Chunk.NameString
            Me.m_Resource = Chunk.Resource
            Me.m_PadByte = Chunk.PadByte
        End Sub

        Public Sub New(ByVal Resource As String)
            Me.m_Children = New List(Of IffChunk)
            Me.m_Resource = Resource
        End Sub


        ' Properties
        Public Property Data As Byte()
            Get
                Return Me.m_Data
            End Get
            Set(ByVal value As Byte())
                Me.m_Data = value
            End Set
        End Property

        Public Property ID As Integer
            Get
                Return Me.m_ID
            End Get
            Set(ByVal value As Integer)
                Me.m_ID = value
            End Set
        End Property

        Public Property Length As UInt32
            Get
                Return Me.m_Length
            End Get
            Set(ByVal value As UInt32)
                Me.m_Length = value
            End Set
        End Property

        Public Property NameString As String
            Get
                Return Me.m_NameStr
            End Get
            Set(ByVal value As String)
                Me.m_NameStr = value
            End Set
        End Property

        Public Property PadByte As Integer
            Get
                Return Me.m_PadByte
            End Get
            Set(ByVal value As Integer)
                Me.m_PadByte = value
            End Set
        End Property

        Public ReadOnly Property Resource As String
            Get
                Return Me.m_Resource
            End Get
        End Property


        ' Fields
        Private m_Children As List(Of IffChunk)
        Private m_Data As Byte()
        Protected m_ID As Integer
        Private m_Length As UInt32
        Private m_NameStr As String
        Private m_PadByte As Integer
        Private m_Resource As String
    End Class
End Namespace

