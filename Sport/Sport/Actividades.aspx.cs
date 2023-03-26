using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport
{
    public partial class Actividades : System.Web.UI.Page
    {
        public List<Actividad> listaActividades { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ActividadNegocio actNegocio = new ActividadNegocio();
            listaActividades = actNegocio.Listar();

            repetidor.DataSource = listaActividades;
            repetidor.DataBind();

        }
    }
}