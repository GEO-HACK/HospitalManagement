<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutPatientForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PateintIDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AttendingPhysicianComboBox = New System.Windows.Forms.ComboBox()
        Me.OtherChargesTextBox = New System.Windows.Forms.TextBox()
        Me.ImagingChargesTextBox = New System.Windows.Forms.TextBox()
        Me.LabChargesTextBox = New System.Windows.Forms.TextBox()
        Me.ProcedureChargesTextBox = New System.Windows.Forms.TextBox()
        Me.ConsultationFeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImagingChargesLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ConsultationFeeLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InsuranceInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.CoveragePercentageComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.InsuranceProviderComboBox = New System.Windows.Forms.ComboBox()
        Me.InsuranceTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PatientResponsibilityTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.InsuranceCoveredTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PaymentOptionsLabel = New System.Windows.Forms.Label()
        Me.PaymentOptionsComboBox = New System.Windows.Forms.ComboBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.InsuranceInformationGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PatientID"
        '
        'PateintIDTextBox
        '
        Me.PateintIDTextBox.Location = New System.Drawing.Point(130, 34)
        Me.PateintIDTextBox.Name = "PateintIDTextBox"
        Me.PateintIDTextBox.Size = New System.Drawing.Size(122, 20)
        Me.PateintIDTextBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.AttendingPhysicianComboBox)
        Me.GroupBox1.Controls.Add(Me.OtherChargesTextBox)
        Me.GroupBox1.Controls.Add(Me.ImagingChargesTextBox)
        Me.GroupBox1.Controls.Add(Me.LabChargesTextBox)
        Me.GroupBox1.Controls.Add(Me.ProcedureChargesTextBox)
        Me.GroupBox1.Controls.Add(Me.ConsultationFeeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ImagingChargesLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ConsultationFeeLabel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 265)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billing Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Other Charges"
        '
        'AttendingPhysicianComboBox
        '
        Me.AttendingPhysicianComboBox.FormattingEnabled = True
        Me.AttendingPhysicianComboBox.Items.AddRange(New Object() {"Paediatrician", "Oncologist", "Neurologist", "Dentist", "Optician", "Gynaecologist", ""})
        Me.AttendingPhysicianComboBox.Location = New System.Drawing.Point(126, 31)
        Me.AttendingPhysicianComboBox.Name = "AttendingPhysicianComboBox"
        Me.AttendingPhysicianComboBox.Size = New System.Drawing.Size(130, 21)
        Me.AttendingPhysicianComboBox.TabIndex = 2
        '
        'OtherChargesTextBox
        '
        Me.OtherChargesTextBox.Location = New System.Drawing.Point(126, 228)
        Me.OtherChargesTextBox.Name = "OtherChargesTextBox"
        Me.OtherChargesTextBox.Size = New System.Drawing.Size(130, 20)
        Me.OtherChargesTextBox.TabIndex = 1
        '
        'ImagingChargesTextBox
        '
        Me.ImagingChargesTextBox.Location = New System.Drawing.Point(126, 187)
        Me.ImagingChargesTextBox.Name = "ImagingChargesTextBox"
        Me.ImagingChargesTextBox.Size = New System.Drawing.Size(130, 20)
        Me.ImagingChargesTextBox.TabIndex = 1
        '
        'LabChargesTextBox
        '
        Me.LabChargesTextBox.Location = New System.Drawing.Point(126, 150)
        Me.LabChargesTextBox.Name = "LabChargesTextBox"
        Me.LabChargesTextBox.Size = New System.Drawing.Size(130, 20)
        Me.LabChargesTextBox.TabIndex = 1
        '
        'ProcedureChargesTextBox
        '
        Me.ProcedureChargesTextBox.Location = New System.Drawing.Point(126, 109)
        Me.ProcedureChargesTextBox.Name = "ProcedureChargesTextBox"
        Me.ProcedureChargesTextBox.Size = New System.Drawing.Size(130, 20)
        Me.ProcedureChargesTextBox.TabIndex = 1
        '
        'ConsultationFeeTextBox
        '
        Me.ConsultationFeeTextBox.Location = New System.Drawing.Point(126, 68)
        Me.ConsultationFeeTextBox.Name = "ConsultationFeeTextBox"
        Me.ConsultationFeeTextBox.Size = New System.Drawing.Size(130, 20)
        Me.ConsultationFeeTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 0
        '
        'ImagingChargesLabel
        '
        Me.ImagingChargesLabel.AutoSize = True
        Me.ImagingChargesLabel.Location = New System.Drawing.Point(20, 190)
        Me.ImagingChargesLabel.Name = "ImagingChargesLabel"
        Me.ImagingChargesLabel.Size = New System.Drawing.Size(86, 13)
        Me.ImagingChargesLabel.TabIndex = 0
        Me.ImagingChargesLabel.Text = "Imaging Charges"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Lab Charges"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Procedures Charges"
        '
        'ConsultationFeeLabel
        '
        Me.ConsultationFeeLabel.AutoSize = True
        Me.ConsultationFeeLabel.Location = New System.Drawing.Point(20, 75)
        Me.ConsultationFeeLabel.Name = "ConsultationFeeLabel"
        Me.ConsultationFeeLabel.Size = New System.Drawing.Size(77, 13)
        Me.ConsultationFeeLabel.TabIndex = 0
        Me.ConsultationFeeLabel.Text = "Consultion Fee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Attending Physician"
        '
        'InsuranceInformationGroupBox
        '
        Me.InsuranceInformationGroupBox.Controls.Add(Me.CoveragePercentageComboBox)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.Label9)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.InsuranceProviderComboBox)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.InsuranceTextBox)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.Label8)
        Me.InsuranceInformationGroupBox.Controls.Add(Me.Label7)
        Me.InsuranceInformationGroupBox.Location = New System.Drawing.Point(440, 37)
        Me.InsuranceInformationGroupBox.Name = "InsuranceInformationGroupBox"
        Me.InsuranceInformationGroupBox.Size = New System.Drawing.Size(326, 133)
        Me.InsuranceInformationGroupBox.TabIndex = 3
        Me.InsuranceInformationGroupBox.TabStop = False
        Me.InsuranceInformationGroupBox.Text = "Insurance Information"
        '
        'CoveragePercentageComboBox
        '
        Me.CoveragePercentageComboBox.FormattingEnabled = True
        Me.CoveragePercentageComboBox.Items.AddRange(New Object() {"15", "20", "50", "65", "80"})
        Me.CoveragePercentageComboBox.Location = New System.Drawing.Point(145, 100)
        Me.CoveragePercentageComboBox.Name = "CoveragePercentageComboBox"
        Me.CoveragePercentageComboBox.Size = New System.Drawing.Size(138, 21)
        Me.CoveragePercentageComboBox.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Coverage Percentage(%)"
        '
        'InsuranceProviderComboBox
        '
        Me.InsuranceProviderComboBox.FormattingEnabled = True
        Me.InsuranceProviderComboBox.Items.AddRange(New Object() {"JUBILEE", "NHIF"})
        Me.InsuranceProviderComboBox.Location = New System.Drawing.Point(145, 27)
        Me.InsuranceProviderComboBox.Name = "InsuranceProviderComboBox"
        Me.InsuranceProviderComboBox.Size = New System.Drawing.Size(138, 21)
        Me.InsuranceProviderComboBox.TabIndex = 2
        '
        'InsuranceTextBox
        '
        Me.InsuranceTextBox.Location = New System.Drawing.Point(145, 64)
        Me.InsuranceTextBox.Name = "InsuranceTextBox"
        Me.InsuranceTextBox.Size = New System.Drawing.Size(138, 20)
        Me.InsuranceTextBox.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Insurance Policy Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Insurance Provider Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PatientResponsibilityTextBox)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.InsuranceCoveredTextBox)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.SubTotalTextBox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(440, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 112)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Charges"
        '
        'PatientResponsibilityTextBox
        '
        Me.PatientResponsibilityTextBox.Location = New System.Drawing.Point(142, 74)
        Me.PatientResponsibilityTextBox.Name = "PatientResponsibilityTextBox"
        Me.PatientResponsibilityTextBox.ReadOnly = True
        Me.PatientResponsibilityTextBox.Size = New System.Drawing.Size(141, 20)
        Me.PatientResponsibilityTextBox.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Patient Responsibilty"
        '
        'InsuranceCoveredTextBox
        '
        Me.InsuranceCoveredTextBox.Location = New System.Drawing.Point(142, 45)
        Me.InsuranceCoveredTextBox.Name = "InsuranceCoveredTextBox"
        Me.InsuranceCoveredTextBox.ReadOnly = True
        Me.InsuranceCoveredTextBox.Size = New System.Drawing.Size(141, 20)
        Me.InsuranceCoveredTextBox.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Insurance Covered"
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Location = New System.Drawing.Point(142, 18)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(141, 20)
        Me.SubTotalTextBox.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Sub Total"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(76, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(621, 415)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'PaymentOptionsLabel
        '
        Me.PaymentOptionsLabel.AutoSize = True
        Me.PaymentOptionsLabel.Location = New System.Drawing.Point(437, 353)
        Me.PaymentOptionsLabel.Name = "PaymentOptionsLabel"
        Me.PaymentOptionsLabel.Size = New System.Drawing.Size(87, 13)
        Me.PaymentOptionsLabel.TabIndex = 8
        Me.PaymentOptionsLabel.Text = "Payment Options"
        '
        'PaymentOptionsComboBox
        '
        Me.PaymentOptionsComboBox.FormattingEnabled = True
        Me.PaymentOptionsComboBox.Items.AddRange(New Object() {"Cash", "Cheque", "Card", "Payment Plan"})
        Me.PaymentOptionsComboBox.Location = New System.Drawing.Point(582, 345)
        Me.PaymentOptionsComboBox.Name = "PaymentOptionsComboBox"
        Me.PaymentOptionsComboBox.Size = New System.Drawing.Size(141, 21)
        Me.PaymentOptionsComboBox.TabIndex = 9
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(347, 415)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 10
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'OutPatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.PaymentOptionsComboBox)
        Me.Controls.Add(Me.PaymentOptionsLabel)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.InsuranceInformationGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PateintIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OutPatientForm"
        Me.Text = "OutPatientForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.InsuranceInformationGroupBox.ResumeLayout(False)
        Me.InsuranceInformationGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PateintIDTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ConsultationFeeLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ImagingChargesTextBox As TextBox
    Friend WithEvents LabChargesTextBox As TextBox
    Friend WithEvents ProcedureChargesTextBox As TextBox
    Friend WithEvents ConsultationFeeTextBox As TextBox
    Friend WithEvents ImagingChargesLabel As Label
    Friend WithEvents AttendingPhysicianComboBox As ComboBox
    Friend WithEvents OtherChargesTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents InsuranceInformationGroupBox As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents InsuranceProviderComboBox As ComboBox
    Friend WithEvents InsuranceTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CoveragePercentageComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PatientResponsibilityTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents InsuranceCoveredTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents PaymentOptionsLabel As Label
    Friend WithEvents PaymentOptionsComboBox As ComboBox
    Friend WithEvents CalculateButton As Button
End Class
