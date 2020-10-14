using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringVector = File.ReadAllLines("palabras.txt");
            int indice = -1;
            for (int i = 0; i < stringVector.Length; i++) {
                if (stringVector[i].ToLower() == "abazón") {
                    indice = i;
                    break;
                }
            }
            if (indice >= 0)//if(indice != -1)
            {
                Console.WriteLine("Se encontró la palabra en la posición {0}", indice);
            }
            else {
                Console.WriteLine("No se ha encontrao la palabra");

            }
            Console.ReadLine();
            //para obtener la posición actual del cursor en la consola
            var posLeft = Console.CursorLeft;
            var posTop = Console.CursorTop;
            Console.WriteLine(  "Linea 1");
            Console.WriteLine("Linea 2");
            Console.WriteLine("Linea 2");
            Console.ReadLine();
            Console.SetCursorPosition(posLeft, posTop);
            Console.WriteLine("Sobre escribo lo que estaba antes.");



            Console.ReadLine();
        }
    }
}
