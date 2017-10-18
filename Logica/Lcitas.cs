using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using utilitarios;
using System.Data;
using DataPersis;

namespace Logica
{
   public  class Lcitas
    {
       public Ucitas validar(DateTime fecha, DateTime anterior, object col) 
       {
           Ucitas datos = new Ucitas();
           if (fecha < anterior) 
           {
              datos.Ver= false;
              datos.Color = col;    
           }
           return datos;
       }
        public Ucitas guardarcitasdoc(String idcita,String doctorid, String diagnostico, String alergia, String descripalergia, String cirugia, String descripcirugia,String fechacirusinh, String horaciru,String fechacirugia, String medicina, String dosis, String fechainimedicina,String fechafinmedicina) 
        {
            Ucitas datos = new Ucitas();
            DAOcita bases = new DAOcita();
            datos.Idcita = idcita;
            datos.Iddoctor = doctorid;
            datos.Diagnostico = diagnostico;
            datos.Alergia = alergia;
            datos.Descripcionalergia = descripalergia;
            datos.Cirugia = cirugia;
            datos.Descripcioncirugia = descripcirugia;
            datos.Fechacirugia = fechacirugia;
            datos.Medicinas = medicina;
            datos.Dosis = dosis;
            datos.Fechainimedicina = fechainimedicina;
            datos.Fechafinmedicina = fechafinmedicina;
            if (medicina.Equals("0"))
            {
                datos.Mensaje = "debe selecionar una medicina";
            }
            if (DateTime.Parse(fechafinmedicina) < DateTime.Today)
            {
                datos.Mensaje = "la fecha del fin de la mediciona no puede ser menor a la actual";
            }
            else
            {
                if (!cirugia.Equals(""))
                {
                    if (fechacirugia.Equals("") || horaciru.Equals("") || descripcirugia.Equals(""))
                    {
                        datos.Mensaje = "revisar que los campos de cirugia esten completos";
                    }
                    else if (alergia.Equals(""))
                    {
                        if (DateTime.Parse(fechacirusinh) > DateTime.Today)
                        {
                            bases.guardacita(datos);
                            datos.Mensaje = "registro exitoso";
                        }
                        else
                        {
                            datos.Mensaje = "la fecha de la cirugia debe ser futura";
                        }
                    }
                }
                if (!alergia.Equals(""))
                {
                    if (descripalergia.Equals(""))
                    {
                        datos.Mensaje = "revisar que la descripcion de la alergia este completa";
                    }
                    else if (cirugia.Equals(""))
                    {
                        bases.guardarcita2(datos);
                        datos.Mensaje = "registro exitoso";
                        
                    }
                }
                if (!alergia.Equals("") && !alergia.Equals(""))
                {
                    if (DateTime.Parse(fechacirusinh) > DateTime.Today)
                    {
                        bases.guardarcitaactual(datos);
                        datos.Mensaje = "registro exitoso";
                    }
                    else 
                    {
                        datos.Mensaje = "la fecha de la cirugia debe ser futura";
                    }
                }
                else if (alergia.Equals("") && cirugia.Equals(""))
                {
                    bases.guardarcita3(datos);
                    datos.Mensaje = "registro exitoso";
                }
            }
            return datos;
        }
        public Ucitas validar(DateTime fecha,DateTime anteriores)
        {
            Ucitas datos = new Ucitas();
            if (anteriores < fecha) 
            {
                
                datos.Ver = false;
            }
            return datos;
        }
       public DataTable mostrarcitasdoctor(String doctor_id)
       {
           DAOcita dao = new DAOcita();
           Ucitas datos = new Ucitas();
           datos.Iddoctor = doctor_id;
           return dao.mostrarcitasdoc(datos);
       }
        public void cancelarCitasUsuario(int id_usuario)
        {
            DAOcita citas = new DAOcita();
            Ucitas datos = new Ucitas();
            datos.Idcita = Convert.ToString(id_usuario);
            citas.cancelarCitaUsuario(datos);

        }
       public DataTable mostrarCitasSeparadas(int id_user)
        {
            Ucitas datos= new Ucitas();
            datos.Idpaciente=id_user;
            DAOcita dao = new DAOcita();
            return dao.mostrarcitasseparadas(datos);

        }
       public DataTable buscarcitaid(int id_user)
       {
           Ucitas datos = new Ucitas();
           DAOcita dao = new DAOcita();
           datos.Idpaciente = id_user;
           return dao.buscarcitaid(datos);

       }
       public DataTable buscarCitaD(DateTime fecha)
       {
           Ucitas datos = new Ucitas();
           DAOcita dao = new DAOcita();
           datos.Fechacita = fecha;
           return dao.buscarcitasD(datos);

       }

       public Ucitas sacarcita(int IdCita, int IdUsuario)
       {
           Ucitas citas = new Ucitas();
           DAOcita dao = new DAOcita();
           DataTable citadisponible = new DataTable();
           citas.Idcita = Convert.ToString(IdCita);
           citas.Idpaciente = IdUsuario;
           citadisponible = dao.verificarCita(citas);

           if (citadisponible.Rows.Count == 0)
           {
               dao.sacarCita(citas);
               citas.Mensaje = "Cita apartada exitosamente";
               citas.Url = "NuevaCita.aspx";
           }
           else
           {
               citas.Mensaje = "ya se tiene asignada una cita con esa fecha y hora";
               citas.Url = "NuevaCita.aspx";
           }
           return citas;
       }
    }
}
