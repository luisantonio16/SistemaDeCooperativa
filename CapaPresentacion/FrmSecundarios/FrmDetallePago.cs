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


namespace CapaPresentacion.FrmSecundarios
{
    public partial class FrmDetallePago : Form
    {
        public FrmDetallePago()
        {
            InitializeComponent();
        }

        private PagosModels pagos = new PagosModels();
        private void FrmDetallePago_Load(object sender, EventArgs e)
        {
            ListarDetalles(this.Tag.ToString());
            ListarCuotas(this.Tag.ToString());
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataListadoDetallePagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarDetalles(string codigo)
        {
            var table = new DataTable();
            table = pagos.BuscarDetallePago(codigo);


            try
            {
                DataListadoDetallePagos.DataSource = table;
                DataListadoDetallePagos.ClearSelection();
                Total();
                Ocultar();
            }
            catch (Exception ex)
            {

            }
        }

        private void Total()
        {
            double Cuotas = 0;

            for (int i = 0; i < DataListadoDetallePagos.Rows.Count; i++)
            {
                Cuotas += Convert.ToDouble(DataListadoDetallePagos.Rows[i].Cells["totalPago"].Value.ToString());

            }

            LblTotal.Text = Cuotas.ToString("###0.00");
        }

        private void ListarCuotas(string codigo)
        {
            var table = new DataTable();
            table = pagos.BuscarPagos(codigo);

            if (table.Rows.Count > 0)
            {
                LblCuotas.Text = table.Rows[0]["CuotasRestantes"].ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblNom_Click(object sender, EventArgs e)
        {

        }
        private void Ocultar()
        {
            DataListadoDetallePagos.Columns["CuotasRestantes"].Visible = false;
        }
    }
}
