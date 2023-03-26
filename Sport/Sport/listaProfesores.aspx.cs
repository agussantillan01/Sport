using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport
{
    public partial class listaProfesores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UsuarioNegocio usuario = new UsuarioNegocio();
                dgvListaProfesores.DataSource = usuario.ListarProfesores();
                dgvListaProfesores.DataBind();
            }
        }
    }
}