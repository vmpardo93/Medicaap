using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    private int id_usuario;

    public int Id_usuario
    {
        get { return id_usuario; }
        set { id_usuario = value; }
    }
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    private string estado;

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }
    private string apellido;

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }
    private string edad;

    public string Edad
    {
        get { return edad; }
        set { edad = value; }
    }
    private string username;

    public string Username
    {
        get { return username; }
        set { username = value; }
    }
    private string tipo_de_sangre;

    public string Tipo_de_sangre
    {
        get { return tipo_de_sangre; }
        set { tipo_de_sangre = value; }
    }
    private string fecha_ultimo_examen;

    public string Fecha_ultimo_examen
    {
        get { return fecha_ultimo_examen; }
        set { fecha_ultimo_examen = value; }
    }
    private string estudios;

    public string Estudios
    {
        get { return estudios; }
        set { estudios = value; }
    }
    private string especialidad;

    public string Especialidad
    {
        get { return especialidad; }
        set { especialidad = value; }
    }
    private int rol;

    public int Rol
    {
        get { return rol; }
        set { rol = value; }
    }
    private string direccionImagen;

    public string DireccionImagen
    {
        get { return direccionImagen; }
        set { direccionImagen = value; }
    }
	public Usuario()
	{
		
	}
}