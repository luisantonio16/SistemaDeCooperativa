using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Entidades;
using CapaDato.Contractos;
using System.Data.SqlClient;
using System.Data;

namespace CapaDato.Repositorios
{
    public class RepositorioPrestamos:RepositorioGenerico,IRepositorioPrestamo
    {
        private string insertar;
        private string eliminar;
        private string editar;
        private string selectALL;


        public RepositorioPrestamos()
        {
            insertar = "INSERT INTO prestamos VALUES(@Codigo,@idsocio,@NomSocios,@TipoPrestamos,@MontoPrestamos,@Fecha,@Estado,@Descripcion)";
            eliminar = "UPDATE prestamos SET EstadoPrestamos = 'Saldado'   WHERE CodigoPrestamo =@Codigo ";
            editar = "UPDATE prestamos SET idsocio=@idsocio,NomSocio=@NomSocios,tipoPrestamo=@TipoPrestamos,EstadoPrestamos=@Estado where CodigoPrestamo=@Codigo";
            selectALL = " select * from prestamos";
        }

        public int Agregar(Prestamos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Codigo", entity.codigoPrestamos));
            parameters.Add(new SqlParameter("@idsocio", entity.idSocio));
            parameters.Add(new SqlParameter("@NomSocios", entity.NomSocio));
            parameters.Add(new SqlParameter("@TipoPrestamos", entity.TipoPrestamos));
            parameters.Add(new SqlParameter("@MontoPrestamos", entity.MontoPrestamos));
            parameters.Add(new SqlParameter("@Fecha", entity.Fecha));
            parameters.Add(new SqlParameter("@Estado", entity.EstadoPrestamo));
            parameters.Add(new SqlParameter("@Descripcion", entity.Descripcion));
            return ExecuteNonQuery(insertar);
        }

        public int Editar(Prestamos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Codigo", entity.codigoPrestamos));
            parameters.Add(new SqlParameter("@idsocio", entity.idSocio));
            parameters.Add(new SqlParameter("@NomSocios", entity.NomSocio));
            parameters.Add(new SqlParameter("@TipoPrestamos", entity.TipoPrestamos));
            parameters.Add(new SqlParameter("@MontoPrestamos", entity.MontoPrestamos));
            parameters.Add(new SqlParameter("@Fecha", entity.Fecha));
            parameters.Add(new SqlParameter("@Estado", entity.EstadoPrestamo));
            parameters.Add(new SqlParameter("@Descripcion", entity.Descripcion));
            return ExecuteNonQuery(editar);
        }

        public int Eliminar(string codigo)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Codigo", codigo));
            return ExecuteNonQuery(eliminar);
        }

        public IEnumerable<Prestamos> GetAll()
        {
            var ResultadoTabla = ExecuteReader(selectALL);
            var ListarPrestamos = new List<Prestamos>();
            foreach (DataRow item in ResultadoTabla.Rows)
            {
                ListarPrestamos.Add(new Prestamos
                {


                    codigoPrestamos = item[0].ToString(),
                    idSocio = item[1].ToString(),
                    NomSocio = item[2].ToString(),
                    TipoPrestamos = Convert.ToString(item[3]),
                    MontoPrestamos = Convert.ToDouble(item[4]),
                    Fecha = Convert.ToDateTime(item[5]),
                    EstadoPrestamo = item[6].ToString(),
                    Descripcion = item[7].ToString()



                }) ;


            }
            return ListarPrestamos;
        }
    }
}
