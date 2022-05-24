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
        Usuario usuario;
        Sesion sesion;

        public FIniciarSesion()
        {
            InitializeComponent();
            usuario = new Usuario();
            sesion = new Sesion();
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
                    bool ValidarSesion = sesion.IniciarSesion(user, pass);
                    if(ValidarSesion)
                    {
                        MessageBox.Show("Existiomos wey");
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe, intente de nuevo o registrese");
                    }
                }
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error de aplicación");
            }
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }
    }
}
