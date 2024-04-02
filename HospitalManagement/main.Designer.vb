<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PaymentReportLabel = New System.Windows.Forms.Label()
        Me.ReloadButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OutpatientLabel = New System.Windows.Forms.Label()
        Me.PatientLabel = New System.Windows.Forms.Label()
        Me.InPatientReportLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 437)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(3, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(781, 388)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.InPatientReportLabel)
        Me.Panel2.Controls.Add(Me.PaymentReportLabel)
        Me.Panel2.Controls.Add(Me.ReloadButton)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.OutpatientLabel)
        Me.Panel2.Controls.Add(Me.PatientLabel)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 29)
        Me.Panel2.TabIndex = 0
        '
        'PaymentReportLabel
        '
        Me.PaymentReportLabel.AutoSize = True
        Me.PaymentReportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentReportLabel.Location = New System.Drawing.Point(357, 3)
        Me.PaymentReportLabel.Name = "PaymentReportLabel"
        Me.PaymentReportLabel.Size = New System.Drawing.Size(134, 20)
        Me.PaymentReportLabel.TabIndex = 2
        Me.PaymentReportLabel.Text = "OutPatientReport"
        '
        'ReloadButton
        '
        Me.ReloadButton.Location = New System.Drawing.Point(696, 3)
        Me.ReloadButton.Name = "ReloadButton"
        Me.ReloadButton.Size = New System.Drawing.Size(75, 23)
        Me.ReloadButton.TabIndex = 1
        Me.ReloadButton.Text = "Reload"
        Me.ReloadButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "InPatient"
        '
        'OutpatientLabel
        '
        Me.OutpatientLabel.AutoSize = True
        Me.OutpatientLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutpatientLabel.Location = New System.Drawing.Point(129, 3)
        Me.OutpatientLabel.Name = "OutpatientLabel"
        Me.OutpatientLabel.Size = New System.Drawing.Size(85, 20)
        Me.OutpatientLabel.TabIndex = 0
        Me.OutpatientLabel.Text = "OutPatient"
        '
        'PatientLabel
        '
        Me.PatientLabel.AutoSize = True
        Me.PatientLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientLabel.Location = New System.Drawing.Point(8, 3)
        Me.PatientLabel.Name = "PatientLabel"
        Me.PatientLabel.Size = New System.Drawing.Size(87, 20)
        Me.PatientLabel.TabIndex = 0
        Me.PatientLabel.Text = "PatientInfo"
        '
        'InPatientReportLabel
        '
        Me.InPatientReportLabel.AutoSize = True
        Me.InPatientReportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InPatientReportLabel.Location = New System.Drawing.Point(535, 3)
        Me.InPatientReportLabel.Name = "InPatientReportLabel"
        Me.InPatientReportLabel.Size = New System.Drawing.Size(122, 20)
        Me.InPatientReportLabel.TabIndex = 3
        Me.InPatientReportLabel.Text = "InPatientReport"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "main"
        Me.Text = "Computer Technology Hospital"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PatientLabel As Label
    Friend WithEvents ReloadButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OutpatientLabel As Label
    Friend WithEvents PaymentReportLabel As Label
    Friend WithEvents InPatientReportLabel As Label
End Class
