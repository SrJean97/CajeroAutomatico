using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Usuario : Persona
    {

        //En archivo de texto la salida debe ser la impresión del recibo de las operaciones que haga.
        List<Usuario> ListaUsuarios;

        public Usuario() {
            ListaUsuarios = new List<Usuario>();
        }

        public Usuario(string Cedula, string Nombre, string User, string Contrasenia)
        {

            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.User = User;
            this.Contrasenia = Contrasenia;

            ListaUsuarios = new List<Usuario>();

        }

        

        public override void RegistrarPersona(Usuario usuario)
        {
            
            if(ListaUsuarios.Count == 0)
            {
                ListaUsuarios.Add(usuario);
                Console.WriteLine("Usuario creado correctamente");
            }
            else
            {
                foreach(var item in ListaUsuarios)
                {
                    if (item.Cedula.Equals(usuario.Cedula))
                    {
                        Console.WriteLine("El usuario ya se encuentra registrado");
                        break;
                    }
                    else
                    {
                        ListaUsuarios.Add(usuario);
                        Console.WriteLine("Usuario creado correctamente");
                    }
                }
            }
        }

        public Usuario ConsultarUsuario(string cedula)
        {

            Usuario u = new Usuario();

            foreach(var item in ListaUsuarios)
            {
                if (item.Cedula.Equals(cedula)) u = item;                
            }
            return u;
        }
    }
}
