using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal abstract class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Contrasenia { get; set; }

        public abstract void RegistrarPersona(Usuario usuario);
    }
}
