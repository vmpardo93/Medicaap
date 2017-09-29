using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;
using utilitarios;
using System.Collections;

namespace Logica
{
    public class Lpacientes
    {
        public UUsuario agregapacientes(String username, String clave, String nombre, String apellido, String edad, String tiposangre, String correo, String documento, String fechaexamen, String foto)
        {
            DAOpaciente paciente = new DAOpaciente();
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
        public Ucitas sacarcita(int id_cita,int id_usuario)
        {
            Ucitas citas = new Ucitas();
            DAOcitas dao = new DAOcitas();
            DataTable citadisponible = new DataTable();
            citadisponible = dao.verificarCita(id_cita, id_usuario);
        if (citadisponible.Rows.Count == 0){
            dao.sacarCita(id_cita, id_usuario);
            citas.Mensaje = "Cita apartada exitosamente";
            citas.Url = "NuevaCita.aspx";
        }
        else
        {
            
            citas.Mensaje="ya se tiene asignada una cita con esa fecha y hora";
            citas.Url="NuevaCita.aspx";
            
            
        }
        return citas;
        
            

        }
        public DataTable buscarcitaid(int id_user)
        {

            DAOcitas dao = new DAOcitas();
            return dao.buscarcitaid(id_user);

        }
        public DataTable buscarcitareporte(int id_user)
        {

            DAOpaciente dao = new DAOpaciente();
            return dao.buscarcitareporte(id_user);

        }
        public DataTable buscaralergiareporte(int id_user)
        {

            DAOpaciente dao = new DAOpaciente();
            return dao.alegiareporte(id_user);

        }

        public DataTable buscarmedicinareporte(int id_user)
        {

            DAOpaciente dao = new DAOpaciente();
            return dao.ReporteMedicina(id_user);

        }
        public DataTable buscarcirugiareporte(int id_user)
        {

            DAOpaciente dao = new DAOpaciente();
            return dao.cirugiasreporte(id_user);

        }

        public DataTable mostrarhv(int id_user)
        {

            DAOpaciente dao = new DAOpaciente();
            return dao.mostrarHV(id_user);

        }
        public string verificarReportes(int rows)
        {
            string redirec;
            if (rows == 0)
            {
                redirec = "Nohay.aspx";
            }
            else
            {
                redirec = null;
            }
            return redirec;

        }
        public DataSet enviarAlergiasR(DataTable resultado)
        {
            utilitarios.Reportes.Reportes datos = new utilitarios.Reportes.Reportes();
            DataTable data = new DataTable(); //dt
            data = datos.alergia;
            DataRow fila;
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                fila = data.NewRow();

                fila["nombre"] = resultado.Rows[i]["nombre"].ToString();
                fila["apellido"] = resultado.Rows[i]["apellido"].ToString();
                fila["documento"] = resultado.Rows[i]["documento"].ToString();
                fila["edad"] = resultado.Rows[i]["edad"].ToString();
                fila["tipo_sangre"] = resultado.Rows[i]["tipo_de_sangre"].ToString();
                fila["fecha_ult_examen"] = resultado.Rows[i]["fecha_de_ultimo_examen"].ToString();
                fila["descripcion_alergia"] = resultado.Rows[i]["descripcion"].ToString();
                fila["nombre_alergia"] = resultado.Rows[i]["nombre_alergia"].ToString();
                data.Rows.Add(fila);
            }
            return datos;


        }

