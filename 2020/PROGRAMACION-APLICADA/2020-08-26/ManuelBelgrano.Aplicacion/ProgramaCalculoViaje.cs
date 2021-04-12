using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Aplicacion
{
    public class ProgramaCalculoViaje : IProgramaConsola
    {
        public void IniciarPrograma()
        {
            double distancia, montoPeajes, precioCombustible, rendimiento, resultado;
           
            distancia = Helper.IngresoDouble("Ingrese la distancia a recorrer:");
            
            montoPeajes = Helper.IngresoDouble(0,double.MaxValue ,"Ingrese el monto de peajes en la ruta (puede ser 0 «cero»):");
            precioCombustible = Helper.IngresoDouble(1, double.MaxValue, "Ingrese el precio por litro de combustible");
            rendimiento = Helper.IngresoDouble(1, double.MaxValue, "Ingrese el rendimiento del vehículo, es decir, cuántos kilómetros recorre por litro de combustible:");
            resultado = (distancia / rendimiento) * precioCombustible + montoPeajes;
            Console.WriteLine("El monto a gastar es:");
            Console.WriteLine(resultado);
        }
    }
}
