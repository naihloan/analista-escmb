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

        private enum PosTop : int
        {
            Seccion1 = 1,
            Seccion2 = 5,
            Seccion3 = 9
        }

        private void UbicarCursor(PosTop pos)
        {
            var posTop = (int)pos;
            Console.SetCursorPosition(1, posTop);
        }

        public Juego(string nmbr, Nivel nivel)
        {
            //Seteamos el campo del nivel
            _nivel = nivel;
            //Seteamos el nombre del jugador
            NombreJugador = nmbr;
            //Convertimos a entero la enumeración para pasarlo al método GenerarPalabra
            int nivelEntero = (int)nivel;
            //Obtenemos la palabra de nuestro diccionario
            //y la asignamo a la porperty Palabra
            Palabra = GenerarPalabra(nivelEntero);
            _espaciosSeccion1 = new char[Palabra.Length];
            for (var i = 0; i < _espaciosSeccion1.Length; i++) {
                _espaciosSeccion1[i] = '_';
            }

            //Inicializamos los contadores
            CaracteresCorrectas = 0;
            CaracteresIncorrectas = 0;
        }

        private Nivel _nivel;
        private string _palabra;
        private char[] _espaciosSeccion1;
        private string Palabra
        {
            get => _palabra;//obtiene el Backing field correspondiente a esta property
            set => _palabra = value.ToLower();//Usamos un backending field para que SIMPRE la setee en minúscula
        }
        public string NombreJugador { get; private set; }
        public int CaracteresCorrectas { get; set; }
        public int CaracteresIncorrectas { get; set; }




        private void MostrarEspacios() //Seccion 1
        {
            UbicarCursor(PosTop.Seccion1);
            //Dibuja en pantalla los valores
            Console.WriteLine("La Palabra es:");
            var sb = new StringBuilder();
            for (var i = 0; i < _espaciosSeccion1.Length; i++)
            {
                sb.Append($"{_espaciosSeccion1[i]} ");
            }

            Console.WriteLine(sb.ToString());
            Console.WriteLine();
        }
        private void MostrarEspacios(char caringresado) //Seccion 1
        { 
            //Recorro la propiedad Palabra y voy buscando en que
            //posiciones se encuentra el caracter ingresado y lo
            //remplazo el el vector _escaciosSeccion1
            for (var i = 0; i < Palabra.Length; i++) {
                if (Palabra[i] == caringresado) {
                    _espaciosSeccion1[i] = char.ToUpper(caringresado);
                }            
            }
            MostrarEspacios();
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

            MostrarAhorcado();//Seccion 3
            MostrarEspacios();//Seccion 1  


            while (CaracteresIncorrectas < 8)
            {
                var carIngresado = IngresarCaracter(); //Seccion 2

                bool contieneElCaracter = false;

                //contieneElCaracter = Palabra.Contains(carIngresado);

                for (var i = 0; i < Palabra.Length; i++)
                {
                    if (Palabra[i] == carIngresado)
                    {
                        contieneElCaracter = true;
                        break;
                    }
                }

                if (contieneElCaracter)
                {
                    CaracteresCorrectas = CaracteresCorrectas + 1;
                    MostrarEspacios(carIngresado);//Seccion 1
                }
                else
                {
                    CaracteresIncorrectas = CaracteresIncorrectas + 1;
                }
            }

            //Console.WriteLine($"La palabra: {(contieneElCaracter ? 1 : 2)} Contiene el caracter ");
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

        private char IngresarCaracter()//Seccion 2
        {
            UbicarCursor(PosTop.Seccion2);
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

        void MostrarAhorcado() //SECCION 3
        {
            UbicarCursor(PosTop.Seccion3);
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
