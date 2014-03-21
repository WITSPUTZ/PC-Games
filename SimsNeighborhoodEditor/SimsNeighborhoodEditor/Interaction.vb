Imports System
Imports System.Collections.Generic

Namespace SimsLib.IFF
    Public Class Interaction
        ' Fields
        Public ActionFuncID As Short
        Public AttenuationCode As UInt32
        Public AttenuationValue As Single
        Public AutonomyThreshold As UInt32
        Public Flags As UInt32
        Public GuardFuncID As Short
        Public JoiningIndex As Integer
        Public MotiveEntryCount As UInt32
        Public Motives As List(Of Motive) = New List(Of Motive)
        Public TTAID As UInt32
    End Class
End Namespace

