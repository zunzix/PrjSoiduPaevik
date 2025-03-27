Imports System.ComponentModel

Public Class formTabeliVaade
    Private autodList As New BindingList(Of CAuto)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Manuaalne autode lisamine, asendme hiljem JSON faili lugemisega
        autodList.Add(New CAuto(1, "Peugot 206", 178989, 11.2, True, False))
        autodList.Add(New CAuto(1, "Honda Civic", 15003.2, 6.8, False, False))
        autodList.Add(New CAuto(1, "Ford Focus", 9999, 7.5, True, False))

        dgvTabeliVaade.DataSource = autodList
    End Sub
End Class
