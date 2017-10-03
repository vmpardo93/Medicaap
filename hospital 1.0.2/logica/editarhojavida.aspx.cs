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
        try
        {
            Uhojavida datos = new Uhojavida();
            Lhojavida logic = new Lhojavida();
            String valida =Convert.ToString(GV_hojavida.Rows.Count);
            LUsuarios users = new LUsuarios();
            Object nomb = Session["objdata"] as Object;
            String rol = Session["rol_user"] as String;
            String user = Session["user"] as String;
            string val =logic.validargrid(valida,rol);
            Response.Redirect(val);  
        }
        catch (Exception ex)
        {
 
        }
    }
}