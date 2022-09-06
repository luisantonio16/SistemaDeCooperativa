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
    public class PagosModels
    {
        public string CodPrestamos { get; set; }
        public string CodPago { get; set; }
        public string Socio { get; set; }
        public double monto { get; set; }
        public double TotalPagos { get; set; }
        public double CuotasRestantes { get; set; }
        public string estadoPago { get; set; }

        private IRepositorioPagos repositorioPagos;
        public EstadoDP Estado { private get; set; }

        public PagosModels()
        {
            repositorioPagos = new RepositorioPagos();
        }

        public string GuardarCambio()
        {

            string mensaje = null;

            try
            {
                var PagosDataModels = new Pagos();
                PagosDataModels.CodPago = CodPago;
                PagosDataModels.CodPrestamos = CodPrestamos;
                PagosDataModels.CuotasRestantes = CuotasRestantes;
                PagosDataModels.monto = monto;
                PagosDataModels.Socio = Socio;
                PagosDataModels.TotalPagos = TotalPagos;
                PagosDataModels.estadoPago = estadoPago;




                switch (Estado)
                {
                    case EstadoDP.Agregar:
                        repositorioPagos.Agregar(PagosDataModels);
                        mensaje = "Se Agrego Correctamente";
                        break;
                    case EstadoDP.Actualizar:
                        repositorioPagos.Editar(PagosDataModels);
                        mensaje = " Se Actualizo Correctamente";
                        break;

                    case EstadoDP.sumar:
                        repositorioPagos.suma(CodPago,TotalPagos);
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

        public DataTable VistaPago()
        {
            RepositorioOtros repositorioOtros = new RepositorioOtros();
            return repositorioOtros.VistaPago();
        }
        public int AgregarDetallePAGO(string id, string nom, double monto, double total, double cuotas)
        {
            RepositorioOtros repositorioOtros = new RepositorioOtros();
            return repositorioOtros.AgregarDetallePAGO(id, nom, monto, total, cuotas);
        }

        public DataTable BuscarDetallePago(string codigo)
        {
            RepositorioOtros repositorioOtros = new RepositorioOtros();
            return repositorioOtros.BuscarDetallePago(codigo);
        }

        public DataTable BuscarPagos(string codigo)
        {
            RepositorioOtros repositorioOtros = new RepositorioOtros();
            return repositorioOtros.BuscarPagos(codigo);
        }
    }
}
