Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
'the module that stores all necessary variables

Module Module1
    Dim dbFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Users.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};Persist Security Info=False;"
    Dim con As New OleDbConnection(connectionString)
    'Public userfile As String
    'Public tempfile As String
    Public mysecurity As Integer
    Public myusername As String
    Public mycustomerid As String
    Public mystaffid As String
    Public mysalary As String
    'Declares a DataAdapter object to serve as the link between the DataSet and the Database
    Public dataadapter As OleDb.OleDbDataAdapter
    'Instantiates a DataSet object to hold the data retrieved from the database by various routines throughout the program
    Public dataset As New DataSet
    'Declares a counter variable that is accessible throughout the program to facilitate a number of processes
    Public intCounter As Integer
    'Declares a Max Rows variable to be used in various routines in the program where records are retrieved from the database
    Public intMaxRows As Integer
    'Instantates a DataTable object which will be filled with records from the database
    Public dtb As New DataTable

    Public Function queryasdatatable(ByVal sql As String) As DataTable
        Dim da As New OleDbDataAdapter(sql, con)
        Dim ds As New DataSet
        da.Fill(ds, "result")
        Return ds.Tables("result")
    End Function




End Module
