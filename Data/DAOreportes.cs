using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;

namespace Data
{
    public class DAOreportes
    {
        public DataTable buscarcitareporte(int id_user)
        {

            DataTable usuarios = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.buscarcitareporte", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_user", NpgsqlDbType.Integer).Value = id_user;

                conection.Open();
                dataAdapter.Fill(usuarios);
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
            return usuarios;

        }
        public DataTable ReporteMedicina(int id_user)
        {

            DataTable usuarios = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.medicamentosreporte", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_user", NpgsqlDbType.Integer).Value = id_user;

                conection.Open();
                dataAdapter.Fill(usuarios);
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
            return usuarios;

        }
        public DataTable alegiareporte(int id_user)
        {

            DataTable usuarios = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.alergiasreporte", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_user", NpgsqlDbType.Integer).Value = id_user;

                conection.Open();
                dataAdapter.Fill(usuarios);
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
            return usuarios;

        }
        public DataTable cirugiasreporte(int id_user)
        {

            DataTable usuarios = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.cirugiasreporte", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_user", NpgsqlDbType.Integer).Value = id_user;

                conection.Open();
                dataAdapter.Fill(usuarios);
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
            return usuarios;

        }
        public DataTable mostrarHV(int id_doctor)
        {
            DataTable hv_doc = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_hv_doctor", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_usuario_", NpgsqlDbType.Integer).Value = id_doctor;
                conection.Open();
                dataAdapter.Fill(hv_doc);
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
            return hv_doc;
        }
/**realmete no supe porque no se pudo mapear estas dos funciones pareciera que fue por las vistas sin embargo no estoy segora que eso sea asi**/
        public DataTable Loggin(UUsuario datos)
        {
            DataTable hv_doc = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_loggin", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("user_", NpgsqlDbType.Text).Value = datos.Username;
                dataAdapter.SelectCommand.Parameters.Add("clave_", NpgsqlDbType.Text).Value = datos.Clave;
                dataAdapter.SelectCommand.Parameters.Add("ip_", NpgsqlDbType.Text).Value = datos.Ip;
                dataAdapter.SelectCommand.Parameters.Add("mac_", NpgsqlDbType.Text).Value = datos.Mac;
;
                conection.Open();
                dataAdapter.Fill(hv_doc);
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
            return hv_doc;
        }
    }
}
