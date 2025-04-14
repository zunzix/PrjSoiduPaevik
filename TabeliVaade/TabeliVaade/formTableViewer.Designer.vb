<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTableViewer
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
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.tpGroups = New System.Windows.Forms.TabPage()
        Me.tpCarsList = New System.Windows.Forms.TabPage()
        Me.btnCarBack = New System.Windows.Forms.Button()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.dgvCarsList = New System.Windows.Forms.DataGridView()
        Me.tpCarDetails = New System.Windows.Forms.TabPage()
        Me.tpProblems = New System.Windows.Forms.TabPage()
        Me.btnProblemBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.tpHistoryDetails = New System.Windows.Forms.TabPage()
        Me.tpAddCar = New System.Windows.Forms.TabPage()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblArchive = New System.Windows.Forms.Label()
        Me.lblReady = New System.Windows.Forms.Label()
        Me.lblAvgFuel = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAvgFuel = New System.Windows.Forms.TextBox()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.cboxReady = New System.Windows.Forms.CheckBox()
        Me.cboxArchive = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.tcTabs.SuspendLayout()
        Me.tpCarsList.SuspendLayout()
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpProblems.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAddCar.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcTabs
        '
        Me.tcTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcTabs.Controls.Add(Me.tpLogin)
        Me.tcTabs.Controls.Add(Me.tpGroups)
        Me.tcTabs.Controls.Add(Me.tpCarsList)
        Me.tcTabs.Controls.Add(Me.tpCarDetails)
        Me.tcTabs.Controls.Add(Me.tpProblems)
        Me.tcTabs.Controls.Add(Me.tpHistory)
        Me.tcTabs.Controls.Add(Me.tpHistoryDetails)
        Me.tcTabs.Controls.Add(Me.tpAddCar)
        Me.tcTabs.Location = New System.Drawing.Point(2, 4)
        Me.tcTabs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(897, 556)
        Me.tcTabs.TabIndex = 0
        '
        'tpLogin
        '
        Me.tpLogin.Location = New System.Drawing.Point(4, 32)
        Me.tpLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Size = New System.Drawing.Size(889, 520)
        Me.tpLogin.TabIndex = 5
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'tpGroups
        '
        Me.tpGroups.Location = New System.Drawing.Point(4, 32)
        Me.tpGroups.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpGroups.Name = "tpGroups"
        Me.tpGroups.Size = New System.Drawing.Size(889, 520)
        Me.tpGroups.TabIndex = 6
        Me.tpGroups.Text = "Groups"
        Me.tpGroups.UseVisualStyleBackColor = True
        '
        'tpCarsList
        '
        Me.tpCarsList.Controls.Add(Me.btnCarBack)
        Me.tpCarsList.Controls.Add(Me.btnAddCar)
        Me.tpCarsList.Controls.Add(Me.dgvCarsList)
        Me.tpCarsList.Location = New System.Drawing.Point(4, 32)
        Me.tpCarsList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpCarsList.Name = "tpCarsList"
        Me.tpCarsList.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpCarsList.Size = New System.Drawing.Size(889, 520)
        Me.tpCarsList.TabIndex = 0
        Me.tpCarsList.Text = "Cars"
        Me.tpCarsList.UseVisualStyleBackColor = True
        '
        'btnCarBack
        '
        Me.btnCarBack.Location = New System.Drawing.Point(8, 8)
        Me.btnCarBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCarBack.Name = "btnCarBack"
        Me.btnCarBack.Size = New System.Drawing.Size(84, 29)
        Me.btnCarBack.TabIndex = 2
        Me.btnCarBack.Text = "Back"
        Me.btnCarBack.UseVisualStyleBackColor = True
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(795, 8)
        Me.btnAddCar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(84, 29)
        Me.btnAddCar.TabIndex = 1
        Me.btnAddCar.Text = "Add car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'dgvCarsList
        '
        Me.dgvCarsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarsList.Location = New System.Drawing.Point(7, 44)
        Me.dgvCarsList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvCarsList.Name = "dgvCarsList"
        Me.dgvCarsList.RowHeadersWidth = 51
        Me.dgvCarsList.RowTemplate.Height = 24
        Me.dgvCarsList.Size = New System.Drawing.Size(874, 469)
        Me.dgvCarsList.TabIndex = 0
        '
        'tpCarDetails
        '
        Me.tpCarDetails.Location = New System.Drawing.Point(4, 32)
        Me.tpCarDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpCarDetails.Name = "tpCarDetails"
        Me.tpCarDetails.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpCarDetails.Size = New System.Drawing.Size(889, 520)
        Me.tpCarDetails.TabIndex = 1
        Me.tpCarDetails.Text = "Car Details"
        Me.tpCarDetails.UseVisualStyleBackColor = True
        '
        'tpProblems
        '
        Me.tpProblems.Controls.Add(Me.btnProblemBack)
        Me.tpProblems.Controls.Add(Me.DataGridView1)
        Me.tpProblems.Location = New System.Drawing.Point(4, 32)
        Me.tpProblems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpProblems.Name = "tpProblems"
        Me.tpProblems.Size = New System.Drawing.Size(889, 520)
        Me.tpProblems.TabIndex = 2
        Me.tpProblems.Text = "Car Problems"
        Me.tpProblems.UseVisualStyleBackColor = True
        '
        'btnProblemBack
        '
        Me.btnProblemBack.Location = New System.Drawing.Point(8, 9)
        Me.btnProblemBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnProblemBack.Name = "btnProblemBack"
        Me.btnProblemBack.Size = New System.Drawing.Size(84, 29)
        Me.btnProblemBack.TabIndex = 1
        Me.btnProblemBack.Text = "Back"
        Me.btnProblemBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 45)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(873, 468)
        Me.DataGridView1.TabIndex = 0
        '
        'tpHistory
        '
        Me.tpHistory.Location = New System.Drawing.Point(4, 32)
        Me.tpHistory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpHistory.Name = "tpHistory"
        Me.tpHistory.Size = New System.Drawing.Size(889, 520)
        Me.tpHistory.TabIndex = 3
        Me.tpHistory.Text = "Car History"
        Me.tpHistory.UseVisualStyleBackColor = True
        '
        'tpHistoryDetails
        '
        Me.tpHistoryDetails.Location = New System.Drawing.Point(4, 32)
        Me.tpHistoryDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpHistoryDetails.Name = "tpHistoryDetails"
        Me.tpHistoryDetails.Size = New System.Drawing.Size(889, 520)
        Me.tpHistoryDetails.TabIndex = 4
        Me.tpHistoryDetails.Text = "History Details"
        Me.tpHistoryDetails.UseVisualStyleBackColor = True
        '
        'tpAddCar
        '
        Me.tpAddCar.Controls.Add(Me.btnEnter)
        Me.tpAddCar.Controls.Add(Me.btnCancel)
        Me.tpAddCar.Controls.Add(Me.cboxArchive)
        Me.tpAddCar.Controls.Add(Me.cboxReady)
        Me.tpAddCar.Controls.Add(Me.txtMileage)
        Me.tpAddCar.Controls.Add(Me.txtAvgFuel)
        Me.tpAddCar.Controls.Add(Me.txtName)
        Me.tpAddCar.Controls.Add(Me.lblName)
        Me.tpAddCar.Controls.Add(Me.lblMileage)
        Me.tpAddCar.Controls.Add(Me.lblAvgFuel)
        Me.tpAddCar.Controls.Add(Me.lblReady)
        Me.tpAddCar.Controls.Add(Me.lblArchive)
        Me.tpAddCar.Controls.Add(Me.lblHeader)
        Me.tpAddCar.Location = New System.Drawing.Point(4, 32)
        Me.tpAddCar.Name = "tpAddCar"
        Me.tpAddCar.Size = New System.Drawing.Size(889, 520)
        Me.tpAddCar.TabIndex = 7
        Me.tpAddCar.Text = "AddCar"
        Me.tpAddCar.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(340, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(208, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Add a car to list"
        '
        'lblArchive
        '
        Me.lblArchive.AutoSize = True
        Me.lblArchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchive.Location = New System.Drawing.Point(53, 365)
        Me.lblArchive.Name = "lblArchive"
        Me.lblArchive.Size = New System.Drawing.Size(429, 26)
        Me.lblArchive.TabIndex = 1
        Me.lblArchive.Text = "Should the car be added to the archive list?"
        '
        'lblReady
        '
        Me.lblReady.AutoSize = True
        Me.lblReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReady.Location = New System.Drawing.Point(53, 295)
        Me.lblReady.Name = "lblReady"
        Me.lblReady.Size = New System.Drawing.Size(296, 26)
        Me.lblReady.TabIndex = 2
        Me.lblReady.Text = "Is the car ready to drive now?"
        '
        'lblAvgFuel
        '
        Me.lblAvgFuel.AutoSize = True
        Me.lblAvgFuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgFuel.Location = New System.Drawing.Point(53, 225)
        Me.lblAvgFuel.Name = "lblAvgFuel"
        Me.lblAvgFuel.Size = New System.Drawing.Size(349, 26)
        Me.lblAvgFuel.TabIndex = 3
        Me.lblAvgFuel.Text = "Car average fuel consumtion [l/km]"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(53, 155)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(178, 26)
        Me.lblMileage.TabIndex = 4
        Me.lblMileage.Text = "Car mileage [km]"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(53, 85)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(108, 26)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Car name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(167, 88)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(686, 26)
        Me.txtName.TabIndex = 6
        '
        'txtAvgFuel
        '
        Me.txtAvgFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvgFuel.Location = New System.Drawing.Point(408, 225)
        Me.txtAvgFuel.Name = "txtAvgFuel"
        Me.txtAvgFuel.Size = New System.Drawing.Size(445, 26)
        Me.txtAvgFuel.TabIndex = 7
        '
        'txtMileage
        '
        Me.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMileage.Location = New System.Drawing.Point(237, 155)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(616, 26)
        Me.txtMileage.TabIndex = 8
        '
        'cboxReady
        '
        Me.cboxReady.AutoSize = True
        Me.cboxReady.Location = New System.Drawing.Point(355, 299)
        Me.cboxReady.Name = "cboxReady"
        Me.cboxReady.Size = New System.Drawing.Size(118, 24)
        Me.cboxReady.TabIndex = 9
        Me.cboxReady.Text = "Car is ready"
        Me.cboxReady.UseVisualStyleBackColor = True
        '
        'cboxArchive
        '
        Me.cboxArchive.AutoSize = True
        Me.cboxArchive.Location = New System.Drawing.Point(488, 369)
        Me.cboxArchive.Name = "cboxArchive"
        Me.cboxArchive.Size = New System.Drawing.Size(113, 24)
        Me.cboxArchive.TabIndex = 10
        Me.cboxArchive.Text = "Archive car"
        Me.cboxArchive.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCancel.Location = New System.Drawing.Point(80, 434)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(366, 66)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEnter.Location = New System.Drawing.Point(487, 434)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(366, 66)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'formTableViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.tcTabs)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formTableViewer"
        Me.Text = "Car Logbook"
        Me.tcTabs.ResumeLayout(False)
        Me.tpCarsList.ResumeLayout(False)
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpProblems.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAddCar.ResumeLayout(False)
        Me.tpAddCar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcTabs As TabControl
    Friend WithEvents tpCarsList As TabPage
    Friend WithEvents tpCarDetails As TabPage
    Friend WithEvents tpProblems As TabPage
    Friend WithEvents tpHistory As TabPage
    Friend WithEvents tpHistoryDetails As TabPage
    Friend WithEvents tpLogin As TabPage
    Friend WithEvents tpGroups As TabPage
    Friend WithEvents btnAddCar As Button
    Friend WithEvents dgvCarsList As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCarBack As Button
    Friend WithEvents btnProblemBack As Button
    Friend WithEvents tpAddCar As TabPage
    Friend WithEvents txtMileage As TextBox
    Friend WithEvents txtAvgFuel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblMileage As Label
    Friend WithEvents lblAvgFuel As Label
    Friend WithEvents lblReady As Label
    Friend WithEvents lblArchive As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cboxArchive As CheckBox
    Friend WithEvents cboxReady As CheckBox
End Class
