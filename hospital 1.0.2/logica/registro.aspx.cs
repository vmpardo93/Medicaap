using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Logica;
using utilitarios;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void B_cargar_Click(object sender, EventArgs e)
    {

        Lpacientes paciente = new Lpacientes();
        UUsuario usuario = new UUsuario();
        string img = cargarimg(FU_foto); 
        usuario = paciente.agregapacientes(TB_username.Text, TB_clave.Text, TB_nombre.Text, TB_apellido.Text, TB_edad.Text, DDL_tipo_sangre.Text, TB_correo.Text, TB_documento.Text, TB_examen.Text, img);
        
        Session["rol_id"] = usuario.Idrol.ToString();
        Session["nombre"] = TB_nombre.Text.ToString();
        Session["User"] = usuario;
        Session["clave"] = TB_clave.Text.ToString();

        this.RegisterStartupScript("mensaje", usuario.Mensaje); TB_nombre.Text = "";
        TB_correo.Text = "";
        TB_clave.Text = "";
        TB_username.Text = "";
        TB_apellido.Text = "";
        TB_edad.Text = "";
        TB_documento.Text = "";
        TB_examen.Text = "";

    }
    public string cargarimg(FileUpload FU_img) 
        /*este metodo es para cargar las imagenes contiene toda la logica para crear el nombre de la imagen y guardarla en la carpeta de 
         imgenes*/
    {
        Lpacientes core = new Lpacientes();
        
        string saveLocation = "";
        string save = "";

        String nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(FU_img.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FU_img.PostedFile.FileName);
        nombreArchivo = nombreArchivo + DateTime.Now.ToFileTime().ToString() + extension;

        saveLocation = (Server.MapPath("~/images/Perfil") + "/" + nombreArchivo);
        save = ("~/images/Perfil") + "/" + nombreArchivo;
        try
        {
            FU_img.PostedFile.SaveAs(saveLocation);
        }
        catch(Exception exc) 
        {
        }
        return save;
    }
}