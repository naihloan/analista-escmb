using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Consola
{
    class ProgramaPitagoras
    {
        public void IniciarPrograma() {
            Console.WriteLine("Bienvenido al programa de pitágoras");
            double HP, CA, CO;
            string ingreso = null;
            while (double.TryParse(ingreso, out CA) == false) {
                Console.WriteLine("Ingrese el Cateto Adyacente");
                ingreso = Console.ReadLine();
            }
            ingreso = null;
            while (double.TryParse(ingreso, out CO) == false)
            {
                Console.WriteLine("Ingrese el Cateto Opuesto");
                ingreso = Console.ReadLine();
            }
            CA = Math.Pow(CA, 2);
            CO = Math.Pow(CO, 2);
            HP = Math.Sqrt(CA + CO);
            Console.WriteLine("El resultado de la Hipotenusa es:");
            Console.WriteLine(HP);
        }
    }
}
