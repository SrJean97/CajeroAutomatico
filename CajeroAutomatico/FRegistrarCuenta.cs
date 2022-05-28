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
    public partial class FRegistrarCuenta : Form
    {

        Cuenta cuenta = new Cuenta();
        
        public FRegistrarCuenta()
        {
            InitializeComponent();
        }

        private void btnRegistrarCuenta_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtCedula.Text == "" || txtNumeroCuenta.Text == "" || txtSaldoInicial.Text == "" || txtPuntos.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else
                {
                    string cedula = txtCedula.Text;
                    string numeroCuenta = txtNumeroCuenta.Text;
                    double saldoInicial = double.Parse(txtSaldoInicial.Text);
                    int puntos = int.Parse(txtPuntos.Text);

                    cuenta.RegistrarCuenta(new Cuenta(numeroCuenta, saldoInicial, puntos, cedula));
                    VaciarCampos();
                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Error de aplicacion " + er);
            }


            
        }

        private void btnCerrarCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
            FRegistrarUsuario fru = new FRegistrarUsuario();
            fru.Show();
        }

        private void VaciarCampos()
        {
            txtCedula.Clear();
            txtNumeroCuenta.Clear();
            txtSaldoInicial.Clear();
            txtPuntos.Clear();
        }
    }
}
