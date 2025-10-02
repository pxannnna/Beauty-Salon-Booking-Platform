' This class defines the main menu for staff users, offering navigation to various functionalities tailored for staff members.

Public Class mainmenustaff

    ' Handles the click event for the Personal Details button. This method hides the current menu and opens the Personal Details form for staff.
    Private Sub btn_personaldetails_Click(sender As Object, e As EventArgs) Handles btn_personaldetails.Click
        Me.Visible = False ' Hides the main menu for staff.
        PersonalDetailsStaff.Visible = True ' Shows the Personal Details form specifically designed for staff members.
    End Sub

    ' Handles the click event for the exit PictureBox. This method makes the login form visible and closes the current main menu form for staff.
    Private Sub pbx_exit_Click(sender As Object, e As EventArgs) Handles pbx_exit.Click
        Login.Visible = True ' Shows the login form.
        Me.Close() ' Closes the main menu form for staff, effectively logging the user out.

    End Sub

    ' On loading the main menu for staff, this method attaches button hover effects to enhance UI interactivity.
    Private Sub mainmenustaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_booking) ' Adds hover effect to the Booking button.
        ButtonResizer.AttachButtonHoverEffect(btn_shifts) ' Adds hover effect to the Shifts button.
        ButtonResizer.AttachButtonHoverEffect(btn_personaldetails) ' Adds hover effect to the Personal Details button.
    End Sub

    ' Handles the click event for the Shifts button. This method keeps the main menu visible and opens the Shifts Timetable form.
    Private Sub btn_shifts_Click(sender As Object, e As EventArgs) Handles btn_shifts.Click
        Me.Visible = True ' Keeps the main menu visible, potentially to allow for easy navigation back.
        ShiftsTimetable.Visible = True ' Shows the Shifts Timetable form, where staff can view their shifts.
    End Sub

    ' Handles the click event for the Booking button. This method hides the main menu and displays the Booking form.
    Private Sub btn_booking_Click(sender As Object, e As EventArgs) Handles btn_booking.Click
        Me.Hide() ' Hides the main menu form for staff.
        Booking.Show() ' Opens the Booking form, allowing staff to manage bookings.
    End Sub
End Class
