<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEliminar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.lvDiccionario = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTA DE LAS PALABRAS "
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(276, 360)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(253, 47)
        Me.btnRegresar.TabIndex = 3
        Me.btnRegresar.Text = "REGRESAR AL MENÚ"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'lvDiccionario
        '
        Me.lvDiccionario.HideSelection = False
        Me.lvDiccionario.Location = New System.Drawing.Point(146, 67)
        Me.lvDiccionario.Name = "lvDiccionario"
        Me.lvDiccionario.Size = New System.Drawing.Size(521, 273)
        Me.lvDiccionario.TabIndex = 4
        Me.lvDiccionario.UseCompatibleStateImageBehavior = False
        Me.lvDiccionario.View = System.Windows.Forms.View.List
        '
        'frmEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lvDiccionario)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEliminar"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents lvDiccionario As ListView
End Class
