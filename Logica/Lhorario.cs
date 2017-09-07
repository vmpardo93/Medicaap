using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;
using Data;
using System.Web;
using System.Web.UI.WebControls;

namespace Logica
{
    public class Lhorario
    {
        public String validar_existe_horario(String vali,String rol)
        {
            String direccion=null;
            if (rol != "3")
            {
                direccion = "Login.aspx";
            }
            else
            {
                if (vali == "0")
                {
                    direccion = "Horariodoc.aspx";
                }
                else 
                {
                    direccion = "verhorario.aspx";
                }
            }
            return direccion;

        }
        public Uhorario valida(DateTime fecha, DateTime anterires)
            /*este metodo es para validar que no pueda seleccionar fechas anteriores a la de hoy en los calendar*/
        {
            Uhorario datos = new Uhorario();
            if(anterires < fecha)
            {
                datos.Ver = false;
            }
            return datos;
        }
        public Uhorario guardarhorario(String inicio, String fin,Hashtable chequeo, String iddoctor,Dictionary<string,string> horasini, Dictionary<string,string>horafin) 
        {
            Uhorario datos = new Uhorario();
            DAOhorario bases = new DAOhorario();
            datos.Inicio = inicio;
            datos.Fin = fin;
            datos.Iddoctor = iddoctor;
            object lunes= chequeo["Lunes"];
            object martes = chequeo["Martes"];
            object miercoles = chequeo["Miercoles"];
            object jueves = chequeo["Jueves"];
            object viernes = chequeo["Viernes"];
            object sabado = chequeo["Sabado"];
            object domingo = chequeo["Domingo"];
            try
            {
                if (Convert.ToDateTime(inicio) < Convert.ToDateTime(fin))
                {
                    if (lunes.Equals(true))
                    {
                        if (horasini["1"] != "" && horafin["1"] != "")
                        {
                            if (DateTime.Parse(horasini["1"]) < DateTime.Parse(horafin["1"]))
                            {
                                datos.Horario = "dia:1-hi:" + horafin["1"] + "-hf" + horafin["1"];
                                bases.guardarhorariodoc(datos);
                            }
                            else
                            {
                                datos.Mensaje = "debe seleccionar un hora de inicio menor a la hora fin";
                            }
                        }
                        else
                        {
                            datos.Mensaje = "debe seleccionar una hora de inicio y fin";
                        }
                    }
                    if (martes.Equals(true))
                    {
                        if (horasini["2"] != "" && horafin["2"] != "")
                        {
                            if (DateTime.Parse(horasini["2"]) < DateTime.Parse(horafin["2"]))
                            {
                                datos.Horario = "dia:2-hi:" + horafin["2"] + "-hf" + horafin["2"];
                                bases.guardarhorariodoc(datos);
                            }
                            else
                            {
                                datos.Mensaje = "debe seleccionar un hora de inicio menor a la hora fin";
                            }
                        }
                        else
                        {
                            datos.Mensaje = "debe seleccionar una hora de inicio y fin";
                        }
                    }
                    if (miercoles.Equals(true))
                    {
                        if (horasini["3"] != "" && horafin["3"] != "")
                        {
                            if (DateTime.Parse(horasini["3"]) < DateTime.Parse(horafin["3"]))
                            {
                                datos.Horario = "dia:3-hi:" + horafin["3"] + "-hf" + horafin["3"];
                                bases.guardarhorariodoc(datos);
                            }
                            else
                            {
                                datos.Mensaje = "debe seleccionar un hora de inicio menor a la hora fin";
                            }
                        }
                        else
                        {
                            datos.Mensaje = "debe seleccionar una hora de inicio y fin";
                        }
                    }
                    if (jueves.Equals(true))
                    {
                        if (horasini["4"] != "" && horafin["4"] != "")
                        {
                            if (DateTime.Parse(horasini["4"]) < DateTime.Parse(horafin["4"]))
                            {
                                datos.Horario = "dia:4-hi:" + horafin["4"] + "-hf" + horafin["4"];
                                bases.guardarhorariodoc(datos);
                            }
                            else
                            {
                                datos.Mensaje = "debe seleccionar un hora de inicio menor a la hora fin";
                            }
                        }
                        else
                        {
                            datos.Mensaje = "debe seleccionar una hora de inicio y fin";
                        }
                    }
                    if (viernes.Equals(true))
                    {
                        if (horasini["5"] != "" && horafin["5"] != "")
                        {
                            if (DateTime.Parse(horasini["5"]) < DateTime.Parse(horafin["5"]))
                            {
                                datos.Horario = "dia:5-hi:" + horafin["5"] + "-hf" + horafin["5"];
                                bases.guardarhorariodoc(datos);
                            }
                            else
                            {
                                datos.Mensaje = "debe seleccionar un hora de inicio menor a la hora fin";
                            }
                        }
                    }
                    if (sabado.Equals(true))
                    {
                        if (horasini["6"] != "" && horafin["6"] != "")
                        {
                            if (DateTime.Parse(horasini["6"]) < DateTime.Parse(horafin["6"]))
                            {
                                datos.Horario = "dia:6-hi:" + horafin["6"] + "-hf" + horafin["6"];
                                bases.guardarhorariodoc(datos);
                            }
                            else
                            {
                                datos.Mensaje = "debe seleccionar un hora de inicio menor a la hora fin";
                            }
                        }
                        else
                        {
                            datos.Mensaje = "debe seleccionar una hora de inicio y fin";
                        }
                    }
                    if (domingo.Equals(true))
                    {
                        if (horasini["7"] != "" && horafin["7"] != "")
                        {
                            if (DateTime.Parse(horasini["7"]) < DateTime.Parse(horafin["7"]))
                            {
                                datos.Horario = "dia:7-hi:" + horafin["7"] + "-hf" + horafin["7"];
                                bases.guardarhorariodoc(datos);
                            }
                            else
                            {
                                datos.Mensaje = "debe seleccionar un hora de inicio menor a la hora fin";
                            }
                        }
                        else
                        {
                            datos.Mensaje = "debe seleccionar una hora de inicio y fin";
                        }
                    }
                }
                else
                {
                    datos.Mensaje = "la fecha inicio de be ser menor a la de fin";
                }
            }
            catch (Exception ex)
            {
                datos.Mensaje = ex.Message;
            }
            return datos;
        }
    }
}
