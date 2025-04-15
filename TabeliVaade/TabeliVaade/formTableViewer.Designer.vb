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
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.txtLoginEmail = New System.Windows.Forms.TextBox()
        Me.lblLoginPassword = New System.Windows.Forms.Label()
        Me.lblLoginEmail = New System.Windows.Forms.Label()
        Me.btnLoginRegister = New System.Windows.Forms.Button()
        Me.btnLoginLogin = New System.Windows.Forms.Button()
        Me.lblLoginTitle = New System.Windows.Forms.Label()
        Me.tpGroups = New System.Windows.Forms.TabPage()
        Me.tpCarsList = New System.Windows.Forms.TabPage()
        Me.btnCarBack = New System.Windows.Forms.Button()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.dgvCarsList = New System.Windows.Forms.DataGridView()
        Me.tpCarDetails = New System.Windows.Forms.TabPage()
        Me.lblInsuranceData = New System.Windows.Forms.Label()
        Me.lblMilageData = New System.Windows.Forms.Label()
        Me.lblAvailabilityData = New System.Windows.Forms.Label()
        Me.btnArchiveCar = New System.Windows.Forms.Button()
        Me.btnShowProblems = New System.Windows.Forms.Button()
        Me.btnAddLog = New System.Windows.Forms.Button()
        Me.lblFuelData = New System.Windows.Forms.Label()
        Me.lblInsuranceText = New System.Windows.Forms.Label()
        Me.lblMilageText = New System.Windows.Forms.Label()
        Me.lblAvailableText = New System.Windows.Forms.Label()
        Me.lblFuelText = New System.Windows.Forms.Label()
        Me.tpProblems = New System.Windows.Forms.TabPage()
        Me.btnProblemBack = New System.Windows.Forms.Button()
        Me.dgvProblemsList = New System.Windows.Forms.DataGridView()
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.tpHistoryDetails = New System.Windows.Forms.TabPage()
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
        Me.btnCarDetailsBack = New System.Windows.Forms.Button()
        Me.tcTabs.SuspendLayout()
        Me.tpLogin.SuspendLayout()
        Me.tpCarsList.SuspendLayout()
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCarDetails.SuspendLayout()
        Me.tpProblems.SuspendLayout()
        CType(Me.dgvProblemsList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tcTabs.Location = New System.Drawing.Point(2, 3)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(797, 445)
        Me.tcTabs.TabIndex = 0
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
        'tpGroups
        '
        Me.tpGroups.Location = New System.Drawing.Point(4, 28)
        Me.tpGroups.Name = "tpGroups"
        Me.tpGroups.Size = New System.Drawing.Size(789, 413)
        Me.tpGroups.TabIndex = 6
        Me.tpGroups.Text = "Groups"
        Me.tpGroups.UseVisualStyleBackColor = True
        '
        'tpCarsList
        '
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
        'tpCarDetails
        '

        Me.tpCarDetails.Controls.Add(Me.btnCarDetailsBack)
        Me.tpCarDetails.Controls.Add(Me.lblInsuranceData)
        Me.tpCarDetails.Controls.Add(Me.lblMilageData)
        Me.tpCarDetails.Controls.Add(Me.lblAvailabilityData)
        Me.tpCarDetails.Controls.Add(Me.btnArchiveCar)
        Me.tpCarDetails.Controls.Add(Me.btnShowProblems)
        Me.tpCarDetails.Controls.Add(Me.btnAddLog)
        Me.tpCarDetails.Controls.Add(Me.lblFuelData)
        Me.tpCarDetails.Controls.Add(Me.lblInsuranceText)
        Me.tpCarDetails.Controls.Add(Me.lblMilageText)
        Me.tpCarDetails.Controls.Add(Me.lblAvailableText)
        Me.tpCarDetails.Controls.Add(Me.lblFuelText)
        Me.tpCarDetails.Location = New System.Drawing.Point(4, 28)
        Me.tpCarDetails.Name = "tpCarDetails"
        Me.tpCarDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCarDetails.Size = New System.Drawing.Size(789, 413)
        Me.tpCarDetails.TabIndex = 1
        Me.tpCarDetails.Text = "Car Details"
        Me.tpCarDetails.UseVisualStyleBackColor = True
        '
        'lblInsuranceData
        '
        Me.lblInsuranceData.AutoSize = True
        Me.lblInsuranceData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsuranceData.Location = New System.Drawing.Point(294, 169)
        Me.lblInsuranceData.Name = "lblInsuranceData"
        Me.lblInsuranceData.Size = New System.Drawing.Size(59, 31)
        Me.lblInsuranceData.TabIndex = 10
        Me.lblInsuranceData.Text = "___"
        '
        'lblMilageData
        '
        Me.lblMilageData.AutoSize = True
        Me.lblMilageData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilageData.Location = New System.Drawing.Point(294, 124)
        Me.lblMilageData.Name = "lblMilageData"
        Me.lblMilageData.Size = New System.Drawing.Size(59, 31)
        Me.lblMilageData.TabIndex = 9
        Me.lblMilageData.Text = "___"
        '
        'lblAvailabilityData
        '
        Me.lblAvailabilityData.AutoSize = True
        Me.lblAvailabilityData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailabilityData.Location = New System.Drawing.Point(294, 84)
        Me.lblAvailabilityData.Name = "lblAvailabilityData"
        Me.lblAvailabilityData.Size = New System.Drawing.Size(59, 31)
        Me.lblAvailabilityData.TabIndex = 8
        Me.lblAvailabilityData.Text = "___"
        '
        'btnArchiveCar
        '
        Me.btnArchiveCar.Location = New System.Drawing.Point(694, 96)
        Me.btnArchiveCar.Name = "btnArchiveCar"
        Me.btnArchiveCar.Size = New System.Drawing.Size(75, 23)
        Me.btnArchiveCar.TabIndex = 7
        Me.btnArchiveCar.Text = "Archive"
        Me.btnArchiveCar.UseVisualStyleBackColor = True
        '
        'btnShowProblems
        '
        Me.btnShowProblems.Location = New System.Drawing.Point(694, 56)
        Me.btnShowProblems.Name = "btnShowProblems"
        Me.btnShowProblems.Size = New System.Drawing.Size(75, 23)
        Me.btnShowProblems.TabIndex = 6
        Me.btnShowProblems.Text = "Problems"
        Me.btnShowProblems.UseVisualStyleBackColor = True
        '
        'btnAddLog
        '
        Me.btnAddLog.Location = New System.Drawing.Point(694, 18)
        Me.btnAddLog.Name = "btnAddLog"
        Me.btnAddLog.Size = New System.Drawing.Size(75, 23)
        Me.btnAddLog.TabIndex = 5
        Me.btnAddLog.Text = "Add log"
        Me.btnAddLog.UseVisualStyleBackColor = True
        '
        'lblFuelData
        '
        Me.lblFuelData.AutoSize = True
        Me.lblFuelData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuelData.Location = New System.Drawing.Point(294, 49)
        Me.lblFuelData.Name = "lblFuelData"
        Me.lblFuelData.Size = New System.Drawing.Size(59, 31)
        Me.lblFuelData.TabIndex = 4
        Me.lblFuelData.Text = "___"
        '
        'lblInsuranceText
        '
        Me.lblInsuranceText.AutoSize = True
        Me.lblInsuranceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsuranceText.Location = New System.Drawing.Point(15, 166)
        Me.lblInsuranceText.Name = "lblInsuranceText"
        Me.lblInsuranceText.Size = New System.Drawing.Size(149, 31)
        Me.lblInsuranceText.TabIndex = 3
        Me.lblInsuranceText.Text = "Insurance :"
        '
        'lblMilageText
        '
        Me.lblMilageText.AutoSize = True
        Me.lblMilageText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilageText.Location = New System.Drawing.Point(15, 125)
        Me.lblMilageText.Name = "lblMilageText"
        Me.lblMilageText.Size = New System.Drawing.Size(108, 31)
        Me.lblMilageText.TabIndex = 2
        Me.lblMilageText.Text = "Milage :"
        '
        'lblAvailableText
        '
        Me.lblAvailableText.AutoSize = True
        Me.lblAvailableText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableText.Location = New System.Drawing.Point(15, 84)
        Me.lblAvailableText.Name = "lblAvailableText"
        Me.lblAvailableText.Size = New System.Drawing.Size(158, 31)
        Me.lblAvailableText.TabIndex = 1
        Me.lblAvailableText.Text = "Availability :"
        '
        'lblFuelText
        '
        Me.lblFuelText.AutoSize = True
        Me.lblFuelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuelText.Location = New System.Drawing.Point(15, 46)
        Me.lblFuelText.Name = "lblFuelText"
        Me.lblFuelText.Size = New System.Drawing.Size(249, 31)
        Me.lblFuelText.TabIndex = 0
        Me.lblFuelText.Text = "Fuel Consumption :"
        '
        'tpProblems
        '
        Me.tpProblems.Controls.Add(Me.btnProblemBack)
        Me.tpProblems.Controls.Add(Me.dgvProblemsList)
        Me.tpProblems.Location = New System.Drawing.Point(4, 28)
        Me.tpProblems.Name = "tpProblems"
        Me.tpProblems.Size = New System.Drawing.Size(789, 413)
        Me.tpProblems.TabIndex = 2
        Me.tpProblems.Text = "Car Problems"
        Me.tpProblems.UseVisualStyleBackColor = True
        '
        'btnProblemBack
        '
        Me.btnProblemBack.Location = New System.Drawing.Point(7, 7)
        Me.btnProblemBack.Name = "btnProblemBack"
        Me.btnProblemBack.Size = New System.Drawing.Size(75, 23)
        Me.btnProblemBack.TabIndex = 1
        Me.btnProblemBack.Text = "Back"
        Me.btnProblemBack.UseVisualStyleBackColor = True
        '
        'dgvProblemsList
        '
        Me.dgvProblemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProblemsList.Location = New System.Drawing.Point(6, 36)
        Me.dgvProblemsList.Name = "dgvProblemsList"
        Me.dgvProblemsList.RowHeadersWidth = 51
        Me.dgvProblemsList.RowTemplate.Height = 24
        Me.dgvProblemsList.Size = New System.Drawing.Size(776, 374)
        Me.dgvProblemsList.TabIndex = 0
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
        'tpHistoryDetails
        '
        Me.tpHistoryDetails.Location = New System.Drawing.Point(4, 28)
        Me.tpHistoryDetails.Name = "tpHistoryDetails"
        Me.tpHistoryDetails.Size = New System.Drawing.Size(789, 413)
        Me.tpHistoryDetails.TabIndex = 4
        Me.tpHistoryDetails.Text = "History Details"
        Me.tpHistoryDetails.UseVisualStyleBackColor = True
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
        'btnCarDetailsBack
        '
        Me.btnCarDetailsBack.Location = New System.Drawing.Point(21, 18)
        Me.btnCarDetailsBack.Name = "btnCarDetailsBack"
        Me.btnCarDetailsBack.Size = New System.Drawing.Size(75, 23)
        Me.btnCarDetailsBack.TabIndex = 11
        Me.btnCarDetailsBack.Text = "Back"
        Me.btnCarDetailsBack.UseVisualStyleBackColor = True
        '
        'formTableViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tcTabs)
        Me.Name = "formTableViewer"
        Me.Text = "Car Logbook"
        Me.tcTabs.ResumeLayout(False)
        Me.tpLogin.ResumeLayout(False)
        Me.tpLogin.PerformLayout()
        Me.tpCarsList.ResumeLayout(False)
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCarDetails.ResumeLayout(False)
        Me.tpCarDetails.PerformLayout()
        Me.tpProblems.ResumeLayout(False)
        CType(Me.dgvProblemsList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvProblemsList As DataGridView
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
    Friend WithEvents btnAddCarEnter As Button
    Friend WithEvents btnAddCarCancel As Button
    Friend WithEvents cboxArchive As CheckBox
    Friend WithEvents cboxReady As CheckBox

    Friend WithEvents lblLoginTitle As Label
    Friend WithEvents btnLoginRegister As Button
    Friend WithEvents btnLoginLogin As Button
    Friend WithEvents lblLoginPassword As Label
    Friend WithEvents lblLoginEmail As Label
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents txtLoginEmail As TextBox

    Friend WithEvents lblAvailableText As Label
    Friend WithEvents lblFuelText As Label
    Friend WithEvents lblFuelData As Label
    Friend WithEvents lblInsuranceText As Label
    Friend WithEvents lblMilageText As Label
    Friend WithEvents btnArchiveCar As Button
    Friend WithEvents btnShowProblems As Button
    Friend WithEvents btnAddLog As Button
    Friend WithEvents lblInsuranceData As Label
    Friend WithEvents lblMilageData As Label
    Friend WithEvents lblAvailabilityData As Label
    Friend WithEvents btnCarDetailsBack As Button

End Class
