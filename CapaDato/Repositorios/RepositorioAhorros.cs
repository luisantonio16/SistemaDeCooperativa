using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Entidades;
using CapaDato.Contractos;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato.Repositorios
{
    public class RepositorioAhorros : RepositorioGenerico, IRepositorioAhorros
    {

        private string insertar;
        private string eliminar;
        private string editar;
        private string selectALL;


        public RepositorioAhorros()
        {
            insertar = "INSERT INTO Ahorros VALUES(@Codigo,@idsocio,@NomSocios,@Cuenta,@Total,@Estado)";
            eliminar = "UPDATE prestamos SET EstadoPrestamos = 'Inactivo'   WHERE CodigoPrestamo =@Codigo ";
            editar = "UPDATE Ahorros SET Total = Total + @Total  WHERE idAhorros =@Codigo";
            selectALL = " select * from prestamos";
        }
        public int Agregar(Ahorros entity) 
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Codigo", entity.idAhorro));
            parameters.Add(new SqlParameter("@idsocio", entity.idSocio));
            parameters.Add(new SqlParameter("@NomSocios", entity.NomSocio));
            parameters.Add(new SqlParameter("@Cuenta", entity.cuenta));
            parameters.Add(new SqlParameter("@Total", entity.Total));
            parameters.Add(new SqlParameter("@Estado", entity.Estado));
            return ExecuteNonQuery(insertar);
        }

        public int Editar(Ahorros entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Codigo", entity.idAhorro));
            parameters.Add(new SqlParameter("@Total", entity.Total));
            return ExecuteNonQuery(editar);
        }

        public int Eliminar(string idpk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ahorros> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
