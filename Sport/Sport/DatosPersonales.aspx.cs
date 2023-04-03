using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport
{
    public partial class DatosPersonales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario us = (Usuario)Session["Usuario"];
            if (us != null && !IsPostBack)
            {
                txtApellido.Text = us.Apellido;
                txtNombre.Text = us.Nombre;
                txtDNI.Text = us.DNI.ToString();
                txtFechaNacimiento.Text = us.FechaNacimiento.ToString();
                txtEmail.Text = us.Email;

            }
        }

    protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario UsuarioSession = (Usuario)Session["Usuario"];
                UsuarioSession.Nombre = txtNombre.Text;
                UsuarioSession.Apellido = txtApellido.Text;
                UsuarioSession.DNI = int.Parse(txtDNI.Text);
                UsuarioSession.Email = txtEmail.Text;
                UsuarioSession.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);



                UsuarioNegocio negocio = new UsuarioNegocio();
                negocio.Modificar(UsuarioSession);
                string mensaje = "Datos guardados Correctamente.";
                string script = "alert('" + mensaje + "');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", script, true);

                Response.Redirect("Actividades.aspx");

            }
            catch (Exception )
            {
                Session.Add("Error", "Formato incorrecto. Por favor, revise los datos ingresados.");
                Response.Redirect("Errorlogin.aspx", false);
               
            }

            


        }

    }
}