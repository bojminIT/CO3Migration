Imports Oracle.ManagedDataAccess.Client

Public Class EnvironmentConnection

    Property Environment As String
    Property Host As String
    Property Username As String
    Property Password As String

    Public Sub New(environment As String, host As String, username As String, password As String)
        Me.Environment = environment
        Me.Host = host
        Me.Username = username
        Me.Password = password
    End Sub

    Public Function getConnectionString() As String
        Dim conn_string As String = ""

        Dim ocsb As New OracleConnectionStringBuilder()

            With ocsb
                .DataSource = Host
                .UserID = Username
                .Password = Password
            End With

            conn_string = ocsb.ToString


        Return conn_string
    End Function

    Public Function TestConnection(ByRef conn_string As String) As String
        Dim isOpened As Boolean = False
        Dim msg As String = ""
        Dim connString As String = getConnectionString()
        Dim conn As New OracleConnection(connString)

        conn_string = connString

        Try
            conn.Open()
            isOpened = (conn.State = ConnectionState.Open)

            If isOpened Then
                conn.Close()
            End If

        Catch ex As Exception
            msg = ex.Message

        Finally
            If conn IsNot Nothing Then conn.Dispose()
            If isOpened Then msg = "yes" Else If msg = "" Then msg = "no"
        End Try

        Return msg
    End Function

    Public Overrides Function ToString() As String
        Return Me.Environment
    End Function

End Class
