using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato.Repositorios
{
    public abstract class RepositorioGenerico:RepositorioConexion
    {
        protected List<SqlParameter> parameters;

        protected int ExecuteNonQuery(string transactsql)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = transactsql;
                    comand.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parameters)
                    {
                        comand.Parameters.Add(item);

                    }
                    int resultado = comand.ExecuteNonQuery();
                    return resultado;
                }
            }

        }


        protected DataTable ExecuteReader(string transactsql)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = transactsql;
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
