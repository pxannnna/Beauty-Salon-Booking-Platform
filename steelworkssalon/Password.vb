Imports System.IO
Imports System.Security.Principal
Imports System.Data.OleDb

' Defines a form class for handling password operations.
Public Class Password

    ' Clears the text fields on the form.
    Private Sub cleartextboxes()
        txt_username.Clear()
        txt_newpassword1.Clear()
        txt_newpassword2.Clear()
    End Sub

    ' Defines the database file path and connection string.
    Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"

    ' Encrypts the provided data string using XOR encryption with a fixed key.
    Public Function EncryptData(data As String) As String
        Dim key As Integer = 200
        Dim encryptedData As String = ""
        For Each c As Char In data
            Dim encryptedChar As Char = Chr(Asc(c) Xor key)
            encryptedData &= encryptedChar
        Next
        Return encryptedData
    End Function

    ' Decrypts the provided data string. Uses the same function as encryption due to the reversible nature of XOR.
    Public Function DecryptData(data As String) As String
        Return EncryptData(data) ' Utilizes the encryption method for decryption.
    End Function

    ' Handles the event when the 'Save Password' button is clicked.
    Private Sub btn_savepassword_Click(sender As Object, e As EventArgs) Handles btn_savepassword.Click
        Dim username As String = txt_username.Text
        Dim password1 As String = txt_newpassword1.Text
        Dim password2 As String = txt_newpassword2.Text

        ' Validates that all required fields are filled.
        If txt_newpassword1.Text = "" Or txt_newpassword1.Text = "" Or txt_username.Text = "" Then
            MsgBox("Please fill out all fields")
            Return
        End If

        ' Ensures that both entered passwords match.
        If password1 = password2 Then
            ' Validates password length.
            If password1.Length <= 4 Then
                MessageBox.Show("Password must be longer than 4 digits.")
                txt_newpassword1.Clear()
                txt_newpassword2.Clear()
                Return
            End If

            ' Checks for spaces in the password.
            If password1.Contains(" ") Then
                MessageBox.Show("Password should not contain spaces in it.")
                txt_newpassword1.Clear()
                txt_newpassword2.Clear()
                Return
            End If

            ' Defines SQL queries for checking existence and updating passwords in the database.
            Dim query As String = "SELECT COUNT(*) FROM CustomersDetailsTbl WHERE Username = @Username"
            Dim query2 As String = "SELECT COUNT(*) FROM StaffDetailsTbl WHERE Username = @Username"
            Dim updateQuery As String = "UPDATE CustomersDetailsTbl SET [Password] = @Password WHERE Username = @Username"
            Dim updateQuery2 As String = "UPDATE StaffDetailsTbl SET [Password] = @Password WHERE Username = @Username"

            Using connection As New OleDbConnection(connectionString)
                ' Checks if the username exists in CustomersDetailsTbl.
                Using cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Username", username)
                    connection.Open()
                    Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If userCount > 0 Then
                        ' If username exists, updates the password.
                        Using updateCmd As New OleDbCommand(updateQuery, connection)
                            Dim encryptedpassword As String = EncryptData(password1)
                            updateCmd.Parameters.AddWithValue("@Password", encryptedpassword)
                            updateCmd.Parameters.AddWithValue("@Username", username)
                            updateCmd.ExecuteNonQuery()
                            MessageBox.Show("Password updated successfully!")
                            cleartextboxes()
                            Return
                        End Using
                    End If
                    connection.Close()
                End Using

                ' Repeats the process for StaffDetailsTbl if the username was not found in CustomersDetailsTbl.
                Using cmd As New OleDbCommand(query2, connection)
                    cmd.Parameters.AddWithValue("@Username", username)
                    connection.Open()
                    Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If userCount > 0 Then
                        Using updateCmd As New OleDbCommand(updateQuery2, connection)
                            Dim encryptedpassword As String = EncryptData(password1)
                            updateCmd.Parameters.AddWithValue("@Password", encryptedpassword)
                            updateCmd.Parameters.AddWithValue("@Username", username)
                            updateCmd.ExecuteNonQuery()
                            MessageBox.Show("Password updated successfully!")
                            cleartextboxes()
                        End Using
                    Else
                        MessageBox.Show("Username does not exist. Please try again.")
                    End If
                    connection.Close()
                End Using
            End Using
            ' Clears the text fields after operation.
            txt_username.Clear()
            txt_newpassword1.Clear()
            txt_newpassword2.Clear()
        Else
            MessageBox.Show("Passwords do not match. Please re-enter.")
        End If
    End Sub

    ' Closes the password form and shows the login form.
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Login.Visible = True
    End Sub

    ' Adds hover effects to the 'Save Password' button upon form load.
    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_savepassword)
    End Sub
End Class
