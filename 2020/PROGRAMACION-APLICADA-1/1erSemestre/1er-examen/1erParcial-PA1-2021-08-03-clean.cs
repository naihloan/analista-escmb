using System;

public class Program
{
    public static void Main()
    {
        
        Console.WriteLine("Bienvenidos al programa del Primer Parcial");
		Console.WriteLine("Ingrese 2 números enteros");

        Console.WriteLine("Ingrese el 1er número");
		string userInput = Console.ReadLine();
		int numero1 = Convert.ToInt32(userInput);

        Console.WriteLine("Ingrese el 2do número");
		string userInput2 = Console.ReadLine();
		int numero2 = Convert.ToInt32(userInput2);

		int suma = numero1 + numero2;
		int prom = suma / 2;
		if (numero1 > numero2) {
			Console.WriteLine("El numero mayor es " + numero1 + ". La suma es " + suma + ". Y el promedio es " + prom);
		} else if (numero2 > numero1) {
			Console.WriteLine("El numero mayor es " + numero2 + ". La suma es " + suma + ". Y el promedio es " + prom);
		} else {
			Console.WriteLine("El cuadrado de los iguales es " + Math.Pow(numero1, 2));
		}
		
		Console.WriteLine("Ahora ingrese un número que llamaremos MAX");
		string userInput3 = Console.ReadLine();
		int max = Convert.ToInt32(userInput3);
		
		Console.WriteLine("Estos son los números desde 1 hasta el MAX elegido: " );
		for (int i = 1; i <= max; i++)
			Console.WriteLine(i);
		
		Console.WriteLine("Quiere limpiar la consola? Pulse 'S' para seleccionar 'Sí'. De lo contrario, cualquier otra tecla.");
		string ingreso;
		ingreso = Console.ReadLine();
		
		if (ingreso == "S") {
			Console.Clear();
		} 
				
		Console.WriteLine("Si quiere Salir pulse 'X'. Si quiere volver a empezar, pulse 'R'.");
		ingreso = Console.ReadLine();
		if (ingreso == "X") {
			Environment.Exit(0);
		} 
		
		else if (ingreso == "R") {
	 		System.Diagnostics.Process.Start(
     		Environment.GetCommandLineArgs()[0], 
		    Environment.GetCommandLineArgs()[1]);
		}
				
		Console.ReadLine();
    }
}

