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
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usNeg = new UsuarioNegocio();
            Usuario us = usNeg.listaTodos().Find(x=> x.Email == txtEmail.Text && x.Password == txtPassword.Text);
            if (us != null)
            {
                Session.Add("Usuario", us);
                Response.Redirect("Default.aspx",false);
            }else
            {
                Session.Add("Error", "Usted no se ha registrado o su usuario y/o contraseña es incorrecta.");
                Response.Redirect("ErrorLogin.aspx", false);
            }
        }
    }
}