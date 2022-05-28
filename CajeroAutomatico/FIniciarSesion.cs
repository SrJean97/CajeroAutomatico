using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FIniciarSesion : Form
    {
        Sesion sesion = new Sesion();        

        public FIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            if(txtContrasenia.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                string user = txtUsuario.Text;
                string contrasenia = txtContrasenia.Text;

                bool val = sesion.ValidarUsuario(user, contrasenia);

                if (val)
                {
                    this.Hide();
                    FOperacionesCuenta foc = new FOperacionesCuenta();
                    foc.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe, ingrese uno valido o registrese");
                    LimpiarCampos();
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRegistrarUsuario fRegistrarUsuario = new FRegistrarUsuario();
            fRegistrarUsuario.Show();
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }

    }
}
