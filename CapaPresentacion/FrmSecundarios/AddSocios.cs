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
using CapaPresentacion.Validaciones;
using CapaNegocios.ObjetsValues;


namespace CapaPresentacion.FrmSecundarios
{
    public partial class AddSocios : Form
    {
        private SociosModels sociosModels = new SociosModels();
        private TipoDocumentoModels tipo = new TipoDocumentoModels();
        public new bool Update = false;
        public AddSocios()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    string id = tipo.correlativo(1);
                    sociosModels.codigo = id;
                    sociosModels.nombre = TxtNombre.Text;
                    sociosModels.cedula = TxtCedula.Text;
                    sociosModels.telefono = TxtTelefono.Text;
                    sociosModels.estado = CmbEstado.Text;
                    sociosModels.email = TxtEmail.Text;
                   
                    

                    bool valid = new Validaciones.Validaciones(sociosModels).validado();
                    if (valid == true)
                    {
                        FrmFiltro frmFiltro = new FrmFiltro();
                        string resultado = sociosModels.GuardarCambio();
                        frmFiltro.Show();
                        FrmBueno.Confirmancion(resultado);
                        frmFiltro.Close();
                        tipo.actualizarCorrelativo(1);
                        limpiar();
                    }

                }
                catch (Exception ex)
                {
                    string mensaje = ex.ToString();
                    MessageBox.Show(mensaje);
                }

            }
            else if (Update == true)
            {
                try
                {
                    sociosModels.Estado = EstadoEntidad.Actualizar;
                    sociosModels.codigo = TxtId.Text;
                    sociosModels.nombre = TxtNombre.Text;
                    sociosModels.cedula = TxtCedula.Text.ToString();
                    sociosModels.telefono = TxtTelefono.Text.ToString();
                    sociosModels.estado = CmbEstado.Text;
                    sociosModels.email = TxtEmail.Text.ToString();

                    bool valid = new Validaciones.Validaciones(sociosModels).validado();
                    if (valid == true)
                    {

                        string resultado = sociosModels.GuardarCambio();
                        FrmBueno.Confirmancion(resultado);
                        Close();

                    }

                    Update = false;


                }
                catch (Exception ex)
                {
                    string mensaje = ex.ToString();
                  

                }

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar()
        {
            TxtCedula.Text = "";
            TxtNombre.Text = "";
            TxtTelefono.Text = "";
            TxtEmail.Text = "";
        }
    }
}
