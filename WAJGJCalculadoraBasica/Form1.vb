Public Class Form1

    Private Sub BTNSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSuma.Click

        'Declaración de variables'
        Dim INTNum1, INTNum2, INTResultado As Integer

        'Entrada de datos'
        INTNum1 = Val(TXTNum1.Text)
        INTNum2 = Val(TXTNum2.Text)

        'Calculo o proceso'
        INTResultado = INTNum1 + INTNum2

        'Salida de datos'
        TXTResultado.Text = Str(INTResultado)

    End Sub

    Private Sub BTNResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNResta.Click

        'Declaración de variables'
        Dim INTNum1, INTNum2, INTResultado As Integer

        'Entrada de datos'
        INTNum1 = Val(TXTNum1.Text)
        INTNum2 = Val(TXTNum2.Text)

        'Calculo o proceso'
        INTResultado = INTNum1 - INTNum2

        'Salida de datos'
        TXTResultado.Text = Str(INTResultado)

    End Sub

    Private Sub BTNMultiplica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMultiplica.Click

        'Declaración de variables'
        Dim INTNum1, INTNum2, INTResultado As Integer

        'Entrada de datos'
        INTNum1 = Val(TXTNum1.Text)
        INTNum2 = Val(TXTNum2.Text)

        'Calculo o proceso'
        INTResultado = INTNum1 * INTNum2

        'Salida de datos'
        TXTResultado.Text = Str(INTResultado)

    End Sub

    Private Sub BTNDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNDivide.Click

        'Declaración de variables'
        Dim INTNum1, INTNum2 As Integer
        Dim INTResultado As Double

        'Entrada de datos'
        INTNum1 = Val(TXTNum1.Text)
        INTNum2 = Val(TXTNum2.Text)

        'Calculo o proceso'
        INTResultado = INTNum1 / INTNum2

        'Salida de datos'
        TXTResultado.Text = Str(INTResultado)

    End Sub
End Class
