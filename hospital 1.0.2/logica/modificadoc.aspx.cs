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
        Udoctor datos= logica.ValidarSesiondoc(Session["rol_user"].ToString(),Session["user"].ToString());
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
        modificado(file, imagen);
        e.NewValues.Add("imagen", datos.Foto);
  /*
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
        }*/
    }
    public void modificado(FileUpload FU_imge,Label texte) 
    {
        Udoctor datos = new Udoctor();
        LDoctor logica= new LDoctor();
        string saveLocation = "";
        string save = "";

        ClientScriptManager cm = this.ClientScript;
        String nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(FU_imge.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FU_imge.PostedFile.FileName);
        nombreArchivo = nombreArchivo + DateTime.Now.ToFileTime().ToString() + extension;

        saveLocation = (Server.MapPath("~/Imagenes/Peliculas") + "/" + nombreArchivo);
        save = ("~/Imagenes/Peliculas") + "/" + nombreArchivo;
        try
        {

            string url = logica.modificadoc(save, saveLocation, FU_imge.HasFile,texte);
            FU_imge.PostedFile.SaveAs(datos.Foto);
        }
        catch (Exception exc)
        {

        }
    }
}