using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;

namespace DataPersis
{
    public class DAOusuario
    {
        public DataTable login(UUsuario datos)
        {
            DataTable data = new DataTable();
            Udatatable datatable = new Udatatable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            List<Medicapp13Context.UserLogginView> user = conect.FLoggin(datos.Username, datos.Clave, datos.Ip, datos.Mac).ToList<Medicapp13Context.UserLogginView>();
            data = datatable.ToDataTable(user);
            conect.SubmitChanges();
            return data;
        }
        public void session(UUsuario datos) 
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            conect.FRestarSession(datos.Id_usuario);
        }
    }
}
