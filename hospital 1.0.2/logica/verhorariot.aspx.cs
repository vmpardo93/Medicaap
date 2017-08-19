using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class verhorariot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAO_doctores doc = new DAO_doctores();
        DataTable com = new DataTable();
        int i;
        GridViewRow row;
        for (i = 0; i < GV_horario.Rows.Count; i++) {
            row = GV_horario.Rows[i];
            if (row != null)
            {
                B_registra.Visible = false;
            }
            else {
                B_registra.Visible = true;
            }
        }
    }
    protected void gv_updating(object sender, GridViewUpdateEventArgs e)
    {
        int index = e.RowIndex;
        GridViewRow row = (GridViewRow)GV_horario.Rows[index];
        DropDownList hora_inicio1 = (DropDownList)row.FindControl("DDL_horainicio");
        DropDownList hora_fin1 = (DropDownList)row.FindControl("DDL_horafin");
        String hora_inicio = hora_inicio1.SelectedValue;
        String hora_fin = hora_fin1.SelectedValue;
        e.NewValues.Add("hora_inicio", hora_inicio);
        e.NewValues.Add("hora_fin",hora_fin);

    }

    protected void B_registra_Click(object sender, EventArgs e)
    {
        Response.Redirect("Horariodoc.aspx");
    }
}