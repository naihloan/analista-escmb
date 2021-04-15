using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManuelBelgrano.Aplicacion
{
    public class ProgramaOrdenamiento : IProgramaConsola
    {
        /*
         Agregar una nueva clase llamada ProgramaOrdenamiento que implemente la interface IProgramaConsola y:

            Agregar la opción 10 a ProgramaMenu para acceder a ProgramaOrdenamiento desde el menu

            En el programa Ordenamiento: 
         */
        public void IniciarPrograma()
        {
            //Pedir al usuario que ingrese la cantidad de númers a cargar y asignarlos a un vector int[] numeros.
            int tamanio = Helper.IngresoInt("Ingrese la cantidad de números: ");
            int[] numeros = new int[tamanio];
            //Usar un bucle for para cargar uno a uno los valores.
            for (int i = 0; i < numeros.Length; i++)
            {
                int valor = Helper.IngresoInt($"Ingrese el número: {i + 1}");
                numeros[i] = valor;
            }

            //Mostrar todos los valores cargados y en que posición está cada uno
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("El número en la posición {0} es: {1}", i, numeros[i]);
            }

            //Encontrar el mayor de los números ingresados en el vector e imprimirlo.
            int mayor = int.MinValue;
            int indiceMayor = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    indiceMayor = i;
                }
            }

            Console.WriteLine("El mayor es: {0}", mayor);

            //Encontrar el menor de los números ingresados en el vector e imprimirlo.
            int menor = int.MaxValue;
            int indiceMenor = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    indiceMenor = i;
                }
            }
            Console.WriteLine("El menor es: {0}", menor);

            //Determinar la posición del vector números donde se encontró el número mayor y el menor en los algoritmos anteriores (puntos 4 y 5)
            Console.WriteLine("El índice en dónde se encontró el número mayor es {0} y el índice en dónde se encontro el menor es: {1}", indiceMayor, indiceMenor);

            // Ordenar el vector de menor a mayor utilizando el método de la burbuja (el buen amigo google los va a ayudar)
           
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1 - i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int aux = numeros[j + 1];
                        numeros[j + 1] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
        }
    }
}
