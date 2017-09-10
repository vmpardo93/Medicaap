using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Configuration;


/// <summary>
/// Descripción breve de DAO_doctores
/// </summary>
public class DAO_doctores
{
    public DAO_doctores()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public void guardarArchivo(Edoctores archivos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("archivos.f_guardar_imgdoc", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nomre", NpgsqlDbType.Varchar, 50).Value = archivos.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_url", NpgsqlDbType.Text).Value = archivos.Url;

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

    public DataTable obtenerImagenes()
    {
        DataTable archivos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("archivos.f_obtener_imgdoc", conection);
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

    public DataTable buscarUsuariosid(int id_user)
    {

        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.buscarusuarioid", conection);
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
    public DataTable buscartipocita()
    {

        DataTable tipos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.buscartipocita", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(tipos);
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
        return tipos;

    }
    public DataTable modificarUsuariosid(int id_user, int id_usuario, string nombre, string apellido, string clave, string edad)
    {

        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.modificarusuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_usuario", NpgsqlDbType.Integer).Value = id_usuario;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = nombre;
            dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Varchar).Value = apellido;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar).Value = clave;
            dataAdapter.SelectCommand.Parameters.Add("_edad", NpgsqlDbType.Varchar).Value = edad;




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

    public DataTable buscarcitareporte(int id_user)
    {

        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.buscarcitareporte", conection);
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
    public DataTable ReporteMedicina(int id_user)
    {

        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.medicamentosreporte", conection);
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
    public DataTable alegiareporte(int id_user)
    {

        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.alergiasreporte", conection);
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
    public DataTable cirugiasreporte(int id_user)
    {

        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.cirugiasreporte", conection);
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

   





    public DataTable vertodosdoctores()
    {//esto es para ver todos los doctores
        DataTable doctores = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.mostrardoctoresrol", conection);
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
    public DataTable obtenerDoctoresprincipal()
    {/*este metodo aplica para la pagina principal*/
        DataTable archivos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_doctorprincipal", conection);
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






    public void guardarDoctor(string username, string clave, string edad, string especialidad, string estudios, string nombre, string apellido, string estado, string url, string correo, string documento)
    {/*guarda el doctor en la base de datosel doctor solo es registrado por el administrador por lo cual este es un metodo que solo lo usa el admin */
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_doctor", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("username_", NpgsqlDbType.Text).Value = username;
            dataAdapter.SelectCommand.Parameters.Add("clave_", NpgsqlDbType.Text).Value = clave;
            dataAdapter.SelectCommand.Parameters.Add("nombre_", NpgsqlDbType.Text).Value = nombre;
            dataAdapter.SelectCommand.Parameters.Add("apellido_", NpgsqlDbType.Text).Value = apellido;
            dataAdapter.SelectCommand.Parameters.Add("edad_", NpgsqlDbType.Text).Value = edad;
            dataAdapter.SelectCommand.Parameters.Add("estudios_", NpgsqlDbType.Text).Value = estudios;
            dataAdapter.SelectCommand.Parameters.Add("especialidad_", NpgsqlDbType.Text).Value = especialidad;
            dataAdapter.SelectCommand.Parameters.Add("idrol_", NpgsqlDbType.Integer).Value = 3;
            dataAdapter.SelectCommand.Parameters.Add("url_", NpgsqlDbType.Text).Value = url;
            dataAdapter.SelectCommand.Parameters.Add("estado_", NpgsqlDbType.Text).Value = estado;
            dataAdapter.SelectCommand.Parameters.Add("correo_", NpgsqlDbType.Text).Value = correo;
            dataAdapter.SelectCommand.Parameters.Add("documento_", NpgsqlDbType.Text).Value = documento;


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


    public DataTable buscarUsuarios(string nombreBD, string claveBD)
    {

        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.buscarusuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("nombreBD", NpgsqlDbType.Varchar, 50).Value = nombreBD;
            dataAdapter.SelectCommand.Parameters.Add("claveBD", NpgsqlDbType.Varchar, 50).Value = claveBD;
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


   



    public void sacarCita(int id_cita_, int id_usuario_)
    {

        DataTable citas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_sacar_cita", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_usuario_", NpgsqlDbType.Integer).Value = id_usuario_;
            dataAdapter.SelectCommand.Parameters.Add("id_cita_", NpgsqlDbType.Integer).Value = id_cita_;




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


    }




    public void guardarcirugias(string alergia)
    {/*este metodo guarda la hoja de vida del doctor cuando el la ingrese*/
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_cirugia", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("cirugia_", NpgsqlDbType.Text).Value = alergia;


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


    public DataTable mostrarHV(int id_doctor)
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_hv_doctor", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_usuario_", NpgsqlDbType.Integer).Value = id_doctor;
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
   
    public DataTable mostrarcitasiguientedoctor(string doctor_id, string fecha_)
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_cita", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_user", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
            dataAdapter.SelectCommand.Parameters.Add("fecha_", NpgsqlDbType.Integer).Value = Convert.ToDateTime(fecha_);
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


    /**************************************novedades angie*******************/


    public DataTable obtenercorreo(int id_usuario_)
    {
        DataTable correo = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_obtener_correo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_usuario_", NpgsqlDbType.Integer).Value = id_usuario_;

            conection.Open();
            dataAdapter.Fill(correo);
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
        return correo;

    }
    public DataTable obtenerfechas()
    {
        DataTable fechas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_obtener_fechas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(fechas);
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
        return fechas;

    }
    public void cancelarCitaUsuario(int id_cita)
    {
        DataTable citas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_cancelar_cita_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_cita_", NpgsqlDbType.Integer).Value = id_cita;
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

    }
    public DataTable mostrarcitasseparadas(int id_usuario_)
    {
        DataTable citas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_buscarcitas_usuarioV", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_usuario_", NpgsqlDbType.Integer).Value = id_usuario_;
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

   
}

   
   
   

