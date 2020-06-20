Imports System.Runtime.InteropServices, System.IO, System.Drawing, System.Drawing.Imaging, System.Collections, System.ComponentModel, System.Diagnostics
Imports System.Data
Imports System.Data.OleDb

Public Class frmMysqlCentralBackup

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F11) Then

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTime.Text = Now.ToString("h:mm:ss tt")
        OpenLocalConnection()
        ShowDatabaseList()
    End Sub
    Public Sub ShowDatabaseList()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        'msda = New OleDbDataAdapter("Select id, Description, host as [Database Host], port as [Port], username as [Username], dbname as [Database], timebackup as [Time Backup],password,backuplocation, Actived, Compress, Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday from tbldatabases order by Description asc", conn)
        msda = New OleDbDataAdapter("Select id, Description, host as [Database Host], port as [Port], username as [Username], dbname as [Database], timebackup as [Time Backup],password,backuplocation, Actived, Compress from tbldatabases order by Description asc", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"id", "password", "backuplocation"})
        GridColumnAlignment(MyDataGridView, {"Port", "Username", "Time Backup"}, DataGridViewContentAlignment.MiddleCenter)

    End Sub
    Public Sub ActivateOfflineMode()
        txtDate.Text = Now.ToString("dddd MMMM dd, yyyy")
    End Sub

    Private Sub cmdChangePassword_Click(sender As Object, e As EventArgs) Handles cmdChangePassword.Click
        frmDatabaseInformation.Show()
    End Sub

    Private Sub ExitConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitConsoleToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to exit mysql central backup? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            End
        End If

    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        frmDatabaseInformation.id.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmDatabaseInformation.mode.Text = "edit"
        frmDatabaseInformation.Show(Me)
    End Sub

    Private Sub ExecuteBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecuteBackupToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Microsoft Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = MyDataGridView.Item("Database", MyDataGridView.CurrentRow.Index).Value().ToString() & " " & Now.ToString("yyyyMMddhhmmss") & ".sql"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            ExecuteDatabaseBackup(False, "mysqldump --opt --host " & MyDataGridView.Item("Database Host", MyDataGridView.CurrentRow.Index).Value().ToString() & " --port=" & MyDataGridView.Item("Port", MyDataGridView.CurrentRow.Index).Value().ToString() & " --password=" & DecryptTripleDES(MyDataGridView.Item("password", MyDataGridView.CurrentRow.Index).Value().ToString()) & " --user=" & MyDataGridView.Item("Username", MyDataGridView.CurrentRow.Index).Value().ToString() & " --database " & MyDataGridView.Item("Database", MyDataGridView.CurrentRow.Index).Value().ToString() & " -r  """ & saveFileDialog1.FileName & """", saveFileDialog1.FileName, CBool(MyDataGridView.Item("Compress", MyDataGridView.CurrentRow.Index).Value()))
        End If

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub frmMysqlCentralBackup_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Hide()
            NotifyIcon1.BalloonTipText = "MySQL Central Backup is running in your system tray.."
            NotifyIcon1.ShowBalloonTip(500)
        End If
    End Sub
 
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If MessageBox.Show("Are you sure you want to exit mysql central backup? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            End
        End If

    End Sub

    Private Sub RefreshDatabaseListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDatabaseListToolStripMenuItem.Click
        ShowDatabaseList()
    End Sub

    Private Sub DeleteDatabaseServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDatabaseServerToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue delete selected database server? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tbldatabases where id=" & MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString() & "" : com.ExecuteReader()
            ShowDatabaseList()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

   
End Class
