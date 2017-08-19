using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class enfermedades : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();
        DAO_doctores bases = new DAO_doctores();
        bases.guardaralergia(TB_alergia.Text);
        bases.guardarcirugias(TB_cirugia.Text);
        bases.guardarmedicina(TB_medicina.Text);
    }
}