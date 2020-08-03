Imports System.ComponentModel
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Xml
Imports System.Configuration
Imports System.Data
Imports Oracle.DataAccess
Imports Oracle.ManagedDataAccess.Client

Public Class XMill

    Public XmlDoc As New XmlDocument() ' Load XML
    Public listOfXMLs As List(Of String) = New List(Of String)
    Public listOfPaths As List(Of String) = New List(Of String)
    Public saveCS As String
    Private _
        dt_environments As DataTable,
        dt_insert As New DataTable,
        dt_storage As New DataTable

    Public dt_preview As DataTable = New DataTable() ' define data table where we will store data 

    Private bs_preview As New BindingSource
    'Public filepath As String


    Public Sub New()
        InitializeComponent()
        createInsertTable()
        createStorageTable()
        saveCS = ""
        dgvInsert.DataSource = dt_insert
        dgvStorage.DataSource = dt_storage
        'filepath = ""
        tsslStatus.Visible = False

        With dt_preview.Columns
            .Add("XMLFileName", GetType(String))
            .Add("ParentObjectTypeId", GetType(Integer))
            .Add("ParentObjectType", GetType(String))
            .Add("ObjectTypeId", GetType(Integer))
            .Add("ObjectType", GetType(String))
            .Add("BvId", GetType(Integer))
            .Add("BvValue", GetType(String))
            .Add("BvNodeName", GetType(String))
            .Add("DateTimeNow", GetType(String))
        End With

        dgvPreview.DataSource = dt_preview
    End Sub

    Function returnXMLFileName(fileName As String) As String ' function that returns name of the xml file that is selected 
        Dim splitFileName = fileName.Split("\")

        For Each item As String In splitFileName
            fileName = item.ToString()
        Next
        Return fileName
    End Function

    Private Sub fXMill_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cl As New ConnectionLoader()
        dt_environments = cl.getConnections()

        If dt_environments IsNot Nothing Then
            For Each r As DataRow In dt_environments.Rows
                Dim ec As New EnvironmentConnection(r("environment"), r("host"), r("username"), r("password"))
                tscbEnvironment.Items.Add(ec)
            Next
        End If


    End Sub



    Private Sub bChoose_Click(sender As Object, e As EventArgs) Handles bChoose.Click
        Dim ofd As New OpenFileDialog()
        Dim fbd As FolderBrowserDialog = New FolderBrowserDialog()

        With fbd
            .Description = "Select a path"
            .SelectedPath = "c:/"
        End With

        If fbd.ShowDialog() = DialogResult.OK Then
            lFilePath.Text = fbd.SelectedPath
            Dim dinfo As New DirectoryInfo(lFilePath.Text)

            Dim files As FileInfo() = dinfo.GetFiles("*.xml")

            If files.Count = 0 Then
                MessageBox.Show("There is no XML files in folder " + fbd.SelectedPath.ToString() + "!")
            Else
                For Each file As FileInfo In files
                    listOfXMLs.Add(lFilePath.Text + "\" + file.Name)
                Next
            End If

        End If
    End Sub

    Private Sub bPreview_Click(sender As Object, e As EventArgs) Handles bPreview.Click

        Dim parse As ParseMill = New ParseMill()
        parse.ListOfNodeNames.Clear()
        If lFilePath.Text = "" Then
            MessageBox.Show("Choose folder path to begin parsing!", "Attention", MessageBoxButtons.OK)
        Else

            For Each item In listOfXMLs
                parse.ListOfNodeNames.Clear()
                parse.XmlDoc.Load(item.ToString())
                Dim xmlFileName As String = returnXMLFileName(item.ToString()) ' call function to return xml file name
                parse.ListOfObjTypes.Add(New ObjectTypeParentChildRelationShip(0, "no parent", 12, "Account")) ' add root node 
                parse.CreateObjectTypeList("/Account", parse.ListOfObjTypes, xmlFileName)
                parse.ReadNodes("/Account", dt_preview, parse.ListOfNodeNames, xmlFileName)
            Next
            'enableUIControls(False)

        End If


    End Sub

    Private Sub bRun_Click(sender As Object, e As EventArgs) Handles bRun.Click
        Dim load_table_name As String = My.Settings.storage_env & "." & My.Settings.table_name

        enableUIControls(False)

        SaveUsingOracleBulkCopy(load_table_name, dt_preview) ' INFORCE
    End Sub


    Public Sub SaveUsingOracleBulkCopy(destTableName As String, dt As DataTable)
        Try
            Using connection As New Oracle.DataAccess.Client.OracleConnection(saveCS)
                connection.Open()
                Using bulkCopy As New Oracle.DataAccess.Client.OracleBulkCopy(connection, Oracle.DataAccess.Client.OracleBulkCopyOptions.UseInternalTransaction)
                    bulkCopy.DestinationTableName = destTableName
                    bulkCopy.BulkCopyTimeout = 600
                    bulkCopy.WriteToServer(dt)
                End Using
            End Using
        Catch ex As Exception

            Throw ex
        End Try
    End Sub



    Private Sub bCopyPath_Click(sender As Object, e As EventArgs)
        lFilePath.Text = ""
        'filepath = ""

    End Sub

    Private Sub bTestConnection_Click(sender As Object, e As EventArgs) Handles bTestConnection.Click
        If tscbEnvironment.SelectedItem IsNot Nothing Then
            Dim conn_string As String = ""
            Dim envConn As EnvironmentConnection = CType(tscbEnvironment.SelectedItem, EnvironmentConnection)
            Dim msg As String = testConnection(envConn, conn_string)
            Dim icon As MessageBoxIcon
            'MessageBox.Show(conn_string.ToString() + " ovo je cs")
            saveCS = conn_string
            Select Case msg
                Case "yes"
                    msg = "Connection to database successful!"
                    icon = 64
                Case "no"
                    msg = "Connection to database failed."
                    icon = 48
                Case Else
                    msg = "Something went wrong while connecting to the database: " & vbNewLine & msg & vbNewLine & conn_string
                    icon = 16
            End Select

            MessageBox.Show(msg, "Test Connection", MessageBoxButtons.OK, icon)
        Else
            MessageBox.Show("Please Choose Envirnoment !")
        End If

    End Sub

    Private Function testConnection(conn As EnvironmentConnection, ByRef conn_string As String) As String
        Dim testConnMsg As String = conn.TestConnection(conn_string)
        Return testConnMsg
    End Function

    Private Sub bwParser_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwParser.DoWork
        Dim jobName As String = e.Argument.ToString()

        Select Case jobName
            Case "parse"
                startParsingMill()
            Case "run"
                startStorageWork()
        End Select
    End Sub

    Private Sub bwParser_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwParser.RunWorkerCompleted
        enableUIControls(True)
    End Sub

    Private Sub createInsertTable()
        With dt_insert
            .Columns.Add("policy_id", GetType(System.String))
            .PrimaryKey = New DataColumn() {dt_insert.Columns("policy_id")}
        End With
    End Sub

    Private Sub createStorageTable()
        With dt_storage
            .Columns.Add("policy_id", GetType(System.String))
            .PrimaryKey = New DataColumn() {dt_storage.Columns("policy_id")}
        End With
    End Sub

    Private Sub tscbEnvironment_Click(sender As Object, e As EventArgs) Handles tscbEnvironment.Click

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub



    Private Sub rbQuery_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rbOverride_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub enableUIControls(enable As Boolean)
        bChoose.Enabled = enable
        bPreview.Enabled = enable
        bRun.Enabled = enable
        'tsslStatus.Visible = Not enable
    End Sub

    Private Sub dgvInsert_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInsert.CellContentClick

    End Sub

    Private Sub OverrideParsedData_CheckedChanged(sender As Object, e As EventArgs) Handles OverrideParsedData.CheckedChanged
        If OverrideParsedData.Checked = True Then
            dgvPreview.ReadOnly = False
        Else
            dgvPreview.ReadOnly = True
        End If
    End Sub

    Private Sub startParsingMill()
        Threading.Thread.Sleep(2000)
    End Sub

    Private Sub startStorageWork()
        Threading.Thread.Sleep(2000)
    End Sub

End Class
