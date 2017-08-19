using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class vista_Reportecitas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CRS_citas.ReportDocument.SetDataSource(obtenerDatos());
        CRV_citas.ReportSource = CRS_citas;
    }


    protected DataSet obtenerDatos()
    {
        Reportes datos = new Reportes();
        DAO_doctores baseD = new DAO_doctores();
        DataTable resultado;
        if (Session["usuarioSeleccionado"] != null)
        {
            resultado = baseD.buscarcitareporte(int.Parse(Session["usuarioSeleccionado"].ToString()));
        }
        else { 
            resultado = baseD.buscarcitareporte(int.Parse(Session["id_user"].ToString()));
        }
        if (resultado.Rows.Count == 0)
        {
            Response.Redirect("Nohay.aspx");
        }
        DataTable data = new DataTable(); //dt
        data = datos.citas;
        DataRow fila;
        for (int i = 0; i < resultado.Rows.Count; i++)
        {
            fila = data.NewRow();

            fila["nombre"] = resultado.Rows[i]["nombre"].ToString();
            fila["apellido"] = resultado.Rows[i]["apellido"].ToString();
            fila["documento"] = resultado.Rows[i]["documento"].ToString();
            fila["edad"] = resultado.Rows[i]["edad"].ToString();
            fila["tipo_sangre"] = resultado.Rows[i]["tipo_de_sangre"].ToString();
            fila["fecha_ult_examen"] = resultado.Rows[i]["fecha_de_ultimo_examen"].ToString();
            fila["hora_ini_cita"] = resultado.Rows[i]["hora_inicio"].ToString();
            fila["hora_fin_cita"] = resultado.Rows[i]["hora_fin"].ToString();
            fila["tipo"] = resultado.Rows[i]["tipo"].ToString();
            fila["diagnostico"] = resultado.Rows[i]["diagnostico"].ToString();
            fila["nombredoc"] = resultado.Rows[i]["nombredoc"].ToString();
            fila["apellidodoc"] = resultado.Rows[i]["apellidodoc"].ToString();

            data.Rows.Add(fila);
        }


        return datos;
    }

}