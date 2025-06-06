﻿Imports System.ComponentModel
Imports System.Net
Imports System.Security.Policy
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles
Imports CEntities
Imports CTableReader

Public Class formTableViewer
    Const DEBUG = False
    Private ADMIN = True
    Private expandedRowIndex As Integer = -1
    Private currentGroup As String = ""
    Private TableReader As New CTableReader.CTableReader()

    ' CHANGE THESE TO YOUR LOG IN INFO SO THAT YOU CAN LOG IN FASTER
    Const QUICK_LOGIN_USER = "test@gmail.com"
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

        ' settings to remove default empty row
        dgvCarsList.AllowUserToAddRows = False
        dgvProblemsList.AllowUserToAddRows = False
        dgvLogsList.AllowUserToAddRows = False
        dgvGroupsList.AllowUserToAddRows = False
        dgvUserHistoryList.AllowUserToAddRows = False

        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()

    End Sub

    ' Description:  Clears the flieds when adding a new car
    ' Parameters:   The usual handler parameters
    ' Return:       NONE
    Private Sub txtAddCarFields_Click(sender As Object, e As EventArgs) _
        Handles txtAddCarAvgFuel.Click, txtAddCarMileage.Click, txtAddCarName.Click
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

            Dim SelectedID As String = dgvCarsList.Rows(e.RowIndex).Cells("CarID").Value

            ' Confirm with the user before deleting the car
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                If TableReader.RemoveTable("Car", SelectedID) Then
                    dgvCarsList.Rows.Remove(dgvCarsList.Rows(e.RowIndex))
                Else
                    MessageBox.Show("Car not removed")
                End If
            End If
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
        LoadToProblemTable(dgvCarsList.Rows(e.RowIndex).Cells("CarID").Value)

        ' Style the logs panel the same way as details panel, but not visible (yet)
        pnlLogs.Top = dgvCarsList.Top + rowRect.Bottom
        LoadToLogTable(dgvCarsList.Rows(e.RowIndex).Cells("CarID").Value)

        ' Assign detailed values to the data fields
        lblFuelData.Text = dgvCarsList.Rows(e.RowIndex).Cells("Average Fuel Consumption").Value & " L/100km"
        lblMilageData.Text = dgvCarsList.Rows(e.RowIndex).Cells("Mileage").Value & " km"

        ' Find whether the selected car has any ongoing insurances
        ' TODO: Make it possible to search through the database for insurance

        ' Check if the insurance item exists
        Dim insuranceData As New DataTable()
        insuranceData = TableReader.GetSpecificTables("CarInsurance", dgvCarsList.Rows(e.RowIndex).Cells("CarID").Value.ToString())
        If insuranceData Is Nothing OrElse insuranceData.Rows.Count = 0 Then
            ' Handle the case where insuranceData is Nothing or has no rows
            lblInsuranceData.Text = ""
            lblInsuranceNameData.Text = ""
        Else
            lblInsuranceData.Text = insuranceData.Rows(0)("Insurance End Date")
            lblInsuranceNameData.Text = insuranceData.Rows(0)("Insurance Name")
        End If


        ' Update the expanded row to be the current row
        expandedRowIndex = e.RowIndex
    End Sub

    Private Sub cboxArchive_CheckedChanged(sender As Object, e As EventArgs) Handles cboxAddCarIsArchived.CheckedChanged
        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
    Private Sub cboxReady_CheckedChanged(sender As Object, e As EventArgs) Handles cboxAddCarIsAvailable.CheckedChanged
        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    ' Description:  Handler function for all the buttons that change tabs
    ' Parameters:   The usual for an event handler
    ' Return:       NONE
    Private Sub Button_Click(sender As Object, e As EventArgs) _
        Handles btnCarBack.Click, btnLoginLogin.Click, btnAddCarCancel.Click,
        btnAddCar.Click, btnAddProblemCancel.Click, btnAddProblem.Click, btnAddProblemEnter.Click,
        btnAddLog.Click, btnAddLogCancel.Click, btnAddLogEnter.Click,
        btnLogOut.Click, btnLoginRegister.Click, btnRegisterCancel.Click,
        btnRegisterEnter.Click, btnNewGroup.Click, btnCancelNewGroup.Click,
        btnEnterNewGroup.Click, btnDetailsUpdateInsurance.Click,
        btnUpdateInsuranceCancel.Click, btnUpdateInsuranceEnter.Click,
        btnAddMember.Click, btnAddMemberCancel.Click, btnAddMemberEnter.Click, btnAddCarEnter.Click

        'Get the button that was clicked
        Dim btn As Button = CType(sender, Button)

        ChangeTab(btn)
    End Sub

    Private Function ValidRegistration(ByVal input As String) As Boolean
        Dim valid As Boolean = True
        If input.Length = 6 Then
            Dim numbers = input.Substring(0, input.Length / 2)
            Dim text = input.Substring(3, input.Length / 2)
            Dim charCount As Integer = 0
            If IsNumeric(numbers) Then
                For Each c As Char In text
                    If Char.IsLetter(c) And Char.IsUpper(c) Then
                        charCount = charCount + 1
                    End If
                Next
                If Not charCount = 3 Then
                    valid = False
                End If
            Else
                valid = False
            End If
        Else
            valid = False
        End If

        dgvCarsList.DataSource = TableReader.GetSpecificTables("Car", dgvGroupsList.Rows(dgvGroupsList.CurrentRow.Index).Cells("ID").Value.ToString())

        For Each row As DataGridViewRow In dgvCarsList.Rows
            If Not row.IsNewRow Then
                Dim cellValue As String = row.Cells(4).Value
                If cellValue IsNot Nothing AndAlso cellValue.Contains(input) Then
                    valid = False
                    Exit For
                End If
            End If
        Next

        If valid Then
                Return True
            Else
                Return False
            End If
    End Function



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
                    MessageBox.Show("Login Failed.")
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
                currentGroup = ""

            Case "btnProblemBack"
                ' Set tab to Car Details
                tab = tpCarsList
                LoadToCarTable(dgvGroupsList.Rows(dgvGroupsList.CurrentRow.Index).Cells("ID").Value.ToString())
            Case "btnLogOut"
                ' Set tab to LogIn
                If TableReader.Logout() Then

                    tab = tpLogin
                Else
                    tab = tpGroups

                    LoadToGroupTab()
                End If

                ' TODO: Log user out
            Case "btnAddLog"
                ' Set tab to Add Log

                tab = tpAddLog
            Case "btnNewGroup"
                ' Set tab to New Group

                tab = tpNewGroup
            Case "btnDetailsUpdateInsurance"

                tab = tpUpdateInsurance
            Case "btnAddCar"

                tab = tpAddCar
            Case "btnAddMember"

                tab = tpAddMember
            Case "btnAddProblem"

                tab = tpAddProblem

            ' "Cancel" buttons for adding
            Case "btnAddCarCancel"
                ' Set tab to Cars List
                tab = tpCarsList
                LoadToCarTable(dgvGroupsList.Rows(dgvGroupsList.CurrentRow.Index).Cells("ID").Value.ToString())
                ' Clear fields
                txtAddCarName.Clear()
                txtAddCarRegistrationPlate.Clear()
                txtAddCarMileage.Clear()
                txtAddCarAvgFuel.Clear()
            Case "btnAddProblemCancel"
                ' Set the tab to Cars List
                tab = tpCarsList
                LoadToCarTable(dgvGroupsList.Rows(dgvGroupsList.CurrentRow.Index).Cells("ID").Value.ToString())
                ' Clear field
                txtProblemDescription.Clear()
            Case "btnAddLogCancel"
                ' Set the tab to Cars List
                tab = tpCarsList
                LoadToCarTable(dgvGroupsList.Rows(dgvGroupsList.CurrentRow.Index).Cells("ID").Value.ToString())
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
                LoadToCarTable(dgvGroupsList.Rows(dgvGroupsList.CurrentRow.Index).Cells("ID").Value.ToString())
            Case "btnAddMemberCancel"
                tab = tpCarsList
                LoadToCarTable(dgvGroupsList.Rows(dgvGroupsList.CurrentRow.Index).Cells("ID").Value.ToString())

            ' "Enter" buttons for adding
            Case "btnAddCarEnter"

                Dim GroupID As String = dgvGroupsList.Rows(dgvGroupsList.CurrentRow.Index).Cells("ID").Value.ToString()
                Dim Name As String = txtAddCarName.Text
                Dim RegistrationPlate As String '= txtAddCarRegistrationPlate.Text
                Dim Mileage As Double
                Dim AvgFuelCons As Double
                Dim IsAvailable As Boolean = cboxAddCarIsAvailable.Checked
                Dim IsArchived As Boolean = cboxAddCarIsArchived.Checked
                Dim IsCritical As Boolean = False

                If Double.TryParse(txtAddCarMileage.Text, Mileage) Then
                    ' Proceed with valid Mileage
                Else
                    MessageBox.Show("Please enter a valid numeric value for Mileage.")
                    Return
                End If

                If Double.TryParse(txtAddCarAvgFuel.Text, AvgFuelCons) Then
                    ' Proceed with valid Mileage
                Else
                    MessageBox.Show("Please enter a valid numeric value for AvgFuelCons.")
                    Return
                End If
                Console.WriteLine("Reg Len: " & txtAddCarRegistrationPlate.Text.Length)
                If ValidRegistration(txtAddCarRegistrationPlate.Text) Then
                    'Reg plate is valid
                    RegistrationPlate = txtAddCarRegistrationPlate.Text
                Else
                    MessageBox.Show("Registration plate must be 6 characters long" & vbCrLf &
                                    "first 3 characters must be numbers" & vbCrLf &
                                    "Last 3 characters must be alphabetical" & vbCrLf &
                                    "Example: 123ABC")
                    Return
                End If

                Dim NewCar As New CEntities.Car(GroupID, Name, RegistrationPlate, Mileage, AvgFuelCons, IsAvailable, IsArchived, IsCritical)

                'TODO: check if inputs are valid
                If TableReader.AddTable("Car", NewCar) Then
                    LoadToCarTable(GroupID)
                    tab = tpCarsList
                Else
                    tab = tpAddCar
                End If

            Case "btnAddProblemEnter"
                Dim NewIssue As New CEntities.CarIssue(dgvCarsList.Rows(expandedRowIndex).Cells("CarID").Value, txtProblemDescription.Text, cbCriticality.Checked, False)

                If TableReader.AddTable("CarIssue", NewIssue) Then
                    ' Set tab to Cars List
                    tab = tpCarsList
                Else
                    tab = tpAddProblem
                End If

                LoadToProblemTable(dgvCarsList.Rows(expandedRowIndex).Cells("CarID").Value)

            Case "btnAddLogEnter"
                ' TODO: Add log to the database
                Dim NewLog As New CEntities.CarLog(dgvCarsList.Rows(expandedRowIndex).Cells("CarID").Value,
                                                   CType(dtpStartDate.Value, Date), CType(dtpEndDate.Value, Date), txtLocationStart.Text,
                                                   txtLocationEnd.Text, CType(txtTotalDistance.Text, Double),
                                                   txtLogComment.Text)

                If TableReader.AddTable("CarLog", NewLog) Then
                    ' Set tab to Cars List
                    'TODO: Clear LogEnter fields
                    tab = tpCarsList
                Else
                    tab = tpAddLog
                End If

                LoadToLogTable(dgvCarsList.Rows(expandedRowIndex).Cells("CarID").Value)

            Case "btnRegisterEnter"
                ' Set tab to Log in

                ' TODO: Check if user with email is already in the database
                ' TODO: Check if the entered email and password are valid

                Dim email As String = tbRegisterEmail.Text
                Dim password As String = tbRegisterPassword.Text
                Dim confirmPassword As String = tbRegisterPasswordConfirm.Text

                If (AccountRegistration(email, password, confirmPassword)) Then
                    tab = tpLogin
                Else
                    tab = tpRegister
                End If
                ' TODO: Add user to database

            Case "btnEnterNewGroup"
                ' Set tab to Groups
                tab = tpGroups

                Dim newGroup As New CEntities.Group(txtNewGroupName.Text)

                TableReader.AddTable("Group", newGroup)

                LoadToGroupTab()

            Case "btnUpdateInsuranceEnter"
                ' TODO: Actually update the insurance

                ' Get insurance data
                Dim SelectedCarID As String = dgvCarsList.Rows(expandedRowIndex).Cells("CarID").Value
                Dim insuranceData As New CEntities.CarInsurance(SelectedCarID, txtUpdateInsuranceName.Text, dtpInsuranceExpiration.Value)

                ' To load back to carsList
                Dim CarGroupID As String = dgvCarsList.Rows(expandedRowIndex).Cells("CarGroupID").Value

                ' Check if insurance for the selected car exists
                Dim insuranceCheck As DataTable = TableReader.GetSpecificTables("CarInsurance", SelectedCarID)


                ' If it doesn't exist, add it

                If insuranceCheck.Rows.Count = 0 Then
                    ' Add new insurance
                    If TableReader.AddTable("CarInsurance", insuranceData) Then
                        tab = tpCarsList
                        LoadToCarTable(CarGroupID)
                    Else
                        tab = tpUpdateInsurance
                    End If

                Else
                    ' Update existing insurance
                    If TableReader.UpdateTable("CarInsurance", insuranceCheck.Rows(0)("CarInsuranceID"), insuranceData) Then
                        tab = tpCarsList
                        LoadToCarTable(CarGroupID)
                    Else
                        tab = tpUpdateInsurance
                    End If

                End If


            Case "btnAddMemberEnter"
                ' TODO: Check if that member exists
                Dim NewMember As New CEntities.GroupMember(currentGroup, txtMemberEmail.Text, cbIsAdmin.Checked)

                If TableReader.AddTable("GroupMember", NewMember) Then
                    ' Set tab to Cars List
                    tab = tpCarsList
                Else
                    tab = tpAddMember
                End If

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

        ' Get the ID of selected cell
        Dim SelectedID As String = dgvGroupsList.Rows(e.RowIndex).Cells("ID").Value.ToString()

        ' Check if the clicked cell isn't empty
        If String.IsNullOrEmpty(SelectedID) Then
            Return
        End If

        ' Change tab to Cars list
        tcTabs.SelectedTab = tpCarsList

        LoadToCarTable(SelectedID)

        ' TODO: Check if user is an admin in this group
        If True Then
            ADMIN = True
            btnAddCar.Visible = ADMIN
            btnAddMember.Visible = ADMIN
        End If

        Dim data As New DataTable()
        Dim message As String = "Expiring insurances:" & Environment.NewLine
        Dim messageLen As Integer = message.Length

        ' Go through the rows in the DGV
        For Each row In dgvCarsList.Rows
            If Not row.IsNewRow Then
                data = TableReader.GetSpecificTables("CarInsurance", row.Cells("CarID").Value.ToString())

                If data.Rows.Count > 0 Then
                    Dim endDate As DateTime = data.Rows(0)("Insurance End Date")

                    ' Compare endate to 2 weeks from today
                    If endDate <= DateAdd(DateInterval.Day, 14, DateAndTime.Today) Then
                        ' Add Car to message
                        message = message & row.Cells("Registration Plate").Value.ToString() & " - " & row.Cells("Car Model").Value.ToString() & Environment.NewLine
                    End If
                End If
            End If
        Next

        ' Inform the admin of the expirations
        If message.Length > messageLen Then
            MessageBox.Show(message)
        End If

        currentGroup = SelectedID
    End Sub

    ' Description: Loads the group list into the DataGridView
    ' Used when: 'tab = tpGroups' is called
    Private Sub LoadToGroupTab()

        ' Groups list 
        dgvGroupsList.DataSource = TableReader.GetGroupTable()

        dgvGroupsList.Columns(0).Visible = False
        dgvGroupsList.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


        ' CarLog list
        dgvUserHistoryList.DataSource = TableReader.GetLogsByUserId()

        dgvUserHistoryList.Columns(0).Visible = False
        dgvUserHistoryList.Columns(1).Visible = False
        dgvUserHistoryList.Columns(2).Visible = False
        dgvUserHistoryList.Columns(8).Visible = False

    End Sub

    Private Sub LoadToCarTable(SelectedID As String)
        EmptyCarTable()
        dgvCarsList.ClearSelection()
        ' Car list
        dgvCarsList.DataSource = TableReader.GetSpecificTables("Car", SelectedID)
        dgvCarsList.Columns(0).Visible = False
        dgvCarsList.Columns(1).Visible = False

        ' Delete button to car list

        Dim carDeleteButton As New DataGridViewButtonColumn()
        carDeleteButton.Name = "DeleteButton"
        carDeleteButton.Text = "Delete"
        carDeleteButton.HeaderText = ""
        carDeleteButton.UseColumnTextForButtonValue = True
        dgvCarsList.Columns.Add(carDeleteButton)

        ' Automatically resize to headers to fit all text
        dgvCarsList.AutoResizeColumnHeadersHeight()
    End Sub

    Private Sub EmptyCarTable()
        dgvCarsList.DataSource = Nothing
        dgvCarsList.Columns.Clear()
        dgvCarsList.Rows.Clear()
    End Sub

    Private Sub LoadToProblemTable(SelectedID As String)
        dgvProblemsList.DataSource = TableReader.GetSpecificTables("CarIssue", SelectedID)
        dgvProblemsList.Columns(0).Visible = False
        dgvProblemsList.Columns(1).Visible = False
    End Sub

    Private Sub LoadToLogTable(SelectedID As String)
        dgvLogsList.DataSource = TableReader.GetSpecificTables("CarLog", SelectedID)
        dgvLogsList.Columns("CarLogID").Visible = False
        dgvLogsList.Columns("CarLogCarID").Visible = False
        dgvLogsList.Columns("CarLogUserEmail").Visible = False
        dgvLogsList.Columns("Start Date").Visible = False
        dgvLogsList.Columns("End Date").Visible = False
        dgvLogsList.Columns("Distance").Visible = False
        dgvLogsList.Columns("Comment").Visible = False
    End Sub

    Private Sub btnGetDistance_Click(sender As Object, e As EventArgs) Handles btnGetDistance.Click
        lblStartData.Text = dtpStatsTimeStart.Value
        lblEndData.Text = dtpStatsTimeEnd.Value
        lblCommentData.Text = "___"

        Dim totalDistance As Double = 0

        For Each log In dgvLogsList.Rows
            If CDate(log.Cells("Start Date").Value) >= CDate(dtpStatsTimeStart.Value) And CDate(log.Cells("End Date").Value) <= CDate(dtpStatsTimeEnd.Value) Then
                totalDistance = totalDistance + CType(log.Cells("Distance").Value, Integer)
            End If
        Next

        lblDistanceData.Text = totalDistance.ToString() & " km"
    End Sub

    Private Sub dgvLogsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogsList.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        lblStartData.Text = dgvLogsList.Rows(e.RowIndex).Cells("Start Date").Value

        lblEndData.Text = dgvLogsList.Rows(e.RowIndex).Cells("End Date").Value

        lblDistanceData.Text = dgvLogsList.Rows(e.RowIndex).Cells("Distance").Value & " km"

        lblCommentData.Text = dgvLogsList.Rows(e.RowIndex).Cells("Comment").Value
    End Sub

    ' Description:  Function for registering a new user and to check if all inputs are valid
    ' Parameters:   Email - email of the user, Password - password of the user, ConfirmPassword - confirmation of the password
    ' Return:       Boolean value of whether the registration was successful or not
    Private Function AccountRegistration(Email As String, Password As String, ConfirmPassword As String)

        ' Check if passwords match
        If Password = ConfirmPassword Then
            ' check is password is atleast 6 long, 1 upper and 1 special character and 1 number
        Else
            MessageBox.Show("Passwords do not match.")
            Return False
        End If

        ' Check if email is correct
        If Not Regex.IsMatch(Email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Please enter a valid email address.")
            Return False
        End If

        ' TODO: Check if a user with the given email already exists in the database

        ' If everything is correct, register account and return true
        If (TableReader.LoginRegister(Email, Password, "Register")) Then
            MessageBox.Show("Account registered successfully.")

            Return True
        Else
            MessageBox.Show("Account registration failed.")
            Return False
        End If
    End Function

    Private Sub cbCarsSort_TabIndexChanged(sender As Object, e As EventArgs) _
        Handles cbCarsSort.SelectionChangeCommitted
        If cbCarsSort.SelectedIndex = -1 Then
            MsgBox("Fail")
        End If

        ' Sort the DataGridView based on the selected sorting option index 4-7
        Select Case cbCarsSort.SelectedItem.ToString()
            ''commented out becaus sorting is already implemented from datagridviewdda
            Case "Distance: Ascending"
                dgvCarsList.Sort(dgvCarsList.Columns("Mileage"), ListSortDirection.Ascending)

            Case "Distance: Descending"
                dgvCarsList.Sort(dgvCarsList.Columns("Mileage"), ListSortDirection.Descending)

            Case "A -> Z"
                dgvCarsList.Sort(dgvCarsList.Columns("Car Model"), ListSortDirection.Descending)

            Case "Z -> A"
                dgvCarsList.Sort(dgvCarsList.Columns("Car Model"), ListSortDirection.Ascending)
            Case "Available"
                dgvCarsList.DataSource = FilterBooleanField("Available", dgvCarsList, True)
            Case "Unavailable"
                dgvCarsList.DataSource = FilterBooleanField("Available", dgvCarsList, False)
            Case "Archived"
                dgvCarsList.DataSource = FilterBooleanField("Archived", dgvCarsList, True)
            Case "Unarchived"
                dgvCarsList.DataSource = FilterBooleanField("Archived", dgvCarsList, False)
            Case "Critical"
                dgvCarsList.DataSource = FilterBooleanField("Critical State", dgvCarsList, True)
            Case "Non-critical"
                dgvCarsList.DataSource = FilterBooleanField("Critical State", dgvCarsList, False)
            Case Else
                MsgBox("Sorting failed")
                Return
        End Select
    End Sub
    Private Function FilterBooleanField(ByVal fieldName As String, ByVal table As DataGridView, ByRef ascending As Boolean) As DataTable
        If table.DataSource Is Nothing OrElse Not TypeOf table.DataSource Is DataTable Then
            MessageBox.Show("Invalid DataSource.")
            Return Nothing
        End If

        Dim originalTable As DataTable = CType(table.DataSource, DataTable)
        Dim temp1 As DataTable = originalTable.Clone()
        Dim temp2 As DataTable = originalTable.Clone()

        ' Iterate through rows and separate them based on the field value
        For Each row As DataGridViewRow In table.Rows
            If Not row.IsNewRow Then
                Dim CellValue As Object = row.Cells(fieldName).Value
                If CellValue.Equals(True) Then
                    temp1.ImportRow(CType(row.DataBoundItem, DataRowView).Row)
                ElseIf CellValue.Equals(False) Then
                    temp2.ImportRow(CType(row.DataBoundItem, DataRowView).Row)
                End If
            End If
        Next

        ' Combine temp1 and temp2 based on the ascending flag
        If ascending Then
            temp1.Merge(temp2)
            Return temp1
        Else
            temp2.Merge(temp1)
            Return temp2
        End If
    End Function

    Private Sub cbRegisterShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbRegisterShowPassword.CheckedChanged
        If cbRegisterShowPassword.Checked Then
            tbRegisterPassword.UseSystemPasswordChar = False
            tbRegisterPasswordConfirm.UseSystemPasswordChar = False
        Else
            tbRegisterPassword.UseSystemPasswordChar = True
            tbRegisterPasswordConfirm.UseSystemPasswordChar = True
        End If
    End Sub
End Class
