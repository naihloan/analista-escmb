﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManuelBelgrano.Ahorcadito
{
    public class Juego
    {
        public Juego()
        {
            Palabra = GenerarPalabra(5);
        }
        private string Palabra { get; set; }
        public string NombreJugador { get; set; }
        public int CaracteresCorrectas { get; set; }
        public int CaracteresIncorrectas { get; set; }

        public void MostrarEspacios()
        {
            Console.Clear();
            for (var i = 0; i < Palabra.Length; i++)
            {
                Console.Write("_ ");
            }

            Console.WriteLine();

        }

        private string GenerarPalabra(int cantCaracteres)
        {

            var lineas = File.ReadAllLines("Palabras.txt");
            var random = new Random();
            string linea = null;

            while (string.IsNullOrEmpty(linea))
            {
                var numLinea = random.Next(1, lineas.Length);
                linea = lineas[numLinea];//leo la linea en la posición aleatoria
                linea = linea.Trim();//borramos los espacios en blanco al principio y al final

                //if (linea.Length == cantCaracteres) { //Cuando encuentro la palabra, salgo del bucle con la instrucción break
                //    break;
                //} 
                if (linea.Length != cantCaracteres)
                {
                    linea = null;
                }
            }

            return linea;
        }



        void IngresarCaracter() { }

        void MostrarCaracteresCorrectos() { }

        void MostrarMonigote() { }

    }
}