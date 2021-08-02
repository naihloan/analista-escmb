using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Aplicacion
{
    public class ProgramaFactorial : IProgramaConsola
    {
        public void IniciarPrograma()
        {
            Console.WriteLine("Bienvenido al programa del cálculo factorial");
            int numero = Helper.IngresoInt(1, 24, "Ingrese un número entre 1 y 24");
            /*
             El factorial de un entero positivo n, 
            el factorial de n o n! se define en principio como el producto de todos los números enteros positivos 
            desde 1 (es decir, los números naturales) hasta n. Por ejemplo:
                5!= 1 * 2 * 3 * 4 * 5
                3! = 1 * 2 * 3
                7! = 1 * 2 * 3 * 4 * 5 * 6 * 7
            
             usar un bucle for para realizar los cálculos, mostrar el resultado y agregar la opción
            del ProgramaFactorial, en el programa programaMenu
             */
            int factorial = 1;
            for (var contador = 1; contador <= numero; contador++) {
                factorial = factorial * contador;
            }
            Console.WriteLine("El Factorial de {0} es {1}", numero, factorial);



        }
    }
}
