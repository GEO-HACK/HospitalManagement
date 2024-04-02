Imports System.Data.OleDb

Public Class InPatientReportForm
    Private Sub InPatientReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\HospitalManagement.accdb"

        ' SQL query to select all records from the table
        Dim query As String = "SELECT * FROM InPatientForm"

        ' Create a new connection to the database
        Using connection As New OleDbConnection(connectionString)
            ' Create a DataAdapter to fetch data from the database
            Using adapter As New OleDbDataAdapter(query, connection)
                ' Create a new DataSet to hold the retrieved data
                Dim dataSet As New DataSet()

                ' Fill the DataSet with data from the database
                adapter.Fill(dataSet, "InPatientForm")

                ' Bind the DataSet to the DataGridView
                DataGridView1.DataSource = dataSet.Tables("InPatientForm")

            End Using
        End Using
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class