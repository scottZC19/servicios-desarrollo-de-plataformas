Public Class Form1


    Dim servicio As New ServiceReference2.Calculadora4SoapClient
    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        Dim nro1, nro2 As Double
        nro1 = txtnro1.Text
        nro2 = txtnro2.Text

        Dim suma As Double = servicio.Suma(nro1, nro2)
        txtresultado.Text = suma.ToString()
    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        Dim nro1, nro2 As Double
        nro1 = txtnro1.Text
        nro2 = txtnro2.Text
        Dim resta As Double = servicio.Resta(nro1, nro2)
        txtresultado.Text = resta.ToString()
    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        Dim nro1, nro2 As Double
        nro1 = txtnro1.Text
        nro2 = txtnro2.Text
        Dim multi As Double = servicio.Multiplicacion(nro1, nro2)
        txtresultado.Text = multi.ToString()
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        Dim nro1, nro2 As Double
        nro1 = txtnro1.Text
        nro2 = txtnro2.Text
        Dim div As Double = servicio.Division(nro1, nro2)
        txtresultado.Text = div.ToString()
    End Sub

    Private Sub btnpot_Click(sender As Object, e As EventArgs) Handles btnpot.Click
        Dim nro1, nro2 As Double
        nro1 = txtnro1.Text
        nro2 = txtnro2.Text
        Dim pot As Double = servicio.Potencia(nro1, nro2)
        txtresultado.Text = pot.ToString()
    End Sub

    Private Sub btnfac_Click(sender As Object, e As EventArgs) Handles btnfac.Click
        Dim nro1 As Double
        nro1 = txtnro1.Text

        Dim fac As Double = servicio.Fact(nro1)
        txtresultado.Text = fac.ToString()
    End Sub

    Private Sub btnraiz_Click(sender As Object, e As EventArgs) Handles btnraiz.Click
        Dim nro1 As Double
        nro1 = txtnro1.Text

        Dim raiz As Double = servicio.Raiz(nro1)
        txtresultado.Text = raiz.ToString()
    End Sub

    Private Sub btnseno_Click(sender As Object, e As EventArgs) Handles btnseno.Click
        Dim nro1 As Double
        nro1 = txtnro1.Text

        Dim sen As Double = servicio.Seno(nro1)
        txtresultado.Text = sen.ToString()
    End Sub

    Private Sub btncos_Click(sender As Object, e As EventArgs) Handles btncos.Click
        Dim nro1 As Double
        nro1 = txtnro1.Text

        Dim cos As Double = servicio.Coseno(nro1)
        txtresultado.Text = cos.ToString()
    End Sub

    Private Sub btntang_Click(sender As Object, e As EventArgs) Handles btntang.Click
        Dim nro1 As Double
        nro1 = txtnro1.Text

        Dim tan As Double = servicio.Tangente(nro1)
        txtresultado.Text = tan.ToString()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        txtnro1.Clear()
        txtnro2.Clear()
        txtresultado.Clear()
    End Sub

    Private Sub txtnro2_TextChanged(sender As Object, e As EventArgs) Handles txtnro2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
