<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMysqlCentralBackup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMysqlCentralBackup))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteDatabaseServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExecuteBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshDatabaseListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckOnlineServer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddnewServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitConsoleToolStripMenuItem, Me.cmdChangePassword, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 24)
        Me.MenuStrip1.TabIndex = 372
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitConsoleToolStripMenuItem
        '
        Me.ExitConsoleToolStripMenuItem.Name = "ExitConsoleToolStripMenuItem"
        Me.ExitConsoleToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ExitConsoleToolStripMenuItem.Text = "Exit Tool"
        '
        'cmdChangePassword
        '
        Me.cmdChangePassword.Name = "cmdChangePassword"
        Me.cmdChangePassword.Size = New System.Drawing.Size(92, 20)
        Me.cmdChangePassword.Text = "Add Database"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.txtDate.ForeColor = System.Drawing.Color.Black
        Me.txtDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDate.Location = New System.Drawing.Point(353, 86)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(276, 23)
        Me.txtDate.TabIndex = 375
        Me.txtDate.Text = "December 13, 1987 MONDAY"
        Me.txtDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Segoe UI", 25.75!)
        Me.txtTime.ForeColor = System.Drawing.Color.Black
        Me.txtTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTime.Location = New System.Drawing.Point(353, 39)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(276, 51)
        Me.txtTime.TabIndex = 376
        Me.txtTime.Text = "10:50 PM"
        Me.txtTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MyDataGridView)
        Me.Panel1.Controls.Add(Me.txtTime)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 494)
        Me.Panel1.TabIndex = 381
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.MultiSelect = False
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(826, 494)
        Me.MyDataGridView.TabIndex = 396
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLocalData, Me.DeleteDatabaseServerToolStripMenuItem, Me.ExecuteBackupToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshDatabaseListToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(194, 98)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.MySQLCentralBackup.My.Resources.Resources.database__pencil
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(193, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Edit database server"
        '
        'DeleteDatabaseServerToolStripMenuItem
        '
        Me.DeleteDatabaseServerToolStripMenuItem.Image = Global.MySQLCentralBackup.My.Resources.Resources.database_delete
        Me.DeleteDatabaseServerToolStripMenuItem.Name = "DeleteDatabaseServerToolStripMenuItem"
        Me.DeleteDatabaseServerToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.DeleteDatabaseServerToolStripMenuItem.Text = "Delete Database Server"
        '
        'ExecuteBackupToolStripMenuItem
        '
        Me.ExecuteBackupToolStripMenuItem.Image = Global.MySQLCentralBackup.My.Resources.Resources.database__arrow
        Me.ExecuteBackupToolStripMenuItem.Name = "ExecuteBackupToolStripMenuItem"
        Me.ExecuteBackupToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ExecuteBackupToolStripMenuItem.Text = "Execute Backup"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'RefreshDatabaseListToolStripMenuItem
        '
        Me.RefreshDatabaseListToolStripMenuItem.Image = Global.MySQLCentralBackup.My.Resources.Resources.arrow_continue_180
        Me.RefreshDatabaseListToolStripMenuItem.Name = "RefreshDatabaseListToolStripMenuItem"
        Me.RefreshDatabaseListToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.RefreshDatabaseListToolStripMenuItem.Text = "Refresh Database List"
        '
        'CheckOnlineServer
        '
        Me.CheckOnlineServer.Interval = 5000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "MySQL Central Backup"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddnewServerToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 76)
        '
        'AddnewServerToolStripMenuItem
        '
        Me.AddnewServerToolStripMenuItem.Image = Global.MySQLCentralBackup.My.Resources.Resources.database__plus
        Me.AddnewServerToolStripMenuItem.Name = "AddnewServerToolStripMenuItem"
        Me.AddnewServerToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AddnewServerToolStripMenuItem.Text = "Addnew Database"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.MySQLCentralBackup.My.Resources.Resources.databases
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripMenuItem1.Tag = "1"
        Me.ToolStripMenuItem1.Text = "Show Backup Setup"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(175, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.MySQLCentralBackup.My.Resources.Resources.cross
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripMenuItem2.Text = "Exit Auto Backup"
        '
        'frmMysqlCentralBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(842, 557)
        Me.Name = "frmMysqlCentralBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQL Central Backup - By Winter Bugahod"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdChangePassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckOnlineServer As System.Windows.Forms.Timer
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExecuteBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddnewServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshDatabaseListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteDatabaseServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
