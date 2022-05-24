using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    internal class Sesion
    {
        

        public bool IniciarSesion(string user, string pass)
        {
            Usuario usuario = new Usuario();

            foreach (Usuario u in usuario.ListaUsuarios) 
            {
                if(u.user == user && u.contrasenia == pass)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
    }
}
