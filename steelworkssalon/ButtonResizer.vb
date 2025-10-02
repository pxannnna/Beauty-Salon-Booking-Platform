Module ButtonResizer
    'A module to change the size of the button when a user hovers over it
    Public Sub AttachButtonHoverEffect(ByVal btn As Button)
        AddHandler btn.MouseEnter, AddressOf OnButtonMouseEnter
        AddHandler btn.MouseLeave, AddressOf OnButtonMouseLeave
    End Sub

    Private Sub OnButtonMouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        ' Store the original size
        Dim originalWidth As Integer = btn.Width
        Dim originalHeight As Integer = btn.Height

        ' Increase the size
        btn.Width += CInt(originalWidth * 0.05)
        btn.Height += CInt(originalHeight * 0.05)

        ' Move the button to the left and up to keep it centered
        btn.Left -= CInt((btn.Width - originalWidth) / 2)
        btn.Top -= CInt((btn.Height - originalHeight) / 2)
    End Sub

    Private Sub OnButtonMouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        ' Store the enlarged size
        Dim enlargedWidth As Integer = btn.Width
        Dim enlargedHeight As Integer = btn.Height

        ' Decrease the size
        btn.Width -= CInt(enlargedWidth * 0.05)
        btn.Height -= CInt(enlargedHeight * 0.05)

        ' Move the button to the right and down to return to original position
        btn.Left += CInt((enlargedWidth - btn.Width) / 2)
        btn.Top += CInt((enlargedHeight - btn.Height) / 2)
    End Sub

End Module
