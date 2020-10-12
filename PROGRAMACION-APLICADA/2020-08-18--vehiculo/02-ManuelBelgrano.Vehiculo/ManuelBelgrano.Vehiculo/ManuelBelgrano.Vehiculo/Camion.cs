using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Vehiculo
{
    public class Camion : IVehiculo
    {
        public void Acelerar()
        {
            Console.Beep(500, 1000);
        }

        public void Frenar()
        {
            Console.Beep(1500, 500);
        }

        public void MostrarForma()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" __________ _______           ___    ");
            Console.WriteLine(" |                 |  ________|__|__i  ");
            Console.WriteLine(" |                 |--|               < ");
            Console.WriteLine(" --00------------O-- --OO--------O----  ");
            Console.ResetColor();
        }
    }
}
