using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Repositorios;
using CapaDato.Contractos;
using CapaDato.Entidades;
using System.Data;
using System.Data.SqlClient;
using CapaNegocios.ObjetsValues;
using System.ComponentModel.DataAnnotations;

namespace CapaNegocios.Modelos
{
    public class SociosModels
    {
       
        [Required]
        public string nombre { get; set; }
        public string codigo { get; set; }
        [Required]
        public string cedula { get; set; }
        [Required]
        public string telefono { get; set; }
        public string estado { get; set; }
        public string email { get; set; }



        public EstadoEntidad Estado { private get; set; }




        private List<SociosModels> listaSocios;
        private IRepositorioSocios repositorioSocio;


        public SociosModels()
        {
            repositorioSocio = new RepositorioSocios();
        }


        public string GuardarCambio()
        {

            string mensaje = null;

            try
            {
                var SociosDataModels = new Socios();
                SociosDataModels.codigo = codigo;
                SociosDataModels.nombre = nombre;
                SociosDataModels.email = email;
                SociosDataModels.cedula = cedula;
                SociosDataModels.telefono = telefono;
                SociosDataModels.estado = estado;




                switch (Estado)
                {
                    case EstadoEntidad.Agregar:
                        repositorioSocio.Agregar(SociosDataModels);
                        mensaje = "Se Agrego Correctamente";
                        break;
                    case EstadoEntidad.Actualizar:
                        repositorioSocio.Editar(SociosDataModels);
                        mensaje = " Se Actualizo Correctamente";
                        break;

                    case EstadoEntidad.Eliminar:
                        repositorioSocio.Eliminar(codigo);
                        mensaje = "Se Elimino Correctamente";
                        break;
                   
                }

            }

            catch (Exception ex)
            {

                string mensaje1 = (ex.ToString());
              

            }
            return mensaje;

        }


        public List<SociosModels> GetAll()
        {
            var SociosDataModels = repositorioSocio.GetAll();
            listaSocios = new List<SociosModels>();
            foreach (Socios item in SociosDataModels)
            {
                listaSocios.Add(new SociosModels
                {
                    nombre = item.nombre,
                    codigo = item.codigo,
                    email = item.email,
                    cedula = item.cedula,
                    telefono = item.telefono,
                    estado = item.estado,

                });
            }
            return listaSocios;
        }


        public IEnumerable<SociosModels> buscar(string filtro)
        {
            return listaSocios.FindAll(s => s.nombre.Contains(filtro) || s.cedula.Contains(filtro) || s.codigo.Contains(filtro) );
        }


    } 
}
