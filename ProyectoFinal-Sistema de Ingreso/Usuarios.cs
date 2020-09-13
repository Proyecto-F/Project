using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Sistema_de_Ingreso
{
    public class Usuarios
    {
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public int Edad { set; get; }
        public string Nacionalidad { set; get; }
        public string Id { set; get; }
        public string Genero { set; get; }
        public string Direccion { set; get; }
        public string NTelefono { set; get; }
        public string Email { set; get; }
        public string Usuario { set; get; }
        public string Contraseña {set;get;}

        public Usuarios()
        {
        }

        public Usuarios(string nombres, string apellidos, int edad, string nacionalidad, string id, string genero, string direccion, string nTelefono, string email, string usuario, string contraseña)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            Nacionalidad = nacionalidad;
            Id = id;
            Genero = genero;
            Direccion = direccion;
            NTelefono = nTelefono;
            Email = email;
            Usuario = usuario;
            Contraseña = contraseña;
        }
    }
}
