Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms

Module Connection
    Public OfflineMode As Boolean
    Public dst As New DataSet 'miniature of your table - cache table to client
    Public dst2 As New DataSet 'miniature of your table - cache table to client

    Public conn As New OleDb.OleDbConnection
    Public msda As OleDb.OleDbDataAdapter
    Public msda2 As OleDb.OleDbDataAdapter
    Public com As New OleDbCommand
    Public rst As OleDbDataReader

    Public sqlserver As String
    Public sqlPort As String
    Public sqluser As String
    Public sqlpass As String
    Public sqldatabase As String


    Public connclient As New MySqlConnection 'for MySQLDatabase Connection
    Public msdaclient As MySqlDataAdapter 'is use to update the dataset and datasource
    Public dstclient As New DataSet 'miniature of your table - cache table to client
    Public comclient As New MySqlCommand
    Public rstclient As MySqlDataReader

    Public Function OpenLocalConnection() As Boolean
        Try
            RecordLog("Connecting to local database")
            conn.Close()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath.ToString & "\db.accdb;Jet OLEDB:Database Password=12sysadmin34;")
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 6000000
            RecordLog("Local DB connection successfully stablished")
        Catch errSQL As Exception
            RecordLog("ERROR CONNECTION: " & errSQL.Message)
            CheckConnection()
        End Try
        Return True
    End Function

    Public Sub CheckConnection()
        If OpenLocalConnection() = True Then
            Dim ServicesToRun() As System.ServiceProcess.ServiceBase
            ServicesToRun = New System.ServiceProcess.ServiceBase() {New MySQLBackup()}
            System.ServiceProcess.ServiceBase.Run(ServicesToRun)
        Else
            CheckConnection()
        End If
    End Sub

    Public Function GridHideColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).Visible = False
                End If
            Next
        Next
        Return grdView
    End Function
 
    Public Function ConvertServerTime(ByVal d As Date)
        Return d.ToString("HH:mm:00")
    End Function

    Public Function GridColumnAlignment(ByVal grdView As DataGridView, ByVal column As Array, ByVal alignment As DataGridViewContentAlignment) As DataGridView
        '   Dim array() As String = {a}
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).DefaultCellStyle.Alignment = alignment
                    grdView.Columns(i).HeaderCell.Style.Alignment = alignment
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function countqry(ByVal tbl As String, ByVal cond As String)
        Dim cnt As Integer = 0
        Try
            com.CommandText = "select count(*) as cnt from " & tbl & " where " & cond
            rst = com.ExecuteReader
            While rst.Read
                cnt = Val(rst("cnt").ToString)
            End While
            rst.Close()
        Catch errSQL As Exception
            RecordLog("ERROR COUNT: " & errSQL.Message)
        End Try
        Return cnt
    End Function
    Public Function ConvertDate(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd")
    End Function
    Public Function CLearDateString(ByVal str As String)
        str = str.Replace(":", "")
        str = str.Replace("/", "")
        str = str.Replace("AM", "")
        str = str.Replace("PM", "")
        str = str.Replace(" ", "")
        Return str
    End Function
    Public Sub RecordLog(ByVal message As String)
        Dim fileName As String = CDate(Now).ToString("yyyy-MM-dd") & ".log"
        Dim path As String = Application.StartupPath.ToString & "\Log"
        If Not System.IO.Directory.Exists(path) Then
            System.IO.Directory.CreateDirectory(path)
        End If
        If Not System.IO.File.Exists(fileName) Then
            System.IO.File.Create(fileName)
        End If

        Dim sw As StreamWriter = File.AppendText(path & "\" & fileName)
        sw.WriteLine(CDate(Now).ToString("yyyy-MM-dd hh:mm:ss tt") & Chr(9) & message)
        sw.Close()
    End Sub
End Module
