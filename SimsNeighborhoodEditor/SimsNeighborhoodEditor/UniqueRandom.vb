Imports System
Imports System.Collections.Generic

Namespace SimsLib.IFF
    Public Class UniqueRandom
        ' Methods
        Public Sub New(ByVal requiredRangeLow As Integer, ByVal requiredRangeHi As Integer)
            Dim num As Integer = (requiredRangeHi - requiredRangeLow)
            Dim collection As Integer() = New Integer((num + 1)  - 1) {}
            Dim i As Integer
            For i = 0 To collection.Length - 1
                collection(i) = (requiredRangeLow + i)
            Next i
            Me.RemainingNumbers = New List(Of Integer)
            Me.RemainingNumbers.AddRange(collection)
        End Sub

        Public Function NewRandomNumber() As Integer
            If (Me.RemainingNumbers.Count = 0) Then
                Throw New InvalidOperationException("All numbers in the range have now been used.Cannot continue selecting random numbers from a list with no members.")
            End If
            Dim index As Integer = Me.m_random.Next(0, Me.RemainingNumbers.Count)
            Me.m_newRandomNumber = Me.RemainingNumbers.Item(index)
            Me.RemainingNumbers.RemoveAt(index)
            Return Me.m_newRandomNumber
        End Function


        ' Fields
        Private m_newRandomNumber As Integer = 0
        Private m_random As Random = New Random
        Private RemainingNumbers As List(Of Integer)
    End Class
End Namespace

