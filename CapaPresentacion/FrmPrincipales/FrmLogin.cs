using CapaNegocios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FrmPrincipales
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text != "")
            {
                if (TxtPass.Text != "")
                {

                    UsuariosModels usuarios = new UsuariosModels();
                    var valido = usuarios.inicio(TxtUser.Text, TxtPass.Text);
                    if (valido == true)
                    {
                        this.Hide();
                        
                       
                       
                        FrmPrincipal menuPrincipal = new FrmPrincipal();
                        menuPrincipal.ShowDialog();
                        

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnLogin_Click(sender, e);

            }
        }
    }
}
