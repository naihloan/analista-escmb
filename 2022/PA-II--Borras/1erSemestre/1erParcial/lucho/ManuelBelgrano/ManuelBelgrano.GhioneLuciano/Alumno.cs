using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.GhioneLuciano
{
    class Alumno : Persona
    {

        public Alumno()
        {
            Notas = new decimal[3];
        }
        public string Resultado { get; set; }
        public decimal[] Notas { get; set; }

        public string MostrarResultado()
        {

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
