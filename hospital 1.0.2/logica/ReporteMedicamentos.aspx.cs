using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Logica;
using utilitarios;

public partial class vista_ReporteMedicamentos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CRS_medicamento.ReportDocument.SetDataSource(obtenerDatos());

        CRV_medicamento.ReportSource = CRS_medicamento;
    }
    protected DataSet obtenerDatos()
    {
        DataSet datos = new DataSet();

        Lreportes logica = new Lreportes();
        DataTable resultado = logica.buscarmedicinareporte((int.Parse(Session["id_user"].ToString())));
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


        datos = logica.enviarMedicinasR(resultado);
        return datos;
    }
}
