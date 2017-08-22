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

    }
    protected void B_enviar_Click(object sender, EventArgs e)
    {
        LDoctor logica = new LDoctor();
        DAOdoctores doc = new DAOdoctores();
        DataTable dataV = new DataTable();

        dataV = paciente.verificarusuario(TB_username.Text);
        if (dataV.Rows.Count > 0)
        {
            this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('Ese nombre de usuario ya esta en uso');</script>"));
        }
        else
        {
            Edoctores doctores = new Edoctores();
            DUsuario data = new DUsuario();
            /*envio todos los datos que estan en lo texbox a la clase que encapsula 
             y a la clase que usa la funcion de la base de datos para guardar los datos del doctor*/
            ClientScriptManager cm = this.ClientScript;
            /*este if lo uso para la confirmacion de la clave si son diferentes*/



            string saveLocation = "";
            string save = "";


            String nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(FU_foto.PostedFile.FileName);
            string extension = System.IO.Path.GetExtension(FU_foto.PostedFile.FileName);
            nombreArchivo = nombreArchivo + DateTime.Now.ToFileTime().ToString() + extension;

            saveLocation = (Server.MapPath("~/images/Perfil") + "/" + nombreArchivo);
            save = ("~/images/Perfil") + "/" + nombreArchivo;

            try
            {


                doctores.Username = TB_username.Text;
                doctores.Clave = TB_clave.Text;
                doctores.Nombre = TB_nombre.Text;
                doctores.Apellido = TB_apellido.Text;
                doctores.Edad = TB_edad.Text;
                doctores.Estudios = TB_estudios.Text;
                doctores.Especialidad = TB_especialidad.Text;
                doctores.Estado = "1";
                doctores.Correo = TB_correo.Text;
                doctores.Documento = Int64.Parse(TB_documento.Text);
                doctores.Url = save;
                data.insertar_doctor(doctores);
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