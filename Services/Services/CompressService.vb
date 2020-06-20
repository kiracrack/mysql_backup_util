Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.IO

Module CompressService
    Private backupdate As String
    Private backupid As Integer
    Private backupSqlFile As String
    Private compressfile As Boolean
    Public bwCompress As BackgroundWorker = New BackgroundWorker
    Public Function customCertValidation(ByVal sender As Object, _
                                                ByVal cert As X509Certificate, _
                                                ByVal chain As X509Chain, _
                                                ByVal errors As SslPolicyErrors) As Boolean

        Return True
    End Function

    Public Function ExecuteCompressBackup(ByVal backup_date As String, ByVal id As Integer, ByVal file As String, ByVal compress As Boolean) As Boolean
        If Not CompressService.bwCompress.IsBusy() And Not BackupService.bw.IsBusy() Then
            bwCompress.WorkerSupportsCancellation = True
            AddHandler bwCompress.DoWork, AddressOf bwCompress_DoWork
            AddHandler bwCompress.ProgressChanged, AddressOf bwCompress_ProgressChanged
            AddHandler bwCompress.RunWorkerCompleted, AddressOf bwCompress_RunWorkerCompleted
            backupdate = backup_date
            backupid = id
            backupSqlFile = file
            compressfile = compress
            bwCompress.RunWorkerAsync()
        End If
    End Function

    Public Function DoCompressJob(ByVal backup_date As String, ByVal id As Integer, ByVal file As String, ByVal compress As Boolean) As Boolean
        Try
            If countqry("tblbackuplogs", "databaseid=" & id & " and backupdate='" & backup_date & "' and executed=true and compressed=true") = 0 Then
                Dim zip As New ICSharpCode.SharpZipLib.Zip.FastZip
                RecordLog("Compressing file " & Path.GetFileName(file))
                zip.CreateZip(Path.GetDirectoryName(file) + "\" + Path.GetFileNameWithoutExtension(file) & ".zip", Path.GetDirectoryName(file), True, Path.GetFileName(file) + "$")
                If System.IO.File.Exists(file) = True Then
                    RecordLog(Path.GetFileNameWithoutExtension(file) & ".zip successfully compressed")
                    com.CommandText = "UPDATE tblbackuplogs set compressed=true where databaseid=" & id & " and backupdate='" & backup_date & "'" : com.ExecuteNonQuery()
                    System.IO.File.Delete(file)
                End If
            End If
        Catch ex As Exception
            'RecordLog("ERROR COMPRESSING BACKUP: " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub bwCompress_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        If bwCompress.CancellationPending = True Then
            e.Cancel = True
            Exit Sub
        End If
        DoCompressJob(backupdate, backupid, backupSqlFile, compressfile)
        System.Threading.Thread.Sleep(2000)
    End Sub
    Private Sub bwCompress_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

    End Sub

    Private Sub bwCompress_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        ' Me.LinkLabel2.Text = e.ProgressPercentage.ToString() & "%"
    End Sub

  
End Module
