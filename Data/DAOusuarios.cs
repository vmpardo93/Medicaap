using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;
using Npgsql;
using NpgsqlTypes;
using System.Configuration;


namespace Data
{
   public class DAO_usuarios
    {
        public DataTable login(UUsuario daoUser)
        {
            DataTable usuarios = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.buscarusuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("user_", NpgsqlDbType.Varchar, 50).Value = daoUser.Username;
                dataAdapter.SelectCommand.Parameters.Add("clave_", NpgsqlDbType.Varchar, 50).Value = daoUser.Clave;
                dataAdapter.SelectCommand.Parameters.Add("ip_", NpgsqlDbType.Varchar, 50).Value = daoUser.Ip;
                dataAdapter.SelectCommand.Parameters.Add("mac_", NpgsqlDbType.Varchar, 50).Value = daoUser.Mac;
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

    }
}
