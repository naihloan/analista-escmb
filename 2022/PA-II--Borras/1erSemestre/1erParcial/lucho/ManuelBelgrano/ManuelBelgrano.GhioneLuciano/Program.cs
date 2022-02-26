using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.GhioneLuciano
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno miAlumno = new Alumno();

            Console.WriteLine("Ingrese el DNI:");
            miAlumno.DNI = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre:");
            miAlumno.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido:");
            miAlumno.Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la edad:");
            miAlumno.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del primer examen:");
            miAlumno.Notas[0] = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del segundo examen:");
            miAlumno.Notas[1] = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del tercer examen:");
            miAlumno.Notas[2] = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado para {miAlumno.Nombre} {miAlumno.Apellido} es:");
            Console.WriteLine(miAlumno.MostrarResultado());
            

            Console.ReadLine();

        }

    }











}
