using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Logica;
using utilitarios;

public partial class vista_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        Session["id_user"] = null;
        if(Session["id_user"] != null ){
            Session["id_user"] = null;
            Session["user"] = null;
            Session["rol_user"] = null;
        }
        
    }



    protected void B_Entrar_Click(object sender, EventArgs e)
    {
      
        UUsuario user = new UUsuario();
        LUsuarios log = new LUsuarios();
        user = log.loggin(TB_username.Text, TB_Clave.Text);

        Session["id_user"] = user.Id_usuario;
        Session["user"] = user.Username;
        Session["rol_user"] = (user.Idrol.ToString());
        ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect","alert('" + user.Mensaje + "'); window.location='" +Request.ApplicationPath + user.Url1 + "';", true);

       
   /*     mac mac=new mac();
        string ip=mac.IP();
        string umac = mac.Mac();
        data=usuario.buscarUsuarios(TB_username.Text.ToString(),TB_Clave.Text.ToString(),ip,umac);
        if (data.Rows.Count==0)
        {
            Session["id_user"] = null;
            //Response.Redirect("Login.aspx");
            this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('Verifique el UserName y la Clave');</script>"));

        }

        else
        {
            user.Nombre = (data.Rows[0]["nombre"].ToString());
            user.Apellido = (data.Rows[0]["apellido"].ToString());
            user.Username = (data.Rows[0]["username"].ToString());
            user.Rol = int.Parse(data.Rows[0]["id_rol"].ToString());
            user.Tipo_de_sangre = (data.Rows[0]["tipo_de_sangre"].ToString());
            user.Edad = (data.Rows[0]["edad"].ToString());
            user.Especialidad = (data.Rows[0]["especialidad"].ToString());
            user.Estudios = (data.Rows[0]["estudios"].ToString());
            user.Fecha_ultimo_examen = (data.Rows[0]["fecha_de_ultimo_examen"].ToString());
            user.Id_usuario = int.Parse(data.Rows[0]["id_usuario"].ToString());
            user.DireccionImagen = (data.Rows[0]["imagen"].ToString());
            
            
             

            if (user.Rol.Equals(1))
            {
                Session["id_user"] = user.Id_usuario;
                Session["user"] = user;
                Session["rol_user"] = (user.Rol.ToString());
                Response.Redirect("VerUsuariosAdmon.aspx");  //redireccionamos a pagina prinsipal de administrador 
            }
            if (user.Rol.Equals(2))
            {
                Session["id_user"] = user.Id_usuario;
                Session["user"] = user;
                Session["rol_user"] = user.Rol;
                Response.Redirect("~/vista/Perfil.aspx"); // redireccionamos a pagina prinsipal de paciente
            }
            if (user.Rol.Equals(3))
            {
                Session["id_user"] = user.Id_usuario;
                Session["user"] = user;
                Session["rol_user"] = user.Rol;
                Response.Redirect("modificadoc.aspx"); // redireccionamos a pagina prinsipal del doc
            }
            
        }*/
    }

    protected void B_Registro_Click(object sender, EventArgs e)
    {
        TB_Clave.Text = "";
        TB_username.Text = "";
        Response.Redirect("registro.aspx");
    }



    protected void IB_HomeLogin_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Inicio.aspx");
    }
}
