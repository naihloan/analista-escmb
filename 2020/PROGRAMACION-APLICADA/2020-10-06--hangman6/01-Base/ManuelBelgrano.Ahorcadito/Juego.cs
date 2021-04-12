using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.CodeDom;

namespace ManuelBelgrano.Ahorcadito
{
    public class Juego
    {
        public enum Nivel : int
        {
            Basico = 5,
            Medio = 6,
            Avanzado = 8,
            SuperHeavy = 10
        }
        public Juego(string nmbr, Nivel nivel)
        {
            _nivel = nivel;
            NombreJugador = nmbr;
            int nivelEntero = (int)nivel;
            Palabra = GenerarPalabra(nivelEntero);
        }

        private Nivel _nivel;
        private string palabra;

        private string Palabra { get => palabra; set => palabra = value.ToLower(); }
        public string NombreJugador { get; private set; }
        public int CaracteresCorrectas { get; set; }
        public int CaracteresIncorrectas { get; set; }

        private void MostrarEspacios()
        {
            Console.WriteLine("La Palabra es:");
            var sb = new StringBuilder();
            for (var i = 0; i < Palabra.Length; i++)
            {
                sb.Append("_ ");
            }

            Console.WriteLine(sb.ToString());
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
                //if (linea.Length == cantCaracteres) {
                //    break; //interrumpe el bucle actual (también se puede usar en for, y en do-while
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
            MostrarAhorcado();
            var carIngresado = IngresarCaracter();
            
            bool contieneElCaracter = false;
            for (var i = 0; i < Palabra.Length; i++) {
                if (Palabra[i] == carIngresado) {
                    contieneElCaracter = true;
                }
            }
            
            Console.WriteLine($"La palabra: {(contieneElCaracter  ? 1 : 2)} Contiene el caracter ");
        }

        private void MostrarMensajeDeBienvenida()
        {
            Console.Beep(1440, 500);
            var random = new Random();
            for (var i = 0; i < 1; i++)
            {
                Console.Clear();
                Thread.Sleep(250);
                Console.BackgroundColor = (ConsoleColor)random.Next(0, 16);
                Console.WriteLine("════════════════════════════════════════════════════════════");
                Console.WriteLine("║                   BIENVENIDXS AL AHORCADITO              ║");
                Console.WriteLine("════════════════════════════════════════════════════════════");

                Thread.Sleep(500);
            }

            Console.ResetColor();

            Console.WriteLine("************************************************************");
            Console.WriteLine($"*El juego consite en formar una palabra de {(int)_nivel} caracteres****");
            Console.WriteLine("*Cada letra ingresada incorrectamente va a ir completando***");
            Console.WriteLine("**********La palabra A H O R C A D O - Son 8 intentos*******");
            Console.WriteLine("************Presione Enter para empezar a jugar*************");
            Console.WriteLine("************************************************************");


            Console.ReadLine();
            Console.Clear();

        }

        private char IngresarCaracter()
        {
            Console.WriteLine("");
            var posLeft = Console.CursorLeft;
            var posTop = Console.CursorTop;
            char caracterIngresado;
            do
            {
                Console.SetCursorPosition(posLeft, posTop);
                Console.Write("                              ");
                Console.SetCursorPosition(posLeft, posTop);
                Console.Write("Ingresa la letra: ");
                caracterIngresado = char.ToLower(Console.ReadKey().KeyChar);
            }
            while ((caracterIngresado < 'a' || caracterIngresado > 'z')
                && (caracterIngresado < 'á' || caracterIngresado > 'ñ')
                && caracterIngresado != 'é');

            return caracterIngresado;
        }

        void MostrarCaracteresCorrectos() { }

        void MostrarAhorcado()
        {
            var sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine($"Te quedan: {8 - CaracteresIncorrectas} de 8 Intentos");
            for (var i = 0; i < 8; i++)
            {
                sb.Append("_ ");
            }

            Console.WriteLine(sb.ToString());
            Console.WriteLine();
        }

    }
}
