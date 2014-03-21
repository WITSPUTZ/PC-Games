Imports SimsLib.IFF

Public Class Analyzer
    Private m_Blocks As List(Of BHAVBlock)
    Private m_GlobalSubs As String() = New String() {"set graphic", "IncComfort-g", "random motion", "old idle", "set object graphic", "SetComfort", "set direction", "Find Closest Person", "test for user interrupt", "hide menu", "SetEnergy", "SetStress", "SetSocial", "SetEntertained", "SetEnvironment", "Init Object", "Standard entry", "Standard Exit", "Move forward n tiles (n)", "set object lighting", "Test Behind", "set multi-object graphic", "standard multi-tile entry", "standard multi-tile exit", "idle", "Wait For Notify", "divide tick counts", "go over and wait around", "fail food chain object", "Fun Object Test", "show skill progress", "verify stack obj ID", "In Use?", "mod8", "old Wait for Notify", "try fliiping object", "create multiple floods in front of object", "create multiple floods under me", "privacy - ask Sims to Shoo", "flip Sim around", "schedule phone call with neighbor", "help display - broken object", "censor", "SetComfortFromMain", "SetComfortFromInt", "is object's room outside", "Clean", "Clean test", "clean inc", "my dirt inc", "Check Schedule", "Schedule", "set sprite visibility", "help display - autosnapshot", "help display - object dirty", "help display - route failure", "privacy - should ignore person", "do the drop", "Is Stack Object held by person?", "sfx Hit Person", "do grim reaper[LL]", "create reaper[LL]", "Am I a clone?[LL]", "Robot Sound?[LL]", "Is lot a Downtown Lot?[HD]", "Is lot a Residential Lot?[HD]", "Trigger Prude Hit[HD]", "Trigger Prude Finger[HD]", "Get Stack Object's Autofollow Sim and Place In Temp 0[HD]", "Allow in Downtown Only[HD]", "Allow at Home Only[HD]", "Find Cash Register[HD]", "Allow Autonomous?[HD]", "do I love anyone?[HD]", "does stack object love anyone?[HD]", "Push Date Response[HD]", "Push Interaction on My Autofollow[HD]", "Get My Autofollow Sim in Temp 0[HD]", "Charge for Downtown[HD]", "Boost STR[HD]", "End Autofollow - Bad Behavior[HD]", "Get Social Availability Scale[HD]", "Bored Social[HD]", "dress naked", "dress normal", "missing animation tree", "set object hidden", "Create Trash Pile By Size", "dress normal - just dress[HD]", "wake everyone sleeping in lot[HD]", "Downtown - Half ad for night[HD]", "dirty inc", "set room impact", "repair inc", "repair finished", "repair start", "relationship", "Find someone i love", "Downtown - Double ad for night[HD]", "verify person in stack obj[HD]", "Push Browse of Same Type[HD]", "get my relationship to temp 0", "Do I Love temp 0?", "am I friends with temp 0", "is temp 0 friends with me?", "Does temp 0 love me?", "wash hands if neat", "Am I a Child?", "Am I an Adult?", "Is either person a child?", "idle hours", "idle minutes", "Leave", "Schedule with param", "animated idle for", "Start Jealousy", "End Jealousy", "find random portal", "set to leave", "Is family full?", "Dress Formal", "Dress Swimsuit", "Dress Work", "enable debug balloons?", "push slap onto temp0 and temp1", "Schedule with Hour", "ensure Sim is standing", "Create Stool", "Remove Stool", "NPC Get Paid", "privacy - test alone", "fall on floor - begin", "fall on floor - end", "privacy - do shoo", "group talk cancel[HD]", "Exit Downtown Object?[HD]", "do electrocution", "kill person for good", "create flood under me", "create flood in front of me", "create flood in front of object", "enable social outcome choice?", "route failure feedback", "wake everyone up in stack object's room", "group talk create", "group talk do", "group talk add person", "group talk exit person", "schedule phone call", "Exit fun object", "drop object from my slot to floor", "Refuse Skill Object?", "Refuse Fun Object?", "repair - Should Tantrum?", "can join?", "Is Object in Use Flag Set?", "Dress for Bed", "wake everyone in my room with balloon", "count people in house", "Exit Skill Object", "Relationship Impact for Join", "Exit Repair Function", "Turn on All TVs in Room[HD]", "Wander[HD]", "Autofollow my family member?[HD]", "Return in Temp 0 & 1 - HIBYTE and LOBYTE[V]", "Return in Temp 0 - Make WORD[V]", "Allow on Vacation Only[V]", "Is lot a Vacation Lot?[V]", "animated idle for[V]", "Get Available Family Kid in Temp 0[V]", "Get Available Family Adult in Temp 0[V]", "Is lot a Vacation Snow Lot?[V]", "Turn Off All Dyn Sprites[V]", "Is Temp 0 a Child?[V]", "Dress Winter[V]", "Set Multi-Tile Dyn Sprite[V]", "Is lot a Vacation Beach Lot?[V]", "Is lot a Vacation Forest Lot?[V]", "Prize Token - Add[V]", "Prize Token - Remove[V]", "Prize Token - Get Num in Temp[V]", "Set Multi-Tile Wall Placement Flags[V]", "Turn Sim to Face Direction[V]", "Set Multi-Tile Lighting[V]", "Notify Multi-Tile[V]", "Temp[0 & 1] := Mutli-Tile Dimensions[base 0][V]", "count my (non-pet) family members[V]", "Group Talk - MT - Create[V]", "Group Talk - MT -  Add Person[V]", "Am I in Selected Sims Party?[V]", "Group Talk - MT - Do[V]", "Group Talk - MT - Exit Person[V]", "Return in Temp 0 - Tile ID w/ Lowest Subindex[V]", "can join away from home?[V]", "Add Deviant Act to Vacation Controller[V]", "Allow away from home only[V]", "Find Nearest Rental Shack[V]", "Find Nearest Rent Shack and Push Interaction[V]", "Push Interaction by Number[V]", "Add to Vacation Score[V]", "Subtract from Vacation Score[V]", "Get Vacation Score in Temp 0[V]", "Save Score[V]", "Set All Wall Placement Flags[V]", "Exit Vacation Object?[V]", "Is Stack Object in the Selected Sim's Party[V]", "Charge for Away from Home[V]", "Route a away if dating[V]", "verify stack obj ID with category[V]", "Remove Time Tokens[U]", "Am I a Dog?[U]", "Am I a Cat?[U]", "Is Lot A Community Lot?[U]", "Allow On Community Only[U]", "Allow On Neighborhood Lot Only[U]", "Dream - Pet[U]", "Dream - Pet - About Other Sim[U]", "Dream - Pet - About Object[U]", "Are there any Community Lots?[U]", "Allow on Residential Lots only[U]", "Is Away From Home Family Full[U]", "Allow Pet Intersection[U]"}
    Private m_GlobalSubsLen As Integer = 0
    Private m_Instructions As BHAV
    Private m_MyFile As Iff
    Private m_SemiGlobal As Iff


    Public Sub New(ByVal IffFile As Iff)
        Me.m_MyFile = IffFile
    End Sub

    Private Sub ChangeSuitOrAccessoryPrimitive(ByVal Instruction As Byte())
    End Sub

    Public Sub DecodeInstruction(ByRef P As IFFDecode)
        Dim iD As Integer = P.Operand(0)
        If (iD < &H100) Then
            Me.DecodePrimitive(P)
        Else
            Dim str As String = Me.EntryName("BHAV", iD)
            If (Me.m_GlobalSubsLen = 0) Then
                Me.m_GlobalSubsLen = ((Me.m_GlobalSubs.Length / Me.m_GlobalSubs(0).Length) - 1)
            End If
            If (str <> ChrW(0)) Then
                P.OutStream.Append(str)
            ElseIf (iD < CULng((Me.m_GlobalSubsLen + &H100))) Then
                P.OutStream.Append(Me.m_GlobalSubs((iD - &H100)))
            ElseIf (iD < &H1000) Then
                P.OutStream.Append(("Call global[" & iD & "]"))
            ElseIf (iD < &H2000) Then
                P.OutStream.Append(("Call local[" & iD & "]"))
            Else
                P.OutStream.Append(("Call semi-global[" & iD & "]"))
            End If
            If ((((P.Operand(4) = &HFFFF) AndAlso (P.Operand(6) = &HFFFF)) AndAlso (P.Operand(8) = &HFFFF)) AndAlso (P.Operand(10) = &HFFFF)) Then
                P.OutStream.Append("(temps)")
            Else
                P.OutStream.Append(String.Concat(New Object() {"(", CShort(P.Operand(4)), ", ", CShort(P.Operand(6)), ", ", CShort(P.Operand(8)), ", ", CShort(P.Operand(10)), ")"}))
            End If
        End If
    End Sub

    Private Sub DecodePrimitive(ByVal P As IFFDecode)
        Dim num4 As Integer
        Dim num5 As Integer
        Dim num9 As Integer
        Dim num As Integer = P.Operand(0)
        Dim num2 As Integer = 0
        Select Case num
            Case 0
                P.OutStream.Append("0: sleep ")
                Me.DoExpressionOperation(9, P.Operand(4))
                P.OutStream.Append(" ticks")
                Return
            Case 1
                Dim num3 As Integer = ((BHAVStrings.BHAVString220.Length / BHAVStrings.BHAVString220(0).Length) - 1)
                num4 = P.Operand(4)
                If (num4 >= num3) Then
                    P.OutStream.Append(("1: generic sim call " & num4))
                    Return
                End If
                P.OutStream.Append(BHAVStrings.BHAVString220(num4))
                Return
            Case 2
                Me.ExpressionPrimitive(P.Instruction)
                Return
            Case 3
                P.OutStream.Append("3: find best interaction")
                Return
            Case 4
                P.OutStream.Append("4: grab stack object")
                Return
            Case 5
                P.OutStream.Append("5: drop stack object")
                Return
            Case 6
                Me.ChangeSuitOrAccessoryPrimitive(P.Instruction)
                Return
            Case 7
                P.OutStream.Append("7: refresh ")
                num5 = ((BHAVStrings.BHAVString153.Length / BHAVStrings.BHAVString153(0).Length) - 1)
                Dim val4 As Integer = Convert.ToInt32(P.Item(4))
                If (val4 >= num5) Then
                    P.OutStream.Append(("WHO=" & Convert.ToInt32((P.Item(4)))))
                    Exit Select
                End If
                P.OutStream.Append(BHAVStrings.BHAVString153(Convert.ToInt32(P.Item(4))))
                Exit Select
            Case 8
                Me.DoExpressionOperation(AscW(P.Item(6)), P.Operand(4))
                P.OutStream.Append(" := random ")
                Me.DoExpressionOperation(AscW(P.Item(10)), P.Operand(8))
                Return
            Case 9
                P.OutStream.Append("9: burn ")
                Dim num7 As Integer = ((BHAVStrings.BHAVString231.Length / BHAVStrings.BHAVString231(0).Length) - 1)
                Dim val As Integer = Convert.ToInt32(P.Item(4))
                If (val >= num7) Then
                    P.OutStream.Append(("WHAT [" & CInt(AscW(P.Item(4))) & "]"))
                    Return
                End If
                P.OutStream.Append(BHAVStrings.BHAVString231(AscW(P.Item(4))))
                Return
            Case 10
                P.OutStream.Append(("10: tutorial " & If((P.Item(4) = ChrW(0)), "begin", "end")))
                Return
            Case 11
                Me.DoExpressionOperation(8, P.Operand(4))
                P.OutStream.Append(" := distance from stack object to ")
                num2 = P.Operand(8)
                If (P.Item(6) <> ChrW(0)) Then
                    If ((P.Item(9) = ChrW(3)) AndAlso (num2 = 11)) Then
                        P.OutStream.Append("me")
                    Else
                        Me.DoExpressionOperation(CInt(AscW(P.Item(9))), num2)
                    End If
                    Return
                End If
                P.OutStream.Append("me")
                Return
            Case 12
                Me.DoExpressionOperation(CInt(AscW(P.Item(6))), P.Operand(4))
                P.OutStream.Append(" := direction from stack object to ")
                num2 = P.Operand(10)
                If (P.Item(8) <> ChrW(0)) Then
                    If ((P.Item(9) = ChrW(3)) AndAlso (num2 = 11)) Then
                        P.OutStream.Append("me")
                    Else
                        Me.DoExpressionOperation(AscW(P.Item(9)), num2)
                    End If
                    Return
                End If
                P.OutStream.Append("me")
                Return
            Case 13
                P.OutStream.Append("13: queue ")
                P.OutStream.Append((CInt(AscW(P.OutStream.Chars(4))) & " of "))
                Dim val7 As Integer = Convert.ToInt32(P.Item(7))
                Dim val11 As Integer = Convert.ToInt32(ChrW(2))
                Me.DoExpressionOperation(If(((val7 And val11) <> 0), &H19, 9), AscW(P.Item(5)))
                Dim num8 As Integer = ((BHAVStrings.BHAVString224.Length / BHAVStrings.BHAVString224(0).Length) - 1)
                Dim val8 As Integer = Convert.ToInt32(P.Item(6))
                If (val8 >= num8) Then
                    P.OutStream.Append((" PRI=" & CInt(AscW(P.Item(6)))))
                ElseIf (P.Item(6) > ChrW(0)) Then
                End If
                Dim val15 As Integer = Convert.ToInt32(ChrW(1))
                If ((val7 And val15) <> 0) Then
                    P.OutStream.Append(" icon=")
                    Me.DoExpressionOperation(&H19, P.Operand(8))
                End If
                Dim val16 As Integer = Convert.ToInt32(ChrW(4))
                If ((val7 And val16) <> 0) Then
                    P.OutStream.Append(", continue as current ")
                End If
                Dim val12 As Integer = Convert.ToInt32(ChrW(8))
                If ((val7 And val12) <> 0) Then
                    P.OutStream.Append(", use name ")
                End If
                Return
            Case 14
                num2 = P.Operand(4)
                P.OutStream.Append("14: find best object for ")
                num9 = ((BHAVStrings.BHAVString201Obj.Length / BHAVStrings.BHAVString201Obj(0).Length) - 1)
                If (num2 >= num9) Then
                    P.OutStream.Append(("function " & num2))
                Else
                    P.OutStream.Append(BHAVStrings.BHAVString201Obj(num2))
                End If
                Dim num10 As Integer = P.Operand(6)
                Dim num11 As Integer = P.Operand(8)
                Dim num12 As Integer = P.Operand(10)
                If (((num10 <> 0) OrElse (num11 <> 0)) OrElse (num12 <> 0)) Then
                    P.OutStream.Append(String.Concat(New Object() {"(", num10, ", ", num11, ", ", num12, ")"}))
                End If
                Return
            Case 15
                P.OutStream.Append("15: tree breakpoint")
                num2 = P.Operand(4)
                If ((P.Item(6) <> ChrW(7)) OrElse (num2 = 0)) Then
                    P.OutStream.Append(" if ")
                    Me.DoExpressionOperation(AscW(P.Item(6)), num2)
                    P.OutStream.Append(" != 0")
                End If
                Return
            Case &H10
                P.OutStream.Append("16: find: ")
                Dim val9 As Integer = Convert.ToInt32(P.Item(8))
                Dim val17 As Integer = Convert.ToInt32(ChrW(2))
                If ((val9 And val17) <> 0) Then
                    P.OutStream.Append("empty ")
                End If
                Dim num13 As Integer = ((BHAVStrings.BHAVString239.Length / BHAVStrings.BHAVString239(0).Length) - 1)
                Dim val4 As Integer = Convert.ToInt32(P.Item(4))
                If (val4 < num13) Then
                    P.OutStream.Append(BHAVStrings.BHAVString239(AscW(P.Item(4))))
                Else
                    P.OutStream.Append(("LOC=" & CInt(AscW(P.Item(4)))))
                End If
                P.OutStream.Append(" loc")
                Dim val2 As Integer = Convert.ToInt32(ChrW(1))
                Dim val3 As Integer = Convert.ToInt32(P.Item(6))
                If (val3 And val2 <> 0) Then
                    P.OutStream.Append(" start at ")
                    Me.DoExpressionOperation(&H19, AscW(P.Item(5)))
                End If
                Dim val10 As Integer = Convert.ToInt32(P.Item(6))
                Dim val15 As Integer = Convert.ToInt32(ChrW(4))
                If ((val10 And val15) <> 0) Then
                    P.OutStream.Append(" user-editable")
                End If
                Return
            Case &H11
                P.OutStream.Append("17: idle for input ")
                Me.DoExpressionOperation(9, P.Operand(4))
                num2 = P.Operand(6)
                P.OutStream.Append((" ticks, " & If((num2 = 0), "forbid", "allow") & " push"))
                Return
            Case &H12
                P.OutStream.Append("18: remove ")
                Dim index As Integer = P.Operand(4)
                num5 = ((BHAVStrings.BHAVString153.Length / BHAVStrings.BHAVString153(0).Length) - 1)
                If (index >= num5) Then
                    P.OutStream.Append(("object[" & index & "]'s"))
                Else
                    P.OutStream.Append(BHAVStrings.BHAVString153(index))
                End If
                P.OutStream.Append(" instance")
                Dim val10 As Integer = Convert.ToInt32(P.Item(6))
                Dim vall11 As Integer = Convert.ToInt32(ChrW(1))

                If ((val10 And vall11) <> 0) Then
                    P.OutStream.Append(", return immediately")
                End If
                Dim vall12 As Integer = Convert.ToInt32(ChrW(2))
                If ((val10 And vall12) <> 0) Then
                    P.OutStream.Append(", clean up all")
                End If
                Return
            Case &H13
                P.OutStream.Append("19: make new character(")
                Me.DoExpressionOperation(&H19, AscW(P.Item(4)))
                P.OutStream.Append(",")
                Me.DoExpressionOperation(&H19, AscW(P.Item(5)))
                P.OutStream.Append(",")
                Me.DoExpressionOperation(&H19, AscW(P.Item(6)))
                P.OutStream.Append(")")
                Return
            Case 20
                num4 = P.Operand(4)
                P.OutStream.Append("20: run ")
                num9 = ((BHAVStrings.BHAVString201Run.Length / BHAVStrings.BHAVString201Run(0).Length) - 1)
                If (num4 >= num9) Then
                    P.OutStream.Append(("function " & num4))
                Else
                    P.OutStream.Append(("""" & BHAVStrings.BHAVString201Run(num4) & """"))
                End If
                num4 = CShort(P.Operand(6))
                If (num4 <> 0) Then
                    P.OutStream.Append(" with new icon")
                End If
                Return
            Case Else
                Me.DefaultPrimitive(P)
                Return
        End Select
        P.OutStream.Append(" ")
        Dim num6 As Integer = ((BHAVStrings.BHAVString212.Length / BHAVStrings.BHAVString212(0).Length) - 1)
        Dim val6 As Integer = Convert.ToInt32(P.Item(6))
        If (val6 < num6) Then
            P.OutStream.Append(BHAVStrings.BHAVString212(AscW(P.Item(6))))
        Else
            P.OutStream.Append(("WHAT=" & CInt(AscW(P.Item(6)))))
        End If
    End Sub

    Private Sub DefaultPrimitive(ByVal P As IFFDecode)
        Dim index As Integer = P.Operand(0)
        Dim num2 As Integer = ((BHAVStrings.BHAVString139.Length / BHAVStrings.BHAVString139(0).Length) - 1)
        If (index < num2) Then
            P.OutStream.Append(BHAVStrings.BHAVString139(index))
        Else
            P.OutStream.Append(("PRIM_" & index))
        End If
        P.OutStream.Append(String.Concat(New Object() {"(", P.Operand(4), ", ", P.Operand(6), ", ", P.Operand(8), ", ", P.Operand(10), ")"}))
    End Sub

    Private Sub DoExpressionOperation(ByVal Code As Integer, ByVal Value As Integer)
    End Sub

    Private Function EntryName(ByVal Type As String, ByVal ID As Integer) As String
        Dim chunk As IffChunk
        For Each chunk In Me.m_MyFile.Chunks
            If ((chunk.Resource = Type) AndAlso (chunk.ID = ID)) Then
                Return chunk.NameString
            End If
        Next
        Return ""
    End Function

    Private Sub ExpressionPrimitive(ByVal p As Byte())
    End Sub
End Class
