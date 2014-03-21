Imports LogThis
Imports System
Imports System.Collections.Generic
Imports System.IO

Namespace SimsLib.IFF
    Public Class TTAB
        Inherits IffChunk
        ' Methods
        Public Sub New(ByVal Chunk As IffChunk)
            MyBase.New(Chunk)
            Me.m_FReader = New FieldReader
            Me.m_Interactions = New List(Of Interaction)
            Dim input As New MemoryStream(Chunk.Data)
            Dim reader As New BinaryReader(input)
            Me.m_InteractionCount = reader.ReadUInt16
            If (Me.m_InteractionCount > 0) Then
                Me.m_Version = reader.ReadUInt16
                Try 
                    Dim num As Long = 0
                    If ((Me.m_Version = 9) OrElse (Me.m_Version = 10)) Then
                        Me.m_CompressionCode = reader.ReadByte
                        Me.m_FEncodingData.CompressionCode = Me.m_CompressionCode
                        Me.m_FEncodingData.FieldWidths = New Byte() { 5, 8, 13, &H10, 6, 11, &H15, &H20 }
                        Me.m_FEncodingData.EncodedDataLength = DirectCast((reader.BaseStream.Length - reader.BaseStream.Position), UInt32)
                        Me.m_FEncodingData.EncodedData = reader.ReadBytes(CInt(Me.m_FEncodingData.EncodedDataLength))
                    End If
                    Dim i As UInt16 = 0
                    Do While (i < Me.m_InteractionCount)
                        Dim interaction As Interaction
                        Dim num3 As UInt32
                        Dim motive As Motive
                        If ((Me.m_Version = 9) OrElse (Me.m_Version = 10)) Then
                            interaction = New Interaction
                            Me.m_FReader.DecodeField(Me.m_FEncodingData, 0, num)
                            interaction.ActionFuncID = CShort(num)
                            Me.m_FReader.DecodeField(Me.m_FEncodingData, 0, num)
                            interaction.GuardFuncID = CShort(num)
                            Me.m_FReader.DecodeField(Me.m_FEncodingData, 1, num)
                            interaction.MotiveEntryCount = DirectCast(num, UInt32)
                            Me.m_FReader.DecodeField(Me.m_FEncodingData, 1, num)
                            interaction.Flags = DirectCast(num, UInt32)
                            Me.m_FReader.DecodeField(Me.m_FEncodingData, 1, num)
                            interaction.TTAID = DirectCast(num, UInt32)
                            Me.m_FReader.DecodeField(Me.m_FEncodingData, 1, num)
                            interaction.AttenuationCode = DirectCast(num, UInt32)
                            Me.m_FReader.DecodeField(Me.m_FEncodingData, 1, num)
                            interaction.AttenuationValue = num
                            Me.m_FReader.DecodeField(Me.m_FEncodingData, 1, num)
                            interaction.AutonomyThreshold = DirectCast(num, UInt32)
                            Me.m_FReader.DecodeField(Me.m_FEncodingData, 1, num)
                            interaction.JoiningIndex = CInt(num)
                            num3 = 0
                            Do While (num3 < interaction.MotiveEntryCount)
                                motive = New Motive
                                Me.m_FReader.DecodeField(Me.m_FEncodingData, 0, num)
                                motive.EffectRangeMinimum = CShort(num)
                                Me.m_FReader.DecodeField(Me.m_FEncodingData, 0, num)
                                motive.EffectRangeMaximum = CShort(num)
                                Me.m_FReader.DecodeField(Me.m_FEncodingData, 0, num)
                                motive.PersonalityModifier = CUShort(num)
                                interaction.Motives.Add(motive)
                                num3 += 1
                            Loop
                            Me.m_Interactions.Add(interaction)
                            If (Me.m_Version = 10) Then
                                Me.m_FReader.DecodeField(Me.m_FEncodingData, 1, num)
                            End If
                        ElseIf ((((Me.m_Version = 5) OrElse (Me.m_Version = 7)) OrElse (Me.m_Version = 8)) OrElse (Me.m_Version = 11)) Then
                            interaction = New Interaction With { _
                                .ActionFuncID = reader.ReadInt16, _
                                .GuardFuncID = reader.ReadInt16, _
                                .MotiveEntryCount = reader.ReadUInt32, _
                                .Flags = reader.ReadUInt32, _
                                .TTAID = reader.ReadUInt32 _
                            }
                            If (Me.m_Version >= 7) Then
                                interaction.AttenuationCode = reader.ReadUInt32
                            End If
                            interaction.AttenuationValue = reader.ReadUInt32
                            interaction.AutonomyThreshold = reader.ReadUInt32
                            interaction.JoiningIndex = reader.ReadInt32
                            num3
                            For num3 = 0 To interaction.MotiveEntryCount - 1
                                motive = New Motive
                                If (Me.m_Version >= 7) Then
                                    motive.EffectRangeMinimum = reader.ReadInt16
                                End If
                                motive.EffectRangeMaximum = reader.ReadInt16
                                If (Me.m_Version >= 7) Then
                                    motive.PersonalityModifier = reader.ReadUInt16
                                End If
                                interaction.Motives.Add(motive)
                            Next num3
                            Me.m_Interactions.Add(interaction)
                            If (Me.m_Version = 11) Then
                                reader.ReadBytes(4)
                            End If
                        End If
                        i = CUShort((i + 1))
                    Loop
                Catch exception As Exception
                    Log.LogThis(String.Concat(New Object() { "Failed parsing a TTAB chunk!" & ChrW(13) & ChrW(10) & "Version: ", Me.m_Version, ChrW(13) & ChrW(10) & "InteractionCount: ", Me.m_InteractionCount, ChrW(13) & ChrW(10), exception.ToString }), eloglevel.error)
                End Try
            End If
            reader.Close
        End Sub


        ' Properties
        Public ReadOnly Property InteractionCount As UInt16
            Get
                Return Me.m_InteractionCount
            End Get
        End Property

        Public ReadOnly Property Version As UInt16
            Get
                Return Me.m_Version
            End Get
        End Property


        ' Fields
        Private m_CompressionCode As Byte
        Private m_FEncodingData As FieldEncodingData
        Private m_FReader As FieldReader
        Private m_InteractionCount As UInt16
        Private m_Interactions As List(Of Interaction)
        Private m_Version As UInt16
    End Class
End Namespace

