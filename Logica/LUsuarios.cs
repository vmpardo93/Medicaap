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
            DAO_usuarios users = new DAO_usuarios();
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
                // data.Username = datos.Rows[0]["user"].ToString();

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
                datos.Mensaje = user;
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
                datos.Mensaje = user;
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
                datos.Mensaje = user;
            }
            return datos;
        }
    }
}