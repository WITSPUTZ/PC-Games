Imports System
Imports System.Runtime.InteropServices

Namespace SimsLib.IFF
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure BHAVBlock
        Public Flow As Byte
        Public Loc As Byte
        Public Type As Byte
        Public Pop As Byte
    End Structure
End Namespace

