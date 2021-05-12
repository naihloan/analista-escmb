Module Module1

    Sub Main()

        Dim primerNombre As String
        Dim segundoNombre As String
        Dim nombreCompleto As String
        Dim edad As Integer
        edad = 1


        primerNombre = "Javier" 'este es mi primer nombre
        segundoNombre = "Mc Donald's"

        If edad >= 21 Then
            Console.WriteLine("Puede tomar alcohol")
        ElseIf edad >= 18 Then
            Console.WriteLine("Puede fumar")
        ElseIf edad < 18 AndAlso edad > 3 Then
            Console.WriteLine("Puede jugar a la pelota o al tejo")
        Else
            Console.WriteLine("No cumple con las condiciones ante4riores")
        End If

        If primerNombre = "javier" Then Console.WriteLine("El nombre es copado")



        If primerNombre = "Javier" Then
            Console.WriteLine("El nombre es copado")
        End If

        nombreCompleto = primerNombre _
        & " " + segundoNombre

        Select Case edad
            Case 1
                Console.WriteLine("Ingresó 1")
            Case 2
                Console.WriteLine("Ingresó 2")
            Case 3
                Console.WriteLine("Ingresó 3")
            Case Else
                Console.WriteLine("No Ingresó ni 1 ni 2 ni 3")
        End Select

        Select Case edad
            Case 1, 2, 3, 4, 5, 6
                Console.WriteLine("Es menor de 7")
            Case 7, 8, 9, 10, 11, 12, 13
                Console.WriteLine("Es menor de 14")
            Case 14, 15, 16, 17
                Console.WriteLine("Es menor de 18")
            Case 21
                Console.WriteLine("Tiene 21")
            Case Else
                Console.WriteLine("Es mayor de 18")
        End Select

        Dim precios(2) As Decimal 'EN Vb. le indico el número de índices que va a tener el vector
        precios(0) = 1
        precios(1) = 2.1
        precios(2) = 3.4
        ' precios(3) = 100














        Console.WriteLine(nombreCompleto)

        Console.ReadLine()


    End Sub

End Module
