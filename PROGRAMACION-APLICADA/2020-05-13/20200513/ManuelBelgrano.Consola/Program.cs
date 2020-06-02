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
        static List<string> notasPermitidas = new List<string>() { "C", "D", "E", "F", "G", "A", "B", "S" };
        static string IngresoNota()
        {
            string ingreso;
            bool esValido = false;
            do
            {
                Console.WriteLine("ingrese la nota: C, D, E, F, G, A, B ó 'S' salir");
                ingreso = Console.ReadKey().KeyChar.ToString();
                ingreso = ingreso.ToUpper();
                Console.WriteLine();
                for (int i = 0; i < 8; i = i + 1)
                {
                    if (notasPermitidas[i] == ingreso)
                    {
                        esValido = true;
                        break;
                    }
                }
            } while (esValido == false);
            return ingreso;
        }
        static void Main(string[] args)
        {
            Reproductor miPlayer = new Reproductor();
            Console.WriteLine("Bienvenidxs al piano mágico");
            string nota = IngresoNota();
            miPlayer.Play(nota);
            Console.ReadLine();
        }
    }
}
