using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void B_cargar_Click(object sender, EventArgs e)
    {
        DAO_paciente paciente = new DAO_paciente();
        DataTable dataV = new DataTable();
        dataV=paciente.verificarusuario(TB_username.Text);
        if(dataV.Rows.Count>0){
            this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('Ese nombre de usuario ya esta en uso');</script>"));
        }
        else{
        EUsuario usuario = new EUsuario();
        DUsuario data = new DUsuario();

        string saveLocation = "";
        string save = "";

        String nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(FU_foto.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FU_foto.PostedFile.FileName);
        nombreArchivo = nombreArchivo + DateTime.Now.ToFileTime().ToString() + extension;

        saveLocation = (Server.MapPath("~/images/Perfil") + "/" + nombreArchivo);
        save = ("~/images/Perfil") + "/" + nombreArchivo;

        try
        {
            usuario.Username = TB_username.Text;
            usuario.Clave = TB_clave.Text;
            usuario.Nombre = TB_nombre.Text;
            usuario.Apellido = TB_apellido.Text;
            usuario.Edad = TB_edad.Text;
            usuario.Tiposangre = DDL_tipo_sangre.Text;
            usuario.Correo = TB_correo.Text;
            usuario.Documento = TB_documento.Text;
            usuario.Fechaexamen = TB_examen.Text;
            usuario.Foto = save;
            data.insertar_paciente(usuario);
            FU_foto.PostedFile.SaveAs(saveLocation);
            Response.Write("<script>window.alert('Registro exitoso');</script>");
            Response.Redirect("RegistroDocAdmon.aspx");

        }
        catch (FormatException ex)
        {
            Response.Write("<script>window.alert('Error el formato digitado en alguno de los campos no es esl solicitado');</script>");
        }
        catch (Exception ex)
        {
            Response.Write("<script>window.alert('Error registro no exitoso');</script>");
        }
            
    }
    }
}