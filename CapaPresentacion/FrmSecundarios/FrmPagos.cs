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

namespace CapaPresentacion.FrmSecundarios
{
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
        }

        private PagosModels pagos = new PagosModels();
        private void FrmPagos_Load(object sender, EventArgs e)
        {
            ListarPagos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarPagos()
        {
            DataTable table = new DataTable();

            try
            {
                table = pagos.VistaPago();
                if (table.Rows.Count > 0)
                {
                    DataListadoPagos.DataSource = table;
                    DataListadoPagos.ClearSelection();
                    CalcularMontoNeto();
                    moverColumnas();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                string mss = ex.ToString();
            }
        }


        private void CalcularMontoNeto()
        {
            double Cuotas = 0;
            double numeros = 0;

            double neto = 0;

            for (int i = 0; i < DataListadoPagos.Rows.Count; i++)
            {
                Cuotas = Convert.ToDouble(DataListadoPagos.Rows[i].Cells["MontoCuotas"].Value.ToString());
                numeros = Convert.ToDouble(DataListadoPagos.Rows[i].Cells["CuotasTotales"].Value.ToString());

                neto = Cuotas * numeros;

                DataListadoPagos.Rows[i].Cells[0].Value = neto.ToString("###0.00");

            }      
        }

        private void moverColumnas()
        {
            DataListadoPagos.Columns[0].DisplayIndex = 6;
            DataListadoPagos.Columns["CuotasRestantes"].Visible = false;
           
        }

        private void DataListadoPagos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SubMenu.Show(DataListadoPagos, 600, 30);
        }

        private void realizarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFiltro filtro = new FrmFiltro();

            if (DataListadoPagos.SelectedRows.Count > 0)
            {
                filtro.Show();
                FrmAbonarPago Abonar = new FrmAbonarPago();
                Abonar.LblNombre.Text = DataListadoPagos.CurrentRow.Cells["NomSocio"].Value.ToString();
                Abonar.Lblid.Text = DataListadoPagos.CurrentRow.Cells["CodigoPago"].Value.ToString();
                Abonar.TxtCuotas.Text = DataListadoPagos.CurrentRow.Cells["MontoCuotas"].Value.ToString();
                Abonar.LblCodPrestamos.Text = DataListadoPagos.CurrentRow.Cells["codPrestamos"].Value.ToString();
                Abonar.LblRestas.Text = DataListadoPagos.CurrentRow.Cells["CuotasRestantes"].Value.ToString();
                //Abonar.LblRestas.Text = DataListadoPagos.CurrentRow.Cells["CuotasRestantes"].Value.ToString();
                Abonar.ShowDialog();
                filtro.Hide();
            }
        }

        private void detalleDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFiltro filtro = new FrmFiltro();

            if (DataListadoPagos.SelectedRows.Count > 0)
            {
                filtro.Show();
                FrmDetallePago frmDetalle = new FrmDetallePago();
                frmDetalle.Tag = DataListadoPagos.CurrentRow.Cells["CodigoPago"].Value.ToString();
                frmDetalle.LblNom.Text = DataListadoPagos.CurrentRow.Cells["NomSocio"].Value.ToString();
                frmDetalle.LblId.Text = DataListadoPagos.CurrentRow.Cells["CodigoPago"].Value.ToString();


                frmDetalle.ShowDialog();
                filtro.Hide();
            }

        }

        private void ListarDettales()
        {
            try
            {
                var table = new DataTable();
              


               
            }
            catch (Exception ex)
            {

            }
        }
        private void SaldarPrestamos()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
