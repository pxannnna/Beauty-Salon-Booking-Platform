Imports System.Data.OleDb
'Updating shifts timetable details
Public Class ShiftsTimetable
    'establishing connection with a database
    Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"
    Dim selectedday As String
    Dim selectedstaff As String

    Private Sub ShiftsTimetableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_save)
        ' Load the shifts timetable into the DataGridView on form load
        LoadShiftsTimetable()
        If mysecurity = 2 Then
            'hiding buttons for updating to the members of staff because only admin should be able to edit the timetable
            btn_save.Visible = False
            cbx_staff.Visible = False
            cbx_starttime.Visible = False
            cbx_endtime.Visible = False
            cbx_dayofweek.Visible = False
            lbl_1.Visible = False
            lbl_2.Visible = False
        End If

    End Sub
    'function that retrieves shifts details to populate the datagrid
    Private Sub LoadShiftsTimetable()
        ' Clear any existing data in the DataGridView
        dgv_shiftstimetable.DataSource = Nothing

        ' Create a DataTable to store the shifts timetable data
        Dim shiftsTimetableTable As New DataTable()

        ' SQL query to retrieve shifts timetable data
        Dim sqlQuery As String =
            "SELECT staffname, " &
            "       MondayStart & '-' & MondayEnd AS Monday, " &
            "       TuesdayStart & '-' & TuesdayEnd AS Tuesday, " &
            "       WednesdayStart & '-' & WednesdayEnd AS Wednesday, " &
            "       ThursdayStart & '-' & ThursdayEnd AS Thursday, " &
            "       FridayStart & '-' & FridayEnd AS Friday, " &
            "       SaturdayStart & '-' & SaturdayEnd AS Saturday, " &
            "       SundayStart & '-' & SundayEnd AS Sunday " &
            "FROM shiftstimetabletbl"

        ' Create a new OleDbConnection using the connection string
        Using con As New OleDbConnection(connectionString)
            con.Open()

            ' Create a new OleDbCommand with the SQL query and OleDbConnection
            Using cmd As New OleDbCommand(sqlQuery, con)
                ' Create a new OleDbDataAdapter
                Using adapter As New OleDbDataAdapter(cmd)
                    ' Fill the DataTable with the results of the query
                    adapter.Fill(shiftsTimetableTable)
                End Using
            End Using
        End Using

        ' Check if there are rows in the DataTable
        If shiftsTimetableTable.Rows.Count > 0 Then
            ' Set the DataTable as the data source for the DataGridView
            dgv_shiftstimetable.DataSource = shiftsTimetableTable
        Else
            ' Display a message if there is no data in the shifts timetable
            MessageBox.Show("No shifts timetable data found.")
        End If
    End Sub
    'Exit button closes currently opened form and takes the user to the main menu
    Private Sub pbx_exit_Click(sender As Object, e As EventArgs) Handles pbx_exit.Click
        Me.Close()
        If mysecurity = 2 Then
            mainmenustaff.Show()
        ElseIf mysecurity = 3 Then
            Mainmenuadmin.Show()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ' Validate the day of the week and staff name selections
        If cbx_dayofweek.SelectedIndex = -1 OrElse cbx_staff.SelectedIndex = -1 Then
            MessageBox.Show("Please select both the day of the week and the member of staff.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate the start time and end time selections
        If cbx_starttime.SelectedIndex = -1 OrElse cbx_endtime.SelectedIndex = -1 Then
            MessageBox.Show("Please select both the start time and the end time to update the shift timetable.", "Time Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Proceed with updating the database
        selectedday = cbx_dayofweek.SelectedItem.ToString()
        selectedstaff = cbx_staff.SelectedItem.ToString()

        Dim updateSql As String = $"UPDATE shiftstimetabletbl SET [{selectedday}Start]= @Start, [{selectedday}End]=@End WHERE [StaffName]=@StaffName"

        Using con As New OleDbConnection(connectionString)
            con.Open()

            Using cmdUpdate As New OleDbCommand(updateSql, con)
                cmdUpdate.Parameters.AddWithValue("@Start", cbx_starttime.SelectedItem.ToString())
                cmdUpdate.Parameters.AddWithValue("@End", cbx_endtime.SelectedItem.ToString())
                cmdUpdate.Parameters.AddWithValue("@StaffName", selectedstaff)
                Dim rowsAffected As Integer = cmdUpdate.ExecuteNonQuery()

                ' Verify the update was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Shifts Timetable has been updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadShiftsTimetable()
                Else
                    MessageBox.Show("Failed to update the timetable. Please ensure the staff member's name is correct.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

End Class
