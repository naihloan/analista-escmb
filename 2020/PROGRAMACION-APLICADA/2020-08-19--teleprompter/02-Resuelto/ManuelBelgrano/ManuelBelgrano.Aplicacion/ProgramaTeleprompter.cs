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
            
            for (var i = 0; i < tamanio; i++) {
                var lineaActual = text[i];
                if (i % 30 == 0) {
                    //Console.CursorTop
                    Console.SetCursorPosition(0, 1);
                    Console.Write("                                                                              ");
                    Console.SetCursorPosition(0, 1);
                }
                

                if (string.IsNullOrWhiteSpace(lineaActual) == false)
                {
                    var tam2 = lineaActual.Length;
                    for (var j = 0; j < tam2; j++) {
                        Console.Write(lineaActual[j]);
                        Thread.Sleep(50);
                    }
                    Console.Write(Convert.ToChar(10));
                }
                else {
                    Console.WriteLine(lineaActual);
                }
                                
                Thread.Sleep(500);
            }

            
        }
    }
}
