using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Contractos;
using CapaDato.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDato.Repositorios
{
    public class RepositorioDetallePrestamos : RepositorioGenerico, IRepositorioDetallePrestamos
    {
        private string insert;

        public RepositorioDetallePrestamos()
        {
            insert = "INSERT INTO Detalleprestamos VALUES(@IdDPrestamos,@Cuotas,@Tiempo,@Duraccion,@Interes)";
        }
        public int Agregar(DetallePrestamos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdDPrestamos", entity.idDPrestamos));
            parameters.Add(new SqlParameter("@Cuotas", entity.cuotas));
            parameters.Add(new SqlParameter("@Tiempo", entity.tiempo));
            parameters.Add(new SqlParameter("@Duraccion", entity.Duraccion));
            parameters.Add(new SqlParameter("@Interes", entity.interes));
            return ExecuteNonQuery(insert);
        }

        public int Editar(DetallePrestamos entity)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(string idpk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetallePrestamos> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
