using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Repositorios;
using CapaDato.Entidades;


namespace CapaNegocios.Modelos
{
    public class TipoDocumentoModels
    {

        private RepositorioOtros repositorio = new RepositorioOtros();

        public string correlativo(int idtipodoc)
        {
            return repositorio.Correlativo(idtipodoc);
        }
        public int actualizarCorrelativo(int idtipodoc)
        {
            return repositorio.ActualizarCorrelativo(idtipodoc);

        }
    }
}
