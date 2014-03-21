Imports System.Reflection
Imports System.IO
Imports WormsNET.Image

Public Class Terrain
    Private label As Label
    Private locs As New System.Drawing.Point(x:=MousePosition.X, y:=MousePosition.Y)
    Private image As Image
    Private Sub Terrain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim current As String = My.Settings.GamePath & "\DATA\Image\"
        Dim selected As String = current & Form1.ComboBox1.SelectedItem
        image = New Image(selected)
        PictureBox1.BackgroundImage = image.Bitmap
    End Sub


    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        TextBox1.Text = e.X
        TextBox2.Text = e.Y
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.Click
        If Variables.Item = 1 Then
            Dim location As New System.Drawing.Point(x:=TextBox1.Text, y:=TextBox2.Text)
            label = New Label()
            label.Location = location
            label.Visible = True
            label.AutoSize = False
            label.Image = My.Resources.worm
            label.BackColor = Color.Transparent
            PictureBox1.Controls.Add(label)

        ElseIf Variables.Item = 2 Then
            Dim location As New System.Drawing.Point(x:=TextBox1.Text, y:=TextBox2.Text)
            label = New Label()
            label.Location = location
            label.Visible = True
            label.AutoSize = False
            label.Image = My.Resources.mine
            label.BackColor = Color.Transparent
            PictureBox1.Controls.Add(label)
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Select()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Select()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        OpenFileDialog1.InitialDirectory = My.Settings.GamePath
        OpenFileDialog1.Filter = "Wors Armageddon Image File (*.img)|*.img|All Files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then

            image = New Image(OpenFileDialog1.FileName)


            PictureBox1.BackgroundImage = image.Bitmap

        End If
    End Sub
End Class