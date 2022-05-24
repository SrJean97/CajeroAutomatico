using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Sesion
    {

        Usuario usuario = new Usuario();
        public bool IniciarSesion(string user, string pass)
        {
            foreach(var item in usuario.ListaUsuarios)
            {
                if(item.User == user && item.Contrasenia == pass)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
    }
}
