using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;
using utilitarios;
using System.Web.UI.WebControls;

namespace Logica
{
    public class LDoctor
    {
        public String modificadoc(String save, String location,Boolean hashfile,Label text) 
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
        public DataTable obtenerdoctores (){

            DAOdoctores dao = new DAOdoctores();
            return dao.mostrarDoctoresPrincipal();
            
        }
        public Udoctor agregardoctor(String username, String clave, String nombre, String apellido, String edad, String estudios,String especialidad,String correo,String documento,String foto) 
        {
            DAOdoctores bases = new DAOdoctores();
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
                        data.Estado = estudios;
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
