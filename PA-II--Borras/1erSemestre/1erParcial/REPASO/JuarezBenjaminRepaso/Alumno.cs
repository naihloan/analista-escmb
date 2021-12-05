using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuarezBenjaminRepaso
{
    public class Alumno : Persona
    {
        // esta es la instanciación o el constructor a partir de la clase Alumno
        public Alumno()
        {
            Notas = new decimal[3];
        }

        public decimal[] Notas { get; set; }
        public string Resultado { get; set; }

        public string MostrarResultado()
        {
            // probar bucle for?
            if (Notas[0] < 4 || Notas[1] < 4 || Notas[2] < 4)
            {
                Resultado = "Reprobado";
            }
            else
            {
                decimal acumNotas = 0;

                for (int i = 0; i < Notas.Length; i++)
                {
                    acumNotas = acumNotas + Notas[i];
                }
                decimal promedio = acumNotas / 3;

                if (promedio >= 7)
                {
                    Resultado = "Sobresaliente";
                }
                else
                {
                    Resultado = "Aprobado";
                }
            }
            return Resultado;
        }
    }
}
