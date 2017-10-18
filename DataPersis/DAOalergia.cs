using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;
using System.Xml.Linq;
using System.Data.Linq;
using System.Data;
using System.Reflection;


namespace DataPersis
{
   public class DAOalergia
    {
        public void guardaralergia(Ualergia datos) 
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Alergia alergia = new Medicapp13Context.Alergia();
            alergia.NombreAlergia = datos.Alergias;
            
            conect.Alergias.InsertOnSubmit(alergia);
            conect.SubmitChanges();
        }
        public DataTable mostraralergiasAdmon() 
        {
            DataTable alergias = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Alergia alergia = new Medicapp13Context.Alergia();
            List<Medicapp13Context.Alergia> aler = conect.Alergias.ToList<Medicapp13Context.Alergia>();
            Udatatable data = new Udatatable();
            alergias = data.ToDataTable(aler);
            
            return alergias;
        }
    }
}
