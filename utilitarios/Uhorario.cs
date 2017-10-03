using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilitarios
{
    public class Uhorario
    {
        private Boolean ver;

        public Boolean Ver
        {
            get { return ver; }
            set { ver = value; }
        }
        private String url;

        public String Url
        {
            get { return url; }
            set { url = value; }
        }
        private String mensaje;

        public String Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
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

  
        private String horario;

        public String Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        private String iddoctor;

        public String Iddoctor
        {
            get { return iddoctor; }
            set { iddoctor = value; }
        }
    }
}
