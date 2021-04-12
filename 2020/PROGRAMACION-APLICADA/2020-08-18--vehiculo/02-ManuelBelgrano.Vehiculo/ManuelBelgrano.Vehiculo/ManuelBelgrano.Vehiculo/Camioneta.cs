using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManuelBelgrano.Vehiculo
{
    public class Camioneta : IVehiculo
    {
        public void TocarBocina() {
            Console.Beep(1270, 500);
            Thread.Sleep(250);
            Console.Beep(1270, 500);
        }
        public void Acelerar()
        {
            Console.Beep(1270, 2000);
        }

        public void Frenar()
        {
            Console.Beep(5270, 3000);
        }

        public void MostrarForma()
        {
            Console.WriteLine("           ________    ");
            Console.WriteLine("       ____|    |__|__i  ");
            Console.WriteLine("      |               < ");
            Console.WriteLine("      |--O---------O--  ");
        }
    }
}
