<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTNSuma = New System.Windows.Forms.Button
        Me.BTNResta = New System.Windows.Forms.Button
        Me.BTNMultiplica = New System.Windows.Forms.Button
        Me.BTNDivide = New System.Windows.Forms.Button
        Me.LBLTitulo = New System.Windows.Forms.Label
        Me.LBLNum1 = New System.Windows.Forms.Label
        Me.LBLResultado = New System.Windows.Forms.Label
        Me.LBLNum2 = New System.Windows.Forms.Label
        Me.TXTNum1 = New System.Windows.Forms.TextBox
        Me.TXTNum2 = New System.Windows.Forms.TextBox
        Me.TXTResultado = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'BTNSuma
        '
        Me.BTNSuma.Location = New System.Drawing.Point(28, 223)
        Me.BTNSuma.Name = "BTNSuma"
        Me.BTNSuma.Size = New System.Drawing.Size(75, 23)
        Me.BTNSuma.TabIndex = 0
        Me.BTNSuma.Text = "Suma"
        Me.BTNSuma.UseVisualStyleBackColor = True
        '
        'BTNResta
        '
        Me.BTNResta.Location = New System.Drawing.Point(133, 223)
        Me.BTNResta.Name = "BTNResta"
        Me.BTNResta.Size = New System.Drawing.Size(75, 23)
        Me.BTNResta.TabIndex = 1
        Me.BTNResta.Text = "Resta"
        Me.BTNResta.UseVisualStyleBackColor = True
        '
        'BTNMultiplica
        '
        Me.BTNMultiplica.Location = New System.Drawing.Point(235, 223)
        Me.BTNMultiplica.Name = "BTNMultiplica"
        Me.BTNMultiplica.Size = New System.Drawing.Size(75, 23)
        Me.BTNMultiplica.TabIndex = 2
        Me.BTNMultiplica.Text = "Multiplica"
        Me.BTNMultiplica.UseVisualStyleBackColor = True
        '
        'BTNDivide
        '
        Me.BTNDivide.Location = New System.Drawing.Point(335, 223)
        Me.BTNDivide.Name = "BTNDivide"
        Me.BTNDivide.Size = New System.Drawing.Size(75, 23)
        Me.BTNDivide.TabIndex = 3
        Me.BTNDivide.Text = "Divide"
        Me.BTNDivide.UseVisualStyleBackColor = True
        '
        'LBLTitulo
        '
        Me.LBLTitulo.AutoSize = True
        Me.LBLTitulo.Location = New System.Drawing.Point(120, 22)
        Me.LBLTitulo.Name = "LBLTitulo"
        Me.LBLTitulo.Size = New System.Drawing.Size(170, 13)
        Me.LBLTitulo.TabIndex = 4
        Me.LBLTitulo.Text = "Calculadora Básica 4 Operaciones"
        '
        'LBLNum1
        '
        Me.LBLNum1.AutoSize = True
        Me.LBLNum1.Location = New System.Drawing.Point(91, 67)
        Me.LBLNum1.Name = "LBLNum1"
        Me.LBLNum1.Size = New System.Drawing.Size(41, 13)
        Me.LBLNum1.TabIndex = 5
        Me.LBLNum1.Text = "Num 1:"
        '
        'LBLResultado
        '
        Me.LBLResultado.AutoSize = True
        Me.LBLResultado.Location = New System.Drawing.Point(91, 155)
        Me.LBLResultado.Name = "LBLResultado"
        Me.LBLResultado.Size = New System.Drawing.Size(58, 13)
        Me.LBLResultado.TabIndex = 6
        Me.LBLResultado.Text = "Resultado:"
        '
        'LBLNum2
        '
        Me.LBLNum2.AutoSize = True
        Me.LBLNum2.Location = New System.Drawing.Point(91, 114)
        Me.LBLNum2.Name = "LBLNum2"
        Me.LBLNum2.Size = New System.Drawing.Size(41, 13)
        Me.LBLNum2.TabIndex = 7
        Me.LBLNum2.Text = "Num 2:"
        '
        'TXTNum1
        '
        Me.TXTNum1.Location = New System.Drawing.Point(190, 64)
        Me.TXTNum1.Name = "TXTNum1"
        Me.TXTNum1.Size = New System.Drawing.Size(100, 20)
        Me.TXTNum1.TabIndex = 8
        '
        'TXTNum2
        '
        Me.TXTNum2.Location = New System.Drawing.Point(190, 107)
        Me.TXTNum2.Name = "TXTNum2"
        Me.TXTNum2.Size = New System.Drawing.Size(100, 20)
        Me.TXTNum2.TabIndex = 9
        '
        'TXTResultado
        '
        Me.TXTResultado.Location = New System.Drawing.Point(190, 155)
        Me.TXTResultado.Name = "TXTResultado"
        Me.TXTResultado.Size = New System.Drawing.Size(100, 20)
        Me.TXTResultado.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 266)
        Me.Controls.Add(Me.TXTResultado)
        Me.Controls.Add(Me.TXTNum2)
        Me.Controls.Add(Me.TXTNum1)
        Me.Controls.Add(Me.LBLNum2)
        Me.Controls.Add(Me.LBLResultado)
        Me.Controls.Add(Me.LBLNum1)
        Me.Controls.Add(Me.LBLTitulo)
        Me.Controls.Add(Me.BTNDivide)
        Me.Controls.Add(Me.BTNMultiplica)
        Me.Controls.Add(Me.BTNResta)
        Me.Controls.Add(Me.BTNSuma)
        Me.Name = "Form1"
        Me.Text = "Calculadora Básica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNSuma As System.Windows.Forms.Button
    Friend WithEvents BTNResta As System.Windows.Forms.Button
    Friend WithEvents BTNMultiplica As System.Windows.Forms.Button
    Friend WithEvents BTNDivide As System.Windows.Forms.Button
    Friend WithEvents LBLTitulo As System.Windows.Forms.Label
    Friend WithEvents LBLNum1 As System.Windows.Forms.Label
    Friend WithEvents LBLResultado As System.Windows.Forms.Label
    Friend WithEvents LBLNum2 As System.Windows.Forms.Label
    Friend WithEvents TXTNum1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTNum2 As System.Windows.Forms.TextBox
    Friend WithEvents TXTResultado As System.Windows.Forms.TextBox

End Class
