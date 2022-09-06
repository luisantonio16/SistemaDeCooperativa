using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Entidades
{
    public class DetallePrestamos
    {
        public string idDPrestamos { get; set; }
        public double cuotas { get; set; }
        public double interes { get; set; }
        public double Duraccion { get; set; }

        public string tiempo { get; set; }
    }
}
