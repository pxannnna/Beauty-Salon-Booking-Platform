
Public Class About

    ' Closes the current form and shows the main menu for customers when the PictureBox is clicked.
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close() ' Closes the About form.
        mainmenucustomer.Show() ' Displays the main menu form for customers.
    End Sub

    ' Handles the MouseHover event for multiple items (labels and picture boxes).
    ' Dynamically changes the description text based on which item is hovered over.
    Private Sub Item_MouseHover(sender As Object, e As EventArgs)
        Dim control As Control = CType(sender, Control) ' Casts the sender to a Control.
        ' Extracts the identifier (a number) from the control's name to determine the source of the event.
        Dim identifier As String = control.Name.Substring(control.Name.Length - 1)

        ' Selects the appropriate text for lbl_description based on the identifier.
        Select Case identifier
            Case "1"
                ' Sets the description for Megan Steele.
                lbl_description.Text = "Meet Megan Steele, the visionary owner of Steelworks Hair & Beauty Co. With over a decade of experience in the hair industry, Megan continuously embraces new training methods to bring her clients the latest trends and timeless looks. Her commitment to excellence ensures you receive cutting-edge styles tailored to your unique personality and preferences. Megan's passion for hair extends beyond the salon, creating a space where innovation, expertise, and client satisfaction converge."
            Case "2"
                ' Sets the description for Carol Streling.
                lbl_description.Text = "Unleash your beauty potential with Carol Streling, a skilled hairstylist at Steelworks. Carol's professionalism shines through as she excels in Babylights, Root Melting, Toner, Ladies Cut and Blowdry, Hair Extensions, Full Head Permanent Colour, Gents Haircut and Blowdry, Bridal Hair, Foliage Highlights, Toner and Colour, and Balayage and Tint. Elevate your style with Carol's expert touch."
            Case "4"
                ' Sets the description for Emma Willow.
                lbl_description.Text = "Experience beauty redefined with Emma Willow, a dedicated hairstylist at Steelworks. Emma's proficiency spans a variety of procedures, offering expertise in Babylights, Root Melting, Toner, Ladies Cut and Blowdry, Hair Extensions, Full Head Permanent Colour, Gents Haircut and Blowdry, Bridal Hair, Foliage Highlights, Toner and Colour, and Balayage and Tint. Let Emma transform your hair into a masterpiece."
            Case "3"
                ' Sets the description for John Archer.
                lbl_description.Text = "As a seasoned hairstylist at Steelworks, John Archer brings professionalism and versatility to every client. Specializing in a range of procedures, including Babylights, Root Melting, Toner, Ladies Cut and Blowdry, Hair Extensions, Full Head Permanent Colour, Gents Haircut and Blowdry, Bridal Hair, Foliage Highlights, Toner and Colour, and Balayage and Tint, John's expertise ensures you leave the salon with a stunning and personalized look."
        End Select
    End Sub

    ' Resets the description text when the mouse leaves any of the items (labels or picture boxes).
    Private Sub Item_MouseLeave(sender As Object, e As EventArgs)
        lbl_description.Text = "To see more details about the staff hover over their name or picture."
    End Sub

    ' Adds event handlers for MouseHover and MouseLeave events to labels and picture boxes upon form load.
    ' This setup enables dynamic interaction based on user actions.
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding MouseHover event handlers for labels.
        AddHandler lbl_1.MouseHover, AddressOf Item_MouseHover
        AddHandler lbl_2.MouseHover, AddressOf Item_MouseHover
        AddHandler lbl_3.MouseHover, AddressOf Item_MouseHover
        AddHandler lbl_4.MouseHover, AddressOf Item_MouseHover

        ' Adding MouseHover event handlers for picture boxes.
        AddHandler pbx_1.MouseHover, AddressOf Item_MouseHover
        AddHandler pbx_2.MouseHover, AddressOf Item_MouseHover
        AddHandler pbx_3.MouseHover, AddressOf Item_MouseHover
        AddHandler pbx_4.MouseHover, AddressOf Item_MouseHover

        ' Adding MouseLeave event handlers to reset the description when the mouse leaves labels or picture boxes.
        AddHandler lbl_1.MouseLeave, AddressOf Item_MouseLeave
        AddHandler lbl_2.MouseLeave, AddressOf Item_MouseLeave
        AddHandler lbl_3.MouseLeave, AddressOf Item_MouseLeave
        AddHandler lbl_4.MouseLeave, AddressOf Item_MouseLeave

        AddHandler pbx_1.MouseLeave, AddressOf Item_MouseLeave
        AddHandler pbx_2.MouseLeave, AddressOf Item_MouseLeave
        AddHandler pbx_3.MouseLeave, AddressOf Item_MouseLeave
        AddHandler pbx_4.MouseLeave, AddressOf Item_MouseLeave
    End Sub


End Class
