EXAMEN FINAL MARZO 2021
=======================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Examen

{
    class Program
    {
        static void Main(string\[\] args)
        {
            var tamanioVector = 10;

            string\[\] alumnos = new string\[tamanioVector\];
            double\[\] nota1erExamen = new double\[tamanioVector\];
            double\[\] nota2doExamen = new double\[tamanioVector\];
            double\[\] nota3erExamen = new double\[tamanioVector\];
            double\[\] promedio = new double\[tamanioVector\];
            string\[\] condicion = new string\[tamanioVector\];

            for (int i = 0; i \< tamanioVector; i++)
            {
                alumnos\[i\] = Helper.IngresoString(\"Ingrese el nombre del Alumno:\");
                nota1erExamen\[i\] = Helper.IngresoDouble(0,10,\"Ingrese la nota del 1er examen\");
                nota2doExamen\[i\] = Helper.IngresoDouble(0, 10, \"Ingrese la nota del 2do examen\");
                nota3erExamen\[i\] = Helper.IngresoDouble(0, 10, \"Ingrese la nota del 3er examen\");
                Console.Clear();
            }

            for (int i = 0; i \< tamanioVector; i++)
            {
                promedio\[i\] = Math.Round(((nota1erExamen\[i\] + nota2doExamen\[i\]) + nota3erExamen\[i\]) / 3,2);
                condicion\[i\] = (promedio\[i\] \>= 6) ? condicion\[i\] = \"Aprobado\" : condicion\[i\] = \"Reprobado\";
            }

            for (int i = 0; i \< tamanioVector; i++)
            {
                Console.WriteLine(\$\"Alumno: {alumnos\[i\]} , Primer Examen: {nota1erExamen\[i\]} , Segundo Examen: {nota2doExamen\[i\]} ,
Tercer Examen: {nota3erExamen\[i\]} ,\" +
                    \$\" Promedio: {promedio\[i\]} , Condición:
{condicion\[i\]}\");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
