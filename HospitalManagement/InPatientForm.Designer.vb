<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InPatientForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PatientInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.RoomNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DischargeDateTextBox = New System.Windows.Forms.TextBox()
        Me.RoomNumberLabel = New System.Windows.Forms.Label()
        Me.AdmissionDateTextBox = New System.Windows.Forms.TextBox()
        Me.DischargeDateLabel = New System.Windows.Forms.Label()
        Me.InPatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.AdmissionDateLabel = New System.Windows.Forms.Label()
        Me.InPatientIDLabel = New System.Windows.Forms.Label()
        Me.BillingDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.AttendingPhysicianComboBox = New System.Windows.Forms.ComboBox()
        Me.AttendingPhysicianLabel = New System.Windows.Forms.Label()
        Me.OtherChargesTextBox = New System.Windows.Forms.TextBox()
        Me.ImagingChargesTextBox = New System.Windows.Forms.TextBox()
        Me.LabChargesTextBox = New System.Windows.Forms.TextBox()
        Me.ProcedureChargesTextBox = New System.Windows.Forms.TextBox()
        Me.MedicationChargesTextBox = New System.Windows.Forms.TextBox()
        Me.OtherChargesLabel = New System.Windows.Forms.Label()
        Me.MealChargesTextBox = New System.Windows.Forms.TextBox()
        Me.ImagingChargesLabel = New System.Windows.Forms.Label()
        Me.LabChargesLabel = New System.Windows.Forms.Label()
        Me.ProcedureChargesLabel = New System.Windows.Forms.Label()
        Me.MedicationChargesLabel = New System.Windows.Forms.Label()
        Me.MealChargesLabel = New System.Windows.Forms.Label()
        Me.BedChargesTextBox = New System.Windows.Forms.TextBox()
        Me.BedChargesLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.InsuranceProviderNameLabel = New System.Windows.Forms.Label()
        Me.InsuranceInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.CoverageDetailsComboBox = New System.Windows.Forms.ComboBox()
        Me.CoverageDetailsLabel = New System.Windows.Forms.Label()
        Me.InsurancePolicyNumberTextBox = New System.Windows.Forms.TextBox()
        Me.InsurancePolicyNumberLabel = New System.Windows.Forms.Label()
        Me.InsuranceProviderNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalChargesGroupBox = New System.Windows.Forms.GroupBox()
        Me.PatientResponsibilityTextBox = New System.Windows.Forms.TextBox()
        Me.InsuranceCoveredTextBox = New System.Windows.Forms.TextBox()
        Me.PatientResponsibilityLabel = New System.Windows.Forms.Label()
        Me.InsuranceCoveredLabel = New System.Windows.Forms.Label()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.PaymentOptionsLabel = New System.Windows.Forms.Label()
        Me.PaymentOptionsComboBox = New System.Windows.Forms.ComboBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PatientInformationGroupBox.SuspendLayout()
        Me.BillingDetailsGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.InsuranceInformationGroupBox.SuspendLayout()
        Me.TotalChargesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PatientInformationGroupBox
        '
        Me.PatientInformationGroupBox.Controls.Add(Me.RoomNumberTextBox)
        Me.PatientInformationGroupBox.Controls.Add(Me.DischargeDateTextBox)
        Me.PatientInformationGroupBox.Controls.Add(Me.RoomNumberLabel)
        Me.PatientInformationGroupBox.Controls.Add(Me.AdmissionDateTextBox)
        Me.PatientInformationGroupBox.Controls.Add(Me.DischargeDateLabel)
        Me.PatientInformationGroupBox.Controls.Add(Me.InPatientIDTextBox)
        Me.PatientInformationGroupBox.Controls.Add(Me.AdmissionDateLabel)
        Me.PatientInformationGroupBox.Controls.Add(Me.InPatientIDLabel)
        Me.PatientInformationGroupBox.Location = New System.Drawing.Point(18, 12)
        Me.PatientInformationGroupBox.Name = "PatientInformationGroupBox"
        Me.PatientInformationGroupBox.Size = New System.Drawing.Size(282, 137)
        Me.PatientInformationGroupBox.TabIndex = 0
        Me.PatientInformationGroupBox.TabStop = False
        Me.PatientInformationGroupBox.Text = "Patient Information"
        '
        'RoomNumberTextBox
        '
        Me.RoomNumberTextBox.Location = New System.Drawing.Point(113, 104)
        Me.RoomNumberTextBox.Name = "RoomNumberTextBox"
        Me.RoomNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RoomNumberTextBox.TabIndex = 1
        '
        'DischargeDateTextBox
        '
        Me.DischargeDateTextBox.Location = New System.Drawing.Point(113, 75)
        Me.DischargeDateTextBox.Name = "DischargeDateTextBox"
        Me.DischargeDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DischargeDateTextBox.TabIndex = 1
        '
        'RoomNumberLabel
        '
        Me.RoomNumberLabel.AutoSize = True
        Me.RoomNumberLabel.Location = New System.Drawing.Point(17, 107)
        Me.RoomNumberLabel.Name = "RoomNumberLabel"
        Me.RoomNumberLabel.Size = New System.Drawing.Size(75, 13)
        Me.RoomNumberLabel.TabIndex = 0
        Me.RoomNumberLabel.Text = "Room Number"
        '
        'AdmissionDateTextBox
        '
        Me.AdmissionDateTextBox.Location = New System.Drawing.Point(113, 49)
        Me.AdmissionDateTextBox.Name = "AdmissionDateTextBox"
        Me.AdmissionDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdmissionDateTextBox.TabIndex = 1
        '
        'DischargeDateLabel
        '
        Me.DischargeDateLabel.AutoSize = True
        Me.DischargeDateLabel.Location = New System.Drawing.Point(19, 84)
        Me.DischargeDateLabel.Name = "DischargeDateLabel"
        Me.DischargeDateLabel.Size = New System.Drawing.Size(81, 13)
        Me.DischargeDateLabel.TabIndex = 0
        Me.DischargeDateLabel.Text = "Discharge Date"
        '
        'InPatientIDTextBox
        '
        Me.InPatientIDTextBox.Location = New System.Drawing.Point(113, 26)
        Me.InPatientIDTextBox.Name = "InPatientIDTextBox"
        Me.InPatientIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InPatientIDTextBox.TabIndex = 1
        '
        'AdmissionDateLabel
        '
        Me.AdmissionDateLabel.AutoSize = True
        Me.AdmissionDateLabel.Location = New System.Drawing.Point(17, 56)
        Me.AdmissionDateLabel.Name = "AdmissionDateLabel"
        Me.AdmissionDateLabel.Size = New System.Drawing.Size(80, 13)
        Me.AdmissionDateLabel.TabIndex = 0
        Me.AdmissionDateLabel.Text = "Admission Date"
        '
        'InPatientIDLabel
        '
        Me.InPatientIDLabel.AutoSize = True
        Me.InPatientIDLabel.Location = New System.Drawing.Point(17, 29)
        Me.InPatientIDLabel.Name = "InPatientIDLabel"
        Me.InPatientIDLabel.Size = New System.Drawing.Size(63, 13)
        Me.InPatientIDLabel.TabIndex = 0
        Me.InPatientIDLabel.Text = "InPatient ID"
        '
        'BillingDetailsGroupBox
        '
        Me.BillingDetailsGroupBox.Controls.Add(Me.AttendingPhysicianComboBox)
        Me.BillingDetailsGroupBox.Controls.Add(Me.AttendingPhysicianLabel)
        Me.BillingDetailsGroupBox.Controls.Add(Me.OtherChargesTextBox)
        Me.BillingDetailsGroupBox.Controls.Add(Me.ImagingChargesTextBox)
        Me.BillingDetailsGroupBox.Controls.Add(Me.LabChargesTextBox)
        Me.BillingDetailsGroupBox.Controls.Add(Me.ProcedureChargesTextBox)
        Me.BillingDetailsGroupBox.Controls.Add(Me.MedicationChargesTextBox)
        Me.BillingDetailsGroupBox.Controls.Add(Me.OtherChargesLabel)
        Me.BillingDetailsGroupBox.Controls.Add(Me.MealChargesTextBox)
        Me.BillingDetailsGroupBox.Controls.Add(Me.ImagingChargesLabel)
        Me.BillingDetailsGroupBox.Controls.Add(Me.LabChargesLabel)
        Me.BillingDetailsGroupBox.Controls.Add(Me.ProcedureChargesLabel)
        Me.BillingDetailsGroupBox.Controls.Add(Me.MedicationChargesLabel)
        Me.BillingDetailsGroupBox.Controls.Add(Me.MealChargesLabel)
        Me.BillingDetailsGroupBox.Controls.Add(Me.BedChargesTextBox)
        Me.BillingDetailsGroupBox.Controls.Add(Me.BedChargesLabel)
        Me.BillingDetailsGroupBox.Location = New System.Drawing.Point(18, 155)
        Me.BillingDetailsGroupBox.Name = "BillingDetailsGroupBox"
        Me.BillingDetailsGroupBox.Size = New System.Drawing.Size(282, 256)
        Me.BillingDetailsGroupBox.TabIndex = 1
        Me.BillingDetailsGroupBox.TabStop = False
        Me.BillingDetailsGroupBox.Text = "Billing Details"
        '
        'AttendingPhysicianComboBox
        '
        Me.AttendingPhysicianComboBox.FormattingEnabled = True
        Me.AttendingPhysicianComboBox.Items.AddRange(New Object() {"Paediatrician", "Oncologist", "Neurologist", "Dentist", "Optician", "Gynaecologist"})
        Me.AttendingPhysicianComboBox.Location = New System.Drawing.Point(113, 25)
        Me.AttendingPhysicianComboBox.Name = "AttendingPhysicianComboBox"
        Me.AttendingPhysicianComboBox.Size = New System.Drawing.Size(100, 21)
        Me.AttendingPhysicianComboBox.TabIndex = 3
        '
        'AttendingPhysicianLabel
        '
        Me.AttendingPhysicianLabel.AutoSize = True
        Me.AttendingPhysicianLabel.Location = New System.Drawing.Point(12, 33)
        Me.AttendingPhysicianLabel.Name = "AttendingPhysicianLabel"
        Me.AttendingPhysicianLabel.Size = New System.Drawing.Size(100, 13)
        Me.AttendingPhysicianLabel.TabIndex = 2
        Me.AttendingPhysicianLabel.Text = "Attending Physician"
        '
        'OtherChargesTextBox
        '
        Me.OtherChargesTextBox.Location = New System.Drawing.Point(113, 213)
        Me.OtherChargesTextBox.Name = "OtherChargesTextBox"
        Me.OtherChargesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OtherChargesTextBox.TabIndex = 1
        '
        'ImagingChargesTextBox
        '
        Me.ImagingChargesTextBox.Location = New System.Drawing.Point(113, 187)
        Me.ImagingChargesTextBox.Name = "ImagingChargesTextBox"
        Me.ImagingChargesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImagingChargesTextBox.TabIndex = 1
        '
        'LabChargesTextBox
        '
        Me.LabChargesTextBox.Location = New System.Drawing.Point(113, 159)
        Me.LabChargesTextBox.Name = "LabChargesTextBox"
        Me.LabChargesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LabChargesTextBox.TabIndex = 1
        '
        'ProcedureChargesTextBox
        '
        Me.ProcedureChargesTextBox.Location = New System.Drawing.Point(113, 137)
        Me.ProcedureChargesTextBox.Name = "ProcedureChargesTextBox"
        Me.ProcedureChargesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProcedureChargesTextBox.TabIndex = 1
        '
        'MedicationChargesTextBox
        '
        Me.MedicationChargesTextBox.Location = New System.Drawing.Point(113, 111)
        Me.MedicationChargesTextBox.Name = "MedicationChargesTextBox"
        Me.MedicationChargesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MedicationChargesTextBox.TabIndex = 1
        '
        'OtherChargesLabel
        '
        Me.OtherChargesLabel.AutoSize = True
        Me.OtherChargesLabel.Location = New System.Drawing.Point(13, 220)
        Me.OtherChargesLabel.Name = "OtherChargesLabel"
        Me.OtherChargesLabel.Size = New System.Drawing.Size(75, 13)
        Me.OtherChargesLabel.TabIndex = 0
        Me.OtherChargesLabel.Text = "Other Charges"
        '
        'MealChargesTextBox
        '
        Me.MealChargesTextBox.Location = New System.Drawing.Point(113, 82)
        Me.MealChargesTextBox.Name = "MealChargesTextBox"
        Me.MealChargesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MealChargesTextBox.TabIndex = 1
        '
        'ImagingChargesLabel
        '
        Me.ImagingChargesLabel.AutoSize = True
        Me.ImagingChargesLabel.Location = New System.Drawing.Point(13, 194)
        Me.ImagingChargesLabel.Name = "ImagingChargesLabel"
        Me.ImagingChargesLabel.Size = New System.Drawing.Size(86, 13)
        Me.ImagingChargesLabel.TabIndex = 0
        Me.ImagingChargesLabel.Text = "Imaging Charges"
        '
        'LabChargesLabel
        '
        Me.LabChargesLabel.AutoSize = True
        Me.LabChargesLabel.Location = New System.Drawing.Point(14, 166)
        Me.LabChargesLabel.Name = "LabChargesLabel"
        Me.LabChargesLabel.Size = New System.Drawing.Size(67, 13)
        Me.LabChargesLabel.TabIndex = 0
        Me.LabChargesLabel.Text = "Lab Charges"
        '
        'ProcedureChargesLabel
        '
        Me.ProcedureChargesLabel.AutoSize = True
        Me.ProcedureChargesLabel.Location = New System.Drawing.Point(14, 140)
        Me.ProcedureChargesLabel.Name = "ProcedureChargesLabel"
        Me.ProcedureChargesLabel.Size = New System.Drawing.Size(98, 13)
        Me.ProcedureChargesLabel.TabIndex = 0
        Me.ProcedureChargesLabel.Text = "Procedure Charges"
        '
        'MedicationChargesLabel
        '
        Me.MedicationChargesLabel.AutoSize = True
        Me.MedicationChargesLabel.Location = New System.Drawing.Point(14, 115)
        Me.MedicationChargesLabel.Name = "MedicationChargesLabel"
        Me.MedicationChargesLabel.Size = New System.Drawing.Size(101, 13)
        Me.MedicationChargesLabel.TabIndex = 0
        Me.MedicationChargesLabel.Text = "Medication Charges"
        '
        'MealChargesLabel
        '
        Me.MealChargesLabel.AutoSize = True
        Me.MealChargesLabel.Location = New System.Drawing.Point(13, 89)
        Me.MealChargesLabel.Name = "MealChargesLabel"
        Me.MealChargesLabel.Size = New System.Drawing.Size(72, 13)
        Me.MealChargesLabel.TabIndex = 0
        Me.MealChargesLabel.Text = "Meal Charges"
        '
        'BedChargesTextBox
        '
        Me.BedChargesTextBox.Location = New System.Drawing.Point(113, 52)
        Me.BedChargesTextBox.Name = "BedChargesTextBox"
        Me.BedChargesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BedChargesTextBox.TabIndex = 1
        '
        'BedChargesLabel
        '
        Me.BedChargesLabel.AutoSize = True
        Me.BedChargesLabel.Location = New System.Drawing.Point(13, 59)
        Me.BedChargesLabel.Name = "BedChargesLabel"
        Me.BedChargesLabel.Size = New System.Drawing.Size(68, 13)
        Me.BedChargesLabel.TabIndex = 0
        Me.BedChargesLabel.Text = "Bed Charges"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.InsuranceProviderNameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(376, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 137)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insurance Information"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(145, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'InsuranceProviderNameLabel
        '
        Me.InsuranceProviderNameLabel.AutoSize = True
        Me.InsuranceProviderNameLabel.Location = New System.Drawing.Point(12, 21)
        Me.InsuranceProviderNameLabel.Name = "InsuranceProviderNameLabel"
        Me.InsuranceProviderNameLabel.Size = New System.Drawing.Size(127, 13)
        Me.InsuranceProviderNameLabel.TabIndex = 0
        Me.InsuranceProviderNameLabel.Text = "Insurance Provider Name"
        '
        'InsuranceInformationGroupBox
        '
        Me.InsuranceInformationGroupBox.Controls.Add(Me.CoverageDetailsComboBox)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.CoverageDetailsLabel)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.InsurancePolicyNumberTextBox)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.InsurancePolicyNumberLabel)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.InsuranceProviderNameComboBox)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.Label1)
        Me.InsuranceInformationGroupBox.Location = New System.Drawing.Point(376, 12)
        Me.InsuranceInformationGroupBox.Name = "InsuranceInformationGroupBox"
        Me.InsuranceInformationGroupBox.Size = New System.Drawing.Size(301, 131)
        Me.InsuranceInformationGroupBox.TabIndex = 2
        Me.InsuranceInformationGroupBox.TabStop = False
        Me.InsuranceInformationGroupBox.Text = "Insurance Information"
        '
        'CoverageDetailsComboBox
        '
        Me.CoverageDetailsComboBox.FormattingEnabled = True
        Me.CoverageDetailsComboBox.Items.AddRange(New Object() {"15", "20", "50", "65", "80"})
        Me.CoverageDetailsComboBox.Location = New System.Drawing.Point(145, 84)
        Me.CoverageDetailsComboBox.Name = "CoverageDetailsComboBox"
        Me.CoverageDetailsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CoverageDetailsComboBox.TabIndex = 5
        '
        'CoverageDetailsLabel
        '
        Me.CoverageDetailsLabel.AutoSize = True
        Me.CoverageDetailsLabel.Location = New System.Drawing.Point(12, 90)
        Me.CoverageDetailsLabel.Name = "CoverageDetailsLabel"
        Me.CoverageDetailsLabel.Size = New System.Drawing.Size(102, 13)
        Me.CoverageDetailsLabel.TabIndex = 4
        Me.CoverageDetailsLabel.Text = "Coverage Details(%)"
        '
        'InsurancePolicyNumberTextBox
        '
        Me.InsurancePolicyNumberTextBox.Location = New System.Drawing.Point(145, 53)
        Me.InsurancePolicyNumberTextBox.Name = "InsurancePolicyNumberTextBox"
        Me.InsurancePolicyNumberTextBox.Size = New System.Drawing.Size(121, 20)
        Me.InsurancePolicyNumberTextBox.TabIndex = 3
        '
        'InsurancePolicyNumberLabel
        '
        Me.InsurancePolicyNumberLabel.AutoSize = True
        Me.InsurancePolicyNumberLabel.Location = New System.Drawing.Point(12, 60)
        Me.InsurancePolicyNumberLabel.Name = "InsurancePolicyNumberLabel"
        Me.InsurancePolicyNumberLabel.Size = New System.Drawing.Size(125, 13)
        Me.InsurancePolicyNumberLabel.TabIndex = 2
        Me.InsurancePolicyNumberLabel.Text = "Insurance Policy Number"
        '
        'InsuranceProviderNameComboBox
        '
        Me.InsuranceProviderNameComboBox.FormattingEnabled = True
        Me.InsuranceProviderNameComboBox.Items.AddRange(New Object() {"JUBILEE", "NHIF"})
        Me.InsuranceProviderNameComboBox.Location = New System.Drawing.Point(145, 18)
        Me.InsuranceProviderNameComboBox.Name = "InsuranceProviderNameComboBox"
        Me.InsuranceProviderNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.InsuranceProviderNameComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insurance Provider Name"
        '
        'TotalChargesGroupBox
        '
        Me.TotalChargesGroupBox.Controls.Add(Me.PatientResponsibilityTextBox)
        Me.TotalChargesGroupBox.Controls.Add(Me.InsuranceCoveredTextBox)
        Me.TotalChargesGroupBox.Controls.Add(Me.PatientResponsibilityLabel)
        Me.TotalChargesGroupBox.Controls.Add(Me.InsuranceCoveredLabel)
        Me.TotalChargesGroupBox.Controls.Add(Me.SubTotalTextBox)
        Me.TotalChargesGroupBox.Controls.Add(Me.SubTotalLabel)
        Me.TotalChargesGroupBox.Location = New System.Drawing.Point(376, 155)
        Me.TotalChargesGroupBox.Name = "TotalChargesGroupBox"
        Me.TotalChargesGroupBox.Size = New System.Drawing.Size(301, 111)
        Me.TotalChargesGroupBox.TabIndex = 3
        Me.TotalChargesGroupBox.TabStop = False
        Me.TotalChargesGroupBox.Text = "Total Charges"
        '
        'PatientResponsibilityTextBox
        '
        Me.PatientResponsibilityTextBox.Location = New System.Drawing.Point(145, 79)
        Me.PatientResponsibilityTextBox.Name = "PatientResponsibilityTextBox"
        Me.PatientResponsibilityTextBox.ReadOnly = True
        Me.PatientResponsibilityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PatientResponsibilityTextBox.TabIndex = 1
        '
        'InsuranceCoveredTextBox
        '
        Me.InsuranceCoveredTextBox.Location = New System.Drawing.Point(145, 48)
        Me.InsuranceCoveredTextBox.Name = "InsuranceCoveredTextBox"
        Me.InsuranceCoveredTextBox.ReadOnly = True
        Me.InsuranceCoveredTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InsuranceCoveredTextBox.TabIndex = 1
        '
        'PatientResponsibilityLabel
        '
        Me.PatientResponsibilityLabel.AutoSize = True
        Me.PatientResponsibilityLabel.Location = New System.Drawing.Point(12, 86)
        Me.PatientResponsibilityLabel.Name = "PatientResponsibilityLabel"
        Me.PatientResponsibilityLabel.Size = New System.Drawing.Size(107, 13)
        Me.PatientResponsibilityLabel.TabIndex = 0
        Me.PatientResponsibilityLabel.Text = "Patient Responsibility"
        '
        'InsuranceCoveredLabel
        '
        Me.InsuranceCoveredLabel.AutoSize = True
        Me.InsuranceCoveredLabel.Location = New System.Drawing.Point(12, 55)
        Me.InsuranceCoveredLabel.Name = "InsuranceCoveredLabel"
        Me.InsuranceCoveredLabel.Size = New System.Drawing.Size(97, 13)
        Me.InsuranceCoveredLabel.TabIndex = 0
        Me.InsuranceCoveredLabel.Text = "Insurance Covered"
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Location = New System.Drawing.Point(145, 18)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubTotalTextBox.TabIndex = 1
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Location = New System.Drawing.Point(12, 21)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(53, 13)
        Me.SubTotalLabel.TabIndex = 0
        Me.SubTotalLabel.Text = "Sub Total"
        '
        'PaymentOptionsLabel
        '
        Me.PaymentOptionsLabel.AutoSize = True
        Me.PaymentOptionsLabel.Location = New System.Drawing.Point(373, 330)
        Me.PaymentOptionsLabel.Name = "PaymentOptionsLabel"
        Me.PaymentOptionsLabel.Size = New System.Drawing.Size(87, 13)
        Me.PaymentOptionsLabel.TabIndex = 4
        Me.PaymentOptionsLabel.Text = "Payment Options"
        '
        'PaymentOptionsComboBox
        '
        Me.PaymentOptionsComboBox.FormattingEnabled = True
        Me.PaymentOptionsComboBox.Items.AddRange(New Object() {"Cash", "Cheque", "Credit Card", "Payment Plan"})
        Me.PaymentOptionsComboBox.Location = New System.Drawing.Point(521, 327)
        Me.PaymentOptionsComboBox.Name = "PaymentOptionsComboBox"
        Me.PaymentOptionsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PaymentOptionsComboBox.TabIndex = 5
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(81, 425)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(354, 425)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 7
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(602, 425)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'InPatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PaymentOptionsComboBox)
        Me.Controls.Add(Me.PaymentOptionsLabel)
        Me.Controls.Add(Me.TotalChargesGroupBox)
        Me.Controls.Add(Me.InsuranceInformationGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BillingDetailsGroupBox)
        Me.Controls.Add(Me.PatientInformationGroupBox)
        Me.Name = "InPatientForm"
        Me.Text = "InPatientForm"
        Me.PatientInformationGroupBox.ResumeLayout(False)
        Me.PatientInformationGroupBox.PerformLayout()
        Me.BillingDetailsGroupBox.ResumeLayout(False)
        Me.BillingDetailsGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.InsuranceInformationGroupBox.ResumeLayout(False)
        Me.InsuranceInformationGroupBox.PerformLayout()
        Me.TotalChargesGroupBox.ResumeLayout(False)
        Me.TotalChargesGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatientInformationGroupBox As GroupBox
    Friend WithEvents RoomNumberTextBox As TextBox
    Friend WithEvents DischargeDateTextBox As TextBox
    Friend WithEvents RoomNumberLabel As Label
    Friend WithEvents AdmissionDateTextBox As TextBox
    Friend WithEvents DischargeDateLabel As Label
    Friend WithEvents InPatientIDTextBox As TextBox
    Friend WithEvents AdmissionDateLabel As Label
    Friend WithEvents InPatientIDLabel As Label
    Friend WithEvents BillingDetailsGroupBox As GroupBox
    Friend WithEvents BedChargesLabel As Label
    Friend WithEvents OtherChargesTextBox As TextBox
    Friend WithEvents ImagingChargesTextBox As TextBox
    Friend WithEvents LabChargesTextBox As TextBox
    Friend WithEvents ProcedureChargesTextBox As TextBox
    Friend WithEvents MedicationChargesTextBox As TextBox
    Friend WithEvents OtherChargesLabel As Label
    Friend WithEvents MealChargesTextBox As TextBox
    Friend WithEvents ImagingChargesLabel As Label
    Friend WithEvents LabChargesLabel As Label
    Friend WithEvents ProcedureChargesLabel As Label
    Friend WithEvents MedicationChargesLabel As Label
    Friend WithEvents MealChargesLabel As Label
    Friend WithEvents BedChargesTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents InsuranceProviderNameLabel As Label
    Friend WithEvents InsuranceInformationGroupBox As GroupBox
    Friend WithEvents CoverageDetailsComboBox As ComboBox
    Friend WithEvents CoverageDetailsLabel As Label
    Friend WithEvents InsurancePolicyNumberTextBox As TextBox
    Friend WithEvents InsurancePolicyNumberLabel As Label
    Friend WithEvents InsuranceProviderNameComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalChargesGroupBox As GroupBox
    Friend WithEvents SubTotalLabel As Label
    Friend WithEvents PatientResponsibilityTextBox As TextBox
    Friend WithEvents InsuranceCoveredTextBox As TextBox
    Friend WithEvents PatientResponsibilityLabel As Label
    Friend WithEvents InsuranceCoveredLabel As Label
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents PaymentOptionsLabel As Label
    Friend WithEvents PaymentOptionsComboBox As ComboBox
    Friend WithEvents AttendingPhysicianComboBox As ComboBox
    Friend WithEvents AttendingPhysicianLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents SaveButton As Button
End Class
