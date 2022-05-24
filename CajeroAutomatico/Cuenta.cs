using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Cuenta
    {
        public string NumeroCuenta { get; set; }
        public double Saldo { get; set; }

        public int Puntos = 3000;
        public DateTime Fecha { get; set; }

        public int ValorPuntos = 7;

        public double ValidarSaldo = 0;

        public Usuario usuario;

        List<Cuenta> ListaCuentas;

        public Cuenta() {
            this.Fecha = DateTime.Now;
            ListaCuentas = new List<Cuenta>();
        }

        public Cuenta(string NumeroCuenta, double Saldo, Usuario usuario)
        {
            this.NumeroCuenta = NumeroCuenta;
            this.Saldo = Saldo;
            this.usuario = usuario;
            this.Fecha = DateTime.Now;
            ListaCuentas = new List<Cuenta>();
        }


        public void CanjearPuntos(int puntosCanje)
        {

            int vp = 0;

            if(Puntos == 0)
            {
                Console.WriteLine("No tiene puntos para canjear");
            }
            else if(puntosCanje > Puntos)
            {
                Console.WriteLine("El limete de puntos que intenta canjear es mayor a los que tiene actualmente");
            }
            else
            {
                vp = (puntosCanje * ValorPuntos);
                Puntos -= puntosCanje;
                Saldo = (Saldo + vp);
            }
            
        }

        public void RegistrarCuenta(Cuenta cuenta)
        {
            if(ListaCuentas.Count == 0)
            {
                ListaCuentas.Add(cuenta);
                Console.WriteLine("Cuenta creada correctamente");
            }
            else
            {
                foreach(var item in ListaCuentas)
                {
                    if (item.NumeroCuenta.Equals(cuenta.NumeroCuenta))
                    {
                        Console.WriteLine("El numero de cuenta ya se encuentra registrado");
                    }
                    else if (cuenta.usuario.cedula == null)
                    {
                        Console.WriteLine("No existe un usuario asociado a la cuenta");
                    }
                    else
                    {
                        ListaCuentas.Add(cuenta);
                        Console.WriteLine("Cuenta creada correctamente");
                    }
                }
            }
        }

        public Cuenta ConsultarCuenta(string idCuenta)
        {
            Cuenta c = new Cuenta();


            foreach(var item in ListaCuentas)
            {
                if(item.NumeroCuenta == idCuenta)
                {
                    c = item;
                }
            }
            return c;
        }

       
        public void RetirarSaldo(double SaldoRetirar, string numeroCuenta)
        {
            
            if(SaldoRetirar > 2000000)
            {
                Console.WriteLine("No puede retirar más de 2 millones por día");
            }
            else if (Fecha == DateTime.Now) 
            {
                ValidarSaldo = (ValidarSaldo + SaldoRetirar);
                if(ValidarSaldo > 2000000)
                {
                    Console.WriteLine("No puede retirar más de 2 millones por día");
                }
                else if(ValidarSaldo > Saldo)
                {
                    Console.WriteLine("Saldo insuficiente en su cuenta para retirar");
                }
                else
                {
                    Saldo -= ValidarSaldo;
                    Console.WriteLine("Su saldo retirado fue de: " + ValidarSaldo);
                    Console.WriteLine("Saldo actual: " + Saldo);
                }
            }
            else
            {
                ValidarSaldo = 0;
                ValidarSaldo += SaldoRetirar;
                Saldo -= ValidarSaldo;
                Console.WriteLine("Su saldo retirado fue de: " + ValidarSaldo);
                Console.WriteLine("Saldo actual: " + Saldo);
            }
        }
    }
}
