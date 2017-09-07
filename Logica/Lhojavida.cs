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
        public String validargrid(String var, String rol)
        {
            /*este metodo valida el rol y valida el gridview para que direccione automaticamente
             si el doctor no tiene hoja de vida*/
            String direccion = null;
            if (rol != "3")
            {
                direccion = "Login.aspx";
            }
            else
            {
                if (var == "0")
                {
                    direccion = "hojavida.aspx";
                }
                else
                {
                    direccion = "editarhojavida.aspx";
                }
            }
            return direccion;
        }
        public Uhojavida agregar_hoja_vida(String bachiller, String estudios, String fellows, String idiomas, String perfil, String universidad, String experiencia, String session)
        {
            DAOhojavida datos = new DAOhojavida();
            Uhojavida encap = new Uhojavida();
            if (bachiller == "" || estudios == "" || universidad == "" || session == "")
            {
                encap.Mensaje = "debe llenar los campos requeridos";
                encap.Url = "hojavida.aspx";
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
                    encap.Url = "editarhojavida.aspx";
                }
                catch (FormatException ex)
                {
                    encap.Mensaje = "ha ocurrido un error el formato de las cadenas no es correcto";
                    encap.Url = "hojavida.aspx";
                }
            }
            return encap;
        }
    }
}
