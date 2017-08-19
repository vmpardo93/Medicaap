using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;
using utilitarios;

namespace Logica
{
    class Bases_Datos_Doctor
    {
        public DataTable obtenerdoctores (){

            DAOdoctores dao = new DAOdoctores();
            return dao.mostrarDoctoresPrincipal();
            
        }


    }
}
