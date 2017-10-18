using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;
using utilitarios;
using DataPersis;

namespace Logica
{
    public class LDoctor
    {
        public String modificadoc(String save, String location,Boolean hashfile) 
        {
            String archivo = null;
            if (hashfile == true)
            {
                Udoctor datos = new Udoctor();
                datos.Foto = location;
                archivo = location;
            }
            return archivo;
        }
        public DataTable obtenerdoctores()
        {

            DAOdoctorcs dao = new DAOdoctorcs();
            return dao.obtenerDoctores();
            
        }
        public void modificardoctor(string Username, string Clave, string Nombre, string Apellido, string Edad, string Estudios, string Especialidad, string Imagen, int IdUsuario, string Estado, string Documento, string Correo)
        {
            Udoctor datos = new Udoctor();
            DAOdoctorcs doctores = new DAOdoctorcs();
            datos.Username = Username;
            datos.Clave = Clave;
            datos.Nombre = Nombre;
            datos.Apellido = Apellido;
            datos.Edad = Edad;
            datos.Especialidad = Especialidad;
            datos.Id_usuario = IdUsuario;
            datos.Estudios = Estudios;
            datos.Estado = "1";
            datos.Correo = Correo;
            datos.Documento = Int64.Parse(Documento);
            datos.Foto = Imagen;
            doctores.modificardoctor(datos);
            
        }
        public DataTable obtenerdoc(Int32 id) 
        {
            DAOdoctorcs dao = new DAOdoctorcs();
            Udoctor datos= new Udoctor();
            datos.Id_usuario=id;
            return dao.obtenerdoc(datos);
        }
        public Udoctor agregardoctor(String username, String clave, String nombre, String apellido, String edad, String estudios,String especialidad,String correo,String documento,String foto) 
        {
            DAOdoctorcs bases = new DAOdoctorcs();
            DataTable datos = new DataTable();
            Udoctor data = new Udoctor();
            if (username == " " || clave == " " || nombre == "" || apellido == "" || edad == "" || estudios == "" || especialidad == "" || correo == "" || documento == "" || foto == "")
            {
                data.Mensaje = "<script type='text/javascript'>alert('debe llenar los campos requeridos');window.location=\"RegistroDocAdmon.aspx\"</script>";
            }
            else
            {

                try
                {
                    data.Username = username;
                    datos = bases.verificarusuario(data);
                    if (datos.Rows.Count != 0)
                    {
                        data.Mensaje = "<script type='text/javascript'>alert('El nombre se usuario esta repetido por favor escribir otro');window.location=\"RegistroDocAdmon.aspx\"</script>";

                    }
                    else
                    {
                        data.Username = username;
                        data.Clave = clave;
                        data.Nombre = nombre;
                        data.Apellido = apellido;
                        data.Edad = edad;
                        data.Especialidad = especialidad;
                        data.Estudios = estudios;
                        data.Estado = "1";
                        data.Correo = correo;
                        data.Documento = int.Parse(documento);
                        data.Foto = foto;
                        bases.insertar_doctor(data);

                        data.Mensaje = "<script type='text/javascript'>alert('registro exitoso');window.location=\"RegistroDocAdmon.aspx\"</script>";

                    }
                }
                catch (FormatException ex)
                {
                    data.Mensaje = "<script type='text/javascript'>alert('ha ocirrido un error en un formato');window.location=\"RegistroDocAdmon.aspx\"</script>";

                }
            }
            return data;
        }
    }
}
