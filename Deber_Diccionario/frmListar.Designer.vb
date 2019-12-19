<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvDiccionario = New System.Windows.Forms.ListView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTA DE LAS PALABRAS "
        '
        'lvDiccionario
        '
        Me.lvDiccionario.HideSelection = False
        Me.lvDiccionario.Location = New System.Drawing.Point(146, 84)
        Me.lvDiccionario.Name = "lvDiccionario"
        Me.lvDiccionario.Size = New System.Drawing.Size(524, 249)
        Me.lvDiccionario.TabIndex = 1
        Me.lvDiccionario.UseCompatibleStateImageBehavior = False
        Me.lvDiccionario.View = System.Windows.Forms.View.List
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(297, 363)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(236, 43)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "REGRESAR AL MENÚ"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lvDiccionario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListar"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lvDiccionario As ListView
    Friend WithEvents btnRegresar As Button
End Class
