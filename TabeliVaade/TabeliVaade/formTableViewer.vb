Imports System.ComponentModel
Imports System.Net
Imports System.Security.Policy
Imports CTableReader


Public Class formTableViewer
    Const DEBUG = True
    Private expandedRowIndex As Integer = -1
    Private TableReader As New CTableReader.CTableReader()


    Private Sub formTableViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim data As New DataTable()

        ' == DELETE LATER ==
        'data.Columns.Add("CarID", GetType(Integer))
        data.Columns.Add("GroupID", GetType(Integer))
        data.Columns.Add("Name", GetType(String))
        data.Columns.Add("Mileage", GetType(Double))
        data.Columns.Add("FuelConsumption", GetType(Double))
        data.Columns.Add("Available", GetType(Boolean))
        data.Columns.Add("Archived", GetType(Boolean))
        data.Columns.Add("Critical", GetType(Boolean))

        data.Rows.Add(0, "Porsche 911", 10000, 5.5, True, False, False)
        data.Rows.Add(0, "Lamborghini Aventador", 876, 9.8, True, True, False)
        data.Rows.Add(0, "Volkswagen Polo", 2390, 10, True, False, True)
        data.Rows.Add(0, "Mercedes-Benz EQB SUV", 11980, 12.4, False, True, True)
        data.Rows.Add(0, "Audi A-6", 0, 5, False, False, True)
        data.Rows.Add(0, "BMW M3", 0, 8.5, True, False, False)
        ' == DELETE LATER ==

        ' Add car data to list
        dgvCarsList.DataSource = data

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


        dgvCarsList.Rows.Add()
        dgvCarsList.Rows.Add()
        dgvCarsList.Rows.Add()

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


    ' Description:  Clears the fields when adding a new car
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
            dgvCarsList.Rows.Remove(dgvCarsList.SelectedRows(e.RowIndex))
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

        ' Style the logs panel the same way as details panel, but not visible (yet)
        pnlLogs.Top = dgvCarsList.Top + rowRect.Bottom

        ' Assign detailed values to the data fields
        ' TODO: Make it so that you get the data from the database
        'lblFuelData.Text = "-1"
        'lblMilageData.Text = "-1"

        ' Find whether the selected car has any ongoing insurances
        ' TODO: Make it possible to search through the database for insurance

        ' Check if the insurance item exists
        lblInsuranceData.Text = DateAdd(DateInterval.Day, 10, Date.Today).ToString()

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
        btnEnterNewGroup.Click

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
                ' TODO: Add tranfer from Groups to Cars page
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
            Case "btnProblems"
                pnlDetails.Visible = True
                pnlLogs.Visible = False
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
End Class
