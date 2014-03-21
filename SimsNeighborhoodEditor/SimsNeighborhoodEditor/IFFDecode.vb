Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text

Namespace SimsLib.IFF
    <StructLayout(LayoutKind.Sequential), DefaultMember("Item")> _
    Public Structure IFFDecode
        Public Instruction As Byte()
        Public OutStream As StringBuilder
        Public Sub New(ByVal InstructionSet As Byte())
            Me.Instruction = InstructionSet
            Me.OutStream = New StringBuilder
        End Sub

        Public Function Operand(ByVal i As Integer) As Integer
            Return ((Me.Instruction((i + 1)) << 8) Or Me.Instruction(i))
        End Function

        Public ReadOnly Default Property Item(ByVal i As Integer) As Char
            Get
                Return DirectCast(Me.Instruction(i), Char)
            End Get
        End Property

    End Structure
End Namespace

