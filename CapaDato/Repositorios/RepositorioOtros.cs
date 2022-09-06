using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDato.Repositorios
{
    public class RepositorioOtros:RepositorioConexion
    {
        public string Correlativo(int tipodoc)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = " Select Serie + '-' + Numero as Nro from TipoDocumento Where idTipoDoc = @idTipoDoc";
                    comand.Parameters.AddWithValue("@idTipoDoc", tipodoc);
                    comand.CommandType = CommandType.Text;
                   
                    string resultado = (string)comand.ExecuteScalar();
                    return resultado;
                }

            }
        }


        public int ActualizarCorrelativo(int tipodoc)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "SpActualizaTipoDoc";
                    comand.Parameters.AddWithValue("@idTipoDoc", tipodoc);
                    comand.CommandType = CommandType.StoredProcedure;

                    int Result = comand.ExecuteNonQuery();
                    return Result;
                   
                }

            }


        }

        public DataTable VistaPago()
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "select * from Vista_Pagos";
                    //comand.Parameters.AddWithValue("@Codigoart", codigo);
                    comand.CommandType = CommandType.Text;
                    SqlDataReader reader = comand.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }

                }
            }

        }

        public DataTable BuscarDetallePago(string codigo)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "select * from detallePagos where idCodigoPago =@Codigo";
                    comand.Parameters.AddWithValue("@Codigo", codigo);
                    comand.CommandType = CommandType.Text;
                    SqlDataReader reader = comand.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }

                }
            }

        }


        public DataTable BuscarPagos(string codigo)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "select * from Pagos where CodigoPago =@Codigo";
                    comand.Parameters.AddWithValue("@Codigo", codigo);
                    comand.CommandType = CommandType.Text;
                    SqlDataReader reader = comand.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }

                }
            }

        }

        public int AgregarDetallePAGO(string id,string nom, double monto, double total,double cuotas)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "SpInsertarDP";
                    comand.Parameters.AddWithValue("@idCodigoPago", id);
                    comand.Parameters.AddWithValue("@NomSocio", nom);
                    comand.Parameters.AddWithValue("@monto", monto);
                    comand.Parameters.AddWithValue("@totalPago", total);
                    comand.Parameters.AddWithValue("@CuotasRestantes", cuotas);
                    comand.CommandType = CommandType.StoredProcedure;

                   int resul= comand.ExecuteNonQuery();
                    return resul;
                   

                }

            }


        }

        public DataTable ListarAhorros()
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "select * from Ahorros";
                    //comand.Parameters.AddWithValue("@Codigo", codigo);
                    comand.CommandType = CommandType.Text;
                    SqlDataReader reader = comand.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }

                }
            }

        }

        public int AgregarDetalleAhorro(string id, double monto, string estado)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "SpDetalleAhorro";
                    comand.Parameters.AddWithValue("@idDetalleAhorro", id);
                    comand.Parameters.AddWithValue("@monto", monto);
                    comand.Parameters.AddWithValue("@Estado", estado);
                    comand.CommandType = CommandType.StoredProcedure;

                    int resul = comand.ExecuteNonQuery();
                    return resul;


                }

            }


        }
        public DataTable BuscarDetalleAhorro(string codigo)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "select * from DetalleAhorros where idDetalleAhorro =@Codigo";
                    comand.Parameters.AddWithValue("@Codigo", codigo);
                    comand.CommandType = CommandType.Text;
                    SqlDataReader reader = comand.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }

                }
            }

        }


        public DataTable BuscarDetallesPrestamos()
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "select * from DetalleAhorros";
                    comand.CommandType = CommandType.Text;
                    SqlDataReader reader = comand.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }

                }
            }

        }

    }
}
