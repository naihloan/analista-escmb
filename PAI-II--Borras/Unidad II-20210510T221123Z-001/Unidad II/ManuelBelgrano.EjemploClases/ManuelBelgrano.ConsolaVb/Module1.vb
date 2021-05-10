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











        Console.WriteLine(nombreCompleto)

        Console.ReadLine()


    End Sub

End Module
