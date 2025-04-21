Imports System.ComponentModel
Imports System.Net
Imports System.Security.Policy

Public Class formTableViewer
    Const DEBUG = True

    Private Sub formTableViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Hides the tabs while the program is running so that the user can't change them manually
        tcTabs.ItemSize = New Size(0, 1)
        tcTabs.SizeMode = TabSizeMode.Fixed

        ' Initialize the form on the "Cars list" tab until log in and/or group view has been built
        tcTabs.SelectedTab = tpLogin

        ' TODO: Bringing in lists and view them on DataGridView

        For Each row As DataGridViewRow In dgvCarsList.Rows
            If Not row.IsNewRow Then
                If row.Cells("IsInCriticalState").Value Then
                    row.Cells("IsInCriticalState").Style.BackColor = Color.Red
                End If
            End If
        Next

        ' Add a remove ( - ) button after every column
        Dim subtractButton As New DataGridViewButtonColumn()
        subtractButton.Name = "DeleteButton"
        subtractButton.HeaderText = ""
        subtractButton.Text = "-"
        subtractButton.UseColumnTextForButtonValue = True
        dgvCarsList.Columns.Add(subtractButton)

        ' Set the AutoSizeColumnsMode to AllCells
        dgvCarsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
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

    Private Sub dgvCarsList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarsList.CellDoubleClick
        ' Check if the clicked cell is in the header or not
        If e.RowIndex < 0 Then
            Return
        End If

        ' Assuming you want to get the value from a specific column (e.g., "AvgFuelConsumption") of the selected row
        lblFuelData.Text = carsList(e.RowIndex).AvgFuelConsumption.ToString()
        lblAvailabilityData.Text = carsList(e.RowIndex).IsAvailable.ToString()
        lblMilageData.Text = carsList(e.RowIndex).Mileage.ToString()
        ' Use LINQ to find the specific insurance item with the matching CarID
        Dim selectedCarID As Integer = CInt(dgvCarsList.Rows(e.RowIndex).Cells("ID").Value)
        Dim insurance As CInsurance = insuranceList.FirstOrDefault(Function(c) c.CarID = selectedCarID)

        ' Check if the insurance item exists
        If insurance IsNot Nothing Then
            lblInsuranceData.Text = insurance.EndDate.ToString()
        Else
            lblInsuranceData.Text = "No insurance found"
        End If

        tcTabs.SelectedTab = tpCarDetails
    End Sub

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
        Handles btnCarBack.Click, btnProblemBack.Click, btnCarDetailsBack.Click,
        btnShowProblems.Click, btnLoginLogin.Click, btnAddCarCancel.Click, btnAddCar.Click

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
                tab = tpCarDetails

            Case "btnCarDetailsBack"
                ' Set tab to Cars List
                tab = tpCarsList

            Case "btnShowProblems"
                ' Set tab to Problems
                tab = tpProblems

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
                ' Force garbage collection
                GC.Collect()
                GC.WaitForPendingFinalizers()

            Case "btnAddCarEnter"
                ' Set tab to Cars List
                tab = tpCarsList

            Case Else
                ' In case something goes wrong, it'll just stay on the same page
                tab = tcTabs.SelectedTab
        End Select

        ' Change the tab
        tcTabs.SelectedTab = tab
    End Sub
End Class
