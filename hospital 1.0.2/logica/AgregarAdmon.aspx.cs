using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using utilitarios;
using Logica;

public partial class vista_AgregarAdmon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios logica = new LUsuarios();
        UUsuario datos = logica.ValidarSesionAdmin(Session["rol_user"].ToString(), Session["user"].ToString());

        this.RegisterStartupScript("mensaje", datos.Mensaje);
        
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
     }
    protected void B_cargarmedicina_Click(object sender, EventArgs e)
    {

        try
        {
            Lmedicinas logica = new Lmedicinas();
            logica.registromedicina(TB_medicina.Text);
            Response.Redirect("AgregarAdmon.aspx");
        }
        catch (Exception Ex)
        {
            this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('ya existe esta medicina);</script>"));
        }
        
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
    }
    protected void B_CargarAlergia_Click(object sender, EventArgs e)
    {
        try
        {

            Lalergias logica = new Lalergias();
            logica.agregaalergia(TB_alergia.Text);
            Response.Redirect("AgregarAdmon.aspx");
        }
        catch (Exception Ex)
        {
            this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('ya existe esta alergia);</script>"));
        }
        
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
    }


    protected void updating(object sender, GridViewUpdateEventArgs e)
    {


        int index = e.RowIndex;
        GridViewRow row = (GridViewRow)GV_parametriza.Rows[index];
        DropDownList duracion = (DropDownList)row.FindControl("DDL_duracion");
        DropDownList hora_inicio1 = (DropDownList)row.FindControl("DDL_horainicio");
        DropDownList hora_fin1 = (DropDownList)row.FindControl("DDL_horafin");
        String hora_inicio = hora_inicio1.SelectedValue;
        String hora_fin = hora_fin1.SelectedValue;
        String duraci = duracion.SelectedValue;

        Lparametriza logica = new Lparametriza();
        //logica.parametrizacitas(duraci, hora_inicio, hora_fin); 

        e.NewValues.Add("duracion_citas", duraci);
        e.NewValues.Add("hora_inicio", hora_inicio);
        e.NewValues.Add("hora_fin", hora_fin);

    }
}