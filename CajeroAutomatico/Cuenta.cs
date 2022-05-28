using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CajeroAutomatico
{
    internal class Cuenta
    {
        public string numeroCuenta { get; set; }
        public double saldo { get; set; }
        public int puntos { get; set; }
        public string idUsuario { get; set; }
        public DateTime fecha { get; set; }

        public static List<Cuenta> listaCuentas = new List<Cuenta>();

        //public static List<string> lista

        Usuario usuario = new Usuario();

        public Cuenta() { }

        public Cuenta(string numeroCuenta, double saldo, int puntos, string idUsuario)
        {
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.puntos = puntos;
            this.idUsuario = idUsuario;
        }

        public void RegistrarCuenta(Cuenta cuenta)
        {
            try
            {
                int contadorLista = 0;
                int contadorUsuarios = 0;

                foreach (var item in usuario.ConsultarTodos())
                {
                    if (item.cedula.Equals(cuenta.idUsuario))
                    {
                        contadorUsuarios += 1;
                    }
                }

                if(contadorUsuarios == 0)
                {
                    MessageBox.Show("El usuario al que intenta crearle la cuenta no existe");
                }
                else
                {
                    foreach (var item in listaCuentas)
                    {
                        if (item.numeroCuenta.Equals(cuenta.numeroCuenta))
                        {
                            contadorLista += 1;
                        }
                    }

                    if (contadorLista > 0)
                    {
                        MessageBox.Show("El numero de cuenta ya existe");
                    }
                    else
                    {
                        listaCuentas.Add(cuenta);
                        MessageBox.Show("Cuenta creada correctamente");
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error de aplicación: " + e);
            }
            
        }

        public Cuenta ConsultarCuentaNCuenta(string idCuenta)
        {
            Cuenta c = new Cuenta();

            if(listaCuentas.Count == 0)
            {
                MessageBox.Show("No hay cuentas registradas para mostrar");
            }
            else
            {
                foreach (var item in listaCuentas)
                {

                    if (item.numeroCuenta == idCuenta)
                    {
                        c = item;
                    }
                }
            }

            
            return c;
        }

        public Cuenta ConsultarCuentaCedula(string idUsuario)
        {
            Cuenta c = new Cuenta();


            foreach (var item in listaCuentas)
            {
                if (item.idUsuario == idUsuario)
                {
                    c = item;
                }
            }
            return c;
        }

        public void EnviarDinero(double nuevoSaldo, string numeroCuentaEnviar, string numeroCuentaOrigen)
        {
            try
            {
                
                int contador = 0;
                string numeroCuenta = "";

                Cuenta cuenta = new Cuenta();


                if (numeroCuentaOrigen.Equals(numeroCuentaEnviar)){
                    MessageBox.Show("El numero de cuenta a enviar no debe ser su misma cuenta");
                }
                else
                {
                    foreach (var item in listaCuentas)
                    {
                        if (item.numeroCuenta.Equals(numeroCuentaEnviar))
                        {
                            contador += 1;
                        }
                    }

                    if(contador > 0)
                    {
                        cuenta = ConsultarCuentaNCuenta(numeroCuentaOrigen);
                        if(cuenta.saldo < nuevoSaldo)
                        {
                            MessageBox.Show("Fondos insuficientes");
                        }
                        else
                        {
                            cuenta.saldo -= nuevoSaldo;
                            Cuenta c = new Cuenta();
                            c = ConsultarCuentaNCuenta(numeroCuentaEnviar);
                            c.saldo += nuevoSaldo;
                            MessageBox.Show("Envio realizado con éxito");
                            using (StreamWriter escribirArchivo = new StreamWriter("F:/envios.txt", false)
                            {
                                
                            }

                        }                        
                    }
                    else
                    {
                        MessageBox.Show("El numero de cuenta a enviar no existe");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de aplicación " + ex);    
            }
        }

        public void RetirarDinero(double saldoRetirar, string numeroCuenta)
        {
            try
            {
                Cuenta cuenta = new Cuenta();
                cuenta = ConsultarCuentaNCuenta(numeroCuenta);

                if(cuenta != null)
                {
                    if(cuenta.saldo == 0)
                    {
                        MessageBox.Show("La cuenta no tiene dinero para retirar");
                    }
                    else
                    {
                        if(cuenta.saldo < saldoRetirar)
                        {
                            MessageBox.Show("Fondos insuficientes");
                        }
                        else
                        {
                            cuenta.saldo -= saldoRetirar;
                            MessageBox.Show("Retiro exitoso");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La cuenta no existe");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }        

        public void CanjearPuntos(int puntosCanje, string numeroCuenta)
        {

            double vp = 0;
            double valorPuntos = 0.7;

            foreach (var item in listaCuentas)
            {
                if (item.numeroCuenta.Equals(numeroCuenta))
                {
                    if (item.puntos == 0)
                    {
                        MessageBox.Show("No tiene puntos para canjear");
                    }
                    else if (puntosCanje > item.puntos)
                    {
                        MessageBox.Show("El limete de puntos que intenta canjear es mayor a los que tiene actualmente");
                    }
                    else
                    {

                        vp = (puntosCanje * valorPuntos);
                        item.puntos -= puntosCanje;
                        item.saldo = (item.saldo + vp);
                        MessageBox.Show("Puntos canjeados con éxito");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("La cuenta no existe");
                }
            }

        }
    }
}
