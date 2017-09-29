using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using utilitarios;

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
            DAOcitas bases = new DAOcitas();
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
        public void cancelarCitasUsuario(int id_usuario)
        {
            DAOcitas citas = new DAOcitas();
            citas.cancelarCitaUsuario(id_usuario);


        }
    }
}
