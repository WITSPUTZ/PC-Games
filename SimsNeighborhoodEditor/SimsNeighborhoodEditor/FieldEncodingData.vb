Imports System
Imports System.Runtime.InteropServices

Namespace SimsLib.IFF
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure FieldEncodingData
        Public CompressionCode As Byte
        Public FieldWidths As Byte()
        Public EncodedDataLength As UInt32
        Public FieldDataCounter As Integer
        Public EncodedData As Byte()
        Public ReadDataLength As UInt32
        Public BitBufferCount As Byte
        Public BitBuffer As Long
    End Structure
End Namespace

