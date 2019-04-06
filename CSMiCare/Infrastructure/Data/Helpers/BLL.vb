Imports MySql.Data.MySqlClient

Public Class BLL
    Protected mySQLConnection As MySqlConnection
    Protected command As MySqlCommand
    Protected reader As MySqlDataReader

    Protected Sub OpenConnection(commandText As String)
        mySQLConnection = New MySqlConnection("Server=localhost;database=CSMiCare;uid=root;pwd=Accord605;")
        command = mySQLConnection.CreateCommand
        command.CommandText = commandText

        'Open the connection.
        mySQLConnection.Open()
    End Sub

    Protected Function DoCmd(commandText As String) As Integer
        OpenConnection(commandText)
        Return command.ExecuteNonQuery()
    End Function

    Protected Function GetCount(tableName As String, whereClause As String) As Integer
        Dim count = 0
        OpenConnection("SELECT Count(Id) As count FROM " + tableName + " " + whereClause)

        reader = command.ExecuteReader()
        Do While reader.Read()
            count = reader.GetInt32("count")
        Loop
        Return count
    End Function

    Protected Sub CloseConnection()
        reader.Close()
        mySQLConnection.Close()
    End Sub


End Class
