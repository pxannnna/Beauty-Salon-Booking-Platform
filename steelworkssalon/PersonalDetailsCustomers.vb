Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand
'class to update personal details of the customer
Public Class PersonalDetailsCustomers
    'encrypting function
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
    Private Sub PersonalDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_update)
        ' Set the customer ID and username in their respective textboxes
        tbx_customerid.Text = mycustomerid
        tbx_customerid.ReadOnly = True
        tbx_username.Text = myusername
        tbx_customerid.ReadOnly = True

        Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"

        ' Create a new SqlConnection using the connection string
        Using conn As New OleDbConnection(connectionString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query using parameters to avoid SQL injection
            Dim strsql As String = "SELECT Title, Name, Surname, TelNumber, Email, Age, Allergies, Additionalinfo FROM customersdetailstbl WHERE Customerid = @CustomerID"

            ' Create a new SqlCommand with the SQL query and SqlConnection
            Dim cmd As New OleDbCommand(strsql, conn)

            ' Add a parameter to the SqlCommand
            cmd.Parameters.AddWithValue("@CustomerID", mycustomerid)

            ' Execute the query and retrieve the data
            Dim myreader As OleDbDataReader = cmd.ExecuteReader()

            ' Check if data is available and read it
            If myreader.Read() Then
                ' Display data in the respective textboxes
                cbx_title.Text = myreader("Title").ToString()
                tbx_name.Text = myreader("Name").ToString()
                tbx_surname.Text = myreader("Surname").ToString()
                tbx_tel.Text = myreader("Telnumber").ToString()
                tbx_email.Text = myreader("Email").ToString()
                tbx_age.Text = myreader("Age").ToString()
                tbx_allergies.Text = myreader("Allergies").ToString()
                tbx_addinfo.Text = myreader("Additionalinfo").ToString()
            End If
            tbx_tel.Text = DecryptData(tbx_tel.Text)
            tbx_email.Text = DecryptData(tbx_email.Text)
            ' Close the reader and connection
            myreader.Close()
        End Using
    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        ' Define the connection string
        Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"


        ' Validate fields before updating
        If String.IsNullOrWhiteSpace(cbx_title.Text) Then
            MessageBox.Show("Please enter your title.")
            Return
        End If

        If String.IsNullOrWhiteSpace(tbx_name.Text) Then
            MessageBox.Show("Please enter your name.")
            Return
        End If

        If String.IsNullOrWhiteSpace(tbx_surname.Text) Then
            MessageBox.Show("Please enter your surname.")
            Return
        End If

        If Not tbx_tel.Text.StartsWith("0") Then
            MessageBox.Show("Make sure that phone number is entered correctly.")
            Return
        End If
        If tbx_tel.Text.Length <> 11 Then
            MessageBox.Show("Phone Number has to be 11 digits long.")
            Return
        End If

        If String.IsNullOrWhiteSpace(tbx_email.Text) Then
            MessageBox.Show("Please enter your email.")
            Return
        End If
        If Not tbx_email.Text.Contains("@") Then
            MessageBox.Show("Email is invalid. Please enter a valid email.")
            Return
        End If

        Dim age As Integer
        If Not Integer.TryParse(tbx_age.Text, age) OrElse age < 0 OrElse age > 110 Then
            MessageBox.Show("Enter a valid age")
            Return
        End If

        ' Create a new SqlConnection using the connection string
        Using conn As New OleDbConnection(connectionString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query for updating details
            Dim updateSql As String = "UPDATE customersdetailstbl SET title=@Title, name=@Name, surname=@Surname, telnumber=@TelNumber, email=@Email, age=@Age, allergies=@Allergies, additionalinfo=@AdditionalInfo WHERE customerid=@CustomerID"

            ' Create a new SqlCommand with the SQL query and SqlConnection
            Using cmdUpdate As New OleDbCommand(updateSql, conn)
                ' Add parameters to the SqlCommand
                Dim encryptedtel As String = EncryptData(tbx_tel.Text)
                Dim encryptedemail As String = EncryptData(tbx_email.Text)
                cmdUpdate.Parameters.AddWithValue("@Title", cbx_title.Text)
                cmdUpdate.Parameters.AddWithValue("@Name", tbx_name.Text)
                cmdUpdate.Parameters.AddWithValue("@Surname", tbx_surname.Text)
                cmdUpdate.Parameters.AddWithValue("@TelNumber", encryptedtel)
                cmdUpdate.Parameters.AddWithValue("@Email", encryptedemail)
                cmdUpdate.Parameters.AddWithValue("@Age", tbx_age.Text)
                cmdUpdate.Parameters.AddWithValue("@Allergies", tbx_allergies.Text)
                cmdUpdate.Parameters.AddWithValue("@AdditionalInfo", tbx_addinfo.Text)
                cmdUpdate.Parameters.AddWithValue("@CustomerID", mycustomerid)

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
        Me.Visible = False
        mainmenucustomer.Visible = True


    End Sub

End Class
