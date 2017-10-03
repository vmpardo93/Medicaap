using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using utilitarios;
using Logica;

public partial class vista_doctoresAdminV : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios logica = new LUsuarios();
        UUsuario datos = logica.ValidarSesionAdmin(Session["rol_user"].ToString(), Session["user"].ToString());

        this.RegisterStartupScript("mensaje", datos.Mensaje);
    }
    
    protected void gv_modifia(object sender, GridViewUpdatedEventArgs e)
    {

    }
    protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        int index = e.RowIndex;
        GridViewRow row = (GridViewRow)GV_Doctores.Rows[index];
        FileUpload file = (FileUpload)row.FindControl("Imagen");
        Label imagen = (Label)row.FindControl("Label11");
        DropDownList drop = (DropDownList)row.FindControl("DL_Estado");
        String estado = drop.SelectedValue;
        e.NewValues.Add("estado", estado);
        
        
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