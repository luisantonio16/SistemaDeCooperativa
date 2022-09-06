using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Contractos;
using CapaDato.Repositorios;

namespace CapaNegocios.Modelos
{
    public class UsuariosModels
    {
        private IRepositorioUsuarios repositorioUsuarios;


        public UsuariosModels()
        {
            repositorioUsuarios = new RepositorioUsuario();

        }


        public bool inicio(string user, string pass)
        {
            return repositorioUsuarios.IniciarSeccion(user, pass);

        }
    }
}
