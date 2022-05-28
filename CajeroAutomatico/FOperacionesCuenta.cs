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
    public partial class FOperacionesCuenta : Form
    {

        Cuenta cuenta = new Cuenta();

        public FOperacionesCuenta()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtNumeroCuenta.Text == "")
            {
                MessageBox.Show("Deber llenar el campo de numero de cuenta");
            }
            else
            {
                string numeroCuenta = txtNumeroCuenta.Text;
                Cuenta c1 = cuenta.ConsultarCuentaNCuenta(numeroCuenta);
                txtMostrarSaldo.Text = c1.saldo.ToString();
                txtPuntosDisponibles.Text = c1.puntos.ToString();
                txtSaldoActual.Text = c1.saldo.ToString();

            }
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            if(txtPuntosCanjear.Text == "")
            {
                MessageBox.Show("Deber llenar el campo de puntos canjear");
            }
            else
            {
                int puntosCanje = int.Parse(txtPuntosCanjear.Text);
                string numeroCuenta = txtNumeroCuenta.Text;

                cuenta.CanjearPuntos(puntosCanje, numeroCuenta);

                Cuenta c1 = cuenta.ConsultarCuentaNCuenta(numeroCuenta);
                txtMostrarSaldo.Text = c1.saldo.ToString();
                txtPuntosDisponibles.Text = c1.puntos.ToString();
                txtSaldoActual.Text = c1.saldo.ToString();

                txtPuntosCanjear.Clear();

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtNumeroCuentaEnviar.Text == "" || txtValorEnviar.Text == "")
            {
                MessageBox.Show("Para enviar dinero, debe llenar todos los campos requeridos");
            }
            else
            {

                string numeroCuentaOrigen = txtNumeroCuenta.Text;
                string numeroCuentaEnviar = txtNumeroCuentaEnviar.Text;
                double valor = double.Parse(txtValorEnviar.Text);

                cuenta.EnviarDinero(valor, numeroCuentaEnviar, txtNumeroCuenta.Text);

                Cuenta c1 = cuenta.ConsultarCuentaNCuenta(numeroCuentaOrigen);
                txtMostrarSaldo.Text = c1.saldo.ToString();
                txtPuntosDisponibles.Text = c1.puntos.ToString();
                txtSaldoActual.Text = c1.saldo.ToString();

                txtValorEnviar.Clear();
                txtNumeroCuentaEnviar.Clear();

            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if(txtSaldoRetirar.Text == "")
            {
                MessageBox.Show("Debe llenar los campos");
            }
            else
            {
                string numeroCuentaOrigen = txtNumeroCuenta.Text;
                double saldoRetirar = double.Parse(txtSaldoRetirar.Text);

                cuenta.RetirarDinero(saldoRetirar, numeroCuentaOrigen);
                Cuenta c1 = cuenta.ConsultarCuentaNCuenta(numeroCuentaOrigen);
                txtMostrarSaldo.Text = c1.saldo.ToString();
                txtPuntosDisponibles.Text = c1.puntos.ToString();
                txtSaldoActual.Text = c1.saldo.ToString();

                txtSaldoRetirar.Clear();
            }
        }
    }
}
