'Programa elaborado por DAVID YAUCA / 04-07-2021

'PROBLEMA: Desarrolle un programa que lea las temperaturas registradas 
'durante las 24 Horas del día. Se pide temperatura promedio del día, mayor 
'y menor temperatura registrada y en qué hora del día se cumplieron esas 2.

Public Class Form1

    Private Sub BtnComenzar_Click(sender As Object, e As EventArgs) Handles BtnComenzar.Click
        'ARRAY que almacena las temperaturas de las 24 horas del día
        Dim TemperaturasDia(23) As Decimal
        'Variable que valida la entrada del usuario para evitar que sea una cadena vacía
        Dim Temperatura As String

        'Se recorre el ARRAY para almacenar las temperaturas que ingresa el usuario
        For i As Integer = 0 To TemperaturasDia.Length - 1
            Temperatura = InputBox("Ingrese la temperatura de las " & i & ":00 Horas",
                                   "Ingresar Temperatura",
                                   "0.0")
            'Si el usuario pisa "Cancelar" dentro del InputBox o no ingresa ningún dato, 
            'se detiene el proceso
            If (Temperatura = "") Then
                Return
            Else
                TemperaturasDia(i) = Val(Temperatura)
            End If
        Next

        MsgBox("¡Las temperaturas han sido ingresadas correctamente!",
               MsgBoxStyle.OkOnly, "Registro exitoso")

        'Se inhabilita el botón "BtnComenzar"
        BtnComenzar.Enabled = False

        'Variable que almacena la HORA de la MAYOR TEMPERATURA
        Dim HoraMayorTemperatura As Integer

        'Variable que almacena la MAYOR TEMPERATURA
        Dim MayorTemperatura As Decimal

        'Determina cuál es la MAYOR temperatura
        For i As Integer = 0 To TemperaturasDia.Length - 1
            If (TemperaturasDia(i) > MayorTemperatura) Then
                HoraMayorTemperatura = i
                MayorTemperatura = TemperaturasDia(i)
            End If
        Next

        'Variable que almacena la HORA de la MENOR TEMPERATURA
        Dim HoraMenorTemperatura As Integer = 0

        'Variable que almacena la MENOR TEMPERATURA
        Dim MenorTemperatura As Decimal = MayorTemperatura

        'Determina cuál es la MENOR temperatura
        For i As Integer = 0 To TemperaturasDia.Length - 1
            If (MenorTemperatura > TemperaturasDia(i)) Then
                HoraMenorTemperatura = i
                MenorTemperatura = TemperaturasDia(i)
            End If
        Next


        'Variable que almacena la sumatoria de todas las temperaturas
        Dim AcumuladorTemperatura As Decimal = 0.0
        'Variable que almacena el promedio de las temperaturas registradas
        Dim TemperaturaPromedio As Decimal = 0.0

        'Suma todas las temperaturas y almacena el resultado en "AcumuladorTemperatura"
        For i As Integer = 0 To TemperaturasDia.Length - 1
            AcumuladorTemperatura += TemperaturasDia(i)
        Next

        'Se almacena el promedio en "TemperaturaPromedio"
        TemperaturaPromedio = AcumuladorTemperatura / TemperaturasDia.Length


        'Se muestra por pantalla la HORA de la MENOR TEMPERATURA
        TxtHoraMenorTemperatura.Text = HoraMenorTemperatura & ":00 h"
        'Se muestra por pantalla la MENOR TEMPERATURA
        TxtMenorTemperatura.Text = MenorTemperatura

        'Se muestra por pantalla la HORA de la MAYOR TEMPERATURA
        TxtHoraMayorTemperatura.Text = HoraMayorTemperatura & ":00 h"
        'Se muestra por pantalla la MAYOR TEMPERATURA
        TxtMayorTemperatura.Text = MayorTemperatura

        'Se muestra por pantalla el PROMEDIO DE LAS TEMPERATURAS
        TxtTemperaturaPromedio.Text = TemperaturaPromedio


        'Se habilita el botón "BtnLimpiar"
        BtnLimpiar.Enabled = True
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtHoraMenorTemperatura.Clear()
        TxtMenorTemperatura.Clear()

        TxtHoraMayorTemperatura.Clear()
        TxtMayorTemperatura.Clear()

        TxtTemperaturaPromedio.Clear()

        BtnComenzar.Enabled = True
        BtnLimpiar.Enabled = False
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'Despliega un MessageBox que pide confirmación para salir del programa
        Dim TextoMsgBox As String = "¿Desea salir de la aplicación?"
        Dim TituloMsgBox As String = "Salir"
        Dim BotonesMsgBox As MessageBoxButtons = MessageBoxButtons.YesNo

        Dim MsgBox As DialogResult = MessageBox.Show(TextoMsgBox, TituloMsgBox, BotonesMsgBox)

        'Si la opción del usuario es "Si", se detiene la ejecución del programa
        If MsgBox = System.Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
End Class