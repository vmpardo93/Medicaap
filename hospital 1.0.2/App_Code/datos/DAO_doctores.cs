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
    public DataTable buscarcitaid(int id_user)
    {

        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.buscarcita", conection);
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
    public DataTable buscarhojavida(string id_doctor)
    {
        /*busca la hoja de vida del doctor que esta en session*/
        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_hoja_vida", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_user", NpgsqlDbType.Integer).Value = int.Parse(id_doctor);
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
    public void guardarhojavida(string bachiller, string estudios, string fellows, string idiomas, string perfil, string universidad, string experiencia, string id_user)
    {/*este metodo guarda la hoja de vida del doctor cuando el la ingrese*/
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_hojavida", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("perfil_", NpgsqlDbType.Text).Value = perfil;
            dataAdapter.SelectCommand.Parameters.Add("bachiller_", NpgsqlDbType.Text).Value = bachiller;
            dataAdapter.SelectCommand.Parameters.Add("universidad_", NpgsqlDbType.Text).Value = universidad;
            dataAdapter.SelectCommand.Parameters.Add("estudios_", NpgsqlDbType.Text).Value = estudios;
            dataAdapter.SelectCommand.Parameters.Add("fellows_", NpgsqlDbType.Text).Value = fellows;
            dataAdapter.SelectCommand.Parameters.Add("idiomas_", NpgsqlDbType.Text).Value = idiomas;
            dataAdapter.SelectCommand.Parameters.Add("experiencia_", NpgsqlDbType.Text).Value = experiencia;
            dataAdapter.SelectCommand.Parameters.Add("doctorid_", NpgsqlDbType.Integer).Value = int.Parse(id_user);


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
    public void guardarDoctor(string username, string clave, string edad, string especialidad, string estudios, string nombre, string apellido, string estado, string url)
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
    public DataTable vertodosdoctores(){//esto es para ver todos los doctores
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




    public void guardarhorariodoc(string fechainicio, string fechafin, string horario, string idusuario)
    {
        DataTable usuario = new DataTable();

        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_generar_horario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_inicio", NpgsqlDbType.Date).Value = Convert.ToDateTime(fechainicio);
            dataAdapter.SelectCommand.Parameters.Add("_fin", NpgsqlDbType.Date).Value = Convert.ToDateTime(fechafin);
            dataAdapter.SelectCommand.Parameters.Add("_horario", NpgsqlDbType.Text).Value = horario;
            dataAdapter.SelectCommand.Parameters.Add("iduser_", NpgsqlDbType.Integer).Value = int.Parse(idusuario);
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
    public void modificarhojavida(string perfil_profesional, string bachiller, string universidad, string otros_estudios, string fellows, string idiomas, string experiencia, int id_doctor)
    {/*modifica la hoja de vida del doctor que esta en session el metodo recibe los datos que son enviados al modificar*/
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        if (otros_estudios == null)
        {
            otros_estudios = "No tiene otros estudios";
        }
        if (fellows == null)
        {
            fellows = "No tiene fellows";
        }
        if (experiencia == null)
        {
            experiencia = "No tiene experiencia en otros hospitales";
        }
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_editar_hojavida", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_doc", NpgsqlDbType.Integer).Value = id_doctor;
            dataAdapter.SelectCommand.Parameters.Add("perfil_", NpgsqlDbType.Text).Value = perfil_profesional;
            dataAdapter.SelectCommand.Parameters.Add("bachiller_", NpgsqlDbType.Text).Value = bachiller;
            dataAdapter.SelectCommand.Parameters.Add("universidad_", NpgsqlDbType.Text).Value = universidad;
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
    public DataTable buscarcitasD(DateTime fecha)
    {

        DataTable citas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_buscar_cita_D", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("fecha", NpgsqlDbType.Date).Value = fecha;




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
    public void sacarCita(int id_cita_,int id_usuario_)
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
    

    public void guardarmedicina(string alergia){/*este metodo guarda la hoja de vida del doctor cuando el la ingrese*/
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_medicina", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("medicina_", NpgsqlDbType.Text).Value = alergia;


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
    public void guardaralergia(string alergia){/*este metodo guarda la hoja de vida del doctor cuando el la ingrese*/
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_alergia", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("alergia_", NpgsqlDbType.Text).Value = alergia;


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
    public DataTable allusuarios()
    {
        DataTable pacientes = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_todos_pacientes", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(pacientes);
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
        return pacientes;
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
    public DataTable mostraralergias()
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_alergias", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    public DataTable guardarcitaactual(string idcita, string doctor_id, string diagnostico, string alergia, string descripalergia, string cirugia, string descripcirugia, string fechacirugia, string medicina, string dosis, string fechainimedicina, string fechafinmedicina)
    /*guarda la cita mientras el doctor y el paciente estan en ella*/
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_citadoctor", conection);
            dataAdapter.SelectCommand.Parameters.Add("diagnostico_", NpgsqlDbType.Text).Value = diagnostico;
            dataAdapter.SelectCommand.Parameters.Add("doctoid_", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
            dataAdapter.SelectCommand.Parameters.Add("idcita_", NpgsqlDbType.Integer).Value = int.Parse(idcita);
            dataAdapter.SelectCommand.Parameters.Add("idalergia_", NpgsqlDbType.Integer).Value = int.Parse(alergia);
            dataAdapter.SelectCommand.Parameters.Add("descripalergia_", NpgsqlDbType.Text).Value = descripalergia;
            dataAdapter.SelectCommand.Parameters.Add("cirugia_", NpgsqlDbType.Text).Value = cirugia;
            dataAdapter.SelectCommand.Parameters.Add("descripcirugia_", NpgsqlDbType.Text).Value = descripcirugia;
            dataAdapter.SelectCommand.Parameters.Add("fechacirugia_", NpgsqlDbType.Text).Value =fechacirugia;
            dataAdapter.SelectCommand.Parameters.Add("id_medicina_", NpgsqlDbType.Integer).Value = int.Parse(medicina);
            dataAdapter.SelectCommand.Parameters.Add("dosis_", NpgsqlDbType.Integer).Value = int.Parse(dosis);
            dataAdapter.SelectCommand.Parameters.Add("fechafinmedicina_", NpgsqlDbType.Text).Value =fechafinmedicina;

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    public DataTable mostrarmedicinas()
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_medicinas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    public DataTable mostrarhorario(string doctor_id)
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_horario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_usuario", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
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
    public DataTable editarhorario(string doctor_id, string hora_inicio, string hora_fin, string dia, string id_usuario)
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_modificar_horario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_inicio", NpgsqlDbType.Timestamp).Value = Convert.ToDateTime(hora_inicio);
            dataAdapter.SelectCommand.Parameters.Add("_fin", NpgsqlDbType.Timestamp).Value = Convert.ToDateTime(hora_fin);
            dataAdapter.SelectCommand.Parameters.Add("_dia", NpgsqlDbType.Text).Value = dia;
            dataAdapter.SelectCommand.Parameters.Add("id_usuario", NpgsqlDbType.Integer).Value = int.Parse(id_usuario);
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
    public DataTable mostrarcitasdoctor(string doctor_id)
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_cita", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("id_user", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
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
    public DataTable mostraralergiasAdmon()
    {
        DataTable alergias = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_ver_alergias", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(alergias);
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
        return alergias;
    }
    public void guardacita(string idcita, string doctor_id, string diagnostico, string cirugia, string descripcirugia, string fechacirugia, string medicina, string dosis, string fechainimedicina, string fechafinmedicina)
    /*guardar cita sin alergias*/
    {
        DataTable citas = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_citadoctor3", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("diagnostico_", NpgsqlDbType.Text).Value = diagnostico;
            dataAdapter.SelectCommand.Parameters.Add("doctoid_", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
            dataAdapter.SelectCommand.Parameters.Add("idcita_", NpgsqlDbType.Integer).Value = int.Parse(idcita);
            dataAdapter.SelectCommand.Parameters.Add("cirugia_", NpgsqlDbType.Text).Value = cirugia;
            dataAdapter.SelectCommand.Parameters.Add("descripcirugia_", NpgsqlDbType.Text).Value = descripcirugia;
            dataAdapter.SelectCommand.Parameters.Add("fechacirugia_", NpgsqlDbType.Text).Value = fechacirugia;
            dataAdapter.SelectCommand.Parameters.Add("idmedicina_", NpgsqlDbType.Integer).Value = int.Parse(medicina);
            dataAdapter.SelectCommand.Parameters.Add("dosis_", NpgsqlDbType.Integer).Value = int.Parse(dosis);
            dataAdapter.SelectCommand.Parameters.Add("fechafinmedicina_", NpgsqlDbType.Text).Value = fechafinmedicina;
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
    public DataTable guardarcita2(string idcita, string doctor_id, string diagnostico, string alergia, string descripalergia, string medicina, string dosis, string fechainimedicina, string fechafinmedicina)
    /*guarda la cita mientras el doctor y el paciente estan en ella*/
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_citadoctor2", conection);
            dataAdapter.SelectCommand.Parameters.Add("diagnostico_", NpgsqlDbType.Text).Value = diagnostico;
            dataAdapter.SelectCommand.Parameters.Add("doctoid_", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
            dataAdapter.SelectCommand.Parameters.Add("idcita_", NpgsqlDbType.Integer).Value = int.Parse(idcita);
            dataAdapter.SelectCommand.Parameters.Add("idalergia_", NpgsqlDbType.Integer).Value = int.Parse(alergia);
            dataAdapter.SelectCommand.Parameters.Add("descripalergia_", NpgsqlDbType.Text).Value = descripalergia;
            dataAdapter.SelectCommand.Parameters.Add("idmedicina_", NpgsqlDbType.Integer).Value = int.Parse(medicina);
            dataAdapter.SelectCommand.Parameters.Add("dosis_", NpgsqlDbType.Integer).Value = int.Parse(dosis);
            dataAdapter.SelectCommand.Parameters.Add("fechafinmedicina_", NpgsqlDbType.Text).Value = fechafinmedicina;
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    public DataTable guardarcita3(string idcita, string doctor_id, string diagnostico, string medicina, string dosis, string fechainimedicina, string fechafinmedicina)
    /*guarda la cita mientras el doctor y el paciente estan en ella*/
    {
        DataTable hv_doc = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_citadoctor4", conection);
            dataAdapter.SelectCommand.Parameters.Add("diagnostico_", NpgsqlDbType.Text).Value = diagnostico;
            dataAdapter.SelectCommand.Parameters.Add("doctoid_", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
            dataAdapter.SelectCommand.Parameters.Add("idcita_", NpgsqlDbType.Integer).Value = int.Parse(idcita);
            dataAdapter.SelectCommand.Parameters.Add("idmedicina_", NpgsqlDbType.Integer).Value = int.Parse(medicina);
            dataAdapter.SelectCommand.Parameters.Add("dosis_", NpgsqlDbType.Integer).Value = int.Parse(dosis);
            dataAdapter.SelectCommand.Parameters.Add("fechafinmedicina_", NpgsqlDbType.Text).Value = fechafinmedicina;
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    public DataTable editarparametrizacion(String duracion_citas, String hora_inicio, String hora_fin, int id_paremetrizacion)
    {
        DataTable parametri = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(" hospital.f_edita_tiempo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_horario", NpgsqlDbType.Integer).Value = id_paremetrizacion;
            dataAdapter.SelectCommand.Parameters.Add("_duracion_citas", NpgsqlDbType.Text).Value = duracion_citas;
            dataAdapter.SelectCommand.Parameters.Add("_hora_inicio", NpgsqlDbType.Text).Value = hora_inicio;
            dataAdapter.SelectCommand.Parameters.Add("_hora_fin", NpgsqlDbType.Text).Value = hora_fin;
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

