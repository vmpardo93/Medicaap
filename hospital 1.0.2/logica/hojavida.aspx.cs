using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using utilitarios;

public partial class hojavida : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        LUsuarios users = new LUsuarios();
        Object nomb = Session["objdata"] as Object;
        String rol = Session["rol_user"] as String;
        String user = Session["user"] as String;
        Udoctor datos = users.ValidarSesiondoc(rol, user);
        this.RegisterStartupScript("mensaje", datos.Mensaje);
    }
    protected void BT_enviar_Click(object sender, EventArgs e)
    {
        Lhojavida hojavida = new Lhojavida();
        Uhojavida datos =new Uhojavida() ;

        hojavida.agregar_hoja_vida(TB_bachiller.Text, TB_estudios.Text, TB_fellows.Text, TB_idiomas.Text, TB_perfil.Text, TB_universidad.Text, TB_experiencia.Text, Session["id_user"].ToString());

        this.RegisterStartupScript("mensaje", datos.Mensaje);
            
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
       


    }
}