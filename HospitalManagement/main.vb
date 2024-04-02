Imports System.Data.OleDb

Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\HospitalManagement.accdb"

        ' SQL query to select all records from the table
        Dim query As String = "SELECT * FROM PatientInformation"

        ' Create a new connection to the database
        Using connection As New OleDbConnection(connectionString)
            ' Create a DataAdapter to fetch data from the database
            Using adapter As New OleDbDataAdapter(query, connection)
                ' Create a new DataSet to hold the retrieved data
                Dim dataSet As New DataSet()

                ' Fill the DataSet with data from the database
                adapter.Fill(dataSet, "PatientInformation")

                ' Bind the DataSet to the DataGridView
                DataGridView1.DataSource = dataSet.Tables("PatientInformation")

            End Using
        End Using
    End Sub

    Private Sub PatientLabel_Click(sender As Object, e As EventArgs) Handles PatientLabel.Click
        Dim newForm As New PatientProfileForm()
        newForm.Show()

    End Sub
    Private Sub OutpatientLabel_Click(sender As Object, e As EventArgs) Handles OutpatientLabel.Click
        Dim newForm As New OutPatientForm()
        newForm.Show()

    End Sub

    Private Sub ReloadButton_Click(sender As Object, e As EventArgs) Handles ReloadButton.Click


        Dim newForm As New main()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub PaymentReportLabel_Click(sender As Object, e As EventArgs) Handles PaymentReportLabel.Click
        Dim newForm As New OutPatientReportForm()
        newForm.Show()
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim newForm As New InPatientForm()
        newForm.Show()
    End Sub

    Private Sub InPatientReportLabel_Click(sender As Object, e As EventArgs) Handles InPatientReportLabel.Click
        Dim newForm As New InPatientReportForm()
        newForm.Show()
    End Sub
End Class