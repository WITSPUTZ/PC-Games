
Imports System.Data
Imports System.Collections.Generic
Imports System.Text
Imports System.Data.Sql
Imports System.Windows.Forms
Imports System.Data.SQLite

Namespace DevPro_CardManager
    Public NotInheritable Class DatabaseHelper
        Private Sub New()
        End Sub


        Public Shared Function ExecuteNonCommand(ByVal command As SQLiteCommand) As Boolean
            Try
                command.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End Function

        Public Shared Function ExecuteStringCommand(ByVal command As SQLiteCommand, ByVal columncount As Integer) As List(Of String())
            Try
                Dim values As New List(Of String())()
                Dim reader As SQLiteDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim row As New List(Of String)()
                    For i As Integer = 0 To reader.FieldCount - 1
                        row.Add(reader(i).ToString())
                    Next
                    values.Add(row.ToArray())
                End While
                reader.Close()

                Return values
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return New List(Of String())()
            End Try
        End Function

        Public Shared Function ExecuteIntCommand(ByVal command As SQLiteCommand) As Integer
            Try
                Return Convert.ToInt32(command.ExecuteScalar())
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return -1
            End Try
        End Function
    End Class
End Namespace
