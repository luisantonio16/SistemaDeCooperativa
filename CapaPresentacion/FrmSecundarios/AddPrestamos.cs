using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios.Modelos;
using CapaComun.Utilidades;
using CapaComun.Cache;
using CapaPresentacion.Validaciones;



namespace CapaPresentacion.FrmSecundarios
{
    public partial class AddPrestamos : Form
    {
        private SociosModels socios = new SociosModels();
        private PrestamosModels prestamos = new PrestamosModels();
        private DetallePrestamosModels detallePrestamos = new DetallePrestamosModels();
        private TipoDocumentoModels tipo = new TipoDocumentoModels();
        PagosModels pagos = new PagosModels();
        public AddPrestamos()
        {
            InitializeComponent();
        }

        private void AddPrestamos_Load(object sender, EventArgs e)
        {
            ListarSocios();
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarSocios()
        {
            CmbSocios.DataSource = socios.GetAll();
            CmbSocios.DisplayMember = "nombre";
            CmbSocios.ValueMember = "codigo";
            CmbSocios.SelectedItem = null;
           
        }

        private void TxtDuraccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                

            }
        }

        private void TxtDuraccion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtMonto.Text.Trim() == "") return;
                if (TxtInteres.SelectedItem == null) return;

                double i = interes();
                double c = 0;

                c = (Convert.ToDouble(TxtMonto.Text) + i) / Convert.ToDouble(TxtDuraccion.Text);
                TxtCuotas.Text = c.ToString("###0.00");


            }
            catch (Exception)
            {
               
            }

        }

        private double interes()
        {
            double i = 0;
            if(TxtInteres.SelectedIndex == 0)
            {
                i = Convert.ToDouble(TxtMonto.Text) * 0.5;
                return i;
            }
            else if(TxtInteres.SelectedIndex == 1)
            {
                i = Convert.ToDouble(TxtMonto.Text) * 0.7;
                return i;
            }
            else if (TxtInteres.SelectedIndex == 2)
            {
                i = Convert.ToDouble(TxtMonto.Text) * 0.010;
                return i;
            }

            else
            {
                MessageBox.Show("Debe Seleccionar Un interes");
                return 0;
            }

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tipo.correlativo(2);
                LblIdPres.Text = id;

                prestamos.codigoPrestamos = LblIdPres.Text.Trim();
                prestamos.idSocio = CmbSocios.SelectedValue.ToString();
                prestamos.MontoPrestamos = Convert.ToDouble(TxtMonto.Text);
                prestamos.Fecha = DateTime.Now;
                prestamos.EstadoPrestamo = "Activo";
                prestamos.NomSocio = CmbSocios.Text;
                prestamos.TipoPrestamos = CmbTipo.Text;
                prestamos.Descripcion = "Ninguna";


                bool valid = new Validaciones.Validaciones(prestamos).validado();
                if (valid == true)
                {
                    string r = prestamos.GuardarCambio();

                    detallePrestamos.idDPrestamos = id;
                    detallePrestamos.interes = Convert.ToDouble(TxtInteres.Text);
                    detallePrestamos.tiempo = CmbTiempo.Text;
                    detallePrestamos.cuotas = Convert.ToDouble(TxtCuotas.Text);
                    detallePrestamos.Duraccion = Convert.ToDouble(TxtDuraccion.Text);

                    detallePrestamos.GuardarCambio();
                    AgregarPagos();
                    tipo.actualizarCorrelativo(2);

                   
                    FrmBueno.Confirmancion(r);
                    limpiar();

                }

            }
            catch (Exception ex)
            {
                string xd = ex.ToString();
                FrmError.AdvertenciaError("Error Agregando Prestamos");
            }
        }

        private void limpiar()
        {
             TxtCuotas.Text = "";
            TxtDuraccion.Text = "";
            TxtMonto.Text = "";
            TxtInteres.SelectedItem = null;
            CmbSocios.SelectedItem = null;

                
        }

        private void AgregarPagos()
        {
            string id = tipo.correlativo(3);

            try
            {
                pagos.CodPago = id;
                pagos.CodPrestamos = LblIdPres.Text;
                pagos.CuotasRestantes = Convert.ToDouble(TxtDuraccion.Text);
                pagos.estadoPago = "activo";
                pagos.monto = 0;
                pagos.Socio = CmbSocios.Text;
                pagos.TotalPagos = 0;

                pagos.GuardarCambio();

                pagos.AgregarDetallePAGO(id, CmbSocios.Text, 0, 0, 0);
                tipo.actualizarCorrelativo(3);
            }
            catch (Exception ex)
            {
                FrmError.AdvertenciaError(ex.ToString());
            }
        }

    }
}
