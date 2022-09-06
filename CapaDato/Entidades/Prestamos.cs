using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Entidades
{
    public class Prestamos
    {
        public string idSocio { get; set; }
        public string codigoPrestamos { get; set; }
        public string NomSocio { get; set; }
        public string TipoPrestamos { get; set; }
        public string Descripcion { get; set; }
        public string EstadoPrestamo { get; set; }
        public double MontoPrestamos { get; set; }
        public DateTime Fecha { get; set; }

    }
}
