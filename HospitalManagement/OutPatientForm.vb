Imports System.Data.OleDb

Public Class OutPatientForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\HospitalManagement.accdb"

        ' SQL query to insert data into the table
        Dim query As String = "insert into OutPatientForm (AttendingPhysician,ConsultationFee, ProcedureCharges, LabCharges, ImagingCharges, OtherCharges, InsuranceProvider, InsuranceNumber, CoveragePercentage, SubTotal, InsuranceCovered, PatientResponsibility,PaymentOptions) 
         VALUES ('" + AttendingPhysicianComboBox.SelectedItem + "','" + ConsultationFeeTextBox.Text + "','" + ProcedureChargesTextBox.Text + "','" + LabChargesTextBox.Text + "','" + ImagingChargesTextBox.Text + "','" + OtherChargesTextBox.Text + "','" + InsuranceProviderComboBox.SelectedItem + "','" + InsuranceTextBox.Text + "','" + CoveragePercentageComboBox.SelectedItem + "','" + SubTotalTextBox.Text + "','" + InsuranceCoveredTextBox.Text + "','" + PatientResponsibilityTextBox.Text + "','" + PaymentOptionsComboBox.SelectedItem + "')"


        ' Create a new OleDbConnection object
        Using connection As New OleDbConnection(connectionString)
            ' Create a new OleDbCommand object with the query and connection
            Dim command As New OleDbCommand(query, connection)

            'Set parameter values
            command.Parameters.AddWithValue("@AttendingPhysician", AttendingPhysicianComboBox.SelectedItem.ToString())
            command.Parameters.AddWithValue("@ConsultationFee", ConsultationFeeTextBox.Text)
            command.Parameters.AddWithValue("@ProcedureCharges", ProcedureChargesTextBox.Text)
            command.Parameters.AddWithValue("@LabCharges", LabChargesTextBox.Text)
            command.Parameters.AddWithValue("@ImagingCharges", ImagingChargesTextBox.Text)
            command.Parameters.AddWithValue("@OtherCharges", OtherChargesTextBox.Text)
            command.Parameters.AddWithValue("@InsuranceProvider", InsuranceProviderComboBox.SelectedItem)
            command.Parameters.AddWithValue("@InsuranceNumber", InsuranceTextBox.Text)
            command.Parameters.AddWithValue("@CoveragePercentage", CoveragePercentageComboBox.SelectedItem)
            command.Parameters.AddWithValue("@SubTotal", SubTotalTextBox.Text)
            command.Parameters.AddWithValue("@InsuranceCovered", InsuranceCoveredTextBox.Text)
            command.Parameters.AddWithValue("@PatientResponsibility", PatientResponsibilityTextBox.Text)
            command.Parameters.AddWithValue("@PaymentOptions", PaymentOptionsComboBox.SelectedItem)



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

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim consultationFee As Decimal = Decimal.Parse(ConsultationFeeTextBox.Text)
        Dim procedureCharges As Decimal = Decimal.Parse(ProcedureChargesTextBox.Text)
        Dim labCharges As Decimal = Decimal.Parse(LabChargesTextBox.Text)
        Dim imagingCharges As Decimal = Decimal.Parse(ImagingChargesTextBox.Text)
        Dim otherCharges As Decimal = Decimal.Parse(OtherChargesTextBox.Text)

        ' Retrieve the selected coverage percentage
        Dim selectedPercentage As Decimal = Decimal.Parse(CoveragePercentageComboBox.SelectedItem.ToString()) / 100

        ' Calculate subtotal
        Dim subTotal As Decimal = Decimal.Parse(ConsultationFeeTextBox.Text) +
                                  Decimal.Parse(ProcedureChargesTextBox.Text) +
                                  Decimal.Parse(LabChargesTextBox.Text) +
                                  Decimal.Parse(ImagingChargesTextBox.Text) +
                                  Decimal.Parse(OtherChargesTextBox.Text)


        ' Calculate insurance covered amount
        Dim insuranceCovered As Decimal = subTotal * selectedPercentage

        ' Calculate patient responsibility
        Dim patientResponsibility As Decimal = subTotal - insuranceCovered

        ' Display the calculated values
        SubTotalTextBox.Text = subTotal.ToString()
        InsuranceCoveredTextBox.Text = insuranceCovered.ToString()
        PatientResponsibilityTextBox.Text = patientResponsibility.ToString()
    End Sub
End Class