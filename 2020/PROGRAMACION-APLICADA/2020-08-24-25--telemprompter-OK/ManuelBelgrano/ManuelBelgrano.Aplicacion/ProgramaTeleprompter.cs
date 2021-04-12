using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Globalization;

namespace ManuelBelgrano.Aplicacion
{
    /*
     ACTIVIDAD OBLIGATORIA:

Modificar el programa "ProgramaTeleprompter" para que muestre el contenido del archivo "prompt.txt", 
    de manera tal que muestre un máximo de 30 líneas, 
    y se genere un efecto de despazamiento de las mismas 
    (como si fueran los títulos que aparecen al final de una película)
Tags de ayuda:
Console.SetCursorPosition(x,y) (establece la posición del cursor),  
Console.CursorTop (obtiene o establece la posición del cursor en el "eje" y), 
Console.CursorLeft (obtiene o establece la posición del cursor en el "eje" x)
Console.Write(new string(' ', Console.WindowWidth));  (Imprime una serie de espacios en blanco que ocupan todo el ancho de la consola)
     */
    public class ProgramaTeleprompter : IProgramaConsola
    {
        public void IniciarPrograma()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            string[] text = File.ReadAllLines("prompt.txt");
            var cantLineas = 30;
            var tamanio = text.Length - cantLineas;

            for (var i = 0; i <= tamanio; i++)
            {
                Console.SetCursorPosition(0, 0);
                for (var j = 0; j < cantLineas; j++)
                {
                    if (j + i >= text.Length) {
                        break;
                    }
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.CursorTop = Console.CursorTop - 1;

                    var lineaActual = text[i + j];
                    if (string.IsNullOrWhiteSpace(lineaActual) == false)
                    {
                        var tam2 = lineaActual.Length;
                        for (var k = 0; k < tam2; k++)
                        {
                            Console.Write(lineaActual[k]);                            
                        }
                        Console.Write(Convert.ToChar(10));
                    }
                    else
                    {
                        Console.WriteLine(lineaActual);
                    }           
                }

                Thread.Sleep(100);
            }


        }
    }
}
