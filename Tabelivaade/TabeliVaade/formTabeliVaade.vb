Imports System.ComponentModel
Imports System.Reflection
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Public Class formTabeliVaade
    Const DEBUG = True

    Private Sub formTabeliVaade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide the "tabs" so that the user can't manually switch between them
        tcTabs.Appearance = TabAppearance.FlatButtons
        tcTabs.ItemSize = New Size(0, 1)
        tcTabs.SizeMode = TabSizeMode.Fixed

        ' Bring in lists
        dgvTabeliVaade.DataSource = CTabelReader.GetInstance().autodList
        Dim probleemid = CTabelReader.GetInstance().probleemidList
        Dim insurance = CTabelReader.GetInstance().kindlustusList

        ' Add a section that shows whether a car has a problem or not
        Dim problemIndicatorColumn As New DataGridViewTextBoxColumn()
        problemIndicatorColumn.Name = "Problems"
        problemIndicatorColumn.HeaderText = "Problems"
        dgvTabeliVaade.Columns.Add(problemIndicatorColumn)

        ' Add a section that shows insurance status
        Dim insuranceColumn As New DataGridViewTextBoxColumn()
        insuranceColumn.Name = "Insurance"
        insuranceColumn.HeaderText = "Insurance"
        dgvTabeliVaade.Columns.Add(insuranceColumn)

        ' Goes through each row of data in dgvTabeliVaate to look for which cars have problems
        For Each row As DataGridViewRow In dgvTabeliVaade.Rows
            If Not row.IsNewRow Then

                ' Gets a list of problems that the car with a certain ID has and keeps it as a list (in case there are more than 1)
                Dim foundProblem As List(Of CAutoProbleem) = probleemid.Where(Function(c) c.CarID = row.Cells("ID").Value).ToList()

                ' In case there are problems, we go through and mark out whether they're critical or not
                If foundProblem.Any() Then
                    For Each prob In foundProblem
                        If Not prob.IsResolved Then
                            If prob.IsCritical Then
                                'Red for critical problems
                                row.Cells("Problems").Style.BackColor = Color.Red

                                ' If one critical problem has already been found, no need to look for any more
                                Exit For
                            Else
                                ' Yellow for non critical problems
                                row.Cells("Problems").Style.BackColor = Color.Yellow
                            End If
                        End If
                    Next
                End If
            End If
        Next

        Dim reader As ITabelReader = CTabelReader.GetInstance()
        dgvTabeliVaade.DataSource = New BindingList(Of CAuto)(reader.GetTabel())
        ' Add remove ( - ) button after every column
        Dim subtractButtonColumn As New DataGridViewButtonColumn()
        subtractButtonColumn.Name = "DeleteButton"
        subtractButtonColumn.HeaderText = ""
        subtractButtonColumn.Text = "-"
        subtractButtonColumn.UseColumnTextForButtonValue = True
        dgvTabeliVaade.Columns.Add(subtractButtonColumn)

        ' Set the AutoSizeColumnsMode to AllCells
        ''Natukene kole sellega aga ennem ei mahtunud - veerg ära
        dgvTabeliVaade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    'Description: React to the changes in the DataGridView
    'Debug return: Operation successful or Operation failed
    Private Sub dgvTabeliVaade_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvTabeliVaade.CellValueChanged
        ' Check if the clicked cell is in the button column not the header
        If e.RowIndex < 0 Then
            Return
        End If
        'Define the reference to the ICarAddSub interface
        Dim Change As ICarAddSub
        Change = New CCarAddSub
        ' Define a variable to store the result of the operation
        Dim done As Boolean
        ' Get the ID of the car that was klicked
        Dim carID = CType(dgvTabeliVaade.Rows(e.RowIndex).DataBoundItem, CAuto).ID

        ' Check if the changed cell is in the boolean column (IsArchived column)
        If e.ColumnIndex = dgvTabeliVaade.Columns("IsArchived").Index Then
            If dgvTabeliVaade.Rows(e.RowIndex).Cells("IsArchived").Value = True Then
                done = Change.ArchiveData(carID)
            Else
                ''Siin küsida ka põhjus, miks unarchive ja lisada see andmebaasi
                done = Change.UnarchiveData(carID)
            End If
            If done Then
                If DEBUG Then
                    MessageBox.Show("Operation successful")
                End If
            Else
                MessageBox.Show("Operation failed")
            End If
        End If
        ''Siia veel teised veerud
    End Sub

    ''gpt poolt pakutud lahendus
    'Private Sub dgvTabeliVaade_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabeliVaade.CellValueChanged
    '    ' Check if the changed cell is in the boolean column (e.g., IsArchived column)
    '    If e.ColumnIndex = dgvTabeliVaade.Columns("IsArchived").Index Then
    '        ' Get the instance of CTabelReader
    '        Dim tabelReaderInstance = CTabelReader.GetInstance()
    '        ' Get the updated car from the DataGridView
    '        Dim updatedCar As CAuto = CType(dgvTabeliVaade.Rows(e.RowIndex).DataBoundItem, CAuto)
    '        ' Find the car in the autodList and update its IsArchived property
    '        Dim carToUpdate = tabelReaderInstance.autodList.FirstOrDefault(Function(car) car.ID = updatedCar.ID)
    '        If carToUpdate IsNot Nothing Then
    '            carToUpdate.IsArchived = updatedCar.IsArchived
    '        End If
    '    End If
    'End Sub

    'Description: Commits uncommited changes in the DataGridView
    'Debug return: Operation successful or Operation failed
    ''(võibolla peaks määrama selle ainult boolean veergudele, ei tea veel)
    Private Sub dgvTabeliVaade_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvTabeliVaade.CurrentCellDirtyStateChanged
        If dgvTabeliVaade.IsCurrentCellDirty Then
            dgvTabeliVaade.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    'Description: Checks if the clicked cell is in the button column,
    '             If click is in the - column, then deletes the car from the list.
    '             Uses garbage collection to free up memory.
    ''saab lisada veerge, kus on nupp, et saaks ka teisi asju teha
    'Debug return: Operation successful or Operation failed
    Private Sub dgvTabeliVaade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvTabeliVaade.CellContentClick
        ' Check if the clicked cell is in the button column not the header
        If e.RowIndex < 0 Then
            Return
        End If
        ' Get the ID of the car that was clicked
        Dim carID = CType(dgvTabeliVaade.Rows(e.RowIndex).DataBoundItem, CAuto).ID
        'Define the reference to the ICarAddSub interface
        Dim Change As ICarAddSub
        Change = New CCarAddSub
        Dim done As Boolean
        If e.ColumnIndex = dgvTabeliVaade.Columns("DeleteButton").Index Then
            done = Change.DeleteCar(carID)
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
        End If
    End Sub

    'Description:   Switches view of the form to show the problems of the car that was clicked
    'Returns:       None
    Private Sub dgvTabeliVaade_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvTabeliVaade.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        ' Bring in new instance of the list of problems
        Dim probleemid = CTabelReader.GetInstance().probleemidList

        ' Check to see if the problems field was clicked
        If e.ColumnIndex = dgvTabeliVaade.Columns("Problems").Index Then
            ' Find a list of problems of the specified car
            dgvProbleemid.DataSource = probleemid.Where(Function(c) c.CarID = dgvTabeliVaade.Rows(e.RowIndex).Cells("ID").Value).ToList()

            ' Switch tabs to the problems view
            tcTabs.SelectedTab = tbProbleemid
        End If
    End Sub

    'Description: Add new car to the list
    '             Uses garbage collection to free up memory.
    'Returns: MessageBox if the operation failed
    'Debug returns: MessageBox if the operation was successful
    Private Sub btnAdd_MouseClick(sender As Object, e As MouseEventArgs) _
        Handles btnAdd.MouseClick
        ''gpt poolt tehtud popup, parem teha ise uus form mis küsib andmeid
        '' Create a new form to ask for car input data
        'Dim inputForm As New Form With {
        '    .Text = "Car Input",
        '    .Size = New Size(300, 300)
        '}

        '' Create labels and textboxes for each input field
        'Dim lblDescription As New Label With {.Text = "Description", .Location = New Point(10, 10)}
        'Dim txtDescription As New TextBox With {.Location = New Point(100, 10), .Width = 150}
        'Dim lblID As New Label With {.Text = "ID", .Location = New Point(10, 40)}
        'Dim txtID As New TextBox With {.Location = New Point(100, 40), .Width = 150}
        'Dim lblPrice As New Label With {.Text = "Price", .Location = New Point(10, 70)}
        'Dim txtPrice As New TextBox With {.Location = New Point(100, 70), .Width = 150}
        'Dim lblQuantity As New Label With {.Text = "Quantity", .Location = New Point(10, 100)}
        'Dim txtQuantity As New TextBox With {.Location = New Point(100, 100), .Width = 150}
        'Dim lblIsNew As New Label With {.Text = "Is New", .Location = New Point(10, 130)}
        'Dim txtIsNew As New TextBox With {.Location = New Point(100, 130), .Width = 150}
        'Dim lblIsArchived As New Label With {.Text = "Is Archived", .Location = New Point(10, 160)}
        'Dim txtIsArchived As New TextBox With {.Location = New Point(100, 160), .Width = 150}

        '' Create OK and Cancel buttons
        'Dim btnOK As New Button With {.Text = "OK", .Location = New Point(50, 200)}
        'Dim btnCancel As New Button With {.Text = "Cancel", .Location = New Point(150, 200)}

        '' Add controls to the form
        'inputForm.Controls.Add(lblDescription)
        'inputForm.Controls.Add(txtDescription)
        'inputForm.Controls.Add(lblID)
        'inputForm.Controls.Add(txtID)
        'inputForm.Controls.Add(lblPrice)
        'inputForm.Controls.Add(txtPrice)
        'inputForm.Controls.Add(lblQuantity)
        'inputForm.Controls.Add(txtQuantity)
        'inputForm.Controls.Add(lblIsNew)
        'inputForm.Controls.Add(txtIsNew)
        'inputForm.Controls.Add(lblIsArchived)
        'inputForm.Controls.Add(txtIsArchived)
        'inputForm.Controls.Add(btnOK)
        'inputForm.Controls.Add(btnCancel)

        '' Show the form as a dialog
        'Dim result As DialogResult = inputForm.ShowDialog()

        '' Check if the user clicked OK
        'If result = DialogResult.OK Then
        '    ' Get the input values
        '    Dim carDescription As String = txtDescription.Text
        '    Dim carID As String = txtID.Text
        '    Dim carPrice As String = txtPrice.Text
        '    Dim carQuantity As String = txtQuantity.Text
        '    Dim carIsNew As String = txtIsNew.Text
        '    Dim carIsArchived As String = txtIsArchived.Text

        '    ' Check if the user provided all necessary inputs
        '    If String.IsNullOrWhiteSpace(carDescription) OrElse
        '       String.IsNullOrWhiteSpace(carID) OrElse
        '       String.IsNullOrWhiteSpace(carPrice) OrElse
        '       String.IsNullOrWhiteSpace(carQuantity) OrElse
        '       String.IsNullOrWhiteSpace(carIsNew) OrElse
        '       String.IsNullOrWhiteSpace(carIsArchived) Then
        '        MessageBox.Show("All fields must be filled.")
        '        Return
        '    End If

        '    ' Validate numeric inputs
        '    Dim carIDValue As Integer
        '    Dim carPriceValue As Decimal
        '    Dim carQuantityValue As Integer
        '    Dim carIsNewValue As Boolean
        '    Dim carIsArchivedValue As Boolean

        '    If Not Integer.TryParse(carID, carIDValue) Then
        '        MessageBox.Show("Car ID must be a valid integer.")
        '        Return
        '    End If

        '    If Not Decimal.TryParse(carPrice, carPriceValue) Then
        '        MessageBox.Show("Car price must be a valid decimal number.")
        '        Return
        '    End If

        '    If Not Integer.TryParse(carQuantity, carQuantityValue) Then
        '        MessageBox.Show("Car quantity must be a valid integer.")
        '        Return
        '    End If

        '    If Not Boolean.TryParse(carIsNew, carIsNewValue) Then
        '        MessageBox.Show("Car Is New must be a valid boolean (True/False).")
        '        Return
        '    End If

        '    If Not Boolean.TryParse(carIsArchived, carIsArchivedValue) Then
        '        MessageBox.Show("Car Is Archived must be a valid boolean (True/False).")
        '        Return
        '    End If

        ' Define the reference to the ICarAddSub interface
        Dim Change As ICarAddSub
        Change = New CCarAddSub
        Dim done As Boolean
        done = Change.AddCar(4, "1955 Mercedes-Benz 300 SLR Uhlenhaut Coupe", 80085, 35, False, True)
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
        'End If
    End Sub

    ' Description: Open detailed car view form when double-clicking on a car in the DataGridView
    ' Parameters: sender as Object, e as DataGridViewCellEventArgs
    ' Return: none
    Private Sub dgvTabeliVaade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabeliVaade.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim valitudAuto As CAuto = CType(dgvTabeliVaade.Rows(e.RowIndex).DataBoundItem, CAuto)
            Dim detailVorm As New formDetailedCarView(valitudAuto)
            detailVorm.ShowDialog()
        End If
    End Sub
    'Description:  Allows the view to go back to the cars tab
    'Returns:      None
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        tcTabs.SelectedTab = tpAutod
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
End Class