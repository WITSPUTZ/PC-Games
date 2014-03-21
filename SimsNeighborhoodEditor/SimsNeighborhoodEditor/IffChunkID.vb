Imports System

Namespace SimsLib.IFF
    Public Class IffChunkID
        ' Methods
        Private Shared Function ToChunkID(ByVal StrID As String) As UInt32
            Dim num As UInt32 = StrID.Chars(0)
            Dim num2 As UInt32 = StrID.Chars(1)
            Dim num3 As UInt32 = StrID.Chars(2)
            Dim num4 As UInt32 = StrID.Chars(3)
            Return ((((num << &H18) Or (num2 << &H10)) Or (num3 << 8)) Or num4)
        End Function


        ' Properties
        Public Shared ReadOnly Property BHAV As UInt32
            Get
                Return IffChunkID.ToChunkID("BHAV")
            End Get
        End Property

        Public Shared ReadOnly Property DGRP As UInt32
            Get
                Return IffChunkID.ToChunkID("DGRP")
            End Get
        End Property

        Public Shared ReadOnly Property OBJF As UInt32
            Get
                Return IffChunkID.ToChunkID("OBJf")
            End Get
        End Property

        Public Shared ReadOnly Property PALT As UInt32
            Get
                Return IffChunkID.ToChunkID("PALT")
            End Get
        End Property

        Public Shared ReadOnly Property RSMP As UInt32
            Get
                Return IffChunkID.ToChunkID("rsmp")
            End Get
        End Property

        Public Shared ReadOnly Property SPR As UInt32
            Get
                Return IffChunkID.ToChunkID("SPR#")
            End Get
        End Property

        Public Shared ReadOnly Property SPR2 As UInt32
            Get
                Return IffChunkID.ToChunkID("SPR2")
            End Get
        End Property

    End Class
End Namespace

