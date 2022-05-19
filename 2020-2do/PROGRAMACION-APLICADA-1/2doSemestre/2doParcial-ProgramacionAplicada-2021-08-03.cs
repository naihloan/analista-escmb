using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ManuelBelgrano.Ahorcadito;

namespace ManuelBelgrano.SegundoParcialPA1
{
	class Program
    {
        static void Main(string[] args)
        {
            Examen.Examen.Empezar();//NO BORRAR ESTA LINEA //ESCRIBE TU CODIGO AQUI:

            string[] listaDePalabras = File.ReadAllLines("Palabras.txt");

            for(var i=15; i <= 25; i++)
            {
                Console.WriteLine(listaDePalabras[i]);
            }

            Random r = new Random();
            int n = r.Next(0, listaDePalabras.Length);
            Console.WriteLine(listaDePalabras[n]);

            Console.WriteLine("Usuario: ingrese un valor en texto en mayuscula o minuscula: ");
            Console.WriteLine("'N' o 'n'; ");
            Console.WriteLine("'L' o 'l'; ");
            Console.WriteLine("o cualquier otra tecla para finalizar el programa.");

            var texto = Helper.IngresoString("Ingrese ");
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
