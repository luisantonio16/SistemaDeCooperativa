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
    public partial class FrmDetalleAhorro : Form
    {
        private AhorroModels ahorro = new AhorroModels();
        public FrmDetalleAhorro()
        {
            InitializeComponent();
        }

        private void FrmDetalleAhorro_Load(object sender, EventArgs e)
        {
            ListarDetalles(this.Tag.ToString());
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ListarDetalles(string codigo)
        {
            var table = new DataTable();
            table = ahorro.BuscarDetalleAhorro(codigo);


            try
            {
                DataListadoAhorros.DataSource = table;
                DataListadoAhorros.ClearSelection();
               
            }
            catch (Exception ex)
            {

            }
        }
    }
}
