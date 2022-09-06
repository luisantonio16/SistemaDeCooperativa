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
using CapaNegocios.ObjetsValues;

namespace CapaPresentacion.FrmSecundarios
{
    public partial class AddAhorros : Form
    {
        private SociosModels socios = new SociosModels();
        private AhorroModels ahorro = new AhorroModels();
        private TipoDocumentoModels tipo = new TipoDocumentoModels();
        public new bool update = false;

        public AddAhorros()
        {
            InitializeComponent();
        }

        private void AddAhorros_Load(object sender, EventArgs e)
        {
            ListarSocios();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarSocios()
        {
            CmbSocios.DataSource = socios.GetAll();
            CmbSocios.DisplayMember = "nombre";
            CmbSocios.ValueMember = "codigo";
            CmbSocios.SelectedItem = null;

        }

        private void CmbSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbSocios.SelectedItem != null)
            {
                LblIdSocio.Text = CmbSocios.SelectedValue.ToString();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                try
                {
                    ahorro.idAhorro = TxtIdAhorro.Text;
                    ahorro.idSocio = LblIdSocio.Text;
                    ahorro.cuenta = "Ninguna";
                    ahorro.Total = Convert.ToDouble(TxtTotal.Text);
                    ahorro.NomSocio = CmbSocios.Text;
                    ahorro.Estado = "Activo";

                    bool valid = new Validaciones.Validaciones(ahorro).validado();
                    if (valid == true)
                    {
                        string result = ahorro.GuardarCambio();
                        ahorro.AgregarDetalleAhorro(TxtIdAhorro.Text, Convert.ToDouble(TxtTotal.Text), "Activo");
                        FrmBueno.Confirmancion(result);
                        tipo.actualizarCorrelativo(4);
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    FrmError.AdvertenciaError("Erro Agregando Ahorros");
                }
            }
            else
            {
                try
                {
                    double total = Convert.ToDouble(LblTotal.Text) + Convert.ToDouble(TxtTotal.Text);
                    ahorro.estado = EstadoEntidad.Actualizar;
                    ahorro.idAhorro = TxtIdAhorro.Text;
                    ahorro.Total = Convert.ToDouble(TxtTotal.Text);


                    bool valid = new Validaciones.Validaciones(ahorro).validado();
                    if (valid == true)
                    {
                        string result = ahorro.GuardarCambio();
                        ahorro.AgregarDetalleAhorro(TxtIdAhorro.Text, Convert.ToDouble(TxtTotal.Text), "Activo");
                        FrmBueno.Confirmancion(result);
                        Limpiar();
                    }

                    update = false;
                }
                catch (Exception ex)
                {
                    FrmError.AdvertenciaError("Erro Editando Ahorros");
                }
            }
           
        }

        private void Limpiar()
        {
            TxtIdAhorro.Text = "";
            CmbSocios.SelectedItem = null;
            TxtTotal.Text = "";
            LblIdSocio.Text = "";
        }
    }
}
