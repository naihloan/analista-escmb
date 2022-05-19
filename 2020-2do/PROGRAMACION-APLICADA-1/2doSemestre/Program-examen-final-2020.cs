using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] primerExamen = new decimal[10];
            decimal[] segundoExamen = new decimal[10];
            decimal[] tercerExamen = new decimal[10];
            string[] nombres = new string[10];
            decimal[] notaPromedio = new decimal[10];


            Console.WriteLine("Bienvenidos al programa del examen final!!!");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");

            //pido los datos por consola

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nIngrese el nombre del estudiante");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la nota del primer examen");
                primerExamen[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del segundo examen");
                segundoExamen[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del tercer examen");
                tercerExamen[i] = Convert.ToInt32(Console.ReadLine());
            }
            //hago el calculo del promedio
            for(int i = 0; i < 10; i++)
            {

                notaPromedio[i] = Math.Round(primerExamen[i] + segundoExamen[i] + tercerExamen[i]) / 10;
            }
            //muestro por consola los resultados
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nEl alumno: "+ nombres[i]);
                Console.WriteLine("obtuvo un: "+ primerExamen[i] + " en el primer examen");
                Console.WriteLine("obtuvo un: " + segundoExamen[i] + " en el segundo examen");
                Console.WriteLine("obtuvo un: " + tercerExamen[i] + " en el tercer examen");
                Console.WriteLine("El promedio es: " + notaPromedio[i]);
                if (notaPromedio[i] >= 6)
                {
                    Console.WriteLine("El alumno " + nombres[i] + " está aprobado");
                    
                }
                else
                {
                    Console.WriteLine("El alumno " + nombres[i] + " está desaprobado");
                    
                }
            }
            
            Console.ReadLine();

        }
    }
}
