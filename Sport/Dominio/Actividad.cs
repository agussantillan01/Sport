using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Actividad
    {
        public int Id { get; set; }
        public Usuario Profesor { get; set; }
        public string Dias { get; set; }
        public string actividad { get; set; }
        public Modalidad modalidad { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string horarioInicio { get; set; }
        public string horarioFin { get; set; }
        public decimal precio { get; set; }
        public string Imagen { get; set; }
    }
}
