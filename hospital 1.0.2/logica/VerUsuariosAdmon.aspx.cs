using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using utilitarios;

public partial class vista_VerUsuariosAdmon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios logica = new LUsuarios();
        UUsuario datos = logica.ValidarSesionAdmin(Session["rol_user"].ToString(), Session["user"].ToString());

        this.RegisterStartupScript("mensaje", datos.Mensaje);
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = this.GV_usuariosAdmon.SelectedRow;
        int id_usuario = int.Parse(GV_usuariosAdmon.DataKeys[row.RowIndex].Values[0].ToString());
        Session["usuarioSeleccionado"] = id_usuario;
        Response.Redirect("Reportecitas.aspx");
        
    }
}