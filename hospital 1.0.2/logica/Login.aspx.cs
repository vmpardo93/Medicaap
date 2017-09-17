using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Logica;
using utilitarios;

public partial class vista_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["id_user"] = null;
        Session["id_user"] = null;
        Session["user"] = null;
        Session["rol_user"] = null;

        Response.Cache.SetNoStore();
        
    }



    protected void B_Entrar_Click(object sender, EventArgs e)
    {
      
        UUsuario user = new UUsuario();
        LUsuarios log = new LUsuarios();
        user = log.loggin(TB_username.Text, TB_Clave.Text);

        Session["id_user"] = user.Id_usuario;
        Session["user"] = user.Username;
        Session["rol_user"] = (user.Idrol.ToString());
        Session["objdata"] = user;

        this.RegisterStartupScript("mensaje",user.Mensaje);

    }

    protected void B_Registro_Click(object sender, EventArgs e)
    {
        TB_Clave.Text = "";
        TB_username.Text = "";
        Response.Redirect("registro.aspx");
    }



    protected void IB_HomeLogin_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Inicio.aspx");
    }
}
