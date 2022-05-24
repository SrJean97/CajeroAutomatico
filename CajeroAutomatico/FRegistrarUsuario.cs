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
    public partial class FRegistrarUsuario : Form
    {

        Usuario usuario = new Usuario();

        public FRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FIniciarSesion fis = new FIniciarSesion();
            fis.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtCedula.Text == "" || txtNombre.Text == "" || txtUsuario.Text == "" || txtContrasenia.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else
                {
                    
                    string cedula = txtCedula.Text;
                    string nombre = txtNombre.Text;
                    string user = txtUsuario.Text;
                    string contrasenia = txtContrasenia.Text;

                    Usuario uNuevo = new Usuario(cedula,nombre,user,contrasenia);
                    
                    usuario.RegistrarUsuario(uNuevo);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de aplicación " + ex);
            }
            
        }

        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }

    }
}
