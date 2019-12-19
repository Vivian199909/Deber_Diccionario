Imports System.IO
Public Class frmGuardar
    Public indiceItem As Integer
    Public path As String
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmListar.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim palabra, definicion, dic As String
        palabra = txtPalabra.Text
        definicion = RichTextBox1.Text
        dic = palabra + ":" + definicion + ":" + path
        Dim item1 As ListViewItem
        item1 = New ListViewItem(dic, 0)
        item1.SubItems.Add(palabra)
        item1.SubItems.Add(definicion)
        item1.SubItems.Add(path)

        frmListar.lvDiccionario.Items.Item(indiceItem) = item1
        frmEliminar.lvDiccionario.Items.Item(indiceItem) = item1.Clone

        'frmListar.lvDiccionario.Items.Add(item1)
        'frmEliminar.lvDiccionario.Items.Add(item1.Clone)
        Dim Directorio As String

        If Dir(Environ("UserProfile") & "\Escritorio\", vbDirectory) <> "" Then Directorio = Environ("USERPROFILE") & "\Escritorio\"
        If Dir(Environ("UserProfile") & "\Desktop\", vbDirectory) <> "" Then Directorio = Environ("USERPROFILE") & "\Desktop\"
        Dim escribir As New StreamWriter(Directorio + "Deber_palabras.txt", False)
        For Each item As ListViewItem In frmListar.lvDiccionario.Items
            escribir.WriteLine(item.Text)
        Next
        escribir.Close()
    End Sub
End Class