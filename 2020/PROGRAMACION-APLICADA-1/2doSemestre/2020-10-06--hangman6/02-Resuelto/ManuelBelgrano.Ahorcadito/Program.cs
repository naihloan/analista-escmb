using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManuelBelgrano.Ahorcadito
{
    public class Program
    {
        static void Main(string[] args)
        {

            


            var sb = new StringBuilder();
            sb.AppendLine("---Bienvenides al Ahoracadito---");
            sb.AppendLine("Ingrese la opción de dificultad:");
            sb.AppendLine("1 - Basico");
            sb.AppendLine("2 - Medio");
            sb.AppendLine("3 - Avanzado");
            sb.AppendLine("4 - Super Heavy");
            var mensaje = sb.ToString();
            int opcionMenu = Helper.IngresoInt(0, 5, mensaje, true);
            Juego.Nivel nivel;
            switch (opcionMenu)
            {
                case 1:
                    nivel = Juego.Nivel.Basico;
                    break;
                case 2:
                    nivel = Juego.Nivel.Medio;
                    break;
                case 3:
                    nivel = Juego.Nivel.Avanzado;
                    break;
                default:
                    nivel = Juego.Nivel.SuperHeavy;
                    break;
            }


            var nombre = Helper.IngresoString("Ingrese El nombre de le jugadore");

            var miJuego = new Juego(nombre, nivel);
            Console.WriteLine($"El jugador es {miJuego.NombreJugador} ");
            miJuego.Empezar();
             

            Console.ReadLine();
        }
    }
}
