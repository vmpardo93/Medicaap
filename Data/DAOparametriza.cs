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
    public class DAOparametriza
    {
        public DataTable mostrarparametrizacion()
        {
            DataTable parametri = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(" hospital.f_muestra_parametrizacion", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                conection.Open();
                dataAdapter.Fill(parametri);
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
            return parametri;
        }
        public DataTable editarparametrizacion(Uparametrizacion datos)
        {
            DataTable parametri = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(" hospital.f_edita_tiempo", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_duracion_citas", NpgsqlDbType.Text).Value =datos.Duracion;
                dataAdapter.SelectCommand.Parameters.Add("_hora_inicio", NpgsqlDbType.Text).Value =datos.Inicio;
                dataAdapter.SelectCommand.Parameters.Add("_hora_fin", NpgsqlDbType.Text).Value = datos.Fin;
                conection.Open();
                dataAdapter.Fill(parametri);
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
            return parametri;

        }
    }
}
