using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Ahorcadito
{
    public static class Helper
    {
        public static string IngresoString(string mensaje)
        {
            string ingreso = null;
            while (string.IsNullOrWhiteSpace(ingreso))
            {
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
            }
            return ingreso;
        }
    }
}
