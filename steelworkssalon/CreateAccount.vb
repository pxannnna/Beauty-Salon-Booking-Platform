Imports System.Data.OleDb

' Defines the class responsible for creating new user accounts.
Public Class CreateAccount

    ' Clears the input textboxes for username and password.
    Private Sub cleartextboxes()
        tbx_username.Clear()
        tbx_newpassword1.Clear()
        tbx_newpassword2.Clear()
    End Sub

    ' Database file path and connection string for Access database.
    Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"

    ' Encrypts input data using XOR with a fixed key for simple encryption.
    Public Function EncryptData(data As String) As String
        Dim key As Integer = 200  ' Fixed key for XOR operation.
        Dim encryptedData As String = ""
        For Each c As Char In data
            Dim encryptedChar As Char = Chr(Asc(c) Xor key)
            encryptedData &= encryptedChar
        Next
        Return encryptedData
    End Function

    ' Decrypts data by reusing the EncryptData function, due to XOR's reversible nature.
    Public Function DecryptData(data As String) As String
        Return EncryptData(data)  ' Uses EncryptData for decryption.
    End Function

    ' Event handler for the "Save" button click.
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim username As String = tbx_username.Text
        Dim password1 As String = tbx_newpassword1.Text
        Dim password2 As String = tbx_newpassword2.Text

        ' Validates that all fields are filled.
        If tbx_newpassword1.Text = "" Or tbx_newpassword1.Text = "" Or tbx_username.Text = "" Then
            MsgBox("Please fill out all fields")
            Return
        End If

        ' Ensures that the two entered passwords match.
        If password1 = password2 Then
            ' Ensures password length is more than 4 characters.
            If password1.Length <= 4 Then
                MessageBox.Show("Password must be longer than 4 digits.")
                tbx_newpassword1.Text = ""
                tbx_newpassword2.Text = ""
                Return
            End If

            ' Checks for spaces in the password.
            If password1.Contains(" ") Then
                MessageBox.Show("Password should not contain spaces in it.")
                tbx_newpassword1.Text = ""
                tbx_newpassword2.Text = ""
                Return
            End If

            ' Encrypts the password before storing.
            Dim encryptedpassword As String = EncryptData(password1)
            Using connection As New OleDbConnection(connectionString)
                ' SQL command to insert new user credentials into the database.
                Dim insertSql As String = "INSERT INTO customersdetailstbl ([username], [password]) VALUES (?, ?)"
                Using command As New OleDbCommand(insertSql, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", encryptedpassword)
                    connection.Open()
                    command.ExecuteNonQuery()  ' Executes the insert operation.
                End Using
            End Using

            ' Prompts the user with a confirmation message upon successful account creation.
            Dim result As DialogResult = MessageBox.Show("Account has been created. Go to login?", "Account Created", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Login.Show()  ' Navigates to the login form.
                Me.Hide()  ' Hides the current form.
            End If
            ' Clears the input fields after account creation.
            tbx_username.Clear()
            tbx_newpassword1.Clear()
            tbx_newpassword2.Clear()
        Else
            MessageBox.Show("Passwords do not match. Please re-enter.")
        End If
    End Sub

    ' Event handler for closing the form and returning to the login screen.
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Login.Show()
    End Sub

    ' Adds hover effect to the "Save" button when the form loads.
    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_save)
    End Sub
End Class
