Imports LogThis
Imports System
Imports System.IO
Imports System.Runtime.Serialization

Namespace SimsLib.IFF
    <Serializable> _
    Public Class OBJD
        Implements ISerializable
        ' Methods
        Public Sub New(ByVal ChunkData As Byte(), ByVal ID As Integer)
            Me.IsMaster = False
            Me.IsMultiTile = False
            Me.m_ID = ID
            Dim input As New MemoryStream(ChunkData)
            Dim reader As New BinaryReader(input)
            Me.m_Version = reader.ReadInt32
            If (Me.m_Version <> &H8A) Then
                Log.LogThis(("Tried loading OBJD chunk version: " & Me.m_Version & " (SimsLib.dll)"), eloglevel.error)
            Else
                Me.m_InitStackSize = reader.ReadUInt16
                Me.m_BaseGraphicID = reader.ReadUInt16
                Me.m_NumGraphics = reader.ReadUInt16
                Me.m_MainFuncID = reader.ReadUInt16
                Me.m_GardeningFuncID = reader.ReadUInt16
                Me.m_TreeTableID = reader.ReadUInt16
                Me.m_InteractionGroup = reader.ReadUInt16
                Me.m_ObjectType = DirectCast(reader.ReadUInt16, ObjectType)
                Me.m_MasterID = reader.ReadUInt16
                If (Me.m_MasterID <> 0) Then
                    Me.IsMultiTile = True
                End If
                If Me.IsMultiTile Then
                    Me.m_SubIndex = reader.ReadUInt16
                    If (CShort(Me.m_SubIndex) = -1) Then
                        Me.IsMaster = True
                    End If
                End If
                Me.m_WashHandsID = reader.ReadUInt16
                Me.m_AnimTableID = reader.ReadUInt16
                Me.m_GUID = reader.ReadUInt32
                Me.m_Disabled = reader.ReadUInt16
                Me.m_Portal = reader.ReadUInt16
                Me.m_Price = reader.ReadUInt16
                If (Me.m_ObjectType = ObjectType.Person) Then
                    Me.m_BodyStringsID = reader.ReadUInt16
                End If
                Me.m_SLOTID = reader.ReadUInt16
                Me.m_AllowsIntersectionID = reader.ReadUInt16
                reader.ReadBytes(4)
                Me.m_PrepareFoodID = reader.ReadUInt16
                Me.m_CookFoodID = reader.ReadUInt16
                Me.m_PlaceOnSurfaceID = reader.ReadUInt16
                Me.m_DisposeID = reader.ReadUInt16
                Me.m_EatFoodID = reader.ReadUInt16
                Me.m_PickupFromSlotID = reader.ReadUInt16
                Me.m_WashDishID = reader.ReadUInt16
                Me.m_EatingSurfaceID = reader.ReadUInt16
                Me.m_SitID = reader.ReadUInt16
                Me.m_StandID = reader.ReadUInt16
                Me.m_SalePrice = reader.ReadUInt16
                Me.m_InitialDepreciation = reader.ReadUInt16
                Me.m_DailyDepreciation = reader.ReadUInt16
                Me.m_SelfDepreciating = reader.ReadUInt16
                Me.m_DepreciationLimit = reader.ReadUInt16
            End If
        End Sub

        Public Sub New(ByVal Info As SerializationInfo, ByVal Context As StreamingContext)
            Me.IsMaster = False
            Me.IsMultiTile = False
            Me.m_Version = CInt(Info.GetValue("Version", GetType(Integer)))
            Me.m_InitStackSize = CUShort(Info.GetValue("InitStackSize", GetType(UInt16)))
            Me.m_BaseGraphicID = CUShort(Info.GetValue("BaseGraphicID", GetType(UInt16)))
            Me.m_NumGraphics = CUShort(Info.GetValue("NumGraphics", GetType(UInt16)))
            Me.m_MainFuncID = CUShort(Info.GetValue("MainFuncID", GetType(UInt16)))
            Me.m_GardeningFuncID = CUShort(Info.GetValue("GardeningFuncID", GetType(UInt16)))
            Me.m_TreeTableID = CUShort(Info.GetValue("TreeTableID", GetType(UInt16)))
            Me.m_InteractionGroup = CUShort(Info.GetValue("InteractionGroup", GetType(UInt16)))
            Me.m_ObjectType = DirectCast(Info.GetValue("ObjectType", GetType(ObjectType)), ObjectType)
            Me.m_MasterID = CUShort(Info.GetValue("MasterID", GetType(UInt16)))
            Me.IsMaster = CBool(Info.GetValue("IsMaster", GetType(Boolean)))
            Me.IsMultiTile = CBool(Info.GetValue("IsMultiTile", GetType(Boolean)))
            Me.m_WashHandsID = CUShort(Info.GetValue("WashHandsID", GetType(UInt16)))
            Me.m_AnimTableID = CUShort(Info.GetValue("AnimTableID", GetType(UInt16)))
            Me.m_GUID = DirectCast(Info.GetValue("GUID", GetType(UInt32)), UInt32)
            Me.m_Disabled = CUShort(Info.GetValue("Disabled", GetType(UInt16)))
            Me.m_Portal = CUShort(Info.GetValue("Portal", GetType(UInt16)))
            Me.m_Price = CUShort(Info.GetValue("Price", GetType(UInt16)))
            Me.m_BodyStringsID = CUShort(Info.GetValue("BodyStringsID", GetType(UInt16)))
            Me.m_SLOTID = CUShort(Info.GetValue("SLOTID", GetType(UInt16)))
            Me.m_AllowsIntersectionID = CUShort(Info.GetValue("AllowsIntersection", GetType(UInt16)))
            Me.m_PrepareFoodID = CUShort(Info.GetValue("PrepareFoodID", GetType(UInt16)))
            Me.m_CookFoodID = CUShort(Info.GetValue("CookFoodID", GetType(UInt16)))
            Me.m_PlaceOnSurfaceID = CUShort(Info.GetValue("PlaceOnSurfaceID", GetType(UInt16)))
            Me.m_DisposeID = CUShort(Info.GetValue("DisposeID", GetType(UInt16)))
            Me.m_EatFoodID = CUShort(Info.GetValue("EatFoodID", GetType(UInt16)))
            Me.m_PickupFromSlotID = CUShort(Info.GetValue("PickupFromSlotID", GetType(UInt16)))
            Me.m_WashDishID = CUShort(Info.GetValue("WashDishID", GetType(UInt16)))
            Me.m_SitID = CUShort(Info.GetValue("SitID", GetType(UInt16)))
            Me.m_StandID = CUShort(Info.GetValue("StandID", GetType(UInt16)))
            Me.m_SalePrice = CUShort(Info.GetValue("SalePrice", GetType(UInt16)))
            Me.m_InitialDepreciation = CUShort(Info.GetValue("InitialDepreciation", GetType(UInt16)))
            Me.m_DailyDepreciation = CUShort(Info.GetValue("DailyDepreciation", GetType(UInt16)))
            Me.m_SelfDepreciating = CUShort(Info.GetValue("SelfDepreciating", GetType(UInt16)))
            Me.m_DepreciationLimit = CUShort(Info.GetValue("DepreciationLimit", GetType(UInt16)))
        End Sub

        Public Sub GetObjectData(ByVal Info As SerializationInfo, ByVal Context As StreamingContext)
            Info.AddValue("Version", Me.m_Version)
            Info.AddValue("InitStackSize", Me.m_InitStackSize)
            Info.AddValue("BaseGraphicID", Me.m_BaseGraphicID)
            Info.AddValue("NumGraphics", Me.m_NumGraphics)
            Info.AddValue("MainFuncID", Me.m_MainFuncID)
            Info.AddValue("GardeningFuncID", Me.m_GardeningFuncID)
            Info.AddValue("TreeTableID", Me.m_TreeTableID)
            Info.AddValue("InteractionGroup", Me.m_InteractionGroup)
            Info.AddValue("ObjectType", Me.m_ObjectType)
            Info.AddValue("MasterID", Me.m_MasterID)
            Info.AddValue("IsMaster", Me.IsMaster)
            Info.AddValue("IsMultiTile", Me.IsMultiTile)
            Info.AddValue("WashHandsID", Me.m_WashHandsID)
            Info.AddValue("AnimTableID", Me.m_AnimTableID)
            Info.AddValue("GUID", Me.m_GUID)
            Info.AddValue("Disabled", Me.m_Disabled)
            Info.AddValue("Portal", Me.m_Portal)
            Info.AddValue("Price", Me.m_Price)
            Info.AddValue("BodyStringsID", Me.m_BodyStringsID)
            Info.AddValue("SLOTID", Me.m_SLOTID)
            Info.AddValue("AllowsIntersection", Me.m_AllowsIntersectionID)
            Info.AddValue("PrepareFoodID", Me.m_PrepareFoodID)
            Info.AddValue("CookFoodID", Me.m_CookFoodID)
            Info.AddValue("PlaceOnSurfaceID", Me.m_PlaceOnSurfaceID)
            Info.AddValue("DisposeID", Me.m_DisposeID)
            Info.AddValue("EatFoodID", Me.m_EatFoodID)
            Info.AddValue("PickupFromSlotID", Me.m_PickupFromSlotID)
            Info.AddValue("WashDishID", Me.m_WashDishID)
            Info.AddValue("SitID", Me.m_SitID)
            Info.AddValue("StandID", Me.m_StandID)
            Info.AddValue("SalePrice", Me.m_SalePrice)
            Info.AddValue("InitialDepreciation", Me.m_InitialDepreciation)
            Info.AddValue("DailyDepreciation", Me.m_DailyDepreciation)
            Info.AddValue("SelfDepreciating", Me.m_SelfDepreciating)
            Info.AddValue("DepreciationLimit", Me.m_DepreciationLimit)
        End Sub


        ' Properties
        Public ReadOnly Property AllowsIntersectionID As UInt16
            Get
                Return Me.m_AllowsIntersectionID
            End Get
        End Property

        Public ReadOnly Property BaseGraphicsID As UInt16
            Get
                Return Me.m_BaseGraphicID
            End Get
        End Property

        Public ReadOnly Property BodystringsID As UInt16
            Get
                Return Me.m_BodyStringsID
            End Get
        End Property

        Public ReadOnly Property ChunkID As Integer
            Get
                Return Me.m_ID
            End Get
        End Property

        Public ReadOnly Property Disabled As UInt16
            Get
                Return Me.m_Disabled
            End Get
        End Property

        Public ReadOnly Property GardeningFuncID As UInt16
            Get
                Return Me.m_GardeningFuncID
            End Get
        End Property

        Public ReadOnly Property GUID As UInt32
            Get
                Return Me.m_GUID
            End Get
        End Property

        Public ReadOnly Property InitialStackSize As UInt16
            Get
                Return Me.m_InitStackSize
            End Get
        End Property

        Public ReadOnly Property MainFuncID As UInt16
            Get
                Return Me.m_MainFuncID
            End Get
        End Property

        Public ReadOnly Property MasterID As UInt16
            Get
                Return Me.m_MasterID
            End Get
        End Property

        Public ReadOnly Property NumGraphics As UInt16
            Get
                Return Me.m_NumGraphics
            End Get
        End Property

        Public ReadOnly Property Portal As UInt16
            Get
                Return Me.m_Portal
            End Get
        End Property

        Public ReadOnly Property Price As UInt16
            Get
                Return Me.m_Price
            End Get
        End Property

        Public ReadOnly Property SLOTID As UInt16
            Get
                Return Me.m_SLOTID
            End Get
        End Property

        Public ReadOnly Property SubIndex As UInt16
            Get
                Return Me.m_SubIndex
            End Get
        End Property

        Public ReadOnly Property TreeTableID As UInt16
            Get
                Return Me.m_TreeTableID
            End Get
        End Property


        ' Fields
        Public IsMaster As Boolean
        Public IsMultiTile As Boolean
        Private m_AllowsIntersectionID As UInt16
        Private m_AnimTableID As UInt16
        Private m_BaseGraphicID As UInt16
        Private m_BodyStringsID As UInt16
        Private m_CookFoodID As UInt16
        Private m_DailyDepreciation As UInt16
        Private m_DepreciationLimit As UInt16
        Private m_Disabled As UInt16
        Private m_DisposeID As UInt16
        Private m_EatFoodID As UInt16
        Private m_EatingSurfaceID As UInt16
        Private m_GardeningFuncID As UInt16
        Private m_GUID As UInt32
        Private m_ID As Integer
        Private m_InitialDepreciation As UInt16
        Private m_InitStackSize As UInt16
        Private m_InteractionGroup As UInt16
        Private m_MainFuncID As UInt16
        Private m_MasterID As UInt16
        Private m_NumGraphics As UInt16
        Private m_ObjectType As ObjectType
        Private m_PickupFromSlotID As UInt16
        Private m_PlaceOnSurfaceID As UInt16
        Private m_Portal As UInt16
        Private m_PrepareFoodID As UInt16
        Private m_Price As UInt16
        Private m_SalePrice As UInt16
        Private m_SelfDepreciating As UInt16
        Private m_SitID As UInt16
        Private m_SLOTID As UInt16
        Private m_StandID As UInt16
        Private m_SubIndex As UInt16
        Private m_TreeTableID As UInt16
        Private m_Version As Integer
        Private m_WashDishID As UInt16
        Private m_WashHandsID As UInt16
    End Class
End Namespace

