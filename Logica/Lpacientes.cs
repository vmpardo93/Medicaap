using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;
using System.Data;
using utilitarios;

namespace Logica
{
    public class Lpacientes
    {
        public UUsuario agregapacientes(String username, String clave, String nombre, String apellido, String edad, String tiposangre, String correo, String documento, String fechaexamen, String foto)
        {
            DAOpaciente paciente = new DAOpaciente();
            DataTable datos = new DataTable();
            UUsuario usuario = new UUsuario();

            usuario.Username = username;
            usuario.Clave = clave;
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Edad = edad;
            usuario.Tiposangre = tiposangre;
            usuario.Correo = correo;
            usuario.Documento = documento;
            usuario.Fechaexamen = fechaexamen;
            usuario.Foto = foto;

            paciente.guarda_paciente(usuario);
            
            usuario.Mensaje = "Registro exitoso";

            usuario.Url1 = "RegistroDocAdmon.aspx";

            return usuario;
        }
        }
}