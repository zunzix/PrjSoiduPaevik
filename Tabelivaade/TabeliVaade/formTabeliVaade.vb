Imports System.ComponentModel

Public Class formTabeliVaade

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvTabeliVaade.DataSource = CTabelReader.GetInstance().autodList

    End Sub
End Class
