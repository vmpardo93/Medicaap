using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;
using Data;
using System.Data;

namespace Logica
{
    public class LUsuarios
    {
        public UUsuario loggin(String user, String pass)
        {
            DAOusuarios users = new DAOusuarios();
            UUsuario data = new UUsuario();
            IpMac dirrec = new IpMac();

            data.Username = user;
            data.Clave = pass;
            data.Ip = dirrec.GetIP();
            data.Mac = dirrec.GetMACAddress2();
            DataTable datos = users.login(data);

            if (datos.Rows.Count > 0)
            {

                data.Idrol = int.Parse(datos.Rows[0]["Id_Rol"].ToString());
                data.Id_usuario = int.Parse(datos.Rows[0]["Id_Usuario"].ToString());
                data.Nombre = (datos.Rows[0]["nombre"].ToString());
                data.Apellido = (datos.Rows[0]["apellido"].ToString());
                data.Username = (datos.Rows[0]["username"].ToString());
                data.Idrol = int.Parse(datos.Rows[0]["id_rol"].ToString());
                data.Tipo_de_sangre = (datos.Rows[0]["tipo_de_sangre"].ToString());
                data.Edad = (datos.Rows[0]["edad"].ToString());
                //data.Especialidad = (datos.Rows[0]["especialidad"].ToString());
                //data.Fecha_ultimo_examen = (datos.Rows[0]["fecha_de_ultimo_examen"].ToString());
                data.DireccionImagen = (datos.Rows[0]["imagen"].ToString());
                

                if (int.Parse(datos.Rows[0]["Id_Rol"].ToString()) == 1)
                {
                    
                    data.Mensaje ="<script type='text/javascript'>window.location=\"VerUsuariosAdmon.aspx\"</script>";
                }
                else if (data.Idrol == 2)
                {

                    data.Mensaje ="<script type='text/javascript'>window.location=\"Perfil.aspx\"</script>";


                }
                else if (data.Idrol == 3)
                {
                    data.Mensaje ="<script type='text/javascript'>window.location=\"modificadoc.aspx\"</script>";
                }
            }
            else
            {
                data.Mensaje = "<script type='text/javascript'>alert('Usuario o Contraseña incorrecta');window.location=\"Login.aspx\"</script>";
            }
            return data;
        }
        public UUsuario ValidarSesionPaci(String rol, String user)
        {
            /*valida la session del paciente*/
            UUsuario datos = new UUsuario();
            if (int.Parse(rol) != 1)
            {
                datos.Mensaje = "<script type='text/javascript'>window.location=\"Login.aspx\"</script>";
            }
            else
            {
                datos.Mensaje =null;
            }
            return datos;
        }
        public UUsuario ValidarSesionAdmin(String rol,String user)
        {
            /*valida la session del administrador*/
            UUsuario datos = new UUsuario();
            if (int.Parse(rol) != 1)
            {
                datos.Mensaje = "<script type='text/javascript'>window.location=\"Login.aspx\"</script>";
            }
            else 
            {
                datos.Mensaje = null;

            }
            return datos;
        }

        public Udoctor ValidarSesiondoc(String rol,String user)
        {
            /*valida la session del doctor*/
            Udoctor datos = new Udoctor();
            if (int.Parse(rol) != 3)
            {
                datos.Mensaje = "<script type='text/javascript'>window.location=\"Login.aspx\"</script>";

            }
            else
            {
                datos.Mensaje = null;
            }
            return datos;
        }
        
    }
}