using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_CancelarCitas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DAO_doctores doctores = new DAO_doctores();
        GridViewRow row = this.GV_CancelarCita.SelectedRow;
        int id_cita = int.Parse(GV_CancelarCita.DataKeys[row.RowIndex].Values[0].ToString());
        doctores.cancelarCitaUsuario(id_cita);
        Response.Redirect("CancelarCitas.aspx");
    }
}