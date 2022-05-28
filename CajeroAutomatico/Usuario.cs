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
        public string user { get; set; }
        public string contrasenia { get; set; }

        public static List<Usuario> listaUsuarios = new List<Usuario>();

        public Usuario() { }

        public Usuario(string cedula, string nombre, string user, string contrasenia)
        {

            this.cedula = cedula;
            this.nombre = nombre;
            this.user = user;
            this.contrasenia = contrasenia;
        }
        

        public override void RegistrarUsuario(Usuario usuario)
        {
            try
            {
                int contador = 0;

                if (listaUsuarios.Count == 0)
                {
                    listaUsuarios.Add(usuario);
                    MessageBox.Show("Usuario creado correctamente");
                }
                else
                {
                    foreach (var usuario1 in listaUsuarios)
                    {
                        if (usuario1.cedula.Equals(usuario.cedula))
                        {
                            contador += 1;
                        }
                    }

                    if (contador == 0)
                    {
                        listaUsuarios.Add(usuario);
                        MessageBox.Show("Usuario creado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya se encuentra registrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de aplicación - " + ex.Message);
            }
        }

        public Usuario ConsultarUsuario(string id)
        {

            Usuario uNuevo = new Usuario();

            foreach(Usuario u in listaUsuarios)
            {
                if (u.cedula.Equals(id))
                {
                    uNuevo = u;
                }
            }
            return uNuevo;
        }

        public List<Usuario> ConsultarTodos()
        {
            List<Usuario> list = new List<Usuario>();
            
            foreach(Usuario item in listaUsuarios)
            {
                Usuario us = new Usuario();
                us.cedula = item.cedula;
                us.nombre = item.nombre;
                us.user = item.user;   
                us.contrasenia = item.contrasenia;
                list.Add(us);
            }

            return list;

        }
    }
}
