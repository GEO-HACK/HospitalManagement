Imports System.Data.OleDb

Public Class InPatientForm
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\HospitalManagement.accdb"

        ' SQL query to insert data into the table
        Dim query As String = "insert into InPatientForm (AdmissionDate, DischargeDate, RoomNumber, AttendingPhysician, BedCharges, MealCharges, MedicationCharges, ProcedureCharges, LabCharges, ImagingCharges, OtherCharges, InsuranceProviderName, InsurancePolicyNumber,CoverageDetails, SubTotal, InsuranceCovered,PatientResponsibility,PaymentOptions) 
         VALUES ('" + AdmissionDateTextBox.Text + "','" + DischargeDateTextBox.Text + "','" + RoomNumberTextBox.Text + "','" + AttendingPhysicianComboBox.SelectedItem + "','" + BedChargesTextBox.Text + "','" + MealChargesTextBox.Text + "','" + MedicationChargesTextBox.Text + "','" + ProcedureChargesTextBox.Text + "','" + LabChargesTextBox.Text + "','" + ImagingChargesTextBox.Text + "','" + OtherChargesTextBox.Text + "','" + InsuranceProviderNameComboBox.SelectedItem + "','" + InsurancePolicyNumberTextBox.Text + "','" + CoverageDetailsComboBox.SelectedItem + "','" + SubTotalTextBox.Text + "','" + InsuranceCoveredTextBox.Text + "','" + PatientResponsibilityTextBox.Text + "','" + PaymentOptionsComboBox.SelectedItem + "')"


        ' Create a new OleDbConnection object
        Using connection As New OleDbConnection(connectionString)
            ' Create a new OleDbCommand object with the query and connection
            Dim command As New OleDbCommand(query, connection)

            'Set parameter values
            command.Parameters.AddWithValue("@AdmissionDate", AdmissionDateTextBox.Text)
            command.Parameters.AddWithValue("@DischargeDate", DischargeDateTextBox.Text)
            command.Parameters.AddWithValue("@RoomNumber", RoomNumberTextBox.Text)
            command.Parameters.AddWithValue("@AttendingPhysician", AttendingPhysicianComboBox.SelectedItem.ToString())
            command.Parameters.AddWithValue("@BedCharges", BedChargesTextBox.Text)
            command.Parameters.AddWithValue("@MealCharges", MealChargesTextBox.Text)
            command.Parameters.AddWithValue("@MedicationCharges", MedicationChargesTextBox.Text)
            command.Parameters.AddWithValue("@ProcedureCharges", ProcedureChargesTextBox.Text)
            command.Parameters.AddWithValue("@LabCharges", LabChargesTextBox.Text)
            command.Parameters.AddWithValue("@ImagingCharges", ImagingChargesTextBox.Text)
            command.Parameters.AddWithValue("@OtherCharges", OtherChargesTextBox.Text)
            command.Parameters.AddWithValue("@InsuranceProviderName", InsuranceProviderNameComboBox.SelectedItem.ToString())
            command.Parameters.AddWithValue("@InsurancePolicyNumber", InsurancePolicyNumberTextBox.Text)
            command.Parameters.AddWithValue("@CoverageDetails", CoverageDetailsComboBox.SelectedItem.ToString())
            command.Parameters.AddWithValue("@SubTotal", SubTotalTextBox.Text)
            command.Parameters.AddWithValue("@InsuranceCovered", InsuranceCoveredTextBox.Text)
            command.Parameters.AddWithValue("@PatientResponsibility", PatientResponsibilityTextBox.Text)
            command.Parameters.AddWithValue("@PaymentOptions", PaymentOptionsComboBox.SelectedItem.ToString())




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

        ' Variables to hold the amounts
        Dim bedAmount, mealAmount, procedureAmount, labAmount, imagingAmount, medicationAmount, otherAmount As Double

        ' Check if the text boxes are empty
        If String.IsNullOrEmpty(BedChargesTextBox.Text) OrElse
        String.IsNullOrEmpty(MealChargesTextBox.Text) OrElse
        String.IsNullOrEmpty(ProcedureChargesTextBox.Text) OrElse
        String.IsNullOrEmpty(LabChargesTextBox.Text) OrElse
        String.IsNullOrEmpty(ImagingChargesTextBox.Text) OrElse
        String.IsNullOrEmpty(MedicationChargesTextBox.Text) OrElse
        String.IsNullOrEmpty(OtherChargesTextBox.Text) Then
            MessageBox.Show("Please fill all the charges.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Parse the amounts from the text boxes
        Double.TryParse(BedChargesTextBox.Text, bedAmount)
        Double.TryParse(MealChargesTextBox.Text, mealAmount)
        Double.TryParse(ProcedureChargesTextBox.Text, procedureAmount)
        Double.TryParse(LabChargesTextBox.Text, labAmount)
        Double.TryParse(ImagingChargesTextBox.Text, imagingAmount)
        Double.TryParse(MedicationChargesTextBox.Text, medicationAmount)
        Double.TryParse(OtherChargesTextBox.Text, otherAmount)

        ' Calculate subtotal
        Dim subtotal As Double = bedAmount + mealAmount + procedureAmount + labAmount + imagingAmount + medicationAmount + otherAmount

        ' Display subtotal
        SubTotalTextBox.Text = subtotal.ToString("0.00")
        ' Get the subtotal from the input
        ' Dim subtotal As Double = Double.Parse(SubtotalTextBox.Text)

        ' Get the insurance coverage percentage from the input
        Dim insuranceCoveragePercentage As Double = Double.Parse(CoverageDetailsComboBox.SelectedItem.ToString()) / 100

        ' Calculate insurance coverage
        Dim insuranceCoverage As Double = subtotal * insuranceCoveragePercentage

        ' Calculate patient's responsibility
        Dim patientResponsibility As Double = subtotal - insuranceCoverage

        ' Display the results
        InsuranceCoveredTextBox.Text = insuranceCoverage.ToString("0.00")
        PatientResponsibilityTextBox.Text = patientResponsibility.ToString("0.00")


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class