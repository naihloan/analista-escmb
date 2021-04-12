using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Aplicacion
{
    public class ProgramaLogin : IProgramaConsola
    {        
        public void IniciarPrograma() {
            string usuarix, password;
            bool ingresoCorrecto;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese el usuarix:");
                    usuarix = Console.ReadLine();
                }
                while (usuarix == "");
                do
                {
                    Console.WriteLine("Ingrese la contraseña:");
                    password = Console.ReadLine();
                }
                while (password == "");
                if (usuarix == "Admin" && password == "123")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bienvenidx");
                    Console.ResetColor();
                    ingresoCorrecto = true;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Usuarix o Password incorrectos");
                    Console.ResetColor();
                    ingresoCorrecto = false;
                }
            } while (ingresoCorrecto == false);
            


        }
    }
}
