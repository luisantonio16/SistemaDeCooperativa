using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Utilidades;
using CapaNegocios.Modelos;
using CapaNegocios.ObjetsValues;

namespace CapaPresentacion.FrmSecundarios
{
    public partial class FrmAbonarPago : Form
    {
        private PagosModels pagos = new PagosModels();
        private PrestamosModels prestamos = new PrestamosModels();
        public FrmAbonarPago()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAbonarPago_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            pagar();
        }

        private void pagar()
        {
            

            try
            {
                if (Convert.ToDouble(LblRestas.Text) == 0)
                {
                    FrmError.AdvertenciaError("Este Prestamos ya Fue Saldado");
                    Close();
                }
                else
                {
                    pagos.AgregarDetallePAGO(Lblid.Text.Trim(), LblNombre.Text.Trim(), Convert.ToDouble(TxtCuotas.Text), Convert.ToDouble(TxtCuotas.Text), 0);
                    //FrmBueno.Confirmancion("Pago Realizado Correctamente!!!");
                    ActualizarPago(Lblid.Text.Trim());
                    LblNombre.Text = "";
                    TxtCuotas.Text = "";

                    Close();
                }
              
            }
            catch (Exception ex)
            {
                string mss = ex.ToString();
                FrmError.AdvertenciaError("Error al Realizar Pago");
            }
        }

        private void ActualizarPago(string codigo)
        {
            double c = 0;

            try
            {
               
                var table = new DataTable();
                table = pagos.BuscarPagos(codigo);

                if (table.Rows.Count > 0)
                {
                    c = Convert.ToDouble(table.Rows[0]["CuotasRestantes"].ToString()) - 1;

                    if (c > 0)
                    {
                        pagos.Estado = EstadoDP.Actualizar;
                        pagos.CodPago = codigo.Trim();
                        pagos.TotalPagos = Convert.ToDouble(TxtCuotas.Text);
                        pagos.CuotasRestantes = c;
                        pagos.GuardarCambio();
                        FrmBueno.Confirmancion("Pago Realizado Correctamente");
                    }


                    else if (c == 0)
                    {
                        pagos.Estado = EstadoDP.Actualizar;
                        pagos.CodPago = codigo.Trim();
                        pagos.TotalPagos = Convert.ToDouble(TxtCuotas.Text);
                        pagos.CuotasRestantes = c;
                        pagos.GuardarCambio();


                        prestamos.Estado = EstadoEntidad.Eliminar;
                        prestamos.codigoPrestamos = LblCodPrestamos.Text.Trim();
                        prestamos.GuardarCambio();
                        FrmBueno.Confirmancion("Ultimo Pago Realizado, Prestamo Saldado");
                    }
                }

                

               
               

            }
            catch (Exception ex)
            {
                string mss = ex.ToString();
                FrmError.AdvertenciaError("Error al Realizar Pago 1");
            }

           
        }
    }
}
