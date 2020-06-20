<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabaseInformation))
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServerhost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBackuppLocation = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.txtTimeBackup = New System.Windows.Forms.TextBox()
        Me.ckMonday = New System.Windows.Forms.CheckBox()
        Me.ckTuesday = New System.Windows.Forms.CheckBox()
        Me.ckSunday = New System.Windows.Forms.CheckBox()
        Me.ckSaturday = New System.Windows.Forms.CheckBox()
        Me.ckFriday = New System.Windows.Forms.CheckBox()
        Me.ckThursday = New System.Windows.Forms.CheckBox()
        Me.ckWednesday = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ckActived = New System.Windows.Forms.CheckBox()
        Me.ckCompress = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSave.Location = New System.Drawing.Point(157, 382)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(177, 39)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Confirm Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Font = New System.Drawing.Font("Wingdings", 9.25!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(157, 126)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtPassword.Size = New System.Drawing.Size(284, 21)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(94, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 368
        Me.Label1.Text = "Password"
        '
        'txtServerhost
        '
        Me.txtServerhost.AcceptsReturn = True
        Me.txtServerhost.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtServerhost.Location = New System.Drawing.Point(157, 78)
        Me.txtServerhost.Name = "txtServerhost"
        Me.txtServerhost.Size = New System.Drawing.Size(204, 22)
        Me.txtServerhost.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(85, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 379
        Me.Label3.Text = "Server Host"
        '
        'txtPort
        '
        Me.txtPort.AcceptsReturn = True
        Me.txtPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPort.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPort.Location = New System.Drawing.Point(364, 78)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(77, 22)
        Me.txtPort.TabIndex = 2
        Me.txtPort.Text = "3306"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(92, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 384
        Me.Label5.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.AcceptsReturn = True
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUsername.Location = New System.Drawing.Point(157, 102)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(284, 22)
        Me.txtUsername.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(95, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 386
        Me.Label4.Text = "Database"
        '
        'txtDatabase
        '
        Me.txtDatabase.AcceptsReturn = True
        Me.txtDatabase.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtDatabase.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDatabase.Location = New System.Drawing.Point(157, 149)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(284, 22)
        Me.txtDatabase.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(58, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 388
        Me.Label6.Text = "Backup Location"
        '
        'txtBackuppLocation
        '
        Me.txtBackuppLocation.AcceptsReturn = True
        Me.txtBackuppLocation.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBackuppLocation.Location = New System.Drawing.Point(157, 173)
        Me.txtBackuppLocation.Name = "txtBackuppLocation"
        Me.txtBackuppLocation.ReadOnly = True
        Me.txtBackuppLocation.Size = New System.Drawing.Size(244, 22)
        Me.txtBackuppLocation.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(79, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 390
        Me.Label7.Text = "Time Backup"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(33, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 392
        Me.Label2.Text = "Database Description"
        '
        'txtDescription
        '
        Me.txtDescription.AcceptsReturn = True
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDescription.Location = New System.Drawing.Point(157, 54)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(284, 22)
        Me.txtDescription.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(403, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 24)
        Me.Button1.TabIndex = 393
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mode
        '
        Me.mode.AcceptsReturn = True
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.Location = New System.Drawing.Point(27, 501)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(77, 22)
        Me.mode.TabIndex = 394
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'id
        '
        Me.id.AcceptsReturn = True
        Me.id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.id.Location = New System.Drawing.Point(27, 476)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(77, 22)
        Me.id.TabIndex = 395
        Me.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.id.Visible = False
        '
        'txtTimeBackup
        '
        Me.txtTimeBackup.AcceptsReturn = True
        Me.txtTimeBackup.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtTimeBackup.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTimeBackup.Location = New System.Drawing.Point(157, 199)
        Me.txtTimeBackup.Name = "txtTimeBackup"
        Me.txtTimeBackup.Size = New System.Drawing.Size(120, 22)
        Me.txtTimeBackup.TabIndex = 396
        Me.txtTimeBackup.Text = "00:00:00"
        '
        'ckMonday
        '
        Me.ckMonday.AutoSize = True
        Me.ckMonday.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckMonday.Location = New System.Drawing.Point(157, 281)
        Me.ckMonday.Name = "ckMonday"
        Me.ckMonday.Size = New System.Drawing.Size(68, 17)
        Me.ckMonday.TabIndex = 397
        Me.ckMonday.Text = "Monday"
        Me.ckMonday.UseVisualStyleBackColor = True
        '
        'ckTuesday
        '
        Me.ckTuesday.AutoSize = True
        Me.ckTuesday.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckTuesday.Location = New System.Drawing.Point(157, 304)
        Me.ckTuesday.Name = "ckTuesday"
        Me.ckTuesday.Size = New System.Drawing.Size(67, 17)
        Me.ckTuesday.TabIndex = 398
        Me.ckTuesday.Text = "Tuesday"
        Me.ckTuesday.UseVisualStyleBackColor = True
        '
        'ckSunday
        '
        Me.ckSunday.AutoSize = True
        Me.ckSunday.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckSunday.Location = New System.Drawing.Point(253, 327)
        Me.ckSunday.Name = "ckSunday"
        Me.ckSunday.Size = New System.Drawing.Size(64, 17)
        Me.ckSunday.TabIndex = 399
        Me.ckSunday.Text = "Sunday"
        Me.ckSunday.UseVisualStyleBackColor = True
        '
        'ckSaturday
        '
        Me.ckSaturday.AutoSize = True
        Me.ckSaturday.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckSaturday.Location = New System.Drawing.Point(253, 304)
        Me.ckSaturday.Name = "ckSaturday"
        Me.ckSaturday.Size = New System.Drawing.Size(71, 17)
        Me.ckSaturday.TabIndex = 400
        Me.ckSaturday.Text = "Saturday"
        Me.ckSaturday.UseVisualStyleBackColor = True
        '
        'ckFriday
        '
        Me.ckFriday.AutoSize = True
        Me.ckFriday.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckFriday.Location = New System.Drawing.Point(253, 281)
        Me.ckFriday.Name = "ckFriday"
        Me.ckFriday.Size = New System.Drawing.Size(57, 17)
        Me.ckFriday.TabIndex = 401
        Me.ckFriday.Text = "Friday"
        Me.ckFriday.UseVisualStyleBackColor = True
        '
        'ckThursday
        '
        Me.ckThursday.AutoSize = True
        Me.ckThursday.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckThursday.Location = New System.Drawing.Point(157, 350)
        Me.ckThursday.Name = "ckThursday"
        Me.ckThursday.Size = New System.Drawing.Size(72, 17)
        Me.ckThursday.TabIndex = 402
        Me.ckThursday.Text = "Thursday"
        Me.ckThursday.UseVisualStyleBackColor = True
        '
        'ckWednesday
        '
        Me.ckWednesday.AutoSize = True
        Me.ckWednesday.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckWednesday.Location = New System.Drawing.Point(157, 327)
        Me.ckWednesday.Name = "ckWednesday"
        Me.ckWednesday.Size = New System.Drawing.Size(86, 17)
        Me.ckWednesday.TabIndex = 403
        Me.ckWednesday.Text = "Wednesday"
        Me.ckWednesday.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(96, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 404
        Me.Label8.Text = "Schedule"
        '
        'ckActived
        '
        Me.ckActived.AutoSize = True
        Me.ckActived.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckActived.Location = New System.Drawing.Point(157, 228)
        Me.ckActived.Name = "ckActived"
        Me.ckActived.Size = New System.Drawing.Size(75, 17)
        Me.ckActived.TabIndex = 405
        Me.ckActived.Text = "Set Active"
        Me.ckActived.UseVisualStyleBackColor = True
        '
        'ckCompress
        '
        Me.ckCompress.AutoSize = True
        Me.ckCompress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckCompress.Location = New System.Drawing.Point(157, 249)
        Me.ckCompress.Name = "ckCompress"
        Me.ckCompress.Size = New System.Drawing.Size(130, 17)
        Me.ckCompress.TabIndex = 406
        Me.ckCompress.Text = "Compress to Zip File"
        Me.ckCompress.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(65, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 407
        Me.Label9.Text = "Backup Option"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(280, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 408
        Me.Label10.Text = "Military Time Format"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(31, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 30)
        Me.Label11.TabIndex = 409
        Me.Label11.Text = "Database Information"
        '
        'frmDatabaseInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(472, 445)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ckCompress)
        Me.Controls.Add(Me.ckActived)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ckWednesday)
        Me.Controls.Add(Me.ckThursday)
        Me.Controls.Add(Me.ckFriday)
        Me.Controls.Add(Me.ckSaturday)
        Me.Controls.Add(Me.ckSunday)
        Me.Controls.Add(Me.ckTuesday)
        Me.Controls.Add(Me.ckMonday)
        Me.Controls.Add(Me.txtTimeBackup)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBackuppLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtServerhost)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDatabaseInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQL Central Backup"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServerhost As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBackuppLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeBackup As System.Windows.Forms.TextBox
    Friend WithEvents ckMonday As System.Windows.Forms.CheckBox
    Friend WithEvents ckTuesday As System.Windows.Forms.CheckBox
    Friend WithEvents ckSunday As System.Windows.Forms.CheckBox
    Friend WithEvents ckSaturday As System.Windows.Forms.CheckBox
    Friend WithEvents ckFriday As System.Windows.Forms.CheckBox
    Friend WithEvents ckThursday As System.Windows.Forms.CheckBox
    Friend WithEvents ckWednesday As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ckActived As System.Windows.Forms.CheckBox
    Friend WithEvents ckCompress As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
