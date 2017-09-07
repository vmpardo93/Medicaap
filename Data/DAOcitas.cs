﻿using Npgsql;
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
    public class DAOcitas
    {
        public DataTable mostrarcitasdoctor(string doctor_id)
        {
            DataTable citas = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_busca_cita", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("id_user", NpgsqlDbType.Integer).Value = int.Parse(doctor_id);
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
        public DataTable guardarcitaactual(Ucitas citas)
        /*guarda la cita mientras el doctor y el paciente estan en ella*/
        {
            DataTable citasdoc = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_citadoctor", conection);
                dataAdapter.SelectCommand.Parameters.Add("diagnostico_", NpgsqlDbType.Text).Value = citas.Diagnostico;
                dataAdapter.SelectCommand.Parameters.Add("doctoid_", NpgsqlDbType.Integer).Value = int.Parse(citas.Iddoctor);
                dataAdapter.SelectCommand.Parameters.Add("idcita_", NpgsqlDbType.Integer).Value = int.Parse(citas.Idcita);
                dataAdapter.SelectCommand.Parameters.Add("idalergia_", NpgsqlDbType.Integer).Value = int.Parse(citas.Alergia);
                dataAdapter.SelectCommand.Parameters.Add("descripalergia_", NpgsqlDbType.Text).Value = citas.Descripcionalergia;
                dataAdapter.SelectCommand.Parameters.Add("cirugia_", NpgsqlDbType.Text).Value = citas.Cirugia;
                dataAdapter.SelectCommand.Parameters.Add("descripcirugia_", NpgsqlDbType.Text).Value = citas.Descripcioncirugia;
                dataAdapter.SelectCommand.Parameters.Add("fechacirugia_", NpgsqlDbType.Text).Value = citas.Fechacirugia;
                dataAdapter.SelectCommand.Parameters.Add("id_medicina_", NpgsqlDbType.Integer).Value = int.Parse(citas.Medicinas);
                dataAdapter.SelectCommand.Parameters.Add("dosis_", NpgsqlDbType.Integer).Value = int.Parse(citas.Dosis);
                dataAdapter.SelectCommand.Parameters.Add("fechafinmedicina_", NpgsqlDbType.Text).Value = citas.Fechafinmedicina;

                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                conection.Open();
                dataAdapter.Fill(citasdoc);
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
            return citasdoc;
        }
        public void guardacita(Ucitas datos)
        /*guardar cita sin alergias*/
        {
            DataTable citas = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_citadoctor3", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("diagnostico_", NpgsqlDbType.Text).Value = datos.Diagnostico;
                dataAdapter.SelectCommand.Parameters.Add("doctoid_", NpgsqlDbType.Integer).Value = int.Parse(datos.Iddoctor);
                dataAdapter.SelectCommand.Parameters.Add("idcita_", NpgsqlDbType.Integer).Value = int.Parse(datos.Idcita);
                dataAdapter.SelectCommand.Parameters.Add("cirugia_", NpgsqlDbType.Text).Value = datos.Cirugia;
                dataAdapter.SelectCommand.Parameters.Add("descripcirugia_", NpgsqlDbType.Text).Value = datos.Descripcioncirugia;
                dataAdapter.SelectCommand.Parameters.Add("fechacirugia_", NpgsqlDbType.Text).Value = datos.Fechacirugia;
                dataAdapter.SelectCommand.Parameters.Add("idmedicina_", NpgsqlDbType.Integer).Value = int.Parse(datos.Mensaje);
                dataAdapter.SelectCommand.Parameters.Add("dosis_", NpgsqlDbType.Integer).Value = int.Parse(datos.Dosis);
                dataAdapter.SelectCommand.Parameters.Add("fechafinmedicina_", NpgsqlDbType.Text).Value = datos.Fechafinmedicina;
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
        public DataTable guardarcita2(Ucitas datos)
        /*guarda la cita mientras el doctor y el paciente estan en ella*/
        {
            DataTable hv_doc = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_citadoctor2", conection);
                dataAdapter.SelectCommand.Parameters.Add("diagnostico_", NpgsqlDbType.Text).Value = datos.Diagnostico;
                dataAdapter.SelectCommand.Parameters.Add("doctoid_", NpgsqlDbType.Integer).Value = int.Parse(datos.Iddoctor);
                dataAdapter.SelectCommand.Parameters.Add("idcita_", NpgsqlDbType.Integer).Value = int.Parse(datos.Idcita);
                dataAdapter.SelectCommand.Parameters.Add("idalergia_", NpgsqlDbType.Integer).Value = int.Parse(datos.Alergia);
                dataAdapter.SelectCommand.Parameters.Add("descripalergia_", NpgsqlDbType.Text).Value = datos.Descripcionalergia;
                dataAdapter.SelectCommand.Parameters.Add("idmedicina_", NpgsqlDbType.Integer).Value = int.Parse(datos.Medicinas);
                dataAdapter.SelectCommand.Parameters.Add("dosis_", NpgsqlDbType.Integer).Value = int.Parse(datos.Dosis);
                dataAdapter.SelectCommand.Parameters.Add("fechafinmedicina_", NpgsqlDbType.Text).Value = datos.Fechafinmedicina;
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
        public DataTable guardarcita3(Ucitas datos)
        /*guarda la cita mientras el doctor y el paciente estan en ella*/
        {
            DataTable hv_doc = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConexionHospital"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("hospital.f_add_citadoctor4", conection);
                dataAdapter.SelectCommand.Parameters.Add("diagnostico_", NpgsqlDbType.Text).Value = datos.Diagnostico;
                dataAdapter.SelectCommand.Parameters.Add("doctoid_", NpgsqlDbType.Integer).Value = int.Parse(datos.Iddoctor);
                dataAdapter.SelectCommand.Parameters.Add("idcita_", NpgsqlDbType.Integer).Value = int.Parse(datos.Idcita);
                dataAdapter.SelectCommand.Parameters.Add("idmedicina_", NpgsqlDbType.Integer).Value = int.Parse(datos.Medicinas);
                dataAdapter.SelectCommand.Parameters.Add("dosis_", NpgsqlDbType.Integer).Value = int.Parse(datos.Dosis);
                dataAdapter.SelectCommand.Parameters.Add("fechafinmedicina_", NpgsqlDbType.Text).Value = datos.Fechafinmedicina;
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
    }
}