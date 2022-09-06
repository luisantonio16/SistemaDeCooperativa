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
    public class PrestamosModels
    {
        public string idSocio { get; set; }
        public string codigoPrestamos { get; set; }
        public string NomSocio { get; set; }
        public string TipoPrestamos { get; set; }
        public string Descripcion { get; set; }
        public string EstadoPrestamo { get; set; }
        public double MontoPrestamos { get; set; }
        public DateTime Fecha { get; set; }

        public EstadoEntidad Estado { private get; set; }

        private List<PrestamosModels> listaPrestamos;
        private IRepositorioPrestamo repositorioPrestamos;

        public PrestamosModels()
        {
            repositorioPrestamos = new RepositorioPrestamos();
        }

        public string GuardarCambio()
        {

            string mensaje = null;

            try
            {
                var PrestamosDataModels = new Prestamos();
                PrestamosDataModels.idSocio = idSocio;
                PrestamosDataModels.codigoPrestamos = codigoPrestamos;
                PrestamosDataModels.NomSocio = NomSocio;
                PrestamosDataModels.TipoPrestamos = TipoPrestamos;
                PrestamosDataModels.MontoPrestamos = MontoPrestamos;
                PrestamosDataModels.Fecha = Fecha;
                PrestamosDataModels.EstadoPrestamo = EstadoPrestamo;
                PrestamosDataModels.Descripcion = Descripcion;
           




                switch (Estado)
                {
                    case EstadoEntidad.Agregar:
                        repositorioPrestamos.Agregar(PrestamosDataModels);
                        mensaje = "Se Agrego Correctamente";
                        break;
                    case EstadoEntidad.Actualizar:
                        repositorioPrestamos.Editar(PrestamosDataModels);
                        mensaje = " Se Actualizo Correctamente";
                        break;

                    case EstadoEntidad.Eliminar:
                        repositorioPrestamos.Eliminar(codigoPrestamos);
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

        public List<PrestamosModels> GetAll()
        {
            var PrestamosDataModels = repositorioPrestamos.GetAll();
            listaPrestamos = new List<PrestamosModels>();
            foreach (Prestamos item in PrestamosDataModels)
            {
                listaPrestamos.Add(new PrestamosModels
                {
                    codigoPrestamos = item.codigoPrestamos,
                    idSocio = item.idSocio,
                    NomSocio = item.NomSocio,
                    TipoPrestamos = item.TipoPrestamos,
                    MontoPrestamos = item.MontoPrestamos,
                    Fecha = item.Fecha,
                    EstadoPrestamo = item.EstadoPrestamo,
                    Descripcion = item.Descripcion



                });
            }
            return listaPrestamos;


        }
        public IEnumerable<PrestamosModels> buscar(string filtro)
        {
            return listaPrestamos.FindAll(p => p.NomSocio.Contains(filtro) || p.codigoPrestamos.Contains(filtro) || p.EstadoPrestamo.Contains(filtro));
        }
    }
}
