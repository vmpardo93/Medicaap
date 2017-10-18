using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using utilitarios;
using Logica;

public partial class vista_Perfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios user = new LUsuarios();
        UUsuario datos = new UUsuario();
        datos = user.ValidarSesionPaci(Session["rol_user"].ToString(), Session["user"].ToString());
        this.RegisterStartupScript("mensaje", datos.Mensaje);
    }
}