  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Data;
using utilitarios;
using Logica;

public partial class vista_RegistroDocAdmon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        Object nomb = Session["objdata"] as Object;
        String rol = Session["rol_user"] as String;
        String user = Session["user"] as String;
        LUsuarios logica = new LUsuarios();
        UUsuario datos = logica.ValidarSesionAdmin(Session["rol_user"].ToString(), Session["user"].ToString());

        this.RegisterStartupScript("mensaje", datos.Mensaje);
 
        

    }
    protected void B_enviar_Click(object sender, EventArgs e)
    {
        LDoctor logica = new LDoctor();
        Udoctor datos = new Udoctor();
        
        string img = cargarimg(FU_foto); 
        
        datos=logica.agregardoctor(TB_username.Text, TB_clave.Text, TB_nombre.Text, TB_apellido.Text, TB_edad.Text, TB_estudios.Text, TB_especialidad.Text, TB_correo.Text, TB_documento.Text,img);
        
        //Session["rol_id"] = datos.Idrol.ToString();
        Session["nombre"] = TB_nombre.Text.ToString();
        Session["User"] = datos;
        Session["clave"] = TB_clave.Text.ToString();

        this.RegisterStartupScript("mensaje", datos.Mensaje);
        
        TB_nombre.Text = "";
        TB_correo.Text = "";
        TB_clave.Text = "";
        TB_username.Text = "";
        TB_apellido.Text = "";
        TB_edad.Text = "";
        TB_documento.Text = "";
        }
        
    public string cargarimg(FileUpload FU_img) 
        /*este metodo es para cargar las imagenes contiene toda la logica para crear el nombre de la imagen y guardarla en la carpeta de 
         imgenes*/
    {
        LDoctor core = new LDoctor();
        
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
    