Imports System.ComponentModel

Public Class formTabeliVaade
    Private autodList As New BindingList(Of CAuto)()
    Private probleemidList As New BindingList(Of CAutoProbleem)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Manuaalne autode lisamine, asendme hiljem JSON faili lugemisega
        autodList.Add(New CAuto(1, "Peugot 206", 178989, 11.2, True, False))
        autodList.Add(New CAuto(1, "Honda Civic", 15003.2, 6.8, False, False))
        autodList.Add(New CAuto(1, "Ford Focus", 9999, 7.5, True, False))

        probleemidList.Add(New CAutoProbleem(0, "Mootor väriseb", True, False))
        probleemidList.Add(New CAutoProbleem(2, "Mootor puudub", False, True))

        dgvTabeliVaade.DataSource = autodList
    End Sub

    Private Sub btnProbleemid_Click(sender As Object, e As EventArgs) Handles btnProbleemid.Click
        If btnProbleemid.Text Is "Probleemid" Then
            btnProbleemid.Text = "Autod"

            dgvTabeliVaade.DataSource = probleemidList
        Else
            dgvTabeliVaade.DataSource = autodList
            btnProbleemid.Text = "Probleemid"
        End If
    End Sub
End Class
