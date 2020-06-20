Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports ICSharpCode.SharpZipLib.Zip
Imports System.IO
Imports System.IO.Compression

Module BackupService
    Public autobackupmode As Boolean
    Public BackupScript As String
    Public backupSqlFile As String
    Public compressfile As Boolean
    Public bw As BackgroundWorker = New BackgroundWorker
    Public Function customCertValidation(ByVal sender As Object, _
                                                ByVal cert As X509Certificate, _
                                                ByVal chain As X509Chain, _
                                                ByVal errors As SslPolicyErrors) As Boolean

        Return True
    End Function

    Public Function ExecuteDatabaseBackup(ByVal autobackup As Boolean, ByVal script As String, ByVal file As String, ByVal compress As Boolean) As Boolean
        If Not bw.IsBusy() Then
            bw.WorkerSupportsCancellation = True
            AddHandler bw.DoWork, AddressOf bw_DoWork
            AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
            AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
            autobackupmode = autobackup
            BackupScript = script
            backupSqlFile = file
            compressfile = compress
            bw.RunWorkerAsync()
        End If
    End Function

    Public Function DoBackupJob(ByVal autobackup As Boolean, ByVal script As String, ByVal file As String, ByVal compress As Boolean) As Boolean
        Try
            Dim process As System.Diagnostics.Process
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            processStartInfo = New System.Diagnostics.ProcessStartInfo
            processStartInfo.FileName = "cmd.exe"

            processStartInfo.Arguments = "/C " + script
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            processStartInfo.UseShellExecute = True
            process = System.Diagnostics.Process.Start(processStartInfo)
            'System.Threading.Thread.Sleep()
            process.WaitForExit()
            If process.HasExited Then
                Dim zip As New ICSharpCode.SharpZipLib.Zip.FastZip
                zip.CreateZip(Path.GetDirectoryName(file) + "\" + Path.GetFileNameWithoutExtension(file) & ".zip", Path.GetDirectoryName(file), True, Path.GetFileName(file) + "$")
                If System.IO.File.Exists(file) = True Then
                    System.IO.File.Delete(file)
                End If
                If autobackup = False Then
                    MessageBox.Show("Database successfully backup!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
        Return True
    End Function

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        If bw.CancellationPending = True Then
            e.Cancel = True
            Exit Sub
        End If
        DoBackupJob(autobackupmode, BackupScript, backupSqlFile, compressfile)
        System.Threading.Thread.Sleep(2000)
    End Sub
    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        autobackupmode = False : BackupScript = ""
    End Sub

    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        ' Me.LinkLabel2.Text = e.ProgressPercentage.ToString() & "%"
    End Sub

End Module
