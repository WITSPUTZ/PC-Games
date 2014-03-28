Imports System
Imports System.Data.SQLite
Imports System.Windows.Forms

Namespace DevPro_CardManager
    Public Class SQLiteCommands
        ' Methods
        Public Shared Function ExecuteSqlCommand(ByVal commandstring As String) As Boolean
            Try
                Dim command As New SQLiteCommand(commandstring)
                DatabaseHelper.ExecuteNonCommand(command)
                Return True
            Catch exception As Exception
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK)
                Return False
            End Try
        End Function

        Public Shared Function SaveCard(ByVal updateid As Integer, ByVal cardid As Integer, ByVal ot As Integer, ByVal cardalias As Integer, ByVal atk As Integer, ByVal def As Integer, ByVal setcode As Integer, ByVal type As Integer, ByVal lvl As Integer, ByVal race As Integer, ByVal attribute As Integer, ByVal category As Integer) As Boolean
            Try
                Dim command As SQLiteCommand = Nothing
                If (updateid <> cardid) Then
                    command = New SQLiteCommand("INSERT INTO datas(id,ot,alias,setcode,type,atk,def,level,race,attribute,category) VALUES (@id, @ot, @alias, @setcode, @type, @atk, @def, @level, @race, @attribute, @category) ON DUPLICATE KEY UPDATE id=@id, ot=@ot, alias=@alias, setcode=@setcode, type=@type, atk=@atk, def=@def, level=@level, race=@race, attribute=@attribute, category=@category")
                Else
                    command = New SQLiteCommand("UPDATE id=@id, ot=@ot, alias=@alias, setcode=@setcode, type=@type, atk=@atk, def=@def, level=@level, race=@race, attribute=@attribute, category=@category WHERE id=@loadedid")
                End If
                command.Parameters.Add(New SQLiteParameter("@loadedid", updateid))
                command.Parameters.Add(New SQLiteParameter("@id", cardid))
                command.Parameters.Add(New SQLiteParameter("@ot", ot))
                command.Parameters.Add(New SQLiteParameter("@alias", cardalias))
                command.Parameters.Add(New SQLiteParameter("@setcode", setcode))
                command.Parameters.Add(New SQLiteParameter("@type", type))
                command.Parameters.Add(New SQLiteParameter("@atk", atk))
                command.Parameters.Add(New SQLiteParameter("@def", def))
                command.Parameters.Add(New SQLiteParameter("@level", lvl))
                command.Parameters.Add(New SQLiteParameter("@race", race))
                command.Parameters.Add(New SQLiteParameter("@attribute", attribute))
                command.Parameters.Add(New SQLiteParameter("@category", category))
                DatabaseHelper.ExecuteNonCommand(command)
                Return True
            Catch exception As Exception
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK)
                Return False
            End Try
        End Function

    End Class
End Namespace
