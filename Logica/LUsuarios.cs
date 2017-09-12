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
        public String ValidarSesionPaci(String rol)
        {
            /*valida la session del administrador*/
            String direccion = null;
            if (int.Parse(rol) != 2)
            {
                direccion = "Login.aspx";

            }
            return direccion;
        }
        public String ValidarSesionAdmin(String rol)
        {
            /*valida la session del administrador*/
            String direccion = null;
            if (int.Parse(rol) != 1)
            {
                direccion = "Login.aspx";

            }
            return direccion;
        }
        public String ValidarSesiondoc(String rol)
        {
            /*valida la session del doctor*/
            String direccion = null;
            if (int.Parse(rol) != 3)
            {
                direccion = "Login.aspx";
            }
            return direccion;
        }
    }
}