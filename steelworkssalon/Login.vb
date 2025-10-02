Imports System.Data.OleDb

Public Class Login
    ' Path to the Access database file
    Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
    ' Connection string for the Access database
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"

    ' Validates user login credentials
    Private Sub ValidateLogin(username As String, password As String)
        Using con As New OleDbConnection(connectionString)
            con.Open()

            ' Query to check existence of username in CustomersDetailsTbl
            Dim query As String = "SELECT COUNT(*) FROM CustomersDetailsTbl WHERE username = @Username"
            Using cmdCheckCustomersUsername As New OleDbCommand(query, con)
                cmdCheckCustomersUsername.Parameters.AddWithValue("@Username", username)
                Dim userCount As Integer = Convert.ToInt32(cmdCheckCustomersUsername.ExecuteScalar())

                ' Query to check existence of username in StaffDetailsTbl
                Dim query2 As String = "SELECT COUNT(*) FROM StaffDetailsTbl WHERE username = @Username"
                Using cmdCheckStaffUsername As New OleDbCommand(query2, con)
                    cmdCheckStaffUsername.Parameters.AddWithValue("@Username", username)
                    Dim userStaffCount As Integer = Convert.ToInt32(cmdCheckStaffUsername.ExecuteScalar())

                    ' Validates customer's password if username found in CustomersDetailsTbl
                    If userCount > 0 Then
                        query = "SELECT Password FROM CustomersDetailsTbl WHERE username = @Username"
                        Using cmdCheckPassword As New OleDbCommand(query, con)
                            cmdCheckPassword.Parameters.AddWithValue("@Username", username)
                            Dim storedPassword As String = Convert.ToString(cmdCheckPassword.ExecuteScalar())

                            If password.Equals(storedPassword) Then 'makes the password check casesensative
                                myusername = username
                                mysecurity = "1"
                                query = "SELECT CustomerID FROM CustomersDetailsTbl WHERE username = @Username"
                                Using cmdfindcustomerid As New OleDbCommand(query, con)
                                    cmdfindcustomerid.Parameters.AddWithValue("@Username", username)
                                    mycustomerid = Convert.ToString(cmdfindcustomerid.ExecuteScalar())
                                End Using
                                Me.Visible = False
                                mainmenucustomer.Visible = True
                                MsgBox("Login successful!")
                            Else
                                MsgBox("Invalid password.")
                            End If
                        End Using
                    ElseIf userStaffCount > 0 Then
                        ' Validates staff's password if username found in StaffDetailsTbl
                        query2 = "SELECT Password FROM StaffDetailsTbl WHERE username = @Username"
                        Using cmdCheckPassword As New OleDbCommand(query2, con)
                            cmdCheckPassword.Parameters.AddWithValue("@Username", username)
                            Dim storedPassword As String = Convert.ToString(cmdCheckPassword.ExecuteScalar())

                            If password.Equals(storedPassword) Then 'makes the password check casesensative
                                myusername = username
                                ' Retrieve and set the user's access level
                                query2 = "SELECT AccessLevel FROM StaffDetailsTbl WHERE username = @Username"
                                Using cmdfindaccesslevel As New OleDbCommand(query2, con)
                                    cmdfindaccesslevel.Parameters.AddWithValue("@Username", username)
                                    mysecurity = Convert.ToString(cmdfindaccesslevel.ExecuteScalar())
                                End Using
                                ' Retrieve and set the user's staff ID
                                query2 = "SELECT StaffID FROM StaffDetailsTbl WHERE username = @Username"
                                Using cmdfindstaffid As New OleDbCommand(query2, con)
                                    cmdfindstaffid.Parameters.AddWithValue("@Username", username)
                                    mystaffid = Convert.ToString(cmdfindstaffid.ExecuteScalar())
                                End Using
                                ' Retrieve and set the user's salary
                                query2 = "SELECT Salary FROM StaffDetailsTbl WHERE username = @Username"
                                Using cmdfindsalary As New OleDbCommand(query2, con)
                                    cmdfindsalary.Parameters.AddWithValue("@Username", username)
                                    mysalary = Convert.ToString(cmdfindsalary.ExecuteScalar())
                                End Using

                                ' Redirect user based on access level
                                Me.Visible = False
                                If mysecurity = "2" Then
                                    mainmenustaff.Visible = True
                                ElseIf mysecurity = "3" Then
                                    Mainmenuadmin.Visible = True
                                End If
                                MsgBox("Login successful!")
                            Else
                                MsgBox("Invalid password.")
                            End If
                        End Using
                    Else
                        MsgBox("Username not found.")
                    End If
                End Using
            End Using

        End Using
    End Sub

    ' Encrypts data using XOR with a key
    Public Function EncryptData(data As String) As String
        Dim key As Integer = 200
        Dim encryptedData As String = ""

        For Each c As Char In data
            Dim encryptedChar As Char = Chr(Asc(c) Xor key)
            encryptedData &= encryptedChar
        Next

        Return encryptedData
    End Function

    ' Decrypts data (identical to EncryptData due to XOR's reversible nature)
    Public Function DecryptData(data As String) As String
        Return EncryptData(data)
    End Function

    ' Shows the password recovery form and hides the login form
    Private Sub btn_forgotpassword_Click(sender As Object, e As EventArgs) Handles btn_forgotpassword.Click
        Me.Visible = False
        Password.Visible = True
    End Sub

    ' Attempts to log in with the provided credentials
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim enteredUsername As String = txt_username.Text
        Dim enteredPassword As String = EncryptData(txt_password.Text)
        ValidateLogin(enteredUsername, enteredPassword)
        txt_password.Clear()
        txt_username.Clear()
    End Sub

    ' Closes the application
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    ' Navigates to the account creation form
    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        Me.Hide()
        CreateAccount.Show()
    End Sub

    ' Adds hover effects to buttons on form load
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_login)
        ButtonResizer.AttachButtonHoverEffect(btn_forgotpassword)
    End Sub
End Class
