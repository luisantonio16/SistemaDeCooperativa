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
    public partial class FrmAhorros : Form
    {

        private TipoDocumentoModels tipo = new TipoDocumentoModels();
        private AhorroModels ahorro = new AhorroModels();
        public FrmAhorros()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNewAhorro_Click(object sender, EventArgs e)
        {
            string id = tipo.correlativo(4);
            FrmFiltro filtro = new FrmFiltro();
            filtro.Show();
            AddAhorros ahorros = new AddAhorros();
            ahorros.TxtIdAhorro.Text = id;
            ahorros.ShowDialog();
            filtro.Close();
        }

        private void FrmAhorros_Load(object sender, EventArgs e)
        {
            ListarPagos();

        }

        private void ListarPagos()
        {
            DataTable table = new DataTable();

            try
            {
                table = ahorro.ListarAhorros();
                if (table.Rows.Count > 0)
                {
                    DataListadoAhorros.DataSource = table;
                    moverColumnas();
                    DataListadoAhorros.ClearSelection();
                    
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

        private void moverColumnas()
        {
            DataListadoAhorros.Columns["Cuenta"].Visible = false;
            DataListadoAhorros.Columns["idSocio"].Visible = false;
            DataListadoAhorros.Columns["Estado"].Visible = false;

            DataListadoAhorros.Columns["NomSocio"].Width = 550;
            DataListadoAhorros.Columns["idAhorros"].Width = 550;
            //DataListadoPagos.Columns["CuotasRestantes"].Visible = false;

        }

        private void detalleDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFiltro filtro = new FrmFiltro();

            if (DataListadoAhorros.SelectedRows.Count > 0)
            {
                filtro.Show();
                AddAhorros frmDetalle = new AddAhorros();
                frmDetalle.update = true;
                frmDetalle.LblIdSocio.Text = DataListadoAhorros.CurrentRow.Cells["idSocio"].Value.ToString();
                frmDetalle.TxtIdAhorro.Text = DataListadoAhorros.CurrentRow.Cells["idAhorros"].Value.ToString();
                frmDetalle.CmbSocios.Text = DataListadoAhorros.CurrentRow.Cells["NomSocio"].Value.ToString();
                frmDetalle.LblTotal.Text = DataListadoAhorros.CurrentRow.Cells["Total"].Value.ToString();



                frmDetalle.ShowDialog();
                filtro.Hide();
                ListarPagos();
            }

        }

        private void DataListadoAhorros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SubMenu.Show(DataListadoAhorros, 600, 30);
        }

        private void realizarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFiltro filtro = new FrmFiltro();

            if (DataListadoAhorros.SelectedRows.Count > 0)
            {
                filtro.Show();
                FrmDetalleAhorro frmDetalle = new FrmDetalleAhorro();
               
                
                frmDetalle.Tag = DataListadoAhorros.CurrentRow.Cells["idAhorros"].Value.ToString();
                frmDetalle.LblNom.Text = DataListadoAhorros.CurrentRow.Cells["NomSocio"].Value.ToString();



                frmDetalle.ShowDialog();
                filtro.Hide();
                ListarPagos();
            }

        }
    }
}
