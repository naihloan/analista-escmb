using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuarezBenjaminRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar la clase alumno en un objeto
            Alumno miAlumno = new Alumno();

            // ingresar la dara del estudiante
            Console.WriteLine("Ingrese el Nombre del alumno:");
            miAlumno.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido del alumno:");
            miAlumno.Apellido = Console.ReadLine();

            // transformar a int
            Console.WriteLine("Ingrese el DNI del alumno:");
            miAlumno.DNI = int.Parse(Console.ReadLine());

            // transformar a int
            Console.WriteLine("Ingrese la edad del alumno:");
            miAlumno.Edad = int.Parse(Console.ReadLine());

            // ingrese las 3 notas
            Console.WriteLine("Ingrese la nota del 1er examen:");
            miAlumno.Notas[0] = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del 2do examen:");
            miAlumno.Notas[1] = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del 3er examen:");
            miAlumno.Notas[2] = decimal.Parse(Console.ReadLine());

            // ver como hacer text wrapping
            // Console.WriteLine($"El resultado para {0} {1} es: {2}.", miAlumno.Nombre, miAlumno.Apellido, miAlumno.Resultado );
            Console.WriteLine($"El resultado para {miAlumno.Nombre} {miAlumno.Apellido} es: {miAlumno.MostrarResultado()}.");

            Console.ReadLine();
        }
    }
}
