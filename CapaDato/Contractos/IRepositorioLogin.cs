using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Contractos
{
    public  interface IRepositorioLogin<Entity>where Entity: class
    {
        bool IniciarSeccion(string user, string pass);
    }
}
