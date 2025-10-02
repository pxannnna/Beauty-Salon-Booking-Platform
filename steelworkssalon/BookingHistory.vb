Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class BookingHistory

    Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"

    ' Load data into DataGridView on form load
    Private Sub BookingHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_alldetails)
        ButtonResizer.AttachButtonHoverEffect(btn_finddetails)
        If mysecurity = 1 Then
            btn_alldetails.Visible = False
            btn_finddetails.Visible = False
            tbx_username.Visible = False
            lbl_name.Visible = False

            LoadBookingHistory()

        End If
        If mysecurity = 3 Then
            lbl_1.Text = "Booking History"
        ElseIf mysecurity = 1 Then
            lbl_1.Text = "My Booking History"
        End If


    End Sub

    ' Function to load booking history into DataGridView
    Private Sub LoadBookingHistory()

        ' Clear any existing data in the DataGridView
        dgv_bookinghistory.DataSource = Nothing

        ' Create a DataTable to store the booking history data
        Dim bookingHistoryTable As New DataTable()

        ' SQL query to retrieve booking details based on customerid
        Dim sqlQuery As String = "SELECT AppDate, Time, ProcedureName, Name, Surname, Price " &
                                 "FROM BookingTbl, Procedurestbl, StaffDetailstbl " &
                                 "WHERE BookingTbl.ProcedureID = Procedurestbl.ProcedureID " &
                                 "AND BookingTbl.StaffID = StaffDetailstbl.StaffID " &
                                 "AND BookingTbl.CustomerID = @customerID"

        ' Create a new OleDbConnection using the connection string
        Using con As New OleDbConnection(connectionString)
            con.Open()

            ' Create a new OleDbCommand with the SQL query and OleDbConnection
            Using cmd As New OleDbCommand(sqlQuery, con)
                ' Add parameter to the OleDbCommand
                Dim newcustomerid As String
                Dim query As String = "SELECT customerid FROM customersdetailstbl WHERE username = @Username"
                Using cmdcustomersid As New OleDbCommand(query, con)
                    cmdcustomersid.Parameters.AddWithValue("@username", tbx_username.Text)
                    newcustomerid = Convert.ToString(cmdcustomersid.ExecuteScalar())
                End Using
                ' Check if a customerid was retrieved
                If String.IsNullOrEmpty(newcustomerid) AndAlso mysecurity = 3 Then
                    MessageBox.Show("There are no booking records with this username", "Make sure that you entered username correctly.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tbx_username.Clear()
                    Return
                End If

                If mycustomerid = Nothing Then
                    cmd.Parameters.AddWithValue("@customerID", newcustomerid)
                    MessageBox.Show("Booking history has been found.", "Match Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    cmd.Parameters.AddWithValue("@customerID", mycustomerid)
                End If

                ' Create a new OleDbDataAdapter
                Using adapter As New OleDbDataAdapter(cmd)
                    ' Fill the DataTable with the results of the query
                    adapter.Fill(bookingHistoryTable)
                End Using
            End Using
        End Using

        ' Check if there are rows in the DataTable
        If bookingHistoryTable.Rows.Count > 0 Then
            ' Set the DataTable as the data source for the DataGridView
            dgv_bookinghistory.DataSource = bookingHistoryTable
        Else
            ' Display a message if there is no booking history for the user
            MessageBox.Show("No booking history found.")
        End If
    End Sub

    Private Sub dgv_bookinghistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If mysecurity = 1 Then
            Me.Close()
            mainmenucustomer.Visible = True
        ElseIf mysecurity = 3 Then
            Me.Close()
            Mainmenuadmin.Visible = True
        End If
    End Sub

    Private Sub dgv_bookinghistory_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_bookinghistory.CellContentClick

    End Sub

    Private Sub btn_finddetails_Click(sender As Object, e As EventArgs) Handles btn_finddetails.Click
        If String.IsNullOrWhiteSpace(tbx_username.Text) Then
            MessageBox.Show("Please enter a username to search for booking history.", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        LoadBookingHistory()
    End Sub
    Private Sub LoadAllBookingHistory()
        ' Clear any existing data in the DataGridView
        dgv_bookinghistory.DataSource = Nothing

        ' Create a DataTable to store the booking history data
        Dim allBookingHistoryTable As New DataTable()

        ' SQL query to retrieve all booking details along with customer's username
        Dim sqlQuery As String = "SELECT customersdetailstbl.Username, BookingTbl.AppDate, BookingTbl.Time, " &
                         "Procedurestbl.ProcedureName, StaffDetailstbl.Name, StaffDetailstbl.Surname, " &
                         "Procedurestbl.Price FROM ((BookingTbl " &
                         "INNER JOIN Procedurestbl ON BookingTbl.ProcedureID = Procedurestbl.ProcedureID) " &
                         "INNER JOIN StaffDetailstbl ON BookingTbl.StaffID = StaffDetailstbl.StaffID) " &
                         "INNER JOIN customersdetailstbl ON BookingTbl.CustomerID = customersdetailstbl.CustomerID"


        ' Create a new OleDbConnection using the connection string
        Using con As New OleDbConnection(connectionString)
            con.Open()

            ' Create a new OleDbCommand with the SQL query and OleDbConnection
            Using cmd As New OleDbCommand(sqlQuery, con)
                ' Create a new OleDbDataAdapter
                Using adapter As New OleDbDataAdapter(cmd)
                    ' Fill the DataTable with the results of the query
                    adapter.Fill(allBookingHistoryTable)
                End Using
            End Using
        End Using

        ' Check if there are rows in the DataTable
        If allBookingHistoryTable.Rows.Count > 0 Then
            ' Set the DataTable as the data source for the DataGridView
            dgv_bookinghistory.DataSource = allBookingHistoryTable
        Else
            ' Display a message if there is no booking history found
            MessageBox.Show("No booking history found for any customer.", "No Booking History", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub CalculateTotalIncome()
        ' Variable to hold the total sum
        Dim totalIncome As Decimal = 0

        ' Go through each row in the DataGridView
        For Each row As DataGridViewRow In dgv_bookinghistory.Rows
            ' Check if the row's cell under "Price" column is not null or empty
            If Not IsDBNull(row.Cells("Price").Value) AndAlso Not String.IsNullOrWhiteSpace(row.Cells("Price").Value.ToString()) Then
                ' Add the value to the total sum
                totalIncome += Convert.ToDecimal(row.Cells("Price").Value)
            End If
        Next

        ' Display the total income in a MessageBox
        MessageBox.Show("The total income made by the salon is: " & totalIncome.ToString("C"), "Total Income", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Button click event to load all booking history
    Private Sub btn_alldetails_Click(sender As Object, e As EventArgs) Handles btn_alldetails.Click
        LoadAllBookingHistory()
        CalculateTotalIncome()
    End Sub

End Class
