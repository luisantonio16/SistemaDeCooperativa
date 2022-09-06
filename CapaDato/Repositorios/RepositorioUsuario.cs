using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Contractos;
using CapaDato.Entidades;
using System.Data.SqlClient;

namespace CapaDato.Repositorios
{
    public class RepositorioUsuario : RepositorioLogin, IRepositorioUsuarios
    {
        public bool IniciarSeccion(string user, string pass)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@user", user));
            parameters.Add(new SqlParameter("@pass", pass));
            return Login(user, pass);
        }
    }
}
