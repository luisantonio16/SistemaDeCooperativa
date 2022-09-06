using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Contractos
{
    public interface IRepositorioGenerico<Entyti> where Entyti: class
    {
        int Agregar(Entyti entity);
        int Editar(Entyti entity);
        int Eliminar(string idpk);
        IEnumerable<Entyti> GetAll();
    }
}
