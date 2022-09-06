using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Contractos;
using CapaDato.Entidades;

namespace CapaDato.Repositorios
{
    public  class RepositorioSocios:RepositorioGenerico, IRepositorioSocios
    {


        private string insertar;
        private string eliminar;
        private string editar;
        private string selectALL;




        public RepositorioSocios()
        {
            selectALL = "select * from Socios";
            insertar = "INSERT INTO Socios VALUES(@Codigo,@Nombre,@Email,@Cedula,@Telefono,@Estado)";
            editar = "UPDATE Socios SET Nombre=@Nombre, email=@Email, cedula=@Cedula, Telefono=@Telefono, estado=@Estado where CodigoSocio =@Codigo";
            eliminar = "UPDATE Socios SET estado = 'Inactivo' WHERE CodigoSocio =@Codigo";
        }

        public int Agregar(Socios entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Codigo", entity.codigo));
            parameters.Add(new SqlParameter("@Nombre", entity.nombre));
            parameters.Add(new SqlParameter("@Email", entity.email));
            parameters.Add(new SqlParameter("@Cedula", entity.cedula));
            parameters.Add(new SqlParameter("@Telefono", entity.telefono));
            parameters.Add(new SqlParameter("@Estado", entity.estado));
            return ExecuteNonQuery(insertar);

                
        }

        public int Editar(Socios entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Codigo", entity.codigo));
            parameters.Add(new SqlParameter("@Nombre", entity.nombre));
            parameters.Add(new SqlParameter("@Email", entity.email));
            parameters.Add(new SqlParameter("@Cedula", entity.cedula));
            parameters.Add(new SqlParameter("@Telefono", entity.telefono));
            parameters.Add(new SqlParameter("@Estado", entity.estado));
            return ExecuteNonQuery(editar);
        }


        public int Eliminar(string codigo)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Codigo", codigo));
            return ExecuteNonQuery(eliminar);
        }


        public IEnumerable<Socios> GetAll()
        {
            var ResultadoTabla = ExecuteReader(selectALL);
            var ListaSocios = new List<Socios>();
            foreach (DataRow item in ResultadoTabla.Rows)
            {
                ListaSocios.Add(new Socios
                {

                    codigo = item[0].ToString(),
                    nombre = item[1].ToString(),
                    email = item[2].ToString(),
                    cedula = item[3].ToString(),
                    telefono = Convert.ToString(item[4]),
                    estado = Convert.ToString(item[5])



                });


            }
            return ListaSocios;
        }
    }

    
}
