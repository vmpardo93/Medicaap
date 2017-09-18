using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using utilitarios;

using Data;
public partial class buscacita : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LUsuarios logica = new LUsuarios();
        Udoctor datos=logica.ValidarSesiondoc(Session["rol_user"].ToString(), Session["user"].ToString());
        this.RegisterStartupScript("mensaje", datos.Mensaje);
        ClientScriptManager cm = this.ClientScript;
        Lnombre.Visible = false;
        Lapellido.Visible = false;
        Label1.Visible = false;
        LB_descripalergia.Visible = false;
        LB_diagnostico.Visible = false;
        DDL_alergias.Visible = false;
        DDL_horacirugia.Visible = false;
        DDL_medicina.Visible = false;
        TB_fecha_cirugia.Visible = false;
        DDL_horacirugia.Visible = false;
        L_paciente.Visible = false;
        L_fefinme.Visible = false;
        L_descirugia.Visible = false;
        L_alergias.Visible = false;
        L_cirugia.Visible = false;
        L_desalergias.Visible = false;
        L_diagnostico.Visible = false;
        L_dosis.Visible = false;
        L_fecirugia.Visible = false;
        L_hora.Visible = false;
        L_medicinas.Visible = false;
        LB_descripcion_cirugia.Visible = false;
        TB_cirugia.Visible = false;
        TB_dosis.Visible = false;
        TB_fechafin.Visible = false;
        B_cargar.Visible = false;
        
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

    }
    protected void B_cargar_Click(object sender, EventArgs e)
    {
        try
            {
                DateTime hoy = DateTime.Today;
                String fecha = TB_fecha_cirugia.Text;
                String diagnostico = LB_diagnostico.Text;
                GridViewRow row = this.GV_citasdoc.SelectedRow;
                
                Lcitas doc = new Lcitas();
                Ucitas datos = new Ucitas();

                String idalergia = DDL_alergias.SelectedItem.Value;
                String idcita = Convert.ToString(GV_citasdoc.DataKeys[row.RowIndex].Values[0].ToString());
                String iddoc = Session["id_user"].ToString();
                String descripalergia = LB_descripalergia.Text;
                String fechasinhciru = TB_fecha_cirugia.Text;
                String horaciru = DDL_horacirugia.Text;
                String fechacirugia = TB_fecha_cirugia.Text + DDL_horacirugia.Text;
                String idmedicina = DDL_medicina.SelectedItem.Value;
                String idmedicna = idmedicina;
                String dosis = TB_dosis.Text;
                String fechafin = TB_fechafin.Text;
                String cirugia = TB_cirugia.Text;
                String descripcirugia = LB_descripcion_cirugia.Text;
                String fechaini = "2017-06-23";
                doc.guardarcitasdoc(idcita, Session["id_user"].ToString(), diagnostico, idalergia, descripalergia, cirugia, descripcirugia, fechasinhciru,horaciru, fechacirugia, idmedicina, dosis, fechaini, fechafin);

                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + datos.Mensaje + "');window.location=\"" + datos.Url + "\"</script>");

            }
            catch(Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('"+ex.Message+"');</script>");//ESTE
            }
            
    }
    protected void GV_citasdocSelectedIndexChanged(object sender, EventArgs e)
    {
        Lnombre.Text = Convert.ToString(GV_citasdoc.SelectedRow.Cells[3].Text);
        Lapellido.Text = Convert.ToString(GV_citasdoc.SelectedRow.Cells[4].Text);
        Lnombre.Visible = true;
        Lapellido.Visible = true;
        Label1.Visible = true;
        LB_descripalergia.Visible = true;
        LB_diagnostico.Visible = true;
        DDL_alergias.Visible = true;
        DDL_horacirugia.Visible = true;
        DDL_medicina.Visible = true;
        DDL_horacirugia.Visible = true;
        L_paciente.Visible = true;
        L_fefinme.Visible = true;
        L_descirugia.Visible = true;
        L_alergias.Visible = true;
        L_cirugia.Visible = true;
        L_desalergias.Visible = true;
        L_diagnostico.Visible = true;
        L_dosis.Visible = true;
        L_fecirugia.Visible = true;
        L_hora.Visible = true;
        L_medicinas.Visible = true;
        LB_descripcion_cirugia.Visible = true;
        TB_cirugia.Visible = true;
        TB_dosis.Visible = true;
        TB_fechafin.Visible = true;
        TB_fecha_cirugia.Visible = true;
        B_cargar.Visible = true;

    }
}