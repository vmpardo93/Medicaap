using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterDoctores : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        
       if (Session["id_user"] == null && (int.Parse(Session["rol_user"].ToString())) != 3)
        {
            Response.Redirect("Login.aspx");   //validamos el id del usuario
        }
       
       

        Usuario user = (Usuario)Session["user"];

        Im_Perfil.ImageUrl = user.DireccionImagen;
    }
    protected void B_salir_Click(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        Session["id_user"] = null;
        Session["user"] = null;
        Session["rol_user"] = null;
        Response.Redirect("Login.aspx"); 
    }
}
