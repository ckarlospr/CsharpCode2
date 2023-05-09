using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras.entities
{
    internal class Cliente
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tlefono { get; set; }
        public string Tarjeta { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
