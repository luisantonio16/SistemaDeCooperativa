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
using CapaPresentacion.FrmSecundarios;
using CapaNegocios.ObjetsValues;

namespace CapaPresentacion.FrmSecundarios
{
    public partial class FrmSocios : Form
    {
        private SociosModels socios = new SociosModels();
        public FrmSocios()
        {
            InitializeComponent();
        }

        private void ListarSocios()
        {
            try
            {
                DataListadoSocios.DataSource = socios.GetAll();


            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                

            }

        }

        private void FrmSocios_Load(object sender, EventArgs e)
        {
            ListarSocios();
            OcultarFilas();
            mover();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBuscarDocumento_TextChanged(object sender, EventArgs e)
        {
            DataListadoSocios.DataSource = socios.buscar(TxtBuscarDocumento.Text.Trim());
        }

        private void BtnNewSocio_Click(object sender, EventArgs e)
        {
            
            AddSocios addSocios = new AddSocios();
            addSocios.ShowDialog();
          
            ListarSocios();

        }

        private void OcultarFilas()
        {
          
        }

        private void DataListadoSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataListadoSocios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SubMenu.Show(DataListadoSocios, 700, 30);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataListadoSocios.SelectedRows.Count > 0)
            {
               
                AddSocios addSocios = new AddSocios();
                addSocios.Update = true;
                addSocios.TxtId.Text = DataListadoSocios.CurrentRow.Cells["codigo"].Value.ToString();
                addSocios.TxtNombre.Text = DataListadoSocios.CurrentRow.Cells["nombre"].Value.ToString();
                addSocios.TxtEmail.Text = DataListadoSocios.CurrentRow.Cells["email"].Value.ToString();
                addSocios.TxtTelefono.Text = DataListadoSocios.CurrentRow.Cells["telefono"].Value.ToString();
                addSocios.TxtCedula.Text = DataListadoSocios.CurrentRow.Cells["cedula"].Value.ToString();
                addSocios.CmbEstado.Text = DataListadoSocios.CurrentRow.Cells["estado"].Value.ToString();
                addSocios.ShowDialog();
             
                ListarSocios();
            }
        }

        private void darBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mensage = new FrmMalo();
            DialogResult result = mensage.ShowDialog();

            if (result == DialogResult.OK)
            {
                socios.Estado = EstadoEntidad.Eliminar;
                socios.codigo = DataListadoSocios.CurrentRow.Cells["codigo"].Value.ToString();
                string r = socios.GuardarCambio();
                FrmBueno.Confirmancion(r);
          
                ListarSocios();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mover()
        {
            DataListadoSocios.Columns["nombre"].DisplayIndex = 1;
            DataListadoSocios.Columns["estado"].DisplayIndex = 5;
            DataListadoSocios.Columns["email"].Width = 200;
            DataListadoSocios.Columns["estado"].Width = 100;

        }
    }
}
