using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;
using System.Xml.Linq;
using System.Data.Linq;
using System.Data;
using utilitarios;

namespace DataPersis
{
    public class DAOmedicina
    {
        public void guardarmedicina(Umedicina datos) 
        {
            Medicapp13Context.Medicapp13DataContext conec = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Medicina medicina = new Medicapp13Context.Medicina();
            medicina.NombreMedicina = datos.Medicina;
            conec.Medicinas.InsertOnSubmit(medicina);
            conec.SubmitChanges();
        }
        public DataTable mostrarmedicinas()
        {
            DataTable medicina = new DataTable();
            Medicapp13Context.Medicapp13DataContext conec = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Medicina medicinas = new Medicapp13Context.Medicina();
            List<Medicapp13Context.Medicina> med = conec.Medicinas.ToList<Medicapp13Context.Medicina>();
            Udatatable data = new Udatatable();
            medicina=data.ToDataTable(med);
            
            return medicina;
        }
    }
}
