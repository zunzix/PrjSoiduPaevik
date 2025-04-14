Public Class formTableViewer
    Const DEBUG = True

    Private Sub formTableViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hides the tabs while the program is running so that the user can't change them manually
        tcTabs.ItemSize = New Size(0, 1)
        tcTabs.SizeMode = TabSizeMode.Fixed

        ' Initialize the form on the "Cars list" tab until log in and/or group view has been built
        tcTabs.SelectedTab = tpCarsList

        ' To Add: Bringing in lists and viewing them on DataGridView
    End Sub

    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        ' To Add: Clicking it adds a car to the cars database and updates the DataGridView
    End Sub

    Private Sub btnCarBack_Click(sender As Object, e As EventArgs) Handles btnCarBack.Click
        ' To Add: Return to Group tab when the button is pressed
    End Sub

    Private Sub btnProblemBack_Click(sender As Object, e As EventArgs) Handles btnProblemBack.Click
        ' To Add: Return to Car Detailed View when the button is pressed
    End Sub
End Class
