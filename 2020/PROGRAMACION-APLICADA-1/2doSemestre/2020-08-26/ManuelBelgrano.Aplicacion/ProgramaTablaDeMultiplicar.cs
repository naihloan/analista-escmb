using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Aplicacion
{
    public class ProgramaTablaDeMultiplicar : IProgramaConsola
    {
        public void IniciarPrograma()
        {
         
            for (var primerFactor = 1; primerFactor < 10; primerFactor++)
            {

                Console.WriteLine("-----------------------tabla del {0:00}---------------------", primerFactor);
                
                for (var segundoFactor = 1; segundoFactor <= 10; segundoFactor++)
                {

                    var resultado = primerFactor * segundoFactor;
                    Console.WriteLine("{0:00} X {1:00} = {2:00} ", primerFactor, segundoFactor, resultado);
                }
                Console.WriteLine("---------------------------------------------------------");
            }

        }
    }
}
