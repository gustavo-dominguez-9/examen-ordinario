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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.menos = New System.Windows.Forms.Button()
        Me.mas = New System.Windows.Forms.Button()
        Me.calcsub = New System.Windows.Forms.Button()
        Me.calciv = New System.Windows.Forms.Button()
        Me.calctt = New System.Windows.Forms.Button()
        Me.subtt = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.iva = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja de Tienda 🍌"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subtotal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IVA (16%) :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(187, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL:"
        '
        'precio
        '
        Me.precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio.Location = New System.Drawing.Point(191, 121)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(183, 23)
        Me.precio.TabIndex = 6
        Me.precio.Text = "0"
        '
        'cantidad
        '
        Me.cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.Location = New System.Drawing.Point(219, 163)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(103, 23)
        Me.cantidad.TabIndex = 7
        Me.cantidad.Text = "0"
        Me.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'menos
        '
        Me.menos.Location = New System.Drawing.Point(167, 163)
        Me.menos.Name = "menos"
        Me.menos.Size = New System.Drawing.Size(46, 23)
        Me.menos.TabIndex = 8
        Me.menos.Text = "-1"
        Me.menos.UseVisualStyleBackColor = True
        '
        'mas
        '
        Me.mas.Location = New System.Drawing.Point(328, 163)
        Me.mas.Name = "mas"
        Me.mas.Size = New System.Drawing.Size(46, 23)
        Me.mas.TabIndex = 9
        Me.mas.Text = "+1"
        Me.mas.UseVisualStyleBackColor = True
        '
        'calcsub
        '
        Me.calcsub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcsub.Location = New System.Drawing.Point(59, 235)
        Me.calcsub.Name = "calcsub"
        Me.calcsub.Size = New System.Drawing.Size(122, 34)
        Me.calcsub.TabIndex = 10
        Me.calcsub.Text = "Calcular Subtotal"
        Me.calcsub.UseVisualStyleBackColor = True
        '
        'calciv
        '
        Me.calciv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calciv.Location = New System.Drawing.Point(59, 287)
        Me.calciv.Name = "calciv"
        Me.calciv.Size = New System.Drawing.Size(122, 34)
        Me.calciv.TabIndex = 11
        Me.calciv.Text = "Calcular IVA"
        Me.calciv.UseVisualStyleBackColor = True
        '
        'calctt
        '
        Me.calctt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calctt.Location = New System.Drawing.Point(59, 338)
        Me.calctt.Name = "calctt"
        Me.calctt.Size = New System.Drawing.Size(122, 34)
        Me.calctt.TabIndex = 12
        Me.calctt.Text = "Calcular Total"
        Me.calctt.UseVisualStyleBackColor = True
        '
        'subtt
        '
        Me.subtt.AutoSize = True
        Me.subtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtt.Location = New System.Drawing.Point(351, 237)
        Me.subtt.Name = "subtt"
        Me.subtt.Size = New System.Drawing.Size(23, 25)
        Me.subtt.TabIndex = 13
        Me.subtt.Text = "0"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(351, 347)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(23, 25)
        Me.total.TabIndex = 14
        Me.total.Text = "0"
        '
        'iva
        '
        Me.iva.AutoSize = True
        Me.iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iva.Location = New System.Drawing.Point(351, 289)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(23, 25)
        Me.iva.TabIndex = 14
        Me.iva.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(322, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(162, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 25)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(322, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 25)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(322, 289)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 25)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 431)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.subtt)
        Me.Controls.Add(Me.calctt)
        Me.Controls.Add(Me.calciv)
        Me.Controls.Add(Me.calcsub)
        Me.Controls.Add(Me.mas)
        Me.Controls.Add(Me.menos)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents precio As TextBox
    Friend WithEvents cantidad As TextBox
    Friend WithEvents menos As Button
    Friend WithEvents mas As Button
    Friend WithEvents calcsub As Button
    Friend WithEvents calciv As Button
    Friend WithEvents calctt As Button
    Friend WithEvents subtt As Label
    Friend WithEvents total As Label
    Friend WithEvents iva As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
