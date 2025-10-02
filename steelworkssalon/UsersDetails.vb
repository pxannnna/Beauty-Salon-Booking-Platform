Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Linq.Expressions
' This class manages user details within the system, enabling administrators to add, search, edit, and delete user records.
' It facilitates interaction with both customers and staff databases.
Public Class UsersDetails

    'establishing connection with the database
    Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"
    Dim con As New OleDbConnection(connectionString)
    ' Variables to track the current row index for navigation buttons.
    Dim rowindex As Integer = 0
    Dim rowindex2 As Integer = 0
    ' On form load, attach hover effects to buttons and populate data grids with customer and staff details.
    Private Sub UsersDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_addnew)
        ButtonResizer.AttachButtonHoverEffect(btn_add2)
        ButtonResizer.AttachButtonHoverEffect(btn_save)
        ButtonResizer.AttachButtonHoverEffect(btn_save2)
        ButtonResizer.AttachButtonHoverEffect(btn_saveedit)
        ButtonResizer.AttachButtonHoverEffect(btn_edit2)
        ButtonResizer.AttachButtonHoverEffect(btn_delete)
        ButtonResizer.AttachButtonHoverEffect(btn_delete2)
        ButtonResizer.AttachButtonHoverEffect(btn_search)
        ButtonResizer.AttachButtonHoverEffect(btn_search2)

        ButtonResizer.AttachButtonHoverEffect(btn_next)
        ButtonResizer.AttachButtonHoverEffect(btn_next2)
        ButtonResizer.AttachButtonHoverEffect(btn_prev)
        ButtonResizer.AttachButtonHoverEffect(btn_prev2)
        ButtonResizer.AttachButtonHoverEffect(btn_last)
        ButtonResizer.AttachButtonHoverEffect(btn_last2)
        ButtonResizer.AttachButtonHoverEffect(btn_first)
        ButtonResizer.AttachButtonHoverEffect(btn_first2)
        ' Attach event handlers
        AddHandler btn_search.MouseEnter, AddressOf btn_search_MouseEnter
        AddHandler btn_search.MouseLeave, AddressOf btn_search_MouseLeave
        AddHandler btn_search2.MouseEnter, AddressOf btn_search2_MouseEnter
        AddHandler btn_search2.MouseLeave, AddressOf btn_search2_MouseLeave
        lbl_2.Visible = False
        lbl_1.Visible = False
        ' Populating data grids with encrypted data.
        populate()
        populate2()
        ' Making certain text boxes read-only to prevent direct ID manipulation.
        tbx_customerid.ReadOnly = True
        tbx_staffid.ReadOnly = True

    End Sub
    ' Encryption and decryption functions using XOR for telephone numbers and emails.
    Public Function EncryptData(data As String) As String
        Dim key As Integer = 200
        Dim encryptedData As String = ""

        For Each c As Char In data
            Dim encryptedChar As Char = Chr(Asc(c) Xor key)
            encryptedData &= encryptedChar
        Next

        Return encryptedData
    End Function

    Public Function DecryptData(data As String) As String
        Return EncryptData(data) ' Since XOR is reversible, using the same function for decryption.
    End Function
    ' Populates the customer details data grid and decrypts sensitive data for display.

    Private Sub populate()
        ' Retrieves and decrypts customer details.
        ' Retrieves customers' details in alphabetical order to make searching through the populated datagrid easier
        con.Open()
        Dim sql = "SELECT * FROM CustomersDetailsTbl"
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, con)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
        Dim ds As DataSet = New DataSet
        adapter.Fill(ds)

        ' Decrypt TelNumber and Email
        For Each row As DataRow In ds.Tables(0).Rows
            row("TelNumber") = DecryptData(row("TelNumber").ToString())
            row("Email") = DecryptData(row("Email").ToString())
        Next

        ' Bubble sort the data by CustomerID
        BubbleSort(ds.Tables(0))

        ' Populate the datagrid with the sorted list of items
        dgv_customers.DataSource = ds.Tables(0)
        dgv_customers.Columns("Password").Visible = False
        con.Close()
    End Sub
    Private Sub populate2()
        ' Retrieves and decrypts staff details.
        'Retrieves staff details in alphabetical order to make searching through the populated datagrid easier
        con.Open()
        Dim sql = "SELECT * FROM StaffDetailsTbl"
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, con)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
        Dim ds As DataSet = New DataSet
        adapter.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows
            row("TelNumber") = DecryptData(row("TelNumber").ToString())
            row("Email") = DecryptData(row("Email").ToString())
        Next
        InsertionSort(ds.Tables(0))
        dgv_staff.DataSource = ds.Tables(0)
        dgv_staff.Columns("Password").Visible = False
        con.Close()
    End Sub
    'function that sorts all the records stored in the table by the CustomerID in descending order
    'I use this function to sort all the records before populating the datagrid
    Private Sub BubbleSort(table As DataTable)
        Dim numRows As Integer = table.Rows.Count
        Dim swapped As Boolean
        Do
            swapped = False
            For i As Integer = 1 To numRows - 1
                If Integer.Parse(table.Rows(i)("CustomerID")) > Integer.Parse(table.Rows(i - 1)("CustomerID")) Then
                    ' Swap rows
                    Dim tempRow As DataRow = table.NewRow()
                    tempRow.ItemArray = table.Rows(i).ItemArray
                    table.Rows(i).ItemArray = table.Rows(i - 1).ItemArray
                    table.Rows(i - 1).ItemArray = tempRow.ItemArray
                    swapped = True
                End If
            Next
        Loop While swapped
    End Sub

    'Function that sorts all the records stored in the table by the staffid in descending order
    'I use this function to sort all the records before populating the datagrid
    Private Sub InsertionSort(table As DataTable)
        Dim numRows As Integer = table.Rows.Count

        For i As Integer = 1 To numRows - 1
            Dim currentRow As DataRow = table.Rows(i)
            Dim j As Integer = i - 1

            While j >= 0 AndAlso Integer.Parse(table.Rows(j)("StaffID")) < Integer.Parse(currentRow("StaffID"))
                table.Rows(j + 1).ItemArray = table.Rows(j).ItemArray
                j -= 1
            End While

            table.Rows(j + 1).ItemArray = currentRow.ItemArray
        Next
    End Sub

    ' Event handler for MouseEnter event on btn_search
    Private Sub btn_search_MouseEnter(sender As Object, e As EventArgs)
        lbl_1.Visible = True ' Make lbl_1 visible when the mouse enters btn_search
    End Sub

    ' Event handler for MouseLeave event on btn_search
    Private Sub btn_search_MouseLeave(sender As Object, e As EventArgs)
        lbl_1.Visible = False ' Make lbl_1 invisible again when the mouse leaves btn_search
    End Sub
    ' Event handler for MouseEnter event on btn_search2
    Private Sub btn_search2_MouseEnter(sender As Object, e As EventArgs)
        lbl_2.Visible = True ' Make lbl_2 visible when the mouse enters btn_search2
    End Sub

    ' Event handler for MouseLeave event on btn_search2
    Private Sub btn_search2_MouseLeave(sender As Object, e As EventArgs)
        lbl_2.Visible = False ' Make lbl_2 invisible again when the mouse leaves btn_search2
    End Sub
    ' Validates customer details input fields before saving to database.

    Private Function validatecustomersdetails() As Boolean
        ' Initialize a flag to indicate validation success
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(tbx_username.Text) Then
            MessageBox.Show("Please enter customers username.")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(cbx_title.Text) Then
            MessageBox.Show("Please enter customers title.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(tbx_name.Text) Then
            MessageBox.Show("Please enter your name.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(tbx_surname.Text) Then
            MessageBox.Show("Please enter your surname.")
            isValid = False
        End If

        If Not tbx_tel.Text.StartsWith("0") OrElse tbx_tel.Text.Length <> 11 Then
            MessageBox.Show("Make sure that phone number is entered correctly and is 11 digits long.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(tbx_email.Text) OrElse Not tbx_email.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid email.")
            isValid = False
        End If


        Dim age As Integer
        If Not Integer.TryParse(tbx_age.Text, age) OrElse age < 0 OrElse age > 110 Then
            MessageBox.Show("Enter a valid age")
            isValid = False
        End If

        Return isValid
    End Function
    ' Similar to validatecustomersdetails(), but for validating staff details inputs.

    Private Function validatestaffdetails() As Boolean
        ' Initialize a flag to indicate validation success
        Dim isValid As Boolean = True
        If String.IsNullOrWhiteSpace(tbx_username2.Text) Then
            MessageBox.Show("Please enter customers username.")
            isValid = False
        End If
        ' Validate fields before updating
        If String.IsNullOrWhiteSpace(cbx_title2.Text) Then
            MessageBox.Show("Please enter customers title.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(tbx_name2.Text) Then
            MessageBox.Show("Please enter your name.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(tbx_surname2.Text) Then
            MessageBox.Show("Please enter your surname.")
            isValid = False
        End If

        If Not tbx_tel2.Text.StartsWith("0") OrElse tbx_tel2.Text.Length <> 11 Then
            MessageBox.Show("Make sure that phone number is entered correctly and is 11 digits long.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(tbx_email2.Text) OrElse Not tbx_email.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid email.")
            isValid = False
        End If

        Dim salary As Integer
        If Not Integer.TryParse(tbx_salary.Text, salary) OrElse salary < 0 OrElse salary > 200000 Then
            MessageBox.Show("Enter a valid salary")
            isValid = False
        End If

        Return isValid
    End Function
    ' Saves new customer details to the database after validation.

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        ' Call validatecustomersdetails and proceed only if validation passes
        If Not validatecustomersdetails() Then
            Return ' Stop execution if validation fails
        End If

        Dim encryptedTel As String = EncryptData(tbx_tel.Text)
        Dim encryptedEmail As String = EncryptData(tbx_email.Text)
        Dim encryptedpassword As String = EncryptData("0")
        Dim databasecon As New DatabaseCon
        'using addrecord function from the databasecon module
        databasecon.AddRecord("SELECT * FROM customersdetailstbl", "CustomersDetailsTbl", "CustomerID",
                              tbx_username.Text, cbx_title.SelectedItem.ToString(), tbx_name.Text, tbx_surname.Text, encryptedTel,
                              encryptedEmail, tbx_age.Text, tbx_allergies.Text, tbx_addinfo.Text, encryptedpassword, "1")
        MsgBox("Customer Added")

        populate()
    End Sub
    ' Deletes a selected customer record from the database.

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If tbx_customerid.Text <> "" Then
            If MessageBox.Show("Do you want to delete this user?", "Confirmation", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                ' Check if the bookingid is set

                ' Create a new OleDbConnection using the connection string
                Using conn As New OleDbConnection(connectionString)
                    ' Open the connection
                    conn.Open()

                    ' Define the SQL query for deleting the record
                    Dim deleteSql As String = "DELETE FROM customersdetailstbl WHERE [customerid]=@customerid"

                    ' Create a new OleDbCommand with the SQL query and OleDbConnection
                    Using cmdDelete As New OleDbCommand(deleteSql, conn)
                        ' Add parameter to the OleDbCommand
                        cmdDelete.Parameters.AddWithValue("@Customerid", tbx_customerid.Text)

                        ' Execute the delete query
                        Dim rowsAffected As Integer = cmdDelete.ExecuteNonQuery()

                        ' Check if the delete was successful
                        If rowsAffected > 0 Then
                            MsgBox("User has been deleted")
                        Else
                            MsgBox("Couldn't delete the user")
                        End If
                    End Using
                End Using
            End If
            populate()
        Else
            MsgBox("Please select a user to be deleted")
        End If

    End Sub
    ' Clears input fields to allow entry of new customer details.

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        tbx_username.Clear()
        tbx_name.Clear()
        cbx_title.Text = ""
        tbx_surname.Clear()
        tbx_tel.Clear()
        tbx_email.Clear()
        tbx_allergies.Clear()
        tbx_addinfo.Clear()
        tbx_age.Clear()
        tbx_customerid.Clear()

    End Sub
    ' Saves new staff details to the database after validation.

    Private Sub btn_save2_Click(sender As Object, e As EventArgs) Handles btn_save2.Click

        If Not validatestaffdetails() Then
            Return ' Stop execution if validation fails
        End If
        Dim encryptedTel As String = EncryptData(tbx_tel2.Text)
        Dim encryptedEmail As String = EncryptData(tbx_email2.Text)
        Dim encryptedpassword As String = EncryptData("0")
        Dim databasecon As New DatabaseCon
        databasecon.AddRecord("SELECT * FROM staffdetailstbl", "StaffDetailsTbl", "StaffID", tbx_username2.Text, cbx_title2.SelectedItem.ToString(), tbx_name2.Text, tbx_surname2.Text, encryptedTel, encryptedEmail, tbx_salary.Text, encryptedpassword, "2")
        MsgBox("Member of Staff Added")

        populate2()
    End Sub
    ' Returns to the main admin menu.

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Mainmenuadmin.Visible = True
    End Sub
    ' Clears input fields for entering new staff details.

    Private Sub btn_add2_Click(sender As Object, e As EventArgs) Handles btn_add2.Click
        tbx_username2.Clear()
        tbx_name2.Clear()
        cbx_title2.Text = ""
        tbx_surname2.Clear()
        tbx_tel2.Clear()
        tbx_email2.Clear()
        tbx_salary.Clear()
        tbx_staffid.Clear()
    End Sub
    ' Navigation functions for browsing through customer and staff records.
    ' These functions update the UI with the corresponding record details.
    Private Sub FirstCustomer()
        rowindex = 0
        UpdateCustomerDetails(rowindex)
        dgv_customers.ClearSelection()
        dgv_customers.Rows(rowindex).Selected = True
    End Sub

    Private Sub LastCustomer()
        rowindex = dgv_customers.Rows.Count - 2
        UpdateCustomerDetails(rowindex)
        dgv_customers.ClearSelection()
        dgv_customers.Rows(rowindex).Selected = True
    End Sub

    Private Sub PreviousCustomer()
        If rowindex > 0 Then
            rowindex -= 1
            UpdateCustomerDetails(rowindex)
            dgv_customers.ClearSelection()
            dgv_customers.Rows(rowindex).Selected = True
        Else
            MsgBox("You are already looking at the FIRST record")
        End If
    End Sub

    Private Sub NextCustomer()
        If rowindex < dgv_customers.Rows.Count - 2 Then
            rowindex += 1
            UpdateCustomerDetails(rowindex)
            dgv_customers.ClearSelection()
            dgv_customers.Rows(rowindex).Selected = True
        Else
            MsgBox("You are already looking at the LAST record")
        End If
    End Sub

    Private Sub UpdateCustomerDetails(ByVal rowIndex As Integer)

        If dgv_customers.Rows.Count > rowIndex Then

            tbx_customerid.Text = dgv_customers.Rows(rowIndex).Cells("CustomerID").Value.ToString()
            tbx_username.Text = dgv_customers.Rows(rowIndex).Cells("Username").Value.ToString()
            cbx_title.Text = dgv_customers.Rows(rowIndex).Cells("Title").Value.ToString()
            tbx_name.Text = dgv_customers.Rows(rowIndex).Cells("Name").Value.ToString()
            tbx_surname.Text = dgv_customers.Rows(rowIndex).Cells("Surname").Value.ToString()
            tbx_tel.Text = (dgv_customers.Rows(rowIndex).Cells("TelNumber").Value.ToString())
            tbx_email.Text = (dgv_customers.Rows(rowIndex).Cells("Email").Value.ToString())
            tbx_age.Text = dgv_customers.Rows(rowIndex).Cells("Age").Value.ToString()
            tbx_allergies.Text = dgv_customers.Rows(rowIndex).Cells("Allergies").Value.ToString()
            tbx_addinfo.Text = dgv_customers.Rows(rowIndex).Cells("AdditionalInfo").Value.ToString()
        End If
    End Sub

    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click
        FirstCustomer()
    End Sub

    Private Sub btn_last_Click(sender As Object, e As EventArgs) Handles btn_last.Click
        LastCustomer()
    End Sub

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        PreviousCustomer()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        NextCustomer()
    End Sub

    Private Sub FirstStaff()
        rowindex2 = 0
        UpdateStaffDetails(rowindex2)
        dgv_staff.ClearSelection()
        dgv_staff.Rows(rowindex2).Selected = True
    End Sub

    Private Sub LastStaff()
        rowindex2 = dgv_staff.Rows.Count - 1
        UpdateStaffDetails(rowindex2)
        dgv_staff.ClearSelection()
        dgv_staff.Rows(rowindex2).Selected = True
    End Sub
    ' Similar navigation functions to LastCustomer, PreviousCustomer, NextCustomer, FisrtCustomer there are such fucntion for the Staff Details

    Private Sub PreviousStaff()
        If rowindex2 > 0 Then
            rowindex2 -= 1
            UpdateStaffDetails(rowindex2)
            dgv_staff.ClearSelection()
            dgv_staff.Rows(rowindex2).Selected = True
        Else
            MsgBox("You are already looking at the FIRST record")
        End If
    End Sub

    Private Sub NextStaff()
        If rowindex2 < dgv_staff.Rows.Count - 1 Then
            rowindex2 += 1
            UpdateStaffDetails(rowindex2)
            dgv_staff.ClearSelection()
            dgv_staff.Rows(rowindex2).Selected = True
        Else
            MsgBox("You are already looking at the LAST record")
        End If
    End Sub

    'method to update the details in the TextBoxes for a given row index
    Private Sub UpdateStaffDetails(ByVal rowIndex2 As Integer)
        If dgv_staff.Rows.Count > rowIndex2 Then

            ' Update textboxes with decrypted data
            tbx_username2.Text = dgv_staff.Rows(rowIndex2).Cells("Username").Value.ToString()
            tbx_staffid.Text = dgv_staff.Rows(rowIndex2).Cells("StaffID").Value.ToString()
            cbx_title2.Text = dgv_staff.Rows(rowIndex2).Cells("Title").Value.ToString()
            tbx_name2.Text = dgv_staff.Rows(rowIndex2).Cells("Name").Value.ToString()
            tbx_surname2.Text = dgv_staff.Rows(rowIndex2).Cells("Surname").Value.ToString()
            tbx_tel2.Text = dgv_staff.Rows(rowIndex2).Cells("TelNumber").Value.ToString()
            tbx_email2.Text = dgv_staff.Rows(rowIndex2).Cells("Email").Value.ToString()
            tbx_salary.Text = dgv_staff.Rows(rowIndex2).Cells("Salary").Value.ToString()
        End If
    End Sub

    Private Sub btn_first2_Click(sender As Object, e As EventArgs) Handles btn_first2.Click
        FirstStaff()
    End Sub

    Private Sub btn_last2_Click(sender As Object, e As EventArgs) Handles btn_last2.Click
        LastStaff()
    End Sub

    Private Sub btn_prev2_Click(sender As Object, e As EventArgs) Handles btn_prev2.Click
        PreviousStaff()
    End Sub

    Private Sub btn_next2_Click(sender As Object, e As EventArgs) Handles btn_next2.Click
        NextStaff()
    End Sub
    Dim key2 As Integer
    Private Sub btn_delete2_Click(sender As Object, e As EventArgs) Handles btn_delete2.Click
        If tbx_staffid.Text <> "" Then
            If MessageBox.Show("Do you want to delete this staff member?", "Confirmation", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                ' Create a new OleDbConnection using the connection string
                Using conn As New OleDbConnection(connectionString)
                    ' Open the connection
                    conn.Open()

                    ' Define the SQL query for deleting the staff record
                    Dim deleteSql As String = "DELETE FROM staffdetailstbl WHERE [staffid]=@staffid"

                    ' Create a new OleDbCommand with the SQL query and OleDbConnection
                    Using cmdDelete As New OleDbCommand(deleteSql, conn)
                        ' Add parameter to the OleDbCommand
                        cmdDelete.Parameters.AddWithValue("@staffid", tbx_staffid.Text)

                        ' Execute the delete query
                        Dim rowsAffected As Integer = cmdDelete.ExecuteNonQuery()

                        ' Check if the delete was successful
                        If rowsAffected > 0 Then
                            MsgBox("Staff member has been deleted")
                            ' Clear the textbox after deletion
                            tbx_staffid.Clear()
                        Else
                            MsgBox("Couldn't delete the staff member")
                        End If
                    End Using
                End Using
            End If
            ' Call the populate method to refresh the data grid, you'll need to implement this method if it doesn't exist
            populate2()
        Else
            MsgBox("Please select a staff member to be deleted")
        End If

    End Sub

    Private Sub btn_edit2_Click(sender As Object, e As EventArgs) Handles btn_edit2.Click
        If Not validatestaffdetails() Then
            Return ' Stop execution if validation fails
        End If
        If tbx_staffid.Text <> "" Then
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                ' Define the SQL query for updating customer details
                Dim updateSql As String = "UPDATE staffdetailstbl SET [Username]= @Username, [Title]=@Title, [Name]=@Name, [Surname]=@Surname, [TelNumber]=@TelNumber, [Email]=@Email, [Salary] = @Salary WHERE [Staffid]=@Staffid"
                Using cmdUpdate As New OleDbCommand(updateSql, conn)
                    Dim encryptedTel As String = EncryptData(tbx_tel2.Text)
                    Dim encryptedEmail As String = EncryptData(tbx_email2.Text)

                    ' Add parameters to the SqlCommand
                    cmdUpdate.Parameters.AddWithValue("@Username", tbx_username2.Text)
                    cmdUpdate.Parameters.AddWithValue("@Title", cbx_title2.SelectedItem.ToString())
                    cmdUpdate.Parameters.AddWithValue("@Name", tbx_name2.Text)
                    cmdUpdate.Parameters.AddWithValue("@Surname", tbx_surname2.Text)
                    cmdUpdate.Parameters.AddWithValue("@TelNumber", encryptedTel)
                    cmdUpdate.Parameters.AddWithValue("@Email", encryptedEmail)
                    cmdUpdate.Parameters.AddWithValue("@Salary", tbx_salary.Text)
                    cmdUpdate.Parameters.AddWithValue("@StaffID", tbx_staffid.Text)



                    ' Execute the update query
                    Dim rowsAffected As Integer = cmdUpdate.ExecuteNonQuery()

                    ' Check if the update was successful
                    If rowsAffected > 0 Then
                        MsgBox("Staff details updated successfully!")
                        populate2()
                    Else
                        MsgBox("Failed to update staff details.")
                    End If
                End Using
            End Using
        Else
            MsgBox("Please select a staff member to update.")
        End If
    End Sub

    Private Sub btn_saveedit_Click(sender As Object, e As EventArgs) Handles btn_saveedit.Click
        If Not validatecustomersdetails() Then
            Return ' Stop execution if validation fails
        End If

        Using conn As New OleDbConnection(connectionString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query for updating details
            Dim updateSql As String = "UPDATE customersdetailstbl SET [username]=@username, [title]= @title, [name]=@name, [surname]=@surname, [telnumber]= @telnumber, [email]= @email, [age]= @age, [allergies]= @allergies, [additionalinfo]= @additionalinfo WHERE [customerid]=@customerid"

            ' Create a new SqlCommand with the SQL query and SqlConnection
            Using cmdUpdate As New OleDbCommand(updateSql, conn)
                ' Add parameters to the SqlCommand
                Dim encryptedTel As String = EncryptData(tbx_tel.Text)
                Dim encryptedEmail As String = EncryptData(tbx_email.Text)

                ' Correctly add parameters for the OleDbCommand
                cmdUpdate.Parameters.AddWithValue("@username", tbx_username.Text)
                cmdUpdate.Parameters.AddWithValue("@title", cbx_title.Text)
                cmdUpdate.Parameters.AddWithValue("@name", tbx_name.Text)
                cmdUpdate.Parameters.AddWithValue("@surname", tbx_surname.Text)
                cmdUpdate.Parameters.AddWithValue("@telnumber", encryptedTel)
                cmdUpdate.Parameters.AddWithValue("@email", encryptedEmail)
                cmdUpdate.Parameters.AddWithValue("@age", tbx_age.Text)
                cmdUpdate.Parameters.AddWithValue("@allergies", tbx_allergies.Text)
                cmdUpdate.Parameters.AddWithValue("@additionalinfo", tbx_addinfo.Text)

                cmdUpdate.Parameters.AddWithValue("@customerid", tbx_customerid.Text)


                ' Execute the update query
                Dim rowsAffected As Integer = cmdUpdate.ExecuteNonQuery()

                ' Check if the update was successful
                If rowsAffected > 0 Then
                    MsgBox("Details updated successfully!")
                    populate()
                Else
                    MsgBox("Failed to update details.")
                End If
            End Using
        End Using

    End Sub
    ' Function to populate a list of customer IDs from the database
    Private Function PopulateCustomerIds() As List(Of Integer)
        ' Initialize a new list to hold customer IDs
        Dim customerIds As New List(Of Integer)

        ' SQL query to select all customer IDs in ascending order
        Dim sql As String = "SELECT CustomerID FROM customersdetailstbl ORDER BY CustomerID ASC"

        ' Establish a new database connection using the connection string
        Using conn As New OleDbConnection(connectionString)
            ' Create a new command to execute the SQL query
            Using cmd As New OleDbCommand(sql, conn)
                ' Open the database connection
                conn.Open()
                ' Execute the command and use a reader to fetch the results
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    ' Loop through all rows in the result set
                    While reader.Read()
                        ' Add each customer ID to the list after converting it to an integer
                        customerIds.Add(Convert.ToInt32(reader("CustomerID")))
                    End While
                End Using
            End Using
        End Using

        ' Return the populated list of customer IDs
        Return customerIds
    End Function

    ' Function to populate a list of staff IDs from the database
    Private Function PopulateStaffIds() As List(Of Integer)
        ' Initialize a new list to hold staff IDs
        Dim staffIds As New List(Of Integer)

        ' SQL query to select all staff IDs in ascending order
        Dim sql As String = "SELECT StaffID FROM staffdetailstbl ORDER BY StaffID ASC"

        ' Establish a new database connection using the connection string
        Using conn As New OleDbConnection(connectionString)
            ' Create a new command to execute the SQL query
            Using cmd As New OleDbCommand(sql, conn)
                ' Open the database connection
                conn.Open()
                ' Execute the command and use a reader to fetch the results
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    ' Loop through all rows in the result set
                    While reader.Read()
                        ' Add each staff ID to the list after converting it to an integer
                        staffIds.Add(Convert.ToInt32(reader("StaffID")))
                    End While
                End Using
            End Using
        End Using

        ' Return the populated list of staff IDs
        Return staffIds
    End Function

    ' Fetches and displays customer details based on the customer ID.
    Private Sub FetchAndDisplayCustomerDetailsByCustomerId(customerId As Integer)
        ' SQL query to select customer details where the CustomerID matches the parameter.
        Dim sql As String = "SELECT * FROM customersdetailstbl WHERE CustomerID = @CustomerID"

        ' Establish a new database connection using the connection string.
        Using conn As New OleDbConnection(connectionString)
            ' Create a new command to execute the SQL query.
            Using cmd As New OleDbCommand(sql, conn)
                ' Add the customer ID as a parameter to the SQL query to prevent SQL injection.
                cmd.Parameters.AddWithValue("@CustomerID", customerId)
                ' Open the database connection.
                conn.Open()
                ' Execute the command and use a reader to fetch the results.
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    ' Check if the query returned any rows.
                    If reader.Read() Then
                        ' If a match is found, populate the form controls with the customer details.
                        tbx_username.Text = reader("Username").ToString()
                        cbx_title.Text = reader("Title").ToString()
                        tbx_name.Text = reader("Name").ToString()
                        tbx_surname.Text = reader("Surname").ToString()
                        tbx_tel.Text = DecryptData(reader("TelNumber").ToString())
                        tbx_email.Text = DecryptData(reader("Email").ToString())
                        tbx_age.Text = reader("Age").ToString()
                        tbx_allergies.Text = reader("Allergies").ToString()
                        tbx_addinfo.Text = reader("AdditionalInfo").ToString()
                    Else
                        ' If no match is found, display a message to the user.
                        MessageBox.Show("Customer not found.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Fetches and displays staff details based on the staff ID.
    Private Sub FetchAndDisplayStaffDetailsByStaffId(staffId As Integer)
        ' SQL query to select staff details where the StaffID matches the parameter.
        Dim sql As String = "SELECT * FROM staffdetailstbl WHERE StaffID = @StaffID"

        ' Establish a new database connection using the connection string.
        Using conn As New OleDbConnection(connectionString)
            ' Create a new command to execute the SQL query.
            Using cmd As New OleDbCommand(sql, conn)
                ' Add the staff ID as a parameter to the SQL query to prevent SQL injection.
                cmd.Parameters.AddWithValue("@StaffID", staffId)
                ' Open the database connection.
                conn.Open()
                ' Execute the command and use a reader to fetch the results.
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    ' Check if the query returned any rows.
                    If reader.Read() Then
                        ' If a match is found, populate the form controls with the staff details.
                        cbx_title2.Text = reader("Title").ToString()
                        tbx_username2.Text = reader("Username").ToString()
                        tbx_name2.Text = reader("Name").ToString()
                        tbx_surname2.Text = reader("Surname").ToString()
                        tbx_tel2.Text = DecryptData(reader("TelNumber").ToString())
                        tbx_email2.Text = DecryptData(reader("Email").ToString())
                        tbx_salary.Text = reader("Salary").ToString()
                        tbx_staffid.Text = staffId.ToString()
                    Else
                        ' If no match is found, display a message to the user.
                        MessageBox.Show("Staff not found.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Performs a binary search on a sorted list using recursion.
    Private Function BinarySearchRecursive(array As List(Of Integer), target As Integer, low As Integer, high As Integer) As Integer
        ' Base case: if the low index is greater than the high index, the target is not in the list.
        If low > high Then
            Return -1 ' Target is not in the list
        End If

        ' Calculate the middle index of the current segment of the list.
        Dim mid As Integer = (low + high) \ 2

        ' Check if the middle element is the target.
        If array(mid) = target Then
            Return mid ' Target found
        ElseIf array(mid) > target Then
            ' If the middle element is greater than the target, search the left half of the list.
            Return BinarySearchRecursive(array, target, low, mid - 1)
        Else
            ' If the middle element is less than the target, search the right half of the list.
            Return BinarySearchRecursive(array, target, mid + 1, high)
        End If
    End Function

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        'searching for customers details using either username or customerid
        'if username is entered then it searches for the customer using username
        'if username is not entered however customerid is entered then it executes binary search using recursion
        If Not String.IsNullOrWhiteSpace(tbx_username.Text) Then
            Dim con As New OleDbConnection(connectionString)
            con.Open()

            ' Define the SQL query using parameters to avoid SQL injection
            Dim strsql As String = "SELECT * FROM customersdetailstbl WHERE Username = @Username"

            ' Create a new SqlCommand with the SQL query and SqlConnection
            Dim cmd As New OleDbCommand(strsql, con)

            ' Add a parameter to the SqlCommand
            cmd.Parameters.AddWithValue("@Username", tbx_username.Text)

            ' Execute the query and retrieve the data
            Dim myreader As OleDbDataReader = cmd.ExecuteReader()


            ' Check if data is available and read it
            If myreader.Read() Then
                MessageBox.Show("Match has been found.", "Match Found", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim decryptedTel = DecryptData(myreader("TelNumber").ToString())
                Dim decryptedEmail = DecryptData(myreader("Email").ToString())

                ' Display data in the respective textboxes
                cbx_title.Text = (myreader("Title").ToString())
                tbx_username.Text = myreader("Username").ToString()
                tbx_name.Text = myreader("Name").ToString()
                tbx_surname.Text = myreader("Surname").ToString()
                tbx_tel.Text = decryptedTel
                tbx_email.Text = decryptedEmail
                tbx_allergies.Text = myreader("Allergies").ToString()
                tbx_addinfo.Text = myreader("AdditionalInfo").ToString()
                tbx_customerid.Text = myreader("Customerid").ToString()


            Else
                MessageBox.Show("There is no customer with such username.", "No Match Found", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            ' Close the reader and connection
            myreader.Close()
            con.Close()
        ElseIf Not String.IsNullOrWhiteSpace(tbx_customerid2.Text) Then
            Dim targetCustomerId As Integer
            ' Check if the entered customer ID is a valid integer.
            If Int32.TryParse(tbx_customerid2.Text, targetCustomerId) Then
                Dim customerIds As List(Of Integer) = PopulateCustomerIds()
                Dim index As Integer = BinarySearchRecursive(customerIds, targetCustomerId, 0, customerIds.Count - 1)

                If index <> -1 Then
                    ' Customer found, fetch and display details.
                    FetchAndDisplayCustomerDetailsByCustomerId(targetCustomerId)
                    tbx_customerid2.Text = ""
                Else
                    ' Customer not found, show message.
                    MessageBox.Show("Customer with ID " & targetCustomerId.ToString() & " not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ' Entered value is not a valid integer, show error message.
                MessageBox.Show("Customer ID should be an integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbx_customerid2.Text = ""
            End If
        Else
            MessageBox.Show("Please enter a username or customer ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btn_search2_Click(sender As Object, e As EventArgs) Handles btn_search2.Click
        'searching for staff details using either username or staffid
        'if username is entered then it searches for the member of staff using username
        'if username is not entered however staffid is entered then it executes binary search using recursion
        If Not String.IsNullOrWhiteSpace(tbx_username2.Text) Then
            Dim con As New OleDbConnection(connectionString)
            con.Open()

            ' Define the SQL query using parameters to avoid SQL injection
            Dim strsql As String = "SELECT * FROM staffdetailstbl WHERE Username = @Username"

            ' Create a new SqlCommand with the SQL query and SqlConnection
            Dim cmd As New OleDbCommand(strsql, con)

            ' Add a parameter to the SqlCommand
            cmd.Parameters.AddWithValue("@Username", tbx_username2.Text)

            ' Execute the query and retrieve the data
            Dim myreader As OleDbDataReader = cmd.ExecuteReader()

            ' Check if data is available and read it
            If myreader.Read() Then
                MessageBox.Show("Match has been found.", "Match Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim decryptedTel = DecryptData(myreader("TelNumber").ToString())
                Dim decryptedEmail = DecryptData(myreader("Email").ToString())
                ' Display data in the respective textboxes
                cbx_title2.Text = (myreader("Title").ToString())
                tbx_username2.Text = myreader("Username").ToString()
                tbx_name2.Text = myreader("Name").ToString()
                tbx_surname2.Text = myreader("Surname").ToString()
                tbx_tel2.Text = decryptedTel
                tbx_email2.Text = decryptedEmail
                tbx_salary.Text = myreader("Salary").ToString()
                tbx_staffid.Text = myreader("Staffid").ToString()
            Else
                MessageBox.Show("There is no customer with such username.", "No Match Found", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            ' Close the reader and connection
            myreader.Close()
        ElseIf Not String.IsNullOrWhiteSpace(tbx_staffid2.Text) Then
            Dim targetStaffId As Integer
            ' Check if the entered staff ID is a valid integer.
            If Int32.TryParse(tbx_staffid2.Text, targetStaffId) Then
                Dim staffIds As List(Of Integer) = PopulateStaffIds()
                Dim index As Integer = BinarySearchRecursive(staffIds, targetStaffId, 0, staffIds.Count - 1)

                If index <> -1 Then
                    ' Staff member found, fetch and display details.
                    FetchAndDisplayStaffDetailsByStaffId(targetStaffId)
                    tbx_staffid2.Text = ""
                Else
                    ' Staff member not found, show message.
                    MessageBox.Show("Staff with ID " & targetStaffId.ToString() & " not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ' Entered value is not a valid integer, show error message.
                MessageBox.Show("Staff ID should be an integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please enter a username or staff ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub


End Class