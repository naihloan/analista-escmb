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
                Console.WriteLine("ingrese la nota: C, D, E, F, G, A, B ó 'S' salir");
                ingreso = Console.ReadLine();//F9 para poner el punto de interrupción
                                             //F10 para ir paso a paso por instrucción o F5 para continuar
                bool ingresoCorrectamente = false; 
                if (ingreso == "C" || ingreso == "c") //ALT + 124 (operador OR)
                {
                    Console.Beep(Do, 500);
                    ingresoCorrectamente = true;
                }
                if (ingreso == "D" || ingreso == "d")
                {
                    Console.Beep(Re, 500);
                    ingresoCorrectamente = true;
                }
                if (ingreso == "E" || ingreso == "e")
                {
                    Console.Beep(Mi, 500);
                    ingresoCorrectamente = true;
                }
                if (ingreso == "F" || ingreso == "f")
                {
                    Console.Beep(Fa, 500);
                    ingresoCorrectamente = true;
                }
                if (ingreso == "G" || ingreso == "g")
                {
                    Console.Beep(Sol, 500);
                    ingresoCorrectamente = true;
                }
                if (ingreso == "A" || ingreso == "s")
                {
                    Console.Beep(La, 500);
                    ingresoCorrectamente = true;
                }
                if (ingreso == "B" || ingreso == "b")
                {
                    Console.Beep(Si, 500);
                    ingresoCorrectamente = true;
                }

                if (ingreso == "S" || ingreso == "s")
                {                    
                    ingresoCorrectamente = true;
                }
                //agregar el código para que cuando el ingreso == "S" no muestre el mensaje de advertencia
                if (ingresoCorrectamente == false) {
                    Console.WriteLine("Ha ingresado un caracter no válido");
                }

            } while (ingreso != "S");

            Console.WriteLine("Presione Enter para Salir");
            Console.ReadLine();
        }
    }
}
