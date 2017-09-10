using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

public partial class enfermedades : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Lmedicinas logica = new Lmedicinas();
        Usuario usu = new Usuario();
        DAO_doctores bases = new DAO_doctores();
     //   bases.guardaralergia(TB_alergia.Text);
        bases.guardarcirugias(TB_cirugia.Text);
        logica.registromedicina(TB_medicina.Text);
    }
}