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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnComenzar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtHoraMenorTemperatura = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtMenorTemperatura = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMayorTemperatura = New System.Windows.Forms.TextBox()
        Me.TxtHoraMayorTemperatura = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTemperaturaPromedio = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Silver
        Me.BtnSalir.Location = New System.Drawing.Point(255, 281)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 45)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Silver
        Me.BtnLimpiar.Enabled = False
        Me.BtnLimpiar.Location = New System.Drawing.Point(167, 281)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 45)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnComenzar
        '
        Me.BtnComenzar.BackColor = System.Drawing.Color.Silver
        Me.BtnComenzar.Location = New System.Drawing.Point(196, 48)
        Me.BtnComenzar.Name = "BtnComenzar"
        Me.BtnComenzar.Size = New System.Drawing.Size(80, 45)
        Me.BtnComenzar.TabIndex = 2
        Me.BtnComenzar.Text = "Comenzar"
        Me.BtnComenzar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnComenzar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 104)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Presione ""Comenzar"" para calcular las temperaturas del día:"
        '
        'TxtHoraMenorTemperatura
        '
        Me.TxtHoraMenorTemperatura.BackColor = System.Drawing.SystemColors.Info
        Me.TxtHoraMenorTemperatura.Enabled = False
        Me.TxtHoraMenorTemperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraMenorTemperatura.Location = New System.Drawing.Point(10, 35)
        Me.TxtHoraMenorTemperatura.Name = "TxtHoraMenorTemperatura"
        Me.TxtHoraMenorTemperatura.Size = New System.Drawing.Size(100, 28)
        Me.TxtHoraMenorTemperatura.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TxtMenorTemperatura)
        Me.GroupBox2.Controls.Add(Me.TxtHoraMenorTemperatura)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 80)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menor temperatura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 24)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "°C"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(112, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 24)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = ":"
        '
        'TxtMenorTemperatura
        '
        Me.TxtMenorTemperatura.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMenorTemperatura.Enabled = False
        Me.TxtMenorTemperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMenorTemperatura.Location = New System.Drawing.Point(130, 35)
        Me.TxtMenorTemperatura.Name = "TxtMenorTemperatura"
        Me.TxtMenorTemperatura.Size = New System.Drawing.Size(70, 28)
        Me.TxtMenorTemperatura.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtMayorTemperatura)
        Me.GroupBox3.Controls.Add(Me.TxtHoraMayorTemperatura)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(251, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 80)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mayor temperatura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(202, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 24)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "°C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 24)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = ":"
        '
        'TxtMayorTemperatura
        '
        Me.TxtMayorTemperatura.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMayorTemperatura.Enabled = False
        Me.TxtMayorTemperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMayorTemperatura.Location = New System.Drawing.Point(130, 35)
        Me.TxtMayorTemperatura.Name = "TxtMayorTemperatura"
        Me.TxtMayorTemperatura.Size = New System.Drawing.Size(70, 28)
        Me.TxtMayorTemperatura.TabIndex = 5
        '
        'TxtHoraMayorTemperatura
        '
        Me.TxtHoraMayorTemperatura.BackColor = System.Drawing.SystemColors.Info
        Me.TxtHoraMayorTemperatura.Enabled = False
        Me.TxtHoraMayorTemperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraMayorTemperatura.Location = New System.Drawing.Point(10, 35)
        Me.TxtHoraMayorTemperatura.Name = "TxtHoraMayorTemperatura"
        Me.TxtHoraMayorTemperatura.Size = New System.Drawing.Size(100, 28)
        Me.TxtHoraMayorTemperatura.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TxtTemperaturaPromedio)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(472, 65)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Temperatura promedio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(287, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 24)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "°C"
        '
        'TxtTemperaturaPromedio
        '
        Me.TxtTemperaturaPromedio.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTemperaturaPromedio.Enabled = False
        Me.TxtTemperaturaPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTemperaturaPromedio.Location = New System.Drawing.Point(186, 21)
        Me.TxtTemperaturaPromedio.Name = "TxtTemperaturaPromedio"
        Me.TxtTemperaturaPromedio.Size = New System.Drawing.Size(100, 28)
        Me.TxtTemperaturaPromedio.TabIndex = 44
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(496, 338)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnComenzar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtHoraMenorTemperatura As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMenorTemperatura As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMayorTemperatura As System.Windows.Forms.TextBox
    Friend WithEvents TxtHoraMayorTemperatura As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTemperaturaPromedio As System.Windows.Forms.TextBox

End Class
