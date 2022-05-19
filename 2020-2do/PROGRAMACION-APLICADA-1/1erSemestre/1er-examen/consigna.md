---
title: "Programación Aplicada [C#] 1er Parcial"
author: Benjamín Juárez
date: 3 de Julio, 2020
geometry: margin=4cm
output: pdf_document
classoption: landscape
---

\thispagestyle{empty}


1. Generar un programa que imprima un mensaje que diga : `'bienvenidos al programa del primer parcial'`
2. El mismo deberá pedir al usuario que `ingrese dos números enteros` (validar el ingreso)  
Luego `imprimir` el mayor de ambos, la suma de ambos y el promedio de ambos  
Si son iguales, `imprimir` la suma de ambos elevado al cuadrado (Math.Pow())
3. Pedir que el usuario `ingrese una variable llamada max`,  
 y luego `imprimir todos los números` del 1 al max (inclusive)
4. Al finalizar, `preguntar` al usuario si desea limpiar la consola
5. `Preguntar` al usuario si desea volver a ejecutar el programa o salir

---

```
using System;
					
public class Program
{
	public static void Main()
	{
        string numero1;
        string numero2;

		Console.WriteLine("Bienvenidos al programa del Primer Parcial");
		Console.WriteLine("Ingrese 2 números enteros");

		Console.WriteLine("Ingrese el 1er número");
        numero1 = Console.ReadLine();
		Console.WriteLine("Ingrese el 2do número");
        numero2 = Console.ReadLine();

		Console.WriteLine("El 1er número es: ");
		Console.WriteLine(numero1);
		Console.WriteLine("El 2do número es: ");
		Console.WriteLine(numero2);
	}
}
```
