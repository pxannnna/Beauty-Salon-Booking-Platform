' This class represents the main menu interface for the administrator user. It provides navigation to different sections of the application.

Public Class Mainmenuadmin

    ' Handles the click event on the exit PictureBox. This method makes the admin main menu invisible and shows the login form.
    Private Sub pbx_exit_Click(sender As Object, e As EventArgs) Handles pbx_exit.Click
        Me.Visible = False
        Login.Visible = True

    End Sub

    ' Handles the click event on the details button. This method navigates from the admin main menu to the user details form.
    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click
        Me.Visible = False
        UsersDetails.Visible = True
    End Sub

    ' Handles the click event on the procedure details button. This method navigates from the admin main menu to the procedures details form.
    Private Sub btn_proceduredetails_Click(sender As Object, e As EventArgs) Handles btn_proceduredetails.Click
        Me.Visible = False
        ProceduresDetails.Visible = True
    End Sub

    ' Handles the click event on the booking button. This method hides the admin main menu and shows the booking form.
    Private Sub btn_boooking_Click(sender As Object, e As EventArgs) Handles btn_boooking.Click
        Me.Hide()
        Booking.Show()
    End Sub

    ' Adds hover effects to buttons on the admin main menu load event to improve user interface interaction.
    Private Sub Mainmenuadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_boooking)
        ButtonResizer.AttachButtonHoverEffect(btn_bookinghistory)
        ButtonResizer.AttachButtonHoverEffect(btn_details)
        ButtonResizer.AttachButtonHoverEffect(btn_proceduredetails)
        ButtonResizer.AttachButtonHoverEffect(btn_shifts)
    End Sub

    ' [This method seems to be declared but not properly linked to an event handler in the provided code snippet.]

    ' Handles the click event on the shifts button. This method hides the admin main menu and shows the shifts timetable form.
    Private Sub btn_shifts_Click(sender As Object, e As EventArgs) Handles btn_shifts.Click
        Me.Hide()
        ShiftsTimetable.Show()
    End Sub

    ' Handles the click event on the booking history button. This method hides the admin main menu and shows the booking history form.
    Private Sub btn_bookinghistory_Click(sender As Object, e As EventArgs) Handles btn_bookinghistory.Click
        Me.Hide()
        BookingHistory.Show()
    End Sub
End Class
