using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDato.Repositorios
{
    public class RepositorioLogin:RepositorioConexion
    {

        protected List<SqlParameter> parameters;

        protected bool Login(string user, string pass)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conection;
                    comand.CommandText = "select * from  Usuarios U join Roles R on u.idRol = R.idRol where U.Usuario = @user and U.Contraseña = @pass";
                    comand.Parameters.AddWithValue("@user", user);
                    comand.Parameters.AddWithValue("@pass", pass);
                    comand.CommandType = CommandType.Text;
                    SqlDataReader reader = comand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CapaComun.Cache.UserLoginCache.idUser = reader.GetInt32(0);
                            CapaComun.Cache.UserLoginCache.nombre = reader.GetString(1);
                            CapaComun.Cache.UserLoginCache.apellido = reader.GetString(2);
                            CapaComun.Cache.UserLoginCache.usuario = reader.GetString(3);
                            CapaComun.Cache.UserLoginCache.contraseña = reader.GetString(4);
                            CapaComun.Cache.UserLoginCache.idRol = reader.GetInt32(5);
                            CapaComun.Cache.UserLoginCache.Rol = reader.GetString(7);



                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }
        }
    }
}
