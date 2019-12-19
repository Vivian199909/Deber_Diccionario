
Public Class frmListar
    Dim listDiccionario As ListView
    Dim palabra, definicion As String
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu.Show()
        Me.Hide()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listDiccionario = lvDiccionario
    End Sub
    Private Sub lvDiccionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDiccionario.SelectedIndexChanged
        If listDiccionario.SelectedItems.Count > 0 Then

            Dim item As ListViewItem = listDiccionario.SelectedItems(0)

            Dim palabra As String = item.SubItems(1).Text
            Dim definicion As String = item.SubItems(2).Text

            frmGuardar.txtPalabra.Text = palabra
            frmGuardar.RichTextBox1.Text = definicion

            frmGuardar.path = lvDiccionario.SelectedItems.Item(0).SubItems(3).Text
            frmGuardar.indiceItem = lvDiccionario.SelectedIndices(0)

            frmGuardar.Show()
            Me.Hide()
        End If
    End Sub


End Class