Imports System
Imports System.Collections.Generic
Imports System.Drawing

Namespace SimsLib.IFF
    Public Class DrawGroupImg
        ' Methods
        Public Sub New(ByVal SpriteCount As UInt32, ByVal DirectionFlag As UInt32, ByVal Zoom As UInt32)
            Me.m_SpriteCount = SpriteCount
            Me.m_DirectionFlag = DirectionFlag
            Me.m_Zoom = Zoom
        End Sub

        Public Sub CompileSprites()
            Me.m_CompiledBitmap = New Bitmap(&H88, &H180)
            Dim graphics As Graphics = Graphics.FromImage(Me.m_CompiledBitmap)
            Dim sprite As DrawGroupSprite
            For Each sprite In Me.Sprites
                Dim num As Integer = ((Me.m_CompiledBitmap.Width / 2) + sprite.SpriteOffset.X)
                Dim num2 As Integer = ((Me.m_CompiledBitmap.Height / 2) + sprite.SpriteOffset.Y)
                graphics.DrawImageUnscaled(sprite.Bitmap, sprite.Sprite.XLocation, sprite.Sprite.YLocation)
            Next
            graphics.Dispose
        End Sub


        ' Properties
        Public ReadOnly Property CompiledBitmap As Bitmap
            Get
                Return Me.m_CompiledBitmap
            End Get
        End Property

        Public ReadOnly Property DirectionFlag As UInt32
            Get
                Return Me.m_DirectionFlag
            End Get
        End Property

        Public ReadOnly Property SpriteCount As UInt32
            Get
                Return Me.m_SpriteCount
            End Get
        End Property

        Public ReadOnly Property Sprites As List(Of DrawGroupSprite)
            Get
                Return Me.m_Sprites
            End Get
        End Property

        Public ReadOnly Property Zoom As UInt32
            Get
                Return Me.m_Zoom
            End Get
        End Property


        ' Fields
        Private m_CompiledBitmap As Bitmap
        Private m_DirectionFlag As UInt32
        Private m_SpriteCount As UInt32
        Private m_Sprites As List(Of DrawGroupSprite) = New List(Of DrawGroupSprite)
        Private m_Zoom As UInt32
    End Class
End Namespace

