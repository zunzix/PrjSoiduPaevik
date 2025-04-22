<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTableViewer
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
        Me.tpAddCar = New System.Windows.Forms.TabPage()
        Me.btnAddCarEnter = New System.Windows.Forms.Button()
        Me.btnAddCarCancel = New System.Windows.Forms.Button()
        Me.cboxArchive = New System.Windows.Forms.CheckBox()
        Me.cboxReady = New System.Windows.Forms.CheckBox()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.txtAvgFuel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblAvgFuel = New System.Windows.Forms.Label()
        Me.lblReady = New System.Windows.Forms.Label()
        Me.lblArchive = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tpHistoryDetails = New System.Windows.Forms.TabPage()
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.tpCarsList = New System.Windows.Forms.TabPage()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.btnAddLog = New System.Windows.Forms.Button()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.lblInsuranceData = New System.Windows.Forms.Label()
        Me.lblMilageData = New System.Windows.Forms.Label()
        Me.lblFuelData = New System.Windows.Forms.Label()
        Me.lblMilage = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblFuel = New System.Windows.Forms.Label()
        Me.btnCarBack = New System.Windows.Forms.Button()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.dgvCarsList = New System.Windows.Forms.DataGridView()
        Me.tpGroups = New System.Windows.Forms.TabPage()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.txtLoginEmail = New System.Windows.Forms.TextBox()
        Me.lblLoginPassword = New System.Windows.Forms.Label()
        Me.lblLoginEmail = New System.Windows.Forms.Label()
        Me.btnLoginRegister = New System.Windows.Forms.Button()
        Me.btnLoginLogin = New System.Windows.Forms.Button()
        Me.lblLoginTitle = New System.Windows.Forms.Label()
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.dgvProblemsList = New System.Windows.Forms.DataGridView()
        Me.tpAddCar.SuspendLayout()
        Me.tpCarsList.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.gbDetails.SuspendLayout()
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpLogin.SuspendLayout()
        Me.tcTabs.SuspendLayout()
        CType(Me.dgvProblemsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tpAddCar
        '
        Me.tpAddCar.Controls.Add(Me.btnAddCarEnter)
        Me.tpAddCar.Controls.Add(Me.btnAddCarCancel)
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
        Me.tpAddCar.Location = New System.Drawing.Point(4, 28)
        Me.tpAddCar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpAddCar.Name = "tpAddCar"
        Me.tpAddCar.Size = New System.Drawing.Size(789, 413)
        Me.tpAddCar.TabIndex = 7
        Me.tpAddCar.Text = "AddCar"
        Me.tpAddCar.UseVisualStyleBackColor = True
        '
        'btnAddCarEnter
        '
        Me.btnAddCarEnter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddCarEnter.Location = New System.Drawing.Point(433, 347)
        Me.btnAddCarEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddCarEnter.Name = "btnAddCarEnter"
        Me.btnAddCarEnter.Size = New System.Drawing.Size(325, 53)
        Me.btnAddCarEnter.TabIndex = 12
        Me.btnAddCarEnter.Text = "Enter"
        Me.btnAddCarEnter.UseVisualStyleBackColor = False
        '
        'btnAddCarCancel
        '
        Me.btnAddCarCancel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddCarCancel.Location = New System.Drawing.Point(71, 347)
        Me.btnAddCarCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddCarCancel.Name = "btnAddCarCancel"
        Me.btnAddCarCancel.Size = New System.Drawing.Size(325, 53)
        Me.btnAddCarCancel.TabIndex = 11
        Me.btnAddCarCancel.Text = "Cancel"
        Me.btnAddCarCancel.UseVisualStyleBackColor = False
        '
        'cboxArchive
        '
        Me.cboxArchive.AutoSize = True
        Me.cboxArchive.Location = New System.Drawing.Point(434, 295)
        Me.cboxArchive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxArchive.Name = "cboxArchive"
        Me.cboxArchive.Size = New System.Drawing.Size(96, 20)
        Me.cboxArchive.TabIndex = 10
        Me.cboxArchive.Text = "Archive car"
        Me.cboxArchive.UseVisualStyleBackColor = True
        '
        'cboxReady
        '
        Me.cboxReady.AutoSize = True
        Me.cboxReady.Location = New System.Drawing.Point(316, 239)
        Me.cboxReady.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxReady.Name = "cboxReady"
        Me.cboxReady.Size = New System.Drawing.Size(101, 20)
        Me.cboxReady.TabIndex = 9
        Me.cboxReady.Text = "Car is ready"
        Me.cboxReady.UseVisualStyleBackColor = True
        '
        'txtMileage
        '
        Me.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMileage.Location = New System.Drawing.Point(211, 124)
        Me.txtMileage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(548, 22)
        Me.txtMileage.TabIndex = 8
        '
        'txtAvgFuel
        '
        Me.txtAvgFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvgFuel.Location = New System.Drawing.Point(363, 180)
        Me.txtAvgFuel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAvgFuel.Name = "txtAvgFuel"
        Me.txtAvgFuel.Size = New System.Drawing.Size(396, 22)
        Me.txtAvgFuel.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(148, 70)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(610, 22)
        Me.txtName.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(47, 68)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(92, 24)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Car name"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(47, 124)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(151, 24)
        Me.lblMileage.TabIndex = 4
        Me.lblMileage.Text = "Car mileage [km]"
        '
        'lblAvgFuel
        '
        Me.lblAvgFuel.AutoSize = True
        Me.lblAvgFuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgFuel.Location = New System.Drawing.Point(47, 180)
        Me.lblAvgFuel.Name = "lblAvgFuel"
        Me.lblAvgFuel.Size = New System.Drawing.Size(299, 24)
        Me.lblAvgFuel.TabIndex = 3
        Me.lblAvgFuel.Text = "Car average fuel consumtion [l/km]"
        '
        'lblReady
        '
        Me.lblReady.AutoSize = True
        Me.lblReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReady.Location = New System.Drawing.Point(47, 236)
        Me.lblReady.Name = "lblReady"
        Me.lblReady.Size = New System.Drawing.Size(254, 24)
        Me.lblReady.TabIndex = 2
        Me.lblReady.Text = "Is the car ready to drive now?"
        '
        'lblArchive
        '
        Me.lblArchive.AutoSize = True
        Me.lblArchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchive.Location = New System.Drawing.Point(47, 292)
        Me.lblArchive.Name = "lblArchive"
        Me.lblArchive.Size = New System.Drawing.Size(371, 24)
        Me.lblArchive.TabIndex = 1
        Me.lblArchive.Text = "Should the car be added to the archive list?"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(302, 16)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(176, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Add a car to list"
        '
        'tpHistoryDetails
        '
        Me.tpHistoryDetails.Location = New System.Drawing.Point(4, 28)
        Me.tpHistoryDetails.Name = "tpHistoryDetails"
        Me.tpHistoryDetails.Size = New System.Drawing.Size(789, 413)
        Me.tpHistoryDetails.TabIndex = 4
        Me.tpHistoryDetails.Text = "History Details"
        Me.tpHistoryDetails.UseVisualStyleBackColor = True
        '
        'tpHistory
        '
        Me.tpHistory.Location = New System.Drawing.Point(4, 28)
        Me.tpHistory.Name = "tpHistory"
        Me.tpHistory.Size = New System.Drawing.Size(789, 413)
        Me.tpHistory.TabIndex = 3
        Me.tpHistory.Text = "Car History"
        Me.tpHistory.UseVisualStyleBackColor = True
        '
        'tpCarsList
        '
        Me.tpCarsList.Controls.Add(Me.pnlDetails)
        Me.tpCarsList.Controls.Add(Me.btnCarBack)
        Me.tpCarsList.Controls.Add(Me.btnAddCar)
        Me.tpCarsList.Controls.Add(Me.dgvCarsList)
        Me.tpCarsList.Location = New System.Drawing.Point(4, 28)
        Me.tpCarsList.Name = "tpCarsList"
        Me.tpCarsList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCarsList.Size = New System.Drawing.Size(789, 413)
        Me.tpCarsList.TabIndex = 0
        Me.tpCarsList.Text = "Cars"
        Me.tpCarsList.UseVisualStyleBackColor = True
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.dgvProblemsList)
        Me.pnlDetails.Controls.Add(Me.btnAddLog)
        Me.pnlDetails.Controls.Add(Me.gbDetails)
        Me.pnlDetails.Location = New System.Drawing.Point(6, 223)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(777, 117)
        Me.pnlDetails.TabIndex = 3
        Me.pnlDetails.Visible = False
        '
        'btnAddLog
        '
        Me.btnAddLog.Location = New System.Drawing.Point(691, 28)
        Me.btnAddLog.Name = "btnAddLog"
        Me.btnAddLog.Size = New System.Drawing.Size(75, 65)
        Me.btnAddLog.TabIndex = 5
        Me.btnAddLog.Text = "Add Log"
        Me.btnAddLog.UseVisualStyleBackColor = True
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.lblInsuranceData)
        Me.gbDetails.Controls.Add(Me.lblMilageData)
        Me.gbDetails.Controls.Add(Me.lblFuelData)
        Me.gbDetails.Controls.Add(Me.lblMilage)
        Me.gbDetails.Controls.Add(Me.lblInsurance)
        Me.gbDetails.Controls.Add(Me.lblFuel)
        Me.gbDetails.Location = New System.Drawing.Point(3, 3)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(281, 107)
        Me.gbDetails.TabIndex = 4
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "Details"
        '
        'lblInsuranceData
        '
        Me.lblInsuranceData.AutoSize = True
        Me.lblInsuranceData.Location = New System.Drawing.Point(175, 80)
        Me.lblInsuranceData.Name = "lblInsuranceData"
        Me.lblInsuranceData.Size = New System.Drawing.Size(28, 16)
        Me.lblInsuranceData.TabIndex = 6
        Me.lblInsuranceData.Text = "___"
        '
        'lblMilageData
        '
        Me.lblMilageData.AutoSize = True
        Me.lblMilageData.Location = New System.Drawing.Point(175, 52)
        Me.lblMilageData.Name = "lblMilageData"
        Me.lblMilageData.Size = New System.Drawing.Size(28, 16)
        Me.lblMilageData.TabIndex = 5
        Me.lblMilageData.Text = "___"
        '
        'lblFuelData
        '
        Me.lblFuelData.AutoSize = True
        Me.lblFuelData.Location = New System.Drawing.Point(175, 25)
        Me.lblFuelData.Name = "lblFuelData"
        Me.lblFuelData.Size = New System.Drawing.Size(28, 16)
        Me.lblFuelData.TabIndex = 4
        Me.lblFuelData.Text = "___"
        '
        'lblMilage
        '
        Me.lblMilage.AutoSize = True
        Me.lblMilage.Location = New System.Drawing.Point(6, 52)
        Me.lblMilage.Name = "lblMilage"
        Me.lblMilage.Size = New System.Drawing.Size(54, 16)
        Me.lblMilage.TabIndex = 1
        Me.lblMilage.Text = "Milage: "
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(6, 80)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(107, 16)
        Me.lblInsurance.TabIndex = 3
        Me.lblInsurance.Text = "Insurance expiry:"
        '
        'lblFuel
        '
        Me.lblFuel.AutoSize = True
        Me.lblFuel.Location = New System.Drawing.Point(6, 25)
        Me.lblFuel.Name = "lblFuel"
        Me.lblFuel.Size = New System.Drawing.Size(165, 16)
        Me.lblFuel.TabIndex = 0
        Me.lblFuel.Text = "Average fuel consumption:"
        '
        'btnCarBack
        '
        Me.btnCarBack.Location = New System.Drawing.Point(7, 6)
        Me.btnCarBack.Name = "btnCarBack"
        Me.btnCarBack.Size = New System.Drawing.Size(75, 23)
        Me.btnCarBack.TabIndex = 2
        Me.btnCarBack.Text = "Back"
        Me.btnCarBack.UseVisualStyleBackColor = True
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(707, 6)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCar.TabIndex = 1
        Me.btnAddCar.Text = "Add car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'dgvCarsList
        '
        Me.dgvCarsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarsList.Location = New System.Drawing.Point(6, 35)
        Me.dgvCarsList.Name = "dgvCarsList"
        Me.dgvCarsList.RowHeadersWidth = 51
        Me.dgvCarsList.RowTemplate.Height = 24
        Me.dgvCarsList.Size = New System.Drawing.Size(777, 375)
        Me.dgvCarsList.TabIndex = 0
        '
        'tpGroups
        '
        Me.tpGroups.Location = New System.Drawing.Point(4, 28)
        Me.tpGroups.Name = "tpGroups"
        Me.tpGroups.Size = New System.Drawing.Size(789, 413)
        Me.tpGroups.TabIndex = 6
        Me.tpGroups.Text = "Groups"
        Me.tpGroups.UseVisualStyleBackColor = True
        '
        'tpLogin
        '
        Me.tpLogin.Controls.Add(Me.txtLoginPassword)
        Me.tpLogin.Controls.Add(Me.txtLoginEmail)
        Me.tpLogin.Controls.Add(Me.lblLoginPassword)
        Me.tpLogin.Controls.Add(Me.lblLoginEmail)
        Me.tpLogin.Controls.Add(Me.btnLoginRegister)
        Me.tpLogin.Controls.Add(Me.btnLoginLogin)
        Me.tpLogin.Controls.Add(Me.lblLoginTitle)
        Me.tpLogin.Location = New System.Drawing.Point(4, 28)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Size = New System.Drawing.Size(789, 413)
        Me.tpLogin.TabIndex = 5
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Location = New System.Drawing.Point(288, 188)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Size = New System.Drawing.Size(220, 22)
        Me.txtLoginPassword.TabIndex = 18
        Me.txtLoginPassword.UseSystemPasswordChar = True
        '
        'txtLoginEmail
        '
        Me.txtLoginEmail.Location = New System.Drawing.Point(288, 133)
        Me.txtLoginEmail.Name = "txtLoginEmail"
        Me.txtLoginEmail.Size = New System.Drawing.Size(220, 22)
        Me.txtLoginEmail.TabIndex = 17
        '
        'lblLoginPassword
        '
        Me.lblLoginPassword.AutoSize = True
        Me.lblLoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginPassword.Location = New System.Drawing.Point(194, 188)
        Me.lblLoginPassword.Name = "lblLoginPassword"
        Me.lblLoginPassword.Size = New System.Drawing.Size(88, 20)
        Me.lblLoginPassword.TabIndex = 16
        Me.lblLoginPassword.Text = "Password:"
        '
        'lblLoginEmail
        '
        Me.lblLoginEmail.AutoSize = True
        Me.lblLoginEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginEmail.Location = New System.Drawing.Point(226, 133)
        Me.lblLoginEmail.Name = "lblLoginEmail"
        Me.lblLoginEmail.Size = New System.Drawing.Size(56, 20)
        Me.lblLoginEmail.TabIndex = 15
        Me.lblLoginEmail.Text = "Email:"
        '
        'btnLoginRegister
        '
        Me.btnLoginRegister.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLoginRegister.Location = New System.Drawing.Point(288, 329)
        Me.btnLoginRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginRegister.Name = "btnLoginRegister"
        Me.btnLoginRegister.Size = New System.Drawing.Size(220, 53)
        Me.btnLoginRegister.TabIndex = 14
        Me.btnLoginRegister.Text = "Register"
        Me.btnLoginRegister.UseVisualStyleBackColor = False
        '
        'btnLoginLogin
        '
        Me.btnLoginLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLoginLogin.Location = New System.Drawing.Point(288, 261)
        Me.btnLoginLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginLogin.Name = "btnLoginLogin"
        Me.btnLoginLogin.Size = New System.Drawing.Size(220, 53)
        Me.btnLoginLogin.TabIndex = 13
        Me.btnLoginLogin.Text = "Login"
        Me.btnLoginLogin.UseVisualStyleBackColor = False
        '
        'lblLoginTitle
        '
        Me.lblLoginTitle.AutoSize = True
        Me.lblLoginTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginTitle.Location = New System.Drawing.Point(281, 37)
        Me.lblLoginTitle.Name = "lblLoginTitle"
        Me.lblLoginTitle.Size = New System.Drawing.Size(227, 42)
        Me.lblLoginTitle.TabIndex = 0
        Me.lblLoginTitle.Text = "CarLogBook"
        '
        'tcTabs
        '
        Me.tcTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcTabs.Controls.Add(Me.tpLogin)
        Me.tcTabs.Controls.Add(Me.tpGroups)
        Me.tcTabs.Controls.Add(Me.tpCarsList)
        Me.tcTabs.Controls.Add(Me.tpHistory)
        Me.tcTabs.Controls.Add(Me.tpHistoryDetails)
        Me.tcTabs.Controls.Add(Me.tpAddCar)
        Me.tcTabs.Location = New System.Drawing.Point(2, 3)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(797, 445)
        Me.tcTabs.TabIndex = 0
        '
        'dgvProblemsList
        '
        Me.dgvProblemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProblemsList.Location = New System.Drawing.Point(290, 13)
        Me.dgvProblemsList.Name = "dgvProblemsList"
        Me.dgvProblemsList.RowHeadersWidth = 51
        Me.dgvProblemsList.RowTemplate.Height = 24
        Me.dgvProblemsList.Size = New System.Drawing.Size(395, 97)
        Me.dgvProblemsList.TabIndex = 6
        '
        'formTableViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tcTabs)
        Me.Name = "formTableViewer"
        Me.Text = "Car Logbook"
        Me.tpAddCar.ResumeLayout(False)
        Me.tpAddCar.PerformLayout()
        Me.tpCarsList.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpLogin.ResumeLayout(False)
        Me.tpLogin.PerformLayout()
        Me.tcTabs.ResumeLayout(False)
        CType(Me.dgvProblemsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tpAddCar As TabPage
    Friend WithEvents btnAddCarEnter As Button
    Friend WithEvents btnAddCarCancel As Button
    Friend WithEvents cboxArchive As CheckBox
    Friend WithEvents cboxReady As CheckBox
    Friend WithEvents txtMileage As TextBox
    Friend WithEvents txtAvgFuel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblMileage As Label
    Friend WithEvents lblAvgFuel As Label
    Friend WithEvents lblReady As Label
    Friend WithEvents lblArchive As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents tpHistoryDetails As TabPage
    Friend WithEvents tpHistory As TabPage
    Friend WithEvents tpCarsList As TabPage
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblMilage As Label
    Friend WithEvents lblFuel As Label
    Friend WithEvents btnCarBack As Button
    Friend WithEvents btnAddCar As Button
    Friend WithEvents dgvCarsList As DataGridView
    Friend WithEvents tpGroups As TabPage
    Friend WithEvents tpLogin As TabPage
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents txtLoginEmail As TextBox
    Friend WithEvents lblLoginPassword As Label
    Friend WithEvents lblLoginEmail As Label
    Friend WithEvents btnLoginRegister As Button
    Friend WithEvents btnLoginLogin As Button
    Friend WithEvents lblLoginTitle As Label
    Friend WithEvents tcTabs As TabControl
    Friend WithEvents btnAddLog As Button
    Friend WithEvents gbDetails As GroupBox
    Friend WithEvents lblInsuranceData As Label
    Friend WithEvents lblMilageData As Label
    Friend WithEvents lblFuelData As Label
    Friend WithEvents dgvProblemsList As DataGridView
End Class
