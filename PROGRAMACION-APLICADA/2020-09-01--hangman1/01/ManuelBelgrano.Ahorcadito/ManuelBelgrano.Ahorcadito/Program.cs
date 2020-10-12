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
            var miJuego = new Juego();

            //Ingreso la palabra
            miJuego.Palabra = Helper.IngresoString("Ingrese la palabra");

            //Ingresar el nombre del jugadore            
            miJuego.NombreJugador = Helper.IngresoString("Ingrese su nombre");


            Console.WriteLine($"El jugador es: {miJuego.NombreJugador}");
            Console.WriteLine($"y la palabra es: {miJuego.Palabra}");

            

            Console.ReadLine();

        }
    }
}
