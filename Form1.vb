Public Class Form1
    Private Sub btnAgregarNombre1_Click(sender As Object, e As EventArgs) Handles btnAgregarNombre1.Click
        'Procedimiento de Evento

        Dim PuestoVentas As String = ""
        AgregarNombre("Ventas", PuestoVentas)
        txtVentas.Text = txtVentas.Text & PuestoVentas

    End Sub

    Private Sub btnAgregarNombre2_Click(sender As Object, e As EventArgs) Handles btnAgregarNombre2.Click
        'Procedimiento de Evento

        Dim PuestoMkt As String = ""
        AgregarNombre("Marketing", PuestoMkt)
        txtMarkenting.Text = txtMarkenting.Text & PuestoMkt
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
