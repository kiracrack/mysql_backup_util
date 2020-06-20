Imports System.Windows.Forms
Imports System.IO
Imports System.ServiceProcess
Imports System.Data.OleDb


Public Class MySQLBackup
    Public timer As System.Timers.Timer = New System.Timers.Timer()
    Protected Overrides Sub OnStart(ByVal args() As String)
        If OpenLocalConnection() = True Then
            timer.Interval = 30000 ' 1 second
            AddHandler timer.Elapsed, AddressOf Me.OnTimer
            timer.Enabled = True
            timer.Start()
            RecordLog("MySQL Central Started")
        Else
            CheckConnection()
        End If
    End Sub

    Protected Overrides Sub OnStop()
        RecordLog("MySQL Central Stop")
    End Sub
    Private Sub OnTimer(sender As Object, e As Timers.ElapsedEventArgs)
        Try
            CheckBackup()
        Catch ex As Exception
            RecordLog("Error" + ex.Message)
            CheckConnection()
        Finally
            timer.Start()
        End Try
    End Sub
    Protected Overrides Sub OnContinue()
        Application.Restart()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub CheckBackup()
        Dim backupdone As Boolean = False
        Try
            If countqry("tblbackuplogs", "backupdate='" & ConvertDate(CDate(Now)) & "'") = 0 Then
                If Not BackupService.bw.IsBusy() Then
                    Dim backupScript As String = ""
                    dst = New DataSet
                    msda = New OleDbDataAdapter("select *, Format([timebackup], 'hh:mm:ss') as [backuptime] from tbldatabases where actived=true and " & If(CDate(Now).DayOfWeek = DayOfWeek.Monday, "monday=true", "") & If(CDate(Now).DayOfWeek = DayOfWeek.Tuesday, "tuesday=true", "") & If(CDate(Now).DayOfWeek = DayOfWeek.Wednesday, "wednesday=true", "") & If(CDate(Now).DayOfWeek = DayOfWeek.Thursday, "thursday=true", "") & If(CDate(Now).DayOfWeek = DayOfWeek.Friday, "friday=true", "") & If(CDate(Now).DayOfWeek = DayOfWeek.Saturday, "saturday=true", "") & If(CDate(Now).DayOfWeek = DayOfWeek.Sunday, "sunday=true", "") & "", conn)
                    msda.Fill(dst, 0)
                    For cnt = 0 To dst.Tables(0).Rows.Count - 1
                        With (dst.Tables(0))
                            If Not Directory.Exists(.Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString()) Then
                                RecordLog("Backup location not exists.. Create " & .Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString() & " ")
                                Directory.CreateDirectory(.Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString())
                            End If
                            If countqry("tblbackuplogs", "databaseid=" & .Rows(cnt)("id").ToString() & " and backupdate='" & ConvertDate(CDate(Now)) & "'") = 0 Then
                                RecordLog("Preparing backup for " & LCase(.Rows(cnt)("description").ToString()))
                                com.CommandText = "INSERT INTO tblbackuplogs (databaseid,filename,backupdate,backuplocation,host,backupscript,executed,compress,compressed) values('" & .Rows(cnt)("id").ToString() & "','" & .Rows(cnt)("dbname").ToString() & " " & CDate(Now).ToString("yyyyMMdd") & CLearDateString(.Rows(cnt)("backuptime").ToString()) & ".sql" & "','" & ConvertDate(CDate(Now)) & "','" & .Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString() & "\" & .Rows(cnt)("dbname").ToString() & " " & CLearDateString(Now.ToString("yyyyMMdd")) & CLearDateString(.Rows(cnt)("backuptime").ToString()) & ".sql" & "','" & .Rows(cnt)("host").ToString() + ":" + .Rows(cnt)("port").ToString() & "','" & "mysqldump --opt --host " & .Rows(cnt)("host").ToString() & " --port=" & .Rows(cnt)("port").ToString() & " --password=" & DecryptTripleDES(.Rows(cnt)("password").ToString()) & " --user=" & .Rows(cnt)("username").ToString() & " --database " & .Rows(cnt)("dbname").ToString() & " -r  """ & .Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString() & "\" & .Rows(cnt)("dbname").ToString() & " " & CLearDateString(Now.ToString("yyyyMMdd")) & CLearDateString(.Rows(cnt)("backuptime").ToString()) & ".sql""" & "',FALSE," & CBool(.Rows(cnt)("compress").ToString()) & ",FALSE)" : com.ExecuteNonQuery()
                            End If
                        End With
                    Next
                End If
            End If
            'execute backup all prepared database
            If countqry("tblbackuplogs", "backupdate='" & ConvertDate(CDate(Now)) & "' and executed=false") > 0 Then
                If Not CompressService.bwCompress.IsBusy() And Not BackupService.bw.IsBusy() Then
                    dst = New DataSet
                    msda = New OleDbDataAdapter("select * from tblbackuplogs where backupdate='" & ConvertDate(CDate(Now)) & "' and executed=false", conn)
                    msda.Fill(dst, 0)
                    For cnt = 0 To dst.Tables(0).Rows.Count - 1
                        With (dst.Tables(0))
                            ExecuteDatabaseBackup(.Rows(cnt)("backupdate").ToString(), .Rows(cnt)("databaseid").ToString(), .Rows(cnt)("host").ToString(), .Rows(cnt)("backupscript").ToString(), .Rows(cnt)("backuplocation").ToString())
                        End With
                    Next
                End If
                backupdone = False
            Else
                backupdone = True
            End If

            If backupdone = True Then
                If countqry("tblbackuplogs", "backupdate='" & ConvertDate(CDate(Now)) & "' and executed=true and compress=true and compressed=false") > 0 Then
                    If Not CompressService.bwCompress.IsBusy() And Not BackupService.bw.IsBusy() Then
                        dst2 = New DataSet
                        msda2 = New OleDbDataAdapter("select * from tblbackuplogs where backupdate='" & ConvertDate(CDate(Now)) & "' and executed=true and compress=true and compressed=false", conn)
                        msda2.Fill(dst2, 0)
                        For cnt = 0 To dst2.Tables(0).Rows.Count - 1
                            With (dst2.Tables(0))
                                ExecuteCompressBackup(.Rows(cnt)("backupdate").ToString(), .Rows(cnt)("databaseid").ToString(), .Rows(cnt)("backuplocation").ToString(), CBool(.Rows(cnt)("compress").ToString()))
                            End With
                        Next
                    End If
                End If
            End If

            'If CDate(Now) > CDate(Now.ToShortDateString + " " + CDate(.Rows(cnt)("backuptime").ToString()).ToString("hh:mm:ss tt")).ToString Then
            '    If Directory.Exists(.Rows(cnt)("backuplocation").ToString()) Then
            '        If Not Directory.Exists(.Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString()) Then
            '            RecordLog("Backup location not exists.. Create " & .Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString() & " ")
            '            Directory.CreateDirectory(.Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString())
            '        End If

            '        '  

            '        If countqry("tblbackuplogs", "databaseid=" & .Rows(cnt)("id").ToString() & " and filename='" & .Rows(cnt)("dbname").ToString() & " " & CDate(Now).ToString("yyyyMMdd") & CLearDateString(.Rows(cnt)("backuptime").ToString()) & ".sql" & "'") = 0 Then
            '            ExecuteDatabaseBackup(True, .Rows(cnt)("id").ToString(), .Rows(cnt)("host").ToString() + ":" + .Rows(cnt)("port").ToString(), "mysqldump --opt --host " & .Rows(cnt)("host").ToString() & " --port=" & .Rows(cnt)("port").ToString() & " --password=" & DecryptTripleDES(.Rows(cnt)("password").ToString()) & " --user=" & .Rows(cnt)("username").ToString() & " --database " & .Rows(cnt)("dbname").ToString() & " -r  """ & .Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString() & "\" & .Rows(cnt)("dbname").ToString() & " " & CLearDateString(Now.ToString("yyyyMMdd")) & CLearDateString(.Rows(cnt)("backuptime").ToString()) & ".sql""", .Rows(cnt)("backuplocation").ToString() & "\" & .Rows(cnt)("dbname").ToString() & "\" & .Rows(cnt)("dbname").ToString() & " " & CLearDateString(Now.ToString("yyyyMMdd")) & CLearDateString(.Rows(cnt)("backuptime").ToString()) & ".sql", CBool(.Rows(cnt)("compress").ToString()))
            '        End If
            '    End If
            'End If
        Catch ex As Exception
            'RecordLog("ERROR CHECKING BACKUP: " & ex.Message)
        End Try
    End Sub
End Class
