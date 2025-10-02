' This class defines the main menu for customer users, offering navigation to various features tailored for customers.

Public Class mainmenucustomer

    ' Handles the click event for a Personal Details button. This method keeps the current form visible and opens the Personal Details form for customers.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = True ' Possibly intended to ensure the main menu remains accessible, but may not work as expected without hiding first.
        PersonalDetailsCustomers.Visible = True
    End Sub

    ' Handles the click event for another Procedure details button. This method hides the current menu and shows the Procedures Details form.
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Visible = False
        ProceduresDetails.Visible = True
    End Sub

    ' Handles the click event on the exit PictureBox. This method makes the login form visible and closes the current main menu form.
    Private Sub pbx_exit_Click(sender As Object, e As EventArgs) Handles pbx_exit.Click
        Login.Visible = True
        Me.Close()

    End Sub

    ' Handles the click event for the Booking button. This method hides the main menu and displays the Booking form.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Booking.Visible = True
    End Sub

    ' Handles the click event for the Booking History button. This method hides the main menu and shows the Booking History form.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        BookingHistory.Visible = True
    End Sub

    ' Handles the click event for the About Salon button. This method hides the main menu and displays the About form.
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        About.Show()
    End Sub

    ' On loading the main menu for customers, attaches button hover effects for improved UI interactivity.
    Private Sub mainmenucustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(Button1)
        ButtonResizer.AttachButtonHoverEffect(Button2)
        ButtonResizer.AttachButtonHoverEffect(Button3)
        ButtonResizer.AttachButtonHoverEffect(Button4)
        ButtonResizer.AttachButtonHoverEffect(button5)
    End Sub
End Class
