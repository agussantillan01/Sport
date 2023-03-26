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
    public partial class agregarActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                txtHorarioInicio.Text = "  :  ";
                txtHorarioFin.Text = "  :  ";
                ModalidadNegocio modalidadNegocio = new ModalidadNegocio();
                ddlModalidad.DataSource = modalidadNegocio.ListarModalidad();
                ddlModalidad.DataTextField = "Modalidad";
                ddlModalidad.DataValueField = "Id";
                ddlModalidad.DataBind();


                UsuarioNegocio profesorNegocio = new UsuarioNegocio();
                ddlProfesores.DataSource = profesorNegocio.ListarProfesores();
                ddlProfesores.DataTextField = "Nombre";
                ddlProfesores.DataValueField = "Id";
                ddlProfesores.DataBind();




            }


        }

        protected void listDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto = listDias.SelectedItem.Text;
            if (txtDias.Text.Length == 0)
                txtDias.Text = texto;
            else

            if (!verificaDiaNoSeleccionado(texto))
                txtDias.Text += ", " + texto;
        }
        private bool verificaDiaNoSeleccionado(string txt)
        {
            string[] arrayTexto = txtDias.Text.Split(',');
            bool existe = false;
            foreach (var item in arrayTexto)
            {
                if (item == txt)
                {
                    existe = true;
                }

            }
            return existe;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtActividad.Text.Length != 0 && txtDias.Text.Length != 0 && txtFechaInicio.Text != null && txtFechaFin.Text != null && txtHorarioInicio.Text != null && txtHorarioFin.Text != null)
            {
                ActividadNegocio actividadNegocio = new ActividadNegocio();
                Actividad act = new Actividad();
                act.actividad = txtActividad.Text;
                act.Dias = txtDias.Text;
                act.fechaInicio = DateTime.Parse(txtFechaInicio.Text);
                act.fechaFin = DateTime.Parse(txtFechaFin.Text);
                act.horarioInicio = txtHorarioInicio.Text.Trim();
                act.horarioFin = txtHorarioFin.Text.Trim();
                act.Imagen = txtImagenUrl.Text;
                act.Profesor = new Usuario();
                act.Profesor.Id = int.Parse(ddlProfesores.SelectedValue);

                act.modalidad = new Modalidad();
                act.modalidad.Id = int.Parse(ddlModalidad.SelectedValue);
                actividadNegocio.Agregar(act);
                Response.Redirect("actividades.aspx", false);

            }
            else
            {
                lblErrorCampos.Text = "Recuerde completar todos los campos";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (txtDias.Text.Length != 0)
                txtDias.Text = "";
        }
    }


       
}