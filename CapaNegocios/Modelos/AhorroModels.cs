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
    public  class AhorroModels
    {
        public string idAhorro { get; set; }
        public string idSocio { get; set; }
        public string NomSocio { get; set; }
        public string cuenta { get; set; }
        public double Total { get; set; }
        public string Estado { get; set; }


        private IRepositorioAhorros repositorioAhorros;
        RepositorioOtros otros = new RepositorioOtros();
        public EstadoEntidad estado { private get; set; }

        public AhorroModels()
        {
            repositorioAhorros = new RepositorioAhorros();
        }

        public string GuardarCambio()
        {

            string mensaje = null;

            try
            {
                var AhorroDataModels = new Ahorros();
                AhorroDataModels.idAhorro = idAhorro;
                AhorroDataModels.idSocio = idSocio;
                AhorroDataModels.cuenta = cuenta;
                AhorroDataModels.Total = Total;
                AhorroDataModels.NomSocio = NomSocio;
                AhorroDataModels.Estado = Estado;
             




                switch (estado)
                {
                    case EstadoEntidad.Agregar:
                        repositorioAhorros.Agregar(AhorroDataModels);
                        mensaje = "Se Agrego Correctamente";
                        break;
                    case EstadoEntidad.Actualizar:
                        repositorioAhorros.Editar(AhorroDataModels);
                        mensaje = " Se Actualizo Correctamente";
                        break;

                    case EstadoEntidad.Eliminar:
                        repositorioAhorros.Eliminar(idAhorro);
                        mensaje = "";
                        break;

                }

            }

            catch (Exception ex)
            {

                string mensaje1 = (ex.ToString());


            }
            return mensaje;

        }

        public DataTable ListarAhorros()
        {
           return otros.ListarAhorros();
        }

        public int AgregarDetalleAhorro(string id, double monto, string estado)
        {
            return  otros.AgregarDetalleAhorro(id, monto, estado);
        }
        public DataTable BuscarDetalleAhorro(string codigo)
        {
            return otros.BuscarDetalleAhorro(codigo);
        }
    }
}
