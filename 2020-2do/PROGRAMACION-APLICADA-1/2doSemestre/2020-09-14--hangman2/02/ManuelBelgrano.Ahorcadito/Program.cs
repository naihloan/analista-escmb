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

            Console.WriteLine("------Bienvenidos al Ahorcadito-----");

            var miJuego = new Juego();


            var palabra = miJuego.GenerarPalabra(5);
            Console.WriteLine(palabra);
            

            miJuego.NombreJugador = Helper.IngresoString("Ingrese El nombre de le jugadore");

            miJuego.Palabra = Helper.IngresoString("Ingrese la palabra");



            Console.WriteLine($"El jugador es {miJuego.NombreJugador} ");
            Console.WriteLine($"y la palabra es: {miJuego.Palabra}");

            miJuego.MostrarEspacios();

            Console.ReadLine();
        }
    }
}
