Imports System
Imports System.Runtime.InteropServices

Namespace SimsLib.IFF
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure PixelOffset
        Public X As Integer
        Public Y As Integer
        Public Sub New(ByVal x As Integer, ByVal y As Integer)
            Me.X = x
            Me.Y = y
        End Sub
    End Structure
End Namespace

