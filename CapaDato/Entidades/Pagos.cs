using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Entidades
{
    public class Pagos
    {
        public string CodPrestamos { get; set; }
        public string CodPago { get; set; }
        public string Socio { get; set; }
        public double monto { get; set; }
        public double TotalPagos { get; set; }
        public double CuotasRestantes { get; set; }
        public string estadoPago { get; set; }
    }
}
