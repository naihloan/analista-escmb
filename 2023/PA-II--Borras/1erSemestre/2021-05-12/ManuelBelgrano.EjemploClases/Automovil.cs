using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.EjemploClases
{
    public class Automovil : Transporte
    {
        private int _llantas; //Se llaman campos o fields y normalmente son privadas
        public int tanque;public string transmision;


        //properties o propiedades
        public int Llantas
        {
            get {
                return _llantas;
            }
            set {
                if (value < 0) throw new ArgumentException("Fuera del rango");
                _llantas = value;
            }
        }

        public string NumeroDePatente { get; set; }

        public bool EstaEncendido { get; set; }


        public void SetNumeroDeLLantas(int value)
        {
            _llantas = value;
        }

        public int NumeroDeLLantas()
        {            
            return _llantas;
        }
        public int CapacidadTanque()
        {
            return _llantas;
        }

        public string TipoTransmision()
        {
            return transmision;
        }
    }
}
