using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using utilitarios;
using Logica;

public partial class vista_MasterAdminVic : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        
        String rol = Session["rol_user"] as String;
        String nombre = Session["user"] as String;
        Object nomb = Session["objdata"] as Object;
    }

    protected void B_Salir_Click(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        Session["id_user"] = null;
        Session["user"] = null;
        Session["rol_user"] = null;
        Session["usuarioSeleccionado"] = null;
        Response.Redirect("Login.aspx");
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("VerUsuariosAdmon.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("doctoresAdminV.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroDocAdmon.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgregarAdmon.aspx");
    }
}