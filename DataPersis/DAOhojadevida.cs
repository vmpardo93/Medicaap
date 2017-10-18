using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;

namespace DataPersis
{
    public class DAOhojadevida
    {
        public void guardarhojavida(Uhojavida datos)
        {/*este metodo guarda la hoja de vida del doctor cuando el la ingrese*/
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.HojaDeVida hoja = new Medicapp13Context.HojaDeVida();
            hoja.PerfilProfesional = datos.Perfil;
            hoja.Bachiller = datos.Bachiller;
            hoja.Universidad = datos.Universidad;
            hoja.OtrosEstudios = datos.Estudios;
            hoja.Fellows = datos.Fellows;
            hoja.Idiomas = datos.Idiomas;
            hoja.Experiencia = datos.Experiencia;
            hoja.IdDoctor = int.Parse(datos.Session);
            conect.HojaDeVidas.InsertOnSubmit(hoja);
            conect.SubmitChanges();
        }
        public DataTable buscarhojavida(Uhojavida datos)
        {
            DataTable hv = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.HojaDeVida hojavida = new Medicapp13Context.HojaDeVida();
            List<Medicapp13Context.HojaDeVida> hoja = conect.HojaDeVidas.Where(x => x.IdDoctor == int.Parse(datos.Id_doctor)).ToList<Medicapp13Context.HojaDeVida>();
            Udatatable data = new Udatatable();
            hv = data.ToDataTable(hoja);
            return hv;
        }
        public void modificarhojavida(Uhojavida datos)
        {
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.HojaDeVida hoja = conect.HojaDeVidas.Single(x => x.IdDoctor == int.Parse(datos.Id_doctor));
            hoja.PerfilProfesional = datos.Perfil;
            hoja.Bachiller = datos.Bachiller;
            hoja.Universidad = datos.Universidad;
            hoja.OtrosEstudios = datos.Estudios;
            hoja.Fellows = datos.Fellows;
            hoja.Idiomas = datos.Idiomas;
            hoja.Experiencia = datos.Experiencia;
            conect.SubmitChanges();
        }
        public DataTable mostrarHV(int id_doctor)
            /*metodo de victor que tengo que saber  de que es porque nose y lo tenia en otra clase a la que no pertencia*/
        {
            Udatatable data = new Udatatable();
            DataTable hoja = new DataTable();
            Medicapp13Context.Medicapp13DataContext conect = new Medicapp13Context.Medicapp13DataContext();
            Medicapp13Context.HojaDeVida hojavida = new Medicapp13Context.HojaDeVida();
            List<Medicapp13Context.HojaDeVida> hv = conect.HojaDeVidas.Where(x => x.IdDoctor == id_doctor).ToList<Medicapp13Context.HojaDeVida>();
            hoja = data.ToDataTable(hv);
            return hoja;
        }
    }
}
