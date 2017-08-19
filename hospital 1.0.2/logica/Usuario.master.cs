using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class vista_Usuario : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        if (Session["id_user"] == null){
            Response.Redirect("Login.aspx");   //validamos el id del usuario
        }
        
        Usuario user = (Usuario)Session["user"];
        
        
        L_Nombre.Text="Bienvenido   "+(user.Nombre);
        Im_Perfil.ImageUrl = user.DireccionImagen;
        if((int.Parse(Session["rol_user"].ToString()))!=2){
            Response.Redirect("Login.aspx"); // validamos su rol
        }
        
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
