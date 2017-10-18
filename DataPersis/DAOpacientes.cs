using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;
using System.Xml.Linq;
using System.Data.Linq;
using System.Data;

namespace DataPersis
{
    public class DAOpacientes
    {
   
        public void guarda_paciente(UUsuario datos)
        /*carga los datos del paciente en la base de datos*/
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Usuario user = new Medicapp13Context.Usuario();
            user.Username = datos.Username;
            user.Clave = datos.Clave;
            user.Nombre = datos.Nombre;
            user.Apellido = datos.Apellido;
            user.Edad = datos.Edad;
            user.TipoDeSangre = datos.Tipo_de_sangre;
            user.Correo = datos.Correo;
            user.Documento = datos.Documento;
            user.FechaDeUltimoExamen = Convert.ToDateTime(datos.Fechaexamen);
            user.Imagen = datos.Foto;
            conect.Usuarios.InsertOnSubmit(user);
            conect.SubmitChanges();
            List<Medicapp13Context.Usuario> us = conect.Usuarios.Where(x => x.Username == datos.Username).ToList<Medicapp13Context.Usuario>();
            DataTable data = new DataTable();
            Udatatable datatable = new Udatatable();
            data = datatable.ToDataTable(us);
            Medicapp13Context.Sessione sesion = new Medicapp13Context.Sessione();
            sesion.Iduser = int.Parse(data.Rows[0]["IdUsuario"].ToString());
            conect.Sessiones.InsertOnSubmit(sesion);
            conect.SubmitChanges();

        }
        public DataTable verificarusuario(UUsuario encap)
            /* verifica que no exista el nombre de usuario en base de datos para que no s e presenten problemas de usernames duplicadod*/
        {
            Udatatable data= new Udatatable();
            DataTable verifica = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect= new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Usuario user= new Medicapp13Context.Usuario();
            List<Medicapp13Context.Usuario> usuario = conect.Usuarios.Where(x => x.Username == encap.Username).ToList<Medicapp13Context.Usuario>();
            verifica = data.ToDataTable(usuario);
            return verifica;
        }
        public DataTable modificarUsuariosid(UUsuario datos)
        {
            DataTable user = new DataTable();
            Udatatable data = new Udatatable();
            Medicapp13Context.Medicapp13DataContext conect =new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Usuario usuario = conect.Usuarios.Single(x => x.IdUsuario == datos.Id_usuario);
            usuario.Nombre = datos.Nombre;
            usuario.Apellido = datos.Apellido;
            usuario.Clave = datos.Clave;
            usuario.Edad = datos.Edad;
            conect.SubmitChanges();
            List<Medicapp13Context.Usuario> lista = conect.Usuarios.Where(x => x.IdUsuario == datos.Id_usuario).ToList<Medicapp13Context.Usuario>();
            user = data.ToDataTable(lista);
            return user;
        }
        public DataTable buscarUsuariosid(UUsuario datos)
        {
            Udatatable data = new Udatatable();
            DataTable user = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Usuario usuario = new Medicapp13Context.Usuario();
            List<Medicapp13Context.Usuario> userid = conect.Usuarios.Where(x => x.IdUsuario == datos.Id_usuario).ToList<Medicapp13Context.Usuario>();
            user = data.ToDataTable(userid);
            return user;
        }
        public DataTable allusuarios()
        {
            Udatatable data = new Udatatable();
            DataTable user = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Usuario usuarios = new Medicapp13Context.Usuario();
            List<Medicapp13Context.Usuario> users = conect.Usuarios.ToList<Medicapp13Context.Usuario>();
            user = data.ToDataTable(users);
            return user;
        }
    }
}
