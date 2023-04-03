using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

    public enum TipoUsuario
    {
        NORMAL = 1,
        ADMIN = 2

    }
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? DNI { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Profesor { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
    }


}
