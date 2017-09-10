using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using NpgsqlTypes;
using System.Configuration;
using utilitarios;

namespace Data
{
    public class DAOdoctores
    {
        public DataTable mostrarDoctoresPrincipal()
        //metodo para mostrar doctores en la pagina principal esto es para el datalist
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
        public void insertar_doctor(Udoctor encapsula)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_registrar_doctor", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_username", NpgsqlDbType.Varchar, 50).Value = encapsula.Username;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar, 50).Value = encapsula.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar, 50).Value = encapsula.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Varchar, 50).Value = encapsula.Apellido;
                dataAdapter.SelectCommand.Parameters.Add("_edad", NpgsqlDbType.Integer).Value = encapsula.Edad;
                dataAdapter.SelectCommand.Parameters.Add("_estudios", NpgsqlDbType.Text).Value = encapsula.Estudios;
                dataAdapter.SelectCommand.Parameters.Add("_especialidad", NpgsqlDbType.Text).Value = encapsula.Especialidad;
                dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = encapsula.Estado;
                dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Varchar, 100).Value = encapsula.Correo;
                dataAdapter.SelectCommand.Parameters.Add("_documento", NpgsqlDbType.Varchar, 20).Value = encapsula.Documento;
                dataAdapter.SelectCommand.Parameters.Add("_url_perfil", NpgsqlDbType.Varchar, 50).Value = encapsula.Foto;
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
        public DataTable verificarusuario(Udoctor encap)
        {
            DataTable usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_verificarusuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("user_", NpgsqlDbType.Text).Value = encap.Username;
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
        public void modificardoctordoc(string username, string clave, string nombre, string apellido, string edad, string estudios, string especialidad, string imagen, int id_usuario, int id_user, string documento, string correo)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_editar_doctor", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_usuario", NpgsqlDbType.Integer).Value = id_usuario;
                dataAdapter.SelectCommand.Parameters.Add("username_", NpgsqlDbType.Text).Value = username;
                dataAdapter.SelectCommand.Parameters.Add("clave_", NpgsqlDbType.Text).Value = clave;
                dataAdapter.SelectCommand.Parameters.Add("nombre_", NpgsqlDbType.Text).Value = nombre;
                dataAdapter.SelectCommand.Parameters.Add("apellido_", NpgsqlDbType.Text).Value = apellido;
                dataAdapter.SelectCommand.Parameters.Add("edad_", NpgsqlDbType.Text).Value = edad;
                dataAdapter.SelectCommand.Parameters.Add("estudios_", NpgsqlDbType.Text).Value = estudios;
                dataAdapter.SelectCommand.Parameters.Add("especialidad_", NpgsqlDbType.Text).Value = especialidad;
                dataAdapter.SelectCommand.Parameters.Add("imagen_", NpgsqlDbType.Text).Value = imagen;
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
        public DataTable obtenerdoc(string id)
        {/*este metodo aplica para el doctor que desea ver sus datos*/
            DataTable archivos = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_buscadoc", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("idusuario_", NpgsqlDbType.Integer).Value = int.Parse(id);

                conection.Open();
                dataAdapter.Fill(archivos);
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
            return archivos;
        }
        public void modificardoctor(string username, string clave, string nombre, string apellido, string edad, string estudios, string especialidad, string imagen, int id_usuario, string estado, string documento, string correo)
        {/*este metodo aplica para el administrador ya que solo el modifica el estado del doctor*/
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexionhospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_editar_doctorv", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_usuario", NpgsqlDbType.Integer).Value = id_usuario;
                dataAdapter.SelectCommand.Parameters.Add("username_", NpgsqlDbType.Text).Value = username;
                dataAdapter.SelectCommand.Parameters.Add("clave_", NpgsqlDbType.Text).Value = clave;
                dataAdapter.SelectCommand.Parameters.Add("nombre_", NpgsqlDbType.Text).Value = nombre;
                dataAdapter.SelectCommand.Parameters.Add("apellido_", NpgsqlDbType.Text).Value = apellido;
                dataAdapter.SelectCommand.Parameters.Add("edad_", NpgsqlDbType.Text).Value = edad;
                dataAdapter.SelectCommand.Parameters.Add("estudios_", NpgsqlDbType.Text).Value = estudios;
                dataAdapter.SelectCommand.Parameters.Add("especialidad_", NpgsqlDbType.Text).Value = especialidad;
                dataAdapter.SelectCommand.Parameters.Add("url_", NpgsqlDbType.Text).Value = imagen;
                dataAdapter.SelectCommand.Parameters.Add("estado_", NpgsqlDbType.Integer).Value = int.Parse(estado);
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
        public DataTable obtenerDoctores()
        {/*este metodo aplica para la pagina de ver doctores del administrador*/
            DataTable archivos = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_doctor", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                conection.Open();
                dataAdapter.Fill(archivos);
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
            return archivos;
        }
    }

}
