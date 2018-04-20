<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Alta = New System.Windows.Forms.Button
        Me.baja = New System.Windows.Forms.Button
        Me.Modificar = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Enumerar = New System.Windows.Forms.Button
        Me.Alfabetizar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(29, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(125, 212)
        Me.ListBox1.TabIndex = 4
        '
        'Alta
        '
        Me.Alta.Location = New System.Drawing.Point(196, 24)
        Me.Alta.Name = "Alta"
        Me.Alta.Size = New System.Drawing.Size(57, 34)
        Me.Alta.TabIndex = 1
        Me.Alta.Text = "Alta"
        Me.Alta.UseVisualStyleBackColor = True
        '
        'baja
        '
        Me.baja.Location = New System.Drawing.Point(196, 86)
        Me.baja.Name = "baja"
        Me.baja.Size = New System.Drawing.Size(54, 38)
        Me.baja.TabIndex = 2
        Me.baja.Text = "Baja"
        Me.baja.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(196, 209)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(65, 40)
        Me.Modificar.TabIndex = 3
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 274)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Enumerar
        '
        Me.Enumerar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Enumerar.Location = New System.Drawing.Point(196, 161)
        Me.Enumerar.Name = "Enumerar"
        Me.Enumerar.Size = New System.Drawing.Size(65, 42)
        Me.Enumerar.TabIndex = 5
        Me.Enumerar.Text = "Enumerar"
        Me.Enumerar.UseVisualStyleBackColor = False
        '
        'Alfabetizar
        '
        Me.Alfabetizar.BackColor = System.Drawing.Color.Red
        Me.Alfabetizar.ForeColor = System.Drawing.Color.Honeydew
        Me.Alfabetizar.Location = New System.Drawing.Point(197, 130)
        Me.Alfabetizar.Name = "Alfabetizar"
        Me.Alfabetizar.Size = New System.Drawing.Size(64, 29)
        Me.Alfabetizar.TabIndex = 6
        Me.Alfabetizar.Text = "Alfabetizar"
        Me.Alfabetizar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(402, 322)
        Me.Controls.Add(Me.Alfabetizar)
        Me.Controls.Add(Me.Enumerar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.baja)
        Me.Controls.Add(Me.Alta)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Alta As System.Windows.Forms.Button
    Friend WithEvents baja As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Enumerar As System.Windows.Forms.Button
    Friend WithEvents Alfabetizar As System.Windows.Forms.Button

End Class
