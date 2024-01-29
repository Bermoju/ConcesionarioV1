using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV1
{
    public class Vehiculo
    {
        // CONSTANTES

        // MIENBROS PRIVADOS
        private string _marca;
        private string _modelo;

        // CONSTRUCTURORES
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        // PROPIEDADES
        public string Marca 
        {
            get { return _marca; }
            set { 
                    // TODO: Proporcionañr seguridad y protección al mienbro - _marca
                _marca = value;  } 
        }

        public string Modelo
        {
            get { return _modelo; }
            set {
                // TODO: Proporcionañr seguridad y protección al mienbro - _modelo
                _modelo = value; }
        }

        // MÉTODOS PÚBLICOS

        // MÉTODOS PRIVADOS

    }
}
