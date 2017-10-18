using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;
using utilitarios;
using System.Collections;
using DataPersis;

namespace Logica
{
    public class Lpacientes
    {
        public UUsuario agregapacientes(String username, String clave, String nombre, String apellido, String edad, String tiposangre, String correo, String documento, String fechaexamen, String foto)
        {
            DAOpacientes paciente = new DAOpacientes();
            DataTable datos = new DataTable();
            UUsuario usuario = new UUsuario();
            try
            {
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

                usuario.Mensaje = "<script type='text/javascript'>alert('registro exitoso');window.location=\"Login.aspx\"</script>";
            }
            catch (FormatException ex) 
            {
                usuario.Mensaje = "<script type='text/javascript'>alert('ha ocirrido un error en un formato');window.location=\"registro.aspx\"</script>";

            }
            return usuario;
        }
        public DataTable obtenerUsuarioId(int id_user)
        {
            UUsuario datos = new UUsuario();
            DAOpacientes dao = new DAOpacientes();
            datos.Id_usuario = id_user;
            DataTable dato = new DataTable();
            dato = dao.buscarUsuariosid(datos);
            return dato;

        }
        public UUsuario modificarUsuario(int id_user, int IdUsuario, string Nombre, string Apellido, string Clave, string Edad)
        {
            UUsuario datos = new UUsuario();
            datos.Id_usuario = IdUsuario;
            datos.Nombre = Nombre;
            datos.Apellido = Apellido;
            datos.Edad = Edad;
            datos.Clave = Clave;
            DAOpacientes dao = new DAOpacientes();
            dao.modificarUsuariosid(datos); 
            return datos;
        }
        }

}