using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;
using Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Logica
{
    public class Lhojavida
    {
        public Uhojavida agregar_hoja_vida(String bachiller, String estudios, String fellows, String idiomas, String perfil, String universidad, String experiencia, String session)
        {
            DAOhojavida datos = new DAOhojavida();
            Uhojavida encap = new Uhojavida();
            if (bachiller == "" || estudios == "" || universidad == "" || session == "")
            {
                encap.Mensaje = "debe llenar los campos requeridos";
                encap.Url = "vista/hojavida.aspx";
            }
            else
            {
                try
                {
                    encap.Bachiller = bachiller;
                    encap.Estudios = estudios;
                    encap.Fellows = fellows;
                    encap.Idiomas = idiomas;
                    encap.Universidad = universidad;
                    encap.Perfil = perfil;
                    encap.Experiencia = experiencia;
                    encap.Session = session;
                    datos.guardarhojavida(encap);

                    encap.Mensaje = "hoja de vida registrada con exito";
                    encap.Url = "vista/editarhojavida.aspx";
                }
                catch (FormatException ex)
                {
                    encap.Mensaje = "ha ocurrido un error el formato de las cadenas no es correcto";
                    encap.Url = "vista/hojavida.aspx";
                }
            }
            return encap;
        }
    }
}
