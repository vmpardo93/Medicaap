using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;

public partial class Horariodoc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void B_cargar_Click(object sender, EventArgs e)
    {
        if (Session["id_user"] != null && Session["rol_user"].ToString().Equals("3"))
        {
            ClientScriptManager cm = this.ClientScript;
            DateTime hoy = DateTime.Today;
            String inicio = C_inicio.SelectedDate.ToShortDateString();
            String fin = C_fin.SelectedDate.ToShortDateString();
            try
            {
                if (Convert.ToDateTime(inicio) < Convert.ToDateTime(fin))
                {
                    if (CB_lunes.Checked == true)
                    {
                        String lunesini = DDL_horainiciolunes.Text;
                        String lunesfin = DDL_horafinlunes.Text;
                        if (lunesini != null && lunesfin != null)
                        {
                            if (DateTime.Parse(lunesini) < DateTime.Parse(lunesfin))
                            {
                                String horario = "dia:1-hi:" + lunesini + "-hf:" + lunesfin;
                                DAO_doctores user = new DAO_doctores();
                                user.guardarhorariodoc(inicio, fin, horario, Session["id_user"].ToString());
                            }
                            else
                            {
                                throw new System.Exception("La hora de inicio no puede ser menor a la final en lunes");                                                        
                            }
                        }
                        else
                        {
                            throw new System.Exception("debe seleccionar la hora de inicio y fin del dia lunes");                                                        
                        }
                    }
                    if (CB_martes.Checked == true)
                    {
                        String martesini = DDL_horainiciomartes.Text;
                        String martesfin = DDL_horafinmartes.Text;
                        if (martesini != null && martesfin != null)
                        {
                            if (DateTime.Parse(martesini) < DateTime.Parse(martesfin))
                            {
                                String horario = "dia:2-hi:" + martesini + "-hf:" + martesfin;
                                DAO_doctores user = new DAO_doctores();
                                user.guardarhorariodoc(inicio, fin, horario, Session["id_user"].ToString());
                            }
                            else
                            {
                                throw new System.Exception("La hora de inicio no puede ser menor a la final en martes");                                                        
                            }
                        }
                        else
                        {
                            throw new System.Exception("debe seleccionar la hora de inicio y fin del dia martes");                            
                        }
                    }
                    if (CB_miercoles.Checked == true)
                    {
                        String miercolesini = DDL_horainiciomiercoles.Text;
                        String miercolesfin = DDL_horafinmiercoles.Text;
                        if (miercolesini != null && miercolesfin != null)
                        {
                            if (DateTime.Parse(miercolesini) < DateTime.Parse(miercolesfin))
                            {
                                String horario = "dia:3-hi:" + miercolesini + "-hf:" + miercolesfin;
                                DAO_doctores user = new DAO_doctores();
                                user.guardarhorariodoc(inicio, fin, horario, Session["id_user"].ToString());
                            }
                            else
                            {
                                throw new System.Exception("La hora de inicio no puede ser menor a la final en miercoles");                            
                            }
                        }
                        else
                        {
                            throw new System.Exception("debe seleccionar la fecha de inicio y fin del dia miercoles");                            
                        }
                    }
                    if (CB_jueves.Checked == true)
                    {
                        String juevesini = DDL_horainiciojueves.Text;
                        String juevesfin = DDL_horafinjueves.Text;
                        if (juevesini != null && juevesfin != null)
                        {
                            if (DateTime.Parse(juevesini) < DateTime.Parse(juevesfin))
                            {
                                String horario = "dia:4-hi:" + juevesini + "-hf:" + juevesfin;
                                DAO_doctores user = new DAO_doctores();
                                user.guardarhorariodoc(inicio, fin, horario, Session["id_user"].ToString());
                            }
                            else
                            {
                                throw new System.Exception("La hora de inicio no puede ser menor a la final en miercoles");                            
                        }
                        }
                        else
                        {
                            throw new System.Exception("debe seleccionar la hora de inicio y fin del dia jueves");
                        }
                    }
                    if (CB_viernes.Checked == true)
                    {
                        String viernesini = DDL_horainicioviernes.Text;
                        String viernesfin = DDL_horafinviernes.Text;
                        if (viernesini != null && viernesfin != null)
                        {
                            if (DateTime.Parse(viernesini) < DateTime.Parse(viernesfin))
                            {
                                String horario = "dia:5-hi:" + viernesini + "-hf:" + viernesfin;
                                DAO_doctores user = new DAO_doctores();
                                user.guardarhorariodoc(inicio, fin, horario, Session["id_user"].ToString());
                            }
                            else
                            {
                                throw new System.Exception("debe seleccionar la hora de inicio y fin del dia viernes");
                            }
                        }
                        else
                        {
                            throw new System.Exception("debe seleccionar la hora de inicio y fin del dia viernes");
                        }
                    }
                    if (CB_sabado.Checked == true)
                    {
                        String sabadoini = DDL_horainiciosabado.Text;
                        String sabadofin = DDL_horafinsabado.Text;
                        if (sabadofin != null && sabadoini != null)
                        {
                            if (DateTime.Parse(sabadoini) < DateTime.Parse(sabadofin))
                            {
                                String horario = "dia:6-hi:" + sabadoini + "-hf:" + sabadofin;
                                DAO_doctores user = new DAO_doctores();
                                user.guardarhorariodoc(inicio, fin, horario, Session["id_user"].ToString());
                            }
                            else
                            {
                                throw new System.Exception("La hora de inicio no puede ser menor a la final en sabado");
                            }
                        }
                        else
                        {
                            throw new System.Exception("debe seleccionar la hora de inicio y fin del dia sabado");
                        }
                    }
                    if (CB_domingo.Checked == true)
                    {
                        String domingoini = DDL_horainiciodomingo.Text;
                        String domingofin = DDL_horafindomingo.Text;
                        if (domingofin != null && domingoini != null)
                        {
                            if (DateTime.Parse(domingoini) < DateTime.Parse(domingofin))
                            {
                                String horario = "dia:7-hi:" + domingoini + "-hf:" + domingofin;
                                DAO_doctores user = new DAO_doctores();
                                user.guardarhorariodoc(inicio, fin, horario, Session["id_user"].ToString());
                            }
                            else
                            {
                                throw new System.Exception("La hora de inicio no puede ser menor a la final en domingo");
                            }
                        }
                        else
                        {
                            throw new System.Exception("debe seleccionar la hora de inicio y fin del dia  domingo");
                        }
                    }
                    Response.Redirect("verhorariot.aspx");

                }
                else
                {
                    throw new System.Exception("La fecha de inicio no puede ser menor que la final"); 
                }
            }
            catch (Exception ex) {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");

            }
        
        }
        else
        {
            Session["rol_user"] = null;
            Session["id_user"] = null;
            Response.Redirect("Login.aspx");

        }
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
     
    }

    protected void render_day(object sender, DayRenderEventArgs e)
    {
        DateTime fecha = DateTime.Now;
        if (e.Day.Date < fecha)
        {
            e.Day.IsSelectable = false;
        }
    }
}