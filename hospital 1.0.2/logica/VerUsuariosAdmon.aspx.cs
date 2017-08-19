using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_VerUsuariosAdmon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        DAO_doctores doctores = new DAO_doctores();
        GridViewRow row = this.GV_usuariosAdmon.SelectedRow;
        int id_usuario = int.Parse(GV_usuariosAdmon.DataKeys[row.RowIndex].Values[0].ToString());
        Session["usuarioSeleccionado"] = id_usuario;
        Response.Redirect("Reportecitas.aspx");
        
    }
}