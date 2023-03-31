using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ActividadXusuario
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Actividad Actividad { get; set; }
    }
}
