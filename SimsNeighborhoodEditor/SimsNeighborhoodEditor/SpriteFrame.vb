Imports System
Imports System.Drawing

Namespace SimsLib.IFF
    Public Class SpriteFrame
        ' Methods
        Public Sub Init(ByVal Alpha As Boolean, ByVal HasZBuffer As Boolean)
            Me.m_HasAlpha = Alpha
            If ((Me.m_Width > 0) AndAlso (Me.m_Height > 0)) Then
                Me.m_BitmapData = New FastPixel(New Bitmap(Me.m_Width, Me.m_Height), Alpha)
                Me.m_BitmapData.Lock
                If HasZBuffer Then
                    Me.m_HasZBuffer = True
                    Me.m_ZBuffer = New FastPixel(New Bitmap(Me.m_Width, Me.m_Height), Alpha)
                    Me.m_ZBuffer.Lock
                End If
            Else
                Me.m_BitmapData = New FastPixel(New Bitmap(1, 1), Alpha)
                Me.m_BitmapData.Lock
                If HasZBuffer Then
                    Me.m_HasZBuffer = True
                    Me.m_ZBuffer = New FastPixel(New Bitmap(1, 1), Alpha)
                    Me.m_ZBuffer.Lock
                End If
            End If
        End Sub


        ' Properties
        Public Property BitmapData As FastPixel
            Get
                Return Me.m_BitmapData
            End Get
            Set(ByVal value As FastPixel)
                Me.m_BitmapData = value
            End Set
        End Property

        Public Property Flag As UInt32
            Get
                Return Me.m_Flag
            End Get
            Set(ByVal value As UInt32)
                Me.m_Flag = value
            End Set
        End Property

        Public Property FrameIndex As UInt32
            Get
                Return Me.m_FrameIndex
            End Get
            Set(ByVal value As UInt32)
                Me.m_FrameIndex = value
            End Set
        End Property

        Public ReadOnly Property HasAlphaBuffer As Boolean
            Get
                Return Me.m_HasAlpha
            End Get
        End Property

        Public ReadOnly Property HasZBuffer As Boolean
            Get
                Return Me.m_HasZBuffer
            End Get
        End Property

        Public Property Height As UInt16
            Get
                Return Me.m_Height
            End Get
            Set(ByVal value As UInt16)
                Me.m_Height = value
            End Set
        End Property

        Public Property PaletteID As UInt16
            Get
                Return Me.m_PaletteID
            End Get
            Set(ByVal value As UInt16)
                Me.m_PaletteID = value
            End Set
        End Property

        Public Property PalMap As PaletteMap
            Get
                Return Me.m_PalMap
            End Get
            Set(ByVal value As PaletteMap)
                Me.m_PalMap = value
            End Set
        End Property

        Public Property Size As UInt32
            Get
                Return Me.m_Size
            End Get
            Set(ByVal value As UInt32)
                Me.m_Size = value
            End Set
        End Property

        Public Property TransparentPixel As Color
            Get
                Return Me.m_TransparentPixel
            End Get
            Set(ByVal value As Color)
                Me.m_TransparentPixel = value
            End Set
        End Property

        Public Property Version As UInt32
            Get
                Return Me.m_Version
            End Get
            Set(ByVal value As UInt32)
                Me.m_Version = value
            End Set
        End Property

        Public Property Width As UInt16
            Get
                Return Me.m_Width
            End Get
            Set(ByVal value As UInt16)
                Me.m_Width = value
            End Set
        End Property

        Public Property XLocation As UInt16
            Get
                Return Me.m_X
            End Get
            Set(ByVal value As UInt16)
                Me.m_X = value
            End Set
        End Property

        Public Property YLocation As UInt16
            Get
                Return Me.m_Y
            End Get
            Set(ByVal value As UInt16)
                Me.m_Y = value
            End Set
        End Property

        Public Property ZBuffer As FastPixel
            Get
                Return Me.m_ZBuffer
            End Get
            Set(ByVal value As FastPixel)
                Me.m_ZBuffer = value
            End Set
        End Property


        ' Fields
        Private m_BitmapData As FastPixel
        Private m_Flag As UInt32
        Private m_FrameIndex As UInt32
        Private m_HasAlpha As Boolean
        Private m_HasZBuffer As Boolean
        Private m_Height As UInt16
        Private m_PaletteID As UInt16
        Private m_PalMap As PaletteMap
        Private m_Size As UInt32
        Private m_TransparentPixel As Color
        Private m_Version As UInt32
        Private m_Width As UInt16
        Private m_X As UInt16
        Private m_Y As UInt16
        Private m_ZBuffer As FastPixel
    End Class
End Namespace

