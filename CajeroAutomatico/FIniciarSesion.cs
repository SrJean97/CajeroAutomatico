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
            
            try
            {
                if (txtContrasenia.Text == "" || txtUsuario.Text == "") 
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else
                {
                    string user = txtUsuario.Text;
                    string pass = txtContrasenia.Text;

                    bool se = sesion.IniciarSesion(user, pass);

                    if (se == true)
                    {
                        MessageBox.Show("Entramos");
                    }
                    else
                    {
                        MessageBox.Show("No entramos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error de aplicación");
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
