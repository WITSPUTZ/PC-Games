Imports System
Imports System.Drawing

Namespace SimsLib.IFF
    Public Class DrawGroupSprite
        ' Methods
        Public Sub New(ByVal type As UInt16, ByVal flags As UInt32, ByVal spriteOffset As PixelOffset, ByVal objectOffset As WorldOffset, ByVal frame As SpriteFrame)
            Me.m_Type = type
            Me.m_Flags = flags
            Me.m_SpriteOffset = spriteOffset
            Me.m_ObjectOffset = objectOffset
            Me.m_Sprite = frame
            Me.m_Bitmap = DirectCast(frame.BitmapData.BitMap.Clone, Bitmap)
            If ((Me.m_Flags And 1) = 1) Then
                Me.m_Bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX)
            End If
        End Sub


        ' Properties
        Public ReadOnly Property Bitmap As Bitmap
            Get
                Return Me.m_Bitmap
            End Get
        End Property

        Public ReadOnly Property Flags As UInt32
            Get
                Return Me.m_Flags
            End Get
        End Property

        Public ReadOnly Property ObjectOffset As WorldOffset
            Get
                Return Me.m_ObjectOffset
            End Get
        End Property

        Public ReadOnly Property Sprite As SpriteFrame
            Get
                Return Me.m_Sprite
            End Get
        End Property

        Public ReadOnly Property SpriteOffset As PixelOffset
            Get
                Return Me.m_SpriteOffset
            End Get
        End Property

        Public ReadOnly Property Type As UInt16
            Get
                Return Me.m_Type
            End Get
        End Property


        ' Fields
        Private m_Bitmap As Bitmap
        Private m_Flags As UInt32
        Private m_ObjectOffset As WorldOffset
        Private m_Sprite As SpriteFrame
        Private m_SpriteOffset As PixelOffset
        Private m_Type As UInt16
    End Class
End Namespace

