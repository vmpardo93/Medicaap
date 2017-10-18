using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilitarios
{
    public class Uparametrizacion
    {
        private int idparametriza;

        public int Idparametriza
        {
            get { return idparametriza; }
            set { idparametriza = value; }
        }
        private String inicio;

        public String Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        private String fin;

        public String Fin
        {
            get { return fin; }
            set { fin = value; }
        }
        private String duracion;

        public String Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
    }
}
