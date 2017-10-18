using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;

namespace DataPersis
{
    public class DAOcita
    {
        public DataTable mostrarcitasdoc(Ucitas datos)
        {
            Udatatable datatable= new Udatatable();
            DateTime thisDay = DateTime.Today;
            DataTable data = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            var cita = (from c in conect.Citas
                        join p in conect.Usuarios/*tengo que preguntarle al profe no se porque join error*/
                        on c.PacienteId equals p.IdUsuario
                        where (c.HoraInicio>=thisDay)
                        && (c.HoraFin>=thisDay)
                        && (c.Estado==1)
                        && (c.DoctorId==int.Parse(datos.Iddoctor))
                        orderby c.HoraInicio
                        select new
                        {
                            c.HoraInicio,
                            c.HoraFin,
                            p.Nombre,
                            p.Apellido,
                            c.DoctorId,
                            c.IdCita,
                        }).ToList();
            data = datatable.ToDataTable(cita);
            return data;
        }
        public void guardacita(Ucitas datos) 
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            conect.FAddCitadoctor3(datos.Diagnostico,
                                   int.Parse(datos.Iddoctor),
                                   int.Parse(datos.Idcita),
                                   datos.Cirugia,
                                   datos.Descripcioncirugia,
                                   datos.Fechacirugia,
                                   int.Parse(datos.Medicinas),
                                   int.Parse(datos.Dosis),
                                   datos.Fechafinmedicina).ToString();
        }
        public void guardarcita2(Ucitas datos) 
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            conect.FAddCitadoctor2(datos.Diagnostico, 
                                   int.Parse(datos.Iddoctor),
                                   int.Parse(datos.Idcita),
                                   int.Parse(datos.Alergia),
                                   datos.Descripcionalergia,
                                   int.Parse(datos.Medicinas),
                                   int.Parse(datos.Dosis),
                                   datos.Fechafinmedicina).ToString();
        }
        public void guardarcita3(Ucitas datos) 
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            conect.FAddCitadoctor4(datos.Diagnostico,
                                   int.Parse(datos.Iddoctor),
                                   int.Parse(datos.Idcita),
                                   int.Parse(datos.Medicinas),
                                   int.Parse(datos.Dosis),
                                   datos.Fechafinmedicina).ToString();
        }
        public void guardarcitaactual(Ucitas datos) 
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            conect.FAddCitadoctor(datos.Diagnostico,
                                  int.Parse(datos.Iddoctor),
                                  int.Parse(datos.Idcita),
                                  int.Parse(datos.Alergia),
                                  datos.Descripcionalergia,
                                  datos.Cirugia,
                                  datos.Descripcioncirugia, 
                                  datos.Fechacirugia,
                                  int.Parse(datos.Medicinas),
                                  int.Parse(datos.Dosis),
                                  datos.Fechafinmedicina).ToString();
            
        }
        public DataTable mostrarcitasseparadas(Ucitas datos)
        {
            Udatatable data = new Udatatable();
            DataTable datatable = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            DateTime hoy= DateTime.Today;
            DateTime masdos= hoy.AddDays(2);
            var citasseparadas = (from c in conect.Citas
                                  join u in conect.Usuarios
                                  on c.DoctorId equals u.IdUsuario
                                  where (c.PacienteId == datos.Idpaciente) && (c.Estado == 1) && (c.HoraInicio.Value.Date > masdos)
                                  select new
                                  {
                                      c.IdCita,
                                      c.Tipo,
                                      c.HoraInicio,
                                      c.HoraFin,
                                      c.Diagnostico,
                                      u.Nombre,
                                      u.Apellido
                                  }).ToList();
            datatable = data.ToDataTable(citasseparadas);
            return datatable;
        }
        public void cancelarCitaUsuario(Ucitas datos)
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Cita cita = conect.Citas.Single(x => x.IdCita == int.Parse(datos.Idcita));
            cita.PacienteId = 0;
            cita.Estado = 0;
            conect.SubmitChanges();
        }
        public DataTable buscarcitaid(Ucitas datos)
        {
            Udatatable data = new Udatatable();
            DataTable cita = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            var citasseparadas = (from c in conect.Citas
                                  join u in conect.Usuarios
                                  on c.DoctorId equals u.IdUsuario
                                  where (c.PacienteId == datos.Idpaciente)
                                  select new
                                  {
                                      c.IdCita,
                                      c.Tipo,
                                      c.HoraInicio,
                                      c.HoraFin,
                                      c.Diagnostico,
                                      u.Nombre,
                                      u.Apellido
                                  }).ToList();
            cita = data.ToDataTable(citasseparadas);
            return cita;
        }
        public DataTable buscarcitasD(Ucitas datos)
        {
            DataTable datatable = new DataTable();
            Udatatable data = new Udatatable();
            Medicapp13Context.Medicapp13DataContext conect= new Medicapp13Context.Medicapp13DataContext();
            var cita = (from c in conect.Citas
                        join u in conect.Usuarios
                        on c.DoctorId equals u.IdUsuario
                        where (c.HoraInicio.Value.Date == datos.Fechacita.Date)
                        && (c.Estado == 0)
                        && (datos.Fechacita.Date > DateTime.Today)
                        select new
                        {
                            c.IdCita,
                            c.Tipo,
                            u.Nombre,
                            u.Apellido,
                            c.HoraInicio,
                            c.HoraFin
                        }).ToList();
            datatable = data.ToDataTable(cita);
            return datatable;
        }

        public DataTable obtenerfechas()
        {
            DataTable data = new DataTable();
            Udatatable datatable = new Udatatable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            var fecha = (from c in conect.Citas
                         where (c.Estado == 0)
                         && (c.HoraInicio > DateTime.Today.Date)
                         select c.HoraInicio).ToList();
            data = datatable.ToDataTable(fecha);
            return data;
        }
        public void sacarCita(Ucitas datos)
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.Cita cita = conect.Citas.Single(x => x.IdCita == int.Parse(datos.Idcita));
            cita.PacienteId = datos.Idpaciente;
            cita.Estado = 1;
            conect.SubmitChanges();
        }
        public DataTable verificarCita(Ucitas datos)
        {
            DataTable datatable = new DataTable();
            Udatatable data=new Udatatable();
            Medicapp13Context.Medicapp13DataContext conect =new Medicapp13Context.Medicapp13DataContext();
            List<Medicapp13Context.VerificacitaView>cita=conect.FVerificarCita(int.Parse(datos.Idcita),datos.Idpaciente).ToList<Medicapp13Context.VerificacitaView>();
            datatable = data.ToDataTable(cita);
            return datatable;
        }
    }
}
