Imports System
Imports System.Runtime.InteropServices

Namespace SimsLib.IFF
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure WorldOffset
        Public X As Single
        Public Y As Single
        Public Z As Single
        Public Sub New(ByVal x As Single, ByVal y As Single, ByVal z As Single)
            Me.X = x
            Me.Y = y
            Me.Z = z
        End Sub
    End Structure
End Namespace

