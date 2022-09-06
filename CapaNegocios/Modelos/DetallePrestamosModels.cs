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
    public class DetallePrestamosModels
    {
        [Required]
        public string idDPrestamos { get; set; }
        [Required]
        public double cuotas { get; set; }
        public double interes { get; set; }
        [Required]
        public double Duraccion { get; set; }
        public string tiempo { get; set; }


        public EstadoEntidad Estado { private get; set; }


        private IRepositorioDetallePrestamos RepositorioDetallePrestamos;

        public DetallePrestamosModels()
        {
            RepositorioDetallePrestamos = new RepositorioDetallePrestamos();
        }


        public string GuardarCambio()
        {

            string mensaje = null;

            try
            {
                var DetallePrestamoModels = new DetallePrestamos();
                DetallePrestamoModels.idDPrestamos = idDPrestamos;
                DetallePrestamoModels.cuotas = cuotas;
                DetallePrestamoModels.tiempo = tiempo;
                DetallePrestamoModels.Duraccion = Duraccion;
                DetallePrestamoModels.interes = interes;






                switch (Estado)
                {
                    case EstadoEntidad.Agregar:
                        RepositorioDetallePrestamos.Agregar(DetallePrestamoModels);
                        mensaje = "Se Agrego Correctamente";
                        break;
                    case EstadoEntidad.Actualizar:
                        RepositorioDetallePrestamos.Editar(DetallePrestamoModels);
                        mensaje = " Se Actualizo Correctamente";
                        break;

                   

                }

            }

            catch (Exception ex)
            {

                string mensaje1 = (ex.ToString());


            }
            return mensaje;

        }
    }
}
