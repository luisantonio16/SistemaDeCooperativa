using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace CapaDato.Repositorios
{
    public abstract class RepositorioConexion
    {
        private readonly string ConnectionString;
        public RepositorioConexion()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ConectionStrings"].ToString();

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
