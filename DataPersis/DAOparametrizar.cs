using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;

namespace DataPersis
{
    public class DAOparametrizar
    {
        public DataTable mostrarparametrizacion()
        {
            DataTable parametriza = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Parametrizacion para = new Medicapp13Context.Parametrizacion();
            List<Medicapp13Context.Parametrizacion> paramelis = conect.Parametrizacions.ToList<Medicapp13Context.Parametrizacion>();
            Udatatable data= new Udatatable();
            parametriza = data.ToDataTable(paramelis);
            return parametriza;
        }
        public void editarparametrizacion(Uparametrizacion datos)
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Parametrizacion para = conect.Parametrizacions.Single(x => x.IdParemetrizacion == datos.Idparametriza);
            para.DuracionCitas =TimeSpan.Parse(datos.Duracion);
            para.HoraInicio =TimeSpan.Parse(datos.Inicio);
            para.HoraFin = TimeSpan.Parse(datos.Fin);
            conect.SubmitChanges();
        }
    }
}
