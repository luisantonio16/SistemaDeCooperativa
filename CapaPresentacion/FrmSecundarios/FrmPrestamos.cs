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
using CapaNegocios.ObjetsValues;
using CapaPresentacion.FrmSecundarios;

namespace CapaPresentacion.FrmSecundarios
{
    public partial class FrmPrestamos : Form
    {

        private PrestamosModels prestamos = new PrestamosModels();
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            ListarPrestamos();
            mover();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarPrestamos()
        {
            try
            {
                DataListadoPrestamos.DataSource = prestamos.GetAll();


            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();


            }

        }

        private void TxtBuscarDocumento_TextChanged(object sender, EventArgs e)
        {
            DataListadoPrestamos.DataSource = prestamos.buscar(TxtBuscarDocumento.Text.Trim());
        }

        private void BtnNewPrestamo_Click(object sender, EventArgs e)
        {
            FrmFiltro filtro = new FrmFiltro();
            filtro.Show();
            AddPrestamos prestamos = new AddPrestamos();
            prestamos.ShowDialog();
            filtro.Close();
            ListarPrestamos();
        }

        private void mover()
        {
            //DataListadoPrestamos.Columns[""].DisplayIndex = 2;
            //DataListadoPrestamos.Columns[""].DisplayIndex = 2;
            DataListadoPrestamos.Columns["EstadoPrestamo"].DisplayIndex = 7;

            DataListadoPrestamos.Columns["idSocio"].Visible = false;
            DataListadoPrestamos.Columns["Descripcion"].Visible = false;
            DataListadoPrestamos.Columns["Fecha"].Width = 200;
            DataListadoPrestamos.Columns["EstadoPrestamo"].Width = 100;
        }
    }
}
