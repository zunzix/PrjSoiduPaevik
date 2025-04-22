Imports System.ComponentModel
Imports System.Net
Imports System.Security.Policy

Public Class formTableViewer
    Const DEBUG = True
    Private expandedRowIndex As Integer = -1

    Private Sub formTableViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Hides the tabs while the program is running so that the user can't change them manually
        tcTabs.ItemSize = New Size(0, 1)
        tcTabs.SizeMode = TabSizeMode.Fixed

        ' Initialize the form on the "Cars list" tab until log in and/or group view has been built
        tcTabs.SelectedTab = tpLogin

        ' TODO: Bringing in lists and view them on DataGridView

        ' Add fields for the car model, whether it needs maintenence and whether it's available and the delete button
        Dim carModel As New DataGridViewTextBoxColumn()
        carModel.Name = "CarModel"
        carModel.HeaderText = "Car Model"
        carModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Dim maintenence As New DataGridViewCheckBoxColumn()
        maintenence.Name = "Maintenence"
        maintenence.HeaderText = "Maintenence"
        maintenence.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

        Dim availability As New DataGridViewCheckBoxColumn()
        availability.Name = "isAvailable"
        availability.HeaderText = "Availability"
        availability.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

        Dim subtractButton As New DataGridViewButtonColumn()
        subtractButton.Name = "DeleteButton"
        subtractButton.HeaderText = ""
        subtractButton.Text = "Delete"
        subtractButton.UseColumnTextForButtonValue = True
        subtractButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        subtractButton.Width = 50

        ' Add all of them to the DGV
        dgvCarsList.Columns.Add(carModel)
        dgvCarsList.Columns.Add(maintenence)
        dgvCarsList.Columns.Add(availability)
        dgvCarsList.Columns.Add(subtractButton)

        dgvCarsList.Rows.Add()

        ' Add fields to the problems list
        ' Problem description
        Dim description As New DataGridViewTextBoxColumn()
        description.Name = "description"
        description.HeaderText = "Problem description"
        description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' Whether it's critical or not
        Dim critical As New DataGridViewCheckBoxColumn()
        critical.Name = "critical"
        critical.HeaderText = "Critical?"
        critical.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

        ' Whether it's resolved or not
        Dim resolved As New DataGridViewCheckBoxColumn()
        resolved.Name = "resolved"
        resolved.HeaderText = "Resolved?"
        resolved.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

        ' Add all of them to the DGV
        dgvProblemsList.Columns.Add(description)
        dgvProblemsList.Columns.Add(critical)
        dgvProblemsList.Columns.Add(resolved)

        ' Set the DataGridView to ReadOnly so that you can't change the fields right on the table
        dgvCarsList.ReadOnly = True
        dgvProblemsList.ReadOnly = True

        ' Remove the annoying row headers and the beginning of the list
        dgvCarsList.RowHeadersVisible = False
        dgvProblemsList.RowHeadersVisible = False

        ' Change the select color from an eye piercing blue to a more subtle gray
        dgvCarsList.DefaultCellStyle.SelectionBackColor = Color.LightGray
        dgvProblemsList.DefaultCellStyle.SelectionBackColor = Color.LightGray

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
            expandedRowIndex = -1
            Return
        End If

        ' Get the area of the row that was clicked
        Dim rowRect As Rectangle = dgvCarsList.GetRowDisplayRectangle(e.RowIndex, True)

        ' Style it so that it looks like a "drop down panel"
        pnlDetails.Top = dgvCarsList.Top + rowRect.Bottom
        pnlDetails.Left = dgvCarsList.Left + 2
        pnlDetails.Width = dgvCarsList.Width - 4
        pnlDetails.Visible = True

        ' Assign detailed values to the data fields
        ' TODO: Make it so that you get the data from the database
        lblFuelData.Text = "-1"
        ' lblAvailabilityData.Text = "-1"
        lblMilageData.Text = "-1"

        ' Find whether the selected car has any ongoing insurances
        ' TODO: Make it possible to search through the database for insurance

        ' Check if the insurance item exists
        lblInsuranceData.Text = "Expired!"

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
        Handles btnCarBack.Click, btnLoginLogin.Click, btnAddCarCancel.Click, btnAddCar.Click

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
            Case "btnCarBack"
                ' Set tab to Group
                tab = tpGroups

            Case "btnProblemBack"
                ' Set tab to Car Details
                tab = tpCarsList

            Case "btnLoginLogin"
                ' Set tab to Groups
                ' TODO: Add tranfer from Groups to Cars page
                tab = tpCarsList                 ' Currently goes straight to the Cars tab

            Case "btnAddCar"
                ' Set tab to Add Car
                tab = tpAddCar

            Case "btnAddCarCancel"
                ' Set tab to Cars List
                tab = tpCarsList

                ' Clear fields
                txtName.Clear()
                txtMileage.Clear()
                txtAvgFuel.Clear()

            Case "btnAddCarEnter"
                ' Set tab to Cars List
                tab = tpCarsList

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

End Class
