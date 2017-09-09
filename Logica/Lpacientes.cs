using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            usuario.Url1 = "vista/RegistroDocAdmon.aspx";

            return usuario;
        }
        public DataTable obtenerUsuarioId(int id_user)
        {

            DAOpaciente dao = new DAOpaciente();
            return dao.buscarUsuariosid(id_user);

        }
        public DataTable modificarUsuario(int id_user, int id_usuario, string nombre, string apellido, string clave, string edad)
        {

            DAOpaciente dao = new DAOpaciente();
            return dao.modificarUsuariosid(id_user,id_usuario,nombre,apellido,clave,edad);

        }
        public DataTable buscarCitaD(DateTime fecha)
        {

            DAOcitas dao = new DAOcitas();
            return dao.buscarcitasD(fecha);

        }
        public void CancelarCitasSeparadas(int id_user)
        {

            DAOpaciente dao = new DAOpaciente();
            dao.cancelarCitaUsuario(id_user);

        }
        public DataTable mostrarCitasSeparadas(int id_user)
        {

            DAOpaciente dao = new DAOpaciente();
            return dao.mostrarcitasseparadas(id_user);

        }
        
        }

}