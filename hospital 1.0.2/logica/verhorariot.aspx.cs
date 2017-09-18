using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using utilitarios;
using Logica;

public partial class verhorariot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Uhorario datos = new Uhorario();
            LUsuarios users = new LUsuarios();
            Object nomb = Session["objdata"] as Object;
            String rol = Session["rol_user"] as String;
            String user = Session["user"] as String;
            String val = Convert.ToString(GV_horario.Rows.Count);
            Lhorario logic = new Lhorario();
            datos=logic.validar_existe_horario(val,Session["id_user"].ToString());
            this.RegisterStartupScript("mensaje", datos.Mensaje);
        }
        catch (Exception ex)
        {

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
}