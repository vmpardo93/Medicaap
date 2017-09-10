using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

public partial class vista_CancelarCitas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Lpacientes doctores = new Lpacientes();
        GridViewRow row = this.GV_CancelarCita.SelectedRow;
        int id_cita = int.Parse(GV_CancelarCita.DataKeys[row.RowIndex].Values[0].ToString());
//       doctores.CancelarCitasSeparadas(id_cita);
        Response.Redirect("CancelarCitas.aspx");
    }
}