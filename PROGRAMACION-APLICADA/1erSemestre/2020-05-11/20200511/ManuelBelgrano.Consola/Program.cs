using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Consola
{
    //funciones de texto Console.ReadKey().KeyChar.ToString()
    class Program
    {
        private static Dictionary<string, int> notas = new Dictionary<string, int>();
        private static List<string> ingresos = new List<string>();
        static bool Play(string nota)
        {
            bool ingresoCorrectamente = false;
            switch (nota)
            {
                case "C":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    ingresoCorrectamente = true;
                    break;
                case "D":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    ingresoCorrectamente = true;
                    break;
                case "E":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    ingresoCorrectamente = true;
                    break;
                case "F":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    ingresoCorrectamente = true;
                    break;
                case "G":
                    Console.Beep(notas[nota], 500);
                    ingresoCorrectamente = true;
                    break;
                case "A":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    ingresoCorrectamente = true;
                    break;
                case "B":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    ingresoCorrectamente = true;
                    break;
                case "S":
                    ingresoCorrectamente = true;
                    Console.WriteLine();
                    break;
            }
            return ingresoCorrectamente;
        }
        static void Grabar(string nota)
        {
            ingresos.Add(nota);
        }

        static void Main(string[] args)
        {
            notas["C"] = 523; notas["D"] = 587; notas["E"] = 656; notas["F"] = 699; notas["G"] = 784; notas["A"] = 880; notas["B"] = 988;
            string ingreso;
            do
            {
                Console.WriteLine("ingrese la nota: C, D, E, F, G, A, B ó 'S' salir");
                ingreso = Console.ReadKey().KeyChar.ToString();//F9 para poner el punto de interrupción
                                                               //F10 para ir paso a paso por instrucción o F5 para continuar
                ingreso = ingreso.Trim();
                ingreso = ingreso.ToUpper();

                bool ingresoCorrectamente = false;
                ingresoCorrectamente = Play(ingreso);

                if (ingresoCorrectamente == false)
                {
                    Console.WriteLine("Ha ingresado un caracter no válido");
                }
                else
                {
                    Grabar(ingreso);
                }

            } while (ingreso != "S");

            ///

            Console.WriteLine("Presione Enter para Salir");
            Console.ReadLine();
        }
    }
}
