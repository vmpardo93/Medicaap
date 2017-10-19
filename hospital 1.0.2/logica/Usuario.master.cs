using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using utilitarios;


public partial class vista_Usuario : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();

        UUsuario user = (UUsuario)Session["objdata"];

        LUsuarios logica = new LUsuarios();
        logica.session(int.Parse(Session["id_user"].ToString()));

        L_Nombre.Text = "Bienvenido   " + user.Nombre;
        Im_Perfil.ImageUrl = user.DireccionImagen;

    }

    /*protected void B_cita_Click(object sender, EventArgs e)
    {
        Response.Redirect("Nuevacita.aspx"); 
    }
    protected void B_perfil_Click(object sender, EventArgs e)
    {
        Response.Redirect("Perfil.aspx"); 
    }*/
    protected void B_salir_Click(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        Session["id_user"] = null;
        Session["user"] = null;
        Session["rol_user"] = null;
        Response.Redirect("Login.aspx");
    }
    /* protected void B_Citas_Click(object sender, EventArgs e)
     {
         Response.Redirect("Citas.aspx"); 
     }
     protected void B_Resultados_Click(object sender, EventArgs e)
     {
         Response.Redirect("Resultados.aspx"); 
     }
     protected void B_doctores_Click(object sender, EventArgs e)
     {
         Response.Redirect("verdoctores.aspx");
     }
     protected void Button1_Click(object sender, EventArgs e)
     {
         Response.Redirect("CancelarCitas.aspx");

     }*/
}

