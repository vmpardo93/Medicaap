using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class editarhojavida : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id_user"] != null && Session["rol_user"].ToString().Equals("3"))
        {
            Edoctores doctores = new Edoctores();
            DAO_doctores bases = new DAO_doctores();
            bases.buscarhojavida(Session["id_user"].ToString());
            int i;
            GridViewRow row;
            for (i = 0; i < GridView1.Rows.Count; i++)
            {
                row = GridView1.Rows[i];
                if (row != null)
                {
                    B_registra.Visible = false;
                }
                else
                {
                    B_registra.Visible = true;
                }
            }
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

    protected void B_registra_Click(object sender, EventArgs e)
    {
        Response.Redirect("hojavida.aspx");
    }
}