        public DataSet enviarCitasR(DataTable resultado)
        {
            utilitarios.Reportes.Reportes datos = new utilitarios.Reportes.Reportes();
            DataTable data = new DataTable(); //dt
            data = datos.citas;
            DataRow fila;
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                fila = data.NewRow();

                fila["nombre"] = resultado.Rows[i]["nombre"].ToString();
                fila["apellido"] = resultado.Rows[i]["apellido"].ToString();
                fila["documento"] = resultado.Rows[i]["documento"].ToString();
                fila["edad"] = resultado.Rows[i]["edad"].ToString();
                fila["tipo_sangre"] = resultado.Rows[i]["tipo_de_sangre"].ToString();
                fila["fecha_ult_examen"] = resultado.Rows[i]["fecha_de_ultimo_examen"].ToString();
                fila["hora_ini_cita"] = resultado.Rows[i]["hora_inicio"].ToString();
                fila["hora_fin_cita"] = resultado.Rows[i]["hora_fin"].ToString();
                fila["tipo"] = resultado.Rows[i]["tipo"].ToString();
                fila["diagnostico"] = resultado.Rows[i]["diagnostico"].ToString();
                fila["nombredoc"] = resultado.Rows[i]["nombredoc"].ToString();
                fila["apellidodoc"] = resultado.Rows[i]["apellidodoc"].ToString();
                data.Rows.Add(fila);
            }
            return datos;


        }
        public DataSet enviarMedicinasR(DataTable resultado)
        {
            utilitarios.Reportes.Reportes datos = new utilitarios.Reportes.Reportes();
            DataTable data = new DataTable(); //dt
            data = datos.medicina;
            DataRow fila;
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                fila = data.NewRow();

                fila["nombre"] = resultado.Rows[i]["nombre"].ToString();
                fila["apellido"] = resultado.Rows[i]["apellido"].ToString();
                fila["documento"] = resultado.Rows[i]["documento"].ToString();
                fila["edad"] = resultado.Rows[i]["edad"].ToString();
                fila["tipo_sangre"] = resultado.Rows[i]["tipo_de_sangre"].ToString();
                fila["fecha_ult_examen"] = resultado.Rows[i]["fecha_de_ultimo_examen"].ToString();
                fila["dosis"] = resultado.Rows[i]["dosis"].ToString();
                fila["fecha_inicio"] = resultado.Rows[i]["fecha_ini"].ToString();
                fila["fecha_fin"] = resultado.Rows[i]["fecha_fin"].ToString();
                fila["nombre_medicina"] = resultado.Rows[i]["nombre_medicamento"].ToString();
                data.Rows.Add(fila);
            }
            return datos;


        }
        public DataSet enviarCirugiasR(DataTable resultado)
        {
            utilitarios.Reportes.Reportes datos = new utilitarios.Reportes.Reportes();
            DataTable data = new DataTable(); //dt
            data = datos.cirugias;
            DataRow fila;
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                fila = data.NewRow();

                fila["nombre"] = resultado.Rows[i]["nombre"].ToString();
                fila["apellido"] = resultado.Rows[i]["apellido"].ToString();
                fila["documento"] = resultado.Rows[i]["documento"].ToString();
                fila["edad"] = resultado.Rows[i]["edad"].ToString();
                fila["tipo_sangre"] = resultado.Rows[i]["tipo_de_sangre"].ToString();
                fila["fecha_ult_examen"] = resultado.Rows[i]["fecha_de_ultimo_examen"].ToString();
                fila["nombre_cirugia"] = resultado.Rows[i]["nombre_cirugia"].ToString();
                fila["descripcion"] = resultado.Rows[i]["descripcion"].ToString();
                fila["fecha_cirugia"] = resultado.Rows[i]["fecha_cirugia"].ToString();

            }
            return datos;


        }
        public DataSet enviarHv(DataTable resultado)
        {
            utilitarios.Reportes.Reportes datos = new utilitarios.Reportes.Reportes();
            DataTable data = new DataTable(); //dt
            data = datos.doctor;
            DataRow fila;
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                fila = data.NewRow();

                fila["nombre"] = resultado.Rows[i]["nombre"].ToString();
                fila["apellido"] = resultado.Rows[i]["apellido"].ToString();
                fila["edad"] = resultado.Rows[i]["edad"].ToString();
                fila["estudios"] = resultado.Rows[i]["estudios"].ToString();
                fila["especialidad"] = resultado.Rows[i]["especialidad"].ToString();
                fila["imagen"] = resultado.Rows[i]["imagen"].ToString();
                fila["experiencia"] = resultado.Rows[i]["experiencia"].ToString();
                fila["fellows"] = resultado.Rows[i]["fellows"].ToString();
                fila["idiomas"] = resultado.Rows[i]["idiomas"].ToString();
                fila["otros_estudios"] = resultado.Rows[i]["otros_estudios"].ToString();
                fila["perfil_profesional"] = resultado.Rows[i]["perfil_profesional"].ToString();
                fila["universidad"] = resultado.Rows[i]["universidad"].ToString();

            }
            return datos;


        }
        
        }

}