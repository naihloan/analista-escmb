using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.EjemploClases
{
    class Program
    {
        static void Main(string[] args)
        {
            string primerNombre;
            string segundoNombre;
            string nombreCompleto;
            int edad;
            primerNombre = "Javier"; //este es mi primer nombre
            segundoNombre = "MC  Donald's";
            edad = -1;
            nombreCompleto = primerNombre
                + " " +
                segundoNombre;

            if (edad >= 21)
            {
                Console.WriteLine("Puede tomar alcohol");
            }
            else if (edad >= 18)
            {
                Console.WriteLine("Puede fumar");
            }
            else if (edad < 18 && edad > 3)
            {
                Console.WriteLine("Puede jugar a la pelota o al tejo");
            }
            else
            {
                Console.WriteLine("No cumple con las condiciones ante4riores");
            }

            if (primerNombre == "Javier")
            {
                Console.WriteLine("El nombre es copado");
            }

            Console.WriteLine("El nombre es copado");

            Console.WriteLine(nombreCompleto);

            switch (edad)
            {
                case 3:
                    Console.WriteLine("Ingresó 3");
                    break;
                case 1:
                    Console.WriteLine("Ingresó 1");
                    break;
                case 2:
                    Console.WriteLine("Ingresó 2");
                    break;
                default:
                    Console.WriteLine("No Ingresó ni 1 ni 2 ni 3");
                    break;
            }
            //Vectores

            decimal[] precios;
            precios = new decimal[3]; //le indico la cantidad de elementos que va a tener ese vector
            precios[0] = 2.40m;
            precios[1] = 30m;
            precios[2] = 9.55m;
            precios[3] = 10m;

            string[] ciudades = new string[] { "Córdoba", "Santiago" };

            Console.WriteLine(ciudades[0]);









            /*


            int num1 = 3; int num2 = num1;

            Console.WriteLine($"num1 = {num1} ");
            Console.WriteLine($"num2 = {num2}");
            num1 = 4;
            Console.WriteLine($"num1 = {num1} ");
            Console.WriteLine($"num2 = {num2}");


            var automovil1 = new Automovil();
            automovil1.Llantas = 9;
            automovil1.EstaEncendido = true;
            Automovil automovil2 = automovil1;

            Console.
                 WriteLine
                 (
                $"automovil1 = {automovil1.Llantas} "
                );
            //Console.WriteLine($"automovil2 = {automovil2.llantas}");

            //automovil2.llantas = 16;

            //Console.WriteLine($"automovil1 = {automovil1.llantas} ");
            //Console.WriteLine($"automovil2 = {automovil2.llantas}");

            */


            Console.ReadLine();

        }
    }
}
