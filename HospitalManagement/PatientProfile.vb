
Imports System.Data.OleDb
Public Class PatientProfileForm

    Private Sub InpatientButton_Click(sender As Object, e As EventArgs) Handles InpatientButton.Click
        Dim newForm As New InPatientForm()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub OutpatientButton_Click(sender As Object, e As EventArgs) Handles OutpatientButton.Click
        Dim newForm As New OutPatientForm()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\HospitalManagement.accdb"

        ' SQL query to insert data into the table
        Dim query As String = "insert into PatientInformation (FullName, Age, PhoneNumber ,Email ,Address ,Gender ,MaritalStatus ,DOB) 
         VALUES ('" + FullPatientNameTextBox.Text + "','" + AgeTextBox.Text + "','" + PhoneNumberTextBox.Text + "','" + EmailPatientTextBox.Text + "','" + AddressTextBox.Text + "','" + GenderTextBox.Text + "','" + MaritalStatusComboBox.SelectedItem + "','" + DOBTextBox.Text + "')"


        ' Create a new OleDbConnection object
        Using connection As New OleDbConnection(connectionString)
            ' Create a new OleDbCommand object with the query and connection
            Dim command As New OleDbCommand(query, connection)

            'Set parameter values
            command.Parameters.AddWithValue("FullName", FullPatientNameTextBox.Text)
            command.Parameters.AddWithValue("Age", AgeTextBox.Text)
            command.Parameters.AddWithValue("PhoneNumber", PhoneNumberTextBox.Text)
            command.Parameters.AddWithValue("Email", EmailPatientTextBox.Text)
            command.Parameters.AddWithValue("Address", AddressTextBox.Text)


            Try
                ' Open the connection
                connection.Open()

                ' Execute the command to insert data into the database
                command.ExecuteNonQuery()

                ' Display a success message to the user
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Display an error message if an exception occurs
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End Using
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


End Class
