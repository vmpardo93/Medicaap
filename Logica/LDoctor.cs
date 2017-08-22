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

            data.Username=username;
            data.Clave= clave;
            data.Nombre= nombre;
            data.Apellido= apellido;
            data.Edad=edad;
            data.Estado=estudios;
            data.Especialidad= especialidad;
            data.Correo= correo;
            data.Documento=int.Parse(documento);
            data.Foto = foto;
            bases.insertar_doctor(data);

            data.Mensaje = "registro exitoso";
            data.Url = "vista/RegistroDocAdmon.aspx";

            return data;
        }
    }
}
