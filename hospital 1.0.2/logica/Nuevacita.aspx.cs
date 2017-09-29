using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using Logica;
using utilitarios;
using Data;

public partial class vista_Nuevacita : System.Web.UI.Page
{
    DateTime dia;
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios user = new LUsuarios();
        UUsuario datos = new UUsuario();
        datos = user.ValidarSesionPaci(Session["rol_user"].ToString(), Session["user"].ToString());
        this.RegisterStartupScript("mensaje", datos.Mensaje);

        if (!IsPostBack)
        {
            C_Ncita.SelectedDate = DateTime.Now;
        }
        C_Ncita.DayRender += new DayRenderEventHandler(this.CL_Citas_DayRender);
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

        dia = C_Ncita.SelectedDate;
        Lpacientes data = new Lpacientes();
        GV_CitasDisponibles.DataSource = data.buscarCitaD(dia);
        GV_CitasDisponibles.DataBind();



    }
    protected void GV_CitasDisponibles_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GV_CitasDisponibles.PageIndex = e.NewPageIndex;
        llenarDatos();
    }
    private void llenarDatos()
    {
        dia = C_Ncita.SelectedDate;
        Lpacientes data = new Lpacientes();
        DataTable datos_llenos = new DataTable();
        datos_llenos = data.buscarCitaD(dia);
        this.GV_CitasDisponibles.DataSource = datos_llenos;
        this.GV_CitasDisponibles.DataBind();
    }
    protected void GV_CitasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
    {


        Ucitas datos = new Ucitas();
        Lpacientes citas = new Lpacientes();

        GridViewRow row = this.GV_CitasDisponibles.SelectedRow;
        int id_cita = int.Parse(GV_CitasDisponibles.DataKeys[row.RowIndex].Values[0].ToString());
        // debe ir un if para verificar que no este ocupado ese horario
        datos = citas.sacarcita(id_cita, (int.Parse(Session["id_user"].ToString())));
        string direc = datos.Url;
        this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('" + datos.Mensaje + "');</script>"));
        Response.Redirect(direc);


    }
    protected void CL_Citas_DayRender(object sender, DayRenderEventArgs e)
    {
        Lcitas logica = new Lcitas();
        Ucitas datos = new Ucitas();
        DAOcitas doc = new DAOcitas();
        DataTable dias = doc.obtenerfechas();
        /* DateTime ant=e.Day.Date;
         DateTime fecha = DateTime.Now;
         logica.validar(fecha,ant);*/
        if (e.Day.Date < DateTime.Now)
        {
            e.Day.IsSelectable = false;
            e.Cell.ForeColor = System.Drawing.Color.Gray;
        }


        int cant = dias.Rows.Count;
        if (cant > 0)
        {
            for (int i = 0; i < cant; i++)
            {
                if (e.Day.Date == DateTime.Parse(dias.Rows[i][0].ToString()).Date)
                {
                    //e.Day.IsSelectable = false;
                    //e.Cell.Enabled = false;
                    e.Cell.ToolTip = "DIA CON CITA";
                    //e.Cell.Controls[0].Visible = false;
                    e.Cell.ForeColor = System.Drawing.Color.Blue;

                }


            }
        }
    }
}