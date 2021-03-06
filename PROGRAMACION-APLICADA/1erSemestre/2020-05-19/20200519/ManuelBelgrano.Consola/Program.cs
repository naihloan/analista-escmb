﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManuelBelgrano.Player;

namespace ManuelBelgrano.Consola
{
    class Program
    {
        static List<string> notasPermitidas = new List<string>() { "C", "D", "E", "F", "G", "A", "B", "S" };
        static string IngresoNota()
        {
            string ingreso;
            bool esValido = false;
            do
            {
                Console.WriteLine("ingrese la nota: C, D, E, F, G, A, B ó 'S' salir");
                ingreso = Console.ReadKey().KeyChar.ToString();
                ingreso = ingreso.ToUpper();
                Console.WriteLine();
                esValido = notasPermitidas.Contains(ingreso);

            } while (esValido == false);
            return ingreso;
        }
        static void Main(string[] args)
        {
            Reproductor miReproductor = new Reproductor();
            Console.WriteLine("Bienvenidxs al piano mágico");
            string nota;
            string continuar;
            do
            {
                do
                {
                    nota = IngresoNota();
                    miReproductor.Play(nota);
                } while (nota != "S");

                Console.WriteLine("¿Quiere tocar otra canción Yes/No?");
                continuar = Console.ReadLine();
                continuar = continuar.ToUpper();
            } while (continuar == "YES");
            //Si el usuario ingreso NO, preguntar
            //si quiere reproducir la cancion
            //grabada, en caso que ingrese YES
            //llamar al metodo miReproductor.ReproducirGrabacion()
            //Sino imprimir "Adiós"
            Console.WriteLine("Desea Reproducir la grabación YES/NO?");
            string reporoducir = Console.ReadLine();
            reporoducir = reporoducir.ToUpper();
            if (reporoducir == "YES")
            {
                miReproductor.ReproducirGrabacion();
            }
            else
            {
                Console.WriteLine("Adiós");
            }
            Console.ReadLine();
        }
    }
}
