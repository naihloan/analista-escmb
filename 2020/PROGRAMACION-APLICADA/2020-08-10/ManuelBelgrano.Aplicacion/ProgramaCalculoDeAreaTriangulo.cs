using ManuelBelgrano.Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Consola
{
    public class ProgramaCalcularAreaTriangulo : IProgramaConsola
    {
        public void IniciarPrograma()
        {
            Console.WriteLine("Bienvenido al programa para calcular el área de un triángulo");
            double baseTriangulo, alturaTriangulo, area;
            baseTriangulo = Helper.IngresoDouble("Ingrese La Base");
            alturaTriangulo = Helper.IngresoDouble("Ingrese La altura");
            area = CalcularArea(baseTriangulo, alturaTriangulo);
            Console.WriteLine("El resultado del área es:");
            Console.WriteLine(area);
        }

        private double CalcularArea(double pBase, double pAltura)
        {
            double area = pBase * pAltura / 2;
            return area;
        }
    }
}
