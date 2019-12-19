Imports System.IO
Public Class frmAgregar
    Dim file As New OpenFileDialog()
    Dim list_diccionario As New List(Of String)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim palabra, definicion, dic As String
        palabra = txtPalabra.Text
        definicion = txtSignificado.Text
        dic = palabra + ":" + definicion + ":" + file.FileName
        Dim item1 As ListViewItem
        item1 = New ListViewItem(dic, 0)
        item1.SubItems.Add(palabra)
        item1.SubItems.Add(definicion)
        item1.SubItems.Add(file.FileName)


        frmListar.lvDiccionario.Items.Add(item1)
        frmEliminar.lvDiccionario.Items.Add(item1.Clone)
        Dim Directorio As String

        If Dir(Environ("UserProfile") & "\Escritorio\", vbDirectory) <> "" Then Directorio = Environ("USERPROFILE") & "\Escritorio\"
        If Dir(Environ("UserProfile") & "\Desktop\", vbDirectory) <> "" Then Directorio = Environ("USERPROFILE") & "\Desktop\"
        Dim escribir As New StreamWriter(Directorio + "Deber_palabras.txt", False)
        For Each item As ListViewItem In frmListar.lvDiccionario.Items
            escribir.WriteLine(item.Text)
        Next
        escribir.Close()

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Form3.lvDiccionario =
        'Form4.lvDiccionario =

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        file.Filter = "Archivo JPG|*.jpg"

        If file.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(file.FileName)
            'MsgBox(file.FileName)
        End If
    End Sub
End Class