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
    public class DAOcitas
    {
        public DataTable buscarcitaid(int id_user)
        {

            DataTable usuarios = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.buscarcita", conection);
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
        public DataTable buscarcitasD(DateTime fecha)
        {

            DataTable citas = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_buscar_cita_D", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("fecha", NpgsqlDbType.Date).Value = fecha;

                conection.Open();
                dataAdapter.Fill(citas);
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
            return citas;

        }
        public DataTable guardarcitaactual(string idcita, string doctor_id, string diagnostico, string alergia, string descripalergia, string cirugia, string descripcirugia, string fechacirugia, string medicina, string dosis, string fechainimedicina, string fechafinmedicina)
        /*guarda la cita mientras el doctor y el paciente estan en ella*/
        {
            DataTable hv_doc = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_citadoctor", conection);
                dataAdapter.SelectCommand.Parameters.Add("diagnostico_", NpgsqlDbType.Text).Value = diagnostico;
                dataAdapter.SelectCommand.Parameters.Add("doctoid_", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
                dataAdapter.SelectCommand.Parameters.Add("idcita_", NpgsqlDbType.Integer).Value = int.Parse(idcita);
                dataAdapter.SelectCommand.Parameters.Add("idalergia_", NpgsqlDbType.Integer).Value = int.Parse(alergia);
                dataAdapter.SelectCommand.Parameters.Add("descripalergia_", NpgsqlDbType.Text).Value = descripalergia;
                dataAdapter.SelectCommand.Parameters.Add("cirugia_", NpgsqlDbType.Text).Value = cirugia;
                dataAdapter.SelectCommand.Parameters.Add("descripcirugia_", NpgsqlDbType.Text).Value = descripcirugia;
                dataAdapter.SelectCommand.Parameters.Add("fechacirugia_", NpgsqlDbType.Text).Value = fechacirugia;
                dataAdapter.SelectCommand.Parameters.Add("id_medicina_", NpgsqlDbType.Integer).Value = int.Parse(medicina);
                dataAdapter.SelectCommand.Parameters.Add("dosis_", NpgsqlDbType.Integer).Value = int.Parse(dosis);
                dataAdapter.SelectCommand.Parameters.Add("fechafinmedicina_", NpgsqlDbType.Text).Value = fechafinmedicina;

                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
