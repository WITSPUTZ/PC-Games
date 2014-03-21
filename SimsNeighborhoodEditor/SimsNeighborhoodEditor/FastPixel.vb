Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Namespace SimsLib.IFF
    Public Class FastPixel
        ' Methods
        Public Sub New(ByVal BMap As Bitmap, ByVal IsAlpha As Boolean)
            If (BMap.PixelFormat = PixelFormat.Indexed) Then
                Throw New Exception("Cannot lock an indexed bitmap - fastpixel.cs!")
            End If
            Me.m_Bitmap = BMap
            If IsAlpha Then
                Me.m_IsAlpha = True
            End If
            Me.m_Width = BMap.Width
            Me.m_Height = BMap.Height
        End Sub

        Public Sub Clear(ByVal Clr As Color)
            Dim num As Integer
            If Not Me.m_Locked Then
                Throw New Exception("Bitmap not locked - fastpixel.cs!")
            End If
            If Me.m_IsAlpha Then
                num = 0
                Do While (num < Me.m_RGBValues.Length)
                    Me.m_RGBValues(num) = Clr.B
                    Me.m_RGBValues((num + 1)) = Clr.G
                    Me.m_RGBValues((num + 2)) = Clr.R
                    Me.m_RGBValues((num + 3)) = Clr.A
                    num = (num + 4)
                Loop
            Else
                num = 0
                Do While (num < Me.m_RGBValues.Length)
                    Me.m_RGBValues(num) = Clr.B
                    Me.m_RGBValues((num + 1)) = Clr.G
                    Me.m_RGBValues((num + 2)) = Clr.R
                    num = (num + 3)
                Loop
            End If
        End Sub

        Public Function GetPixel(ByVal Location As Point) As Color
            Return Me.GetPixel(Location.X, Location.Y)
        End Function

        Private Function GetPixel(ByVal X As Integer, ByVal Y As Integer) As Color
            Dim num As Integer
            Dim num2 As Integer
            Dim num3 As Integer
            Dim num4 As Integer
            If Not Me.m_Locked Then
                Throw New Exception("Bitmap not locked - fastpixel.cs!")
            End If
            If Me.m_IsAlpha Then
                num = (((Y * Me.m_Width) + X) * 4)
                num2 = Me.m_RGBValues(num)
                num3 = Me.m_RGBValues((num + 1))
                num4 = Me.m_RGBValues((num + 2))
                Dim alpha As Integer = Me.m_RGBValues((num + 3))
                Return Color.FromArgb(alpha, num4, num3, num2)
            End If
            num = (((Y * Me.m_Width) + X) * 3)
            num2 = Me.m_RGBValues(num)
            num3 = Me.m_RGBValues((num + 1))
            num4 = Me.m_RGBValues((num + 2))
            Return Color.FromArgb(num4, num3, num2)
        End Function

        Public Sub Lock()
            Dim buffer As Byte()
            If Me.m_Locked Then
                Throw New Exception("Bitmap already locked - fastpixel.cs!")
            End If
            Dim rect As New Rectangle(0, 0, Me.m_Width, Me.m_Height)
            Me.m_BMPData = Me.m_Bitmap.LockBits(rect, ImageLockMode.ReadWrite, Me.m_Bitmap.PixelFormat)
            Me.m_BMPPtr = Me.m_BMPData.Scan0
            If Me.m_IsAlpha Then
                buffer = New Byte(((Me.m_Width * Me.m_Height) * 4)  - 1) {}
                Me.m_RGBValues = New Byte(buffer.Length  - 1) {}
                Marshal.Copy(Me.m_BMPPtr, Me.m_RGBValues, 0, Me.m_RGBValues.Length)
            Else
                buffer = New Byte(((Me.m_Width * Me.m_Height) * 3)  - 1) {}
                Me.m_RGBValues = New Byte(buffer.Length  - 1) {}
                Marshal.Copy(Me.m_BMPPtr, Me.m_RGBValues, 0, Me.m_RGBValues.Length)
            End If
            Me.m_Locked = True
        End Sub

        Public Sub SetPixel(ByVal Location As Point, ByVal Clr As Color)
            Me.SetPixel(Location.X, Location.Y, Clr)
        End Sub

        Private Sub SetPixel(ByVal X As Integer, ByVal Y As Integer, ByVal Clr As Color)
            Dim num As Integer
            If Not Me.m_Locked Then
                Throw New Exception("Bitmap not locked - fastpixel.cs!")
            End If
            If Me.m_IsAlpha Then
                num = (((Y * Me.m_Width) + X) * 4)
                Me.m_RGBValues(num) = Clr.B
                Me.m_RGBValues((num + 1)) = Clr.G
                Me.m_RGBValues((num + 2)) = Clr.R
                Me.m_RGBValues((num + 3)) = Clr.A
            Else
                num = (((Y * Me.m_Width) + X) * 3)
                Me.m_RGBValues(num) = Clr.B
                Me.m_RGBValues((num + 1)) = Clr.G
                Me.m_RGBValues((num + 2)) = Clr.R
            End If
        End Sub

        Public Sub Unlock(ByVal SetPixels As Boolean)
            If Not Me.m_Locked Then
                Throw New Exception("Bitmap not locked - fastpixel.cs!")
            End If
            If SetPixels Then
                Marshal.Copy(Me.m_RGBValues, 0, Me.m_BMPPtr, Me.m_RGBValues.Length)
            End If
            Me.m_Bitmap.UnlockBits(Me.m_BMPData)
            Me.m_Locked = False
        End Sub


        ' Properties
        Public ReadOnly Property BitMap As Bitmap
            Get
                Return Me.m_Bitmap
            End Get
        End Property

        Public ReadOnly Property Height As Integer
            Get
                Return Me.m_Height
            End Get
        End Property

        Public ReadOnly Property IsAlphaBitmap As Boolean
            Get
                Return Me.m_IsAlpha
            End Get
        End Property

        Public ReadOnly Property Width As Integer
            Get
                Return Me.m_Width
            End Get
        End Property


        ' Fields
        Private m_Bitmap As Bitmap
        Private m_BMPData As BitmapData
        Private m_BMPPtr As IntPtr
        Private m_Height As Integer
        Private m_IsAlpha As Boolean = False
        Private m_Locked As Boolean = False
        Private m_RGBValues As Byte()
        Private m_Width As Integer
    End Class
End Namespace

