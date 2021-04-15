using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Player
{
    public class Reproductor
    {
        private static Dictionary<string, int> notas;
        private static List<string> ingresos;
        public Reproductor()
        {
            notas = new Dictionary<string, int>();
            notas["C"] = 523;
            notas["D"] = 587;
            notas["E"] = 656;
            notas["F"] = 699;
            notas["G"] = 784;
            notas["A"] = 880;
            notas["B"] = 988;
            ingresos = new List<string>();
        }

        public void Play(string nota)
        {            
            switch (nota)
            {
                case "C":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    break;
                case "D":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    break;
                case "E":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    break;
                case "F":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    break;
                case "G":
                    Console.Beep(notas[nota], 500);
                    break;
                case "A":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    break;
                case "B":
                    Console.Beep(notas[nota], 500);
                    Console.WriteLine();
                    break;
                case "S":
                    Console.WriteLine();
                    break;
            }            
        }
        public void Grabar(string nota)
        {
            ingresos.Add(nota);
        }
        public void ReproducirGrabacion()
        {
            var hasta = ingresos.Count;
            for (var i = 0; i < hasta; i = i + 1)
            {
                string miNota = ingresos[i];
                Play(miNota);
            }
        }
    }
}
