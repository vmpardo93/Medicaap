using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using utilitarios;
using DataPersis;

namespace Logica
{
   public class Lalergias
    {
     public void agregaalergia(string alergia)
       {
           DAOalergia bases = new DAOalergia();
           Ualergia datos= new Ualergia();
           datos.Alergias=alergia;
           bases.guardaralergia(datos);
 
       }
    }
}
