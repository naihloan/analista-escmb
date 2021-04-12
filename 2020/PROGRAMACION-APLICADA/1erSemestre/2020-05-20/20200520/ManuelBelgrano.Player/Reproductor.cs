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

        public void Play(string clave)
        {
            bool contieneLaClave = notas.ContainsKey(clave);
            if (contieneLaClave) {
                Console.Beep(notas[clave], 500);
                Grabar(clave);
                Console.WriteLine();
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
