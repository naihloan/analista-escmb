using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace ManuelBelgrano.Aplicacion
{
    public class ProgramaTeleprompter : IProgramaConsola
    {
        public void IniciarPrograma()
        {
            Console.Clear();
            string[] text = File.ReadAllLines("prompt.txt");
            var tamanio = text.Length;
            Console.WriteLine(text);

            Console.ReadLine;
            
          

            
        }
    }
}
