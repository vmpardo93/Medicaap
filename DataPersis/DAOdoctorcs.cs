using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;

namespace DataPersis
{
    public class DAOdoctorcs
    {
        public DataTable mostrarDoctoresPrincipal()
        //metodo para mostrar doctores en la pagina principal esto es para el datalist
        {
            Udatatable data= new Udatatable();
            DataTable doctores= new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            List<Medicapp13Context.Usuario> doctor = conect.Usuarios.Where(x => x.IdRol==3 && x.Estado == 1).ToList<Medicapp13Context.Usuario>();
            doctores = data.ToDataTable(doctor);
            return doctores;
        }
        public DataTable obtenerdoc(Udoctor datos) 
        {
            Udatatable datatable = new Udatatable();
            DataTable data = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect =new Medicapp13Context.Medicapp13DataContext();
            List<Medicapp13Context.Usuario> user = conect.Usuarios.Where(x => x.IdUsuario == datos.Id_usuario).ToList<Medicapp13Context.Usuario>();
            data = datatable.ToDataTable(user);
            return data;
        }
        public DataTable obtenerDoctores()
        {
            Udatatable data = new Udatatable();
            DataTable doctores = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            List<Medicapp13Context.Usuario> doctor = conect.Usuarios.Where(x => x.IdRol == 3 && x.Estado == 1).ToList<Medicapp13Context.Usuario>();
            doctores = data.ToDataTable(doctor);
            return doctores;
        }
        public void modificardoctor(Udoctor datos)
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Usuario user = conect.Usuarios.Single(x => x.IdUsuario == datos.Id_usuario);
            user.Nombre = datos.Nombre;
            user.Imagen = datos.Foto;
            user.Apellido = datos.Apellido;
            user.Clave = datos.Clave;
            user.Username = datos.Username;
            user.Correo = datos.Correo;
            user.Estado = int.Parse(datos.Estado);
            user.Edad = datos.Edad;
            user.Estudios = datos.Estudios;
            user.Especialidad = datos.Especialidad;
            user.Documento =Convert.ToString(datos.Documento);
            conect.SubmitChanges();
            
        }
        public DataTable verificarusuario(Udoctor datos)
        {
            DataTable data = new DataTable();
            Udatatable datatable = new Udatatable();
            Medicapp13Context.Medicapp13DataContext conect= new Medicapp13Context.Medicapp13DataContext();
            List<Medicapp13Context.Usuario> doc = conect.Usuarios.Where(x => x.Username == datos.Username).ToList<Medicapp13Context.Usuario>();
            data = datatable.ToDataTable(doc);
            return data;
        }
        public void insertar_doctor(Udoctor data)
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Usuario user = new Medicapp13Context.Usuario();
            user.Username=data.Username;
            user.Clave=data.Clave;
            user.Nombre=data.Nombre;
            user.Apellido=data.Apellido;
            user.Edad=data.Edad;
            user.Especialidad=data.Especialidad;
            user.Estudios=data.Estudios;
            user.Estado=int.Parse(data.Estado);
            user.Correo=data.Correo;
            user.Documento=Convert.ToString(data.Documento);
            user.Imagen = data.Foto;
            conect.Usuarios.InsertOnSubmit(user);
            conect.SubmitChanges();

            List<Medicapp13Context.Usuario> us = conect.Usuarios.Where(x => x.Username == data.Username).ToList<Medicapp13Context.Usuario>();
            DataTable datat = new DataTable();
            Udatatable datatable = new Udatatable();
            datat = datatable.ToDataTable(us);
            Medicapp13Context.Sessione sesion = new Medicapp13Context.Sessione();
            sesion.Iduser = int.Parse(datat.Rows[0]["IdUsuario"].ToString());
            conect.Sessiones.InsertOnSubmit(sesion);
            conect.SubmitChanges();

        }
    }
}
