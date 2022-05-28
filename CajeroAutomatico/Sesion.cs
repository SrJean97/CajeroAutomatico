using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public class Sesion
    {

        Usuario usuario = new Usuario();
        List<Usuario> listaUsuarios = new List<Usuario>();  

        public bool ValidarUsuario(string user, string pass)
        {
            try
            {
                listaUsuarios = usuario.ConsultarTodos();

                foreach (var u in listaUsuarios)
                {
                    if(u.user == user && u.contrasenia == pass)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de aplicación " + ex);
            }

            return false;
        }



    }
}
