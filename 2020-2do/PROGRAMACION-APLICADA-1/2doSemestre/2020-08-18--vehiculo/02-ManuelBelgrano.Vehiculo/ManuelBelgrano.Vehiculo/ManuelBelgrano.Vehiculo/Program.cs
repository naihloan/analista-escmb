using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingresoFinalizar = null;
            while (ingresoFinalizar != "S" && ingresoFinalizar != "s")
            {
                Console.Clear();
                IVehiculo vehiculo = null;
                int opcion;
                while (int.TryParse(Console.ReadLine(), out opcion) == false)
                {
                    Console.WriteLine("Ingrese la opción deseada para los vehículos\n\t1=Camión\n\t2=Camioneta\n\t3=Auto");
                }
                switch (opcion)
                {
                    case 1:
                        vehiculo = new Camion();
                        break;
                    case 2:
                        vehiculo = new Camioneta();
                        break;
                    case 3:
                        vehiculo = new Auto();
                        break;
                    default:
                        Console.WriteLine(string.Format("La opción {0} que usted ingresó, no es válida", opcion));
                        return;
                        break;
                }

                vehiculo.MostrarForma();
                //Solicitar que se ingrese A para acelerar si el vehículo no ha sido "acelerado" 
                //nunca, e invocar al método vehiculo.Acelerar(), 
                string ingreso = null;
                while (ingreso != "A" && ingreso != "a")
                {
                    Console.WriteLine("Ingrese A para acelerar el vehículo");
                    ingreso = Console.ReadLine();
                }
                vehiculo.Acelerar();
                while (ingreso != "F" && ingreso != "f")
                {
                    Console.WriteLine("Ingrese F para frenar el vehículo");
                    ingreso = Console.ReadLine();
                }
                vehiculo.Frenar();

                Console.WriteLine("Ingrese enter para probar otro vehículo, o S para finalizar el programa");
                ingresoFinalizar = Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
