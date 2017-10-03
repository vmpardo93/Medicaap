using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilitarios;
using Data;

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
            }
            return direccion;
        }
        public Uhojavida agregar_hoja_vida(String bachiller, String estudios, String fellows, String idiomas, String perfil, String universidad, String experiencia, String session)
        {
            DAOhojavida datos = new DAOhojavida();
            Uhojavida encap = new Uhojavida();
            if (bachiller == "" || estudios == "" || universidad == "" || session == "")
            {
                encap.Mensaje = "<script type='text/javascript'>alert('debe llenar los campos requeridos');window.location=\"hojavida.aspx\"</script>";
                
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

                    encap.Mensaje = "<script type='text/javascript'>alert('hoja de vida registrada con exito');window.location=\"editarhojavida.aspx\"</script>";
                }
                catch (FormatException ex)
                {
                    encap.Mensaje = "<script type='text/javascript'>alert('ha ocirrido un error en un formato');window.location=\"hojavida.aspx\"</script>";
                }
            }
            return encap;
        }
    }
}
