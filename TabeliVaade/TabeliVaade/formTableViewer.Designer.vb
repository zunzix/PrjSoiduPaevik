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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tpCarsList = New System.Windows.Forms.TabPage()
        Me.cbCarsSort = New System.Windows.Forms.ComboBox()
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
        Me.cbRegisterShowPassword = New System.Windows.Forms.CheckBox()
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
        Me.tpAddCar.Controls.Add(Me.lblHeader)
        Me.tpAddCar.Location = New System.Drawing.Point(4, 32)
        Me.tpAddCar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpAddCar.Name = "tpAddCar"
        Me.tpAddCar.Size = New System.Drawing.Size(889, 522)
        Me.tpAddCar.TabIndex = 7
        Me.tpAddCar.Text = "Add Car"
        Me.tpAddCar.UseVisualStyleBackColor = True
        '
        'txtAddCarRegistrationPlate
        '
        Me.txtAddCarRegistrationPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddCarRegistrationPlate.Location = New System.Drawing.Point(406, 85)
        Me.txtAddCarRegistrationPlate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddCarRegistrationPlate.Name = "txtAddCarRegistrationPlate"
        Me.txtAddCarRegistrationPlate.Size = New System.Drawing.Size(444, 26)
        Me.txtAddCarRegistrationPlate.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Registration Plate"
        '
        'btnAddCarEnter
        '
        Me.btnAddCarEnter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddCarEnter.Location = New System.Drawing.Point(488, 434)
        Me.btnAddCarEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddCarEnter.Name = "btnAddCarEnter"
        Me.btnAddCarEnter.Size = New System.Drawing.Size(366, 66)
        Me.btnAddCarEnter.TabIndex = 12
        Me.btnAddCarEnter.Text = "Enter"
        Me.btnAddCarEnter.UseVisualStyleBackColor = False
        '
        'btnAddCarCancel
        '
        Me.btnAddCarCancel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddCarCancel.Location = New System.Drawing.Point(80, 434)
        Me.btnAddCarCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddCarCancel.Name = "btnAddCarCancel"
        Me.btnAddCarCancel.Size = New System.Drawing.Size(366, 66)
        Me.btnAddCarCancel.TabIndex = 11
        Me.btnAddCarCancel.Text = "Cancel"
        Me.btnAddCarCancel.UseVisualStyleBackColor = False
        '
        'cboxAddCarIsArchived
        '
        Me.cboxAddCarIsArchived.AutoSize = True
        Me.cboxAddCarIsArchived.Location = New System.Drawing.Point(558, 322)
        Me.cboxAddCarIsArchived.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxAddCarIsArchived.Name = "cboxAddCarIsArchived"
        Me.cboxAddCarIsArchived.Size = New System.Drawing.Size(113, 24)
        Me.cboxAddCarIsArchived.TabIndex = 10
        Me.cboxAddCarIsArchived.Text = "Archive car"
        Me.cboxAddCarIsArchived.UseVisualStyleBackColor = True
        '
        'cboxAddCarIsAvailable
        '
        Me.cboxAddCarIsAvailable.AutoSize = True
        Me.cboxAddCarIsAvailable.Checked = True
        Me.cboxAddCarIsAvailable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboxAddCarIsAvailable.Location = New System.Drawing.Point(406, 322)
        Me.cboxAddCarIsAvailable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxAddCarIsAvailable.Name = "cboxAddCarIsAvailable"
        Me.cboxAddCarIsAvailable.Size = New System.Drawing.Size(140, 24)
        Me.cboxAddCarIsAvailable.TabIndex = 9
        Me.cboxAddCarIsAvailable.Text = "Car is available"
        Me.cboxAddCarIsAvailable.UseVisualStyleBackColor = True
        '
        'txtAddCarMileage
        '
        Me.txtAddCarMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddCarMileage.Location = New System.Drawing.Point(406, 192)
        Me.txtAddCarMileage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddCarMileage.Name = "txtAddCarMileage"
        Me.txtAddCarMileage.Size = New System.Drawing.Size(446, 26)
        Me.txtAddCarMileage.TabIndex = 8
        '
        'txtAddCarAvgFuel
        '
        Me.txtAddCarAvgFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddCarAvgFuel.Location = New System.Drawing.Point(406, 262)
        Me.txtAddCarAvgFuel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddCarAvgFuel.Name = "txtAddCarAvgFuel"
        Me.txtAddCarAvgFuel.Size = New System.Drawing.Size(446, 26)
        Me.txtAddCarAvgFuel.TabIndex = 7
        '
        'txtAddCarName
        '
        Me.txtAddCarName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddCarName.Location = New System.Drawing.Point(406, 131)
        Me.txtAddCarName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddCarName.Name = "txtAddCarName"
        Me.txtAddCarName.Size = New System.Drawing.Size(444, 26)
        Me.txtAddCarName.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(52, 128)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(108, 26)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Car name"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(51, 189)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(178, 26)
        Me.lblMileage.TabIndex = 4
        Me.lblMileage.Text = "Car mileage [km]"
        '
        'lblAvgFuel
        '
        Me.lblAvgFuel.AutoSize = True
        Me.lblAvgFuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgFuel.Location = New System.Drawing.Point(51, 262)
        Me.lblAvgFuel.Name = "lblAvgFuel"
        Me.lblAvgFuel.Size = New System.Drawing.Size(349, 26)
        Me.lblAvgFuel.TabIndex = 3
        Me.lblAvgFuel.Text = "Car average fuel consumtion [l/km]"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(339, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(208, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Add a car to list"
        '
        'tpCarsList
        '
        Me.tpCarsList.Controls.Add(Me.cbCarsSort)
        Me.tpCarsList.Controls.Add(Me.btnAddMember)
        Me.tpCarsList.Controls.Add(Me.pnlLogs)
        Me.tpCarsList.Controls.Add(Me.pnlDetails)
        Me.tpCarsList.Controls.Add(Me.btnCarBack)
        Me.tpCarsList.Controls.Add(Me.btnAddCar)
        Me.tpCarsList.Controls.Add(Me.dgvCarsList)
        Me.tpCarsList.Location = New System.Drawing.Point(4, 32)
        Me.tpCarsList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpCarsList.Name = "tpCarsList"
        Me.tpCarsList.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpCarsList.Size = New System.Drawing.Size(889, 522)
        Me.tpCarsList.TabIndex = 0
        Me.tpCarsList.Text = "Cars"
        Me.tpCarsList.UseVisualStyleBackColor = True
        '
        'cbCarsSort
        '
        Me.cbCarsSort.FormattingEnabled = True
        Me.cbCarsSort.Items.AddRange(New Object() {"A -> Z", "Z -> A", "Distance: Ascending", "Distance: Descending", "Available", "Unavailable", "Archived", "Unarchived", "Critical"})
        Me.cbCarsSort.Location = New System.Drawing.Point(546, 9)
        Me.cbCarsSort.Name = "cbCarsSort"
        Me.cbCarsSort.Size = New System.Drawing.Size(204, 28)
        Me.cbCarsSort.TabIndex = 6
        Me.cbCarsSort.Text = "Sort"
        '
        'btnAddMember
        '
        Me.btnAddMember.Location = New System.Drawing.Point(356, 8)
        Me.btnAddMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(135, 29)
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
        Me.pnlLogs.Location = New System.Drawing.Point(4, 80)
        Me.pnlLogs.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pnlLogs.Name = "pnlLogs"
        Me.pnlLogs.Size = New System.Drawing.Size(874, 282)
        Me.pnlLogs.TabIndex = 4
        Me.pnlLogs.Visible = False
        '
        'dtpStatsTimeEnd
        '
        Me.dtpStatsTimeEnd.Location = New System.Drawing.Point(579, 242)
        Me.dtpStatsTimeEnd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStatsTimeEnd.Name = "dtpStatsTimeEnd"
        Me.dtpStatsTimeEnd.Size = New System.Drawing.Size(190, 26)
        Me.dtpStatsTimeEnd.TabIndex = 10
        Me.dtpStatsTimeEnd.Value = New Date(2025, 5, 13, 22, 59, 9, 0)
        '
        'btnGetDistance
        '
        Me.btnGetDistance.Location = New System.Drawing.Point(777, 208)
        Me.btnGetDistance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGetDistance.Name = "btnGetDistance"
        Me.btnGetDistance.Size = New System.Drawing.Size(93, 68)
        Me.btnGetDistance.TabIndex = 8
        Me.btnGetDistance.Text = "Get Distance"
        Me.btnGetDistance.UseVisualStyleBackColor = True
        '
        'dtpStatsTimeStart
        '
        Me.dtpStatsTimeStart.CustomFormat = ""
        Me.dtpStatsTimeStart.Location = New System.Drawing.Point(298, 242)
        Me.dtpStatsTimeStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStatsTimeStart.Name = "dtpStatsTimeStart"
        Me.dtpStatsTimeStart.Size = New System.Drawing.Size(212, 26)
        Me.dtpStatsTimeStart.TabIndex = 9
        '
        'btnProblems
        '
        Me.btnProblems.Location = New System.Drawing.Point(777, 82)
        Me.btnProblems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProblems.Name = "btnProblems"
        Me.btnProblems.Size = New System.Drawing.Size(93, 58)
        Me.btnProblems.TabIndex = 3
        Me.btnProblems.Text = "Problems"
        Me.btnProblems.UseVisualStyleBackColor = True
        '
        'btnAddLog
        '
        Me.btnAddLog.Location = New System.Drawing.Point(777, 12)
        Me.btnAddLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddLog.Name = "btnAddLog"
        Me.btnAddLog.Size = New System.Drawing.Size(93, 58)
        Me.btnAddLog.TabIndex = 2
        Me.btnAddLog.Text = "Add Log"
        Me.btnAddLog.UseVisualStyleBackColor = True
        '
        'dgvLogsList
        '
        Me.dgvLogsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogsList.Location = New System.Drawing.Point(298, 12)
        Me.dgvLogsList.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvLogsList.Name = "dgvLogsList"
        Me.dgvLogsList.ReadOnly = True
        Me.dgvLogsList.RowHeadersVisible = False
        Me.dgvLogsList.RowHeadersWidth = 51
        Me.dgvLogsList.RowTemplate.Height = 24
        Me.dgvLogsList.Size = New System.Drawing.Size(471, 200)
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
        Me.gbLogDetails.Location = New System.Drawing.Point(2, 2)
        Me.gbLogDetails.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbLogDetails.Name = "gbLogDetails"
        Me.gbLogDetails.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gbLogDetails.Size = New System.Drawing.Size(286, 268)
        Me.gbLogDetails.TabIndex = 0
        Me.gbLogDetails.TabStop = False
        Me.gbLogDetails.Text = "Details"
        '
        'lblCommentData
        '
        Me.lblCommentData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCommentData.AutoSize = True
        Me.lblCommentData.Location = New System.Drawing.Point(126, 131)
        Me.lblCommentData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCommentData.Name = "lblCommentData"
        Me.lblCommentData.Size = New System.Drawing.Size(36, 20)
        Me.lblCommentData.TabIndex = 7
        Me.lblCommentData.Text = "___"
        Me.lblCommentData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDistanceData
        '
        Me.lblDistanceData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDistanceData.AutoSize = True
        Me.lblDistanceData.Location = New System.Drawing.Point(126, 95)
        Me.lblDistanceData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDistanceData.Name = "lblDistanceData"
        Me.lblDistanceData.Size = New System.Drawing.Size(36, 20)
        Me.lblDistanceData.TabIndex = 6
        Me.lblDistanceData.Text = "___"
        Me.lblDistanceData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEndData
        '
        Me.lblEndData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEndData.AutoSize = True
        Me.lblEndData.Location = New System.Drawing.Point(126, 62)
        Me.lblEndData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndData.Name = "lblEndData"
        Me.lblEndData.Size = New System.Drawing.Size(36, 20)
        Me.lblEndData.TabIndex = 5
        Me.lblEndData.Text = "___"
        Me.lblEndData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStartData
        '
        Me.lblStartData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStartData.AutoSize = True
        Me.lblStartData.Location = New System.Drawing.Point(126, 26)
        Me.lblStartData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartData.Name = "lblStartData"
        Me.lblStartData.Size = New System.Drawing.Size(36, 20)
        Me.lblStartData.TabIndex = 4
        Me.lblStartData.Text = "___"
        Me.lblStartData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(6, 62)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(42, 20)
        Me.lblEndTime.TabIndex = 3
        Me.lblEndTime.Text = "End:"
        '
        'lblLogComment
        '
        Me.lblLogComment.AutoSize = True
        Me.lblLogComment.Location = New System.Drawing.Point(8, 131)
        Me.lblLogComment.Name = "lblLogComment"
        Me.lblLogComment.Size = New System.Drawing.Size(82, 20)
        Me.lblLogComment.TabIndex = 2
        Me.lblLogComment.Text = "Comment:"
        '
        'lblTotalDistance
        '
        Me.lblTotalDistance.AutoSize = True
        Me.lblTotalDistance.Location = New System.Drawing.Point(6, 95)
        Me.lblTotalDistance.Name = "lblTotalDistance"
        Me.lblTotalDistance.Size = New System.Drawing.Size(112, 20)
        Me.lblTotalDistance.TabIndex = 1
        Me.lblTotalDistance.Text = "Total distance:"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(6, 26)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(48, 20)
        Me.lblStartTime.TabIndex = 0
        Me.lblStartTime.Text = "Start:"
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.btnAddProblem)
        Me.pnlDetails.Controls.Add(Me.dgvProblemsList)
        Me.pnlDetails.Controls.Add(Me.btnLogs)
        Me.pnlDetails.Controls.Add(Me.gbCarDetails)
        Me.pnlDetails.Location = New System.Drawing.Point(4, 366)
        Me.pnlDetails.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(874, 282)
        Me.pnlDetails.TabIndex = 3
        Me.pnlDetails.Visible = False
        '
        'btnAddProblem
        '
        Me.btnAddProblem.Location = New System.Drawing.Point(777, 12)
        Me.btnAddProblem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProblem.Name = "btnAddProblem"
        Me.btnAddProblem.Size = New System.Drawing.Size(93, 58)
        Me.btnAddProblem.TabIndex = 7
        Me.btnAddProblem.Text = "Add Problem"
        Me.btnAddProblem.UseVisualStyleBackColor = True
        '
        'dgvProblemsList
        '
        Me.dgvProblemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProblemsList.Location = New System.Drawing.Point(303, 15)
        Me.dgvProblemsList.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvProblemsList.Name = "dgvProblemsList"
        Me.dgvProblemsList.ReadOnly = True
        Me.dgvProblemsList.RowHeadersVisible = False
        Me.dgvProblemsList.RowHeadersWidth = 51
        Me.dgvProblemsList.RowTemplate.Height = 24
        Me.dgvProblemsList.Size = New System.Drawing.Size(466, 255)
        Me.dgvProblemsList.TabIndex = 6
        '
        'btnLogs
        '
        Me.btnLogs.Location = New System.Drawing.Point(777, 82)
        Me.btnLogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(93, 58)
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
        Me.gbCarDetails.Location = New System.Drawing.Point(2, 2)
        Me.gbCarDetails.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbCarDetails.Name = "gbCarDetails"
        Me.gbCarDetails.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gbCarDetails.Size = New System.Drawing.Size(291, 268)
        Me.gbCarDetails.TabIndex = 4
        Me.gbCarDetails.TabStop = False
        Me.gbCarDetails.Text = "Details"
        '
        'lblInsuranceNameData
        '
        Me.lblInsuranceNameData.AutoSize = True
        Me.lblInsuranceNameData.Location = New System.Drawing.Point(195, 98)
        Me.lblInsuranceNameData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsuranceNameData.Name = "lblInsuranceNameData"
        Me.lblInsuranceNameData.Size = New System.Drawing.Size(36, 20)
        Me.lblInsuranceNameData.TabIndex = 9
        Me.lblInsuranceNameData.Text = "___"
        Me.lblInsuranceNameData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInsuranceName
        '
        Me.lblInsuranceName.AutoSize = True
        Me.lblInsuranceName.Location = New System.Drawing.Point(6, 98)
        Me.lblInsuranceName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsuranceName.Name = "lblInsuranceName"
        Me.lblInsuranceName.Size = New System.Drawing.Size(84, 20)
        Me.lblInsuranceName.TabIndex = 8
        Me.lblInsuranceName.Text = "Insurance:"
        '
        'btnDetailsUpdateInsurance
        '
        Me.btnDetailsUpdateInsurance.Location = New System.Drawing.Point(9, 178)
        Me.btnDetailsUpdateInsurance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDetailsUpdateInsurance.Name = "btnDetailsUpdateInsurance"
        Me.btnDetailsUpdateInsurance.Size = New System.Drawing.Size(273, 35)
        Me.btnDetailsUpdateInsurance.TabIndex = 7
        Me.btnDetailsUpdateInsurance.Text = "Update insurance"
        Me.btnDetailsUpdateInsurance.UseVisualStyleBackColor = True
        '
        'lblInsuranceData
        '
        Me.lblInsuranceData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInsuranceData.AutoSize = True
        Me.lblInsuranceData.Location = New System.Drawing.Point(195, 140)
        Me.lblInsuranceData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsuranceData.Name = "lblInsuranceData"
        Me.lblInsuranceData.Size = New System.Drawing.Size(36, 20)
        Me.lblInsuranceData.TabIndex = 6
        Me.lblInsuranceData.Text = "___"
        Me.lblInsuranceData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMilageData
        '
        Me.lblMilageData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMilageData.AutoSize = True
        Me.lblMilageData.Location = New System.Drawing.Point(195, 65)
        Me.lblMilageData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMilageData.Name = "lblMilageData"
        Me.lblMilageData.Size = New System.Drawing.Size(36, 20)
        Me.lblMilageData.TabIndex = 5
        Me.lblMilageData.Text = "___"
        Me.lblMilageData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFuelData
        '
        Me.lblFuelData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFuelData.AutoSize = True
        Me.lblFuelData.Location = New System.Drawing.Point(195, 31)
        Me.lblFuelData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuelData.Name = "lblFuelData"
        Me.lblFuelData.Size = New System.Drawing.Size(101, 20)
        Me.lblFuelData.TabIndex = 4
        Me.lblFuelData.Text = "___ L/100km"
        Me.lblFuelData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMilage
        '
        Me.lblMilage.AutoSize = True
        Me.lblMilage.Location = New System.Drawing.Point(6, 65)
        Me.lblMilage.Name = "lblMilage"
        Me.lblMilage.Size = New System.Drawing.Size(63, 20)
        Me.lblMilage.TabIndex = 1
        Me.lblMilage.Text = "Milage: "
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(8, 140)
        Me.lblInsurance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(128, 20)
        Me.lblInsurance.TabIndex = 3
        Me.lblInsurance.Text = "Insurance expiry:"
        '
        'lblFuel
        '
        Me.lblFuel.AutoSize = True
        Me.lblFuel.Location = New System.Drawing.Point(6, 31)
        Me.lblFuel.Name = "lblFuel"
        Me.lblFuel.Size = New System.Drawing.Size(197, 20)
        Me.lblFuel.TabIndex = 0
        Me.lblFuel.Text = "Average fuel consumption:"
        '
        'btnCarBack
        '
        Me.btnCarBack.Location = New System.Drawing.Point(8, 8)
        Me.btnCarBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCarBack.Name = "btnCarBack"
        Me.btnCarBack.Size = New System.Drawing.Size(84, 29)
        Me.btnCarBack.TabIndex = 2
        Me.btnCarBack.Text = "Back"
        Me.btnCarBack.UseVisualStyleBackColor = True
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(795, 8)
        Me.btnAddCar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(84, 29)
        Me.btnAddCar.TabIndex = 1
        Me.btnAddCar.Text = "Add car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'dgvCarsList
        '
        Me.dgvCarsList.ColumnHeadersHeight = 29
        Me.dgvCarsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCarsList.Location = New System.Drawing.Point(6, 42)
        Me.dgvCarsList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCarsList.Name = "dgvCarsList"
        Me.dgvCarsList.ReadOnly = True
        Me.dgvCarsList.RowHeadersVisible = False
        Me.dgvCarsList.RowHeadersWidth = 51
        Me.dgvCarsList.RowTemplate.Height = 24
        Me.dgvCarsList.Size = New System.Drawing.Size(874, 469)
        Me.dgvCarsList.TabIndex = 0
        '
        'tpGroups
        '
        Me.tpGroups.Controls.Add(Me.btnNewGroup)
        Me.tpGroups.Controls.Add(Me.gbGroups)
        Me.tpGroups.Controls.Add(Me.gbRideHistory)
        Me.tpGroups.Controls.Add(Me.btnLogOut)
        Me.tpGroups.Location = New System.Drawing.Point(4, 32)
        Me.tpGroups.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpGroups.Name = "tpGroups"
        Me.tpGroups.Size = New System.Drawing.Size(889, 522)
        Me.tpGroups.TabIndex = 6
        Me.tpGroups.Text = "Groups"
        Me.tpGroups.UseVisualStyleBackColor = True
        '
        'btnNewGroup
        '
        Me.btnNewGroup.Location = New System.Drawing.Point(326, 8)
        Me.btnNewGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNewGroup.Name = "btnNewGroup"
        Me.btnNewGroup.Size = New System.Drawing.Size(96, 29)
        Me.btnNewGroup.TabIndex = 5
        Me.btnNewGroup.Text = "New group"
        Me.btnNewGroup.UseVisualStyleBackColor = True
        '
        'gbGroups
        '
        Me.gbGroups.Controls.Add(Me.dgvGroupsList)
        Me.gbGroups.Location = New System.Drawing.Point(6, 42)
        Me.gbGroups.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbGroups.Name = "gbGroups"
        Me.gbGroups.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbGroups.Size = New System.Drawing.Size(422, 465)
        Me.gbGroups.TabIndex = 4
        Me.gbGroups.TabStop = False
        Me.gbGroups.Text = "Groups"
        '
        'dgvGroupsList
        '
        Me.dgvGroupsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGroupsList.Location = New System.Drawing.Point(6, 31)
        Me.dgvGroupsList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvGroupsList.Name = "dgvGroupsList"
        Me.dgvGroupsList.ReadOnly = True
        Me.dgvGroupsList.RowHeadersVisible = False
        Me.dgvGroupsList.RowHeadersWidth = 51
        Me.dgvGroupsList.RowTemplate.Height = 24
        Me.dgvGroupsList.Size = New System.Drawing.Size(408, 434)
        Me.dgvGroupsList.TabIndex = 0
        '
        'gbRideHistory
        '
        Me.gbRideHistory.Controls.Add(Me.cbSortRides)
        Me.gbRideHistory.Controls.Add(Me.dgvUserHistoryList)
        Me.gbRideHistory.Location = New System.Drawing.Point(435, 8)
        Me.gbRideHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbRideHistory.Name = "gbRideHistory"
        Me.gbRideHistory.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbRideHistory.Size = New System.Drawing.Size(448, 505)
        Me.gbRideHistory.TabIndex = 3
        Me.gbRideHistory.TabStop = False
        Me.gbRideHistory.Text = "Ride history"
        '
        'cbSortRides
        '
        Me.cbSortRides.FormattingEnabled = True
        Me.cbSortRides.Items.AddRange(New Object() {"A -> Z", "Z -> A", "Newest -> Oldest", "Oldest -> Newest", "Distance: Ascending", "Distance: Decending"})
        Me.cbSortRides.Location = New System.Drawing.Point(306, 31)
        Me.cbSortRides.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSortRides.Name = "cbSortRides"
        Me.cbSortRides.Size = New System.Drawing.Size(136, 28)
        Me.cbSortRides.TabIndex = 2
        Me.cbSortRides.Text = "Sort"
        '
        'dgvUserHistoryList
        '
        Me.dgvUserHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserHistoryList.Location = New System.Drawing.Point(8, 66)
        Me.dgvUserHistoryList.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvUserHistoryList.Name = "dgvUserHistoryList"
        Me.dgvUserHistoryList.ReadOnly = True
        Me.dgvUserHistoryList.RowHeadersVisible = False
        Me.dgvUserHistoryList.RowHeadersWidth = 51
        Me.dgvUserHistoryList.RowTemplate.Height = 24
        Me.dgvUserHistoryList.Size = New System.Drawing.Size(435, 434)
        Me.dgvUserHistoryList.TabIndex = 1
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(8, 8)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(84, 29)
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
        Me.tpLogin.Location = New System.Drawing.Point(4, 32)
        Me.tpLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Size = New System.Drawing.Size(889, 522)
        Me.tpLogin.TabIndex = 5
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Location = New System.Drawing.Point(324, 235)
        Me.txtLoginPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Size = New System.Drawing.Size(247, 26)
        Me.txtLoginPassword.TabIndex = 18
        Me.txtLoginPassword.UseSystemPasswordChar = True
        '
        'txtLoginEmail
        '
        Me.txtLoginEmail.Location = New System.Drawing.Point(324, 166)
        Me.txtLoginEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLoginEmail.Name = "txtLoginEmail"
        Me.txtLoginEmail.Size = New System.Drawing.Size(247, 26)
        Me.txtLoginEmail.TabIndex = 17
        '
        'lblLoginPassword
        '
        Me.lblLoginPassword.AutoSize = True
        Me.lblLoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginPassword.Location = New System.Drawing.Point(219, 235)
        Me.lblLoginPassword.Name = "lblLoginPassword"
        Me.lblLoginPassword.Size = New System.Drawing.Size(112, 25)
        Me.lblLoginPassword.TabIndex = 16
        Me.lblLoginPassword.Text = "Password:"
        '
        'lblLoginEmail
        '
        Me.lblLoginEmail.AutoSize = True
        Me.lblLoginEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginEmail.Location = New System.Drawing.Point(255, 166)
        Me.lblLoginEmail.Name = "lblLoginEmail"
        Me.lblLoginEmail.Size = New System.Drawing.Size(71, 25)
        Me.lblLoginEmail.TabIndex = 15
        Me.lblLoginEmail.Text = "Email:"
        '
        'btnLoginRegister
        '
        Me.btnLoginRegister.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLoginRegister.Location = New System.Drawing.Point(324, 411)
        Me.btnLoginRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginRegister.Name = "btnLoginRegister"
        Me.btnLoginRegister.Size = New System.Drawing.Size(248, 66)
        Me.btnLoginRegister.TabIndex = 14
        Me.btnLoginRegister.Text = "Register"
        Me.btnLoginRegister.UseVisualStyleBackColor = False
        '
        'btnLoginLogin
        '
        Me.btnLoginLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLoginLogin.Location = New System.Drawing.Point(324, 326)
        Me.btnLoginLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginLogin.Name = "btnLoginLogin"
        Me.btnLoginLogin.Size = New System.Drawing.Size(248, 66)
        Me.btnLoginLogin.TabIndex = 13
        Me.btnLoginLogin.Text = "Login"
        Me.btnLoginLogin.UseVisualStyleBackColor = False
        '
        'lblLoginTitle
        '
        Me.lblLoginTitle.AutoSize = True
        Me.lblLoginTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginTitle.Location = New System.Drawing.Point(316, 46)
        Me.lblLoginTitle.Name = "lblLoginTitle"
        Me.lblLoginTitle.Size = New System.Drawing.Size(273, 52)
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
        Me.tcTabs.Location = New System.Drawing.Point(3, 2)
        Me.tcTabs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(897, 558)
        Me.tcTabs.TabIndex = 0
        '
        'tpAddProblem
        '
        Me.tpAddProblem.Controls.Add(Me.btnAddProblemEnter)
        Me.tpAddProblem.Controls.Add(Me.btnAddProblemCancel)
        Me.tpAddProblem.Controls.Add(Me.cbCriticality)
        Me.tpAddProblem.Controls.Add(Me.txtProblemDescription)
        Me.tpAddProblem.Controls.Add(Me.lblIssueDescription)
        Me.tpAddProblem.Controls.Add(Me.lblProblemReportTitle)
        Me.tpAddProblem.Location = New System.Drawing.Point(4, 32)
        Me.tpAddProblem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpAddProblem.Name = "tpAddProblem"
        Me.tpAddProblem.Size = New System.Drawing.Size(889, 522)
        Me.tpAddProblem.TabIndex = 8
        Me.tpAddProblem.Text = "Add Problem"
        Me.tpAddProblem.UseVisualStyleBackColor = True
        '
        'btnAddProblemEnter
        '
        Me.btnAddProblemEnter.Location = New System.Drawing.Point(456, 363)
        Me.btnAddProblemEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProblemEnter.Name = "btnAddProblemEnter"
        Me.btnAddProblemEnter.Size = New System.Drawing.Size(122, 69)
        Me.btnAddProblemEnter.TabIndex = 6
        Me.btnAddProblemEnter.Text = "Enter"
        Me.btnAddProblemEnter.UseVisualStyleBackColor = True
        '
        'btnAddProblemCancel
        '
        Me.btnAddProblemCancel.Location = New System.Drawing.Point(302, 363)
        Me.btnAddProblemCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProblemCancel.Name = "btnAddProblemCancel"
        Me.btnAddProblemCancel.Size = New System.Drawing.Size(122, 68)
        Me.btnAddProblemCancel.TabIndex = 5
        Me.btnAddProblemCancel.Text = "Cancel"
        Me.btnAddProblemCancel.UseVisualStyleBackColor = True
        '
        'cbCriticality
        '
        Me.cbCriticality.AutoSize = True
        Me.cbCriticality.Location = New System.Drawing.Point(302, 312)
        Me.cbCriticality.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCriticality.Name = "cbCriticality"
        Me.cbCriticality.Size = New System.Drawing.Size(143, 24)
        Me.cbCriticality.TabIndex = 4
        Me.cbCriticality.Text = "Critical problem"
        Me.cbCriticality.UseVisualStyleBackColor = True
        '
        'txtProblemDescription
        '
        Me.txtProblemDescription.Location = New System.Drawing.Point(268, 171)
        Me.txtProblemDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProblemDescription.Multiline = True
        Me.txtProblemDescription.Name = "txtProblemDescription"
        Me.txtProblemDescription.Size = New System.Drawing.Size(336, 121)
        Me.txtProblemDescription.TabIndex = 3
        '
        'lblIssueDescription
        '
        Me.lblIssueDescription.AutoSize = True
        Me.lblIssueDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblIssueDescription.Location = New System.Drawing.Point(336, 126)
        Me.lblIssueDescription.Name = "lblIssueDescription"
        Me.lblIssueDescription.Size = New System.Drawing.Size(191, 26)
        Me.lblIssueDescription.TabIndex = 1
        Me.lblIssueDescription.Text = "Describe the issue"
        '
        'lblProblemReportTitle
        '
        Me.lblProblemReportTitle.AutoSize = True
        Me.lblProblemReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblProblemReportTitle.Location = New System.Drawing.Point(314, 55)
        Me.lblProblemReportTitle.Name = "lblProblemReportTitle"
        Me.lblProblemReportTitle.Size = New System.Drawing.Size(232, 32)
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
        Me.tpAddLog.Location = New System.Drawing.Point(4, 32)
        Me.tpAddLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpAddLog.Name = "tpAddLog"
        Me.tpAddLog.Size = New System.Drawing.Size(889, 522)
        Me.tpAddLog.TabIndex = 9
        Me.tpAddLog.Text = "Add Log"
        Me.tpAddLog.UseVisualStyleBackColor = True
        '
        'btnAddLogEnter
        '
        Me.btnAddLogEnter.Location = New System.Drawing.Point(678, 426)
        Me.btnAddLogEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddLogEnter.Name = "btnAddLogEnter"
        Me.btnAddLogEnter.Size = New System.Drawing.Size(148, 58)
        Me.btnAddLogEnter.TabIndex = 18
        Me.btnAddLogEnter.Text = "Enter"
        Me.btnAddLogEnter.UseVisualStyleBackColor = True
        '
        'btnAddLogCancel
        '
        Me.btnAddLogCancel.Location = New System.Drawing.Point(442, 426)
        Me.btnAddLogCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddLogCancel.Name = "btnAddLogCancel"
        Me.btnAddLogCancel.Size = New System.Drawing.Size(148, 55)
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
        Me.gbEnd.Location = New System.Drawing.Point(430, 54)
        Me.gbEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbEnd.Name = "gbEnd"
        Me.gbEnd.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbEnd.Size = New System.Drawing.Size(394, 249)
        Me.gbEnd.TabIndex = 16
        Me.gbEnd.TabStop = False
        Me.gbEnd.Text = "End"
        '
        'lblEndAdd
        '
        Me.lblEndAdd.AutoSize = True
        Me.lblEndAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblEndAdd.Location = New System.Drawing.Point(6, 48)
        Me.lblEndAdd.Name = "lblEndAdd"
        Me.lblEndAdd.Size = New System.Drawing.Size(94, 26)
        Me.lblEndAdd.TabIndex = 2
        Me.lblEndAdd.Text = "Location"
        '
        'txtLocationEnd
        '
        Me.txtLocationEnd.Location = New System.Drawing.Point(105, 48)
        Me.txtLocationEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLocationEnd.Name = "txtLocationEnd"
        Me.txtLocationEnd.Size = New System.Drawing.Size(283, 32)
        Me.txtLocationEnd.TabIndex = 8
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(12, 162)
        Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(376, 32)
        Me.dtpEndDate.TabIndex = 14
        '
        'lblEndDateAdd
        '
        Me.lblEndDateAdd.AutoSize = True
        Me.lblEndDateAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblEndDateAdd.Location = New System.Drawing.Point(6, 112)
        Me.lblEndDateAdd.Name = "lblEndDateAdd"
        Me.lblEndDateAdd.Size = New System.Drawing.Size(148, 26)
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
        Me.gbStart.Location = New System.Drawing.Point(6, 54)
        Me.gbStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbStart.Name = "gbStart"
        Me.gbStart.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbStart.Size = New System.Drawing.Size(398, 238)
        Me.gbStart.TabIndex = 15
        Me.gbStart.TabStop = False
        Me.gbStart.Text = "Start"
        '
        'lblStartDateAdd
        '
        Me.lblStartDateAdd.AutoSize = True
        Me.lblStartDateAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblStartDateAdd.Location = New System.Drawing.Point(6, 112)
        Me.lblStartDateAdd.Name = "lblStartDateAdd"
        Me.lblStartDateAdd.Size = New System.Drawing.Size(148, 26)
        Me.lblStartDateAdd.TabIndex = 4
        Me.lblStartDateAdd.Text = "Date and time"
        '
        'lblAddStart
        '
        Me.lblAddStart.AutoSize = True
        Me.lblAddStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblAddStart.Location = New System.Drawing.Point(6, 48)
        Me.lblAddStart.Name = "lblAddStart"
        Me.lblAddStart.Size = New System.Drawing.Size(94, 26)
        Me.lblAddStart.TabIndex = 1
        Me.lblAddStart.Text = "Location"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(6, 162)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(384, 32)
        Me.dtpStartDate.TabIndex = 13
        Me.dtpStartDate.Value = New Date(2025, 4, 24, 0, 0, 0, 0)
        '
        'txtLocationStart
        '
        Me.txtLocationStart.Location = New System.Drawing.Point(105, 42)
        Me.txtLocationStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLocationStart.Name = "txtLocationStart"
        Me.txtLocationStart.Size = New System.Drawing.Size(286, 32)
        Me.txtLocationStart.TabIndex = 7
        '
        'txtLogComment
        '
        Me.txtLogComment.Location = New System.Drawing.Point(162, 400)
        Me.txtLogComment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLogComment.Multiline = True
        Me.txtLogComment.Name = "txtLogComment"
        Me.txtLogComment.Size = New System.Drawing.Size(241, 82)
        Me.txtLogComment.TabIndex = 12
        '
        'txtTotalDistance
        '
        Me.txtTotalDistance.Location = New System.Drawing.Point(162, 320)
        Me.txtTotalDistance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalDistance.Name = "txtTotalDistance"
        Me.txtTotalDistance.Size = New System.Drawing.Size(235, 26)
        Me.txtTotalDistance.TabIndex = 11
        '
        'lblLogCommentAdd
        '
        Me.lblLogCommentAdd.AutoSize = True
        Me.lblLogCommentAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblLogCommentAdd.Location = New System.Drawing.Point(14, 426)
        Me.lblLogCommentAdd.Name = "lblLogCommentAdd"
        Me.lblLogCommentAdd.Size = New System.Drawing.Size(119, 26)
        Me.lblLogCommentAdd.TabIndex = 6
        Me.lblLogCommentAdd.Text = "Comments"
        '
        'lblDistanceAdd
        '
        Me.lblDistanceAdd.AutoSize = True
        Me.lblDistanceAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblDistanceAdd.Location = New System.Drawing.Point(14, 318)
        Me.lblDistanceAdd.Name = "lblDistanceAdd"
        Me.lblDistanceAdd.Size = New System.Drawing.Size(146, 26)
        Me.lblDistanceAdd.TabIndex = 3
        Me.lblDistanceAdd.Text = "Total distance"
        '
        'lblAddLogTitle
        '
        Me.lblAddLogTitle.AutoSize = True
        Me.lblAddLogTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblAddLogTitle.Location = New System.Drawing.Point(298, 14)
        Me.lblAddLogTitle.Name = "lblAddLogTitle"
        Me.lblAddLogTitle.Size = New System.Drawing.Size(198, 32)
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
        Me.tpNewGroup.Location = New System.Drawing.Point(4, 32)
        Me.tpNewGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpNewGroup.Name = "tpNewGroup"
        Me.tpNewGroup.Size = New System.Drawing.Size(889, 522)
        Me.tpNewGroup.TabIndex = 10
        Me.tpNewGroup.Text = "New Group"
        Me.tpNewGroup.UseVisualStyleBackColor = True
        '
        'lblGroupName
        '
        Me.lblGroupName.AutoSize = True
        Me.lblGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblGroupName.Location = New System.Drawing.Point(201, 214)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(133, 26)
        Me.lblGroupName.TabIndex = 4
        Me.lblGroupName.Text = "Group name"
        '
        'btnCancelNewGroup
        '
        Me.btnCancelNewGroup.Location = New System.Drawing.Point(204, 398)
        Me.btnCancelNewGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelNewGroup.Name = "btnCancelNewGroup"
        Me.btnCancelNewGroup.Size = New System.Drawing.Size(129, 62)
        Me.btnCancelNewGroup.TabIndex = 3
        Me.btnCancelNewGroup.Text = "Cancel"
        Me.btnCancelNewGroup.UseVisualStyleBackColor = True
        '
        'btnEnterNewGroup
        '
        Me.btnEnterNewGroup.Location = New System.Drawing.Point(507, 398)
        Me.btnEnterNewGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnterNewGroup.Name = "btnEnterNewGroup"
        Me.btnEnterNewGroup.Size = New System.Drawing.Size(129, 62)
        Me.btnEnterNewGroup.TabIndex = 2
        Me.btnEnterNewGroup.Text = "Enter"
        Me.btnEnterNewGroup.UseVisualStyleBackColor = True
        '
        'txtNewGroupName
        '
        Me.txtNewGroupName.Location = New System.Drawing.Point(392, 215)
        Me.txtNewGroupName.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtNewGroupName.Name = "txtNewGroupName"
        Me.txtNewGroupName.Size = New System.Drawing.Size(388, 26)
        Me.txtNewGroupName.TabIndex = 1
        '
        'lblCreateGroup
        '
        Me.lblCreateGroup.AutoSize = True
        Me.lblCreateGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblCreateGroup.Location = New System.Drawing.Point(308, 18)
        Me.lblCreateGroup.Name = "lblCreateGroup"
        Me.lblCreateGroup.Size = New System.Drawing.Size(238, 32)
        Me.lblCreateGroup.TabIndex = 0
        Me.lblCreateGroup.Text = "Create new group"
        '
        'tpRegister
        '
        Me.tpRegister.Controls.Add(Me.cbRegisterShowPassword)
        Me.tpRegister.Controls.Add(Me.lblCreateAccountTitle)
        Me.tpRegister.Controls.Add(Me.lblConfirmPassword)
        Me.tpRegister.Controls.Add(Me.lblRegisterPassword)
        Me.tpRegister.Controls.Add(Me.lblRegisterEmail)
        Me.tpRegister.Controls.Add(Me.tbRegisterPasswordConfirm)
        Me.tpRegister.Controls.Add(Me.tbRegisterPassword)
        Me.tpRegister.Controls.Add(Me.tbRegisterEmail)
        Me.tpRegister.Controls.Add(Me.btnRegisterEnter)
        Me.tpRegister.Controls.Add(Me.btnRegisterCancel)
        Me.tpRegister.Location = New System.Drawing.Point(4, 32)
        Me.tpRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpRegister.Name = "tpRegister"
        Me.tpRegister.Size = New System.Drawing.Size(889, 522)
        Me.tpRegister.TabIndex = 11
        Me.tpRegister.Text = "Register"
        Me.tpRegister.UseVisualStyleBackColor = True
        '
        'cbRegisterShowPassword
        '
        Me.cbRegisterShowPassword.AutoSize = True
        Me.cbRegisterShowPassword.Location = New System.Drawing.Point(694, 311)
        Me.cbRegisterShowPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbRegisterShowPassword.Name = "cbRegisterShowPassword"
        Me.cbRegisterShowPassword.Size = New System.Drawing.Size(147, 24)
        Me.cbRegisterShowPassword.TabIndex = 9
        Me.cbRegisterShowPassword.Text = "Show password"
        Me.cbRegisterShowPassword.UseVisualStyleBackColor = True
        '
        'lblCreateAccountTitle
        '
        Me.lblCreateAccountTitle.AutoSize = True
        Me.lblCreateAccountTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblCreateAccountTitle.Location = New System.Drawing.Point(303, 62)
        Me.lblCreateAccountTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCreateAccountTitle.Name = "lblCreateAccountTitle"
        Me.lblCreateAccountTitle.Size = New System.Drawing.Size(288, 32)
        Me.lblCreateAccountTitle.TabIndex = 8
        Me.lblCreateAccountTitle.Text = "Create a new account"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblConfirmPassword.Location = New System.Drawing.Point(222, 305)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(194, 26)
        Me.lblConfirmPassword.TabIndex = 7
        Me.lblConfirmPassword.Text = "Confirm password:"
        '
        'lblRegisterPassword
        '
        Me.lblRegisterPassword.AutoSize = True
        Me.lblRegisterPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblRegisterPassword.Location = New System.Drawing.Point(222, 235)
        Me.lblRegisterPassword.Name = "lblRegisterPassword"
        Me.lblRegisterPassword.Size = New System.Drawing.Size(114, 26)
        Me.lblRegisterPassword.TabIndex = 6
        Me.lblRegisterPassword.Text = "Password:"
        '
        'lblRegisterEmail
        '
        Me.lblRegisterEmail.AutoSize = True
        Me.lblRegisterEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblRegisterEmail.Location = New System.Drawing.Point(222, 155)
        Me.lblRegisterEmail.Name = "lblRegisterEmail"
        Me.lblRegisterEmail.Size = New System.Drawing.Size(74, 26)
        Me.lblRegisterEmail.TabIndex = 5
        Me.lblRegisterEmail.Text = "Email:"
        '
        'tbRegisterPasswordConfirm
        '
        Me.tbRegisterPasswordConfirm.Location = New System.Drawing.Point(450, 308)
        Me.tbRegisterPasswordConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbRegisterPasswordConfirm.Name = "tbRegisterPasswordConfirm"
        Me.tbRegisterPasswordConfirm.Size = New System.Drawing.Size(212, 26)
        Me.tbRegisterPasswordConfirm.TabIndex = 4
        Me.tbRegisterPasswordConfirm.UseSystemPasswordChar = True
        '
        'tbRegisterPassword
        '
        Me.tbRegisterPassword.Location = New System.Drawing.Point(450, 238)
        Me.tbRegisterPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbRegisterPassword.Name = "tbRegisterPassword"
        Me.tbRegisterPassword.Size = New System.Drawing.Size(212, 26)
        Me.tbRegisterPassword.TabIndex = 3
        Me.tbRegisterPassword.UseSystemPasswordChar = True
        '
        'tbRegisterEmail
        '
        Me.tbRegisterEmail.Location = New System.Drawing.Point(450, 158)
        Me.tbRegisterEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbRegisterEmail.Name = "tbRegisterEmail"
        Me.tbRegisterEmail.Size = New System.Drawing.Size(212, 26)
        Me.tbRegisterEmail.TabIndex = 2
        '
        'btnRegisterEnter
        '
        Me.btnRegisterEnter.Location = New System.Drawing.Point(508, 408)
        Me.btnRegisterEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegisterEnter.Name = "btnRegisterEnter"
        Me.btnRegisterEnter.Size = New System.Drawing.Size(112, 63)
        Me.btnRegisterEnter.TabIndex = 1
        Me.btnRegisterEnter.Text = "Enter"
        Me.btnRegisterEnter.UseVisualStyleBackColor = True
        '
        'btnRegisterCancel
        '
        Me.btnRegisterCancel.Location = New System.Drawing.Point(267, 408)
        Me.btnRegisterCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegisterCancel.Name = "btnRegisterCancel"
        Me.btnRegisterCancel.Size = New System.Drawing.Size(112, 63)
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
        Me.tpUpdateInsurance.Location = New System.Drawing.Point(4, 32)
        Me.tpUpdateInsurance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpUpdateInsurance.Name = "tpUpdateInsurance"
        Me.tpUpdateInsurance.Size = New System.Drawing.Size(889, 522)
        Me.tpUpdateInsurance.TabIndex = 12
        Me.tpUpdateInsurance.Text = "Update insurance"
        Me.tpUpdateInsurance.UseVisualStyleBackColor = True
        '
        'lblUpdateInsuranceTitle
        '
        Me.lblUpdateInsuranceTitle.AutoSize = True
        Me.lblUpdateInsuranceTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblUpdateInsuranceTitle.Location = New System.Drawing.Point(309, 31)
        Me.lblUpdateInsuranceTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdateInsuranceTitle.Name = "lblUpdateInsuranceTitle"
        Me.lblUpdateInsuranceTitle.Size = New System.Drawing.Size(237, 32)
        Me.lblUpdateInsuranceTitle.TabIndex = 6
        Me.lblUpdateInsuranceTitle.Text = "Update insurance"
        '
        'btnUpdateInsuranceEnter
        '
        Me.btnUpdateInsuranceEnter.Location = New System.Drawing.Point(638, 392)
        Me.btnUpdateInsuranceEnter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateInsuranceEnter.Name = "btnUpdateInsuranceEnter"
        Me.btnUpdateInsuranceEnter.Size = New System.Drawing.Size(112, 86)
        Me.btnUpdateInsuranceEnter.TabIndex = 5
        Me.btnUpdateInsuranceEnter.Text = "Enter"
        Me.btnUpdateInsuranceEnter.UseVisualStyleBackColor = True
        '
        'btnUpdateInsuranceCancel
        '
        Me.btnUpdateInsuranceCancel.Location = New System.Drawing.Point(128, 392)
        Me.btnUpdateInsuranceCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateInsuranceCancel.Name = "btnUpdateInsuranceCancel"
        Me.btnUpdateInsuranceCancel.Size = New System.Drawing.Size(112, 86)
        Me.btnUpdateInsuranceCancel.TabIndex = 4
        Me.btnUpdateInsuranceCancel.Text = "Cancel"
        Me.btnUpdateInsuranceCancel.UseVisualStyleBackColor = True
        '
        'dtpInsuranceExpiration
        '
        Me.dtpInsuranceExpiration.Location = New System.Drawing.Point(388, 265)
        Me.dtpInsuranceExpiration.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpInsuranceExpiration.Name = "dtpInsuranceExpiration"
        Me.dtpInsuranceExpiration.Size = New System.Drawing.Size(358, 26)
        Me.dtpInsuranceExpiration.TabIndex = 3
        '
        'txtUpdateInsuranceName
        '
        Me.txtUpdateInsuranceName.Location = New System.Drawing.Point(388, 169)
        Me.txtUpdateInsuranceName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUpdateInsuranceName.Name = "txtUpdateInsuranceName"
        Me.txtUpdateInsuranceName.Size = New System.Drawing.Size(358, 26)
        Me.txtUpdateInsuranceName.TabIndex = 2
        '
        'lblUpdateExpiration
        '
        Me.lblUpdateExpiration.AutoSize = True
        Me.lblUpdateExpiration.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblUpdateExpiration.Location = New System.Drawing.Point(123, 262)
        Me.lblUpdateExpiration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdateExpiration.Name = "lblUpdateExpiration"
        Me.lblUpdateExpiration.Size = New System.Drawing.Size(163, 26)
        Me.lblUpdateExpiration.TabIndex = 1
        Me.lblUpdateExpiration.Text = "Expiration date:"
        '
        'lblUpdateName
        '
        Me.lblUpdateName.AutoSize = True
        Me.lblUpdateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblUpdateName.Location = New System.Drawing.Point(123, 166)
        Me.lblUpdateName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdateName.Name = "lblUpdateName"
        Me.lblUpdateName.Size = New System.Drawing.Size(197, 26)
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
        Me.tpAddMember.Location = New System.Drawing.Point(4, 32)
        Me.tpAddMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpAddMember.Name = "tpAddMember"
        Me.tpAddMember.Size = New System.Drawing.Size(889, 522)
        Me.tpAddMember.TabIndex = 13
        Me.tpAddMember.Text = "Add member"
        Me.tpAddMember.UseVisualStyleBackColor = True
        '
        'txtMemberEmail
        '
        Me.txtMemberEmail.Location = New System.Drawing.Point(340, 215)
        Me.txtMemberEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMemberEmail.Name = "txtMemberEmail"
        Me.txtMemberEmail.Size = New System.Drawing.Size(238, 26)
        Me.txtMemberEmail.TabIndex = 5
        '
        'lblAddMemberTitle
        '
        Me.lblAddMemberTitle.AutoSize = True
        Me.lblAddMemberTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblAddMemberTitle.Location = New System.Drawing.Point(284, 94)
        Me.lblAddMemberTitle.Name = "lblAddMemberTitle"
        Me.lblAddMemberTitle.Size = New System.Drawing.Size(286, 32)
        Me.lblAddMemberTitle.TabIndex = 4
        Me.lblAddMemberTitle.Text = "Add member to group"
        '
        'lblMemberEmail
        '
        Me.lblMemberEmail.AutoSize = True
        Me.lblMemberEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblMemberEmail.Location = New System.Drawing.Point(246, 212)
        Me.lblMemberEmail.Name = "lblMemberEmail"
        Me.lblMemberEmail.Size = New System.Drawing.Size(74, 26)
        Me.lblMemberEmail.TabIndex = 3
        Me.lblMemberEmail.Text = "Email:"
        '
        'btnAddMemberEnter
        '
        Me.btnAddMemberEnter.Location = New System.Drawing.Point(495, 365)
        Me.btnAddMemberEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddMemberEnter.Name = "btnAddMemberEnter"
        Me.btnAddMemberEnter.Size = New System.Drawing.Size(84, 75)
        Me.btnAddMemberEnter.TabIndex = 2
        Me.btnAddMemberEnter.Text = "Enter"
        Me.btnAddMemberEnter.UseVisualStyleBackColor = True
        '
        'btnAddMemberCancel
        '
        Me.btnAddMemberCancel.Location = New System.Drawing.Point(249, 365)
        Me.btnAddMemberCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddMemberCancel.Name = "btnAddMemberCancel"
        Me.btnAddMemberCancel.Size = New System.Drawing.Size(84, 75)
        Me.btnAddMemberCancel.TabIndex = 1
        Me.btnAddMemberCancel.Text = "Cancel"
        Me.btnAddMemberCancel.UseVisualStyleBackColor = True
        '
        'cbIsAdmin
        '
        Me.cbIsAdmin.AutoSize = True
        Me.cbIsAdmin.Location = New System.Drawing.Point(340, 260)
        Me.cbIsAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbIsAdmin.Name = "cbIsAdmin"
        Me.cbIsAdmin.Size = New System.Drawing.Size(131, 24)
        Me.cbIsAdmin.TabIndex = 0
        Me.cbIsAdmin.Text = "User is admin"
        Me.cbIsAdmin.UseVisualStyleBackColor = True
        '
        'formTableViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.tcTabs)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents cbCarsSort As ComboBox
    Friend WithEvents cbRegisterShowPassword As CheckBox
End Class
