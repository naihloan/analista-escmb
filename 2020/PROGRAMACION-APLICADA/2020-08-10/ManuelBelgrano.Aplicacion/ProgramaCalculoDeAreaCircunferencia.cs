using ManuelBelgrano.Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Consola
{
    public class ProgramaCalculoDeAreaCircunferencia : IProgramaConsola
    {
        public void IniciarPrograma()
        {
            Console.WriteLine("Bienvenido al programa para calcular el área de una Circunferencia");
            double radio, area;
            //string ingreso = null;
            //while (double.TryParse(ingreso, out radio) == false)
            //{
            //    Console.WriteLine("Ingrese Lel radio");
            //    ingreso = Console.ReadLine();
            //}
            Console.WriteLine("Ingrese el radio");
            radio = Helper.IngresoDouble();

            area = CalcularArea(Math.PI, radio);
            Console.WriteLine("El resultado del área es:");
            Console.WriteLine(area);
        }

        private double CalcularArea(double pi, double radio)
        {
            double area = pi * radio * radio;
            return area;
        }
    }
}
