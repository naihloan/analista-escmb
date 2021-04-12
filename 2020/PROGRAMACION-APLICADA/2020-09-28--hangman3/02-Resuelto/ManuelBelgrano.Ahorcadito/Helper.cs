using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Ahorcadito
{
    public static class Helper
    {
        public static string IngresoString(string mensaje)
        {
            string ingreso = null;
            while (string.IsNullOrWhiteSpace(ingreso))
            {
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
            }
            return ingreso;
        }
        public static double IngresoDouble()
        {
            double salida;
            salida = IngresoDouble("Ingrese un número");
            return salida;
        }
        public static double IngresoDouble(string mensaje)
        {
            double salida;
            salida = IngresoDouble(double.MinValue, double.MaxValue, mensaje);
            return salida;
        }
        public static double IngresoDouble(double valordesde, double valorHasta)
        {
            double salida;
            salida = IngresoDouble(valordesde, valordesde, $"Ingrese un valor entre {valordesde} y {valorHasta}");
            return salida;
        }
        public static double IngresoDouble(double valordesde, double valorHasta, string mensaje)
        {
            double salida;
            salida = IngresoDouble(valordesde, valorHasta, mensaje, false);
            return salida;
        }
        public static double IngresoDouble(double valordesde, double valorHasta, string mensaje, bool limpiarPantalla)
        {
            double salida;
            if (limpiarPantalla == true)
            {
                Console.Clear();
            }

            Console.WriteLine(mensaje);
            string ingreso = Console.ReadLine();
            while (double.TryParse(ingreso, out salida) == false || (salida < valordesde || salida > valorHasta))
            {
                if (limpiarPantalla == true)
                {
                    Console.Clear();
                }
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
            }

            return salida;
        }

        public static int IngresoInt()
        {
            int salida;
            salida = IngresoInt("El valor ingresado no es numérico. Ingrese nuevamente");
            return salida;
        }
        public static int IngresoInt(string mensaje)
        {
            int salida = IngresoInt(int.MinValue, int.MaxValue, $"Ingrese un valor Numérico");
            return salida;
        }
        public static int IngresoInt(int valordesde, int valorHasta, string mensaje)
        {
            int salida = IngresoInt(valordesde, valorHasta, mensaje, false);
            return salida;
        }
        public static int IngresoInt(int valordesde, int valorHasta)
        {
            return IngresoInt(valordesde, valorHasta, $"Ingrese un valor entre {valordesde} y {valorHasta}");
        }
        public static int IngresoInt(int valordesde, int valorHasta, string mensaje, bool limpiarPantalla)
        {
            int salida;
            if (limpiarPantalla == true)
            {
                Console.Clear();
            }

            Console.WriteLine(mensaje);
            string ingreso = Console.ReadLine();
            while (int.TryParse(ingreso, out salida) == false || (salida <= valordesde || salida >= valorHasta))
            {
                if (limpiarPantalla == true)
                {
                    Console.Clear();
                }
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
            }

            return salida;
        }





    }
}
