using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.FrmSecundarios;

namespace CapaPresentacion.FrmPrincipales
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

      
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                    //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                

            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();

            }
        }

        private void BtnSocios_Click(object sender, EventArgs e)
        {
           
            FrmSocios socios = new FrmSocios();
            socios.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
           
            FrmPrestamos socios = new FrmPrestamos();
            socios.ShowDialog();
         
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            FrmFiltro frmFiltro = new FrmFiltro();
            frmFiltro.Show();
            FrmPagos pagos = new FrmPagos();
            pagos.ShowDialog();
            frmFiltro.Close();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void BtnAhorros_Click(object sender, EventArgs e)
        {
            
            FrmAhorros ahorros = new FrmAhorros();
            ahorros.ShowDialog();
          
        }
    }
}
