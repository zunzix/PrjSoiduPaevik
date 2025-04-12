<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDetailedCarView
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
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Me.lblCarName = New System.Windows.Forms.Label()
        Me.lblFuelConsumption = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblTechnical = New System.Windows.Forms.Label()
        Me.lblFuelConsumptionText = New System.Windows.Forms.Label()
        Me.lblAvailabilityText = New System.Windows.Forms.Label()
        Me.lblMileageText = New System.Windows.Forms.Label()
        Me.lblInsuranceText = New System.Windows.Forms.Label()
        Me.lblTechnicalText = New System.Windows.Forms.Label()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        GroupBox1.Location = New System.Drawing.Point(36, 66)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(733, 300)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        '
        'lblCarName
        '
        Me.lblCarName.AutoSize = True
        Me.lblCarName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarName.Location = New System.Drawing.Point(54, 39)
        Me.lblCarName.Name = "lblCarName"
        Me.lblCarName.Size = New System.Drawing.Size(109, 24)
        Me.lblCarName.TabIndex = 0
        Me.lblCarName.Text = "AUTONIMI"
        '
        'lblFuelConsumption
        '
        Me.lblFuelConsumption.AutoSize = True
        Me.lblFuelConsumption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuelConsumption.Location = New System.Drawing.Point(55, 123)
        Me.lblFuelConsumption.Name = "lblFuelConsumption"
        Me.lblFuelConsumption.Size = New System.Drawing.Size(74, 16)
        Me.lblFuelConsumption.TabIndex = 1
        Me.lblFuelConsumption.Text = "Kütusekulu:"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability.Location = New System.Drawing.Point(55, 174)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(72, 16)
        Me.lblAvailability.TabIndex = 2
        Me.lblAvailability.Text = "Saadavus:"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(55, 221)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(57, 16)
        Me.lblMileage.TabIndex = 3
        Me.lblMileage.Text = "Läbisõit:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.Location = New System.Drawing.Point(55, 265)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(70, 16)
        Me.lblInsurance.TabIndex = 4
        Me.lblInsurance.Text = "Kindlustus:"
        '
        'lblTechnical
        '
        Me.lblTechnical.AutoSize = True
        Me.lblTechnical.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTechnical.Location = New System.Drawing.Point(55, 306)
        Me.lblTechnical.Name = "lblTechnical"
        Me.lblTechnical.Size = New System.Drawing.Size(79, 16)
        Me.lblTechnical.TabIndex = 5
        Me.lblTechnical.Text = "Tehno lõpp:"
        '
        'lblFuelConsumptionText
        '
        Me.lblFuelConsumptionText.AutoSize = True
        Me.lblFuelConsumptionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuelConsumptionText.Location = New System.Drawing.Point(159, 123)
        Me.lblFuelConsumptionText.Name = "lblFuelConsumptionText"
        Me.lblFuelConsumptionText.Size = New System.Drawing.Size(90, 16)
        Me.lblFuelConsumptionText.TabIndex = 7
        Me.lblFuelConsumptionText.Text = "kütusekulutext"
        '
        'lblAvailabilityText
        '
        Me.lblAvailabilityText.AutoSize = True
        Me.lblAvailabilityText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailabilityText.Location = New System.Drawing.Point(159, 174)
        Me.lblAvailabilityText.Name = "lblAvailabilityText"
        Me.lblAvailabilityText.Size = New System.Drawing.Size(87, 16)
        Me.lblAvailabilityText.TabIndex = 8
        Me.lblAvailabilityText.Text = "saadavustext"
        '
        'lblMileageText
        '
        Me.lblMileageText.AutoSize = True
        Me.lblMileageText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileageText.Location = New System.Drawing.Point(159, 221)
        Me.lblMileageText.Name = "lblMileageText"
        Me.lblMileageText.Size = New System.Drawing.Size(70, 16)
        Me.lblMileageText.TabIndex = 9
        Me.lblMileageText.Text = "labisoittext"
        '
        'lblInsuranceText
        '
        Me.lblInsuranceText.AutoSize = True
        Me.lblInsuranceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsuranceText.Location = New System.Drawing.Point(159, 265)
        Me.lblInsuranceText.Name = "lblInsuranceText"
        Me.lblInsuranceText.Size = New System.Drawing.Size(86, 16)
        Me.lblInsuranceText.TabIndex = 10
        Me.lblInsuranceText.Text = "kindlustustext"
        '
        'lblTechnicalText
        '
        Me.lblTechnicalText.AutoSize = True
        Me.lblTechnicalText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTechnicalText.Location = New System.Drawing.Point(159, 306)
        Me.lblTechnicalText.Name = "lblTechnicalText"
        Me.lblTechnicalText.Size = New System.Drawing.Size(60, 16)
        Me.lblTechnicalText.TabIndex = 11
        Me.lblTechnicalText.Text = "tehnotext"
        '
        'formDetailedCarView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTechnicalText)
        Me.Controls.Add(Me.lblInsuranceText)
        Me.Controls.Add(Me.lblMileageText)
        Me.Controls.Add(Me.lblAvailabilityText)
        Me.Controls.Add(Me.lblFuelConsumptionText)
        Me.Controls.Add(Me.lblTechnical)
        Me.Controls.Add(Me.lblInsurance)
        Me.Controls.Add(Me.lblMileage)
        Me.Controls.Add(Me.lblAvailability)
        Me.Controls.Add(Me.lblFuelConsumption)
        Me.Controls.Add(Me.lblCarName)
        Me.Controls.Add(GroupBox1)
        Me.Name = "formDetailedCarView"
        Me.Text = "formDetailedCarView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCarName As Label
    Friend WithEvents lblFuelConsumption As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents lblMileage As Label
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblTechnical As Label
    Friend WithEvents lblFuelConsumptionText As Label
    Friend WithEvents lblAvailabilityText As Label
    Friend WithEvents lblMileageText As Label
    Friend WithEvents lblInsuranceText As Label
    Friend WithEvents lblTechnicalText As Label
End Class
