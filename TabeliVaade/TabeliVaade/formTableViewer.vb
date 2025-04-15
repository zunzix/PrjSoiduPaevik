Imports System.ComponentModel
Imports System.Net
Imports System.Security.Policy

Public Class formTableViewer
    Const DEBUG = True

    ' Hardcoded list for the time being
    Public carsList As New BindingList(Of CCar)()
    Public problemsList As New BindingList(Of CProblem)()
    Public insuranceList As New BindingList(Of CInsurance)()


    Private Sub formTableViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carsList.Add(New CCar(1, "Peugeot 206", 178989, 11.2, True, False, False))
        carsList.Add(New CCar(2, "Honda Civic", 15003.2, 6.8, False, False, False))
        carsList.Add(New CCar(3, "Ford Focus", 9999, 7.5, True, False, False))

        problemsList.Add(New CProblem(0, "Motor vibrates", False))
        problemsList.Add(New CProblem(1, "Radio didn't work", False))
        problemsList.Add(New CProblem(2, "It's a Ford car", True))

        insuranceList.Add(New CInsurance(0, "if", DateAdd("Year", 1, Today)))
        insuranceList.Add(New CInsurance(1, "Swedbank", DateAdd("Week", 1, Today)))
        insuranceList.Add(New CInsurance(2, "Salva", DateAdd("Week", 2.5, Today)))

        ' Hides the tabs while the program is running so that the user can't change them manually
        tcTabs.ItemSize = New Size(0, 1)
        tcTabs.SizeMode = TabSizeMode.Fixed

        ' Initialize the form on the "Cars list" tab until log in and/or group view has been built
        tcTabs.SelectedTab = tpCarsList

        ' >>> To Add: Bringing in lists and view them on DataGridView <<<

        ' Add a section to show whether the car has a problem or not
        Dim problemIndicator As New DataGridViewTextBoxColumn()
        problemIndicator.Name = "Problems"
        problemIndicator.HeaderText = "Problems"
        dgvCarsList.Columns.Add(problemIndicator)

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

    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        ' To Add: Clicking it adds a car to the cars database and updates the DataGridView
        tcTabs.SelectedTab = tpAddCar


    End Sub

    Private Function ValidateInput() As Boolean
        ' Validate the input fields
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            txtName.Text = "Please enter car name"
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtMileage.Text) OrElse Not IsNumeric(txtMileage.Text) Then
            txtMileage.Text = "Pelase enter valid mileage"
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtAvgFuel.Text) _
            OrElse Not IsNumeric(txtAvgFuel.Text) Then
            txtAvgFuel.Text = "Please enter valid average fuel consumption"
            Return False
        End If
        'add check, if car is already in list

        If DEBUG Then
            MessageBox.Show($"Name: {txtName.Text}, Mileage: {txtMileage.Text}
                                , Avg Fuel Consumption: {txtAvgFuel.Text}, 
                                Ready: {cboxReady.Checked}, Archived: {cboxArchive.Checked}")
        End If

        Return True
    End Function

    Private Sub txtAvgFuelCon_Click(sender As Object, e As EventArgs) _
        Handles txtAvgFuel.Click
        txtAvgFuel.Clear()
        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
    Private Sub txtMileage_Click(sender As Object, e As EventArgs) _
        Handles txtMileage.Click
        txtMileage.Clear()
        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
    Private Sub txtName_Click(sender As Object, e As EventArgs) _
        Handles txtName.Click
        txtName.Clear()
        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Private Sub btnCarBack_Click(sender As Object, e As EventArgs) Handles btnCarBack.Click
        ' Return to Group tab when the button is pressed
        tcTabs.SelectedTab = tpGroups
    End Sub

    Private Sub btnProblemBack_Click(sender As Object, e As EventArgs) Handles btnProblemBack.Click
        ' Return to Car Detailed View when the button is pressed
        tcTabs.SelectedTab = tpCarDetails
    End Sub

    Private Sub dgvCarsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarsList.CellContentClick
        ' Check if the clicked cell is in the header or not
        If e.RowIndex < 0 Then
            Return
        End If

        ' To Add: Once removing functionality for the Cars class has been made. Fill it out!
    End Sub

    Private Sub dgvCarsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarsList.CellClick
        ' Check if the clicked cell is in the header or not
        If e.RowIndex < 0 Then
            Return
        End If

        ' Check which field of the table was clicked
        If e.ColumnIndex = dgvCarsList.Columns("Problems").Index Then ' Problems field
            ' To Add: Add problems data of specified car to dgvProblemsList for viewing

            ' Switch tabs to the problems view
            tcTabs.SelectedTab = tpProblems
        End If
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
        done = True '' To Add: Add the car to the database

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
        tcTabs.SelectedTab = tpCarsList
    End Sub

    Private Sub btnAddCarCancel_Click(sender As Object, e As EventArgs) Handles btnAddCarCancel.Click

        ' Clear input fields
        txtName.Clear()
        txtMileage.Clear()
        txtAvgFuel.Clear()
        ' Force garbage collection
        GC.Collect()
        GC.WaitForPendingFinalizers()

        tcTabs.SelectedTab = tpCarsList
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
End Class
