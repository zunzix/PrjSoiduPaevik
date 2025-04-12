Public Class formDetailedCarView
    Private auto As CAuto

    Public Sub New(selectedAuto As CAuto)
        InitializeComponent()
        auto = selectedAuto
        LoadCarInfo()
    End Sub

    'Description: Load selected car info from TabeliVaade form
    'Parameters: none
    'Return: none
    Private Sub LoadCarInfo()

        lblCarName.Text = auto.Name
        lblFuelConsumptionText.Text = auto.AvgFuelCon.ToString() & " l/100km"
        lblAvailabilityText.Text = If(auto.IsAvailable, "Jah", "Ei")
        lblMileageText.Text = auto.Mileage.ToString() & " km"
        lblInsuranceText.Text = "Pole lisatud veel"
        lblTechnicalText.Text = "Pole lisatud veel"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class