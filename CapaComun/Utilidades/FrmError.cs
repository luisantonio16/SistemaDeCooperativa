using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaComun.Utilidades
{
    public partial class FrmError : Form
    {
        public FrmError(string mensaje)
        {
            InitializeComponent();
            LblMensaje.Text = mensaje;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void AdvertenciaError(string mensaje)
        {
            FrmError frm = new FrmError(mensaje);
            frm.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
