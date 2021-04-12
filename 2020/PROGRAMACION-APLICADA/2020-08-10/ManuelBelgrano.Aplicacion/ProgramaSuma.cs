using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Aplicacion
{
    public class ProgramaSuma : IProgramaConsola
    {
        public void IniciarPrograma()
        {
            double num1 = Helper.IngresoDouble("Ingrese el primer número");
            double num2 = Helper.IngresoDouble("Ingrese el segundo número");
            double resultado = num1 + num2;
            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
