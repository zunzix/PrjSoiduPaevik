Imports System.ComponentModel
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Public Class formTabeliVaade
    Const DEBUG = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvTabeliVaade.DataSource = CTabelReader.GetInstance().autodList

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
    ''(võibolla peaks määrama selle ainult boolean veergudele, ei tea veel)
    Private Sub dgvTabeliVaade_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvTabeliVaade.CurrentCellDirtyStateChanged
        If dgvTabeliVaade.IsCurrentCellDirty Then
            dgvTabeliVaade.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

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
End Class