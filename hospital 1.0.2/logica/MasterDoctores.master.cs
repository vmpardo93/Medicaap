using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using utilitarios;
using Logica;

public partial class MasterDoctores : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        
        LUsuarios log = new LUsuarios();
        UUsuario datos = new UUsuario();
        
        String rol = Session["rol_user"] as String;
        String nombre = Session["user"] as String;
        Object nomb = Session["objdata"] as Object;
        datos = log.ValidarSesiondoc(rol, nombre, nomb);     

        Im_Perfil.ImageUrl = datos.Imagen;
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
