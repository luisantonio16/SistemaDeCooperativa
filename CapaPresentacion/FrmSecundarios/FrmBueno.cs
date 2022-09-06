using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FrmSecundarios
{
    public partial class FrmBueno : Form
    {
        public FrmBueno(string mensaje)
        {
            InitializeComponent();
            LblMensaje.Text = mensaje;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void Confirmancion(string mensaje)
        {
            FrmBueno frm = new FrmBueno(mensaje);
            frm.ShowDialog();

        }

        private void FrmBueno_Load(object sender, EventArgs e)
        {

        }
    }
}
