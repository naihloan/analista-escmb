using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            var tamanioVector = 2;
            
            string[] alumnos = new string[tamanioVector]; // crear un vector de alumnos
            double[] nota1erExamen = new double[tamanioVector]; // crear vectores de notas
            double[] nota2doExamen = new double[tamanioVector];
            double[] nota3erExamen = new double[tamanioVector];
            double[] promedio = new double[tamanioVector]; // crear vector para almacenar promedios
            string[] condicion = new string[tamanioVector]; // y resultados


            for (int i = 0; i < tamanioVector; i++)
            {
                alumnos[i] = Helper.IngresoString("Ingrese el nombre del Alumno:"); // no dejar en blanco
                nota1erExamen[i] = Helper.IngresoDouble(0,10,"Ingrese la nota del 1er examen"); // acá se ponen los límites de rango de nota
                nota2doExamen[i] = Helper.IngresoDouble(0, 10, "Ingrese la nota del 2do examen");
                nota3erExamen[i] = Helper.IngresoDouble(0, 10, "Ingrese la nota del 3er examen");

                Console.Clear();
            }

            for (int i = 0; i < tamanioVector; i++)
            {

                promedio[i] = Math.Round(((nota1erExamen[i] + nota2doExamen[i]) + nota3erExamen[i]) / 3, 2);
                condicion[i] = (promedio[i] >= 6) ? "Aprobado" : "Reprobado";

                Console.WriteLine($"Alumno: {alumnos[i]} , Primer Examen: {nota1erExamen[i]} , Segundo Examen: {nota2doExamen[i]} , Tercer Examen: {nota3erExamen[i]} ," +
                    $" Promedio: {promedio[i]} , Condición: {condicion[i]}");
                Console.WriteLine();
            }
            //for (int i = 0; i < tamanioVector; i++)
            //{

            //    promedio[i] = Math.Round(((nota1erExamen[i] + nota2doExamen[i]) + nota3erExamen[i]) / 3,2);
            //    condicion[i] = (promedio[i] >= 6) ? "Aprobado" :  "Reprobado";
            //}

            //for (int i = 0; i < tamanioVector; i++)
            //{
            //    Console.WriteLine($"Alumno: {alumnos[i]} , Primer Examen: {nota1erExamen[i]} , Segundo Examen: {nota2doExamen[i]} , Tercer Examen: {nota3erExamen[i]} ," +
            //        $" Promedio: {promedio[i]} , Condición: {condicion[i]}");
            //    Console.WriteLine();


            //}

            Console.ReadLine();
        }
        
    }
}
