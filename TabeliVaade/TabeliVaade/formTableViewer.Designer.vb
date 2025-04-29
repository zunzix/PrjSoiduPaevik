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
        Me.txtAddCarRegistrationPlate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddCarEnter = New System.Windows.Forms.Button()
        Me.btnAddCarCancel = New System.Windows.Forms.Button()
        Me.cboxAddCarIsArchived = New System.Windows.Forms.CheckBox()
        Me.cboxAddCarIsAvailable = New System.Windows.Forms.CheckBox()
        Me.txtAddCarMileage = New System.Windows.Forms.TextBox()
        Me.txtAddCarAvgFuel = New System.Windows.Forms.TextBox()
        Me.txtAddCarName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblAvgFuel = New System.Windows.Forms.Label()
        Me.lblReady = New System.Windows.Forms.Label()
        Me.lblArchive = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tpCarsList = New System.Windows.Forms.TabPage()
        Me.btnAddMember = New System.Windows.Forms.Button()
        Me.pnlLogs = New System.Windows.Forms.Panel()
        Me.dtpStatsTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnGetDistance = New System.Windows.Forms.Button()
        Me.dtpStatsTimeStart = New System.Windows.Forms.DateTimePicker()
        Me.btnProblems = New System.Windows.Forms.Button()
        Me.btnAddLog = New System.Windows.Forms.Button()
        Me.dgvLogsList = New System.Windows.Forms.DataGridView()
        Me.gbLogDetails = New System.Windows.Forms.GroupBox()
        Me.lblCommentData = New System.Windows.Forms.Label()
        Me.lblDistanceData = New System.Windows.Forms.Label()
        Me.lblEndData = New System.Windows.Forms.Label()
        Me.lblStartData = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblLogComment = New System.Windows.Forms.Label()
        Me.lblTotalDistance = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.btnAddProblem = New System.Windows.Forms.Button()
        Me.dgvProblemsList = New System.Windows.Forms.DataGridView()
        Me.btnLogs = New System.Windows.Forms.Button()
        Me.gbCarDetails = New System.Windows.Forms.GroupBox()
        Me.lblInsuranceNameData = New System.Windows.Forms.Label()
        Me.lblInsuranceName = New System.Windows.Forms.Label()
        Me.btnDetailsUpdateInsurance = New System.Windows.Forms.Button()
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
        Me.btnNewGroup = New System.Windows.Forms.Button()
        Me.gbGroups = New System.Windows.Forms.GroupBox()
        Me.dgvGroupsList = New System.Windows.Forms.DataGridView()
        Me.gbRideHistory = New System.Windows.Forms.GroupBox()
        Me.cbSortRides = New System.Windows.Forms.ComboBox()
        Me.dgvUserHistoryList = New System.Windows.Forms.DataGridView()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.txtLoginEmail = New System.Windows.Forms.TextBox()
        Me.lblLoginPassword = New System.Windows.Forms.Label()
        Me.lblLoginEmail = New System.Windows.Forms.Label()
        Me.btnLoginRegister = New System.Windows.Forms.Button()
        Me.btnLoginLogin = New System.Windows.Forms.Button()
        Me.lblLoginTitle = New System.Windows.Forms.Label()
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.tpAddProblem = New System.Windows.Forms.TabPage()
        Me.btnAddProblemEnter = New System.Windows.Forms.Button()
        Me.btnAddProblemCancel = New System.Windows.Forms.Button()
        Me.cbCriticality = New System.Windows.Forms.CheckBox()
        Me.txtProblemDescription = New System.Windows.Forms.TextBox()
        Me.lblCriticality = New System.Windows.Forms.Label()
        Me.lblIssueDescription = New System.Windows.Forms.Label()
        Me.lblProblemReportTitle = New System.Windows.Forms.Label()
        Me.tpAddLog = New System.Windows.Forms.TabPage()
        Me.btnAddLogEnter = New System.Windows.Forms.Button()
        Me.btnAddLogCancel = New System.Windows.Forms.Button()
        Me.gbEnd = New System.Windows.Forms.GroupBox()
        Me.lblEndAdd = New System.Windows.Forms.Label()
        Me.txtLocationEnd = New System.Windows.Forms.TextBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDateAdd = New System.Windows.Forms.Label()
        Me.gbStart = New System.Windows.Forms.GroupBox()
        Me.lblStartDateAdd = New System.Windows.Forms.Label()
        Me.lblAddStart = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLocationStart = New System.Windows.Forms.TextBox()
        Me.txtLogComment = New System.Windows.Forms.TextBox()
        Me.txtTotalDistance = New System.Windows.Forms.TextBox()
        Me.lblLogCommentAdd = New System.Windows.Forms.Label()
        Me.lblDistanceAdd = New System.Windows.Forms.Label()
        Me.lblAddLogTitle = New System.Windows.Forms.Label()
        Me.tpNewGroup = New System.Windows.Forms.TabPage()
        Me.lblGroupName = New System.Windows.Forms.Label()
        Me.btnCancelNewGroup = New System.Windows.Forms.Button()
        Me.btnEnterNewGroup = New System.Windows.Forms.Button()
        Me.txtNewGroupName = New System.Windows.Forms.TextBox()
        Me.lblCreateGroup = New System.Windows.Forms.Label()
        Me.tpRegister = New System.Windows.Forms.TabPage()
        Me.lblCreateAccountTitle = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblRegisterPassword = New System.Windows.Forms.Label()
        Me.lblRegisterEmail = New System.Windows.Forms.Label()
        Me.tbRegisterPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.tbRegisterPassword = New System.Windows.Forms.TextBox()
        Me.tbRegisterEmail = New System.Windows.Forms.TextBox()
        Me.btnRegisterEnter = New System.Windows.Forms.Button()
        Me.btnRegisterCancel = New System.Windows.Forms.Button()
        Me.tpUpdateInsurance = New System.Windows.Forms.TabPage()
        Me.lblUpdateInsuranceTitle = New System.Windows.Forms.Label()
        Me.btnUpdateInsuranceEnter = New System.Windows.Forms.Button()
        Me.btnUpdateInsuranceCancel = New System.Windows.Forms.Button()
        Me.dtpInsuranceExpiration = New System.Windows.Forms.DateTimePicker()
        Me.txtUpdateInsuranceName = New System.Windows.Forms.TextBox()
        Me.lblUpdateExpiration = New System.Windows.Forms.Label()
        Me.lblUpdateName = New System.Windows.Forms.Label()
        Me.tpAddMember = New System.Windows.Forms.TabPage()
        Me.txtMemberEmail = New System.Windows.Forms.TextBox()
        Me.lblAddMemberTitle = New System.Windows.Forms.Label()
        Me.lblMemberEmail = New System.Windows.Forms.Label()
        Me.btnAddMemberEnter = New System.Windows.Forms.Button()
        Me.btnAddMemberCancel = New System.Windows.Forms.Button()
        Me.cbIsAdmin = New System.Windows.Forms.CheckBox()
        Me.tpAddCar.SuspendLayout()
        Me.tpCarsList.SuspendLayout()
        Me.pnlLogs.SuspendLayout()
        CType(Me.dgvLogsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLogDetails.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        CType(Me.dgvProblemsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCarDetails.SuspendLayout()
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpGroups.SuspendLayout()
        Me.gbGroups.SuspendLayout()
        CType(Me.dgvGroupsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRideHistory.SuspendLayout()
        CType(Me.dgvUserHistoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpLogin.SuspendLayout()
        Me.tcTabs.SuspendLayout()
        Me.tpAddProblem.SuspendLayout()
        Me.tpAddLog.SuspendLayout()
        Me.gbEnd.SuspendLayout()
        Me.gbStart.SuspendLayout()
        Me.tpNewGroup.SuspendLayout()
        Me.tpRegister.SuspendLayout()
        Me.tpUpdateInsurance.SuspendLayout()
        Me.tpAddMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpAddCar
        '
        Me.tpAddCar.Controls.Add(Me.txtAddCarRegistrationPlate)
        Me.tpAddCar.Controls.Add(Me.Label1)
        Me.tpAddCar.Controls.Add(Me.btnAddCarEnter)
        Me.tpAddCar.Controls.Add(Me.btnAddCarCancel)
        Me.tpAddCar.Controls.Add(Me.cboxAddCarIsArchived)
        Me.tpAddCar.Controls.Add(Me.cboxAddCarIsAvailable)
        Me.tpAddCar.Controls.Add(Me.txtAddCarMileage)
        Me.tpAddCar.Controls.Add(Me.txtAddCarAvgFuel)
        Me.tpAddCar.Controls.Add(Me.txtAddCarName)
        Me.tpAddCar.Controls.Add(Me.lblName)
        Me.tpAddCar.Controls.Add(Me.lblMileage)
        Me.tpAddCar.Controls.Add(Me.lblAvgFuel)
        Me.tpAddCar.Controls.Add(Me.lblReady)
        Me.tpAddCar.Controls.Add(Me.lblArchive)
        Me.tpAddCar.Controls.Add(Me.lblHeader)
        Me.tpAddCar.Location = New System.Drawing.Point(4, 28)
        Me.tpAddCar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpAddCar.Name = "tpAddCar"
        Me.tpAddCar.Size = New System.Drawing.Size(789, 414)
        Me.tpAddCar.TabIndex = 7
        Me.tpAddCar.Text = "Add Car"
        Me.tpAddCar.UseVisualStyleBackColor = True
        '
        'txtAddCarRegistrationPlate
        '
        Me.txtAddCarRegistrationPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddCarRegistrationPlate.Location = New System.Drawing.Point(361, 68)
        Me.txtAddCarRegistrationPlate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddCarRegistrationPlate.Name = "txtAddCarRegistrationPlate"
        Me.txtAddCarRegistrationPlate.Size = New System.Drawing.Size(395, 22)
        Me.txtAddCarRegistrationPlate.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Registration Plate"
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
        'cboxAddCarIsArchived
        '
        Me.cboxAddCarIsArchived.AutoSize = True
        Me.cboxAddCarIsArchived.Location = New System.Drawing.Point(435, 302)
        Me.cboxAddCarIsArchived.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxAddCarIsArchived.Name = "cboxAddCarIsArchived"
        Me.cboxAddCarIsArchived.Size = New System.Drawing.Size(96, 20)
        Me.cboxAddCarIsArchived.TabIndex = 10
        Me.cboxAddCarIsArchived.Text = "Archive car"
        Me.cboxAddCarIsArchived.UseVisualStyleBackColor = True
        '
        'cboxAddCarIsAvailable
        '
        Me.cboxAddCarIsAvailable.AutoSize = True
        Me.cboxAddCarIsAvailable.Location = New System.Drawing.Point(316, 257)
        Me.cboxAddCarIsAvailable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxAddCarIsAvailable.Name = "cboxAddCarIsAvailable"
        Me.cboxAddCarIsAvailable.Size = New System.Drawing.Size(101, 20)
        Me.cboxAddCarIsAvailable.TabIndex = 9
        Me.cboxAddCarIsAvailable.Text = "Car is ready"
        Me.cboxAddCarIsAvailable.UseVisualStyleBackColor = True
        '
        'txtAddCarMileage
        '
        Me.txtAddCarMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddCarMileage.Location = New System.Drawing.Point(361, 154)
        Me.txtAddCarMileage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddCarMileage.Name = "txtAddCarMileage"
        Me.txtAddCarMileage.Size = New System.Drawing.Size(397, 22)
        Me.txtAddCarMileage.TabIndex = 8
        '
        'txtAddCarAvgFuel
        '
        Me.txtAddCarAvgFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddCarAvgFuel.Location = New System.Drawing.Point(361, 209)
        Me.txtAddCarAvgFuel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddCarAvgFuel.Name = "txtAddCarAvgFuel"
        Me.txtAddCarAvgFuel.Size = New System.Drawing.Size(397, 22)
        Me.txtAddCarAvgFuel.TabIndex = 7
        '
        'txtAddCarName
        '
        Me.txtAddCarName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddCarName.Location = New System.Drawing.Point(361, 105)
        Me.txtAddCarName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddCarName.Name = "txtAddCarName"
        Me.txtAddCarName.Size = New System.Drawing.Size(395, 22)
        Me.txtAddCarName.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(47, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(92, 24)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Car name"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(45, 151)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(151, 24)
        Me.lblMileage.TabIndex = 4
        Me.lblMileage.Text = "Car mileage [km]"
        '
        'lblAvgFuel
        '
        Me.lblAvgFuel.AutoSize = True
        Me.lblAvgFuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgFuel.Location = New System.Drawing.Point(45, 209)
        Me.lblAvgFuel.Name = "lblAvgFuel"
        Me.lblAvgFuel.Size = New System.Drawing.Size(299, 24)
        Me.lblAvgFuel.TabIndex = 3
        Me.lblAvgFuel.Text = "Car average fuel consumtion [l/km]"
        '
        'lblReady
        '
        Me.lblReady.AutoSize = True
        Me.lblReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReady.Location = New System.Drawing.Point(47, 255)
        Me.lblReady.Name = "lblReady"
        Me.lblReady.Size = New System.Drawing.Size(254, 24)
        Me.lblReady.TabIndex = 2
        Me.lblReady.Text = "Is the car ready to drive now?"
        '
        'lblArchive
        '
        Me.lblArchive.AutoSize = True
        Me.lblArchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchive.Location = New System.Drawing.Point(47, 298)
        Me.lblArchive.Name = "lblArchive"
        Me.lblArchive.Size = New System.Drawing.Size(371, 24)
        Me.lblArchive.TabIndex = 1
        Me.lblArchive.Text = "Should the car be added to the archive list?"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(301, 16)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(176, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Add a car to list"
        '
        'tpCarsList
        '
        Me.tpCarsList.Controls.Add(Me.btnAddMember)
        Me.tpCarsList.Controls.Add(Me.pnlLogs)
        Me.tpCarsList.Controls.Add(Me.pnlDetails)
        Me.tpCarsList.Controls.Add(Me.btnCarBack)
        Me.tpCarsList.Controls.Add(Me.btnAddCar)
        Me.tpCarsList.Controls.Add(Me.dgvCarsList)
        Me.tpCarsList.Location = New System.Drawing.Point(4, 28)
        Me.tpCarsList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpCarsList.Name = "tpCarsList"
        Me.tpCarsList.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpCarsList.Size = New System.Drawing.Size(789, 414)
        Me.tpCarsList.TabIndex = 0
        Me.tpCarsList.Text = "Cars"
        Me.tpCarsList.UseVisualStyleBackColor = True
        '
        'btnAddMember
        '
        Me.btnAddMember.Location = New System.Drawing.Point(316, 6)
        Me.btnAddMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(120, 23)
        Me.btnAddMember.TabIndex = 5
        Me.btnAddMember.Text = "Add member"
        Me.btnAddMember.UseVisualStyleBackColor = True
        '
        'pnlLogs
        '
        Me.pnlLogs.Controls.Add(Me.dtpStatsTimeEnd)
        Me.pnlLogs.Controls.Add(Me.btnGetDistance)
        Me.pnlLogs.Controls.Add(Me.dtpStatsTimeStart)
        Me.pnlLogs.Controls.Add(Me.btnProblems)
        Me.pnlLogs.Controls.Add(Me.btnAddLog)
        Me.pnlLogs.Controls.Add(Me.dgvLogsList)
        Me.pnlLogs.Controls.Add(Me.gbLogDetails)
        Me.pnlLogs.Location = New System.Drawing.Point(4, 64)
        Me.pnlLogs.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pnlLogs.Name = "pnlLogs"
        Me.pnlLogs.Size = New System.Drawing.Size(778, 225)
        Me.pnlLogs.TabIndex = 4
        Me.pnlLogs.Visible = False
        '
        'dtpStatsTimeEnd
        '
        Me.dtpStatsTimeEnd.Location = New System.Drawing.Point(515, 194)
        Me.dtpStatsTimeEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStatsTimeEnd.MaxDate = New Date(2025, 4, 29, 0, 0, 0, 0)
        Me.dtpStatsTimeEnd.Name = "dtpStatsTimeEnd"
        Me.dtpStatsTimeEnd.Size = New System.Drawing.Size(169, 22)
        Me.dtpStatsTimeEnd.TabIndex = 10
        Me.dtpStatsTimeEnd.Value = New Date(2025, 4, 29, 0, 0, 0, 0)
        '
        'btnGetDistance
        '
        Me.btnGetDistance.Location = New System.Drawing.Point(691, 166)
        Me.btnGetDistance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetDistance.Name = "btnGetDistance"
        Me.btnGetDistance.Size = New System.Drawing.Size(83, 54)
        Me.btnGetDistance.TabIndex = 8
        Me.btnGetDistance.Text = "Get Distance"
        Me.btnGetDistance.UseVisualStyleBackColor = True
        '
        'dtpStatsTimeStart
        '
        Me.dtpStatsTimeStart.CustomFormat = ""
        Me.dtpStatsTimeStart.Location = New System.Drawing.Point(265, 194)
        Me.dtpStatsTimeStart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStatsTimeStart.Name = "dtpStatsTimeStart"
        Me.dtpStatsTimeStart.Size = New System.Drawing.Size(190, 22)
        Me.dtpStatsTimeStart.TabIndex = 9
        '
        'btnProblems
        '
        Me.btnProblems.Location = New System.Drawing.Point(691, 65)
        Me.btnProblems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProblems.Name = "btnProblems"
        Me.btnProblems.Size = New System.Drawing.Size(83, 46)
        Me.btnProblems.TabIndex = 3
        Me.btnProblems.Text = "Problems"
        Me.btnProblems.UseVisualStyleBackColor = True
        '
        'btnAddLog
        '
        Me.btnAddLog.Location = New System.Drawing.Point(691, 10)
        Me.btnAddLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddLog.Name = "btnAddLog"
        Me.btnAddLog.Size = New System.Drawing.Size(83, 46)
        Me.btnAddLog.TabIndex = 2
        Me.btnAddLog.Text = "Add Log"
        Me.btnAddLog.UseVisualStyleBackColor = True
        '
        'dgvLogsList
        '
        Me.dgvLogsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogsList.Location = New System.Drawing.Point(265, 10)
        Me.dgvLogsList.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvLogsList.Name = "dgvLogsList"
        Me.dgvLogsList.ReadOnly = True
        Me.dgvLogsList.RowHeadersVisible = False
        Me.dgvLogsList.RowHeadersWidth = 51
        Me.dgvLogsList.RowTemplate.Height = 24
        Me.dgvLogsList.Size = New System.Drawing.Size(419, 160)
        Me.dgvLogsList.TabIndex = 1
        '
        'gbLogDetails
        '
        Me.gbLogDetails.Controls.Add(Me.lblCommentData)
        Me.gbLogDetails.Controls.Add(Me.lblDistanceData)
        Me.gbLogDetails.Controls.Add(Me.lblEndData)
        Me.gbLogDetails.Controls.Add(Me.lblStartData)
        Me.gbLogDetails.Controls.Add(Me.lblEndTime)
        Me.gbLogDetails.Controls.Add(Me.lblLogComment)
        Me.gbLogDetails.Controls.Add(Me.lblTotalDistance)
        Me.gbLogDetails.Controls.Add(Me.lblStartTime)
        Me.gbLogDetails.Location = New System.Drawing.Point(3, 2)
        Me.gbLogDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbLogDetails.Name = "gbLogDetails"
        Me.gbLogDetails.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gbLogDetails.Size = New System.Drawing.Size(255, 214)
        Me.gbLogDetails.TabIndex = 0
        Me.gbLogDetails.TabStop = False
        Me.gbLogDetails.Text = "Details"
        '
        'lblCommentData
        '
        Me.lblCommentData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCommentData.AutoSize = True
        Me.lblCommentData.Location = New System.Drawing.Point(112, 105)
        Me.lblCommentData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCommentData.Name = "lblCommentData"
        Me.lblCommentData.Size = New System.Drawing.Size(28, 16)
        Me.lblCommentData.TabIndex = 7
        Me.lblCommentData.Text = "___"
        Me.lblCommentData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDistanceData
        '
        Me.lblDistanceData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDistanceData.AutoSize = True
        Me.lblDistanceData.Location = New System.Drawing.Point(112, 76)
        Me.lblDistanceData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDistanceData.Name = "lblDistanceData"
        Me.lblDistanceData.Size = New System.Drawing.Size(28, 16)
        Me.lblDistanceData.TabIndex = 6
        Me.lblDistanceData.Text = "___"
        Me.lblDistanceData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEndData
        '
        Me.lblEndData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEndData.AutoSize = True
        Me.lblEndData.Location = New System.Drawing.Point(112, 49)
        Me.lblEndData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndData.Name = "lblEndData"
        Me.lblEndData.Size = New System.Drawing.Size(28, 16)
        Me.lblEndData.TabIndex = 5
        Me.lblEndData.Text = "___"
        Me.lblEndData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStartData
        '
        Me.lblStartData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStartData.AutoSize = True
        Me.lblStartData.Location = New System.Drawing.Point(112, 21)
        Me.lblStartData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartData.Name = "lblStartData"
        Me.lblStartData.Size = New System.Drawing.Size(28, 16)
        Me.lblStartData.TabIndex = 4
        Me.lblStartData.Text = "___"
        Me.lblStartData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(5, 49)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(34, 16)
        Me.lblEndTime.TabIndex = 3
        Me.lblEndTime.Text = "End:"
        '
        'lblLogComment
        '
        Me.lblLogComment.AutoSize = True
        Me.lblLogComment.Location = New System.Drawing.Point(6, 105)
        Me.lblLogComment.Name = "lblLogComment"
        Me.lblLogComment.Size = New System.Drawing.Size(67, 16)
        Me.lblLogComment.TabIndex = 2
        Me.lblLogComment.Text = "Comment:"
        '
        'lblTotalDistance
        '
        Me.lblTotalDistance.AutoSize = True
        Me.lblTotalDistance.Location = New System.Drawing.Point(5, 76)
        Me.lblTotalDistance.Name = "lblTotalDistance"
        Me.lblTotalDistance.Size = New System.Drawing.Size(95, 16)
        Me.lblTotalDistance.TabIndex = 1
        Me.lblTotalDistance.Text = "Total distance:"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(5, 21)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(37, 16)
        Me.lblStartTime.TabIndex = 0
        Me.lblStartTime.Text = "Start:"
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.btnAddProblem)
        Me.pnlDetails.Controls.Add(Me.dgvProblemsList)
        Me.pnlDetails.Controls.Add(Me.btnLogs)
        Me.pnlDetails.Controls.Add(Me.gbCarDetails)
        Me.pnlDetails.Location = New System.Drawing.Point(4, 293)
        Me.pnlDetails.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(778, 225)
        Me.pnlDetails.TabIndex = 3
        Me.pnlDetails.Visible = False
        '
        'btnAddProblem
        '
        Me.btnAddProblem.Location = New System.Drawing.Point(691, 10)
        Me.btnAddProblem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProblem.Name = "btnAddProblem"
        Me.btnAddProblem.Size = New System.Drawing.Size(83, 46)
        Me.btnAddProblem.TabIndex = 7
        Me.btnAddProblem.Text = "Add Problem"
        Me.btnAddProblem.UseVisualStyleBackColor = True
        '
        'dgvProblemsList
        '
        Me.dgvProblemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProblemsList.Location = New System.Drawing.Point(269, 12)
        Me.dgvProblemsList.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvProblemsList.Name = "dgvProblemsList"
        Me.dgvProblemsList.ReadOnly = True
        Me.dgvProblemsList.RowHeadersVisible = False
        Me.dgvProblemsList.RowHeadersWidth = 51
        Me.dgvProblemsList.RowTemplate.Height = 24
        Me.dgvProblemsList.Size = New System.Drawing.Size(415, 204)
        Me.dgvProblemsList.TabIndex = 6
        '
        'btnLogs
        '
        Me.btnLogs.Location = New System.Drawing.Point(691, 65)
        Me.btnLogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(83, 46)
        Me.btnLogs.TabIndex = 5
        Me.btnLogs.Text = "Logs"
        Me.btnLogs.UseVisualStyleBackColor = True
        '
        'gbCarDetails
        '
        Me.gbCarDetails.Controls.Add(Me.lblInsuranceNameData)
        Me.gbCarDetails.Controls.Add(Me.lblInsuranceName)
        Me.gbCarDetails.Controls.Add(Me.btnDetailsUpdateInsurance)
        Me.gbCarDetails.Controls.Add(Me.lblInsuranceData)
        Me.gbCarDetails.Controls.Add(Me.lblMilageData)
        Me.gbCarDetails.Controls.Add(Me.lblFuelData)
        Me.gbCarDetails.Controls.Add(Me.lblMilage)
        Me.gbCarDetails.Controls.Add(Me.lblInsurance)
        Me.gbCarDetails.Controls.Add(Me.lblFuel)
        Me.gbCarDetails.Location = New System.Drawing.Point(3, 2)
        Me.gbCarDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbCarDetails.Name = "gbCarDetails"
        Me.gbCarDetails.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gbCarDetails.Size = New System.Drawing.Size(259, 214)
        Me.gbCarDetails.TabIndex = 4
        Me.gbCarDetails.TabStop = False
        Me.gbCarDetails.Text = "Details"
        '
        'lblInsuranceNameData
        '
        Me.lblInsuranceNameData.AutoSize = True
        Me.lblInsuranceNameData.Location = New System.Drawing.Point(173, 78)
        Me.lblInsuranceNameData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsuranceNameData.Name = "lblInsuranceNameData"
        Me.lblInsuranceNameData.Size = New System.Drawing.Size(28, 16)
        Me.lblInsuranceNameData.TabIndex = 9
        Me.lblInsuranceNameData.Text = "___"
        Me.lblInsuranceNameData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInsuranceName
        '
        Me.lblInsuranceName.AutoSize = True
        Me.lblInsuranceName.Location = New System.Drawing.Point(5, 78)
        Me.lblInsuranceName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsuranceName.Name = "lblInsuranceName"
        Me.lblInsuranceName.Size = New System.Drawing.Size(68, 16)
        Me.lblInsuranceName.TabIndex = 8
        Me.lblInsuranceName.Text = "Insurance:"
        '
        'btnDetailsUpdateInsurance
        '
        Me.btnDetailsUpdateInsurance.Location = New System.Drawing.Point(8, 142)
        Me.btnDetailsUpdateInsurance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDetailsUpdateInsurance.Name = "btnDetailsUpdateInsurance"
        Me.btnDetailsUpdateInsurance.Size = New System.Drawing.Size(243, 28)
        Me.btnDetailsUpdateInsurance.TabIndex = 7
        Me.btnDetailsUpdateInsurance.Text = "Update insurance"
        Me.btnDetailsUpdateInsurance.UseVisualStyleBackColor = True
        '
        'lblInsuranceData
        '
        Me.lblInsuranceData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInsuranceData.AutoSize = True
        Me.lblInsuranceData.Location = New System.Drawing.Point(173, 112)
        Me.lblInsuranceData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsuranceData.Name = "lblInsuranceData"
        Me.lblInsuranceData.Size = New System.Drawing.Size(28, 16)
        Me.lblInsuranceData.TabIndex = 6
        Me.lblInsuranceData.Text = "___"
        Me.lblInsuranceData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMilageData
        '
        Me.lblMilageData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMilageData.AutoSize = True
        Me.lblMilageData.Location = New System.Drawing.Point(173, 52)
        Me.lblMilageData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMilageData.Name = "lblMilageData"
        Me.lblMilageData.Size = New System.Drawing.Size(28, 16)
        Me.lblMilageData.TabIndex = 5
        Me.lblMilageData.Text = "___"
        Me.lblMilageData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFuelData
        '
        Me.lblFuelData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFuelData.AutoSize = True
        Me.lblFuelData.Location = New System.Drawing.Point(173, 25)
        Me.lblFuelData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuelData.Name = "lblFuelData"
        Me.lblFuelData.Size = New System.Drawing.Size(81, 16)
        Me.lblFuelData.TabIndex = 4
        Me.lblFuelData.Text = "___ L/100km"
        Me.lblFuelData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMilage
        '
        Me.lblMilage.AutoSize = True
        Me.lblMilage.Location = New System.Drawing.Point(5, 52)
        Me.lblMilage.Name = "lblMilage"
        Me.lblMilage.Size = New System.Drawing.Size(54, 16)
        Me.lblMilage.TabIndex = 1
        Me.lblMilage.Text = "Milage: "
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(7, 112)
        Me.lblInsurance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(107, 16)
        Me.lblInsurance.TabIndex = 3
        Me.lblInsurance.Text = "Insurance expiry:"
        '
        'lblFuel
        '
        Me.lblFuel.AutoSize = True
        Me.lblFuel.Location = New System.Drawing.Point(5, 25)
        Me.lblFuel.Name = "lblFuel"
        Me.lblFuel.Size = New System.Drawing.Size(165, 16)
        Me.lblFuel.TabIndex = 0
        Me.lblFuel.Text = "Average fuel consumption:"
        '
        'btnCarBack
        '
        Me.btnCarBack.Location = New System.Drawing.Point(7, 6)
        Me.btnCarBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCarBack.Name = "btnCarBack"
        Me.btnCarBack.Size = New System.Drawing.Size(75, 23)
        Me.btnCarBack.TabIndex = 2
        Me.btnCarBack.Text = "Back"
        Me.btnCarBack.UseVisualStyleBackColor = True
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(707, 6)
        Me.btnAddCar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCar.TabIndex = 1
        Me.btnAddCar.Text = "Add car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'dgvCarsList
        '
        Me.dgvCarsList.ColumnHeadersHeight = 29
        Me.dgvCarsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCarsList.Location = New System.Drawing.Point(5, 34)
        Me.dgvCarsList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCarsList.Name = "dgvCarsList"
        Me.dgvCarsList.ReadOnly = True
        Me.dgvCarsList.RowHeadersVisible = False
        Me.dgvCarsList.RowHeadersWidth = 51
        Me.dgvCarsList.RowTemplate.Height = 24
        Me.dgvCarsList.Size = New System.Drawing.Size(777, 375)
        Me.dgvCarsList.TabIndex = 0
        '
        'tpGroups
        '
        Me.tpGroups.Controls.Add(Me.btnNewGroup)
        Me.tpGroups.Controls.Add(Me.gbGroups)
        Me.tpGroups.Controls.Add(Me.gbRideHistory)
        Me.tpGroups.Controls.Add(Me.btnLogOut)
        Me.tpGroups.Location = New System.Drawing.Point(4, 28)
        Me.tpGroups.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpGroups.Name = "tpGroups"
        Me.tpGroups.Size = New System.Drawing.Size(789, 414)
        Me.tpGroups.TabIndex = 6
        Me.tpGroups.Text = "Groups"
        Me.tpGroups.UseVisualStyleBackColor = True
        '
        'btnNewGroup
        '
        Me.btnNewGroup.Location = New System.Drawing.Point(289, 6)
        Me.btnNewGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNewGroup.Name = "btnNewGroup"
        Me.btnNewGroup.Size = New System.Drawing.Size(85, 23)
        Me.btnNewGroup.TabIndex = 5
        Me.btnNewGroup.Text = "New group"
        Me.btnNewGroup.UseVisualStyleBackColor = True
        '
        'gbGroups
        '
        Me.gbGroups.Controls.Add(Me.dgvGroupsList)
        Me.gbGroups.Location = New System.Drawing.Point(5, 34)
        Me.gbGroups.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbGroups.Name = "gbGroups"
        Me.gbGroups.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbGroups.Size = New System.Drawing.Size(375, 372)
        Me.gbGroups.TabIndex = 4
        Me.gbGroups.TabStop = False
        Me.gbGroups.Text = "Groups"
        '
        'dgvGroupsList
        '
        Me.dgvGroupsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGroupsList.Location = New System.Drawing.Point(5, 25)
        Me.dgvGroupsList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvGroupsList.Name = "dgvGroupsList"
        Me.dgvGroupsList.ReadOnly = True
        Me.dgvGroupsList.RowHeadersVisible = False
        Me.dgvGroupsList.RowHeadersWidth = 51
        Me.dgvGroupsList.RowTemplate.Height = 24
        Me.dgvGroupsList.Size = New System.Drawing.Size(363, 347)
        Me.dgvGroupsList.TabIndex = 0
        '
        'gbRideHistory
        '
        Me.gbRideHistory.Controls.Add(Me.cbSortRides)
        Me.gbRideHistory.Controls.Add(Me.dgvUserHistoryList)
        Me.gbRideHistory.Location = New System.Drawing.Point(387, 6)
        Me.gbRideHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbRideHistory.Name = "gbRideHistory"
        Me.gbRideHistory.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbRideHistory.Size = New System.Drawing.Size(399, 404)
        Me.gbRideHistory.TabIndex = 3
        Me.gbRideHistory.TabStop = False
        Me.gbRideHistory.Text = "Ride history"
        '
        'cbSortRides
        '
        Me.cbSortRides.FormattingEnabled = True
        Me.cbSortRides.Items.AddRange(New Object() {"A -> Z", "Z -> A", "Newest -> Oldest", "Oldest -> Newest", "Distance: Ascending", "Distance: Decending"})
        Me.cbSortRides.Location = New System.Drawing.Point(272, 25)
        Me.cbSortRides.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSortRides.Name = "cbSortRides"
        Me.cbSortRides.Size = New System.Drawing.Size(121, 24)
        Me.cbSortRides.TabIndex = 2
        Me.cbSortRides.Text = "Sort"
        '
        'dgvUserHistoryList
        '
        Me.dgvUserHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserHistoryList.Location = New System.Drawing.Point(7, 53)
        Me.dgvUserHistoryList.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvUserHistoryList.Name = "dgvUserHistoryList"
        Me.dgvUserHistoryList.ReadOnly = True
        Me.dgvUserHistoryList.RowHeadersVisible = False
        Me.dgvUserHistoryList.RowHeadersWidth = 51
        Me.dgvUserHistoryList.RowTemplate.Height = 24
        Me.dgvUserHistoryList.Size = New System.Drawing.Size(387, 347)
        Me.dgvUserHistoryList.TabIndex = 1
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(7, 6)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log out"
        Me.btnLogOut.UseVisualStyleBackColor = True
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
        Me.tpLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Size = New System.Drawing.Size(789, 414)
        Me.tpLogin.TabIndex = 5
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Location = New System.Drawing.Point(288, 188)
        Me.txtLoginPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Size = New System.Drawing.Size(220, 22)
        Me.txtLoginPassword.TabIndex = 18
        Me.txtLoginPassword.UseSystemPasswordChar = True
        '
        'txtLoginEmail
        '
        Me.txtLoginEmail.Location = New System.Drawing.Point(288, 133)
        Me.txtLoginEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLoginEmail.Name = "txtLoginEmail"
        Me.txtLoginEmail.Size = New System.Drawing.Size(220, 22)
        Me.txtLoginEmail.TabIndex = 17
        '
        'lblLoginPassword
        '
        Me.lblLoginPassword.AutoSize = True
        Me.lblLoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginPassword.Location = New System.Drawing.Point(195, 188)
        Me.lblLoginPassword.Name = "lblLoginPassword"
        Me.lblLoginPassword.Size = New System.Drawing.Size(88, 20)
        Me.lblLoginPassword.TabIndex = 16
        Me.lblLoginPassword.Text = "Password:"
        '
        'lblLoginEmail
        '
        Me.lblLoginEmail.AutoSize = True
        Me.lblLoginEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginEmail.Location = New System.Drawing.Point(227, 133)
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
        Me.tcTabs.Controls.Add(Me.tpAddCar)
        Me.tcTabs.Controls.Add(Me.tpAddProblem)
        Me.tcTabs.Controls.Add(Me.tpAddLog)
        Me.tcTabs.Controls.Add(Me.tpNewGroup)
        Me.tcTabs.Controls.Add(Me.tpRegister)
        Me.tcTabs.Controls.Add(Me.tpUpdateInsurance)
        Me.tcTabs.Controls.Add(Me.tpAddMember)
        Me.tcTabs.Location = New System.Drawing.Point(4, 2)
        Me.tcTabs.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(797, 446)
        Me.tcTabs.TabIndex = 0
        '
        'tpAddProblem
        '
        Me.tpAddProblem.Controls.Add(Me.btnAddProblemEnter)
        Me.tpAddProblem.Controls.Add(Me.btnAddProblemCancel)
        Me.tpAddProblem.Controls.Add(Me.cbCriticality)
        Me.tpAddProblem.Controls.Add(Me.txtProblemDescription)
        Me.tpAddProblem.Controls.Add(Me.lblCriticality)
        Me.tpAddProblem.Controls.Add(Me.lblIssueDescription)
        Me.tpAddProblem.Controls.Add(Me.lblProblemReportTitle)
        Me.tpAddProblem.Location = New System.Drawing.Point(4, 28)
        Me.tpAddProblem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpAddProblem.Name = "tpAddProblem"
        Me.tpAddProblem.Size = New System.Drawing.Size(789, 414)
        Me.tpAddProblem.TabIndex = 8
        Me.tpAddProblem.Text = "Add Problem"
        Me.tpAddProblem.UseVisualStyleBackColor = True
        '
        'btnAddProblemEnter
        '
        Me.btnAddProblemEnter.Location = New System.Drawing.Point(405, 278)
        Me.btnAddProblemEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProblemEnter.Name = "btnAddProblemEnter"
        Me.btnAddProblemEnter.Size = New System.Drawing.Size(108, 55)
        Me.btnAddProblemEnter.TabIndex = 6
        Me.btnAddProblemEnter.Text = "Enter"
        Me.btnAddProblemEnter.UseVisualStyleBackColor = True
        '
        'btnAddProblemCancel
        '
        Me.btnAddProblemCancel.Location = New System.Drawing.Point(268, 278)
        Me.btnAddProblemCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProblemCancel.Name = "btnAddProblemCancel"
        Me.btnAddProblemCancel.Size = New System.Drawing.Size(108, 54)
        Me.btnAddProblemCancel.TabIndex = 5
        Me.btnAddProblemCancel.Text = "Cancel"
        Me.btnAddProblemCancel.UseVisualStyleBackColor = True
        '
        'cbCriticality
        '
        Me.cbCriticality.AutoSize = True
        Me.cbCriticality.Location = New System.Drawing.Point(437, 241)
        Me.cbCriticality.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCriticality.Name = "cbCriticality"
        Me.cbCriticality.Size = New System.Drawing.Size(76, 20)
        Me.cbCriticality.TabIndex = 4
        Me.cbCriticality.Text = "Critical?"
        Me.cbCriticality.UseVisualStyleBackColor = True
        '
        'txtProblemDescription
        '
        Me.txtProblemDescription.Location = New System.Drawing.Point(268, 161)
        Me.txtProblemDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProblemDescription.Multiline = True
        Me.txtProblemDescription.Name = "txtProblemDescription"
        Me.txtProblemDescription.Size = New System.Drawing.Size(245, 73)
        Me.txtProblemDescription.TabIndex = 3
        '
        'lblCriticality
        '
        Me.lblCriticality.AutoSize = True
        Me.lblCriticality.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblCriticality.Location = New System.Drawing.Point(264, 238)
        Me.lblCriticality.Name = "lblCriticality"
        Me.lblCriticality.Size = New System.Drawing.Size(167, 24)
        Me.lblCriticality.TabIndex = 2
        Me.lblCriticality.Text = "Is it a critical issue?"
        '
        'lblIssueDescription
        '
        Me.lblIssueDescription.AutoSize = True
        Me.lblIssueDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblIssueDescription.Location = New System.Drawing.Point(303, 134)
        Me.lblIssueDescription.Name = "lblIssueDescription"
        Me.lblIssueDescription.Size = New System.Drawing.Size(165, 24)
        Me.lblIssueDescription.TabIndex = 1
        Me.lblIssueDescription.Text = "Describe the issue"
        '
        'lblProblemReportTitle
        '
        Me.lblProblemReportTitle.AutoSize = True
        Me.lblProblemReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblProblemReportTitle.Location = New System.Drawing.Point(285, 71)
        Me.lblProblemReportTitle.Name = "lblProblemReportTitle"
        Me.lblProblemReportTitle.Size = New System.Drawing.Size(201, 29)
        Me.lblProblemReportTitle.TabIndex = 0
        Me.lblProblemReportTitle.Text = "Report a problem"
        '
        'tpAddLog
        '
        Me.tpAddLog.Controls.Add(Me.btnAddLogEnter)
        Me.tpAddLog.Controls.Add(Me.btnAddLogCancel)
        Me.tpAddLog.Controls.Add(Me.gbEnd)
        Me.tpAddLog.Controls.Add(Me.gbStart)
        Me.tpAddLog.Controls.Add(Me.txtLogComment)
        Me.tpAddLog.Controls.Add(Me.txtTotalDistance)
        Me.tpAddLog.Controls.Add(Me.lblLogCommentAdd)
        Me.tpAddLog.Controls.Add(Me.lblDistanceAdd)
        Me.tpAddLog.Controls.Add(Me.lblAddLogTitle)
        Me.tpAddLog.Location = New System.Drawing.Point(4, 28)
        Me.tpAddLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpAddLog.Name = "tpAddLog"
        Me.tpAddLog.Size = New System.Drawing.Size(789, 414)
        Me.tpAddLog.TabIndex = 9
        Me.tpAddLog.Text = "Add Log"
        Me.tpAddLog.UseVisualStyleBackColor = True
        '
        'btnAddLogEnter
        '
        Me.btnAddLogEnter.Location = New System.Drawing.Point(603, 341)
        Me.btnAddLogEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddLogEnter.Name = "btnAddLogEnter"
        Me.btnAddLogEnter.Size = New System.Drawing.Size(132, 46)
        Me.btnAddLogEnter.TabIndex = 18
        Me.btnAddLogEnter.Text = "Enter"
        Me.btnAddLogEnter.UseVisualStyleBackColor = True
        '
        'btnAddLogCancel
        '
        Me.btnAddLogCancel.Location = New System.Drawing.Point(393, 341)
        Me.btnAddLogCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddLogCancel.Name = "btnAddLogCancel"
        Me.btnAddLogCancel.Size = New System.Drawing.Size(132, 44)
        Me.btnAddLogCancel.TabIndex = 17
        Me.btnAddLogCancel.Text = "Cancel"
        Me.btnAddLogCancel.UseVisualStyleBackColor = True
        '
        'gbEnd
        '
        Me.gbEnd.Controls.Add(Me.lblEndAdd)
        Me.gbEnd.Controls.Add(Me.txtLocationEnd)
        Me.gbEnd.Controls.Add(Me.dtpEndDate)
        Me.gbEnd.Controls.Add(Me.lblEndDateAdd)
        Me.gbEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gbEnd.Location = New System.Drawing.Point(383, 43)
        Me.gbEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbEnd.Name = "gbEnd"
        Me.gbEnd.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbEnd.Size = New System.Drawing.Size(351, 199)
        Me.gbEnd.TabIndex = 16
        Me.gbEnd.TabStop = False
        Me.gbEnd.Text = "End"
        '
        'lblEndAdd
        '
        Me.lblEndAdd.AutoSize = True
        Me.lblEndAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblEndAdd.Location = New System.Drawing.Point(5, 38)
        Me.lblEndAdd.Name = "lblEndAdd"
        Me.lblEndAdd.Size = New System.Drawing.Size(81, 24)
        Me.lblEndAdd.TabIndex = 2
        Me.lblEndAdd.Text = "Location"
        '
        'txtLocationEnd
        '
        Me.txtLocationEnd.Location = New System.Drawing.Point(93, 38)
        Me.txtLocationEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLocationEnd.Name = "txtLocationEnd"
        Me.txtLocationEnd.Size = New System.Drawing.Size(252, 28)
        Me.txtLocationEnd.TabIndex = 8
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(11, 130)
        Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(335, 28)
        Me.dtpEndDate.TabIndex = 14
        '
        'lblEndDateAdd
        '
        Me.lblEndDateAdd.AutoSize = True
        Me.lblEndDateAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblEndDateAdd.Location = New System.Drawing.Point(5, 90)
        Me.lblEndDateAdd.Name = "lblEndDateAdd"
        Me.lblEndDateAdd.Size = New System.Drawing.Size(125, 24)
        Me.lblEndDateAdd.TabIndex = 5
        Me.lblEndDateAdd.Text = "Date and time"
        '
        'gbStart
        '
        Me.gbStart.Controls.Add(Me.lblStartDateAdd)
        Me.gbStart.Controls.Add(Me.lblAddStart)
        Me.gbStart.Controls.Add(Me.dtpStartDate)
        Me.gbStart.Controls.Add(Me.txtLocationStart)
        Me.gbStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gbStart.Location = New System.Drawing.Point(5, 43)
        Me.gbStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbStart.Name = "gbStart"
        Me.gbStart.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbStart.Size = New System.Drawing.Size(353, 190)
        Me.gbStart.TabIndex = 15
        Me.gbStart.TabStop = False
        Me.gbStart.Text = "Start"
        '
        'lblStartDateAdd
        '
        Me.lblStartDateAdd.AutoSize = True
        Me.lblStartDateAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblStartDateAdd.Location = New System.Drawing.Point(5, 90)
        Me.lblStartDateAdd.Name = "lblStartDateAdd"
        Me.lblStartDateAdd.Size = New System.Drawing.Size(125, 24)
        Me.lblStartDateAdd.TabIndex = 4
        Me.lblStartDateAdd.Text = "Date and time"
        '
        'lblAddStart
        '
        Me.lblAddStart.AutoSize = True
        Me.lblAddStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblAddStart.Location = New System.Drawing.Point(5, 38)
        Me.lblAddStart.Name = "lblAddStart"
        Me.lblAddStart.Size = New System.Drawing.Size(81, 24)
        Me.lblAddStart.TabIndex = 1
        Me.lblAddStart.Text = "Location"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(5, 130)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(341, 28)
        Me.dtpStartDate.TabIndex = 13
        Me.dtpStartDate.Value = New Date(2025, 4, 24, 0, 0, 0, 0)
        '
        'txtLocationStart
        '
        Me.txtLocationStart.Location = New System.Drawing.Point(93, 34)
        Me.txtLocationStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLocationStart.Name = "txtLocationStart"
        Me.txtLocationStart.Size = New System.Drawing.Size(255, 28)
        Me.txtLocationStart.TabIndex = 7
        '
        'txtLogComment
        '
        Me.txtLogComment.Location = New System.Drawing.Point(144, 320)
        Me.txtLogComment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLogComment.Multiline = True
        Me.txtLogComment.Name = "txtLogComment"
        Me.txtLogComment.Size = New System.Drawing.Size(215, 66)
        Me.txtLogComment.TabIndex = 12
        '
        'txtTotalDistance
        '
        Me.txtTotalDistance.Location = New System.Drawing.Point(144, 256)
        Me.txtTotalDistance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalDistance.Name = "txtTotalDistance"
        Me.txtTotalDistance.Size = New System.Drawing.Size(209, 22)
        Me.txtTotalDistance.TabIndex = 11
        '
        'lblLogCommentAdd
        '
        Me.lblLogCommentAdd.AutoSize = True
        Me.lblLogCommentAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblLogCommentAdd.Location = New System.Drawing.Point(12, 341)
        Me.lblLogCommentAdd.Name = "lblLogCommentAdd"
        Me.lblLogCommentAdd.Size = New System.Drawing.Size(101, 24)
        Me.lblLogCommentAdd.TabIndex = 6
        Me.lblLogCommentAdd.Text = "Comments"
        '
        'lblDistanceAdd
        '
        Me.lblDistanceAdd.AutoSize = True
        Me.lblDistanceAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblDistanceAdd.Location = New System.Drawing.Point(12, 254)
        Me.lblDistanceAdd.Name = "lblDistanceAdd"
        Me.lblDistanceAdd.Size = New System.Drawing.Size(126, 24)
        Me.lblDistanceAdd.TabIndex = 3
        Me.lblDistanceAdd.Text = "Total distance"
        '
        'lblAddLogTitle
        '
        Me.lblAddLogTitle.AutoSize = True
        Me.lblAddLogTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblAddLogTitle.Location = New System.Drawing.Point(265, 11)
        Me.lblAddLogTitle.Name = "lblAddLogTitle"
        Me.lblAddLogTitle.Size = New System.Drawing.Size(171, 29)
        Me.lblAddLogTitle.TabIndex = 0
        Me.lblAddLogTitle.Text = "Register a ride"
        '
        'tpNewGroup
        '
        Me.tpNewGroup.Controls.Add(Me.lblGroupName)
        Me.tpNewGroup.Controls.Add(Me.btnCancelNewGroup)
        Me.tpNewGroup.Controls.Add(Me.btnEnterNewGroup)
        Me.tpNewGroup.Controls.Add(Me.txtNewGroupName)
        Me.tpNewGroup.Controls.Add(Me.lblCreateGroup)
        Me.tpNewGroup.Location = New System.Drawing.Point(4, 28)
        Me.tpNewGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpNewGroup.Name = "tpNewGroup"
        Me.tpNewGroup.Size = New System.Drawing.Size(789, 414)
        Me.tpNewGroup.TabIndex = 10
        Me.tpNewGroup.Text = "New Group"
        Me.tpNewGroup.UseVisualStyleBackColor = True
        '
        'lblGroupName
        '
        Me.lblGroupName.AutoSize = True
        Me.lblGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblGroupName.Location = New System.Drawing.Point(179, 171)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(116, 24)
        Me.lblGroupName.TabIndex = 4
        Me.lblGroupName.Text = "Group name"
        '
        'btnCancelNewGroup
        '
        Me.btnCancelNewGroup.Location = New System.Drawing.Point(181, 318)
        Me.btnCancelNewGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelNewGroup.Name = "btnCancelNewGroup"
        Me.btnCancelNewGroup.Size = New System.Drawing.Size(115, 50)
        Me.btnCancelNewGroup.TabIndex = 3
        Me.btnCancelNewGroup.Text = "Cancel"
        Me.btnCancelNewGroup.UseVisualStyleBackColor = True
        '
        'btnEnterNewGroup
        '
        Me.btnEnterNewGroup.Location = New System.Drawing.Point(451, 318)
        Me.btnEnterNewGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnterNewGroup.Name = "btnEnterNewGroup"
        Me.btnEnterNewGroup.Size = New System.Drawing.Size(115, 50)
        Me.btnEnterNewGroup.TabIndex = 2
        Me.btnEnterNewGroup.Text = "Enter"
        Me.btnEnterNewGroup.UseVisualStyleBackColor = True
        '
        'txtNewGroupName
        '
        Me.txtNewGroupName.Location = New System.Drawing.Point(348, 173)
        Me.txtNewGroupName.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtNewGroupName.Name = "txtNewGroupName"
        Me.txtNewGroupName.Size = New System.Drawing.Size(345, 22)
        Me.txtNewGroupName.TabIndex = 1
        '
        'lblCreateGroup
        '
        Me.lblCreateGroup.AutoSize = True
        Me.lblCreateGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblCreateGroup.Location = New System.Drawing.Point(273, 14)
        Me.lblCreateGroup.Name = "lblCreateGroup"
        Me.lblCreateGroup.Size = New System.Drawing.Size(205, 29)
        Me.lblCreateGroup.TabIndex = 0
        Me.lblCreateGroup.Text = "Create new group"
        '
        'tpRegister
        '
        Me.tpRegister.Controls.Add(Me.lblCreateAccountTitle)
        Me.tpRegister.Controls.Add(Me.lblConfirmPassword)
        Me.tpRegister.Controls.Add(Me.lblRegisterPassword)
        Me.tpRegister.Controls.Add(Me.lblRegisterEmail)
        Me.tpRegister.Controls.Add(Me.tbRegisterPasswordConfirm)
        Me.tpRegister.Controls.Add(Me.tbRegisterPassword)
        Me.tpRegister.Controls.Add(Me.tbRegisterEmail)
        Me.tpRegister.Controls.Add(Me.btnRegisterEnter)
        Me.tpRegister.Controls.Add(Me.btnRegisterCancel)
        Me.tpRegister.Location = New System.Drawing.Point(4, 28)
        Me.tpRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpRegister.Name = "tpRegister"
        Me.tpRegister.Size = New System.Drawing.Size(789, 414)
        Me.tpRegister.TabIndex = 11
        Me.tpRegister.Text = "Register"
        Me.tpRegister.UseVisualStyleBackColor = True
        '
        'lblCreateAccountTitle
        '
        Me.lblCreateAccountTitle.AutoSize = True
        Me.lblCreateAccountTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblCreateAccountTitle.Location = New System.Drawing.Point(335, 46)
        Me.lblCreateAccountTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCreateAccountTitle.Name = "lblCreateAccountTitle"
        Me.lblCreateAccountTitle.Size = New System.Drawing.Size(244, 29)
        Me.lblCreateAccountTitle.TabIndex = 8
        Me.lblCreateAccountTitle.Text = "Create a new account"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblConfirmPassword.Location = New System.Drawing.Point(224, 244)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(166, 24)
        Me.lblConfirmPassword.TabIndex = 7
        Me.lblConfirmPassword.Text = "Confirm password:"
        '
        'lblRegisterPassword
        '
        Me.lblRegisterPassword.AutoSize = True
        Me.lblRegisterPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblRegisterPassword.Location = New System.Drawing.Point(224, 188)
        Me.lblRegisterPassword.Name = "lblRegisterPassword"
        Me.lblRegisterPassword.Size = New System.Drawing.Size(97, 24)
        Me.lblRegisterPassword.TabIndex = 6
        Me.lblRegisterPassword.Text = "Password:"
        '
        'lblRegisterEmail
        '
        Me.lblRegisterEmail.AutoSize = True
        Me.lblRegisterEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblRegisterEmail.Location = New System.Drawing.Point(224, 124)
        Me.lblRegisterEmail.Name = "lblRegisterEmail"
        Me.lblRegisterEmail.Size = New System.Drawing.Size(62, 24)
        Me.lblRegisterEmail.TabIndex = 5
        Me.lblRegisterEmail.Text = "Email:"
        '
        'tbRegisterPasswordConfirm
        '
        Me.tbRegisterPasswordConfirm.Location = New System.Drawing.Point(427, 246)
        Me.tbRegisterPasswordConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbRegisterPasswordConfirm.Name = "tbRegisterPasswordConfirm"
        Me.tbRegisterPasswordConfirm.Size = New System.Drawing.Size(100, 22)
        Me.tbRegisterPasswordConfirm.TabIndex = 4
        '
        'tbRegisterPassword
        '
        Me.tbRegisterPassword.Location = New System.Drawing.Point(427, 190)
        Me.tbRegisterPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbRegisterPassword.Name = "tbRegisterPassword"
        Me.tbRegisterPassword.Size = New System.Drawing.Size(100, 22)
        Me.tbRegisterPassword.TabIndex = 3
        '
        'tbRegisterEmail
        '
        Me.tbRegisterEmail.Location = New System.Drawing.Point(427, 126)
        Me.tbRegisterEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbRegisterEmail.Name = "tbRegisterEmail"
        Me.tbRegisterEmail.Size = New System.Drawing.Size(100, 22)
        Me.tbRegisterEmail.TabIndex = 2
        '
        'btnRegisterEnter
        '
        Me.btnRegisterEnter.Location = New System.Drawing.Point(452, 326)
        Me.btnRegisterEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegisterEnter.Name = "btnRegisterEnter"
        Me.btnRegisterEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnRegisterEnter.TabIndex = 1
        Me.btnRegisterEnter.Text = "Enter"
        Me.btnRegisterEnter.UseVisualStyleBackColor = True
        '
        'btnRegisterCancel
        '
        Me.btnRegisterCancel.Location = New System.Drawing.Point(228, 326)
        Me.btnRegisterCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegisterCancel.Name = "btnRegisterCancel"
        Me.btnRegisterCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnRegisterCancel.TabIndex = 0
        Me.btnRegisterCancel.Text = "Cancel"
        Me.btnRegisterCancel.UseVisualStyleBackColor = True
        '
        'tpUpdateInsurance
        '
        Me.tpUpdateInsurance.Controls.Add(Me.lblUpdateInsuranceTitle)
        Me.tpUpdateInsurance.Controls.Add(Me.btnUpdateInsuranceEnter)
        Me.tpUpdateInsurance.Controls.Add(Me.btnUpdateInsuranceCancel)
        Me.tpUpdateInsurance.Controls.Add(Me.dtpInsuranceExpiration)
        Me.tpUpdateInsurance.Controls.Add(Me.txtUpdateInsuranceName)
        Me.tpUpdateInsurance.Controls.Add(Me.lblUpdateExpiration)
        Me.tpUpdateInsurance.Controls.Add(Me.lblUpdateName)
        Me.tpUpdateInsurance.Location = New System.Drawing.Point(4, 28)
        Me.tpUpdateInsurance.Margin = New System.Windows.Forms.Padding(4)
        Me.tpUpdateInsurance.Name = "tpUpdateInsurance"
        Me.tpUpdateInsurance.Size = New System.Drawing.Size(789, 414)
        Me.tpUpdateInsurance.TabIndex = 12
        Me.tpUpdateInsurance.Text = "Update insurance"
        Me.tpUpdateInsurance.UseVisualStyleBackColor = True
        '
        'lblUpdateInsuranceTitle
        '
        Me.lblUpdateInsuranceTitle.AutoSize = True
        Me.lblUpdateInsuranceTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblUpdateInsuranceTitle.Location = New System.Drawing.Point(275, 24)
        Me.lblUpdateInsuranceTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdateInsuranceTitle.Name = "lblUpdateInsuranceTitle"
        Me.lblUpdateInsuranceTitle.Size = New System.Drawing.Size(201, 29)
        Me.lblUpdateInsuranceTitle.TabIndex = 6
        Me.lblUpdateInsuranceTitle.Text = "Update insurance"
        '
        'btnUpdateInsuranceEnter
        '
        Me.btnUpdateInsuranceEnter.Location = New System.Drawing.Point(566, 314)
        Me.btnUpdateInsuranceEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateInsuranceEnter.Name = "btnUpdateInsuranceEnter"
        Me.btnUpdateInsuranceEnter.Size = New System.Drawing.Size(100, 69)
        Me.btnUpdateInsuranceEnter.TabIndex = 5
        Me.btnUpdateInsuranceEnter.Text = "Enter"
        Me.btnUpdateInsuranceEnter.UseVisualStyleBackColor = True
        '
        'btnUpdateInsuranceCancel
        '
        Me.btnUpdateInsuranceCancel.Location = New System.Drawing.Point(114, 314)
        Me.btnUpdateInsuranceCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateInsuranceCancel.Name = "btnUpdateInsuranceCancel"
        Me.btnUpdateInsuranceCancel.Size = New System.Drawing.Size(100, 69)
        Me.btnUpdateInsuranceCancel.TabIndex = 4
        Me.btnUpdateInsuranceCancel.Text = "Cancel"
        Me.btnUpdateInsuranceCancel.UseVisualStyleBackColor = True
        '
        'dtpInsuranceExpiration
        '
        Me.dtpInsuranceExpiration.Location = New System.Drawing.Point(346, 212)
        Me.dtpInsuranceExpiration.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpInsuranceExpiration.Name = "dtpInsuranceExpiration"
        Me.dtpInsuranceExpiration.Size = New System.Drawing.Size(319, 22)
        Me.dtpInsuranceExpiration.TabIndex = 3
        '
        'txtUpdateInsuranceName
        '
        Me.txtUpdateInsuranceName.Location = New System.Drawing.Point(346, 136)
        Me.txtUpdateInsuranceName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUpdateInsuranceName.Name = "txtUpdateInsuranceName"
        Me.txtUpdateInsuranceName.Size = New System.Drawing.Size(319, 22)
        Me.txtUpdateInsuranceName.TabIndex = 2
        '
        'lblUpdateExpiration
        '
        Me.lblUpdateExpiration.AutoSize = True
        Me.lblUpdateExpiration.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblUpdateExpiration.Location = New System.Drawing.Point(109, 210)
        Me.lblUpdateExpiration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdateExpiration.Name = "lblUpdateExpiration"
        Me.lblUpdateExpiration.Size = New System.Drawing.Size(140, 24)
        Me.lblUpdateExpiration.TabIndex = 1
        Me.lblUpdateExpiration.Text = "Expiration date:"
        '
        'lblUpdateName
        '
        Me.lblUpdateName.AutoSize = True
        Me.lblUpdateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblUpdateName.Location = New System.Drawing.Point(109, 133)
        Me.lblUpdateName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdateName.Name = "lblUpdateName"
        Me.lblUpdateName.Size = New System.Drawing.Size(172, 24)
        Me.lblUpdateName.TabIndex = 0
        Me.lblUpdateName.Text = "Insurance provider:"
        '
        'tpAddMember
        '
        Me.tpAddMember.Controls.Add(Me.txtMemberEmail)
        Me.tpAddMember.Controls.Add(Me.lblAddMemberTitle)
        Me.tpAddMember.Controls.Add(Me.lblMemberEmail)
        Me.tpAddMember.Controls.Add(Me.btnAddMemberEnter)
        Me.tpAddMember.Controls.Add(Me.btnAddMemberCancel)
        Me.tpAddMember.Controls.Add(Me.cbIsAdmin)
        Me.tpAddMember.Location = New System.Drawing.Point(4, 28)
        Me.tpAddMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpAddMember.Name = "tpAddMember"
        Me.tpAddMember.Size = New System.Drawing.Size(789, 414)
        Me.tpAddMember.TabIndex = 13
        Me.tpAddMember.Text = "Add member"
        Me.tpAddMember.UseVisualStyleBackColor = True
        '
        'txtMemberEmail
        '
        Me.txtMemberEmail.Location = New System.Drawing.Point(303, 172)
        Me.txtMemberEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMemberEmail.Name = "txtMemberEmail"
        Me.txtMemberEmail.Size = New System.Drawing.Size(212, 22)
        Me.txtMemberEmail.TabIndex = 5
        '
        'lblAddMemberTitle
        '
        Me.lblAddMemberTitle.AutoSize = True
        Me.lblAddMemberTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblAddMemberTitle.Location = New System.Drawing.Point(252, 75)
        Me.lblAddMemberTitle.Name = "lblAddMemberTitle"
        Me.lblAddMemberTitle.Size = New System.Drawing.Size(247, 29)
        Me.lblAddMemberTitle.TabIndex = 4
        Me.lblAddMemberTitle.Text = "Add member to group"
        '
        'lblMemberEmail
        '
        Me.lblMemberEmail.AutoSize = True
        Me.lblMemberEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblMemberEmail.Location = New System.Drawing.Point(219, 170)
        Me.lblMemberEmail.Name = "lblMemberEmail"
        Me.lblMemberEmail.Size = New System.Drawing.Size(62, 24)
        Me.lblMemberEmail.TabIndex = 3
        Me.lblMemberEmail.Text = "Email:"
        '
        'btnAddMemberEnter
        '
        Me.btnAddMemberEnter.Location = New System.Drawing.Point(440, 292)
        Me.btnAddMemberEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddMemberEnter.Name = "btnAddMemberEnter"
        Me.btnAddMemberEnter.Size = New System.Drawing.Size(75, 60)
        Me.btnAddMemberEnter.TabIndex = 2
        Me.btnAddMemberEnter.Text = "Enter"
        Me.btnAddMemberEnter.UseVisualStyleBackColor = True
        '
        'btnAddMemberCancel
        '
        Me.btnAddMemberCancel.Location = New System.Drawing.Point(221, 292)
        Me.btnAddMemberCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddMemberCancel.Name = "btnAddMemberCancel"
        Me.btnAddMemberCancel.Size = New System.Drawing.Size(75, 60)
        Me.btnAddMemberCancel.TabIndex = 1
        Me.btnAddMemberCancel.Text = "Cancel"
        Me.btnAddMemberCancel.UseVisualStyleBackColor = True
        '
        'cbIsAdmin
        '
        Me.cbIsAdmin.AutoSize = True
        Me.cbIsAdmin.Location = New System.Drawing.Point(303, 208)
        Me.cbIsAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbIsAdmin.Name = "cbIsAdmin"
        Me.cbIsAdmin.Size = New System.Drawing.Size(74, 20)
        Me.cbIsAdmin.TabIndex = 0
        Me.cbIsAdmin.Text = "Admin?"
        Me.cbIsAdmin.UseVisualStyleBackColor = True
        '
        'formTableViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tcTabs)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "formTableViewer"
        Me.Text = "Car Logbook"
        Me.tpAddCar.ResumeLayout(False)
        Me.tpAddCar.PerformLayout()
        Me.tpCarsList.ResumeLayout(False)
        Me.pnlLogs.ResumeLayout(False)
        CType(Me.dgvLogsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLogDetails.ResumeLayout(False)
        Me.gbLogDetails.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        CType(Me.dgvProblemsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCarDetails.ResumeLayout(False)
        Me.gbCarDetails.PerformLayout()
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpGroups.ResumeLayout(False)
        Me.gbGroups.ResumeLayout(False)
        CType(Me.dgvGroupsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRideHistory.ResumeLayout(False)
        CType(Me.dgvUserHistoryList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpLogin.ResumeLayout(False)
        Me.tpLogin.PerformLayout()
        Me.tcTabs.ResumeLayout(False)
        Me.tpAddProblem.ResumeLayout(False)
        Me.tpAddProblem.PerformLayout()
        Me.tpAddLog.ResumeLayout(False)
        Me.tpAddLog.PerformLayout()
        Me.gbEnd.ResumeLayout(False)
        Me.gbEnd.PerformLayout()
        Me.gbStart.ResumeLayout(False)
        Me.gbStart.PerformLayout()
        Me.tpNewGroup.ResumeLayout(False)
        Me.tpNewGroup.PerformLayout()
        Me.tpRegister.ResumeLayout(False)
        Me.tpRegister.PerformLayout()
        Me.tpUpdateInsurance.ResumeLayout(False)
        Me.tpUpdateInsurance.PerformLayout()
        Me.tpAddMember.ResumeLayout(False)
        Me.tpAddMember.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tpAddCar As TabPage
    Friend WithEvents btnAddCarEnter As Button
    Friend WithEvents btnAddCarCancel As Button
    Friend WithEvents cboxAddCarIsArchived As CheckBox
    Friend WithEvents cboxAddCarIsAvailable As CheckBox
    Friend WithEvents txtAddCarMileage As TextBox
    Friend WithEvents txtAddCarAvgFuel As TextBox
    Friend WithEvents txtAddCarName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblMileage As Label
    Friend WithEvents lblAvgFuel As Label
    Friend WithEvents lblReady As Label
    Friend WithEvents lblArchive As Label
    Friend WithEvents lblHeader As Label
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
    Friend WithEvents btnLogs As Button
    Friend WithEvents gbCarDetails As GroupBox
    Friend WithEvents lblInsuranceData As Label
    Friend WithEvents lblMilageData As Label
    Friend WithEvents lblFuelData As Label
    Friend WithEvents dgvProblemsList As DataGridView
    Friend WithEvents btnAddProblem As Button
    Friend WithEvents tpAddProblem As TabPage
    Friend WithEvents pnlLogs As Panel
    Friend WithEvents gbLogDetails As GroupBox
    Friend WithEvents dgvLogsList As DataGridView
    Friend WithEvents btnProblems As Button
    Friend WithEvents btnAddLog As Button
    Friend WithEvents lblEndTime As Label
    Friend WithEvents lblLogComment As Label
    Friend WithEvents lblTotalDistance As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblEndData As Label
    Friend WithEvents lblStartData As Label
    Friend WithEvents lblCommentData As Label
    Friend WithEvents lblDistanceData As Label
    Friend WithEvents lblProblemReportTitle As Label
    Friend WithEvents tpAddLog As TabPage
    Friend WithEvents lblIssueDescription As Label
    Friend WithEvents lblCriticality As Label
    Friend WithEvents cbCriticality As CheckBox
    Friend WithEvents txtProblemDescription As TextBox
    Friend WithEvents btnAddProblemEnter As Button
    Friend WithEvents btnAddProblemCancel As Button
    Friend WithEvents lblAddStart As Label
    Friend WithEvents lblAddLogTitle As Label
    Friend WithEvents lblLogCommentAdd As Label
    Friend WithEvents lblEndDateAdd As Label
    Friend WithEvents lblStartDateAdd As Label
    Friend WithEvents lblDistanceAdd As Label
    Friend WithEvents lblEndAdd As Label
    Friend WithEvents txtLocationStart As TextBox
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents txtLogComment As TextBox
    Friend WithEvents txtTotalDistance As TextBox
    Friend WithEvents txtLocationEnd As TextBox
    Friend WithEvents gbStart As GroupBox
    Friend WithEvents gbEnd As GroupBox
    Friend WithEvents btnAddLogCancel As Button
    Friend WithEvents btnAddLogEnter As Button
    Friend WithEvents dgvGroupsList As DataGridView
    Friend WithEvents btnLogOut As Button
    Friend WithEvents dgvUserHistoryList As DataGridView
    Friend WithEvents gbRideHistory As GroupBox
    Friend WithEvents cbSortRides As ComboBox
    Friend WithEvents btnNewGroup As Button
    Friend WithEvents gbGroups As GroupBox
    Friend WithEvents registrationPlate As DataGridViewTextBoxColumn
    Friend WithEvents carModel As DataGridViewTextBoxColumn
    Friend WithEvents maintenence As DataGridViewCheckBoxColumn
    Friend WithEvents isAvailable As DataGridViewCheckBoxColumn
    Friend WithEvents DeleteButton As DataGridViewButtonColumn
    Friend WithEvents tpNewGroup As TabPage
    Friend WithEvents btnEnterNewGroup As Button
    Friend WithEvents txtNewGroupName As TextBox
    Friend WithEvents lblCreateGroup As Label
    Friend WithEvents btnCancelNewGroup As Button
    Friend WithEvents lblGroupName As Label
    Friend WithEvents tpRegister As TabPage
    Friend WithEvents btnRegisterEnter As Button
    Friend WithEvents btnRegisterCancel As Button
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblRegisterPassword As Label
    Friend WithEvents lblRegisterEmail As Label
    Friend WithEvents tbRegisterPasswordConfirm As TextBox
    Friend WithEvents tbRegisterPassword As TextBox
    Friend WithEvents tbRegisterEmail As TextBox
    Friend WithEvents lblCreateAccountTitle As Label
    Friend WithEvents dtpStatsTimeEnd As DateTimePicker
    Friend WithEvents btnGetDistance As Button
    Friend WithEvents dtpStatsTimeStart As DateTimePicker
    Friend WithEvents btnDetailsUpdateInsurance As Button
    Friend WithEvents lblInsuranceNameData As Label
    Friend WithEvents lblInsuranceName As Label
    Friend WithEvents tpUpdateInsurance As TabPage
    Friend WithEvents lblUpdateName As Label
    Friend WithEvents dtpInsuranceExpiration As DateTimePicker
    Friend WithEvents txtUpdateInsuranceName As TextBox
    Friend WithEvents lblUpdateExpiration As Label
    Friend WithEvents lblUpdateInsuranceTitle As Label
    Friend WithEvents btnUpdateInsuranceEnter As Button
    Friend WithEvents btnUpdateInsuranceCancel As Button
    Friend WithEvents tpAddMember As TabPage
    Friend WithEvents txtMemberEmail As TextBox
    Friend WithEvents lblAddMemberTitle As Label
    Friend WithEvents lblMemberEmail As Label
    Friend WithEvents btnAddMemberEnter As Button
    Friend WithEvents btnAddMemberCancel As Button
    Friend WithEvents cbIsAdmin As CheckBox
    Friend WithEvents btnAddMember As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddCarRegistrationPlate As TextBox
End Class
