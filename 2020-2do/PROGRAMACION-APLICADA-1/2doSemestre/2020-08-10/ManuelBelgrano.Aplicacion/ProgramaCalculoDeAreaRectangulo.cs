using ManuelBelgrano.Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Consola
{
    public class ProgramaCalcularAreaRectangulo : IProgramaConsola
    {
        public void IniciarPrograma()
        {
            Console.WriteLine("Bienvenido al programa para calcular el área de un rectángulo");
            double baseRectangulo, alturaRectangulo, area;
            baseRectangulo = Helper.IngresoDouble("Ingrese La Base");
            alturaRectangulo = Helper.IngresoDouble("Ingrese La altura");
            area = CalcularArea(baseRectangulo, alturaRectangulo);
            Console.WriteLine("El resultado del área es:");
            Console.WriteLine(area);
        }

        private double CalcularArea(double pBase, double pAltura)
        {
            double area = pBase * pAltura;
            return area;
        }
    }
}
