Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.IO

Module BackupService
    Private backupdate As String
    Private backupid As Integer
    Private backuphost As String
    Private BackupScript As String
    Private backupSqlFile As String
    Public bw As BackgroundWorker = New BackgroundWorker
    Public Function customCertValidation(ByVal sender As Object, _
                                                ByVal cert As X509Certificate, _
                                                ByVal chain As X509Chain, _
                                                ByVal errors As SslPolicyErrors) As Boolean

        Return True
    End Function

    Public Function ExecuteDatabaseBackup(ByVal backup_date As String, ByVal id As Integer, ByVal host As String, ByVal script As String, ByVal file As String) As Boolean
        If Not CompressService.bwCompress.IsBusy() And Not BackupService.bw.IsBusy() Then
            bw.WorkerSupportsCancellation = True
            AddHandler bw.DoWork, AddressOf bw_DoWork
            AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
            AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
            backupdate = backup_date
            backupid = id
            backuphost = host
            BackupScript = script
            backupSqlFile = file
            bw.RunWorkerAsync()
        End If
    End Function

    Public Function DoBackupJob(ByVal backup_date As String, ByVal id As Integer, ByVal host As String, ByVal script As String, ByVal file As String) As Boolean
        Try
            If countqry("tblbackuplogs", "databaseid=" & id & " and backupdate='" & backup_date & "' and executed=true") = 0 Then
                Dim process As System.Diagnostics.Process
                Dim processStartInfo As System.Diagnostics.ProcessStartInfo
                processStartInfo = New System.Diagnostics.ProcessStartInfo
                processStartInfo.FileName = "cmd.exe"

                processStartInfo.Arguments = "/C " + script
                processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                processStartInfo.UseShellExecute = True

                RecordLog("Connecting to mysql server host " & host)
                process = System.Diagnostics.Process.Start(processStartInfo)
                RecordLog("Execute backup " & Path.GetFileName(file))
                process.WaitForExit()

                If process.HasExited Then
                    RecordLog(Path.GetFileName(file) & " successfully created")
                    com.CommandText = "UPDATE tblbackuplogs set executed=true where databaseid=" & id & " and backupdate='" & backup_date & "'" : com.ExecuteNonQuery()
                    process.Dispose()
                End If
            End If
        Catch ex As Exception
            ' RecordLog("ERROR EXECUTING BACKUP: " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        If bw.CancellationPending = True Then
            e.Cancel = True
            Exit Sub
        End If
        DoBackupJob(backupdate, backupid, backuphost, BackupScript, backupSqlFile)
        System.Threading.Thread.Sleep(2000)
    End Sub
    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        BackupScript = ""
    End Sub

    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        ' Me.LinkLabel2.Text = e.ProgressPercentage.ToString() & "%"
    End Sub

     
End Module
