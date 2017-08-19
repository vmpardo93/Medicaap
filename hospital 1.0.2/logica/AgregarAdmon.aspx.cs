using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_AgregarAdmon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();
     }
    protected void B_cargarmedicina_Click(object sender, EventArgs e)
    {

        try
        {
            DAO_doctores bases = new DAO_doctores();
            bases.guardarmedicina(TB_medicina.Text);
            Response.Redirect("AgregarAdmon.aspx");
        }
        catch (Exception Ex)
        {
            this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('ya existe esta medicina);</script>"));
        }
    }
    protected void B_CargarAlergia_Click(object sender, EventArgs e)
    {
        try
        {
            DAO_doctores bases = new DAO_doctores();
            bases.guardaralergia(TB_alergia.Text);
            Response.Redirect("AgregarAdmon.aspx");
        }
        catch (Exception Ex)
        {
            this.RegisterStartupScript("mensaje", ("<script type='text/javascript'>alert('ya existe esta alergia);</script>"));
        }

    }


    protected void updating(object sender, GridViewUpdateEventArgs e)
    {
   
            int index = e.RowIndex;
            GridViewRow row = (GridViewRow)GV_parametriza.Rows[index];
            DropDownList duracion = (DropDownList)row.FindControl("DDL_duracion");
            DropDownList hora_inicio1 = (DropDownList)row.FindControl("DDL_horainicio");
            DropDownList hora_fin1 = (DropDownList)row.FindControl("DDL_horafin");
            String hora_inicio = hora_inicio1.SelectedValue;
            String hora_fin = hora_fin1.SelectedValue;
            String duraci = duracion.SelectedValue;
        /*    if (DateTime.Parse(hora_inicio) > DateTime.Parse(hora_fin)) {
                throw new System.Exception("la hora de inicio no puede ser menor a la final");
                Response.Redirect("AgregarAdmon.aspx");
            }//creo que esto de abajo no va esta doblando las variables
        */
            e.NewValues.Add("duracion_citas", duraci);
            e.NewValues.Add("hora_inicio", hora_inicio);
            e.NewValues.Add("hora_fin", hora_fin);
        
    }
}