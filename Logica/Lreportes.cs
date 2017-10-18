using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using utilitarios;
using System.Data;

namespace Logica
{
    public class Lreportes
    {
        public DataTable buscarcitareporte(int id_user)
        {

            DAOreportes dao = new DAOreportes();
            return dao.buscarcitareporte(id_user);

        }
        public DataTable buscaralergiareporte(int id_user)
        {

            DAOreportes dao = new DAOreportes();
            return dao.alegiareporte(id_user);

        }

        public DataTable buscarmedicinareporte(int id_user)
        {

            DAOreportes dao = new DAOreportes();
            return dao.ReporteMedicina(id_user);

        }
        public DataTable buscarcirugiareporte(int id_user)
        {

            DAOreportes dao = new DAOreportes();
            return dao.cirugiasreporte(id_user);

        }

        public DataTable mostrarhv(int id_user)
        {

            DAOreportes dao = new DAOreportes();
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
