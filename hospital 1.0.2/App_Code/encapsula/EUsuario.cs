using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EUsuario
/// </summary>
public class EUsuario
{
    public EUsuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    String username;

    public String Username
    {
        get { return username; }
        set { username = value; }
    }
    String clave;

    public String Clave
    {
        get { return clave; }
        set { clave = value; }
    }
    String nombre;

    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    String apellido;

    public String Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }
    String edad;

    public String Edad
    {
        get { return edad; }
        set { edad = value; }
    }
    String tiposangre;

    public String Tiposangre
    {
        get { return tiposangre; }
        set { tiposangre = value; }
    }
    String imagen;

    public String Imagen
    {
        get { return imagen; }
        set { imagen = value; }
    }
    String fechaexamen;

    public String Fechaexamen
    {
        get { return fechaexamen; }
        set { fechaexamen = value; }
    }
    int id_usuario;

    public int Id_usuario
    {
        get { return id_usuario; }
        set { id_usuario = value; }
    }
    int idrol;

    public int Idrol
    {
        get { return idrol; }
        set { idrol = value; }
    }
    private String estado;

    public String Estado
    {
        get { return estado; }
        set { estado = value; }
    }
    String documento;

    public String Documento
    {
        get { return documento; }
        set { documento = value; }
    }

    String foto;

    public String Foto
    {
        get { return foto; }
        set { foto = value; }
    }
    String correo;

    public String Correo
    {
        get { return correo; }
        set { correo = value; }
    }
}