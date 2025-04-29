Imports System.ComponentModel
Imports System.Net
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles
Imports CEntities
Imports CTableReader

Public Class formTableViewer
    Const DEBUG = True
    Private ADMIN = False
    Private expandedRowIndex As Integer = -1
    Private TableReader As New CTableReader.CTableReader()

    ' CHANGE THESE TO YOUR LOG IN INFO SO THAT YOU CAN LOG IN FASTER
    Const QUICK_LOGIN_USER = "test@test.com"
    Const QUICK_LOGIN_PASS = "Test123!"

    Private Sub formTableViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Hides the tabs while the program is running so that the user can't change them manually
        tcTabs.ItemSize = New Size(0, 1)
        tcTabs.SizeMode = TabSizeMode.Fixed

        ' Initialize the form on the "Cars list" tab until log in and/or group view has been built
        tcTabs.SelectedTab = tpLogin

        ' Set panel width
        pnlDetails.Left = dgvCarsList.Left + 2
        pnlDetails.Width = dgvCarsList.Width - 4
        pnlLogs.Left = dgvCarsList.Left + 2
        pnlLogs.Width = dgvCarsList.Width - 4

        ' Change the select color from an eye piercing blue to a more subtle gray
        dgvCarsList.DefaultCellStyle.SelectionBackColor = Color.LightGray
        dgvProblemsList.DefaultCellStyle.SelectionBackColor = Color.LightGray
        dgvLogsList.DefaultCellStyle.SelectionBackColor = Color.LightGray

    End Sub

    ' Description:  Checks whether input fields for adding a car are valid or not
    ' Parameters:   NONE
    ' Return:       Boolean value of whether input fields are valid or not
    Private Function ValidateInput() As Boolean
        ' Validate the input fields

        ' Car name cannot be empty
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            txtName.Text = "Please enter car name"
            Return False

            ' Car milage must be a numeric value
        ElseIf String.IsNullOrWhiteSpace(txtMileage.Text) _
            OrElse Not IsNumeric(txtMileage.Text) Then
            txtMileage.Text = "Pelase enter valid mileage"
            Return False

            ' Average fuel consumption must be a numberic value
        ElseIf String.IsNullOrWhiteSpace(txtAvgFuel.Text) _
            OrElse Not IsNumeric(txtAvgFuel.Text) Then
            txtAvgFuel.Text = "Please enter valid average fuel consumption"
            Return False
        End If
        ' TODO: Add check, if car is already in list/database

        If DEBUG Then
            MessageBox.Show($"Name: {txtName.Text}, Mileage: {txtMileage.Text}
                                , Avg Fuel Consumption: {txtAvgFuel.Text}, 
                                Ready: {cboxReady.Checked}, Archived: {cboxArchive.Checked}")
        End If

        Return True
    End Function


    ' Description:  Clears the flieds when adding a new car
    ' Parameters:   The usual handler parameters
    ' Return:       NONE
    Private Sub txtAddCarFields_Click(sender As Object, e As EventArgs) _
        Handles txtAvgFuel.Click, txtMileage.Click, txtName.Click
        ' Figure out which textbox was clicked
        Dim txt As TextBox = CType(sender, TextBox)

        ' Clear the field
        txt.Clear()

        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    ' Description:  Checks whether the delete button of the row has been pressed and removes it
    ' Parameters:   Default handler parameters
    ' Return:       NONE
    Private Sub dgvCarsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarsList.CellContentClick
        ' Check if the clicked cell is in the header or not
        If e.RowIndex < 0 Then
            Return
        End If

        ' TODO: Once removing functionality for the database has been made. Fill it out!
        ' Temporary solution
        If e.ColumnIndex = dgvCarsList.Columns("DeleteButton").Index Then
            dgvCarsList.Rows.Remove(dgvCarsList.Rows(e.RowIndex))
        End If
    End Sub

    ' Description:  Clicking one of the fields changes tabs to the problems view
    ' Parameters:   Default handler parameters
    ' Return:       NONE
    Private Sub dgvCarsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarsList.CellClick
        ' Check if the clicked cell is in the header or delete button
        If e.RowIndex < 0 Or e.ColumnIndex = (dgvCarsList.ColumnCount - 1) Then
            Return
        ElseIf e.RowIndex = expandedRowIndex Then ' Clicking the same row will close it
            pnlDetails.Visible = False
            pnlLogs.Visible = False
            expandedRowIndex = -1
            Return
        End If

        ' Get the area of the row that was clicked
        Dim rowRect As Rectangle = dgvCarsList.GetRowDisplayRectangle(e.RowIndex, True)

        ' Style it so that it looks like a "drop down panel"
        pnlDetails.Top = dgvCarsList.Top + rowRect.Bottom
        pnlDetails.Visible = True
        dgvProblemsList.DataSource = TableReader.GetSpecificTables("CarIssue", dgvCarsList.Rows(e.RowIndex).Cells("CarID").Value)

        ' Style the logs panel the same way as details panel, but not visible (yet)
        pnlLogs.Top = dgvCarsList.Top + rowRect.Bottom

        ' Assign detailed values to the data fields
        lblFuelData.Text = dgvCarsList.Rows(e.RowIndex).Cells("CarAvgFuelConsumption").Value & " L/100km"
        lblMilageData.Text = dgvCarsList.Rows(e.RowIndex).Cells("CarMileage").Value & " km"

        ' Find whether the selected car has any ongoing insurances
        ' TODO: Make it possible to search through the database for insurance

        ' Check if the insurance item exists
        Dim insuranceData As New DataTable()
        insuranceData = TableReader.GetSpecificTables("CarInsurance", dgvCarsList.Rows(e.RowIndex).Cells("CarID").Value.ToString())
        lblInsuranceData.Text = insuranceData.Rows(0)("CarInsuranceEndDate")
        lblInsuranceNameData.Text = insuranceData.Rows(0)("CarInsuranceName")

        ' Update the expanded row to be the current row
        expandedRowIndex = e.RowIndex
    End Sub

    ' Description:  By pressing this button, the data inserted into the fields in tpAddCar is added into the database
    ' Parameters:   Default handler parameters
    ' Return:       NONE
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnAddCarEnter.Click

        Dim done As Boolean = False
        'initiate groupID, import correct ID later
        Dim groupID As Integer = 0

        ' Validate input fields
        If Not ValidateInput() Then
            ' Force garbage collection
            GC.Collect()
            GC.WaitForPendingFinalizers()
            Return
        End If

        ' Add the new car to the list
        done = True
        ' TODO: Add the car to the database

        ' Clear input fields
        txtName.Clear()
        txtMileage.Clear()
        txtAvgFuel.Clear()

        If done Then
            ' Force garbage collection
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If DEBUG Then
                MessageBox.Show("Operation successful")
            End If
        Else
            MessageBox.Show("Operation failed")
        End If

        ChangeTab(CType(sender, Button))
    End Sub

    Private Sub cboxArchive_CheckedChanged(sender As Object, e As EventArgs) Handles cboxArchive.CheckedChanged
        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
    Private Sub cboxReady_CheckedChanged(sender As Object, e As EventArgs) Handles cboxReady.CheckedChanged
        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    ' Description:  Handler function for all the buttons that change tabs
    ' Parameters:   The usual for an event handler
    ' Return:       NONE
    Private Sub Button_Click(sender As Object, e As EventArgs) _
        Handles btnCarBack.Click, btnLoginLogin.Click, btnAddCarCancel.Click,
        btnAddCar.Click, btnAddProblemCancel.Click, btnAddProblem.Click,
        btnAddLog.Click, btnAddLogCancel.Click, btnAddLogEnter.Click,
        btnLogOut.Click, btnLoginRegister.Click, btnRegisterCancel.Click,
        btnRegisterEnter.Click, btnNewGroup.Click, btnCancelNewGroup.Click,
        btnEnterNewGroup.Click, btnDetailsUpdateInsurance.Click,
        btnUpdateInsuranceCancel.Click, btnUpdateInsuranceEnter.Click

        'Get the button that was clicked
        Dim btn As Button = CType(sender, Button)

        ChangeTab(btn)
    End Sub

    ' Description:  Big Select case, where tab selection happens
    ' Parameters:   btn - variable of the button that was clicked
    ' Return:       NONE
    Private Sub ChangeTab(ByVal btn As Button)
        Dim tab As TabPage

        Select Case btn.Name

            Case "btnLoginLogin"
                ' Set tab to Groups

                ' TEMPORARY QUICK LOGIN
                If txtLoginEmail.Text = "" And txtLoginPassword.Text = "" Then
                    txtLoginEmail.Text = QUICK_LOGIN_USER
                    txtLoginPassword.Text = QUICK_LOGIN_PASS
                End If


                If (TableReader.LoginRegister(txtLoginEmail.Text, txtLoginPassword.Text, "Login")) Then
                    Console.WriteLine("Login successful")
                    ' TableReader.GetSpecificTables("Car", )

                    tab = tpGroups
                    LoadToGroupTab()
                Else
                    Console.WriteLine("Login failed")
                    tab = tpLogin
                End If
            Case "btnLoginRegister"
                ' Set tab to Register
                tab = tpRegister

            ' Buttons for going back to the previous tab
            Case "btnCarBack"
                ' Set tab to Group
                tab = tpGroups
                LoadToGroupTab()

            Case "btnProblemBack"
                ' Set tab to Car Details
                tab = tpCarsList
            Case "btnLogOut"
                ' Set tab to LogIn
                tab = tpLogin
                ' TODO: Log user out
            Case "btnAddLog"
                ' Set tab to Add Log
                tab = tpAddLog
            Case "btnNewGroup"
                ' Set tab to New Group
                tab = tpNewGroup
            Case "btnDetailsUpdateInsurance"
                tab = tpUpdateInsurance

            ' "Cancel" buttons for adding
            Case "btnAddCarCancel"
                ' Set tab to Cars List
                tab = tpCarsList
                ' Clear fields
                txtName.Clear()
                txtMileage.Clear()
                txtAvgFuel.Clear()
            Case "btnAddProblemCancel"
                ' Set the tab to Cars List
                tab = tpCarsList
                ' Clear field
                txtProblemDescription.Clear()
            Case "btnAddLogCancel"
                ' Set the tab to Cars List
                tab = tpCarsList
                ' Clear fields
            Case "btnRegisterCancel"
                ' Set tab to Log in
                tab = tpLogin
            Case "btnCancelNewGroup"
                ' Set tab to Groups
                tab = tpGroups
                LoadToGroupTab()
            Case "btnUpdateInsuranceCancel"
                tab = tpCarsList

            ' "Enter" buttons for adding
            Case "btnAddCarEnter"
                ' Set tab to Cars List
                tab = tpCarsList
                ' TODO: Add car to the database
            Case "btnAddProblemEnter"
                ' Set tab to Cars List
                tab = tpCarsList
                ' TODO: Add problem to the database
            Case "btnAddLogEnter"
                ' Set tab to Cars List
                tab = tpCarsList
                ' TODO: Add log to the database
            Case "btnRegisterEnter"
                ' Set tab to Log in
                tab = tpLogin
                ' TODO: Add user to database
            Case "btnEnterNewGroup"
                ' Set tab to Groups
                tab = tpGroups
                LoadToGroupTab()
                ' TODO: Add group to database
                Dim newGroup As New Group(txtNewGroupName.Text)
                TableReader.AddTable("Group", newGroup)
            Case "btnUpdateInsuranceEnter"
                tab = tpCarsList
                ' TODO: Actually update the insurance

            Case Else
                ' In case something goes wrong, it'll just stay on the same page
                tab = tcTabs.SelectedTab
        End Select

        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()

        ' Change the tab
        tcTabs.SelectedTab = tab
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click, btnProblems.Click
        Dim btn As Button = CType(sender, Button)

        Select Case btn.Name
            Case "btnLogs"
                pnlDetails.Visible = False
                pnlLogs.Visible = True
                If dgvLogsList.DataSource Is Nothing Then
                    dgvLogsList.DataSource = TableReader.GetSpecificTables("CarLog", dgvCarsList.Rows(expandedRowIndex).Cells("CarID").Value)
                End If
            Case "btnProblems"
                pnlDetails.Visible = True
                pnlLogs.Visible = False
                If dgvProblemsList Is Nothing Then
                    dgvProblemsList.DataSource = TableReader.GetSpecificTables("CarIssue", dgvCarsList.Rows(expandedRowIndex).Cells("CarID").Value)
                End If
        End Select
    End Sub

    Private Sub dgvGroupsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGroupsList.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        ' Change tab to Cars list
        tcTabs.SelectedTab = tpCarsList

        ' Get the ID of selected cell
        Dim SelectedID As String = dgvGroupsList.Rows(e.RowIndex).Cells("ID").Value.ToString()

        dgvCarsList.DataSource = TableReader.GetSpecificTables("Car", SelectedID)

        Dim carDeleteButton As New DataGridViewButtonColumn()
        carDeleteButton.Name = "DeleteButton"
        carDeleteButton.HeaderText = ""
        carDeleteButton.UseColumnTextForButtonValue = True
        dgvCarsList.Columns.Add(carDeleteButton)

        ' TODO: Check if user is an admin in this group
        If True Then
            ADMIN = True
            btnAddCar.Visible = ADMIN
            dgvCarsList.ReadOnly = Not ADMIN
            dgvProblemsList.ReadOnly = Not ADMIN
            dgvUserHistoryList.ReadOnly = Not ADMIN
            dgvLogsList.ReadOnly = Not ADMIN
        End If

        Dim data As New DataTable()
        Dim message As String = "Expiring insurances:" & Environment.NewLine
        Dim messageLen As Integer = message.Length

        ' Go through the rows in the DGV
        For Each row In dgvCarsList.Rows
            If Not row.IsNewRow Then
                data = TableReader.GetSpecificTables("CarInsurance", row.Cells("CarID").Value.ToString())

                If data.Rows.Count > 0 Then
                    Dim endDate As DateTime = data.Rows(0)("CarInsuranceEndDate")

                    ' Compare endate to 2 weeks from today
                    If endDate <= DateAdd(DateInterval.Day, 14, DateAndTime.Today) Then
                        ' Add Car to message
                        message = message & row.Cells("CarRegistrationPlate").Value.ToString() & " - " & row.Cells("CarName").Value.ToString() & Environment.NewLine
                    End If
                End If
            End If
        Next

        ' Inform the admin of the expirations
        If message.Length > messageLen Then
            MessageBox.Show(message)
        End If
    End Sub

    ' Description:  Loads the group list into the DataGridView
    ' Used when: 'tab = tpGroups' is called
    Private Sub LoadToGroupTab()
        dgvGroupsList.DataSource = TableReader.GetGroupTable()
        dgvGroupsList.Columns(0).Visible = False
        dgvGroupsList.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub btnGetDistance_Click(sender As Object, e As EventArgs) Handles btnGetDistance.Click
        lblStartData.Text = dtpStatsTimeStart.Value
        lblEndData.Text = dtpStatsTimeEnd.Value
        lblCommentData.Text = "___"

        Dim totalDistance As Double = 0

        For Each log In dgvLogsList.Rows
            If CDate(log.Cells("CarLogStartDate").Value) >= CDate(dtpStatsTimeStart.Value) And CDate(log.Cells("CarLogEndDate").Value) <= CDate(dtpStatsTimeEnd.Value) Then
                totalDistance = totalDistance + CType(log.Cells("CarLogDistance").Value, Integer)
            End If
        Next

        lblDistanceData.Text = totalDistance.ToString() & " km"
    End Sub

    Private Sub dgvLogsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogsList.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If

        lblStartData.Text = dgvLogsList.Rows(e.RowIndex).Cells("CarLogStartDate").Value

        lblEndData.Text = dgvLogsList.Rows(e.RowIndex).Cells("CarLogEndDate").Value

        lblDistanceData.Text = dgvLogsList.Rows(e.RowIndex).Cells("CarLogDistance").Value & " km"

        lblCommentData.Text = dgvLogsList.Rows(e.RowIndex).Cells("CarLogComment").Value
    End Sub

    Private Sub btnUpdateInsuranceCancel_Click(sender As Object, e As EventArgs) Handles btnUpdateInsuranceCancel.Click

    End Sub

    Private Sub btnUpdateInsuranceEnter_Click(sender As Object, e As EventArgs) Handles btnUpdateInsuranceEnter.Click

    End Sub
End Class
