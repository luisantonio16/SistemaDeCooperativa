using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Contractos;
using CapaDato.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato.Repositorios
{
    public class RepositorioPagos : RepositorioGenerico, IRepositorioPagos
    {
        private string insert;
        private string edit;
        private string sumar;

        public RepositorioPagos()
        {
            insert = "INSERT INTO Pagos VALUES(@CodPagos,@CodPrestamos,@NomSocios,@Monto,@TotalPago,@CuotasResta,@Estado)";
            edit = "UPDATE Pagos SET totalPago=@TotalPago, CuotasRestantes=@CuotasResta WHERE CodigoPago=@CodPagos";
            sumar = "UPDATE Pagos SET totalPago = totalPago + @TotalPago WHERE CodigoPago=@CodPagos";

        }
  

        public int Agregar(Pagos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CodPagos", entity.CodPago));
            parameters.Add(new SqlParameter("@CodPrestamos", entity.CodPrestamos));
            parameters.Add(new SqlParameter("@NomSocios", entity.Socio));
            parameters.Add(new SqlParameter("@Monto", entity.monto));
            parameters.Add(new SqlParameter("@TotalPago", entity.TotalPagos));
            parameters.Add(new SqlParameter("@CuotasResta", entity.CuotasRestantes));
            parameters.Add(new SqlParameter("@Estado", entity.estadoPago));
            return ExecuteNonQuery(insert);
        }

        public int Editar(Pagos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CodPagos", entity.CodPago));
            parameters.Add(new SqlParameter("@TotalPago", entity.TotalPagos));
            parameters.Add(new SqlParameter("@CuotasResta", entity.CuotasRestantes));
            return ExecuteNonQuery(edit);
        }

        public int Eliminar(string idpk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pagos> GetAll()
        {
            throw new NotImplementedException();
        }

        public int suma(string cod, double Total)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@CodPagos", cod));
            parameters.Add(new SqlParameter("@TotalPago", Total));
            return ExecuteNonQuery(edit);
        }
    }
}
