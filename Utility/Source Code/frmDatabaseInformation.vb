Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmDatabaseInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtDescription.Text = "" Then
            MessageBox.Show("Please enter database description!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        ElseIf txtServerhost.Text = "" Then
            MessageBox.Show("Please enter server host!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtServerhost.Focus()
            Exit Sub
        ElseIf txtPort.Text = "" Then
            MessageBox.Show("Please enter server port number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPort.Focus()
            Exit Sub
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("Please enter server username!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter server password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPassword.Focus()
            Exit Sub
        ElseIf txtDatabase.Text = "" Then
            MessageBox.Show("Please enter server database name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDatabase.Focus()
            Exit Sub
        ElseIf txtBackuppLocation.Text = "" Then
            MessageBox.Show("Please enter select backup location!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDatabase.Focus()
            Exit Sub
        End If
       
        Try
            If OpenClientServer(txtServerhost.Text, txtPort.Text, txtUsername.Text, txtPassword.Text, txtDatabase.Text) = True Then
                If mode.Text = "edit" Then
                    com.CommandText = "UPDATE tbldatabases set description='" & txtDescription.Text & "',host='" & txtServerhost.Text & "',port='" & txtPort.Text & "',[username]='" & txtUsername.Text & "',[password]='" & EncryptTripleDES(txtPassword.Text) & "',dbname='" & txtDatabase.Text & "',backuplocation='" & txtBackuppLocation.Text & "',timebackup='" & txtTimeBackup.Text & "',actived=" & ckActived.CheckState & ",compress=" & ckCompress.CheckState & ", monday=" & ckMonday.CheckState & ",tuesday=" & ckTuesday.CheckState & ",wednesday=" & ckWednesday.CheckState & ",thursday=" & ckThursday.CheckState & ",friday=" & ckFriday.CheckState & ",saturday=" & ckSaturday.CheckState & ",sunday=" & ckSunday.CheckState & " where id=" & id.Text & "" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "insert into tbldatabases (description,host,port,[username],[password],dbname,backuplocation,timebackup,actived,compress,monday,tuesday,wednesday,thursday,friday,saturday,sunday) values('" & txtDescription.Text & "','" & txtServerhost.Text & "','" & txtPort.Text & "','" & txtUsername.Text & "','" & EncryptTripleDES(txtPassword.Text) & "','" & txtDatabase.Text & "', '" & txtBackuppLocation.Text & "','" & txtTimeBackup.Text & "'," & ckActived.CheckState & "," & ckCompress.CheckState & "," & ckMonday.CheckState & "," & ckTuesday.CheckState & "," & ckWednesday.CheckState & "," & ckThursday.CheckState & "," & ckFriday.CheckState & "," & ckSaturday.CheckState & "," & ckSunday.CheckState & ")" : com.ExecuteNonQuery()
                End If
                frmMysqlCentralBackup.ShowDatabaseList() : mode.Text = "" : id.Text = ""
                MsgBox("Database successfully saved!", vbInformation)
                Me.Close()
            Else

            End If


        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub


    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mode.Text = "edit" Then
            ShowInformation()
        End If
    End Sub

    Public Sub ShowInformation()
        com.CommandText = "select * from tbldatabases where id=" & id.Text & "" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            txtServerhost.Text = rst("host").ToString
            txtPort.Text = rst("port").ToString
            txtUsername.Text = rst("username").ToString
            txtPassword.Text = DecryptTripleDES(rst("password").ToString)
            txtDatabase.Text = rst("dbname").ToString
            txtBackuppLocation.Text = rst("backuplocation").ToString
            txtTimeBackup.Text = rst("timebackup").ToString
            ckActived.Checked = rst("actived")
            ckCompress.Checked = rst("compress")
            ckMonday.Checked = rst("monday")
            ckTuesday.Checked = rst("tuesday")
            ckWednesday.Checked = rst("wednesday")
            ckThursday.Checked = rst("thursday")
            ckFriday.Checked = rst("friday")
            ckSaturday.Checked = rst("saturday")
            ckSunday.Checked = rst("sunday")
        End While
        rst.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                txtBackuppLocation.Text = f.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
End Class