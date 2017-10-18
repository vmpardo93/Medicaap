using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;
using DataPersis;
using System.Data;

namespace Logica
{
    public class Lparametriza
    {
        public Uparametrizacion parametrizacitas(String duracion, String horainicio, String horafin,String duracion_citas, String hora_inicio, String hora_fin, int IdParemetrizacion) 
        {
            DAOparametrizar para = new DAOparametrizar();
            Uparametrizacion datos = new Uparametrizacion();
            datos.Inicio = hora_fin;
            datos.Fin = hora_inicio;
            datos.Duracion = duracion_citas;
            datos.Idparametriza = IdParemetrizacion;
            para.editarparametrizacion(datos);
            return datos;
        }
        public DataTable mostrarparametrizacion()
        {
            DataTable parametrizar = new DataTable();
            DAOparametrizar para = new DAOparametrizar();
            parametrizar=para.mostrarparametrizacion();
            return parametrizar;
        }
    }
}
