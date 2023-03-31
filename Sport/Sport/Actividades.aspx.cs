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
        public List<ActividadXusuario> listaMisInscripciones { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ActividadNegocio actNegocio = new ActividadNegocio();
                listaActividades = actNegocio.Listar();

                repetidor.DataSource = listaActividades;
                repetidor.DataBind();
            }

            ActividadXusuarioNegocio actXusNeg = new ActividadXusuarioNegocio();
            listaMisInscripciones = actXusNeg.listarMisInscripciones(3);
            repetidorMisInscripciones.DataSource = listaMisInscripciones; 
            repetidorMisInscripciones.DataBind();   


        }

        private void generarAlerta(int id)
        {
            ActividadNegocio actNegocio = new ActividadNegocio();
            List<Actividad> listaActividades = actNegocio.Listar();
            Actividad act = listaActividades.Find(x => x.Id == id);
            string msjAlerta = "Te has inscripto a " + act.actividad + ", los dias " + act.Dias + ", de " + act.horarioInicio.ToString() + " a " + act.horarioFin + " ";
            ScriptManager.RegisterStartupScript(this, this.GetType(),
            "alert",
             "Confirm('" + msjAlerta + "'); ", true);


            //string script = "var respuesta = confirm('Quieres inscribirse a" + act.actividad + ", los dias" + act.Dias + " de " + act.horarioInicio + " a " + act.horarioFin + "'); if (respuesta == true);
            //ClientScript.RegisterStartupScript(this.GetType(), "alerta", script, true);




        }
        protected void btnInscribirse_Click(object sender, EventArgs e)
        {
            var idSeleccionado = int.Parse(((Button)sender).CommandArgument);
            //generarAlerta(idSeleccionado);
            ActividadXusuario actividadXusuario = new ActividadXusuario();


            UsuarioNegocio usNeg = new UsuarioNegocio();
            Usuario us = usNeg.ListaUsuarios().Find(x => x.Id == 3);
            actividadXusuario.Usuario = us;

            ActividadNegocio actNeg = new ActividadNegocio();
            Actividad act = actNeg.Listar().Find(x => x.Id == idSeleccionado);

            actividadXusuario.Actividad = act;

            ActividadXusuarioNegocio actXusuarioNeg = new ActividadXusuarioNegocio();
            actXusuarioNeg.Agregar(actividadXusuario); 




        }
    }
}