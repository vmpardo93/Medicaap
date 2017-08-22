using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using NpgsqlTypes;
using Npgsql;
using utilitarios;


namespace Data
{
   public class DAOpaciente
    {
        public void guarda_paciente(UUsuario encap)
            /*carga los datos del paciente en la base de datos*/
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_registrar_paciente", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_username", NpgsqlDbType.Varchar, 50).Value = encap.Username;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar, 50).Value = encap.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar, 50).Value = encap.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Varchar, 50).Value = encap.Apellido;
                dataAdapter.SelectCommand.Parameters.Add("_edad", NpgsqlDbType.Integer).Value = encap.Edad;
                dataAdapter.SelectCommand.Parameters.Add("_tiposangre", NpgsqlDbType.Text).Value = encap.Tiposangre;
                dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = encap.Correo;
                dataAdapter.SelectCommand.Parameters.Add("_documento", NpgsqlDbType.Text).Value = encap.Documento;
                dataAdapter.SelectCommand.Parameters.Add("_fechaexamen", NpgsqlDbType.Varchar, 100).Value = encap.Fechaexamen;
                dataAdapter.SelectCommand.Parameters.Add("_imagen", NpgsqlDbType.Text).Value = encap.Foto;
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
        public DataTable verificarusuario(UUsuario encap)
        {
            DataTable usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_verificarusuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("user_", NpgsqlDbType.Text).Value =encap.Username;
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
            return usuario;
        }
    }
}
