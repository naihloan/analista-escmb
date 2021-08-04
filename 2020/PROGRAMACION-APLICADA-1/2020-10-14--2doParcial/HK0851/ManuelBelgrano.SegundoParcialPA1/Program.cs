
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ManuelBelgrano.Ahorcadito;

namespace ManuelBelgrano.SegundoParcialPA1
{
	/*
	CONSIGNA:
	Mediante el método File.ReadAllLines(...) leer el archivo asociado "palabras.txt", en dónde en cada línea hay una palabra y almacenarlo en una variable llamada string[] palabras.Luego generar los métodos para:
Usando un bucle FOR, mostrar las palabras en el rango de posiciones del 15 al 25 .
 Usando el método Random, mostrar una palabra aleatoria de 0 hasta el tamaño del vector
 Mostrar un mensaje que pida al usuario que ingrese un valor (texto) y segun sea ese valor hacer: :  Si la letra ingresada es "N" o "n", Limpiar la pantalla y ubicar el cursor en la posición Top: 20 y Left: 25 y mostrar tu nombre completo
 Si la letra ingresada es "L" o "l", Limpliar la pantalla y mostrar con un color de fondo azul (blue) y letras amarillas (yellow) el mensaje "Esto ha sido el parcial"
 Caso contrario, Limpiar la pantalla, Producir un sonido "Console.Beep..." y finalizar el programa
	*/

    class Program
    {
        static void Main(string[] args)
        {
            Examen.Examen.Empezar();//NO BORRAR ESTA LINEA
            //ESCRIBE TU CODIGO AQUI:

            //Mediante el método File.ReadAllLines(...) leer el archivo asociado "palabras.txt", 
            string[] listaDePalabras = File.ReadAllLines("Palabras.txt");
            // Console.WriteLine(listaDePalabras);
            // en dónde en cada línea hay una palabra y almacenarlo en una variable llamada string[] palabras.

            // Luego generar los métodos para:
            // Usando un bucle FOR, mostrar las palabras en el rango de posiciones del 15 al 25 .

            Console.WriteLine("Esta es una lista de palabras entre los rangos 15 y 25: "); 
            for(var i=15; i <= 25; i++)
            {
                Console.WriteLine(listaDePalabras[i]);
            }

            Console.WriteLine("Y ahora esta es una palabra al azar: ");
            // Usando el método Random, mostrar una palabra aleatoria de 0 hasta el tamaño del vector
            Random r = new Random();
            int n = r.Next(0, listaDePalabras.Length);
            Console.WriteLine(listaDePalabras[n]);

            // Mostrar un mensaje que pida al usuario que ingrese un valor (texto) 
            Console.WriteLine("Usuario: ingrese un valor en texto en mayúscula o minúscula: ");
            // y segun sea ese valor hacer: :  Si la letra ingresada es "N" o "n", Limpiar la pantalla y ubicar el cursor en la posición Top: 20 y Left: 25 y mostrar tu nombre completo
            Console.WriteLine("'N' o 'n', para mostrar tu nombre; ");
            // Si la letra ingresada es "L" o "l", Limpliar la pantalla y mostrar con un color de fondo azul (blue) y letras amarillas (yellow) el mensaje "Esto ha sido el parcial"
            Console.WriteLine("'L' o 'l', para limpiar la pantalla y terminar el test; ");
            // Caso contrario, Limpiar la pantalla, Producir un sonido "Console.Beep..." y finalizar el programa
            Console.WriteLine("o cualquier otra tecla para finalizar el programa.");

            var texto = Helper.IngresoString("Presione una letra cualquiera: ");
            if (texto == "N" || texto == "n")
            {
                    Console.Clear();
                    Console.CursorTop = 20;
                    Console.CursorLeft = 25;
                    Console.WriteLine("Benjamin Juarez");
                    Console.ReadLine();
            }
            if (texto == "L" || texto == "l")
            {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Esto ha sido el parcial.");
            } 
            else
            {
                    // THE END
                    Console.Clear();
                    Console.Beep(4000, 300);
                    Environment.Exit(0);
            }
            
            Console.ReadLine();

            Examen.Examen.Finalizar();//NO BORRAR ESTA LINEA 
         
       }
    }
}
