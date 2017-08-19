using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class vista_ReporteHv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CRS_DoctorHv.ReportDocument.SetDataSource(obtenerDatos());
        CRV_DoctorHv.ReportSource = CRS_DoctorHv;
    }
    protected DataSet obtenerDatos()
    {
        Reportes datos = new Reportes();
        DAO_doctores baseD = new DAO_doctores();
        DataTable resultado = baseD.mostrarHV(int.Parse((Session["hvdoc"].ToString())));
        if (resultado.Rows.Count == 0)
        {
            Response.Redirect("Nohay.aspx");
        }
        DataTable data = new DataTable(); //dt
        data = datos.doctor;
        DataRow fila;
        for (int i = 0; i < resultado.Rows.Count; i++)
        {
            fila = data.NewRow();

            fila["nombre"] = resultado.Rows[i]["nombre"].ToString();
            fila["apellido"] = resultado.Rows[i]["apellido"].ToString();
            fila["edad"] = resultado.Rows[i]["edad"].ToString();
            fila["estudios"] = resultado.Rows[i]["estudios"].ToString();
            fila["especialidad"] = resultado.Rows[i]["especialidad"].ToString();
            fila["imagen"] = resultado.Rows[i]["imagen"].ToString();
            fila["experiencia"] = resultado.Rows[i]["experiencia"].ToString();
            fila["fellows"] = resultado.Rows[i]["fellows"].ToString();
            fila["idiomas"] = resultado.Rows[i]["idiomas"].ToString();
            fila["otros_estudios"] = resultado.Rows[i]["otros_estudios"].ToString();
            fila["perfil_profesional"] = resultado.Rows[i]["perfil_profesional"].ToString();
            fila["universidad"] = resultado.Rows[i]["universidad"].ToString();

            data.Rows.Add(fila);
        }


        return datos;
    }
    
}