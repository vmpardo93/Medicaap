using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using utilitarios;
using Logica;

public partial class editarhojavida : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            Response.Cache.SetNoStore();
            LUsuarios users = new LUsuarios();
            Object nomb = Session["objdata"] as Object;
            String rol = Session["rol_user"] as String;
            String user = Session["user"] as String;
            users.ValidarSesiondoc(rol, user, nomb);
            
          
    }
}