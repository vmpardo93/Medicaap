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
    public class DAOhojavida
    {
        public void guardarhojavida(Uhojavida hoja)
        {/*este metodo guarda la hoja de vida del doctor cuando el la ingrese*/
            DataTable usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_hojavida", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("perfil_", NpgsqlDbType.Text).Value = hoja.Perfil;
                dataAdapter.SelectCommand.Parameters.Add("bachiller_", NpgsqlDbType.Text).Value = hoja.Bachiller;
                dataAdapter.SelectCommand.Parameters.Add("universidad_", NpgsqlDbType.Text).Value = hoja.Universidad;
                dataAdapter.SelectCommand.Parameters.Add("estudios_", NpgsqlDbType.Text).Value = hoja.Estudios;
                dataAdapter.SelectCommand.Parameters.Add("fellows_", NpgsqlDbType.Text).Value = hoja.Fellows;
                dataAdapter.SelectCommand.Parameters.Add("idiomas_", NpgsqlDbType.Text).Value = hoja.Idiomas;
                dataAdapter.SelectCommand.Parameters.Add("experiencia_", NpgsqlDbType.Text).Value = hoja.Experiencia;
                dataAdapter.SelectCommand.Parameters.Add("doctorid_", NpgsqlDbType.Integer).Value = int.Parse(hoja.Session);


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
       public void modificarhojavida(String perfil_profesional, String bachiller, String universidad, String otros_estudios, String fellows, String idiomas, String experiencia, Int32 id_doctor)
        {/*modifica la hoja de vida del doctor que esta en session el metodo recibe los datos que son enviados al modificar*/
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_editar_hojavida", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_doc", NpgsqlDbType.Integer).Value = id_doctor;
                dataAdapter.SelectCommand.Parameters.Add("perfil_", NpgsqlDbType.Text).Value = perfil_profesional;
                dataAdapter.SelectCommand.Parameters.Add("bachiller_", NpgsqlDbType.Text).Value = bachiller;
                dataAdapter.SelectCommand.Parameters.Add("universidad_", NpgsqlDbType.Text).Value =universidad;
                dataAdapter.SelectCommand.Parameters.Add("estudios_", NpgsqlDbType.Text).Value = otros_estudios;
                dataAdapter.SelectCommand.Parameters.Add("fellows_", NpgsqlDbType.Text).Value = fellows;
                dataAdapter.SelectCommand.Parameters.Add("idiomas_", NpgsqlDbType.Text).Value = idiomas;
                dataAdapter.SelectCommand.Parameters.Add("experiencia_", NpgsqlDbType.Text).Value = experiencia;


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
        public DataTable buscarhojavida(Int32 encap)
        {
            /*busca la hoja de vida del doctor que esta en session*/
            DataTable usuarios = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_hoja_vida", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_user", NpgsqlDbType.Integer).Value =encap;
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
