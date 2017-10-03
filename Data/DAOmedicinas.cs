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
   public class DAOmedicinas
    {
       public DataTable mostrarmedicinasAdmon()
       {
           DataTable medicinas = new DataTable();
           NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
           try
           {
               NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_ver_medicinas", conection);
               dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
               conection.Open();
               dataAdapter.Fill(medicinas);
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
           return medicinas;
       }
       public DataTable mostrarmedicinas()
       {
           DataTable medicinas = new DataTable();
           NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
           try
           {
               NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_medicinas", conection);
               dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
               conection.Open();
               dataAdapter.Fill(medicinas);
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
           return medicinas;
       }
        
       public void guardarmedicina(Umedicina datos)
       {
           DataTable usuario = new DataTable();
           NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

           try
           {
               NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_medicina", conection);
               dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
               dataAdapter.SelectCommand.Parameters.Add("medicina_", NpgsqlDbType.Text).Value = datos.Medicina;


               conection.Open();
               dataAdapter.Fill(usuario);
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
