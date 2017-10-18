using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;

namespace DataPersis
{
    public class DAOhorarios
    {
        public void guardarhorariodoc(Uhorario datos)
        {
            
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            DateTime inicio= Convert.ToDateTime(datos.Inicio);
            DateTime fin = Convert.ToDateTime(datos.Fin);
            conect.FGenerarHorario(inicio,
                                   fin,
                                   datos.Horario,
                                   int.Parse(datos.Iddoctor)).ToString();

        }
        public DataTable mostrarhorario(Uhorario datos)
        {
            DataTable data = new DataTable();
            Udatatable datatable = new Udatatable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            var horario = conect.FBuscaHorario(int.Parse(datos.Iddoctor)).ToList();
            data = datatable.ToDataTable(horario);
            return data;
        }
        public void editarhorario(Uhorario datos)
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            conect.FModificarHorario(Convert.ToDateTime(datos.Inicio),
                                     Convert.ToDateTime(datos.Fin),
                                     datos.Horario,
                                     int.Parse(datos.Iddoctor)).ToString();
        }
    }
}
