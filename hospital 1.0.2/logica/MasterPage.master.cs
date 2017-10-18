using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DDL_idioma_selected(object sender, EventArgs e)
    {
       /* Session["id_idioma"] = DDL_idioma.SelectedValue;*/
    }
  /*  protected void DDL_idioma_selected1(object sender, EventArgs e)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(DDL_idioma.SelectedValue.ToString());
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(DDL_idioma.SelectedValue.ToString());
    }*/
}
