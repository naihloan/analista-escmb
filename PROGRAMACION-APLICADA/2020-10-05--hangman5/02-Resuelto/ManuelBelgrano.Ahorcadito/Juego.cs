using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManuelBelgrano.Ahorcadito
{
    public class Juego
    {
        public enum Nivel
        {
            Basico = 5,
            Medio = 6,
            Avanzado = 8,
            SuperHeavy = 10
        }

        //variable de campo o Field Value
        private Nivel _NivelDeDificultad;
        public Juego(string nombreJugador, Nivel nivelDeDificultad)
        {
            _NivelDeDificultad = nivelDeDificultad;
            NombreJugador = nombreJugador;
            Palabra = GenerarPalabra((int)nivelDeDificultad).ToUpper();

        }

        private string Palabra { get; set; }
        public string NombreJugador { get; private set; }
        public int CaracteresCorrectas { get; set; }
        public int CaracteresIncorrectas { get; set; }

        private void MostrarEspacios()
        {
            Console.WriteLine("════════════════════════════════════════════════════════════");
            for (var i = 0; i < Palabra.Length; i++)
            {
                Console.Write("_ ");
            }
            Console.WriteLine();
            Console.WriteLine("════════════════════════════════════════════════════════════");
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

        public void Empezar()
        {
            MostrarMensajeDeBienvenida();
            MostrarEspacios();
            //HOLA
            var carIngresado = char.ToUpper(IngresarCaracter());
            var contieneElCaracter = false;
            for (var i = 0; i < Palabra.Length; i++) {
                if (Palabra[i] == carIngresado) {
                    contieneElCaracter = true;
                }
            }

            //TODO: Hacer que muestre las coincidencias 
            //o vaya armando la palabra AHORCADO

        }

        private void MostrarMensajeDeBienvenida()
        {
            Console.Clear();
            Console.WriteLine("════════════════════════════════════════════════════════════");
            Console.WriteLine("║                   BIENVENIDXS AL AHORCADITO              ║");
            Console.WriteLine("════════════════════════════════════════════════════════════");
            Console.WriteLine("************************************************************");
            Console.WriteLine($"*El juego consite en formar una palabra de {(int)_NivelDeDificultad} caracteres****");
            Console.WriteLine("*Cada letra ingresada incorrectamente va a ir completando***");
            Console.WriteLine("**********La palabra A H O R C A D O - Son 8 intentos*******");
            Console.WriteLine("************Presione Enter para empezar a jugar*************");
            Console.WriteLine("************************************************************");
            Console.ReadLine();
            Console.Clear();
        }

        private char IngresarCaracter()
        {
            //obtengo el caracter ingresado transformado a mayúscula

            var posActualx = Console.CursorLeft;
            var posActualy = Console.CursorTop;
            char caracter;
            do
            {
                Console.SetCursorPosition(posActualx, posActualy);
                Console.Write("                      ");
                Console.SetCursorPosition(posActualx, posActualy);
                Console.Write("INGRESA UNA LETRA: ");
                caracter = char.ToLower(Console.ReadKey().KeyChar);
            }
            //while (((caracter >= 'a' && caracter <= 'z') || (caracter >= 'á' && caracter <= 'ñ') || caracter == 'ü' || caracter == 'é') == false);
            while ((caracter < 'a' || caracter > 'z') && (caracter < 'á' || caracter > 'ñ') && caracter != 'ü' && caracter != 'é');

            return caracter;
        }

        void MostrarCaracteresCorrectos() { }

        void MostrarIncorrectos() //A H O R C A D O
        {

        }

    }
}
