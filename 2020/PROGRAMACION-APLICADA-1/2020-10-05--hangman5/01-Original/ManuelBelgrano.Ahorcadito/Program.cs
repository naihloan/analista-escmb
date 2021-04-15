using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Ahorcadito
{
    public class Program
    {
        static void Main(string[] args)
        {

           

            var sb = new StringBuilder();
            sb.AppendLine("------Bienvenidos al Ahorcadito-----");
            sb.AppendLine("Ingrese el nivel de dificultad:");
            sb.AppendLine("1 = Basico");
            sb.AppendLine("2 = Medio");
            sb.AppendLine("3 = Avanzado");
            sb.AppendLine("4 = Super Heavy");
            string mensaje = sb.ToString();

            var nivel = Helper.IngresoInt(0, 5, mensaje, true);
            Juego.Nivel nivelEnum = Juego.Nivel.Basico;
            switch (nivel)
            {
                case 1:
                    nivelEnum = Juego.Nivel.Basico;
                    break;
                case 2:
                    nivelEnum = Juego.Nivel.Medio;
                    break;
                case 3:
                    nivelEnum = Juego.Nivel.Avanzado;
                    break;
                default:
                    nivelEnum = Juego.Nivel.SuperHeavy;
                    break;
            }
            var nombreDelJugador = Helper.IngresoString("Ingrese El nombre de le jugadore");
            var miJuego = new Juego(nombreDelJugador, nivelEnum);

            //Console.WriteLine($"Bienvenido {miJuego.NombreJugador} a jugar!!!");


            //miJuego.MostrarEspacios();

            Console.ReadLine();
        }
    }
}
