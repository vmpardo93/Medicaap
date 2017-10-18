using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using utilitarios;


public partial class vista_CancelarCitas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios user = new LUsuarios();
        UUsuario datos = new UUsuario();
        datos = user.ValidarSesionPaci(Session["rol_user"].ToString(), Session["user"].ToString());
        this.RegisterStartupScript("mensaje", datos.Mensaje);
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Lcitas doctores = new Lcitas();
        GridViewRow row = this.GV_CancelarCita.SelectedRow;
        int id_cita = int.Parse(GV_CancelarCita.DataKeys[row.RowIndex].Values[0].ToString());
        doctores.cancelarCitasUsuario(id_cita);
        Response.Redirect("CancelarCitas.aspx");
        
    }
}