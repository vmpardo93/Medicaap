using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using NpgsqlTypes;
using System.Configuration;

namespace Data
{
    public class DAOdoctores
    {
        public DataTable mostrarDoctoresPrincipal()//metodo para mostrar doctores en la pagina principal esto es para el datalist
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

    }
}
