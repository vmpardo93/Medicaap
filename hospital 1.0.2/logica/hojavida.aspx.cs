using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hojavida : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BT_enviar_Click(object sender, EventArgs e)
    {
        if (Session["id_user"] != null && Session["rol_user"].ToString().Equals("3"))
        {
            Ehojavida doctores = new Ehojavida();
            DAO_doctores bases = new DAO_doctores();
            bases.guardarhojavida(TB_bachiller.Text, TB_estudios.Text, TB_fellows.Text, TB_idiomas.Text, TB_perfil.Text, TB_universidad.Text, TB_experiencia.Text, Session["id_user"].ToString());
            Response.Redirect("editarhojavida.aspx");
        }
        else
        {
            Session["rol_user"] = null;
            Session["id_user"] = null;
            Response.Redirect("Login.aspx");

        }
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
       


    }
}