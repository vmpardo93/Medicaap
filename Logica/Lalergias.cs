using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using utilitarios;

namespace Logica
{
   public class Lalergias
    {
     public void agregaalergia(string alergia)
       {
           DAOalergias bases = new DAOalergias();
           Ualergia datos= new Ualergia();
           datos.Alergias=alergia;
           bases.guardaralergia(datos);
 
       }
    }
}
