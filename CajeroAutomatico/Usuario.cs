using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public class Usuario : Persona
    {

        //En archivo de texto la salida debe ser la impresión del recibo de las operaciones que haga.
        public List<Usuario> ListaUsuarios;

        public Usuario() {
            ListaUsuarios = new List<Usuario>();
        }

        public Usuario(string cedula, string nombre, string user, string contrasenia)
        {

            this.cedula = cedula;
            this.nombre = nombre;
            this.user = user;
            this.contrasenia = contrasenia;
            ListaUsuarios = new List<Usuario>();
        }
        

        public override void RegistrarUsuario(Usuario usuario)
        {
            
            if(ListaUsuarios.Count == 0)
            {
                ListaUsuarios.Add(usuario);
                MessageBox.Show("Usuario creado correctamente");
            }
            else
            {
                foreach(var item in ListaUsuarios)
                {
                    if (item.cedula.Equals(usuario.cedula))
                    {
                        MessageBox.Show("El usuario ya se encuentra registrado");
                        break;
                    }
                    else
                    {
                        this.ListaUsuarios.Add(usuario);
                        MessageBox.Show("Usuario creado correctamente");
                    }
                }
            }
        }

        public Usuario ConsultarUsuario(string id)
        {

            Usuario uNuevo = new Usuario();

            foreach(Usuario u in ListaUsuarios)
            {
                if (u.cedula.Equals(id))
                {
                    uNuevo = u;
                }
                else
                {
                    MessageBox.Show("Usuario no se encuentra registrado");
                    break;
                }
            }
            return uNuevo;
        }

        public List<Usuario> ConsultarTodos()
        {
            List<Usuario> ul = new List<Usuario>();
            Usuario u = new Usuario();

            foreach(var item in ListaUsuarios)
            {
                u.cedula = item.cedula;
                u.nombre = item.nombre;
                u.user = item.user;
                u.contrasenia = item.contrasenia;
                ul.Add(u);
            }

            return ul;
        }
    }
}
