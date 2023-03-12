using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Entities
{
    public class Persona
    {
        public Persona(string nombre, int edad, int id)
        {
            Id = id;
            Edad = edad;
            Nombre = nombre;
        }
        public Persona(string nombre, int edad)
        {
            Edad = edad;
            Nombre = nombre;
        }
        public int Id { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
    }
}
