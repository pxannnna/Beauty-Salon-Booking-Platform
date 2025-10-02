Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
'class that allows members of staff to update their personal details
Public Class PersonalDetailsStaff
    'encryption function
    Public Function EncryptData(data As String) As String
        Dim key As Integer = 200
        Dim encryptedData As String = ""

        For Each c As Char In data
            Dim encryptedChar As Char = Chr(Asc(c) Xor key)
            encryptedData &= encryptedChar
        Next

        Return encryptedData
    End Function
    'decryption function
    Public Function DecryptData(data As String) As String
        Return EncryptData(data) ' Since XOR is reversible, using the same function for decryption.
    End Function
    Private Sub PersonalDetailsStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_update)
        ' Set the customer ID and username in their respective textboxes
        tbx_staffid.Text = mystaffid
        tbx_staffid.ReadOnly = True
        tbx_username.Text = myusername
        tbx_username.ReadOnly = True
        tbx_salary.Text = mysalary
        tbx_salary.ReadOnly = True

        Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"

        ' Create a new SqlConnection using the connection string
        Dim conn As New OleDbConnection(connectionString)

        ' Open the connection
        conn.Open()

        ' Define the SQL query using parameters to avoid SQL injection
        Dim strsql As String = "SELECT title, name, surname, telnumber, email FROM staffdetailstbl WHERE staffid = @StaffID"

        ' Create a new SqlCommand with the SQL query and SqlConnection
        Dim cmd As New OleDbCommand(strsql, conn)

        ' Add a parameter to the SqlCommand
        cmd.Parameters.AddWithValue("@StaffID", mystaffid)

        ' Execute the query and retrieve the data
        Dim myreader As OleDbDataReader = cmd.ExecuteReader()

        ' Check if data is available and read it
        If myreader.Read() Then
            ' Display data in the respective textboxes
            cbx_title.Text = myreader("title").ToString()
            tbx_name.Text = myreader("name").ToString()
            tbx_surname.Text = myreader("surname").ToString()
            tbx_tel.Text = DecryptData(myreader("telnumber").ToString())
            tbx_email.Text = DecryptData(myreader("email").ToString())

        End If

        ' Close the reader and connection
        myreader.Close()
        conn.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"
        If String.IsNullOrWhiteSpace(tbx_name.Text) OrElse
       String.IsNullOrWhiteSpace(tbx_surname.Text) OrElse
       String.IsNullOrWhiteSpace(tbx_tel.Text) OrElse
       String.IsNullOrWhiteSpace(tbx_email.Text) Then

            MsgBox("Please ensure all fields are filled correctly and email is valid.")
            Return
        End If
        If Not tbx_email.Text.Contains("@") Then
            MessageBox.Show("Email is invalid. Please enter a valid email.")
        End If
        If Not tbx_tel.Text.StartsWith("0") Then
            MessageBox.Show("Make sure that phone number is entered correctly.")
            Return
        End If
        If tbx_tel.Text.Length <> 11 Then
            MessageBox.Show("Phone Number has to be 11 digits long.")
            Return
        End If

        Using conn As New OleDbConnection(connectionString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query for updating details
            Dim updateSql As String = "UPDATE staffdetailstbl SET title=@Title, name=@Name, surname=@Surname, telnumber=@Telnumber, email=@Email WHERE staffid=@StaffID"

            ' Create a new SqlCommand with the SQL query and SqlConnection
            Using cmdUpdate As New OleDbCommand(updateSql, conn)

                Dim encryptedtel As String = EncryptData(tbx_tel.Text)
                Dim encryptedemail As String = EncryptData(tbx_email.Text)
                cmdUpdate.Parameters.AddWithValue("@Title", cbx_title.Text)
                cmdUpdate.Parameters.AddWithValue("@Name", tbx_name.Text)
                cmdUpdate.Parameters.AddWithValue("@Surname", tbx_surname.Text)
                cmdUpdate.Parameters.AddWithValue("@Telnumber", encryptedtel)
                cmdUpdate.Parameters.AddWithValue("@Email", encryptedemail)
                cmdUpdate.Parameters.AddWithValue("@StaffID", mystaffid)


                ' Execute the update query
                Dim rowsAffected As Integer = cmdUpdate.ExecuteNonQuery()

                ' Check if the update was successful
                If rowsAffected > 0 Then
                    MsgBox("Details updated successfully!")
                Else
                    MsgBox("Failed to update details.")
                End If
            End Using
        End Using
    End Sub
    'Exit button closes the form and takes the user back to the main menu

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        mainmenustaff.Visible = True

    End Sub
End Class