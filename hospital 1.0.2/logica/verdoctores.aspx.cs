using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using utilitarios;

public partial class vista_verdoctores : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios user = new LUsuarios();
        UUsuario datos = new UUsuario();
        datos = user.ValidarSesionAdmin(Session["rol_user"].ToString(), Session["user"].ToString());
        this.RegisterStartupScript("mensaje", datos.Mensaje);
    }
    protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        int index = e.RowIndex;
        GridViewRow row = (GridViewRow)GV_doctores.Rows[index];
        FileUpload file = (FileUpload)row.FindControl("Imagen");
        Label imagen = (Label)row.FindControl("Label1");

        if (file.HasFile)
        {
            String archivo = System.IO.Path.GetFileName(file.PostedFile.FileName);
            string extension = System.IO.Path.GetExtension(file.PostedFile.FileName);
            string savelocation = (Server.MapPath("~\\images\\Perfil") + "\\" + archivo);
            string nombreArchivo = archivo;
            e.NewValues.Add("imagen", "~\\images\\Perfil\\" + nombreArchivo);
            try
            {
                file.PostedFile.SaveAs(savelocation);
            }
            catch (Exception ex)
            {

            }
        }
        else
        {
            e.NewValues.Add("imagen", imagen.Text);
        }
    }
    
}
