Imports System.IO

Public Class ConnectionLoader

    Private conn_config_path As String = ""

    Public Sub New()
        conn_config_path = "conn_config.xml"
    End Sub

    Public Function getConnections() As DataTable
        Dim ds As DataSet = Nothing

        If (File.Exists(conn_config_path)) Then
            ds = New DataSet("connections")
            ds.ReadXml(conn_config_path)
        End If

        Dim dt As DataTable = Nothing

        If ds.Tables.Count > 0 Then
            dt = ds.Tables(0)
        End If

        Return dt
    End Function

End Class
