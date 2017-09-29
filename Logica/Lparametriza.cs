using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;

namespace Logica
{
    public class Lparametriza
    {
        public Uparametrizacion parametrizacitas(String duracion, String horainicio, String horafin) 
        {
            Uparametrizacion datos = new Uparametrizacion();
            datos.Inicio = horainicio;
            datos.Fin = horafin;
            datos.Duracion = duracion;
            return datos;
        }
    }
}
