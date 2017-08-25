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
    public class LDoctor
    {
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
                data.Mensaje = "debe llenar todos lo campos";
                data.Url = "~/vista/RegistroDocAdmon.aspx";
            }
            else
            {

                try
                {
                    data.Username = username;
                    datos = bases.verificarusuario(data);
                    if (datos.Rows.Count != 0)
                    {
                        data.Mensaje = "El nombre se usuario esta repetido por favor escribir otro";
                        data.Url = "~/vista/RegistroDocAdmon.aspx";
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

                        data.Mensaje = "registro exitoso";
                        data.Url = "~/vista/RegistroDocAdmon.aspx";

                    }
                }
                catch (FormatException ex)
                {
                    data.Mensaje="l_Mensaje3";
                    data.Url = "~/vista/RegistroDocAdmon.aspx";
                }
            }
            return data;
        }
    }
}
