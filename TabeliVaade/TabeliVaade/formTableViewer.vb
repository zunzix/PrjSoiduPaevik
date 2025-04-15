Public Class formTableViewer
    Const DEBUG = True

    Private Sub formTableViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class
