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
            Palabra = GenerarPalabra((int)nivelDeDificultad);
            MostrarEspacios();
        }

        private string Palabra { get; set; }
        public string NombreJugador { get; private set; }
        public int CaracteresCorrectas { get; set; }
        public int CaracteresIncorrectas { get; set; }

        private void MostrarEspacios()
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

        public void Empezar() { 
            
        
        }


        void IngresarCaracter() {
            //obtengo el caracter ingresado transformado a mayúscula
            
            var posActualx = Console.CursorLeft;
            var posActualy = Console.CursorTop;
            Console.Write("INGRESA UNA LETRA: ");
            char caracter = char.ToLower(Console.ReadKey().KeyChar);
            while (((caracter > 'a' && caracter < 'z')  || (caracter > 'á' && caracter < 'ñ') || caracter == 'ü' || caracter == 'é') == false  ) 
            {
                Console.SetCursorPosition(posActualx, posActualy);
                Console.Write("INGRESA UNA LETRA: ");
                caracter = char.ToLower(Console.ReadKey().KeyChar);
            }
            //while()

        }

        void MostrarCaracteresCorrectos() { }

        void MostrarMonigote() { 
        
        }

    }
}
