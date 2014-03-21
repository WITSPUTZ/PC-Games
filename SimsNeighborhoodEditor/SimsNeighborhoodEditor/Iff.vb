Imports SimsLib
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text

Namespace SimsLib.IFF
    Public Class Iff
        ' Methods
        Public Sub New(ByVal Data As Stream)
            Me.m_Chunks = New List(Of IffChunk)
            Me.m_PMaps = New List(Of PaletteMap)
            Me.m_DGroups = New List(Of DrawGroup)
            Me.m_SPRs = New List(Of SPRParser)
            Me.m_SPR2s = New List(Of SPR2Parser)
            Me.m_StringTables = New List(Of StringTable)
            Me.m_BHAVs = New List(Of BHAV)
            Me.m_OBJfs = New List(Of OBJf)
            Me.m_BCONs = New List(Of BCON)
            Me.m_TTABs = New List(Of TTAB)
            Me.m_OBJDs = New List(Of OBJD)
            Me.m_FBMPs = New List(Of FBMP)
            Me.m_BMP_s = New List(Of BMP_)
            Me.m_FCNSs = New List(Of FCNS)
            Me.m_UniqueRnd = New UniqueRandom(1, &H3E8)
            Me.m_Reader = New BinaryReader(Data)
            Me.ReadChunks
            Me.ParsePALTs
            Me.ParseSPRs
            Me.ParseSPR2s
            Me.ParseGroups
            Me.ParseStrings
            Me.ParseBHAVs
            Me.ParseOBJfs
            Me.ParseBCONs
            Me.ParseTTABs
            Me.ParseFBMPs
            Me.ParseBMP_s
            Me.ParseFCNSs
            Me.m_Reader.Close
        End Sub

        Public Sub New(ByVal Path As String)
            Me.m_Chunks = New List(Of IffChunk)
            Me.m_PMaps = New List(Of PaletteMap)
            Me.m_DGroups = New List(Of DrawGroup)
            Me.m_SPRs = New List(Of SPRParser)
            Me.m_SPR2s = New List(Of SPR2Parser)
            Me.m_StringTables = New List(Of StringTable)
            Me.m_BHAVs = New List(Of BHAV)
            Me.m_OBJfs = New List(Of OBJf)
            Me.m_BCONs = New List(Of BCON)
            Me.m_TTABs = New List(Of TTAB)
            Me.m_OBJDs = New List(Of OBJD)
            Me.m_FBMPs = New List(Of FBMP)
            Me.m_BMP_s = New List(Of BMP_)
            Me.m_FCNSs = New List(Of FCNS)
            Me.m_UniqueRnd = New UniqueRandom(1, &H3E8)
            Me.m_Path = Path
            Me.m_Reader = New BinaryReader(File.Open(Me.m_Path, FileMode.Open), Encoding.ASCII)
            Me.ReadChunks
            Me.ParsePALTs
            Me.ParseSPRs
            Me.ParseSPR2s
            Me.ParseGroups
            Me.ParseStrings
            Me.ParseBHAVs
            Me.ParseOBJfs
            Me.ParseBCONs
            Me.ParseTTABs
            Me.ParseOBJDs
            Me.ParseFBMPs
            Me.ParseBMP_s
            Me.ParseFCNSs
            Me.m_Reader.Close
        End Sub

        Public Sub New(ByVal Data As Byte())
            Me.m_Chunks = New List(Of IffChunk)
            Me.m_PMaps = New List(Of PaletteMap)
            Me.m_DGroups = New List(Of DrawGroup)
            Me.m_SPRs = New List(Of SPRParser)
            Me.m_SPR2s = New List(Of SPR2Parser)
            Me.m_StringTables = New List(Of StringTable)
            Me.m_BHAVs = New List(Of BHAV)
            Me.m_OBJfs = New List(Of OBJf)
            Me.m_BCONs = New List(Of BCON)
            Me.m_TTABs = New List(Of TTAB)
            Me.m_OBJDs = New List(Of OBJD)
            Me.m_FBMPs = New List(Of FBMP)
            Me.m_BMP_s = New List(Of BMP_)
            Me.m_FCNSs = New List(Of FCNS)
            Me.m_UniqueRnd = New UniqueRandom(1, &H3E8)
            Dim input As New MemoryStream(Data)
            Me.m_Reader = New BinaryReader(input, Encoding.ASCII)
            Me.ReadChunks
            Me.ParsePALTs
            Me.ParseSPRs
            Me.ParseSPR2s
            Me.ParseGroups
            Me.ParseStrings
            Me.ParseBHAVs
            Me.ParseOBJfs
            Me.ParseBCONs
            Me.ParseTTABs
            Me.ParseFBMPs
            Me.ParseBMP_s
            Me.ParseFCNSs
            Me.m_Reader.Close
        End Sub

        Private Sub FindPALT()
            Me.m_Reader.BaseStream.Position = &H40
            Dim list As New List(Of KeyValuePair(Of String, UInt32))
            Do
                Dim position As UInt32 = DirectCast(Me.m_Reader.BaseStream.Position, UInt32)
                Dim array As Byte() = Me.m_Reader.ReadBytes(4)
                Array.Reverse(array)
                Dim key As String = New ASCIIEncoding().GetString(array)
                Dim buffer2 As Byte() = Me.m_Reader.ReadBytes(4)
                If (buffer2.Length = 0) Then
                    Exit Do
                End If
                Dim num2 As UInt32 = Endian.SwapUInt32(BitConverter.ToUInt32(buffer2, 0))
                Dim baseStream As Stream = Me.m_Reader.BaseStream
                baseStream.Position = (baseStream.Position + (num2 - 8))
                If key.Equals("PALT") Then
                    list.Add(New KeyValuePair(Of String, UInt32)(key, position))
                End If
            Loop While ((Me.m_Reader.BaseStream.Position <> Me.m_Reader.BaseStream.Length) AndAlso ((Me.m_Reader.BaseStream.Length - Me.m_Reader.BaseStream.Position) >= &H4C))
            Dim pair As KeyValuePair(Of String, UInt32)
            For Each pair In list
                Me.m_Reader.BaseStream.Position = CLng(CULng(pair.Value))
                Dim chunk As New IffChunk(pair.Key) With { _
                    .Length = (Endian.SwapUInt32(Me.m_Reader.ReadUInt32) - &H4C), _
                    .ID = Endian.SwapUInt16(Me.m_Reader.ReadUInt16) _
                }
                Dim num3 As UInt16 = Endian.SwapUInt16(Me.m_Reader.ReadUInt16)
                chunk.NameString = Me.GetNameString
                If ((Me.m_Reader.BaseStream.Length - Me.m_Reader.BaseStream.Position) >= chunk.Length) Then
                    Me.m_Reader.BaseStream.Position = (pair.Value + &H4C)
                    chunk.Data = Me.m_Reader.ReadBytes(CInt(chunk.Length))
                Else
                    chunk.Data = New Byte(chunk.Length  - 1) {}
                End If
                Me.m_PMaps.Add(New PaletteMap(chunk))
            Next
        End Sub

        Private Sub FuckThisShit(ByRef files As Dictionary(Of String, List(Of UInt32)))
            Me.m_Reader.BaseStream.Position = &H40
            Dim list As New List(Of KeyValuePair(Of String, UInt32))
            Do
                Dim position As UInt32 = DirectCast(Me.m_Reader.BaseStream.Position, UInt32)
                Dim array As Byte() = Me.m_Reader.ReadBytes(4)
                Array.Reverse(array)
                Dim key As String = New ASCIIEncoding().GetString(array)
                Dim buffer2 As Byte() = Me.m_Reader.ReadBytes(4)
                If (buffer2.Length = 0) Then
                    Exit Do
                End If
                Dim num2 As UInt32 = Endian.SwapUInt32(BitConverter.ToUInt32(buffer2, 0))
                Dim baseStream As Stream = Me.m_Reader.BaseStream
                baseStream.Position = (baseStream.Position + (num2 - 8))
                If Not key.Equals("XXXX") Then
                    list.Add(New KeyValuePair(Of String, UInt32)(key, position))
                End If
            Loop While ((Me.m_Reader.BaseStream.Position <> Me.m_Reader.BaseStream.Length) AndAlso ((Me.m_Reader.BaseStream.Length - Me.m_Reader.BaseStream.Position) >= &H4C))
            Dim list2 As New List(Of String)
            Using enumerator As Enumerator(Of KeyValuePair(Of String, UInt32)) = list.GetEnumerator
                Dim match As Predicate(Of String) = Nothing
                Dim predicate2 As Predicate(Of KeyValuePair(Of String, UInt32)) = Nothing
                Dim kvp As KeyValuePair(Of String, UInt32)
                Do While enumerator.MoveNext
                    kvp = enumerator.Current
                    If (match Is Nothing) Then
                        match = s => (s.CompareTo(kvp.Key) = 0)
                    End If
                    If Not list2.Exists(match) Then
                        If (predicate2 Is Nothing) Then
                            predicate2 = pair => (pair.Key.CompareTo(kvp.Key) = 0)
                        End If
                        Dim list3 As List(Of KeyValuePair(Of String, UInt32)) = list.FindAll(predicate2)
                        Dim list4 As New List(Of UInt32)
                        Dim pair As KeyValuePair(Of String, UInt32)
                        For Each pair In list3
                            list4.Add(pair.Value)
                        Next
                        files.Add(kvp.Key, list4)
                        list2.Add(kvp.Key)
                    End If
                Loop
            End Using
        End Sub

        Private Function GetNameString() As String
            Dim flag As Boolean = False
            Dim count As Integer = 0
            Do While (count < &H3F)
                Dim ch As Char = DirectCast(Me.m_Reader.PeekChar, Char)
                If (ch = ChrW(0)) Then
                    flag = True
                    Exit Do
                End If
                count += 1
            Loop
            If flag Then
                Return New String(Me.m_Reader.ReadChars(count))
            End If
            Return Encoding.ASCII.GetString(Me.m_Reader.ReadBytes(&H40))
        End Function

        Public Function GetSprite(ByVal Index As Integer) As SPR2Parser
            Return Me.m_SPR2s.Item(Index)
        End Function

        Private Sub ParseBCONs()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "BCON") Then
                    Me.m_BCONs.Add(New BCON(chunk))
                End If
            Next
        End Sub

        Private Sub ParseBHAVs()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "BHAV") Then
                    Me.m_BHAVs.Add(New BHAV(chunk))
                End If
            Next
        End Sub

        Private Sub ParseBMP_s()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "FBMP") Then
                    Me.m_BMP_s.Add(New BMP_(chunk))
                End If
            Next
        End Sub

        Private Sub ParseFBMPs()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "FBMP") Then
                    Me.m_FBMPs.Add(New FBMP(chunk))
                End If
            Next
        End Sub

        Private Sub ParseFCNSs()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "FCNS") Then
                    Me.m_FCNSs.Add(New FCNS(chunk))
                End If
            Next
        End Sub

        Private Sub ParseGroups()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "DGRP") Then
                    Me.m_DGroups.Add(New DrawGroup(chunk, Me.m_SPR2s))
                End If
            Next
        End Sub

        Private Sub ParseOBJDs()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "OBJD") Then
                    Me.ToOBJD(chunk)
                End If
            Next
        End Sub

        Private Sub ParseOBJfs()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "OBJf") Then
                    Me.m_OBJfs.Add(New OBJf(chunk))
                End If
            Next
        End Sub

        Private Sub ParsePALTs()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "PALT") Then
                    Me.m_PMaps.Add(New PaletteMap(chunk))
                End If
            Next
        End Sub

        Private Sub ParseSPR2s()
            If (Me.m_PMaps.Count = 0) Then
                Me.FindPALT
            End If
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "SPR2") Then
                    Me.m_SPR2s.Add(New SPR2Parser(chunk, Me.m_PMaps))
                End If
            Next
        End Sub

        Private Sub ParseSPRs()
            If (Me.m_PMaps.Count = 0) Then
                Me.FindPALT
            End If
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "SPR#") Then
                    Me.m_SPRs.Add(New SPRParser(chunk, Me.m_PMaps))
                End If
            Next
        End Sub

        Private Sub ParseStrings()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If ((((chunk.Resource = "STR#") OrElse (chunk.Resource = "TTAs")) OrElse (chunk.Resource = "CTSS")) OrElse (chunk.Resource = "CST")) Then
                    Me.m_StringTables.Add(New StringTable(chunk))
                End If
            Next
        End Sub

        Private Sub ParseTTABs()
            Dim chunk As IffChunk
            For Each chunk In Me.m_Chunks
                If (chunk.Resource = "TTAB") Then
                    Me.m_TTABs.Add(New TTAB(chunk))
                End If
            Next
        End Sub

        Private Sub ReadChunks()
            Dim num8 As UInt32
            If (New String(Me.m_Reader.ReadChars(60)).Replace(ChrW(0), "") <> "IFF FILE 2.5:TYPE FOLLOWED BY SIZE JAMIE DOORNBOS & MAXIS 1") Then
                Throw New Exception("Invalid iff file!")
            End If
            Dim num As UInt32 = Endian.SwapUInt32(Me.m_Reader.ReadUInt32)
            Dim files As New Dictionary(Of String, List(Of UInt32))
            If (num <> 0) Then
                Dim position As Long = Me.m_Reader.BaseStream.Position
                Me.m_Reader.BaseStream.Position = num
                Dim baseStream As Stream = Me.m_Reader.BaseStream
                baseStream.Position = (baseStream.Position + &H4C)
                Me.m_Reader.ReadInt32
                Dim num3 As UInt32 = Me.m_Reader.ReadUInt32
                Me.m_Reader.ReadInt32
                Me.m_Reader.ReadInt32
                Dim num4 As UInt32 = Me.m_Reader.ReadUInt32
                Dim i As UInt32
                For i = 0 To num4 - 1
                    Dim key As String = New ASCIIEncoding().GetString(Me.m_Reader.ReadBytes(4))
                    If (num3 = 0) Then
                        If ((Me.m_Reader.BaseStream.Length - Me.m_Reader.BaseStream.Position) < 13) Then
                            files.Clear
                            Me.FuckThisShit(files)
                            Exit For
                        End If
                    ElseIf ((num3 = 1) AndAlso ((Me.m_Reader.BaseStream.Length - Me.m_Reader.BaseStream.Position) < &H10)) Then
                        files.Clear
                        Me.FuckThisShit(files)
                        Exit For
                    End If
                    Dim num6 As UInt32 = Me.m_Reader.ReadUInt32
                    Dim list As New List(Of UInt32)
                    Dim j As UInt32
                    For j = 0 To num6 - 1
                        If (num3 = 0) Then
                            If ((Me.m_Reader.BaseStream.Length - Me.m_Reader.BaseStream.Position) < ((num6 - j) * 9)) Then
                                files.Clear
                                Me.FuckThisShit(files)
                                Exit For
                            End If
                        ElseIf ((num3 = 1) AndAlso ((Me.m_Reader.BaseStream.Length - Me.m_Reader.BaseStream.Position) < ((num6 - j) * 12))) Then
                            files.Clear
                            Me.FuckThisShit(files)
                            Exit For
                        End If
                        num8 = Me.m_Reader.ReadUInt32
                        Me.m_Reader.ReadInt16
                        If (num3 = 1) Then
                            Me.m_Reader.ReadInt16
                        End If
                        Me.m_Reader.ReadInt16
                        If (num3 = 1) Then
                            Dim count As Byte = Me.m_Reader.ReadByte
                            If (count > 0) Then
                                Me.m_Reader.ReadBytes(count)
                            End If
                        Else
                            Me.GetNameString
                        End If
                        list.Add(num8)
                    Next j
                    If Not files.ContainsKey(key) Then
                        files.Add(key, list)
                    End If
                Next i
            Else
                Dim list2 As New List(Of KeyValuePair(Of String, UInt32))
                Do
                    num8 = DirectCast(Me.m_Reader.BaseStream.Position, UInt32)
                    Dim array As Byte() = Me.m_Reader.ReadBytes(4)
                    Array.Reverse(array)
                    Dim str3 As String = New ASCIIEncoding().GetString(array)
                    Dim buffer2 As Byte() = Me.m_Reader.ReadBytes(4)
                    If (buffer2.Length = 0) Then
                        Exit Do
                    End If
                    Dim num10 As UInt32 = Endian.SwapUInt32(BitConverter.ToUInt32(buffer2, 0))
                    Dim stream2 As Stream = Me.m_Reader.BaseStream
                    stream2.Position = (stream2.Position + (num10 - 8))
                    If Not str3.Equals("XXXX") Then
                        list2.Add(New KeyValuePair(Of String, UInt32)(str3, num8))
                    End If
                Loop While ((Me.m_Reader.BaseStream.Position <> Me.m_Reader.BaseStream.Length) AndAlso ((Me.m_Reader.BaseStream.Length - Me.m_Reader.BaseStream.Position) >= &H4C))
                Dim list3 As New List(Of String)
                Using enumerator As Enumerator(Of KeyValuePair(Of String, UInt32)) = list2.GetEnumerator
                    Dim match As Predicate(Of String) = Nothing
                    Dim predicate2 As Predicate(Of KeyValuePair(Of String, UInt32)) = Nothing
                    Dim kvp As KeyValuePair(Of String, UInt32)
                    Do While enumerator.MoveNext
                        kvp = enumerator.Current
                        If (match Is Nothing) Then
                            match = s => (s.CompareTo(kvp.Key) = 0)
                        End If
                        If Not list3.Exists(match) Then
                            If (predicate2 Is Nothing) Then
                                predicate2 = pair => (pair.Key.CompareTo(kvp.Key) = 0)
                            End If
                            Dim list4 As List(Of KeyValuePair(Of String, UInt32)) = list2.FindAll(predicate2)
                            Dim list5 As New List(Of UInt32)
                            Dim pair As KeyValuePair(Of String, UInt32)
                            For Each pair In list4
                                list5.Add(pair.Value)
                            Next
                            If Not files.ContainsKey(kvp.Key) Then
                                files.Add(kvp.Key, list5)
                            End If
                            list3.Add(kvp.Key)
                        End If
                    Loop
                End Using
            End If
            Dim pair2 As KeyValuePair(Of String, List(Of UInt32))
            For Each pair2 In files
                Dim num11 As Integer
                For Each num11 In pair2.Value
                    If (num11 > 0) Then
                        Me.m_Reader.BaseStream.Position = num11
                        Dim bytes As Byte() = Me.m_Reader.ReadBytes(4)
                        Dim resource As String = Encoding.ASCII.GetString(bytes)
                        Select Case resource
                            Case "SPR#", "SPR2", "rsmp", "PALT", "DGRP", "STR#", "BHAV", "FWAV", "CTSS", "TTAB", "TTAs", "OBJf", "BCON", "TPRP", "TMPL", "TRCN", "Optn", "SLOT", "GLOB", "FBMP", "BMP_", "FCNS"
                                Dim item As IffChunk = Me.ToChunk(resource, num11)
                                Me.m_Chunks.Add(item)
                                Exit Select
                        End Select
                    End If
                Next
            Next
        End Sub

        Private Function ToChunk(ByVal Resource As String, ByVal offset As Integer) As IffChunk
            Dim chunk As New IffChunk(Resource) With { _
                .Length = (Endian.SwapUInt32(Me.m_Reader.ReadUInt32) - &H4C), _
                .ID = Endian.SwapUInt16(Me.m_Reader.ReadUInt16) _
            }
            Dim num As UInt16 = Endian.SwapUInt16(Me.m_Reader.ReadUInt16)
            chunk.NameString = Me.GetNameString
            If ((Me.m_Reader.BaseStream.Length - Me.m_Reader.BaseStream.Position) >= chunk.Length) Then
                Me.m_Reader.BaseStream.Position = (offset + &H4C)
                chunk.Data = Me.m_Reader.ReadBytes(CInt(chunk.Length))
                Return chunk
            End If
            chunk.Data = New Byte(chunk.Length  - 1) {}
            Return chunk
        End Function

        Private Sub ToOBJD(ByVal Chunk As IffChunk)
            Dim item As New OBJD(Chunk.Data, Chunk.ID)
            Me.m_OBJDs.Add(item)
        End Sub


        ' Properties
        Public ReadOnly Property BHAVs As List(Of BHAV)
            Get
                Return Me.m_BHAVs
            End Get
        End Property

        Public ReadOnly Property Chunks As List(Of IffChunk)
            Get
                Return Me.m_Chunks
            End Get
        End Property

        Public ReadOnly Property DrawGroups As List(Of DrawGroup)
            Get
                Return Me.m_DGroups
            End Get
        End Property

        Public ReadOnly Property OBJDs As List(Of OBJD)
            Get
                Return Me.m_OBJDs
            End Get
        End Property

        Public ReadOnly Property OBJfs As List(Of OBJf)
            Get
                Return Me.m_OBJfs
            End Get
        End Property

        Public ReadOnly Property Path As String
            Get
                Return Me.m_Path
            End Get
        End Property

        Public ReadOnly Property SPR2s As List(Of SPR2Parser)
            Get
                Return Me.m_SPR2s
            End Get
        End Property

        Public ReadOnly Property SPRs As List(Of SPRParser)
            Get
                Return Me.m_SPRs
            End Get
        End Property

        Public ReadOnly Property StringTables As List(Of StringTable)
            Get
                Return Me.m_StringTables
            End Get
        End Property


        ' Fields
        Private m_BCONs As List(Of BCON)
        Private m_BHAVs As List(Of BHAV)
        Private m_BMP_s As List(Of BMP_)
        Private m_Chunks As List(Of IffChunk)
        Private m_DGroups As List(Of DrawGroup)
        Private m_FBMPs As List(Of FBMP)
        Private m_FCNSs As List(Of FCNS)
        Private m_OBJDs As List(Of OBJD)
        Private m_OBJfs As List(Of OBJf)
        Private m_Path As String
        Private m_PMaps As List(Of PaletteMap)
        Private m_Reader As BinaryReader
        Private m_SPR2s As List(Of SPR2Parser)
        Private m_SPRs As List(Of SPRParser)
        Private m_StringTables As List(Of StringTable)
        Private m_TTABs As List(Of TTAB)
        Private m_UniqueRnd As UniqueRandom
    End Class
End Namespace

