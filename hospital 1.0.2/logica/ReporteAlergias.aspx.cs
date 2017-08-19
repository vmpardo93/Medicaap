using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class vista_ReporteAlergias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CRS_Alergias.ReportDocument.SetDataSource(obtenerDatos());
        CRV_Alergias.ReportSource = CRS_Alergias;
    }
    protected DataSet obtenerDatos()
    {
        Reportes datos = new Reportes();
        DAO_doctores baseD = new DAO_doctores();
        DataTable resultado = baseD.alegiareporte(int.Parse(Session["id_user"].ToString()));
        if (resultado.Rows.Count == 0)
        {
            Response.Redirect("Nohay.aspx");
        }
        DataTable data = new DataTable(); //dt
        data = datos.alergia;
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
            fila["descripcion_alergia"] = resultado.Rows[i]["descripcion"].ToString();
            fila["nombre_alergia"] = resultado.Rows[i]["nombre_alergia"].ToString();
            data.Rows.Add(fila);
        }


        return datos;
    }
}