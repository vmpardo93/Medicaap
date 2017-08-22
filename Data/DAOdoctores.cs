using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using NpgsqlTypes;
using System.Configuration;
using utilitarios;

namespace Data
{
    public class DAOdoctores
    {
        public DataTable mostrarDoctoresPrincipal()
            //metodo para mostrar doctores en la pagina principal esto es para el datalist
        {

            DataTable doctores = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_buscar_doctores", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(doctores);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return doctores;
        }
        public void insertar_doctor(Udoctor encapsula)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_registrar_doctor", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_username", NpgsqlDbType.Varchar, 50).Value = encapsula.Username;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar, 50).Value = encapsula.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar, 50).Value = encapsula.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Varchar, 50).Value = encapsula.Apellido;
                dataAdapter.SelectCommand.Parameters.Add("_edad", NpgsqlDbType.Integer).Value = encapsula.Edad;
                dataAdapter.SelectCommand.Parameters.Add("_estudios", NpgsqlDbType.Text).Value = encapsula.Estudios;
                dataAdapter.SelectCommand.Parameters.Add("_especialidad", NpgsqlDbType.Text).Value = encapsula.Especialidad;
                dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = encapsula.Estado;
                dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Varchar, 100).Value = encapsula.Correo;
                dataAdapter.SelectCommand.Parameters.Add("_documento", NpgsqlDbType.Varchar, 20).Value = encapsula.Documento;
                dataAdapter.SelectCommand.Parameters.Add("_url_perfil", NpgsqlDbType.Varchar, 50).Value = encapsula.Url;
                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }

    }
}
