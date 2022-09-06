using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public static class UserLoginCache
    {
        public static int idUser { get; set; }
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static string usuario { get; set; }
        public static string contraseña { get; set; }
        public static string Rol { get; set; }
        public static int idRol { get; set; }
    }
}
