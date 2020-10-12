using ManuelBelgrano.Consola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Aplicacion
{
    public class ProgramaMenu : IProgramaConsola
    {
        public void IniciarPrograma()
        {
            
            int numeroDeOpcion;
            //Caracteres de escape \ (ALT + 92)
            //Console.WriteLine("Probando caracteres de escape \nEsto esta en una nueva linea ");
            //Console.WriteLine("Probando caracteres de escape  \rEsto esta en una nueva linea ");
            //Console.WriteLine("Probando caracteres de escape:  \tEsto esta tabulado ");
            //Console.WriteLine("Probando caracteres de escape:  \t\tEsto esta más tabulado ");
            //Console.WriteLine("Probando caracteres de escape:  \\ esto es una barra invertida ");
            //Console.WriteLine("Probando caracteres de escape:  \" esto es una comilla doble ");
            numeroDeOpcion = Helper.IngresoInt(1, 10, 
                "Ingrese la opción deseada: \n" +
                "\t1 - Programa Login \n" +
                "\t2 - Programa Rectángulo \n" +
                "\t3 - Programa Triángulo \n " +
                "\t4 - Programa Circunferencia \n" +
                "\t5 - Programa CalculoViaje \n" +
                "\t6 - Programa Factorial\n" +
                "\t7 - Programa Tabla de multiplicar\n" +
                "\t8 - Programa Suma\n" +
                "\t9 - Programa Teleprompter\n", true);
            //Declaro la variable programa del tipo IProgramaConsola
            IProgramaConsola programa = null;
            switch (numeroDeOpcion)
            {
                case 1:
                    programa = new ProgramaLogin();                    
                    break;
                case 2:
                    programa = new ProgramaCalcularAreaRectangulo();                    
                    break;
                case 3:
                    programa = new ProgramaCalcularAreaTriangulo();
                    break;
                case 4:
                    programa = new ProgramaCalculoDeAreaCircunferencia();
                    break;
                case 5:
                    programa = new ProgramaCalculoViaje();
                    break;
                case 6:
                    programa = new ProgramaFactorial();
                    break;
                case 7:
                    programa = new ProgramaTablaDeMultiplicar();
                    break;
                case 8:
                    programa = new ProgramaSuma();
                    break;
                case 9:
                    programa = new ProgramaTeleprompter();
                    break;
                default:
                    Console.WriteLine("La opción no es correcta.");
                    break;
            }
            programa.IniciarPrograma();
        }
    }
}
