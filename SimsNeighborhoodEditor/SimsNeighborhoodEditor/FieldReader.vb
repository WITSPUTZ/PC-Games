Imports System

Namespace SimsLib.IFF
    Public Class FieldReader
        ' Methods
        Public Function DecodeField(ByRef Data As FieldEncodingData, ByVal FieldType As Byte, ByRef Value As Long) As Integer
            Dim num As Long = 0
            Dim num2 As Long = 0
            If (Me.ReadBits(Data, 1, Value) = 0) Then
                Return 0
            End If
            If (Not Value Is 0) Then
                If (Me.ReadBits(Data, 2, num) = 0) Then
                    Return 0
                End If
                num2 = Data.FieldWidths(CInt(DirectCast(((FieldType * 4) + num), IntPtr)))
                If (Me.ReadBits(Data, CByte(num2), Value) = 0) Then
                    Return 0
                End If
                Value = (Value Or -(Value And (CLng(1) << CByte((num2 - 1)))))
            End If
            Return 1
        End Function

        Private Function ReadBits(ByRef FieldData As FieldEncodingData, ByVal Width As Byte, ByRef Value As Long) As Integer
            Do While (FieldData.BitBufferCount < Width)
                If (FieldData.ReadDataLength >= FieldData.EncodedDataLength) Then
                    Return 0
                End If
                FieldData.BitBuffer = (FieldData.BitBuffer << 8)
                FieldData.BitBuffer = (FieldData.BitBuffer Or FieldData.EncodedData(FieldData.FieldDataCounter))
                FieldData.BitBufferCount = CByte((FieldData.BitBufferCount + 8))
                FieldData.ReadDataLength += 1
            Loop
            Value = (FieldData.BitBuffer >> (FieldData.BitBufferCount - Width))
            Value = (Value And ((CLng(1) << Width) - 1))
            FieldData.BitBufferCount = CByte((FieldData.BitBufferCount - Width))
            Return 1
        End Function

    End Class
End Namespace

