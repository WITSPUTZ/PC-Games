Imports System
Imports System.Runtime.InteropServices

Namespace SimsLib.IFF
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure StringTableString
        Public LanguageCode As Byte
        Public Length As Byte
        Public Str As String
        Public Str2 As String
    End Structure
End Namespace

