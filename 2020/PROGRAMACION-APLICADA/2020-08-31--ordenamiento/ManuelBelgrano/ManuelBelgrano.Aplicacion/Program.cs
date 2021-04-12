using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string salir;
            do
            {
                ProgramaMenu menu = new ProgramaMenu();
                menu.IniciarPrograma();
                Console.WriteLine("ingrese salir para terminar, o Enter para continuar");
                salir = Console.ReadLine();
            } while (salir != "salir");

            
        }
    }
}
