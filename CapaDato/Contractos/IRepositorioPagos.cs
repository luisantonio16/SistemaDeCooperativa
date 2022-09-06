using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Entidades;

namespace CapaDato.Contractos
{
    public interface IRepositorioPagos:IRepositorioGenerico<Pagos>
    {
        int suma(string cod, double Total);
    }
}
