Public Class Form1
    Dim precioexe As Double
    Dim cantidadsum As Integer
    Dim subtotal As Double
    Dim ivan As Double

    Private Sub cantidad_TextChanged(sender As Object, e As EventArgs) Handles cantidad.TextChanged

    End Sub

    Private Sub menos_Click_1(sender As Object, e As EventArgs) Handles menos.Click
        cantidadsum = Val(cantidad.Text)
        If cantidadsum > 0 Then
            cantidadsum -= 1
        End If
        cantidad.Text = cantidadsum.ToString()
    End Sub

    Private Sub mas_Click(sender As Object, e As EventArgs) Handles mas.Click
        cantidadsum = Val(cantidad.Text)
        cantidadsum += 1
        cantidad.Text = cantidadsum.ToString()

    End Sub

    Private Sub calcs_Click(sender As Object, e As EventArgs) Handles calcsub.Click
        precioexe = Val(precio.Text)
        cantidadsum = Val(cantidad.Text)

        subtotal = precioexe * cantidadsum
        subtt.Text = subtotal.ToString

    End Sub

    Private Sub calciv_Click(sender As Object, e As EventArgs) Handles calciv.Click
        ivan = subtotal * 0.16
        iva.Text = ivan.ToString
    End Sub

    Private Sub calctt_Click(sender As Object, e As EventArgs) Handles calctt.Click
        Dim totalFinal As Double
        totalFinal = subtotal + ivan
        total.Text = totalFinal.ToString

    End Sub

    Private Sub subtt_Click(sender As Object, e As EventArgs) Handles subtt.Click

    End Sub

    Private Sub iva_Click(sender As Object, e As EventArgs) Handles iva.Click

    End Sub

    Private Sub total_Click(sender As Object, e As EventArgs) Handles total.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
