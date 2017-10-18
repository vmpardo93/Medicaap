using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using utilitarios;
using Logica;

public partial class editarhojavida : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        try
        {
            Uhojavida datos = new Uhojavida();
            Lhojavida logic = new Lhojavida();
            String valida = Convert.ToString(GV_hojavida.Rows.Count);
            LUsuarios users = new LUsuarios();
            Object nomb = Session["objdata"] as Object;
            String rol = Session["rol_user"] as String;
            String user = Session["user"] as String;
            string val = logic.validargrid(valida, rol);
            Response.Redirect(val); 
            /*
            Uhojavida datos = new Uhojavida();
            Lhojavida logic = new Lhojavida();
            LUsuarios users = new LUsuarios();
            Lobteneridioma obteneridioma= new Lobteneridioma();

            String valida =Convert.ToString(GV_hojavida.Rows.Count);
            Object nomb = Session["objdata"] as Object;
            String rol = Session["rol_user"] as String;
            String user = Session["user"] as String;
            int idformulario = 5;

            Hashtable idioma = obteneridioma.ibteneridoma(int.Parse(Session["id_idioma"].ToString()), idformulario);

            GV_hojavida.Columns[0].HeaderText = idioma["HeaderPerfilProfesional"].ToString();
            GV_hojavida.Columns[1].HeaderText=idioma["HeaderBachiller"].ToString();
            GV_hojavida.Columns[2].HeaderText = idioma["HeaderUniversidad"].ToString();
            GV_hojavida.Columns[3].HeaderText = idioma["HeaderOtrosEstudios"].ToString();
            GV_hojavida.Columns[4].HeaderText = idioma["HeaderFellows"].ToString();
            GV_hojavida.Columns[5].HeaderText = idioma["HeaderIdiomas"].ToString();
            GV_hojavida.Columns[6].HeaderText = idioma["HeaderExperiencia"].ToString();

            string val =logic.validargrid(valida,rol);
            Response.Redirect(val);  */
        }
        catch (Exception ex)
        {
 
        }
    }

}