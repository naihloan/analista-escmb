using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManuelBelgrano.Player;

namespace ManuelBelgrano.Consola
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la opción deseada:");
            Console.WriteLine("1 - Programa Piano");
            Console.WriteLine("2 - Pitágoras");

            string ingreso = Console.ReadLine();
            int opcion = int.Parse(ingreso) ;
            
            switch (opcion)
            {
                case 1:
                    //abrimos el progama piano
                    ProgramaPiano programa = new ProgramaPiano();                    
                    programa.IniciarPrograma();
                    break;
                case 2:
                    Console.WriteLine("Otro programa");
                    break;
                default:
                    ProgramaPitagoras programa2 = new ProgramaPitagoras();
                    programa2.IniciarPrograma();
                    break;
            }
            Console.ReadLine();
        }
    }
}
