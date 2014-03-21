Imports System.Net
Imports System
Imports SimsLib
Imports SimsLib.IFF
Imports System.IO
Imports SimsLib.IFF.FBMP

Public Class LotsBuild
    Private m_Chunks As List(Of IffChunk)
    Dim m_FBMPs = New List(Of FBMP)
    Dim client1 As WebClient

    Private Sub LotsBuild_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Snow" Then


        ElseIf ComboBox1.SelectedItem = "Grass" Then

        ElseIf ComboBox1.SelectedItem = "Sand" Then

        ElseIf ComboBox1.SelectedItem = "Dirt" Then

        ElseIf ComboBox1.SelectedItem = "Forest" Then

        ElseIf ComboBox1.SelectedItem = "" Then

        Else
            MsgBox("Select another house type")
        End If
    End Sub



    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Snow" And ComboBox2.SelectedItem = "Big" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housesnowbig.jpg"

        ElseIf ComboBox1.SelectedItem = "Snow" And ComboBox2.SelectedItem = "Medium" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housesnowmedium.jpg"
        ElseIf ComboBox1.SelectedItem = "Sand" And ComboBox2.SelectedItem = "Big" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housesandbig.jpg"
        ElseIf ComboBox1.SelectedItem = "Sand" And ComboBox2.SelectedItem = "Medium" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housesandmedium.jpg"
        ElseIf ComboBox1.SelectedItem = "Sand" And ComboBox2.SelectedItem = "Small" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housesandsmall.jpg"
        ElseIf ComboBox1.SelectedItem = "Grass" And ComboBox2.SelectedItem = "Big" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housegrassbig.jpg"
        ElseIf ComboBox1.SelectedItem = "Grass" And ComboBox2.SelectedItem = "Medium" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housegrassmedium.jpg"
        ElseIf ComboBox1.SelectedItem = "Grass" And ComboBox2.SelectedItem = "Small" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housegrassmall.jpg"
        ElseIf ComboBox1.SelectedItem = "Dirt" And ComboBox2.SelectedItem = "Big" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housedirt.jpg"
        ElseIf ComboBox1.SelectedItem = "Dirt" And ComboBox2.SelectedItem = "Medium" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housedirtmedium.jpg"
        ElseIf ComboBox1.SelectedItem = "Forest" And ComboBox2.SelectedItem = "Big" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/houseforestbig.jpg"
        ElseIf ComboBox1.SelectedItem = "Forest" And ComboBox2.SelectedItem = "Medium" Then
            PictureBox1.ImageLocation = "http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/houseforest.jpg"
        Else
            MsgBox("Select another house size")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text <> "" Then
                If ComboBox1.SelectedItem = "Snow" And ComboBox2.SelectedItem = "Big" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseSnowBig.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Snow" And ComboBox2.SelectedItem = "Medium" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseSnowMedium.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Sand" And ComboBox2.SelectedItem = "Big" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/Housesandbig.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Sand" And ComboBox2.SelectedItem = "Medium" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseSandMedium.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Sand" And ComboBox2.SelectedItem = "Small" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseSandSmall.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Grass" And ComboBox2.SelectedItem = "Big" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseGrassBig.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Grass" And ComboBox2.SelectedItem = "Medium" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseGrassMedium.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Grass" And ComboBox2.SelectedItem = "Small" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseGrassSmall.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Dirt" And ComboBox2.SelectedItem = "Big" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseDirtBig.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Dirt" And ComboBox2.SelectedItem = "Medium" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/housedirtsmedium.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Forest" And ComboBox2.SelectedItem = "Big" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseForestBig.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                ElseIf ComboBox1.SelectedItem = "Forest" And ComboBox2.SelectedItem = "Medium" Then
                    Me.client1 = New WebClient
                    Me.client1.DownloadFileAsync(New Uri(("http://simsvilleroleplay.bugs3.com/public_html/files/NeighborhoodEditor/HouseForestMedium.iff")), My.Settings.GamePath & "\UserData9\Houses\" & TextBox1.Text)
                    Me.client1.Credentials = New NetworkCredential("a6174471", "simsville1")
                    Me.Label7.Text = Me.TextBox1.Text
                    Me.Label8.Text = "Downloaded"
                    Me.ComboBox3.Items.Add(TextBox1.Text)
                Else
                    MsgBox("Please specify house name")
                End If

            End If

        Catch ex As Exception
            MsgBox("Cannot download file")
        End Try



    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If NumericUpDown1.Value = 0 Then
            TextBox1.Text = "House00.iff"
        ElseIf NumericUpDown1.Value = 1 Then
            TextBox1.Text = "House01.iff"
        ElseIf NumericUpDown1.Value = 2 Then
            TextBox1.Text = "House02.iff"
        ElseIf NumericUpDown1.Value = 3 Then
            TextBox1.Text = "House03.iff"
        ElseIf NumericUpDown1.Value = 4 Then
            TextBox1.Text = "House04.iff"
        ElseIf NumericUpDown1.Value = 5 Then
            TextBox1.Text = "House05.iff"
        ElseIf NumericUpDown1.Value = 6 Then
            TextBox1.Text = "House06.iff"
        ElseIf NumericUpDown1.Value = 7 Then
            TextBox1.Text = "House07.iff"
        ElseIf NumericUpDown1.Value = 8 Then
            TextBox1.Text = "House08.iff"
        ElseIf NumericUpDown1.Value = 9 Then
            TextBox1.Text = "House09.iff"
        ElseIf NumericUpDown1.Value = 10 Then
            TextBox1.Text = "House10.iff"

        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 0 Then
            TextBox1.Text = "House00.iff"
        ElseIf NumericUpDown1.Value = 1 Then
            TextBox1.Text = "House01.iff"
        ElseIf NumericUpDown1.Value = 2 Then
            TextBox1.Text = "House02.iff"
        ElseIf NumericUpDown1.Value = 3 Then
            TextBox1.Text = "House03.iff"
        ElseIf NumericUpDown1.Value = 4 Then
            TextBox1.Text = "House04.iff"
        ElseIf NumericUpDown1.Value = 5 Then
            TextBox1.Text = "House05.iff"
        ElseIf NumericUpDown1.Value = 6 Then
            TextBox1.Text = "House06.iff"
        ElseIf NumericUpDown1.Value = 7 Then
            TextBox1.Text = "House07.iff"
        ElseIf NumericUpDown1.Value = 8 Then
            TextBox1.Text = "House08.iff"
        ElseIf NumericUpDown1.Value = 9 Then
            TextBox1.Text = "House09.iff"
        ElseIf NumericUpDown1.Value = 10 Then
            TextBox1.Text = "House10.iff"

        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text <> "" Then
            TextBox2.Text = ComboBox3.SelectedItem

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim NewString As String = TextBox2.Text
        Dim CurrPos As Integer = ComboBox3.SelectedIndex
        If TextBox2.Text.Length > 0 Then
            ComboBox3.Items.RemoveAt(CurrPos)
            ComboBox3.Items.Insert(CurrPos, NewString)
            My.Computer.FileSystem.RenameFile((My.Settings.GamePath & "\UserData9\Houses\" & Me.ComboBox3.SelectedItem), (My.Settings.GamePath & "\UserData9\Houses\" & Me.TextBox2.Text))
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class