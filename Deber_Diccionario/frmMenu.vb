Public Class frmMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        frmAgregar.Show()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        frmEliminar.Show()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        frmListar.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
