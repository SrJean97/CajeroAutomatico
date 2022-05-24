using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public abstract class Persona
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string user { get; set; }
        public string contrasenia { get; set; }

        public abstract void RegistrarUsuario(Usuario usuario);
    }
}
