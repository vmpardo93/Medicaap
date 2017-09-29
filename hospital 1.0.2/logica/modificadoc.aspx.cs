using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using utilitarios;
using Logica;

public partial class modificadoc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios logica = new LUsuarios();
        Udoctor datos = logica.ValidarSesiondoc(Session["rol_user"].ToString(), Session["user"].ToString());
        this.RegisterStartupScript("mensaje", datos.Mensaje);

        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
    }
    protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        int index = e.RowIndex;
        Udoctor datos = new Udoctor();
        GridViewRow row = (GridViewRow)GridView1.Rows[index];
        FileUpload file = (FileUpload)row.FindControl("Imagen");
        Label imagen = (Label)row.FindControl("Label1");
        LDoctor doc = new LDoctor();
        /* modificado(file, imagen);
         e.NewValues.Add("imagen", datos.Foto);*/
        string aux;

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