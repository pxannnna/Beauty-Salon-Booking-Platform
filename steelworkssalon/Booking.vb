
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Xml.Schema

Public Class Booking
    ' Holds panels for each day in the calendar UI.
    Private listflday As New List(Of FlowLayoutPanel)
    ' Current date, used for displaying the calendar.
    Private currentdate As DateTime = DateTime.Today
    ' Paths and connection string for accessing the local database
    Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"
    ' Identifier for the currently selected booking, used for edits and deletions
    Dim bookingid As Integer
    ' Stores initial ComboBox values for time, procedures, and staff
    Private initialTimeValues As New List(Of String)
    Private initialProcedureValues As New List(Of String)
    Private initialStaffValues As New List(Of String)

    ' Function to get staffid based on staff name
    Private Function GetStaffId(Name As String) As Integer
        Dim staffId As Integer = -1

        Try
            Using con As New OleDbConnection(connectionString)
                con.Open()

                ' Split the selected staff name to get only the first word (name)
                Dim firstName As String = Name.Split(" ")(0)

                Dim query As String = "SELECT staffid FROM staffdetailstbl WHERE [Name]= @Name"
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@Name", firstName)

                    staffId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            ' Handle exception
            MsgBox("Error retrieving staffid: " & ex.Message)

        End Try

        Return staffId
    End Function

    'Retrieves the procedure ID based On the selected procedure name
    Private Function GetProcedureId(procedureName As String) As Integer
        Dim procedureId As Integer = -1
        ' Database operation to find the procedure ID
        Try
            Using con As New OleDbConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT procedureid FROM procedurestbl WHERE procedurename = @ProcedureName"
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@ProcedureName", procedureName)
                    procedureId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving procedureid: " & ex.Message)
        End Try
        Return procedureId
    End Function
    ' Retrieves the customer's name based on the booking ID
    Private Function RetrieveCustomersName(ByVal bookingid As Integer) As String
        Dim customersname As String = ""
        Dim customersurname As String = ""


        Using con As New OleDbConnection(connectionString)
            con.Open()

            ' Retrieve customersid who made the booking
            Dim customersid As String

            Dim query2 As String = "SELECT customerid FROM bookingtbl WHERE bookingid = @bookingid"
            Using cmdcustomersid As New OleDbCommand(query2, con)
                cmdcustomersid.Parameters.AddWithValue("@bookingid", bookingid)
                customersid = Convert.ToString(cmdcustomersid.ExecuteScalar())
            End Using

            ' Retrieve customer details based on customersid
            Dim query As String = "SELECT [name], [surname] FROM customersdetailstbl WHERE customerid=@customerid"
            Using cmdfindname As New OleDbCommand(query, con)
                cmdfindname.Parameters.AddWithValue("@customerid", customersid)
                Dim myreader As OleDbDataReader = cmdfindname.ExecuteReader()

                ' Check if data is available and read it
                If myreader.Read() Then
                    ' Display data in the respective local variables
                    customersname = myreader("Name").ToString()
                    customersurname = myreader("Surname").ToString()

                End If

                ' Close the reader
                myreader.Close()
            End Using
        End Using

        Return customersname & " " & customersurname
    End Function
    ' Retrieves the customer's username based on the booking ID
    Private Function RetrieveCustomersUsername(ByVal bookingid As Integer) As String
        Dim customersusername As String = ""
        ' Database operation to find the customer's username
        Using con As New OleDbConnection(connectionString)
            con.Open()

            Dim customersid As String

            Dim query2 As String = "SELECT customerid FROM bookingtbl WHERE bookingid = @bookingid"
            Using cmdcustomersid As New OleDbCommand(query2, con)
                cmdcustomersid.Parameters.AddWithValue("@bookingid", bookingid)
                customersid = Convert.ToString(cmdcustomersid.ExecuteScalar())
            End Using


            Dim query As String = "SELECT username FROM customersdetailstbl WHERE customerid=@customerid"
            Using cmdfindusername As New OleDbCommand(query, con)
                cmdfindusername.Parameters.AddWithValue("@customerid", customersid)
                customersusername = Convert.ToString(cmdfindusername.ExecuteScalar())
            End Using
        End Using
        Return customersusername

    End Function


    ' Function to validate inputs before saving or updating
    Private Function ValidateInputs() As Boolean
        If cbx_time.SelectedIndex = -1 OrElse cbx_procedure.SelectedIndex = -1 OrElse cbx_staff.SelectedIndex = -1 Then
            MessageBox.Show("All fields must be selected.")
            Return False
        End If
        Return True
    End Function
    ' Handles the event for saving a new booking
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ' Validation of selected time, staff, and procedure
        If cbx_time.SelectedIndex = -1 Then
            MessageBox.Show("Please select prefered time.")
        ElseIf cbx_staff.SelectedIndex = -1 Then
            MessageBox.Show("Please select prefered hairstylist.")
        ElseIf cbx_procedure.SelectedIndex = -1 Then
            MessageBox.Show("Please select prefered beautyprocedure.")
        Else

            ' Database operations for saving the booking

            Dim con As New OleDbConnection(connectionString)
            Try
                ' Check if the database file exists
                Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
                If File.Exists(dbFilePath) Then
                    ' Open the connection if the file exists
                    con.Open()

                    ' Step 1: Retrieve staffid and procedureid
                    Dim selectedStaffId As Integer = GetStaffId(cbx_staff.SelectedItem.ToString())
                    Dim selectedProcedureId As Integer = GetProcedureId(cbx_procedure.SelectedItem.ToString())

                    Dim formattedDate As String = dtp_date.Value.ToString("yyyy-MM-dd")

                    Dim databasecon As New DatabaseCon


                    If mycustomerid = "" Then
                        Dim customerusername As String = tbx_customerusername.Text

                        Dim query2 As String = "SELECT customerid FROM customersdetailstbl WHERE username = @username"
                        Using cmdcustomersid As New OleDbCommand(query2, con)
                            cmdcustomersid.Parameters.AddWithValue("@username", customerusername)
                            mycustomerid = Convert.ToString(cmdcustomersid.ExecuteScalar())
                        End Using

                    End If
                    databasecon.AddRecord("SELECT * FROM BookingTbl", "BookingTbl", "BookingID", mycustomerid, selectedStaffId, selectedProcedureId, formattedDate, cbx_time.SelectedItem.ToString())

                    Dim query3 As String = "SELECT Price FROM ProceduresTbl WHERE procedureID = @ProcedureID"
                    Dim price As String
                    Using cmdfindprice As New OleDbCommand(query3, con)
                        cmdfindprice.Parameters.AddWithValue("@ProceudreID", selectedProcedureId)
                        price = Convert.ToString(cmdfindprice.ExecuteScalar())
                    End Using

                    Dim query4 As String = "SELECT Duration FROM ProceduresTbl WHERE procedureID = @ProcedureID"
                    Dim duration As String
                    Using cmdfindduration As New OleDbCommand(query4, con)
                        cmdfindduration.Parameters.AddWithValue("@ProceudreID", selectedProcedureId)
                        duration = Convert.ToString(cmdfindduration.ExecuteScalar())
                    End Using

                    MsgBox("You have successfully booked a time slot with " & cbx_staff.SelectedItem.ToString() & "!" & vbCrLf & "On " & formattedDate & " at " & cbx_time.SelectedItem.ToString() & vbCrLf & "Estimated duration of the procedure: " & duration & " mins" & vbCrLf & "Total Price to be payed: £" & price)
                    ' Resetting the form fields after successful booking
                    tbx_customerusername.Clear()
                    mycustomerid = ""
                    cbx_time.SelectedIndex = -1
                    cbx_procedure.SelectedIndex = -1
                    cbx_staff.SelectedIndex = -1
                Else
                    MsgBox("Database file not found.")
                End If
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If

    End Sub
    ' Handles the event for editing an existing booking
    Private Sub btn_saveedit_Click(sender As Object, e As EventArgs) Handles btn_saveedit.Click
        Dim findBookingIdSql As String = "SELECT COUNT(*) FROM bookingtbl WHERE bookingid = @BookingID"
        Using con As New OleDbConnection(connectionString)
            con.Open()

            Using cmd As New OleDbCommand(findBookingIdSql, con)
                ' Add the bookingid parameter to the command
                cmd.Parameters.AddWithValue("@BookingID", bookingid)

                ' Execute the command and get the result
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Check if the result is 0, which means no such booking record exists
                If result = 0 Then
                    MessageBox.Show("There is no such booking record, so details cannot be updated.", "No Booking Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using
        End Using


        Dim selectedStaffId As Integer = GetStaffId(cbx_staff.SelectedItem.ToString())
        Dim selectedProcedureId As Integer = GetProcedureId(cbx_procedure.SelectedItem.ToString())

        ' Check if preferred hairstylist (staff) is selected
        If cbx_staff.SelectedIndex = -1 Then
            MessageBox.Show("Please select a preferred hairstylist.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if procedure is selected
        If cbx_procedure.SelectedIndex = -1 Then
            MessageBox.Show("Please select a procedure.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if time is selected
        If String.IsNullOrEmpty(cbx_time.Text) Then
            MessageBox.Show("Please select a time.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' If all checks passed, proceed with updating the booking details
        Using conn As New OleDbConnection(connectionString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query for updating details
            Dim updateSql As String = "UPDATE bookingtbl SET [time]=@Time, [staffid]=@StaffID, [procedureid]=@ProcedureID WHERE [bookingid]=@BookingID"

            ' Create a new SqlCommand with the SQL query and SqlConnection
            Using cmdUpdate As New OleDbCommand(updateSql, conn)
                ' Add parameters to the SqlCommand
                cmdUpdate.Parameters.AddWithValue("@Time", cbx_time.Text)
                cmdUpdate.Parameters.AddWithValue("@StaffID", selectedStaffId)
                cmdUpdate.Parameters.AddWithValue("@ProcedureID", selectedProcedureId)
                cmdUpdate.Parameters.AddWithValue("@BookingID", bookingid)

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


    'Exit button that closes currently opened form and takes the user to the main menu accordingly to their access level
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        If mysecurity = 1 Then
            mainmenucustomer.Show()
        ElseIf mysecurity = 2 Then
            mainmenustaff.Show()
        ElseIf mysecurity = 3 Then
            Mainmenuadmin.Show()
        End If

    End Sub
    ' Initializes Booking form with necessary setups for the calendar and UI elements
    'when user hovers over the button it should change the size
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_save)
        ButtonResizer.AttachButtonHoverEffect(btn_clear)
        ButtonResizer.AttachButtonHoverEffect(btn_delete)
        ButtonResizer.AttachButtonHoverEffect(btn_saveedit)
        generatedaypanel(37)
        displaycurrentdate()


        If mysecurity = 1 Then
            lbl_name.Visible = False
            tbx_customername.Visible = False
            lbl_allergies.Visible = False
            lbl_info.Visible = False
            tbx_addinfo.Visible = False
            tbx_allergies.Visible = False
            lbl_customersusername.Visible = False
            tbx_customerusername.Visible = False

        ElseIf mysecurity = 2 Then
            btn_delete.Visible = False
            btn_saveedit.Visible = False
            btn_clear.Visible = False
            btn_save.Visible = False
            lbl_customersusername.Visible = False
            tbx_customerusername.Visible = False
            pbx_1.Visible = False
            pbx_2.Visible = False
        End If



    End Sub
    ' Adds appointments to the calendar based on the database entries for the current month

    Private Sub addappointmenttofldate(ByVal startdayatflnumber As Integer)
        Dim startdate As DateTime = New Date(currentdate.Year, currentdate.Month, 1)
        Dim enddate As DateTime = startdate.AddMonths(1).AddDays(-1)
        ' SQL query to select bookings within the current month

        Dim sql As String = $"Select * from bookingtbl where Appdate between #{startdate.ToShortDateString()}# and #{enddate.ToShortDateString()}# "
        Dim dt As DataTable = queryasdatatable(sql)
        ' Iterates through each booking and adds a link label to the corresponding day panel

        For Each row As DataRow In dt.Rows
            Dim appday As DateTime = DateTime.Parse(row("AppDate"))
            If appday.Month = currentdate.Month AndAlso appday.Year = currentdate.Year Then
                Dim link As New LinkLabel
                ' Use the bookingid from the row to get the customer's name
                Dim bookingId As Integer = Convert.ToInt32(row("BookingID"))

                ' Retrieve the customerid for the current booking
                Dim bookingCustomerID As String = Convert.ToString(row("CustomerID"))
                If mysecurity = 1 Then
                    ' Check if bookingCustomerID matches mycustomerid
                    If bookingCustomerID = mycustomerid Then
                        ' Adds the booking link for the current customer's bookings
                        link.Name = $"link{row("BookingID")}"
                        Dim customersnameandsurname As String = RetrieveCustomersName(bookingId)
                        link.Text = customersnameandsurname
                        link.Tag = bookingId
                        Dim customersusername As String = RetrieveCustomersUsername(bookingId)
                        AddHandler link.Click, Sub(sender, e) showappointmentdetail(sender, e, customersnameandsurname, customersusername)

                        listflday((appday.Day - 1) + (startdayatflnumber - 1)).Controls.Add(link)
                    End If
                Else
                    ' Adds the booking link for staff or admin to view all bookings
                    link.Name = $"link{row("BookingID")}"
                    Dim customersnameandsurname As String = RetrieveCustomersName(row("BookingID"))
                    link.Text = customersnameandsurname

                    link.Tag = bookingId
                    Dim customersusername As String = RetrieveCustomersUsername(bookingId)
                    AddHandler link.Click, Sub(sender, e) showappointmentdetail(sender, e, customersnameandsurname, customersusername)


                    listflday((appday.Day - 1) + (startdayatflnumber - 1)).Controls.Add(link)
                End If
            End If

        Next
    End Sub
    ' Displays the details of a selected appointment in the form fields for viewing or editing

    Private Sub showappointmentdetail(sender As Object, e As EventArgs, ByVal customersnameandsurname As String, ByVal customersusername As String)

        bookingid = CType(sender, LinkLabel).Tag

        Dim conn As New OleDbConnection(connectionString)
        conn.Open()

        ' Declare variables at the beginning of the method
        Dim selectedprocedure As String = ""
        Dim selectedstaff As String = ""

        ' Define the SQL query using parameters to avoid SQL injection
        Dim strsql As String = "SELECT * FROM bookingtbl WHERE BookingID = @BookingID"

        ' Create a new SqlCommand with the SQL query and SqlConnection
        Dim cmd As New OleDbCommand(strsql, conn)

        ' Add a parameter to the SqlCommand
        cmd.Parameters.AddWithValue("@BookingID", bookingid)

        ' Execute the query and retrieve the data
        Dim myreader As OleDbDataReader = cmd.ExecuteReader()

        ' Check if data is available and read it
        If myreader.Read() Then
            ' Display data in the respective textboxes
            cbx_time.Text = (myreader("Time").ToString())
            selectedprocedure = myreader("ProcedureID").ToString()
            selectedstaff = myreader("StaffID").ToString()
            dtp_date.Value = Convert.ToDateTime(myreader("AppDate"))
        End If

        ' Close the reader and connection
        myreader.Close()

        ' Define the SQL query using parameters to avoid SQL injection
        Dim strsql2 As String = "SELECT procedurename FROM procedurestbl WHERE procedureid = @procedureid"

        ' Create a new SqlCommand with the SQL query and SqlConnection
        Dim cmdfindprocedurename As New OleDbCommand(strsql2, conn)
        cmdfindprocedurename.Parameters.AddWithValue("@ProcedureID", selectedprocedure)
        cbx_procedure.Text = (Convert.ToString(cmdfindprocedurename.ExecuteScalar()))



        Dim strsql3 As String = "SELECT Name, Surname FROM StaffDetailstbl WHERE StaffID = @StaffId"

        ' Create a new SqlCommand with the SQL query and SqlConnection
        Dim cmd2 As New OleDbCommand(strsql3, conn)

        ' Add a parameter to the SqlCommand
        cmd2.Parameters.AddWithValue("@StaffID", selectedstaff)

        ' Execute the query and retrieve the data
        Dim myreader2 As OleDbDataReader = cmd2.ExecuteReader()

        ' Check if data is available and read it
        If myreader2.Read() Then
            ' Display data in the respective textboxes
            cbx_staff.Text = ($"{myreader2("Name").ToString()} {myreader2("Surname").ToString()}")

        End If

        ' Close the reader and connection
        myreader2.Close()
        tbx_customername.Text = customersnameandsurname
        tbx_customerusername.Text = customersusername


        Dim customersid As String


        Dim query As String = "SELECT customerid FROM bookingtbl WHERE bookingid = @bookingid"
        Using cmdcustomersid As New OleDbCommand(query, conn)
            cmdcustomersid.Parameters.AddWithValue("@bookingid", bookingid)
            customersid = Convert.ToString(cmdcustomersid.ExecuteScalar())
        End Using

        Dim query2 As String = "SELECT allergies, additionalinfo FROM customersdetailstbl WHERE customerid = @customerid"
        Using cmdfinddetails As New OleDbCommand(query2, conn)
            cmdfinddetails.Parameters.AddWithValue("@customerid", customersid)
            Using reader As OleDbDataReader = cmdfinddetails.ExecuteReader()
                If reader.Read() Then ' Check if there is at least one row
                    ' Assuming allergies and additionalinfo are not DBNull.
                    tbx_allergies.Text = Convert.ToString(reader("allergies"))
                    tbx_addinfo.Text = Convert.ToString(reader("additionalinfo"))
                Else
                    ' Handle the case where no data is found
                    tbx_allergies.Text = "Not found"
                    tbx_addinfo.Text = "Not found"
                End If
            End Using
        End Using

    End Sub
    ' Clears all appointments from the day panels to refresh the UI for a new month or after a booking change
    Private Sub clearAppointmentsFromPanels()
        For Each fl As FlowLayoutPanel In listflday
            fl.Controls.Clear() ' Clearing each panel before repopulating
        Next
    End Sub
    ' Updates the UI to display the current month, including generating day labels and adding appointments
    Private Sub displaycurrentdate()
        lbl_monthandyear.Text = currentdate.ToString("MMMM, yyyy")
        Dim firstdayatflnumber = getfirstdayofweeekofcurrentdate()
        Dim totaldays As Integer = gettotaldaysofcurrentdate()
        clearAppointmentsFromPanels()
        addlabeldaytoflday(firstdayatflnumber, totaldays)
        addappointmenttofldate(firstdayatflnumber)
    End Sub
    ' Navigation functions to display previous month, next month, or return to today's date.
    Private Sub prevmonth()
        currentdate = currentdate.AddMonths(-1)
        displaycurrentdate()
    End Sub
    Private Sub nextmonth()
        currentdate = currentdate.AddMonths(+1)
        displaycurrentdate()
    End Sub
    Private Sub today()
        currentdate = DateTime.Today
        displaycurrentdate()
    End Sub
    ' Calculates the first day of the week for the current month to correctly align dates in the UI
    Private Function getfirstdayofweeekofcurrentdate() As Integer
        Dim firstdayofmonth As DateTime = New Date(currentdate.Year, currentdate.Month, 1)
        Return firstdayofmonth.DayOfWeek + 1
    End Function
    ' Determines the total number of days in the current month for generating day labels
    Private Function gettotaldaysofcurrentdate() As Integer
        Dim firstdayofcurrentdate As DateTime = New Date(currentdate.Year, currentdate.Month, 1)
        Return firstdayofcurrentdate.AddMonths(1).AddDays(-1).Day
    End Function
    ' Event handler for creating a new appointment when a day panel is clicked

    Private Sub addnewappointment(ByVal sender As Object, e As EventArgs)

        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            dtp_date.Value = New Date(currentdate.Year, currentdate.Month, day)

            displaycurrentdate()
            cbx_time.SelectedIndex = -1
            cbx_procedure.SelectedIndex = -1
            cbx_staff.SelectedIndex = -1
            tbx_customerusername.Clear()
            tbx_allergies.Clear()
            tbx_addinfo.Clear()
            tbx_customername.Clear()

        End If

    End Sub


    ' Generates flow panels for each day of the month, allowing for dynamic updates to the calendar


    Private Sub generatedaypanel(ByVal totaldays As Integer)

        flDays.Controls.Clear()
        listflday.Clear()
        For i As Integer = 1 To totaldays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"FlDay{i}"
            fl.Size = New Size(75, 67)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            AddHandler fl.Click, AddressOf addnewappointment

            flDays.Controls.Add(fl)
            listflday.Add(fl)
        Next

    End Sub
    ' Adds day labels to the panels, highlighting the current day and preparing for appointment links

    Private Sub addlabeldaytoflday(ByVal startdayflnumber As Integer, ByVal totaldaysinmonth As Integer)
        For Each fl As FlowLayoutPanel In listflday
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next


        For i As Integer = 1 To totaldaysinmonth
            Dim lbl As New Label
            lbl.Name = $"lbl_day{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(72, 17)
            lbl.Text = i
            lbl.Font = New Font("Lucida Sans Unicode", 7)
            'set position of the label
            lbl.Top = (i - 1) * lbl.Height
            lbl.Left = 0

            listflday((i - 1) + (startdayflnumber - 1)).Tag = i
            listflday((i - 1) + (startdayflnumber - 1)).Controls.Add(lbl)
            If New Date(currentdate.Year, currentdate.Month, i) = Date.Today Then
                ' Change the label's text color to dark orange for the current day
                lbl.ForeColor = Color.DarkOrange
                lbl.Font = New Font(lbl.Font, FontStyle.Bold)
            End If

        Next
    End Sub
    ' Navigation button events to trigger month changes or return to the current date

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        prevmonth()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        nextmonth()
    End Sub

    Private Sub btn_now_Click(sender As Object, e As EventArgs) Handles btn_now.Click
        today()
    End Sub
    ' Event handler for deleting a selected appointment

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MessageBox.Show("Do you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
            ' Check if the bookingid is set
            If bookingid > 0 Then
                ' Create a new OleDbConnection using the connection string
                Using conn As New OleDbConnection(connectionString)
                    ' Open the connection
                    conn.Open()

                    ' Define the SQL query for deleting the record
                    Dim deleteSql As String = "DELETE FROM bookingtbl WHERE [bookingid]=@BookingID"

                    ' Create a new OleDbCommand with the SQL query and OleDbConnection
                    Using cmdDelete As New OleDbCommand(deleteSql, conn)
                        ' Add parameter to the OleDbCommand
                        cmdDelete.Parameters.AddWithValue("@BookingID", bookingid)

                        ' Execute the delete query
                        Dim rowsAffected As Integer = cmdDelete.ExecuteNonQuery()

                        ' Check if the delete was successful
                        If rowsAffected > 0 Then
                            MsgBox("Appointment has been deleted")
                        Else
                            MsgBox("Couldn't delete the appointment")
                        End If
                    End Using
                End Using
            Else
                MsgBox("No appointment selected for deletion.")
            End If
        End If
    End Sub


    ' Resets ComboBox selections to initial values

    Private Sub ResetComboBox(cbx As ComboBox, initialValues As List(Of String))
        cbx.Items.Clear()
        For Each item As String In initialValues
            cbx.Items.Add(item)
        Next
        cbx.SelectedIndex = -1
    End Sub


    ' Clears all form fields to default values, preparing for a new booking or clearing current selections

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        cbx_time.SelectedIndex = -1
        cbx_procedure.SelectedIndex = -1
        cbx_staff.SelectedIndex = -1
        tbx_customerusername.Clear()
        tbx_allergies.Clear()
        tbx_addinfo.Clear()
        tbx_customername.Clear()

    End Sub

End Class
