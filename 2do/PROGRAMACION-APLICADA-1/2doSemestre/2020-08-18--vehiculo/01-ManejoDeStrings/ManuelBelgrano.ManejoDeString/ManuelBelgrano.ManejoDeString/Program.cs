using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.ManejoDeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string miString = "Mis archivos están en el direcotorio c:\\Mis Archivos";
            //string miString = "El personaje dijo de forma irónica \"hola\"";
            ///string miString = "Querido hermano:\n\t\t\tTe escribo esta carta...";
            //string miString = string.Format("{0}", "hola");
            //string miString = string.Format("Modelo:{1} - Marca {0}", "BMW",1990);
            string miString = string.Format("Modelo:{1} - Marca {0} - Precio: {2:C}", "BMW", 1990,195000.25);
            Console.WriteLine(miString);
            Console.ReadLine();
        }
    }
}
