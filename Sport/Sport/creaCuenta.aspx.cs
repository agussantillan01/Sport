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
    public partial class creaCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Email = txtEmail.Text;
            usuario.Password = txtPassword.Text;
            if (usuario.Nombre != "" && usuario.Password != "" && usuario.Email != "" && usuario.Password != "")
            {
                usuarioNegocio.Agregar(usuario);
                Response.Redirect("Default.aspx", false);
            }
            else
            {
                lblError.Text = "Recuerde completar todos los campos";
            }
        }
    }
}