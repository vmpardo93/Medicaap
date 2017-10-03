using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using utilitarios;

namespace Logica
{
    public class Lmedicinas
    {
        public void registromedicina(string medicina) 
        {
            DAOmedicinas bases = new DAOmedicinas();
            Umedicina datos = new Umedicina();
            datos.Medicina = medicina;
            bases.guardarmedicina(datos);
        }
    }
}
