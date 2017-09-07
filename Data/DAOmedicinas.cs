﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class DAOmedicinas
    {
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
   
    }
}