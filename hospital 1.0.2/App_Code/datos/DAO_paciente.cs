using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Npgsql;
using NpgsqlTypes;
using System.Configuration;

/// <summary>
/// Descripción breve de DAO_paciente
/// </summary>
public class DAO_paciente
{
	public DAO_paciente()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    public void guardarpaciente(string imagen, string user, string clave, string nombre, string apellido, string edad, string tiposangre, string examen, string documento, string correo)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_paciente", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("username_", NpgsqlDbType.Text).Value = user;
            dataAdapter.SelectCommand.Parameters.Add("clave_", NpgsqlDbType.Text).Value = clave;
            dataAdapter.SelectCommand.Parameters.Add("nombre_", NpgsqlDbType.Text).Value = nombre;
            dataAdapter.SelectCommand.Parameters.Add("apellido_", NpgsqlDbType.Text).Value = apellido;
            dataAdapter.SelectCommand.Parameters.Add("edad_", NpgsqlDbType.Text).Value = edad;
            dataAdapter.SelectCommand.Parameters.Add("tiposangre_", NpgsqlDbType.Text).Value = tiposangre;
            dataAdapter.SelectCommand.Parameters.Add("idrol_", NpgsqlDbType.Integer).Value = 2;
            dataAdapter.SelectCommand.Parameters.Add("url_", NpgsqlDbType.Text).Value = imagen;
            dataAdapter.SelectCommand.Parameters.Add("examen_", NpgsqlDbType.Date).Value =examen;
            dataAdapter.SelectCommand.Parameters.Add("documento_", NpgsqlDbType.Text).Value = documento;
            dataAdapter.SelectCommand.Parameters.Add("correo_", NpgsqlDbType.Text).Value = correo;
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
    public DataTable verificarusuario(string username)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_verificarusuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("user_", NpgsqlDbType.Text).Value = username;
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