Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TemperaturConverter

Public Class Form1
    Private Sub ctof_button_Click(sender As Object, e As EventArgs) Handles ctof_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim c As Double
        c = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.cToF(c)
    End Sub

    Private Sub ctor_button_Click(sender As Object, e As EventArgs) Handles ctor_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim c As Double
        c = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.cToR(c)
    End Sub

    Private Sub ctok_button_Click(sender As Object, e As EventArgs) Handles ctok_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim c As Double
        c = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.cToK(c)
    End Sub




    Private Sub ftoc_button_Click(sender As Object, e As EventArgs) Handles ftoc_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim f As Double
        f = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.fToC(f)
    End Sub

    Private Sub ftor_button_Click(sender As Object, e As EventArgs) Handles ftor_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim f As Double
        f = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.fToR(f)
    End Sub

    Private Sub ftok_button_Click(sender As Object, e As EventArgs) Handles ftok_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim f As Double
        f = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.fToK(f)
    End Sub



    Private Sub rtoc_button_Click(sender As Object, e As EventArgs) Handles rtoc_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim r As Double
        r = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.rToC(r)
    End Sub

    Private Sub rtof_button_Click(sender As Object, e As EventArgs) Handles rtof_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim r As Double
        r = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.rToF(r)
    End Sub

    Private Sub rtok_button_Click(sender As Object, e As EventArgs) Handles rtok_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim r As Double
        r = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.rToK(r)
    End Sub




    Private Sub ktoc_button_Click(sender As Object, e As EventArgs) Handles ktoc_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim k As Double
        k = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.kToC(k)
    End Sub

    Private Sub ktof_button_Click(sender As Object, e As EventArgs) Handles ktof_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim k As Double
        k = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.kToF(k)
    End Sub

    Private Sub ktor_button_Click(sender As Object, e As EventArgs) Handles ktor_button.Click
        Dim objConv As New TemperaturConverter.Class1
        Dim k As Double
        k = CDbl(input_textbox.Text)
        hasil_label.Text = objConv.kToR(k)
    End Sub


End Class
