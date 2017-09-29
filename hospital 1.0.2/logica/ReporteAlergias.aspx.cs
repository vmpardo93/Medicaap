using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Logica;
using Data;
using System.Collections;
using utilitarios;

public partial class vista_ReporteAlergias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CRS_Alergias.ReportDocument.SetDataSource(obtenerDatos());
        CRV_Alergias.ReportSource = CRS_Alergias;
    }
    protected DataSet obtenerDatos()
    {
        DataSet datos = new DataSet();

        Lpacientes logica = new Lpacientes();
        DataTable resultado = logica.buscaralergiareporte((int.Parse(Session["id_user"].ToString())));
        try
        {
            int filas = resultado.Rows.Count;
            string redirec;
            redirec = logica.verificarReportes(filas);
            Response.Redirect(redirec);
        }

        catch (Exception ex)
        {

        }


        datos = logica.enviarAlergiasR(resultado);
        return datos;
    }
}