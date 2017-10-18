using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Logica;
using utilitarios;

public partial class vista_ReporteCirugias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CRS_Cirugia.ReportDocument.SetDataSource(obtenerDatos());
        CRV_Cirugia.ReportSource = CRS_Cirugia;
    }
    protected DataSet obtenerDatos()
    {
        DataSet datos = new DataSet();

        Lreportes logica = new Lreportes();
        DataTable resultado = logica.buscarcirugiareporte((int.Parse(Session["id_user"].ToString())));
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


        datos = logica.enviarCirugiasR(resultado);
        return datos;
    }
}
