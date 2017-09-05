using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DAOhorario
    {
        public DataTable mostrarhorario(string doctor_id)
        {
            DataTable hv_doc = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_horario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_usuario", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
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
        public DataTable editarhorario(string doctor_id, string hora_inicio, string hora_fin, string dia, string id_usuario)
        {
            DataTable hv_doc = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_modificar_horario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_inicio", NpgsqlDbType.Timestamp).Value = Convert.ToDateTime(hora_inicio);
                dataAdapter.SelectCommand.Parameters.Add("_fin", NpgsqlDbType.Timestamp).Value = Convert.ToDateTime(hora_fin);
                dataAdapter.SelectCommand.Parameters.Add("_dia", NpgsqlDbType.Text).Value = dia;
                dataAdapter.SelectCommand.Parameters.Add("id_usuario", NpgsqlDbType.Integer).Value = int.Parse(id_usuario);
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
