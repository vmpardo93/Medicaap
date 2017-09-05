using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

public partial class vista_Nuevacita : System.Web.UI.Page
{
    DateTime dia;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack){
           // C_Ncita.SelectedDate = DateTime.Now;
        }
    //    C_Ncita.DayRender += new DayRenderEventHandler(this.CL_Citas_DayRender);

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        
       /* dia =C_Ncita.SelectedDate;
        DAO_doctores data =new DAO_doctores();
        GV_CitasDisponibles.DataSource = data.buscarcitasD(dia);
        GV_CitasDisponibles.DataBind();
        */


    }
    protected void GV_CitasDisponibles_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
       // this.GV_CitasDisponibles.PageIndex = e.NewPageIndex;
        llenarDatos();
    }
    private void llenarDatos()
    {
     /*   dia = C_Ncita.SelectedDate;
        DAO_doctores data = new DAO_doctores();
        DataTable datos_llenos = new DataTable();
        datos_llenos = data.buscarcitasD(dia);
        this.GV_CitasDisponibles.DataSource = datos_llenos;
        this.GV_CitasDisponibles.DataBind();*/
    }
    protected void GV_CitasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
    {

        DAO_doctores doctores = new DAO_doctores();
        DAO_Citas citas = new DAO_Citas();
        DataTable citadisponible = new DataTable();
     /*   GridViewRow row = this.GV_CitasDisponibles.SelectedRow;
        int id_cita = int.Parse(GV_CitasDisponibles.DataKeys[row.RowIndex].Values[0].ToString());
        // debe ir un if para verificar que no este ocupado ese horario
        citadisponible=citas.verificarCita(id_cita,int.Parse(Session["id_user"].ToString()));
        if(citadisponible.Rows.Count == 0 ){
            doctores.sacarCita(id_cita, (int.Parse(Session["id_user"].ToString())));
            MailMessage mail_ = new MailMessage();
            mail_.From = new MailAddress("vicmacondo@hotmail.com");
            DataTable correo = doctores.obtenercorreo(int.Parse(Session["id_user"].ToString()));
            if (correo.Rows.Count != 0)
            {
                mail_.To.Add(correo.Rows[0]["correo"].ToString());
                mail_.Subject = "nueva cita medica Medicapp";
                mail_.Body = "se agendo una nueva cita medica con numero de identificacion: " + id_cita;
                mail_.IsBodyHtml = false;
                mail_.Priority = MailPriority.Normal;
                SmtpClient smpt = new SmtpClient();
                smpt.Credentials = new NetworkCredential("vicmacondo@hotmail.com", "vmpardo93_");
                smpt.Host = "smpt.hotmail.com";
                smpt.Port = 587;
                smpt.EnableSsl = true;
                try
                {
                    smpt.Send(mail_);


                }
                catch
                {
                    this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('no fue posible enviar cita');</script>"));
                }
                mail_.Dispose();
                Response.Redirect("NuevaCita.aspx");
            }
            else
            {
                Response.Redirect("NuevaCita.aspx");
            }
        }
        else
        {
            this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('ya se tiene asignada una cita con esa fecha y hora');</script>"));
            Response.Redirect("NuevaCita.aspx");
        }
        */

    }
    protected void CL_Citas_DayRender(object sender, DayRenderEventArgs e)
    {
        DAO_doctores doc = new DAO_doctores();
        DataTable dias = doc.obtenerfechas();

        if (e.Day.Date < DateTime.Now.Date)
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