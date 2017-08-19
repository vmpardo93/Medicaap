using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_MasterAdminVic : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        if (Session["id_user"] == null)
        {
            Response.Redirect("Login.aspx");   //validamos el id del usuario
        }

        Usuario user = (Usuario)Session["user"];
        if ((int.Parse(Session["rol_user"].ToString())) != 1)
        {
            Response.Redirect("Login.aspx"); // validamos su rol
        }
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
