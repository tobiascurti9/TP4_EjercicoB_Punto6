Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim DosConsecutivos, Contador, Num As Integer
        Do
            Num = InputBox("Ingresar numero: " & "", 0)
            If Num Mod 10 = 2 Or Num Mod 10 = -2 Then
                DosConsecutivos = DosConsecutivos + 1
            Else
                DosConsecutivos = 0

            End If
            Contador = Contador + 1
        Loop Until DosConsecutivos = 3
        lblSalida.Text = "Cantidad de numeros ingresados:" & Contador
        lblSalida.Text = "Ultimas"



    End Sub
End Class
