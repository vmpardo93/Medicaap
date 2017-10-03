using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using Logica;
using utilitarios;

public partial class Horariodoc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios logica=new LUsuarios();
        Udoctor datos = logica.ValidarSesiondoc(Session["rol_user"].ToString(), Session["user"].ToString());
        this.RegisterStartupScript("mensaje", datos.Mensaje);
    }

    protected void B_cargar_Click(object sender, EventArgs e)
    {
        
        Lhorario logic=new Lhorario();
        Uhorario datos = new Uhorario();
        String inicio = C_inicio.SelectedDate.ToShortDateString();
        String fin = C_fin.SelectedDate.ToShortDateString();
 
        Hashtable hash= new Hashtable();
        hash.Add(CB_lunes.Text,CB_lunes.Checked);
        hash.Add(CB_martes.Text,CB_martes.Checked);
        hash.Add(CB_miercoles.Text,CB_miercoles.Checked);
        hash.Add(CB_jueves.Text,CB_jueves.Checked);
        hash.Add(CB_viernes.Text, CB_viernes.Checked);
        hash.Add(CB_sabado.Text,CB_sabado.Checked);
        hash.Add(CB_domingo.Text,CB_domingo.Checked);
        
        var lista_horasini=new Dictionary<string, string>();
        lista_horasini.Add("1",DDL_horainiciolunes.Text);
        lista_horasini.Add("2",DDL_horainiciomartes.Text);
        lista_horasini.Add("3",DDL_horainiciomiercoles.Text);
        lista_horasini.Add("4",DDL_horainiciojueves.Text);
        lista_horasini.Add("5",DDL_horainicioviernes.Text);
        lista_horasini.Add("6",DDL_horainiciosabado.Text);
        lista_horasini.Add("7",DDL_horainiciodomingo.Text);

        var lista_horafin= new Dictionary<string,string>();
        lista_horafin.Add("1",DDL_horafinlunes.Text);
        lista_horafin.Add("2",DDL_horafinmartes.Text);
        lista_horafin.Add("3",DDL_horafinmiercoles.Text);
        lista_horafin.Add("4",DDL_horafinjueves.Text);
        lista_horafin.Add("5",DDL_horafinviernes.Text);
        lista_horafin.Add("6",DDL_horafinsabado.Text);
        lista_horafin.Add("7",DDL_horafindomingo.Text);

        logic.guardarhorario(inicio,fin,hash,Session["id_user"].ToString(),lista_horasini,lista_horafin);

        this.RegisterStartupScript("mensaje", datos.Mensaje);


        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
     
    }

    protected void render_day(object sender, DayRenderEventArgs e)
    {
        DateTime fecha = DateTime.Now;
        DateTime ant = e.Day.Date;
        Lhorario logica = new Lhorario();
        Uhorario datos =new Uhorario();
    }
}