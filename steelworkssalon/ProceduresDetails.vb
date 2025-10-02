Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand

'Updating procedure costs and their description
Public Class ProceduresDetails
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        mainmenucustomer.Visible = True
    End Sub
    'establishing connection with a database
    Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"

    Private Sub ProceduresDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonResizer.AttachButtonHoverEffect(btn_update)
        'hiding unnecessary buttons to customers
        If mysecurity = 1 Then
            tbx_price1.ReadOnly = True
            tbx_price2.ReadOnly = True
            tbx_price3.ReadOnly = True
            tbx_price4.ReadOnly = True
            tbx_price5.ReadOnly = True
            tbx_price6.ReadOnly = True
            tbx_price7.ReadOnly = True
            tbx_price8.ReadOnly = True
            tbx_price9.ReadOnly = True
            tbx_1.ReadOnly = True
            tbx_2.ReadOnly = True
            tbx_3.ReadOnly = True
            tbx_4.ReadOnly = True
            tbx_5.ReadOnly = True
            tbx_6.ReadOnly = True
            tbx_7.ReadOnly = True
            tbx_8.ReadOnly = True
            tbx_9.ReadOnly = True
        End If
        If mysecurity = 3 Then
            ' update button is only visible to admin
            btn_update.Visible = True
        Else
            btn_update.Visible = False
        End If

        ' Create a new SqlConnection using the connection string
        Using conn As New OleDbConnection(connectionString)
            ' Open the connection
            conn.Open()

            ' Define the SQL query to retrieve prices
            Dim strsql As String = "SELECT price FROM procedurestbl"

            ' Create a new SqlCommand with the SQL query and SqlConnection
            Dim cmd As New OleDbCommand(strsql, conn)

            ' Execute the query and retrieve the data
            Dim myreader As OleDbDataReader = cmd.ExecuteReader()

            ' Check if data is available and read it
            Dim i As Integer = 1
            While myreader.Read() AndAlso i <= 9
                ' Display price in the respective textboxes
                DirectCast(Me.Controls("tbx_price" & i.ToString()), TextBox).Text = myreader("price").ToString()
                i += 1
            End While

            ' Close the reader and connection
            myreader.Close()
        End Using




    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        ' Flag to track if all prices are valid integers
        Dim allPricesValid As Boolean = True

        ' Loop through each textbox and validate the entered price
        For i As Integer = 1 To 9
            Dim priceTextBox As TextBox = DirectCast(Me.Controls("tbx_price" & i.ToString()), TextBox)
            Dim price As Integer

            ' Check if the entered value is a valid integer
            If Not Integer.TryParse(priceTextBox.Text, price) Then
                ' Display error message and set flag to false if invalid
                allPricesValid = False
                Exit For
            End If
        Next i

        ' Proceed with updating prices only if all prices are valid integers
        If allPricesValid Then
            ' Create a new SqlConnection using the connection string
            Using conn As New OleDbConnection(connectionString)
                ' Open the connection
                conn.Open()

                ' Define the base SQL query for updating the price column
                Dim updateSql As String = "UPDATE procedurestbl SET price=@Price WHERE procedureid=@ProcedureID"

                ' Loop through each textbox and update the corresponding row in the table
                For i As Integer = 1 To 9
                    ' Create a new SqlCommand with the SQL query and SqlConnection
                    Using cmdUpdate As New OleDbCommand(updateSql, conn)
                        ' Add parameters to the SqlCommand
                        cmdUpdate.Parameters.AddWithValue("@Price", DirectCast(Me.Controls("tbx_price" & i.ToString()), TextBox).Text)
                        cmdUpdate.Parameters.AddWithValue("@ProcedureID", i)

                        ' Execute the update query
                        Dim rowsAffected As Integer = cmdUpdate.ExecuteNonQuery()

                        ' Check if the update was unsuccessful
                        If rowsAffected <= 0 Then
                            MsgBox("Failed to update the prices.")
                        End If
                    End Using
                Next i

                ' Display a single message box after all updates
                MsgBox("Prices have been updated.")
            End Using
        Else
            ' Display message if any entered price is not an integer
            MsgBox("All entered prices must be integers.")
        End If
    End Sub


End Class