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
        Me.tpCarsList = New System.Windows.Forms.TabPage()
        Me.cbCarsSort = New System.Windows.Forms.ComboBox()
        Me.pnlLogs = New System.Windows.Forms.Panel()
        Me.btnProblems = New System.Windows.Forms.Button()
        Me.btnAddLog = New System.Windows.Forms.Button()
        Me.dgvLogsList = New System.Windows.Forms.DataGridView()
        Me.trip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isCritical = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.isResolved = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnLogs = New System.Windows.Forms.Button()
        Me.gbCarDetails = New System.Windows.Forms.GroupBox()
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
        Me.userHistoryRide = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userRidePeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userRideDistance = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCreateGroup = New System.Windows.Forms.Label()
        Me.tpRegister = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblRegisterPassword = New System.Windows.Forms.Label()
        Me.lblRegisterEmail = New System.Windows.Forms.Label()
        Me.tbPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.tbRegisterPassword = New System.Windows.Forms.TextBox()
        Me.tbRegisterEmail = New System.Windows.Forms.TextBox()
        Me.btnRegisterEnter = New System.Windows.Forms.Button()
        Me.btnRegisterCancel = New System.Windows.Forms.Button()
        Me.registrationPlate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carModel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maintenence = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.isAvailable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeleteButton = New System.Windows.Forms.DataGridViewButtonColumn()
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
        Me.tpAddCar.Location = New System.Drawing.Point(4, 32)
        Me.tpAddCar.Name = "tpAddCar"
        Me.tpAddCar.Size = New System.Drawing.Size(889, 521)
        Me.tpAddCar.TabIndex = 7
        Me.tpAddCar.Text = "Add Car"
        Me.tpAddCar.UseVisualStyleBackColor = True
        '
        'btnAddCarEnter
        '
        Me.btnAddCarEnter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddCarEnter.Location = New System.Drawing.Point(488, 434)
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
        Me.btnAddCarCancel.Name = "btnAddCarCancel"
        Me.btnAddCarCancel.Size = New System.Drawing.Size(366, 66)
        Me.btnAddCarCancel.TabIndex = 11
        Me.btnAddCarCancel.Text = "Cancel"
        Me.btnAddCarCancel.UseVisualStyleBackColor = False
        '
        'cboxArchive
        '
        Me.cboxArchive.AutoSize = True
        Me.cboxArchive.Location = New System.Drawing.Point(489, 369)
        Me.cboxArchive.Name = "cboxArchive"
        Me.cboxArchive.Size = New System.Drawing.Size(113, 24)
        Me.cboxArchive.TabIndex = 10
        Me.cboxArchive.Text = "Archive car"
        Me.cboxArchive.UseVisualStyleBackColor = True
        '
        'cboxReady
        '
        Me.cboxReady.AutoSize = True
        Me.cboxReady.Location = New System.Drawing.Point(356, 298)
        Me.cboxReady.Name = "cboxReady"
        Me.cboxReady.Size = New System.Drawing.Size(118, 24)
        Me.cboxReady.TabIndex = 9
        Me.cboxReady.Text = "Car is ready"
        Me.cboxReady.UseVisualStyleBackColor = True
        '
        'txtMileage
        '
        Me.txtMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMileage.Location = New System.Drawing.Point(237, 155)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(617, 26)
        Me.txtMileage.TabIndex = 8
        '
        'txtAvgFuel
        '
        Me.txtAvgFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvgFuel.Location = New System.Drawing.Point(408, 225)
        Me.txtAvgFuel.Name = "txtAvgFuel"
        Me.txtAvgFuel.Size = New System.Drawing.Size(446, 26)
        Me.txtAvgFuel.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(166, 88)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(686, 26)
        Me.txtName.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(52, 85)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(108, 26)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Car name"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(52, 155)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(178, 26)
        Me.lblMileage.TabIndex = 4
        Me.lblMileage.Text = "Car mileage [km]"
        '
        'lblAvgFuel
        '
        Me.lblAvgFuel.AutoSize = True
        Me.lblAvgFuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgFuel.Location = New System.Drawing.Point(52, 225)
        Me.lblAvgFuel.Name = "lblAvgFuel"
        Me.lblAvgFuel.Size = New System.Drawing.Size(349, 26)
        Me.lblAvgFuel.TabIndex = 3
        Me.lblAvgFuel.Text = "Car average fuel consumtion [l/km]"
        '
        'lblReady
        '
        Me.lblReady.AutoSize = True
        Me.lblReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReady.Location = New System.Drawing.Point(52, 295)
        Me.lblReady.Name = "lblReady"
        Me.lblReady.Size = New System.Drawing.Size(296, 26)
        Me.lblReady.TabIndex = 2
        Me.lblReady.Text = "Is the car ready to drive now?"
        '
        'lblArchive
        '
        Me.lblArchive.AutoSize = True
        Me.lblArchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchive.Location = New System.Drawing.Point(52, 365)
        Me.lblArchive.Name = "lblArchive"
        Me.lblArchive.Size = New System.Drawing.Size(429, 26)
        Me.lblArchive.TabIndex = 1
        Me.lblArchive.Text = "Should the car be added to the archive list?"
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
        Me.tpCarsList.Controls.Add(Me.pnlLogs)
        Me.tpCarsList.Controls.Add(Me.pnlDetails)
        Me.tpCarsList.Controls.Add(Me.btnCarBack)
        Me.tpCarsList.Controls.Add(Me.btnAddCar)
        Me.tpCarsList.Controls.Add(Me.dgvCarsList)
        Me.tpCarsList.Location = New System.Drawing.Point(4, 32)
        Me.tpCarsList.Name = "tpCarsList"
        Me.tpCarsList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCarsList.Size = New System.Drawing.Size(889, 521)
        Me.tpCarsList.TabIndex = 0
        Me.tpCarsList.Text = "Cars"
        Me.tpCarsList.UseVisualStyleBackColor = True
        '
        'cbCarsSort
        '
        Me.cbCarsSort.FormattingEnabled = True
        Me.cbCarsSort.Items.AddRange(New Object() {"A -> Z", "Z -> A", "Distance: Ascending", "Distance: Descending", "Available", "Unavailable", "Archived", "Unarchived"})
        Me.cbCarsSort.Location = New System.Drawing.Point(575, 9)
        Me.cbCarsSort.Name = "cbCarsSort"
        Me.cbCarsSort.Size = New System.Drawing.Size(204, 28)
        Me.cbCarsSort.TabIndex = 5
        Me.cbCarsSort.Text = "Sort"
        '
        'pnlLogs
        '
        Me.pnlLogs.Controls.Add(Me.btnProblems)
        Me.pnlLogs.Controls.Add(Me.btnAddLog)
        Me.pnlLogs.Controls.Add(Me.dgvLogsList)
        Me.pnlLogs.Controls.Add(Me.gbLogDetails)
        Me.pnlLogs.Location = New System.Drawing.Point(8, 363)
        Me.pnlLogs.Name = "pnlLogs"
        Me.pnlLogs.Size = New System.Drawing.Size(874, 146)
        Me.pnlLogs.TabIndex = 4
        Me.pnlLogs.Visible = False
        '
        'btnProblems
        '
        Me.btnProblems.Location = New System.Drawing.Point(777, 82)
        Me.btnProblems.Name = "btnProblems"
        Me.btnProblems.Size = New System.Drawing.Size(93, 57)
        Me.btnProblems.TabIndex = 3
        Me.btnProblems.Text = "Problems"
        Me.btnProblems.UseVisualStyleBackColor = True
        '
        'btnAddLog
        '
        Me.btnAddLog.Location = New System.Drawing.Point(777, 12)
        Me.btnAddLog.Name = "btnAddLog"
        Me.btnAddLog.Size = New System.Drawing.Size(93, 57)
        Me.btnAddLog.TabIndex = 2
        Me.btnAddLog.Text = "Add Log"
        Me.btnAddLog.UseVisualStyleBackColor = True
        '
        'dgvLogsList
        '
        Me.dgvLogsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trip, Me.time})
        Me.dgvLogsList.Location = New System.Drawing.Point(327, 12)
        Me.dgvLogsList.Name = "dgvLogsList"
        Me.dgvLogsList.ReadOnly = True
        Me.dgvLogsList.RowHeadersVisible = False
        Me.dgvLogsList.RowHeadersWidth = 51
        Me.dgvLogsList.RowTemplate.Height = 24
        Me.dgvLogsList.Size = New System.Drawing.Size(444, 125)
        Me.dgvLogsList.TabIndex = 1
        '
        'trip
        '
        Me.trip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.trip.HeaderText = "Trip"
        Me.trip.MinimumWidth = 6
        Me.trip.Name = "trip"
        Me.trip.ReadOnly = True
        '
        'time
        '
        Me.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.time.HeaderText = "Time of trip"
        Me.time.MinimumWidth = 6
        Me.time.Name = "time"
        Me.time.ReadOnly = True
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
        Me.gbLogDetails.Location = New System.Drawing.Point(3, 3)
        Me.gbLogDetails.Name = "gbLogDetails"
        Me.gbLogDetails.Size = New System.Drawing.Size(316, 134)
        Me.gbLogDetails.TabIndex = 0
        Me.gbLogDetails.TabStop = False
        Me.gbLogDetails.Text = "Details"
        '
        'lblCommentData
        '
        Me.lblCommentData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCommentData.AutoSize = True
        Me.lblCommentData.Location = New System.Drawing.Point(264, 111)
        Me.lblCommentData.Name = "lblCommentData"
        Me.lblCommentData.Size = New System.Drawing.Size(36, 20)
        Me.lblCommentData.TabIndex = 7
        Me.lblCommentData.Text = "___"
        '
        'lblDistanceData
        '
        Me.lblDistanceData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDistanceData.AutoSize = True
        Me.lblDistanceData.Location = New System.Drawing.Point(240, 83)
        Me.lblDistanceData.Name = "lblDistanceData"
        Me.lblDistanceData.Size = New System.Drawing.Size(61, 20)
        Me.lblDistanceData.TabIndex = 6
        Me.lblDistanceData.Text = "___ km"
        '
        'lblEndData
        '
        Me.lblEndData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEndData.AutoSize = True
        Me.lblEndData.Location = New System.Drawing.Point(172, 55)
        Me.lblEndData.Name = "lblEndData"
        Me.lblEndData.Size = New System.Drawing.Size(142, 20)
        Me.lblEndData.TabIndex = 5
        Me.lblEndData.Text = "12:00 - 01.01.1970"
        '
        'lblStartData
        '
        Me.lblStartData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStartData.AutoSize = True
        Me.lblStartData.Location = New System.Drawing.Point(172, 26)
        Me.lblStartData.Name = "lblStartData"
        Me.lblStartData.Size = New System.Drawing.Size(142, 20)
        Me.lblStartData.TabIndex = 4
        Me.lblStartData.Text = "12:00 - 01.01.1970"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(6, 55)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(42, 20)
        Me.lblEndTime.TabIndex = 3
        Me.lblEndTime.Text = "End:"
        '
        'lblLogComment
        '
        Me.lblLogComment.AutoSize = True
        Me.lblLogComment.Location = New System.Drawing.Point(6, 111)
        Me.lblLogComment.Name = "lblLogComment"
        Me.lblLogComment.Size = New System.Drawing.Size(82, 20)
        Me.lblLogComment.TabIndex = 2
        Me.lblLogComment.Text = "Comment:"
        '
        'lblTotalDistance
        '
        Me.lblTotalDistance.AutoSize = True
        Me.lblTotalDistance.Location = New System.Drawing.Point(6, 83)
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
        Me.pnlDetails.Location = New System.Drawing.Point(8, 208)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(874, 146)
        Me.pnlDetails.TabIndex = 3
        Me.pnlDetails.Visible = False
        '
        'btnAddProblem
        '
        Me.btnAddProblem.Location = New System.Drawing.Point(777, 12)
        Me.btnAddProblem.Name = "btnAddProblem"
        Me.btnAddProblem.Size = New System.Drawing.Size(93, 57)
        Me.btnAddProblem.TabIndex = 7
        Me.btnAddProblem.Text = "Add Problem"
        Me.btnAddProblem.UseVisualStyleBackColor = True
        '
        'dgvProblemsList
        '
        Me.dgvProblemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProblemsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.description, Me.isCritical, Me.isResolved})
        Me.dgvProblemsList.Location = New System.Drawing.Point(327, 12)
        Me.dgvProblemsList.Name = "dgvProblemsList"
        Me.dgvProblemsList.ReadOnly = True
        Me.dgvProblemsList.RowHeadersVisible = False
        Me.dgvProblemsList.RowHeadersWidth = 51
        Me.dgvProblemsList.RowTemplate.Height = 24
        Me.dgvProblemsList.Size = New System.Drawing.Size(444, 125)
        Me.dgvProblemsList.TabIndex = 6
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.description.HeaderText = "Problem description"
        Me.description.MinimumWidth = 6
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        '
        'isCritical
        '
        Me.isCritical.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.isCritical.HeaderText = "Critical?"
        Me.isCritical.MinimumWidth = 6
        Me.isCritical.Name = "isCritical"
        Me.isCritical.ReadOnly = True
        Me.isCritical.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.isCritical.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.isCritical.Width = 101
        '
        'isResolved
        '
        Me.isResolved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.isResolved.HeaderText = "Resolved?"
        Me.isResolved.MinimumWidth = 6
        Me.isResolved.Name = "isResolved"
        Me.isResolved.ReadOnly = True
        Me.isResolved.Width = 90
        '
        'btnLogs
        '
        Me.btnLogs.Location = New System.Drawing.Point(777, 82)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(93, 57)
        Me.btnLogs.TabIndex = 5
        Me.btnLogs.Text = "Logs"
        Me.btnLogs.UseVisualStyleBackColor = True
        '
        'gbCarDetails
        '
        Me.gbCarDetails.Controls.Add(Me.lblInsuranceData)
        Me.gbCarDetails.Controls.Add(Me.lblMilageData)
        Me.gbCarDetails.Controls.Add(Me.lblFuelData)
        Me.gbCarDetails.Controls.Add(Me.lblMilage)
        Me.gbCarDetails.Controls.Add(Me.lblInsurance)
        Me.gbCarDetails.Controls.Add(Me.lblFuel)
        Me.gbCarDetails.Location = New System.Drawing.Point(3, 3)
        Me.gbCarDetails.Name = "gbCarDetails"
        Me.gbCarDetails.Size = New System.Drawing.Size(316, 134)
        Me.gbCarDetails.TabIndex = 4
        Me.gbCarDetails.TabStop = False
        Me.gbCarDetails.Text = "Details"
        '
        'lblInsuranceData
        '
        Me.lblInsuranceData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInsuranceData.AutoSize = True
        Me.lblInsuranceData.Location = New System.Drawing.Point(219, 100)
        Me.lblInsuranceData.Name = "lblInsuranceData"
        Me.lblInsuranceData.Size = New System.Drawing.Size(89, 20)
        Me.lblInsuranceData.TabIndex = 6
        Me.lblInsuranceData.Text = "01.01.1970"
        '
        'lblMilageData
        '
        Me.lblMilageData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMilageData.AutoSize = True
        Me.lblMilageData.Location = New System.Drawing.Point(240, 65)
        Me.lblMilageData.Name = "lblMilageData"
        Me.lblMilageData.Size = New System.Drawing.Size(61, 20)
        Me.lblMilageData.TabIndex = 5
        Me.lblMilageData.Text = "___ km"
        '
        'lblFuelData
        '
        Me.lblFuelData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFuelData.AutoSize = True
        Me.lblFuelData.Location = New System.Drawing.Point(204, 31)
        Me.lblFuelData.Name = "lblFuelData"
        Me.lblFuelData.Size = New System.Drawing.Size(101, 20)
        Me.lblFuelData.TabIndex = 4
        Me.lblFuelData.Text = "___ L/100km"
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
        Me.lblInsurance.Location = New System.Drawing.Point(6, 100)
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
        Me.btnCarBack.Name = "btnCarBack"
        Me.btnCarBack.Size = New System.Drawing.Size(84, 29)
        Me.btnCarBack.TabIndex = 2
        Me.btnCarBack.Text = "Back"
        Me.btnCarBack.UseVisualStyleBackColor = True
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(795, 8)
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
        Me.dgvCarsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.registrationPlate, Me.carModel, Me.maintenence, Me.isAvailable, Me.DeleteButton})
        Me.dgvCarsList.Location = New System.Drawing.Point(6, 43)
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
        Me.tpGroups.Name = "tpGroups"
        Me.tpGroups.Size = New System.Drawing.Size(889, 521)
        Me.tpGroups.TabIndex = 6
        Me.tpGroups.Text = "Groups"
        Me.tpGroups.UseVisualStyleBackColor = True
        '
        'btnNewGroup
        '
        Me.btnNewGroup.Location = New System.Drawing.Point(326, 8)
        Me.btnNewGroup.Name = "btnNewGroup"
        Me.btnNewGroup.Size = New System.Drawing.Size(96, 29)
        Me.btnNewGroup.TabIndex = 5
        Me.btnNewGroup.Text = "New group"
        Me.btnNewGroup.UseVisualStyleBackColor = True
        '
        'gbGroups
        '
        Me.gbGroups.Controls.Add(Me.dgvGroupsList)
        Me.gbGroups.Location = New System.Drawing.Point(6, 43)
        Me.gbGroups.Name = "gbGroups"
        Me.gbGroups.Size = New System.Drawing.Size(422, 465)
        Me.gbGroups.TabIndex = 4
        Me.gbGroups.TabStop = False
        Me.gbGroups.Text = "Groups"
        '
        'dgvGroupsList
        '
        Me.dgvGroupsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGroupsList.Location = New System.Drawing.Point(6, 31)
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
        Me.gbRideHistory.Name = "gbRideHistory"
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
        Me.cbSortRides.Name = "cbSortRides"
        Me.cbSortRides.Size = New System.Drawing.Size(136, 28)
        Me.cbSortRides.TabIndex = 2
        Me.cbSortRides.Text = "Sort"
        '
        'dgvUserHistoryList
        '
        Me.dgvUserHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserHistoryList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.userHistoryRide, Me.userRidePeriod, Me.userRideDistance})
        Me.dgvUserHistoryList.Location = New System.Drawing.Point(6, 68)
        Me.dgvUserHistoryList.Name = "dgvUserHistoryList"
        Me.dgvUserHistoryList.ReadOnly = True
        Me.dgvUserHistoryList.RowHeadersVisible = False
        Me.dgvUserHistoryList.RowHeadersWidth = 51
        Me.dgvUserHistoryList.RowTemplate.Height = 24
        Me.dgvUserHistoryList.Size = New System.Drawing.Size(435, 434)
        Me.dgvUserHistoryList.TabIndex = 1
        '
        'userHistoryRide
        '
        Me.userHistoryRide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.userHistoryRide.HeaderText = "Ride"
        Me.userHistoryRide.MinimumWidth = 6
        Me.userHistoryRide.Name = "userHistoryRide"
        Me.userHistoryRide.ReadOnly = True
        '
        'userRidePeriod
        '
        Me.userRidePeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.userRidePeriod.HeaderText = "Period"
        Me.userRidePeriod.MinimumWidth = 6
        Me.userRidePeriod.Name = "userRidePeriod"
        Me.userRidePeriod.ReadOnly = True
        '
        'userRideDistance
        '
        Me.userRideDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.userRideDistance.HeaderText = "Distance"
        Me.userRideDistance.MinimumWidth = 6
        Me.userRideDistance.Name = "userRideDistance"
        Me.userRideDistance.ReadOnly = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(8, 8)
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
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Size = New System.Drawing.Size(889, 521)
        Me.tpLogin.TabIndex = 5
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Location = New System.Drawing.Point(324, 235)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Size = New System.Drawing.Size(247, 26)
        Me.txtLoginPassword.TabIndex = 18
        Me.txtLoginPassword.UseSystemPasswordChar = True
        '
        'txtLoginEmail
        '
        Me.txtLoginEmail.Location = New System.Drawing.Point(324, 166)
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
        Me.tcTabs.Location = New System.Drawing.Point(3, 3)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(897, 557)
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
        Me.tpAddProblem.Location = New System.Drawing.Point(4, 32)
        Me.tpAddProblem.Name = "tpAddProblem"
        Me.tpAddProblem.Size = New System.Drawing.Size(889, 521)
        Me.tpAddProblem.TabIndex = 8
        Me.tpAddProblem.Text = "Add Problem"
        Me.tpAddProblem.UseVisualStyleBackColor = True
        '
        'btnAddProblemEnter
        '
        Me.btnAddProblemEnter.Location = New System.Drawing.Point(456, 348)
        Me.btnAddProblemEnter.Name = "btnAddProblemEnter"
        Me.btnAddProblemEnter.Size = New System.Drawing.Size(122, 69)
        Me.btnAddProblemEnter.TabIndex = 6
        Me.btnAddProblemEnter.Text = "Enter"
        Me.btnAddProblemEnter.UseVisualStyleBackColor = True
        '
        'btnAddProblemCancel
        '
        Me.btnAddProblemCancel.Location = New System.Drawing.Point(302, 348)
        Me.btnAddProblemCancel.Name = "btnAddProblemCancel"
        Me.btnAddProblemCancel.Size = New System.Drawing.Size(122, 68)
        Me.btnAddProblemCancel.TabIndex = 5
        Me.btnAddProblemCancel.Text = "Cancel"
        Me.btnAddProblemCancel.UseVisualStyleBackColor = True
        '
        'cbCriticality
        '
        Me.cbCriticality.AutoSize = True
        Me.cbCriticality.Location = New System.Drawing.Point(492, 302)
        Me.cbCriticality.Name = "cbCriticality"
        Me.cbCriticality.Size = New System.Drawing.Size(91, 24)
        Me.cbCriticality.TabIndex = 4
        Me.cbCriticality.Text = "Critical?"
        Me.cbCriticality.UseVisualStyleBackColor = True
        '
        'txtProblemDescription
        '
        Me.txtProblemDescription.Location = New System.Drawing.Point(302, 202)
        Me.txtProblemDescription.Multiline = True
        Me.txtProblemDescription.Name = "txtProblemDescription"
        Me.txtProblemDescription.Size = New System.Drawing.Size(276, 90)
        Me.txtProblemDescription.TabIndex = 3
        '
        'lblCriticality
        '
        Me.lblCriticality.AutoSize = True
        Me.lblCriticality.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblCriticality.Location = New System.Drawing.Point(297, 297)
        Me.lblCriticality.Name = "lblCriticality"
        Me.lblCriticality.Size = New System.Drawing.Size(201, 26)
        Me.lblCriticality.TabIndex = 2
        Me.lblCriticality.Text = "Is it a critical issue?"
        '
        'lblIssueDescription
        '
        Me.lblIssueDescription.AutoSize = True
        Me.lblIssueDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblIssueDescription.Location = New System.Drawing.Point(340, 168)
        Me.lblIssueDescription.Name = "lblIssueDescription"
        Me.lblIssueDescription.Size = New System.Drawing.Size(191, 26)
        Me.lblIssueDescription.TabIndex = 1
        Me.lblIssueDescription.Text = "Describe the issue"
        '
        'lblProblemReportTitle
        '
        Me.lblProblemReportTitle.AutoSize = True
        Me.lblProblemReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblProblemReportTitle.Location = New System.Drawing.Point(321, 89)
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
        Me.tpAddLog.Name = "tpAddLog"
        Me.tpAddLog.Size = New System.Drawing.Size(889, 521)
        Me.tpAddLog.TabIndex = 9
        Me.tpAddLog.Text = "Add Log"
        Me.tpAddLog.UseVisualStyleBackColor = True
        '
        'btnAddLogEnter
        '
        Me.btnAddLogEnter.Location = New System.Drawing.Point(678, 426)
        Me.btnAddLogEnter.Name = "btnAddLogEnter"
        Me.btnAddLogEnter.Size = New System.Drawing.Size(148, 57)
        Me.btnAddLogEnter.TabIndex = 18
        Me.btnAddLogEnter.Text = "Enter"
        Me.btnAddLogEnter.UseVisualStyleBackColor = True
        '
        'btnAddLogCancel
        '
        Me.btnAddLogCancel.Location = New System.Drawing.Point(442, 426)
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
        Me.gbEnd.Name = "gbEnd"
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
        Me.txtLocationEnd.Name = "txtLocationEnd"
        Me.txtLocationEnd.Size = New System.Drawing.Size(283, 32)
        Me.txtLocationEnd.TabIndex = 8
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(12, 163)
        Me.dtpEndDate.MinDate = New Date(2025, 4, 24, 0, 0, 0, 0)
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
        Me.gbStart.Name = "gbStart"
        Me.gbStart.Size = New System.Drawing.Size(398, 237)
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
        Me.dtpStartDate.Location = New System.Drawing.Point(6, 163)
        Me.dtpStartDate.MaxDate = New Date(2025, 4, 24, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(384, 32)
        Me.dtpStartDate.TabIndex = 13
        Me.dtpStartDate.Value = New Date(2025, 4, 24, 0, 0, 0, 0)
        '
        'txtLocationStart
        '
        Me.txtLocationStart.Location = New System.Drawing.Point(105, 43)
        Me.txtLocationStart.Name = "txtLocationStart"
        Me.txtLocationStart.Size = New System.Drawing.Size(286, 32)
        Me.txtLocationStart.TabIndex = 7
        '
        'txtLogComment
        '
        Me.txtLogComment.Location = New System.Drawing.Point(162, 400)
        Me.txtLogComment.Multiline = True
        Me.txtLogComment.Name = "txtLogComment"
        Me.txtLogComment.Size = New System.Drawing.Size(241, 81)
        Me.txtLogComment.TabIndex = 12
        '
        'txtTotalDistance
        '
        Me.txtTotalDistance.Location = New System.Drawing.Point(162, 320)
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
        Me.lblDistanceAdd.Location = New System.Drawing.Point(14, 317)
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
        Me.tpNewGroup.Controls.Add(Me.TextBox1)
        Me.tpNewGroup.Controls.Add(Me.lblCreateGroup)
        Me.tpNewGroup.Location = New System.Drawing.Point(4, 32)
        Me.tpNewGroup.Name = "tpNewGroup"
        Me.tpNewGroup.Size = New System.Drawing.Size(889, 521)
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
        Me.btnCancelNewGroup.Location = New System.Drawing.Point(204, 397)
        Me.btnCancelNewGroup.Name = "btnCancelNewGroup"
        Me.btnCancelNewGroup.Size = New System.Drawing.Size(129, 63)
        Me.btnCancelNewGroup.TabIndex = 3
        Me.btnCancelNewGroup.Text = "Cancel"
        Me.btnCancelNewGroup.UseVisualStyleBackColor = True
        '
        'btnEnterNewGroup
        '
        Me.btnEnterNewGroup.Location = New System.Drawing.Point(518, 397)
        Me.btnEnterNewGroup.Name = "btnEnterNewGroup"
        Me.btnEnterNewGroup.Size = New System.Drawing.Size(129, 63)
        Me.btnEnterNewGroup.TabIndex = 2
        Me.btnEnterNewGroup.Text = "Enter"
        Me.btnEnterNewGroup.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(354, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(292, 26)
        Me.TextBox1.TabIndex = 1
        '
        'lblCreateGroup
        '
        Me.lblCreateGroup.AutoSize = True
        Me.lblCreateGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblCreateGroup.Location = New System.Drawing.Point(308, 17)
        Me.lblCreateGroup.Name = "lblCreateGroup"
        Me.lblCreateGroup.Size = New System.Drawing.Size(238, 32)
        Me.lblCreateGroup.TabIndex = 0
        Me.lblCreateGroup.Text = "Create new group"
        '
        'tpRegister
        '
        Me.tpRegister.Controls.Add(Me.Label1)
        Me.tpRegister.Controls.Add(Me.lblConfirmPassword)
        Me.tpRegister.Controls.Add(Me.lblRegisterPassword)
        Me.tpRegister.Controls.Add(Me.lblRegisterEmail)
        Me.tpRegister.Controls.Add(Me.tbPasswordConfirm)
        Me.tpRegister.Controls.Add(Me.tbRegisterPassword)
        Me.tpRegister.Controls.Add(Me.tbRegisterEmail)
        Me.tpRegister.Controls.Add(Me.btnRegisterEnter)
        Me.tpRegister.Controls.Add(Me.btnRegisterCancel)
        Me.tpRegister.Location = New System.Drawing.Point(4, 32)
        Me.tpRegister.Name = "tpRegister"
        Me.tpRegister.Size = New System.Drawing.Size(889, 521)
        Me.tpRegister.TabIndex = 11
        Me.tpRegister.Text = "Register"
        Me.tpRegister.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(282, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Create a new account"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblConfirmPassword.Location = New System.Drawing.Point(252, 305)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(194, 26)
        Me.lblConfirmPassword.TabIndex = 7
        Me.lblConfirmPassword.Text = "Confirm password:"
        '
        'lblRegisterPassword
        '
        Me.lblRegisterPassword.AutoSize = True
        Me.lblRegisterPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblRegisterPassword.Location = New System.Drawing.Point(252, 235)
        Me.lblRegisterPassword.Name = "lblRegisterPassword"
        Me.lblRegisterPassword.Size = New System.Drawing.Size(114, 26)
        Me.lblRegisterPassword.TabIndex = 6
        Me.lblRegisterPassword.Text = "Password:"
        '
        'lblRegisterEmail
        '
        Me.lblRegisterEmail.AutoSize = True
        Me.lblRegisterEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblRegisterEmail.Location = New System.Drawing.Point(252, 155)
        Me.lblRegisterEmail.Name = "lblRegisterEmail"
        Me.lblRegisterEmail.Size = New System.Drawing.Size(74, 26)
        Me.lblRegisterEmail.TabIndex = 5
        Me.lblRegisterEmail.Text = "Email:"
        '
        'tbPasswordConfirm
        '
        Me.tbPasswordConfirm.Location = New System.Drawing.Point(480, 308)
        Me.tbPasswordConfirm.Name = "tbPasswordConfirm"
        Me.tbPasswordConfirm.Size = New System.Drawing.Size(112, 26)
        Me.tbPasswordConfirm.TabIndex = 4
        '
        'tbRegisterPassword
        '
        Me.tbRegisterPassword.Location = New System.Drawing.Point(480, 237)
        Me.tbRegisterPassword.Name = "tbRegisterPassword"
        Me.tbRegisterPassword.Size = New System.Drawing.Size(112, 26)
        Me.tbRegisterPassword.TabIndex = 3
        '
        'tbRegisterEmail
        '
        Me.tbRegisterEmail.Location = New System.Drawing.Point(480, 157)
        Me.tbRegisterEmail.Name = "tbRegisterEmail"
        Me.tbRegisterEmail.Size = New System.Drawing.Size(112, 26)
        Me.tbRegisterEmail.TabIndex = 2
        '
        'btnRegisterEnter
        '
        Me.btnRegisterEnter.Location = New System.Drawing.Point(508, 408)
        Me.btnRegisterEnter.Name = "btnRegisterEnter"
        Me.btnRegisterEnter.Size = New System.Drawing.Size(84, 29)
        Me.btnRegisterEnter.TabIndex = 1
        Me.btnRegisterEnter.Text = "Enter"
        Me.btnRegisterEnter.UseVisualStyleBackColor = True
        '
        'btnRegisterCancel
        '
        Me.btnRegisterCancel.Location = New System.Drawing.Point(256, 408)
        Me.btnRegisterCancel.Name = "btnRegisterCancel"
        Me.btnRegisterCancel.Size = New System.Drawing.Size(84, 29)
        Me.btnRegisterCancel.TabIndex = 0
        Me.btnRegisterCancel.Text = "Cancel"
        Me.btnRegisterCancel.UseVisualStyleBackColor = True
        '
        'registrationPlate
        '
        Me.registrationPlate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.registrationPlate.HeaderText = "Registration plate"
        Me.registrationPlate.MinimumWidth = 6
        Me.registrationPlate.Name = "registrationPlate"
        Me.registrationPlate.ReadOnly = True
        Me.registrationPlate.Width = 170
        '
        'carModel
        '
        Me.carModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.carModel.HeaderText = "Car Model"
        Me.carModel.MinimumWidth = 6
        Me.carModel.Name = "carModel"
        Me.carModel.ReadOnly = True
        '
        'maintenence
        '
        Me.maintenence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.maintenence.HeaderText = "Maintenence"
        Me.maintenence.MinimumWidth = 6
        Me.maintenence.Name = "maintenence"
        Me.maintenence.ReadOnly = True
        Me.maintenence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.maintenence.Width = 137
        '
        'isAvailable
        '
        Me.isAvailable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.isAvailable.HeaderText = "Availability"
        Me.isAvailable.MinimumWidth = 6
        Me.isAvailable.Name = "isAvailable"
        Me.isAvailable.ReadOnly = True
        Me.isAvailable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.isAvailable.Width = 117
        '
        'DeleteButton
        '
        Me.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DeleteButton.HeaderText = ""
        Me.DeleteButton.MinimumWidth = 6
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.ReadOnly = True
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseColumnTextForButtonValue = True
        Me.DeleteButton.Width = 50
        '
        'formTableViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 563)
        Me.Controls.Add(Me.tcTabs)
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
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents isCritical As DataGridViewCheckBoxColumn
    Friend WithEvents isResolved As DataGridViewCheckBoxColumn
    Friend WithEvents trip As DataGridViewTextBoxColumn
    Friend WithEvents time As DataGridViewTextBoxColumn
    Friend WithEvents userHistoryRide As DataGridViewTextBoxColumn
    Friend WithEvents userRidePeriod As DataGridViewTextBoxColumn
    Friend WithEvents userRideDistance As DataGridViewTextBoxColumn
    Friend WithEvents tpNewGroup As TabPage
    Friend WithEvents btnEnterNewGroup As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCreateGroup As Label
    Friend WithEvents btnCancelNewGroup As Button
    Friend WithEvents lblGroupName As Label
    Friend WithEvents tpRegister As TabPage
    Friend WithEvents btnRegisterEnter As Button
    Friend WithEvents btnRegisterCancel As Button
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblRegisterPassword As Label
    Friend WithEvents lblRegisterEmail As Label
    Friend WithEvents tbPasswordConfirm As TextBox
    Friend WithEvents tbRegisterPassword As TextBox
    Friend WithEvents tbRegisterEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCarsSort As ComboBox
    Friend WithEvents registrationPlate As DataGridViewTextBoxColumn
    Friend WithEvents carModel As DataGridViewTextBoxColumn
    Friend WithEvents maintenence As DataGridViewCheckBoxColumn
    Friend WithEvents isAvailable As DataGridViewCheckBoxColumn
    Friend WithEvents DeleteButton As DataGridViewButtonColumn
End Class
