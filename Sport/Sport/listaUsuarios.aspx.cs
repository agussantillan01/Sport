using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport
{
    public partial class listaUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UsuarioNegocio usuario = new UsuarioNegocio();
                ddlListaUsuarios.DataSource = usuario.ListaUsuarios();
                ddlListaUsuarios.DataBind();
            }

        }


        protected void ddlListaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int id = int.Parse(ddlListaUsuarios.DataKeys[index]["Id"].ToString());

            UsuarioNegocio usNeg = new UsuarioNegocio();
            usNeg.AsignaProfesor(id);
            Response.Redirect("listaUsuarios.aspx", false);

        }
    }
}