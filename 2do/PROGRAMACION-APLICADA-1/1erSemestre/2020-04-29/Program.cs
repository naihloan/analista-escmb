using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            int Do = 523, Re = 587, Mi = 656, Fa = 699, Sol = 784, La = 880, Si = 988;
            do
            {
                Console.WriteLine("ingrese la nota: C,D,E,F,G,A,B ó 'S' salir");
                ingreso = Console.ReadLine();
                if (ingreso == "C")
                {
                    Console.Beep(Do, 500);
                }
                if (ingreso == "D")
                {
                    Console.Beep(Re, 500);
                }
                if (ingreso == "E")
                {
                    Console.Beep(Mi, 500);
                }
                if (ingreso == "F")
                {
                    Console.Beep(Fa, 500);
                }
                if (ingreso == "G")
                {
                    Console.Beep(Sol, 500);
                }
                if (ingreso == "A")
                {
                    Console.Beep(La, 500);
                }
                if (ingreso == "B")
                {
                    Console.Beep(Si, 500);
                }
            } while (ingreso != "S");



            /*
            for (int i = 1000; i < 3600; i = i + 1)
            {
                Console.Beep(1000, 100);
            }
            

            Console.WriteLine("Ingresa tu nombre");
            string nombre = Console.ReadLine();
            if (nombre == "javi")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Bienenido: " + nombre);
        Console.WriteLine("presione enter para salir");
            Console.ReadLine(); */
        }
    }
}
