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

                    data.Url1 = "VerUsuariosAdmon.aspx";
                }
                else if (data.Idrol == 2)
                {

                    data.Url1 = "Perfil.aspx";

                }
                else if (data.Idrol == 3)
                {
                    data.Url1 = "modificadoc.aspx";
                }
            }
            else
            {
                data.Mensaje = "Usuario o Contraseña incorrecta";
                data.Url1 = "Loggin.aspx";
            }
            return data;
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