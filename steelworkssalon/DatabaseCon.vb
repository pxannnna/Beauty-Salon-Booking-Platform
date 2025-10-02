Imports System.Data.Common
Imports System.Data.OleDb
'module to make operations with database
'it makes the process of saving, retireving, updating and deleting details faster and easier
Public Class DatabaseCon

    'Instantiates a new Database Connection object
    Private Con As New OleDb.OleDbConnection

    'Instantiates a new List Array object to hold table column names
    Private strList As New List(Of String)

    'Declares an integer variable to hold the ID value for records held in database tables
    Private intID As Integer = 0
    Public dataset As New DataSet

    'Makes the identifiers for the database provider technology and file name available throughout the program
    Public dbProvider As String
    Public dbSource As String

    ' Retrieves the maximum number of rows from the dataset
    Public Function GetMaxRows() As Integer
        Return intMaxRows
    End Function

    Private dataadapter As OleDbDataAdapter

    'Connects to the database using a SQL string and table name and fills a dataset
    Public Sub dbConnect(ByVal strSQL As String, ByRef strTable As String)

        'Identifies the database technology being used, Microsoft Access in this case
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"

        'Identifies the database file name being used
        dbSource = "Data Source = Users.accdb"

        'Combines the database provider and source into the required connection string
        Con.ConnectionString = dbProvider & dbSource

        'Opens the database connection
        Con.Open()

        'Instanciates the Data Adapter object and assigns the SQL string and database connection parameters to it
        dataadapter = New OleDbDataAdapter(strSQL, Con)

        'Clear the contents of the dataset
        dataset.Reset()

        'Uses the Data Adapter to fill the Dataset with the data retrieved from the database
        dataadapter.Fill(dataset, strTable)

        'Retrieves the Max Rows of the dataset retrieved from the database
        intMaxRows = DataSet.Tables(strTable).Rows.Count

        'Closes the database connectionSystem.Data.OleDb.OleDbException: 'No value given for one or more required parameters.'

        Con.Close()
    End Sub

    'Searches a specified table for a specific field and assigns an ID value to be used when adding a new record
    Public Sub GetID(ByVal strSQL As String, ByRef strTable As String, ByRef strField As String)
        Dim intID As Integer = 0

        'Calls the dbConnect subroutine
        dbConnect(strSQL, strTable)

        'Checks that the table isn't empty
        If intMaxRows > 0 Then

            Try
                'If a record already exists in the table retrieve the ID value 
                intID = Convert.ToInt32(dataset.Tables(strTable).Rows(0).Item(strField))

                'Increment the intID
                intID += 1

                'Catch any errors that might occur from an empty database
            Catch ex As Exception

                'Set the intID value to 1
                intID = 1

            End Try
        End If
    End Sub

    'Uses a SQL string to fill a data table
    Public Sub FillDataTable(ByVal strSQL As String)

        Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")

        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"
        If dtb Is Nothing Then
            dtb = New DataTable()
        End If
        'Use database connection to fill the DataTable
        Using Con As New OleDb.OleDbConnection(connectionString)
            'Open database connection
            Con.Open()

            'Clear DataTable contents
            dtb.Reset()


            'Instantiate a new DataAdapter object to be the interface between the database and the DataTable
            Using dataadapter As New OleDb.OleDbDataAdapter(strSQL, Con)
                'Use the DataAdapter to fill the DataTable
                dataadapter.Fill(dtb)
            End Using
            'Close the database connection
            Con.Close()
        End Using

        'Retrieves the Max Rows of the DataTable filled from the database
        intMaxRows = dtb.Rows.Count
    End Sub

    'Retrieves a list a field names from a specified table
    Public Sub GetFields(ByVal strSQL As String, ByRef strTable As String)

        'Call the FillDataTable method
        FillDataTable(strSQL)

        'Reset intCounter value to 0
        intCounter = 0
        'Retrieve the column/field names from the DataTable
        For Each column As DataColumn In dtb.Columns
            'Add the column/field names to the list object
            strList.Add(column.ColumnName)
            'Increment the intCounter with each item added
            intCounter += 1
        Next

    End Sub

    'Adds a record to a table. Requires a table name, primary key field name, and values of fields being added (in same order as columns in table) as parameters
    Public Sub AddRecord(ByVal strSQL As String, ByRef strTable As String, ByVal strFieldName As String, ParamArray strFieldValue() As String)

        'Declare a counter variable to track the field values being added via the Parameter Array
        Dim intFieldCounter As Integer = 0

        'Call the GetFields routine to retrieve database table fields
        GetFields(strSQL, strTable)
        'Call the GetID routine to determine what value the record ID must be
        GetID("SELECT MAX (" & strFieldName & ") as [" & strFieldName & "] FROM " & strTable & "", strTable, strFieldName)

        'Calls the dbConnect routine using the SQL statement and table name as parameters
        dbConnect(strSQL, strTable)

        'Sets the counter to 0
        intCounter = 0

        'Instantiates the data adapter to perform the update to the dataset
        Dim userCommandBuilder As New OleDb.OleDbCommandBuilder(DataAdapter)

        'Assign Quote Prefix/Suffix properties to simpify SQL string concatenation
        userCommandBuilder.QuotePrefix = "["
        userCommandBuilder.QuoteSuffix = "]"

        'Declares a DataRow variable to hold the new record details
        Dim rowNewDataRow As DataRow

        'Assigns the DataRow to the table in the dataset
        rowNewDataRow = DataSet.Tables(strTable).NewRow()

        'Assigns the values to each of the fields in the data row
        'Assigns the value from intID to the ID field
        rowNewDataRow.Item(strFieldName) = intID

        'Assign the values for each field in turn
        'Add items to datarow equivalent in number to Field Values passed via Parameter Array, skipping table ID field
        For intCounter As Integer = 1 To strFieldValue.Count
            'Add item to DataRow using items in list as field names and Parameter Array values as values
            rowNewDataRow.Item(strList.Item(intCounter).ToString) = strFieldValue(intFieldCounter)
            'Increment Parameter Array counter
            intFieldCounter += 1
        Next

        'Adds the datarow contents to the dataset
        DataSet.Tables(strTable).Rows.Add(rowNewDataRow)

        'Uses the Data Adapter as the link to update the table with the dataset
        DataAdapter.Update(DataSet, strTable)

    End Sub

    'Updates a record after being passed a SQL string, primary key field name, and field values as parameters
    Public Sub UpdateRecord(ByVal strSQL As String, ByRef strTable As String, ByVal strFieldName As String, ParamArray strFieldValue() As String)

        'Declare a counter variable to track the field values being entered into the dataset
        Dim intFieldCounter As Integer = 0

        'Retrieve the fields from the table being updated
        GetFields(strSQL, strTable)

        'Connect to the database using the SQL string and table name as paramters
        dbConnect(strSQL, strTable)

        'Initialise intCounter to 0
        intCounter = 0

        'Instantiate a new Command Builder object used to update the record
        Dim userCommandBuilder As New OleDb.OleDbCommandBuilder(DataAdapter)

        'Assign Quote Prefix/Suffix properties to simpify SQL string concatenation
        userCommandBuilder.QuotePrefix = "["
        userCommandBuilder.QuoteSuffix = "]"

        'Add items to dataset equivalent to number of Field Values passed via Parameter Array
        For intCounter As Integer = 0 To strFieldValue.Count - 1
            'Add item to DataRow using items in list as field names and Parameter Array values as values
            DataSet.Tables(strTable).Rows(0).Item(strList.Item(intCounter)) = strFieldValue(intFieldCounter)

            'Increment the Parameter Array counter
            intFieldCounter += 1
        Next

        'Update the table with the dataset contents using the data adapter
        DataAdapter.Update(DataSet, strTable)
    End Sub

    'Deletes a record using a SQL string, table name, primary key field name, and value of primary key field for selected record
    Public Sub DeleteRecord(ByVal strSQL As String, ByRef strTable As String, ByVal strFieldName As String, ByVal intFieldValue As Integer)

        'Identifies the database technology being used, Microsoft Access in this case
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        'Identifies the database file name being used
        dbSource = "Data Source = Users.accdb"

        'Combine the provider and source into a connection string
        Dim connectionString As String = dbProvider & dbSource

        'Use database connection within a Using block to ensure it is closed and disposed
        Using Con As New OleDbConnection(connectionString)
            'Open the connection
            Con.Open()

            'Instantiate a new Delete Command object within a Using block to ensure it is disposed
            Using command As New OleDbCommand("DELETE * FROM " & strTable & " WHERE " & strFieldName & " = " & intFieldValue, Con)
                'Execute the Delete Command
                command.ExecuteNonQuery()
            End Using
        End Using ' The connection is automatically closed and disposed here, even if an exception occurs

    End Sub

End Class

