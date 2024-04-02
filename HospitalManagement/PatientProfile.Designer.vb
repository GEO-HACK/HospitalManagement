<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientProfileForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.MaritalStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DOBLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailPatientTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.FullPatientNameTextBox = New System.Windows.Forms.TextBox()
        Me.InpatientButton = New System.Windows.Forms.Button()
        Me.OutpatientButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DOBTextBox)
        Me.GroupBox2.Controls.Add(Me.MaritalStatusComboBox)
        Me.GroupBox2.Controls.Add(Me.GenderTextBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.DOBLabel)
        Me.GroupBox2.Controls.Add(Me.AddressLabel)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.AddressTextBox)
        Me.GroupBox2.Controls.Add(Me.EmailPatientTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.AgeTextBox)
        Me.GroupBox2.Controls.Add(Me.FullPatientNameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 319)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Information"
        '
        'DOBTextBox
        '
        Me.DOBTextBox.Location = New System.Drawing.Point(538, 108)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DOBTextBox.TabIndex = 10
        '
        'MaritalStatusComboBox
        '
        Me.MaritalStatusComboBox.FormattingEnabled = True
        Me.MaritalStatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Divorced"})
        Me.MaritalStatusComboBox.Location = New System.Drawing.Point(538, 163)
        Me.MaritalStatusComboBox.Name = "MaritalStatusComboBox"
        Me.MaritalStatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MaritalStatusComboBox.TabIndex = 9
        '
        'GenderTextBox
        '
        Me.GenderTextBox.Location = New System.Drawing.Point(538, 38)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(121, 20)
        Me.GenderTextBox.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(448, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(445, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Marital Status"
        '
        'DOBLabel
        '
        Me.DOBLabel.AutoSize = True
        Me.DOBLabel.Location = New System.Drawing.Point(445, 108)
        Me.DOBLabel.Name = "DOBLabel"
        Me.DOBLabel.Size = New System.Drawing.Size(30, 13)
        Me.DOBLabel.TabIndex = 3
        Me.DOBLabel.Text = "DOB"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(19, 247)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 1
        Me.AddressLabel.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Phone Number"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(127, 240)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 0
        '
        'EmailPatientTextBox
        '
        Me.EmailPatientTextBox.Location = New System.Drawing.Point(127, 188)
        Me.EmailPatientTextBox.Name = "EmailPatientTextBox"
        Me.EmailPatientTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailPatientTextBox.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Age"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(127, 139)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumberTextBox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "full Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(127, 88)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 0
        '
        'FullPatientNameTextBox
        '
        Me.FullPatientNameTextBox.Location = New System.Drawing.Point(127, 31)
        Me.FullPatientNameTextBox.Name = "FullPatientNameTextBox"
        Me.FullPatientNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FullPatientNameTextBox.TabIndex = 0
        '
        'InpatientButton
        '
        Me.InpatientButton.Location = New System.Drawing.Point(31, 364)
        Me.InpatientButton.Name = "InpatientButton"
        Me.InpatientButton.Size = New System.Drawing.Size(75, 23)
        Me.InpatientButton.TabIndex = 2
        Me.InpatientButton.Text = "&Inpatient"
        Me.InpatientButton.UseVisualStyleBackColor = True
        '
        'OutpatientButton
        '
        Me.OutpatientButton.Location = New System.Drawing.Point(204, 363)
        Me.OutpatientButton.Name = "OutpatientButton"
        Me.OutpatientButton.Size = New System.Drawing.Size(75, 23)
        Me.OutpatientButton.TabIndex = 3
        Me.OutpatientButton.Text = "&Outpatient"
        Me.OutpatientButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(406, 364)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(625, 363)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PatientProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.OutpatientButton)
        Me.Controls.Add(Me.InpatientButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "PatientProfileForm"
        Me.Text = "PatientProfile"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents EmailPatientTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents FullPatientNameTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DOBLabel As Label
    Friend WithEvents InpatientButton As Button
    Friend WithEvents OutpatientButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MaritalStatusComboBox As ComboBox
    Friend WithEvents DOBTextBox As TextBox
End Class
